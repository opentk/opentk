#region License
//
// LinuxGraphicsContext.cs
//
// Author:
//       thefiddler <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Platform.Linux
{
    /// \internal
    /// <summary>
    /// Defines an IGraphicsContext implementation for the Linux KMS framebuffer.
    /// For Linux/X11 and other Unix operating systems, use the more generic
    /// <see cref="OpenTK.Platform.Egl.EglUnixContext"/> instead.
    /// </summary>
    /// <remarks>
    /// Note: to display our results, we need to allocate a GBM framebuffer
    /// and point the scanout address to that via Drm.ModeSetCrtc.
    /// </remarks>
    class LinuxGraphicsContext : Egl.EglUnixContext
    {
        BufferObject bo, bo_next;
        int fd;
        bool is_flip_queued;
        int swap_interval;

        public LinuxGraphicsContext(GraphicsMode mode, LinuxWindowInfo window, IGraphicsContext sharedContext,
            int major, int minor, GraphicsContextFlags flags)
            : base(mode, window, sharedContext, major, minor, flags)
        {
            if (mode.Buffers < 1)
                throw new ArgumentException();
            fd = window.FD;

            PageFlip = HandlePageFlip;
            PageFlipPtr = Marshal.GetFunctionPointerForDelegate(PageFlip);
        }

        public override void SwapBuffers()
        {
            base.SwapBuffers();

            bo_next = LockSurface();
            int fb = GetFramebuffer(bo_next);

            if (is_flip_queued)
            {
                // Todo: if we don't wait for the page flip,
                // we drop all rendering buffers and get a crash
                // in Egl.SwapBuffers(). We need to fix that
                // before we can disable vsync.
                WaitFlip(true); // WaitFlip(SwapInterval > 0)
                if (is_flip_queued)
                {
                    Debug.Print("[KMS] Dropping frame");
                    return;
                }
            }

            QueueFlip(fb);
        }

        public override void Update(IWindowInfo window)
        {
            WaitFlip(true);

            base.SwapBuffers();

            bo = LockSurface();
            int fb = GetFramebuffer(bo);
            SetScanoutRegion(fb);
        }

        public override int SwapInterval
        {
            get
            {
                return swap_interval;
            }
            set
            {
                // We only support a SwapInterval of 0 (immediate)
                // or 1 (vsynced).
                // Todo: add support for SwapInterval of -1 (adaptive).
                // This requires a small change in WaitFlip().
                swap_interval = MathHelper.Clamp(value, 0, 1);
            }
        }

        void WaitFlip(bool block)
        {
            PollFD fds = new PollFD();
            fds.fd = fd;
            fds.events = PollFlags.In;

            EventContext evctx = new EventContext();
            evctx.version = EventContext.Version;
            evctx.page_flip_handler = PageFlipPtr;

            int timeout = block ? -1 : 0;

            while (is_flip_queued)
            {
                fds.revents = 0;
                if (Libc.poll(ref fds, 1, timeout) < 0)
                    break;

                if ((fds.revents & (PollFlags.Hup | PollFlags.Error)) != 0)
                    break;

                if ((fds.revents & PollFlags.In) != 0)
                    Drm.HandleEvent(fd, ref evctx);
                else
                    break;
            }

            // Page flip has taken place, update buffer objects
            if (!is_flip_queued)
            {
                IntPtr gbm_surface = WindowInfo.Handle;
                Gbm.ReleaseBuffer(gbm_surface, bo);
                bo = bo_next;
            }
        }

        void QueueFlip(int buffer)
        {
            LinuxWindowInfo wnd = WindowInfo as LinuxWindowInfo;
            if (wnd == null)
                throw new InvalidOperationException();

            unsafe
            {
                int ret = Drm.ModePageFlip(fd, wnd.DisplayDevice.Id, buffer,
                    PageFlipFlags.FlipEvent, IntPtr.Zero);

                if (ret < 0)
                {
                    Debug.Print("[KMS] Failed to enqueue framebuffer flip. Error: {0}", ret);
                }

                is_flip_queued = true;
            }
        }

        void SetScanoutRegion(int buffer)
        {
            LinuxWindowInfo wnd = WindowInfo as LinuxWindowInfo;
            if (wnd == null)
                throw new InvalidOperationException();

            unsafe
            {
                ModeInfo* mode = wnd.DisplayDevice.pConnector->modes;
                int connector_id = wnd.DisplayDevice.pConnector->connector_id;
                int crtc_id = wnd.DisplayDevice.Id;

                int x = 0;
                int y = 0;
                int connector_count = 1;
                int ret = Drm.ModeSetCrtc(fd, crtc_id, buffer, x, y,
                    &connector_id, connector_count, mode);

                if (ret != 0)
                {
                    Debug.Print("[KMS] Drm.ModeSetCrtc{0}, {1}, {2}, {3}, {4:x}, {5}, {6:x}) failed. Error: {7}",
                        fd, crtc_id, buffer, x, y, (IntPtr)connector_id, connector_count, (IntPtr)mode, ret);
                }
            }
        }

        BufferObject LockSurface()
        {
            IntPtr gbm_surface = WindowInfo.Handle;
            return Gbm.LockFrontBuffer(gbm_surface);
        }

        int GetFramebuffer(BufferObject bo)
        {
            if (bo == BufferObject.Zero)
                goto fail;

            int bo_handle = bo.Handle;
            if (bo_handle == 0)
            {
                Debug.Print("[KMS] Gbm.BOGetHandle({0:x}) failed.", bo);
                goto fail;
            }

            int width = bo.Width;
            int height = bo.Height;
            int bpp = Mode.ColorFormat.BitsPerPixel;
            int depth = Mode.Depth;
            int stride = bo.Stride;

            if (width == 0 || height == 0 || bpp == 0)
            {
                Debug.Print("[KMS] Invalid framebuffer format: {0}x{1} {2} {3} {4}",
                    width, height, stride, bpp, depth);
                goto fail;
            }

            int buffer;
            int ret = Drm.ModeAddFB(
                fd, width, height,
                (byte)depth, (byte)bpp, stride, bo_handle,
                out buffer);
            if (ret != 0)
            {
                Debug.Print("[KMS] Drm.ModeAddFB({0}, {1}, {2}, {3}, {4}, {5}, {6}) failed. Error: {7}",
                    fd, width, height, depth, bpp, stride, bo_handle, ret);
                goto fail;
            }

            bo.SetUserData((IntPtr)buffer, DestroyFB);
            return buffer;

            fail:
            Debug.Print("[Error] Failed to create framebuffer.");
            return -1;
        }

        readonly IntPtr PageFlipPtr;
        readonly PageFlipCallback PageFlip;
        void HandlePageFlip(int fd,
            int sequence,
            int tv_sec,
            int tv_usec,
            IntPtr user_data)
        {
            is_flip_queued = false;
        }

        static readonly DestroyUserDataCallback DestroyFB = HandleDestroyFB;
        static void HandleDestroyFB(BufferObject bo, IntPtr data)
        {
            IntPtr gbm = bo.Device;
            int fb = data.ToInt32();
            Debug.Print("[KMS] Destroying framebuffer {0}", fb);

            if (fb != 0)
            {
                Drm.ModeRmFB(Gbm.DeviceGetFD(gbm), fb);
            }
        }

        protected override void Dispose(bool manual)
        {
            if (manual)
            {
                // Reset the scanout region
                LinuxWindowInfo wnd = WindowInfo as LinuxWindowInfo;
                if (wnd != null)
                {
                    unsafe
                    {
                        int connector_id = wnd.DisplayDevice.pConnector->connector_id;
                        ModeInfo mode = wnd.DisplayDevice.OriginalMode;
                        Drm.ModeSetCrtc(fd,
                            wnd.DisplayDevice.pCrtc->crtc_id,
                            wnd.DisplayDevice.pCrtc->buffer_id,
                            wnd.DisplayDevice.pCrtc->x,
                            wnd.DisplayDevice.pCrtc->y,
                            &connector_id,
                            1,
                            &mode);
                    }
                }
            }
            base.Dispose(manual);
        }
    }
}




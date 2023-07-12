// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;
using OpenTK.Graphics;

namespace OpenTK.Graphics.Glx
{
    public static unsafe partial class GLX
    {
        /// <inheritdoc cref="ChooseFBConfig(Display*, int, int*, int*)"/>
        public static unsafe GLXFBConfig* ChooseFBConfig(ref Display dpy, int screen, in int attrib_list, ref int nelements)
        {
            GLXFBConfig* returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (int* attrib_list_ptr = &attrib_list)
            fixed (int* nelements_ptr = &nelements)
            {
                returnValue = ChooseFBConfig(dpy_ptr, screen, attrib_list_ptr, nelements_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="ChooseVisual(Display*, int, int*)"/>
        public static unsafe XVisualInfo* ChooseVisual(ref Display dpy, int screen, ref int attribList)
        {
            XVisualInfo* returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (int* attribList_ptr = &attribList)
            {
                returnValue = ChooseVisual(dpy_ptr, screen, attribList_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CopyContext(Display*, GLXContext, GLXContext, ulong)"/>
        public static unsafe void CopyContext(ref Display dpy, GLXContext src, GLXContext dst, ulong mask)
        {
            fixed (Display* dpy_ptr = &dpy)
            {
                CopyContext(dpy_ptr, src, dst, mask);
            }
        }
        /// <inheritdoc cref="CreateContext(Display*, XVisualInfo*, GLXContext, bool)"/>
        public static unsafe GLXContext CreateContext(ref Display dpy, ref XVisualInfo vis, GLXContext shareList, bool direct)
        {
            GLXContext returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (XVisualInfo* vis_ptr = &vis)
            {
                returnValue = CreateContext(dpy_ptr, vis_ptr, shareList, direct);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateGLXPixmap(Display*, XVisualInfo*, Pixmap)"/>
        public static unsafe GLXPixmap CreateGLXPixmap(ref Display dpy, ref XVisualInfo visual, Pixmap pixmap)
        {
            GLXPixmap returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (XVisualInfo* visual_ptr = &visual)
            {
                returnValue = CreateGLXPixmap(dpy_ptr, visual_ptr, pixmap);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateNewContext(Display*, GLXFBConfig, int, GLXContext, bool)"/>
        public static unsafe GLXContext CreateNewContext(ref Display dpy, GLXFBConfig config, int render_type, GLXContext share_list, bool direct)
        {
            GLXContext returnValue;
            fixed (Display* dpy_ptr = &dpy)
            {
                returnValue = CreateNewContext(dpy_ptr, config, render_type, share_list, direct);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePbuffer(Display*, GLXFBConfig, int*)"/>
        public static unsafe GLXPbuffer CreatePbuffer(ref Display dpy, GLXFBConfig config, in int attrib_list)
        {
            GLXPbuffer returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreatePbuffer(dpy_ptr, config, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePixmap(Display*, GLXFBConfig, Pixmap, int*)"/>
        public static unsafe GLXPixmap CreatePixmap(ref Display dpy, GLXFBConfig config, Pixmap pixmap, in int attrib_list)
        {
            GLXPixmap returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreatePixmap(dpy_ptr, config, pixmap, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateWindow(Display*, GLXFBConfig, Window, int*)"/>
        public static unsafe GLXWindow CreateWindow(ref Display dpy, GLXFBConfig config, Window win, in int attrib_list)
        {
            GLXWindow returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreateWindow(dpy_ptr, config, win, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="DestroyContext(Display*, GLXContext)"/>
        public static unsafe void DestroyContext(ref Display dpy, GLXContext ctx)
        {
            fixed (Display* dpy_ptr = &dpy)
            {
                DestroyContext(dpy_ptr, ctx);
            }
        }
        /// <inheritdoc cref="DestroyGLXPixmap(Display*, GLXPixmap)"/>
        public static unsafe void DestroyGLXPixmap(ref Display dpy, GLXPixmap pixmap)
        {
            fixed (Display* dpy_ptr = &dpy)
            {
                DestroyGLXPixmap(dpy_ptr, pixmap);
            }
        }
        /// <inheritdoc cref="DestroyPbuffer(Display*, GLXPbuffer)"/>
        public static unsafe void DestroyPbuffer(ref Display dpy, GLXPbuffer pbuf)
        {
            fixed (Display* dpy_ptr = &dpy)
            {
                DestroyPbuffer(dpy_ptr, pbuf);
            }
        }
        /// <inheritdoc cref="DestroyPixmap(Display*, GLXPixmap)"/>
        public static unsafe void DestroyPixmap(ref Display dpy, GLXPixmap pixmap)
        {
            fixed (Display* dpy_ptr = &dpy)
            {
                DestroyPixmap(dpy_ptr, pixmap);
            }
        }
        /// <inheritdoc cref="DestroyWindow(Display*, GLXWindow)"/>
        public static unsafe void DestroyWindow(ref Display dpy, GLXWindow win)
        {
            fixed (Display* dpy_ptr = &dpy)
            {
                DestroyWindow(dpy_ptr, win);
            }
        }
        /// <inheritdoc cref="GetClientString(Display*, int)"/>
        public static unsafe string? GetClientString(ref Display dpy, int name)
        {
            string? returnValue_str;
            fixed (Display* dpy_ptr = &dpy)
            {
                byte* returnValue;
                returnValue = GetClientString(dpy_ptr, name);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            }
            return returnValue_str;
        }
        /// <inheritdoc cref="GetConfig(Display*, XVisualInfo*, int, int*)"/>
        public static unsafe int GetConfig(ref Display dpy, ref XVisualInfo visual, int attrib, ref int value)
        {
            int returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (XVisualInfo* visual_ptr = &visual)
            fixed (int* value_ptr = &value)
            {
                returnValue = GetConfig(dpy_ptr, visual_ptr, attrib, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetFBConfigAttrib(Display*, GLXFBConfig, int, int*)"/>
        public static unsafe int GetFBConfigAttrib(ref Display dpy, GLXFBConfig config, int attribute, ref int value)
        {
            int returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (int* value_ptr = &value)
            {
                returnValue = GetFBConfigAttrib(dpy_ptr, config, attribute, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetFBConfigs(Display*, int, int*)"/>
        public static unsafe GLXFBConfig* GetFBConfig(ref Display dpy, int screen, ref int nelements)
        {
            GLXFBConfig* returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (int* nelements_ptr = &nelements)
            {
                returnValue = GetFBConfigs(dpy_ptr, screen, nelements_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProcAddress(byte*)"/>
        public static unsafe IntPtr GetProcAddress(in byte procName)
        {
            IntPtr returnValue;
            fixed (byte* procName_ptr = &procName)
            {
                returnValue = GetProcAddress(procName_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetSelectedEvent(Display*, GLXDrawable, ulong*)"/>
        public static unsafe void GetSelectedEvent(ref Display dpy, GLXDrawable draw, ref ulong event_mask)
        {
            fixed (Display* dpy_ptr = &dpy)
            fixed (ulong* event_mask_ptr = &event_mask)
            {
                GetSelectedEvent(dpy_ptr, draw, event_mask_ptr);
            }
        }
        /// <inheritdoc cref="GetVisualFromFBConfig(Display*, GLXFBConfig)"/>
        public static unsafe XVisualInfo* GetVisualFromFBConfig(ref Display dpy, GLXFBConfig config)
        {
            XVisualInfo* returnValue;
            fixed (Display* dpy_ptr = &dpy)
            {
                returnValue = GetVisualFromFBConfig(dpy_ptr, config);
            }
            return returnValue;
        }
        /// <inheritdoc cref="IsDirect(Display*, GLXContext)"/>
        public static unsafe bool IsDirect(ref Display dpy, GLXContext ctx)
        {
            bool returnValue;
            fixed (Display* dpy_ptr = &dpy)
            {
                returnValue = IsDirect(dpy_ptr, ctx);
            }
            return returnValue;
        }
        /// <inheritdoc cref="MakeContextCurrent(Display*, GLXDrawable, GLXDrawable, GLXContext)"/>
        public static unsafe bool MakeContextCurrent(ref Display dpy, GLXDrawable draw, GLXDrawable read, GLXContext ctx)
        {
            bool returnValue;
            fixed (Display* dpy_ptr = &dpy)
            {
                returnValue = MakeContextCurrent(dpy_ptr, draw, read, ctx);
            }
            return returnValue;
        }
        /// <inheritdoc cref="MakeCurrent(Display*, GLXDrawable, GLXContext)"/>
        public static unsafe bool MakeCurrent(ref Display dpy, GLXDrawable drawable, GLXContext ctx)
        {
            bool returnValue;
            fixed (Display* dpy_ptr = &dpy)
            {
                returnValue = MakeCurrent(dpy_ptr, drawable, ctx);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryContext(Display*, GLXContext, int, int*)"/>
        public static unsafe int QueryContext(ref Display dpy, GLXContext ctx, int attribute, ref int value)
        {
            int returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (int* value_ptr = &value)
            {
                returnValue = QueryContext(dpy_ptr, ctx, attribute, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryDrawable(Display*, GLXDrawable, int, uint*)"/>
        public static unsafe void QueryDrawable(ref Display dpy, GLXDrawable draw, int attribute, ref uint value)
        {
            fixed (Display* dpy_ptr = &dpy)
            fixed (uint* value_ptr = &value)
            {
                QueryDrawable(dpy_ptr, draw, attribute, value_ptr);
            }
        }
        /// <inheritdoc cref="QueryExtension(Display*, int*, int*)"/>
        public static unsafe bool QueryExtension(ref Display dpy, ref int errorb, ref int @event)
        {
            bool returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (int* errorb_ptr = &errorb)
            fixed (int* @event_ptr = &@event)
            {
                returnValue = QueryExtension(dpy_ptr, errorb_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryExtensionsString(Display*, int)"/>
        public static unsafe string? QueryExtensionsString(ref Display dpy, int screen)
        {
            string? returnValue_str;
            fixed (Display* dpy_ptr = &dpy)
            {
                byte* returnValue;
                returnValue = QueryExtensionsString(dpy_ptr, screen);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            }
            return returnValue_str;
        }
        /// <inheritdoc cref="QueryServerString(Display*, int, int)"/>
        public static unsafe string? QueryServerString(ref Display dpy, int screen, int name)
        {
            string? returnValue_str;
            fixed (Display* dpy_ptr = &dpy)
            {
                byte* returnValue;
                returnValue = QueryServerString(dpy_ptr, screen, name);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            }
            return returnValue_str;
        }
        /// <inheritdoc cref="QueryVersion(Display*, int*, int*)"/>
        public static unsafe bool QueryVersion(ref Display dpy, ref int maj, ref int min)
        {
            bool returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (int* maj_ptr = &maj)
            fixed (int* min_ptr = &min)
            {
                returnValue = QueryVersion(dpy_ptr, maj_ptr, min_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SelectEvent(Display*, GLXDrawable, ulong)"/>
        public static unsafe void SelectEvent(ref Display dpy, GLXDrawable draw, ulong event_mask)
        {
            fixed (Display* dpy_ptr = &dpy)
            {
                SelectEvent(dpy_ptr, draw, event_mask);
            }
        }
        /// <inheritdoc cref="SwapBuffers(Display*, GLXDrawable)"/>
        public static unsafe void SwapBuffers(ref Display dpy, GLXDrawable drawable)
        {
            fixed (Display* dpy_ptr = &dpy)
            {
                SwapBuffers(dpy_ptr, drawable);
            }
        }
        public static unsafe partial class AMD
        {
            /// <inheritdoc cref="CreateAssociatedContextAttribsAMD(uint, GLXContext, int*)"/>
            public static unsafe GLXContext CreateAssociatedContextAttribsAMD(uint id, GLXContext share_context, in int attribList)
            {
                GLXContext returnValue;
                fixed (int* attribList_ptr = &attribList)
                {
                    returnValue = CreateAssociatedContextAttribsAMD(id, share_context, attribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGPUIDsAMD(uint, uint*)"/>
            public static unsafe uint GetGPUIDsAMD(uint maxCount, ref uint ids)
            {
                uint returnValue;
                fixed (uint* ids_ptr = &ids)
                {
                    returnValue = GetGPUIDsAMD(maxCount, ids_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGPUInfoAMD(uint, int, All, uint, void*)"/>
            public static unsafe int GetGPUInfoAMD(uint id, int property, All dataType, uint size, IntPtr data)
            {
                int returnValue;
                void* data_vptr = (void*)data;
                returnValue = GetGPUInfoAMD(id, property, dataType, size, data_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="GetGPUInfoAMD(uint, int, All, uint, void*)"/>
            public static unsafe int GetGPUInfoAMD<T1>(uint id, int property, All dataType, uint size, ref T1 data)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* data_ptr = &data)
                {
                    returnValue = GetGPUInfoAMD(id, property, dataType, size, data_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class ARB
        {
            /// <inheritdoc cref="CreateContextAttribsARB(Display*, GLXFBConfig, GLXContext, bool, int*)"/>
            public static unsafe GLXContext CreateContextAttribsARB(ref Display dpy, GLXFBConfig config, GLXContext share_context, bool direct, in int attrib_list)
            {
                GLXContext returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateContextAttribsARB(dpy_ptr, config, share_context, direct, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetProcAddressARB(byte*)"/>
            public static unsafe IntPtr GetProcAddressARB(in byte procName)
            {
                IntPtr returnValue;
                fixed (byte* procName_ptr = &procName)
                {
                    returnValue = GetProcAddressARB(procName_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class EXT
        {
            /// <inheritdoc cref="BindTexImageEXT(Display*, GLXDrawable, int, int*)"/>
            public static unsafe void BindTexImageEXT(ref Display dpy, GLXDrawable drawable, int buffer, in int attrib_list)
            {
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    BindTexImageEXT(dpy_ptr, drawable, buffer, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="FreeContextEXT(Display*, GLXContext)"/>
            public static unsafe void FreeContextEXT(ref Display dpy, GLXContext context)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    FreeContextEXT(dpy_ptr, context);
                }
            }
            /// <inheritdoc cref="ImportContextEXT(Display*, GLXContextID)"/>
            public static unsafe GLXContext ImportContextEXT(ref Display dpy, GLXContextID contextID)
            {
                GLXContext returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = ImportContextEXT(dpy_ptr, contextID);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryContextInfoEXT(Display*, GLXContext, int, int*)"/>
            public static unsafe int QueryContextInfoEXT(ref Display dpy, GLXContext context, int attribute, ref int value)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* value_ptr = &value)
                {
                    returnValue = QueryContextInfoEXT(dpy_ptr, context, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReleaseTexImageEXT(Display*, GLXDrawable, int)"/>
            public static unsafe void ReleaseTexImageEXT(ref Display dpy, GLXDrawable drawable, int buffer)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    ReleaseTexImageEXT(dpy_ptr, drawable, buffer);
                }
            }
            /// <inheritdoc cref="SwapIntervalEXT(Display*, GLXDrawable, int)"/>
            public static unsafe void SwapIntervalEXT(ref Display dpy, GLXDrawable drawable, int interval)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    SwapIntervalEXT(dpy_ptr, drawable, interval);
                }
            }
        }
        public static unsafe partial class MESA
        {
            /// <inheritdoc cref="CopySubBufferMESA(Display*, GLXDrawable, int, int, int, int)"/>
            public static unsafe void CopySubBufferMESA(ref Display dpy, GLXDrawable drawable, int x, int y, int width, int height)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    CopySubBufferMESA(dpy_ptr, drawable, x, y, width, height);
                }
            }
            /// <inheritdoc cref="CreateGLXPixmapMESA(Display*, XVisualInfo*, Pixmap, Colormap)"/>
            public static unsafe GLXPixmap CreateGLXPixmapMESA(ref Display dpy, ref XVisualInfo visual, Pixmap pixmap, Colormap cmap)
            {
                GLXPixmap returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (XVisualInfo* visual_ptr = &visual)
                {
                    returnValue = CreateGLXPixmapMESA(dpy_ptr, visual_ptr, pixmap, cmap);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetAGPOffsetMESA(void*)"/>
            public static unsafe uint GetAGPOffsetMESA(IntPtr pointer)
            {
                uint returnValue;
                void* pointer_vptr = (void*)pointer;
                returnValue = GetAGPOffsetMESA(pointer_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="GetAGPOffsetMESA(void*)"/>
            public static unsafe uint GetAGPOffsetMESA<T1>(in T1 pointer)
                where T1 : unmanaged
            {
                uint returnValue;
                fixed (void* pointer_ptr = &pointer)
                {
                    returnValue = GetAGPOffsetMESA(pointer_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryCurrentRendererIntegerMESA(int, uint*)"/>
            public static unsafe bool QueryCurrentRendererIntegerMESA(int attribute, ref uint value)
            {
                bool returnValue;
                fixed (uint* value_ptr = &value)
                {
                    returnValue = QueryCurrentRendererIntegerMESA(attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryCurrentRendererStringMESA(int)"/>
            public static unsafe string? QueryCurrentRendererStringMESA(int attribute)
            {
                string? returnValue_str;
                byte* returnValue;
                returnValue = QueryCurrentRendererStringMESA_(attribute);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="QueryRendererIntegerMESA(Display*, int, int, int, uint*)"/>
            public static unsafe bool QueryRendererIntegerMESA(ref Display dpy, int screen, int renderer, int attribute, ref uint value)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (uint* value_ptr = &value)
                {
                    returnValue = QueryRendererIntegerMESA(dpy_ptr, screen, renderer, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryRendererStringMESA(Display*, int, int, int)"/>
            public static unsafe string? QueryRendererStringMESA(ref Display dpy, int screen, int renderer, int attribute)
            {
                string? returnValue_str;
                fixed (Display* dpy_ptr = &dpy)
                {
                    byte* returnValue;
                    returnValue = QueryRendererStringMESA(dpy_ptr, screen, renderer, attribute);
                    returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                }
                return returnValue_str;
            }
            /// <inheritdoc cref="ReleaseBuffersMESA(Display*, GLXDrawable)"/>
            public static unsafe bool ReleaseBuffersMESA(ref Display dpy, GLXDrawable drawable)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = ReleaseBuffersMESA(dpy_ptr, drawable);
                }
                return returnValue;
            }
        }
        public static unsafe partial class NV
        {
            /// <inheritdoc cref="BindSwapBarrierNV(Display*, uint, uint)"/>
            public static unsafe bool BindSwapBarrierNV(ref Display dpy, uint group, uint barrier)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = BindSwapBarrierNV(dpy_ptr, group, barrier);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindVideoCaptureDeviceNV(Display*, uint, GLXVideoCaptureDeviceNV)"/>
            public static unsafe int BindVideoCaptureDeviceNV(ref Display dpy, uint video_capture_slot, GLXVideoCaptureDeviceNV device)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = BindVideoCaptureDeviceNV(dpy_ptr, video_capture_slot, device);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindVideoDeviceNV(Display*, uint, uint, int*)"/>
            public static unsafe int BindVideoDeviceNV(ref Display dpy, uint video_slot, uint video_device, in int attrib_list)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = BindVideoDeviceNV(dpy_ptr, video_slot, video_device, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindVideoImageNV(Display*, GLXVideoDeviceNV, GLXPbuffer, int)"/>
            public static unsafe int BindVideoImageNV(ref Display dpy, GLXVideoDeviceNV VideoDevice, GLXPbuffer pbuf, int iVideoBuffer)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = BindVideoImageNV(dpy_ptr, VideoDevice, pbuf, iVideoBuffer);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CopyBufferSubDataNV(Display*, GLXContext, GLXContext, All, All, IntPtr, IntPtr, nint)"/>
            public static unsafe void CopyBufferSubDataNV(ref Display dpy, GLXContext readCtx, GLXContext writeCtx, All readTarget, All writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    CopyBufferSubDataNV(dpy_ptr, readCtx, writeCtx, readTarget, writeTarget, readOffset, writeOffset, size);
                }
            }
            /// <inheritdoc cref="CopyImageSubDataNV(Display*, GLXContext, uint, All, int, int, int, int, GLXContext, uint, All, int, int, int, int, int, int, int)"/>
            public static unsafe void CopyImageSubDataNV(ref Display dpy, GLXContext srcCtx, uint srcName, All srcTarget, int srcLevel, int srcX, int srcY, int srcZ, GLXContext dstCtx, uint dstName, All dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    CopyImageSubDataNV(dpy_ptr, srcCtx, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstCtx, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
                }
            }
            /// <inheritdoc cref="DelayBeforeSwapNV(Display*, GLXDrawable, float)"/>
            public static unsafe bool DelayBeforeSwapNV(ref Display dpy, GLXDrawable drawable, float seconds)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = DelayBeforeSwapNV(dpy_ptr, drawable, seconds);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoCaptureDevicesNV(Display*, int, int*)"/>
            public static unsafe GLXVideoCaptureDeviceNV* EnumerateVideoCaptureDevicesNV(ref Display dpy, int screen, ref int nelements)
            {
                GLXVideoCaptureDeviceNV* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* nelements_ptr = &nelements)
                {
                    returnValue = EnumerateVideoCaptureDevicesNV(dpy_ptr, screen, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoDevicesNV(Display*, int, int*)"/>
            public static unsafe uint* EnumerateVideoDevicesNV(ref Display dpy, int screen, ref int nelements)
            {
                uint* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* nelements_ptr = &nelements)
                {
                    returnValue = EnumerateVideoDevicesNV(dpy_ptr, screen, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoDeviceNV(Display*, int, int, GLXVideoDeviceNV*)"/>
            public static unsafe int GetVideoDeviceNV(ref Display dpy, int screen, int numVideoDevices, ref GLXVideoDeviceNV pVideoDevice)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (GLXVideoDeviceNV* pVideoDevice_ptr = &pVideoDevice)
                {
                    returnValue = GetVideoDeviceNV(dpy_ptr, screen, numVideoDevices, pVideoDevice_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoInfoNV(Display*, int, GLXVideoDeviceNV, ulong*, ulong*)"/>
            public static unsafe int GetVideoInfoNV(ref Display dpy, int screen, GLXVideoDeviceNV VideoDevice, ref ulong pulCounterOutputPbuffer, ref ulong pulCounterOutputVideo)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (ulong* pulCounterOutputPbuffer_ptr = &pulCounterOutputPbuffer)
                fixed (ulong* pulCounterOutputVideo_ptr = &pulCounterOutputVideo)
                {
                    returnValue = GetVideoInfoNV(dpy_ptr, screen, VideoDevice, pulCounterOutputPbuffer_ptr, pulCounterOutputVideo_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="JoinSwapGroupNV(Display*, GLXDrawable, uint)"/>
            public static unsafe bool JoinSwapGroupNV(ref Display dpy, GLXDrawable drawable, uint group)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = JoinSwapGroupNV(dpy_ptr, drawable, group);
                }
                return returnValue;
            }
            /// <inheritdoc cref="LockVideoCaptureDeviceNV(Display*, GLXVideoCaptureDeviceNV)"/>
            public static unsafe void LockVideoCaptureDeviceNV(ref Display dpy, GLXVideoCaptureDeviceNV device)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    LockVideoCaptureDeviceNV(dpy_ptr, device);
                }
            }
            /// <inheritdoc cref="NamedCopyBufferSubDataNV(Display*, GLXContext, GLXContext, uint, uint, IntPtr, IntPtr, nint)"/>
            public static unsafe void NamedCopyBufferSubDataNV(ref Display dpy, GLXContext readCtx, GLXContext writeCtx, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    NamedCopyBufferSubDataNV(dpy_ptr, readCtx, writeCtx, readBuffer, writeBuffer, readOffset, writeOffset, size);
                }
            }
            /// <inheritdoc cref="QueryFrameCountNV(Display*, int, uint*)"/>
            public static unsafe bool QueryFrameCountNV(ref Display dpy, int screen, ref uint count)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (uint* count_ptr = &count)
                {
                    returnValue = QueryFrameCountNV(dpy_ptr, screen, count_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapGroupsNV(Display*, int, uint*, uint*)"/>
            public static unsafe bool QueryMaxSwapGroupsNV(ref Display dpy, int screen, ref uint maxGroups, ref uint maxBarriers)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (uint* maxGroups_ptr = &maxGroups)
                fixed (uint* maxBarriers_ptr = &maxBarriers)
                {
                    returnValue = QueryMaxSwapGroupsNV(dpy_ptr, screen, maxGroups_ptr, maxBarriers_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QuerySwapGroupNV(Display*, GLXDrawable, uint*, uint*)"/>
            public static unsafe bool QuerySwapGroupNV(ref Display dpy, GLXDrawable drawable, ref uint group, ref uint barrier)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (uint* group_ptr = &group)
                fixed (uint* barrier_ptr = &barrier)
                {
                    returnValue = QuerySwapGroupNV(dpy_ptr, drawable, group_ptr, barrier_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryVideoCaptureDeviceNV(Display*, GLXVideoCaptureDeviceNV, int, int*)"/>
            public static unsafe int QueryVideoCaptureDeviceNV(ref Display dpy, GLXVideoCaptureDeviceNV device, int attribute, ref int value)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* value_ptr = &value)
                {
                    returnValue = QueryVideoCaptureDeviceNV(dpy_ptr, device, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReleaseVideoCaptureDeviceNV(Display*, GLXVideoCaptureDeviceNV)"/>
            public static unsafe void ReleaseVideoCaptureDeviceNV(ref Display dpy, GLXVideoCaptureDeviceNV device)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    ReleaseVideoCaptureDeviceNV(dpy_ptr, device);
                }
            }
            /// <inheritdoc cref="ReleaseVideoDeviceNV(Display*, int, GLXVideoDeviceNV)"/>
            public static unsafe int ReleaseVideoDeviceNV(ref Display dpy, int screen, GLXVideoDeviceNV VideoDevice)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = ReleaseVideoDeviceNV(dpy_ptr, screen, VideoDevice);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReleaseVideoImageNV(Display*, GLXPbuffer)"/>
            public static unsafe int ReleaseVideoImageNV(ref Display dpy, GLXPbuffer pbuf)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = ReleaseVideoImageNV(dpy_ptr, pbuf);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ResetFrameCountNV(Display*, int)"/>
            public static unsafe bool ResetFrameCountNV(ref Display dpy, int screen)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = ResetFrameCountNV(dpy_ptr, screen);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SendPbufferToVideoNV(Display*, GLXPbuffer, int, ulong*, bool)"/>
            public static unsafe int SendPbufferToVideoNV(ref Display dpy, GLXPbuffer pbuf, int iBufferType, ref ulong pulCounterPbuffer, bool bBlock)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (ulong* pulCounterPbuffer_ptr = &pulCounterPbuffer)
                {
                    returnValue = SendPbufferToVideoNV(dpy_ptr, pbuf, iBufferType, pulCounterPbuffer_ptr, bBlock);
                }
                return returnValue;
            }
        }
        public static unsafe partial class OML
        {
            /// <inheritdoc cref="GetMscRateOML(Display*, GLXDrawable, int*, int*)"/>
            public static unsafe bool GetMscRateOML(ref Display dpy, GLXDrawable drawable, ref int numerator, ref int denominator)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* numerator_ptr = &numerator)
                fixed (int* denominator_ptr = &denominator)
                {
                    returnValue = GetMscRateOML(dpy_ptr, drawable, numerator_ptr, denominator_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSyncValuesOML(Display*, GLXDrawable, long*, long*, long*)"/>
            public static unsafe bool GetSyncValuesOML(ref Display dpy, GLXDrawable drawable, ref long ust, ref long msc, ref long sbc)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    returnValue = GetSyncValuesOML(dpy_ptr, drawable, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SwapBuffersMscOML(Display*, GLXDrawable, long, long, long)"/>
            public static unsafe long SwapBuffersMscOML(ref Display dpy, GLXDrawable drawable, long target_msc, long divisor, long remainder)
            {
                long returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = SwapBuffersMscOML(dpy_ptr, drawable, target_msc, divisor, remainder);
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForMscOML(Display*, GLXDrawable, long, long, long, long*, long*, long*)"/>
            public static unsafe bool WaitForMscOML(ref Display dpy, GLXDrawable drawable, long target_msc, long divisor, long remainder, ref long ust, ref long msc, ref long sbc)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    returnValue = WaitForMscOML(dpy_ptr, drawable, target_msc, divisor, remainder, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForSbcOML(Display*, GLXDrawable, long, long*, long*, long*)"/>
            public static unsafe bool WaitForSbcOML(ref Display dpy, GLXDrawable drawable, long target_sbc, ref long ust, ref long msc, ref long sbc)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    returnValue = WaitForSbcOML(dpy_ptr, drawable, target_sbc, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class SGI
        {
            /// <inheritdoc cref="CushionSGI(Display*, Window, float)"/>
            public static unsafe void CushionSGI(ref Display dpy, Window window, float cushion)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    CushionSGI(dpy_ptr, window, cushion);
                }
            }
            /// <inheritdoc cref="GetVideoSyncSGI(uint*)"/>
            public static unsafe int GetVideoSyncSGI(ref uint count)
            {
                int returnValue;
                fixed (uint* count_ptr = &count)
                {
                    returnValue = GetVideoSyncSGI(count_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="MakeCurrentReadSGI(Display*, GLXDrawable, GLXDrawable, GLXContext)"/>
            public static unsafe bool MakeCurrentReadSGI(ref Display dpy, GLXDrawable draw, GLXDrawable read, GLXContext ctx)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = MakeCurrentReadSGI(dpy_ptr, draw, read, ctx);
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitVideoSyncSGI(int, int, uint*)"/>
            public static unsafe int WaitVideoSyncSGI(int divisor, int remainder, ref uint count)
            {
                int returnValue;
                fixed (uint* count_ptr = &count)
                {
                    returnValue = WaitVideoSyncSGI(divisor, remainder, count_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class SGIX
        {
            /// <inheritdoc cref="BindChannelToWindowSGIX(Display*, int, int, Window)"/>
            public static unsafe int BindChannelToWindowSGIX(ref Display display, int screen, int channel, Window window)
            {
                int returnValue;
                fixed (Display* display_ptr = &display)
                {
                    returnValue = BindChannelToWindowSGIX(display_ptr, screen, channel, window);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindHyperpipeSGIX(Display*, int)"/>
            public static unsafe int BindHyperpipeSGIX(ref Display dpy, int hpId)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = BindHyperpipeSGIX(dpy_ptr, hpId);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindSwapBarrierSGIX(Display*, GLXDrawable, int)"/>
            public static unsafe void BindSwapBarrierSGIX(ref Display dpy, GLXDrawable drawable, int barrier)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    BindSwapBarrierSGIX(dpy_ptr, drawable, barrier);
                }
            }
            /// <inheritdoc cref="ChannelRectSGIX(Display*, int, int, int, int, int, int)"/>
            public static unsafe int ChannelRectSGIX(ref Display display, int screen, int channel, int x, int y, int w, int h)
            {
                int returnValue;
                fixed (Display* display_ptr = &display)
                {
                    returnValue = ChannelRectSGIX(display_ptr, screen, channel, x, y, w, h);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ChannelRectSyncSGIX(Display*, int, int, All)"/>
            public static unsafe int ChannelRectSyncSGIX(ref Display display, int screen, int channel, All synctype)
            {
                int returnValue;
                fixed (Display* display_ptr = &display)
                {
                    returnValue = ChannelRectSyncSGIX(display_ptr, screen, channel, synctype);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ChooseFBConfigSGIX(Display*, int, int*, int*)"/>
            public static unsafe GLXFBConfigSGIX* ChooseFBConfigSGIX(ref Display dpy, int screen, ref int attrib_list, ref int nelements)
            {
                GLXFBConfigSGIX* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* attrib_list_ptr = &attrib_list)
                fixed (int* nelements_ptr = &nelements)
                {
                    returnValue = ChooseFBConfigSGIX(dpy_ptr, screen, attrib_list_ptr, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateContextWithConfigSGIX(Display*, GLXFBConfigSGIX, int, GLXContext, bool)"/>
            public static unsafe GLXContext CreateContextWithConfigSGIX(ref Display dpy, GLXFBConfigSGIX config, int render_type, GLXContext share_list, bool direct)
            {
                GLXContext returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = CreateContextWithConfigSGIX(dpy_ptr, config, render_type, share_list, direct);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateGLXPbufferSGIX(Display*, GLXFBConfigSGIX, uint, uint, int*)"/>
            public static unsafe GLXPbufferSGIX CreateGLXPbufferSGIX(ref Display dpy, GLXFBConfigSGIX config, uint width, uint height, ref int attrib_list)
            {
                GLXPbufferSGIX returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateGLXPbufferSGIX(dpy_ptr, config, width, height, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateGLXPixmapWithConfigSGIX(Display*, GLXFBConfigSGIX, Pixmap)"/>
            public static unsafe GLXPixmap CreateGLXPixmapWithConfigSGIX(ref Display dpy, GLXFBConfigSGIX config, Pixmap pixmap)
            {
                GLXPixmap returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = CreateGLXPixmapWithConfigSGIX(dpy_ptr, config, pixmap);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DestroyGLXPbufferSGIX(Display*, GLXPbufferSGIX)"/>
            public static unsafe void DestroyGLXPbufferSGIX(ref Display dpy, GLXPbufferSGIX pbuf)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    DestroyGLXPbufferSGIX(dpy_ptr, pbuf);
                }
            }
            /// <inheritdoc cref="DestroyHyperpipeConfigSGIX(Display*, int)"/>
            public static unsafe int DestroyHyperpipeConfigSGIX(ref Display dpy, int hpId)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = DestroyHyperpipeConfigSGIX(dpy_ptr, hpId);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetFBConfigAttribSGIX(Display*, GLXFBConfigSGIX, int, int*)"/>
            public static unsafe int GetFBConfigAttribSGIX(ref Display dpy, GLXFBConfigSGIX config, int attribute, ref int value)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* value_ptr = &value)
                {
                    returnValue = GetFBConfigAttribSGIX(dpy_ptr, config, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetFBConfigFromVisualSGIX(Display*, XVisualInfo*)"/>
            public static unsafe GLXFBConfigSGIX GetFBConfigFromVisualSGIX(ref Display dpy, ref XVisualInfo vis)
            {
                GLXFBConfigSGIX returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (XVisualInfo* vis_ptr = &vis)
                {
                    returnValue = GetFBConfigFromVisualSGIX(dpy_ptr, vis_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSelectedEventSGIX(Display*, GLXDrawable, ulong*)"/>
            public static unsafe void GetSelectedEventSGIX(ref Display dpy, GLXDrawable drawable, ref ulong mask)
            {
                fixed (Display* dpy_ptr = &dpy)
                fixed (ulong* mask_ptr = &mask)
                {
                    GetSelectedEventSGIX(dpy_ptr, drawable, mask_ptr);
                }
            }
            /// <inheritdoc cref="GetVisualFromFBConfigSGIX(Display*, GLXFBConfigSGIX)"/>
            public static unsafe XVisualInfo* GetVisualFromFBConfigSGIX(ref Display dpy, GLXFBConfigSGIX config)
            {
                XVisualInfo* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = GetVisualFromFBConfigSGIX(dpy_ptr, config);
                }
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeAttribSGIX(Display*, int, int, int, void*)"/>
            public static unsafe int HyperpipeAttribSGIX(ref Display dpy, int timeSlice, int attrib, int size, IntPtr attribList)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    void* attribList_vptr = (void*)attribList;
                    returnValue = HyperpipeAttribSGIX(dpy_ptr, timeSlice, attrib, size, attribList_vptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeAttribSGIX(Display*, int, int, int, void*)"/>
            public static unsafe int HyperpipeAttribSGIX<T1>(ref Display dpy, int timeSlice, int attrib, int size, ref T1 attribList)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (void* attribList_ptr = &attribList)
                {
                    returnValue = HyperpipeAttribSGIX(dpy_ptr, timeSlice, attrib, size, attribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeConfigSGIX(Display*, int, int, GLXHyperpipeConfigSGIX*, int*)"/>
            public static unsafe int HyperpipeConfigSGIX(ref Display dpy, int networkId, int npipes, ref GLXHyperpipeConfigSGIX cfg, ref int hpId)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (GLXHyperpipeConfigSGIX* cfg_ptr = &cfg)
                fixed (int* hpId_ptr = &hpId)
                {
                    returnValue = HyperpipeConfigSGIX(dpy_ptr, networkId, npipes, cfg_ptr, hpId_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="JoinSwapGroupSGIX(Display*, GLXDrawable, GLXDrawable)"/>
            public static unsafe void JoinSwapGroupSGIX(ref Display dpy, GLXDrawable drawable, GLXDrawable member)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    JoinSwapGroupSGIX(dpy_ptr, drawable, member);
                }
            }
            /// <inheritdoc cref="QueryChannelDeltasSGIX(Display*, int, int, int*, int*, int*, int*)"/>
            public static unsafe int QueryChannelDeltasSGIX(ref Display display, int screen, int channel, ref int x, ref int y, ref int w, ref int h)
            {
                int returnValue;
                fixed (Display* display_ptr = &display)
                fixed (int* x_ptr = &x)
                fixed (int* y_ptr = &y)
                fixed (int* w_ptr = &w)
                fixed (int* h_ptr = &h)
                {
                    returnValue = QueryChannelDeltasSGIX(display_ptr, screen, channel, x_ptr, y_ptr, w_ptr, h_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryChannelRectSGIX(Display*, int, int, int*, int*, int*, int*)"/>
            public static unsafe int QueryChannelRectSGIX(ref Display display, int screen, int channel, ref int dx, ref int dy, ref int dw, ref int dh)
            {
                int returnValue;
                fixed (Display* display_ptr = &display)
                fixed (int* dx_ptr = &dx)
                fixed (int* dy_ptr = &dy)
                fixed (int* dw_ptr = &dw)
                fixed (int* dh_ptr = &dh)
                {
                    returnValue = QueryChannelRectSGIX(display_ptr, screen, channel, dx_ptr, dy_ptr, dw_ptr, dh_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryGLXPbufferSGIX(Display*, GLXPbufferSGIX, int, uint*)"/>
            public static unsafe void QueryGLXPbufferSGIX(ref Display dpy, GLXPbufferSGIX pbuf, int attribute, ref uint value)
            {
                fixed (Display* dpy_ptr = &dpy)
                fixed (uint* value_ptr = &value)
                {
                    QueryGLXPbufferSGIX(dpy_ptr, pbuf, attribute, value_ptr);
                }
            }
            /// <inheritdoc cref="QueryHyperpipeAttribSGIX(Display*, int, int, int, void*)"/>
            public static unsafe int QueryHyperpipeAttribSGIX(ref Display dpy, int timeSlice, int attrib, int size, IntPtr returnAttribList)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    void* returnAttribList_vptr = (void*)returnAttribList;
                    returnValue = QueryHyperpipeAttribSGIX(dpy_ptr, timeSlice, attrib, size, returnAttribList_vptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeAttribSGIX(Display*, int, int, int, void*)"/>
            public static unsafe int QueryHyperpipeAttribSGIX<T1>(ref Display dpy, int timeSlice, int attrib, int size, ref T1 returnAttribList)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (void* returnAttribList_ptr = &returnAttribList)
                {
                    returnValue = QueryHyperpipeAttribSGIX(dpy_ptr, timeSlice, attrib, size, returnAttribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeBestAttribSGIX(Display*, int, int, int, void*, void*)"/>
            public static unsafe int QueryHyperpipeBestAttribSGIX(ref Display dpy, int timeSlice, int attrib, int size, IntPtr attribList, IntPtr returnAttribList)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    void* attribList_vptr = (void*)attribList;
                    void* returnAttribList_vptr = (void*)returnAttribList;
                    returnValue = QueryHyperpipeBestAttribSGIX(dpy_ptr, timeSlice, attrib, size, attribList_vptr, returnAttribList_vptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeBestAttribSGIX(Display*, int, int, int, void*, void*)"/>
            public static unsafe int QueryHyperpipeBestAttribSGIX<T1, T2>(ref Display dpy, int timeSlice, int attrib, int size, ref T1 attribList, ref T2 returnAttribList)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (void* attribList_ptr = &attribList)
                fixed (void* returnAttribList_ptr = &returnAttribList)
                {
                    returnValue = QueryHyperpipeBestAttribSGIX(dpy_ptr, timeSlice, attrib, size, attribList_ptr, returnAttribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeConfigSGIX(Display*, int, int*)"/>
            public static unsafe GLXHyperpipeConfigSGIX* QueryHyperpipeConfigSGIX(ref Display dpy, int hpId, ref int npipes)
            {
                GLXHyperpipeConfigSGIX* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* npipes_ptr = &npipes)
                {
                    returnValue = QueryHyperpipeConfigSGIX(dpy_ptr, hpId, npipes_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeNetworkSGIX(Display*, int*)"/>
            public static unsafe GLXHyperpipeNetworkSGIX* QueryHyperpipeNetworkSGIX(ref Display dpy, ref int npipes)
            {
                GLXHyperpipeNetworkSGIX* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* npipes_ptr = &npipes)
                {
                    returnValue = QueryHyperpipeNetworkSGIX(dpy_ptr, npipes_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapBarriersSGIX(Display*, int, int*)"/>
            public static unsafe bool QueryMaxSwapBarriersSGIX(ref Display dpy, int screen, ref int max)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* max_ptr = &max)
                {
                    returnValue = QueryMaxSwapBarriersSGIX(dpy_ptr, screen, max_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SelectEventSGIX(Display*, GLXDrawable, ulong)"/>
            public static unsafe void SelectEventSGIX(ref Display dpy, GLXDrawable drawable, ulong mask)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    SelectEventSGIX(dpy_ptr, drawable, mask);
                }
            }
        }
        public static unsafe partial class SUN
        {
            /// <inheritdoc cref="GetTransparentIndexSUN(Display*, Window, Window, ulong*)"/>
            public static unsafe int GetTransparentIndexSUN(ref Display dpy, Window overlay, Window underlay, ref ulong pTransparentIndex)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (ulong* pTransparentIndex_ptr = &pTransparentIndex)
                {
                    returnValue = GetTransparentIndexSUN(dpy_ptr, overlay, underlay, pTransparentIndex_ptr);
                }
                return returnValue;
            }
        }
    }
}

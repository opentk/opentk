#region License
//
// LinuxDisplayDriver.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
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
using System.Collections.Generic;
using System.Diagnostics;
using OpenTK;
using OpenTK.Graphics;

namespace OpenTK.Platform.Linux
{
    // Stores platform-specific information about a display
    class LinuxDisplay
    {
        public int FD;
        public IntPtr Connector;
        public IntPtr Crtc;
        public IntPtr Encoder;

        unsafe public ModeConnector* pConnector { get { return (ModeConnector*)Connector; } }
        unsafe public ModeCrtc* pCrtc { get { return (ModeCrtc*)Crtc; } }
        unsafe public ModeEncoder* pEncoder { get { return (ModeEncoder*)Encoder; } }
        /*
        public ModeInfo Mode
        {
            get
            {
                if (Crtc == IntPtr.Zero)
                    throw new InvalidOperationException();

                unsafe
                {
                    return pCrtc->mode;
                }
            }
        }
        */

        public ModeInfo OriginalMode;

        public int Id
        {
            get
            {
                if (Crtc == IntPtr.Zero)
                    throw new InvalidOperationException();

                unsafe
                {
                    return (int)pCrtc->crtc_id;
                }
            }
        }

        public LinuxDisplay(int fd, IntPtr c, IntPtr e, IntPtr r)
        {
            FD = fd;
            Connector = c;
            Encoder = e;
            Crtc = r;
            unsafe
            {
                OriginalMode = pCrtc->mode; // in case we change resolution later on
            }
        }
    }

    class LinuxDisplayDriver : DisplayDeviceBase
    {
        readonly int FD;
        readonly Dictionary<int, int> DisplayIds =
            new Dictionary<int, int>();

        public LinuxDisplayDriver(int fd)
        {
            Debug.Print("[KMS] Creating LinuxDisplayDriver for fd:{0}", fd);
            Debug.Indent();
            try
            {
                FD = fd;
                UpdateDisplays(fd);
            }
            finally
            {
                Debug.Unindent();
            }
        }

        /// \internal
        /// <summary>
        /// Queries the specified GPU for connected displays and, optionally,
        /// returns the list of displays.
        /// </summary>
        /// <returns><c>true</c>, if at least one display is connected, <c>false</c> otherwise.</returns>
        /// <param name="fd">The fd for the GPU to query, obtained through open("/dev/dri/card0").</param>
        /// <param name="displays">
        /// If not null, this will contain a list <see cref="LinuxDisplay"/> instances,
        /// one for each connected display.
        /// </param>
        internal static bool QueryDisplays(int fd, List<LinuxDisplay> displays)
        {
            unsafe
            {
                bool has_displays = false;
                if (displays != null)
                {
                    displays.Clear();
                }

                ModeRes* resources = (ModeRes*)Drm.ModeGetResources(fd);
                if (resources == null)
                {
                    Debug.Print("[KMS] Drm.ModeGetResources failed.");
                    return false;
                }
                Debug.Print("[KMS] DRM found {0} connectors", resources->count_connectors);

                // Search for a valid connector
                ModeConnector* connector = null;
                for (int i = 0; i < resources->count_connectors; i++)
                {
                    connector = (ModeConnector*)Drm.ModeGetConnector(fd,
                        *(resources->connectors + i));
                    if (connector != null)
                    {
                        bool success = false;
                        LinuxDisplay display = null;
                        try
                        {
                            if (connector->connection == ModeConnection.Connected &&
                            connector->count_modes > 0)
                            {
                                success = QueryDisplay(fd, connector, out display);
                                has_displays |= success;
                            }
                        }
                        catch (Exception e)
                        {
                            Debug.Print("[KMS] Failed to add display. Error: {0}", e);
                        }

                        if (success && displays != null)
                        {
                            displays.Add(display);
                        }
                        else
                        {
                            Drm.ModeFreeConnector((IntPtr)connector);
                            connector = null;
                        }
                    }
                }

                return has_displays;
            }
        }

        void UpdateDisplays(int fd)
        {
            unsafe
            {
                lock (this)
                {
                    AvailableDevices.Clear();
                    DisplayIds.Clear();

                    List<LinuxDisplay> displays = new List<LinuxDisplay>();
                    if (QueryDisplays(fd, displays))
                    {
                        foreach (LinuxDisplay display in displays)
                        {
                            AddDisplay(display);
                        }
                    }

                    if (AvailableDevices.Count == 0)
                    {
                        Debug.Print("[KMS] Failed to find any active displays");
                    }
                }
            }
        }

        unsafe static ModeEncoder* GetEncoder(int fd, ModeConnector* c)
        {
            ModeEncoder* encoder = null;
            for (int i = 0; i < c->count_encoders && encoder == null; i++)
            {
                ModeEncoder* e = (ModeEncoder*)Drm.ModeGetEncoder(
                    fd, *(c->encoders + i));
                if (e != null)
                {
                    if (e->encoder_id == c->encoder_id)
                    {
                        encoder = e;
                    }
                    else
                    {
                        Drm.ModeFreeEncoder((IntPtr)e);
                    }
                }
            }

            if (encoder != null)
            {
                Debug.Print("[KMS] Encoder {0} found for connector {1}",
                    encoder->encoder_id, c->connector_id);
            }
            else
            {
                Debug.Print("[KMS] Failed to find encoder for connector {0}", c->connector_id);
            }

            return encoder;
        }

        unsafe static ModeCrtc* GetCrtc(int fd, ModeEncoder* encoder)
        {
            ModeCrtc* crtc = (ModeCrtc*)Drm.ModeGetCrtc(fd, encoder->crtc_id);
            if (crtc != null)
            {
                Debug.Print("[KMS] CRTC {0} found for encoder {1}",
                    encoder->crtc_id, encoder->encoder_id);
            }
            else
            {
                Debug.Print("[KMS] Failed to find crtc {0} for encoder {1}",
                    encoder->crtc_id, encoder->encoder_id);
            }
            return crtc;
        }

        unsafe static void GetModes(LinuxDisplay display, DisplayResolution[] modes, out DisplayResolution current)
        {
            int mode_count = display.pConnector->count_modes;
            Debug.Print("[KMS] Display supports {0} mode(s)", mode_count);
            for (int i = 0; i < mode_count; i++)
            {
                ModeInfo* mode = display.pConnector->modes + i;
                if (mode != null)
                {
                    Debug.Print("Mode {0}: {1}x{2} @{3}", i,
                        mode->hdisplay, mode->vdisplay, mode->vrefresh);
                    DisplayResolution res = GetDisplayResolution(mode);
                    modes[i] = res;
                }
            }

            if (display.pCrtc->mode_valid != 0)
            {
                ModeInfo cmode = display.pCrtc->mode;
                current = GetDisplayResolution(&cmode);
            }
            else
            {
                current = GetDisplayResolution(display.pConnector->modes);
            }
            Debug.Print("Current mode: {0}", current.ToString());
        }

        System.Drawing.Rectangle GetBounds(DisplayResolution current)
        {
            // Note: since we are not running a display manager, we are free
            // to choose the display layout for multiple displays ourselves.
            // We choose the simplest layout: displays are laid out side-by-side
            // from left to right. Primary display is the first display we encounter.
            int x = AvailableDevices.Count == 0 ?
                0 : AvailableDevices[AvailableDevices.Count - 1].Bounds.Right;
            int y = 0;

            return new System.Drawing.Rectangle(
                x, y, current.Width, current.Height);
        }

        void UpdateDisplayIndices(LinuxDisplay display, DisplayDevice device)
        {
            if (!DisplayIds.ContainsKey(display.Id))
            {
                Debug.Print("[KMS] Adding display {0} as {1}", display.Id, AvailableDevices.Count);
                DisplayIds.Add(display.Id, AvailableDevices.Count);
            }
            int index = DisplayIds[display.Id];
            if (index >= AvailableDevices.Count)
            {
                AvailableDevices.Add(device);
            }
            else
            {
                AvailableDevices[index] = device;
            }
        }

        unsafe static bool QueryDisplay(int fd, ModeConnector* c, out LinuxDisplay display)
        {
            display = null;

            // Find corresponding encoder
            ModeEncoder* encoder = GetEncoder(fd, c);
            if (encoder == null)
                return false;

            ModeCrtc* crtc = GetCrtc(fd, encoder);
            if (crtc == null)
                return false;

            display = new LinuxDisplay(fd, (IntPtr)c, (IntPtr)encoder, (IntPtr)crtc);
            return true;
        }

        unsafe void AddDisplay(LinuxDisplay display)
        {
            DisplayResolution[] modes = new DisplayResolution[display.pConnector->count_modes];
            DisplayResolution current;
            GetModes(display, modes, out current);

            bool is_primary = AvailableDevices.Count == 0;
            DisplayDevice device = new DisplayDevice(current, is_primary,
                modes, GetBounds(current), display);

            if (is_primary)
            {
                Primary = device;
            }

            UpdateDisplayIndices(display, device);

            Debug.Print("[KMS] Added DisplayDevice {0}", device);
        }

        unsafe static DisplayResolution GetDisplayResolution(ModeInfo* mode)
        {
            return new DisplayResolution(
                0, 0,
                mode->hdisplay, mode->vdisplay,
                32, // This is actually part of the framebuffer, not the DisplayResolution
                mode->vrefresh);
        }

        unsafe static ModeInfo* GetModeInfo(LinuxDisplay display, DisplayResolution resolution)
        {
            for (int i = 0; i < display.pConnector->count_modes; i++)
            {
                ModeInfo* mode = display.pConnector->modes + i;
                if (mode != null &&
                    mode->hdisplay == resolution.Width &&
                    mode->vdisplay == resolution.Height)
                {
                    return mode;
                }
            }
            return null;
        }

        #region IDisplayDeviceDriver

        public override bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution)
        {
            unsafe
            {
                LinuxDisplay display = (LinuxDisplay)device.Id;
                ModeInfo* mode = GetModeInfo(display, resolution);
                int connector_id = display.pConnector->connector_id;
                if (mode != null)
                {
                    return Drm.ModeSetCrtc(FD, display.Id, 0, 0, 0,
                        &connector_id, 1, mode) == 0;
                }
                return false;
            }
        }

        public override bool TryRestoreResolution(DisplayDevice device)
        {
            unsafe
            {
                LinuxDisplay display = (LinuxDisplay)device.Id;
                ModeInfo mode = display.OriginalMode;
                int connector_id = display.pConnector->connector_id;
                return Drm.ModeSetCrtc(FD, display.Id, 0, 0, 0,
                    &connector_id, 1, &mode) == 0;
            }
        }

        #endregion
    }
}


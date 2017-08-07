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

using System;
using System.Collections.Generic;
using System.Diagnostics;
#if !MINIMAL
using System.Drawing;
#endif

namespace OpenTK.Platform.Linux
{
    // Stores platform-specific information about a display
    internal sealed class LinuxDisplayDevice : DisplayDevice
    {
        public DisplayIndex Index;
        public List<DisplayResolution> _availableResolutions;
        public int FD;
        public IntPtr Connector;
        public IntPtr Crtc;
        public IntPtr Encoder;

        unsafe public ModeConnector* pConnector { get { return (ModeConnector*)Connector; } }
        unsafe public ModeCrtc* pCrtc { get { return (ModeCrtc*)Crtc; } }
        unsafe public ModeEncoder* pEncoder { get { return (ModeEncoder*)Encoder; } }

        public ModeInfo OriginalMode;

        public int Id
        {
            get
            {
                if (Crtc == IntPtr.Zero)
                {
                    throw new InvalidOperationException();
                }

                unsafe
                {
                    return (int)pCrtc->crtc_id;
                }
            }
        }

        public LinuxDisplayDevice(DisplayIndex index, int fd, IntPtr c, IntPtr e, IntPtr r)
        {
            Index = index;
            FD = fd;
            Connector = c;
            Encoder = e;
            Crtc = r;
            unsafe
            {
                OriginalMode = pCrtc->mode; // in case we change resolution later on
            }
        }

        internal unsafe static DisplayResolution GetDisplayResolution(ModeInfo* mode)
        {
            return new DisplayResolution(
                0, 0,
                mode->hdisplay, mode->vdisplay,
                32, // This is actually part of the framebuffer, not the DisplayResolution
                mode->vrefresh);
        }

        public override DisplayResolution CurrentResolution
        {
            get
            {
                unsafe
                {
                    DisplayResolution current;

                    if (pCrtc->mode_valid != 0)
                    {
                        ModeInfo cmode = pCrtc->mode;
                        current = GetDisplayResolution(&cmode);
                    }
                    else
                    {
                        current = GetDisplayResolution(pConnector->modes);
                    }
                    Debug.Print("Current mode: {0}", current.ToString());

                    // Note: since we are not running a display manager, we are free
                    // to choose the display layout for multiple displays ourselves.
                    // We choose the simplest layout: displays are laid out side-by-side
                    // from left to right. Primary display is the first display we encounter.
                    int x = 0;
                    if (Index != DisplayIndex.First)
                    {
                        var device = GetDisplay(Index - 1);
                        x = device.CurrentResolution.Bounds.Right;
                    }
                    int y = 0;

                    return new DisplayResolution(x, y, current.Width, current.Height, current.BitsPerPixel, current.RefreshRate);
                }
            }

            set
            {
                base.CurrentResolution = value;
            }
        }

        public override bool IsPrimary
        {
            get
            {
                return Index == DisplayIndex.First;
            }
        }

        public override IList<DisplayResolution> AvailableResolutions
        {
            get
            {
                return _availableResolutions.AsReadOnly();
            }
        }

        public override void ChangeResolution(DisplayResolution resolution)
        {
            unsafe
            {
                ModeInfo* mode = LinuxDisplayDeviceDriver.GetModeInfo(this, resolution);
                int connector_id = pConnector->connector_id;
                if (mode != null)
                {
                    if (Drm.ModeSetCrtc(FD, Id, 0, 0, 0, &connector_id, 1, mode) == 0)
                    {
                        return;
                    }
                }
                throw new Graphics.GraphicsModeException(
                    string.Format("Device {0}: Failed to change resolution to {1}.", this, resolution));
            }
        }

        public override void RestoreResolution()
        {
            unsafe
            {
                ModeInfo mode = OriginalMode;
                int connector_id = pConnector->connector_id;
                if (Drm.ModeSetCrtc(FD, Id, 0, 0, 0, &connector_id, 1, &mode) != 0)
                {
                    throw new Graphics.GraphicsModeException(string.Format("Device {0}: Failed to restore resolution.", this));
                }
            }
        }
    }

    internal sealed class LinuxDisplayDeviceDriver : DisplayDeviceDriver
    {
        private readonly int FD;

        public LinuxDisplayDeviceDriver(int fd)
        {
            Debug.Print("[KMS] Creating LinuxDisplayDriver for fd:{0}", fd);
            Debug.Indent();
            try
            {
                FD = fd;
                lock (this)
                {
                    QueryDisplays(FD, Devices);
                }
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
        internal static bool QueryDisplays(int fd, List<DisplayDevice> devices)
        {
            unsafe
            {
                bool has_displays = false;

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
                    connector = (ModeConnector*)Drm.ModeGetConnector(fd, *(resources->connectors + i));
                    if (connector != null)
                    {
                        bool success = false;
                        LinuxDisplayDevice display = null;
                        try
                        {
                            if (connector->connection == ModeConnection.Connected &&
                            connector->count_modes > 0)
                            {
                                success = QueryDisplay(fd, connector, i, out display);
                                has_displays |= success;
                            }
                        }
                        catch (Exception e)
                        {
                            Debug.Print("[KMS] Failed to add display. Error: {0}", e);
                        }

                        if (success && devices != null)
                        {
                            GetModes(display);

                            Debug.Print("[KMS] Adding display {0} as {1}", display.Id, display.Index);
                            devices.Add(display);

                            Debug.Print("[KMS] Added DisplayDevice {0}", display);
                        }
                        else
                        {
                            Drm.ModeFreeConnector((IntPtr)connector);
                            connector = null;
                        }
                    }
                }

                if (devices != null && devices.Count == 0)
                {
                    Debug.Print("[KMS] Failed to find any active displays");
                }

                return has_displays;
            }
        }

        private unsafe static ModeEncoder* GetEncoder(int fd, ModeConnector* c)
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

        private unsafe static ModeCrtc* GetCrtc(int fd, ModeEncoder* encoder)
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

        internal unsafe static void GetModes(LinuxDisplayDevice display)
        {
            int modeCount = display.pConnector->count_modes;
            display._availableResolutions = new List<DisplayResolution>(modeCount);
            Debug.Print("[KMS] Display supports {0} mode(s)", modeCount);
            for (int i = 0; i < modeCount; i++)
            {
                ModeInfo* mode = display.pConnector->modes + i;
                if (mode != null)
                {
                    Debug.Print("Mode {0}: {1}x{2} @{3}", i,
                        mode->hdisplay, mode->vdisplay, mode->vrefresh);
                    DisplayResolution res = LinuxDisplayDevice.GetDisplayResolution(mode);
                    display._availableResolutions.Add(res);
                }
            }
        }

        private unsafe static bool QueryDisplay(int fd, ModeConnector* c, int index, out LinuxDisplayDevice display)
        {
            display = null;

            // Find corresponding encoder
            ModeEncoder* encoder = GetEncoder(fd, c);
            if (encoder == null)
            {
                return false;
            }

            ModeCrtc* crtc = GetCrtc(fd, encoder);
            if (crtc == null)
            {
                return false;
            }

            display = new LinuxDisplayDevice((DisplayIndex)index, fd, (IntPtr)c, (IntPtr)encoder, (IntPtr)crtc);
            return true;
        }

        internal unsafe static ModeInfo* GetModeInfo(LinuxDisplayDevice display, DisplayResolution resolution)
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

        internal static DisplayDevice FromPoint(int x, int y)
        {
            for (DisplayIndex i = DisplayIndex.First; i < DisplayIndex.Sixth; i++)
            {
                DisplayDevice display = DisplayDevice.GetDisplay(i);
                if (display != null)
                {
                    if (display.CurrentResolution.Bounds.Contains(x, y))
                    {
                        return display;
                    }
                }
            }
            return null;
        }
    }
}


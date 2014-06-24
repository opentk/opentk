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
    class LinuxDisplayDriver : DisplayDeviceBase
    {
        unsafe class LinuxDisplay
        {
            public ModeConnector* Connector;
            public ModeEncoder* Encoder;
            public ModeCrtc* Crtc;
            public ModeInfo Mode
            {
                get
                {
                    if (Crtc == null)
                        throw new InvalidOperationException();

                    return Crtc->mode;
                }
            }
            public ModeInfo OriginalMode;

            public int Id
            {
                get
                {
                    if (Crtc == null)
                        throw new InvalidOperationException();

                    return (int)Crtc->crtc_id;
                }
            }

            public LinuxDisplay(ModeConnector* c, ModeEncoder* e, ModeCrtc* r)
            {
                Connector = c;
                Encoder = e;
                Crtc = r;
                OriginalMode = Crtc->mode; // in case we change resolution later on
            }
        }

        readonly int FD;
        readonly GbmDevice Device;
        readonly Dictionary<int, int> DisplayIds =
            new Dictionary<int, int>();

        public LinuxDisplayDriver(int fd)
        {
            FD = fd;
            QueryDisplays();
        }

        void QueryDisplays()
        {
            unsafe
            {
                lock (this)
                {
                    AvailableDevices.Clear();
                    DisplayIds.Clear();

                    ModeRes* resources = (ModeRes*)Drm.ModeGetResources(FD);
                    if (resources == null)
                    {
                        throw new NotSupportedException("[KMS] DRM ModeGetResources failed");
                    }
                    Debug.Print("[KMS] DRM found {0} connectors", resources->count_connectors);

                    // Search for a valid connector
                    ModeConnector* connector = null;
                    for (int i = 0; i < resources->count_connectors; i++)
                    {
                        connector = (ModeConnector*)Drm.ModeGetConnector(FD,
                            *(resources->connectors + i));
                        if (connector != null)
                        {
                            if (connector->connection == ModeConnection.Connected &&
                            connector->count_modes > 0)
                            {
                                // Connector found!
                                AddDisplay(connector);
                            }
                            else
                            {
                                // This is not the display we are looking for
                                Drm.ModeFreeConnector((IntPtr)connector);
                                connector = null;
                            }
                        }
                    }

                    if (AvailableDevices.Count == 0)
                    {
                        Debug.Print("[KMS] Failed to find any active displays");
                    }
                }
            }
        }

        unsafe void AddDisplay(ModeConnector* c)
        {
            // Find corresponding encoder
            ModeEncoder* encoder = null;
            for (int i = 0; i < c->count_encoders && encoder == null; i++)
            {
                ModeEncoder* e = (ModeEncoder*)Drm.ModeGetEncoder(
                    FD, *(c->encoders + i));
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
                return;
            }

            ModeCrtc* crtc = (ModeCrtc*)Drm.ModeGetCrtc(FD, encoder->crtc_id);
            if (crtc != null)
            {
                Debug.Print("[KMS] CRTC {0} found for encoder {1}",
                    encoder->crtc_id, encoder->encoder_id);
            }
            else
            {
                Debug.Print("[KMS] Failed to find crtc {0} for encoder {1}",
                    encoder->crtc_id, encoder->encoder_id);
                return;
            }

            LinuxDisplay display = new LinuxDisplay(c, encoder, crtc);
            if (!DisplayIds.ContainsKey(display.Id))
            {
                DisplayIds.Add(display.Id, AvailableDevices.Count);
            }

            List<DisplayResolution> modes = new List<DisplayResolution>();
            for (int i = 0; i < display.Connector->count_modes; i++)
            {
                ModeInfo* mode = display.Connector->modes + i;
                DisplayResolution res = GetDisplayResolution(mode);
                modes.Add(res);
            }
            ModeInfo current_mode = display.Mode;
            DisplayResolution current = GetDisplayResolution(&current_mode);

            // Note: since we are not running a display manager, we are free
            // to choose the display layout for multiple displays ourselves.
            // We choose the simplest layout: displays are laid out side-by-side
            // from left to right. Primary display is the first display we encounter.
            System.Drawing.Rectangle bounds =
                new System.Drawing.Rectangle(
                    AvailableDevices.Count == 0 ? 0 : AvailableDevices[0].Bounds.Right,
                    0,
                    current.Width,
                    current.Height);

            DisplayDevice device = new DisplayDevice(
                current,
                AvailableDevices.Count == 0,
                modes,
                bounds,
                display);

            if (AvailableDevices.Count == 0)
            {
                Primary = device;
            }

            AvailableDevices.Add(device);
        }

        unsafe static DisplayResolution GetDisplayResolution(ModeInfo* mode)
        {
            if (mode == null)
                throw new ArgumentNullException();

            return new DisplayResolution(
                0, 0,
                mode->htotal, mode->vtotal,
                32, // This is actually part of the framebuffer, not the DisplayResolution
                mode->vrefresh / 1000.0f);
        }

        unsafe static ModeInfo* GetModeInfo(LinuxDisplay display, DisplayResolution resolution)
        {
            for (int i = 0; i < display.Connector->count_modes; i++)
            {
                ModeInfo* mode = display.Connector->modes + i;
                if (mode != null &&
                    mode->htotal == resolution.Width &&
                    mode->vtotal == resolution.Height)
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
                uint connector_id = display.Connector->connector_id;
                if (mode != null)
                {
                    return Drm.ModeSetCrtc(FD, (uint)display.Id, 0, 0, 0,
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
                uint connector_id = display.Connector->connector_id;
                ModeInfo mode = display.OriginalMode;
                return Drm.ModeSetCrtc(FD, (uint)display.Id, 0, 0, 0,
                    &connector_id, 1, &mode) == 0;
            }
        }

        #endregion
    }
}


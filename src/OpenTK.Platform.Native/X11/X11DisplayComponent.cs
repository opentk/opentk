using System;
using System.Diagnostics;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using static OpenTK.Platform.Native.X11.XRandR.XRandR;
using static OpenTK.Platform.Native.X11.LibX11;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Platform.Native.X11.XRandR;

namespace OpenTK.Platform.Native.X11
{
    public class X11DisplayComponent : IDisplayComponent
    {
        /// <inheritdoc />
        public string Name => "X11DisplayComponent";

        /// <inheritdoc />
        public PalComponents Provides => PalComponents.Display;

        /// <inheritdoc />
        public ILogger? Logger { get ; set; }

        // TODO: Write Xinerama fallback.

        /// <inheritdoc />
        public bool CanGetVirtualPosition { get; } = false;

        public XRRScreenConfiguration XrrScreenConfiguration { get; private set; }

        private static readonly List<XDisplayHandle> _displays = new List<XDisplayHandle>();

        /// <inheritdoc />
        public void Initialize(PalComponents which)
        {
            if (X11.Extensions.Contains("RANDR"))
            {
                if (XRRQueryExtension(X11.Display, out int eventBase, out int errorBase) != 0)
                {
                    X11.XRandREventBase = eventBase;
                    X11.XRandRErrorBase = errorBase;

                    int major = 1;
                    int minor = 3;
                    XRRQueryVersion(X11.Display, ref major, ref minor);
                    if (major != 1 && minor < 3)
                    {
                        Logger?.LogError($"XRandR failed to load. Got version {major}.{minor} but 1.3 is required.");
                        return;
                    }
                    //DisplayExtensionVersion = new Version(major, minor);

                    XrrScreenConfiguration = XRRGetScreenInfo(X11.Display, (XDrawable)X11.DefaultRootWindow);

                    int screenCount = XScreenCount(X11.Display);

                    // Loop through all displays
                    for (int screen = 0; screen < screenCount; screen++)
                    {
                        unsafe {
                            XRRScreenResources* resources = XRRGetScreenResources(X11.Display, XRootWindow(X11.Display, screen));

                            RROutput primaryOutput = XRRGetOutputPrimary(X11.Display, X11.DefaultRootWindow);

                            if (resources == null) continue;

                            for (int i = 0; i < resources->NumberOfOutputs; i++)
                            {
                                RROutput output = resources->Outputs[i];
                                XRROutputInfo* outputInfo = XRRGetOutputInfo(X11.Display, resources, output);

                                if (outputInfo->crtc == RRCrtc.None || outputInfo->connection == Connection.Disconnected)
                                {
                                    XRRFreeOutputInfo(outputInfo);
                                    continue;
                                }

                                string name = Marshal.PtrToStringUTF8((IntPtr)outputInfo->name)!;

                                Span<XAtom> atoms = XRRListOutputProperties(X11.Display, output, out int nprops);

                                string? displayName = null;

                                List<string> list = new List<string>();
                                foreach (var atom in atoms)
                                {
                                    list.Add(XGetAtomName(X11.Display, atom));

                                    if (atom == X11.Atoms[KnownAtoms.EDID])
                                    {
                                        int status = XRRGetOutputProperty(
                                            X11.Display, output,
                                            X11.Atoms[KnownAtoms.EDID],
                                            0, ~0,
                                            false, false,
                                            new XAtom(0),
                                            out XAtom actualType,
                                            out int actualFormat,
                                            out long nitems,
                                            out long bytesAfter,
                                            out IntPtr prop);

                                        if (status == X11.Success)
                                        {
                                            byte* edid = (byte*)prop;

                                            EDID.EDIDInfo info = EDID.Parse(edid, Logger);

                                            displayName = info.DisplayName;

                                            XFree(prop);
                                        }
                                    }
                                }

                                XFree(atoms);

                                XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, outputInfo->crtc);

                                if (crtcInfo == null)
                                {
                                    continue;
                                }

                                bool isPrimary = output == primaryOutput;

                                Console.WriteLine($"Name: {name}");
                                Console.WriteLine($"Name: {displayName}");
                                if (isPrimary) Console.WriteLine($"Primary display");
                                Console.WriteLine($"Position: ({crtcInfo->x}, {crtcInfo->y})");
                                Console.WriteLine($"Resolution: ({crtcInfo->width}, {crtcInfo->height})");
                                Console.WriteLine($"Rotation: {crtcInfo->rotation}");
                                Console.WriteLine($"Atoms: {string.Join(", ", list)}");

                                XDisplayHandle handle = new XDisplayHandle(output, outputInfo->crtc);
                                handle.Name = displayName ?? name;

                                _displays.Add(handle);

                                XRRFreeOutputInfo(outputInfo);
                                XRRFreeCrtcInfo(crtcInfo);
                            }

                            XRRFreeScreenResources(resources);

                            // Subscribe to events relating to connecting and disconnecting monitors.
                            XRRSelectInput(X11.Display, X11.DefaultRootWindow, RRSelectMask.OutputChangeNotifyMask);
                        }
                    }
                
                    Logger?.LogInfo("Using XRANDR for display component.");
                }

                // FIXME: Error message for when this fails?
            }
            else 
            {
                Logger?.LogError("Could not find XRANDR extension. The display component will not work.");
            }
        }

        internal static void HandleXRREvent(XEvent @event)
        {
            switch ((RREventType)(@event.Type - X11.XRandREventBase))
            {
                case RREventType.RRScreenChangeNotify:
                    Console.WriteLine("RR Screen change notify.");
                    break;
                case RREventType.RRNotify:
                    Console.WriteLine($"RR Notify (subtype: {@event.RRNotify.SubType})");
                    break;
                default:
                    break;
            }
        }

        /// <inheritdoc />
        public int GetDisplayCount()
        {
            return _displays.Count;
        }

        /// <inheritdoc />
        public DisplayHandle Open(int index)
        {
            // FIXME: Bounds check
            return _displays[index];
        }

        /// <inheritdoc />
        public DisplayHandle OpenPrimary()
        {
            return Open(0);
        }

        /// <inheritdoc />
        public void Close(DisplayHandle handle)
        {
            // We don't need to do anything here, we just verify that we got the right type of handle.
            XDisplayHandle randr = handle.As<XDisplayHandle>(this);
        }

        /// <inheritdoc />
        public bool IsPrimary(DisplayHandle handle)
        {
            XDisplayHandle xdisplay = handle.As<XDisplayHandle>(this);
            RROutput primary = XRRGetOutputPrimary(X11.Display, X11.DefaultRootWindow);

            return xdisplay.Output == primary;
        }

        /// <inheritdoc />
        public string GetName(DisplayHandle handle)
        {
            XDisplayHandle randr = handle.As<XDisplayHandle>(this);
            return randr.Name;
        }

        /// <inheritdoc />
        public void GetVideoMode(DisplayHandle handle, out VideoMode mode)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public VideoMode[] GetSupportedVideoModes(DisplayHandle handle)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void GetVirtualPosition(DisplayHandle handle, out int x, out int y)
        {
            // FIXME: Should we get this every time or should we cache this?
            unsafe
            {
                XDisplayHandle xdisplay = handle.As<XDisplayHandle>(this);

                // FIXME: DefaultScreen...?
                XRRScreenResources* resources = XRRGetScreenResources(X11.Display, XRootWindow(X11.Display, X11.DefaultScreen));
                XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, xdisplay.Crtc);

                x = crtcInfo->x;
                y = crtcInfo->y;

                XRRFreeCrtcInfo(crtcInfo);
                XRRFreeScreenResources(resources);
            }
        }

        /// <inheritdoc />
        public void GetResolution(DisplayHandle handle, out int width, out int  height)
        {
            // FIXME: Should we get this every time or should we cache this?
            unsafe
            {
                XDisplayHandle xdisplay = handle.As<XDisplayHandle>(this);

                // FIXME: DefaultScreen...?
                XRRScreenResources* resources = XRRGetScreenResources(X11.Display, XRootWindow(X11.Display, X11.DefaultScreen));
                XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, xdisplay.Crtc);

                // FIXME: Should we use crtc size or output size?
                width = (int)crtcInfo->width;
                height = (int)crtcInfo->height;

                XRRFreeCrtcInfo(crtcInfo);
                XRRFreeScreenResources(resources);
            }
        }

        /// <inheritdoc />
        public void GetWorkArea(DisplayHandle handle, out Box2i area)
        {
            // Use NET_WORKAREA and NET_DESKTOP to get the work area
            // fall back to the crtc area if NET_WORKAREA isn't available.
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void GetRefreshRate(DisplayHandle handle, out float refreshRate)
        {
            unsafe
            {
                XDisplayHandle xdisplay = handle.As<XDisplayHandle>(this);

                // FIXME: DefaultScreen...?
                XRRScreenResources* resources = XRRGetScreenResources(X11.Display, XRootWindow(X11.Display, X11.DefaultScreen));
                XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, xdisplay.Crtc);

                XRRModeInfo* info = null;
                for (int i = 0; i < resources->NumberOfModes; i++)
                {
                    if (resources->Modes[i].ModeId == crtcInfo->mode)
                    {
                        info = &resources->Modes[i];
                        break;
                    }
                }

                if (info != null)
                {
                    if (info->DotClock != 0 && info->VTotal != 0 && info->HTotal != 0)
                        {
                            refreshRate = ((info->DotClock * 100) / (info->VTotal * info->HTotal)) / 100.0f;
                        }
                        else
                        {
                            // FIXME: Name or index of the display...
                            Logger?.LogWarning("Could not get refresh rate.");
                            refreshRate = 0;
                        }
                }
                else
                {
                    // FIXME: Name or index of the display...
                    Logger?.LogWarning("Could not find mode info for display.");
                    refreshRate = 0;
                }

                XRRFreeCrtcInfo(crtcInfo);
                XRRFreeScreenResources(resources);
            }
        }

        /// <inheritdoc />
        public void GetDisplayScale(DisplayHandle handle, out float scaleX, out float scaleY)
        {
            throw new NotImplementedException();
        }
    }
}

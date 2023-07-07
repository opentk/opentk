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

        /// <inheritdoc />
        public void Initialize(PalComponents which)
        {
            if (X11.Extensions.Contains("RANDR"))
            {
                DisplayExtension = DisplayExtensionType.XRandR;

                if (XRRQueryExtension(X11.Display, out int eventBase, out int errorBase) != 0)
                {
                    DisplayExtension = DisplayExtensionType.XRandR;

                    X11.XRandREventBase = eventBase;
                    X11.XRandRErrorBase = errorBase;

                    int major = 1;
                    int minor = 3;
                    XRRQueryVersion(X11.Display, ref major, ref minor);
                    if (major != 1 && minor < 3)
                    {
                        Logger?.LogError($"XRandR failed to load. Got version {major}.{minor} but 1.3 is required.");
                        // FIXME: Fallback to XINERAMA or just X11?
                        DisplayExtension = DisplayExtensionType.None;
                        return;
                    }
                    DisplayExtensionVersion = new Version(major, minor);

                    XrrScreenConfiguration = XRRGetScreenInfo(X11.Display, X11.DefaultRootWindow);

                    int screenCount = XScreenCount(X11.Display);

                    // Loop through all displays
                    for (int screen = 0; screen < screenCount; screen++)
                    {
                        unsafe {
                            XRRScreenResources* resources = XRRGetScreenResources(X11.Display, XRootWindow(X11.Display, screen));

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

                                string name = Marshal.PtrToStringUTF8((IntPtr)outputInfo->name);

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

                                            EDID.EDIDInfo info = EDID.Parse(edid);

                                            displayName = info.DisplayName;

                                            XFree(prop);
                                        }
                                    }
                                }

                                XFree(atoms);

                                XRRCrtcInfo* crtcInfo = XRRGetCrtcInfo(X11.Display, resources, outputInfo->crtc);

                                XRRFreeOutputInfo(outputInfo);

                                if (crtcInfo == null)
                                {
                                    continue;
                                }

                                Console.WriteLine($"Name: {name}");
                                Console.WriteLine($"Name: {displayName}");
                                Console.WriteLine($"Position: ({crtcInfo->x}, {crtcInfo->y})");
                                Console.WriteLine($"Resolution: ({crtcInfo->width}, {crtcInfo->height})");
                                Console.WriteLine($"Rotation: {crtcInfo->rotation}");
                                Console.WriteLine($"Atoms: {string.Join(", ", list)}");

                                XRRFreeCrtcInfo(crtcInfo);
                            }

                            XRRFreeScreenResources(resources);
                        }
                    }
                }
            }
            else if (X11.Extensions.Contains("XINERAMA"))
            {
                DisplayExtension = DisplayExtensionType.Xinerama;
            }
            else {
                DisplayExtension = DisplayExtensionType.None;
            }

            // FIXME

            Logger?.LogInfo($"Using display extension: {DisplayExtension}.");
            if (DisplayExtension != DisplayExtensionType.None)
                Logger?.LogInfo($"{DisplayExtension} version {DisplayExtensionVersion}");
        }

        // TODO: Write Xinerama fallback.

        /// <inheritdoc />
        public bool CanSetVideoMode { get; } = false;

        /// <inheritdoc />
        public bool CanGetVirtualPosition { get; } = false;

        /// <summary>
        /// The type of extension that is used to get display information.
        /// </summary>
        public DisplayExtensionType DisplayExtension { get; private set; } = DisplayExtensionType.None;

        /// <summary>
        /// Version of the extension used to get display information.
        /// </summary>
        public Version DisplayExtensionVersion { get; private set; }

        public XRRScreenConfiguration XrrScreenConfiguration { get; private set; }

        /// <inheritdoc />
        public int GetDisplayCount()
        {
            switch (DisplayExtension)
            {
            case DisplayExtensionType.XRandR:
            {


                return -1;
            }
            default:
            case DisplayExtensionType.None:
                return 1;
            }
        }

        /// <inheritdoc />
        public DisplayHandle Open(int index)
        {
            switch (DisplayExtension)
            {
            case DisplayExtensionType.XRandR:
                unsafe
                {
                    XRRScreenResources* resources = XRRGetScreenResources(X11.Display, X11.DefaultRootWindow);

                    if (resources is null)
                    {
                        throw new PalException(this, "Could not get screen XRandR screen resources.");
                    }

                    XRRFreeScreenResources(resources);
                }
                throw new NotImplementedException();
            default:
            case DisplayExtensionType.None:
                if (index > 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                return DummyDisplayHandle.Instance;
            }
        }

        /// <inheritdoc />
        public DisplayHandle OpenPrimary()
        {
            return Open(0);
        }

        /// <inheritdoc />
        public void Close(DisplayHandle handle)
        {
            switch (DisplayExtension)
            {
            case DisplayExtensionType.XRandR:
                throw new NotImplementedException();
            default:
            case DisplayExtensionType.None:
                // Nothing needs to be done to the dummy handle as long as it is the dummy handle.
                handle.As<DummyDisplayHandle>(this);
                break;
            }
        }

        /// <inheritdoc />
        public bool IsPrimary(DisplayHandle handle)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string GetName(DisplayHandle handle)
        {
            switch (DisplayExtension)
            {
            case DisplayExtensionType.XRandR:
                throw new NotImplementedException();
            default:
            case DisplayExtensionType.None:
                handle.As<DummyDisplayHandle>(this);
                return "X Root Window";
            }
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
            switch (DisplayExtension)
            {
                case DisplayExtensionType.XRandR:
                    throw new NotImplementedException();
                default:
                case DisplayExtensionType.None:
                    handle.As<DummyDisplayHandle>(this);
                    x = y = 0;
                    break;
            }
        }

        /// <inheritdoc />
        public void GetResolution(DisplayHandle handle, out int width, out int  height)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void GetWorkArea(DisplayHandle handle, out Box2i area)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void GetRefreshRate(DisplayHandle handle, out float refreshRate)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void GetDisplayScale(DisplayHandle handle, out float scaleX, out float scaleY)
        {
            throw new NotImplementedException();
        }

        public enum DisplayExtensionType
        {
            None,
            XRandR,
            Xinerama
        }

        private class DummyDisplayHandle : DisplayHandle
        {
            public static readonly DummyDisplayHandle Instance = new DummyDisplayHandle();
        }
    }
}

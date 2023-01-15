using System;
using System.Diagnostics;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using static OpenTK.Platform.Native.X11.XRandR;

namespace OpenTK.Platform.Native.X11
{
    public class X11DisplayComponent : IDisplayComponent
    {
        public string Name => "X11DisplayComponent";

        public PalComponents Provides => PalComponents.Display;

        public ILogger? Logger { get ; set; }

        public void Initialize(PalComponents which)
        {
            // FIXME

            // In X11, we have a priority list of extensions and methods we can use.
            // 1. Use the X Rotate and Reflect extension.
            // 2. Fallback to Xinerama extension.
            // 3. Fallback to the size of the root window.

            int eventBase = default, errorBase = default;
            if (XRRQueryExtension(X11.Display, ref eventBase, ref errorBase) != 0)
            {
                DisplayExtension = DisplayExtensionType.XRandR;

                XRRQueryVersion(X11.Display, out int major, out int minor);
                DisplayExtensionVersion = new Version(major, minor);

                unsafe
                {
                    XrrScreenConfiguration = XRRGetScreenInfo(X11.Display, X11.DefaultRootWindow);
                }
            }
            else
            {
                DisplayExtension = DisplayExtensionType.None;
            }

            Logger?.LogInfo($"Using display extension: {DisplayExtension}.");
            if (DisplayExtension != DisplayExtensionType.None)
                Logger?.LogInfo($"{DisplayExtension} version {DisplayExtensionVersion}");
        }

        // TODO: Write Xinerama fallback.

        public bool CanSetVideoMode { get; } = false;
        public bool CanGetVirtualPosition { get; } = false;
        public bool CanGetDisplaySize { get; } = false;

        public DisplayExtensionType DisplayExtension { get; private set; } = DisplayExtensionType.None;

        public Version DisplayExtensionVersion { get; private set; }

        public unsafe XRRScreenConfiguration* XrrScreenConfiguration = null;

        public int GetDisplayCount()
        {
            switch (DisplayExtension)
            {
            case DisplayExtensionType.XRandR:
                throw new NotImplementedException();
            default:
            case DisplayExtensionType.None:
                return 1;
            }
        }

        public DisplayHandle Create(int index)
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

        public DisplayHandle CreatePrimary()
        {
            return Create(0);
        }

        public void Destroy(DisplayHandle handle)
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

        public bool IsPrimary(DisplayHandle handle)
        {
            throw new NotImplementedException();
        }

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

        public void GetVideoMode(DisplayHandle handle, out VideoMode mode)
        {
            throw new NotImplementedException();
        }

        public void SetVideoMode(DisplayHandle handle, in VideoMode mode)
        {
            throw new NotImplementedException();
        }

        public int GetSupportedVideoModeCount(DisplayHandle handle)
        {
            throw new NotImplementedException();
        }

        public void GetSupportedVideoModes(DisplayHandle handle, Span<VideoMode> modes)
        {
            throw new NotImplementedException();
        }

        public void GetDisplaySize(DisplayHandle handle, out float width, out float height)
        {
            throw new NotImplementedException();
        }

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

        public void GetResolution(DisplayHandle handle, out int width, out int  height)
        {
            throw new NotImplementedException();
        }

        public void GetWorkArea(DisplayHandle handle, out Box2i area)
        {
            throw new NotImplementedException();
        }

        public void GetRefreshRate(DisplayHandle handle, out float refreshRate)
        {
            throw new NotImplementedException();
        }

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

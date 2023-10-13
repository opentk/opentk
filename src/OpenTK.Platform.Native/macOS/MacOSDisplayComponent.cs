using System;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using static OpenTK.Platform.Native.macOS.ObjC;
using static OpenTK.Platform.Native.macOS.CG;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Net.Http.Headers;

namespace OpenTK.Platform.Native.macOS
{
    public class MacOSDisplayComponent : IDisplayComponent
    {
        internal static readonly ObjCClass NSScreenClass = objc_getClass("NSScreen");

        internal static SEL selScreens = sel_registerName("screens"u8);
        internal static SEL selObjectAtIndex = sel_registerName("objectAtIndex:"u8);
        internal static SEL selCount = sel_registerName("count"u8);

        internal static SEL selDeviceDescription = sel_registerName("deviceDescription"u8);
        internal static SEL selLocalizedName = sel_registerName("localizedName"u8);
        internal static SEL selBackingScaleFactor = sel_registerName("backingScaleFactor"u8);

        internal static SEL selObjectForKey = sel_registerName("objectForKey:"u8);

        internal static SEL selUnsignedIntValue = sel_registerName("unsignedIntValue"u8);

        internal static SEL selRespondsToSelector = sel_registerName("respondsToSelector:"u8);

        public string Name => nameof(MacOSDisplayComponent);

        public PalComponents Provides =>  PalComponents.Display;

        public ILogger? Logger { get; set; }

        private static readonly List<NSScreenHandle> _displays = new List<NSScreenHandle>();

        public unsafe void Initialize(PalComponents which)
        {
            if (which != PalComponents.Display)
            {
                throw new PalException(this, "MacOSDisplayComponent can only initialize the Display component.");
            }

            CGError status = CGGetActiveDisplayList(0, null, out uint noDisplays);
            if (status != CGError.Success)
            {
                // FIXME:
            }
            Span<uint> displays = stackalloc uint[(int)noDisplays];
            fixed(uint* displaysPtr = displays)
            {
                CGGetActiveDisplayList(noDisplays, displaysPtr, out noDisplays);
            }

            for (int i = 0; i < displays.Length; i++)
            {
                if (CGDisplayIsAsleep(displays[i]) != 0)
                {
                    // This display is asleep, ignore it.
                    continue;
                }

                uint unitNumber = CGDisplayUnitNumber(displays[i]);

                IntPtr nsscreen = IntPtr.Zero;

                IntPtr screensNSArray = objc_msgSend_IntPtr((IntPtr)NSScreenClass, selScreens);
                nint count = (nint)objc_msgSend_IntPtr(screensNSArray, selCount);
                for (int screenIdx = 0; screenIdx < count; screenIdx++)
                {
                    nsscreen = objc_msgSend_IntPtr(screensNSArray, selObjectAtIndex, (IntPtr)screenIdx);
                    IntPtr descNSDictionary = objc_msgSend_IntPtr(nsscreen, selDeviceDescription);

                    IntPtr screenNumberNSNumber = objc_msgSend_IntPtr(descNSDictionary, selObjectForKey, ToNSString("NSScreenNumber"u8));
                    uint screenNumber = objc_msgSend_uint(screenNumberNSNumber, selUnsignedIntValue);

                    if (CGDisplayUnitNumber(screenNumber) == unitNumber)
                    {
                        // Here we've found the NSScreen associated with this display.
                        break;
                    }
                }

                // FIXME: Returns BOOL
                string name = "Display";
                if (objc_msgSend_bool(nsscreen, selRespondsToSelector, selLocalizedName))
                {
                    name = FromNSString(objc_msgSend_IntPtr(nsscreen, selLocalizedName));
                }
                else
                {
                    // FIXME: If localizedName doesn't work we could use the IOKit api to query the name
                    // Is this needed?
                    Logger?.LogWarning($"Could not get localized name from: CGDirectDisplayID={displays[i]}, UnitNumber={unitNumber}, NSScreen={nsscreen}");
                }

                bool primary = CGDisplayIsMain(displays[i]) != 0;

                IntPtr mode = CGDisplayCopyDisplayMode(displays[i]);

                // FIXME: This gets us the retina scaled size of the display
                // For example on the machine I'm using right now a value of
                // 900 is reported for the display height, while infact the display
                // has a vertical resolution of 1600 pixels.
                // How should we handle this?
                // FIXME: How are the resolutions of external monitors (non-retina) reported?
                int width = (int)CGDisplayModeGetWidth(mode);
                int height = (int)CGDisplayModeGetHeight(mode);

                double refreshRate = CGDisplayModeGetRefreshRate(mode);
                // FIXME: refreshRate could be 0 here, in which case we could use the IORegistry api to
                // query IOFBCurrentPixelClock, and IOFBCurrentPixelCount to calculate the refresh rate.
                if (refreshRate == 0)
                {
                    Logger?.LogWarning($"Could not get refresh rate from display: {name} (CGDirectDisplayID={displays[i]}, UnitNumber={unitNumber}, NSScreen={nsscreen})");
                }

                CGDisplayModeRelease(mode);

                NSScreenHandle handle = new NSScreenHandle(displays[i], unitNumber, nsscreen)
                {
                    Name = name,
                    IsPrimary = primary,
                    Resolution = new DisplayResolution(width, height),
                    RefreshRate = refreshRate,
                };
                _displays.Add(handle);
            }
        }

        public bool CanGetVirtualPosition => throw new NotImplementedException();

        public int GetDisplayCount()
        {
            return _displays.Count;
        }

        public DisplayHandle Open(int index)
        {
            // FIXME: Range check?

            return _displays[index];
        }
        
        public DisplayHandle OpenPrimary()
        {
            // FIXME: Make the primary array always be first?
            foreach (var display in _displays)
            {
                if (display.IsPrimary)
                {
                    return display;
                }
            }
            // Throw exception here as we found no primary display.
            throw new NotImplementedException();
        }

        // FIXME: platform specific api for getting the monitor with the best color?

        public void Close(DisplayHandle handle)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);
            // We just have to check this is a valid NSScreenHandle
        }

        public bool IsPrimary(DisplayHandle handle)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);
            return nsscreen.IsPrimary;
        }

        public string GetName(DisplayHandle handle)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);
            return nsscreen.Name;
        }

        public void GetVideoMode(DisplayHandle handle, out VideoMode mode)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);

            mode.Width = nsscreen.Resolution.ResolutionX;
            mode.Height = nsscreen.Resolution.ResolutionY;
            mode.RefreshRate = (float)nsscreen.RefreshRate;
            // FIXME!!
            mode.BitsPerPixel = -1;
        }

        public VideoMode[] GetSupportedVideoModes(DisplayHandle handle)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);

            // FIXME:
            IntPtr arrayRef = CGDisplayCopyAllDisplayModes(nsscreen.DirectDisplayID, IntPtr.Zero);

            nint count = CFArrayGetCount(arrayRef);
            List<VideoMode> modes = new List<VideoMode>();
            for (int i = 0; i < count; i++)
            {
                IntPtr /* CGDisplayModeRef */ modeRef = CFArrayGetValueAtIndex(arrayRef, i);

                // Prune video modes that we don't want.
                DisplayModeIOFlags flags = CGDisplayModeGetIOFlags(modeRef);
                if (flags.HasFlag(DisplayModeIOFlags.DisplayModeValidFlag) == false)
                    continue;
                // FIXME: GLFW also removes modes that are missing the kDisplayModeSafeFlag..
                if (flags.HasFlag(DisplayModeIOFlags.DisplayModeInterlacedFlag))
                    continue;
                if (flags.HasFlag(DisplayModeIOFlags.DisplayModeStretchedFlag))
                    continue;

                int width = (int)CGDisplayModeGetWidth(modeRef);
                int height = (int)CGDisplayModeGetHeight(modeRef);

                double refreshRate = CGDisplayModeGetRefreshRate(modeRef);
                // FIXME: refreshRate could be 0 here, in which case we could use the IORegistry api to
                // query IOFBCurrentPixelClock, and IOFBCurrentPixelCount to calculate the refresh rate.
                if (refreshRate == 0)
                {
                    //Logger?.LogWarning($"Could not get refresh rate from display: {nsscreen.Name} (CGDirectDisplayID={nsscreen.DirectDisplayID}, UnitNumber={nsscreen.UnitNumber}, NSScreen={nsscreen.Screen})");
                }

                modes.Add(new VideoMode(width, height, (float)refreshRate, -1));
            }

            return modes.ToArray();
        }

        public void GetVirtualPosition(DisplayHandle handle, out int x, out int y)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);

            CGRect bounds = CGDisplayBounds(nsscreen.DirectDisplayID);

            // FIXME: These coordinates are in global display coordinate space,
            // is that the coordinate space we want to return?
            // FIXME: Either do something to align this to pixels or make the virtual
            // position floating point.
            x = (int)bounds.origin.x;
            y = (int)bounds.origin.y;
        }

        public void GetResolution(DisplayHandle handle, out int width, out int height)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);
            width = nsscreen.Resolution.ResolutionX;
            height = nsscreen.Resolution.ResolutionY;
        }

        public void GetWorkArea(DisplayHandle handle, out Box2i area)
        {
            throw new NotImplementedException();
        }

        public void GetRefreshRate(DisplayHandle handle, out float refreshRate)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);
            refreshRate = (float)nsscreen.RefreshRate;
        }

        public void GetDisplayScale(DisplayHandle handle, out float scaleX, out float scaleY)
        {
            throw new NotImplementedException();
        }
    }
}


using System;
using OpenTK.Core.Utility;
using OpenTK.Mathematics;
using static OpenTK.Platform.Native.macOS.ObjC;
using static OpenTK.Platform.Native.macOS.CG;
using static OpenTK.Platform.Native.macOS.CV;

using System.Collections.Generic;

namespace OpenTK.Platform.Native.macOS
{
    public class MacOSDisplayComponent : IDisplayComponent
    {
        internal static readonly ObjCClass NSScreenClass = objc_getClass("NSScreen"u8);

        internal static readonly SEL selScreens = sel_registerName("screens"u8);
        internal static readonly SEL selObjectAtIndex = sel_registerName("objectAtIndex:"u8);
        internal static readonly SEL selCount = sel_registerName("count"u8);

        internal static readonly SEL selDeviceDescription = sel_registerName("deviceDescription"u8);
        internal static readonly SEL selLocalizedName = sel_registerName("localizedName"u8);
        internal static readonly SEL selBackingScaleFactor = sel_registerName("backingScaleFactor"u8);
        internal static readonly SEL selVisibleFrame = sel_registerName("visibleFrame"u8);
        internal static readonly SEL selFrame = sel_registerName("frame"u8);
        internal static readonly SEL selConvertRectToBacking = sel_registerName("convertRectToBacking:"u8);
        internal static readonly SEL selDepth = sel_registerName("depth"u8);
        // macOS 12.0+
        internal static readonly SEL selSafeAreaInsets = sel_registerName("safeAreaInsets"u8);
        internal static readonly SEL selAuxiliaryTopLeftArea = sel_registerName("auxiliaryTopLeftArea"u8);
        internal static readonly SEL selAuxiliaryTopRightArea = sel_registerName("auxiliaryTopRightArea"u8);

        internal static readonly SEL selObjectForKey = sel_registerName("objectForKey:"u8);

        internal static readonly SEL selUnsignedIntValue = sel_registerName("unsignedIntValue"u8);

        internal static readonly SEL selRespondsToSelector = sel_registerName("respondsToSelector:"u8);

        /// <inheritdoc/>
        public string Name => nameof(MacOSDisplayComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Display;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        private static readonly List<NSScreenHandle> _displays = new List<NSScreenHandle>();

        /// <inheritdoc/>
        public unsafe void Initialize(ToolkitOptions options)
        {
            UpdateDisplays(Logger, false);
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
            // We don't need to clear this list,
            // but it feels appropriate.
            // - Noggin_bops 2024-10-30
            _displays.Clear();
        }

        internal static unsafe void UpdateDisplays(ILogger? logger, bool sendEvents)
        {
            List<NSScreenHandle> newDisplays = new List<NSScreenHandle>();

            List<NSScreenHandle> removedDisplays = new List<NSScreenHandle>(_displays);

            // FIXME: Maybe use CGGetOnlineDisplayList?
            CGError status = CGGetActiveDisplayList(0, null, out uint noDisplays);
            if (status != CGError.Success)
            {
                // FIXME:
            }
            Span<uint> displays = stackalloc uint[(int)noDisplays];
            fixed (uint* displaysPtr = displays)
            {
                CGGetActiveDisplayList(noDisplays, displaysPtr, out noDisplays);
            }

            for (int i = 0; i < displays.Length; i++)
            {
                if (CGDisplayIsAsleep(displays[i]) != 0)
                    continue;

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

                // If this display already existed remove it from the removed list.
                NSScreenHandle? handle = null;
                for (int j = 0; j < _displays.Count; j++)
                {
                    if (_displays[j].UnitNumber == unitNumber)
                    {
                        handle = _displays[j];
                        removedDisplays.Remove(handle);
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
                    logger?.LogWarning($"Could not get localized name from: CGDirectDisplayID={displays[i]}, UnitNumber={unitNumber}, NSScreen={nsscreen}");
                }

                bool isPrimary = CGDisplayIsMain(displays[i]) != 0;

                IntPtr mode = CGDisplayCopyDisplayMode(displays[i]);
                var width = CGDisplayPixelsWide(displays[i]);

                CGDisplayModeRelease(mode);

                if (handle == null)
                {
                    handle = new NSScreenHandle(displays[i], unitNumber, nsscreen, name, isPrimary);
                    newDisplays.Add(handle);
                }
                else
                {
                    handle.Name = name;
                    handle.Screen = nsscreen;
                    handle.IsPrimary = isPrimary;
                    handle.DirectDisplayID = displays[i];
                }
            }

            // FIXME: Should we really update _display as we are sending the events?
            // Wouldn't it be better if we had figured out the elements and order before
            // we start sending events?
            // - Noggin_bops 2024-02-28

            foreach (NSScreenHandle removed in removedDisplays)
            {
                _displays.Remove(removed);
                if (sendEvents)
                {
                    EventQueue.Raise(removed, PlatformEventType.DisplayConnectionChanged, new DisplayConnectionChangedEventArgs(removed, true));
                }
            }

            foreach (NSScreenHandle connected in newDisplays)
            {
                _displays.Add(connected);
                if (sendEvents)
                {
                    EventQueue.Raise(connected, PlatformEventType.DisplayConnectionChanged, new DisplayConnectionChangedEventArgs(connected, false));
                }
            }

            NSScreenHandle? primary = null;
            foreach (NSScreenHandle display in _displays)
            {
                if (display.IsPrimary)
                {
                    primary = display;
                    break;
                }
            }

            if (primary != null)
            {
                int index = _displays.IndexOf(primary);
                _displays.RemoveAt(index);
                _displays.Insert(0, primary);
            }
            else
            {
                logger?.LogWarning("Could not find primary monitor!");
            }
        }

        internal static DisplayHandle FindDisplay(IntPtr /* NSScreen */ nsscreen)
        {
            for (int i = 0; i < _displays.Count; i++)
            {
                if (_displays[i].Screen == nsscreen)
                {
                    return _displays[i];
                }
            }

            throw new ArgumentException($"Cannot find display handle for NSScreen=0x{nsscreen}.");
        }

        /// <inheritdoc/>
        public bool CanGetVirtualPosition => true;

        /// <inheritdoc/>
        public int GetDisplayCount()
        {
            return _displays.Count;
        }

        /// <inheritdoc/>
        public DisplayHandle Open(int index)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index), $"Display index cannot be negative. {index}");
            if (index >= _displays.Count) throw new ArgumentOutOfRangeException(nameof(index), $"Display index cannot be larger or equal to the number of displays. Index: {index}, Display count: {_displays.Count}");

            return _displays[index];
        }

        /// <inheritdoc/>
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

            throw new PalException(this, $"Could not find a primary monitor (this should not happen).");
        }

        // FIXME: platform specific api for getting the monitor with the best color?

        /// <inheritdoc/>
        public void Close(DisplayHandle handle)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);
            // We just have to check this is a valid NSScreenHandle
        }

        /// <inheritdoc/>
        public bool IsPrimary(DisplayHandle handle)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);
            return nsscreen.IsPrimary;
        }

        /// <inheritdoc/>
        public string GetName(DisplayHandle handle)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);
            return nsscreen.Name;
        }

        /// <inheritdoc/>
        public void GetVideoMode(DisplayHandle handle, out VideoMode mode)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);

            CGRect bounds = objc_msgSend_CGRect(nsscreen.Screen, selFrame);

            // FIXME: Should we report pixels or virtual screen size?
            mode.Width = (int)bounds.size.x;
            mode.Height = (int)bounds.size.y;
            GetRefreshRate(nsscreen, out mode.RefreshRate);

            int /* NSWindowDepth */ depth = objc_msgSend_int(nsscreen.Screen, selDepth);
            nint bpp = NSBitsPerPixelFromDepth(depth);
            mode.BitsPerPixel = (int)bpp;
        }

        /// <inheritdoc/>
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
                if (refreshRate == 0)
                {
                    CVDisplayLinkCreateWithCGDisplay(nsscreen.DirectDisplayID, out CVDisplayLinkRef link);
                    CVTime time = CVDisplayLinkGetNominalOutputVideoRefreshPeriod(link);
                    if ((time.flags & CVIndefiniteTime) == 0)
                    {
                        // FIXME: Maybe round this value?
                        refreshRate = (time.timeScale / (float)time.timeValue);
                    }
                    else
                    {
                        // FIXME: Maybe not spam the log here, just print this out once?
                        Logger?.LogWarning($"Could not get refresh rate from display: {nsscreen.Name} (CGDirectDisplayID={nsscreen.DirectDisplayID}, UnitNumber={nsscreen.UnitNumber}, NSScreen={nsscreen.Screen})");
                    }
                    CVDisplayLinkRelease(link);
                }

                // FIXME: This gives us the bits that are actually used as color components
                // This doesn't give us the stride between pixels.
                int bitsPerPixel = -1;
                IntPtr mode = CGDisplayModeCopyPixelEncoding(modeRef);
                if (CFStringCompare(mode, IO16BitDirectPixels, 0) == 0)
                {
                    // R5G5B5
                    bitsPerPixel = 15;
                }
                else if (CFStringCompare(mode, IO32BitDirectPixels, 0) == 0)
                {
                    // R8G8B8
                    bitsPerPixel = 24;
                }
                else if (CFStringCompare(mode, IO30BitDirectPixels, 0) == 0)
                {
                    // R10G10B10
                    bitsPerPixel = 30;
                }
                else if (CFStringCompare(mode, IO64BitDirectPixels, 0) == 0)
                {
                    // R16G16B16
                    bitsPerPixel = 48;
                }
                else if (CFStringCompare(mode, IO16BitFloatPixels, 0) == 0)
                {
                    // FIXME: Some way to indicate HDR?
                    // R16FG16FB16F
                    bitsPerPixel = 48;
                }
                else if (CFStringCompare(mode, IO32BitFloatPixels, 0) == 0)
                {
                    // FIXME: Some way to indicate HDR?
                    // R32FG32FB32F
                    bitsPerPixel = 96;
                }

                modes.Add(new VideoMode(width, height, (float)refreshRate, bitsPerPixel));
            }

            return modes.ToArray();
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        // FIXME: Maybe rename this to be size? it will not return pixels!
        public void GetResolution(DisplayHandle handle, out int width, out int height)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);

            CGRect bounds = objc_msgSend_CGRect(nsscreen.Screen, selFrame);

            // FIXME: Do not round?
            width = (int)bounds.size.x;
            height = (int)bounds.size.y;
        }

        /// <inheritdoc/>
        public void GetWorkArea(DisplayHandle handle, out Box2i area)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);

            CGRect visible = objc_msgSend_CGRect(nsscreen.Screen, selVisibleFrame);

            area = new Box2i(
                (int)visible.origin.x,
                (int)FlipYCoordinate(visible.origin.y + visible.size.y),
                (int)(visible.origin.x + visible.size.x),
                (int)FlipYCoordinate(visible.origin.y));
        }

        // FIXME: Document this!
        public void GetSafeArea(DisplayHandle handle, out Box2i area)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);

            NSEdgeInsets insets = objc_msgSend_NSEdgeInsets(nsscreen.Screen, selSafeAreaInsets);

            CGRect frame = objc_msgSend_CGRect(nsscreen.Screen, selFrame);

            frame.origin.x += insets.left;
            frame.origin.y += insets.bottom;
            frame.size.x -= insets.left + insets.right;
            frame.size.y -= insets.bottom + insets.top;

            area = new Box2i(
                (int)frame.origin.x,
                (int)FlipYCoordinate(frame.origin.y + frame.size.y),
                (int)(frame.origin.x + frame.size.x),
                (int)FlipYCoordinate(frame.origin.y));
        }

        /// <summary>
        /// The the top left unobscured area of the screen.
        /// Some macOS devices have a portion of the screen covered by the camera housing,
        /// this function returns the visible are left to the that.
        /// If there is no obscured area of the display this function returns false.
        /// </summary>
        /// <param name="handle">The display to get the safe area of.</param>
        /// <param name="area">The top left auxiliary area.</param>
        /// <returns>If there is an auxiliary area.</returns>
        public bool GetSafeLeftAuxArea(DisplayHandle handle, out Box2i area)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);

            CGRect auxArea = objc_msgSend_CGRect(nsscreen.Screen, selAuxiliaryTopLeftArea);

            if (auxArea.IsZeroRect)
            {
                area = default;
                return false;
            }
            else
            {
                area = new Box2i(
                    (int)auxArea.origin.x,
                    (int)FlipYCoordinate(auxArea.origin.y + auxArea.size.y),
                    (int)(auxArea.origin.x + auxArea.size.x),
                    (int)FlipYCoordinate(auxArea.origin.y));
                return true;
            }
        }

        /// <summary>
        /// The the top right unobscured area of the screen.
        /// Some macOS devices have a portion of the screen covered by the camera housing,
        /// this function returns the visible are left to the that.
        /// If there is no obscured area of the display this function returns false.
        /// </summary>
        /// <param name="handle">The display to get the safe area of.</param>
        /// <param name="area">The top left auxiliary area.</param>
        /// <returns>If there is an auxiliary area.</returns>
        public bool GetSafeRightAuxArea(DisplayHandle handle, out Box2i area)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);

            CGRect auxArea = objc_msgSend_CGRect(nsscreen.Screen, selAuxiliaryTopRightArea);

            if (auxArea.IsZeroRect)
            {
                area = default;
                return false;
            }
            else
            {
                area = new Box2i(
                    (int)auxArea.origin.x,
                    (int)FlipYCoordinate(auxArea.origin.y + auxArea.size.y),
                    (int)(auxArea.origin.x + auxArea.size.x),
                    (int)FlipYCoordinate(auxArea.origin.y));
                return true;
            }
        }

        /// <inheritdoc/>
        public void GetRefreshRate(DisplayHandle handle, out float refreshRate)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);

            IntPtr mode = CGDisplayCopyDisplayMode(nsscreen.DirectDisplayID);
            refreshRate = (float)CGDisplayModeGetRefreshRate(mode);
            if (refreshRate == 0)
            {
                CVDisplayLinkCreateWithCGDisplay(nsscreen.DirectDisplayID, out CVDisplayLinkRef link);
                CVTime time = CVDisplayLinkGetNominalOutputVideoRefreshPeriod(link);
                if ((time.flags & CVIndefiniteTime) == 0)
                {
                    // FIXME: Maybe round this value?
                    refreshRate = (time.timeScale / (float)time.timeValue);
                }
                else
                {
                    Logger?.LogWarning($"Could not get refresh rate from display: {nsscreen.Name} (CGDirectDisplayID={nsscreen.DirectDisplayID}, UnitNumber={nsscreen.UnitNumber}, NSScreen={nsscreen.Screen})");
                }
                CVDisplayLinkRelease(link);
            }
            CGDisplayModeRelease(mode);
        }

        /// <inheritdoc/>
        public void GetDisplayScale(DisplayHandle handle, out float scaleX, out float scaleY)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);

            CGRect frame = objc_msgSend_CGRect(nsscreen.Screen, selFrame);
            CGRect frameBacking = objc_msgSend_CGRect(nsscreen.Screen, selConvertRectToBacking, frame);

            scaleX = (float)(frameBacking.size.x / frame.size.x);
            scaleY = (float)(frameBacking.size.y / frame.size.y);

            //float factor = (float)objc_msgSend_nfloat(nsscreen.Screen, selBackingScaleFactor);
        }

        /// <summary>
        /// Returns the <c>CGDirectDisplayID</c> associated with this display handle.
        /// </summary>
        /// <param name="handle">A handle to a display to get the associated <c>CGDirectDisplayID</c> from.</param>
        /// <returns>The <c>CGDirectDisplayID</c> associated with the display handle.</returns>
        public uint GetDirectDisplayID(DisplayHandle handle)
        {
            NSScreenHandle nsscreen = handle.As<NSScreenHandle>(this);

            return nsscreen.DirectDisplayID;
        }

        // FIXME: Do we want to expose other native things like NSScreen or UnitNumber?
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using static System.Formats.Asn1.AsnWriter;
using static OpenTK.Platform.Native.macOS.ObjC;

namespace OpenTK.Platform.Native.macOS
{
    public class MacOSCursorComponent : ICursorComponent
    {
        internal static readonly ObjCClass NSCursorClass = objc_getClass("NSCursor"u8);
        internal static readonly ObjCClass NSImageClass = objc_getClass("NSImage"u8);
        internal static readonly ObjCClass NSDictionaryClass = objc_getClass("NSDictionary"u8);
        internal static readonly ObjCClass NSUserDefaultsClass = objc_getClass("NSUserDefaults"u8);


        internal static readonly SEL selInitWithImage_HotSpot = sel_registerName("initWithImage:hotSpot:"u8);
        internal static readonly SEL selHotSpot = sel_registerName("hotSpot"u8);
        internal static readonly SEL selImage = sel_registerName("image"u8);


        internal static readonly SEL selArrowCursor = sel_registerName("arrowCursor"u8);
        internal static readonly SEL selIBeamCursor = sel_registerName("IBeamCursor"u8);
        internal static readonly SEL selCrosshairCursor = sel_registerName("crosshairCursor"u8);
        internal static readonly SEL selClosedHandCursor = sel_registerName("closedHandCursor"u8);
        internal static readonly SEL selPointingHandCursor = sel_registerName("pointingHandCursor"u8);
        internal static readonly SEL selResizeLeftCursor = sel_registerName("resizeLeftCursor"u8);
        internal static readonly SEL selResizeRightCursor = sel_registerName("resizeRightCursor"u8);
        internal static readonly SEL selResizeLeftRightCursor = sel_registerName("resizeLeftRightCursor"u8);
        internal static readonly SEL selResizeUpCursor = sel_registerName("resizeUpCursor"u8);
        internal static readonly SEL selResizeDownCursor = sel_registerName("resizeDownCursor"u8);
        internal static readonly SEL selResizeUpDownCursor = sel_registerName("resizeUpDownCursor"u8);
        internal static readonly SEL selOperationNotAllowedCursor = sel_registerName("operationNotAllowedCursor"u8);
        internal static readonly SEL selContextualMenuCursor = sel_registerName("contextualMenuCursor"u8);

        internal static readonly SEL selInitWithContentsOfFile = sel_registerName("initWithContentsOfFile:"u8);
        internal static readonly SEL selIsValid = sel_registerName("isValid"u8);


        internal static readonly SEL selDictionaryWithContentsOfFile = sel_registerName("dictionaryWithContentsOfFile:"u8);
        internal static readonly SEL selValueForKey = sel_registerName("valueForKey:"u8);
        internal static readonly SEL selIntegerValue = sel_registerName("integerValue"u8);
        internal static readonly SEL selDoubleValue = sel_registerName("doubleValue"u8);

        internal static readonly SEL selInitWithSize = sel_registerName("initWithSize:"u8);
        internal static readonly SEL selDrawInRect_FromRect_Operation_Fraction = sel_registerName("drawInRect:fromRect:operation:fraction:"u8);
        internal static readonly SEL selLockFocus = sel_registerName("lockFocus"u8);
        internal static readonly SEL selUnlockFocus = sel_registerName("unlockFocus"u8);
        internal static readonly SEL selSize = sel_registerName("size"u8);

        internal static readonly SEL selStandardUserDefaults = sel_registerName("standardUserDefaults"u8);
        internal static readonly SEL selPersistentDomainForName = sel_registerName("persistentDomainForName:"u8);


        // Keep a list of animated cursors?
        private List<NSCursorHandle> AnimatedCursors = new List<NSCursorHandle>();

        public string Name => nameof(MacOSCursorComponent);

        public PalComponents Provides => PalComponents.MouseCursor;

        public ILogger? Logger { get; set; }

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.MouseCursor)
            {
                throw new Exception("MacOSCursorComponent can only initialize the MouseCursor component.");
            }
        }

        public bool CanLoadSystemCursors => true;

        public bool CanInspectSystemCursors => true;

        // FIXME: Make two separate functions, one for loading animated cursors.
        // FIXME: Maybe do the string manipulation in UTF-8 for efficiency? ""u8 etc.
        internal static IntPtr[] LoadAnimatedHiddenCursor(string cursorName, SEL fallback, out double delay)
        {
            string cursorPath = Path.Combine("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/HIServices.framework/Versions/A/Resources/cursors", cursorName);
            string imagePath = Path.Combine(cursorPath, "cursor.pdf");

            IntPtr image = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSImageClass, Alloc), selInitWithContentsOfFile, ToNSString(imagePath));
            // FIXME: BOOL
            if (image == IntPtr.Zero || objc_msgSend_bool(image, selIsValid) == false)
            {
                // We could not load the image.. return the fallback.
                // FIXME: Can we avoid returning this array?
                delay = 0;
                return new IntPtr[1] { objc_msgSend_IntPtr((IntPtr)NSCursorClass, fallback) };
            }

            IntPtr dict = objc_msgSend_IntPtr((IntPtr)NSDictionaryClass, selDictionaryWithContentsOfFile, ToNSString(Path.Combine(cursorPath, "info.plist")));
            long frames = objc_msgSend_IntPtr(objc_msgSend_IntPtr(dict, selValueForKey, ToNSString("frames"u8)), selIntegerValue);

            double hotX = objc_msgSend_double(objc_msgSend_IntPtr(dict, selValueForKey, ToNSString("hotx"u8)), selDoubleValue);
            double hotY = objc_msgSend_double(objc_msgSend_IntPtr(dict, selValueForKey, ToNSString("hoty"u8)), selDoubleValue);
            CGPoint hotspot = new CGPoint((NFloat)hotX, (NFloat)hotY);

            if (frames > 1)
            {
                NSSize originalSize = objc_msgSend_NSSize(image, selSize);
                NFloat height = originalSize.height / frames;

                IntPtr[] cursors = new IntPtr[frames];
                for (int i = 0; i < frames; i++)
                {
                    NSSize size = new NSSize(originalSize.width, height);
                    IntPtr frameImage = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSImageClass, Alloc), selInitWithSize, size);

                    // FIXME: This is deprecated...
                    objc_msgSend(frameImage, selLockFocus);

                    CGRect sourceRect = new CGRect(0, height * i, originalSize.width, height);
                    CGRect destRect = new CGRect(0, 0, originalSize.width, height);
                    objc_msgSend(image, selDrawInRect_FromRect_Operation_Fraction, destRect, sourceRect, (nuint)NSCompositingOperator.Copy, 1);

                    objc_msgSend(frameImage, selUnlockFocus);

                    IntPtr cursor = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSCursorClass, Alloc), selInitWithImage_HotSpot, frameImage, hotspot);
                    cursors[i] = cursor;
                }

                delay = objc_msgSend_double(objc_msgSend_IntPtr(dict, selValueForKey, ToNSString("delay"u8)), selDoubleValue);
                return cursors;
            }
            else
            {
                IntPtr cursor = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSCursorClass, Alloc), selInitWithImage_HotSpot, image, hotspot);
                delay = 0;
                return new IntPtr[1] { cursor };
            }
        }

        internal IntPtr LoadHiddenCursor(string cursorName, SEL fallback)
        {
            string cursorPath = Path.Combine("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/HIServices.framework/Versions/A/Resources/cursors", cursorName);
            string imagePath = Path.Combine(cursorPath, "cursor.pdf");

            IntPtr image = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSImageClass, Alloc), selInitWithContentsOfFile, ToNSString(imagePath));
            // FIXME: BOOL
            if (image == IntPtr.Zero || objc_msgSend_bool(image, selIsValid) == false)
            {
                // We could not load the image.. return the fallback.
                // FIXME: Can we avoid returning this array?
                return objc_msgSend_IntPtr((IntPtr)NSCursorClass, fallback);
            }

            IntPtr dict = objc_msgSend_IntPtr((IntPtr)NSDictionaryClass, selDictionaryWithContentsOfFile, ToNSString(Path.Combine(cursorPath, "info.plist")));
            long frames = objc_msgSend_IntPtr(objc_msgSend_IntPtr(dict, selValueForKey, ToNSString("frames"u8)), selIntegerValue);

            double hotX = objc_msgSend_double(objc_msgSend_IntPtr(dict, selValueForKey, ToNSString("hotx"u8)), selDoubleValue);
            double hotY = objc_msgSend_double(objc_msgSend_IntPtr(dict, selValueForKey, ToNSString("hoty"u8)), selDoubleValue);
            CGPoint hotspot = new CGPoint((NFloat)hotX, (NFloat)hotY);

            if (frames > 1)
            {
                NSSize originalSize = objc_msgSend_NSSize(image, selSize);
                NFloat height = originalSize.height / frames;

                NSSize size = new NSSize(originalSize.width, height);
                IntPtr croppedImage = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSImageClass, Alloc), selInitWithSize, size);

                // FIXME: This is deprecated...
                objc_msgSend(croppedImage, selLockFocus);

                CGRect cropRect = new CGRect(0, 0, originalSize.width, height);
                objc_msgSend(image, selDrawInRect_FromRect_Operation_Fraction, cropRect, cropRect, (nuint)NSCompositingOperator.Copy, 1);

                objc_msgSend(croppedImage, selUnlockFocus);

                IntPtr cursor = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSCursorClass, Alloc), selInitWithImage_HotSpot, croppedImage, hotspot);
                return cursor;
            }
            else
            {
                IntPtr cursor = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSCursorClass, Alloc), selInitWithImage_HotSpot, image, hotspot);
                return cursor;
            }
        }

        public CursorHandle Create(SystemCursorType systemCursor)
        {
            IntPtr cursor;
            IntPtr[]? cursorFrames = null;
            NSCursorHandle.CursorMode mode = NSCursorHandle.CursorMode.SystemCursor;
            double delay = 0;
            switch (systemCursor)
            {
                case SystemCursorType.Default:
                    cursor = objc_msgSend_IntPtr((IntPtr)NSCursorClass, selArrowCursor);
                    break;
                case SystemCursorType.Loading:
                    // This isn't perfect, but it should be good enough.
                    cursor = IntPtr.Zero;
                    cursorFrames = LoadAnimatedHiddenCursor("busybutclickable", selArrowCursor, out delay);
                    mode = NSCursorHandle.CursorMode.AnimatedCursor;
                    if (cursorFrames.Length == 1)
                    {
                        cursor = cursorFrames[0];
                        cursorFrames = null;
                        mode = NSCursorHandle.CursorMode.SystemCursor;
                    }
                    break;
                case SystemCursorType.Wait:
                    cursor = IntPtr.Zero;
                    cursorFrames = LoadAnimatedHiddenCursor("busybutclickable", selArrowCursor, out delay);
                    mode = NSCursorHandle.CursorMode.AnimatedCursor;
                    if (cursorFrames.Length == 1)
                    {
                        cursor = cursorFrames[0];
                        cursorFrames = null;
                        mode = NSCursorHandle.CursorMode.SystemCursor;
                    }
                    break;
                case SystemCursorType.Cross:
                    cursor = objc_msgSend_IntPtr((IntPtr)NSCursorClass, selCrosshairCursor);
                    break;
                case SystemCursorType.Hand:
                    cursor = objc_msgSend_IntPtr((IntPtr)NSCursorClass, selPointingHandCursor);
                    break;
                case SystemCursorType.Help:
                    cursor = LoadHiddenCursor("help", selContextualMenuCursor);
                    break;
                case SystemCursorType.TextBeam:
                    cursor = objc_msgSend_IntPtr((IntPtr)NSCursorClass, selIBeamCursor);
                    break;
                case SystemCursorType.Forbidden:
                    cursor = objc_msgSend_IntPtr((IntPtr)NSCursorClass, selOperationNotAllowedCursor);
                    break;
                case SystemCursorType.ArrowFourway:
                    cursor = LoadHiddenCursor("move", selClosedHandCursor);
                    break;
                case SystemCursorType.ArrowNS:
                    cursor = LoadHiddenCursor("resizenorthsouth", selResizeUpDownCursor);
                    break;
                case SystemCursorType.ArrowEW:
                    cursor = LoadHiddenCursor("resizeeastwest", selResizeLeftRightCursor);
                    break;
                case SystemCursorType.ArrowNESW:
                    cursor = LoadHiddenCursor("resizenortheastsouthwest", selClosedHandCursor);
                    break;
                case SystemCursorType.ArrowNWSE:
                    cursor = LoadHiddenCursor("resizenorthwestsoutheast", selClosedHandCursor);
                    break;
                case SystemCursorType.ArrowUp:
                    // FIXME: There isn't really a good cursor for this...
                    cursor = objc_msgSend_IntPtr((IntPtr)NSCursorClass, selPointingHandCursor);
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(systemCursor), (int)systemCursor, typeof(SystemCursorType));
            }

            NSCursorHandle nscursor;
            switch (mode)
            {
                case NSCursorHandle.CursorMode.SystemCursor:
                    nscursor = new NSCursorHandle(NSCursorHandle.CursorMode.SystemCursor, cursor);
                    break;
                case NSCursorHandle.CursorMode.AnimatedCursor:
                    nscursor = new NSCursorHandle(NSCursorHandle.CursorMode.AnimatedCursor, cursorFrames!, delay);
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(mode), (int)mode, mode.GetType());
            }

            return nscursor;
        }

        public CursorHandle Create(int width, int height, ReadOnlySpan<byte> image, int hotspotX, int hotspotY)
        {
            throw new NotImplementedException();
        }

        public CursorHandle Create(int width, int height, ReadOnlySpan<byte> colorData, ReadOnlySpan<byte> maskData, int hotspotX, int hotspotY)
        {
            throw new NotImplementedException();
        }

        public void Destroy(CursorHandle handle)
        {
            // FIXME:
        }

        public bool IsSystemCursor(CursorHandle handle)
        {
            NSCursorHandle nscursor = handle.As<NSCursorHandle>(this);

            // FIXME: Differentiate Animated system cursors from custom animated cursors
            if (nscursor.Mode == NSCursorHandle.CursorMode.SystemCursor ||
                nscursor.Mode == NSCursorHandle.CursorMode.AnimatedCursor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GetSize(CursorHandle handle, out int width, out int height)
        {
            NSCursorHandle nscursor = handle.As<NSCursorHandle>(this);

            IntPtr standardUserDefaults = objc_msgSend_IntPtr((IntPtr)NSUserDefaultsClass, selStandardUserDefaults);
            IntPtr dict = objc_msgSend_IntPtr(standardUserDefaults, selPersistentDomainForName, ToNSString("com.apple.universalaccess"u8));
            IntPtr scalePtr = objc_msgSend_IntPtr(dict, selValueForKey, ToNSString("mouseDriverCursorSize"u8));

            // FIXME: Is this correct? Should we always get a value from the dictionary?
            int scale;
            if (scalePtr != IntPtr.Zero)
            {
                scale = (int)objc_msgSend_IntPtr(scalePtr, selIntegerValue);
            }
            else
            {
                scale = 1;
            }

            IntPtr cursor;
            switch (nscursor.Mode)
            {
                case NSCursorHandle.CursorMode.AnimatedCursor:
                    // Measure the current frame
                    cursor = nscursor.CursorFrames![nscursor.Frame];
                    break;
                case NSCursorHandle.CursorMode.SystemCursor:
                    cursor = nscursor.Cursor;
                    break;
                default:
                    cursor = IntPtr.Zero;
                    break;
            }
            if (cursor != IntPtr.Zero)
            {
                IntPtr image = objc_msgSend_IntPtr(cursor, selImage);
                NSSize size = objc_msgSend_NSSize(image, selSize);

                // FIXME: How should we round to float?
                width = (int)(size.width * scale);
                height = (int)(size.height * scale);
            }
            else
            {
                Logger?.LogWarning("Trying to get the size of an uninitialized cursor.");
                width = -1;
                height = -1;
            }
        }

        public void GetHotspot(CursorHandle handle, out int x, out int y)
        {
            NSCursorHandle nscursor = handle.As<NSCursorHandle>(this);

            CGPoint hotSpot = objc_msgSend_CGPoint(nscursor.Cursor, selHotSpot);

            x = (int)hotSpot.x;
            y = (int)hotSpot.y;
        }

        // FIXME: Is this the API we want to expose, or do we want to
        // expose an api for updating all cursors at the same time.
        // This requires us to constantly call SetCursor for the cursor to update
        // is that fine? Is there some other way we can animate the cursor?
        public void UpdateAnimation(CursorHandle handle, double deltaTime)
        {
            NSCursorHandle nscursor = handle.As<NSCursorHandle>(this);

            if (nscursor.Mode != NSCursorHandle.CursorMode.AnimatedCursor)
            {
                return;
            }

            nscursor.Time += deltaTime;
            while (nscursor.Time > nscursor.Delay)
            {
                nscursor.Frame = (nscursor.Frame + 1) % nscursor.CursorFrames!.Length;
                nscursor.Time -= nscursor.Delay;
            }
        }
    }
}


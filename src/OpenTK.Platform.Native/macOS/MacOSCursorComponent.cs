using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using static OpenTK.Platform.Native.macOS.ObjC;

namespace OpenTK.Platform.Native.macOS
{
    public class MacOSCursorComponent : ICursorComponent
    {
        internal static readonly ObjCClass NSCursorClass = objc_getClass("NSCursor"u8);
        internal static readonly ObjCClass NSImageClass = objc_getClass("NSImage"u8);
        internal static readonly ObjCClass NSDictionaryClass = objc_getClass("NSDictionary"u8);
        internal static readonly ObjCClass NSUserDefaultsClass = objc_getClass("NSUserDefaults"u8);
        internal static readonly ObjCClass NSBitmapImageRep = objc_getClass("NSBitmapImageRep"u8);

        internal static readonly IntPtr NSCalibratedRGBColorSpace = GetStringConstant(AppKitLibrary, "NSCalibratedRGBColorSpace"u8);

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
        internal static readonly SEL selAddRepresentation = sel_registerName("addRepresentation:"u8);

        internal static readonly SEL selStandardUserDefaults = sel_registerName("standardUserDefaults"u8);
        internal static readonly SEL selPersistentDomainForName = sel_registerName("persistentDomainForName:"u8);

        internal static readonly SEL selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BitmapFormat_BytesPerRow_BitsPerPixel = sel_registerName("initWithBitmapDataPlanes:pixelsWide:pixelsHigh:bitsPerSample:samplesPerPixel:hasAlpha:isPlanar:colorSpaceName:bitmapFormat:bytesPerRow:bitsPerPixel:"u8);
        internal static readonly SEL selBitmapData = sel_registerName("bitmapData"u8);
        internal static readonly SEL selSetSize = sel_registerName("setSize:"u8);


        // Keep a list of animated cursors?
        private List<NSCursorHandle> AnimatedCursors = new List<NSCursorHandle>();

        /// <inheritdoc/>
        public string Name => nameof(MacOSCursorComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.MouseCursor;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.MouseCursor)
            {
                throw new Exception("MacOSCursorComponent can only initialize the MouseCursor component.");
            }
        }

        /// <inheritdoc/>
        public bool CanLoadSystemCursors => true;

        /// <inheritdoc/>
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

        /// <inheritdoc/>
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
                    mode = NSCursorHandle.CursorMode.SystemAnimatedCursor;
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
                    mode = NSCursorHandle.CursorMode.SystemAnimatedCursor;
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
                // FIXME: Figure out if there are any hidden cursors we want to load here?
                case SystemCursorType.ArrowN:
                    cursor = objc_msgSend_IntPtr((IntPtr)NSCursorClass, selResizeUpCursor);
                    break;
                case SystemCursorType.ArrowE:
                    cursor = objc_msgSend_IntPtr((IntPtr)NSCursorClass, selResizeRightCursor);
                    break;
                case SystemCursorType.ArrowS:
                    cursor = objc_msgSend_IntPtr((IntPtr)NSCursorClass, selResizeDownCursor);
                    break;
                case SystemCursorType.ArrowW:
                    cursor = objc_msgSend_IntPtr((IntPtr)NSCursorClass, selResizeLeftCursor);
                    break;
                case SystemCursorType.ArrowNE:
                    // FIXME: Is there a hidden resize cursor for this?
                    cursor = LoadHiddenCursor("resizenortheastsouthwest", selClosedHandCursor);
                    break;
                case SystemCursorType.ArrowSE:
                    // FIXME: Is there a hidden resize cursor for this?
                    cursor = LoadHiddenCursor("resizenorthwestsoutheast", selClosedHandCursor);
                    break;
                case SystemCursorType.ArrowSW:
                    // FIXME: Is there a hidden resize cursor for this?
                    cursor = LoadHiddenCursor("resizenortheastsouthwest", selClosedHandCursor);
                    break;
                case SystemCursorType.ArrowNW:
                    // FIXME: Is there a hidden resize cursor for this?
                    cursor = LoadHiddenCursor("resizenorthwestsoutheast", selClosedHandCursor);
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
                case NSCursorHandle.CursorMode.SystemAnimatedCursor:
                    nscursor = new NSCursorHandle(NSCursorHandle.CursorMode.SystemAnimatedCursor, cursorFrames!, delay);
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(mode), (int)mode, mode.GetType());
            }

            return nscursor;
        }

        // FIXME: Some way to handle high DPI...?
        internal IntPtr NSCursorFromImage(int resX, int resY, float width, float height, ReadOnlySpan<byte> image, int hotspotX, int hotspotY)
        {
            IntPtr bitmap = objc_msgSend_IntPtr((IntPtr)NSBitmapImageRep, Alloc);
            // FIXME: BOOL
            bitmap = objc_msgSend_IntPtr(bitmap,
                selInitWithBitmapDataPlanes_PixelsWide_PixelsHigh_BitsPerSample_SamplesPerPixel_HasAlpha_IsPlanar_ColorSpaceName_BitmapFormat_BytesPerRow_BitsPerPixel,
                IntPtr.Zero,
                resX,
                resY,
                8,
                4,
                true,
                false,
                NSCalibratedRGBColorSpace,
                (nuint)NSBitmapFormat.AlphaNonpremultiplied,
                resX * 4,
                32);

            Debug.Assert(bitmap != 0);

            unsafe
            {
                Span<byte> data = new Span<byte>((void*)objc_msgSend_IntPtr(bitmap, selBitmapData), resX * resY * 4);
                image.CopyTo(data);
            }

            // FIXME: Dissociate the resolution from the screen size.
            // objc_msgSend(bitmap, selSetSize, new NSSize(width, height));

            IntPtr nsimage = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSImageClass, Alloc), selInitWithSize, new NSSize(resX, resY));
            objc_msgSend(nsimage, selAddRepresentation, bitmap);

            IntPtr nscursor = objc_msgSend_IntPtr(
                objc_msgSend_IntPtr((IntPtr)NSCursorClass, Alloc),
                selInitWithImage_HotSpot,
                nsimage,
                new CGPoint(hotspotX, hotspotY));

            objc_msgSend(bitmap, Release);
            objc_msgSend(nsimage, Release);

            return nscursor;
        }

        /// <inheritdoc/>
        public CursorHandle Create(int width, int height, ReadOnlySpan<byte> image, int hotspotX, int hotspotY)
        {
            IntPtr nscursor = NSCursorFromImage(width, height, width, height, image, hotspotX, hotspotY);

            NSCursorHandle handle = new NSCursorHandle(NSCursorHandle.CursorMode.CustomCursor, nscursor);

            return handle;
        }

        /// <inheritdoc/>
        public CursorHandle Create(int width, int height, ReadOnlySpan<byte> colorData, ReadOnlySpan<byte> maskData, int hotspotX, int hotspotY)
        {
            // Convert the image to RGBA interleaved format
            int pixels = width * height;
            byte[] imageData = new byte[pixels * 4];
            for (int i = 0; i < pixels; i++)
            {
                imageData[i * 4 + 0] = colorData[i * 3 + 0];
                imageData[i * 4 + 1] = colorData[i * 3 + 1];
                imageData[i * 4 + 2] = colorData[i * 3 + 2];
                imageData[i * 4 + 3] = maskData[i * 1 + 0] == 1 ? (byte)255 : (byte)0;
            }

            return Create(width, height, imageData, hotspotX, hotspotY);
        }

        public struct Frame
        {
            public int ResX;
            public int ResY;
            public float Width;
            public float Height;
            public int HotspotX;
            public int HotspotY;
            public byte[] Image;

            public Frame(int width, int height, byte[] image, int hotspotX, int hotspotY)
            {
                Width = width;
                Height = height;
                Image = image;
                HotspotX = hotspotX;
                HotspotY = hotspotY;
            }
        }

        /// <summary>
        /// Creates an animated cursor from a collection of frames.
        /// </summary>
        /// <param name="frames">The frames of the animation.</param>
        /// <param name="delay">The delay in seconds between frames of the animation.</param>
        /// <returns>The created animated cursor.</returns>
        public CursorHandle Create(Frame[] frames, float delay)
        {
            IntPtr[] cursorFrames = new IntPtr[frames.Length];
            for (int i = 0; i < frames.Length; i++)
            {
                Frame frame = frames[i];
                cursorFrames[i] = NSCursorFromImage(frame.ResX, frame.ResY, frame.Width, frame.Height, frame.Image, frame.HotspotX, frame.HotspotY);
            }

            NSCursorHandle handle = new NSCursorHandle(NSCursorHandle.CursorMode.SystemAnimatedCursor, cursorFrames, delay);

            return handle;
        }

        /// <inheritdoc/>
        public void Destroy(CursorHandle handle)
        {
            NSCursorHandle nscursor = handle.As<NSCursorHandle>(this);

            // FIXME: Is this all that is required to destroy the cursor?

            if (nscursor.Cursor != 0)
            {
                objc_msgSend(nscursor.Cursor, Release);
                nscursor.Cursor = 0;
            }

            if (nscursor.CursorFrames != null)
            {
                foreach (var frame in nscursor.CursorFrames)
                {
                    objc_msgSend(frame, Release);
                }
                nscursor.CursorFrames = null;
            }

            nscursor.Delay = 0;
            nscursor.Time = 0;
            nscursor.Frame = 0;

            nscursor.Mode = NSCursorHandle.CursorMode.Uninitialized;
        }

        /// <inheritdoc/>
        public bool IsSystemCursor(CursorHandle handle)
        {
            NSCursorHandle nscursor = handle.As<NSCursorHandle>(this);

            if (nscursor.Mode == NSCursorHandle.CursorMode.SystemCursor ||
                nscursor.Mode == NSCursorHandle.CursorMode.SystemAnimatedCursor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns true if the cursor is an animated cursor.
        /// </summary>
        /// <param name="handle">The cursor to check if it is an animated</param>
        /// <returns>True if the cursor is animated, false otherwise.</returns>
        public bool IsAnimatedCursor(CursorHandle handle)
        {
            NSCursorHandle nscursor = handle.As<NSCursorHandle>(this);

            if (nscursor.Mode == NSCursorHandle.CursorMode.SystemAnimatedCursor ||
                nscursor.Mode == NSCursorHandle.CursorMode.CustomAnimatedCursor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <inheritdoc/>
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
                case NSCursorHandle.CursorMode.SystemAnimatedCursor:
                    // Measure the current frame
                    cursor = nscursor.CursorFrames![nscursor.Frame];
                    break;
                case NSCursorHandle.CursorMode.SystemCursor:
                    cursor = nscursor.Cursor;
                    break;
                case NSCursorHandle.CursorMode.CustomCursor:
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

        /// <inheritdoc/>
        public void GetHotspot(CursorHandle handle, out int x, out int y)
        {
            NSCursorHandle nscursor = handle.As<NSCursorHandle>(this);

            if (nscursor.Mode == NSCursorHandle.CursorMode.SystemAnimatedCursor ||
                nscursor.Mode == NSCursorHandle.CursorMode.CustomAnimatedCursor)
            {
                CGPoint hotSpot = objc_msgSend_CGPoint(nscursor.CursorFrames![nscursor.Frame], selHotSpot);

                x = (int)hotSpot.x;
                y = (int)hotSpot.y;
            }
            else
            {
                CGPoint hotSpot = objc_msgSend_CGPoint(nscursor.Cursor, selHotSpot);

                x = (int)hotSpot.x;
                y = (int)hotSpot.y;
            }
        }

        /// <summary>
        /// Updates the animation of an animated cursor.
        /// When animated cursors change frame <see cref="IWindowComponent.SetCursor(WindowHandle, CursorHandle?)"/> needs to be called to properly animate.
        /// This function returns true if the cursor needs to be set again.
        /// </summary>
        /// <param name="handle">An animated cursor to update.</param>
        /// <param name="deltaTime">The amount of time to advance the cursor animation.</param>
        /// <returns>True if the cursor frame has changed and <see cref="IWindowComponent.SetCursor(WindowHandle, CursorHandle?)"/> needs to be called for the cursor to update, false otherwise.</returns>
        public bool UpdateAnimation(CursorHandle handle, double deltaTime)
        {
            NSCursorHandle nscursor = handle.As<NSCursorHandle>(this);

            if (nscursor.Mode != NSCursorHandle.CursorMode.SystemAnimatedCursor)
            {
                return false;
            }

            int startFrame = nscursor.Frame;

            // If delay is negative, invert deltaTime as we are playing the animation backwards.
            if (nscursor.Delay < 0)
            {
                deltaTime = -deltaTime;
            }

            nscursor.Time += deltaTime;
            while (double.Abs(nscursor.Time) > double.Abs(nscursor.Delay))
            {
                // Handle both positive and negative animation direction.
                if (nscursor.Delay > 0)
                {
                    nscursor.Frame = (nscursor.Frame + 1) % nscursor.CursorFrames!.Length;
                }
                else
                {
                    nscursor.Frame--;
                    if (nscursor.Frame < 0)
                        nscursor.Frame = nscursor.CursorFrames!.Length - 1;
                }

                nscursor.Time -= nscursor.Delay;
            }

            return startFrame != nscursor.Frame;
        }
    }
}


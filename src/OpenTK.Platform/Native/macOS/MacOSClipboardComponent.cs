using System;
using System.Collections.Generic;
using OpenTK.Platform;
using OpenTK.Core.Utility;
using static OpenTK.Platform.Native.macOS.ObjC;
using static OpenTK.Platform.Native.macOS.CG;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace OpenTK.Platform.Native.macOS
{
    public class MacOSClipboardComponent : IClipboardComponent
    {
        internal static readonly ObjCClass NSPasteboardClass = objc_getClass("NSPasteboard"u8);
        internal static readonly ObjCClass NSImageClass = objc_getClass("NSImage"u8);
        internal static readonly ObjCClass NSGraphicsContextClass = objc_getClass("NSGraphicsContext"u8);
        internal static readonly ObjCClass NSArrayClass = objc_getClass("NSArray"u8);
        internal static readonly ObjCClass NSStringClass = objc_getClass("NSString"u8);
        internal static readonly ObjCClass NSURLClass = objc_getClass("NSURL"u8);

        internal static readonly SEL selGeneralPasteboard = sel_registerName("generalPasteboard"u8);
        internal static readonly SEL selTypes = sel_registerName("types"u8);
        internal static readonly SEL selCount = sel_registerName("count"u8);
        internal static readonly SEL selObjectAtIndex = sel_registerName("objectAtIndex:"u8);
        internal static readonly SEL selIsEqualToString = sel_registerName("isEqualToString:"u8);
        internal static readonly SEL selStringForType = sel_registerName("stringForType:"u8);
        internal static readonly SEL selInitWithPasteboard = sel_registerName("initWithPasteboard:"u8);
        internal static readonly SEL selSize = sel_registerName("size"u8);
        internal static readonly SEL selGraphicsContextWithCGContext_flipped = sel_registerName("graphicsContextWithCGContext:flipped:"u8);
        internal static readonly SEL selSetCurrentContext = sel_registerName("setCurrentContext:"u8);
        internal static readonly SEL selDrawInRect = sel_registerName("drawInRect:"u8);
        internal static readonly SEL selClearContents = sel_registerName("clearContents"u8);
        internal static readonly SEL selsetString_forType = sel_registerName("setString:forType:"u8);
        internal static readonly SEL selDeclareTypes_owner = sel_registerName("declareTypes:owner:"u8);
        internal static readonly SEL selArrayWithObject = sel_registerName("arrayWithObject:"u8);
        internal static readonly SEL selPasteboardItems = sel_registerName("pasteboardItems"u8);
        internal static readonly SEL selDataForType = sel_registerName("dataForType:"u8);
        internal static readonly SEL selBytes = sel_registerName("bytes"u8);
        internal static readonly SEL selLength = sel_registerName("length"u8);
        internal static readonly SEL selWriteObjects = sel_registerName("writeObjects:"u8);
        internal static readonly SEL selChangeCount = sel_registerName("changeCount"u8);

        internal static readonly SEL selInitWithData_encoding = sel_registerName("initWithData:encoding:"u8);
        internal static readonly SEL selURLWithString = sel_registerName("URLWithString:"u8);
        internal static readonly SEL selFileSystemRepresentation = sel_registerName("fileSystemRepresentation"u8);

        internal static readonly SEL selInitWithCGImage_size = sel_registerName("initWithCGImage:size:"u8);

        internal static readonly IntPtr NSPasteboardTypeString = GetStringConstant(AppKitLibrary, "NSPasteboardTypeString"u8);
        internal static readonly IntPtr NSPasteboardTypeSound = GetStringConstant(AppKitLibrary, "NSPasteboardTypeSound"u8);
        internal static readonly IntPtr NSPasteboardTypePNG = GetStringConstant(AppKitLibrary, "NSPasteboardTypePNG"u8);
        internal static readonly IntPtr NSPasteboardTypeTIFF = GetStringConstant(AppKitLibrary, "NSPasteboardTypeTIFF"u8);
        internal static readonly IntPtr NSPasteboardTypeFileURL = GetStringConstant(AppKitLibrary, "NSPasteboardTypeFileURL"u8);

        internal static readonly IntPtr NSCalibratedRGBColorSpace = GetStringConstant(AppKitLibrary, "NSCalibratedRGBColorSpace"u8);

        internal static readonly IntPtr kCGColorSpaceSRGB = GetStringConstant(AppKitLibrary, "kCGColorSpaceSRGB"u8);
        internal static readonly IntPtr kCGColorSpaceLinearSRGB = GetStringConstant(AppKitLibrary, "kCGColorSpaceLinearSRGB"u8);
        internal static readonly IntPtr kCGColorSpaceGenericRGBLinear = GetStringConstant(AppKitLibrary, "kCGColorSpaceGenericRGBLinear"u8);


        /// <inheritdoc/>
        public string Name => nameof(MacOSClipboardComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Clipboard;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        private static nint ChangeCount = 0;

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            IntPtr pasteboard = objc_msgSend_IntPtr((IntPtr)NSPasteboardClass, selGeneralPasteboard);
            ChangeCount = objc_msgSend_IntPtr(pasteboard, selChangeCount);
        }

        // FIXME: Make this not static...
        public static bool CheckClipboardUpdate()
        {
            IntPtr pasteboard = objc_msgSend_IntPtr((IntPtr)NSPasteboardClass, selGeneralPasteboard);
            nint changeCount = objc_msgSend_IntPtr(pasteboard, selChangeCount);
            bool changed = changeCount != ChangeCount;
            ChangeCount = changeCount;
            return changed;
        }

        /// <inheritdoc/>
        public IReadOnlyList<ClipboardFormat> SupportedFormats => _SupportedFormats;

        private static readonly ClipboardFormat[] _SupportedFormats = new[]
        {
            ClipboardFormat.Text,
            ClipboardFormat.Files,
            ClipboardFormat.Bitmap,
            //ClipboardFormat.Audio,
        };

        internal static ClipboardFormat GetClipboardFormatInternal(ILogger? logger)
        {
            IntPtr pasteboard = objc_msgSend_IntPtr((IntPtr)NSPasteboardClass, selGeneralPasteboard);

            IntPtr types = objc_msgSend_IntPtr(pasteboard, selTypes);
            nuint count = (nuint)objc_msgSend_IntPtr(types, selCount);
            ClipboardFormat format = ClipboardFormat.None;
            logger?.LogDebug($"Clipboard formats: {count} ({ChangeCount})");
            for (nuint i = 0; i < count; i++)
            {
                IntPtr type = objc_msgSend_IntPtr(types, selObjectAtIndex, i);
                string typeStr = FromNSString(type);
                logger?.LogDebug($"Type {i}: {typeStr}");
            }
            for (nuint i = 0; i < count; i++)
            {
                IntPtr type = objc_msgSend_IntPtr(types, selObjectAtIndex, i);
                if (objc_msgSend_bool(NSPasteboardTypeString, selIsEqualToString, type))
                {
                    format = ClipboardFormat.Text;
                    break;
                }
                else if (objc_msgSend_bool(NSPasteboardTypePNG, selIsEqualToString, type) ||
                         objc_msgSend_bool(NSPasteboardTypeTIFF, selIsEqualToString, type))
                {
                    format = ClipboardFormat.Bitmap;
                    break;
                }
                else if (objc_msgSend_bool(NSPasteboardTypeSound, selIsEqualToString, type))
                {
                    format = ClipboardFormat.Audio;
                    break;
                }
                else if (objc_msgSend_bool(NSPasteboardTypeFileURL, selIsEqualToString, type))
                {
                    format = ClipboardFormat.Files;
                    break;
                }
            }

            return format;
        }

        /// <inheritdoc/>
        public ClipboardFormat GetClipboardFormat()
        {
            return GetClipboardFormatInternal(Logger);
        }

        /// <inheritdoc/>
        public void SetClipboardText(string text)
        {
            IntPtr pasteboard = objc_msgSend_IntPtr((IntPtr)NSPasteboardClass, selGeneralPasteboard);

            nint changecount = objc_msgSend_IntPtr(pasteboard, selClearContents);

            IntPtr typesArray = objc_msgSend_IntPtr((IntPtr)NSArrayClass, selArrayWithObject, NSPasteboardTypeString);

            objc_msgSend_IntPtr(pasteboard, selDeclareTypes_owner, typesArray, (IntPtr)0);

            IntPtr nsstr = ToNSString(text);
            bool written = objc_msgSend_bool(pasteboard, selsetString_forType, nsstr, NSPasteboardTypeString);
            if (written == false)
            {
                Logger?.LogWarning("Failed to write string to pasteboard.");
            }

            objc_msgSend(pasteboard, Release);
        }

        /// <inheritdoc/>
        public string? GetClipboardText()
        {
            IntPtr pasteboard = objc_msgSend_IntPtr((IntPtr)NSPasteboardClass, selGeneralPasteboard);

            IntPtr nsstr = objc_msgSend_IntPtr(pasteboard, selStringForType, NSPasteboardTypeString);
            string str = FromNSString(nsstr);

            objc_msgSend(pasteboard, Release);

            return str;
        }

        /// <inheritdoc/>
        public unsafe AudioData? GetClipboardAudio()
        {
            // NSSound can read from the clipboard but doesn't provide access to the
            // underlying audio data.
            // There is stuff like Audio Toolbox that allows more access but it doesn't have
            // functions for reading sound data from the clipboard directly.
            // - Noggin_bops 2024-06-03
            Logger?.LogError("We currently don't support clipboard audio on macOS. If this is an issue please open an issue at: https://github.com/opentk/opentk/issues/new. Please include what program was used to copy the sound.");
            return null;
        }

        /// <summary>
        /// Writes a bitmap to the clipboard.
        /// </summary>
        /// <param name="bitmap">The bitmap to write to the clipboard.</param>
        public unsafe void SetClipboardBitmap(Bitmap bitmap)
        {
            IntPtr pasteboard = objc_msgSend_IntPtr((IntPtr)NSPasteboardClass, selGeneralPasteboard);

            nint changecount = objc_msgSend_IntPtr(pasteboard, selClearContents);

            // FIXME: What is the proper colorspace...
            IntPtr space = CGColorSpaceCreateWithName(kCGColorSpaceSRGB);
            void* data = NativeMemory.Alloc((nuint)bitmap.Data.Length);
            fixed(byte* ptr = bitmap.Data)
            {
                NativeMemory.Copy(ptr, data, (nuint)bitmap.Data.Length);
            }

            // Inline UnmanagedCallerOnly function for freeing the data.
            [UnmanagedCallersOnly(CallConvs = new [] { typeof(CallConvCdecl) })]
            static void FreeImage(void* info, void* data, nuint size)
            {
                // FIXME: Do ever get here? I wasn't able to trigger this...
                // - Noggin_bops 2024-06-03
                NativeMemory.Free(data);
            }

            IntPtr provider = CGDataProviderCreateWithData(null, data, (nuint)bitmap.Data.Length, &FreeImage);

            IntPtr cgimage = CGImageCreate(
                (nuint)bitmap.Width,
                (nuint)bitmap.Height,
                8,
                32,
                4 * (nuint)bitmap.Width,
                space,
                (uint)CGImageAlphaInfo.kCGImageAlphaNoneSkipLast | (uint)CGBitmapInfo.kCGBitmapByteOrderDefault,
                provider,
                null,
                false,
                CGColorRenderingIntent.kCGRenderingIntentDefault);

            IntPtr image = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSImageClass, Alloc), selInitWithCGImage_size, cgimage, NSSize.NSZeroSize);
            IntPtr imageArray = objc_msgSend_IntPtr((IntPtr)NSArrayClass, selArrayWithObject, image);

            bool success = objc_msgSend_bool(pasteboard, selWriteObjects, imageArray);
            if (success == false)
            {
                Logger?.LogWarning("Failed to write NSImage to pasteboard.");
            }

            objc_msgSend(imageArray, Release);
            objc_msgSend(image, Release);
            CGImageRelease(cgimage);
            CGDataProviderRelease(provider);
          
            // FIXME: Do we need to free any other resources?
        }

        /// <inheritdoc/>
        public unsafe Bitmap? GetClipboardBitmap()
        {
            IntPtr pasteboard = objc_msgSend_IntPtr((IntPtr)NSPasteboardClass, selGeneralPasteboard);

            IntPtr image = objc_msgSend_IntPtr((IntPtr)NSImageClass, Alloc);
            image = objc_msgSend_IntPtr(image, selInitWithPasteboard, pasteboard);

            NSSize size = objc_msgSend_NSSize(image, selSize);

            nuint width = (nuint)size.width;
            nuint height = (nuint)size.height;

            // FIXME: Read out the alpha channel too...
            // Though it seems the alpha is working for images that are
            // copied online with transparency, so maybe we don't need to do anything.
            // - Noggin_bops 2024-05-20
            IntPtr sRGBColorSpace = CGColorSpaceCreateWithName(kCGColorSpaceSRGB);
            byte[] data = new byte[width * height * 4];
            fixed(byte* dataPtr = data)
            {
                // FIXME: Render the image into a alpha only version too so we can
                // work around the limitation that CGBitmapContexts only support
                // premultiplied alpha.
                IntPtr context = CGBitmapContextCreate(dataPtr, width, height, 8, 4 * width, sRGBColorSpace, (uint)CGImageAlphaInfo.kCGImageAlphaNoneSkipLast | (uint)CGBitmapInfo.kCGBitmapByteOrderDefault);
                CGContextTranslateCTM(context, 0.0f, height);
                CGContextScaleCTM(context, 1.0f, -1.0f);
                IntPtr nscontext = objc_msgSend_IntPtr((IntPtr)NSGraphicsContextClass, selGraphicsContextWithCGContext_flipped, context, false);

                objc_msgSend((IntPtr)NSGraphicsContextClass, selSetCurrentContext, nscontext);

                objc_msgSend(image, selDrawInRect, new CGRect(0, 0, width, height));

                objc_msgSend((IntPtr)NSGraphicsContextClass, selSetCurrentContext, (IntPtr)0);

                objc_msgSend(nscontext, Release);
                CGContextRelease(context);
            }

            Bitmap bitmap = new Bitmap((int)width, (int)height, data);

            objc_msgSend(pasteboard, Release);

            return bitmap;
        }

        /// <inheritdoc/>
        public List<string>? GetClipboardFiles()
        {
            IntPtr pasteboard = objc_msgSend_IntPtr((IntPtr)NSPasteboardClass, selGeneralPasteboard);
            IntPtr items = objc_msgSend_IntPtr(pasteboard, selPasteboardItems);

            // FIXME: Return null if the current format isn't ClipboardFormat.Files.
            // This is what the documentation for this function says we should do.
            // - Noggin_bops 2024-06-02

            nuint count = (nuint)objc_msgSend_IntPtr(items, selCount);
            List<string>? files = new List<string>(int.CreateSaturating(count));
            for (nuint i = 0; i < count; i++)
            {
                IntPtr item = objc_msgSend_IntPtr(items, selObjectAtIndex, i);
                IntPtr itemData = objc_msgSend_IntPtr(item, selDataForType, NSPasteboardTypeFileURL);
                if (itemData != IntPtr.Zero)
                {
                    IntPtr dataStr = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSStringClass, Alloc), selInitWithData_encoding, itemData, (ulong)NSStringEncoding.UTF8);
                    IntPtr url = objc_msgSend_IntPtr((IntPtr)NSURLClass, selURLWithString, dataStr);
                    string path = Marshal.PtrToStringUTF8(objc_msgSend_IntPtr(url, selFileSystemRepresentation))!;
                    files.Add(path);
                    objc_msgSend(dataStr, Release);
                    // FIXME: Are there any other objects we need to release?
                }
            }

            return files;
        }
    }
}


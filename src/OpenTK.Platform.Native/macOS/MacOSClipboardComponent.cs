using System;
using System.Collections.Generic;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using static OpenTK.Platform.Native.macOS.ObjC;
using static OpenTK.Platform.Native.macOS.CG;
using System.Runtime.InteropServices;

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

        internal static readonly SEL selInitWithData_encoding = sel_registerName("initWithData:encoding:"u8);
        internal static readonly SEL selURLWithString = sel_registerName("URLWithString:"u8);
        internal static readonly SEL selFileSystemRepresentation = sel_registerName("fileSystemRepresentation"u8);

        internal static readonly IntPtr NSPasteboardTypeString = GetStringConstant(AppKitLibrary, "NSPasteboardTypeString"u8);
        internal static readonly IntPtr NSPasteboardTypeSound = GetStringConstant(AppKitLibrary, "NSPasteboardTypeSound"u8);
        internal static readonly IntPtr NSPasteboardTypePNG = GetStringConstant(AppKitLibrary, "NSPasteboardTypePNG"u8);
        internal static readonly IntPtr NSPasteboardTypeTIFF = GetStringConstant(AppKitLibrary, "NSPasteboardTypeTIFF"u8);
        internal static readonly IntPtr NSPasteboardTypeFileURL = GetStringConstant(AppKitLibrary, "NSPasteboardTypeFileURL"u8);

        internal static readonly IntPtr NSCalibratedRGBColorSpace = GetStringConstant(AppKitLibrary, "NSCalibratedRGBColorSpace"u8);

        internal static readonly IntPtr kCGColorSpaceSRGB = GetStringConstant(AppKitLibrary, "kCGColorSpaceSRGB"u8);
        internal static readonly IntPtr kCGColorSpaceLinearSRGB = GetStringConstant(AppKitLibrary, "kCGColorSpaceLinearSRGB"u8);
        internal static readonly IntPtr kCGColorSpaceGenericRGBLinear = GetStringConstant(AppKitLibrary, "kCGColorSpaceGenericRGBLinear"u8);
        


        public string Name => nameof(MacOSClipboardComponent);

        public PalComponents Provides => PalComponents.Clipboard;

        public ILogger? Logger { get; set; }

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Clipboard)
            {
                throw new Exception("MacOSClipboardComponent can only initialize the Clipboard component.");
            }
        }

        public IReadOnlyList<ClipboardFormat> SupportedFormats => _SupportedFormats;

        private static readonly ClipboardFormat[] _SupportedFormats = new[]
        {
            ClipboardFormat.Text,
            //ClipboardFormat.HTML,
            //ClipboardFormat.Files,
            ClipboardFormat.Bitmap,
            //ClipboardFormat.Audio,
        };

        public ClipboardFormat GetClipboardFormat()
        {
            IntPtr pasteboard = objc_msgSend_IntPtr((IntPtr)NSPasteboardClass, selGeneralPasteboard);

            IntPtr types = objc_msgSend_IntPtr(pasteboard, selTypes);
            nuint count = (nuint)objc_msgSend_IntPtr(types, selCount);
            ClipboardFormat format = ClipboardFormat.None;
            for (nuint i = 0; i < count; i++)
            {
                IntPtr type = objc_msgSend_IntPtr(types, selObjectAtIndex, i);
                string typeStr = FromNSString(type);
                Console.WriteLine($"Type {i}: {typeStr}");
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

            objc_msgSend(pasteboard, Release);

            return format;
        }

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

        public string? GetClipboardText()
        {
            IntPtr pasteboard = objc_msgSend_IntPtr((IntPtr)NSPasteboardClass, selGeneralPasteboard);

            IntPtr nsstr = objc_msgSend_IntPtr(pasteboard, selStringForType, NSPasteboardTypeString);
            string str = FromNSString(nsstr);

            objc_msgSend(pasteboard, Release);

            return str;
        }

        public AudioData? GetClipboardAudio()
        {
            throw new NotImplementedException();
        }

        public unsafe Bitmap? GetClipboardBitmap()
        {
            IntPtr pasteboard = objc_msgSend_IntPtr((IntPtr)NSPasteboardClass, selGeneralPasteboard);

            IntPtr image = objc_msgSend_IntPtr((IntPtr)NSImageClass, Alloc);
            image = objc_msgSend_IntPtr(image, selInitWithPasteboard, pasteboard);

            NSSize size = objc_msgSend_NSSize(image, selSize);
            Console.WriteLine(size);

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

        public string? GetClipboardHTML()
        {
            throw new NotImplementedException();
        }

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


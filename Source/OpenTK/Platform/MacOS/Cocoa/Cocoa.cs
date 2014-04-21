using System.Runtime.InteropServices;
using System;
using System.Drawing;

namespace OpenTK.Platform.MacOS
{
    static class Cocoa
    {
        static readonly IntPtr selUTF8String = Selector.Get("UTF8String");

        internal const string LibObjC = "/usr/lib/libobjc.dylib";

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, ulong ulong1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, IntPtr intPtr1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, IntPtr intPtr1, int int1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, IntPtr intPtr1, IntPtr intPtr2);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, IntPtr intPtr1, IntPtr intPtr2, IntPtr intPtr3);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, RectangleF rectangle1, int int1, int int2, bool bool1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, uint uint1, IntPtr intPtr1, IntPtr intPtr2, bool bool1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, RectangleF rectangle1, int int1, IntPtr intPtr1, IntPtr intPtr2);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static bool SendBool(IntPtr receiver, IntPtr selector);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static bool SendBool(IntPtr receiver, IntPtr selector, int int1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, uint uint1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, IntPtr intPtr1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, IntPtr intPtr1, int int1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, IntPtr intPtr1, IntPtr intPtr2);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, int int1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, bool bool1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, PointF point1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, RectangleF rect1, bool bool1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static int SendInt(IntPtr receiver, IntPtr selector);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static uint SendUint(IntPtr receiver, IntPtr selector);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static ushort SendUshort(IntPtr receiver, IntPtr selector);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static float SendFloat(IntPtr receiver, IntPtr selector);

        [DllImport (LibObjC, EntryPoint="objc_msgSend")] // Not the _stret version, perhaps because a PointF fits in one register?
        public extern static PointF SendPoint(IntPtr receiver, IntPtr selector);

        [DllImport (LibObjC, EntryPoint="objc_msgSend_stret")]
        extern static void SendRect(out System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector);

        [DllImport (LibObjC, EntryPoint="objc_msgSend_stret")]
        extern static void SendRect(out System.Drawing.RectangleF retval, IntPtr receiver, IntPtr selector, RectangleF rect1);

        public static RectangleF SendRect(IntPtr receiver, IntPtr selector)
        {
            RectangleF r;
            SendRect(out r, receiver, selector);
            return r;
        }

        public static RectangleF SendRect(IntPtr receiver, IntPtr selector, RectangleF rect1)
        {
            RectangleF r;
            SendRect(out r, receiver, selector, rect1);
            return r;
        }

        public static IntPtr ToNSString(string str)
        {
            if (str == null)
                return IntPtr.Zero;

            unsafe 
            {
                fixed (char* ptrFirstChar = str)
                {
                    var handle = Cocoa.SendIntPtr(Class.Get("NSString"), Selector.Alloc);
                    handle = Cocoa.SendIntPtr(handle, Selector.Get("initWithCharacters:length:"), (IntPtr)ptrFirstChar, str.Length);
                    return handle;
                }
            }
        }

        public static string FromNSString(IntPtr handle)
        {
            return Marshal.PtrToStringAuto(SendIntPtr(handle, selUTF8String));
        }

        public static unsafe IntPtr ToNSImage(Image img)
        {
            using (System.IO.MemoryStream s = new System.IO.MemoryStream())
            {
                img.Save(s, System.Drawing.Imaging.ImageFormat.Png);
                byte[] b = s.ToArray();

                fixed (byte* pBytes = b)
                {
                    IntPtr nsData = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSData"), Selector.Alloc),
                        Selector.Get("initWithBytes:length:"), (IntPtr)pBytes, b.Length),
                        Selector.Autorelease);

                    IntPtr nsImage = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSImage"), Selector.Alloc), 
                        Selector.Get("initWithData:"), nsData),
                        Selector.Autorelease);

                    return nsImage;
                }
            }
        }

        public static IntPtr GetStringConstant(IntPtr handle, string symbol)
        {
            var indirect = NS.GetSymbol(handle, symbol);
            if (indirect == IntPtr.Zero)
                return IntPtr.Zero;

            var actual = Marshal.ReadIntPtr(indirect);
            if (actual == IntPtr.Zero)
                return IntPtr.Zero;

            return actual;
        }

        public static IntPtr AppKitLibrary;
        public static IntPtr FoundationLibrary;

        public static void Initialize()
        {
            if (AppKitLibrary != IntPtr.Zero)
            {
                return;
            }

            AppKitLibrary = NS.LoadLibrary("/System/Library/Frameworks/AppKit.framework/AppKit");
            FoundationLibrary = NS.LoadLibrary("/System/Library/Frameworks/Foundation.framework/Foundation");

            NSApplication.Initialize();
        }
    }
}

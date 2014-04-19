using System.Runtime.InteropServices;
using System;
using System.Drawing;

namespace OpenTK.Platform.MacOS
{
    static class Cocoa
    {
        internal const string LibObjC = "/usr/lib/libobjc.dylib";

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, IntPtr intPtr1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, IntPtr intPtr1, int int1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, IntPtr intPtr1, IntPtr intPtr2);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, RectangleF rectangle1, int int1, int int2, bool bool1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, uint mask, IntPtr intPtr1, IntPtr intPtr2, bool bool1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static bool SendBool(IntPtr receiver, IntPtr selector, int int1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, IntPtr intPtr1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, IntPtr intPtr1, int int1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, int int1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, bool bool1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, PointF point1);

        public static IntPtr ToNative(string str)
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

        public static IntPtr GetStringConstant(IntPtr handle, string symbol)
        {
            var indirect = NS.GetSymbol(handle, symbol);
            if (indirect == IntPtr.Zero)
                return IntPtr.Zero;

            var actual = Marshal.ReadIntPtr(indirect);
            if (actual == IntPtr.Zero)
                return IntPtr.Zero;

            return actual;
            //return (NSString) Runtime.GetNSObject (actual);
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

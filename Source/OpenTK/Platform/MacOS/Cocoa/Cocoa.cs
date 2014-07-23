#region License
//
// Cocoa.cs
//
// Author:
//       Olle Håkansson <ollhak@gmail.com>
//
// Copyright (c) 2014 Olle Håkansson
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

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
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, NSSize size);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, IntPtr intPtr1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, IntPtr intPtr1, int int1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, IntPtr intPtr1, IntPtr intPtr2);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, IntPtr intPtr1, IntPtr intPtr2, IntPtr intPtr3);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, IntPtr intPtr1, IntPtr intPtr2, IntPtr intPtr3, IntPtr intPtr4, IntPtr intPtr5);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, IntPtr p1, NSPoint p2);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, bool p1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, NSPoint p1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, NSRect rectangle1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, NSRect rectangle1, int int1, int int2, bool bool1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, uint uint1, IntPtr intPtr1, IntPtr intPtr2, bool bool1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, NSRect rectangle1, int int1, IntPtr intPtr1, IntPtr intPtr2);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static IntPtr SendIntPtr(IntPtr receiver, IntPtr selector, IntPtr p1, int p2, int p3, int p4, int p5, int p6, int p7, IntPtr p8, NSBitmapFormat p9, int p10, int p11);

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
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, NSPoint point1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, NSRect rect1, bool bool1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static void SendVoid(IntPtr receiver, IntPtr selector, NSRect rect1, IntPtr intPtr1);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static int SendInt(IntPtr receiver, IntPtr selector);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static uint SendUint(IntPtr receiver, IntPtr selector);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        public extern static ushort SendUshort(IntPtr receiver, IntPtr selector);

        [DllImport(LibObjC, EntryPoint="objc_msgSend_fpret")]
        extern static float SendFloat_i386(IntPtr receiver, IntPtr selector);

        [DllImport(LibObjC, EntryPoint="objc_msgSend")]
        extern static float SendFloat_normal(IntPtr receiver, IntPtr selector);

        public static float SendFloat(IntPtr receiver, IntPtr selector)
        {
            #if IOS
            return SendFloat_normal(receiver, selector);
            #else
            if (IntPtr.Size == 4)
            {
                return SendFloat_i386(receiver, selector);
            }
            else
            {
                return SendFloat_normal(receiver, selector);
            }
            #endif
        }

        // Not the _stret version, perhaps because a NSPoint fits in one register?
        // thefiddler: gcc is indeed using objc_msgSend for NSPoint on i386
        [DllImport (LibObjC, EntryPoint="objc_msgSend")]
        public extern static NSPoint SendPoint(IntPtr receiver, IntPtr selector);

        [DllImport (LibObjC, EntryPoint="objc_msgSend_stret")]
        extern static void SendRect(out NSRect retval, IntPtr receiver, IntPtr selector);

        [DllImport (LibObjC, EntryPoint="objc_msgSend_stret")]
        extern static void SendRect(out NSRect retval, IntPtr receiver, IntPtr selector, NSRect rect1);

        public static NSRect SendRect(IntPtr receiver, IntPtr selector)
        {
            NSRect r;
            SendRect(out r, receiver, selector);
            return r;
        }

        public static NSRect SendRect(IntPtr receiver, IntPtr selector, NSRect rect1)
        {
            NSRect r;
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
                    IntPtr nsData = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSData"), Selector.Alloc),
                        Selector.Get("initWithBytes:length:"), (IntPtr)pBytes, b.Length);

                    IntPtr nsImage = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSImage"), Selector.Alloc), 
                        Selector.Get("initWithData:"), nsData);

                    Cocoa.SendVoid(nsData, Selector.Release);
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
        }
    }
}

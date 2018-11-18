//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Platform.MacOS.Carbon
{
    using CFAllocatorRef = IntPtr;
    using CFIndex = IntPtr;
    using CFRunLoop = IntPtr;
    using CFRunLoopRef = IntPtr;
    using CFRunLoopSourceRef = IntPtr;
    using CFStringRef = IntPtr;
    using CFTypeRef = IntPtr;
    using CFMachPortRef = IntPtr;

    internal struct CFArray
    {
        public IntPtr Ref { get; set; }

        public CFArray(IntPtr reference)
        {
            Ref = reference;
        }

        public int Count => CF.CFArrayGetCount(Ref);

        public IntPtr this[int index]
        {
            get
            {
                if (index >= Count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                return CF.CFArrayGetValueAtIndex(Ref, index);
            }
        }
    }

    internal struct CFDictionary
    {
        public CFDictionary(IntPtr reference)
        {
            Ref = reference;
        }

        public IntPtr Ref { get; set; }

        public int Count => CF.CFDictionaryGetCount(Ref);

        public double GetNumberValue(string key)
        {
            double retval;
            var cfnum = CF.CFDictionaryGetValue(Ref,
                CF.CFSTR(key));

            CF.CFNumberGetValue(cfnum, CF.CFNumberType.kCFNumberDoubleType, out retval);

            return retval;
        }
    }

    internal class CF
    {
        public enum CFRunLoopExitReason
        {
            Finished = 1,
            Stopped = 2,
            TimedOut = 3,
            HandledSource = 4
        }

        public enum CFStringEncoding
        {
            MacRoman = 0,
            WindowsLatin1 = 0x0500,
            ISOLatin1 = 0x0201,
            NextStepLatin = 0x0B01,
            ASCII = 0x0600,
            Unicode = 0x0100,
            UTF8 = 0x08000100,
            NonLossyASCII = 0x0BFF,

            UTF16 = 0x0100,
            UTF16BE = 0x10000100,
            UTF16LE = 0x14000100,
            UTF32 = 0x0c000100,
            UTF32BE = 0x18000100,
            UTF32LE = 0x1c000100
        }

        private const string appServices =
            "/System/Library/Frameworks/ApplicationServices.framework/Versions/Current/ApplicationServices";

        public static readonly IntPtr RunLoopModeDefault = CFSTR("kCFRunLoopDefaultMode");

        [DllImport(appServices)]
        internal static extern int CFArrayGetCount(IntPtr theArray);

        [DllImport(appServices)]
        internal static extern IntPtr CFArrayGetValueAtIndex(IntPtr theArray, int idx);

        [DllImport(appServices)]
        internal static extern int CFDictionaryGetCount(IntPtr theDictionary);

        [DllImport(appServices)]
        internal static extern IntPtr CFDictionaryGetValue(IntPtr theDictionary, IntPtr theKey);

        [DllImport(appServices)]
        internal static extern IntPtr CFGetTypeID(IntPtr v);

        [DllImport(appServices)]
        internal static extern IntPtr CFRetain(CFTypeRef cf);

        [DllImport(appServices)]
        internal static extern void CFRelease(CFTypeRef cf);

        // this mirrors the definition in CFString.h.
        // I don't know why, but __CFStringMakeConstantString is marked as "private and should not be used directly"
        // even though the CFSTR macro just calls it.
        [DllImport(appServices)]
        private static extern IntPtr __CFStringMakeConstantString(string cStr);

        internal static IntPtr CFSTR(string cStr)
        {
            return __CFStringMakeConstantString(cStr);
        }

        [DllImport(appServices)]
        internal static extern bool CFStringGetCString(
            CFStringRef theString,
            byte[] buffer,
            CFIndex bufferSize,
            CFStringEncoding encoding
        );

        internal static string CFStringGetCString(IntPtr cfstr)
        {
            var length = CFStringGetLength(cfstr);
            if (length != IntPtr.Zero)
            {
                var utf8_chars = new byte[length.ToInt32() + 1];
                if (CFStringGetCString(cfstr, utf8_chars, new IntPtr(utf8_chars.Length), CFStringEncoding.UTF8))
                {
                    return Encoding.UTF8.GetString(utf8_chars);
                }
            }

            return string.Empty;
        }

        [DllImport(appServices)]
        internal static extern CFIndex CFStringGetLength(
            CFStringRef theString
        );

        [DllImport(appServices)]
        internal static extern bool CFNumberGetValue(IntPtr number, CFNumberType theType, out int valuePtr);

        [DllImport(appServices)]
        internal static extern bool CFNumberGetValue(IntPtr number, CFNumberType theType, out long valuePtr);

        [DllImport(appServices)]
        internal static extern bool CFNumberGetValue(IntPtr number, CFNumberType theType, out double valuePtr);

        [DllImport(appServices)]
        internal static extern CFRunLoop CFRunLoopGetCurrent();

        [DllImport(appServices)]
        internal static extern CFRunLoop CFRunLoopGetMain();

        [DllImport(appServices)]
        internal static extern CFRunLoopExitReason CFRunLoopRunInMode(
            IntPtr cfstrMode, double interval, bool returnAfterSourceHandled);

        [DllImport(appServices, EntryPoint = "CFMachPortCreateRunLoopSource")]
        internal static extern CFRunLoopSourceRef MachPortCreateRunLoopSource(
            CFAllocatorRef allocator,
            CFMachPortRef port,
            CFIndex order);

        [DllImport(appServices, EntryPoint = "CFRunLoopAddSource")]
        internal static extern void RunLoopAddSource(
            CFRunLoopRef rl,
            CFRunLoopSourceRef source,
            CFStringRef mode);

        [DllImport(appServices, EntryPoint = "CFRunLoopRemoveSource")]
        internal static extern void RunLoopRemoveSource(
            CFRunLoopRef rl,
            CFRunLoopSourceRef source,
            CFStringRef mode);

        internal enum CFNumberType
        {
            kCFNumberSInt8Type = 1,
            kCFNumberSInt16Type = 2,
            kCFNumberSInt32Type = 3,
            kCFNumberSInt64Type = 4,
            kCFNumberFloat32Type = 5,
            kCFNumberFloat64Type = 6,
            kCFNumberCharType = 7,
            kCFNumberShortType = 8,
            kCFNumberIntType = 9,
            kCFNumberLongType = 10,
            kCFNumberLongLongType = 11,
            kCFNumberFloatType = 12,
            kCFNumberDoubleType = 13,
            kCFNumberCFIndexType = 14,
            kCFNumberNSIntegerType = 15,
            kCFNumberCGFloatType = 16,
            kCFNumberMaxType = 16
        }
    }
}
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Platform.MacOS.Carbon
{
    struct CFArray
    {
        IntPtr arrayRef;
        public IntPtr Ref { get { return arrayRef; } set { arrayRef = value; } }

        public CFArray(IntPtr reference)
        {
            arrayRef = reference;
        }

        public int Count
        {
            get { return CF.CFArrayGetCount(arrayRef); }
        }
        public IntPtr this[int index]
        {
            get
            {
                if (index >= Count || index < 0)
                    throw new IndexOutOfRangeException();

                return CF.CFArrayGetValueAtIndex(arrayRef, index);
            }
        }
    }
    struct CFDictionary
    {
        public CFDictionary(IntPtr reference)
        {
            dictionaryRef = reference;
        }

        IntPtr dictionaryRef;
        public IntPtr Ref { get { return dictionaryRef; } set { dictionaryRef = value; } }

        public int Count
        {
            get
            {
                return CF.CFDictionaryGetCount(dictionaryRef);
            }
        }
        public double GetNumberValue(string key)
        {
            unsafe
            {
                double retval;
                IntPtr cfnum = CF.CFDictionaryGetValue(dictionaryRef,
                    CF.CFSTR(key));

                CF.CFNumberGetValue(cfnum, CF.CFNumberType.kCFNumberDoubleType, &retval);

                return retval;
            }
        }
    }
    class CF
    {
        const string appServices = "/System/Library/Frameworks/ApplicationServices.framework/Versions/Current/ApplicationServices";

        [DllImport(appServices)]
        internal static extern int CFArrayGetCount(IntPtr theArray);

        [DllImport(appServices)]
        internal static extern IntPtr CFArrayGetValueAtIndex(IntPtr theArray, int idx);

        [DllImport(appServices)]
        internal static extern int CFDictionaryGetCount(IntPtr theDictionary);

        [DllImport(appServices)]
        internal static extern IntPtr CFDictionaryGetValue(IntPtr theDictionary, IntPtr theKey);

        // this mirrors the definition in CFString.h.
        // I don't know why, but __CFStringMakeConstantString is marked as "private and should not be used directly"
        // even though the CFSTR macro just calls it.
        [DllImport(appServices)]
        static extern IntPtr __CFStringMakeConstantString(string cStr);
        internal static IntPtr CFSTR(string cStr)
        {
            return __CFStringMakeConstantString(cStr);
        }

        [DllImport(appServices)]
        internal unsafe static extern bool CFNumberGetValue (IntPtr number, CFNumberType theType, int* valuePtr);
        [DllImport(appServices)]
        internal unsafe static extern bool CFNumberGetValue(IntPtr number, CFNumberType theType, double* valuePtr);

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
        };
    }
}

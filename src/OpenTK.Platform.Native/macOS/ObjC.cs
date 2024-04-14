using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;

namespace OpenTK.Platform.Native.macOS
{
#pragma warning disable IDE1006 // Naming Styles
    internal static unsafe class ObjC
    {
        private const string libdl = "libdl.dylib";
        private const string FoundationFramework = "/System/Library/Frameworks/Foundation.framework/Foundation";
        private const string AppKitFramework = "/System/Library/Frameworks/AppKit.framework/AppKit";

        internal static readonly IntPtr FoundationLibrary = LoadLibrary("/System/Library/Frameworks/Foundation.framework/Foundation"u8);
        internal static readonly IntPtr AppKitLibrary = LoadLibrary("/System/Library/Frameworks/AppKit.framework/AppKit"u8);

        internal static readonly IntPtr /* CFString */ IO16BitDirectPixels = CFStringCreateWithBytes(0, "-RRRRRGGGGGBBBBB"u8, CFStringEncoding.UTF8, false);
        internal static readonly IntPtr /* CFString */ IO32BitDirectPixels = CFStringCreateWithBytes(0, "--------RRRRRRRRGGGGGGGGBBBBBBBB"u8, CFStringEncoding.UTF8, false);
        internal static readonly IntPtr /* CFString */ IO30BitDirectPixels = CFStringCreateWithBytes(0, "--RRRRRRRRRRGGGGGGGGGGBBBBBBBBBB"u8, CFStringEncoding.UTF8, false);
        internal static readonly IntPtr /* CFString */ IO64BitDirectPixels = CFStringCreateWithBytes(0, "-16R16G16B16"u8, CFStringEncoding.UTF8, false);
        internal static readonly IntPtr /* CFString */ IO16BitFloatPixels = CFStringCreateWithBytes(0, "-16FR16FG16FB16F"u8, CFStringEncoding.UTF8, false);
        internal static readonly IntPtr /* CFString */ IO32BitFloatPixels = CFStringCreateWithBytes(0, "-32FR32FG32FB32F"u8, CFStringEncoding.UTF8, false);

        internal static readonly IntPtr /* NSString */ NSApplicationDidChangeScreenParametersNotification = GetStringConstant(AppKitLibrary, "NSApplicationDidChangeScreenParametersNotification"u8);

        internal const byte YES = 1;
        internal const byte NO = 0;

        // FIXME: Number type enum!
        internal const int kCFNumberIntType = 9;

        // FIXME: Maybe move to a selector class?
        // FIXME: Maybe prefix with sel like all other selectors...?
        internal static readonly SEL Init = sel_registerName("init"u8);
        internal static readonly SEL Alloc = sel_registerName("alloc"u8);
        internal static readonly SEL Retain = sel_registerName("retain"u8);
        internal static readonly SEL Release = sel_registerName("release"u8);

        internal static readonly SEL selcStringUsingEncoding = sel_registerName("cStringUsingEncoding:"u8);

        internal static SEL sel_registerName(ReadOnlySpan<byte> str)
        {
            fixed(byte* ptr = str)
            {
                return sel_registerName(ptr);
            }

            [DllImport(FoundationFramework)]
            static extern SEL sel_registerName(byte* data);
        }

        // FIXME: Maybe just expose raw dlopen?
        internal static IntPtr LoadLibrary(ReadOnlySpan<byte> path, bool first = false)
        {
            const int RTLD_NOW = 2;
            const int RTLD_FIRST = 0x100;

            int mode = RTLD_NOW;
            if (first)
            {
                mode |= RTLD_FIRST;
            }

            fixed(byte* ptr = path)
            {
                return dlopen(ptr, mode);
            }

            [DllImport(libdl)]
            static extern IntPtr dlopen(byte* path, int mode);
        }

        // FIXME: Maybe rename this to GetSymbol?
        internal static IntPtr GetStringConstant(IntPtr handle, ReadOnlySpan<byte> symbol)
        {
            fixed(byte* ptr = symbol)
            {
                // Load the pointer to the constant, then dereference it.
                return *(IntPtr*)dlsym(handle, ptr);
            }

            [DllImport(libdl)]
            static extern IntPtr dlsym(IntPtr handle, byte* symbol);
        }

        internal static IntPtr GetSymbol(IntPtr handle, ReadOnlySpan<byte> symbol)
        {
            fixed (byte* ptr = symbol)
            {
                // Load the pointer to the constant, then dereference it.
                IntPtr* symPtr = (IntPtr*)dlsym(handle, ptr);
                return *symPtr;
            }

            [DllImport(libdl)]
            static extern IntPtr dlsym(IntPtr handle, byte* symbol);
        }

        internal static IntPtr GetSymbol(IntPtr handle, string symbol)
        {
            IntPtr strPtr = Marshal.StringToCoTaskMemUTF8(symbol);
            IntPtr value = dlsym(handle, strPtr);
            Marshal.FreeCoTaskMem(strPtr);
            return value;

            [DllImport(libdl)]
            static extern IntPtr dlsym(IntPtr handle, IntPtr symbol);
        }

        [DllImport(AppKitFramework, CharSet = CharSet.Ansi)]
        internal static extern ObjCClass objc_getClass(string name);

        internal static ObjCClass objc_getClass(ReadOnlySpan<byte> name)
        {
            fixed(byte* ptr = name)
            {
                return objc_getClass(ptr);
            }

            [DllImport(AppKitFramework)]
            static extern ObjCClass objc_getClass(byte* name);
        }

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver, SEL selector);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver, SEL selector, IntPtr ptr, long value);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver, SEL selector, CGPoint point);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver, SEL selector, CGRect value1);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver, SEL selector, CGRect value1, IntPtr value2);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver, SEL selector, CGRect value1, CGRect value2, nuint value3, NFloat value4);

        // FIXME: BOOL vs bool...
        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver, SEL selector, CGRect value1, bool value2);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver, SEL selector, NSSize size);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver, SEL selector, IntPtr value1, SEL value2, IntPtr value3, IntPtr value4);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern IntPtr objc_msgSend_IntPtr(IntPtr receiver, SEL selector);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern IntPtr objc_msgSend_IntPtr(IntPtr receiver, SEL selector, IntPtr value);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern IntPtr objc_msgSend_IntPtr(IntPtr receiver, SEL selector, IntPtr value0, CGPoint value1);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern IntPtr objc_msgSend_IntPtr(IntPtr receiver, SEL selector, NSSize value1);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern IntPtr objc_msgSend_IntPtr(IntPtr receiver, SEL selector, SEL value);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern IntPtr objc_msgSend_IntPtr(IntPtr receiver, SEL selector, IntPtr value1, IntPtr value2);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern IntPtr objc_msgSend_IntPtr(IntPtr receiver, SEL selector, CGRect value1, IntPtr value2, IntPtr value3, [MarshalAs(UnmanagedType.I1)] bool value4);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern IntPtr objc_msgSend_IntPtr(IntPtr receiver, SEL selector, IntPtr planes, nint width, nint height, nint bps, nint spp, [MarshalAs(UnmanagedType.I1)] bool alpha, [MarshalAs(UnmanagedType.I1)] bool isPlanar, IntPtr colorSpaceName, nuint bitmapFormat, nint rBytes, nint pBits);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern IntPtr objc_msgSend_IntPtr(IntPtr receiver, SEL selector, ulong value);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern IntPtr objc_msgSend_IntPtr(IntPtr receiver, SEL selector, CGRect rect);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver, SEL selector, bool value);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver, SEL selector, IntPtr value);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver, SEL selector, ulong value);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver, SEL selector, ulong value1, IntPtr value2);
          
        // FIXME: Is bool correct here?
        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern IntPtr objc_msgSend_IntPtr(IntPtr receiver, SEL selector, CGRect rect, NSWindowStyleMask styleMask, NSBackingStoreType type, bool defer);

        // FIXME: Is bool correct here?
        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern IntPtr /* NSEvent */ objc_msgSend_IntPtr(IntPtr receiver, SEL selector, NSEventMask mask, IntPtr /* NSDate */ expiration, IntPtr /* NSRunLoopMode */ mode, bool deqFlag);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern IntPtr objc_msgSend_IntPtr(IntPtr receiver, SEL selector, IntPtr /* NSString */ str, SEL sel, IntPtr /* NSString */ charCode);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern ulong objc_msgSend_ulong(IntPtr receiver, SEL selector);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern ulong objc_msgSend_ulong(IntPtr receiver, SEL selector, ulong value);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern uint objc_msgSend_uint(IntPtr receiver, SEL selector);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern int objc_msgSend_int(IntPtr receiver, SEL selector);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern ushort objc_msgSend_ushort(IntPtr receiver, SEL selector);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern bool objc_msgSend_bool(IntPtr receiver, SEL selector);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern bool objc_msgSend_bool(IntPtr receiver, SEL selector, long value);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern bool objc_msgSend_bool(IntPtr receiver, SEL selector, SEL value);

        internal static CGRect objc_msgSend_CGRect(IntPtr receiver, SEL selector)
        {
            objc_msgSend_CGRect(out CGRect rect, receiver, selector);
            return rect;

            [DllImport(FoundationFramework, EntryPoint = "objc_msgSend_stret")]
            static extern void objc_msgSend_CGRect(out CGRect rect, IntPtr receiver, SEL selector);
        }

        internal static CGRect objc_msgSend_CGRect(IntPtr receiver, SEL selector, CGRect rect1)
        {
            objc_msgSend_CGRect(out CGRect rect, receiver, selector, rect1);
            return rect;

            [DllImport(FoundationFramework, EntryPoint = "objc_msgSend_stret")]
            static extern void objc_msgSend_CGRect(out CGRect rect, IntPtr receiver, SEL selector, CGRect rect1);
        }

        internal static CGRect objc_msgSend_CGRect(IntPtr receiver, SEL selector, CGRect rect1, IntPtr value1)
        {
            objc_msgSend_CGRect(out CGRect rect, receiver, selector, rect1, value1);
            return rect;

            [DllImport(FoundationFramework, EntryPoint = "objc_msgSend_stret")]
            static extern void objc_msgSend_CGRect(out CGRect rect, IntPtr receiver, SEL selector, CGRect rect1, IntPtr value1);
        }

        // FIXME: What happens on ARM?
        // NSPoint doesn't use the _stret version of msgSend (on x86_64?) for some reason..?
        // This document touches lightly on when to use _stret:
        // https://learn.microsoft.com/en-us/xamarin/ios/internals/objective-c-selectors
        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern CGPoint objc_msgSend_CGPoint(IntPtr receiver, SEL selector);

        // NSPoint doesn't use the _stret version of msgSend (on x86_64?) for some reason..?
        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern CGPoint objc_msgSend_CGPoint(IntPtr receiver, SEL selector, CGPoint point1, IntPtr ptr);


        // NSPoint doesn't use the _stret version of msgSend (on x86_64?) for some reason..?
        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern NSSize objc_msgSend_NSSize(IntPtr receiver, SEL selector);

        // FIXME: Should we even consider 32bit macos?
        internal static float objc_msgSend_float(IntPtr receiver, SEL selector)
        {
            if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
            {
                return objc_msgSend_fret(receiver, selector);
            }
            else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
            {
                // For x64 any struct smaller than 16 bytes is put into registers.
                // https://stackoverflow.com/a/39290251
                return (float)objc_msgSend_float(receiver, selector);
            }
            else
            {
                // FIXME: What do we do with ARM? Do we only need to consider 64bit?
                // This is likely a good place to start: https://stackoverflow.com/a/39290251
                return (float)objc_msgSend_float(receiver, selector);
            }

            [DllImport(FoundationFramework, EntryPoint = "objc_msgSend_fret")]
            static extern float objc_msgSend_fret(IntPtr receiver, SEL selector);

            [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
            static extern double objc_msgSend_float(IntPtr receiver, SEL selector);
        }

        // FIXME: Should we even consider 32-bit macos?
        internal static NFloat objc_msgSend_nfloat(IntPtr receiver, SEL selector)
        {
            if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
            {
                return objc_msgSend_fret(receiver, selector);
            }
            else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
            {
                // For x64 any struct smaller than 16 bytes is put into registers.
                // https://stackoverflow.com/a/39290251
                return (NFloat)objc_msgSend_float(receiver, selector);
            }
            else
            {
                // FIXME: What do we do with ARM? Do we only need to consider 64bit?
                // This is likely a good place to start: https://stackoverflow.com/a/39290251
                return (NFloat)objc_msgSend_float(receiver, selector);
            }

            [DllImport(FoundationFramework, EntryPoint = "objc_msgSend_fret")]
            static extern NFloat objc_msgSend_fret(IntPtr receiver, SEL selector);

            [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
            static extern double objc_msgSend_float(IntPtr receiver, SEL selector);
        }

        // FIXME: Should we even consider 32-bit macos?
        internal static double objc_msgSend_double(IntPtr receiver, SEL selector)
        {
            if (RuntimeInformation.ProcessArchitecture == Architecture.X86)
            {
                return objc_msgSend_fret(receiver, selector);
            }
            else if (RuntimeInformation.ProcessArchitecture == Architecture.X64)
            {
                // For x64 any struct smaller than 16 bytes is put into registers.
                // https://stackoverflow.com/a/39290251
                return (NFloat)objc_msgSend_float(receiver, selector);
            }
            else
            {
                // FIXME: What do we do with ARM? Do we only need to consider 64bit?
                // This is likely a good place to start: https://stackoverflow.com/a/39290251
                return (NFloat)objc_msgSend_float(receiver, selector);
            }

            [DllImport(FoundationFramework, EntryPoint = "objc_msgSend_fret")]
            static extern double objc_msgSend_fret(IntPtr receiver, SEL selector);

            [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
            static extern double objc_msgSend_float(IntPtr receiver, SEL selector);
        }

        internal static NSEdgeInsets objc_msgSend_NSEdgeInsets(IntPtr receiver, SEL selector)
        {
            objc_msgSend_NSEdgeInsets(out NSEdgeInsets insets, receiver, selector);
            return insets;

            [DllImport(FoundationFramework, EntryPoint = "objc_msgSend_stret")]
            static extern void objc_msgSend_NSEdgeInsets(out NSEdgeInsets @struct, IntPtr receiver, SEL selector);
        }


        [DllImport(FoundationFramework, EntryPoint = "objc_msgSendSuper")]
        internal static extern void objc_msgSendSuper(in objc_super super, SEL op);


        internal static ObjCClass objc_allocateClassPair(ObjCClass superclass, ReadOnlySpan<byte> name, ulong extraBytes)
        {
            fixed(byte* ptr = name)
            {
                return objc_allocateClassPair(superclass, ptr, 0);
            }

            [DllImport(FoundationFramework)]
            static extern ObjCClass objc_allocateClassPair(ObjCClass superclass, byte* name, ulong extraBytes);
        }

        internal static IntPtr /* Protocol */ objc_getProtocol(ReadOnlySpan<byte> name)
        {
            fixed (byte* ptr = name)
            {
                return objc_getProtocol(ptr);
            }

            [DllImport(FoundationFramework)]
            static extern IntPtr /* Protocol */ objc_getProtocol(byte* name);
        }

        internal static bool class_addIvar(ObjCClass cls, ReadOnlySpan<byte> name, nuint size, nuint alignment, ReadOnlySpan<byte> types)
        {
            fixed(byte* namePtr = name)
            fixed(byte* typesPtr = types)
            {
                return class_addIvar(cls, namePtr, size, alignment, typesPtr);
            }

            // FIXME: BOOL?
            [DllImport(FoundationFramework)]
            static extern bool class_addIvar(ObjCClass cls, byte* name, nuint size, nuint alignment, byte* types);
        }

        // FIXME: BOOL?
        [DllImport(FoundationFramework)]
        internal static extern bool class_addProtocol(ObjCClass cls, IntPtr /* Protocol */ protocol);

        internal static bool class_addMethod(ObjCClass cls, SEL name, IntPtr imp, ReadOnlySpan<byte> types)
        {
            fixed (byte* ptr = types)
            {
                return class_addMethod(cls, name, imp, ptr);
            }

            // FIXME: What framework?
            [DllImport(FoundationFramework)]
            static extern bool class_addMethod(ObjCClass cls, SEL name, IntPtr imp, byte* types);
        }

        [DllImport(FoundationFramework)]
        internal static extern IntPtr /* objc_property_t* */ class_copyPropertyList(ObjCClass cls, out uint outCount);

        internal static string property_getName(IntPtr property) {

            byte** name = property_getName(property);
            return Marshal.PtrToStringUTF8((IntPtr)(*name))!;

            // FIXME: For some reason we are getting a char** when the documentation says
            // we should be getting a char*???
            // - Noggin_bops 2024-04-13
            [DllImport(FoundationFramework, CallingConvention = CallingConvention.Cdecl)]
            static extern byte** /* char* */ property_getName(IntPtr /* objc_property_t */ property);
        }

        internal static IntPtr /* Ivar */ object_getInstanceVariable(IntPtr /* id */ @object, ReadOnlySpan<byte> name, out IntPtr outValue)
        {
            fixed(byte* namePtr = name)
            {
                return object_getInstanceVariable(@object, namePtr, out outValue);
            }

            // FIXME: BOOL
            [DllImport(FoundationFramework)]
            static extern IntPtr /* Ivar */ object_getInstanceVariable(IntPtr /* id */ @object, byte* name, out IntPtr outValue);
        }

        internal static IntPtr /* Ivar */ object_setInstanceVariable(IntPtr /* id */ @object, ReadOnlySpan<byte> name, IntPtr value)
        {
            fixed (byte* namePtr = name)
            {
                return object_setInstanceVariable(@object, namePtr, value);
            }

            // FIXME: BOOL
            [DllImport(FoundationFramework)]
            static extern IntPtr /* Ivar */ object_setInstanceVariable(IntPtr /* id */ @object, byte* name, IntPtr value);
        }

        [DllImport(FoundationFramework)]
        internal static extern void objc_registerClassPair(ObjCClass cls);

        internal static string FromNSString(IntPtr nsString)
        {
            char* strPtr = (char*)objc_msgSend_IntPtr(nsString, selcStringUsingEncoding, (ulong)NSStringEncoding.UTF16);
            string str = new string(strPtr);
            return str;
        }

        internal static IntPtr ToNSString(string str)
        {
            return CFStringCreateWithBytes(IntPtr.Zero, str.AsSpan(), CFStringEncoding.UTF16, false);
        }

        internal static IntPtr ToNSString(ReadOnlySpan<byte> str)
        {
            return CFStringCreateWithBytes(IntPtr.Zero, str, CFStringEncoding.UTF8, false);
        }

        internal static IntPtr /* CFStringRef */ CFStringCreateWithBytes(IntPtr allocator, ReadOnlySpan<char> buffer, CFStringEncoding encoding, bool isExternalRepresentation)
        {
            fixed (char* ptr = buffer)
            {
                return CFStringCreateWithBytes(allocator, ptr, buffer.Length * 2, encoding, isExternalRepresentation ? (byte)1 : (byte)0);
            }

            [DllImport(FoundationFramework)]
            static extern IntPtr /* CFStringRef */ CFStringCreateWithBytes(IntPtr allocator, char* buffer, long numBytes, CFStringEncoding encoding, byte /* Boolean */ isExternalRepresentation);
        }

        internal static IntPtr /* CFStringRef */ CFStringCreateWithBytes(IntPtr allocator, ReadOnlySpan<byte> buffer, CFStringEncoding encoding, bool isExternalRepresentation)
        {
            fixed (byte* ptr = buffer)
            {
                return CFStringCreateWithBytes(allocator, ptr, buffer.Length, encoding, isExternalRepresentation ? (byte)1 : (byte)0);
            }

            [DllImport(FoundationFramework)]
            static extern IntPtr /* CFStringRef */ CFStringCreateWithBytes(IntPtr allocator, byte* buffer, long numBytes, CFStringEncoding encoding, byte /* Boolean */ isExternalRepresentation);
        }

        [DllImport(AppKitFramework)]
        internal static extern SEL NSSelectorFromString(IntPtr /* NSString */ aSelectorName);

        [DllImport(AppKitFramework)]
        internal static extern nint NSBitsPerPixelFromDepth(int /* NSWindowDepth */ depth);

        [DllImport(FoundationFramework)]
        internal static extern nint CFArrayGetCount(IntPtr /* CFArrayRef */ theArray);

        [DllImport(FoundationFramework)]
        internal static extern IntPtr CFArrayGetValueAtIndex(IntPtr /* CFArrayRef */ theArray, nint idx);

        [DllImport(FoundationFramework)]
        internal static extern nint /* CFComparisonResult */ CFStringCompare(IntPtr /* CFString */ theString1, IntPtr /* CFString */ theString2, nuint compareOptions);

        // FIXME: Boolean
        [DllImport(FoundationFramework)]
        internal static extern bool CFEqual(IntPtr /* CFTypeRef */ cf1, IntPtr /* CFTypeRef */ cf2);

        [DllImport(FoundationFramework)]
        internal static extern void CFRelease(IntPtr /* CFTypeRef */ cf);

        [DllImport(FoundationFramework)]
        internal static extern nint /* CFIndex */ CFDictionaryGetCount(IntPtr /* CFDictionaryRef */ theDict);

        [DllImport(FoundationFramework)]
        internal static extern IntPtr /* void* */ CFDictionaryGetValue(IntPtr /* CFDictionaryRef */ theDict, IntPtr /* void* */ key);

        [DllImport(FoundationFramework)]
        internal static extern void CFDictionaryGetKeysAndValues(IntPtr /* CFDictionaryRef */ theDict, IntPtr* keys, IntPtr* values);

        // FIXME: Boolean
        // FIXME: CFnumberType
        [DllImport(FoundationFramework)]
        internal static extern bool CFNumberGetValue(IntPtr /* CFnumberRef */ number, nint /* CFNumberType */ theType, void* valuePtr);

        [DllImport(FoundationFramework)]
        internal static extern IntPtr /* CFStringRef */ CFCopyDescription(IntPtr /* CFTypeRef */ cf);

        [DllImport(FoundationFramework)]
        internal static extern bool CFBooleanGetValue(IntPtr /* CFBooleanRef */ boolean);
    }
#pragma warning restore IDE1006 // Naming Styles
}


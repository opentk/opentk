using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace OpenTK.Platform.Native.macOS
{
    public static unsafe class ObjC
    {
        private const string libdl = "libdl.dylib";
        private const string FoundationFramework = "/System/Library/Frameworks/Foundation.framework/Foundation";
        private const string AppKitFramework = "/System/Library/Frameworks/AppKit.framework/AppKit";

        internal static readonly IntPtr FoundationLibrary = LoadLibrary("/System/Library/Frameworks/Foundation.framework/Foundation"u8);
        internal static readonly IntPtr AppKitLibrary = LoadLibrary("/System/Library/Frameworks/AppKit.framework/AppKit"u8);

        // FIXME: Maybe move to a selector class?
        internal static readonly SEL Init = sel_registerName("init"u8);
        internal static readonly SEL Alloc = sel_registerName("alloc"u8);
        internal static readonly SEL Retain = sel_registerName("retain"u8);

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
        internal static extern IntPtr objc_msgSend_IntPtr(IntPtr receiver, SEL selector);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern IntPtr objc_msgSend_IntPtr(IntPtr receiver, SEL selector, IntPtr value);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern IntPtr objc_msgSend_IntPtr(IntPtr receiver, SEL selector, CGRect rect);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver, SEL selector, bool value);

        [DllImport(FoundationFramework, EntryPoint = "objc_msgSend")]
        internal static extern void objc_msgSend(IntPtr receiver, SEL selector, IntPtr value);

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
        internal static extern bool objc_msgSend_bool(IntPtr receiver, SEL selector, long value);

        internal static CGRect objc_msgSend_CGRect(IntPtr receiver, SEL selector)
        {
            objc_msgSend_CGRect(out CGRect rect, receiver, selector);
            return rect;

            [DllImport(FoundationFramework, EntryPoint = "objc_msgSend_stret")]
            static extern bool objc_msgSend_CGRect(out CGRect rect, IntPtr receiver, SEL selector);
        }

        

        internal static ObjCClass objc_allocateClassPair(ObjCClass superclass, ReadOnlySpan<byte> name, ulong extraBytes)
        {
            fixed(byte* ptr = name)
            {
                return objc_allocateClassPair(superclass, ptr, 0);
            }

            [DllImport(FoundationFramework)]
            static extern ObjCClass objc_allocateClassPair(ObjCClass superclass, byte* name, ulong extraBytes);
        }

        internal static bool class_addMethod(ObjCClass cls, SEL name, Delegate imp, ReadOnlySpan<byte> types)
        {
            // FIXME: Maybe avoid marshalling the delegate?
            IntPtr impPtr = Marshal.GetFunctionPointerForDelegate(imp);
            fixed(byte* ptr = types)
            {
                return class_addMethod(cls, name, impPtr, ptr);
            }

            // FIXME: What framework?
            [DllImport(FoundationFramework)]
            static extern bool class_addMethod(ObjCClass cls, SEL name, IntPtr imp, byte* types);
        }

        [DllImport(FoundationFramework)]
        internal static extern void objc_registerClassPair(ObjCClass cls);
        
        internal static IntPtr ToNSString(ReadOnlySpan<byte> str)
        {
            return CFStringCreateWithBytes(IntPtr.Zero, str, CFStringEncoding.UTF8, false);
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
    }
}


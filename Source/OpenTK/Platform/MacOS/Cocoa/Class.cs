using System.Runtime.InteropServices;
using System;

namespace OpenTK.Platform.MacOS
{
    static class Class
    {
        [DllImport (Cocoa.LibObjC)]
        extern static IntPtr class_getName(IntPtr handle);

        [DllImport (Cocoa.LibObjC)]
        extern static bool class_addMethod(IntPtr classHandle, IntPtr selector, IntPtr method, string types);

        [DllImport (Cocoa.LibObjC)]
        extern static IntPtr objc_getClass(string name);

        [DllImport (Cocoa.LibObjC)]
        extern static IntPtr objc_allocateClassPair(IntPtr parentClass, string name, int extraBytes);

        [DllImport (Cocoa.LibObjC)]
        extern static void objc_registerClassPair(IntPtr classToRegister);

        public static IntPtr Get(string name)
        {
            var id = objc_getClass(name);
            if (id == IntPtr.Zero)
            {
                throw new ArgumentException("Unknown class: " + name);
            }
            return id;
        }

        public static IntPtr AllocateClass(string className, string parentClass)
        {
            return objc_allocateClassPair(Get(parentClass), className, 0);
        }

        public static void RegisterClass(IntPtr handle)
        {
            objc_registerClassPair(handle);
        }

        public static void RegisterMethod(IntPtr handle, Delegate d, string selector, string typeString)
        {
            // TypeString info:
            // https://developer.apple.com/library/mac/documentation/Cocoa/Conceptual/ObjCRuntimeGuide/Articles/ocrtTypeEncodings.html

            IntPtr p = Marshal.GetFunctionPointerForDelegate(d);
            bool r = class_addMethod(handle, Selector.Get(selector), p, typeString);

            if (!r)
            {
                throw new ArgumentException("Could not register method " + d + " in class + " + class_getName(handle));
            }
        }
    }
}

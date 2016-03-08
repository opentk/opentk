// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;

namespace OpenTK.Platform.MacOS
{
    static class Class
    {
        public static readonly IntPtr NSAutoreleasePool = Get("NSAutoreleasePool");
        public static readonly IntPtr NSDictionary = Get("NSDictionary");
        public static readonly IntPtr NSNumber = Get("NSNumber");
        public static readonly IntPtr NSUserDefaults = Get("NSUserDefaults");

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

        [DllImport (Cocoa.LibObjC)]
        extern static void objc_disposeClassPair(IntPtr cls);

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

        public static void DisposeClass(IntPtr handle)
        {
            objc_disposeClassPair(handle);
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

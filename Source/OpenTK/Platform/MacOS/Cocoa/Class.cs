#region License
//
// Class.cs
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

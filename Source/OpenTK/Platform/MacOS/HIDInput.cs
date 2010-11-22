#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Input;

namespace OpenTK.Platform.MacOS
{
    using Carbon;
    using CFAllocatorRef = System.IntPtr;
    using CFDictionaryRef = System.IntPtr;
    using CFRunLoop = System.IntPtr;
    using CFString = System.IntPtr;
    using IOHIDDeviceRef = System.IntPtr;
    using IOHIDManagerRef = System.IntPtr;
    using IOOptionBits = System.IntPtr;
    using IOReturn = System.IntPtr;

    class HIDInput : IMouseDriver2
    {
        #region Fields

        readonly IOHIDManagerRef hidmanager;
        readonly static NativeMethods.IOHIDDeviceCallback HandleDeviceAdded = delegate
        {
            Debug.WriteLine("Device added");
        };
        readonly static NativeMethods.IOHIDDeviceCallback HandleDeviceRemoved = delegate
        {
            Debug.WriteLine("Device Removed");
        };
        readonly static CFString RunLoopMode = CF.CFSTR("OPENTK_INPUT");
        readonly static CFDictionary DeviceTypes = new CFDictionary();

        #endregion

        #region Constructors

        public HIDInput()
        {
            Debug.Print("Using {0}.", typeof(HIDInput).Name);

            hidmanager = CreateHIDManager();
            RegisterHIDCallbacks(hidmanager);
        }

        #endregion

         #region Private Members

        static IOHIDManagerRef CreateHIDManager()
        {
            return NativeMethods.IOHIDManagerCreate(IntPtr.Zero, IntPtr.Zero);
        }

        static void RegisterHIDCallbacks(IOHIDManagerRef hidmanager)
        {
            CFRunLoop runloop = Carbon.CF.CFRunLoopGetCurrent();

            NativeMethods.IOHIDManagerRegisterDeviceMatchingCallback(
                hidmanager, HandleDeviceAdded, IntPtr.Zero);
            NativeMethods.IOHIDManagerRegisterDeviceRemovalCallback(
                hidmanager, HandleDeviceRemoved, IntPtr.Zero);
            NativeMethods.IOHIDManagerScheduleWithRunLoop(hidmanager,
                runloop, RunLoopMode);

            NativeMethods.IOHIDManagerSetDeviceMatching(hidmanager, DeviceTypes.Ref);
            NativeMethods.IOHIDManagerOpen(hidmanager, IOOptionBits.Zero);
        }

        #endregion

        #region IMouseDriver2 Members

        public MouseState GetState()
        {
            return new MouseState();
        }

        public MouseState GetState(int index)
        {
            return new MouseState();
        }

        #endregion

        #region NativeMethods

        class NativeMethods
        {
            const string hid = "/System/Library/Frameworks/IOKit.framework/Versions/Current/IOKit";

            [DllImport(hid)]
            public static extern IOHIDManagerRef IOHIDManagerCreate(
                CFAllocatorRef allocator, IOOptionBits options) ;

            // This routine will be called when a new (matching) device is connected.
            [DllImport(hid)]
            public static extern void IOHIDManagerRegisterDeviceMatchingCallback(
                IOHIDManagerRef inIOHIDManagerRef,
                IOHIDDeviceCallback inIOHIDDeviceCallback,
                IntPtr inContext);

            // This routine will be called when a (matching) device is disconnected.
            [DllImport(hid)]
            public static extern void IOHIDManagerRegisterDeviceRemovalCallback(
                IOHIDManagerRef inIOHIDManagerRef,
                IOHIDDeviceCallback inIOHIDDeviceCallback,
                IntPtr inContext);

            [DllImport(hid)]
            public static extern void IOHIDManagerScheduleWithRunLoop(
                IOHIDManagerRef inIOHIDManagerRef,
                CFRunLoop inCFRunLoop,
                CFString inCFRunLoopMode);

            [DllImport(hid)]
            public static extern void IOHIDManagerSetDeviceMatching(
                IOHIDManagerRef manager,
                CFDictionaryRef matching) ;

            [DllImport(hid)]
            public static extern IOReturn IOHIDManagerOpen(
                IOHIDManagerRef manager,
                IOOptionBits options) ;


            public delegate void IOHIDDeviceCallback(IntPtr ctx, IOReturn res, IntPtr sender, IOHIDDeviceRef device);
        }

        #endregion
    }
}


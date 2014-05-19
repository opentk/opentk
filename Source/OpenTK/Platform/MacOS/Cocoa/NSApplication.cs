#region License
//
// NSApplication.cs
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

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using OpenTK.Platform.MacOS;

namespace OpenTK.Platform.MacOS
{
    static class NSApplication
    {
        internal static IntPtr Handle;
        internal static IntPtr AutoreleasePool;

        static readonly IntPtr selQuit = Selector.Get("quit");

        internal static void Initialize()
        {
            // Create the NSAutoreleasePool
            AutoreleasePool = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.NSAutoreleasePool, Selector.Alloc), Selector.Init);

            // Register a Quit method to be called on cmd-q
            IntPtr nsapp = Class.Get("NSApplication");
            Class.RegisterMethod(nsapp, new OnQuitDelegate(OnQuit), "quit", "v@:");

            // Fetch the application handle
            Handle = Cocoa.SendIntPtr(nsapp, Selector.Get("sharedApplication"));

            // Setup the application
            Cocoa.SendBool(Handle, Selector.Get("setActivationPolicy:"), (int)NSApplicationActivationPolicy.Regular);
            Cocoa.SendVoid(Handle, Selector.Get("activateIgnoringOtherApps:"), true);

            // Create the menu bar
            var menubar = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSMenu"), Selector.Alloc),
                Selector.Autorelease);

            var menuItem = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSMenuItem"), Selector.Alloc),
                Selector.Autorelease);

            // Add menu item to bar, and bar to application
            Cocoa.SendIntPtr(menubar, Selector.Get("addItem:"), menuItem);
            Cocoa.SendIntPtr(Handle, Selector.Get("setMainMenu:"), menubar);

            // Add a "Quit" menu item and bind the button.
            var appMenu = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSMenu"), Selector.Alloc),
                Selector.Autorelease);
            var quitMenuItem = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSMenuItem"), Selector.Alloc),
                Selector.Get("initWithTitle:action:keyEquivalent:"), Cocoa.ToNSString("Quit"), selQuit, Cocoa.ToNSString("q")),
                Selector.Autorelease);

            Cocoa.SendIntPtr(appMenu, Selector.Get("addItem:"), quitMenuItem);
            Cocoa.SendIntPtr(menuItem, Selector.Get("setSubmenu:"), appMenu);

            // Tell cocoa we're ready to run the application (usually called by [NSApp run]). 
            Cocoa.SendVoid(Handle, Selector.Get("finishLaunching"));

            // Disable momentum scrolling and long-press key pop-ups
            IntPtr settings = Cocoa.SendIntPtr(Class.NSDictionary, Selector.Alloc);
            IntPtr momentum_scrolling = Cocoa.SendIntPtr(Class.NSNumber, Selector.Get("numberWithBool:"), false);
            IntPtr press_and_hold = Cocoa.SendIntPtr(Class.NSNumber, Selector.Get("numberWithBool:"), false);

            // Initialize and register the settings dictionary
            settings = 
                Cocoa.SendIntPtr(settings, Selector.Get("initWithObjectsAndKeys:"),
                    //momentum_scrolling, Cocoa.ToNSString("AppleMomentumScrollSupported"),
                    press_and_hold, Cocoa.ToNSString("ApplePressAndHoldEnabled"),
                    IntPtr.Zero);
            Cocoa.SendVoid(
                Cocoa.SendIntPtr(Class.NSUserDefaults, Selector.Get("standardUserDefaults")),
                Selector.Get("registerDefaults:"),
                settings);
            Cocoa.SendVoid(settings, Selector.Release);
        }

        internal static event EventHandler<CancelEventArgs> Quit = delegate { };

        delegate void OnQuitDelegate(IntPtr self, IntPtr cmd);
        static void OnQuit(IntPtr self, IntPtr cmd)
        {
            var e = new CancelEventArgs();
            Quit(null, e);
            if (!e.Cancel)
            {
                Cocoa.SendVoid(Handle, Selector.Get("terminate:"), Handle);
            }
        }
    }
}

using System;
using System.Runtime.InteropServices;
using OpenTK.Platform.MacOS;

namespace OpenTK.Platform.MacOS
{
    static class NSApplication
    {
        internal static IntPtr Handle;
        internal static IntPtr AutoreleasePool;

        internal static void Initialize()
        {
            // Create the NSAutoreleasePool
            AutoreleasePool = Cocoa.SendIntPtr(Cocoa.SendIntPtr(Class.Get("NSAutoreleasePool"), Selector.Alloc), Selector.Init);

            // Fetch the application handle
            Handle = Cocoa.SendIntPtr(Class.Get("NSApplication"), Selector.Get("sharedApplication"));

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

            // Tell cocoa we're ready to run the application (usually called by [NSApp run]). 
            Cocoa.SendVoid(Handle, Selector.Get("finishLaunching"));
        }
    }
}

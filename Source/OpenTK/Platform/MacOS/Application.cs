//
//  
//  xCSCarbon
//
//  Created by Erik Ylvisaker on 3/17/08.
//  Copyright 2008 __MyCompanyName__. All rights reserved.
//
//

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace OpenTK.Platform.MacOS.Carbon
{
	static class Application
	{
        static bool mInitialized = false;
        static IntPtr uppHandler;
        static CarbonGLNative eventHandler;
        static int osMajor, osMinor, osBugfix;

        static Application()
        {
            Initialize();
        }

        internal static void Initialize()
        {
            if (mInitialized) return;
			
            API.AcquireRootMenu();

            ConnectEvents();

            API.Gestalt(GestaltSelector.SystemVersionMajor, out osMajor);
            API.Gestalt(GestaltSelector.SystemVersionMinor, out osMinor);
            API.Gestalt(GestaltSelector.SystemVersionBugFix, out osBugfix);

            Debug.Print("Running on Mac OS X {0}.{1}.{2}.", osMajor, osMinor, osBugfix);
        }

        internal static CarbonGLNative WindowEventHandler
        {
            get { return eventHandler; }
            set { eventHandler = value; }
        }

        static void ConnectEvents()
        {
            EventTypeSpec[] eventTypes = new EventTypeSpec[]
            {
                new EventTypeSpec(EventClass.Application, AppEventKind.AppActivated),
                new EventTypeSpec(EventClass.Application, AppEventKind.AppDeactivated),
                new EventTypeSpec(EventClass.Application, AppEventKind.AppQuit),

                new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseDown),
                new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseUp),
                new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseMoved),
                new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseDragged),
                new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseEntered),
                new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseExited),
                new EventTypeSpec(EventClass.Mouse, MouseEventKind.WheelMoved),
                
                new EventTypeSpec(EventClass.Keyboard, KeyboardEventKind.RawKeyDown),
                new EventTypeSpec(EventClass.Keyboard, KeyboardEventKind.RawKeyRepeat),
                new EventTypeSpec(EventClass.Keyboard, KeyboardEventKind.RawKeyUp),
                new EventTypeSpec(EventClass.Keyboard, KeyboardEventKind.RawKeyModifiersChanged),

                new EventTypeSpec(EventClass.AppleEvent, AppleEventKind.AppleEvent),
            };

            MacOSEventHandler handler = EventHandler;
            uppHandler = API.NewEventHandlerUPP(handler);

            API.InstallApplicationEventHandler(
                uppHandler, eventTypes, IntPtr.Zero, IntPtr.Zero);
            
            mInitialized = true;
        }

        static OSStatus EventHandler(IntPtr inCaller, IntPtr inEvent, IntPtr userData)
        {
            EventInfo evt = new EventInfo(inEvent);
            
            switch (evt.EventClass)
            {
                case EventClass.Application:
                    switch (evt.AppEventKind)
                    {
                        default:
                            return OSStatus.EventNotHandled;
                    }

                case EventClass.AppleEvent:
                    // only event here is the apple event.
                    Debug.Print("Processing apple event.");
                    API.ProcessAppleEvent(inEvent);
                    break;

                case EventClass.Keyboard:
                case EventClass.Mouse:
                    if (WindowEventHandler != null)
                    {
                        return WindowEventHandler.DispatchEvent(inCaller, inEvent, evt, userData);
                    }
                    break;
            }

            return OSStatus.EventNotHandled;
        }

        public static void Run(CarbonGLNative window)
        {
            window.Destroy += MainWindowClosed;
            window.Visible = true;

            API.RunApplicationEventLoop();

            window.Destroy -= MainWindowClosed;
        }

        static void MainWindowClosed(object sender, EventArgs e)
        {
        	Debug.Print("Quitting application event loop.");
            API.QuitApplicationEventLoop();
        }


        internal static void ProcessEvents()
        {
            API.ProcessEvents();
        }
    }
}

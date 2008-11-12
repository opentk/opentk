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

        static Application()
        {
            Initialize();
        }

        internal static void Initialize()
        {
            if (mInitialized) return;

            API.AcquireRootMenu();

            ConnectEvents();    
        }

        static void ConnectEvents()
        {
            EventTypeSpec[] eventTypes = new EventTypeSpec[]
            {
                new EventTypeSpec(EventClass.Application, AppEventKind.AppActivated),
                new EventTypeSpec(EventClass.Application, AppEventKind.AppDeactivated),
                new EventTypeSpec(EventClass.Application, AppEventKind.AppQuit),

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
            
            Debug.Print("{0}", evt);

            if (evt.EventClass == EventClass.Application)
            {
                switch (evt.AppEventKind)
                {
                    default:
                        return OSStatus.EventNotHandled;
                }
            }
            else if (evt.EventClass == EventClass.AppleEvent)
            {
                // only event here is the apple event.
                Debug.Print("Processing apple event.");
                API.ProcessAppleEvent(inEvent);
            }

            return OSStatus.EventNotHandled;
        }

        public static void Run(CarbonGLNative window)
        {
            window.Destroy += MainWindowClosed;
            window.Show();

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

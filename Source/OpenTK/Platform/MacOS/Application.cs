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

// Created by Erik Ylvisaker on 3/17/08.

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

        static internal void Initialize()
        {
            if (mInitialized)
                return;
            
            API.AcquireRootMenu();
            
            ConnectEvents();
            
            API.Gestalt(GestaltSelector.SystemVersionMajor, out osMajor);
            API.Gestalt(GestaltSelector.SystemVersionMinor, out osMinor);
            API.Gestalt(GestaltSelector.SystemVersionBugFix, out osBugfix);
            
            Debug.Print("Running on Mac OS X {0}.{1}.{2}.", osMajor, osMinor, osBugfix);
            
            TransformProcessToForeground();
        }

        private static void TransformProcessToForeground()
        {
            Carbon.ProcessSerialNumber psn = new ProcessSerialNumber();
            
            Debug.Print("Setting process to be foreground application.");
            
            API.GetCurrentProcess(ref psn);
            API.TransformProcessType(ref psn, ProcessApplicationTransformState.kProcessTransformToForegroundApplication);
            API.SetFrontProcess(ref psn);
        }

        static internal CarbonGLNative WindowEventHandler
        {
            get { return eventHandler; }
            set { eventHandler = value; }
        }

        static void ConnectEvents()
        {
            
            EventTypeSpec[] eventTypes = new EventTypeSpec[] { new EventTypeSpec(EventClass.Application, AppEventKind.AppActivated), new EventTypeSpec(EventClass.Application, AppEventKind.AppDeactivated), new EventTypeSpec(EventClass.Application, AppEventKind.AppQuit), new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseDown), new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseUp), new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseMoved), new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseDragged), new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseEntered), new EventTypeSpec(EventClass.Mouse, MouseEventKind.MouseExited), new EventTypeSpec(EventClass.Mouse, MouseEventKind.WheelMoved),
            
            
            new EventTypeSpec(EventClass.Keyboard, KeyboardEventKind.RawKeyDown), new EventTypeSpec(EventClass.Keyboard, KeyboardEventKind.RawKeyRepeat), new EventTypeSpec(EventClass.Keyboard, KeyboardEventKind.RawKeyUp), new EventTypeSpec(EventClass.Keyboard, KeyboardEventKind.RawKeyModifiersChanged), new EventTypeSpec(EventClass.AppleEvent, AppleEventKind.AppleEvent) };
            
            MacOSEventHandler handler = EventHandler;
            uppHandler = API.NewEventHandlerUPP(handler);
            
            API.InstallApplicationEventHandler(uppHandler, eventTypes, IntPtr.Zero, IntPtr.Zero);
            
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
            window.Closed += MainWindowClosed;
            window.Visible = true;
            
            API.RunApplicationEventLoop();
            
            window.Closed -= MainWindowClosed;
        }

        static void MainWindowClosed(object sender, EventArgs e)
        {
            Debug.Print("Quitting application event loop.");
            API.QuitApplicationEventLoop();
        }


        static internal void ProcessEvents()
        {
            API.ProcessEvents();
        }
    }
}

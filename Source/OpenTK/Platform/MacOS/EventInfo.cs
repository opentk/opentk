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

//  Created by Erik Ylvisaker on 3/17/08.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OpenTK.Platform.MacOS.Carbon
{
    internal struct EventInfo
    {
        internal EventInfo(IntPtr eventRef)
        {
            this._eventClass = API.GetEventClass(eventRef);
            this._eventKind = API.GetEventKind(eventRef);
        }

        uint _eventKind;
        EventClass _eventClass;

        public EventClass EventClass
        {
            get { return _eventClass; }
        }

        public WindowEventKind WindowEventKind
        {
            get
            {
                if (EventClass == EventClass.Window)
                    return (WindowEventKind)_eventKind;
                else
                    throw new InvalidCastException("Event is not a Window event.");
            }
        }
        public KeyboardEventKind KeyboardEventKind
        {
            get
            {
                if (EventClass == EventClass.Keyboard)
                    return (KeyboardEventKind)_eventKind;
                else
                    throw new InvalidCastException("Event is not a Keyboard event.");
            }
        }
        public MouseEventKind MouseEventKind
        {
            get
            {
                if (EventClass == EventClass.Mouse)
                    return (MouseEventKind)_eventKind;
                else
                    throw new InvalidCastException("Event is not an Mouse event.");
            }
        }
        public AppEventKind AppEventKind
        {
            get
            {
                if (EventClass == EventClass.Application)
                    return (AppEventKind)_eventKind;
                else
                    throw new InvalidCastException("Event is not an Application event.");
            }
        }


        public override string ToString()
        {
            switch (EventClass)
            {
            case EventClass.Application:
                return "Event: App " + AppEventKind.ToString();
            case EventClass.Keyboard:
                return "Event: Keyboard " + KeyboardEventKind.ToString();
            case EventClass.Mouse:
                return "Event: Mouse " + MouseEventKind.ToString();
            case EventClass.Window:
                return "Event: Window " + WindowEventKind.ToString();
            }
            
            return "Event: Unknown Class " + EventClass.ToString() + "   kind: " + _eventKind.ToString();
        }
    }
}

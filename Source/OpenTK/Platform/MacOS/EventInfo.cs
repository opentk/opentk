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

        public EventClass EventClass { get { return _eventClass; }}
       
        public WindowEventKind WindowEventKind
        {
            get
            {
                if (EventClass == EventClass.Window)
                    return (WindowEventKind) _eventKind;
                else
                    throw new InvalidCastException("Event is not a Window event.");
            }
        }
        public KeyboardEventKind KeyboardEventKind
        {
            get
            {
                if (EventClass == EventClass.Keyboard)
                    return (KeyboardEventKind) _eventKind;
                else
                    throw new InvalidCastException("Event is not a Keyboard event.");
            }
        }
        public MouseEventKind MouseEventKind
        {
            get
            {
                if (EventClass == EventClass.Mouse)
                    return (MouseEventKind) _eventKind;
                else
                    throw new InvalidCastException("Event is not an Mouse event.");
            }
        }
        public AppEventKind AppEventKind
        {
            get
            {
                if (EventClass == EventClass.Application)
                    return (AppEventKind) _eventKind;
                else
                    throw new InvalidCastException("Event is not an Application event.");
            }
        }


        public override string ToString()
        {
            switch(EventClass)
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

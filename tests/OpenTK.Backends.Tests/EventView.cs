using System;
using System.Collections.Generic;
using System.Diagnostics;
using ImGuiNET;
using OpenTK.Platform;

namespace OpenTK.Backends.Tests
{
    public class EventView : View
    {
        public class CustomEventArgs : EventArgs
        {
            public int Value;
            public CustomEventArgs(int value)
            {
                Value = value;
            }
        }

        public override string Title => "Events";

        public override bool IsVisible => true;

        private List<EventArgs> Events = new List<EventArgs>();

        private bool ShowMouseEvents = false;
        private int CustomDataInt = 0;

        public override void Initialize()
        {
            EventQueue.EventRaised += EventView_EventRaised;
        }

        private void EventView_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            Events.Add(args);
        }

        public override void Paint(double deltaTime)
        {
            ImGuiUtils.ToggleButton("Mouse events", ref ShowMouseEvents);

            // FIXME: A way to filter events
            // FIXME: Collapse events of the same type
            if (ImGui.BeginListBox("Events"))
            {
                for (int i = 0; i < Events.Count; i++)
                {
                    // Proper way to filter events!
                    EventArgs @event = Events[i];
                    if (@event is MouseMoveEventArgs ||
                        @event is MouseButtonDownEventArgs ||
                        @event is MouseButtonUpEventArgs ||
                        @event is ScrollEventArgs ||
                        @event is MouseEnterEventArgs)
                    {
                        if (ShowMouseEvents)
                            PaintEvent(@event);
                    }
                    else
                    {
                        PaintEvent(@event);
                    }
                }

                ImGui.EndListBox();
            }

            ImGui.DragInt("Custom data", ref CustomDataInt);
            if (ImGui.Button("Post custom user event"))
            {
                Toolkit.Window.PostUserEvent(new CustomEventArgs(CustomDataInt));
            }
        }

        private void PaintEvent(EventArgs @event)
        {
            if (@event is CustomEventArgs customEvent)
            {
                ImGui.TextUnformatted($"CustomEvent - {customEvent.Value}");
            }
            else if (@event is WindowEventArgs windowEvent)
            {
                if (@event is TextInputEventArgs textInput)
                {
                    ImGui.TextUnformatted($"{@event.GetType().Name} - \"{textInput.Text}\"");
                }
                else if (@event is KeyDownEventArgs keyDown)
                {
                    ImGui.TextUnformatted($"{@event.GetType().Name} - {keyDown.Key} {keyDown.Scancode} {keyDown.IsRepeat} {keyDown.Modifiers}");
                }
                else if (@event is KeyUpEventArgs keyUp)
                {
                    ImGui.TextUnformatted($"{@event.GetType().Name} - {keyUp.Key} {keyUp.Scancode} {keyUp.Modifiers}");
                }
                else
                {
                    ImGui.TextUnformatted($"{@event.GetType().Name} - {Toolkit.Window.GetTitle(windowEvent.Window)}");
                }
            }
            else
            {
                ImGui.TextUnformatted(@event.GetType().Name);
            }
        }
    }
}

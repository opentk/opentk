using ImGuiNET;
using OpenTK.Mathematics;
using OpenTK.Platform;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace OpenTK.Backends.Tests
{
    public class EventView : View
    {
        public class CustomEventArgs : EventArgs
        {
            public int Value { get; set; }
            public CustomEventArgs(int value)
            {
                Value = value;
            }
        }

        public class EventMetadata
        {
            public static readonly EventMetadata Empty = new EventMetadata();
        }

        public class DisplayName : EventMetadata
        {
            public string Name;
        }

        public class DisplayValues : EventMetadata
        {
            public string Name;
            public VideoMode VideoMode;
            public Vector2i VirtualPosition;
            public Box2i WorkArea;
            public Vector2 Scale;
            // FIXME: Color info?
        }

        public override string Title => "Events";

        public override bool IsVisible => true;

        private List<EventArgs> Events = new List<EventArgs>();
        private List<EventArgs> FilteredEvents = new List<EventArgs>();
        private List<EventMetadata> EventsMetadata = new List<EventMetadata>();
        private int SelectedEventIndex = -1;

        private bool ShowMouseEvents = false;
        private int CustomDataInt = 0;

        public override void Initialize()
        {
            EventQueue.EventRaised += EventView_EventRaised;
        }

        private void EventView_EventRaised(PalHandle? handle, PlatformEventType type, EventArgs args)
        {
            Events.Add(args);
            if (FilterEvent(args) == false)
            {
                FilteredEvents.Add(args);
            }

            if (args is DisplayConnectionChangedEventArgs displayConnectionChanged)
            {
                DisplayName displayName = new DisplayName();
                displayName.Name = Toolkit.Display.GetName(displayConnectionChanged.Display);
                EventsMetadata.Add(displayName);
            }
            else if (args is DisplayValuesChangedEventArgs displayValuesChanged)
            {
                DisplayHandle display = Toolkit.Display.Open(displayValuesChanged.DisplayIndex);
                DisplayValues displayValues = new DisplayValues();
                displayValues.Name = Toolkit.Display.GetName(display);
                displayValues.VideoMode = Toolkit.Display.GetVideoMode(display);
                displayValues.VirtualPosition = Toolkit.Display.GetVirtualPosition(display);
                displayValues.WorkArea = Toolkit.Display.GetWorkArea(display);
                displayValues.Scale = Toolkit.Display.GetDisplayScale(display);
                Toolkit.Display.Close(display);
                EventsMetadata.Add(displayValues);
            }
            else
            {
                EventsMetadata.Add(EventMetadata.Empty);
            }
        }

        private void RecreateFilteredList()
        {
            FilteredEvents.Clear();
            for (int i = 0; i < Events.Count; i++)
            {
                var @event = Events[i];
                if (FilterEvent(@event) == false)
                {
                    FilteredEvents.Add(@event);
                }
            }
        }

        private bool FilterEvent(EventArgs @event)
        {
            if (ShowMouseEvents == false)
            {
                if (@event is MouseMoveEventArgs ||
                            @event is MouseButtonDownEventArgs ||
                            @event is MouseButtonUpEventArgs ||
                            @event is ScrollEventArgs ||
                            @event is MouseEnterEventArgs)
                {
                    return true;
                }
            }

            return false;
        }

        bool useClipper = false;
        public override void Paint(double deltaTime)
        {
            if (ImGuiUtils.ToggleButton("Mouse events", ref ShowMouseEvents))
            {
                RecreateFilteredList();
            }

            ImGui.DragInt("Custom data", ref CustomDataInt);
            if (ImGui.Button("Post custom user event"))
            {
                Toolkit.Window.PostUserEvent(new CustomEventArgs(CustomDataInt));
            }

            ImGui.Checkbox("Use clipper", ref useClipper);

            if (ImGui.BeginListBox("Events", new System.Numerics.Vector2(ImGui.GetColumnWidth(), ImGui.GetTextLineHeightWithSpacing() * 12.25f)))
            {
                ImGuiListClipper clipper;
                ImGuiListClipperPtr listClipper;
                unsafe
                {
                    listClipper = new ImGuiListClipperPtr(&clipper);
                }
                listClipper.Begin(FilteredEvents.Count);
                while (listClipper.Step())
                {
                    for (int i = clipper.DisplayStart; i < clipper.DisplayEnd; i++)
                    {
                        var @event = FilteredEvents[i];

                        string eventString = GetEventString(@event);

                        if (ImGui.Selectable($"{eventString}###event{i}", i == SelectedEventIndex))
                        {
                            if (i == SelectedEventIndex)
                                SelectedEventIndex = -1;
                            else
                                SelectedEventIndex = i;
                        }
                    }
                }

                ImGui.EndListBox();
            }

            if (SelectedEventIndex != -1)
            {
                var @event = FilteredEvents[SelectedEventIndex];
                int idx = Events.IndexOf(@event);
                PaintEventInfo(@event, EventsMetadata[idx]);
            }
            else
            {
                ImGui.BeginDisabled();
                ImGui.TextUnformatted("No event selected...");
                ImGui.EndDisabled();
            }
        }

        private string GetEventString(EventArgs @event)
        {
            const int Justify = -40;

            if (@event is CustomEventArgs customEvent)
            {
                return $"{@event.GetType().Name,Justify} - {customEvent.Value}";
            }
            else if (@event is WindowEventArgs windowEvent)
            {
                string extra = GetWindowEventExtra(windowEvent);
                return $"{@event.GetType().Name,Justify} - {Toolkit.Window.GetTitle(windowEvent.Window)}{(string.IsNullOrEmpty(extra) ? "" : $": {extra}")}";
            }
            else if (@event is InputLanguageChangedEventArgs languageChange)
            {
                return $"Language: {languageChange.InputLanguage.Culture.EnglishName}, Layout name: {languageChange.InputLanguage.LayoutName}";
            }
            else if (@event is ClipboardUpdateEventArgs clipboardUpdate)
            {
                return $"{@event.GetType().Name,Justify} - New clipboard format: {clipboardUpdate.NewFormat}";
            }
            else if (@event is ThemeChangeEventArgs themeChange)
            {
                return $"{@event.GetType().Name,Justify} - New theme: {themeChange.NewTheme}";
            }
            else if (@event is DisplayConnectionChangedEventArgs displayConnectionChanged)
            {
                if (displayConnectionChanged.Disconnected)
                {
                    // FIXME: Can we get the name??
                    return $"{@event.GetType().Name,Justify} - Removed display: {Toolkit.Display.GetName(displayConnectionChanged.Display)}";
                }
                else
                {
                    return $"{@event.GetType().Name,Justify} - New display: {Toolkit.Display.GetName(displayConnectionChanged.Display)}";
                }
            }
            else if (@event is DisplayValuesChangedEventArgs displayValues)
            {
                StringBuilder sb = new StringBuilder();
                if (displayValues.BitsPerPixelChanged)
                    sb.Append("Bits per pixel, ");
                if (displayValues.ResolutionChanged)
                    sb.Append("Resolution, ");
                if (displayValues.RefreshRateChanged)
                    sb.Append("Refresh rate, ");
                if (displayValues.VirtualPositionChanged)
                    sb.Append("Virtual position, ");
                if (displayValues.WorkAreaChanged)
                    sb.Append("Work area, ");
                if (displayValues.DisplayScaleChanged)
                    sb.Append("Scale, ");
                if (displayValues.ColorInfoChanged)
                    sb.Append("Color info, ");

                if (sb.Length > 0)
                {
                    sb.Length -= ", ".Length;
                }

                return $"{@event.GetType().Name,Justify} - Changed values: {sb}";
            }
            else if (@event is PowerStateChangeEventArgs powerState)
            {
                return $"{@event.GetType().Name,Justify} - {(powerState.GoingToSleep ? "Going to sleep" : "Woke up")}";
            }
            else
            {
                return @event.GetType().Name;
            }

            static string GetWindowEventExtra(WindowEventArgs @event)
            {
                if (@event is FocusEventArgs focus)
                {
                    return $"GotFocus: {focus.GotFocus}";
                }
                else if (@event is WindowMoveEventArgs windowMove)
                {
                    return $"New position: {windowMove.WindowPosition} client: {windowMove.ClientAreaPosition}";
                }
                else if (@event is WindowResizeEventArgs windowResize)
                {
                    return $"New size: {windowResize.NewSize} client: {windowResize.NewClientSize}";
                }
                else if (@event is WindowFramebufferResizeEventArgs framebufferResize)
                {
                    return $"New framebuffer size: {framebufferResize.NewFramebufferSize.X}x{framebufferResize.NewFramebufferSize.Y}";
                }
                else if (@event is WindowModeChangeEventArgs modeChanged)
                {
                    return $"New mode: {modeChanged.NewMode}";
                }
                else if (@event is WindowScaleChangeEventArgs scaleChange)
                {
                    return $"New scale: {new Vector2(scaleChange.ScaleX, scaleChange.ScaleY)}";
                }
                else if (@event is KeyDownEventArgs keyDown)
                {
                    return $"Key: {keyDown.Key}, Scancode: {keyDown.Scancode}, Modifiers: {keyDown.Modifiers}";
                }
                else if (@event is KeyUpEventArgs keyUp)
                {
                    return $"Key: {keyUp.Key}, Scancode: {keyUp.Scancode}, Modifiers: {keyUp.Modifiers}";
                }
                else if (@event is TextInputEventArgs text)
                {
                    return $"Text: {text.Text}";
                }
                else if (@event is TextEditingEventArgs textEditing)
                {
                    return "FIXME";
                }
                else if (@event is MouseEnterEventArgs mouseEnter)
                {
                    return $"{(mouseEnter.Entered ? "Entered" : "Exited")}";
                }
                else if (@event is MouseMoveEventArgs mouseMove)
                {
                    return $"Client position: {mouseMove.ClientPosition}";
                }
                else if (@event is RawMouseMoveEventArgs rawMouseMove)
                {
                    return $"Delta: {rawMouseMove.Delta}";
                }
                else if (@event is MouseButtonDownEventArgs mouseButtonDown)
                {
                    return $"Button: {mouseButtonDown.Button}, Modifiers: {mouseButtonDown.Modifiers}";
                }
                else if (@event is MouseButtonUpEventArgs mouseButtonUp)
                {
                    return $"Button: {mouseButtonUp.Button}, Modifiers: {mouseButtonUp.Modifiers}";
                }
                else if (@event is ScrollEventArgs scroll)
                {
                    return $"Delta: {scroll.Delta}";
                }
                else if (@event is CloseEventArgs)
                {
                    return $"Closed";
                }
                else if (@event is FileDropEventArgs fileDrop)
                {
                    return $"{fileDrop.FilePaths.Count} file{(fileDrop.FilePaths.Count == 1 ? "" : "s")} at {fileDrop.Position}";
                }
                else
                {
                    return "";
                }
            }
        }

        static readonly System.Numerics.Vector4 TrueColor = new System.Numerics.Vector4(0.630f, 0.980f, 0.343f, 1.0f);
        static readonly System.Numerics.Vector4 FalseColor = new System.Numerics.Vector4(1.0f, 0.184f, 0.184f, 1.0f);

        private void PaintEventInfo(EventArgs @event, EventMetadata metadata)
        {
            ImGui.SeparatorText(RemoveEnd(@event.GetType().Name, "EventArgs"));

            if (@event is DisplayConnectionChangedEventArgs displayConnectionChanged)
            {
                DisplayName name = (DisplayName)metadata;
                ImGui.TextUnformatted($"Display: {name.Name}");
                ImGui.TextUnformatted(displayConnectionChanged.Disconnected ? "Disconnected" : "Connected");
            }
            else if (@event is DisplayValuesChangedEventArgs displayValuesChanged)
            {
                DisplayValues values = (DisplayValues)metadata;
                
                ImGui.TextUnformatted($"DisplayIndex: {displayValuesChanged.DisplayIndex} - {values.Name}");
                ImGui.TextUnformatted($"BitsPerPixelChanged: ");ImGui.SameLine();ImGui.TextColored(displayValuesChanged.BitsPerPixelChanged ? TrueColor : FalseColor, $"{displayValuesChanged.BitsPerPixelChanged}");ImGui.SameLine(); ImGui.TextUnformatted($"{(displayValuesChanged.BitsPerPixelChanged ? $"({values.VideoMode.BitsPerPixel})" : "")}");
                ImGui.TextUnformatted($"ResolutionChanged: ");ImGui.SameLine();ImGui.TextColored(displayValuesChanged.ResolutionChanged ? TrueColor : FalseColor, $"{displayValuesChanged.ResolutionChanged}");ImGui.SameLine();ImGui.TextUnformatted($"{(displayValuesChanged.ResolutionChanged ? $"({values.VideoMode.Width}x{values.VideoMode.Height})" : "")}");
                ImGui.TextUnformatted($"RefreshRateChanged: ");ImGui.SameLine();ImGui.TextColored(displayValuesChanged.RefreshRateChanged ? TrueColor : FalseColor, $"{displayValuesChanged.RefreshRateChanged}");ImGui.SameLine();ImGui.TextUnformatted($"{(displayValuesChanged.RefreshRateChanged ? $"({values.VideoMode.RefreshRate})" : "")}");
                ImGui.TextUnformatted($"VirtualPositionChanged: ");ImGui.SameLine();ImGui.TextColored(displayValuesChanged.VirtualPositionChanged ? TrueColor : FalseColor, $"{displayValuesChanged.VirtualPositionChanged}");ImGui.SameLine();ImGui.TextUnformatted($"{(displayValuesChanged.VirtualPositionChanged ? $"({values.VirtualPosition.X}, {values.VirtualPosition.Y})" : "")}");
                ImGui.TextUnformatted($"WorkAreaChanged: ");ImGui.SameLine();ImGui.TextColored(displayValuesChanged.WorkAreaChanged ? TrueColor : FalseColor, $"{displayValuesChanged.WorkAreaChanged}");ImGui.SameLine();ImGui.TextUnformatted($"{(displayValuesChanged.WorkAreaChanged ? $"({values.WorkArea})" : "")}");
                ImGui.TextUnformatted($"DisplayScaleChanged: ");ImGui.SameLine();ImGui.TextColored(displayValuesChanged.DisplayScaleChanged ? TrueColor : FalseColor, $"{displayValuesChanged.DisplayScaleChanged}");ImGui.SameLine();ImGui.TextUnformatted($"{(displayValuesChanged.DisplayScaleChanged ? $"({values.Scale.X}, {values.Scale.Y})" : "")}");
                ImGui.TextUnformatted($"ColorInfoChanged: ");ImGui.SameLine();ImGui.TextColored(displayValuesChanged.ColorInfoChanged ? TrueColor : FalseColor, $"{displayValuesChanged.ColorInfoChanged}");ImGui.SameLine();ImGui.TextUnformatted($"{(displayValuesChanged.ColorInfoChanged ? $"(FIXME)" : "")}");
            }
            else
            {
                PaintGenericEvent(@event);
            }

            static void PaintGenericEvent(EventArgs @event)
                {
                    Type eventType = @event.GetType();
                    var properties = eventType.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                    for (int i = 0; i < properties.Length; i++)
                    {
                        var property = properties[i];
                        var value = property.GetValue(@event);
                        switch (value)
                        {
                        case System.Collections.IList list:
                            StringBuilder sb = new StringBuilder();
                            sb.Append('[');
                            foreach (var item in list)
                            {
                                sb.Append(item);
                                sb.Append(", ");
                            }
                            if (list.Count > 0)
                            {
                                sb.Length -= ", ".Length;
                            }
                            sb.Append(']');
                            value = sb.ToString();
                        break;
                        case WindowHandle window:
                            value = Toolkit.Window.GetTitle(window);
                            break;
                        }
                        ImGui.TextUnformatted($"{property.Name}: {value}");
                    }
                }

            static string RemoveEnd(string str, string end)
            {
                if (str.EndsWith(end))
                    return str.Remove(str.Length - end.Length);
                else return str;
            }
        }
    }
}

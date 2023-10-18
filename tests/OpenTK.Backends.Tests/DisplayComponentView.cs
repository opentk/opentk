using ImGuiNET;
using OpenTK.Core.Platform;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Core.Platform.Handles;

namespace OpenTK.Backends.Tests
{
    public class DisplayComponentView : View
    {
        struct Display
        {
            public int Index;
            public string Name;
            public bool Primary;
            public Box2i Bounds;
            public float RefreshRate;

            public Display(int index, string name, bool primary, Box2i bounds, float refreshRate)
            {
                Index = index;
                Name = name;
                Primary = primary;
                Bounds = bounds;
                RefreshRate = refreshRate;
            }
        }

        public override string Title => "Displays";

        public override bool IsVisible => Program.DisplayComponent != null;

        private bool canGetVirtualPosition;

        private List<Display> Displays = new List<Display>();

        private Box2i BoundingBox = Box2i.Empty;

        private int SelectedDisplay = -1;

        const float PADDING = 5;
        static readonly Vector2 PADDINGV2 = (PADDING, PADDING);
        const float PADDING2 = PADDING * 2;
        static readonly Vector2 PADDING2V2 = (PADDING2, PADDING2);

        public override void Initialize()
        {
            try { canGetVirtualPosition = Program.DisplayComponent!.CanGetVirtualPosition; } catch { canGetVirtualPosition = false; }

            int displays = Program.DisplayComponent!.GetDisplayCount();
            for (int i = 0; i < displays; i++)
            {
                var handle = Program.DisplayComponent.Open(i);

                string name = Program.DisplayComponent.GetName(handle);
                bool primary = Program.DisplayComponent.IsPrimary(handle);
                Program.DisplayComponent.GetVirtualPosition(handle, out int x, out int y);
                Program.DisplayComponent.GetResolution(handle, out int width, out int height);
                Program.DisplayComponent.GetRefreshRate(handle, out float refreshRate);

                Display disp = new Display(i, name, primary, new Box2i(x, y, x + width, y + height), refreshRate);
                Displays.Add(disp);

                BoundingBox.Inflate(disp.Bounds.Min);
                BoundingBox.Inflate(disp.Bounds.Max);

                Program.DisplayComponent.Close(handle);
            }
        }

        public override void Paint()
        {
            base.Paint();

            ImGui.SeparatorText("Component Properties");
            // FIXME: Separate display if the property threw an exception?
            ImGuiUtils.ReadonlyCheckbox("Can Get Virtual Position", canGetVirtualPosition);

            ImGui.SeparatorText("Displays");

            ImDrawListPtr draw_list = ImGui.GetWindowDrawList();
            Vector2 p = ImGui.GetCursorScreenPos().ToOpenTK();

            float targetAspect = BoundingBox.Width / (float)BoundingBox.Height;

            // FIXME: We want the content size of the window, ie the size between the tabs and the end of the window.
            // Does that give us that?
            float windowHeight = ImGui.GetWindowHeight();

            float displayViewHeight = windowHeight * 0.45f;
            float displayViewWidth = ImGui.GetWindowWidth();
            float displayViewAspect = displayViewWidth / displayViewHeight;

            // FIXME: Introduce a minimum size for the area.
            if (targetAspect < displayViewAspect)
            {
                displayViewWidth *= (targetAspect / displayViewAspect);
            }
            else if (targetAspect > displayViewAspect)
            {
                displayViewHeight *= (displayViewAspect / targetAspect);
            }

            // Maybe center the drawing?
            Vector2 size = (displayViewWidth, displayViewHeight);

            draw_list.AddRectFilled(p.AsNumerics(), (p + size).ToNumerics(), 0xFF444444, 5f, ImDrawFlags.RoundCornersAll);

            for (int i = 0; i < Displays.Count; i++)
            {
                Display disp = Displays[i];

                Vector2 min = (disp.Bounds.Min / (Vector2)BoundingBox.Size) * (size - PADDING2V2) + PADDINGV2;
                Vector2 max = (disp.Bounds.Max / (Vector2)BoundingBox.Size) * (size - PADDING2V2) + PADDINGV2;

                const uint FILL_NORMAL = 0xAA997744;
                const uint FILL_SELECTED = 0xAABF7022;
                const uint FILL_HOVER = 0xAABB9966;
                const uint FILL_SELECTED_HOVER = 0xAACF8032;

                uint fillColor = i == SelectedDisplay ? FILL_SELECTED : FILL_NORMAL;
                if (ImGui.IsMouseHoveringRect((p + min).ToNumerics(), (p + max).ToNumerics()) && !ImGui.IsMouseDown(ImGuiMouseButton.Left))
                    fillColor = i == SelectedDisplay ? FILL_SELECTED_HOVER : FILL_HOVER;

                draw_list.AddRectFilled((p + min).ToNumerics(), (p + max).ToNumerics(), fillColor, 5f, ImDrawFlags.RoundCornersAll);
                draw_list.AddRect((p + min).ToNumerics(), (p + max).ToNumerics(), 0xFFFFFFFF, 5f, ImDrawFlags.RoundCornersAll);

                draw_list.AddText((p + min + (10, 10)).ToNumerics(), ImGui.GetColorU32(ImGuiCol.Text), $"{i}");

                {
                    Vector2i resolution = disp.Bounds.Size;
                    string resolutionStr = $"{resolution.X}x{resolution.Y} @{disp.RefreshRate}Hz";
                    Vector2 textSize = ImGui.CalcTextSize(resolutionStr).ToOpenTK();

                    draw_list.AddText((p + ((min + max) / 2) - (textSize / 2)).ToNumerics(), ImGui.GetColorU32(ImGuiCol.Text), resolutionStr);
                }

                ImGui.SetCursorPos((p + min).ToNumerics());
                if (ImGui.InvisibleButton($"{i}", (max - min).ToNumerics()))
                {
                    SelectedDisplay = i;
                }
            }

            ImGui.SetCursorScreenPos(p.ToNumerics());
            ImGui.Dummy(size.ToNumerics());

            ImGui.SeparatorText("Display Info");

            if (SelectedDisplay != -1)
            {
                Display disp = Displays[SelectedDisplay];

                var (x, y) = disp.Bounds.Location;
                var (width, height) = disp.Bounds.Size;

                ImGui.BeginDisabled();
                ImGui.Text($"Name: {Displays[SelectedDisplay].Name} ({SelectedDisplay})");
                ImGui.Text($"Virtual Position: ({x}, {y})");
                ImGui.Text($"Resolution: {width}x{height}");
                ImGui.Text($"Refresh rate: {disp.RefreshRate}Hz");

                DisplayHandle handle = Program.DisplayComponent!.Open(disp.Index);
                Program.DisplayComponent.GetVideoMode(handle, out VideoMode currentVideoMode);
                ImGui.Text($"Video mode: {currentVideoMode}");

                VideoMode[] modes = Program.DisplayComponent.GetSupportedVideoModes(handle);
                ImGui.EndDisabled();
                if (ImGui.BeginListBox("Supported video modes"))
                {
                    ImGui.BeginDisabled();
                    for (int i = 0; i < modes.Length; i++)
                    {
                        ImGui.Selectable(modes[i].ToString());
                    }
                    ImGui.EndDisabled();

                    ImGui.EndListBox();
                }
                ImGui.BeginDisabled();

                ImGui.EndDisabled();
            }
        }
    }
}

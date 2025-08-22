using ImGuiNET;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Platform;
using OpenTK.Platform.Native;
using OpenTK.Platform.Native.macOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
            public Vector2 Scale;

            public Display(int index, string name, bool primary, Box2i bounds, float refreshRate, Vector2 scale)
            {
                Index = index;
                Name = name;
                Primary = primary;
                Bounds = bounds;
                RefreshRate = refreshRate;
                Scale = scale;
            }
        }

        public override string Title => "Displays";

        public override bool IsVisible => Toolkit.Display != null;

        private bool canGetVirtualPosition;

        private List<Display> Displays = new List<Display>();

        private Box2i BoundingBox = Box2i.Empty;

        private int SelectedDisplay = -1;

        private int Granularity = 4;
        private Vector2[]? Locus = null;
        private static readonly Vector2i LocusDiagramSize = (200, 200);

        const float PADDING = 5;
        static readonly Vector2 PADDINGV2 = (PADDING, PADDING);
        const float PADDING2 = PADDING * 2;
        static readonly Vector2 PADDING2V2 = (PADDING2, PADDING2);

        public override void Initialize()
        {
            try { canGetVirtualPosition = Toolkit.Display.CanGetVirtualPosition; } catch { canGetVirtualPosition = false; }

            int displays = Toolkit.Display.GetDisplayCount();
            for (int i = 0; i < displays; i++)
            {
                var handle = Toolkit.Display.Open(i);

                string name = Toolkit.Display.GetName(handle);
                bool primary = Toolkit.Display.IsPrimary(handle);
                Toolkit.Display.GetVirtualPosition(handle, out int x, out int y);
                Toolkit.Display.GetResolution(handle, out int width, out int height);
                Toolkit.Display.GetRefreshRate(handle, out float refreshRate);
                Toolkit.Display.GetDisplayScale(handle, out float scaleX, out float scaleY);

                Display disp = new Display(i, name, primary, new Box2i(x, y, x + width, y + height), refreshRate, (scaleX, scaleY));
                Displays.Add(disp);

                BoundingBox.Extend(disp.Bounds.Min);
                BoundingBox.Extend(disp.Bounds.Max);

                Toolkit.Display.Close(handle);
            }
        }

        public void HandleConnectionChange(DisplayConnectionChangedEventArgs connectionChange)
        {
            Program.Logger.LogInfo("Refreshing screen info!");
            if (connectionChange.Disconnected)
            {
                // FIXME: Make sure that we can always get the name of disconnected displays
                // We probably want a few DisplayComponent function to still work in the disconnected
                // event so we should formalize and document this.
                // - Noggin_bops 2024-02-28
                Program.Logger.LogDebug($"Display '{Toolkit.Display.GetName(connectionChange.Display)}' was disconnected.");
            }
            else
            {
                Program.Logger.LogDebug($"Display '{Toolkit.Display.GetName(connectionChange.Display)}' was connected.");
            }

            // FIXME: For now we just recreate the entire list of displays.
            BoundingBox = Box2i.Empty;
            Displays.Clear();
            
            int displays = Toolkit.Display.GetDisplayCount();
            for (int i = 0; i < displays; i++)
            {
                var handle = Toolkit.Display.Open(i);

                string name = Toolkit.Display.GetName(handle);
                bool primary = Toolkit.Display.IsPrimary(handle);
                Toolkit.Display.GetVirtualPosition(handle, out int x, out int y);
                Toolkit.Display.GetResolution(handle, out int width, out int height);
                Toolkit.Display.GetRefreshRate(handle, out float refreshRate);
                Toolkit.Display.GetDisplayScale(handle, out float scaleX, out float scaleY);

                Display disp = new Display(i, name, primary, new Box2i(x, y, x + width, y + height), refreshRate, (scaleX, scaleY));
                Displays.Add(disp);

                BoundingBox.Extend(disp.Bounds.Min);
                BoundingBox.Extend(disp.Bounds.Max);

                Toolkit.Display.Close(handle);
            }
        }

        public override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

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

                const uint FILL_WORK_NORMAL = 0x77FFEF78;
                const uint FILL_WORK_SELECTED = 0x77FFF399;
                const uint FILL_WORK_HOVER = 0x77FFF5AD;
                const uint FILL_WORK_SELECTED_HOVER = 0x77FFF3D0;

                bool hovered = ImGui.IsMouseHoveringRect((p + min).ToNumerics(), (p + max).ToNumerics()) && !ImGui.IsMouseDown(ImGuiMouseButton.Left);
                uint fillColor = i == SelectedDisplay ? FILL_SELECTED : FILL_NORMAL;
                if (hovered)
                    fillColor = i == SelectedDisplay ? FILL_SELECTED_HOVER : FILL_HOVER;

                draw_list.AddRectFilled((p + min).ToNumerics(), (p + max).ToNumerics(), fillColor, 5f, ImDrawFlags.RoundCornersAll);
                draw_list.AddRect((p + min).ToNumerics(), (p + max).ToNumerics(), 0xFFFFFFFF, 5f, ImDrawFlags.RoundCornersAll);

                try
                {
                    DisplayHandle handle = Toolkit.Display.Open(disp.Index);
                    Toolkit.Display.GetWorkArea(handle, out Box2i workArea);
                    Toolkit.Display.Close(handle);

                    // Scale the workArea to be in the range [min, max].
                    Vector2 workMin;
                    workMin.X = MathHelper.MapRange(workArea.Min.X, disp.Bounds.Min.X, disp.Bounds.Max.X, min.X, max.X);
                    workMin.Y = MathHelper.MapRange(workArea.Min.Y, disp.Bounds.Min.Y, disp.Bounds.Max.Y, min.Y, max.Y);
                    Vector2 workMax;
                    workMax.X = MathHelper.MapRange(workArea.Max.X, disp.Bounds.Min.X, disp.Bounds.Max.X, min.X, max.X);
                    workMax.Y = MathHelper.MapRange(workArea.Max.Y, disp.Bounds.Min.Y, disp.Bounds.Max.Y, min.Y, max.Y);

                    uint fillWorkColor = i == SelectedDisplay ? FILL_WORK_SELECTED : FILL_WORK_NORMAL;
                    if (hovered)
                        fillWorkColor = i == SelectedDisplay ? FILL_WORK_SELECTED_HOVER : FILL_WORK_HOVER;

                    // FIXME: Should we round here?
                    draw_list.AddRectFilled((p + workMin).ToNumerics(), (p + workMax).ToNumerics(), fillWorkColor, 5f, ImDrawFlags.RoundCornersAll);
                }
                catch { }

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
                ImGui.Text($"Scale factor: {disp.Scale}");

                DisplayHandle handle = Toolkit.Display.Open(disp.Index);

                Platform.Native.Windows.DisplayColorInfo colorInfo = default;
                bool hasColorInfo = (Toolkit.Display as Platform.Native.Windows.DisplayComponent)?.GetColorInfo(handle, out colorInfo) ?? false;
                ImGui.Text($"Has HDR Info: {hasColorInfo}");
                if (hasColorInfo)
                {
                    ImGui.Text($"  Advanced Color Info 2: {colorInfo.IsAdvancedColorInfo2}");
                    ImGui.Text($"  HDR Supported: {colorInfo.HdrSupported} | Enabled: {colorInfo.HdrEnabled?.ToString() ?? "?"} | Active: {colorInfo.HdrActive}");
                    ImGui.Text($"  WGC Supported: {colorInfo.WideColorGammutSupported} | Enabled: {colorInfo.WideColorGammutEnabled} | Active: {colorInfo.WideColorGammutActive}");
                    ImGui.Text($"  SDR White point: {colorInfo.SDRWhitePoint}");
                    ImGui.Text($"  Color encoding: {colorInfo.ColorEncoding}");
                    
                    ImGui.EndDisabled();
                    ImGui.DragInt("Granularity", ref Granularity, 1, 1, 20);
                    ImGui.BeginDisabled();

                    ImGui.Text($"  Has color volume info: {colorInfo.HasColorVolumeInfo}");
                    ImGui.Columns(2);
                    ImGui.SetColumnWidth(0, 200 + 3 * ImGui.GetStyle().FramePadding.X);
                    {
                        Vector2 diagramPos = ImGui.GetCursorScreenPos().ToOpenTK();
                        Vector2 diagramSize = LocusDiagramSize;
                        Box2 diagramBounds = Box2.FromSize(diagramPos, diagramSize);

                        uint bgColor = ImGui.GetColorU32(ImGuiCol.FrameBg);
                        uint textColor = ImGui.GetColorU32(ImGuiCol.Text);
                        uint borderColor = 0xFF000000;

                        ImDrawListPtr drawList = ImGui.GetWindowDrawList();
                        drawList.PushClipRect(diagramPos.AsNumerics(), (diagramPos + diagramSize).ToNumerics());

                        draw_list.AddRectFilled(diagramPos.AsNumerics(), (diagramPos + diagramSize).ToNumerics(), 0xFF444444, 5f, ImDrawFlags.RoundCornersAll);

                        ColorMatchingFunctions.CalculateLocus(ColorMatchingFunctions.CIEXYZ1931, ref Locus, Granularity, diagramBounds.Scaled(new Vector2(0.95f), diagramBounds.Center), out var xyTransform);

                        Vector2 red = xyTransform.Transform(colorInfo.ColorVolume.RedPrimary);
                        Vector2 green = xyTransform.Transform(colorInfo.ColorVolume.GreenPrimary);
                        Vector2 blue = xyTransform.Transform(colorInfo.ColorVolume.BluePrimary);
                        Vector2 white = xyTransform.Transform(colorInfo.ColorVolume.WhitePoint);

                        // FIXME: We might need a custom shader to do the colors properly...
                        drawList.AddConvexPolyFilled(ref Locus.AsSpan().ToNumerics()[0], Locus.Length, textColor);

                        drawList.AddTriangle(red.AsNumerics(), green.AsNumerics(), blue.AsNumerics(), borderColor, 2);
                        drawList.AddCircleFilled(white.AsNumerics(), 2, borderColor);


                        drawList.PopClipRect();
                        ImGui.SetCursorScreenPos(diagramPos.ToNumerics());
                        ImGui.Dummy(diagramSize.AsNumerics());
                    }
                    ImGui.NextColumn();
                    {
                        ImGui.Text($"Red primary: {colorInfo.ColorVolume.RedPrimary}");
                        ImGui.Text($"Green primary: {colorInfo.ColorVolume.GreenPrimary}");
                        ImGui.Text($"Blue primary: {colorInfo.ColorVolume.BluePrimary}");
                        ImGui.Text($"White point: {colorInfo.ColorVolume.WhitePoint}");
                        ImGui.Text($"Min luminance (cd/m^2): {colorInfo.ColorVolume.MinLuminance}");
                        ImGui.Text($"Max luminance (cd/m^2): {colorInfo.ColorVolume.MaxLuminance}"); ImGui.SameLine(); ImGuiUtils.HelpMarker("Most HDR displays can only achive this luminance for a small area of the screen. The \"full frame\" luminance describes the luminance that can be achived when a single color fills the entire area of the display.");
                        ImGui.Text($"Max full frame luminance (cd/m^2): {colorInfo.ColorVolume.MaxFullFrameLuminance}"); ImGui.SameLine(); ImGuiUtils.HelpMarker("The luminance that can be achived for a single color that fills the entire area of the display.");
                        ImGui.Text($"Color space: {colorInfo.ColorSpace}");
                    }
                    ImGui.Columns(1);
                }

                Toolkit.Display.GetVideoMode(handle, out VideoMode currentVideoMode);
                ImGui.Text($"Video mode: {currentVideoMode}");

                VideoMode[] modes = Toolkit.Display.GetSupportedVideoModes(handle);
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

                if (Toolkit.Display is MacOSDisplayComponent macOSDisplayComponent)
                {
                    ImGui.SeparatorText("MacOS");

                    macOSDisplayComponent.GetSafeArea(handle, out Box2i safeArea);
                    macOSDisplayComponent.GetSafeLeftAuxArea(handle, out Box2i leftArea);
                    macOSDisplayComponent.GetSafeRightAuxArea(handle, out Box2i rightArea);

                    ImGui.Text($"Safe area: {safeArea}");
                    ImGui.Text($"Top left aux area: {leftArea}");
                    ImGui.Text($"Top right aux area: {rightArea}");
                }

                Toolkit.Display.Close(handle);

                ImGui.EndDisabled();
            }
        }
    }
}

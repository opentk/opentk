using System;
using System.Drawing;
using ImGuiNET;
using OpenTK.Mathematics;
using OpenTK.Platform;

namespace OpenTK.Backends.Tests
{
    public class JoystickComponentView : View
    {
        public override string Title => "Joystick";

        public override bool IsVisible => Toolkit.Joystick != null;

        public override void Initialize()
        {
            base.Initialize();
        }

        private void DrawAxis(float x, float y, float deadzone)
        {
            // FIXME: Padding!
            const float RADIUS = 50;
            const float SMALL_RADIUS = 8;

            ImDrawListPtr draw_list = ImGui.GetWindowDrawList();
            Vector2 p = ImGui.GetCursorScreenPos().ToOpenTK();

            // XY axes
            draw_list.AddLine((p + new Vector2(0, RADIUS)).ToNumerics(), (p + new Vector2(2 * RADIUS, RADIUS)).ToNumerics(), ImGui.GetColorU32(ImGuiCol.TextDisabled));
            draw_list.AddLine((p + new Vector2(RADIUS, 0)).ToNumerics(), (p + new Vector2(RADIUS, 2 * RADIUS)).ToNumerics(), ImGui.GetColorU32(ImGuiCol.TextDisabled));

            // Deadzone circle
            draw_list.AddCircle((p + new Vector2(RADIUS, RADIUS)).ToNumerics(), RADIUS * deadzone, ImGui.ColorConvertFloat4ToU32(new System.Numerics.Vector4(0.8f, 0.2f, 0, 0.8f)));

            // Outline
            draw_list.AddCircle((p + new Vector2(RADIUS, RADIUS)).ToNumerics(), RADIUS, ImGui.GetColorU32(ImGuiCol.Text));

            // Position circle
            draw_list.AddCircle((p + new Vector2((x * 0.5f + 0.5f) * RADIUS * 2, (y * 0.5f + 0.5f) * RADIUS * 2)).ToNumerics(), SMALL_RADIUS, 0xFFFFFFFF);
            draw_list.AddCircleFilled((p + new Vector2((x * 0.5f + 0.5f) * RADIUS * 2, (y * 0.5f + 0.5f) * RADIUS * 2)).ToNumerics(), 1.5f, 0xFF0000FF);

            string str = $"X:{x:0.00} Y:{y:0.00}";
            Vector2 strSize = ImGui.CalcTextSize(str).ToOpenTK();

            draw_list.AddText((p + new Vector2((2 * RADIUS) / 2 - strSize.X / 2, 2 * RADIUS)).ToNumerics(), ImGui.GetColorU32(ImGuiCol.Text), str);

            ImGui.Dummy(new Vector2(RADIUS * 2, RADIUS * 2 + ImGui.GetTextLineHeightWithSpacing()).ToNumerics());
        }

        private void DrawTrigger(string label, float t)
        {
            const float WIDTH = 40;
            const float HEIGHT = 100;
            const float RADIUS = 10;

            t = (t + 1) * 0.5f;

            ImDrawListPtr draw_list = ImGui.GetWindowDrawList();
            Vector2 p = ImGui.GetCursorScreenPos().ToOpenTK();

            // FIXME: When t is vert small the radius doesn't work correctly...
            // There is some code in imgui that is used for horizontal progress bars
            // which handles this but it is not public.
            // https://github.com/ocornut/imgui/blob/master/imgui_draw.cpp#L5881
            // - Noggin_bops 2025-07-13
            draw_list.AddRectFilled((p + new Vector2(0, (1 - t) * HEIGHT)).ToNumerics(), (p + new Vector2(WIDTH, HEIGHT)).ToNumerics(), ImGui.GetColorU32(ImGuiCol.Text), RADIUS);

            // Outline
            draw_list.AddRect(p.ToNumerics(), (p + new Vector2(WIDTH, HEIGHT)).ToNumerics(), ImGui.GetColorU32(ImGuiCol.Text), RADIUS);

            string str = $"{t:0.00}";
            Vector2 strSize = ImGui.CalcTextSize(str).ToOpenTK();

            draw_list.AddText((p + new Vector2(WIDTH / 2 - strSize.X / 2, HEIGHT + ImGui.GetStyle().ItemSpacing.Y)).ToNumerics(), ImGui.GetColorU32(ImGuiCol.Text), str);

            ImGui.Dummy(new Vector2(WIDTH, HEIGHT + ImGui.GetTextLineHeightWithSpacing()).ToNumerics());
        }

        private void DrawButton(string label, bool pressed, Color3<Hsv> hsv_color)
        {
            const float WIDTH = 50;
            const float HEIGHT = 50;
            const float RADIUS = 25;

            ImDrawListPtr draw_list = ImGui.GetWindowDrawList();
            Vector2 p = ImGui.GetCursorScreenPos().ToOpenTK();

            Color4<Rgba> color = hsv_color.ToRgb().ToRgba(1.0f);
            Color4<Rgba> bg_color = new Color3<Hsv>(hsv_color.X, hsv_color.Y * 0.5f, hsv_color.Z * 0.5f).ToRgb().ToRgba(1.0f);
            Color4<Rgba> pressed_color = new Color3<Hsv>(hsv_color.X, float.Clamp(hsv_color.Y * 1.5f, 0, 1), hsv_color.Z).ToRgb().ToRgba(1.0f);

            draw_list.AddCircleFilled((p + new Vector2(RADIUS, RADIUS)).ToNumerics(), RADIUS, (pressed ? pressed_color : bg_color).ToImGui());
            draw_list.AddCircle((p + new Vector2(RADIUS, RADIUS)).ToNumerics(), RADIUS, color.ToImGui());

            Vector2 strSize = ImGui.CalcTextSize(label).ToOpenTK();

            draw_list.AddText((p + new Vector2(WIDTH / 2 - strSize.X / 2, HEIGHT / 2 + -strSize.Y / 2)).ToNumerics(), ImGui.GetColorU32(ImGuiCol.Text), label);

            ImGui.Dummy(new Vector2(WIDTH, HEIGHT).ToNumerics());
        }

        private void DrawHat(string label, HatState state)
        {
            const float WIDTH = 50;
            const float HEIGHT = 50;
            const float RADIUS = 10;

            const float CENTER_DIAMETER = WIDTH / 2.0f;
            const float PADDING = 2;
            const float TRI_WIDTH = WIDTH - 2*PADDING;
            const float TRI_HEIGHT = HEIGHT - 2*PADDING;
            const float PAD_WIDTH = CENTER_DIAMETER - 10;

            ImDrawListPtr draw_list = ImGui.GetWindowDrawList();
            Vector2 p = ImGui.GetCursorScreenPos().ToOpenTK();

            draw_list.AddRectFilled(p.ToNumerics(), (p + new Vector2(WIDTH, HEIGHT)).ToNumerics(), new Color4<Rgba>(0.2f, 0.2f, 0.2f, 1.0f).ToImGui(), RADIUS);

            string str = $"{state}";
            Vector2 strSize = ImGui.CalcTextSize(str).ToOpenTK();

            Vector2 iconPos = p + new Vector2(PADDING, PADDING);

            draw_list.AddRectFilled(
                (iconPos + new Vector2((TRI_WIDTH / 2) - (PAD_WIDTH / 2.0f), 0)).ToNumerics(),
                (iconPos + new Vector2((TRI_WIDTH / 2) + (PAD_WIDTH / 2.0f), TRI_HEIGHT)).ToNumerics(),
                Color4.Dimgray.ToImGui(), RADIUS);

            draw_list.AddRectFilled(
                (iconPos + new Vector2(0, (TRI_HEIGHT / 2) - (PAD_WIDTH / 2.0f))).ToNumerics(),
                (iconPos + new Vector2(TRI_WIDTH, (TRI_HEIGHT / 2) + (PAD_WIDTH / 2.0f))).ToNumerics(),
                Color4.Dimgray.ToImGui(), RADIUS);

            float angle = 0;
            switch (state)
            {
                case HatState.Centered:
                    draw_list.AddCircleFilled((iconPos + new Vector2(TRI_WIDTH / 2.0f, TRI_HEIGHT / 2.0f)).ToNumerics(), CENTER_DIAMETER / 2.0f, ImGui.GetColorU32(ImGuiCol.TextDisabled));
                    break;
                case HatState.Left:
                    angle = (2 * MathF.PI / 8) * 0;
                    goto case (HatState)100;
                case HatState.Right:
                    angle = (2 * MathF.PI / 8) * 4;
                    goto case (HatState)100;
                case HatState.Up:
                    angle = (2 * MathF.PI / 8) * 2;
                    goto case (HatState)100;
                case HatState.Down:
                    angle = (2 * MathF.PI / 8) * 6;
                    goto case (HatState)100;
                case HatState.LeftUp:
                    angle = (2 * MathF.PI / 8) * 1;
                    goto case (HatState)100;
                case HatState.LeftDown:
                    angle = (2 * MathF.PI / 8) * 7;
                    goto case (HatState)100;
                case HatState.RightUp:
                    angle = (2 * MathF.PI / 8) * 3;
                    goto case (HatState)100;
                case HatState.RightDown:
                    angle = (2 * MathF.PI / 8) * 5;
                    goto case (HatState)100;

                case (HatState)100:
                    draw_list.AddTriangleFilled(
                        (iconPos + new Vector2(TRI_WIDTH / 2.0f, TRI_HEIGHT / 2.0f) - new Vector2(MathF.Cos(angle + MathHelper.PiOver2), MathF.Sin(angle + MathHelper.PiOver2)) * (CENTER_DIAMETER / 2.0f)).ToNumerics(),
                        (iconPos + new Vector2(TRI_WIDTH / 2.0f, TRI_HEIGHT / 2.0f) - new Vector2(MathF.Cos(angle - MathHelper.PiOver2), MathF.Sin(angle - MathHelper.PiOver2)) * (CENTER_DIAMETER / 2.0f)).ToNumerics(),
                        (iconPos + new Vector2(TRI_WIDTH / 2.0f, TRI_HEIGHT / 2.0f) - new Vector2(MathF.Cos(angle), MathF.Sin(angle)) * CENTER_DIAMETER).ToNumerics(),
                        ImGui.GetColorU32(ImGuiCol.Text));

                    draw_list.AddCircleFilled((iconPos + new Vector2(TRI_WIDTH / 2.0f, TRI_HEIGHT / 2.0f)).ToNumerics(), CENTER_DIAMETER / 2.0f, ImGui.GetColorU32(ImGuiCol.TextDisabled));
                    break;
                default:
                    break;
            }

            

            ImGui.Dummy(new Vector2(WIDTH, HEIGHT + ImGui.GetTextLineHeightWithSpacing()).ToNumerics());
        }

        private void DrawJoystickState(int index, JoystickHandle joystick)
        {
            Guid guid = Toolkit.Joystick.GetGuid(joystick);
            string name = Toolkit.Joystick.GetName(joystick);
            if (ImGui.BeginChild($"##{guid}-{index}", new System.Numerics.Vector2(), ImGuiChildFlags.Borders | ImGuiChildFlags.AutoResizeY, ImGuiWindowFlags.HorizontalScrollbar | ImGuiWindowFlags.AlwaysHorizontalScrollbar))
            {
                ImGui.SeparatorText($"{name} ({guid})");

                if (Toolkit.Joystick.TryGetBatteryInfo(joystick, out GamepadBatteryInfo batteryInfo))
                {
                    ImGui.Text($"Battery type: {batteryInfo.BatteryType}, Charge: {batteryInfo.ChargeLevel*100:0.0}%");
                }
                else
                {
                    ImGui.TextDisabled("Unable to get battery status.");
                }

                // FIXME: Make UI for linking axes with rumble?
                //Toolkit.Joystick.SetRumble(joystick, leftTrigger, rightTrigger);

                if (ImGui.BeginChild("##axes", new System.Numerics.Vector2(), ImGuiChildFlags.AutoResizeX | ImGuiChildFlags.AutoResizeY, ImGuiWindowFlags.NoScrollbar))
                {
                    int nAxes = Toolkit.Joystick.GetNumberOfAxes(joystick);
                    for (int i = 0; i < nAxes; i++)
                    {
                        float value = Toolkit.Joystick.GetAxis(joystick, i);
                        DrawTrigger($"{i}", value);
                        ImGui.SameLine();
                    }
                    ImGui.NewLine();
                }
                ImGui.EndChild();

                ImGui.SameLine();

                if (ImGui.BeginChild("##buttons", new System.Numerics.Vector2(), ImGuiChildFlags.AutoResizeX | ImGuiChildFlags.AutoResizeY, ImGuiWindowFlags.NoScrollbar))
                {
                    int nButtons = Toolkit.Joystick.GetNumberOfButtons(joystick);
                    for (int i = 0; i < nButtons; i++)
                    {
                        bool pressed = Toolkit.Joystick.GetButton(joystick, i);
                        DrawButton($"{i}", pressed, new Color3<Rgb>(0.5f, 0.5f, 0.5f).ToHsv());
                        ImGui.SameLine();
                    }
                    ImGui.NewLine();
                }
                ImGui.EndChild();

                if (ImGui.BeginChild("##hats", new System.Numerics.Vector2(), ImGuiChildFlags.AutoResizeX | ImGuiChildFlags.AutoResizeY, ImGuiWindowFlags.NoScrollbar))
                {
                    int nHats = Toolkit.Joystick.GetNumberOfHats(joystick);
                    for (int i = 0; i < nHats; i++)
                    {
                        HatState state = Toolkit.Joystick.GetHat(joystick, i);
                        DrawHat($"{i}", state);
                        ImGui.SameLine();
                    }
                    ImGui.NewLine();
                }
                ImGui.EndChild();
            }
            ImGui.EndChild();
        }

        public override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

            ImGui.SeparatorText("Component properties");

            ImGui.SeparatorText("Joysticks");

            if (ImGui.BeginChild("##controller-container", new System.Numerics.Vector2(ImGui.GetContentRegionAvail().X, Math.Max(200, ImGui.GetContentRegionAvail().Y))))
            {
                int nJoysticks = Toolkit.Joystick.GetJoystickCount();
                for (int i = 0; i < nJoysticks; i++)
                {
                    JoystickHandle handle = Toolkit.Joystick.Open(i);

                    DrawJoystickState(i, handle);

                    Toolkit.Joystick.Close(handle);
                }
            }
            ImGui.EndChild();
        }
    }
}

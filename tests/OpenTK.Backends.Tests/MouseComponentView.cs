using ImGuiNET;
using OpenTK.Platform;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Backends.Tests
{
    internal class MouseComponentView : View
    {
        public override string Title => "Mouse";

        public override bool IsVisible => Toolkit.Mouse != null;

        private bool canSetMousePosition;
        private bool supportsRawMouseMotion;

        private Vector2 setPosition;
        private bool enableRawInput = false;

        public override void Initialize()
        {
            base.Initialize();

            try { canSetMousePosition = Toolkit.Mouse.CanSetMousePosition; } catch { canSetMousePosition = false; }
            try { supportsRawMouseMotion = Toolkit.Mouse.SupportsRawMouseMotion; } catch { supportsRawMouseMotion = false; }
        }

        public override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

            ImGui.SeparatorText("Common properties");

            ImGuiUtils.ReadonlyCheckbox("Can Set Mouse Position", canSetMousePosition);
            ImGuiUtils.ReadonlyCheckbox("Supports Raw Mouse Motion", supportsRawMouseMotion);

            ImGui.SeparatorText("Mouse state");

            Toolkit.Mouse.GetPosition(out int x, out int y);
            ImGui.TextUnformatted($"Mouse position: ({x}, {y})");

            try
            {
                Toolkit.Mouse.GetMouseState(out MouseState state);

                ImGui.TextUnformatted($"Mouse state:");
                ImGui.TextUnformatted($"  Position: {state.Position}");
                ImGui.TextUnformatted($"  Scroll pos: {state.Scroll}");
                ImGui.TextUnformatted($"  Pressed buttons: {state.PressedButtons}");

                // FIXME: Calcuate a diff against the last mouse state and display that as well.
            }
            catch (NotImplementedException)
            {
                ImGui.TextUnformatted("GetMouseState() is not implemented on this backend.");
            }

            ImGui.BeginDisabled(canSetMousePosition == false);

            ImGui.SeparatorText("Set mouse pos");

            // FIXME: Speed?
            ImGui.DragFloat2("Position", ref setPosition.AsNumerics(), 10, 0, float.PositiveInfinity); ImGui.SameLine();
            if (ImGui.Button("Set position"))
            {
                Toolkit.Mouse.SetPosition((int)setPosition.X, (int)setPosition.Y);
            }

            ImGui.BeginDisabled(supportsRawMouseMotion == false);

            ImGui.SeparatorText("Raw mouse input");

            if (ImGui.Checkbox("Raw input", ref enableRawInput))
            {
                Toolkit.Mouse.EnableRawMouseMotion(Program.Window, enableRawInput);
            }

            ImGui.EndDisabled();

            ImGui.EndDisabled();
        }
    }
}

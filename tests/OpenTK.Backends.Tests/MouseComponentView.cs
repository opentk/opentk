using ImGuiNET;
using OpenTK.Core.Platform;
using OpenTK.Mathematics;
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

        public override bool IsVisible => Program.MouseComponent != null;

        private bool canSetMousePosition;

        private Vector2 setPosition;

        public override void Initialize()
        {
            base.Initialize();

            try { canSetMousePosition = Program.MouseComponent?.CanSetMousePosition ?? false; } catch { canSetMousePosition = false; }
        }

        public override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

            ImGui.SeparatorText("Common properties");

            ImGuiUtils.ReadonlyCheckbox("Can Set Mouse Position", canSetMousePosition);

            ImGui.SeparatorText("Mouse state");

            Program.MouseComponent!.GetPosition(out int x, out int y);
            ImGui.TextUnformatted($"Mouse position: ({x}, {y})");

            try
            {
                Program.MouseComponent.GetMouseState(out MouseState state);

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
                Program.MouseComponent.SetPosition((int)setPosition.X, (int)setPosition.Y);
            }

            ImGui.EndDisabled();
        }
    }
}

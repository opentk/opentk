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

        private WindowHandle? mouseStateWindow;

        public override void Initialize()
        {
            base.Initialize();

            try { canSetMousePosition = Toolkit.Mouse.CanSetMousePosition; } catch { canSetMousePosition = false; }
            try { supportsRawMouseMotion = Toolkit.Mouse.SupportsRawMouseMotion; } catch { supportsRawMouseMotion = false; }

            // FIXME: Make a useful hit test callback as part of this view.
            Toolkit.Window.SetHitTestCallback(Program.Window, HitTest);
        }

        static readonly HitType[] HitTypeValues = 
        [
            HitType.Draggable, 
            HitType.ResizeTopLeft,
            HitType.ResizeTop,
            HitType.ResizeTopRight,
            HitType.ResizeRight,
            HitType.ResizeBottomRight,
            HitType.ResizeBottom,
            HitType.ResizeBottomLeft,
            HitType.ResizeLeft 
        ];
        
        Vector2[] HitTypeAreaPosition = new Vector2[HitTypeValues.Length];
        Vector2[] HitTypeAreaSize = new Vector2[HitTypeValues.Length];

        bool IsActive = false;

        // FIXME: Actually make this usable.
        private HitType HitTest(WindowHandle window, Vector2 point)
        {
            if (IsActive == false)
            {
                return HitType.Default;
            }

            for (int i = 0; i < HitTypeValues.Length; i++)
            {
                Box2 grabArea = new Box2(HitTypeAreaPosition[i], HitTypeAreaPosition[i] + HitTypeAreaSize[i]);
                if (grabArea.ContainsInclusive(point))
                {
                    return HitTypeValues[i];
                }
            }

            return HitType.Default;
        }

        public override void NotifyEnter()
        {
            base.NotifyEnter();

            IsActive = true;
        }

        public override void NotifyLeave()
        {
            base.NotifyLeave();

            IsActive = false;
        }

        public override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

            ImGui.SeparatorText("Common properties");

            ImGuiUtils.ReadonlyCheckbox("Can Set Mouse Position", canSetMousePosition);
            ImGuiUtils.ReadonlyCheckbox("Supports Raw Mouse Motion", supportsRawMouseMotion);

            ImGui.SeparatorText("Global Mouse state");

            Toolkit.Mouse.GetGlobalPosition(out Vector2 gmPos);
            ImGui.TextUnformatted($"Mouse position: ({gmPos.X}, {gmPos.Y})");

            try
            {
                Toolkit.Mouse.GetGlobalMouseState(out MouseState state);

                ImGui.TextUnformatted($"Mouse state:");
                ImGui.TextUnformatted($"  Position: {state.Position}");
                ImGui.TextUnformatted($"  Scroll pos: {state.Scroll}");
                ImGui.TextUnformatted($"  Pressed buttons: {state.PressedButtons}");

                // FIXME: Calcuate a diff against the last mouse state and display that as well.
            }
            catch (NotImplementedException)
            {
                ImGui.TextUnformatted("GetGlobalMouseState() is not implemented on this backend.");
            }

            ImGui.SeparatorText("Window Mouse state");

            ImGuiUtils.WindowCombobox("Window", ref mouseStateWindow);

            Toolkit.Mouse.GetPosition(mouseStateWindow, out Vector2 mPosition);
            ImGui.TextUnformatted($"Mouse position: ({mPosition.X}, {mPosition.Y})");

            try
            {
                Toolkit.Mouse.GetMouseState(mouseStateWindow, out MouseState wstate);

                ImGui.TextUnformatted($"Mouse state:");
                ImGui.TextUnformatted($"  Position: {wstate.Position}");
                ImGui.TextUnformatted($"  Scroll pos: {wstate.Scroll}");
                ImGui.TextUnformatted($"  Pressed buttons: {wstate.PressedButtons}");

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
                Toolkit.Mouse.SetGlobalPosition(setPosition);
            }

            ImGui.EndDisabled();

            ImGui.BeginDisabled(supportsRawMouseMotion == false);

            ImGui.SeparatorText("Raw mouse input");

            if (ImGui.Checkbox("Raw input", ref enableRawInput))
            {
                Toolkit.Mouse.EnableRawMouseMotion(Program.Window, enableRawInput);
            }

            ImGui.EndDisabled();

            ImGui.SeparatorText("Hit tests");

            ImGui.BeginDisabled(true);
            // FIXME: Better layout for this!
            for (int i = 0; i < HitTypeValues.Length; i++)
            {
                HitTypeAreaPosition[i] = ImGui.GetCursorScreenPos().ToOpenTK();
                // FIXME: Fit text!
                HitTypeAreaSize[i] = (100, 50);
                ImGui.Button(HitTypeValues[i].ToString(), HitTypeAreaSize[i].AsNumerics());
                ImGui.SameLine();
                if ((i + 1) % 4 == 0)
                    ImGui.NewLine();
            }
            ImGui.NewLine();
            ImGui.EndDisabled();
        }
    }
}

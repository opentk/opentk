using ImGuiNET;
using OpenTK.Core.Platform;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Backends.Tests
{
    internal class KeyboardComponentView : View
    {
        public override string Title => "Keyboard";

        public override bool IsVisible => Program.KeyboardComponent != null;

        private bool[] KeyboardState = new bool[256];

        private string[] Layouts = new string[0];

        private string TextInput = "";

        public override void Initialize()
        {
            base.Initialize();

            Layouts = Program.KeyboardComponent!.GetAvailableKeyboardLayouts();
        }

        public override void Paint()
        {
            base.Paint();

            ImGui.SeparatorText("Keyboard layout");

            // FIXME: Api for getting input language?
            string layout = Program.KeyboardComponent!.GetActiveKeyboardLayout(Program.Window);
            ImGui.TextUnformatted($"Current keyboard layout: {layout}");

            if (ImGui.BeginListBox("Keyboard layouts"))
            {
                ImGui.BeginDisabled();
                for (int i = 0; i < Layouts.Length; i++)
                {
                    ImGui.Selectable(Layouts[i]);
                }
                ImGui.EndDisabled();
                ImGui.EndListBox();
            }
            
            ImGui.SeparatorText("Keyboard state");

            Program.KeyboardComponent.GetKeyboardState(KeyboardState);

            StringBuilder pressedScancodes = new StringBuilder();
            StringBuilder pressedKeys = new StringBuilder();
            for (int i = 0; i < KeyboardState.Length; i++)
            {
                if (KeyboardState[i] == true)
                {
                    pressedScancodes.Append((Scancode)i);
                    pressedScancodes.Append(", ");

                    Key key = Program.KeyboardComponent.GetKeyFromScancode((Scancode)i);
                    pressedKeys.Append(key);
                    pressedKeys.Append(", ");
                }
            }
            pressedScancodes.Length = Math.Max(pressedScancodes.Length - 2, 0);
            pressedKeys.Length = Math.Max(pressedKeys.Length - 2, 0);

            // Graphical representation of the keyboard.
            ImGui.TextUnformatted($"Scancodes: {pressedScancodes}");
            ImGui.TextUnformatted($"Keys: {pressedKeys}");

            ImGui.SeparatorText("Text input");

            float width = ImGui.GetColumnWidth();
            float height = ImGui.GetContentRegionAvail().Y;

            ImGui.InputTextMultiline("Try typing something...", ref TextInput, 8192, new System.Numerics.Vector2(width, height));
        }
    }
}

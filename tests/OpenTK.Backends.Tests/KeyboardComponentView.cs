using ImGuiNET;
using OpenTK.Platform;
using OpenTK.Graphics.OpenGL;
using OpenTK.Platform.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Intrinsics;
using OpenTK.Mathematics;

namespace OpenTK.Backends.Tests
{
    internal class KeyboardComponentView : View
    {
        public override string Title => "Keyboard";

        public override bool IsVisible => Toolkit.Keyboard != null;

        private bool[] KeyboardState = new bool[256];

        private InputLanguage[] Layouts = new InputLanguage[0];

        private string TextInput = "";

        public override void Initialize()
        {
            base.Initialize();

            try
            { 
                Layouts = Toolkit.Keyboard.GetInstalledInputLanguages();
            }
            catch
            {
                Layouts = new InputLanguage[0];
            }
        }

        public unsafe override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

            ImGui.SeparatorText("Keyboard layout");

            // FIXME: Api for getting input language?
            InputLanguage inputLanguage = Toolkit.Keyboard.GetActiveInputLanguage(Program.Window);
            if (ImGui.CollapsingHeader($"Input language: {inputLanguage.Culture.EnglishName}###input-lang", ImGuiTreeNodeFlags.NoTreePushOnOpen))
            {
                ImGui.Indent();
                ImGui.TextUnformatted($"{"CompareInfo",-31}{inputLanguage.Culture.CompareInfo,-47}");
                ImGui.TextUnformatted($"{"DisplayName",-31}{inputLanguage.Culture.DisplayName,-47}");
                ImGui.TextUnformatted($"{"EnglishName",-31}{inputLanguage.Culture.EnglishName,-47}");
                ImGui.TextUnformatted($"{"IsNeutralCulture",-31}{inputLanguage.Culture.IsNeutralCulture,-47}");
                ImGui.TextUnformatted($"{"IsReadOnly",-31}{inputLanguage.Culture.IsReadOnly,-47}");
                ImGui.TextUnformatted($"{"LCID",-31}{inputLanguage.Culture.LCID,-47}");
                ImGui.TextUnformatted($"{"Name",-31}{inputLanguage.Culture.Name,-47}");
                ImGui.TextUnformatted($"{"NativeName",-31}{inputLanguage.Culture.NativeName,-47}");
                ImGui.TextUnformatted($"{"Parent",-31}{inputLanguage.Culture.Parent,-47}");
                ImGui.TextUnformatted($"{"TextInfo",-31}{inputLanguage.Culture.TextInfo,-47}");
                ImGui.TextUnformatted($"{"ThreeLetterISOLanguageName",-31}{inputLanguage.Culture.ThreeLetterISOLanguageName,-47}");
                ImGui.TextUnformatted($"{"ThreeLetterWindowsLanguageName",-31}{inputLanguage.Culture.ThreeLetterWindowsLanguageName,-47}");
                ImGui.TextUnformatted($"{"TwoLetterISOLanguageName",-31}{inputLanguage.Culture.TwoLetterISOLanguageName,-47}");
                ImGui.Unindent();
            }
            ImGui.TextUnformatted($"Keyboard layout: {inputLanguage.LayoutName}");

            if (ImGui.BeginListBox("Keyboard layouts"))
            {
                ImGui.BeginDisabled();
                for (int i = 0; i < Layouts.Length; i++)
                {
                    ImGui.Selectable($"{Layouts[i]}##{i}");
                }
                ImGui.EndDisabled();
                ImGui.EndListBox();
            }

            if (ImGui.Button("Refresh layouts"))
            {
                Layouts = Toolkit.Keyboard.GetInstalledInputLanguages();
            }
            
            ImGui.SeparatorText("Keyboard state");

            Toolkit.Keyboard.GetKeyboardState(KeyboardState);

            StringBuilder pressedScancodes = new StringBuilder();
            StringBuilder pressedKeys = new StringBuilder();
            for (int i = 0; i < KeyboardState.Length; i++)
            {
                if (KeyboardState[i] == true)
                {
                    pressedScancodes.Append((Scancode)i);
                    pressedScancodes.Append(", ");

                    Key key = Toolkit.Keyboard.GetKeyFromScancode((Scancode)i);
                    pressedKeys.Append(key);
                    pressedKeys.Append(", ");
                }
            }
            pressedScancodes.Length = Math.Max(pressedScancodes.Length - 2, 0);
            pressedKeys.Length = Math.Max(pressedKeys.Length - 2, 0);

            // Graphical representation of the keyboard.
            ImGui.TextUnformatted($"Scancodes: {pressedScancodes}");
            ImGui.TextUnformatted($"Keys: {pressedKeys}");

            KeyModifier modifiers = Toolkit.Keyboard.GetKeyboardModifiers();
            StringBuilder pressedModifiers = new StringBuilder();
            foreach (var modifier in Enum.GetValues<KeyModifier>())
            {
                if (modifier == KeyModifier.None) continue;
                if (modifiers.HasFlag(modifier))
                {
                    pressedModifiers.Append(modifier);
                    pressedModifiers.Append(", ");
                }
            }
            pressedModifiers.Length = Math.Max(pressedModifiers.Length - 2, 0);

            ImGui.TextUnformatted($"Modifiers: {pressedModifiers}");

            ImGui.SeparatorText("Text input");

            float width = ImGui.GetColumnWidth();
            float height = ImGui.GetContentRegionAvail().Y;

            bool edited = ImGui.InputTextMultiline("##keyboard-input-area", ref TextInput, 8192, new System.Numerics.Vector2(width, height));
        }
    }
}

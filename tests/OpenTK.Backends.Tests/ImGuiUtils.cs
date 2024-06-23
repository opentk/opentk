using ImGuiNET;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace OpenTK.Backends.Tests
{
    internal static class ImGuiUtils
    {
        public static ref Vector2 AsOpenTK(ref this System.Numerics.Vector2 vec) => ref Unsafe.As<System.Numerics.Vector2, Vector2>(ref vec);

        public static Vector2 ToOpenTK(this System.Numerics.Vector2 vec) => Unsafe.As<System.Numerics.Vector2, Vector2>(ref vec);

        public static ref System.Numerics.Vector2 AsNumerics(ref this Vector2 vec) => ref Unsafe.As<Vector2, System.Numerics.Vector2>(ref vec);

        public static System.Numerics.Vector2 ToNumerics(this Vector2 vec) => Unsafe.As<Vector2, System.Numerics.Vector2>(ref vec);

        public static void ReadonlyCheckbox(string label, bool value)
        {
            ImGui.BeginDisabled();
            ImGui.Checkbox("", ref value);
            ImGui.EndDisabled();
            ImGui.SameLine();
            ImGui.TextUnformatted(label);
        }

        // FIXME: Maybe make this allocate less?
        public static bool EnumCombo<T>(string label, ref T selected) where T : struct,Enum
        {
            bool selectionChanged = false;
            if (ImGui.BeginCombo(label, selected.ToString()))
            {
                string[] names = Enum.GetNames<T>();
                T[] values = Enum.GetValues<T>();

                for (int i = 0; i < names.Length; i++)
                {
                    bool isSelected = EqualityComparer<T>.Default.Equals(selected, values[i]);

                    if (ImGui.Selectable(names[i], isSelected))
                    {
                        selected = values[i];
                        selectionChanged = true;
                    }

                    if (isSelected) ImGui.SetItemDefaultFocus();
                }

                ImGui.EndCombo();
            }

            return selectionChanged;
        }

        // Helper to display a little (?) mark which shows a tooltip when hovered.
        public static void HelpMarker(string desc)
        {
            ImGui.TextDisabled("(?)");
            if (ImGui.BeginItemTooltip())
            {
                ImGui.PushTextWrapPos(ImGui.GetFontSize()* 35.0f);
                ImGui.TextUnformatted(desc);
                ImGui.PopTextWrapPos();
                ImGui.EndTooltip();
            }
        }

        public static void ReadonlyText(string label, string str)
        {
            ImGui.BeginDisabled(true);
            ImGui.InputText(label, ref str, (uint)(str.Length + 1));
            if (ImGui.IsItemHovered(ImGuiHoveredFlags.ForTooltip | ImGuiHoveredFlags.AllowWhenDisabled))
            {
                ImGui.EndDisabled();
                if (ImGui.BeginTooltip())
                {
                    ImGui.PushTextWrapPos(ImGui.GetFontSize() * 35.0f);
                    ImGui.TextUnformatted(str);
                    ImGui.PopTextWrapPos();
                    ImGui.EndTooltip();
                    ImGui.BeginDisabled(true);
                }
            }
            ImGui.EndDisabled();
        }
    }
}

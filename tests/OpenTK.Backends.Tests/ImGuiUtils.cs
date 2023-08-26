using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Backends.Tests
{
    internal static class ImGuiUtils
    {
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
    }
}

using ImGuiNET;
using OpenTK.Core.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Backends.Tests
{
    internal class IconComponentView : View
    {
        public override string Title => "Icon";

        public override bool IsVisible => Program.IconComponent != null;

        private bool canLoadSystemIcons;

        public SortedDictionary<SystemIconType, IconHandle> SystemIcons = new SortedDictionary<SystemIconType, IconHandle>();

        public override void Initialize()
        {
            base.Initialize();

            try { canLoadSystemIcons = Program.IconComponent!.CanLoadSystemIcons; } catch { canLoadSystemIcons = false; }

            if (canLoadSystemIcons)
            {
                foreach (SystemIconType iconType in Enum.GetValues<SystemIconType>())
                {
                    IconHandle handle = Program.IconComponent!.Create(iconType);
                    SystemIcons.Add(iconType, handle);
                }
            }
        }

        public override void Paint()
        {
            base.Paint();

            ImGui.SeparatorText("Component Properties");
            // FIXME: Separate display if the property threw an exception?
            ImGuiUtils.ReadonlyCheckbox("Can Load System Icons", canLoadSystemIcons);

            ImGui.SeparatorText("System Icons");

            if (canLoadSystemIcons == false)
            {
                ImGui.BeginDisabled();
            }

            // FIXME: Disable all of the buttons if we can set the window icon.

            {
                float maxTextWidth = float.NegativeInfinity;
                foreach (string name in Enum.GetNames<SystemIconType>())
                {
                    float textWidth = ImGui.CalcTextSize(name).X;
                    if (textWidth > maxTextWidth)
                    {
                        maxTextWidth = textWidth;
                    }
                }

                float columnWidth = ImGui.GetColumnWidth();
                // The max text width + some padding.
                float targetSize = maxTextWidth + 10;
                int buttonsPerLine = (int)(columnWidth / targetSize);
                if (buttonsPerLine == 0) buttonsPerLine = 1;
                targetSize = columnWidth / buttonsPerLine;

                // Remove a little size to account for padding
                // FIXME: Get the actual size we need to remove
                targetSize -= 8;

                ImGui.PushStyleVar(ImGuiStyleVar.FrameRounding, 5);
                int i = 0;
                int hoveredIndex = -1;
                foreach (var (type, handle) in SystemIcons)
                {
                    if (i++ % buttonsPerLine != 0) ImGui.SameLine();

                    if (ImGui.Button(type.ToString(), new System.Numerics.Vector2(targetSize, targetSize)))
                    {
                        Program.WindowComp.SetIcon(Program.Window, handle);
                    }

                    // FIXME: Possibly extract the icon data so we can display them here...
                    /*
                    if (ImGui.ImageButton(type.ToString(), , new System.Numerics.Vector2(targetSize, targetSize)))
                    {
                        Program.WindowComp.SetIcon();
                    }
                    */
                }
                ImGui.PopStyleVar();
            }

            if (canLoadSystemIcons == false)
            {
                ImGui.EndDisabled();
            }
        }
    }
}

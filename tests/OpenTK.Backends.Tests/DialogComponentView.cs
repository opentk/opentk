using System;
using System.IO;
using ImGuiNET;
using OpenTK.Core.Platform;

namespace OpenTK.Backends.Tests
{
    public class DialogComponentView : View
    {
        public override string Title => "Dialog";

        public override bool IsVisible => Program.DialogComponent != null;

        bool canTargetDirectories;

        public override void Initialize()
        {
            base.Initialize();

            try { canTargetDirectories = Program.DialogComponent!.CanTargetFolders; } catch { canTargetDirectories = false; }
        }

        bool multiSelect = false;

        public override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

            ImGui.SeparatorText("Component Properties");
            // FIXME: Separate display if the property threw an exception?
            ImGuiUtils.ReadonlyCheckbox("Can Target Directories", canTargetDirectories);

            ImGui.SeparatorText("Open dialog");

            ImGui.Checkbox("Multi-select", ref multiSelect);

            {
                OpenDialogOptions options = multiSelect ? OpenDialogOptions.AllowMultiSelect : 0;

                if (ImGui.Button("Open file"))
                {
                    Program.DialogComponent!.ShowOpenDialog(Program.Window, "Open file (custom title)", Directory.GetCurrentDirectory(), null, options);
                }

                ImGui.BeginDisabled(canTargetDirectories == false);
                if (ImGui.Button("Open directory"))
                {
                    Program.DialogComponent!.ShowOpenDialog(Program.Window, "Open directory (custom title)", Directory.GetCurrentDirectory(), null, options | OpenDialogOptions.SelectDirectory);
                }
                ImGui.EndDisabled();
            }

            ImGui.SeparatorText("Save dialog");

            {
                if (ImGui.Button("Save file"))
                {
                    Program.DialogComponent!.ShowSaveDialog(Program.Window, "Save file (custom title)", Directory.GetCurrentDirectory(), null, 0);
                }
            }
        }
    }
}


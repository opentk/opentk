﻿using System;
using System.Collections.Generic;
using System.IO;
using ImGuiNET;
using OpenTK.Platform;
using OpenTK.Platform.Native;
using OpenTK.Platform.Native.macOS;
using StbImageSharp;

namespace OpenTK.Backends.Tests
{
    public class DialogComponentView : View
    {
        public override string Title => "Dialog";

        public override bool IsVisible => Toolkit.Dialog != null;

        bool canTargetDirectories;

        public override void Initialize()
        {
            base.Initialize();

            try { canTargetDirectories = Toolkit.Dialog.CanTargetFolders; } catch { canTargetDirectories = false; }

            if (Toolkit.Icon is not null)
            {
                ImageResult logoData = ImageResult.FromMemory(Icons.opentk_logo_small_png, ColorComponents.RedGreenBlueAlpha);
                opentkIcon = Toolkit.Icon.Create(logoData.Width, logoData.Height, logoData.Data);
            }
        }

        bool multiSelect = false;
        List<string>? lastSelectedFiles;
        string? saveFileFilename;

        IconHandle? opentkIcon;
        bool reopenRetryDialog = false;
        string? dialogResponseString;
        System.Numerics.Vector4 responseColor;

        bool reopenRetryDialogMacOS = false;
        string? dialogResponseStringMacOS;
        System.Numerics.Vector4 responseColorMacOS;

        static readonly System.Numerics.Vector4 GoodColor = new  System.Numerics.Vector4(0.630f, 0.980f, 0.343f, 1.0f);
        static readonly System.Numerics.Vector4 BadColor = new  System.Numerics.Vector4(1.0f, 0.184f, 0.184f, 1.0f);

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
                    lastSelectedFiles = Toolkit.Dialog.ShowOpenDialog(Program.Window, "Open file (custom title)", Directory.GetCurrentDirectory(), null, options);
                }

                {
                    if (Toolkit.Dialog is MacOSDialogComponent macOSDialog)
                    {
                        ImGui.SameLine();
                        if (ImGui.Button("Open file (no window)"))
                        {
                            lastSelectedFiles = macOSDialog.ShowOpenDialogNoWindow("Open file (custom title)", Directory.GetCurrentDirectory(), null, options);
                        }
                    }
                }

                ImGui.BeginDisabled(canTargetDirectories == false);
                if (ImGui.Button("Open directory"))
                {
                    lastSelectedFiles = Toolkit.Dialog.ShowOpenDialog(Program.Window, "Open directory (custom title)", Directory.GetCurrentDirectory(), null, options | OpenDialogOptions.SelectDirectory);
                }

                {
                    if (Toolkit.Dialog is MacOSDialogComponent macOSDialog)
                    {
                        ImGui.SameLine();
                        if (ImGui.Button("Open directory (no window)"))
                        {
                            lastSelectedFiles = macOSDialog.ShowOpenDialogNoWindow("Open directory (custom title)", Directory.GetCurrentDirectory(), null, options | OpenDialogOptions.SelectDirectory);
                        }
                    }
                }
                ImGui.EndDisabled();

                ImGui.BeginDisabled(true);
                if (ImGui.BeginListBox("Selected files"))
                {
                    for (int i = 0; i < lastSelectedFiles?.Count; i++)
                    {
                        ImGui.Selectable(lastSelectedFiles[i]);
                    }
                    ImGui.EndListBox();
                }
                ImGui.EndDisabled();
            }

            ImGui.SeparatorText("Save dialog");

            {
                if (ImGui.Button("Save file"))
                {
                    saveFileFilename = Toolkit.Dialog.ShowSaveDialog(Program.Window, "Save file (custom title)", Directory.GetCurrentDirectory(), "defaultFileName.txt", null, 0);
                }

                {
                    if (Toolkit.Dialog is MacOSDialogComponent macOSDialog)
                    {
                        ImGui.SameLine();
                        if (ImGui.Button("Open save (no window)"))
                        {
                            saveFileFilename = macOSDialog.ShowSaveDialogNoWindow("Save file (custom title)", Directory.GetCurrentDirectory(), "defaultFileName.txt", null, 0);
                        }
                    }
                }

                ImGui.TextColored(GoodColor, saveFileFilename ?? "");
            }

            ImGui.SeparatorText("Messsage dialogs");

            if (ImGui.Button("Info box"))
            {
                MessageBoxButton button = Toolkit.Dialog.ShowMessageBox(Program.Window, "Information message box", "This is some informational message.", MessageBoxType.Information);
                if (button == MessageBoxButton.Ok)
                {
                    dialogResponseString = "OK!";
                    responseColor = GoodColor;
                }
            }

            ImGui.SameLine();
            if (ImGui.Button("Warning box"))
            {
                MessageBoxButton button = Toolkit.Dialog.ShowMessageBox(Program.Window, "Warning message box!", "This is a warning message.", MessageBoxType.Warning);
                if (button == MessageBoxButton.Ok)
                {
                    dialogResponseString = "OK!";
                    responseColor = GoodColor;
                }
            }

            ImGui.SameLine();
            if (ImGui.Button("Error box"))
            {
                MessageBoxButton button = Toolkit.Dialog.ShowMessageBox(Program.Window, "Error message box!", "This is an error message!", MessageBoxType.Error);
                if (button == MessageBoxButton.Ok)
                {
                    dialogResponseString = "OK!";
                    responseColor = GoodColor;
                }
            }

            ImGui.SameLine();
            if (ImGui.Button("Confirmation box"))
            {
                MessageBoxButton button = Toolkit.Dialog.ShowMessageBox(Program.Window, "Confirm", "Are you sure?", MessageBoxType.Confirmation, opentkIcon);
                if (button == MessageBoxButton.Yes)
                {
                    dialogResponseString = "Pressed Yes!";
                    responseColor = GoodColor;
                }
                else if (button == MessageBoxButton.No)
                {
                    dialogResponseString = "Pressed No!";
                    responseColor = BadColor;
                }
                else if (button == MessageBoxButton.Cancel)
                {
                    dialogResponseString = "Pressed Cancel.";
                    responseColor = BadColor;
                }
            }

            ImGui.SameLine();
            if (ImGui.Button("Retry box") || reopenRetryDialog)
            {
                MessageBoxButton button = Toolkit.Dialog.ShowMessageBox(Program.Window, "Retry?", "Should we retry?", MessageBoxType.Retry);
                if (button == MessageBoxButton.Retry)
                {
                    reopenRetryDialog = true;
                }
                else
                {
                    reopenRetryDialog = false;
                }
            }

            if (dialogResponseString != null)
            {
                ImGui.TextColored(responseColor, dialogResponseString);
            }

            {
                if (Toolkit.Dialog is Platform.Native.macOS.MacOSDialogComponent macOSDialog)
                {
                    ImGui.SeparatorText("Message dialogs (no window)");

                    ImGui.PushID("NoWindow");

                    if (ImGui.Button("Info box"))
                    {
                        MessageBoxButton button = macOSDialog.ShowMessageBoxNoWindow("Information message box", "This is some informational message.", MessageBoxType.Information);
                        if (button == MessageBoxButton.Ok)
                        {
                            dialogResponseStringMacOS = "OK!";
                            responseColorMacOS = GoodColor;
                        }
                    }

                    ImGui.SameLine();
                    if (ImGui.Button("Warning box"))
                    {
                        MessageBoxButton button = macOSDialog.ShowMessageBoxNoWindow("Warning message box!", "This is a warning message.", MessageBoxType.Warning);
                        if (button == MessageBoxButton.Ok)
                        {
                            dialogResponseStringMacOS = "OK!";
                            responseColorMacOS = GoodColor;
                        }
                    }

                    ImGui.SameLine();
                    if (ImGui.Button("Error box"))
                    {
                        MessageBoxButton button = macOSDialog.ShowMessageBoxNoWindow("Error message box!", "This is an error message!", MessageBoxType.Error);
                        if (button == MessageBoxButton.Ok)
                        {
                            dialogResponseStringMacOS = "OK!";
                            responseColorMacOS = GoodColor;
                        }
                    }

                    ImGui.SameLine();
                    if (ImGui.Button("Confirmation box"))
                    {
                        MessageBoxButton button = macOSDialog.ShowMessageBoxNoWindow("Confirm", "Are you sure?", MessageBoxType.Confirmation, opentkIcon);
                        if (button == MessageBoxButton.Yes)
                        {
                            dialogResponseStringMacOS = "Pressed Yes!";
                            responseColorMacOS = GoodColor;
                        }
                        else if (button == MessageBoxButton.No)
                        {
                            dialogResponseStringMacOS = "Pressed No!";
                            responseColorMacOS = BadColor;
                        }
                        else if (button == MessageBoxButton.Cancel)
                        {
                            dialogResponseStringMacOS = "Pressed Cancel.";
                            responseColorMacOS = BadColor;
                        }
                    }

                    ImGui.SameLine();
                    if (ImGui.Button("Retry box") || reopenRetryDialogMacOS)
                    {
                        MessageBoxButton button = macOSDialog.ShowMessageBoxNoWindow("Retry?", "Should we retry?", MessageBoxType.Retry);
                        if (button == MessageBoxButton.Retry)
                        {
                            reopenRetryDialogMacOS = true;
                        }
                        else
                        {
                            reopenRetryDialogMacOS = false;
                        }
                    }

                    if (dialogResponseStringMacOS != null)
                    {
                        ImGui.TextColored(responseColorMacOS, dialogResponseStringMacOS);
                    }

                    ImGui.PopID();
                }
            }
        }
    }
}


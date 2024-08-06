using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Threading;
using ImGuiNET;
using OpenTK.Platform;
using OpenTK.Core.Utility;
using OpenTK.Platform.Native;

namespace OpenTK.Backends.Tests
{
    /// <summary>
    /// The view class for the first overview tab.
    /// </summary>
    public class OverviewView : View
    {
        /// <inheritdoc/>
        public override string Title => "Overview";

        readonly PalComponents[] Components = Enum.GetValues<PalComponents>();
        readonly List<string> log = new List<string>();
        string logPath = Path.Combine(Environment.CurrentDirectory, "log.txt");

        const ImGuiTreeNodeFlags TREE_NODE_FLAGS = ImGuiTreeNodeFlags.Framed | ImGuiTreeNodeFlags.DefaultOpen;

        /// <summary>
        /// Create a new instance of OverviewView.
        /// </summary>
        public OverviewView()
        {
            if (Program.Logger is ModularLogger logger)
            {
                logger.OnLog += OnLog;
            }
        }

        private void OnLog(string str, LogLevel level, string filePath, int lineNumber, string member)
        {
            log.Add($"[{DateTime.Now:HH:mm:ss.fff} {level}] {member} {Path.GetFileName(filePath)}:{lineNumber} {str}");
        }

        // FIXME: Add some other diagnostics data such as OS version, Arch, 64bit?, GPU vendor, etc.

        /// <inheritdoc/>
        public override void Paint(double deltaTime)
        {
            ImGui.Text("This is the OpenTK PAL2 driver test suite.");
            ImGui.BulletText("Click on each tab to view details related to that driver. ");
            ImGui.BulletText("Use the command line argument to specify which drivers to load manually.");
            ImGui.BulletText("Alternatively, drag the config file on the application.");

            bool preferSDL2 = PlatformComponents.PreferSDL2;
            ImGuiUtils.ReadonlyCheckbox("Default Prefers SDL2", preferSDL2);

            bool preferANGLE = PlatformComponents.PreferANGLE;
            ImGuiUtils.ReadonlyCheckbox("Default Prefers ANGLE", preferANGLE);

            if (ImGui.BeginTable("overview_table_id", 3, ImGuiTableFlags.Borders))
            {
                ImGui.TableSetupColumn("Component", ImGuiTableColumnFlags.WidthFixed);
                ImGui.TableSetupColumn("Driver Name", ImGuiTableColumnFlags.WidthFixed);
                ImGui.TableSetupColumn("Class", ImGuiTableColumnFlags.WidthStretch);
                ImGui.TableHeadersRow();

                foreach (PalComponents component in Components)
                {
                    IPalComponent? driver = Program.GetComponent(component);

                    if (driver == null)
                        continue;

                    ImGui.TableNextRow();
                    ImGui.TableNextColumn(); ImGui.TextUnformatted(component.ToString());
                    ImGui.TableNextColumn(); ImGui.TextUnformatted(driver.Name);
                    ImGui.TableNextColumn(); ImGui.TextUnformatted(driver.GetType().FullName);
                }

                ImGui.EndTable();
            }

            ImGui.Checkbox("Wait for events", ref Program.WaitForEvents);

            if (ImGui.TreeNodeEx("Log", TREE_NODE_FLAGS))
            {
                ImGui.InputText("Path", ref logPath, 4096); // Arbitrary max length.
                if (ImGui.BeginItemTooltip())
                {
                    ImGui.TextUnformatted(logPath);
                    ImGui.EndTooltip();
                }

                if (Toolkit.Dialog != null)
                {
                    ImGui.SameLine();
                    if (ImGui.Button("Browse..."))
                    {

                        DialogFileFilter[] filter;
                        if (OperatingSystem.IsMacOS())
                        {
                            // On windows and linux it's nice to be able to switch to a "All files" filter so you can see all files that are in a folder.
                            // But on macOS adding this filter gives zero indication of the supported files so we would ideally avoid adding the * filter on macOS.
                            // - Noggin_bops 2024-07-22
                            filter = new DialogFileFilter[] { new("Text documents (*.txt)", "txt") };
                        }
                        else
                        {
                            // The "text" filter here is only to test the multi filter feature.
                            // - Noggin_bops 2024-07-22
                            filter = new DialogFileFilter[] { new("Text documents (*.txt;*.text)", "txt;text"), new("All files (*.*)", "*") };
                        }

                        List<string>? location = Toolkit.Dialog.ShowOpenDialog(Program.Window, "Choose file...", Directory.GetCurrentDirectory(), filter, 0);
                        if (location != null)
                        {
                            Debug.Assert(location.Count <= 1);

                            logPath = location[0];
                        }
                    }

                    ImGui.SameLine();
                    if (ImGui.Button("Save"))
                    {
                        DialogFileFilter[] filter;
                        if (OperatingSystem.IsMacOS())
                        {
                            // On windows and linux it's nice to be able to switch to a "All files" filter so you can see all files that are in a folder.
                            // But on macOS adding this filter gives zero indication of the supported files so we would ideally avoid adding the * filter on macOS.
                            // - Noggin_bops 2024-07-22
                            filter = new DialogFileFilter[] { new("Text documents (*.txt)", "txt") };
                        }
                        else
                        {
                            // The "text" filter here is only to test the multi filter feature.
                            // - Noggin_bops 2024-07-22
                            filter = new DialogFileFilter[] { new("Text documents (*.txt;*.text)", "txt;text"), new("All files (*.*)", "*") };
                        }

                        string? location = Toolkit.Dialog.ShowSaveDialog(Program.Window, "Save", Directory.GetCurrentDirectory(), filter, 0);
                        if (location != null)
                        {
                            if (Path.HasExtension(location) == false)
                            {
                                location = location + ".txt";
                            }
                            logPath = location;

                            using Stream str = File.OpenWrite(logPath);
                            using StreamWriter writer = new StreamWriter(str);

                            foreach (string line in log)
                            {
                                writer.WriteLine(line);
                            }
                        }
                    }
                }
                else
                {
                    ImGui.SameLine();
                    if (ImGui.Button("Save"))
                    {
                        try
                        {
                            using Stream str = File.OpenWrite(logPath);
                            using StreamWriter writer = new StreamWriter(str);

                            foreach (string line in log)
                            {
                                writer.WriteLine(line);
                            }
                        }
                        catch (Exception ex)
                        {
                            Program.Logger.LogError($"Could not save log file: {ex}");
                        }
                    }
                }

                // FIXME: This is a pathethic slow excuse of a log displayer.
                //              1. The normal imgui demo uses a clipper, but this seems unimplemented in ImGui.NET
                //              2. It uses ImGui.TextWrapped, which expects a format string. Couldn't figure out how
                //                 how to make it unformatted since the C ... parameter is unimplemented.
                //                      ImGui::TextWrappped("%s", line);

                ImGui.SetNextWindowSizeConstraints(new Vector2(0, ImGui.GetTextLineHeightWithSpacing() * 4), new Vector2(float.PositiveInfinity, float.PositiveInfinity));
                if (ImGui.BeginChild("overview_log_table", new Vector2(0, 0 /* ImGui.GetTextLineHeightWithSpacing() * 4 */), ImGuiChildFlags.Border, ImGuiWindowFlags.AlwaysVerticalScrollbar))
                {
                    if (log.Count == 0)
                    {
                        ImGui.TextDisabled("There is no log to display.");
                    }
                    else
                    {
                        foreach (string line in log)
                        {
                            ImGui.TextWrapped(line);
                        }
                    }

                    if (ImGui.GetScrollY() >= ImGui.GetScrollMaxY())
                        ImGui.SetScrollHereY(1.0f);
                }
                ImGui.EndChild();

                ImGui.TreePop();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using ImGuiNET;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;

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

        /// <inheritdoc/>
        public override void Paint()
        {
            ImGui.Text("This is the OpenTK PAL2 driver test suite.");
            ImGui.BulletText("Click on each tab to view details related to that driver. ");
            ImGui.BulletText("Use the command line argument to specify which drivers to load manually.");
            ImGui.BulletText("Alternatively, drag the config file on the application.");

            bool preferSDL2 = BackendsConfig.Singleton.PreferSDL2;
            ImGuiUtils.ReadonlyCheckbox("Default Prefers SDL2", preferSDL2);

            if (ImGui.BeginTable("overview_table_id", 4, ImGuiTableFlags.Borders))
            {
                ImGui.TableSetupColumn("Default", ImGuiTableColumnFlags.WidthFixed);
                ImGui.TableSetupColumn("Component", ImGuiTableColumnFlags.WidthFixed);
                ImGui.TableSetupColumn("Driver Name", ImGuiTableColumnFlags.WidthFixed);
                ImGui.TableSetupColumn("Class", ImGuiTableColumnFlags.WidthStretch);
                ImGui.TableHeadersRow();

                foreach (PalComponents component in Components)
                {
                    IPalComponent? driver = Program.GetComponent(component);

                    if (driver == null)
                        continue;

                    bool isDefault = BackendsConfig.Singleton[component] == null;
                    ImGui.TableNextRow();
                    ImGui.TableNextColumn(); ImGui.Checkbox("", ref isDefault);
                    ImGui.TableNextColumn(); ImGui.TextUnformatted(component.ToString());
                    ImGui.TableNextColumn(); ImGui.TextUnformatted(driver.Name);
                    ImGui.TableNextColumn(); ImGui.TextUnformatted(driver.GetType().FullName);
                }

                ImGui.EndTable();
            }


            if (ImGui.TreeNodeEx("Extra Assemblies", TREE_NODE_FLAGS))
            {
                if (BackendsConfig.ExtraAssembliesLoaded)
                {
                    ImGui.Text("Also, the following extra assemblies were loaded:");
                    foreach (var name in BackendsConfig.Singleton.ExtraAssemblies)
                    {
                        ImGui.BulletText(name);
                    }
                }
                else
                {
                    ImGui.Text("No extra assemblies have been loaded.");
                }

                ImGui.TreePop();
            }

            if (ImGui.TreeNodeEx("Log", TREE_NODE_FLAGS))
            {
                ImGui.InputText("Path", ref logPath, 4096); // Arbitrary max length.
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

                // FIXME: This is a pathethic slow excuse of a log displayer.
                //              1. The normal imgui demo uses a clipper, but this seems unimplemented in ImGui.NET
                //              2. It uses ImGui.TextWrapped, which expects a format string. Couldn't figure out how
                //                 how to make it unformatted since the C ... parameter is unimplemented.
                //                      ImGui::TextWrappped("%s", line);

                if (ImGui.BeginChild("overview_log_table", Vector2.Zero, true, ImGuiWindowFlags.AlwaysVerticalScrollbar))
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

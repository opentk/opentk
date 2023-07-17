using System;
using ImGuiNET;
using OpenTK.Core.Platform;

namespace OpenTK.Backends.Tests
{
    public class OverviewView : View
    {
        public override string Title => "Overview";

        readonly PalComponents[] Components = Enum.GetValues<PalComponents>();

        public override void Paint()
        {
            ImGui.Text("This is the OpenTK PAL2 driver test suite.");
            ImGui.BulletText("Click on each tab to view details related to that driver. ");
            ImGui.BulletText("Use the command line argument to specify which drivers to load manually.");
            ImGui.BulletText("Alternatively, drag the config file on the application.");

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
        }
    }
}
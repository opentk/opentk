using ImGuiNET;
using OpenTK.Core.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Backends.Tests
{
    internal class ShellComponentView : View
    {
        public override string Title => "Shell";

        public override bool IsVisible => Program.ShellComponent != null;

        static readonly AppTheme[] Themes = Enum.GetValues<AppTheme>();

        public override void Initialize()
        {
            base.Initialize();
        }

        bool useImmersiveDarkMode = false;

        public override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

            ImGui.SeparatorText("Screen saver");

            if (ImGui.Button("Disable"))
                Program.ShellComponent!.AllowScreenSaver(false);
            ImGui.SameLine();
            if (ImGui.Button("Enable"))
                Program.ShellComponent!.AllowScreenSaver(true);

            BatteryStatus status = Program.ShellComponent!.GetBatteryInfo(out BatteryInfo batteryInfo);
            string statusStr = status switch
            {
                BatteryStatus.Unknown => "unknown",
                BatteryStatus.NoSystemBattery => "no system battery",
                BatteryStatus.HasSystemBattery => "has battery",
                _ => "unknown",
            };
            ImGui.SeparatorText($"Battery Status ({statusStr})");

            ImGui.BeginDisabled();

            ImGui.Checkbox("On AC", ref batteryInfo.OnAC);
            ImGui.Checkbox("Charging", ref batteryInfo.Charging);
            ImGui.Checkbox("Power saver", ref batteryInfo.PowerSaver);

            {
                string unknown = "unknown";
                float percent = batteryInfo.BatteryPercent ?? 0;
                if (batteryInfo.BatteryPercent != null)
                    ImGui.InputFloat("Battery percent", ref percent);
                else
                    ImGui.InputText("Battery percent", ref unknown, (uint)unknown.Length);
                ImGui.SameLine();
                ImGui.EndDisabled();
                ImGuiUtils.HelpMarker("How many percent of full charge is left.");
                ImGui.BeginDisabled();
            }

            {
                float time = batteryInfo.BatteryTime ?? float.NaN;
                ImGui.InputFloat("Battery time", ref time);
                ImGui.SameLine();
                ImGui.EndDisabled();
                ImGuiUtils.HelpMarker("An estimate in seconds of how much battery charge is left.");
                ImGui.BeginDisabled();
            }

            ImGui.EndDisabled();

            ImGui.SeparatorText("Theme");

            ThemeInfo themeInfo = Program.ShellComponent.GetPreferredTheme();

            ImGui.BeginDisabled();

            // FIXME: Get the padding from somewhere?
            if (ImGui.BeginListBox("Theme", new System.Numerics.Vector2(ImGui.CalcItemWidth(), ImGui.GetTextLineHeight() * Themes.Length + 15)))
            {
                foreach (var theme in Themes)
                {
                    bool isSelected = theme == themeInfo.Theme;
                    ImGui.Selectable($"{theme}", isSelected);
                }

                ImGui.EndListBox();
            }

            ImGui.Checkbox("High contrast", ref themeInfo.HighContrast);

            ImGui.EndDisabled();

            ImGui.SeparatorText("System Resources");

            SystemMemoryInfo memInfo = Program.ShellComponent.GetSystemMemoryInformation();

            // FIXME: Display in a better way
            ImGui.Text($"System memory: {GetHumanReadable(memInfo.TotalPhysicalMemory)}");

            ImGui.Text($"Available system memory: {GetHumanReadable(memInfo.AvailablePhysicalMemory)}");

            if (ImGui.BeginTabBar("platforms"))
            {
                if (Program.ShellComponent is Platform.Native.Windows.ShellComponent winShell)
                {
                    if (ImGui.BeginTabItem("Win32"))
                    {
                        if (ImGui.Checkbox("Use Immeresive Dark Mode", ref useImmersiveDarkMode))
                        {
                            // FIXME: It seems like the window titlebar doesn't get changed
                            // immediately, you need to minimize and restore the window for this to work...
                            winShell.SetImmersiveDarkMode(Program.Window, useImmersiveDarkMode);
                        }

                        System.Numerics.Vector3 textColor = new System.Numerics.Vector3(1, 1, 1);
                        if (ImGui.ColorEdit3("Caption Text Color", ref textColor))
                        {
                            //winShell.SetCaptionTextColor(Program.Window, new Color3<Rgb>(textColor.X, textColor.Y, textColor.Z));
                        }

                        System.Numerics.Vector3 captionColor = new System.Numerics.Vector3(1, 1, 1);
                        if (ImGui.ColorEdit3("Caption Color", ref captionColor))
                        {
                            //winShell.SetCaptionColor(Program.Window, new Color3<Rgb>(captionColor.X, captionColor.Y, captionColor.Z));
                        }

                        ImGui.EndTabItem();
                    }
                }
                ImGui.EndTabBar();
            }

            static string GetHumanReadable(long bytes)
            {
                if (bytes > 1_024 * 1_024 * 1_024)
                {
                    return $"{bytes / (float)(1_024 * 1_024 * 1_024):0.0} Gb";
                }
                else if (bytes > 1_024 * 1_024)
                {
                    return $"{bytes / (float)(1_024 * 1_024):0.0} Mb";
                }
                else if (bytes > 1_024)
                {
                    return $"{bytes / (float)1_000:0.0} Kb";
                }
                else
                {
                    return $"{bytes} b";
                }
            }
        }
    }
}

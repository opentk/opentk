using ImGuiNET;
using OpenTK.Platform;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
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

        public override bool IsVisible => Toolkit.Shell != null;

        static readonly AppTheme[] Themes = Enum.GetValues<AppTheme>();

        System.Numerics.Vector3 textColor = new System.Numerics.Vector3(1, 1, 1);
        System.Numerics.Vector3 captionColor = new System.Numerics.Vector3(1, 1, 1);

        public override void Initialize()
        {
            base.Initialize();
        }

        bool useImmersiveDarkMode = false;

        int cornerPreferenceIndex = 0;
        Platform.Native.Windows.ShellComponent.ProgressMode win32ProgressMode = Platform.Native.Windows.ShellComponent.ProgressMode.NoProgress;
        Platform.Native.macOS.MacOSShellComponent.ProgressMode macOSProgressMode = Platform.Native.macOS.MacOSShellComponent.ProgressMode.NoProgress;
        
        float progressCompletion = 0;

        readonly static Platform.Native.Windows.ShellComponent.CornerPreference[] CornerPreferences = Enum.GetValues<Platform.Native.Windows.ShellComponent.CornerPreference>();
        readonly static string[] CornerPreferenceNames = Enum.GetNames<Platform.Native.Windows.ShellComponent.CornerPreference>();

        bool UseCustomReason = false;
        string SSDisableReason = "";

        public override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

            ImGui.SeparatorText("Screen saver");

            bool ssAllowed = Toolkit.Shell.IsScreenSaverAllowed();
            if (ImGui.Checkbox("Screen saver allowed", ref ssAllowed))
            {
                Toolkit.Shell.AllowScreenSaver(ssAllowed, UseCustomReason ? SSDisableReason : null);
            }

            ImGui.Checkbox("Custom disable reason", ref UseCustomReason);
            ImGui.BeginDisabled(UseCustomReason == false);
            ImGui.InputText("Screen saver disable reason", ref SSDisableReason, 128);
            ImGui.EndDisabled();

            BatteryStatus status = Toolkit.Shell.GetBatteryInfo(out BatteryInfo batteryInfo);
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

            ThemeInfo themeInfo = Toolkit.Shell.GetPreferredTheme();

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

            SystemMemoryInfo memInfo = Toolkit.Shell.GetSystemMemoryInformation();

            // FIXME: Display in a better way
            ImGui.Text($"System memory: {GetHumanReadable(memInfo.TotalPhysicalMemory)}");

            ImGui.Text($"Available system memory: {GetHumanReadable(memInfo.AvailablePhysicalMemory)}");

            if (ImGui.BeginTabBar("platforms"))
            {
                if (Toolkit.Shell is Platform.Native.Windows.ShellComponent winShell)
                {
                    if (ImGui.BeginTabItem("Win32"))
                    {
                        if (ImGui.Checkbox("Use Immeresive Dark Mode", ref useImmersiveDarkMode))
                        {
                            winShell.SetImmersiveDarkMode(Program.Window, useImmersiveDarkMode);
                        }

                        if (ImGui.ColorEdit3("Caption Text Color", ref textColor))
                        {
                            winShell.SetCaptionTextColor(Program.Window, new Color3<Rgb>(textColor.X, textColor.Y, textColor.Z));
                        }

                        if (ImGui.ColorEdit3("Caption Color", ref captionColor))
                        {
                            winShell.SetCaptionColor(Program.Window, new Color3<Rgb>(captionColor.X, captionColor.Y, captionColor.Z));
                        }

                        ImGui.AlignTextToFramePadding();
                        ImGui.TextUnformatted("Window Corner Preference"); ImGui.SameLine();
                        ImGui.Combo("##cornerPreference", ref cornerPreferenceIndex, CornerPreferenceNames, CornerPreferenceNames.Length); ImGui.SameLine();
                        if (ImGui.Button("Apply##cornerPreference"))
                        {
                            winShell.SetWindowCornerPreference(Program.Window, CornerPreferences[cornerPreferenceIndex]);
                            Program.Logger.LogInfo($"ShellComponent.SetWindowCornerPreference({CornerPreferenceNames[cornerPreferenceIndex]})");
                        }

                        bool updateProgress = false;
                        updateProgress |= ImGuiUtils.EnumCombo("Progress mode", ref win32ProgressMode);
                        updateProgress |= ImGui.SliderFloat("Progess completion", ref progressCompletion, 0, 1);
                        if (updateProgress)
                        {
                            winShell.SetProgressStatus(Program.Window, win32ProgressMode, progressCompletion);
                        }

                        ImGui.EndTabItem();
                    }
                }
                else if (Toolkit.Shell is Platform.Native.macOS.MacOSShellComponent macosShell)
                {
                    if (ImGui.BeginTabItem("macOS"))
                    {
                        bool updateProgress = false;
                        updateProgress |= ImGuiUtils.EnumCombo("Progress mode", ref macOSProgressMode);
                        updateProgress |= ImGui.SliderFloat("Progess completion", ref progressCompletion, 0, 1);
                        if (updateProgress)
                        {
                            macosShell.SetProgressStatus(Program.Window, macOSProgressMode, progressCompletion);
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

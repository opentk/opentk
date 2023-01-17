using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.X11
{
    public class X11ShellComponent : IShellComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(X11ShellComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Shell;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if ((which & ~Provides) != 0)
            {
                throw new PalException(this, $"Cannot initialize unimplemented components {which & ~Provides}.");
            }
        }

        /// <inheritdoc/>
        public void AllowScreenSaver(bool allow)
        {
            // Seems like we can either use some dbus functions or
            // we can use X11 Screen Saver Extension to turn it off.
            // https://github.com/libsdl-org/SDL/blob/fde78d12f247a776b52b007479e5274d4bd4e3fe/src/video/x11/SDL_x11events.c#L1730


            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public BatteryStatus GetBatteryInfo(out BatteryInfo batteryInfo)
        {
            bool setAC = false;
            bool onAC = false;
            foreach (string dir in Directory.EnumerateDirectories("/sys/class/power_supply/"))
            {
                if (Path.GetFileName(dir)?.StartsWith("AC") ?? false)
                {
                    string online = File.ReadAllText(Path.Combine(dir, "online"));
                    // FIXME: Will this always be "1\n" if we are on AC?
                    onAC = online == "1\n";

                    setAC = true;
                    break;
                }
            }

            bool setBattery = false;
            bool charging = false;
            bool powerSaver = false;
            float? batteryPercent = null;
            float? batteryTime = null;
            foreach (string dir in Directory.EnumerateDirectories("/sys/class/power_supply/"))
            {
                if (Path.GetFileName(dir)?.StartsWith("BAT") ?? false)
                {
                    // FIXME: "evergy_now" and "energy_full" might not always be available.
                    // We could also look at using "charge_now" and "charge_full"
                    bool has_energy_now = int.TryParse(File.ReadAllText(Path.Combine(dir, "energy_now")), out int energy_now);
                    bool has_energy_full = int.TryParse(File.ReadAllText(Path.Combine(dir, "energy_full")), out int energy_full);

                    if (has_energy_now && has_energy_full && energy_now != -1 && energy_full != -1)
                    {
                        batteryPercent = (energy_now / (float)energy_full) * 100;
                    }
                    else if (int.TryParse(File.ReadAllText(Path.Combine(dir, "capacity")), out int capacity) && capacity != -1)
                    {
                        batteryPercent = capacity;
                    }

                    // FIXME: For now we don't provide this on linux.
                    batteryTime = null;

                    string status = File.ReadAllText(Path.Combine(dir, "status"));
                    charging = (status == "Charging\n");

                    // FIXMe: For now we don't report power saver info on linux.
                    powerSaver = false;

                    setBattery = true;
                    break;
                }
            }

            if (setBattery == false)
            {
                batteryInfo = default;
                return BatteryStatus.NoSystemBattery;
            }
            else
            {
                batteryInfo.OnAC = onAC;
                batteryInfo.Charging = charging;
                batteryInfo.PowerSaver = powerSaver;
                batteryInfo.BatteryPercent = batteryPercent;
                batteryInfo.BatteryTime = batteryTime;
                return BatteryStatus.HasSystemBattery;
            }
        }

        // FIXME: Maybe add a platform specific API for getting a theme name.
        public AppTheme GetPreferredTheme()
        {
            // Seems like we might be able to use xsettings to get some kind of data about preferred theme.
            // https://wiki.archlinux.org/title/Dark_mode_switching
            // https://specifications.freedesktop.org/xsettings-spec/xsettings-latest.html

            throw new NotImplementedException();
        }
    }
}

using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
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
            // https://github.com/libsdl-org/SDLLib/blob/fde78d12f247a776b52b007479e5274d4bd4e3fe/src/video/x11/SDL_x11events.c#L1730


            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public BatteryStatus GetBatteryInfo(out BatteryInfo batteryInfo)
        {
            bool setAC = false;
            bool onAC = false;
            foreach (string dir in Directory.EnumerateDirectories("/sys/class/power_supply/"))
            {
                string? type = ReadPowerFile(dir, "type");
                if (type == "Mains\n")
                {
                    string? online = ReadPowerFile(dir, "online");
                    onAC = (online == "1\n");
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
                string? type = ReadPowerFile(dir, "type");
                if (type != null && type == "Battery\n")
                {
                    // This is a battery!
                    Console.WriteLine($"{dir} is a battery.");

                    // We don't care about device batteries.
                    string? scope = ReadPowerFile(dir, "scope");
                    if (scope != null && scope == "Device\n")
                        continue;

                    setBattery = true;

                    string? status = ReadPowerFile(dir, "status");
                    switch (status)
                    {
                        case "Charging\n":
                            charging = true;
                            break;
                        case "Discharging\n":
                            break;
                        case "Not charging\n":
                            break;
                        case "Full\n":
                            break;
                        default: 
                            // We couldn't read the status or the status is not one that we recognize.
                            break;
                    }

                    string? capacityStr = ReadPowerFile(dir, "capacity");
                    if (int.TryParse(capacityStr, out int capacity))
                    {
                        // FIXME: Maybe clamp to 0% - 100%?
                        batteryPercent = capacity;
                    }

                    string? energyNowStr = ReadPowerFile(dir, "energy_now");
                    string? energyFullStr = ReadPowerFile(dir, "energy_full");
                    if (energyNowStr != null && energyFullStr != null &&
                        int.TryParse(energyNowStr, out int energyNow) &&
                        int.TryParse(energyFullStr, out int energyFull))
                    {
                        batteryPercent = (energyNow / (float)energyFull) * 100;
                    }

                    string? chargeNowStr = ReadPowerFile(dir, "charge_now");
                    string? chargeFullStr = ReadPowerFile(dir, "charge_full");
                    if (chargeNowStr != null && chargeFullStr != null &&
                        int.TryParse(chargeNowStr, out int chargeNow) &&
                        int.TryParse(chargeFullStr, out int chargeFull))
                    {
                        batteryPercent = (chargeNow / (float)chargeFull) * 100;
                    }

                    string? timeToEmptyNowStr = ReadPowerFile(dir, "time_to_empty_now");
                    if (timeToEmptyNowStr != null && 
                        int.TryParse(timeToEmptyNowStr, out int timeToEmptyNow))
                    {
                        batteryTime = timeToEmptyNow;
                    }

                    // FIXME: In the case of multiple batteries, pick the highest time to empty
                    // And highest battery percentage?

                    // FIXME: For now we don't report power saver info on linux.
                    powerSaver = false;

                    // FIXME: Consider the case of multiple batteries.
                    setBattery = true;
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

            static string? ReadPowerFile(string name, string key)
            {
                try 
                {
                    return File.ReadAllText(Path.Combine("/sys/class/power_supply/",  name, key));
                }
                // FIXME: Are there some exceptions we should let through?
                catch
                {
                    return null;
                }
            }
        }

        /// <inheritdoc />
        // FIXME: Maybe add a platform specific API for getting a theme name.
        public ThemeInfo GetPreferredTheme()
        {
            // Seems like we might be able to use xsettings to get some kind of data about preferred theme.
            // https://wiki.archlinux.org/title/Dark_mode_switching
            // https://specifications.freedesktop.org/xsettings-spec/xsettings-latest.html

            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public unsafe SystemMemoryInfo GetSystemMemoryInformation()
        {
            int result = Sysinfo.sysinfo(out Sysinfo.sysinfo_struct sysInfo);
            if (result < 0)
            {
                int error = Marshal.GetLastPInvokeError();
                string? errorStr = Marshal.PtrToStringUTF8((IntPtr)Sysinfo.strerror(error));

                Logger?.LogError($"sysinfo() failed: '{errorStr}' (0x{error:X})");
                return default;
            }

            SystemMemoryInfo info;

            info.TotalPhysicalMemory = (long)sysInfo.totalram;
            info.AvailablePhysicalMemory = (long)sysInfo.freeram;

            return info;
        }
    }
}

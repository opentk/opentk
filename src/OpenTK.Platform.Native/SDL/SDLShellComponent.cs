using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.SDL.SDL;

namespace OpenTK.Platform.Native.SDL
{
    public class SDLShellComponent : IShellComponent
    {
        public string Name => nameof(SDLShellComponent);

        public PalComponents Provides => PalComponents.Shell;

        public ILogger? Logger { get; set; }

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Shell)
            {
                throw new PalException(this, "SDLShellComponent can only initialize the Shell component.");
            }
        }

        public void AllowScreenSaver(bool allow)
        {
            if (allow)
            {
                SDL_EnableScreenSaver();
            }
            else
            {
                SDL_DisableScreenSaver();
            }
        }

        public BatteryStatus GetBatteryInfo(out BatteryInfo batteryInfo)
        {
            SDL_PowerState state = SDL_GetPowerInfo(out int seconds, out int percent);

            batteryInfo.BatteryTime = seconds == -1 ? null : seconds;
            batteryInfo.BatteryPercent = percent == -1 ? null : percent;

            batteryInfo.OnAC =
                state == SDL_PowerState.SDL_POWERSTATE_NO_BATTERY ||
                state == SDL_PowerState.SDL_POWERSTATE_CHARGING ||
                state == SDL_PowerState.SDL_POWERSTATE_CHARGED;

            batteryInfo.Charging =
                state == SDL_PowerState.SDL_POWERSTATE_CHARGING ||
                state == SDL_PowerState.SDL_POWERSTATE_CHARGED;

            // FIXME: Can we know the power saver status??
            batteryInfo.PowerSaver = false;

            switch (state)
            {
                case SDL_PowerState.SDL_POWERSTATE_UNKNOWN:
                    return BatteryStatus.Unknown;
                case SDL_PowerState.SDL_POWERSTATE_ON_BATTERY:
                case SDL_PowerState.SDL_POWERSTATE_CHARGING:
                case SDL_PowerState.SDL_POWERSTATE_CHARGED:
                    return BatteryStatus.HasSystemBattery;
                case SDL_PowerState.SDL_POWERSTATE_NO_BATTERY:
                    return BatteryStatus.NoSystemBattery;
                default:
                    Logger?.LogError($"Unknown SDL 2 battery state: {state}");
                    return BatteryStatus.Unknown;
            }
        }

        public ThemeInfo GetPreferredTheme()
        {
            // FIXME: SDL 3.2.0 adds the function SDL_GetSystemTheme()
            Logger?.LogError("Can't get the preferred theme when using the SDL 2 backend. The information returned will be incorrect.");
            return new ThemeInfo()
            {
                Theme = AppTheme.NoPreference,
                HighContrast = false,
            };
        }

        public SystemMemoryInfo GetSystemMemoryInformation()
        {
            SystemMemoryInfo info;

            info.TotalPhysicalMemory = SDL_GetSystemRAM() * 1024 * 1024;
            // FIXME: Is there some way to get this information using SDL?
            info.AvailablePhysicalMemory = -1;

            return info;
        }
    }
}

using OpenTK.Core.Platform;
using OpenTK.Core.Platform.Enums;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.Windows
{
    public class ShellComponent : IShellComponent
    {
        /// <inheritdoc/>
        public string Name => "Win32 Shell Component";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Shell;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Shell)
            {
                throw new Exception("ShellComponent can only initialize the Shell component.");
            }
        }

        /// <inheritdoc/>
        public void AllowScreenSaver(bool allow)
        {
            Win32.SetThreadExecutionState(ExecutionState.Continuous | (allow ? 0 : ExecutionState.DisplayRequired));
        }

        /// <inheritdoc/>
        public BatteryStatus GetBatteryInfo(out BatteryInfo info)
        {
            bool success = Win32.GetSystemPowerStatus(out Win32.SystemPowerStatus systemPowerStatus);

            if (success == false)
            {
                // FIXME: Should we return BatteryStatus.Unknown?
                // return null;
                throw new Win32Exception();
            }

            if (systemPowerStatus.BatteryFlag.HasFlag(BatteryFlags.NoSystemBattery))
            {
                info = default;
                return BatteryStatus.NoSystemBattery;
            }

            // FIXME: Maybe express some of the uncertainty the windows api exposes
            // e.g. ACLineStatus can be unkown.
            info.OnAC = systemPowerStatus.ACLineStatus == ACLineStatus.Online;
            info.Charging = systemPowerStatus.BatteryFlag.HasFlag(BatteryFlags.Charging);
            info.PowerSaver = systemPowerStatus.SystemStatusFlag.HasFlag(SystemStatusFlags.BatterySaver);
            info.BatteryPercent = systemPowerStatus.BatteryLifePercent;
            info.BatteryTime = systemPowerStatus.BatteryLifeTime != -1 ? systemPowerStatus.BatteryLifeTime : null;
            return BatteryStatus.HasSystemBattery;
        }

        /// <inheritdoc/>
        public AppTheme GetPreferredTheme()
        {
            // Seems like this is non-standard on windows 10, but windows 11 has API for this.
            // There is a registry key, but that seems not that nice, though maybe as a fallback.
            //
            // This seems to say something about this:
            // https://learn.microsoft.com/en-us/windows/apps/desktop/modernize/apply-windows-themes
            // 
            // For windows 11 we want a platform specific setting for DWMWA_USE_IMMERSIVE_DARK_MODE.

            throw new NotImplementedException();
        }

        public void SetImmersiveDarkMode(bool useImmersiveDarkMode)
        {
            // FIXME:
            // DwmSetWindowAttribute(hWnd, DWMWA_USE_IMMERSIVE_DARK_MODE, &value, sizeof(value));
            throw new NotImplementedException();
        }
    }
}

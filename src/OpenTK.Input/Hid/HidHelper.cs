using System.Diagnostics;

namespace OpenTK.Input.Hid
{
    /// <summary>
    /// Static class that provides helper functions for consuming HID input.
    /// </summary>
    public static class HidHelper
    {
        /// <summary>
        /// Translates a generic HID usage value to a specific joystick axis for the specified <see cref="HidPage"/>.
        /// </summary>
        /// <param name="page">The HID usage page.</param>
        /// <param name="usage">The generic usage value.</param>
        /// <returns>An <see cref="int"/> that maps the HID usage value to a joystick axis.</returns>
        public static int TranslateJoystickAxis(HidPage page, int usage)
        {
            switch (page)
            {
                case HidPage.GenericDesktop:
                    switch ((HidGenericDesktopUsage)usage)
                    {
                        case HidGenericDesktopUsage.X:
                            return 0;
                        case HidGenericDesktopUsage.Y:
                            return 1;
                        case HidGenericDesktopUsage.Z:
                            return 2;
                        case HidGenericDesktopUsage.RotationZ:
                            return 3;
                        case HidGenericDesktopUsage.RotationX:
                            return 4;
                        case HidGenericDesktopUsage.RotationY:
                            return 5;
                        case HidGenericDesktopUsage.Slider:
                            return 6;
                        case HidGenericDesktopUsage.Dial:
                            return 7;
                        case HidGenericDesktopUsage.Wheel:
                            return 8;
                    }

                    break;
                case HidPage.Simulation:
                    switch ((HidSimulationUsage)usage)
                    {
                        case HidSimulationUsage.Rudder:
                            return 9;
                        case HidSimulationUsage.Throttle:
                            return 10;
                    }

                    break;
            }

            Debug.Print($"[Input] Unknown axis with HID page/usage {page}/{usage}");
            return 0;
        }
    }
}

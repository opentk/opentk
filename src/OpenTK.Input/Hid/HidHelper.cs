using System.Diagnostics;

namespace OpenTK.Input.Hid
{
    /// <summary>
    /// Static class that provides helper functions for consuming HID input.
    /// </summary>
    public static class HidHelper
    {
        //todo: XMLdoc here
        public static int TranslateJoystickAxis(HidPage page, int usage)
        {
            switch (page)
            {
                case HidPage.GenericDesktop:
                    switch ((HidUsageGD)usage)
                    {
                        case HidUsageGD.X:
                            return 0;
                        case HidUsageGD.Y:
                            return 1;
                        case HidUsageGD.Z:
                            return 2;
                        case HidUsageGD.Rz:
                            return 3;
                        case HidUsageGD.Rx:
                            return 4;
                        case HidUsageGD.Ry:
                            return 5;
                        case HidUsageGD.Slider:
                            return 6;
                        case HidUsageGD.Dial:
                            return 7;
                        case HidUsageGD.Wheel:
                            return 8;
                    }

                    break;
                case HidPage.Simulation:
                    switch ((HidUsageSim)usage)
                    {
                        case HidUsageSim.Rudder:
                            return 9;
                        case HidUsageSim.Throttle:
                            return 10;
                    }

                    break;
            }

            Debug.Print($"[Input] Unknown axis with HID page/usage {page}/{usage}");
            return 0;
        }
    }
}

using System;

namespace OpenTK.Core.Platform.Common
{
    public class HidHelper
    {
        /// <summary>
        /// Scales the specified value linearly between min and max.
        /// </summary>
        /// <param name="value">The value to scale</param>
        /// <param name="value_min">The minimum expected value (inclusive)</param>
        /// <param name="value_max">The maximum expected value (inclusive)</param>
        /// <param name="result_min">The minimum output value (inclusive)</param>
        /// <param name="result_max">The maximum output value (inclusive)</param>
        /// <returns>The value, scaled linearly between min and max</returns>
        public static int ScaleValue(int value, int value_min, int value_max,
            int result_min, int result_max)
        {
            if (value_min >= value_max || result_min >= result_max)
            {
                throw new ArgumentOutOfRangeException();
            }

            MathHelper.Clamp(value, value_min, value_max);

            var range = result_max - result_min;
            long temp = (value - value_min) * range; // need long to avoid overflow
            return (int)(temp / (value_max - value_min) + result_min);
        }

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

            Debug.Print("[Input] Unknown axis with HID page/usage {0}/{1}", page, usage);
            return 0;
        }
    }
}

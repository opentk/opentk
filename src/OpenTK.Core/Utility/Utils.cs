using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;

namespace OpenTK.Core
{
    public static class Utils
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Contains timing estimations used by <see cref="PreciseSleep(ref SleepTimings, double)"/> to achive highly precise sleeps.
        /// </summary>
        public struct SleepTimings
        {
            public double Estimate;
            public double Mean;
            public double M2;
            public long Count;

            /// <summary>
            /// Initializes a new instance of the <see cref="SleepTimings"/> struct that starts out with the expected sleep time in milliseconds.
            /// </summary>
            /// <param name="expectedSleepTime">The expected resolution of <see cref="Thread.Sleep(int)"/> in ms.</param>
            public SleepTimings(int expectedSleepTime)
            {
                Estimate = expectedSleepTime / 1000.0;
                Mean = expectedSleepTime / 1000.0;
                M2 = 0;
                Count = 1;
            }
        }

        /// <summary>
        /// A method for precise sleeps using previous measurements for the time of <see cref="Thread.Sleep(int)"/> to more accurately sleep.
        /// This function will use <see cref="Thread.Sleep(int)"/> in 1ms increments until the remaining sleep time is less than the estimated sleep time,
        /// at which point a spin wait is done.
        /// </summary>
        /// <param name="timings">A struct containting the current sleep timings.</param>
        /// <param name="seconds">The number of seconds to wait.</param>
        public static void PreciseSleep(this ref SleepTimings timings, double seconds)
        {
            // See https://blog.bearcats.nl/accurate-sleep-function/
            // FIXME: This method has a problem where if the timer resolution is about the same as the sleep times it will generally only spinwait.

            while (seconds > timings.Estimate)
            {
                var start = Stopwatch.GetTimestamp();
                Thread.Sleep(1);
                var end = Stopwatch.GetTimestamp();

                double observed = (end - start) / (double)Stopwatch.Frequency;
                seconds -= observed;

                timings.Count++;
                double delta = observed - timings.Mean;
                timings.Mean += delta / timings.Count;
                timings.M2 += delta * (observed - timings.Mean);
                double stddev = Math.Sqrt(timings.M2 / (timings.Count - 1));
                timings.Estimate = timings.Mean + stddev;
            }

            // spin wait
            var spinStart = Stopwatch.GetTimestamp();
            var delay = (long)seconds * Stopwatch.Frequency;
            while (Stopwatch.GetTimestamp() - spinStart < delay)
            {
            }
        }
    }
}

using System;
using System.Diagnostics;
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
        /// Contains timing estimations used to provide highly precise sleeps in <see cref="PreciseSleep(double)"/>.
        /// </summary>
        /// <remarks> See <see href="https://blog.bearcats.nl/accurate-sleep-function/" /> for more details.</remarks>
        public struct SleepTimings
        {
            // See https://blog.bearcats.nl/accurate-sleep-function/

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

            /// <summary>
            /// A method for precise sleeps using previous measurements for the time of <see cref="Thread.Sleep(int)"/> to more accurately sleep.
            /// This function will use <see cref="Thread.Sleep(int)"/> in 1ms increments until the remaining sleep time is less than the estimated sleep time,
            /// at which point a spin wait is done.
            /// </summary>
            /// <param name="seconds">The number of seconds to wait.</param>
            public void PreciseSleep(double seconds)
            {
                // FIXME: This method has a problem where if the timer resolution is about the same as the sleep times it will generally only spinwait.

                while (seconds > this.Estimate)
                {
                    var start = Stopwatch.GetTimestamp();
                    Thread.Sleep(1);
                    var end = Stopwatch.GetTimestamp();

                    double observed = (end - start) / (double)Stopwatch.Frequency;
                    seconds -= observed;

                    this.Count++;
                    double delta = observed - this.Mean;
                    this.Mean += delta / this.Count;
                    this.M2 += delta * (observed - this.Mean);
                    double stddev = Math.Sqrt(this.M2 / (this.Count - 1));
                    this.Estimate = this.Mean + stddev;
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
}

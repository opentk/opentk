using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
        /// A method for accurate sleep times.
        /// This function will favour accuracy over efficiency and spin wait if it's unsure a sleep will wake in time.
        /// </summary>
        /// <param name="seconds">The number of seconds to sleep for.</param>
        /// <param name="expectedSchedulerPeriod">
        /// The expected scheduler period in milliseconds. Can also be seen as the expected sleep time of <c>Thread.Sleep(1)</c>. <br/>
        /// Set on windows using <c>timeBeginPeriod()</c>.
        /// </param>
        public static void AccurateSleep(double seconds, int expectedSchedulerPeriod)
        {
            // FIXME: Make this a parameter?
            const double TOLERANCE = 0.02;

            long t0 = Stopwatch.GetTimestamp();
            long target = t0 + (long)(seconds * Stopwatch.Frequency);

            double ms = (seconds * 1000) - (expectedSchedulerPeriod * TOLERANCE);
            int ticks = (int)(ms / expectedSchedulerPeriod);
            if (ticks > 0)
            {
                Thread.Sleep(ticks * expectedSchedulerPeriod);
            }

            while (Stopwatch.GetTimestamp() < target)
            {
                Thread.Yield();
            }
        }
    }
}

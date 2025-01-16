using System;
using System.Diagnostics;
using System.Threading;

namespace OpenTK.Core
{
    /// <summary>
    /// A collection of utility functions exposed by OpenTK.
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// A method for accurate sleep times.
        /// This function will favour accuracy over efficiency and spin wait if it's unsure a sleep will wake in time.
        ///
        /// This is useful when implementing a run-loop with accurate timings.
        /// </summary>
        /// <param name="seconds">The number of seconds to sleep for.</param>
        /// <param name="expectedSchedulerPeriod">
        /// The expected scheduler period in milliseconds. Can also be seen as the expected sleep time of <c>Thread.Sleep(1)</c>. <br/>
        /// Set on windows using <c>timeBeginPeriod()</c>.
        /// </param>
        /// <remarks>
        /// The details of this method is described in detail here:
        /// <see href="https://blog.bearcats.nl/perfect-sleep-function/"/>.
        /// </remarks>
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

        // FIXME: this function is supposed to take in a TCHAR string,
        // but it doesn't handle the 32 bit case...
        public static unsafe string FromTszString(char* ptr, int max_length)
        {
            ReadOnlySpan<char> span = new ReadOnlySpan<char>(ptr, max_length);
            int index = span.IndexOf('\0');
            if (index == -1)
            {
                return new string(ptr, 0, max_length);
            }
            else
            {
                return new string(ptr, 0, index);
            }
        }
    }
}

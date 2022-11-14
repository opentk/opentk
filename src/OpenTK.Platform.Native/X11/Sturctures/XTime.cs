using System;

namespace OpenTK.Platform.Native.X11
{
    /// <summary>
    /// X11 Time Structure.
    /// </summary>
    public struct XTime
    {
        // The excellent (!) XLib documentation just does not describe this type
        // and I am lost as to what exactly the value of this structure is.
        // According to most references of the the type, it is aptly "time".
        // Sometimes it is labelled as "milliseconds" in the comments. My best
        // guess is that it is milliseconds since the UNIX epoch of
        // 1970-01-01T00:00:00.000Z.    - mixed

        /// <summary>
        /// Time value.
        /// </summary>
        /// <remarks>Likely milliseconds since UNIX epoch.</remarks>
        public ulong Value { get; }

        public XTime(ulong value)
        {
            Value = value;
        }

        public static explicit operator XTime(DateTime time)
        {
            return new XTime(
                (ulong)new DateTimeOffset(time).ToUnixTimeMilliseconds());
        }

        public static explicit operator DateTime(XTime time)
        {
            return DateTimeOffset.FromUnixTimeMilliseconds(
                (long)time.Value).DateTime;
        }
    }
}

using System;
using System.Diagnostics;

namespace OpenTK.Platform.Native.X11.XRandR
{
#pragma warning disable CS0649
    /// <summary>
    /// Opaque structure to the XRandR screen configuration structure.
    /// </summary>
    internal struct XRRScreenConfiguration
    {
        public IntPtr Handle;
    }

    internal struct XRRScreenSize
    {
        public int Width;
        public int Height;
        public int MWidth;
        public int MHeight;
    }
#pragma warning restore CS0649


    /// <summary>
    /// XRandR Output handle.
    /// </summary>
    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal readonly struct RROutput : IEquatable<RROutput>
    {
        public readonly ulong Id { get; }

        public static readonly RROutput None = new RROutput(0);

        public RROutput(ulong id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            return obj is RROutput mode && Id == mode.Id;
        }

        public bool Equals(RROutput other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public static bool operator ==(RROutput a, RROutput b)
        {
            return a.Id == b.Id;
        }

        public static bool operator !=(RROutput a, RROutput b)
        {
            return a.Id != b.Id;
        }
    }

    /// <summary>
    /// XRandR Crtc handle.
    /// </summary>
    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal readonly struct RRCrtc : IEquatable<RRCrtc>
    {
        public readonly ulong Id { get; }

        public static readonly RRCrtc None = new RRCrtc(0);

        public RRCrtc(ulong id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            return obj is RRCrtc mode && Id == mode.Id;
        }

        public bool Equals(RRCrtc other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public static bool operator ==(RRCrtc a, RRCrtc b)
        {
            return a.Id == b.Id;
        }

        public static bool operator !=(RRCrtc a, RRCrtc b)
        {
            return a.Id != b.Id;
        }
    }

    /// <summary>
    /// XRandR mode handle.
    /// </summary>
    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal readonly struct RRMode : IEquatable<RRMode>
    {
        public readonly ulong Id { get; }

        public static readonly RRMode None = new RRMode(0);

        public RRMode(ulong id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            return obj is RRMode mode && Id == mode.Id;
        }

        public bool Equals(RRMode other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public static bool operator ==(RRMode a, RRMode b)
        {
            return a.Id == b.Id;
        }

        public static bool operator !=(RRMode a, RRMode b)
        {
            return a.Id != b.Id;
        }
    }

    /// <summary>
    /// XRandR Output handle.
    /// </summary>
    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal readonly struct RRProvider
    {
        public readonly ulong Id { get; }

        public static readonly RRProvider None = new RRProvider(0);

        public RRProvider(ulong id)
        {
            Id = id;
        }
    }

#pragma warning disable CS0649 // Field '' is never assigned to, and will always have its default value 0
    internal struct XRRModeInfo
    {
        public RRMode ModeId;
        public uint Width;
        public uint Height;
        public ulong DotClock;
        public uint HSyncStart;
        public uint HSyncEnd;
        public uint HTotal;
        public uint HSkew;
        public uint VSyncStart;
        public uint VSyncEnd;
        public uint VTotal;
        public IntPtr Name;
        public uint NameLength;
        public XRRModeFlags ModeFlags;
    }

    internal unsafe struct XRRScreenResources
    {
        public XTime Timestamp;
        public XTime ConfigurationTimestamp;
        public int NumberOfCrtcs;
        public RRCrtc* Crtcs;
        public int NumberOfOutputs;
        public RROutput* Outputs;
        public int NumberOfModes;
        public XRRModeInfo* Modes;
    }
#pragma warning restore CS0649 // Field '' is never assigned to, and will always have its default value 0
}

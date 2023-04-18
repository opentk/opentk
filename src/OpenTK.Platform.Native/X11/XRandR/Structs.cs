using System;
using System.Diagnostics;

namespace OpenTK.Platform.Native.X11.XRandR
{
    /// <summary>
    /// Opaque structure to the XRandR screen configuration structure.
    /// </summary>
    public struct XRRScreenConfiguration
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

    /// <summary>
    /// XRandR Output handle.
    /// </summary>
    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal struct RROutput
    {
        public ulong Id { get; }

        public static readonly RROutput None = new RROutput(0);

        public RROutput(ulong id)
        {
            Id = id;
        }
    }

    /// <summary>
    /// XRandR Crtc handle.
    /// </summary>
    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal struct RRCrtc : IEquatable<RRCrtc>
    {
        public ulong Id { get; }

        public static readonly RRCrtc None = new RRCrtc(0);

        public RRCrtc(ulong id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            return obj is RRMode mode && Id == mode.Id;
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
    internal struct RRMode
    {
        public ulong Id { get; }

        public static readonly RRMode None = new RRMode(0);

        public RRMode(ulong id)
        {
            Id = id;
        }
    }

    /// <summary>
    /// XRandR Output handle.
    /// </summary>
    [DebuggerDisplay("XID={(System.IntPtr)Id}")]
    internal struct RRProvider
    {
        public ulong Id { get; }

        public static readonly RRProvider None = new RRProvider(0);

        public RRProvider(ulong id)
        {
            Id = id;
        }
    }

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
}

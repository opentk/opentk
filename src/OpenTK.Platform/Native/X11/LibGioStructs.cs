using System;

namespace OpenTK.Platform.Native
{
#pragma warning disable CS0649
    internal unsafe struct GError
    {
        public uint /* GQuark */ domain;
        public int code;
        public byte* message;
    }

    internal struct GValue
    {
        public nint Type;
        public nint Data0;
        public nint Data1;
    }
#pragma warning restore CS0649

}

using System;

namespace OpenTK.Platform.Native
{
    internal unsafe struct GError
    {
        public uint /* GQuark */ domain;
        public int code;
        public byte* message;
    }
}

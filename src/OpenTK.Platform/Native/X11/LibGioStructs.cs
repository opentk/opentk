namespace OpenTK.Platform.Native
{
#pragma warning disable CS0649
    internal unsafe struct GError
    {
        public uint /* GQuark */ domain;
        public int code;
        public byte* message;
    }
#pragma warning restore CS0649

}

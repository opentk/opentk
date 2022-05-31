namespace OpenTK.Platform.Native.X11
{
    public struct XVisualId
    {
        public ulong Id { get; }

        public static readonly XVisualId None = new XVisualId(0);

        public XVisualId(ulong id)
        {
            Id = id;
        }
    }
}

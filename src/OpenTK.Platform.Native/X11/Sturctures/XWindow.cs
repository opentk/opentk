namespace OpenTK.Platform.Native.X11
{
    public struct XWindow
    {
        public ulong Id { get; }

        public static readonly XWindow None = new XWindow(0);

        public XWindow(ulong id)
        {
            Id = id;
        }
    }
}
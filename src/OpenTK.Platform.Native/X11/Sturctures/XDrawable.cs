namespace OpenTK.Platform.Native.X11
{
    public struct XDrawable
    {
        public ulong Id { get; }

        public static readonly XDrawable None = new XDrawable(0);

        public XDrawable(ulong id)
        {
            Id = id;
        }
    }
}
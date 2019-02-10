namespace OpenToolkit.Windowing.EventingModels
{
    public class ResizeEventArgs
    {
        public ResizeEventArgs()
        {
            
        }

        public ResizeEventArgs(ResizeEventArgs other)
        {
            this.Width = other.Width;
            this.Height = other.Height;
        }

        internal ResizeEventArgs(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        
        public int Width { get; internal set; }
        public int Height { get; internal set; }
    }
}
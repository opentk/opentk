namespace OpenToolkit.Windowing.EventingModels
{
    public class WindowPositionEventArgs
    {
        public WindowPositionEventArgs()
        {
            
        }

        public WindowPositionEventArgs(WindowPositionEventArgs other)
        {
            this.X = other.X;
            this.Y = other.Y;
        }

        public WindowPositionEventArgs(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        
        public int X { get; internal set; }
        public int Y { get; internal set; }
    }
}
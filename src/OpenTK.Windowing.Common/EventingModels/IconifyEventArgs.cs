namespace OpenToolkit.Windowing.EventingModels
{
    public class IconifyEventArgs
    {
        public IconifyEventArgs()
        {
            
        }

        public IconifyEventArgs(IconifyEventArgs other)
        {
            this.isIconified = other.isIconified;
        }

        internal IconifyEventArgs(bool isIconified)
        {
            this.isIconified = isIconified;
        }
        
        public bool isIconified { get; internal set; }
    }
}
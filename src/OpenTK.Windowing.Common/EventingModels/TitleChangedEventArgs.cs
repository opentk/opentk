namespace OpenToolkit.Windowing.EventingModels
{
    public class TitleChangedEventArgs
    {
        public TitleChangedEventArgs()
        {
            
        }

        public TitleChangedEventArgs(TitleChangedEventArgs other)
        {
            this.Title = other.Title;
        }

        internal TitleChangedEventArgs(string Title)
        {
            this.Title = Title;
        }
        
        public string Title { get; internal set; }
    }
}
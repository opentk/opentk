using System;

namespace OpenToolkit.Windowing.EventingModels
{
    public class VisibilityChangedEventArgs : EventArgs
    {
        public VisibilityChangedEventArgs()
        {
            
        }

        public VisibilityChangedEventArgs(VisibilityChangedEventArgs other)
        {
            this.isVisible = other.isVisible;
        }

        public VisibilityChangedEventArgs(bool isVisible)
        {
            this.isVisible = isVisible;
        }
        
        public bool isVisible { get; internal set; }
    }
}
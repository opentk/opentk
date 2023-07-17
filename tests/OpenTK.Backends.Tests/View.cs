using System;

namespace OpenTK.Backends.Tests
{
    public abstract class View
    {
        public abstract string Title { get; }

        public virtual bool IsVisible => true;

        public virtual void NotifyEnter() { }

        public virtual void NotifyLeave() { }

        public virtual void Paint() { }
    }
}
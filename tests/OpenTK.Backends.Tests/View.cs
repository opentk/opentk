using System;

namespace OpenTK.Backends.Tests
{
    /// <summary>
    /// Base class for test application view tabs.
    /// </summary>
    public abstract class View
    {
        /// <summary>
        /// Title of the view tab.
        /// </summary>
        public abstract string Title { get; }

        /// <summary>
        /// True if the view should remain visible in the tab bar.
        /// </summary>
        public virtual bool IsVisible => true;

        /// <summary>
        /// Called at the start of the program, when the main window as been created.
        /// </summary>
        public virtual void Initialize() { }

        /// <summary>
        /// Called once when the tab becomes active.
        /// </summary>
        public virtual void NotifyEnter() { }

        /// <summary>
        /// Called once when the tab becomes inactive.
        /// </summary>
        public virtual void NotifyLeave() { }

        /// <summary>
        /// Paint tab contents.
        /// </summary>
        public virtual void Paint(double deltaTimex) { }
    }
}

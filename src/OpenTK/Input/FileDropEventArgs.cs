using System;

namespace OpenTK.Input
{
    /// <summary>
    /// Defines the event data for <see cref="NativeWindow"/> events.
    /// </summary>
    public class FileDropEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        public string FileName
        {
            get;
            internal set;
        }
    }
}

using System;

namespace OpenTK
{
    /// <summary>
    /// This exception is thown when a binding method is called and the bindings have not been rewritten by Rewrite.exe.
    /// </summary>
    public class BindingsNotRewrittenException : Exception
    {
        /// <summary>
        /// Constructs a new BindingsNotRewrittenException instance.
        /// </summary>
        public BindingsNotRewrittenException() : base("Rewrite.exe has not been run.")
        {
        }
    }
}
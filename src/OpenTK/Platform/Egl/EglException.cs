using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.Egl
{
    /// <summary>
    /// Represents an Egl exception.
    /// </summary>
    public class EglException : GraphicsContextException
    {
        /// <summary>
        /// Get the EGL error code.
        /// </summary>
        public ErrorCode ErrorCode { get; private set; }

        internal EglException(string message, ErrorCode errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}

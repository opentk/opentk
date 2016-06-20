// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using OpenTK.Graphics;

namespace OpenTK.Platform.Egl
{
    /// <summary>
    /// Represents an Egl exception.
    /// </summary>
    public class EglException : GraphicsContextException
    {
        /// <summary>
        /// Gets the EGL error code.
        /// </summary>
        public ErrorCode ErrorCode { get; private set; }

        internal EglException(string message, ErrorCode errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
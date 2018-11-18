﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using OpenToolkit.Graphics;

namespace OpenToolkit.Platform.Egl
{
    /// <summary>
    /// Represents an Egl exception.
    /// </summary>
    public class EglException : GraphicsContextException
    {
        internal EglException(string message, ErrorCode errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Gets the EGL error code.
        /// </summary>
        public ErrorCode ErrorCode { get; }
    }
}

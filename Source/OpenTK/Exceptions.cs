// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.

using System;

namespace OpenTK
{

    /// <summary>
    /// This exception is thrown when a GraphicsContext property cannot be changed after creation.
    /// </summary>
    public class ContextExistsException : ApplicationException
    {
        string msg;

        /// <summary>
        /// Constructs a new ContextExistsException instance.
        /// </summary>
        /// <param name="message">A System.String explaining the cause of this exception.</param>
        public ContextExistsException(string message)
        {
            msg = message;
        }

        /// <summary>
        /// Gets a System.String explaining the cause of this exception.
        /// </summary>
        public override string Message
        {
            get
            {
                return msg;
            }
        }
    }
}
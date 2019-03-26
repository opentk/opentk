//
// GLFWException.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Runtime.Serialization;

namespace OpenToolkit.GraphicsLibraryFramework
{
    [Serializable]
    public class GLFWException : Exception
    {
        public ErrorCode ErrorCode { get; set; }

        public GLFWException() { }
        public GLFWException(string message) : base(message) { }
        public GLFWException(string message, Exception inner) : base(message, inner) { }
        protected GLFWException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) { }
    }
}

//
// GLFWException.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.GraphicsLibraryFramework
{
    [Serializable]
    public class GLFWException : Exception
    {
        public int ErrorCode { get; set; }

        public GLFWException() { }
        public GLFWException(string message) : base(message) { }
        public GLFWException(string message, Exception inner) : base(message, inner) { }
        protected GLFWException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

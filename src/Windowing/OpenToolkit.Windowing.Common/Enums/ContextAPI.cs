//
// ContextAPI.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.Diagnostics.CodeAnalysis;

#pragma warning disable 1591

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Describes the graphics API you want the context to use.
    /// </summary>
    [SuppressMessage("ReSharper", "SA1602", Justification = "Should be obvious based on the names")]
    public enum ContextAPI
    {
        NoContext,
        OpenGLES,
        OpenGL,
    }
}

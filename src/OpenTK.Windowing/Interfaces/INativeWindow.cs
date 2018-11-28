//
// IGameWindow.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;


namespace OpenToolkit.Windowing.Interfaces
{
    /// <summary>
    /// Defines the interface for a NativeWindow
    /// </summary>
    public interface INativeWindow : IWindowProperties, IWindowEvents, IWindowInput, IDisposable
    {
    }
}

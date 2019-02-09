//
// FileDropEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.EventingModels
{
    /// <summary>
    /// Defines the event data for <see cref="NativeWindow" /> events.
    /// </summary>
    public class FileDropEventArgs : EventArgs
    {
        //HIGH: GLFW documentation states that this should be a string array instead of a single string
        // (for dragging and dropping multiple files at once)
        
        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        public string FileName { get; internal set; }
    }
}

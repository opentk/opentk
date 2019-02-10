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
    /// Defines the event data for files being dropped onto the window.
    /// </summary>
    public class FileDropEventArgs : EventArgs
    {        
        /// <summary>
        /// Get the names of the files.
        /// </summary>
        /// <value>An <see cref="System.Array" /> of strings giving the names of all files dropped.</value>
        public string[] FileName { get; internal set; }
    }
}

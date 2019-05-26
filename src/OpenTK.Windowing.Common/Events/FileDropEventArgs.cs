//
// FileDropEventArgs.cs
//
// Copyright (C) 2018 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Defines the event data for files being dropped onto the window.
    /// </summary>
    public class FileDropEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDropEventArgs"/> class.
        /// </summary>
        /// <param name="paths">
        /// The <see cref="System.Array" /> of strings giving the names of all files dropped.
        /// </param>
        public FileDropEventArgs(string[] paths)
        {
            FileNames = paths;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileDropEventArgs"/> class.
        /// </summary>
        /// <param name="other">The <see cref="FileDropEventArgs" /> instance to clone.</param>
        public FileDropEventArgs(FileDropEventArgs other)
        {
            FileNames = other.FileNames;
        }

        /// <summary>
        /// Gets the names of the files.
        /// </summary>
        /// <value>An <see cref="System.Array" /> of strings giving the names of all files dropped.</value>
        public string[] FileNames { get; internal set; }
    }
}

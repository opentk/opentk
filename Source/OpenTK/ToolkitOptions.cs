#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK
{
    /// <summary>
    /// Enumerates options regarding OpenTK.Platform
    /// implementations.
    /// </summary>
    public enum PlatformBackend
    {
        /// <summary>
        /// Select the optimal OpenTK.Platform implementation
        /// for the current operating system. This is the default
        /// option.
        /// </summary>
        Default = 0,
        /// <summary>
        /// Prefer native OpenTK.Platform implementations. 
        /// Platform abstractions such as SDL will not be considered,
        /// even if available. Use this if you need support for multiple
        /// mice or keyboards.
        /// </summary>
        PreferNative,
        /// <summary>
        /// Prefer an X11 OpenTK.Platform implementation,
        /// even if a different implementation is available. This option
        /// allows you to use X11 on Windows or Mac OS X when an
        /// X11 server is installed. 
        /// </summary>
        PreferX11
    }

    /// <summary>
    /// Contains configuration options for OpenTK.
    /// <see cref="Toolkit.Init(ToolkitOptions)"/>
    /// </summary>
    public class ToolkitOptions
    {
        static ToolkitOptions()
        {
            Default = new ToolkitOptions();
            Default.EnableHighResolution = true;
        }

        /// <summary>
        /// Get or set the desired <c>PlatformBackend</c>
        /// for the OpenTK.Platform implementation.
        /// </summary>
        public PlatformBackend Backend { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether high
        /// resolution modes are supported on high-DPI
        /// ("Retina") displays. Enabled by default.
        /// Set to false for applications that are not
        /// DPI-aware (e.g. WinForms.)
        /// </summary>
        /// See: http://msdn.microsoft.com/en-us/library/windows/desktop/ee308410(v=vs.85).aspx
        public bool EnableHighResolution { get; set; }

        /// <summary>
        /// Gets a <c>ToolkitOptions</c> instance with
        /// default values.
        /// </summary>
        public static ToolkitOptions Default { get; private set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Windowing.GraphicsLibraryFramework
{
    public enum InitHintPlatform
    {
        /// <summary>
        /// Use to specify the platform to use for windowing and input.
        /// Possible values are <see cref="Platform.Any"/>, <see cref="Platform.Win32"/>, <see cref="Platform.Cocoa"/>, <see cref="Platform.Wayland"/>, <see cref="Platform.X11"/> and <see cref="Platform.Null"/>.
        /// The default value is <see cref="Platform.Any"/>, which will choose any platform the library includes support for except for the Null backend.
        /// </summary>
        Platform = 0x00050003,
    }
}

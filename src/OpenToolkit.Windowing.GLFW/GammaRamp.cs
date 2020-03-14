//
// GammaRamp.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.GraphicsLibraryFramework
{
    /// <summary>
    /// Gamma ramp for a <see cref="Monitor"/>.
    /// </summary>
    public unsafe struct GammaRamp
    {
        /// <summary>
        /// Red components of the gamma ramp.
        /// </summary>
        public ushort* Red;

        /// <summary>
        /// Green components of the gamma ramp.
        /// </summary>
        public ushort* Green;

        /// <summary>
        /// Blue components of the gamma ramp.
        /// </summary>
        public ushort* Blue;

        /// <summary>
        /// Length of the arrays.
        /// </summary>
        public uint Size;
    }
}

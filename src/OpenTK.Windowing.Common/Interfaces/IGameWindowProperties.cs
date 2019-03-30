//
// IGameWindowProperties.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Describes <see cref="IGameWindow"/> related properties.
    /// </summary>
    public interface IGameWindowProperties
    {
        /// <summary>
        /// Gets a value indicating whether or not the NativeWindow should use a single-threaded context.
        /// </summary>
        /// <remarks>
        ///   <para>
        /// This should generally be false.
        ///   </para>
        /// </remarks>
        bool IsSingleThreaded { get; }

        /// <summary>
        /// Gets or sets a double representing the render frequency, in hertz.
        /// </summary>
        /// <remarks>
        ///  <para>
        /// A value of 0.0 indicates that RenderFrame events are generated at the maximum possible frequency (i.e. only
        /// limited by the hardware's capabilities).
        ///  </para>
        ///  <para>Values lower than 1.0Hz are clamped to 0.0. Values higher than 500.0Hz are clamped to 200.0Hz.</para>
        /// </remarks>
        double RenderFrequency { get; set; }

        /// <summary>
        /// Gets or sets a double representing the update frequency, in hertz.
        /// </summary>
        /// <remarks>
        ///  <para>
        /// A value of 0.0 indicates that UpdateFrame events are generated at the maximum possible frequency (i.e. only
        /// limited by the hardware's capabilities).
        ///  </para>
        ///  <para>Values lower than 1.0Hz are clamped to 0.0. Values higher than 500.0Hz are clamped to 500.0Hz.</para>
        /// </remarks>
        double UpdateFrequency { get; set; }
    }
}

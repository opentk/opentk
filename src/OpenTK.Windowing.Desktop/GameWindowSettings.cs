//
// GameWindowSettings.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace OpenTK.Windowing.Desktop
{
    /// <summary>
    ///     <see cref="GameWindow" /> related settings.
    /// </summary>
    public class GameWindowSettings
    {
        /// <summary>
        ///     The default <see cref="GameWindowSettings" />.
        /// </summary>
        public static readonly GameWindowSettings Default = new GameWindowSettings();

        /// <summary>
        ///     Gets or sets a value indicating whether the game window should use a separate thread for render events.
        /// </summary>
        public bool IsMultiThreaded { get; set; } = false;

        /// <summary>
        ///     Gets or sets a double representing the render frequency, in hertz.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         A value of 0.0 indicates that RenderFrame events are generated at the maximum possible frequency (i.e. only
        ///         limited by the hardware's capabilities).
        ///     </para>
        ///     <para>Values lower than 1.0Hz are clamped to 0.0. Values higher than 500.0Hz are clamped to 200.0Hz.</para>
        /// </remarks>
        public double RenderFrequency { get; set; } = 0.0;

        /// <summary>
        ///     Gets or sets a double representing the update frequency, in hertz.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         A value of 0.0 indicates that UpdateFrame events are generated at the maximum possible frequency (i.e. only
        ///         limited by the hardware's capabilities).
        ///     </para>
        ///     <para>Values lower than 1.0Hz are clamped to 0.0. Values higher than 500.0Hz are clamped to 500.0Hz.</para>
        /// </remarks>
        public double UpdateFrequency { get; set; } = 0.0;
    }
}

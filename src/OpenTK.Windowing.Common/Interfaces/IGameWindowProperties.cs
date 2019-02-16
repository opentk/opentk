namespace OpenToolkit.Windowing.Common
{
    public interface IGameWindowProperties
    {
        /// <summary>
        /// Whether or not the NativeWindow should use a single-threaded context.
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
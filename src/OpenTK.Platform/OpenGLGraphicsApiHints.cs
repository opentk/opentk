using System;

#nullable enable

namespace OpenTK.Platform
{
    /// <summary>
    /// Graphics API hints for OpenGL family of APIs.
    /// </summary>
    public class OpenGLGraphicsApiHints : GraphicsApiHints
    {
        /// <inheritdoc/>
        public override GraphicsApi Api => GraphicsApi.OpenGL;

        /// <summary>
        /// OpenGL version to create.
        /// </summary>
        public Version Version { get; set; } = new Version(4, 1);

        // FIXME: Convert a bunch of the framebuffer settings
        // into a single ContextValues property that we can use
        // directly when we call the selector.
        // - Noggin_bops 2024-06-22

        /// <summary>
        /// Number of bits for red color channel.
        /// </summary>
        public int RedColorBits { get; set; } = 8;

        /// <summary>
        /// Number of bits for green color channel.
        /// </summary>
        public int GreenColorBits { get; set; } = 8;

        /// <summary>
        /// Number of bits for blue color channel.
        /// </summary>
        public int BlueColorBits { get; set; } = 8;

        /// <summary>
        /// Number of bits for alpha color channel.
        /// </summary>
        public int AlphaColorBits { get; set; } = 8;

        /// <summary>
        /// Number of bits for stencil buffer.
        /// </summary>
        public ContextStencilBits StencilBits { get; set; } = ContextStencilBits.Stencil8;

        /// <summary>
        /// Number of bits for depth buffer.
        /// </summary>
        public ContextDepthBits DepthBits { get; set; } = ContextDepthBits.Depth24;

        /// <summary>
        /// Number of MSAA samples.
        /// </summary>
        public int Multisamples { get; set; } = 0;

        /// <summary>
        /// Enable double buffering.
        /// </summary>
        public bool DoubleBuffer { get; set; } = true;

        /// <summary>
        /// Makes the backbuffer support sRGB.
        /// </summary>
        public bool sRGBFramebuffer { get; set; } = false;

        /// <summary>
        /// The pixel format of the context.
        /// This differentiates between "normal" fixed point LDR formats
        /// and floating point HDR formats.
        /// Use <see cref="ContextPixelFormat.RGBAFloat"/> or <see cref="ContextPixelFormat.RGBAPackedFloat"/> for HDR support.
        /// Is <see cref="ContextPixelFormat.RGBA"/> by default.
        /// </summary>
        public ContextPixelFormat PixelFormat { get; set; } = ContextPixelFormat.RGBA;

        /// <summary>
        /// The swap method to use for the context.
        /// Is <see cref="ContextSwapMethod.Undefined"/> by default.
        /// </summary>
        public ContextSwapMethod SwapMethod { get; set; } = ContextSwapMethod.Undefined;

        /// <summary>
        /// The OpenGL profile to request.
        /// </summary>
        public OpenGLProfile Profile { get; set; } = OpenGLProfile.None;

        /// <summary>
        /// If the forward compatible flag should be set or not.
        /// </summary>
        public bool ForwardCompatibleFlag { get; set; } = true;

        /// <summary>
        /// If the debug flag should be set or not.
        /// </summary>
        public bool DebugFlag { get; set; } = false;

        /// <summary>
        /// If the robustness flag should be set or not.
        /// </summary>
        public bool RobustnessFlag { get; set; } = false;

        /// <summary>
        /// The reset notification strategy to use if <see cref="RobustnessFlag"/> is set to <c>true</c>.
        /// See <see href="https://registry.khronos.org/OpenGL/extensions/ARB/ARB_robustness.txt">GL_ARB_robustness</see> for details.
        /// Default value is <see cref="ContextResetNotificationStrategy.NoResetNotification"/>.
        /// </summary>
        public ContextResetNotificationStrategy ResetNotificationStrategy { get; set; } = ContextResetNotificationStrategy.NoResetNotification;

        /// <summary>
        /// See <see href="https://registry.khronos.org/OpenGL/extensions/ARB/ARB_robustness_application_isolation.txt">GL_ARB_robustness_isolation</see>.
        /// <see cref="ResetNotificationStrategy"/> needs to be <see cref="ContextResetNotificationStrategy.LoseContextOnReset"/>.
        /// </summary>
        public bool ResetIsolationFlag { get; set; } = false;

        /// <summary>
        /// If the "no error" flag should be set or not.
        /// See <see href="https://registry.khronos.org/OpenGL/extensions/KHR/KHR_no_error.txt">KHR_no_error</see>.
        /// Cannot be enabled while <see cref="DebugFlag"/> or <see cref="RobustnessFlag"/> is set.
        /// </summary>
        public bool NoErrorFlag { get; set; } = false;

        /// <summary>
        /// Whether to use KHR_context_flush_control (if available) or not.
        /// See <see cref="ReleaseBehaviour"/> for flush control options.
        /// </summary>
        public bool UseFlushControl { get; set; } = false;

        /// <summary>
        /// If <see cref="UseFlushControl"/> is true then this controls the context release behaviour when the context is changed.
        /// Is <see cref="ContextReleaseBehaviour.Flush"/> by default.
        /// </summary>
        public ContextReleaseBehaviour ReleaseBehaviour { get; set; } = ContextReleaseBehaviour.Flush;

        /// <summary>
        /// A context to enable context sharing with.
        /// </summary>
        public OpenGLContextHandle? SharedContext { get; set; } = null;

        /// <summary>
        /// A callback that can be used to select appropriate backbuffer values.
        /// </summary>
        /// <remarks>
        /// By default on macOS this selector is not used due to slow performance,
        /// see <see cref="UseSelectorOnMacOS"/> to enable the selector on macOS.
        /// </remarks>
        /// <seealso cref="UseSelectorOnMacOS"/>
        public ContextValueSelector Selector { get; set; } = ContextValues.DefaultValuesSelector;

        /// <summary>
        /// Enumerating <see cref="ContextValues"/> on macOS is slow, so by default <see cref="Selector"/> is not used on macOS.
        /// When this property is <c>false</c> the default platform selection of context values are used, which tries to find a closest match.
        /// </summary>
        /// <seealso cref="Selector"/>
        /// <seealso cref="ContextValueSelector"/>
        public bool UseSelectorOnMacOS { get; set; } = false;

        /// <summary>
        /// If the requested <see cref="ContextValues"/> should have <see cref="ContextValues.SupportsFramebufferTransparency"/> set to <see langword="true"/>.
        /// This only matters on Linux/X11 as other platforms always support framebuffer transparency.
        /// </summary>
        /// <seealso cref="ContextValues.SupportsFramebufferTransparency"/>
        /// <seealso cref="IWindowComponent.SupportsFramebufferTransparency(WindowHandle)"/>
        /// <seealso cref="IWindowComponent.SetTransparencyMode(WindowHandle, WindowTransparencyMode, float)"/>
        /// <seealso cref="IWindowComponent.GetTransparencyMode(WindowHandle, out float)"/>
        public bool SupportTransparentFramebufferX11 { get; set; } = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGLGraphicsApiHints"/> class.
        /// </summary>
        public OpenGLGraphicsApiHints()
        {
        }

        /// <summary>
        /// Make a memberwise copy of these settings.
        /// </summary>
        /// <returns>The copied settings.</returns>
        public OpenGLGraphicsApiHints Copy()
        {
            return (OpenGLGraphicsApiHints)MemberwiseClone();
        }
    }
}

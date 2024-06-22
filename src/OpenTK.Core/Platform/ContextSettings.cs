using System;
using System.Collections.Generic;
using OpenTK.Core.Utility;

#nullable enable

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Delegate used to select appropriate context values to use.
    /// </summary>
    /// <param name="options">A list of possible context values.</param>
    /// <param name="requested">The user requested context values.</param>
    /// <param name="logger">A logger to use for logging.</param>
    /// <returns>The index of the context value to use.</returns>
    public delegate int ContextValueSelector(IReadOnlyList<ContextValues> options, ContextValues requested, ILogger? logger);

    // FIXME: Better name.
    public struct ContextValues
    {
        public int ID;

        public int RedBits;
        public int GreenBits;
        public int BlueBits;
        public int AlphaBits;
        public int DepthBits;
        public int StencilBits;
        public bool DoubleBuffered;
        public bool SRGBFramebuffer;
        public ContextPixelFormat PixelFormat;
        public ContextSwapMethod SwapMethod;
        public int Samples;

        // FIXME: Add stereo?
        // FIXME: Add transparency?

        /// <summary>
        /// Default context values selector. Prioritizes the requested values with a series of "relaxations" to find a close match.<br/>
        /// The relaxations are done in the following order:
        /// <list type="number">
        /// <item><description>If no exact match is found try find a format with a larger number of color, depth, or stencil bits.</description></item>
        /// <item><description>If <see cref="SRGBFramebuffer"/> == false is requested, <see cref="SRGBFramebuffer"/> == true formats will be accepted.</description></item>
        /// <item><description>If <see cref="SwapMethod"/> == <see cref="ContextSwapMethod.Undefined"/>, any swap method will be accepted.</description></item>
        /// <item><description>If <see cref="SRGBFramebuffer"/> == true, accept <see cref="SRGBFramebuffer"/> == false formats.</description></item>
        /// <item><description>Accept any <see cref="PixelFormat"/>.</description></item>
        /// <item><description>Decrement <see cref="Samples"/> by one at a time until 0 and see if any alternative sample counts are possible.</description></item>
        /// <item><description>Accept any <see cref="SwapMethod"/>.</description></item>
        /// <item><description>If all relaxations fail, select the first option in the list.</description></item>
        /// </list>
        /// </summary>
        /// <param name="options">The possible context values.</param>
        /// <param name="requested">The requested context values.</param>
        /// <param name="logger">A logger to use for logging.</param>
        /// <returns>The index of the selected "best match" context values.</returns>
        public static int DefaultValuesSelector(IReadOnlyList<ContextValues> options, ContextValues requested, ILogger? logger)
        {
            if (options.Count == 0)
            {
                // FIXME: Maybe better exception?
                throw new InvalidOperationException("There needs to be at least one ContextValues option.");
            }

            logger?.LogDebug("Default context values matcher:");

            for (int i = 0; i < options.Count; i++)
            {
                if (IsEqualExcludingID(options[i], requested))
                {
                    logger?.LogDebug("Found exact match!");
                    return options[i].ID;
                }
            }

            // We have to relax some requirements.

            // See if there are any formats with greater bit depth.
            logger?.LogDebug("No exact match, looking for context values with greater or equal color depth.");
            for (int i = 0; i < options.Count; i++)
            {
                if (HasGreaterOrEqualColorBits(options[i], requested) &&
                    HasGreaterOrEqualDepthBits(options[i], requested) &&
                    HasGreaterOrEqualStencilBits(options[i], requested) &&
                    HasEqualMSAA(options[i], requested) &&
                    HasEqualSRGB(options[i], requested) &&
                    HasEqualPixelFormat(options[i], requested) &&
                    HasEqualSwapMethod(options[i], requested))
                {
                    logger?.LogDebug("Found matching format with greater color depth!");
                    return options[i].ID;
                }
            }

            // Relax requested SRGBFramebuffer == false to match formats with sRGB support.
            if (requested.SRGBFramebuffer == false)
            {
                logger?.LogDebug("No match found, relaxing SRGBFramebuffer == false to match with SRGBFramebuffer == true.");
                for (int i = 0; i < options.Count; i++)
                {
                    if (HasGreaterOrEqualColorBits(options[i], requested) &&
                        HasGreaterOrEqualDepthBits(options[i], requested) &&
                        HasGreaterOrEqualStencilBits(options[i], requested) &&
                        HasEqualMSAA(options[i], requested) &&
                        (HasEqualSRGB(options[i], requested) || requested.SRGBFramebuffer == false) &&
                        HasEqualPixelFormat(options[i], requested))
                    {
                        logger?.LogDebug("Found matching format with SRGBFramebuffer == true!");
                        return options[i].ID;
                    }
                }
            }

            // Relax requested ContextSwapMethod.Undefined to match with any swap method.
            if (requested.SwapMethod == ContextSwapMethod.Undefined)
            {
                logger?.LogDebug("No match found, relaxing ContextSwapMethod.Undefined to match with any swap method.");
                for (int i = 0; i < options.Count; i++)
                {
                    if (HasGreaterOrEqualColorBits(options[i], requested) &&
                        HasGreaterOrEqualDepthBits(options[i], requested) &&
                        HasGreaterOrEqualStencilBits(options[i], requested) &&
                        HasEqualMSAA(options[i], requested) &&
                        (HasEqualSRGB(options[i], requested) || requested.SRGBFramebuffer == false) &&
                        HasEqualPixelFormat(options[i], requested))
                    {
                        logger?.LogDebug("Found matching format with any swap format!");
                        return options[i].ID;
                    }
                }
            }

            // Relax srgb
            logger?.LogDebug("No match found, relaxing sRGB framebuffer requirement.");
            for (int i = 0; i < options.Count; i++)
            {
                if (HasGreaterOrEqualColorBits(options[i], requested) &&
                    HasGreaterOrEqualDepthBits(options[i], requested) &&
                    HasGreaterOrEqualStencilBits(options[i], requested) &&
                    HasEqualMSAA(options[i], requested) &&
                    HasEqualPixelFormat(options[i], requested) &&
                    (requested.SwapMethod == ContextSwapMethod.Undefined || HasEqualSwapMethod(options[i], requested)))
                {
                    logger?.LogDebug("Found matching format without sRGB framebuffer!");
                    return options[i].ID;
                }
            }

            // Relax pixel format
            logger?.LogDebug("No match found, relaxing ContextPixelFormat to match with any pixel format.");
            for (int i = 0; i < options.Count; i++)
            {
                if (HasGreaterOrEqualColorBits(options[i], requested) &&
                    HasGreaterOrEqualDepthBits(options[i], requested) &&
                    HasGreaterOrEqualStencilBits(options[i], requested) &&
                    HasEqualMSAA(options[i], requested) &&
                    (requested.SwapMethod == ContextSwapMethod.Undefined || HasEqualSwapMethod(options[i], requested)))
                {
                    logger?.LogDebug("Found matching format after relaxing ContextPixelFormat!");
                    return options[i].ID;
                }
            }

            // Relax MSAA
            logger?.LogDebug("No match found, relaxing MSAA samples.");
            while (requested.Samples > 0)
            {
                requested.Samples--;
                for (int i = 0; i < options.Count; i++)
                {
                    if (HasGreaterOrEqualColorBits(options[i], requested) &&
                        HasGreaterOrEqualDepthBits(options[i], requested) &&
                        HasGreaterOrEqualStencilBits(options[i], requested) &&
                        HasEqualMSAA(options[i], requested) &&
                        (requested.SwapMethod == ContextSwapMethod.Undefined || HasEqualSwapMethod(options[i], requested)))
                    {
                        logger?.LogDebug($"Found match with {requested.Samples} MSAA samples.");
                        return options[i].ID;
                    }
                }
            }

            // Relax swap method completely
            logger?.LogDebug("No match found, relaxing swap method completely.");
            for (int i = 0; i < options.Count; i++)
            {
                if (HasGreaterOrEqualColorBits(options[i], requested) &&
                    HasGreaterOrEqualDepthBits(options[i], requested) &&
                    HasGreaterOrEqualStencilBits(options[i], requested))
                {
                    logger?.LogDebug("Found matching format after relaxing swap method.");
                    return options[i].ID;
                }
            }

            // FIXME: More relaxations.

            // All else has failed, return the first format.
            logger?.LogDebug("No match found, all relaxations failed. Using the first format in the list...");
            return 0;
        }

        public static bool IsEqualExcludingID(ContextValues option, ContextValues requested)
        {
            return option.RedBits == requested.RedBits &&
                option.GreenBits == requested.GreenBits &&
                option.BlueBits == requested.BlueBits &&
                option.AlphaBits == requested.AlphaBits &&
                option.DepthBits == requested.DepthBits &&
                option.StencilBits == requested.StencilBits &&
                option.DoubleBuffered == requested.DoubleBuffered &&
                option.SRGBFramebuffer == requested.SRGBFramebuffer &&
                option.PixelFormat == requested.PixelFormat &&
                option.SwapMethod == requested.SwapMethod &&
                option.Samples == requested.Samples;
        }

        public static bool HasEqualColorBits(ContextValues option, ContextValues requested)
        {
            return option.RedBits == requested.RedBits &&
                option.GreenBits == requested.GreenBits &&
                option.BlueBits == requested.BlueBits &&
                option.AlphaBits == requested.AlphaBits;
        }

        public static bool HasGreaterOrEqualColorBits(ContextValues option, ContextValues requested)
        {
            return option.RedBits >= requested.RedBits &&
                option.GreenBits >= requested.GreenBits &&
                option.BlueBits >= requested.BlueBits &&
                option.AlphaBits >= requested.AlphaBits;
        }

        public static bool HasEqualDepthBits(ContextValues option, ContextValues requested)
        {
            return option.DepthBits == requested.DepthBits;
        }

        public static bool HasGreaterOrEqualDepthBits(ContextValues option, ContextValues requested)
        {
            return option.DepthBits >= requested.DepthBits;
        }

        public static bool HasEqualStencilBits(ContextValues option, ContextValues requested)
        {
            return option.StencilBits == requested.StencilBits;
        }

        public static bool HasGreaterOrEqualStencilBits(ContextValues option, ContextValues requested)
        {
            return option.StencilBits >= requested.StencilBits;
        }

        public static bool HasEqualMSAA(ContextValues option, ContextValues requested)
        {
            return option.Samples == requested.Samples;
        }

        public static bool HasEqualSRGB(ContextValues option, ContextValues requested)
        {
            return option.SRGBFramebuffer == requested.SRGBFramebuffer;
        }

        public static bool HasEqualPixelFormat(ContextValues option, ContextValues requested)
        {
            return option.PixelFormat == requested.PixelFormat;
        }

        public static bool HasEqualSwapMethod(ContextValues option, ContextValues requested)
        {
            return option.SwapMethod == requested.SwapMethod;
        }

        public ContextValues(int id, int redBits, int greenBits, int blueBits, int alphaBits, int depthBits, int stencilBits, bool doubleBuffered, bool sRGBFramebuffer, ContextPixelFormat pixelFormat, ContextSwapMethod swapMethod, int samples)
        {
            ID = id;
            RedBits = redBits;
            GreenBits = greenBits;
            BlueBits = blueBits;
            AlphaBits = alphaBits;
            DepthBits = depthBits;
            StencilBits = stencilBits;
            DoubleBuffered = doubleBuffered;
            SRGBFramebuffer = sRGBFramebuffer;
            PixelFormat = pixelFormat;
            SwapMethod = swapMethod;
            Samples = samples;
        }

        public override readonly string ToString()
        {
            return $"ID: {ID}, " +
                $"RedBits: {RedBits}, " +
                $"GreenBits: {GreenBits}, " +
                $"BlueBits: {BlueBits}, " +
                $"AlphaBits: {AlphaBits}, " +
                $"DepthBits: {DepthBits}, " +
                $"StencilBits: {StencilBits}, " +
                $"DoubleBuffered: {DoubleBuffered}, " +
                $"SRGBFramebuffer: {SRGBFramebuffer}, " +
                $"PixelFormat: {PixelFormat}, " +
                $"SwapMethod: {SwapMethod}, " +
                $"Samples: {Samples}";
        }
    }

    /// <summary>
    /// Defined the pixel format type of the context.
    /// This is used to differentiate between "normal" fixed point LDR formats
    /// and floating point HDR formats.
    /// </summary>
    public enum ContextPixelFormat
    {
        /// <summary>
        /// Normal fixed point RGBA format specified by the color bits.
        /// </summary>
        RGBA,

        /// <summary>
        /// Floating point RGBA pixel format specified by
        /// <see href="https://registry.khronos.org/OpenGL/extensions/ARB/ARB_color_buffer_float.txt">ARB_color_buffer_float</see>
        /// or
        /// <see href="https://registry.khronos.org/OpenGL/extensions/ATI/WGL_ATI_pixel_format_float.txt">WGL_ATI_pixel_format_float</see>.
        /// </summary>
        RGBAFloat,

        /// <summary>
        /// From <see href="https://registry.khronos.org/OpenGL/extensions/EXT/EXT_packed_float.txt">EXT_packed_float</see>.
        /// Pixel format is unsigned 10F_11F_11F format.
        /// </summary>
        RGBAPackedFloat,
    }

    /// <summary>
    /// Defines differnet semantics for what happens to the backbuffer after a swap.
    /// </summary>
    public enum ContextSwapMethod
    {
        /// <summary>
        /// The contents of the backbuffer after a swap is undefined.
        /// </summary>
        Undefined,

        /// <summary>
        /// The contents of the frontbuffer and backbuffer are exchanged after a swap.
        /// </summary>
        Exchange,

        /// <summary>
        /// The contents of the backbuffer are copied to the frontbuffer during a swap.
        /// Leaving the contents of the backbuffer unchanged.
        /// </summary>
        Copy,
    }

    /// <summary>
    /// Represents the number of depth bits of the context depth backbuffer.
    /// </summary>
    public enum ContextDepthBits
    {
        /// <summary>
        /// No depth buffer.
        /// </summary>
        None = 0,

        /// <summary>
        /// 16-bit depth buffer.
        /// </summary>
        Depth16 = 16,

        /// <summary>
        /// 24-bit depth buffer.
        /// </summary>
        Depth24 = 24,

        /// <summary>
        /// 32-bit depth buffer.
        /// </summary>
        Depth32 = 32,

        // FIXME: Floating point depth buffers??
    }

    /// <summary>
    /// Represents the number of depth bits of the context stencil backbuffer.
    /// </summary>
    public enum ContextStencilBits
    {
        /// <summary>
        /// No stencil bits needed.
        /// </summary>
        None = 0,

        /// <summary>
        /// 1-bit stencil buffer.
        /// </summary>
        Stencil1 = 1,

        /// <summary>
        /// 8-bit stencil buffer.
        /// </summary>
        Stencil8 = 8,
    }

    /// <summary>
    /// See <see href="https://registry.khronos.org/OpenGL/extensions/ARB/ARB_robustness.txt">GL_ARB_robustness</see> extension for details.
    /// </summary>
    public enum ContextResetNotificationStrategy
    {
        NoResetNotification,
        LoseContextOnReset,
    }

    /// <summary>
    /// See <see href="https://registry.khronos.org/OpenGL/extensions/KHR/KHR_context_flush_control.txt">KHR_context_flush_control</see> extension for details.
    /// </summary>
    public enum ContextReleaseBehaviour
    {
        /// <summary>
        /// No flush is done when the context is released (made not current).
        /// </summary>
        None,

        /// <summary>
        /// A flush is done when the context is released (made not current).
        /// </summary>
        Flush,
    }
}

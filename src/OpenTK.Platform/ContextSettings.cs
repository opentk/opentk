using System;
using System.Collections.Generic;
using OpenTK.Core.Utility;

#nullable enable

namespace OpenTK.Platform
{
    /// <summary>
    /// Delegate used to select appropriate context values to use.
    /// </summary>
    /// <param name="options">A list of possible context values.</param>
    /// <param name="requested">The user requested context values.</param>
    /// <param name="logger">A logger to use for logging.</param>
    /// <returns>The index of the context value to use.</returns>
    public delegate int ContextValueSelector(IReadOnlyList<ContextValues> options, ContextValues requested, ILogger? logger);

    /// <summary>
    /// Values describing the full specification of a OpenGL context's backbuffer.
    /// </summary>
    // FIXME: Better name.
    public struct ContextValues : IEquatable<ContextValues>
    {
        /// <summary>The internal ID used to identify these context values.</summary>
        public ulong ID;

        /// <summary>The number of bits used to represent the red channel.</summary>
        public int RedBits;
        /// <summary>The number of bits used to represent the green channel.</summary>
        public int GreenBits;
        /// <summary>The number of bits used to represent the blue channel.</summary>
        public int BlueBits;
        /// <summary>The number of bits used to represent the alpha channel.</summary>
        public int AlphaBits;
        /// <summary>The number of bits used to represent the depth buffer.</summary>
        public int DepthBits;
        /// <summary>The number of bits used to represent the stencil buffer.</summary>
        public int StencilBits;
        /// <summary>If the backbuffer is double buffered or not.</summary>
        public bool DoubleBuffered;
        /// <summary>If the backbuffer supports framebuffer sRGB conversion. Enabled using <see cref="Graphics.OpenGL.GL.Enable(Graphics.OpenGL.EnableCap)"/> with <see cref="Graphics.OpenGL.EnableCap.FramebufferSrgb"/>.</summary>
        public bool SRGBFramebuffer;
        /// <summary>The pixel format of the backbuffer. Using floating point pixel formats allows for HDR display output.</summary>
        public ContextPixelFormat PixelFormat;
        /// <summary>The swap method to use for the backbuffer.</summary>
        public ContextSwapMethod SwapMethod;
        /// <summary>The number of MSAA samples for the backbuffer.</summary>
        public int Samples;

        /// <summary>
        /// If this context configuration supports <see cref="WindowTransparencyMode.TransparentFramebuffer"/>.
        /// <list type="bullet|number|table">
        ///     <item>
        ///         <term>Win32</term>
        ///         <description>Always <see langword="true"/>.</description>
        ///     </item>
        ///     <item>
        ///         <term>X11</term>
        ///         <description>Support for transparent framebuffers is not always available.</description>
        ///     </item>
        ///     <item>
        ///         <term>macOS</term>
        ///         <description>Always <see langword="true"/>.</description>
        ///     </item>
        ///     <item>
        ///         <term>ANGLE on win32</term>
        ///         <description>Always <see langword="true"/>.</description>
        ///     </item>
        ///     <item>
        ///         <term>ANGLE on X11</term>
        ///         <description>TODO: Does this work?</description>
        ///     </item>
        ///     <item>
        ///         <term>ANGLE on macOS</term>
        ///         <description>TODO: Does this work?</description>
        ///     </item>
        /// </list>
        /// </summary>
        /// <seealso cref="WindowTransparencyMode.TransparentFramebuffer"/>
        /// <see cref="IWindowComponent.SupportsFramebufferTransparency(WindowHandle)"/>
        /// <seealso cref="IWindowComponent.SetTransparencyMode(WindowHandle, WindowTransparencyMode, float)"/>
        /// <seealso cref="IWindowComponent.GetTransparencyMode(WindowHandle, out float)"/>
        public bool SupportsFramebufferTransparency;

        /// <summary>
        /// If the backbuffer has a left and right buffer.
        /// </summary>
        public bool Stereo;

        /// <summary>
        /// Default context values selector. Prioritizes the requested values with a series of "relaxations" to find a close match.<br/>
        /// The relaxations are done in the following order:
        /// <list type="number">
        /// <item><description>If no exact match is found try find a format with a larger number of color, depth, or stencil bits.</description></item>
        /// <item><description>If <see cref="SupportsFramebufferTransparency"/> == false is requested, <see cref="SupportsFramebufferTransparency"/> == true formats will be accepted.</description></item>
        /// <item><description>If <see cref="SRGBFramebuffer"/> == false is requested, <see cref="SRGBFramebuffer"/> == true formats will be accepted.</description></item>
        /// <item><description>If <see cref="SwapMethod"/> == <see cref="ContextSwapMethod.Undefined"/>, any swap method will be accepted.</description></item>
        /// <item><description>If <see cref="SupportsFramebufferTransparency"/> == true, accept <see cref="SupportsFramebufferTransparency"/> == false formats.</description></item>
        /// <item><description>If <see cref="SRGBFramebuffer"/> == true, accept <see cref="SRGBFramebuffer"/> == false formats.</description></item>
        /// <item><description>Accept any <see cref="PixelFormat"/>.</description></item>
        /// <item><description>Decrement <see cref="Samples"/> by one at a time until 0 and see if any alternative sample counts are possible.</description></item>
        /// <item><description>Accept any <see cref="SwapMethod"/>.</description></item>
        /// <item><description>Allow one of color bits (<see cref="RedBits"/>, <see cref="GreenBits"/>, <see cref="BlueBits"/>, and <see cref="AlphaBits"/>), <see cref="DepthBits"/>, or <see cref="StencilBits"/> to be lower than requested.</description></item>
        /// <item><description>Allow two of color bits (<see cref="RedBits"/>, <see cref="GreenBits"/>, <see cref="BlueBits"/>, and <see cref="AlphaBits"/>), <see cref="DepthBits"/>, or <see cref="StencilBits"/> to be lower than requested.</description></item>
        /// <item><description>Relax all bit requirements.</description></item>
        /// <item><description>Relax double buffer requirements.</description></item>
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
                    return i;
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
                    HasEqualDoubleBuffer(options[i], requested) &&
                    HasEqualSRGB(options[i], requested) &&
                    HasEqualPixelFormat(options[i], requested) &&
                    HasEqualSwapMethod(options[i], requested) &&
                    HasEqualFramebufferTransparencySupport(options[i], requested) &&
                    HasEqualStereo(options[i], requested))
                {
                    logger?.LogDebug("Found matching format with greater color depth!");
                    return i;
                }
            }

            if (requested.SupportsFramebufferTransparency == false)
            {
                logger?.LogDebug("No exact match, relaxing SupportsFramebufferTransparency == false to match with SupportsFramebufferTransparency == true.");
                for (int i = 0; i < options.Count; i++)
                {
                    if (HasGreaterOrEqualColorBits(options[i], requested) &&
                        HasGreaterOrEqualDepthBits(options[i], requested) &&
                        HasGreaterOrEqualStencilBits(options[i], requested) &&
                        HasEqualMSAA(options[i], requested) &&
                        HasEqualDoubleBuffer(options[i], requested) &&
                        HasEqualSRGB(options[i], requested) &&
                        HasEqualPixelFormat(options[i], requested) &&
                        HasEqualSwapMethod(options[i], requested) &&
                        HasEqualStereo(options[i], requested))
                    {
                        logger?.LogDebug("Found matching format with relaxed framebuffer transparency support!");
                        return i;
                    }
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
                        HasEqualDoubleBuffer(options[i], requested) &&
                        (HasEqualSRGB(options[i], requested) || requested.SRGBFramebuffer == false) &&
                        HasEqualPixelFormat(options[i], requested) &&
                        HasEqualSwapMethod(options[i], requested) &&
                        (requested.SupportsFramebufferTransparency == false || HasEqualFramebufferTransparencySupport(options[i], requested)) &&
                        HasEqualStereo(options[i], requested))
                    {
                        logger?.LogDebug("Found matching format with SRGBFramebuffer == true!");
                        return i;
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
                        HasEqualDoubleBuffer(options[i], requested) &&
                        (HasEqualSRGB(options[i], requested) || requested.SRGBFramebuffer == false) &&
                        HasEqualPixelFormat(options[i], requested) &&
                        (requested.SupportsFramebufferTransparency == false || HasEqualFramebufferTransparencySupport(options[i], requested)) &&
                        HasEqualStereo(options[i], requested))
                    {
                        logger?.LogDebug("Found matching format with any swap format!");
                        return i;
                    }
                }
            }

            // Relax framebuffer transparency support
            logger?.LogDebug("No match found, relaxing framebuffer transparency support requirement.");
            for (int i = 0; i < options.Count; i++)
            {
                if (HasGreaterOrEqualColorBits(options[i], requested) &&
                    HasGreaterOrEqualDepthBits(options[i], requested) &&
                    HasGreaterOrEqualStencilBits(options[i], requested) &&
                    HasEqualMSAA(options[i], requested) &&
                    HasEqualDoubleBuffer(options[i], requested) &&
                    (HasEqualSRGB(options[i], requested) || requested.SRGBFramebuffer == false) &&
                    HasEqualPixelFormat(options[i], requested) &&
                    (requested.SwapMethod == ContextSwapMethod.Undefined || HasEqualSwapMethod(options[i], requested)) &&
                    HasEqualStereo(options[i], requested))
                {
                    logger?.LogDebug("Found matching format with relaxed framebuffer transparency support!");
                    return i;
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
                    HasEqualDoubleBuffer(options[i], requested) &&
                    HasEqualPixelFormat(options[i], requested) &&
                    (requested.SwapMethod == ContextSwapMethod.Undefined || HasEqualSwapMethod(options[i], requested)) &&
                    HasEqualStereo(options[i], requested))
                {
                    logger?.LogDebug("Found matching format without sRGB framebuffer!");
                    return i;
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
                    HasEqualDoubleBuffer(options[i], requested) &&
                    (requested.SwapMethod == ContextSwapMethod.Undefined || HasEqualSwapMethod(options[i], requested)) &&
                    HasEqualStereo(options[i], requested))
                {
                    logger?.LogDebug("Found matching format after relaxing ContextPixelFormat!");
                    return i;
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
                        HasEqualDoubleBuffer(options[i], requested) &&
                        (requested.SwapMethod == ContextSwapMethod.Undefined || HasEqualSwapMethod(options[i], requested)) &&
                        HasEqualStereo(options[i], requested))
                    {
                        logger?.LogDebug($"Found match with {requested.Samples} MSAA samples.");
                        return i;
                    }
                }
            }

            // Relax swap method completely
            logger?.LogDebug("No match found, relaxing swap method completely.");
            for (int i = 0; i < options.Count; i++)
            {
                if (HasGreaterOrEqualColorBits(options[i], requested) &&
                    HasGreaterOrEqualDepthBits(options[i], requested) &&
                    HasGreaterOrEqualStencilBits(options[i], requested) &&
                    HasEqualDoubleBuffer(options[i], requested) &&
                    HasEqualStereo(options[i], requested))
                {
                    logger?.LogDebug("Found matching format after relaxing swap method.");
                    return i;
                }
            }

            // FIXME: When we get here we actually want to get the "closest" format
            // and not just remove every bit depth test completely.

            // Relax color bits to allow one of color, depth or stencil bits to be lower.
            logger?.LogDebug("No match found, relaxing one of color, depth, or stencil bits");
            for (int i = 0; i < options.Count; i++)
            {
                if (HasGreaterOrEqualColorBits(options[i], requested) &&
                    HasGreaterOrEqualDepthBits(options[i], requested) &&
                    HasLessOrEqualStencilBits(options[i], requested) &&
                    HasEqualDoubleBuffer(options[i], requested) &&
                    HasEqualStereo(options[i], requested))
                {
                    logger?.LogDebug("Found matching format after relaxing stencil bits.");
                    return i;
                }

                if (HasGreaterOrEqualColorBits(options[i], requested) &&
                    HasLessOrEqualDepthBits(options[i], requested) &&
                    HasGreaterOrEqualStencilBits(options[i], requested) &&
                    HasEqualDoubleBuffer(options[i], requested) &&
                    HasEqualStereo(options[i], requested))
                {
                    logger?.LogDebug("Found matching format after relaxing depth bits.");
                    return i;
                }

                if (HasLessOrEqualColorBits(options[i], requested) &&
                    HasGreaterOrEqualDepthBits(options[i], requested) &&
                    HasGreaterOrEqualStencilBits(options[i], requested) &&
                    HasEqualDoubleBuffer(options[i], requested) &&
                    HasEqualStereo(options[i], requested))
                {
                    logger?.LogDebug("Found matching format after relaxing color bits.");
                    return i;
                }
            }

            // Relax color bits to allow two of color, depth or stencil bits to be lower.
            logger?.LogDebug("No match found, relaxing two of color, depth, or stencil bits");
            for (int i = 0; i < options.Count; i++)
            {
                if (HasGreaterOrEqualColorBits(options[i], requested) &&
                    HasLessOrEqualDepthBits(options[i], requested) &&
                    HasLessOrEqualStencilBits(options[i], requested) &&
                    HasEqualDoubleBuffer(options[i], requested) &&
                    HasEqualStereo(options[i], requested))
                {
                    logger?.LogDebug("Found matching format after relaxing stencil and depth bits.");
                    return i;
                }

                if (HasLessOrEqualColorBits(options[i], requested) &&
                    HasLessOrEqualDepthBits(options[i], requested) &&
                    HasGreaterOrEqualStencilBits(options[i], requested) &&
                    HasEqualDoubleBuffer(options[i], requested) &&
                    HasEqualStereo(options[i], requested))
                {
                    logger?.LogDebug("Found matching format after relaxing color and depth bits.");
                    return i;
                }

                if (HasLessOrEqualColorBits(options[i], requested) &&
                    HasGreaterOrEqualDepthBits(options[i], requested) &&
                    HasLessOrEqualStencilBits(options[i], requested) &&
                    HasEqualDoubleBuffer(options[i], requested) &&
                    HasEqualStereo(options[i], requested))
                {
                    logger?.LogDebug("Found matching format after relaxing color and stencil bits.");
                    return i;
                }
            }

            // Relax all bits to allow lower bits.
            logger?.LogDebug("No match found, relaxing all bits.");
            for (int i = 0; i < options.Count; i++)
            {
                if (HasEqualDoubleBuffer(options[i], requested) &&
                    HasEqualStereo(options[i], requested))
                {
                    logger?.LogDebug("Found matching format after relaxing all bits.");
                    return i;
                }
            }

            // Relax double buffering, if stereo was requested the user probably wants stereo more than double buffering.
            logger?.LogDebug("No match found, relaxing double buffering.");
            for (int i = 0; i < options.Count; i++)
            {
                if (HasEqualStereo(options[i], requested))
                {
                    logger?.LogDebug("Found matching format after relaxing double buffering.");
                    return i;
                }
            }

            // FIXME: More relaxations.

            // FIXME: Potentially consider some kind of score based system...

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
                option.Samples == requested.Samples &&
                option.SupportsFramebufferTransparency == requested.SupportsFramebufferTransparency &&
                option.Stereo == requested.Stereo;
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

        public static bool HasLessOrEqualColorBits(ContextValues option, ContextValues requested)
        {
            return option.RedBits <= requested.RedBits &&
                option.GreenBits <= requested.GreenBits &&
                option.BlueBits <= requested.BlueBits &&
                option.AlphaBits <= requested.AlphaBits;
        }

        public static bool HasEqualDepthBits(ContextValues option, ContextValues requested)
        {
            return option.DepthBits == requested.DepthBits;
        }

        public static bool HasGreaterOrEqualDepthBits(ContextValues option, ContextValues requested)
        {
            return option.DepthBits >= requested.DepthBits;
        }

        public static bool HasLessOrEqualDepthBits(ContextValues option, ContextValues requested)
        {
            return option.DepthBits <= requested.DepthBits;
        }

        public static bool HasEqualStencilBits(ContextValues option, ContextValues requested)
        {
            return option.StencilBits == requested.StencilBits;
        }

        public static bool HasGreaterOrEqualStencilBits(ContextValues option, ContextValues requested)
        {
            return option.StencilBits >= requested.StencilBits;
        }

        public static bool HasLessOrEqualStencilBits(ContextValues option, ContextValues requested)
        {
            return option.StencilBits <= requested.StencilBits;
        }

        public static bool HasEqualMSAA(ContextValues option, ContextValues requested)
        {
            return option.Samples == requested.Samples;
        }

        public static bool HasEqualDoubleBuffer(ContextValues option, ContextValues requested)
        {
            return option.DoubleBuffered == requested.DoubleBuffered;
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

        public static bool HasEqualFramebufferTransparencySupport(ContextValues option, ContextValues requested)
        {
            return option.SupportsFramebufferTransparency == requested.SupportsFramebufferTransparency;
        }

        public static bool HasEqualStereo(ContextValues option, ContextValues requested)
        {
            return option.Stereo == requested.Stereo;
        }

        public ContextValues(ulong id, int redBits, int greenBits, int blueBits, int alphaBits, int depthBits, int stencilBits, bool doubleBuffered, bool sRGBFramebuffer, ContextPixelFormat pixelFormat, ContextSwapMethod swapMethod, int samples)
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

        /// <inheritdoc />
        public override readonly bool Equals(object? obj)
        {
            return obj is ContextValues values && Equals(values);
        }

        /// <inheritdoc />
        public readonly bool Equals(ContextValues other)
        {
            return // ID == other.ID &&
                   RedBits == other.RedBits &&
                   GreenBits == other.GreenBits &&
                   BlueBits == other.BlueBits &&
                   AlphaBits == other.AlphaBits &&
                   DepthBits == other.DepthBits &&
                   StencilBits == other.StencilBits &&
                   DoubleBuffered == other.DoubleBuffered &&
                   SRGBFramebuffer == other.SRGBFramebuffer &&
                   PixelFormat == other.PixelFormat &&
                   SwapMethod == other.SwapMethod &&
                   Samples == other.Samples;
        }

        /// <inheritdoc />
        public override readonly int GetHashCode()
        {
            HashCode hash = new HashCode();
            // hash.Add(ID);
            hash.Add(RedBits);
            hash.Add(GreenBits);
            hash.Add(BlueBits);
            hash.Add(AlphaBits);
            hash.Add(DepthBits);
            hash.Add(StencilBits);
            hash.Add(DoubleBuffered);
            hash.Add(SRGBFramebuffer);
            hash.Add(PixelFormat);
            hash.Add(SwapMethod);
            hash.Add(Samples);
            return hash.ToHashCode();
        }

        /// <inheritdoc />
        public static bool operator ==(ContextValues left, ContextValues right)
        {
            return left.Equals(right);
        }

        /// <inheritdoc />
        public static bool operator !=(ContextValues left, ContextValues right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
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
                $"Samples: {Samples}, " +
                $"Stereo: {Stereo}";
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
        /// <summary>
        /// No reset notification will be sent and <see cref="Graphics.OpenGL.GL.ARB.GetGraphicsResetStatusARB"/> will always return <see cref="Graphics.OpenGL.GraphicsResetStatus.NoError"/>.
        /// </summary>
        NoResetNotification,
        /// <summary>
        /// Reset notification will be sent through <see cref="Graphics.OpenGL.GL.ARB.GetGraphicsResetStatusARB"/> which can be used to detect a reset of a OpenGL context.
        /// </summary>
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

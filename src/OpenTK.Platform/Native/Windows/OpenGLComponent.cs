using Microsoft.VisualBasic.FileIO;
using OpenTK.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenTK.Platform.Native.Windows
{
    // FIXME: This is to enable easily writing a full description of
    // Win32.PIXELFORMATDESCRIPTOR while having trimming enabled.
    // We want to remove this in favour of a proper ToString method
    // on Win32.PIXELFORMATDESCRIPTOR.
    [JsonSourceGenerationOptions(WriteIndented = true)]
    [JsonSerializable(typeof(Win32.PIXELFORMATDESCRIPTOR))]
    internal partial class PixelformatDescriptorSourceGenerationContext : JsonSerializerContext
    {
    }

    public class OpenGLComponent : IOpenGLComponent
    {
        /// <inheritdoc/>
        public string Name => "Win32OpenGL";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.OpenGL;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            Win32.PIXELFORMATDESCRIPTOR pfd = Win32.PIXELFORMATDESCRIPTOR.Create();
            pfd = new Win32.PIXELFORMATDESCRIPTOR()
            {
                nSize = pfd.nSize,
                nVersion = 1,
                dwFlags = PFD.DRAW_TO_WINDOW | PFD.SUPPORT_OPENGL | PFD.DOUBLEBUFFER,
                iPixelType = PFDType.TYPE_RGBA,
                cColorBits = 32,
                cRedBits = 0,
                cRedShift = 0,
                cGreenBits = 0,
                cGreenShift = 0,
                cBlueBits = 0,
                cBlueShift = 0,
                cAlphaBits = 0,
                cAlphaShift = 0,
                cAccumBits = 0,
                cAccumRedBits = 0,
                cAccumGreenBits = 0,
                cAccumBlueBits = 0,
                cAccumAlphaBits = 0,
                cDepthBits = 0,
                cStencilBits = 0,
                cAuxBuffers = 0,
                iLayerType = 0,
                bReserved = 0,
                dwLayerMask = 0,
                dwVisibleMask = 0,
                dwDamageMask = 0,
            };

            // We don't release this DC because we have CS_OWNDC set.
            // - Noggin_bops 2023-01-11
            IntPtr hDC = Win32.GetDC(WindowComponent.HelperHWnd);

            if (hDC == IntPtr.Zero)
            {
                throw new Win32Exception();
            }
            uint nBytes;
            unchecked
            {
                nBytes = (uint)Marshal.SizeOf<Win32.PIXELFORMATDESCRIPTOR>();
            }

            int pixelFormatIndex = Win32.ChoosePixelFormat(hDC, in pfd);
            if (pixelFormatIndex == 0)
            {
                throw new Win32Exception();
            }

            Win32.PIXELFORMATDESCRIPTOR chosenFormat = default;
            int maxFormat = Win32.DescribePixelFormat(hDC, pixelFormatIndex, nBytes, ref chosenFormat);
            if (maxFormat == 0)
            {
                throw new Win32Exception();
            }
            JsonSerializerOptions opt2 = new JsonSerializerOptions()
            {
                IncludeFields = true,
                WriteIndented = true,
                TypeInfoResolver = PixelformatDescriptorSourceGenerationContext.Default,
            };
            Logger?.LogDebug($"=== Chosen Format ===\n" +
                $"Version: {chosenFormat.nVersion}\n" +
                $"Flags: {chosenFormat.dwFlags} ({Convert.ToString((uint)chosenFormat.dwFlags, 2)})\n" +
                $"Pixel Type: {chosenFormat.iPixelType}\n" +
                $"Color bits: {chosenFormat.cColorBits}\n" +
                $"Depth bits: {chosenFormat.cDepthBits}\n" +
                $"Stencil bits: {chosenFormat.cStencilBits}\n" +
                $"Full desc: {JsonSerializer.Serialize(chosenFormat, chosenFormat.GetType(), new PixelformatDescriptorSourceGenerationContext(opt2))}");

            bool success = Win32.SetPixelFormat(hDC, pixelFormatIndex, in chosenFormat);
            if (success == false)
            {
                throw new Win32Exception();
            }

            IntPtr hGLRC = Wgl.CreateContext(hDC);
            if (hGLRC == IntPtr.Zero)
            {
                throw new Win32Exception();
            }

            // FIXME: Maybe restore the context that was already there after?
            success = Wgl.MakeCurrent(hDC, hGLRC);
            if (success == false)
            {
                throw new Win32Exception();
            }

            unsafe
            {
                Wgl._GetExtensionsStringARB__fnptr = (delegate* unmanaged<IntPtr, byte*>)Wgl.GetProcAddress("wglGetExtensionsStringARB");
                
                Wgl._GetPixelFormatAttribivARB__fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int*, int*, int>)Wgl.GetProcAddress("wglGetPixelFormatAttribivARB");

                Wgl._ChoosePixelFormatARB__fnptr = (delegate* unmanaged<IntPtr, int*, float*, uint, int*, uint*, int>)Wgl.GetProcAddress("wglChoosePixelFormatARB");

                Wgl._CreateContextAttribsARB__fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, IntPtr>)Wgl.GetProcAddress("wglCreateContextAttribsARB");

                Wgl._SwapIntervalEXT__fnptr = (delegate* unmanaged<int, void>)Wgl.GetProcAddress("wglSwapIntervalEXT");

                Wgl._GetSwapIntervalEXT__fnptr = (delegate* unmanaged<int>)Wgl.GetProcAddress("wglGetSwapIntervalEXT");

                if (Wgl._GetExtensionsStringARB__fnptr != null)
                {
                    string[] wglExts = Wgl.GetExtensionsStringARB(hDC)?.Split(" ") ?? Array.Empty<string>();

                    ARB_multisample = wglExts.Contains("WGL_ARB_multisample");
                    ARB_framebuffer_sRGB = wglExts.Contains("WGL_ARB_framebuffer_sRGB");
                    EXT_framebuffer_sRGB = wglExts.Contains("WGL_EXT_framebuffer_sRGB");
                    ARB_color_buffer_float = wglExts.Contains("WGL_ARB_pixel_format_float");
                    ATI_pixel_format_float = wglExts.Contains("WGL_ATI_pixel_format_float");
                    EXT_pixel_format_packed_float = wglExts.Contains("WGL_EXT_pixel_format_packed_float");
                    ARB_create_context = wglExts.Contains("WGL_ARB_create_context");
                    ARB_create_context_profile = wglExts.Contains("WGL_ARB_create_context_profile");
                    ARB_create_context_es2_profile = wglExts.Contains("WGL_EXT_create_context_es2_profile");
                    ARB_create_context_robustness = wglExts.Contains("WGL_ARB_create_context_robustness");
                    ARB_robustness_application_isolation = wglExts.Contains("WGL_ARB_robustness_application_isolation");
                    ARB_robustness_share_group_isolation = wglExts.Contains("WGL_ARB_robustness_share_group_isolation");
                    ARB_create_context_no_error = wglExts.Contains("WGL_ARB_create_context_no_error");
                    EXT_swap_control = wglExts.Contains("WGL_EXT_swap_control");
                    EXT_colorspace = wglExts.Contains("WGL_EXT_colorspace");
                    EXT_depth_float = wglExts.Contains("WGL_EXT_depth_float");
                    ARB_pixel_format = wglExts.Contains("WGL_ARB_pixel_format");
                    ARB_context_flush_control = wglExts.Contains("WGL_ARB_context_flush_control");

                    foreach (var ext in wglExts)
                    {
                        Logger?.LogDebug($"wglExts: {ext}");
                    }
                }
            }

            // FIXME: Maybe restore the context that was already there?

            // Delete the helper context
            success = Wgl.DeleteContext(hGLRC);
            if (success == false)
            {
                throw new Win32Exception();
            }
        }

        internal static readonly Dictionary<IntPtr, HGLRC> HGLRCDict = new Dictionary<IntPtr, HGLRC>();

        #region Extension bools

        internal static bool ARB_multisample { get; set; }

        internal static bool ARB_framebuffer_sRGB { get; set; }

        internal static bool EXT_framebuffer_sRGB { get; set; }

        internal static bool ARB_color_buffer_float { get; set; }

        internal static bool ATI_pixel_format_float { get; set; }

        internal static bool EXT_pixel_format_packed_float { get; set; }

        internal static bool ARB_create_context { get; set; }

        internal static bool ARB_create_context_profile { get; set; }

        internal static bool ARB_create_context_es2_profile { get; set; }

        internal static bool ARB_create_context_robustness { get; set; }

        internal static bool ARB_robustness_application_isolation { get; set; }

        internal static bool ARB_robustness_share_group_isolation { get; set; }

        internal static bool ARB_create_context_no_error { get; set; }

        internal static bool EXT_swap_control { get; set; }

        internal static bool EXT_colorspace { get; set; }

        internal static bool EXT_depth_float { get; set; }

        internal static bool ARB_pixel_format { get; set; }

        internal static bool ARB_context_flush_control { get; set; }


        #endregion

        /// <inheritdoc/>
        public bool CanShareContexts => true;

        /// <inheritdoc/>
        public bool CanCreateFromWindow => true;

        /// <inheritdoc/>
        public bool CanCreateFromSurface => false;

        /// <inheritdoc/>
        public OpenGLContextHandle CreateFromSurface()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public OpenGLContextHandle CreateFromWindow(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);
            if (hwnd.GraphicsApiHints is not OpenGLGraphicsApiHints settings)
            {
                throw new PalException(this, $"Can't create an OpenGL context from a window that was not created with {nameof(OpenGLGraphicsApiHints)}.");
            }

            // FIXME: Make this a parameter to this function instead?
            HGLRC? hshareContext = null;
            if (settings.SharedContext != null)
            {
                if (settings.SharedContext is HGLRC share)
                {
                    hshareContext = share;
                }
                else
                {
                    throw new PalException(this, "Can't create a shared context with a non-WGL (HGLRC) OpenGL context.");
                }
            }

            bool success;

            // This DC is kept for the lifetime of the object.
            // We have CS_OWNDC set so keeping the reference isn't an issue.
            // - Noggin_bops 2023-01-11
            IntPtr hDC = Win32.GetDC(hwnd.HWnd);
            if (hDC == IntPtr.Zero)
            {
                throw new Win32Exception();
            }

            byte depthBits;
            switch (settings.DepthBits)
            {
                case ContextDepthBits.None:    depthBits = 0;  break;
                case ContextDepthBits.Depth16: depthBits = 16; break;
                case ContextDepthBits.Depth24: depthBits = 24; break;
                case ContextDepthBits.Depth32: depthBits = 32; break;
                default: throw new InvalidEnumArgumentException(nameof(settings.DepthBits), (int)settings.DepthBits, settings.DepthBits.GetType());
            }

            byte stencilBits;
            switch (settings.StencilBits)
            {
                case ContextStencilBits.None:     stencilBits = 0; break;
                case ContextStencilBits.Stencil1: stencilBits = 1; break;
                case ContextStencilBits.Stencil8: stencilBits = 8; break;
                default: throw new InvalidEnumArgumentException(nameof(settings.StencilBits), (int)settings.StencilBits, settings.StencilBits.GetType());
            }

            ContextValues requested = new ContextValues();
            requested.RedBits = settings.RedColorBits;
            requested.GreenBits = settings.GreenColorBits;
            requested.BlueBits = settings.BlueColorBits;
            requested.AlphaBits = settings.AlphaColorBits;
            requested.DepthBits = depthBits;
            requested.StencilBits = stencilBits;
            requested.DoubleBuffered = settings.DoubleBuffer;
            requested.SRGBFramebuffer = settings.sRGBFramebuffer;
            requested.PixelFormat = settings.PixelFormat;
            requested.SwapMethod = settings.SwapMethod;
            requested.Samples = settings.Multisamples;

            if (ARB_pixel_format)
            {
                // We have the pixel format extension!
                Span<WGLPixelFormatAttribute> attrib = stackalloc WGLPixelFormatAttribute[1] { WGLPixelFormatAttribute.NUMBER_PIXEL_FORMATS_ARB };
                int numberOfFormats = 0;
                unsafe
                {
                    success = Wgl.GetPixelFormatAttribivARB(hDC, 1, 0, 1, attrib, new Span<int>(&numberOfFormats, 1));
                    if (success == false)
                    {
                        throw new Win32Exception();
                    }
                }
                
                List<WGLPixelFormatAttribute> attribList = new List<WGLPixelFormatAttribute>()
                {
                    WGLPixelFormatAttribute.SUPPORT_OPENGL_ARB,
                    WGLPixelFormatAttribute.DRAW_TO_WINDOW_ARB,
                    WGLPixelFormatAttribute.PIXEL_TYPE_ARB,
                    WGLPixelFormatAttribute.ACCELERATION_ARB,
                    WGLPixelFormatAttribute.SWAP_METHOD_ARB,
                    WGLPixelFormatAttribute.DOUBLE_BUFFER_ARB,
                    WGLPixelFormatAttribute.STEREO_ARB,
                    WGLPixelFormatAttribute.RED_BITS_ARB,
                    WGLPixelFormatAttribute.GREEN_BITS_ARB,
                    WGLPixelFormatAttribute.BLUE_BITS_ARB,
                    WGLPixelFormatAttribute.ALPHA_BITS_ARB,
                    WGLPixelFormatAttribute.DEPTH_BITS_ARB,
                    WGLPixelFormatAttribute.STENCIL_BITS_ARB,
                };

                if (ARB_multisample)
                {
                    attribList.Add(WGLPixelFormatAttribute.SAMPLES_ARB);
                }

                if (ARB_framebuffer_sRGB)
                {
                    attribList.Add(WGLPixelFormatAttribute.FRAMEBUFFER_SRGB_CAPABLE_ARB);
                }
                else if (EXT_framebuffer_sRGB)
                {
                    attribList.Add(WGLPixelFormatAttribute.FRAMEBUFFER_SRGB_CAPABLE_ARB);
                }
                else if (EXT_colorspace)
                {
                    attribList.Add(WGLPixelFormatAttribute.COLORSPACE_EXT);
                }

                // Extract the span directly from the list to avoid allocation?
                WGLPixelFormatAttribute[] contextValueAttrib = attribList.ToArray();
                // FIXME: Stack alloc this?
                int[] contextValues = new int[contextValueAttrib.Length];

                // FIXME: Don't always return -1? Pass the default value...
                // Should we throw exceptions for the ones we always expect to get answers to?
                static int FindAttribute(WGLPixelFormatAttribute[] attribs, int[] values, WGLPixelFormatAttribute search)
                {
                    for (int i = 0; i < attribs.Length; i++)
                    {
                        if (attribs[i] == search)
                        {
                            return values[i];
                        }
                    }

                    return -1;
                }

                List<ContextValues> possibleContextValues = new List<ContextValues>(numberOfFormats);
                for (int i = 1; i <= numberOfFormats; i++)
                {
                    success = Wgl.GetPixelFormatAttribivARB(hDC, i, 0, contextValueAttrib.Length, contextValueAttrib, contextValues);
                    if (success == false)
                    {
                        throw new Win32Exception();
                    }

                    if (FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.DRAW_TO_WINDOW_ARB) == 0)
                    {
                        continue;
                    }

                    if (FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.SUPPORT_OPENGL_ARB) == 0)
                    {
                        continue;
                    }

                    WGLColorType colorType = (WGLColorType)FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.PIXEL_TYPE_ARB);
                    ContextPixelFormat pixelFormat;
                    if (EXT_pixel_format_packed_float && colorType == WGLColorType.TYPE_RGBA_UNSIGNED_FLOAT_EXT)
                    {
                        pixelFormat = ContextPixelFormat.RGBAPackedFloat;
                    }
                    else if ((ARB_color_buffer_float || ATI_pixel_format_float) && colorType == WGLColorType.TYPE_RGBA_FLOAT_ARB)
                    {
                        pixelFormat = ContextPixelFormat.RGBAFloat;
                    }
                    else if (colorType == WGLColorType.TYPE_RGBA_ARB)
                    {
                        pixelFormat = ContextPixelFormat.RGBA;
                    }
                    else
                    {
                        continue;
                    }

                    // FIXME: Add this as a parameter.
                    if ((WGLAcceleration)FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.ACCELERATION_ARB) == WGLAcceleration.NO_ACCELERATION_ARB)
                    {
                        //Logger?.LogWarning("OpenGL context doesn't have hardware acceleration");
                        continue;
                    }

                    WGLSwapMethod wglSwapMethod = (WGLSwapMethod)FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.SWAP_METHOD_ARB);
                    ContextSwapMethod swapMethod;
                    if (wglSwapMethod == WGLSwapMethod.SWAP_UNDEFINED_ARB)
                    {
                        swapMethod = ContextSwapMethod.Undefined;
                    }
                    else if (wglSwapMethod == WGLSwapMethod.SWAP_EXCHANGE_ARB)
                    {
                        swapMethod = ContextSwapMethod.Exchange;
                    }
                    else if (wglSwapMethod == WGLSwapMethod.SWAP_COPY_ARB)
                    {
                        swapMethod = ContextSwapMethod.Copy;
                    }
                    else
                    {
                        Logger?.LogWarning($"Unknown swap method {wglSwapMethod}, using ContextSwapMethod.Undefined.");
                        swapMethod = ContextSwapMethod.Undefined;
                    }


                    if ((WGLSwapMethod)FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.SWAP_METHOD_ARB) == WGLSwapMethod.SWAP_UNDEFINED_ARB)
                    {
                        //Logger?.LogWarning("OpenGL context has undefined swap method");
                    }
                    //Logger?.LogDebug($"Swap method: {(WGLSwapMethod)FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.SWAP_METHOD_ARB)}");

                    // FIXME: Add stereo to this?
                    ContextValues option = default;
                    option.ID = (ulong)i;
                    option.RedBits = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.RED_BITS_ARB);
                    option.GreenBits = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.GREEN_BITS_ARB);
                    option.BlueBits = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.BLUE_BITS_ARB);
                    option.AlphaBits = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.ALPHA_BITS_ARB);
                    option.DepthBits = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.DEPTH_BITS_ARB);
                    option.StencilBits = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.STENCIL_BITS_ARB);
                    option.DoubleBuffered = (FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.DOUBLE_BUFFER_ARB) == 1);
                    if (ARB_framebuffer_sRGB || EXT_framebuffer_sRGB)
                    {
                        option.SRGBFramebuffer = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.FRAMEBUFFER_SRGB_CAPABLE_ARB) == 1;
                    }
                    else if (EXT_colorspace)
                    {
                        option.SRGBFramebuffer = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.COLORSPACE_EXT) == (int)WGLColorspaceEXT.WGL_COLORSPACE_SRGB_EXT;
                    }
                    else
                    {
                        option.SRGBFramebuffer = false;
                    }
                    option.PixelFormat = pixelFormat;
                    option.SwapMethod = swapMethod;
                    option.Samples = ARB_multisample ? FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.SAMPLES_ARB) : 0;
                    possibleContextValues.Add(option);
                }

                // Call user callback and allow them to select the appropriate format!
                int selectedFormatIndex = settings.Selector(possibleContextValues, requested, Logger);
                if (selectedFormatIndex < 0 || selectedFormatIndex >= possibleContextValues.Count)
                {
                    throw new IndexOutOfRangeException($"The selected format index ({selectedFormatIndex}) is outside the range of valid indices. This is either an OpenTK bug or an issue with your custom ContextValueSelector.");
                }

                int selectedFormat = (int)possibleContextValues[selectedFormatIndex].ID;
                success = Wgl.GetPixelFormatAttribivARB(hDC, selectedFormat, 0, contextValueAttrib.Length, contextValueAttrib, contextValues);
                if (success == false)
                {
                    throw new Win32Exception();
                }

                if (FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.DRAW_TO_WINDOW_ARB) == 0)
                {
                    Logger?.LogError("Drawing to window is not supported");
                }

                if (FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.SUPPORT_OPENGL_ARB) == 0)
                {
                    Logger?.LogError("OpneGL is not supported");
                }

                WGLColorType chosenColorType = (WGLColorType)FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.PIXEL_TYPE_ARB);
                ContextPixelFormat chosenPixelFormat;
                if (EXT_pixel_format_packed_float && chosenColorType == WGLColorType.TYPE_RGBA_UNSIGNED_FLOAT_EXT)
                {
                    chosenPixelFormat = ContextPixelFormat.RGBAPackedFloat;
                }
                else if ((ARB_color_buffer_float || ATI_pixel_format_float) && chosenColorType == WGLColorType.TYPE_RGBA_FLOAT_ARB)
                {
                    chosenPixelFormat = ContextPixelFormat.RGBAFloat;
                }
                else if (chosenColorType == WGLColorType.TYPE_RGBA_ARB)
                {
                    chosenPixelFormat = ContextPixelFormat.RGBA;
                }
                else
                {
                    Logger?.LogError("OpenGL context pixel type is not RGBA");
                    chosenPixelFormat = ContextPixelFormat.RGBA;
                }

                if ((WGLAcceleration)FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.ACCELERATION_ARB) == WGLAcceleration.NO_ACCELERATION_ARB)
                {
                    Logger?.LogWarning("OpenGL context doesn't have hardware acceleration");
                }

                WGLSwapMethod chosenWglSwapMethod = (WGLSwapMethod)FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.SWAP_METHOD_ARB);
                ContextSwapMethod chosenSwapMethod;
                if (chosenWglSwapMethod == WGLSwapMethod.SWAP_UNDEFINED_ARB)
                {
                    chosenSwapMethod = ContextSwapMethod.Undefined;
                }
                else if (chosenWglSwapMethod == WGLSwapMethod.SWAP_EXCHANGE_ARB)
                {
                    chosenSwapMethod = ContextSwapMethod.Exchange;
                }
                else if (chosenWglSwapMethod == WGLSwapMethod.SWAP_COPY_ARB)
                {
                    chosenSwapMethod = ContextSwapMethod.Copy;
                }
                else
                {
                    Logger?.LogWarning($"Unknown swap method {chosenWglSwapMethod}, using ContextSwapMethod.Undefined.");
                    chosenSwapMethod = ContextSwapMethod.Undefined;
                }

                bool chosenSRGB = false;
                if (ARB_framebuffer_sRGB || EXT_framebuffer_sRGB)
                {
                    chosenSRGB = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.FRAMEBUFFER_SRGB_CAPABLE_ARB) == 1;
                }
                else if (EXT_colorspace)
                {
                    chosenSRGB = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.COLORSPACE_EXT) == (int)WGLColorspaceEXT.WGL_COLORSPACE_SRGB_EXT;
                }

                ContextValues chosenValues;
                chosenValues.ID = (ulong)selectedFormat;
                chosenValues.RedBits = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.RED_BITS_ARB);
                chosenValues.GreenBits = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.GREEN_BITS_ARB);
                chosenValues.BlueBits = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.BLUE_BITS_ARB);
                chosenValues.AlphaBits = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.ALPHA_BITS_ARB);
                chosenValues.DepthBits = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.DEPTH_BITS_ARB);
                chosenValues.StencilBits = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.STENCIL_BITS_ARB);
                chosenValues.DoubleBuffered = FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.DOUBLE_BUFFER_ARB) == 1;
                chosenValues.SRGBFramebuffer = chosenSRGB;
                chosenValues.PixelFormat = chosenPixelFormat;
                chosenValues.SwapMethod = chosenSwapMethod;
                chosenValues.Samples = ARB_multisample ? FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.SAMPLES_ARB) : 0;

                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < contextValueAttrib.Length; j++)
                {
                    sb.AppendLine($"{contextValueAttrib[j]}: {contextValues[j]}");
                }
                Logger?.LogDebug($"===== Chosen Format ARB =====\n{sb}");

                Logger?.LogDebug($"ContextValues: {chosenValues}");

                Win32.PIXELFORMATDESCRIPTOR pfd = Win32.PIXELFORMATDESCRIPTOR.Create();
                pfd = new Win32.PIXELFORMATDESCRIPTOR()
                {
                    nSize = pfd.nSize,
                    nVersion = 1,
                    dwFlags = PFD.DRAW_TO_WINDOW | PFD.SUPPORT_OPENGL | PFD.DOUBLEBUFFER,
                    iPixelType = PFDType.TYPE_RGBA,
                    cColorBits = (byte)(chosenValues.RedBits +
                                        chosenValues.GreenBits +
                                        chosenValues.BlueBits +
                                        chosenValues.AlphaBits),
                    cRedBits = 0,
                    cRedShift = 0,
                    cGreenBits = 0,
                    cGreenShift = 0,
                    cBlueBits = 0,
                    cBlueShift = 0,
                    cAlphaBits = 0,
                    cAlphaShift = 0,
                    cAccumBits = 0,
                    cAccumRedBits = 0,
                    cAccumGreenBits = 0,
                    cAccumBlueBits = 0,
                    cAccumAlphaBits = 0,
                    cDepthBits = (byte)chosenValues.DepthBits,
                    cStencilBits = (byte)chosenValues.StencilBits,
                    cAuxBuffers = 0,
                    iLayerType = PFDPlane.MAIN,
                    bReserved = 0,
                    dwLayerMask = 0,
                    dwVisibleMask = 0,
                    dwDamageMask = 0,
                };

                success = Win32.SetPixelFormat(hDC, selectedFormat, in pfd);
                if (success == false)
                {
                    throw new Win32Exception();
                }

                Logger?.LogDebug("Got pixel format from wgl_arb_pixel_format");
            }
            else
            {
                int numberOfFormats = Win32.DescribePixelFormat(hDC, 0, (uint)Marshal.SizeOf<Win32.PIXELFORMATDESCRIPTOR>(), ref Unsafe.NullRef<Win32.PIXELFORMATDESCRIPTOR>());
                if (numberOfFormats == 0)
                {
                    throw new Win32Exception();
                }

                List<ContextValues> possibleContextValues = new List<ContextValues>(numberOfFormats);
                for (int i = 1; i <= numberOfFormats; i++)
                {
                    Win32.PIXELFORMATDESCRIPTOR pfd = Win32.PIXELFORMATDESCRIPTOR.Create();
                    int ret = Win32.DescribePixelFormat(hDC, i, (uint)Marshal.SizeOf<Win32.PIXELFORMATDESCRIPTOR>(), ref pfd);
                    if (ret == 0)
                    {
                        throw new Win32Exception();
                    }

                    if (pfd.dwFlags.HasFlag(PFD.DRAW_TO_WINDOW) == false)
                    {
                        continue;
                    }

                    if (pfd.dwFlags.HasFlag(PFD.SUPPORT_OPENGL) == false)
                    {
                        continue;
                    }

                    if (pfd.dwFlags.HasFlag(PFD.NEED_SYSTEM_PALETTE) || pfd.dwFlags.HasFlag(PFD.NEED_PALETTE))
                    {
                        continue;
                    }

                    ContextValues option;
                    option.ID = (ulong)i;
                    option.RedBits = pfd.cRedBits;
                    option.GreenBits = pfd.cGreenBits;
                    option.BlueBits = pfd.cBlueBits;
                    option.AlphaBits = pfd.cAlphaBits;
                    option.DepthBits = pfd.cDepthBits;
                    option.StencilBits = pfd.cStencilBits;
                    option.DoubleBuffered = pfd.dwFlags.HasFlag(PFD.DOUBLEBUFFER);
                    option.SRGBFramebuffer = false;
                    option.PixelFormat = ContextPixelFormat.RGBA;
                    option.SwapMethod = ContextSwapMethod.Undefined;
                    option.Samples = 0;
                    possibleContextValues.Add(option);
                }

                // Call user callback and allow them to select the appropriate format!
                int selectedFormat = settings.Selector(possibleContextValues, requested, Logger);
                if (selectedFormat < 0 || selectedFormat >= numberOfFormats)
                {
                    throw new IndexOutOfRangeException($"The selected format ID ({selectedFormat}) is outside the range of valid IDs.");
                }

                Win32.PIXELFORMATDESCRIPTOR chosenFormat = default;
                int maxFormat = Win32.DescribePixelFormat(hDC, selectedFormat, (uint)Marshal.SizeOf<Win32.PIXELFORMATDESCRIPTOR>(), ref chosenFormat);
                if (maxFormat == 0)
                {
                    throw new Win32Exception();
                }
                JsonSerializerOptions opt2 = new JsonSerializerOptions()
                {
                    IncludeFields = true,
                    WriteIndented = true,
                    TypeInfoResolver = PixelformatDescriptorSourceGenerationContext.Default,
                };
                Logger?.LogDebug($"=== Chosen Format ===\n" +
                    $"Version: {chosenFormat.nVersion}\n" +
                    $"Flags: {chosenFormat.dwFlags} ({Convert.ToString((uint)chosenFormat.dwFlags, 2)})\n" +
                    $"Pixel Type: {chosenFormat.iPixelType}\n" +
                    $"Color bits: {chosenFormat.cColorBits}\n" +
                    $"Depth bits: {chosenFormat.cDepthBits}\n" +
                    $"Stencil bits: {chosenFormat.cStencilBits}\n" +
                    $"Full desc: {JsonSerializer.Serialize(chosenFormat, chosenFormat.GetType(), new PixelformatDescriptorSourceGenerationContext(opt2))}");

                success = Win32.SetPixelFormat(hDC, selectedFormat, in chosenFormat);
                if (success == false)
                {
                    throw new Win32Exception();
                }

                Logger?.LogDebug("Got pixel format from DescribePixelFormat");
            }

            IntPtr hGLRC;
            unsafe
            {
                if (Wgl._CreateContextAttribsARB__fnptr != null)
                {
                    const int WGL_CONTEXT_DEBUG_BIT_ARB = 0x0001;
                    const int WGL_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB = 0x0002;
                    const int WGL_CONTEXT_ROBUST_ACCESS_BIT_ARB = 0x00000004;
                    const int WGL_CONTEXT_RESET_ISOLATION_BIT_ARB = 0x00000008;

                    const int WGL_CONTEXT_CORE_PROFILE_BIT_ARB = 0x1;
                    const int WGL_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB = 0x2;

                    const int WGL_NO_RESET_NOTIFICATION_ARB = 0x8261;
                    const int WGL_LOSE_CONTEXT_ON_RESET_ARB = 0x8252;

                    const int WGL_CONTEXT_RELEASE_BEHAVIOR_NONE_ARB = 0x0000;
                    const int WGL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_ARB = 0x2098;

                    int flags = 0;
                    if (settings.DebugFlag) flags |= WGL_CONTEXT_DEBUG_BIT_ARB;
                    if (settings.ForwardCompatibleFlag) flags |= WGL_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB;
                    if (ARB_create_context_robustness && settings.RobustnessFlag) flags |= WGL_CONTEXT_ROBUST_ACCESS_BIT_ARB;
                    if (ARB_robustness_application_isolation && settings.ResetIsolation) flags |= WGL_CONTEXT_RESET_ISOLATION_BIT_ARB;
                    
                    int profile = 0;
                    switch (settings.Profile)
                    {
                        case OpenGLProfile.None:
                            break;
                        case OpenGLProfile.Core:
                            profile = WGL_CONTEXT_CORE_PROFILE_BIT_ARB;
                            break;
                        case OpenGLProfile.Compatibility:
                            profile = WGL_CONTEXT_CORE_PROFILE_BIT_ARB | WGL_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB;
                            break;
                        default:
                            break;
                    }

                    List<int> attribs = new List<int>();

                    attribs.Add((int)WGLContextAttribs.CONTEXT_MAJOR_VERSION_ARB);
                    attribs.Add(settings.Version.Major);

                    attribs.Add((int)WGLContextAttribs.CONTEXT_MINOR_VERSION_ARB);
                    attribs.Add(settings.Version.Minor);

                    if (flags != 0)
                    {
                        attribs.Add((int)WGLContextAttribs.CONTEXT_FLAGS_ARB);
                        attribs.Add(flags);
                    }

                    if (profile != 0)
                    {
                        attribs.Add((int)WGLContextAttribs.CONTEXT_PROFILE_MASK_ARB);
                        attribs.Add(profile);
                    }

                    if (ARB_create_context_robustness && settings.RobustnessFlag)
                    {
                        attribs.Add((int)WGLContextAttribs.CONTEXT_RESET_NOTIFICATION_STRATEGY_ARB);
                        switch (settings.ResetNotificationStrategy)
                        {
                            case ContextResetNotificationStrategy.NoResetNotification:
                                attribs.Add(WGL_NO_RESET_NOTIFICATION_ARB);
                                break;
                            case ContextResetNotificationStrategy.LoseContextOnReset:
                                attribs.Add(WGL_LOSE_CONTEXT_ON_RESET_ARB);
                                break;
                            default:
                                throw new InvalidEnumArgumentException(nameof(settings.ResetNotificationStrategy), (int)settings.ResetNotificationStrategy, settings.ResetNotificationStrategy.GetType());
                        }
                    }

                    if (ARB_create_context_no_error && settings.NoError)
                    {
                        attribs.Add((int)WGLContextAttribs.CONTEXT_OPENGL_NO_ERROR_ARB);
                        attribs.Add(1);
                    }

                    if (ARB_context_flush_control && settings.UseFlushControl)
                    {
                        attribs.Add((int)WGLContextAttribs.CONTEXT_RELEASE_BEHAVIOR_ARB);
                        switch (settings.ReleaseBehaviour)
                        {
                            case ContextReleaseBehaviour.None:
                                attribs.Add(WGL_CONTEXT_RELEASE_BEHAVIOR_NONE_ARB);
                                break;
                            case ContextReleaseBehaviour.Flush:
                                attribs.Add(WGL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_ARB);
                                break;
                            default:
                                throw new InvalidEnumArgumentException(nameof(settings.ReleaseBehaviour), (int)settings.ReleaseBehaviour, settings.ReleaseBehaviour.GetType());
                        }
                        
                    }

                    IntPtr hshare = hshareContext?.HGlrc ?? IntPtr.Zero;

                    hGLRC = Wgl.CreateContextAttribsARB(hDC, hshare, CollectionsMarshal.AsSpan(attribs));
                    if (hGLRC == IntPtr.Zero)
                    {
                        throw new Win32Exception();
                    }

                    Logger?.LogDebug("Created context using wglCreateContextAttribsARB");
                }
                else
                {
                    // FIXME: We can't share contexts if this happens!
                    if (settings.SharedContext != null)
                    {
                        Logger?.LogError("wglCreateContextAttribsARB not available so we can't create shared contexts.");
                    }
                    
                    hGLRC = Wgl.CreateContext(hDC);
                    if (hGLRC == IntPtr.Zero)
                    {
                        throw new Win32Exception();
                    }

                    Logger?.LogDebug("Created context using wglCreateContext");
                }
            }

            // FIXME: Maybe restore the context that was already there after?
            success = Wgl.MakeCurrent(hDC, hGLRC);
            if (success == false)
            {
                throw new Win32Exception();
            }

            HGLRC hglrc = new HGLRC(hGLRC, hDC, hshareContext);
            HGLRCDict.Add(hGLRC, hglrc);

            return hglrc;
        }

        /// <inheritdoc/>
        public void DestroyContext(OpenGLContextHandle handle)
        {
            HGLRC hglrc = handle.As<HGLRC>(this);

            HGLRCDict.Remove(hglrc.HGlrc);

            bool success = Wgl.DeleteContext(hglrc.HGlrc);
            // FIXME: Do we add back the hglrc to HGLRCDict?
            if (success == false)
            {
                throw new Win32Exception();
            }
        }

        /// <inheritdoc/>
        public IBindingsContext GetBindingsContext(OpenGLContextHandle handle)
        {
            return new Pal2BindingsContext(this, handle);
        }

        /// <inheritdoc/>
        public unsafe IntPtr GetProcedureAddress(OpenGLContextHandle handle, string procedureName)
        {
            HGLRC hglrc = handle.As<HGLRC>(this);

            return (IntPtr)Wgl.GetAnyProcAddress(procedureName);
        }

        /// <inheritdoc/>
        public OpenGLContextHandle? GetCurrentContext()
        {
            IntPtr hGlrc = Wgl.GetCurrentContext();
            if (hGlrc == IntPtr.Zero)
            {
                return null;
            }
            else
            {
                return HGLRCDict[hGlrc];
            }
        }

        /// <inheritdoc/>
        public bool SetCurrentContext(OpenGLContextHandle? handle)
        {
            HGLRC? hglrc = handle?.As<HGLRC>(this);

            if (hglrc == null)
            {
                // Make the hglrc not current
                bool success = Wgl.MakeCurrent(IntPtr.Zero, IntPtr.Zero);
                if (success == false)
                {
                    throw new Win32Exception();
                }
            }
            else
            {
                bool success = Wgl.MakeCurrent(hglrc.HDC, hglrc.HGlrc);

                if (success == false)
                {
                    throw new Win32Exception();
                }
            }

            return true;
        }

        /// <inheritdoc/>
        public OpenGLContextHandle? GetSharedContext(OpenGLContextHandle handle)
        {
            HGLRC hglrc = handle.As<HGLRC>(this);
            return hglrc.SharedContext;
        }

        /// <inheritdoc/>
        public void SetSwapInterval(int interval)
        {
            if (EXT_swap_control)
            {
                Wgl.SwapIntervalEXT(interval);
            }
            else
            {
                Logger?.LogError("Cannot set swap interval. EXT_swap_control not available.");
            }
        }

        /// <inheritdoc/>
        public int GetSwapInterval()
        {
            if (EXT_swap_control)
            {
                return Wgl.GetSwapIntervalEXT();
            }
            else
            {
                Logger?.LogError("Cannot get swap interval. EXT_swap_control not available.");
            }

            // FIXME: We can't get the swap interval. For now we return 0,
            // but we could change it to null if we change the return to int? or
            // make it a Try* function.
            return 0;
        }

        /// <inheritdoc/>
        public void SwapBuffers(OpenGLContextHandle handle)
        {
            HGLRC hglrc = handle.As<HGLRC>(this);

            // Context for DwmFlush() code:
            // https://github.com/glfw/glfw/issues/1072
            // https://github.com/libsdl-org/SDL/issues/5797
            // Relevant glfw source:
            // https://github.com/glfw/glfw/blob/dd8a678a66f1967372e5a5e3deac41ebf65ee127/src/wgl_context.c#L340
            // https://github.com/glfw/glfw/blob/dd8a678a66f1967372e5a5e3deac41ebf65ee127/src/wgl_context.c#L315
            // Source from love2d:
            // https://github.com/love2d/love/blob/5175b0d1b599ea4c7b929f6b4282dd379fa116b8/src/modules/window/sdl/Window.cpp#L1024

            // FIXME: Don't do this for fullscreen windows?
            if (hglrc.UseDwmFlush == true)
            {
                // FIXME: Should we always use
                int result = Win32.DwmIsCompositionEnabled(out bool compositionEnabled);
                if (result != Win32.S_OK)
                {
                    // FIXME: Does Win32Exception take hresult values?
                    throw new Win32Exception(result);
                }

                if (OperatingSystem.IsWindowsVersionAtLeast(6, 2) || compositionEnabled)
                {
                    Win32.DwmFlush();
                }
            }

            bool success = Win32.SwapBuffers(hglrc.HDC);
            if (success == false)
            {
                throw new Win32Exception();
            }
        }

        /// <summary>
        /// Sets whether calls to <see cref="SwapBuffers(OpenGLContextHandle)"/> should use <c>DwmFlush()</c> to sync if DWM compositing is enabled.
        /// This can improve vsync performance on systems with multiple monitors using different refresh rates, but is likely to break in a multi-window scenario.
        /// If using multiple windows, only one window should have this property set.
        ///
        /// By default this value is set to <c>false</c>.
        /// </summary>
        /// <param name="handle">The OpenGL context that should <c>DwmFlush()</c> setting.</param>
        /// <param name="enable">Whether to enable <c>DwmFlush()</c> sync or not.</param>
        public void UseDwmFlushIfApplicable(OpenGLContextHandle handle, bool enable)
        {
            HGLRC hglrc = handle.As<HGLRC>(this);

            hglrc.UseDwmFlush = enable;
        }

        /// <summary>
        /// Gets the win32 <c>HGLRC</c> opengl context handle associated with the context.
        /// This OpenGL context is associated with the window or surface that was used to create this context.
        /// Modifying the context outsite of OpenTK functions may cause side effects when calling OpenTK functions.
        /// </summary>
        /// <param name="handle">The OpenGL context to get the associated win32 <c>HGLRC</c> handle from.</param>
        /// <returns>The native <c>HGLRC</c> context handle.</returns>
        public IntPtr GetHGLRC(OpenGLContextHandle handle)
        {
            HGLRC hglrc = handle.As<HGLRC>(this);

            return hglrc.HGlrc;
        }
    }
}

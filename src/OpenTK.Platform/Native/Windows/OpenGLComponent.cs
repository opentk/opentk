using Microsoft.VisualBasic.FileIO;
using OpenTK.Core.Utility;
using OpenTK.Graphics.Wgl;
using OpenTK.Platform;
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
using Wgl = OpenTK.Graphics.Wgl.Wgl;

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
                WglPointers._wglGetExtensionsStringARB_fnptr = (delegate* unmanaged<IntPtr, byte*>)Wgl.GetProcAddress("wglGetExtensionsStringARB");
                
                WglPointers._wglGetPixelFormatAttribivARB_fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int*, int*, int>)Wgl.GetProcAddress("wglGetPixelFormatAttribivARB");

                WglPointers._wglChoosePixelFormatARB_fnptr = (delegate* unmanaged<IntPtr, int*, float*, uint, int*, uint*, int>)Wgl.GetProcAddress("wglChoosePixelFormatARB");

                WglPointers._wglCreateContextAttribsARB_fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, IntPtr>)Wgl.GetProcAddress("wglCreateContextAttribsARB");

                WglPointers._wglSwapIntervalEXT_fnptr = (delegate* unmanaged<int, int>)Wgl.GetProcAddress("wglSwapIntervalEXT");

                WglPointers._wglGetSwapIntervalEXT_fnptr = (delegate* unmanaged<int>)Wgl.GetProcAddress("wglGetSwapIntervalEXT");

                if (WglPointers._wglGetExtensionsStringARB_fnptr != null)
                {
                    string[] wglExts = Wgl.ARB.GetExtensionsStringARB(hDC)?.Split(" ") ?? Array.Empty<string>();

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

        /// <inheritdoc/>
        public void Uninitialize()
        {
            // Delete all of the OpenGL contexts if there are any left.

            if (HGLRCDict.Count > 0)
            {
                Logger?.LogWarning($"OpenGL contexts still active when uninitializing. Please destroy all contexts before uninitializing.");
            }
            foreach (var (_, hglrc) in HGLRCDict)
            {
                DestroyContext(hglrc);
            }
        }

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
            requested.Stereo = settings.Stereo;

            ContextValues chosenValues;
            if (ARB_pixel_format)
            {
                // We have the pixel format extension!
                Span<PixelFormatAttribute> attrib = stackalloc PixelFormatAttribute[1] { PixelFormatAttribute.NumberPixelFormatsArb };
                int numberOfFormats = 0;
                unsafe
                {
                    success = Wgl.ARB.GetPixelFormatAttribivARB(hDC, 1, 0, 1, attrib, new Span<int>(&numberOfFormats, 1));
                    if (success == false)
                    {
                        throw new Win32Exception();
                    }
                }
                
                List<PixelFormatAttribute> attribList = new List<PixelFormatAttribute>()
                {
                    PixelFormatAttribute.SupportOpenglArb,
                    PixelFormatAttribute.DrawToWindowArb,
                    PixelFormatAttribute.PixelTypeArb,
                    PixelFormatAttribute.AccelerationArb,
                    PixelFormatAttribute.SwapMethodArb,
                    PixelFormatAttribute.DoubleBufferArb,
                    PixelFormatAttribute.StereoArb,
                    PixelFormatAttribute.RedBitsArb,
                    PixelFormatAttribute.GreenBitsArb,
                    PixelFormatAttribute.BlueBitsArb,
                    PixelFormatAttribute.AlphaBitsArb,
                    PixelFormatAttribute.DepthBitsArb,
                    PixelFormatAttribute.StencilBitsArb,
                };

                if (ARB_multisample)
                {
                    attribList.Add(PixelFormatAttribute.SamplesArb);
                }

                if (ARB_framebuffer_sRGB)
                {
                    attribList.Add(PixelFormatAttribute.FramebufferSrgbCapableArb);
                }
                else if (EXT_framebuffer_sRGB)
                {
                    attribList.Add(PixelFormatAttribute.FramebufferSrgbCapableExt);
                }
                else if (EXT_colorspace)
                {
                    attribList.Add(PixelFormatAttribute.ColorspaceExt);
                }

                // Extract the span directly from the list to avoid allocation?
                PixelFormatAttribute[] contextValueAttrib = attribList.ToArray();
                // FIXME: Stack alloc this?
                int[] contextValues = new int[contextValueAttrib.Length];

                // FIXME: Don't always return -1? Pass the default value...
                // Should we throw exceptions for the ones we always expect to get answers to?
                static int FindAttribute(PixelFormatAttribute[] attribs, int[] values, PixelFormatAttribute search)
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
                    success = Wgl.ARB.GetPixelFormatAttribivARB(hDC, i, 0, (uint)contextValueAttrib.Length, contextValueAttrib, contextValues);
                    if (success == false)
                    {
                        throw new Win32Exception();
                    }

                    if (FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.DrawToWindowArb) == 0)
                    {
                        continue;
                    }

                    if (FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.SupportOpenglArb) == 0)
                    {
                        continue;
                    }

                    WGLColorType colorType = (WGLColorType)FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.PixelTypeArb);
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
                    if ((WGLAcceleration)FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.AccelerationArb) == WGLAcceleration.NO_ACCELERATION_ARB)
                    {
                        //Logger?.LogWarning("OpenGL context doesn't have hardware acceleration");
                        continue;
                    }

                    SwapMethod wglSwapMethod = (SwapMethod)FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.SwapMethodArb);
                    ContextSwapMethod swapMethod;
                    if (wglSwapMethod == SwapMethod.SwapUndefinedArb)
                    {
                        swapMethod = ContextSwapMethod.Undefined;
                    }
                    else if (wglSwapMethod == SwapMethod.SwapExchangeArb)
                    {
                        swapMethod = ContextSwapMethod.Exchange;
                    }
                    else if (wglSwapMethod == SwapMethod.SwapCopyArb)
                    {
                        swapMethod = ContextSwapMethod.Copy;
                    }
                    else
                    {
                        Logger?.LogWarning($"Unknown swap method {wglSwapMethod}, using ContextSwapMethod.Undefined.");
                        swapMethod = ContextSwapMethod.Undefined;
                    }


                    if ((SwapMethod)FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.SwapMethodArb) == SwapMethod.SwapUndefinedArb)
                    {
                        //Logger?.LogWarning("OpenGL context has undefined swap method");
                    }
                    //Logger?.LogDebug($"Swap method: {(WGLSwapMethod)FindAttribute(contextValueAttrib, contextValues, WGLPixelFormatAttribute.SWAP_METHOD_ARB)}");

                    
                    ContextValues option;
                    option.ID = (ulong)i;
                    option.RedBits = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.RedBitsArb);
                    option.GreenBits = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.GreenBitsArb);
                    option.BlueBits = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.BlueBitsArb);
                    option.AlphaBits = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.AlphaBitsArb);
                    option.DepthBits = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.DepthBitsArb);
                    option.StencilBits = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.StencilBitsArb);
                    option.DoubleBuffered = (FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.DoubleBufferArb) != 0);
                    if (ARB_framebuffer_sRGB || EXT_framebuffer_sRGB)
                    {
                        option.SRGBFramebuffer = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.FramebufferSrgbCapableArb) != 0;
                    }
                    else if (EXT_colorspace)
                    {
                        option.SRGBFramebuffer = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.ColorspaceExt) == (int)ColorspaceEXT.ColorspaceSrgbExt;
                    }
                    else
                    {
                        option.SRGBFramebuffer = false;
                    }
                    option.PixelFormat = pixelFormat;
                    option.SwapMethod = swapMethod;
                    option.Samples = ARB_multisample ? FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.SamplesArb) : 0;
                    option.SupportsFramebufferTransparency = true;
                    option.Stereo = (FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.StereoArb) != 0);
                    possibleContextValues.Add(option);
                }

                // Call user callback and allow them to select the appropriate format!
                int selectedFormatIndex = settings.Selector(possibleContextValues, requested, Logger);
                if (selectedFormatIndex < 0 || selectedFormatIndex >= possibleContextValues.Count)
                {
                    throw new IndexOutOfRangeException($"The selected format index ({selectedFormatIndex}) is outside the range of valid indices. This is either an OpenTK bug or an issue with your custom ContextValueSelector.");
                }

                int selectedFormat = (int)possibleContextValues[selectedFormatIndex].ID;
                success = Wgl.ARB.GetPixelFormatAttribivARB(hDC, selectedFormat, 0, (uint)contextValueAttrib.Length, contextValueAttrib, contextValues);
                if (success == false)
                {
                    throw new Win32Exception();
                }

                if (FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.DrawToWindowArb) == 0)
                {
                    Logger?.LogError("Drawing to window is not supported");
                }

                if (FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.SupportOpenglArb) == 0)
                {
                    Logger?.LogError("OpneGL is not supported");
                }

                PixelType chosenColorType = (PixelType)FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.PixelTypeArb);
                ContextPixelFormat chosenPixelFormat;
                if (EXT_pixel_format_packed_float && chosenColorType == PixelType.TypeRgbaUnsignedFloatExt)
                {
                    chosenPixelFormat = ContextPixelFormat.RGBAPackedFloat;
                }
                else if ((ARB_color_buffer_float || ATI_pixel_format_float) && chosenColorType == PixelType.TypeRgbaFloatArb)
                {
                    chosenPixelFormat = ContextPixelFormat.RGBAFloat;
                }
                else if (chosenColorType == PixelType.TypeRgbaArb)
                {
                    chosenPixelFormat = ContextPixelFormat.RGBA;
                }
                else
                {
                    Logger?.LogError("OpenGL context pixel type is not RGBA");
                    chosenPixelFormat = ContextPixelFormat.RGBA;
                }

                if ((AccelerationType)FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.AccelerationArb) == AccelerationType.NoAccelerationArb)
                {
                    Logger?.LogWarning("OpenGL context doesn't have hardware acceleration");
                }

                SwapMethod chosenWglSwapMethod = (SwapMethod)FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.SwapMethodArb);
                ContextSwapMethod chosenSwapMethod;
                if (chosenWglSwapMethod == SwapMethod.SwapUndefinedArb)
                {
                    chosenSwapMethod = ContextSwapMethod.Undefined;
                }
                else if (chosenWglSwapMethod == SwapMethod.SwapExchangeArb)
                {
                    chosenSwapMethod = ContextSwapMethod.Exchange;
                }
                else if (chosenWglSwapMethod == SwapMethod.SwapCopyArb)
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
                    chosenSRGB = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.FramebufferSrgbCapableArb) != 0;
                }
                else if (EXT_colorspace)
                {
                    chosenSRGB = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.ColorspaceExt) == (int)ColorspaceEXT.ColorspaceSrgbExt;
                }

                chosenValues.ID = (ulong)selectedFormat;
                chosenValues.RedBits = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.RedBitsArb);
                chosenValues.GreenBits = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.GreenBitsArb);
                chosenValues.BlueBits = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.BlueBitsArb);
                chosenValues.AlphaBits = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.AlphaBitsArb);
                chosenValues.DepthBits = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.DepthBitsArb);
                chosenValues.StencilBits = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.StencilBitsArb);
                chosenValues.DoubleBuffered = FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.DoubleBufferArb) != 0;
                chosenValues.SRGBFramebuffer = chosenSRGB;
                chosenValues.PixelFormat = chosenPixelFormat;
                chosenValues.SwapMethod = chosenSwapMethod;
                chosenValues.Samples = ARB_multisample ? FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.SamplesArb) : 0;
                chosenValues.SupportsFramebufferTransparency = true;
                chosenValues.Stereo = (FindAttribute(contextValueAttrib, contextValues, PixelFormatAttribute.StereoArb) != 0);

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
                    option.SupportsFramebufferTransparency = true;
                    option.Stereo = pfd.dwFlags.HasFlag(PFD.STEREO);
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

                chosenValues.ID = (ulong)selectedFormat;
                chosenValues.RedBits = chosenFormat.cRedBits;
                chosenValues.GreenBits = chosenFormat.cGreenBits;
                chosenValues.BlueBits = chosenFormat.cBlueBits;
                chosenValues.AlphaBits = chosenFormat.cAlphaBits;
                chosenValues.DepthBits = chosenFormat.cDepthBits;
                chosenValues.StencilBits = chosenFormat.cStencilBits;
                chosenValues.DoubleBuffered = chosenFormat.dwFlags.HasFlag(PFD.DOUBLEBUFFER);
                chosenValues.SRGBFramebuffer = false;
                chosenValues.PixelFormat = ContextPixelFormat.RGBA;
                chosenValues.SwapMethod = ContextSwapMethod.Undefined;
                chosenValues.Samples = 0;
                chosenValues.SupportsFramebufferTransparency = true;
                chosenValues.Stereo = chosenFormat.dwFlags.HasFlag(PFD.STEREO);

                Logger?.LogDebug("Got pixel format from DescribePixelFormat");
            }

            IntPtr hGLRC;
            unsafe
            {
                if (WglPointers._wglCreateContextAttribsARB_fnptr != null)
                {
                    ContextFlagsMask flags = 0;
                    if (settings.DebugFlag) flags |= ContextFlagsMask.ContextDebugBitArb;
                    if (settings.ForwardCompatibleFlag) flags |= ContextFlagsMask.ContextForwardCompatibleBitArb;
                    if (ARB_create_context_robustness && settings.RobustnessFlag) flags |= ContextFlagsMask.ContextRobustAccessBitArb;
                    if (ARB_robustness_application_isolation && settings.ResetIsolationFlag) flags |= ContextFlagsMask.ContextResetIsolationBitArb;

                    ContextProfileMask profile = 0;
                    switch (settings.Profile)
                    {
                        case OpenGLProfile.None:
                            break;
                        case OpenGLProfile.Core:
                            profile = ContextProfileMask.ContextCoreProfileBitArb;
                            break;
                        case OpenGLProfile.Compatibility:
                            profile = ContextProfileMask.ContextCompatibilityProfileBitArb;
                            break;
                        default:
                            break;
                    }

                    List<ContextAttribs> attribs = new List<ContextAttribs>();

                    attribs.Add(ContextAttribs.ContextMajorVersionArb);
                    attribs.Add((ContextAttribs)settings.Version.Major);

                    attribs.Add(ContextAttribs.ContextMinorVersionArb);
                    attribs.Add((ContextAttribs)settings.Version.Minor);

                    if (flags != 0)
                    {
                        attribs.Add(ContextAttribs.ContextFlagsArb);
                        attribs.Add((ContextAttribs)flags);
                    }

                    if (profile != 0)
                    {
                        attribs.Add(ContextAttribs.ContextProfileMaskArb);
                        attribs.Add((ContextAttribs)profile);
                    }

                    if (ARB_create_context_robustness && settings.RobustnessFlag)
                    {
                        attribs.Add(ContextAttribs.ContextResetNotificationStrategyArb);
                        switch (settings.ResetNotificationStrategy)
                        {
                            case ContextResetNotificationStrategy.NoResetNotification:
                                attribs.Add((ContextAttribs)Graphics.Wgl.ContextResetNotificationStrategy.NoResetNotificationArb);
                                break;
                            case ContextResetNotificationStrategy.LoseContextOnReset:
                                attribs.Add((ContextAttribs)Graphics.Wgl.ContextResetNotificationStrategy.LoseContextOnResetArb);
                                break;
                            default:
                                throw new InvalidEnumArgumentException(nameof(settings.ResetNotificationStrategy), (int)settings.ResetNotificationStrategy, settings.ResetNotificationStrategy.GetType());
                        }
                    }

                    if (ARB_create_context_no_error && settings.NoErrorFlag)
                    {
                        attribs.Add(ContextAttribs.ContextOpenglNoErrorArb);
                        attribs.Add((ContextAttribs)1);
                    }

                    if (ARB_context_flush_control && settings.UseFlushControl)
                    {
                        attribs.Add(ContextAttribs.ContextReleaseBehaviorArb);
                        switch (settings.ReleaseBehaviour)
                        {
                            case ContextReleaseBehaviour.None:
                                attribs.Add((ContextAttribs)ContextReleaseBehavior.ContextReleaseBehaviorNoneArb);
                                break;
                            case ContextReleaseBehaviour.Flush:
                                attribs.Add((ContextAttribs)ContextReleaseBehavior.ContextReleaseBehaviorFlushArb);
                                break;
                            default:
                                throw new InvalidEnumArgumentException(nameof(settings.ReleaseBehaviour), (int)settings.ReleaseBehaviour, settings.ReleaseBehaviour.GetType());
                        }
                        
                    }

                    IntPtr hshare = hshareContext?.HGlrc ?? IntPtr.Zero;

                    hGLRC = Wgl.ARB.CreateContextAttribsARB(hDC, hshare, CollectionsMarshal.AsSpan(attribs));
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

            HGLRC hglrc = new HGLRC(hGLRC, hDC, hwnd, hshareContext, chosenValues);
            HGLRCDict.Add(hGLRC, hglrc);

            hwnd.OpenGLContextHandle = hglrc;

            return hglrc;
        }

        /// <inheritdoc/>
        public void DestroyContext(OpenGLContextHandle handle)
        {
            HGLRC hglrc = handle.As<HGLRC>(this);

            HGLRCDict.Remove(hglrc.HGlrc);

            if (hglrc.WindowHandle != null)
            {
                hglrc.WindowHandle.OpenGLContextHandle = null;
            }

            bool success = Wgl.DeleteContext(hglrc.HGlrc);
            // FIXME: Do we add back the hglrc to HGLRCDict?
            if (success == false)
            {
                throw new Win32Exception();
            }
        }

        /// <inheritdoc/>
        public ContextValues GetContextValues(OpenGLContextHandle handle)
        {
            HGLRC hglrc = handle.As<HGLRC>(this);

            return hglrc.ContextValues;
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

            return (IntPtr)GetAnyProcAddress(procedureName);

            static unsafe IntPtr GetAnyProcAddress(string procName)
            {
                IntPtr p = Wgl.GetProcAddress(procName);
                if (p == 0 || (p == 0x1) || (p == 0x2) || (p == 0x3) || (p == -1))
                {
                    // FIXME: Make this only load this once?
                    IntPtr module = Win32.LoadLibrary("opengl32.dll");
                    p = Win32.GetProcAddress(module, procName);
                }

                return p;
            }
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
                Wgl.EXT.SwapIntervalEXT(interval);
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
                return Wgl.EXT.GetSwapIntervalEXT();
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

        /// <inheritdoc/>
        public WindowHandle? GetWindow(OpenGLContextHandle handle)
        {
            HGLRC hglrc = handle.As<HGLRC>(this);
            return hglrc.WindowHandle;
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

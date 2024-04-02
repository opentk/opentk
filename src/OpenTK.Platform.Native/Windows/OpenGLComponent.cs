using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace OpenTK.Platform.Native.Windows
{
    public class OpenGLComponent : IOpenGLComponent
    {
        /// <inheritdoc/>
        public string Name => "Win32OpenGL";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.OpenGL;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.OpenGL)
            {
                throw new Exception("OpenGLComponent can only initialize the OpenGL component.");
            }

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
            Console.WriteLine($"=== Chosen Format ===");
            Console.WriteLine($"Version: {chosenFormat.nVersion}");
            Console.WriteLine($"Flags: {chosenFormat.dwFlags} ({Convert.ToString((uint)chosenFormat.dwFlags, 2)})");
            Console.WriteLine($"Pixel Type: {chosenFormat.iPixelType}");
            Console.WriteLine($"Color bits: {chosenFormat.cColorBits}");
            Console.WriteLine($"Depth bits: {chosenFormat.cDepthBits}");
            Console.WriteLine($"Stencil bits: {chosenFormat.cStencilBits}");
            JsonSerializerOptions opt2 = new JsonSerializerOptions()
            {
                IncludeFields = true,
                WriteIndented = true,
            };
            Console.WriteLine($"Full desc: {JsonSerializer.Serialize(chosenFormat, chosenFormat.GetType(), opt2)}");

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
                    ARB_create_context = wglExts.Contains("WGL_ARB_create_context");
                    ARB_create_context_profile = wglExts.Contains("WGL_ARB_create_context_profile");
                    ARB_create_context_es2_profile = wglExts.Contains("WGL_EXT_create_context_es2_profile");
                    ARB_create_context_robustness = wglExts.Contains("WGL_ARB_create_context_robustness");
                    ARB_create_context_no_error = wglExts.Contains("WGL_ARB_create_context_no_error");
                    EXT_swap_control = wglExts.Contains("WGL_EXT_swap_control");
                    EXT_colorspace = wglExts.Contains("WGL_EXT_colorspace");
                    ARB_pixel_format = wglExts.Contains("WGL_ARB_pixel_format");
                    ARB_context_flush_control = wglExts.Contains("WGL_ARB_context_flush_control");

                    foreach (var ext in wglExts)
                    {
                        Console.WriteLine($"wglExts: {ext}");
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

        // FIXME: Which ones of these do we care about?

        internal static bool ARB_multisample { get; set; }

        internal static bool ARB_framebuffer_sRGB { get; set; }

        internal static bool EXT_framebuffer_sRGB { get; set; }

        internal static bool ARB_create_context { get; set; }

        internal static bool ARB_create_context_profile { get; set; }

        internal static bool ARB_create_context_es2_profile { get; set; }

        internal static bool ARB_create_context_robustness { get; set; }

        internal static bool ARB_create_context_no_error { get; set; }

        internal static bool EXT_swap_control { get; set; }

        internal static bool EXT_colorspace { get; set; }

        internal static bool ARB_pixel_format { get; set; }

        internal static bool ARB_context_flush_control { get; set; }

        #endregion

        /// <inheritdoc/>
        public bool CanShareContexts => true;

        /// <inheritdoc/>
        public bool CanCreateFromWindow => true;

        /// <inheritdoc/>
        public bool CanCreateFromSurface => throw new NotImplementedException();

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
                case ContextDepthBits.Depth24: depthBits = 24; break;
                case ContextDepthBits.Depth32: depthBits = 32; break;
                default: throw new InvalidEnumArgumentException(nameof(settings.DepthBits), (int)settings.DepthBits, settings.DepthBits.GetType());
            }

            byte stencilBits;
            switch (settings.StencilBits)
            {
                case ContextStencilBits.Stencil1: stencilBits = 1; break;
                case ContextStencilBits.Stencil8: stencilBits = 8; break;
                default: throw new InvalidEnumArgumentException(nameof(settings.StencilBits), (int)settings.StencilBits, settings.StencilBits.GetType());
            }

            if (ARB_pixel_format)
            {
                // We have the pixel format extension!
                WGLPixelFormatAttribute[] attrib = new WGLPixelFormatAttribute[1] { WGLPixelFormatAttribute.NUMBER_PIXEL_FORMATS_ARB };
                int[] values = new int[1];
                success = Wgl.GetPixelFormatAttribivARB(hDC, 1, 0, 1, attrib, values);
                if (success == false)
                {
                    throw new Win32Exception();
                }

                int numberOfFormats = values[0];

                List<int> attribs = new List<int>();
                attribs.Add((int)WGLPixelFormatAttribute.ACCELERATION_ARB);
                attribs.Add((int)WGLAcceleration.FULL_ACCELERATION_ARB);

                attribs.Add((int)WGLPixelFormatAttribute.DRAW_TO_WINDOW_ARB);
                attribs.Add(1);

                attribs.Add((int)WGLPixelFormatAttribute.RED_BITS_ARB);
                attribs.Add(settings.RedColorBits);

                attribs.Add((int)WGLPixelFormatAttribute.GREEN_BITS_ARB);
                attribs.Add(settings.GreenColorBits);

                attribs.Add((int)WGLPixelFormatAttribute.BLUE_BITS_ARB);
                attribs.Add(settings.BlueColorBits);

                attribs.Add((int)WGLPixelFormatAttribute.ALPHA_BITS_ARB);
                attribs.Add(settings.AlphaColorBits);

                if (settings.DoubleBuffer)
                {
                    attribs.Add((int)WGLPixelFormatAttribute.DOUBLE_BUFFER_ARB);
                    attribs.Add(1);
                }

                if (depthBits > 0)
                {
                    attribs.Add((int)WGLPixelFormatAttribute.DEPTH_BITS_ARB);
                    attribs.Add(depthBits);
                }

                if (stencilBits > 0)
                {
                    attribs.Add((int)WGLPixelFormatAttribute.STENCIL_BITS_ARB);
                    attribs.Add(stencilBits);
                }

                // FIXME: Figure out if 0 or 1 means no MSAA
                if (settings.Multisamples > 0 && ARB_multisample)
                {
                    attribs.Add((int)WGLPixelFormatAttribute.SAMPLES_ARB);
                    attribs.Add(settings.Multisamples);
                }

                if (ARB_framebuffer_sRGB)
                {
                    attribs.Add((int)WGLPixelFormatAttribute.FRAMEBUFFER_SRGB_CAPABLE_ARB);
                    attribs.Add(settings.sRGBFramebuffer ? 1 : 0);
                }
                attribs.Add(0);

                int[] formats = new int[1];
                success = Wgl.ChoosePixelFormatARB(hDC, attribs.ToArray(), null, formats.Length, formats, out int numFormats);
                if (success == false || numFormats == 0)
                {
                    throw new NotImplementedException("FIXME: Relax requirements and try again!");
                }

                int choosenFormat = formats[0];

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

                attrib = attribList.ToArray();
                values = new int[attrib.Length];

                int FindAttribute(WGLPixelFormatAttribute search)
                {
                    for (int i = 0; i < attrib.Length; i++)
                    {
                        if (attrib[i] == search)
                        {
                            return values[i];
                        }
                    }

                    return -1;
                }

                success = Wgl.GetPixelFormatAttribivARB(hDC, choosenFormat, 0, attrib.Length, attrib, values);
                if (success == false)
                {
                    throw new Win32Exception();
                }

                if (FindAttribute(WGLPixelFormatAttribute.DRAW_TO_WINDOW_ARB) == 0)
                {
                    Logger?.LogError("Drawing to window is not supported");
                }

                if (FindAttribute(WGLPixelFormatAttribute.SUPPORT_OPENGL_ARB) == 0)
                {
                    Logger?.LogError("OpneGL is not supported");
                }

                if ((WGLColorType)FindAttribute(WGLPixelFormatAttribute.PIXEL_TYPE_ARB) != WGLColorType.TYPE_RGBA_ARB)
                {
                    Logger?.LogError("OpneGL context pixel type is not RGBA");
                }

                if ((WGLAcceleration)FindAttribute(WGLPixelFormatAttribute.ACCELERATION_ARB) == WGLAcceleration.NO_ACCELERATION_ARB)
                {
                    Logger?.LogWarning("OpenGL context doesn't have hardware acceleration");
                }

                if (FindAttribute(WGLPixelFormatAttribute.DOUBLE_BUFFER_ARB) != (settings.DoubleBuffer ? 1 : 0))
                {
                    Logger?.LogWarning("OpenGL context has no double buffering");
                }

                if ((WGLSwapMethod)FindAttribute(WGLPixelFormatAttribute.SWAP_METHOD_ARB) == WGLSwapMethod.SWAP_UNDEFINED_ARB)
                {
                    Logger?.LogWarning("OpenGL context has undefined swap method");
                }
                Logger?.LogDebug($"Swap method: {(WGLSwapMethod)FindAttribute(WGLPixelFormatAttribute.SWAP_METHOD_ARB)}");

                ContextValues choosenValues = default;

                choosenValues.RedBits = FindAttribute(WGLPixelFormatAttribute.RED_BITS_ARB);
                choosenValues.GreenBits = FindAttribute(WGLPixelFormatAttribute.GREEN_BITS_ARB);
                choosenValues.BlueBits = FindAttribute(WGLPixelFormatAttribute.BLUE_BITS_ARB);
                choosenValues.AlphaBits = FindAttribute(WGLPixelFormatAttribute.ALPHA_BITS_ARB);
                choosenValues.DepthBits = FindAttribute(WGLPixelFormatAttribute.DEPTH_BITS_ARB);
                choosenValues.StencilBits = FindAttribute(WGLPixelFormatAttribute.STENCIL_BITS_ARB);

                choosenValues.Samples = ARB_multisample ? FindAttribute(WGLPixelFormatAttribute.SAMPLES_ARB) : 0;
                choosenValues.Multisample = choosenValues.Samples > 0;

                choosenValues.SRGBFramebuffer = ARB_framebuffer_sRGB ? FindAttribute(WGLPixelFormatAttribute.FRAMEBUFFER_SRGB_CAPABLE_ARB) == 1 : false;

                Console.WriteLine($"===== Chosen Format ARB =====");
                for (int j = 0; j < attrib.Length; j++)
                {
                    Console.WriteLine($"{attrib[j]}: {values[j]}");
                }
                Console.WriteLine();

                Win32.PIXELFORMATDESCRIPTOR pfd = Win32.PIXELFORMATDESCRIPTOR.Create();
                pfd = new Win32.PIXELFORMATDESCRIPTOR()
                {
                    nSize = pfd.nSize,
                    nVersion = 1,
                    dwFlags = PFD.DRAW_TO_WINDOW | PFD.SUPPORT_OPENGL | PFD.DOUBLEBUFFER,
                    iPixelType = PFDType.TYPE_RGBA,
                    cColorBits = (byte)(choosenValues.RedBits +
                                        choosenValues.GreenBits +
                                        choosenValues.BlueBits +
                                        choosenValues.AlphaBits),
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
                    cDepthBits = (byte)choosenValues.DepthBits,
                    cStencilBits = (byte)choosenValues.StencilBits,
                    cAuxBuffers = 0,
                    iLayerType = PFDPlane.MAIN,
                    bReserved = 0,
                    dwLayerMask = 0,
                    dwVisibleMask = 0,
                    dwDamageMask = 0,
                };

                success = Win32.SetPixelFormat(hDC, choosenFormat, in pfd);
                if (success == false)
                {
                    throw new Win32Exception();
                }

                Logger?.LogDebug("Got pixel format from wgl_arb_pixel_format");
            }
            else
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
                    cDepthBits = depthBits,
                    cStencilBits = stencilBits,
                    cAuxBuffers = 0,
                    iLayerType = 0,
                    bReserved = 0,
                    dwLayerMask = 0,
                    dwVisibleMask = 0,
                    dwDamageMask = 0,
                };

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
                Console.WriteLine($"=== Chosen Format ===");
                Console.WriteLine($"Version: {chosenFormat.nVersion}");
                Console.WriteLine($"Flags: {chosenFormat.dwFlags} ({Convert.ToString((uint)chosenFormat.dwFlags, 2)})");
                Console.WriteLine($"Pixel Type: {chosenFormat.iPixelType}");
                Console.WriteLine($"Color bits: {chosenFormat.cColorBits}");
                Console.WriteLine($"Depth bits: {chosenFormat.cDepthBits}");
                Console.WriteLine($"Stencil bits: {chosenFormat.cStencilBits}");
                JsonSerializerOptions opt2 = new JsonSerializerOptions()
                {
                    IncludeFields = true,
                    WriteIndented = true,
                };
                Console.WriteLine($"Full desc: {JsonSerializer.Serialize(chosenFormat, chosenFormat.GetType(), opt2)}");

                success = Win32.SetPixelFormat(hDC, pixelFormatIndex, in chosenFormat);
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

                    const int WGL_CONTEXT_CORE_PROFILE_BIT_ARB = 0x1;
                    const int WGL_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB = 0x2;

                    int flags = 0;
                    if (settings.DebugFlag) flags |= WGL_CONTEXT_DEBUG_BIT_ARB;
                    if (settings.ForwardCompatibleFlag) flags |= WGL_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB;

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
            // FIXME: Maybe implement DWM hack?
            // https://github.com/glfw/glfw/issues/1072
            // https://github.com/libsdl-org/SDL/issues/5797

            // Relevant glfw source:
            // https://github.com/glfw/glfw/blob/dd8a678a66f1967372e5a5e3deac41ebf65ee127/src/wgl_context.c#L340
            // https://github.com/glfw/glfw/blob/dd8a678a66f1967372e5a5e3deac41ebf65ee127/src/wgl_context.c#L315

            // Source from love2d:
            // https://github.com/love2d/love/blob/5175b0d1b599ea4c7b929f6b4282dd379fa116b8/src/modules/window/sdl/Window.cpp#L1024


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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace OpenTK.Core.Platform.Implementations.Windows
{
    public class OpenGLComponent : IOpenGLComponent
    {
        public IntPtr HelperHWnd { get; private set; }

        public string Name => "Win32OpenGL";

        public PalComponents Provides => PalComponents.OpenGL;

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
                cDepthBits = 24, // FIXME: Ability to configure!
                cStencilBits = 8, // FIXME: Ability to configure!
                cAuxBuffers = 0,
                iLayerType = 0,
                bReserved = 0,
                dwLayerMask = 0,
                dwVisibleMask = 0,
                dwDamageMask = 0,
            };

            IntPtr hDC = Win32.GetDC(WindowComponent.HelperHWnd);

            if (hDC == IntPtr.Zero)
            {
                throw new Win32Exception("GetDC failed");
            }
            uint nBytes;
            unchecked
            {
                nBytes = (uint)Marshal.SizeOf<Win32.PIXELFORMATDESCRIPTOR>();
            }

            int pixelFormatIndex = Win32.ChoosePixelFormat(hDC, in pfd);
            if (pixelFormatIndex == 0)
            {
                throw new Win32Exception("ChoosePixelFormat failed");
            }

            Win32.PIXELFORMATDESCRIPTOR chosenFormat = default;
            Win32.DescribePixelFormat(hDC, pixelFormatIndex, nBytes, ref chosenFormat);
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
                throw new Win32Exception("SetPixelFormat failed");
            }

            IntPtr hGLRC = Wgl.CreateContext(hDC);
            if (hGLRC == IntPtr.Zero)
            {
                throw new Win32Exception("wglCreateContext failed");
            }

            // FIXME: Maybe restore the context that was already there after?
            success = Wgl.MakeCurrent(hDC, hGLRC);
            if (success == false)
            {
                throw new Win32Exception("wglMakeCurrent failed to make helper context current");
            }

            unsafe
            {
                Wgl._GetExtensionsStringARB__fnptr = (delegate* unmanaged<IntPtr, byte*>)Wgl.GetProcAddress("wglGetExtensionsStringARB");

                Wgl._GetPixelFormatAttribivARB__fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int*, int*, int>)Wgl.GetProcAddress("wglGetPixelFormatAttribivARB");

                Wgl._ChoosePixelFormatARB__fnptr = (delegate* unmanaged<IntPtr, int*, float*, uint, int*, uint*, int>)Wgl.GetProcAddress("wglChoosePixelFormatARB");

                Wgl._CreateContextAttribsARB__fnptr = (delegate* unmanaged<IntPtr, IntPtr, int*, IntPtr>)Wgl.GetProcAddress("wglCreateContextAttribsARB");

                if (Wgl._GetExtensionsStringARB__fnptr != null)
                {
                    string[] wglExts = Wgl.GetExtensionsStringARB(hDC).Split(" ");

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
                throw new Win32Exception("wglDeleteContext failed for helper window");
            }
        }

        internal static readonly Dictionary<IntPtr, HGLRC> HGLRCDict = new Dictionary<IntPtr, HGLRC>();

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

        public bool CanShareContexts => throw new NotImplementedException();

        public bool CanCreateFromWindow => true;

        public bool CanCreateFromSurface => throw new NotImplementedException();

        public OpenGLContextHandle CreateFromSurface()
        {
            throw new NotImplementedException();
        }

        public OpenGLContextHandle CreateFromWindow(WindowHandle handle, ContextSettings settings)
        {
            HWND hwnd = handle.As<HWND>(this);
            bool success;

            IntPtr hDC = Win32.GetDC(hwnd.HWnd);
            if (hDC == IntPtr.Zero)
            {
                throw new Win32Exception("GetDC failed");
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
                    throw new Win32Exception("GetPixelFormatAttribivARB failed to get number of pixel formats");
                }

                int numberOfFormats = values[0];

                List<int> attribs = new List<int>();
                attribs.Add((int)WGLPixelFormatAttribute.ACCELERATION_ARB);
                attribs.Add((int)WGLAcceleration.FULL_ACCELERATION_ARB);

                attribs.Add((int)WGLPixelFormatAttribute.DRAW_TO_WINDOW_ARB);
                attribs.Add(1);

                // FIXME! Settings!
                attribs.Add((int)WGLPixelFormatAttribute.RED_BITS_ARB);
                attribs.Add(8);

                attribs.Add((int)WGLPixelFormatAttribute.GREEN_BITS_ARB);
                attribs.Add(8);

                attribs.Add((int)WGLPixelFormatAttribute.BLUE_BITS_ARB);
                attribs.Add(8);

                // FIXME: Make settings available
                attribs.Add((int)WGLPixelFormatAttribute.ALPHA_BITS_ARB);
                attribs.Add(0);

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

                if (settings.Multisample && ARB_multisample)
                {
                    attribs.Add((int)WGLPixelFormatAttribute.SAMPLES_ARB);
                    attribs.Add(settings.Samples);
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
                    throw new Win32Exception("GetPixelFormatAttribivARB failed");
                }

                if (FindAttribute(WGLPixelFormatAttribute.SUPPORT_OPENGL_ARB) == 0 ||
                    FindAttribute(WGLPixelFormatAttribute.DRAW_TO_WINDOW_ARB) == 0)
                {
                    // FIXME:
                    Console.WriteLine("WARNING: OpenGL or DrawToWindow not supported!");
                }

                if ((WGLColorType)FindAttribute(WGLPixelFormatAttribute.PIXEL_TYPE_ARB) != WGLColorType.TYPE_RGBA_ARB)
                {
                    Console.WriteLine("WARNING: Pixel type is not RGBA");
                }

                if ((WGLAcceleration)FindAttribute(WGLPixelFormatAttribute.ACCELERATION_ARB) == WGLAcceleration.NO_ACCELERATION_ARB)
                {
                    Console.WriteLine("WARNING: No acceleration!");
                }

                if (FindAttribute(WGLPixelFormatAttribute.DOUBLE_BUFFER_ARB) != (settings.DoubleBuffer ? 1 : 0))
                {
                    Console.WriteLine("WARNING: No double buffering!");
                }

                if ((WGLSwapMethod)FindAttribute(WGLPixelFormatAttribute.SWAP_METHOD_ARB) == WGLSwapMethod.SWAP_UNDEFINED_ARB)
                {
                    Console.WriteLine("WARNING: Undefined swap method!");
                }
                Console.WriteLine("Swap method:" + (WGLSwapMethod)values[4]);

                ContextValues choosenValues = default;

                choosenValues.ColorBits =
                        FindAttribute(WGLPixelFormatAttribute.RED_BITS_ARB) +
                        FindAttribute(WGLPixelFormatAttribute.GREEN_BITS_ARB) +
                        FindAttribute(WGLPixelFormatAttribute.BLUE_BITS_ARB) +
                        FindAttribute(WGLPixelFormatAttribute.ALPHA_BITS_ARB);
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
                    cColorBits = (byte)choosenValues.ColorBits,
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
                    throw new Win32Exception("SetPixelFormat failed");
                }

                Console.WriteLine("Got pixel format from wgl_arb_pixel_format");
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
                    throw new Win32Exception("ChoosePixelFormat failed");
                }

                Win32.PIXELFORMATDESCRIPTOR chosenFormat = default;
                Win32.DescribePixelFormat(hDC, pixelFormatIndex, nBytes, ref chosenFormat);
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
                    throw new Win32Exception("SetPixelFormat failed");
                }

                Console.WriteLine("Got pixel format from DescribePixelFormat");
            }

            IntPtr hGLRC;
            unsafe
            {
                if (Wgl._CreateContextAttribsARB__fnptr != null)
                {
                    // FIXME: Shared context!
                    int[] attribs = new int[]
                    {
                        (int)WGLContextAttribs.CONTEXT_MAJOR_VERSION_ARB, 3,
                        (int)WGLContextAttribs.CONTEXT_MINOR_VERSION_ARB, 2,
                        (int)WGLContextAttribs.CONTEXT_FLAGS_ARB, 0x00, // FIXME: context flags!!
                        (int)WGLContextAttribs.CONTEXT_PROFILE_MASK_ARB, 0x01, // Core profile FIXME: Configurable!
                    };

                    hGLRC = Wgl.CreateContextAttribsARB(hDC, IntPtr.Zero, attribs);
                    if (hGLRC == IntPtr.Zero)
                    {
                        throw new Win32Exception("wglCreateContextAttribsARB failed");
                    }

                    Console.WriteLine("Created context using wglCreateContextAttribsARB");
                }
                else
                {
                    hGLRC = Wgl.CreateContext(hDC);
                    if (hGLRC == IntPtr.Zero)
                    {
                        throw new Win32Exception("wglCreateContext failed");
                    }

                    Console.WriteLine("Created context using wglCreateContext");
                }
            }

            // FIXME: Maybe restore the context that was already there after?
            success = Wgl.MakeCurrent(hDC, hGLRC);
            if (success == false)
            {
                throw new Win32Exception("wglMakeCurrent failed to make helper context current");
            }

            HGLRC hglrc = new HGLRC(hGLRC, hDC, this);
            HGLRCDict.Add(hGLRC, hglrc);

            return hglrc;
        }

        public void DestroyContext(OpenGLContextHandle handle)
        {
            HGLRC hglrc = handle.As<HGLRC>(this);

            HGLRCDict.Remove(hglrc.HGlrc);

            bool success = Wgl.DeleteContext(hglrc.HGlrc);

            // FIXME: Do we add back the hglrc to HGLRCDict?
            if (success == false)
            {
                throw new Win32Exception("wglDeleteContext failed");
            }
        }

        public unsafe IntPtr GetProcedureAddress(OpenGLContextHandle handle, string procedureName)
        {
            return (IntPtr)Wgl.GetAnyProcAddress(procedureName);
        }

        public OpenGLContextHandle GetCurrentContext()
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

        public bool SetCurrentContext(OpenGLContextHandle handle)
        {
            HGLRC hglrc = handle?.As<HGLRC>(this);

            if (hglrc == null)
            {
                // Make the hglrc not current
                bool success = Wgl.MakeCurrent(IntPtr.Zero, IntPtr.Zero);

                if (success == false)
                {
                    throw new Win32Exception("wglMakeCurrent failed when unbinding context");
                }
            }
            else
            {
                bool success = Wgl.MakeCurrent(hglrc.HDC, hglrc.HGlrc);

                if (success == false)
                {
                    throw new Win32Exception("wglMakeCurrent failed");
                }
            }

            return true;
        }

        public OpenGLContextHandle GetSharedContext()
        {
            throw new NotImplementedException();
        }

        public OpenGLContextHandle GetSharedContext(OpenGLContextHandle handle)
        {
            throw new NotImplementedException();
        }

        public void SetSharedContext(OpenGLContextHandle handle)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform.Implementations.Windows
{
    public class OpenGLComponent : IOpenGLComponent
    {
        public string Name => "Win32OpenGL";

        public PalComponents Provides => PalComponents.OpenGL;

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.OpenGL)
            {
                throw new Exception("OpenGLComponent can only initialize the OpenGL component.");
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

        public OpenGLContextHandle CreateFromWindow(WindowHandle handle)
        {
            HWND hwnd = handle.As<HWND>(this);

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

            IntPtr hDC = Win32.GetDC(hwnd.HWnd);

            if (hDC == IntPtr.Zero)
            {
                throw new Win32Exception("GetDC failed", Marshal.GetLastWin32Error());
            }
            uint nBytes;
            unchecked
            {
                nBytes = (uint)Marshal.SizeOf<Win32.PIXELFORMATDESCRIPTOR>();
            }

            /**
            int maxPixelFormats = Win32.DescribePixelFormat(hDC, 1, nBytes, ref Unsafe.NullRef<Win32.PIXELFORMATDESCRIPTOR>());
            if (maxPixelFormats == 0)
            {
                throw new Win32Exception("DescribePixelFormat failed to get maximum format index", Marshal.GetLastWin32Error());
            }

            for (int i = 1; i <= maxPixelFormats; i++)
            {
                Win32.PIXELFORMATDESCRIPTOR desc = default;
                Win32.DescribePixelFormat(hDC, i, nBytes, ref desc);

                if (desc.dwFlags.HasFlag(PFD.SUPPORT_OPENGL) == false)
                {
                    continue;
                }

                if (desc.dwFlags.HasFlag(PFD.DRAW_TO_WINDOW) == false)
                {
                    continue;
                }

                Console.WriteLine($"=== Format {i} ===");
                Console.WriteLine($"Version: {desc.nVersion}");
                Console.WriteLine($"Flags: {desc.dwFlags} ({Convert.ToString((uint)desc.dwFlags, 2)})");
                Console.WriteLine($"Pixel Type: {desc.iPixelType}");
                Console.WriteLine($"Color bits: {desc.cColorBits}");
                Console.WriteLine($"Depth bits: {desc.cDepthBits}");
                Console.WriteLine($"Stencil bits: {desc.cStencilBits}");
                JsonSerializerOptions opt = new JsonSerializerOptions()
                {
                    IncludeFields = true,
                    WriteIndented = true,
                };
                Console.WriteLine($"Full desc: {JsonSerializer.Serialize(desc, desc.GetType(), opt)}");
            }
            */
            int pixelFormatIndex = Win32.ChoosePixelFormat(hDC, in pfd);
            if (pixelFormatIndex == 0)
            {
                throw new Win32Exception("ChoosePixelFormat failed", Marshal.GetLastWin32Error());
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

            // FIXME: We can only ever set this format once!!
            // So if we need to support sRGB backbuffers or other more andvanced features we need
            // to create a new window to create a dummy context and query the capabilities.
            bool success = Win32.SetPixelFormat(hDC, pixelFormatIndex, in chosenFormat);
            if (success == false)
            {
                throw new Win32Exception("SetPixelFormat failed", Marshal.GetLastWin32Error());
            }

            IntPtr hGLRC = Wgl.CreateContext(hDC);
            if (hGLRC == IntPtr.Zero)
            {
                throw new Win32Exception("wglCreateContext failed", Marshal.GetLastWin32Error());
            }

            HGLRC hglrc = new HGLRC(hGLRC, hDC, this);
            HGLRCDict.Add(hGLRC, hglrc);

            Wgl.MakeCurrent(hDC, hGLRC);

            unsafe
            {
                Wgl._GetExtensionsStringARB__fnptr = (delegate* unmanaged<IntPtr, byte*>)Wgl.GetProcAddress("wglGetExtensionsStringARB");
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
                throw new Win32Exception("wglDeleteContext failed", Marshal.GetLastWin32Error());
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
                    throw new Win32Exception("wglMakeCurrent failed when unbinding context", Marshal.GetLastWin32Error());
                }
            }
            else
            {
                bool success = Wgl.MakeCurrent(hglrc.HDC, hglrc.HGlrc);

                if (success == false)
                {
                    throw new Win32Exception("wglMakeCurrent failed", Marshal.GetLastWin32Error());
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

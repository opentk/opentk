//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

//  Created by Erik Ylvisaker on 3/17/08.


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.MacOS
{
    #pragma warning disable 0169

    /*
    ** Macintosh device type.
    */
    using AGLDevice = IntPtr;

    /*
    ** Macintosh drawable type.
    */
    using AGLDrawable = IntPtr;

    /*
    ** AGL opaque data.
    */
    using AGLRendererInfo = IntPtr;
    using AGLPixelFormat = IntPtr;
    using AGLContext = IntPtr;
    using AGLPbuffer = IntPtr;

    using GLenum = UInt32;

    internal unsafe static partial class Agl
    {
        private const string agl = "/System/Library/Frameworks/AGL.framework/Versions/Current/AGL";

        /*
         ** AGL API version.
         */
        private const int AGL_VERSION_2_0 =  1;

        /************************************************************************/

        /*
         ** Attribute names for aglChoosePixelFormat and aglDescribePixelFormat.
         */
        internal enum PixelFormatAttribute
        {
            AGL_NONE = 0,
            AGL_ALL_RENDERERS = 1,  /* choose from all available renderers          */
            AGL_BUFFER_SIZE = 2,  /* depth of the index buffer                    */
            AGL_LEVEL = 3,  /* level in plane stacking                      */
            AGL_RGBA = 4,  /* choose an RGBA format                        */
            AGL_DOUBLEBUFFER = 5,  /* double buffering supported                   */
            AGL_STEREO = 6,  /* stereo buffering supported                   */
            AGL_AUX_BUFFERS = 7,  /* number of aux buffers                        */
            AGL_RED_SIZE = 8,  /* number of red component bits                 */
            AGL_GREEN_SIZE = 9,  /* number of green component bits               */
            AGL_BLUE_SIZE = 10,  /* number of blue component bits                */
            AGL_ALPHA_SIZE = 11,  /* number of alpha component bits               */
            AGL_DEPTH_SIZE = 12,  /* number of depth bits                         */
            AGL_STENCIL_SIZE = 13,  /* number of stencil bits                       */
            AGL_ACCUM_RED_SIZE = 14,  /* number of red accum bits                     */
            AGL_ACCUM_GREEN_SIZE = 15,  /* number of green accum bits                   */
            AGL_ACCUM_BLUE_SIZE = 16,  /* number of blue accum bits                    */
            AGL_ACCUM_ALPHA_SIZE = 17,  /* number of alpha accum bits                   */
            AGL_PIXEL_SIZE = 50,
            AGL_MINIMUM_POLICY = 51,
            AGL_MAXIMUM_POLICY = 52,
            AGL_OFFSCREEN = 53,
            AGL_FULLSCREEN = 54,
            AGL_SAMPLE_BUFFERS_ARB = 55,
            AGL_SAMPLES_ARB = 56,
            AGL_AUX_DEPTH_STENCIL = 57,
            AGL_COLOR_FLOAT = 58,
            AGL_MULTISAMPLE = 59,
            AGL_SUPERSAMPLE = 60,
            AGL_SAMPLE_ALPHA = 61,
        }
        /*
         ** Extended attributes
         */
        internal enum ExtendedAttribute
        {
            AGL_PIXEL_SIZE = 50,  /* frame buffer bits per pixel                  */
            AGL_MINIMUM_POLICY = 51,  /* never choose smaller buffers than requested  */
            AGL_MAXIMUM_POLICY = 52,  /* choose largest buffers of type requested     */
            AGL_OFFSCREEN = 53,  /* choose an off-screen capable renderer        */
            AGL_FULLSCREEN = 54,  /* choose a full-screen capable renderer        */
            AGL_SAMPLE_BUFFERS_ARB = 55,  /* number of multi sample buffers               */
            AGL_SAMPLES_ARB = 56,  /* number of samples per multi sample buffer    */
            AGL_AUX_DEPTH_STENCIL = 57,  /* independent depth and/or stencil buffers for the aux buffer */
            AGL_COLOR_FLOAT = 58,  /* color buffers store floating point pixels    */
            AGL_MULTISAMPLE = 59,  /* choose multisample                           */
            AGL_SUPERSAMPLE = 60,  /* choose supersample                           */
            AGL_SAMPLE_ALPHA = 61,  /* request alpha filtering                      */
        }
        /*
         ** Renderer management
         */
        internal enum RendererManagement
        {
            AGL_RENDERER_ID = 70,  /* request renderer by ID                       */
            AGL_SINGLE_RENDERER = 71,  /* choose a single renderer for all screens     */
            AGL_NO_RECOVERY = 72,  /* disable all failure recovery systems         */
            AGL_ACCELERATED = 73,  /* choose a hardware accelerated renderer       */
            AGL_CLOSEST_POLICY = 74,  /* choose the closest color buffer to request   */
            AGL_ROBUST = 75,  /* renderer does not need failure recovery      */
            AGL_BACKING_STORE = 76,  /* back buffer contents are valid after swap    */
            AGL_MP_SAFE = 78,  /* renderer is multi-processor safe             */

            AGL_WINDOW = 80,  /* can be used to render to a window            */
            AGL_MULTISCREEN = 81,  /* single window can span multiple screens      */
            AGL_VIRTUAL_SCREEN = 82,  /* virtual screen number                        */
            AGL_COMPLIANT = 83,  /* renderer is opengl compliant                 */

            AGL_PBUFFER = 90,  /* can be used to render to a pbuffer           */
            AGL_REMOTE_PBUFFER = 91,  /* can be used to render offline to a pbuffer      */
        }
        /*
         ** Property names for aglDescribeRenderer
         */
        internal enum RendererProperties
        {
            /* const int AGL_OFFSCREEN =          53 */
            /* const int AGL_FULLSCREEN =         54 */
            /* const int AGL_RENDERER_ID =        70 */
            /* const int AGL_ACCELERATED =        73 */
            /* const int AGL_ROBUST =             75 */
            /* const int AGL_BACKING_STORE =      76 */
            /* const int AGL_MP_SAFE =            78 */
            /* const int AGL_WINDOW =             80 */
            /* const int AGL_MULTISCREEN =        81 */
            /* const int AGL_COMPLIANT =          83 */
            /* const int AGL_PBUFFER =            90 */
            AGL_BUFFER_MODES = 100,
            AGL_MIN_LEVEL = 101,
            AGL_MAX_LEVEL = 102,
            AGL_COLOR_MODES = 103,
            AGL_ACCUM_MODES = 104,
            AGL_DEPTH_MODES = 105,
            AGL_STENCIL_MODES = 106,
            AGL_MAX_AUX_BUFFERS = 107,
            AGL_VIDEO_MEMORY = 120,
            AGL_TEXTURE_MEMORY = 121,
            AGL_RENDERER_COUNT = 128,
        }
        /*
         ** Integer parameter names
         */
        internal enum ParameterNames
        {
            AGL_SWAP_RECT = 200,  /* Enable or set the swap rectangle              */
            AGL_BUFFER_RECT = 202,  /* Enable or set the buffer rectangle            */
            AGL_SWAP_LIMIT = 203,  /* Enable or disable the swap async limit        */
            AGL_COLORMAP_TRACKING = 210,  /* Enable or disable colormap tracking           */
            AGL_COLORMAP_ENTRY = 212,  /* Set a colormap entry to {index, r, g, b}      */
            AGL_RASTERIZATION = 220,  /* Enable or disable all rasterization           */
            AGL_SWAP_INTERVAL = 222,  /* 0 -> Don't sync, n -> Sync every n retrace    */
            AGL_STATE_VALIDATION = 230,  /* Validate state for multi-screen functionality */
            AGL_BUFFER_NAME = 231,  /* Set the buffer name. Allows for multi ctx to share a buffer */
            AGL_ORDER_CONTEXT_TO_FRONT = 232,  /* Order the current context in front of all the other contexts. */
            AGL_CONTEXT_SURFACE_ID = 233,  /* aglGetInteger only - returns the ID of the drawable surface for the context */
            AGL_CONTEXT_DISPLAY_ID = 234,  /* aglGetInteger only - returns the display ID(s) of all displays touched by the context, up to a maximum of 32 displays */
            AGL_SURFACE_ORDER = 235,  /* Position of OpenGL surface relative to window: 1 -> Above window, -1 -> Below Window */
            AGL_SURFACE_OPACITY = 236,  /* Opacity of OpenGL surface: 1 -> Surface is opaque (default), 0 -> non-opaque */
            AGL_CLIP_REGION = 254,  /* Enable or set the drawable clipping region */
            AGL_FS_CAPTURE_SINGLE = 255,  /* Enable the capture of only a single display for aglFullScreen, normally disabled */
            AGL_SURFACE_BACKING_SIZE = 304,  /* 2 params.   Width/height of surface backing size     */
            AGL_ENABLE_SURFACE_BACKING_SIZE = 305,  /* Enable or disable surface backing size override */
            AGL_SURFACE_VOLATILE = 306,  /* Flag surface to candidate for deletion */
        }
        /*
         ** Option names for aglConfigure.
         */
        internal enum OptionName
        {
            AGL_FORMAT_CACHE_SIZE = 501,  /* Set the size of the pixel format cache        */
            AGL_CLEAR_FORMAT_CACHE = 502,  /* Reset the pixel format cache                  */
            AGL_RETAIN_RENDERERS = 503,  /* Whether to retain loaded renderers in memory  */
        }
        /* buffer_modes */
        internal enum BufferModes
        {
            AGL_MONOSCOPIC_BIT = 0x00000001,
            AGL_STEREOSCOPIC_BIT = 0x00000002,
            AGL_SINGLEBUFFER_BIT = 0x00000004,
            AGL_DOUBLEBUFFER_BIT = 0x00000008,
        }

        internal enum BitDepths
        {
            /* bit depths */
            AGL_0_BIT =                0x00000001,
            AGL_1_BIT =                0x00000002,
            AGL_2_BIT =                0x00000004,
            AGL_3_BIT =                0x00000008,
            AGL_4_BIT =                0x00000010,
            AGL_5_BIT =                0x00000020,
            AGL_6_BIT =                0x00000040,
            AGL_8_BIT =                0x00000080,
            AGL_10_BIT =               0x00000100,
            AGL_12_BIT =               0x00000200,
            AGL_16_BIT =               0x00000400,
            AGL_24_BIT =               0x00000800,
            AGL_32_BIT =               0x00001000,
            AGL_48_BIT =               0x00002000,
            AGL_64_BIT =               0x00004000,
            AGL_96_BIT =               0x00008000,
            AGL_128_BIT =              0x00010000,
        }
        /* color modes */
        internal enum ColorModes
        {
            AGL_RGB8_BIT = 0x00000001,  /* 8 rgb bit/pixel,     RGB=7:0, inverse colormap         */
            AGL_RGB8_A8_BIT = 0x00000002,  /* 8-8 argb bit/pixel,  A=7:0, RGB=7:0, inverse colormap  */
            AGL_BGR233_BIT = 0x00000004,  /* 8 rgb bit/pixel,     B=7:6, G=5:3, R=2:0               */
            AGL_BGR233_A8_BIT = 0x00000008,  /* 8-8 argb bit/pixel,  A=7:0, B=7:6, G=5:3, R=2:0        */
            AGL_RGB332_BIT = 0x00000010,  /* 8 rgb bit/pixel,     R=7:5, G=4:2, B=1:0               */
            AGL_RGB332_A8_BIT = 0x00000020,  /* 8-8 argb bit/pixel,  A=7:0, R=7:5, G=4:2, B=1:0        */
            AGL_RGB444_BIT = 0x00000040,  /* 16 rgb bit/pixel,    R=11:8, G=7:4, B=3:0              */
            AGL_ARGB4444_BIT = 0x00000080,  /* 16 argb bit/pixel,   A=15:12, R=11:8, G=7:4, B=3:0     */
            AGL_RGB444_A8_BIT = 0x00000100,  /* 8-16 argb bit/pixel, A=7:0, R=11:8, G=7:4, B=3:0       */
            AGL_RGB555_BIT = 0x00000200,  /* 16 rgb bit/pixel,    R=14:10, G=9:5, B=4:0             */
            AGL_ARGB1555_BIT = 0x00000400,  /* 16 argb bit/pixel,   A=15, R=14:10, G=9:5, B=4:0       */
            AGL_RGB555_A8_BIT = 0x00000800,  /* 8-16 argb bit/pixel, A=7:0, R=14:10, G=9:5, B=4:0      */
            AGL_RGB565_BIT = 0x00001000,  /* 16 rgb bit/pixel,    R=15:11, G=10:5, B=4:0            */
            AGL_RGB565_A8_BIT = 0x00002000,  /* 8-16 argb bit/pixel, A=7:0, R=15:11, G=10:5, B=4:0     */
            AGL_RGB888_BIT = 0x00004000,  /* 32 rgb bit/pixel,    R=23:16, G=15:8, B=7:0            */
            AGL_ARGB8888_BIT = 0x00008000,  /* 32 argb bit/pixel,   A=31:24, R=23:16, G=15:8, B=7:0   */
            AGL_RGB888_A8_BIT = 0x00010000,  /* 8-32 argb bit/pixel, A=7:0, R=23:16, G=15:8, B=7:0     */
            AGL_RGB101010_BIT = 0x00020000,  /* 32 rgb bit/pixel,    R=29:20, G=19:10, B=9:0           */
            AGL_ARGB2101010_BIT = 0x00040000,  /* 32 argb bit/pixel,   A=31:30  R=29:20, G=19:10, B=9:0  */
            AGL_RGB101010_A8_BIT = 0x00080000,  /* 8-32 argb bit/pixel, A=7:0  R=29:20, G=19:10, B=9:0    */
            AGL_RGB121212_BIT = 0x00100000,  /* 48 rgb bit/pixel,    R=35:24, G=23:12, B=11:0          */
            AGL_ARGB12121212_BIT = 0x00200000,  /* 48 argb bit/pixel,   A=47:36, R=35:24, G=23:12, B=11:0 */
            AGL_RGB161616_BIT = 0x00400000,  /* 64 rgb bit/pixel,    R=47:32, G=31:16, B=15:0          */
            AGL_ARGB16161616_BIT = 0x00800000,  /* 64 argb bit/pixel,   A=63:48, R=47:32, G=31:16, B=15:0 */
            AGL_INDEX8_BIT = 0x20000000,  /* 8 bit color look up table (deprecated)                 */
            AGL_INDEX16_BIT = 0x40000000,  /* 16 bit color look up table (deprecated)                   */
            AGL_RGBFLOAT64_BIT = 0x01000000,  /* 64 rgb bit/pixel,    half float                        */
            AGL_RGBAFLOAT64_BIT = 0x02000000,  /* 64 argb bit/pixel,   half float                        */
            AGL_RGBFLOAT128_BIT = 0x04000000,  /* 128 rgb bit/pixel,   ieee float                        */
            AGL_RGBAFLOAT128_BIT = 0x08000000,  /* 128 argb bit/pixel,  ieee float                        */
            AGL_RGBFLOAT256_BIT = 0x10000000,  /* 256 rgb bit/pixel,   ieee double                       */
            AGL_RGBAFLOAT256_BIT = 0x20000000,  /* 256 argb bit/pixel,  ieee double                       */
        }
        /*
         ** Error return values from aglGetError.
         */
        internal enum AglError
        {
            NoError =                 0, /* no error                        */

            BadAttribute =        10000, /* invalid pixel format attribute  */
            BadProperty =         10001, /* invalid renderer property       */
            BadPixelFormat =      10002, /* invalid pixel format            */
            BadRendererInfo =     10003, /* invalid renderer info           */
            BadContext =          10004, /* invalid context                 */
            BadDrawable =         10005, /* invalid drawable                */
            BadGraphicsDevice =   10006, /* invalid graphics device         */
            BadState =            10007, /* invalid context state           */
            BadValue =            10008, /* invalid numerical value         */
            BadMatch =            10009, /* invalid share context           */
            BadEnum =             10010, /* invalid enumerant               */
            BadOffscreen =        10011, /* invalid offscreen drawable      */
            BadFullscreen =       10012, /* invalid offscreen drawable      */
            BadWindow =           10013, /* invalid window                  */
            BadPointer =          10014, /* invalid pointer                 */
            BadModule =           10015, /* invalid code module             */
            BadAlloc =            10016, /* memory allocation failure       */
            BadConnection =       10017, /* invalid CoreGraphics connection */
        }
        /************************************************************************/

        /*
         ** Pixel format functions
         */
        [DllImport(agl)] internal static extern AGLPixelFormat aglChoosePixelFormat(ref AGLDevice gdevs, int ndev, int []attribs);
        /// <summary>
        /// Use this overload only with IntPtr.Zero for the first argument.
        /// </summary>
        /// <param name="gdevs">
        /// </param>
        /// <param name="ndev">
        /// </param>
        /// <param name="attribs">
        /// </param>
        /// <returns>
        /// </returns>
        [DllImport(agl)] internal static extern AGLPixelFormat aglChoosePixelFormat(IntPtr gdevs, int ndev, int []attribs);
        [DllImport(agl)] internal static extern void aglDestroyPixelFormat(AGLPixelFormat pix);
        [DllImport(agl)] internal static extern AGLPixelFormat aglNextPixelFormat(AGLPixelFormat pix);
        [DllImport(agl)] internal static extern bool aglDescribePixelFormat(AGLPixelFormat pix, PixelFormatAttribute attrib, out int value);

        /*
         ** Renderer information functions
         */
        [DllImport(agl)]
        private static extern AGLRendererInfo aglQueryRendererInfo(AGLDevice[] gdevs, int ndev);
        [DllImport(agl)]
        private static extern void aglDestroyRendererInfo(AGLRendererInfo rend);
        [DllImport(agl)]
        private static extern AGLRendererInfo aglNextRendererInfo(AGLRendererInfo rend);
        [DllImport(agl)]
        private static extern byte aglDescribeRenderer(AGLRendererInfo rend, int prop, out int value);

        /*
         ** Context functions
         */
        [DllImport(agl)] internal static extern AGLContext aglCreateContext(AGLPixelFormat pix, AGLContext share);
        [DllImport(agl, EntryPoint="aglDestroyContext")]
        private static extern byte _aglDestroyContext(AGLContext ctx);
        internal static bool aglDestroyContext(AGLContext context)
        {
            return (_aglDestroyContext(context) != 0) ? true : false;
        }

        [DllImport(agl)]
        private static extern byte aglCopyContext(AGLContext src, AGLContext dst, uint mask);
        [DllImport(agl)] internal static extern byte aglUpdateContext(AGLContext ctx);

        /*
         ** Current state functions
         */

        [DllImport(agl, EntryPoint="aglSetCurrentContext")]
        private static extern byte _aglSetCurrentContext(AGLContext ctx);
        internal static bool aglSetCurrentContext(IntPtr context)
        {
            byte retval = _aglSetCurrentContext(context);

            if (retval != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [DllImport(agl)] internal static extern AGLContext aglGetCurrentContext();


        /*
         ** Drawable Functions
         */
        [DllImport(agl, EntryPoint="aglSetDrawable")]
        private static extern byte _aglSetDrawable(AGLContext ctx, AGLDrawable draw);

        internal static void aglSetDrawable(AGLContext ctx, AGLDrawable draw)
        {
            byte retval = _aglSetDrawable(ctx, draw);

            if (retval == 0)
            {
                AglError err = GetError();
                throw new Exception(ErrorString(err));
            }
        }
        [DllImport(agl)]
        private static extern byte aglSetOffScreen(AGLContext ctx, int width, int height, int rowbytes, IntPtr baseaddr);
        [DllImport(agl)]
        private static extern AGLDrawable aglGetDrawable(AGLContext ctx);

        [DllImport(agl, EntryPoint = "aglSetFullScreen")]
        private static extern byte _aglSetFullScreen(AGLContext ctx, int width, int height, int freq, int device);
        internal static void aglSetFullScreen(AGLContext ctx, int width, int height, int freq, int device)
        {
            byte retval = _aglSetFullScreen(ctx, width, height, freq, device);

            if (retval == 0)
            {
                AglError err = GetError();
                Debug.Print("AGL Error: {0}", err);
                Debug.Indent();
                Debug.Print(ErrorString(err));
                Debug.Unindent();

                throw new Exception(ErrorString(err));
            }
        }
        /*
         ** Virtual screen functions
         */
        [DllImport(agl)]
        private static extern byte aglSetVirtualScreen(AGLContext ctx, int screen);
        [DllImport(agl)]
        private static extern int aglGetVirtualScreen(AGLContext ctx);

        /*
         ** Obtain version numbers
         */
        [DllImport(agl)]
        private static extern void aglGetVersion(int *major, int *minor);

        /*
         ** Global library options
         */
        [DllImport(agl)]
        private static extern byte aglConfigure(GLenum pname, uint param);

        /*
         ** Swap functions
         */
        [DllImport(agl)] internal static extern void aglSwapBuffers(AGLContext ctx);

        /*
         ** Per context options
         */
        [DllImport(agl)]
        internal static extern bool aglEnable(AGLContext ctx, ParameterNames pname);
        [DllImport(agl)]
        internal static extern bool aglDisable(AGLContext ctx, ParameterNames pname);
        [DllImport(agl)]
        private static extern bool aglIsEnabled(AGLContext ctx, GLenum pname);
        [DllImport(agl)]
        internal static extern bool aglSetInteger(AGLContext ctx, ParameterNames pname, ref int param);
        [DllImport(agl)]
        internal static extern bool aglSetInteger(AGLContext ctx, ParameterNames pname, int[] @params);
        //[DllImport(agl)]
        //static extern bool aglGetInteger(AGLContext ctx, ParameterNames pname, int* @params);
        [DllImport(agl)]
        internal static extern bool aglGetInteger(AGLContext ctx, ParameterNames pname, out int param);

        /*
         ** Font function
         */
         // TODO: face parameter should be of type StyleParameter in QuickDraw.
        [DllImport(agl)]
        private static extern byte aglUseFont(AGLContext ctx, int fontID, int face, int size, int first, int count, int @base);

        /*
         ** Error functions
         */
        [DllImport(agl, EntryPoint="aglGetError")] internal static extern AglError GetError();
        [DllImport(agl, EntryPoint="aglErrorString")]
        private static extern IntPtr _aglErrorString(AglError code);
        internal static string ErrorString(AglError code)
        {
            return Marshal.PtrToStringAnsi(_aglErrorString(code));
        }

        /*
         ** Soft reset function
         */
        [DllImport(agl)]
        private static extern void aglResetLibrary();

        /*
         ** Surface texture function
         */
        [DllImport(agl)]
        private static extern void aglSurfaceTexture (AGLContext context, GLenum target, GLenum internalformat, AGLContext surfacecontext);

        /*
         ** PBuffer functions
         */
        [DllImport(agl)]
        private static extern byte aglCreatePBuffer (int width, int height, GLenum target, GLenum internalFormat, long max_level, AGLPbuffer *pbuffer);
        [DllImport(agl)]
        private static extern byte aglDestroyPBuffer (AGLPbuffer pbuffer);
        [DllImport(agl)]
        private static extern byte aglDescribePBuffer (AGLPbuffer pbuffer, int *width, int *height, GLenum *target, GLenum *internalFormat, int *max_level);
        [DllImport(agl)]
        private static extern byte aglTexImagePBuffer (AGLContext ctx, AGLPbuffer pbuffer, int source);

        /*
         ** Pbuffer Drawable Functions
         */
        [DllImport(agl)]
        private static extern byte aglSetPBuffer (AGLContext ctx, AGLPbuffer pbuffer, int face, int level, int screen);
        [DllImport(agl)]
        private static extern byte aglGetPBuffer (AGLContext ctx, AGLPbuffer *pbuffer, int *face, int *level, int *screen);

        /*
         ** CGL functions
         */
        [DllImport(agl)]
        private static extern byte aglGetCGLContext(AGLContext ctx, void **cgl_ctx);
        [DllImport(agl)]
        private static extern byte aglGetCGLPixelFormat(AGLPixelFormat pix, void **cgl_pix);

        #pragma warning restore 0169
    }
}

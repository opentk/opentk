#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

using System;

using OpenTK.Graphics.OpenGL;

namespace Examples.TextureLoaders
{

    /// <summary>The parameters in this class have only effect on the following Texture loads.</summary>
    public static class TextureLoaderParameters
    {
        /// <summary>(Debug Aid, should be set to false) If set to false only Errors will be printed. If set to true, debug information (Warnings and Queries) will be printed in addition to Errors.</summary>
        public static bool Verbose = false;

        /// <summary>Always-valid fallback parameter for GL.BindTexture (Default: 0). This number will be returned if loading the Texture failed. You can set this to a checkerboard texture or similar, which you have already loaded.</summary>
        public static uint OpenGLDefaultTexture = 0;

        /// <summary>Compressed formats must have a border of 0, so this is constant.</summary>
        public const int Border = 0;

        /// <summary>false==DirectX TexCoords, true==OpenGL TexCoords (Default: true)</summary>
        public static bool FlipImages = true;

        /// <summary>When enabled, will use Glu to create MipMaps for images loaded with GDI+ (Default: false)</summary>
        public static bool BuildMipmapsForUncompressed = false;

        /// <summary>Selects the Magnification filter for following Textures to be loaded. (Default: Nearest)</summary>
        public static TextureMagFilter MagnificationFilter = TextureMagFilter.Nearest;

        /// <summary>Selects the Minification filter for following Textures to be loaded. (Default: Nearest)</summary>
        public static TextureMinFilter MinificationFilter = TextureMinFilter.Nearest;

        /// <summary>Selects the S Wrapping for following Textures to be loaded. (Default: Repeat)</summary>
        public static TextureWrapMode WrapModeS = TextureWrapMode.Repeat;

        /// <summary>Selects the T Wrapping for following Textures to be loaded. (Default: Repeat)</summary>
        public static TextureWrapMode WrapModeT = TextureWrapMode.Repeat;

        /// <summary>Selects the Texture Environment Mode for the following Textures to be loaded. Default: Modulate)</summary>
        public static TextureEnvMode EnvMode = TextureEnvMode.Modulate;
    }

}

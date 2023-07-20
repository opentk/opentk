using System;

#nullable enable

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Graphics API hints for OpenGL family of APIs.
    /// </summary>
    public class OpenGLGraphicsApiHints : GraphicsApiHints
    {
        /// <inheritdoc/>
        public override GraphicsApi Api { get; }

        /// <summary>
        /// OpenGL version to create.
        /// </summary>
        public Version Version { get; set; } = new Version(4, 1);

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
        public bool DoubleBuffer { get; set; } = true; // TODO: Is it really necessary?

        /// <summary>
        /// Makes the backbuffer support sRGB.
        /// </summary>
        public bool sRGBFramebuffer { get; set; } = false;

        public OpenGLProfile Profile { get; set; } = OpenGLProfile.None;

        public bool ForwardCompatibleFlag { get; set; } = true;

        public bool DebugFlag { get; set; } = false;

        public OpenGLContextHandle? SharedContext { get; set; } = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGLGraphicsApiHints"/> class.
        /// </summary>
        /// <param name="api">The OpenGL variant the hints are for.</param>
        public OpenGLGraphicsApiHints(GraphicsApi api = GraphicsApi.OpenGL)
        {
            if (api != GraphicsApi.OpenGL && api != GraphicsApi.OpenGLES)
            {
                throw new Exception($"Cannot create OpenGL hints for graphics API {api}.");
            }

            Api = api;
        }

        public OpenGLGraphicsApiHints Copy()
        {
            return (OpenGLGraphicsApiHints)MemberwiseClone();
        }
    }
}

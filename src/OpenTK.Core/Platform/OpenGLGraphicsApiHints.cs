using System;

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
        public Version Version { get; set; } = new Version(4, 6);

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
        public int StencilBits { get; set; } = 0;

        /// <summary>
        /// Number of bits for depth buffer.
        /// </summary>
        public int DepthBits { get; set; } = 24;

        /// <summary>
        /// Number of MSAA samples.
        /// </summary>
        public int Multisamples { get; set; } = 4;

        /// <summary>
        /// Enable double buffering.
        /// </summary>
        public bool DoubleBuffer { get; set; } = true; // TODO: Is it really necessary?

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenGLGraphicsApiHints"/> class.
        /// </summary>
        /// <param name="api">The OpenGL variant the hints are for.</param>
        public OpenGLGraphicsApiHints(GraphicsApi api = GraphicsApi.OpenGL)
        {
            if (api != GraphicsApi.OpenGL || api != GraphicsApi.OpenGLES)
            {
                throw new Exception($"Cannot create OpenGL hints for graphics API {api}.");
            }

            Api = api;
        }
    }
}

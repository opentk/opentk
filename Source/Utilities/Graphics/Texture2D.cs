#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
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
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace OpenTK.Graphics
{
    abstract class Texture2D :  IGraphicsResource
    {
        #region Fields

        GraphicsContext context;
        int id;
        int width, height;
        bool disposed;

        TextureMagFilter mag_filter = TextureMagFilter.Linear;
        TextureMinFilter min_filter = TextureMinFilter.Linear;

        #endregion

        #region Constructors

        public Texture2D(int width, int height)
        {
            if (width <= 0)
                throw new ArgumentOutOfRangeException("width");

            if (height <= 0)
                throw new ArgumentOutOfRangeException("height");

            Width = width;
            Height = height;
        }

        #endregion

        #region Public Members

        #region public int Width

        /// <summary>Gets the width of the texture.</summary>
        public int Width { get { return width; } private set { width = value; } }

        #endregion

        #region public int Height

        /// <summary>Gets the height of the texture.</summary>
        public int Height { get { return height; } private set { height = value; } }

        #endregion

        #region MagnificationFilter

        public TextureMagFilter MagnificationFilter
        {
            get { return mag_filter; }
            set { mag_filter = value; }
        }

        #endregion

        #region MinificationFilter

        public TextureMinFilter MinificationFilter
        {
            get { return min_filter; }
            set { min_filter = value; }
        }

        #endregion

        #region Bind

        public void Bind()
        {
            GL.BindTexture(TextureTarget.Texture2D, (this as IGraphicsResource).Id);
        }

        #endregion

        #region WriteRegion

        public void WriteRegion(Rectangle source, Rectangle target, int mipLevel, Bitmap bitmap)
        {
            if (bitmap == null)
                throw new ArgumentNullException("data");

            GraphicsUnit unit = GraphicsUnit.Pixel;

            if (!bitmap.GetBounds(ref unit).Contains(source))
                throw new InvalidOperationException("The source Rectangle is larger than the Bitmap.");

            if (mipLevel < 0)
                throw new ArgumentOutOfRangeException("mipLevel");

            Bind();

            BitmapData data = null;

            GL.PushClientAttrib(ClientAttribMask.ClientPixelStoreBit);
            try
            {
                data = bitmap.LockBits(source, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                GL.PixelStore(PixelStoreParameter.UnpackAlignment, 1);
                GL.PixelStore(PixelStoreParameter.UnpackRowLength, bitmap.Width);
                GL.TexSubImage2D(TextureTarget.Texture2D, mipLevel,
                    target.Left, target.Top,
                    target.Width, target.Height,
                    OpenTK.Graphics.PixelFormat.Rgba,
                    PixelType.UnsignedByte, data.Scan0);
            }
            finally
            {
                GL.PopClientAttrib();
                if (data != null)
                    bitmap.UnlockBits(data);
            }
        }

        #endregion

        #region ReadRegion

        public TextureRegion2D ReadRegion(Rectangle rect, int mipLevel)
        {
            if (mipLevel < 0)
                throw new ArgumentOutOfRangeException("miplevel");

            TextureRegion2D<int> region = new TextureRegion2D<int>(rect);

            GL.GetTexImage(TextureTarget.Texture2D, mipLevel, PixelFormat.Bgra, PixelType.UnsignedByte, region.Data);

            return region;
        }

        #endregion

        #endregion

        #region Protected Members

        #region InternalFormat

        protected abstract PixelInternalFormat InternalFormat { get; }

        #endregion

        #endregion

        #region IGraphicsResource Members

        #region IGraphicsResource.Context

        GraphicsContext IGraphicsResource.Context { get { return context; } }

        #endregion

        #region IGraphicsResource.Id

        int IGraphicsResource.Id
        {
            get
            {
                if (id == 0)
                {
                    GraphicsContext.Assert();
                    context = GraphicsContext.CurrentContext;

                    id = GL.GenTexture();
                    if (id == 0)
                        throw new GraphicsResourceException(String.Format("Texture creation failed, (Error: {0})", GL.GetError()));

                    // Ensure the texture is allocated.
                    GL.BindTexture(TextureTarget.Texture2D, id);
                    GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)All.Linear);
                    GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)All.Linear);
                    if (GL.SupportsExtension("Version12"))
                    {
                        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)All.ClampToEdge);
                        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)All.ClampToEdge);
                    }
                    else
                    {
                        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)All.Clamp);
                        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)All.Clamp);
                    }

                    GL.TexImage2D(TextureTarget.Texture2D, 0, InternalFormat, Width, Height, 0,
                        OpenTK.Graphics.PixelFormat.Rgba, PixelType.UnsignedByte, IntPtr.Zero);
                }

                return id;
            }
        }

        #endregion

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void Dispose(bool manual)
        {
            if (!disposed)
            {
                if (manual)
                {
                    GL.DeleteTexture(id);
                }
                disposed = true;
            }
        }

        ~Texture2D()
        {
            GraphicsContext context = (this as IGraphicsResource).Context;
            if (context != null)
             (context as IGraphicsContextInternal).RegisterForDisposal(this);
        }

        #endregion
    }
}

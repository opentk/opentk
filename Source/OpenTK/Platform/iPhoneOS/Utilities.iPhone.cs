#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * Copyright 2013 Xamarin Inc
 * See license.txt for license info
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;

using MonoTouch.OpenGLES;

using OpenTK.Graphics;

#endregion

namespace OpenTK.Platform
{
    /// <summary>
    /// Provides cross-platform utilities to help interact with the underlying platform.
    /// </summary>
    public static class Utilities
    {
        /// <summary>
        /// Creates an IGraphicsContext instance for the specified window.
        /// </summary>
        /// <param name="mode">The GraphicsMode for the GraphicsContext.</param>
        /// <param name="window">An IWindowInfo instance describing the parent window for this IGraphicsContext.</param>
        /// <param name="major">The major OpenGL version number for this IGraphicsContext.</param>
        /// <param name="minor">The minor OpenGL version number for this IGraphicsContext.</param>
        /// <param name="flags">A bitwise collection of GraphicsContextFlags with specific options for this IGraphicsContext.</param>
        /// <returns>A new IGraphicsContext instance.</returns>
        public static IGraphicsContext CreateGraphicsContext(
            GraphicsMode mode, IWindowInfo window,
            int major, int minor, GraphicsContextFlags flags)
        {
            GraphicsContext context = new GraphicsContext(mode, window, major, minor, flags);
            context.MakeCurrent(window);

            (context as IGraphicsContextInternal).LoadAll();

            return context;
        }

        public static IGraphicsContext CreateGraphicsContext(EAGLRenderingAPI version)
        {
            int major = 0, minor = 0;
            switch (version) {
                case EAGLRenderingAPI.OpenGLES1: major = 1; minor = 1; break;
                case EAGLRenderingAPI.OpenGLES2: major = 2; minor = 0; break;
                default:
                    throw new ArgumentException("Unsupported EAGLRenderingAPI version: " + version);
            }
            return CreateGraphicsContext(null, null, major, minor, GraphicsContextFlags.Embedded);
        }
    }
}

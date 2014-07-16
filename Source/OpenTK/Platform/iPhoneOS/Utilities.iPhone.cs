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

#if XAMCORE_2_0
using OpenGLES;
#else
using MonoTouch.OpenGLES;
#endif

using OpenTK.Graphics;

#endregion

namespace OpenTK.Platform
{
    /// <summary>
    /// Provides cross-platform utilities to help interact with the underlying platform.
    /// </summary>
    public static partial class Utilities
    {
        public static IGraphicsContext CreateGraphicsContext(EAGLRenderingAPI version)
        {
            int major = 0, minor = 0;
            switch ((int)version) {
                case 1 /*EAGLRenderingAPI.OpenGLES1*/: major = 1; minor = 1; break;
                case 2 /*EAGLRenderingAPI.OpenGLES2*/: major = 2; minor = 0; break;
                case 3 /*EAGLRenderingAPI.OpenGLES3*/: major = 3; minor = 0; break;
                default:
                    throw new ArgumentException("Unsupported EAGLRenderingAPI version: " + version);
            }
            return CreateGraphicsContext(null, null, major, minor, GraphicsContextFlags.Embedded);
        }
    }
}

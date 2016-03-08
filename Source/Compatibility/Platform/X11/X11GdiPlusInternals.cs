﻿// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Reflection;

namespace OpenTK.Platform.X11
{
    // Note: This class is Mono-specific, not X11-specific!
    // It works on all platforms (windows, linux, macos) as long as we are running on Mono.
    class X11GdiPlusInternals : IGdiPlusInternals
    {
        static readonly PropertyInfo native_graphics_property, native_font_property, native_string_format_property;

        static X11GdiPlusInternals()
        {
            native_graphics_property =
                typeof(System.Drawing.Graphics).GetProperty("NativeObject", BindingFlags.Instance | BindingFlags.NonPublic);

            native_font_property =
                typeof(System.Drawing.Font).GetProperty("NativeObject", BindingFlags.Instance | BindingFlags.NonPublic);

            native_string_format_property =
                typeof(System.Drawing.StringFormat).GetProperty("NativeObject", BindingFlags.Instance | BindingFlags.NonPublic);
        }

        #region --- IGdiPlusInternals Members ---

        public IntPtr GetNativeGraphics(System.Drawing.Graphics graphics)
        {
            return (IntPtr)native_graphics_property.GetValue(graphics, null);
        }

        public IntPtr GetNativeFont(Font font)
        {
            return (IntPtr)native_font_property.GetValue(font, null);
        }

        public IntPtr GetNativeStringFormat(StringFormat format)
        {
            return (IntPtr)native_string_format_property.GetValue(format, null);
        }

        #endregion
    }
}

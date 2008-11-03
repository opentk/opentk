#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Reflection;

namespace OpenTK.Platform.X11
{
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

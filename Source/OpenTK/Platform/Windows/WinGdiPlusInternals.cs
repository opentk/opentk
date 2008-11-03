using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Reflection;

namespace OpenTK.Platform.Windows
{
    class WinGdiPlusInternals : IGdiPlusInternals
    {
        const string gdi_plus_library = "gdiplus.dll";
        static readonly PropertyInfo native_graphics_property, native_font_property;
        static readonly FieldInfo native_string_format_field;

        static WinGdiPlusInternals()
        {
            native_graphics_property =
                typeof(System.Drawing.Graphics).GetProperty("NativeGraphics", BindingFlags.Instance | BindingFlags.NonPublic);

            native_font_property =
                typeof(System.Drawing.Font).GetProperty("NativeFont", BindingFlags.Instance | BindingFlags.NonPublic);

            native_string_format_field =
                typeof(System.Drawing.StringFormat).GetField("nativeFormat", BindingFlags.Instance | BindingFlags.NonPublic);
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
            return (IntPtr)native_string_format_field.GetValue(format);
        }

        #endregion
    }
}

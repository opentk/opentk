#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Reflection;
using System.Diagnostics;

namespace OpenTK.Platform
{
    internal static class GdiPlus
    {
        const string gdi_plus_library = "gdiplus.dll";
        static readonly PropertyInfo native_graphics_property, native_font_property;
        static readonly FieldInfo native_string_format_field;

        #region --- Constructors ---

        static GdiPlus()
        {
            native_graphics_property =
                typeof(System.Drawing.Graphics).GetProperty("NativeGraphics", BindingFlags.Instance | BindingFlags.NonPublic);

            native_font_property =
                typeof(System.Drawing.Font).GetProperty("NativeFont", BindingFlags.Instance | BindingFlags.NonPublic);

            native_string_format_field =
                typeof(System.Drawing.StringFormat).GetField("nativeFormat", BindingFlags.Instance | BindingFlags.NonPublic);
        }

        #endregion

        #region --- Reflection ---

        public static IntPtr GetNativeGraphics(System.Drawing.Graphics graphics)
        {
            return (IntPtr)native_graphics_property.GetValue(graphics, null);
        }

        public static IntPtr GetNativeFont(Font font)
        {
            return (IntPtr)native_font_property.GetValue(font, null);
        }

        public static IntPtr GetNativeStringFormat(StringFormat format)
        {
            return (IntPtr)native_string_format_field.GetValue(format);
        }

        public static int MaxMeasurableCharacterRanges
        {
            get
            {
                return 32;    // This is a GDI+ limitation. TODO: Can we query this somehow? 
            }
        }

        #endregion

        #region --- Methods ---

        [DllImport(gdi_plus_library, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true, EntryPoint="GdipSetStringFormatMeasurableCharacterRanges")]
        public static extern int SetStringFormatMeasurableCharacterRanges(HandleRef format, int rangeCount, [In, Out] CharacterRange[] range);

        [DllImport(gdi_plus_library, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true, EntryPoint = "GdipGetStringFormatMeasurableCharacterRangeCount")]
        public static extern int GetStringFormatMeasurableCharacterRangeCount(HandleRef format, out int count);

        [DllImport(gdi_plus_library, CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true, EntryPoint = "GdipMeasureCharacterRanges")]
        public static extern int MeasureCharacterRanges(HandleRef graphics, string textString, int length, HandleRef font, ref RectangleF layoutRect, HandleRef stringFormat, int characterCount, [In, Out] IntPtr[] region);

        [DllImport("gdiplus.dll", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true, EntryPoint = "GdipGetRegionBounds")]
        public static extern int GetRegionBounds(IntPtr region, HandleRef graphics, ref RectangleF gprectf);

        [DllImport("gdiplus.dll", EntryPoint = "GdipCreateRegion", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        public static extern int CreateRegion(out IntPtr region);

        [DllImport("gdiplus.dll", EntryPoint = "GdipDeleteRegion", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        public static extern int DeleteRegion(IntPtr region);

        #endregion

        [StructLayout(LayoutKind.Sequential)]
        internal struct GPRECTF
        {
            internal float X;
            internal float Y;
            internal float Width;
            internal float Height;
            internal GPRECTF(float x, float y, float width, float height)
            {
                this.X = x;
                this.Y = y;
                this.Width = width;
                this.Height = height;
            }

            internal GPRECTF(RectangleF rect)
            {
                this.X = rect.X;
                this.Y = rect.Y;
                this.Width = rect.Width;
                this.Height = rect.Height;
            }

            internal SizeF SizeF
            {
                get
                {
                    return new SizeF(this.Width, this.Height);
                }
            }
            internal RectangleF ToRectangleF()
            {
                return new RectangleF(this.X, this.Y, this.Width, this.Height);
            }
        }


    }


}

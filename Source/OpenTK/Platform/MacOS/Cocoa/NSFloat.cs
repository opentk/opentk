// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
#if !MINIMAL
using System.Drawing;
#endif
using System.Runtime.InteropServices;

namespace OpenTK.Platform.MacOS
{
    // NSFloat is defined as float on 32bit systems and double on 64bit.
    // We have to account for this peculiarity in order to run OpenTK on
    // 64bit Mac platforms.
    // We do this by adding implicit conversions between IntPtr and float/double.
    // Note that this conversion is against C# best practices, as it can lose information.
    // However, NSFloat is used internally in places where this precision loss does not matter.
    struct NSFloat
    {
        IntPtr value;

        public static implicit operator NSFloat(float v)
        {
            NSFloat f;
            unsafe
            {
                if (IntPtr.Size == 4)
                {
                    f.value = *(IntPtr*)&v;
                }
                else
                {
                    double d = v;
                    f.value = *(IntPtr*)&d;
                }
            }
            return f;
        }

        public static implicit operator NSFloat(double v)
        {
            NSFloat f;
            unsafe
            {
                if (IntPtr.Size == 4)
                {
                    float fv = (float)v;
                    f.value = *(IntPtr*)&fv;
                }
                else
                {
                    f.value = *(IntPtr*)&v;
                }
            }
            return f;
        }

        public static implicit operator float(NSFloat f)
        {
            unsafe
            {
                if (IntPtr.Size == 4)
                {
                    return *(float*)&f.value;
                }
                else
                {
                    return (float)*(double*)&f.value;
                }
            }
        }

        public static implicit operator double(NSFloat f)
        {
            unsafe
            {
                if (IntPtr.Size == 4)
                {
                    return (double)*(float*)&f.value;
                }
                else
                {
                    return *(float*)&f.value;
                }
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    struct NSPoint
    {
        public NSFloat X;
        public NSFloat Y;

        public static implicit operator NSPoint(PointF p)
        {
            return new NSPoint
            {
                X = p.X,
                Y = p.Y
            };
        }

        public static implicit operator PointF(NSPoint s)
        {
            return new PointF(s.X, s.Y);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    struct NSSize
    {
        public NSFloat Width;
        public NSFloat Height;

        public static implicit operator NSSize(SizeF s)
        {
            return new NSSize
            {
                Width = s.Width,
                Height = s.Height
            };
        }

        public static implicit operator SizeF(NSSize s)
        {
            return new SizeF(s.Width, s.Height);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    struct NSRect
    {
        public NSPoint Location;
        public NSSize Size;

        public NSFloat Width { get { return Size.Width; } }
        public NSFloat Height { get { return Size.Height; } }
        public NSFloat X { get { return Location.X; } }
        public NSFloat Y { get { return Location.Y; } }

        public static implicit operator NSRect(RectangleF s)
        {
            return new NSRect
            {
                Location = s.Location,
                Size = s.Size
            };
        }

        public static implicit operator RectangleF(NSRect s)
        {
            return new RectangleF(s.Location, s.Size);
        } 
    }
}


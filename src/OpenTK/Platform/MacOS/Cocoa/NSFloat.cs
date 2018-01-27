//
// NSFloat.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

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
    internal struct NSFloat
    {
        private IntPtr _value;

        public IntPtr Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public static implicit operator NSFloat(float v)
        {
            NSFloat f = new NSFloat();
            unsafe
            {
                if (IntPtr.Size == 4)
                {
                    f.Value = *(IntPtr*)&v;
                }
                else
                {
                    double d = v;
                    f.Value = *(IntPtr*)&d;
                }
            }
            return f;
        }

        public static implicit operator NSFloat(double v)
        {
            NSFloat f = new NSFloat();
            unsafe
            {
                if (IntPtr.Size == 4)
                {
                    float fv = (float)v;
                    f.Value = *(IntPtr*)&fv;
                }
                else
                {
                    f.Value = *(IntPtr*)&v;
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
                    return *(float*)&f._value;
                }
                else
                {
                    return (float)*(double*)&f._value;
                }
            }
        }

        public static implicit operator double(NSFloat f)
        {
            unsafe
            {
                if (IntPtr.Size == 4)
                {
                    return (double)*(float*)&f._value;
                }
                else
                {
                    return *(double*)&f._value;
                }
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct NSPoint
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
    internal struct NSSize
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
    internal struct NSRect
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

    // Using IntPtr in NSFloat cause that if imported function
    // return struct that consist of them you will get wrong data
    // This types are used for such function.
    [StructLayout(LayoutKind.Sequential)]
    internal struct NSPointF
    {
        public float X;
        public float Y;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct NSPointD
    {
        public double X;
        public double Y;
    }
}

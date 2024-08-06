using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;

namespace OpenTK.Platform.Native.macOS
{
    // FIXME: Add ToString methods.

    [DebuggerDisplay("{Handle}")]
    internal struct ObjCClass
    {
        public IntPtr Handle;

        public ObjCClass(IntPtr handle)
        {
            Handle = handle;
        }

        public static explicit operator ObjCClass(IntPtr ptr) => new ObjCClass(ptr);
        public static explicit operator IntPtr(ObjCClass cls) => cls.Handle;
    }

    [DebuggerDisplay("{Handle}")]
    internal struct SEL
    {
        public static SEL Null => new SEL(0);

        public IntPtr Handle;

        public SEL(IntPtr handle)
        {
            Handle = handle;
        }
    }

    internal struct objc_super
    {
        public IntPtr /* id */ receiver;
        public ObjCClass pclass;
    }

    internal struct CGPoint : IEquatable<CGPoint>
    {
        public static readonly CGPoint Zero = new CGPoint(0, 0);

        public NFloat x;
        public NFloat y;

        public CGPoint(NFloat x, NFloat y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object? obj)
        {
            return obj is CGPoint point && Equals(point);
        }

        public bool Equals(CGPoint other)
        {
            return x.Equals(other.x) &&
                   y.Equals(other.y);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }

        public static bool operator ==(CGPoint left, CGPoint right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(CGPoint left, CGPoint right)
        {
            return !(left == right);
        }

        public static CGPoint operator +(CGPoint left, CGPoint right)
        {
            return new CGPoint(left.x + right.x, left.y + right.y);
        }

        public static explicit operator Vector2(CGPoint p)
        {
            return new Vector2((float)p.x, (float)p.y);
        }

        public static explicit operator Vector2i(CGPoint p)
        {
            return new Vector2i((int)p.x, (int)p.y);
        }
    }
    
    internal struct CGRect
    {
        public CGPoint origin;
        // FIXME: Change this to a CGSize struct?
        public CGPoint size;

        public bool IsZeroRect => origin == CGPoint.Zero && size == CGPoint.Zero;

        public CGRect(CGPoint origin, CGPoint size)
        {
            this.origin = origin;
            this.size = size;
        }

        public CGRect(NFloat x, NFloat y, NFloat width, NFloat height)
        {
            origin = new CGPoint(x, y);
            size = new CGPoint(width, height);
        }

        public bool Contains(CGPoint point)
        {
            if (point.x >= origin.x && point.x < origin.x + size.x &&
                point.y >= origin.y && point.y < origin.y + size.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{origin} - {size}";
        }
    }

    internal struct NSEdgeInsets
    {
        public NFloat top;
        public NFloat left;
        public NFloat bottom;
        public NFloat right;
    }

    internal struct NSRange
    {
        public nuint location;
        public nuint length;

        public static NSRange kEmptyRange = new NSRange((uint)nint.MaxValue, 0);

        public NSRange(nuint location, nuint length)
        {
            this.location = location;
            this.length = length;
        }
    }

    internal struct NSSize
    {
        public static NSSize NSZeroSize => new NSSize(0, 0);

        public NFloat width;
        public NFloat height;

        public NSSize(NFloat width, NFloat height)
        {
            this.width = width;
            this.height = height;
        }

        public override string ToString()
        {
            return $"({width}, {height})";
        }
    }
}


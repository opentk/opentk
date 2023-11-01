﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

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
        public IntPtr Handle;

        public SEL(IntPtr handle)
        {
            Handle = handle;
        }
    }

    internal struct CGPoint
    {
        public static readonly CGPoint Zero = new CGPoint(0, 0);

        public NFloat x;
        public NFloat y;

        public CGPoint(NFloat x, NFloat y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
    
    internal struct CGRect
    {
        public CGPoint origin;
        public CGPoint size;

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

        public override string ToString()
        {
            return $"{origin} - {size}";
        }
    }
}

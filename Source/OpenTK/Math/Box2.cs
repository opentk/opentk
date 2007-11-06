using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Math
{
    /// <summary>
    /// Defines a rectangle.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Box2
    {
        public Box2(Vector2 topLeft, Vector2 bottomRight)
        {
            Left = topLeft.X;
            Top = topLeft.Y;
            Right = topLeft.X;
            Bottom = topLeft.Y;
        }
        public Box2(float left, float top, float right, float bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }
        public float Left, Right, Top, Bottom;
        public float Width { get { return (float)System.Math.Abs(Right - Left); } }
        public float Height { get { return (float)System.Math.Abs(Bottom - Top); } }
        public static Box2 FromTLRB(float top, float left, float right, float bottom)
        {
            return new Box2(left, top, right, bottom);
        }
    }
}

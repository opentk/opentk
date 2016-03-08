﻿// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Math
{
    /// <summary>
    /// Defines a 2d box (rectangle).
    /// </summary>
    [Obsolete("OpenTK.Math functions have been moved to the root OpenTK namespace (reason: XNA compatibility")]
    [StructLayout(LayoutKind.Sequential)]
    public struct Box2
    {
        /// <summary>
        /// The left boundary of the structure.
        /// </summary>
        public float Left;

        /// <summary>
        /// The right boundary of the structure.
        /// </summary>
        public float Right;

        /// <summary>
        /// The top boundary of the structure.
        /// </summary>
        public float Top;

        /// <summary>
        /// The bottom boundary of the structure.
        /// </summary>
        public float Bottom;

        /// <summary>
        /// Constructs a new Box2 with the specified dimensions.
        /// </summary>
        /// <param name="topLeft">AnOpenTK.Vector2 describing the top-left corner of the Box2.</param>
        /// <param name="bottomRight">An OpenTK.Vector2 describing the bottom-right corner of the Box2.</param>
        public Box2(Vector2 topLeft, Vector2 bottomRight)
        {
            Left = topLeft.X;
            Top = topLeft.Y;
            Right = topLeft.X;
            Bottom = topLeft.Y;
        }

        /// <summary>
        /// Constructs a new Box2 with the specified dimensions.
        /// </summary>
        /// <param name="left">The position of the left boundary.</param>
        /// <param name="top">The position of the top boundary.</param>
        /// <param name="right">The position of the right boundary.</param>
        /// <param name="bottom">The position of the bottom boundary.</param>
        public Box2(float left, float top, float right, float bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        /// <summary>
        /// Creates a new Box2 with the specified dimensions.
        /// </summary>
        /// <param name="top">The position of the top boundary.</param>
        /// <param name="left">The position of the left boundary.</param>
        /// <param name="right">The position of the right boundary.</param>
        /// <param name="bottom">The position of the bottom boundary.</param>
        /// <returns>A new OpenTK.Box2 with the specfied dimensions.</returns>
        public static Box2 FromTLRB(float top, float left, float right, float bottom)
        {
            return new Box2(left, top, right, bottom);
        }

        /// <summary>
        /// Gets a float describing the width of the Box2 structure.
        /// </summary>
        public float Width { get { return (float)System.Math.Abs(Right - Left); } }

        /// <summary>
        /// Gets a float describing the height of the Box2 structure.
        /// </summary>
        public float Height { get { return (float)System.Math.Abs(Bottom - Top); } }

        public override string ToString()
        {
            return String.Format("({0},{1})-({2},{3})", Left, Top, Right, Bottom);
        }
    }
}

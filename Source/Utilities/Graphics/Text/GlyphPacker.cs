#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OpenTK.Graphics.Text
{
    class GlyphPacker
    {
        Node root;

        #region --- Constructors ---

        public GlyphPacker(int width, int height)
        {
            if (width <= 0)
                throw new ArgumentOutOfRangeException("width", width, "Must be greater than zero.");
            if (height <= 0)
                throw new ArgumentOutOfRangeException("height", height, "Must be greater than zero.");

            root = new Node();
            root.Rectangle = new Rectangle(0, 0, width, width);
        }

        #endregion

        #region --- Public Methods ---

        #region public bool TryAdd(Rectangle boundingBox)

        /// <summary>
        /// Adds boundingBox to the GlyphPacker.
        /// </summary>
        /// <param name="boundingBox">The bounding box of the item to pack.</param>
        /// <param name="packedRectangle">The System.Drawing.Rectangle that contains the position of the packed item.</param>
        /// <returns>True, if the item was successfully packed; false if the item is too big for this packer..</returns>
        /// <exception cref="InvalidOperationException">Occurs if the item is larger than the available TexturePacker area</exception>
        /// <exception cref="TexturePackerFullException">Occurs if the item cannot fit in the remaining packer space.</exception>
        public bool TryAdd(Rectangle boundingBox, out Rectangle packedRectangle)
        {
            if (!root.Rectangle.Contains(boundingBox))
            {
                packedRectangle = new Rectangle();
                return false;
            }

            // Increase size so that the glyphs do not touch each other (to avoid rendering artifacts).
            boundingBox.Width += 2;
            boundingBox.Height += 2;

            Node node = root.Insert(boundingBox);

            // Tree is full and insertion failed:
            if (node == null)
            {
                packedRectangle = new Rectangle();
                return false;
            }

            packedRectangle = new Rectangle(node.Rectangle.X, node.Rectangle.Y, node.Rectangle.Width - 2, node.Rectangle.Height - 2);
            return true;
        }

        #endregion

        #region public Rectangle TryAdd(RectangleF boundingBox)

        /// <summary>
        /// Adds boundingBox to the GlyphPacker.
        /// </summary>
        /// <param name="boundingBox">The bounding box of the item to pack.</param>
        /// <param name="packedRectangle">The System.Drawing.RectangleF that contains the position of the packed item.</param>
        /// <returns>True, if the item was successfully packed; false if the item is too big for this packer..</returns>
        /// <exception cref="InvalidOperationException">Occurs if the item is larger than the available TexturePacker area</exception>
        /// <exception cref="TexturePackerFullException">Occurs if the item cannot fit in the remaining packer space.</exception>
        public bool TryAdd(RectangleF boundingBox, out RectangleF packedRectangle)
        {
            Rectangle bbox = new Rectangle(
                (int)boundingBox.X, (int)boundingBox.Y,
                (int)(boundingBox.Width + 0.5f), (int)(boundingBox.Height + 0.5f));

            return TryAdd(bbox, out packedRectangle);
        }

        #endregion

        #region public Rectangle Add(Rectangle boundingBox)

        /// <summary>
        /// Adds boundingBox to the GlyphPacker.
        /// </summary>
        /// <param name="boundingBox">The bounding box of the item to pack.</param>
        /// <returns>A System.Drawing.Rectangle containing the coordinates of the packed item.</returns>
        /// <exception cref="InvalidOperationException">Occurs if the item is larger than the available TexturePacker area</exception>
        /// <exception cref="TexturePackerFullException">Occurs if the item cannot fit in the remaining packer space.</exception>
        public Rectangle Add(Rectangle boundingBox)
        {
            if (!TryAdd(boundingBox, out boundingBox))
                throw new TexturePackerFullException();

            return boundingBox;
        }

        #endregion

        #region public Rectangle Add(RectangleF boundingBox)

        /// <summary>
        /// Rounds boundingBox to the largest integer and adds the resulting Rectangle to the GlyphPacker.
        /// </summary>
        /// <param name="boundingBox">The bounding box of the item to pack.</param>
        /// <returns>A System.Drawing.Rectangle containing the coordinates of the packed item.</returns>
        /// <exception cref="InvalidOperationException">Occurs if the item is larger than the available TexturePacker area</exception>
        /// <exception cref="ArgumentException">Occurs if the item already exists in the TexturePacker.</exception>
        public Rectangle Add(RectangleF boundingBox)
        {
            Rectangle bbox = new Rectangle(
                (int)boundingBox.X, (int)boundingBox.Y,
                (int)(boundingBox.Width + 0.5f), (int)(boundingBox.Height + 0.5f));

            return Add(bbox);
        }

        #endregion

        #region public void Clear()

        /// <summary>
        /// Discards all packed items.
        /// </summary>
        public void Clear()
        {
            root.Clear();
        }

        #endregion

        #endregion

        #region Node

        class Node
        {
            public Node()
            {
            }

            Node left, right;
            Rectangle rect;
            bool occupied;

            public Rectangle Rectangle { get { return rect; } set { rect = value; } }
            public Node Left { get { return left; } set { left = value; } }
            public Node Right { get { return right; } set { right = value; } }

            #region --- Constructor ---

            public bool Leaf
            {
                get { return left == null && right == null; }
            }

            #endregion

            #region Node Insert(Rectangle bbox)

            public Node Insert( Rectangle bbox)
            {
                if (!this.Leaf)
                {
                    // Recurse towards left child, and if that fails, towards the right.
                    Node new_node = left.Insert(bbox);
                    return new_node ?? right.Insert(bbox);
                }
                else
                {
                    // We have recursed to a leaf.

                    // If it is not empty go back.
                    if (occupied)
                        return null;

                    // If this leaf is too small go back.
                    if (rect.Width < bbox.Width || rect.Height < bbox.Height)
                        return null;

                    // If this leaf is the right size, insert here.
                    if (rect.Width == bbox.Width && rect.Height == bbox.Height)
                    {
                        occupied = true;
                        return this;
                    }

                    // This leaf is too large, split it up. We'll decide which way to split
                    // by checking the width and height difference between this rectangle and
                    // out item's bounding box. If the width difference is larger, we'll split
                    // horizontaly, else verticaly.
                    left = new Node();
                    right = new Node();

                    int dw = this.rect.Width - bbox.Width + 1;
                    int dh = this.rect.Height - bbox.Height + 1;

                    if (dw > dh)
                    {
                        left.rect = new Rectangle(rect.Left, rect.Top, bbox.Width, rect.Height);
                        right.rect = new Rectangle(rect.Left + bbox.Width, rect.Top, rect.Width - bbox.Width, rect.Height);
                    }
                    else
                    {
                        left.rect = new Rectangle(rect.Left, rect.Top, rect.Width, bbox.Height);
                        right.rect = new Rectangle(rect.Left, rect.Top + bbox.Height, rect.Width, rect.Height - bbox.Height);
                    }

                    return left.Insert(bbox);
                }
            }

            #endregion

            #region public void Clear()
            
            public void Clear()
            {
                if (left != null)
                    left.Clear();
                if (right != null)
                    right.Clear();

                left = right = null;
            }

            #endregion
        }

        #endregion
    }

    class TexturePackerFullException : Exception
    {
        public TexturePackerFullException() : base("There is not enough space to add this item. Consider calling the Clear() method.") { }
    }
}

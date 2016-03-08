﻿// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace OpenTK
{
    class TexturePacker<T> where T : IPackable<T>
    {
        Node root;

        #region --- Constructors ---

        public TexturePacker(int width, int height)
        {
            if (width <= 0)
                throw new ArgumentOutOfRangeException("width", width, "Must be greater than zero.");
            if (height <= 0)
                throw new ArgumentOutOfRangeException("height", height, "Must be greater than zero.");

            root = new Node();
            root.Rect = new Rectangle(0, 0, width, width);
        }

        #endregion

        #region --- Public Methods ---

        #region public Rectangle Add(T item)

        // Packs the given item into the free space of the TexturePacker. Returns the Rectangle of the packed item.
        public void Add(T item, out Rectangle rect)
        {
            if (item.Width > root.Rect.Width || item.Height > root.Rect.Height)
                throw new InvalidOperationException("The item is too large for this TexturePacker");

            Node node;
            //if (!items.ContainsKey(item))
            {
                node = root.Insert(item);

                // Tree is full and insertion failed:
                if (node == null)
                    throw new TexturePackerFullException();

                //items.Add(item, node);
                rect = node.Rect;
            }
            //throw new ArgumentException("The item already exists in the TexturePacker.", "item");
        }

        #endregion

        #region public void Clear()

        /// <summary>
        /// Discards all packed items.
        /// </summary>
        public void Clear()
        {
            //items.Clear();
            root.Clear();
        }

        #endregion

        #region public void ChangeSize(int new_width, int new_height)

        /// <summary>
        /// Changes the dimensions of the TexturePacker surface.
        /// </summary>
        /// <param name="new_width">The new width of the TexturePacker surface.</param>
        /// <param name="new_height">The new height of the TexturePacker surface.</param>
        /// <remarks>Changing the size of the TexturePacker surface will implicitly call TexturePacker.Clear().</remarks>
        /// <seealso cref="Clear"/>
        public void ChangeSize(int new_width, int new_height)
        {
            throw new NotImplementedException();
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
            int use_count;

            public Rectangle Rect { get { return rect; } set { rect = value; } }
            public Node Left { get { return left; } set { left = value; } }
            public Node Right { get { return right; } set { right = value; } }

            #region --- Constructor ---

            public bool Leaf
            {
                get { return left == null && right == null; }
            }

            #endregion

            #region public Node Insert(T item)

            public Node Insert(T item)
            {
                if (!this.Leaf)
                {
                    // Recurse towards left child, and if that fails, towards the right.
                    Node new_node = left.Insert(item);
                    return new_node ?? right.Insert(item);
                }
                else
                {
                    // We have recursed to a leaf.

                    // If it is not empty go back.
                    if (use_count != 0)
                        return null;

                    // If this leaf is too small go back.
                    if (rect.Width < item.Width || rect.Height < item.Height)
                        return null;

                    // If this leaf is the right size, insert here.
                    if (rect.Width == item.Width && rect.Height == item.Height)
                    {
                        use_count = 1;
                        return this;
                    }

                    // This leaf is too large, split it up. We'll decide which way to split
                    // by checking the width and height difference between this rectangle and
                    // out item's bounding box. If the width difference is larger, we'll split
                    // horizontaly, else verticaly.
                    left = new Node();
                    right = new Node();

                    int dw = this.rect.Width - item.Width + 1;
                    int dh = this.rect.Height - item.Height + 1;

                    if (dw > dh)
                    {
                        left.rect = new Rectangle(rect.Left, rect.Top, item.Width, rect.Height);
                        right.rect = new Rectangle(rect.Left + item.Width, rect.Top, rect.Width - item.Width, rect.Height);
                    }
                    else
                    {
                        left.rect = new Rectangle(rect.Left, rect.Top, rect.Width, item.Height);
                        right.rect = new Rectangle(rect.Left, rect.Top + item.Height, rect.Width, rect.Height - item.Height);
                    }

                    return left.Insert(item);
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

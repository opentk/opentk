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

        #region public Rectangle Add(Rectangle boundingBox)

        /// <summary>
        /// Adds boundingBox to the GlyphPacker.
        /// </summary>
        /// <param name="boundingBox">The bounding box of the item to pack.</param>
        /// <returns>A System.Drawing.Rectangle containing the coordinates of the packed item.</returns>
        /// <exception cref="InvalidOperationException">Occurs if the item is larger than the available TexturePacker area</exception>
        /// <exception cref="ArgumentException">Occurs if the item already exists in the TexturePacker.</exception>
        public Rectangle Add(Rectangle boundingBox)
        {
            if (!root.Rectangle.Contains(boundingBox))
                throw new InvalidOperationException("The item is too large for this TexturePacker");

            Node node;
            node = root.Insert(boundingBox);

            // Tree is full and insertion failed:
            if (node == null)
                throw new TexturePackerFullException();

            return node.Rectangle;
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

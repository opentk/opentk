using OpenToolkit.Windowing.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OpenToolkit.Windowing.Interfaces
{
    public interface IWindowInput
    {

        /// <summary>
        /// Gets or sets the <see cref="OpenTK.MouseCursor" /> for this window.
        /// </summary>
        /// <value>The cursor.</value>
        MouseCursor Cursor { get; set; }

        /// <summary>
        /// Gets or sets a value, indicating whether the mouse cursor is visible.
        /// </summary>
        bool CursorVisible { get; set; }

        //        /// <summary>
        //        /// Gets or sets a value, indicating whether the mouse cursor is confined inside the window size.
        //        /// </summary>
        //        bool CursorGrabbed { get; set; }

        /// <summary>
        /// Transforms the specified point from screen to client coordinates.
        /// </summary>
        /// <param name="point">
        /// A <see cref="System.Drawing.Point" /> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to client coordinates.
        /// </returns>
        Point PointToClient(Point point);

        /// <summary>
        /// Transforms the specified point from client to screen coordinates.
        /// </summary>
        /// <param name="point">
        /// A <see cref="System.Drawing.Point" /> to transform.
        /// </param>
        /// <returns>
        /// The point transformed to screen coordinates.
        /// </returns>
        Point PointToScreen(Point point);
    }
}

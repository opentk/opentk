#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion


using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.OpenGL
{
    /// <summary>
    /// Provides methods to create and render a display list.
    /// </summary>
    public class DisplayList : IDisposable
    {
        #region --- Private variables ---

        private int id = -1;

        #endregion

        #region --- Constructors ---

        /// <summary>
        /// Allocates a new DisplayList.
        /// </summary>
        public DisplayList()
        {
            Id = GL.GenLists(1);
        }

        #endregion

        #region --- Public properties ---

        /// <summary>
        /// Gets the display list number.
        /// </summary>
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        #endregion

        #region --- Public methods ---

        /// <summary>
        /// Starts recording elements into the display list.
        /// </summary>
        public void Begin()
        {
            GL.NewList(Id, Enums.ListMode.COMPILE);
        }

        /// <summary>
        /// Starts recording elements into the display list.
        /// </summary>
        /// <param name="listMode">Sets if the list is to be compiled or compiled and executed immediately.</param>
        public void Begin(Enums.ListMode listMode)
        {
            GL.NewList(Id, listMode);
        }

        /// <summary>
        /// Stops recording elements into the display list.
        /// </summary>
        public void End()
        {
            GL.EndList();
        }

        /// <summary>
        /// Renders the display list elements.
        /// </summary>
        public void Render()
        {
            GL.CallList(Id);
        }

        #region IDisposable Members

        public void Dispose()
        {
            if (Id > 0)
                GL.DeleteLists(Id, 1);
            Id = -1;
        }

        #endregion

        #endregion
    }
}

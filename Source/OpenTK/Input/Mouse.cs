using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Provides access to mouse devices.
    /// </summary>
    public static class Mouse
    {
        #region Fields

        static IMouseDriver driver;

        #endregion

        #region Constructors

        static Mouse()
        {
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Retrieves the MouseState for the specified mouse device.
        /// </summary>
        /// <param name="index">The index of the mouse device.</param>
        /// <returns>A <see cref="OpenTK.Input.MouseState"/> structure containing the state of the mouse device.</returns>
        public static MouseState GetState(int index)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

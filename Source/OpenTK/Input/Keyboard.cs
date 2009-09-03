using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Input
{
    /// <summary>
    /// Provides access to keyboard devices.
    /// </summary>
    public static class Keyboard
    {
        #region Fields

        static IKeyboardDriver driver;

        #endregion

        #region Constructors

        static Keyboard()
        {
            throw new NotImplementedException();
            //driver = Platform.Factory.Default.CreateKeyboardDriver();
        }

        #endregion

        #region Public Members

        /// <summary>
        /// Retrieves the KeyboardState for the default keyboard device.
        /// </summary>
        /// <returns>A <see cref="OpenTK.Input.KeyboardState"/> structure containing the state of the keyboard device.</returns>
        public static KeyboardState GetState()
        {
            return new KeyboardState();
        }

        /// <summary>
        /// Retrieves the KeyboardState for the specified keyboard device.
        /// </summary>
        /// <param name="index">The index of the keyboard device.</param>
        /// <returns>A <see cref="OpenTK.Input.KeyboardState"/> structure containing the state of the keyboard device.</returns>
        public static KeyboardState GetState(int index)
        {
            return new KeyboardState();
        }

        #endregion
    }
}

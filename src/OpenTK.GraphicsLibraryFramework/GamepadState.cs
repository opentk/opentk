namespace OpenToolkit.GraphicsLibraryFramework
{
    public struct GamepadState
    {
        /// <summary>
        /// State of each of the 15 gamepad buttons, equal to <see cref="InputAction.Press"/> or <see cref="InputAction.Release"/>.
        /// </summary>
        public byte[] Buttons;
        
        /// <summary>
        /// State of each of the 6 gamepad axes, ranging from -1.0 to 1.0.
        /// </summary>
        public float[] Axes;
    }
}
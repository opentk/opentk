namespace OpenTK.Input.Hid
{
    /// <summary>
    /// Describes usages for the <see cref="HidPage.Consumer"/> page.
    /// </summary>
    public enum HidConsumerUsage : ushort
    {
        /// <summary>
        /// General consumer control device.
        /// </summary>
        ConsumerControl = 0x01,

        /// <summary>
        /// Set the horizontal offset of the display in the document.
        /// </summary>
        ACPan = 0x0238,
    }
}

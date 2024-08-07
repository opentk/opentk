#nullable enable

namespace OpenTK.Platform
{
    /// <summary>
    /// Message box types deciding the default icon and button layout.
    /// </summary>
    public enum MessageBoxType
    {
        /// <summary>
        /// An informational dialog containing a single <see cref="MessageBoxButton.Ok"/> button.
        /// </summary>
        Information,

        /// <summary>
        /// A warning dialog containing a single <see cref="MessageBoxButton.Ok"/> button.
        /// </summary>
        Warning,

        /// <summary>
        /// An error dialog containing a single <see cref="MessageBoxButton.Ok"/> button.
        /// </summary>
        Error,

        /// <summary>
        /// An confirmation dialog containing a <see cref="MessageBoxButton.Yes"/>, <see cref="MessageBoxButton.No"/>, and <see cref="MessageBoxButton.Cancel"/> button.
        /// </summary>
        Confirmation,

        /// <summary>
        /// An retry dialog containing a <see cref="MessageBoxButton.Retry"/> and <see cref="MessageBoxButton.Cancel"/> button.
        /// </summary>
        Retry,
    }
}

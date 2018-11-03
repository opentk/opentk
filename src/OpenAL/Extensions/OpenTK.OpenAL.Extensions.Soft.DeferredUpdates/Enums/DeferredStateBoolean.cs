using OpenToolkit.OpenAL.Interfaces;

namespace OpenToolkit.OpenAL.Extensions.Soft.DeferredUpdates
{
    /// <summary>
    /// A list of valid <see cref="bool"/> <see cref="IState.GetBoolean"/> parameters.
    /// </summary>
    public enum DeferredStateBoolean
    {
        /// <summary>
        /// Determines whether or not updates are currently deferred.
        /// </summary>
        /// <seealso cref="IDeferredUpdatesState.DeferUpdates"/>
        /// <seealso cref="IDeferredUpdatesState.ProcessUpdates"/>
        AreUpdatesDeferred = 0xC002,
    }
}

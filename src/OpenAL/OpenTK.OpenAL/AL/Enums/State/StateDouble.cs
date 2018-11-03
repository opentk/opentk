using OpenToolkit.OpenAL.Interfaces;

namespace OpenToolkit.OpenAL
{
    /// <summary>
    /// A list of valid <see cref="double"/> <see cref="IState.GetStateProperty(StateDouble)"/> parameters.
    /// </summary>
    public enum StateDouble
    {
        /// <summary>
        /// Scale for source and listener velocities.
        /// </summary>
        DopplerFactor = 0xC000,

        /// <summary>
        /// The speed at which sound waves are assumed to travel, when calculating the doppler effect.
        /// </summary>
        SpeedOfSound = 0xC003
    }
}

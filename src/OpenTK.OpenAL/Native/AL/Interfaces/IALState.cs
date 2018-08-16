using AdvancedDLSupport;

namespace OpenTK.OpenAL.Native.Interfaces
{
    /// <summary>
    /// Defines the public interface for the state-related functions of OpenAL 1.1.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    public interface IALState
    {
        /// <summary>
        /// Enables a capability in the state.
        /// </summary>
        /// <param name="capability">The capability.</param>
        void Enable(ALCapability capability);

        /// <summary>
        /// Disables a capability in the state.
        /// </summary>
        /// <param name="capability">The capability.</param>
        void Disable(ALCapability capability);

        /// <summary>
        /// Determines whether or not the given capability is enabled.
        /// </summary>
        /// <param name="capability">The capability.</param>
        /// <returns>true if the capability is enabled; otherwise, false.</returns>
        bool IsEnabled(ALCapability capability);

        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        bool GetBoolean(StateBoolean param);

        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        double GetDouble(StateDouble param);

        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        float GetFloat(StateFloat param);

        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        int GetInteger(StateInteger param);

        /// <summary>
        /// Gets a named value from the state.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        string GetString(StateString param);

        /// <summary>
        /// Sets the model by which sources attenuate with distance.
        /// </summary>
        /// <param name="distanceModel">The distance model.</param>
        void DistanceModel(DistanceModel distanceModel);

        /// <summary>
        /// Doppler scale.
        /// Range: [0.0 - ]
        /// Default: 1.0
        ///
        /// Sets the scale for source and listener velocities.
        /// </summary>
        /// <param name="value">The scale.</param>
        void DopplerFactor(float value);

        /// <summary>
        /// Speed of sound, in units per second.
        ///
        /// Range: [0.0001 - ]
        /// Default: 343.3
        ///
        /// Sets the speed at which sound waves are assumed to travel, when calculating the doppler effect.
        /// </summary>
        /// <param name="value">The speed of sound.</param>
        void SpeedOfSound(float value);
    }
}


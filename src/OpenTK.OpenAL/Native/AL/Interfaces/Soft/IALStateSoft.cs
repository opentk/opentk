using System;
using AdvancedDLSupport;
// ReSharper disable ExplicitCallerInfoArgument

namespace OpenTK.OpenAL.Native.Interfaces
{
    /// <summary>
    /// Defines the public interface for the state-related functions of OpenAL 1.1 (OpenAL Soft).
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    public interface IALStateSoft
    {
        /// <summary>
        /// Gets a named value from the state. This overload covers additional valid values added by OpenAL
        /// Soft.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        bool GetBoolean(ALGetBooleanSoft param);

        /// <summary>
        /// Gets a named value from the state. This overload covers additional valid values added by OpenAL
        /// Soft.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        double GetDouble(ALGetDoubleSoft param);

        /// <summary>
        /// Gets a named value from the state. This overload covers additional valid values added by OpenAL
        /// Soft.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        float GetFloat(ALGetFloatSoft param);

        /// <summary>
        /// Gets a named value from the state. This overload covers additional valid values added by OpenAL
        /// Soft.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        int GetInteger(ALGetIntegerSoft param);

        /// <summary>
        /// Gets a named value from the state. This overload covers additional valid values added by OpenAL
        /// Soft.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        [NativeSymbol("GetPointerSOFT")]
        IntPtr GetPointer(ALGetPointerSoft param);

        /// <summary>
        /// Defers updates until <see cref="ProcessUpdates"/> is called.
        ///
        /// When called, samples will continue to render and be sent to the output device, but the effects of changing
        /// playback properties, such as the source or listener gain, or auxiliary slot gain or effect if EFX is
        /// supported, among others, will be deferred. Multiple changes can be batched so that they all apply at once at
        /// a later time.
        /// </summary>
        [NativeSymbol("DeferUpdatesSOFT")]
        void DeferUpdates();

        /// <summary>
        /// Resumes update processing, reverting a call to <see cref="DeferUpdates"/>.
        ///
        /// Once called, all pending deferred updates will be processed. Any following state changes will also apply as
        /// normal.
        /// </summary>
        [NativeSymbol("ProcessUpdatesSOFT")]
        void ProcessUpdates();
    }
}


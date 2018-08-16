using AdvancedDLSupport;
// ReSharper disable ExplicitCallerInfoArgument

namespace OpenTK.OpenAL.Native.Extensions.Creative.EFX
{
    /// <summary>
    /// Defines the public API of the source-related functions of the Effects Extension.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    internal interface IEFXSources
    {
        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Sourcei")]
        void SetSourceProperty(uint source, SourceInteger param, int value);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Sourcef")]
        void SetSourceProperty(uint source, SourceFloat param, float value);

        /// <summary>
        /// Sets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Sourceb")]
        void SetSourceProperty(uint source, SourceBoolean param, bool value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("GetSourcei")]
        void GetSourceProperty(uint source, SourceInteger param, out int value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("GetSourcef")]
        void GetSourceProperty(uint source, SourceFloat param, out float value);

        /// <summary>
        /// Gets the value of a named property on the given source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("GetSourceb")]
        void GetSourceProperty(uint source, SourceBoolean param, out bool value);
    }
}

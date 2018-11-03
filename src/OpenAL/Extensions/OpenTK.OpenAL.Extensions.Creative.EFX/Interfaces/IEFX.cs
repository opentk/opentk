using AdvancedDLSupport;

namespace OpenTK.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// Defines the public API of the Effect Extension.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    internal interface IEFX : IEFXEffectSlots, IEFXEffects, IEFXFilters, IEFXSources, IEFXListeners
    {
    }
}

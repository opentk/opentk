namespace Bind.XML
{
    /// <summary>
    /// This class is responsible for taking the full set of signatures and the full set of overrides, and then
    /// combining them into final specification profiles.
    ///
    /// In short, it performs a union of all elements in a version range in both sets, applies the override set to the
    /// profile set, and then performs a language-specific translation step to adjust the baked profile such that it's
    /// valid in the context of a given language.
    /// </summary>
    public class ProfileBaker
    {
    }
}

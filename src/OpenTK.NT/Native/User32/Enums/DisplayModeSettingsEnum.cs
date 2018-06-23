using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    public enum DisplayModeSettingsEnum : DWORD
    {
        CurrentSettings = unchecked((DWORD)(-1)),
        RegistrySettings = unchecked((DWORD)(-2))
    }
}

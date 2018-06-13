using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    public enum DisplayModeSettingsEnum : DWORD
    {
        CurrentSettings = unchecked((uint)-1),
        RegistrySettings = unchecked((uint)-2)
    }
}

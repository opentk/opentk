using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    public enum DisplayModeSettingsEnum : DWORD
    {
        CurrentSettings = 0xFFFFFFFF, // ((DWORD)-1)
        RegistrySettings = 0xFFFFFFFE // ((DWORD)-2)
    }
}

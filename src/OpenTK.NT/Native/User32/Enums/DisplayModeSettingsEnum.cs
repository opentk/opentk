using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    public enum DisplayModeSettingsEnum : DWORD
    {
        CURRENT_SETTINGS = unchecked((uint)-1),
        REGISTRY_SETTINGS = unchecked((uint)-2)
    }
}

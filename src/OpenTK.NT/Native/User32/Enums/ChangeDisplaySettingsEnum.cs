using System;

namespace OpenTK.NT.Native
{
    [Flags]
    public enum ChangeDisplaySettingsEnum
    {
        UpdateRegistry = 0x00000001,
        Test = 0x00000002,
        Fullscreen = 0x00000004
    }
}

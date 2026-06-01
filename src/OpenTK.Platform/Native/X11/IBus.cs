using System;

namespace OpenTK.Platform.Native.X11
{
    [Flags]
    internal enum IBusModifierType
    {
        ShiftMask    = 1 << 0,
        LockMask     = 1 << 1,
        ControlMask  = 1 << 2,
        Mod1Mask     = 1 << 3,
        Mod2Mask     = 1 << 4,
        Mod3Mask     = 1 << 5,
        Mod4Mask     = 1 << 6,
        Mod5Mask     = 1 << 7,
        Button1Mask  = 1 << 8,
        Button2Mask  = 1 << 9,
        Button3Mask  = 1 << 10,
        Button4Mask  = 1 << 11,
        Button5Mask  = 1 << 12,

        /* The next few modifiers are used by XKB, so we skip to the end.
        * Bits 15 - 23 are currently unused. Bit 29 is used internally.
        */

        /* ibus mask */
        HandledMask  = 1 << 24,
        ForwardMask  = 1 << 25,
        IgnoredMask  = ForwardMask,

        SuperMask    = 1 << 26,
        HyperMask    = 1 << 27,
        MetaMask     = 1 << 28,

        ReleaseMask  = 1 << 30,

        ModifierMask = 0x5f001fff
    }

    [Flags]
    internal enum IBusCapabilite : int
    {
        PreeditText       = 1 << 0,
        AuxiliaryText     = 1 << 1,
        LookupTable       = 1 << 2,
        Focus              = 1 << 3,
        Property           = 1 << 4,
        SurroundingText   = 1 << 5,
        Osk               = 1 << 6,
        SyncProcessKey   = 1 << 7,
        SyncProcessKeyV2 = SyncProcessKey,
    }
}

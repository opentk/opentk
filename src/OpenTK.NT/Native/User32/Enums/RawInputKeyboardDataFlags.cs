namespace OpenTK.NT.Native
{
    public enum RawInputKeyboardDataFlags : ushort
    {
        MAKE = 0,
        BREAK = 1,
        E0 = 2,
        E1 = 4,
        TERMSRV_SET_LED = 8,
        TERMSRV_SHADOW = 0x10
    }
}

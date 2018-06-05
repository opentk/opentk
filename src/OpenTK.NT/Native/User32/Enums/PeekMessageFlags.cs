using System;

namespace OpenTK.NT.Native
{
    [Flags]
    internal enum PeekMessageFlags : uint
    {
        NoRemove = 0,
        Remove = 1,
        NoYield = 2
    }
}

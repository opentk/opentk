using System;

namespace OpenToolkit.Windowing.Common
{
    /// <summary>
    /// Wrapper around an implementation-defined monitor struct.
    /// </summary>
    public struct Monitor
    {
        public Monitor(IntPtr ptr)
        {
            Ptr = ptr;
        }
        
        public IntPtr Ptr;
    }
}
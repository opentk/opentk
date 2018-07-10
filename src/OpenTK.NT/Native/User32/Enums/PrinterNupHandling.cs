﻿using DWORD = System.UInt32;

namespace OpenTK.NT.Native
{
    /// <summary>
    /// Specifies the responsibility for performing page layout for N-up printing.
    /// </summary>
    public enum PrinterNupHandling : DWORD
    {
        /// <summary>
        /// The print server does the page layout.
        /// </summary>
        System = 1,

        /// <summary>
        /// The application does the page layout.
        /// </summary>
        OneUp = 2,
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform
{
    /// <summary>
    /// Contains information about the current state of physical memory.
    /// </summary>
    public struct SystemMemoryInfo
    {
        /// <summary>
        /// The amount of physical memory in bytes.
        /// </summary>
        public ulong TotalPhysicalMemory;

        /// <summary>
        /// The amount of available physical memory in bytes.
        /// </summary>
        public ulong AvailablePhysicalMemory;
    }
}

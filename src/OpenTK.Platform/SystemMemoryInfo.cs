namespace OpenTK.Platform
{
    /// <summary>
    /// Contains information about the current state of physical memory.
    /// </summary>
    public struct SystemMemoryInfo
    {
        /// <summary>
        /// The amount of physical memory (RAM) in bytes.
        /// </summary>
        public long TotalPhysicalMemory;

        /// <summary>
        /// The amount of available physical memory (RAM) in bytes.
        /// This is a rough estimate of available physical memory .
        /// </summary>
        public long AvailablePhysicalMemory;
    }
}

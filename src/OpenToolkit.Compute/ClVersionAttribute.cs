using System;

namespace OpenToolkit.Compute
{
    public class ClVersionAttribute : Attribute
    {
        public byte Major { get; }
        public byte Minor { get; }
        public ClVersionAttribute(byte major, byte minor)
        {
            Major = major;
            Minor = minor;
        }
    }
}

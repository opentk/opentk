#if _NET_CORECLR

namespace System
{
    using System;
    using System.Reflection;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate, Inherited = false)]
    public sealed class SerializableAttribute : Attribute
    {
        public SerializableAttribute()
        {
        }
    }
}
#endif
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenToolkit.Native
{
    public class ApiAttribute : Attribute
    {
        public string Prefix { get; set; }

        public string Name { get; set; }

        public CallingConvention CallingConvention { get; set; }

        public ApiAttribute()
        {
        }

        public ApiAttribute(string name)
        {
            Name = name;
        }

        public static string GetEntryPoint(ApiAttribute attr, ApiAttribute parent, string method)
        {
            return (string.IsNullOrEmpty(attr?.Prefix) ? parent?.Prefix : attr.Prefix) + (string.IsNullOrEmpty(attr?.Name) ? method : attr.Name);
        }

        public static CallingConvention GetCallingConvention(ApiAttribute attr, ApiAttribute parent)
        {
            return attr?.CallingConvention ?? parent?.CallingConvention ?? CallingConvention.Cdecl;
        }
    }
}

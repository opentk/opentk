using System;
using System.Collections.Generic;
using System.Text;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.Audio.OpenAL
{
    public class ApiAttribute : Attribute
    {
        public string DllName { get; set; }

        public Type PlatformNameContainerType { get; set; }

        public ApiAttribute(string dllName, Type platformNameContainerType)
        {
            if (string.IsNullOrEmpty(dllName))
            {
                throw new ArgumentNullException(nameof(dllName));
            }
            else
            {
                DllName = dllName;
            }

            if (typeof(IPlatformLibraryNameContainer).IsAssignableFrom(platformNameContainerType) == false)
            {
                throw new Exception($"Platform name container type must be assignable from {typeof(IPlatformLibraryNameContainer)}!");
            }
            else
            {
                PlatformNameContainerType = platformNameContainerType;
            }
        }
    }
}

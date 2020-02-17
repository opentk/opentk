using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using OpenToolkit.Core.Loader;

namespace OpenToolkit.Audio.OpenAL
{
    public abstract class ApiContainer<T> : ApiBase where T : ApiContainer<T>
    {
        public static readonly Type StaticConstructorTrigger = typeof(T);

        static ApiContainer()
        {
            var apiAttr = typeof(T).GetCustomAttribute<ApiAttribute>();
            AddDllIntercept(apiAttr.DllName, apiAttr.PlatformNameContainerType);
        }
    }
}

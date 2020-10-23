//
// ApiContainer.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenTK.Audio.OpenAL
{
    /// <summary>
    /// This is a base class for OpenAL ALC extensions that are using DllImport and want to resolve different dll names on different platforms.
    /// </summary>
    public abstract class ALCBase
    {
        /// <summary>
        /// This needs to be called before trying to use any OpenAL functions.
        /// This should be done in the static constructor of any class that DllImports OpenAL functions.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void RegisterOpenALResolver()
        {
            ALLoader.RegisterDllResolver();
        }

        /// <summary>
        /// Calls alGetProcAddress and converts the resulting pointer into a delegate.
        /// </summary>
        /// <typeparam name="TDelegate">The delegate type to create.</typeparam>
        /// <param name="device">The AL device to get the ALC extension method from.</param>
        /// <param name="name">The name of the AL proc.</param>
        /// <returns>The created delegate.</returns>
        protected internal static TDelegate LoadDelegate<TDelegate>(ALDevice device, string name) where TDelegate : Delegate
        {
            IntPtr ptr = ALC.GetProcAddress(device, name);
            if (ptr == IntPtr.Zero)
            {
                MethodInfo invoke = typeof(TDelegate).GetMethod("Invoke");
                Type returnType = invoke.ReturnType;
                Type[] parameters = invoke.GetParameters().Select(p => p.ParameterType).ToArray();
                DynamicMethod method = new DynamicMethod(
                    "OpenAL_ALC_Extension_Null_GetProcAddress_Exception_Delegate_" + Guid.NewGuid(),
                    returnType,
                    parameters);
                ILGenerator generator = method.GetILGenerator();

                // Here we are generating a delegate that looks like this:
                // ((<the arguments that the delegate type takes>) =>
                // throw new Exception(<error string>);
                generator.Emit(OpCodes.Ldstr, $"This function could not be loaded from the given {nameof(ALDevice)}. Either you have not set the Device property of the Alc extension you are using or the device you are using doesn't support this extension.");
                generator.Emit(OpCodes.Newobj, typeof(Exception).GetConstructor(new[] { typeof(string) }));
                generator.Emit(OpCodes.Throw);

                return (TDelegate)method.CreateDelegate(typeof(TDelegate));
            }
            else
            {
                return Marshal.GetDelegateForFunctionPointer<TDelegate>(ptr);
            }
        }
    }
}

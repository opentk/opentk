#region License
/*
MIT License
Copyright ©2003-2006 Tao Framework Team
http://www.taoframework.com
All rights reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion License

namespace Tao.OpenAl
{
    using System;
    using System.Runtime.InteropServices;

    [Obsolete]
    internal static class Delegates
    {
        static Delegates()
        {
        }

        /// <summary>
        /// Creates a System.Delegate that can be used to call a dynamically exported OpenAL function.
        /// </summary>
        /// <param name="name">The function string for the OpenAL function</param>
        /// <param name="signature">The signature of the OpenAL function.</param>
        /// <returns>
        /// A System.Delegate that can be used to call this OpenAL function or null
        /// if the function is not available in the current OpenAL context.
        /// </returns>
        public static Delegate GetDelegateForExtensionMethod(string name, Type signature)
        {
            IntPtr address = Al.alGetProcAddress(name);
            if (address == IntPtr.Zero)
            {
                return null;
            }
            else
            {
                return Marshal.GetDelegateForFunctionPointer(address, signature);
            }
        }

        #region X-RAM
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void EAXSetBufferModeDelegate(int n, [Out] int* buffers, int value);
        internal static EAXSetBufferModeDelegate EAXSetBufferMode = (EAXSetBufferModeDelegate)GetDelegateForExtensionMethod("EAXSetBufferMode", typeof(EAXSetBufferModeDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate int EAXGetBufferModeDelegate(int buffer, [Out] int* reserved);
        internal static EAXGetBufferModeDelegate EAXGetBufferMode = (EAXGetBufferModeDelegate)GetDelegateForExtensionMethod("EAXGetBufferMode", typeof(EAXGetBufferModeDelegate));
        #endregion

        #region EFX_EXT
        #region alEffect
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alGenEffectsDelegate(int size, [Out] int* effects);
        internal static alGenEffectsDelegate alGenEffects = (alGenEffectsDelegate)GetDelegateForExtensionMethod("alGenEffects", typeof(alGenEffectsDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alDeleteEffectsDelegate(int size, int* effects);
        internal static alDeleteEffectsDelegate alDeleteEffects = (alDeleteEffectsDelegate)GetDelegateForExtensionMethod("alDeleteEffects", typeof(alDeleteEffectsDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool alIsEffectDelegate(int effect);
        internal static alIsEffectDelegate alIsEffect = (alIsEffectDelegate)GetDelegateForExtensionMethod("alIsEffect", typeof(alIsEffectDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void alEffectiDelegate(int effect, int param, int value);
        internal static alEffectiDelegate alEffecti = (alEffectiDelegate)GetDelegateForExtensionMethod("alEffecti", typeof(alEffectiDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alEffectivDelegate(int effect, int param, int* value);
        internal static alEffectivDelegate alEffectiv = (alEffectivDelegate)GetDelegateForExtensionMethod("alEffectiv", typeof(alEffectivDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void alEffectfDelegate(int effect, int param, float value);
        internal static alEffectfDelegate alEffectf = (alEffectfDelegate)GetDelegateForExtensionMethod("alEffectf", typeof(alEffectfDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alEffectfvDelegate(int effect, int param, float* value);
        internal static alEffectfvDelegate alEffectfv = (alEffectfvDelegate)GetDelegateForExtensionMethod("alEffectfv", typeof(alEffectfvDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alGetEffectiDelegate(int effect, int param, [Out] int* value);
        internal static alGetEffectiDelegate alGetEffecti = (alGetEffectiDelegate)GetDelegateForExtensionMethod("alGetEffecti", typeof(alGetEffectiDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alGetEffectivDelegate(int effect, int param, [Out] int* value);
        internal static alGetEffectivDelegate alGetEffectiv = (alGetEffectivDelegate)GetDelegateForExtensionMethod("alGetEffectiv", typeof(alGetEffectivDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alGetEffectfDelegate(int effect, int param, [Out] float* value);
        internal static alGetEffectfDelegate alGetEffectf = (alGetEffectfDelegate)GetDelegateForExtensionMethod("alGetEffectf", typeof(alGetEffectfDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alGetEffectfvDelegate(int effect, int param, [Out] float* value);
        internal static alGetEffectfvDelegate alGetEffectfv = (alGetEffectfvDelegate)GetDelegateForExtensionMethod("alGetEffectfv", typeof(alGetEffectfvDelegate));
        #endregion

        #region alFilter
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alGenFiltersDelegate(int size, [Out] int* Filters);
        internal static alGenFiltersDelegate alGenFilters = (alGenFiltersDelegate)GetDelegateForExtensionMethod("alGenFilters", typeof(alGenFiltersDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alDeleteFiltersDelegate(int size, int* Filters);
        internal static alDeleteFiltersDelegate alDeleteFilters = (alDeleteFiltersDelegate)GetDelegateForExtensionMethod("alDeleteFilters", typeof(alDeleteFiltersDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool alIsFilterDelegate(int Filter);
        internal static alIsFilterDelegate alIsFilter = (alIsFilterDelegate)GetDelegateForExtensionMethod("alIsFilter", typeof(alIsFilterDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void alFilteriDelegate(int Filter, int param, int value);
        internal static alFilteriDelegate alFilteri = (alFilteriDelegate)GetDelegateForExtensionMethod("alFilteri", typeof(alFilteriDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alFilterivDelegate(int Filter, int param, int* value);
        internal static alFilterivDelegate alFilteriv = (alFilterivDelegate)GetDelegateForExtensionMethod("alFilteriv", typeof(alFilterivDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void alFilterfDelegate(int Filter, int param, float value);
        internal static alFilterfDelegate alFilterf = (alFilterfDelegate)GetDelegateForExtensionMethod("alFilterf", typeof(alFilterfDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alFilterfvDelegate(int Filter, int param, float* value);
        internal static alFilterfvDelegate alFilterfv = (alFilterfvDelegate)GetDelegateForExtensionMethod("alFilterfv", typeof(alFilterfvDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alGetFilteriDelegate(int Filter, int param, [Out] int* value);
        internal static alGetFilteriDelegate alGetFilteri = (alGetFilteriDelegate)GetDelegateForExtensionMethod("alGetFilteri", typeof(alGetFilteriDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alGetFilterivDelegate(int Filter, int param, [Out] int* value);
        internal static alGetFilterivDelegate alGetFilteriv = (alGetFilterivDelegate)GetDelegateForExtensionMethod("alGetFilteriv", typeof(alGetFilterivDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alGetFilterfDelegate(int Filter, int param, [Out] float* value);
        internal static alGetFilterfDelegate alGetFilterf = (alGetFilterfDelegate)GetDelegateForExtensionMethod("alGetFilterf", typeof(alGetFilterfDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alGetFilterfvDelegate(int Filter, int param, [Out] float* value);
        internal static alGetFilterfvDelegate alGetFilterfv = (alGetFilterfvDelegate)GetDelegateForExtensionMethod("alGetFilterfv", typeof(alGetFilterfvDelegate));
        #endregion

        #region alFilter
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alGenAuxiliaryEffectSlotsDelegate(int size, [Out] int* AuxiliaryEffectSlots);
        internal static alGenAuxiliaryEffectSlotsDelegate alGenAuxiliaryEffectSlots = (alGenAuxiliaryEffectSlotsDelegate)GetDelegateForExtensionMethod("alGenAuxiliaryEffectSlots", typeof(alGenAuxiliaryEffectSlotsDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alDeleteAuxiliaryEffectSlotsDelegate(int size, int* AuxiliaryEffectSlots);
        internal static alDeleteAuxiliaryEffectSlotsDelegate alDeleteAuxiliaryEffectSlots = (alDeleteAuxiliaryEffectSlotsDelegate)GetDelegateForExtensionMethod("alDeleteAuxiliaryEffectSlots", typeof(alDeleteAuxiliaryEffectSlotsDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate bool alIsAuxiliaryEffectSlotDelegate(int AuxiliaryEffectSlot);
        internal static alIsAuxiliaryEffectSlotDelegate alIsAuxiliaryEffectSlot = (alIsAuxiliaryEffectSlotDelegate)GetDelegateForExtensionMethod("alIsAuxiliaryEffectSlot", typeof(alIsAuxiliaryEffectSlotDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void alAuxiliaryEffectSlotiDelegate(int AuxiliaryEffectSlot, int param, int value);
        internal static alAuxiliaryEffectSlotiDelegate alAuxiliaryEffectSloti = (alAuxiliaryEffectSlotiDelegate)GetDelegateForExtensionMethod("alAuxiliaryEffectSloti", typeof(alAuxiliaryEffectSlotiDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alAuxiliaryEffectSlotivDelegate(int AuxiliaryEffectSlot, int param, int* value);
        internal static alAuxiliaryEffectSlotivDelegate alAuxiliaryEffectSlotiv = (alAuxiliaryEffectSlotivDelegate)GetDelegateForExtensionMethod("alAuxiliaryEffectSlotiv", typeof(alAuxiliaryEffectSlotivDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal delegate void alAuxiliaryEffectSlotfDelegate(int AuxiliaryEffectSlot, int param, float value);
        internal static alAuxiliaryEffectSlotfDelegate alAuxiliaryEffectSlotf = (alAuxiliaryEffectSlotfDelegate)GetDelegateForExtensionMethod("alAuxiliaryEffectSlotf", typeof(alAuxiliaryEffectSlotfDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alAuxiliaryEffectSlotfvDelegate(int AuxiliaryEffectSlot, int param, float* value);
        internal static alAuxiliaryEffectSlotfvDelegate alAuxiliaryEffectSlotfv = (alAuxiliaryEffectSlotfvDelegate)GetDelegateForExtensionMethod("alAuxiliaryEffectSlotfv", typeof(alAuxiliaryEffectSlotfvDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alGetAuxiliaryEffectSlotiDelegate(int AuxiliaryEffectSlot, int param, [Out] int* value);
        internal static alGetAuxiliaryEffectSlotiDelegate alGetAuxiliaryEffectSloti = (alGetAuxiliaryEffectSlotiDelegate)GetDelegateForExtensionMethod("alGetAuxiliaryEffectSloti", typeof(alGetAuxiliaryEffectSlotiDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alGetAuxiliaryEffectSlotivDelegate(int AuxiliaryEffectSlot, int param, [Out] int* value);
        internal static alGetAuxiliaryEffectSlotivDelegate alGetAuxiliaryEffectSlotiv = (alGetAuxiliaryEffectSlotivDelegate)GetDelegateForExtensionMethod("alGetAuxiliaryEffectSlotiv", typeof(alGetAuxiliaryEffectSlotivDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alGetAuxiliaryEffectSlotfDelegate(int AuxiliaryEffectSlot, int param, [Out] float* value);
        internal static alGetAuxiliaryEffectSlotfDelegate alGetAuxiliaryEffectSlotf = (alGetAuxiliaryEffectSlotfDelegate)GetDelegateForExtensionMethod("alGetAuxiliaryEffectSlotf", typeof(alGetAuxiliaryEffectSlotfDelegate));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        internal unsafe delegate void alGetAuxiliaryEffectSlotfvDelegate(int AuxiliaryEffectSlot, int param, [Out] float* value);
        internal static alGetAuxiliaryEffectSlotfvDelegate alGetAuxiliaryEffectSlotfv = (alGetAuxiliaryEffectSlotfvDelegate)GetDelegateForExtensionMethod("alGetAuxiliaryEffectSlotfv", typeof(alGetAuxiliaryEffectSlotfvDelegate));
        #endregion
        #endregion

    }
}

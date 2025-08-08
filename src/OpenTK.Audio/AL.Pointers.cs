// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Audio;

namespace OpenTK.Audio.OpenAL
{
    /// <summary>A collection of all function pointers to all OpenAL entry points.</summary>
    public static unsafe partial class ALPointers
    {
        /// <summary><b>[entry point: <c>alAuxiliaryEffectSlotf</c>]</b></summary>
        public static delegate* unmanaged<int, int, float, void> _alAuxiliaryEffectSlotf_fnptr = &alAuxiliaryEffectSlotf_Lazy;
        [UnmanagedCallersOnly]
        private static void alAuxiliaryEffectSlotf_Lazy(int effectslot, int param, float flValue)
        {
            _alAuxiliaryEffectSlotf_fnptr = (delegate* unmanaged<int, int, float, void>)ALLoader.ALGetProcAddress("alAuxiliaryEffectSlotf");
            _alAuxiliaryEffectSlotf_fnptr(effectslot, param, flValue);
        }
        
        /// <summary><b>[entry point: <c>alAuxiliaryEffectSlotfDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float, void> _alAuxiliaryEffectSlotfDirect_fnptr = &alAuxiliaryEffectSlotfDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alAuxiliaryEffectSlotfDirect_Lazy(IntPtr context, int effectslot, int param, float flValue)
        {
            _alAuxiliaryEffectSlotfDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float, void>)ALLoader.ALGetProcAddress("alAuxiliaryEffectSlotfDirect");
            _alAuxiliaryEffectSlotfDirect_fnptr(context, effectslot, param, flValue);
        }
        
        /// <summary><b>[entry point: <c>alAuxiliaryEffectSlotfv</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, void> _alAuxiliaryEffectSlotfv_fnptr = &alAuxiliaryEffectSlotfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alAuxiliaryEffectSlotfv_Lazy(int effectslot, int param, float* pflValues)
        {
            _alAuxiliaryEffectSlotfv_fnptr = (delegate* unmanaged<int, int, float*, void>)ALLoader.ALGetProcAddress("alAuxiliaryEffectSlotfv");
            _alAuxiliaryEffectSlotfv_fnptr(effectslot, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alAuxiliaryEffectSlotfvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, void> _alAuxiliaryEffectSlotfvDirect_fnptr = &alAuxiliaryEffectSlotfvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alAuxiliaryEffectSlotfvDirect_Lazy(IntPtr context, int effectslot, int param, float* pflValues)
        {
            _alAuxiliaryEffectSlotfvDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, void>)ALLoader.ALGetProcAddress("alAuxiliaryEffectSlotfvDirect");
            _alAuxiliaryEffectSlotfvDirect_fnptr(context, effectslot, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alAuxiliaryEffectSloti</c>]</b></summary>
        public static delegate* unmanaged<int, int, int, void> _alAuxiliaryEffectSloti_fnptr = &alAuxiliaryEffectSloti_Lazy;
        [UnmanagedCallersOnly]
        private static void alAuxiliaryEffectSloti_Lazy(int effectslot, int param, int iValue)
        {
            _alAuxiliaryEffectSloti_fnptr = (delegate* unmanaged<int, int, int, void>)ALLoader.ALGetProcAddress("alAuxiliaryEffectSloti");
            _alAuxiliaryEffectSloti_fnptr(effectslot, param, iValue);
        }
        
        /// <summary><b>[entry point: <c>alAuxiliaryEffectSlotiDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, void> _alAuxiliaryEffectSlotiDirect_fnptr = &alAuxiliaryEffectSlotiDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alAuxiliaryEffectSlotiDirect_Lazy(IntPtr context, int effectslot, int param, int iValue)
        {
            _alAuxiliaryEffectSlotiDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int, void>)ALLoader.ALGetProcAddress("alAuxiliaryEffectSlotiDirect");
            _alAuxiliaryEffectSlotiDirect_fnptr(context, effectslot, param, iValue);
        }
        
        /// <summary><b>[entry point: <c>alAuxiliaryEffectSlotiv</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alAuxiliaryEffectSlotiv_fnptr = &alAuxiliaryEffectSlotiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alAuxiliaryEffectSlotiv_Lazy(int effectslot, int param, int* piValues)
        {
            _alAuxiliaryEffectSlotiv_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alAuxiliaryEffectSlotiv");
            _alAuxiliaryEffectSlotiv_fnptr(effectslot, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alAuxiliaryEffectSlotivDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alAuxiliaryEffectSlotivDirect_fnptr = &alAuxiliaryEffectSlotivDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alAuxiliaryEffectSlotivDirect_Lazy(IntPtr context, int effectslot, int param, int* piValues)
        {
            _alAuxiliaryEffectSlotivDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alAuxiliaryEffectSlotivDirect");
            _alAuxiliaryEffectSlotivDirect_fnptr(context, effectslot, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alBuffer3f</c>]</b></summary>
        public static delegate* unmanaged<int, int, float, float, float, void> _alBuffer3f_fnptr = &alBuffer3f_Lazy;
        [UnmanagedCallersOnly]
        private static void alBuffer3f_Lazy(int buffer, int param, float value1, float value2, float value3)
        {
            _alBuffer3f_fnptr = (delegate* unmanaged<int, int, float, float, float, void>)ALLoader.ALGetProcAddress("alBuffer3f");
            _alBuffer3f_fnptr(buffer, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alBuffer3fDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float, float, float, void> _alBuffer3fDirect_fnptr = &alBuffer3fDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alBuffer3fDirect_Lazy(IntPtr context, int buffer, int param, float value1, float value2, float value3)
        {
            _alBuffer3fDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float, float, float, void>)ALLoader.ALGetProcAddress("alBuffer3fDirect");
            _alBuffer3fDirect_fnptr(context, buffer, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alBuffer3i</c>]</b></summary>
        public static delegate* unmanaged<int, int, int, int, int, void> _alBuffer3i_fnptr = &alBuffer3i_Lazy;
        [UnmanagedCallersOnly]
        private static void alBuffer3i_Lazy(int buffer, int param, int value1, int value2, int value3)
        {
            _alBuffer3i_fnptr = (delegate* unmanaged<int, int, int, int, int, void>)ALLoader.ALGetProcAddress("alBuffer3i");
            _alBuffer3i_fnptr(buffer, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alBuffer3iDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, int, int, void> _alBuffer3iDirect_fnptr = &alBuffer3iDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alBuffer3iDirect_Lazy(IntPtr context, int buffer, int param, int value1, int value2, int value3)
        {
            _alBuffer3iDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int, int, void>)ALLoader.ALGetProcAddress("alBuffer3iDirect");
            _alBuffer3iDirect_fnptr(context, buffer, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alBufferCallbackDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*, void> _alBufferCallbackDirectSOFT_fnptr = &alBufferCallbackDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferCallbackDirectSOFT_Lazy(IntPtr context, int buffer, int format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, void* userptr)
        {
            _alBufferCallbackDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*, void>)ALLoader.ALGetProcAddress("alBufferCallbackDirectSOFT");
            _alBufferCallbackDirectSOFT_fnptr(context, buffer, format, freq, callback, userptr);
        }
        
        /// <summary><b>[entry point: <c>alBufferCallbackSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*, void> _alBufferCallbackSOFT_fnptr = &alBufferCallbackSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferCallbackSOFT_Lazy(int buffer, int format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, void* userptr)
        {
            _alBufferCallbackSOFT_fnptr = (delegate* unmanaged<int, int, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*, void>)ALLoader.ALGetProcAddress("alBufferCallbackSOFT");
            _alBufferCallbackSOFT_fnptr(buffer, format, freq, callback, userptr);
        }
        
        /// <summary><b>[entry point: <c>alBufferData</c>]</b></summary>
        public static delegate* unmanaged<int, int, void*, int, int, void> _alBufferData_fnptr = &alBufferData_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferData_Lazy(int buffer, int format, void* data, int size, int samplerate)
        {
            _alBufferData_fnptr = (delegate* unmanaged<int, int, void*, int, int, void>)ALLoader.ALGetProcAddress("alBufferData");
            _alBufferData_fnptr(buffer, format, data, size, samplerate);
        }
        
        /// <summary><b>[entry point: <c>alBufferDataDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, void*, int, int, void> _alBufferDataDirect_fnptr = &alBufferDataDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferDataDirect_Lazy(IntPtr context, int buffer, int format, void* data, int size, int samplerate)
        {
            _alBufferDataDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, void*, int, int, void>)ALLoader.ALGetProcAddress("alBufferDataDirect");
            _alBufferDataDirect_fnptr(context, buffer, format, data, size, samplerate);
        }
        
        /// <summary><b>[entry point: <c>alBufferf</c>]</b></summary>
        public static delegate* unmanaged<int, int, float, void> _alBufferf_fnptr = &alBufferf_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferf_Lazy(int buffer, int param, float value)
        {
            _alBufferf_fnptr = (delegate* unmanaged<int, int, float, void>)ALLoader.ALGetProcAddress("alBufferf");
            _alBufferf_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alBufferfDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float, void> _alBufferfDirect_fnptr = &alBufferfDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferfDirect_Lazy(IntPtr context, int buffer, int param, float value)
        {
            _alBufferfDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float, void>)ALLoader.ALGetProcAddress("alBufferfDirect");
            _alBufferfDirect_fnptr(context, buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alBufferfv</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, void> _alBufferfv_fnptr = &alBufferfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferfv_Lazy(int buffer, int param, float* value)
        {
            _alBufferfv_fnptr = (delegate* unmanaged<int, int, float*, void>)ALLoader.ALGetProcAddress("alBufferfv");
            _alBufferfv_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alBufferfvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, void> _alBufferfvDirect_fnptr = &alBufferfvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferfvDirect_Lazy(IntPtr context, int buffer, int param, float* value)
        {
            _alBufferfvDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, void>)ALLoader.ALGetProcAddress("alBufferfvDirect");
            _alBufferfvDirect_fnptr(context, buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alBufferi</c>]</b></summary>
        public static delegate* unmanaged<int, int, int, void> _alBufferi_fnptr = &alBufferi_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferi_Lazy(int buffer, int param, int value)
        {
            _alBufferi_fnptr = (delegate* unmanaged<int, int, int, void>)ALLoader.ALGetProcAddress("alBufferi");
            _alBufferi_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alBufferiDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, void> _alBufferiDirect_fnptr = &alBufferiDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferiDirect_Lazy(IntPtr context, int buffer, int param, int value)
        {
            _alBufferiDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int, void>)ALLoader.ALGetProcAddress("alBufferiDirect");
            _alBufferiDirect_fnptr(context, buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alBufferiv</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alBufferiv_fnptr = &alBufferiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferiv_Lazy(int buffer, int param, int* value)
        {
            _alBufferiv_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alBufferiv");
            _alBufferiv_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alBufferivDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alBufferivDirect_fnptr = &alBufferivDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferivDirect_Lazy(IntPtr context, int buffer, int param, int* value)
        {
            _alBufferivDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alBufferivDirect");
            _alBufferivDirect_fnptr(context, buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alBufferSamplesDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint, int, int, int, int, void*, void> _alBufferSamplesDirectSOFT_fnptr = &alBufferSamplesDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferSamplesDirectSOFT_Lazy(IntPtr context, int buffer, uint samplerate, int internalformat, int samples, int channels, int type, void* data)
        {
            _alBufferSamplesDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, uint, int, int, int, int, void*, void>)ALLoader.ALGetProcAddress("alBufferSamplesDirectSOFT");
            _alBufferSamplesDirectSOFT_fnptr(context, buffer, samplerate, internalformat, samples, channels, type, data);
        }
        
        /// <summary><b>[entry point: <c>alBufferSamplesSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, uint, int, int, int, int, void*, void> _alBufferSamplesSOFT_fnptr = &alBufferSamplesSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferSamplesSOFT_Lazy(int buffer, uint samplerate, int internalformat, int samples, int channels, int type, void* data)
        {
            _alBufferSamplesSOFT_fnptr = (delegate* unmanaged<int, uint, int, int, int, int, void*, void>)ALLoader.ALGetProcAddress("alBufferSamplesSOFT");
            _alBufferSamplesSOFT_fnptr(buffer, samplerate, internalformat, samples, channels, type, data);
        }
        
        /// <summary><b>[entry point: <c>alBufferSubDataDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, void*, int, int, void> _alBufferSubDataDirectSOFT_fnptr = &alBufferSubDataDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferSubDataDirectSOFT_Lazy(IntPtr context, int buffer, int format, void* data, int offset, int length)
        {
            _alBufferSubDataDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, void*, int, int, void>)ALLoader.ALGetProcAddress("alBufferSubDataDirectSOFT");
            _alBufferSubDataDirectSOFT_fnptr(context, buffer, format, data, offset, length);
        }
        
        /// <summary><b>[entry point: <c>alBufferSubDataSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, void*, int, int, void> _alBufferSubDataSOFT_fnptr = &alBufferSubDataSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferSubDataSOFT_Lazy(int buffer, int format, void* data, int offset, int length)
        {
            _alBufferSubDataSOFT_fnptr = (delegate* unmanaged<int, int, void*, int, int, void>)ALLoader.ALGetProcAddress("alBufferSubDataSOFT");
            _alBufferSubDataSOFT_fnptr(buffer, format, data, offset, length);
        }
        
        /// <summary><b>[entry point: <c>alBufferSubSamplesDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, int, int, void*, void> _alBufferSubSamplesDirectSOFT_fnptr = &alBufferSubSamplesDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferSubSamplesDirectSOFT_Lazy(IntPtr context, int buffer, int offset, int samples, int channels, int type, void* data)
        {
            _alBufferSubSamplesDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int, int, void*, void>)ALLoader.ALGetProcAddress("alBufferSubSamplesDirectSOFT");
            _alBufferSubSamplesDirectSOFT_fnptr(context, buffer, offset, samples, channels, type, data);
        }
        
        /// <summary><b>[entry point: <c>alBufferSubSamplesSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, int, int, int, void*, void> _alBufferSubSamplesSOFT_fnptr = &alBufferSubSamplesSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferSubSamplesSOFT_Lazy(int buffer, int offset, int samples, int channels, int type, void* data)
        {
            _alBufferSubSamplesSOFT_fnptr = (delegate* unmanaged<int, int, int, int, int, void*, void>)ALLoader.ALGetProcAddress("alBufferSubSamplesSOFT");
            _alBufferSubSamplesSOFT_fnptr(buffer, offset, samples, channels, type, data);
        }
        
        /// <summary><b>[entry point: <c>alDebugMessageCallbackDirectEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int>, void*, void> _alDebugMessageCallbackDirectEXT_fnptr = &alDebugMessageCallbackDirectEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alDebugMessageCallbackDirectEXT_Lazy(IntPtr context, delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, void* userParam)
        {
            _alDebugMessageCallbackDirectEXT_fnptr = (delegate* unmanaged<IntPtr, delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int>, void*, void>)ALLoader.ALGetProcAddress("alDebugMessageCallbackDirectEXT");
            _alDebugMessageCallbackDirectEXT_fnptr(context, callback, userParam);
        }
        
        /// <summary><b>[entry point: <c>alDebugMessageCallbackEXT</c>]</b></summary>
        public static delegate* unmanaged<delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int>, void*, void> _alDebugMessageCallbackEXT_fnptr = &alDebugMessageCallbackEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alDebugMessageCallbackEXT_Lazy(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, void* userParam)
        {
            _alDebugMessageCallbackEXT_fnptr = (delegate* unmanaged<delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int>, void*, void>)ALLoader.ALGetProcAddress("alDebugMessageCallbackEXT");
            _alDebugMessageCallbackEXT_fnptr(callback, userParam);
        }
        
        /// <summary><b>[entry point: <c>alDebugMessageControlDirectEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, uint, int, uint*, byte, void> _alDebugMessageControlDirectEXT_fnptr = &alDebugMessageControlDirectEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alDebugMessageControlDirectEXT_Lazy(IntPtr context, int source, int type, uint severity, int count, uint* ids, byte enable)
        {
            _alDebugMessageControlDirectEXT_fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int, uint*, byte, void>)ALLoader.ALGetProcAddress("alDebugMessageControlDirectEXT");
            _alDebugMessageControlDirectEXT_fnptr(context, source, type, severity, count, ids, enable);
        }
        
        /// <summary><b>[entry point: <c>alDebugMessageControlEXT</c>]</b></summary>
        public static delegate* unmanaged<int, int, uint, int, uint*, byte, void> _alDebugMessageControlEXT_fnptr = &alDebugMessageControlEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alDebugMessageControlEXT_Lazy(int source, int type, uint severity, int count, uint* ids, byte enable)
        {
            _alDebugMessageControlEXT_fnptr = (delegate* unmanaged<int, int, uint, int, uint*, byte, void>)ALLoader.ALGetProcAddress("alDebugMessageControlEXT");
            _alDebugMessageControlEXT_fnptr(source, type, severity, count, ids, enable);
        }
        
        /// <summary><b>[entry point: <c>alDebugMessageInsertDirectEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, uint, int, byte*, void> _alDebugMessageInsertDirectEXT_fnptr = &alDebugMessageInsertDirectEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alDebugMessageInsertDirectEXT_Lazy(IntPtr context, int source, int type, uint severity, int length, byte* message)
        {
            _alDebugMessageInsertDirectEXT_fnptr = (delegate* unmanaged<IntPtr, int, int, uint, int, byte*, void>)ALLoader.ALGetProcAddress("alDebugMessageInsertDirectEXT");
            _alDebugMessageInsertDirectEXT_fnptr(context, source, type, severity, length, message);
        }
        
        /// <summary><b>[entry point: <c>alDebugMessageInsertEXT</c>]</b></summary>
        public static delegate* unmanaged<int, int, uint, int, byte*, void> _alDebugMessageInsertEXT_fnptr = &alDebugMessageInsertEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alDebugMessageInsertEXT_Lazy(int source, int type, uint severity, int length, byte* message)
        {
            _alDebugMessageInsertEXT_fnptr = (delegate* unmanaged<int, int, uint, int, byte*, void>)ALLoader.ALGetProcAddress("alDebugMessageInsertEXT");
            _alDebugMessageInsertEXT_fnptr(source, type, severity, length, message);
        }
        
        /// <summary><b>[entry point: <c>alDeferUpdatesDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void> _alDeferUpdatesDirectSOFT_fnptr = &alDeferUpdatesDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeferUpdatesDirectSOFT_Lazy(IntPtr context)
        {
            _alDeferUpdatesDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, void>)ALLoader.ALGetProcAddress("alDeferUpdatesDirectSOFT");
            _alDeferUpdatesDirectSOFT_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>alDeferUpdatesSOFT</c>]</b></summary>
        public static delegate* unmanaged<void> _alDeferUpdatesSOFT_fnptr = &alDeferUpdatesSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeferUpdatesSOFT_Lazy()
        {
            _alDeferUpdatesSOFT_fnptr = (delegate* unmanaged<void>)ALLoader.ALGetProcAddress("alDeferUpdatesSOFT");
            _alDeferUpdatesSOFT_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alDeleteAuxiliaryEffectSlots</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alDeleteAuxiliaryEffectSlots_fnptr = &alDeleteAuxiliaryEffectSlots_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeleteAuxiliaryEffectSlots_Lazy(int n, int* effectslots)
        {
            _alDeleteAuxiliaryEffectSlots_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alDeleteAuxiliaryEffectSlots");
            _alDeleteAuxiliaryEffectSlots_fnptr(n, effectslots);
        }
        
        /// <summary><b>[entry point: <c>alDeleteAuxiliaryEffectSlotsDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alDeleteAuxiliaryEffectSlotsDirect_fnptr = &alDeleteAuxiliaryEffectSlotsDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeleteAuxiliaryEffectSlotsDirect_Lazy(IntPtr context, int n, int* effectslots)
        {
            _alDeleteAuxiliaryEffectSlotsDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alDeleteAuxiliaryEffectSlotsDirect");
            _alDeleteAuxiliaryEffectSlotsDirect_fnptr(context, n, effectslots);
        }
        
        /// <summary><b>[entry point: <c>alDeleteBuffers</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alDeleteBuffers_fnptr = &alDeleteBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeleteBuffers_Lazy(int n, int* buffers)
        {
            _alDeleteBuffers_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alDeleteBuffers");
            _alDeleteBuffers_fnptr(n, buffers);
        }
        
        /// <summary><b>[entry point: <c>alDeleteBuffersDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alDeleteBuffersDirect_fnptr = &alDeleteBuffersDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeleteBuffersDirect_Lazy(IntPtr context, int n, int* buffers)
        {
            _alDeleteBuffersDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alDeleteBuffersDirect");
            _alDeleteBuffersDirect_fnptr(context, n, buffers);
        }
        
        /// <summary><b>[entry point: <c>alDeleteEffects</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alDeleteEffects_fnptr = &alDeleteEffects_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeleteEffects_Lazy(int n, int* effects)
        {
            _alDeleteEffects_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alDeleteEffects");
            _alDeleteEffects_fnptr(n, effects);
        }
        
        /// <summary><b>[entry point: <c>alDeleteEffectsDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alDeleteEffectsDirect_fnptr = &alDeleteEffectsDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeleteEffectsDirect_Lazy(IntPtr context, int n, int* effects)
        {
            _alDeleteEffectsDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alDeleteEffectsDirect");
            _alDeleteEffectsDirect_fnptr(context, n, effects);
        }
        
        /// <summary><b>[entry point: <c>alDeleteFilters</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alDeleteFilters_fnptr = &alDeleteFilters_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeleteFilters_Lazy(int n, int* filters)
        {
            _alDeleteFilters_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alDeleteFilters");
            _alDeleteFilters_fnptr(n, filters);
        }
        
        /// <summary><b>[entry point: <c>alDeleteFiltersDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alDeleteFiltersDirect_fnptr = &alDeleteFiltersDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeleteFiltersDirect_Lazy(IntPtr context, int n, int* filters)
        {
            _alDeleteFiltersDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alDeleteFiltersDirect");
            _alDeleteFiltersDirect_fnptr(context, n, filters);
        }
        
        /// <summary><b>[entry point: <c>alDeleteSources</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alDeleteSources_fnptr = &alDeleteSources_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeleteSources_Lazy(int n, int* sources)
        {
            _alDeleteSources_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alDeleteSources");
            _alDeleteSources_fnptr(n, sources);
        }
        
        /// <summary><b>[entry point: <c>alDeleteSourcesDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alDeleteSourcesDirect_fnptr = &alDeleteSourcesDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeleteSourcesDirect_Lazy(IntPtr context, int n, int* sources)
        {
            _alDeleteSourcesDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alDeleteSourcesDirect");
            _alDeleteSourcesDirect_fnptr(context, n, sources);
        }
        
        /// <summary><b>[entry point: <c>alDisable</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alDisable_fnptr = &alDisable_Lazy;
        [UnmanagedCallersOnly]
        private static void alDisable_Lazy(int capability)
        {
            _alDisable_fnptr = (delegate* unmanaged<int, void>)ALLoader.ALGetProcAddress("alDisable");
            _alDisable_fnptr(capability);
        }
        
        /// <summary><b>[entry point: <c>alDisableDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, void> _alDisableDirect_fnptr = &alDisableDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alDisableDirect_Lazy(IntPtr context, int capability)
        {
            _alDisableDirect_fnptr = (delegate* unmanaged<IntPtr, int, void>)ALLoader.ALGetProcAddress("alDisableDirect");
            _alDisableDirect_fnptr(context, capability);
        }
        
        /// <summary><b>[entry point: <c>alDistanceModel</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alDistanceModel_fnptr = &alDistanceModel_Lazy;
        [UnmanagedCallersOnly]
        private static void alDistanceModel_Lazy(int distanceModel)
        {
            _alDistanceModel_fnptr = (delegate* unmanaged<int, void>)ALLoader.ALGetProcAddress("alDistanceModel");
            _alDistanceModel_fnptr(distanceModel);
        }
        
        /// <summary><b>[entry point: <c>alDistanceModelDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, void> _alDistanceModelDirect_fnptr = &alDistanceModelDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alDistanceModelDirect_Lazy(IntPtr context, int distanceModel)
        {
            _alDistanceModelDirect_fnptr = (delegate* unmanaged<IntPtr, int, void>)ALLoader.ALGetProcAddress("alDistanceModelDirect");
            _alDistanceModelDirect_fnptr(context, distanceModel);
        }
        
        /// <summary><b>[entry point: <c>alDopperFactor</c>]</b></summary>
        public static delegate* unmanaged<float, void> _alDopperFactor_fnptr = &alDopperFactor_Lazy;
        [UnmanagedCallersOnly]
        private static void alDopperFactor_Lazy(float value)
        {
            _alDopperFactor_fnptr = (delegate* unmanaged<float, void>)ALLoader.ALGetProcAddress("alDopperFactor");
            _alDopperFactor_fnptr(value);
        }
        
        /// <summary><b>[entry point: <c>alDopperFactorDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, float, void> _alDopperFactorDirect_fnptr = &alDopperFactorDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alDopperFactorDirect_Lazy(IntPtr context, float value)
        {
            _alDopperFactorDirect_fnptr = (delegate* unmanaged<IntPtr, float, void>)ALLoader.ALGetProcAddress("alDopperFactorDirect");
            _alDopperFactorDirect_fnptr(context, value);
        }
        
        /// <summary><b>[entry point: <c>alEffectf</c>]</b></summary>
        public static delegate* unmanaged<int, int, float, void> _alEffectf_fnptr = &alEffectf_Lazy;
        [UnmanagedCallersOnly]
        private static void alEffectf_Lazy(int effect, int param, float flValue)
        {
            _alEffectf_fnptr = (delegate* unmanaged<int, int, float, void>)ALLoader.ALGetProcAddress("alEffectf");
            _alEffectf_fnptr(effect, param, flValue);
        }
        
        /// <summary><b>[entry point: <c>alEffectfDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float, void> _alEffectfDirect_fnptr = &alEffectfDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alEffectfDirect_Lazy(IntPtr context, int effect, int param, float flValue)
        {
            _alEffectfDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float, void>)ALLoader.ALGetProcAddress("alEffectfDirect");
            _alEffectfDirect_fnptr(context, effect, param, flValue);
        }
        
        /// <summary><b>[entry point: <c>alEffectfv</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, void> _alEffectfv_fnptr = &alEffectfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alEffectfv_Lazy(int effect, int param, float* pflValues)
        {
            _alEffectfv_fnptr = (delegate* unmanaged<int, int, float*, void>)ALLoader.ALGetProcAddress("alEffectfv");
            _alEffectfv_fnptr(effect, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alEffectfvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, void> _alEffectfvDirect_fnptr = &alEffectfvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alEffectfvDirect_Lazy(IntPtr context, int effect, int param, float* pflValues)
        {
            _alEffectfvDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, void>)ALLoader.ALGetProcAddress("alEffectfvDirect");
            _alEffectfvDirect_fnptr(context, effect, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alEffecti</c>]</b></summary>
        public static delegate* unmanaged<int, int, int, void> _alEffecti_fnptr = &alEffecti_Lazy;
        [UnmanagedCallersOnly]
        private static void alEffecti_Lazy(int effect, int param, int iValue)
        {
            _alEffecti_fnptr = (delegate* unmanaged<int, int, int, void>)ALLoader.ALGetProcAddress("alEffecti");
            _alEffecti_fnptr(effect, param, iValue);
        }
        
        /// <summary><b>[entry point: <c>alEffectiDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, void> _alEffectiDirect_fnptr = &alEffectiDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alEffectiDirect_Lazy(IntPtr context, int effect, int param, int iValue)
        {
            _alEffectiDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int, void>)ALLoader.ALGetProcAddress("alEffectiDirect");
            _alEffectiDirect_fnptr(context, effect, param, iValue);
        }
        
        /// <summary><b>[entry point: <c>alEffectiv</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alEffectiv_fnptr = &alEffectiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alEffectiv_Lazy(int effect, int param, int* piValues)
        {
            _alEffectiv_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alEffectiv");
            _alEffectiv_fnptr(effect, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alEffectivDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alEffectivDirect_fnptr = &alEffectivDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alEffectivDirect_Lazy(IntPtr context, int effect, int param, int* piValues)
        {
            _alEffectivDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alEffectivDirect");
            _alEffectivDirect_fnptr(context, effect, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alEnable</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alEnable_fnptr = &alEnable_Lazy;
        [UnmanagedCallersOnly]
        private static void alEnable_Lazy(int capability)
        {
            _alEnable_fnptr = (delegate* unmanaged<int, void>)ALLoader.ALGetProcAddress("alEnable");
            _alEnable_fnptr(capability);
        }
        
        /// <summary><b>[entry point: <c>alEnableDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, void> _alEnableDirect_fnptr = &alEnableDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alEnableDirect_Lazy(IntPtr context, int capability)
        {
            _alEnableDirect_fnptr = (delegate* unmanaged<IntPtr, int, void>)ALLoader.ALGetProcAddress("alEnableDirect");
            _alEnableDirect_fnptr(context, capability);
        }
        
        /// <summary><b>[entry point: <c>alEventCallbackDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void>, void*, void> _alEventCallbackDirectSOFT_fnptr = &alEventCallbackDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alEventCallbackDirectSOFT_Lazy(IntPtr context, delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, void* userParam)
        {
            _alEventCallbackDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void>, void*, void>)ALLoader.ALGetProcAddress("alEventCallbackDirectSOFT");
            _alEventCallbackDirectSOFT_fnptr(context, callback, userParam);
        }
        
        /// <summary><b>[entry point: <c>alEventCallbackSOFT</c>]</b></summary>
        public static delegate* unmanaged<delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void>, void*, void> _alEventCallbackSOFT_fnptr = &alEventCallbackSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alEventCallbackSOFT_Lazy(delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, void* userParam)
        {
            _alEventCallbackSOFT_fnptr = (delegate* unmanaged<delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void>, void*, void>)ALLoader.ALGetProcAddress("alEventCallbackSOFT");
            _alEventCallbackSOFT_fnptr(callback, userParam);
        }
        
        /// <summary><b>[entry point: <c>alEventControlDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, byte, void> _alEventControlDirectSOFT_fnptr = &alEventControlDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alEventControlDirectSOFT_Lazy(IntPtr context, int count, int* types, byte enable)
        {
            _alEventControlDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int*, byte, void>)ALLoader.ALGetProcAddress("alEventControlDirectSOFT");
            _alEventControlDirectSOFT_fnptr(context, count, types, enable);
        }
        
        /// <summary><b>[entry point: <c>alEventControlSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int*, byte, void> _alEventControlSOFT_fnptr = &alEventControlSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alEventControlSOFT_Lazy(int count, int* types, byte enable)
        {
            _alEventControlSOFT_fnptr = (delegate* unmanaged<int, int*, byte, void>)ALLoader.ALGetProcAddress("alEventControlSOFT");
            _alEventControlSOFT_fnptr(count, types, enable);
        }
        
        /// <summary><b>[entry point: <c>alFilterf</c>]</b></summary>
        public static delegate* unmanaged<int, int, float, void> _alFilterf_fnptr = &alFilterf_Lazy;
        [UnmanagedCallersOnly]
        private static void alFilterf_Lazy(int filter, int param, float flValue)
        {
            _alFilterf_fnptr = (delegate* unmanaged<int, int, float, void>)ALLoader.ALGetProcAddress("alFilterf");
            _alFilterf_fnptr(filter, param, flValue);
        }
        
        /// <summary><b>[entry point: <c>alFilterfDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float, void> _alFilterfDirect_fnptr = &alFilterfDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alFilterfDirect_Lazy(IntPtr context, int filter, int param, float flValue)
        {
            _alFilterfDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float, void>)ALLoader.ALGetProcAddress("alFilterfDirect");
            _alFilterfDirect_fnptr(context, filter, param, flValue);
        }
        
        /// <summary><b>[entry point: <c>alFilterfv</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, void> _alFilterfv_fnptr = &alFilterfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alFilterfv_Lazy(int filter, int param, float* pflValues)
        {
            _alFilterfv_fnptr = (delegate* unmanaged<int, int, float*, void>)ALLoader.ALGetProcAddress("alFilterfv");
            _alFilterfv_fnptr(filter, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alFilterfvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, void> _alFilterfvDirect_fnptr = &alFilterfvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alFilterfvDirect_Lazy(IntPtr context, int filter, int param, float* pflValues)
        {
            _alFilterfvDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, void>)ALLoader.ALGetProcAddress("alFilterfvDirect");
            _alFilterfvDirect_fnptr(context, filter, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alFilteri</c>]</b></summary>
        public static delegate* unmanaged<int, int, int, void> _alFilteri_fnptr = &alFilteri_Lazy;
        [UnmanagedCallersOnly]
        private static void alFilteri_Lazy(int filter, int param, int iValue)
        {
            _alFilteri_fnptr = (delegate* unmanaged<int, int, int, void>)ALLoader.ALGetProcAddress("alFilteri");
            _alFilteri_fnptr(filter, param, iValue);
        }
        
        /// <summary><b>[entry point: <c>alFilteriDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, void> _alFilteriDirect_fnptr = &alFilteriDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alFilteriDirect_Lazy(IntPtr context, int filter, int param, int iValue)
        {
            _alFilteriDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int, void>)ALLoader.ALGetProcAddress("alFilteriDirect");
            _alFilteriDirect_fnptr(context, filter, param, iValue);
        }
        
        /// <summary><b>[entry point: <c>alFilteriv</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alFilteriv_fnptr = &alFilteriv_Lazy;
        [UnmanagedCallersOnly]
        private static void alFilteriv_Lazy(int filter, int param, int* piValues)
        {
            _alFilteriv_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alFilteriv");
            _alFilteriv_fnptr(filter, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alFilterivDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alFilterivDirect_fnptr = &alFilterivDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alFilterivDirect_Lazy(IntPtr context, int filter, int param, int* piValues)
        {
            _alFilterivDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alFilterivDirect");
            _alFilterivDirect_fnptr(context, filter, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alGenAuxiliaryEffectSlots</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alGenAuxiliaryEffectSlots_fnptr = &alGenAuxiliaryEffectSlots_Lazy;
        [UnmanagedCallersOnly]
        private static void alGenAuxiliaryEffectSlots_Lazy(int n, int* effectslots)
        {
            _alGenAuxiliaryEffectSlots_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alGenAuxiliaryEffectSlots");
            _alGenAuxiliaryEffectSlots_fnptr(n, effectslots);
        }
        
        /// <summary><b>[entry point: <c>alGenAuxiliaryEffectSlotsDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alGenAuxiliaryEffectSlotsDirect_fnptr = &alGenAuxiliaryEffectSlotsDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGenAuxiliaryEffectSlotsDirect_Lazy(IntPtr context, int n, int* effectslots)
        {
            _alGenAuxiliaryEffectSlotsDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alGenAuxiliaryEffectSlotsDirect");
            _alGenAuxiliaryEffectSlotsDirect_fnptr(context, n, effectslots);
        }
        
        /// <summary><b>[entry point: <c>alGenBuffers</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alGenBuffers_fnptr = &alGenBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static void alGenBuffers_Lazy(int n, int* buffers)
        {
            _alGenBuffers_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alGenBuffers");
            _alGenBuffers_fnptr(n, buffers);
        }
        
        /// <summary><b>[entry point: <c>alGenBuffersDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alGenBuffersDirect_fnptr = &alGenBuffersDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGenBuffersDirect_Lazy(IntPtr context, int n, int* buffers)
        {
            _alGenBuffersDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alGenBuffersDirect");
            _alGenBuffersDirect_fnptr(context, n, buffers);
        }
        
        /// <summary><b>[entry point: <c>alGenEffects</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alGenEffects_fnptr = &alGenEffects_Lazy;
        [UnmanagedCallersOnly]
        private static void alGenEffects_Lazy(int n, int* effects)
        {
            _alGenEffects_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alGenEffects");
            _alGenEffects_fnptr(n, effects);
        }
        
        /// <summary><b>[entry point: <c>alGenEffectsDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alGenEffectsDirect_fnptr = &alGenEffectsDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGenEffectsDirect_Lazy(IntPtr context, int n, int* effects)
        {
            _alGenEffectsDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alGenEffectsDirect");
            _alGenEffectsDirect_fnptr(context, n, effects);
        }
        
        /// <summary><b>[entry point: <c>alGenFilters</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alGenFilters_fnptr = &alGenFilters_Lazy;
        [UnmanagedCallersOnly]
        private static void alGenFilters_Lazy(int n, int* filters)
        {
            _alGenFilters_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alGenFilters");
            _alGenFilters_fnptr(n, filters);
        }
        
        /// <summary><b>[entry point: <c>alGenFiltersDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alGenFiltersDirect_fnptr = &alGenFiltersDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGenFiltersDirect_Lazy(IntPtr context, int n, int* filters)
        {
            _alGenFiltersDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alGenFiltersDirect");
            _alGenFiltersDirect_fnptr(context, n, filters);
        }
        
        /// <summary><b>[entry point: <c>alGenSources</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alGenSources_fnptr = &alGenSources_Lazy;
        [UnmanagedCallersOnly]
        private static void alGenSources_Lazy(int n, int* sources)
        {
            _alGenSources_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alGenSources");
            _alGenSources_fnptr(n, sources);
        }
        
        /// <summary><b>[entry point: <c>alGenSourcesDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alGenSourcesDirect_fnptr = &alGenSourcesDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGenSourcesDirect_Lazy(IntPtr context, int n, int* sources)
        {
            _alGenSourcesDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alGenSourcesDirect");
            _alGenSourcesDirect_fnptr(context, n, sources);
        }
        
        /// <summary><b>[entry point: <c>alGetAuxiliaryEffectSlotf</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, void> _alGetAuxiliaryEffectSlotf_fnptr = &alGetAuxiliaryEffectSlotf_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetAuxiliaryEffectSlotf_Lazy(int effectslot, int param, float* pflValue)
        {
            _alGetAuxiliaryEffectSlotf_fnptr = (delegate* unmanaged<int, int, float*, void>)ALLoader.ALGetProcAddress("alGetAuxiliaryEffectSlotf");
            _alGetAuxiliaryEffectSlotf_fnptr(effectslot, param, pflValue);
        }
        
        /// <summary><b>[entry point: <c>alGetAuxiliaryEffectSlotfDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, void> _alGetAuxiliaryEffectSlotfDirect_fnptr = &alGetAuxiliaryEffectSlotfDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetAuxiliaryEffectSlotfDirect_Lazy(IntPtr context, int effectslot, int param, float* pflValue)
        {
            _alGetAuxiliaryEffectSlotfDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, void>)ALLoader.ALGetProcAddress("alGetAuxiliaryEffectSlotfDirect");
            _alGetAuxiliaryEffectSlotfDirect_fnptr(context, effectslot, param, pflValue);
        }
        
        /// <summary><b>[entry point: <c>alGetAuxiliaryEffectSlotfv</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, void> _alGetAuxiliaryEffectSlotfv_fnptr = &alGetAuxiliaryEffectSlotfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetAuxiliaryEffectSlotfv_Lazy(int effectslot, int param, float* pflValues)
        {
            _alGetAuxiliaryEffectSlotfv_fnptr = (delegate* unmanaged<int, int, float*, void>)ALLoader.ALGetProcAddress("alGetAuxiliaryEffectSlotfv");
            _alGetAuxiliaryEffectSlotfv_fnptr(effectslot, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alGetAuxiliaryEffectSlotfvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, void> _alGetAuxiliaryEffectSlotfvDirect_fnptr = &alGetAuxiliaryEffectSlotfvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetAuxiliaryEffectSlotfvDirect_Lazy(IntPtr context, int effectslot, int param, float* pflValues)
        {
            _alGetAuxiliaryEffectSlotfvDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, void>)ALLoader.ALGetProcAddress("alGetAuxiliaryEffectSlotfvDirect");
            _alGetAuxiliaryEffectSlotfvDirect_fnptr(context, effectslot, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alGetAuxiliaryEffectSloti</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alGetAuxiliaryEffectSloti_fnptr = &alGetAuxiliaryEffectSloti_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetAuxiliaryEffectSloti_Lazy(int effectslot, int param, int* piValue)
        {
            _alGetAuxiliaryEffectSloti_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alGetAuxiliaryEffectSloti");
            _alGetAuxiliaryEffectSloti_fnptr(effectslot, param, piValue);
        }
        
        /// <summary><b>[entry point: <c>alGetAuxiliaryEffectSlotiDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alGetAuxiliaryEffectSlotiDirect_fnptr = &alGetAuxiliaryEffectSlotiDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetAuxiliaryEffectSlotiDirect_Lazy(IntPtr context, int effectslot, int param, int* piValue)
        {
            _alGetAuxiliaryEffectSlotiDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alGetAuxiliaryEffectSlotiDirect");
            _alGetAuxiliaryEffectSlotiDirect_fnptr(context, effectslot, param, piValue);
        }
        
        /// <summary><b>[entry point: <c>alGetAuxiliaryEffectSlotiv</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alGetAuxiliaryEffectSlotiv_fnptr = &alGetAuxiliaryEffectSlotiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetAuxiliaryEffectSlotiv_Lazy(int effectslot, int param, int* piValues)
        {
            _alGetAuxiliaryEffectSlotiv_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alGetAuxiliaryEffectSlotiv");
            _alGetAuxiliaryEffectSlotiv_fnptr(effectslot, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alGetAuxiliaryEffectSlotivDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alGetAuxiliaryEffectSlotivDirect_fnptr = &alGetAuxiliaryEffectSlotivDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetAuxiliaryEffectSlotivDirect_Lazy(IntPtr context, int effectslot, int param, int* piValues)
        {
            _alGetAuxiliaryEffectSlotivDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alGetAuxiliaryEffectSlotivDirect");
            _alGetAuxiliaryEffectSlotivDirect_fnptr(context, effectslot, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alGetBoolean</c>]</b></summary>
        public static delegate* unmanaged<int, byte> _alGetBoolean_fnptr = &alGetBoolean_Lazy;
        [UnmanagedCallersOnly]
        private static byte alGetBoolean_Lazy(int param)
        {
            _alGetBoolean_fnptr = (delegate* unmanaged<int, byte>)ALLoader.ALGetProcAddress("alGetBoolean");
            return _alGetBoolean_fnptr(param);
        }
        
        /// <summary><b>[entry point: <c>alGetBooleanDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte> _alGetBooleanDirect_fnptr = &alGetBooleanDirect_Lazy;
        [UnmanagedCallersOnly]
        private static byte alGetBooleanDirect_Lazy(IntPtr context, int param)
        {
            _alGetBooleanDirect_fnptr = (delegate* unmanaged<IntPtr, int, byte>)ALLoader.ALGetProcAddress("alGetBooleanDirect");
            return _alGetBooleanDirect_fnptr(context, param);
        }
        
        /// <summary><b>[entry point: <c>alGetBooleanv</c>]</b></summary>
        public static delegate* unmanaged<int, byte*, void> _alGetBooleanv_fnptr = &alGetBooleanv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBooleanv_Lazy(int param, byte* values)
        {
            _alGetBooleanv_fnptr = (delegate* unmanaged<int, byte*, void>)ALLoader.ALGetProcAddress("alGetBooleanv");
            _alGetBooleanv_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetBooleanvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte*, void> _alGetBooleanvDirect_fnptr = &alGetBooleanvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBooleanvDirect_Lazy(IntPtr context, int param, byte* values)
        {
            _alGetBooleanvDirect_fnptr = (delegate* unmanaged<IntPtr, int, byte*, void>)ALLoader.ALGetProcAddress("alGetBooleanvDirect");
            _alGetBooleanvDirect_fnptr(context, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetBuffer3f</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, float*, float*, void> _alGetBuffer3f_fnptr = &alGetBuffer3f_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBuffer3f_Lazy(int buffer, int param, float* value1, float* value2, float* value3)
        {
            _alGetBuffer3f_fnptr = (delegate* unmanaged<int, int, float*, float*, float*, void>)ALLoader.ALGetProcAddress("alGetBuffer3f");
            _alGetBuffer3f_fnptr(buffer, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetBuffer3fDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, float*, float*, void> _alGetBuffer3fDirect_fnptr = &alGetBuffer3fDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBuffer3fDirect_Lazy(IntPtr context, int buffer, int param, float* value1, float* value2, float* value3)
        {
            _alGetBuffer3fDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, float*, float*, void>)ALLoader.ALGetProcAddress("alGetBuffer3fDirect");
            _alGetBuffer3fDirect_fnptr(context, buffer, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetBuffer3i</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, int*, int*, void> _alGetBuffer3i_fnptr = &alGetBuffer3i_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBuffer3i_Lazy(int buffer, int param, int* value1, int* value2, int* value3)
        {
            _alGetBuffer3i_fnptr = (delegate* unmanaged<int, int, int*, int*, int*, void>)ALLoader.ALGetProcAddress("alGetBuffer3i");
            _alGetBuffer3i_fnptr(buffer, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetBuffer3iDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, int*, int*, void> _alGetBuffer3iDirect_fnptr = &alGetBuffer3iDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBuffer3iDirect_Lazy(IntPtr context, int buffer, int param, int* value1, int* value2, int* value3)
        {
            _alGetBuffer3iDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, int*, int*, void>)ALLoader.ALGetProcAddress("alGetBuffer3iDirect");
            _alGetBuffer3iDirect_fnptr(context, buffer, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetBuffer3PtrDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, void**, void**, void**, void> _alGetBuffer3PtrDirectSOFT_fnptr = &alGetBuffer3PtrDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBuffer3PtrDirectSOFT_Lazy(IntPtr context, int buffer, int param, void** ptr0, void** ptr1, void** ptr2)
        {
            _alGetBuffer3PtrDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, void**, void**, void**, void>)ALLoader.ALGetProcAddress("alGetBuffer3PtrDirectSOFT");
            _alGetBuffer3PtrDirectSOFT_fnptr(context, buffer, param, ptr0, ptr1, ptr2);
        }
        
        /// <summary><b>[entry point: <c>alGetBuffer3PtrSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, void**, void**, void**, void> _alGetBuffer3PtrSOFT_fnptr = &alGetBuffer3PtrSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBuffer3PtrSOFT_Lazy(int buffer, int param, void** ptr0, void** ptr1, void** ptr2)
        {
            _alGetBuffer3PtrSOFT_fnptr = (delegate* unmanaged<int, int, void**, void**, void**, void>)ALLoader.ALGetProcAddress("alGetBuffer3PtrSOFT");
            _alGetBuffer3PtrSOFT_fnptr(buffer, param, ptr0, ptr1, ptr2);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferf</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, void> _alGetBufferf_fnptr = &alGetBufferf_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferf_Lazy(int buffer, int param, float* value)
        {
            _alGetBufferf_fnptr = (delegate* unmanaged<int, int, float*, void>)ALLoader.ALGetProcAddress("alGetBufferf");
            _alGetBufferf_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferfDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, void> _alGetBufferfDirect_fnptr = &alGetBufferfDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferfDirect_Lazy(IntPtr context, int buffer, int param, float* value)
        {
            _alGetBufferfDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, void>)ALLoader.ALGetProcAddress("alGetBufferfDirect");
            _alGetBufferfDirect_fnptr(context, buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferfv</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, void> _alGetBufferfv_fnptr = &alGetBufferfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferfv_Lazy(int buffer, int param, float* value)
        {
            _alGetBufferfv_fnptr = (delegate* unmanaged<int, int, float*, void>)ALLoader.ALGetProcAddress("alGetBufferfv");
            _alGetBufferfv_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferfvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, void> _alGetBufferfvDirect_fnptr = &alGetBufferfvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferfvDirect_Lazy(IntPtr context, int buffer, int param, float* value)
        {
            _alGetBufferfvDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, void>)ALLoader.ALGetProcAddress("alGetBufferfvDirect");
            _alGetBufferfvDirect_fnptr(context, buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferi</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alGetBufferi_fnptr = &alGetBufferi_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferi_Lazy(int buffer, int param, int* value)
        {
            _alGetBufferi_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alGetBufferi");
            _alGetBufferi_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferiDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alGetBufferiDirect_fnptr = &alGetBufferiDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferiDirect_Lazy(IntPtr context, int buffer, int param, int* value)
        {
            _alGetBufferiDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alGetBufferiDirect");
            _alGetBufferiDirect_fnptr(context, buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferiv</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alGetBufferiv_fnptr = &alGetBufferiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferiv_Lazy(int buffer, int param, int* value)
        {
            _alGetBufferiv_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alGetBufferiv");
            _alGetBufferiv_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferivDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alGetBufferivDirect_fnptr = &alGetBufferivDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferivDirect_Lazy(IntPtr context, int buffer, int param, int* value)
        {
            _alGetBufferivDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alGetBufferivDirect");
            _alGetBufferivDirect_fnptr(context, buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferPtrDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, void**, void> _alGetBufferPtrDirectSOFT_fnptr = &alGetBufferPtrDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferPtrDirectSOFT_Lazy(IntPtr context, int buffer, int param, void** ptr)
        {
            _alGetBufferPtrDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, void**, void>)ALLoader.ALGetProcAddress("alGetBufferPtrDirectSOFT");
            _alGetBufferPtrDirectSOFT_fnptr(context, buffer, param, ptr);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferPtrSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, void**, void> _alGetBufferPtrSOFT_fnptr = &alGetBufferPtrSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferPtrSOFT_Lazy(int buffer, int param, void** ptr)
        {
            _alGetBufferPtrSOFT_fnptr = (delegate* unmanaged<int, int, void**, void>)ALLoader.ALGetProcAddress("alGetBufferPtrSOFT");
            _alGetBufferPtrSOFT_fnptr(buffer, param, ptr);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferPtrvDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, void**, void> _alGetBufferPtrvDirectSOFT_fnptr = &alGetBufferPtrvDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferPtrvDirectSOFT_Lazy(IntPtr context, int buffer, int param, void** ptr)
        {
            _alGetBufferPtrvDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, void**, void>)ALLoader.ALGetProcAddress("alGetBufferPtrvDirectSOFT");
            _alGetBufferPtrvDirectSOFT_fnptr(context, buffer, param, ptr);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferPtrvSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, void**, void> _alGetBufferPtrvSOFT_fnptr = &alGetBufferPtrvSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferPtrvSOFT_Lazy(int buffer, int param, void** ptr)
        {
            _alGetBufferPtrvSOFT_fnptr = (delegate* unmanaged<int, int, void**, void>)ALLoader.ALGetProcAddress("alGetBufferPtrvSOFT");
            _alGetBufferPtrvSOFT_fnptr(buffer, param, ptr);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferSamplesDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, int, int, void*, void> _alGetBufferSamplesDirectSOFT_fnptr = &alGetBufferSamplesDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferSamplesDirectSOFT_Lazy(IntPtr context, int buffer, int offset, int samples, int channels, int type, void* data)
        {
            _alGetBufferSamplesDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int, int, void*, void>)ALLoader.ALGetProcAddress("alGetBufferSamplesDirectSOFT");
            _alGetBufferSamplesDirectSOFT_fnptr(context, buffer, offset, samples, channels, type, data);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferSamplesSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, int, int, int, void*, void> _alGetBufferSamplesSOFT_fnptr = &alGetBufferSamplesSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferSamplesSOFT_Lazy(int buffer, int offset, int samples, int channels, int type, void* data)
        {
            _alGetBufferSamplesSOFT_fnptr = (delegate* unmanaged<int, int, int, int, int, void*, void>)ALLoader.ALGetProcAddress("alGetBufferSamplesSOFT");
            _alGetBufferSamplesSOFT_fnptr(buffer, offset, samples, channels, type, data);
        }
        
        /// <summary><b>[entry point: <c>alGetDebugMessageLogDirectEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, uint, int, int*, int*, uint*, int*, int*, byte*, uint> _alGetDebugMessageLogDirectEXT_fnptr = &alGetDebugMessageLogDirectEXT_Lazy;
        [UnmanagedCallersOnly]
        private static uint alGetDebugMessageLogDirectEXT_Lazy(IntPtr context, uint count, int logBufSize, int* sources, int* types, uint* ids, int* severities, int* lengths, byte* logBuf)
        {
            _alGetDebugMessageLogDirectEXT_fnptr = (delegate* unmanaged<IntPtr, uint, int, int*, int*, uint*, int*, int*, byte*, uint>)ALLoader.ALGetProcAddress("alGetDebugMessageLogDirectEXT");
            return _alGetDebugMessageLogDirectEXT_fnptr(context, count, logBufSize, sources, types, ids, severities, lengths, logBuf);
        }
        
        /// <summary><b>[entry point: <c>alGetDebugMessageLogEXT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, int*, uint*, int*, int*, byte*, uint> _alGetDebugMessageLogEXT_fnptr = &alGetDebugMessageLogEXT_Lazy;
        [UnmanagedCallersOnly]
        private static uint alGetDebugMessageLogEXT_Lazy(uint count, int logBufSize, int* sources, int* types, uint* ids, int* severities, int* lengths, byte* logBuf)
        {
            _alGetDebugMessageLogEXT_fnptr = (delegate* unmanaged<uint, int, int*, int*, uint*, int*, int*, byte*, uint>)ALLoader.ALGetProcAddress("alGetDebugMessageLogEXT");
            return _alGetDebugMessageLogEXT_fnptr(count, logBufSize, sources, types, ids, severities, lengths, logBuf);
        }
        
        /// <summary><b>[entry point: <c>alGetDouble</c>]</b></summary>
        public static delegate* unmanaged<int, double> _alGetDouble_fnptr = &alGetDouble_Lazy;
        [UnmanagedCallersOnly]
        private static double alGetDouble_Lazy(int param)
        {
            _alGetDouble_fnptr = (delegate* unmanaged<int, double>)ALLoader.ALGetProcAddress("alGetDouble");
            return _alGetDouble_fnptr(param);
        }
        
        /// <summary><b>[entry point: <c>alGetDoubleDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, double> _alGetDoubleDirect_fnptr = &alGetDoubleDirect_Lazy;
        [UnmanagedCallersOnly]
        private static double alGetDoubleDirect_Lazy(IntPtr context, int param)
        {
            _alGetDoubleDirect_fnptr = (delegate* unmanaged<IntPtr, int, double>)ALLoader.ALGetProcAddress("alGetDoubleDirect");
            return _alGetDoubleDirect_fnptr(context, param);
        }
        
        /// <summary><b>[entry point: <c>alGetDoublev</c>]</b></summary>
        public static delegate* unmanaged<int, double*, void> _alGetDoublev_fnptr = &alGetDoublev_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetDoublev_Lazy(int param, double* values)
        {
            _alGetDoublev_fnptr = (delegate* unmanaged<int, double*, void>)ALLoader.ALGetProcAddress("alGetDoublev");
            _alGetDoublev_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetDoublevDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, double*, void> _alGetDoublevDirect_fnptr = &alGetDoublevDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetDoublevDirect_Lazy(IntPtr context, int param, double* values)
        {
            _alGetDoublevDirect_fnptr = (delegate* unmanaged<IntPtr, int, double*, void>)ALLoader.ALGetProcAddress("alGetDoublevDirect");
            _alGetDoublevDirect_fnptr(context, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetEffectf</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, void> _alGetEffectf_fnptr = &alGetEffectf_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetEffectf_Lazy(int effect, int param, float* pflValue)
        {
            _alGetEffectf_fnptr = (delegate* unmanaged<int, int, float*, void>)ALLoader.ALGetProcAddress("alGetEffectf");
            _alGetEffectf_fnptr(effect, param, pflValue);
        }
        
        /// <summary><b>[entry point: <c>alGetEffectfDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, void> _alGetEffectfDirect_fnptr = &alGetEffectfDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetEffectfDirect_Lazy(IntPtr context, int effect, int param, float* pflValue)
        {
            _alGetEffectfDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, void>)ALLoader.ALGetProcAddress("alGetEffectfDirect");
            _alGetEffectfDirect_fnptr(context, effect, param, pflValue);
        }
        
        /// <summary><b>[entry point: <c>alGetEffectfv</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, void> _alGetEffectfv_fnptr = &alGetEffectfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetEffectfv_Lazy(int effect, int param, float* pflValues)
        {
            _alGetEffectfv_fnptr = (delegate* unmanaged<int, int, float*, void>)ALLoader.ALGetProcAddress("alGetEffectfv");
            _alGetEffectfv_fnptr(effect, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alGetEffectfvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, void> _alGetEffectfvDirect_fnptr = &alGetEffectfvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetEffectfvDirect_Lazy(IntPtr context, int effect, int param, float* pflValues)
        {
            _alGetEffectfvDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, void>)ALLoader.ALGetProcAddress("alGetEffectfvDirect");
            _alGetEffectfvDirect_fnptr(context, effect, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alGetEffecti</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alGetEffecti_fnptr = &alGetEffecti_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetEffecti_Lazy(int effect, int param, int* piValue)
        {
            _alGetEffecti_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alGetEffecti");
            _alGetEffecti_fnptr(effect, param, piValue);
        }
        
        /// <summary><b>[entry point: <c>alGetEffectiDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alGetEffectiDirect_fnptr = &alGetEffectiDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetEffectiDirect_Lazy(IntPtr context, int effect, int param, int* piValue)
        {
            _alGetEffectiDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alGetEffectiDirect");
            _alGetEffectiDirect_fnptr(context, effect, param, piValue);
        }
        
        /// <summary><b>[entry point: <c>alGetEffectiv</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alGetEffectiv_fnptr = &alGetEffectiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetEffectiv_Lazy(int effect, int param, int* piValues)
        {
            _alGetEffectiv_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alGetEffectiv");
            _alGetEffectiv_fnptr(effect, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alGetEffectivDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alGetEffectivDirect_fnptr = &alGetEffectivDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetEffectivDirect_Lazy(IntPtr context, int effect, int param, int* piValues)
        {
            _alGetEffectivDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alGetEffectivDirect");
            _alGetEffectivDirect_fnptr(context, effect, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alGetEnumValue</c>]</b></summary>
        public static delegate* unmanaged<byte*, int> _alGetEnumValue_fnptr = &alGetEnumValue_Lazy;
        [UnmanagedCallersOnly]
        private static int alGetEnumValue_Lazy(byte* ename)
        {
            _alGetEnumValue_fnptr = (delegate* unmanaged<byte*, int>)ALLoader.ALGetProcAddress("alGetEnumValue");
            return _alGetEnumValue_fnptr(ename);
        }
        
        /// <summary><b>[entry point: <c>alGetEnumValueDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte*, int> _alGetEnumValueDirect_fnptr = &alGetEnumValueDirect_Lazy;
        [UnmanagedCallersOnly]
        private static int alGetEnumValueDirect_Lazy(IntPtr context, byte* ename)
        {
            _alGetEnumValueDirect_fnptr = (delegate* unmanaged<IntPtr, byte*, int>)ALLoader.ALGetProcAddress("alGetEnumValueDirect");
            return _alGetEnumValueDirect_fnptr(context, ename);
        }
        
        /// <summary><b>[entry point: <c>alGetError</c>]</b></summary>
        public static delegate* unmanaged<int> _alGetError_fnptr = &alGetError_Lazy;
        [UnmanagedCallersOnly]
        private static int alGetError_Lazy()
        {
            _alGetError_fnptr = (delegate* unmanaged<int>)ALLoader.ALGetProcAddress("alGetError");
            return _alGetError_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alGetErrorDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _alGetErrorDirect_fnptr = &alGetErrorDirect_Lazy;
        [UnmanagedCallersOnly]
        private static int alGetErrorDirect_Lazy(IntPtr context)
        {
            _alGetErrorDirect_fnptr = (delegate* unmanaged<IntPtr, int>)ALLoader.ALGetProcAddress("alGetErrorDirect");
            return _alGetErrorDirect_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>alGetFilterf</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, void> _alGetFilterf_fnptr = &alGetFilterf_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetFilterf_Lazy(int filter, int param, float* pflValue)
        {
            _alGetFilterf_fnptr = (delegate* unmanaged<int, int, float*, void>)ALLoader.ALGetProcAddress("alGetFilterf");
            _alGetFilterf_fnptr(filter, param, pflValue);
        }
        
        /// <summary><b>[entry point: <c>alGetFilterfDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, void> _alGetFilterfDirect_fnptr = &alGetFilterfDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetFilterfDirect_Lazy(IntPtr context, int filter, int param, float* pflValue)
        {
            _alGetFilterfDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, void>)ALLoader.ALGetProcAddress("alGetFilterfDirect");
            _alGetFilterfDirect_fnptr(context, filter, param, pflValue);
        }
        
        /// <summary><b>[entry point: <c>alGetFilterfv</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, void> _alGetFilterfv_fnptr = &alGetFilterfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetFilterfv_Lazy(int filter, int param, float* pflValues)
        {
            _alGetFilterfv_fnptr = (delegate* unmanaged<int, int, float*, void>)ALLoader.ALGetProcAddress("alGetFilterfv");
            _alGetFilterfv_fnptr(filter, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alGetFilterfvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, void> _alGetFilterfvDirect_fnptr = &alGetFilterfvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetFilterfvDirect_Lazy(IntPtr context, int filter, int param, float* pflValues)
        {
            _alGetFilterfvDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, void>)ALLoader.ALGetProcAddress("alGetFilterfvDirect");
            _alGetFilterfvDirect_fnptr(context, filter, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alGetFilteri</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alGetFilteri_fnptr = &alGetFilteri_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetFilteri_Lazy(int filter, int param, int* piValue)
        {
            _alGetFilteri_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alGetFilteri");
            _alGetFilteri_fnptr(filter, param, piValue);
        }
        
        /// <summary><b>[entry point: <c>alGetFilteriDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alGetFilteriDirect_fnptr = &alGetFilteriDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetFilteriDirect_Lazy(IntPtr context, int filter, int param, int* piValue)
        {
            _alGetFilteriDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alGetFilteriDirect");
            _alGetFilteriDirect_fnptr(context, filter, param, piValue);
        }
        
        /// <summary><b>[entry point: <c>alGetFilteriv</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alGetFilteriv_fnptr = &alGetFilteriv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetFilteriv_Lazy(int filter, int param, int* piValues)
        {
            _alGetFilteriv_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alGetFilteriv");
            _alGetFilteriv_fnptr(filter, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alGetFilterivDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alGetFilterivDirect_fnptr = &alGetFilterivDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetFilterivDirect_Lazy(IntPtr context, int filter, int param, int* piValues)
        {
            _alGetFilterivDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alGetFilterivDirect");
            _alGetFilterivDirect_fnptr(context, filter, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alGetFloat</c>]</b></summary>
        public static delegate* unmanaged<int, float> _alGetFloat_fnptr = &alGetFloat_Lazy;
        [UnmanagedCallersOnly]
        private static float alGetFloat_Lazy(int param)
        {
            _alGetFloat_fnptr = (delegate* unmanaged<int, float>)ALLoader.ALGetProcAddress("alGetFloat");
            return _alGetFloat_fnptr(param);
        }
        
        /// <summary><b>[entry point: <c>alGetFloatDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, float> _alGetFloatDirect_fnptr = &alGetFloatDirect_Lazy;
        [UnmanagedCallersOnly]
        private static float alGetFloatDirect_Lazy(IntPtr context, int param)
        {
            _alGetFloatDirect_fnptr = (delegate* unmanaged<IntPtr, int, float>)ALLoader.ALGetProcAddress("alGetFloatDirect");
            return _alGetFloatDirect_fnptr(context, param);
        }
        
        /// <summary><b>[entry point: <c>alGetFloatv</c>]</b></summary>
        public static delegate* unmanaged<int, float*, void> _alGetFloatv_fnptr = &alGetFloatv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetFloatv_Lazy(int param, float* values)
        {
            _alGetFloatv_fnptr = (delegate* unmanaged<int, float*, void>)ALLoader.ALGetProcAddress("alGetFloatv");
            _alGetFloatv_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetFloatvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, float*, void> _alGetFloatvDirect_fnptr = &alGetFloatvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetFloatvDirect_Lazy(IntPtr context, int param, float* values)
        {
            _alGetFloatvDirect_fnptr = (delegate* unmanaged<IntPtr, int, float*, void>)ALLoader.ALGetProcAddress("alGetFloatvDirect");
            _alGetFloatvDirect_fnptr(context, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetInteger</c>]</b></summary>
        public static delegate* unmanaged<int, int> _alGetInteger_fnptr = &alGetInteger_Lazy;
        [UnmanagedCallersOnly]
        private static int alGetInteger_Lazy(int param)
        {
            _alGetInteger_fnptr = (delegate* unmanaged<int, int>)ALLoader.ALGetProcAddress("alGetInteger");
            return _alGetInteger_fnptr(param);
        }
        
        /// <summary><b>[entry point: <c>alGetIntegerDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int> _alGetIntegerDirect_fnptr = &alGetIntegerDirect_Lazy;
        [UnmanagedCallersOnly]
        private static int alGetIntegerDirect_Lazy(IntPtr context, int param)
        {
            _alGetIntegerDirect_fnptr = (delegate* unmanaged<IntPtr, int, int>)ALLoader.ALGetProcAddress("alGetIntegerDirect");
            return _alGetIntegerDirect_fnptr(context, param);
        }
        
        /// <summary><b>[entry point: <c>alGetIntegerv</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alGetIntegerv_fnptr = &alGetIntegerv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetIntegerv_Lazy(int param, int* values)
        {
            _alGetIntegerv_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alGetIntegerv");
            _alGetIntegerv_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetIntegervDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alGetIntegervDirect_fnptr = &alGetIntegervDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetIntegervDirect_Lazy(IntPtr context, int param, int* values)
        {
            _alGetIntegervDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alGetIntegervDirect");
            _alGetIntegervDirect_fnptr(context, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetListener3f</c>]</b></summary>
        public static delegate* unmanaged<int, float*, float*, float*, void> _alGetListener3f_fnptr = &alGetListener3f_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListener3f_Lazy(int param, float* value1, float* value2, float* value3)
        {
            _alGetListener3f_fnptr = (delegate* unmanaged<int, float*, float*, float*, void>)ALLoader.ALGetProcAddress("alGetListener3f");
            _alGetListener3f_fnptr(param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetListener3fDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, float*, float*, float*, void> _alGetListener3fDirect_fnptr = &alGetListener3fDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListener3fDirect_Lazy(IntPtr context, int param, float* value1, float* value2, float* value3)
        {
            _alGetListener3fDirect_fnptr = (delegate* unmanaged<IntPtr, int, float*, float*, float*, void>)ALLoader.ALGetProcAddress("alGetListener3fDirect");
            _alGetListener3fDirect_fnptr(context, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetListener3i</c>]</b></summary>
        public static delegate* unmanaged<int, int*, int*, int*, void> _alGetListener3i_fnptr = &alGetListener3i_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListener3i_Lazy(int param, int* value1, int* value2, int* value3)
        {
            _alGetListener3i_fnptr = (delegate* unmanaged<int, int*, int*, int*, void>)ALLoader.ALGetProcAddress("alGetListener3i");
            _alGetListener3i_fnptr(param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetListener3iDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, int*, int*, void> _alGetListener3iDirect_fnptr = &alGetListener3iDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListener3iDirect_Lazy(IntPtr context, int param, int* value1, int* value2, int* value3)
        {
            _alGetListener3iDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, int*, int*, void>)ALLoader.ALGetProcAddress("alGetListener3iDirect");
            _alGetListener3iDirect_fnptr(context, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetListenerf</c>]</b></summary>
        public static delegate* unmanaged<int, float*, void> _alGetListenerf_fnptr = &alGetListenerf_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListenerf_Lazy(int param, float* value)
        {
            _alGetListenerf_fnptr = (delegate* unmanaged<int, float*, void>)ALLoader.ALGetProcAddress("alGetListenerf");
            _alGetListenerf_fnptr(param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetListenerfDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, float*, void> _alGetListenerfDirect_fnptr = &alGetListenerfDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListenerfDirect_Lazy(IntPtr context, int param, float* value)
        {
            _alGetListenerfDirect_fnptr = (delegate* unmanaged<IntPtr, int, float*, void>)ALLoader.ALGetProcAddress("alGetListenerfDirect");
            _alGetListenerfDirect_fnptr(context, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetListenerfv</c>]</b></summary>
        public static delegate* unmanaged<int, float*, void> _alGetListenerfv_fnptr = &alGetListenerfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListenerfv_Lazy(int param, float* values)
        {
            _alGetListenerfv_fnptr = (delegate* unmanaged<int, float*, void>)ALLoader.ALGetProcAddress("alGetListenerfv");
            _alGetListenerfv_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetListenerfvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, float*, void> _alGetListenerfvDirect_fnptr = &alGetListenerfvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListenerfvDirect_Lazy(IntPtr context, int param, float* values)
        {
            _alGetListenerfvDirect_fnptr = (delegate* unmanaged<IntPtr, int, float*, void>)ALLoader.ALGetProcAddress("alGetListenerfvDirect");
            _alGetListenerfvDirect_fnptr(context, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetListeneri</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alGetListeneri_fnptr = &alGetListeneri_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListeneri_Lazy(int param, int* value)
        {
            _alGetListeneri_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alGetListeneri");
            _alGetListeneri_fnptr(param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetListeneriDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alGetListeneriDirect_fnptr = &alGetListeneriDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListeneriDirect_Lazy(IntPtr context, int param, int* value)
        {
            _alGetListeneriDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alGetListeneriDirect");
            _alGetListeneriDirect_fnptr(context, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetListeneriv</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alGetListeneriv_fnptr = &alGetListeneriv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListeneriv_Lazy(int param, int* values)
        {
            _alGetListeneriv_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alGetListeneriv");
            _alGetListeneriv_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetListenerivDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alGetListenerivDirect_fnptr = &alGetListenerivDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListenerivDirect_Lazy(IntPtr context, int param, int* values)
        {
            _alGetListenerivDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alGetListenerivDirect");
            _alGetListenerivDirect_fnptr(context, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetObjectLabelDirectEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint, int, int*, byte*, void> _alGetObjectLabelDirectEXT_fnptr = &alGetObjectLabelDirectEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetObjectLabelDirectEXT_Lazy(IntPtr context, int identifier, uint name, int bufSize, int* length, byte* label)
        {
            _alGetObjectLabelDirectEXT_fnptr = (delegate* unmanaged<IntPtr, int, uint, int, int*, byte*, void>)ALLoader.ALGetProcAddress("alGetObjectLabelDirectEXT");
            _alGetObjectLabelDirectEXT_fnptr(context, identifier, name, bufSize, length, label);
        }
        
        /// <summary><b>[entry point: <c>alGetObjectLabelEXT</c>]</b></summary>
        public static delegate* unmanaged<int, uint, int, int*, byte*, void> _alGetObjectLabelEXT_fnptr = &alGetObjectLabelEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetObjectLabelEXT_Lazy(int identifier, uint name, int bufSize, int* length, byte* label)
        {
            _alGetObjectLabelEXT_fnptr = (delegate* unmanaged<int, uint, int, int*, byte*, void>)ALLoader.ALGetProcAddress("alGetObjectLabelEXT");
            _alGetObjectLabelEXT_fnptr(identifier, name, bufSize, length, label);
        }
        
        /// <summary><b>[entry point: <c>alGetPointerDirectEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, void*> _alGetPointerDirectEXT_fnptr = &alGetPointerDirectEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void* alGetPointerDirectEXT_Lazy(IntPtr context, int pname)
        {
            _alGetPointerDirectEXT_fnptr = (delegate* unmanaged<IntPtr, int, void*>)ALLoader.ALGetProcAddress("alGetPointerDirectEXT");
            return _alGetPointerDirectEXT_fnptr(context, pname);
        }
        
        /// <summary><b>[entry point: <c>alGetPointerDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, void*> _alGetPointerDirectSOFT_fnptr = &alGetPointerDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void* alGetPointerDirectSOFT_Lazy(IntPtr context, int pname)
        {
            _alGetPointerDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, void*>)ALLoader.ALGetProcAddress("alGetPointerDirectSOFT");
            return _alGetPointerDirectSOFT_fnptr(context, pname);
        }
        
        /// <summary><b>[entry point: <c>alGetPointerEXT</c>]</b></summary>
        public static delegate* unmanaged<int, void*> _alGetPointerEXT_fnptr = &alGetPointerEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void* alGetPointerEXT_Lazy(int pname)
        {
            _alGetPointerEXT_fnptr = (delegate* unmanaged<int, void*>)ALLoader.ALGetProcAddress("alGetPointerEXT");
            return _alGetPointerEXT_fnptr(pname);
        }
        
        /// <summary><b>[entry point: <c>alGetPointerSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, void*> _alGetPointerSOFT_fnptr = &alGetPointerSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void* alGetPointerSOFT_Lazy(int pname)
        {
            _alGetPointerSOFT_fnptr = (delegate* unmanaged<int, void*>)ALLoader.ALGetProcAddress("alGetPointerSOFT");
            return _alGetPointerSOFT_fnptr(pname);
        }
        
        /// <summary><b>[entry point: <c>alGetPointervDirectEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, void**, void> _alGetPointervDirectEXT_fnptr = &alGetPointervDirectEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetPointervDirectEXT_Lazy(IntPtr context, int pname, void** values)
        {
            _alGetPointervDirectEXT_fnptr = (delegate* unmanaged<IntPtr, int, void**, void>)ALLoader.ALGetProcAddress("alGetPointervDirectEXT");
            _alGetPointervDirectEXT_fnptr(context, pname, values);
        }
        
        /// <summary><b>[entry point: <c>alGetPointervDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, void**, void> _alGetPointervDirectSOFT_fnptr = &alGetPointervDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetPointervDirectSOFT_Lazy(IntPtr context, int pname, void** values)
        {
            _alGetPointervDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, void**, void>)ALLoader.ALGetProcAddress("alGetPointervDirectSOFT");
            _alGetPointervDirectSOFT_fnptr(context, pname, values);
        }
        
        /// <summary><b>[entry point: <c>alGetPointervEXT</c>]</b></summary>
        public static delegate* unmanaged<int, void**, void> _alGetPointervEXT_fnptr = &alGetPointervEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetPointervEXT_Lazy(int pname, void** values)
        {
            _alGetPointervEXT_fnptr = (delegate* unmanaged<int, void**, void>)ALLoader.ALGetProcAddress("alGetPointervEXT");
            _alGetPointervEXT_fnptr(pname, values);
        }
        
        /// <summary><b>[entry point: <c>alGetPointervSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, void**, void> _alGetPointervSOFT_fnptr = &alGetPointervSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetPointervSOFT_Lazy(int pname, void** values)
        {
            _alGetPointervSOFT_fnptr = (delegate* unmanaged<int, void**, void>)ALLoader.ALGetProcAddress("alGetPointervSOFT");
            _alGetPointervSOFT_fnptr(pname, values);
        }
        
        /// <summary><b>[entry point: <c>alGetProcAddress</c>]</b></summary>
        public static delegate* unmanaged<byte*, void*> _alGetProcAddress_fnptr = &alGetProcAddress_Lazy;
        [UnmanagedCallersOnly]
        private static void* alGetProcAddress_Lazy(byte* fname)
        {
            _alGetProcAddress_fnptr = (delegate* unmanaged<byte*, void*>)ALLoader.ALGetProcAddress("alGetProcAddress");
            return _alGetProcAddress_fnptr(fname);
        }
        
        /// <summary><b>[entry point: <c>alGetProcAddressDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte*, void*> _alGetProcAddressDirect_fnptr = &alGetProcAddressDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void* alGetProcAddressDirect_Lazy(IntPtr context, byte* fname)
        {
            _alGetProcAddressDirect_fnptr = (delegate* unmanaged<IntPtr, byte*, void*>)ALLoader.ALGetProcAddress("alGetProcAddressDirect");
            return _alGetProcAddressDirect_fnptr(context, fname);
        }
        
        /// <summary><b>[entry point: <c>alGetSource3dDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, double*, double*, double*, void> _alGetSource3dDirectSOFT_fnptr = &alGetSource3dDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSource3dDirectSOFT_Lazy(IntPtr context, int source, int param, double* value1, double* value2, double* value3)
        {
            _alGetSource3dDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, double*, double*, double*, void>)ALLoader.ALGetProcAddress("alGetSource3dDirectSOFT");
            _alGetSource3dDirectSOFT_fnptr(context, source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetSource3dSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, double*, double*, double*, void> _alGetSource3dSOFT_fnptr = &alGetSource3dSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSource3dSOFT_Lazy(int source, int param, double* value1, double* value2, double* value3)
        {
            _alGetSource3dSOFT_fnptr = (delegate* unmanaged<int, int, double*, double*, double*, void>)ALLoader.ALGetProcAddress("alGetSource3dSOFT");
            _alGetSource3dSOFT_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetSource3f</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, float*, float*, void> _alGetSource3f_fnptr = &alGetSource3f_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSource3f_Lazy(int source, int param, float* value1, float* value2, float* value3)
        {
            _alGetSource3f_fnptr = (delegate* unmanaged<int, int, float*, float*, float*, void>)ALLoader.ALGetProcAddress("alGetSource3f");
            _alGetSource3f_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetSource3fDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, float*, float*, void> _alGetSource3fDirect_fnptr = &alGetSource3fDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSource3fDirect_Lazy(IntPtr context, int source, int param, float* value1, float* value2, float* value3)
        {
            _alGetSource3fDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, float*, float*, void>)ALLoader.ALGetProcAddress("alGetSource3fDirect");
            _alGetSource3fDirect_fnptr(context, source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetSource3i</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, int*, int*, void> _alGetSource3i_fnptr = &alGetSource3i_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSource3i_Lazy(int source, int param, int* value1, int* value2, int* value3)
        {
            _alGetSource3i_fnptr = (delegate* unmanaged<int, int, int*, int*, int*, void>)ALLoader.ALGetProcAddress("alGetSource3i");
            _alGetSource3i_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetSource3i64DirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, long*, long*, long*, void> _alGetSource3i64DirectSOFT_fnptr = &alGetSource3i64DirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSource3i64DirectSOFT_Lazy(IntPtr context, int source, int param, long* value1, long* value2, long* value3)
        {
            _alGetSource3i64DirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, long*, long*, long*, void>)ALLoader.ALGetProcAddress("alGetSource3i64DirectSOFT");
            _alGetSource3i64DirectSOFT_fnptr(context, source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetSource3i64SOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, long*, long*, long*, void> _alGetSource3i64SOFT_fnptr = &alGetSource3i64SOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSource3i64SOFT_Lazy(int source, int param, long* value1, long* value2, long* value3)
        {
            _alGetSource3i64SOFT_fnptr = (delegate* unmanaged<int, int, long*, long*, long*, void>)ALLoader.ALGetProcAddress("alGetSource3i64SOFT");
            _alGetSource3i64SOFT_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetSource3iDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, int*, int*, void> _alGetSource3iDirect_fnptr = &alGetSource3iDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSource3iDirect_Lazy(IntPtr context, int source, int param, int* value1, int* value2, int* value3)
        {
            _alGetSource3iDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, int*, int*, void>)ALLoader.ALGetProcAddress("alGetSource3iDirect");
            _alGetSource3iDirect_fnptr(context, source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcedDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, double*, void> _alGetSourcedDirectSOFT_fnptr = &alGetSourcedDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcedDirectSOFT_Lazy(IntPtr context, int source, int param, double* value)
        {
            _alGetSourcedDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, double*, void>)ALLoader.ALGetProcAddress("alGetSourcedDirectSOFT");
            _alGetSourcedDirectSOFT_fnptr(context, source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcedSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, double*, void> _alGetSourcedSOFT_fnptr = &alGetSourcedSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcedSOFT_Lazy(int source, int param, double* value)
        {
            _alGetSourcedSOFT_fnptr = (delegate* unmanaged<int, int, double*, void>)ALLoader.ALGetProcAddress("alGetSourcedSOFT");
            _alGetSourcedSOFT_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcedvDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, double*, void> _alGetSourcedvDirectSOFT_fnptr = &alGetSourcedvDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcedvDirectSOFT_Lazy(IntPtr context, int source, int param, double* values)
        {
            _alGetSourcedvDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, double*, void>)ALLoader.ALGetProcAddress("alGetSourcedvDirectSOFT");
            _alGetSourcedvDirectSOFT_fnptr(context, source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcedvSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, double*, void> _alGetSourcedvSOFT_fnptr = &alGetSourcedvSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcedvSOFT_Lazy(int source, int param, double* values)
        {
            _alGetSourcedvSOFT_fnptr = (delegate* unmanaged<int, int, double*, void>)ALLoader.ALGetProcAddress("alGetSourcedvSOFT");
            _alGetSourcedvSOFT_fnptr(source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcef</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, void> _alGetSourcef_fnptr = &alGetSourcef_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcef_Lazy(int source, int param, float* value)
        {
            _alGetSourcef_fnptr = (delegate* unmanaged<int, int, float*, void>)ALLoader.ALGetProcAddress("alGetSourcef");
            _alGetSourcef_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcefDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, void> _alGetSourcefDirect_fnptr = &alGetSourcefDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcefDirect_Lazy(IntPtr context, int source, int param, float* value)
        {
            _alGetSourcefDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, void>)ALLoader.ALGetProcAddress("alGetSourcefDirect");
            _alGetSourcefDirect_fnptr(context, source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcefv</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, void> _alGetSourcefv_fnptr = &alGetSourcefv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcefv_Lazy(int source, int param, float* values)
        {
            _alGetSourcefv_fnptr = (delegate* unmanaged<int, int, float*, void>)ALLoader.ALGetProcAddress("alGetSourcefv");
            _alGetSourcefv_fnptr(source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcefvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, void> _alGetSourcefvDirect_fnptr = &alGetSourcefvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcefvDirect_Lazy(IntPtr context, int source, int param, float* values)
        {
            _alGetSourcefvDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, void>)ALLoader.ALGetProcAddress("alGetSourcefvDirect");
            _alGetSourcefvDirect_fnptr(context, source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcei</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alGetSourcei_fnptr = &alGetSourcei_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcei_Lazy(int source, int param, int* value)
        {
            _alGetSourcei_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alGetSourcei");
            _alGetSourcei_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcei64DirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, long*, void> _alGetSourcei64DirectSOFT_fnptr = &alGetSourcei64DirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcei64DirectSOFT_Lazy(IntPtr context, int source, int param, long* value)
        {
            _alGetSourcei64DirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, long*, void>)ALLoader.ALGetProcAddress("alGetSourcei64DirectSOFT");
            _alGetSourcei64DirectSOFT_fnptr(context, source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcei64SOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, long*, void> _alGetSourcei64SOFT_fnptr = &alGetSourcei64SOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcei64SOFT_Lazy(int source, int param, long* value)
        {
            _alGetSourcei64SOFT_fnptr = (delegate* unmanaged<int, int, long*, void>)ALLoader.ALGetProcAddress("alGetSourcei64SOFT");
            _alGetSourcei64SOFT_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcei64vDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, long*, void> _alGetSourcei64vDirectSOFT_fnptr = &alGetSourcei64vDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcei64vDirectSOFT_Lazy(IntPtr context, int source, int param, long* values)
        {
            _alGetSourcei64vDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, long*, void>)ALLoader.ALGetProcAddress("alGetSourcei64vDirectSOFT");
            _alGetSourcei64vDirectSOFT_fnptr(context, source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcei64vSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, long*, void> _alGetSourcei64vSOFT_fnptr = &alGetSourcei64vSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcei64vSOFT_Lazy(int source, int param, long* values)
        {
            _alGetSourcei64vSOFT_fnptr = (delegate* unmanaged<int, int, long*, void>)ALLoader.ALGetProcAddress("alGetSourcei64vSOFT");
            _alGetSourcei64vSOFT_fnptr(source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetSourceiDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alGetSourceiDirect_fnptr = &alGetSourceiDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourceiDirect_Lazy(IntPtr context, int source, int param, int* value)
        {
            _alGetSourceiDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alGetSourceiDirect");
            _alGetSourceiDirect_fnptr(context, source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetSourceiv</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alGetSourceiv_fnptr = &alGetSourceiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourceiv_Lazy(int source, int param, int* values)
        {
            _alGetSourceiv_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alGetSourceiv");
            _alGetSourceiv_fnptr(source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetSourceivDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alGetSourceivDirect_fnptr = &alGetSourceivDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourceivDirect_Lazy(IntPtr context, int source, int param, int* values)
        {
            _alGetSourceivDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alGetSourceivDirect");
            _alGetSourceivDirect_fnptr(context, source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetString</c>]</b></summary>
        public static delegate* unmanaged<int, byte*> _alGetString_fnptr = &alGetString_Lazy;
        [UnmanagedCallersOnly]
        private static byte* alGetString_Lazy(int param)
        {
            _alGetString_fnptr = (delegate* unmanaged<int, byte*>)ALLoader.ALGetProcAddress("alGetString");
            return _alGetString_fnptr(param);
        }
        
        /// <summary><b>[entry point: <c>alGetStringDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte*> _alGetStringDirect_fnptr = &alGetStringDirect_Lazy;
        [UnmanagedCallersOnly]
        private static byte* alGetStringDirect_Lazy(IntPtr context, int param)
        {
            _alGetStringDirect_fnptr = (delegate* unmanaged<IntPtr, int, byte*>)ALLoader.ALGetProcAddress("alGetStringDirect");
            return _alGetStringDirect_fnptr(context, param);
        }
        
        /// <summary><b>[entry point: <c>alGetStringiDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, byte*> _alGetStringiDirectSOFT_fnptr = &alGetStringiDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static byte* alGetStringiDirectSOFT_Lazy(IntPtr context, int pname, int index)
        {
            _alGetStringiDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, byte*>)ALLoader.ALGetProcAddress("alGetStringiDirectSOFT");
            return _alGetStringiDirectSOFT_fnptr(context, pname, index);
        }
        
        /// <summary><b>[entry point: <c>alGetStringiSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, byte*> _alGetStringiSOFT_fnptr = &alGetStringiSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static byte* alGetStringiSOFT_Lazy(int pname, int index)
        {
            _alGetStringiSOFT_fnptr = (delegate* unmanaged<int, int, byte*>)ALLoader.ALGetProcAddress("alGetStringiSOFT");
            return _alGetStringiSOFT_fnptr(pname, index);
        }
        
        /// <summary><b>[entry point: <c>alIsAuxiliaryEffectSlot</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alIsAuxiliaryEffectSlot_fnptr = &alIsAuxiliaryEffectSlot_Lazy;
        [UnmanagedCallersOnly]
        private static void alIsAuxiliaryEffectSlot_Lazy(int effectslot)
        {
            _alIsAuxiliaryEffectSlot_fnptr = (delegate* unmanaged<int, void>)ALLoader.ALGetProcAddress("alIsAuxiliaryEffectSlot");
            _alIsAuxiliaryEffectSlot_fnptr(effectslot);
        }
        
        /// <summary><b>[entry point: <c>alIsAuxiliaryEffectSlotDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, void> _alIsAuxiliaryEffectSlotDirect_fnptr = &alIsAuxiliaryEffectSlotDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alIsAuxiliaryEffectSlotDirect_Lazy(IntPtr context, int effectslot)
        {
            _alIsAuxiliaryEffectSlotDirect_fnptr = (delegate* unmanaged<IntPtr, int, void>)ALLoader.ALGetProcAddress("alIsAuxiliaryEffectSlotDirect");
            _alIsAuxiliaryEffectSlotDirect_fnptr(context, effectslot);
        }
        
        /// <summary><b>[entry point: <c>alIsBuffer</c>]</b></summary>
        public static delegate* unmanaged<int, byte> _alIsBuffer_fnptr = &alIsBuffer_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsBuffer_Lazy(int buffer)
        {
            _alIsBuffer_fnptr = (delegate* unmanaged<int, byte>)ALLoader.ALGetProcAddress("alIsBuffer");
            return _alIsBuffer_fnptr(buffer);
        }
        
        /// <summary><b>[entry point: <c>alIsBufferDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte> _alIsBufferDirect_fnptr = &alIsBufferDirect_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsBufferDirect_Lazy(IntPtr context, int buffer)
        {
            _alIsBufferDirect_fnptr = (delegate* unmanaged<IntPtr, int, byte>)ALLoader.ALGetProcAddress("alIsBufferDirect");
            return _alIsBufferDirect_fnptr(context, buffer);
        }
        
        /// <summary><b>[entry point: <c>alIsBufferFormatSupportedDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte> _alIsBufferFormatSupportedDirectSOFT_fnptr = &alIsBufferFormatSupportedDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsBufferFormatSupportedDirectSOFT_Lazy(IntPtr context, int format)
        {
            _alIsBufferFormatSupportedDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, byte>)ALLoader.ALGetProcAddress("alIsBufferFormatSupportedDirectSOFT");
            return _alIsBufferFormatSupportedDirectSOFT_fnptr(context, format);
        }
        
        /// <summary><b>[entry point: <c>alIsBufferFormatSupportedSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, byte> _alIsBufferFormatSupportedSOFT_fnptr = &alIsBufferFormatSupportedSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsBufferFormatSupportedSOFT_Lazy(int format)
        {
            _alIsBufferFormatSupportedSOFT_fnptr = (delegate* unmanaged<int, byte>)ALLoader.ALGetProcAddress("alIsBufferFormatSupportedSOFT");
            return _alIsBufferFormatSupportedSOFT_fnptr(format);
        }
        
        /// <summary><b>[entry point: <c>alIsEffect</c>]</b></summary>
        public static delegate* unmanaged<int, byte> _alIsEffect_fnptr = &alIsEffect_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsEffect_Lazy(int effect)
        {
            _alIsEffect_fnptr = (delegate* unmanaged<int, byte>)ALLoader.ALGetProcAddress("alIsEffect");
            return _alIsEffect_fnptr(effect);
        }
        
        /// <summary><b>[entry point: <c>alIsEffectDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte> _alIsEffectDirect_fnptr = &alIsEffectDirect_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsEffectDirect_Lazy(IntPtr context, int effect)
        {
            _alIsEffectDirect_fnptr = (delegate* unmanaged<IntPtr, int, byte>)ALLoader.ALGetProcAddress("alIsEffectDirect");
            return _alIsEffectDirect_fnptr(context, effect);
        }
        
        /// <summary><b>[entry point: <c>alIsEnabled</c>]</b></summary>
        public static delegate* unmanaged<int, byte> _alIsEnabled_fnptr = &alIsEnabled_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsEnabled_Lazy(int capability)
        {
            _alIsEnabled_fnptr = (delegate* unmanaged<int, byte>)ALLoader.ALGetProcAddress("alIsEnabled");
            return _alIsEnabled_fnptr(capability);
        }
        
        /// <summary><b>[entry point: <c>alIsEnabledDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte> _alIsEnabledDirect_fnptr = &alIsEnabledDirect_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsEnabledDirect_Lazy(IntPtr context, int capability)
        {
            _alIsEnabledDirect_fnptr = (delegate* unmanaged<IntPtr, int, byte>)ALLoader.ALGetProcAddress("alIsEnabledDirect");
            return _alIsEnabledDirect_fnptr(context, capability);
        }
        
        /// <summary><b>[entry point: <c>alIsExtensionPresent</c>]</b></summary>
        public static delegate* unmanaged<byte*, byte> _alIsExtensionPresent_fnptr = &alIsExtensionPresent_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsExtensionPresent_Lazy(byte* extname)
        {
            _alIsExtensionPresent_fnptr = (delegate* unmanaged<byte*, byte>)ALLoader.ALGetProcAddress("alIsExtensionPresent");
            return _alIsExtensionPresent_fnptr(extname);
        }
        
        /// <summary><b>[entry point: <c>alIsExtensionPresentDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte*, byte> _alIsExtensionPresentDirect_fnptr = &alIsExtensionPresentDirect_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsExtensionPresentDirect_Lazy(IntPtr context, byte* extname)
        {
            _alIsExtensionPresentDirect_fnptr = (delegate* unmanaged<IntPtr, byte*, byte>)ALLoader.ALGetProcAddress("alIsExtensionPresentDirect");
            return _alIsExtensionPresentDirect_fnptr(context, extname);
        }
        
        /// <summary><b>[entry point: <c>alIsFilter</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alIsFilter_fnptr = &alIsFilter_Lazy;
        [UnmanagedCallersOnly]
        private static void alIsFilter_Lazy(int filter)
        {
            _alIsFilter_fnptr = (delegate* unmanaged<int, void>)ALLoader.ALGetProcAddress("alIsFilter");
            _alIsFilter_fnptr(filter);
        }
        
        /// <summary><b>[entry point: <c>alIsFilterDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, void> _alIsFilterDirect_fnptr = &alIsFilterDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alIsFilterDirect_Lazy(IntPtr context, int filter)
        {
            _alIsFilterDirect_fnptr = (delegate* unmanaged<IntPtr, int, void>)ALLoader.ALGetProcAddress("alIsFilterDirect");
            _alIsFilterDirect_fnptr(context, filter);
        }
        
        /// <summary><b>[entry point: <c>alIsSource</c>]</b></summary>
        public static delegate* unmanaged<int, byte> _alIsSource_fnptr = &alIsSource_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsSource_Lazy(int source)
        {
            _alIsSource_fnptr = (delegate* unmanaged<int, byte>)ALLoader.ALGetProcAddress("alIsSource");
            return _alIsSource_fnptr(source);
        }
        
        /// <summary><b>[entry point: <c>alIsSourceDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte> _alIsSourceDirect_fnptr = &alIsSourceDirect_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsSourceDirect_Lazy(IntPtr context, int source)
        {
            _alIsSourceDirect_fnptr = (delegate* unmanaged<IntPtr, int, byte>)ALLoader.ALGetProcAddress("alIsSourceDirect");
            return _alIsSourceDirect_fnptr(context, source);
        }
        
        /// <summary><b>[entry point: <c>alListener3f</c>]</b></summary>
        public static delegate* unmanaged<int, float, float, float, void> _alListener3f_fnptr = &alListener3f_Lazy;
        [UnmanagedCallersOnly]
        private static void alListener3f_Lazy(int param, float value1, float value2, float value3)
        {
            _alListener3f_fnptr = (delegate* unmanaged<int, float, float, float, void>)ALLoader.ALGetProcAddress("alListener3f");
            _alListener3f_fnptr(param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alListener3fDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, float, float, float, void> _alListener3fDirect_fnptr = &alListener3fDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alListener3fDirect_Lazy(IntPtr context, int param, float value1, float value2, float value3)
        {
            _alListener3fDirect_fnptr = (delegate* unmanaged<IntPtr, int, float, float, float, void>)ALLoader.ALGetProcAddress("alListener3fDirect");
            _alListener3fDirect_fnptr(context, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alListener3i</c>]</b></summary>
        public static delegate* unmanaged<int, int, int, int, void> _alListener3i_fnptr = &alListener3i_Lazy;
        [UnmanagedCallersOnly]
        private static void alListener3i_Lazy(int param, int value1, int value2, int value3)
        {
            _alListener3i_fnptr = (delegate* unmanaged<int, int, int, int, void>)ALLoader.ALGetProcAddress("alListener3i");
            _alListener3i_fnptr(param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alListener3iDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, int, void> _alListener3iDirect_fnptr = &alListener3iDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alListener3iDirect_Lazy(IntPtr context, int param, int value1, int value2, int value3)
        {
            _alListener3iDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int, void>)ALLoader.ALGetProcAddress("alListener3iDirect");
            _alListener3iDirect_fnptr(context, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alListenerf</c>]</b></summary>
        public static delegate* unmanaged<int, float, void> _alListenerf_fnptr = &alListenerf_Lazy;
        [UnmanagedCallersOnly]
        private static void alListenerf_Lazy(int param, float value)
        {
            _alListenerf_fnptr = (delegate* unmanaged<int, float, void>)ALLoader.ALGetProcAddress("alListenerf");
            _alListenerf_fnptr(param, value);
        }
        
        /// <summary><b>[entry point: <c>alListenerfDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, float, void> _alListenerfDirect_fnptr = &alListenerfDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alListenerfDirect_Lazy(IntPtr context, int param, float value)
        {
            _alListenerfDirect_fnptr = (delegate* unmanaged<IntPtr, int, float, void>)ALLoader.ALGetProcAddress("alListenerfDirect");
            _alListenerfDirect_fnptr(context, param, value);
        }
        
        /// <summary><b>[entry point: <c>alListenerfv</c>]</b></summary>
        public static delegate* unmanaged<int, float*, void> _alListenerfv_fnptr = &alListenerfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alListenerfv_Lazy(int param, float* values)
        {
            _alListenerfv_fnptr = (delegate* unmanaged<int, float*, void>)ALLoader.ALGetProcAddress("alListenerfv");
            _alListenerfv_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alListenerfvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, float*, void> _alListenerfvDirect_fnptr = &alListenerfvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alListenerfvDirect_Lazy(IntPtr context, int param, float* values)
        {
            _alListenerfvDirect_fnptr = (delegate* unmanaged<IntPtr, int, float*, void>)ALLoader.ALGetProcAddress("alListenerfvDirect");
            _alListenerfvDirect_fnptr(context, param, values);
        }
        
        /// <summary><b>[entry point: <c>alListeneri</c>]</b></summary>
        public static delegate* unmanaged<int, int, void> _alListeneri_fnptr = &alListeneri_Lazy;
        [UnmanagedCallersOnly]
        private static void alListeneri_Lazy(int param, int value)
        {
            _alListeneri_fnptr = (delegate* unmanaged<int, int, void>)ALLoader.ALGetProcAddress("alListeneri");
            _alListeneri_fnptr(param, value);
        }
        
        /// <summary><b>[entry point: <c>alListeneriDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, void> _alListeneriDirect_fnptr = &alListeneriDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alListeneriDirect_Lazy(IntPtr context, int param, int value)
        {
            _alListeneriDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, void>)ALLoader.ALGetProcAddress("alListeneriDirect");
            _alListeneriDirect_fnptr(context, param, value);
        }
        
        /// <summary><b>[entry point: <c>alListeneriv</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alListeneriv_fnptr = &alListeneriv_Lazy;
        [UnmanagedCallersOnly]
        private static void alListeneriv_Lazy(int param, int* values)
        {
            _alListeneriv_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alListeneriv");
            _alListeneriv_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alListenerivDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alListenerivDirect_fnptr = &alListenerivDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alListenerivDirect_Lazy(IntPtr context, int param, int* values)
        {
            _alListenerivDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alListenerivDirect");
            _alListenerivDirect_fnptr(context, param, values);
        }
        
        /// <summary><b>[entry point: <c>alMacOSXGetRenderChannelCount</c>]</b></summary>
        public static delegate* unmanaged<int> _alMacOSXGetRenderChannelCount_fnptr = &alMacOSXGetRenderChannelCount_Lazy;
        [UnmanagedCallersOnly]
        private static int alMacOSXGetRenderChannelCount_Lazy()
        {
            _alMacOSXGetRenderChannelCount_fnptr = (delegate* unmanaged<int>)ALLoader.ALGetProcAddress("alMacOSXGetRenderChannelCount");
            return _alMacOSXGetRenderChannelCount_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alMacOSXGetRenderChannelCountDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _alMacOSXGetRenderChannelCountDirect_fnptr = &alMacOSXGetRenderChannelCountDirect_Lazy;
        [UnmanagedCallersOnly]
        private static int alMacOSXGetRenderChannelCountDirect_Lazy(IntPtr context)
        {
            _alMacOSXGetRenderChannelCountDirect_fnptr = (delegate* unmanaged<IntPtr, int>)ALLoader.ALGetProcAddress("alMacOSXGetRenderChannelCountDirect");
            return _alMacOSXGetRenderChannelCountDirect_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>alMacOSXRenderChannelCount</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alMacOSXRenderChannelCount_fnptr = &alMacOSXRenderChannelCount_Lazy;
        [UnmanagedCallersOnly]
        private static void alMacOSXRenderChannelCount_Lazy(int value)
        {
            _alMacOSXRenderChannelCount_fnptr = (delegate* unmanaged<int, void>)ALLoader.ALGetProcAddress("alMacOSXRenderChannelCount");
            _alMacOSXRenderChannelCount_fnptr(value);
        }
        
        /// <summary><b>[entry point: <c>alMacOSXRenderChannelCountDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, void> _alMacOSXRenderChannelCountDirect_fnptr = &alMacOSXRenderChannelCountDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alMacOSXRenderChannelCountDirect_Lazy(IntPtr context, int value)
        {
            _alMacOSXRenderChannelCountDirect_fnptr = (delegate* unmanaged<IntPtr, int, void>)ALLoader.ALGetProcAddress("alMacOSXRenderChannelCountDirect");
            _alMacOSXRenderChannelCountDirect_fnptr(context, value);
        }
        
        /// <summary><b>[entry point: <c>alObjectLabelDirectEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint, int, byte*, void> _alObjectLabelDirectEXT_fnptr = &alObjectLabelDirectEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alObjectLabelDirectEXT_Lazy(IntPtr context, int identifier, uint name, int length, byte* label)
        {
            _alObjectLabelDirectEXT_fnptr = (delegate* unmanaged<IntPtr, int, uint, int, byte*, void>)ALLoader.ALGetProcAddress("alObjectLabelDirectEXT");
            _alObjectLabelDirectEXT_fnptr(context, identifier, name, length, label);
        }
        
        /// <summary><b>[entry point: <c>alObjectLabelEXT</c>]</b></summary>
        public static delegate* unmanaged<int, uint, int, byte*, void> _alObjectLabelEXT_fnptr = &alObjectLabelEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alObjectLabelEXT_Lazy(int identifier, uint name, int length, byte* label)
        {
            _alObjectLabelEXT_fnptr = (delegate* unmanaged<int, uint, int, byte*, void>)ALLoader.ALGetProcAddress("alObjectLabelEXT");
            _alObjectLabelEXT_fnptr(identifier, name, length, label);
        }
        
        /// <summary><b>[entry point: <c>alPopDebugGroupDirectEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void> _alPopDebugGroupDirectEXT_fnptr = &alPopDebugGroupDirectEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alPopDebugGroupDirectEXT_Lazy(IntPtr context)
        {
            _alPopDebugGroupDirectEXT_fnptr = (delegate* unmanaged<IntPtr, void>)ALLoader.ALGetProcAddress("alPopDebugGroupDirectEXT");
            _alPopDebugGroupDirectEXT_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>alPopDebugGroupEXT</c>]</b></summary>
        public static delegate* unmanaged<void> _alPopDebugGroupEXT_fnptr = &alPopDebugGroupEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alPopDebugGroupEXT_Lazy()
        {
            _alPopDebugGroupEXT_fnptr = (delegate* unmanaged<void>)ALLoader.ALGetProcAddress("alPopDebugGroupEXT");
            _alPopDebugGroupEXT_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alProcessUpdatesDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void> _alProcessUpdatesDirectSOFT_fnptr = &alProcessUpdatesDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alProcessUpdatesDirectSOFT_Lazy(IntPtr context)
        {
            _alProcessUpdatesDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, void>)ALLoader.ALGetProcAddress("alProcessUpdatesDirectSOFT");
            _alProcessUpdatesDirectSOFT_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>alProcessUpdatesSOFT</c>]</b></summary>
        public static delegate* unmanaged<void> _alProcessUpdatesSOFT_fnptr = &alProcessUpdatesSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alProcessUpdatesSOFT_Lazy()
        {
            _alProcessUpdatesSOFT_fnptr = (delegate* unmanaged<void>)ALLoader.ALGetProcAddress("alProcessUpdatesSOFT");
            _alProcessUpdatesSOFT_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alPushDebugGroupDirectEXT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint, int, byte*, void> _alPushDebugGroupDirectEXT_fnptr = &alPushDebugGroupDirectEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alPushDebugGroupDirectEXT_Lazy(IntPtr context, int source, uint id, int length, byte* message)
        {
            _alPushDebugGroupDirectEXT_fnptr = (delegate* unmanaged<IntPtr, int, uint, int, byte*, void>)ALLoader.ALGetProcAddress("alPushDebugGroupDirectEXT");
            _alPushDebugGroupDirectEXT_fnptr(context, source, id, length, message);
        }
        
        /// <summary><b>[entry point: <c>alPushDebugGroupEXT</c>]</b></summary>
        public static delegate* unmanaged<int, uint, int, byte*, void> _alPushDebugGroupEXT_fnptr = &alPushDebugGroupEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alPushDebugGroupEXT_Lazy(int source, uint id, int length, byte* message)
        {
            _alPushDebugGroupEXT_fnptr = (delegate* unmanaged<int, uint, int, byte*, void>)ALLoader.ALGetProcAddress("alPushDebugGroupEXT");
            _alPushDebugGroupEXT_fnptr(source, id, length, message);
        }
        
        /// <summary><b>[entry point: <c>alRequestFoldbackStart</c>]</b></summary>
        public static delegate* unmanaged<int, int, int, float*, delegate* unmanaged[Cdecl]<All, nuint, void>, void> _alRequestFoldbackStart_fnptr = &alRequestFoldbackStart_Lazy;
        [UnmanagedCallersOnly]
        private static void alRequestFoldbackStart_Lazy(int foldbackMode, int blockCount, int blockLength, float* bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback)
        {
            _alRequestFoldbackStart_fnptr = (delegate* unmanaged<int, int, int, float*, delegate* unmanaged[Cdecl]<All, nuint, void>, void>)ALLoader.ALGetProcAddress("alRequestFoldbackStart");
            _alRequestFoldbackStart_fnptr(foldbackMode, blockCount, blockLength, bufferMemory, callback);
        }
        
        /// <summary><b>[entry point: <c>alRequestFoldbackStartDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, float*, delegate* unmanaged[Cdecl]<All, nuint, void>, void> _alRequestFoldbackStartDirect_fnptr = &alRequestFoldbackStartDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alRequestFoldbackStartDirect_Lazy(IntPtr context, int foldbackMode, int blockCount, int blockLength, float* bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback)
        {
            _alRequestFoldbackStartDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int, float*, delegate* unmanaged[Cdecl]<All, nuint, void>, void>)ALLoader.ALGetProcAddress("alRequestFoldbackStartDirect");
            _alRequestFoldbackStartDirect_fnptr(context, foldbackMode, blockCount, blockLength, bufferMemory, callback);
        }
        
        /// <summary><b>[entry point: <c>alRequestFoldbackStop</c>]</b></summary>
        public static delegate* unmanaged<void> _alRequestFoldbackStop_fnptr = &alRequestFoldbackStop_Lazy;
        [UnmanagedCallersOnly]
        private static void alRequestFoldbackStop_Lazy()
        {
            _alRequestFoldbackStop_fnptr = (delegate* unmanaged<void>)ALLoader.ALGetProcAddress("alRequestFoldbackStop");
            _alRequestFoldbackStop_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alRequestFoldbackStopDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void> _alRequestFoldbackStopDirect_fnptr = &alRequestFoldbackStopDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alRequestFoldbackStopDirect_Lazy(IntPtr context)
        {
            _alRequestFoldbackStopDirect_fnptr = (delegate* unmanaged<IntPtr, void>)ALLoader.ALGetProcAddress("alRequestFoldbackStopDirect");
            _alRequestFoldbackStopDirect_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>alSource3dDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, double, double, double, void> _alSource3dDirectSOFT_fnptr = &alSource3dDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSource3dDirectSOFT_Lazy(IntPtr context, int source, int param, double value1, double value2, double value3)
        {
            _alSource3dDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, double, double, double, void>)ALLoader.ALGetProcAddress("alSource3dDirectSOFT");
            _alSource3dDirectSOFT_fnptr(context, source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alSource3dSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, double, double, double, void> _alSource3dSOFT_fnptr = &alSource3dSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSource3dSOFT_Lazy(int source, int param, double value1, double value2, double value3)
        {
            _alSource3dSOFT_fnptr = (delegate* unmanaged<int, int, double, double, double, void>)ALLoader.ALGetProcAddress("alSource3dSOFT");
            _alSource3dSOFT_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alSource3f</c>]</b></summary>
        public static delegate* unmanaged<int, int, float, float, float, void> _alSource3f_fnptr = &alSource3f_Lazy;
        [UnmanagedCallersOnly]
        private static void alSource3f_Lazy(int source, int param, float value1, float value2, float value3)
        {
            _alSource3f_fnptr = (delegate* unmanaged<int, int, float, float, float, void>)ALLoader.ALGetProcAddress("alSource3f");
            _alSource3f_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alSource3fDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float, float, float, void> _alSource3fDirect_fnptr = &alSource3fDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSource3fDirect_Lazy(IntPtr context, int source, int param, float value1, float value2, float value3)
        {
            _alSource3fDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float, float, float, void>)ALLoader.ALGetProcAddress("alSource3fDirect");
            _alSource3fDirect_fnptr(context, source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alSource3i</c>]</b></summary>
        public static delegate* unmanaged<int, int, int, int, int, void> _alSource3i_fnptr = &alSource3i_Lazy;
        [UnmanagedCallersOnly]
        private static void alSource3i_Lazy(int source, int param, int value1, int value2, int value3)
        {
            _alSource3i_fnptr = (delegate* unmanaged<int, int, int, int, int, void>)ALLoader.ALGetProcAddress("alSource3i");
            _alSource3i_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alSource3i64DirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, long, long, long, void> _alSource3i64DirectSOFT_fnptr = &alSource3i64DirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSource3i64DirectSOFT_Lazy(IntPtr context, int source, int param, long value1, long value2, long value3)
        {
            _alSource3i64DirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, long, long, long, void>)ALLoader.ALGetProcAddress("alSource3i64DirectSOFT");
            _alSource3i64DirectSOFT_fnptr(context, source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alSource3i64SOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, long, long, long, void> _alSource3i64SOFT_fnptr = &alSource3i64SOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSource3i64SOFT_Lazy(int source, int param, long value1, long value2, long value3)
        {
            _alSource3i64SOFT_fnptr = (delegate* unmanaged<int, int, long, long, long, void>)ALLoader.ALGetProcAddress("alSource3i64SOFT");
            _alSource3i64SOFT_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alSource3iDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, int, int, void> _alSource3iDirect_fnptr = &alSource3iDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSource3iDirect_Lazy(IntPtr context, int source, int param, int value1, int value2, int value3)
        {
            _alSource3iDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int, int, int, void>)ALLoader.ALGetProcAddress("alSource3iDirect");
            _alSource3iDirect_fnptr(context, source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alSourceAddNotification</c>]</b></summary>
        public static delegate* unmanaged<int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*, int> _alSourceAddNotification_fnptr = &alSourceAddNotification_Lazy;
        [UnmanagedCallersOnly]
        private static int alSourceAddNotification_Lazy(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, void* userData)
        {
            _alSourceAddNotification_fnptr = (delegate* unmanaged<int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*, int>)ALLoader.ALGetProcAddress("alSourceAddNotification");
            return _alSourceAddNotification_fnptr(sid, notificationID, notifyProc, userData);
        }
        
        /// <summary><b>[entry point: <c>alSourceAddNotificationDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*, int> _alSourceAddNotificationDirect_fnptr = &alSourceAddNotificationDirect_Lazy;
        [UnmanagedCallersOnly]
        private static int alSourceAddNotificationDirect_Lazy(IntPtr context, int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, void* userData)
        {
            _alSourceAddNotificationDirect_fnptr = (delegate* unmanaged<IntPtr, int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*, int>)ALLoader.ALGetProcAddress("alSourceAddNotificationDirect");
            return _alSourceAddNotificationDirect_fnptr(context, sid, notificationID, notifyProc, userData);
        }
        
        /// <summary><b>[entry point: <c>alSourcedDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, double, void> _alSourcedDirectSOFT_fnptr = &alSourcedDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcedDirectSOFT_Lazy(IntPtr context, int source, int param, double value)
        {
            _alSourcedDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, double, void>)ALLoader.ALGetProcAddress("alSourcedDirectSOFT");
            _alSourcedDirectSOFT_fnptr(context, source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourcedSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, double, void> _alSourcedSOFT_fnptr = &alSourcedSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcedSOFT_Lazy(int source, int param, double value)
        {
            _alSourcedSOFT_fnptr = (delegate* unmanaged<int, int, double, void>)ALLoader.ALGetProcAddress("alSourcedSOFT");
            _alSourcedSOFT_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourcedvDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, double*, void> _alSourcedvDirectSOFT_fnptr = &alSourcedvDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcedvDirectSOFT_Lazy(IntPtr context, int source, int param, double* values)
        {
            _alSourcedvDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, double*, void>)ALLoader.ALGetProcAddress("alSourcedvDirectSOFT");
            _alSourcedvDirectSOFT_fnptr(context, source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alSourcedvSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, double*, void> _alSourcedvSOFT_fnptr = &alSourcedvSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcedvSOFT_Lazy(int source, int param, double* values)
        {
            _alSourcedvSOFT_fnptr = (delegate* unmanaged<int, int, double*, void>)ALLoader.ALGetProcAddress("alSourcedvSOFT");
            _alSourcedvSOFT_fnptr(source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alSourcef</c>]</b></summary>
        public static delegate* unmanaged<int, int, float, void> _alSourcef_fnptr = &alSourcef_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcef_Lazy(int source, int param, float value)
        {
            _alSourcef_fnptr = (delegate* unmanaged<int, int, float, void>)ALLoader.ALGetProcAddress("alSourcef");
            _alSourcef_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourcefDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float, void> _alSourcefDirect_fnptr = &alSourcefDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcefDirect_Lazy(IntPtr context, int source, int param, float value)
        {
            _alSourcefDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float, void>)ALLoader.ALGetProcAddress("alSourcefDirect");
            _alSourcefDirect_fnptr(context, source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourcefv</c>]</b></summary>
        public static delegate* unmanaged<int, int, float*, void> _alSourcefv_fnptr = &alSourcefv_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcefv_Lazy(int source, int param, float* value)
        {
            _alSourcefv_fnptr = (delegate* unmanaged<int, int, float*, void>)ALLoader.ALGetProcAddress("alSourcefv");
            _alSourcefv_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourcefvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, float*, void> _alSourcefvDirect_fnptr = &alSourcefvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcefvDirect_Lazy(IntPtr context, int source, int param, float* value)
        {
            _alSourcefvDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, float*, void>)ALLoader.ALGetProcAddress("alSourcefvDirect");
            _alSourcefvDirect_fnptr(context, source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourceGetRenderingQuality</c>]</b></summary>
        public static delegate* unmanaged<int, int> _alSourceGetRenderingQuality_fnptr = &alSourceGetRenderingQuality_Lazy;
        [UnmanagedCallersOnly]
        private static int alSourceGetRenderingQuality_Lazy(int sid)
        {
            _alSourceGetRenderingQuality_fnptr = (delegate* unmanaged<int, int>)ALLoader.ALGetProcAddress("alSourceGetRenderingQuality");
            return _alSourceGetRenderingQuality_fnptr(sid);
        }
        
        /// <summary><b>[entry point: <c>alSourceGetRenderingQualityDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int> _alSourceGetRenderingQualityDirect_fnptr = &alSourceGetRenderingQualityDirect_Lazy;
        [UnmanagedCallersOnly]
        private static int alSourceGetRenderingQualityDirect_Lazy(IntPtr context, int sid)
        {
            _alSourceGetRenderingQualityDirect_fnptr = (delegate* unmanaged<IntPtr, int, int>)ALLoader.ALGetProcAddress("alSourceGetRenderingQualityDirect");
            return _alSourceGetRenderingQualityDirect_fnptr(context, sid);
        }
        
        /// <summary><b>[entry point: <c>alSourcei</c>]</b></summary>
        public static delegate* unmanaged<int, int, int, void> _alSourcei_fnptr = &alSourcei_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcei_Lazy(int source, int param, int value)
        {
            _alSourcei_fnptr = (delegate* unmanaged<int, int, int, void>)ALLoader.ALGetProcAddress("alSourcei");
            _alSourcei_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourcei64DirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, long, void> _alSourcei64DirectSOFT_fnptr = &alSourcei64DirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcei64DirectSOFT_Lazy(IntPtr context, int source, int param, long value)
        {
            _alSourcei64DirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, long, void>)ALLoader.ALGetProcAddress("alSourcei64DirectSOFT");
            _alSourcei64DirectSOFT_fnptr(context, source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourcei64SOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, long, void> _alSourcei64SOFT_fnptr = &alSourcei64SOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcei64SOFT_Lazy(int source, int param, long value)
        {
            _alSourcei64SOFT_fnptr = (delegate* unmanaged<int, int, long, void>)ALLoader.ALGetProcAddress("alSourcei64SOFT");
            _alSourcei64SOFT_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourcei64vDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, long*, void> _alSourcei64vDirectSOFT_fnptr = &alSourcei64vDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcei64vDirectSOFT_Lazy(IntPtr context, int source, int param, long* values)
        {
            _alSourcei64vDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, long*, void>)ALLoader.ALGetProcAddress("alSourcei64vDirectSOFT");
            _alSourcei64vDirectSOFT_fnptr(context, source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alSourcei64vSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, long*, void> _alSourcei64vSOFT_fnptr = &alSourcei64vSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcei64vSOFT_Lazy(int source, int param, long* values)
        {
            _alSourcei64vSOFT_fnptr = (delegate* unmanaged<int, int, long*, void>)ALLoader.ALGetProcAddress("alSourcei64vSOFT");
            _alSourcei64vSOFT_fnptr(source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alSourceiDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, void> _alSourceiDirect_fnptr = &alSourceiDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceiDirect_Lazy(IntPtr context, int source, int param, int value)
        {
            _alSourceiDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int, void>)ALLoader.ALGetProcAddress("alSourceiDirect");
            _alSourceiDirect_fnptr(context, source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourceiv</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alSourceiv_fnptr = &alSourceiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceiv_Lazy(int source, int param, int* value)
        {
            _alSourceiv_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alSourceiv");
            _alSourceiv_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourceivDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alSourceivDirect_fnptr = &alSourceivDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceivDirect_Lazy(IntPtr context, int source, int param, int* value)
        {
            _alSourceivDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alSourceivDirect");
            _alSourceivDirect_fnptr(context, source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourcePause</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alSourcePause_fnptr = &alSourcePause_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePause_Lazy(int source)
        {
            _alSourcePause_fnptr = (delegate* unmanaged<int, void>)ALLoader.ALGetProcAddress("alSourcePause");
            _alSourcePause_fnptr(source);
        }
        
        /// <summary><b>[entry point: <c>alSourcePauseDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, void> _alSourcePauseDirect_fnptr = &alSourcePauseDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePauseDirect_Lazy(IntPtr context, int source)
        {
            _alSourcePauseDirect_fnptr = (delegate* unmanaged<IntPtr, int, void>)ALLoader.ALGetProcAddress("alSourcePauseDirect");
            _alSourcePauseDirect_fnptr(context, source);
        }
        
        /// <summary><b>[entry point: <c>alSourcePausev</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alSourcePausev_fnptr = &alSourcePausev_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePausev_Lazy(int n, int* sources)
        {
            _alSourcePausev_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alSourcePausev");
            _alSourcePausev_fnptr(n, sources);
        }
        
        /// <summary><b>[entry point: <c>alSourcePausevDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alSourcePausevDirect_fnptr = &alSourcePausevDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePausevDirect_Lazy(IntPtr context, int n, int* sources)
        {
            _alSourcePausevDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alSourcePausevDirect");
            _alSourcePausevDirect_fnptr(context, n, sources);
        }
        
        /// <summary><b>[entry point: <c>alSourcePlay</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alSourcePlay_fnptr = &alSourcePlay_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePlay_Lazy(int source)
        {
            _alSourcePlay_fnptr = (delegate* unmanaged<int, void>)ALLoader.ALGetProcAddress("alSourcePlay");
            _alSourcePlay_fnptr(source);
        }
        
        /// <summary><b>[entry point: <c>alSourcePlayAtTimeDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, long, void> _alSourcePlayAtTimeDirectSOFT_fnptr = &alSourcePlayAtTimeDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePlayAtTimeDirectSOFT_Lazy(IntPtr context, int source, long start_time)
        {
            _alSourcePlayAtTimeDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, long, void>)ALLoader.ALGetProcAddress("alSourcePlayAtTimeDirectSOFT");
            _alSourcePlayAtTimeDirectSOFT_fnptr(context, source, start_time);
        }
        
        /// <summary><b>[entry point: <c>alSourcePlayAtTimeSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, long, void> _alSourcePlayAtTimeSOFT_fnptr = &alSourcePlayAtTimeSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePlayAtTimeSOFT_Lazy(int source, long start_time)
        {
            _alSourcePlayAtTimeSOFT_fnptr = (delegate* unmanaged<int, long, void>)ALLoader.ALGetProcAddress("alSourcePlayAtTimeSOFT");
            _alSourcePlayAtTimeSOFT_fnptr(source, start_time);
        }
        
        /// <summary><b>[entry point: <c>alSourcePlayAtTimevDirectSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, long, void> _alSourcePlayAtTimevDirectSOFT_fnptr = &alSourcePlayAtTimevDirectSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePlayAtTimevDirectSOFT_Lazy(IntPtr context, int n, int* sources, long start_time)
        {
            _alSourcePlayAtTimevDirectSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int*, long, void>)ALLoader.ALGetProcAddress("alSourcePlayAtTimevDirectSOFT");
            _alSourcePlayAtTimevDirectSOFT_fnptr(context, n, sources, start_time);
        }
        
        /// <summary><b>[entry point: <c>alSourcePlayAtTimevSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int*, long, void> _alSourcePlayAtTimevSOFT_fnptr = &alSourcePlayAtTimevSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePlayAtTimevSOFT_Lazy(int n, int* sources, long start_time)
        {
            _alSourcePlayAtTimevSOFT_fnptr = (delegate* unmanaged<int, int*, long, void>)ALLoader.ALGetProcAddress("alSourcePlayAtTimevSOFT");
            _alSourcePlayAtTimevSOFT_fnptr(n, sources, start_time);
        }
        
        /// <summary><b>[entry point: <c>alSourcePlayDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, void> _alSourcePlayDirect_fnptr = &alSourcePlayDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePlayDirect_Lazy(IntPtr context, int source)
        {
            _alSourcePlayDirect_fnptr = (delegate* unmanaged<IntPtr, int, void>)ALLoader.ALGetProcAddress("alSourcePlayDirect");
            _alSourcePlayDirect_fnptr(context, source);
        }
        
        /// <summary><b>[entry point: <c>alSourcePlayv</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alSourcePlayv_fnptr = &alSourcePlayv_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePlayv_Lazy(int n, int* sources)
        {
            _alSourcePlayv_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alSourcePlayv");
            _alSourcePlayv_fnptr(n, sources);
        }
        
        /// <summary><b>[entry point: <c>alSourcePlayvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alSourcePlayvDirect_fnptr = &alSourcePlayvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePlayvDirect_Lazy(IntPtr context, int n, int* sources)
        {
            _alSourcePlayvDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alSourcePlayvDirect");
            _alSourcePlayvDirect_fnptr(context, n, sources);
        }
        
        /// <summary><b>[entry point: <c>alSourceQueueBuffers</c>]</b></summary>
        public static delegate* unmanaged<int, int, uint*, void> _alSourceQueueBuffers_fnptr = &alSourceQueueBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceQueueBuffers_Lazy(int source, int nb, uint* buffers)
        {
            _alSourceQueueBuffers_fnptr = (delegate* unmanaged<int, int, uint*, void>)ALLoader.ALGetProcAddress("alSourceQueueBuffers");
            _alSourceQueueBuffers_fnptr(source, nb, buffers);
        }
        
        /// <summary><b>[entry point: <c>alSourceQueueBuffersDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, uint*, void> _alSourceQueueBuffersDirect_fnptr = &alSourceQueueBuffersDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceQueueBuffersDirect_Lazy(IntPtr context, int source, int nb, uint* buffers)
        {
            _alSourceQueueBuffersDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, uint*, void>)ALLoader.ALGetProcAddress("alSourceQueueBuffersDirect");
            _alSourceQueueBuffersDirect_fnptr(context, source, nb, buffers);
        }
        
        /// <summary><b>[entry point: <c>alSourceRemoveNotification</c>]</b></summary>
        public static delegate* unmanaged<int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*, void> _alSourceRemoveNotification_fnptr = &alSourceRemoveNotification_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceRemoveNotification_Lazy(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, void* userData)
        {
            _alSourceRemoveNotification_fnptr = (delegate* unmanaged<int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*, void>)ALLoader.ALGetProcAddress("alSourceRemoveNotification");
            _alSourceRemoveNotification_fnptr(sid, notificationID, notifyProc, userData);
        }
        
        /// <summary><b>[entry point: <c>alSourceRemoveNotificationDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*, void> _alSourceRemoveNotificationDirect_fnptr = &alSourceRemoveNotificationDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceRemoveNotificationDirect_Lazy(IntPtr context, int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, void* userData)
        {
            _alSourceRemoveNotificationDirect_fnptr = (delegate* unmanaged<IntPtr, int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*, void>)ALLoader.ALGetProcAddress("alSourceRemoveNotificationDirect");
            _alSourceRemoveNotificationDirect_fnptr(context, sid, notificationID, notifyProc, userData);
        }
        
        /// <summary><b>[entry point: <c>alSourceRenderingQuality</c>]</b></summary>
        public static delegate* unmanaged<int, int, void> _alSourceRenderingQuality_fnptr = &alSourceRenderingQuality_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceRenderingQuality_Lazy(int sid, int value)
        {
            _alSourceRenderingQuality_fnptr = (delegate* unmanaged<int, int, void>)ALLoader.ALGetProcAddress("alSourceRenderingQuality");
            _alSourceRenderingQuality_fnptr(sid, value);
        }
        
        /// <summary><b>[entry point: <c>alSourceRenderingQualityDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, void> _alSourceRenderingQualityDirect_fnptr = &alSourceRenderingQualityDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceRenderingQualityDirect_Lazy(IntPtr context, int sid, int value)
        {
            _alSourceRenderingQualityDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, void>)ALLoader.ALGetProcAddress("alSourceRenderingQualityDirect");
            _alSourceRenderingQualityDirect_fnptr(context, sid, value);
        }
        
        /// <summary><b>[entry point: <c>alSourceRewind</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alSourceRewind_fnptr = &alSourceRewind_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceRewind_Lazy(int source)
        {
            _alSourceRewind_fnptr = (delegate* unmanaged<int, void>)ALLoader.ALGetProcAddress("alSourceRewind");
            _alSourceRewind_fnptr(source);
        }
        
        /// <summary><b>[entry point: <c>alSourceRewindDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, void> _alSourceRewindDirect_fnptr = &alSourceRewindDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceRewindDirect_Lazy(IntPtr context, int source)
        {
            _alSourceRewindDirect_fnptr = (delegate* unmanaged<IntPtr, int, void>)ALLoader.ALGetProcAddress("alSourceRewindDirect");
            _alSourceRewindDirect_fnptr(context, source);
        }
        
        /// <summary><b>[entry point: <c>alSourceRewindv</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alSourceRewindv_fnptr = &alSourceRewindv_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceRewindv_Lazy(int n, int* sources)
        {
            _alSourceRewindv_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alSourceRewindv");
            _alSourceRewindv_fnptr(n, sources);
        }
        
        /// <summary><b>[entry point: <c>alSourceRewindvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alSourceRewindvDirect_fnptr = &alSourceRewindvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceRewindvDirect_Lazy(IntPtr context, int n, int* sources)
        {
            _alSourceRewindvDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alSourceRewindvDirect");
            _alSourceRewindvDirect_fnptr(context, n, sources);
        }
        
        /// <summary><b>[entry point: <c>alSourceStop</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alSourceStop_fnptr = &alSourceStop_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceStop_Lazy(int source)
        {
            _alSourceStop_fnptr = (delegate* unmanaged<int, void>)ALLoader.ALGetProcAddress("alSourceStop");
            _alSourceStop_fnptr(source);
        }
        
        /// <summary><b>[entry point: <c>alSourceStopDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, void> _alSourceStopDirect_fnptr = &alSourceStopDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceStopDirect_Lazy(IntPtr context, int source)
        {
            _alSourceStopDirect_fnptr = (delegate* unmanaged<IntPtr, int, void>)ALLoader.ALGetProcAddress("alSourceStopDirect");
            _alSourceStopDirect_fnptr(context, source);
        }
        
        /// <summary><b>[entry point: <c>alSourceStopv</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alSourceStopv_fnptr = &alSourceStopv_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceStopv_Lazy(int n, int* sources)
        {
            _alSourceStopv_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.ALGetProcAddress("alSourceStopv");
            _alSourceStopv_fnptr(n, sources);
        }
        
        /// <summary><b>[entry point: <c>alSourceStopvDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int*, void> _alSourceStopvDirect_fnptr = &alSourceStopvDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceStopvDirect_Lazy(IntPtr context, int n, int* sources)
        {
            _alSourceStopvDirect_fnptr = (delegate* unmanaged<IntPtr, int, int*, void>)ALLoader.ALGetProcAddress("alSourceStopvDirect");
            _alSourceStopvDirect_fnptr(context, n, sources);
        }
        
        /// <summary><b>[entry point: <c>alSourceUnqueueBuffers</c>]</b></summary>
        public static delegate* unmanaged<int, int, int*, void> _alSourceUnqueueBuffers_fnptr = &alSourceUnqueueBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceUnqueueBuffers_Lazy(int source, int nb, int* buffer)
        {
            _alSourceUnqueueBuffers_fnptr = (delegate* unmanaged<int, int, int*, void>)ALLoader.ALGetProcAddress("alSourceUnqueueBuffers");
            _alSourceUnqueueBuffers_fnptr(source, nb, buffer);
        }
        
        /// <summary><b>[entry point: <c>alSourceUnqueueBuffersDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, void> _alSourceUnqueueBuffersDirect_fnptr = &alSourceUnqueueBuffersDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceUnqueueBuffersDirect_Lazy(IntPtr context, int source, int nb, int* buffer)
        {
            _alSourceUnqueueBuffersDirect_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, void>)ALLoader.ALGetProcAddress("alSourceUnqueueBuffersDirect");
            _alSourceUnqueueBuffersDirect_fnptr(context, source, nb, buffer);
        }
        
        /// <summary><b>[entry point: <c>alSpeedOfSound</c>]</b></summary>
        public static delegate* unmanaged<float, void> _alSpeedOfSound_fnptr = &alSpeedOfSound_Lazy;
        [UnmanagedCallersOnly]
        private static void alSpeedOfSound_Lazy(float value)
        {
            _alSpeedOfSound_fnptr = (delegate* unmanaged<float, void>)ALLoader.ALGetProcAddress("alSpeedOfSound");
            _alSpeedOfSound_fnptr(value);
        }
        
        /// <summary><b>[entry point: <c>alSpeedOfSoundDirect</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, float, void> _alSpeedOfSoundDirect_fnptr = &alSpeedOfSoundDirect_Lazy;
        [UnmanagedCallersOnly]
        private static void alSpeedOfSoundDirect_Lazy(IntPtr context, float value)
        {
            _alSpeedOfSoundDirect_fnptr = (delegate* unmanaged<IntPtr, float, void>)ALLoader.ALGetProcAddress("alSpeedOfSoundDirect");
            _alSpeedOfSoundDirect_fnptr(context, value);
        }
        
        /// <summary><b>[entry point: <c>AttenuationScale_DirectLOKI</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, float, void> _AttenuationScale_DirectLOKI_fnptr = &AttenuationScale_DirectLOKI_Lazy;
        [UnmanagedCallersOnly]
        private static void AttenuationScale_DirectLOKI_Lazy(IntPtr context, float value)
        {
            _AttenuationScale_DirectLOKI_fnptr = (delegate* unmanaged<IntPtr, float, void>)ALLoader.ALGetProcAddress("AttenuationScale_DirectLOKI");
            _AttenuationScale_DirectLOKI_fnptr(context, value);
        }
        
        /// <summary><b>[entry point: <c>AttenuationScale_LOKI</c>]</b></summary>
        public static delegate* unmanaged<float, void> _AttenuationScale_LOKI_fnptr = &AttenuationScale_LOKI_Lazy;
        [UnmanagedCallersOnly]
        private static void AttenuationScale_LOKI_Lazy(float value)
        {
            _AttenuationScale_LOKI_fnptr = (delegate* unmanaged<float, void>)ALLoader.ALGetProcAddress("AttenuationScale_LOKI");
            _AttenuationScale_LOKI_fnptr(value);
        }
        
        /// <summary><b>[entry point: <c>BufferDataWithCallback_DirectLOKI</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, delegate* unmanaged[Cdecl]<uint, uint, void*, All, uint, int>, void> _BufferDataWithCallback_DirectLOKI_fnptr = &BufferDataWithCallback_DirectLOKI_Lazy;
        [UnmanagedCallersOnly]
        private static void BufferDataWithCallback_DirectLOKI_Lazy(IntPtr context, int bid, delegate* unmanaged[Cdecl]<uint, uint, void*, All, uint, int> callback)
        {
            _BufferDataWithCallback_DirectLOKI_fnptr = (delegate* unmanaged<IntPtr, int, delegate* unmanaged[Cdecl]<uint, uint, void*, All, uint, int>, void>)ALLoader.ALGetProcAddress("BufferDataWithCallback_DirectLOKI");
            _BufferDataWithCallback_DirectLOKI_fnptr(context, bid, callback);
        }
        
        /// <summary><b>[entry point: <c>BufferDataWithCallback_LOKI</c>]</b></summary>
        public static delegate* unmanaged<int, delegate* unmanaged[Cdecl]<uint, uint, void*, All, uint, int>, void> _BufferDataWithCallback_LOKI_fnptr = &BufferDataWithCallback_LOKI_Lazy;
        [UnmanagedCallersOnly]
        private static void BufferDataWithCallback_LOKI_Lazy(int bid, delegate* unmanaged[Cdecl]<uint, uint, void*, All, uint, int> callback)
        {
            _BufferDataWithCallback_LOKI_fnptr = (delegate* unmanaged<int, delegate* unmanaged[Cdecl]<uint, uint, void*, All, uint, int>, void>)ALLoader.ALGetProcAddress("BufferDataWithCallback_LOKI");
            _BufferDataWithCallback_LOKI_fnptr(bid, callback);
        }
        
    }
}

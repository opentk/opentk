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
        public static delegate* unmanaged<uint, int, float, void> _alAuxiliaryEffectSlotf_fnptr = &alAuxiliaryEffectSlotf_Lazy;
        [UnmanagedCallersOnly]
        private static void alAuxiliaryEffectSlotf_Lazy(uint effectslot, int param, float flValue)
        {
            _alAuxiliaryEffectSlotf_fnptr = (delegate* unmanaged<uint, int, float, void>)ALLoader.BindingsContext.GetProcAddress("alAuxiliaryEffectSlotf");
            _alAuxiliaryEffectSlotf_fnptr(effectslot, param, flValue);
        }
        
        /// <summary><b>[entry point: <c>alAuxiliaryEffectSlotfv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, void> _alAuxiliaryEffectSlotfv_fnptr = &alAuxiliaryEffectSlotfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alAuxiliaryEffectSlotfv_Lazy(uint effectslot, int param, float* pflValues)
        {
            _alAuxiliaryEffectSlotfv_fnptr = (delegate* unmanaged<uint, int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alAuxiliaryEffectSlotfv");
            _alAuxiliaryEffectSlotfv_fnptr(effectslot, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alAuxiliaryEffectSloti</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int, void> _alAuxiliaryEffectSloti_fnptr = &alAuxiliaryEffectSloti_Lazy;
        [UnmanagedCallersOnly]
        private static void alAuxiliaryEffectSloti_Lazy(uint effectslot, int param, int iValue)
        {
            _alAuxiliaryEffectSloti_fnptr = (delegate* unmanaged<uint, int, int, void>)ALLoader.BindingsContext.GetProcAddress("alAuxiliaryEffectSloti");
            _alAuxiliaryEffectSloti_fnptr(effectslot, param, iValue);
        }
        
        /// <summary><b>[entry point: <c>alAuxiliaryEffectSlotiv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, void> _alAuxiliaryEffectSlotiv_fnptr = &alAuxiliaryEffectSlotiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alAuxiliaryEffectSlotiv_Lazy(uint effectslot, int param, int* piValues)
        {
            _alAuxiliaryEffectSlotiv_fnptr = (delegate* unmanaged<uint, int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alAuxiliaryEffectSlotiv");
            _alAuxiliaryEffectSlotiv_fnptr(effectslot, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alBuffer3f</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float, float, float, void> _alBuffer3f_fnptr = &alBuffer3f_Lazy;
        [UnmanagedCallersOnly]
        private static void alBuffer3f_Lazy(uint buffer, int param, float value1, float value2, float value3)
        {
            _alBuffer3f_fnptr = (delegate* unmanaged<uint, int, float, float, float, void>)ALLoader.BindingsContext.GetProcAddress("alBuffer3f");
            _alBuffer3f_fnptr(buffer, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alBuffer3i</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int, int, int, void> _alBuffer3i_fnptr = &alBuffer3i_Lazy;
        [UnmanagedCallersOnly]
        private static void alBuffer3i_Lazy(uint buffer, int param, int value1, int value2, int value3)
        {
            _alBuffer3i_fnptr = (delegate* unmanaged<uint, int, int, int, int, void>)ALLoader.BindingsContext.GetProcAddress("alBuffer3i");
            _alBuffer3i_fnptr(buffer, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alBufferCallbackSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*, void> _alBufferCallbackSOFT_fnptr = &alBufferCallbackSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferCallbackSOFT_Lazy(uint buffer, int format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, void* userptr)
        {
            _alBufferCallbackSOFT_fnptr = (delegate* unmanaged<uint, int, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*, void>)ALLoader.BindingsContext.GetProcAddress("alBufferCallbackSOFT");
            _alBufferCallbackSOFT_fnptr(buffer, format, freq, callback, userptr);
        }
        
        /// <summary><b>[entry point: <c>alBufferData</c>]</b></summary>
        public static delegate* unmanaged<uint, int, void*, int, int, void> _alBufferData_fnptr = &alBufferData_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferData_Lazy(uint buffer, int format, void* data, int size, int samplerate)
        {
            _alBufferData_fnptr = (delegate* unmanaged<uint, int, void*, int, int, void>)ALLoader.BindingsContext.GetProcAddress("alBufferData");
            _alBufferData_fnptr(buffer, format, data, size, samplerate);
        }
        
        /// <summary><b>[entry point: <c>alBufferf</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float, void> _alBufferf_fnptr = &alBufferf_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferf_Lazy(uint buffer, int param, float value)
        {
            _alBufferf_fnptr = (delegate* unmanaged<uint, int, float, void>)ALLoader.BindingsContext.GetProcAddress("alBufferf");
            _alBufferf_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alBufferfv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, void> _alBufferfv_fnptr = &alBufferfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferfv_Lazy(uint buffer, int param, float* value)
        {
            _alBufferfv_fnptr = (delegate* unmanaged<uint, int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alBufferfv");
            _alBufferfv_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alBufferi</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int, void> _alBufferi_fnptr = &alBufferi_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferi_Lazy(uint buffer, int param, int value)
        {
            _alBufferi_fnptr = (delegate* unmanaged<uint, int, int, void>)ALLoader.BindingsContext.GetProcAddress("alBufferi");
            _alBufferi_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alBufferiv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, void> _alBufferiv_fnptr = &alBufferiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferiv_Lazy(uint buffer, int param, int* value)
        {
            _alBufferiv_fnptr = (delegate* unmanaged<uint, int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alBufferiv");
            _alBufferiv_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alBufferSamplesSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, uint, int, int, int, int, void*, void> _alBufferSamplesSOFT_fnptr = &alBufferSamplesSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferSamplesSOFT_Lazy(uint buffer, uint samplerate, int internalformat, int samples, int channels, int type, void* data)
        {
            _alBufferSamplesSOFT_fnptr = (delegate* unmanaged<uint, uint, int, int, int, int, void*, void>)ALLoader.BindingsContext.GetProcAddress("alBufferSamplesSOFT");
            _alBufferSamplesSOFT_fnptr(buffer, samplerate, internalformat, samples, channels, type, data);
        }
        
        /// <summary><b>[entry point: <c>alBufferSubDataSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, void*, int, int, void> _alBufferSubDataSOFT_fnptr = &alBufferSubDataSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferSubDataSOFT_Lazy(uint buffer, int format, void* data, int offset, int length)
        {
            _alBufferSubDataSOFT_fnptr = (delegate* unmanaged<uint, int, void*, int, int, void>)ALLoader.BindingsContext.GetProcAddress("alBufferSubDataSOFT");
            _alBufferSubDataSOFT_fnptr(buffer, format, data, offset, length);
        }
        
        /// <summary><b>[entry point: <c>alBufferSubSamplesSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int, int, int, void*, void> _alBufferSubSamplesSOFT_fnptr = &alBufferSubSamplesSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alBufferSubSamplesSOFT_Lazy(uint buffer, int offset, int samples, int channels, int type, void* data)
        {
            _alBufferSubSamplesSOFT_fnptr = (delegate* unmanaged<uint, int, int, int, int, void*, void>)ALLoader.BindingsContext.GetProcAddress("alBufferSubSamplesSOFT");
            _alBufferSubSamplesSOFT_fnptr(buffer, offset, samples, channels, type, data);
        }
        
        /// <summary><b>[entry point: <c>alDebugMessageCallbackEXT</c>]</b></summary>
        public static delegate* unmanaged<delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int>, void*, void> _alDebugMessageCallbackEXT_fnptr = &alDebugMessageCallbackEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alDebugMessageCallbackEXT_Lazy(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, void* userParam)
        {
            _alDebugMessageCallbackEXT_fnptr = (delegate* unmanaged<delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int>, void*, void>)ALLoader.BindingsContext.GetProcAddress("alDebugMessageCallbackEXT");
            _alDebugMessageCallbackEXT_fnptr(callback, userParam);
        }
        
        /// <summary><b>[entry point: <c>alDebugMessageControlEXT</c>]</b></summary>
        public static delegate* unmanaged<int, int, uint, int, uint*, byte, void> _alDebugMessageControlEXT_fnptr = &alDebugMessageControlEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alDebugMessageControlEXT_Lazy(int source, int type, uint severity, int count, uint* ids, byte enable)
        {
            _alDebugMessageControlEXT_fnptr = (delegate* unmanaged<int, int, uint, int, uint*, byte, void>)ALLoader.BindingsContext.GetProcAddress("alDebugMessageControlEXT");
            _alDebugMessageControlEXT_fnptr(source, type, severity, count, ids, enable);
        }
        
        /// <summary><b>[entry point: <c>alDebugMessageInsertEXT</c>]</b></summary>
        public static delegate* unmanaged<int, int, uint, int, byte*, void> _alDebugMessageInsertEXT_fnptr = &alDebugMessageInsertEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alDebugMessageInsertEXT_Lazy(int source, int type, uint severity, int length, byte* message)
        {
            _alDebugMessageInsertEXT_fnptr = (delegate* unmanaged<int, int, uint, int, byte*, void>)ALLoader.BindingsContext.GetProcAddress("alDebugMessageInsertEXT");
            _alDebugMessageInsertEXT_fnptr(source, type, severity, length, message);
        }
        
        /// <summary><b>[entry point: <c>alDeferUpdatesSOFT</c>]</b></summary>
        public static delegate* unmanaged<void> _alDeferUpdatesSOFT_fnptr = &alDeferUpdatesSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeferUpdatesSOFT_Lazy()
        {
            _alDeferUpdatesSOFT_fnptr = (delegate* unmanaged<void>)ALLoader.BindingsContext.GetProcAddress("alDeferUpdatesSOFT");
            _alDeferUpdatesSOFT_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alDeleteAuxiliaryEffectSlots</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, void> _alDeleteAuxiliaryEffectSlots_fnptr = &alDeleteAuxiliaryEffectSlots_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeleteAuxiliaryEffectSlots_Lazy(int n, uint* effectslots)
        {
            _alDeleteAuxiliaryEffectSlots_fnptr = (delegate* unmanaged<int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alDeleteAuxiliaryEffectSlots");
            _alDeleteAuxiliaryEffectSlots_fnptr(n, effectslots);
        }
        
        /// <summary><b>[entry point: <c>alDeleteBuffers</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, void> _alDeleteBuffers_fnptr = &alDeleteBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeleteBuffers_Lazy(int n, uint* buffers)
        {
            _alDeleteBuffers_fnptr = (delegate* unmanaged<int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alDeleteBuffers");
            _alDeleteBuffers_fnptr(n, buffers);
        }
        
        /// <summary><b>[entry point: <c>alDeleteEffects</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, void> _alDeleteEffects_fnptr = &alDeleteEffects_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeleteEffects_Lazy(int n, uint* effects)
        {
            _alDeleteEffects_fnptr = (delegate* unmanaged<int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alDeleteEffects");
            _alDeleteEffects_fnptr(n, effects);
        }
        
        /// <summary><b>[entry point: <c>alDeleteFilters</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, void> _alDeleteFilters_fnptr = &alDeleteFilters_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeleteFilters_Lazy(int n, uint* filters)
        {
            _alDeleteFilters_fnptr = (delegate* unmanaged<int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alDeleteFilters");
            _alDeleteFilters_fnptr(n, filters);
        }
        
        /// <summary><b>[entry point: <c>alDeleteSources</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, void> _alDeleteSources_fnptr = &alDeleteSources_Lazy;
        [UnmanagedCallersOnly]
        private static void alDeleteSources_Lazy(int n, uint* sources)
        {
            _alDeleteSources_fnptr = (delegate* unmanaged<int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alDeleteSources");
            _alDeleteSources_fnptr(n, sources);
        }
        
        /// <summary><b>[entry point: <c>alDisable</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alDisable_fnptr = &alDisable_Lazy;
        [UnmanagedCallersOnly]
        private static void alDisable_Lazy(int capability)
        {
            _alDisable_fnptr = (delegate* unmanaged<int, void>)ALLoader.BindingsContext.GetProcAddress("alDisable");
            _alDisable_fnptr(capability);
        }
        
        /// <summary><b>[entry point: <c>alDistanceModel</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alDistanceModel_fnptr = &alDistanceModel_Lazy;
        [UnmanagedCallersOnly]
        private static void alDistanceModel_Lazy(int distanceModel)
        {
            _alDistanceModel_fnptr = (delegate* unmanaged<int, void>)ALLoader.BindingsContext.GetProcAddress("alDistanceModel");
            _alDistanceModel_fnptr(distanceModel);
        }
        
        /// <summary><b>[entry point: <c>alDopperFactor</c>]</b></summary>
        public static delegate* unmanaged<float, void> _alDopperFactor_fnptr = &alDopperFactor_Lazy;
        [UnmanagedCallersOnly]
        private static void alDopperFactor_Lazy(float value)
        {
            _alDopperFactor_fnptr = (delegate* unmanaged<float, void>)ALLoader.BindingsContext.GetProcAddress("alDopperFactor");
            _alDopperFactor_fnptr(value);
        }
        
        /// <summary><b>[entry point: <c>alEffectf</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float, void> _alEffectf_fnptr = &alEffectf_Lazy;
        [UnmanagedCallersOnly]
        private static void alEffectf_Lazy(uint effect, int param, float flValue)
        {
            _alEffectf_fnptr = (delegate* unmanaged<uint, int, float, void>)ALLoader.BindingsContext.GetProcAddress("alEffectf");
            _alEffectf_fnptr(effect, param, flValue);
        }
        
        /// <summary><b>[entry point: <c>alEffectfv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, void> _alEffectfv_fnptr = &alEffectfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alEffectfv_Lazy(uint effect, int param, float* pflValues)
        {
            _alEffectfv_fnptr = (delegate* unmanaged<uint, int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alEffectfv");
            _alEffectfv_fnptr(effect, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alEffecti</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int, void> _alEffecti_fnptr = &alEffecti_Lazy;
        [UnmanagedCallersOnly]
        private static void alEffecti_Lazy(uint effect, int param, int iValue)
        {
            _alEffecti_fnptr = (delegate* unmanaged<uint, int, int, void>)ALLoader.BindingsContext.GetProcAddress("alEffecti");
            _alEffecti_fnptr(effect, param, iValue);
        }
        
        /// <summary><b>[entry point: <c>alEffectiv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, void> _alEffectiv_fnptr = &alEffectiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alEffectiv_Lazy(uint effect, int param, int* piValues)
        {
            _alEffectiv_fnptr = (delegate* unmanaged<uint, int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alEffectiv");
            _alEffectiv_fnptr(effect, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alEnable</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alEnable_fnptr = &alEnable_Lazy;
        [UnmanagedCallersOnly]
        private static void alEnable_Lazy(int capability)
        {
            _alEnable_fnptr = (delegate* unmanaged<int, void>)ALLoader.BindingsContext.GetProcAddress("alEnable");
            _alEnable_fnptr(capability);
        }
        
        /// <summary><b>[entry point: <c>alEventCallbackSOFT</c>]</b></summary>
        public static delegate* unmanaged<delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void>, void*, void> _alEventCallbackSOFT_fnptr = &alEventCallbackSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alEventCallbackSOFT_Lazy(delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, void* userParam)
        {
            _alEventCallbackSOFT_fnptr = (delegate* unmanaged<delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void>, void*, void>)ALLoader.BindingsContext.GetProcAddress("alEventCallbackSOFT");
            _alEventCallbackSOFT_fnptr(callback, userParam);
        }
        
        /// <summary><b>[entry point: <c>alEventControlSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int*, byte, void> _alEventControlSOFT_fnptr = &alEventControlSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alEventControlSOFT_Lazy(int count, int* types, byte enable)
        {
            _alEventControlSOFT_fnptr = (delegate* unmanaged<int, int*, byte, void>)ALLoader.BindingsContext.GetProcAddress("alEventControlSOFT");
            _alEventControlSOFT_fnptr(count, types, enable);
        }
        
        /// <summary><b>[entry point: <c>alFilterf</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float, void> _alFilterf_fnptr = &alFilterf_Lazy;
        [UnmanagedCallersOnly]
        private static void alFilterf_Lazy(uint filter, int param, float flValue)
        {
            _alFilterf_fnptr = (delegate* unmanaged<uint, int, float, void>)ALLoader.BindingsContext.GetProcAddress("alFilterf");
            _alFilterf_fnptr(filter, param, flValue);
        }
        
        /// <summary><b>[entry point: <c>alFilterfv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, void> _alFilterfv_fnptr = &alFilterfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alFilterfv_Lazy(uint filter, int param, float* pflValues)
        {
            _alFilterfv_fnptr = (delegate* unmanaged<uint, int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alFilterfv");
            _alFilterfv_fnptr(filter, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alFilteri</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int, void> _alFilteri_fnptr = &alFilteri_Lazy;
        [UnmanagedCallersOnly]
        private static void alFilteri_Lazy(uint filter, int param, int iValue)
        {
            _alFilteri_fnptr = (delegate* unmanaged<uint, int, int, void>)ALLoader.BindingsContext.GetProcAddress("alFilteri");
            _alFilteri_fnptr(filter, param, iValue);
        }
        
        /// <summary><b>[entry point: <c>alFilteriv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, void> _alFilteriv_fnptr = &alFilteriv_Lazy;
        [UnmanagedCallersOnly]
        private static void alFilteriv_Lazy(uint filter, int param, int* piValues)
        {
            _alFilteriv_fnptr = (delegate* unmanaged<uint, int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alFilteriv");
            _alFilteriv_fnptr(filter, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alGenAuxiliaryEffectSlots</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, void> _alGenAuxiliaryEffectSlots_fnptr = &alGenAuxiliaryEffectSlots_Lazy;
        [UnmanagedCallersOnly]
        private static void alGenAuxiliaryEffectSlots_Lazy(int n, uint* effectslots)
        {
            _alGenAuxiliaryEffectSlots_fnptr = (delegate* unmanaged<int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alGenAuxiliaryEffectSlots");
            _alGenAuxiliaryEffectSlots_fnptr(n, effectslots);
        }
        
        /// <summary><b>[entry point: <c>alGenBuffers</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, void> _alGenBuffers_fnptr = &alGenBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static void alGenBuffers_Lazy(int n, uint* buffers)
        {
            _alGenBuffers_fnptr = (delegate* unmanaged<int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alGenBuffers");
            _alGenBuffers_fnptr(n, buffers);
        }
        
        /// <summary><b>[entry point: <c>alGenEffects</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, void> _alGenEffects_fnptr = &alGenEffects_Lazy;
        [UnmanagedCallersOnly]
        private static void alGenEffects_Lazy(int n, uint* effects)
        {
            _alGenEffects_fnptr = (delegate* unmanaged<int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alGenEffects");
            _alGenEffects_fnptr(n, effects);
        }
        
        /// <summary><b>[entry point: <c>alGenFilters</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, void> _alGenFilters_fnptr = &alGenFilters_Lazy;
        [UnmanagedCallersOnly]
        private static void alGenFilters_Lazy(int n, uint* filters)
        {
            _alGenFilters_fnptr = (delegate* unmanaged<int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alGenFilters");
            _alGenFilters_fnptr(n, filters);
        }
        
        /// <summary><b>[entry point: <c>alGenSources</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, void> _alGenSources_fnptr = &alGenSources_Lazy;
        [UnmanagedCallersOnly]
        private static void alGenSources_Lazy(int n, uint* sources)
        {
            _alGenSources_fnptr = (delegate* unmanaged<int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alGenSources");
            _alGenSources_fnptr(n, sources);
        }
        
        /// <summary><b>[entry point: <c>alGetAuxiliaryEffectSlotf</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, void> _alGetAuxiliaryEffectSlotf_fnptr = &alGetAuxiliaryEffectSlotf_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetAuxiliaryEffectSlotf_Lazy(uint effectslot, int param, float* pflValue)
        {
            _alGetAuxiliaryEffectSlotf_fnptr = (delegate* unmanaged<uint, int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetAuxiliaryEffectSlotf");
            _alGetAuxiliaryEffectSlotf_fnptr(effectslot, param, pflValue);
        }
        
        /// <summary><b>[entry point: <c>alGetAuxiliaryEffectSlotfv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, void> _alGetAuxiliaryEffectSlotfv_fnptr = &alGetAuxiliaryEffectSlotfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetAuxiliaryEffectSlotfv_Lazy(uint effectslot, int param, float* pflValues)
        {
            _alGetAuxiliaryEffectSlotfv_fnptr = (delegate* unmanaged<uint, int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetAuxiliaryEffectSlotfv");
            _alGetAuxiliaryEffectSlotfv_fnptr(effectslot, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alGetAuxiliaryEffectSloti</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, void> _alGetAuxiliaryEffectSloti_fnptr = &alGetAuxiliaryEffectSloti_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetAuxiliaryEffectSloti_Lazy(uint effectslot, int param, int* piValue)
        {
            _alGetAuxiliaryEffectSloti_fnptr = (delegate* unmanaged<uint, int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetAuxiliaryEffectSloti");
            _alGetAuxiliaryEffectSloti_fnptr(effectslot, param, piValue);
        }
        
        /// <summary><b>[entry point: <c>alGetAuxiliaryEffectSlotiv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, void> _alGetAuxiliaryEffectSlotiv_fnptr = &alGetAuxiliaryEffectSlotiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetAuxiliaryEffectSlotiv_Lazy(uint effectslot, int param, int* piValues)
        {
            _alGetAuxiliaryEffectSlotiv_fnptr = (delegate* unmanaged<uint, int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetAuxiliaryEffectSlotiv");
            _alGetAuxiliaryEffectSlotiv_fnptr(effectslot, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alGetBoolean</c>]</b></summary>
        public static delegate* unmanaged<int, byte> _alGetBoolean_fnptr = &alGetBoolean_Lazy;
        [UnmanagedCallersOnly]
        private static byte alGetBoolean_Lazy(int param)
        {
            _alGetBoolean_fnptr = (delegate* unmanaged<int, byte>)ALLoader.BindingsContext.GetProcAddress("alGetBoolean");
            return _alGetBoolean_fnptr(param);
        }
        
        /// <summary><b>[entry point: <c>alGetBooleanv</c>]</b></summary>
        public static delegate* unmanaged<int, byte*, void> _alGetBooleanv_fnptr = &alGetBooleanv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBooleanv_Lazy(int param, byte* values)
        {
            _alGetBooleanv_fnptr = (delegate* unmanaged<int, byte*, void>)ALLoader.BindingsContext.GetProcAddress("alGetBooleanv");
            _alGetBooleanv_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetBuffer3f</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, float*, float*, void> _alGetBuffer3f_fnptr = &alGetBuffer3f_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBuffer3f_Lazy(uint buffer, int param, float* value1, float* value2, float* value3)
        {
            _alGetBuffer3f_fnptr = (delegate* unmanaged<uint, int, float*, float*, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetBuffer3f");
            _alGetBuffer3f_fnptr(buffer, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetBuffer3i</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, int*, int*, void> _alGetBuffer3i_fnptr = &alGetBuffer3i_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBuffer3i_Lazy(uint buffer, int param, int* value1, int* value2, int* value3)
        {
            _alGetBuffer3i_fnptr = (delegate* unmanaged<uint, int, int*, int*, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetBuffer3i");
            _alGetBuffer3i_fnptr(buffer, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetBuffer3PtrSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, void**, void**, void**, void> _alGetBuffer3PtrSOFT_fnptr = &alGetBuffer3PtrSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBuffer3PtrSOFT_Lazy(uint buffer, int param, void** ptr0, void** ptr1, void** ptr2)
        {
            _alGetBuffer3PtrSOFT_fnptr = (delegate* unmanaged<uint, int, void**, void**, void**, void>)ALLoader.BindingsContext.GetProcAddress("alGetBuffer3PtrSOFT");
            _alGetBuffer3PtrSOFT_fnptr(buffer, param, ptr0, ptr1, ptr2);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferf</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, void> _alGetBufferf_fnptr = &alGetBufferf_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferf_Lazy(uint buffer, int param, float* value)
        {
            _alGetBufferf_fnptr = (delegate* unmanaged<uint, int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetBufferf");
            _alGetBufferf_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferfv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, void> _alGetBufferfv_fnptr = &alGetBufferfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferfv_Lazy(uint buffer, int param, float* value)
        {
            _alGetBufferfv_fnptr = (delegate* unmanaged<uint, int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetBufferfv");
            _alGetBufferfv_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferi</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, void> _alGetBufferi_fnptr = &alGetBufferi_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferi_Lazy(uint buffer, int param, int* value)
        {
            _alGetBufferi_fnptr = (delegate* unmanaged<uint, int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetBufferi");
            _alGetBufferi_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferiv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, void> _alGetBufferiv_fnptr = &alGetBufferiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferiv_Lazy(uint buffer, int param, int* value)
        {
            _alGetBufferiv_fnptr = (delegate* unmanaged<uint, int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetBufferiv");
            _alGetBufferiv_fnptr(buffer, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferPtrSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, void**, void> _alGetBufferPtrSOFT_fnptr = &alGetBufferPtrSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferPtrSOFT_Lazy(uint buffer, int param, void** ptr)
        {
            _alGetBufferPtrSOFT_fnptr = (delegate* unmanaged<uint, int, void**, void>)ALLoader.BindingsContext.GetProcAddress("alGetBufferPtrSOFT");
            _alGetBufferPtrSOFT_fnptr(buffer, param, ptr);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferPtrvSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, void**, void> _alGetBufferPtrvSOFT_fnptr = &alGetBufferPtrvSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferPtrvSOFT_Lazy(uint buffer, int param, void** ptr)
        {
            _alGetBufferPtrvSOFT_fnptr = (delegate* unmanaged<uint, int, void**, void>)ALLoader.BindingsContext.GetProcAddress("alGetBufferPtrvSOFT");
            _alGetBufferPtrvSOFT_fnptr(buffer, param, ptr);
        }
        
        /// <summary><b>[entry point: <c>alGetBufferSamplesSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int, int, int, void*, void> _alGetBufferSamplesSOFT_fnptr = &alGetBufferSamplesSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetBufferSamplesSOFT_Lazy(uint buffer, int offset, int samples, int channels, int type, void* data)
        {
            _alGetBufferSamplesSOFT_fnptr = (delegate* unmanaged<uint, int, int, int, int, void*, void>)ALLoader.BindingsContext.GetProcAddress("alGetBufferSamplesSOFT");
            _alGetBufferSamplesSOFT_fnptr(buffer, offset, samples, channels, type, data);
        }
        
        /// <summary><b>[entry point: <c>alGetDebugMessageLogEXT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, int*, uint*, int*, int*, byte*, uint> _alGetDebugMessageLogEXT_fnptr = &alGetDebugMessageLogEXT_Lazy;
        [UnmanagedCallersOnly]
        private static uint alGetDebugMessageLogEXT_Lazy(uint count, int logBufSize, int* sources, int* types, uint* ids, int* severities, int* lengths, byte* logBuf)
        {
            _alGetDebugMessageLogEXT_fnptr = (delegate* unmanaged<uint, int, int*, int*, uint*, int*, int*, byte*, uint>)ALLoader.BindingsContext.GetProcAddress("alGetDebugMessageLogEXT");
            return _alGetDebugMessageLogEXT_fnptr(count, logBufSize, sources, types, ids, severities, lengths, logBuf);
        }
        
        /// <summary><b>[entry point: <c>alGetDouble</c>]</b></summary>
        public static delegate* unmanaged<int, double> _alGetDouble_fnptr = &alGetDouble_Lazy;
        [UnmanagedCallersOnly]
        private static double alGetDouble_Lazy(int param)
        {
            _alGetDouble_fnptr = (delegate* unmanaged<int, double>)ALLoader.BindingsContext.GetProcAddress("alGetDouble");
            return _alGetDouble_fnptr(param);
        }
        
        /// <summary><b>[entry point: <c>alGetDoublev</c>]</b></summary>
        public static delegate* unmanaged<int, double*, void> _alGetDoublev_fnptr = &alGetDoublev_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetDoublev_Lazy(int param, double* values)
        {
            _alGetDoublev_fnptr = (delegate* unmanaged<int, double*, void>)ALLoader.BindingsContext.GetProcAddress("alGetDoublev");
            _alGetDoublev_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetEffectf</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, void> _alGetEffectf_fnptr = &alGetEffectf_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetEffectf_Lazy(uint effect, int param, float* pflValue)
        {
            _alGetEffectf_fnptr = (delegate* unmanaged<uint, int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetEffectf");
            _alGetEffectf_fnptr(effect, param, pflValue);
        }
        
        /// <summary><b>[entry point: <c>alGetEffectfv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, void> _alGetEffectfv_fnptr = &alGetEffectfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetEffectfv_Lazy(uint effect, int param, float* pflValues)
        {
            _alGetEffectfv_fnptr = (delegate* unmanaged<uint, int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetEffectfv");
            _alGetEffectfv_fnptr(effect, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alGetEffecti</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, void> _alGetEffecti_fnptr = &alGetEffecti_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetEffecti_Lazy(uint effect, int param, int* piValue)
        {
            _alGetEffecti_fnptr = (delegate* unmanaged<uint, int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetEffecti");
            _alGetEffecti_fnptr(effect, param, piValue);
        }
        
        /// <summary><b>[entry point: <c>alGetEffectiv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, void> _alGetEffectiv_fnptr = &alGetEffectiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetEffectiv_Lazy(uint effect, int param, int* piValues)
        {
            _alGetEffectiv_fnptr = (delegate* unmanaged<uint, int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetEffectiv");
            _alGetEffectiv_fnptr(effect, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alGetEnumValue</c>]</b></summary>
        public static delegate* unmanaged<byte*, int> _alGetEnumValue_fnptr = &alGetEnumValue_Lazy;
        [UnmanagedCallersOnly]
        private static int alGetEnumValue_Lazy(byte* ename)
        {
            _alGetEnumValue_fnptr = (delegate* unmanaged<byte*, int>)ALLoader.BindingsContext.GetProcAddress("alGetEnumValue");
            return _alGetEnumValue_fnptr(ename);
        }
        
        /// <summary><b>[entry point: <c>alGetError</c>]</b></summary>
        public static delegate* unmanaged<int> _alGetError_fnptr = &alGetError_Lazy;
        [UnmanagedCallersOnly]
        private static int alGetError_Lazy()
        {
            _alGetError_fnptr = (delegate* unmanaged<int>)ALLoader.BindingsContext.GetProcAddress("alGetError");
            return _alGetError_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alGetFilterf</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, void> _alGetFilterf_fnptr = &alGetFilterf_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetFilterf_Lazy(uint filter, int param, float* pflValue)
        {
            _alGetFilterf_fnptr = (delegate* unmanaged<uint, int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetFilterf");
            _alGetFilterf_fnptr(filter, param, pflValue);
        }
        
        /// <summary><b>[entry point: <c>alGetFilterfv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, void> _alGetFilterfv_fnptr = &alGetFilterfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetFilterfv_Lazy(uint filter, int param, float* pflValues)
        {
            _alGetFilterfv_fnptr = (delegate* unmanaged<uint, int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetFilterfv");
            _alGetFilterfv_fnptr(filter, param, pflValues);
        }
        
        /// <summary><b>[entry point: <c>alGetFilteri</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, void> _alGetFilteri_fnptr = &alGetFilteri_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetFilteri_Lazy(uint filter, int param, int* piValue)
        {
            _alGetFilteri_fnptr = (delegate* unmanaged<uint, int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetFilteri");
            _alGetFilteri_fnptr(filter, param, piValue);
        }
        
        /// <summary><b>[entry point: <c>alGetFilteriv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, void> _alGetFilteriv_fnptr = &alGetFilteriv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetFilteriv_Lazy(uint filter, int param, int* piValues)
        {
            _alGetFilteriv_fnptr = (delegate* unmanaged<uint, int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetFilteriv");
            _alGetFilteriv_fnptr(filter, param, piValues);
        }
        
        /// <summary><b>[entry point: <c>alGetFloat</c>]</b></summary>
        public static delegate* unmanaged<int, float> _alGetFloat_fnptr = &alGetFloat_Lazy;
        [UnmanagedCallersOnly]
        private static float alGetFloat_Lazy(int param)
        {
            _alGetFloat_fnptr = (delegate* unmanaged<int, float>)ALLoader.BindingsContext.GetProcAddress("alGetFloat");
            return _alGetFloat_fnptr(param);
        }
        
        /// <summary><b>[entry point: <c>alGetFloatv</c>]</b></summary>
        public static delegate* unmanaged<int, float*, void> _alGetFloatv_fnptr = &alGetFloatv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetFloatv_Lazy(int param, float* values)
        {
            _alGetFloatv_fnptr = (delegate* unmanaged<int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetFloatv");
            _alGetFloatv_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetInteger</c>]</b></summary>
        public static delegate* unmanaged<int, int> _alGetInteger_fnptr = &alGetInteger_Lazy;
        [UnmanagedCallersOnly]
        private static int alGetInteger_Lazy(int param)
        {
            _alGetInteger_fnptr = (delegate* unmanaged<int, int>)ALLoader.BindingsContext.GetProcAddress("alGetInteger");
            return _alGetInteger_fnptr(param);
        }
        
        /// <summary><b>[entry point: <c>alGetIntegerv</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alGetIntegerv_fnptr = &alGetIntegerv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetIntegerv_Lazy(int param, int* values)
        {
            _alGetIntegerv_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetIntegerv");
            _alGetIntegerv_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetListener3f</c>]</b></summary>
        public static delegate* unmanaged<int, float*, float*, float*, void> _alGetListener3f_fnptr = &alGetListener3f_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListener3f_Lazy(int param, float* value1, float* value2, float* value3)
        {
            _alGetListener3f_fnptr = (delegate* unmanaged<int, float*, float*, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetListener3f");
            _alGetListener3f_fnptr(param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetListener3i</c>]</b></summary>
        public static delegate* unmanaged<int, int*, int*, int*, void> _alGetListener3i_fnptr = &alGetListener3i_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListener3i_Lazy(int param, int* value1, int* value2, int* value3)
        {
            _alGetListener3i_fnptr = (delegate* unmanaged<int, int*, int*, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetListener3i");
            _alGetListener3i_fnptr(param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetListenerf</c>]</b></summary>
        public static delegate* unmanaged<int, float*, void> _alGetListenerf_fnptr = &alGetListenerf_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListenerf_Lazy(int param, float* value)
        {
            _alGetListenerf_fnptr = (delegate* unmanaged<int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetListenerf");
            _alGetListenerf_fnptr(param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetListenerfv</c>]</b></summary>
        public static delegate* unmanaged<int, float*, void> _alGetListenerfv_fnptr = &alGetListenerfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListenerfv_Lazy(int param, float* values)
        {
            _alGetListenerfv_fnptr = (delegate* unmanaged<int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetListenerfv");
            _alGetListenerfv_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetListeneri</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alGetListeneri_fnptr = &alGetListeneri_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListeneri_Lazy(int param, int* value)
        {
            _alGetListeneri_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetListeneri");
            _alGetListeneri_fnptr(param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetListeneriv</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alGetListeneriv_fnptr = &alGetListeneriv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetListeneriv_Lazy(int param, int* values)
        {
            _alGetListeneriv_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetListeneriv");
            _alGetListeneriv_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetObjectLabelEXT</c>]</b></summary>
        public static delegate* unmanaged<int, uint, int, int*, byte*, void> _alGetObjectLabelEXT_fnptr = &alGetObjectLabelEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetObjectLabelEXT_Lazy(int identifier, uint name, int bufSize, int* length, byte* label)
        {
            _alGetObjectLabelEXT_fnptr = (delegate* unmanaged<int, uint, int, int*, byte*, void>)ALLoader.BindingsContext.GetProcAddress("alGetObjectLabelEXT");
            _alGetObjectLabelEXT_fnptr(identifier, name, bufSize, length, label);
        }
        
        /// <summary><b>[entry point: <c>alGetPointerEXT</c>]</b></summary>
        public static delegate* unmanaged<int, void*> _alGetPointerEXT_fnptr = &alGetPointerEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void* alGetPointerEXT_Lazy(int pname)
        {
            _alGetPointerEXT_fnptr = (delegate* unmanaged<int, void*>)ALLoader.BindingsContext.GetProcAddress("alGetPointerEXT");
            return _alGetPointerEXT_fnptr(pname);
        }
        
        /// <summary><b>[entry point: <c>alGetPointerSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, void*> _alGetPointerSOFT_fnptr = &alGetPointerSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void* alGetPointerSOFT_Lazy(int pname)
        {
            _alGetPointerSOFT_fnptr = (delegate* unmanaged<int, void*>)ALLoader.BindingsContext.GetProcAddress("alGetPointerSOFT");
            return _alGetPointerSOFT_fnptr(pname);
        }
        
        /// <summary><b>[entry point: <c>alGetPointervEXT</c>]</b></summary>
        public static delegate* unmanaged<int, void**, void> _alGetPointervEXT_fnptr = &alGetPointervEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetPointervEXT_Lazy(int pname, void** values)
        {
            _alGetPointervEXT_fnptr = (delegate* unmanaged<int, void**, void>)ALLoader.BindingsContext.GetProcAddress("alGetPointervEXT");
            _alGetPointervEXT_fnptr(pname, values);
        }
        
        /// <summary><b>[entry point: <c>alGetPointervSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, void**, void> _alGetPointervSOFT_fnptr = &alGetPointervSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetPointervSOFT_Lazy(int pname, void** values)
        {
            _alGetPointervSOFT_fnptr = (delegate* unmanaged<int, void**, void>)ALLoader.BindingsContext.GetProcAddress("alGetPointervSOFT");
            _alGetPointervSOFT_fnptr(pname, values);
        }
        
        /// <summary><b>[entry point: <c>alGetProcAddress</c>]</b></summary>
        public static delegate* unmanaged<byte*, void*> _alGetProcAddress_fnptr = &alGetProcAddress_Lazy;
        [UnmanagedCallersOnly]
        private static void* alGetProcAddress_Lazy(byte* fname)
        {
            _alGetProcAddress_fnptr = (delegate* unmanaged<byte*, void*>)ALLoader.BindingsContext.GetProcAddress("alGetProcAddress");
            return _alGetProcAddress_fnptr(fname);
        }
        
        /// <summary><b>[entry point: <c>alGetSource3dSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, double*, double*, double*, void> _alGetSource3dSOFT_fnptr = &alGetSource3dSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSource3dSOFT_Lazy(uint source, int param, double* value1, double* value2, double* value3)
        {
            _alGetSource3dSOFT_fnptr = (delegate* unmanaged<uint, int, double*, double*, double*, void>)ALLoader.BindingsContext.GetProcAddress("alGetSource3dSOFT");
            _alGetSource3dSOFT_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetSource3f</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, float*, float*, void> _alGetSource3f_fnptr = &alGetSource3f_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSource3f_Lazy(uint source, int param, float* value1, float* value2, float* value3)
        {
            _alGetSource3f_fnptr = (delegate* unmanaged<uint, int, float*, float*, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetSource3f");
            _alGetSource3f_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetSource3i</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, int*, int*, void> _alGetSource3i_fnptr = &alGetSource3i_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSource3i_Lazy(uint source, int param, int* value1, int* value2, int* value3)
        {
            _alGetSource3i_fnptr = (delegate* unmanaged<uint, int, int*, int*, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetSource3i");
            _alGetSource3i_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetSource3i64SOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, long*, long*, long*, void> _alGetSource3i64SOFT_fnptr = &alGetSource3i64SOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSource3i64SOFT_Lazy(uint source, int param, long* value1, long* value2, long* value3)
        {
            _alGetSource3i64SOFT_fnptr = (delegate* unmanaged<uint, int, long*, long*, long*, void>)ALLoader.BindingsContext.GetProcAddress("alGetSource3i64SOFT");
            _alGetSource3i64SOFT_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcedSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, double*, void> _alGetSourcedSOFT_fnptr = &alGetSourcedSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcedSOFT_Lazy(uint source, int param, double* value)
        {
            _alGetSourcedSOFT_fnptr = (delegate* unmanaged<uint, int, double*, void>)ALLoader.BindingsContext.GetProcAddress("alGetSourcedSOFT");
            _alGetSourcedSOFT_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcedvSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, double*, void> _alGetSourcedvSOFT_fnptr = &alGetSourcedvSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcedvSOFT_Lazy(uint source, int param, double* values)
        {
            _alGetSourcedvSOFT_fnptr = (delegate* unmanaged<uint, int, double*, void>)ALLoader.BindingsContext.GetProcAddress("alGetSourcedvSOFT");
            _alGetSourcedvSOFT_fnptr(source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcef</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, void> _alGetSourcef_fnptr = &alGetSourcef_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcef_Lazy(uint source, int param, float* value)
        {
            _alGetSourcef_fnptr = (delegate* unmanaged<uint, int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetSourcef");
            _alGetSourcef_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcefv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, void> _alGetSourcefv_fnptr = &alGetSourcefv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcefv_Lazy(uint source, int param, float* values)
        {
            _alGetSourcefv_fnptr = (delegate* unmanaged<uint, int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alGetSourcefv");
            _alGetSourcefv_fnptr(source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcei</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, void> _alGetSourcei_fnptr = &alGetSourcei_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcei_Lazy(uint source, int param, int* value)
        {
            _alGetSourcei_fnptr = (delegate* unmanaged<uint, int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetSourcei");
            _alGetSourcei_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcei64SOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, long*, void> _alGetSourcei64SOFT_fnptr = &alGetSourcei64SOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcei64SOFT_Lazy(uint source, int param, long* value)
        {
            _alGetSourcei64SOFT_fnptr = (delegate* unmanaged<uint, int, long*, void>)ALLoader.BindingsContext.GetProcAddress("alGetSourcei64SOFT");
            _alGetSourcei64SOFT_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alGetSourcei64vSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, long*, void> _alGetSourcei64vSOFT_fnptr = &alGetSourcei64vSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourcei64vSOFT_Lazy(uint source, int param, long* values)
        {
            _alGetSourcei64vSOFT_fnptr = (delegate* unmanaged<uint, int, long*, void>)ALLoader.BindingsContext.GetProcAddress("alGetSourcei64vSOFT");
            _alGetSourcei64vSOFT_fnptr(source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetSourceiv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, void> _alGetSourceiv_fnptr = &alGetSourceiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alGetSourceiv_Lazy(uint source, int param, int* values)
        {
            _alGetSourceiv_fnptr = (delegate* unmanaged<uint, int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alGetSourceiv");
            _alGetSourceiv_fnptr(source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alGetString</c>]</b></summary>
        public static delegate* unmanaged<int, byte*> _alGetString_fnptr = &alGetString_Lazy;
        [UnmanagedCallersOnly]
        private static byte* alGetString_Lazy(int param)
        {
            _alGetString_fnptr = (delegate* unmanaged<int, byte*>)ALLoader.BindingsContext.GetProcAddress("alGetString");
            return _alGetString_fnptr(param);
        }
        
        /// <summary><b>[entry point: <c>alGetStringiSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, byte*> _alGetStringiSOFT_fnptr = &alGetStringiSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static byte* alGetStringiSOFT_Lazy(int pname, int index)
        {
            _alGetStringiSOFT_fnptr = (delegate* unmanaged<int, int, byte*>)ALLoader.BindingsContext.GetProcAddress("alGetStringiSOFT");
            return _alGetStringiSOFT_fnptr(pname, index);
        }
        
        /// <summary><b>[entry point: <c>alIsAuxiliaryEffectSlot</c>]</b></summary>
        public static delegate* unmanaged<uint, void> _alIsAuxiliaryEffectSlot_fnptr = &alIsAuxiliaryEffectSlot_Lazy;
        [UnmanagedCallersOnly]
        private static void alIsAuxiliaryEffectSlot_Lazy(uint effectslot)
        {
            _alIsAuxiliaryEffectSlot_fnptr = (delegate* unmanaged<uint, void>)ALLoader.BindingsContext.GetProcAddress("alIsAuxiliaryEffectSlot");
            _alIsAuxiliaryEffectSlot_fnptr(effectslot);
        }
        
        /// <summary><b>[entry point: <c>alIsBuffer</c>]</b></summary>
        public static delegate* unmanaged<uint, byte> _alIsBuffer_fnptr = &alIsBuffer_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsBuffer_Lazy(uint buffer)
        {
            _alIsBuffer_fnptr = (delegate* unmanaged<uint, byte>)ALLoader.BindingsContext.GetProcAddress("alIsBuffer");
            return _alIsBuffer_fnptr(buffer);
        }
        
        /// <summary><b>[entry point: <c>alIsBufferFormatSupportedSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, byte> _alIsBufferFormatSupportedSOFT_fnptr = &alIsBufferFormatSupportedSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsBufferFormatSupportedSOFT_Lazy(int format)
        {
            _alIsBufferFormatSupportedSOFT_fnptr = (delegate* unmanaged<int, byte>)ALLoader.BindingsContext.GetProcAddress("alIsBufferFormatSupportedSOFT");
            return _alIsBufferFormatSupportedSOFT_fnptr(format);
        }
        
        /// <summary><b>[entry point: <c>alIsEffect</c>]</b></summary>
        public static delegate* unmanaged<uint, byte> _alIsEffect_fnptr = &alIsEffect_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsEffect_Lazy(uint effect)
        {
            _alIsEffect_fnptr = (delegate* unmanaged<uint, byte>)ALLoader.BindingsContext.GetProcAddress("alIsEffect");
            return _alIsEffect_fnptr(effect);
        }
        
        /// <summary><b>[entry point: <c>alIsEnabled</c>]</b></summary>
        public static delegate* unmanaged<int, byte> _alIsEnabled_fnptr = &alIsEnabled_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsEnabled_Lazy(int capability)
        {
            _alIsEnabled_fnptr = (delegate* unmanaged<int, byte>)ALLoader.BindingsContext.GetProcAddress("alIsEnabled");
            return _alIsEnabled_fnptr(capability);
        }
        
        /// <summary><b>[entry point: <c>alIsExtensionPresent</c>]</b></summary>
        public static delegate* unmanaged<byte*, byte> _alIsExtensionPresent_fnptr = &alIsExtensionPresent_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsExtensionPresent_Lazy(byte* extname)
        {
            _alIsExtensionPresent_fnptr = (delegate* unmanaged<byte*, byte>)ALLoader.BindingsContext.GetProcAddress("alIsExtensionPresent");
            return _alIsExtensionPresent_fnptr(extname);
        }
        
        /// <summary><b>[entry point: <c>alIsFilter</c>]</b></summary>
        public static delegate* unmanaged<uint, void> _alIsFilter_fnptr = &alIsFilter_Lazy;
        [UnmanagedCallersOnly]
        private static void alIsFilter_Lazy(uint filter)
        {
            _alIsFilter_fnptr = (delegate* unmanaged<uint, void>)ALLoader.BindingsContext.GetProcAddress("alIsFilter");
            _alIsFilter_fnptr(filter);
        }
        
        /// <summary><b>[entry point: <c>alIsSource</c>]</b></summary>
        public static delegate* unmanaged<uint, byte> _alIsSource_fnptr = &alIsSource_Lazy;
        [UnmanagedCallersOnly]
        private static byte alIsSource_Lazy(uint source)
        {
            _alIsSource_fnptr = (delegate* unmanaged<uint, byte>)ALLoader.BindingsContext.GetProcAddress("alIsSource");
            return _alIsSource_fnptr(source);
        }
        
        /// <summary><b>[entry point: <c>alListener3f</c>]</b></summary>
        public static delegate* unmanaged<int, float, float, float, void> _alListener3f_fnptr = &alListener3f_Lazy;
        [UnmanagedCallersOnly]
        private static void alListener3f_Lazy(int param, float value1, float value2, float value3)
        {
            _alListener3f_fnptr = (delegate* unmanaged<int, float, float, float, void>)ALLoader.BindingsContext.GetProcAddress("alListener3f");
            _alListener3f_fnptr(param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alListener3i</c>]</b></summary>
        public static delegate* unmanaged<int, int, int, int, void> _alListener3i_fnptr = &alListener3i_Lazy;
        [UnmanagedCallersOnly]
        private static void alListener3i_Lazy(int param, int value1, int value2, int value3)
        {
            _alListener3i_fnptr = (delegate* unmanaged<int, int, int, int, void>)ALLoader.BindingsContext.GetProcAddress("alListener3i");
            _alListener3i_fnptr(param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alListenerf</c>]</b></summary>
        public static delegate* unmanaged<int, float, void> _alListenerf_fnptr = &alListenerf_Lazy;
        [UnmanagedCallersOnly]
        private static void alListenerf_Lazy(int param, float value)
        {
            _alListenerf_fnptr = (delegate* unmanaged<int, float, void>)ALLoader.BindingsContext.GetProcAddress("alListenerf");
            _alListenerf_fnptr(param, value);
        }
        
        /// <summary><b>[entry point: <c>alListenerfv</c>]</b></summary>
        public static delegate* unmanaged<int, float*, void> _alListenerfv_fnptr = &alListenerfv_Lazy;
        [UnmanagedCallersOnly]
        private static void alListenerfv_Lazy(int param, float* values)
        {
            _alListenerfv_fnptr = (delegate* unmanaged<int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alListenerfv");
            _alListenerfv_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alListeneri</c>]</b></summary>
        public static delegate* unmanaged<int, int, void> _alListeneri_fnptr = &alListeneri_Lazy;
        [UnmanagedCallersOnly]
        private static void alListeneri_Lazy(int param, int value)
        {
            _alListeneri_fnptr = (delegate* unmanaged<int, int, void>)ALLoader.BindingsContext.GetProcAddress("alListeneri");
            _alListeneri_fnptr(param, value);
        }
        
        /// <summary><b>[entry point: <c>alListeneriv</c>]</b></summary>
        public static delegate* unmanaged<int, int*, void> _alListeneriv_fnptr = &alListeneriv_Lazy;
        [UnmanagedCallersOnly]
        private static void alListeneriv_Lazy(int param, int* values)
        {
            _alListeneriv_fnptr = (delegate* unmanaged<int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alListeneriv");
            _alListeneriv_fnptr(param, values);
        }
        
        /// <summary><b>[entry point: <c>alMacOSXGetRenderChannelCount</c>]</b></summary>
        public static delegate* unmanaged<int> _alMacOSXGetRenderChannelCount_fnptr = &alMacOSXGetRenderChannelCount_Lazy;
        [UnmanagedCallersOnly]
        private static int alMacOSXGetRenderChannelCount_Lazy()
        {
            _alMacOSXGetRenderChannelCount_fnptr = (delegate* unmanaged<int>)ALLoader.BindingsContext.GetProcAddress("alMacOSXGetRenderChannelCount");
            return _alMacOSXGetRenderChannelCount_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alMacOSXRenderChannelCount</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alMacOSXRenderChannelCount_fnptr = &alMacOSXRenderChannelCount_Lazy;
        [UnmanagedCallersOnly]
        private static void alMacOSXRenderChannelCount_Lazy(int value)
        {
            _alMacOSXRenderChannelCount_fnptr = (delegate* unmanaged<int, void>)ALLoader.BindingsContext.GetProcAddress("alMacOSXRenderChannelCount");
            _alMacOSXRenderChannelCount_fnptr(value);
        }
        
        /// <summary><b>[entry point: <c>alObjectLabelEXT</c>]</b></summary>
        public static delegate* unmanaged<int, uint, int, byte*, void> _alObjectLabelEXT_fnptr = &alObjectLabelEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alObjectLabelEXT_Lazy(int identifier, uint name, int length, byte* label)
        {
            _alObjectLabelEXT_fnptr = (delegate* unmanaged<int, uint, int, byte*, void>)ALLoader.BindingsContext.GetProcAddress("alObjectLabelEXT");
            _alObjectLabelEXT_fnptr(identifier, name, length, label);
        }
        
        /// <summary><b>[entry point: <c>alPopDebugGroupEXT</c>]</b></summary>
        public static delegate* unmanaged<void> _alPopDebugGroupEXT_fnptr = &alPopDebugGroupEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alPopDebugGroupEXT_Lazy()
        {
            _alPopDebugGroupEXT_fnptr = (delegate* unmanaged<void>)ALLoader.BindingsContext.GetProcAddress("alPopDebugGroupEXT");
            _alPopDebugGroupEXT_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alProcessUpdatesSOFT</c>]</b></summary>
        public static delegate* unmanaged<void> _alProcessUpdatesSOFT_fnptr = &alProcessUpdatesSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alProcessUpdatesSOFT_Lazy()
        {
            _alProcessUpdatesSOFT_fnptr = (delegate* unmanaged<void>)ALLoader.BindingsContext.GetProcAddress("alProcessUpdatesSOFT");
            _alProcessUpdatesSOFT_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alPushDebugGroupEXT</c>]</b></summary>
        public static delegate* unmanaged<int, uint, int, byte*, void> _alPushDebugGroupEXT_fnptr = &alPushDebugGroupEXT_Lazy;
        [UnmanagedCallersOnly]
        private static void alPushDebugGroupEXT_Lazy(int source, uint id, int length, byte* message)
        {
            _alPushDebugGroupEXT_fnptr = (delegate* unmanaged<int, uint, int, byte*, void>)ALLoader.BindingsContext.GetProcAddress("alPushDebugGroupEXT");
            _alPushDebugGroupEXT_fnptr(source, id, length, message);
        }
        
        /// <summary><b>[entry point: <c>alRequestFoldbackStart</c>]</b></summary>
        public static delegate* unmanaged<int, int, int, float*, delegate* unmanaged[Cdecl]<All, nuint, void>, void> _alRequestFoldbackStart_fnptr = &alRequestFoldbackStart_Lazy;
        [UnmanagedCallersOnly]
        private static void alRequestFoldbackStart_Lazy(int foldbackMode, int blockCount, int blockLength, float* bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback)
        {
            _alRequestFoldbackStart_fnptr = (delegate* unmanaged<int, int, int, float*, delegate* unmanaged[Cdecl]<All, nuint, void>, void>)ALLoader.BindingsContext.GetProcAddress("alRequestFoldbackStart");
            _alRequestFoldbackStart_fnptr(foldbackMode, blockCount, blockLength, bufferMemory, callback);
        }
        
        /// <summary><b>[entry point: <c>alRequestFoldbackStop</c>]</b></summary>
        public static delegate* unmanaged<void> _alRequestFoldbackStop_fnptr = &alRequestFoldbackStop_Lazy;
        [UnmanagedCallersOnly]
        private static void alRequestFoldbackStop_Lazy()
        {
            _alRequestFoldbackStop_fnptr = (delegate* unmanaged<void>)ALLoader.BindingsContext.GetProcAddress("alRequestFoldbackStop");
            _alRequestFoldbackStop_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alSource3dSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, double, double, double, void> _alSource3dSOFT_fnptr = &alSource3dSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSource3dSOFT_Lazy(uint source, int param, double value1, double value2, double value3)
        {
            _alSource3dSOFT_fnptr = (delegate* unmanaged<uint, int, double, double, double, void>)ALLoader.BindingsContext.GetProcAddress("alSource3dSOFT");
            _alSource3dSOFT_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alSource3f</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float, float, float, void> _alSource3f_fnptr = &alSource3f_Lazy;
        [UnmanagedCallersOnly]
        private static void alSource3f_Lazy(uint source, int param, float value1, float value2, float value3)
        {
            _alSource3f_fnptr = (delegate* unmanaged<uint, int, float, float, float, void>)ALLoader.BindingsContext.GetProcAddress("alSource3f");
            _alSource3f_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alSource3i</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int, int, int, void> _alSource3i_fnptr = &alSource3i_Lazy;
        [UnmanagedCallersOnly]
        private static void alSource3i_Lazy(uint source, int param, int value1, int value2, int value3)
        {
            _alSource3i_fnptr = (delegate* unmanaged<uint, int, int, int, int, void>)ALLoader.BindingsContext.GetProcAddress("alSource3i");
            _alSource3i_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alSource3i64SOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, long, long, long, void> _alSource3i64SOFT_fnptr = &alSource3i64SOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSource3i64SOFT_Lazy(uint source, int param, long value1, long value2, long value3)
        {
            _alSource3i64SOFT_fnptr = (delegate* unmanaged<uint, int, long, long, long, void>)ALLoader.BindingsContext.GetProcAddress("alSource3i64SOFT");
            _alSource3i64SOFT_fnptr(source, param, value1, value2, value3);
        }
        
        /// <summary><b>[entry point: <c>alSourceAddNotification</c>]</b></summary>
        public static delegate* unmanaged<uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*, int> _alSourceAddNotification_fnptr = &alSourceAddNotification_Lazy;
        [UnmanagedCallersOnly]
        private static int alSourceAddNotification_Lazy(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, void* userData)
        {
            _alSourceAddNotification_fnptr = (delegate* unmanaged<uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*, int>)ALLoader.BindingsContext.GetProcAddress("alSourceAddNotification");
            return _alSourceAddNotification_fnptr(sid, notificationID, notifyProc, userData);
        }
        
        /// <summary><b>[entry point: <c>alSourcedSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, double, void> _alSourcedSOFT_fnptr = &alSourcedSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcedSOFT_Lazy(uint source, int param, double value)
        {
            _alSourcedSOFT_fnptr = (delegate* unmanaged<uint, int, double, void>)ALLoader.BindingsContext.GetProcAddress("alSourcedSOFT");
            _alSourcedSOFT_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourcedvSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, double*, void> _alSourcedvSOFT_fnptr = &alSourcedvSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcedvSOFT_Lazy(uint source, int param, double* values)
        {
            _alSourcedvSOFT_fnptr = (delegate* unmanaged<uint, int, double*, void>)ALLoader.BindingsContext.GetProcAddress("alSourcedvSOFT");
            _alSourcedvSOFT_fnptr(source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alSourcef</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float, void> _alSourcef_fnptr = &alSourcef_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcef_Lazy(uint source, int param, float value)
        {
            _alSourcef_fnptr = (delegate* unmanaged<uint, int, float, void>)ALLoader.BindingsContext.GetProcAddress("alSourcef");
            _alSourcef_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourcefv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, float*, void> _alSourcefv_fnptr = &alSourcefv_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcefv_Lazy(uint source, int param, float* value)
        {
            _alSourcefv_fnptr = (delegate* unmanaged<uint, int, float*, void>)ALLoader.BindingsContext.GetProcAddress("alSourcefv");
            _alSourcefv_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourceGetRenderingQuality</c>]</b></summary>
        public static delegate* unmanaged<uint, int> _alSourceGetRenderingQuality_fnptr = &alSourceGetRenderingQuality_Lazy;
        [UnmanagedCallersOnly]
        private static int alSourceGetRenderingQuality_Lazy(uint sid)
        {
            _alSourceGetRenderingQuality_fnptr = (delegate* unmanaged<uint, int>)ALLoader.BindingsContext.GetProcAddress("alSourceGetRenderingQuality");
            return _alSourceGetRenderingQuality_fnptr(sid);
        }
        
        /// <summary><b>[entry point: <c>alSourcei</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int, void> _alSourcei_fnptr = &alSourcei_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcei_Lazy(uint source, int param, int value)
        {
            _alSourcei_fnptr = (delegate* unmanaged<uint, int, int, void>)ALLoader.BindingsContext.GetProcAddress("alSourcei");
            _alSourcei_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourcei64SOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, long, void> _alSourcei64SOFT_fnptr = &alSourcei64SOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcei64SOFT_Lazy(uint source, int param, long value)
        {
            _alSourcei64SOFT_fnptr = (delegate* unmanaged<uint, int, long, void>)ALLoader.BindingsContext.GetProcAddress("alSourcei64SOFT");
            _alSourcei64SOFT_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourcei64vSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, int, long*, void> _alSourcei64vSOFT_fnptr = &alSourcei64vSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcei64vSOFT_Lazy(uint source, int param, long* values)
        {
            _alSourcei64vSOFT_fnptr = (delegate* unmanaged<uint, int, long*, void>)ALLoader.BindingsContext.GetProcAddress("alSourcei64vSOFT");
            _alSourcei64vSOFT_fnptr(source, param, values);
        }
        
        /// <summary><b>[entry point: <c>alSourceiv</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int*, void> _alSourceiv_fnptr = &alSourceiv_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceiv_Lazy(uint source, int param, int* value)
        {
            _alSourceiv_fnptr = (delegate* unmanaged<uint, int, int*, void>)ALLoader.BindingsContext.GetProcAddress("alSourceiv");
            _alSourceiv_fnptr(source, param, value);
        }
        
        /// <summary><b>[entry point: <c>alSourcePause</c>]</b></summary>
        public static delegate* unmanaged<uint, void> _alSourcePause_fnptr = &alSourcePause_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePause_Lazy(uint source)
        {
            _alSourcePause_fnptr = (delegate* unmanaged<uint, void>)ALLoader.BindingsContext.GetProcAddress("alSourcePause");
            _alSourcePause_fnptr(source);
        }
        
        /// <summary><b>[entry point: <c>alSourcePausev</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, void> _alSourcePausev_fnptr = &alSourcePausev_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePausev_Lazy(int n, uint* sources)
        {
            _alSourcePausev_fnptr = (delegate* unmanaged<int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alSourcePausev");
            _alSourcePausev_fnptr(n, sources);
        }
        
        /// <summary><b>[entry point: <c>alSourcePlay</c>]</b></summary>
        public static delegate* unmanaged<uint, void> _alSourcePlay_fnptr = &alSourcePlay_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePlay_Lazy(uint source)
        {
            _alSourcePlay_fnptr = (delegate* unmanaged<uint, void>)ALLoader.BindingsContext.GetProcAddress("alSourcePlay");
            _alSourcePlay_fnptr(source);
        }
        
        /// <summary><b>[entry point: <c>alSourcePlayAtTimeSOFT</c>]</b></summary>
        public static delegate* unmanaged<uint, long, void> _alSourcePlayAtTimeSOFT_fnptr = &alSourcePlayAtTimeSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePlayAtTimeSOFT_Lazy(uint source, long start_time)
        {
            _alSourcePlayAtTimeSOFT_fnptr = (delegate* unmanaged<uint, long, void>)ALLoader.BindingsContext.GetProcAddress("alSourcePlayAtTimeSOFT");
            _alSourcePlayAtTimeSOFT_fnptr(source, start_time);
        }
        
        /// <summary><b>[entry point: <c>alSourcePlayAtTimevSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, long, void> _alSourcePlayAtTimevSOFT_fnptr = &alSourcePlayAtTimevSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePlayAtTimevSOFT_Lazy(int n, uint* sources, long start_time)
        {
            _alSourcePlayAtTimevSOFT_fnptr = (delegate* unmanaged<int, uint*, long, void>)ALLoader.BindingsContext.GetProcAddress("alSourcePlayAtTimevSOFT");
            _alSourcePlayAtTimevSOFT_fnptr(n, sources, start_time);
        }
        
        /// <summary><b>[entry point: <c>alSourcePlayv</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, void> _alSourcePlayv_fnptr = &alSourcePlayv_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourcePlayv_Lazy(int n, uint* sources)
        {
            _alSourcePlayv_fnptr = (delegate* unmanaged<int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alSourcePlayv");
            _alSourcePlayv_fnptr(n, sources);
        }
        
        /// <summary><b>[entry point: <c>alSourceQueueBuffers</c>]</b></summary>
        public static delegate* unmanaged<uint, int, uint*, void> _alSourceQueueBuffers_fnptr = &alSourceQueueBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceQueueBuffers_Lazy(uint source, int nb, uint* buffers)
        {
            _alSourceQueueBuffers_fnptr = (delegate* unmanaged<uint, int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alSourceQueueBuffers");
            _alSourceQueueBuffers_fnptr(source, nb, buffers);
        }
        
        /// <summary><b>[entry point: <c>alSourceRemoveNotification</c>]</b></summary>
        public static delegate* unmanaged<uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*, void> _alSourceRemoveNotification_fnptr = &alSourceRemoveNotification_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceRemoveNotification_Lazy(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, void* userData)
        {
            _alSourceRemoveNotification_fnptr = (delegate* unmanaged<uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*, void>)ALLoader.BindingsContext.GetProcAddress("alSourceRemoveNotification");
            _alSourceRemoveNotification_fnptr(sid, notificationID, notifyProc, userData);
        }
        
        /// <summary><b>[entry point: <c>alSourceRenderingQuality</c>]</b></summary>
        public static delegate* unmanaged<uint, int, void> _alSourceRenderingQuality_fnptr = &alSourceRenderingQuality_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceRenderingQuality_Lazy(uint sid, int value)
        {
            _alSourceRenderingQuality_fnptr = (delegate* unmanaged<uint, int, void>)ALLoader.BindingsContext.GetProcAddress("alSourceRenderingQuality");
            _alSourceRenderingQuality_fnptr(sid, value);
        }
        
        /// <summary><b>[entry point: <c>alSourceRewind</c>]</b></summary>
        public static delegate* unmanaged<uint, void> _alSourceRewind_fnptr = &alSourceRewind_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceRewind_Lazy(uint source)
        {
            _alSourceRewind_fnptr = (delegate* unmanaged<uint, void>)ALLoader.BindingsContext.GetProcAddress("alSourceRewind");
            _alSourceRewind_fnptr(source);
        }
        
        /// <summary><b>[entry point: <c>alSourceRewindv</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, void> _alSourceRewindv_fnptr = &alSourceRewindv_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceRewindv_Lazy(int n, uint* sources)
        {
            _alSourceRewindv_fnptr = (delegate* unmanaged<int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alSourceRewindv");
            _alSourceRewindv_fnptr(n, sources);
        }
        
        /// <summary><b>[entry point: <c>alSourceStop</c>]</b></summary>
        public static delegate* unmanaged<uint, void> _alSourceStop_fnptr = &alSourceStop_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceStop_Lazy(uint source)
        {
            _alSourceStop_fnptr = (delegate* unmanaged<uint, void>)ALLoader.BindingsContext.GetProcAddress("alSourceStop");
            _alSourceStop_fnptr(source);
        }
        
        /// <summary><b>[entry point: <c>alSourceStopv</c>]</b></summary>
        public static delegate* unmanaged<int, uint*, void> _alSourceStopv_fnptr = &alSourceStopv_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceStopv_Lazy(int n, uint* sources)
        {
            _alSourceStopv_fnptr = (delegate* unmanaged<int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alSourceStopv");
            _alSourceStopv_fnptr(n, sources);
        }
        
        /// <summary><b>[entry point: <c>alSourceUnqueueBuffers</c>]</b></summary>
        public static delegate* unmanaged<uint, int, uint*, void> _alSourceUnqueueBuffers_fnptr = &alSourceUnqueueBuffers_Lazy;
        [UnmanagedCallersOnly]
        private static void alSourceUnqueueBuffers_Lazy(uint source, int nb, uint* buffer)
        {
            _alSourceUnqueueBuffers_fnptr = (delegate* unmanaged<uint, int, uint*, void>)ALLoader.BindingsContext.GetProcAddress("alSourceUnqueueBuffers");
            _alSourceUnqueueBuffers_fnptr(source, nb, buffer);
        }
        
        /// <summary><b>[entry point: <c>alSpeedOfSound</c>]</b></summary>
        public static delegate* unmanaged<float, void> _alSpeedOfSound_fnptr = &alSpeedOfSound_Lazy;
        [UnmanagedCallersOnly]
        private static void alSpeedOfSound_Lazy(float value)
        {
            _alSpeedOfSound_fnptr = (delegate* unmanaged<float, void>)ALLoader.BindingsContext.GetProcAddress("alSpeedOfSound");
            _alSpeedOfSound_fnptr(value);
        }
        
        /// <summary><b>[entry point: <c>AttenuationScale_LOKI</c>]</b></summary>
        public static delegate* unmanaged<float, void> _AttenuationScale_LOKI_fnptr = &AttenuationScale_LOKI_Lazy;
        [UnmanagedCallersOnly]
        private static void AttenuationScale_LOKI_Lazy(float value)
        {
            _AttenuationScale_LOKI_fnptr = (delegate* unmanaged<float, void>)ALLoader.BindingsContext.GetProcAddress("AttenuationScale_LOKI");
            _AttenuationScale_LOKI_fnptr(value);
        }
        
        /// <summary><b>[entry point: <c>BufferDataWithCallback_LOKI</c>]</b></summary>
        public static delegate* unmanaged<uint, delegate* unmanaged[Cdecl]<uint, uint, void*, All, uint, int>, void> _BufferDataWithCallback_LOKI_fnptr = &BufferDataWithCallback_LOKI_Lazy;
        [UnmanagedCallersOnly]
        private static void BufferDataWithCallback_LOKI_Lazy(uint bid, delegate* unmanaged[Cdecl]<uint, uint, void*, All, uint, int> callback)
        {
            _BufferDataWithCallback_LOKI_fnptr = (delegate* unmanaged<uint, delegate* unmanaged[Cdecl]<uint, uint, void*, All, uint, int>, void>)ALLoader.BindingsContext.GetProcAddress("BufferDataWithCallback_LOKI");
            _BufferDataWithCallback_LOKI_fnptr(bid, callback);
        }
        
    }
}

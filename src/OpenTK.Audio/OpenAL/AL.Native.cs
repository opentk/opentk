// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Audio;

namespace OpenTK.Audio.OpenAL
{
    public static unsafe partial class AL
    {
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alBuffer3f</c>]</b><br/>  </summary>
        public static void Buffer3f(uint buffer, All param, float value1, float value2, float value3) => ALPointers._alBuffer3f_fnptr(buffer, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alBuffer3i</c>]</b><br/>  </summary>
        public static void Buffer3i(uint buffer, All param, int value1, int value2, int value3) => ALPointers._alBuffer3i_fnptr(buffer, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alBufferData</c>]</b><br/>  </summary>
        public static void BufferData(uint buffer, All format, void* data, int size, int samplerate) => ALPointers._alBufferData_fnptr(buffer, (int)format, data, size, samplerate);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alBufferf</c>]</b><br/>  </summary>
        public static void Bufferf(uint buffer, All param, float value) => ALPointers._alBufferf_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alBufferfv</c>]</b><br/>  </summary>
        public static void Bufferfv(uint buffer, All param, float* value) => ALPointers._alBufferfv_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alBufferi</c>]</b><br/>  </summary>
        public static void Bufferi(uint buffer, All param, int value) => ALPointers._alBufferi_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alBufferiv</c>]</b><br/>  </summary>
        public static void Bufferiv(uint buffer, All param, int* value) => ALPointers._alBufferiv_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alDeleteBuffers</c>]</b><br/>  </summary>
        public static void DeleteBuffers(int n, uint* buffers) => ALPointers._alDeleteBuffers_fnptr(n, buffers);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alDeleteSources</c>]</b><br/>  </summary>
        public static void DeleteSources(int n, uint* sources) => ALPointers._alDeleteSources_fnptr(n, sources);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alDisable</c>]</b><br/>  </summary>
        public static void Disable(EnableCap capability) => ALPointers._alDisable_fnptr((int)capability);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alDistanceModel</c>]</b><br/>  </summary>
        public static void DistanceModel(DistanceModel distanceModel) => ALPointers._alDistanceModel_fnptr((int)distanceModel);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alDopperFactor</c>]</b><br/>  </summary>
        public static void DopperFactor(float value) => ALPointers._alDopperFactor_fnptr(value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alEnable</c>]</b><br/>  </summary>
        public static void Enable(EnableCap capability) => ALPointers._alEnable_fnptr((int)capability);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGenBuffers</c>]</b><br/>  </summary>
        public static void GenBuffers(int n, uint* buffers) => ALPointers._alGenBuffers_fnptr(n, buffers);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGenSources</c>]</b><br/>  </summary>
        public static void GenSources(int n, uint* sources) => ALPointers._alGenSources_fnptr(n, sources);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBoolean</c>]</b><br/>  </summary>
        public static bool GetBoolean(GetPName param) => ALPointers._alGetBoolean_fnptr((int)param) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBooleanv</c>]</b><br/>  </summary>
        public static void GetBooleanv(GetPName param, bool* values) => ALPointers._alGetBooleanv_fnptr((int)param, (byte*)values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBuffer3f</c>]</b><br/>  </summary>
        public static void GetBuffer3f(uint buffer, All param, float* value1, float* value2, float* value3) => ALPointers._alGetBuffer3f_fnptr(buffer, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBuffer3i</c>]</b><br/>  </summary>
        public static void GetBuffer3i(uint buffer, All param, int* value1, int* value2, int* value3) => ALPointers._alGetBuffer3i_fnptr(buffer, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBufferf</c>]</b><br/>  </summary>
        public static void GetBufferf(uint buffer, All param, float* value) => ALPointers._alGetBufferf_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBufferfv</c>]</b><br/>  </summary>
        public static void GetBufferfv(uint buffer, All param, float* value) => ALPointers._alGetBufferfv_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBufferi</c>]</b><br/>  </summary>
        public static void GetBufferi(uint buffer, All param, int* value) => ALPointers._alGetBufferi_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBufferiv</c>]</b><br/>  </summary>
        public static void GetBufferiv(uint buffer, All param, int* value) => ALPointers._alGetBufferiv_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetDouble</c>]</b><br/>  </summary>
        public static double GetDouble(GetPName param) => ALPointers._alGetDouble_fnptr((int)param);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetDoublev</c>]</b><br/>  </summary>
        public static void GetDoublev(GetPName param, double* values) => ALPointers._alGetDoublev_fnptr((int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetEnumValue</c>]</b><br/>  </summary>
        public static All GetEnumValue(byte* ename) => (All) ALPointers._alGetEnumValue_fnptr(ename);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetError</c>]</b><br/>  </summary>
        public static ErrorCode GetError() => (ErrorCode) ALPointers._alGetError_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetFloat</c>]</b><br/>  </summary>
        public static float GetFloat(GetPName param) => ALPointers._alGetFloat_fnptr((int)param);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetFloatv</c>]</b><br/>  </summary>
        public static void GetFloatv(GetPName param, float* values) => ALPointers._alGetFloatv_fnptr((int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetInteger</c>]</b><br/>  </summary>
        public static int GetInteger(GetPName param) => ALPointers._alGetInteger_fnptr((int)param);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetIntegerv</c>]</b><br/>  </summary>
        public static void GetIntegerv(GetPName param, int* values) => ALPointers._alGetIntegerv_fnptr((int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetListener3f</c>]</b><br/>  </summary>
        public static void GetListener3f(All param, float* value1, float* value2, float* value3) => ALPointers._alGetListener3f_fnptr((int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetListener3i</c>]</b><br/>  </summary>
        public static void GetListener3i(All param, int* value1, int* value2, int* value3) => ALPointers._alGetListener3i_fnptr((int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetListenerf</c>]</b><br/>  </summary>
        public static void GetListenerf(All param, float* value) => ALPointers._alGetListenerf_fnptr((int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetListenerfv</c>]</b><br/>  </summary>
        public static void GetListenerfv(All param, float* values) => ALPointers._alGetListenerfv_fnptr((int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetListeneri</c>]</b><br/>  </summary>
        public static void GetListeneri(All param, int* value) => ALPointers._alGetListeneri_fnptr((int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetListeneriv</c>]</b><br/>  </summary>
        public static void GetListeneriv(All param, int* values) => ALPointers._alGetListeneriv_fnptr((int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetProcAddress</c>]</b><br/>  </summary>
        public static void* GetProcAddress(byte* fname) => ALPointers._alGetProcAddress_fnptr(fname);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetSource3f</c>]</b><br/>  </summary>
        public static void GetSource3f(uint source, All param, float* value1, float* value2, float* value3) => ALPointers._alGetSource3f_fnptr(source, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetSource3i</c>]</b><br/>  </summary>
        public static void GetSource3i(uint source, All param, int* value1, int* value2, int* value3) => ALPointers._alGetSource3i_fnptr(source, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetSourcef</c>]</b><br/>  </summary>
        public static void GetSourcef(uint source, All param, float* value) => ALPointers._alGetSourcef_fnptr(source, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetSourcefv</c>]</b><br/>  </summary>
        public static void GetSourcefv(uint source, All param, float* values) => ALPointers._alGetSourcefv_fnptr(source, (int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetSourcei</c>]</b><br/>  </summary>
        public static void GetSourcei(uint source, All param, int* value) => ALPointers._alGetSourcei_fnptr(source, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetSourceiv</c>]</b><br/>  </summary>
        public static void GetSourceiv(uint source, All param, int* values) => ALPointers._alGetSourceiv_fnptr(source, (int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetString</c>]</b><br/>  </summary>
        public static byte* GetString_(StringName param) => ALPointers._alGetString_fnptr((int)param);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alIsBuffer</c>]</b><br/>  </summary>
        public static bool IsBuffer(uint buffer) => ALPointers._alIsBuffer_fnptr(buffer) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alIsEnabled</c>]</b><br/>  </summary>
        public static bool IsEnabled(EnableCap capability) => ALPointers._alIsEnabled_fnptr((int)capability) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alIsExtensionPresent</c>]</b><br/>  </summary>
        public static bool IsExtensionPresent(byte* extname) => ALPointers._alIsExtensionPresent_fnptr(extname) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alIsSource</c>]</b><br/>  </summary>
        public static bool IsSource(uint source) => ALPointers._alIsSource_fnptr(source) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alListener3f</c>]</b><br/>  </summary>
        public static void Listener3f(All param, float value1, float value2, float value3) => ALPointers._alListener3f_fnptr((int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alListener3i</c>]</b><br/>  </summary>
        public static void Listener3i(All param, int value1, int value2, int value3) => ALPointers._alListener3i_fnptr((int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alListenerf</c>]</b><br/>  </summary>
        public static void Listenerf(All param, float value) => ALPointers._alListenerf_fnptr((int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alListenerfv</c>]</b><br/>  </summary>
        public static void Listenerfv(All param, float* values) => ALPointers._alListenerfv_fnptr((int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alListeneri</c>]</b><br/>  </summary>
        public static void Listeneri(All param, int value) => ALPointers._alListeneri_fnptr((int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alListeneriv</c>]</b><br/>  </summary>
        public static void Listeneriv(All param, int* values) => ALPointers._alListeneriv_fnptr((int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSource3f</c>]</b><br/>  </summary>
        public static void Source3f(uint source, All param, float value1, float value2, float value3) => ALPointers._alSource3f_fnptr(source, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSource3i</c>]</b><br/>  </summary>
        public static void Source3i(uint source, All param, int value1, int value2, int value3) => ALPointers._alSource3i_fnptr(source, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourcef</c>]</b><br/>  </summary>
        public static void Sourcef(uint source, All param, float value) => ALPointers._alSourcef_fnptr(source, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourcefv</c>]</b><br/>  </summary>
        public static void Sourcefv(uint source, All param, float* value) => ALPointers._alSourcefv_fnptr(source, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourcei</c>]</b><br/>  </summary>
        public static void Sourcei(uint source, All param, int value) => ALPointers._alSourcei_fnptr(source, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourceiv</c>]</b><br/>  </summary>
        public static void Sourceiv(uint source, All param, int* value) => ALPointers._alSourceiv_fnptr(source, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourcePause</c>]</b><br/>  </summary>
        public static void SourcePause(uint source) => ALPointers._alSourcePause_fnptr(source);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourcePausev</c>]</b><br/>  </summary>
        public static void SourcePausev(int n, uint* sources) => ALPointers._alSourcePausev_fnptr(n, sources);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourcePlay</c>]</b><br/>  </summary>
        public static void SourcePlay(uint source) => ALPointers._alSourcePlay_fnptr(source);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourcePlayv</c>]</b><br/>  </summary>
        public static void SourcePlayv(int n, uint* sources) => ALPointers._alSourcePlayv_fnptr(n, sources);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourceQueueBuffers</c>]</b><br/>  </summary>
        public static void SourceQueueBuffers(uint source, int nb, uint* buffers) => ALPointers._alSourceQueueBuffers_fnptr(source, nb, buffers);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourceRewind</c>]</b><br/>  </summary>
        public static void SourceRewind(uint source) => ALPointers._alSourceRewind_fnptr(source);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourceRewindv</c>]</b><br/>  </summary>
        public static void SourceRewindv(int n, uint* sources) => ALPointers._alSourceRewindv_fnptr(n, sources);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourceStop</c>]</b><br/>  </summary>
        public static void SourceStop(uint source) => ALPointers._alSourceStop_fnptr(source);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourceStopv</c>]</b><br/>  </summary>
        public static void SourceStopv(int n, uint* sources) => ALPointers._alSourceStopv_fnptr(n, sources);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourceUnqueueBuffers</c>]</b><br/>  </summary>
        public static void SourceUnqueueBuffers(uint source, int nb, uint* buffer) => ALPointers._alSourceUnqueueBuffers_fnptr(source, nb, buffer);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSpeedOfSound</c>]</b><br/>  </summary>
        public static void SpeedOfSound(float value) => ALPointers._alSpeedOfSound_fnptr(value);
        
        /// <summary>EXT extensions.</summary>
        public static unsafe partial class EXT
        {
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alAuxiliaryEffectSlotf</c>]</b><br/>  </summary>
            public static void AuxiliaryEffectSlotf(uint effectslot, All param, float flValue) => ALPointers._alAuxiliaryEffectSlotf_fnptr(effectslot, (int)param, flValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alAuxiliaryEffectSlotfv</c>]</b><br/>  </summary>
            public static void AuxiliaryEffectSlotfv(uint effectslot, All param, float* pflValues) => ALPointers._alAuxiliaryEffectSlotfv_fnptr(effectslot, (int)param, pflValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alAuxiliaryEffectSloti</c>]</b><br/>  </summary>
            public static void AuxiliaryEffectSloti(uint effectslot, All param, int iValue) => ALPointers._alAuxiliaryEffectSloti_fnptr(effectslot, (int)param, iValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alAuxiliaryEffectSlotiv</c>]</b><br/>  </summary>
            public static void AuxiliaryEffectSlotiv(uint effectslot, All param, int* piValues) => ALPointers._alAuxiliaryEffectSlotiv_fnptr(effectslot, (int)param, piValues);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alDebugMessageCallbackEXT</c>]</b><br/>  </summary>
            public static void DebugMessageCallbackEXT(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, void* userParam) => ALPointers._alDebugMessageCallbackEXT_fnptr(callback, userParam);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alDebugMessageControlEXT</c>]</b><br/>  </summary>
            public static void DebugMessageControlEXT(All source, All type, uint severity, int count, uint* ids, bool enable) => ALPointers._alDebugMessageControlEXT_fnptr((int)source, (int)type, severity, count, ids, (byte)(enable ? 1 : 0));
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alDebugMessageInsertEXT</c>]</b><br/>  </summary>
            public static void DebugMessageInsertEXT(All source, All type, uint severity, int length, byte* message) => ALPointers._alDebugMessageInsertEXT_fnptr((int)source, (int)type, severity, length, message);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alDeleteAuxiliaryEffectSlots</c>]</b><br/>  </summary>
            public static void DeleteAuxiliaryEffectSlots(int n, uint* effectslots) => ALPointers._alDeleteAuxiliaryEffectSlots_fnptr(n, effectslots);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alDeleteEffects</c>]</b><br/>  </summary>
            public static void DeleteEffects(int n, uint* effects) => ALPointers._alDeleteEffects_fnptr(n, effects);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alDeleteFilters</c>]</b><br/>  </summary>
            public static void DeleteFilters(int n, uint* filters) => ALPointers._alDeleteFilters_fnptr(n, filters);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alEffectf</c>]</b><br/>  </summary>
            public static void Effectf(uint effect, All param, float flValue) => ALPointers._alEffectf_fnptr(effect, (int)param, flValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alEffectfv</c>]</b><br/>  </summary>
            public static void Effectfv(uint effect, All param, float* pflValues) => ALPointers._alEffectfv_fnptr(effect, (int)param, pflValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alEffecti</c>]</b><br/>  </summary>
            public static void Effecti(uint effect, All param, int iValue) => ALPointers._alEffecti_fnptr(effect, (int)param, iValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alEffectiv</c>]</b><br/>  </summary>
            public static void Effectiv(uint effect, All param, int* piValues) => ALPointers._alEffectiv_fnptr(effect, (int)param, piValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alFilterf</c>]</b><br/>  </summary>
            public static void Filterf(uint filter, All param, float flValue) => ALPointers._alFilterf_fnptr(filter, (int)param, flValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alFilterfv</c>]</b><br/>  </summary>
            public static void Filterfv(uint filter, All param, float* pflValues) => ALPointers._alFilterfv_fnptr(filter, (int)param, pflValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alFilteri</c>]</b><br/>  </summary>
            public static void Filteri(uint filter, All param, int iValue) => ALPointers._alFilteri_fnptr(filter, (int)param, iValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alFilteriv</c>]</b><br/>  </summary>
            public static void Filteriv(uint filter, All param, int* piValues) => ALPointers._alFilteriv_fnptr(filter, (int)param, piValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGenAuxiliaryEffectSlots</c>]</b><br/>  </summary>
            public static void GenAuxiliaryEffectSlots(int n, uint* effectslots) => ALPointers._alGenAuxiliaryEffectSlots_fnptr(n, effectslots);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGenEffects</c>]</b><br/>  </summary>
            public static void GenEffects(int n, uint* effects) => ALPointers._alGenEffects_fnptr(n, effects);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGenFilters</c>]</b><br/>  </summary>
            public static void GenFilters(int n, uint* filters) => ALPointers._alGenFilters_fnptr(n, filters);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetAuxiliaryEffectSlotf</c>]</b><br/>  </summary>
            public static void GetAuxiliaryEffectSlotf(uint effectslot, All param, float* pflValue) => ALPointers._alGetAuxiliaryEffectSlotf_fnptr(effectslot, (int)param, pflValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetAuxiliaryEffectSlotfv</c>]</b><br/>  </summary>
            public static void GetAuxiliaryEffectSlotfv(uint effectslot, All param, float* pflValues) => ALPointers._alGetAuxiliaryEffectSlotfv_fnptr(effectslot, (int)param, pflValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetAuxiliaryEffectSloti</c>]</b><br/>  </summary>
            public static void GetAuxiliaryEffectSloti(uint effectslot, All param, int* piValue) => ALPointers._alGetAuxiliaryEffectSloti_fnptr(effectslot, (int)param, piValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetAuxiliaryEffectSlotiv</c>]</b><br/>  </summary>
            public static void GetAuxiliaryEffectSlotiv(uint effectslot, All param, int* piValues) => ALPointers._alGetAuxiliaryEffectSlotiv_fnptr(effectslot, (int)param, piValues);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alGetDebugMessageLogEXT</c>]</b><br/>  </summary>
            public static uint GetDebugMessageLogEXT(uint count, int logBufSize, All* sources, All* types, uint* ids, All* severities, int* lengths, byte* logBuf) => ALPointers._alGetDebugMessageLogEXT_fnptr(count, logBufSize, (int*)sources, (int*)types, ids, (int*)severities, lengths, logBuf);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetEffectf</c>]</b><br/>  </summary>
            public static void GetEffectf(uint effect, All param, float* pflValue) => ALPointers._alGetEffectf_fnptr(effect, (int)param, pflValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetEffectfv</c>]</b><br/>  </summary>
            public static void GetEffectfv(uint effect, All param, float* pflValues) => ALPointers._alGetEffectfv_fnptr(effect, (int)param, pflValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetEffecti</c>]</b><br/>  </summary>
            public static void GetEffecti(uint effect, All param, int* piValue) => ALPointers._alGetEffecti_fnptr(effect, (int)param, piValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetEffectiv</c>]</b><br/>  </summary>
            public static void GetEffectiv(uint effect, All param, int* piValues) => ALPointers._alGetEffectiv_fnptr(effect, (int)param, piValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetFilterf</c>]</b><br/>  </summary>
            public static void GetFilterf(uint filter, All param, float* pflValue) => ALPointers._alGetFilterf_fnptr(filter, (int)param, pflValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetFilterfv</c>]</b><br/>  </summary>
            public static void GetFilterfv(uint filter, All param, float* pflValues) => ALPointers._alGetFilterfv_fnptr(filter, (int)param, pflValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetFilteri</c>]</b><br/>  </summary>
            public static void GetFilteri(uint filter, All param, int* piValue) => ALPointers._alGetFilteri_fnptr(filter, (int)param, piValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetFilteriv</c>]</b><br/>  </summary>
            public static void GetFilteriv(uint filter, All param, int* piValues) => ALPointers._alGetFilteriv_fnptr(filter, (int)param, piValues);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alGetObjectLabelEXT</c>]</b><br/>  </summary>
            public static void GetObjectLabelEXT(All identifier, uint name, int bufSize, int* length, byte* label) => ALPointers._alGetObjectLabelEXT_fnptr((int)identifier, name, bufSize, length, label);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alGetPointerEXT</c>]</b><br/>  </summary>
            public static void* GetPointerEXT(All pname) => ALPointers._alGetPointerEXT_fnptr((int)pname);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alGetPointervEXT</c>]</b><br/>  </summary>
            public static void GetPointervEXT(All pname, void** values) => ALPointers._alGetPointervEXT_fnptr((int)pname, values);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alIsAuxiliaryEffectSlot</c>]</b><br/>  </summary>
            public static void IsAuxiliaryEffectSlot(uint effectslot) => ALPointers._alIsAuxiliaryEffectSlot_fnptr(effectslot);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alIsEffect</c>]</b><br/>  </summary>
            public static bool IsEffect(uint effect) => ALPointers._alIsEffect_fnptr(effect) != 0;
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alIsFilter</c>]</b><br/>  </summary>
            public static void IsFilter(uint filter) => ALPointers._alIsFilter_fnptr(filter);
            
            /// <summary> <b>[requires: ALC_EXT_MAC_OSX]</b> <b>[entry point: <c>alMacOSXGetRenderChannelCount</c>]</b><br/>  </summary>
            public static int MacOSXGetRenderChannelCount() => ALPointers._alMacOSXGetRenderChannelCount_fnptr();
            
            /// <summary> <b>[requires: ALC_EXT_MAC_OSX]</b> <b>[entry point: <c>alMacOSXRenderChannelCount</c>]</b><br/>  </summary>
            public static void MacOSXRenderChannelCount(int value) => ALPointers._alMacOSXRenderChannelCount_fnptr(value);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alObjectLabelEXT</c>]</b><br/>  </summary>
            public static void ObjectLabelEXT(All identifier, uint name, int length, byte* label) => ALPointers._alObjectLabelEXT_fnptr((int)identifier, name, length, label);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alPopDebugGroupEXT</c>]</b><br/>  </summary>
            public static void PopDebugGroupEXT() => ALPointers._alPopDebugGroupEXT_fnptr();
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alPushDebugGroupEXT</c>]</b><br/>  </summary>
            public static void PushDebugGroupEXT(All source, uint id, int length, byte* message) => ALPointers._alPushDebugGroupEXT_fnptr((int)source, id, length, message);
            
            /// <summary> <b>[requires: AL_EXT_FOLDBACK]</b> <b>[entry point: <c>alRequestFoldbackStart</c>]</b><br/>  </summary>
            public static void RequestFoldbackStart(All foldbackMode, int blockCount, int blockLength, float* bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback) => ALPointers._alRequestFoldbackStart_fnptr((int)foldbackMode, blockCount, blockLength, bufferMemory, callback);
            
            /// <summary> <b>[requires: AL_EXT_FOLDBACK]</b> <b>[entry point: <c>alRequestFoldbackStop</c>]</b><br/>  </summary>
            public static void RequestFoldbackStop() => ALPointers._alRequestFoldbackStop_fnptr();
            
            /// <summary> <b>[requires: AL_EXT_SOURCE_NOTIFICATIONS]</b> <b>[entry point: <c>alSourceAddNotification</c>]</b><br/>  </summary>
            public static All SourceAddNotification(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, void* userData) => (All) ALPointers._alSourceAddNotification_fnptr(sid, notificationID, notifyProc, userData);
            
            /// <summary> <b>[requires: AL_EXT_SOURCE_SPATIALIZATION]</b> <b>[entry point: <c>alSourceGetRenderingQuality</c>]</b><br/>  </summary>
            public static int SourceGetRenderingQuality(uint sid) => ALPointers._alSourceGetRenderingQuality_fnptr(sid);
            
            /// <summary> <b>[requires: AL_EXT_SOURCE_NOTIFICATIONS]</b> <b>[entry point: <c>alSourceRemoveNotification</c>]</b><br/>  </summary>
            public static void SourceRemoveNotification(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, void* userData) => ALPointers._alSourceRemoveNotification_fnptr(sid, notificationID, notifyProc, userData);
            
            /// <summary> <b>[requires: AL_EXT_SOURCE_SPATIALIZATION]</b> <b>[entry point: <c>alSourceRenderingQuality</c>]</b><br/>  </summary>
            public static void SourceRenderingQuality(uint sid, int value) => ALPointers._alSourceRenderingQuality_fnptr(sid, value);
            
        }
        /// <summary>LOKI extensions.</summary>
        public static unsafe partial class LOKI
        {
            /// <summary> <b>[requires: AL_LOKI_attenuation_scale]</b> <b>[entry point: <c>AttenuationScale_LOKI</c>]</b><br/>  </summary>
            public static void AttenuationScale_LOKI(float value) => ALPointers._AttenuationScale_LOKI_fnptr(value);
            
            /// <summary> <b>[requires: AL_LOKI_buffer_data_callback]</b> <b>[entry point: <c>BufferDataWithCallback_LOKI</c>]</b><br/>  </summary>
            public static void BufferDataWithCallback_LOKI(uint bid, delegate* unmanaged[Cdecl]<uint, uint, void*, All, uint, int> callback) => ALPointers._BufferDataWithCallback_LOKI_fnptr(bid, callback);
            
        }
        /// <summary>SOFT extensions.</summary>
        public static unsafe partial class SOFT
        {
            /// <summary> <b>[requires: AL_SOFT_callback_buffer]</b> <b>[entry point: <c>alBufferCallbackSOFT</c>]</b><br/>  </summary>
            public static void BufferCallbackSOFT(uint buffer, All format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, void* userptr) => ALPointers._alBufferCallbackSOFT_fnptr(buffer, (int)format, freq, callback, userptr);
            
            /// <summary> <b>[requires: AL_SOFT_buffer_samples]</b> <b>[entry point: <c>alBufferSamplesSOFT</c>]</b><br/>  </summary>
            public static void BufferSamplesSOFT(uint buffer, uint samplerate, All internalformat, int samples, All channels, All type, void* data) => ALPointers._alBufferSamplesSOFT_fnptr(buffer, samplerate, (int)internalformat, samples, (int)channels, (int)type, data);
            
            /// <summary> <b>[requires: AL_SOFT_buffer_sub_data]</b> <b>[entry point: <c>alBufferSubDataSOFT</c>]</b><br/>  </summary>
            public static void BufferSubDataSOFT(uint buffer, All format, void* data, int offset, int length) => ALPointers._alBufferSubDataSOFT_fnptr(buffer, (int)format, data, offset, length);
            
            /// <summary> <b>[requires: AL_SOFT_buffer_samples]</b> <b>[entry point: <c>alBufferSubSamplesSOFT</c>]</b><br/>  </summary>
            public static void BufferSubSamplesSOFT(uint buffer, int offset, int samples, All channels, All type, void* data) => ALPointers._alBufferSubSamplesSOFT_fnptr(buffer, offset, samples, (int)channels, (int)type, data);
            
            /// <summary> <b>[requires: AL_SOFT_deferred_updates]</b> <b>[entry point: <c>alDeferUpdatesSOFT</c>]</b><br/>  </summary>
            public static void DeferUpdatesSOFT() => ALPointers._alDeferUpdatesSOFT_fnptr();
            
            /// <summary> <b>[requires: AL_SOFT_events]</b> <b>[entry point: <c>alEventCallbackSOFT</c>]</b><br/>  </summary>
            public static void EventCallbackSOFT(delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, void* userParam) => ALPointers._alEventCallbackSOFT_fnptr(callback, userParam);
            
            /// <summary> <b>[requires: AL_SOFT_events]</b> <b>[entry point: <c>alEventControlSOFT</c>]</b><br/>  </summary>
            public static void EventControlSOFT(int count, All* types, bool enable) => ALPointers._alEventControlSOFT_fnptr(count, (int*)types, (byte)(enable ? 1 : 0));
            
            /// <summary> <b>[requires: AL_SOFT_callback_buffer]</b> <b>[entry point: <c>alGetBuffer3PtrSOFT</c>]</b><br/>  </summary>
            public static void GetBuffer3PtrSOFT(uint buffer, All param, void** ptr0, void** ptr1, void** ptr2) => ALPointers._alGetBuffer3PtrSOFT_fnptr(buffer, (int)param, ptr0, ptr1, ptr2);
            
            /// <summary> <b>[requires: AL_SOFT_callback_buffer]</b> <b>[entry point: <c>alGetBufferPtrSOFT</c>]</b><br/>  </summary>
            public static void GetBufferPtrSOFT(uint buffer, All param, void** ptr) => ALPointers._alGetBufferPtrSOFT_fnptr(buffer, (int)param, ptr);
            
            /// <summary> <b>[requires: AL_SOFT_callback_buffer]</b> <b>[entry point: <c>alGetBufferPtrvSOFT</c>]</b><br/>  </summary>
            public static void GetBufferPtrvSOFT(uint buffer, All param, void** ptr) => ALPointers._alGetBufferPtrvSOFT_fnptr(buffer, (int)param, ptr);
            
            /// <summary> <b>[requires: AL_SOFT_buffer_samples]</b> <b>[entry point: <c>alGetBufferSamplesSOFT</c>]</b><br/>  </summary>
            public static void GetBufferSamplesSOFT(uint buffer, int offset, int samples, All channels, All type, void* data) => ALPointers._alGetBufferSamplesSOFT_fnptr(buffer, offset, samples, (int)channels, (int)type, data);
            
            /// <summary> <b>[requires: AL_SOFT_events]</b> <b>[entry point: <c>alGetPointerSOFT</c>]</b><br/>  </summary>
            public static void* GetPointerSOFT(All pname) => ALPointers._alGetPointerSOFT_fnptr((int)pname);
            
            /// <summary> <b>[requires: AL_SOFT_events]</b> <b>[entry point: <c>alGetPointervSOFT</c>]</b><br/>  </summary>
            public static void GetPointervSOFT(All pname, void** values) => ALPointers._alGetPointervSOFT_fnptr((int)pname, values);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alGetSource3dSOFT</c>]</b><br/>  </summary>
            public static void GetSource3dSOFT(uint source, All param, double* value1, double* value2, double* value3) => ALPointers._alGetSource3dSOFT_fnptr(source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alGetSource3i64SOFT</c>]</b><br/>  </summary>
            public static void GetSource3i64SOFT(uint source, All param, long* value1, long* value2, long* value3) => ALPointers._alGetSource3i64SOFT_fnptr(source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alGetSourcedSOFT</c>]</b><br/>  </summary>
            public static void GetSourcedSOFT(uint source, All param, double* value) => ALPointers._alGetSourcedSOFT_fnptr(source, (int)param, value);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alGetSourcedvSOFT</c>]</b><br/>  </summary>
            public static void GetSourcedvSOFT(uint source, All param, double* values) => ALPointers._alGetSourcedvSOFT_fnptr(source, (int)param, values);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alGetSourcei64SOFT</c>]</b><br/>  </summary>
            public static void GetSourcei64SOFT(uint source, All param, long* value) => ALPointers._alGetSourcei64SOFT_fnptr(source, (int)param, value);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alGetSourcei64vSOFT</c>]</b><br/>  </summary>
            public static void GetSourcei64vSOFT(uint source, All param, long* values) => ALPointers._alGetSourcei64vSOFT_fnptr(source, (int)param, values);
            
            /// <summary> <b>[requires: AL_SOFT_source_resampler]</b> <b>[entry point: <c>alGetStringiSOFT</c>]</b><br/>  </summary>
            public static byte* GetStringiSOFT_(All pname, int index) => ALPointers._alGetStringiSOFT_fnptr((int)pname, index);
            
            /// <summary> <b>[requires: AL_SOFT_buffer_samples]</b> <b>[entry point: <c>alIsBufferFormatSupportedSOFT</c>]</b><br/>  </summary>
            public static bool IsBufferFormatSupportedSOFT(All format) => ALPointers._alIsBufferFormatSupportedSOFT_fnptr((int)format) != 0;
            
            /// <summary> <b>[requires: AL_SOFT_deferred_updates]</b> <b>[entry point: <c>alProcessUpdatesSOFT</c>]</b><br/>  </summary>
            public static void ProcessUpdatesSOFT() => ALPointers._alProcessUpdatesSOFT_fnptr();
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alSource3dSOFT</c>]</b><br/>  </summary>
            public static void Source3dSOFT(uint source, All param, double value1, double value2, double value3) => ALPointers._alSource3dSOFT_fnptr(source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alSource3i64SOFT</c>]</b><br/>  </summary>
            public static void Source3i64SOFT(uint source, All param, long value1, long value2, long value3) => ALPointers._alSource3i64SOFT_fnptr(source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alSourcedSOFT</c>]</b><br/>  </summary>
            public static void SourcedSOFT(uint source, All param, double value) => ALPointers._alSourcedSOFT_fnptr(source, (int)param, value);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alSourcedvSOFT</c>]</b><br/>  </summary>
            public static void SourcedvSOFT(uint source, All param, double* values) => ALPointers._alSourcedvSOFT_fnptr(source, (int)param, values);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alSourcei64SOFT</c>]</b><br/>  </summary>
            public static void Sourcei64SOFT(uint source, All param, long value) => ALPointers._alSourcei64SOFT_fnptr(source, (int)param, value);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alSourcei64vSOFT</c>]</b><br/>  </summary>
            public static void Sourcei64vSOFT(uint source, All param, long* values) => ALPointers._alSourcei64vSOFT_fnptr(source, (int)param, values);
            
            /// <summary> <b>[requires: AL_SOFT_source_start_delay]</b> <b>[entry point: <c>alSourcePlayAtTimeSOFT</c>]</b><br/>  </summary>
            public static void SourcePlayAtTimeSOFT(uint source, long start_time) => ALPointers._alSourcePlayAtTimeSOFT_fnptr(source, start_time);
            
            /// <summary> <b>[requires: AL_SOFT_source_start_delay]</b> <b>[entry point: <c>alSourcePlayAtTimevSOFT</c>]</b><br/>  </summary>
            public static void SourcePlayAtTimevSOFT(int n, uint* sources, long start_time) => ALPointers._alSourcePlayAtTimevSOFT_fnptr(n, sources, start_time);
            
        }
    }
}

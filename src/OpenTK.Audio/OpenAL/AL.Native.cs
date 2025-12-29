// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Audio;

namespace OpenTK.Audio.OpenAL
{
    public static unsafe partial class AL
    {
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alBuffer3f</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Buffer3f(int buffer, BufferPName3F param, float value1, float value2, float value3) => ALPointers._alBuffer3f_fnptr(buffer, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alBuffer3i</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Buffer3i(int buffer, BufferPName3I param, int value1, int value2, int value3) => ALPointers._alBuffer3i_fnptr(buffer, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alBufferData</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void BufferData(int buffer, Format format, void* data, int size, int samplerate) => ALPointers._alBufferData_fnptr(buffer, (int)format, data, size, samplerate);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alBufferf</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Bufferf(int buffer, BufferPNameF param, float value) => ALPointers._alBufferf_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alBufferfv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Bufferfv(int buffer, BufferPNameFV param, float* value) => ALPointers._alBufferfv_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alBufferi</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Bufferi(int buffer, BufferPNameI param, int value) => ALPointers._alBufferi_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alBufferiv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Bufferiv(int buffer, BufferPNameIV param, int* value) => ALPointers._alBufferiv_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alDeleteBuffers</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void DeleteBuffers(int n, int* buffers) => ALPointers._alDeleteBuffers_fnptr(n, buffers);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alDeleteSources</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void DeleteSources(int n, int* sources) => ALPointers._alDeleteSources_fnptr(n, sources);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alDisable</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Disable(EnableCap capability) => ALPointers._alDisable_fnptr((int)capability);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alDistanceModel</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void DistanceModel(DistanceModel distanceModel) => ALPointers._alDistanceModel_fnptr((int)distanceModel);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alDopperFactor</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void DopperFactor(float value) => ALPointers._alDopperFactor_fnptr(value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alEnable</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Enable(EnableCap capability) => ALPointers._alEnable_fnptr((int)capability);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGenBuffers</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GenBuffers(int n, int* buffers) => ALPointers._alGenBuffers_fnptr(n, buffers);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGenSources</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GenSources(int n, int* sources) => ALPointers._alGenSources_fnptr(n, sources);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBoolean</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static bool GetBoolean(GetPNameB param) => ALPointers._alGetBoolean_fnptr((int)param) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBooleanv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetBooleanv(GetPNameBV param, bool* values) => ALPointers._alGetBooleanv_fnptr((int)param, (byte*)values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBuffer3f</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetBuffer3f(int buffer, BufferGetPName3F param, float* value1, float* value2, float* value3) => ALPointers._alGetBuffer3f_fnptr(buffer, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBuffer3i</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetBuffer3i(int buffer, BufferGetPName3I param, int* value1, int* value2, int* value3) => ALPointers._alGetBuffer3i_fnptr(buffer, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBufferf</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetBufferf(int buffer, BufferGetPNameF param, float* value) => ALPointers._alGetBufferf_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBufferfv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetBufferfv(int buffer, BufferGetPNameFV param, float* value) => ALPointers._alGetBufferfv_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBufferi</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetBufferi(int buffer, BufferGetPNameI param, int* value) => ALPointers._alGetBufferi_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetBufferiv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetBufferiv(int buffer, BufferGetPNameIV param, int* value) => ALPointers._alGetBufferiv_fnptr(buffer, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetDouble</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static double GetDouble(GetPNameD param) => ALPointers._alGetDouble_fnptr((int)param);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetDoublev</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetDoublev(GetPNameDV param, double* values) => ALPointers._alGetDoublev_fnptr((int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetEnumValue</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static All GetEnumValue(byte* ename) => (All) ALPointers._alGetEnumValue_fnptr(ename);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetError</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static ErrorCode GetError() => (ErrorCode) ALPointers._alGetError_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetFloat</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static float GetFloat(GetPNameF param) => ALPointers._alGetFloat_fnptr((int)param);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetFloatv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetFloatv(GetPNameFV param, float* values) => ALPointers._alGetFloatv_fnptr((int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetInteger</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static int GetInteger(GetPNameI param) => ALPointers._alGetInteger_fnptr((int)param);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetIntegerv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetIntegerv(GetPNameIV param, int* values) => ALPointers._alGetIntegerv_fnptr((int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetListener3f</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetListener3f(ListenerGetPName3F param, float* value1, float* value2, float* value3) => ALPointers._alGetListener3f_fnptr((int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetListener3i</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetListener3i(ListenerGetPName3I param, int* value1, int* value2, int* value3) => ALPointers._alGetListener3i_fnptr((int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetListenerf</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetListenerf(ListenerGetPNameF param, float* value) => ALPointers._alGetListenerf_fnptr((int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetListenerfv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetListenerfv(ListenerGetPNameFV param, float* values) => ALPointers._alGetListenerfv_fnptr((int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetListeneri</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetListeneri(ListenerGetPNameI param, int* value) => ALPointers._alGetListeneri_fnptr((int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetListeneriv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetListeneriv(ListenerGetPNameIV param, int* values) => ALPointers._alGetListeneriv_fnptr((int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetProcAddress</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void* GetProcAddress(byte* fname) => ALPointers._alGetProcAddress_fnptr(fname);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetSource3f</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetSource3f(int source, SourceGetPName3F param, float* value1, float* value2, float* value3) => ALPointers._alGetSource3f_fnptr(source, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetSource3i</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetSource3i(int source, SourceGetPName3I param, int* value1, int* value2, int* value3) => ALPointers._alGetSource3i_fnptr(source, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetSourcef</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetSourcef(int source, SourceGetPNameF param, float* value) => ALPointers._alGetSourcef_fnptr(source, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetSourcefv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetSourcefv(int source, SourceGetPNameFV param, float* values) => ALPointers._alGetSourcefv_fnptr(source, (int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetSourcei</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetSourcei(int source, SourceGetPNameI param, int* value) => ALPointers._alGetSourcei_fnptr(source, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetSourceiv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetSourceiv(int source, SourceGetPNameIV param, int* values) => ALPointers._alGetSourceiv_fnptr(source, (int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alGetString</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static byte* GetString_(StringName param) => ALPointers._alGetString_fnptr((int)param);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alIsBuffer</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static bool IsBuffer(int buffer) => ALPointers._alIsBuffer_fnptr(buffer) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alIsEnabled</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static bool IsEnabled(EnableCap capability) => ALPointers._alIsEnabled_fnptr((int)capability) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alIsExtensionPresent</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static bool IsExtensionPresent(byte* extname) => ALPointers._alIsExtensionPresent_fnptr(extname) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alIsSource</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static bool IsSource(int source) => ALPointers._alIsSource_fnptr(source) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alListener3f</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Listener3f(ListenerPName3F param, float value1, float value2, float value3) => ALPointers._alListener3f_fnptr((int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alListener3i</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Listener3i(ListenerPName3I param, int value1, int value2, int value3) => ALPointers._alListener3i_fnptr((int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alListenerf</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Listenerf(ListenerPNameF param, float value) => ALPointers._alListenerf_fnptr((int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alListenerfv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Listenerfv(ListenerPNameFV param, float* values) => ALPointers._alListenerfv_fnptr((int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alListeneri</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Listeneri(ListenerPNameI param, int value) => ALPointers._alListeneri_fnptr((int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alListeneriv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Listeneriv(ListenerPNameIV param, int* values) => ALPointers._alListeneriv_fnptr((int)param, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSource3f</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Source3f(int source, SourcePName3F param, float value1, float value2, float value3) => ALPointers._alSource3f_fnptr(source, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSource3i</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Source3i(int source, SourcePName3I param, int value1, int value2, int value3) => ALPointers._alSource3i_fnptr(source, (int)param, value1, value2, value3);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourcef</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Sourcef(int source, SourcePNameF param, float value) => ALPointers._alSourcef_fnptr(source, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourcefv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Sourcefv(int source, SourcePNameFV param, float* value) => ALPointers._alSourcefv_fnptr(source, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourcei</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Sourcei(int source, SourcePNameI param, int value) => ALPointers._alSourcei_fnptr(source, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourceiv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void Sourceiv(int source, SourcePNameIV param, int* value) => ALPointers._alSourceiv_fnptr(source, (int)param, value);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourcePause</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void SourcePause(int source) => ALPointers._alSourcePause_fnptr(source);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourcePausev</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void SourcePausev(int n, int* sources) => ALPointers._alSourcePausev_fnptr(n, sources);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourcePlay</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void SourcePlay(int source) => ALPointers._alSourcePlay_fnptr(source);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourcePlayv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void SourcePlayv(int n, int* sources) => ALPointers._alSourcePlayv_fnptr(n, sources);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourceQueueBuffers</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void SourceQueueBuffers(int source, int nb, int* buffers) => ALPointers._alSourceQueueBuffers_fnptr(source, nb, buffers);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourceRewind</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void SourceRewind(int source) => ALPointers._alSourceRewind_fnptr(source);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourceRewindv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void SourceRewindv(int n, int* sources) => ALPointers._alSourceRewindv_fnptr(n, sources);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourceStop</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void SourceStop(int source) => ALPointers._alSourceStop_fnptr(source);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourceStopv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void SourceStopv(int n, int* sources) => ALPointers._alSourceStopv_fnptr(n, sources);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSourceUnqueueBuffers</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void SourceUnqueueBuffers(int source, int nb, int* buffers) => ALPointers._alSourceUnqueueBuffers_fnptr(source, nb, buffers);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alSpeedOfSound</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void SpeedOfSound(float value) => ALPointers._alSpeedOfSound_fnptr(value);
        
        /// <summary>Creative extensions.</summary>
        public static unsafe partial class Creative
        {
            /// <summary> <b>[requires: EAX | EAX2.0 | EAX3.0 | EAX3.0EMULATED | EAX4.0 | EAX4.0EMULATED | EAX5.0]</b> <b>[entry point: <c>EAXGet</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX2.0.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX3.0.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX3.0EMULATED.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX4.0.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX4.0EMULATED.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX5.0.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static All EAXGet(Guid* property_get_id, uint property_id, uint source_id, void* value, uint value_size) => (All) ALPointers._EAXGet_fnptr(property_get_id, property_id, source_id, value, value_size);
            
            /// <summary> <b>[requires: EAX-RAM | EAX3.0 | EAX3.0EMULATED | EAX4.0 | EAX4.0EMULATED | EAX5.0]</b> <b>[entry point: <c>EAXGetBufferMode</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX-RAM.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX3.0.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX3.0EMULATED.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX4.0.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX4.0EMULATED.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX5.0.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static EAXBufferMode EAXGetBufferMode(int buffer, int* pReserved) => (EAXBufferMode) ALPointers._EAXGetBufferMode_fnptr(buffer, pReserved);
            
            /// <summary> <b>[requires: EAX | EAX2.0 | EAX3.0 | EAX3.0EMULATED | EAX4.0 | EAX4.0EMULATED | EAX5.0]</b> <b>[entry point: <c>EAXSet</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX2.0.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX3.0.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX3.0EMULATED.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX4.0.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX4.0EMULATED.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX5.0.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static All EAXSet(Guid* property_set_id, uint property_id, uint source_id, void* value, uint value_size) => (All) ALPointers._EAXSet_fnptr(property_set_id, property_id, source_id, value, value_size);
            
            /// <summary> <b>[requires: EAX-RAM | EAX3.0 | EAX3.0EMULATED | EAX4.0 | EAX4.0EMULATED | EAX5.0]</b> <b>[entry point: <c>EAXSetBufferMode</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX-RAM.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX3.0.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX3.0EMULATED.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX4.0.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX4.0EMULATED.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/EAX5.0.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool EAXSetBufferMode(int n, int* buffers, int value) => ALPointers._EAXSetBufferMode_fnptr(n, buffers, value) != 0;
            
        }
        /// <summary>EXT extensions.</summary>
        public static unsafe partial class EXT
        {
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>AttenuationScale_DirectLOKI</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void AttenuationScale_DirectLOKI(ALCContext context, float value) => ALPointers._AttenuationScale_DirectLOKI_fnptr((IntPtr)context, value);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alAuxiliaryEffectSlotf</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void AuxiliaryEffectSlotf(int effectslot, AuxEffectSlotPNameF param, float flValue) => ALPointers._alAuxiliaryEffectSlotf_fnptr(effectslot, (int)param, flValue);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alAuxiliaryEffectSlotfDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void AuxiliaryEffectSlotfDirect(ALCContext context, int effectslot, AuxEffectSlotPNameF param, float flValue) => ALPointers._alAuxiliaryEffectSlotfDirect_fnptr((IntPtr)context, effectslot, (int)param, flValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alAuxiliaryEffectSlotfv</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void AuxiliaryEffectSlotfv(int effectslot, AuxEffectSlotPNameFV param, float* pflValues) => ALPointers._alAuxiliaryEffectSlotfv_fnptr(effectslot, (int)param, pflValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alAuxiliaryEffectSlotfvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void AuxiliaryEffectSlotfvDirect(ALCContext context, int effectslot, AuxEffectSlotPNameFV param, float* pflValues) => ALPointers._alAuxiliaryEffectSlotfvDirect_fnptr((IntPtr)context, effectslot, (int)param, pflValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alAuxiliaryEffectSloti</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void AuxiliaryEffectSloti(int effectslot, AuxEffectSlotPNameI param, int iValue) => ALPointers._alAuxiliaryEffectSloti_fnptr(effectslot, (int)param, iValue);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alAuxiliaryEffectSlotiDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void AuxiliaryEffectSlotiDirect(ALCContext context, int effectslot, AuxEffectSlotPNameI param, int iValue) => ALPointers._alAuxiliaryEffectSlotiDirect_fnptr((IntPtr)context, effectslot, (int)param, iValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alAuxiliaryEffectSlotiv</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void AuxiliaryEffectSlotiv(int effectslot, AuxEffectSlotPNameIV param, int* piValues) => ALPointers._alAuxiliaryEffectSlotiv_fnptr(effectslot, (int)param, piValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alAuxiliaryEffectSlotivDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void AuxiliaryEffectSlotivDirect(ALCContext context, int effectslot, AuxEffectSlotPNameIV param, int* piValues) => ALPointers._alAuxiliaryEffectSlotivDirect_fnptr((IntPtr)context, effectslot, (int)param, piValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alBuffer3fDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Buffer3fDirect(ALCContext context, int buffer, BufferPName3F param, float value1, float value2, float value3) => ALPointers._alBuffer3fDirect_fnptr((IntPtr)context, buffer, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alBuffer3iDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Buffer3iDirect(ALCContext context, int buffer, BufferPName3I param, int value1, int value2, int value3) => ALPointers._alBuffer3iDirect_fnptr((IntPtr)context, buffer, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alBufferCallbackDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void BufferCallbackDirectSOFT(ALCContext context, int buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, void* userptr) => ALPointers._alBufferCallbackDirectSOFT_fnptr((IntPtr)context, buffer, (int)format, freq, callback, userptr);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alBufferDataDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void BufferDataDirect(ALCContext context, int buffer, Format format, void* data, int size, int samplerate) => ALPointers._alBufferDataDirect_fnptr((IntPtr)context, buffer, (int)format, data, size, samplerate);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>BufferDataWithCallback_DirectLOKI</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void BufferDataWithCallback_DirectLOKI(ALCContext context, int bid, delegate* unmanaged[Cdecl]<uint, uint, void*, All, uint, int> callback) => ALPointers._BufferDataWithCallback_DirectLOKI_fnptr((IntPtr)context, bid, callback);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alBufferfDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void BufferfDirect(ALCContext context, int buffer, BufferPNameF param, float value) => ALPointers._alBufferfDirect_fnptr((IntPtr)context, buffer, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alBufferfvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void BufferfvDirect(ALCContext context, int buffer, BufferPNameFV param, float* value) => ALPointers._alBufferfvDirect_fnptr((IntPtr)context, buffer, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alBufferiDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void BufferiDirect(ALCContext context, int buffer, BufferPNameI param, int value) => ALPointers._alBufferiDirect_fnptr((IntPtr)context, buffer, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alBufferivDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void BufferivDirect(ALCContext context, int buffer, BufferPNameIV param, int* value) => ALPointers._alBufferivDirect_fnptr((IntPtr)context, buffer, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alBufferSamplesDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void BufferSamplesDirectSOFT(ALCContext context, int buffer, uint samplerate, InternalFormat internalformat, int samples, Channels channels, SampleType type, void* data) => ALPointers._alBufferSamplesDirectSOFT_fnptr((IntPtr)context, buffer, samplerate, (int)internalformat, samples, (int)channels, (int)type, data);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alBufferSubDataDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void BufferSubDataDirectSOFT(ALCContext context, int buffer, Format format, void* data, int offset, int length) => ALPointers._alBufferSubDataDirectSOFT_fnptr((IntPtr)context, buffer, (int)format, data, offset, length);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alBufferSubSamplesDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void BufferSubSamplesDirectSOFT(ALCContext context, int buffer, int offset, int samples, Channels channels, SampleType type, void* data) => ALPointers._alBufferSubSamplesDirectSOFT_fnptr((IntPtr)context, buffer, offset, samples, (int)channels, (int)type, data);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alDebugMessageCallbackDirectEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DebugMessageCallbackDirectEXT(ALCContext context, delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, void* userParam) => ALPointers._alDebugMessageCallbackDirectEXT_fnptr((IntPtr)context, callback, userParam);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alDebugMessageCallbackEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_debug.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DebugMessageCallbackEXT(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, void* userParam) => ALPointers._alDebugMessageCallbackEXT_fnptr(callback, userParam);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alDebugMessageControlDirectEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DebugMessageControlDirectEXT(ALCContext context, DebugSource source, DebugType type, uint severity, int count, uint* ids, bool enable) => ALPointers._alDebugMessageControlDirectEXT_fnptr((IntPtr)context, (int)source, (int)type, severity, count, ids, (byte)(enable ? 1 : 0));
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alDebugMessageControlEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_debug.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DebugMessageControlEXT(DebugSource source, DebugType type, uint severity, int count, uint* ids, bool enable) => ALPointers._alDebugMessageControlEXT_fnptr((int)source, (int)type, severity, count, ids, (byte)(enable ? 1 : 0));
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alDebugMessageInsertDirectEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DebugMessageInsertDirectEXT(ALCContext context, DebugSource source, DebugType type, uint severity, int length, byte* message) => ALPointers._alDebugMessageInsertDirectEXT_fnptr((IntPtr)context, (int)source, (int)type, severity, length, message);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alDebugMessageInsertEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_debug.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DebugMessageInsertEXT(DebugSource source, DebugType type, uint severity, int length, byte* message) => ALPointers._alDebugMessageInsertEXT_fnptr((int)source, (int)type, severity, length, message);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alDeferUpdatesDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DeferUpdatesDirectSOFT(ALCContext context) => ALPointers._alDeferUpdatesDirectSOFT_fnptr((IntPtr)context);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alDeleteAuxiliaryEffectSlots</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DeleteAuxiliaryEffectSlots(int n, int* effectslots) => ALPointers._alDeleteAuxiliaryEffectSlots_fnptr(n, effectslots);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alDeleteAuxiliaryEffectSlotsDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DeleteAuxiliaryEffectSlotsDirect(ALCContext context, int n, int* effectslots) => ALPointers._alDeleteAuxiliaryEffectSlotsDirect_fnptr((IntPtr)context, n, effectslots);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alDeleteBuffersDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DeleteBuffersDirect(ALCContext context, int n, int* buffers) => ALPointers._alDeleteBuffersDirect_fnptr((IntPtr)context, n, buffers);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alDeleteEffects</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DeleteEffects(int n, int* effects) => ALPointers._alDeleteEffects_fnptr(n, effects);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alDeleteEffectsDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DeleteEffectsDirect(ALCContext context, int n, int* effects) => ALPointers._alDeleteEffectsDirect_fnptr((IntPtr)context, n, effects);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alDeleteFilters</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DeleteFilters(int n, int* filters) => ALPointers._alDeleteFilters_fnptr(n, filters);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alDeleteFiltersDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DeleteFiltersDirect(ALCContext context, int n, int* filters) => ALPointers._alDeleteFiltersDirect_fnptr((IntPtr)context, n, filters);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alDeleteSourcesDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DeleteSourcesDirect(ALCContext context, int n, int* sources) => ALPointers._alDeleteSourcesDirect_fnptr((IntPtr)context, n, sources);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alDisableDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DisableDirect(ALCContext context, EnableCap capability) => ALPointers._alDisableDirect_fnptr((IntPtr)context, (int)capability);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alDistanceModelDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DistanceModelDirect(ALCContext context, DistanceModel distanceModel) => ALPointers._alDistanceModelDirect_fnptr((IntPtr)context, (int)distanceModel);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alDopperFactorDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DopperFactorDirect(ALCContext context, float value) => ALPointers._alDopperFactorDirect_fnptr((IntPtr)context, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>EAXGetBufferModeDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static EAXBufferMode EAXGetBufferModeDirect(ALCContext context, int buffer, int* pReserved) => (EAXBufferMode) ALPointers._EAXGetBufferModeDirect_fnptr((IntPtr)context, buffer, pReserved);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>EAXGetDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static All EAXGetDirect(ALCContext context, Guid* property_get_id, uint property_id, uint source_id, void* value, uint value_size) => (All) ALPointers._EAXGetDirect_fnptr((IntPtr)context, property_get_id, property_id, source_id, value, value_size);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>EAXSetBufferModeDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool EAXSetBufferModeDirect(ALCContext context, int n, int* buffers, int value) => ALPointers._EAXSetBufferModeDirect_fnptr((IntPtr)context, n, buffers, value) != 0;
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>EAXSetDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static All EAXSetDirect(ALCContext context, Guid* property_set_id, uint property_id, uint source_id, void* value, uint value_size) => (All) ALPointers._EAXSetDirect_fnptr((IntPtr)context, property_set_id, property_id, source_id, value, value_size);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alEffectf</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Effectf(int effect, EffectPNameF param, float flValue) => ALPointers._alEffectf_fnptr(effect, (int)param, flValue);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alEffectfDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void EffectfDirect(ALCContext context, int effect, EffectPNameF param, float flValue) => ALPointers._alEffectfDirect_fnptr((IntPtr)context, effect, (int)param, flValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alEffectfv</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Effectfv(int effect, EffectPNameFV param, float* pflValues) => ALPointers._alEffectfv_fnptr(effect, (int)param, pflValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alEffectfvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void EffectfvDirect(ALCContext context, int effect, EffectPNameFV param, float* pflValues) => ALPointers._alEffectfvDirect_fnptr((IntPtr)context, effect, (int)param, pflValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alEffecti</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Effecti(int effect, EffectPNameI param, int iValue) => ALPointers._alEffecti_fnptr(effect, (int)param, iValue);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alEffectiDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void EffectiDirect(ALCContext context, int effect, EffectPNameI param, int iValue) => ALPointers._alEffectiDirect_fnptr((IntPtr)context, effect, (int)param, iValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alEffectiv</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Effectiv(int effect, EffectPNameIV param, int* piValues) => ALPointers._alEffectiv_fnptr(effect, (int)param, piValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alEffectivDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void EffectivDirect(ALCContext context, int effect, EffectPNameIV param, int* piValues) => ALPointers._alEffectivDirect_fnptr((IntPtr)context, effect, (int)param, piValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alEnableDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void EnableDirect(ALCContext context, EnableCap capability) => ALPointers._alEnableDirect_fnptr((IntPtr)context, (int)capability);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alEventCallbackDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void EventCallbackDirectSOFT(ALCContext context, delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, void* userParam) => ALPointers._alEventCallbackDirectSOFT_fnptr((IntPtr)context, callback, userParam);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alEventControlDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void EventControlDirectSOFT(ALCContext context, int count, EventType* types, bool enable) => ALPointers._alEventControlDirectSOFT_fnptr((IntPtr)context, count, (int*)types, (byte)(enable ? 1 : 0));
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alFilterf</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Filterf(int filter, FilterPNameF param, float flValue) => ALPointers._alFilterf_fnptr(filter, (int)param, flValue);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alFilterfDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void FilterfDirect(ALCContext context, int filter, FilterPNameF param, float flValue) => ALPointers._alFilterfDirect_fnptr((IntPtr)context, filter, (int)param, flValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alFilterfv</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Filterfv(int filter, FilterPNameFV param, float* pflValues) => ALPointers._alFilterfv_fnptr(filter, (int)param, pflValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alFilterfvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void FilterfvDirect(ALCContext context, int filter, FilterPNameFV param, float* pflValues) => ALPointers._alFilterfvDirect_fnptr((IntPtr)context, filter, (int)param, pflValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alFilteri</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Filteri(int filter, FilterPNameI param, int iValue) => ALPointers._alFilteri_fnptr(filter, (int)param, iValue);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alFilteriDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void FilteriDirect(ALCContext context, int filter, FilterPNameI param, int iValue) => ALPointers._alFilteriDirect_fnptr((IntPtr)context, filter, (int)param, iValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alFilteriv</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Filteriv(int filter, FilterPNameIV param, int* piValues) => ALPointers._alFilteriv_fnptr(filter, (int)param, piValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alFilterivDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void FilterivDirect(ALCContext context, int filter, FilterPNameIV param, int* piValues) => ALPointers._alFilterivDirect_fnptr((IntPtr)context, filter, (int)param, piValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGenAuxiliaryEffectSlots</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GenAuxiliaryEffectSlots(int n, int* effectslots) => ALPointers._alGenAuxiliaryEffectSlots_fnptr(n, effectslots);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGenAuxiliaryEffectSlotsDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GenAuxiliaryEffectSlotsDirect(ALCContext context, int n, int* effectslots) => ALPointers._alGenAuxiliaryEffectSlotsDirect_fnptr((IntPtr)context, n, effectslots);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGenBuffersDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GenBuffersDirect(ALCContext context, int n, int* buffers) => ALPointers._alGenBuffersDirect_fnptr((IntPtr)context, n, buffers);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGenEffects</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GenEffects(int n, int* effects) => ALPointers._alGenEffects_fnptr(n, effects);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGenEffectsDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GenEffectsDirect(ALCContext context, int n, int* effects) => ALPointers._alGenEffectsDirect_fnptr((IntPtr)context, n, effects);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGenFilters</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GenFilters(int n, int* filters) => ALPointers._alGenFilters_fnptr(n, filters);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGenFiltersDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GenFiltersDirect(ALCContext context, int n, int* filters) => ALPointers._alGenFiltersDirect_fnptr((IntPtr)context, n, filters);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGenSourcesDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GenSourcesDirect(ALCContext context, int n, int* sources) => ALPointers._alGenSourcesDirect_fnptr((IntPtr)context, n, sources);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetAuxiliaryEffectSlotf</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetAuxiliaryEffectSlotf(int effectslot, AuxEffectSlotGetPNameF param, float* pflValue) => ALPointers._alGetAuxiliaryEffectSlotf_fnptr(effectslot, (int)param, pflValue);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetAuxiliaryEffectSlotfDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetAuxiliaryEffectSlotfDirect(ALCContext context, int effectslot, AuxEffectSlotGetPNameF param, float* pflValue) => ALPointers._alGetAuxiliaryEffectSlotfDirect_fnptr((IntPtr)context, effectslot, (int)param, pflValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetAuxiliaryEffectSlotfv</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetAuxiliaryEffectSlotfv(int effectslot, AuxEffectSlotGetPNameFV param, float* pflValues) => ALPointers._alGetAuxiliaryEffectSlotfv_fnptr(effectslot, (int)param, pflValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetAuxiliaryEffectSlotfvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetAuxiliaryEffectSlotfvDirect(ALCContext context, int effectslot, AuxEffectSlotGetPNameFV param, float* pflValues) => ALPointers._alGetAuxiliaryEffectSlotfvDirect_fnptr((IntPtr)context, effectslot, (int)param, pflValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetAuxiliaryEffectSloti</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetAuxiliaryEffectSloti(int effectslot, AuxEffectSlotGetPNameI param, int* piValue) => ALPointers._alGetAuxiliaryEffectSloti_fnptr(effectslot, (int)param, piValue);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetAuxiliaryEffectSlotiDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetAuxiliaryEffectSlotiDirect(ALCContext context, int effectslot, AuxEffectSlotGetPNameI param, int* piValue) => ALPointers._alGetAuxiliaryEffectSlotiDirect_fnptr((IntPtr)context, effectslot, (int)param, piValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetAuxiliaryEffectSlotiv</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetAuxiliaryEffectSlotiv(int effectslot, AuxEffectSlotGetPNameIV param, int* piValues) => ALPointers._alGetAuxiliaryEffectSlotiv_fnptr(effectslot, (int)param, piValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetAuxiliaryEffectSlotivDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetAuxiliaryEffectSlotivDirect(ALCContext context, int effectslot, AuxEffectSlotGetPNameIV param, int* piValues) => ALPointers._alGetAuxiliaryEffectSlotivDirect_fnptr((IntPtr)context, effectslot, (int)param, piValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetBooleanDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool GetBooleanDirect(ALCContext context, GetPNameB param) => ALPointers._alGetBooleanDirect_fnptr((IntPtr)context, (int)param) != 0;
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetBooleanvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetBooleanvDirect(ALCContext context, GetPNameBV param, bool* values) => ALPointers._alGetBooleanvDirect_fnptr((IntPtr)context, (int)param, (byte*)values);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetBuffer3fDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetBuffer3fDirect(ALCContext context, int buffer, BufferGetPName3F param, float* value1, float* value2, float* value3) => ALPointers._alGetBuffer3fDirect_fnptr((IntPtr)context, buffer, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetBuffer3iDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetBuffer3iDirect(ALCContext context, int buffer, BufferGetPName3I param, int* value1, int* value2, int* value3) => ALPointers._alGetBuffer3iDirect_fnptr((IntPtr)context, buffer, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetBuffer3PtrDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetBuffer3PtrDirectSOFT(ALCContext context, int buffer, BufferGetPName3Ptr param, void** ptr0, void** ptr1, void** ptr2) => ALPointers._alGetBuffer3PtrDirectSOFT_fnptr((IntPtr)context, buffer, (int)param, ptr0, ptr1, ptr2);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetBufferfDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetBufferfDirect(ALCContext context, int buffer, BufferGetPNameF param, float* value) => ALPointers._alGetBufferfDirect_fnptr((IntPtr)context, buffer, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetBufferfvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetBufferfvDirect(ALCContext context, int buffer, BufferGetPNameFV param, float* value) => ALPointers._alGetBufferfvDirect_fnptr((IntPtr)context, buffer, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetBufferiDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetBufferiDirect(ALCContext context, int buffer, BufferGetPNameI param, int* value) => ALPointers._alGetBufferiDirect_fnptr((IntPtr)context, buffer, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetBufferivDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetBufferivDirect(ALCContext context, int buffer, BufferGetPNameIV param, int* value) => ALPointers._alGetBufferivDirect_fnptr((IntPtr)context, buffer, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetBufferPtrDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetBufferPtrDirectSOFT(ALCContext context, int buffer, BufferGetPNamePtr param, void** ptr) => ALPointers._alGetBufferPtrDirectSOFT_fnptr((IntPtr)context, buffer, (int)param, ptr);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetBufferPtrvDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetBufferPtrvDirectSOFT(ALCContext context, int buffer, BufferGetPNamePtrV param, void** ptr) => ALPointers._alGetBufferPtrvDirectSOFT_fnptr((IntPtr)context, buffer, (int)param, ptr);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetBufferSamplesDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetBufferSamplesDirectSOFT(ALCContext context, int buffer, int offset, int samples, Channels channels, SampleType type, void* data) => ALPointers._alGetBufferSamplesDirectSOFT_fnptr((IntPtr)context, buffer, offset, samples, (int)channels, (int)type, data);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetDebugMessageLogDirectEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static uint GetDebugMessageLogDirectEXT(ALCContext context, uint count, int logBufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* logBuf) => ALPointers._alGetDebugMessageLogDirectEXT_fnptr((IntPtr)context, count, logBufSize, (int*)sources, (int*)types, ids, (int*)severities, lengths, logBuf);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alGetDebugMessageLogEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_debug.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static uint GetDebugMessageLogEXT(uint count, int logBufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* logBuf) => ALPointers._alGetDebugMessageLogEXT_fnptr(count, logBufSize, (int*)sources, (int*)types, ids, (int*)severities, lengths, logBuf);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetDoubleDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static double GetDoubleDirect(ALCContext context, GetPNameD param) => ALPointers._alGetDoubleDirect_fnptr((IntPtr)context, (int)param);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetDoublevDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetDoublevDirect(ALCContext context, GetPNameDV param, double* values) => ALPointers._alGetDoublevDirect_fnptr((IntPtr)context, (int)param, values);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetEffectf</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetEffectf(int effect, EffectGetPNameF param, float* pflValue) => ALPointers._alGetEffectf_fnptr(effect, (int)param, pflValue);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetEffectfDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetEffectfDirect(ALCContext context, int effect, EffectGetPNameF param, float* pflValue) => ALPointers._alGetEffectfDirect_fnptr((IntPtr)context, effect, (int)param, pflValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetEffectfv</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetEffectfv(int effect, EffectGetPNameFV param, float* pflValues) => ALPointers._alGetEffectfv_fnptr(effect, (int)param, pflValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetEffectfvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetEffectfvDirect(ALCContext context, int effect, EffectGetPNameFV param, float* pflValues) => ALPointers._alGetEffectfvDirect_fnptr((IntPtr)context, effect, (int)param, pflValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetEffecti</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetEffecti(int effect, EffectGetPNameI param, int* piValue) => ALPointers._alGetEffecti_fnptr(effect, (int)param, piValue);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetEffectiDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetEffectiDirect(ALCContext context, int effect, EffectGetPNameI param, int* piValue) => ALPointers._alGetEffectiDirect_fnptr((IntPtr)context, effect, (int)param, piValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetEffectiv</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetEffectiv(int effect, EffectGetPNameIV param, int* piValues) => ALPointers._alGetEffectiv_fnptr(effect, (int)param, piValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetEffectivDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetEffectivDirect(ALCContext context, int effect, EffectGetPNameIV param, int* piValues) => ALPointers._alGetEffectivDirect_fnptr((IntPtr)context, effect, (int)param, piValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetEnumValueDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static All GetEnumValueDirect(ALCContext context, byte* ename) => (All) ALPointers._alGetEnumValueDirect_fnptr((IntPtr)context, ename);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetErrorDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static ErrorCode GetErrorDirect(ALCContext context) => (ErrorCode) ALPointers._alGetErrorDirect_fnptr((IntPtr)context);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetFilterf</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetFilterf(int filter, FilterGetPNameF param, float* pflValue) => ALPointers._alGetFilterf_fnptr(filter, (int)param, pflValue);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetFilterfDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetFilterfDirect(ALCContext context, int filter, FilterGetPNameF param, float* pflValue) => ALPointers._alGetFilterfDirect_fnptr((IntPtr)context, filter, (int)param, pflValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetFilterfv</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetFilterfv(int filter, FilterGetPNameFV param, float* pflValues) => ALPointers._alGetFilterfv_fnptr(filter, (int)param, pflValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetFilterfvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetFilterfvDirect(ALCContext context, int filter, FilterGetPNameFV param, float* pflValues) => ALPointers._alGetFilterfvDirect_fnptr((IntPtr)context, filter, (int)param, pflValues);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetFilteri</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetFilteri(int filter, FilterGetPNameI param, int* piValue) => ALPointers._alGetFilteri_fnptr(filter, (int)param, piValue);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetFilteriDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetFilteriDirect(ALCContext context, int filter, FilterGetPNameI param, int* piValue) => ALPointers._alGetFilteriDirect_fnptr((IntPtr)context, filter, (int)param, piValue);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alGetFilteriv</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetFilteriv(int filter, FilterGetPNameIV param, int* piValues) => ALPointers._alGetFilteriv_fnptr(filter, (int)param, piValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetFilterivDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetFilterivDirect(ALCContext context, int filter, FilterGetPNameIV param, int* piValues) => ALPointers._alGetFilterivDirect_fnptr((IntPtr)context, filter, (int)param, piValues);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetFloatDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static float GetFloatDirect(ALCContext context, GetPNameF param) => ALPointers._alGetFloatDirect_fnptr((IntPtr)context, (int)param);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetFloatvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetFloatvDirect(ALCContext context, GetPNameFV param, float* values) => ALPointers._alGetFloatvDirect_fnptr((IntPtr)context, (int)param, values);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetIntegerDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static int GetIntegerDirect(ALCContext context, GetPNameI param) => ALPointers._alGetIntegerDirect_fnptr((IntPtr)context, (int)param);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetIntegervDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetIntegervDirect(ALCContext context, GetPNameIV param, int* values) => ALPointers._alGetIntegervDirect_fnptr((IntPtr)context, (int)param, values);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetListener3fDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetListener3fDirect(ALCContext context, ListenerGetPName3F param, float* value1, float* value2, float* value3) => ALPointers._alGetListener3fDirect_fnptr((IntPtr)context, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetListener3iDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetListener3iDirect(ALCContext context, ListenerGetPName3I param, int* value1, int* value2, int* value3) => ALPointers._alGetListener3iDirect_fnptr((IntPtr)context, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetListenerfDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetListenerfDirect(ALCContext context, ListenerGetPNameF param, float* value) => ALPointers._alGetListenerfDirect_fnptr((IntPtr)context, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetListenerfvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetListenerfvDirect(ALCContext context, ListenerGetPNameFV param, float* values) => ALPointers._alGetListenerfvDirect_fnptr((IntPtr)context, (int)param, values);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetListeneriDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetListeneriDirect(ALCContext context, ListenerGetPNameI param, int* value) => ALPointers._alGetListeneriDirect_fnptr((IntPtr)context, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetListenerivDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetListenerivDirect(ALCContext context, ListenerGetPNameIV param, int* values) => ALPointers._alGetListenerivDirect_fnptr((IntPtr)context, (int)param, values);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetObjectLabelDirectEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetObjectLabelDirectEXT(ALCContext context, ObjectType identifier, uint name, int bufSize, int* length, byte* label) => ALPointers._alGetObjectLabelDirectEXT_fnptr((IntPtr)context, (int)identifier, name, bufSize, length, label);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alGetObjectLabelEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_debug.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetObjectLabelEXT(ObjectType identifier, uint name, int bufSize, int* length, byte* label) => ALPointers._alGetObjectLabelEXT_fnptr((int)identifier, name, bufSize, length, label);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetPointerDirectEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void* GetPointerDirectEXT(ALCContext context, GetPNamePtr pname) => ALPointers._alGetPointerDirectEXT_fnptr((IntPtr)context, (int)pname);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetPointerDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void* GetPointerDirectSOFT(ALCContext context, GetPNamePtr pname) => ALPointers._alGetPointerDirectSOFT_fnptr((IntPtr)context, (int)pname);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alGetPointerEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_debug.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void* GetPointerEXT(GetPNamePtr pname) => ALPointers._alGetPointerEXT_fnptr((int)pname);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetPointervDirectEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetPointervDirectEXT(ALCContext context, GetPNamePtr pname, void** values) => ALPointers._alGetPointervDirectEXT_fnptr((IntPtr)context, (int)pname, values);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetPointervDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetPointervDirectSOFT(ALCContext context, GetPNamePtrV pname, void** values) => ALPointers._alGetPointervDirectSOFT_fnptr((IntPtr)context, (int)pname, values);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alGetPointervEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_debug.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetPointervEXT(GetPNamePtr pname, void** values) => ALPointers._alGetPointervEXT_fnptr((int)pname, values);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetProcAddressDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void* GetProcAddressDirect(ALCContext context, byte* fname) => ALPointers._alGetProcAddressDirect_fnptr((IntPtr)context, fname);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetSource3dDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSource3dDirectSOFT(ALCContext context, int source, SourceGetPName3D param, double* value1, double* value2, double* value3) => ALPointers._alGetSource3dDirectSOFT_fnptr((IntPtr)context, source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetSource3fDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSource3fDirect(ALCContext context, int source, SourceGetPName3F param, float* value1, float* value2, float* value3) => ALPointers._alGetSource3fDirect_fnptr((IntPtr)context, source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetSource3i64DirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSource3i64DirectSOFT(ALCContext context, int source, SourceGetPName3I64 param, long* value1, long* value2, long* value3) => ALPointers._alGetSource3i64DirectSOFT_fnptr((IntPtr)context, source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetSource3iDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSource3iDirect(ALCContext context, int source, SourceGetPName3I param, int* value1, int* value2, int* value3) => ALPointers._alGetSource3iDirect_fnptr((IntPtr)context, source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetSourcedDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSourcedDirectSOFT(ALCContext context, int source, SourceGetPNameD param, double* value) => ALPointers._alGetSourcedDirectSOFT_fnptr((IntPtr)context, source, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetSourcedvDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSourcedvDirectSOFT(ALCContext context, int source, SourceGetPNameDV param, double* values) => ALPointers._alGetSourcedvDirectSOFT_fnptr((IntPtr)context, source, (int)param, values);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetSourcefDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSourcefDirect(ALCContext context, int source, SourceGetPNameF param, float* value) => ALPointers._alGetSourcefDirect_fnptr((IntPtr)context, source, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetSourcefvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSourcefvDirect(ALCContext context, int source, SourceGetPNameFV param, float* values) => ALPointers._alGetSourcefvDirect_fnptr((IntPtr)context, source, (int)param, values);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetSourcei64DirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSourcei64DirectSOFT(ALCContext context, int source, SourceGetPNameI64 param, long* value) => ALPointers._alGetSourcei64DirectSOFT_fnptr((IntPtr)context, source, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetSourcei64vDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSourcei64vDirectSOFT(ALCContext context, int source, SourceGetPNameI64V param, long* values) => ALPointers._alGetSourcei64vDirectSOFT_fnptr((IntPtr)context, source, (int)param, values);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetSourceiDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSourceiDirect(ALCContext context, int source, SourceGetPNameI param, int* value) => ALPointers._alGetSourceiDirect_fnptr((IntPtr)context, source, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetSourceivDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSourceivDirect(ALCContext context, int source, SourceGetPNameIV param, int* values) => ALPointers._alGetSourceivDirect_fnptr((IntPtr)context, source, (int)param, values);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetStringDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static byte* GetStringDirect_(ALCContext context, StringName param) => ALPointers._alGetStringDirect_fnptr((IntPtr)context, (int)param);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alGetStringiDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static byte* GetStringiDirectSOFT_(ALCContext context, IndexedStringName pname, int index) => ALPointers._alGetStringiDirectSOFT_fnptr((IntPtr)context, (int)pname, index);
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alIsAuxiliaryEffectSlot</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void IsAuxiliaryEffectSlot(int effectslot) => ALPointers._alIsAuxiliaryEffectSlot_fnptr(effectslot);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alIsAuxiliaryEffectSlotDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void IsAuxiliaryEffectSlotDirect(ALCContext context, int effectslot) => ALPointers._alIsAuxiliaryEffectSlotDirect_fnptr((IntPtr)context, effectslot);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alIsBufferDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool IsBufferDirect(ALCContext context, int buffer) => ALPointers._alIsBufferDirect_fnptr((IntPtr)context, buffer) != 0;
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alIsBufferFormatSupportedDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool IsBufferFormatSupportedDirectSOFT(ALCContext context, InternalFormat format) => ALPointers._alIsBufferFormatSupportedDirectSOFT_fnptr((IntPtr)context, (int)format) != 0;
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alIsEffect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool IsEffect(int effect) => ALPointers._alIsEffect_fnptr(effect) != 0;
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alIsEffectDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool IsEffectDirect(ALCContext context, int effect) => ALPointers._alIsEffectDirect_fnptr((IntPtr)context, effect) != 0;
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alIsEnabledDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool IsEnabledDirect(ALCContext context, EnableCap capability) => ALPointers._alIsEnabledDirect_fnptr((IntPtr)context, (int)capability) != 0;
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alIsExtensionPresentDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool IsExtensionPresentDirect(ALCContext context, byte* extname) => ALPointers._alIsExtensionPresentDirect_fnptr((IntPtr)context, extname) != 0;
            
            /// <summary> <b>[requires: ALC_EXT_EFX]</b> <b>[entry point: <c>alIsFilter</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_EFX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void IsFilter(int filter) => ALPointers._alIsFilter_fnptr(filter);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alIsFilterDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void IsFilterDirect(ALCContext context, int filter) => ALPointers._alIsFilterDirect_fnptr((IntPtr)context, filter);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alIsSourceDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool IsSourceDirect(ALCContext context, int source) => ALPointers._alIsSourceDirect_fnptr((IntPtr)context, source) != 0;
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alListener3fDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Listener3fDirect(ALCContext context, ListenerPName3F param, float value1, float value2, float value3) => ALPointers._alListener3fDirect_fnptr((IntPtr)context, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alListener3iDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Listener3iDirect(ALCContext context, ListenerPName3I param, int value1, int value2, int value3) => ALPointers._alListener3iDirect_fnptr((IntPtr)context, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alListenerfDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void ListenerfDirect(ALCContext context, ListenerPNameF param, float value) => ALPointers._alListenerfDirect_fnptr((IntPtr)context, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alListenerfvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void ListenerfvDirect(ALCContext context, ListenerPNameFV param, float* values) => ALPointers._alListenerfvDirect_fnptr((IntPtr)context, (int)param, values);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alListeneriDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void ListeneriDirect(ALCContext context, ListenerPNameI param, int value) => ALPointers._alListeneriDirect_fnptr((IntPtr)context, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alListenerivDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void ListenerivDirect(ALCContext context, ListenerPNameIV param, int* values) => ALPointers._alListenerivDirect_fnptr((IntPtr)context, (int)param, values);
            
            /// <summary> <b>[requires: ALC_EXT_MAC_OSX]</b> <b>[entry point: <c>alMacOSXGetRenderChannelCount</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_MAC_OSX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static int MacOSXGetRenderChannelCount() => ALPointers._alMacOSXGetRenderChannelCount_fnptr();
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alMacOSXGetRenderChannelCountDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static int MacOSXGetRenderChannelCountDirect(ALCContext context) => ALPointers._alMacOSXGetRenderChannelCountDirect_fnptr((IntPtr)context);
            
            /// <summary> <b>[requires: ALC_EXT_MAC_OSX]</b> <b>[entry point: <c>alMacOSXRenderChannelCount</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/ALC_EXT_MAC_OSX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void MacOSXRenderChannelCount(int value) => ALPointers._alMacOSXRenderChannelCount_fnptr(value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alMacOSXRenderChannelCountDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void MacOSXRenderChannelCountDirect(ALCContext context, int value) => ALPointers._alMacOSXRenderChannelCountDirect_fnptr((IntPtr)context, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alObjectLabelDirectEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void ObjectLabelDirectEXT(ALCContext context, ObjectType identifier, uint name, int length, byte* label) => ALPointers._alObjectLabelDirectEXT_fnptr((IntPtr)context, (int)identifier, name, length, label);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alObjectLabelEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_debug.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void ObjectLabelEXT(ObjectType identifier, uint name, int length, byte* label) => ALPointers._alObjectLabelEXT_fnptr((int)identifier, name, length, label);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alPopDebugGroupDirectEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void PopDebugGroupDirectEXT(ALCContext context) => ALPointers._alPopDebugGroupDirectEXT_fnptr((IntPtr)context);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alPopDebugGroupEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_debug.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void PopDebugGroupEXT() => ALPointers._alPopDebugGroupEXT_fnptr();
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alProcessUpdatesDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void ProcessUpdatesDirectSOFT(ALCContext context) => ALPointers._alProcessUpdatesDirectSOFT_fnptr((IntPtr)context);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alPushDebugGroupDirectEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void PushDebugGroupDirectEXT(ALCContext context, DebugSource source, uint id, int length, byte* message) => ALPointers._alPushDebugGroupDirectEXT_fnptr((IntPtr)context, (int)source, id, length, message);
            
            /// <summary> <b>[requires: AL_EXT_debug]</b> <b>[entry point: <c>alPushDebugGroupEXT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_debug.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void PushDebugGroupEXT(DebugSource source, uint id, int length, byte* message) => ALPointers._alPushDebugGroupEXT_fnptr((int)source, id, length, message);
            
            /// <summary> <b>[requires: AL_EXT_FOLDBACK]</b> <b>[entry point: <c>alRequestFoldbackStart</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_FOLDBACK.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void RequestFoldbackStart(FoldbackMode foldbackMode, int blockCount, int blockLength, float* bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback) => ALPointers._alRequestFoldbackStart_fnptr((int)foldbackMode, blockCount, blockLength, bufferMemory, callback);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alRequestFoldbackStartDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void RequestFoldbackStartDirect(ALCContext context, FoldbackMode foldbackMode, int blockCount, int blockLength, float* bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback) => ALPointers._alRequestFoldbackStartDirect_fnptr((IntPtr)context, (int)foldbackMode, blockCount, blockLength, bufferMemory, callback);
            
            /// <summary> <b>[requires: AL_EXT_FOLDBACK]</b> <b>[entry point: <c>alRequestFoldbackStop</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_FOLDBACK.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void RequestFoldbackStop() => ALPointers._alRequestFoldbackStop_fnptr();
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alRequestFoldbackStopDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void RequestFoldbackStopDirect(ALCContext context) => ALPointers._alRequestFoldbackStopDirect_fnptr((IntPtr)context);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSource3dDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Source3dDirectSOFT(ALCContext context, int source, SourcePName3D param, double value1, double value2, double value3) => ALPointers._alSource3dDirectSOFT_fnptr((IntPtr)context, source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSource3fDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Source3fDirect(ALCContext context, int source, SourcePName3F param, float value1, float value2, float value3) => ALPointers._alSource3fDirect_fnptr((IntPtr)context, source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSource3i64DirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Source3i64DirectSOFT(ALCContext context, int source, SourcePName3I64 param, long value1, long value2, long value3) => ALPointers._alSource3i64DirectSOFT_fnptr((IntPtr)context, source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSource3iDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Source3iDirect(ALCContext context, int source, SourcePName3I param, int value1, int value2, int value3) => ALPointers._alSource3iDirect_fnptr((IntPtr)context, source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_EXT_SOURCE_NOTIFICATIONS]</b> <b>[entry point: <c>alSourceAddNotification</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_SOURCE_NOTIFICATIONS.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static ErrorCode SourceAddNotification(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, void* userData) => (ErrorCode) ALPointers._alSourceAddNotification_fnptr(sid, notificationID, notifyProc, userData);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourceAddNotificationDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static ErrorCode SourceAddNotificationDirect(ALCContext context, int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, void* userData) => (ErrorCode) ALPointers._alSourceAddNotificationDirect_fnptr((IntPtr)context, sid, notificationID, notifyProc, userData);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourcedDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourcedDirectSOFT(ALCContext context, int source, SourcePNameD param, double value) => ALPointers._alSourcedDirectSOFT_fnptr((IntPtr)context, source, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourcedvDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourcedvDirectSOFT(ALCContext context, int source, SourcePNameDV param, double* values) => ALPointers._alSourcedvDirectSOFT_fnptr((IntPtr)context, source, (int)param, values);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourcefDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourcefDirect(ALCContext context, int source, SourcePNameF param, float value) => ALPointers._alSourcefDirect_fnptr((IntPtr)context, source, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourcefvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourcefvDirect(ALCContext context, int source, SourcePNameFV param, float* value) => ALPointers._alSourcefvDirect_fnptr((IntPtr)context, source, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_SOURCE_SPATIALIZATION]</b> <b>[entry point: <c>alSourceGetRenderingQuality</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_SOURCE_SPATIALIZATION.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static int SourceGetRenderingQuality(int sid) => ALPointers._alSourceGetRenderingQuality_fnptr(sid);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourceGetRenderingQualityDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static int SourceGetRenderingQualityDirect(ALCContext context, int sid) => ALPointers._alSourceGetRenderingQualityDirect_fnptr((IntPtr)context, sid);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourcei64DirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Sourcei64DirectSOFT(ALCContext context, int source, SourcePNameI64 param, long value) => ALPointers._alSourcei64DirectSOFT_fnptr((IntPtr)context, source, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourcei64vDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Sourcei64vDirectSOFT(ALCContext context, int source, SourcePNameI64V param, long* values) => ALPointers._alSourcei64vDirectSOFT_fnptr((IntPtr)context, source, (int)param, values);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourceiDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourceiDirect(ALCContext context, int source, SourcePNameI param, int value) => ALPointers._alSourceiDirect_fnptr((IntPtr)context, source, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourceivDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourceivDirect(ALCContext context, int source, SourcePNameIV param, int* value) => ALPointers._alSourceivDirect_fnptr((IntPtr)context, source, (int)param, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourcePauseDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourcePauseDirect(ALCContext context, int source) => ALPointers._alSourcePauseDirect_fnptr((IntPtr)context, source);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourcePausevDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourcePausevDirect(ALCContext context, int n, int* sources) => ALPointers._alSourcePausevDirect_fnptr((IntPtr)context, n, sources);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourcePlayAtTimeDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourcePlayAtTimeDirectSOFT(ALCContext context, int source, long start_time) => ALPointers._alSourcePlayAtTimeDirectSOFT_fnptr((IntPtr)context, source, start_time);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourcePlayAtTimevDirectSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourcePlayAtTimevDirectSOFT(ALCContext context, int n, int* sources, long start_time) => ALPointers._alSourcePlayAtTimevDirectSOFT_fnptr((IntPtr)context, n, sources, start_time);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourcePlayDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourcePlayDirect(ALCContext context, int source) => ALPointers._alSourcePlayDirect_fnptr((IntPtr)context, source);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourcePlayvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourcePlayvDirect(ALCContext context, int n, int* sources) => ALPointers._alSourcePlayvDirect_fnptr((IntPtr)context, n, sources);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourceQueueBuffersDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourceQueueBuffersDirect(ALCContext context, int source, int nb, int* buffers) => ALPointers._alSourceQueueBuffersDirect_fnptr((IntPtr)context, source, nb, buffers);
            
            /// <summary> <b>[requires: AL_EXT_SOURCE_NOTIFICATIONS]</b> <b>[entry point: <c>alSourceRemoveNotification</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_SOURCE_NOTIFICATIONS.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourceRemoveNotification(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, void* userData) => ALPointers._alSourceRemoveNotification_fnptr(sid, notificationID, notifyProc, userData);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourceRemoveNotificationDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourceRemoveNotificationDirect(ALCContext context, int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, void* userData) => ALPointers._alSourceRemoveNotificationDirect_fnptr((IntPtr)context, sid, notificationID, notifyProc, userData);
            
            /// <summary> <b>[requires: AL_EXT_SOURCE_SPATIALIZATION]</b> <b>[entry point: <c>alSourceRenderingQuality</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_SOURCE_SPATIALIZATION.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourceRenderingQuality(int sid, int value) => ALPointers._alSourceRenderingQuality_fnptr(sid, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourceRenderingQualityDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourceRenderingQualityDirect(ALCContext context, int sid, int value) => ALPointers._alSourceRenderingQualityDirect_fnptr((IntPtr)context, sid, value);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourceRewindDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourceRewindDirect(ALCContext context, int source) => ALPointers._alSourceRewindDirect_fnptr((IntPtr)context, source);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourceRewindvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourceRewindvDirect(ALCContext context, int n, int* sources) => ALPointers._alSourceRewindvDirect_fnptr((IntPtr)context, n, sources);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourceStopDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourceStopDirect(ALCContext context, int source) => ALPointers._alSourceStopDirect_fnptr((IntPtr)context, source);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourceStopvDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourceStopvDirect(ALCContext context, int n, int* sources) => ALPointers._alSourceStopvDirect_fnptr((IntPtr)context, n, sources);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSourceUnqueueBuffersDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourceUnqueueBuffersDirect(ALCContext context, int source, int nb, int* buffers) => ALPointers._alSourceUnqueueBuffersDirect_fnptr((IntPtr)context, source, nb, buffers);
            
            /// <summary> <b>[requires: AL_EXT_direct_context]</b> <b>[entry point: <c>alSpeedOfSoundDirect</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SpeedOfSoundDirect(ALCContext context, float value) => ALPointers._alSpeedOfSoundDirect_fnptr((IntPtr)context, value);
            
        }
        /// <summary>LOKI extensions.</summary>
        public static unsafe partial class LOKI
        {
            /// <summary> <b>[requires: AL_LOKI_attenuation_scale]</b> <b>[entry point: <c>AttenuationScale_LOKI</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_LOKI_attenuation_scale.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void AttenuationScale_LOKI(float value) => ALPointers._AttenuationScale_LOKI_fnptr(value);
            
            /// <summary> <b>[requires: AL_LOKI_buffer_data_callback]</b> <b>[entry point: <c>BufferDataWithCallback_LOKI</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_LOKI_buffer_data_callback.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void BufferDataWithCallback_LOKI(int bid, delegate* unmanaged[Cdecl]<uint, uint, void*, All, uint, int> callback) => ALPointers._BufferDataWithCallback_LOKI_fnptr(bid, callback);
            
        }
        /// <summary>SOFT extensions.</summary>
        public static unsafe partial class SOFT
        {
            /// <summary> <b>[requires: AL_SOFT_callback_buffer]</b> <b>[entry point: <c>alBufferCallbackSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_callback_buffer.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void BufferCallbackSOFT(int buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, void* userptr) => ALPointers._alBufferCallbackSOFT_fnptr(buffer, (int)format, freq, callback, userptr);
            
            /// <summary> <b>[requires: AL_SOFT_buffer_samples]</b> <b>[entry point: <c>alBufferSamplesSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_buffer_samples.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void BufferSamplesSOFT(int buffer, uint samplerate, InternalFormat internalformat, int samples, Channels channels, SampleType type, void* data) => ALPointers._alBufferSamplesSOFT_fnptr(buffer, samplerate, (int)internalformat, samples, (int)channels, (int)type, data);
            
            /// <summary> <b>[requires: AL_SOFT_buffer_sub_data]</b> <b>[entry point: <c>alBufferSubDataSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_buffer_sub_data.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void BufferSubDataSOFT(int buffer, Format format, void* data, int offset, int length) => ALPointers._alBufferSubDataSOFT_fnptr(buffer, (int)format, data, offset, length);
            
            /// <summary> <b>[requires: AL_SOFT_buffer_samples]</b> <b>[entry point: <c>alBufferSubSamplesSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_buffer_samples.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void BufferSubSamplesSOFT(int buffer, int offset, int samples, Channels channels, SampleType type, void* data) => ALPointers._alBufferSubSamplesSOFT_fnptr(buffer, offset, samples, (int)channels, (int)type, data);
            
            /// <summary> <b>[requires: AL_SOFT_deferred_updates]</b> <b>[entry point: <c>alDeferUpdatesSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_deferred_updates.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DeferUpdatesSOFT() => ALPointers._alDeferUpdatesSOFT_fnptr();
            
            /// <summary> <b>[requires: AL_SOFT_events]</b> <b>[entry point: <c>alEventCallbackSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_events.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void EventCallbackSOFT(delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, void* userParam) => ALPointers._alEventCallbackSOFT_fnptr(callback, userParam);
            
            /// <summary> <b>[requires: AL_SOFT_events]</b> <b>[entry point: <c>alEventControlSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_events.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void EventControlSOFT(int count, EventType* types, bool enable) => ALPointers._alEventControlSOFT_fnptr(count, (int*)types, (byte)(enable ? 1 : 0));
            
            /// <summary> <b>[requires: AL_SOFT_callback_buffer]</b> <b>[entry point: <c>alGetBuffer3PtrSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_callback_buffer.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetBuffer3PtrSOFT(int buffer, BufferGetPName3Ptr param, void** ptr0, void** ptr1, void** ptr2) => ALPointers._alGetBuffer3PtrSOFT_fnptr(buffer, (int)param, ptr0, ptr1, ptr2);
            
            /// <summary> <b>[requires: AL_SOFT_callback_buffer]</b> <b>[entry point: <c>alGetBufferPtrSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_callback_buffer.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetBufferPtrSOFT(int buffer, BufferGetPNamePtr param, void** ptr) => ALPointers._alGetBufferPtrSOFT_fnptr(buffer, (int)param, ptr);
            
            /// <summary> <b>[requires: AL_SOFT_callback_buffer]</b> <b>[entry point: <c>alGetBufferPtrvSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_callback_buffer.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetBufferPtrvSOFT(int buffer, BufferGetPNamePtrV param, void** ptr) => ALPointers._alGetBufferPtrvSOFT_fnptr(buffer, (int)param, ptr);
            
            /// <summary> <b>[requires: AL_SOFT_buffer_samples]</b> <b>[entry point: <c>alGetBufferSamplesSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_buffer_samples.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetBufferSamplesSOFT(int buffer, int offset, int samples, Channels channels, SampleType type, void* data) => ALPointers._alGetBufferSamplesSOFT_fnptr(buffer, offset, samples, (int)channels, (int)type, data);
            
            /// <summary> <b>[requires: AL_SOFT_events]</b> <b>[entry point: <c>alGetPointerSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_events.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void* GetPointerSOFT(GetPNamePtr pname) => ALPointers._alGetPointerSOFT_fnptr((int)pname);
            
            /// <summary> <b>[requires: AL_SOFT_events]</b> <b>[entry point: <c>alGetPointervSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_events.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetPointervSOFT(GetPNamePtrV pname, void** values) => ALPointers._alGetPointervSOFT_fnptr((int)pname, values);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alGetSource3dSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_source_latency.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSource3dSOFT(int source, SourceGetPName3D param, double* value1, double* value2, double* value3) => ALPointers._alGetSource3dSOFT_fnptr(source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alGetSource3i64SOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_source_latency.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSource3i64SOFT(int source, SourceGetPName3I64 param, long* value1, long* value2, long* value3) => ALPointers._alGetSource3i64SOFT_fnptr(source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alGetSourcedSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_source_latency.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSourcedSOFT(int source, SourceGetPNameD param, double* value) => ALPointers._alGetSourcedSOFT_fnptr(source, (int)param, value);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alGetSourcedvSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_source_latency.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSourcedvSOFT(int source, SourceGetPNameDV param, double* values) => ALPointers._alGetSourcedvSOFT_fnptr(source, (int)param, values);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alGetSourcei64SOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_source_latency.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSourcei64SOFT(int source, SourceGetPNameI64 param, long* value) => ALPointers._alGetSourcei64SOFT_fnptr(source, (int)param, value);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alGetSourcei64vSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_source_latency.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetSourcei64vSOFT(int source, SourceGetPNameI64V param, long* values) => ALPointers._alGetSourcei64vSOFT_fnptr(source, (int)param, values);
            
            /// <summary> <b>[requires: AL_SOFT_source_resampler]</b> <b>[entry point: <c>alGetStringiSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_source_resampler.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static byte* GetStringiSOFT_(IndexedStringName pname, int index) => ALPointers._alGetStringiSOFT_fnptr((int)pname, index);
            
            /// <summary> <b>[requires: AL_SOFT_buffer_samples]</b> <b>[entry point: <c>alIsBufferFormatSupportedSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_buffer_samples.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool IsBufferFormatSupportedSOFT(InternalFormat format) => ALPointers._alIsBufferFormatSupportedSOFT_fnptr((int)format) != 0;
            
            /// <summary> <b>[requires: AL_SOFT_deferred_updates]</b> <b>[entry point: <c>alProcessUpdatesSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_deferred_updates.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void ProcessUpdatesSOFT() => ALPointers._alProcessUpdatesSOFT_fnptr();
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alSource3dSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_source_latency.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Source3dSOFT(int source, SourcePName3D param, double value1, double value2, double value3) => ALPointers._alSource3dSOFT_fnptr(source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alSource3i64SOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_source_latency.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Source3i64SOFT(int source, SourcePName3I64 param, long value1, long value2, long value3) => ALPointers._alSource3i64SOFT_fnptr(source, (int)param, value1, value2, value3);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alSourcedSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_source_latency.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourcedSOFT(int source, SourcePNameD param, double value) => ALPointers._alSourcedSOFT_fnptr(source, (int)param, value);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alSourcedvSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_source_latency.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourcedvSOFT(int source, SourcePNameDV param, double* values) => ALPointers._alSourcedvSOFT_fnptr(source, (int)param, values);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alSourcei64SOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_source_latency.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Sourcei64SOFT(int source, SourcePNameI64 param, long value) => ALPointers._alSourcei64SOFT_fnptr(source, (int)param, value);
            
            /// <summary> <b>[requires: AL_SOFT_source_latency]</b> <b>[entry point: <c>alSourcei64vSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_source_latency.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void Sourcei64vSOFT(int source, SourcePNameI64V param, long* values) => ALPointers._alSourcei64vSOFT_fnptr(source, (int)param, values);
            
            /// <summary> <b>[requires: AL_SOFT_source_start_delay]</b> <b>[entry point: <c>alSourcePlayAtTimeSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_source_start_delay.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourcePlayAtTimeSOFT(int source, long start_time) => ALPointers._alSourcePlayAtTimeSOFT_fnptr(source, start_time);
            
            /// <summary> <b>[requires: AL_SOFT_source_start_delay]</b> <b>[entry point: <c>alSourcePlayAtTimevSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/AL%20Extensions/AL_SOFT_source_start_delay.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SourcePlayAtTimevSOFT(int n, int* sources, long start_time) => ALPointers._alSourcePlayAtTimevSOFT_fnptr(n, sources, start_time);
            
        }
    }
}

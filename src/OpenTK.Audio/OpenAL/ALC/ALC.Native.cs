// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Audio;

namespace OpenTK.Audio.OpenAL.ALC
{
    public static unsafe partial class ALC
    {
        /// <summary> <b>[requires: v1.1 | ALC_EXT_CAPTURE]</b> <b>[entry point: <c>alcCaptureCloseDevice</c>]</b><br/>  </summary>
        /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_CAPTURE.txt"/></remarks>
        [OverloadResolutionPriority(-1)]
        public static bool CaptureCloseDevice(ALCDevice device) => ALCPointers._alcCaptureCloseDevice_fnptr((IntPtr)device) != 0;
        
        /// <summary> <b>[requires: v1.1 | ALC_EXT_CAPTURE]</b> <b>[entry point: <c>alcCaptureOpenDevice</c>]</b><br/>  </summary>
        /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_CAPTURE.txt"/></remarks>
        [OverloadResolutionPriority(-1)]
        public static ALCDevice CaptureOpenDevice(byte* devicename, uint frequency, Format format, int buffersize) => (ALCDevice) ALCPointers._alcCaptureOpenDevice_fnptr(devicename, frequency, (int)format, buffersize);
        
        /// <summary> <b>[requires: v1.1 | ALC_EXT_CAPTURE]</b> <b>[entry point: <c>alcCaptureSamples</c>]</b><br/>  </summary>
        /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_CAPTURE.txt"/></remarks>
        [OverloadResolutionPriority(-1)]
        public static void CaptureSamples(ALCDevice device, void* buffer, int samples) => ALCPointers._alcCaptureSamples_fnptr((IntPtr)device, buffer, samples);
        
        /// <summary> <b>[requires: v1.1 | ALC_EXT_CAPTURE]</b> <b>[entry point: <c>alcCaptureStart</c>]</b><br/>  </summary>
        /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_CAPTURE.txt"/></remarks>
        [OverloadResolutionPriority(-1)]
        public static void CaptureStart(ALCDevice device) => ALCPointers._alcCaptureStart_fnptr((IntPtr)device);
        
        /// <summary> <b>[requires: v1.1 | ALC_EXT_CAPTURE]</b> <b>[entry point: <c>alcCaptureStop</c>]</b><br/>  </summary>
        /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_CAPTURE.txt"/></remarks>
        [OverloadResolutionPriority(-1)]
        public static void CaptureStop(ALCDevice device) => ALCPointers._alcCaptureStop_fnptr((IntPtr)device);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alcCloseDevice</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static bool CloseDevice(ALCDevice device) => ALCPointers._alcCloseDevice_fnptr((IntPtr)device) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alcCreateContext</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static ALCContext CreateContext(ALCDevice device, int* attrlist) => (ALCContext) ALCPointers._alcCreateContext_fnptr((IntPtr)device, attrlist);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alcDestroyContext</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void DestroyContext(ALCContext context) => ALCPointers._alcDestroyContext_fnptr((IntPtr)context);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alcGetContextsDevice</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static ALCDevice GetContextsDevice(ALCContext context) => (ALCDevice) ALCPointers._alcGetContextsDevice_fnptr((IntPtr)context);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alcGetCurrentContext</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static ALCContext GetCurrentContext() => (ALCContext) ALCPointers._alcGetCurrentContext_fnptr();
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alcGetEnumValue</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static All GetEnumValue(ALCDevice device, byte* enumname) => (All) ALCPointers._alcGetEnumValue_fnptr((IntPtr)device, enumname);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alcGetError</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static ErrorCode GetError(ALCDevice device) => (ErrorCode) ALCPointers._alcGetError_fnptr((IntPtr)device);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alcGetIntegerv</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void GetIntegerv(ALCDevice device, GetPNameIV param, int size, int* values) => ALCPointers._alcGetIntegerv_fnptr((IntPtr)device, (int)param, size, values);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alcGetProcAddress</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void* GetProcAddress(ALCDevice device, byte* extname) => ALCPointers._alcGetProcAddress_fnptr((IntPtr)device, extname);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alcGetString</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static byte* GetString_(ALCDevice device, StringName param) => ALCPointers._alcGetString_fnptr((IntPtr)device, (int)param);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alcIsExtensionPresent</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static bool IsExtensionPresent(ALCDevice deviceHandle, byte* extname) => ALCPointers._alcIsExtensionPresent_fnptr((IntPtr)deviceHandle, extname) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alcMakeContextCurrent</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static bool MakeContextCurrent(ALCContext context) => ALCPointers._alcMakeContextCurrent_fnptr((IntPtr)context) != 0;
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alcOpenDevice</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static ALCDevice OpenDevice(byte* devicename) => (ALCDevice) ALCPointers._alcOpenDevice_fnptr(devicename);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alcProcessContext</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void ProcessContext(ALCContext context) => ALCPointers._alcProcessContext_fnptr((IntPtr)context);
        
        /// <summary> <b>[requires: v1.0]</b> <b>[entry point: <c>alcSuspendContext</c>]</b><br/>  </summary>
        [OverloadResolutionPriority(-1)]
        public static void SuspendContext(ALCContext context) => ALCPointers._alcSuspendContext_fnptr((IntPtr)context);
        
        /// <summary>EXT extensions.</summary>
        public static unsafe partial class EXT
        {
            /// <summary> <b>[requires: ALC_EXT_ASA]</b> <b>[entry point: <c>alcASAGetListener</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_ASA.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static All ASAGetListener(uint property, void* data, uint* dataSize) => (All) ALCPointers._alcASAGetListener_fnptr(property, data, dataSize);
            
            /// <summary> <b>[requires: ALC_EXT_ASA]</b> <b>[entry point: <c>alcASAGetSource</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_ASA.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static All ASAGetSource(uint property, uint source, void* data, uint* dataSize) => (All) ALCPointers._alcASAGetSource_fnptr(property, source, data, dataSize);
            
            /// <summary> <b>[requires: ALC_EXT_ASA]</b> <b>[entry point: <c>alcASASetListener</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_ASA.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static All ASASetListener(uint property, void* data, uint dataSize) => (All) ALCPointers._alcASASetListener_fnptr(property, data, dataSize);
            
            /// <summary> <b>[requires: ALC_EXT_ASA]</b> <b>[entry point: <c>alcASASetSource</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_ASA.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static All ASASetSource(uint property, uint source, void* data, uint dataSize) => (All) ALCPointers._alcASASetSource_fnptr(property, source, data, dataSize);
            
            /// <summary> <b>[requires: v1.1 | ALC_EXT_CAPTURE]</b> <b>[entry point: <c>alcCaptureCloseDevice</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_CAPTURE.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool CaptureCloseDevice(ALCDevice device) => ALCPointers._alcCaptureCloseDevice_fnptr((IntPtr)device) != 0;
            
            /// <summary> <b>[requires: v1.1 | ALC_EXT_CAPTURE]</b> <b>[entry point: <c>alcCaptureOpenDevice</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_CAPTURE.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static ALCDevice CaptureOpenDevice(byte* devicename, uint frequency, Format format, int buffersize) => (ALCDevice) ALCPointers._alcCaptureOpenDevice_fnptr(devicename, frequency, (int)format, buffersize);
            
            /// <summary> <b>[requires: v1.1 | ALC_EXT_CAPTURE]</b> <b>[entry point: <c>alcCaptureSamples</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_CAPTURE.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void CaptureSamples(ALCDevice device, void* buffer, int samples) => ALCPointers._alcCaptureSamples_fnptr((IntPtr)device, buffer, samples);
            
            /// <summary> <b>[requires: v1.1 | ALC_EXT_CAPTURE]</b> <b>[entry point: <c>alcCaptureStart</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_CAPTURE.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void CaptureStart(ALCDevice device) => ALCPointers._alcCaptureStart_fnptr((IntPtr)device);
            
            /// <summary> <b>[requires: v1.1 | ALC_EXT_CAPTURE]</b> <b>[entry point: <c>alcCaptureStop</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_CAPTURE.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void CaptureStop(ALCDevice device) => ALCPointers._alcCaptureStop_fnptr((IntPtr)device);
            
            /// <summary> <b>[requires: ALC_EXT_direct_context]</b> <b>[entry point: <c>alcGetProcAddress2</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_direct_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void* GetProcAddress2(ALCDevice device, byte* funcName) => ALCPointers._alcGetProcAddress2_fnptr((IntPtr)device, funcName);
            
            /// <summary> <b>[requires: ALC_EXT_thread_local_context]</b> <b>[entry point: <c>alcGetThreadContext</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_thread_local_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static ALCContext GetThreadContext() => (ALCContext) ALCPointers._alcGetThreadContext_fnptr();
            
            /// <summary> <b>[requires: ALC_EXT_MAC_OSX]</b> <b>[entry point: <c>alcMacOSXGetMixerMaxiumumBusses</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_MAC_OSX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static int MacOSXGetMixerMaxiumumBusses() => ALCPointers._alcMacOSXGetMixerMaxiumumBusses_fnptr();
            
            /// <summary> <b>[requires: ALC_EXT_MAC_OSX]</b> <b>[entry point: <c>alcMacOSXGetMixerOutputRate</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_MAC_OSX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static double MacOSXGetMixerOutputRate() => ALCPointers._alcMacOSXGetMixerOutputRate_fnptr();
            
            /// <summary> <b>[requires: ALC_EXT_MAC_OSX]</b> <b>[entry point: <c>alcMacOSXGetRenderingQuality</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_MAC_OSX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static int MacOSXGetRenderingQuality() => ALCPointers._alcMacOSXGetRenderingQuality_fnptr();
            
            /// <summary> <b>[requires: ALC_EXT_MAC_OSX]</b> <b>[entry point: <c>alcMacOSXMixerMaxiumumBusses</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_MAC_OSX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void MacOSXMixerMaxiumumBusses(int value) => ALCPointers._alcMacOSXMixerMaxiumumBusses_fnptr(value);
            
            /// <summary> <b>[requires: ALC_EXT_MAC_OSX]</b> <b>[entry point: <c>alcMacOSXMixerOutputRate</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_MAC_OSX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void MacOSXMixerOutputRate(double value) => ALCPointers._alcMacOSXMixerOutputRate_fnptr(value);
            
            /// <summary> <b>[requires: ALC_EXT_MAC_OSX]</b> <b>[entry point: <c>alcMacOSXRenderingQuality</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_MAC_OSX.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void MacOSXRenderingQuality(int value) => ALCPointers._alcMacOSXRenderingQuality_fnptr(value);
            
            /// <summary> <b>[requires: ALC_EXT_OUTPUT_CAPTURER]</b> <b>[entry point: <c>alcOutputCapturerAvailableSamples</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_OUTPUT_CAPTURER.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void OutputCapturerAvailableSamples() => ALCPointers._alcOutputCapturerAvailableSamples_fnptr();
            
            /// <summary> <b>[requires: ALC_EXT_OUTPUT_CAPTURER]</b> <b>[entry point: <c>alcOutputCapturerPrepare</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_OUTPUT_CAPTURER.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void OutputCapturerPrepare(uint frequency, All format, int maxsamplecount) => ALCPointers._alcOutputCapturerPrepare_fnptr(frequency, (int)format, maxsamplecount);
            
            /// <summary> <b>[requires: ALC_EXT_OUTPUT_CAPTURER]</b> <b>[entry point: <c>alcOutputCapturerSamples</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_OUTPUT_CAPTURER.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void OutputCapturerSamples(void* buffer, int maxsamplecount) => ALCPointers._alcOutputCapturerSamples_fnptr(buffer, maxsamplecount);
            
            /// <summary> <b>[requires: ALC_EXT_OUTPUT_CAPTURER]</b> <b>[entry point: <c>alcOutputCapturerStart</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_OUTPUT_CAPTURER.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void OutputCapturerStart() => ALCPointers._alcOutputCapturerStart_fnptr();
            
            /// <summary> <b>[requires: ALC_EXT_OUTPUT_CAPTURER]</b> <b>[entry point: <c>alcOutputCapturerStop</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_OUTPUT_CAPTURER.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void OutputCapturerStop() => ALCPointers._alcOutputCapturerStop_fnptr();
            
            /// <summary> <b>[requires: ALC_EXT_thread_local_context]</b> <b>[entry point: <c>alcSetThreadContext</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_EXT_thread_local_context.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool SetThreadContext(ALCContext context) => ALCPointers._alcSetThreadContext_fnptr((IntPtr)context) != 0;
            
        }
        /// <summary>LOKI extensions.</summary>
        public static unsafe partial class LOKI
        {
            /// <summary> <b>[requires: ALC_LOKI_audio_channel]</b> <b>[entry point: <c>GetAudioChannel_LOKI</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_LOKI_audio_channel.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static float GetAudioChannel_LOKI(uint channel) => ALCPointers._GetAudioChannel_LOKI_fnptr(channel);
            
            /// <summary> <b>[requires: ALC_LOKI_audio_channel]</b> <b>[entry point: <c>SetAudioChannel_LOKI</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_LOKI_audio_channel.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void SetAudioChannel_LOKI(uint channel, float volume) => ALCPointers._SetAudioChannel_LOKI_fnptr(channel, volume);
            
        }
        /// <summary>SOFT extensions.</summary>
        public static unsafe partial class SOFT
        {
            /// <summary> <b>[requires: ALC_SOFT_pause_device]</b> <b>[entry point: <c>alcDevicePauseSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_SOFT_pause_device.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DevicePauseSOFT(ALCDevice device) => ALCPointers._alcDevicePauseSOFT_fnptr((IntPtr)device);
            
            /// <summary> <b>[requires: ALC_SOFT_pause_device]</b> <b>[entry point: <c>alcDeviceResumeSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_SOFT_pause_device.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void DeviceResumeSOFT(ALCDevice device) => ALCPointers._alcDeviceResumeSOFT_fnptr((IntPtr)device);
            
            /// <summary> <b>[requires: ALC_SOFT_system_events]</b> <b>[entry point: <c>alcEventCallbackSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_SOFT_system_events.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void EventCallbackSOFT(delegate* unmanaged[Cdecl]<All, All, ALCDevice, nuint, byte*, void*, void> callback, void* userParam) => ALCPointers._alcEventCallbackSOFT_fnptr(callback, userParam);
            
            /// <summary> <b>[requires: ALC_SOFT_system_events]</b> <b>[entry point: <c>alcEventControlSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_SOFT_system_events.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool EventControlSOFT(int count, EventType* events, bool enable) => ALCPointers._alcEventControlSOFT_fnptr(count, (int*)events, (byte)(enable ? 1 : 0)) != 0;
            
            /// <summary> <b>[requires: ALC_SOFT_system_events]</b> <b>[entry point: <c>alcEventIsSupportedSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_SOFT_system_events.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static EventSupport EventIsSupportedSOFT(EventType eventType, DeviceType deviceType) => (EventSupport) ALCPointers._alcEventIsSupportedSOFT_fnptr((int)eventType, (int)deviceType);
            
            /// <summary> <b>[requires: ALC_SOFT_device_clock]</b> <b>[entry point: <c>alcGetInteger64vSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_SOFT_device_clock.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void GetInteger64vSOFT(ALCDevice device, GetPNameI64V pname, int size, long* values) => ALCPointers._alcGetInteger64vSOFT_fnptr((IntPtr)device, (int)pname, size, values);
            
            /// <summary> <b>[requires: ALC_SOFT_HRTF]</b> <b>[entry point: <c>alcGetStringiSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_SOFT_HRTF.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static byte* GetStringiSOFT_(ALCDevice device, IndexedStringName paramName, int index) => ALCPointers._alcGetStringiSOFT_fnptr((IntPtr)device, (int)paramName, index);
            
            /// <summary> <b>[requires: ALC_SOFT_loopback]</b> <b>[entry point: <c>alcIsRenderFormatSupportedSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_SOFT_loopback.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool IsRenderFormatSupportedSOFT(ALCDevice device, int frequency, RenderFormatChannels channels, RenderFormatType type) => ALCPointers._alcIsRenderFormatSupportedSOFT_fnptr((IntPtr)device, frequency, (int)channels, (int)type) != 0;
            
            /// <summary> <b>[requires: ALC_SOFT_loopback]</b> <b>[entry point: <c>alcLoopbackOpenDeviceSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_SOFT_loopback.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static ALCDevice LoopbackOpenDeviceSOFT(ALCDevice device) => (ALCDevice) ALCPointers._alcLoopbackOpenDeviceSOFT_fnptr((IntPtr)device);
            
            /// <summary> <b>[requires: ALC_SOFT_loopback]</b> <b>[entry point: <c>alcRenderSamplesSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_SOFT_loopback.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static void RenderSamplesSOFT(ALCDevice device, void* buffer, int samples) => ALCPointers._alcRenderSamplesSOFT_fnptr((IntPtr)device, buffer, samples);
            
            /// <summary> <b>[requires: ALC_SOFT_reopen_device]</b> <b>[entry point: <c>alcReopenDeviceSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_SOFT_reopen_device.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool ReopenDeviceSOFT(ALCDevice device, byte* deviceName, int* attribs) => ALCPointers._alcReopenDeviceSOFT_fnptr((IntPtr)device, deviceName, attribs) != 0;
            
            /// <summary> <b>[requires: ALC_SOFT_HRTF | ALC_SOFT_output_limiter]</b> <b>[entry point: <c>alcResetDeviceSOFT</c>]</b><br/>  </summary>
            /// <remarks><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_SOFT_HRTF.txt"/><br/><see href="https://raw.githubusercontent.com/Raulshc/OpenAL-EXT-Repository/refs/heads/master/ALC%20Extensions/ALC_SOFT_output_limiter.txt"/></remarks>
            [OverloadResolutionPriority(-1)]
            public static bool ResetDeviceSOFT(ALCDevice device, int* attrList) => ALCPointers._alcResetDeviceSOFT_fnptr((IntPtr)device, attrList) != 0;
            
        }
    }
}

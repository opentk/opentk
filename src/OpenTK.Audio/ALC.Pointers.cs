// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Audio;

namespace OpenTK.Audio.OpenAL.ALC
{
    /// <summary>A collection of all function pointers to all OpenAL entry points.</summary>
    public static unsafe partial class ALCPointers
    {
        /// <summary><b>[entry point: <c>alcASAGetListener</c>]</b></summary>
        public static delegate* unmanaged<uint, void*, uint*, int> _alcASAGetListener_fnptr = &alcASAGetListener_Lazy;
        [UnmanagedCallersOnly]
        private static int alcASAGetListener_Lazy(uint property, void* data, uint* dataSize)
        {
            _alcASAGetListener_fnptr = (delegate* unmanaged<uint, void*, uint*, int>)ALCLoader.BindingsContext.GetProcAddress("alcASAGetListener");
            return _alcASAGetListener_fnptr(property, data, dataSize);
        }
        
        /// <summary><b>[entry point: <c>alcASAGetSource</c>]</b></summary>
        public static delegate* unmanaged<uint, uint, void*, uint*, int> _alcASAGetSource_fnptr = &alcASAGetSource_Lazy;
        [UnmanagedCallersOnly]
        private static int alcASAGetSource_Lazy(uint property, uint source, void* data, uint* dataSize)
        {
            _alcASAGetSource_fnptr = (delegate* unmanaged<uint, uint, void*, uint*, int>)ALCLoader.BindingsContext.GetProcAddress("alcASAGetSource");
            return _alcASAGetSource_fnptr(property, source, data, dataSize);
        }
        
        /// <summary><b>[entry point: <c>alcASASetListener</c>]</b></summary>
        public static delegate* unmanaged<uint, void*, uint, int> _alcASASetListener_fnptr = &alcASASetListener_Lazy;
        [UnmanagedCallersOnly]
        private static int alcASASetListener_Lazy(uint property, void* data, uint dataSize)
        {
            _alcASASetListener_fnptr = (delegate* unmanaged<uint, void*, uint, int>)ALCLoader.BindingsContext.GetProcAddress("alcASASetListener");
            return _alcASASetListener_fnptr(property, data, dataSize);
        }
        
        /// <summary><b>[entry point: <c>alcASASetSource</c>]</b></summary>
        public static delegate* unmanaged<uint, uint, void*, uint, int> _alcASASetSource_fnptr = &alcASASetSource_Lazy;
        [UnmanagedCallersOnly]
        private static int alcASASetSource_Lazy(uint property, uint source, void* data, uint dataSize)
        {
            _alcASASetSource_fnptr = (delegate* unmanaged<uint, uint, void*, uint, int>)ALCLoader.BindingsContext.GetProcAddress("alcASASetSource");
            return _alcASASetSource_fnptr(property, source, data, dataSize);
        }
        
        /// <summary><b>[entry point: <c>alcCaptureCloseDevice</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte> _alcCaptureCloseDevice_fnptr = &alcCaptureCloseDevice_Lazy;
        [UnmanagedCallersOnly]
        private static byte alcCaptureCloseDevice_Lazy(IntPtr device)
        {
            _alcCaptureCloseDevice_fnptr = (delegate* unmanaged<IntPtr, byte>)ALCLoader.BindingsContext.GetProcAddress("alcCaptureCloseDevice");
            return _alcCaptureCloseDevice_fnptr(device);
        }
        
        /// <summary><b>[entry point: <c>alcCaptureOpenDevice</c>]</b></summary>
        public static delegate* unmanaged<byte*, uint, int, int, IntPtr> _alcCaptureOpenDevice_fnptr = &alcCaptureOpenDevice_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr alcCaptureOpenDevice_Lazy(byte* devicename, uint frequency, int format, int buffersize)
        {
            _alcCaptureOpenDevice_fnptr = (delegate* unmanaged<byte*, uint, int, int, IntPtr>)ALCLoader.BindingsContext.GetProcAddress("alcCaptureOpenDevice");
            return _alcCaptureOpenDevice_fnptr(devicename, frequency, format, buffersize);
        }
        
        /// <summary><b>[entry point: <c>alcCaptureSamples</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, int, void> _alcCaptureSamples_fnptr = &alcCaptureSamples_Lazy;
        [UnmanagedCallersOnly]
        private static void alcCaptureSamples_Lazy(IntPtr device, void* buffer, int samples)
        {
            _alcCaptureSamples_fnptr = (delegate* unmanaged<IntPtr, void*, int, void>)ALCLoader.BindingsContext.GetProcAddress("alcCaptureSamples");
            _alcCaptureSamples_fnptr(device, buffer, samples);
        }
        
        /// <summary><b>[entry point: <c>alcCaptureStart</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void> _alcCaptureStart_fnptr = &alcCaptureStart_Lazy;
        [UnmanagedCallersOnly]
        private static void alcCaptureStart_Lazy(IntPtr device)
        {
            _alcCaptureStart_fnptr = (delegate* unmanaged<IntPtr, void>)ALCLoader.BindingsContext.GetProcAddress("alcCaptureStart");
            _alcCaptureStart_fnptr(device);
        }
        
        /// <summary><b>[entry point: <c>alcCaptureStop</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void> _alcCaptureStop_fnptr = &alcCaptureStop_Lazy;
        [UnmanagedCallersOnly]
        private static void alcCaptureStop_Lazy(IntPtr device)
        {
            _alcCaptureStop_fnptr = (delegate* unmanaged<IntPtr, void>)ALCLoader.BindingsContext.GetProcAddress("alcCaptureStop");
            _alcCaptureStop_fnptr(device);
        }
        
        /// <summary><b>[entry point: <c>alcCloseDevice</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte> _alcCloseDevice_fnptr = &alcCloseDevice_Lazy;
        [UnmanagedCallersOnly]
        private static byte alcCloseDevice_Lazy(IntPtr device)
        {
            _alcCloseDevice_fnptr = (delegate* unmanaged<IntPtr, byte>)ALCLoader.BindingsContext.GetProcAddress("alcCloseDevice");
            return _alcCloseDevice_fnptr(device);
        }
        
        /// <summary><b>[entry point: <c>alcCreateContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, IntPtr> _alcCreateContext_fnptr = &alcCreateContext_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr alcCreateContext_Lazy(IntPtr device, int* attrlist)
        {
            _alcCreateContext_fnptr = (delegate* unmanaged<IntPtr, int*, IntPtr>)ALCLoader.BindingsContext.GetProcAddress("alcCreateContext");
            return _alcCreateContext_fnptr(device, attrlist);
        }
        
        /// <summary><b>[entry point: <c>alcDestroyContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void> _alcDestroyContext_fnptr = &alcDestroyContext_Lazy;
        [UnmanagedCallersOnly]
        private static void alcDestroyContext_Lazy(IntPtr context)
        {
            _alcDestroyContext_fnptr = (delegate* unmanaged<IntPtr, void>)ALCLoader.BindingsContext.GetProcAddress("alcDestroyContext");
            _alcDestroyContext_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>alcDevicePauseSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void> _alcDevicePauseSOFT_fnptr = &alcDevicePauseSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alcDevicePauseSOFT_Lazy(IntPtr device)
        {
            _alcDevicePauseSOFT_fnptr = (delegate* unmanaged<IntPtr, void>)ALCLoader.BindingsContext.GetProcAddress("alcDevicePauseSOFT");
            _alcDevicePauseSOFT_fnptr(device);
        }
        
        /// <summary><b>[entry point: <c>alcDeviceResumeSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void> _alcDeviceResumeSOFT_fnptr = &alcDeviceResumeSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alcDeviceResumeSOFT_Lazy(IntPtr device)
        {
            _alcDeviceResumeSOFT_fnptr = (delegate* unmanaged<IntPtr, void>)ALCLoader.BindingsContext.GetProcAddress("alcDeviceResumeSOFT");
            _alcDeviceResumeSOFT_fnptr(device);
        }
        
        /// <summary><b>[entry point: <c>alcEventCallbackSOFT</c>]</b></summary>
        public static delegate* unmanaged<delegate* unmanaged[Cdecl]<All, All, ALCDevice, nuint, byte*, void*, void>, void*, void> _alcEventCallbackSOFT_fnptr = &alcEventCallbackSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alcEventCallbackSOFT_Lazy(delegate* unmanaged[Cdecl]<All, All, ALCDevice, nuint, byte*, void*, void> callback, void* userParam)
        {
            _alcEventCallbackSOFT_fnptr = (delegate* unmanaged<delegate* unmanaged[Cdecl]<All, All, ALCDevice, nuint, byte*, void*, void>, void*, void>)ALCLoader.BindingsContext.GetProcAddress("alcEventCallbackSOFT");
            _alcEventCallbackSOFT_fnptr(callback, userParam);
        }
        
        /// <summary><b>[entry point: <c>alcEventControlSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int*, byte, byte> _alcEventControlSOFT_fnptr = &alcEventControlSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static byte alcEventControlSOFT_Lazy(int count, int* events, byte enable)
        {
            _alcEventControlSOFT_fnptr = (delegate* unmanaged<int, int*, byte, byte>)ALCLoader.BindingsContext.GetProcAddress("alcEventControlSOFT");
            return _alcEventControlSOFT_fnptr(count, events, enable);
        }
        
        /// <summary><b>[entry point: <c>alcEventIsSupportedSOFT</c>]</b></summary>
        public static delegate* unmanaged<int, int, int> _alcEventIsSupportedSOFT_fnptr = &alcEventIsSupportedSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static int alcEventIsSupportedSOFT_Lazy(int eventType, int deviceType)
        {
            _alcEventIsSupportedSOFT_fnptr = (delegate* unmanaged<int, int, int>)ALCLoader.BindingsContext.GetProcAddress("alcEventIsSupportedSOFT");
            return _alcEventIsSupportedSOFT_fnptr(eventType, deviceType);
        }
        
        /// <summary><b>[entry point: <c>alcGetContextsDevice</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr> _alcGetContextsDevice_fnptr = &alcGetContextsDevice_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr alcGetContextsDevice_Lazy(IntPtr context)
        {
            _alcGetContextsDevice_fnptr = (delegate* unmanaged<IntPtr, IntPtr>)ALCLoader.BindingsContext.GetProcAddress("alcGetContextsDevice");
            return _alcGetContextsDevice_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>alcGetCurrentContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _alcGetCurrentContext_fnptr = &alcGetCurrentContext_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr alcGetCurrentContext_Lazy()
        {
            _alcGetCurrentContext_fnptr = (delegate* unmanaged<IntPtr>)ALCLoader.BindingsContext.GetProcAddress("alcGetCurrentContext");
            return _alcGetCurrentContext_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alcGetEnumValue</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte*, int> _alcGetEnumValue_fnptr = &alcGetEnumValue_Lazy;
        [UnmanagedCallersOnly]
        private static int alcGetEnumValue_Lazy(IntPtr device, byte* enumname)
        {
            _alcGetEnumValue_fnptr = (delegate* unmanaged<IntPtr, byte*, int>)ALCLoader.BindingsContext.GetProcAddress("alcGetEnumValue");
            return _alcGetEnumValue_fnptr(device, enumname);
        }
        
        /// <summary><b>[entry point: <c>alcGetError</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int> _alcGetError_fnptr = &alcGetError_Lazy;
        [UnmanagedCallersOnly]
        private static int alcGetError_Lazy(IntPtr device)
        {
            _alcGetError_fnptr = (delegate* unmanaged<IntPtr, int>)ALCLoader.BindingsContext.GetProcAddress("alcGetError");
            return _alcGetError_fnptr(device);
        }
        
        /// <summary><b>[entry point: <c>alcGetInteger64vSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, long*, void> _alcGetInteger64vSOFT_fnptr = &alcGetInteger64vSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alcGetInteger64vSOFT_Lazy(IntPtr device, int pname, int size, long* values)
        {
            _alcGetInteger64vSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, long*, void>)ALCLoader.BindingsContext.GetProcAddress("alcGetInteger64vSOFT");
            _alcGetInteger64vSOFT_fnptr(device, pname, size, values);
        }
        
        /// <summary><b>[entry point: <c>alcGetIntegerv</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int*, byte*> _alcGetIntegerv_fnptr = &alcGetIntegerv_Lazy;
        [UnmanagedCallersOnly]
        private static byte* alcGetIntegerv_Lazy(IntPtr device, int param, int size, int* values)
        {
            _alcGetIntegerv_fnptr = (delegate* unmanaged<IntPtr, int, int, int*, byte*>)ALCLoader.BindingsContext.GetProcAddress("alcGetIntegerv");
            return _alcGetIntegerv_fnptr(device, param, size, values);
        }
        
        /// <summary><b>[entry point: <c>alcGetProcAddress</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte*, void*> _alcGetProcAddress_fnptr = &alcGetProcAddress_Lazy;
        [UnmanagedCallersOnly]
        private static void* alcGetProcAddress_Lazy(IntPtr device, byte* extname)
        {
            _alcGetProcAddress_fnptr = (delegate* unmanaged<IntPtr, byte*, void*>)ALCLoader.BindingsContext.GetProcAddress("alcGetProcAddress");
            return _alcGetProcAddress_fnptr(device, extname);
        }
        
        /// <summary><b>[entry point: <c>alcGetProcAddress2</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte*, void*> _alcGetProcAddress2_fnptr = &alcGetProcAddress2_Lazy;
        [UnmanagedCallersOnly]
        private static void* alcGetProcAddress2_Lazy(IntPtr device, byte* funcName)
        {
            _alcGetProcAddress2_fnptr = (delegate* unmanaged<IntPtr, byte*, void*>)ALCLoader.BindingsContext.GetProcAddress("alcGetProcAddress2");
            return _alcGetProcAddress2_fnptr(device, funcName);
        }
        
        /// <summary><b>[entry point: <c>alcGetString</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, byte*> _alcGetString_fnptr = &alcGetString_Lazy;
        [UnmanagedCallersOnly]
        private static byte* alcGetString_Lazy(IntPtr device, int param)
        {
            _alcGetString_fnptr = (delegate* unmanaged<IntPtr, int, byte*>)ALCLoader.BindingsContext.GetProcAddress("alcGetString");
            return _alcGetString_fnptr(device, param);
        }
        
        /// <summary><b>[entry point: <c>alcGetStringiSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, byte*> _alcGetStringiSOFT_fnptr = &alcGetStringiSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static byte* alcGetStringiSOFT_Lazy(IntPtr device, int paramName, int index)
        {
            _alcGetStringiSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, byte*>)ALCLoader.BindingsContext.GetProcAddress("alcGetStringiSOFT");
            return _alcGetStringiSOFT_fnptr(device, paramName, index);
        }
        
        /// <summary><b>[entry point: <c>alcGetThreadContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr> _alcGetThreadContext_fnptr = &alcGetThreadContext_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr alcGetThreadContext_Lazy()
        {
            _alcGetThreadContext_fnptr = (delegate* unmanaged<IntPtr>)ALCLoader.BindingsContext.GetProcAddress("alcGetThreadContext");
            return _alcGetThreadContext_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alcIsExtensionPresent</c>]</b></summary>
        public static delegate* unmanaged<byte*, byte> _alcIsExtensionPresent_fnptr = &alcIsExtensionPresent_Lazy;
        [UnmanagedCallersOnly]
        private static byte alcIsExtensionPresent_Lazy(byte* extname)
        {
            _alcIsExtensionPresent_fnptr = (delegate* unmanaged<byte*, byte>)ALCLoader.BindingsContext.GetProcAddress("alcIsExtensionPresent");
            return _alcIsExtensionPresent_fnptr(extname);
        }
        
        /// <summary><b>[entry point: <c>alcIsRenderFormatSupportedSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int, int, int, byte> _alcIsRenderFormatSupportedSOFT_fnptr = &alcIsRenderFormatSupportedSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static byte alcIsRenderFormatSupportedSOFT_Lazy(IntPtr device, int frequency, int channels, int type)
        {
            _alcIsRenderFormatSupportedSOFT_fnptr = (delegate* unmanaged<IntPtr, int, int, int, byte>)ALCLoader.BindingsContext.GetProcAddress("alcIsRenderFormatSupportedSOFT");
            return _alcIsRenderFormatSupportedSOFT_fnptr(device, frequency, channels, type);
        }
        
        /// <summary><b>[entry point: <c>alcLoopbackOpenDeviceSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, IntPtr> _alcLoopbackOpenDeviceSOFT_fnptr = &alcLoopbackOpenDeviceSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr alcLoopbackOpenDeviceSOFT_Lazy(IntPtr device)
        {
            _alcLoopbackOpenDeviceSOFT_fnptr = (delegate* unmanaged<IntPtr, IntPtr>)ALCLoader.BindingsContext.GetProcAddress("alcLoopbackOpenDeviceSOFT");
            return _alcLoopbackOpenDeviceSOFT_fnptr(device);
        }
        
        /// <summary><b>[entry point: <c>alcMacOSXGetMixerMaxiumumBusses</c>]</b></summary>
        public static delegate* unmanaged<int> _alcMacOSXGetMixerMaxiumumBusses_fnptr = &alcMacOSXGetMixerMaxiumumBusses_Lazy;
        [UnmanagedCallersOnly]
        private static int alcMacOSXGetMixerMaxiumumBusses_Lazy()
        {
            _alcMacOSXGetMixerMaxiumumBusses_fnptr = (delegate* unmanaged<int>)ALCLoader.BindingsContext.GetProcAddress("alcMacOSXGetMixerMaxiumumBusses");
            return _alcMacOSXGetMixerMaxiumumBusses_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alcMacOSXGetMixerOutputRate</c>]</b></summary>
        public static delegate* unmanaged<double> _alcMacOSXGetMixerOutputRate_fnptr = &alcMacOSXGetMixerOutputRate_Lazy;
        [UnmanagedCallersOnly]
        private static double alcMacOSXGetMixerOutputRate_Lazy()
        {
            _alcMacOSXGetMixerOutputRate_fnptr = (delegate* unmanaged<double>)ALCLoader.BindingsContext.GetProcAddress("alcMacOSXGetMixerOutputRate");
            return _alcMacOSXGetMixerOutputRate_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alcMacOSXGetRenderingQuality</c>]</b></summary>
        public static delegate* unmanaged<int> _alcMacOSXGetRenderingQuality_fnptr = &alcMacOSXGetRenderingQuality_Lazy;
        [UnmanagedCallersOnly]
        private static int alcMacOSXGetRenderingQuality_Lazy()
        {
            _alcMacOSXGetRenderingQuality_fnptr = (delegate* unmanaged<int>)ALCLoader.BindingsContext.GetProcAddress("alcMacOSXGetRenderingQuality");
            return _alcMacOSXGetRenderingQuality_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alcMacOSXMixerMaxiumumBusses</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alcMacOSXMixerMaxiumumBusses_fnptr = &alcMacOSXMixerMaxiumumBusses_Lazy;
        [UnmanagedCallersOnly]
        private static void alcMacOSXMixerMaxiumumBusses_Lazy(int value)
        {
            _alcMacOSXMixerMaxiumumBusses_fnptr = (delegate* unmanaged<int, void>)ALCLoader.BindingsContext.GetProcAddress("alcMacOSXMixerMaxiumumBusses");
            _alcMacOSXMixerMaxiumumBusses_fnptr(value);
        }
        
        /// <summary><b>[entry point: <c>alcMacOSXMixerOutputRate</c>]</b></summary>
        public static delegate* unmanaged<double, void> _alcMacOSXMixerOutputRate_fnptr = &alcMacOSXMixerOutputRate_Lazy;
        [UnmanagedCallersOnly]
        private static void alcMacOSXMixerOutputRate_Lazy(double value)
        {
            _alcMacOSXMixerOutputRate_fnptr = (delegate* unmanaged<double, void>)ALCLoader.BindingsContext.GetProcAddress("alcMacOSXMixerOutputRate");
            _alcMacOSXMixerOutputRate_fnptr(value);
        }
        
        /// <summary><b>[entry point: <c>alcMacOSXRenderingQuality</c>]</b></summary>
        public static delegate* unmanaged<int, void> _alcMacOSXRenderingQuality_fnptr = &alcMacOSXRenderingQuality_Lazy;
        [UnmanagedCallersOnly]
        private static void alcMacOSXRenderingQuality_Lazy(int value)
        {
            _alcMacOSXRenderingQuality_fnptr = (delegate* unmanaged<int, void>)ALCLoader.BindingsContext.GetProcAddress("alcMacOSXRenderingQuality");
            _alcMacOSXRenderingQuality_fnptr(value);
        }
        
        /// <summary><b>[entry point: <c>alcMakeContextCurrent</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte> _alcMakeContextCurrent_fnptr = &alcMakeContextCurrent_Lazy;
        [UnmanagedCallersOnly]
        private static byte alcMakeContextCurrent_Lazy(IntPtr context)
        {
            _alcMakeContextCurrent_fnptr = (delegate* unmanaged<IntPtr, byte>)ALCLoader.BindingsContext.GetProcAddress("alcMakeContextCurrent");
            return _alcMakeContextCurrent_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>alcOpenDevice</c>]</b></summary>
        public static delegate* unmanaged<byte*, IntPtr> _alcOpenDevice_fnptr = &alcOpenDevice_Lazy;
        [UnmanagedCallersOnly]
        private static IntPtr alcOpenDevice_Lazy(byte* devicename)
        {
            _alcOpenDevice_fnptr = (delegate* unmanaged<byte*, IntPtr>)ALCLoader.BindingsContext.GetProcAddress("alcOpenDevice");
            return _alcOpenDevice_fnptr(devicename);
        }
        
        /// <summary><b>[entry point: <c>alcOutputCapturerAvailableSamples</c>]</b></summary>
        public static delegate* unmanaged<void> _alcOutputCapturerAvailableSamples_fnptr = &alcOutputCapturerAvailableSamples_Lazy;
        [UnmanagedCallersOnly]
        private static void alcOutputCapturerAvailableSamples_Lazy()
        {
            _alcOutputCapturerAvailableSamples_fnptr = (delegate* unmanaged<void>)ALCLoader.BindingsContext.GetProcAddress("alcOutputCapturerAvailableSamples");
            _alcOutputCapturerAvailableSamples_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alcOutputCapturerPrepare</c>]</b></summary>
        public static delegate* unmanaged<uint, int, int, void> _alcOutputCapturerPrepare_fnptr = &alcOutputCapturerPrepare_Lazy;
        [UnmanagedCallersOnly]
        private static void alcOutputCapturerPrepare_Lazy(uint frequency, int format, int maxsamplecount)
        {
            _alcOutputCapturerPrepare_fnptr = (delegate* unmanaged<uint, int, int, void>)ALCLoader.BindingsContext.GetProcAddress("alcOutputCapturerPrepare");
            _alcOutputCapturerPrepare_fnptr(frequency, format, maxsamplecount);
        }
        
        /// <summary><b>[entry point: <c>alcOutputCapturerSamples</c>]</b></summary>
        public static delegate* unmanaged<void*, int, void> _alcOutputCapturerSamples_fnptr = &alcOutputCapturerSamples_Lazy;
        [UnmanagedCallersOnly]
        private static void alcOutputCapturerSamples_Lazy(void* buffer, int maxsamplecount)
        {
            _alcOutputCapturerSamples_fnptr = (delegate* unmanaged<void*, int, void>)ALCLoader.BindingsContext.GetProcAddress("alcOutputCapturerSamples");
            _alcOutputCapturerSamples_fnptr(buffer, maxsamplecount);
        }
        
        /// <summary><b>[entry point: <c>alcOutputCapturerStart</c>]</b></summary>
        public static delegate* unmanaged<void> _alcOutputCapturerStart_fnptr = &alcOutputCapturerStart_Lazy;
        [UnmanagedCallersOnly]
        private static void alcOutputCapturerStart_Lazy()
        {
            _alcOutputCapturerStart_fnptr = (delegate* unmanaged<void>)ALCLoader.BindingsContext.GetProcAddress("alcOutputCapturerStart");
            _alcOutputCapturerStart_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alcOutputCapturerStop</c>]</b></summary>
        public static delegate* unmanaged<void> _alcOutputCapturerStop_fnptr = &alcOutputCapturerStop_Lazy;
        [UnmanagedCallersOnly]
        private static void alcOutputCapturerStop_Lazy()
        {
            _alcOutputCapturerStop_fnptr = (delegate* unmanaged<void>)ALCLoader.BindingsContext.GetProcAddress("alcOutputCapturerStop");
            _alcOutputCapturerStop_fnptr();
        }
        
        /// <summary><b>[entry point: <c>alcProcessContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void> _alcProcessContext_fnptr = &alcProcessContext_Lazy;
        [UnmanagedCallersOnly]
        private static void alcProcessContext_Lazy(IntPtr context)
        {
            _alcProcessContext_fnptr = (delegate* unmanaged<IntPtr, void>)ALCLoader.BindingsContext.GetProcAddress("alcProcessContext");
            _alcProcessContext_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>alcRenderSamplesSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void*, int, void> _alcRenderSamplesSOFT_fnptr = &alcRenderSamplesSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static void alcRenderSamplesSOFT_Lazy(IntPtr device, void* buffer, int samples)
        {
            _alcRenderSamplesSOFT_fnptr = (delegate* unmanaged<IntPtr, void*, int, void>)ALCLoader.BindingsContext.GetProcAddress("alcRenderSamplesSOFT");
            _alcRenderSamplesSOFT_fnptr(device, buffer, samples);
        }
        
        /// <summary><b>[entry point: <c>alcReopenDeviceSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte*, int*, byte> _alcReopenDeviceSOFT_fnptr = &alcReopenDeviceSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static byte alcReopenDeviceSOFT_Lazy(IntPtr device, byte* deviceName, int* attribs)
        {
            _alcReopenDeviceSOFT_fnptr = (delegate* unmanaged<IntPtr, byte*, int*, byte>)ALCLoader.BindingsContext.GetProcAddress("alcReopenDeviceSOFT");
            return _alcReopenDeviceSOFT_fnptr(device, deviceName, attribs);
        }
        
        /// <summary><b>[entry point: <c>alcResetDeviceSOFT</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, int*, byte> _alcResetDeviceSOFT_fnptr = &alcResetDeviceSOFT_Lazy;
        [UnmanagedCallersOnly]
        private static byte alcResetDeviceSOFT_Lazy(IntPtr device, int* attrList)
        {
            _alcResetDeviceSOFT_fnptr = (delegate* unmanaged<IntPtr, int*, byte>)ALCLoader.BindingsContext.GetProcAddress("alcResetDeviceSOFT");
            return _alcResetDeviceSOFT_fnptr(device, attrList);
        }
        
        /// <summary><b>[entry point: <c>alcSetThreadContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, byte> _alcSetThreadContext_fnptr = &alcSetThreadContext_Lazy;
        [UnmanagedCallersOnly]
        private static byte alcSetThreadContext_Lazy(IntPtr context)
        {
            _alcSetThreadContext_fnptr = (delegate* unmanaged<IntPtr, byte>)ALCLoader.BindingsContext.GetProcAddress("alcSetThreadContext");
            return _alcSetThreadContext_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>alcSuspendContext</c>]</b></summary>
        public static delegate* unmanaged<IntPtr, void> _alcSuspendContext_fnptr = &alcSuspendContext_Lazy;
        [UnmanagedCallersOnly]
        private static void alcSuspendContext_Lazy(IntPtr context)
        {
            _alcSuspendContext_fnptr = (delegate* unmanaged<IntPtr, void>)ALCLoader.BindingsContext.GetProcAddress("alcSuspendContext");
            _alcSuspendContext_fnptr(context);
        }
        
        /// <summary><b>[entry point: <c>GetAudioChannel_LOKI</c>]</b></summary>
        public static delegate* unmanaged<uint, float> _GetAudioChannel_LOKI_fnptr = &GetAudioChannel_LOKI_Lazy;
        [UnmanagedCallersOnly]
        private static float GetAudioChannel_LOKI_Lazy(uint channel)
        {
            _GetAudioChannel_LOKI_fnptr = (delegate* unmanaged<uint, float>)ALCLoader.BindingsContext.GetProcAddress("GetAudioChannel_LOKI");
            return _GetAudioChannel_LOKI_fnptr(channel);
        }
        
        /// <summary><b>[entry point: <c>SetAudioChannel_LOKI</c>]</b></summary>
        public static delegate* unmanaged<uint, float, void> _SetAudioChannel_LOKI_fnptr = &SetAudioChannel_LOKI_Lazy;
        [UnmanagedCallersOnly]
        private static void SetAudioChannel_LOKI_Lazy(uint channel, float volume)
        {
            _SetAudioChannel_LOKI_fnptr = (delegate* unmanaged<uint, float, void>)ALCLoader.BindingsContext.GetProcAddress("SetAudioChannel_LOKI");
            _SetAudioChannel_LOKI_fnptr(channel, volume);
        }
        
    }
}

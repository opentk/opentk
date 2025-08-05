// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Core.Native;
using OpenTK.Mathematics;
using OpenTK.Audio;

namespace OpenTK.Audio.OpenAL.ALC
{
    public static unsafe partial class ALC
    {
        /// <inheritdoc cref="CaptureOpenDevice(byte*, uint, Format, int)"/>
        public static unsafe ALCDevice CaptureOpenDevice(string devicename, uint frequency, Format format, int buffersize)
        {
            ALCDevice returnValue;
            byte* devicename_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(devicename);
            returnValue = CaptureOpenDevice(devicename_ptr, frequency, format, buffersize);
            Marshal.FreeCoTaskMem((IntPtr)devicename_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="CaptureSamples(ALCDevice, void*, int)"/>
        public static unsafe void CaptureSamples(ALCDevice device, IntPtr buffer, int samples)
        {
            void* buffer_vptr = (void*)buffer;
            CaptureSamples(device, buffer_vptr, samples);
        }
        /// <inheritdoc cref="CaptureSamples(ALCDevice, void*, int)"/>
        public static unsafe void CaptureSamples<T1>(ALCDevice device, Span<T1> buffer, int samples)
            where T1 : unmanaged
        {
            fixed (void* buffer_ptr = buffer)
            {
                CaptureSamples(device, buffer_ptr, samples);
            }
        }
        /// <inheritdoc cref="CaptureSamples(ALCDevice, void*, int)"/>
        public static unsafe void CaptureSamples<T1>(ALCDevice device, T1[] buffer, int samples)
            where T1 : unmanaged
        {
            fixed (void* buffer_ptr = buffer)
            {
                CaptureSamples(device, buffer_ptr, samples);
            }
        }
        /// <inheritdoc cref="CaptureSamples(ALCDevice, void*, int)"/>
        public static unsafe void CaptureSamples<T1>(ALCDevice device, ref T1 buffer, int samples)
            where T1 : unmanaged
        {
            fixed (void* buffer_ptr = &buffer)
            {
                CaptureSamples(device, buffer_ptr, samples);
            }
        }
        /// <inheritdoc cref="CreateContext(ALCDevice, int*)"/>
        public static unsafe ALCContext CreateContext(ALCDevice device, ReadOnlySpan<int> attrlist)
        {
            ALCContext returnValue;
            fixed (int* attrlist_ptr = attrlist)
            {
                returnValue = CreateContext(device, attrlist_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContext(ALCDevice, int*)"/>
        public static unsafe ALCContext CreateContext(ALCDevice device, int[] attrlist)
        {
            ALCContext returnValue;
            fixed (int* attrlist_ptr = attrlist)
            {
                returnValue = CreateContext(device, attrlist_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContext(ALCDevice, int*)"/>
        public static unsafe ALCContext CreateContext(ALCDevice device, ref readonly int attrlist)
        {
            ALCContext returnValue;
            fixed (int* attrlist_ptr = &attrlist)
            {
                returnValue = CreateContext(device, attrlist_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEnumValue(ALCDevice, byte*)"/>
        public static unsafe All GetEnumValue(ALCDevice device, string enumname)
        {
            All returnValue;
            byte* enumname_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(enumname);
            returnValue = GetEnumValue(device, enumname_ptr);
            Marshal.FreeCoTaskMem((IntPtr)enumname_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="GetIntegerv(ALCDevice, GetPNameIV, int, int*)"/>
        public static unsafe void GetInteger(ALCDevice device, GetPNameIV param, int size, Span<int> values)
        {
            fixed (int* values_ptr = values)
            {
                GetIntegerv(device, param, size, values_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegerv(ALCDevice, GetPNameIV, int, int*)"/>
        public static unsafe void GetInteger(ALCDevice device, GetPNameIV param, int size, int[] values)
        {
            fixed (int* values_ptr = values)
            {
                GetIntegerv(device, param, size, values_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegerv(ALCDevice, GetPNameIV, int, int*)"/>
        public static unsafe void GetInteger(ALCDevice device, GetPNameIV param, int size, ref int values)
        {
            fixed (int* values_ptr = &values)
            {
                GetIntegerv(device, param, size, values_ptr);
            }
        }
        /// <inheritdoc cref="GetProcAddress(ALCDevice, byte*)"/>
        public static unsafe void* GetProcAddress(ALCDevice device, string extname)
        {
            void* returnValue;
            byte* extname_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(extname);
            returnValue = GetProcAddress(device, extname_ptr);
            Marshal.FreeCoTaskMem((IntPtr)extname_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="GetString_(ALCDevice, StringName)"/>
        public static unsafe string? GetString(ALCDevice device, StringName param)
        {
            string? returnValue_str;
            byte* returnValue;
            returnValue = GetString_(device, param);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <inheritdoc cref="IsExtensionPresent(ALCDevice, byte*)"/>
        public static unsafe bool IsExtensionPresent(ALCDevice deviceHandle, string extname)
        {
            bool returnValue;
            byte* extname_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(extname);
            returnValue = IsExtensionPresent(deviceHandle, extname_ptr);
            Marshal.FreeCoTaskMem((IntPtr)extname_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="OpenDevice(byte*)"/>
        public static unsafe ALCDevice OpenDevice(string devicename)
        {
            ALCDevice returnValue;
            byte* devicename_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(devicename);
            returnValue = OpenDevice(devicename_ptr);
            Marshal.FreeCoTaskMem((IntPtr)devicename_ptr);
            return returnValue;
        }
        public static unsafe partial class EXT
        {
            /// <inheritdoc cref="ASAGetListener(uint, void*, uint*)"/>
            public static unsafe All ASAGetListener(uint property, IntPtr data, Span<uint> dataSize)
            {
                All returnValue;
                fixed (uint* dataSize_ptr = dataSize)
                {
                    void* data_vptr = (void*)data;
                    returnValue = ASAGetListener(property, data_vptr, dataSize_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASAGetListener(uint, void*, uint*)"/>
            public static unsafe All ASAGetListener(uint property, IntPtr data, uint[] dataSize)
            {
                All returnValue;
                fixed (uint* dataSize_ptr = dataSize)
                {
                    void* data_vptr = (void*)data;
                    returnValue = ASAGetListener(property, data_vptr, dataSize_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASAGetListener(uint, void*, uint*)"/>
            public static unsafe All ASAGetListener(uint property, IntPtr data, ref uint dataSize)
            {
                All returnValue;
                fixed (uint* dataSize_ptr = &dataSize)
                {
                    void* data_vptr = (void*)data;
                    returnValue = ASAGetListener(property, data_vptr, dataSize_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASAGetListener(uint, void*, uint*)"/>
            public static unsafe All ASAGetListener<T1>(uint property, Span<T1> data, Span<uint> dataSize)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (uint* dataSize_ptr = dataSize)
                {
                    fixed (void* data_ptr = data)
                    {
                        returnValue = ASAGetListener(property, data_ptr, dataSize_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASAGetListener(uint, void*, uint*)"/>
            public static unsafe All ASAGetListener<T1>(uint property, T1[] data, uint[] dataSize)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (uint* dataSize_ptr = dataSize)
                {
                    fixed (void* data_ptr = data)
                    {
                        returnValue = ASAGetListener(property, data_ptr, dataSize_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASAGetListener(uint, void*, uint*)"/>
            public static unsafe All ASAGetListener<T1>(uint property, ref T1 data, ref uint dataSize)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* data_ptr = &data)
                fixed (uint* dataSize_ptr = &dataSize)
                {
                    returnValue = ASAGetListener(property, data_ptr, dataSize_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASAGetSource(uint, uint, void*, uint*)"/>
            public static unsafe All ASAGetSource(uint property, uint source, IntPtr data, Span<uint> dataSize)
            {
                All returnValue;
                fixed (uint* dataSize_ptr = dataSize)
                {
                    void* data_vptr = (void*)data;
                    returnValue = ASAGetSource(property, source, data_vptr, dataSize_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASAGetSource(uint, uint, void*, uint*)"/>
            public static unsafe All ASAGetSource(uint property, uint source, IntPtr data, uint[] dataSize)
            {
                All returnValue;
                fixed (uint* dataSize_ptr = dataSize)
                {
                    void* data_vptr = (void*)data;
                    returnValue = ASAGetSource(property, source, data_vptr, dataSize_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASAGetSource(uint, uint, void*, uint*)"/>
            public static unsafe All ASAGetSource(uint property, uint source, IntPtr data, ref uint dataSize)
            {
                All returnValue;
                fixed (uint* dataSize_ptr = &dataSize)
                {
                    void* data_vptr = (void*)data;
                    returnValue = ASAGetSource(property, source, data_vptr, dataSize_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASAGetSource(uint, uint, void*, uint*)"/>
            public static unsafe All ASAGetSource<T1>(uint property, uint source, Span<T1> data, Span<uint> dataSize)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (uint* dataSize_ptr = dataSize)
                {
                    fixed (void* data_ptr = data)
                    {
                        returnValue = ASAGetSource(property, source, data_ptr, dataSize_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASAGetSource(uint, uint, void*, uint*)"/>
            public static unsafe All ASAGetSource<T1>(uint property, uint source, T1[] data, uint[] dataSize)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (uint* dataSize_ptr = dataSize)
                {
                    fixed (void* data_ptr = data)
                    {
                        returnValue = ASAGetSource(property, source, data_ptr, dataSize_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASAGetSource(uint, uint, void*, uint*)"/>
            public static unsafe All ASAGetSource<T1>(uint property, uint source, ref T1 data, ref uint dataSize)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* data_ptr = &data)
                fixed (uint* dataSize_ptr = &dataSize)
                {
                    returnValue = ASAGetSource(property, source, data_ptr, dataSize_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASASetListener(uint, void*, uint)"/>
            public static unsafe All ASASetListener(uint property, IntPtr data, uint dataSize)
            {
                All returnValue;
                void* data_vptr = (void*)data;
                returnValue = ASASetListener(property, data_vptr, dataSize);
                return returnValue;
            }
            /// <inheritdoc cref="ASASetListener(uint, void*, uint)"/>
            public static unsafe All ASASetListener<T1>(uint property, Span<T1> data, uint dataSize)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* data_ptr = data)
                {
                    returnValue = ASASetListener(property, data_ptr, dataSize);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASASetListener(uint, void*, uint)"/>
            public static unsafe All ASASetListener<T1>(uint property, T1[] data, uint dataSize)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* data_ptr = data)
                {
                    returnValue = ASASetListener(property, data_ptr, dataSize);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASASetListener(uint, void*, uint)"/>
            public static unsafe All ASASetListener<T1>(uint property, ref T1 data, uint dataSize)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* data_ptr = &data)
                {
                    returnValue = ASASetListener(property, data_ptr, dataSize);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASASetSource(uint, uint, void*, uint)"/>
            public static unsafe All ASASetSource(uint property, uint source, IntPtr data, uint dataSize)
            {
                All returnValue;
                void* data_vptr = (void*)data;
                returnValue = ASASetSource(property, source, data_vptr, dataSize);
                return returnValue;
            }
            /// <inheritdoc cref="ASASetSource(uint, uint, void*, uint)"/>
            public static unsafe All ASASetSource<T1>(uint property, uint source, Span<T1> data, uint dataSize)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* data_ptr = data)
                {
                    returnValue = ASASetSource(property, source, data_ptr, dataSize);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASASetSource(uint, uint, void*, uint)"/>
            public static unsafe All ASASetSource<T1>(uint property, uint source, T1[] data, uint dataSize)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* data_ptr = data)
                {
                    returnValue = ASASetSource(property, source, data_ptr, dataSize);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ASASetSource(uint, uint, void*, uint)"/>
            public static unsafe All ASASetSource<T1>(uint property, uint source, ref T1 data, uint dataSize)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* data_ptr = &data)
                {
                    returnValue = ASASetSource(property, source, data_ptr, dataSize);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CaptureOpenDevice(byte*, uint, Format, int)"/>
            public static unsafe ALCDevice CaptureOpenDevice(string devicename, uint frequency, Format format, int buffersize)
            {
                ALCDevice returnValue;
                byte* devicename_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(devicename);
                returnValue = CaptureOpenDevice(devicename_ptr, frequency, format, buffersize);
                Marshal.FreeCoTaskMem((IntPtr)devicename_ptr);
                return returnValue;
            }
            /// <inheritdoc cref="CaptureSamples(ALCDevice, void*, int)"/>
            public static unsafe void CaptureSamples(ALCDevice device, IntPtr buffer, int samples)
            {
                void* buffer_vptr = (void*)buffer;
                CaptureSamples(device, buffer_vptr, samples);
            }
            /// <inheritdoc cref="CaptureSamples(ALCDevice, void*, int)"/>
            public static unsafe void CaptureSamples<T1>(ALCDevice device, Span<T1> buffer, int samples)
                where T1 : unmanaged
            {
                fixed (void* buffer_ptr = buffer)
                {
                    CaptureSamples(device, buffer_ptr, samples);
                }
            }
            /// <inheritdoc cref="CaptureSamples(ALCDevice, void*, int)"/>
            public static unsafe void CaptureSamples<T1>(ALCDevice device, T1[] buffer, int samples)
                where T1 : unmanaged
            {
                fixed (void* buffer_ptr = buffer)
                {
                    CaptureSamples(device, buffer_ptr, samples);
                }
            }
            /// <inheritdoc cref="CaptureSamples(ALCDevice, void*, int)"/>
            public static unsafe void CaptureSamples<T1>(ALCDevice device, ref T1 buffer, int samples)
                where T1 : unmanaged
            {
                fixed (void* buffer_ptr = &buffer)
                {
                    CaptureSamples(device, buffer_ptr, samples);
                }
            }
            /// <inheritdoc cref="GetProcAddress2(ALCDevice, byte*)"/>
            public static unsafe void* GetProcAddress2(ALCDevice device, string funcName)
            {
                void* returnValue;
                byte* funcName_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(funcName);
                returnValue = GetProcAddress2(device, funcName_ptr);
                Marshal.FreeCoTaskMem((IntPtr)funcName_ptr);
                return returnValue;
            }
            /// <inheritdoc cref="OutputCapturerSamples(void*, int)"/>
            public static unsafe void OutputCapturerSamples(IntPtr buffer, int maxsamplecount)
            {
                void* buffer_vptr = (void*)buffer;
                OutputCapturerSamples(buffer_vptr, maxsamplecount);
            }
            /// <inheritdoc cref="OutputCapturerSamples(void*, int)"/>
            public static unsafe void OutputCapturerSamples<T1>(Span<T1> buffer, int maxsamplecount)
                where T1 : unmanaged
            {
                fixed (void* buffer_ptr = buffer)
                {
                    OutputCapturerSamples(buffer_ptr, maxsamplecount);
                }
            }
            /// <inheritdoc cref="OutputCapturerSamples(void*, int)"/>
            public static unsafe void OutputCapturerSamples<T1>(T1[] buffer, int maxsamplecount)
                where T1 : unmanaged
            {
                fixed (void* buffer_ptr = buffer)
                {
                    OutputCapturerSamples(buffer_ptr, maxsamplecount);
                }
            }
            /// <inheritdoc cref="OutputCapturerSamples(void*, int)"/>
            public static unsafe void OutputCapturerSamples<T1>(ref T1 buffer, int maxsamplecount)
                where T1 : unmanaged
            {
                fixed (void* buffer_ptr = &buffer)
                {
                    OutputCapturerSamples(buffer_ptr, maxsamplecount);
                }
            }
        }
        public static unsafe partial class LOKI
        {
        }
        public static unsafe partial class SOFT
        {
            /// <inheritdoc cref="EventCallbackSOFT(delegate* unmanaged[Cdecl]<All, All, ALCDevice, nuint, byte*, void*, void>, void*)"/>
            public static unsafe void EventCallbackSOFT(delegate* unmanaged[Cdecl]<All, All, ALCDevice, nuint, byte*, void*, void> callback, IntPtr userParam)
            {
                void* userParam_vptr = (void*)userParam;
                EventCallbackSOFT(callback, userParam_vptr);
            }
            /// <inheritdoc cref="EventCallbackSOFT(delegate* unmanaged[Cdecl]<All, All, ALCDevice, nuint, byte*, void*, void>, void*)"/>
            public static unsafe void EventCallbackSOFT<T1>(delegate* unmanaged[Cdecl]<All, All, ALCDevice, nuint, byte*, void*, void> callback, Span<T1> userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = userParam)
                {
                    EventCallbackSOFT(callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="EventCallbackSOFT(delegate* unmanaged[Cdecl]<All, All, ALCDevice, nuint, byte*, void*, void>, void*)"/>
            public static unsafe void EventCallbackSOFT<T1>(delegate* unmanaged[Cdecl]<All, All, ALCDevice, nuint, byte*, void*, void> callback, T1[] userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = userParam)
                {
                    EventCallbackSOFT(callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="EventCallbackSOFT(delegate* unmanaged[Cdecl]<All, All, ALCDevice, nuint, byte*, void*, void>, void*)"/>
            public static unsafe void EventCallbackSOFT<T1>(delegate* unmanaged[Cdecl]<All, All, ALCDevice, nuint, byte*, void*, void> callback, ref T1 userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = &userParam)
                {
                    EventCallbackSOFT(callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="EventControlSOFT(int, EventType*, bool)"/>
            public static unsafe bool EventControlSOFT(int count, ReadOnlySpan<EventType> events, bool enable)
            {
                bool returnValue;
                fixed (EventType* events_ptr = events)
                {
                    returnValue = EventControlSOFT(count, events_ptr, enable);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EventControlSOFT(int, EventType*, bool)"/>
            public static unsafe bool EventControlSOFT(int count, EventType[] events, bool enable)
            {
                bool returnValue;
                fixed (EventType* events_ptr = events)
                {
                    returnValue = EventControlSOFT(count, events_ptr, enable);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EventControlSOFT(int, EventType*, bool)"/>
            public static unsafe bool EventControlSOFT(int count, ref readonly EventType events, bool enable)
            {
                bool returnValue;
                fixed (EventType* events_ptr = &events)
                {
                    returnValue = EventControlSOFT(count, events_ptr, enable);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetInteger64vSOFT(ALCDevice, GetPNameI64V, int, long*)"/>
            public static unsafe void GetInteger64vSOFT(ALCDevice device, GetPNameI64V pname, int size, Span<long> values)
            {
                fixed (long* values_ptr = values)
                {
                    GetInteger64vSOFT(device, pname, size, values_ptr);
                }
            }
            /// <inheritdoc cref="GetInteger64vSOFT(ALCDevice, GetPNameI64V, int, long*)"/>
            public static unsafe void GetInteger64vSOFT(ALCDevice device, GetPNameI64V pname, int size, long[] values)
            {
                fixed (long* values_ptr = values)
                {
                    GetInteger64vSOFT(device, pname, size, values_ptr);
                }
            }
            /// <inheritdoc cref="GetInteger64vSOFT(ALCDevice, GetPNameI64V, int, long*)"/>
            public static unsafe void GetInteger64vSOFT(ALCDevice device, GetPNameI64V pname, int size, ref long values)
            {
                fixed (long* values_ptr = &values)
                {
                    GetInteger64vSOFT(device, pname, size, values_ptr);
                }
            }
            /// <inheritdoc cref="GetStringiSOFT_(ALCDevice, IndexedStringName, int)"/>
            public static unsafe string? GetStringiSOFT(ALCDevice device, IndexedStringName paramName, int index)
            {
                string? returnValue_str;
                byte* returnValue;
                returnValue = GetStringiSOFT_(device, paramName, index);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="RenderSamplesSOFT(ALCDevice, void*, int)"/>
            public static unsafe void RenderSamplesSOFT(ALCDevice device, IntPtr buffer, int samples)
            {
                void* buffer_vptr = (void*)buffer;
                RenderSamplesSOFT(device, buffer_vptr, samples);
            }
            /// <inheritdoc cref="RenderSamplesSOFT(ALCDevice, void*, int)"/>
            public static unsafe void RenderSamplesSOFT<T1>(ALCDevice device, Span<T1> buffer, int samples)
                where T1 : unmanaged
            {
                fixed (void* buffer_ptr = buffer)
                {
                    RenderSamplesSOFT(device, buffer_ptr, samples);
                }
            }
            /// <inheritdoc cref="RenderSamplesSOFT(ALCDevice, void*, int)"/>
            public static unsafe void RenderSamplesSOFT<T1>(ALCDevice device, T1[] buffer, int samples)
                where T1 : unmanaged
            {
                fixed (void* buffer_ptr = buffer)
                {
                    RenderSamplesSOFT(device, buffer_ptr, samples);
                }
            }
            /// <inheritdoc cref="RenderSamplesSOFT(ALCDevice, void*, int)"/>
            public static unsafe void RenderSamplesSOFT<T1>(ALCDevice device, ref T1 buffer, int samples)
                where T1 : unmanaged
            {
                fixed (void* buffer_ptr = &buffer)
                {
                    RenderSamplesSOFT(device, buffer_ptr, samples);
                }
            }
            /// <inheritdoc cref="ReopenDeviceSOFT(ALCDevice, byte*, int*)"/>
            public static unsafe bool ReopenDeviceSOFT(ALCDevice device, string deviceName, ReadOnlySpan<int> attribs)
            {
                bool returnValue;
                fixed (int* attribs_ptr = attribs)
                {
                    byte* deviceName_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(deviceName);
                    returnValue = ReopenDeviceSOFT(device, deviceName_ptr, attribs_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)deviceName_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReopenDeviceSOFT(ALCDevice, byte*, int*)"/>
            public static unsafe bool ReopenDeviceSOFT(ALCDevice device, string deviceName, int[] attribs)
            {
                bool returnValue;
                fixed (int* attribs_ptr = attribs)
                {
                    byte* deviceName_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(deviceName);
                    returnValue = ReopenDeviceSOFT(device, deviceName_ptr, attribs_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)deviceName_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReopenDeviceSOFT(ALCDevice, byte*, int*)"/>
            public static unsafe bool ReopenDeviceSOFT(ALCDevice device, string deviceName, ref readonly int attribs)
            {
                bool returnValue;
                fixed (int* attribs_ptr = &attribs)
                {
                    byte* deviceName_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(deviceName);
                    returnValue = ReopenDeviceSOFT(device, deviceName_ptr, attribs_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)deviceName_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ResetDeviceSOFT(ALCDevice, int*)"/>
            public static unsafe bool ResetDeviceSOFT(ALCDevice device, ReadOnlySpan<int> attrList)
            {
                bool returnValue;
                fixed (int* attrList_ptr = attrList)
                {
                    returnValue = ResetDeviceSOFT(device, attrList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ResetDeviceSOFT(ALCDevice, int*)"/>
            public static unsafe bool ResetDeviceSOFT(ALCDevice device, int[] attrList)
            {
                bool returnValue;
                fixed (int* attrList_ptr = attrList)
                {
                    returnValue = ResetDeviceSOFT(device, attrList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ResetDeviceSOFT(ALCDevice, int*)"/>
            public static unsafe bool ResetDeviceSOFT(ALCDevice device, ref readonly int attrList)
            {
                bool returnValue;
                fixed (int* attrList_ptr = &attrList)
                {
                    returnValue = ResetDeviceSOFT(device, attrList_ptr);
                }
                return returnValue;
            }
        }
    }
}

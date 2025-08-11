// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Core.Native;
using OpenTK.Mathematics;
using OpenTK.Audio;

namespace OpenTK.Audio.OpenAL
{
    public static unsafe partial class AL
    {
        /// <inheritdoc cref="BufferData(int, Format, void*, int, int)"/>
        public static unsafe void BufferData(int buffer, Format format, IntPtr data, int size, int samplerate)
        {
            void* data_vptr = (void*)data;
            BufferData(buffer, format, data_vptr, size, samplerate);
        }
        /// <inheritdoc cref="BufferData(int, Format, void*, int, int)"/>
        public static unsafe void BufferData<T1>(int buffer, Format format, ReadOnlySpan<T1> data, int size, int samplerate)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = data)
            {
                BufferData(buffer, format, data_ptr, size, samplerate);
            }
        }
        /// <inheritdoc cref="BufferData(int, Format, void*, int, int)"/>
        public static unsafe void BufferData<T1>(int buffer, Format format, T1[] data, int size, int samplerate)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = data)
            {
                BufferData(buffer, format, data_ptr, size, samplerate);
            }
        }
        /// <inheritdoc cref="BufferData(int, Format, void*, int, int)"/>
        public static unsafe void BufferData<T1>(int buffer, Format format, ref readonly T1 data, int size, int samplerate)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                BufferData(buffer, format, data_ptr, size, samplerate);
            }
        }
        /// <inheritdoc cref="Bufferfv(int, BufferPNameFV, float*)"/>
        public static unsafe void Bufferfv(int buffer, BufferPNameFV param, ReadOnlySpan<float> value)
        {
            fixed (float* value_ptr = value)
            {
                Bufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Bufferfv(int, BufferPNameFV, float*)"/>
        public static unsafe void Bufferfv(int buffer, BufferPNameFV param, float[] value)
        {
            fixed (float* value_ptr = value)
            {
                Bufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Bufferfv(int, BufferPNameFV, float*)"/>
        public static unsafe void Bufferfv(int buffer, BufferPNameFV param, ref readonly float value)
        {
            fixed (float* value_ptr = &value)
            {
                Bufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Bufferiv(int, BufferPNameIV, int*)"/>
        public static unsafe void Bufferiv(int buffer, BufferPNameIV param, ReadOnlySpan<int> value)
        {
            fixed (int* value_ptr = value)
            {
                Bufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Bufferiv(int, BufferPNameIV, int*)"/>
        public static unsafe void Bufferiv(int buffer, BufferPNameIV param, int[] value)
        {
            fixed (int* value_ptr = value)
            {
                Bufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Bufferiv(int, BufferPNameIV, int*)"/>
        public static unsafe void Bufferiv(int buffer, BufferPNameIV param, ref readonly int value)
        {
            fixed (int* value_ptr = &value)
            {
                Bufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="DeleteBuffers(int, int*)"/>
        public static unsafe void DeleteBuffer(int buffer)
        {
            int n = 1;
            int* buffers_handle = &buffer;
            DeleteBuffers(n, buffers_handle);
        }
        /// <inheritdoc cref="DeleteBuffers(int, int*)"/>
        public static unsafe void DeleteBuffers(int n, ReadOnlySpan<int> buffers)
        {
            fixed (int* buffers_ptr = buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteBuffers(int, int*)"/>
        public static unsafe void DeleteBuffers(int n, int[] buffers)
        {
            fixed (int* buffers_ptr = buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteBuffers(int, int*)"/>
        public static unsafe void DeleteBuffers(int n, ref readonly int buffers)
        {
            fixed (int* buffers_ptr = &buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteSources(int, int*)"/>
        public static unsafe void DeleteSource(int source)
        {
            int n = 1;
            int* sources_handle = &source;
            DeleteSources(n, sources_handle);
        }
        /// <inheritdoc cref="DeleteSources(int, int*)"/>
        public static unsafe void DeleteSources(int n, ReadOnlySpan<int> sources)
        {
            fixed (int* sources_ptr = sources)
            {
                DeleteSources(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="DeleteSources(int, int*)"/>
        public static unsafe void DeleteSources(int n, int[] sources)
        {
            fixed (int* sources_ptr = sources)
            {
                DeleteSources(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="DeleteSources(int, int*)"/>
        public static unsafe void DeleteSources(int n, ref readonly int sources)
        {
            fixed (int* sources_ptr = &sources)
            {
                DeleteSources(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="GenBuffers(int, int*)"/>
        public static unsafe int GenBuffer()
        {
            int buffer;
            int n = 1;
            Unsafe.SkipInit(out buffer);
            int* buffers_handle = &buffer;
            GenBuffers(n, buffers_handle);
            return buffer;
        }
        /// <inheritdoc cref="GenBuffers(int, int*)"/>
        public static unsafe void GenBuffer(out int buffer)
        {
            int n = 1;
            Unsafe.SkipInit(out buffer);
            fixed(int* buffers_handle = &buffer)
            {
                GenBuffers(n, buffers_handle);
            }
        }
        /// <inheritdoc cref="GenBuffers(int, int*)"/>
        public static unsafe void GenBuffers(int n, Span<int> buffers)
        {
            fixed (int* buffers_ptr = buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="GenBuffers(int, int*)"/>
        public static unsafe void GenBuffers(int n, int[] buffers)
        {
            fixed (int* buffers_ptr = buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="GenBuffers(int, int*)"/>
        public static unsafe void GenBuffers(int n, ref int buffers)
        {
            fixed (int* buffers_ptr = &buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="GenSources(int, int*)"/>
        public static unsafe int GenSource()
        {
            int source;
            int n = 1;
            Unsafe.SkipInit(out source);
            int* sources_handle = &source;
            GenSources(n, sources_handle);
            return source;
        }
        /// <inheritdoc cref="GenSources(int, int*)"/>
        public static unsafe void GenSource(out int source)
        {
            int n = 1;
            Unsafe.SkipInit(out source);
            fixed(int* sources_handle = &source)
            {
                GenSources(n, sources_handle);
            }
        }
        /// <inheritdoc cref="GenSources(int, int*)"/>
        public static unsafe void GenSources(int n, Span<int> sources)
        {
            fixed (int* sources_ptr = sources)
            {
                GenSources(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="GenSources(int, int*)"/>
        public static unsafe void GenSources(int n, int[] sources)
        {
            fixed (int* sources_ptr = sources)
            {
                GenSources(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="GenSources(int, int*)"/>
        public static unsafe void GenSources(int n, ref int sources)
        {
            fixed (int* sources_ptr = &sources)
            {
                GenSources(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleanv(GetPNameBV, bool*)"/>
        public static unsafe void GetBoolean(GetPNameBV param, Span<bool> values)
        {
            fixed (bool* values_ptr = values)
            {
                GetBooleanv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleanv(GetPNameBV, bool*)"/>
        public static unsafe void GetBoolean(GetPNameBV param, bool[] values)
        {
            fixed (bool* values_ptr = values)
            {
                GetBooleanv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleanv(GetPNameBV, bool*)"/>
        public static unsafe void GetBoolean(GetPNameBV param, ref bool values)
        {
            fixed (bool* values_ptr = &values)
            {
                GetBooleanv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetBuffer3f(int, BufferGetPName3F, float*, float*, float*)"/>
        public static unsafe float GetBuffer3f(int buffer, BufferGetPName3F param, out float value1, out float value2)
        {
            float value3;
            float* value3_ptr = &value3;
            fixed (float* value1_ptr = &value1)
            fixed (float* value2_ptr = &value2)
            {
                GetBuffer3f(buffer, param, value1_ptr, value2_ptr, value3_ptr);
            }
            return value3;
        }
        /// <inheritdoc cref="GetBuffer3f(int, BufferGetPName3F, float*, float*, float*)"/>
        public static unsafe void GetBuffer3f(int buffer, BufferGetPName3F param, out float value1, out float value2, out float value3)
        {
            fixed (float* value1_ptr = &value1)
            fixed (float* value2_ptr = &value2)
            fixed (float* value3_ptr = &value3)
            {
                GetBuffer3f(buffer, param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetBuffer3i(int, BufferGetPName3I, int*, int*, int*)"/>
        public static unsafe int GetBuffer3i(int buffer, BufferGetPName3I param, out int value1, out int value2)
        {
            int value3;
            int* value3_ptr = &value3;
            fixed (int* value1_ptr = &value1)
            fixed (int* value2_ptr = &value2)
            {
                GetBuffer3i(buffer, param, value1_ptr, value2_ptr, value3_ptr);
            }
            return value3;
        }
        /// <inheritdoc cref="GetBuffer3i(int, BufferGetPName3I, int*, int*, int*)"/>
        public static unsafe void GetBuffer3i(int buffer, BufferGetPName3I param, out int value1, out int value2, out int value3)
        {
            fixed (int* value1_ptr = &value1)
            fixed (int* value2_ptr = &value2)
            fixed (int* value3_ptr = &value3)
            {
                GetBuffer3i(buffer, param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferf(int, BufferGetPNameF, float*)"/>
        public static unsafe float GetBufferf(int buffer, BufferGetPNameF param)
        {
            float value;
            float* value_ptr = &value;
            {
                GetBufferf(buffer, param, value_ptr);
            }
            return value;
        }
        /// <inheritdoc cref="GetBufferf(int, BufferGetPNameF, float*)"/>
        public static unsafe void GetBufferf(int buffer, BufferGetPNameF param, out float value)
        {
            fixed (float* value_ptr = &value)
            {
                GetBufferf(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferfv(int, BufferGetPNameFV, float*)"/>
        public static unsafe void GetBufferfv(int buffer, BufferGetPNameFV param, Span<float> value)
        {
            fixed (float* value_ptr = value)
            {
                GetBufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferfv(int, BufferGetPNameFV, float*)"/>
        public static unsafe void GetBufferfv(int buffer, BufferGetPNameFV param, float[] value)
        {
            fixed (float* value_ptr = value)
            {
                GetBufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferfv(int, BufferGetPNameFV, float*)"/>
        public static unsafe void GetBufferfv(int buffer, BufferGetPNameFV param, ref float value)
        {
            fixed (float* value_ptr = &value)
            {
                GetBufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferi(int, BufferGetPNameI, int*)"/>
        public static unsafe int GetBufferi(int buffer, BufferGetPNameI param)
        {
            int value;
            int* value_ptr = &value;
            {
                GetBufferi(buffer, param, value_ptr);
            }
            return value;
        }
        /// <inheritdoc cref="GetBufferi(int, BufferGetPNameI, int*)"/>
        public static unsafe void GetBufferi(int buffer, BufferGetPNameI param, out int value)
        {
            fixed (int* value_ptr = &value)
            {
                GetBufferi(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferiv(int, BufferGetPNameIV, int*)"/>
        public static unsafe void GetBufferiv(int buffer, BufferGetPNameIV param, Span<int> value)
        {
            fixed (int* value_ptr = value)
            {
                GetBufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferiv(int, BufferGetPNameIV, int*)"/>
        public static unsafe void GetBufferiv(int buffer, BufferGetPNameIV param, int[] value)
        {
            fixed (int* value_ptr = value)
            {
                GetBufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferiv(int, BufferGetPNameIV, int*)"/>
        public static unsafe void GetBufferiv(int buffer, BufferGetPNameIV param, ref int value)
        {
            fixed (int* value_ptr = &value)
            {
                GetBufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetDoublev(GetPNameDV, double*)"/>
        public static unsafe void GetDouble(GetPNameDV param, Span<double> values)
        {
            fixed (double* values_ptr = values)
            {
                GetDoublev(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetDoublev(GetPNameDV, double*)"/>
        public static unsafe void GetDouble(GetPNameDV param, double[] values)
        {
            fixed (double* values_ptr = values)
            {
                GetDoublev(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetDoublev(GetPNameDV, double*)"/>
        public static unsafe void GetDouble(GetPNameDV param, ref double values)
        {
            fixed (double* values_ptr = &values)
            {
                GetDoublev(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetEnumValue(byte*)"/>
        public static unsafe All GetEnumValue(string ename)
        {
            All returnValue;
            byte* ename_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(ename);
            returnValue = GetEnumValue(ename_ptr);
            Marshal.FreeCoTaskMem((IntPtr)ename_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="GetFloatv(GetPNameFV, float*)"/>
        public static unsafe void GetFloat(GetPNameFV param, Span<float> values)
        {
            fixed (float* values_ptr = values)
            {
                GetFloatv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetFloatv(GetPNameFV, float*)"/>
        public static unsafe void GetFloat(GetPNameFV param, float[] values)
        {
            fixed (float* values_ptr = values)
            {
                GetFloatv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetFloatv(GetPNameFV, float*)"/>
        public static unsafe void GetFloat(GetPNameFV param, ref float values)
        {
            fixed (float* values_ptr = &values)
            {
                GetFloatv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegerv(GetPNameIV, int*)"/>
        public static unsafe void GetInteger(GetPNameIV param, Span<int> values)
        {
            fixed (int* values_ptr = values)
            {
                GetIntegerv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegerv(GetPNameIV, int*)"/>
        public static unsafe void GetInteger(GetPNameIV param, int[] values)
        {
            fixed (int* values_ptr = values)
            {
                GetIntegerv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegerv(GetPNameIV, int*)"/>
        public static unsafe void GetInteger(GetPNameIV param, ref int values)
        {
            fixed (int* values_ptr = &values)
            {
                GetIntegerv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetListener3f(ListenerGetPName3F, float*, float*, float*)"/>
        public static unsafe float GetListener3f(ListenerGetPName3F param, out float value1, out float value2)
        {
            float value3;
            float* value3_ptr = &value3;
            fixed (float* value1_ptr = &value1)
            fixed (float* value2_ptr = &value2)
            {
                GetListener3f(param, value1_ptr, value2_ptr, value3_ptr);
            }
            return value3;
        }
        /// <inheritdoc cref="GetListener3f(ListenerGetPName3F, float*, float*, float*)"/>
        public static unsafe void GetListener3f(ListenerGetPName3F param, out float value1, out float value2, out float value3)
        {
            fixed (float* value1_ptr = &value1)
            fixed (float* value2_ptr = &value2)
            fixed (float* value3_ptr = &value3)
            {
                GetListener3f(param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetListener3i(ListenerGetPName3I, int*, int*, int*)"/>
        public static unsafe int GetListener3i(ListenerGetPName3I param, out int value1, out int value2)
        {
            int value3;
            int* value3_ptr = &value3;
            fixed (int* value1_ptr = &value1)
            fixed (int* value2_ptr = &value2)
            {
                GetListener3i(param, value1_ptr, value2_ptr, value3_ptr);
            }
            return value3;
        }
        /// <inheritdoc cref="GetListener3i(ListenerGetPName3I, int*, int*, int*)"/>
        public static unsafe void GetListener3i(ListenerGetPName3I param, out int value1, out int value2, out int value3)
        {
            fixed (int* value1_ptr = &value1)
            fixed (int* value2_ptr = &value2)
            fixed (int* value3_ptr = &value3)
            {
                GetListener3i(param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetListenerf(ListenerGetPNameF, float*)"/>
        public static unsafe float GetListenerf(ListenerGetPNameF param)
        {
            float value;
            float* value_ptr = &value;
            {
                GetListenerf(param, value_ptr);
            }
            return value;
        }
        /// <inheritdoc cref="GetListenerf(ListenerGetPNameF, float*)"/>
        public static unsafe void GetListenerf(ListenerGetPNameF param, out float value)
        {
            fixed (float* value_ptr = &value)
            {
                GetListenerf(param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetListenerfv(ListenerGetPNameFV, float*)"/>
        public static unsafe void GetListenerfv(ListenerGetPNameFV param, Span<float> values)
        {
            fixed (float* values_ptr = values)
            {
                GetListenerfv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetListenerfv(ListenerGetPNameFV, float*)"/>
        public static unsafe void GetListenerfv(ListenerGetPNameFV param, float[] values)
        {
            fixed (float* values_ptr = values)
            {
                GetListenerfv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetListenerfv(ListenerGetPNameFV, float*)"/>
        public static unsafe void GetListenerfv(ListenerGetPNameFV param, ref float values)
        {
            fixed (float* values_ptr = &values)
            {
                GetListenerfv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetListeneri(ListenerGetPNameI, int*)"/>
        public static unsafe int GetListeneri(ListenerGetPNameI param)
        {
            int value;
            int* value_ptr = &value;
            {
                GetListeneri(param, value_ptr);
            }
            return value;
        }
        /// <inheritdoc cref="GetListeneri(ListenerGetPNameI, int*)"/>
        public static unsafe void GetListeneri(ListenerGetPNameI param, out int value)
        {
            fixed (int* value_ptr = &value)
            {
                GetListeneri(param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetListeneriv(ListenerGetPNameIV, int*)"/>
        public static unsafe void GetListeneriv(ListenerGetPNameIV param, Span<int> values)
        {
            fixed (int* values_ptr = values)
            {
                GetListeneriv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetListeneriv(ListenerGetPNameIV, int*)"/>
        public static unsafe void GetListeneriv(ListenerGetPNameIV param, int[] values)
        {
            fixed (int* values_ptr = values)
            {
                GetListeneriv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetListeneriv(ListenerGetPNameIV, int*)"/>
        public static unsafe void GetListeneriv(ListenerGetPNameIV param, ref int values)
        {
            fixed (int* values_ptr = &values)
            {
                GetListeneriv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetProcAddress(byte*)"/>
        public static unsafe void* GetProcAddress(string fname)
        {
            void* returnValue;
            byte* fname_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(fname);
            returnValue = GetProcAddress(fname_ptr);
            Marshal.FreeCoTaskMem((IntPtr)fname_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="GetSource3f(int, SourceGetPName3F, float*, float*, float*)"/>
        public static unsafe float GetSource3f(int source, SourceGetPName3F param, out float value1, out float value2)
        {
            float value3;
            float* value3_ptr = &value3;
            fixed (float* value1_ptr = &value1)
            fixed (float* value2_ptr = &value2)
            {
                GetSource3f(source, param, value1_ptr, value2_ptr, value3_ptr);
            }
            return value3;
        }
        /// <inheritdoc cref="GetSource3f(int, SourceGetPName3F, float*, float*, float*)"/>
        public static unsafe void GetSource3f(int source, SourceGetPName3F param, out float value1, out float value2, out float value3)
        {
            fixed (float* value1_ptr = &value1)
            fixed (float* value2_ptr = &value2)
            fixed (float* value3_ptr = &value3)
            {
                GetSource3f(source, param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetSource3i(int, SourceGetPName3I, int*, int*, int*)"/>
        public static unsafe int GetSource3i(int source, SourceGetPName3I param, out int value1, out int value2)
        {
            int value3;
            int* value3_ptr = &value3;
            fixed (int* value1_ptr = &value1)
            fixed (int* value2_ptr = &value2)
            {
                GetSource3i(source, param, value1_ptr, value2_ptr, value3_ptr);
            }
            return value3;
        }
        /// <inheritdoc cref="GetSource3i(int, SourceGetPName3I, int*, int*, int*)"/>
        public static unsafe void GetSource3i(int source, SourceGetPName3I param, out int value1, out int value2, out int value3)
        {
            fixed (int* value1_ptr = &value1)
            fixed (int* value2_ptr = &value2)
            fixed (int* value3_ptr = &value3)
            {
                GetSource3i(source, param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcef(int, SourceGetPNameF, float*)"/>
        public static unsafe float GetSourcef(int source, SourceGetPNameF param)
        {
            float value;
            float* value_ptr = &value;
            {
                GetSourcef(source, param, value_ptr);
            }
            return value;
        }
        /// <inheritdoc cref="GetSourcef(int, SourceGetPNameF, float*)"/>
        public static unsafe void GetSourcef(int source, SourceGetPNameF param, out float value)
        {
            fixed (float* value_ptr = &value)
            {
                GetSourcef(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcefv(int, SourceGetPNameFV, float*)"/>
        public static unsafe void GetSourcefv(int source, SourceGetPNameFV param, Span<float> values)
        {
            fixed (float* values_ptr = values)
            {
                GetSourcefv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcefv(int, SourceGetPNameFV, float*)"/>
        public static unsafe void GetSourcefv(int source, SourceGetPNameFV param, float[] values)
        {
            fixed (float* values_ptr = values)
            {
                GetSourcefv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcefv(int, SourceGetPNameFV, float*)"/>
        public static unsafe void GetSourcefv(int source, SourceGetPNameFV param, ref float values)
        {
            fixed (float* values_ptr = &values)
            {
                GetSourcefv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcei(int, SourceGetPNameI, int*)"/>
        public static unsafe int GetSourcei(int source, SourceGetPNameI param)
        {
            int value;
            int* value_ptr = &value;
            {
                GetSourcei(source, param, value_ptr);
            }
            return value;
        }
        /// <inheritdoc cref="GetSourcei(int, SourceGetPNameI, int*)"/>
        public static unsafe void GetSourcei(int source, SourceGetPNameI param, out int value)
        {
            fixed (int* value_ptr = &value)
            {
                GetSourcei(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetSourceiv(int, SourceGetPNameIV, int*)"/>
        public static unsafe void GetSourceiv(int source, SourceGetPNameIV param, Span<int> values)
        {
            fixed (int* values_ptr = values)
            {
                GetSourceiv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetSourceiv(int, SourceGetPNameIV, int*)"/>
        public static unsafe void GetSourceiv(int source, SourceGetPNameIV param, int[] values)
        {
            fixed (int* values_ptr = values)
            {
                GetSourceiv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetSourceiv(int, SourceGetPNameIV, int*)"/>
        public static unsafe void GetSourceiv(int source, SourceGetPNameIV param, ref int values)
        {
            fixed (int* values_ptr = &values)
            {
                GetSourceiv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetString_(StringName)"/>
        public static unsafe string? GetString(StringName param)
        {
            string? returnValue_str;
            byte* returnValue;
            returnValue = GetString_(param);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <inheritdoc cref="IsExtensionPresent(byte*)"/>
        public static unsafe bool IsExtensionPresent(string extname)
        {
            bool returnValue;
            byte* extname_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(extname);
            returnValue = IsExtensionPresent(extname_ptr);
            Marshal.FreeCoTaskMem((IntPtr)extname_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="Listenerfv(ListenerPNameFV, float*)"/>
        public static unsafe void Listenerfv(ListenerPNameFV param, Span<float> values)
        {
            fixed (float* values_ptr = values)
            {
                Listenerfv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="Listenerfv(ListenerPNameFV, float*)"/>
        public static unsafe void Listenerfv(ListenerPNameFV param, float[] values)
        {
            fixed (float* values_ptr = values)
            {
                Listenerfv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="Listenerfv(ListenerPNameFV, float*)"/>
        public static unsafe void Listenerfv(ListenerPNameFV param, ref float values)
        {
            fixed (float* values_ptr = &values)
            {
                Listenerfv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="Listeneriv(ListenerPNameIV, int*)"/>
        public static unsafe void Listeneriv(ListenerPNameIV param, Span<int> values)
        {
            fixed (int* values_ptr = values)
            {
                Listeneriv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="Listeneriv(ListenerPNameIV, int*)"/>
        public static unsafe void Listeneriv(ListenerPNameIV param, int[] values)
        {
            fixed (int* values_ptr = values)
            {
                Listeneriv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="Listeneriv(ListenerPNameIV, int*)"/>
        public static unsafe void Listeneriv(ListenerPNameIV param, ref int values)
        {
            fixed (int* values_ptr = &values)
            {
                Listeneriv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="Sourcefv(int, SourcePNameFV, float*)"/>
        public static unsafe void Sourcefv(int source, SourcePNameFV param, ReadOnlySpan<float> value)
        {
            fixed (float* value_ptr = value)
            {
                Sourcefv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Sourcefv(int, SourcePNameFV, float*)"/>
        public static unsafe void Sourcefv(int source, SourcePNameFV param, float[] value)
        {
            fixed (float* value_ptr = value)
            {
                Sourcefv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Sourcefv(int, SourcePNameFV, float*)"/>
        public static unsafe void Sourcefv(int source, SourcePNameFV param, ref readonly float value)
        {
            fixed (float* value_ptr = &value)
            {
                Sourcefv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Sourceiv(int, SourcePNameIV, int*)"/>
        public static unsafe void Sourceiv(int source, SourcePNameIV param, ReadOnlySpan<int> value)
        {
            fixed (int* value_ptr = value)
            {
                Sourceiv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Sourceiv(int, SourcePNameIV, int*)"/>
        public static unsafe void Sourceiv(int source, SourcePNameIV param, int[] value)
        {
            fixed (int* value_ptr = value)
            {
                Sourceiv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Sourceiv(int, SourcePNameIV, int*)"/>
        public static unsafe void Sourceiv(int source, SourcePNameIV param, ref readonly int value)
        {
            fixed (int* value_ptr = &value)
            {
                Sourceiv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="SourcePausev(int, int*)"/>
        public static unsafe void SourcePause(int n, ReadOnlySpan<int> sources)
        {
            fixed (int* sources_ptr = sources)
            {
                SourcePausev(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourcePausev(int, int*)"/>
        public static unsafe void SourcePause(int n, int[] sources)
        {
            fixed (int* sources_ptr = sources)
            {
                SourcePausev(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourcePausev(int, int*)"/>
        public static unsafe void SourcePause(int n, ref readonly int sources)
        {
            fixed (int* sources_ptr = &sources)
            {
                SourcePausev(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourcePlayv(int, int*)"/>
        public static unsafe void SourcePlay(int n, ReadOnlySpan<int> sources)
        {
            fixed (int* sources_ptr = sources)
            {
                SourcePlayv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourcePlayv(int, int*)"/>
        public static unsafe void SourcePlay(int n, int[] sources)
        {
            fixed (int* sources_ptr = sources)
            {
                SourcePlayv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourcePlayv(int, int*)"/>
        public static unsafe void SourcePlay(int n, ref readonly int sources)
        {
            fixed (int* sources_ptr = &sources)
            {
                SourcePlayv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourceQueueBuffers(int, int, uint*)"/>
        public static unsafe void SourceQueueBuffers(int source, int nb, ReadOnlySpan<uint> buffers)
        {
            fixed (uint* buffers_ptr = buffers)
            {
                SourceQueueBuffers(source, nb, buffers_ptr);
            }
        }
        /// <inheritdoc cref="SourceQueueBuffers(int, int, uint*)"/>
        public static unsafe void SourceQueueBuffers(int source, int nb, uint[] buffers)
        {
            fixed (uint* buffers_ptr = buffers)
            {
                SourceQueueBuffers(source, nb, buffers_ptr);
            }
        }
        /// <inheritdoc cref="SourceQueueBuffers(int, int, uint*)"/>
        public static unsafe void SourceQueueBuffers(int source, int nb, ref readonly uint buffers)
        {
            fixed (uint* buffers_ptr = &buffers)
            {
                SourceQueueBuffers(source, nb, buffers_ptr);
            }
        }
        /// <inheritdoc cref="SourceRewindv(int, int*)"/>
        public static unsafe void SourceRewind(int n, ReadOnlySpan<int> sources)
        {
            fixed (int* sources_ptr = sources)
            {
                SourceRewindv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourceRewindv(int, int*)"/>
        public static unsafe void SourceRewind(int n, int[] sources)
        {
            fixed (int* sources_ptr = sources)
            {
                SourceRewindv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourceRewindv(int, int*)"/>
        public static unsafe void SourceRewind(int n, ref readonly int sources)
        {
            fixed (int* sources_ptr = &sources)
            {
                SourceRewindv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourceStopv(int, int*)"/>
        public static unsafe void SourceStop(int n, ReadOnlySpan<int> sources)
        {
            fixed (int* sources_ptr = sources)
            {
                SourceStopv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourceStopv(int, int*)"/>
        public static unsafe void SourceStop(int n, int[] sources)
        {
            fixed (int* sources_ptr = sources)
            {
                SourceStopv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourceStopv(int, int*)"/>
        public static unsafe void SourceStop(int n, ref readonly int sources)
        {
            fixed (int* sources_ptr = &sources)
            {
                SourceStopv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourceUnqueueBuffers(int, int, int*)"/>
        public static unsafe void SourceUnqueueBuffers(int source, int nb, Span<int> buffer)
        {
            fixed (int* buffer_ptr = buffer)
            {
                SourceUnqueueBuffers(source, nb, buffer_ptr);
            }
        }
        /// <inheritdoc cref="SourceUnqueueBuffers(int, int, int*)"/>
        public static unsafe void SourceUnqueueBuffers(int source, int nb, int[] buffer)
        {
            fixed (int* buffer_ptr = buffer)
            {
                SourceUnqueueBuffers(source, nb, buffer_ptr);
            }
        }
        /// <inheritdoc cref="SourceUnqueueBuffers(int, int, int*)"/>
        public static unsafe void SourceUnqueueBuffers(int source, int nb, ref int buffer)
        {
            fixed (int* buffer_ptr = &buffer)
            {
                SourceUnqueueBuffers(source, nb, buffer_ptr);
            }
        }
        public static unsafe partial class Creative
        {
            /// <inheritdoc cref="EAXGet(Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXGet(ref readonly Guid property_get_id, uint property_id, uint source_id, IntPtr value, uint value_size)
            {
                All returnValue;
                fixed (Guid* property_get_id_ptr = &property_get_id)
                {
                    void* value_vptr = (void*)value;
                    returnValue = EAXGet(property_get_id_ptr, property_id, source_id, value_vptr, value_size);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXGet(Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXGet<T1>(ref readonly Guid property_get_id, uint property_id, uint source_id, Span<T1> value, uint value_size)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (Guid* property_get_id_ptr = &property_get_id)
                {
                    fixed (void* value_ptr = value)
                    {
                        returnValue = EAXGet(property_get_id_ptr, property_id, source_id, value_ptr, value_size);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXGet(Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXGet<T1>(ref readonly Guid property_get_id, uint property_id, uint source_id, T1[] value, uint value_size)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (Guid* property_get_id_ptr = &property_get_id)
                {
                    fixed (void* value_ptr = value)
                    {
                        returnValue = EAXGet(property_get_id_ptr, property_id, source_id, value_ptr, value_size);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXGet(Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXGet<T1>(ref readonly Guid property_get_id, uint property_id, uint source_id, ref T1 value, uint value_size)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (Guid* property_get_id_ptr = &property_get_id)
                fixed (void* value_ptr = &value)
                {
                    returnValue = EAXGet(property_get_id_ptr, property_id, source_id, value_ptr, value_size);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXGetBufferMode(uint, int*)"/>
            public static unsafe EAXBufferMode EAXGetBufferMode(uint buffer, Span<int> pReserved)
            {
                EAXBufferMode returnValue;
                fixed (int* pReserved_ptr = pReserved)
                {
                    returnValue = EAXGetBufferMode(buffer, pReserved_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXGetBufferMode(uint, int*)"/>
            public static unsafe EAXBufferMode EAXGetBufferMode(uint buffer, int[] pReserved)
            {
                EAXBufferMode returnValue;
                fixed (int* pReserved_ptr = pReserved)
                {
                    returnValue = EAXGetBufferMode(buffer, pReserved_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXGetBufferMode(uint, int*)"/>
            public static unsafe EAXBufferMode EAXGetBufferMode(uint buffer, ref int pReserved)
            {
                EAXBufferMode returnValue;
                fixed (int* pReserved_ptr = &pReserved)
                {
                    returnValue = EAXGetBufferMode(buffer, pReserved_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXSet(Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXSet(ref readonly Guid property_set_id, uint property_id, uint source_id, IntPtr value, uint value_size)
            {
                All returnValue;
                fixed (Guid* property_set_id_ptr = &property_set_id)
                {
                    void* value_vptr = (void*)value;
                    returnValue = EAXSet(property_set_id_ptr, property_id, source_id, value_vptr, value_size);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXSet(Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXSet<T1>(ref readonly Guid property_set_id, uint property_id, uint source_id, Span<T1> value, uint value_size)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (Guid* property_set_id_ptr = &property_set_id)
                {
                    fixed (void* value_ptr = value)
                    {
                        returnValue = EAXSet(property_set_id_ptr, property_id, source_id, value_ptr, value_size);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXSet(Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXSet<T1>(ref readonly Guid property_set_id, uint property_id, uint source_id, T1[] value, uint value_size)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (Guid* property_set_id_ptr = &property_set_id)
                {
                    fixed (void* value_ptr = value)
                    {
                        returnValue = EAXSet(property_set_id_ptr, property_id, source_id, value_ptr, value_size);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXSet(Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXSet<T1>(ref readonly Guid property_set_id, uint property_id, uint source_id, ref T1 value, uint value_size)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (Guid* property_set_id_ptr = &property_set_id)
                fixed (void* value_ptr = &value)
                {
                    returnValue = EAXSet(property_set_id_ptr, property_id, source_id, value_ptr, value_size);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXSetBufferMode(int, uint*, int)"/>
            public static unsafe bool EAXSetBufferMode(int n, Span<uint> buffers, int value)
            {
                bool returnValue;
                fixed (uint* buffers_ptr = buffers)
                {
                    returnValue = EAXSetBufferMode(n, buffers_ptr, value);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXSetBufferMode(int, uint*, int)"/>
            public static unsafe bool EAXSetBufferMode(int n, uint[] buffers, int value)
            {
                bool returnValue;
                fixed (uint* buffers_ptr = buffers)
                {
                    returnValue = EAXSetBufferMode(n, buffers_ptr, value);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXSetBufferMode(int, uint*, int)"/>
            public static unsafe bool EAXSetBufferMode(int n, ref uint buffers, int value)
            {
                bool returnValue;
                fixed (uint* buffers_ptr = &buffers)
                {
                    returnValue = EAXSetBufferMode(n, buffers_ptr, value);
                }
                return returnValue;
            }
        }
        public static unsafe partial class EXT
        {
            /// <inheritdoc cref="AuxiliaryEffectSlotfv(int, AuxEffectSlotPNameFV, float*)"/>
            public static unsafe void AuxiliaryEffectSlotfv(int effectslot, AuxEffectSlotPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    AuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotfv(int, AuxEffectSlotPNameFV, float*)"/>
            public static unsafe void AuxiliaryEffectSlotfv(int effectslot, AuxEffectSlotPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    AuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotfv(int, AuxEffectSlotPNameFV, float*)"/>
            public static unsafe void AuxiliaryEffectSlotfv(int effectslot, AuxEffectSlotPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    AuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotfvDirect(ALCContext, int, AuxEffectSlotPNameFV, float*)"/>
            public static unsafe void AuxiliaryEffectSlotfvDirect(ALCContext context, int effectslot, AuxEffectSlotPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    AuxiliaryEffectSlotfvDirect(context, effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotfvDirect(ALCContext, int, AuxEffectSlotPNameFV, float*)"/>
            public static unsafe void AuxiliaryEffectSlotfvDirect(ALCContext context, int effectslot, AuxEffectSlotPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    AuxiliaryEffectSlotfvDirect(context, effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotfvDirect(ALCContext, int, AuxEffectSlotPNameFV, float*)"/>
            public static unsafe void AuxiliaryEffectSlotfvDirect(ALCContext context, int effectslot, AuxEffectSlotPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    AuxiliaryEffectSlotfvDirect(context, effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotiv(int, AuxEffectSlotPNameIV, int*)"/>
            public static unsafe void AuxiliaryEffectSlotiv(int effectslot, AuxEffectSlotPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    AuxiliaryEffectSlotiv(effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotiv(int, AuxEffectSlotPNameIV, int*)"/>
            public static unsafe void AuxiliaryEffectSlotiv(int effectslot, AuxEffectSlotPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    AuxiliaryEffectSlotiv(effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotiv(int, AuxEffectSlotPNameIV, int*)"/>
            public static unsafe void AuxiliaryEffectSlotiv(int effectslot, AuxEffectSlotPNameIV param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    AuxiliaryEffectSlotiv(effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotivDirect(ALCContext, int, AuxEffectSlotPNameIV, int*)"/>
            public static unsafe void AuxiliaryEffectSlotivDirect(ALCContext context, int effectslot, AuxEffectSlotPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    AuxiliaryEffectSlotivDirect(context, effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotivDirect(ALCContext, int, AuxEffectSlotPNameIV, int*)"/>
            public static unsafe void AuxiliaryEffectSlotivDirect(ALCContext context, int effectslot, AuxEffectSlotPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    AuxiliaryEffectSlotivDirect(context, effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotivDirect(ALCContext, int, AuxEffectSlotPNameIV, int*)"/>
            public static unsafe void AuxiliaryEffectSlotivDirect(ALCContext context, int effectslot, AuxEffectSlotPNameIV param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    AuxiliaryEffectSlotivDirect(context, effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="BufferCallbackDirectSOFT(ALCContext, int, Format, int, delegate* unmanaged[Cdecl]{void*, void*, nuint, nuint}, void*)"/>
            public static unsafe void BufferCallbackDirectSOFT(ALCContext context, int buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, IntPtr userptr)
            {
                void* userptr_vptr = (void*)userptr;
                BufferCallbackDirectSOFT(context, buffer, format, freq, callback, userptr_vptr);
            }
            /// <inheritdoc cref="BufferCallbackDirectSOFT(ALCContext, int, Format, int, delegate* unmanaged[Cdecl]{void*, void*, nuint, nuint}, void*)"/>
            public static unsafe void BufferCallbackDirectSOFT<T1>(ALCContext context, int buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, Span<T1> userptr)
                where T1 : unmanaged
            {
                fixed (void* userptr_ptr = userptr)
                {
                    BufferCallbackDirectSOFT(context, buffer, format, freq, callback, userptr_ptr);
                }
            }
            /// <inheritdoc cref="BufferCallbackDirectSOFT(ALCContext, int, Format, int, delegate* unmanaged[Cdecl]{void*, void*, nuint, nuint}, void*)"/>
            public static unsafe void BufferCallbackDirectSOFT<T1>(ALCContext context, int buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, T1[] userptr)
                where T1 : unmanaged
            {
                fixed (void* userptr_ptr = userptr)
                {
                    BufferCallbackDirectSOFT(context, buffer, format, freq, callback, userptr_ptr);
                }
            }
            /// <inheritdoc cref="BufferCallbackDirectSOFT(ALCContext, int, Format, int, delegate* unmanaged[Cdecl]{void*, void*, nuint, nuint}, void*)"/>
            public static unsafe void BufferCallbackDirectSOFT<T1>(ALCContext context, int buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, ref T1 userptr)
                where T1 : unmanaged
            {
                fixed (void* userptr_ptr = &userptr)
                {
                    BufferCallbackDirectSOFT(context, buffer, format, freq, callback, userptr_ptr);
                }
            }
            /// <inheritdoc cref="BufferDataDirect(ALCContext, int, Format, void*, int, int)"/>
            public static unsafe void BufferDataDirect(ALCContext context, int buffer, Format format, IntPtr data, int size, int samplerate)
            {
                void* data_vptr = (void*)data;
                BufferDataDirect(context, buffer, format, data_vptr, size, samplerate);
            }
            /// <inheritdoc cref="BufferDataDirect(ALCContext, int, Format, void*, int, int)"/>
            public static unsafe void BufferDataDirect<T1>(ALCContext context, int buffer, Format format, ReadOnlySpan<T1> data, int size, int samplerate)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferDataDirect(context, buffer, format, data_ptr, size, samplerate);
                }
            }
            /// <inheritdoc cref="BufferDataDirect(ALCContext, int, Format, void*, int, int)"/>
            public static unsafe void BufferDataDirect<T1>(ALCContext context, int buffer, Format format, T1[] data, int size, int samplerate)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferDataDirect(context, buffer, format, data_ptr, size, samplerate);
                }
            }
            /// <inheritdoc cref="BufferDataDirect(ALCContext, int, Format, void*, int, int)"/>
            public static unsafe void BufferDataDirect<T1>(ALCContext context, int buffer, Format format, ref readonly T1 data, int size, int samplerate)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    BufferDataDirect(context, buffer, format, data_ptr, size, samplerate);
                }
            }
            /// <inheritdoc cref="BufferfvDirect(ALCContext, int, BufferPNameFV, float*)"/>
            public static unsafe void BufferfvDirect(ALCContext context, int buffer, BufferPNameFV param, ReadOnlySpan<float> value)
            {
                fixed (float* value_ptr = value)
                {
                    BufferfvDirect(context, buffer, param, value_ptr);
                }
            }
            /// <inheritdoc cref="BufferfvDirect(ALCContext, int, BufferPNameFV, float*)"/>
            public static unsafe void BufferfvDirect(ALCContext context, int buffer, BufferPNameFV param, float[] value)
            {
                fixed (float* value_ptr = value)
                {
                    BufferfvDirect(context, buffer, param, value_ptr);
                }
            }
            /// <inheritdoc cref="BufferfvDirect(ALCContext, int, BufferPNameFV, float*)"/>
            public static unsafe void BufferfvDirect(ALCContext context, int buffer, BufferPNameFV param, ref readonly float value)
            {
                fixed (float* value_ptr = &value)
                {
                    BufferfvDirect(context, buffer, param, value_ptr);
                }
            }
            /// <inheritdoc cref="BufferivDirect(ALCContext, int, BufferPNameIV, int*)"/>
            public static unsafe void BufferivDirect(ALCContext context, int buffer, BufferPNameIV param, ReadOnlySpan<int> value)
            {
                fixed (int* value_ptr = value)
                {
                    BufferivDirect(context, buffer, param, value_ptr);
                }
            }
            /// <inheritdoc cref="BufferivDirect(ALCContext, int, BufferPNameIV, int*)"/>
            public static unsafe void BufferivDirect(ALCContext context, int buffer, BufferPNameIV param, int[] value)
            {
                fixed (int* value_ptr = value)
                {
                    BufferivDirect(context, buffer, param, value_ptr);
                }
            }
            /// <inheritdoc cref="BufferivDirect(ALCContext, int, BufferPNameIV, int*)"/>
            public static unsafe void BufferivDirect(ALCContext context, int buffer, BufferPNameIV param, ref readonly int value)
            {
                fixed (int* value_ptr = &value)
                {
                    BufferivDirect(context, buffer, param, value_ptr);
                }
            }
            /// <inheritdoc cref="BufferSamplesDirectSOFT(ALCContext, int, uint, InternalFormat, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSamplesDirectSOFT(ALCContext context, int buffer, uint samplerate, InternalFormat internalformat, int samples, Channels channels, SampleType type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                BufferSamplesDirectSOFT(context, buffer, samplerate, internalformat, samples, channels, type, data_vptr);
            }
            /// <inheritdoc cref="BufferSamplesDirectSOFT(ALCContext, int, uint, InternalFormat, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSamplesDirectSOFT<T1>(ALCContext context, int buffer, uint samplerate, InternalFormat internalformat, int samples, Channels channels, SampleType type, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSamplesDirectSOFT(context, buffer, samplerate, internalformat, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSamplesDirectSOFT(ALCContext, int, uint, InternalFormat, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSamplesDirectSOFT<T1>(ALCContext context, int buffer, uint samplerate, InternalFormat internalformat, int samples, Channels channels, SampleType type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSamplesDirectSOFT(context, buffer, samplerate, internalformat, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSamplesDirectSOFT(ALCContext, int, uint, InternalFormat, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSamplesDirectSOFT<T1>(ALCContext context, int buffer, uint samplerate, InternalFormat internalformat, int samples, Channels channels, SampleType type, ref readonly T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    BufferSamplesDirectSOFT(context, buffer, samplerate, internalformat, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSubDataDirectSOFT(ALCContext, int, Format, void*, int, int)"/>
            public static unsafe void BufferSubDataDirectSOFT(ALCContext context, int buffer, Format format, IntPtr data, int offset, int length)
            {
                void* data_vptr = (void*)data;
                BufferSubDataDirectSOFT(context, buffer, format, data_vptr, offset, length);
            }
            /// <inheritdoc cref="BufferSubDataDirectSOFT(ALCContext, int, Format, void*, int, int)"/>
            public static unsafe void BufferSubDataDirectSOFT<T1>(ALCContext context, int buffer, Format format, ReadOnlySpan<T1> data, int offset, int length)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubDataDirectSOFT(context, buffer, format, data_ptr, offset, length);
                }
            }
            /// <inheritdoc cref="BufferSubDataDirectSOFT(ALCContext, int, Format, void*, int, int)"/>
            public static unsafe void BufferSubDataDirectSOFT<T1>(ALCContext context, int buffer, Format format, T1[] data, int offset, int length)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubDataDirectSOFT(context, buffer, format, data_ptr, offset, length);
                }
            }
            /// <inheritdoc cref="BufferSubDataDirectSOFT(ALCContext, int, Format, void*, int, int)"/>
            public static unsafe void BufferSubDataDirectSOFT<T1>(ALCContext context, int buffer, Format format, ref readonly T1 data, int offset, int length)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    BufferSubDataDirectSOFT(context, buffer, format, data_ptr, offset, length);
                }
            }
            /// <inheritdoc cref="BufferSubSamplesDirectSOFT(ALCContext, int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSubSamplesDirectSOFT(ALCContext context, int buffer, int offset, int samples, Channels channels, SampleType type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                BufferSubSamplesDirectSOFT(context, buffer, offset, samples, channels, type, data_vptr);
            }
            /// <inheritdoc cref="BufferSubSamplesDirectSOFT(ALCContext, int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSubSamplesDirectSOFT<T1>(ALCContext context, int buffer, int offset, int samples, Channels channels, SampleType type, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubSamplesDirectSOFT(context, buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSubSamplesDirectSOFT(ALCContext, int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSubSamplesDirectSOFT<T1>(ALCContext context, int buffer, int offset, int samples, Channels channels, SampleType type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubSamplesDirectSOFT(context, buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSubSamplesDirectSOFT(ALCContext, int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSubSamplesDirectSOFT<T1>(ALCContext context, int buffer, int offset, int samples, Channels channels, SampleType type, ref readonly T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    BufferSubSamplesDirectSOFT(context, buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="DebugMessageCallbackDirectEXT(ALCContext, delegate* unmanaged[Cdecl]{All, All, uint, All, nuint, byte*, void*, int}, void*)"/>
            public static unsafe void DebugMessageCallbackDirectEXT(ALCContext context, delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, IntPtr userParam)
            {
                void* userParam_vptr = (void*)userParam;
                DebugMessageCallbackDirectEXT(context, callback, userParam_vptr);
            }
            /// <inheritdoc cref="DebugMessageCallbackDirectEXT(ALCContext, delegate* unmanaged[Cdecl]{All, All, uint, All, nuint, byte*, void*, int}, void*)"/>
            public static unsafe void DebugMessageCallbackDirectEXT<T1>(ALCContext context, delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, Span<T1> userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = userParam)
                {
                    DebugMessageCallbackDirectEXT(context, callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="DebugMessageCallbackDirectEXT(ALCContext, delegate* unmanaged[Cdecl]{All, All, uint, All, nuint, byte*, void*, int}, void*)"/>
            public static unsafe void DebugMessageCallbackDirectEXT<T1>(ALCContext context, delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, T1[] userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = userParam)
                {
                    DebugMessageCallbackDirectEXT(context, callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="DebugMessageCallbackDirectEXT(ALCContext, delegate* unmanaged[Cdecl]{All, All, uint, All, nuint, byte*, void*, int}, void*)"/>
            public static unsafe void DebugMessageCallbackDirectEXT<T1>(ALCContext context, delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, ref T1 userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = &userParam)
                {
                    DebugMessageCallbackDirectEXT(context, callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="DebugMessageCallbackEXT(delegate* unmanaged[Cdecl]{All, All, uint, All, nuint, byte*, void*, int}, void*)"/>
            public static unsafe void DebugMessageCallbackEXT(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, IntPtr userParam)
            {
                void* userParam_vptr = (void*)userParam;
                DebugMessageCallbackEXT(callback, userParam_vptr);
            }
            /// <inheritdoc cref="DebugMessageCallbackEXT(delegate* unmanaged[Cdecl]{All, All, uint, All, nuint, byte*, void*, int}, void*)"/>
            public static unsafe void DebugMessageCallbackEXT<T1>(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, Span<T1> userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = userParam)
                {
                    DebugMessageCallbackEXT(callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="DebugMessageCallbackEXT(delegate* unmanaged[Cdecl]{All, All, uint, All, nuint, byte*, void*, int}, void*)"/>
            public static unsafe void DebugMessageCallbackEXT<T1>(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, T1[] userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = userParam)
                {
                    DebugMessageCallbackEXT(callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="DebugMessageCallbackEXT(delegate* unmanaged[Cdecl]{All, All, uint, All, nuint, byte*, void*, int}, void*)"/>
            public static unsafe void DebugMessageCallbackEXT<T1>(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, ref T1 userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = &userParam)
                {
                    DebugMessageCallbackEXT(callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="DebugMessageControlDirectEXT(ALCContext, DebugSource, DebugType, uint, int, uint*, bool)"/>
            public static unsafe void DebugMessageControlDirectEXT(ALCContext context, DebugSource source, DebugType type, uint severity, int count, ReadOnlySpan<uint> ids, bool enable)
            {
                fixed (uint* ids_ptr = ids)
                {
                    DebugMessageControlDirectEXT(context, source, type, severity, count, ids_ptr, enable);
                }
            }
            /// <inheritdoc cref="DebugMessageControlDirectEXT(ALCContext, DebugSource, DebugType, uint, int, uint*, bool)"/>
            public static unsafe void DebugMessageControlDirectEXT(ALCContext context, DebugSource source, DebugType type, uint severity, int count, uint[] ids, bool enable)
            {
                fixed (uint* ids_ptr = ids)
                {
                    DebugMessageControlDirectEXT(context, source, type, severity, count, ids_ptr, enable);
                }
            }
            /// <inheritdoc cref="DebugMessageControlDirectEXT(ALCContext, DebugSource, DebugType, uint, int, uint*, bool)"/>
            public static unsafe void DebugMessageControlDirectEXT(ALCContext context, DebugSource source, DebugType type, uint severity, int count, ref readonly uint ids, bool enable)
            {
                fixed (uint* ids_ptr = &ids)
                {
                    DebugMessageControlDirectEXT(context, source, type, severity, count, ids_ptr, enable);
                }
            }
            /// <inheritdoc cref="DebugMessageControlEXT(DebugSource, DebugType, uint, int, uint*, bool)"/>
            public static unsafe void DebugMessageControlEXT(DebugSource source, DebugType type, uint severity, int count, ReadOnlySpan<uint> ids, bool enable)
            {
                fixed (uint* ids_ptr = ids)
                {
                    DebugMessageControlEXT(source, type, severity, count, ids_ptr, enable);
                }
            }
            /// <inheritdoc cref="DebugMessageControlEXT(DebugSource, DebugType, uint, int, uint*, bool)"/>
            public static unsafe void DebugMessageControlEXT(DebugSource source, DebugType type, uint severity, int count, uint[] ids, bool enable)
            {
                fixed (uint* ids_ptr = ids)
                {
                    DebugMessageControlEXT(source, type, severity, count, ids_ptr, enable);
                }
            }
            /// <inheritdoc cref="DebugMessageControlEXT(DebugSource, DebugType, uint, int, uint*, bool)"/>
            public static unsafe void DebugMessageControlEXT(DebugSource source, DebugType type, uint severity, int count, ref readonly uint ids, bool enable)
            {
                fixed (uint* ids_ptr = &ids)
                {
                    DebugMessageControlEXT(source, type, severity, count, ids_ptr, enable);
                }
            }
            /// <inheritdoc cref="DebugMessageInsertDirectEXT(ALCContext, DebugSource, DebugType, uint, int, byte*)"/>
            public static unsafe void DebugMessageInsertDirectEXT(ALCContext context, DebugSource source, DebugType type, uint severity, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                DebugMessageInsertDirectEXT(context, source, type, severity, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
            }
            /// <inheritdoc cref="DebugMessageInsertEXT(DebugSource, DebugType, uint, int, byte*)"/>
            public static unsafe void DebugMessageInsertEXT(DebugSource source, DebugType type, uint severity, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                DebugMessageInsertEXT(source, type, severity, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
            }
            /// <inheritdoc cref="DeleteAuxiliaryEffectSlots(int, int*)"/>
            public static unsafe void DeleteAuxiliaryEffectSlot(int effectslot)
            {
                int n = 1;
                int* effectslots_handle = &effectslot;
                DeleteAuxiliaryEffectSlots(n, effectslots_handle);
            }
            /// <inheritdoc cref="DeleteAuxiliaryEffectSlots(int, int*)"/>
            public static unsafe void DeleteAuxiliaryEffectSlots(int n, Span<int> effectslots)
            {
                fixed (int* effectslots_ptr = effectslots)
                {
                    DeleteAuxiliaryEffectSlots(n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="DeleteAuxiliaryEffectSlots(int, int*)"/>
            public static unsafe void DeleteAuxiliaryEffectSlots(int n, int[] effectslots)
            {
                fixed (int* effectslots_ptr = effectslots)
                {
                    DeleteAuxiliaryEffectSlots(n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="DeleteAuxiliaryEffectSlots(int, int*)"/>
            public static unsafe void DeleteAuxiliaryEffectSlots(int n, ref int effectslots)
            {
                fixed (int* effectslots_ptr = &effectslots)
                {
                    DeleteAuxiliaryEffectSlots(n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="DeleteAuxiliaryEffectSlotsDirect(ALCContext, int, int*)"/>
            public static unsafe void DeleteAuxiliaryEffectSlotsDirect(ALCContext context, int n, Span<int> effectslots)
            {
                fixed (int* effectslots_ptr = effectslots)
                {
                    DeleteAuxiliaryEffectSlotsDirect(context, n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="DeleteAuxiliaryEffectSlotsDirect(ALCContext, int, int*)"/>
            public static unsafe void DeleteAuxiliaryEffectSlotsDirect(ALCContext context, int n, int[] effectslots)
            {
                fixed (int* effectslots_ptr = effectslots)
                {
                    DeleteAuxiliaryEffectSlotsDirect(context, n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="DeleteAuxiliaryEffectSlotsDirect(ALCContext, int, int*)"/>
            public static unsafe void DeleteAuxiliaryEffectSlotsDirect(ALCContext context, int n, ref int effectslots)
            {
                fixed (int* effectslots_ptr = &effectslots)
                {
                    DeleteAuxiliaryEffectSlotsDirect(context, n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="DeleteBuffersDirect(ALCContext, int, int*)"/>
            public static unsafe void DeleteBuffersDirect(ALCContext context, int n, ReadOnlySpan<int> buffers)
            {
                fixed (int* buffers_ptr = buffers)
                {
                    DeleteBuffersDirect(context, n, buffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteBuffersDirect(ALCContext, int, int*)"/>
            public static unsafe void DeleteBuffersDirect(ALCContext context, int n, int[] buffers)
            {
                fixed (int* buffers_ptr = buffers)
                {
                    DeleteBuffersDirect(context, n, buffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteBuffersDirect(ALCContext, int, int*)"/>
            public static unsafe void DeleteBuffersDirect(ALCContext context, int n, ref readonly int buffers)
            {
                fixed (int* buffers_ptr = &buffers)
                {
                    DeleteBuffersDirect(context, n, buffers_ptr);
                }
            }
            /// <inheritdoc cref="DeleteEffects(int, int*)"/>
            public static unsafe void DeleteEffect(int effect)
            {
                int n = 1;
                int* effects_handle = &effect;
                DeleteEffects(n, effects_handle);
            }
            /// <inheritdoc cref="DeleteEffects(int, int*)"/>
            public static unsafe void DeleteEffects(int n, Span<int> effects)
            {
                fixed (int* effects_ptr = effects)
                {
                    DeleteEffects(n, effects_ptr);
                }
            }
            /// <inheritdoc cref="DeleteEffects(int, int*)"/>
            public static unsafe void DeleteEffects(int n, int[] effects)
            {
                fixed (int* effects_ptr = effects)
                {
                    DeleteEffects(n, effects_ptr);
                }
            }
            /// <inheritdoc cref="DeleteEffects(int, int*)"/>
            public static unsafe void DeleteEffects(int n, ref int effects)
            {
                fixed (int* effects_ptr = &effects)
                {
                    DeleteEffects(n, effects_ptr);
                }
            }
            /// <inheritdoc cref="DeleteEffectsDirect(ALCContext, int, int*)"/>
            public static unsafe void DeleteEffectsDirect(ALCContext context, int n, Span<int> effects)
            {
                fixed (int* effects_ptr = effects)
                {
                    DeleteEffectsDirect(context, n, effects_ptr);
                }
            }
            /// <inheritdoc cref="DeleteEffectsDirect(ALCContext, int, int*)"/>
            public static unsafe void DeleteEffectsDirect(ALCContext context, int n, int[] effects)
            {
                fixed (int* effects_ptr = effects)
                {
                    DeleteEffectsDirect(context, n, effects_ptr);
                }
            }
            /// <inheritdoc cref="DeleteEffectsDirect(ALCContext, int, int*)"/>
            public static unsafe void DeleteEffectsDirect(ALCContext context, int n, ref int effects)
            {
                fixed (int* effects_ptr = &effects)
                {
                    DeleteEffectsDirect(context, n, effects_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFilters(int, int*)"/>
            public static unsafe void DeleteFilter(int filter)
            {
                int n = 1;
                int* filters_handle = &filter;
                DeleteFilters(n, filters_handle);
            }
            /// <inheritdoc cref="DeleteFilters(int, int*)"/>
            public static unsafe void DeleteFilters(int n, Span<int> filters)
            {
                fixed (int* filters_ptr = filters)
                {
                    DeleteFilters(n, filters_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFilters(int, int*)"/>
            public static unsafe void DeleteFilters(int n, int[] filters)
            {
                fixed (int* filters_ptr = filters)
                {
                    DeleteFilters(n, filters_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFilters(int, int*)"/>
            public static unsafe void DeleteFilters(int n, ref int filters)
            {
                fixed (int* filters_ptr = &filters)
                {
                    DeleteFilters(n, filters_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFiltersDirect(ALCContext, int, int*)"/>
            public static unsafe void DeleteFiltersDirect(ALCContext context, int n, Span<int> filters)
            {
                fixed (int* filters_ptr = filters)
                {
                    DeleteFiltersDirect(context, n, filters_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFiltersDirect(ALCContext, int, int*)"/>
            public static unsafe void DeleteFiltersDirect(ALCContext context, int n, int[] filters)
            {
                fixed (int* filters_ptr = filters)
                {
                    DeleteFiltersDirect(context, n, filters_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFiltersDirect(ALCContext, int, int*)"/>
            public static unsafe void DeleteFiltersDirect(ALCContext context, int n, ref int filters)
            {
                fixed (int* filters_ptr = &filters)
                {
                    DeleteFiltersDirect(context, n, filters_ptr);
                }
            }
            /// <inheritdoc cref="DeleteSourcesDirect(ALCContext, int, int*)"/>
            public static unsafe void DeleteSourcesDirect(ALCContext context, int n, ReadOnlySpan<int> sources)
            {
                fixed (int* sources_ptr = sources)
                {
                    DeleteSourcesDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="DeleteSourcesDirect(ALCContext, int, int*)"/>
            public static unsafe void DeleteSourcesDirect(ALCContext context, int n, int[] sources)
            {
                fixed (int* sources_ptr = sources)
                {
                    DeleteSourcesDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="DeleteSourcesDirect(ALCContext, int, int*)"/>
            public static unsafe void DeleteSourcesDirect(ALCContext context, int n, ref readonly int sources)
            {
                fixed (int* sources_ptr = &sources)
                {
                    DeleteSourcesDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="EAXGetBufferModeDirect(ALCContext, uint, int*)"/>
            public static unsafe EAXBufferMode EAXGetBufferModeDirect(ALCContext context, uint buffer, Span<int> pReserved)
            {
                EAXBufferMode returnValue;
                fixed (int* pReserved_ptr = pReserved)
                {
                    returnValue = EAXGetBufferModeDirect(context, buffer, pReserved_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXGetBufferModeDirect(ALCContext, uint, int*)"/>
            public static unsafe EAXBufferMode EAXGetBufferModeDirect(ALCContext context, uint buffer, int[] pReserved)
            {
                EAXBufferMode returnValue;
                fixed (int* pReserved_ptr = pReserved)
                {
                    returnValue = EAXGetBufferModeDirect(context, buffer, pReserved_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXGetBufferModeDirect(ALCContext, uint, int*)"/>
            public static unsafe EAXBufferMode EAXGetBufferModeDirect(ALCContext context, uint buffer, ref int pReserved)
            {
                EAXBufferMode returnValue;
                fixed (int* pReserved_ptr = &pReserved)
                {
                    returnValue = EAXGetBufferModeDirect(context, buffer, pReserved_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXGetDirect(ALCContext, Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXGetDirect(ALCContext context, ref readonly Guid property_get_id, uint property_id, uint source_id, IntPtr value, uint value_size)
            {
                All returnValue;
                fixed (Guid* property_get_id_ptr = &property_get_id)
                {
                    void* value_vptr = (void*)value;
                    returnValue = EAXGetDirect(context, property_get_id_ptr, property_id, source_id, value_vptr, value_size);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXGetDirect(ALCContext, Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXGetDirect<T1>(ALCContext context, ref readonly Guid property_get_id, uint property_id, uint source_id, Span<T1> value, uint value_size)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (Guid* property_get_id_ptr = &property_get_id)
                {
                    fixed (void* value_ptr = value)
                    {
                        returnValue = EAXGetDirect(context, property_get_id_ptr, property_id, source_id, value_ptr, value_size);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXGetDirect(ALCContext, Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXGetDirect<T1>(ALCContext context, ref readonly Guid property_get_id, uint property_id, uint source_id, T1[] value, uint value_size)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (Guid* property_get_id_ptr = &property_get_id)
                {
                    fixed (void* value_ptr = value)
                    {
                        returnValue = EAXGetDirect(context, property_get_id_ptr, property_id, source_id, value_ptr, value_size);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXGetDirect(ALCContext, Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXGetDirect<T1>(ALCContext context, ref readonly Guid property_get_id, uint property_id, uint source_id, ref T1 value, uint value_size)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (Guid* property_get_id_ptr = &property_get_id)
                fixed (void* value_ptr = &value)
                {
                    returnValue = EAXGetDirect(context, property_get_id_ptr, property_id, source_id, value_ptr, value_size);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXSetBufferModeDirect(ALCContext, int, uint*, int)"/>
            public static unsafe bool EAXSetBufferModeDirect(ALCContext context, int n, Span<uint> buffers, int value)
            {
                bool returnValue;
                fixed (uint* buffers_ptr = buffers)
                {
                    returnValue = EAXSetBufferModeDirect(context, n, buffers_ptr, value);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXSetBufferModeDirect(ALCContext, int, uint*, int)"/>
            public static unsafe bool EAXSetBufferModeDirect(ALCContext context, int n, uint[] buffers, int value)
            {
                bool returnValue;
                fixed (uint* buffers_ptr = buffers)
                {
                    returnValue = EAXSetBufferModeDirect(context, n, buffers_ptr, value);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXSetBufferModeDirect(ALCContext, int, uint*, int)"/>
            public static unsafe bool EAXSetBufferModeDirect(ALCContext context, int n, ref uint buffers, int value)
            {
                bool returnValue;
                fixed (uint* buffers_ptr = &buffers)
                {
                    returnValue = EAXSetBufferModeDirect(context, n, buffers_ptr, value);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXSetDirect(ALCContext, Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXSetDirect(ALCContext context, ref readonly Guid property_set_id, uint property_id, uint source_id, IntPtr value, uint value_size)
            {
                All returnValue;
                fixed (Guid* property_set_id_ptr = &property_set_id)
                {
                    void* value_vptr = (void*)value;
                    returnValue = EAXSetDirect(context, property_set_id_ptr, property_id, source_id, value_vptr, value_size);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXSetDirect(ALCContext, Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXSetDirect<T1>(ALCContext context, ref readonly Guid property_set_id, uint property_id, uint source_id, Span<T1> value, uint value_size)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (Guid* property_set_id_ptr = &property_set_id)
                {
                    fixed (void* value_ptr = value)
                    {
                        returnValue = EAXSetDirect(context, property_set_id_ptr, property_id, source_id, value_ptr, value_size);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXSetDirect(ALCContext, Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXSetDirect<T1>(ALCContext context, ref readonly Guid property_set_id, uint property_id, uint source_id, T1[] value, uint value_size)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (Guid* property_set_id_ptr = &property_set_id)
                {
                    fixed (void* value_ptr = value)
                    {
                        returnValue = EAXSetDirect(context, property_set_id_ptr, property_id, source_id, value_ptr, value_size);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EAXSetDirect(ALCContext, Guid*, uint, uint, void*, uint)"/>
            public static unsafe All EAXSetDirect<T1>(ALCContext context, ref readonly Guid property_set_id, uint property_id, uint source_id, ref T1 value, uint value_size)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (Guid* property_set_id_ptr = &property_set_id)
                fixed (void* value_ptr = &value)
                {
                    returnValue = EAXSetDirect(context, property_set_id_ptr, property_id, source_id, value_ptr, value_size);
                }
                return returnValue;
            }
            /// <inheritdoc cref="Effectfv(int, EffectPNameFV, float*)"/>
            public static unsafe void Effectfv(int effect, EffectPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    Effectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Effectfv(int, EffectPNameFV, float*)"/>
            public static unsafe void Effectfv(int effect, EffectPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    Effectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Effectfv(int, EffectPNameFV, float*)"/>
            public static unsafe void Effectfv(int effect, EffectPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    Effectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="EffectfvDirect(ALCContext, int, EffectPNameFV, float*)"/>
            public static unsafe void EffectfvDirect(ALCContext context, int effect, EffectPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    EffectfvDirect(context, effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="EffectfvDirect(ALCContext, int, EffectPNameFV, float*)"/>
            public static unsafe void EffectfvDirect(ALCContext context, int effect, EffectPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    EffectfvDirect(context, effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="EffectfvDirect(ALCContext, int, EffectPNameFV, float*)"/>
            public static unsafe void EffectfvDirect(ALCContext context, int effect, EffectPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    EffectfvDirect(context, effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Effectiv(int, EffectPNameIV, int*)"/>
            public static unsafe void Effectiv(int effect, EffectPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    Effectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="Effectiv(int, EffectPNameIV, int*)"/>
            public static unsafe void Effectiv(int effect, EffectPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    Effectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="Effectiv(int, EffectPNameIV, int*)"/>
            public static unsafe void Effectiv(int effect, EffectPNameIV param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    Effectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="EffectivDirect(ALCContext, int, EffectPNameIV, int*)"/>
            public static unsafe void EffectivDirect(ALCContext context, int effect, EffectPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    EffectivDirect(context, effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="EffectivDirect(ALCContext, int, EffectPNameIV, int*)"/>
            public static unsafe void EffectivDirect(ALCContext context, int effect, EffectPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    EffectivDirect(context, effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="EffectivDirect(ALCContext, int, EffectPNameIV, int*)"/>
            public static unsafe void EffectivDirect(ALCContext context, int effect, EffectPNameIV param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    EffectivDirect(context, effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="EventCallbackDirectSOFT(ALCContext, delegate* unmanaged[Cdecl]{All, uint, uint, nuint, byte*, void*, void}, void*)"/>
            public static unsafe void EventCallbackDirectSOFT(ALCContext context, delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, IntPtr userParam)
            {
                void* userParam_vptr = (void*)userParam;
                EventCallbackDirectSOFT(context, callback, userParam_vptr);
            }
            /// <inheritdoc cref="EventCallbackDirectSOFT(ALCContext, delegate* unmanaged[Cdecl]{All, uint, uint, nuint, byte*, void*, void}, void*)"/>
            public static unsafe void EventCallbackDirectSOFT<T1>(ALCContext context, delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, Span<T1> userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = userParam)
                {
                    EventCallbackDirectSOFT(context, callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="EventCallbackDirectSOFT(ALCContext, delegate* unmanaged[Cdecl]{All, uint, uint, nuint, byte*, void*, void}, void*)"/>
            public static unsafe void EventCallbackDirectSOFT<T1>(ALCContext context, delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, T1[] userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = userParam)
                {
                    EventCallbackDirectSOFT(context, callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="EventCallbackDirectSOFT(ALCContext, delegate* unmanaged[Cdecl]{All, uint, uint, nuint, byte*, void*, void}, void*)"/>
            public static unsafe void EventCallbackDirectSOFT<T1>(ALCContext context, delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, ref T1 userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = &userParam)
                {
                    EventCallbackDirectSOFT(context, callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="EventControlDirectSOFT(ALCContext, int, EventType*, bool)"/>
            public static unsafe void EventControlDirectSOFT(ALCContext context, int count, ReadOnlySpan<EventType> types, bool enable)
            {
                fixed (EventType* types_ptr = types)
                {
                    EventControlDirectSOFT(context, count, types_ptr, enable);
                }
            }
            /// <inheritdoc cref="EventControlDirectSOFT(ALCContext, int, EventType*, bool)"/>
            public static unsafe void EventControlDirectSOFT(ALCContext context, int count, EventType[] types, bool enable)
            {
                fixed (EventType* types_ptr = types)
                {
                    EventControlDirectSOFT(context, count, types_ptr, enable);
                }
            }
            /// <inheritdoc cref="EventControlDirectSOFT(ALCContext, int, EventType*, bool)"/>
            public static unsafe void EventControlDirectSOFT(ALCContext context, int count, ref readonly EventType types, bool enable)
            {
                fixed (EventType* types_ptr = &types)
                {
                    EventControlDirectSOFT(context, count, types_ptr, enable);
                }
            }
            /// <inheritdoc cref="Filterfv(int, FilterPNameFV, float*)"/>
            public static unsafe void Filterfv(int filter, FilterPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    Filterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Filterfv(int, FilterPNameFV, float*)"/>
            public static unsafe void Filterfv(int filter, FilterPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    Filterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Filterfv(int, FilterPNameFV, float*)"/>
            public static unsafe void Filterfv(int filter, FilterPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    Filterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="FilterfvDirect(ALCContext, int, FilterPNameFV, float*)"/>
            public static unsafe void FilterfvDirect(ALCContext context, int filter, FilterPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    FilterfvDirect(context, filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="FilterfvDirect(ALCContext, int, FilterPNameFV, float*)"/>
            public static unsafe void FilterfvDirect(ALCContext context, int filter, FilterPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    FilterfvDirect(context, filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="FilterfvDirect(ALCContext, int, FilterPNameFV, float*)"/>
            public static unsafe void FilterfvDirect(ALCContext context, int filter, FilterPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    FilterfvDirect(context, filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Filteriv(int, FilterPNameIV, int*)"/>
            public static unsafe void Filteriv(int filter, FilterPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    Filteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="Filteriv(int, FilterPNameIV, int*)"/>
            public static unsafe void Filteriv(int filter, FilterPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    Filteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="Filteriv(int, FilterPNameIV, int*)"/>
            public static unsafe void Filteriv(int filter, FilterPNameIV param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    Filteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="FilterivDirect(ALCContext, int, FilterPNameIV, int*)"/>
            public static unsafe void FilterivDirect(ALCContext context, int filter, FilterPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    FilterivDirect(context, filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="FilterivDirect(ALCContext, int, FilterPNameIV, int*)"/>
            public static unsafe void FilterivDirect(ALCContext context, int filter, FilterPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    FilterivDirect(context, filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="FilterivDirect(ALCContext, int, FilterPNameIV, int*)"/>
            public static unsafe void FilterivDirect(ALCContext context, int filter, FilterPNameIV param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    FilterivDirect(context, filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GenAuxiliaryEffectSlots(int, int*)"/>
            public static unsafe int GenAuxiliaryEffectSlot()
            {
                int effectslot;
                int n = 1;
                Unsafe.SkipInit(out effectslot);
                int* effectslots_handle = &effectslot;
                GenAuxiliaryEffectSlots(n, effectslots_handle);
                return effectslot;
            }
            /// <inheritdoc cref="GenAuxiliaryEffectSlots(int, int*)"/>
            public static unsafe void GenAuxiliaryEffectSlot(out int effectslot)
            {
                int n = 1;
                Unsafe.SkipInit(out effectslot);
                fixed(int* effectslots_handle = &effectslot)
                {
                    GenAuxiliaryEffectSlots(n, effectslots_handle);
                }
            }
            /// <inheritdoc cref="GenAuxiliaryEffectSlots(int, int*)"/>
            public static unsafe void GenAuxiliaryEffectSlots(int n, Span<int> effectslots)
            {
                fixed (int* effectslots_ptr = effectslots)
                {
                    GenAuxiliaryEffectSlots(n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="GenAuxiliaryEffectSlots(int, int*)"/>
            public static unsafe void GenAuxiliaryEffectSlots(int n, int[] effectslots)
            {
                fixed (int* effectslots_ptr = effectslots)
                {
                    GenAuxiliaryEffectSlots(n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="GenAuxiliaryEffectSlots(int, int*)"/>
            public static unsafe void GenAuxiliaryEffectSlots(int n, ref int effectslots)
            {
                fixed (int* effectslots_ptr = &effectslots)
                {
                    GenAuxiliaryEffectSlots(n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="GenAuxiliaryEffectSlotsDirect(ALCContext, int, int*)"/>
            public static unsafe void GenAuxiliaryEffectSlotsDirect(ALCContext context, int n, Span<int> effectslots)
            {
                fixed (int* effectslots_ptr = effectslots)
                {
                    GenAuxiliaryEffectSlotsDirect(context, n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="GenAuxiliaryEffectSlotsDirect(ALCContext, int, int*)"/>
            public static unsafe void GenAuxiliaryEffectSlotsDirect(ALCContext context, int n, int[] effectslots)
            {
                fixed (int* effectslots_ptr = effectslots)
                {
                    GenAuxiliaryEffectSlotsDirect(context, n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="GenAuxiliaryEffectSlotsDirect(ALCContext, int, int*)"/>
            public static unsafe void GenAuxiliaryEffectSlotsDirect(ALCContext context, int n, ref int effectslots)
            {
                fixed (int* effectslots_ptr = &effectslots)
                {
                    GenAuxiliaryEffectSlotsDirect(context, n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="GenBuffersDirect(ALCContext, int, int*)"/>
            public static unsafe void GenBuffersDirect(ALCContext context, int n, Span<int> buffers)
            {
                fixed (int* buffers_ptr = buffers)
                {
                    GenBuffersDirect(context, n, buffers_ptr);
                }
            }
            /// <inheritdoc cref="GenBuffersDirect(ALCContext, int, int*)"/>
            public static unsafe void GenBuffersDirect(ALCContext context, int n, int[] buffers)
            {
                fixed (int* buffers_ptr = buffers)
                {
                    GenBuffersDirect(context, n, buffers_ptr);
                }
            }
            /// <inheritdoc cref="GenBuffersDirect(ALCContext, int, int*)"/>
            public static unsafe void GenBuffersDirect(ALCContext context, int n, ref int buffers)
            {
                fixed (int* buffers_ptr = &buffers)
                {
                    GenBuffersDirect(context, n, buffers_ptr);
                }
            }
            /// <inheritdoc cref="GenEffects(int, int*)"/>
            public static unsafe int GenEffect()
            {
                int effect;
                int n = 1;
                Unsafe.SkipInit(out effect);
                int* effects_handle = &effect;
                GenEffects(n, effects_handle);
                return effect;
            }
            /// <inheritdoc cref="GenEffects(int, int*)"/>
            public static unsafe void GenEffect(out int effect)
            {
                int n = 1;
                Unsafe.SkipInit(out effect);
                fixed(int* effects_handle = &effect)
                {
                    GenEffects(n, effects_handle);
                }
            }
            /// <inheritdoc cref="GenEffects(int, int*)"/>
            public static unsafe void GenEffects(int n, Span<int> effects)
            {
                fixed (int* effects_ptr = effects)
                {
                    GenEffects(n, effects_ptr);
                }
            }
            /// <inheritdoc cref="GenEffects(int, int*)"/>
            public static unsafe void GenEffects(int n, int[] effects)
            {
                fixed (int* effects_ptr = effects)
                {
                    GenEffects(n, effects_ptr);
                }
            }
            /// <inheritdoc cref="GenEffects(int, int*)"/>
            public static unsafe void GenEffects(int n, ref int effects)
            {
                fixed (int* effects_ptr = &effects)
                {
                    GenEffects(n, effects_ptr);
                }
            }
            /// <inheritdoc cref="GenEffectsDirect(ALCContext, int, int*)"/>
            public static unsafe void GenEffectsDirect(ALCContext context, int n, Span<int> effects)
            {
                fixed (int* effects_ptr = effects)
                {
                    GenEffectsDirect(context, n, effects_ptr);
                }
            }
            /// <inheritdoc cref="GenEffectsDirect(ALCContext, int, int*)"/>
            public static unsafe void GenEffectsDirect(ALCContext context, int n, int[] effects)
            {
                fixed (int* effects_ptr = effects)
                {
                    GenEffectsDirect(context, n, effects_ptr);
                }
            }
            /// <inheritdoc cref="GenEffectsDirect(ALCContext, int, int*)"/>
            public static unsafe void GenEffectsDirect(ALCContext context, int n, ref int effects)
            {
                fixed (int* effects_ptr = &effects)
                {
                    GenEffectsDirect(context, n, effects_ptr);
                }
            }
            /// <inheritdoc cref="GenFilters(int, int*)"/>
            public static unsafe int GenFilter()
            {
                int filter;
                int n = 1;
                Unsafe.SkipInit(out filter);
                int* filters_handle = &filter;
                GenFilters(n, filters_handle);
                return filter;
            }
            /// <inheritdoc cref="GenFilters(int, int*)"/>
            public static unsafe void GenFilter(out int filter)
            {
                int n = 1;
                Unsafe.SkipInit(out filter);
                fixed(int* filters_handle = &filter)
                {
                    GenFilters(n, filters_handle);
                }
            }
            /// <inheritdoc cref="GenFilters(int, int*)"/>
            public static unsafe void GenFilters(int n, Span<int> filters)
            {
                fixed (int* filters_ptr = filters)
                {
                    GenFilters(n, filters_ptr);
                }
            }
            /// <inheritdoc cref="GenFilters(int, int*)"/>
            public static unsafe void GenFilters(int n, int[] filters)
            {
                fixed (int* filters_ptr = filters)
                {
                    GenFilters(n, filters_ptr);
                }
            }
            /// <inheritdoc cref="GenFilters(int, int*)"/>
            public static unsafe void GenFilters(int n, ref int filters)
            {
                fixed (int* filters_ptr = &filters)
                {
                    GenFilters(n, filters_ptr);
                }
            }
            /// <inheritdoc cref="GenFiltersDirect(ALCContext, int, int*)"/>
            public static unsafe void GenFiltersDirect(ALCContext context, int n, Span<int> filters)
            {
                fixed (int* filters_ptr = filters)
                {
                    GenFiltersDirect(context, n, filters_ptr);
                }
            }
            /// <inheritdoc cref="GenFiltersDirect(ALCContext, int, int*)"/>
            public static unsafe void GenFiltersDirect(ALCContext context, int n, int[] filters)
            {
                fixed (int* filters_ptr = filters)
                {
                    GenFiltersDirect(context, n, filters_ptr);
                }
            }
            /// <inheritdoc cref="GenFiltersDirect(ALCContext, int, int*)"/>
            public static unsafe void GenFiltersDirect(ALCContext context, int n, ref int filters)
            {
                fixed (int* filters_ptr = &filters)
                {
                    GenFiltersDirect(context, n, filters_ptr);
                }
            }
            /// <inheritdoc cref="GenSourcesDirect(ALCContext, int, int*)"/>
            public static unsafe void GenSourcesDirect(ALCContext context, int n, Span<int> sources)
            {
                fixed (int* sources_ptr = sources)
                {
                    GenSourcesDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="GenSourcesDirect(ALCContext, int, int*)"/>
            public static unsafe void GenSourcesDirect(ALCContext context, int n, int[] sources)
            {
                fixed (int* sources_ptr = sources)
                {
                    GenSourcesDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="GenSourcesDirect(ALCContext, int, int*)"/>
            public static unsafe void GenSourcesDirect(ALCContext context, int n, ref int sources)
            {
                fixed (int* sources_ptr = &sources)
                {
                    GenSourcesDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotf(int, AuxEffectSlotGetPNameF, float*)"/>
            public static unsafe float GetAuxiliaryEffectSlotf(int effectslot, AuxEffectSlotGetPNameF param)
            {
                float pflValue;
                float* pflValue_ptr = &pflValue;
                {
                    GetAuxiliaryEffectSlotf(effectslot, param, pflValue_ptr);
                }
                return pflValue;
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotf(int, AuxEffectSlotGetPNameF, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotf(int effectslot, AuxEffectSlotGetPNameF param, out float pflValue)
            {
                fixed (float* pflValue_ptr = &pflValue)
                {
                    GetAuxiliaryEffectSlotf(effectslot, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotfDirect(ALCContext, int, AuxEffectSlotGetPNameF, float*)"/>
            public static unsafe float GetAuxiliaryEffectSlotfDirect(ALCContext context, int effectslot, AuxEffectSlotGetPNameF param)
            {
                float pflValue;
                float* pflValue_ptr = &pflValue;
                {
                    GetAuxiliaryEffectSlotfDirect(context, effectslot, param, pflValue_ptr);
                }
                return pflValue;
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotfDirect(ALCContext, int, AuxEffectSlotGetPNameF, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotfDirect(ALCContext context, int effectslot, AuxEffectSlotGetPNameF param, out float pflValue)
            {
                fixed (float* pflValue_ptr = &pflValue)
                {
                    GetAuxiliaryEffectSlotfDirect(context, effectslot, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotfv(int, AuxEffectSlotGetPNameFV, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotfv(int effectslot, AuxEffectSlotGetPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetAuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotfv(int, AuxEffectSlotGetPNameFV, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotfv(int effectslot, AuxEffectSlotGetPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetAuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotfv(int, AuxEffectSlotGetPNameFV, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotfv(int effectslot, AuxEffectSlotGetPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    GetAuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotfvDirect(ALCContext, int, AuxEffectSlotGetPNameFV, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotfvDirect(ALCContext context, int effectslot, AuxEffectSlotGetPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetAuxiliaryEffectSlotfvDirect(context, effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotfvDirect(ALCContext, int, AuxEffectSlotGetPNameFV, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotfvDirect(ALCContext context, int effectslot, AuxEffectSlotGetPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetAuxiliaryEffectSlotfvDirect(context, effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotfvDirect(ALCContext, int, AuxEffectSlotGetPNameFV, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotfvDirect(ALCContext context, int effectslot, AuxEffectSlotGetPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    GetAuxiliaryEffectSlotfvDirect(context, effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSloti(int, AuxEffectSlotGetPNameI, int*)"/>
            public static unsafe int GetAuxiliaryEffectSloti(int effectslot, AuxEffectSlotGetPNameI param)
            {
                int piValue;
                int* piValue_ptr = &piValue;
                {
                    GetAuxiliaryEffectSloti(effectslot, param, piValue_ptr);
                }
                return piValue;
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSloti(int, AuxEffectSlotGetPNameI, int*)"/>
            public static unsafe void GetAuxiliaryEffectSloti(int effectslot, AuxEffectSlotGetPNameI param, out int piValue)
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    GetAuxiliaryEffectSloti(effectslot, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotiDirect(ALCContext, int, AuxEffectSlotGetPNameI, int*)"/>
            public static unsafe int GetAuxiliaryEffectSlotiDirect(ALCContext context, int effectslot, AuxEffectSlotGetPNameI param)
            {
                int piValue;
                int* piValue_ptr = &piValue;
                {
                    GetAuxiliaryEffectSlotiDirect(context, effectslot, param, piValue_ptr);
                }
                return piValue;
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotiDirect(ALCContext, int, AuxEffectSlotGetPNameI, int*)"/>
            public static unsafe void GetAuxiliaryEffectSlotiDirect(ALCContext context, int effectslot, AuxEffectSlotGetPNameI param, out int piValue)
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    GetAuxiliaryEffectSlotiDirect(context, effectslot, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotiv(int, AuxEffectSlotGetPNameIV, int*)"/>
            public static unsafe void GetAuxiliaryEffectSlotiv(int effectslot, AuxEffectSlotGetPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetAuxiliaryEffectSlotiv(effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotiv(int, AuxEffectSlotGetPNameIV, int*)"/>
            public static unsafe void GetAuxiliaryEffectSlotiv(int effectslot, AuxEffectSlotGetPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetAuxiliaryEffectSlotiv(effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotiv(int, AuxEffectSlotGetPNameIV, int*)"/>
            public static unsafe void GetAuxiliaryEffectSlotiv(int effectslot, AuxEffectSlotGetPNameIV param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    GetAuxiliaryEffectSlotiv(effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotivDirect(ALCContext, int, AuxEffectSlotGetPNameIV, int*)"/>
            public static unsafe void GetAuxiliaryEffectSlotivDirect(ALCContext context, int effectslot, AuxEffectSlotGetPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetAuxiliaryEffectSlotivDirect(context, effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotivDirect(ALCContext, int, AuxEffectSlotGetPNameIV, int*)"/>
            public static unsafe void GetAuxiliaryEffectSlotivDirect(ALCContext context, int effectslot, AuxEffectSlotGetPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetAuxiliaryEffectSlotivDirect(context, effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotivDirect(ALCContext, int, AuxEffectSlotGetPNameIV, int*)"/>
            public static unsafe void GetAuxiliaryEffectSlotivDirect(ALCContext context, int effectslot, AuxEffectSlotGetPNameIV param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    GetAuxiliaryEffectSlotivDirect(context, effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetBooleanvDirect(ALCContext, GetPNameBV, bool*)"/>
            public static unsafe void GetBooleanvDirect(ALCContext context, GetPNameBV param, Span<bool> values)
            {
                fixed (bool* values_ptr = values)
                {
                    GetBooleanvDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetBooleanvDirect(ALCContext, GetPNameBV, bool*)"/>
            public static unsafe void GetBooleanvDirect(ALCContext context, GetPNameBV param, bool[] values)
            {
                fixed (bool* values_ptr = values)
                {
                    GetBooleanvDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetBooleanvDirect(ALCContext, GetPNameBV, bool*)"/>
            public static unsafe void GetBooleanvDirect(ALCContext context, GetPNameBV param, ref bool values)
            {
                fixed (bool* values_ptr = &values)
                {
                    GetBooleanvDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetBuffer3fDirect(ALCContext, int, BufferGetPName3F, float*, float*, float*)"/>
            public static unsafe float GetBuffer3fDirect(ALCContext context, int buffer, BufferGetPName3F param, out float value1, out float value2)
            {
                float value3;
                float* value3_ptr = &value3;
                fixed (float* value1_ptr = &value1)
                fixed (float* value2_ptr = &value2)
                {
                    GetBuffer3fDirect(context, buffer, param, value1_ptr, value2_ptr, value3_ptr);
                }
                return value3;
            }
            /// <inheritdoc cref="GetBuffer3fDirect(ALCContext, int, BufferGetPName3F, float*, float*, float*)"/>
            public static unsafe void GetBuffer3fDirect(ALCContext context, int buffer, BufferGetPName3F param, out float value1, out float value2, out float value3)
            {
                fixed (float* value1_ptr = &value1)
                fixed (float* value2_ptr = &value2)
                fixed (float* value3_ptr = &value3)
                {
                    GetBuffer3fDirect(context, buffer, param, value1_ptr, value2_ptr, value3_ptr);
                }
            }
            /// <inheritdoc cref="GetBuffer3iDirect(ALCContext, int, BufferGetPName3I, int*, int*, int*)"/>
            public static unsafe int GetBuffer3iDirect(ALCContext context, int buffer, BufferGetPName3I param, out int value1, out int value2)
            {
                int value3;
                int* value3_ptr = &value3;
                fixed (int* value1_ptr = &value1)
                fixed (int* value2_ptr = &value2)
                {
                    GetBuffer3iDirect(context, buffer, param, value1_ptr, value2_ptr, value3_ptr);
                }
                return value3;
            }
            /// <inheritdoc cref="GetBuffer3iDirect(ALCContext, int, BufferGetPName3I, int*, int*, int*)"/>
            public static unsafe void GetBuffer3iDirect(ALCContext context, int buffer, BufferGetPName3I param, out int value1, out int value2, out int value3)
            {
                fixed (int* value1_ptr = &value1)
                fixed (int* value2_ptr = &value2)
                fixed (int* value3_ptr = &value3)
                {
                    GetBuffer3iDirect(context, buffer, param, value1_ptr, value2_ptr, value3_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferfDirect(ALCContext, int, BufferGetPNameF, float*)"/>
            public static unsafe float GetBufferfDirect(ALCContext context, int buffer, BufferGetPNameF param)
            {
                float value;
                float* value_ptr = &value;
                {
                    GetBufferfDirect(context, buffer, param, value_ptr);
                }
                return value;
            }
            /// <inheritdoc cref="GetBufferfDirect(ALCContext, int, BufferGetPNameF, float*)"/>
            public static unsafe void GetBufferfDirect(ALCContext context, int buffer, BufferGetPNameF param, out float value)
            {
                fixed (float* value_ptr = &value)
                {
                    GetBufferfDirect(context, buffer, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferfvDirect(ALCContext, int, BufferGetPNameFV, float*)"/>
            public static unsafe void GetBufferfvDirect(ALCContext context, int buffer, BufferGetPNameFV param, Span<float> value)
            {
                fixed (float* value_ptr = value)
                {
                    GetBufferfvDirect(context, buffer, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferfvDirect(ALCContext, int, BufferGetPNameFV, float*)"/>
            public static unsafe void GetBufferfvDirect(ALCContext context, int buffer, BufferGetPNameFV param, float[] value)
            {
                fixed (float* value_ptr = value)
                {
                    GetBufferfvDirect(context, buffer, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferfvDirect(ALCContext, int, BufferGetPNameFV, float*)"/>
            public static unsafe void GetBufferfvDirect(ALCContext context, int buffer, BufferGetPNameFV param, ref float value)
            {
                fixed (float* value_ptr = &value)
                {
                    GetBufferfvDirect(context, buffer, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferiDirect(ALCContext, int, BufferGetPNameI, int*)"/>
            public static unsafe int GetBufferiDirect(ALCContext context, int buffer, BufferGetPNameI param)
            {
                int value;
                int* value_ptr = &value;
                {
                    GetBufferiDirect(context, buffer, param, value_ptr);
                }
                return value;
            }
            /// <inheritdoc cref="GetBufferiDirect(ALCContext, int, BufferGetPNameI, int*)"/>
            public static unsafe void GetBufferiDirect(ALCContext context, int buffer, BufferGetPNameI param, out int value)
            {
                fixed (int* value_ptr = &value)
                {
                    GetBufferiDirect(context, buffer, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferivDirect(ALCContext, int, BufferGetPNameIV, int*)"/>
            public static unsafe void GetBufferivDirect(ALCContext context, int buffer, BufferGetPNameIV param, Span<int> value)
            {
                fixed (int* value_ptr = value)
                {
                    GetBufferivDirect(context, buffer, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferivDirect(ALCContext, int, BufferGetPNameIV, int*)"/>
            public static unsafe void GetBufferivDirect(ALCContext context, int buffer, BufferGetPNameIV param, int[] value)
            {
                fixed (int* value_ptr = value)
                {
                    GetBufferivDirect(context, buffer, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferivDirect(ALCContext, int, BufferGetPNameIV, int*)"/>
            public static unsafe void GetBufferivDirect(ALCContext context, int buffer, BufferGetPNameIV param, ref int value)
            {
                fixed (int* value_ptr = &value)
                {
                    GetBufferivDirect(context, buffer, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferSamplesDirectSOFT(ALCContext, int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void GetBufferSamplesDirectSOFT(ALCContext context, int buffer, int offset, int samples, Channels channels, SampleType type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                GetBufferSamplesDirectSOFT(context, buffer, offset, samples, channels, type, data_vptr);
            }
            /// <inheritdoc cref="GetBufferSamplesDirectSOFT(ALCContext, int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void GetBufferSamplesDirectSOFT<T1>(ALCContext context, int buffer, int offset, int samples, Channels channels, SampleType type, Span<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    GetBufferSamplesDirectSOFT(context, buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferSamplesDirectSOFT(ALCContext, int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void GetBufferSamplesDirectSOFT<T1>(ALCContext context, int buffer, int offset, int samples, Channels channels, SampleType type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    GetBufferSamplesDirectSOFT(context, buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferSamplesDirectSOFT(ALCContext, int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void GetBufferSamplesDirectSOFT<T1>(ALCContext context, int buffer, int offset, int samples, Channels channels, SampleType type, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    GetBufferSamplesDirectSOFT(context, buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="GetDebugMessageLogDirectEXT(ALCContext, uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*)"/>
            public static unsafe uint GetDebugMessageLogDirectEXT(ALCContext context, uint count, int logBufSize, Span<DebugSource> sources, Span<DebugType> types, Span<uint> ids, Span<DebugSeverity> severities, Span<int> lengths, out string logBuf)
            {
                uint returnValue;
                fixed (int* lengths_ptr = lengths)
                {
                    fixed (DebugSeverity* severities_ptr = severities)
                    {
                        fixed (uint* ids_ptr = ids)
                        {
                            fixed (DebugType* types_ptr = types)
                            {
                                fixed (DebugSource* sources_ptr = sources)
                                {
                                    var logBuf_ptr = (byte*)Marshal.AllocCoTaskMem(logBufSize);
                                    returnValue = GetDebugMessageLogDirectEXT(context, count, logBufSize, sources_ptr, types_ptr, ids_ptr, severities_ptr, lengths_ptr, logBuf_ptr);
                                    logBuf = Marshal.PtrToStringUTF8((IntPtr)logBuf_ptr)!;
                                    Marshal.FreeCoTaskMem((IntPtr)logBuf_ptr);
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDebugMessageLogDirectEXT(ALCContext, uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*)"/>
            public static unsafe uint GetDebugMessageLogDirectEXT(ALCContext context, uint count, int logBufSize, DebugSource[] sources, DebugType[] types, uint[] ids, DebugSeverity[] severities, int[] lengths, out string logBuf)
            {
                uint returnValue;
                fixed (int* lengths_ptr = lengths)
                {
                    fixed (DebugSeverity* severities_ptr = severities)
                    {
                        fixed (uint* ids_ptr = ids)
                        {
                            fixed (DebugType* types_ptr = types)
                            {
                                fixed (DebugSource* sources_ptr = sources)
                                {
                                    var logBuf_ptr = (byte*)Marshal.AllocCoTaskMem(logBufSize);
                                    returnValue = GetDebugMessageLogDirectEXT(context, count, logBufSize, sources_ptr, types_ptr, ids_ptr, severities_ptr, lengths_ptr, logBuf_ptr);
                                    logBuf = Marshal.PtrToStringUTF8((IntPtr)logBuf_ptr)!;
                                    Marshal.FreeCoTaskMem((IntPtr)logBuf_ptr);
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDebugMessageLogDirectEXT(ALCContext, uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*)"/>
            public static unsafe uint GetDebugMessageLogDirectEXT(ALCContext context, uint count, int logBufSize, ref DebugSource sources, ref DebugType types, ref uint ids, ref DebugSeverity severities, ref int lengths, out string logBuf)
            {
                uint returnValue;
                fixed (DebugSource* sources_ptr = &sources)
                fixed (DebugType* types_ptr = &types)
                fixed (uint* ids_ptr = &ids)
                fixed (DebugSeverity* severities_ptr = &severities)
                fixed (int* lengths_ptr = &lengths)
                {
                    var logBuf_ptr = (byte*)Marshal.AllocCoTaskMem(logBufSize);
                    returnValue = GetDebugMessageLogDirectEXT(context, count, logBufSize, sources_ptr, types_ptr, ids_ptr, severities_ptr, lengths_ptr, logBuf_ptr);
                    logBuf = Marshal.PtrToStringUTF8((IntPtr)logBuf_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)logBuf_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDebugMessageLogEXT(uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*)"/>
            public static unsafe uint GetDebugMessageLogEXT(uint count, int logBufSize, Span<DebugSource> sources, Span<DebugType> types, Span<uint> ids, Span<DebugSeverity> severities, Span<int> lengths, out string logBuf)
            {
                uint returnValue;
                fixed (int* lengths_ptr = lengths)
                {
                    fixed (DebugSeverity* severities_ptr = severities)
                    {
                        fixed (uint* ids_ptr = ids)
                        {
                            fixed (DebugType* types_ptr = types)
                            {
                                fixed (DebugSource* sources_ptr = sources)
                                {
                                    var logBuf_ptr = (byte*)Marshal.AllocCoTaskMem(logBufSize);
                                    returnValue = GetDebugMessageLogEXT(count, logBufSize, sources_ptr, types_ptr, ids_ptr, severities_ptr, lengths_ptr, logBuf_ptr);
                                    logBuf = Marshal.PtrToStringUTF8((IntPtr)logBuf_ptr)!;
                                    Marshal.FreeCoTaskMem((IntPtr)logBuf_ptr);
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDebugMessageLogEXT(uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*)"/>
            public static unsafe uint GetDebugMessageLogEXT(uint count, int logBufSize, DebugSource[] sources, DebugType[] types, uint[] ids, DebugSeverity[] severities, int[] lengths, out string logBuf)
            {
                uint returnValue;
                fixed (int* lengths_ptr = lengths)
                {
                    fixed (DebugSeverity* severities_ptr = severities)
                    {
                        fixed (uint* ids_ptr = ids)
                        {
                            fixed (DebugType* types_ptr = types)
                            {
                                fixed (DebugSource* sources_ptr = sources)
                                {
                                    var logBuf_ptr = (byte*)Marshal.AllocCoTaskMem(logBufSize);
                                    returnValue = GetDebugMessageLogEXT(count, logBufSize, sources_ptr, types_ptr, ids_ptr, severities_ptr, lengths_ptr, logBuf_ptr);
                                    logBuf = Marshal.PtrToStringUTF8((IntPtr)logBuf_ptr)!;
                                    Marshal.FreeCoTaskMem((IntPtr)logBuf_ptr);
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDebugMessageLogEXT(uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*)"/>
            public static unsafe uint GetDebugMessageLogEXT(uint count, int logBufSize, ref DebugSource sources, ref DebugType types, ref uint ids, ref DebugSeverity severities, ref int lengths, out string logBuf)
            {
                uint returnValue;
                fixed (DebugSource* sources_ptr = &sources)
                fixed (DebugType* types_ptr = &types)
                fixed (uint* ids_ptr = &ids)
                fixed (DebugSeverity* severities_ptr = &severities)
                fixed (int* lengths_ptr = &lengths)
                {
                    var logBuf_ptr = (byte*)Marshal.AllocCoTaskMem(logBufSize);
                    returnValue = GetDebugMessageLogEXT(count, logBufSize, sources_ptr, types_ptr, ids_ptr, severities_ptr, lengths_ptr, logBuf_ptr);
                    logBuf = Marshal.PtrToStringUTF8((IntPtr)logBuf_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)logBuf_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDoublevDirect(ALCContext, GetPNameDV, double*)"/>
            public static unsafe void GetDoublevDirect(ALCContext context, GetPNameDV param, Span<double> values)
            {
                fixed (double* values_ptr = values)
                {
                    GetDoublevDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetDoublevDirect(ALCContext, GetPNameDV, double*)"/>
            public static unsafe void GetDoublevDirect(ALCContext context, GetPNameDV param, double[] values)
            {
                fixed (double* values_ptr = values)
                {
                    GetDoublevDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetDoublevDirect(ALCContext, GetPNameDV, double*)"/>
            public static unsafe void GetDoublevDirect(ALCContext context, GetPNameDV param, ref double values)
            {
                fixed (double* values_ptr = &values)
                {
                    GetDoublevDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectf(int, EffectGetPNameF, float*)"/>
            public static unsafe float GetEffectf(int effect, EffectGetPNameF param)
            {
                float pflValue;
                float* pflValue_ptr = &pflValue;
                {
                    GetEffectf(effect, param, pflValue_ptr);
                }
                return pflValue;
            }
            /// <inheritdoc cref="GetEffectf(int, EffectGetPNameF, float*)"/>
            public static unsafe void GetEffectf(int effect, EffectGetPNameF param, out float pflValue)
            {
                fixed (float* pflValue_ptr = &pflValue)
                {
                    GetEffectf(effect, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectfDirect(ALCContext, int, EffectGetPNameF, float*)"/>
            public static unsafe float GetEffectfDirect(ALCContext context, int effect, EffectGetPNameF param)
            {
                float pflValue;
                float* pflValue_ptr = &pflValue;
                {
                    GetEffectfDirect(context, effect, param, pflValue_ptr);
                }
                return pflValue;
            }
            /// <inheritdoc cref="GetEffectfDirect(ALCContext, int, EffectGetPNameF, float*)"/>
            public static unsafe void GetEffectfDirect(ALCContext context, int effect, EffectGetPNameF param, out float pflValue)
            {
                fixed (float* pflValue_ptr = &pflValue)
                {
                    GetEffectfDirect(context, effect, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectfv(int, EffectGetPNameFV, float*)"/>
            public static unsafe void GetEffectfv(int effect, EffectGetPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetEffectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectfv(int, EffectGetPNameFV, float*)"/>
            public static unsafe void GetEffectfv(int effect, EffectGetPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetEffectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectfv(int, EffectGetPNameFV, float*)"/>
            public static unsafe void GetEffectfv(int effect, EffectGetPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    GetEffectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectfvDirect(ALCContext, int, EffectGetPNameFV, float*)"/>
            public static unsafe void GetEffectfvDirect(ALCContext context, int effect, EffectGetPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetEffectfvDirect(context, effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectfvDirect(ALCContext, int, EffectGetPNameFV, float*)"/>
            public static unsafe void GetEffectfvDirect(ALCContext context, int effect, EffectGetPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetEffectfvDirect(context, effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectfvDirect(ALCContext, int, EffectGetPNameFV, float*)"/>
            public static unsafe void GetEffectfvDirect(ALCContext context, int effect, EffectGetPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    GetEffectfvDirect(context, effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffecti(int, EffectGetPNameI, int*)"/>
            public static unsafe int GetEffecti(int effect, EffectGetPNameI param)
            {
                int piValue;
                int* piValue_ptr = &piValue;
                {
                    GetEffecti(effect, param, piValue_ptr);
                }
                return piValue;
            }
            /// <inheritdoc cref="GetEffecti(int, EffectGetPNameI, int*)"/>
            public static unsafe void GetEffecti(int effect, EffectGetPNameI param, out int piValue)
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    GetEffecti(effect, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectiDirect(ALCContext, int, EffectGetPNameI, int*)"/>
            public static unsafe int GetEffectiDirect(ALCContext context, int effect, EffectGetPNameI param)
            {
                int piValue;
                int* piValue_ptr = &piValue;
                {
                    GetEffectiDirect(context, effect, param, piValue_ptr);
                }
                return piValue;
            }
            /// <inheritdoc cref="GetEffectiDirect(ALCContext, int, EffectGetPNameI, int*)"/>
            public static unsafe void GetEffectiDirect(ALCContext context, int effect, EffectGetPNameI param, out int piValue)
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    GetEffectiDirect(context, effect, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectiv(int, EffectGetPNameIV, int*)"/>
            public static unsafe void GetEffectiv(int effect, EffectGetPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetEffectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectiv(int, EffectGetPNameIV, int*)"/>
            public static unsafe void GetEffectiv(int effect, EffectGetPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetEffectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectiv(int, EffectGetPNameIV, int*)"/>
            public static unsafe void GetEffectiv(int effect, EffectGetPNameIV param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    GetEffectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectivDirect(ALCContext, int, EffectGetPNameIV, int*)"/>
            public static unsafe void GetEffectivDirect(ALCContext context, int effect, EffectGetPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetEffectivDirect(context, effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectivDirect(ALCContext, int, EffectGetPNameIV, int*)"/>
            public static unsafe void GetEffectivDirect(ALCContext context, int effect, EffectGetPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetEffectivDirect(context, effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectivDirect(ALCContext, int, EffectGetPNameIV, int*)"/>
            public static unsafe void GetEffectivDirect(ALCContext context, int effect, EffectGetPNameIV param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    GetEffectivDirect(context, effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEnumValueDirect(ALCContext, byte*)"/>
            public static unsafe All GetEnumValueDirect(ALCContext context, string ename)
            {
                All returnValue;
                byte* ename_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(ename);
                returnValue = GetEnumValueDirect(context, ename_ptr);
                Marshal.FreeCoTaskMem((IntPtr)ename_ptr);
                return returnValue;
            }
            /// <inheritdoc cref="GetFilterf(int, FilterGetPNameF, float*)"/>
            public static unsafe float GetFilterf(int filter, FilterGetPNameF param)
            {
                float pflValue;
                float* pflValue_ptr = &pflValue;
                {
                    GetFilterf(filter, param, pflValue_ptr);
                }
                return pflValue;
            }
            /// <inheritdoc cref="GetFilterf(int, FilterGetPNameF, float*)"/>
            public static unsafe void GetFilterf(int filter, FilterGetPNameF param, out float pflValue)
            {
                fixed (float* pflValue_ptr = &pflValue)
                {
                    GetFilterf(filter, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterfDirect(ALCContext, int, FilterGetPNameF, float*)"/>
            public static unsafe float GetFilterfDirect(ALCContext context, int filter, FilterGetPNameF param)
            {
                float pflValue;
                float* pflValue_ptr = &pflValue;
                {
                    GetFilterfDirect(context, filter, param, pflValue_ptr);
                }
                return pflValue;
            }
            /// <inheritdoc cref="GetFilterfDirect(ALCContext, int, FilterGetPNameF, float*)"/>
            public static unsafe void GetFilterfDirect(ALCContext context, int filter, FilterGetPNameF param, out float pflValue)
            {
                fixed (float* pflValue_ptr = &pflValue)
                {
                    GetFilterfDirect(context, filter, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterfv(int, FilterGetPNameFV, float*)"/>
            public static unsafe void GetFilterfv(int filter, FilterGetPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetFilterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterfv(int, FilterGetPNameFV, float*)"/>
            public static unsafe void GetFilterfv(int filter, FilterGetPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetFilterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterfv(int, FilterGetPNameFV, float*)"/>
            public static unsafe void GetFilterfv(int filter, FilterGetPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    GetFilterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterfvDirect(ALCContext, int, FilterGetPNameFV, float*)"/>
            public static unsafe void GetFilterfvDirect(ALCContext context, int filter, FilterGetPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetFilterfvDirect(context, filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterfvDirect(ALCContext, int, FilterGetPNameFV, float*)"/>
            public static unsafe void GetFilterfvDirect(ALCContext context, int filter, FilterGetPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetFilterfvDirect(context, filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterfvDirect(ALCContext, int, FilterGetPNameFV, float*)"/>
            public static unsafe void GetFilterfvDirect(ALCContext context, int filter, FilterGetPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    GetFilterfvDirect(context, filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilteri(int, FilterGetPNameI, int*)"/>
            public static unsafe int GetFilteri(int filter, FilterGetPNameI param)
            {
                int piValue;
                int* piValue_ptr = &piValue;
                {
                    GetFilteri(filter, param, piValue_ptr);
                }
                return piValue;
            }
            /// <inheritdoc cref="GetFilteri(int, FilterGetPNameI, int*)"/>
            public static unsafe void GetFilteri(int filter, FilterGetPNameI param, out int piValue)
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    GetFilteri(filter, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetFilteriDirect(ALCContext, int, FilterGetPNameI, int*)"/>
            public static unsafe int GetFilteriDirect(ALCContext context, int filter, FilterGetPNameI param)
            {
                int piValue;
                int* piValue_ptr = &piValue;
                {
                    GetFilteriDirect(context, filter, param, piValue_ptr);
                }
                return piValue;
            }
            /// <inheritdoc cref="GetFilteriDirect(ALCContext, int, FilterGetPNameI, int*)"/>
            public static unsafe void GetFilteriDirect(ALCContext context, int filter, FilterGetPNameI param, out int piValue)
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    GetFilteriDirect(context, filter, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetFilteriv(int, FilterGetPNameIV, int*)"/>
            public static unsafe void GetFilteriv(int filter, FilterGetPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetFilteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilteriv(int, FilterGetPNameIV, int*)"/>
            public static unsafe void GetFilteriv(int filter, FilterGetPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetFilteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilteriv(int, FilterGetPNameIV, int*)"/>
            public static unsafe void GetFilteriv(int filter, FilterGetPNameIV param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    GetFilteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterivDirect(ALCContext, int, FilterGetPNameIV, int*)"/>
            public static unsafe void GetFilterivDirect(ALCContext context, int filter, FilterGetPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetFilterivDirect(context, filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterivDirect(ALCContext, int, FilterGetPNameIV, int*)"/>
            public static unsafe void GetFilterivDirect(ALCContext context, int filter, FilterGetPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetFilterivDirect(context, filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterivDirect(ALCContext, int, FilterGetPNameIV, int*)"/>
            public static unsafe void GetFilterivDirect(ALCContext context, int filter, FilterGetPNameIV param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    GetFilterivDirect(context, filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFloatvDirect(ALCContext, GetPNameFV, float*)"/>
            public static unsafe void GetFloatvDirect(ALCContext context, GetPNameFV param, Span<float> values)
            {
                fixed (float* values_ptr = values)
                {
                    GetFloatvDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetFloatvDirect(ALCContext, GetPNameFV, float*)"/>
            public static unsafe void GetFloatvDirect(ALCContext context, GetPNameFV param, float[] values)
            {
                fixed (float* values_ptr = values)
                {
                    GetFloatvDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetFloatvDirect(ALCContext, GetPNameFV, float*)"/>
            public static unsafe void GetFloatvDirect(ALCContext context, GetPNameFV param, ref float values)
            {
                fixed (float* values_ptr = &values)
                {
                    GetFloatvDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetIntegervDirect(ALCContext, GetPNameIV, int*)"/>
            public static unsafe void GetIntegervDirect(ALCContext context, GetPNameIV param, Span<int> values)
            {
                fixed (int* values_ptr = values)
                {
                    GetIntegervDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetIntegervDirect(ALCContext, GetPNameIV, int*)"/>
            public static unsafe void GetIntegervDirect(ALCContext context, GetPNameIV param, int[] values)
            {
                fixed (int* values_ptr = values)
                {
                    GetIntegervDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetIntegervDirect(ALCContext, GetPNameIV, int*)"/>
            public static unsafe void GetIntegervDirect(ALCContext context, GetPNameIV param, ref int values)
            {
                fixed (int* values_ptr = &values)
                {
                    GetIntegervDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetListener3fDirect(ALCContext, ListenerGetPName3F, float*, float*, float*)"/>
            public static unsafe float GetListener3fDirect(ALCContext context, ListenerGetPName3F param, out float value1, out float value2)
            {
                float value3;
                float* value3_ptr = &value3;
                fixed (float* value1_ptr = &value1)
                fixed (float* value2_ptr = &value2)
                {
                    GetListener3fDirect(context, param, value1_ptr, value2_ptr, value3_ptr);
                }
                return value3;
            }
            /// <inheritdoc cref="GetListener3fDirect(ALCContext, ListenerGetPName3F, float*, float*, float*)"/>
            public static unsafe void GetListener3fDirect(ALCContext context, ListenerGetPName3F param, out float value1, out float value2, out float value3)
            {
                fixed (float* value1_ptr = &value1)
                fixed (float* value2_ptr = &value2)
                fixed (float* value3_ptr = &value3)
                {
                    GetListener3fDirect(context, param, value1_ptr, value2_ptr, value3_ptr);
                }
            }
            /// <inheritdoc cref="GetListener3iDirect(ALCContext, ListenerGetPName3I, int*, int*, int*)"/>
            public static unsafe int GetListener3iDirect(ALCContext context, ListenerGetPName3I param, out int value1, out int value2)
            {
                int value3;
                int* value3_ptr = &value3;
                fixed (int* value1_ptr = &value1)
                fixed (int* value2_ptr = &value2)
                {
                    GetListener3iDirect(context, param, value1_ptr, value2_ptr, value3_ptr);
                }
                return value3;
            }
            /// <inheritdoc cref="GetListener3iDirect(ALCContext, ListenerGetPName3I, int*, int*, int*)"/>
            public static unsafe void GetListener3iDirect(ALCContext context, ListenerGetPName3I param, out int value1, out int value2, out int value3)
            {
                fixed (int* value1_ptr = &value1)
                fixed (int* value2_ptr = &value2)
                fixed (int* value3_ptr = &value3)
                {
                    GetListener3iDirect(context, param, value1_ptr, value2_ptr, value3_ptr);
                }
            }
            /// <inheritdoc cref="GetListenerfDirect(ALCContext, ListenerGetPNameF, float*)"/>
            public static unsafe float GetListenerfDirect(ALCContext context, ListenerGetPNameF param)
            {
                float value;
                float* value_ptr = &value;
                {
                    GetListenerfDirect(context, param, value_ptr);
                }
                return value;
            }
            /// <inheritdoc cref="GetListenerfDirect(ALCContext, ListenerGetPNameF, float*)"/>
            public static unsafe void GetListenerfDirect(ALCContext context, ListenerGetPNameF param, out float value)
            {
                fixed (float* value_ptr = &value)
                {
                    GetListenerfDirect(context, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetListenerfvDirect(ALCContext, ListenerGetPNameFV, float*)"/>
            public static unsafe void GetListenerfvDirect(ALCContext context, ListenerGetPNameFV param, Span<float> values)
            {
                fixed (float* values_ptr = values)
                {
                    GetListenerfvDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetListenerfvDirect(ALCContext, ListenerGetPNameFV, float*)"/>
            public static unsafe void GetListenerfvDirect(ALCContext context, ListenerGetPNameFV param, float[] values)
            {
                fixed (float* values_ptr = values)
                {
                    GetListenerfvDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetListenerfvDirect(ALCContext, ListenerGetPNameFV, float*)"/>
            public static unsafe void GetListenerfvDirect(ALCContext context, ListenerGetPNameFV param, ref float values)
            {
                fixed (float* values_ptr = &values)
                {
                    GetListenerfvDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetListeneriDirect(ALCContext, ListenerGetPNameI, int*)"/>
            public static unsafe int GetListeneriDirect(ALCContext context, ListenerGetPNameI param)
            {
                int value;
                int* value_ptr = &value;
                {
                    GetListeneriDirect(context, param, value_ptr);
                }
                return value;
            }
            /// <inheritdoc cref="GetListeneriDirect(ALCContext, ListenerGetPNameI, int*)"/>
            public static unsafe void GetListeneriDirect(ALCContext context, ListenerGetPNameI param, out int value)
            {
                fixed (int* value_ptr = &value)
                {
                    GetListeneriDirect(context, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetListenerivDirect(ALCContext, ListenerGetPNameIV, int*)"/>
            public static unsafe void GetListenerivDirect(ALCContext context, ListenerGetPNameIV param, Span<int> values)
            {
                fixed (int* values_ptr = values)
                {
                    GetListenerivDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetListenerivDirect(ALCContext, ListenerGetPNameIV, int*)"/>
            public static unsafe void GetListenerivDirect(ALCContext context, ListenerGetPNameIV param, int[] values)
            {
                fixed (int* values_ptr = values)
                {
                    GetListenerivDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetListenerivDirect(ALCContext, ListenerGetPNameIV, int*)"/>
            public static unsafe void GetListenerivDirect(ALCContext context, ListenerGetPNameIV param, ref int values)
            {
                fixed (int* values_ptr = &values)
                {
                    GetListenerivDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetObjectLabelDirectEXT(ALCContext, ObjectType, uint, int, int*, byte*)"/>
            public static unsafe string GetObjectLabelDirectEXT(ALCContext context, ObjectType identifier, uint name, int bufSize, out int length)
            {
                string label;
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabelDirectEXT(context, identifier, name, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            /// <inheritdoc cref="GetObjectLabelDirectEXT(ALCContext, ObjectType, uint, int, int*, byte*)"/>
            public static unsafe void GetObjectLabelDirectEXT(ALCContext context, ObjectType identifier, uint name, int bufSize, out int length, out string label)
            {
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabelDirectEXT(context, identifier, name, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            /// <inheritdoc cref="GetObjectLabelEXT(ObjectType, uint, int, int*, byte*)"/>
            public static unsafe string GetObjectLabelEXT(ObjectType identifier, uint name, int bufSize, out int length)
            {
                string label;
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabelEXT(identifier, name, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
                return label;
            }
            /// <inheritdoc cref="GetObjectLabelEXT(ObjectType, uint, int, int*, byte*)"/>
            public static unsafe void GetObjectLabelEXT(ObjectType identifier, uint name, int bufSize, out int length, out string label)
            {
                fixed (int* length_ptr = &length)
                {
                    var label_ptr = (byte*)Marshal.AllocCoTaskMem(bufSize);
                    GetObjectLabelEXT(identifier, name, bufSize, length_ptr, label_ptr);
                    label = Marshal.PtrToStringUTF8((IntPtr)label_ptr)!;
                    Marshal.FreeCoTaskMem((IntPtr)label_ptr);
                }
            }
            /// <inheritdoc cref="GetProcAddressDirect(ALCContext, byte*)"/>
            public static unsafe void* GetProcAddressDirect(ALCContext context, string fname)
            {
                void* returnValue;
                byte* fname_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(fname);
                returnValue = GetProcAddressDirect(context, fname_ptr);
                Marshal.FreeCoTaskMem((IntPtr)fname_ptr);
                return returnValue;
            }
            /// <inheritdoc cref="GetSource3dDirectSOFT(ALCContext, int, SourceGetPName3D, double*, double*, double*)"/>
            public static unsafe double GetSource3dDirectSOFT(ALCContext context, int source, SourceGetPName3D param, out double value1, out double value2)
            {
                double value3;
                double* value3_ptr = &value3;
                fixed (double* value1_ptr = &value1)
                fixed (double* value2_ptr = &value2)
                {
                    GetSource3dDirectSOFT(context, source, param, value1_ptr, value2_ptr, value3_ptr);
                }
                return value3;
            }
            /// <inheritdoc cref="GetSource3dDirectSOFT(ALCContext, int, SourceGetPName3D, double*, double*, double*)"/>
            public static unsafe void GetSource3dDirectSOFT(ALCContext context, int source, SourceGetPName3D param, out double value1, out double value2, out double value3)
            {
                fixed (double* value1_ptr = &value1)
                fixed (double* value2_ptr = &value2)
                fixed (double* value3_ptr = &value3)
                {
                    GetSource3dDirectSOFT(context, source, param, value1_ptr, value2_ptr, value3_ptr);
                }
            }
            /// <inheritdoc cref="GetSource3fDirect(ALCContext, int, SourceGetPName3F, float*, float*, float*)"/>
            public static unsafe float GetSource3fDirect(ALCContext context, int source, SourceGetPName3F param, out float value1, out float value2)
            {
                float value3;
                float* value3_ptr = &value3;
                fixed (float* value1_ptr = &value1)
                fixed (float* value2_ptr = &value2)
                {
                    GetSource3fDirect(context, source, param, value1_ptr, value2_ptr, value3_ptr);
                }
                return value3;
            }
            /// <inheritdoc cref="GetSource3fDirect(ALCContext, int, SourceGetPName3F, float*, float*, float*)"/>
            public static unsafe void GetSource3fDirect(ALCContext context, int source, SourceGetPName3F param, out float value1, out float value2, out float value3)
            {
                fixed (float* value1_ptr = &value1)
                fixed (float* value2_ptr = &value2)
                fixed (float* value3_ptr = &value3)
                {
                    GetSource3fDirect(context, source, param, value1_ptr, value2_ptr, value3_ptr);
                }
            }
            /// <inheritdoc cref="GetSource3i64DirectSOFT(ALCContext, int, SourceGetPName3I64, long*, long*, long*)"/>
            public static unsafe long GetSource3i64DirectSOFT(ALCContext context, int source, SourceGetPName3I64 param, out long value1, out long value2)
            {
                long value3;
                long* value3_ptr = &value3;
                fixed (long* value1_ptr = &value1)
                fixed (long* value2_ptr = &value2)
                {
                    GetSource3i64DirectSOFT(context, source, param, value1_ptr, value2_ptr, value3_ptr);
                }
                return value3;
            }
            /// <inheritdoc cref="GetSource3i64DirectSOFT(ALCContext, int, SourceGetPName3I64, long*, long*, long*)"/>
            public static unsafe void GetSource3i64DirectSOFT(ALCContext context, int source, SourceGetPName3I64 param, out long value1, out long value2, out long value3)
            {
                fixed (long* value1_ptr = &value1)
                fixed (long* value2_ptr = &value2)
                fixed (long* value3_ptr = &value3)
                {
                    GetSource3i64DirectSOFT(context, source, param, value1_ptr, value2_ptr, value3_ptr);
                }
            }
            /// <inheritdoc cref="GetSource3iDirect(ALCContext, int, SourceGetPName3I, int*, int*, int*)"/>
            public static unsafe int GetSource3iDirect(ALCContext context, int source, SourceGetPName3I param, out int value1, out int value2)
            {
                int value3;
                int* value3_ptr = &value3;
                fixed (int* value1_ptr = &value1)
                fixed (int* value2_ptr = &value2)
                {
                    GetSource3iDirect(context, source, param, value1_ptr, value2_ptr, value3_ptr);
                }
                return value3;
            }
            /// <inheritdoc cref="GetSource3iDirect(ALCContext, int, SourceGetPName3I, int*, int*, int*)"/>
            public static unsafe void GetSource3iDirect(ALCContext context, int source, SourceGetPName3I param, out int value1, out int value2, out int value3)
            {
                fixed (int* value1_ptr = &value1)
                fixed (int* value2_ptr = &value2)
                fixed (int* value3_ptr = &value3)
                {
                    GetSource3iDirect(context, source, param, value1_ptr, value2_ptr, value3_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedDirectSOFT(ALCContext, int, SourceGetPNameD, double*)"/>
            public static unsafe double GetSourcedDirectSOFT(ALCContext context, int source, SourceGetPNameD param)
            {
                double value;
                double* value_ptr = &value;
                {
                    GetSourcedDirectSOFT(context, source, param, value_ptr);
                }
                return value;
            }
            /// <inheritdoc cref="GetSourcedDirectSOFT(ALCContext, int, SourceGetPNameD, double*)"/>
            public static unsafe void GetSourcedDirectSOFT(ALCContext context, int source, SourceGetPNameD param, out double value)
            {
                fixed (double* value_ptr = &value)
                {
                    GetSourcedDirectSOFT(context, source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedvDirectSOFT(ALCContext, int, SourceGetPNameDV, double*)"/>
            public static unsafe void GetSourcedvDirectSOFT(ALCContext context, int source, SourceGetPNameDV param, Span<double> values)
            {
                fixed (double* values_ptr = values)
                {
                    GetSourcedvDirectSOFT(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedvDirectSOFT(ALCContext, int, SourceGetPNameDV, double*)"/>
            public static unsafe void GetSourcedvDirectSOFT(ALCContext context, int source, SourceGetPNameDV param, double[] values)
            {
                fixed (double* values_ptr = values)
                {
                    GetSourcedvDirectSOFT(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedvDirectSOFT(ALCContext, int, SourceGetPNameDV, double*)"/>
            public static unsafe void GetSourcedvDirectSOFT(ALCContext context, int source, SourceGetPNameDV param, ref double values)
            {
                fixed (double* values_ptr = &values)
                {
                    GetSourcedvDirectSOFT(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcefDirect(ALCContext, int, SourceGetPNameF, float*)"/>
            public static unsafe float GetSourcefDirect(ALCContext context, int source, SourceGetPNameF param)
            {
                float value;
                float* value_ptr = &value;
                {
                    GetSourcefDirect(context, source, param, value_ptr);
                }
                return value;
            }
            /// <inheritdoc cref="GetSourcefDirect(ALCContext, int, SourceGetPNameF, float*)"/>
            public static unsafe void GetSourcefDirect(ALCContext context, int source, SourceGetPNameF param, out float value)
            {
                fixed (float* value_ptr = &value)
                {
                    GetSourcefDirect(context, source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcefvDirect(ALCContext, int, SourceGetPNameFV, float*)"/>
            public static unsafe void GetSourcefvDirect(ALCContext context, int source, SourceGetPNameFV param, Span<float> values)
            {
                fixed (float* values_ptr = values)
                {
                    GetSourcefvDirect(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcefvDirect(ALCContext, int, SourceGetPNameFV, float*)"/>
            public static unsafe void GetSourcefvDirect(ALCContext context, int source, SourceGetPNameFV param, float[] values)
            {
                fixed (float* values_ptr = values)
                {
                    GetSourcefvDirect(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcefvDirect(ALCContext, int, SourceGetPNameFV, float*)"/>
            public static unsafe void GetSourcefvDirect(ALCContext context, int source, SourceGetPNameFV param, ref float values)
            {
                fixed (float* values_ptr = &values)
                {
                    GetSourcefvDirect(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64DirectSOFT(ALCContext, int, SourceGetPNameI64, long*)"/>
            public static unsafe long GetSourcei64DirectSOFT(ALCContext context, int source, SourceGetPNameI64 param)
            {
                long value;
                long* value_ptr = &value;
                {
                    GetSourcei64DirectSOFT(context, source, param, value_ptr);
                }
                return value;
            }
            /// <inheritdoc cref="GetSourcei64DirectSOFT(ALCContext, int, SourceGetPNameI64, long*)"/>
            public static unsafe void GetSourcei64DirectSOFT(ALCContext context, int source, SourceGetPNameI64 param, out long value)
            {
                fixed (long* value_ptr = &value)
                {
                    GetSourcei64DirectSOFT(context, source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64vDirectSOFT(ALCContext, int, SourceGetPNameI64V, long*)"/>
            public static unsafe void GetSourcei64vDirectSOFT(ALCContext context, int source, SourceGetPNameI64V param, Span<long> values)
            {
                fixed (long* values_ptr = values)
                {
                    GetSourcei64vDirectSOFT(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64vDirectSOFT(ALCContext, int, SourceGetPNameI64V, long*)"/>
            public static unsafe void GetSourcei64vDirectSOFT(ALCContext context, int source, SourceGetPNameI64V param, long[] values)
            {
                fixed (long* values_ptr = values)
                {
                    GetSourcei64vDirectSOFT(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64vDirectSOFT(ALCContext, int, SourceGetPNameI64V, long*)"/>
            public static unsafe void GetSourcei64vDirectSOFT(ALCContext context, int source, SourceGetPNameI64V param, ref long values)
            {
                fixed (long* values_ptr = &values)
                {
                    GetSourcei64vDirectSOFT(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourceiDirect(ALCContext, int, SourceGetPNameI, int*)"/>
            public static unsafe int GetSourceiDirect(ALCContext context, int source, SourceGetPNameI param)
            {
                int value;
                int* value_ptr = &value;
                {
                    GetSourceiDirect(context, source, param, value_ptr);
                }
                return value;
            }
            /// <inheritdoc cref="GetSourceiDirect(ALCContext, int, SourceGetPNameI, int*)"/>
            public static unsafe void GetSourceiDirect(ALCContext context, int source, SourceGetPNameI param, out int value)
            {
                fixed (int* value_ptr = &value)
                {
                    GetSourceiDirect(context, source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetSourceivDirect(ALCContext, int, SourceGetPNameIV, int*)"/>
            public static unsafe void GetSourceivDirect(ALCContext context, int source, SourceGetPNameIV param, Span<int> values)
            {
                fixed (int* values_ptr = values)
                {
                    GetSourceivDirect(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourceivDirect(ALCContext, int, SourceGetPNameIV, int*)"/>
            public static unsafe void GetSourceivDirect(ALCContext context, int source, SourceGetPNameIV param, int[] values)
            {
                fixed (int* values_ptr = values)
                {
                    GetSourceivDirect(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourceivDirect(ALCContext, int, SourceGetPNameIV, int*)"/>
            public static unsafe void GetSourceivDirect(ALCContext context, int source, SourceGetPNameIV param, ref int values)
            {
                fixed (int* values_ptr = &values)
                {
                    GetSourceivDirect(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetStringDirect_(ALCContext, StringName)"/>
            public static unsafe string? GetStringDirect(ALCContext context, StringName param)
            {
                string? returnValue_str;
                byte* returnValue;
                returnValue = GetStringDirect_(context, param);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="GetStringiDirectSOFT_(ALCContext, IndexedStringName, int)"/>
            public static unsafe string? GetStringiDirectSOFT(ALCContext context, IndexedStringName pname, int index)
            {
                string? returnValue_str;
                byte* returnValue;
                returnValue = GetStringiDirectSOFT_(context, pname, index);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="IsExtensionPresentDirect(ALCContext, byte*)"/>
            public static unsafe bool IsExtensionPresentDirect(ALCContext context, string extname)
            {
                bool returnValue;
                byte* extname_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(extname);
                returnValue = IsExtensionPresentDirect(context, extname_ptr);
                Marshal.FreeCoTaskMem((IntPtr)extname_ptr);
                return returnValue;
            }
            /// <inheritdoc cref="ListenerfvDirect(ALCContext, ListenerPNameFV, float*)"/>
            public static unsafe void ListenerfvDirect(ALCContext context, ListenerPNameFV param, Span<float> values)
            {
                fixed (float* values_ptr = values)
                {
                    ListenerfvDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="ListenerfvDirect(ALCContext, ListenerPNameFV, float*)"/>
            public static unsafe void ListenerfvDirect(ALCContext context, ListenerPNameFV param, float[] values)
            {
                fixed (float* values_ptr = values)
                {
                    ListenerfvDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="ListenerfvDirect(ALCContext, ListenerPNameFV, float*)"/>
            public static unsafe void ListenerfvDirect(ALCContext context, ListenerPNameFV param, ref float values)
            {
                fixed (float* values_ptr = &values)
                {
                    ListenerfvDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="ListenerivDirect(ALCContext, ListenerPNameIV, int*)"/>
            public static unsafe void ListenerivDirect(ALCContext context, ListenerPNameIV param, Span<int> values)
            {
                fixed (int* values_ptr = values)
                {
                    ListenerivDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="ListenerivDirect(ALCContext, ListenerPNameIV, int*)"/>
            public static unsafe void ListenerivDirect(ALCContext context, ListenerPNameIV param, int[] values)
            {
                fixed (int* values_ptr = values)
                {
                    ListenerivDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="ListenerivDirect(ALCContext, ListenerPNameIV, int*)"/>
            public static unsafe void ListenerivDirect(ALCContext context, ListenerPNameIV param, ref int values)
            {
                fixed (int* values_ptr = &values)
                {
                    ListenerivDirect(context, param, values_ptr);
                }
            }
            /// <inheritdoc cref="ObjectLabelDirectEXT(ALCContext, ObjectType, uint, int, byte*)"/>
            public static unsafe void ObjectLabelDirectEXT(ALCContext context, ObjectType identifier, uint name, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                ObjectLabelDirectEXT(context, identifier, name, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <inheritdoc cref="ObjectLabelEXT(ObjectType, uint, int, byte*)"/>
            public static unsafe void ObjectLabelEXT(ObjectType identifier, uint name, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                ObjectLabelEXT(identifier, name, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <inheritdoc cref="PushDebugGroupDirectEXT(ALCContext, DebugSource, uint, int, byte*)"/>
            public static unsafe void PushDebugGroupDirectEXT(ALCContext context, DebugSource source, uint id, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                PushDebugGroupDirectEXT(context, source, id, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
            }
            /// <inheritdoc cref="PushDebugGroupEXT(DebugSource, uint, int, byte*)"/>
            public static unsafe void PushDebugGroupEXT(DebugSource source, uint id, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                PushDebugGroupEXT(source, id, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
            }
            /// <inheritdoc cref="RequestFoldbackStart(FoldbackMode, int, int, float*, delegate* unmanaged[Cdecl]{All, nuint, void})"/>
            public static unsafe void RequestFoldbackStart(FoldbackMode foldbackMode, int blockCount, int blockLength, Span<float> bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback)
            {
                fixed (float* bufferMemory_ptr = bufferMemory)
                {
                    RequestFoldbackStart(foldbackMode, blockCount, blockLength, bufferMemory_ptr, callback);
                }
            }
            /// <inheritdoc cref="RequestFoldbackStart(FoldbackMode, int, int, float*, delegate* unmanaged[Cdecl]{All, nuint, void})"/>
            public static unsafe void RequestFoldbackStart(FoldbackMode foldbackMode, int blockCount, int blockLength, float[] bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback)
            {
                fixed (float* bufferMemory_ptr = bufferMemory)
                {
                    RequestFoldbackStart(foldbackMode, blockCount, blockLength, bufferMemory_ptr, callback);
                }
            }
            /// <inheritdoc cref="RequestFoldbackStart(FoldbackMode, int, int, float*, delegate* unmanaged[Cdecl]{All, nuint, void})"/>
            public static unsafe void RequestFoldbackStart(FoldbackMode foldbackMode, int blockCount, int blockLength, ref float bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback)
            {
                fixed (float* bufferMemory_ptr = &bufferMemory)
                {
                    RequestFoldbackStart(foldbackMode, blockCount, blockLength, bufferMemory_ptr, callback);
                }
            }
            /// <inheritdoc cref="RequestFoldbackStartDirect(ALCContext, FoldbackMode, int, int, float*, delegate* unmanaged[Cdecl]{All, nuint, void})"/>
            public static unsafe void RequestFoldbackStartDirect(ALCContext context, FoldbackMode foldbackMode, int blockCount, int blockLength, Span<float> bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback)
            {
                fixed (float* bufferMemory_ptr = bufferMemory)
                {
                    RequestFoldbackStartDirect(context, foldbackMode, blockCount, blockLength, bufferMemory_ptr, callback);
                }
            }
            /// <inheritdoc cref="RequestFoldbackStartDirect(ALCContext, FoldbackMode, int, int, float*, delegate* unmanaged[Cdecl]{All, nuint, void})"/>
            public static unsafe void RequestFoldbackStartDirect(ALCContext context, FoldbackMode foldbackMode, int blockCount, int blockLength, float[] bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback)
            {
                fixed (float* bufferMemory_ptr = bufferMemory)
                {
                    RequestFoldbackStartDirect(context, foldbackMode, blockCount, blockLength, bufferMemory_ptr, callback);
                }
            }
            /// <inheritdoc cref="RequestFoldbackStartDirect(ALCContext, FoldbackMode, int, int, float*, delegate* unmanaged[Cdecl]{All, nuint, void})"/>
            public static unsafe void RequestFoldbackStartDirect(ALCContext context, FoldbackMode foldbackMode, int blockCount, int blockLength, ref float bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback)
            {
                fixed (float* bufferMemory_ptr = &bufferMemory)
                {
                    RequestFoldbackStartDirect(context, foldbackMode, blockCount, blockLength, bufferMemory_ptr, callback);
                }
            }
            /// <inheritdoc cref="SourceAddNotification(int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe ErrorCode SourceAddNotification(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, IntPtr userData)
            {
                ErrorCode returnValue;
                void* userData_vptr = (void*)userData;
                returnValue = SourceAddNotification(sid, notificationID, notifyProc, userData_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="SourceAddNotification(int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe ErrorCode SourceAddNotification<T1>(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, Span<T1> userData)
                where T1 : unmanaged
            {
                ErrorCode returnValue;
                fixed (void* userData_ptr = userData)
                {
                    returnValue = SourceAddNotification(sid, notificationID, notifyProc, userData_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SourceAddNotification(int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe ErrorCode SourceAddNotification<T1>(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, T1[] userData)
                where T1 : unmanaged
            {
                ErrorCode returnValue;
                fixed (void* userData_ptr = userData)
                {
                    returnValue = SourceAddNotification(sid, notificationID, notifyProc, userData_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SourceAddNotification(int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe ErrorCode SourceAddNotification<T1>(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, ref T1 userData)
                where T1 : unmanaged
            {
                ErrorCode returnValue;
                fixed (void* userData_ptr = &userData)
                {
                    returnValue = SourceAddNotification(sid, notificationID, notifyProc, userData_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SourceAddNotificationDirect(ALCContext, int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe ErrorCode SourceAddNotificationDirect(ALCContext context, int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, IntPtr userData)
            {
                ErrorCode returnValue;
                void* userData_vptr = (void*)userData;
                returnValue = SourceAddNotificationDirect(context, sid, notificationID, notifyProc, userData_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="SourceAddNotificationDirect(ALCContext, int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe ErrorCode SourceAddNotificationDirect<T1>(ALCContext context, int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, Span<T1> userData)
                where T1 : unmanaged
            {
                ErrorCode returnValue;
                fixed (void* userData_ptr = userData)
                {
                    returnValue = SourceAddNotificationDirect(context, sid, notificationID, notifyProc, userData_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SourceAddNotificationDirect(ALCContext, int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe ErrorCode SourceAddNotificationDirect<T1>(ALCContext context, int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, T1[] userData)
                where T1 : unmanaged
            {
                ErrorCode returnValue;
                fixed (void* userData_ptr = userData)
                {
                    returnValue = SourceAddNotificationDirect(context, sid, notificationID, notifyProc, userData_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SourceAddNotificationDirect(ALCContext, int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe ErrorCode SourceAddNotificationDirect<T1>(ALCContext context, int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, ref T1 userData)
                where T1 : unmanaged
            {
                ErrorCode returnValue;
                fixed (void* userData_ptr = &userData)
                {
                    returnValue = SourceAddNotificationDirect(context, sid, notificationID, notifyProc, userData_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SourcedvDirectSOFT(ALCContext, int, SourcePNameDV, double*)"/>
            public static unsafe void SourcedvDirectSOFT(ALCContext context, int source, SourcePNameDV param, ReadOnlySpan<double> values)
            {
                fixed (double* values_ptr = values)
                {
                    SourcedvDirectSOFT(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="SourcedvDirectSOFT(ALCContext, int, SourcePNameDV, double*)"/>
            public static unsafe void SourcedvDirectSOFT(ALCContext context, int source, SourcePNameDV param, double[] values)
            {
                fixed (double* values_ptr = values)
                {
                    SourcedvDirectSOFT(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="SourcedvDirectSOFT(ALCContext, int, SourcePNameDV, double*)"/>
            public static unsafe void SourcedvDirectSOFT(ALCContext context, int source, SourcePNameDV param, ref readonly double values)
            {
                fixed (double* values_ptr = &values)
                {
                    SourcedvDirectSOFT(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="SourcefvDirect(ALCContext, int, SourcePNameFV, float*)"/>
            public static unsafe void SourcefvDirect(ALCContext context, int source, SourcePNameFV param, ReadOnlySpan<float> value)
            {
                fixed (float* value_ptr = value)
                {
                    SourcefvDirect(context, source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="SourcefvDirect(ALCContext, int, SourcePNameFV, float*)"/>
            public static unsafe void SourcefvDirect(ALCContext context, int source, SourcePNameFV param, float[] value)
            {
                fixed (float* value_ptr = value)
                {
                    SourcefvDirect(context, source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="SourcefvDirect(ALCContext, int, SourcePNameFV, float*)"/>
            public static unsafe void SourcefvDirect(ALCContext context, int source, SourcePNameFV param, ref readonly float value)
            {
                fixed (float* value_ptr = &value)
                {
                    SourcefvDirect(context, source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="Sourcei64vDirectSOFT(ALCContext, int, SourcePNameI64V, long*)"/>
            public static unsafe void Sourcei64vDirectSOFT(ALCContext context, int source, SourcePNameI64V param, ReadOnlySpan<long> values)
            {
                fixed (long* values_ptr = values)
                {
                    Sourcei64vDirectSOFT(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="Sourcei64vDirectSOFT(ALCContext, int, SourcePNameI64V, long*)"/>
            public static unsafe void Sourcei64vDirectSOFT(ALCContext context, int source, SourcePNameI64V param, long[] values)
            {
                fixed (long* values_ptr = values)
                {
                    Sourcei64vDirectSOFT(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="Sourcei64vDirectSOFT(ALCContext, int, SourcePNameI64V, long*)"/>
            public static unsafe void Sourcei64vDirectSOFT(ALCContext context, int source, SourcePNameI64V param, ref readonly long values)
            {
                fixed (long* values_ptr = &values)
                {
                    Sourcei64vDirectSOFT(context, source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="SourceivDirect(ALCContext, int, SourcePNameIV, int*)"/>
            public static unsafe void SourceivDirect(ALCContext context, int source, SourcePNameIV param, ReadOnlySpan<int> value)
            {
                fixed (int* value_ptr = value)
                {
                    SourceivDirect(context, source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="SourceivDirect(ALCContext, int, SourcePNameIV, int*)"/>
            public static unsafe void SourceivDirect(ALCContext context, int source, SourcePNameIV param, int[] value)
            {
                fixed (int* value_ptr = value)
                {
                    SourceivDirect(context, source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="SourceivDirect(ALCContext, int, SourcePNameIV, int*)"/>
            public static unsafe void SourceivDirect(ALCContext context, int source, SourcePNameIV param, ref readonly int value)
            {
                fixed (int* value_ptr = &value)
                {
                    SourceivDirect(context, source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="SourcePausevDirect(ALCContext, int, int*)"/>
            public static unsafe void SourcePausevDirect(ALCContext context, int n, ReadOnlySpan<int> sources)
            {
                fixed (int* sources_ptr = sources)
                {
                    SourcePausevDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="SourcePausevDirect(ALCContext, int, int*)"/>
            public static unsafe void SourcePausevDirect(ALCContext context, int n, int[] sources)
            {
                fixed (int* sources_ptr = sources)
                {
                    SourcePausevDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="SourcePausevDirect(ALCContext, int, int*)"/>
            public static unsafe void SourcePausevDirect(ALCContext context, int n, ref readonly int sources)
            {
                fixed (int* sources_ptr = &sources)
                {
                    SourcePausevDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="SourcePlayAtTimevDirectSOFT(ALCContext, int, int*, long)"/>
            public static unsafe void SourcePlayAtTimevDirectSOFT(ALCContext context, int n, ReadOnlySpan<int> sources, long start_time)
            {
                fixed (int* sources_ptr = sources)
                {
                    SourcePlayAtTimevDirectSOFT(context, n, sources_ptr, start_time);
                }
            }
            /// <inheritdoc cref="SourcePlayAtTimevDirectSOFT(ALCContext, int, int*, long)"/>
            public static unsafe void SourcePlayAtTimevDirectSOFT(ALCContext context, int n, int[] sources, long start_time)
            {
                fixed (int* sources_ptr = sources)
                {
                    SourcePlayAtTimevDirectSOFT(context, n, sources_ptr, start_time);
                }
            }
            /// <inheritdoc cref="SourcePlayAtTimevDirectSOFT(ALCContext, int, int*, long)"/>
            public static unsafe void SourcePlayAtTimevDirectSOFT(ALCContext context, int n, ref readonly int sources, long start_time)
            {
                fixed (int* sources_ptr = &sources)
                {
                    SourcePlayAtTimevDirectSOFT(context, n, sources_ptr, start_time);
                }
            }
            /// <inheritdoc cref="SourcePlayvDirect(ALCContext, int, int*)"/>
            public static unsafe void SourcePlayvDirect(ALCContext context, int n, ReadOnlySpan<int> sources)
            {
                fixed (int* sources_ptr = sources)
                {
                    SourcePlayvDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="SourcePlayvDirect(ALCContext, int, int*)"/>
            public static unsafe void SourcePlayvDirect(ALCContext context, int n, int[] sources)
            {
                fixed (int* sources_ptr = sources)
                {
                    SourcePlayvDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="SourcePlayvDirect(ALCContext, int, int*)"/>
            public static unsafe void SourcePlayvDirect(ALCContext context, int n, ref readonly int sources)
            {
                fixed (int* sources_ptr = &sources)
                {
                    SourcePlayvDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="SourceQueueBuffersDirect(ALCContext, int, int, uint*)"/>
            public static unsafe void SourceQueueBuffersDirect(ALCContext context, int source, int nb, ReadOnlySpan<uint> buffers)
            {
                fixed (uint* buffers_ptr = buffers)
                {
                    SourceQueueBuffersDirect(context, source, nb, buffers_ptr);
                }
            }
            /// <inheritdoc cref="SourceQueueBuffersDirect(ALCContext, int, int, uint*)"/>
            public static unsafe void SourceQueueBuffersDirect(ALCContext context, int source, int nb, uint[] buffers)
            {
                fixed (uint* buffers_ptr = buffers)
                {
                    SourceQueueBuffersDirect(context, source, nb, buffers_ptr);
                }
            }
            /// <inheritdoc cref="SourceQueueBuffersDirect(ALCContext, int, int, uint*)"/>
            public static unsafe void SourceQueueBuffersDirect(ALCContext context, int source, int nb, ref readonly uint buffers)
            {
                fixed (uint* buffers_ptr = &buffers)
                {
                    SourceQueueBuffersDirect(context, source, nb, buffers_ptr);
                }
            }
            /// <inheritdoc cref="SourceRemoveNotification(int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe void SourceRemoveNotification(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, IntPtr userData)
            {
                void* userData_vptr = (void*)userData;
                SourceRemoveNotification(sid, notificationID, notifyProc, userData_vptr);
            }
            /// <inheritdoc cref="SourceRemoveNotification(int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe void SourceRemoveNotification<T1>(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, Span<T1> userData)
                where T1 : unmanaged
            {
                fixed (void* userData_ptr = userData)
                {
                    SourceRemoveNotification(sid, notificationID, notifyProc, userData_ptr);
                }
            }
            /// <inheritdoc cref="SourceRemoveNotification(int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe void SourceRemoveNotification<T1>(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, T1[] userData)
                where T1 : unmanaged
            {
                fixed (void* userData_ptr = userData)
                {
                    SourceRemoveNotification(sid, notificationID, notifyProc, userData_ptr);
                }
            }
            /// <inheritdoc cref="SourceRemoveNotification(int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe void SourceRemoveNotification<T1>(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, ref T1 userData)
                where T1 : unmanaged
            {
                fixed (void* userData_ptr = &userData)
                {
                    SourceRemoveNotification(sid, notificationID, notifyProc, userData_ptr);
                }
            }
            /// <inheritdoc cref="SourceRemoveNotificationDirect(ALCContext, int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe void SourceRemoveNotificationDirect(ALCContext context, int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, IntPtr userData)
            {
                void* userData_vptr = (void*)userData;
                SourceRemoveNotificationDirect(context, sid, notificationID, notifyProc, userData_vptr);
            }
            /// <inheritdoc cref="SourceRemoveNotificationDirect(ALCContext, int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe void SourceRemoveNotificationDirect<T1>(ALCContext context, int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, Span<T1> userData)
                where T1 : unmanaged
            {
                fixed (void* userData_ptr = userData)
                {
                    SourceRemoveNotificationDirect(context, sid, notificationID, notifyProc, userData_ptr);
                }
            }
            /// <inheritdoc cref="SourceRemoveNotificationDirect(ALCContext, int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe void SourceRemoveNotificationDirect<T1>(ALCContext context, int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, T1[] userData)
                where T1 : unmanaged
            {
                fixed (void* userData_ptr = userData)
                {
                    SourceRemoveNotificationDirect(context, sid, notificationID, notifyProc, userData_ptr);
                }
            }
            /// <inheritdoc cref="SourceRemoveNotificationDirect(ALCContext, int, uint, delegate* unmanaged[Cdecl]{uint, uint, void*, void}, void*)"/>
            public static unsafe void SourceRemoveNotificationDirect<T1>(ALCContext context, int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, ref T1 userData)
                where T1 : unmanaged
            {
                fixed (void* userData_ptr = &userData)
                {
                    SourceRemoveNotificationDirect(context, sid, notificationID, notifyProc, userData_ptr);
                }
            }
            /// <inheritdoc cref="SourceRewindvDirect(ALCContext, int, int*)"/>
            public static unsafe void SourceRewindvDirect(ALCContext context, int n, ReadOnlySpan<int> sources)
            {
                fixed (int* sources_ptr = sources)
                {
                    SourceRewindvDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="SourceRewindvDirect(ALCContext, int, int*)"/>
            public static unsafe void SourceRewindvDirect(ALCContext context, int n, int[] sources)
            {
                fixed (int* sources_ptr = sources)
                {
                    SourceRewindvDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="SourceRewindvDirect(ALCContext, int, int*)"/>
            public static unsafe void SourceRewindvDirect(ALCContext context, int n, ref readonly int sources)
            {
                fixed (int* sources_ptr = &sources)
                {
                    SourceRewindvDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="SourceStopvDirect(ALCContext, int, int*)"/>
            public static unsafe void SourceStopvDirect(ALCContext context, int n, ReadOnlySpan<int> sources)
            {
                fixed (int* sources_ptr = sources)
                {
                    SourceStopvDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="SourceStopvDirect(ALCContext, int, int*)"/>
            public static unsafe void SourceStopvDirect(ALCContext context, int n, int[] sources)
            {
                fixed (int* sources_ptr = sources)
                {
                    SourceStopvDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="SourceStopvDirect(ALCContext, int, int*)"/>
            public static unsafe void SourceStopvDirect(ALCContext context, int n, ref readonly int sources)
            {
                fixed (int* sources_ptr = &sources)
                {
                    SourceStopvDirect(context, n, sources_ptr);
                }
            }
            /// <inheritdoc cref="SourceUnqueueBuffersDirect(ALCContext, int, int, int*)"/>
            public static unsafe void SourceUnqueueBuffersDirect(ALCContext context, int source, int nb, Span<int> buffer)
            {
                fixed (int* buffer_ptr = buffer)
                {
                    SourceUnqueueBuffersDirect(context, source, nb, buffer_ptr);
                }
            }
            /// <inheritdoc cref="SourceUnqueueBuffersDirect(ALCContext, int, int, int*)"/>
            public static unsafe void SourceUnqueueBuffersDirect(ALCContext context, int source, int nb, int[] buffer)
            {
                fixed (int* buffer_ptr = buffer)
                {
                    SourceUnqueueBuffersDirect(context, source, nb, buffer_ptr);
                }
            }
            /// <inheritdoc cref="SourceUnqueueBuffersDirect(ALCContext, int, int, int*)"/>
            public static unsafe void SourceUnqueueBuffersDirect(ALCContext context, int source, int nb, ref int buffer)
            {
                fixed (int* buffer_ptr = &buffer)
                {
                    SourceUnqueueBuffersDirect(context, source, nb, buffer_ptr);
                }
            }
        }
        public static unsafe partial class LOKI
        {
        }
        public static unsafe partial class SOFT
        {
            /// <inheritdoc cref="BufferCallbackSOFT(int, Format, int, delegate* unmanaged[Cdecl]{void*, void*, nuint, nuint}, void*)"/>
            public static unsafe void BufferCallbackSOFT(int buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, IntPtr userptr)
            {
                void* userptr_vptr = (void*)userptr;
                BufferCallbackSOFT(buffer, format, freq, callback, userptr_vptr);
            }
            /// <inheritdoc cref="BufferCallbackSOFT(int, Format, int, delegate* unmanaged[Cdecl]{void*, void*, nuint, nuint}, void*)"/>
            public static unsafe void BufferCallbackSOFT<T1>(int buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, Span<T1> userptr)
                where T1 : unmanaged
            {
                fixed (void* userptr_ptr = userptr)
                {
                    BufferCallbackSOFT(buffer, format, freq, callback, userptr_ptr);
                }
            }
            /// <inheritdoc cref="BufferCallbackSOFT(int, Format, int, delegate* unmanaged[Cdecl]{void*, void*, nuint, nuint}, void*)"/>
            public static unsafe void BufferCallbackSOFT<T1>(int buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, T1[] userptr)
                where T1 : unmanaged
            {
                fixed (void* userptr_ptr = userptr)
                {
                    BufferCallbackSOFT(buffer, format, freq, callback, userptr_ptr);
                }
            }
            /// <inheritdoc cref="BufferCallbackSOFT(int, Format, int, delegate* unmanaged[Cdecl]{void*, void*, nuint, nuint}, void*)"/>
            public static unsafe void BufferCallbackSOFT<T1>(int buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, ref T1 userptr)
                where T1 : unmanaged
            {
                fixed (void* userptr_ptr = &userptr)
                {
                    BufferCallbackSOFT(buffer, format, freq, callback, userptr_ptr);
                }
            }
            /// <inheritdoc cref="BufferSamplesSOFT(int, uint, InternalFormat, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSamplesSOFT(int buffer, uint samplerate, InternalFormat internalformat, int samples, Channels channels, SampleType type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                BufferSamplesSOFT(buffer, samplerate, internalformat, samples, channels, type, data_vptr);
            }
            /// <inheritdoc cref="BufferSamplesSOFT(int, uint, InternalFormat, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSamplesSOFT<T1>(int buffer, uint samplerate, InternalFormat internalformat, int samples, Channels channels, SampleType type, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSamplesSOFT(buffer, samplerate, internalformat, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSamplesSOFT(int, uint, InternalFormat, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSamplesSOFT<T1>(int buffer, uint samplerate, InternalFormat internalformat, int samples, Channels channels, SampleType type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSamplesSOFT(buffer, samplerate, internalformat, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSamplesSOFT(int, uint, InternalFormat, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSamplesSOFT<T1>(int buffer, uint samplerate, InternalFormat internalformat, int samples, Channels channels, SampleType type, ref readonly T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    BufferSamplesSOFT(buffer, samplerate, internalformat, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSubDataSOFT(int, Format, void*, int, int)"/>
            public static unsafe void BufferSubDataSOFT(int buffer, Format format, IntPtr data, int offset, int length)
            {
                void* data_vptr = (void*)data;
                BufferSubDataSOFT(buffer, format, data_vptr, offset, length);
            }
            /// <inheritdoc cref="BufferSubDataSOFT(int, Format, void*, int, int)"/>
            public static unsafe void BufferSubDataSOFT<T1>(int buffer, Format format, ReadOnlySpan<T1> data, int offset, int length)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubDataSOFT(buffer, format, data_ptr, offset, length);
                }
            }
            /// <inheritdoc cref="BufferSubDataSOFT(int, Format, void*, int, int)"/>
            public static unsafe void BufferSubDataSOFT<T1>(int buffer, Format format, T1[] data, int offset, int length)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubDataSOFT(buffer, format, data_ptr, offset, length);
                }
            }
            /// <inheritdoc cref="BufferSubDataSOFT(int, Format, void*, int, int)"/>
            public static unsafe void BufferSubDataSOFT<T1>(int buffer, Format format, ref readonly T1 data, int offset, int length)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    BufferSubDataSOFT(buffer, format, data_ptr, offset, length);
                }
            }
            /// <inheritdoc cref="BufferSubSamplesSOFT(int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSubSamplesSOFT(int buffer, int offset, int samples, Channels channels, SampleType type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                BufferSubSamplesSOFT(buffer, offset, samples, channels, type, data_vptr);
            }
            /// <inheritdoc cref="BufferSubSamplesSOFT(int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSubSamplesSOFT<T1>(int buffer, int offset, int samples, Channels channels, SampleType type, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSubSamplesSOFT(int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSubSamplesSOFT<T1>(int buffer, int offset, int samples, Channels channels, SampleType type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSubSamplesSOFT(int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSubSamplesSOFT<T1>(int buffer, int offset, int samples, Channels channels, SampleType type, ref readonly T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    BufferSubSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="EventCallbackSOFT(delegate* unmanaged[Cdecl]{All, uint, uint, nuint, byte*, void*, void}, void*)"/>
            public static unsafe void EventCallbackSOFT(delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, IntPtr userParam)
            {
                void* userParam_vptr = (void*)userParam;
                EventCallbackSOFT(callback, userParam_vptr);
            }
            /// <inheritdoc cref="EventCallbackSOFT(delegate* unmanaged[Cdecl]{All, uint, uint, nuint, byte*, void*, void}, void*)"/>
            public static unsafe void EventCallbackSOFT<T1>(delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, Span<T1> userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = userParam)
                {
                    EventCallbackSOFT(callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="EventCallbackSOFT(delegate* unmanaged[Cdecl]{All, uint, uint, nuint, byte*, void*, void}, void*)"/>
            public static unsafe void EventCallbackSOFT<T1>(delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, T1[] userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = userParam)
                {
                    EventCallbackSOFT(callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="EventCallbackSOFT(delegate* unmanaged[Cdecl]{All, uint, uint, nuint, byte*, void*, void}, void*)"/>
            public static unsafe void EventCallbackSOFT<T1>(delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, ref T1 userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = &userParam)
                {
                    EventCallbackSOFT(callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="EventControlSOFT(int, EventType*, bool)"/>
            public static unsafe void EventControlSOFT(int count, ReadOnlySpan<EventType> types, bool enable)
            {
                fixed (EventType* types_ptr = types)
                {
                    EventControlSOFT(count, types_ptr, enable);
                }
            }
            /// <inheritdoc cref="EventControlSOFT(int, EventType*, bool)"/>
            public static unsafe void EventControlSOFT(int count, EventType[] types, bool enable)
            {
                fixed (EventType* types_ptr = types)
                {
                    EventControlSOFT(count, types_ptr, enable);
                }
            }
            /// <inheritdoc cref="EventControlSOFT(int, EventType*, bool)"/>
            public static unsafe void EventControlSOFT(int count, ref readonly EventType types, bool enable)
            {
                fixed (EventType* types_ptr = &types)
                {
                    EventControlSOFT(count, types_ptr, enable);
                }
            }
            /// <inheritdoc cref="GetBufferSamplesSOFT(int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void GetBufferSamplesSOFT(int buffer, int offset, int samples, Channels channels, SampleType type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                GetBufferSamplesSOFT(buffer, offset, samples, channels, type, data_vptr);
            }
            /// <inheritdoc cref="GetBufferSamplesSOFT(int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void GetBufferSamplesSOFT<T1>(int buffer, int offset, int samples, Channels channels, SampleType type, Span<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    GetBufferSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferSamplesSOFT(int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void GetBufferSamplesSOFT<T1>(int buffer, int offset, int samples, Channels channels, SampleType type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    GetBufferSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferSamplesSOFT(int, int, int, Channels, SampleType, void*)"/>
            public static unsafe void GetBufferSamplesSOFT<T1>(int buffer, int offset, int samples, Channels channels, SampleType type, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    GetBufferSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="GetSource3dSOFT(int, SourceGetPName3D, double*, double*, double*)"/>
            public static unsafe double GetSource3dSOFT(int source, SourceGetPName3D param, out double value1, out double value2)
            {
                double value3;
                double* value3_ptr = &value3;
                fixed (double* value1_ptr = &value1)
                fixed (double* value2_ptr = &value2)
                {
                    GetSource3dSOFT(source, param, value1_ptr, value2_ptr, value3_ptr);
                }
                return value3;
            }
            /// <inheritdoc cref="GetSource3dSOFT(int, SourceGetPName3D, double*, double*, double*)"/>
            public static unsafe void GetSource3dSOFT(int source, SourceGetPName3D param, out double value1, out double value2, out double value3)
            {
                fixed (double* value1_ptr = &value1)
                fixed (double* value2_ptr = &value2)
                fixed (double* value3_ptr = &value3)
                {
                    GetSource3dSOFT(source, param, value1_ptr, value2_ptr, value3_ptr);
                }
            }
            /// <inheritdoc cref="GetSource3i64SOFT(int, SourceGetPName3I64, long*, long*, long*)"/>
            public static unsafe long GetSource3i64SOFT(int source, SourceGetPName3I64 param, out long value1, out long value2)
            {
                long value3;
                long* value3_ptr = &value3;
                fixed (long* value1_ptr = &value1)
                fixed (long* value2_ptr = &value2)
                {
                    GetSource3i64SOFT(source, param, value1_ptr, value2_ptr, value3_ptr);
                }
                return value3;
            }
            /// <inheritdoc cref="GetSource3i64SOFT(int, SourceGetPName3I64, long*, long*, long*)"/>
            public static unsafe void GetSource3i64SOFT(int source, SourceGetPName3I64 param, out long value1, out long value2, out long value3)
            {
                fixed (long* value1_ptr = &value1)
                fixed (long* value2_ptr = &value2)
                fixed (long* value3_ptr = &value3)
                {
                    GetSource3i64SOFT(source, param, value1_ptr, value2_ptr, value3_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedSOFT(int, SourceGetPNameD, double*)"/>
            public static unsafe double GetSourcedSOFT(int source, SourceGetPNameD param)
            {
                double value;
                double* value_ptr = &value;
                {
                    GetSourcedSOFT(source, param, value_ptr);
                }
                return value;
            }
            /// <inheritdoc cref="GetSourcedSOFT(int, SourceGetPNameD, double*)"/>
            public static unsafe void GetSourcedSOFT(int source, SourceGetPNameD param, out double value)
            {
                fixed (double* value_ptr = &value)
                {
                    GetSourcedSOFT(source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedvSOFT(int, SourceGetPNameDV, double*)"/>
            public static unsafe void GetSourcedvSOFT(int source, SourceGetPNameDV param, Span<double> values)
            {
                fixed (double* values_ptr = values)
                {
                    GetSourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedvSOFT(int, SourceGetPNameDV, double*)"/>
            public static unsafe void GetSourcedvSOFT(int source, SourceGetPNameDV param, double[] values)
            {
                fixed (double* values_ptr = values)
                {
                    GetSourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedvSOFT(int, SourceGetPNameDV, double*)"/>
            public static unsafe void GetSourcedvSOFT(int source, SourceGetPNameDV param, ref double values)
            {
                fixed (double* values_ptr = &values)
                {
                    GetSourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64SOFT(int, SourceGetPNameI64, long*)"/>
            public static unsafe long GetSourcei64SOFT(int source, SourceGetPNameI64 param)
            {
                long value;
                long* value_ptr = &value;
                {
                    GetSourcei64SOFT(source, param, value_ptr);
                }
                return value;
            }
            /// <inheritdoc cref="GetSourcei64SOFT(int, SourceGetPNameI64, long*)"/>
            public static unsafe void GetSourcei64SOFT(int source, SourceGetPNameI64 param, out long value)
            {
                fixed (long* value_ptr = &value)
                {
                    GetSourcei64SOFT(source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64vSOFT(int, SourceGetPNameI64V, long*)"/>
            public static unsafe void GetSourcei64vSOFT(int source, SourceGetPNameI64V param, Span<long> values)
            {
                fixed (long* values_ptr = values)
                {
                    GetSourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64vSOFT(int, SourceGetPNameI64V, long*)"/>
            public static unsafe void GetSourcei64vSOFT(int source, SourceGetPNameI64V param, long[] values)
            {
                fixed (long* values_ptr = values)
                {
                    GetSourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64vSOFT(int, SourceGetPNameI64V, long*)"/>
            public static unsafe void GetSourcei64vSOFT(int source, SourceGetPNameI64V param, ref long values)
            {
                fixed (long* values_ptr = &values)
                {
                    GetSourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetStringiSOFT_(IndexedStringName, int)"/>
            public static unsafe string? GetStringiSOFT(IndexedStringName pname, int index)
            {
                string? returnValue_str;
                byte* returnValue;
                returnValue = GetStringiSOFT_(pname, index);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="SourcedvSOFT(int, SourcePNameDV, double*)"/>
            public static unsafe void SourcedvSOFT(int source, SourcePNameDV param, ReadOnlySpan<double> values)
            {
                fixed (double* values_ptr = values)
                {
                    SourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="SourcedvSOFT(int, SourcePNameDV, double*)"/>
            public static unsafe void SourcedvSOFT(int source, SourcePNameDV param, double[] values)
            {
                fixed (double* values_ptr = values)
                {
                    SourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="SourcedvSOFT(int, SourcePNameDV, double*)"/>
            public static unsafe void SourcedvSOFT(int source, SourcePNameDV param, ref readonly double values)
            {
                fixed (double* values_ptr = &values)
                {
                    SourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="Sourcei64vSOFT(int, SourcePNameI64V, long*)"/>
            public static unsafe void Sourcei64vSOFT(int source, SourcePNameI64V param, ReadOnlySpan<long> values)
            {
                fixed (long* values_ptr = values)
                {
                    Sourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="Sourcei64vSOFT(int, SourcePNameI64V, long*)"/>
            public static unsafe void Sourcei64vSOFT(int source, SourcePNameI64V param, long[] values)
            {
                fixed (long* values_ptr = values)
                {
                    Sourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="Sourcei64vSOFT(int, SourcePNameI64V, long*)"/>
            public static unsafe void Sourcei64vSOFT(int source, SourcePNameI64V param, ref readonly long values)
            {
                fixed (long* values_ptr = &values)
                {
                    Sourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="SourcePlayAtTimevSOFT(int, int*, long)"/>
            public static unsafe void SourcePlayAtTimevSOFT(int n, ReadOnlySpan<int> sources, long start_time)
            {
                fixed (int* sources_ptr = sources)
                {
                    SourcePlayAtTimevSOFT(n, sources_ptr, start_time);
                }
            }
            /// <inheritdoc cref="SourcePlayAtTimevSOFT(int, int*, long)"/>
            public static unsafe void SourcePlayAtTimevSOFT(int n, int[] sources, long start_time)
            {
                fixed (int* sources_ptr = sources)
                {
                    SourcePlayAtTimevSOFT(n, sources_ptr, start_time);
                }
            }
            /// <inheritdoc cref="SourcePlayAtTimevSOFT(int, int*, long)"/>
            public static unsafe void SourcePlayAtTimevSOFT(int n, ref readonly int sources, long start_time)
            {
                fixed (int* sources_ptr = &sources)
                {
                    SourcePlayAtTimevSOFT(n, sources_ptr, start_time);
                }
            }
        }
    }
}

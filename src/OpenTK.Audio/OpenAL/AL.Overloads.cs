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
            /// <inheritdoc cref="DebugMessageCallbackEXT(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int>, void*)"/>
            public static unsafe void DebugMessageCallbackEXT(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, IntPtr userParam)
            {
                void* userParam_vptr = (void*)userParam;
                DebugMessageCallbackEXT(callback, userParam_vptr);
            }
            /// <inheritdoc cref="DebugMessageCallbackEXT(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int>, void*)"/>
            public static unsafe void DebugMessageCallbackEXT<T1>(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, Span<T1> userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = userParam)
                {
                    DebugMessageCallbackEXT(callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="DebugMessageCallbackEXT(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int>, void*)"/>
            public static unsafe void DebugMessageCallbackEXT<T1>(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, T1[] userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = userParam)
                {
                    DebugMessageCallbackEXT(callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="DebugMessageCallbackEXT(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int>, void*)"/>
            public static unsafe void DebugMessageCallbackEXT<T1>(delegate* unmanaged[Cdecl]<All, All, uint, All, nuint, byte*, void*, int> callback, ref T1 userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = &userParam)
                {
                    DebugMessageCallbackEXT(callback, userParam_ptr);
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
            /// <inheritdoc cref="ObjectLabelEXT(ObjectType, uint, int, byte*)"/>
            public static unsafe void ObjectLabelEXT(ObjectType identifier, uint name, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                ObjectLabelEXT(identifier, name, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <inheritdoc cref="PushDebugGroupEXT(DebugSource, uint, int, byte*)"/>
            public static unsafe void PushDebugGroupEXT(DebugSource source, uint id, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                PushDebugGroupEXT(source, id, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
            }
            /// <inheritdoc cref="RequestFoldbackStart(FoldbackMode, int, int, float*, delegate* unmanaged[Cdecl]<All, nuint, void>)"/>
            public static unsafe void RequestFoldbackStart(FoldbackMode foldbackMode, int blockCount, int blockLength, Span<float> bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback)
            {
                fixed (float* bufferMemory_ptr = bufferMemory)
                {
                    RequestFoldbackStart(foldbackMode, blockCount, blockLength, bufferMemory_ptr, callback);
                }
            }
            /// <inheritdoc cref="RequestFoldbackStart(FoldbackMode, int, int, float*, delegate* unmanaged[Cdecl]<All, nuint, void>)"/>
            public static unsafe void RequestFoldbackStart(FoldbackMode foldbackMode, int blockCount, int blockLength, float[] bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback)
            {
                fixed (float* bufferMemory_ptr = bufferMemory)
                {
                    RequestFoldbackStart(foldbackMode, blockCount, blockLength, bufferMemory_ptr, callback);
                }
            }
            /// <inheritdoc cref="RequestFoldbackStart(FoldbackMode, int, int, float*, delegate* unmanaged[Cdecl]<All, nuint, void>)"/>
            public static unsafe void RequestFoldbackStart(FoldbackMode foldbackMode, int blockCount, int blockLength, ref float bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback)
            {
                fixed (float* bufferMemory_ptr = &bufferMemory)
                {
                    RequestFoldbackStart(foldbackMode, blockCount, blockLength, bufferMemory_ptr, callback);
                }
            }
            /// <inheritdoc cref="SourceAddNotification(int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe ErrorCode SourceAddNotification(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, IntPtr userData)
            {
                ErrorCode returnValue;
                void* userData_vptr = (void*)userData;
                returnValue = SourceAddNotification(sid, notificationID, notifyProc, userData_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="SourceAddNotification(int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
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
            /// <inheritdoc cref="SourceAddNotification(int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
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
            /// <inheritdoc cref="SourceAddNotification(int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
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
            /// <inheritdoc cref="SourceRemoveNotification(int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe void SourceRemoveNotification(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, IntPtr userData)
            {
                void* userData_vptr = (void*)userData;
                SourceRemoveNotification(sid, notificationID, notifyProc, userData_vptr);
            }
            /// <inheritdoc cref="SourceRemoveNotification(int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe void SourceRemoveNotification<T1>(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, Span<T1> userData)
                where T1 : unmanaged
            {
                fixed (void* userData_ptr = userData)
                {
                    SourceRemoveNotification(sid, notificationID, notifyProc, userData_ptr);
                }
            }
            /// <inheritdoc cref="SourceRemoveNotification(int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe void SourceRemoveNotification<T1>(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, T1[] userData)
                where T1 : unmanaged
            {
                fixed (void* userData_ptr = userData)
                {
                    SourceRemoveNotification(sid, notificationID, notifyProc, userData_ptr);
                }
            }
            /// <inheritdoc cref="SourceRemoveNotification(int, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe void SourceRemoveNotification<T1>(int sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, ref T1 userData)
                where T1 : unmanaged
            {
                fixed (void* userData_ptr = &userData)
                {
                    SourceRemoveNotification(sid, notificationID, notifyProc, userData_ptr);
                }
            }
        }
        public static unsafe partial class LOKI
        {
        }
        public static unsafe partial class SOFT
        {
            /// <inheritdoc cref="BufferCallbackSOFT(int, Format, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*)"/>
            public static unsafe void BufferCallbackSOFT(int buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, IntPtr userptr)
            {
                void* userptr_vptr = (void*)userptr;
                BufferCallbackSOFT(buffer, format, freq, callback, userptr_vptr);
            }
            /// <inheritdoc cref="BufferCallbackSOFT(int, Format, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*)"/>
            public static unsafe void BufferCallbackSOFT<T1>(int buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, Span<T1> userptr)
                where T1 : unmanaged
            {
                fixed (void* userptr_ptr = userptr)
                {
                    BufferCallbackSOFT(buffer, format, freq, callback, userptr_ptr);
                }
            }
            /// <inheritdoc cref="BufferCallbackSOFT(int, Format, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*)"/>
            public static unsafe void BufferCallbackSOFT<T1>(int buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, T1[] userptr)
                where T1 : unmanaged
            {
                fixed (void* userptr_ptr = userptr)
                {
                    BufferCallbackSOFT(buffer, format, freq, callback, userptr_ptr);
                }
            }
            /// <inheritdoc cref="BufferCallbackSOFT(int, Format, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*)"/>
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
            /// <inheritdoc cref="EventCallbackSOFT(delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void>, void*)"/>
            public static unsafe void EventCallbackSOFT(delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, IntPtr userParam)
            {
                void* userParam_vptr = (void*)userParam;
                EventCallbackSOFT(callback, userParam_vptr);
            }
            /// <inheritdoc cref="EventCallbackSOFT(delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void>, void*)"/>
            public static unsafe void EventCallbackSOFT<T1>(delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, Span<T1> userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = userParam)
                {
                    EventCallbackSOFT(callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="EventCallbackSOFT(delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void>, void*)"/>
            public static unsafe void EventCallbackSOFT<T1>(delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void> callback, T1[] userParam)
                where T1 : unmanaged
            {
                fixed (void* userParam_ptr = userParam)
                {
                    EventCallbackSOFT(callback, userParam_ptr);
                }
            }
            /// <inheritdoc cref="EventCallbackSOFT(delegate* unmanaged[Cdecl]<All, uint, uint, nuint, byte*, void*, void>, void*)"/>
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

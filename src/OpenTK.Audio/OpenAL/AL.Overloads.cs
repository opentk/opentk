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
        /// <inheritdoc cref="BufferData(uint, Format, void*, int, int)"/>
        public static unsafe void BufferData(uint buffer, Format format, IntPtr data, int size, int samplerate)
        {
            void* data_vptr = (void*)data;
            BufferData(buffer, format, data_vptr, size, samplerate);
        }
        /// <inheritdoc cref="BufferData(uint, Format, void*, int, int)"/>
        public static unsafe void BufferData<T1>(uint buffer, Format format, ReadOnlySpan<T1> data, int size, int samplerate)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = data)
            {
                BufferData(buffer, format, data_ptr, size, samplerate);
            }
        }
        /// <inheritdoc cref="BufferData(uint, Format, void*, int, int)"/>
        public static unsafe void BufferData<T1>(uint buffer, Format format, T1[] data, int size, int samplerate)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = data)
            {
                BufferData(buffer, format, data_ptr, size, samplerate);
            }
        }
        /// <inheritdoc cref="BufferData(uint, Format, void*, int, int)"/>
        public static unsafe void BufferData<T1>(uint buffer, Format format, ref readonly T1 data, int size, int samplerate)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                BufferData(buffer, format, data_ptr, size, samplerate);
            }
        }
        /// <inheritdoc cref="Bufferfv(uint, BufferPNameFV, float*)"/>
        public static unsafe void Bufferfv(uint buffer, BufferPNameFV param, ReadOnlySpan<float> value)
        {
            fixed (float* value_ptr = value)
            {
                Bufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Bufferfv(uint, BufferPNameFV, float*)"/>
        public static unsafe void Bufferfv(uint buffer, BufferPNameFV param, float[] value)
        {
            fixed (float* value_ptr = value)
            {
                Bufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Bufferfv(uint, BufferPNameFV, float*)"/>
        public static unsafe void Bufferfv(uint buffer, BufferPNameFV param, ref readonly float value)
        {
            fixed (float* value_ptr = &value)
            {
                Bufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Bufferiv(uint, BufferPNameIV, int*)"/>
        public static unsafe void Bufferiv(uint buffer, BufferPNameIV param, ReadOnlySpan<int> value)
        {
            fixed (int* value_ptr = value)
            {
                Bufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Bufferiv(uint, BufferPNameIV, int*)"/>
        public static unsafe void Bufferiv(uint buffer, BufferPNameIV param, int[] value)
        {
            fixed (int* value_ptr = value)
            {
                Bufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Bufferiv(uint, BufferPNameIV, int*)"/>
        public static unsafe void Bufferiv(uint buffer, BufferPNameIV param, ref readonly int value)
        {
            fixed (int* value_ptr = &value)
            {
                Bufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="DeleteBuffers(int, uint*)"/>
        public static unsafe void DeleteBuffer(uint buffer)
        {
            int n = 1;
            uint* buffers_handle = &buffer;
            DeleteBuffers(n, buffers_handle);
        }
        /// <inheritdoc cref="DeleteBuffers(int, uint*)"/>
        public static unsafe void DeleteBuffers(int n, ReadOnlySpan<uint> buffers)
        {
            fixed (uint* buffers_ptr = buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteBuffers(int, uint*)"/>
        public static unsafe void DeleteBuffers(int n, uint[] buffers)
        {
            fixed (uint* buffers_ptr = buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteBuffers(int, uint*)"/>
        public static unsafe void DeleteBuffers(int n, ref readonly uint buffers)
        {
            fixed (uint* buffers_ptr = &buffers)
            {
                DeleteBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="DeleteSources(int, uint*)"/>
        public static unsafe void DeleteSource(uint source)
        {
            int n = 1;
            uint* sources_handle = &source;
            DeleteSources(n, sources_handle);
        }
        /// <inheritdoc cref="DeleteSources(int, uint*)"/>
        public static unsafe void DeleteSources(int n, ReadOnlySpan<uint> sources)
        {
            fixed (uint* sources_ptr = sources)
            {
                DeleteSources(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="DeleteSources(int, uint*)"/>
        public static unsafe void DeleteSources(int n, uint[] sources)
        {
            fixed (uint* sources_ptr = sources)
            {
                DeleteSources(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="DeleteSources(int, uint*)"/>
        public static unsafe void DeleteSources(int n, ref readonly uint sources)
        {
            fixed (uint* sources_ptr = &sources)
            {
                DeleteSources(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="GenBuffers(int, uint*)"/>
        public static unsafe uint GenBuffer()
        {
            uint buffer;
            int n = 1;
            Unsafe.SkipInit(out buffer);
            uint* buffers_handle = &buffer;
            GenBuffers(n, buffers_handle);
            return buffer;
        }
        /// <inheritdoc cref="GenBuffers(int, uint*)"/>
        public static unsafe void GenBuffer(out uint buffer)
        {
            int n = 1;
            Unsafe.SkipInit(out buffer);
            fixed(uint* buffers_handle = &buffer)
            {
                GenBuffers(n, buffers_handle);
            }
        }
        /// <inheritdoc cref="GenBuffers(int, uint*)"/>
        public static unsafe void GenBuffers(int n, Span<uint> buffers)
        {
            fixed (uint* buffers_ptr = buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="GenBuffers(int, uint*)"/>
        public static unsafe void GenBuffers(int n, uint[] buffers)
        {
            fixed (uint* buffers_ptr = buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="GenBuffers(int, uint*)"/>
        public static unsafe void GenBuffers(int n, ref uint buffers)
        {
            fixed (uint* buffers_ptr = &buffers)
            {
                GenBuffers(n, buffers_ptr);
            }
        }
        /// <inheritdoc cref="GenSources(int, uint*)"/>
        public static unsafe uint GenSource()
        {
            uint source;
            int n = 1;
            Unsafe.SkipInit(out source);
            uint* sources_handle = &source;
            GenSources(n, sources_handle);
            return source;
        }
        /// <inheritdoc cref="GenSources(int, uint*)"/>
        public static unsafe void GenSource(out uint source)
        {
            int n = 1;
            Unsafe.SkipInit(out source);
            fixed(uint* sources_handle = &source)
            {
                GenSources(n, sources_handle);
            }
        }
        /// <inheritdoc cref="GenSources(int, uint*)"/>
        public static unsafe void GenSources(int n, Span<uint> sources)
        {
            fixed (uint* sources_ptr = sources)
            {
                GenSources(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="GenSources(int, uint*)"/>
        public static unsafe void GenSources(int n, uint[] sources)
        {
            fixed (uint* sources_ptr = sources)
            {
                GenSources(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="GenSources(int, uint*)"/>
        public static unsafe void GenSources(int n, ref uint sources)
        {
            fixed (uint* sources_ptr = &sources)
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
        /// <inheritdoc cref="GetBuffer3f(uint, BufferGetPName3F, float*, float*, float*)"/>
        public static unsafe float GetBuffer3f(uint buffer, BufferGetPName3F param, out float value1, out float value2)
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
        /// <inheritdoc cref="GetBuffer3f(uint, BufferGetPName3F, float*, float*, float*)"/>
        public static unsafe void GetBuffer3f(uint buffer, BufferGetPName3F param, out float value1, out float value2, out float value3)
        {
            fixed (float* value1_ptr = &value1)
            fixed (float* value2_ptr = &value2)
            fixed (float* value3_ptr = &value3)
            {
                GetBuffer3f(buffer, param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetBuffer3i(uint, BufferGetPName3I, int*, int*, int*)"/>
        public static unsafe int GetBuffer3i(uint buffer, BufferGetPName3I param, out int value1, out int value2)
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
        /// <inheritdoc cref="GetBuffer3i(uint, BufferGetPName3I, int*, int*, int*)"/>
        public static unsafe void GetBuffer3i(uint buffer, BufferGetPName3I param, out int value1, out int value2, out int value3)
        {
            fixed (int* value1_ptr = &value1)
            fixed (int* value2_ptr = &value2)
            fixed (int* value3_ptr = &value3)
            {
                GetBuffer3i(buffer, param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferf(uint, BufferGetPNameF, float*)"/>
        public static unsafe float GetBufferf(uint buffer, BufferGetPNameF param)
        {
            float value;
            float* value_ptr = &value;
            {
                GetBufferf(buffer, param, value_ptr);
            }
            return value;
        }
        /// <inheritdoc cref="GetBufferf(uint, BufferGetPNameF, float*)"/>
        public static unsafe void GetBufferf(uint buffer, BufferGetPNameF param, out float value)
        {
            fixed (float* value_ptr = &value)
            {
                GetBufferf(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferfv(uint, BufferGetPNameFV, float*)"/>
        public static unsafe void GetBufferfv(uint buffer, BufferGetPNameFV param, Span<float> value)
        {
            fixed (float* value_ptr = value)
            {
                GetBufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferfv(uint, BufferGetPNameFV, float*)"/>
        public static unsafe void GetBufferfv(uint buffer, BufferGetPNameFV param, float[] value)
        {
            fixed (float* value_ptr = value)
            {
                GetBufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferfv(uint, BufferGetPNameFV, float*)"/>
        public static unsafe void GetBufferfv(uint buffer, BufferGetPNameFV param, ref float value)
        {
            fixed (float* value_ptr = &value)
            {
                GetBufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferi(uint, BufferGetPNameI, int*)"/>
        public static unsafe int GetBufferi(uint buffer, BufferGetPNameI param)
        {
            int value;
            int* value_ptr = &value;
            {
                GetBufferi(buffer, param, value_ptr);
            }
            return value;
        }
        /// <inheritdoc cref="GetBufferi(uint, BufferGetPNameI, int*)"/>
        public static unsafe void GetBufferi(uint buffer, BufferGetPNameI param, out int value)
        {
            fixed (int* value_ptr = &value)
            {
                GetBufferi(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferiv(uint, BufferGetPNameIV, int*)"/>
        public static unsafe void GetBufferiv(uint buffer, BufferGetPNameIV param, Span<int> value)
        {
            fixed (int* value_ptr = value)
            {
                GetBufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferiv(uint, BufferGetPNameIV, int*)"/>
        public static unsafe void GetBufferiv(uint buffer, BufferGetPNameIV param, int[] value)
        {
            fixed (int* value_ptr = value)
            {
                GetBufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferiv(uint, BufferGetPNameIV, int*)"/>
        public static unsafe void GetBufferiv(uint buffer, BufferGetPNameIV param, ref int value)
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
        /// <inheritdoc cref="GetSource3f(uint, SourceGetPName3F, float*, float*, float*)"/>
        public static unsafe float GetSource3f(uint source, SourceGetPName3F param, out float value1, out float value2)
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
        /// <inheritdoc cref="GetSource3f(uint, SourceGetPName3F, float*, float*, float*)"/>
        public static unsafe void GetSource3f(uint source, SourceGetPName3F param, out float value1, out float value2, out float value3)
        {
            fixed (float* value1_ptr = &value1)
            fixed (float* value2_ptr = &value2)
            fixed (float* value3_ptr = &value3)
            {
                GetSource3f(source, param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetSource3i(uint, SourceGetPName3I, int*, int*, int*)"/>
        public static unsafe int GetSource3i(uint source, SourceGetPName3I param, out int value1, out int value2)
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
        /// <inheritdoc cref="GetSource3i(uint, SourceGetPName3I, int*, int*, int*)"/>
        public static unsafe void GetSource3i(uint source, SourceGetPName3I param, out int value1, out int value2, out int value3)
        {
            fixed (int* value1_ptr = &value1)
            fixed (int* value2_ptr = &value2)
            fixed (int* value3_ptr = &value3)
            {
                GetSource3i(source, param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcef(uint, SourceGetPNameF, float*)"/>
        public static unsafe float GetSourcef(uint source, SourceGetPNameF param)
        {
            float value;
            float* value_ptr = &value;
            {
                GetSourcef(source, param, value_ptr);
            }
            return value;
        }
        /// <inheritdoc cref="GetSourcef(uint, SourceGetPNameF, float*)"/>
        public static unsafe void GetSourcef(uint source, SourceGetPNameF param, out float value)
        {
            fixed (float* value_ptr = &value)
            {
                GetSourcef(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcefv(uint, SourceGetPNameFV, float*)"/>
        public static unsafe void GetSourcefv(uint source, SourceGetPNameFV param, Span<float> values)
        {
            fixed (float* values_ptr = values)
            {
                GetSourcefv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcefv(uint, SourceGetPNameFV, float*)"/>
        public static unsafe void GetSourcefv(uint source, SourceGetPNameFV param, float[] values)
        {
            fixed (float* values_ptr = values)
            {
                GetSourcefv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcefv(uint, SourceGetPNameFV, float*)"/>
        public static unsafe void GetSourcefv(uint source, SourceGetPNameFV param, ref float values)
        {
            fixed (float* values_ptr = &values)
            {
                GetSourcefv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcei(uint, SourceGetPNameI, int*)"/>
        public static unsafe int GetSourcei(uint source, SourceGetPNameI param)
        {
            int value;
            int* value_ptr = &value;
            {
                GetSourcei(source, param, value_ptr);
            }
            return value;
        }
        /// <inheritdoc cref="GetSourcei(uint, SourceGetPNameI, int*)"/>
        public static unsafe void GetSourcei(uint source, SourceGetPNameI param, out int value)
        {
            fixed (int* value_ptr = &value)
            {
                GetSourcei(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetSourceiv(uint, SourceGetPNameIV, int*)"/>
        public static unsafe void GetSourceiv(uint source, SourceGetPNameIV param, Span<int> values)
        {
            fixed (int* values_ptr = values)
            {
                GetSourceiv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetSourceiv(uint, SourceGetPNameIV, int*)"/>
        public static unsafe void GetSourceiv(uint source, SourceGetPNameIV param, int[] values)
        {
            fixed (int* values_ptr = values)
            {
                GetSourceiv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetSourceiv(uint, SourceGetPNameIV, int*)"/>
        public static unsafe void GetSourceiv(uint source, SourceGetPNameIV param, ref int values)
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
        /// <inheritdoc cref="Sourcefv(uint, SourcePNameFV, float*)"/>
        public static unsafe void Sourcefv(uint source, SourcePNameFV param, ReadOnlySpan<float> value)
        {
            fixed (float* value_ptr = value)
            {
                Sourcefv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Sourcefv(uint, SourcePNameFV, float*)"/>
        public static unsafe void Sourcefv(uint source, SourcePNameFV param, float[] value)
        {
            fixed (float* value_ptr = value)
            {
                Sourcefv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Sourcefv(uint, SourcePNameFV, float*)"/>
        public static unsafe void Sourcefv(uint source, SourcePNameFV param, ref readonly float value)
        {
            fixed (float* value_ptr = &value)
            {
                Sourcefv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Sourceiv(uint, SourcePNameIV, int*)"/>
        public static unsafe void Sourceiv(uint source, SourcePNameIV param, ReadOnlySpan<int> value)
        {
            fixed (int* value_ptr = value)
            {
                Sourceiv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Sourceiv(uint, SourcePNameIV, int*)"/>
        public static unsafe void Sourceiv(uint source, SourcePNameIV param, int[] value)
        {
            fixed (int* value_ptr = value)
            {
                Sourceiv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Sourceiv(uint, SourcePNameIV, int*)"/>
        public static unsafe void Sourceiv(uint source, SourcePNameIV param, ref readonly int value)
        {
            fixed (int* value_ptr = &value)
            {
                Sourceiv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="SourcePausev(int, uint*)"/>
        public static unsafe void SourcePause(int n, ReadOnlySpan<uint> sources)
        {
            fixed (uint* sources_ptr = sources)
            {
                SourcePausev(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourcePausev(int, uint*)"/>
        public static unsafe void SourcePause(int n, uint[] sources)
        {
            fixed (uint* sources_ptr = sources)
            {
                SourcePausev(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourcePausev(int, uint*)"/>
        public static unsafe void SourcePause(int n, ref readonly uint sources)
        {
            fixed (uint* sources_ptr = &sources)
            {
                SourcePausev(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourcePlayv(int, uint*)"/>
        public static unsafe void SourcePlay(int n, ReadOnlySpan<uint> sources)
        {
            fixed (uint* sources_ptr = sources)
            {
                SourcePlayv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourcePlayv(int, uint*)"/>
        public static unsafe void SourcePlay(int n, uint[] sources)
        {
            fixed (uint* sources_ptr = sources)
            {
                SourcePlayv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourcePlayv(int, uint*)"/>
        public static unsafe void SourcePlay(int n, ref readonly uint sources)
        {
            fixed (uint* sources_ptr = &sources)
            {
                SourcePlayv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourceQueueBuffers(uint, int, uint*)"/>
        public static unsafe void SourceQueueBuffers(uint source, int nb, ReadOnlySpan<uint> buffers)
        {
            fixed (uint* buffers_ptr = buffers)
            {
                SourceQueueBuffers(source, nb, buffers_ptr);
            }
        }
        /// <inheritdoc cref="SourceQueueBuffers(uint, int, uint*)"/>
        public static unsafe void SourceQueueBuffers(uint source, int nb, uint[] buffers)
        {
            fixed (uint* buffers_ptr = buffers)
            {
                SourceQueueBuffers(source, nb, buffers_ptr);
            }
        }
        /// <inheritdoc cref="SourceQueueBuffers(uint, int, uint*)"/>
        public static unsafe void SourceQueueBuffers(uint source, int nb, ref readonly uint buffers)
        {
            fixed (uint* buffers_ptr = &buffers)
            {
                SourceQueueBuffers(source, nb, buffers_ptr);
            }
        }
        /// <inheritdoc cref="SourceRewindv(int, uint*)"/>
        public static unsafe void SourceRewind(int n, ReadOnlySpan<uint> sources)
        {
            fixed (uint* sources_ptr = sources)
            {
                SourceRewindv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourceRewindv(int, uint*)"/>
        public static unsafe void SourceRewind(int n, uint[] sources)
        {
            fixed (uint* sources_ptr = sources)
            {
                SourceRewindv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourceRewindv(int, uint*)"/>
        public static unsafe void SourceRewind(int n, ref readonly uint sources)
        {
            fixed (uint* sources_ptr = &sources)
            {
                SourceRewindv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourceStopv(int, uint*)"/>
        public static unsafe void SourceStop(int n, ReadOnlySpan<uint> sources)
        {
            fixed (uint* sources_ptr = sources)
            {
                SourceStopv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourceStopv(int, uint*)"/>
        public static unsafe void SourceStop(int n, uint[] sources)
        {
            fixed (uint* sources_ptr = sources)
            {
                SourceStopv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourceStopv(int, uint*)"/>
        public static unsafe void SourceStop(int n, ref readonly uint sources)
        {
            fixed (uint* sources_ptr = &sources)
            {
                SourceStopv(n, sources_ptr);
            }
        }
        /// <inheritdoc cref="SourceUnqueueBuffers(uint, int, uint*)"/>
        public static unsafe void SourceUnqueueBuffers(uint source, int nb, Span<uint> buffer)
        {
            fixed (uint* buffer_ptr = buffer)
            {
                SourceUnqueueBuffers(source, nb, buffer_ptr);
            }
        }
        /// <inheritdoc cref="SourceUnqueueBuffers(uint, int, uint*)"/>
        public static unsafe void SourceUnqueueBuffers(uint source, int nb, uint[] buffer)
        {
            fixed (uint* buffer_ptr = buffer)
            {
                SourceUnqueueBuffers(source, nb, buffer_ptr);
            }
        }
        /// <inheritdoc cref="SourceUnqueueBuffers(uint, int, uint*)"/>
        public static unsafe void SourceUnqueueBuffers(uint source, int nb, ref uint buffer)
        {
            fixed (uint* buffer_ptr = &buffer)
            {
                SourceUnqueueBuffers(source, nb, buffer_ptr);
            }
        }
        public static unsafe partial class EXT
        {
            /// <inheritdoc cref="AuxiliaryEffectSlotfv(uint, AuxEffectSlotPNameFV, float*)"/>
            public static unsafe void AuxiliaryEffectSlotfv(uint effectslot, AuxEffectSlotPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    AuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotfv(uint, AuxEffectSlotPNameFV, float*)"/>
            public static unsafe void AuxiliaryEffectSlotfv(uint effectslot, AuxEffectSlotPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    AuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotfv(uint, AuxEffectSlotPNameFV, float*)"/>
            public static unsafe void AuxiliaryEffectSlotfv(uint effectslot, AuxEffectSlotPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    AuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotiv(uint, AuxEffectSlotPNameIV, int*)"/>
            public static unsafe void AuxiliaryEffectSlotiv(uint effectslot, AuxEffectSlotPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    AuxiliaryEffectSlotiv(effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotiv(uint, AuxEffectSlotPNameIV, int*)"/>
            public static unsafe void AuxiliaryEffectSlotiv(uint effectslot, AuxEffectSlotPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    AuxiliaryEffectSlotiv(effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotiv(uint, AuxEffectSlotPNameIV, int*)"/>
            public static unsafe void AuxiliaryEffectSlotiv(uint effectslot, AuxEffectSlotPNameIV param, ref int piValues)
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
            /// <inheritdoc cref="DeleteAuxiliaryEffectSlots(int, uint*)"/>
            public static unsafe void DeleteAuxiliaryEffectSlot(uint effectslot)
            {
                int n = 1;
                uint* effectslots_handle = &effectslot;
                DeleteAuxiliaryEffectSlots(n, effectslots_handle);
            }
            /// <inheritdoc cref="DeleteAuxiliaryEffectSlots(int, uint*)"/>
            public static unsafe void DeleteAuxiliaryEffectSlots(int n, Span<uint> effectslots)
            {
                fixed (uint* effectslots_ptr = effectslots)
                {
                    DeleteAuxiliaryEffectSlots(n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="DeleteAuxiliaryEffectSlots(int, uint*)"/>
            public static unsafe void DeleteAuxiliaryEffectSlots(int n, uint[] effectslots)
            {
                fixed (uint* effectslots_ptr = effectslots)
                {
                    DeleteAuxiliaryEffectSlots(n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="DeleteAuxiliaryEffectSlots(int, uint*)"/>
            public static unsafe void DeleteAuxiliaryEffectSlots(int n, ref uint effectslots)
            {
                fixed (uint* effectslots_ptr = &effectslots)
                {
                    DeleteAuxiliaryEffectSlots(n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="DeleteEffects(int, uint*)"/>
            public static unsafe void DeleteEffect(uint effect)
            {
                int n = 1;
                uint* effects_handle = &effect;
                DeleteEffects(n, effects_handle);
            }
            /// <inheritdoc cref="DeleteEffects(int, uint*)"/>
            public static unsafe void DeleteEffects(int n, Span<uint> effects)
            {
                fixed (uint* effects_ptr = effects)
                {
                    DeleteEffects(n, effects_ptr);
                }
            }
            /// <inheritdoc cref="DeleteEffects(int, uint*)"/>
            public static unsafe void DeleteEffects(int n, uint[] effects)
            {
                fixed (uint* effects_ptr = effects)
                {
                    DeleteEffects(n, effects_ptr);
                }
            }
            /// <inheritdoc cref="DeleteEffects(int, uint*)"/>
            public static unsafe void DeleteEffects(int n, ref uint effects)
            {
                fixed (uint* effects_ptr = &effects)
                {
                    DeleteEffects(n, effects_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFilters(int, uint*)"/>
            public static unsafe void DeleteFilter(uint filter)
            {
                int n = 1;
                uint* filters_handle = &filter;
                DeleteFilters(n, filters_handle);
            }
            /// <inheritdoc cref="DeleteFilters(int, uint*)"/>
            public static unsafe void DeleteFilters(int n, Span<uint> filters)
            {
                fixed (uint* filters_ptr = filters)
                {
                    DeleteFilters(n, filters_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFilters(int, uint*)"/>
            public static unsafe void DeleteFilters(int n, uint[] filters)
            {
                fixed (uint* filters_ptr = filters)
                {
                    DeleteFilters(n, filters_ptr);
                }
            }
            /// <inheritdoc cref="DeleteFilters(int, uint*)"/>
            public static unsafe void DeleteFilters(int n, ref uint filters)
            {
                fixed (uint* filters_ptr = &filters)
                {
                    DeleteFilters(n, filters_ptr);
                }
            }
            /// <inheritdoc cref="Effectfv(uint, EffectPNameFV, float*)"/>
            public static unsafe void Effectfv(uint effect, EffectPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    Effectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Effectfv(uint, EffectPNameFV, float*)"/>
            public static unsafe void Effectfv(uint effect, EffectPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    Effectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Effectfv(uint, EffectPNameFV, float*)"/>
            public static unsafe void Effectfv(uint effect, EffectPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    Effectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Effectiv(uint, EffectPNameIV, int*)"/>
            public static unsafe void Effectiv(uint effect, EffectPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    Effectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="Effectiv(uint, EffectPNameIV, int*)"/>
            public static unsafe void Effectiv(uint effect, EffectPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    Effectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="Effectiv(uint, EffectPNameIV, int*)"/>
            public static unsafe void Effectiv(uint effect, EffectPNameIV param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    Effectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="Filterfv(uint, FilterPNameFV, float*)"/>
            public static unsafe void Filterfv(uint filter, FilterPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    Filterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Filterfv(uint, FilterPNameFV, float*)"/>
            public static unsafe void Filterfv(uint filter, FilterPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    Filterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Filterfv(uint, FilterPNameFV, float*)"/>
            public static unsafe void Filterfv(uint filter, FilterPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    Filterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Filteriv(uint, FilterPNameIV, int*)"/>
            public static unsafe void Filteriv(uint filter, FilterPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    Filteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="Filteriv(uint, FilterPNameIV, int*)"/>
            public static unsafe void Filteriv(uint filter, FilterPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    Filteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="Filteriv(uint, FilterPNameIV, int*)"/>
            public static unsafe void Filteriv(uint filter, FilterPNameIV param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    Filteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GenAuxiliaryEffectSlots(int, uint*)"/>
            public static unsafe uint GenAuxiliaryEffectSlot()
            {
                uint effectslot;
                int n = 1;
                Unsafe.SkipInit(out effectslot);
                uint* effectslots_handle = &effectslot;
                GenAuxiliaryEffectSlots(n, effectslots_handle);
                return effectslot;
            }
            /// <inheritdoc cref="GenAuxiliaryEffectSlots(int, uint*)"/>
            public static unsafe void GenAuxiliaryEffectSlot(out uint effectslot)
            {
                int n = 1;
                Unsafe.SkipInit(out effectslot);
                fixed(uint* effectslots_handle = &effectslot)
                {
                    GenAuxiliaryEffectSlots(n, effectslots_handle);
                }
            }
            /// <inheritdoc cref="GenAuxiliaryEffectSlots(int, uint*)"/>
            public static unsafe void GenAuxiliaryEffectSlots(int n, Span<uint> effectslots)
            {
                fixed (uint* effectslots_ptr = effectslots)
                {
                    GenAuxiliaryEffectSlots(n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="GenAuxiliaryEffectSlots(int, uint*)"/>
            public static unsafe void GenAuxiliaryEffectSlots(int n, uint[] effectslots)
            {
                fixed (uint* effectslots_ptr = effectslots)
                {
                    GenAuxiliaryEffectSlots(n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="GenAuxiliaryEffectSlots(int, uint*)"/>
            public static unsafe void GenAuxiliaryEffectSlots(int n, ref uint effectslots)
            {
                fixed (uint* effectslots_ptr = &effectslots)
                {
                    GenAuxiliaryEffectSlots(n, effectslots_ptr);
                }
            }
            /// <inheritdoc cref="GenEffects(int, uint*)"/>
            public static unsafe uint GenEffect()
            {
                uint effect;
                int n = 1;
                Unsafe.SkipInit(out effect);
                uint* effects_handle = &effect;
                GenEffects(n, effects_handle);
                return effect;
            }
            /// <inheritdoc cref="GenEffects(int, uint*)"/>
            public static unsafe void GenEffect(out uint effect)
            {
                int n = 1;
                Unsafe.SkipInit(out effect);
                fixed(uint* effects_handle = &effect)
                {
                    GenEffects(n, effects_handle);
                }
            }
            /// <inheritdoc cref="GenEffects(int, uint*)"/>
            public static unsafe void GenEffects(int n, Span<uint> effects)
            {
                fixed (uint* effects_ptr = effects)
                {
                    GenEffects(n, effects_ptr);
                }
            }
            /// <inheritdoc cref="GenEffects(int, uint*)"/>
            public static unsafe void GenEffects(int n, uint[] effects)
            {
                fixed (uint* effects_ptr = effects)
                {
                    GenEffects(n, effects_ptr);
                }
            }
            /// <inheritdoc cref="GenEffects(int, uint*)"/>
            public static unsafe void GenEffects(int n, ref uint effects)
            {
                fixed (uint* effects_ptr = &effects)
                {
                    GenEffects(n, effects_ptr);
                }
            }
            /// <inheritdoc cref="GenFilters(int, uint*)"/>
            public static unsafe uint GenFilter()
            {
                uint filter;
                int n = 1;
                Unsafe.SkipInit(out filter);
                uint* filters_handle = &filter;
                GenFilters(n, filters_handle);
                return filter;
            }
            /// <inheritdoc cref="GenFilters(int, uint*)"/>
            public static unsafe void GenFilter(out uint filter)
            {
                int n = 1;
                Unsafe.SkipInit(out filter);
                fixed(uint* filters_handle = &filter)
                {
                    GenFilters(n, filters_handle);
                }
            }
            /// <inheritdoc cref="GenFilters(int, uint*)"/>
            public static unsafe void GenFilters(int n, Span<uint> filters)
            {
                fixed (uint* filters_ptr = filters)
                {
                    GenFilters(n, filters_ptr);
                }
            }
            /// <inheritdoc cref="GenFilters(int, uint*)"/>
            public static unsafe void GenFilters(int n, uint[] filters)
            {
                fixed (uint* filters_ptr = filters)
                {
                    GenFilters(n, filters_ptr);
                }
            }
            /// <inheritdoc cref="GenFilters(int, uint*)"/>
            public static unsafe void GenFilters(int n, ref uint filters)
            {
                fixed (uint* filters_ptr = &filters)
                {
                    GenFilters(n, filters_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotf(uint, AuxEffectSlotGetPNameF, float*)"/>
            public static unsafe float GetAuxiliaryEffectSlotf(uint effectslot, AuxEffectSlotGetPNameF param)
            {
                float pflValue;
                float* pflValue_ptr = &pflValue;
                {
                    GetAuxiliaryEffectSlotf(effectslot, param, pflValue_ptr);
                }
                return pflValue;
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotf(uint, AuxEffectSlotGetPNameF, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotf(uint effectslot, AuxEffectSlotGetPNameF param, out float pflValue)
            {
                fixed (float* pflValue_ptr = &pflValue)
                {
                    GetAuxiliaryEffectSlotf(effectslot, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotfv(uint, AuxEffectSlotGetPNameFV, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotfv(uint effectslot, AuxEffectSlotGetPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetAuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotfv(uint, AuxEffectSlotGetPNameFV, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotfv(uint effectslot, AuxEffectSlotGetPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetAuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotfv(uint, AuxEffectSlotGetPNameFV, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotfv(uint effectslot, AuxEffectSlotGetPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    GetAuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSloti(uint, AuxEffectSlotGetPNameI, int*)"/>
            public static unsafe int GetAuxiliaryEffectSloti(uint effectslot, AuxEffectSlotGetPNameI param)
            {
                int piValue;
                int* piValue_ptr = &piValue;
                {
                    GetAuxiliaryEffectSloti(effectslot, param, piValue_ptr);
                }
                return piValue;
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSloti(uint, AuxEffectSlotGetPNameI, int*)"/>
            public static unsafe void GetAuxiliaryEffectSloti(uint effectslot, AuxEffectSlotGetPNameI param, out int piValue)
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    GetAuxiliaryEffectSloti(effectslot, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotiv(uint, AuxEffectSlotGetPNameIV, int*)"/>
            public static unsafe void GetAuxiliaryEffectSlotiv(uint effectslot, AuxEffectSlotGetPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetAuxiliaryEffectSlotiv(effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotiv(uint, AuxEffectSlotGetPNameIV, int*)"/>
            public static unsafe void GetAuxiliaryEffectSlotiv(uint effectslot, AuxEffectSlotGetPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetAuxiliaryEffectSlotiv(effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotiv(uint, AuxEffectSlotGetPNameIV, int*)"/>
            public static unsafe void GetAuxiliaryEffectSlotiv(uint effectslot, AuxEffectSlotGetPNameIV param, ref int piValues)
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
            /// <inheritdoc cref="GetEffectf(uint, EffectGetPNameF, float*)"/>
            public static unsafe float GetEffectf(uint effect, EffectGetPNameF param)
            {
                float pflValue;
                float* pflValue_ptr = &pflValue;
                {
                    GetEffectf(effect, param, pflValue_ptr);
                }
                return pflValue;
            }
            /// <inheritdoc cref="GetEffectf(uint, EffectGetPNameF, float*)"/>
            public static unsafe void GetEffectf(uint effect, EffectGetPNameF param, out float pflValue)
            {
                fixed (float* pflValue_ptr = &pflValue)
                {
                    GetEffectf(effect, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectfv(uint, EffectGetPNameFV, float*)"/>
            public static unsafe void GetEffectfv(uint effect, EffectGetPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetEffectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectfv(uint, EffectGetPNameFV, float*)"/>
            public static unsafe void GetEffectfv(uint effect, EffectGetPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetEffectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectfv(uint, EffectGetPNameFV, float*)"/>
            public static unsafe void GetEffectfv(uint effect, EffectGetPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    GetEffectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffecti(uint, EffectGetPNameI, int*)"/>
            public static unsafe int GetEffecti(uint effect, EffectGetPNameI param)
            {
                int piValue;
                int* piValue_ptr = &piValue;
                {
                    GetEffecti(effect, param, piValue_ptr);
                }
                return piValue;
            }
            /// <inheritdoc cref="GetEffecti(uint, EffectGetPNameI, int*)"/>
            public static unsafe void GetEffecti(uint effect, EffectGetPNameI param, out int piValue)
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    GetEffecti(effect, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectiv(uint, EffectGetPNameIV, int*)"/>
            public static unsafe void GetEffectiv(uint effect, EffectGetPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetEffectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectiv(uint, EffectGetPNameIV, int*)"/>
            public static unsafe void GetEffectiv(uint effect, EffectGetPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetEffectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectiv(uint, EffectGetPNameIV, int*)"/>
            public static unsafe void GetEffectiv(uint effect, EffectGetPNameIV param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    GetEffectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterf(uint, FilterGetPNameF, float*)"/>
            public static unsafe float GetFilterf(uint filter, FilterGetPNameF param)
            {
                float pflValue;
                float* pflValue_ptr = &pflValue;
                {
                    GetFilterf(filter, param, pflValue_ptr);
                }
                return pflValue;
            }
            /// <inheritdoc cref="GetFilterf(uint, FilterGetPNameF, float*)"/>
            public static unsafe void GetFilterf(uint filter, FilterGetPNameF param, out float pflValue)
            {
                fixed (float* pflValue_ptr = &pflValue)
                {
                    GetFilterf(filter, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterfv(uint, FilterGetPNameFV, float*)"/>
            public static unsafe void GetFilterfv(uint filter, FilterGetPNameFV param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetFilterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterfv(uint, FilterGetPNameFV, float*)"/>
            public static unsafe void GetFilterfv(uint filter, FilterGetPNameFV param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetFilterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterfv(uint, FilterGetPNameFV, float*)"/>
            public static unsafe void GetFilterfv(uint filter, FilterGetPNameFV param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    GetFilterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilteri(uint, FilterGetPNameI, int*)"/>
            public static unsafe int GetFilteri(uint filter, FilterGetPNameI param)
            {
                int piValue;
                int* piValue_ptr = &piValue;
                {
                    GetFilteri(filter, param, piValue_ptr);
                }
                return piValue;
            }
            /// <inheritdoc cref="GetFilteri(uint, FilterGetPNameI, int*)"/>
            public static unsafe void GetFilteri(uint filter, FilterGetPNameI param, out int piValue)
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    GetFilteri(filter, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetFilteriv(uint, FilterGetPNameIV, int*)"/>
            public static unsafe void GetFilteriv(uint filter, FilterGetPNameIV param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetFilteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilteriv(uint, FilterGetPNameIV, int*)"/>
            public static unsafe void GetFilteriv(uint filter, FilterGetPNameIV param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetFilteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilteriv(uint, FilterGetPNameIV, int*)"/>
            public static unsafe void GetFilteriv(uint filter, FilterGetPNameIV param, ref int piValues)
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
            /// <inheritdoc cref="SourceAddNotification(uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe ErrorCode SourceAddNotification(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, IntPtr userData)
            {
                ErrorCode returnValue;
                void* userData_vptr = (void*)userData;
                returnValue = SourceAddNotification(sid, notificationID, notifyProc, userData_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="SourceAddNotification(uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe ErrorCode SourceAddNotification<T1>(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, Span<T1> userData)
                where T1 : unmanaged
            {
                ErrorCode returnValue;
                fixed (void* userData_ptr = userData)
                {
                    returnValue = SourceAddNotification(sid, notificationID, notifyProc, userData_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SourceAddNotification(uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe ErrorCode SourceAddNotification<T1>(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, T1[] userData)
                where T1 : unmanaged
            {
                ErrorCode returnValue;
                fixed (void* userData_ptr = userData)
                {
                    returnValue = SourceAddNotification(sid, notificationID, notifyProc, userData_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SourceAddNotification(uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe ErrorCode SourceAddNotification<T1>(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, ref T1 userData)
                where T1 : unmanaged
            {
                ErrorCode returnValue;
                fixed (void* userData_ptr = &userData)
                {
                    returnValue = SourceAddNotification(sid, notificationID, notifyProc, userData_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SourceRemoveNotification(uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe void SourceRemoveNotification(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, IntPtr userData)
            {
                void* userData_vptr = (void*)userData;
                SourceRemoveNotification(sid, notificationID, notifyProc, userData_vptr);
            }
            /// <inheritdoc cref="SourceRemoveNotification(uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe void SourceRemoveNotification<T1>(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, Span<T1> userData)
                where T1 : unmanaged
            {
                fixed (void* userData_ptr = userData)
                {
                    SourceRemoveNotification(sid, notificationID, notifyProc, userData_ptr);
                }
            }
            /// <inheritdoc cref="SourceRemoveNotification(uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe void SourceRemoveNotification<T1>(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, T1[] userData)
                where T1 : unmanaged
            {
                fixed (void* userData_ptr = userData)
                {
                    SourceRemoveNotification(sid, notificationID, notifyProc, userData_ptr);
                }
            }
            /// <inheritdoc cref="SourceRemoveNotification(uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe void SourceRemoveNotification<T1>(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, ref T1 userData)
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
            /// <inheritdoc cref="BufferCallbackSOFT(uint, Format, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*)"/>
            public static unsafe void BufferCallbackSOFT(uint buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, IntPtr userptr)
            {
                void* userptr_vptr = (void*)userptr;
                BufferCallbackSOFT(buffer, format, freq, callback, userptr_vptr);
            }
            /// <inheritdoc cref="BufferCallbackSOFT(uint, Format, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*)"/>
            public static unsafe void BufferCallbackSOFT<T1>(uint buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, Span<T1> userptr)
                where T1 : unmanaged
            {
                fixed (void* userptr_ptr = userptr)
                {
                    BufferCallbackSOFT(buffer, format, freq, callback, userptr_ptr);
                }
            }
            /// <inheritdoc cref="BufferCallbackSOFT(uint, Format, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*)"/>
            public static unsafe void BufferCallbackSOFT<T1>(uint buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, T1[] userptr)
                where T1 : unmanaged
            {
                fixed (void* userptr_ptr = userptr)
                {
                    BufferCallbackSOFT(buffer, format, freq, callback, userptr_ptr);
                }
            }
            /// <inheritdoc cref="BufferCallbackSOFT(uint, Format, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*)"/>
            public static unsafe void BufferCallbackSOFT<T1>(uint buffer, Format format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, ref T1 userptr)
                where T1 : unmanaged
            {
                fixed (void* userptr_ptr = &userptr)
                {
                    BufferCallbackSOFT(buffer, format, freq, callback, userptr_ptr);
                }
            }
            /// <inheritdoc cref="BufferSamplesSOFT(uint, uint, InternalFormat, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSamplesSOFT(uint buffer, uint samplerate, InternalFormat internalformat, int samples, Channels channels, SampleType type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                BufferSamplesSOFT(buffer, samplerate, internalformat, samples, channels, type, data_vptr);
            }
            /// <inheritdoc cref="BufferSamplesSOFT(uint, uint, InternalFormat, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSamplesSOFT<T1>(uint buffer, uint samplerate, InternalFormat internalformat, int samples, Channels channels, SampleType type, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSamplesSOFT(buffer, samplerate, internalformat, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSamplesSOFT(uint, uint, InternalFormat, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSamplesSOFT<T1>(uint buffer, uint samplerate, InternalFormat internalformat, int samples, Channels channels, SampleType type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSamplesSOFT(buffer, samplerate, internalformat, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSamplesSOFT(uint, uint, InternalFormat, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSamplesSOFT<T1>(uint buffer, uint samplerate, InternalFormat internalformat, int samples, Channels channels, SampleType type, ref readonly T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    BufferSamplesSOFT(buffer, samplerate, internalformat, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSubDataSOFT(uint, Format, void*, int, int)"/>
            public static unsafe void BufferSubDataSOFT(uint buffer, Format format, IntPtr data, int offset, int length)
            {
                void* data_vptr = (void*)data;
                BufferSubDataSOFT(buffer, format, data_vptr, offset, length);
            }
            /// <inheritdoc cref="BufferSubDataSOFT(uint, Format, void*, int, int)"/>
            public static unsafe void BufferSubDataSOFT<T1>(uint buffer, Format format, ReadOnlySpan<T1> data, int offset, int length)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubDataSOFT(buffer, format, data_ptr, offset, length);
                }
            }
            /// <inheritdoc cref="BufferSubDataSOFT(uint, Format, void*, int, int)"/>
            public static unsafe void BufferSubDataSOFT<T1>(uint buffer, Format format, T1[] data, int offset, int length)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubDataSOFT(buffer, format, data_ptr, offset, length);
                }
            }
            /// <inheritdoc cref="BufferSubDataSOFT(uint, Format, void*, int, int)"/>
            public static unsafe void BufferSubDataSOFT<T1>(uint buffer, Format format, ref readonly T1 data, int offset, int length)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    BufferSubDataSOFT(buffer, format, data_ptr, offset, length);
                }
            }
            /// <inheritdoc cref="BufferSubSamplesSOFT(uint, int, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSubSamplesSOFT(uint buffer, int offset, int samples, Channels channels, SampleType type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                BufferSubSamplesSOFT(buffer, offset, samples, channels, type, data_vptr);
            }
            /// <inheritdoc cref="BufferSubSamplesSOFT(uint, int, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSubSamplesSOFT<T1>(uint buffer, int offset, int samples, Channels channels, SampleType type, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSubSamplesSOFT(uint, int, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSubSamplesSOFT<T1>(uint buffer, int offset, int samples, Channels channels, SampleType type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSubSamplesSOFT(uint, int, int, Channels, SampleType, void*)"/>
            public static unsafe void BufferSubSamplesSOFT<T1>(uint buffer, int offset, int samples, Channels channels, SampleType type, ref readonly T1 data)
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
            /// <inheritdoc cref="GetBufferSamplesSOFT(uint, int, int, Channels, SampleType, void*)"/>
            public static unsafe void GetBufferSamplesSOFT(uint buffer, int offset, int samples, Channels channels, SampleType type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                GetBufferSamplesSOFT(buffer, offset, samples, channels, type, data_vptr);
            }
            /// <inheritdoc cref="GetBufferSamplesSOFT(uint, int, int, Channels, SampleType, void*)"/>
            public static unsafe void GetBufferSamplesSOFT<T1>(uint buffer, int offset, int samples, Channels channels, SampleType type, Span<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    GetBufferSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferSamplesSOFT(uint, int, int, Channels, SampleType, void*)"/>
            public static unsafe void GetBufferSamplesSOFT<T1>(uint buffer, int offset, int samples, Channels channels, SampleType type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    GetBufferSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferSamplesSOFT(uint, int, int, Channels, SampleType, void*)"/>
            public static unsafe void GetBufferSamplesSOFT<T1>(uint buffer, int offset, int samples, Channels channels, SampleType type, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    GetBufferSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="GetSource3dSOFT(uint, SourceGetPName3D, double*, double*, double*)"/>
            public static unsafe double GetSource3dSOFT(uint source, SourceGetPName3D param, out double value1, out double value2)
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
            /// <inheritdoc cref="GetSource3dSOFT(uint, SourceGetPName3D, double*, double*, double*)"/>
            public static unsafe void GetSource3dSOFT(uint source, SourceGetPName3D param, out double value1, out double value2, out double value3)
            {
                fixed (double* value1_ptr = &value1)
                fixed (double* value2_ptr = &value2)
                fixed (double* value3_ptr = &value3)
                {
                    GetSource3dSOFT(source, param, value1_ptr, value2_ptr, value3_ptr);
                }
            }
            /// <inheritdoc cref="GetSource3i64SOFT(uint, SourceGetPName3I64, long*, long*, long*)"/>
            public static unsafe long GetSource3i64SOFT(uint source, SourceGetPName3I64 param, out long value1, out long value2)
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
            /// <inheritdoc cref="GetSource3i64SOFT(uint, SourceGetPName3I64, long*, long*, long*)"/>
            public static unsafe void GetSource3i64SOFT(uint source, SourceGetPName3I64 param, out long value1, out long value2, out long value3)
            {
                fixed (long* value1_ptr = &value1)
                fixed (long* value2_ptr = &value2)
                fixed (long* value3_ptr = &value3)
                {
                    GetSource3i64SOFT(source, param, value1_ptr, value2_ptr, value3_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedSOFT(uint, SourceGetPNameD, double*)"/>
            public static unsafe double GetSourcedSOFT(uint source, SourceGetPNameD param)
            {
                double value;
                double* value_ptr = &value;
                {
                    GetSourcedSOFT(source, param, value_ptr);
                }
                return value;
            }
            /// <inheritdoc cref="GetSourcedSOFT(uint, SourceGetPNameD, double*)"/>
            public static unsafe void GetSourcedSOFT(uint source, SourceGetPNameD param, out double value)
            {
                fixed (double* value_ptr = &value)
                {
                    GetSourcedSOFT(source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedvSOFT(uint, SourceGetPNameDV, double*)"/>
            public static unsafe void GetSourcedvSOFT(uint source, SourceGetPNameDV param, Span<double> values)
            {
                fixed (double* values_ptr = values)
                {
                    GetSourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedvSOFT(uint, SourceGetPNameDV, double*)"/>
            public static unsafe void GetSourcedvSOFT(uint source, SourceGetPNameDV param, double[] values)
            {
                fixed (double* values_ptr = values)
                {
                    GetSourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedvSOFT(uint, SourceGetPNameDV, double*)"/>
            public static unsafe void GetSourcedvSOFT(uint source, SourceGetPNameDV param, ref double values)
            {
                fixed (double* values_ptr = &values)
                {
                    GetSourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64SOFT(uint, SourceGetPNameI64, long*)"/>
            public static unsafe long GetSourcei64SOFT(uint source, SourceGetPNameI64 param)
            {
                long value;
                long* value_ptr = &value;
                {
                    GetSourcei64SOFT(source, param, value_ptr);
                }
                return value;
            }
            /// <inheritdoc cref="GetSourcei64SOFT(uint, SourceGetPNameI64, long*)"/>
            public static unsafe void GetSourcei64SOFT(uint source, SourceGetPNameI64 param, out long value)
            {
                fixed (long* value_ptr = &value)
                {
                    GetSourcei64SOFT(source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64vSOFT(uint, SourceGetPNameI64V, long*)"/>
            public static unsafe void GetSourcei64vSOFT(uint source, SourceGetPNameI64V param, Span<long> values)
            {
                fixed (long* values_ptr = values)
                {
                    GetSourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64vSOFT(uint, SourceGetPNameI64V, long*)"/>
            public static unsafe void GetSourcei64vSOFT(uint source, SourceGetPNameI64V param, long[] values)
            {
                fixed (long* values_ptr = values)
                {
                    GetSourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64vSOFT(uint, SourceGetPNameI64V, long*)"/>
            public static unsafe void GetSourcei64vSOFT(uint source, SourceGetPNameI64V param, ref long values)
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
            /// <inheritdoc cref="SourcedvSOFT(uint, SourcePNameDV, double*)"/>
            public static unsafe void SourcedvSOFT(uint source, SourcePNameDV param, ReadOnlySpan<double> values)
            {
                fixed (double* values_ptr = values)
                {
                    SourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="SourcedvSOFT(uint, SourcePNameDV, double*)"/>
            public static unsafe void SourcedvSOFT(uint source, SourcePNameDV param, double[] values)
            {
                fixed (double* values_ptr = values)
                {
                    SourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="SourcedvSOFT(uint, SourcePNameDV, double*)"/>
            public static unsafe void SourcedvSOFT(uint source, SourcePNameDV param, ref readonly double values)
            {
                fixed (double* values_ptr = &values)
                {
                    SourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="Sourcei64vSOFT(uint, SourcePNameI64V, long*)"/>
            public static unsafe void Sourcei64vSOFT(uint source, SourcePNameI64V param, ReadOnlySpan<long> values)
            {
                fixed (long* values_ptr = values)
                {
                    Sourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="Sourcei64vSOFT(uint, SourcePNameI64V, long*)"/>
            public static unsafe void Sourcei64vSOFT(uint source, SourcePNameI64V param, long[] values)
            {
                fixed (long* values_ptr = values)
                {
                    Sourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="Sourcei64vSOFT(uint, SourcePNameI64V, long*)"/>
            public static unsafe void Sourcei64vSOFT(uint source, SourcePNameI64V param, ref readonly long values)
            {
                fixed (long* values_ptr = &values)
                {
                    Sourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="SourcePlayAtTimevSOFT(int, uint*, long)"/>
            public static unsafe void SourcePlayAtTimevSOFT(int n, ReadOnlySpan<uint> sources, long start_time)
            {
                fixed (uint* sources_ptr = sources)
                {
                    SourcePlayAtTimevSOFT(n, sources_ptr, start_time);
                }
            }
            /// <inheritdoc cref="SourcePlayAtTimevSOFT(int, uint*, long)"/>
            public static unsafe void SourcePlayAtTimevSOFT(int n, uint[] sources, long start_time)
            {
                fixed (uint* sources_ptr = sources)
                {
                    SourcePlayAtTimevSOFT(n, sources_ptr, start_time);
                }
            }
            /// <inheritdoc cref="SourcePlayAtTimevSOFT(int, uint*, long)"/>
            public static unsafe void SourcePlayAtTimevSOFT(int n, ref readonly uint sources, long start_time)
            {
                fixed (uint* sources_ptr = &sources)
                {
                    SourcePlayAtTimevSOFT(n, sources_ptr, start_time);
                }
            }
        }
    }
}

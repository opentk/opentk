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
        /// <inheritdoc cref="BufferData(uint, All, void*, int, int)"/>
        public static unsafe void BufferData(uint buffer, All format, IntPtr data, int size, int samplerate)
        {
            void* data_vptr = (void*)data;
            BufferData(buffer, format, data_vptr, size, samplerate);
        }
        /// <inheritdoc cref="BufferData(uint, All, void*, int, int)"/>
        public static unsafe void BufferData<T1>(uint buffer, All format, ReadOnlySpan<T1> data, int size, int samplerate)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = data)
            {
                BufferData(buffer, format, data_ptr, size, samplerate);
            }
        }
        /// <inheritdoc cref="BufferData(uint, All, void*, int, int)"/>
        public static unsafe void BufferData<T1>(uint buffer, All format, T1[] data, int size, int samplerate)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = data)
            {
                BufferData(buffer, format, data_ptr, size, samplerate);
            }
        }
        /// <inheritdoc cref="BufferData(uint, All, void*, int, int)"/>
        public static unsafe void BufferData<T1>(uint buffer, All format, ref readonly T1 data, int size, int samplerate)
            where T1 : unmanaged
        {
            fixed (void* data_ptr = &data)
            {
                BufferData(buffer, format, data_ptr, size, samplerate);
            }
        }
        /// <inheritdoc cref="Bufferfv(uint, All, float*)"/>
        public static unsafe void Bufferfv(uint buffer, All param, ReadOnlySpan<float> value)
        {
            fixed (float* value_ptr = value)
            {
                Bufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Bufferfv(uint, All, float*)"/>
        public static unsafe void Bufferfv(uint buffer, All param, float[] value)
        {
            fixed (float* value_ptr = value)
            {
                Bufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Bufferfv(uint, All, float*)"/>
        public static unsafe void Bufferfv(uint buffer, All param, ref readonly float value)
        {
            fixed (float* value_ptr = &value)
            {
                Bufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Bufferiv(uint, All, int*)"/>
        public static unsafe void Bufferiv(uint buffer, All param, ReadOnlySpan<int> value)
        {
            fixed (int* value_ptr = value)
            {
                Bufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Bufferiv(uint, All, int*)"/>
        public static unsafe void Bufferiv(uint buffer, All param, int[] value)
        {
            fixed (int* value_ptr = value)
            {
                Bufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Bufferiv(uint, All, int*)"/>
        public static unsafe void Bufferiv(uint buffer, All param, ref readonly int value)
        {
            fixed (int* value_ptr = &value)
            {
                Bufferiv(buffer, param, value_ptr);
            }
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
        /// <inheritdoc cref="GetBooleanv(GetPName, bool*)"/>
        public static unsafe void GetBoolean(GetPName param, Span<bool> values)
        {
            fixed (bool* values_ptr = values)
            {
                GetBooleanv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleanv(GetPName, bool*)"/>
        public static unsafe void GetBoolean(GetPName param, bool[] values)
        {
            fixed (bool* values_ptr = values)
            {
                GetBooleanv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetBooleanv(GetPName, bool*)"/>
        public static unsafe void GetBoolean(GetPName param, ref bool values)
        {
            fixed (bool* values_ptr = &values)
            {
                GetBooleanv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetBuffer3f(uint, All, float*, float*, float*)"/>
        public static unsafe void GetBuffer3f(uint buffer, All param, Span<float> value1, Span<float> value2, Span<float> value3)
        {
            fixed (float* value3_ptr = value3)
            {
                fixed (float* value2_ptr = value2)
                {
                    fixed (float* value1_ptr = value1)
                    {
                        GetBuffer3f(buffer, param, value1_ptr, value2_ptr, value3_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetBuffer3f(uint, All, float*, float*, float*)"/>
        public static unsafe void GetBuffer3f(uint buffer, All param, float[] value1, float[] value2, float[] value3)
        {
            fixed (float* value3_ptr = value3)
            {
                fixed (float* value2_ptr = value2)
                {
                    fixed (float* value1_ptr = value1)
                    {
                        GetBuffer3f(buffer, param, value1_ptr, value2_ptr, value3_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetBuffer3f(uint, All, float*, float*, float*)"/>
        public static unsafe void GetBuffer3f(uint buffer, All param, ref float value1, ref float value2, ref float value3)
        {
            fixed (float* value1_ptr = &value1)
            fixed (float* value2_ptr = &value2)
            fixed (float* value3_ptr = &value3)
            {
                GetBuffer3f(buffer, param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetBuffer3i(uint, All, int*, int*, int*)"/>
        public static unsafe void GetBuffer3i(uint buffer, All param, Span<int> value1, Span<int> value2, Span<int> value3)
        {
            fixed (int* value3_ptr = value3)
            {
                fixed (int* value2_ptr = value2)
                {
                    fixed (int* value1_ptr = value1)
                    {
                        GetBuffer3i(buffer, param, value1_ptr, value2_ptr, value3_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetBuffer3i(uint, All, int*, int*, int*)"/>
        public static unsafe void GetBuffer3i(uint buffer, All param, int[] value1, int[] value2, int[] value3)
        {
            fixed (int* value3_ptr = value3)
            {
                fixed (int* value2_ptr = value2)
                {
                    fixed (int* value1_ptr = value1)
                    {
                        GetBuffer3i(buffer, param, value1_ptr, value2_ptr, value3_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetBuffer3i(uint, All, int*, int*, int*)"/>
        public static unsafe void GetBuffer3i(uint buffer, All param, ref int value1, ref int value2, ref int value3)
        {
            fixed (int* value1_ptr = &value1)
            fixed (int* value2_ptr = &value2)
            fixed (int* value3_ptr = &value3)
            {
                GetBuffer3i(buffer, param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferf(uint, All, float*)"/>
        public static unsafe void GetBufferf(uint buffer, All param, Span<float> value)
        {
            fixed (float* value_ptr = value)
            {
                GetBufferf(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferf(uint, All, float*)"/>
        public static unsafe void GetBufferf(uint buffer, All param, float[] value)
        {
            fixed (float* value_ptr = value)
            {
                GetBufferf(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferf(uint, All, float*)"/>
        public static unsafe void GetBufferf(uint buffer, All param, ref float value)
        {
            fixed (float* value_ptr = &value)
            {
                GetBufferf(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferfv(uint, All, float*)"/>
        public static unsafe void GetBufferfv(uint buffer, All param, Span<float> value)
        {
            fixed (float* value_ptr = value)
            {
                GetBufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferfv(uint, All, float*)"/>
        public static unsafe void GetBufferfv(uint buffer, All param, float[] value)
        {
            fixed (float* value_ptr = value)
            {
                GetBufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferfv(uint, All, float*)"/>
        public static unsafe void GetBufferfv(uint buffer, All param, ref float value)
        {
            fixed (float* value_ptr = &value)
            {
                GetBufferfv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferi(uint, All, int*)"/>
        public static unsafe void GetBufferi(uint buffer, All param, Span<int> value)
        {
            fixed (int* value_ptr = value)
            {
                GetBufferi(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferi(uint, All, int*)"/>
        public static unsafe void GetBufferi(uint buffer, All param, int[] value)
        {
            fixed (int* value_ptr = value)
            {
                GetBufferi(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferi(uint, All, int*)"/>
        public static unsafe void GetBufferi(uint buffer, All param, ref int value)
        {
            fixed (int* value_ptr = &value)
            {
                GetBufferi(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferiv(uint, All, int*)"/>
        public static unsafe void GetBufferiv(uint buffer, All param, Span<int> value)
        {
            fixed (int* value_ptr = value)
            {
                GetBufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferiv(uint, All, int*)"/>
        public static unsafe void GetBufferiv(uint buffer, All param, int[] value)
        {
            fixed (int* value_ptr = value)
            {
                GetBufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetBufferiv(uint, All, int*)"/>
        public static unsafe void GetBufferiv(uint buffer, All param, ref int value)
        {
            fixed (int* value_ptr = &value)
            {
                GetBufferiv(buffer, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetDoublev(GetPName, double*)"/>
        public static unsafe void GetDouble(GetPName param, Span<double> values)
        {
            fixed (double* values_ptr = values)
            {
                GetDoublev(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetDoublev(GetPName, double*)"/>
        public static unsafe void GetDouble(GetPName param, double[] values)
        {
            fixed (double* values_ptr = values)
            {
                GetDoublev(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetDoublev(GetPName, double*)"/>
        public static unsafe void GetDouble(GetPName param, ref double values)
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
        /// <inheritdoc cref="GetFloatv(GetPName, float*)"/>
        public static unsafe void GetFloat(GetPName param, Span<float> values)
        {
            fixed (float* values_ptr = values)
            {
                GetFloatv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetFloatv(GetPName, float*)"/>
        public static unsafe void GetFloat(GetPName param, float[] values)
        {
            fixed (float* values_ptr = values)
            {
                GetFloatv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetFloatv(GetPName, float*)"/>
        public static unsafe void GetFloat(GetPName param, ref float values)
        {
            fixed (float* values_ptr = &values)
            {
                GetFloatv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegerv(GetPName, int*)"/>
        public static unsafe void GetInteger(GetPName param, Span<int> values)
        {
            fixed (int* values_ptr = values)
            {
                GetIntegerv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegerv(GetPName, int*)"/>
        public static unsafe void GetInteger(GetPName param, int[] values)
        {
            fixed (int* values_ptr = values)
            {
                GetIntegerv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetIntegerv(GetPName, int*)"/>
        public static unsafe void GetInteger(GetPName param, ref int values)
        {
            fixed (int* values_ptr = &values)
            {
                GetIntegerv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetListener3f(All, float*, float*, float*)"/>
        public static unsafe void GetListener3f(All param, Span<float> value1, Span<float> value2, Span<float> value3)
        {
            fixed (float* value3_ptr = value3)
            {
                fixed (float* value2_ptr = value2)
                {
                    fixed (float* value1_ptr = value1)
                    {
                        GetListener3f(param, value1_ptr, value2_ptr, value3_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetListener3f(All, float*, float*, float*)"/>
        public static unsafe void GetListener3f(All param, float[] value1, float[] value2, float[] value3)
        {
            fixed (float* value3_ptr = value3)
            {
                fixed (float* value2_ptr = value2)
                {
                    fixed (float* value1_ptr = value1)
                    {
                        GetListener3f(param, value1_ptr, value2_ptr, value3_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetListener3f(All, float*, float*, float*)"/>
        public static unsafe void GetListener3f(All param, ref float value1, ref float value2, ref float value3)
        {
            fixed (float* value1_ptr = &value1)
            fixed (float* value2_ptr = &value2)
            fixed (float* value3_ptr = &value3)
            {
                GetListener3f(param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetListener3i(All, int*, int*, int*)"/>
        public static unsafe void GetListener3i(All param, Span<int> value1, Span<int> value2, Span<int> value3)
        {
            fixed (int* value3_ptr = value3)
            {
                fixed (int* value2_ptr = value2)
                {
                    fixed (int* value1_ptr = value1)
                    {
                        GetListener3i(param, value1_ptr, value2_ptr, value3_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetListener3i(All, int*, int*, int*)"/>
        public static unsafe void GetListener3i(All param, int[] value1, int[] value2, int[] value3)
        {
            fixed (int* value3_ptr = value3)
            {
                fixed (int* value2_ptr = value2)
                {
                    fixed (int* value1_ptr = value1)
                    {
                        GetListener3i(param, value1_ptr, value2_ptr, value3_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetListener3i(All, int*, int*, int*)"/>
        public static unsafe void GetListener3i(All param, ref int value1, ref int value2, ref int value3)
        {
            fixed (int* value1_ptr = &value1)
            fixed (int* value2_ptr = &value2)
            fixed (int* value3_ptr = &value3)
            {
                GetListener3i(param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetListenerf(All, float*)"/>
        public static unsafe void GetListenerf(All param, Span<float> value)
        {
            fixed (float* value_ptr = value)
            {
                GetListenerf(param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetListenerf(All, float*)"/>
        public static unsafe void GetListenerf(All param, float[] value)
        {
            fixed (float* value_ptr = value)
            {
                GetListenerf(param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetListenerf(All, float*)"/>
        public static unsafe void GetListenerf(All param, ref float value)
        {
            fixed (float* value_ptr = &value)
            {
                GetListenerf(param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetListenerfv(All, float*)"/>
        public static unsafe void GetListenerfv(All param, Span<float> values)
        {
            fixed (float* values_ptr = values)
            {
                GetListenerfv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetListenerfv(All, float*)"/>
        public static unsafe void GetListenerfv(All param, float[] values)
        {
            fixed (float* values_ptr = values)
            {
                GetListenerfv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetListenerfv(All, float*)"/>
        public static unsafe void GetListenerfv(All param, ref float values)
        {
            fixed (float* values_ptr = &values)
            {
                GetListenerfv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetListeneri(All, int*)"/>
        public static unsafe void GetListeneri(All param, Span<int> value)
        {
            fixed (int* value_ptr = value)
            {
                GetListeneri(param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetListeneri(All, int*)"/>
        public static unsafe void GetListeneri(All param, int[] value)
        {
            fixed (int* value_ptr = value)
            {
                GetListeneri(param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetListeneri(All, int*)"/>
        public static unsafe void GetListeneri(All param, ref int value)
        {
            fixed (int* value_ptr = &value)
            {
                GetListeneri(param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetListeneriv(All, int*)"/>
        public static unsafe void GetListeneriv(All param, Span<int> values)
        {
            fixed (int* values_ptr = values)
            {
                GetListeneriv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetListeneriv(All, int*)"/>
        public static unsafe void GetListeneriv(All param, int[] values)
        {
            fixed (int* values_ptr = values)
            {
                GetListeneriv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetListeneriv(All, int*)"/>
        public static unsafe void GetListeneriv(All param, ref int values)
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
        /// <inheritdoc cref="GetSource3f(uint, All, float*, float*, float*)"/>
        public static unsafe void GetSource3f(uint source, All param, Span<float> value1, Span<float> value2, Span<float> value3)
        {
            fixed (float* value3_ptr = value3)
            {
                fixed (float* value2_ptr = value2)
                {
                    fixed (float* value1_ptr = value1)
                    {
                        GetSource3f(source, param, value1_ptr, value2_ptr, value3_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetSource3f(uint, All, float*, float*, float*)"/>
        public static unsafe void GetSource3f(uint source, All param, float[] value1, float[] value2, float[] value3)
        {
            fixed (float* value3_ptr = value3)
            {
                fixed (float* value2_ptr = value2)
                {
                    fixed (float* value1_ptr = value1)
                    {
                        GetSource3f(source, param, value1_ptr, value2_ptr, value3_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetSource3f(uint, All, float*, float*, float*)"/>
        public static unsafe void GetSource3f(uint source, All param, ref float value1, ref float value2, ref float value3)
        {
            fixed (float* value1_ptr = &value1)
            fixed (float* value2_ptr = &value2)
            fixed (float* value3_ptr = &value3)
            {
                GetSource3f(source, param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetSource3i(uint, All, int*, int*, int*)"/>
        public static unsafe void GetSource3i(uint source, All param, Span<int> value1, Span<int> value2, Span<int> value3)
        {
            fixed (int* value3_ptr = value3)
            {
                fixed (int* value2_ptr = value2)
                {
                    fixed (int* value1_ptr = value1)
                    {
                        GetSource3i(source, param, value1_ptr, value2_ptr, value3_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetSource3i(uint, All, int*, int*, int*)"/>
        public static unsafe void GetSource3i(uint source, All param, int[] value1, int[] value2, int[] value3)
        {
            fixed (int* value3_ptr = value3)
            {
                fixed (int* value2_ptr = value2)
                {
                    fixed (int* value1_ptr = value1)
                    {
                        GetSource3i(source, param, value1_ptr, value2_ptr, value3_ptr);
                    }
                }
            }
        }
        /// <inheritdoc cref="GetSource3i(uint, All, int*, int*, int*)"/>
        public static unsafe void GetSource3i(uint source, All param, ref int value1, ref int value2, ref int value3)
        {
            fixed (int* value1_ptr = &value1)
            fixed (int* value2_ptr = &value2)
            fixed (int* value3_ptr = &value3)
            {
                GetSource3i(source, param, value1_ptr, value2_ptr, value3_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcef(uint, All, float*)"/>
        public static unsafe void GetSourcef(uint source, All param, Span<float> value)
        {
            fixed (float* value_ptr = value)
            {
                GetSourcef(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcef(uint, All, float*)"/>
        public static unsafe void GetSourcef(uint source, All param, float[] value)
        {
            fixed (float* value_ptr = value)
            {
                GetSourcef(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcef(uint, All, float*)"/>
        public static unsafe void GetSourcef(uint source, All param, ref float value)
        {
            fixed (float* value_ptr = &value)
            {
                GetSourcef(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcefv(uint, All, float*)"/>
        public static unsafe void GetSourcefv(uint source, All param, Span<float> values)
        {
            fixed (float* values_ptr = values)
            {
                GetSourcefv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcefv(uint, All, float*)"/>
        public static unsafe void GetSourcefv(uint source, All param, float[] values)
        {
            fixed (float* values_ptr = values)
            {
                GetSourcefv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcefv(uint, All, float*)"/>
        public static unsafe void GetSourcefv(uint source, All param, ref float values)
        {
            fixed (float* values_ptr = &values)
            {
                GetSourcefv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcei(uint, All, int*)"/>
        public static unsafe void GetSourcei(uint source, All param, Span<int> value)
        {
            fixed (int* value_ptr = value)
            {
                GetSourcei(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcei(uint, All, int*)"/>
        public static unsafe void GetSourcei(uint source, All param, int[] value)
        {
            fixed (int* value_ptr = value)
            {
                GetSourcei(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetSourcei(uint, All, int*)"/>
        public static unsafe void GetSourcei(uint source, All param, ref int value)
        {
            fixed (int* value_ptr = &value)
            {
                GetSourcei(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="GetSourceiv(uint, All, int*)"/>
        public static unsafe void GetSourceiv(uint source, All param, Span<int> values)
        {
            fixed (int* values_ptr = values)
            {
                GetSourceiv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetSourceiv(uint, All, int*)"/>
        public static unsafe void GetSourceiv(uint source, All param, int[] values)
        {
            fixed (int* values_ptr = values)
            {
                GetSourceiv(source, param, values_ptr);
            }
        }
        /// <inheritdoc cref="GetSourceiv(uint, All, int*)"/>
        public static unsafe void GetSourceiv(uint source, All param, ref int values)
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
        /// <inheritdoc cref="Listenerfv(All, float*)"/>
        public static unsafe void Listenerfv(All param, Span<float> values)
        {
            fixed (float* values_ptr = values)
            {
                Listenerfv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="Listenerfv(All, float*)"/>
        public static unsafe void Listenerfv(All param, float[] values)
        {
            fixed (float* values_ptr = values)
            {
                Listenerfv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="Listenerfv(All, float*)"/>
        public static unsafe void Listenerfv(All param, ref float values)
        {
            fixed (float* values_ptr = &values)
            {
                Listenerfv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="Listeneriv(All, int*)"/>
        public static unsafe void Listeneriv(All param, Span<int> values)
        {
            fixed (int* values_ptr = values)
            {
                Listeneriv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="Listeneriv(All, int*)"/>
        public static unsafe void Listeneriv(All param, int[] values)
        {
            fixed (int* values_ptr = values)
            {
                Listeneriv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="Listeneriv(All, int*)"/>
        public static unsafe void Listeneriv(All param, ref int values)
        {
            fixed (int* values_ptr = &values)
            {
                Listeneriv(param, values_ptr);
            }
        }
        /// <inheritdoc cref="Sourcefv(uint, All, float*)"/>
        public static unsafe void Sourcefv(uint source, All param, ReadOnlySpan<float> value)
        {
            fixed (float* value_ptr = value)
            {
                Sourcefv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Sourcefv(uint, All, float*)"/>
        public static unsafe void Sourcefv(uint source, All param, float[] value)
        {
            fixed (float* value_ptr = value)
            {
                Sourcefv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Sourcefv(uint, All, float*)"/>
        public static unsafe void Sourcefv(uint source, All param, ref readonly float value)
        {
            fixed (float* value_ptr = &value)
            {
                Sourcefv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Sourceiv(uint, All, int*)"/>
        public static unsafe void Sourceiv(uint source, All param, ReadOnlySpan<int> value)
        {
            fixed (int* value_ptr = value)
            {
                Sourceiv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Sourceiv(uint, All, int*)"/>
        public static unsafe void Sourceiv(uint source, All param, int[] value)
        {
            fixed (int* value_ptr = value)
            {
                Sourceiv(source, param, value_ptr);
            }
        }
        /// <inheritdoc cref="Sourceiv(uint, All, int*)"/>
        public static unsafe void Sourceiv(uint source, All param, ref readonly int value)
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
            /// <inheritdoc cref="AuxiliaryEffectSlotfv(uint, All, float*)"/>
            public static unsafe void AuxiliaryEffectSlotfv(uint effectslot, All param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    AuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotfv(uint, All, float*)"/>
            public static unsafe void AuxiliaryEffectSlotfv(uint effectslot, All param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    AuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotfv(uint, All, float*)"/>
            public static unsafe void AuxiliaryEffectSlotfv(uint effectslot, All param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    AuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotiv(uint, All, int*)"/>
            public static unsafe void AuxiliaryEffectSlotiv(uint effectslot, All param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    AuxiliaryEffectSlotiv(effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotiv(uint, All, int*)"/>
            public static unsafe void AuxiliaryEffectSlotiv(uint effectslot, All param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    AuxiliaryEffectSlotiv(effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="AuxiliaryEffectSlotiv(uint, All, int*)"/>
            public static unsafe void AuxiliaryEffectSlotiv(uint effectslot, All param, ref int piValues)
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
            /// <inheritdoc cref="DebugMessageControlEXT(All, All, uint, int, uint*, bool)"/>
            public static unsafe void DebugMessageControlEXT(All source, All type, uint severity, int count, ReadOnlySpan<uint> ids, bool enable)
            {
                fixed (uint* ids_ptr = ids)
                {
                    DebugMessageControlEXT(source, type, severity, count, ids_ptr, enable);
                }
            }
            /// <inheritdoc cref="DebugMessageControlEXT(All, All, uint, int, uint*, bool)"/>
            public static unsafe void DebugMessageControlEXT(All source, All type, uint severity, int count, uint[] ids, bool enable)
            {
                fixed (uint* ids_ptr = ids)
                {
                    DebugMessageControlEXT(source, type, severity, count, ids_ptr, enable);
                }
            }
            /// <inheritdoc cref="DebugMessageControlEXT(All, All, uint, int, uint*, bool)"/>
            public static unsafe void DebugMessageControlEXT(All source, All type, uint severity, int count, ref readonly uint ids, bool enable)
            {
                fixed (uint* ids_ptr = &ids)
                {
                    DebugMessageControlEXT(source, type, severity, count, ids_ptr, enable);
                }
            }
            /// <inheritdoc cref="DebugMessageInsertEXT(All, All, uint, int, byte*)"/>
            public static unsafe void DebugMessageInsertEXT(All source, All type, uint severity, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                DebugMessageInsertEXT(source, type, severity, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
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
            /// <inheritdoc cref="Effectfv(uint, All, float*)"/>
            public static unsafe void Effectfv(uint effect, All param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    Effectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Effectfv(uint, All, float*)"/>
            public static unsafe void Effectfv(uint effect, All param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    Effectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Effectfv(uint, All, float*)"/>
            public static unsafe void Effectfv(uint effect, All param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    Effectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Effectiv(uint, All, int*)"/>
            public static unsafe void Effectiv(uint effect, All param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    Effectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="Effectiv(uint, All, int*)"/>
            public static unsafe void Effectiv(uint effect, All param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    Effectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="Effectiv(uint, All, int*)"/>
            public static unsafe void Effectiv(uint effect, All param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    Effectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="Filterfv(uint, All, float*)"/>
            public static unsafe void Filterfv(uint filter, All param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    Filterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Filterfv(uint, All, float*)"/>
            public static unsafe void Filterfv(uint filter, All param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    Filterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Filterfv(uint, All, float*)"/>
            public static unsafe void Filterfv(uint filter, All param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    Filterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="Filteriv(uint, All, int*)"/>
            public static unsafe void Filteriv(uint filter, All param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    Filteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="Filteriv(uint, All, int*)"/>
            public static unsafe void Filteriv(uint filter, All param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    Filteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="Filteriv(uint, All, int*)"/>
            public static unsafe void Filteriv(uint filter, All param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    Filteriv(filter, param, piValues_ptr);
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
            /// <inheritdoc cref="GetAuxiliaryEffectSlotf(uint, All, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotf(uint effectslot, All param, Span<float> pflValue)
            {
                fixed (float* pflValue_ptr = pflValue)
                {
                    GetAuxiliaryEffectSlotf(effectslot, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotf(uint, All, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotf(uint effectslot, All param, float[] pflValue)
            {
                fixed (float* pflValue_ptr = pflValue)
                {
                    GetAuxiliaryEffectSlotf(effectslot, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotf(uint, All, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotf(uint effectslot, All param, ref float pflValue)
            {
                fixed (float* pflValue_ptr = &pflValue)
                {
                    GetAuxiliaryEffectSlotf(effectslot, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotfv(uint, All, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotfv(uint effectslot, All param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetAuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotfv(uint, All, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotfv(uint effectslot, All param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetAuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotfv(uint, All, float*)"/>
            public static unsafe void GetAuxiliaryEffectSlotfv(uint effectslot, All param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    GetAuxiliaryEffectSlotfv(effectslot, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSloti(uint, All, int*)"/>
            public static unsafe void GetAuxiliaryEffectSloti(uint effectslot, All param, Span<int> piValue)
            {
                fixed (int* piValue_ptr = piValue)
                {
                    GetAuxiliaryEffectSloti(effectslot, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSloti(uint, All, int*)"/>
            public static unsafe void GetAuxiliaryEffectSloti(uint effectslot, All param, int[] piValue)
            {
                fixed (int* piValue_ptr = piValue)
                {
                    GetAuxiliaryEffectSloti(effectslot, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSloti(uint, All, int*)"/>
            public static unsafe void GetAuxiliaryEffectSloti(uint effectslot, All param, ref int piValue)
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    GetAuxiliaryEffectSloti(effectslot, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotiv(uint, All, int*)"/>
            public static unsafe void GetAuxiliaryEffectSlotiv(uint effectslot, All param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetAuxiliaryEffectSlotiv(effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotiv(uint, All, int*)"/>
            public static unsafe void GetAuxiliaryEffectSlotiv(uint effectslot, All param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetAuxiliaryEffectSlotiv(effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetAuxiliaryEffectSlotiv(uint, All, int*)"/>
            public static unsafe void GetAuxiliaryEffectSlotiv(uint effectslot, All param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    GetAuxiliaryEffectSlotiv(effectslot, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetDebugMessageLogEXT(uint, int, All*, All*, uint*, All*, int*, byte*)"/>
            public static unsafe uint GetDebugMessageLogEXT(uint count, int logBufSize, Span<All> sources, Span<All> types, Span<uint> ids, Span<All> severities, Span<int> lengths, byte* logBuf)
            {
                uint returnValue;
                fixed (int* lengths_ptr = lengths)
                {
                    fixed (All* severities_ptr = severities)
                    {
                        fixed (uint* ids_ptr = ids)
                        {
                            fixed (All* types_ptr = types)
                            {
                                fixed (All* sources_ptr = sources)
                                {
                                    returnValue = GetDebugMessageLogEXT(count, logBufSize, sources_ptr, types_ptr, ids_ptr, severities_ptr, lengths_ptr, logBuf);
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDebugMessageLogEXT(uint, int, All*, All*, uint*, All*, int*, byte*)"/>
            public static unsafe uint GetDebugMessageLogEXT(uint count, int logBufSize, All[] sources, All[] types, uint[] ids, All[] severities, int[] lengths, byte* logBuf)
            {
                uint returnValue;
                fixed (int* lengths_ptr = lengths)
                {
                    fixed (All* severities_ptr = severities)
                    {
                        fixed (uint* ids_ptr = ids)
                        {
                            fixed (All* types_ptr = types)
                            {
                                fixed (All* sources_ptr = sources)
                                {
                                    returnValue = GetDebugMessageLogEXT(count, logBufSize, sources_ptr, types_ptr, ids_ptr, severities_ptr, lengths_ptr, logBuf);
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDebugMessageLogEXT(uint, int, All*, All*, uint*, All*, int*, byte*)"/>
            public static unsafe uint GetDebugMessageLogEXT(uint count, int logBufSize, ref All sources, ref All types, ref uint ids, ref All severities, ref int lengths, byte* logBuf)
            {
                uint returnValue;
                fixed (All* sources_ptr = &sources)
                fixed (All* types_ptr = &types)
                fixed (uint* ids_ptr = &ids)
                fixed (All* severities_ptr = &severities)
                fixed (int* lengths_ptr = &lengths)
                {
                    returnValue = GetDebugMessageLogEXT(count, logBufSize, sources_ptr, types_ptr, ids_ptr, severities_ptr, lengths_ptr, logBuf);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetEffectf(uint, All, float*)"/>
            public static unsafe void GetEffectf(uint effect, All param, Span<float> pflValue)
            {
                fixed (float* pflValue_ptr = pflValue)
                {
                    GetEffectf(effect, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectf(uint, All, float*)"/>
            public static unsafe void GetEffectf(uint effect, All param, float[] pflValue)
            {
                fixed (float* pflValue_ptr = pflValue)
                {
                    GetEffectf(effect, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectf(uint, All, float*)"/>
            public static unsafe void GetEffectf(uint effect, All param, ref float pflValue)
            {
                fixed (float* pflValue_ptr = &pflValue)
                {
                    GetEffectf(effect, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectfv(uint, All, float*)"/>
            public static unsafe void GetEffectfv(uint effect, All param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetEffectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectfv(uint, All, float*)"/>
            public static unsafe void GetEffectfv(uint effect, All param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetEffectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectfv(uint, All, float*)"/>
            public static unsafe void GetEffectfv(uint effect, All param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    GetEffectfv(effect, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffecti(uint, All, int*)"/>
            public static unsafe void GetEffecti(uint effect, All param, Span<int> piValue)
            {
                fixed (int* piValue_ptr = piValue)
                {
                    GetEffecti(effect, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetEffecti(uint, All, int*)"/>
            public static unsafe void GetEffecti(uint effect, All param, int[] piValue)
            {
                fixed (int* piValue_ptr = piValue)
                {
                    GetEffecti(effect, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetEffecti(uint, All, int*)"/>
            public static unsafe void GetEffecti(uint effect, All param, ref int piValue)
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    GetEffecti(effect, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectiv(uint, All, int*)"/>
            public static unsafe void GetEffectiv(uint effect, All param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetEffectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectiv(uint, All, int*)"/>
            public static unsafe void GetEffectiv(uint effect, All param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetEffectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetEffectiv(uint, All, int*)"/>
            public static unsafe void GetEffectiv(uint effect, All param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    GetEffectiv(effect, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterf(uint, All, float*)"/>
            public static unsafe void GetFilterf(uint filter, All param, Span<float> pflValue)
            {
                fixed (float* pflValue_ptr = pflValue)
                {
                    GetFilterf(filter, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterf(uint, All, float*)"/>
            public static unsafe void GetFilterf(uint filter, All param, float[] pflValue)
            {
                fixed (float* pflValue_ptr = pflValue)
                {
                    GetFilterf(filter, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterf(uint, All, float*)"/>
            public static unsafe void GetFilterf(uint filter, All param, ref float pflValue)
            {
                fixed (float* pflValue_ptr = &pflValue)
                {
                    GetFilterf(filter, param, pflValue_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterfv(uint, All, float*)"/>
            public static unsafe void GetFilterfv(uint filter, All param, Span<float> pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetFilterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterfv(uint, All, float*)"/>
            public static unsafe void GetFilterfv(uint filter, All param, float[] pflValues)
            {
                fixed (float* pflValues_ptr = pflValues)
                {
                    GetFilterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilterfv(uint, All, float*)"/>
            public static unsafe void GetFilterfv(uint filter, All param, ref float pflValues)
            {
                fixed (float* pflValues_ptr = &pflValues)
                {
                    GetFilterfv(filter, param, pflValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilteri(uint, All, int*)"/>
            public static unsafe void GetFilteri(uint filter, All param, Span<int> piValue)
            {
                fixed (int* piValue_ptr = piValue)
                {
                    GetFilteri(filter, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetFilteri(uint, All, int*)"/>
            public static unsafe void GetFilteri(uint filter, All param, int[] piValue)
            {
                fixed (int* piValue_ptr = piValue)
                {
                    GetFilteri(filter, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetFilteri(uint, All, int*)"/>
            public static unsafe void GetFilteri(uint filter, All param, ref int piValue)
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    GetFilteri(filter, param, piValue_ptr);
                }
            }
            /// <inheritdoc cref="GetFilteriv(uint, All, int*)"/>
            public static unsafe void GetFilteriv(uint filter, All param, Span<int> piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetFilteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilteriv(uint, All, int*)"/>
            public static unsafe void GetFilteriv(uint filter, All param, int[] piValues)
            {
                fixed (int* piValues_ptr = piValues)
                {
                    GetFilteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetFilteriv(uint, All, int*)"/>
            public static unsafe void GetFilteriv(uint filter, All param, ref int piValues)
            {
                fixed (int* piValues_ptr = &piValues)
                {
                    GetFilteriv(filter, param, piValues_ptr);
                }
            }
            /// <inheritdoc cref="GetObjectLabelEXT(All, uint, int, int*, byte*)"/>
            public static unsafe void GetObjectLabelEXT(All identifier, uint name, int bufSize, Span<int> length, byte* label)
            {
                fixed (int* length_ptr = length)
                {
                    GetObjectLabelEXT(identifier, name, bufSize, length_ptr, label);
                }
            }
            /// <inheritdoc cref="GetObjectLabelEXT(All, uint, int, int*, byte*)"/>
            public static unsafe void GetObjectLabelEXT(All identifier, uint name, int bufSize, int[] length, byte* label)
            {
                fixed (int* length_ptr = length)
                {
                    GetObjectLabelEXT(identifier, name, bufSize, length_ptr, label);
                }
            }
            /// <inheritdoc cref="GetObjectLabelEXT(All, uint, int, int*, byte*)"/>
            public static unsafe void GetObjectLabelEXT(All identifier, uint name, int bufSize, ref int length, byte* label)
            {
                fixed (int* length_ptr = &length)
                {
                    GetObjectLabelEXT(identifier, name, bufSize, length_ptr, label);
                }
            }
            /// <inheritdoc cref="ObjectLabelEXT(All, uint, int, byte*)"/>
            public static unsafe void ObjectLabelEXT(All identifier, uint name, int length, string label)
            {
                byte* label_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(label);
                ObjectLabelEXT(identifier, name, length, label_ptr);
                Marshal.FreeCoTaskMem((IntPtr)label_ptr);
            }
            /// <inheritdoc cref="PushDebugGroupEXT(All, uint, int, byte*)"/>
            public static unsafe void PushDebugGroupEXT(All source, uint id, int length, string message)
            {
                byte* message_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(message);
                PushDebugGroupEXT(source, id, length, message_ptr);
                Marshal.FreeCoTaskMem((IntPtr)message_ptr);
            }
            /// <inheritdoc cref="RequestFoldbackStart(All, int, int, float*, delegate* unmanaged[Cdecl]<All, nuint, void>)"/>
            public static unsafe void RequestFoldbackStart(All foldbackMode, int blockCount, int blockLength, Span<float> bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback)
            {
                fixed (float* bufferMemory_ptr = bufferMemory)
                {
                    RequestFoldbackStart(foldbackMode, blockCount, blockLength, bufferMemory_ptr, callback);
                }
            }
            /// <inheritdoc cref="RequestFoldbackStart(All, int, int, float*, delegate* unmanaged[Cdecl]<All, nuint, void>)"/>
            public static unsafe void RequestFoldbackStart(All foldbackMode, int blockCount, int blockLength, float[] bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback)
            {
                fixed (float* bufferMemory_ptr = bufferMemory)
                {
                    RequestFoldbackStart(foldbackMode, blockCount, blockLength, bufferMemory_ptr, callback);
                }
            }
            /// <inheritdoc cref="RequestFoldbackStart(All, int, int, float*, delegate* unmanaged[Cdecl]<All, nuint, void>)"/>
            public static unsafe void RequestFoldbackStart(All foldbackMode, int blockCount, int blockLength, ref float bufferMemory, delegate* unmanaged[Cdecl]<All, nuint, void> callback)
            {
                fixed (float* bufferMemory_ptr = &bufferMemory)
                {
                    RequestFoldbackStart(foldbackMode, blockCount, blockLength, bufferMemory_ptr, callback);
                }
            }
            /// <inheritdoc cref="SourceAddNotification(uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe All SourceAddNotification(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, IntPtr userData)
            {
                All returnValue;
                void* userData_vptr = (void*)userData;
                returnValue = SourceAddNotification(sid, notificationID, notifyProc, userData_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="SourceAddNotification(uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe All SourceAddNotification<T1>(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, Span<T1> userData)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* userData_ptr = userData)
                {
                    returnValue = SourceAddNotification(sid, notificationID, notifyProc, userData_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SourceAddNotification(uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe All SourceAddNotification<T1>(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, T1[] userData)
                where T1 : unmanaged
            {
                All returnValue;
                fixed (void* userData_ptr = userData)
                {
                    returnValue = SourceAddNotification(sid, notificationID, notifyProc, userData_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SourceAddNotification(uint, uint, delegate* unmanaged[Cdecl]<uint, uint, void*, void>, void*)"/>
            public static unsafe All SourceAddNotification<T1>(uint sid, uint notificationID, delegate* unmanaged[Cdecl]<uint, uint, void*, void> notifyProc, ref T1 userData)
                where T1 : unmanaged
            {
                All returnValue;
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
            /// <inheritdoc cref="BufferCallbackSOFT(uint, All, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*)"/>
            public static unsafe void BufferCallbackSOFT(uint buffer, All format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, IntPtr userptr)
            {
                void* userptr_vptr = (void*)userptr;
                BufferCallbackSOFT(buffer, format, freq, callback, userptr_vptr);
            }
            /// <inheritdoc cref="BufferCallbackSOFT(uint, All, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*)"/>
            public static unsafe void BufferCallbackSOFT<T1>(uint buffer, All format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, Span<T1> userptr)
                where T1 : unmanaged
            {
                fixed (void* userptr_ptr = userptr)
                {
                    BufferCallbackSOFT(buffer, format, freq, callback, userptr_ptr);
                }
            }
            /// <inheritdoc cref="BufferCallbackSOFT(uint, All, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*)"/>
            public static unsafe void BufferCallbackSOFT<T1>(uint buffer, All format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, T1[] userptr)
                where T1 : unmanaged
            {
                fixed (void* userptr_ptr = userptr)
                {
                    BufferCallbackSOFT(buffer, format, freq, callback, userptr_ptr);
                }
            }
            /// <inheritdoc cref="BufferCallbackSOFT(uint, All, int, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint>, void*)"/>
            public static unsafe void BufferCallbackSOFT<T1>(uint buffer, All format, int freq, delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> callback, ref T1 userptr)
                where T1 : unmanaged
            {
                fixed (void* userptr_ptr = &userptr)
                {
                    BufferCallbackSOFT(buffer, format, freq, callback, userptr_ptr);
                }
            }
            /// <inheritdoc cref="BufferSamplesSOFT(uint, uint, All, int, All, All, void*)"/>
            public static unsafe void BufferSamplesSOFT(uint buffer, uint samplerate, All internalformat, int samples, All channels, All type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                BufferSamplesSOFT(buffer, samplerate, internalformat, samples, channels, type, data_vptr);
            }
            /// <inheritdoc cref="BufferSamplesSOFT(uint, uint, All, int, All, All, void*)"/>
            public static unsafe void BufferSamplesSOFT<T1>(uint buffer, uint samplerate, All internalformat, int samples, All channels, All type, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSamplesSOFT(buffer, samplerate, internalformat, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSamplesSOFT(uint, uint, All, int, All, All, void*)"/>
            public static unsafe void BufferSamplesSOFT<T1>(uint buffer, uint samplerate, All internalformat, int samples, All channels, All type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSamplesSOFT(buffer, samplerate, internalformat, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSamplesSOFT(uint, uint, All, int, All, All, void*)"/>
            public static unsafe void BufferSamplesSOFT<T1>(uint buffer, uint samplerate, All internalformat, int samples, All channels, All type, ref readonly T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    BufferSamplesSOFT(buffer, samplerate, internalformat, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSubDataSOFT(uint, All, void*, int, int)"/>
            public static unsafe void BufferSubDataSOFT(uint buffer, All format, IntPtr data, int offset, int length)
            {
                void* data_vptr = (void*)data;
                BufferSubDataSOFT(buffer, format, data_vptr, offset, length);
            }
            /// <inheritdoc cref="BufferSubDataSOFT(uint, All, void*, int, int)"/>
            public static unsafe void BufferSubDataSOFT<T1>(uint buffer, All format, ReadOnlySpan<T1> data, int offset, int length)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubDataSOFT(buffer, format, data_ptr, offset, length);
                }
            }
            /// <inheritdoc cref="BufferSubDataSOFT(uint, All, void*, int, int)"/>
            public static unsafe void BufferSubDataSOFT<T1>(uint buffer, All format, T1[] data, int offset, int length)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubDataSOFT(buffer, format, data_ptr, offset, length);
                }
            }
            /// <inheritdoc cref="BufferSubDataSOFT(uint, All, void*, int, int)"/>
            public static unsafe void BufferSubDataSOFT<T1>(uint buffer, All format, ref readonly T1 data, int offset, int length)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    BufferSubDataSOFT(buffer, format, data_ptr, offset, length);
                }
            }
            /// <inheritdoc cref="BufferSubSamplesSOFT(uint, int, int, All, All, void*)"/>
            public static unsafe void BufferSubSamplesSOFT(uint buffer, int offset, int samples, All channels, All type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                BufferSubSamplesSOFT(buffer, offset, samples, channels, type, data_vptr);
            }
            /// <inheritdoc cref="BufferSubSamplesSOFT(uint, int, int, All, All, void*)"/>
            public static unsafe void BufferSubSamplesSOFT<T1>(uint buffer, int offset, int samples, All channels, All type, ReadOnlySpan<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSubSamplesSOFT(uint, int, int, All, All, void*)"/>
            public static unsafe void BufferSubSamplesSOFT<T1>(uint buffer, int offset, int samples, All channels, All type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    BufferSubSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="BufferSubSamplesSOFT(uint, int, int, All, All, void*)"/>
            public static unsafe void BufferSubSamplesSOFT<T1>(uint buffer, int offset, int samples, All channels, All type, ref readonly T1 data)
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
            /// <inheritdoc cref="EventControlSOFT(int, All*, bool)"/>
            public static unsafe void EventControlSOFT(int count, ReadOnlySpan<All> types, bool enable)
            {
                fixed (All* types_ptr = types)
                {
                    EventControlSOFT(count, types_ptr, enable);
                }
            }
            /// <inheritdoc cref="EventControlSOFT(int, All*, bool)"/>
            public static unsafe void EventControlSOFT(int count, All[] types, bool enable)
            {
                fixed (All* types_ptr = types)
                {
                    EventControlSOFT(count, types_ptr, enable);
                }
            }
            /// <inheritdoc cref="EventControlSOFT(int, All*, bool)"/>
            public static unsafe void EventControlSOFT(int count, ref readonly All types, bool enable)
            {
                fixed (All* types_ptr = &types)
                {
                    EventControlSOFT(count, types_ptr, enable);
                }
            }
            /// <inheritdoc cref="GetBufferSamplesSOFT(uint, int, int, All, All, void*)"/>
            public static unsafe void GetBufferSamplesSOFT(uint buffer, int offset, int samples, All channels, All type, IntPtr data)
            {
                void* data_vptr = (void*)data;
                GetBufferSamplesSOFT(buffer, offset, samples, channels, type, data_vptr);
            }
            /// <inheritdoc cref="GetBufferSamplesSOFT(uint, int, int, All, All, void*)"/>
            public static unsafe void GetBufferSamplesSOFT<T1>(uint buffer, int offset, int samples, All channels, All type, Span<T1> data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    GetBufferSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferSamplesSOFT(uint, int, int, All, All, void*)"/>
            public static unsafe void GetBufferSamplesSOFT<T1>(uint buffer, int offset, int samples, All channels, All type, T1[] data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = data)
                {
                    GetBufferSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="GetBufferSamplesSOFT(uint, int, int, All, All, void*)"/>
            public static unsafe void GetBufferSamplesSOFT<T1>(uint buffer, int offset, int samples, All channels, All type, ref T1 data)
                where T1 : unmanaged
            {
                fixed (void* data_ptr = &data)
                {
                    GetBufferSamplesSOFT(buffer, offset, samples, channels, type, data_ptr);
                }
            }
            /// <inheritdoc cref="GetSource3dSOFT(uint, All, double*, double*, double*)"/>
            public static unsafe void GetSource3dSOFT(uint source, All param, Span<double> value1, Span<double> value2, Span<double> value3)
            {
                fixed (double* value3_ptr = value3)
                {
                    fixed (double* value2_ptr = value2)
                    {
                        fixed (double* value1_ptr = value1)
                        {
                            GetSource3dSOFT(source, param, value1_ptr, value2_ptr, value3_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetSource3dSOFT(uint, All, double*, double*, double*)"/>
            public static unsafe void GetSource3dSOFT(uint source, All param, double[] value1, double[] value2, double[] value3)
            {
                fixed (double* value3_ptr = value3)
                {
                    fixed (double* value2_ptr = value2)
                    {
                        fixed (double* value1_ptr = value1)
                        {
                            GetSource3dSOFT(source, param, value1_ptr, value2_ptr, value3_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetSource3dSOFT(uint, All, double*, double*, double*)"/>
            public static unsafe void GetSource3dSOFT(uint source, All param, ref double value1, ref double value2, ref double value3)
            {
                fixed (double* value1_ptr = &value1)
                fixed (double* value2_ptr = &value2)
                fixed (double* value3_ptr = &value3)
                {
                    GetSource3dSOFT(source, param, value1_ptr, value2_ptr, value3_ptr);
                }
            }
            /// <inheritdoc cref="GetSource3i64SOFT(uint, All, long*, long*, long*)"/>
            public static unsafe void GetSource3i64SOFT(uint source, All param, Span<long> value1, Span<long> value2, Span<long> value3)
            {
                fixed (long* value3_ptr = value3)
                {
                    fixed (long* value2_ptr = value2)
                    {
                        fixed (long* value1_ptr = value1)
                        {
                            GetSource3i64SOFT(source, param, value1_ptr, value2_ptr, value3_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetSource3i64SOFT(uint, All, long*, long*, long*)"/>
            public static unsafe void GetSource3i64SOFT(uint source, All param, long[] value1, long[] value2, long[] value3)
            {
                fixed (long* value3_ptr = value3)
                {
                    fixed (long* value2_ptr = value2)
                    {
                        fixed (long* value1_ptr = value1)
                        {
                            GetSource3i64SOFT(source, param, value1_ptr, value2_ptr, value3_ptr);
                        }
                    }
                }
            }
            /// <inheritdoc cref="GetSource3i64SOFT(uint, All, long*, long*, long*)"/>
            public static unsafe void GetSource3i64SOFT(uint source, All param, ref long value1, ref long value2, ref long value3)
            {
                fixed (long* value1_ptr = &value1)
                fixed (long* value2_ptr = &value2)
                fixed (long* value3_ptr = &value3)
                {
                    GetSource3i64SOFT(source, param, value1_ptr, value2_ptr, value3_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedSOFT(uint, All, double*)"/>
            public static unsafe void GetSourcedSOFT(uint source, All param, Span<double> value)
            {
                fixed (double* value_ptr = value)
                {
                    GetSourcedSOFT(source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedSOFT(uint, All, double*)"/>
            public static unsafe void GetSourcedSOFT(uint source, All param, double[] value)
            {
                fixed (double* value_ptr = value)
                {
                    GetSourcedSOFT(source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedSOFT(uint, All, double*)"/>
            public static unsafe void GetSourcedSOFT(uint source, All param, ref double value)
            {
                fixed (double* value_ptr = &value)
                {
                    GetSourcedSOFT(source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedvSOFT(uint, All, double*)"/>
            public static unsafe void GetSourcedvSOFT(uint source, All param, Span<double> values)
            {
                fixed (double* values_ptr = values)
                {
                    GetSourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedvSOFT(uint, All, double*)"/>
            public static unsafe void GetSourcedvSOFT(uint source, All param, double[] values)
            {
                fixed (double* values_ptr = values)
                {
                    GetSourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcedvSOFT(uint, All, double*)"/>
            public static unsafe void GetSourcedvSOFT(uint source, All param, ref double values)
            {
                fixed (double* values_ptr = &values)
                {
                    GetSourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64SOFT(uint, All, long*)"/>
            public static unsafe void GetSourcei64SOFT(uint source, All param, Span<long> value)
            {
                fixed (long* value_ptr = value)
                {
                    GetSourcei64SOFT(source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64SOFT(uint, All, long*)"/>
            public static unsafe void GetSourcei64SOFT(uint source, All param, long[] value)
            {
                fixed (long* value_ptr = value)
                {
                    GetSourcei64SOFT(source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64SOFT(uint, All, long*)"/>
            public static unsafe void GetSourcei64SOFT(uint source, All param, ref long value)
            {
                fixed (long* value_ptr = &value)
                {
                    GetSourcei64SOFT(source, param, value_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64vSOFT(uint, All, long*)"/>
            public static unsafe void GetSourcei64vSOFT(uint source, All param, Span<long> values)
            {
                fixed (long* values_ptr = values)
                {
                    GetSourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64vSOFT(uint, All, long*)"/>
            public static unsafe void GetSourcei64vSOFT(uint source, All param, long[] values)
            {
                fixed (long* values_ptr = values)
                {
                    GetSourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetSourcei64vSOFT(uint, All, long*)"/>
            public static unsafe void GetSourcei64vSOFT(uint source, All param, ref long values)
            {
                fixed (long* values_ptr = &values)
                {
                    GetSourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="GetStringiSOFT_(All, int)"/>
            public static unsafe string? GetStringiSOFT(All pname, int index)
            {
                string? returnValue_str;
                byte* returnValue;
                returnValue = GetStringiSOFT_(pname, index);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="SourcedvSOFT(uint, All, double*)"/>
            public static unsafe void SourcedvSOFT(uint source, All param, ReadOnlySpan<double> values)
            {
                fixed (double* values_ptr = values)
                {
                    SourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="SourcedvSOFT(uint, All, double*)"/>
            public static unsafe void SourcedvSOFT(uint source, All param, double[] values)
            {
                fixed (double* values_ptr = values)
                {
                    SourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="SourcedvSOFT(uint, All, double*)"/>
            public static unsafe void SourcedvSOFT(uint source, All param, ref readonly double values)
            {
                fixed (double* values_ptr = &values)
                {
                    SourcedvSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="Sourcei64vSOFT(uint, All, long*)"/>
            public static unsafe void Sourcei64vSOFT(uint source, All param, ReadOnlySpan<long> values)
            {
                fixed (long* values_ptr = values)
                {
                    Sourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="Sourcei64vSOFT(uint, All, long*)"/>
            public static unsafe void Sourcei64vSOFT(uint source, All param, long[] values)
            {
                fixed (long* values_ptr = values)
                {
                    Sourcei64vSOFT(source, param, values_ptr);
                }
            }
            /// <inheritdoc cref="Sourcei64vSOFT(uint, All, long*)"/>
            public static unsafe void Sourcei64vSOFT(uint source, All param, ref readonly long values)
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

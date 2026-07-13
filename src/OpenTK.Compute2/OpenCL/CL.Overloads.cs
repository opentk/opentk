// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Core.Native;
using OpenTK.Mathematics;
using OpenTK.Compute2;

namespace OpenTK.Compute2.OpenCL
{
    public static unsafe partial class CL
    {
        /// <inheritdoc cref="BuildProgram(IntPtr, uint, IntPtr*, byte*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int BuildProgram(IntPtr program, uint num_devices, Span<IntPtr> device_list, string options, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, IntPtr user_data)
        {
            int returnValue;
            fixed (IntPtr* device_list_ptr = device_list)
            {
                byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                void* user_data_vptr = (void*)user_data;
                returnValue = BuildProgram(program, num_devices, device_list_ptr, options_ptr, pfn_notify, user_data_vptr);
                Marshal.FreeCoTaskMem((IntPtr)options_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="BuildProgram(IntPtr, uint, IntPtr*, byte*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int BuildProgram(IntPtr program, uint num_devices, IntPtr[] device_list, string options, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, IntPtr user_data)
        {
            int returnValue;
            fixed (IntPtr* device_list_ptr = device_list)
            {
                byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                void* user_data_vptr = (void*)user_data;
                returnValue = BuildProgram(program, num_devices, device_list_ptr, options_ptr, pfn_notify, user_data_vptr);
                Marshal.FreeCoTaskMem((IntPtr)options_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="BuildProgram(IntPtr, uint, IntPtr*, byte*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int BuildProgram(IntPtr program, uint num_devices, ref IntPtr device_list, string options, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, IntPtr user_data)
        {
            int returnValue;
            fixed (IntPtr* device_list_ptr = &device_list)
            {
                byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                void* user_data_vptr = (void*)user_data;
                returnValue = BuildProgram(program, num_devices, device_list_ptr, options_ptr, pfn_notify, user_data_vptr);
                Marshal.FreeCoTaskMem((IntPtr)options_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="BuildProgram(IntPtr, uint, IntPtr*, byte*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int BuildProgram<T1>(IntPtr program, uint num_devices, Span<IntPtr> device_list, string options, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, Span<T1> user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = user_data)
            {
                fixed (IntPtr* device_list_ptr = device_list)
                {
                    byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                    returnValue = BuildProgram(program, num_devices, device_list_ptr, options_ptr, pfn_notify, user_data_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)options_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="BuildProgram(IntPtr, uint, IntPtr*, byte*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int BuildProgram<T1>(IntPtr program, uint num_devices, IntPtr[] device_list, string options, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, T1[] user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = user_data)
            {
                fixed (IntPtr* device_list_ptr = device_list)
                {
                    byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                    returnValue = BuildProgram(program, num_devices, device_list_ptr, options_ptr, pfn_notify, user_data_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)options_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="BuildProgram(IntPtr, uint, IntPtr*, byte*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int BuildProgram<T1>(IntPtr program, uint num_devices, ref IntPtr device_list, string options, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, ref T1 user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* device_list_ptr = &device_list)
            fixed (void* user_data_ptr = &user_data)
            {
                byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                returnValue = BuildProgram(program, num_devices, device_list_ptr, options_ptr, pfn_notify, user_data_ptr);
                Marshal.FreeCoTaskMem((IntPtr)options_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CloneKernel(IntPtr, int*)"/>
        public static unsafe IntPtr CloneKernel(IntPtr source_kernel, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                returnValue = CloneKernel(source_kernel, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CloneKernel(IntPtr, int*)"/>
        public static unsafe IntPtr CloneKernel(IntPtr source_kernel, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                returnValue = CloneKernel(source_kernel, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CloneKernel(IntPtr, int*)"/>
        public static unsafe IntPtr CloneKernel(IntPtr source_kernel, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CloneKernel(source_kernel, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CompileProgram(IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, byte**, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int CompileProgram(IntPtr program, uint num_devices, Span<IntPtr> device_list, string options, uint num_input_headers, Span<IntPtr> input_headers, string[] header_include_names, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, IntPtr user_data)
        {
            int returnValue;
            fixed (IntPtr* input_headers_ptr = input_headers)
            {
                fixed (IntPtr* device_list_ptr = device_list)
                {
                    byte** header_include_names_ptr = (byte**)MarshalTk.StringArrayToCoTaskMemUTF8(header_include_names);
                    byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                    void* user_data_vptr = (void*)user_data;
                    returnValue = CompileProgram(program, num_devices, device_list_ptr, options_ptr, num_input_headers, input_headers_ptr, header_include_names_ptr, pfn_notify, user_data_vptr);
                    Marshal.FreeCoTaskMem((IntPtr)options_ptr);
                    MarshalTk.FreeStringArrayCoTaskMem((IntPtr)header_include_names_ptr, header_include_names.Length);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CompileProgram(IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, byte**, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int CompileProgram(IntPtr program, uint num_devices, IntPtr[] device_list, string options, uint num_input_headers, IntPtr[] input_headers, string[] header_include_names, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, IntPtr user_data)
        {
            int returnValue;
            fixed (IntPtr* input_headers_ptr = input_headers)
            {
                fixed (IntPtr* device_list_ptr = device_list)
                {
                    byte** header_include_names_ptr = (byte**)MarshalTk.StringArrayToCoTaskMemUTF8(header_include_names);
                    byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                    void* user_data_vptr = (void*)user_data;
                    returnValue = CompileProgram(program, num_devices, device_list_ptr, options_ptr, num_input_headers, input_headers_ptr, header_include_names_ptr, pfn_notify, user_data_vptr);
                    Marshal.FreeCoTaskMem((IntPtr)options_ptr);
                    MarshalTk.FreeStringArrayCoTaskMem((IntPtr)header_include_names_ptr, header_include_names.Length);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CompileProgram(IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, byte**, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int CompileProgram(IntPtr program, uint num_devices, ref IntPtr device_list, string options, uint num_input_headers, ref IntPtr input_headers, string[] header_include_names, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, IntPtr user_data)
        {
            int returnValue;
            fixed (IntPtr* device_list_ptr = &device_list)
            fixed (IntPtr* input_headers_ptr = &input_headers)
            {
                byte** header_include_names_ptr = (byte**)MarshalTk.StringArrayToCoTaskMemUTF8(header_include_names);
                byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                void* user_data_vptr = (void*)user_data;
                returnValue = CompileProgram(program, num_devices, device_list_ptr, options_ptr, num_input_headers, input_headers_ptr, header_include_names_ptr, pfn_notify, user_data_vptr);
                Marshal.FreeCoTaskMem((IntPtr)options_ptr);
                MarshalTk.FreeStringArrayCoTaskMem((IntPtr)header_include_names_ptr, header_include_names.Length);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CompileProgram(IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, byte**, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int CompileProgram<T1>(IntPtr program, uint num_devices, Span<IntPtr> device_list, string options, uint num_input_headers, Span<IntPtr> input_headers, string[] header_include_names, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, Span<T1> user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = user_data)
            {
                fixed (IntPtr* input_headers_ptr = input_headers)
                {
                    fixed (IntPtr* device_list_ptr = device_list)
                    {
                        byte** header_include_names_ptr = (byte**)MarshalTk.StringArrayToCoTaskMemUTF8(header_include_names);
                        byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                        returnValue = CompileProgram(program, num_devices, device_list_ptr, options_ptr, num_input_headers, input_headers_ptr, header_include_names_ptr, pfn_notify, user_data_ptr);
                        Marshal.FreeCoTaskMem((IntPtr)options_ptr);
                        MarshalTk.FreeStringArrayCoTaskMem((IntPtr)header_include_names_ptr, header_include_names.Length);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CompileProgram(IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, byte**, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int CompileProgram<T1>(IntPtr program, uint num_devices, IntPtr[] device_list, string options, uint num_input_headers, IntPtr[] input_headers, string[] header_include_names, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, T1[] user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = user_data)
            {
                fixed (IntPtr* input_headers_ptr = input_headers)
                {
                    fixed (IntPtr* device_list_ptr = device_list)
                    {
                        byte** header_include_names_ptr = (byte**)MarshalTk.StringArrayToCoTaskMemUTF8(header_include_names);
                        byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                        returnValue = CompileProgram(program, num_devices, device_list_ptr, options_ptr, num_input_headers, input_headers_ptr, header_include_names_ptr, pfn_notify, user_data_ptr);
                        Marshal.FreeCoTaskMem((IntPtr)options_ptr);
                        MarshalTk.FreeStringArrayCoTaskMem((IntPtr)header_include_names_ptr, header_include_names.Length);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CompileProgram(IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, byte**, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int CompileProgram<T1>(IntPtr program, uint num_devices, ref IntPtr device_list, string options, uint num_input_headers, ref IntPtr input_headers, string[] header_include_names, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, ref T1 user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* device_list_ptr = &device_list)
            fixed (IntPtr* input_headers_ptr = &input_headers)
            fixed (void* user_data_ptr = &user_data)
            {
                byte** header_include_names_ptr = (byte**)MarshalTk.StringArrayToCoTaskMemUTF8(header_include_names);
                byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                returnValue = CompileProgram(program, num_devices, device_list_ptr, options_ptr, num_input_headers, input_headers_ptr, header_include_names_ptr, pfn_notify, user_data_ptr);
                Marshal.FreeCoTaskMem((IntPtr)options_ptr);
                MarshalTk.FreeStringArrayCoTaskMem((IntPtr)header_include_names_ptr, header_include_names.Length);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateBuffer(IntPtr, MemFlags, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateBuffer(IntPtr context, MemFlags flags, nuint size, IntPtr host_ptr, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                void* host_ptr_vptr = (void*)host_ptr;
                returnValue = CreateBuffer(context, flags, size, host_ptr_vptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateBuffer(IntPtr, MemFlags, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateBuffer(IntPtr context, MemFlags flags, nuint size, IntPtr host_ptr, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                void* host_ptr_vptr = (void*)host_ptr;
                returnValue = CreateBuffer(context, flags, size, host_ptr_vptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateBuffer(IntPtr, MemFlags, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateBuffer(IntPtr context, MemFlags flags, nuint size, IntPtr host_ptr, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                void* host_ptr_vptr = (void*)host_ptr;
                returnValue = CreateBuffer(context, flags, size, host_ptr_vptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateBuffer(IntPtr, MemFlags, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateBuffer<T1>(IntPtr context, MemFlags flags, nuint size, Span<T1> host_ptr, Span<int> errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* host_ptr_ptr = host_ptr)
                {
                    returnValue = CreateBuffer(context, flags, size, host_ptr_ptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateBuffer(IntPtr, MemFlags, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateBuffer<T1>(IntPtr context, MemFlags flags, nuint size, T1[] host_ptr, int[] errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* host_ptr_ptr = host_ptr)
                {
                    returnValue = CreateBuffer(context, flags, size, host_ptr_ptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateBuffer(IntPtr, MemFlags, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateBuffer<T1>(IntPtr context, MemFlags flags, nuint size, ref T1 host_ptr, ref int errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (void* host_ptr_ptr = &host_ptr)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreateBuffer(context, flags, size, host_ptr_ptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateBufferWithProperties(IntPtr, ulong*, MemFlags, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateBufferWithProperties(IntPtr context, Span<ulong> properties, MemFlags flags, nuint size, IntPtr host_ptr, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (ulong* properties_ptr = properties)
                {
                    void* host_ptr_vptr = (void*)host_ptr;
                    returnValue = CreateBufferWithProperties(context, properties_ptr, flags, size, host_ptr_vptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateBufferWithProperties(IntPtr, ulong*, MemFlags, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateBufferWithProperties(IntPtr context, ulong[] properties, MemFlags flags, nuint size, IntPtr host_ptr, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (ulong* properties_ptr = properties)
                {
                    void* host_ptr_vptr = (void*)host_ptr;
                    returnValue = CreateBufferWithProperties(context, properties_ptr, flags, size, host_ptr_vptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateBufferWithProperties(IntPtr, ulong*, MemFlags, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateBufferWithProperties(IntPtr context, ref ulong properties, MemFlags flags, nuint size, IntPtr host_ptr, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (ulong* properties_ptr = &properties)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                void* host_ptr_vptr = (void*)host_ptr;
                returnValue = CreateBufferWithProperties(context, properties_ptr, flags, size, host_ptr_vptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateBufferWithProperties(IntPtr, ulong*, MemFlags, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateBufferWithProperties<T1>(IntPtr context, Span<ulong> properties, MemFlags flags, nuint size, Span<T1> host_ptr, Span<int> errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* host_ptr_ptr = host_ptr)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = CreateBufferWithProperties(context, properties_ptr, flags, size, host_ptr_ptr, errcode_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateBufferWithProperties(IntPtr, ulong*, MemFlags, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateBufferWithProperties<T1>(IntPtr context, ulong[] properties, MemFlags flags, nuint size, T1[] host_ptr, int[] errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* host_ptr_ptr = host_ptr)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = CreateBufferWithProperties(context, properties_ptr, flags, size, host_ptr_ptr, errcode_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateBufferWithProperties(IntPtr, ulong*, MemFlags, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateBufferWithProperties<T1>(IntPtr context, ref ulong properties, MemFlags flags, nuint size, ref T1 host_ptr, ref int errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (ulong* properties_ptr = &properties)
            fixed (void* host_ptr_ptr = &host_ptr)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreateBufferWithProperties(context, properties_ptr, flags, size, host_ptr_ptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateCommandQueue(IntPtr, IntPtr, CommandQueueProperties, int*)"/>
        public static unsafe IntPtr CreateCommandQueue(IntPtr context, IntPtr device, CommandQueueProperties properties, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                returnValue = CreateCommandQueue(context, device, properties, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateCommandQueue(IntPtr, IntPtr, CommandQueueProperties, int*)"/>
        public static unsafe IntPtr CreateCommandQueue(IntPtr context, IntPtr device, CommandQueueProperties properties, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                returnValue = CreateCommandQueue(context, device, properties, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateCommandQueue(IntPtr, IntPtr, CommandQueueProperties, int*)"/>
        public static unsafe IntPtr CreateCommandQueue(IntPtr context, IntPtr device, CommandQueueProperties properties, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreateCommandQueue(context, device, properties, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateCommandQueueWithProperties(IntPtr, IntPtr, ulong*, int*)"/>
        public static unsafe IntPtr CreateCommandQueueWithProperties(IntPtr context, IntPtr device, Span<ulong> properties, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (ulong* properties_ptr = properties)
                {
                    returnValue = CreateCommandQueueWithProperties(context, device, properties_ptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateCommandQueueWithProperties(IntPtr, IntPtr, ulong*, int*)"/>
        public static unsafe IntPtr CreateCommandQueueWithProperties(IntPtr context, IntPtr device, ulong[] properties, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (ulong* properties_ptr = properties)
                {
                    returnValue = CreateCommandQueueWithProperties(context, device, properties_ptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateCommandQueueWithProperties(IntPtr, IntPtr, ulong*, int*)"/>
        public static unsafe IntPtr CreateCommandQueueWithProperties(IntPtr context, IntPtr device, ref ulong properties, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (ulong* properties_ptr = &properties)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreateCommandQueueWithProperties(context, device, properties_ptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContext(IntPtr*, uint, IntPtr*, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*)"/>
        public static unsafe IntPtr CreateContext(Span<IntPtr> properties, uint num_devices, Span<IntPtr> devices, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, IntPtr user_data, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (IntPtr* devices_ptr = devices)
                {
                    fixed (IntPtr* properties_ptr = properties)
                    {
                        void* user_data_vptr = (void*)user_data;
                        returnValue = CreateContext(properties_ptr, num_devices, devices_ptr, pfn_notify, user_data_vptr, errcode_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContext(IntPtr*, uint, IntPtr*, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*)"/>
        public static unsafe IntPtr CreateContext(IntPtr[] properties, uint num_devices, IntPtr[] devices, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, IntPtr user_data, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (IntPtr* devices_ptr = devices)
                {
                    fixed (IntPtr* properties_ptr = properties)
                    {
                        void* user_data_vptr = (void*)user_data;
                        returnValue = CreateContext(properties_ptr, num_devices, devices_ptr, pfn_notify, user_data_vptr, errcode_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContext(IntPtr*, uint, IntPtr*, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*)"/>
        public static unsafe IntPtr CreateContext(ref IntPtr properties, uint num_devices, ref IntPtr devices, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, IntPtr user_data, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (IntPtr* properties_ptr = &properties)
            fixed (IntPtr* devices_ptr = &devices)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                void* user_data_vptr = (void*)user_data;
                returnValue = CreateContext(properties_ptr, num_devices, devices_ptr, pfn_notify, user_data_vptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContext(IntPtr*, uint, IntPtr*, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*)"/>
        public static unsafe IntPtr CreateContext<T1>(Span<IntPtr> properties, uint num_devices, Span<IntPtr> devices, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, Span<T1> user_data, Span<int> errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* user_data_ptr = user_data)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        fixed (IntPtr* properties_ptr = properties)
                        {
                            returnValue = CreateContext(properties_ptr, num_devices, devices_ptr, pfn_notify, user_data_ptr, errcode_ret_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContext(IntPtr*, uint, IntPtr*, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*)"/>
        public static unsafe IntPtr CreateContext<T1>(IntPtr[] properties, uint num_devices, IntPtr[] devices, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, T1[] user_data, int[] errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* user_data_ptr = user_data)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        fixed (IntPtr* properties_ptr = properties)
                        {
                            returnValue = CreateContext(properties_ptr, num_devices, devices_ptr, pfn_notify, user_data_ptr, errcode_ret_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContext(IntPtr*, uint, IntPtr*, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*)"/>
        public static unsafe IntPtr CreateContext<T1>(ref IntPtr properties, uint num_devices, ref IntPtr devices, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, ref T1 user_data, ref int errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (IntPtr* properties_ptr = &properties)
            fixed (IntPtr* devices_ptr = &devices)
            fixed (void* user_data_ptr = &user_data)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreateContext(properties_ptr, num_devices, devices_ptr, pfn_notify, user_data_ptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContextFromType(IntPtr*, DeviceType, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*)"/>
        public static unsafe IntPtr CreateContextFromType(Span<IntPtr> properties, DeviceType device_type, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, IntPtr user_data, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (IntPtr* properties_ptr = properties)
                {
                    void* user_data_vptr = (void*)user_data;
                    returnValue = CreateContextFromType(properties_ptr, device_type, pfn_notify, user_data_vptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContextFromType(IntPtr*, DeviceType, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*)"/>
        public static unsafe IntPtr CreateContextFromType(IntPtr[] properties, DeviceType device_type, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, IntPtr user_data, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (IntPtr* properties_ptr = properties)
                {
                    void* user_data_vptr = (void*)user_data;
                    returnValue = CreateContextFromType(properties_ptr, device_type, pfn_notify, user_data_vptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContextFromType(IntPtr*, DeviceType, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*)"/>
        public static unsafe IntPtr CreateContextFromType(ref IntPtr properties, DeviceType device_type, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, IntPtr user_data, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (IntPtr* properties_ptr = &properties)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                void* user_data_vptr = (void*)user_data;
                returnValue = CreateContextFromType(properties_ptr, device_type, pfn_notify, user_data_vptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContextFromType(IntPtr*, DeviceType, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*)"/>
        public static unsafe IntPtr CreateContextFromType<T1>(Span<IntPtr> properties, DeviceType device_type, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, Span<T1> user_data, Span<int> errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* user_data_ptr = user_data)
                {
                    fixed (IntPtr* properties_ptr = properties)
                    {
                        returnValue = CreateContextFromType(properties_ptr, device_type, pfn_notify, user_data_ptr, errcode_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContextFromType(IntPtr*, DeviceType, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*)"/>
        public static unsafe IntPtr CreateContextFromType<T1>(IntPtr[] properties, DeviceType device_type, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, T1[] user_data, int[] errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* user_data_ptr = user_data)
                {
                    fixed (IntPtr* properties_ptr = properties)
                    {
                        returnValue = CreateContextFromType(properties_ptr, device_type, pfn_notify, user_data_ptr, errcode_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateContextFromType(IntPtr*, DeviceType, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void>, void*, int*)"/>
        public static unsafe IntPtr CreateContextFromType<T1>(ref IntPtr properties, DeviceType device_type, delegate* unmanaged[Cdecl]<byte*, void*, nuint, void*, void> pfn_notify, ref T1 user_data, ref int errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (IntPtr* properties_ptr = &properties)
            fixed (void* user_data_ptr = &user_data)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreateContextFromType(properties_ptr, device_type, pfn_notify, user_data_ptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage(IntPtr, MemFlags, cl_image_format*, cl_image_desc*, void*, int*)"/>
        public static unsafe IntPtr CreateImage(IntPtr context, MemFlags flags, Span<cl_image_format> image_format, Span<cl_image_desc> image_desc, IntPtr host_ptr, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (cl_image_desc* image_desc_ptr = image_desc)
                {
                    fixed (cl_image_format* image_format_ptr = image_format)
                    {
                        void* host_ptr_vptr = (void*)host_ptr;
                        returnValue = CreateImage(context, flags, image_format_ptr, image_desc_ptr, host_ptr_vptr, errcode_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage(IntPtr, MemFlags, cl_image_format*, cl_image_desc*, void*, int*)"/>
        public static unsafe IntPtr CreateImage(IntPtr context, MemFlags flags, cl_image_format[] image_format, cl_image_desc[] image_desc, IntPtr host_ptr, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (cl_image_desc* image_desc_ptr = image_desc)
                {
                    fixed (cl_image_format* image_format_ptr = image_format)
                    {
                        void* host_ptr_vptr = (void*)host_ptr;
                        returnValue = CreateImage(context, flags, image_format_ptr, image_desc_ptr, host_ptr_vptr, errcode_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage(IntPtr, MemFlags, cl_image_format*, cl_image_desc*, void*, int*)"/>
        public static unsafe IntPtr CreateImage(IntPtr context, MemFlags flags, ref cl_image_format image_format, ref cl_image_desc image_desc, IntPtr host_ptr, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (cl_image_format* image_format_ptr = &image_format)
            fixed (cl_image_desc* image_desc_ptr = &image_desc)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                void* host_ptr_vptr = (void*)host_ptr;
                returnValue = CreateImage(context, flags, image_format_ptr, image_desc_ptr, host_ptr_vptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage(IntPtr, MemFlags, cl_image_format*, cl_image_desc*, void*, int*)"/>
        public static unsafe IntPtr CreateImage<T1>(IntPtr context, MemFlags flags, Span<cl_image_format> image_format, Span<cl_image_desc> image_desc, Span<T1> host_ptr, Span<int> errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* host_ptr_ptr = host_ptr)
                {
                    fixed (cl_image_desc* image_desc_ptr = image_desc)
                    {
                        fixed (cl_image_format* image_format_ptr = image_format)
                        {
                            returnValue = CreateImage(context, flags, image_format_ptr, image_desc_ptr, host_ptr_ptr, errcode_ret_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage(IntPtr, MemFlags, cl_image_format*, cl_image_desc*, void*, int*)"/>
        public static unsafe IntPtr CreateImage<T1>(IntPtr context, MemFlags flags, cl_image_format[] image_format, cl_image_desc[] image_desc, T1[] host_ptr, int[] errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* host_ptr_ptr = host_ptr)
                {
                    fixed (cl_image_desc* image_desc_ptr = image_desc)
                    {
                        fixed (cl_image_format* image_format_ptr = image_format)
                        {
                            returnValue = CreateImage(context, flags, image_format_ptr, image_desc_ptr, host_ptr_ptr, errcode_ret_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage(IntPtr, MemFlags, cl_image_format*, cl_image_desc*, void*, int*)"/>
        public static unsafe IntPtr CreateImage<T1>(IntPtr context, MemFlags flags, ref cl_image_format image_format, ref cl_image_desc image_desc, ref T1 host_ptr, ref int errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (cl_image_format* image_format_ptr = &image_format)
            fixed (cl_image_desc* image_desc_ptr = &image_desc)
            fixed (void* host_ptr_ptr = &host_ptr)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreateImage(context, flags, image_format_ptr, image_desc_ptr, host_ptr_ptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage2D(IntPtr, MemFlags, cl_image_format*, nuint, nuint, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateImage2D(IntPtr context, MemFlags flags, Span<cl_image_format> image_format, nuint image_width, nuint image_height, nuint image_row_pitch, IntPtr host_ptr, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (cl_image_format* image_format_ptr = image_format)
                {
                    void* host_ptr_vptr = (void*)host_ptr;
                    returnValue = CreateImage2D(context, flags, image_format_ptr, image_width, image_height, image_row_pitch, host_ptr_vptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage2D(IntPtr, MemFlags, cl_image_format*, nuint, nuint, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateImage2D(IntPtr context, MemFlags flags, cl_image_format[] image_format, nuint image_width, nuint image_height, nuint image_row_pitch, IntPtr host_ptr, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (cl_image_format* image_format_ptr = image_format)
                {
                    void* host_ptr_vptr = (void*)host_ptr;
                    returnValue = CreateImage2D(context, flags, image_format_ptr, image_width, image_height, image_row_pitch, host_ptr_vptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage2D(IntPtr, MemFlags, cl_image_format*, nuint, nuint, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateImage2D(IntPtr context, MemFlags flags, ref cl_image_format image_format, nuint image_width, nuint image_height, nuint image_row_pitch, IntPtr host_ptr, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (cl_image_format* image_format_ptr = &image_format)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                void* host_ptr_vptr = (void*)host_ptr;
                returnValue = CreateImage2D(context, flags, image_format_ptr, image_width, image_height, image_row_pitch, host_ptr_vptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage2D(IntPtr, MemFlags, cl_image_format*, nuint, nuint, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateImage2D<T1>(IntPtr context, MemFlags flags, Span<cl_image_format> image_format, nuint image_width, nuint image_height, nuint image_row_pitch, Span<T1> host_ptr, Span<int> errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* host_ptr_ptr = host_ptr)
                {
                    fixed (cl_image_format* image_format_ptr = image_format)
                    {
                        returnValue = CreateImage2D(context, flags, image_format_ptr, image_width, image_height, image_row_pitch, host_ptr_ptr, errcode_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage2D(IntPtr, MemFlags, cl_image_format*, nuint, nuint, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateImage2D<T1>(IntPtr context, MemFlags flags, cl_image_format[] image_format, nuint image_width, nuint image_height, nuint image_row_pitch, T1[] host_ptr, int[] errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* host_ptr_ptr = host_ptr)
                {
                    fixed (cl_image_format* image_format_ptr = image_format)
                    {
                        returnValue = CreateImage2D(context, flags, image_format_ptr, image_width, image_height, image_row_pitch, host_ptr_ptr, errcode_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage2D(IntPtr, MemFlags, cl_image_format*, nuint, nuint, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateImage2D<T1>(IntPtr context, MemFlags flags, ref cl_image_format image_format, nuint image_width, nuint image_height, nuint image_row_pitch, ref T1 host_ptr, ref int errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (cl_image_format* image_format_ptr = &image_format)
            fixed (void* host_ptr_ptr = &host_ptr)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreateImage2D(context, flags, image_format_ptr, image_width, image_height, image_row_pitch, host_ptr_ptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage3D(IntPtr, MemFlags, cl_image_format*, nuint, nuint, nuint, nuint, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateImage3D(IntPtr context, MemFlags flags, Span<cl_image_format> image_format, nuint image_width, nuint image_height, nuint image_depth, nuint image_row_pitch, nuint image_slice_pitch, IntPtr host_ptr, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (cl_image_format* image_format_ptr = image_format)
                {
                    void* host_ptr_vptr = (void*)host_ptr;
                    returnValue = CreateImage3D(context, flags, image_format_ptr, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr_vptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage3D(IntPtr, MemFlags, cl_image_format*, nuint, nuint, nuint, nuint, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateImage3D(IntPtr context, MemFlags flags, cl_image_format[] image_format, nuint image_width, nuint image_height, nuint image_depth, nuint image_row_pitch, nuint image_slice_pitch, IntPtr host_ptr, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (cl_image_format* image_format_ptr = image_format)
                {
                    void* host_ptr_vptr = (void*)host_ptr;
                    returnValue = CreateImage3D(context, flags, image_format_ptr, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr_vptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage3D(IntPtr, MemFlags, cl_image_format*, nuint, nuint, nuint, nuint, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateImage3D(IntPtr context, MemFlags flags, ref cl_image_format image_format, nuint image_width, nuint image_height, nuint image_depth, nuint image_row_pitch, nuint image_slice_pitch, IntPtr host_ptr, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (cl_image_format* image_format_ptr = &image_format)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                void* host_ptr_vptr = (void*)host_ptr;
                returnValue = CreateImage3D(context, flags, image_format_ptr, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr_vptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage3D(IntPtr, MemFlags, cl_image_format*, nuint, nuint, nuint, nuint, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateImage3D<T1>(IntPtr context, MemFlags flags, Span<cl_image_format> image_format, nuint image_width, nuint image_height, nuint image_depth, nuint image_row_pitch, nuint image_slice_pitch, Span<T1> host_ptr, Span<int> errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* host_ptr_ptr = host_ptr)
                {
                    fixed (cl_image_format* image_format_ptr = image_format)
                    {
                        returnValue = CreateImage3D(context, flags, image_format_ptr, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr_ptr, errcode_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage3D(IntPtr, MemFlags, cl_image_format*, nuint, nuint, nuint, nuint, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateImage3D<T1>(IntPtr context, MemFlags flags, cl_image_format[] image_format, nuint image_width, nuint image_height, nuint image_depth, nuint image_row_pitch, nuint image_slice_pitch, T1[] host_ptr, int[] errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* host_ptr_ptr = host_ptr)
                {
                    fixed (cl_image_format* image_format_ptr = image_format)
                    {
                        returnValue = CreateImage3D(context, flags, image_format_ptr, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr_ptr, errcode_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImage3D(IntPtr, MemFlags, cl_image_format*, nuint, nuint, nuint, nuint, nuint, void*, int*)"/>
        public static unsafe IntPtr CreateImage3D<T1>(IntPtr context, MemFlags flags, ref cl_image_format image_format, nuint image_width, nuint image_height, nuint image_depth, nuint image_row_pitch, nuint image_slice_pitch, ref T1 host_ptr, ref int errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (cl_image_format* image_format_ptr = &image_format)
            fixed (void* host_ptr_ptr = &host_ptr)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreateImage3D(context, flags, image_format_ptr, image_width, image_height, image_depth, image_row_pitch, image_slice_pitch, host_ptr_ptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImageWithProperties(IntPtr, ulong*, MemFlags, cl_image_format*, cl_image_desc*, void*, int*)"/>
        public static unsafe IntPtr CreateImageWithProperties(IntPtr context, Span<ulong> properties, MemFlags flags, Span<cl_image_format> image_format, Span<cl_image_desc> image_desc, IntPtr host_ptr, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (cl_image_desc* image_desc_ptr = image_desc)
                {
                    fixed (cl_image_format* image_format_ptr = image_format)
                    {
                        fixed (ulong* properties_ptr = properties)
                        {
                            void* host_ptr_vptr = (void*)host_ptr;
                            returnValue = CreateImageWithProperties(context, properties_ptr, flags, image_format_ptr, image_desc_ptr, host_ptr_vptr, errcode_ret_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImageWithProperties(IntPtr, ulong*, MemFlags, cl_image_format*, cl_image_desc*, void*, int*)"/>
        public static unsafe IntPtr CreateImageWithProperties(IntPtr context, ulong[] properties, MemFlags flags, cl_image_format[] image_format, cl_image_desc[] image_desc, IntPtr host_ptr, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (cl_image_desc* image_desc_ptr = image_desc)
                {
                    fixed (cl_image_format* image_format_ptr = image_format)
                    {
                        fixed (ulong* properties_ptr = properties)
                        {
                            void* host_ptr_vptr = (void*)host_ptr;
                            returnValue = CreateImageWithProperties(context, properties_ptr, flags, image_format_ptr, image_desc_ptr, host_ptr_vptr, errcode_ret_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImageWithProperties(IntPtr, ulong*, MemFlags, cl_image_format*, cl_image_desc*, void*, int*)"/>
        public static unsafe IntPtr CreateImageWithProperties(IntPtr context, ref ulong properties, MemFlags flags, ref cl_image_format image_format, ref cl_image_desc image_desc, IntPtr host_ptr, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (ulong* properties_ptr = &properties)
            fixed (cl_image_format* image_format_ptr = &image_format)
            fixed (cl_image_desc* image_desc_ptr = &image_desc)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                void* host_ptr_vptr = (void*)host_ptr;
                returnValue = CreateImageWithProperties(context, properties_ptr, flags, image_format_ptr, image_desc_ptr, host_ptr_vptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImageWithProperties(IntPtr, ulong*, MemFlags, cl_image_format*, cl_image_desc*, void*, int*)"/>
        public static unsafe IntPtr CreateImageWithProperties<T1>(IntPtr context, Span<ulong> properties, MemFlags flags, Span<cl_image_format> image_format, Span<cl_image_desc> image_desc, Span<T1> host_ptr, Span<int> errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* host_ptr_ptr = host_ptr)
                {
                    fixed (cl_image_desc* image_desc_ptr = image_desc)
                    {
                        fixed (cl_image_format* image_format_ptr = image_format)
                        {
                            fixed (ulong* properties_ptr = properties)
                            {
                                returnValue = CreateImageWithProperties(context, properties_ptr, flags, image_format_ptr, image_desc_ptr, host_ptr_ptr, errcode_ret_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImageWithProperties(IntPtr, ulong*, MemFlags, cl_image_format*, cl_image_desc*, void*, int*)"/>
        public static unsafe IntPtr CreateImageWithProperties<T1>(IntPtr context, ulong[] properties, MemFlags flags, cl_image_format[] image_format, cl_image_desc[] image_desc, T1[] host_ptr, int[] errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* host_ptr_ptr = host_ptr)
                {
                    fixed (cl_image_desc* image_desc_ptr = image_desc)
                    {
                        fixed (cl_image_format* image_format_ptr = image_format)
                        {
                            fixed (ulong* properties_ptr = properties)
                            {
                                returnValue = CreateImageWithProperties(context, properties_ptr, flags, image_format_ptr, image_desc_ptr, host_ptr_ptr, errcode_ret_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateImageWithProperties(IntPtr, ulong*, MemFlags, cl_image_format*, cl_image_desc*, void*, int*)"/>
        public static unsafe IntPtr CreateImageWithProperties<T1>(IntPtr context, ref ulong properties, MemFlags flags, ref cl_image_format image_format, ref cl_image_desc image_desc, ref T1 host_ptr, ref int errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (ulong* properties_ptr = &properties)
            fixed (cl_image_format* image_format_ptr = &image_format)
            fixed (cl_image_desc* image_desc_ptr = &image_desc)
            fixed (void* host_ptr_ptr = &host_ptr)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreateImageWithProperties(context, properties_ptr, flags, image_format_ptr, image_desc_ptr, host_ptr_ptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateKernel(IntPtr, byte*, int*)"/>
        public static unsafe IntPtr CreateKernel(IntPtr program, string kernel_name, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                byte* kernel_name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(kernel_name);
                returnValue = CreateKernel(program, kernel_name_ptr, errcode_ret_ptr);
                Marshal.FreeCoTaskMem((IntPtr)kernel_name_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateKernel(IntPtr, byte*, int*)"/>
        public static unsafe IntPtr CreateKernel(IntPtr program, string kernel_name, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                byte* kernel_name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(kernel_name);
                returnValue = CreateKernel(program, kernel_name_ptr, errcode_ret_ptr);
                Marshal.FreeCoTaskMem((IntPtr)kernel_name_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateKernel(IntPtr, byte*, int*)"/>
        public static unsafe IntPtr CreateKernel(IntPtr program, string kernel_name, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                byte* kernel_name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(kernel_name);
                returnValue = CreateKernel(program, kernel_name_ptr, errcode_ret_ptr);
                Marshal.FreeCoTaskMem((IntPtr)kernel_name_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateKernelsInProgram(IntPtr, uint, IntPtr*, uint*)"/>
        public static unsafe int CreateKernelsInProgram(IntPtr program, uint num_kernels, Span<IntPtr> kernels, Span<uint> num_kernels_ret)
        {
            int returnValue;
            fixed (uint* num_kernels_ret_ptr = num_kernels_ret)
            {
                fixed (IntPtr* kernels_ptr = kernels)
                {
                    returnValue = CreateKernelsInProgram(program, num_kernels, kernels_ptr, num_kernels_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateKernelsInProgram(IntPtr, uint, IntPtr*, uint*)"/>
        public static unsafe int CreateKernelsInProgram(IntPtr program, uint num_kernels, IntPtr[] kernels, uint[] num_kernels_ret)
        {
            int returnValue;
            fixed (uint* num_kernels_ret_ptr = num_kernels_ret)
            {
                fixed (IntPtr* kernels_ptr = kernels)
                {
                    returnValue = CreateKernelsInProgram(program, num_kernels, kernels_ptr, num_kernels_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateKernelsInProgram(IntPtr, uint, IntPtr*, uint*)"/>
        public static unsafe int CreateKernelsInProgram(IntPtr program, uint num_kernels, ref IntPtr kernels, ref uint num_kernels_ret)
        {
            int returnValue;
            fixed (IntPtr* kernels_ptr = &kernels)
            fixed (uint* num_kernels_ret_ptr = &num_kernels_ret)
            {
                returnValue = CreateKernelsInProgram(program, num_kernels, kernels_ptr, num_kernels_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePipe(IntPtr, MemFlags, uint, uint, IntPtr*, int*)"/>
        public static unsafe IntPtr CreatePipe(IntPtr context, MemFlags flags, uint pipe_packet_size, uint pipe_max_packets, Span<IntPtr> properties, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (IntPtr* properties_ptr = properties)
                {
                    returnValue = CreatePipe(context, flags, pipe_packet_size, pipe_max_packets, properties_ptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePipe(IntPtr, MemFlags, uint, uint, IntPtr*, int*)"/>
        public static unsafe IntPtr CreatePipe(IntPtr context, MemFlags flags, uint pipe_packet_size, uint pipe_max_packets, IntPtr[] properties, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (IntPtr* properties_ptr = properties)
                {
                    returnValue = CreatePipe(context, flags, pipe_packet_size, pipe_max_packets, properties_ptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePipe(IntPtr, MemFlags, uint, uint, IntPtr*, int*)"/>
        public static unsafe IntPtr CreatePipe(IntPtr context, MemFlags flags, uint pipe_packet_size, uint pipe_max_packets, ref IntPtr properties, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (IntPtr* properties_ptr = &properties)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreatePipe(context, flags, pipe_packet_size, pipe_max_packets, properties_ptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateProgramWithBinary(IntPtr, uint, IntPtr*, nuint*, byte**, int*, int*)"/>
        public static unsafe IntPtr CreateProgramWithBinary(IntPtr context, uint num_devices, Span<IntPtr> device_list, ReadOnlySpan<nuint> lengths, string[] binaries, Span<int> binary_status, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (int* binary_status_ptr = binary_status)
                {
                    fixed (nuint* lengths_ptr = lengths)
                    {
                        fixed (IntPtr* device_list_ptr = device_list)
                        {
                            byte** binaries_ptr = (byte**)MarshalTk.StringArrayToCoTaskMemUTF8(binaries);
                            returnValue = CreateProgramWithBinary(context, num_devices, device_list_ptr, lengths_ptr, binaries_ptr, binary_status_ptr, errcode_ret_ptr);
                            MarshalTk.FreeStringArrayCoTaskMem((IntPtr)binaries_ptr, binaries.Length);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateProgramWithBinary(IntPtr, uint, IntPtr*, nuint*, byte**, int*, int*)"/>
        public static unsafe IntPtr CreateProgramWithBinary(IntPtr context, uint num_devices, IntPtr[] device_list, nuint[] lengths, string[] binaries, int[] binary_status, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (int* binary_status_ptr = binary_status)
                {
                    fixed (nuint* lengths_ptr = lengths)
                    {
                        fixed (IntPtr* device_list_ptr = device_list)
                        {
                            byte** binaries_ptr = (byte**)MarshalTk.StringArrayToCoTaskMemUTF8(binaries);
                            returnValue = CreateProgramWithBinary(context, num_devices, device_list_ptr, lengths_ptr, binaries_ptr, binary_status_ptr, errcode_ret_ptr);
                            MarshalTk.FreeStringArrayCoTaskMem((IntPtr)binaries_ptr, binaries.Length);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateProgramWithBinary(IntPtr, uint, IntPtr*, nuint*, byte**, int*, int*)"/>
        public static unsafe IntPtr CreateProgramWithBinary(IntPtr context, uint num_devices, ref IntPtr device_list, ref readonly nuint lengths, string[] binaries, ref int binary_status, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (IntPtr* device_list_ptr = &device_list)
            fixed (nuint* lengths_ptr = &lengths)
            fixed (int* binary_status_ptr = &binary_status)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                byte** binaries_ptr = (byte**)MarshalTk.StringArrayToCoTaskMemUTF8(binaries);
                returnValue = CreateProgramWithBinary(context, num_devices, device_list_ptr, lengths_ptr, binaries_ptr, binary_status_ptr, errcode_ret_ptr);
                MarshalTk.FreeStringArrayCoTaskMem((IntPtr)binaries_ptr, binaries.Length);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateProgramWithBuiltInKernels(IntPtr, uint, IntPtr*, byte*, int*)"/>
        public static unsafe IntPtr CreateProgramWithBuiltInKernel(IntPtr context, uint num_devices, Span<IntPtr> device_list, string kernel_names, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (IntPtr* device_list_ptr = device_list)
                {
                    byte* kernel_names_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(kernel_names);
                    returnValue = CreateProgramWithBuiltInKernels(context, num_devices, device_list_ptr, kernel_names_ptr, errcode_ret_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)kernel_names_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateProgramWithBuiltInKernels(IntPtr, uint, IntPtr*, byte*, int*)"/>
        public static unsafe IntPtr CreateProgramWithBuiltInKernel(IntPtr context, uint num_devices, IntPtr[] device_list, string kernel_names, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (IntPtr* device_list_ptr = device_list)
                {
                    byte* kernel_names_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(kernel_names);
                    returnValue = CreateProgramWithBuiltInKernels(context, num_devices, device_list_ptr, kernel_names_ptr, errcode_ret_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)kernel_names_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateProgramWithBuiltInKernels(IntPtr, uint, IntPtr*, byte*, int*)"/>
        public static unsafe IntPtr CreateProgramWithBuiltInKernel(IntPtr context, uint num_devices, ref IntPtr device_list, string kernel_names, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (IntPtr* device_list_ptr = &device_list)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                byte* kernel_names_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(kernel_names);
                returnValue = CreateProgramWithBuiltInKernels(context, num_devices, device_list_ptr, kernel_names_ptr, errcode_ret_ptr);
                Marshal.FreeCoTaskMem((IntPtr)kernel_names_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateProgramWithIL(IntPtr, void*, nuint, int*)"/>
        public static unsafe IntPtr CreateProgramWithIL(IntPtr context, IntPtr il, nuint length, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                void* il_vptr = (void*)il;
                returnValue = CreateProgramWithIL(context, il_vptr, length, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateProgramWithIL(IntPtr, void*, nuint, int*)"/>
        public static unsafe IntPtr CreateProgramWithIL(IntPtr context, IntPtr il, nuint length, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                void* il_vptr = (void*)il;
                returnValue = CreateProgramWithIL(context, il_vptr, length, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateProgramWithIL(IntPtr, void*, nuint, int*)"/>
        public static unsafe IntPtr CreateProgramWithIL(IntPtr context, IntPtr il, nuint length, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                void* il_vptr = (void*)il;
                returnValue = CreateProgramWithIL(context, il_vptr, length, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateProgramWithIL(IntPtr, void*, nuint, int*)"/>
        public static unsafe IntPtr CreateProgramWithIL<T1>(IntPtr context, ReadOnlySpan<T1> il, nuint length, Span<int> errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* il_ptr = il)
                {
                    returnValue = CreateProgramWithIL(context, il_ptr, length, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateProgramWithIL(IntPtr, void*, nuint, int*)"/>
        public static unsafe IntPtr CreateProgramWithIL<T1>(IntPtr context, T1[] il, nuint length, int[] errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* il_ptr = il)
                {
                    returnValue = CreateProgramWithIL(context, il_ptr, length, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateProgramWithIL(IntPtr, void*, nuint, int*)"/>
        public static unsafe IntPtr CreateProgramWithIL<T1>(IntPtr context, ref readonly T1 il, nuint length, ref int errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (void* il_ptr = &il)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreateProgramWithIL(context, il_ptr, length, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateProgramWithSource(IntPtr, uint, byte**, nuint*, int*)"/>
        public static unsafe IntPtr CreateProgramWithSource(IntPtr context, uint count, string[] strings, ReadOnlySpan<nuint> lengths, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (nuint* lengths_ptr = lengths)
                {
                    byte** strings_ptr = (byte**)MarshalTk.StringArrayToCoTaskMemUTF8(strings);
                    returnValue = CreateProgramWithSource(context, count, strings_ptr, lengths_ptr, errcode_ret_ptr);
                    MarshalTk.FreeStringArrayCoTaskMem((IntPtr)strings_ptr, strings.Length);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateProgramWithSource(IntPtr, uint, byte**, nuint*, int*)"/>
        public static unsafe IntPtr CreateProgramWithSource(IntPtr context, uint count, string[] strings, nuint[] lengths, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (nuint* lengths_ptr = lengths)
                {
                    byte** strings_ptr = (byte**)MarshalTk.StringArrayToCoTaskMemUTF8(strings);
                    returnValue = CreateProgramWithSource(context, count, strings_ptr, lengths_ptr, errcode_ret_ptr);
                    MarshalTk.FreeStringArrayCoTaskMem((IntPtr)strings_ptr, strings.Length);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateProgramWithSource(IntPtr, uint, byte**, nuint*, int*)"/>
        public static unsafe IntPtr CreateProgramWithSource(IntPtr context, uint count, string[] strings, ref readonly nuint lengths, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (nuint* lengths_ptr = &lengths)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                byte** strings_ptr = (byte**)MarshalTk.StringArrayToCoTaskMemUTF8(strings);
                returnValue = CreateProgramWithSource(context, count, strings_ptr, lengths_ptr, errcode_ret_ptr);
                MarshalTk.FreeStringArrayCoTaskMem((IntPtr)strings_ptr, strings.Length);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSampler(IntPtr, Bool, uint, uint, int*)"/>
        public static unsafe IntPtr CreateSampler(IntPtr context, Bool normalized_coords, uint addressing_mode, uint filter_mode, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                returnValue = CreateSampler(context, normalized_coords, addressing_mode, filter_mode, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSampler(IntPtr, Bool, uint, uint, int*)"/>
        public static unsafe IntPtr CreateSampler(IntPtr context, Bool normalized_coords, uint addressing_mode, uint filter_mode, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                returnValue = CreateSampler(context, normalized_coords, addressing_mode, filter_mode, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSampler(IntPtr, Bool, uint, uint, int*)"/>
        public static unsafe IntPtr CreateSampler(IntPtr context, Bool normalized_coords, uint addressing_mode, uint filter_mode, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreateSampler(context, normalized_coords, addressing_mode, filter_mode, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSamplerWithProperties(IntPtr, ulong*, int*)"/>
        public static unsafe IntPtr CreateSamplerWithProperties(IntPtr context, Span<ulong> sampler_properties, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (ulong* sampler_properties_ptr = sampler_properties)
                {
                    returnValue = CreateSamplerWithProperties(context, sampler_properties_ptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSamplerWithProperties(IntPtr, ulong*, int*)"/>
        public static unsafe IntPtr CreateSamplerWithProperties(IntPtr context, ulong[] sampler_properties, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (ulong* sampler_properties_ptr = sampler_properties)
                {
                    returnValue = CreateSamplerWithProperties(context, sampler_properties_ptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSamplerWithProperties(IntPtr, ulong*, int*)"/>
        public static unsafe IntPtr CreateSamplerWithProperties(IntPtr context, ref ulong sampler_properties, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (ulong* sampler_properties_ptr = &sampler_properties)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreateSamplerWithProperties(context, sampler_properties_ptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSubBuffer(IntPtr, MemFlags, uint, void*, int*)"/>
        public static unsafe IntPtr CreateSubBuffer(IntPtr buffer, MemFlags flags, uint buffer_create_type, IntPtr buffer_create_info, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                void* buffer_create_info_vptr = (void*)buffer_create_info;
                returnValue = CreateSubBuffer(buffer, flags, buffer_create_type, buffer_create_info_vptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSubBuffer(IntPtr, MemFlags, uint, void*, int*)"/>
        public static unsafe IntPtr CreateSubBuffer(IntPtr buffer, MemFlags flags, uint buffer_create_type, IntPtr buffer_create_info, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                void* buffer_create_info_vptr = (void*)buffer_create_info;
                returnValue = CreateSubBuffer(buffer, flags, buffer_create_type, buffer_create_info_vptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSubBuffer(IntPtr, MemFlags, uint, void*, int*)"/>
        public static unsafe IntPtr CreateSubBuffer(IntPtr buffer, MemFlags flags, uint buffer_create_type, IntPtr buffer_create_info, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                void* buffer_create_info_vptr = (void*)buffer_create_info;
                returnValue = CreateSubBuffer(buffer, flags, buffer_create_type, buffer_create_info_vptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSubBuffer(IntPtr, MemFlags, uint, void*, int*)"/>
        public static unsafe IntPtr CreateSubBuffer<T1>(IntPtr buffer, MemFlags flags, uint buffer_create_type, ReadOnlySpan<T1> buffer_create_info, Span<int> errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* buffer_create_info_ptr = buffer_create_info)
                {
                    returnValue = CreateSubBuffer(buffer, flags, buffer_create_type, buffer_create_info_ptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSubBuffer(IntPtr, MemFlags, uint, void*, int*)"/>
        public static unsafe IntPtr CreateSubBuffer<T1>(IntPtr buffer, MemFlags flags, uint buffer_create_type, T1[] buffer_create_info, int[] errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* buffer_create_info_ptr = buffer_create_info)
                {
                    returnValue = CreateSubBuffer(buffer, flags, buffer_create_type, buffer_create_info_ptr, errcode_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSubBuffer(IntPtr, MemFlags, uint, void*, int*)"/>
        public static unsafe IntPtr CreateSubBuffer<T1>(IntPtr buffer, MemFlags flags, uint buffer_create_type, ref readonly T1 buffer_create_info, ref int errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (void* buffer_create_info_ptr = &buffer_create_info)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreateSubBuffer(buffer, flags, buffer_create_type, buffer_create_info_ptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSubDevices(IntPtr, IntPtr*, uint, IntPtr*, uint*)"/>
        public static unsafe int CreateSubDevices(IntPtr in_device, Span<IntPtr> properties, uint num_devices, Span<IntPtr> out_devices, Span<uint> num_devices_ret)
        {
            int returnValue;
            fixed (uint* num_devices_ret_ptr = num_devices_ret)
            {
                fixed (IntPtr* out_devices_ptr = out_devices)
                {
                    fixed (IntPtr* properties_ptr = properties)
                    {
                        returnValue = CreateSubDevices(in_device, properties_ptr, num_devices, out_devices_ptr, num_devices_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSubDevices(IntPtr, IntPtr*, uint, IntPtr*, uint*)"/>
        public static unsafe int CreateSubDevices(IntPtr in_device, IntPtr[] properties, uint num_devices, IntPtr[] out_devices, uint[] num_devices_ret)
        {
            int returnValue;
            fixed (uint* num_devices_ret_ptr = num_devices_ret)
            {
                fixed (IntPtr* out_devices_ptr = out_devices)
                {
                    fixed (IntPtr* properties_ptr = properties)
                    {
                        returnValue = CreateSubDevices(in_device, properties_ptr, num_devices, out_devices_ptr, num_devices_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateSubDevices(IntPtr, IntPtr*, uint, IntPtr*, uint*)"/>
        public static unsafe int CreateSubDevices(IntPtr in_device, ref IntPtr properties, uint num_devices, ref IntPtr out_devices, ref uint num_devices_ret)
        {
            int returnValue;
            fixed (IntPtr* properties_ptr = &properties)
            fixed (IntPtr* out_devices_ptr = &out_devices)
            fixed (uint* num_devices_ret_ptr = &num_devices_ret)
            {
                returnValue = CreateSubDevices(in_device, properties_ptr, num_devices, out_devices_ptr, num_devices_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateUserEvent(IntPtr, int*)"/>
        public static unsafe IntPtr CreateUserEvent(IntPtr context, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                returnValue = CreateUserEvent(context, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateUserEvent(IntPtr, int*)"/>
        public static unsafe IntPtr CreateUserEvent(IntPtr context, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                returnValue = CreateUserEvent(context, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateUserEvent(IntPtr, int*)"/>
        public static unsafe IntPtr CreateUserEvent(IntPtr context, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = CreateUserEvent(context, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueBarrierWithWaitList(IntPtr, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueBarrierWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    returnValue = EnqueueBarrierWithWaitList(command_queue, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueBarrierWithWaitList(IntPtr, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueBarrierWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    returnValue = EnqueueBarrierWithWaitList(command_queue, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueBarrierWithWaitList(IntPtr, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueBarrierWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueBarrierWithWaitList(command_queue, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueCopyBuffer(IntPtr, IntPtr, IntPtr, nuint, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueCopyBuffer(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, nuint src_offset, nuint dst_offset, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    returnValue = EnqueueCopyBuffer(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueCopyBuffer(IntPtr, IntPtr, IntPtr, nuint, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueCopyBuffer(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, nuint src_offset, nuint dst_offset, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    returnValue = EnqueueCopyBuffer(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueCopyBuffer(IntPtr, IntPtr, IntPtr, nuint, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueCopyBuffer(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, nuint src_offset, nuint dst_offset, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueCopyBuffer(command_queue, src_buffer, dst_buffer, src_offset, dst_offset, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueCopyBufferRect(IntPtr, IntPtr, IntPtr, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueCopyBufferRect(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, ReadOnlySpan<nuint> src_origin, ReadOnlySpan<nuint> dst_origin, ReadOnlySpan<nuint> region, nuint src_row_pitch, nuint src_slice_pitch, nuint dst_row_pitch, nuint dst_slice_pitch, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* dst_origin_ptr = dst_origin)
                        {
                            fixed (nuint* src_origin_ptr = src_origin)
                            {
                                returnValue = EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin_ptr, dst_origin_ptr, region_ptr, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueCopyBufferRect(IntPtr, IntPtr, IntPtr, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueCopyBufferRect(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, nuint[] src_origin, nuint[] dst_origin, nuint[] region, nuint src_row_pitch, nuint src_slice_pitch, nuint dst_row_pitch, nuint dst_slice_pitch, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* dst_origin_ptr = dst_origin)
                        {
                            fixed (nuint* src_origin_ptr = src_origin)
                            {
                                returnValue = EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin_ptr, dst_origin_ptr, region_ptr, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueCopyBufferRect(IntPtr, IntPtr, IntPtr, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueCopyBufferRect(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, ref readonly nuint src_origin, ref readonly nuint dst_origin, ref readonly nuint region, nuint src_row_pitch, nuint src_slice_pitch, nuint dst_row_pitch, nuint dst_slice_pitch, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (nuint* src_origin_ptr = &src_origin)
            fixed (nuint* dst_origin_ptr = &dst_origin)
            fixed (nuint* region_ptr = &region)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueCopyBufferRect(command_queue, src_buffer, dst_buffer, src_origin_ptr, dst_origin_ptr, region_ptr, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueCopyBufferToImage(IntPtr, IntPtr, IntPtr, nuint, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueCopyBufferToImage(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_image, nuint src_offset, ReadOnlySpan<nuint> dst_origin, ReadOnlySpan<nuint> region, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* dst_origin_ptr = dst_origin)
                        {
                            returnValue = EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, dst_origin_ptr, region_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueCopyBufferToImage(IntPtr, IntPtr, IntPtr, nuint, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueCopyBufferToImage(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_image, nuint src_offset, nuint[] dst_origin, nuint[] region, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* dst_origin_ptr = dst_origin)
                        {
                            returnValue = EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, dst_origin_ptr, region_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueCopyBufferToImage(IntPtr, IntPtr, IntPtr, nuint, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueCopyBufferToImage(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_image, nuint src_offset, ref readonly nuint dst_origin, ref readonly nuint region, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (nuint* dst_origin_ptr = &dst_origin)
            fixed (nuint* region_ptr = &region)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueCopyBufferToImage(command_queue, src_buffer, dst_image, src_offset, dst_origin_ptr, region_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueCopyImage(IntPtr, IntPtr, IntPtr, nuint*, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueCopyImage(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, ReadOnlySpan<nuint> src_origin, ReadOnlySpan<nuint> dst_origin, ReadOnlySpan<nuint> region, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* dst_origin_ptr = dst_origin)
                        {
                            fixed (nuint* src_origin_ptr = src_origin)
                            {
                                returnValue = EnqueueCopyImage(command_queue, src_image, dst_image, src_origin_ptr, dst_origin_ptr, region_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueCopyImage(IntPtr, IntPtr, IntPtr, nuint*, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueCopyImage(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, nuint[] src_origin, nuint[] dst_origin, nuint[] region, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* dst_origin_ptr = dst_origin)
                        {
                            fixed (nuint* src_origin_ptr = src_origin)
                            {
                                returnValue = EnqueueCopyImage(command_queue, src_image, dst_image, src_origin_ptr, dst_origin_ptr, region_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueCopyImage(IntPtr, IntPtr, IntPtr, nuint*, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueCopyImage(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, ref readonly nuint src_origin, ref readonly nuint dst_origin, ref readonly nuint region, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (nuint* src_origin_ptr = &src_origin)
            fixed (nuint* dst_origin_ptr = &dst_origin)
            fixed (nuint* region_ptr = &region)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueCopyImage(command_queue, src_image, dst_image, src_origin_ptr, dst_origin_ptr, region_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueCopyImageToBuffer(IntPtr, IntPtr, IntPtr, nuint*, nuint*, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueCopyImageToBuffer(IntPtr command_queue, IntPtr src_image, IntPtr dst_buffer, ReadOnlySpan<nuint> src_origin, ReadOnlySpan<nuint> region, nuint dst_offset, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* src_origin_ptr = src_origin)
                        {
                            returnValue = EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, src_origin_ptr, region_ptr, dst_offset, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueCopyImageToBuffer(IntPtr, IntPtr, IntPtr, nuint*, nuint*, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueCopyImageToBuffer(IntPtr command_queue, IntPtr src_image, IntPtr dst_buffer, nuint[] src_origin, nuint[] region, nuint dst_offset, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* src_origin_ptr = src_origin)
                        {
                            returnValue = EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, src_origin_ptr, region_ptr, dst_offset, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueCopyImageToBuffer(IntPtr, IntPtr, IntPtr, nuint*, nuint*, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueCopyImageToBuffer(IntPtr command_queue, IntPtr src_image, IntPtr dst_buffer, ref readonly nuint src_origin, ref readonly nuint region, nuint dst_offset, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (nuint* src_origin_ptr = &src_origin)
            fixed (nuint* region_ptr = &region)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueCopyImageToBuffer(command_queue, src_image, dst_buffer, src_origin_ptr, region_ptr, dst_offset, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueFillBuffer(IntPtr, IntPtr, void*, nuint, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueFillBuffer(IntPtr command_queue, IntPtr buffer, IntPtr pattern, nuint pattern_size, nuint offset, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* pattern_vptr = (void*)pattern;
                    returnValue = EnqueueFillBuffer(command_queue, buffer, pattern_vptr, pattern_size, offset, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueFillBuffer(IntPtr, IntPtr, void*, nuint, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueFillBuffer(IntPtr command_queue, IntPtr buffer, IntPtr pattern, nuint pattern_size, nuint offset, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* pattern_vptr = (void*)pattern;
                    returnValue = EnqueueFillBuffer(command_queue, buffer, pattern_vptr, pattern_size, offset, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueFillBuffer(IntPtr, IntPtr, void*, nuint, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueFillBuffer(IntPtr command_queue, IntPtr buffer, IntPtr pattern, nuint pattern_size, nuint offset, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                void* pattern_vptr = (void*)pattern;
                returnValue = EnqueueFillBuffer(command_queue, buffer, pattern_vptr, pattern_size, offset, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueFillBuffer(IntPtr, IntPtr, void*, nuint, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueFillBuffer<T1>(IntPtr command_queue, IntPtr buffer, ReadOnlySpan<T1> pattern, nuint pattern_size, nuint offset, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* pattern_ptr = pattern)
                    {
                        returnValue = EnqueueFillBuffer(command_queue, buffer, pattern_ptr, pattern_size, offset, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueFillBuffer(IntPtr, IntPtr, void*, nuint, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueFillBuffer<T1>(IntPtr command_queue, IntPtr buffer, T1[] pattern, nuint pattern_size, nuint offset, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* pattern_ptr = pattern)
                    {
                        returnValue = EnqueueFillBuffer(command_queue, buffer, pattern_ptr, pattern_size, offset, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueFillBuffer(IntPtr, IntPtr, void*, nuint, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueFillBuffer<T1>(IntPtr command_queue, IntPtr buffer, ref readonly T1 pattern, nuint pattern_size, nuint offset, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* pattern_ptr = &pattern)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueFillBuffer(command_queue, buffer, pattern_ptr, pattern_size, offset, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueFillImage(IntPtr, IntPtr, void*, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueFillImage(IntPtr command_queue, IntPtr image, IntPtr fill_color, ReadOnlySpan<nuint> origin, ReadOnlySpan<nuint> region, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* origin_ptr = origin)
                        {
                            void* fill_color_vptr = (void*)fill_color;
                            returnValue = EnqueueFillImage(command_queue, image, fill_color_vptr, origin_ptr, region_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueFillImage(IntPtr, IntPtr, void*, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueFillImage(IntPtr command_queue, IntPtr image, IntPtr fill_color, nuint[] origin, nuint[] region, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* origin_ptr = origin)
                        {
                            void* fill_color_vptr = (void*)fill_color;
                            returnValue = EnqueueFillImage(command_queue, image, fill_color_vptr, origin_ptr, region_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueFillImage(IntPtr, IntPtr, void*, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueFillImage(IntPtr command_queue, IntPtr image, IntPtr fill_color, ref readonly nuint origin, ref readonly nuint region, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (nuint* origin_ptr = &origin)
            fixed (nuint* region_ptr = &region)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                void* fill_color_vptr = (void*)fill_color;
                returnValue = EnqueueFillImage(command_queue, image, fill_color_vptr, origin_ptr, region_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueFillImage(IntPtr, IntPtr, void*, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueFillImage<T1>(IntPtr command_queue, IntPtr image, ReadOnlySpan<T1> fill_color, ReadOnlySpan<nuint> origin, ReadOnlySpan<nuint> region, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* origin_ptr = origin)
                        {
                            fixed (void* fill_color_ptr = fill_color)
                            {
                                returnValue = EnqueueFillImage(command_queue, image, fill_color_ptr, origin_ptr, region_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueFillImage(IntPtr, IntPtr, void*, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueFillImage<T1>(IntPtr command_queue, IntPtr image, T1[] fill_color, nuint[] origin, nuint[] region, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* origin_ptr = origin)
                        {
                            fixed (void* fill_color_ptr = fill_color)
                            {
                                returnValue = EnqueueFillImage(command_queue, image, fill_color_ptr, origin_ptr, region_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueFillImage(IntPtr, IntPtr, void*, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueFillImage<T1>(IntPtr command_queue, IntPtr image, ref readonly T1 fill_color, ref readonly nuint origin, ref readonly nuint region, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* fill_color_ptr = &fill_color)
            fixed (nuint* origin_ptr = &origin)
            fixed (nuint* region_ptr = &region)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueFillImage(command_queue, image, fill_color_ptr, origin_ptr, region_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueMapBuffer(IntPtr, IntPtr, Bool, MapFlags, nuint, nuint, uint, IntPtr*, IntPtr*, int*)"/>
        public static unsafe void* EnqueueMapBuffer(IntPtr command_queue, IntPtr buffer, Bool blocking_map, MapFlags map_flags, nuint offset, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event, Span<int> errcode_ret)
        {
            void* returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        returnValue = EnqueueMapBuffer(command_queue, buffer, blocking_map, map_flags, offset, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr, errcode_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueMapBuffer(IntPtr, IntPtr, Bool, MapFlags, nuint, nuint, uint, IntPtr*, IntPtr*, int*)"/>
        public static unsafe void* EnqueueMapBuffer(IntPtr command_queue, IntPtr buffer, Bool blocking_map, MapFlags map_flags, nuint offset, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event, int[] errcode_ret)
        {
            void* returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        returnValue = EnqueueMapBuffer(command_queue, buffer, blocking_map, map_flags, offset, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr, errcode_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueMapBuffer(IntPtr, IntPtr, Bool, MapFlags, nuint, nuint, uint, IntPtr*, IntPtr*, int*)"/>
        public static unsafe void* EnqueueMapBuffer(IntPtr command_queue, IntPtr buffer, Bool blocking_map, MapFlags map_flags, nuint offset, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event, ref int errcode_ret)
        {
            void* returnValue;
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = EnqueueMapBuffer(command_queue, buffer, blocking_map, map_flags, offset, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueMapImage(IntPtr, IntPtr, Bool, MapFlags, nuint*, nuint*, nuint*, nuint*, uint, IntPtr*, IntPtr*, int*)"/>
        public static unsafe void* EnqueueMapImage(IntPtr command_queue, IntPtr image, Bool blocking_map, MapFlags map_flags, ReadOnlySpan<nuint> origin, ReadOnlySpan<nuint> region, Span<nuint> image_row_pitch, Span<nuint> image_slice_pitch, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event, Span<int> errcode_ret)
        {
            void* returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (nuint* image_slice_pitch_ptr = image_slice_pitch)
                        {
                            fixed (nuint* image_row_pitch_ptr = image_row_pitch)
                            {
                                fixed (nuint* region_ptr = region)
                                {
                                    fixed (nuint* origin_ptr = origin)
                                    {
                                        returnValue = EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin_ptr, region_ptr, image_row_pitch_ptr, image_slice_pitch_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr, errcode_ret_ptr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueMapImage(IntPtr, IntPtr, Bool, MapFlags, nuint*, nuint*, nuint*, nuint*, uint, IntPtr*, IntPtr*, int*)"/>
        public static unsafe void* EnqueueMapImage(IntPtr command_queue, IntPtr image, Bool blocking_map, MapFlags map_flags, nuint[] origin, nuint[] region, nuint[] image_row_pitch, nuint[] image_slice_pitch, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event, int[] errcode_ret)
        {
            void* returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (nuint* image_slice_pitch_ptr = image_slice_pitch)
                        {
                            fixed (nuint* image_row_pitch_ptr = image_row_pitch)
                            {
                                fixed (nuint* region_ptr = region)
                                {
                                    fixed (nuint* origin_ptr = origin)
                                    {
                                        returnValue = EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin_ptr, region_ptr, image_row_pitch_ptr, image_slice_pitch_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr, errcode_ret_ptr);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueMapImage(IntPtr, IntPtr, Bool, MapFlags, nuint*, nuint*, nuint*, nuint*, uint, IntPtr*, IntPtr*, int*)"/>
        public static unsafe void* EnqueueMapImage(IntPtr command_queue, IntPtr image, Bool blocking_map, MapFlags map_flags, ref readonly nuint origin, ref readonly nuint region, ref nuint image_row_pitch, ref nuint image_slice_pitch, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event, ref int errcode_ret)
        {
            void* returnValue;
            fixed (nuint* origin_ptr = &origin)
            fixed (nuint* region_ptr = &region)
            fixed (nuint* image_row_pitch_ptr = &image_row_pitch)
            fixed (nuint* image_slice_pitch_ptr = &image_slice_pitch)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                returnValue = EnqueueMapImage(command_queue, image, blocking_map, map_flags, origin_ptr, region_ptr, image_row_pitch_ptr, image_slice_pitch_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr, errcode_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueMarker(IntPtr, IntPtr*)"/>
        public static unsafe int EnqueueMarker(IntPtr command_queue, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                returnValue = EnqueueMarker(command_queue, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueMarker(IntPtr, IntPtr*)"/>
        public static unsafe int EnqueueMarker(IntPtr command_queue, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                returnValue = EnqueueMarker(command_queue, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueMarker(IntPtr, IntPtr*)"/>
        public static unsafe int EnqueueMarker(IntPtr command_queue, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueMarker(command_queue, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueMarkerWithWaitList(IntPtr, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueMarkerWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    returnValue = EnqueueMarkerWithWaitList(command_queue, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueMarkerWithWaitList(IntPtr, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueMarkerWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    returnValue = EnqueueMarkerWithWaitList(command_queue, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueMarkerWithWaitList(IntPtr, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueMarkerWithWaitList(IntPtr command_queue, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueMarkerWithWaitList(command_queue, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueMigrateMemObjects(IntPtr, uint, IntPtr*, MemMigrationFlags, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueMigrateMemObjects(IntPtr command_queue, uint num_mem_objects, Span<IntPtr> mem_objects, MemMigrationFlags flags, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (IntPtr* mem_objects_ptr = mem_objects)
                    {
                        returnValue = EnqueueMigrateMemObjects(command_queue, num_mem_objects, mem_objects_ptr, flags, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueMigrateMemObjects(IntPtr, uint, IntPtr*, MemMigrationFlags, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueMigrateMemObjects(IntPtr command_queue, uint num_mem_objects, IntPtr[] mem_objects, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (IntPtr* mem_objects_ptr = mem_objects)
                    {
                        returnValue = EnqueueMigrateMemObjects(command_queue, num_mem_objects, mem_objects_ptr, flags, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueMigrateMemObjects(IntPtr, uint, IntPtr*, MemMigrationFlags, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueMigrateMemObjects(IntPtr command_queue, uint num_mem_objects, ref IntPtr mem_objects, MemMigrationFlags flags, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* mem_objects_ptr = &mem_objects)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueMigrateMemObjects(command_queue, num_mem_objects, mem_objects_ptr, flags, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueNativeKernel(IntPtr, delegate* unmanaged[Cdecl]<void*, void>, void*, nuint, uint, IntPtr*, void**, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueNativeKernel(IntPtr command_queue, delegate* unmanaged[Cdecl]<void*, void> user_func, IntPtr args, nuint cb_args, uint num_mem_objects, Span<IntPtr> mem_list, void** args_mem_loc, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (IntPtr* mem_list_ptr = mem_list)
                    {
                        void* args_vptr = (void*)args;
                        returnValue = EnqueueNativeKernel(command_queue, user_func, args_vptr, cb_args, num_mem_objects, mem_list_ptr, args_mem_loc, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueNativeKernel(IntPtr, delegate* unmanaged[Cdecl]<void*, void>, void*, nuint, uint, IntPtr*, void**, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueNativeKernel(IntPtr command_queue, delegate* unmanaged[Cdecl]<void*, void> user_func, IntPtr args, nuint cb_args, uint num_mem_objects, IntPtr[] mem_list, void** args_mem_loc, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (IntPtr* mem_list_ptr = mem_list)
                    {
                        void* args_vptr = (void*)args;
                        returnValue = EnqueueNativeKernel(command_queue, user_func, args_vptr, cb_args, num_mem_objects, mem_list_ptr, args_mem_loc, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueNativeKernel(IntPtr, delegate* unmanaged[Cdecl]<void*, void>, void*, nuint, uint, IntPtr*, void**, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueNativeKernel(IntPtr command_queue, delegate* unmanaged[Cdecl]<void*, void> user_func, IntPtr args, nuint cb_args, uint num_mem_objects, ref IntPtr mem_list, void** args_mem_loc, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* mem_list_ptr = &mem_list)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                void* args_vptr = (void*)args;
                returnValue = EnqueueNativeKernel(command_queue, user_func, args_vptr, cb_args, num_mem_objects, mem_list_ptr, args_mem_loc, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueNativeKernel(IntPtr, delegate* unmanaged[Cdecl]<void*, void>, void*, nuint, uint, IntPtr*, void**, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueNativeKernel<T1>(IntPtr command_queue, delegate* unmanaged[Cdecl]<void*, void> user_func, Span<T1> args, nuint cb_args, uint num_mem_objects, Span<IntPtr> mem_list, void** args_mem_loc, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (IntPtr* mem_list_ptr = mem_list)
                    {
                        fixed (void* args_ptr = args)
                        {
                            returnValue = EnqueueNativeKernel(command_queue, user_func, args_ptr, cb_args, num_mem_objects, mem_list_ptr, args_mem_loc, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueNativeKernel(IntPtr, delegate* unmanaged[Cdecl]<void*, void>, void*, nuint, uint, IntPtr*, void**, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueNativeKernel<T1>(IntPtr command_queue, delegate* unmanaged[Cdecl]<void*, void> user_func, T1[] args, nuint cb_args, uint num_mem_objects, IntPtr[] mem_list, void** args_mem_loc, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (IntPtr* mem_list_ptr = mem_list)
                    {
                        fixed (void* args_ptr = args)
                        {
                            returnValue = EnqueueNativeKernel(command_queue, user_func, args_ptr, cb_args, num_mem_objects, mem_list_ptr, args_mem_loc, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueNativeKernel(IntPtr, delegate* unmanaged[Cdecl]<void*, void>, void*, nuint, uint, IntPtr*, void**, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueNativeKernel<T1>(IntPtr command_queue, delegate* unmanaged[Cdecl]<void*, void> user_func, ref T1 args, nuint cb_args, uint num_mem_objects, ref IntPtr mem_list, void** args_mem_loc, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* args_ptr = &args)
            fixed (IntPtr* mem_list_ptr = &mem_list)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueNativeKernel(command_queue, user_func, args_ptr, cb_args, num_mem_objects, mem_list_ptr, args_mem_loc, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueNDRangeKernel(IntPtr, IntPtr, uint, nuint*, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueNDRangeKernel(IntPtr command_queue, IntPtr kernel, uint work_dim, ReadOnlySpan<nuint> global_work_offset, ReadOnlySpan<nuint> global_work_size, ReadOnlySpan<nuint> local_work_size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* local_work_size_ptr = local_work_size)
                    {
                        fixed (nuint* global_work_size_ptr = global_work_size)
                        {
                            fixed (nuint* global_work_offset_ptr = global_work_offset)
                            {
                                returnValue = EnqueueNDRangeKernel(command_queue, kernel, work_dim, global_work_offset_ptr, global_work_size_ptr, local_work_size_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueNDRangeKernel(IntPtr, IntPtr, uint, nuint*, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueNDRangeKernel(IntPtr command_queue, IntPtr kernel, uint work_dim, nuint[] global_work_offset, nuint[] global_work_size, nuint[] local_work_size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* local_work_size_ptr = local_work_size)
                    {
                        fixed (nuint* global_work_size_ptr = global_work_size)
                        {
                            fixed (nuint* global_work_offset_ptr = global_work_offset)
                            {
                                returnValue = EnqueueNDRangeKernel(command_queue, kernel, work_dim, global_work_offset_ptr, global_work_size_ptr, local_work_size_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueNDRangeKernel(IntPtr, IntPtr, uint, nuint*, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueNDRangeKernel(IntPtr command_queue, IntPtr kernel, uint work_dim, ref readonly nuint global_work_offset, ref readonly nuint global_work_size, ref readonly nuint local_work_size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (nuint* global_work_offset_ptr = &global_work_offset)
            fixed (nuint* global_work_size_ptr = &global_work_size)
            fixed (nuint* local_work_size_ptr = &local_work_size)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueNDRangeKernel(command_queue, kernel, work_dim, global_work_offset_ptr, global_work_size_ptr, local_work_size_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadBuffer(IntPtr, IntPtr, Bool, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadBuffer(IntPtr command_queue, IntPtr buffer, Bool blocking_read, nuint offset, nuint size, IntPtr ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* ptr_vptr = (void*)ptr;
                    returnValue = EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadBuffer(IntPtr, IntPtr, Bool, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadBuffer(IntPtr command_queue, IntPtr buffer, Bool blocking_read, nuint offset, nuint size, IntPtr ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* ptr_vptr = (void*)ptr;
                    returnValue = EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadBuffer(IntPtr, IntPtr, Bool, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadBuffer(IntPtr command_queue, IntPtr buffer, Bool blocking_read, nuint offset, nuint size, IntPtr ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                void* ptr_vptr = (void*)ptr;
                returnValue = EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadBuffer(IntPtr, IntPtr, Bool, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadBuffer<T1>(IntPtr command_queue, IntPtr buffer, Bool blocking_read, nuint offset, nuint size, Span<T1> ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* ptr_ptr = ptr)
                    {
                        returnValue = EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadBuffer(IntPtr, IntPtr, Bool, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadBuffer<T1>(IntPtr command_queue, IntPtr buffer, Bool blocking_read, nuint offset, nuint size, T1[] ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* ptr_ptr = ptr)
                    {
                        returnValue = EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadBuffer(IntPtr, IntPtr, Bool, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadBuffer<T1>(IntPtr command_queue, IntPtr buffer, Bool blocking_read, nuint offset, nuint size, ref T1 ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* ptr_ptr = &ptr)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueReadBuffer(command_queue, buffer, blocking_read, offset, size, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadBufferRect(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadBufferRect(IntPtr command_queue, IntPtr buffer, Bool blocking_read, ReadOnlySpan<nuint> buffer_origin, ReadOnlySpan<nuint> host_origin, ReadOnlySpan<nuint> region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* host_origin_ptr = host_origin)
                        {
                            fixed (nuint* buffer_origin_ptr = buffer_origin)
                            {
                                void* ptr_vptr = (void*)ptr;
                                returnValue = EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin_ptr, host_origin_ptr, region_ptr, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadBufferRect(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadBufferRect(IntPtr command_queue, IntPtr buffer, Bool blocking_read, nuint[] buffer_origin, nuint[] host_origin, nuint[] region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* host_origin_ptr = host_origin)
                        {
                            fixed (nuint* buffer_origin_ptr = buffer_origin)
                            {
                                void* ptr_vptr = (void*)ptr;
                                returnValue = EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin_ptr, host_origin_ptr, region_ptr, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadBufferRect(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadBufferRect(IntPtr command_queue, IntPtr buffer, Bool blocking_read, ref readonly nuint buffer_origin, ref readonly nuint host_origin, ref readonly nuint region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (nuint* buffer_origin_ptr = &buffer_origin)
            fixed (nuint* host_origin_ptr = &host_origin)
            fixed (nuint* region_ptr = &region)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                void* ptr_vptr = (void*)ptr;
                returnValue = EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin_ptr, host_origin_ptr, region_ptr, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadBufferRect(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadBufferRect<T1>(IntPtr command_queue, IntPtr buffer, Bool blocking_read, ReadOnlySpan<nuint> buffer_origin, ReadOnlySpan<nuint> host_origin, ReadOnlySpan<nuint> region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, Span<T1> ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* ptr_ptr = ptr)
                    {
                        fixed (nuint* region_ptr = region)
                        {
                            fixed (nuint* host_origin_ptr = host_origin)
                            {
                                fixed (nuint* buffer_origin_ptr = buffer_origin)
                                {
                                    returnValue = EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin_ptr, host_origin_ptr, region_ptr, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                                }
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadBufferRect(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadBufferRect<T1>(IntPtr command_queue, IntPtr buffer, Bool blocking_read, nuint[] buffer_origin, nuint[] host_origin, nuint[] region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, T1[] ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* ptr_ptr = ptr)
                    {
                        fixed (nuint* region_ptr = region)
                        {
                            fixed (nuint* host_origin_ptr = host_origin)
                            {
                                fixed (nuint* buffer_origin_ptr = buffer_origin)
                                {
                                    returnValue = EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin_ptr, host_origin_ptr, region_ptr, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                                }
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadBufferRect(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadBufferRect<T1>(IntPtr command_queue, IntPtr buffer, Bool blocking_read, ref readonly nuint buffer_origin, ref readonly nuint host_origin, ref readonly nuint region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, ref T1 ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* buffer_origin_ptr = &buffer_origin)
            fixed (nuint* host_origin_ptr = &host_origin)
            fixed (nuint* region_ptr = &region)
            fixed (void* ptr_ptr = &ptr)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueReadBufferRect(command_queue, buffer, blocking_read, buffer_origin_ptr, host_origin_ptr, region_ptr, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadImage(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadImage(IntPtr command_queue, IntPtr image, Bool blocking_read, ReadOnlySpan<nuint> origin, ReadOnlySpan<nuint> region, nuint row_pitch, nuint slice_pitch, IntPtr ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* origin_ptr = origin)
                        {
                            void* ptr_vptr = (void*)ptr;
                            returnValue = EnqueueReadImage(command_queue, image, blocking_read, origin_ptr, region_ptr, row_pitch, slice_pitch, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadImage(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadImage(IntPtr command_queue, IntPtr image, Bool blocking_read, nuint[] origin, nuint[] region, nuint row_pitch, nuint slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* origin_ptr = origin)
                        {
                            void* ptr_vptr = (void*)ptr;
                            returnValue = EnqueueReadImage(command_queue, image, blocking_read, origin_ptr, region_ptr, row_pitch, slice_pitch, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadImage(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadImage(IntPtr command_queue, IntPtr image, Bool blocking_read, ref readonly nuint origin, ref readonly nuint region, nuint row_pitch, nuint slice_pitch, IntPtr ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (nuint* origin_ptr = &origin)
            fixed (nuint* region_ptr = &region)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                void* ptr_vptr = (void*)ptr;
                returnValue = EnqueueReadImage(command_queue, image, blocking_read, origin_ptr, region_ptr, row_pitch, slice_pitch, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadImage(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadImage<T1>(IntPtr command_queue, IntPtr image, Bool blocking_read, ReadOnlySpan<nuint> origin, ReadOnlySpan<nuint> region, nuint row_pitch, nuint slice_pitch, Span<T1> ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* ptr_ptr = ptr)
                    {
                        fixed (nuint* region_ptr = region)
                        {
                            fixed (nuint* origin_ptr = origin)
                            {
                                returnValue = EnqueueReadImage(command_queue, image, blocking_read, origin_ptr, region_ptr, row_pitch, slice_pitch, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadImage(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadImage<T1>(IntPtr command_queue, IntPtr image, Bool blocking_read, nuint[] origin, nuint[] region, nuint row_pitch, nuint slice_pitch, T1[] ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* ptr_ptr = ptr)
                    {
                        fixed (nuint* region_ptr = region)
                        {
                            fixed (nuint* origin_ptr = origin)
                            {
                                returnValue = EnqueueReadImage(command_queue, image, blocking_read, origin_ptr, region_ptr, row_pitch, slice_pitch, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueReadImage(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueReadImage<T1>(IntPtr command_queue, IntPtr image, Bool blocking_read, ref readonly nuint origin, ref readonly nuint region, nuint row_pitch, nuint slice_pitch, ref T1 ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* origin_ptr = &origin)
            fixed (nuint* region_ptr = &region)
            fixed (void* ptr_ptr = &ptr)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueReadImage(command_queue, image, blocking_read, origin_ptr, region_ptr, row_pitch, slice_pitch, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMFree(IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMFree(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, IntPtr user_data, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* user_data_vptr = (void*)user_data;
                    returnValue = EnqueueSVMFree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMFree(IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMFree(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, IntPtr user_data, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* user_data_vptr = (void*)user_data;
                    returnValue = EnqueueSVMFree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMFree(IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMFree(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, IntPtr user_data, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                void* user_data_vptr = (void*)user_data;
                returnValue = EnqueueSVMFree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMFree(IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMFree<T1>(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, Span<T1> user_data, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* user_data_ptr = user_data)
                    {
                        returnValue = EnqueueSVMFree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMFree(IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMFree<T1>(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, T1[] user_data, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* user_data_ptr = user_data)
                    {
                        returnValue = EnqueueSVMFree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMFree(IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMFree<T1>(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, ref T1 user_data, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = &user_data)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueSVMFree(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMap(IntPtr, Bool, MapFlags, void*, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMap(IntPtr command_queue, Bool blocking_map, MapFlags flags, IntPtr svm_ptr, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* svm_ptr_vptr = (void*)svm_ptr;
                    returnValue = EnqueueSVMMap(command_queue, blocking_map, flags, svm_ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMap(IntPtr, Bool, MapFlags, void*, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMap(IntPtr command_queue, Bool blocking_map, MapFlags flags, IntPtr svm_ptr, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* svm_ptr_vptr = (void*)svm_ptr;
                    returnValue = EnqueueSVMMap(command_queue, blocking_map, flags, svm_ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMap(IntPtr, Bool, MapFlags, void*, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMap(IntPtr command_queue, Bool blocking_map, MapFlags flags, IntPtr svm_ptr, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                void* svm_ptr_vptr = (void*)svm_ptr;
                returnValue = EnqueueSVMMap(command_queue, blocking_map, flags, svm_ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMap(IntPtr, Bool, MapFlags, void*, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMap<T1>(IntPtr command_queue, Bool blocking_map, MapFlags flags, Span<T1> svm_ptr, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* svm_ptr_ptr = svm_ptr)
                    {
                        returnValue = EnqueueSVMMap(command_queue, blocking_map, flags, svm_ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMap(IntPtr, Bool, MapFlags, void*, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMap<T1>(IntPtr command_queue, Bool blocking_map, MapFlags flags, T1[] svm_ptr, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* svm_ptr_ptr = svm_ptr)
                    {
                        returnValue = EnqueueSVMMap(command_queue, blocking_map, flags, svm_ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMap(IntPtr, Bool, MapFlags, void*, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMap<T1>(IntPtr command_queue, Bool blocking_map, MapFlags flags, ref T1 svm_ptr, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* svm_ptr_ptr = &svm_ptr)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueSVMMap(command_queue, blocking_map, flags, svm_ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMemcpy(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMemcpy(IntPtr command_queue, Bool blocking_copy, IntPtr dst_ptr, IntPtr src_ptr, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* dst_ptr_vptr = (void*)dst_ptr;
                    void* src_ptr_vptr = (void*)src_ptr;
                    returnValue = EnqueueSVMMemcpy(command_queue, blocking_copy, dst_ptr_vptr, src_ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMemcpy(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMemcpy(IntPtr command_queue, Bool blocking_copy, IntPtr dst_ptr, IntPtr src_ptr, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* dst_ptr_vptr = (void*)dst_ptr;
                    void* src_ptr_vptr = (void*)src_ptr;
                    returnValue = EnqueueSVMMemcpy(command_queue, blocking_copy, dst_ptr_vptr, src_ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMemcpy(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMemcpy(IntPtr command_queue, Bool blocking_copy, IntPtr dst_ptr, IntPtr src_ptr, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                void* dst_ptr_vptr = (void*)dst_ptr;
                void* src_ptr_vptr = (void*)src_ptr;
                returnValue = EnqueueSVMMemcpy(command_queue, blocking_copy, dst_ptr_vptr, src_ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMemcpy(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMemcpy<T1, T2>(IntPtr command_queue, Bool blocking_copy, Span<T1> dst_ptr, ReadOnlySpan<T2> src_ptr, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            where T1 : unmanaged
            where T2 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* src_ptr_ptr = src_ptr)
                    {
                        fixed (void* dst_ptr_ptr = dst_ptr)
                        {
                            returnValue = EnqueueSVMMemcpy(command_queue, blocking_copy, dst_ptr_ptr, src_ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMemcpy(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMemcpy<T1, T2>(IntPtr command_queue, Bool blocking_copy, T1[] dst_ptr, T2[] src_ptr, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            where T1 : unmanaged
            where T2 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* src_ptr_ptr = src_ptr)
                    {
                        fixed (void* dst_ptr_ptr = dst_ptr)
                        {
                            returnValue = EnqueueSVMMemcpy(command_queue, blocking_copy, dst_ptr_ptr, src_ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMemcpy(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMemcpy<T1, T2>(IntPtr command_queue, Bool blocking_copy, ref T1 dst_ptr, ref readonly T2 src_ptr, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            where T1 : unmanaged
            where T2 : unmanaged
        {
            int returnValue;
            fixed (void* dst_ptr_ptr = &dst_ptr)
            fixed (void* src_ptr_ptr = &src_ptr)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueSVMMemcpy(command_queue, blocking_copy, dst_ptr_ptr, src_ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMemFill(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMemFill(IntPtr command_queue, IntPtr svm_ptr, IntPtr pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* svm_ptr_vptr = (void*)svm_ptr;
                    void* pattern_vptr = (void*)pattern;
                    returnValue = EnqueueSVMMemFill(command_queue, svm_ptr_vptr, pattern_vptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMemFill(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMemFill(IntPtr command_queue, IntPtr svm_ptr, IntPtr pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* svm_ptr_vptr = (void*)svm_ptr;
                    void* pattern_vptr = (void*)pattern;
                    returnValue = EnqueueSVMMemFill(command_queue, svm_ptr_vptr, pattern_vptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMemFill(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMemFill(IntPtr command_queue, IntPtr svm_ptr, IntPtr pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                void* svm_ptr_vptr = (void*)svm_ptr;
                void* pattern_vptr = (void*)pattern;
                returnValue = EnqueueSVMMemFill(command_queue, svm_ptr_vptr, pattern_vptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMemFill(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMemFill<T1, T2>(IntPtr command_queue, Span<T1> svm_ptr, ReadOnlySpan<T2> pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            where T1 : unmanaged
            where T2 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* pattern_ptr = pattern)
                    {
                        fixed (void* svm_ptr_ptr = svm_ptr)
                        {
                            returnValue = EnqueueSVMMemFill(command_queue, svm_ptr_ptr, pattern_ptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMemFill(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMemFill<T1, T2>(IntPtr command_queue, T1[] svm_ptr, T2[] pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            where T1 : unmanaged
            where T2 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* pattern_ptr = pattern)
                    {
                        fixed (void* svm_ptr_ptr = svm_ptr)
                        {
                            returnValue = EnqueueSVMMemFill(command_queue, svm_ptr_ptr, pattern_ptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMemFill(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMemFill<T1, T2>(IntPtr command_queue, ref T1 svm_ptr, ref readonly T2 pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            where T1 : unmanaged
            where T2 : unmanaged
        {
            int returnValue;
            fixed (void* svm_ptr_ptr = &svm_ptr)
            fixed (void* pattern_ptr = &pattern)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueSVMMemFill(command_queue, svm_ptr_ptr, pattern_ptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMigrateMem(IntPtr, uint, void**, nuint*, MemMigrationFlags, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMigrateMem(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, ReadOnlySpan<nuint> sizes, MemMigrationFlags flags, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* sizes_ptr = sizes)
                    {
                        returnValue = EnqueueSVMMigrateMem(command_queue, num_svm_pointers, svm_pointers, sizes_ptr, flags, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMigrateMem(IntPtr, uint, void**, nuint*, MemMigrationFlags, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMigrateMem(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, nuint[] sizes, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* sizes_ptr = sizes)
                    {
                        returnValue = EnqueueSVMMigrateMem(command_queue, num_svm_pointers, svm_pointers, sizes_ptr, flags, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMMigrateMem(IntPtr, uint, void**, nuint*, MemMigrationFlags, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMMigrateMem(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, ref readonly nuint sizes, MemMigrationFlags flags, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (nuint* sizes_ptr = &sizes)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueSVMMigrateMem(command_queue, num_svm_pointers, svm_pointers, sizes_ptr, flags, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMUnmap(IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMUnmap(IntPtr command_queue, IntPtr svm_ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* svm_ptr_vptr = (void*)svm_ptr;
                    returnValue = EnqueueSVMUnmap(command_queue, svm_ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMUnmap(IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMUnmap(IntPtr command_queue, IntPtr svm_ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* svm_ptr_vptr = (void*)svm_ptr;
                    returnValue = EnqueueSVMUnmap(command_queue, svm_ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMUnmap(IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMUnmap(IntPtr command_queue, IntPtr svm_ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                void* svm_ptr_vptr = (void*)svm_ptr;
                returnValue = EnqueueSVMUnmap(command_queue, svm_ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMUnmap(IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMUnmap<T1>(IntPtr command_queue, Span<T1> svm_ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* svm_ptr_ptr = svm_ptr)
                    {
                        returnValue = EnqueueSVMUnmap(command_queue, svm_ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMUnmap(IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMUnmap<T1>(IntPtr command_queue, T1[] svm_ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* svm_ptr_ptr = svm_ptr)
                    {
                        returnValue = EnqueueSVMUnmap(command_queue, svm_ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueSVMUnmap(IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueSVMUnmap<T1>(IntPtr command_queue, ref T1 svm_ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* svm_ptr_ptr = &svm_ptr)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueSVMUnmap(command_queue, svm_ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueTask(IntPtr, IntPtr, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueTask(IntPtr command_queue, IntPtr kernel, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    returnValue = EnqueueTask(command_queue, kernel, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueTask(IntPtr, IntPtr, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueTask(IntPtr command_queue, IntPtr kernel, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    returnValue = EnqueueTask(command_queue, kernel, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueTask(IntPtr, IntPtr, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueTask(IntPtr command_queue, IntPtr kernel, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueTask(command_queue, kernel, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueUnmapMemObject(IntPtr, IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueUnmapMemObject(IntPtr command_queue, IntPtr memobj, IntPtr mapped_ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* mapped_ptr_vptr = (void*)mapped_ptr;
                    returnValue = EnqueueUnmapMemObject(command_queue, memobj, mapped_ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueUnmapMemObject(IntPtr, IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueUnmapMemObject(IntPtr command_queue, IntPtr memobj, IntPtr mapped_ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* mapped_ptr_vptr = (void*)mapped_ptr;
                    returnValue = EnqueueUnmapMemObject(command_queue, memobj, mapped_ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueUnmapMemObject(IntPtr, IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueUnmapMemObject(IntPtr command_queue, IntPtr memobj, IntPtr mapped_ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                void* mapped_ptr_vptr = (void*)mapped_ptr;
                returnValue = EnqueueUnmapMemObject(command_queue, memobj, mapped_ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueUnmapMemObject(IntPtr, IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueUnmapMemObject<T1>(IntPtr command_queue, IntPtr memobj, Span<T1> mapped_ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* mapped_ptr_ptr = mapped_ptr)
                    {
                        returnValue = EnqueueUnmapMemObject(command_queue, memobj, mapped_ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueUnmapMemObject(IntPtr, IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueUnmapMemObject<T1>(IntPtr command_queue, IntPtr memobj, T1[] mapped_ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* mapped_ptr_ptr = mapped_ptr)
                    {
                        returnValue = EnqueueUnmapMemObject(command_queue, memobj, mapped_ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueUnmapMemObject(IntPtr, IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueUnmapMemObject<T1>(IntPtr command_queue, IntPtr memobj, ref T1 mapped_ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* mapped_ptr_ptr = &mapped_ptr)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueUnmapMemObject(command_queue, memobj, mapped_ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWaitForEvents(IntPtr, uint, IntPtr*)"/>
        public static unsafe int EnqueueWaitForEvents(IntPtr command_queue, uint num_events, Span<IntPtr> event_list)
        {
            int returnValue;
            fixed (IntPtr* event_list_ptr = event_list)
            {
                returnValue = EnqueueWaitForEvents(command_queue, num_events, event_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWaitForEvents(IntPtr, uint, IntPtr*)"/>
        public static unsafe int EnqueueWaitForEvents(IntPtr command_queue, uint num_events, IntPtr[] event_list)
        {
            int returnValue;
            fixed (IntPtr* event_list_ptr = event_list)
            {
                returnValue = EnqueueWaitForEvents(command_queue, num_events, event_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWaitForEvents(IntPtr, uint, IntPtr*)"/>
        public static unsafe int EnqueueWaitForEvents(IntPtr command_queue, uint num_events, ref IntPtr event_list)
        {
            int returnValue;
            fixed (IntPtr* event_list_ptr = &event_list)
            {
                returnValue = EnqueueWaitForEvents(command_queue, num_events, event_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteBuffer(IntPtr, IntPtr, Bool, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteBuffer(IntPtr command_queue, IntPtr buffer, Bool blocking_write, nuint offset, nuint size, IntPtr ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* ptr_vptr = (void*)ptr;
                    returnValue = EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteBuffer(IntPtr, IntPtr, Bool, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteBuffer(IntPtr command_queue, IntPtr buffer, Bool blocking_write, nuint offset, nuint size, IntPtr ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    void* ptr_vptr = (void*)ptr;
                    returnValue = EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteBuffer(IntPtr, IntPtr, Bool, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteBuffer(IntPtr command_queue, IntPtr buffer, Bool blocking_write, nuint offset, nuint size, IntPtr ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                void* ptr_vptr = (void*)ptr;
                returnValue = EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteBuffer(IntPtr, IntPtr, Bool, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteBuffer<T1>(IntPtr command_queue, IntPtr buffer, Bool blocking_write, nuint offset, nuint size, ReadOnlySpan<T1> ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* ptr_ptr = ptr)
                    {
                        returnValue = EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteBuffer(IntPtr, IntPtr, Bool, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteBuffer<T1>(IntPtr command_queue, IntPtr buffer, Bool blocking_write, nuint offset, nuint size, T1[] ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* ptr_ptr = ptr)
                    {
                        returnValue = EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteBuffer(IntPtr, IntPtr, Bool, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteBuffer<T1>(IntPtr command_queue, IntPtr buffer, Bool blocking_write, nuint offset, nuint size, ref readonly T1 ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* ptr_ptr = &ptr)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueWriteBuffer(command_queue, buffer, blocking_write, offset, size, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteBufferRect(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteBufferRect(IntPtr command_queue, IntPtr buffer, Bool blocking_write, ReadOnlySpan<nuint> buffer_origin, ReadOnlySpan<nuint> host_origin, ReadOnlySpan<nuint> region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* host_origin_ptr = host_origin)
                        {
                            fixed (nuint* buffer_origin_ptr = buffer_origin)
                            {
                                void* ptr_vptr = (void*)ptr;
                                returnValue = EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin_ptr, host_origin_ptr, region_ptr, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteBufferRect(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteBufferRect(IntPtr command_queue, IntPtr buffer, Bool blocking_write, nuint[] buffer_origin, nuint[] host_origin, nuint[] region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* host_origin_ptr = host_origin)
                        {
                            fixed (nuint* buffer_origin_ptr = buffer_origin)
                            {
                                void* ptr_vptr = (void*)ptr;
                                returnValue = EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin_ptr, host_origin_ptr, region_ptr, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteBufferRect(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteBufferRect(IntPtr command_queue, IntPtr buffer, Bool blocking_write, ref readonly nuint buffer_origin, ref readonly nuint host_origin, ref readonly nuint region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (nuint* buffer_origin_ptr = &buffer_origin)
            fixed (nuint* host_origin_ptr = &host_origin)
            fixed (nuint* region_ptr = &region)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                void* ptr_vptr = (void*)ptr;
                returnValue = EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin_ptr, host_origin_ptr, region_ptr, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteBufferRect(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteBufferRect<T1>(IntPtr command_queue, IntPtr buffer, Bool blocking_write, ReadOnlySpan<nuint> buffer_origin, ReadOnlySpan<nuint> host_origin, ReadOnlySpan<nuint> region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, ReadOnlySpan<T1> ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* ptr_ptr = ptr)
                    {
                        fixed (nuint* region_ptr = region)
                        {
                            fixed (nuint* host_origin_ptr = host_origin)
                            {
                                fixed (nuint* buffer_origin_ptr = buffer_origin)
                                {
                                    returnValue = EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin_ptr, host_origin_ptr, region_ptr, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                                }
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteBufferRect(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteBufferRect<T1>(IntPtr command_queue, IntPtr buffer, Bool blocking_write, nuint[] buffer_origin, nuint[] host_origin, nuint[] region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, T1[] ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* ptr_ptr = ptr)
                    {
                        fixed (nuint* region_ptr = region)
                        {
                            fixed (nuint* host_origin_ptr = host_origin)
                            {
                                fixed (nuint* buffer_origin_ptr = buffer_origin)
                                {
                                    returnValue = EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin_ptr, host_origin_ptr, region_ptr, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                                }
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteBufferRect(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteBufferRect<T1>(IntPtr command_queue, IntPtr buffer, Bool blocking_write, ref readonly nuint buffer_origin, ref readonly nuint host_origin, ref readonly nuint region, nuint buffer_row_pitch, nuint buffer_slice_pitch, nuint host_row_pitch, nuint host_slice_pitch, ref readonly T1 ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* buffer_origin_ptr = &buffer_origin)
            fixed (nuint* host_origin_ptr = &host_origin)
            fixed (nuint* region_ptr = &region)
            fixed (void* ptr_ptr = &ptr)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueWriteBufferRect(command_queue, buffer, blocking_write, buffer_origin_ptr, host_origin_ptr, region_ptr, buffer_row_pitch, buffer_slice_pitch, host_row_pitch, host_slice_pitch, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteImage(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteImage(IntPtr command_queue, IntPtr image, Bool blocking_write, ReadOnlySpan<nuint> origin, ReadOnlySpan<nuint> region, nuint input_row_pitch, nuint input_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* origin_ptr = origin)
                        {
                            void* ptr_vptr = (void*)ptr;
                            returnValue = EnqueueWriteImage(command_queue, image, blocking_write, origin_ptr, region_ptr, input_row_pitch, input_slice_pitch, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteImage(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteImage(IntPtr command_queue, IntPtr image, Bool blocking_write, nuint[] origin, nuint[] region, nuint input_row_pitch, nuint input_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (nuint* region_ptr = region)
                    {
                        fixed (nuint* origin_ptr = origin)
                        {
                            void* ptr_vptr = (void*)ptr;
                            returnValue = EnqueueWriteImage(command_queue, image, blocking_write, origin_ptr, region_ptr, input_row_pitch, input_slice_pitch, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteImage(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteImage(IntPtr command_queue, IntPtr image, Bool blocking_write, ref readonly nuint origin, ref readonly nuint region, nuint input_row_pitch, nuint input_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
        {
            int returnValue;
            fixed (nuint* origin_ptr = &origin)
            fixed (nuint* region_ptr = &region)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                void* ptr_vptr = (void*)ptr;
                returnValue = EnqueueWriteImage(command_queue, image, blocking_write, origin_ptr, region_ptr, input_row_pitch, input_slice_pitch, ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteImage(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteImage<T1>(IntPtr command_queue, IntPtr image, Bool blocking_write, ReadOnlySpan<nuint> origin, ReadOnlySpan<nuint> region, nuint input_row_pitch, nuint input_slice_pitch, ReadOnlySpan<T1> ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* ptr_ptr = ptr)
                    {
                        fixed (nuint* region_ptr = region)
                        {
                            fixed (nuint* origin_ptr = origin)
                            {
                                returnValue = EnqueueWriteImage(command_queue, image, blocking_write, origin_ptr, region_ptr, input_row_pitch, input_slice_pitch, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteImage(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteImage<T1>(IntPtr command_queue, IntPtr image, Bool blocking_write, nuint[] origin, nuint[] region, nuint input_row_pitch, nuint input_slice_pitch, T1[] ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (IntPtr* @event_ptr = @event)
            {
                fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                {
                    fixed (void* ptr_ptr = ptr)
                    {
                        fixed (nuint* region_ptr = region)
                        {
                            fixed (nuint* origin_ptr = origin)
                            {
                                returnValue = EnqueueWriteImage(command_queue, image, blocking_write, origin_ptr, region_ptr, input_row_pitch, input_slice_pitch, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="EnqueueWriteImage(IntPtr, IntPtr, Bool, nuint*, nuint*, nuint, nuint, void*, uint, IntPtr*, IntPtr*)"/>
        public static unsafe int EnqueueWriteImage<T1>(IntPtr command_queue, IntPtr image, Bool blocking_write, ref readonly nuint origin, ref readonly nuint region, nuint input_row_pitch, nuint input_slice_pitch, ref readonly T1 ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* origin_ptr = &origin)
            fixed (nuint* region_ptr = &region)
            fixed (void* ptr_ptr = &ptr)
            fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
            fixed (IntPtr* @event_ptr = &@event)
            {
                returnValue = EnqueueWriteImage(command_queue, image, blocking_write, origin_ptr, region_ptr, input_row_pitch, input_slice_pitch, ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetCommandQueueInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetCommandQueueInfo(IntPtr command_queue, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetCommandQueueInfo(command_queue, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetCommandQueueInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetCommandQueueInfo(IntPtr command_queue, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetCommandQueueInfo(command_queue, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetCommandQueueInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetCommandQueueInfo(IntPtr command_queue, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetCommandQueueInfo(command_queue, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetCommandQueueInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetCommandQueueInfo<T1>(IntPtr command_queue, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetCommandQueueInfo(command_queue, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetCommandQueueInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetCommandQueueInfo<T1>(IntPtr command_queue, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetCommandQueueInfo(command_queue, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetCommandQueueInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetCommandQueueInfo<T1>(IntPtr command_queue, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetCommandQueueInfo(command_queue, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetContextInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetContextInfo(IntPtr context, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetContextInfo(context, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetContextInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetContextInfo(IntPtr context, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetContextInfo(context, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetContextInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetContextInfo(IntPtr context, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetContextInfo(context, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetContextInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetContextInfo<T1>(IntPtr context, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetContextInfo(context, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetContextInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetContextInfo<T1>(IntPtr context, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetContextInfo(context, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetContextInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetContextInfo<T1>(IntPtr context, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetContextInfo(context, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetDeviceAndHostTimer(IntPtr, ulong*, ulong*)"/>
        public static unsafe int GetDeviceAndHostTimer(IntPtr device, Span<ulong> device_timestamp, Span<ulong> host_timestamp)
        {
            int returnValue;
            fixed (ulong* host_timestamp_ptr = host_timestamp)
            {
                fixed (ulong* device_timestamp_ptr = device_timestamp)
                {
                    returnValue = GetDeviceAndHostTimer(device, device_timestamp_ptr, host_timestamp_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetDeviceAndHostTimer(IntPtr, ulong*, ulong*)"/>
        public static unsafe int GetDeviceAndHostTimer(IntPtr device, ulong[] device_timestamp, ulong[] host_timestamp)
        {
            int returnValue;
            fixed (ulong* host_timestamp_ptr = host_timestamp)
            {
                fixed (ulong* device_timestamp_ptr = device_timestamp)
                {
                    returnValue = GetDeviceAndHostTimer(device, device_timestamp_ptr, host_timestamp_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetDeviceAndHostTimer(IntPtr, ulong*, ulong*)"/>
        public static unsafe int GetDeviceAndHostTimer(IntPtr device, ref ulong device_timestamp, ref ulong host_timestamp)
        {
            int returnValue;
            fixed (ulong* device_timestamp_ptr = &device_timestamp)
            fixed (ulong* host_timestamp_ptr = &host_timestamp)
            {
                returnValue = GetDeviceAndHostTimer(device, device_timestamp_ptr, host_timestamp_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetDeviceIDs(IntPtr, DeviceType, uint, IntPtr*, uint*)"/>
        public static unsafe int GetDeviceIDs(IntPtr platform, DeviceType device_type, uint num_entries, Span<IntPtr> devices, Span<uint> num_devices)
        {
            int returnValue;
            fixed (uint* num_devices_ptr = num_devices)
            {
                fixed (IntPtr* devices_ptr = devices)
                {
                    returnValue = GetDeviceIDs(platform, device_type, num_entries, devices_ptr, num_devices_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetDeviceIDs(IntPtr, DeviceType, uint, IntPtr*, uint*)"/>
        public static unsafe int GetDeviceIDs(IntPtr platform, DeviceType device_type, uint num_entries, IntPtr[] devices, uint[] num_devices)
        {
            int returnValue;
            fixed (uint* num_devices_ptr = num_devices)
            {
                fixed (IntPtr* devices_ptr = devices)
                {
                    returnValue = GetDeviceIDs(platform, device_type, num_entries, devices_ptr, num_devices_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetDeviceIDs(IntPtr, DeviceType, uint, IntPtr*, uint*)"/>
        public static unsafe int GetDeviceIDs(IntPtr platform, DeviceType device_type, uint num_entries, ref IntPtr devices, ref uint num_devices)
        {
            int returnValue;
            fixed (IntPtr* devices_ptr = &devices)
            fixed (uint* num_devices_ptr = &num_devices)
            {
                returnValue = GetDeviceIDs(platform, device_type, num_entries, devices_ptr, num_devices_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetDeviceInfo(IntPtr, DeviceInfo, nuint, void*, nuint*)"/>
        public static unsafe int GetDeviceInfo(IntPtr device, DeviceInfo param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetDeviceInfo(device, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetDeviceInfo(IntPtr, DeviceInfo, nuint, void*, nuint*)"/>
        public static unsafe int GetDeviceInfo(IntPtr device, DeviceInfo param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetDeviceInfo(device, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetDeviceInfo(IntPtr, DeviceInfo, nuint, void*, nuint*)"/>
        public static unsafe int GetDeviceInfo(IntPtr device, DeviceInfo param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetDeviceInfo(device, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetDeviceInfo(IntPtr, DeviceInfo, nuint, void*, nuint*)"/>
        public static unsafe int GetDeviceInfo<T1>(IntPtr device, DeviceInfo param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetDeviceInfo(device, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetDeviceInfo(IntPtr, DeviceInfo, nuint, void*, nuint*)"/>
        public static unsafe int GetDeviceInfo<T1>(IntPtr device, DeviceInfo param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetDeviceInfo(device, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetDeviceInfo(IntPtr, DeviceInfo, nuint, void*, nuint*)"/>
        public static unsafe int GetDeviceInfo<T1>(IntPtr device, DeviceInfo param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetDeviceInfo(device, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEventInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetEventInfo(IntPtr @event, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetEventInfo(@event, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEventInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetEventInfo(IntPtr @event, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetEventInfo(@event, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEventInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetEventInfo(IntPtr @event, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetEventInfo(@event, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEventInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetEventInfo<T1>(IntPtr @event, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetEventInfo(@event, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEventInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetEventInfo<T1>(IntPtr @event, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetEventInfo(@event, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEventInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetEventInfo<T1>(IntPtr @event, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetEventInfo(@event, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEventProfilingInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetEventProfilingInfo(IntPtr @event, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetEventProfilingInfo(@event, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEventProfilingInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetEventProfilingInfo(IntPtr @event, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetEventProfilingInfo(@event, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEventProfilingInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetEventProfilingInfo(IntPtr @event, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetEventProfilingInfo(@event, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEventProfilingInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetEventProfilingInfo<T1>(IntPtr @event, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetEventProfilingInfo(@event, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEventProfilingInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetEventProfilingInfo<T1>(IntPtr @event, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetEventProfilingInfo(@event, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEventProfilingInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetEventProfilingInfo<T1>(IntPtr @event, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetEventProfilingInfo(@event, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetExtensionFunctionAddress(byte*)"/>
        public static unsafe void* GetExtensionFunctionAddress(string func_name)
        {
            void* returnValue;
            byte* func_name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(func_name);
            returnValue = GetExtensionFunctionAddress(func_name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)func_name_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="GetExtensionFunctionAddressForPlatform(IntPtr, byte*)"/>
        public static unsafe void* GetExtensionFunctionAddressForPlatform(IntPtr platform, string func_name)
        {
            void* returnValue;
            byte* func_name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(func_name);
            returnValue = GetExtensionFunctionAddressForPlatform(platform, func_name_ptr);
            Marshal.FreeCoTaskMem((IntPtr)func_name_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="GetHostTimer(IntPtr, ulong*)"/>
        public static unsafe int GetHostTimer(IntPtr device, Span<ulong> host_timestamp)
        {
            int returnValue;
            fixed (ulong* host_timestamp_ptr = host_timestamp)
            {
                returnValue = GetHostTimer(device, host_timestamp_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetHostTimer(IntPtr, ulong*)"/>
        public static unsafe int GetHostTimer(IntPtr device, ulong[] host_timestamp)
        {
            int returnValue;
            fixed (ulong* host_timestamp_ptr = host_timestamp)
            {
                returnValue = GetHostTimer(device, host_timestamp_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetHostTimer(IntPtr, ulong*)"/>
        public static unsafe int GetHostTimer(IntPtr device, ref ulong host_timestamp)
        {
            int returnValue;
            fixed (ulong* host_timestamp_ptr = &host_timestamp)
            {
                returnValue = GetHostTimer(device, host_timestamp_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetImageInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetImageInfo(IntPtr image, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetImageInfo(image, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetImageInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetImageInfo(IntPtr image, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetImageInfo(image, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetImageInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetImageInfo(IntPtr image, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetImageInfo(image, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetImageInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetImageInfo<T1>(IntPtr image, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetImageInfo(image, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetImageInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetImageInfo<T1>(IntPtr image, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetImageInfo(image, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetImageInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetImageInfo<T1>(IntPtr image, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetImageInfo(image, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelArgInfo(IntPtr, uint, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelArgInfo(IntPtr kernel, uint arg_index, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetKernelArgInfo(kernel, arg_index, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelArgInfo(IntPtr, uint, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelArgInfo(IntPtr kernel, uint arg_index, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetKernelArgInfo(kernel, arg_index, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelArgInfo(IntPtr, uint, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelArgInfo(IntPtr kernel, uint arg_index, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetKernelArgInfo(kernel, arg_index, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelArgInfo(IntPtr, uint, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelArgInfo<T1>(IntPtr kernel, uint arg_index, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetKernelArgInfo(kernel, arg_index, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelArgInfo(IntPtr, uint, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelArgInfo<T1>(IntPtr kernel, uint arg_index, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetKernelArgInfo(kernel, arg_index, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelArgInfo(IntPtr, uint, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelArgInfo<T1>(IntPtr kernel, uint arg_index, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetKernelArgInfo(kernel, arg_index, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelInfo(IntPtr kernel, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetKernelInfo(kernel, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelInfo(IntPtr kernel, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetKernelInfo(kernel, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelInfo(IntPtr kernel, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetKernelInfo(kernel, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelInfo<T1>(IntPtr kernel, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetKernelInfo(kernel, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelInfo<T1>(IntPtr kernel, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetKernelInfo(kernel, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelInfo<T1>(IntPtr kernel, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetKernelInfo(kernel, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelSubGroupInfo(IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelSubGroupInfo(IntPtr kernel, IntPtr device, uint param_name, nuint input_value_size, IntPtr input_value, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* input_value_vptr = (void*)input_value;
                void* param_value_vptr = (void*)param_value;
                returnValue = GetKernelSubGroupInfo(kernel, device, param_name, input_value_size, input_value_vptr, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelSubGroupInfo(IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelSubGroupInfo(IntPtr kernel, IntPtr device, uint param_name, nuint input_value_size, IntPtr input_value, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* input_value_vptr = (void*)input_value;
                void* param_value_vptr = (void*)param_value;
                returnValue = GetKernelSubGroupInfo(kernel, device, param_name, input_value_size, input_value_vptr, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelSubGroupInfo(IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelSubGroupInfo(IntPtr kernel, IntPtr device, uint param_name, nuint input_value_size, IntPtr input_value, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* input_value_vptr = (void*)input_value;
                void* param_value_vptr = (void*)param_value;
                returnValue = GetKernelSubGroupInfo(kernel, device, param_name, input_value_size, input_value_vptr, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelSubGroupInfo(IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelSubGroupInfo<T1, T2>(IntPtr kernel, IntPtr device, uint param_name, nuint input_value_size, ReadOnlySpan<T1> input_value, nuint param_value_size, Span<T2> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
            where T2 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    fixed (void* input_value_ptr = input_value)
                    {
                        returnValue = GetKernelSubGroupInfo(kernel, device, param_name, input_value_size, input_value_ptr, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelSubGroupInfo(IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelSubGroupInfo<T1, T2>(IntPtr kernel, IntPtr device, uint param_name, nuint input_value_size, T1[] input_value, nuint param_value_size, T2[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
            where T2 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    fixed (void* input_value_ptr = input_value)
                    {
                        returnValue = GetKernelSubGroupInfo(kernel, device, param_name, input_value_size, input_value_ptr, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelSubGroupInfo(IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelSubGroupInfo<T1, T2>(IntPtr kernel, IntPtr device, uint param_name, nuint input_value_size, ref readonly T1 input_value, nuint param_value_size, ref T2 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
            where T2 : unmanaged
        {
            int returnValue;
            fixed (void* input_value_ptr = &input_value)
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetKernelSubGroupInfo(kernel, device, param_name, input_value_size, input_value_ptr, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelSuggestedLocalWorkSize(IntPtr, IntPtr, uint, nuint*, nuint*, nuint*)"/>
        public static unsafe int GetKernelSuggestedLocalWorkSize(IntPtr command_queue, IntPtr kernel, uint work_dim, ReadOnlySpan<nuint> global_work_offset, ReadOnlySpan<nuint> global_work_size, Span<nuint> suggested_local_work_size)
        {
            int returnValue;
            fixed (nuint* suggested_local_work_size_ptr = suggested_local_work_size)
            {
                fixed (nuint* global_work_size_ptr = global_work_size)
                {
                    fixed (nuint* global_work_offset_ptr = global_work_offset)
                    {
                        returnValue = GetKernelSuggestedLocalWorkSize(command_queue, kernel, work_dim, global_work_offset_ptr, global_work_size_ptr, suggested_local_work_size_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelSuggestedLocalWorkSize(IntPtr, IntPtr, uint, nuint*, nuint*, nuint*)"/>
        public static unsafe int GetKernelSuggestedLocalWorkSize(IntPtr command_queue, IntPtr kernel, uint work_dim, nuint[] global_work_offset, nuint[] global_work_size, nuint[] suggested_local_work_size)
        {
            int returnValue;
            fixed (nuint* suggested_local_work_size_ptr = suggested_local_work_size)
            {
                fixed (nuint* global_work_size_ptr = global_work_size)
                {
                    fixed (nuint* global_work_offset_ptr = global_work_offset)
                    {
                        returnValue = GetKernelSuggestedLocalWorkSize(command_queue, kernel, work_dim, global_work_offset_ptr, global_work_size_ptr, suggested_local_work_size_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelSuggestedLocalWorkSize(IntPtr, IntPtr, uint, nuint*, nuint*, nuint*)"/>
        public static unsafe int GetKernelSuggestedLocalWorkSize(IntPtr command_queue, IntPtr kernel, uint work_dim, ref readonly nuint global_work_offset, ref readonly nuint global_work_size, ref nuint suggested_local_work_size)
        {
            int returnValue;
            fixed (nuint* global_work_offset_ptr = &global_work_offset)
            fixed (nuint* global_work_size_ptr = &global_work_size)
            fixed (nuint* suggested_local_work_size_ptr = &suggested_local_work_size)
            {
                returnValue = GetKernelSuggestedLocalWorkSize(command_queue, kernel, work_dim, global_work_offset_ptr, global_work_size_ptr, suggested_local_work_size_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelWorkGroupInfo(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelWorkGroupInfo(IntPtr kernel, IntPtr device, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelWorkGroupInfo(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelWorkGroupInfo(IntPtr kernel, IntPtr device, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelWorkGroupInfo(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelWorkGroupInfo(IntPtr kernel, IntPtr device, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelWorkGroupInfo(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelWorkGroupInfo<T1>(IntPtr kernel, IntPtr device, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelWorkGroupInfo(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelWorkGroupInfo<T1>(IntPtr kernel, IntPtr device, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetKernelWorkGroupInfo(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetKernelWorkGroupInfo<T1>(IntPtr kernel, IntPtr device, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetKernelWorkGroupInfo(kernel, device, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetMemObjectInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetMemObjectInfo(IntPtr memobj, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetMemObjectInfo(memobj, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetMemObjectInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetMemObjectInfo(IntPtr memobj, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetMemObjectInfo(memobj, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetMemObjectInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetMemObjectInfo(IntPtr memobj, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetMemObjectInfo(memobj, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetMemObjectInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetMemObjectInfo<T1>(IntPtr memobj, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetMemObjectInfo(memobj, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetMemObjectInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetMemObjectInfo<T1>(IntPtr memobj, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetMemObjectInfo(memobj, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetMemObjectInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetMemObjectInfo<T1>(IntPtr memobj, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetMemObjectInfo(memobj, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPipeInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetPipeInfo(IntPtr pipe, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetPipeInfo(pipe, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPipeInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetPipeInfo(IntPtr pipe, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetPipeInfo(pipe, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPipeInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetPipeInfo(IntPtr pipe, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetPipeInfo(pipe, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPipeInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetPipeInfo<T1>(IntPtr pipe, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetPipeInfo(pipe, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPipeInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetPipeInfo<T1>(IntPtr pipe, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetPipeInfo(pipe, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPipeInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetPipeInfo<T1>(IntPtr pipe, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetPipeInfo(pipe, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPlatformIDs(uint, IntPtr*, uint*)"/>
        public static unsafe int GetPlatformIDs(uint num_entries, Span<IntPtr> platforms, Span<uint> num_platforms)
        {
            int returnValue;
            fixed (uint* num_platforms_ptr = num_platforms)
            {
                fixed (IntPtr* platforms_ptr = platforms)
                {
                    returnValue = GetPlatformIDs(num_entries, platforms_ptr, num_platforms_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPlatformIDs(uint, IntPtr*, uint*)"/>
        public static unsafe int GetPlatformIDs(uint num_entries, IntPtr[] platforms, uint[] num_platforms)
        {
            int returnValue;
            fixed (uint* num_platforms_ptr = num_platforms)
            {
                fixed (IntPtr* platforms_ptr = platforms)
                {
                    returnValue = GetPlatformIDs(num_entries, platforms_ptr, num_platforms_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPlatformIDs(uint, IntPtr*, uint*)"/>
        public static unsafe int GetPlatformIDs(uint num_entries, ref IntPtr platforms, ref uint num_platforms)
        {
            int returnValue;
            fixed (IntPtr* platforms_ptr = &platforms)
            fixed (uint* num_platforms_ptr = &num_platforms)
            {
                returnValue = GetPlatformIDs(num_entries, platforms_ptr, num_platforms_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPlatformInfo(IntPtr, PlatformInfo, nuint, void*, nuint*)"/>
        public static unsafe int GetPlatformInfo(IntPtr platform, PlatformInfo param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetPlatformInfo(platform, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPlatformInfo(IntPtr, PlatformInfo, nuint, void*, nuint*)"/>
        public static unsafe int GetPlatformInfo(IntPtr platform, PlatformInfo param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetPlatformInfo(platform, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPlatformInfo(IntPtr, PlatformInfo, nuint, void*, nuint*)"/>
        public static unsafe int GetPlatformInfo(IntPtr platform, PlatformInfo param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetPlatformInfo(platform, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPlatformInfo(IntPtr, PlatformInfo, nuint, void*, nuint*)"/>
        public static unsafe int GetPlatformInfo<T1>(IntPtr platform, PlatformInfo param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetPlatformInfo(platform, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPlatformInfo(IntPtr, PlatformInfo, nuint, void*, nuint*)"/>
        public static unsafe int GetPlatformInfo<T1>(IntPtr platform, PlatformInfo param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetPlatformInfo(platform, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetPlatformInfo(IntPtr, PlatformInfo, nuint, void*, nuint*)"/>
        public static unsafe int GetPlatformInfo<T1>(IntPtr platform, PlatformInfo param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetPlatformInfo(platform, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProgramBuildInfo(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetProgramBuildInfo(IntPtr program, IntPtr device, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetProgramBuildInfo(program, device, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProgramBuildInfo(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetProgramBuildInfo(IntPtr program, IntPtr device, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetProgramBuildInfo(program, device, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProgramBuildInfo(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetProgramBuildInfo(IntPtr program, IntPtr device, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetProgramBuildInfo(program, device, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProgramBuildInfo(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetProgramBuildInfo<T1>(IntPtr program, IntPtr device, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetProgramBuildInfo(program, device, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProgramBuildInfo(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetProgramBuildInfo<T1>(IntPtr program, IntPtr device, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetProgramBuildInfo(program, device, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProgramBuildInfo(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetProgramBuildInfo<T1>(IntPtr program, IntPtr device, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetProgramBuildInfo(program, device, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProgramInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetProgramInfo(IntPtr program, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetProgramInfo(program, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProgramInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetProgramInfo(IntPtr program, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetProgramInfo(program, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProgramInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetProgramInfo(IntPtr program, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetProgramInfo(program, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProgramInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetProgramInfo<T1>(IntPtr program, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetProgramInfo(program, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProgramInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetProgramInfo<T1>(IntPtr program, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetProgramInfo(program, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProgramInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetProgramInfo<T1>(IntPtr program, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetProgramInfo(program, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetSamplerInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetSamplerInfo(IntPtr sampler, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetSamplerInfo(sampler, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetSamplerInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetSamplerInfo(IntPtr sampler, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetSamplerInfo(sampler, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetSamplerInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetSamplerInfo(IntPtr sampler, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                void* param_value_vptr = (void*)param_value;
                returnValue = GetSamplerInfo(sampler, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetSamplerInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetSamplerInfo<T1>(IntPtr sampler, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetSamplerInfo(sampler, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetSamplerInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetSamplerInfo<T1>(IntPtr sampler, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
            {
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = GetSamplerInfo(sampler, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetSamplerInfo(IntPtr, uint, nuint, void*, nuint*)"/>
        public static unsafe int GetSamplerInfo<T1>(IntPtr sampler, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
            {
                returnValue = GetSamplerInfo(sampler, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetSupportedImageFormats(IntPtr, MemFlags, uint, uint, cl_image_format*, uint*)"/>
        public static unsafe int GetSupportedImageFormats(IntPtr context, MemFlags flags, uint image_type, uint num_entries, Span<cl_image_format> image_formats, Span<uint> num_image_formats)
        {
            int returnValue;
            fixed (uint* num_image_formats_ptr = num_image_formats)
            {
                fixed (cl_image_format* image_formats_ptr = image_formats)
                {
                    returnValue = GetSupportedImageFormats(context, flags, image_type, num_entries, image_formats_ptr, num_image_formats_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetSupportedImageFormats(IntPtr, MemFlags, uint, uint, cl_image_format*, uint*)"/>
        public static unsafe int GetSupportedImageFormats(IntPtr context, MemFlags flags, uint image_type, uint num_entries, cl_image_format[] image_formats, uint[] num_image_formats)
        {
            int returnValue;
            fixed (uint* num_image_formats_ptr = num_image_formats)
            {
                fixed (cl_image_format* image_formats_ptr = image_formats)
                {
                    returnValue = GetSupportedImageFormats(context, flags, image_type, num_entries, image_formats_ptr, num_image_formats_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetSupportedImageFormats(IntPtr, MemFlags, uint, uint, cl_image_format*, uint*)"/>
        public static unsafe int GetSupportedImageFormats(IntPtr context, MemFlags flags, uint image_type, uint num_entries, ref cl_image_format image_formats, ref uint num_image_formats)
        {
            int returnValue;
            fixed (cl_image_format* image_formats_ptr = &image_formats)
            fixed (uint* num_image_formats_ptr = &num_image_formats)
            {
                returnValue = GetSupportedImageFormats(context, flags, image_type, num_entries, image_formats_ptr, num_image_formats_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="LinkProgram(IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int*)"/>
        public static unsafe IntPtr LinkProgram(IntPtr context, uint num_devices, Span<IntPtr> device_list, string options, uint num_input_programs, Span<IntPtr> input_programs, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, IntPtr user_data, Span<int> errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (IntPtr* input_programs_ptr = input_programs)
                {
                    fixed (IntPtr* device_list_ptr = device_list)
                    {
                        byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                        void* user_data_vptr = (void*)user_data;
                        returnValue = LinkProgram(context, num_devices, device_list_ptr, options_ptr, num_input_programs, input_programs_ptr, pfn_notify, user_data_vptr, errcode_ret_ptr);
                        Marshal.FreeCoTaskMem((IntPtr)options_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="LinkProgram(IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int*)"/>
        public static unsafe IntPtr LinkProgram(IntPtr context, uint num_devices, IntPtr[] device_list, string options, uint num_input_programs, IntPtr[] input_programs, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, IntPtr user_data, int[] errcode_ret)
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (IntPtr* input_programs_ptr = input_programs)
                {
                    fixed (IntPtr* device_list_ptr = device_list)
                    {
                        byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                        void* user_data_vptr = (void*)user_data;
                        returnValue = LinkProgram(context, num_devices, device_list_ptr, options_ptr, num_input_programs, input_programs_ptr, pfn_notify, user_data_vptr, errcode_ret_ptr);
                        Marshal.FreeCoTaskMem((IntPtr)options_ptr);
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="LinkProgram(IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int*)"/>
        public static unsafe IntPtr LinkProgram(IntPtr context, uint num_devices, ref IntPtr device_list, string options, uint num_input_programs, ref IntPtr input_programs, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, IntPtr user_data, ref int errcode_ret)
        {
            IntPtr returnValue;
            fixed (IntPtr* device_list_ptr = &device_list)
            fixed (IntPtr* input_programs_ptr = &input_programs)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                void* user_data_vptr = (void*)user_data;
                returnValue = LinkProgram(context, num_devices, device_list_ptr, options_ptr, num_input_programs, input_programs_ptr, pfn_notify, user_data_vptr, errcode_ret_ptr);
                Marshal.FreeCoTaskMem((IntPtr)options_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="LinkProgram(IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int*)"/>
        public static unsafe IntPtr LinkProgram<T1>(IntPtr context, uint num_devices, Span<IntPtr> device_list, string options, uint num_input_programs, Span<IntPtr> input_programs, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, Span<T1> user_data, Span<int> errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* user_data_ptr = user_data)
                {
                    fixed (IntPtr* input_programs_ptr = input_programs)
                    {
                        fixed (IntPtr* device_list_ptr = device_list)
                        {
                            byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                            returnValue = LinkProgram(context, num_devices, device_list_ptr, options_ptr, num_input_programs, input_programs_ptr, pfn_notify, user_data_ptr, errcode_ret_ptr);
                            Marshal.FreeCoTaskMem((IntPtr)options_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="LinkProgram(IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int*)"/>
        public static unsafe IntPtr LinkProgram<T1>(IntPtr context, uint num_devices, IntPtr[] device_list, string options, uint num_input_programs, IntPtr[] input_programs, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, T1[] user_data, int[] errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (int* errcode_ret_ptr = errcode_ret)
            {
                fixed (void* user_data_ptr = user_data)
                {
                    fixed (IntPtr* input_programs_ptr = input_programs)
                    {
                        fixed (IntPtr* device_list_ptr = device_list)
                        {
                            byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                            returnValue = LinkProgram(context, num_devices, device_list_ptr, options_ptr, num_input_programs, input_programs_ptr, pfn_notify, user_data_ptr, errcode_ret_ptr);
                            Marshal.FreeCoTaskMem((IntPtr)options_ptr);
                        }
                    }
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="LinkProgram(IntPtr, uint, IntPtr*, byte*, uint, IntPtr*, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*, int*)"/>
        public static unsafe IntPtr LinkProgram<T1>(IntPtr context, uint num_devices, ref IntPtr device_list, string options, uint num_input_programs, ref IntPtr input_programs, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, ref T1 user_data, ref int errcode_ret)
            where T1 : unmanaged
        {
            IntPtr returnValue;
            fixed (IntPtr* device_list_ptr = &device_list)
            fixed (IntPtr* input_programs_ptr = &input_programs)
            fixed (void* user_data_ptr = &user_data)
            fixed (int* errcode_ret_ptr = &errcode_ret)
            {
                byte* options_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(options);
                returnValue = LinkProgram(context, num_devices, device_list_ptr, options_ptr, num_input_programs, input_programs_ptr, pfn_notify, user_data_ptr, errcode_ret_ptr);
                Marshal.FreeCoTaskMem((IntPtr)options_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetCommandQueueProperty(IntPtr, CommandQueueProperties, Bool, CommandQueueProperties*)"/>
        public static unsafe int SetCommandQueueProperty(IntPtr command_queue, CommandQueueProperties properties, Bool enable, Span<CommandQueueProperties> old_properties)
        {
            int returnValue;
            fixed (CommandQueueProperties* old_properties_ptr = old_properties)
            {
                returnValue = SetCommandQueueProperty(command_queue, properties, enable, old_properties_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetCommandQueueProperty(IntPtr, CommandQueueProperties, Bool, CommandQueueProperties*)"/>
        public static unsafe int SetCommandQueueProperty(IntPtr command_queue, CommandQueueProperties properties, Bool enable, CommandQueueProperties[] old_properties)
        {
            int returnValue;
            fixed (CommandQueueProperties* old_properties_ptr = old_properties)
            {
                returnValue = SetCommandQueueProperty(command_queue, properties, enable, old_properties_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetCommandQueueProperty(IntPtr, CommandQueueProperties, Bool, CommandQueueProperties*)"/>
        public static unsafe int SetCommandQueueProperty(IntPtr command_queue, CommandQueueProperties properties, Bool enable, ref CommandQueueProperties old_properties)
        {
            int returnValue;
            fixed (CommandQueueProperties* old_properties_ptr = &old_properties)
            {
                returnValue = SetCommandQueueProperty(command_queue, properties, enable, old_properties_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetContextDestructorCallback(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int SetContextDestructorCallback(IntPtr context, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, IntPtr user_data)
        {
            int returnValue;
            void* user_data_vptr = (void*)user_data;
            returnValue = SetContextDestructorCallback(context, pfn_notify, user_data_vptr);
            return returnValue;
        }
        /// <inheritdoc cref="SetContextDestructorCallback(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int SetContextDestructorCallback<T1>(IntPtr context, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, Span<T1> user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = user_data)
            {
                returnValue = SetContextDestructorCallback(context, pfn_notify, user_data_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetContextDestructorCallback(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int SetContextDestructorCallback<T1>(IntPtr context, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, T1[] user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = user_data)
            {
                returnValue = SetContextDestructorCallback(context, pfn_notify, user_data_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetContextDestructorCallback(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int SetContextDestructorCallback<T1>(IntPtr context, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, ref T1 user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = &user_data)
            {
                returnValue = SetContextDestructorCallback(context, pfn_notify, user_data_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetEventCallback(IntPtr, int, delegate* unmanaged[Cdecl]<IntPtr, int, void*, void>, void*)"/>
        public static unsafe int SetEventCallback(IntPtr @event, int command_exec_callback_type, delegate* unmanaged[Cdecl]<IntPtr, int, void*, void> pfn_notify, IntPtr user_data)
        {
            int returnValue;
            void* user_data_vptr = (void*)user_data;
            returnValue = SetEventCallback(@event, command_exec_callback_type, pfn_notify, user_data_vptr);
            return returnValue;
        }
        /// <inheritdoc cref="SetEventCallback(IntPtr, int, delegate* unmanaged[Cdecl]<IntPtr, int, void*, void>, void*)"/>
        public static unsafe int SetEventCallback<T1>(IntPtr @event, int command_exec_callback_type, delegate* unmanaged[Cdecl]<IntPtr, int, void*, void> pfn_notify, Span<T1> user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = user_data)
            {
                returnValue = SetEventCallback(@event, command_exec_callback_type, pfn_notify, user_data_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetEventCallback(IntPtr, int, delegate* unmanaged[Cdecl]<IntPtr, int, void*, void>, void*)"/>
        public static unsafe int SetEventCallback<T1>(IntPtr @event, int command_exec_callback_type, delegate* unmanaged[Cdecl]<IntPtr, int, void*, void> pfn_notify, T1[] user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = user_data)
            {
                returnValue = SetEventCallback(@event, command_exec_callback_type, pfn_notify, user_data_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetEventCallback(IntPtr, int, delegate* unmanaged[Cdecl]<IntPtr, int, void*, void>, void*)"/>
        public static unsafe int SetEventCallback<T1>(IntPtr @event, int command_exec_callback_type, delegate* unmanaged[Cdecl]<IntPtr, int, void*, void> pfn_notify, ref T1 user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = &user_data)
            {
                returnValue = SetEventCallback(@event, command_exec_callback_type, pfn_notify, user_data_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetKernelArg(IntPtr, uint, nuint, void*)"/>
        public static unsafe int SetKernelArg(IntPtr kernel, uint arg_index, nuint arg_size, IntPtr arg_value)
        {
            int returnValue;
            void* arg_value_vptr = (void*)arg_value;
            returnValue = SetKernelArg(kernel, arg_index, arg_size, arg_value_vptr);
            return returnValue;
        }
        /// <inheritdoc cref="SetKernelArg(IntPtr, uint, nuint, void*)"/>
        public static unsafe int SetKernelArg<T1>(IntPtr kernel, uint arg_index, nuint arg_size, ReadOnlySpan<T1> arg_value)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* arg_value_ptr = arg_value)
            {
                returnValue = SetKernelArg(kernel, arg_index, arg_size, arg_value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetKernelArg(IntPtr, uint, nuint, void*)"/>
        public static unsafe int SetKernelArg<T1>(IntPtr kernel, uint arg_index, nuint arg_size, T1[] arg_value)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* arg_value_ptr = arg_value)
            {
                returnValue = SetKernelArg(kernel, arg_index, arg_size, arg_value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetKernelArg(IntPtr, uint, nuint, void*)"/>
        public static unsafe int SetKernelArg<T1>(IntPtr kernel, uint arg_index, nuint arg_size, ref readonly T1 arg_value)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* arg_value_ptr = &arg_value)
            {
                returnValue = SetKernelArg(kernel, arg_index, arg_size, arg_value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetKernelArgSVMPointer(IntPtr, uint, void*)"/>
        public static unsafe int SetKernelArgSVMPointer(IntPtr kernel, uint arg_index, IntPtr arg_value)
        {
            int returnValue;
            void* arg_value_vptr = (void*)arg_value;
            returnValue = SetKernelArgSVMPointer(kernel, arg_index, arg_value_vptr);
            return returnValue;
        }
        /// <inheritdoc cref="SetKernelArgSVMPointer(IntPtr, uint, void*)"/>
        public static unsafe int SetKernelArgSVMPointer<T1>(IntPtr kernel, uint arg_index, ReadOnlySpan<T1> arg_value)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* arg_value_ptr = arg_value)
            {
                returnValue = SetKernelArgSVMPointer(kernel, arg_index, arg_value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetKernelArgSVMPointer(IntPtr, uint, void*)"/>
        public static unsafe int SetKernelArgSVMPointer<T1>(IntPtr kernel, uint arg_index, T1[] arg_value)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* arg_value_ptr = arg_value)
            {
                returnValue = SetKernelArgSVMPointer(kernel, arg_index, arg_value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetKernelArgSVMPointer(IntPtr, uint, void*)"/>
        public static unsafe int SetKernelArgSVMPointer<T1>(IntPtr kernel, uint arg_index, ref readonly T1 arg_value)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* arg_value_ptr = &arg_value)
            {
                returnValue = SetKernelArgSVMPointer(kernel, arg_index, arg_value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetKernelExecInfo(IntPtr, uint, nuint, void*)"/>
        public static unsafe int SetKernelExecInfo(IntPtr kernel, uint param_name, nuint param_value_size, IntPtr param_value)
        {
            int returnValue;
            void* param_value_vptr = (void*)param_value;
            returnValue = SetKernelExecInfo(kernel, param_name, param_value_size, param_value_vptr);
            return returnValue;
        }
        /// <inheritdoc cref="SetKernelExecInfo(IntPtr, uint, nuint, void*)"/>
        public static unsafe int SetKernelExecInfo<T1>(IntPtr kernel, uint param_name, nuint param_value_size, ReadOnlySpan<T1> param_value)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = param_value)
            {
                returnValue = SetKernelExecInfo(kernel, param_name, param_value_size, param_value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetKernelExecInfo(IntPtr, uint, nuint, void*)"/>
        public static unsafe int SetKernelExecInfo<T1>(IntPtr kernel, uint param_name, nuint param_value_size, T1[] param_value)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = param_value)
            {
                returnValue = SetKernelExecInfo(kernel, param_name, param_value_size, param_value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetKernelExecInfo(IntPtr, uint, nuint, void*)"/>
        public static unsafe int SetKernelExecInfo<T1>(IntPtr kernel, uint param_name, nuint param_value_size, ref readonly T1 param_value)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* param_value_ptr = &param_value)
            {
                returnValue = SetKernelExecInfo(kernel, param_name, param_value_size, param_value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetMemObjectDestructorCallback(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int SetMemObjectDestructorCallback(IntPtr memobj, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, IntPtr user_data)
        {
            int returnValue;
            void* user_data_vptr = (void*)user_data;
            returnValue = SetMemObjectDestructorCallback(memobj, pfn_notify, user_data_vptr);
            return returnValue;
        }
        /// <inheritdoc cref="SetMemObjectDestructorCallback(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int SetMemObjectDestructorCallback<T1>(IntPtr memobj, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, Span<T1> user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = user_data)
            {
                returnValue = SetMemObjectDestructorCallback(memobj, pfn_notify, user_data_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetMemObjectDestructorCallback(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int SetMemObjectDestructorCallback<T1>(IntPtr memobj, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, T1[] user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = user_data)
            {
                returnValue = SetMemObjectDestructorCallback(memobj, pfn_notify, user_data_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetMemObjectDestructorCallback(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int SetMemObjectDestructorCallback<T1>(IntPtr memobj, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, ref T1 user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = &user_data)
            {
                returnValue = SetMemObjectDestructorCallback(memobj, pfn_notify, user_data_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetProgramReleaseCallback(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int SetProgramReleaseCallback(IntPtr program, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, IntPtr user_data)
        {
            int returnValue;
            void* user_data_vptr = (void*)user_data;
            returnValue = SetProgramReleaseCallback(program, pfn_notify, user_data_vptr);
            return returnValue;
        }
        /// <inheritdoc cref="SetProgramReleaseCallback(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int SetProgramReleaseCallback<T1>(IntPtr program, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, Span<T1> user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = user_data)
            {
                returnValue = SetProgramReleaseCallback(program, pfn_notify, user_data_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetProgramReleaseCallback(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int SetProgramReleaseCallback<T1>(IntPtr program, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, T1[] user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = user_data)
            {
                returnValue = SetProgramReleaseCallback(program, pfn_notify, user_data_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetProgramReleaseCallback(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
        public static unsafe int SetProgramReleaseCallback<T1>(IntPtr program, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, ref T1 user_data)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* user_data_ptr = &user_data)
            {
                returnValue = SetProgramReleaseCallback(program, pfn_notify, user_data_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetProgramSpecializationConstant(IntPtr, uint, nuint, void*)"/>
        public static unsafe int SetProgramSpecializationConstant(IntPtr program, uint spec_id, nuint spec_size, IntPtr spec_value)
        {
            int returnValue;
            void* spec_value_vptr = (void*)spec_value;
            returnValue = SetProgramSpecializationConstant(program, spec_id, spec_size, spec_value_vptr);
            return returnValue;
        }
        /// <inheritdoc cref="SetProgramSpecializationConstant(IntPtr, uint, nuint, void*)"/>
        public static unsafe int SetProgramSpecializationConstant<T1>(IntPtr program, uint spec_id, nuint spec_size, ReadOnlySpan<T1> spec_value)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* spec_value_ptr = spec_value)
            {
                returnValue = SetProgramSpecializationConstant(program, spec_id, spec_size, spec_value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetProgramSpecializationConstant(IntPtr, uint, nuint, void*)"/>
        public static unsafe int SetProgramSpecializationConstant<T1>(IntPtr program, uint spec_id, nuint spec_size, T1[] spec_value)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* spec_value_ptr = spec_value)
            {
                returnValue = SetProgramSpecializationConstant(program, spec_id, spec_size, spec_value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetProgramSpecializationConstant(IntPtr, uint, nuint, void*)"/>
        public static unsafe int SetProgramSpecializationConstant<T1>(IntPtr program, uint spec_id, nuint spec_size, ref readonly T1 spec_value)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* spec_value_ptr = &spec_value)
            {
                returnValue = SetProgramSpecializationConstant(program, spec_id, spec_size, spec_value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SVMFree(IntPtr, void*)"/>
        public static unsafe void SVMFree(IntPtr context, IntPtr svm_pointer)
        {
            void* svm_pointer_vptr = (void*)svm_pointer;
            SVMFree(context, svm_pointer_vptr);
        }
        /// <inheritdoc cref="SVMFree(IntPtr, void*)"/>
        public static unsafe void SVMFree<T1>(IntPtr context, Span<T1> svm_pointer)
            where T1 : unmanaged
        {
            fixed (void* svm_pointer_ptr = svm_pointer)
            {
                SVMFree(context, svm_pointer_ptr);
            }
        }
        /// <inheritdoc cref="SVMFree(IntPtr, void*)"/>
        public static unsafe void SVMFree<T1>(IntPtr context, T1[] svm_pointer)
            where T1 : unmanaged
        {
            fixed (void* svm_pointer_ptr = svm_pointer)
            {
                SVMFree(context, svm_pointer_ptr);
            }
        }
        /// <inheritdoc cref="SVMFree(IntPtr, void*)"/>
        public static unsafe void SVMFree<T1>(IntPtr context, ref T1 svm_pointer)
            where T1 : unmanaged
        {
            fixed (void* svm_pointer_ptr = &svm_pointer)
            {
                SVMFree(context, svm_pointer_ptr);
            }
        }
        /// <inheritdoc cref="WaitForEvents(uint, IntPtr*)"/>
        public static unsafe int WaitForEvents(uint num_events, Span<IntPtr> event_list)
        {
            int returnValue;
            fixed (IntPtr* event_list_ptr = event_list)
            {
                returnValue = WaitForEvents(num_events, event_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="WaitForEvents(uint, IntPtr*)"/>
        public static unsafe int WaitForEvents(uint num_events, IntPtr[] event_list)
        {
            int returnValue;
            fixed (IntPtr* event_list_ptr = event_list)
            {
                returnValue = WaitForEvents(num_events, event_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="WaitForEvents(uint, IntPtr*)"/>
        public static unsafe int WaitForEvents(uint num_events, ref IntPtr event_list)
        {
            int returnValue;
            fixed (IntPtr* event_list_ptr = &event_list)
            {
                returnValue = WaitForEvents(num_events, event_list_ptr);
            }
            return returnValue;
        }
        public static unsafe partial class APPLE
        {
            /// <inheritdoc cref="LogMessagesToStderrAPPLE(byte*, void*, nuint, void*)"/>
            public static unsafe void LogMessagesToStderrAPPLE(string errstr, IntPtr private_info, nuint cb, IntPtr user_data)
            {
                byte* errstr_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(errstr);
                void* private_info_vptr = (void*)private_info;
                void* user_data_vptr = (void*)user_data;
                LogMessagesToStderrAPPLE(errstr_ptr, private_info_vptr, cb, user_data_vptr);
                Marshal.FreeCoTaskMem((IntPtr)errstr_ptr);
            }
            /// <inheritdoc cref="LogMessagesToStderrAPPLE(byte*, void*, nuint, void*)"/>
            public static unsafe void LogMessagesToStderrAPPLE<T1, T2>(string errstr, ReadOnlySpan<T1> private_info, nuint cb, Span<T2> user_data)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* user_data_ptr = user_data)
                {
                    fixed (void* private_info_ptr = private_info)
                    {
                        byte* errstr_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(errstr);
                        LogMessagesToStderrAPPLE(errstr_ptr, private_info_ptr, cb, user_data_ptr);
                        Marshal.FreeCoTaskMem((IntPtr)errstr_ptr);
                    }
                }
            }
            /// <inheritdoc cref="LogMessagesToStderrAPPLE(byte*, void*, nuint, void*)"/>
            public static unsafe void LogMessagesToStderrAPPLE<T1, T2>(string errstr, T1[] private_info, nuint cb, T2[] user_data)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* user_data_ptr = user_data)
                {
                    fixed (void* private_info_ptr = private_info)
                    {
                        byte* errstr_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(errstr);
                        LogMessagesToStderrAPPLE(errstr_ptr, private_info_ptr, cb, user_data_ptr);
                        Marshal.FreeCoTaskMem((IntPtr)errstr_ptr);
                    }
                }
            }
            /// <inheritdoc cref="LogMessagesToStderrAPPLE(byte*, void*, nuint, void*)"/>
            public static unsafe void LogMessagesToStderrAPPLE<T1, T2>(string errstr, ref readonly T1 private_info, nuint cb, ref T2 user_data)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* private_info_ptr = &private_info)
                fixed (void* user_data_ptr = &user_data)
                {
                    byte* errstr_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(errstr);
                    LogMessagesToStderrAPPLE(errstr_ptr, private_info_ptr, cb, user_data_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)errstr_ptr);
                }
            }
            /// <inheritdoc cref="LogMessagesToStdoutAPPLE(byte*, void*, nuint, void*)"/>
            public static unsafe void LogMessagesToStdoutAPPLE(string errstr, IntPtr private_info, nuint cb, IntPtr user_data)
            {
                byte* errstr_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(errstr);
                void* private_info_vptr = (void*)private_info;
                void* user_data_vptr = (void*)user_data;
                LogMessagesToStdoutAPPLE(errstr_ptr, private_info_vptr, cb, user_data_vptr);
                Marshal.FreeCoTaskMem((IntPtr)errstr_ptr);
            }
            /// <inheritdoc cref="LogMessagesToStdoutAPPLE(byte*, void*, nuint, void*)"/>
            public static unsafe void LogMessagesToStdoutAPPLE<T1, T2>(string errstr, ReadOnlySpan<T1> private_info, nuint cb, Span<T2> user_data)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* user_data_ptr = user_data)
                {
                    fixed (void* private_info_ptr = private_info)
                    {
                        byte* errstr_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(errstr);
                        LogMessagesToStdoutAPPLE(errstr_ptr, private_info_ptr, cb, user_data_ptr);
                        Marshal.FreeCoTaskMem((IntPtr)errstr_ptr);
                    }
                }
            }
            /// <inheritdoc cref="LogMessagesToStdoutAPPLE(byte*, void*, nuint, void*)"/>
            public static unsafe void LogMessagesToStdoutAPPLE<T1, T2>(string errstr, T1[] private_info, nuint cb, T2[] user_data)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* user_data_ptr = user_data)
                {
                    fixed (void* private_info_ptr = private_info)
                    {
                        byte* errstr_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(errstr);
                        LogMessagesToStdoutAPPLE(errstr_ptr, private_info_ptr, cb, user_data_ptr);
                        Marshal.FreeCoTaskMem((IntPtr)errstr_ptr);
                    }
                }
            }
            /// <inheritdoc cref="LogMessagesToStdoutAPPLE(byte*, void*, nuint, void*)"/>
            public static unsafe void LogMessagesToStdoutAPPLE<T1, T2>(string errstr, ref readonly T1 private_info, nuint cb, ref T2 user_data)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* private_info_ptr = &private_info)
                fixed (void* user_data_ptr = &user_data)
                {
                    byte* errstr_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(errstr);
                    LogMessagesToStdoutAPPLE(errstr_ptr, private_info_ptr, cb, user_data_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)errstr_ptr);
                }
            }
            /// <inheritdoc cref="LogMessagesToSystemLogAPPLE(byte*, void*, nuint, void*)"/>
            public static unsafe void LogMessagesToSystemLogAPPLE(string errstr, IntPtr private_info, nuint cb, IntPtr user_data)
            {
                byte* errstr_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(errstr);
                void* private_info_vptr = (void*)private_info;
                void* user_data_vptr = (void*)user_data;
                LogMessagesToSystemLogAPPLE(errstr_ptr, private_info_vptr, cb, user_data_vptr);
                Marshal.FreeCoTaskMem((IntPtr)errstr_ptr);
            }
            /// <inheritdoc cref="LogMessagesToSystemLogAPPLE(byte*, void*, nuint, void*)"/>
            public static unsafe void LogMessagesToSystemLogAPPLE<T1, T2>(string errstr, ReadOnlySpan<T1> private_info, nuint cb, Span<T2> user_data)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* user_data_ptr = user_data)
                {
                    fixed (void* private_info_ptr = private_info)
                    {
                        byte* errstr_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(errstr);
                        LogMessagesToSystemLogAPPLE(errstr_ptr, private_info_ptr, cb, user_data_ptr);
                        Marshal.FreeCoTaskMem((IntPtr)errstr_ptr);
                    }
                }
            }
            /// <inheritdoc cref="LogMessagesToSystemLogAPPLE(byte*, void*, nuint, void*)"/>
            public static unsafe void LogMessagesToSystemLogAPPLE<T1, T2>(string errstr, T1[] private_info, nuint cb, T2[] user_data)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* user_data_ptr = user_data)
                {
                    fixed (void* private_info_ptr = private_info)
                    {
                        byte* errstr_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(errstr);
                        LogMessagesToSystemLogAPPLE(errstr_ptr, private_info_ptr, cb, user_data_ptr);
                        Marshal.FreeCoTaskMem((IntPtr)errstr_ptr);
                    }
                }
            }
            /// <inheritdoc cref="LogMessagesToSystemLogAPPLE(byte*, void*, nuint, void*)"/>
            public static unsafe void LogMessagesToSystemLogAPPLE<T1, T2>(string errstr, ref readonly T1 private_info, nuint cb, ref T2 user_data)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* private_info_ptr = &private_info)
                fixed (void* user_data_ptr = &user_data)
                {
                    byte* errstr_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(errstr);
                    LogMessagesToSystemLogAPPLE(errstr_ptr, private_info_ptr, cb, user_data_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)errstr_ptr);
                }
            }
            /// <inheritdoc cref="SetMemObjectDestructorAPPLE(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
            public static unsafe int SetMemObjectDestructorAPPLE(IntPtr memobj, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, IntPtr user_data)
            {
                int returnValue;
                void* user_data_vptr = (void*)user_data;
                returnValue = SetMemObjectDestructorAPPLE(memobj, pfn_notify, user_data_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="SetMemObjectDestructorAPPLE(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
            public static unsafe int SetMemObjectDestructorAPPLE<T1>(IntPtr memobj, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, Span<T1> user_data)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* user_data_ptr = user_data)
                {
                    returnValue = SetMemObjectDestructorAPPLE(memobj, pfn_notify, user_data_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetMemObjectDestructorAPPLE(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
            public static unsafe int SetMemObjectDestructorAPPLE<T1>(IntPtr memobj, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, T1[] user_data)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* user_data_ptr = user_data)
                {
                    returnValue = SetMemObjectDestructorAPPLE(memobj, pfn_notify, user_data_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetMemObjectDestructorAPPLE(IntPtr, delegate* unmanaged[Cdecl]<IntPtr, void*, void>, void*)"/>
            public static unsafe int SetMemObjectDestructorAPPLE<T1>(IntPtr memobj, delegate* unmanaged[Cdecl]<IntPtr, void*, void> pfn_notify, ref T1 user_data)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* user_data_ptr = &user_data)
                {
                    returnValue = SetMemObjectDestructorAPPLE(memobj, pfn_notify, user_data_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class arm
        {
            /// <inheritdoc cref="EnqueueSVMFreeARM(IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMFreeARM(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, IntPtr user_data, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* user_data_vptr = (void*)user_data;
                        returnValue = EnqueueSVMFreeARM(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMFreeARM(IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMFreeARM(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, IntPtr user_data, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* user_data_vptr = (void*)user_data;
                        returnValue = EnqueueSVMFreeARM(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMFreeARM(IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMFreeARM(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, IntPtr user_data, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    void* user_data_vptr = (void*)user_data;
                    returnValue = EnqueueSVMFreeARM(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMFreeARM(IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMFreeARM<T1>(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, Span<T1> user_data, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* user_data_ptr = user_data)
                        {
                            returnValue = EnqueueSVMFreeARM(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMFreeARM(IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMFreeARM<T1>(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, T1[] user_data, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* user_data_ptr = user_data)
                        {
                            returnValue = EnqueueSVMFreeARM(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMFreeARM(IntPtr, uint, void**, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void>, void*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMFreeARM<T1>(IntPtr command_queue, uint num_svm_pointers, void** svm_pointers, delegate* unmanaged[Cdecl]<IntPtr, uint, void**, void*, void> pfn_free_func, ref T1 user_data, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* user_data_ptr = &user_data)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueSVMFreeARM(command_queue, num_svm_pointers, svm_pointers, pfn_free_func, user_data_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMapARM(IntPtr, Bool, MapFlags, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMapARM(IntPtr command_queue, Bool blocking_map, MapFlags flags, IntPtr svm_ptr, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* svm_ptr_vptr = (void*)svm_ptr;
                        returnValue = EnqueueSVMMapARM(command_queue, blocking_map, flags, svm_ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMapARM(IntPtr, Bool, MapFlags, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMapARM(IntPtr command_queue, Bool blocking_map, MapFlags flags, IntPtr svm_ptr, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* svm_ptr_vptr = (void*)svm_ptr;
                        returnValue = EnqueueSVMMapARM(command_queue, blocking_map, flags, svm_ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMapARM(IntPtr, Bool, MapFlags, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMapARM(IntPtr command_queue, Bool blocking_map, MapFlags flags, IntPtr svm_ptr, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    void* svm_ptr_vptr = (void*)svm_ptr;
                    returnValue = EnqueueSVMMapARM(command_queue, blocking_map, flags, svm_ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMapARM(IntPtr, Bool, MapFlags, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMapARM<T1>(IntPtr command_queue, Bool blocking_map, MapFlags flags, Span<T1> svm_ptr, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* svm_ptr_ptr = svm_ptr)
                        {
                            returnValue = EnqueueSVMMapARM(command_queue, blocking_map, flags, svm_ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMapARM(IntPtr, Bool, MapFlags, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMapARM<T1>(IntPtr command_queue, Bool blocking_map, MapFlags flags, T1[] svm_ptr, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* svm_ptr_ptr = svm_ptr)
                        {
                            returnValue = EnqueueSVMMapARM(command_queue, blocking_map, flags, svm_ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMapARM(IntPtr, Bool, MapFlags, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMapARM<T1>(IntPtr command_queue, Bool blocking_map, MapFlags flags, ref T1 svm_ptr, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* svm_ptr_ptr = &svm_ptr)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueSVMMapARM(command_queue, blocking_map, flags, svm_ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMemcpyARM(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMemcpyARM(IntPtr command_queue, Bool blocking_copy, IntPtr dst_ptr, IntPtr src_ptr, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* dst_ptr_vptr = (void*)dst_ptr;
                        void* src_ptr_vptr = (void*)src_ptr;
                        returnValue = EnqueueSVMMemcpyARM(command_queue, blocking_copy, dst_ptr_vptr, src_ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMemcpyARM(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMemcpyARM(IntPtr command_queue, Bool blocking_copy, IntPtr dst_ptr, IntPtr src_ptr, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* dst_ptr_vptr = (void*)dst_ptr;
                        void* src_ptr_vptr = (void*)src_ptr;
                        returnValue = EnqueueSVMMemcpyARM(command_queue, blocking_copy, dst_ptr_vptr, src_ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMemcpyARM(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMemcpyARM(IntPtr command_queue, Bool blocking_copy, IntPtr dst_ptr, IntPtr src_ptr, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    void* dst_ptr_vptr = (void*)dst_ptr;
                    void* src_ptr_vptr = (void*)src_ptr;
                    returnValue = EnqueueSVMMemcpyARM(command_queue, blocking_copy, dst_ptr_vptr, src_ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMemcpyARM(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMemcpyARM<T1, T2>(IntPtr command_queue, Bool blocking_copy, Span<T1> dst_ptr, ReadOnlySpan<T2> src_ptr, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* src_ptr_ptr = src_ptr)
                        {
                            fixed (void* dst_ptr_ptr = dst_ptr)
                            {
                                returnValue = EnqueueSVMMemcpyARM(command_queue, blocking_copy, dst_ptr_ptr, src_ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMemcpyARM(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMemcpyARM<T1, T2>(IntPtr command_queue, Bool blocking_copy, T1[] dst_ptr, T2[] src_ptr, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* src_ptr_ptr = src_ptr)
                        {
                            fixed (void* dst_ptr_ptr = dst_ptr)
                            {
                                returnValue = EnqueueSVMMemcpyARM(command_queue, blocking_copy, dst_ptr_ptr, src_ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMemcpyARM(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMemcpyARM<T1, T2>(IntPtr command_queue, Bool blocking_copy, ref T1 dst_ptr, ref readonly T2 src_ptr, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (void* dst_ptr_ptr = &dst_ptr)
                fixed (void* src_ptr_ptr = &src_ptr)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueSVMMemcpyARM(command_queue, blocking_copy, dst_ptr_ptr, src_ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMemFillARM(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMemFillARM(IntPtr command_queue, IntPtr svm_ptr, IntPtr pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* svm_ptr_vptr = (void*)svm_ptr;
                        void* pattern_vptr = (void*)pattern;
                        returnValue = EnqueueSVMMemFillARM(command_queue, svm_ptr_vptr, pattern_vptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMemFillARM(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMemFillARM(IntPtr command_queue, IntPtr svm_ptr, IntPtr pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* svm_ptr_vptr = (void*)svm_ptr;
                        void* pattern_vptr = (void*)pattern;
                        returnValue = EnqueueSVMMemFillARM(command_queue, svm_ptr_vptr, pattern_vptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMemFillARM(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMemFillARM(IntPtr command_queue, IntPtr svm_ptr, IntPtr pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    void* svm_ptr_vptr = (void*)svm_ptr;
                    void* pattern_vptr = (void*)pattern;
                    returnValue = EnqueueSVMMemFillARM(command_queue, svm_ptr_vptr, pattern_vptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMemFillARM(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMemFillARM<T1, T2>(IntPtr command_queue, Span<T1> svm_ptr, ReadOnlySpan<T2> pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* pattern_ptr = pattern)
                        {
                            fixed (void* svm_ptr_ptr = svm_ptr)
                            {
                                returnValue = EnqueueSVMMemFillARM(command_queue, svm_ptr_ptr, pattern_ptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMemFillARM(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMemFillARM<T1, T2>(IntPtr command_queue, T1[] svm_ptr, T2[] pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* pattern_ptr = pattern)
                        {
                            fixed (void* svm_ptr_ptr = svm_ptr)
                            {
                                returnValue = EnqueueSVMMemFillARM(command_queue, svm_ptr_ptr, pattern_ptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMMemFillARM(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMMemFillARM<T1, T2>(IntPtr command_queue, ref T1 svm_ptr, ref readonly T2 pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (void* svm_ptr_ptr = &svm_ptr)
                fixed (void* pattern_ptr = &pattern)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueSVMMemFillARM(command_queue, svm_ptr_ptr, pattern_ptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMUnmapARM(IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMUnmapARM(IntPtr command_queue, IntPtr svm_ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* svm_ptr_vptr = (void*)svm_ptr;
                        returnValue = EnqueueSVMUnmapARM(command_queue, svm_ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMUnmapARM(IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMUnmapARM(IntPtr command_queue, IntPtr svm_ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* svm_ptr_vptr = (void*)svm_ptr;
                        returnValue = EnqueueSVMUnmapARM(command_queue, svm_ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMUnmapARM(IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMUnmapARM(IntPtr command_queue, IntPtr svm_ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    void* svm_ptr_vptr = (void*)svm_ptr;
                    returnValue = EnqueueSVMUnmapARM(command_queue, svm_ptr_vptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMUnmapARM(IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMUnmapARM<T1>(IntPtr command_queue, Span<T1> svm_ptr, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* svm_ptr_ptr = svm_ptr)
                        {
                            returnValue = EnqueueSVMUnmapARM(command_queue, svm_ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMUnmapARM(IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMUnmapARM<T1>(IntPtr command_queue, T1[] svm_ptr, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* svm_ptr_ptr = svm_ptr)
                        {
                            returnValue = EnqueueSVMUnmapARM(command_queue, svm_ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSVMUnmapARM(IntPtr, void*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSVMUnmapARM<T1>(IntPtr command_queue, ref T1 svm_ptr, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* svm_ptr_ptr = &svm_ptr)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueSVMUnmapARM(command_queue, svm_ptr_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ImportMemoryARM(IntPtr, MemFlags, IntPtr*, void*, nuint, int*)"/>
            public static unsafe IntPtr ImportMemoryARM(IntPtr context, MemFlags flags, Span<IntPtr> properties, IntPtr memory, nuint size, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* properties_ptr = properties)
                    {
                        void* memory_vptr = (void*)memory;
                        returnValue = ImportMemoryARM(context, flags, properties_ptr, memory_vptr, size, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="ImportMemoryARM(IntPtr, MemFlags, IntPtr*, void*, nuint, int*)"/>
            public static unsafe IntPtr ImportMemoryARM(IntPtr context, MemFlags flags, IntPtr[] properties, IntPtr memory, nuint size, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* properties_ptr = properties)
                    {
                        void* memory_vptr = (void*)memory;
                        returnValue = ImportMemoryARM(context, flags, properties_ptr, memory_vptr, size, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="ImportMemoryARM(IntPtr, MemFlags, IntPtr*, void*, nuint, int*)"/>
            public static unsafe IntPtr ImportMemoryARM(IntPtr context, MemFlags flags, ref IntPtr properties, IntPtr memory, nuint size, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (IntPtr* properties_ptr = &properties)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    void* memory_vptr = (void*)memory;
                    returnValue = ImportMemoryARM(context, flags, properties_ptr, memory_vptr, size, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ImportMemoryARM(IntPtr, MemFlags, IntPtr*, void*, nuint, int*)"/>
            public static unsafe IntPtr ImportMemoryARM<T1>(IntPtr context, MemFlags flags, Span<IntPtr> properties, Span<T1> memory, nuint size, Span<int> errcode_ret)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (void* memory_ptr = memory)
                    {
                        fixed (IntPtr* properties_ptr = properties)
                        {
                            returnValue = ImportMemoryARM(context, flags, properties_ptr, memory_ptr, size, errcode_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="ImportMemoryARM(IntPtr, MemFlags, IntPtr*, void*, nuint, int*)"/>
            public static unsafe IntPtr ImportMemoryARM<T1>(IntPtr context, MemFlags flags, IntPtr[] properties, T1[] memory, nuint size, int[] errcode_ret)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (void* memory_ptr = memory)
                    {
                        fixed (IntPtr* properties_ptr = properties)
                        {
                            returnValue = ImportMemoryARM(context, flags, properties_ptr, memory_ptr, size, errcode_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="ImportMemoryARM(IntPtr, MemFlags, IntPtr*, void*, nuint, int*)"/>
            public static unsafe IntPtr ImportMemoryARM<T1>(IntPtr context, MemFlags flags, ref IntPtr properties, ref T1 memory, nuint size, ref int errcode_ret)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (IntPtr* properties_ptr = &properties)
                fixed (void* memory_ptr = &memory)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = ImportMemoryARM(context, flags, properties_ptr, memory_ptr, size, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetKernelArgSVMPointerARM(IntPtr, uint, void*)"/>
            public static unsafe int SetKernelArgSVMPointerARM(IntPtr kernel, uint arg_index, IntPtr arg_value)
            {
                int returnValue;
                void* arg_value_vptr = (void*)arg_value;
                returnValue = SetKernelArgSVMPointerARM(kernel, arg_index, arg_value_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="SetKernelArgSVMPointerARM(IntPtr, uint, void*)"/>
            public static unsafe int SetKernelArgSVMPointerARM<T1>(IntPtr kernel, uint arg_index, ReadOnlySpan<T1> arg_value)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* arg_value_ptr = arg_value)
                {
                    returnValue = SetKernelArgSVMPointerARM(kernel, arg_index, arg_value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetKernelArgSVMPointerARM(IntPtr, uint, void*)"/>
            public static unsafe int SetKernelArgSVMPointerARM<T1>(IntPtr kernel, uint arg_index, T1[] arg_value)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* arg_value_ptr = arg_value)
                {
                    returnValue = SetKernelArgSVMPointerARM(kernel, arg_index, arg_value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetKernelArgSVMPointerARM(IntPtr, uint, void*)"/>
            public static unsafe int SetKernelArgSVMPointerARM<T1>(IntPtr kernel, uint arg_index, ref readonly T1 arg_value)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* arg_value_ptr = &arg_value)
                {
                    returnValue = SetKernelArgSVMPointerARM(kernel, arg_index, arg_value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetKernelExecInfoARM(IntPtr, uint, nuint, void*)"/>
            public static unsafe int SetKernelExecInfoARM(IntPtr kernel, uint param_name, nuint param_value_size, IntPtr param_value)
            {
                int returnValue;
                void* param_value_vptr = (void*)param_value;
                returnValue = SetKernelExecInfoARM(kernel, param_name, param_value_size, param_value_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="SetKernelExecInfoARM(IntPtr, uint, nuint, void*)"/>
            public static unsafe int SetKernelExecInfoARM<T1>(IntPtr kernel, uint param_name, nuint param_value_size, ReadOnlySpan<T1> param_value)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = SetKernelExecInfoARM(kernel, param_name, param_value_size, param_value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetKernelExecInfoARM(IntPtr, uint, nuint, void*)"/>
            public static unsafe int SetKernelExecInfoARM<T1>(IntPtr kernel, uint param_name, nuint param_value_size, T1[] param_value)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* param_value_ptr = param_value)
                {
                    returnValue = SetKernelExecInfoARM(kernel, param_name, param_value_size, param_value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetKernelExecInfoARM(IntPtr, uint, nuint, void*)"/>
            public static unsafe int SetKernelExecInfoARM<T1>(IntPtr kernel, uint param_name, nuint param_value_size, ref readonly T1 param_value)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* param_value_ptr = &param_value)
                {
                    returnValue = SetKernelExecInfoARM(kernel, param_name, param_value_size, param_value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SVMFreeARM(IntPtr, void*)"/>
            public static unsafe void SVMFreeARM(IntPtr context, IntPtr svm_pointer)
            {
                void* svm_pointer_vptr = (void*)svm_pointer;
                SVMFreeARM(context, svm_pointer_vptr);
            }
            /// <inheritdoc cref="SVMFreeARM(IntPtr, void*)"/>
            public static unsafe void SVMFreeARM<T1>(IntPtr context, Span<T1> svm_pointer)
                where T1 : unmanaged
            {
                fixed (void* svm_pointer_ptr = svm_pointer)
                {
                    SVMFreeARM(context, svm_pointer_ptr);
                }
            }
            /// <inheritdoc cref="SVMFreeARM(IntPtr, void*)"/>
            public static unsafe void SVMFreeARM<T1>(IntPtr context, T1[] svm_pointer)
                where T1 : unmanaged
            {
                fixed (void* svm_pointer_ptr = svm_pointer)
                {
                    SVMFreeARM(context, svm_pointer_ptr);
                }
            }
            /// <inheritdoc cref="SVMFreeARM(IntPtr, void*)"/>
            public static unsafe void SVMFreeARM<T1>(IntPtr context, ref T1 svm_pointer)
                where T1 : unmanaged
            {
                fixed (void* svm_pointer_ptr = &svm_pointer)
                {
                    SVMFreeARM(context, svm_pointer_ptr);
                }
            }
        }
        public static unsafe partial class ext
        {
            /// <inheritdoc cref="CreateSubDevicesEXT(IntPtr, ulong*, uint, IntPtr*, uint*)"/>
            public static unsafe int CreateSubDevicesEXT(IntPtr in_device, Span<ulong> properties, uint num_entries, Span<IntPtr> out_devices, Span<uint> num_devices)
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* out_devices_ptr = out_devices)
                    {
                        fixed (ulong* properties_ptr = properties)
                        {
                            returnValue = CreateSubDevicesEXT(in_device, properties_ptr, num_entries, out_devices_ptr, num_devices_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateSubDevicesEXT(IntPtr, ulong*, uint, IntPtr*, uint*)"/>
            public static unsafe int CreateSubDevicesEXT(IntPtr in_device, ulong[] properties, uint num_entries, IntPtr[] out_devices, uint[] num_devices)
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* out_devices_ptr = out_devices)
                    {
                        fixed (ulong* properties_ptr = properties)
                        {
                            returnValue = CreateSubDevicesEXT(in_device, properties_ptr, num_entries, out_devices_ptr, num_devices_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateSubDevicesEXT(IntPtr, ulong*, uint, IntPtr*, uint*)"/>
            public static unsafe int CreateSubDevicesEXT(IntPtr in_device, ref ulong properties, uint num_entries, ref IntPtr out_devices, ref uint num_devices)
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (IntPtr* out_devices_ptr = &out_devices)
                fixed (uint* num_devices_ptr = &num_devices)
                {
                    returnValue = CreateSubDevicesEXT(in_device, properties_ptr, num_entries, out_devices_ptr, num_devices_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMigrateMemObjectEXT(IntPtr, uint, IntPtr*, ulong, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMigrateMemObjectEXT(IntPtr command_queue, uint num_mem_objects, Span<IntPtr> mem_objects, ulong flags, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueMigrateMemObjectEXT(command_queue, num_mem_objects, mem_objects_ptr, flags, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMigrateMemObjectEXT(IntPtr, uint, IntPtr*, ulong, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMigrateMemObjectEXT(IntPtr command_queue, uint num_mem_objects, IntPtr[] mem_objects, ulong flags, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueMigrateMemObjectEXT(command_queue, num_mem_objects, mem_objects_ptr, flags, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMigrateMemObjectEXT(IntPtr, uint, IntPtr*, ulong, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMigrateMemObjectEXT(IntPtr command_queue, uint num_mem_objects, ref IntPtr mem_objects, ulong flags, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueMigrateMemObjectEXT(command_queue, num_mem_objects, mem_objects_ptr, flags, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetImageRequirementsInfoEXT(IntPtr, ulong*, MemFlags, cl_image_format*, cl_image_desc*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetImageRequirementsInfoEXT(IntPtr context, Span<ulong> properties, MemFlags flags, Span<cl_image_format> image_format, Span<cl_image_desc> image_desc, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (cl_image_desc* image_desc_ptr = image_desc)
                    {
                        fixed (cl_image_format* image_format_ptr = image_format)
                        {
                            fixed (ulong* properties_ptr = properties)
                            {
                                void* param_value_vptr = (void*)param_value;
                                returnValue = GetImageRequirementsInfoEXT(context, properties_ptr, flags, image_format_ptr, image_desc_ptr, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetImageRequirementsInfoEXT(IntPtr, ulong*, MemFlags, cl_image_format*, cl_image_desc*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetImageRequirementsInfoEXT(IntPtr context, ulong[] properties, MemFlags flags, cl_image_format[] image_format, cl_image_desc[] image_desc, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (cl_image_desc* image_desc_ptr = image_desc)
                    {
                        fixed (cl_image_format* image_format_ptr = image_format)
                        {
                            fixed (ulong* properties_ptr = properties)
                            {
                                void* param_value_vptr = (void*)param_value;
                                returnValue = GetImageRequirementsInfoEXT(context, properties_ptr, flags, image_format_ptr, image_desc_ptr, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetImageRequirementsInfoEXT(IntPtr, ulong*, MemFlags, cl_image_format*, cl_image_desc*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetImageRequirementsInfoEXT(IntPtr context, ref ulong properties, MemFlags flags, ref cl_image_format image_format, ref cl_image_desc image_desc, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (cl_image_format* image_format_ptr = &image_format)
                fixed (cl_image_desc* image_desc_ptr = &image_desc)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetImageRequirementsInfoEXT(context, properties_ptr, flags, image_format_ptr, image_desc_ptr, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetImageRequirementsInfoEXT(IntPtr, ulong*, MemFlags, cl_image_format*, cl_image_desc*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetImageRequirementsInfoEXT<T1>(IntPtr context, Span<ulong> properties, MemFlags flags, Span<cl_image_format> image_format, Span<cl_image_desc> image_desc, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        fixed (cl_image_desc* image_desc_ptr = image_desc)
                        {
                            fixed (cl_image_format* image_format_ptr = image_format)
                            {
                                fixed (ulong* properties_ptr = properties)
                                {
                                    returnValue = GetImageRequirementsInfoEXT(context, properties_ptr, flags, image_format_ptr, image_desc_ptr, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetImageRequirementsInfoEXT(IntPtr, ulong*, MemFlags, cl_image_format*, cl_image_desc*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetImageRequirementsInfoEXT<T1>(IntPtr context, ulong[] properties, MemFlags flags, cl_image_format[] image_format, cl_image_desc[] image_desc, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        fixed (cl_image_desc* image_desc_ptr = image_desc)
                        {
                            fixed (cl_image_format* image_format_ptr = image_format)
                            {
                                fixed (ulong* properties_ptr = properties)
                                {
                                    returnValue = GetImageRequirementsInfoEXT(context, properties_ptr, flags, image_format_ptr, image_desc_ptr, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetImageRequirementsInfoEXT(IntPtr, ulong*, MemFlags, cl_image_format*, cl_image_desc*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetImageRequirementsInfoEXT<T1>(IntPtr context, ref ulong properties, MemFlags flags, ref cl_image_format image_format, ref cl_image_desc image_desc, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (cl_image_format* image_format_ptr = &image_format)
                fixed (cl_image_desc* image_desc_ptr = &image_desc)
                fixed (void* param_value_ptr = &param_value)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    returnValue = GetImageRequirementsInfoEXT(context, properties_ptr, flags, image_format_ptr, image_desc_ptr, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class img
        {
            /// <inheritdoc cref="CancelCommandsIMG(IntPtr*, nuint)"/>
            public static unsafe int CancelCommandsIMG(Span<IntPtr> event_list, nuint num_events_in_list)
            {
                int returnValue;
                fixed (IntPtr* event_list_ptr = event_list)
                {
                    returnValue = CancelCommandsIMG(event_list_ptr, num_events_in_list);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CancelCommandsIMG(IntPtr*, nuint)"/>
            public static unsafe int CancelCommandsIMG(IntPtr[] event_list, nuint num_events_in_list)
            {
                int returnValue;
                fixed (IntPtr* event_list_ptr = event_list)
                {
                    returnValue = CancelCommandsIMG(event_list_ptr, num_events_in_list);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CancelCommandsIMG(IntPtr*, nuint)"/>
            public static unsafe int CancelCommandsIMG(ref IntPtr event_list, nuint num_events_in_list)
            {
                int returnValue;
                fixed (IntPtr* event_list_ptr = &event_list)
                {
                    returnValue = CancelCommandsIMG(event_list_ptr, num_events_in_list);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireGrallocObjectsIMG(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireGrallocObjectsIMG(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireGrallocObjectsIMG(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireGrallocObjectsIMG(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireGrallocObjectsIMG(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireGrallocObjectsIMG(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireGrallocObjectsIMG(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireGrallocObjectsIMG(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueAcquireGrallocObjectsIMG(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueGenerateMipmapIMG(IntPtr, IntPtr, IntPtr, MipmapFilterModeImg, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueGenerateMipmapIMG(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, MipmapFilterModeImg mipmap_filter_mode, ReadOnlySpan<nuint> array_region, ReadOnlySpan<nuint> mip_region, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (nuint* mip_region_ptr = mip_region)
                        {
                            fixed (nuint* array_region_ptr = array_region)
                            {
                                returnValue = EnqueueGenerateMipmapIMG(command_queue, src_image, dst_image, mipmap_filter_mode, array_region_ptr, mip_region_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueGenerateMipmapIMG(IntPtr, IntPtr, IntPtr, MipmapFilterModeImg, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueGenerateMipmapIMG(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, MipmapFilterModeImg mipmap_filter_mode, nuint[] array_region, nuint[] mip_region, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (nuint* mip_region_ptr = mip_region)
                        {
                            fixed (nuint* array_region_ptr = array_region)
                            {
                                returnValue = EnqueueGenerateMipmapIMG(command_queue, src_image, dst_image, mipmap_filter_mode, array_region_ptr, mip_region_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueGenerateMipmapIMG(IntPtr, IntPtr, IntPtr, MipmapFilterModeImg, nuint*, nuint*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueGenerateMipmapIMG(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, MipmapFilterModeImg mipmap_filter_mode, ref readonly nuint array_region, ref readonly nuint mip_region, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (nuint* array_region_ptr = &array_region)
                fixed (nuint* mip_region_ptr = &mip_region)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueGenerateMipmapIMG(command_queue, src_image, dst_image, mipmap_filter_mode, array_region_ptr, mip_region_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseGrallocObjectsIMG(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseGrallocObjectsIMG(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseGrallocObjectsIMG(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseGrallocObjectsIMG(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseGrallocObjectsIMG(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseGrallocObjectsIMG(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseGrallocObjectsIMG(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseGrallocObjectsIMG(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueReleaseGrallocObjectsIMG(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class intel
        {
            /// <inheritdoc cref="CreateAcceleratorINTEL(IntPtr, AcceleratorTypeIntel, nuint, void*, int*)"/>
            public static unsafe IntPtr CreateAcceleratorINTEL(IntPtr context, AcceleratorTypeIntel accelerator_type, nuint descriptor_size, IntPtr descriptor, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    void* descriptor_vptr = (void*)descriptor;
                    returnValue = CreateAcceleratorINTEL(context, accelerator_type, descriptor_size, descriptor_vptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateAcceleratorINTEL(IntPtr, AcceleratorTypeIntel, nuint, void*, int*)"/>
            public static unsafe IntPtr CreateAcceleratorINTEL(IntPtr context, AcceleratorTypeIntel accelerator_type, nuint descriptor_size, IntPtr descriptor, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    void* descriptor_vptr = (void*)descriptor;
                    returnValue = CreateAcceleratorINTEL(context, accelerator_type, descriptor_size, descriptor_vptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateAcceleratorINTEL(IntPtr, AcceleratorTypeIntel, nuint, void*, int*)"/>
            public static unsafe IntPtr CreateAcceleratorINTEL(IntPtr context, AcceleratorTypeIntel accelerator_type, nuint descriptor_size, IntPtr descriptor, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    void* descriptor_vptr = (void*)descriptor;
                    returnValue = CreateAcceleratorINTEL(context, accelerator_type, descriptor_size, descriptor_vptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateAcceleratorINTEL(IntPtr, AcceleratorTypeIntel, nuint, void*, int*)"/>
            public static unsafe IntPtr CreateAcceleratorINTEL<T1>(IntPtr context, AcceleratorTypeIntel accelerator_type, nuint descriptor_size, ReadOnlySpan<T1> descriptor, Span<int> errcode_ret)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (void* descriptor_ptr = descriptor)
                    {
                        returnValue = CreateAcceleratorINTEL(context, accelerator_type, descriptor_size, descriptor_ptr, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateAcceleratorINTEL(IntPtr, AcceleratorTypeIntel, nuint, void*, int*)"/>
            public static unsafe IntPtr CreateAcceleratorINTEL<T1>(IntPtr context, AcceleratorTypeIntel accelerator_type, nuint descriptor_size, T1[] descriptor, int[] errcode_ret)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (void* descriptor_ptr = descriptor)
                    {
                        returnValue = CreateAcceleratorINTEL(context, accelerator_type, descriptor_size, descriptor_ptr, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateAcceleratorINTEL(IntPtr, AcceleratorTypeIntel, nuint, void*, int*)"/>
            public static unsafe IntPtr CreateAcceleratorINTEL<T1>(IntPtr context, AcceleratorTypeIntel accelerator_type, nuint descriptor_size, ref readonly T1 descriptor, ref int errcode_ret)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (void* descriptor_ptr = &descriptor)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateAcceleratorINTEL(context, accelerator_type, descriptor_size, descriptor_ptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateBufferWithPropertiesINTEL(IntPtr, ulong*, MemFlags, nuint, void*, int*)"/>
            public static unsafe IntPtr CreateBufferWithPropertiesINTEL(IntPtr context, Span<ulong> properties, MemFlags flags, nuint size, IntPtr host_ptr, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        void* host_ptr_vptr = (void*)host_ptr;
                        returnValue = CreateBufferWithPropertiesINTEL(context, properties_ptr, flags, size, host_ptr_vptr, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateBufferWithPropertiesINTEL(IntPtr, ulong*, MemFlags, nuint, void*, int*)"/>
            public static unsafe IntPtr CreateBufferWithPropertiesINTEL(IntPtr context, ulong[] properties, MemFlags flags, nuint size, IntPtr host_ptr, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        void* host_ptr_vptr = (void*)host_ptr;
                        returnValue = CreateBufferWithPropertiesINTEL(context, properties_ptr, flags, size, host_ptr_vptr, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateBufferWithPropertiesINTEL(IntPtr, ulong*, MemFlags, nuint, void*, int*)"/>
            public static unsafe IntPtr CreateBufferWithPropertiesINTEL(IntPtr context, ref ulong properties, MemFlags flags, nuint size, IntPtr host_ptr, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    void* host_ptr_vptr = (void*)host_ptr;
                    returnValue = CreateBufferWithPropertiesINTEL(context, properties_ptr, flags, size, host_ptr_vptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateBufferWithPropertiesINTEL(IntPtr, ulong*, MemFlags, nuint, void*, int*)"/>
            public static unsafe IntPtr CreateBufferWithPropertiesINTEL<T1>(IntPtr context, Span<ulong> properties, MemFlags flags, nuint size, Span<T1> host_ptr, Span<int> errcode_ret)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (void* host_ptr_ptr = host_ptr)
                    {
                        fixed (ulong* properties_ptr = properties)
                        {
                            returnValue = CreateBufferWithPropertiesINTEL(context, properties_ptr, flags, size, host_ptr_ptr, errcode_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateBufferWithPropertiesINTEL(IntPtr, ulong*, MemFlags, nuint, void*, int*)"/>
            public static unsafe IntPtr CreateBufferWithPropertiesINTEL<T1>(IntPtr context, ulong[] properties, MemFlags flags, nuint size, T1[] host_ptr, int[] errcode_ret)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (void* host_ptr_ptr = host_ptr)
                    {
                        fixed (ulong* properties_ptr = properties)
                        {
                            returnValue = CreateBufferWithPropertiesINTEL(context, properties_ptr, flags, size, host_ptr_ptr, errcode_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateBufferWithPropertiesINTEL(IntPtr, ulong*, MemFlags, nuint, void*, int*)"/>
            public static unsafe IntPtr CreateBufferWithPropertiesINTEL<T1>(IntPtr context, ref ulong properties, MemFlags flags, nuint size, ref T1 host_ptr, ref int errcode_ret)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (void* host_ptr_ptr = &host_ptr)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateBufferWithPropertiesINTEL(context, properties_ptr, flags, size, host_ptr_ptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromDX9MediaSurfaceINTEL(IntPtr, MemFlags, IntPtr*, IntPtr, uint, int*)"/>
            public static unsafe IntPtr CreateFromDX9MediaSurfaceINTEL(IntPtr context, MemFlags flags, Span<IntPtr> resource, IntPtr sharedHandle, uint plane, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* resource_ptr = resource)
                    {
                        returnValue = CreateFromDX9MediaSurfaceINTEL(context, flags, resource_ptr, sharedHandle, plane, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromDX9MediaSurfaceINTEL(IntPtr, MemFlags, IntPtr*, IntPtr, uint, int*)"/>
            public static unsafe IntPtr CreateFromDX9MediaSurfaceINTEL(IntPtr context, MemFlags flags, IntPtr[] resource, IntPtr sharedHandle, uint plane, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* resource_ptr = resource)
                    {
                        returnValue = CreateFromDX9MediaSurfaceINTEL(context, flags, resource_ptr, sharedHandle, plane, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromDX9MediaSurfaceINTEL(IntPtr, MemFlags, IntPtr*, IntPtr, uint, int*)"/>
            public static unsafe IntPtr CreateFromDX9MediaSurfaceINTEL(IntPtr context, MemFlags flags, ref IntPtr resource, IntPtr sharedHandle, uint plane, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (IntPtr* resource_ptr = &resource)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateFromDX9MediaSurfaceINTEL(context, flags, resource_ptr, sharedHandle, plane, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromVA_APIMediaSurfaceINTEL(IntPtr, MemFlags, uint*, uint, int*)"/>
            public static unsafe IntPtr CreateFromVA_APIMediaSurfaceINTEL(IntPtr context, MemFlags flags, Span<uint> surface, uint plane, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (uint* surface_ptr = surface)
                    {
                        returnValue = CreateFromVA_APIMediaSurfaceINTEL(context, flags, surface_ptr, plane, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromVA_APIMediaSurfaceINTEL(IntPtr, MemFlags, uint*, uint, int*)"/>
            public static unsafe IntPtr CreateFromVA_APIMediaSurfaceINTEL(IntPtr context, MemFlags flags, uint[] surface, uint plane, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (uint* surface_ptr = surface)
                    {
                        returnValue = CreateFromVA_APIMediaSurfaceINTEL(context, flags, surface_ptr, plane, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromVA_APIMediaSurfaceINTEL(IntPtr, MemFlags, uint*, uint, int*)"/>
            public static unsafe IntPtr CreateFromVA_APIMediaSurfaceINTEL(IntPtr context, MemFlags flags, ref uint surface, uint plane, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (uint* surface_ptr = &surface)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateFromVA_APIMediaSurfaceINTEL(context, flags, surface_ptr, plane, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DeviceMemAllocINTEL(IntPtr, IntPtr, ulong*, nuint, uint, int*)"/>
            public static unsafe void* DeviceMemAllocINTEL(IntPtr context, IntPtr device, Span<ulong> properties, nuint size, uint alignment, Span<int> errcode_ret)
            {
                void* returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = DeviceMemAllocINTEL(context, device, properties_ptr, size, alignment, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="DeviceMemAllocINTEL(IntPtr, IntPtr, ulong*, nuint, uint, int*)"/>
            public static unsafe void* DeviceMemAllocINTEL(IntPtr context, IntPtr device, ulong[] properties, nuint size, uint alignment, int[] errcode_ret)
            {
                void* returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = DeviceMemAllocINTEL(context, device, properties_ptr, size, alignment, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="DeviceMemAllocINTEL(IntPtr, IntPtr, ulong*, nuint, uint, int*)"/>
            public static unsafe void* DeviceMemAllocINTEL(IntPtr context, IntPtr device, ref ulong properties, nuint size, uint alignment, ref int errcode_ret)
            {
                void* returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = DeviceMemAllocINTEL(context, device, properties_ptr, size, alignment, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireDX9ObjectsINTEL(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireDX9ObjectsINTEL(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireDX9ObjectsINTEL(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireDX9ObjectsINTEL(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireDX9ObjectsINTEL(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireDX9ObjectsINTEL(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireDX9ObjectsINTEL(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireDX9ObjectsINTEL(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueAcquireDX9ObjectsINTEL(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireVA_APIMediaSurfacesINTEL(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireVA_APIMediaSurfacesINTEL(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireVA_APIMediaSurfacesINTEL(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireVA_APIMediaSurfacesINTEL(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireVA_APIMediaSurfacesINTEL(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireVA_APIMediaSurfacesINTEL(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireVA_APIMediaSurfacesINTEL(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireVA_APIMediaSurfacesINTEL(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueAcquireVA_APIMediaSurfacesINTEL(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemAdviseINTEL(IntPtr, void*, nuint, uint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemAdviseINTEL(IntPtr command_queue, IntPtr ptr, nuint size, uint advice, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* ptr_vptr = (void*)ptr;
                        returnValue = EnqueueMemAdviseINTEL(command_queue, ptr_vptr, size, advice, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemAdviseINTEL(IntPtr, void*, nuint, uint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemAdviseINTEL(IntPtr command_queue, IntPtr ptr, nuint size, uint advice, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* ptr_vptr = (void*)ptr;
                        returnValue = EnqueueMemAdviseINTEL(command_queue, ptr_vptr, size, advice, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemAdviseINTEL(IntPtr, void*, nuint, uint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemAdviseINTEL(IntPtr command_queue, IntPtr ptr, nuint size, uint advice, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    void* ptr_vptr = (void*)ptr;
                    returnValue = EnqueueMemAdviseINTEL(command_queue, ptr_vptr, size, advice, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemAdviseINTEL(IntPtr, void*, nuint, uint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemAdviseINTEL<T1>(IntPtr command_queue, ReadOnlySpan<T1> ptr, nuint size, uint advice, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* ptr_ptr = ptr)
                        {
                            returnValue = EnqueueMemAdviseINTEL(command_queue, ptr_ptr, size, advice, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemAdviseINTEL(IntPtr, void*, nuint, uint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemAdviseINTEL<T1>(IntPtr command_queue, T1[] ptr, nuint size, uint advice, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* ptr_ptr = ptr)
                        {
                            returnValue = EnqueueMemAdviseINTEL(command_queue, ptr_ptr, size, advice, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemAdviseINTEL(IntPtr, void*, nuint, uint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemAdviseINTEL<T1>(IntPtr command_queue, ref readonly T1 ptr, nuint size, uint advice, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* ptr_ptr = &ptr)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueMemAdviseINTEL(command_queue, ptr_ptr, size, advice, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemcpyINTEL(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemcpyINTEL(IntPtr command_queue, Bool blocking, IntPtr dst_ptr, IntPtr src_ptr, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* dst_ptr_vptr = (void*)dst_ptr;
                        void* src_ptr_vptr = (void*)src_ptr;
                        returnValue = EnqueueMemcpyINTEL(command_queue, blocking, dst_ptr_vptr, src_ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemcpyINTEL(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemcpyINTEL(IntPtr command_queue, Bool blocking, IntPtr dst_ptr, IntPtr src_ptr, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* dst_ptr_vptr = (void*)dst_ptr;
                        void* src_ptr_vptr = (void*)src_ptr;
                        returnValue = EnqueueMemcpyINTEL(command_queue, blocking, dst_ptr_vptr, src_ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemcpyINTEL(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemcpyINTEL(IntPtr command_queue, Bool blocking, IntPtr dst_ptr, IntPtr src_ptr, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    void* dst_ptr_vptr = (void*)dst_ptr;
                    void* src_ptr_vptr = (void*)src_ptr;
                    returnValue = EnqueueMemcpyINTEL(command_queue, blocking, dst_ptr_vptr, src_ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemcpyINTEL(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemcpyINTEL<T1, T2>(IntPtr command_queue, Bool blocking, Span<T1> dst_ptr, ReadOnlySpan<T2> src_ptr, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* src_ptr_ptr = src_ptr)
                        {
                            fixed (void* dst_ptr_ptr = dst_ptr)
                            {
                                returnValue = EnqueueMemcpyINTEL(command_queue, blocking, dst_ptr_ptr, src_ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemcpyINTEL(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemcpyINTEL<T1, T2>(IntPtr command_queue, Bool blocking, T1[] dst_ptr, T2[] src_ptr, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* src_ptr_ptr = src_ptr)
                        {
                            fixed (void* dst_ptr_ptr = dst_ptr)
                            {
                                returnValue = EnqueueMemcpyINTEL(command_queue, blocking, dst_ptr_ptr, src_ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemcpyINTEL(IntPtr, Bool, void*, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemcpyINTEL<T1, T2>(IntPtr command_queue, Bool blocking, ref T1 dst_ptr, ref readonly T2 src_ptr, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (void* dst_ptr_ptr = &dst_ptr)
                fixed (void* src_ptr_ptr = &src_ptr)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueMemcpyINTEL(command_queue, blocking, dst_ptr_ptr, src_ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemFillINTEL(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemFillINTEL(IntPtr command_queue, IntPtr dst_ptr, IntPtr pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* dst_ptr_vptr = (void*)dst_ptr;
                        void* pattern_vptr = (void*)pattern;
                        returnValue = EnqueueMemFillINTEL(command_queue, dst_ptr_vptr, pattern_vptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemFillINTEL(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemFillINTEL(IntPtr command_queue, IntPtr dst_ptr, IntPtr pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* dst_ptr_vptr = (void*)dst_ptr;
                        void* pattern_vptr = (void*)pattern;
                        returnValue = EnqueueMemFillINTEL(command_queue, dst_ptr_vptr, pattern_vptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemFillINTEL(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemFillINTEL(IntPtr command_queue, IntPtr dst_ptr, IntPtr pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    void* dst_ptr_vptr = (void*)dst_ptr;
                    void* pattern_vptr = (void*)pattern;
                    returnValue = EnqueueMemFillINTEL(command_queue, dst_ptr_vptr, pattern_vptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemFillINTEL(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemFillINTEL<T1, T2>(IntPtr command_queue, Span<T1> dst_ptr, ReadOnlySpan<T2> pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* pattern_ptr = pattern)
                        {
                            fixed (void* dst_ptr_ptr = dst_ptr)
                            {
                                returnValue = EnqueueMemFillINTEL(command_queue, dst_ptr_ptr, pattern_ptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemFillINTEL(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemFillINTEL<T1, T2>(IntPtr command_queue, T1[] dst_ptr, T2[] pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* pattern_ptr = pattern)
                        {
                            fixed (void* dst_ptr_ptr = dst_ptr)
                            {
                                returnValue = EnqueueMemFillINTEL(command_queue, dst_ptr_ptr, pattern_ptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemFillINTEL(IntPtr, void*, void*, nuint, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemFillINTEL<T1, T2>(IntPtr command_queue, ref T1 dst_ptr, ref readonly T2 pattern, nuint pattern_size, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (void* dst_ptr_ptr = &dst_ptr)
                fixed (void* pattern_ptr = &pattern)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueMemFillINTEL(command_queue, dst_ptr_ptr, pattern_ptr, pattern_size, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemsetINTEL(IntPtr, void*, int, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemsetINTEL(IntPtr command_queue, IntPtr dst_ptr, int value, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* dst_ptr_vptr = (void*)dst_ptr;
                        returnValue = EnqueueMemsetINTEL(command_queue, dst_ptr_vptr, value, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemsetINTEL(IntPtr, void*, int, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemsetINTEL(IntPtr command_queue, IntPtr dst_ptr, int value, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* dst_ptr_vptr = (void*)dst_ptr;
                        returnValue = EnqueueMemsetINTEL(command_queue, dst_ptr_vptr, value, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemsetINTEL(IntPtr, void*, int, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemsetINTEL(IntPtr command_queue, IntPtr dst_ptr, int value, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    void* dst_ptr_vptr = (void*)dst_ptr;
                    returnValue = EnqueueMemsetINTEL(command_queue, dst_ptr_vptr, value, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemsetINTEL(IntPtr, void*, int, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemsetINTEL<T1>(IntPtr command_queue, Span<T1> dst_ptr, int value, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* dst_ptr_ptr = dst_ptr)
                        {
                            returnValue = EnqueueMemsetINTEL(command_queue, dst_ptr_ptr, value, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemsetINTEL(IntPtr, void*, int, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemsetINTEL<T1>(IntPtr command_queue, T1[] dst_ptr, int value, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* dst_ptr_ptr = dst_ptr)
                        {
                            returnValue = EnqueueMemsetINTEL(command_queue, dst_ptr_ptr, value, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMemsetINTEL(IntPtr, void*, int, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMemsetINTEL<T1>(IntPtr command_queue, ref T1 dst_ptr, int value, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dst_ptr_ptr = &dst_ptr)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueMemsetINTEL(command_queue, dst_ptr_ptr, value, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMigrateMemINTEL(IntPtr, void*, nuint, MemMigrationFlags, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMigrateMemINTEL(IntPtr command_queue, IntPtr ptr, nuint size, MemMigrationFlags flags, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* ptr_vptr = (void*)ptr;
                        returnValue = EnqueueMigrateMemINTEL(command_queue, ptr_vptr, size, flags, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMigrateMemINTEL(IntPtr, void*, nuint, MemMigrationFlags, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMigrateMemINTEL(IntPtr command_queue, IntPtr ptr, nuint size, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        void* ptr_vptr = (void*)ptr;
                        returnValue = EnqueueMigrateMemINTEL(command_queue, ptr_vptr, size, flags, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMigrateMemINTEL(IntPtr, void*, nuint, MemMigrationFlags, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMigrateMemINTEL(IntPtr command_queue, IntPtr ptr, nuint size, MemMigrationFlags flags, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    void* ptr_vptr = (void*)ptr;
                    returnValue = EnqueueMigrateMemINTEL(command_queue, ptr_vptr, size, flags, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMigrateMemINTEL(IntPtr, void*, nuint, MemMigrationFlags, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMigrateMemINTEL<T1>(IntPtr command_queue, ReadOnlySpan<T1> ptr, nuint size, MemMigrationFlags flags, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* ptr_ptr = ptr)
                        {
                            returnValue = EnqueueMigrateMemINTEL(command_queue, ptr_ptr, size, flags, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMigrateMemINTEL(IntPtr, void*, nuint, MemMigrationFlags, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMigrateMemINTEL<T1>(IntPtr command_queue, T1[] ptr, nuint size, MemMigrationFlags flags, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* ptr_ptr = ptr)
                        {
                            returnValue = EnqueueMigrateMemINTEL(command_queue, ptr_ptr, size, flags, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueMigrateMemINTEL(IntPtr, void*, nuint, MemMigrationFlags, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueMigrateMemINTEL<T1>(IntPtr command_queue, ref readonly T1 ptr, nuint size, MemMigrationFlags flags, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* ptr_ptr = &ptr)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueMigrateMemINTEL(command_queue, ptr_ptr, size, flags, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReadHostPipeINTEL(IntPtr, IntPtr, byte*, Bool, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReadHostPipeINTEL(IntPtr command_queue, IntPtr program, string pipe_symbol, Bool blocking_read, IntPtr ptr, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        byte* pipe_symbol_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(pipe_symbol);
                        void* ptr_vptr = (void*)ptr;
                        returnValue = EnqueueReadHostPipeINTEL(command_queue, program, pipe_symbol_ptr, blocking_read, ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        Marshal.FreeCoTaskMem((IntPtr)pipe_symbol_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReadHostPipeINTEL(IntPtr, IntPtr, byte*, Bool, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReadHostPipeINTEL(IntPtr command_queue, IntPtr program, string pipe_symbol, Bool blocking_read, IntPtr ptr, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        byte* pipe_symbol_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(pipe_symbol);
                        void* ptr_vptr = (void*)ptr;
                        returnValue = EnqueueReadHostPipeINTEL(command_queue, program, pipe_symbol_ptr, blocking_read, ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        Marshal.FreeCoTaskMem((IntPtr)pipe_symbol_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReadHostPipeINTEL(IntPtr, IntPtr, byte*, Bool, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReadHostPipeINTEL(IntPtr command_queue, IntPtr program, string pipe_symbol, Bool blocking_read, IntPtr ptr, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    byte* pipe_symbol_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(pipe_symbol);
                    void* ptr_vptr = (void*)ptr;
                    returnValue = EnqueueReadHostPipeINTEL(command_queue, program, pipe_symbol_ptr, blocking_read, ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)pipe_symbol_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReadHostPipeINTEL(IntPtr, IntPtr, byte*, Bool, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReadHostPipeINTEL<T1>(IntPtr command_queue, IntPtr program, string pipe_symbol, Bool blocking_read, Span<T1> ptr, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* ptr_ptr = ptr)
                        {
                            byte* pipe_symbol_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(pipe_symbol);
                            returnValue = EnqueueReadHostPipeINTEL(command_queue, program, pipe_symbol_ptr, blocking_read, ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            Marshal.FreeCoTaskMem((IntPtr)pipe_symbol_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReadHostPipeINTEL(IntPtr, IntPtr, byte*, Bool, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReadHostPipeINTEL<T1>(IntPtr command_queue, IntPtr program, string pipe_symbol, Bool blocking_read, T1[] ptr, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* ptr_ptr = ptr)
                        {
                            byte* pipe_symbol_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(pipe_symbol);
                            returnValue = EnqueueReadHostPipeINTEL(command_queue, program, pipe_symbol_ptr, blocking_read, ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            Marshal.FreeCoTaskMem((IntPtr)pipe_symbol_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReadHostPipeINTEL(IntPtr, IntPtr, byte*, Bool, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReadHostPipeINTEL<T1>(IntPtr command_queue, IntPtr program, string pipe_symbol, Bool blocking_read, ref T1 ptr, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* ptr_ptr = &ptr)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    byte* pipe_symbol_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(pipe_symbol);
                    returnValue = EnqueueReadHostPipeINTEL(command_queue, program, pipe_symbol_ptr, blocking_read, ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)pipe_symbol_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseDX9ObjectsINTEL(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseDX9ObjectsINTEL(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseDX9ObjectsINTEL(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseDX9ObjectsINTEL(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseDX9ObjectsINTEL(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseDX9ObjectsINTEL(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseDX9ObjectsINTEL(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseDX9ObjectsINTEL(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueReleaseDX9ObjectsINTEL(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseVA_APIMediaSurfacesINTEL(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseVA_APIMediaSurfacesINTEL(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseVA_APIMediaSurfacesINTEL(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseVA_APIMediaSurfacesINTEL(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseVA_APIMediaSurfacesINTEL(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseVA_APIMediaSurfacesINTEL(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseVA_APIMediaSurfacesINTEL(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseVA_APIMediaSurfacesINTEL(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueReleaseVA_APIMediaSurfacesINTEL(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueWriteHostPipeINTEL(IntPtr, IntPtr, byte*, Bool, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueWriteHostPipeINTEL(IntPtr command_queue, IntPtr program, string pipe_symbol, Bool blocking_write, IntPtr ptr, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        byte* pipe_symbol_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(pipe_symbol);
                        void* ptr_vptr = (void*)ptr;
                        returnValue = EnqueueWriteHostPipeINTEL(command_queue, program, pipe_symbol_ptr, blocking_write, ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        Marshal.FreeCoTaskMem((IntPtr)pipe_symbol_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueWriteHostPipeINTEL(IntPtr, IntPtr, byte*, Bool, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueWriteHostPipeINTEL(IntPtr command_queue, IntPtr program, string pipe_symbol, Bool blocking_write, IntPtr ptr, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        byte* pipe_symbol_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(pipe_symbol);
                        void* ptr_vptr = (void*)ptr;
                        returnValue = EnqueueWriteHostPipeINTEL(command_queue, program, pipe_symbol_ptr, blocking_write, ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        Marshal.FreeCoTaskMem((IntPtr)pipe_symbol_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueWriteHostPipeINTEL(IntPtr, IntPtr, byte*, Bool, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueWriteHostPipeINTEL(IntPtr command_queue, IntPtr program, string pipe_symbol, Bool blocking_write, IntPtr ptr, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    byte* pipe_symbol_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(pipe_symbol);
                    void* ptr_vptr = (void*)ptr;
                    returnValue = EnqueueWriteHostPipeINTEL(command_queue, program, pipe_symbol_ptr, blocking_write, ptr_vptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)pipe_symbol_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueWriteHostPipeINTEL(IntPtr, IntPtr, byte*, Bool, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueWriteHostPipeINTEL<T1>(IntPtr command_queue, IntPtr program, string pipe_symbol, Bool blocking_write, ReadOnlySpan<T1> ptr, nuint size, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* ptr_ptr = ptr)
                        {
                            byte* pipe_symbol_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(pipe_symbol);
                            returnValue = EnqueueWriteHostPipeINTEL(command_queue, program, pipe_symbol_ptr, blocking_write, ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            Marshal.FreeCoTaskMem((IntPtr)pipe_symbol_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueWriteHostPipeINTEL(IntPtr, IntPtr, byte*, Bool, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueWriteHostPipeINTEL<T1>(IntPtr command_queue, IntPtr program, string pipe_symbol, Bool blocking_write, T1[] ptr, nuint size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (void* ptr_ptr = ptr)
                        {
                            byte* pipe_symbol_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(pipe_symbol);
                            returnValue = EnqueueWriteHostPipeINTEL(command_queue, program, pipe_symbol_ptr, blocking_write, ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            Marshal.FreeCoTaskMem((IntPtr)pipe_symbol_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueWriteHostPipeINTEL(IntPtr, IntPtr, byte*, Bool, void*, nuint, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueWriteHostPipeINTEL<T1>(IntPtr command_queue, IntPtr program, string pipe_symbol, Bool blocking_write, ref readonly T1 ptr, nuint size, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* ptr_ptr = &ptr)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    byte* pipe_symbol_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(pipe_symbol);
                    returnValue = EnqueueWriteHostPipeINTEL(command_queue, program, pipe_symbol_ptr, blocking_write, ptr_ptr, size, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                    Marshal.FreeCoTaskMem((IntPtr)pipe_symbol_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetAcceleratorInfoINTEL(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetAcceleratorInfoINTEL(IntPtr accelerator, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetAcceleratorInfoINTEL(accelerator, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetAcceleratorInfoINTEL(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetAcceleratorInfoINTEL(IntPtr accelerator, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetAcceleratorInfoINTEL(accelerator, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetAcceleratorInfoINTEL(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetAcceleratorInfoINTEL(IntPtr accelerator, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetAcceleratorInfoINTEL(accelerator, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetAcceleratorInfoINTEL(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetAcceleratorInfoINTEL<T1>(IntPtr accelerator, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        returnValue = GetAcceleratorInfoINTEL(accelerator, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetAcceleratorInfoINTEL(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetAcceleratorInfoINTEL<T1>(IntPtr accelerator, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        returnValue = GetAcceleratorInfoINTEL(accelerator, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetAcceleratorInfoINTEL(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetAcceleratorInfoINTEL<T1>(IntPtr accelerator, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* param_value_ptr = &param_value)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    returnValue = GetAcceleratorInfoINTEL(accelerator, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromDX9INTEL(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromDX9INTEL(IntPtr platform, uint dx9_device_source, IntPtr dx9_object, uint dx9_device_set, uint num_entries, Span<IntPtr> devices, Span<uint> num_devices)
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        void* dx9_object_vptr = (void*)dx9_object;
                        returnValue = GetDeviceIDsFromDX9INTEL(platform, dx9_device_source, dx9_object_vptr, dx9_device_set, num_entries, devices_ptr, num_devices_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromDX9INTEL(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromDX9INTEL(IntPtr platform, uint dx9_device_source, IntPtr dx9_object, uint dx9_device_set, uint num_entries, IntPtr[] devices, uint[] num_devices)
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        void* dx9_object_vptr = (void*)dx9_object;
                        returnValue = GetDeviceIDsFromDX9INTEL(platform, dx9_device_source, dx9_object_vptr, dx9_device_set, num_entries, devices_ptr, num_devices_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromDX9INTEL(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromDX9INTEL(IntPtr platform, uint dx9_device_source, IntPtr dx9_object, uint dx9_device_set, uint num_entries, ref IntPtr devices, ref uint num_devices)
            {
                int returnValue;
                fixed (IntPtr* devices_ptr = &devices)
                fixed (uint* num_devices_ptr = &num_devices)
                {
                    void* dx9_object_vptr = (void*)dx9_object;
                    returnValue = GetDeviceIDsFromDX9INTEL(platform, dx9_device_source, dx9_object_vptr, dx9_device_set, num_entries, devices_ptr, num_devices_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromDX9INTEL(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromDX9INTEL<T1>(IntPtr platform, uint dx9_device_source, Span<T1> dx9_object, uint dx9_device_set, uint num_entries, Span<IntPtr> devices, Span<uint> num_devices)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        fixed (void* dx9_object_ptr = dx9_object)
                        {
                            returnValue = GetDeviceIDsFromDX9INTEL(platform, dx9_device_source, dx9_object_ptr, dx9_device_set, num_entries, devices_ptr, num_devices_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromDX9INTEL(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromDX9INTEL<T1>(IntPtr platform, uint dx9_device_source, T1[] dx9_object, uint dx9_device_set, uint num_entries, IntPtr[] devices, uint[] num_devices)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        fixed (void* dx9_object_ptr = dx9_object)
                        {
                            returnValue = GetDeviceIDsFromDX9INTEL(platform, dx9_device_source, dx9_object_ptr, dx9_device_set, num_entries, devices_ptr, num_devices_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromDX9INTEL(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromDX9INTEL<T1>(IntPtr platform, uint dx9_device_source, ref T1 dx9_object, uint dx9_device_set, uint num_entries, ref IntPtr devices, ref uint num_devices)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dx9_object_ptr = &dx9_object)
                fixed (IntPtr* devices_ptr = &devices)
                fixed (uint* num_devices_ptr = &num_devices)
                {
                    returnValue = GetDeviceIDsFromDX9INTEL(platform, dx9_device_source, dx9_object_ptr, dx9_device_set, num_entries, devices_ptr, num_devices_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromVA_APIMediaAdapterINTEL(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromVA_APIMediaAdapterINTEL(IntPtr platform, uint media_adapter_type, IntPtr media_adapter, uint media_adapter_set, uint num_entries, Span<IntPtr> devices, Span<uint> num_devices)
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        void* media_adapter_vptr = (void*)media_adapter;
                        returnValue = GetDeviceIDsFromVA_APIMediaAdapterINTEL(platform, media_adapter_type, media_adapter_vptr, media_adapter_set, num_entries, devices_ptr, num_devices_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromVA_APIMediaAdapterINTEL(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromVA_APIMediaAdapterINTEL(IntPtr platform, uint media_adapter_type, IntPtr media_adapter, uint media_adapter_set, uint num_entries, IntPtr[] devices, uint[] num_devices)
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        void* media_adapter_vptr = (void*)media_adapter;
                        returnValue = GetDeviceIDsFromVA_APIMediaAdapterINTEL(platform, media_adapter_type, media_adapter_vptr, media_adapter_set, num_entries, devices_ptr, num_devices_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromVA_APIMediaAdapterINTEL(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromVA_APIMediaAdapterINTEL(IntPtr platform, uint media_adapter_type, IntPtr media_adapter, uint media_adapter_set, uint num_entries, ref IntPtr devices, ref uint num_devices)
            {
                int returnValue;
                fixed (IntPtr* devices_ptr = &devices)
                fixed (uint* num_devices_ptr = &num_devices)
                {
                    void* media_adapter_vptr = (void*)media_adapter;
                    returnValue = GetDeviceIDsFromVA_APIMediaAdapterINTEL(platform, media_adapter_type, media_adapter_vptr, media_adapter_set, num_entries, devices_ptr, num_devices_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromVA_APIMediaAdapterINTEL(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromVA_APIMediaAdapterINTEL<T1>(IntPtr platform, uint media_adapter_type, Span<T1> media_adapter, uint media_adapter_set, uint num_entries, Span<IntPtr> devices, Span<uint> num_devices)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        fixed (void* media_adapter_ptr = media_adapter)
                        {
                            returnValue = GetDeviceIDsFromVA_APIMediaAdapterINTEL(platform, media_adapter_type, media_adapter_ptr, media_adapter_set, num_entries, devices_ptr, num_devices_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromVA_APIMediaAdapterINTEL(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromVA_APIMediaAdapterINTEL<T1>(IntPtr platform, uint media_adapter_type, T1[] media_adapter, uint media_adapter_set, uint num_entries, IntPtr[] devices, uint[] num_devices)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        fixed (void* media_adapter_ptr = media_adapter)
                        {
                            returnValue = GetDeviceIDsFromVA_APIMediaAdapterINTEL(platform, media_adapter_type, media_adapter_ptr, media_adapter_set, num_entries, devices_ptr, num_devices_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromVA_APIMediaAdapterINTEL(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromVA_APIMediaAdapterINTEL<T1>(IntPtr platform, uint media_adapter_type, ref T1 media_adapter, uint media_adapter_set, uint num_entries, ref IntPtr devices, ref uint num_devices)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* media_adapter_ptr = &media_adapter)
                fixed (IntPtr* devices_ptr = &devices)
                fixed (uint* num_devices_ptr = &num_devices)
                {
                    returnValue = GetDeviceIDsFromVA_APIMediaAdapterINTEL(platform, media_adapter_type, media_adapter_ptr, media_adapter_set, num_entries, devices_ptr, num_devices_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMemAllocInfoINTEL(IntPtr, void*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetMemAllocInfoINTEL(IntPtr context, IntPtr ptr, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* ptr_vptr = (void*)ptr;
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetMemAllocInfoINTEL(context, ptr_vptr, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMemAllocInfoINTEL(IntPtr, void*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetMemAllocInfoINTEL(IntPtr context, IntPtr ptr, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* ptr_vptr = (void*)ptr;
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetMemAllocInfoINTEL(context, ptr_vptr, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMemAllocInfoINTEL(IntPtr, void*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetMemAllocInfoINTEL(IntPtr context, IntPtr ptr, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    void* ptr_vptr = (void*)ptr;
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetMemAllocInfoINTEL(context, ptr_vptr, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMemAllocInfoINTEL(IntPtr, void*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetMemAllocInfoINTEL<T1, T2>(IntPtr context, ReadOnlySpan<T1> ptr, uint param_name, nuint param_value_size, Span<T2> param_value, Span<nuint> param_value_size_ret)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        fixed (void* ptr_ptr = ptr)
                        {
                            returnValue = GetMemAllocInfoINTEL(context, ptr_ptr, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMemAllocInfoINTEL(IntPtr, void*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetMemAllocInfoINTEL<T1, T2>(IntPtr context, T1[] ptr, uint param_name, nuint param_value_size, T2[] param_value, nuint[] param_value_size_ret)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        fixed (void* ptr_ptr = ptr)
                        {
                            returnValue = GetMemAllocInfoINTEL(context, ptr_ptr, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMemAllocInfoINTEL(IntPtr, void*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetMemAllocInfoINTEL<T1, T2>(IntPtr context, ref readonly T1 ptr, uint param_name, nuint param_value_size, ref T2 param_value, ref nuint param_value_size_ret)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (void* ptr_ptr = &ptr)
                fixed (void* param_value_ptr = &param_value)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    returnValue = GetMemAllocInfoINTEL(context, ptr_ptr, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSupportedD3D10TextureFormatsINTEL(IntPtr, MemFlags, uint, uint, uint*, uint*)"/>
            public static unsafe int GetSupportedD3D10TextureFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint num_entries, Span<uint> d3d10_formats, Span<uint> num_texture_formats)
            {
                int returnValue;
                fixed (uint* num_texture_formats_ptr = num_texture_formats)
                {
                    fixed (uint* d3d10_formats_ptr = d3d10_formats)
                    {
                        returnValue = GetSupportedD3D10TextureFormatsINTEL(context, flags, image_type, num_entries, d3d10_formats_ptr, num_texture_formats_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSupportedD3D10TextureFormatsINTEL(IntPtr, MemFlags, uint, uint, uint*, uint*)"/>
            public static unsafe int GetSupportedD3D10TextureFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint num_entries, uint[] d3d10_formats, uint[] num_texture_formats)
            {
                int returnValue;
                fixed (uint* num_texture_formats_ptr = num_texture_formats)
                {
                    fixed (uint* d3d10_formats_ptr = d3d10_formats)
                    {
                        returnValue = GetSupportedD3D10TextureFormatsINTEL(context, flags, image_type, num_entries, d3d10_formats_ptr, num_texture_formats_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSupportedD3D10TextureFormatsINTEL(IntPtr, MemFlags, uint, uint, uint*, uint*)"/>
            public static unsafe int GetSupportedD3D10TextureFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint num_entries, ref uint d3d10_formats, ref uint num_texture_formats)
            {
                int returnValue;
                fixed (uint* d3d10_formats_ptr = &d3d10_formats)
                fixed (uint* num_texture_formats_ptr = &num_texture_formats)
                {
                    returnValue = GetSupportedD3D10TextureFormatsINTEL(context, flags, image_type, num_entries, d3d10_formats_ptr, num_texture_formats_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSupportedD3D11TextureFormatsINTEL(IntPtr, MemFlags, uint, uint, uint, uint*, uint*)"/>
            public static unsafe int GetSupportedD3D11TextureFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint plane, uint num_entries, Span<uint> d3d11_formats, Span<uint> num_texture_formats)
            {
                int returnValue;
                fixed (uint* num_texture_formats_ptr = num_texture_formats)
                {
                    fixed (uint* d3d11_formats_ptr = d3d11_formats)
                    {
                        returnValue = GetSupportedD3D11TextureFormatsINTEL(context, flags, image_type, plane, num_entries, d3d11_formats_ptr, num_texture_formats_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSupportedD3D11TextureFormatsINTEL(IntPtr, MemFlags, uint, uint, uint, uint*, uint*)"/>
            public static unsafe int GetSupportedD3D11TextureFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint plane, uint num_entries, uint[] d3d11_formats, uint[] num_texture_formats)
            {
                int returnValue;
                fixed (uint* num_texture_formats_ptr = num_texture_formats)
                {
                    fixed (uint* d3d11_formats_ptr = d3d11_formats)
                    {
                        returnValue = GetSupportedD3D11TextureFormatsINTEL(context, flags, image_type, plane, num_entries, d3d11_formats_ptr, num_texture_formats_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSupportedD3D11TextureFormatsINTEL(IntPtr, MemFlags, uint, uint, uint, uint*, uint*)"/>
            public static unsafe int GetSupportedD3D11TextureFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint plane, uint num_entries, ref uint d3d11_formats, ref uint num_texture_formats)
            {
                int returnValue;
                fixed (uint* d3d11_formats_ptr = &d3d11_formats)
                fixed (uint* num_texture_formats_ptr = &num_texture_formats)
                {
                    returnValue = GetSupportedD3D11TextureFormatsINTEL(context, flags, image_type, plane, num_entries, d3d11_formats_ptr, num_texture_formats_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSupportedDX9MediaSurfaceFormatsINTEL(IntPtr, MemFlags, uint, uint, uint, uint*, uint*)"/>
            public static unsafe int GetSupportedDX9MediaSurfaceFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint plane, uint num_entries, Span<uint> dx9_formats, Span<uint> num_surface_formats)
            {
                int returnValue;
                fixed (uint* num_surface_formats_ptr = num_surface_formats)
                {
                    fixed (uint* dx9_formats_ptr = dx9_formats)
                    {
                        returnValue = GetSupportedDX9MediaSurfaceFormatsINTEL(context, flags, image_type, plane, num_entries, dx9_formats_ptr, num_surface_formats_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSupportedDX9MediaSurfaceFormatsINTEL(IntPtr, MemFlags, uint, uint, uint, uint*, uint*)"/>
            public static unsafe int GetSupportedDX9MediaSurfaceFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint plane, uint num_entries, uint[] dx9_formats, uint[] num_surface_formats)
            {
                int returnValue;
                fixed (uint* num_surface_formats_ptr = num_surface_formats)
                {
                    fixed (uint* dx9_formats_ptr = dx9_formats)
                    {
                        returnValue = GetSupportedDX9MediaSurfaceFormatsINTEL(context, flags, image_type, plane, num_entries, dx9_formats_ptr, num_surface_formats_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSupportedDX9MediaSurfaceFormatsINTEL(IntPtr, MemFlags, uint, uint, uint, uint*, uint*)"/>
            public static unsafe int GetSupportedDX9MediaSurfaceFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint plane, uint num_entries, ref uint dx9_formats, ref uint num_surface_formats)
            {
                int returnValue;
                fixed (uint* dx9_formats_ptr = &dx9_formats)
                fixed (uint* num_surface_formats_ptr = &num_surface_formats)
                {
                    returnValue = GetSupportedDX9MediaSurfaceFormatsINTEL(context, flags, image_type, plane, num_entries, dx9_formats_ptr, num_surface_formats_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSupportedGLTextureFormatsINTEL(IntPtr, MemFlags, uint, uint, uint*, uint*)"/>
            public static unsafe int GetSupportedGLTextureFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint num_entries, Span<uint> gl_formats, Span<uint> num_texture_formats)
            {
                int returnValue;
                fixed (uint* num_texture_formats_ptr = num_texture_formats)
                {
                    fixed (uint* gl_formats_ptr = gl_formats)
                    {
                        returnValue = GetSupportedGLTextureFormatsINTEL(context, flags, image_type, num_entries, gl_formats_ptr, num_texture_formats_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSupportedGLTextureFormatsINTEL(IntPtr, MemFlags, uint, uint, uint*, uint*)"/>
            public static unsafe int GetSupportedGLTextureFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint num_entries, uint[] gl_formats, uint[] num_texture_formats)
            {
                int returnValue;
                fixed (uint* num_texture_formats_ptr = num_texture_formats)
                {
                    fixed (uint* gl_formats_ptr = gl_formats)
                    {
                        returnValue = GetSupportedGLTextureFormatsINTEL(context, flags, image_type, num_entries, gl_formats_ptr, num_texture_formats_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSupportedGLTextureFormatsINTEL(IntPtr, MemFlags, uint, uint, uint*, uint*)"/>
            public static unsafe int GetSupportedGLTextureFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint num_entries, ref uint gl_formats, ref uint num_texture_formats)
            {
                int returnValue;
                fixed (uint* gl_formats_ptr = &gl_formats)
                fixed (uint* num_texture_formats_ptr = &num_texture_formats)
                {
                    returnValue = GetSupportedGLTextureFormatsINTEL(context, flags, image_type, num_entries, gl_formats_ptr, num_texture_formats_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSupportedVA_APIMediaSurfaceFormatsINTEL(IntPtr, MemFlags, uint, uint, uint, VAImageFormat*, uint*)"/>
            public static unsafe int GetSupportedVA_APIMediaSurfaceFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint plane, uint num_entries, Span<VAImageFormat> va_api_formats, Span<uint> num_surface_formats)
            {
                int returnValue;
                fixed (uint* num_surface_formats_ptr = num_surface_formats)
                {
                    fixed (VAImageFormat* va_api_formats_ptr = va_api_formats)
                    {
                        returnValue = GetSupportedVA_APIMediaSurfaceFormatsINTEL(context, flags, image_type, plane, num_entries, va_api_formats_ptr, num_surface_formats_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSupportedVA_APIMediaSurfaceFormatsINTEL(IntPtr, MemFlags, uint, uint, uint, VAImageFormat*, uint*)"/>
            public static unsafe int GetSupportedVA_APIMediaSurfaceFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint plane, uint num_entries, VAImageFormat[] va_api_formats, uint[] num_surface_formats)
            {
                int returnValue;
                fixed (uint* num_surface_formats_ptr = num_surface_formats)
                {
                    fixed (VAImageFormat* va_api_formats_ptr = va_api_formats)
                    {
                        returnValue = GetSupportedVA_APIMediaSurfaceFormatsINTEL(context, flags, image_type, plane, num_entries, va_api_formats_ptr, num_surface_formats_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSupportedVA_APIMediaSurfaceFormatsINTEL(IntPtr, MemFlags, uint, uint, uint, VAImageFormat*, uint*)"/>
            public static unsafe int GetSupportedVA_APIMediaSurfaceFormatsINTEL(IntPtr context, MemFlags flags, uint image_type, uint plane, uint num_entries, ref VAImageFormat va_api_formats, ref uint num_surface_formats)
            {
                int returnValue;
                fixed (VAImageFormat* va_api_formats_ptr = &va_api_formats)
                fixed (uint* num_surface_formats_ptr = &num_surface_formats)
                {
                    returnValue = GetSupportedVA_APIMediaSurfaceFormatsINTEL(context, flags, image_type, plane, num_entries, va_api_formats_ptr, num_surface_formats_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="HostMemAllocINTEL(IntPtr, ulong*, nuint, uint, int*)"/>
            public static unsafe void* HostMemAllocINTEL(IntPtr context, Span<ulong> properties, nuint size, uint alignment, Span<int> errcode_ret)
            {
                void* returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = HostMemAllocINTEL(context, properties_ptr, size, alignment, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="HostMemAllocINTEL(IntPtr, ulong*, nuint, uint, int*)"/>
            public static unsafe void* HostMemAllocINTEL(IntPtr context, ulong[] properties, nuint size, uint alignment, int[] errcode_ret)
            {
                void* returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = HostMemAllocINTEL(context, properties_ptr, size, alignment, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="HostMemAllocINTEL(IntPtr, ulong*, nuint, uint, int*)"/>
            public static unsafe void* HostMemAllocINTEL(IntPtr context, ref ulong properties, nuint size, uint alignment, ref int errcode_ret)
            {
                void* returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = HostMemAllocINTEL(context, properties_ptr, size, alignment, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="MemBlockingFreeINTEL(IntPtr, void*)"/>
            public static unsafe int MemBlockingFreeINTEL(IntPtr context, IntPtr ptr)
            {
                int returnValue;
                void* ptr_vptr = (void*)ptr;
                returnValue = MemBlockingFreeINTEL(context, ptr_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="MemBlockingFreeINTEL(IntPtr, void*)"/>
            public static unsafe int MemBlockingFreeINTEL<T1>(IntPtr context, Span<T1> ptr)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* ptr_ptr = ptr)
                {
                    returnValue = MemBlockingFreeINTEL(context, ptr_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="MemBlockingFreeINTEL(IntPtr, void*)"/>
            public static unsafe int MemBlockingFreeINTEL<T1>(IntPtr context, T1[] ptr)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* ptr_ptr = ptr)
                {
                    returnValue = MemBlockingFreeINTEL(context, ptr_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="MemBlockingFreeINTEL(IntPtr, void*)"/>
            public static unsafe int MemBlockingFreeINTEL<T1>(IntPtr context, ref T1 ptr)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* ptr_ptr = &ptr)
                {
                    returnValue = MemBlockingFreeINTEL(context, ptr_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="MemFreeINTEL(IntPtr, void*)"/>
            public static unsafe int MemFreeINTEL(IntPtr context, IntPtr ptr)
            {
                int returnValue;
                void* ptr_vptr = (void*)ptr;
                returnValue = MemFreeINTEL(context, ptr_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="MemFreeINTEL(IntPtr, void*)"/>
            public static unsafe int MemFreeINTEL<T1>(IntPtr context, Span<T1> ptr)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* ptr_ptr = ptr)
                {
                    returnValue = MemFreeINTEL(context, ptr_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="MemFreeINTEL(IntPtr, void*)"/>
            public static unsafe int MemFreeINTEL<T1>(IntPtr context, T1[] ptr)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* ptr_ptr = ptr)
                {
                    returnValue = MemFreeINTEL(context, ptr_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="MemFreeINTEL(IntPtr, void*)"/>
            public static unsafe int MemFreeINTEL<T1>(IntPtr context, ref T1 ptr)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* ptr_ptr = &ptr)
                {
                    returnValue = MemFreeINTEL(context, ptr_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetKernelArgMemPointerINTEL(IntPtr, uint, void*)"/>
            public static unsafe int SetKernelArgMemPointerINTEL(IntPtr kernel, uint arg_index, IntPtr arg_value)
            {
                int returnValue;
                void* arg_value_vptr = (void*)arg_value;
                returnValue = SetKernelArgMemPointerINTEL(kernel, arg_index, arg_value_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="SetKernelArgMemPointerINTEL(IntPtr, uint, void*)"/>
            public static unsafe int SetKernelArgMemPointerINTEL<T1>(IntPtr kernel, uint arg_index, ReadOnlySpan<T1> arg_value)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* arg_value_ptr = arg_value)
                {
                    returnValue = SetKernelArgMemPointerINTEL(kernel, arg_index, arg_value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetKernelArgMemPointerINTEL(IntPtr, uint, void*)"/>
            public static unsafe int SetKernelArgMemPointerINTEL<T1>(IntPtr kernel, uint arg_index, T1[] arg_value)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* arg_value_ptr = arg_value)
                {
                    returnValue = SetKernelArgMemPointerINTEL(kernel, arg_index, arg_value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetKernelArgMemPointerINTEL(IntPtr, uint, void*)"/>
            public static unsafe int SetKernelArgMemPointerINTEL<T1>(IntPtr kernel, uint arg_index, ref readonly T1 arg_value)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* arg_value_ptr = &arg_value)
                {
                    returnValue = SetKernelArgMemPointerINTEL(kernel, arg_index, arg_value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SharedMemAllocINTEL(IntPtr, IntPtr, ulong*, nuint, uint, int*)"/>
            public static unsafe void* SharedMemAllocINTEL(IntPtr context, IntPtr device, Span<ulong> properties, nuint size, uint alignment, Span<int> errcode_ret)
            {
                void* returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = SharedMemAllocINTEL(context, device, properties_ptr, size, alignment, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="SharedMemAllocINTEL(IntPtr, IntPtr, ulong*, nuint, uint, int*)"/>
            public static unsafe void* SharedMemAllocINTEL(IntPtr context, IntPtr device, ulong[] properties, nuint size, uint alignment, int[] errcode_ret)
            {
                void* returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = SharedMemAllocINTEL(context, device, properties_ptr, size, alignment, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="SharedMemAllocINTEL(IntPtr, IntPtr, ulong*, nuint, uint, int*)"/>
            public static unsafe void* SharedMemAllocINTEL(IntPtr context, IntPtr device, ref ulong properties, nuint size, uint alignment, ref int errcode_ret)
            {
                void* returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = SharedMemAllocINTEL(context, device, properties_ptr, size, alignment, errcode_ret_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class khr
        {
            /// <inheritdoc cref="CommandBarrierWithWaitListKHR(IntPtr, IntPtr, ulong*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandBarrierWithWaitListKHR(IntPtr command_buffer, IntPtr command_queue, Span<ulong> properties, uint num_sync_points_in_wait_list, Span<uint> sync_point_wait_list, Span<uint> sync_point, Span<IntPtr> mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (ulong* properties_ptr = properties)
                            {
                                returnValue = CommandBarrierWithWaitListKHR(command_buffer, command_queue, properties_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandBarrierWithWaitListKHR(IntPtr, IntPtr, ulong*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandBarrierWithWaitListKHR(IntPtr command_buffer, IntPtr command_queue, ulong[] properties, uint num_sync_points_in_wait_list, uint[] sync_point_wait_list, uint[] sync_point, IntPtr[] mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (ulong* properties_ptr = properties)
                            {
                                returnValue = CommandBarrierWithWaitListKHR(command_buffer, command_queue, properties_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandBarrierWithWaitListKHR(IntPtr, IntPtr, ulong*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandBarrierWithWaitListKHR(IntPtr command_buffer, IntPtr command_queue, ref ulong properties, uint num_sync_points_in_wait_list, ref uint sync_point_wait_list, ref uint sync_point, ref IntPtr mutable_handle)
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (uint* sync_point_wait_list_ptr = &sync_point_wait_list)
                fixed (uint* sync_point_ptr = &sync_point)
                fixed (IntPtr* mutable_handle_ptr = &mutable_handle)
                {
                    returnValue = CommandBarrierWithWaitListKHR(command_buffer, command_queue, properties_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandCopyBufferKHR(IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandCopyBufferKHR(IntPtr command_buffer, IntPtr command_queue, Span<ulong> properties, IntPtr src_buffer, IntPtr dst_buffer, nuint src_offset, nuint dst_offset, nuint size, uint num_sync_points_in_wait_list, Span<uint> sync_point_wait_list, Span<uint> sync_point, Span<IntPtr> mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (ulong* properties_ptr = properties)
                            {
                                returnValue = CommandCopyBufferKHR(command_buffer, command_queue, properties_ptr, src_buffer, dst_buffer, src_offset, dst_offset, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandCopyBufferKHR(IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandCopyBufferKHR(IntPtr command_buffer, IntPtr command_queue, ulong[] properties, IntPtr src_buffer, IntPtr dst_buffer, nuint src_offset, nuint dst_offset, nuint size, uint num_sync_points_in_wait_list, uint[] sync_point_wait_list, uint[] sync_point, IntPtr[] mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (ulong* properties_ptr = properties)
                            {
                                returnValue = CommandCopyBufferKHR(command_buffer, command_queue, properties_ptr, src_buffer, dst_buffer, src_offset, dst_offset, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandCopyBufferKHR(IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandCopyBufferKHR(IntPtr command_buffer, IntPtr command_queue, ref ulong properties, IntPtr src_buffer, IntPtr dst_buffer, nuint src_offset, nuint dst_offset, nuint size, uint num_sync_points_in_wait_list, ref uint sync_point_wait_list, ref uint sync_point, ref IntPtr mutable_handle)
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (uint* sync_point_wait_list_ptr = &sync_point_wait_list)
                fixed (uint* sync_point_ptr = &sync_point)
                fixed (IntPtr* mutable_handle_ptr = &mutable_handle)
                {
                    returnValue = CommandCopyBufferKHR(command_buffer, command_queue, properties_ptr, src_buffer, dst_buffer, src_offset, dst_offset, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandCopyBufferRectKHR(IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandCopyBufferRectKHR(IntPtr command_buffer, IntPtr command_queue, Span<ulong> properties, IntPtr src_buffer, IntPtr dst_buffer, ReadOnlySpan<nuint> src_origin, ReadOnlySpan<nuint> dst_origin, ReadOnlySpan<nuint> region, nuint src_row_pitch, nuint src_slice_pitch, nuint dst_row_pitch, nuint dst_slice_pitch, uint num_sync_points_in_wait_list, Span<uint> sync_point_wait_list, Span<uint> sync_point, Span<IntPtr> mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (nuint* region_ptr = region)
                            {
                                fixed (nuint* dst_origin_ptr = dst_origin)
                                {
                                    fixed (nuint* src_origin_ptr = src_origin)
                                    {
                                        fixed (ulong* properties_ptr = properties)
                                        {
                                            returnValue = CommandCopyBufferRectKHR(command_buffer, command_queue, properties_ptr, src_buffer, dst_buffer, src_origin_ptr, dst_origin_ptr, region_ptr, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandCopyBufferRectKHR(IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandCopyBufferRectKHR(IntPtr command_buffer, IntPtr command_queue, ulong[] properties, IntPtr src_buffer, IntPtr dst_buffer, nuint[] src_origin, nuint[] dst_origin, nuint[] region, nuint src_row_pitch, nuint src_slice_pitch, nuint dst_row_pitch, nuint dst_slice_pitch, uint num_sync_points_in_wait_list, uint[] sync_point_wait_list, uint[] sync_point, IntPtr[] mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (nuint* region_ptr = region)
                            {
                                fixed (nuint* dst_origin_ptr = dst_origin)
                                {
                                    fixed (nuint* src_origin_ptr = src_origin)
                                    {
                                        fixed (ulong* properties_ptr = properties)
                                        {
                                            returnValue = CommandCopyBufferRectKHR(command_buffer, command_queue, properties_ptr, src_buffer, dst_buffer, src_origin_ptr, dst_origin_ptr, region_ptr, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandCopyBufferRectKHR(IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint*, nuint*, nuint*, nuint, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandCopyBufferRectKHR(IntPtr command_buffer, IntPtr command_queue, ref ulong properties, IntPtr src_buffer, IntPtr dst_buffer, ref readonly nuint src_origin, ref readonly nuint dst_origin, ref readonly nuint region, nuint src_row_pitch, nuint src_slice_pitch, nuint dst_row_pitch, nuint dst_slice_pitch, uint num_sync_points_in_wait_list, ref uint sync_point_wait_list, ref uint sync_point, ref IntPtr mutable_handle)
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (nuint* src_origin_ptr = &src_origin)
                fixed (nuint* dst_origin_ptr = &dst_origin)
                fixed (nuint* region_ptr = &region)
                fixed (uint* sync_point_wait_list_ptr = &sync_point_wait_list)
                fixed (uint* sync_point_ptr = &sync_point)
                fixed (IntPtr* mutable_handle_ptr = &mutable_handle)
                {
                    returnValue = CommandCopyBufferRectKHR(command_buffer, command_queue, properties_ptr, src_buffer, dst_buffer, src_origin_ptr, dst_origin_ptr, region_ptr, src_row_pitch, src_slice_pitch, dst_row_pitch, dst_slice_pitch, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandCopyBufferToImageKHR(IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint, nuint*, nuint*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandCopyBufferToImageKHR(IntPtr command_buffer, IntPtr command_queue, Span<ulong> properties, IntPtr src_buffer, IntPtr dst_image, nuint src_offset, ReadOnlySpan<nuint> dst_origin, ReadOnlySpan<nuint> region, uint num_sync_points_in_wait_list, Span<uint> sync_point_wait_list, Span<uint> sync_point, Span<IntPtr> mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (nuint* region_ptr = region)
                            {
                                fixed (nuint* dst_origin_ptr = dst_origin)
                                {
                                    fixed (ulong* properties_ptr = properties)
                                    {
                                        returnValue = CommandCopyBufferToImageKHR(command_buffer, command_queue, properties_ptr, src_buffer, dst_image, src_offset, dst_origin_ptr, region_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandCopyBufferToImageKHR(IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint, nuint*, nuint*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandCopyBufferToImageKHR(IntPtr command_buffer, IntPtr command_queue, ulong[] properties, IntPtr src_buffer, IntPtr dst_image, nuint src_offset, nuint[] dst_origin, nuint[] region, uint num_sync_points_in_wait_list, uint[] sync_point_wait_list, uint[] sync_point, IntPtr[] mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (nuint* region_ptr = region)
                            {
                                fixed (nuint* dst_origin_ptr = dst_origin)
                                {
                                    fixed (ulong* properties_ptr = properties)
                                    {
                                        returnValue = CommandCopyBufferToImageKHR(command_buffer, command_queue, properties_ptr, src_buffer, dst_image, src_offset, dst_origin_ptr, region_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandCopyBufferToImageKHR(IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint, nuint*, nuint*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandCopyBufferToImageKHR(IntPtr command_buffer, IntPtr command_queue, ref ulong properties, IntPtr src_buffer, IntPtr dst_image, nuint src_offset, ref readonly nuint dst_origin, ref readonly nuint region, uint num_sync_points_in_wait_list, ref uint sync_point_wait_list, ref uint sync_point, ref IntPtr mutable_handle)
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (nuint* dst_origin_ptr = &dst_origin)
                fixed (nuint* region_ptr = &region)
                fixed (uint* sync_point_wait_list_ptr = &sync_point_wait_list)
                fixed (uint* sync_point_ptr = &sync_point)
                fixed (IntPtr* mutable_handle_ptr = &mutable_handle)
                {
                    returnValue = CommandCopyBufferToImageKHR(command_buffer, command_queue, properties_ptr, src_buffer, dst_image, src_offset, dst_origin_ptr, region_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandCopyImageKHR(IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint*, nuint*, nuint*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandCopyImageKHR(IntPtr command_buffer, IntPtr command_queue, Span<ulong> properties, IntPtr src_image, IntPtr dst_image, ReadOnlySpan<nuint> src_origin, ReadOnlySpan<nuint> dst_origin, ReadOnlySpan<nuint> region, uint num_sync_points_in_wait_list, Span<uint> sync_point_wait_list, Span<uint> sync_point, Span<IntPtr> mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (nuint* region_ptr = region)
                            {
                                fixed (nuint* dst_origin_ptr = dst_origin)
                                {
                                    fixed (nuint* src_origin_ptr = src_origin)
                                    {
                                        fixed (ulong* properties_ptr = properties)
                                        {
                                            returnValue = CommandCopyImageKHR(command_buffer, command_queue, properties_ptr, src_image, dst_image, src_origin_ptr, dst_origin_ptr, region_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandCopyImageKHR(IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint*, nuint*, nuint*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandCopyImageKHR(IntPtr command_buffer, IntPtr command_queue, ulong[] properties, IntPtr src_image, IntPtr dst_image, nuint[] src_origin, nuint[] dst_origin, nuint[] region, uint num_sync_points_in_wait_list, uint[] sync_point_wait_list, uint[] sync_point, IntPtr[] mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (nuint* region_ptr = region)
                            {
                                fixed (nuint* dst_origin_ptr = dst_origin)
                                {
                                    fixed (nuint* src_origin_ptr = src_origin)
                                    {
                                        fixed (ulong* properties_ptr = properties)
                                        {
                                            returnValue = CommandCopyImageKHR(command_buffer, command_queue, properties_ptr, src_image, dst_image, src_origin_ptr, dst_origin_ptr, region_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandCopyImageKHR(IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint*, nuint*, nuint*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandCopyImageKHR(IntPtr command_buffer, IntPtr command_queue, ref ulong properties, IntPtr src_image, IntPtr dst_image, ref readonly nuint src_origin, ref readonly nuint dst_origin, ref readonly nuint region, uint num_sync_points_in_wait_list, ref uint sync_point_wait_list, ref uint sync_point, ref IntPtr mutable_handle)
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (nuint* src_origin_ptr = &src_origin)
                fixed (nuint* dst_origin_ptr = &dst_origin)
                fixed (nuint* region_ptr = &region)
                fixed (uint* sync_point_wait_list_ptr = &sync_point_wait_list)
                fixed (uint* sync_point_ptr = &sync_point)
                fixed (IntPtr* mutable_handle_ptr = &mutable_handle)
                {
                    returnValue = CommandCopyImageKHR(command_buffer, command_queue, properties_ptr, src_image, dst_image, src_origin_ptr, dst_origin_ptr, region_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandCopyImageToBufferKHR(IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint*, nuint*, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandCopyImageToBufferKHR(IntPtr command_buffer, IntPtr command_queue, Span<ulong> properties, IntPtr src_image, IntPtr dst_buffer, ReadOnlySpan<nuint> src_origin, ReadOnlySpan<nuint> region, nuint dst_offset, uint num_sync_points_in_wait_list, Span<uint> sync_point_wait_list, Span<uint> sync_point, Span<IntPtr> mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (nuint* region_ptr = region)
                            {
                                fixed (nuint* src_origin_ptr = src_origin)
                                {
                                    fixed (ulong* properties_ptr = properties)
                                    {
                                        returnValue = CommandCopyImageToBufferKHR(command_buffer, command_queue, properties_ptr, src_image, dst_buffer, src_origin_ptr, region_ptr, dst_offset, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandCopyImageToBufferKHR(IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint*, nuint*, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandCopyImageToBufferKHR(IntPtr command_buffer, IntPtr command_queue, ulong[] properties, IntPtr src_image, IntPtr dst_buffer, nuint[] src_origin, nuint[] region, nuint dst_offset, uint num_sync_points_in_wait_list, uint[] sync_point_wait_list, uint[] sync_point, IntPtr[] mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (nuint* region_ptr = region)
                            {
                                fixed (nuint* src_origin_ptr = src_origin)
                                {
                                    fixed (ulong* properties_ptr = properties)
                                    {
                                        returnValue = CommandCopyImageToBufferKHR(command_buffer, command_queue, properties_ptr, src_image, dst_buffer, src_origin_ptr, region_ptr, dst_offset, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandCopyImageToBufferKHR(IntPtr, IntPtr, ulong*, IntPtr, IntPtr, nuint*, nuint*, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandCopyImageToBufferKHR(IntPtr command_buffer, IntPtr command_queue, ref ulong properties, IntPtr src_image, IntPtr dst_buffer, ref readonly nuint src_origin, ref readonly nuint region, nuint dst_offset, uint num_sync_points_in_wait_list, ref uint sync_point_wait_list, ref uint sync_point, ref IntPtr mutable_handle)
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (nuint* src_origin_ptr = &src_origin)
                fixed (nuint* region_ptr = &region)
                fixed (uint* sync_point_wait_list_ptr = &sync_point_wait_list)
                fixed (uint* sync_point_ptr = &sync_point)
                fixed (IntPtr* mutable_handle_ptr = &mutable_handle)
                {
                    returnValue = CommandCopyImageToBufferKHR(command_buffer, command_queue, properties_ptr, src_image, dst_buffer, src_origin_ptr, region_ptr, dst_offset, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandFillBufferKHR(IntPtr, IntPtr, ulong*, IntPtr, void*, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandFillBufferKHR(IntPtr command_buffer, IntPtr command_queue, Span<ulong> properties, IntPtr buffer, IntPtr pattern, nuint pattern_size, nuint offset, nuint size, uint num_sync_points_in_wait_list, Span<uint> sync_point_wait_list, Span<uint> sync_point, Span<IntPtr> mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (ulong* properties_ptr = properties)
                            {
                                void* pattern_vptr = (void*)pattern;
                                returnValue = CommandFillBufferKHR(command_buffer, command_queue, properties_ptr, buffer, pattern_vptr, pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandFillBufferKHR(IntPtr, IntPtr, ulong*, IntPtr, void*, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandFillBufferKHR(IntPtr command_buffer, IntPtr command_queue, ulong[] properties, IntPtr buffer, IntPtr pattern, nuint pattern_size, nuint offset, nuint size, uint num_sync_points_in_wait_list, uint[] sync_point_wait_list, uint[] sync_point, IntPtr[] mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (ulong* properties_ptr = properties)
                            {
                                void* pattern_vptr = (void*)pattern;
                                returnValue = CommandFillBufferKHR(command_buffer, command_queue, properties_ptr, buffer, pattern_vptr, pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandFillBufferKHR(IntPtr, IntPtr, ulong*, IntPtr, void*, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandFillBufferKHR(IntPtr command_buffer, IntPtr command_queue, ref ulong properties, IntPtr buffer, IntPtr pattern, nuint pattern_size, nuint offset, nuint size, uint num_sync_points_in_wait_list, ref uint sync_point_wait_list, ref uint sync_point, ref IntPtr mutable_handle)
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (uint* sync_point_wait_list_ptr = &sync_point_wait_list)
                fixed (uint* sync_point_ptr = &sync_point)
                fixed (IntPtr* mutable_handle_ptr = &mutable_handle)
                {
                    void* pattern_vptr = (void*)pattern;
                    returnValue = CommandFillBufferKHR(command_buffer, command_queue, properties_ptr, buffer, pattern_vptr, pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandFillBufferKHR(IntPtr, IntPtr, ulong*, IntPtr, void*, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandFillBufferKHR<T1>(IntPtr command_buffer, IntPtr command_queue, Span<ulong> properties, IntPtr buffer, ReadOnlySpan<T1> pattern, nuint pattern_size, nuint offset, nuint size, uint num_sync_points_in_wait_list, Span<uint> sync_point_wait_list, Span<uint> sync_point, Span<IntPtr> mutable_handle)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (void* pattern_ptr = pattern)
                            {
                                fixed (ulong* properties_ptr = properties)
                                {
                                    returnValue = CommandFillBufferKHR(command_buffer, command_queue, properties_ptr, buffer, pattern_ptr, pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandFillBufferKHR(IntPtr, IntPtr, ulong*, IntPtr, void*, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandFillBufferKHR<T1>(IntPtr command_buffer, IntPtr command_queue, ulong[] properties, IntPtr buffer, T1[] pattern, nuint pattern_size, nuint offset, nuint size, uint num_sync_points_in_wait_list, uint[] sync_point_wait_list, uint[] sync_point, IntPtr[] mutable_handle)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (void* pattern_ptr = pattern)
                            {
                                fixed (ulong* properties_ptr = properties)
                                {
                                    returnValue = CommandFillBufferKHR(command_buffer, command_queue, properties_ptr, buffer, pattern_ptr, pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandFillBufferKHR(IntPtr, IntPtr, ulong*, IntPtr, void*, nuint, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandFillBufferKHR<T1>(IntPtr command_buffer, IntPtr command_queue, ref ulong properties, IntPtr buffer, ref readonly T1 pattern, nuint pattern_size, nuint offset, nuint size, uint num_sync_points_in_wait_list, ref uint sync_point_wait_list, ref uint sync_point, ref IntPtr mutable_handle)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (void* pattern_ptr = &pattern)
                fixed (uint* sync_point_wait_list_ptr = &sync_point_wait_list)
                fixed (uint* sync_point_ptr = &sync_point)
                fixed (IntPtr* mutable_handle_ptr = &mutable_handle)
                {
                    returnValue = CommandFillBufferKHR(command_buffer, command_queue, properties_ptr, buffer, pattern_ptr, pattern_size, offset, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandFillImageKHR(IntPtr, IntPtr, ulong*, IntPtr, void*, nuint*, nuint*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandFillImageKHR(IntPtr command_buffer, IntPtr command_queue, Span<ulong> properties, IntPtr image, IntPtr fill_color, ReadOnlySpan<nuint> origin, ReadOnlySpan<nuint> region, uint num_sync_points_in_wait_list, Span<uint> sync_point_wait_list, Span<uint> sync_point, Span<IntPtr> mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (nuint* region_ptr = region)
                            {
                                fixed (nuint* origin_ptr = origin)
                                {
                                    fixed (ulong* properties_ptr = properties)
                                    {
                                        void* fill_color_vptr = (void*)fill_color;
                                        returnValue = CommandFillImageKHR(command_buffer, command_queue, properties_ptr, image, fill_color_vptr, origin_ptr, region_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandFillImageKHR(IntPtr, IntPtr, ulong*, IntPtr, void*, nuint*, nuint*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandFillImageKHR(IntPtr command_buffer, IntPtr command_queue, ulong[] properties, IntPtr image, IntPtr fill_color, nuint[] origin, nuint[] region, uint num_sync_points_in_wait_list, uint[] sync_point_wait_list, uint[] sync_point, IntPtr[] mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (nuint* region_ptr = region)
                            {
                                fixed (nuint* origin_ptr = origin)
                                {
                                    fixed (ulong* properties_ptr = properties)
                                    {
                                        void* fill_color_vptr = (void*)fill_color;
                                        returnValue = CommandFillImageKHR(command_buffer, command_queue, properties_ptr, image, fill_color_vptr, origin_ptr, region_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandFillImageKHR(IntPtr, IntPtr, ulong*, IntPtr, void*, nuint*, nuint*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandFillImageKHR(IntPtr command_buffer, IntPtr command_queue, ref ulong properties, IntPtr image, IntPtr fill_color, ref readonly nuint origin, ref readonly nuint region, uint num_sync_points_in_wait_list, ref uint sync_point_wait_list, ref uint sync_point, ref IntPtr mutable_handle)
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (nuint* origin_ptr = &origin)
                fixed (nuint* region_ptr = &region)
                fixed (uint* sync_point_wait_list_ptr = &sync_point_wait_list)
                fixed (uint* sync_point_ptr = &sync_point)
                fixed (IntPtr* mutable_handle_ptr = &mutable_handle)
                {
                    void* fill_color_vptr = (void*)fill_color;
                    returnValue = CommandFillImageKHR(command_buffer, command_queue, properties_ptr, image, fill_color_vptr, origin_ptr, region_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandFillImageKHR(IntPtr, IntPtr, ulong*, IntPtr, void*, nuint*, nuint*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandFillImageKHR<T1>(IntPtr command_buffer, IntPtr command_queue, Span<ulong> properties, IntPtr image, ReadOnlySpan<T1> fill_color, ReadOnlySpan<nuint> origin, ReadOnlySpan<nuint> region, uint num_sync_points_in_wait_list, Span<uint> sync_point_wait_list, Span<uint> sync_point, Span<IntPtr> mutable_handle)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (nuint* region_ptr = region)
                            {
                                fixed (nuint* origin_ptr = origin)
                                {
                                    fixed (void* fill_color_ptr = fill_color)
                                    {
                                        fixed (ulong* properties_ptr = properties)
                                        {
                                            returnValue = CommandFillImageKHR(command_buffer, command_queue, properties_ptr, image, fill_color_ptr, origin_ptr, region_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandFillImageKHR(IntPtr, IntPtr, ulong*, IntPtr, void*, nuint*, nuint*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandFillImageKHR<T1>(IntPtr command_buffer, IntPtr command_queue, ulong[] properties, IntPtr image, T1[] fill_color, nuint[] origin, nuint[] region, uint num_sync_points_in_wait_list, uint[] sync_point_wait_list, uint[] sync_point, IntPtr[] mutable_handle)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (nuint* region_ptr = region)
                            {
                                fixed (nuint* origin_ptr = origin)
                                {
                                    fixed (void* fill_color_ptr = fill_color)
                                    {
                                        fixed (ulong* properties_ptr = properties)
                                        {
                                            returnValue = CommandFillImageKHR(command_buffer, command_queue, properties_ptr, image, fill_color_ptr, origin_ptr, region_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandFillImageKHR(IntPtr, IntPtr, ulong*, IntPtr, void*, nuint*, nuint*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandFillImageKHR<T1>(IntPtr command_buffer, IntPtr command_queue, ref ulong properties, IntPtr image, ref readonly T1 fill_color, ref readonly nuint origin, ref readonly nuint region, uint num_sync_points_in_wait_list, ref uint sync_point_wait_list, ref uint sync_point, ref IntPtr mutable_handle)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (void* fill_color_ptr = &fill_color)
                fixed (nuint* origin_ptr = &origin)
                fixed (nuint* region_ptr = &region)
                fixed (uint* sync_point_wait_list_ptr = &sync_point_wait_list)
                fixed (uint* sync_point_ptr = &sync_point)
                fixed (IntPtr* mutable_handle_ptr = &mutable_handle)
                {
                    returnValue = CommandFillImageKHR(command_buffer, command_queue, properties_ptr, image, fill_color_ptr, origin_ptr, region_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandNDRangeKernelKHR(IntPtr, IntPtr, ulong*, IntPtr, uint, nuint*, nuint*, nuint*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandNDRangeKernelKHR(IntPtr command_buffer, IntPtr command_queue, Span<ulong> properties, IntPtr kernel, uint work_dim, ReadOnlySpan<nuint> global_work_offset, ReadOnlySpan<nuint> global_work_size, ReadOnlySpan<nuint> local_work_size, uint num_sync_points_in_wait_list, Span<uint> sync_point_wait_list, Span<uint> sync_point, Span<IntPtr> mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (nuint* local_work_size_ptr = local_work_size)
                            {
                                fixed (nuint* global_work_size_ptr = global_work_size)
                                {
                                    fixed (nuint* global_work_offset_ptr = global_work_offset)
                                    {
                                        fixed (ulong* properties_ptr = properties)
                                        {
                                            returnValue = CommandNDRangeKernelKHR(command_buffer, command_queue, properties_ptr, kernel, work_dim, global_work_offset_ptr, global_work_size_ptr, local_work_size_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandNDRangeKernelKHR(IntPtr, IntPtr, ulong*, IntPtr, uint, nuint*, nuint*, nuint*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandNDRangeKernelKHR(IntPtr command_buffer, IntPtr command_queue, ulong[] properties, IntPtr kernel, uint work_dim, nuint[] global_work_offset, nuint[] global_work_size, nuint[] local_work_size, uint num_sync_points_in_wait_list, uint[] sync_point_wait_list, uint[] sync_point, IntPtr[] mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (nuint* local_work_size_ptr = local_work_size)
                            {
                                fixed (nuint* global_work_size_ptr = global_work_size)
                                {
                                    fixed (nuint* global_work_offset_ptr = global_work_offset)
                                    {
                                        fixed (ulong* properties_ptr = properties)
                                        {
                                            returnValue = CommandNDRangeKernelKHR(command_buffer, command_queue, properties_ptr, kernel, work_dim, global_work_offset_ptr, global_work_size_ptr, local_work_size_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandNDRangeKernelKHR(IntPtr, IntPtr, ulong*, IntPtr, uint, nuint*, nuint*, nuint*, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandNDRangeKernelKHR(IntPtr command_buffer, IntPtr command_queue, ref ulong properties, IntPtr kernel, uint work_dim, ref readonly nuint global_work_offset, ref readonly nuint global_work_size, ref readonly nuint local_work_size, uint num_sync_points_in_wait_list, ref uint sync_point_wait_list, ref uint sync_point, ref IntPtr mutable_handle)
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (nuint* global_work_offset_ptr = &global_work_offset)
                fixed (nuint* global_work_size_ptr = &global_work_size)
                fixed (nuint* local_work_size_ptr = &local_work_size)
                fixed (uint* sync_point_wait_list_ptr = &sync_point_wait_list)
                fixed (uint* sync_point_ptr = &sync_point)
                fixed (IntPtr* mutable_handle_ptr = &mutable_handle)
                {
                    returnValue = CommandNDRangeKernelKHR(command_buffer, command_queue, properties_ptr, kernel, work_dim, global_work_offset_ptr, global_work_size_ptr, local_work_size_ptr, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandSVMMemcpyKHR(IntPtr, IntPtr, ulong*, void*, void*, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandSVMMemcpyKHR(IntPtr command_buffer, IntPtr command_queue, Span<ulong> properties, IntPtr dst_ptr, IntPtr src_ptr, nuint size, uint num_sync_points_in_wait_list, Span<uint> sync_point_wait_list, Span<uint> sync_point, Span<IntPtr> mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (ulong* properties_ptr = properties)
                            {
                                void* dst_ptr_vptr = (void*)dst_ptr;
                                void* src_ptr_vptr = (void*)src_ptr;
                                returnValue = CommandSVMMemcpyKHR(command_buffer, command_queue, properties_ptr, dst_ptr_vptr, src_ptr_vptr, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandSVMMemcpyKHR(IntPtr, IntPtr, ulong*, void*, void*, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandSVMMemcpyKHR(IntPtr command_buffer, IntPtr command_queue, ulong[] properties, IntPtr dst_ptr, IntPtr src_ptr, nuint size, uint num_sync_points_in_wait_list, uint[] sync_point_wait_list, uint[] sync_point, IntPtr[] mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (ulong* properties_ptr = properties)
                            {
                                void* dst_ptr_vptr = (void*)dst_ptr;
                                void* src_ptr_vptr = (void*)src_ptr;
                                returnValue = CommandSVMMemcpyKHR(command_buffer, command_queue, properties_ptr, dst_ptr_vptr, src_ptr_vptr, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandSVMMemcpyKHR(IntPtr, IntPtr, ulong*, void*, void*, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandSVMMemcpyKHR(IntPtr command_buffer, IntPtr command_queue, ref ulong properties, IntPtr dst_ptr, IntPtr src_ptr, nuint size, uint num_sync_points_in_wait_list, ref uint sync_point_wait_list, ref uint sync_point, ref IntPtr mutable_handle)
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (uint* sync_point_wait_list_ptr = &sync_point_wait_list)
                fixed (uint* sync_point_ptr = &sync_point)
                fixed (IntPtr* mutable_handle_ptr = &mutable_handle)
                {
                    void* dst_ptr_vptr = (void*)dst_ptr;
                    void* src_ptr_vptr = (void*)src_ptr;
                    returnValue = CommandSVMMemcpyKHR(command_buffer, command_queue, properties_ptr, dst_ptr_vptr, src_ptr_vptr, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandSVMMemcpyKHR(IntPtr, IntPtr, ulong*, void*, void*, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandSVMMemcpyKHR<T1, T2>(IntPtr command_buffer, IntPtr command_queue, Span<ulong> properties, Span<T1> dst_ptr, ReadOnlySpan<T2> src_ptr, nuint size, uint num_sync_points_in_wait_list, Span<uint> sync_point_wait_list, Span<uint> sync_point, Span<IntPtr> mutable_handle)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (void* src_ptr_ptr = src_ptr)
                            {
                                fixed (void* dst_ptr_ptr = dst_ptr)
                                {
                                    fixed (ulong* properties_ptr = properties)
                                    {
                                        returnValue = CommandSVMMemcpyKHR(command_buffer, command_queue, properties_ptr, dst_ptr_ptr, src_ptr_ptr, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandSVMMemcpyKHR(IntPtr, IntPtr, ulong*, void*, void*, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandSVMMemcpyKHR<T1, T2>(IntPtr command_buffer, IntPtr command_queue, ulong[] properties, T1[] dst_ptr, T2[] src_ptr, nuint size, uint num_sync_points_in_wait_list, uint[] sync_point_wait_list, uint[] sync_point, IntPtr[] mutable_handle)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (void* src_ptr_ptr = src_ptr)
                            {
                                fixed (void* dst_ptr_ptr = dst_ptr)
                                {
                                    fixed (ulong* properties_ptr = properties)
                                    {
                                        returnValue = CommandSVMMemcpyKHR(command_buffer, command_queue, properties_ptr, dst_ptr_ptr, src_ptr_ptr, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandSVMMemcpyKHR(IntPtr, IntPtr, ulong*, void*, void*, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandSVMMemcpyKHR<T1, T2>(IntPtr command_buffer, IntPtr command_queue, ref ulong properties, ref T1 dst_ptr, ref readonly T2 src_ptr, nuint size, uint num_sync_points_in_wait_list, ref uint sync_point_wait_list, ref uint sync_point, ref IntPtr mutable_handle)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (void* dst_ptr_ptr = &dst_ptr)
                fixed (void* src_ptr_ptr = &src_ptr)
                fixed (uint* sync_point_wait_list_ptr = &sync_point_wait_list)
                fixed (uint* sync_point_ptr = &sync_point)
                fixed (IntPtr* mutable_handle_ptr = &mutable_handle)
                {
                    returnValue = CommandSVMMemcpyKHR(command_buffer, command_queue, properties_ptr, dst_ptr_ptr, src_ptr_ptr, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandSVMMemFillKHR(IntPtr, IntPtr, ulong*, void*, void*, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandSVMMemFillKHR(IntPtr command_buffer, IntPtr command_queue, Span<ulong> properties, IntPtr svm_ptr, IntPtr pattern, nuint pattern_size, nuint size, uint num_sync_points_in_wait_list, Span<uint> sync_point_wait_list, Span<uint> sync_point, Span<IntPtr> mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (ulong* properties_ptr = properties)
                            {
                                void* svm_ptr_vptr = (void*)svm_ptr;
                                void* pattern_vptr = (void*)pattern;
                                returnValue = CommandSVMMemFillKHR(command_buffer, command_queue, properties_ptr, svm_ptr_vptr, pattern_vptr, pattern_size, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandSVMMemFillKHR(IntPtr, IntPtr, ulong*, void*, void*, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandSVMMemFillKHR(IntPtr command_buffer, IntPtr command_queue, ulong[] properties, IntPtr svm_ptr, IntPtr pattern, nuint pattern_size, nuint size, uint num_sync_points_in_wait_list, uint[] sync_point_wait_list, uint[] sync_point, IntPtr[] mutable_handle)
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (ulong* properties_ptr = properties)
                            {
                                void* svm_ptr_vptr = (void*)svm_ptr;
                                void* pattern_vptr = (void*)pattern;
                                returnValue = CommandSVMMemFillKHR(command_buffer, command_queue, properties_ptr, svm_ptr_vptr, pattern_vptr, pattern_size, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandSVMMemFillKHR(IntPtr, IntPtr, ulong*, void*, void*, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandSVMMemFillKHR(IntPtr command_buffer, IntPtr command_queue, ref ulong properties, IntPtr svm_ptr, IntPtr pattern, nuint pattern_size, nuint size, uint num_sync_points_in_wait_list, ref uint sync_point_wait_list, ref uint sync_point, ref IntPtr mutable_handle)
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (uint* sync_point_wait_list_ptr = &sync_point_wait_list)
                fixed (uint* sync_point_ptr = &sync_point)
                fixed (IntPtr* mutable_handle_ptr = &mutable_handle)
                {
                    void* svm_ptr_vptr = (void*)svm_ptr;
                    void* pattern_vptr = (void*)pattern;
                    returnValue = CommandSVMMemFillKHR(command_buffer, command_queue, properties_ptr, svm_ptr_vptr, pattern_vptr, pattern_size, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandSVMMemFillKHR(IntPtr, IntPtr, ulong*, void*, void*, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandSVMMemFillKHR<T1, T2>(IntPtr command_buffer, IntPtr command_queue, Span<ulong> properties, Span<T1> svm_ptr, ReadOnlySpan<T2> pattern, nuint pattern_size, nuint size, uint num_sync_points_in_wait_list, Span<uint> sync_point_wait_list, Span<uint> sync_point, Span<IntPtr> mutable_handle)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (void* pattern_ptr = pattern)
                            {
                                fixed (void* svm_ptr_ptr = svm_ptr)
                                {
                                    fixed (ulong* properties_ptr = properties)
                                    {
                                        returnValue = CommandSVMMemFillKHR(command_buffer, command_queue, properties_ptr, svm_ptr_ptr, pattern_ptr, pattern_size, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandSVMMemFillKHR(IntPtr, IntPtr, ulong*, void*, void*, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandSVMMemFillKHR<T1, T2>(IntPtr command_buffer, IntPtr command_queue, ulong[] properties, T1[] svm_ptr, T2[] pattern, nuint pattern_size, nuint size, uint num_sync_points_in_wait_list, uint[] sync_point_wait_list, uint[] sync_point, IntPtr[] mutable_handle)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* mutable_handle_ptr = mutable_handle)
                {
                    fixed (uint* sync_point_ptr = sync_point)
                    {
                        fixed (uint* sync_point_wait_list_ptr = sync_point_wait_list)
                        {
                            fixed (void* pattern_ptr = pattern)
                            {
                                fixed (void* svm_ptr_ptr = svm_ptr)
                                {
                                    fixed (ulong* properties_ptr = properties)
                                    {
                                        returnValue = CommandSVMMemFillKHR(command_buffer, command_queue, properties_ptr, svm_ptr_ptr, pattern_ptr, pattern_size, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                                    }
                                }
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CommandSVMMemFillKHR(IntPtr, IntPtr, ulong*, void*, void*, nuint, nuint, uint, uint*, uint*, IntPtr*)"/>
            public static unsafe int CommandSVMMemFillKHR<T1, T2>(IntPtr command_buffer, IntPtr command_queue, ref ulong properties, ref T1 svm_ptr, ref readonly T2 pattern, nuint pattern_size, nuint size, uint num_sync_points_in_wait_list, ref uint sync_point_wait_list, ref uint sync_point, ref IntPtr mutable_handle)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (void* svm_ptr_ptr = &svm_ptr)
                fixed (void* pattern_ptr = &pattern)
                fixed (uint* sync_point_wait_list_ptr = &sync_point_wait_list)
                fixed (uint* sync_point_ptr = &sync_point)
                fixed (IntPtr* mutable_handle_ptr = &mutable_handle)
                {
                    returnValue = CommandSVMMemFillKHR(command_buffer, command_queue, properties_ptr, svm_ptr_ptr, pattern_ptr, pattern_size, size, num_sync_points_in_wait_list, sync_point_wait_list_ptr, sync_point_ptr, mutable_handle_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateCommandBufferKHR(uint, IntPtr*, ulong*, int*)"/>
            public static unsafe IntPtr CreateCommandBufferKHR(uint num_queues, Span<IntPtr> queues, Span<ulong> properties, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        fixed (IntPtr* queues_ptr = queues)
                        {
                            returnValue = CreateCommandBufferKHR(num_queues, queues_ptr, properties_ptr, errcode_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateCommandBufferKHR(uint, IntPtr*, ulong*, int*)"/>
            public static unsafe IntPtr CreateCommandBufferKHR(uint num_queues, IntPtr[] queues, ulong[] properties, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        fixed (IntPtr* queues_ptr = queues)
                        {
                            returnValue = CreateCommandBufferKHR(num_queues, queues_ptr, properties_ptr, errcode_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateCommandBufferKHR(uint, IntPtr*, ulong*, int*)"/>
            public static unsafe IntPtr CreateCommandBufferKHR(uint num_queues, ref IntPtr queues, ref ulong properties, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (IntPtr* queues_ptr = &queues)
                fixed (ulong* properties_ptr = &properties)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateCommandBufferKHR(num_queues, queues_ptr, properties_ptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateCommandQueueWithPropertiesKHR(IntPtr, IntPtr, ulong*, int*)"/>
            public static unsafe IntPtr CreateCommandQueueWithPropertiesKHR(IntPtr context, IntPtr device, Span<ulong> properties, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = CreateCommandQueueWithPropertiesKHR(context, device, properties_ptr, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateCommandQueueWithPropertiesKHR(IntPtr, IntPtr, ulong*, int*)"/>
            public static unsafe IntPtr CreateCommandQueueWithPropertiesKHR(IntPtr context, IntPtr device, ulong[] properties, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = CreateCommandQueueWithPropertiesKHR(context, device, properties_ptr, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateCommandQueueWithPropertiesKHR(IntPtr, IntPtr, ulong*, int*)"/>
            public static unsafe IntPtr CreateCommandQueueWithPropertiesKHR(IntPtr context, IntPtr device, ref ulong properties, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateCommandQueueWithPropertiesKHR(context, device, properties_ptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateEventFromEGLSyncKHR(IntPtr, void*, void*, int*)"/>
            public static unsafe IntPtr CreateEventFromEGLSyncKHR(IntPtr context, IntPtr sync, IntPtr display, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    void* sync_vptr = (void*)sync;
                    void* display_vptr = (void*)display;
                    returnValue = CreateEventFromEGLSyncKHR(context, sync_vptr, display_vptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateEventFromEGLSyncKHR(IntPtr, void*, void*, int*)"/>
            public static unsafe IntPtr CreateEventFromEGLSyncKHR(IntPtr context, IntPtr sync, IntPtr display, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    void* sync_vptr = (void*)sync;
                    void* display_vptr = (void*)display;
                    returnValue = CreateEventFromEGLSyncKHR(context, sync_vptr, display_vptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateEventFromEGLSyncKHR(IntPtr, void*, void*, int*)"/>
            public static unsafe IntPtr CreateEventFromEGLSyncKHR(IntPtr context, IntPtr sync, IntPtr display, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    void* sync_vptr = (void*)sync;
                    void* display_vptr = (void*)display;
                    returnValue = CreateEventFromEGLSyncKHR(context, sync_vptr, display_vptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateEventFromEGLSyncKHR(IntPtr, void*, void*, int*)"/>
            public static unsafe IntPtr CreateEventFromEGLSyncKHR<T1, T2>(IntPtr context, Span<T1> sync, Span<T2> display, Span<int> errcode_ret)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (void* display_ptr = display)
                    {
                        fixed (void* sync_ptr = sync)
                        {
                            returnValue = CreateEventFromEGLSyncKHR(context, sync_ptr, display_ptr, errcode_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateEventFromEGLSyncKHR(IntPtr, void*, void*, int*)"/>
            public static unsafe IntPtr CreateEventFromEGLSyncKHR<T1, T2>(IntPtr context, T1[] sync, T2[] display, int[] errcode_ret)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (void* display_ptr = display)
                    {
                        fixed (void* sync_ptr = sync)
                        {
                            returnValue = CreateEventFromEGLSyncKHR(context, sync_ptr, display_ptr, errcode_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateEventFromEGLSyncKHR(IntPtr, void*, void*, int*)"/>
            public static unsafe IntPtr CreateEventFromEGLSyncKHR<T1, T2>(IntPtr context, ref T1 sync, ref T2 display, ref int errcode_ret)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                IntPtr returnValue;
                fixed (void* sync_ptr = &sync)
                fixed (void* display_ptr = &display)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateEventFromEGLSyncKHR(context, sync_ptr, display_ptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateEventFromGLsyncKHR(IntPtr, IntPtr, int*)"/>
            public static unsafe IntPtr CreateEventFromGLsyncKHR(IntPtr context, IntPtr sync, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    returnValue = CreateEventFromGLsyncKHR(context, sync, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateEventFromGLsyncKHR(IntPtr, IntPtr, int*)"/>
            public static unsafe IntPtr CreateEventFromGLsyncKHR(IntPtr context, IntPtr sync, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    returnValue = CreateEventFromGLsyncKHR(context, sync, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateEventFromGLsyncKHR(IntPtr, IntPtr, int*)"/>
            public static unsafe IntPtr CreateEventFromGLsyncKHR(IntPtr context, IntPtr sync, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateEventFromGLsyncKHR(context, sync, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D10BufferKHR(IntPtr, MemFlags, IntPtr*, int*)"/>
            public static unsafe IntPtr CreateFromD3D10BufferKHR(IntPtr context, MemFlags flags, Span<IntPtr> resource, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* resource_ptr = resource)
                    {
                        returnValue = CreateFromD3D10BufferKHR(context, flags, resource_ptr, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D10BufferKHR(IntPtr, MemFlags, IntPtr*, int*)"/>
            public static unsafe IntPtr CreateFromD3D10BufferKHR(IntPtr context, MemFlags flags, IntPtr[] resource, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* resource_ptr = resource)
                    {
                        returnValue = CreateFromD3D10BufferKHR(context, flags, resource_ptr, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D10BufferKHR(IntPtr, MemFlags, IntPtr*, int*)"/>
            public static unsafe IntPtr CreateFromD3D10BufferKHR(IntPtr context, MemFlags flags, ref IntPtr resource, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (IntPtr* resource_ptr = &resource)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateFromD3D10BufferKHR(context, flags, resource_ptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D10Texture2DKHR(IntPtr, MemFlags, IntPtr*, uint, int*)"/>
            public static unsafe IntPtr CreateFromD3D10Texture2DKHR(IntPtr context, MemFlags flags, Span<IntPtr> resource, uint subresource, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* resource_ptr = resource)
                    {
                        returnValue = CreateFromD3D10Texture2DKHR(context, flags, resource_ptr, subresource, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D10Texture2DKHR(IntPtr, MemFlags, IntPtr*, uint, int*)"/>
            public static unsafe IntPtr CreateFromD3D10Texture2DKHR(IntPtr context, MemFlags flags, IntPtr[] resource, uint subresource, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* resource_ptr = resource)
                    {
                        returnValue = CreateFromD3D10Texture2DKHR(context, flags, resource_ptr, subresource, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D10Texture2DKHR(IntPtr, MemFlags, IntPtr*, uint, int*)"/>
            public static unsafe IntPtr CreateFromD3D10Texture2DKHR(IntPtr context, MemFlags flags, ref IntPtr resource, uint subresource, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (IntPtr* resource_ptr = &resource)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateFromD3D10Texture2DKHR(context, flags, resource_ptr, subresource, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D10Texture3DKHR(IntPtr, MemFlags, IntPtr*, uint, int*)"/>
            public static unsafe IntPtr CreateFromD3D10Texture3DKHR(IntPtr context, MemFlags flags, Span<IntPtr> resource, uint subresource, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* resource_ptr = resource)
                    {
                        returnValue = CreateFromD3D10Texture3DKHR(context, flags, resource_ptr, subresource, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D10Texture3DKHR(IntPtr, MemFlags, IntPtr*, uint, int*)"/>
            public static unsafe IntPtr CreateFromD3D10Texture3DKHR(IntPtr context, MemFlags flags, IntPtr[] resource, uint subresource, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* resource_ptr = resource)
                    {
                        returnValue = CreateFromD3D10Texture3DKHR(context, flags, resource_ptr, subresource, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D10Texture3DKHR(IntPtr, MemFlags, IntPtr*, uint, int*)"/>
            public static unsafe IntPtr CreateFromD3D10Texture3DKHR(IntPtr context, MemFlags flags, ref IntPtr resource, uint subresource, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (IntPtr* resource_ptr = &resource)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateFromD3D10Texture3DKHR(context, flags, resource_ptr, subresource, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D11BufferKHR(IntPtr, MemFlags, IntPtr*, int*)"/>
            public static unsafe IntPtr CreateFromD3D11BufferKHR(IntPtr context, MemFlags flags, Span<IntPtr> resource, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* resource_ptr = resource)
                    {
                        returnValue = CreateFromD3D11BufferKHR(context, flags, resource_ptr, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D11BufferKHR(IntPtr, MemFlags, IntPtr*, int*)"/>
            public static unsafe IntPtr CreateFromD3D11BufferKHR(IntPtr context, MemFlags flags, IntPtr[] resource, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* resource_ptr = resource)
                    {
                        returnValue = CreateFromD3D11BufferKHR(context, flags, resource_ptr, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D11BufferKHR(IntPtr, MemFlags, IntPtr*, int*)"/>
            public static unsafe IntPtr CreateFromD3D11BufferKHR(IntPtr context, MemFlags flags, ref IntPtr resource, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (IntPtr* resource_ptr = &resource)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateFromD3D11BufferKHR(context, flags, resource_ptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D11Texture2DKHR(IntPtr, MemFlags, IntPtr*, uint, int*)"/>
            public static unsafe IntPtr CreateFromD3D11Texture2DKHR(IntPtr context, MemFlags flags, Span<IntPtr> resource, uint subresource, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* resource_ptr = resource)
                    {
                        returnValue = CreateFromD3D11Texture2DKHR(context, flags, resource_ptr, subresource, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D11Texture2DKHR(IntPtr, MemFlags, IntPtr*, uint, int*)"/>
            public static unsafe IntPtr CreateFromD3D11Texture2DKHR(IntPtr context, MemFlags flags, IntPtr[] resource, uint subresource, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* resource_ptr = resource)
                    {
                        returnValue = CreateFromD3D11Texture2DKHR(context, flags, resource_ptr, subresource, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D11Texture2DKHR(IntPtr, MemFlags, IntPtr*, uint, int*)"/>
            public static unsafe IntPtr CreateFromD3D11Texture2DKHR(IntPtr context, MemFlags flags, ref IntPtr resource, uint subresource, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (IntPtr* resource_ptr = &resource)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateFromD3D11Texture2DKHR(context, flags, resource_ptr, subresource, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D11Texture3DKHR(IntPtr, MemFlags, IntPtr*, uint, int*)"/>
            public static unsafe IntPtr CreateFromD3D11Texture3DKHR(IntPtr context, MemFlags flags, Span<IntPtr> resource, uint subresource, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* resource_ptr = resource)
                    {
                        returnValue = CreateFromD3D11Texture3DKHR(context, flags, resource_ptr, subresource, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D11Texture3DKHR(IntPtr, MemFlags, IntPtr*, uint, int*)"/>
            public static unsafe IntPtr CreateFromD3D11Texture3DKHR(IntPtr context, MemFlags flags, IntPtr[] resource, uint subresource, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* resource_ptr = resource)
                    {
                        returnValue = CreateFromD3D11Texture3DKHR(context, flags, resource_ptr, subresource, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromD3D11Texture3DKHR(IntPtr, MemFlags, IntPtr*, uint, int*)"/>
            public static unsafe IntPtr CreateFromD3D11Texture3DKHR(IntPtr context, MemFlags flags, ref IntPtr resource, uint subresource, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (IntPtr* resource_ptr = &resource)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateFromD3D11Texture3DKHR(context, flags, resource_ptr, subresource, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromDX9MediaSurfaceKHR(IntPtr, MemFlags, uint, void*, uint, int*)"/>
            public static unsafe IntPtr CreateFromDX9MediaSurfaceKHR(IntPtr context, MemFlags flags, uint adapter_type, IntPtr surface_info, uint plane, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    void* surface_info_vptr = (void*)surface_info;
                    returnValue = CreateFromDX9MediaSurfaceKHR(context, flags, adapter_type, surface_info_vptr, plane, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromDX9MediaSurfaceKHR(IntPtr, MemFlags, uint, void*, uint, int*)"/>
            public static unsafe IntPtr CreateFromDX9MediaSurfaceKHR(IntPtr context, MemFlags flags, uint adapter_type, IntPtr surface_info, uint plane, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    void* surface_info_vptr = (void*)surface_info;
                    returnValue = CreateFromDX9MediaSurfaceKHR(context, flags, adapter_type, surface_info_vptr, plane, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromDX9MediaSurfaceKHR(IntPtr, MemFlags, uint, void*, uint, int*)"/>
            public static unsafe IntPtr CreateFromDX9MediaSurfaceKHR(IntPtr context, MemFlags flags, uint adapter_type, IntPtr surface_info, uint plane, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    void* surface_info_vptr = (void*)surface_info;
                    returnValue = CreateFromDX9MediaSurfaceKHR(context, flags, adapter_type, surface_info_vptr, plane, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromDX9MediaSurfaceKHR(IntPtr, MemFlags, uint, void*, uint, int*)"/>
            public static unsafe IntPtr CreateFromDX9MediaSurfaceKHR<T1>(IntPtr context, MemFlags flags, uint adapter_type, Span<T1> surface_info, uint plane, Span<int> errcode_ret)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (void* surface_info_ptr = surface_info)
                    {
                        returnValue = CreateFromDX9MediaSurfaceKHR(context, flags, adapter_type, surface_info_ptr, plane, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromDX9MediaSurfaceKHR(IntPtr, MemFlags, uint, void*, uint, int*)"/>
            public static unsafe IntPtr CreateFromDX9MediaSurfaceKHR<T1>(IntPtr context, MemFlags flags, uint adapter_type, T1[] surface_info, uint plane, int[] errcode_ret)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (void* surface_info_ptr = surface_info)
                    {
                        returnValue = CreateFromDX9MediaSurfaceKHR(context, flags, adapter_type, surface_info_ptr, plane, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromDX9MediaSurfaceKHR(IntPtr, MemFlags, uint, void*, uint, int*)"/>
            public static unsafe IntPtr CreateFromDX9MediaSurfaceKHR<T1>(IntPtr context, MemFlags flags, uint adapter_type, ref T1 surface_info, uint plane, ref int errcode_ret)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (void* surface_info_ptr = &surface_info)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateFromDX9MediaSurfaceKHR(context, flags, adapter_type, surface_info_ptr, plane, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromEGLImageKHR(IntPtr, void*, void*, MemFlags, IntPtr*, int*)"/>
            public static unsafe IntPtr CreateFromEGLImageKHR(IntPtr context, IntPtr egldisplay, IntPtr eglimage, MemFlags flags, Span<IntPtr> properties, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* properties_ptr = properties)
                    {
                        void* egldisplay_vptr = (void*)egldisplay;
                        void* eglimage_vptr = (void*)eglimage;
                        returnValue = CreateFromEGLImageKHR(context, egldisplay_vptr, eglimage_vptr, flags, properties_ptr, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromEGLImageKHR(IntPtr, void*, void*, MemFlags, IntPtr*, int*)"/>
            public static unsafe IntPtr CreateFromEGLImageKHR(IntPtr context, IntPtr egldisplay, IntPtr eglimage, MemFlags flags, IntPtr[] properties, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* properties_ptr = properties)
                    {
                        void* egldisplay_vptr = (void*)egldisplay;
                        void* eglimage_vptr = (void*)eglimage;
                        returnValue = CreateFromEGLImageKHR(context, egldisplay_vptr, eglimage_vptr, flags, properties_ptr, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromEGLImageKHR(IntPtr, void*, void*, MemFlags, IntPtr*, int*)"/>
            public static unsafe IntPtr CreateFromEGLImageKHR(IntPtr context, IntPtr egldisplay, IntPtr eglimage, MemFlags flags, ref IntPtr properties, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (IntPtr* properties_ptr = &properties)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    void* egldisplay_vptr = (void*)egldisplay;
                    void* eglimage_vptr = (void*)eglimage;
                    returnValue = CreateFromEGLImageKHR(context, egldisplay_vptr, eglimage_vptr, flags, properties_ptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromEGLImageKHR(IntPtr, void*, void*, MemFlags, IntPtr*, int*)"/>
            public static unsafe IntPtr CreateFromEGLImageKHR<T1, T2>(IntPtr context, Span<T1> egldisplay, Span<T2> eglimage, MemFlags flags, Span<IntPtr> properties, Span<int> errcode_ret)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* properties_ptr = properties)
                    {
                        fixed (void* eglimage_ptr = eglimage)
                        {
                            fixed (void* egldisplay_ptr = egldisplay)
                            {
                                returnValue = CreateFromEGLImageKHR(context, egldisplay_ptr, eglimage_ptr, flags, properties_ptr, errcode_ret_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromEGLImageKHR(IntPtr, void*, void*, MemFlags, IntPtr*, int*)"/>
            public static unsafe IntPtr CreateFromEGLImageKHR<T1, T2>(IntPtr context, T1[] egldisplay, T2[] eglimage, MemFlags flags, IntPtr[] properties, int[] errcode_ret)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* properties_ptr = properties)
                    {
                        fixed (void* eglimage_ptr = eglimage)
                        {
                            fixed (void* egldisplay_ptr = egldisplay)
                            {
                                returnValue = CreateFromEGLImageKHR(context, egldisplay_ptr, eglimage_ptr, flags, properties_ptr, errcode_ret_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromEGLImageKHR(IntPtr, void*, void*, MemFlags, IntPtr*, int*)"/>
            public static unsafe IntPtr CreateFromEGLImageKHR<T1, T2>(IntPtr context, ref T1 egldisplay, ref T2 eglimage, MemFlags flags, ref IntPtr properties, ref int errcode_ret)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                IntPtr returnValue;
                fixed (void* egldisplay_ptr = &egldisplay)
                fixed (void* eglimage_ptr = &eglimage)
                fixed (IntPtr* properties_ptr = &properties)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateFromEGLImageKHR(context, egldisplay_ptr, eglimage_ptr, flags, properties_ptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromGLBuffer(IntPtr, MemFlags, uint, int*)"/>
            public static unsafe IntPtr CreateFromGLBuffer(IntPtr context, MemFlags flags, uint bufobj, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    returnValue = CreateFromGLBuffer(context, flags, bufobj, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromGLBuffer(IntPtr, MemFlags, uint, int*)"/>
            public static unsafe IntPtr CreateFromGLBuffer(IntPtr context, MemFlags flags, uint bufobj, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    returnValue = CreateFromGLBuffer(context, flags, bufobj, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromGLBuffer(IntPtr, MemFlags, uint, int*)"/>
            public static unsafe IntPtr CreateFromGLBuffer(IntPtr context, MemFlags flags, uint bufobj, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateFromGLBuffer(context, flags, bufobj, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromGLRenderbuffer(IntPtr, MemFlags, uint, int*)"/>
            public static unsafe IntPtr CreateFromGLRenderbuffer(IntPtr context, MemFlags flags, uint renderbuffer, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    returnValue = CreateFromGLRenderbuffer(context, flags, renderbuffer, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromGLRenderbuffer(IntPtr, MemFlags, uint, int*)"/>
            public static unsafe IntPtr CreateFromGLRenderbuffer(IntPtr context, MemFlags flags, uint renderbuffer, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    returnValue = CreateFromGLRenderbuffer(context, flags, renderbuffer, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromGLRenderbuffer(IntPtr, MemFlags, uint, int*)"/>
            public static unsafe IntPtr CreateFromGLRenderbuffer(IntPtr context, MemFlags flags, uint renderbuffer, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateFromGLRenderbuffer(context, flags, renderbuffer, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromGLTexture(IntPtr, MemFlags, uint, int, uint, int*)"/>
            public static unsafe IntPtr CreateFromGLTexture(IntPtr context, MemFlags flags, uint target, int miplevel, uint texture, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    returnValue = CreateFromGLTexture(context, flags, target, miplevel, texture, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromGLTexture(IntPtr, MemFlags, uint, int, uint, int*)"/>
            public static unsafe IntPtr CreateFromGLTexture(IntPtr context, MemFlags flags, uint target, int miplevel, uint texture, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    returnValue = CreateFromGLTexture(context, flags, target, miplevel, texture, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromGLTexture(IntPtr, MemFlags, uint, int, uint, int*)"/>
            public static unsafe IntPtr CreateFromGLTexture(IntPtr context, MemFlags flags, uint target, int miplevel, uint texture, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateFromGLTexture(context, flags, target, miplevel, texture, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromGLTexture2D(IntPtr, MemFlags, uint, int, uint, int*)"/>
            public static unsafe IntPtr CreateFromGLTexture2D(IntPtr context, MemFlags flags, uint target, int miplevel, uint texture, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    returnValue = CreateFromGLTexture2D(context, flags, target, miplevel, texture, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromGLTexture2D(IntPtr, MemFlags, uint, int, uint, int*)"/>
            public static unsafe IntPtr CreateFromGLTexture2D(IntPtr context, MemFlags flags, uint target, int miplevel, uint texture, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    returnValue = CreateFromGLTexture2D(context, flags, target, miplevel, texture, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromGLTexture2D(IntPtr, MemFlags, uint, int, uint, int*)"/>
            public static unsafe IntPtr CreateFromGLTexture2D(IntPtr context, MemFlags flags, uint target, int miplevel, uint texture, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateFromGLTexture2D(context, flags, target, miplevel, texture, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromGLTexture3D(IntPtr, MemFlags, uint, int, uint, int*)"/>
            public static unsafe IntPtr CreateFromGLTexture3D(IntPtr context, MemFlags flags, uint target, int miplevel, uint texture, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    returnValue = CreateFromGLTexture3D(context, flags, target, miplevel, texture, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromGLTexture3D(IntPtr, MemFlags, uint, int, uint, int*)"/>
            public static unsafe IntPtr CreateFromGLTexture3D(IntPtr context, MemFlags flags, uint target, int miplevel, uint texture, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    returnValue = CreateFromGLTexture3D(context, flags, target, miplevel, texture, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateFromGLTexture3D(IntPtr, MemFlags, uint, int, uint, int*)"/>
            public static unsafe IntPtr CreateFromGLTexture3D(IntPtr context, MemFlags flags, uint target, int miplevel, uint texture, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateFromGLTexture3D(context, flags, target, miplevel, texture, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateProgramWithILKHR(IntPtr, void*, nuint, int*)"/>
            public static unsafe IntPtr CreateProgramWithILKHR(IntPtr context, IntPtr il, nuint length, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    void* il_vptr = (void*)il;
                    returnValue = CreateProgramWithILKHR(context, il_vptr, length, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateProgramWithILKHR(IntPtr, void*, nuint, int*)"/>
            public static unsafe IntPtr CreateProgramWithILKHR(IntPtr context, IntPtr il, nuint length, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    void* il_vptr = (void*)il;
                    returnValue = CreateProgramWithILKHR(context, il_vptr, length, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateProgramWithILKHR(IntPtr, void*, nuint, int*)"/>
            public static unsafe IntPtr CreateProgramWithILKHR(IntPtr context, IntPtr il, nuint length, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    void* il_vptr = (void*)il;
                    returnValue = CreateProgramWithILKHR(context, il_vptr, length, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateProgramWithILKHR(IntPtr, void*, nuint, int*)"/>
            public static unsafe IntPtr CreateProgramWithILKHR<T1>(IntPtr context, ReadOnlySpan<T1> il, nuint length, Span<int> errcode_ret)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (void* il_ptr = il)
                    {
                        returnValue = CreateProgramWithILKHR(context, il_ptr, length, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateProgramWithILKHR(IntPtr, void*, nuint, int*)"/>
            public static unsafe IntPtr CreateProgramWithILKHR<T1>(IntPtr context, T1[] il, nuint length, int[] errcode_ret)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (void* il_ptr = il)
                    {
                        returnValue = CreateProgramWithILKHR(context, il_ptr, length, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateProgramWithILKHR(IntPtr, void*, nuint, int*)"/>
            public static unsafe IntPtr CreateProgramWithILKHR<T1>(IntPtr context, ref readonly T1 il, nuint length, ref int errcode_ret)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (void* il_ptr = &il)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateProgramWithILKHR(context, il_ptr, length, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateSemaphoreWithPropertiesKHR(IntPtr, ulong*, int*)"/>
            public static unsafe IntPtr CreateSemaphoreWithPropertiesKHR(IntPtr context, Span<ulong> sema_props, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* sema_props_ptr = sema_props)
                    {
                        returnValue = CreateSemaphoreWithPropertiesKHR(context, sema_props_ptr, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateSemaphoreWithPropertiesKHR(IntPtr, ulong*, int*)"/>
            public static unsafe IntPtr CreateSemaphoreWithPropertiesKHR(IntPtr context, ulong[] sema_props, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* sema_props_ptr = sema_props)
                    {
                        returnValue = CreateSemaphoreWithPropertiesKHR(context, sema_props_ptr, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateSemaphoreWithPropertiesKHR(IntPtr, ulong*, int*)"/>
            public static unsafe IntPtr CreateSemaphoreWithPropertiesKHR(IntPtr context, ref ulong sema_props, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (ulong* sema_props_ptr = &sema_props)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = CreateSemaphoreWithPropertiesKHR(context, sema_props_ptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireD3D10ObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireD3D10ObjectsKHR(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireD3D10ObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireD3D10ObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireD3D10ObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireD3D10ObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireD3D10ObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireD3D10ObjectsKHR(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueAcquireD3D10ObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireD3D11ObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireD3D11ObjectsKHR(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireD3D11ObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireD3D11ObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireD3D11ObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireD3D11ObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireD3D11ObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireD3D11ObjectsKHR(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueAcquireD3D11ObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireDX9MediaSurfacesKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireDX9MediaSurfacesKHR(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireDX9MediaSurfacesKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireDX9MediaSurfacesKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireDX9MediaSurfacesKHR(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireDX9MediaSurfacesKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireDX9MediaSurfacesKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireDX9MediaSurfacesKHR(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueAcquireDX9MediaSurfacesKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireEGLObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireEGLObjectsKHR(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireEGLObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireEGLObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireEGLObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireEGLObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireEGLObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireEGLObjectsKHR(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueAcquireEGLObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireExternalMemObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireExternalMemObjectsKHR(IntPtr command_queue, uint num_mem_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireExternalMemObjectsKHR(command_queue, num_mem_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireExternalMemObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireExternalMemObjectsKHR(IntPtr command_queue, uint num_mem_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireExternalMemObjectsKHR(command_queue, num_mem_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireExternalMemObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireExternalMemObjectsKHR(IntPtr command_queue, uint num_mem_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueAcquireExternalMemObjectsKHR(command_queue, num_mem_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireGLObjects(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireGLObjects(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireGLObjects(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireGLObjects(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireGLObjects(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueAcquireGLObjects(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueAcquireGLObjects(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueAcquireGLObjects(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueAcquireGLObjects(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueCommandBufferKHR(uint, IntPtr*, IntPtr, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueCommandBufferKHR(uint num_queues, Span<IntPtr> queues, IntPtr command_buffer, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* queues_ptr = queues)
                        {
                            returnValue = EnqueueCommandBufferKHR(num_queues, queues_ptr, command_buffer, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueCommandBufferKHR(uint, IntPtr*, IntPtr, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueCommandBufferKHR(uint num_queues, IntPtr[] queues, IntPtr command_buffer, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* queues_ptr = queues)
                        {
                            returnValue = EnqueueCommandBufferKHR(num_queues, queues_ptr, command_buffer, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueCommandBufferKHR(uint, IntPtr*, IntPtr, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueCommandBufferKHR(uint num_queues, ref IntPtr queues, IntPtr command_buffer, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* queues_ptr = &queues)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueCommandBufferKHR(num_queues, queues_ptr, command_buffer, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseD3D10ObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseD3D10ObjectsKHR(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseD3D10ObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseD3D10ObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseD3D10ObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseD3D10ObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseD3D10ObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseD3D10ObjectsKHR(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueReleaseD3D10ObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseD3D11ObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseD3D11ObjectsKHR(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseD3D11ObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseD3D11ObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseD3D11ObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseD3D11ObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseD3D11ObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseD3D11ObjectsKHR(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueReleaseD3D11ObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseDX9MediaSurfacesKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseDX9MediaSurfacesKHR(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseDX9MediaSurfacesKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseDX9MediaSurfacesKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseDX9MediaSurfacesKHR(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseDX9MediaSurfacesKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseDX9MediaSurfacesKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseDX9MediaSurfacesKHR(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueReleaseDX9MediaSurfacesKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseEGLObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseEGLObjectsKHR(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseEGLObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseEGLObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseEGLObjectsKHR(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseEGLObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseEGLObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseEGLObjectsKHR(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueReleaseEGLObjectsKHR(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseExternalMemObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseExternalMemObjectsKHR(IntPtr command_queue, uint num_mem_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseExternalMemObjectsKHR(command_queue, num_mem_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseExternalMemObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseExternalMemObjectsKHR(IntPtr command_queue, uint num_mem_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseExternalMemObjectsKHR(command_queue, num_mem_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseExternalMemObjectsKHR(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseExternalMemObjectsKHR(IntPtr command_queue, uint num_mem_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueReleaseExternalMemObjectsKHR(command_queue, num_mem_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseGLObjects(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseGLObjects(IntPtr command_queue, uint num_objects, Span<IntPtr> mem_objects, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseGLObjects(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseGLObjects(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseGLObjects(IntPtr command_queue, uint num_objects, IntPtr[] mem_objects, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (IntPtr* mem_objects_ptr = mem_objects)
                        {
                            returnValue = EnqueueReleaseGLObjects(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueReleaseGLObjects(IntPtr, uint, IntPtr*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueReleaseGLObjects(IntPtr command_queue, uint num_objects, ref IntPtr mem_objects, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* mem_objects_ptr = &mem_objects)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueReleaseGLObjects(command_queue, num_objects, mem_objects_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSignalSemaphoresKHR(IntPtr, uint, IntPtr*, ulong*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSignalSemaphoresKHR(IntPtr command_queue, uint num_sema_objects, Span<IntPtr> sema_objects, Span<ulong> sema_payload_list, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (ulong* sema_payload_list_ptr = sema_payload_list)
                        {
                            fixed (IntPtr* sema_objects_ptr = sema_objects)
                            {
                                returnValue = EnqueueSignalSemaphoresKHR(command_queue, num_sema_objects, sema_objects_ptr, sema_payload_list_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSignalSemaphoresKHR(IntPtr, uint, IntPtr*, ulong*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSignalSemaphoresKHR(IntPtr command_queue, uint num_sema_objects, IntPtr[] sema_objects, ulong[] sema_payload_list, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (ulong* sema_payload_list_ptr = sema_payload_list)
                        {
                            fixed (IntPtr* sema_objects_ptr = sema_objects)
                            {
                                returnValue = EnqueueSignalSemaphoresKHR(command_queue, num_sema_objects, sema_objects_ptr, sema_payload_list_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueSignalSemaphoresKHR(IntPtr, uint, IntPtr*, ulong*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueSignalSemaphoresKHR(IntPtr command_queue, uint num_sema_objects, ref IntPtr sema_objects, ref ulong sema_payload_list, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* sema_objects_ptr = &sema_objects)
                fixed (ulong* sema_payload_list_ptr = &sema_payload_list)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueSignalSemaphoresKHR(command_queue, num_sema_objects, sema_objects_ptr, sema_payload_list_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueWaitSemaphoresKHR(IntPtr, uint, IntPtr*, ulong*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueWaitSemaphoresKHR(IntPtr command_queue, uint num_sema_objects, Span<IntPtr> sema_objects, Span<ulong> sema_payload_list, uint num_events_in_wait_list, Span<IntPtr> event_wait_list, Span<IntPtr> @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (ulong* sema_payload_list_ptr = sema_payload_list)
                        {
                            fixed (IntPtr* sema_objects_ptr = sema_objects)
                            {
                                returnValue = EnqueueWaitSemaphoresKHR(command_queue, num_sema_objects, sema_objects_ptr, sema_payload_list_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueWaitSemaphoresKHR(IntPtr, uint, IntPtr*, ulong*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueWaitSemaphoresKHR(IntPtr command_queue, uint num_sema_objects, IntPtr[] sema_objects, ulong[] sema_payload_list, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr[] @event)
            {
                int returnValue;
                fixed (IntPtr* @event_ptr = @event)
                {
                    fixed (IntPtr* event_wait_list_ptr = event_wait_list)
                    {
                        fixed (ulong* sema_payload_list_ptr = sema_payload_list)
                        {
                            fixed (IntPtr* sema_objects_ptr = sema_objects)
                            {
                                returnValue = EnqueueWaitSemaphoresKHR(command_queue, num_sema_objects, sema_objects_ptr, sema_payload_list_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnqueueWaitSemaphoresKHR(IntPtr, uint, IntPtr*, ulong*, uint, IntPtr*, IntPtr*)"/>
            public static unsafe int EnqueueWaitSemaphoresKHR(IntPtr command_queue, uint num_sema_objects, ref IntPtr sema_objects, ref ulong sema_payload_list, uint num_events_in_wait_list, ref IntPtr event_wait_list, ref IntPtr @event)
            {
                int returnValue;
                fixed (IntPtr* sema_objects_ptr = &sema_objects)
                fixed (ulong* sema_payload_list_ptr = &sema_payload_list)
                fixed (IntPtr* event_wait_list_ptr = &event_wait_list)
                fixed (IntPtr* @event_ptr = &@event)
                {
                    returnValue = EnqueueWaitSemaphoresKHR(command_queue, num_sema_objects, sema_objects_ptr, sema_payload_list_ptr, num_events_in_wait_list, event_wait_list_ptr, @event_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetCommandBufferInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetCommandBufferInfoKHR(IntPtr command_buffer, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetCommandBufferInfoKHR(command_buffer, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetCommandBufferInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetCommandBufferInfoKHR(IntPtr command_buffer, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetCommandBufferInfoKHR(command_buffer, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetCommandBufferInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetCommandBufferInfoKHR(IntPtr command_buffer, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetCommandBufferInfoKHR(command_buffer, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetCommandBufferInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetCommandBufferInfoKHR<T1>(IntPtr command_buffer, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        returnValue = GetCommandBufferInfoKHR(command_buffer, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetCommandBufferInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetCommandBufferInfoKHR<T1>(IntPtr command_buffer, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        returnValue = GetCommandBufferInfoKHR(command_buffer, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetCommandBufferInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetCommandBufferInfoKHR<T1>(IntPtr command_buffer, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* param_value_ptr = &param_value)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    returnValue = GetCommandBufferInfoKHR(command_buffer, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromD3D10KHR(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromD3D10KHR(IntPtr platform, uint d3d_device_source, IntPtr d3d_object, uint d3d_device_set, uint num_entries, Span<IntPtr> devices, Span<uint> num_devices)
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        void* d3d_object_vptr = (void*)d3d_object;
                        returnValue = GetDeviceIDsFromD3D10KHR(platform, d3d_device_source, d3d_object_vptr, d3d_device_set, num_entries, devices_ptr, num_devices_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromD3D10KHR(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromD3D10KHR(IntPtr platform, uint d3d_device_source, IntPtr d3d_object, uint d3d_device_set, uint num_entries, IntPtr[] devices, uint[] num_devices)
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        void* d3d_object_vptr = (void*)d3d_object;
                        returnValue = GetDeviceIDsFromD3D10KHR(platform, d3d_device_source, d3d_object_vptr, d3d_device_set, num_entries, devices_ptr, num_devices_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromD3D10KHR(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromD3D10KHR(IntPtr platform, uint d3d_device_source, IntPtr d3d_object, uint d3d_device_set, uint num_entries, ref IntPtr devices, ref uint num_devices)
            {
                int returnValue;
                fixed (IntPtr* devices_ptr = &devices)
                fixed (uint* num_devices_ptr = &num_devices)
                {
                    void* d3d_object_vptr = (void*)d3d_object;
                    returnValue = GetDeviceIDsFromD3D10KHR(platform, d3d_device_source, d3d_object_vptr, d3d_device_set, num_entries, devices_ptr, num_devices_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromD3D10KHR(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromD3D10KHR<T1>(IntPtr platform, uint d3d_device_source, Span<T1> d3d_object, uint d3d_device_set, uint num_entries, Span<IntPtr> devices, Span<uint> num_devices)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        fixed (void* d3d_object_ptr = d3d_object)
                        {
                            returnValue = GetDeviceIDsFromD3D10KHR(platform, d3d_device_source, d3d_object_ptr, d3d_device_set, num_entries, devices_ptr, num_devices_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromD3D10KHR(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromD3D10KHR<T1>(IntPtr platform, uint d3d_device_source, T1[] d3d_object, uint d3d_device_set, uint num_entries, IntPtr[] devices, uint[] num_devices)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        fixed (void* d3d_object_ptr = d3d_object)
                        {
                            returnValue = GetDeviceIDsFromD3D10KHR(platform, d3d_device_source, d3d_object_ptr, d3d_device_set, num_entries, devices_ptr, num_devices_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromD3D10KHR(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromD3D10KHR<T1>(IntPtr platform, uint d3d_device_source, ref T1 d3d_object, uint d3d_device_set, uint num_entries, ref IntPtr devices, ref uint num_devices)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* d3d_object_ptr = &d3d_object)
                fixed (IntPtr* devices_ptr = &devices)
                fixed (uint* num_devices_ptr = &num_devices)
                {
                    returnValue = GetDeviceIDsFromD3D10KHR(platform, d3d_device_source, d3d_object_ptr, d3d_device_set, num_entries, devices_ptr, num_devices_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromD3D11KHR(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromD3D11KHR(IntPtr platform, uint d3d_device_source, IntPtr d3d_object, uint d3d_device_set, uint num_entries, Span<IntPtr> devices, Span<uint> num_devices)
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        void* d3d_object_vptr = (void*)d3d_object;
                        returnValue = GetDeviceIDsFromD3D11KHR(platform, d3d_device_source, d3d_object_vptr, d3d_device_set, num_entries, devices_ptr, num_devices_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromD3D11KHR(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromD3D11KHR(IntPtr platform, uint d3d_device_source, IntPtr d3d_object, uint d3d_device_set, uint num_entries, IntPtr[] devices, uint[] num_devices)
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        void* d3d_object_vptr = (void*)d3d_object;
                        returnValue = GetDeviceIDsFromD3D11KHR(platform, d3d_device_source, d3d_object_vptr, d3d_device_set, num_entries, devices_ptr, num_devices_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromD3D11KHR(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromD3D11KHR(IntPtr platform, uint d3d_device_source, IntPtr d3d_object, uint d3d_device_set, uint num_entries, ref IntPtr devices, ref uint num_devices)
            {
                int returnValue;
                fixed (IntPtr* devices_ptr = &devices)
                fixed (uint* num_devices_ptr = &num_devices)
                {
                    void* d3d_object_vptr = (void*)d3d_object;
                    returnValue = GetDeviceIDsFromD3D11KHR(platform, d3d_device_source, d3d_object_vptr, d3d_device_set, num_entries, devices_ptr, num_devices_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromD3D11KHR(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromD3D11KHR<T1>(IntPtr platform, uint d3d_device_source, Span<T1> d3d_object, uint d3d_device_set, uint num_entries, Span<IntPtr> devices, Span<uint> num_devices)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        fixed (void* d3d_object_ptr = d3d_object)
                        {
                            returnValue = GetDeviceIDsFromD3D11KHR(platform, d3d_device_source, d3d_object_ptr, d3d_device_set, num_entries, devices_ptr, num_devices_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromD3D11KHR(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromD3D11KHR<T1>(IntPtr platform, uint d3d_device_source, T1[] d3d_object, uint d3d_device_set, uint num_entries, IntPtr[] devices, uint[] num_devices)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        fixed (void* d3d_object_ptr = d3d_object)
                        {
                            returnValue = GetDeviceIDsFromD3D11KHR(platform, d3d_device_source, d3d_object_ptr, d3d_device_set, num_entries, devices_ptr, num_devices_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromD3D11KHR(IntPtr, uint, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromD3D11KHR<T1>(IntPtr platform, uint d3d_device_source, ref T1 d3d_object, uint d3d_device_set, uint num_entries, ref IntPtr devices, ref uint num_devices)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* d3d_object_ptr = &d3d_object)
                fixed (IntPtr* devices_ptr = &devices)
                fixed (uint* num_devices_ptr = &num_devices)
                {
                    returnValue = GetDeviceIDsFromD3D11KHR(platform, d3d_device_source, d3d_object_ptr, d3d_device_set, num_entries, devices_ptr, num_devices_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromDX9MediaAdapterKHR(IntPtr, uint, uint*, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromDX9MediaAdapterKHR(IntPtr platform, uint num_media_adapters, Span<uint> media_adapter_type, IntPtr media_adapters, uint media_adapter_set, uint num_entries, Span<IntPtr> devices, Span<uint> num_devices)
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        fixed (uint* media_adapter_type_ptr = media_adapter_type)
                        {
                            void* media_adapters_vptr = (void*)media_adapters;
                            returnValue = GetDeviceIDsFromDX9MediaAdapterKHR(platform, num_media_adapters, media_adapter_type_ptr, media_adapters_vptr, media_adapter_set, num_entries, devices_ptr, num_devices_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromDX9MediaAdapterKHR(IntPtr, uint, uint*, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromDX9MediaAdapterKHR(IntPtr platform, uint num_media_adapters, uint[] media_adapter_type, IntPtr media_adapters, uint media_adapter_set, uint num_entries, IntPtr[] devices, uint[] num_devices)
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        fixed (uint* media_adapter_type_ptr = media_adapter_type)
                        {
                            void* media_adapters_vptr = (void*)media_adapters;
                            returnValue = GetDeviceIDsFromDX9MediaAdapterKHR(platform, num_media_adapters, media_adapter_type_ptr, media_adapters_vptr, media_adapter_set, num_entries, devices_ptr, num_devices_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromDX9MediaAdapterKHR(IntPtr, uint, uint*, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromDX9MediaAdapterKHR(IntPtr platform, uint num_media_adapters, ref uint media_adapter_type, IntPtr media_adapters, uint media_adapter_set, uint num_entries, ref IntPtr devices, ref uint num_devices)
            {
                int returnValue;
                fixed (uint* media_adapter_type_ptr = &media_adapter_type)
                fixed (IntPtr* devices_ptr = &devices)
                fixed (uint* num_devices_ptr = &num_devices)
                {
                    void* media_adapters_vptr = (void*)media_adapters;
                    returnValue = GetDeviceIDsFromDX9MediaAdapterKHR(platform, num_media_adapters, media_adapter_type_ptr, media_adapters_vptr, media_adapter_set, num_entries, devices_ptr, num_devices_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromDX9MediaAdapterKHR(IntPtr, uint, uint*, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromDX9MediaAdapterKHR<T1>(IntPtr platform, uint num_media_adapters, Span<uint> media_adapter_type, Span<T1> media_adapters, uint media_adapter_set, uint num_entries, Span<IntPtr> devices, Span<uint> num_devices)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        fixed (void* media_adapters_ptr = media_adapters)
                        {
                            fixed (uint* media_adapter_type_ptr = media_adapter_type)
                            {
                                returnValue = GetDeviceIDsFromDX9MediaAdapterKHR(platform, num_media_adapters, media_adapter_type_ptr, media_adapters_ptr, media_adapter_set, num_entries, devices_ptr, num_devices_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromDX9MediaAdapterKHR(IntPtr, uint, uint*, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromDX9MediaAdapterKHR<T1>(IntPtr platform, uint num_media_adapters, uint[] media_adapter_type, T1[] media_adapters, uint media_adapter_set, uint num_entries, IntPtr[] devices, uint[] num_devices)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (uint* num_devices_ptr = num_devices)
                {
                    fixed (IntPtr* devices_ptr = devices)
                    {
                        fixed (void* media_adapters_ptr = media_adapters)
                        {
                            fixed (uint* media_adapter_type_ptr = media_adapter_type)
                            {
                                returnValue = GetDeviceIDsFromDX9MediaAdapterKHR(platform, num_media_adapters, media_adapter_type_ptr, media_adapters_ptr, media_adapter_set, num_entries, devices_ptr, num_devices_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceIDsFromDX9MediaAdapterKHR(IntPtr, uint, uint*, void*, uint, uint, IntPtr*, uint*)"/>
            public static unsafe int GetDeviceIDsFromDX9MediaAdapterKHR<T1>(IntPtr platform, uint num_media_adapters, ref uint media_adapter_type, ref T1 media_adapters, uint media_adapter_set, uint num_entries, ref IntPtr devices, ref uint num_devices)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (uint* media_adapter_type_ptr = &media_adapter_type)
                fixed (void* media_adapters_ptr = &media_adapters)
                fixed (IntPtr* devices_ptr = &devices)
                fixed (uint* num_devices_ptr = &num_devices)
                {
                    returnValue = GetDeviceIDsFromDX9MediaAdapterKHR(platform, num_media_adapters, media_adapter_type_ptr, media_adapters_ptr, media_adapter_set, num_entries, devices_ptr, num_devices_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGLContextInfoKHR(IntPtr*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetGLContextInfoKHR(Span<IntPtr> properties, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (IntPtr* properties_ptr = properties)
                    {
                        void* param_value_vptr = (void*)param_value;
                        returnValue = GetGLContextInfoKHR(properties_ptr, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGLContextInfoKHR(IntPtr*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetGLContextInfoKHR(IntPtr[] properties, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (IntPtr* properties_ptr = properties)
                    {
                        void* param_value_vptr = (void*)param_value;
                        returnValue = GetGLContextInfoKHR(properties_ptr, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGLContextInfoKHR(IntPtr*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetGLContextInfoKHR(ref IntPtr properties, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
            {
                int returnValue;
                fixed (IntPtr* properties_ptr = &properties)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetGLContextInfoKHR(properties_ptr, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGLContextInfoKHR(IntPtr*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetGLContextInfoKHR<T1>(Span<IntPtr> properties, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        fixed (IntPtr* properties_ptr = properties)
                        {
                            returnValue = GetGLContextInfoKHR(properties_ptr, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGLContextInfoKHR(IntPtr*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetGLContextInfoKHR<T1>(IntPtr[] properties, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        fixed (IntPtr* properties_ptr = properties)
                        {
                            returnValue = GetGLContextInfoKHR(properties_ptr, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGLContextInfoKHR(IntPtr*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetGLContextInfoKHR<T1>(ref IntPtr properties, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (IntPtr* properties_ptr = &properties)
                fixed (void* param_value_ptr = &param_value)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    returnValue = GetGLContextInfoKHR(properties_ptr, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGLObjectInfo(IntPtr, uint*, uint*)"/>
            public static unsafe int GetGLObjectInfo(IntPtr memobj, Span<uint> gl_object_type, Span<uint> gl_object_name)
            {
                int returnValue;
                fixed (uint* gl_object_name_ptr = gl_object_name)
                {
                    fixed (uint* gl_object_type_ptr = gl_object_type)
                    {
                        returnValue = GetGLObjectInfo(memobj, gl_object_type_ptr, gl_object_name_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGLObjectInfo(IntPtr, uint*, uint*)"/>
            public static unsafe int GetGLObjectInfo(IntPtr memobj, uint[] gl_object_type, uint[] gl_object_name)
            {
                int returnValue;
                fixed (uint* gl_object_name_ptr = gl_object_name)
                {
                    fixed (uint* gl_object_type_ptr = gl_object_type)
                    {
                        returnValue = GetGLObjectInfo(memobj, gl_object_type_ptr, gl_object_name_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGLObjectInfo(IntPtr, uint*, uint*)"/>
            public static unsafe int GetGLObjectInfo(IntPtr memobj, ref uint gl_object_type, ref uint gl_object_name)
            {
                int returnValue;
                fixed (uint* gl_object_type_ptr = &gl_object_type)
                fixed (uint* gl_object_name_ptr = &gl_object_name)
                {
                    returnValue = GetGLObjectInfo(memobj, gl_object_type_ptr, gl_object_name_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGLTextureInfo(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetGLTextureInfo(IntPtr memobj, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetGLTextureInfo(memobj, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGLTextureInfo(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetGLTextureInfo(IntPtr memobj, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetGLTextureInfo(memobj, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGLTextureInfo(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetGLTextureInfo(IntPtr memobj, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetGLTextureInfo(memobj, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGLTextureInfo(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetGLTextureInfo<T1>(IntPtr memobj, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        returnValue = GetGLTextureInfo(memobj, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGLTextureInfo(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetGLTextureInfo<T1>(IntPtr memobj, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        returnValue = GetGLTextureInfo(memobj, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGLTextureInfo(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetGLTextureInfo<T1>(IntPtr memobj, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* param_value_ptr = &param_value)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    returnValue = GetGLTextureInfo(memobj, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetKernelSubGroupInfoKHR(IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*)"/>
            public static unsafe int GetKernelSubGroupInfoKHR(IntPtr in_kernel, IntPtr in_device, uint param_name, nuint input_value_size, IntPtr input_value, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* input_value_vptr = (void*)input_value;
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetKernelSubGroupInfoKHR(in_kernel, in_device, param_name, input_value_size, input_value_vptr, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetKernelSubGroupInfoKHR(IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*)"/>
            public static unsafe int GetKernelSubGroupInfoKHR(IntPtr in_kernel, IntPtr in_device, uint param_name, nuint input_value_size, IntPtr input_value, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* input_value_vptr = (void*)input_value;
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetKernelSubGroupInfoKHR(in_kernel, in_device, param_name, input_value_size, input_value_vptr, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetKernelSubGroupInfoKHR(IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*)"/>
            public static unsafe int GetKernelSubGroupInfoKHR(IntPtr in_kernel, IntPtr in_device, uint param_name, nuint input_value_size, IntPtr input_value, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    void* input_value_vptr = (void*)input_value;
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetKernelSubGroupInfoKHR(in_kernel, in_device, param_name, input_value_size, input_value_vptr, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetKernelSubGroupInfoKHR(IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*)"/>
            public static unsafe int GetKernelSubGroupInfoKHR<T1, T2>(IntPtr in_kernel, IntPtr in_device, uint param_name, nuint input_value_size, ReadOnlySpan<T1> input_value, nuint param_value_size, Span<T2> param_value, Span<nuint> param_value_size_ret)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        fixed (void* input_value_ptr = input_value)
                        {
                            returnValue = GetKernelSubGroupInfoKHR(in_kernel, in_device, param_name, input_value_size, input_value_ptr, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetKernelSubGroupInfoKHR(IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*)"/>
            public static unsafe int GetKernelSubGroupInfoKHR<T1, T2>(IntPtr in_kernel, IntPtr in_device, uint param_name, nuint input_value_size, T1[] input_value, nuint param_value_size, T2[] param_value, nuint[] param_value_size_ret)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        fixed (void* input_value_ptr = input_value)
                        {
                            returnValue = GetKernelSubGroupInfoKHR(in_kernel, in_device, param_name, input_value_size, input_value_ptr, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetKernelSubGroupInfoKHR(IntPtr, IntPtr, uint, nuint, void*, nuint, void*, nuint*)"/>
            public static unsafe int GetKernelSubGroupInfoKHR<T1, T2>(IntPtr in_kernel, IntPtr in_device, uint param_name, nuint input_value_size, ref readonly T1 input_value, nuint param_value_size, ref T2 param_value, ref nuint param_value_size_ret)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (void* input_value_ptr = &input_value)
                fixed (void* param_value_ptr = &param_value)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    returnValue = GetKernelSubGroupInfoKHR(in_kernel, in_device, param_name, input_value_size, input_value_ptr, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetKernelSuggestedLocalWorkSizeKHR(IntPtr, IntPtr, uint, nuint*, nuint*, nuint*)"/>
            public static unsafe int GetKernelSuggestedLocalWorkSizeKHR(IntPtr command_queue, IntPtr kernel, uint work_dim, ReadOnlySpan<nuint> global_work_offset, ReadOnlySpan<nuint> global_work_size, Span<nuint> suggested_local_work_size)
            {
                int returnValue;
                fixed (nuint* suggested_local_work_size_ptr = suggested_local_work_size)
                {
                    fixed (nuint* global_work_size_ptr = global_work_size)
                    {
                        fixed (nuint* global_work_offset_ptr = global_work_offset)
                        {
                            returnValue = GetKernelSuggestedLocalWorkSizeKHR(command_queue, kernel, work_dim, global_work_offset_ptr, global_work_size_ptr, suggested_local_work_size_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetKernelSuggestedLocalWorkSizeKHR(IntPtr, IntPtr, uint, nuint*, nuint*, nuint*)"/>
            public static unsafe int GetKernelSuggestedLocalWorkSizeKHR(IntPtr command_queue, IntPtr kernel, uint work_dim, nuint[] global_work_offset, nuint[] global_work_size, nuint[] suggested_local_work_size)
            {
                int returnValue;
                fixed (nuint* suggested_local_work_size_ptr = suggested_local_work_size)
                {
                    fixed (nuint* global_work_size_ptr = global_work_size)
                    {
                        fixed (nuint* global_work_offset_ptr = global_work_offset)
                        {
                            returnValue = GetKernelSuggestedLocalWorkSizeKHR(command_queue, kernel, work_dim, global_work_offset_ptr, global_work_size_ptr, suggested_local_work_size_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetKernelSuggestedLocalWorkSizeKHR(IntPtr, IntPtr, uint, nuint*, nuint*, nuint*)"/>
            public static unsafe int GetKernelSuggestedLocalWorkSizeKHR(IntPtr command_queue, IntPtr kernel, uint work_dim, ref readonly nuint global_work_offset, ref readonly nuint global_work_size, ref nuint suggested_local_work_size)
            {
                int returnValue;
                fixed (nuint* global_work_offset_ptr = &global_work_offset)
                fixed (nuint* global_work_size_ptr = &global_work_size)
                fixed (nuint* suggested_local_work_size_ptr = &suggested_local_work_size)
                {
                    returnValue = GetKernelSuggestedLocalWorkSizeKHR(command_queue, kernel, work_dim, global_work_offset_ptr, global_work_size_ptr, suggested_local_work_size_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMutableCommandInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetMutableCommandInfoKHR(IntPtr command, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetMutableCommandInfoKHR(command, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMutableCommandInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetMutableCommandInfoKHR(IntPtr command, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetMutableCommandInfoKHR(command, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMutableCommandInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetMutableCommandInfoKHR(IntPtr command, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetMutableCommandInfoKHR(command, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMutableCommandInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetMutableCommandInfoKHR<T1>(IntPtr command, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        returnValue = GetMutableCommandInfoKHR(command, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMutableCommandInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetMutableCommandInfoKHR<T1>(IntPtr command, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        returnValue = GetMutableCommandInfoKHR(command, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMutableCommandInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetMutableCommandInfoKHR<T1>(IntPtr command, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* param_value_ptr = &param_value)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    returnValue = GetMutableCommandInfoKHR(command, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSemaphoreHandleForTypeKHR(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSemaphoreHandleForTypeKHR(IntPtr sema_object, IntPtr device, uint handle_type, nuint handle_size, IntPtr handle_ptr, Span<nuint> handle_size_ret)
            {
                int returnValue;
                fixed (nuint* handle_size_ret_ptr = handle_size_ret)
                {
                    void* handle_ptr_vptr = (void*)handle_ptr;
                    returnValue = GetSemaphoreHandleForTypeKHR(sema_object, device, handle_type, handle_size, handle_ptr_vptr, handle_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSemaphoreHandleForTypeKHR(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSemaphoreHandleForTypeKHR(IntPtr sema_object, IntPtr device, uint handle_type, nuint handle_size, IntPtr handle_ptr, nuint[] handle_size_ret)
            {
                int returnValue;
                fixed (nuint* handle_size_ret_ptr = handle_size_ret)
                {
                    void* handle_ptr_vptr = (void*)handle_ptr;
                    returnValue = GetSemaphoreHandleForTypeKHR(sema_object, device, handle_type, handle_size, handle_ptr_vptr, handle_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSemaphoreHandleForTypeKHR(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSemaphoreHandleForTypeKHR(IntPtr sema_object, IntPtr device, uint handle_type, nuint handle_size, IntPtr handle_ptr, ref nuint handle_size_ret)
            {
                int returnValue;
                fixed (nuint* handle_size_ret_ptr = &handle_size_ret)
                {
                    void* handle_ptr_vptr = (void*)handle_ptr;
                    returnValue = GetSemaphoreHandleForTypeKHR(sema_object, device, handle_type, handle_size, handle_ptr_vptr, handle_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSemaphoreHandleForTypeKHR(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSemaphoreHandleForTypeKHR<T1>(IntPtr sema_object, IntPtr device, uint handle_type, nuint handle_size, Span<T1> handle_ptr, Span<nuint> handle_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* handle_size_ret_ptr = handle_size_ret)
                {
                    fixed (void* handle_ptr_ptr = handle_ptr)
                    {
                        returnValue = GetSemaphoreHandleForTypeKHR(sema_object, device, handle_type, handle_size, handle_ptr_ptr, handle_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSemaphoreHandleForTypeKHR(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSemaphoreHandleForTypeKHR<T1>(IntPtr sema_object, IntPtr device, uint handle_type, nuint handle_size, T1[] handle_ptr, nuint[] handle_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* handle_size_ret_ptr = handle_size_ret)
                {
                    fixed (void* handle_ptr_ptr = handle_ptr)
                    {
                        returnValue = GetSemaphoreHandleForTypeKHR(sema_object, device, handle_type, handle_size, handle_ptr_ptr, handle_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSemaphoreHandleForTypeKHR(IntPtr, IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSemaphoreHandleForTypeKHR<T1>(IntPtr sema_object, IntPtr device, uint handle_type, nuint handle_size, ref T1 handle_ptr, ref nuint handle_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* handle_ptr_ptr = &handle_ptr)
                fixed (nuint* handle_size_ret_ptr = &handle_size_ret)
                {
                    returnValue = GetSemaphoreHandleForTypeKHR(sema_object, device, handle_type, handle_size, handle_ptr_ptr, handle_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSemaphoreInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSemaphoreInfoKHR(IntPtr sema_object, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetSemaphoreInfoKHR(sema_object, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSemaphoreInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSemaphoreInfoKHR(IntPtr sema_object, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetSemaphoreInfoKHR(sema_object, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSemaphoreInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSemaphoreInfoKHR(IntPtr sema_object, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetSemaphoreInfoKHR(sema_object, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSemaphoreInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSemaphoreInfoKHR<T1>(IntPtr sema_object, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        returnValue = GetSemaphoreInfoKHR(sema_object, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSemaphoreInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSemaphoreInfoKHR<T1>(IntPtr sema_object, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        returnValue = GetSemaphoreInfoKHR(sema_object, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSemaphoreInfoKHR(IntPtr, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSemaphoreInfoKHR<T1>(IntPtr sema_object, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* param_value_ptr = &param_value)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    returnValue = GetSemaphoreInfoKHR(sema_object, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSVMPointerInfoKHR(IntPtr, IntPtr, void*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSVMPointerInfoKHR(IntPtr context, IntPtr device, IntPtr ptr, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* ptr_vptr = (void*)ptr;
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetSVMPointerInfoKHR(context, device, ptr_vptr, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSVMPointerInfoKHR(IntPtr, IntPtr, void*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSVMPointerInfoKHR(IntPtr context, IntPtr device, IntPtr ptr, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* ptr_vptr = (void*)ptr;
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetSVMPointerInfoKHR(context, device, ptr_vptr, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSVMPointerInfoKHR(IntPtr, IntPtr, void*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSVMPointerInfoKHR(IntPtr context, IntPtr device, IntPtr ptr, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    void* ptr_vptr = (void*)ptr;
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetSVMPointerInfoKHR(context, device, ptr_vptr, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSVMPointerInfoKHR(IntPtr, IntPtr, void*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSVMPointerInfoKHR<T1, T2>(IntPtr context, IntPtr device, ReadOnlySpan<T1> ptr, uint param_name, nuint param_value_size, Span<T2> param_value, Span<nuint> param_value_size_ret)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        fixed (void* ptr_ptr = ptr)
                        {
                            returnValue = GetSVMPointerInfoKHR(context, device, ptr_ptr, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSVMPointerInfoKHR(IntPtr, IntPtr, void*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSVMPointerInfoKHR<T1, T2>(IntPtr context, IntPtr device, T1[] ptr, uint param_name, nuint param_value_size, T2[] param_value, nuint[] param_value_size_ret)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        fixed (void* ptr_ptr = ptr)
                        {
                            returnValue = GetSVMPointerInfoKHR(context, device, ptr_ptr, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSVMPointerInfoKHR(IntPtr, IntPtr, void*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetSVMPointerInfoKHR<T1, T2>(IntPtr context, IntPtr device, ref readonly T1 ptr, uint param_name, nuint param_value_size, ref T2 param_value, ref nuint param_value_size_ret)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (void* ptr_ptr = &ptr)
                fixed (void* param_value_ptr = &param_value)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    returnValue = GetSVMPointerInfoKHR(context, device, ptr_ptr, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSVMSuggestedTypeIndexKHR(IntPtr, SvmCapabilitiesKhr, SvmCapabilitiesKhr, ulong*, nuint, uint*)"/>
            public static unsafe int GetSVMSuggestedTypeIndexKHR(IntPtr context, SvmCapabilitiesKhr required_capabilities, SvmCapabilitiesKhr desired_capabilities, Span<ulong> properties, nuint size, Span<uint> suggested_svm_type_index)
            {
                int returnValue;
                fixed (uint* suggested_svm_type_index_ptr = suggested_svm_type_index)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = GetSVMSuggestedTypeIndexKHR(context, required_capabilities, desired_capabilities, properties_ptr, size, suggested_svm_type_index_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSVMSuggestedTypeIndexKHR(IntPtr, SvmCapabilitiesKhr, SvmCapabilitiesKhr, ulong*, nuint, uint*)"/>
            public static unsafe int GetSVMSuggestedTypeIndexKHR(IntPtr context, SvmCapabilitiesKhr required_capabilities, SvmCapabilitiesKhr desired_capabilities, ulong[] properties, nuint size, uint[] suggested_svm_type_index)
            {
                int returnValue;
                fixed (uint* suggested_svm_type_index_ptr = suggested_svm_type_index)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = GetSVMSuggestedTypeIndexKHR(context, required_capabilities, desired_capabilities, properties_ptr, size, suggested_svm_type_index_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSVMSuggestedTypeIndexKHR(IntPtr, SvmCapabilitiesKhr, SvmCapabilitiesKhr, ulong*, nuint, uint*)"/>
            public static unsafe int GetSVMSuggestedTypeIndexKHR(IntPtr context, SvmCapabilitiesKhr required_capabilities, SvmCapabilitiesKhr desired_capabilities, ref ulong properties, nuint size, ref uint suggested_svm_type_index)
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (uint* suggested_svm_type_index_ptr = &suggested_svm_type_index)
                {
                    returnValue = GetSVMSuggestedTypeIndexKHR(context, required_capabilities, desired_capabilities, properties_ptr, size, suggested_svm_type_index_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="IcdGetFunctionAddressForPlatformKHR(IntPtr, byte*)"/>
            public static unsafe void* IcdGetFunctionAddressForPlatformKHR(IntPtr platform, string func_name)
            {
                void* returnValue;
                byte* func_name_ptr = (byte*)Marshal.StringToCoTaskMemUTF8(func_name);
                returnValue = IcdGetFunctionAddressForPlatformKHR(platform, func_name_ptr);
                Marshal.FreeCoTaskMem((IntPtr)func_name_ptr);
                return returnValue;
            }
            /// <inheritdoc cref="IcdGetPlatformIDsKHR(uint, IntPtr*, uint*)"/>
            public static unsafe int IcdGetPlatformIDsKHR(uint num_entries, Span<IntPtr> platforms, Span<uint> num_platforms)
            {
                int returnValue;
                fixed (uint* num_platforms_ptr = num_platforms)
                {
                    fixed (IntPtr* platforms_ptr = platforms)
                    {
                        returnValue = IcdGetPlatformIDsKHR(num_entries, platforms_ptr, num_platforms_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="IcdGetPlatformIDsKHR(uint, IntPtr*, uint*)"/>
            public static unsafe int IcdGetPlatformIDsKHR(uint num_entries, IntPtr[] platforms, uint[] num_platforms)
            {
                int returnValue;
                fixed (uint* num_platforms_ptr = num_platforms)
                {
                    fixed (IntPtr* platforms_ptr = platforms)
                    {
                        returnValue = IcdGetPlatformIDsKHR(num_entries, platforms_ptr, num_platforms_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="IcdGetPlatformIDsKHR(uint, IntPtr*, uint*)"/>
            public static unsafe int IcdGetPlatformIDsKHR(uint num_entries, ref IntPtr platforms, ref uint num_platforms)
            {
                int returnValue;
                fixed (IntPtr* platforms_ptr = &platforms)
                fixed (uint* num_platforms_ptr = &num_platforms)
                {
                    returnValue = IcdGetPlatformIDsKHR(num_entries, platforms_ptr, num_platforms_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="IcdSetPlatformDispatchDataKHR(IntPtr, void*)"/>
            public static unsafe int IcdSetPlatformDispatchDataKHR(IntPtr platform, IntPtr dispatch_data)
            {
                int returnValue;
                void* dispatch_data_vptr = (void*)dispatch_data;
                returnValue = IcdSetPlatformDispatchDataKHR(platform, dispatch_data_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="IcdSetPlatformDispatchDataKHR(IntPtr, void*)"/>
            public static unsafe int IcdSetPlatformDispatchDataKHR<T1>(IntPtr platform, Span<T1> dispatch_data)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dispatch_data_ptr = dispatch_data)
                {
                    returnValue = IcdSetPlatformDispatchDataKHR(platform, dispatch_data_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="IcdSetPlatformDispatchDataKHR(IntPtr, void*)"/>
            public static unsafe int IcdSetPlatformDispatchDataKHR<T1>(IntPtr platform, T1[] dispatch_data)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dispatch_data_ptr = dispatch_data)
                {
                    returnValue = IcdSetPlatformDispatchDataKHR(platform, dispatch_data_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="IcdSetPlatformDispatchDataKHR(IntPtr, void*)"/>
            public static unsafe int IcdSetPlatformDispatchDataKHR<T1>(IntPtr platform, ref T1 dispatch_data)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dispatch_data_ptr = &dispatch_data)
                {
                    returnValue = IcdSetPlatformDispatchDataKHR(platform, dispatch_data_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReImportSemaphoreSyncFdKHR(IntPtr, ulong*, int)"/>
            public static unsafe int ReImportSemaphoreSyncFdKHR(IntPtr sema_object, Span<ulong> reimport_props, int fd)
            {
                int returnValue;
                fixed (ulong* reimport_props_ptr = reimport_props)
                {
                    returnValue = ReImportSemaphoreSyncFdKHR(sema_object, reimport_props_ptr, fd);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReImportSemaphoreSyncFdKHR(IntPtr, ulong*, int)"/>
            public static unsafe int ReImportSemaphoreSyncFdKHR(IntPtr sema_object, ulong[] reimport_props, int fd)
            {
                int returnValue;
                fixed (ulong* reimport_props_ptr = reimport_props)
                {
                    returnValue = ReImportSemaphoreSyncFdKHR(sema_object, reimport_props_ptr, fd);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReImportSemaphoreSyncFdKHR(IntPtr, ulong*, int)"/>
            public static unsafe int ReImportSemaphoreSyncFdKHR(IntPtr sema_object, ref ulong reimport_props, int fd)
            {
                int returnValue;
                fixed (ulong* reimport_props_ptr = &reimport_props)
                {
                    returnValue = ReImportSemaphoreSyncFdKHR(sema_object, reimport_props_ptr, fd);
                }
                return returnValue;
            }
            /// <inheritdoc cref="RemapCommandBufferKHR(IntPtr, Bool, uint, IntPtr*, uint, IntPtr*, IntPtr*, int*)"/>
            public static unsafe IntPtr RemapCommandBufferKHR(IntPtr command_buffer, Bool automatic, uint num_queues, Span<IntPtr> queues, uint num_handles, Span<IntPtr> handles, Span<IntPtr> handles_ret, Span<int> errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* handles_ret_ptr = handles_ret)
                    {
                        fixed (IntPtr* handles_ptr = handles)
                        {
                            fixed (IntPtr* queues_ptr = queues)
                            {
                                returnValue = RemapCommandBufferKHR(command_buffer, automatic, num_queues, queues_ptr, num_handles, handles_ptr, handles_ret_ptr, errcode_ret_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="RemapCommandBufferKHR(IntPtr, Bool, uint, IntPtr*, uint, IntPtr*, IntPtr*, int*)"/>
            public static unsafe IntPtr RemapCommandBufferKHR(IntPtr command_buffer, Bool automatic, uint num_queues, IntPtr[] queues, uint num_handles, IntPtr[] handles, IntPtr[] handles_ret, int[] errcode_ret)
            {
                IntPtr returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (IntPtr* handles_ret_ptr = handles_ret)
                    {
                        fixed (IntPtr* handles_ptr = handles)
                        {
                            fixed (IntPtr* queues_ptr = queues)
                            {
                                returnValue = RemapCommandBufferKHR(command_buffer, automatic, num_queues, queues_ptr, num_handles, handles_ptr, handles_ret_ptr, errcode_ret_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="RemapCommandBufferKHR(IntPtr, Bool, uint, IntPtr*, uint, IntPtr*, IntPtr*, int*)"/>
            public static unsafe IntPtr RemapCommandBufferKHR(IntPtr command_buffer, Bool automatic, uint num_queues, ref IntPtr queues, uint num_handles, ref IntPtr handles, ref IntPtr handles_ret, ref int errcode_ret)
            {
                IntPtr returnValue;
                fixed (IntPtr* queues_ptr = &queues)
                fixed (IntPtr* handles_ptr = &handles)
                fixed (IntPtr* handles_ret_ptr = &handles_ret)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = RemapCommandBufferKHR(command_buffer, automatic, num_queues, queues_ptr, num_handles, handles_ptr, handles_ret_ptr, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SVMAllocWithPropertiesKHR(IntPtr, ulong*, uint, nuint, int*)"/>
            public static unsafe void* SVMAllocWithPropertiesKHR(IntPtr context, Span<ulong> properties, uint svm_type_index, nuint size, Span<int> errcode_ret)
            {
                void* returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = SVMAllocWithPropertiesKHR(context, properties_ptr, svm_type_index, size, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="SVMAllocWithPropertiesKHR(IntPtr, ulong*, uint, nuint, int*)"/>
            public static unsafe void* SVMAllocWithPropertiesKHR(IntPtr context, ulong[] properties, uint svm_type_index, nuint size, int[] errcode_ret)
            {
                void* returnValue;
                fixed (int* errcode_ret_ptr = errcode_ret)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = SVMAllocWithPropertiesKHR(context, properties_ptr, svm_type_index, size, errcode_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="SVMAllocWithPropertiesKHR(IntPtr, ulong*, uint, nuint, int*)"/>
            public static unsafe void* SVMAllocWithPropertiesKHR(IntPtr context, ref ulong properties, uint svm_type_index, nuint size, ref int errcode_ret)
            {
                void* returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (int* errcode_ret_ptr = &errcode_ret)
                {
                    returnValue = SVMAllocWithPropertiesKHR(context, properties_ptr, svm_type_index, size, errcode_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SVMFreeWithPropertiesKHR(IntPtr, ulong*, ulong, void*)"/>
            public static unsafe int SVMFreeWithPropertiesKHR(IntPtr context, Span<ulong> properties, ulong flags, IntPtr ptr)
            {
                int returnValue;
                fixed (ulong* properties_ptr = properties)
                {
                    void* ptr_vptr = (void*)ptr;
                    returnValue = SVMFreeWithPropertiesKHR(context, properties_ptr, flags, ptr_vptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SVMFreeWithPropertiesKHR(IntPtr, ulong*, ulong, void*)"/>
            public static unsafe int SVMFreeWithPropertiesKHR(IntPtr context, ulong[] properties, ulong flags, IntPtr ptr)
            {
                int returnValue;
                fixed (ulong* properties_ptr = properties)
                {
                    void* ptr_vptr = (void*)ptr;
                    returnValue = SVMFreeWithPropertiesKHR(context, properties_ptr, flags, ptr_vptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SVMFreeWithPropertiesKHR(IntPtr, ulong*, ulong, void*)"/>
            public static unsafe int SVMFreeWithPropertiesKHR(IntPtr context, ref ulong properties, ulong flags, IntPtr ptr)
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                {
                    void* ptr_vptr = (void*)ptr;
                    returnValue = SVMFreeWithPropertiesKHR(context, properties_ptr, flags, ptr_vptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SVMFreeWithPropertiesKHR(IntPtr, ulong*, ulong, void*)"/>
            public static unsafe int SVMFreeWithPropertiesKHR<T1>(IntPtr context, Span<ulong> properties, ulong flags, Span<T1> ptr)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* ptr_ptr = ptr)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = SVMFreeWithPropertiesKHR(context, properties_ptr, flags, ptr_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="SVMFreeWithPropertiesKHR(IntPtr, ulong*, ulong, void*)"/>
            public static unsafe int SVMFreeWithPropertiesKHR<T1>(IntPtr context, ulong[] properties, ulong flags, T1[] ptr)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* ptr_ptr = ptr)
                {
                    fixed (ulong* properties_ptr = properties)
                    {
                        returnValue = SVMFreeWithPropertiesKHR(context, properties_ptr, flags, ptr_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="SVMFreeWithPropertiesKHR(IntPtr, ulong*, ulong, void*)"/>
            public static unsafe int SVMFreeWithPropertiesKHR<T1>(IntPtr context, ref ulong properties, ulong flags, ref T1 ptr)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (ulong* properties_ptr = &properties)
                fixed (void* ptr_ptr = &ptr)
                {
                    returnValue = SVMFreeWithPropertiesKHR(context, properties_ptr, flags, ptr_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="UpdateMutableCommandsKHR(IntPtr, uint, CommandBufferUpdateTypeKhr*, void**)"/>
            public static unsafe int UpdateMutableCommandsKHR(IntPtr command_buffer, uint num_configs, Span<CommandBufferUpdateTypeKhr> config_types, void** configs)
            {
                int returnValue;
                fixed (CommandBufferUpdateTypeKhr* config_types_ptr = config_types)
                {
                    returnValue = UpdateMutableCommandsKHR(command_buffer, num_configs, config_types_ptr, configs);
                }
                return returnValue;
            }
            /// <inheritdoc cref="UpdateMutableCommandsKHR(IntPtr, uint, CommandBufferUpdateTypeKhr*, void**)"/>
            public static unsafe int UpdateMutableCommandsKHR(IntPtr command_buffer, uint num_configs, CommandBufferUpdateTypeKhr[] config_types, void** configs)
            {
                int returnValue;
                fixed (CommandBufferUpdateTypeKhr* config_types_ptr = config_types)
                {
                    returnValue = UpdateMutableCommandsKHR(command_buffer, num_configs, config_types_ptr, configs);
                }
                return returnValue;
            }
            /// <inheritdoc cref="UpdateMutableCommandsKHR(IntPtr, uint, CommandBufferUpdateTypeKhr*, void**)"/>
            public static unsafe int UpdateMutableCommandsKHR(IntPtr command_buffer, uint num_configs, ref CommandBufferUpdateTypeKhr config_types, void** configs)
            {
                int returnValue;
                fixed (CommandBufferUpdateTypeKhr* config_types_ptr = &config_types)
                {
                    returnValue = UpdateMutableCommandsKHR(command_buffer, num_configs, config_types_ptr, configs);
                }
                return returnValue;
            }
        }
        public static unsafe partial class loader
        {
            /// <inheritdoc cref="GetICDLoaderInfoOCLICD(IcdlInfo, nuint, void*, nuint*)"/>
            public static unsafe int GetICDLoaderInfoOCLICD(IcdlInfo param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetICDLoaderInfoOCLICD(param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetICDLoaderInfoOCLICD(IcdlInfo, nuint, void*, nuint*)"/>
            public static unsafe int GetICDLoaderInfoOCLICD(IcdlInfo param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetICDLoaderInfoOCLICD(param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetICDLoaderInfoOCLICD(IcdlInfo, nuint, void*, nuint*)"/>
            public static unsafe int GetICDLoaderInfoOCLICD(IcdlInfo param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetICDLoaderInfoOCLICD(param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetICDLoaderInfoOCLICD(IcdlInfo, nuint, void*, nuint*)"/>
            public static unsafe int GetICDLoaderInfoOCLICD<T1>(IcdlInfo param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        returnValue = GetICDLoaderInfoOCLICD(param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetICDLoaderInfoOCLICD(IcdlInfo, nuint, void*, nuint*)"/>
            public static unsafe int GetICDLoaderInfoOCLICD<T1>(IcdlInfo param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        returnValue = GetICDLoaderInfoOCLICD(param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetICDLoaderInfoOCLICD(IcdlInfo, nuint, void*, nuint*)"/>
            public static unsafe int GetICDLoaderInfoOCLICD<T1>(IcdlInfo param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* param_value_ptr = &param_value)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    returnValue = GetICDLoaderInfoOCLICD(param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetLayerInfo(uint, nuint, void*, nuint*)"/>
            public static unsafe int GetLayerInfo(uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetLayerInfo(param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetLayerInfo(uint, nuint, void*, nuint*)"/>
            public static unsafe int GetLayerInfo(uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetLayerInfo(param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetLayerInfo(uint, nuint, void*, nuint*)"/>
            public static unsafe int GetLayerInfo(uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetLayerInfo(param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetLayerInfo(uint, nuint, void*, nuint*)"/>
            public static unsafe int GetLayerInfo<T1>(uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        returnValue = GetLayerInfo(param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetLayerInfo(uint, nuint, void*, nuint*)"/>
            public static unsafe int GetLayerInfo<T1>(uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        returnValue = GetLayerInfo(param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetLayerInfo(uint, nuint, void*, nuint*)"/>
            public static unsafe int GetLayerInfo<T1>(uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* param_value_ptr = &param_value)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    returnValue = GetLayerInfo(param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="InitLayer(uint, IntPtr, uint*, IntPtr*)"/>
            public static unsafe int InitLayer(uint num_entries, IntPtr target_dispatch, Span<uint> num_entries_ret, ReadOnlySpan<IntPtr> layer_dispatch_ret)
            {
                int returnValue;
                fixed (IntPtr* layer_dispatch_ret_ptr = layer_dispatch_ret)
                {
                    fixed (uint* num_entries_ret_ptr = num_entries_ret)
                    {
                        returnValue = InitLayer(num_entries, target_dispatch, num_entries_ret_ptr, layer_dispatch_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="InitLayer(uint, IntPtr, uint*, IntPtr*)"/>
            public static unsafe int InitLayer(uint num_entries, IntPtr target_dispatch, uint[] num_entries_ret, IntPtr[] layer_dispatch_ret)
            {
                int returnValue;
                fixed (IntPtr* layer_dispatch_ret_ptr = layer_dispatch_ret)
                {
                    fixed (uint* num_entries_ret_ptr = num_entries_ret)
                    {
                        returnValue = InitLayer(num_entries, target_dispatch, num_entries_ret_ptr, layer_dispatch_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="InitLayer(uint, IntPtr, uint*, IntPtr*)"/>
            public static unsafe int InitLayer(uint num_entries, IntPtr target_dispatch, ref uint num_entries_ret, ref readonly IntPtr layer_dispatch_ret)
            {
                int returnValue;
                fixed (uint* num_entries_ret_ptr = &num_entries_ret)
                fixed (IntPtr* layer_dispatch_ret_ptr = &layer_dispatch_ret)
                {
                    returnValue = InitLayer(num_entries, target_dispatch, num_entries_ret_ptr, layer_dispatch_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="InitLayerWithProperties(uint, IntPtr, uint*, IntPtr*, ulong*)"/>
            public static unsafe int InitLayerWithProperties(uint num_entries, IntPtr target_dispatch, Span<uint> num_entries_ret, ReadOnlySpan<IntPtr> layer_dispatch_ret, Span<ulong> properties)
            {
                int returnValue;
                fixed (ulong* properties_ptr = properties)
                {
                    fixed (IntPtr* layer_dispatch_ret_ptr = layer_dispatch_ret)
                    {
                        fixed (uint* num_entries_ret_ptr = num_entries_ret)
                        {
                            returnValue = InitLayerWithProperties(num_entries, target_dispatch, num_entries_ret_ptr, layer_dispatch_ret_ptr, properties_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="InitLayerWithProperties(uint, IntPtr, uint*, IntPtr*, ulong*)"/>
            public static unsafe int InitLayerWithProperties(uint num_entries, IntPtr target_dispatch, uint[] num_entries_ret, IntPtr[] layer_dispatch_ret, ulong[] properties)
            {
                int returnValue;
                fixed (ulong* properties_ptr = properties)
                {
                    fixed (IntPtr* layer_dispatch_ret_ptr = layer_dispatch_ret)
                    {
                        fixed (uint* num_entries_ret_ptr = num_entries_ret)
                        {
                            returnValue = InitLayerWithProperties(num_entries, target_dispatch, num_entries_ret_ptr, layer_dispatch_ret_ptr, properties_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="InitLayerWithProperties(uint, IntPtr, uint*, IntPtr*, ulong*)"/>
            public static unsafe int InitLayerWithProperties(uint num_entries, IntPtr target_dispatch, ref uint num_entries_ret, ref readonly IntPtr layer_dispatch_ret, ref ulong properties)
            {
                int returnValue;
                fixed (uint* num_entries_ret_ptr = &num_entries_ret)
                fixed (IntPtr* layer_dispatch_ret_ptr = &layer_dispatch_ret)
                fixed (ulong* properties_ptr = &properties)
                {
                    returnValue = InitLayerWithProperties(num_entries, target_dispatch, num_entries_ret_ptr, layer_dispatch_ret_ptr, properties_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class pocl
        {
        }
        public static unsafe partial class qcom
        {
            /// <inheritdoc cref="GetDeviceImageInfoQCOM(IntPtr, nuint, nuint, cl_image_format*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetDeviceImageInfoQCOM(IntPtr device, nuint image_width, nuint image_height, Span<cl_image_format> image_format, uint param_name, nuint param_value_size, IntPtr param_value, Span<nuint> param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (cl_image_format* image_format_ptr = image_format)
                    {
                        void* param_value_vptr = (void*)param_value;
                        returnValue = GetDeviceImageInfoQCOM(device, image_width, image_height, image_format_ptr, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceImageInfoQCOM(IntPtr, nuint, nuint, cl_image_format*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetDeviceImageInfoQCOM(IntPtr device, nuint image_width, nuint image_height, cl_image_format[] image_format, uint param_name, nuint param_value_size, IntPtr param_value, nuint[] param_value_size_ret)
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (cl_image_format* image_format_ptr = image_format)
                    {
                        void* param_value_vptr = (void*)param_value;
                        returnValue = GetDeviceImageInfoQCOM(device, image_width, image_height, image_format_ptr, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceImageInfoQCOM(IntPtr, nuint, nuint, cl_image_format*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetDeviceImageInfoQCOM(IntPtr device, nuint image_width, nuint image_height, ref cl_image_format image_format, uint param_name, nuint param_value_size, IntPtr param_value, ref nuint param_value_size_ret)
            {
                int returnValue;
                fixed (cl_image_format* image_format_ptr = &image_format)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    void* param_value_vptr = (void*)param_value;
                    returnValue = GetDeviceImageInfoQCOM(device, image_width, image_height, image_format_ptr, param_name, param_value_size, param_value_vptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceImageInfoQCOM(IntPtr, nuint, nuint, cl_image_format*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetDeviceImageInfoQCOM<T1>(IntPtr device, nuint image_width, nuint image_height, Span<cl_image_format> image_format, uint param_name, nuint param_value_size, Span<T1> param_value, Span<nuint> param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        fixed (cl_image_format* image_format_ptr = image_format)
                        {
                            returnValue = GetDeviceImageInfoQCOM(device, image_width, image_height, image_format_ptr, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceImageInfoQCOM(IntPtr, nuint, nuint, cl_image_format*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetDeviceImageInfoQCOM<T1>(IntPtr device, nuint image_width, nuint image_height, cl_image_format[] image_format, uint param_name, nuint param_value_size, T1[] param_value, nuint[] param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (nuint* param_value_size_ret_ptr = param_value_size_ret)
                {
                    fixed (void* param_value_ptr = param_value)
                    {
                        fixed (cl_image_format* image_format_ptr = image_format)
                        {
                            returnValue = GetDeviceImageInfoQCOM(device, image_width, image_height, image_format_ptr, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDeviceImageInfoQCOM(IntPtr, nuint, nuint, cl_image_format*, uint, nuint, void*, nuint*)"/>
            public static unsafe int GetDeviceImageInfoQCOM<T1>(IntPtr device, nuint image_width, nuint image_height, ref cl_image_format image_format, uint param_name, nuint param_value_size, ref T1 param_value, ref nuint param_value_size_ret)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (cl_image_format* image_format_ptr = &image_format)
                fixed (void* param_value_ptr = &param_value)
                fixed (nuint* param_value_size_ret_ptr = &param_value_size_ret)
                {
                    returnValue = GetDeviceImageInfoQCOM(device, image_width, image_height, image_format_ptr, param_name, param_value_size, param_value_ptr, param_value_size_ret_ptr);
                }
                return returnValue;
            }
        }
    }
}

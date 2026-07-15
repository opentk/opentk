// This file is auto generated, do not edit.
using OpenTK.Mathematics;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenTK.Compute2.OpenCL
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_dx9_surface_info_khr.html" /></remarks>
    public unsafe struct cl_dx9_surface_info_khr
    {
        /// <summary></summary>
        public IntPtr* resource;
        /// <summary></summary>
        public IntPtr shared_handle;
        public cl_dx9_surface_info_khr() { }
        public cl_dx9_surface_info_khr(IntPtr* resource, IntPtr shared_handle)
        {
            this.resource = resource;
            this.shared_handle = shared_handle;
        }
    }
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_motion_estimation_desc_intel.html" /></remarks>
    public unsafe struct cl_motion_estimation_desc_intel
    {
        /// <summary></summary>
        public uint mb_block_type;
        /// <summary></summary>
        public uint subpixel_mode;
        /// <summary></summary>
        public uint sad_adjust_mode;
        /// <summary></summary>
        public uint search_path_type;
        public cl_motion_estimation_desc_intel() { }
        public cl_motion_estimation_desc_intel(uint mb_block_type, uint subpixel_mode, uint sad_adjust_mode, uint search_path_type)
        {
            this.mb_block_type = mb_block_type;
            this.subpixel_mode = subpixel_mode;
            this.sad_adjust_mode = sad_adjust_mode;
            this.search_path_type = search_path_type;
        }
    }
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_mem_ext_host_ptr.html" /></remarks>
    public unsafe struct cl_mem_ext_host_ptr
    {
        /// <summary></summary>
        public uint allocation_type;
        /// <summary></summary>
        public uint host_cache_policy;
        public cl_mem_ext_host_ptr() { }
        public cl_mem_ext_host_ptr(uint allocation_type, uint host_cache_policy)
        {
            this.allocation_type = allocation_type;
            this.host_cache_policy = host_cache_policy;
        }
    }
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_mem_ion_host_ptr.html" /></remarks>
    public unsafe struct cl_mem_ion_host_ptr
    {
        /// <summary></summary>
        public cl_mem_ext_host_ptr ext_host_ptr;
        /// <summary></summary>
        public int ion_filedesc;
        /// <summary></summary>
        public void* ion_hostptr;
        public cl_mem_ion_host_ptr() { }
        public cl_mem_ion_host_ptr(cl_mem_ext_host_ptr ext_host_ptr, int ion_filedesc, void* ion_hostptr)
        {
            this.ext_host_ptr = ext_host_ptr;
            this.ion_filedesc = ion_filedesc;
            this.ion_hostptr = ion_hostptr;
        }
    }
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_mem_android_native_buffer_host_ptr.html" /></remarks>
    public unsafe struct cl_mem_android_native_buffer_host_ptr
    {
        /// <summary></summary>
        public cl_mem_ext_host_ptr ext_host_ptr;
        /// <summary></summary>
        public void* anb_ptr;
        public cl_mem_android_native_buffer_host_ptr() { }
        public cl_mem_android_native_buffer_host_ptr(cl_mem_ext_host_ptr ext_host_ptr, void* anb_ptr)
        {
            this.ext_host_ptr = ext_host_ptr;
            this.anb_ptr = anb_ptr;
        }
    }
    /// <summary>Used by <see cref="CL.GetDeviceImageInfoQCOM"/>, <see cref="CL.CreateImage"/>, <see cref="CL.CreateImageWithProperties"/>, ...</summary>
    /// <remarks><see href="FIXME: url to struct docs cl_image_format.html" /></remarks>
    public unsafe struct cl_image_format
    {
        /// <summary></summary>
        public ChannelOrder image_channel_order;
        /// <summary></summary>
        public ChannelType image_channel_data_type;
        public cl_image_format() { }
        public cl_image_format(ChannelOrder image_channel_order, ChannelType image_channel_data_type)
        {
            this.image_channel_order = image_channel_order;
            this.image_channel_data_type = image_channel_data_type;
        }
    }
    /// <summary>Used by <see cref="CL.CreateImage"/>, <see cref="CL.CreateImageWithProperties"/>, <see cref="CL.GetImageRequirementsInfoEXT"/></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_image_desc.html" /></remarks>
    public unsafe struct cl_image_desc
    {
        /// <summary></summary>
        public MemObjectType image_type;
        /// <summary></summary>
        public nuint image_width;
        /// <summary></summary>
        public nuint image_height;
        /// <summary></summary>
        public nuint image_depth;
        /// <summary></summary>
        public nuint image_array_size;
        /// <summary></summary>
        public nuint image_row_pitch;
        /// <summary></summary>
        public nuint image_slice_pitch;
        /// <summary></summary>
        public uint num_mip_levels;
        /// <summary></summary>
        public uint num_samples;
        public cl_image_desc() { }
        public cl_image_desc(MemObjectType image_type, nuint image_width, nuint image_height, nuint image_depth, nuint image_array_size, nuint image_row_pitch, nuint image_slice_pitch, uint num_mip_levels, uint num_samples)
        {
            this.image_type = image_type;
            this.image_width = image_width;
            this.image_height = image_height;
            this.image_depth = image_depth;
            this.image_array_size = image_array_size;
            this.image_row_pitch = image_row_pitch;
            this.image_slice_pitch = image_slice_pitch;
            this.num_mip_levels = num_mip_levels;
            this.num_samples = num_samples;
        }
    }
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_buffer_region.html" /></remarks>
    public unsafe struct cl_buffer_region
    {
        /// <summary></summary>
        public nuint origin;
        /// <summary></summary>
        public nuint size;
        public cl_buffer_region() { }
        public cl_buffer_region(nuint origin, nuint size)
        {
            this.origin = origin;
            this.size = size;
        }
    }
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_name_version.html" /></remarks>
    public unsafe struct cl_name_version
    {
        /// <summary></summary>
        public uint version;
        [InlineArray(64)]
        public struct nameInlineArray1
        {
            public byte element;
        }
        /// <summary></summary>
        public nameInlineArray1 name;
        public cl_name_version() { }
    }
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_name_version_khr.html" /></remarks>
    public unsafe struct cl_name_version_khr
    {
        /// <summary></summary>
        public uint version;
        [InlineArray(64)]
        public struct nameInlineArray1
        {
            public byte element;
        }
        /// <summary></summary>
        public nameInlineArray1 name;
        public cl_name_version_khr() { }
    }
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_device_pci_bus_info_khr.html" /></remarks>
    public unsafe struct cl_device_pci_bus_info_khr
    {
        /// <summary></summary>
        public uint pci_domain;
        /// <summary></summary>
        public uint pci_bus;
        /// <summary></summary>
        public uint pci_device;
        /// <summary></summary>
        public uint pci_function;
        public cl_device_pci_bus_info_khr() { }
        public cl_device_pci_bus_info_khr(uint pci_domain, uint pci_bus, uint pci_device, uint pci_function)
        {
            this.pci_domain = pci_domain;
            this.pci_bus = pci_bus;
            this.pci_device = pci_device;
            this.pci_function = pci_function;
        }
    }
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_queue_family_properties_intel.html" /></remarks>
    public unsafe struct cl_queue_family_properties_intel
    {
        /// <summary></summary>
        public CommandQueueProperties properties;
        /// <summary></summary>
        public CommandQueueCapabilitiesIntel capabilities;
        /// <summary></summary>
        public uint count;
        [InlineArray(64)]
        public struct nameInlineArray1
        {
            public byte element;
        }
        /// <summary></summary>
        public nameInlineArray1 name;
        public cl_queue_family_properties_intel() { }
    }
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_kernel_allocation_info_intel.html" /></remarks>
    public unsafe struct cl_kernel_allocation_info_intel
    {
        /// <summary></summary>
        public void* @base;
        /// <summary></summary>
        public nuint size;
        /// <summary></summary>
        public UnifiedSharedMemoryTypeIntel type;
        /// <summary></summary>
        public int arg_index;
        public cl_kernel_allocation_info_intel() { }
        public cl_kernel_allocation_info_intel(void* @base, nuint size, UnifiedSharedMemoryTypeIntel type, int arg_index)
        {
            this.@base = @base;
            this.size = size;
            this.type = type;
            this.arg_index = arg_index;
        }
    }
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_device_integer_dot_product_acceleration_properties.html" /></remarks>
    public unsafe struct cl_device_integer_dot_product_acceleration_properties
    {
        /// <summary></summary>
        public Bool signed_accelerated;
        /// <summary></summary>
        public Bool unsigned_accelerated;
        /// <summary></summary>
        public Bool mixed_signedness_accelerated;
        /// <summary></summary>
        public Bool accumulating_saturating_signed_accelerated;
        /// <summary></summary>
        public Bool accumulating_saturating_unsigned_accelerated;
        /// <summary></summary>
        public Bool accumulating_saturating_mixed_signedness_accelerated;
        public cl_device_integer_dot_product_acceleration_properties() { }
        public cl_device_integer_dot_product_acceleration_properties(Bool signed_accelerated, Bool unsigned_accelerated, Bool mixed_signedness_accelerated, Bool accumulating_saturating_signed_accelerated, Bool accumulating_saturating_unsigned_accelerated, Bool accumulating_saturating_mixed_signedness_accelerated)
        {
            this.signed_accelerated = signed_accelerated;
            this.unsigned_accelerated = unsigned_accelerated;
            this.mixed_signedness_accelerated = mixed_signedness_accelerated;
            this.accumulating_saturating_signed_accelerated = accumulating_saturating_signed_accelerated;
            this.accumulating_saturating_unsigned_accelerated = accumulating_saturating_unsigned_accelerated;
            this.accumulating_saturating_mixed_signedness_accelerated = accumulating_saturating_mixed_signedness_accelerated;
        }
    }
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_device_integer_dot_product_acceleration_properties_khr.html" /></remarks>
    public unsafe struct cl_device_integer_dot_product_acceleration_properties_khr
    {
        /// <summary></summary>
        public Bool signed_accelerated;
        /// <summary></summary>
        public Bool unsigned_accelerated;
        /// <summary></summary>
        public Bool mixed_signedness_accelerated;
        /// <summary></summary>
        public Bool accumulating_saturating_signed_accelerated;
        /// <summary></summary>
        public Bool accumulating_saturating_unsigned_accelerated;
        /// <summary></summary>
        public Bool accumulating_saturating_mixed_signedness_accelerated;
        public cl_device_integer_dot_product_acceleration_properties_khr() { }
        public cl_device_integer_dot_product_acceleration_properties_khr(Bool signed_accelerated, Bool unsigned_accelerated, Bool mixed_signedness_accelerated, Bool accumulating_saturating_signed_accelerated, Bool accumulating_saturating_unsigned_accelerated, Bool accumulating_saturating_mixed_signedness_accelerated)
        {
            this.signed_accelerated = signed_accelerated;
            this.unsigned_accelerated = unsigned_accelerated;
            this.mixed_signedness_accelerated = mixed_signedness_accelerated;
            this.accumulating_saturating_signed_accelerated = accumulating_saturating_signed_accelerated;
            this.accumulating_saturating_unsigned_accelerated = accumulating_saturating_unsigned_accelerated;
            this.accumulating_saturating_mixed_signedness_accelerated = accumulating_saturating_mixed_signedness_accelerated;
        }
    }
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_mutable_dispatch_arg_khr.html" /></remarks>
    public unsafe struct cl_mutable_dispatch_arg_khr
    {
        /// <summary></summary>
        public uint arg_index;
        /// <summary></summary>
        public nuint arg_size;
        /// <summary></summary>
        public void* arg_value;
        public cl_mutable_dispatch_arg_khr() { }
        public cl_mutable_dispatch_arg_khr(uint arg_index, nuint arg_size, void* arg_value)
        {
            this.arg_index = arg_index;
            this.arg_size = arg_size;
            this.arg_value = arg_value;
        }
    }
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_mutable_dispatch_exec_info_khr.html" /></remarks>
    public unsafe struct cl_mutable_dispatch_exec_info_khr
    {
        /// <summary></summary>
        public uint param_name;
        /// <summary></summary>
        public nuint param_value_size;
        /// <summary></summary>
        public void* param_value;
        public cl_mutable_dispatch_exec_info_khr() { }
        public cl_mutable_dispatch_exec_info_khr(uint param_name, nuint param_value_size, void* param_value)
        {
            this.param_name = param_name;
            this.param_value_size = param_value_size;
            this.param_value = param_value;
        }
    }
    /// <summary></summary>
    /// <remarks><see href="FIXME: url to struct docs cl_mutable_dispatch_config_khr.html" /></remarks>
    public unsafe struct cl_mutable_dispatch_config_khr
    {
        /// <summary></summary>
        public IntPtr command;
        /// <summary></summary>
        public uint num_args;
        /// <summary></summary>
        public uint num_svm_args;
        /// <summary></summary>
        public uint num_exec_infos;
        /// <summary></summary>
        public uint work_dim;
        /// <summary></summary>
        public cl_mutable_dispatch_arg_khr* arg_list;
        /// <summary></summary>
        public cl_mutable_dispatch_arg_khr* arg_svm_list;
        /// <summary></summary>
        public cl_mutable_dispatch_exec_info_khr* exec_info_list;
        /// <summary></summary>
        public nuint* global_work_offset;
        /// <summary></summary>
        public nuint* global_work_size;
        /// <summary></summary>
        public nuint* local_work_size;
        public cl_mutable_dispatch_config_khr() { }
        public cl_mutable_dispatch_config_khr(IntPtr command, uint num_args, uint num_svm_args, uint num_exec_infos, uint work_dim, cl_mutable_dispatch_arg_khr* arg_list, cl_mutable_dispatch_arg_khr* arg_svm_list, cl_mutable_dispatch_exec_info_khr* exec_info_list, nuint* global_work_offset, nuint* global_work_size, nuint* local_work_size)
        {
            this.command = command;
            this.num_args = num_args;
            this.num_svm_args = num_svm_args;
            this.num_exec_infos = num_exec_infos;
            this.work_dim = work_dim;
            this.arg_list = arg_list;
            this.arg_svm_list = arg_svm_list;
            this.exec_info_list = exec_info_list;
            this.global_work_offset = global_work_offset;
            this.global_work_size = global_work_size;
            this.local_work_size = local_work_size;
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

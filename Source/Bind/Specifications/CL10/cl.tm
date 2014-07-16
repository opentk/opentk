# Opaque types
#_cl_context, IntPtr
#_cl_event, IntPtr
cl_command_queue, CommandQueue
cl_context, ComputeContext
cl_device_id, ComputeDevice
cl_event, ComputeEvent
cl_kernel, ComputeKernel
cl_mem, ComputeMemory
cl_platform_id, ComputePlatform
cl_program, ComputeProgram
cl_sampler, ComputeSampler

# Primitive types
cl_bool, bool
cl_int, int
cl_uint, uint
uchar, byte
size_t, IntPtr
intptr_t, IntPtr

# Structures
cl_context_properties, IntPtr
cl_image_format, ImageFormat
cl_image_desc, ImageDescriptor
cl_pipe_properties, IntPtr

# Enumerations
cl_device_type, DeviceTypeFlags
cl_command_queue_properties, CommandQueueFlags


#cl_addressing_mode, AddressingMode
#cl_command_queue_info, CommandQueueInfo
#cl_command_queue_properties, CommandQueuePropertiesFlags
#cl_context_info, ContextInfo
#cl_context_properties, IntPtr # ContextProperties
#cl_device_info, DeviceInfo
#cl_event_info, EventInfo
#cl_filter_mode, FilterMode
#cl_image_desc, ImageDescriptor
#cl_image_info, ImageInfo
#cl_kernel_group_info, KernelGroupInfo
#cl_kernel_info, KernelInfo
#cl_kernel_work_group_info, KernelWorkGroupInfo
#cl_map_flags, MapFlags
#cl_mem_info, MemInfo
#cl_mem_flags, MemFlags
#cl_mem_object_type, MemObjectType
#cl_platform_info, PlatformInfo
#cl_profiling_info, ProfilingInfo
#cl_program_build_info, ProgramBuildInfo
#cl_program_info, ProgramInfo
#cl_queue_properties, CommandQueuePropertiesFlags # QueuePropertiesFlags does not exist in the specs
#cl_sampler_info, SamplerInfo
#cl_work_group_info, WorkGroupInfo

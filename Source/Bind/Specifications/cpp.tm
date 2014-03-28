# Normal types.
GLsizei,            GLsizei
GLsizeiptr,         GLsizeiptr
GLintptr,           GLintptr
# GLenum,             GLenum
GLboolean,          bool        # Boolean # Int32
GLbitfield,         GLbitfield
# GLvoid*,            IntPtr
# GLvoid,             Void    #Object
GLchar,             GLchar
GLbyte,             GLbyte
GLubyte,            GLubyte
GLshort,            GLshort
GLushort,           GLushort
GLint,              GLint
GLuint,             GLuint
GLfloat,            GLfloat
GLclampf,           GLclampf
GLdouble,           GLdouble
GLclampd,           GLclampd
GLstring,           GLstring

PixelInternalFormat,    PixelInternalFormat

# ARB and NV types.
GLsizeiptrARB,      GLsizeiptrARB
GLintptrARB,        GLintptrARB
GLhandleARB,        GLhandleARB
GLhalfARB,          GLhalfARB
GLhalfNV,           GLhalfNV
GLcharARB,          GLcharARB

# 64 bit types (introduced in 2.1)
GLint64EXT,         GLint64EXT
GLuint64EXT,        GLuint64EXT
GLint64,            GLint64
GLuint64,           GLuint64

# ARB_sync (introduced in 3.2)
sync,           GLsync
GLsync,        GLsync

# OpenGL|ES types.
GLclampx, GLclampx
GLfixed, GLfixed
GLeglImageOES, GLeglImageOES

cl_addressing_mode, AddressingMode
cl_command_queue_info, CommandQueueInfo
cl_command_queue_properties, CommandQueueProperties
cl_context_info, ContextInfo
cl_context_properties, IntPtr # ContextProperties
cl_device_info, DeviceInfo
cl_device_type, DeviceType
cl_event_info, EventInfo
cl_filter_mode, FilterMode
cl_image_format, ImageFormat
cl_image_info, ImageInfo
cl_kernel_group_info, KernelGroupInfo
cl_kernel_info, KernelInfo
cl_kernel_work_group_info, KernelWorkGroupInfo
cl_map_flags, MapFlags
cl_mem_info, MemInfo
cl_mem_flags, MemFlags
cl_mem_object_type, MemObjectType
cl_platform_info, PlatformInfo
cl_profiling_info, ProfilingInfo
cl_program_build_info, ProgramBuildInfo
cl_program_info, ProgramInfo
cl_sampler_info, SamplerInfo
cl_work_group_info, WorkGroupInfo

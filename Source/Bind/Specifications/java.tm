# Normal types.
GLsizei,            int
GLsizeiptr,         com.sun.jna.ptr.IntByReference
GLintptr,           com.sun.jna.ptr.IntByReference
# GLenum,             int
GLboolean,          boolean        # bool # int
GLbitfield,         int
# GLvoid*,            com.sun.jna.ptr.IntByReference
# GLvoid,             Void    #Object
GLchar,             char
GLbyte,             byte
GLubyte,            byte
GLshort,            short
GLushort,           short
GLint,              int
GLuint,             int
GLfloat,            float
GLclampf,           float
GLdouble,           double
GLclampd,           double
GLstring,           String

PixelInternalFormat,    PixelInternalFormat

# ARB and NV types.
GLsizeiptrARB,      com.sun.jna.ptr.IntByReference
GLintptrARB,        com.sun.jna.ptr.IntByReference
GLhandleARB,        int
GLhalfARB,          Half
GLhalfNV,           Half
GLcharARB,          char

# 64 bit types (introduced in 2.1)
GLint64EXT,         long
GLuint64EXT,        long
GLint64,            long
GLuint64,           long

# ARB_sync (introduced in 3.2)
sync,           com.sun.jna.ptr.IntByReference
GLsync,        com.sun.jna.ptr.IntByReference

# Wgl types.
PROC,           com.sun.jna.ptr.IntByReference
LPCSTR,         String
COLORREF,       int
BOOL,           boolean
DWORD,          int
FLOAT,          float
HANDLE,         com.sun.jna.ptr.IntByReference
HDC,            com.sun.jna.ptr.IntByReference
HGLRC,          com.sun.jna.ptr.IntByReference
HPBUFFERARB,    com.sun.jna.ptr.IntByReference        #HPBUFFERARB
HPBUFFEREXT,    com.sun.jna.ptr.IntByReference        #HPBUFFEREXT
INT32,          int
INT64,          long
LPVOID,         void*
#String,         const char *
UINT,           int
USHORT,         short
VOID,           void
VoidPointer,    void*
float,          float
int,            int
#void,           *
GLDEBUGPROCARB, DebugProcArb
GLDEBUGPROCAMD , DebugProcAmd
GLvdpauSurfaceNV, com.sun.jna.ptr.IntByReference

# Glu types.
Float64         double
Float64Pointer  com.sun.jna.ptr.DoubleByReference
Float32         float
Float32Pointer  com.sun.jna.ptr.SingleByReference

# Glx types.
Void            void
Bool            boolean
int64_t            long
int32_t            int

Display            com.sun.jna.ptr.IntByReference
Window            com.sun.jna.ptr.IntByReference
Pixmap            com.sun.jna.ptr.IntByReference
Colormap        com.sun.jna.ptr.IntByReference

GLXWindow        com.sun.jna.ptr.IntByReference
GLXContext        com.sun.jna.ptr.IntByReference
GLXDrawable        com.sun.jna.ptr.IntByReference
GLXPixmap        com.sun.jna.ptr.IntByReference
__GLXextFuncPtr com.sun.jna.ptr.IntByReference

VLServer        com.sun.jna.ptr.IntByReference
VLPath            com.sun.jna.ptr.IntByReference
VLNode            com.sun.jna.ptr.IntByReference


# OpenGL|ES types.
GLclampx, int
GLfixed, int
GLeglImageOES, com.sun.jna.ptr.IntByReference


# OpenCL types.
_cl_context, com.sun.jna.ptr.IntByReference
_cl_event, com.sun.jna.ptr.IntByReference
cl_command_queue, com.sun.jna.ptr.IntByReference
cl_context, com.sun.jna.ptr.IntByReference
cl_device_id, com.sun.jna.ptr.IntByReference
cl_event, com.sun.jna.ptr.IntByReference
cl_kernel, com.sun.jna.ptr.IntByReference
cl_mem, com.sun.jna.ptr.IntByReference
cl_platform_id, com.sun.jna.ptr.IntByReference
cl_program, com.sun.jna.ptr.IntByReference
cl_sampler, com.sun.jna.ptr.IntByReference
size_t, com.sun.jna.NativeLong

cl_bool, boolean
cl_int, int
cl_uint, uint
uchar, byte

cl_addressing_mode, AddressingMode
cl_command_queue_info, CommandQueueInfo
cl_command_queue_properties, CommandQueueProperties
cl_context_info, ContextInfo
cl_context_properties, com.sun.jna.ptr.IntByReference # ContextProperties
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

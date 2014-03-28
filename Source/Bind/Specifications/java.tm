# Normal types.
GLsizei,            int
GLsizeiptr,         Integer
GLintptr,           Integer
# GLenum,             int
GLboolean,          boolean        # bool # int
GLbitfield,         int
# GLvoid*,            Integer
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
GLsizeiptrARB,      Integer
GLintptrARB,        Integer
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
sync,           Integer
GLsync,        Integer

# Wgl types.
PROC,           Integer
LPCSTR,         String
COLORREF,       int
BOOL,           boolean
DWORD,          int
FLOAT,          float
HANDLE,         Integer
HDC,            Integer
HGLRC,          Integer
HPBUFFERARB,    Integer        #HPBUFFERARB
HPBUFFEREXT,    Integer        #HPBUFFEREXT
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
GLvdpauSurfaceNV, Integer

# Glu types.
Float64         double
Float64Pointer  Double
Float32         float
Float32Pointer  Float

# Glx types.
Void            void
Bool            boolean
int64_t            long
int32_t            int

Display            Integer
Window            Integer
Pixmap            Integer
Colormap        Integer

GLXWindow        Integer
GLXContext        Integer
GLXDrawable        Integer
GLXPixmap        Integer
__GLXextFuncPtr Integer

VLServer        Integer
VLPath            Integer
VLNode            Integer


# OpenGL|ES types.
GLclampx, int
GLfixed, int
GLeglImageOES, Integer


# OpenCL types.
_cl_context, Integer
_cl_event, Integer
cl_command_queue, Integer
cl_context, Integer
cl_device_id, Integer
cl_event, Integer
cl_kernel, Integer
cl_mem, Integer
cl_platform_id, Integer
cl_program, Integer
cl_sampler, Integer
size_t, Integer # not exactly right, NativeLong is the correct one.

cl_bool, boolean
cl_int, int
cl_uint, uint
uchar, byte

cl_addressing_mode, AddressingMode
cl_command_queue_info, CommandQueueInfo
cl_command_queue_properties, CommandQueueProperties
cl_context_info, ContextInfo
cl_context_properties, Integer # ContextProperties
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

# OpenTK-specific
IntPtr, Pointer # com.sun.jna

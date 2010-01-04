# Normal types.
GLsizei,            Int32
GLsizeiptr,         IntPtr
GLintptr,           IntPtr
# GLenum,             Int32
GLboolean,          bool        # Boolean # Int32
GLbitfield,         UInt32
# GLvoid*,            IntPtr
# GLvoid,             Void    #Object
GLchar,             Char
GLbyte,             SByte
GLubyte,            Byte
GLshort,            Int16
GLushort,           UInt16
GLint,              Int32
GLuint,             UInt32
GLfloat,            Single
GLclampf,           Single
GLdouble,           Double
GLclampd,           Double
GLstring,           String

PixelInternalFormat,    PixelInternalFormat

# ARB and NV types.
GLsizeiptrARB,      IntPtr
GLintptrARB,        IntPtr
GLhandleARB,        UInt32
GLhalfARB,          OpenTK.Half
GLhalfNV,           OpenTK.Half
GLcharARB,          Char

# 64 bit types (introduced in 2.1)
GLint64EXT,         Int64
GLuint64EXT,        UInt64
GLint64,            Int64
GLuint64,           UInt64

# ARB_sync (introduced in 3.2)
sync,           IntPtr

# Wgl types.
PROC,           IntPtr
LPCSTR,         String
COLORREF,       Int32
BOOL,           Boolean
DWORD,          Int32
FLOAT,          Single
HANDLE,         IntPtr
HDC,            IntPtr
HGLRC,          IntPtr
HPBUFFERARB,    IntPtr        #HPBUFFERARB
HPBUFFEREXT,    IntPtr        #HPBUFFEREXT
INT32,          Int32
INT64,          Int64
LPVOID,         void*
#String,         const char *
UINT,           UInt32
USHORT,         UInt16
VOID,           void
VoidPointer,    void*
float,          float
int,            int
#void,           *

# Glu types.
Float64         double
Float64Pointer  double*
Float32         float
Float32Pointer  float*

# Glx types.
Void            void
Bool            bool
int64_t            long
int32_t            int

Display            IntPtr
Window            IntPtr
Pixmap            IntPtr
Colormap        IntPtr

GLXWindow        IntPtr
GLXContext        IntPtr
GLXDrawable        IntPtr
GLXPixmap        IntPtr
__GLXextFuncPtr IntPtr

VLServer        IntPtr
VLPath            IntPtr
VLNode            IntPtr


# OpenGL|ES types.
GLclampx, int
GLfixed, int
GLeglImageOES, IntPtr


# OpenCL types.
cl_command_queue, IntPtr
cl_context, IntPtr
cl_device_id, IntPtr
cl_event, IntPtr
cl_kernel, IntPtr
cl_mem, IntPtr
cl_platform_id, IntPtr
cl_program, IntPtr
cl_sampler, IntPtr
size_t, IntPtr

cl_bool, bool
cl_int, int
cl_uint, uint
uchar, byte

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

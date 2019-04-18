# Normal types.
GLsizei,            uint
GLsizeiptr,         UIntPtr
GLintptr,           IntPtr
GLboolean,          bool        # Boolean # Int32
GLbitfield,         uint
GLvoid,             void    #Object
GLchar,             char
GLbyte,             sbyte
GLubyte,            byte
GLshort,            short
GLushort,           ushort
GLint,              int
GLuint,             uint
GLfloat,            float
GLclampf,           float
GLdouble,           double
GLclampd,           double
GLstring,           string
String,             string

# Pointer types
GLvoid*,            void*
GLchar*,            string
GLchar**,           string[]
GLcharARB*,         string
GLfloat*,           float*
GLdouble*,          double*
GLboolean*,         bool*

# ARB and NV types.
GLsizeiptrARB,      UIntPtr
GLintptrARB,        IntPtr
GLhandleARB,        uint
GLhalfARB,          OpenToolkit.Mathematics.Half
GLhalfNV,           OpenToolkit.Mathematics.Half
GLcharARB,          char

# 64 bit types (introduced in 2.1)
GLint64EXT,         long
GLuint64EXT,        ulong
GLint64,            long
GLuint64,           ulong

# ARB_sync (introduced in 3.2)
sync,               IntPtr
GLsync,		        IntPtr

# Debug callbacks
GLDEBUGPROC,        DebugProc
GLDEBUGPROCAMD,     DebugProcAmd
GLDEBUGPROCARB,     DebugProcArb
GLDEBUGPROCKHR,     DebugProcKhr

# NV_vdpau
GLvdpauSurfaceNV,   IntPtr

# Wgl types.
PROC,           IntPtr
LPCSTR,         string
COLORREF,       int
BOOL,           bool
DWORD,          int
FLOAT,          float
HANDLE,         IntPtr
HDC,            IntPtr
HGLRC,          IntPtr
HPBUFFERARB,    IntPtr        #HPBUFFERARB
HPBUFFEREXT,    IntPtr        #HPBUFFEREXT
INT32,          int
INT64,          long
LPVOID,         void*
UINT,           uint
USHORT,         ushort
VOID,           void
VoidPointer,    void*

# Glu types.
Float64,        double
Float64Pointer, double*
Float32,        float
Float32Pointer, float*

# Glx types.
Void,           void
Bool,           bool
int64_t,        long
int32_t,        int

Display,        IntPtr
Window,         IntPtr
Pixmap,         IntPtr
Colormap,       IntPtr

GLXWindow,      IntPtr
GLXContext,     IntPtr
GLXDrawable,    IntPtr
GLXPixmap,      IntPtr
__GLXextFuncPtr,IntPtr

VLServer,       IntPtr
VLPath,         IntPtr
VLNode,         IntPtr

# OpenGL|ES types.
GLclampx,       int
GLfixed,        int
GLeglImageOES,  IntPtr

# External egl buffer type added in OpenGL 4.6
GLeglClientBufferEXT, IntPtr

# nVidia vulkan entry point, added by NV_draw_vulkan_image extension
GLVULKANPROCNV, IntPtr

# OpenCL types.
_cl_context,    IntPtr
_cl_event,      IntPtr
cl_command_queue, IntPtr
cl_context,     IntPtr
cl_device_id,   IntPtr
cl_event,       IntPtr
cl_kernel,      IntPtr
cl_mem,         IntPtr
cl_platform_id, IntPtr
cl_program,     IntPtr
cl_sampler,     IntPtr
size_t,         IntPtr

cl_bool,        bool
cl_int,         int
cl_uint,        uint
uchar,          byte

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

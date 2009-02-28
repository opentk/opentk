# Normal types.
GLsizei,            Int32
GLsizeiptr,         IntPtr
GLintptr,           IntPtr
# GLenum,             Int32
GLboolean,          bool		# Boolean # Int32
GLbitfield,         UInt32
# GLvoid*,            IntPtr
# GLvoid,             Void	#Object
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

PixelInternalFormat,	PixelInternalFormat

# ARB and NV types.
GLsizeiptrARB,      IntPtr
GLintptrARB,        IntPtr
GLhandleARB,        UInt32
GLhalfARB,          UInt16
GLhalfNV,           UInt16
GLcharARB,          Char

# 64 bit types (introduced in 2.1)
GLint64EXT,         Int64
GLuint64EXT,        UInt64
GLint64,            Int64
GLuint64,           UInt64

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
HPBUFFERARB,    IntPtr		#HPBUFFERARB
HPBUFFEREXT,    IntPtr		#HPBUFFEREXT
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
Void			void
Bool			bool
int64_t			long
int32_t			int

Display			IntPtr
Window			IntPtr
Pixmap			IntPtr
Colormap		IntPtr

GLXWindow		IntPtr
GLXContext		IntPtr
GLXDrawable		IntPtr
GLXPixmap		IntPtr
__GLXextFuncPtr IntPtr

VLServer		IntPtr
VLPath			IntPtr
VLNode			IntPtr
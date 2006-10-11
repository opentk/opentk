# ARB and NV types (these should come before normal types to guard against double translation).
GLsizeiptrARB,	IntPtr
GLintptrARB,	IntPtr
GLhandleARB,	Int32	#UInt32
GLhalfARB,		Int16	#UInt16
GLhalfNV,		Int16	#UInt16
GLcharARB,		Char

# Normal types.
GLsizei,		Int32
GLsizeiptr,		IntPtr
GLintptr,		IntPtr
GLenum,			Int32
GLboolean,		Boolean
GLbitfield,		Int32	#UInt32
# GLvoid*,		IntPtr
# GLvoid,		void
GLchar,			Char
GLbyte,			Byte	#SByte
GLubyte,		Byte
GLshort,		Int16
GLushort,		Int16	#UInt16
GLint,			Int32
GLuint,			Int32	#UInt32
GLfloat,		Single
GLclampf,		Single
GLdouble,		Double
GLclampd,		Double
GLstring,		String

# 64 bit types (introduced in 2.1)
GLint64EXT,		Int64
GLuint64EXT,	Int64
GLint64,		Int64
GLuint64,		Int64
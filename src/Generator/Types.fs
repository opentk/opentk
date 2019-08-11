module Types

open FSharp.Data

type OpenGL_Specification = XmlProvider<"./gl.xml">

type Enum =
    { name: string
      value: string }

type EnumGroup =
    { groupName: string
      cases: Enum[] }

type ParameterInfo =
    { paramName: string
      paramType: string }

type FunctionDeclaration =
    { funcName: string
      parameters: ParameterInfo[]
      retType: string }

type GLType =
    | Pointer of GLType
    | GLenum
    | GLint
    | GLboolean
    | GLdouble
    | GLbyte
    | GLfloat
    | GLchar
    | GLcharARB
    | GLclampf
    | GLfixed
    | GLint64
    | GLint64EXT
    | GLintptr
    | GLshort
    | GLsizei
    | GLsizeiptr
    | GLubyte
    | GLuint
    | GLuint64
    | GLuint64EXT
    | GLushort
    | GLvdpauSurfaceNV
    | Void
    | GLhalfNV
    | GLbitfield
    | GLclampd
    | GLclampx
    | GLeglClientBufferEXT
    | GLeglImageOES
    | GLhandleARB
    | GLintptrARB
    | GLsizeiptrARB
    | GLsync
    | Struct_cl_context
    | Struct_cl_event
    | GLDEBUGPROC
    | GLDEBUGPROCAMD
    | GLDEBUGPROCARB
    | GLDEBUGPROCKHR
    
[<RequireQualifiedAccess>]
type TypedParameterInfo =
    { name: string
      typ: GLType }
      
let typedParameterInfo name typ =
    { name = name 
      typ = typ } : TypedParameterInfo
    
[<RequireQualifiedAccess>]
type TypedFunctionDeclaration =
    { name: string
      parameters: TypedParameterInfo[]
      retType: GLType }

let typedFunctionDeclaration name parameters retType =
    { name = name 
      parameters = parameters
      retType = retType } : TypedFunctionDeclaration
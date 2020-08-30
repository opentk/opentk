module Types

type GLEnum =
    { name: string
      value: string }

type GLEnumGroup =
    { groupName: string
      cases: GLEnum [] }

[<RequireQualifiedAccess>]
type GLLooseType =
    { typ: string
      group: string option }

let looseType typ group: GLLooseType =
    { typ = typ
      group = group }

type GLParameterInfo =
    { paramName: string
      lengthParamName: string option
      paramType: GLLooseType }

let parameterInfo name typ =
    { paramName = name
      lengthParamName = None
      paramType = typ }

let parameterInfoWith name typ lengthParamName =
    { paramName = name
      lengthParamName = Some lengthParamName
      paramType = typ }

type GLFunctionDeclaration =
    { funcName: string
      parameters: GLParameterInfo []
      retType: GLLooseType }

type OpenTKType =
    | Vector2
    | Vector3
    | Vector4
    | Vector2d
    | Vector3d
    | Vector4d
    | Matrix2
    | Matrix3
    | Matrix4
    | Matrix2d
    | Matrix3d
    | Matrix4d
    | Matrix2x3
    | Matrix2x4
    | Matrix3x2
    | Matrix3x4
    | Matrix4x2
    | Matrix4x3
    | Matrix2x3d
    | Matrix2x4d
    | Matrix3x2d
    | Matrix3x4d
    | Matrix4x2d
    | Matrix4x3d

type GLType =
    | Pointer of GLType
    | GLenum of GLEnumGroup
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
    | GLVULKANPROCNV
    | OpenTK of OpenTKType
    | RefPointer of GLType
    | StructGenericType of string
    | ArrayType of GLType
    | GLString

[<RequireQualifiedAccess>]
type TypedParameterInfo =
    { name: string
      lengthParamName: string option
      typ: GLType }

let typedParameterInfo name typ: TypedParameterInfo =
    { name = name
      lengthParamName = None
      typ = typ }

let typedParameterInfoWith name typ lengthParamName: TypedParameterInfo =
    { name = name
      lengthParamName = lengthParamName
      typ = typ }

[<RequireQualifiedAccess>]
type TypedFunctionDeclaration =
    { name: string
      parameters: TypedParameterInfo []
      genericTypes: string []
      retType: GLType }

[<RequireQualifiedAccess>]
type PrintReadyTypeInfo =
    { prettyTypeName: string
      typ: GLType }

[<RequireQualifiedAccess>]
type PrintReadyTypedParameterInfo =
    { actualName: string
      prettyName: string
      lengthParamName: string option
      typ: PrintReadyTypeInfo }

[<RequireQualifiedAccess>]
type PrintReadyTypedFunctionDeclaration =
    { actualName: string
      prettyName: string
      parameters: PrintReadyTypedParameterInfo []
      genericTypes: string []
      retType: PrintReadyTypeInfo }

[<RequireQualifiedAccess>]
type PrintReadyEnum =
    { actualName: string
      prettyName: string
      value: string }

[<RequireQualifiedAccess>]
type PrintReadyEnumGroup =
    { groupName: string
      enumCases: PrintReadyEnum [] }

let typedFunctionDeclaration name parameters retType genericTypes : TypedFunctionDeclaration =
    { name = name
      parameters = parameters
      genericTypes = genericTypes
      retType = retType }

type DummyTypeDescriptor =
    { _namespace: string option
      name: string }

[<RequireQualifiedAccess>]
type RawOpenGLSpecificationDetails =
    { version: string
      versionNumber: decimal
      functions: string Set
      enumCases: string Set }

[<RequireQualifiedAccess>]
type ExtensionInfo =
    { name: string
      functions: string []
      enumCases: string [] }

[<RequireQualifiedAccess>]
type FunctionSignature =
    { retType: GLType
      parameters: TypedParameterInfo [] }

let functionSignature retType parameters: FunctionSignature =
    { retType = retType
      parameters = parameters }

type FunctionOverload =
    { expectedName: string
      alternativeName: string option
      overloads: FunctionSignature [] }

let functionOverloads name overloads =
    { expectedName = name
      alternativeName = None
      overloads = overloads }

let functionOverloadsWith name alternativeName overloads =
    { expectedName = name
      alternativeName = Some alternativeName
      overloads = overloads }

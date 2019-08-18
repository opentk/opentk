module Types

type Enum =
    { name: string
      value: string }

type EnumGroup =
    { groupName: string
      cases: Enum [] }

[<RequireQualifiedAccess>]
type LooseType =
    { typ: string
      group: string option }

let looseType typ group: LooseType =
    { typ = typ
      group = group }

type ParameterInfo =
    { paramName: string
      lengthParamName: string option
      paramType: LooseType }

let parameterInfo name typ =
    { paramName = name
      lengthParamName = None
      paramType = typ }

let parameterInfoWith name typ lengthParamName =
    { paramName = name
      lengthParamName = Some lengthParamName
      paramType = typ }

type FunctionDeclaration =
    { funcName: string
      parameters: ParameterInfo []
      retType: LooseType }

type OpenToolkitType =
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

type GLType =
    | Pointer of GLType
    | GLenum of EnumGroup
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
    | OpenToolkit of OpenToolkitType
    | RefPointer of GLType
    | StructGenericType of string
    | ArrayType of GLType

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

type Either<'a, 'b> =
    | Left of 'a
    | Right of 'b

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

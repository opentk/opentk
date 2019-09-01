module Types

type GLEnum =
    { Name: string
      Value: string }

type GLEnumGroup =
    { GroupName: string
      Cases: GLEnum [] }

[<RequireQualifiedAccess>]
type GLLooseType =
    { Type: string
      Group: string option }
    
    static member mk ``type`` group =
        { Type = ``type``
          Group = group }
    

type GLParameterInfo =
    { ParamName: string
      LengthParamName: string option
      ParamType: GLLooseType }
    
    static member mk paramName lengthParamName paramType =
        { ParamName = paramName
          LengthParamName = lengthParamName
          ParamType = paramType }
        
    static member parameterInfoWith name ``type`` lengthParamName =
        { ParamName = name
          LengthParamName = Some lengthParamName
          ParamType = ``type`` } 

type GLFunctionDeclaration =
    { FuncName: string
      Parameters: GLParameterInfo []
      RetType: GLLooseType }

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
    | OpenToolkit of OpenToolkitType
    | RefPointer of GLType
    | StructGenericType of string
    | ArrayType of GLType
    | GLString

[<RequireQualifiedAccess>]
type TypedParameterInfo =
    { Name: string
      LengthParamName: string option
      Type: GLType }
    
    static member mk name ``type`` =
        { Name = name
          LengthParamName = None
          Type = ``type`` }

    static member typedParameterInfoWith name ``type`` lengthParamName =
        { Name = name
          LengthParamName = lengthParamName
          Type = ``type`` }

[<RequireQualifiedAccess>]
type TypedFunctionDeclaration =
    { Name: string
      Parameters: TypedParameterInfo []
      GenericTypes: string []
      RetType: GLType }

[<RequireQualifiedAccess>]
type PrintReadyTypeInfo =
    { PrettyTypeName: string
      Type: GLType }

[<RequireQualifiedAccess>]
type PrintReadyTypedParameterInfo =
    { ActualName: string
      PrettyName: string
      LengthParamName: string option
      Type: PrintReadyTypeInfo }

[<RequireQualifiedAccess>]
type PrintReadyTypedFunctionDeclaration =
    { ActualName: string
      PrettyName: string
      Parameters: PrintReadyTypedParameterInfo []
      GenericTypes: string []
      RetType: PrintReadyTypeInfo }

[<RequireQualifiedAccess>]
type PrintReadyEnum =
    { ActualName: string
      PrettyName: string
      Value: string }

[<RequireQualifiedAccess>]
type PrintReadyEnumGroup =
    { GroupName: string
      EnumCases: PrintReadyEnum [] }

let typedFunctionDeclaration name parameters retType genericTypes : TypedFunctionDeclaration =
    { Name = name
      Parameters = parameters
      GenericTypes = genericTypes
      RetType = retType }

type DummyTypeDescriptor =
    { Namespace: string option
      Name: string }

[<RequireQualifiedAccess>]
type RawOpenGLSpecificationDetails =
    { Version: string
      VersionNumber: decimal
      Functions: string Set
      EnumCases: string Set }

[<RequireQualifiedAccess>]
type ExtensionInfo =
    { Name: string
      Functions: string []
      EnumCases: string [] }

[<RequireQualifiedAccess>]
type FunctionSignature =
    { RetType: GLType
      Parameters: TypedParameterInfo [] }

let functionSignature retType parameters: FunctionSignature =
    { RetType = retType
      Parameters = parameters }

type FunctionOverload =
    { ExpectedName: string
      AlternativeName: string option
      Overloads: FunctionSignature [] }

let functionOverloads name overloads =
    { ExpectedName = name
      AlternativeName = None
      Overloads = overloads }

let functionOverloadsWith name alternativeName overloads =
    { ExpectedName = name
      AlternativeName = Some alternativeName
      Overloads = overloads }

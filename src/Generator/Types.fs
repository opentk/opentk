module Types

open FSharp.Data

type OpenGL_Specification = XmlProvider<"./../gl.xml">


/// A named enum from the specification.
/// This corresponds to a single case within an enum in C#.
type GLEnum =
    { Name: string
      PrettyName: string
      Value: string }

/// A group of enums, from the specification.
/// This corresponds to the general enum type, where the case.
type GLEnumGroup =
    { GroupName: string
      PrettyName: string
      Cases: GLEnum [] }

[<RequireQualifiedAccess>]
type GLLooseType =
    { Type: string
      Group: string option }
    
    static member mk ``type`` group =
        { Type = ``type``
          Group = group }
    

/// Loosely typed parameter info from the specification.
type RawGLParameterInfo =
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


/// Loosely typed enums from the specification.
type RawGLFunctionDeclaration =
    { FuncName: string
      Parameters: RawGLParameterInfo []
      RetType: GLLooseType }

/// The size of a matrix/vector in a single dimension.
type Size =
    | S2
    | S3
    | S4
    
    member x.Number =
        match x with
        | S2 -> 2
        | S3 -> 3
        | S4 -> 4
    
module Size =
    let parse =
        function
        | "2" -> S2
        | "3" -> S3
        | "4" -> S4
        | x -> failwithf "impossible size %s found!" x

type TKType =
    | Vector of Size
    | Vectord of Size
    | Matrix of Size * Size
    | Matrixd of Size * Size
    
    override x.ToString() =
        match x with
        | Vector v -> sprintf "Vector%d" v.Number
        | Vectord v -> sprintf "Vector%id" v.Number
        | Matrix (x,y) -> if x.Number = y.Number then sprintf "Matrix%d" x.Number else sprintf "Matrix%dx%d" x.Number y.Number
        | Matrixd (x,y) -> if x.Number = y.Number then sprintf "Matrix%dd" x.Number else sprintf "Matrix%dx%dd" x.Number y.Number
        
    
module Matrix =
    let square size = Matrix(size, size)

module Matrixd =
    let square size = Matrixd(size, size)
    
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
    | GLString
    | OpenToolkit of TKType
    | RefPointer of GLType
    | StructGenericType of string
    | ArrayType of GLType

[<RequireQualifiedAccess>]
type ParameterInfo =
    { Name: string
      PrettyName: string
      LengthParamName: string option
      Type: GLType }
    
    static member mk name ``type`` =
        { Name = name
          PrettyName = name
          LengthParamName = None
          Type = ``type`` }

    static member typedParameterInfoWith name ``type`` lengthParamName =
        { Name = name
          PrettyName = name
          LengthParamName = lengthParamName
          Type = ``type`` }

[<RequireQualifiedAccess>]
type FunctionDeclaration =
    { Name: string
      PrettyName: string
      Parameters: ParameterInfo []
      GenericTypes: string []
      RetType: GLType }

let typedFunctionDeclaration name parameters retType genericTypes : FunctionDeclaration =
    { Name = name
      PrettyName = name
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
      Cases: string Set }

[<RequireQualifiedAccess>]
type ExtensionInfo =
    { Name: string
      Functions: string []
      Cases: string [] }

[<RequireQualifiedAccess>]
type FunctionSignature =
    { RetType: GLType
      Parameters: ParameterInfo [] }

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

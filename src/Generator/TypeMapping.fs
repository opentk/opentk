module TypeMapping

open Types

type GLType with
    member x.PrettyName =
        match x with
        | GLType.Void -> "void"
        | Pointer elementType -> elementType.PrettyName + "*"
        | GLenum elementType -> elementType.GroupName
        | GLint -> "int"
        | GLboolean -> "bool"
        | GLdouble -> "double"
        | GLbyte -> "sbyte"
        | GLfloat -> "float"
        | GLchar -> "char"
        | GLcharARB -> "char"
        | GLclampf -> "float"
        | GLfixed -> "int"
        | GLint64 -> "long"
        | GLint64EXT -> "long"
        | GLintptr -> "IntPtr"
        | GLshort -> "short"
        | GLsizei -> "uint"
        | GLsizeiptr -> "IntPtr"
        | GLubyte -> "byte"
        | GLuint -> "uint"
        | GLuint64 -> "ulong"
        | GLuint64EXT -> "ulong"
        | GLushort -> "ushort"
        | GLvdpauSurfaceNV -> "IntPtr"
        | GLhalfNV -> "Half"
        | GLbitfield -> "uint"
        | GLclampd -> "double"
        | GLclampx -> "int"
        | GLeglClientBufferEXT -> "IntPtr"
        | GLeglImageOES -> "IntPtr"
        | GLhandleARB -> "uint"
        | GLintptrARB -> "IntPtr"
        | GLsizeiptrARB -> "IntPtr"
        | GLsync -> "IntPtr"
        | Struct_cl_context -> "Struct_cl_context"
        | Struct_cl_event -> "Struct_cl_event"
        | GLDEBUGPROC -> "DebugProc"
        | GLDEBUGPROCAMD -> "DebugProcAmd"
        | GLDEBUGPROCARB -> "DebugProcArb" 
        | GLDEBUGPROCKHR -> "DebugProcKhr"
        | GLVULKANPROCNV -> "IntPtr"
        | OpenToolkit elementType -> string elementType
        | RefPointer (RefPointer _) ->  failwithf "ref-ref pointers should never occur"
        | RefPointer elementType -> "ref " + elementType.PrettyName
        | StructGenericType s -> s
        | ArrayType elementType -> elementType.PrettyName + "[]"
        | GLType.GLString -> "string"
        | IntPtrType -> "IntPtr"

open Util

let looslyTypedFunctionsToTypedFunctions enumMap functions =
    let typecheckParams parameters =
        let len = (parameters |> Array.length)
        let res = Array.zeroCreate len

        let rec typecheck index =
            if index < len then
                let currParam = parameters.[index]
                match currParam.ParamType
                      |> Parsing.tryParseType enumMap currParam.ParamName with
                | Some typ ->
                    res.[index] <- ParameterDeclaration.typedParameterInfoWith currParam.ParamName typ currParam.LengthParamName
                    typecheck (index + 1)
                | None -> false
            else true
        if typecheck 0 then Some res
        else None
    functions
    |> Array.Parallel.choose (fun func ->
        maybe {
            let! retType = func.RetType
                           |> Parsing.tryParseType enumMap func.FuncName
            let! parameters = func.Parameters |> typecheckParams
            let res = typedFunctionDeclaration func.FuncName parameters retType [||]
            return! Some res
        })

let rec tryGetEnumType (typ: GLType) =
    match typ with
    | GLType.Pointer inner -> tryGetEnumType inner
    | GLType.GLenum group -> Some group
    | _ -> None

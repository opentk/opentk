module Parsing
open System
open System.Collections.Generic
open Types
open Util

let private simpleGLTypes =
    [|GLint; GLboolean; GLdouble; GLbyte; GLfloat; GLchar; GLcharARB; GLclampf; GLfixed; GLint64; GLint64EXT; GLintptr;
      GLshort; GLsizei; GLsizeiptr; GLubyte; GLuint; GLuint64; GLuint64EXT; GLushort; GLvdpauSurfaceNV; Void; GLhalfNV;
      GLbitfield; GLclampd; GLclampx; GLeglClientBufferEXT; GLeglImageOES; GLhandleARB; GLintptrARB; GLsizeiptrARB; GLsync;
      Struct_cl_context; Struct_cl_event; GLDEBUGPROC; GLDEBUGPROCAMD; GLDEBUGPROCARB; GLDEBUGPROCKHR; GLVULKANPROCNV; GLString|]
    |> Array.map (fun s -> KeyValuePair.Create((string s).ToLowerInvariant(), s))
    |> fun s -> new Dictionary<_,_>(s, StringComparer.OrdinalIgnoreCase)

let (|IsSimpleGLType|_|) input =
    match simpleGLTypes.TryGetValue input with
    | true, v -> Some v
    | _ -> None

let (|IsPointerType|_|) input =
    match input with
    | "" -> None
    | _ when input.EndsWith('*') -> input.Substring(0, input.Length - 1) |> Some
    | _ -> None

let tryParseType enumMap funcOrParamName (typ: GLLooseType) =
    let str = typ.Type.Replace("const", "").Replace(" ", "")

    let rec tryParse str =
        match str with
        | IsPointerType inner -> tryParse inner |> Option.map Pointer
        | IsSimpleGLType t -> Some t 
        | "GLenum" ->
            match typ.Group with
            | Some group -> 
                match enumMap |> Map.tryFind group with
                | Some entry -> GLenum entry |> Some
                | None ->
                    printfn
                        "Function or param %s references enum group %s which does not exist"
                        funcOrParamName group
                    None
            | _ -> None
        | _ ->
            printfn "input %s is not a valid type" str
            None
    tryParse str

open SpecificationOpenGL
open System.Text.RegularExpressions

let readSpec (path: string) = OpenGL_Specification.Load path

let getEnumsFromSpecification (spec: OpenGL_Specification.Registry) =
    let valueForName =
        spec.Enums
        |> Array.Parallel.collect
            (fun e ->
            e.Enums
            |> Array.Parallel.choose
                (fun case ->
                case.Value.String
                |> Option.map (fun value -> (case.Name, value))))
        |> Map.ofArray
    spec.Groups
    |> Array.Parallel.choose (fun e ->
        maybe {
            let group = e.Name

            let cases =
                e.Enums
                |> Array.Parallel.choose (fun case ->
                    valueForName
                    |> Map.tryFind case.Name
                    |> Option.map (fun value ->
                        { Name = case.Name
                          Value = value }))
                |> Array.groupBy (fun case -> case.Value)
                |> Array.Parallel.choose (fun (_, cases) ->
                    // This is for picking the best enum case name
                    // for an enum case which has multiple names with the same value.
                    // We prefer names which are not from extensions
                    // neither from NVIDIA or so.
                    // If no case was found meeting this standard
                    // just pick the first case (lucky pick!)
                    cases
                    |> Array.tryFind
                        (fun case ->
                        (case.Name.Contains "EXT" || case.Name.Contains "NV")
                        |> not)
                    |> Option.orElse (cases |> Array.tryHead))

            let res =
                { GroupName = group
                  Cases = cases }

            return! Some res
        })

let paramsTypeRegex =
    new Regex("<param(.*?(group=\"(?<group>.*?)\").*?|.*?)>(?<f>.*?)(<ptype>(?<t>.*?)<\/ptype>(?<b>.*?))?(<name>.+?<\/name>).*?<\/param>")
let protoTypeRegex =
    new Regex("<proto(.*?(group=\"(?<group>.*?)\").*?|.*?)>(?<f>.*?)(<ptype>(?<t>.*?)<\/ptype>(?<b>.*?))?(<name>.+?<\/name>).*?<\/proto>")
let getGroupValue (group: string) (matching: Match) =
    matching.Groups.[group].Value
let getRawElementDataWithoutLineBreaks (v: Xml.Linq.XElement) =
    v.ToString().Replace("\n", "").Replace("\t", "").Replace("\r", "")

let getResFromRegexMatch res =
    let groupName =
        let str = getGroupValue "group" res
        if str |> String.IsNullOrWhiteSpace then None
        else Some str

    let typ =
        getGroupValue "f" res + getGroupValue "t" res + getGroupValue "b" res
    groupName, typ

let extractTypeFromPtypeTag (param: OpenGL_Specification.Param) =
    let possibleLengthParam = param.Len.String
    let str = getRawElementDataWithoutLineBreaks param.XElement
    let a, b =
        paramsTypeRegex.Match str
        |> getResFromRegexMatch
    possibleLengthParam, a, b

let extractTypeFromProto (proto: OpenGL_Specification.Proto) =
    let str = getRawElementDataWithoutLineBreaks proto.XElement
    let res = protoTypeRegex.Match str
    getResFromRegexMatch res

let getFunctions (spec: OpenGL_Specification.Registry) =
    spec.Commands.Commands
    |> Array.Parallel.map (fun cmd ->
        let funcName = cmd.Proto.Name

        let parameters =
            cmd.Params
            |> Array.Parallel.map (fun p ->
                let lengthParamName, group, typ = extractTypeFromPtypeTag p
                if String.IsNullOrWhiteSpace typ then
                    let str = p.XElement.ToString()
                    printfn "failed parsing %A, value: %s" (funcName) str
                { ParamName = p.Name
                  LengthParamName = lengthParamName
                  ParamType = GLLooseType.mk typ group })

        let group, typ = extractTypeFromProto cmd.Proto

        let ret =
            { FuncName = funcName
              Parameters = parameters
              RetType = GLLooseType.mk typ group }
        ret)

let getExtensions (spec: OpenGL_Specification.Registry) =
    spec.Extensions
    |> Array.Parallel.map (fun extension ->
        let functions, enums =
            let functions, enums =
                extension.Requires
                |> Array.Parallel.collectEither (fun entry ->
                    [| entry.Commands
                       |> Array.Parallel.map (fun cmd -> cmd.Name)
                       |> Choice1Of2
                       entry.Enums
                       |> Array.Parallel.map (fun cmd -> cmd.Name)
                       |> Choice2Of2 |])
            functions |> Array.Parallel.collect id,
            enums |> Array.Parallel.collect id
        { Name = extension.Name
          Functions = functions
          EnumCases = enums }: ExtensionInfo)

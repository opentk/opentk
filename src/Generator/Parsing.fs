﻿module Parsing

let (|IsPointerType|_|) input =
    match input with
    | "" -> None
    | _ when input.EndsWith('*') ->
        input.Substring(0, input.Length - 1)
        |> Some
    | _ -> None

open Types

let tryParseType enumMap funcOrParamName (ty:LooseType) =
    let str = ty.typ.Replace("const", "").Replace(" ", "")
    let rec tryParse str =
        match str with
        | IsPointerType inner ->
            tryParse inner
            |> Option.map Pointer
        | "GLenum" ->
            ty.group
            |> Option.bind(fun group ->
                match enumMap |> Map.tryFind group with
                | Some entry -> GLenum entry |> Some
                | None ->
                    printfn "Function or param %s references enum group %s which does not exist" funcOrParamName group
                    None
            )
        | "GLboolean" -> Some GLboolean
        | "GLbyte" -> Some GLbyte
        | "GLchar" -> Some GLchar
        | "GLcharARB" -> Some GLcharARB
        | "GLclampf" -> Some GLclampf
        | "GLdouble" -> Some GLdouble
        | "GLfixed" -> Some GLfixed
        | "GLfloat" -> Some GLfloat
        | "GLhalfNV" -> Some GLhalfNV
        | "GLint" -> Some GLint
        | "GLint64" -> Some GLint64
        | "GLint64EXT" -> Some GLint64EXT
        | "GLuint" -> Some GLuint
        | "GLuint64" -> Some GLuint64
        | "GLuint64EXT" -> Some GLuint64EXT
        | "GLintptr" -> Some GLintptr
        | "GLshort" -> Some GLshort
        | "GLushort" -> Some GLushort
        | "GLsizei" -> Some GLsizei
        | "GLubyte" -> Some GLubyte
        | "GLsizeiptr" -> Some GLsizeiptr
        | "GLvdpauSurfaceNV" -> Some GLvdpauSurfaceNV
        | "void" -> Some Void
        | "GLbitfield" -> Some GLbitfield
        | "GLclampd" -> Some GLclampd
        | "GLclampx" -> Some GLclampx
        | "GLeglClientBufferEXT" -> Some GLeglClientBufferEXT
        | "GLeglImageOES" -> Some GLeglImageOES
        | "GLhandleARB" -> Some GLhandleARB
        | "GLintptrARB" -> Some GLintptrARB
        | "GLsizeiptrARB" -> Some GLsizeiptrARB
        | "GLsync" -> Some GLsync
        | "struct_cl_context" -> Some Struct_cl_context
        | "struct_cl_event" -> Some Struct_cl_event
        | "GLDEBUGPROC" -> Some GLDEBUGPROC
        | "GLDEBUGPROCAMD" -> Some GLDEBUGPROCAMD
        | "GLDEBUGPROCARB" -> Some GLDEBUGPROCARB
        | "GLDEBUGPROCKHR" -> Some GLDEBUGPROCKHR
        | _ ->
            printfn "input %s is not a valid type" str
            None
    tryParse str



open Types
open SpecificationOpenGL
open Util

open System
open System.IO
open System.Text.RegularExpressions

let readSpec (path:string) = OpenGL_Specification.Load path

let getEnumsFromSpecification (spec: OpenGL_Specification.Registry) =
    let valueForName =
        spec.Enums
        |> Array.Parallel.collect(fun e ->
            e.Enums
            |> Array.Parallel.choose(fun case ->
                case.Value.String
                |> Option.map(fun value -> (case.Name, value)))
        )
        |> Map.ofArray

    spec.Groups
    |> Array.Parallel.choose(fun e ->
        maybe {
            let group = e.Name
            let cases =
                e.Enums
                |> Array.Parallel.choose(fun case ->
                    valueForName
                    |> Map.tryFind case.Name
                    |> Option.map(fun value ->
                        { name = case.Name
                          value =  value })
                )
                |> Array.groupBy(fun case -> case.value)
                |> Array.Parallel.choose(fun (_, cases) ->
                    cases
                    |> Array.tryFind(fun case -> (case.name.Contains "EXT" || case.name.Contains "NV") |> not)
                    |> Option.orElse (cases |> Array.tryHead)
                )
            let res =
                { groupName = group
                  cases = cases }
            return! Some res
        }
    )

let paramsTypeRegex = new Regex("<param(.*?(group=\"(?<group>.*?)\").*?|.*?)>(?<f>.*?)(<ptype>(?<t>.*?)<\/ptype>(?<b>.*?))?(<name>.+?<\/name>)<\/param>")
let protoTypeRegex = new Regex("<proto(.*?(group=\"(?<group>.*?)\").*?|.*?)>(?<f>.*?)(<ptype>(?<t>.*?)<\/ptype>(?<b>.*?))?(<name>.+?<\/name>)<\/proto>")
let getGroupValue (group: string) (matching: Match) =
    matching.Groups.[group].Value

let getRawElementDataWithoutLineBreaks (v: Xml.Linq.XElement) =
    v.ToString().Replace("\n", "").Replace("\t", "").Replace("\r", "")

let extractTypeFromPtype (param: OpenGL_Specification.Param) =
    let str = getRawElementDataWithoutLineBreaks param.XElement
    let res = paramsTypeRegex.Match str
    let groupName =
        let str = getGroupValue "group" res
        if str |> String.IsNullOrWhiteSpace then None
        else Some str
    let ty =
        getGroupValue "f" res +
        getGroupValue "t" res +
        getGroupValue "b" res
    groupName, ty

let extractTypeFromProto (proto: OpenGL_Specification.Proto) =
    let str = getRawElementDataWithoutLineBreaks proto.XElement
    let res = protoTypeRegex.Match str
    let groupName =
        let str = getGroupValue "group" res
        if str |> String.IsNullOrWhiteSpace then None
        else Some str
    let ty =
        getGroupValue "f" res +
        getGroupValue "t" res +
        getGroupValue "b" res
    groupName, ty

let getFunctions (spec: OpenGL_Specification.Registry) =
    spec.Commands.Commands
    |> Array.Parallel.map(fun cmd ->
        //let isInvalid =
        //    cmd.Params |> Array.exists(fun p -> p.Ptype |> Option.isNone)
        //    || Option.isNone cmd.Proto.Ptype 
        //if isInvalid then
        //    printfn "Function specification %A is invalid" cmd.Proto.Name
        //    cmd.Params |> Seq.iter (fun p -> printfn "%A" p.XElement.Value)
        //    None
        //else
            let funcName = cmd.Proto.Name
            let parameters =
                cmd.Params
                |> Array.Parallel.map(fun p ->
                    let group, ty = extractTypeFromPtype p
                    if String.IsNullOrWhiteSpace ty then
                        let str = p.XElement.ToString()
                        printfn "failed parsing %A, value: %s" (funcName) str
                    { paramName = p.Name
                      paramType = looseType ty group }
                )
            let group, ty = extractTypeFromProto cmd.Proto
            let ret =
                { funcName = funcName 
                  parameters = parameters
                  retType = looseType ty group }
            ret
    )

let getExtensions (spec: OpenGL_Specification.Registry) =
    spec.Extensions
    |> Array.Parallel.map(fun extension ->
        let functions, enums =
            let functions, enums =
                extension.Requires
                |> Array.Parallel.collectEither(fun entry ->
                    [| entry.Commands |> Array.Parallel.map(fun cmd -> cmd.Name) |> Left
                       entry.Enums  |> Array.Parallel.map(fun cmd -> cmd.Name) |> Right |])
            functions |> Array.Parallel.collect id,
            enums |> Array.Parallel.collect id
        { name = extension.Name
          functions = functions
          enumCases = enums } : ExtensionInfo
    )
module Formatting
open Types
open Constants
open TypeMapping

type WriteStatement =
    | WriteLine of string
    | Write of string
    | Indent
    | Unindent

module WriteStatement =
    let writeLine s = WriteLine s
    let write s = Write s
    let indent = Indent
    let unindent = Unindent

    let execute statements =
        use backing = new System.IO.StringWriter()
        use writer = new System.CodeDom.Compiler.IndentedTextWriter(backing)
        let executeStatement statement =
            match statement with
            | WriteLine str -> writer.WriteLine str
            | Write str -> writer.Write str
            | Indent -> writer.Indent <- writer.Indent + 1
            | Unindent -> writer.Indent <- max 0 (writer.Indent - 1)
        statements
        |> Seq.iter executeStatement 
        writer.Flush()
        backing.Flush()
        backing.ToString()

let rec typeToString (ty: GLType) =
    match ty with
    | GLType.Void -> "void"
    | GLType.GLenum inner -> inner.groupName
    | GLType.Pointer inner ->
        typeToString inner + " *"
    | other ->
        let fallback = other.ToString()
        specTypeToCSharpType
        |> Map.tryFind fallback
        |> Option.defaultValue fallback
        
let formatName name =
    reservedKeywords
    |> Array.tryFind (fun n -> name = n)
    |> Option.map(fun keyword -> keyword.ToUpper())
    |> Option.defaultValue name

let formatParam (p: TypedParameterInfo) =
    let name = formatName p.name
    sprintf "%s %s" (p.typ |> typeToString) name

let outputPath = "../binding/Binding"

open WriteStatement

let writeLeftBracket = WriteLine "{"
let writeRightBracket = WriteLine "}"
let writeEmptyLine = WriteLine ""

let generateDummyTypes () =
    let usings = 
        [
            "System"
        ]
        
    let formatDummyType ty =
        sprintf "public struct %s {}" ty.name


    seq {
        for using in usings ->
            writeLine (sprintf "using %s;" using)
            
        yield writeEmptyLine
        yield writeLine "namespace FooBar"
        yield writeLeftBracket
        yield indent
        for ty in additionalTypesToGenerate do
            match ty._namespace with
            | Some n ->
                yield writeLine (sprintf "namespace %s" n)
                yield writeLeftBracket
                yield indent
                yield formatDummyType ty |> writeLine
                yield unindent
                yield writeRightBracket
            | None ->
                yield formatDummyType ty |> writeLine

        yield unindent
        yield writeRightBracket
    } |> execute

let generateEnums enums openGl =
    let usings = 
        [
            "System"
        ]
    seq {
        for using in usings ->
            sprintf "using %s;" using
            |> writeLine
    
        yield writeEmptyLine
        yield writeLine "namespace FooBar"
        yield writeLeftBracket
        yield indent
    
        for enum in enums do
            if enum.cases.Length > 0 then
                yield
                    sprintf "public enum %s" enum.groupName
                    |> writeLine
                yield writeLeftBracket
                yield indent
                let formattedCases =
                    let valueToString value =
                        match value with
                        | "0xFFFFFFFF" -> "-1"
                        | "0x80000000" ->
                            let value = 0x80000000
                            value |> string
                        | _ -> value
                    enum.cases
                    |> Array.Parallel.map(fun case ->
                        sprintf "%s = %s" case.name (valueToString case.value)
                    )
                if formattedCases.Length > 2 then
                    for case in formattedCases.[..formattedCases.Length - 2] ->
                        writeLine (case + ",")
                yield
                    formattedCases.[formattedCases.Length - 1]
                    |> writeLine
                yield unindent
                yield writeRightBracket

        yield unindent
        yield writeRightBracket
    } |> execute

let generateInterface (functions: TypedFunctionDeclaration[]) =
    let usings = 
        [
            "System"
        ]
    seq {
        for using in usings ->
            sprintf "using %s;" using
            |> writeLine

        yield writeEmptyLine
        yield writeLine "namespace FooBar"
        yield writeLeftBracket
        yield indent

        yield writeLine "public interface IGL"
        yield writeLeftBracket
        yield indent

        for func in functions do
            let retTypeAsString = func.retType |> typeToString
            
            let formattedParams =
                func.parameters
                |> Array.Parallel.map formatParam
                |> String.concat ", "
            yield sprintf "unsafe %s %s(%s);" retTypeAsString func.name formattedParams
            |> writeLine
            yield writeEmptyLine
        yield unindent
        yield writeRightBracket
        yield unindent
        yield writeRightBracket
    } |> execute

let generateStaticClass (functions: TypedFunctionDeclaration[]) =
    let usings = 
        [
            "System"
        ]
    seq {
        for using in usings ->
            sprintf "using %s;" using
            |> writeLine
        yield writeLine "namespace FooBar"
        yield writeLeftBracket
        yield indent

        yield writeLine "public static partial class GL"
        yield writeLeftBracket
        yield indent

        for func in functions do
            let retTypeAsString = func.retType |> typeToString
       
            let formattedParams =
                func.parameters
                |> Array.Parallel.map formatParam
                |> String.concat ", "
            let funcName = func.name
            let formattedParamNames = func.parameters |> Array.Parallel.map(fun p -> p.name |> formatName) |> String.concat ", "
            yield
                sprintf "public static unsafe %s %s(%s) => instance.%s(%s);" retTypeAsString funcName formattedParams funcName formattedParamNames
                |> writeLine
            yield writeEmptyLine
        yield unindent
        yield writeRightBracket
        yield unindent
        yield writeRightBracket
    } |> execute
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

let inline specTypeToCSharpTypeWithFallback fallback =
    specTypeToCSharpType
    |> Map.tryFind fallback
    |> Option.defaultValue fallback

let rec typeToString (ty: GLType) =
    match ty with
    | GLType.Void -> "void"
    | GLType.GLenum inner -> inner.groupName
    | GLType.Pointer inner -> typeToString inner + " *"
    | GLType.GLint -> specTypeToCSharpTypeWithFallback "GLint"
    | GLType.GLboolean -> specTypeToCSharpTypeWithFallback "GLboolean"
    | GLType.GLdouble -> specTypeToCSharpTypeWithFallback "GLdouble"
    | GLType.GLbyte -> specTypeToCSharpTypeWithFallback "GLbyte"
    | GLType.GLfloat -> specTypeToCSharpTypeWithFallback "GLfloat"
    | GLType.GLchar -> specTypeToCSharpTypeWithFallback "GLchar"
    | GLType.GLcharARB -> specTypeToCSharpTypeWithFallback "GLcharARB"
    | GLType.GLclampf -> specTypeToCSharpTypeWithFallback "GLclampf"
    | GLType.GLfixed -> specTypeToCSharpTypeWithFallback "GLfixed"
    | GLType.GLint64 -> specTypeToCSharpTypeWithFallback "GLint64"
    | GLType.GLint64EXT -> specTypeToCSharpTypeWithFallback "GLint64EXT"
    | GLType.GLintptr -> specTypeToCSharpTypeWithFallback "GLintptr"
    | GLType.GLshort -> specTypeToCSharpTypeWithFallback "GLshort"
    | GLType.GLsizei -> specTypeToCSharpTypeWithFallback "GLsizei"
    | GLType.GLsizeiptr -> specTypeToCSharpTypeWithFallback "GLsizeiptr"
    | GLType.GLubyte -> specTypeToCSharpTypeWithFallback "GLubyte"
    | GLType.GLuint -> specTypeToCSharpTypeWithFallback "GLuint"
    | GLType.GLuint64 -> specTypeToCSharpTypeWithFallback "GLuint64"
    | GLType.GLuint64EXT -> specTypeToCSharpTypeWithFallback "GLuint64EXT"
    | GLType.GLushort -> specTypeToCSharpTypeWithFallback "GLushort"
    | GLType.GLvdpauSurfaceNV -> specTypeToCSharpTypeWithFallback "GLvdpauSurfaceNV"
    | GLType.GLhalfNV -> specTypeToCSharpTypeWithFallback "GLhalfNV"
    | GLType.GLbitfield -> specTypeToCSharpTypeWithFallback "GLbitfield"
    | GLType.GLclampd -> specTypeToCSharpTypeWithFallback "GLclampd"
    | GLType.GLclampx -> specTypeToCSharpTypeWithFallback "GLclampx"
    | GLType.GLeglClientBufferEXT -> specTypeToCSharpTypeWithFallback "GLeglClientBufferEXT"
    | GLType.GLeglImageOES -> specTypeToCSharpTypeWithFallback "GLeglImageOES"
    | GLType.GLhandleARB -> specTypeToCSharpTypeWithFallback "GLhandleARB"
    | GLType.GLintptrARB -> specTypeToCSharpTypeWithFallback "GLintptrARB"
    | GLType.GLsizeiptrARB -> specTypeToCSharpTypeWithFallback "GLsizeiptrARB"
    | GLType.GLsync -> specTypeToCSharpTypeWithFallback "GLsync"
    | GLType.Struct_cl_context -> specTypeToCSharpTypeWithFallback "Struct_cl_context"
    | GLType.Struct_cl_event -> specTypeToCSharpTypeWithFallback "Struct_cl_event"
    | GLType.GLDEBUGPROC -> specTypeToCSharpTypeWithFallback "GLDEBUGPROC"
    | GLType.GLDEBUGPROCAMD -> specTypeToCSharpTypeWithFallback "GLDEBUGPROCAMD"
    | GLType.GLDEBUGPROCARB -> specTypeToCSharpTypeWithFallback "GLDEBUGPROCARB"
    | GLType.GLDEBUGPROCKHR -> specTypeToCSharpTypeWithFallback "GLDEBUGPROCKHR"
        
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


let namespaceForGlSpecification (openGl: RawOpenGLSpecificationDetails) =
    openGl.version.Replace(".", "_")
    |> sprintf "GL%s"

let generateDummyTypes (openGl: RawOpenGLSpecificationDetails) =
    let usings = 
        [
            "System"
        ]
        
    let formatDummyType ty =
        sprintf "public struct %s {}" ty.name

    let _namespace = namespaceForGlSpecification openGl

    seq {
        for using in usings ->
            writeLine (sprintf "using %s;" using)
            
        yield writeEmptyLine
        yield writeLine ("namespace " + _namespace)
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

let generateEnums enums (openGl: RawOpenGLSpecificationDetails) =
    let usings = 
        [
            "System"
        ]
    let _namespace = namespaceForGlSpecification openGl
    seq {
        for using in usings ->
            sprintf "using %s;" using
            |> writeLine
    
        yield writeEmptyLine
        
        yield writeLine ("namespace " + _namespace)
        yield writeLeftBracket
        yield indent
    
        yield!
            enums
            |> Array.Parallel.collect(fun enum ->
                [|
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
                |])

        yield unindent
        yield writeRightBracket
    } |> execute

let generateInterface (functions: TypedFunctionDeclaration[]) (openGl: RawOpenGLSpecificationDetails) =
    let usings = 
        [
            "System"
        ]
    let _namespace = namespaceForGlSpecification openGl
    seq {
        for using in usings ->
            sprintf "using %s;" using
            |> writeLine

        yield writeEmptyLine
        
        yield writeLine ("namespace " + _namespace)
        yield writeLeftBracket
        yield indent

        yield writeLine "public interface IGL"
        yield writeLeftBracket
        yield indent

        yield!
            functions
            |> Array.Parallel.collect(fun func ->
                [|
                    let retTypeAsString = func.retType |> typeToString
                    
                    let formattedParams =
                        func.parameters
                        |> Array.Parallel.map formatParam
                        |> String.concat ", "
                    yield "unsafe " + retTypeAsString + " " + func.name + "(" + formattedParams + ");"
                    |> writeLine
                    yield writeEmptyLine
                |])
        yield unindent
        yield writeRightBracket
        yield unindent
        yield writeRightBracket
    } |> execute

let generateStaticClass (functions: TypedFunctionDeclaration[]) (openGl: RawOpenGLSpecificationDetails) =
    let usings = 
        [
            "System"
        ]
    let _namespace = namespaceForGlSpecification openGl
    seq {
        for using in usings ->
            sprintf "using %s;" using
            |> writeLine
        
        yield writeLine ("namespace " + _namespace)
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
            // Parameters are so less that running in parallel hurts rather then helps.
            let formattedParamNames = func.parameters |> Array.map(fun p -> p.name |> formatName) |> String.concat ", "
            yield
                sprintf "public static unsafe %s %s(%s) => instance.%s(%s);" retTypeAsString funcName formattedParams funcName formattedParamNames
                |> writeLine
            yield writeEmptyLine
        yield unindent
        yield writeRightBracket
        yield unindent
        yield writeRightBracket
    } |> execute
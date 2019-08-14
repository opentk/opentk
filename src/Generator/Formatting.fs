module Formatting
open Types
open Constants
open TypeMapping
open System.IO

type StringWriterBuilder() =
    let backing = new StringWriter()
    let writer = new System.CodeDom.Compiler.IndentedTextWriter(backing)
    [<CustomOperation("writeLine")>]
    member __.WriteLine (_, str: string) =
        writer.WriteLine str

    [<CustomOperation("writeLines")>]
    member __.WriteLines(_, strs: string[]) =
        strs
        |> Seq.iter(fun line ->
            writer.WriteLine line
        )
        
    [<CustomOperation("returnStringWriter")>]
    member __.GetStringWriter (_) = backing
        
    [<CustomOperation("write")>]
    member __.Write (_, str: string) =
        writer.Write str
    
    [<CustomOperation("indent")>]
    member __.Indent(()) =
        writer.Indent <- writer.Indent + 1
    
    [<CustomOperation("unindent")>]
    member __.Unindent(()) =
        writer.Indent <- max (writer.Indent - 1) 0
    
    member __.Bind _ = ()

    [<CustomOperation("toString")>]
    member __.toString(()) =
        writer.Flush()
        backing.Flush()
        backing.ToString()

    member __.Return _ = ()

    [<CustomOperation("fecker", MaintainsVariableSpaceUsingBind = true)>]
    member __.Fecker(_, [<ProjectionParameter>] a) =
        ()

    member __.Yield _ = ()

    member __.For(_, _) = " asdiajsodj"

    member __.Zero _ = backing.ToString()

let writer() = StringWriterBuilder()



//let test =
//    writer() {
//        //writeLine "foobar"
//        //indent
//        //writeLine "indented"
//        //unindent
//        writeLine ""
//        let test = 
//            writer() {
//                for i in 0..10 do
//                    writeLine "a"
//                fecker ()
//            }
//        writeLines
//            [| for i in 0 .. 10 ->
//                    string i |]
//            //writeLine ""
//        //writeLine "continue writing"
//        //toString
//    }

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

let generateDummyTypes () =
    let usings = 
        [
            "System"
        ]
        
    let formatDummyType ty =
        sprintf "public struct %s {}" ty.name
    writer() {
        for using in usings do
            sprintf "using %s;" using
            |> writeLine

        writeLine ""
        writeLine "namespace FooBar"
        writeLine "{"
        indent()

        for ty in additionalTypesToGenerate do
            match ty._namespace with
            | Some n ->
                sprintf "namespace %s" n
                |> writeLine
                writeLine "{"
                indent()
                formatDummyType ty
                |> writeLine
                unindent()
                writeLine "}"
            | None ->
                formatDummyType ty
                |> writeLine

        unindent()
        writeLine "}"
        toString
    }
    backing.Flush()
    backing.ToString()

let generateEnums enums openGl=
    use backing = new StringWriter()
    use writer = new System.CodeDom.Compiler.IndentedTextWriter(backing)
    let writeLine (str: string) = writer.WriteLine str
    let indent() = writer.Indent <- writer.Indent + 1
    let unindent() = writer.Indent <- writer.Indent - 1
    let usings = 
        [
            "System"
        ]
    for using in usings do
        sprintf "using %s;" using
        |> writeLine

    writeLine ""
    writeLine "namespace FooBar"
    writeLine "{"
    indent()
    
    for enum in enums do
        if enum.cases.Length > 0 then
            sprintf "public enum %s" enum.groupName
            |> writeLine
            writeLine "{"
            indent()
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
                for case in formattedCases.[..formattedCases.Length - 2] do
                    writeLine (case + ",")
            formattedCases.[formattedCases.Length - 1]
            |> writeLine
            unindent()
            writeLine "}"

    unindent()
    writeLine "}"
    backing.Flush()
    backing.ToString()

let generateInterface (functions: TypedFunctionDeclaration[]) =
    use backing = new StringWriter()
    use writer = new System.CodeDom.Compiler.IndentedTextWriter(backing)
    let writeLine (str: string) = writer.WriteLine str
    let indent() = writer.Indent <- writer.Indent + 1
    let unindent() = writer.Indent <- writer.Indent - 1
    let usings = 
        [
            "System"
        ]
    for using in usings do
        sprintf "using %s;" using
        |> writeLine

    writeLine ""
    writeLine "namespace FooBar"
    writeLine "{"
    indent()

    writeLine "public interface IGL"
    writeLine "{"
    indent()

    functions
    |> Seq.iter(fun func ->
        let retTypeAsString = func.retType |> typeToString
        
        let formattedParams =
            func.parameters
            |> Array.Parallel.map formatParam
            |> String.concat ", "
        sprintf "unsafe %s %s(%s);" retTypeAsString func.name formattedParams
        |> writeLine
        writeLine ""
    )
    unindent()
    writeLine "}"
    unindent()
    writeLine "}"
    backing.Flush()
    backing.ToString()

let generateStaticClass (functions: TypedFunctionDeclaration[]) =
   use backing = new StringWriter()
   use writer = new System.CodeDom.Compiler.IndentedTextWriter(backing)
   let writeLine (str: string) = writer.WriteLine str
   let indent() = writer.Indent <- writer.Indent + 1
   let unindent() = writer.Indent <- writer.Indent - 1
   let usings = 
        [
            "System"
        ]
   for using in usings do
        sprintf "using %s;" using
        |> writeLine
   writeLine "namespace FooBar"
   writeLine "{"
   indent()

   writeLine "public static partial class GL"
   writeLine "{"
   indent()

   functions
   |> Seq.iter(fun func ->
       let retTypeAsString = func.retType |> typeToString
       
       let formattedParams =
           func.parameters
           |> Array.Parallel.map formatParam
           |> String.concat ", "
       let funcName = func.name
       let formattedParamNames = func.parameters |> Array.Parallel.map(fun p -> p.name |> formatName) |> String.concat ", "
       sprintf "public static unsafe %s %s(%s) => instance.%s(%s);" retTypeAsString funcName formattedParams funcName formattedParamNames
       |> writeLine
       writeLine ""
   )
   unindent()
   writeLine "}"
   unindent()
   writeLine "}"
   backing.Flush()
   backing.ToString()
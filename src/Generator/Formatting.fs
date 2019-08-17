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
    type Configuration =
        { IndentSize : int }
        static member Default = { IndentSize = 1 }
    let writeLine s = WriteLine s
    let write s = Write s
    let indent = Indent
    let unindent = Unindent

    let executeWith conf statements =
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

    let execute statements = executeWith Configuration.Default statements

let inline specTypeToCSharpTypeWithFallback fallback =
    specTypeToCSharpType
    |> Map.tryFind fallback
    |> Option.defaultValue fallback

let outputPath = "../binding/Binding"

open WriteStatement

let writeLeftBracket = WriteLine "{"
let writeRightBracket = WriteLine "}"
let writeEmptyLine = WriteLine ""

module TypeToString =
    let private cache = System.Collections.Concurrent.ConcurrentDictionary()

    let rec private typeToString (ty: GLType) =
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
        | GLType.RefPointer ty ->
             "ref " + typeToString ty
        | GLType.OpenToolkit ty ->
            match ty with
            | Vector2 -> "Vector2"
            | Vector3 -> "Vector3"
            | Vector4 -> "Vector4"
            | Matrix4 -> "Matrix4"
    
    let typeToStringCached ty =
        match cache.TryGetValue ty with
        | true, value -> value
        | false, _ ->
            let res = typeToString ty
            cache.[ty] <- res
            res

let inline typeToString ty = TypeToString.typeToStringCached ty


let (|StartsWith|_|) (pattern:string) (str:string) =
    if str.StartsWith pattern then str.Substring(pattern.Length) |> Some
    else None

let (|EndsWith|_|) (pattern: string) (str: string) =
    if str.EndsWith pattern then str.Substring(0, str.Length - pattern.Length) |> Some
    else None

let formatNameRemovingPrefix (name: string) =
    let prefix =
        prefixToRemove
        |> Array.tryFind(fun prefix -> name.StartsWith prefix)
    match prefix with
    | Some prefix ->
        let res = name.Substring prefix.Length
        match res.[0] with
        | '1' | '2' | '3' | '4' | '5'
        | '6' | '7' | '8' | '9' ->
            "_" + res
        | _ -> res
    | _ -> name

let formatFunctionName (name: string) =
    let nameWithRemovedPrefix =
        formatNameRemovingPrefix name
    let sufix =
        sufixToRemove
        |> Array.tryFind(fun sufix -> nameWithRemovedPrefix.EndsWith sufix)
    match sufix with
    | Some sufix -> nameWithRemovedPrefix.Substring(0, nameWithRemovedPrefix.Length - sufix.Length)
    | _ -> nameWithRemovedPrefix

let formatParameterName (name: string) =
    reservedKeywords
    |> Array.tryFindIndex (fun n -> name = n)
    |> Option.map(fun i -> reservedKeywordsUpper |> Array.item i)
    |> Option.defaultValue name

let formatParam (p: TypedParameterInfo) = formatParameterName p.name

let namespaceForGlSpecification (openGl: RawOpenGLSpecificationDetails) =
    let prettyName =
        let temp = openGl.version
        let versionAsString =
            let str = openGl.versionNumber |> string
            str.Replace(".", "")
        match temp with
        | StartsWith "GL_ES_VERSION" _
        | StartsWith "GL_VERSION_ES_CM_1_0" _ -> ".ES" + versionAsString
        | StartsWith "GL_VERSION" _ -> versionAsString
        | _ -> temp
    prettyName
    |> sprintf "GL%s"

module PrintReady =

    let formatEnumGroup (enumGroup: EnumGroup) =
        let prettyEnumCases =
            enumGroup.cases
            |> Array.Parallel.map(fun case -> 
                { actualName = case.name
                  prettyName = case.name |> formatNameRemovingPrefix
                  value = case.value } : PrintReadyEnum
            )
        { groupName = enumGroup.groupName
          enumCases = prettyEnumCases } : PrintReadyEnumGroup

    let formatTypeInfo (typeInfo: GLType) =
        { typ = typeInfo
          prettyTypeName = typeInfo |> typeToString } : PrintReadyTypeInfo

    let formatTypeTypeParameterInfo (typedParameterInfo: TypedParameterInfo) =
        { actualName = typedParameterInfo.name
          prettyName = typedParameterInfo |> formatParam
          typ = typedParameterInfo.typ |> formatTypeInfo } : PrintReadyTypedParameterInfo

    let formatTypedFunctionDeclaration (typedFunctionDeclaration: TypedFunctionDeclaration) =
        let parameters =
            typedFunctionDeclaration.parameters
            |> Array.Parallel.map formatTypeTypeParameterInfo
        { actualName = typedFunctionDeclaration.name
          prettyName = typedFunctionDeclaration.name |> formatFunctionName 
          parameters = parameters
          retType = typedFunctionDeclaration.retType |> formatTypeInfo } : PrintReadyTypedFunctionDeclaration

let generateDummyTypes =
    let usings = 
        [
            "System"
        ]
        
    let formatDummyType ty =
        sprintf "public struct %s {}" ty.name

    seq {
        for using in usings ->
            writeLine (sprintf "using %s;" using)
        yield "namespace " + dummyTypesNamespace |> writeLine
        yield writeLeftBracket
        yield indent
        yield writeEmptyLine
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

let generateEnums (enums: PrintReadyEnumGroup[]) (openGl: RawOpenGLSpecificationDetails) =
    let usings = 
        [
            "System"
            dummyTypesNamespace
        ]
    let _namespace = namespaceForGlSpecification openGl
    seq {
        for using in usings ->
            sprintf "using %s;" using
            |> writeLine
    
        yield writeEmptyLine
        
        yield "namespace " + graphicsNamespace + "." + _namespace |> writeLine
        yield writeLeftBracket
        yield indent
    
        yield!
            enums
            |> Array.Parallel.collect(fun enum ->
                [|
                    if enum.enumCases.Length > 0 then
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
                            enum.enumCases
                            |> Array.Parallel.map(fun case ->
                                sprintf "%s = %s" case.prettyName (valueToString case.value)
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

let generateInterface (functions: PrintReadyTypedFunctionDeclaration[]) (openGl: RawOpenGLSpecificationDetails) =
    let usings = 
        [
            "System"
            advancedDlSupport
            mathematicsNamespace
            dummyTypesNamespace
        ]
    let _namespace = namespaceForGlSpecification openGl
    seq {
        for using in usings ->
            sprintf "using %s;" using
            |> writeLine

        yield writeEmptyLine
        
        yield "namespace " + graphicsNamespace + "." + _namespace |> writeLine
        yield writeLeftBracket
        yield indent

        yield writeLine "public interface IGL"
        yield writeLeftBracket
        yield indent

        yield!
            functions
            |> Array.Parallel.collect(fun func ->
                [|
                    let retTypeAsString = func.retType.prettyTypeName
                    
                    let formattedParams =
                        func.parameters
                        |> Array.Parallel.map(fun p -> p.typ.prettyTypeName + " " + p.prettyName)
                        |> String.concat ", "
                    yield ("[NativeSymbol(\"" + func.actualName + "\")]") |> writeLine
                    yield "unsafe " + retTypeAsString + " " + func.prettyName + "(" + formattedParams + ");"
                    |> writeLine
                    yield writeEmptyLine
                |])
        yield unindent
        yield writeRightBracket
        yield unindent
        yield writeRightBracket
    } |> execute

let generateStaticClass (functions: PrintReadyTypedFunctionDeclaration[]) (openGl: RawOpenGLSpecificationDetails) =
    let usings = 
        [
            "System"
            mathematicsNamespace
            dummyTypesNamespace
        ]
    let _namespace = namespaceForGlSpecification openGl
    seq {
        for using in usings ->
            sprintf "using %s;" using
            |> writeLine
        
        yield "namespace " + graphicsNamespace + "." + _namespace |> writeLine
        yield writeLeftBracket
        yield indent

        yield writeLine "public static partial class GL"
        yield writeLeftBracket
        yield indent

        for func in functions do
            let retTypeAsString = func.retType.prettyTypeName
       
            let formattedParams =
                func.parameters
                |> Array.Parallel.map(fun p -> p.typ.prettyTypeName + " " + p.prettyName)
                |> String.concat ", "
            let funcName = func.prettyName
            // Parameters are so less that running in parallel hurts rather then helps.
            let formattedParamNames =
                func.parameters
                |> Array.Parallel.map(fun p ->
                    let possiblePrefix =
                        match p.typ.typ with
                        | RefPointer _ -> "ref "
                        | _ -> ""
                    possiblePrefix + p.prettyName) |> String.concat ", "
            yield
                sprintf "public static unsafe %s %s(%s) => instance.%s(%s);" retTypeAsString funcName formattedParams funcName formattedParamNames
                |> writeLine
            yield writeEmptyLine
        yield unindent
        yield writeRightBracket
        yield unindent
        yield writeRightBracket
    } |> execute

let generateLibraryLoaderFor (openGl: RawOpenGLSpecificationDetails) =
    let libraryLoaderFor _namespace =
        sprintf
                """using AdvancedDLSupport;
                   using OpenToolkit.Graphics.GL;
namespace %s.%s
{
    public static partial class GL
    {
        public static IGL instance = new NativeLibraryBuilder(ImplementationOptions.SuppressSecurity |
                                                     ImplementationOptions.GenerateDisposalChecks |
                                                     ImplementationOptions.UseLazyBinding |
                                                     ImplementationOptions.EnableOptimizations).ActivateInterface<IGL>(LibraryNameContainer.GetLibraryNameForCurrentPlatform());
    }
}"""
            graphicsNamespace _namespace
    openGl
    |> namespaceForGlSpecification
    |> libraryLoaderFor

open Util

/// <deprecated>
let generateCsProjectFileForAllVersions (versions: RawOpenGLSpecificationDetails[]) dummyTypesFilename files =
    let baseString additional =
        sprintf """<Project Sdk="Microsoft.NET.Sdk">

<PropertyGroup>
    <TargetFramework>netstandard2.0</TargetFramework>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
</PropertyGroup>

<ItemGroup>
    <PackageReference Include="AdvancedDLSupport" Version="3.0.0" />
    <ProjectReference Include="..\OpenToolkit.Mathematics\OpenToolkit.Mathematics.csproj" />
</ItemGroup>

%s

</Project>""" additional
    let startTag tag = "<" + tag + ">"
    let endTag tag = "</" + tag ">"
    let includeFile file = "<Compile Include=\"" + file + "\"/>"
    let pathToDummyFile = dummyTypesFileName + ".cs"
    let additionalIncludes =
        seq {
            yield "<ItemGroup>" |> writeLine
            yield indent
            for file in files -> includeFile file |> writeLine
            yield unindent
            yield "</ItemGroup>" |> writeLine
        } |> execute
    baseString additionalIncludes
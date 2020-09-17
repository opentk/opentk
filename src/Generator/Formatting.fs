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
        { IndentSize: int }
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
        statements |> Seq.iter executeStatement
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
open Util

let writeLeftBracket = WriteLine "{"
let writeRightBracket = WriteLine "}"
let writeEmptyLine = WriteLine ""

module TypeToString =
    let private cache = System.Collections.Concurrent.ConcurrentDictionary()

    let rec private typeToString (typ: GLType) =
        match typ with
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
        | GLType.GLvdpauSurfaceNV ->
            specTypeToCSharpTypeWithFallback "GLvdpauSurfaceNV"
        | GLType.GLhalfNV -> specTypeToCSharpTypeWithFallback "GLhalfNV"
        | GLType.GLbitfield -> specTypeToCSharpTypeWithFallback "GLbitfield"
        | GLType.GLclampd -> specTypeToCSharpTypeWithFallback "GLclampd"
        | GLType.GLclampx -> specTypeToCSharpTypeWithFallback "GLclampx"
        | GLType.GLeglClientBufferEXT ->
            specTypeToCSharpTypeWithFallback "GLeglClientBufferEXT"
        | GLType.GLeglImageOES ->
            specTypeToCSharpTypeWithFallback "GLeglImageOES"
        | GLType.GLhandleARB -> specTypeToCSharpTypeWithFallback "GLhandleARB"
        | GLType.GLintptrARB -> specTypeToCSharpTypeWithFallback "GLintptrARB"
        | GLType.GLsizeiptrARB ->
            specTypeToCSharpTypeWithFallback "GLsizeiptrARB"
        | GLType.GLsync -> specTypeToCSharpTypeWithFallback "GLsync"
        | GLType.Struct_cl_context ->
            specTypeToCSharpTypeWithFallback "Struct_cl_context"
        | GLType.Struct_cl_event ->
            specTypeToCSharpTypeWithFallback "Struct_cl_event"
        | GLType.GLDEBUGPROC -> specTypeToCSharpTypeWithFallback "GLDEBUGPROC"
        | GLType.GLDEBUGPROCAMD ->
            specTypeToCSharpTypeWithFallback "GLDEBUGPROCAMD"
        | GLType.GLDEBUGPROCARB ->
            specTypeToCSharpTypeWithFallback "GLDEBUGPROCARB"
        | GLType.GLDEBUGPROCKHR ->
            specTypeToCSharpTypeWithFallback "GLDEBUGPROCKHR"
        | GLType.GLVULKANPROCNV ->
            specTypeToCSharpTypeWithFallback "GLVULKANPROCNV"
        | GLType.RefPointer typ -> "ref " + typeToString typ
        | GLType.StructGenericType s -> s
        | GLType.ArrayType typ -> typeToString typ + "[]"
        | GLType.GLString -> "string"
        | GLType.OpenTK typ ->
            match typ with
            | Vector2 -> "Vector2"
            | Vector3 -> "Vector3"
            | Vector4 -> "Vector4"
            | Vector2d -> "Vector2d"
            | Vector3d -> "Vector3d"
            | Vector4d -> "Vector4d"
            | Matrix2 -> "Matrix2"
            | Matrix3 -> "Matrix3"
            | Matrix4 -> "Matrix4"
            | Matrix2d -> "Matrix2d"
            | Matrix3d -> "Matrix3d"
            | Matrix4d -> "Matrix4d"
            | Matrix2x3 -> "Matrix2x3"
            | Matrix2x4 -> "Matrix2x4"
            | Matrix3x2 -> "Matrix3x2"
            | Matrix3x4 -> "Matrix3x4"
            | Matrix4x2 -> "Matrix4x2"
            | Matrix4x3 -> "Matrix4x3"
            | Matrix2x3d -> "Matrix2x3d"
            | Matrix2x4d -> "Matrix2x4d"
            | Matrix3x2d -> "Matrix3x2d"
            | Matrix3x4d -> "Matrix3x4d"
            | Matrix4x2d -> "Matrix4x2d"
            | Matrix4x3d -> "Matrix4x3d"

    let typeToStringCached typ =
        match cache.TryGetValue typ with
        | true, value -> value
        | false, _ ->
            let res = typeToString typ
            cache.[typ] <- res
            res

let inline typeToString typ = TypeToString.typeToStringCached typ

let (|StartsWith|_|) (pattern: string) (str: string) =
    if str.StartsWith pattern then str.Substring(pattern.Length) |> Some
    else None

let (|EndsWith|_|) (pattern: string) (str: string) =
    if str.EndsWith pattern then
        str.Substring(0, str.Length - pattern.Length) |> Some
    else None

let addUnderscoreIfBeginsWithNumber (res: string) =
    match res.[0] with
    | '1'
    | '2'
    | '3'
    | '4'
    | '5'
    | '6'
    | '7'
    | '8'
    | '9' -> "_" + res
    | _ -> res

let formatNameRemovingPrefix (name: string) =
    let prefix =
        prefixToRemove |> Array.tryFind (fun prefix -> name.StartsWith prefix)
    match prefix with
    | Some prefix ->
        let res = name.Substring prefix.Length
        addUnderscoreIfBeginsWithNumber res
    | _ -> name

let formatFunctionName (name: string) = formatNameRemovingPrefix name

let inline formatParameterName (name: string) =
    let idx = System.Array.IndexOf(reservedKeywords, name)
    if idx <> -1 then
        reservedKeywordsUpper.[idx]
    else
        name

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
    prettyName |> sprintf "GL%s"

module PrintReady =
    let private enumRegex = System.Text.RegularExpressions.Regex("[a-zA-Z0-9]+")

    let formatEnumCase (str:string) =
        let firstPart =
            str
            |> formatNameRemovingPrefix
        enumRegex.Matches firstPart
        |> Seq.choose(fun m ->
            if m.Success then
                m.Value.ToLower()
                |> String.firstToUpper
                |> Some
            else None)
        |> String.concat ""
        |> addUnderscoreIfBeginsWithNumber

    let formatEnumGroup (enumGroup: GLEnumGroup) =
        let prettyEnumCases =
            enumGroup.cases
            |> Array.Parallel.map (fun case ->
                { actualName = case.name
                  prettyName = case.name |> formatEnumCase
                  value = case.value }: PrintReadyEnum)
        { groupName = enumGroup.groupName
          enumCases = prettyEnumCases }: PrintReadyEnumGroup

    let formatTypeInfo (typeInfo: GLType): PrintReadyTypeInfo =
        { typ = typeInfo
          prettyTypeName = typeInfo |> typeToString }

    let formatTypeTypeParameterInfo (typedParameterInfo: TypedParameterInfo): PrintReadyTypedParameterInfo =
        { actualName = typedParameterInfo.name
          prettyName = typedParameterInfo |> formatParam
          lengthParamName = typedParameterInfo.lengthParamName
          typ = typedParameterInfo.typ |> formatTypeInfo }

    let formatTypedFunctionDeclaration (typedFunctionDeclaration: TypedFunctionDeclaration) =
        let parameters =
            typedFunctionDeclaration.parameters
            |> Array.Parallel.map formatTypeTypeParameterInfo
        { actualName = typedFunctionDeclaration.name
          prettyName = typedFunctionDeclaration.name |> formatFunctionName
          parameters = parameters
          genericTypes = typedFunctionDeclaration.genericTypes
          retType = typedFunctionDeclaration.retType |> formatTypeInfo }: PrintReadyTypedFunctionDeclaration

let generateDummyTypes =
    let usings = [ "System" ]
    let formatDummyType typ = sprintf "public struct %s {}" typ.name
    seq {
        for using in usings -> writeLine (sprintf "using %s;" using)
        yield "namespace " + dummyTypesNamespace |> writeLine
        yield writeLeftBracket
        yield indent
        yield writeEmptyLine
        for typ in additionalTypesToGenerate do
            match typ._namespace with
            | Some n ->
                yield writeLine (sprintf "namespace %s" n)
                yield writeLeftBracket
                yield indent
                yield formatDummyType typ |> writeLine
                yield unindent
                yield writeRightBracket
            | None -> yield formatDummyType typ |> writeLine
        yield unindent
        yield writeRightBracket
    }
    |> execute

type GenerateDetails =
    | Extensions
    | OpenGlVersion of RawOpenGLSpecificationDetails

let generateEnums (enums: PrintReadyEnumGroup [])
    (details: GenerateDetails) =
    let usings = [ "System"; dummyTypesNamespace ]
    let _namespace =
        match details with
        | OpenGlVersion openGl -> namespaceForGlSpecification openGl
        | Extensions -> "EXT"
    seq {
        for using in usings -> sprintf "using %s;" using |> writeLine
        yield writeEmptyLine
        yield "namespace " + graphicsNamespace + "." + _namespace |> writeLine
        yield writeLeftBracket
        yield indent
        yield! enums
               |> Array.Parallel.collect (fun enum ->
                   [| if enum.enumCases.Length > 0 then
                       yield sprintf "public enum %s" enum.groupName
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
                           |> Array.Parallel.map
                               (fun case ->
                               sprintf "%s = %s" case.prettyName
                                   (valueToString case.value))
                       if formattedCases.Length > 2 then
                           for case in formattedCases.[..formattedCases.Length
                                                         - 2] ->
                               writeLine (case + ",")
                       yield formattedCases.[formattedCases.Length - 1]
                             |> writeLine
                       yield unindent
                       yield writeRightBracket |])
        yield unindent
        yield writeRightBracket
    }
    |> execute

let rec isPointerType typ =
    match typ with
    | ArrayType inner
    | RefPointer inner -> isPointerType inner
    | Pointer(Pointer _ as inner) -> isPointerType inner
    | Pointer _ -> true
    | _ -> false

let namespaceAndDocumentationFor (details: GenerateDetails) =
    match details with
    | OpenGlVersion openGl ->
        let version = openGl.versionNumber |> floor |> int
        let baseUrl = sprintf "http://docs.gl/gl%d/" version
        namespaceForGlSpecification openGl,
        fun str -> "/// See documentation online here: "+ baseUrl + str
    | Extensions ->
        "EXT",
        fun _ -> "/// No documentation for extension functions available yet."

let generateInterface (functions: PrintReadyTypedFunctionDeclaration [])
    (details: GenerateDetails) =
    let _namespace, documentationFor = namespaceAndDocumentationFor details
    let usings =
        [ "System"; advancedDlSupport; mathematicsNamespace; dummyTypesNamespace ]
    seq {
        for using in usings -> sprintf "using %s;" using |> writeLine
        yield writeEmptyLine
        yield "namespace " + graphicsNamespace + "." + _namespace |> writeLine
        yield writeLeftBracket
        yield indent
        yield writeLine "public interface IGL"
        yield writeLeftBracket
        yield indent
        yield! functions
               |> Array.Parallel.collect (fun func ->
                   [| let retTypeAsString = func.retType.prettyTypeName

                      let formattedParams =
                          func.parameters
                          |> Array.map
                              (fun p ->
                              p.typ.prettyTypeName + " " + p.prettyName)
                          |> String.concat ", "
                      yield documentationFor func.actualName |> writeLine
                      yield ("[NativeSymbol(\"" + func.actualName + "\")]")
                            |> writeLine
                      let additional =
                          if func.genericTypes.Length > 0 then
                            let inner =
                                func.genericTypes
                                |> String.concat ", "
                            "<" + inner + ">"
                          else ""
                      let prefix =
                          if func.parameters |> Array.exists (fun p -> isPointerType p.typ.typ)
                             || isPointerType func.retType.typ then "unsafe "
                          else ""
                      yield prefix + retTypeAsString + " " + func.prettyName
                            + additional
                            + "(" + formattedParams + ")" |> write
                      if func.genericTypes.Length > 0 then
                        yield indent
                        yield writeLine ""
                        for typ in func.genericTypes |> Seq.take (max 0 (func.genericTypes.Length - 2)) do
                            yield "where " + typ + " : struct" |> writeLine
                        let last = func.genericTypes |> Seq.last
                        yield "where " + last + " : struct;" |> writeLine
                        yield unindent
                      else
                        yield writeLine ";"
                      yield writeEmptyLine |])
        yield unindent
        yield writeRightBracket
        yield unindent
        yield writeRightBracket
    }
    |> execute

let generateStaticClass (functions: PrintReadyTypedFunctionDeclaration [])
    (details: GenerateDetails) =
    let _namespace, documentationFor = namespaceAndDocumentationFor details
    let usings =
        [ "System"; mathematicsNamespace; dummyTypesNamespace ]
    seq {
        for using in usings -> sprintf "using %s;" using |> writeLine
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
                |> Array.Parallel.map
                    (fun p -> p.typ.prettyTypeName + " " + p.prettyName)
                |> String.concat ", "

            let funcName = func.prettyName

            // Parameters are so less that running in parallel hurts rather then helps.
            let formattedParamNames =
                func.parameters
                |> Array.Parallel.map (fun p ->
                    let possiblePrefix =
                        match p.typ.typ with
                        | RefPointer _ -> "ref "
                        | _ -> ""
                    possiblePrefix + p.prettyName)
                |> String.concat ", "
            let additional =
                if func.genericTypes.Length > 0 then
                    let inner =
                        func.genericTypes
                        |> String.concat ", "
                    "<" + inner + ">"
                else ""
            yield documentationFor func.actualName |> writeLine
            let prefix =
                if func.parameters |> Array.exists (fun p -> isPointerType p.typ.typ)
                   || isPointerType func.retType.typ then " unsafe"
                else ""
            if func.genericTypes.Length > 0 then
                yield sprintf "public static%s %s %s%s(%s)"
                          prefix retTypeAsString funcName additional formattedParams |> writeLine
                yield indent
                yield writeLine ""
                for typ in func.genericTypes |> Seq.take (max 0 (func.genericTypes.Length - 2)) do
                    yield "where " + typ + " : struct" |> writeLine
                let last = func.genericTypes |> Seq.last
                yield "where " + last + " : struct" |> write
                yield sprintf " => instance.%s(%s);" funcName formattedParamNames |> writeLine

                yield unindent
            else
                yield sprintf "public static%s %s %s%s(%s) => instance.%s(%s);"
                          prefix retTypeAsString funcName additional formattedParams
                          funcName formattedParamNames |> writeLine
            yield writeEmptyLine
        yield unindent
        yield writeRightBracket
        yield unindent
        yield writeRightBracket
    }
    |> execute

let generateLibraryLoaderFor (details: GenerateDetails) =
    let _namespace =
        match details with
        | OpenGlVersion openGl -> namespaceForGlSpecification openGl
        | Extensions -> "EXT"
    let libraryLoaderFor _namespace =
        let call =
            sprintf """using AdvancedDLSupport;
using OpenTK.Graphics.GL;
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
        call graphicsNamespace _namespace
    _namespace
    |> libraryLoaderFor

open Util

/// <deprecated>
let generateCsProjectFileForAllVersions (versions: RawOpenGLSpecificationDetails [])
    dummyTypesFilename files =
    let baseString additional =
        sprintf """<Project Sdk="Microsoft.NET.Sdk">

<PropertyGroup>
    <TargetFramework>netstandard2.0</TargetFramework>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
</PropertyGroup>

<ItemGroup>
    <PackageReference Include="AdvancedDLSupport" Version="3.0.0" />
    <ProjectReference Include="..\OpenTK.Mathematics\OpenTK.Mathematics.csproj" />
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
        }
        |> execute
    baseString additionalIncludes

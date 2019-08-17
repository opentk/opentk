﻿// Learn more about F// at http://fsharp.org

open Types
open SpecificationOpenGL
open Util
open Constants

open System
open System.IO

open CommandLine

type options = {
  [<Option('i', "input", Required = true, HelpText = "Path to specification file.")>] pathToSpecificationFile: string
  [<Option('o', "output", Required = true, HelpText = "Path to output directory.")>] pathToOutputDirectory: string
}


[<EntryPoint>]
let main argv =
    printfn "Hello World from F# and welcome to the OpenTK4.0 binding generator!"
    let result = CommandLine.Parser.Default.ParseArguments<options>(argv)
    let options =
        match result with
        | :? Parsed<options> as parsed -> parsed.Value
        | :? NotParsed<options> as notParsed -> failwithf "Error %A" (notParsed.Errors)
        | _ -> failwith "No options given"

    System.Runtime.GCSettings.LatencyMode <- System.Runtime.GCLatencyMode.SustainedLowLatency
    let startTime = System.Diagnostics.Stopwatch.StartNew()
    let path = options.pathToSpecificationFile
    let test = OpenGL_Specification.Load path
    let enums =
        Parsing.getEnumsFromSpecification test
    printfn "Enum group count: %d" enums.Length
    let enumMap =
        enums
        |> Array.Parallel.map(fun group ->
            group.groupName, group
        )
        |> Map.ofArray
    let functions = Parsing.getFunctions test
    printfn "Function count: %d" functions.Length
    
    let extensions = Parsing.getExtensions test
    printfn "Extension count: %d" extensions.Length

    let functionToExtensionMapper =
        extensions
        |> Array.Parallel.collect(fun extension ->
            extension.functions |> Array.Parallel.map(fun func -> extension.name, func))
        |> Array.groupBy snd
        |> Array.Parallel.map(fun (func, extensions) -> func, extensions |> Array.Parallel.map fst)
        |> Map.ofArray

    let enumCaseToExtensionMapper =
        extensions
        |> Array.Parallel.collect(fun extension ->
            extension.enumCases |> Array.Parallel.map(fun enumCase -> extension.name, enumCase))
        |> Array.groupBy snd
        |> Array.Parallel.map(fun (enumCase, extensions) -> enumCase, extensions |> Array.Parallel.map fst)
        |> Map.ofArray
            

    let typecheckedFunctions =
        TypeMapping.looslyTypedFunctionsToTypedFunctions enumMap functions
        |> Array.Parallel.map Formatting.PrintReady.formatTypedFunctionDeclaration
        |> Array.Parallel.collect(fun func ->
            match functionOverloads |> Map.tryFind func.actualName with
            | Some overload ->
                overload.overloads
                |> Array.Parallel.map(fun currOverload ->
                    { func with
                        prettyName = overload.alternativeName |> Option.defaultValue func.prettyName
                        parameters = currOverload.parameters |> Array.map Formatting.PrintReady.formatTypeTypeParameterInfo
                        retType = currOverload.retType |> Formatting.PrintReady.formatTypeInfo }
                )
            | None -> func |> Array.singleton
        )

    let prettyEnumGroups =
        enums
        |> Array.Parallel.map Formatting.PrintReady.formatEnumGroup

    let prettyEnumGroupMap =
        prettyEnumGroups
        |> Array.Parallel.map(fun group ->
            group.groupName, group
        )
        |> Map.ofArray

    printfn "overall correct function specifications: %d" typecheckedFunctions.Length
    let openGlSpecVersions = Aggregator.getEnumCasesAndCommandsPerVersion test
    let basePath = options.pathToOutputDirectory

    let getShortTagForOpenGlVersion (openGl: RawOpenGLSpecificationDetails) =
        let str = sprintf "%M" openGl.versionNumber
        if openGl.version.Contains "ES" then str + "_ES"
        else str

    let getPathForOpenGlVersion (openGl: RawOpenGLSpecificationDetails) =
        basePath </> (getShortTagForOpenGlVersion openGl)

    basePath
    |> Directory.CreateDirectory
    |> ignore

    Formatting.generateDummyTypes
    |> fun content -> 
        File.WriteAllText(basePath </> dummyTypesFileName + ".cs", content)

    let inline writeToFile (openGl: RawOpenGLSpecificationDetails) topic content =
        let pathToFile = getPathForOpenGlVersion openGl
        pathToFile
        |> Directory.CreateDirectory
        |> ignore
        let fileName = topic + ".cs"
        Directory.CreateDirectory pathToFile |> ignore
        File.WriteAllText(pathToFile </> fileName, content)
        pathToFile </> fileName

    let writeCsProjFile content =
        let fileName = sprintf "OpenGL_Bindings.csproj"
        let fullPathToFile = basePath </> fileName
        File.WriteAllText(fullPathToFile, content)

    openGlSpecVersions
    |> Array.Parallel.collect (fun currOpenGL_Spec ->
        let inline writeToFile topic content = writeToFile currOpenGL_Spec topic content
        let typecheckedFunctions =
            typecheckedFunctions
            |> Array.filter(fun func ->
                currOpenGL_Spec.functions.Contains func.actualName
                || (functionToExtensionMapper |> Map.containsKey func.actualName))
        let enums =
            let requiredEnumsFromFunctions =
                typecheckedFunctions
                |> Array.Parallel.collect(fun func ->
                    func.parameters
                    |> Array.Parallel.choose(fun param ->
                        TypeMapping.tryGetEnumType param.typ.typ
                        |> Option.bind(fun group -> prettyEnumGroupMap |> Map.tryFind group.groupName)
                    )
                )
            prettyEnumGroups
            |> Array.Parallel.choose(fun enum ->
                // if enum.groupName = "ClipPlaneName" then System.Diagnostics.Debugger.Break()
                let cases =
                    enum.enumCases
                    |> Array.filter (fun case ->
                        currOpenGL_Spec.enumCases.Contains case.actualName
                        || (enumCaseToExtensionMapper |> Map.containsKey case.actualName))
                if cases.Length > 0 then
                    { enum with
                        enumCases = cases }
                    |> Some
                else None
            )
            |> Array.append requiredEnumsFromFunctions
            |> Array.distinctBy(fun e -> e.groupName)

        let generatedFiles =
            [|
                yield
                    Formatting.generateEnums enums currOpenGL_Spec
                    |> writeToFile "Enums"
                yield
                    Formatting.generateInterface typecheckedFunctions currOpenGL_Spec
                    |> writeToFile "Interface"
                yield
                    Formatting.generateStaticClass typecheckedFunctions currOpenGL_Spec
                    |> writeToFile "StaticClass"
                yield
                    Formatting.generateLibraryLoaderFor currOpenGL_Spec
                    |> writeToFile "LibraryLoader"
            |]
        printfn "Done writing OpenGL Version %s files." currOpenGL_Spec.version
        generatedFiles
    ) |> ignore
    
    //Formatting.generateCsProjectFileForAllVersions openGlSpecVersions dummyTypesFileName [||]
    //|> writeCsProjFile

    printfn "Generating files took %s seconds" (startTime.Elapsed.Seconds |> string)  

    //printfn "Please press any key..."
    //System.Console.ReadKey() |> ignore

    0 // return an integer exit code

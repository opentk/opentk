// Learn more about F// at http://fsharp.org

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
    let enums = Parsing.getEnumsFromSpecification test
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

    let writeCsProjFile (openGl: RawOpenGLSpecificationDetails) content =
        let path = getPathForOpenGlVersion openGl
        path
        |> Directory.CreateDirectory
        |> ignore
        let versionAsString = getShortTagForOpenGlVersion openGl
        let fileName = sprintf "OpenGL_Bindings_%s.csproj" versionAsString
        let fullPathToFile = path </> fileName
        File.WriteAllText(fullPathToFile, content)


    openGlSpecVersions
    |> Array.Parallel.iter (fun currOpenGL_Spec ->
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
                    )
                )
            enums
            |> Array.Parallel.choose(fun enum ->
                // if enum.groupName = "ClipPlaneName" then System.Diagnostics.Debugger.Break()
                let cases =
                    enum.cases
                    |> Array.filter (fun case ->
                        currOpenGL_Spec.enumCases.Contains case.name
                        || (enumCaseToExtensionMapper |> Map.containsKey case.name))
                if cases.Length > 0 then
                    { enum with
                        EnumGroup.cases = cases }
                    |> Some
                else None
            )
            |> Array.append requiredEnumsFromFunctions
            |> Array.distinctBy(fun e -> e.groupName)
        Formatting.generateEnums enums currOpenGL_Spec
        |> writeToFile "Enums"
        Formatting.generateInterface typecheckedFunctions currOpenGL_Spec
        |> writeToFile "Interface"
        Formatting.generateStaticClass typecheckedFunctions currOpenGL_Spec
        |> writeToFile "StaticClass"
        Formatting.generateLibraryLoaderFor currOpenGL_Spec
        |> writeToFile "LibraryLoader"
        Formatting.generateCsProjectFileFor currOpenGL_Spec dummyTypesFileName
        |> writeCsProjFile currOpenGL_Spec
        printfn "Done writing OpenGL Version %s files." currOpenGL_Spec.version
    )

    printfn "Generating files took %s seconds" (startTime.Elapsed.Seconds |> string)  

    //printfn "Please press any key..."
    //System.Console.ReadKey() |> ignore

    0 // return an integer exit code

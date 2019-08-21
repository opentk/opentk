// Learn more about F// at http://fsharp.org
open System
open Formatting
open Types
open SpecificationOpenGL
open Util
open Constants
open System.IO
open System.Runtime
open CommandLine

type options =
    { [<Option('i', "input", Required = true,
               HelpText = "Path to specification file.")>]
      pathToSpecificationFile: string
      [<Option('o', "output", Required = true,
               HelpText = "Path to output directory.")>]
      pathToOutputDirectory: string }


[<RequireQualifiedAccess>]
type ParseResult =
    { enums: GLEnumGroup[]
      functions: GLFunctionDeclaration[]
      extensions: ExtensionInfo[]
      data: OpenGL_Specification.Registry }
 
let parse (pathToSpec: string) =
    let test = OpenGL_Specification.Load pathToSpec
    let enums = Parsing.getEnumsFromSpecification test
    let functions = Parsing.getFunctions test
    let extensions = Parsing.getExtensions test

    printfn "Enum group count: %d" enums.Length
    printfn "Function count: %d" functions.Length
    printfn "Extension count: %d" extensions.Length

    { enums = enums
      functions = functions
      extensions = extensions
      data = test } : ParseResult

[<RequireQualifiedAccess>]
type TypecheckAndFormatWithOverloadGenerationResult =
    { prettyFunctions: PrintReadyTypedFunctionDeclaration[]
      prettyEnumGroups: PrintReadyEnumGroup[]
      functionToExtensionMapper: Map<string, string[]>
      enumCaseToExtensionMapper: Map<string, string[]>
      prettyEnumGroupMap: Map<string, PrintReadyEnumGroup>
      extensionsOnlyFunctions: PrintReadyTypedFunctionDeclaration[]
      extensionsOnlyEnumCases: PrintReadyEnumGroup[]
      data: OpenGL_Specification.Registry }

let ``typecheck, format and generate overloads`` (parseResult: ParseResult) =
    let enums = parseResult.enums
    let functions = parseResult.functions
    let extensions = parseResult.extensions

    let enumMap =
        enums
        |> Array.Parallel.map (fun group -> group.groupName, group)
        |> Map.ofArray

    let prettyFunctions =
        TypeMapping.looslyTypedFunctionsToTypedFunctions enumMap functions
        |> Array.Parallel.collect (fun func ->            
            let func = Formatting.PrintReady.formatTypedFunctionDeclaration func
            match functionOverloads |> Map.tryFind func.actualName with
            | Some overload ->
                overload.overloads
                |> Array.Parallel.map
                    (fun currOverload ->
                    { func with
                          prettyName =
                              overload.alternativeName
                              |> Option.defaultValue func.prettyName
                          parameters =
                              currOverload.parameters
                              |> Array.map
                                  Formatting.PrintReady.formatTypeTypeParameterInfo
                          retType =
                              currOverload.retType
                              |> Formatting.PrintReady.formatTypeInfo })
            | None ->
                let newName, primaryOverload =
                    func
                    |> OverloadGeneration.autoGenerateOverloadForType
                let funcWithOriginalSignature =
                    newName
                    |> Option.map(fun newName -> { func with prettyName = newName })
                    |> Option.defaultValue func
                let additionalOverloads = OverloadGeneration.autoGenerateAdditionalOverloadForType funcWithOriginalSignature
                [| funcWithOriginalSignature
                   primaryOverload |]
                |> Array.append additionalOverloads
                |> Array.distinct)

    let prettyEnumGroups =
        enums |> Array.Parallel.map Formatting.PrintReady.formatEnumGroup

    let getMapper fn =
        extensions
        |> Array.Parallel.collect
            (fun extension ->
            fn extension
            |> Array.Parallel.map (fun value -> extension.name, value))
        |> Array.groupBy snd
        |> Array.Parallel.map
            (fun (value, extensions) ->
            value, extensions |> Array.Parallel.map fst)
        |> Map.ofArray

    let functionToExtensionMapper =
        getMapper (fun extension -> extension.functions)

    let enumCaseToExtensionMapper =
        getMapper (fun extension -> extension.enumCases)
        

    let prettyEnumGroupMap =
        prettyEnumGroups
        |> Array.Parallel.map (fun group -> group.groupName, group)
        |> Map.ofArray

    let typecheckedFunctionsExtensionsOnly =
        prettyFunctions
        |> Array.filter
            (fun func -> (functionToExtensionMapper |> Map.containsKey func.actualName))
    let enumsWithExtensionsOnly =
        let requiredEnumsFromFunctions =
            typecheckedFunctionsExtensionsOnly
            |> Array.Parallel.collect
                (fun func ->
                func.parameters
                |> Array.Parallel.choose
                    (fun param ->
                    TypeMapping.tryGetEnumType param.typ.typ
                    |> Option.bind
                        (fun group ->
                        prettyEnumGroupMap |> Map.tryFind group.groupName)))
        prettyEnumGroups
        |> Array.Parallel.choose (fun enum ->
            // if enum.groupName = "ClipPlaneName" then System.Diagnostics.Debugger.Break()
            let cases =
                enum.enumCases
                |> Array.filter
                    (fun case ->
                        enumCaseToExtensionMapper
                        |> Map.containsKey case.actualName)
            if cases.Length > 0 then { enum with enumCases = cases } |> Some
            else None)
        |> Array.append requiredEnumsFromFunctions
        |> Array.distinctBy (fun e -> e.groupName)
    {
        prettyEnumGroups = prettyEnumGroups
        prettyFunctions = prettyFunctions
        prettyEnumGroupMap = prettyEnumGroupMap
        functionToExtensionMapper = functionToExtensionMapper
        enumCaseToExtensionMapper = enumCaseToExtensionMapper
        extensionsOnlyEnumCases = enumsWithExtensionsOnly
        extensionsOnlyFunctions = typecheckedFunctionsExtensionsOnly
        data = parseResult.data
    } : TypecheckAndFormatWithOverloadGenerationResult

type TypecheckAndAggregateResults =
    { prettyFunctions: PrintReadyTypedFunctionDeclaration[]
      prettyEnumGroups: PrintReadyEnumGroup[]
      functionToExtensionMapper: Map<string, string[]>
      enumCaseToExtensionMapper: Map<string, string[]>
      prettyEnumGroupMap: Map<string, PrintReadyEnumGroup>
      extensionsOnlyFunctions: PrintReadyTypedFunctionDeclaration[]
      extensionsOnlyEnumCases: PrintReadyEnumGroup[]
      openGlVersions: RawOpenGLSpecificationDetails[] }

let aggregateFunctionsAndEnums (typecheckResults: TypecheckAndFormatWithOverloadGenerationResult) =
    let openGlVersions = Aggregator.getEnumCasesAndCommandsPerVersion typecheckResults.data
    { prettyFunctions = typecheckResults.prettyFunctions
      prettyEnumGroups = typecheckResults.prettyEnumGroups
      openGlVersions = openGlVersions
      prettyEnumGroupMap = typecheckResults.prettyEnumGroupMap
      functionToExtensionMapper = typecheckResults.functionToExtensionMapper
      enumCaseToExtensionMapper = typecheckResults.enumCaseToExtensionMapper
      extensionsOnlyEnumCases = typecheckResults.extensionsOnlyEnumCases
      extensionsOnlyFunctions = typecheckResults.extensionsOnlyFunctions } : TypecheckAndAggregateResults

let generateCode basePath (typecheckAndAggregateResults: TypecheckAndAggregateResults) =
    let enumsWithExtensionsOnly = typecheckAndAggregateResults.extensionsOnlyEnumCases
    let typecheckedFunctionsExtensionsOnly = typecheckAndAggregateResults.extensionsOnlyFunctions
    let openGlVersions = typecheckAndAggregateResults.openGlVersions
    let prettyFunctions = typecheckAndAggregateResults.prettyFunctions
    let prettyEnumGroups = typecheckAndAggregateResults.prettyEnumGroups
    let prettyEnumGroupMap = typecheckAndAggregateResults.prettyEnumGroupMap
    let functionToExtensionMapper = typecheckAndAggregateResults.functionToExtensionMapper
    let enumCaseToExtensionMapper = typecheckAndAggregateResults.enumCaseToExtensionMapper
    
    
    let inline writeToFile pathToFile topic content =
        pathToFile
        |> Directory.CreateDirectory
        |> ignore
        let fileName = topic + ".cs"
        Directory.CreateDirectory pathToFile |> ignore
        File.WriteAllText(pathToFile </> fileName, content)
    
    let getShortTagForOpenGlVersion (openGl: RawOpenGLSpecificationDetails) =
        let str = sprintf "%M" openGl.versionNumber
        if openGl.version.Contains "ES" then str + "_ES"
        else str
    
    let getPathForOpenGlVersion (openGl: RawOpenGLSpecificationDetails) =
        basePath </> (getShortTagForOpenGlVersion openGl)
    
    let inline writeToFileSpec (openGl: RawOpenGLSpecificationDetails) topic content =
        let pathToFile = getPathForOpenGlVersion openGl
        writeToFile pathToFile topic content

    basePath
    |> Directory.CreateDirectory
    |> ignore
    Formatting.generateDummyTypes
    |> fun content ->
        File.WriteAllText(basePath </> dummyTypesFileName + ".cs", content)

    let path = basePath </> "Extensions"
    Formatting.generateEnums enumsWithExtensionsOnly (GenerateDetails.Extensions)
    |> writeToFile path "EnumsExtensionsOnly"

    Formatting.generateInterface typecheckedFunctionsExtensionsOnly (GenerateDetails.Extensions)
    |> writeToFile path "InterfaceExtensionsOnly"

    Formatting.generateStaticClass typecheckedFunctionsExtensionsOnly
        (GenerateDetails.Extensions)
    |> writeToFile path "StaticClassExtensionsOnly"

    Formatting.generateLibraryLoaderFor (GenerateDetails.Extensions)
    |> writeToFile path "LibraryLoaderExtensionsOnly"

    openGlVersions
    |> Array.Parallel.iter (fun glVersion ->
        let inline writeToFile topic content =
            writeToFileSpec glVersion topic content
        let typecheckedFunctionsWithoutExtensions =
            prettyFunctions
            |> Array.filter
                (fun func ->
                glVersion.functions.Contains func.actualName
                && (functionToExtensionMapper |> Map.containsKey func.actualName |> not))

        let enumsWithoutExtensions =
            let requiredEnumsFromFunctions =
                typecheckedFunctionsWithoutExtensions
                |> Array.Parallel.collect
                    (fun func ->
                    func.parameters
                    |> Array.Parallel.choose
                        (fun param ->
                        TypeMapping.tryGetEnumType param.typ.typ
                        |> Option.bind
                            (fun group ->
                            prettyEnumGroupMap |> Map.tryFind group.groupName)))
            prettyEnumGroups
            |> Array.Parallel.choose (fun enum ->
                // if enum.groupName = "ClipPlaneName" then System.Diagnostics.Debugger.Break()
                let cases =
                    enum.enumCases
                    |> Array.filter
                        (fun case ->
                        glVersion.enumCases.Contains case.actualName
                        && (enumCaseToExtensionMapper
                            |> Map.containsKey case.actualName
                            |> not))
                if cases.Length > 0 then { enum with enumCases = cases } |> Some
                else None)
            |> Array.append requiredEnumsFromFunctions
            |> Array.distinctBy (fun e -> e.groupName)
        Formatting.generateEnums enumsWithoutExtensions (GenerateDetails.OpenGlVersion glVersion)
        |> writeToFile "EnumsWithoutExtensions"

        Formatting.generateInterface typecheckedFunctionsWithoutExtensions (GenerateDetails.OpenGlVersion glVersion)
        |> writeToFile "InterfaceWithoutExtensions"

        Formatting.generateStaticClass typecheckedFunctionsWithoutExtensions (GenerateDetails.OpenGlVersion glVersion)
        |> writeToFile "StaticClassWithoutExtensions"

        Formatting.generateLibraryLoaderFor (GenerateDetails.OpenGlVersion glVersion)
        |> writeToFile "LibraryLoaderWithoutExtensions"

        printfn "Done writing OpenGL Version %s files." glVersion.version)

[<EntryPoint>]
let main argv =
    printfn
        "Welcome to the OpenTK4.0 binding generator F#ast edition!"
    let result = CommandLine.Parser.Default.ParseArguments<options>(argv)

    let options =
        match result with
        | :? (Parsed<options>) as parsed -> parsed.Value
        | :? (NotParsed<options>) as notParsed ->
            failwithf "Error %A" (notParsed.Errors)
        | _ -> failwith "No options given"
        
    System.Runtime.GCSettings.LatencyMode <- System.Runtime.GCLatencyMode.Batch
    let startTime = System.Diagnostics.Stopwatch.StartNew()
    let path = options.pathToSpecificationFile

    path
    |> parse
    |> ``typecheck, format and generate overloads``
    |> aggregateFunctionsAndEnums
    |> generateCode options.pathToOutputDirectory
    
    printfn "Generating files took %f seconds" startTime.Elapsed.TotalSeconds
    0 // return an integer exit code

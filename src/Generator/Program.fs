// Learn more about F// at http://fsharp.org
open Types
open SpecificationOpenGL
open Util
open Constants
open System.IO
open CommandLine

type options =
    { [<Option('i', "input", Required = true,
               HelpText = "Path to specification file.")>]
      pathToSpecificationFile: string
      [<Option('o', "output", Required = true,
               HelpText = "Path to output directory.")>]
      pathToOutputDirectory: string }

open Formatting

let autoGenerateAdditionalOverloadForType (func: PrintReadyTypedFunctionDeclaration) =
    let lengthParamsSet =
        func.parameters
        |> Array.choose(fun p -> p.lengthParamName)
        |> Set.ofArray

    let rec unwrapTyFromPointer ty =
        match ty with
        | Pointer ty -> unwrapTyFromPointer ty
        | _ -> ty
    let transformPointerTy i transform ty =
        let transformPointerTy ty =
            match ty with
            | Pointer(inner) ->
                let flattenedTy = unwrapTyFromPointer inner
                let res = flattenedTy |> transform
                if res = flattenedTy then ty
                else res
            | inner -> inner
        match ty with
        | Pointer(_) when unwrapTyFromPointer ty = Void ->
            let name = 
                ("T" + string i)
            let inner = name |> StructGenericType
            let res = inner |> transform 
            if res = inner then None, ty
            else Some name, res
        | _ -> None, transformPointerTy ty
    if lengthParamsSet.Count = 0 then [||]
    else
        let overloadWithMapping tyMapper =
            let adjustedParameters =
                func.parameters
                |> Array.mapi(fun i currParameter ->
                    maybe {
                        if lengthParamsSet.Contains currParameter.actualName then
                            let _, newParameterType =
                                currParameter.typ.typ
                                |> transformPointerTy i RefPointer
                            return! Some(None, { currParameter with typ = newParameterType |> PrintReady.formatTypeInfo })
                        else
                            let (genericName, newParameterType) =
                                currParameter.typ.typ 
                                |> transformPointerTy i tyMapper
                            return! Some(genericName, { currParameter with typ = newParameterType |> PrintReady.formatTypeInfo })
                    } |> Option.defaultValue (None, currParameter))
            let genericTypes = adjustedParameters |> Array.choose fst
            let parameters = adjustedParameters |> Array.map snd
            { func with
                genericTypes = genericTypes
                parameters = parameters }
        pointerTypeMappings
        |> Array.Parallel.map overloadWithMapping


let autoGenerateOverloadForType (func: PrintReadyTypedFunctionDeclaration) =
    let keep = func

    let injectTkTy ty adjustedName expectedPointerTy =
        let name = adjustedName |> formatNameRemovingPrefix

        let parameters =
            func.parameters
            |> Array.Parallel.map (fun param ->
                let typ =
                    match param.typ.typ with
                    | Pointer(currTy) when currTy = expectedPointerTy ->
                        ty
                        |> OpenToolkit
                        |> RefPointer
                    | ty -> ty
                { param with typ = typ |> PrintReady.formatTypeInfo })
        { func with
              parameters = parameters
              prettyName = name }
    // The order here is very important.
    // The longer sufixes are checked first before the shorter ones
    match func.actualName with
    | EndsWith "Matrix2fv" adjustedName ->
        injectTkTy (OpenToolkitType.Matrix2) (adjustedName + "Matrix") GLfloat
    | EndsWith "Matrix3fv" adjustedName ->
        injectTkTy (OpenToolkitType.Matrix3) (adjustedName + "Matrix") GLfloat
    | EndsWith "Matrix4fv" adjustedName ->
        injectTkTy (OpenToolkitType.Matrix4) (adjustedName + "Matrix") GLfloat
    | EndsWith "Matrix2dv" adjustedName ->
        injectTkTy (OpenToolkitType.Matrix2d) (adjustedName + "Matrix") GLdouble
    | EndsWith "Matrix3dv" adjustedName ->
        injectTkTy (OpenToolkitType.Matrix3d) (adjustedName + "Matrix") GLdouble
    | EndsWith "Matrix4dv" adjustedName ->
        injectTkTy (OpenToolkitType.Matrix4d) (adjustedName + "Matrix") GLdouble
    | EndsWith "udv" _ -> keep
    | EndsWith "2dv" adjustedName ->
        injectTkTy (OpenToolkitType.Vector2d) (adjustedName) GLdouble
    | EndsWith "3dv" adjustedName ->
        injectTkTy (OpenToolkitType.Vector3d) (adjustedName) GLdouble
    | EndsWith "4dv" adjustedName ->
        injectTkTy (OpenToolkitType.Vector4d) (adjustedName) GLdouble
    | EndsWith "ufv" _ -> keep
    | EndsWith "2fv" adjustedName ->
        injectTkTy (OpenToolkitType.Vector2) (adjustedName) GLfloat
    | EndsWith "3fv" adjustedName ->
        injectTkTy (OpenToolkitType.Vector3) (adjustedName) GLfloat
    | EndsWith "4fv" adjustedName ->
        injectTkTy (OpenToolkitType.Vector4) (adjustedName) GLfloat
    | _ -> keep

[<EntryPoint>]
let main argv =
    printfn
        "Hello World from F# and welcome to the OpenTK4.0 binding generator!"
    let result = CommandLine.Parser.Default.ParseArguments<options>(argv)

    let options =
        match result with
        | :? (Parsed<options>) as parsed -> parsed.Value
        | :? (NotParsed<options>) as notParsed ->
            failwithf "Error %A" (notParsed.Errors)
        | _ -> failwith "No options given"
    System.Runtime.GCSettings.LatencyMode <- System.Runtime.GCLatencyMode.SustainedLowLatency
    let startTime = System.Diagnostics.Stopwatch.StartNew()
    let path = options.pathToSpecificationFile
    let test = OpenGL_Specification.Load path
    let enums = Parsing.getEnumsFromSpecification test
    printfn "Enum group count: %d" enums.Length
    let enumMap =
        enums
        |> Array.Parallel.map (fun group -> group.groupName, group)
        |> Map.ofArray

    let functions = Parsing.getFunctions test
    printfn "Function count: %d" functions.Length
    let extensions = Parsing.getExtensions test
    printfn "Extension count: %d" extensions.Length
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

    let typecheckedFunctions =
        TypeMapping.looslyTypedFunctionsToTypedFunctions enumMap functions
        |> Array.Parallel.map
            Formatting.PrintReady.formatTypedFunctionDeclaration
        |> Array.Parallel.collect (fun func ->
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
                let res =
                    func |> autoGenerateOverloadForType
                res
                |> Array.singleton
                |> Array.append (autoGenerateAdditionalOverloadForType res)
                |> Array.distinct)

    let prettyEnumGroups =
        enums |> Array.Parallel.map Formatting.PrintReady.formatEnumGroup

    let prettyEnumGroupMap =
        prettyEnumGroups
        |> Array.Parallel.map (fun group -> group.groupName, group)
        |> Map.ofArray
    printfn "overall correct function specifications: %d"
        typecheckedFunctions.Length
    let openGlVersions = Aggregator.getEnumCasesAndCommandsPerVersion test
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
    let inline writeToFile pathToFile topic content =
        pathToFile
        |> Directory.CreateDirectory
        |> ignore
        let fileName = topic + ".cs"
        Directory.CreateDirectory pathToFile |> ignore
        File.WriteAllText(pathToFile </> fileName, content)
        pathToFile </> fileName
    let inline writeToFileSpec (openGl: RawOpenGLSpecificationDetails) topic content =
        let pathToFile = getPathForOpenGlVersion openGl
        writeToFile pathToFile topic content

    let writeCsProjFile content =
        let fileName = sprintf "OpenGL_Bindings.csproj"
        let fullPathToFile = basePath </> fileName
        File.WriteAllText(fullPathToFile, content)
    let typecheckedFunctionsExtensionsOnly =
        typecheckedFunctions
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
    

    [|  let path = basePath </> "Extensions"
        yield Formatting.generateEnums enumsWithExtensionsOnly (GenerateDetails.Extensions)
            |> writeToFile path "EnumsExtensionsOnly"

        yield Formatting.generateInterface typecheckedFunctionsExtensionsOnly (GenerateDetails.Extensions)
            |> writeToFile path "InterfaceExtensionsOnly"

        yield Formatting.generateStaticClass typecheckedFunctionsExtensionsOnly
                    (GenerateDetails.Extensions)
                        |> writeToFile path "StaticClassExtensionsOnly"

        yield Formatting.generateLibraryLoaderFor (GenerateDetails.Extensions)
            |> writeToFile path "LibraryLoaderExtensionsOnly" |]
    |> ignore
    openGlVersions
    |> Array.Parallel.collect (fun glVersion ->
        let inline writeToFile topic content =
            writeToFileSpec glVersion topic content
        let typecheckedFunctionsWithoutExtensions =
            typecheckedFunctions
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
                

        let generatedFiles =
            [| yield Formatting.generateEnums enumsWithoutExtensions (GenerateDetails.OpenGlVersion glVersion)
                    |> writeToFile "EnumsWithoutExtensions"

               yield Formatting.generateInterface typecheckedFunctionsWithoutExtensions (GenerateDetails.OpenGlVersion glVersion)
                    |> writeToFile "InterfaceWithoutExtensions"

               yield Formatting.generateStaticClass typecheckedFunctionsWithoutExtensions
                         (GenerateDetails.OpenGlVersion glVersion)
                                |> writeToFile "StaticClassWithoutExtensions"

               yield Formatting.generateLibraryLoaderFor (GenerateDetails.OpenGlVersion glVersion)
                    |> writeToFile "LibraryLoaderWithoutExtensions" |]

        printfn "Done writing OpenGL Version %s files." glVersion.version
        generatedFiles)
    |> ignore
    printfn "Generating files took %s seconds"
        (startTime.Elapsed.Seconds |> string)
    0 // return an integer exit code

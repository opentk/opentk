module Aggregator

open Types
open Util
open SpecificationOpenGL

// Generically take the field name
let inline nameField a = (^a: (member Name: string) (a))

let inline parallelCollectId a b =
    Array.Parallel.collect id a, Array.Parallel.collect id b

// This function aggregates each OpenGL version as the functions and enums
// per version are not represented in a snapshot, they are represented by
// required and remove statements which is very the same to an Event UpdateStore.
// Therefor this function begins with the first version collecting all initial functions
// and enum cases. Afterwards it aggregates each version
// *incrementally* based on the *prior* version.
let getEnumCasesAndCommandsPerVersion (data: OpenGL_Specification.Registry) =
    let featuresSortedAscendingByVersion =
        data.Features |> Array.sortBy (fun data -> data.Number)
    let versions =
        featuresSortedAscendingByVersion
        |> Array.Parallel.map (fun data -> data.Name)
    let resultsByVersion = Array.zeroCreate versions.Length
    let aggregatedResultByVersion = Array.zeroCreate versions.Length
    let getVersionBefore index = aggregatedResultByVersion.[index - 1]

    let extractAddedAndRemoved (data: OpenGL_Specification.Feature) =
        let inline divideIntoCommandsAndEnums cmd enum e =
            [| Choice1Of2(cmd e |> Array.Parallel.map nameField)
               Choice2Of2(enum e |> Array.Parallel.map nameField) |]

        let (addedFunctions: string [], addedEnums: string []) =
            data.Requires
            |> Array.Parallel.collectEither
                (divideIntoCommandsAndEnums
                    (fun (e: OpenGL_Specification.Require) -> e.Commands)
                        (fun (e: OpenGL_Specification.Require) -> e.Enums))
            ||> parallelCollectId

        let removedFunctions, removedEnums =
            data.Removes
            |> Array.Parallel.collectEither
                (divideIntoCommandsAndEnums
                    (fun (e: OpenGL_Specification.Remove) -> e.Commands)
                        (fun (e: OpenGL_Specification.Remove) -> e.Enums))
            ||> parallelCollectId

        {| addedFunctions = addedFunctions
           addedEnums = addedEnums
           removedFunctions = removedFunctions
           removedEnums = removedEnums |}

    let extractAddedAndRemovedAndSaveBack index =
        let data = featuresSortedAscendingByVersion.[index]
        let res = extractAddedAndRemoved data
        resultsByVersion.[index] <- res
        res

    let startIndex = 0
    let res = extractAddedAndRemovedAndSaveBack startIndex
    aggregatedResultByVersion.[startIndex] <- {| functions = res.addedFunctions
                                                 enumCases = res.addedEnums |}
    let rec aggregateFunctions index =
        if index < featuresSortedAscendingByVersion.Length then
            let res = extractAddedAndRemovedAndSaveBack index
            let removedFunctionsSet = res.removedFunctions |> Set.ofArray
            let removedEnumCasesSet = res.removedEnums |> Set.ofArray
            let versionBefore = getVersionBefore index
            let functions =
                versionBefore.functions
                |> Array.Parallel.updateState res.addedFunctions
                       removedFunctionsSet
            let enumCases =
                versionBefore.enumCases
                |> Array.Parallel.updateState res.addedEnums removedEnumCasesSet
            aggregatedResultByVersion.[index] <- {| functions = functions
                                                    enumCases = enumCases |}
            aggregateFunctions (index + 1)
    aggregateFunctions 1
    Array.Parallel.init (versions.Length) <| fun i ->
        let curr = aggregatedResultByVersion.[i]
        { version = versions.[i] |> string
          versionNumber = featuresSortedAscendingByVersion.[i].Number
          functions = curr.functions |> Set
          enumCases = curr.enumCases |> Set }: RawOpenGLSpecificationDetails
    |> Array.groupBy (fun info -> info.version)
    |> Array.map (fun (version, infos) -> infos |> Array.last)

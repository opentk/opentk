module Aggregator
open Types
open Util
open SpecificationOpenGL
open System

let getEnumCasesAndCommandsPerVersion (data: OpenGL_Specification.Registry) =
    let featuresSortedAscendingByVersion = 
        data.Features
        |> Array.sortBy(fun data -> data.Number)
    let versions =
        featuresSortedAscendingByVersion
        |> Array.Parallel.map(fun data -> data.Name)
    let resultsByVersion = Array.zeroCreate versions.Length
    let aggregatedResultByVersion = Array.zeroCreate versions.Length
    let getVersionBefore index = aggregatedResultByVersion.[index - 1]

    let extractAddedAndRemoved(data: OpenGL_Specification.Feature) =
        let (addedFunctions: string[], addedEnums : string[]) =
            let a, b =
                data.Requires
                |> Array.Parallel.collectEither(fun e ->
                    [| Left(e.Commands |> Array.Parallel.map(fun inner ->
                        let res = inner.Name
                        if res |> String.IsNullOrEmpty then failwith "unallowed"
                        else res))
                       Right(e.Enums |> Array.Parallel.map(fun e -> 
                           let res = e.Name
                           if res |> String.IsNullOrEmpty then failwith "unallowed"
                           else res)) |])
            a |> Array.Parallel.collect id, b |> Array.Parallel.collect id
        let removedFunctions, removedEnums =
            let a, b =
                data.Removes
                |> Array.Parallel.collectEither(fun e ->
                    [| Left(e.Commands |> Array.Parallel.map(fun inner -> inner.Name))
                       Right(e.Enums |> Array.Parallel.map(fun e -> e.Name)) |])
            a |> Array.Parallel.collect id, b |> Array.Parallel.collect id
        
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
    aggregatedResultByVersion.[startIndex] <-
        {| functions = res.addedFunctions
           enumCases = res.addedEnums |}

    let rec aggregateFunctions index =
        if index < featuresSortedAscendingByVersion.Length then
            let res = extractAddedAndRemovedAndSaveBack index
            let removedFunctionsSet = res.removedFunctions |> Set.ofArray
            let removedEnumCasesSet = res.removedEnums |> Set.ofArray
            let versionBefore = getVersionBefore index
            let functions =
                versionBefore.functions
                |> Array.Parallel.updateState
                    res.addedFunctions
                    removedFunctionsSet
            let enumCases =
                versionBefore.enumCases
                |> Array.Parallel.updateState
                    res.addedEnums
                    removedEnumCasesSet
            aggregatedResultByVersion.[index] <-
                {| functions = functions
                   enumCases = enumCases |}
            aggregateFunctions (index + 1)

    aggregateFunctions 1
    Array.Parallel.init (versions.Length) <| fun i ->
        let curr = aggregatedResultByVersion.[i]
        { version = versions.[i] |> string
          versionNumber = featuresSortedAscendingByVersion.[i].Number
          functions = curr.functions |> Set
          enumCases = curr.enumCases |> Set } : RawOpenGLSpecificationDetails
    |> Array.groupBy(fun info -> info.version)
    |> Array.map(fun (version, infos) ->
        infos |> Array.last
    )
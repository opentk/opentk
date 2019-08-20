module Util

let inline (</>) path1 path2 = System.IO.Path.Combine(path1, path2)

type MaybeBuilder() =
    member __.Bind(v, fn) = Option.bind fn v
    member __.ReturnFrom v = v

let maybe = MaybeBuilder()

module String =
    let firstToUpper (str: string) =
        if str |> System.String.IsNullOrEmpty |> not then
            if str.Length = 1 then str.ToUpper()
            else
                let upper = System.Char.ToUpper <| str.Chars(0)
                upper.ToString() + str.Substring(1).ToLower()
        else ""

module Array =
    module Parallel =
        let partitionChoice f (input: 'T []) =
            let inputLength = input.Length
            let isLeft: bool [] = Array.zeroCreate inputLength
            let left: 'U [] = Array.zeroCreate inputLength
            let right: 'V [] = Array.zeroCreate inputLength
            input
            |> Array.Parallel.iteri (fun i e ->
                match f e with
                | Choice1Of2 v ->
                    isLeft.[i] <- true
                    left.[i] <- v
                | Choice2Of2 v ->
                    isLeft.[i] <- false
                    right.[i] <- v)
            let mutable leftCount = 0
            for i = 0 to isLeft.Length - 1 do
                if isLeft.[i] then leftCount <- leftCount + 1
            let rightCount = inputLength - leftCount

            let leftOutput =
                if leftCount = 0 then Array.empty
                else Array.zeroCreate leftCount

            let rightOutput =
                if rightCount = 0 then Array.empty
                else Array.zeroCreate rightCount

            let mutable leftCounter = 0
            let mutable rightCounter = 0
            for i in 0..(inputLength - 1) do
                if isLeft.[i] then
                    leftOutput.[leftCounter] <- left.[i]
                    leftCounter <- leftCounter + 1
                else
                    rightOutput.[rightCounter] <- right.[i]
                    rightCounter <- rightCounter + 1
            leftOutput, rightOutput

        let collectEither (f: 'T -> Choice<'U, 'V> []) (input: 'T []) =
            input
            |> Array.Parallel.collect f
            |> partitionChoice id

        let updateState toAdd toRemove currentState =
            currentState
            |> Array.Parallel.choose (fun fName ->
                if toRemove |> Set.contains fName then None
                else Some fName)
            |> Array.append toAdd

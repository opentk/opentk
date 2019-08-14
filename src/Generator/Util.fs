module Util
open Types

type MaybeBuilder() =
    member __.Bind(v, fn) = Option.bind fn v

    member __.ReturnFrom v = v


let maybe = MaybeBuilder()

module Array =

    module Parallel =
        let partitionEither f (input: 'T[]) =
            let inputLength = input.Length                

            let isLeft : bool [] = Array.zeroCreate inputLength
            let left: 'U [] = Array.zeroCreate inputLength
            let right: 'V [] = Array.zeroCreate inputLength
            
            input
            |> Array.Parallel.iteri(fun i e -> 
                match f e with 
                | Left v ->
                    isLeft.[i] <- true
                    left.[i] <- v
                | Right v -> 
                    isLeft.[i] <- false
                    right.[i] <- v
            )
                                                                                  
            let mutable leftCount = 0
            for i = 0 to isLeft.Length-1 do 
                if isLeft.[i] then
                    leftCount <- leftCount + 1
            let rightCount = inputLength - leftCount
            let leftOutput = Array.zeroCreate leftCount
            let rightOutput = Array.zeroCreate rightCount
            input
            |> Array.Parallel.iteri(fun i e ->
                if isLeft.[i] then
                    leftOutput.[i] <- left.[i]
                else
                    rightOutput.[i] <- right.[i]
            )
            leftOutput, rightOutput

        let collectEither (f: 'T -> Either<'U, 'V>[]) (input: 'T[]) =
            input
            |> Array.Parallel.collect f
            |> partitionEither id
            
        let updateState toAdd toRemove currentState =
            currentState
            |> Array.Parallel.choose(fun fName ->
                if toRemove |> Set.contains fName then None
                else Some fName)
            |> Array.append toAdd

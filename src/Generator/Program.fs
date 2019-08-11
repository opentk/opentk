// Learn more about F# at http://fsharp.org

open System
open Types

type MaybeBuilder() =
    member __.Bind(v, fn) = Option.bind fn v

    member __.ReturnFrom v = v


let maybe = MaybeBuilder()

let readSpec (path:string) = Types.OpenGL_Specification.Load path

let getEnumsFromSpecification (spec: Types.OpenGL_Specification.Registry) =
    let valueForName =
        spec.Enums
        |> Array.Parallel.collect(fun e ->
            e.Enums
            |> Array.Parallel.choose(fun case ->
                case.Value.String
                |> Option.map(fun value -> (case.Name, value))
            )
        )
        |> Map.ofArray

    spec.Groups
    |> Array.Parallel.choose(fun e ->
        maybe {
            let group = e.Name
            let cases =
                e.Enums
                |> Array.Parallel.choose(fun case ->
                    valueForName
                    |> Map.tryFind case.Name
                    |> Option.map(fun value ->
                        { name = case.Name
                          value =  value })
                )
            let res =
                { groupName = group
                  cases = cases }
            return! Some res
        }
    )

open System.Text.RegularExpressions
let paramsTypeRegex = new Regex("<param(.*?(group=\"(?<group>.*?)\").*?|.*?)>(?<f>.*?)(<ptype>(?<t>.*?)<\/ptype>(?<b>.*?))?(<name>.+?<\/name>)<\/param>")
let protoTypeRegex = new Regex("<proto(.*?(group=\"(?<group>.*?)\").*?|.*?)>(?<f>.*?)(<ptype>(?<t>.*?)<\/ptype>(?<b>.*?))?(<name>.+?<\/name>)<\/proto>")
let getGroupValue (group: string) (matching: Match) =
    matching.Groups.[group].Value

let getRawElementDataWithoutLineBreaks (v: Xml.Linq.XElement) =
    v.ToString().Replace("\n", "").Replace("\t", "").Replace("\r", "")

let extractTypeFromPtype (param: Types.OpenGL_Specification.Param) =
    let str = getRawElementDataWithoutLineBreaks param.XElement
    let res = paramsTypeRegex.Match str
    let groupName =
        let str = getGroupValue "group" res
        if str |> String.IsNullOrWhiteSpace then None
        else Some str
    let ty =
        getGroupValue "f" res +
        getGroupValue "t" res +
        getGroupValue "b" res
    groupName, ty

let extractTypeFromProto (proto: Types.OpenGL_Specification.Proto) =
    let str = getRawElementDataWithoutLineBreaks proto.XElement
    let res = protoTypeRegex.Match str
    let groupName =
        let str = getGroupValue "group" res
        if str |> String.IsNullOrWhiteSpace then None
        else Some str
    let ty =
        getGroupValue "f" res +
        getGroupValue "t" res +
        getGroupValue "b" res
    groupName, ty

let getFunctions (spec: Types.OpenGL_Specification.Registry) =
    spec.Commands.Commands
    |> Array.Parallel.map(fun cmd ->
        //let isInvalid =
        //    cmd.Params |> Array.exists(fun p -> p.Ptype |> Option.isNone)
        //    || Option.isNone cmd.Proto.Ptype 
        //if isInvalid then
        //    printfn "Function specification %A is invalid" cmd.Proto.Name
        //    cmd.Params |> Seq.iter (fun p -> printfn "%A" p.XElement.Value)
        //    None
        //else
            let funcName = cmd.Proto.Name
            let parameters =
                cmd.Params
                |> Array.Parallel.map(fun p ->
                    let group, ty = extractTypeFromPtype p
                    if String.IsNullOrWhiteSpace ty then
                        let str = p.XElement.ToString()
                        printfn "failed parsing %A, value: %s" (funcName) str
                    { paramName = p.Name
                      paramType = looseType ty group }
                )
            let group, ty = extractTypeFromProto cmd.Proto
            let ret =
                { funcName = funcName 
                  parameters = parameters
                  retType = looseType ty group }
            ret
    )

let looslyTypedFunctionsToTypedFunctions enumMap functions =
    let typecheckParams parameters =
        let len = (parameters |> Array.length)
        let res = Array.zeroCreate len
        let rec typecheck index =
            if index < len then
                let currParam = parameters.[index]
                match currParam.paramType |> Parsing.tryParseType enumMap currParam.paramName with
                | Some ty ->
                    res.[index] <-
                        typedParameterInfo
                            currParam.paramName
                            ty
                    typecheck (index + 1)
                | None -> false
            else true
        if typecheck 0 then Some res
        else None

    functions
    |> Array.Parallel.choose(fun func ->
        maybe {
            let! retType = func.retType |> Parsing.tryParseType enumMap func.funcName
            let! parameters =
                func.parameters
                |> typecheckParams
            let res =
                typedFunctionDeclaration
                    func.funcName
                    parameters
                    retType
            return!
                Some res
        }
    )

open System.IO

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let path = @"D:\repos\opentk\src\Generator\gl.xml"
    let test = Types.OpenGL_Specification.Load path
    let enums = getEnumsFromSpecification test
    printfn "Enum group count: %d" enums.Length
    let enumMap =
        enums
        |> Array.Parallel.map(fun group ->
            group.groupName, group
        )
        |> Map.ofArray
    //enums
    //|> Seq.iter(fun enum ->
    //    printfn "-- enum group name: %A --" enum.groupName
    //    enum.cases
    //    |> Seq.iter(fun case ->
    //        printfn "case %A, value %A" case.name case.value
    //    )
    //    printfn "----"
    //)
    let functions = getFunctions test
    printfn "Function count: %d" functions.Length
    use writer = new StringWriter()
    functions
    |> Seq.iter(fun func ->
        sprintf "-- func %A --" func.funcName
        |> writer.WriteLine
        func.parameters
        |> Seq.iteri(fun i p ->
            sprintf "parameter %d, name: %A, type: %A" i p.paramName p.paramType
            |> writer.WriteLine
        )
        writer.WriteLine "-----"
    )
    writer.Flush()
    File.WriteAllText("./functions.txt", writer.ToString())
    let possibleTypes =
        functions
        |> Array.Parallel.collect(fun func ->
            func.parameters
            |> Array.Parallel.map(fun p -> p.paramType)
        )
        |> Set.ofArray
    //for possibleType in possibleTypes do
    //    printfn "%A" possibleType
    let checkedTypes =
        possibleTypes
        |> Set.map(fun v -> v, Parsing.tryParseType enumMap "<unknown>" v)
    //for possibleType in checkedTypes do
    //    printfn "%A" possibleType
    let typecheckedFunctions = looslyTypedFunctionsToTypedFunctions enumMap functions
    printfn "overall correct function specifications: %d" typecheckedFunctions.Length
    //for func in typecheckedFunctions |> Array.take 100 do
    //    printfn "%A" func

    0 // return an integer exit code

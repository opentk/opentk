namespace OpenToolkit.Tests

open System
open System
open System.IO
open System.Reflection

/// This module is responsible for comparing and checking the API surface difference between 3.x and 4.x.
///
/// We target net472 for this, as both OpenTK 3.x and 4.0 (via netstandard) run correctly, allowing us to compare the two.
module GraphicsAPITest =
        
    let levenshteinDistance source target =
        let sourceLen = String.length source
        let targetLen = String.length target
        let distance = Array2D.zeroCreate<int> (sourceLen + 1) (targetLen + 1)
        Array2D.iteri (fun i _ _ -> distance.[i,0] <- i) distance |> ignore
        Array2D.iteri (fun _ j _ -> distance.[0,j] <- j) distance |> ignore
        for i in 1..sourceLen do
             for j in 1..targetLen do
                let cost = if target.[j - 1] = source.[i - 1] then 0
                           else 1
                distance.[i,j] <- min (min (distance.[i - 1, j] + 1) (distance.[i, j - 1] + 1))
                                      distance.[i - 1, j - 1] + cost
        distance.[sourceLen, targetLen]
        
    /// [0;1]
    let similarity source target =
        let dist = levenshteinDistance source target
        (1.0f - (float32 dist / float32 (max source.Length target.Length)))
    
    let findGraphicsMethods(t:Type) =
        t.GetMethods(BindingFlags.Public ||| BindingFlags.Static)
        |> Array.sortBy (fun m -> m.Name)
    
    type MethodDiff =
        | MethodName of string * string
        | ParameterCount of int * int
        | ParameterType of idx:int * string * string
        | ParameterName of idx:int * string * string
        
        
    let forcedEquivalenceTable =
        let baseTypes = [|
            typeof<UInt32>, typeof<Int32>
            typeof<UIntPtr>, typeof<IntPtr>
            |]
            
        let mkPointerTypes (a:Type,b:Type) =
            [|
                a, b
                a.MakePointerType(), b.MakePointerType()
                a.MakePointerType().MakePointerType(), b.MakePointerType().MakePointerType()
                a.MakeByRefType(), b.MakeByRefType()
            |]
            
            
        baseTypes |> Array.collect mkPointerTypes
            
        
    let areTypesEquivalent (a:Type) (b:Type) =
        if a.Name = b.Name then
            true
        else
            forcedEquivalenceTable |> Array.exists (fun (x,y) -> a = x && b = y || a = y && b = x)
        

    let diff(a:MethodInfo) (b:MethodInfo) =
        [
        if a.Name <> b.Name then
            yield MethodName (a.Name, b.Name)
        else
            let aps = a.GetParameters()
            let bps = b.GetParameters()
            if aps.Length <> bps.Length then
                yield ParameterCount(aps.Length, bps.Length)
            else    
                for i = 0 to aps.Length - 1 do
                    let ap = aps.[i] 
                    let bp = bps.[i]
                    if not (areTypesEquivalent ap.ParameterType bp.ParameterType) then
                        yield ParameterType(i, ap.ParameterType.Name, bp.ParameterType.Name)
                    
                    if ap.Name <> bp.Name then
                        yield ParameterType(i, ap.Name, bp.Name)
        ]
        
    let scoreDiff d = 
        match d with
        | MethodName _ -> 1000.0f
        | ParameterCount _ -> 100.0f
        | ParameterType (_, a, b) -> 10.0f * (similarity a b)
        | ParameterName (_, a, b) -> 1.0f * (similarity a b)
        
    type MethodMatch =
        {
        Legacy: MethodInfo
        Nearest: MethodInfo
        Diff: MethodDiff list
        Score: float32
        }
        
                    
    [<EntryPoint>]
    let main _ =
        
        
        printfn "---------------------"
        printfn "Legacy API Diff Tool"
        printfn "---------------------"

        
        use writer = new StreamWriter("difflog.txt")
        let wprintfn x = Printf.kprintf (writer.WriteLine) x
        
        let legacyApi = findGraphicsMethods typeof<OpenTK.Graphics.OpenGL4.GL> |> Array.sortBy (fun m -> m.Name)
        let newApi = findGraphicsMethods typeof<OpenToolkit.Graphics.GL46.GL>
        
        let findBestMatch (m:MethodInfo) =
            let diffToScore o =
                let diffs = diff m o
                { Legacy = m
                  Nearest = o
                  Diff = diffs
                  Score = diffs |> List.sumBy scoreDiff }
            
            newApi |> Array.map diffToScore
            |> Array.sortBy (fun m -> m.Score)
            |> Array.head
            
        
        let matches =
            legacyApi
            |> Array.map (fun lm -> findBestMatch lm)
            |> Array.sortByDescending (fun m -> m.Score)
            
        
        for m in matches do
            if m.Score > 0.0f then
                wprintfn ""
                wprintfn "Method %A is missing in new API." m.Legacy
                if m.Score < 1000.0f then
                    wprintfn "Nearest match is %A" m.Nearest
                    wprintfn "Diff:"
                    for d in m.Diff do
                        wprintfn "\t%A" d
                    
        let matches, notMatches = matches |> Array.partition (fun m -> m.Score <= 0.0f)
        writer.Flush()
        printfn "match count: %d" (matches.Length)
        printfn "mismatch count: %d" (notMatches.Length)
        printfn "Log location: %s" (Path.GetFullPath "difflog.txt") 
        printfn "Press enter to exit..."
        Console.ReadLine() |> ignore
        0

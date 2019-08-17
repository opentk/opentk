module Constants
open Types

let additionalTypesToGenerate =
    [|
        { _namespace = Some "OpenToolkit.Mathematics"; name = "Half" }
        { _namespace = None; name = "DebugProc" }
        { _namespace = None; name = "DebugProcAmd" }
        { _namespace = None; name = "DebugProcArb" }
        { _namespace = None; name = "DebugProcKhr" }
        { _namespace = None; name = "Struct_cl_context" }
        { _namespace = None; name = "Struct_cl_event" }
        { _namespace = None; name = "ElementPointerTypeATI" }
        { _namespace = None; name = "CombinerPortionNV" }
        { _namespace = None; name = "FragmentLightParameterSGIX" }
        { _namespace = None; name = "MapTypeNV" }
        { _namespace = None; name = "ProgramTarget" }
        { _namespace = None; name = "ProgramStringProperty" }
        { _namespace = None; name = "IglooFunctionSelectSGIX" }
        { _namespace = None; name = "IndexFunctionEXT" }
        { _namespace = None; name = "ProgramFormat" }
        { _namespace = None; name = "MatrixIndexPointerTypeARB" }
        { _namespace = None; name = "ReplacementCodeTypeSUN" }
        { _namespace = None; name = "SecondaryColorPointerTypeIBM" }
        { _namespace = None; name = "VertexWeightPointerTypeEXT" }
        { _namespace = None; name = "WeightPointerTypeARB" }
        { _namespace = None; name = "VertexShaderWriteMaskEXT" }
    |] |> Set.ofArray |> Set.toArray

let reservedKeywords = 
    [|
        "ref"
        "object"
        "string"
        "event"
        "params"
        "base"
        "in"
    |]

let graphicsNamespace = "OpenToolkit.Graphics"
    
let dummyTypesFileName = "DummyTypes"

let advancedDlSupport = "AdvancedDLSupport"

let dummyTypesNamespace = graphicsNamespace + "." + "GL"

let prefixToRemove =
    [|
        "gl"
    |]

let reservedKeywordsUpper =
    reservedKeywords
    |> Array.Parallel.map(fun k -> k.ToUpper())
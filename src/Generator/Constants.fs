module Constants

open Types

let additionalTypesToGenerate =
    [|
      "DebugProcAmd"
      "DebugProcArb"
      "DebugProcKhr"
      "Struct_cl_context"
      "Struct_cl_event"
      "ElementPointerTypeATI"
      "CombinerPortionNV"
      "FragmentLightParameterSGIX"
      "MapTypeNV"
      "ProgramTarget"
      "ProgramStringProperty"
      "IglooFunctionSelectSGIX"
      "IndexFunctionEXT"
      "ProgramFormat"
      "MatrixIndexPointerTypeARB"
      "ReplacementCodeTypeSUN"
      "SecondaryColorPointerTypeIBM"
      "VertexWeightPointerTypeEXT"
      "WeightPointerTypeARB"
      "VertexShaderWriteMaskEXT"
    |]
    |> Array.map (fun n -> { _namespace = None; name = n })
    |> Set.ofArray

let reservedKeywords =
    [| "ref"; "object"; "string"; "event"; "params"; "base"; "in" |]
let graphicsNamespace = "OpenTK.Graphics"
let dummyTypesFileName = "DummyTypes"
let advancedDlSupport = "AdvancedDLSupport"
let mathematicsNamespace = "OpenTK.Mathematics"
let dummyTypesNamespace = graphicsNamespace + "." + "GL"
let prefixToRemove = [| "gl"; "GL_" |]
let sufixToRemove =
    [| "1"; "2"; "3"; "4"; "fv"; "ubv"; "u"; "uiv"; "ui"; "usv"; "us"; "i"; "iv";
       "f"; "b"; "d"; "dv"; "s"; "sv"; "ub"; "v" |]
    |> Array.sortByDescending (fun s -> s.Length)
let reservedKeywordsUpper =
    reservedKeywords |> Array.map (fun k -> k.ToUpper())

let pointerTypeMappings =
    [| RefPointer; ArrayType; (function | GLint -> GLintptr | keep -> keep) |]

let functionOverloads =
    let dummyEnumGroupTy name =
        { groupName = name
          cases = Array.empty }
        |> GLenum

    [| 
       functionOverloadsWith "glGetQueryBufferObjecti64v"
           "GetQueryBufferObjecti64v"
           [| functionSignature Void
                  [| typedParameterInfo "id" GLuint
                     typedParameterInfo "buffer" GLuint

                     dummyEnumGroupTy "QueryObjectParameterName"
                     |> typedParameterInfo "pname"
                     typedParameterInfo "offset" GLintptr |] |]
       functionOverloadsWith "glGetQueryBufferObjectv" "GetQueryBufferObjectv"
           [| functionSignature Void
                  [| typedParameterInfo "id" GLuint
                     typedParameterInfo "buffer" GLuint

                     dummyEnumGroupTy "QueryObjectParameterName"
                     |> typedParameterInfo "pname"
                     typedParameterInfo "offset" GLintptr |] |]
       functionOverloadsWith "glGetQueryBufferObjectui64v"
           "GetQueryBufferObjectui64v"
           [| functionSignature Void
                  [| typedParameterInfo "id" GLuint
                     typedParameterInfo "buffer" GLuint

                     dummyEnumGroupTy "QueryObjectParameterName"
                     |> typedParameterInfo "pname"
                     typedParameterInfo "offset" GLintptr |] |]
       functionOverloadsWith "glGetQueryBufferObjectuiv"
           "GetQueryBufferObjectuiv"
           [| functionSignature Void
                  [| typedParameterInfo "id" GLuint
                     typedParameterInfo "buffer" GLuint

                     dummyEnumGroupTy "QueryObjectParameterName"
                     |> typedParameterInfo "pname"
                     typedParameterInfo "offset" GLintptr |] |] |]
    |> Array.Parallel.map (fun overload -> overload.expectedName, overload)
    |> Map.ofArray

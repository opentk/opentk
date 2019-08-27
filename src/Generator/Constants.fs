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
let graphicsNamespace = "OpenToolkit.Graphics"
let dummyTypesFileName = "DummyTypes"
let advancedDlSupport = "AdvancedDLSupport"
let openTKCoreNamespace = "OpenToolkit.Core"
let mathematicsNamespace = "OpenToolkit.Mathematics"
let dummyTypesNamespace = graphicsNamespace + "." + "GL"
let prefixToRemove = [| "gl"; "GL_" |]

let rec getBaseGLType t =
    match t with
    | Pointer(s) -> getBaseGLType s
    | RefPointer(s) -> getBaseGLType s
    | ArrayType(s) -> getBaseGLType s
    | _ -> t 
let sufixToRemove =
    [| ("1", fun (_ : PrintReadyTypedFunctionDeclaration) -> true);
       ("2", fun _ -> true);
       ("3", fun _ -> true);
       ("4", fun _ -> true);
       ("fv", fun _ -> true);
       ("ubv", fun _ -> true);
       ("u", fun _ -> true);
       ("uiv", fun _ -> true);
       ("ui", fun _ -> true);
       ("usv", fun _ -> true);
       ("us", fun d -> (Array.exists (fun (p : PrintReadyTypedParameterInfo) -> (getBaseGLType p.typ.typ) = GLType.GLushort) d.parameters ));
       ("i", fun _ -> true);
       ("iv", fun _ -> true);
       ("f", fun _ -> true);
       ("b", fun _ -> true);
       ("d", fun _ -> true);
       ("dv", fun _ -> true);
       ("s", fun d -> (Array.exists (fun (p : PrintReadyTypedParameterInfo) -> (getBaseGLType p.typ.typ) = GLType.GLshort) d.parameters ));
       ("sv", fun _ -> true);
       ("ub", fun _ -> true);
       ("v", fun _ -> true)
       |]
    |> Array.sortByDescending (fun (s,f) -> s.Length)

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

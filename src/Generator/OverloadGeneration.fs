module OverloadGeneration
open Formatting
open Types
open Constants


let autoGenerateAdditionalOverloadForType (func: PrintReadyTypedFunctionDeclaration) =
    let lengthParamsSet =
        func.parameters
        |> Array.choose(fun p -> p.lengthParamName)
        |> Set.ofArray

    let rec unwrapTyFromPointer typ =
        match typ with
        | Pointer typ -> unwrapTyFromPointer typ
        | _ -> typ
    let transformPointerTy i transformGLTypeFun typ =
        let transformPointerTy typ =
            match typ with
            | Pointer(inner) ->
                let flattenedTy = unwrapTyFromPointer inner
                let res = flattenedTy |> transformGLTypeFun
                if res = flattenedTy then typ
                else res
            | inner -> inner
        match typ with
        | Pointer(GLchar) ->
            None, GLString
        | Pointer(Pointer(GLchar)) ->
            None, GLString |> ArrayType
        | Pointer(_) when unwrapTyFromPointer typ = Void ->
            let name = 
                ("TElement" + string i)
            let inner = name |> StructGenericType
            let res = inner |> transformGLTypeFun 
            if res = inner then None, typ
            else Some name, res
        | _ -> None, transformPointerTy typ
    if lengthParamsSet.Count = 0 then
        let adjustedParameters =
            func.parameters
            |> Array.map(fun currParameter ->
                match currParameter.typ.typ with
                | Pointer(GLchar) ->
                    { currParameter with
                        PrintReadyTypedParameterInfo.typ = GLString |> PrintReady.formatTypeInfo }
                | Pointer(Pointer(GLchar)) ->
                    { currParameter with
                        PrintReadyTypedParameterInfo.typ = GLString |> ArrayType |> PrintReady.formatTypeInfo }
                | _ -> currParameter)
        { func with parameters = adjustedParameters } |> Array.singleton
    else
        let overloadWithMapping tyMapper =
            // Easiest solution to get
            // incrementing generic type parameter names.
            let mutable i = 1
            let adjustedParameters =
                func.parameters
                |> Array.map(fun currParameter ->
                    if lengthParamsSet.Contains currParameter.actualName then
                        let _, newParameterType =
                            currParameter.typ.typ
                            |> transformPointerTy 0 RefPointer
                        None, { currParameter with typ = newParameterType |> PrintReady.formatTypeInfo }
                    else
                        let (genericName, newParameterType) =
                            currParameter.typ.typ 
                            |> transformPointerTy i tyMapper
                        // Yes this is a bit evil, I'm sorry but this was easiest here.
                        // without hurting performance.
                        genericName |> Option.iter(fun _ -> i <- i + 1)
                        genericName, { currParameter with typ = newParameterType |> PrintReady.formatTypeInfo })
            let genericTypes = adjustedParameters |> Array.choose fst
            let parameters = adjustedParameters |> Array.map snd
            { func with
                genericTypes = genericTypes
                parameters = parameters }
        pointerTypeMappings
        |> Array.Parallel.map overloadWithMapping

let autoGenerateOverloadForType (func: PrintReadyTypedFunctionDeclaration) =
    let keep = func

    let injectTkType typ adjustedName expectedPointerTy =
        let name = adjustedName |> formatNameRemovingPrefix

        let parameters =
            func.parameters
            |> Array.Parallel.map (fun param ->
                let typ =
                    match param.typ.typ with
                    | Pointer(currTy) when currTy = expectedPointerTy ->
                        typ
                        |> OpenTK
                        |> RefPointer
                    | typ -> typ
                { param with typ = typ |> PrintReady.formatTypeInfo })
        // This is definitely no candidate for the pointers
        Some adjustedName,
        { func with
              parameters = parameters
              prettyName = name }

    let (|EndsWithOneOf|_|) suffixes name =
        suffixes
        |> Array.tryPick(fun suffix ->
            match name with
            | EndsWith suffix adjustedName -> Some adjustedName
            | _ -> None
        )

    // The order here is very important.
    // The longer sufixes are checked first before the shorter ones

    match func.prettyName with
    // Matrix and Vector mappings
    | EndsWith "Matrix2fv" adjustedName -> injectTkType (OpenTKType.Matrix2) (adjustedName + "Matrix2") GLfloat
    | EndsWith "Matrix3fv" adjustedName -> injectTkType (OpenTKType.Matrix3) (adjustedName + "Matrix3") GLfloat
    | EndsWith "Matrix4fv" adjustedName -> injectTkType (OpenTKType.Matrix4) (adjustedName + "Matrix4") GLfloat
    | EndsWith "Matrix2dv" adjustedName -> injectTkType (OpenTKType.Matrix2d) (adjustedName + "Matrix2") GLdouble
    | EndsWith "Matrix3dv" adjustedName -> injectTkType (OpenTKType.Matrix3d) (adjustedName + "Matrix3") GLdouble
    | EndsWith "Matrix4dv" adjustedName -> injectTkType (OpenTKType.Matrix4d) (adjustedName + "Matrix4") GLdouble
    | EndsWith "Matrix2x3fv" adjustedName -> injectTkType (OpenTKType.Matrix2x3) (adjustedName + "Matrix2x3") GLfloat
    | EndsWith "Matrix2x4fv" adjustedName -> injectTkType (OpenTKType.Matrix2x4) (adjustedName + "Matrix2x4") GLfloat
    | EndsWith "Matrix3x2fv" adjustedName -> injectTkType (OpenTKType.Matrix3x2) (adjustedName + "Matrix3x2") GLfloat
    | EndsWith "Matrix3x4fv" adjustedName -> injectTkType (OpenTKType.Matrix3x4) (adjustedName + "Matrix3x4") GLfloat
    | EndsWith "Matrix4x2fv" adjustedName -> injectTkType (OpenTKType.Matrix4x2) (adjustedName + "Matrix4x2") GLfloat
    | EndsWith "Matrix4x3fv" adjustedName -> injectTkType (OpenTKType.Matrix4x3) (adjustedName + "Matrix4x3") GLfloat
    | EndsWith "Matrix2x3dv" adjustedName -> injectTkType (OpenTKType.Matrix2x3d) (adjustedName + "Matrix2x3") GLdouble
    | EndsWith "Matrix2x4dv" adjustedName -> injectTkType (OpenTKType.Matrix2x4d) (adjustedName + "Matrix2x4") GLdouble
    | EndsWith "Matrix3x2dv" adjustedName -> injectTkType (OpenTKType.Matrix3x2d) (adjustedName + "Matrix3x2") GLdouble
    | EndsWith "Matrix3x4dv" adjustedName -> injectTkType (OpenTKType.Matrix3x4d) (adjustedName + "Matrix3x4") GLdouble
    | EndsWith "Matrix4x2dv" adjustedName -> injectTkType (OpenTKType.Matrix4x2d) (adjustedName + "Matrix4x2") GLdouble
    | EndsWith "Matrix4x3dv" adjustedName -> injectTkType (OpenTKType.Matrix4x3d) (adjustedName + "Matrix4x3") GLdouble
    | EndsWith "2dv" adjustedName -> injectTkType (OpenTKType.Vector2d) (adjustedName + "2") GLdouble
    | EndsWith "3dv" adjustedName -> injectTkType (OpenTKType.Vector3d) (adjustedName + "3") GLdouble
    | EndsWith "4dv" adjustedName -> injectTkType (OpenTKType.Vector4d) (adjustedName + "4") GLdouble
    | EndsWith "2fv" adjustedName -> injectTkType (OpenTKType.Vector2) (adjustedName + "2") GLfloat
    | EndsWith "3fv" adjustedName -> injectTkType (OpenTKType.Vector3) (adjustedName + "3") GLfloat
    | EndsWith "4fv" adjustedName -> injectTkType (OpenTKType.Vector4) (adjustedName + "4") GLfloat
    // We don't want to remove the Plural
    | EndsWith "ib" _
    | EndsWith "ts" _
    | EndsWith "ls" _
    | EndsWith "ys" _
    | EndsWith "rs" _
    | EndsWith "ed" _
    | EndsWith "nd" _
    | EndsWith "es" _
    | EndsWith "ufv" _
    | EndsWith "udv" _ -> None, keep
    | EndsWithOneOf sufixToRemove adjustedName -> Some adjustedName, { func with prettyName = adjustedName }
    | _ -> None, keep
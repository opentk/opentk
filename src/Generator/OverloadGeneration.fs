module OverloadGeneration
open System
open Formatting
open Types
open Constants
open Formatting


module private Helpers =
    /// Retrieves the underlying type from a pointer type (recursively).
    let rec unwrapTypeFromPointer =
        function
        | Pointer t -> unwrapTypeFromPointer t
        | t -> t
        
    /// transforms the type of that a pointer points to, recursively.
    /// The number of pointers is preserved in the output, only the root type is changed.
    let rec transformPointer newRootType ptrType =
        match ptrType with
        | Pointer inner ->
            Pointer (transformPointer newRootType inner)
        | _ -> newRootType

type private Overload = FunctionDeclaration -> FunctionDeclaration array

module private Overloads =
    let charArrayToString (func:FunctionDeclaration) =
        let adjustedParameters =
            func.Parameters
            |> Array.map(fun parm ->
                match parm.Type with
                | Pointer(GLchar) ->
                    { parm with
                        Type = GLString }
                | Pointer(Pointer(GLchar)) ->
                    { parm with
                        Type = ArrayType GLString }
                | _ -> parm)
        { func with Parameters = adjustedParameters } |> Array.singleton

    
    let pointerToArray (func:FunctionDeclaration) =
        let adjustedParameters =
            func.Parameters
            |> Array.map(fun parm ->
                match parm.Type with
                | Pointer(x) when x <> Void ->
                    { parm with
                        Type = GLType.ArrayType x }
                | _ -> parm)
        { func with Parameters = adjustedParameters } |> Array.singleton
    
//    let voidPointerToGeneric (func:FunctionDeclaration) =
//        let adjustedParameters =
//            func.Parameters
//            |> Array.mapi(fun i param ->
//                match param.Type.Type with
//                | Pointer(_) when Helpers.unwrapTypeFromPointer param.Type.Type = Void ->
//                        let name = ("TElement" + string i)
//                        let inner = name |> StructGenericType
//                        let res = inner |> transformGLTypeFun
//                        if res = inner then
//                            param
//                        else
//                            { param with PrettyName = name; Type = { param.Type with Type = res} }
//                | _ -> param)
//        { func with Parameters = adjustedParameters } |> Array.singleton
    
    let doNothing _ = [||]


let private allOverloads: Overload array =
    [|
        Overloads.doNothing
        Overloads.charArrayToString
        Overloads.pointerToArray
    |]
    
    
let applyAllOverloads func =
    allOverloads
    |> Array.collect (fun overload -> overload func)
    |> Array.distinct

let autoGenerateAdditionalOverloadForType (func: FunctionDeclaration) =
    applyAllOverloads func
//    let lengthParamsSet =
//        func.Parameters
//        |> Array.choose(fun p -> p.LengthParamName)
//        |> Set.ofArray
//
//    let transformPointerTy i transformGLTypeFun typ =
//        let transformPointerTy typ =
//            match typ with
//            | Pointer(inner) ->
//                let flattenedTy = Helpers.unwrapTypeFromPointer inner
//                let res = flattenedTy |> transformGLTypeFun
//                if res = flattenedTy then typ
//                else res
//            | inner -> inner
//        match typ with
//        | Pointer(GLchar) ->
//            None, GLString
//        | Pointer(Pointer(GLchar)) ->
//            None, GLString |> ArrayType
//        | Pointer(_) when Helpers.unwrapTypeFromPointer typ = Void ->
//            let name = 
//                ("TElement" + string i)
//            let inner = name |> StructGenericType
//            let res = inner |> transformGLTypeFun 
//            //if res = inner then
//            //    None, typ
//            //else
//            //    Some name, res
//            None, Pointer(Void)
//        | _ -> None, transformPointerTy typ
//    if lengthParamsSet.Count = 0 then
//        let adjustedParameters =
//            func.Parameters
//            |> Array.map(fun currParameter ->
//                match currParameter.Type.Type with
//                | Pointer(GLchar) ->
//                    { currParameter with
//                        PrintReadyTypedParameterInfo.Type = GLString |> PrintReady.formatGLType }
//                | Pointer(Pointer(GLchar)) ->
//                    { currParameter with
//                        PrintReadyTypedParameterInfo.Type = GLString |> ArrayType |> PrintReady.formatGLType }
//                | _ -> currParameter)
//        { func with Parameters = adjustedParameters } |> Array.singleton
//    else
//        let overloadWithMapping tyMapper =
//            // Easiest solution to get
//            // incrementing generic type parameter names.
//            let mutable i = 1
//            let adjustedParameters =
//                func.Parameters
//                |> Array.map(fun currParameter ->
//                    if lengthParamsSet.Contains currParameter.ActualName then
//                        let _, newParameterType =
//                            currParameter.Type.Type
//                            |> transformPointerTy 0 RefPointer
//                        None, { currParameter with Type = newParameterType |> PrintReady.formatGLType }
//                    else
//                        let (genericName, newParameterType) =
//                            currParameter.Type.Type 
//                            |> transformPointerTy i tyMapper
//                        // Yes this is a bit evil, I'm sorry but this was easiest here.
//                        // without hurting performance.
//                        genericName |> Option.iter(fun _ -> i <- i + 1)
//                        genericName, { currParameter with Type = newParameterType |> PrintReady.formatGLType })
//            let genericTypes = adjustedParameters |> Array.choose fst
//            let parameters = adjustedParameters |> Array.map snd
//            { func with
//                GenericTypes = genericTypes
//                Parameters = parameters }
//        pointerTypeMappings
//        |> Array.Parallel.map overloadWithMapping





let autoGenerateOverloadForType (func: FunctionDeclaration) =
    let keep = func

    let injectTkType typ adjustedName expectedPointerTy =
        let name = adjustedName |> formatNameRemovingPrefix

        let parameters =
            func.Parameters
            |> Array.Parallel.map (fun param ->
                let typ =
                    match param.Type with
                    | Pointer(currTy) when currTy = expectedPointerTy ->
                        typ
                        |> OpenToolkit
                        |> RefPointer
                    | typ -> typ
                { param with Type = typ })
        // This is definitely no candidate for the pointers
        Some adjustedName,
        { func with
              Parameters = parameters
              PrettyName = name }

    let (|EndsWithOneOf|_|) suffixes func name =
        suffixes
        |> Array.tryPick(fun (suffix, f) ->
            match name with
            | EndsWith suffix adjustedName ->
                if f func then
                    Some adjustedName
                else
                    None
            | _ -> None
        )

    // The order here is very important.
    // The longer sufixes are checked first before the shorter ones

    //this can be de-duplicated with some string parsing or a LUT.
    match func.PrettyName with
    // Matrix and Vector mappings
    | EndsWith "Matrix2fv" adjustedName -> injectTkType (Matrix.square S2) (adjustedName + "Matrix2") GLfloat
    | EndsWith "Matrix3fv" adjustedName -> injectTkType (Matrix.square S3) (adjustedName + "Matrix3") GLfloat
    | EndsWith "Matrix4fv" adjustedName -> injectTkType (Matrix.square S4) (adjustedName + "Matrix4") GLfloat
    | EndsWith "Matrix2dv" adjustedName -> injectTkType (Matrixd.square S2) (adjustedName + "Matrix2") GLdouble
    | EndsWith "Matrix3dv" adjustedName -> injectTkType (Matrixd.square S3) (adjustedName + "Matrix3") GLdouble
    | EndsWith "Matrix4dv" adjustedName -> injectTkType (Matrixd.square S4) (adjustedName + "Matrix4") GLdouble
    | EndsWith "Matrix2x3fv" adjustedName -> injectTkType (Matrix(S2, S3)) (adjustedName + "Matrix2x3") GLfloat
    | EndsWith "Matrix2x4fv" adjustedName -> injectTkType (Matrix(S2, S4)) (adjustedName + "Matrix2x4") GLfloat
    | EndsWith "Matrix3x2fv" adjustedName -> injectTkType (Matrix(S3, S2)) (adjustedName + "Matrix3x2") GLfloat
    | EndsWith "Matrix3x4fv" adjustedName -> injectTkType (Matrix(S3, S4)) (adjustedName + "Matrix3x4") GLfloat
    | EndsWith "Matrix4x2fv" adjustedName -> injectTkType (Matrix(S4, S2)) (adjustedName + "Matrix4x2") GLfloat
    | EndsWith "Matrix4x3fv" adjustedName -> injectTkType (Matrix(S4, S3)) (adjustedName + "Matrix4x3") GLfloat
    | EndsWith "Matrix2x3dv" adjustedName -> injectTkType (Matrixd(S2, S3)) (adjustedName + "Matrix2x3") GLdouble
    | EndsWith "Matrix2x4dv" adjustedName -> injectTkType (Matrixd(S2, S4)) (adjustedName + "Matrix2x4") GLdouble
    | EndsWith "Matrix3x2dv" adjustedName -> injectTkType (Matrixd(S3, S2)) (adjustedName + "Matrix3x2") GLdouble
    | EndsWith "Matrix3x4dv" adjustedName -> injectTkType (Matrixd(S3, S4)) (adjustedName + "Matrix3x4") GLdouble
    | EndsWith "Matrix4x2dv" adjustedName -> injectTkType (Matrixd(S4, S2)) (adjustedName + "Matrix4x2") GLdouble
    | EndsWith "Matrix4x3dv" adjustedName -> injectTkType (Matrixd(S4, S3)) (adjustedName + "Matrix4x3") GLdouble
    | EndsWith "2dv" adjustedName -> injectTkType (Vectord S2) (adjustedName + "2") GLdouble
    | EndsWith "3dv" adjustedName -> injectTkType (Vectord S3) (adjustedName + "3") GLdouble
    | EndsWith "4dv" adjustedName -> injectTkType (Vectord S4) (adjustedName + "4") GLdouble
    | EndsWith "2fv" adjustedName -> injectTkType (Vector S2) (adjustedName + "2") GLfloat
    | EndsWith "3fv" adjustedName -> injectTkType (Vector S3) (adjustedName + "3") GLfloat
    | EndsWith "4fv" adjustedName -> injectTkType (Vector S4) (adjustedName + "4") GLfloat
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
    | EndsWithOneOf sufixToRemove func adjustedName -> Some adjustedName, { func with PrettyName = adjustedName }
    | _ ->
            None, keep

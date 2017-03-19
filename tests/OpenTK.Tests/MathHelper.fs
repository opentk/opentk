namespace OpenTK.Tests

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open OpenTK

[<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
module MathHelper = 
    /// This test ensures that approximately equal can never get it 'wrong' about the values.
    [<Property>]
    let ``ApproximatelyEqual is never incorrect`` (a : float32,b : float32,bits : int32) = 
        let clamped = max 0 (min bits 24)
        let areApproxEqual = MathHelper.ApproximatelyEqual(a,b,clamped)
        let areExactlyEqual = a = b
        let isWrong = areExactlyEqual && not areApproxEqual
        Assert.False(isWrong)
    
    [<Property>]
    let ``ApproximatelyEqual can return true if some values are not exactly equal`` (a : float32,b : float32,bits : int32) = 
        let clamped = max 0 (min bits 24)
        let areApproxEqual = MathHelper.ApproximatelyEqual(a,b,clamped)
        let areExactlyEqual = a = b
        let isWrong = areExactlyEqual && not areApproxEqual
        let p = new PropertyAttribute()
        Assert.False(isWrong)
    
    [<Fact>]
    let ``ApproximatelyEqual correctly approximates equality``() = 
        let a = 0.000000001f
        let b = 0.0000000010000001f
        Assert.NotEqual(a,b)
        [ 1..24 ] |> List.iter (fun i -> Assert.True(MathHelper.ApproximatelyEqual(a,b,i)))
    
    [<Fact>]
    let ``ApproximatelyEqual reports very different values as non-equal even with high bit count``() = 
        let a = 2.0f
        let b = 1.0f
        Assert.NotEqual(a,b)
        Assert.False(MathHelper.ApproximatelyEqual(a,b,10))
    
    [<Fact>]
    let ``ApproximatelyEqual works with single zero value``() = 
        let a = 1.0f
        let b = 0.0f
        Assert.NotEqual(a,b)
        Assert.False(MathHelper.ApproximatelyEqual(a,b,0))
    
    [<Fact>]
    let ``ApproximatelyEqual works with both zero values``() = 
        let a = 0.0f
        let b = 0.0f
        Assert.Equal(a,b)
        Assert.True(MathHelper.ApproximatelyEqual(a,b,0))

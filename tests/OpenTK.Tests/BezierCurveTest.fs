namespace OpenTK.Tests

open Xunit
open FsCheck.Xunit
open OpenTK.Mathematics

[<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
module BezierCurve =
    
    [<Property>]
    let ``Bezier curve between 2 points is a straight line``(pt1:Vector2, pt2:Vector2) =
        let curve = BezierCurve(pt1, pt2)
        Assert.ApproximatelyEquivalent(pt1, curve.CalculatePoint(0.0f))
        Assert.ApproximatelyEquivalent(pt2, curve.CalculatePoint(1.0f))
        let midPoint = Vector2.Lerp(pt1, pt2, 0.5f)
        Assert.ApproximatelyEquivalent(midPoint, curve.CalculatePoint(0.5f))

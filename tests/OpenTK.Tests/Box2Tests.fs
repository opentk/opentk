namespace OpenTK.Tests

open Xunit
open System
open FsCheck.Xunit
open OpenTK.Mathematics

module Box2 =
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Constructors =
        [<Property>]
        let ``Vector constructor sets all values accordingly`` (v1 : Vector2, v2 : Vector2) =
            let b = Box2(v1, v2)

            Assert.Equal(v1, b.Min)
            Assert.Equal(v2, b.Max)

        [<Property>]
        let ``Float constructor should be the same as creating vectors and using the vector constructor`` (f1 : float32, f2 : float32, f3 : float32, f4 : float32) =
            let b1 = Box2(f1, f2, f3, f4)
            let b2 = Box2(Vector2(f1, f2), Vector2(f3, f4))

            Assert.Equal(b1, b2)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Size =
        [<Property>]
        let ``The size of a given box must be greater than or equal to 0`` (b : Box2) =
            Assert.True(b.Size.X * b.Size.Y >= (float32)0)

        [<Property>]
        let ``The halfsize of a given box must be greater than or equal to 0`` (b : Box3) =
            Assert.True(b.HalfSize.X * b.HalfSize.Y >= (float32)0)

        [<Property>]
        let ``The width and height of a given box must be greater than or equal to 0`` (b : Box3) =
            Assert.True(b.Width >= (float32)0)
            Assert.True(b.Height >= (float32)0)

        [<Property>]
        let ``The size should follow max-min`` (b : Box2) =
           Assert.Equal(b.Size, Vector2.ComponentMax(Vector2.Zero, b.Max - b.Min))

        [<Property>]
        let ``The halfsize should always be equal to half the size`` (b1 : Box2) =
            Assert.Equal(b1.Size/(float32)2, b1.HalfSize)

        [<Property>]
        let ``Using the fields should always result in size >= 0`` (v1 : Vector3, v2 : Vector3, v3 : Vector3, v4 : Vector3) =
            let mutable b = Box3(v1, v2)

            b.Min <- v3
            b.Max <- v4

            Assert.True(b.Size.X * b.Size.Y >= (float32)0)

    [<Properties(Arbitrary = [|typeof<OpenTKGen>|])>]
    module Scale =
        [<Property>]
        let ``When scaling the size should change accordingly`` (b1 : Box2, v1 : Vector2, v2 : Vector2) =
            let mutable b = b1
            let f = b.Size
            let v = new Vector2(Math.Abs(v1.X), Math.Abs(v1.Y))
            
            b.Scale(v, v2)

            let epsilon = new Vector2(
                Assert.EpsilonFromValue4Digits(v.X),
                Assert.EpsilonFromValue4Digits(v.Y)
            )
            
            Assert.ApproximatelyEqualDelta(v * f, b.Size, epsilon)
            
        [<Property>]
        let ``Scaling from the center of a box should have the same result as multiplying the size`` (b1 : Box2, v1 : Vector2) =
            let v2 = Vector2.ComponentMax(Vector2.Zero, b1.Size * v1)

            b1.Scale(v1, b1.Center)

            let epsilon = new Vector2(
                Assert.EpsilonFromValue4Digits(v1.X),
                Assert.EpsilonFromValue4Digits(v1.Y)
            )
            
            Assert.ApproximatelyEqualDelta(v2, b1.Size, epsilon)
            
        [<Property>]
        let ``Box2.Scale is equivelant to Box2.Scaled`` (b1 : Box2, v1 : Vector2, v2 : Vector2) =
            let mutable b = b1
            
            b.Scale(v1, v2)
            
            Assert.Equal(b, b1.Scaled(v1, v2))

    [<Properties(Arbitrary = [|typeof<OpenTKGen>|])>]
    module Translate =
        [<Property>]
        let ``Translating is the same as adding to the min and max value`` (b1 : Box2, v1 : Vector2) =
            let b = Box2(b1.Min + v1, b1.Max + v1)
            
            Assert.Equal(b, b1.Translated(v1))
        
        [<Property>]
        let ``Box2.Translate is equivelant to Box2.Translated`` (b1 : Box2, v1 : Vector2) =
            let mutable b = b1
            
            b.Translate(v1)
            
            Assert.Equal(b, b1.Translated(v1))
            
    [<Properties(Arbitrary = [|typeof<OpenTKGen>|])>]
    module Inflate =
        [<Property>]
        let ``Box2.Inflate produces the expected min and max changes`` (b1 : Box2, v1 : Vector2) =
            let size = Vector2.ComponentMax(v1, -b1.HalfSize);
            let bx = Box2.FromTwoPoints(b1.Min - size, b1.Max + size)
            let mutable b = b1
            b.Inflate(v1)
            Assert.Equal(b, bx)

        [<Property>]
        let ``Box2.Inflate is equivalent to Inflated`` (b1 : Box2, v1 : Vector2) =
            let mutable b = b1
            b.Inflate(v1)
            Assert.Equal(b, b1.Inflated(v1))

        [<Property>]
        let ``Box2.Inflate correctly modifies the size of the box`` (b1 : Box2, v1 : Vector2) =
            let b2 = b1.Inflated(v1)
            let expected = Vector2.ComponentMax(b1.Size + (v1 * 2.0f), Vector2.Zero)
            Assert.ApproximatelyEquivalent(expected, b2.Size)
            Assert.AllComponentsPositiveOrZero(b2.Size)
        
    [<Properties(Arbitrary = [|typeof<OpenTKGen>|])>]
    module Extend =
        [<Property>]
        let ``After extending a box the point should be either on the edge of the box or the box shouldn't change size`` (b1 : Box2, v1 : Vector2) =
            let v2 = b1.Size
            b1.Extend(v1)
            Assert.EitherEqual(b1.DistanceToNearestEdge(v1), (float32)0, v2, b1.Size)

        [<Property>]
        let ``After extending the point should be enclosed in the box`` (b1 : Box2, v1 : Vector2) =
            Assert.True(b1.Extended(v1).ContainsInclusive(v1))

        [<Property>]
        let ``Box2.Extend is equivalent to Box2.Extended`` (b1 : Box2, v1 : Vector2) =
            let mutable b = b1
            b.Extend(v1)
            Assert.Equal(b, b1.Extended(v1))
        
    [<Properties(Arbitrary = [|typeof<OpenTKGen>|])>]
    module Center =
        [<Property>]
        let ``When setting the center property the center should change to the new value`` (b1 : Box2, v1 : Vector2) =
            let mutable b = b1
            
            b.Center <- v1
            
            Assert.ApproximatelyEquivalent(v1, b.Center)
        
        [<Property>]
        let ``The center should be half the distance between min and max points`` (b1 : Box2) =
            let v1 = (b1.Max - b1.Min) * 0.5f + b1.Min
            
            Assert.Equal(v1, b1.Center)
    
    [<Properties(Arbitrary = [|typeof<OpenTKGen>|])>]
    module Contains =
        [<Property>]
        let ``Box2.Contains should only return true if the point is enclosed in the box (exclusive)`` (b1 : Box2, v1 : Vector2) =
            let c = b1.Min.X < v1.X && b1.Min.Y < v1.Y && v1.X < b1.Max.X && v1.Y < b1.Max.Y
            
            Assert.Equal(c, b1.ContainsExclusive(v1))

        let ``Box2.Contains should only return true if the point is enclosed in the box (inclusive)`` (b1 : Box2, v1 : Vector2) =
            let c = b1.Min.X <= v1.X && b1.Min.Y <= v1.Y && v1.X <= b1.Max.X && v1.Y <= b1.Max.Y
            
            Assert.Equal(c, b1.ContainsInclusive(v1))

        [<Property>]
        let ``Box2.Contains should only return true if the other box is completely within the box`` (b1 : Box2, b2 : Box2) =
            let c = b1.Min.X <= b2.Min.X && b1.Min.Y <= b2.Min.Y && b1.Max.X >= b2.Max.X && b1.Max.Y >= b2.Max.Y
            
            Assert.Equal(c, b1.Contains(b2))
                
    [<Properties(Arbitrary = [|typeof<OpenTKGen>|])>]
    module DistanceToNearestEdge =
        [<Property>]
        let ``The distance should always return the smallest possible distance`` (b1 : Box2, v1 : Vector2) =
           let v2 = Vector2(Math.Max((float32)0, Math.Max(b1.Min.X - v1.X, v1.X - b1.Max.X)), Math.Max((float32)0, Math.Max(b1.Min.Y - v1.Y,  v1.Y - b1.Max.Y)));
           Assert.Equal(b1.DistanceToNearestEdge(v1), v2.Length)
            
        [<Property>]
        let ``The distance should never be negative`` (b1 : Box2, v1 : Vector2) =            
            Assert.True(b1.DistanceToNearestEdge(v1) >= (float32)0)
            
    [<Properties(Arbitrary = [|typeof<OpenTKGen>|])>]
    module Equality =
        [<Property>]
        let ``Any box should be equal to itself`` (b1 : Box2) =
            Assert.Equal(b1, b1)
            Assert.True(b1.Equals(b1))

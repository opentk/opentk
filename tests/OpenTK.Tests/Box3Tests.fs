namespace OpenTK.Tests

open Xunit
open FsCheck
open System
open FsCheck.Xunit
open System.Runtime.InteropServices
open OpenTK
open OpenTK.Mathematics

module Box3 =
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Constructors =
        [<Property>]
        let ``Vector constructor sets all values accordingly`` (v1 : Vector3, v2 : Vector3) =
            let b = Box3(v1, v2)
            let vMin = Vector3(Math.Min(v1.X, v2.X), Math.Min(v1.Y, v2.Y), Math.Min(v1.Z, v2.Z))
            let vMax = Vector3(Math.Max(v1.X, v2.X), Math.Max(v1.Y, v2.Y), Math.Max(v1.Z, v2.Z))

            Assert.Equal(vMin, b.Min)
            Assert.Equal(vMax, b.Max)

        [<Property>]
        let ``Float constructor should be the same as creating vectors and using the vector constructor`` (f1 : float32, f2 : float32, f3 : float32, f4 : float32, f5 : float32, f6 : float32) =
            let b1 = Box3(f1, f2, f3, f4, f5, f6)
            let b2 = Box3(Vector3(f1, f2, f3), Vector3(f4, f5, f6))

            Assert.Equal(b1, b2)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Size =
        [<Property>]
        let ``The size of a given box must be greater than or equal to 0`` (b : Box3) =
            Assert.True(b.Size.X * b.Size.Y * b.Size.Z >= (float32)0)

        [<Property>]
        let ``The size should follow max-min`` (b : Box3) =
           Assert.Equal(b.Size, b.Max - b.Min)

        [<Property>]
        let ``The size should be equal to the set size`` (b1 : Box3, v1 : Vector3) =
           let mutable b = b1
           let v = new Vector3(Math.Abs(v1.X), Math.Abs(v1.Y), Math.Abs(v1.Z))

           b.Size <- v
           
           Assert.ApproximatelyEquivalent(v, b.Size)
        
        [<Property>]
        let ``Changing the size should not change the center`` (b1 : Box3, v1 : Vector3) =
           let mutable b = b1
           let v = b.Center
           
           b.Size <- v1
           
           Assert.ApproximatelyEquivalent(v, b.Center)
        
        [<Property>]
        let ``The halfsize should always be equal to half the size`` (b1 : Box3, v1 : Vector3) =
            let mutable b = b1
            
            b.Size <- v1
            
            Assert.Equal(b1.Size/(float32)2, b1.HalfSize)
            Assert.Equal(b.Size/(float32)2, b.HalfSize)
            
        [<Property>]
        let ``The halfsize should always be equal to half the size when using the halfSize setter`` (b1 : Box3, v1 : Vector3) =
            let mutable b = b1
            
            b.HalfSize <- v1
            
            Assert.Equal(b1.Size/(float32)2, b1.HalfSize)
            Assert.Equal(b.Size/(float32)2, b.HalfSize)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Properties =
        [<Property>]
        let ``Using the properties should always result in a valid box (size >= 0)`` (v1 : Vector3, v2 : Vector3, v3 : Vector3, v4 : Vector3) =
            let mutable b = Box3(v1, v2)

            b.Min <- v3
            b.Max <- v4

            Assert.True(b.Size.X * b.Size.Y * b.Size.Z >= (float32)0)

        [<Property>]
        let ``Setting a min value higher than max moves the max`` (b1 : Box3, v1 : Vector3) =
            let mutable b = b1

            b.Min <- v1

            Assert.Equal(b.Max, Vector3.ComponentMax(v1, b1.Max))

        [<Property>]
        let ``Setting a max value lower than min moves the min`` (b1 : Box3, v1 : Vector3) =
            let mutable b = b1

            b.Max <- v1

            Assert.Equal(b.Min, Vector3.ComponentMin(v1, b1.Min))
    
    [<Properties(Arbitrary = [|typeof<OpenTKGen>|])>]
    module Scale =
        [<Property>]
        let ``When scaling the size should change accordingly`` (b1 : Box3, v1 : Vector3, v2 : Vector3) =
            let mutable b = b1
            let f = b.Size
            let v = new Vector3(Math.Abs(v1.X), Math.Abs(v1.Y), Math.Abs(v1.Z))
            
            b.Scale(v, v2)
            
            Assert.ApproximatelyEqualEpsilon(v * f, b.Size, (float32)0.001)
            
        [<Property>]
        let ``Scaling from the center of a box should have the same result as multiplying the size`` (b1 : Box3, v1 : Vector3) =
            let v2 = b1.Size * v1
            b1.Scale(v1, b1.Center)
            
            Assert.ApproximatelyEqualEpsilon(b1.Size, v2, (float32)0.001)
            
        [<Property>]
        let ``Box2.Scale is equivelant to Box2.Scaled`` (b1 : Box3, v1 : Vector3, v2 : Vector3) =
            let mutable b = b1
            
            b.Scale(v1, v2)
            
            Assert.Equal(b, b1.Scaled(v1, v2))

    [<Properties(Arbitrary = [|typeof<OpenTKGen>|])>]
    module Translate =
        [<Property>]
        let ``Translating is the same as adding to the min and max value`` (b1 : Box3, v1 : Vector3) =
            let b = Box3(b1.Min + v1, b1.Max + v1)
            
            Assert.Equal(b, b1.Translated(v1))
        
        [<Property>]
        let ``Box2.Translate is equivelant to Box2.Translated`` (b1 : Box3, v1 : Vector3) =
            let mutable b = b1
            
            b.Translate(v1)
            
            Assert.Equal(b, b1.Translated(v1))
            
    [<Properties(Arbitrary = [|typeof<OpenTKGen>|])>]
    module Inflate =
        [<Property>]
        let ``After inflating a box the point should be either on the edge of the box or the box shouldn't change size`` (b1 : Box3, v1 : Vector3) =
            let v2 = b1.Size
            
            b1.Inflate(v1)
            
            Assert.True(b1.DistanceToNearestEdge(v1) = (float32)0 || v2 = b1.Size)
        
        [<Property>]
        let ``After inflating the point should be enclosed in the box`` (b1 : Box3, v1 : Vector3) =
            Assert.True(b1.Inflated(v1).Contains(v1, true))

        [<Property>]
        let ``Box2.Inflate is equivalent to Box2.Inflated`` (b1 : Box3, v1 : Vector3) =
            let mutable b = b1
            
            b.Inflate(v1)
            
            Assert.Equal(b, b1.Inflated(v1))
        
    [<Properties(Arbitrary = [|typeof<OpenTKGen>|])>]
    module Center =
        [<Property>]
        let ``When setting the center property the center should change to the new value`` (b1 : Box3, v1 : Vector3) =
            let mutable b = b1
            
            b.Center <- v1
            
            Assert.ApproximatelyEquivalent(v1, b.Center)
        
        [<Property>]
        let ``The center should be half the distance between min and max points`` (b1 : Box3) =
            let v1 = (b1.Max - b1.Min) * 0.5f + b1.Min
            
            Assert.Equal(v1, b1.Center)
    
    [<Properties(Arbitrary = [|typeof<OpenTKGen>|])>]
    module Contains =
        [<Property>]
        let ``Box3.Contains should only return true if the point is enclosed in the box`` (b1 : Box3, v1 : Vector3) =
            let c = b1.Min.X < v1.X && v1.X < b1.Max.X && b1.Min.Y < v1.Y && v1.Y < b1.Max.Y && b1.Min.Z < v1.Z && v1.Z < b1.Max.Z
            
            Assert.Equal(c, b1.Contains(v1))

        [<Property>]
        let ``Box3.Contains should only return true if the other box is partly within in the box`` (b1 : Box3, b2 : Box3) =
            let c = b1.Min.X <= b2.Max.X && b1.Max.X >= b2.Min.X && b1.Min.Y <= b2.Max.Y && b1.Max.Y >= b2.Min.Y && b1.Min.Z <= b2.Max.Z && b1.Max.Z >= b2.Min.Z
            
            Assert.Equal(c, b1.Contains(b2))
                
    [<Properties(Arbitrary = [|typeof<OpenTKGen>|])>]
    module DistanceToNearestEdge =
        [<Property>]
        let ``The distance should always return the smallest possible distance`` (b1 : Box3, v1 : Vector3) =
           let v2 = Vector3(Math.Max((float32)0, Math.Max(b1.Min.X - v1.X, v1.X - b1.Max.X)), Math.Max((float32)0, Math.Max(b1.Min.Y - v1.Y,  v1.Y - b1.Max.Y)), Math.Max((float32)0, Math.Max(b1.Min.Z - v1.Z,  v1.Z - b1.Max.Z)));
           Assert.Equal(b1.DistanceToNearestEdge(v1), v2.Length)
            
        [<Property>]
        let ``The distance should never be negative`` (b1 : Box3, v1 : Vector3) =            
            Assert.True(b1.DistanceToNearestEdge(v1) >= (float32)0)
            
    [<Properties(Arbitrary = [|typeof<OpenTKGen>|])>]
    module Equality =
        [<Property>]
        let ``Any box should be equal to itself`` (b1 : Box3) =
            Assert.Equal(b1, b1)
            Assert.True(b1.Equals(b1))

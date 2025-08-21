namespace OpenTK.Tests

open Xunit
open FsCheck.Xunit
open System.Runtime.InteropServices
open OpenTK.Mathematics

module Vector4b =
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Constructors =
        //
        [<Property>]
        let ``Quadruple value constructor sets all components to the correct values`` (x, y, z, w) =
            let v = Vector4b(x, y, z, w)

            Assert.Equal(x, v.X)
            Assert.Equal(y, v.Y)
            Assert.Equal(z, v.Z)
            Assert.Equal(w, v.W)

        [<Property>]
        let ``Single value constructor sets all components to the correct values`` (a : bool) =
            let v = Vector4b(a)

            Assert.Equal(a, v.X)
            Assert.Equal(a, v.Y)
            Assert.Equal(a, v.Z)
            Assert.Equal(a, v.W)

        [<Property>]
        let ``Vector2 value constructor sets all components to the correct values`` (x, y) =
            let v1 = Vector2b(x, y)
            let v2 = Vector4b(v1)

            Assert.Equal(v1.X, v2.X)
            Assert.Equal(v1.Y, v2.Y)

            Assert.Equal(x, v2.X)
            Assert.Equal(y, v2.Y)
            Assert.Equal(false, v2.Z)
            Assert.Equal(false, v2.W)

        [<Property>]
        let ``Vector3 value constructor sets all components to the correct values`` (x, y, z) =
            let v1 = Vector3b(x, y, z)
            let v2 = Vector4b(v1)

            Assert.Equal(v1.X, v2.X)
            Assert.Equal(v1.Y, v2.Y)
            Assert.Equal(v1.Z, v2.Z)

            Assert.Equal(x, v2.X)
            Assert.Equal(y, v2.Y)
            Assert.Equal(z, v2.Z)
            Assert.Equal(false, v2.W)

        [<Property>]
        let ``Vector3 value and scalar constructor sets all components to the correct values`` (x, y, z, w) =
            let v1 = Vector3b(x, y, z)
            let v2 = Vector4b(v1, w)

            Assert.Equal(v1.X, v2.X)
            Assert.Equal(v1.Y, v2.Y)
            Assert.Equal(v1.Z, v2.Z)

            Assert.Equal(x, v2.X)
            Assert.Equal(y, v2.Y)
            Assert.Equal(z, v2.Z)
            Assert.Equal(w, v2.W)

        [<Property>]
        let ``Vector4 value constructor sets all components to the correct values`` (x, y, z, w) =
            let v1 = Vector4b(x, y, z, w)
            let v2 = Vector4b(v1)

            Assert.Equal(v1.X, v2.X)
            Assert.Equal(v1.Y, v2.Y)
            Assert.Equal(v1.Z, v2.Z)
            Assert.Equal(v1.W, v2.W)

            Assert.Equal(x, v2.X)
            Assert.Equal(y, v2.Y)
            Assert.Equal(z, v2.Z)
            Assert.Equal(w, v2.W)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Equality =
        //
        [<Property>]
        let ``Vector equality operator is by component`` (x, y, z, w) =
            let v1 = Vector4b(x, y, z, w)
            let v2 = Vector4b(x, y, z, w)
            let equality = v1 = v2

            Assert.True(equality)

        [<Property>]
        let ``Vector inequality operator is by component`` (x, y, z, w) =
            let v1 = Vector4b(x, y, z, w)
            let v2 = Vector4b(not x, not y, not z, not w)
            let inequality = v1 <> v2

            Assert.True(inequality)

        [<Property>]
        let ``Vector equality method is by component`` (x, y, z, w) =
            let v1 = Vector4b(x, y, z, w)
            let v2 = Vector4b(x, y, z, w)
            let notVector = Matrix2()

            let equality = v1.Equals(v2)
            let inequalityByOtherType = v1.Equals(notVector)

            Assert.True(equality)
            Assert.False(inequalityByOtherType)

        [<Property>]
        let ``Vector equality method returns false for other classes`` (x, y, z, w) =
            let v1 = Vector4b(x, y, z, w)
            let notVector = Matrix2()

            let inequalityByOtherType = v1.Equals(notVector)

            Assert.False(inequalityByOtherType)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Not =
        //
        [<Property>]
        let ``Not true equals false`` () =
            let v = Vector4b.Not(Vector4b.True);
            Assert.Equal(v, Vector4b.False)

        [<Property>]
        let ``Not false equals true`` () =
            let v = Vector4b.Not(Vector4b.False);
            Assert.Equal(v, Vector4b.True)

        [<Property>]
        let ``Not inverts all components`` (x, y, z, w) =
            let v = Vector4b.Not(Vector4b(x, y, z, w));

            Assert.Equal(not x, v.X)
            Assert.Equal(not y, v.Y)
            Assert.Equal(not z, v.Z)
            Assert.Equal(not w, v.W)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module And =
        //
        [<Property>]
        let ``And between two vectors is by component`` (a : Vector4b, b : Vector4b) =
            let v = Vector4b.And(a, b);

            let x = a.X && b.X;
            let y = a.Y && b.Y;
            let z = a.Z && b.Z;
            let w = a.W && b.W;

            Assert.Equal(x, v.X)
            Assert.Equal(y, v.Y)
            Assert.Equal(z, v.Z)
            Assert.Equal(w, v.W)

        [<Property>]
        let ``And between vector and true does not change vector`` (a : Vector4b) =
            let v = Vector4b.And(a, Vector4b.True);

            Assert.Equal(a.X, v.X)
            Assert.Equal(a.Y, v.Y)
            Assert.Equal(a.Z, v.Z)
            Assert.Equal(a.W, v.W)

            Assert.Equal(a, v)

        [<Property>]
        let ``And between vector and false is all false`` (a : Vector4b) =
            let v = Vector4b.And(a, Vector4b.False);

            Assert.Equal(false, v.X)
            Assert.Equal(false, v.Y)
            Assert.Equal(false, v.Z)
            Assert.Equal(false, v.W)

            Assert.Equal(Vector4b.False, v)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Or =
        //
        [<Property>]
        let ``Or between two vectors is by component`` (a : Vector4b, b : Vector4b) =
            let v = Vector4b.Or(a, b);

            let x = a.X || b.X;
            let y = a.Y || b.Y;
            let z = a.Z || b.Z;
            let w = a.W || b.W;

            Assert.Equal(x, v.X)
            Assert.Equal(y, v.Y)
            Assert.Equal(z, v.Z)
            Assert.Equal(w, v.W)

        [<Property>]
        let ``OR between vector and true is all true`` (a : Vector4b) =
            let v = Vector4b.Or(a, Vector4b.True);

            Assert.Equal(true, v.X)
            Assert.Equal(true, v.Y)
            Assert.Equal(true, v.Z)
            Assert.Equal(true, v.W)

            Assert.Equal(Vector4b.True, v)

        [<Property>]
        let ``Or between vector and false does not change vector`` (a : Vector4b) =
            let v = Vector4b.Or(a, Vector4b.False);

            Assert.Equal(a.X, v.X)
            Assert.Equal(a.Y, v.Y)
            Assert.Equal(a.Z, v.Z)
            Assert.Equal(a.W, v.W)

            Assert.Equal(a, v)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Xor =
        //
        [<Property>]
        let ``Xor between two vectors is by component`` (a : Vector4b, b : Vector4b) =
            let v = Vector4b.Xor(a, b);

            let x = a.X <> b.X;
            let y = a.Y <> b.Y;
            let z = a.Z <> b.Z;
            let w = a.W <> b.W;

            Assert.Equal(x, v.X)
            Assert.Equal(y, v.Y)
            Assert.Equal(z, v.Z)
            Assert.Equal(w, v.W)

        [<Property>]
        let ``Xor between a vector and true inverts the vector`` (a : Vector4b) =
            let v = Vector4b.Xor(a, Vector4b.True);
            let n = Vector4b.Not(a);

            Assert.Equal(n.X, v.X)
            Assert.Equal(n.Y, v.Y)
            Assert.Equal(n.Z, v.Z)
            Assert.Equal(n.W, v.W)

            Assert.Equal(n, v)

        [<Property>]
        let ``Xor between a vector and false does not change vector`` (a : Vector4b) =
            let v = Vector4b.Xor(a, Vector4b.False);

            Assert.Equal(a.X, v.X)
            Assert.Equal(a.Y, v.Y)
            Assert.Equal(a.Z, v.Z)
            Assert.Equal(a.W, v.W)

            Assert.Equal(a, v)

        [<Property>]
        let ``Xor between a vector and itself is false`` (a : Vector4b) =
            let v = Vector4b.Xor(a, a);

            Assert.Equal(false, v.X)
            Assert.Equal(false, v.Y)
            Assert.Equal(false, v.Z)
            Assert.Equal(false, v.W)

            Assert.Equal(Vector4b.False, v)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module All =
        //
        [<Property>]
        let ``All on true vector is true`` () =
            let b = Vector4b.True.All()

            Assert.Equal(true, b)

        [<Property>]
        let ``All on not all true vector is false`` () =
            let b1 = Vector4b.False.All()
            let b2 = Vector4b.UnitX.All()
            let b3 = Vector4b.UnitY.All()
            let b4 = Vector4b.UnitZ.All()
            let b5 = Vector4b.UnitW.All()

            Assert.Equal(false, b1)
            Assert.Equal(false, b2)
            Assert.Equal(false, b3)
            Assert.Equal(false, b4)
            Assert.Equal(false, b5)

        [<Property>]
        let ``All is only true if all components are true`` (a : Vector4b) =
            let b = a.All()

            let e = a.X && a.Y && a.Z && a.W;

            Assert.Equal(e, b)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Any =
        //
        [<Property>]
        let ``Any on not all false vector is true`` () =
            let b1 = Vector4b.True.Any()
            let b2 = Vector4b.UnitX.Any()
            let b3 = Vector4b.UnitY.Any()
            let b4 = Vector4b.UnitZ.Any()
            let b5 = Vector4b.UnitW.Any()

            Assert.Equal(true, b1)
            Assert.Equal(true, b2)
            Assert.Equal(true, b3)
            Assert.Equal(true, b4)
            Assert.Equal(true, b5)

        [<Property>]
        let ``Any on false vector is false`` () =
            let b = Vector4b.False.Any()

            Assert.Equal(false, b)

        [<Property>]
        let ``Any is only true if any component is true`` (a : Vector4b) =
            let b = a.Any()

            let e = a.X || a.Y || a.Z || a.W;

            Assert.Equal(e, b)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Casts =
        //
        [<Property>]
        let ``Cast to Vector4i is accurate`` (a: Vector4b, b: Vector4i) =
            let c: Vector4i = Vector4b.op_Explicit a
            
            Assert.Equal(b, c)
            
        [<Property>]
        let ``Cast to Vector4 is accurate`` (a: Vector4b, b: Vector4) =
            let c: Vector4 = Vector4b.op_Explicit a
            
            Assert.Equal(b, c)
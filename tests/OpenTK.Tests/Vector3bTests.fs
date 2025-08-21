namespace OpenTK.Tests

open Xunit
open FsCheck.Xunit
open System.Runtime.InteropServices
open OpenTK.Mathematics

module Vector3b =
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Constructors =
        //
        [<Property>]
        let ``Quadruple value constructor sets all components to the correct values`` (x, y, z) =
            let v = Vector3b(x, y, z)

            Assert.Equal(x, v.X)
            Assert.Equal(y, v.Y)
            Assert.Equal(z, v.Z)

        [<Property>]
        let ``Single value constructor sets all components to the correct values`` (a : bool) =
            let v = Vector3b(a)

            Assert.Equal(a, v.X)
            Assert.Equal(a, v.Y)
            Assert.Equal(a, v.Z)

        [<Property>]
        let ``Vector2 value constructor sets all components to the correct values`` (x, y) =
            let v1 = Vector2b(x, y)
            let v2 = Vector3b(v1)

            Assert.Equal(v1.X, v2.X)
            Assert.Equal(v1.Y, v2.Y)

            Assert.Equal(x, v2.X)
            Assert.Equal(y, v2.Y)
            Assert.Equal(false, v2.Z)

        [<Property>]
        let ``Vector3 value constructor sets all components to the correct values`` (x, y, z) =
            let v1 = Vector3b(x, y, z)
            let v2 = Vector3b(v1)

            Assert.Equal(v1.X, v2.X)
            Assert.Equal(v1.Y, v2.Y)
            Assert.Equal(v1.Z, v2.Z)

            Assert.Equal(x, v2.X)
            Assert.Equal(y, v2.Y)
            Assert.Equal(z, v2.Z)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Equality =
        //
        [<Property>]
        let ``Vector equality operator is by component`` (x, y, z) =
            let v1 = Vector3b(x, y, z)
            let v2 = Vector3b(x, y, z)
            let equality = v1 = v2

            Assert.True(equality)

        [<Property>]
        let ``Vector inequality operator is by component`` (x, y, z) =
            let v1 = Vector3b(x, y, z)
            let v2 = Vector3b(not x, not y, not z)
            let inequality = v1 <> v2

            Assert.True(inequality)

        [<Property>]
        let ``Vector equality method is by component`` (x, y, z) =
            let v1 = Vector3b(x, y, z)
            let v2 = Vector3b(x, y, z)
            let notVector = Matrix2()

            let equality = v1.Equals(v2)
            let inequalityByOtherType = v1.Equals(notVector)

            Assert.True(equality)
            Assert.False(inequalityByOtherType)

        [<Property>]
        let ``Vector equality method returns false for other classes`` (x, y, z) =
            let v1 = Vector3b(x, y, z)
            let notVector = Matrix2()

            let inequalityByOtherType = v1.Equals(notVector)

            Assert.False(inequalityByOtherType)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Not =
        //
        [<Property>]
        let ``Not true equals false`` () =
            let v = Vector3b.Not(Vector3b.True);
            Assert.Equal(v, Vector3b.False)

        [<Property>]
        let ``Not false equals true`` () =
            let v = Vector3b.Not(Vector3b.False);
            Assert.Equal(v, Vector3b.True)

        [<Property>]
        let ``Not inverts all components`` (x, y, z) =
            let v = Vector3b.Not(Vector3b(x, y, z));

            Assert.Equal(not x, v.X)
            Assert.Equal(not y, v.Y)
            Assert.Equal(not z, v.Z)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module And =
        //
        [<Property>]
        let ``And between two vectors is by component`` (a : Vector3b, b : Vector3b) =
            let v = Vector3b.And(a, b);

            let x = a.X && b.X;
            let y = a.Y && b.Y;
            let z = a.Z && b.Z;

            Assert.Equal(x, v.X)
            Assert.Equal(y, v.Y)
            Assert.Equal(z, v.Z)

        [<Property>]
        let ``And between vector and true does not change vector`` (a : Vector3b) =
            let v = Vector3b.And(a, Vector3b.True);

            Assert.Equal(a.X, v.X)
            Assert.Equal(a.Y, v.Y)
            Assert.Equal(a.Z, v.Z)

            Assert.Equal(a, v)

        [<Property>]
        let ``And between vector and false is all false`` (a : Vector3b) =
            let v = Vector3b.And(a, Vector3b.False);

            Assert.Equal(false, v.X)
            Assert.Equal(false, v.Y)
            Assert.Equal(false, v.Z)

            Assert.Equal(Vector3b.False, v)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Or =
        //
        [<Property>]
        let ``Or between two vectors is by component`` (a : Vector3b, b : Vector3b) =
            let v = Vector3b.Or(a, b);

            let x = a.X || b.X;
            let y = a.Y || b.Y;
            let z = a.Z || b.Z;

            Assert.Equal(x, v.X)
            Assert.Equal(y, v.Y)
            Assert.Equal(z, v.Z)

        [<Property>]
        let ``OR between vector and true is all true`` (a : Vector3b) =
            let v = Vector3b.Or(a, Vector3b.True);

            Assert.Equal(true, v.X)
            Assert.Equal(true, v.Y)
            Assert.Equal(true, v.Z)

            Assert.Equal(Vector3b.True, v)

        [<Property>]
        let ``Or between vector and false does not change vector`` (a : Vector3b) =
            let v = Vector3b.Or(a, Vector3b.False);

            Assert.Equal(a.X, v.X)
            Assert.Equal(a.Y, v.Y)
            Assert.Equal(a.Z, v.Z)

            Assert.Equal(a, v)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Xor =
        //
        [<Property>]
        let ``Xor between two vectors is by component`` (a : Vector3b, b : Vector3b) =
            let v = Vector3b.Xor(a, b);

            let x = a.X <> b.X;
            let y = a.Y <> b.Y;
            let z = a.Z <> b.Z;

            Assert.Equal(x, v.X)
            Assert.Equal(y, v.Y)
            Assert.Equal(z, v.Z)

        [<Property>]
        let ``Xor between a vector and true inverts the vector`` (a : Vector3b) =
            let v = Vector3b.Xor(a, Vector3b.True);
            let n = Vector3b.Not(a);

            Assert.Equal(n.X, v.X)
            Assert.Equal(n.Y, v.Y)
            Assert.Equal(n.Z, v.Z)

            Assert.Equal(n, v)

        [<Property>]
        let ``Xor between a vector and false does not change vector`` (a : Vector3b) =
            let v = Vector3b.Xor(a, Vector3b.False);

            Assert.Equal(a.X, v.X)
            Assert.Equal(a.Y, v.Y)
            Assert.Equal(a.Z, v.Z)

            Assert.Equal(a, v)

        [<Property>]
        let ``Xor between a vector and itself is false`` (a : Vector3b) =
            let v = Vector3b.Xor(a, a);

            Assert.Equal(false, v.X)
            Assert.Equal(false, v.Y)
            Assert.Equal(false, v.Z)

            Assert.Equal(Vector3b.False, v)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module All =
        //
        [<Property>]
        let ``All on true vector is true`` () =
            let b = Vector3b.True.All()

            Assert.Equal(true, b)

        [<Property>]
        let ``All on not all true vector is false`` () =
            let b1 = Vector3b.False.All()
            let b2 = Vector3b.UnitX.All()
            let b3 = Vector3b.UnitY.All()
            let b4 = Vector3b.UnitZ.All()

            Assert.Equal(false, b1)
            Assert.Equal(false, b2)
            Assert.Equal(false, b3)
            Assert.Equal(false, b4)

        [<Property>]
        let ``All is only true if all components are true`` (a : Vector3b) =
            let b = a.All()

            let e = a.X && a.Y && a.Z;

            Assert.Equal(e, b)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Any =
        //
        [<Property>]
        let ``Any on not all false vector is true`` () =
            let b1 = Vector3b.True.Any()
            let b2 = Vector3b.UnitX.Any()
            let b3 = Vector3b.UnitY.Any()
            let b4 = Vector3b.UnitZ.Any()

            Assert.Equal(true, b1)
            Assert.Equal(true, b2)
            Assert.Equal(true, b3)
            Assert.Equal(true, b4)

        [<Property>]
        let ``Any on false vector is false`` () =
            let b = Vector3b.False.Any()

            Assert.Equal(false, b)

        [<Property>]
        let ``Any is only true if any component is true`` (a : Vector3b) =
            let b = a.Any()

            let e = a.X || a.Y || a.Z;

            Assert.Equal(e, b)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Casts =
        //
        [<Property>]
        let ``Cast to Vector3i is accurate`` (a: Vector3b) =
            let b = Vector3i(
                (if a.X then 1 else 0),
                (if a.Y then 1 else 0),
                (if a.Z then 1 else 0)
            )
            
            let c: Vector3i = Vector3b.op_Explicit a
            
            Assert.Equal(b, c)
            
        [<Property>]
        let ``Cast to Vector3 is accurate`` (a: Vector3b) =
            let b = Vector3(
                (if a.X then 1.0f else 0.0f),
                (if a.Y then 1.0f else 0.0f),
                (if a.Z then 1.0f else 0.0f)
            )
            
            let c: Vector3 = Vector3b.op_Explicit a
            
            Assert.Equal(b, c)
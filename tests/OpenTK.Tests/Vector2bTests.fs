namespace OpenTK.Tests

open Xunit
open FsCheck.Xunit
open System.Runtime.InteropServices
open OpenTK.Mathematics

module Vector2b =
    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Constructors =
        //
        [<Property>]
        let ``Quadruple value constructor sets all components to the correct values`` (x, y) =
            let v = Vector2b(x, y)

            Assert.Equal(x, v.X)
            Assert.Equal(y, v.Y)

        [<Property>]
        let ``Single value constructor sets all components to the correct values`` (a : bool) =
            let v = Vector2b(a)

            Assert.Equal(a, v.X)
            Assert.Equal(a, v.Y)

        [<Property>]
        let ``Vector2 value constructor sets all components to the correct values`` (x, y) =
            let v1 = Vector2b(x, y)
            let v2 = Vector2b(v1)

            Assert.Equal(v1.X, v2.X)
            Assert.Equal(v1.Y, v2.Y)

            Assert.Equal(x, v2.X)
            Assert.Equal(y, v2.Y)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Equality =
        //
        [<Property>]
        let ``Vector equality operator is by component`` (x, y) =
            let v1 = Vector2b(x, y)
            let v2 = Vector2b(x, y)
            let equality = v1 = v2

            Assert.True(equality)

        [<Property>]
        let ``Vector inequality operator is by component`` (x, y) =
            let v1 = Vector2b(x, y)
            let v2 = Vector2b(not x, not y)
            let inequality = v1 <> v2

            Assert.True(inequality)

        [<Property>]
        let ``Vector equality method is by component`` (x, y) =
            let v1 = Vector2b(x, y)
            let v2 = Vector2b(x, y)
            let notVector = Matrix2()

            let equality = v1.Equals(v2)
            let inequalityByOtherType = v1.Equals(notVector)

            Assert.True(equality)
            Assert.False(inequalityByOtherType)

        [<Property>]
        let ``Vector equality method returns false for other classes`` (x, y) =
            let v1 = Vector2b(x, y)
            let notVector = Matrix2()

            let inequalityByOtherType = v1.Equals(notVector)

            Assert.False(inequalityByOtherType)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Not =
        //
        [<Property>]
        let ``Not true equals false`` () =
            let v = Vector2b.Not(Vector2b.True);
            Assert.Equal(v, Vector2b.False)

        [<Property>]
        let ``Not false equals true`` () =
            let v = Vector2b.Not(Vector2b.False);
            Assert.Equal(v, Vector2b.True)

        [<Property>]
        let ``Not inverts all components`` (x, y) =
            let v = Vector2b.Not(Vector2b(x, y));

            Assert.Equal(not x, v.X)
            Assert.Equal(not y, v.Y)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module And =
        //
        [<Property>]
        let ``And between two vectors is by component`` (a : Vector2b, b : Vector2b) =
            let v = Vector2b.And(a, b);

            let x = a.X && b.X;
            let y = a.Y && b.Y;

            Assert.Equal(x, v.X)
            Assert.Equal(y, v.Y)

        [<Property>]
        let ``And between vector and true does not change vector`` (a : Vector2b) =
            let v = Vector2b.And(a, Vector2b.True);

            Assert.Equal(a.X, v.X)
            Assert.Equal(a.Y, v.Y)

            Assert.Equal(a, v)

        [<Property>]
        let ``And between vector and false is all false`` (a : Vector2b) =
            let v = Vector2b.And(a, Vector2b.False);

            Assert.Equal(false, v.X)
            Assert.Equal(false, v.Y)

            Assert.Equal(Vector2b.False, v)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Or =
        //
        [<Property>]
        let ``Or between two vectors is by component`` (a : Vector2b, b : Vector2b) =
            let v = Vector2b.Or(a, b);

            let x = a.X || b.X;
            let y = a.Y || b.Y;

            Assert.Equal(x, v.X)
            Assert.Equal(y, v.Y)

        [<Property>]
        let ``OR between vector and true is all true`` (a : Vector2b) =
            let v = Vector2b.Or(a, Vector2b.True);

            Assert.Equal(true, v.X)
            Assert.Equal(true, v.Y)

            Assert.Equal(Vector2b.True, v)

        [<Property>]
        let ``Or between vector and false does not change vector`` (a : Vector2b) =
            let v = Vector2b.Or(a, Vector2b.False);

            Assert.Equal(a.X, v.X)
            Assert.Equal(a.Y, v.Y)

            Assert.Equal(a, v)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Xor =
        //
        [<Property>]
        let ``Xor between two vectors is by component`` (a : Vector2b, b : Vector2b) =
            let v = Vector2b.Xor(a, b);

            let x = a.X <> b.X;
            let y = a.Y <> b.Y;

            Assert.Equal(x, v.X)
            Assert.Equal(y, v.Y)

        [<Property>]
        let ``Xor between a vector and true inverts the vector`` (a : Vector2b) =
            let v = Vector2b.Xor(a, Vector2b.True);
            let n = Vector2b.Not(a);

            Assert.Equal(n.X, v.X)
            Assert.Equal(n.Y, v.Y)

            Assert.Equal(n, v)

        [<Property>]
        let ``Xor between a vector and false does not change vector`` (a : Vector2b) =
            let v = Vector2b.Xor(a, Vector2b.False);

            Assert.Equal(a.X, v.X)
            Assert.Equal(a.Y, v.Y)

            Assert.Equal(a, v)

        [<Property>]
        let ``Xor between a vector and itself is false`` (a : Vector2b) =
            let v = Vector2b.Xor(a, a);

            Assert.Equal(false, v.X)
            Assert.Equal(false, v.Y)

            Assert.Equal(Vector2b.False, v)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module All =
        //
        [<Property>]
        let ``All on true vector is true`` () =
            let b = Vector2b.True.All()

            Assert.Equal(true, b)

        [<Property>]
        let ``All on not all true vector is false`` () =
            let b1 = Vector2b.False.All()
            let b2 = Vector2b.UnitX.All()
            let b3 = Vector2b.UnitY.All()

            Assert.Equal(false, b1)
            Assert.Equal(false, b2)
            Assert.Equal(false, b3)

        [<Property>]
        let ``All is only true if all components are true`` (a : Vector2b) =
            let b = a.All()

            let e = a.X && a.Y;

            Assert.Equal(e, b)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Any =
        //
        [<Property>]
        let ``Any on not all false vector is true`` () =
            let b1 = Vector2b.True.Any()
            let b2 = Vector2b.UnitX.Any()
            let b3 = Vector2b.UnitY.Any()

            Assert.Equal(true, b1)
            Assert.Equal(true, b2)
            Assert.Equal(true, b3)

        [<Property>]
        let ``Any on false vector is false`` () =
            let b = Vector2b.False.Any()

            Assert.Equal(false, b)

        [<Property>]
        let ``Any is only true if any component is true`` (a : Vector2b) =
            let b = a.Any()

            let e = a.X || a.Y;

            Assert.Equal(e, b)

    [<Properties(Arbitrary = [| typeof<OpenTKGen> |])>]
    module Casts =
        //
        [<Property>]
        let ``Cast to Vector2i is accurate`` (a: Vector2b) =
            let b = Vector2i(
                (if a.X then 1 else 0),
                (if a.Y then 1 else 0)
            )
            
            let c: Vector2i = Vector2b.op_Explicit a
            
            Assert.Equal(b, c)
            
        [<Property>]
        let ``Cast to Vector2 is accurate`` (a: Vector2b) =
            let b = Vector2(
                (if a.X then 1.0f else 0.0f),
                (if a.Y then 1.0f else 0.0f)
            )
            
            let c: Vector2 = Vector2b.op_Explicit a
            
            Assert.Equal(b, c)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenTK;

namespace OpenTK.Tests
{
    [TestFixture]
    public class Vector3Tests
    {
        [Test]
        public void Vector3_SingleValueConstructor()
        {
            Vector3 V = new Vector3(1);
            Assert.AreEqual(1, V.X);
            Assert.AreEqual(1, V.Y);
            Assert.AreEqual(1, V.Z);
        }

        [Test]
        public void Vector3_ThreeValueConstructor()
        {
            Vector3 V = new Vector3(1,2,3);
            Assert.AreEqual(1, V.X);
            Assert.AreEqual(2, V.Y);
            Assert.AreEqual(3, V.Z);
        }

        [Test]
        public void Vector3_Vector2Constructor()
        {
            Vector2 T = new Vector2(1, 2);
            Vector3 V = new Vector3(T);
            Assert.AreEqual(T.X, V.X);
            Assert.AreEqual(T.Y, V.Y);
            Assert.AreEqual(0, V.Z);
        }

        [Test]
        public void Vector3_Vector3Constructor()
        {
            Vector3 U = new Vector3(1, 2, 3);
            Vector3 V = new Vector3(U);
            Assert.IsTrue(U == V);
        }

        [Test]
        public void Vector3_Vector4Constructor()
        {
            Vector4 T = new Vector4(1, 2, 3, 0);
            Vector3 V = new Vector3(T);
            Assert.AreEqual(T.X, V.X);
            Assert.AreEqual(T.Y, V.Y);
            Assert.AreEqual(T.Z, V.Z);
        }

        [Test]
        public void Vector3_Index_operator()
        {
            Vector3 V = new Vector3();
            V[0] = 1; V[1] = 2; V[2] = 3;
            Assert.AreEqual(1, V[0]);
            Assert.AreEqual(2, V[1]);
            Assert.AreEqual(3, V[2]);
        }

        [Test]
        public void Vector3_Index_NegativeExceptin()
        {
            //the syntax for an expected exception changes from 
            //NUnit 2.6.4 / Microsoft Unit Test  to NUnit 3+
            //but a try-catch block is always guaranteed to work
            Vector3 V = new Vector3();
            bool negativeIndexExceptionFound = false;
            try
            {
                V[-1] = 5;
            }
            catch (Exception)
            {
                negativeIndexExceptionFound = true;
            }
            Assert.IsTrue(negativeIndexExceptionFound);
        }

        [Test]
        public void Vector3_Index_LargeIndexExceptin()
        {
            //the syntax for an expected exception changes from 
            //NUnit 2.6.4 / Microsoft Unit Test  to NUnit 3+
            //but a try-catch block is always guaranteed to work
            Vector3 V = new Vector3();
            bool largeIndexExceptionFound = false;
            try
            {
                V[3] = 6;
            }
            catch (Exception)
            {
                largeIndexExceptionFound = true;
            }
            Assert.IsTrue(largeIndexExceptionFound);
        }

        [Test]
        public void Vector3_Length()
        {
            float X = 1, Y = 2, Z = 2;
            Vector3 U = new Vector3(X, Y, Z);
            Assert.AreEqual((float)System.Math.Sqrt(X * X + Y * Y + Z * Z), U.Length);
        }

        [Test]
        public void Vector3_LengthFast()
        {
            float X = 1, Y = 2, Z = 2;
            Vector3 U = new Vector3(X, Y, Z);
            Assert.AreEqual(1.0f / MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z), U.LengthFast);
        }

        [Test]
        public void Vector3_Normalized()
        {
            float X = 2, Y = 4, Z = 16;
            Vector3 U = new Vector3(X, Y, Z);
            float length = U.Length;
            Vector3 V = U.Normalized();
            Assert.AreEqual(U.X / length, V.X);
            Assert.AreEqual(U.Y / length, V.Y);
            Assert.AreEqual(U.Z / length, V.Z);
        }

        [Test]
        public void Vector3_NormalizeFast_Instance()
        {
            float X = 2, Y = 4, Z = 16;
            Vector3 U = new Vector3(X, Y, Z);
            Vector3 V = U;
            V.NormalizeFast();
            float scale = MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z);
            Assert.AreEqual(U.X * scale, V.X);
            Assert.AreEqual(U.Y * scale, V.Y);
            Assert.AreEqual(U.Z * scale, V.Z);
        }

        [Test]
        public void Vector3_Add()
        {
            Vector3 T = new Vector3(7, 8, 9);
            Vector3 U = new Vector3(23, 89, -34);
            Vector3 V = Vector3.Add(T, U);
            Assert.AreEqual(T.X + U.X, V.X);
            Assert.AreEqual(T.Y + U.Y, V.Y);
            Assert.AreEqual(T.Z + U.Z, V.Z);
        }

        [Test]
        public void Vector3_Subtract()
        {
            Vector3 T = new Vector3(7, 8, 9);
            Vector3 U = new Vector3(23, 89, -34);
            Vector3 V = Vector3.Subtract(T, U);
            Assert.AreEqual(T.X - U.X, V.X);
            Assert.AreEqual(T.Y - U.Y, V.Y);
            Assert.AreEqual(T.Z - U.Z, V.Z);
        }

        [Test]
        public void Vector3_Multiply_Scalar()
        {
            float scalar = 5.5f;
            Vector3 U = new Vector3(23, 89, -34);
            Vector3 V = Vector3.Multiply(U, scalar);
            Assert.AreEqual(U.X * scalar, V.X);
            Assert.AreEqual(U.Y * scalar, V.Y);
            Assert.AreEqual(U.Z * scalar, V.Z);
        }

        [Test]
        public void Vector3_Multiply_Componentwise()
        {
            Vector3 T = new Vector3(7, 8, 0.5f);
            Vector3 U = new Vector3(23, 89, -34);
            Vector3 V = Vector3.Multiply(T, U);
            Assert.AreEqual(T.X * U.X, V.X);
            Assert.AreEqual(T.Y * U.Y, V.Y);
            Assert.AreEqual(T.Z * U.Z, V.Z);
        }

        [Test]
        public void Vector3_Divide_Scalar()
        {
            float scalar = 5.5f;
            Vector3 U = new Vector3(23, 89, -34);
            Vector3 V = Vector3.Divide(U, scalar);
            //we have to account for a small amount of round off error
            //in this division test
            Assert.IsTrue(Math.Abs((U.X / scalar) - V.X) < 1e-5);
            Assert.IsTrue(Math.Abs((U.Y / scalar) - V.Y) < 1e-5);
            Assert.IsTrue(Math.Abs((U.Z / scalar) - V.Z) < 1e-5);
        }

        [Test]
        public void Vector3_ComponentMin()
        {
            Vector3 T = new Vector3(1, 55, -100);
            Vector3 U = new Vector3(24, 3, 1);
            Vector3 V = Vector3.ComponentMin(T, U);
            Assert.AreEqual(1, V.X);
            Assert.AreEqual(3, V.Y);
            Assert.AreEqual(-100, V.Z);
        }

        [Test]
        public void Vector3_ComponentMinOut()
        {
            Vector3 T = new Vector3(1, 55, -100);
            Vector3 U = new Vector3(24, 3, 1);
            Vector3 V;
            Vector3.ComponentMin(ref T, ref U, out V);
            Assert.AreEqual(1, V.X);
            Assert.AreEqual(3, V.Y);
            Assert.AreEqual(-100, V.Z);
        }

        [Test]
        public void Vector3_ComponentMax()
        {
            Vector3 T = new Vector3(1, 55, -100);
            Vector3 U = new Vector3(24, 3, 1);
            Vector3 V = Vector3.ComponentMax(T, U);
            Assert.AreEqual(24, V.X);
            Assert.AreEqual(55, V.Y);
            Assert.AreEqual(1, V.Z);
        }

        [Test]
        public void Vector3_ComponentMaxOut()
        {
            Vector3 T = new Vector3(1, 55, -100);
            Vector3 U = new Vector3(24, 3, 1);
            Vector3 V;
            Vector3.ComponentMax(ref T, ref U, out V);
            Assert.AreEqual(24, V.X);
            Assert.AreEqual(55, V.Y);
            Assert.AreEqual(1, V.Z);
        }

        [Test]
        public void Vector3_Min()
        {
            Vector3 T = new Vector3(1, 2, 3);
            Vector3 U = new Vector3(24, 300, 88);
            Vector3 result = Vector3.Min(T, U);
            Assert.IsTrue(result == T);
        }

        [Test]
        public void Vector3_Max()
        {
            Vector3 T = new Vector3(1, 2, 3);
            Vector3 U = new Vector3(24, 300, 88);
            Vector3 result = Vector3.Max(T, U);
            Assert.IsTrue(result == U);
        }

        [Test]
        public void Vector3_Clamp()
        {
            Vector3 V = new Vector3(-6, 302, -22);
            Vector3 min = new Vector3(-5, -10, -20);
            Vector3 max = new Vector3(24, 300, 55);
            Vector3 result = Vector3.Clamp(V, min, max);
            Assert.AreEqual(result.X, -5);
            Assert.AreEqual(result.Y, 300);
            Assert.AreEqual(result.Z, -20);
        }

        [Test]
        public void Vector3_ClampOut()
        {
            Vector3 V = new Vector3(-6, 302, -22);
            Vector3 min = new Vector3(-5, -10, -20);
            Vector3 max = new Vector3(24, 300, 55);
            Vector3 result;
            Vector3.Clamp(ref V, ref min, ref max, out result);
            Assert.AreEqual(result.X, -5);
            Assert.AreEqual(result.Y, 300);
            Assert.AreEqual(result.Z, -20);
        }

        [Test]
        public void Vector3_Normalize()
        {
            float X = 64, Y = 144, Z = 16;
            Vector3 U = new Vector3(X, Y, Z);
            Vector3 V = Vector3.Normalize(U);
            float length = U.Length;
            Assert.IsTrue(Math.Abs((U.X / length) - V.X) < 1e-5);
            Assert.IsTrue(Math.Abs((U.Y / length) - V.Y) < 1e-5);
            Assert.IsTrue(Math.Abs((U.Z / length) - V.Z) < 1e-5);
        }

        [Test]
        public void Vector3_NormalizeOut()
        {
            float X = 64, Y = 144, Z = 16;
            Vector3 U = new Vector3(X, Y, Z);
            Vector3 V;
            Vector3.Normalize(ref U, out V);
            float length = U.Length;
            Assert.IsTrue(Math.Abs((U.X / length) - V.X) < 1e-5);
            Assert.IsTrue(Math.Abs((U.Y / length) - V.Y) < 1e-5);
            Assert.IsTrue(Math.Abs((U.Z / length) - V.Z) < 1e-5);
        }

        [Test]
        public void Vector3_NormalizeFast_Static()
        {
            float X = 64, Y = 144, Z = 16;
            Vector3 U = new Vector3(X, Y, Z);
            Vector3 V = Vector3.NormalizeFast(U);
            float scale = MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z);
            Assert.AreEqual(U.X * scale, V.X);
            Assert.AreEqual(U.Y * scale, V.Y);
            Assert.AreEqual(U.Z * scale, V.Z);
        }

        [Test]
        public void Vector3_NormalizeFast()
        {
            float X = 64, Y = 144, Z = 16;
            Vector3 U = new Vector3(X, Y, Z);
            Vector3 V;
            Vector3.NormalizeFast(ref U, out V);
            float scale = MathHelper.InverseSqrtFast(X * X + Y * Y + Z * Z);
            Assert.AreEqual(U.X * scale, V.X);
            Assert.AreEqual(U.Y * scale, V.Y);
            Assert.AreEqual(U.Z * scale, V.Z);
        }

        [Test]
        public void Vector3_Dot()
        {
            Vector3 T = new Vector3(7, 8, 9);
            Vector3 U = new Vector3(23, 89, -34);
            float dot = Vector3.Dot(T, U);
            float expected = T.X * U.X + T.Y * U.Y + T.Z * U.Z;
            Assert.AreEqual(expected, dot);
        }

        [Test]
        public void Vector3_Cross()
        {
            Vector3 T = new Vector3(7, 8, 9);
            Vector3 U = new Vector3(23, 89, -34);
            Vector3 expected = new Vector3(-1073, 445, 439);
            Vector3 result = Vector3.Cross(T, U);
            Assert.IsTrue(expected == result);
        }

        [Test]
        public void Vector3_Lerp()
        {
            Vector3 T = new Vector3(7, 8, 9);
            Vector3 U = new Vector3(23, 89, -34);
            float blend = 0.25f;
            Vector3 expected = blend * (U - T) + T;
            Vector3 result = Vector3.Lerp(T, U, blend);
            Assert.IsTrue(expected == result);
        }

        [Test]
        public void Vector3_LerpOut()
        {
            Vector3 T = new Vector3(7, 8, 9);
            Vector3 U = new Vector3(23, 89, -34);
            float blend = 0.25f;
            Vector3 expected = blend * (U - T) + T;
            Vector3 result;
            Vector3.Lerp(ref T, ref U, blend, out result);
            Assert.IsTrue(expected == result);
        }

        [Test]
        public void Vector3_BaryCentric()
        {
            Vector3 a = new Vector3(7, 8, 9);
            Vector3 b = new Vector3(23, 89, -34);
            Vector3 c = new Vector3(88, -42, 39);
            float u = 0.25f;
            float v = 0.75f;
            Vector3 expected = a + u * (b - a) + v * (c - a);
            Vector3 result = Vector3.BaryCentric(a, b, c, u, v);
            Assert.IsTrue(expected == result);
        }

        [Test]
        public void Vector3_BaryCentricOut()
        {
            Vector3 a = new Vector3(7, 8, 9);
            Vector3 b = new Vector3(23, 89, -34);
            Vector3 c = new Vector3(88, -42, 39);
            float u = 0.25f;
            float v = 0.75f;
            Vector3 expected = a + u * (b - a) + v * (c - a);
            Vector3 result;
            Vector3.BaryCentric(ref a, ref b, ref c, u, v, out result);
            Assert.IsTrue(expected == result);
        }

        [Test]
        public void Vector3_Matrix3TimesVector3_operator()
        {
            Matrix3 A = new Matrix3();
            A[0, 0] = 16; A[0, 1] = 15; A[0, 2] = 14;
            A[1, 0] = 12; A[1, 1] = 11; A[1, 2] = 10;
            A[2, 0] = 8; A[2, 1] = 7; A[2, 2] = 6;

            Vector3 input = new Vector3(1, 5, 9);
            Vector3 result = A * input;
            OpenTK.Vector3 expected = new OpenTK.Vector3(217, 157, 97);
            Assert.IsTrue(expected == result);
        }

        [Test]
        public void Vector3_Equal_operator()
        {
            Vector3 V = new Vector3(1, 2, 3);
            Vector3 U = new Vector3(1, 2, 3);
            Assert.IsTrue(U == V);
        }


    }
}

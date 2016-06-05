using System;
using OpenTK;
using Xunit;

namespace OpenTK.Tests
{
    public class Matrix4Test
    {
        [Fact]
        public void Matrix4_SixteenValueConstructor()
        {
            Matrix4 A = new Matrix4( 0,  1,  2,  3,
                                     4,  5,  6,  7,
                                     8,  9, 10, 11,
                                    12, 13, 14, 15);

            Assert.Equal(0, A.M11);
            Assert.Equal(1, A.M12);
            Assert.Equal(2, A.M13);
            Assert.Equal(3, A.M14);

            Assert.Equal(4, A.M21);
            Assert.Equal(5, A.M22);
            Assert.Equal(6, A.M23);
            Assert.Equal(7, A.M24);

            Assert.Equal(8, A.M31);
            Assert.Equal(9, A.M32);
            Assert.Equal(10, A.M33);
            Assert.Equal(11, A.M34);

            Assert.Equal(12, A.M41);
            Assert.Equal(13, A.M42);
            Assert.Equal(14, A.M43);
            Assert.Equal(15, A.M44);
        }

        [Fact]
        public void Matrix4_Matrix3Constructor()
        {
            Matrix3 B = new Matrix3( 1, 2, 3,
                                     4, 5, 6,
                                     7, 8, 9);

            Matrix4 A = new Matrix4(B);

            Assert.Equal(B.M11, A.M11);
            Assert.Equal(B.M12, A.M12);
            Assert.Equal(B.M13, A.M13);

            Assert.Equal(B.M21, A.M21);
            Assert.Equal(B.M22, A.M22);
            Assert.Equal(B.M23, A.M23);

            Assert.Equal(B.M31, A.M31);
            Assert.Equal(B.M32, A.M32);
            Assert.Equal(B.M33, A.M33);
        }

        [Fact]
        public void Matrix4_FourVector4Constructor()
        {
            Vector4 V = new Vector4(1, 2, 3, 4);
            Vector4 U = new Vector4(5, 6, 7, 8);
            Vector4 S = new Vector4(9, 10, 11, 12);
            Vector4 T = new Vector4(13, 14, 15, 16);

            Matrix4 A = new Matrix4(V, U, S, T);

            Assert.Equal(V.X, A.M11);
            Assert.Equal(V.Y, A.M12);
            Assert.Equal(V.Z, A.M13);
            Assert.Equal(V.W, A.M14);

            Assert.Equal(U.X, A.M21);
            Assert.Equal(U.Y, A.M22);
            Assert.Equal(U.Z, A.M23);
            Assert.Equal(U.W, A.M24);

            Assert.Equal(S.X, A.M31);
            Assert.Equal(S.Y, A.M32);
            Assert.Equal(S.Z, A.M33);
            Assert.Equal(S.W, A.M34);

            Assert.Equal(T.X, A.M41);
            Assert.Equal(T.Y, A.M42);
            Assert.Equal(T.Z, A.M43);
            Assert.Equal(T.W, A.M44);

        }

        [Fact]
        public void Matrix4_Equal_operator()
        {
            Matrix4 A = new Matrix4( 0,  1,  2,  3,
                                     4,  5,  6,  7,
                                     8,  9, 10, 11,
                                    12, 13, 14, 15);

            Matrix4 B = new Matrix4( 0,  1,  2,  3,
                                     4,  5,  6,  7,
                                     8,  9, 10, 11,
                                    12, 13, 14, 15);

            Assert.True(A == B);
        }

        [Fact]
        public void Matrix4_Matrix4TimesMatrix4_operator()
        {
            Matrix4 A = new Matrix4( 0,  1,  2,  3,
                                     4,  5,  6,  7,
                                     8,  9, 10, 11,
                                    12, 13, 14, 15);

            Matrix4 B = new Matrix4( 0,  1,  2,  3,
                                     4,  5,  6,  7,
                                     8,  9, 10, 11,
                                    12, 13, 14, 15);

            Matrix4 expected = new Matrix4( 56,  62,  68,  74,
                                           152, 174, 196, 218,
                                           248, 286, 324, 362,
                                           344, 398, 452, 506);

            Matrix4 result = A * B;
            Assert.True(expected == result);
        }

        [Fact]
        public void Matrix4_Matrix4PlusMatrix4_operator()
        {
            Matrix4 A = new Matrix4( 0,  1,  2,  3,
                                     4,  5,  6,  7,
                                     8,  9, 10, 11,
                                    12, 13, 14, 15);

            Matrix4 B = new Matrix4( 0,  1,  2,  3,
                                     4,  5,  6,  7,
                                     8,  9, 10, 11,
                                    12, 13, 14, 15);

            Matrix4 expected = new Matrix4( 0,  2,  4,  6,
                                            8, 10, 12, 14,
                                           16, 18, 20, 22,
                                           24, 26, 28, 30);

            Matrix4 result = A + B;
            Assert.True(expected == result);
        }

        [Fact]
        public void Matrix4_Matrix4MinusMatrix4_operator()
        {
            Matrix4 A = new Matrix4( 0,  1,  2,  3,
                                     4,  5,  6,  7,
                                     8,  9, 10, 11,
                                    12, 13, 14, 15);

            Matrix4 B = new Matrix4( 0,  1,  2,  3,
                                     4,  5,  6,  7,
                                     8,  9, 10, 11,
                                    12, 13, 14, 15);

            Matrix4 expected = new Matrix4( 0, 0, 0, 0,
                                            0, 0, 0, 0,
                                            0, 0, 0, 0,
                                            0, 0, 0, 0);

            Matrix4 result = A - B;
            Assert.True(expected == result);
        }

        [Fact]
        public void Matrix4_Index_Operator()
        {
            Matrix4 A = new Matrix4();
            A[0, 0] = 0;
            A[0, 1] = 1;
            A[0, 2] = 2;
            A[0, 3] = 3;
            A[1, 0] = 4;
            A[1, 1] = 5;
            A[1, 2] = 6;
            A[1, 3] = 7;
            A[2, 0] = 8;
            A[2, 1] = 9;
            A[2, 2] = 10;
            A[2, 3] = 11;
            A[3, 0] = 12;
            A[3, 1] = 13;
            A[3, 2] = 14;
            A[3, 3] = 15;
            Assert.Equal(0, A[0, 0]);
            Assert.Equal(1, A[0, 1]);
            Assert.Equal(2, A[0, 2]);
            Assert.Equal(3, A[0, 3]);
            Assert.Equal(4, A[1, 0]);
            Assert.Equal(5, A[1, 1]);
            Assert.Equal(6, A[1, 2]);
            Assert.Equal(7, A[1, 3]);
            Assert.Equal(8, A[2, 0]);
            Assert.Equal(9, A[2, 1]);
            Assert.Equal(10, A[2, 2]);
            Assert.Equal(11, A[2, 3]);
            Assert.Equal(12, A[3, 0]);
            Assert.Equal(13, A[3, 1]);
            Assert.Equal(14, A[3, 2]);
            Assert.Equal(15, A[3, 3]);
        }

        [Fact]
        public void Matrix4_Index_NegativeIndexException()
        {
            Matrix4 A = new Matrix4();
            bool negativeIndexException = false;
            try
            {
                A[-1, 2] = 0;
            }
            catch(Exception)
            {
                negativeIndexException = true;
            }
            Assert.True(negativeIndexException);

            negativeIndexException = false;
            try
            {
                A[1, -2] = 0;
            }
            catch (Exception)
            {
                negativeIndexException = true;
            }
            Assert.True(negativeIndexException);

            negativeIndexException = false;
            try
            {
                A[-1, -2] = 0;
            }
            catch (Exception)
            {
                negativeIndexException = true;
            }
            Assert.True(negativeIndexException);
        }

        [Fact]
        public void Matrix4_Index_LargeIndexException()
        {
            Matrix4 A = new Matrix4();
            bool largeIndexException = false;
            try
            {
                A[5, 2] = 0;
            }
            catch (Exception)
            {
                largeIndexException = true;
            }
            Assert.True(largeIndexException);

            largeIndexException = false;
            try
            {
                A[1, 6] = 0;
            }
            catch (Exception)
            {
                largeIndexException = true;
            }
            Assert.True(largeIndexException);

            largeIndexException = false;
            try
            {
                A[7, 12] = 0;
            }
            catch (Exception)
            {
                largeIndexException = true;
            }
            Assert.True(largeIndexException);
        }
    }
}

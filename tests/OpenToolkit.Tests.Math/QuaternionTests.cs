using OpenTK.Mathematics;
using OpenTK.Tests.Math.DataProviders;
using OpenTK.Tests.Math.Helpers;
using Xunit;

namespace OpenTK.Tests.Math
{
    public class QuaternionTests
    {
        /// <summary>
        /// Contains all tests which cover the constructor of Quaternion.
        /// </summary>
        public class Constructor
        {
            /// <summary>
            /// Checks if a single given value (either pitch, yaw or roll) get converted into correct x,y,z value of quaternion.
            /// </summary>
            /// <param name="eulerValues">euler angle values.</param>
            /// <param name="expectedResult">expected xyz component of quaternion.</param>
            [Theory]
            [MemberData(nameof(QuaternionTestDataGenerator.SingleAxisTestCases), MemberType =
                typeof(QuaternionTestDataGenerator))]
            public void SingleAxisAsEulerAnglesInFloatsIsConvertedToCorrectQuaternionComponents
                (Vector3 eulerValues, Vector3 expectedResult)
            {
                //Arrange + Act: Create Quaternion with "pitch/yaw/roll"
                var cut = new Quaternion(eulerValues.X, eulerValues.Y, eulerValues.Z);

                //Assert: Use helper, to check if part of the two correct axis is zero. I just want check the direction
                var resultXYZ = cut.Xyz;

                Assert.True(QuaternionTestHelper.VerifyEqualSingleDirection(resultXYZ, expectedResult));
            }

            /// <summary>
            /// Checks if a single given value (either pitch, yaw or roll) get converted into correct x,y,z value of quaternion.
            /// </summary>
            /// <param name="eulerValues">euler angle values.</param>
            /// <param name="expectedResult">expected xyz component of quaternion.</param>
            [Theory]
            [MemberData(nameof(QuaternionTestDataGenerator.SingleAxisTestCases), MemberType =
                typeof(QuaternionTestDataGenerator))]
            public void SingleAxisAsEulerAnglesInVector3IsConvertedToCorrectQuaternionComponents
                (Vector3 eulerValues, Vector3 expectedResult)
            {
                //Arrange + Act: Create Quaternion with "pitch/yaw/roll"
                var cut = new Quaternion(eulerValues);

                //Assert: Use helper, to check if part of the two correct axis is zero. I just want check the direction
                var resultXYZ = cut.Xyz;

                Assert.True(QuaternionTestHelper.VerifyEqualSingleDirection(resultXYZ, expectedResult));
            }

            //TODO: Make also checks with ccw rotation angle and correct applied rotation order of multiple axis
        }

        /// <summary>
        /// Contains all tests for FromEulerAngles
        /// </summary>
        public class FromEulerAngles
        {
            /// <summary>
            /// Checks if a single given value (either pitch, yaw or roll) get converted into correct x,y,z value of quaternion.
            /// </summary>
            /// <param name="eulerValues">euler angle values.</param>
            /// <param name="expectedResult">expected xyz component of quaternion.</param>
            [Theory]
            [MemberData(nameof(QuaternionTestDataGenerator.SingleAxisTestCases), MemberType =
                typeof(QuaternionTestDataGenerator))]
            public void SingleAxisAsEulerAnglesInFloatsIsConvertedToCorrectQuaternionComponents
                (Vector3 eulerValues, Vector3 expectedResult)
            {
                //Arrange + Act: Create Quaternion with "pitch/yaw/roll"
                var cut = Quaternion.FromEulerAngles(eulerValues.X, eulerValues.Y, eulerValues.Z);

                //Assert: Use helper, to check if part of the two correct axis is zero. I just want check the direction
                var resultXYZ = cut.Xyz;

                Assert.True(QuaternionTestHelper.VerifyEqualSingleDirection(resultXYZ, expectedResult));
            }

            /// <summary>
            /// Checks if a single given value (either pitch, yaw or roll) get converted into correct x,y,z value of quaternion.
            /// </summary>
            /// <param name="eulerValues">euler angle values.</param>
            /// <param name="expectedResult">expected xyz component of quaternion.</param>
            [Theory]
            [MemberData(nameof(QuaternionTestDataGenerator.SingleAxisTestCases), MemberType =
                typeof(QuaternionTestDataGenerator))]
            public void SingleAxisAsEulerAnglesInVector3IsConvertedToCorrectQuaternionComponents
                (Vector3 eulerValues, Vector3 expectedResult)
            {
                //Arrange + Act: Create Quaternion with "pitch/yaw/roll"
                var cut = Quaternion.FromEulerAngles(eulerValues);

                //Assert: Use helper, to check if part of the two correct axis is zero. I just want check the direction
                var resultXYZ = cut.Xyz;

                Assert.True(QuaternionTestHelper.VerifyEqualSingleDirection(resultXYZ, expectedResult));
            }

            /// <summary>
            /// Checks if a single given value (either pitch, yaw or roll) get converted into correct x,y,z value of quaternion.
            /// </summary>
            /// <param name="eulerValues">euler angle values.</param>
            /// <param name="expectedResult">expected xyz component of quaternion.</param>
            [Theory]
            [MemberData(nameof(QuaternionTestDataGenerator.SingleAxisTestCases), MemberType =
                typeof(QuaternionTestDataGenerator))]
            public void SingleAxisAsEulerAnglesInVector3IsConvertedToCorrectQuaternionComponentsAsOutParam
                (Vector3 eulerValues, Vector3 expectedResult)
            {
                //Arrange + Act: Create Quaternion with "pitch/yaw/roll"
                var cut = Quaternion.Identity;
                Quaternion.FromEulerAngles(ref eulerValues, out cut);

                //Assert: Use helper, to check if part of the two correct axis is zero. I just want check the direction
                var resultXYZ = cut.Xyz;

                Assert.True(QuaternionTestHelper.VerifyEqualSingleDirection(resultXYZ, expectedResult));
            }

            //TODO: Make also checks with ccw rotation angle and correct applied rotation order of multiple axis
        }


        /// <summary>
        /// Contains all test for ToAxisAngle
        /// </summary>
        public class ToAxisAngle
        {
            /// <summary>
            /// Check if a quaternion returns a a rotation about the correct coordinate axis
            /// </summary>
            /// <param name="cut">Prepared Quaternion.</param>
            /// <param name="expectedResult">Expected result.</param>
            [Theory]
            [MemberData(nameof(QuaternionTestDataGenerator.ToAxisAngleTestCases), MemberType =
                typeof(QuaternionTestDataGenerator))]
            public void PreparedSingleRotationAxisQuaternionConvertsToCorrectAxisAngleRepresentation(Quaternion cut,
                Vector3 expectedResult)
            {
                //Arrange + Act: Create Quaternion with rotation about X/Y/Z axis
                Vector3 resultXYZ;
                float dontCare;
                cut.ToAxisAngle(out resultXYZ, out dontCare);

                //Assert: Use helper, to check if part of the two correct axis is zero. I just want check the direction
                Assert.True(QuaternionTestHelper.VerifyEqualSingleDirection(resultXYZ, expectedResult));
            }

            //TODO: Make also checks with ccw rotation angle and correct applied rotation order of multiple axis
        }
    }
}

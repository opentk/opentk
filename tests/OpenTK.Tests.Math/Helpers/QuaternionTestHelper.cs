using OpenTK.Mathematics;

namespace OpenTK.Tests.Math.Helpers
{
    /// <summary>
    /// Provides some methods which helps to verify test results
    /// </summary>
    internal static class QuaternionTestHelper
    {
        /// <summary>
        /// Verifies the direction of an given <see cref="Vector3" />.
        /// </summary>
        /// <returns>
        /// false: When <paramref name="toTest" /> does contain xyz values, when it should be 0,
        /// or does not contain 0 when it should be
        /// </returns>
        /// <param name="toTest">To test.</param>
        /// <param name="expected">Expected directions. Values getting only 0 checked.</param>>
        public static bool VerifyEqualSingleDirection(Vector3 toTest, Vector3 expected)
        {
            //To verify the direction of an vector, just respect the 0 values and check against these.
            //The length of the vectors are ignored.
            if (expected.X == 0)
            {
                if (toTest.X != 0)
                {
                    return false;
                }
            }
            else
            {
                if (toTest.X == 0)
                {
                    return false;
                }
            }

            if (expected.Y == 0)
            {
                if (toTest.Y != 0)
                {
                    return false;
                }
            }
            else
            {
                if (toTest.Y == 0)
                {
                    return false;
                }
            }

            if (expected.Z == 0)
            {
                if (toTest.Z != 0)
                {
                    return false;
                }
            }
            else
            {
                if (toTest.Z == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

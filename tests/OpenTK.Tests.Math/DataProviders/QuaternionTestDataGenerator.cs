using System.Collections.Generic;
using OpenTK.Mathematics;

namespace OpenTK.Tests.Math.DataProviders
{
    /// <summary>
    /// Generates/Provides Quaternion test data.
    /// </summary>
    public class QuaternionTestDataGenerator
    {
        /// <summary>
        /// Returns the single axis test cases.
        /// 1. param: rotation in euler angles
        /// 2. param: expected result of xyz-component of quaternion
        /// </summary>
        /// <value>The single axis test cases.</value>
        public static IEnumerable<object[]> SingleAxisTestCases()
        {
            yield return new object[] { new Vector3(1, 0, 0), Vector3.UnitX }; //"Rotate around x axis"
            yield return new object[] { new Vector3(0, 1, 0), Vector3.UnitY }; //"Rotate around y axis"
            yield return new object[] { new Vector3(0, 0, 1), Vector3.UnitZ }; //"Rotate around z axis"
        }

        /// <summary>
        /// Returns the single ToAxisAngle test cases.
        /// 1. param: Quaternion which a definied value of xyz-component.
        /// 2. param: expected result of xyz-component of quaternion
        /// </summary>
        /// <value>The single axis test cases.</value>
        public static IEnumerable<object[]> ToAxisAngleTestCases()
        {
            yield return new object[] { new Quaternion(Vector3.UnitX, 0), Vector3.UnitX }; //"Rotate around x axis"
            yield return new object[] { new Quaternion(Vector3.UnitY, 0), Vector3.UnitY }; //"Rotate around y axis"
            yield return new object[] { new Quaternion(Vector3.UnitZ, 0), Vector3.UnitZ }; //"Rotate around z axis"
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections;
namespace OpenTK.Tests.CSharp
{
	/// <summary>
	/// Quaternion test data.
	/// </summary>
	internal class QuaternionTestData
	{
		/// <summary>
		/// Gets the single axis test cases.
		/// </summary>
		/// <value>The single axis test cases.</value>
		public static IEnumerable SingleAxisTestCases
		{
			get
			{
				yield return new TestCaseData(new Vector3(1, 0, 0), Vector3.UnitX).SetName("Rotate around x axis");
				yield return new TestCaseData(new Vector3(0, 1, 0), Vector3.UnitY).SetName("Rotate around y axis");
				yield return new TestCaseData(new Vector3(0, 0, 1), Vector3.UnitZ).SetName("Rotate around z axis");
			}
		}
	}

	/// <summary>
	/// Provides some methods which helps to verify test results
	/// </summary>
	internal static class QuaternionTestHelper
	{
		/// <summary>
		/// Verifies the direction of an given <see cref="Vector3"/>
		/// </summary>
		/// <returns>The direction.</returns>
		/// <param name="toTest">To test.</param>
		/// <param name="expected">Expected.</param>
		public static bool VerifyEuqalDirection(Vector3 toTest, Vector3 expected)
		{
			//To verify the direction of an vector, just respect the 0 values and check against these.
			//The length of the vectors are ignored.
			if (expected.X == 0)
			{
				if (toTest.X != 0)
					return false;
			}

			if (expected.Y == 0)
			{
				if (toTest.Y != 0)
					return false;
			}

			if (expected.Z == 0)
			{
				if (toTest.Z != 0)
					return false;
			}

			return true;
		}
	}

	[TestFixture()]
	public class Quaternion_Tests
	{
		/// <summary>
		/// Checks if a single given value (either pitch, yaw or roll) get converted into correct x,y,z value of quaternion.
		/// </summary>
		/// <param name="rotationAxis">euler angle values</param>
		[Test, TestCaseSource(typeof(QuaternionTestData), "SingleAxisTestCases")]
		public void CtorEulerAngles_SingleEulerAngleSet_RotateCorrectAxis(Vector3 eulerValues, Vector3 expectedResult)
		{
			//Arrange + Act: Create Quaternion with "pitch"
			var cut = new Quaternion(eulerValues.X, eulerValues.Y, eulerValues.Z);

			//Assert: Normalize result, cause I am just interested if vector is parallel to correct expected axis
			Vector3 resultXYZ = cut.Xyz;
			resultXYZ.Normalize();

			Assert.IsTrue(QuaternionTestHelper.VerifyEuqalDirection(resultXYZ, expectedResult));
		}
	}
}


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

		public static IEnumerable ToAxisAngleTestCases
		{
			get
			{
				yield return new TestCaseData(new Quaternion(Vector3.UnitX, 0), Vector3.UnitX).SetName("Rotate around x axis");
				yield return new TestCaseData(new Quaternion(Vector3.UnitY, 0), Vector3.UnitY).SetName("Rotate around y axis");
				yield return new TestCaseData(new Quaternion(Vector3.UnitZ, 0), Vector3.UnitZ).SetName("Rotate around z axis");
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
			//Arrange + Act: Create Quaternion with "pitch/yaw/roll"
			var cut = new Quaternion(eulerValues.X, eulerValues.Y, eulerValues.Z);

			//Assert: Use helper, to check if part of the two correct axis is zero. I just want check the direction
			Vector3 resultXYZ = cut.Xyz;

			Assert.IsTrue(QuaternionTestHelper.VerifyEuqalDirection(resultXYZ, expectedResult));
		}

		/// <summary>
		/// Checks if a single given value (either pitch, yaw or roll) get converted into correct x,y,z value of quaternion.
		/// </summary>
		/// <param name="rotationAxis">euler angle values</param>
		[Test, TestCaseSource(typeof(QuaternionTestData), "SingleAxisTestCases")]
		public void FromEulerAngles_SingleEulerAngleSet_RotateCorrectAxis(Vector3 eulerValues, Vector3 expectedResult)
		{
			//Arrange + Act: Create Quaternion with "pitch/yaw/roll"
			var cut = Quaternion.FromEulerAngles(eulerValues.X, eulerValues.Y, eulerValues.Z);

			//Assert: Use helper, to check if part of the two correct axis is zero. I just want check the direction
			Vector3 resultXYZ = cut.Xyz;

			Assert.IsTrue(QuaternionTestHelper.VerifyEuqalDirection(resultXYZ, expectedResult));
		}

		/// <summary>
		/// Check if a quaternion returns a a rotation about the correct coordinate axis
		/// </summary>
		/// <returns>The axis angle single axis set and angle ignored rotate correct axis.</returns>
		/// <param name="cut">Cut.</param>
		/// <param name="expectedResult">Expected result.</param>
		[Test, TestCaseSource(typeof(QuaternionTestData), "ToAxisAngleTestCases")]
		public void ToAxisAngle_SingleAxisSetAndAngleIgnored_RotateCorrectAxis(Quaternion cut, Vector3 expectedResult)
		{
			//Arrange + Act: Create Quaternion with rotation about X/Y/Z axis
			Vector3 resultXYZ;
			float dontCare;
			cut.ToAxisAngle(out resultXYZ, out dontCare);

			//Assert: Use helper, to check if part of the two correct axis is zero. I just want check the direction
			Assert.IsTrue(QuaternionTestHelper.VerifyEuqalDirection(resultXYZ, expectedResult));
		}

		//TODO: Make also checks with rotation angle
	}
}


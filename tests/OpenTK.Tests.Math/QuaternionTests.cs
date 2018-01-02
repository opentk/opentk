using Xunit;
using System;
using System.Collections.Generic;

namespace OpenTK.Tests.Math
{
	/// <summary>
	/// Generates Quaternion test data.
	/// </summary>
	public class QuaternionTestDataGenerator
	{
		/// <summary>
		/// Returns the single axis test cases.
		/// 1. param: rotation in euler angles
		/// 2. param: expected result of xyz-component of quaternion
		/// 3. param: test name (Don't found a working way how to pass this to xUnit runner). I let it here for test documentation
		/// </summary>
		/// <value>The single axis test cases.</value>
		public static IEnumerable<object> SingleAxisTestCases()
		{
			yield return new object[] { new Vector3(1, 0, 0), Vector3.UnitX, "Rotate around x axis" };
			yield return new object[] { new Vector3(0, 1, 0), Vector3.UnitY, "Rotate around y axis" };
			yield return new object[] { new Vector3(0, 0, 1), Vector3.UnitZ, "Rotate around z axis" };
		}

		/// <summary>
		/// Returns the single ToAxisAngle test cases.
		/// 1. param: Quaternion which a definied value of xyz-component.
		/// 2. param: expected result of xyz-component of quaternion
		/// 3. param: test name (Don't found a working way how to pass this to xUnit runner). I let it here for test documentation
		/// </summary>
		/// <value>The single axis test cases.</value>
		public static IEnumerable<object[]> ToAxisAngleTestCases()
		{
			yield return new object[] { new Quaternion(Vector3.UnitX, 0), Vector3.UnitX, "Rotate around x axis" };
			yield return new object[] { new Quaternion(Vector3.UnitY, 0), Vector3.UnitY, "Rotate around y axis" };
			yield return new object[] { new Quaternion(Vector3.UnitZ, 0), Vector3.UnitZ, "Rotate around z axis" };
		}
	}

	/// <summary>
	/// Provides some methods which helps to verify test results
	/// </summary>
	internal static class QuaternionTestHelper
	{
		/// <summary>
		/// Verifies the direction of an given <see cref="Vector3"/>.
		/// </summary>
		/// <returns>false: When <paramref name="toTest"/> does contain xyz values, when it should be 0,
		/// or does not contain 0 when it should be</returns>
		/// <param name="toTest">To test</param>
		/// <param name="expected">Expected directions. Values getting only 0 checked</param>
		public static bool VerifyEuqalSignleDirection(Vector3 toTest, Vector3 expected)
		{
			//To verify the direction of an vector, just respect the 0 values and check against these.
			//The length of the vectors are ignored.
			if (expected.X == 0)
			{
				if (toTest.X != 0)
					return false;
			}
			else
			{
				if (toTest.X == 0)
					return false;
			}

			if (expected.Y == 0)
			{
				if (toTest.Y != 0)
					return false;
			}
			else
			{
				if (toTest.Y == 0)
					return false;
			}

			if (expected.Z == 0)
			{
				if (toTest.Z != 0)
					return false;
			}
			else
			{
				if (toTest.Z == 0)
					return false;
			}

			return true;
		}
	}

	public class Quaternion_Tests
	{
		/// <summary>
		/// Checks if a single given value (either pitch, yaw or roll) get converted into correct x,y,z value of quaternion.
		/// </summary>
		/// <param name="eulerValues">euler angle values</param>
		/// <param name="expectedResult">expected xyz component of quaternion</param>
		/// <param name="testName">Taken from nUnit test data. Don't know how to name data driven tests for xUnit which actually works.</param>
		[Theory]
		[MemberData(nameof(QuaternionTestDataGenerator.SingleAxisTestCases), MemberType = typeof(QuaternionTestDataGenerator))]
		public void CtorEulerAnglesFloat_SingleEulerAngleSet_RotateCorrectAxis(Vector3 eulerValues, Vector3 expectedResult, String testName)
		{
			//Arrange + Act: Create Quaternion with "pitch/yaw/roll"
			var cut = new Quaternion(eulerValues.X, eulerValues.Y, eulerValues.Z);

			//Assert: Use helper, to check if part of the two correct axis is zero. I just want check the direction
			Vector3 resultXYZ = cut.Xyz;

			Assert.True(QuaternionTestHelper.VerifyEuqalSignleDirection(resultXYZ, expectedResult));
		}

		/// <summary>
		/// Checks if a single given value (either pitch, yaw or roll) get converted into correct x,y,z value of quaternion.
		/// </summary>
		/// <param name="eulerValues">euler angle values</param>
		/// <param name="expectedResult">expected xyz component of quaternion</param>
		/// <param name="testName">Taken from nUnit test data. Don't know how to name data driven tests for xUnit which actually works.</param>
		[Theory]
		[MemberData(nameof(QuaternionTestDataGenerator.SingleAxisTestCases), MemberType = typeof(QuaternionTestDataGenerator))]
		public void CtorEulerAnglesVector3_SingleEulerAngleSet_RotateCorrectAxis(Vector3 eulerValues, Vector3 expectedResult, String testName)
		{
			//Arrange + Act: Create Quaternion with "pitch/yaw/roll"
			var cut = new Quaternion(eulerValues.X, eulerValues.Y, eulerValues.Z);

			//Assert: Use helper, to check if part of the two correct axis is zero. I just want check the direction
			Vector3 resultXYZ = cut.Xyz;

			Assert.True(QuaternionTestHelper.VerifyEuqalSignleDirection(resultXYZ, expectedResult));
		}

		/// <summary>
		/// Checks if a single given value (either pitch, yaw or roll) get converted into correct x,y,z value of quaternion.
		/// </summary>
		/// <param name="eulerValues">euler angle values</param>
		/// <param name="expectedResult">expected xyz component of quaternion</param>
		/// <param name="testName">Taken from nUnit test data. Don't know how to name data driven tests for xUnit which actually works.</param>
		[Theory]
		[MemberData(nameof(QuaternionTestDataGenerator.SingleAxisTestCases), MemberType = typeof(QuaternionTestDataGenerator))]
		public void FromEulerAnglesFloat_SingleEulerAngleSet_RotateCorrectAxis(Vector3 eulerValues, Vector3 expectedResult, String testName)
		{
			//Arrange + Act: Create Quaternion with "pitch/yaw/roll"
			var cut = Quaternion.FromEulerAngles(eulerValues.X, eulerValues.Y, eulerValues.Z);

			//Assert: Use helper, to check if part of the two correct axis is zero. I just want check the direction
			Vector3 resultXYZ = cut.Xyz;

			Assert.True(QuaternionTestHelper.VerifyEuqalSignleDirection(resultXYZ, expectedResult));
		}

		/// <summary>
		/// Checks if a single given value (either pitch, yaw or roll) get converted into correct x,y,z value of quaternion.
		/// </summary>
		/// <param name="eulerValues">euler angle values</param>
		/// <param name="expectedResult">expected xyz component of quaternion</param>
		/// <param name="testName">Taken from nUnit test data. Don't know how to name data driven tests for xUnit which actually works.</param>
		[Theory]
		[MemberData(nameof(QuaternionTestDataGenerator.SingleAxisTestCases), MemberType = typeof(QuaternionTestDataGenerator))]
		public void FromEulerAnglesVector3_SingleEulerAngleSet_RotateCorrectAxis(Vector3 eulerValues, Vector3 expectedResult, String testName)
		{
			//Arrange + Act: Create Quaternion with "pitch/yaw/roll"
			var cut = Quaternion.FromEulerAngles(eulerValues);

			//Assert: Use helper, to check if part of the two correct axis is zero. I just want check the direction
			Vector3 resultXYZ = cut.Xyz;

			Assert.True(QuaternionTestHelper.VerifyEuqalSignleDirection(resultXYZ, expectedResult));
		}

		/// <summary>
		/// Checks if a single given value (either pitch, yaw or roll) get converted into correct x,y,z value of quaternion.
		/// </summary>
		/// <param name="eulerValues">euler angle values</param>
		/// <param name="expectedResult">expected xyz component of quaternion</param>
		/// <param name="testName">Taken from nUnit test data. Don't know how to name data driven tests for xUnit which actually works.</param>
		[Theory]
		[MemberData(nameof(QuaternionTestDataGenerator.SingleAxisTestCases), MemberType = typeof(QuaternionTestDataGenerator))]
		public void FromEulerAnglesOut_SingleEulerAngleSet_RotateCorrectAxis(Vector3 eulerValues, Vector3 expectedResult, String testName)
		{
			//Arrange + Act: Create Quaternion with "pitch/yaw/roll"
			var cut = Quaternion.Identity;
			Quaternion.FromEulerAngles(ref eulerValues, out cut);

			//Assert: Use helper, to check if part of the two correct axis is zero. I just want check the direction
			Vector3 resultXYZ = cut.Xyz;

			Assert.True(QuaternionTestHelper.VerifyEuqalSignleDirection(resultXYZ, expectedResult));
		}

		/// <summary>
		/// Check if a quaternion returns a a rotation about the correct coordinate axis
		/// </summary>
		/// <param name="cut">Prepared Quaternion</param>
		/// <param name="expectedResult">Expected result.</param>
		/// <param name="testName">Taken from nUnit test data. Don't know how to name data driven tests for xUnit which actually works.</param>
		[Theory]
		[MemberData(nameof(QuaternionTestDataGenerator.ToAxisAngleTestCases), MemberType = typeof(QuaternionTestDataGenerator))]
		public void ToAxisAngle_SingleAxisSetAndAngleIgnored_RotateCorrectAxis(Quaternion cut, Vector3 expectedResult, String testName)
		{
			//Arrange + Act: Create Quaternion with rotation about X/Y/Z axis
			Vector3 resultXYZ;
			float dontCare;
			cut.ToAxisAngle(out resultXYZ, out dontCare);

			//Assert: Use helper, to check if part of the two correct axis is zero. I just want check the direction
			Assert.True(QuaternionTestHelper.VerifyEuqalSignleDirection(resultXYZ, expectedResult));
		}

		//TODO: Make also checks with rotation angle
	}
}


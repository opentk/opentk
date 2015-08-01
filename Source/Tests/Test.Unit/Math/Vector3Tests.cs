using System.Collections.Generic;
using OpenTK;
using Xunit;

namespace Test.Unit
{
	public class Vector3Tests
	{
		public static IEnumerable<object[]> AddData =
			new[]
			{
				new object[] {new Vector3(2, 5, -2), new Vector3(9, -1, 54), new Vector3(11, 4, 52)},
				new object[] {new Vector3(5, -1, -7), new Vector3(9, -1, 54), new Vector3(14, -2, 47)},
				new object[] {new Vector3(22, 55, -24), new Vector3(19, 49, 0), new Vector3(41, 104, -24)}
			};

		[Theory, MemberData("AddData")]
		public void Add_SampleVectors_AddsXyz(Vector3 left, Vector3 right, Vector3 expected)
		{
			// Arrange

			// Act
			var result = Vector3.Add(left, right);

			// Assert
			Assert.Equal(expected, result);
		}
	}
}
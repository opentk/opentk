using FsCheck.Xunit;
using OpenTK.Tests.Generators;
using Xunit;
using Assert = Xunit.Assert;

namespace OpenTK.Tests.Math
{
    public class BezierCurveTests
    {
        [Properties(Arbitrary = new[] { typeof(OpenTKGen) })]
        public class Constructor
        {
            [Property]
            public void AcceptingVector2EnumerableCreatesCurveContainingThePointsInTheEnumerable
                (Vector2 a, Vector2 b, Vector2 c, Vector2 d)
            {
                var expected = new[] { a, b, c, d };

                var curve = new BezierCurve(expected);

                var actual = curve.Points;
                Assert.Equal(expected, actual);
            }
        }

        public class CalculatePoint
        {
            [Fact]
            public void StraightLine()
            {
                var curve = new BezierCurve(Vector2.Zero, Vector2.One);
                Assert.Equal(Vector2.Zero, curve.CalculatePoint(0.0f));
                Assert.Equal(Vector2.One, curve.CalculatePoint(1.0f));
                Assert.Equal(new Vector2(0.5f, 0.5f), curve.CalculatePoint(0.5f));
            }
        }
    }
}

using OpenTK.Mathematics;
using Xunit;

namespace OpenTK.Tests.Unit
{
    public class BezierCurveTests
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
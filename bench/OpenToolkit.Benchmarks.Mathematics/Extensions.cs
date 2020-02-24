using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenToolkit.Mathematics;

namespace OpenToolkit.Benchmarks.Mathematics
{
    internal static class Extensions
    {
        internal static float NextFloat(this Random rand)
            => (float)rand.NextDouble();

        internal static Matrix3 NextMatrix3(this Random rand)
            => new Matrix3(
                rand.NextFloat(), rand.NextFloat(), rand.NextFloat(),
                rand.NextFloat(), rand.NextFloat(), rand.NextFloat(),
                rand.NextFloat(), rand.NextFloat(), rand.NextFloat());

        internal static Matrix4 NextMatrix4(this Random rand)
            => new Matrix4(
                rand.NextFloat(), rand.NextFloat(), rand.NextFloat(), rand.NextFloat(),
                rand.NextFloat(), rand.NextFloat(), rand.NextFloat(), rand.NextFloat(),
                rand.NextFloat(), rand.NextFloat(), rand.NextFloat(), rand.NextFloat(),
                rand.NextFloat(), rand.NextFloat(), rand.NextFloat(), rand.NextFloat());
    }
}

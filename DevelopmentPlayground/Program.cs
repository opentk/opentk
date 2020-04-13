using OpenToolkit.Mathematics;
using OpenToolkit.Mathematics.Rotors;
using System;

namespace DevelopmentPlayground
{
    class Program
    {
        public static void Main()
        {
            var r = new Rotor3(Vector3.UnitZ, -Vector3.UnitY);
            var pos = Vector3.UnitZ;
            var newPos = Rotor3.Rotate(r, pos);
            Console.WriteLine(pos);
            Console.WriteLine(r);
            Console.WriteLine(newPos);
        }
    }
}

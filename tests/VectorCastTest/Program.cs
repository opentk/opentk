using OpenTK.Mathematics;

namespace VectorCastTest;

class Program
{
    static void Main(string[] args)
    {
        Vector2b booleanVec2 = (true, false);
        Console.WriteLine($"The Vector2b is {booleanVec2}");
        Console.WriteLine($"To Vector2i is {(Vector2i)booleanVec2}");
        Console.WriteLine($"To Vector2 is {(Vector2)booleanVec2}");
    }
}

// This code is in the Public Domain. It is provided "as is"
// without express or implied warranty of any kind.

using System;
using System.Diagnostics;
using System.Reflection;
using OpenTK;

namespace Examples.Tests
{
    struct Simple { public int Value; }
    struct Generic<T> { public T Value; }
    enum Enum { First, Second }
    struct Complex { public Simple Value; }
    struct Complex<T> { public Generic<T> Value; }
    struct Complex2 { public Enum Value; }
    struct Complex3 { public Class Value; }
    struct Complex4 : Interface { public Class Value; }
    class Class { public int Value; }
    class Class<T> { public T Value; }
    interface Interface { }

    [Example("Blittable Value Types", ExampleCategory.OpenTK, "Test", Documentation="BlittableValueTypes")]
    public class BlittableValueTypes
    {
        public static void Main()
        {
            TestType(new Simple());
            TestType(new Generic<Simple>());
            TestType(new Generic<Enum>());
            TestType(new Complex());
            TestType(new Complex<Enum>());
            TestType(new Complex2());
            TestType(new Complex3());
            TestType(new Complex4());
            TestType(new Class());
            TestType(new Class<Simple>());
        }

        // Tests whether specified type is blittable and prints its marshalled size if so.
        static void TestType<T>(T instance)
        {
            PrintType<T>();
            
            Trace.Write(BlittableValueType.Check(instance) ? "is blittable " : "is not blittable ");

            try
            {
                // StrideOf() will throw an ArgumentException if the type is not blittable.
                Trace.Write(String.Format("({0} bytes)", BlittableValueType.StrideOf(instance)));
            }
            catch (Exception e)
            {
                Trace.Write(String.Format("({0})", e.GetType().Name));
            }
            
            Trace.WriteLine("");
        }

        // Prints a simple description for the type.
        static void PrintType<T>()
        {
            Type type = typeof(T);
            string typename = type.GetFields()[0].FieldType.ToString();

            Trace.Write(type.IsClass ? "class " : type.IsEnum ? "enum " : type.IsInterface ? "interface " : "struct ");
            Trace.Write(type.Name);
            if (type.IsGenericType)
                Trace.Write(String.Format("<{0}>", type.GetGenericArguments()[0].Name));
            Trace.Write(" { ");

            Trace.Write(typename.Substring(typename.LastIndexOf('.') + 1));
            Trace.Write(" } ");
        }
    }
}

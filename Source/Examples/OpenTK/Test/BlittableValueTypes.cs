#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2008 the Open Toolkit library, except where noted.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

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
            PrintType(new Simple());
            PrintType(new Generic<Simple>());
            PrintType(new Generic<Enum>());
            PrintType(new Complex());
            PrintType(new Complex<Enum>());
            PrintType(new Complex2());
            PrintType(new Complex3());
            PrintType(new Complex4());
            PrintType(new Class());
            PrintType(new Class<Simple>());
        }

        static bool CheckBlittable<T>(T type)
        {
            return BlittableValueType.Check(type);
        }

        static int GetStride<T>(T type)
        {
            return BlittableValueType.StrideOf(type);
        }

        static void PrintType<T>(T instance)
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
            Trace.Write(CheckBlittable(instance) ? "is blittable " : "is not blittable ");
            try { Trace.Write(String.Format("({0} bytes)", GetStride(instance))); }
            catch (Exception e) { Trace.Write(String.Format("({0})", e.GetType().Name)); }
            Trace.WriteLine("");
        }
    }
}

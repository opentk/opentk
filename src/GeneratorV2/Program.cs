using System.Diagnostics;
using GeneratorV2.Parsing;

namespace GeneratorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            var st = new Stopwatch();
            st.Start();
            using (Logger.CreateLogger("log.txt"))
            {
                //TODO: Documentation.
                //Reading
                using var stream = Reader.ReadSpecFromGithub();

                //Parsing
                var specification = new Specification();
                new Parser().Parse(stream, specification);
                

                //Overloading
                Overloader.OverloadCommands(specification);

                //Writing
                Writer.Write(specification);

                st.Stop();

                Logger.Info($"{st.ElapsedMilliseconds}");
            }
        }
    }
}

//TODO: Next time
//Project cleanup
// - Closer look at parser
// - Writer
// - Overloader

//TODO:
//Overloading
//Documentation
//Trimmer
//Buildscript
// - .gitignore

//TODO: For moving to dotnet5
//Sourcecodegenerator
//DllImport - what are we gonna do? function pointers

/*
 * TODO:
 *  OpenToolkit.Graphics.OpenGL.Current.GL.Function
 *  
 *  OpenToolkit.Graphics.OpenGL.V46.GL.Function
 *  OpenToolkit.Graphics.OpenGL.Extensions.EXT.Function
 *  OpenToolkit.Graphics.OpenGLES1.Extensions.NV.Function
 *  OpenToolkit.Graphics.OpenGLES2.V30.GL.Function
 *
 */

/*
 * OpenToolkit.Graphics
 *     /[API]opengl
 *         /All.cs
 *         /extensions
 *             /AMD
 *                  /Methods.cs
 *                  /Overloads.cs
 *             /NV
 *             /EXT
 *         /versions
 *             /V32
 *                  /Methods.cs
 *                  /Overloads.cs
 *                  /Enums.cs
 *             /V42
 *             /V46
 *     /[API]gles
 */


//public enum SomeEnumExt
//{

//}

//public enum SomeEnumV45
//{

//}
//public enum SomeEnumV46
//{

//}
//public struct SomeEnumCombined
//{
//    private readonly uint _value;

//    private SomeEnumCombined(uint value)
//    {
//        _value = value;
//    }

//    public static implicit operator SomeEnumCombined(SomeEnumExt val)
//    {
//        return new SomeEnumCombined((uint)val);
//    }
//    public static implicit operator SomeEnumCombined(SomeEnumV45 val)
//    {
//        return new SomeEnumCombined((uint)val);
//    }

//    public static implicit operator SomeEnumCombined(SomeEnumV46 val)
//    {
//        return new SomeEnumCombined((uint)val);
//    }

//    public static implicit operator uint(SomeEnumCombined val)
//    {
//        return val._value;
//    }
//}


//[Flags]
//public enum OverloadType
//{
//    None = 0,
//    Feature = 1,
//    Extension = 2,

//    All = Feature | Extension
//}

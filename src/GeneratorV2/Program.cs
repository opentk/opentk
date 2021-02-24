using System.Diagnostics;
using GeneratorV2.Data;
using GeneratorV2.Parsing;
using GeneratorV2.Writing;
using GeneratorV2.Overloading;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using GeneratorV2.Process;

namespace GeneratorV2
{
    unsafe class Program
    {
        static void Main(string[] args)
        {
            var st = new Stopwatch();
            st.Start();
            using (Logger.CreateLogger(Path.Combine(Assembly.GetEntryAssembly()!.Location, "log.txt")))
            {
                //TODO: Documentation.
                //Reading
                using var stream = Reader.ReadSpecFromGithub();

                //Parsing
                var specification = Parser.Parse(stream);

                // WIP
                var outputSpec = Processor.ProcessSpec(specification);

                Writer.Write(outputSpec);

                /*
                Writer.WriteProject();
                foreach (var api in outputSpec)
                {
                    foreach (var glvers in api.ver)
                    {
                        Writer.WriteGLAPI(glAPI);
                    }
                    foreach (var glexten in outputSpec)
                    {
                        Writer.WriteGLAPI(glAPI);
                    }
                    Writer.WriteEnums(api.Enums);
                }
                */

                //Overloading
                //new Overloader(specification).Overload();
                //Overloader.OverloadCommands(specification);

                //Writing
                //new Writer(specification).Write();

                st.Stop();

                Logger.Info($"{st.ElapsedMilliseconds}");
            }
        }

        //[DllImport("opengl32.dll", EntryPoint = "glCullFace")]
        //private static void PreloadCullFace()
        //{
        //    CullFace_fnptr = _bindingsContext.GetProcAddress("glCullFace");
        //}

        //public static void Preload()
        //{
        //    PreloadCullFace();
        //    ...
        //}
        //private static object _lock = new object();
        //private static IBindingContext _bindingsContext;
        //public static void LoadBindings(IBindingContext c)
        //{
        //    _bindingsContext = c;
        //}

        //[DllImport("opengl32.dll", EntryPoint = "glCullFace")]
        //public static extern void CullFace(uint mode);
    }
}
/*
 * TODO:
 * Work on some manual overloading system.
 */

/*TODO: Look into enum overloads for extensions
 * 1) Only use the ALL enum - Currently doing
 * 2) Create a struct with implicit conversions
 * 3) Create a ton of overloads
 * 4) Extra enum group per extension (downside: name collision)
 * */

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
 *  OpenToolkit.Graphics.OpenGL.V35.GL.Function
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

using System;
using System.Diagnostics;


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
                var parser = new Parser(stream);
                var commands = parser.ParseCommands();
                var enums = parser.ParseEnums();
                var versions = parser.ParseFeatures(commands, enums);
                var extensions = parser.ParseExtensions(commands, enums);

                //Overloading
                Overloader.OverloadCommands(commands);

                //Writing
                Writer.Write(versions, extensions);

                st.Stop();

                Logger.Info($"{st.ElapsedMilliseconds}");
            }
        }
    }
}

//TODO:
//Overloading
//Documentation
//Trimmer
//Buildscript
// - .gitignore
// - Big re-organisation of parser

/*
 * TODO:
 *  OpenToolkit.Graphics.OpenGL.V46.GL.Function
 *  OpenToolkit.Graphics.OpenGL.Extensions.EXT.Function
 *  OpenToolkit.Graphics.OpenGLES1.Extensions.NV.Function
 *  OpenToolkit.Graphics.OpenGLES2.V30.GL.Function
 *
 */

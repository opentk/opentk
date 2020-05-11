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

                //Writing
                Writer.Write(versions);

                st.Stop();

                Logger.Info($"{st.ElapsedMilliseconds}");
            }
        }
    }
}

//TODO:
//Load extensions
//Do overloads
//Output path/multiple projects

/*
 * 
 * EnumEntries[]
 * {
 *      Name
 *      Value
 *      Groups
 * }
 * Command[]
 * {
 *      Extern -
 *      Overloads[] -
 * }
 *
 * Version[]
 * {
 *      EnumGroup
 * }
 * 
 *
 */

/*
 * Graphics
 * /Gl10
 *  - Gl.Methods.cs
 *  - Vendor/GL.[Vendor].Methods.cs
 *  - Vendor/GL.[Vendor].Overloads.cs
 *  - Gl.Overloads.cs
 *  - Enums.cs
 * /Gl11
 *  - Methods.cs
 *  - Vendor/[Vendor].Methods.cs
 *  - Vendor/[Vendor].Overloads.cs
 *  - Overloads.cs
 *  - Enums.cs
 * /Gl31
 * /Gl32
 * /Gl46
 * /Es10
 * /Es11
 * /Es12
 * /Es21
 * /Es30
 * */

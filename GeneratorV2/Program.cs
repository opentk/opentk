using System;

namespace GeneratorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Logger.CreateLogger("log.txt"))
            {
                //TODO: Documentation.
                //Reading
                using var stream = Reader.ReadSpecFromGithub();

                //Parsing
                var parser = new Parser(stream);
                var commands = parser.ParseCommands();
                //Overloading

                //Writing
                Writer.Write(commands);
            }
        }
    }
}

/*
 * EnumGroups[]
 * {
 *      EnumEntries[]
 * }
 * 
 * EnumEntries[]
 * {
 *      Name
 *      Value
 * }
 * Command[]
 * {
 *      Extern -
 *      Overloads[] -
 * }
 *
 * Version[]
 * {
 *   EnumGroupVersion
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

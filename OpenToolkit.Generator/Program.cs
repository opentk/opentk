using System;

namespace OpenToolkit.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step1: Read specification from github.
            //Step2: Parse information to methods and class structs.
            //Step3: Generate overloads.
            //Step4: Write generated classes to .cs files.
            Logger.Initialize();

            var rawSpec = Reader.ReadSpecFromGithub();

            var rawClass = Parser.Parse(rawSpec);

            Logger.Dispose();
        }
    }
}

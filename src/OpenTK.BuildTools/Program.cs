using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using OpenTK.BuildTools.Convert;

namespace OpenTK.BuildTools
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OpenGL Build Tools");
            Console.WriteLine("(C) The Open Toolkit Project");
            Console.WriteLine();
            var profileConstuctor = new ProfileConstuctor();
            profileConstuctor.InputFiles = new List<string>() {args[0]};
            profileConstuctor.OutputFolder = Path.Combine(Environment.CurrentDirectory,"Specifications");
            profileConstuctor.Pretty = true;
            profileConstuctor.Prefix = "gl";
            profileConstuctor.WriteProfiles();
            if (args.Length == 0 || args[0].ToLower() == "bind")
            {
                BindMain(new ArraySegment<string>(args, 1, args.Length - 1));
            }
            else if (args[0].ToLower() == "convert")
            {
                ConvertMain(new ArraySegment<string>(args, 1, args.Length - 1));
            }
            else
            {
                Console.WriteLine("USAGE:");
                Console.WriteLine("BuildTools [tool] [options]");
                Console.WriteLine();
                Console.WriteLine("Available tools:");
                Console.WriteLine();
                Console.WriteLine("  Bind - Creates projects from JSON bindings (created by Convert)");
                Console.WriteLine();
                Console.WriteLine("  Convert - Creates bindings from Khronos XML files, and with optional overrides.");
                Console.WriteLine();
                Console.WriteLine("To see available options, use the following command:");
                Console.WriteLine();
                Console.WriteLine("  BuildTools [tool] --help");
            }
        }
    }
}
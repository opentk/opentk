using System;
using System.Collections.Generic;
using System.IO;

namespace Generator.Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OpenGL Registry Converter");
            Console.WriteLine("(C) The Open Toolkit Project");
            Console.WriteLine();
            var profileConstuctor = new ProfileConstructor();
            profileConstuctor.InputFiles = new List<string>() {args[0]};
            profileConstuctor.OutputFolder = Path.Combine(Environment.CurrentDirectory,"Specifications");
            profileConstuctor.Pretty = true;
            profileConstuctor.Prefix = "gl";
            profileConstuctor.WriteProfiles();
        }
    }
}

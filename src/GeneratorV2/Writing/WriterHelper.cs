using System.CodeDom.Compiler;

namespace GeneratorV2.Writing
{
    public static class WriterUtility
    {
        public static void WriteUsings(IndentedTextWriter writer)
        {
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine("using System;");
            writer.WriteLine("using OpenToolkit.Graphics.Types;");
            writer.WriteLine();
        }
    }
}
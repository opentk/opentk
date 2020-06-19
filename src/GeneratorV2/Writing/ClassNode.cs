using GeneratorV2.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GeneratorV2.Writing
{
    public class ClassNode : TypeContainerNode
    {
        private readonly string _name;

        public ClassNode(string name)
        {
            _name = name;
        }

        protected override void WriteDeclaration()
        {
            Writer.WriteLine("public unsafe static partial class " + _name);
        }
    }
}

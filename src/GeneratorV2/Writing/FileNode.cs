using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeneratorV2.Writing
{
    public class FileNode : Node
    {
        /*private IndentedTextWriter? _writer;
        public IndentedTextWriter Writer
        {
            get => _writer ?? throw new NullReferenceException();
            private set => _writer = value;
        }*/

        private readonly string _filepath;

        public FileNode(string filepath) : base(new List<Node>())
        {
            _filepath = filepath;
        }

        public override void Write()
        {
            using (var stream = new FileStream(_filepath, FileMode.Create))
            using (var streamWriter = new StreamWriter(stream))
            //using(Writer = new IndentedTextWriter(streamWriter))
            {
                WriteChildren();
            }
        }
    }
}

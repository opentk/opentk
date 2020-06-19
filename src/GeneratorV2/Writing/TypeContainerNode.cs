using GeneratorV2.Extensions;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace GeneratorV2.Writing
{
    public interface IWriterNode
    {
        IndentedTextWriter Writer {get;}
    }
    public abstract class TypeContainerNode : WriterNode
    {
        protected TypeContainerNode() : base(new List<Node>()) { }

        public override void Write()
        {
            WriteDeclaration();
            using (Writer.Scope())
            {
                WriteChildren();
            }
        }

        protected abstract void WriteDeclaration();
    }

    public abstract class WriterNode : Node, IWriterNode
    {
        private IndentedTextWriter? _writer = null;
        public IndentedTextWriter Writer
        {
            get
            {
                if (Parent == null)
                {
                    throw new NullReferenceException();
                }
                if (_writer == null)
                {
                    return _writer = ((IWriterNode)Parent).Writer;
                }
                return _writer;
            }
        }

        protected WriterNode(List<Node>? children = null) : base(children) { }
    }
}

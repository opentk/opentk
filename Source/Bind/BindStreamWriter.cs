using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Bind.Structures;

namespace Bind
{
    class BindStreamWriter : StreamWriter
    {
        public BindStreamWriter(string file)
            : base(file)
        {
        }

        private string indent = "";

        public void Indent()
        {
            indent = "    " + indent;
        }

        public void Unindent()
        {
            if (!String.IsNullOrEmpty(indent))
                indent = indent.Substring(4);
        }

        public override void Write(string value)
        {
            base.Write(indent + value);
        }

        public override void WriteLine(string value)
        {
            base.WriteLine(indent + value);
        }

        public void Write(Bind.Structures.Enum e)
        {
            StringBuilder sb = new StringBuilder(e.ToString());
            sb.Replace(System.Environment.NewLine, System.Environment.NewLine + indent);
            Write(sb);
        }

        public void Write(Bind.Structures.Function f)
        {
            StringBuilder sb = new StringBuilder(f.ToString());
            sb.Replace(System.Environment.NewLine, System.Environment.NewLine + indent);
            Write(sb);
        }
    }
}

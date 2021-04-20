using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorV2
{
    public class IndentedTextWriter : IDisposable
    {
        // PR
        public TextWriter Writer;
        public int CurrentIndentation = 0;
        public int IndentationWidth = 4;

        public IndentedTextWriter(string filePath)
        {
            Writer = new StreamWriter(File.OpenWrite(filePath));
        }

        public IndentedTextWriter(TextWriter writer)
        {
            Writer = writer;
        }

        public void WriteIndentation()
        {
            int indents = CurrentIndentation * IndentationWidth;
            for (int i = 0; i < indents; i++)
            {
                Writer.Write(' ');
            }
        }

        // FIXME
        public void Write(string str) => Writer.Write(str);

        public void WriteLine() => Writer.WriteLine();

        public void WriteLine(string str)
        {
            WriteIndentation();
            Writer.WriteLine(str);
        }

        public void Flush() => Writer.Flush();

        public Scope Indentation()
        {
            CurrentIndentation++;
            return new Scope(this);
        }

        public void Dispose()
        {
            Writer.Flush();
            Writer.Dispose();
            GC.SuppressFinalize(this);
        }

        public struct Scope : IDisposable
        {
            public readonly IndentedTextWriter Writer;

            public Scope(IndentedTextWriter writer)
            {
                Writer = writer;
            }

            public void Dispose()
            {
                Writer.CurrentIndentation--;
            }
        }
    }
}

#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//


#endregion

using System;
using System.IO;
using System.Text.RegularExpressions;
using Bind.Structures;
using Enum=Bind.Structures.Enum;

namespace Bind
{
    enum WriteOptions
    {
        Default = 0,
        NoIndent = 1
    }

    class BindStreamWriter : IDisposable
    {
        static readonly char[] SplitCharacters = new char[] { '\r', '\n' };
        readonly StreamWriter sw;
        public readonly string File;

        int indent_level = 0;

        public BindStreamWriter(string file)
        {
            File = file;
            sw = new StreamWriter(file);
        }

        public void Indent()
        {
            ++indent_level;
        }

        public void Unindent()
        {
            if (indent_level > 0)
                --indent_level;
        }

        public void Write(WriteOptions options, string value)
        {
            var lines = value.Split(SplitCharacters,
                StringSplitOptions.RemoveEmptyEntries);
            bool is_multiline = lines.Length > 1;
            if (is_multiline)
            {
                // Write all internal lines
                for (int i = 0; i < lines.Length - 1; i++)
                {
                    var line = lines[i];
                    WriteIndentations(options);
                    sw.Write(line);
                    sw.Write(System.Environment.NewLine);
                }
                // Write the last line without appending a newline
                WriteIndentations(options);
                sw.Write(lines[lines.Length - 1]);
            }
            else
            {
                WriteIndentations(options);
                sw.Write(value);
            }
        }

        public void Write(WriteOptions options, string format, params object[] args)
        {
            Write(options, String.Format(format, args));
        }

        public void Write(string value)
        {
            Write(WriteOptions.Default, value);
        }

        public void Write(string format, params object[] args)
        {
            Write(WriteOptions.Default, format, args);
        }

        public void WriteLine()
        {
            sw.WriteLine();
        }

        public void WriteLine(WriteOptions options, string value)
        {
            Write(options, value);
            WriteLine();
        }

        public void WriteLine(WriteOptions options, string format, params object[] args)
        {
            WriteLine(options, String.Format(format, args));
        }


        public void WriteLine(string value)
        {
            WriteLine(WriteOptions.Default, value);
        }

        public void WriteLine(string format, params object[] args)
        {
            WriteLine(WriteOptions.Default, format, args);
        }

        public void Flush()
        {
            sw.Flush();
        }

        public void Close()
        {
            sw.Close();
        }

        void WriteIndentations(WriteOptions options)
        {
            if (options != WriteOptions.NoIndent)
            {
                for (int i = indent_level; i > 0; i--)
                    sw.Write("    ");
            }
        }

        public void Dispose()
        {
            sw.Dispose();
        }
    }
}

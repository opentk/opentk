// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
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
        static readonly string[] SplitStrings = new string[] { System.Environment.NewLine };
        readonly StreamWriter sw;
        public readonly string File;

        bool newline = true;
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
            var lines = value.Split(SplitStrings, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; ++i)
            {
                if (lines[i].Length != 0)
                {
                    if (newline)
                    {
                        WriteIndentations(options);
                    }
                    newline = false;
                    sw.Write(lines[i]);
                }

                // if we're going to write another line add a line break string
                if (i + 1 < lines.Length)
                {
                    sw.Write(System.Environment.NewLine);
                    newline = true;
                }
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
            Write(System.Environment.NewLine);
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

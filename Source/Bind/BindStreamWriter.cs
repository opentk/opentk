#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Bind.Structures;
using System.Text.RegularExpressions;

namespace Bind
{
    class BindStreamWriter : StreamWriter
    {
        int indent_level = 0;
        Regex splitLines = new Regex(System.Environment.NewLine, RegexOptions.Compiled);

        public BindStreamWriter(string file)
            : base(file)
        {
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

        public override void Write(string value)
        {
            for (int i = indent_level; i > 0; i--)
                base.Write("    ");

            base.Write(value);
        }

        public override void WriteLine(string value)
        {
            for (int i = indent_level; i > 0; i--)
                base.Write("    ");

            base.WriteLine(value);
        }

        public void Write(Bind.Structures.Enum e)
        {
            foreach (string s in splitLines.Split(e.ToString()))
                WriteLine(s.TrimEnd('\r', '\n'));
        }

        public void Write(Bind.Structures.Function f)
        {
            foreach (string s in splitLines.Split(f.ToString()))
                WriteLine(s);
        }
    }
}

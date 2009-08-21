#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.IO;
using System.Text.RegularExpressions;
using Bind.Structures;
using Enum=Bind.Structures.Enum;

namespace Bind
{
    class BindStreamWriter : StreamWriter
    {
        int indent_level = 0;
        Regex splitLines = new Regex(Environment.NewLine, RegexOptions.Compiled);
        //Regex splitLines = new Regex("(\r\n|\n\r|\n|\r)", RegexOptions.Compiled);

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
            // Todo: it seems that spacing is not correct if this code
            // is enabled on Linux/Mono. However, it works as it should on Windows/.Net.
            // This could be related to line-ending differences, but I haven't been able to
            // find the cause yet.
            // This ugly workaround should work until the real cause is found.
            if (Environment.OSVersion.Platform == PlatformID.Win32Windows ||
                Environment.OSVersion.Platform == PlatformID.Win32NT ||
                Environment.OSVersion.Platform == PlatformID.Win32S ||
                Environment.OSVersion.Platform == PlatformID.WinCE)
            {
                for (int i = indent_level; i > 0; i--)
                    base.Write("    ");
            }
            
            base.WriteLine(value);
        }

        public void Write(Enum e)
        {
            foreach (string s in splitLines.Split(e.ToString()))
                WriteLine(s.TrimEnd('\r', '\n'));
        }

        public void Write(Function f)
        {
            foreach (string s in splitLines.Split(f.ToString()))
                WriteLine(s);
        }
    }
}

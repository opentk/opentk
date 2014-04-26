#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bind.GL2
{
    class GL4Generator : Generator
    {
        public GL4Generator(Settings settings, string dirname)
            : base(settings, dirname)
        {
            Settings.DefaultOutputPath = Path.Combine(
                Settings.DefaultOutputPath, "../OpenGL4");
            Settings.DefaultOutputNamespace = "OpenTK.Graphics.OpenGL4";
            Settings.DefaultImportsFile = "GL4Core.cs";
            Settings.DefaultDelegatesFile = "GL4Delegates.cs";
            Settings.DefaultEnumsFile = "GL4Enums.cs";
            Settings.DefaultWrappersFile = "GL4.cs";
            Settings.DefaultDocPath = Path.Combine(
                Settings.DefaultDocPath, "GL");

            Profile = "glcore";

            //Settings.DefaultCompatibility |=
            //    Settings.Legacy.UseDllImports | Settings.Legacy.UseWindowsCompatibleGL;
        }
    }
}

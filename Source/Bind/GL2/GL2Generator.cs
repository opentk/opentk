#region License
//
// GL2Generator.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using System.IO;

namespace Bind.GL2
{

    class GL2Generator : Generator
    {
        public GL2Generator(Settings settings, string dirname)
            : base(settings, dirname)
        {
            if (Settings.Compatibility == Settings.Legacy.Tao)
            {
                Settings.OutputNamespace = "Tao.OpenGl";
                Settings.OutputClass = "Gl";
            }
            else
            {
                // Defaults
            }

            Settings.DefaultOutputNamespace = "OpenTK.Graphics.OpenGL";
            Settings.DefaultImportsFile = "GLCore.cs";
            Settings.DefaultDelegatesFile = "GLDelegates.cs";
            Settings.DefaultEnumsFile = "GLEnums.cs";
            Settings.DefaultWrappersFile = "GL.cs";
            Settings.DefaultDocPath = Path.Combine(
                Settings.DefaultDocPath, "GL");

            //Settings.DefaultCompatibility |=
            //    Settings.Legacy.UseDllImports | Settings.Legacy.UseWindowsCompatibleGL;
        }
    }
}


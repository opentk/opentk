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
using System.Globalization;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Build.Tasks
{
    /// <summary>
    /// Deletes directory and all of its contents.
    /// Replaces RemoveDir task which exhibits different behavior
    /// on xbuild compared to msbuild: the first requires an empty
    /// directory, while the latter does not.
    /// </summary>
    public class DelTree : Task
    {
        string path;

        /// <summary>
        /// The filesystem path to delete.
        /// </summary>
        [Required]
        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public override bool Execute()
        {
            try
            {
                if (String.IsNullOrEmpty(Path) ||
                    System.IO.Directory.Exists(Path))
                {
                    return false;
                }
                else
                {
                    System.IO.Directory.Delete(Path, true);
                }
            }
            catch (Exception e)
            {
                Log.LogErrorFromException(e);
                return false;
            }
            return true;
        }
    }
}

#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
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
using System.Text;
using System.Diagnostics;

namespace OpenTK.Graphics.ES20
{
    // Used in debug-mode only, for automatic OpenGL error-checking.
    //
    // Works like this: an instance is created before each OpenGL function is called.
    // The constructor resets the OpenGL error state. Once the native function returns,
    // the error state is checked again, raising the relevant exceptions.
    //
    // A using-region is used to ensure Dispose() is called.
    //
    // Make sure that no error checking is added to the GetError function,
    // as that would cause infinite recursion!
    struct ErrorHelper : IDisposable
    {
        #region Fields

        static readonly object SyncRoot = new object();
        static readonly Dictionary<GraphicsContext, List<ErrorCode>> ContextErrors =
            new Dictionary<GraphicsContext, List<ErrorCode>>();
        readonly GraphicsContext Context;

        #endregion

        #region Constructors

        public ErrorHelper(IGraphicsContext context)
        {
            if (context == null)
                throw new GraphicsContextMissingException();

            Context = (GraphicsContext)context;
            lock (SyncRoot)
            {
                if (!ContextErrors.ContainsKey(Context))
                    ContextErrors.Add(Context, new List<ErrorCode>());
            }
            ResetErrors();
        }

        #endregion

        #region Public Members

        // Retrieve all OpenGL errors to clear the error list.
        // See http://www.opengl.org/documentation/specs/man_pages/hardcopy/GL/html/gl/geterror.html
        [Conditional("DEBUG")]
        internal void ResetErrors()
        {
            if (Context.ErrorChecking)
            {
                while ((ErrorCode)GL.GetError() != ErrorCode.NoError)
                { }
            }
        }

        // Retrieve all OpenGL errors and throw an exception if anything other than NoError is returned.
        [Conditional("DEBUG")]
        internal void CheckErrors()
        {
            if (Context.ErrorChecking)
            {
                List<ErrorCode> error_list = ContextErrors[Context];
                error_list.Clear();
                ErrorCode error;
                do
                {
                    error = (ErrorCode)GL.GetError();
                    error_list.Add(error);
                } while (error != ErrorCode.NoError);

                if (error_list.Count != 1)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (ErrorCode e in error_list)
                    {
                        if (e != ErrorCode.NoError)
                        {
                            sb.Append(e.ToString());
                            sb.Append(", ");
                        }
                        else
                            break;
                    }
                    sb.Remove(sb.Length - 2, 2); // Remove the last comma

                    throw new GraphicsErrorException(sb.ToString());
                }
            }
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            CheckErrors();
        }

        #endregion
    }
}

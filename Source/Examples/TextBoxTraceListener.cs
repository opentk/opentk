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
using System.Windows.Forms;
using System.Threading;

namespace Examples
{
    public class TextBoxTraceListener : TraceListener
    {
        TextBox _target;
        StringSendDelegate _invokeWrite;

        public TextBoxTraceListener(TextBox target)
        {
            _target = target;
            _invokeWrite = new StringSendDelegate(SendString);
        }

        public override void Write(string message)
        {
            if (_target.Created)
                _target.BeginInvoke(_invokeWrite, new object[] { message });
        }

        public override void WriteLine(string message)
        {
            if (_target.Created)
                _target.BeginInvoke(_invokeWrite, new object[] { message + Environment.NewLine });
        }

        private delegate void StringSendDelegate(string message);
        private void SendString(string message)
        {
            if (_target.Created)
            {
                // No need to lock text box as this function will only 
                // ever be executed from the UI thread
                _target.Text += message;
            }
        }
    }
}

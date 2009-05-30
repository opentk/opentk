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

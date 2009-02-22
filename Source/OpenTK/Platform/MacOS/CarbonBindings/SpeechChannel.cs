using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Platform.MacOS.Carbon
{

    public class SpeechChannel
    {

        private IntPtr _id;

        protected const string appServicesPath = "/System/Library/Frameworks/ApplicationServices.framework/Versions/Current/ApplicationServices";

        [DllImport(appServicesPath)]
        private static extern short NewSpeechChannel(IntPtr voice, ref IntPtr result);


        [DllImport(appServicesPath)]
        private static extern short SpeakText(IntPtr channel, String text, long length);

        public SpeechChannel()
        {
            short rc = NewSpeechChannel((IntPtr)null, ref _id);
            Debug.WriteLine(rc);
        }

        public bool Speak(String text)
        {
            short rc = SpeakText(_id, text, (long)text.Length);
            return (rc == 0);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.X11
{
    public struct XErrorEvent
    {
        public int type;
        public XDisplayPtr display;       /* Display the event was read from */
        public XID resourceid;         /* resource id */
        public ulong serial;       /* serial number of failed request */
        public XError error_code;   /* error code of failed request */
        public XRequestCode request_code; /* Major op-code of failed request */
        public byte minor_code;   /* Minor op-code of failed request */
    }
}

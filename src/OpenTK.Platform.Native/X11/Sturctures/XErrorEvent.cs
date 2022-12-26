using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.X11
{
    public struct XErrorEvent
    {
        public int type;
        public XDisplayPtr display;       /* Display the event was read from */
        public ulong serial;       /* serial number of failed request */
        public byte error_code;   /* error code of failed request */
        public byte request_code; /* Major op-code of failed request */
        public byte minor_code;   /* Minor op-code of failed request */
        public XID resourceid;         /* resource id */
    }
}

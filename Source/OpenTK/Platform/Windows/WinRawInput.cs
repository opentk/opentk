using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Windows
{
    static class WinRawInput
    {
        private static API.RawInput data = new API.RawInput();
        internal static API.RawInput ProcessEvent(ref System.Windows.Forms.Message msg)
        {
            if (msg.Msg == API.Constants.WM_INPUT)
            {
                uint size = 0;
                // Get the size of the input data
                API.GetRawInputData(
                    msg.LParam,
                    API.GetRawInputDataEnum.INPUT,
                    IntPtr.Zero,
                    ref size,
                    API.RawInputHeaderSize
                );

                if (data == null || API.RawInputSize < size)
                {
                    throw new Exception("WTF?!");
                }

                if (size ==
                    API.GetRawInputData(
                        msg.LParam,
                        API.GetRawInputDataEnum.INPUT,
                        data,
                        ref size,
                        API.RawInputHeaderSize))
                {
                    return data;
                }
                else
                {
                    throw new Exception(
                        "GetRawInputData returned invalid data. Please file a bug in http://opentk.sourceforge.net"
                    );
                }
            }
            throw new Exception("Never reach this!");
        }
    }
}

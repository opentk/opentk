using System.Runtime.InteropServices;

using HWND = System.IntPtr;
using LPARAM = System.IntPtr;
using WPARAM = System.IntPtr;

namespace OpenTK.NT.Native
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct MSG
    {
        internal HWND HWnd;
        internal WindowMessage Message;
        internal WPARAM WParam;
        internal LPARAM LParam;
        internal uint Time;

        internal POINT Point;
        //internal object RefObject;

        public override string ToString()
            => $"msg=0x{(int)Message:x} ({Message.ToString()}) hwnd=0x{HWnd.ToInt32():x} wparam=0x{WParam.ToInt32():x} lparam=0x{LParam.ToInt32():x} pt=0x{Point:x}";
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Core.Platform;

namespace OpenTK.Platform.Native.Windows
{
    internal class ClipboardComponent : IClipboardComponent
    {
        public string Name => "Win32 Clipboard component";

        public PalComponents Provides => PalComponents.Clipboard;

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Clipboard)
            {
                throw new PalException(this, "ClipboardComponent can only initialize the Clipboard component.");
            }
        }

        public void SetClipboardText(string text)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);

            IntPtr hmem = Win32.GlobalAlloc(0, (ulong)data.Length);
            if (hmem == IntPtr.Zero)
            {
                throw new Win32Exception();
            }

            IntPtr memory = Win32.GlobalLock(hmem);
            if (memory == IntPtr.Zero)
            {
                throw new Win32Exception();
            }

            Marshal.Copy(data, 0, memory, data.Length);

            bool stillLocked = Win32.GlobalUnlock(hmem);
            if (stillLocked == false)
            {
                // If the function returns NO_ERROR then we 
                int errorCode = Marshal.GetLastWin32Error();
                if (errorCode != 0)
                {
                    throw new Win32Exception(errorCode);
                }
            }

            throw new NotImplementedException();
        }

        public string GetClipboardText()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform.Implementations.Windows
{
    internal class Win32Exception : PlatformException
    {
        public int LastError { get; private set; }

        public Win32Exception(string message, int lastError)
            : base(message + $"(LastError: 0x{lastError:X})")
        {
            LastError = lastError;
        }
    }
}

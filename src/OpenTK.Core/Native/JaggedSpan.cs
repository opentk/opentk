using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenToolkit.Core.Native
{
    public unsafe readonly struct JaggedSpan<T> : IDisposable
        where T : unmanaged
    {
        private readonly T** _refer;
        private readonly IntPtr _pointer;
        private readonly int _length;

        public JaggedSpan(T[][] data)
        {
            _pointer = Marshal.AllocCoTaskMem(data.Length * sizeof(T*));
            _refer = (T**)_pointer;
            _length = data.Length;
        }

        public int Length => _length;

        public void Dispose()
        {
            Marshal.FreeCoTaskMem(_pointer);
        }

        public static implicit operator T**(JaggedSpan<T> jaggedSpan)
        {
            return jaggedSpan._refer;
        }

        public static implicit operator JaggedSpan<T>(T[][] jaggedArray)
        {
            return new JaggedSpan<T>(jaggedArray);
        }

        public static explicit operator IntPtr(JaggedSpan<T> jaggedSpan)
        {
            return jaggedSpan._pointer;
        }
    }
}

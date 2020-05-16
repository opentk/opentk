using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.Types
{
    public unsafe delegate void GLDEBUGPROC(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDEBUGPROCARB(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDEBUGPROCKHR(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDEBUGPROCAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDEBUGPROCNV();
    public struct GLsync{};
    public struct CLContext{};
    public struct CLEvent{};
    public struct GLhandleARB
    {
        private readonly uint _value1;
        private readonly IntPtr _value2;
        public GLhandleARB(uint val)
        {
            _value2 = IntPtr.Zero;
            _value1 = val;
        }
        public GLhandleARB(IntPtr val)
        {
            _value1 = 0;
            _value2 = val;
        }
        public static implicit operator GLhandleARB(uint val) => new GLhandleARB(val);
        public static implicit operator GLhandleARB(IntPtr val) => new GLhandleARB(val);
        public static implicit operator uint(GLhandleARB val) => val._value1;
        public static implicit operator IntPtr(GLhandleARB val) => val._value2;
    }
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics
{
    namespace OpenGL
    {
        public delegate void GLDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, IntPtr message, IntPtr userParam);
        public unsafe delegate void GLDebugProcARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcNV();
    }

    namespace OpenGLES1
    {
        public unsafe delegate void GLDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcNV();
    }

    namespace OpenGLES3
    {
        public unsafe delegate void GLDebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
        public unsafe delegate void GLDebugProcNV();
    }

    public struct CLContext {}
    public struct CLEvent {}

    public struct GLSync {}
    public unsafe struct GLSyncObject
    {
        internal GLSync* ObjPtr;
        internal GLSyncObject(GLSync* syncObject)
        {
            ObjPtr = syncObject;
        }

        public static implicit operator GLSync*(GLSyncObject obj) => obj.ObjPtr;
        public static implicit operator GLSyncObject(GLSync* obj) => new GLSyncObject(obj);
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GLHandleARB
    {
        [FieldOffset(0)] private readonly uint _value1;
        [FieldOffset(0)] private readonly IntPtr _value2;

        public GLHandleARB(uint val)
        {
            _value2 = IntPtr.Zero;
            _value1 = val;
        }

        public GLHandleARB(IntPtr val)
        {
            _value1 = 0;
            _value2 = val;
        }

        public static implicit operator GLHandleARB(uint val) => new GLHandleARB(val);
        public static implicit operator GLHandleARB(IntPtr val) => new GLHandleARB(val);
        public static implicit operator uint(GLHandleARB val) => val._value1;
        public static implicit operator IntPtr(GLHandleARB val) => val._value2;
    }

    public readonly struct Program1
    {
        private uint _handle { get; init; }

        public static readonly Program1 Zero = new Program1() {_handle = 0};
    }
    public readonly struct ProgramPipeline
    {
        private uint _handle { get; init; }

        public static readonly ProgramPipeline Zero = new ProgramPipeline() {_handle = 0};
    }
    public readonly struct Texture
    {
        private uint _handle { get; init; }

        public static readonly Texture Zero = new Texture() {_handle = 0};
    }
    public readonly struct Buffer1
    {
        private uint _handle { get; init; }

        public static readonly Buffer1 Zero = new Buffer1() {_handle = 0};
    }
    public struct Shader : IEquatable<Shader>
    {
        public static readonly Shader Null = new Shader(0);

        public int Handle;

        public Shader(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object obj)
        {
            return obj is Shader device && Equals(device);
        }

        public bool Equals([AllowNull] Shader other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(Shader left, Shader right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Shader left, Shader right)
        {
            return !(left == right);
        }

        public static implicit operator int(Shader device) => device.Handle;
    }
    public readonly struct Query
    {
        private uint _handle { get; init; }

        public static readonly Query Zero = new Query() {_handle = 0};
    }
    public readonly struct Framebuffer
    {
        private uint _handle { get; init; }

        public static readonly Framebuffer Zero = new Framebuffer() {_handle = 0};
    }
    public readonly struct Renderbuffer
    {
        private uint _handle { get; init; }

        public static readonly Renderbuffer Zero = new Renderbuffer() {_handle = 0};
    }
    public readonly struct Sampler
    {
        private uint _handle { get; init; }

        public static readonly Sampler Zero = new Sampler() {_handle = 0};
    }
    public readonly struct TransformFeedback
    {
        private uint _handle { get; init; }

        public static readonly TransformFeedback Zero = new TransformFeedback() {_handle = 0};
    }
    public readonly struct VertexArray
    {
        private uint _handle { get; init; }

        public static readonly VertexArray Zero = new VertexArray() {_handle = 0};
    }
    public readonly struct Sync
    {
        private uint _handle { get; init; }

        public static readonly Sync Zero = new Sync() {_handle = 0};
    }
    public readonly struct DisplayList
    {
        private uint _handle { get; init; }

        public static readonly DisplayList Zero = new DisplayList() {_handle = 0};
    }
}

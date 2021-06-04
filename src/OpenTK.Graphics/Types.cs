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

    public struct CLContext
    {
        public IntPtr Value;

        public CLContext(IntPtr value)
        {
            Value = value;
        }

        public static explicit operator CLContext(IntPtr val) => new CLContext(val);
    }

    public struct CLEvent
    {
        public IntPtr Value;

        public CLEvent(IntPtr value)
        {
            Value = value;
        }

        public static explicit operator CLEvent(IntPtr val) => new CLEvent(val);
    }
        public static implicit operator GLSync*(GLSyncObject obj) => obj.ObjPtr;
        public static implicit operator GLSyncObject(GLSync* obj) => new GLSyncObject(obj);
    }

    public struct GLSync
    {
        public IntPtr Value;

        public GLSync(IntPtr value)
        {
            Value = value;
        }

        public static explicit operator GLSync(IntPtr val) => new GLSync(val);
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct GLHandleARB
    {
        [FieldOffset(0)] private readonly uint _value1;
        [FieldOffset(0)] private readonly IntPtr _value2;
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
        public GLHandleARB(IntPtr val)
        {
            _value1 = 0;
            _value2 = val;
        }

        public static explicit operator GLHandleARB(uint val) => new GLHandleARB(val);
        public static explicit operator GLHandleARB(IntPtr val) => new GLHandleARB(val);
        public static explicit operator uint(GLHandleARB val) => val._value1;
        public static explicit operator IntPtr(GLHandleARB val) => val._value2;
    }

    public struct Program1
    {
        public static readonly Shader Zero = new Shader(0);

        public int Handle;

        public Program1(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is Program1 device && Equals(device);
        }

        public bool Equals([AllowNull] Program1 other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(Program1 left, Program1 right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Program1 left, Program1 right)
        {
            return !(left == right);
        }

        public static explicit operator Program1(int Program1) => new Program1(Program1);
        public static explicit operator int(Program1 Program1) => Program1.Handle;
    }

    public struct ProgramPipeline
    {
        public static readonly Shader Zero = new Shader(0);

        public int Handle;

        public ProgramPipeline(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is ProgramPipeline device && Equals(device);
        }

        public bool Equals([AllowNull] ProgramPipeline other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(ProgramPipeline left, ProgramPipeline right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ProgramPipeline left, ProgramPipeline right)
        {
            return !(left == right);
        }

        public static explicit operator ProgramPipeline(int ProgramPipeline) => new ProgramPipeline(ProgramPipeline);
        public static explicit operator int(ProgramPipeline ProgramPipeline) => ProgramPipeline.Handle;
    }

    public struct Texture
    {
        public static readonly Shader Zero = new Shader(0);

        public int Handle;

        public Texture(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is Texture device && Equals(device);
        }

        public bool Equals([AllowNull] Texture other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(Texture left, Texture right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Texture left, Texture right)
        {
            return !(left == right);
        }

        public static explicit operator Texture(int Texture) => new Texture(Texture);
        public static explicit operator int(Texture Texture) => Texture.Handle;
    }

    public struct Buffer1
    {
        public static readonly Shader Zero = new Shader(0);

        public int Handle;

        public Buffer1(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is Buffer1 device && Equals(device);
        }

        public bool Equals([AllowNull] Buffer1 other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(Buffer1 left, Buffer1 right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Buffer1 left, Buffer1 right)
        {
            return !(left == right);
        }

        public static explicit operator Buffer1(int Buffer1) => new Buffer1(Buffer1);
        public static explicit operator int(Buffer1 Buffer1) => Buffer1.Handle;
    }

    public struct Shader : IEquatable<Shader>
    {
        public static readonly Shader Zero = new Shader(0);

        public int Handle;

        public Shader(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
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

        public static explicit operator Shader(int shader) => new Shader(shader);
        public static explicit operator int(Shader shader) => shader.Handle;
    }

    public struct Query
    {
        public static readonly Shader Zero = new Shader(0);

        public int Handle;

        public Query(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is Query device && Equals(device);
        }

        public bool Equals([AllowNull] Query other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(Query left, Query right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Query left, Query right)
        {
            return !(left == right);
        }

        public static explicit operator Query(int Query) => new Query(Query);
        public static explicit operator int(Query Query) => Query.Handle;
    }

    public struct Framebuffer
    {
        public static readonly Shader Zero = new Shader(0);

        public int Handle;

        public Framebuffer(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is Framebuffer device && Equals(device);
        }

        public bool Equals([AllowNull] Framebuffer other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(Framebuffer left, Framebuffer right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Framebuffer left, Framebuffer right)
        {
            return !(left == right);
        }

        public static explicit operator Framebuffer(int Framebuffer) => new Framebuffer(Framebuffer);
        public static explicit operator int(Framebuffer Framebuffer) => Framebuffer.Handle;
    }

    public struct Renderbuffer
    {
        public static readonly Shader Zero = new Shader(0);

        public int Handle;

        public Renderbuffer(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is Renderbuffer device && Equals(device);
        }

        public bool Equals([AllowNull] Renderbuffer other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(Renderbuffer left, Renderbuffer right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Renderbuffer left, Renderbuffer right)
        {
            return !(left == right);
        }

        public static explicit operator Renderbuffer(int Renderbuffer) => new Renderbuffer(Renderbuffer);
        public static explicit operator int(Renderbuffer Renderbuffer) => Renderbuffer.Handle;
    }

    public struct Sampler
    {
        public static readonly Shader Zero = new Shader(0);

        public int Handle;

        public Sampler(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is Sampler device && Equals(device);
        }

        public bool Equals([AllowNull] Sampler other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(Sampler left, Sampler right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Sampler left, Sampler right)
        {
            return !(left == right);
        }

        public static explicit operator Sampler(int Sampler) => new Sampler(Sampler);
        public static explicit operator int(Sampler Sampler) => Sampler.Handle;
    }

    public struct TransformFeedback
    {
        public static readonly Shader Zero = new Shader(0);

        public int Handle;

        public TransformFeedback(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is TransformFeedback device && Equals(device);
        }

        public bool Equals([AllowNull] TransformFeedback other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(TransformFeedback left, TransformFeedback right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(TransformFeedback left, TransformFeedback right)
        {
            return !(left == right);
        }

        public static explicit operator TransformFeedback(int TransformFeedback) => new TransformFeedback(TransformFeedback);
        public static explicit operator int(TransformFeedback TransformFeedback) => TransformFeedback.Handle;
    }

    public struct VertexArray
    {
        public static readonly Shader Zero = new Shader(0);

        public int Handle;

        public VertexArray(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is VertexArray device && Equals(device);
        }

        public bool Equals([AllowNull] VertexArray other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(VertexArray left, VertexArray right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(VertexArray left, VertexArray right)
        {
            return !(left == right);
        }

        public static explicit operator VertexArray(int VertexArray) => new VertexArray(VertexArray);
        public static explicit operator int(VertexArray VertexArray) => VertexArray.Handle;
    }

    public struct DisplayList
    {
        public static readonly Shader Zero = new Shader(0);

        public int Handle;

        public DisplayList(int handle)
        {
            Handle = handle;
        }

        public override bool Equals(object? obj)
        {
            return obj is DisplayList device && Equals(device);
        }

        public bool Equals([AllowNull] DisplayList other)
        {
            return Handle.Equals(other.Handle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Handle);
        }

        public static bool operator ==(DisplayList left, DisplayList right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(DisplayList left, DisplayList right)
        {
            return !(left == right);
        }

        public static explicit operator DisplayList(int DisplayList) => new DisplayList(DisplayList);
        public static explicit operator int(DisplayList DisplayList) => DisplayList.Handle;
    }
}
        public static implicit operator GLHandleARB(uint val) => new GLHandleARB(val);
        public static implicit operator GLHandleARB(IntPtr val) => new GLHandleARB(val);
        public static implicit operator uint(GLHandleARB val) => val._value1;
        public static implicit operator IntPtr(GLHandleARB val) => val._value2;
    }
}

<<<<<<< HEAD
=======

// This file is auto generated, do not edit.
>>>>>>> 72bd3468d87d9e134d1c5671163e881add3e2414
using System;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics
{
<<<<<<< HEAD
    public unsafe delegate void GLDebugProc(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcARB(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcKHR(uint source, uint type, uint id, uint severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcAMD(uint id, uint category, uint severity, int length, char* message, void* userParam);
    public unsafe delegate void GLDebugProcNV();

    public struct CLContext{}
    public struct CLEvent{}

    public struct GLSync{}
=======
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
>>>>>>> 72bd3468d87d9e134d1c5671163e881add3e2414
    public unsafe struct GLSyncObject
    {
        internal GLSync* ObjPtr;
        internal GLSyncObject(GLSync* syncObject)
<<<<<<< HEAD

=======
>>>>>>> 72bd3468d87d9e134d1c5671163e881add3e2414
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
}

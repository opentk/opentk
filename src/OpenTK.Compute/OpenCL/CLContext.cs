using System;

namespace OpenTK.Compute.OpenCL
{
	public readonly struct CLContext : IEquatable<CLContext>
	{
		public readonly IntPtr Handle;

		public CLContext(IntPtr handle)
		{
			Handle = handle;
		}

		public bool Equals(CLContext other)
		{
			return Handle.Equals(other.Handle);
		}

		public override bool Equals(object obj)
		{
			return obj is CLContext other && Equals(other);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Handle);
		}

		public static bool operator ==(CLContext left, CLContext right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CLContext left, CLContext right)
		{
			return !(left == right);
		}

		public static implicit operator IntPtr(CLContext context) => context.Handle;

        public enum Property : int
        {
            ContextPlatform = 0x1084, //cl_platform_id
            ContextInteropUserSync = 0x1085,
            GlContextKHR = 0x2008,
            EglDisplayKHR = 0x2009,
            GlxDisplayKHR = 0x200A,
            WglHDCKHR = 0x200B,
            CglShareGroupKHR = 0x200C,
            ContextD3D10DeviceKHR = 0x4014,
            ContextD3D11DeviceKHR = 0x401D,
            ContextAdapterD3D9KHR = 0x2025,
            ContextAdapterD3D9ExKHR = 0x2026,
            ContextAdapterDXVAKHR = 0x2027,
            ContextMemoryInitializeKHR = 0x2030,
            ContextTerminateKHR = -1121,
        }

        public enum Info : uint
        {
            ReferenceCount = 0x1080,
            Devices = 0x1081,
            Properties = 0x1082,
            NumberOfDevices = 0x1083
        }
    }
}

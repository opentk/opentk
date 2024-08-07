namespace OpenTK.Graphics.Vulkan
{
    public unsafe struct SECURITY_ATTRIBUTES
    {
        public uint nLength;
        public void* lpSecurityDescriptor;
        public int bInheritHandle;
    }
}

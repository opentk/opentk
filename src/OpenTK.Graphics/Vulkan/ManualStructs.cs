namespace OpenTK.Graphics.Vulkan
{
    /// <summary>
    /// The SECURITY_ATTRIBUTES structure contains the security descriptor for an object and specifies whether the handle retrieved by specifying this structure is inheritable.
    /// This structure provides security settings for objects created by various functions, such as CreateFile, CreatePipe, CreateProcess, RegCreateKeyEx, or RegSaveKeyEx.
    /// </summary>
    public unsafe struct SECURITY_ATTRIBUTES
    {
        /// <summary>
        /// The size, in bytes, of this structure. Set this value to the size of the SECURITY_ATTRIBUTES structure.
        /// </summary>
        public uint nLength;
        /// <summary>
        /// A pointer to a SECURITY_DESCRIPTOR structure that controls access to the object.
        /// If the value of this member is NULL, the object is assigned the default security descriptor associated with the access token of the calling process.
        /// This is not the same as granting access to everyone by assigning a NULL discretionary access control list (DACL).
        /// By default, the default DACL in the access token of a process allows access only to the user represented by the access token.
        /// 
        /// For information about creating a security descriptor, see Creating a Security Descriptor.
        /// </summary>
        public void* lpSecurityDescriptor;
        /// <summary>
        /// A Boolean value that specifies whether the returned handle is inherited when a new process is created. If this member is TRUE, the new process inherits the handle.
        /// </summary>
        public int bInheritHandle;
    }
}

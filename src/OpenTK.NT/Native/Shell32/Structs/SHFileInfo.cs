using System;
using System.Runtime.InteropServices;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Contains information about a file object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct SHFileInfo
    {
        /// <summary>
        /// A handle to the icon that represents the file. You are responsible for destroying this handle with
        /// <see cref="User32.Icon.DestroyIcon(IntPtr)"/> when you no longer need it.
        /// </summary>
        public IntPtr Icon;

        /// <summary>
        /// The index of the icon image within the system image list.
        /// </summary>
        public int IconIndex;

        /// <summary>
        /// An array of values that indicates the attributes of the file object. For information about these values,
        /// see the IShellFolder::GetAttributesOf method.
        /// </summary>
        public uint Attributes;

        /// <summary>
        /// A string that contains the name of the file as it appears in the Windows Shell, or the path and file
        /// name of the file that contains the icon representing the file.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string DisplayName;

        /// <summary>
        /// A string that describes the type of file.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string TypeName;

        /// <summary>
        /// The size of this structure in bytes.
        /// </summary>
        public static readonly uint SizeInBytes = (uint)Marshal.SizeOf<SHFileInfo>();
    }
}

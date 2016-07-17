using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Platform.X11.Bindings
{
    // Fully implemented but not currently used by OpenTK
    // See System.IO.FileSystemWatcher for a cross-platform alternative
#if false
    class INotify
    {
        const string lib = "";

        /// <summary>
        /// Create and initialize inotify instance
        /// </summary>
        /// <returns></returns>
        [DllImport(lib, EntryPoint = "inotify_init", ExactSpelling = true)]
        public static extern int Init();

        /// <summary>
        /// Create and initialize inotify instance with specified flags
        /// </summary>
        /// <param name="flags">See <see cref="INotifyInitFlags"/></param>
        /// <returns>A <c>System.Int32</c> handle to a inotify instance</returns>
        [DllImport(lib, EntryPoint = "inotify_init1", ExactSpelling = true)]
        public static extern int Init(INotifyFlags flags);

        /// <summary>
        /// Add watch of object pathname to inotify instance fd. Notify about
        /// events specified by mask
        /// </summary>
        [DllImport(lib, EntryPoint = "inotify_add_watch", ExactSpelling = true)]
        public static extern int AddWatch(int fd, string pathname, INotifyFlags mask);

        /// <summary>
        /// Remove the watch specified by wd from the inotify instance fd
        /// </summary>
        [DllImport(lib, EntryPoint = "inotify_rm_watch", ExactSpelling = true)]
        public static extern int RemoveWatch(int fd, int wd);
    }

    /// <summary>
    /// Describes an INotify event
    /// </summary>
    struct INotifyEvent
    {
        /// <summary>
        /// Watch descriptor for wd parameter of INotify methods
        /// </summary>
        public int WatchDescriptor;

        /// <summary>
        /// Watch mask for mask parameter of INotify methods
        /// </summary>
        public INotifyFlags WatchMask;

        /// <summary>
        /// Cookie to synchronize two events
        /// </summary>
        public uint Cookie;

        /// <summary>
        /// Length (including NULs) of name
        /// </summary>
        public uint Length;

        /// <summary>
        /// 
        /// </summary>
        public IntPtr Name;
    }

    /// <summary>
    /// Flags for the parameter of <see cref="INotify.Init(INotifyFlags)"/>
    /// </summary>
    [Flags]
    enum INotifyInitFlags
    {
        CloExec = 02000000,
        NonBlock = 04000
    }

    /// \internal
    /// <summary>
    /// Supported events suitable for MASK parameter of AddWatch.
    /// </summary>
    [Flags]
    enum INotifyFlags
    {
        /// <summary>
        /// File was accessed
        /// </summary>
        Access = 0x00000001,

        /// <summary>
        /// File was modified
        /// </summary>
        Modify = 0x00000002,

        /// <summary>
        /// Metadata changed
        /// </summary>
        Attrib = 0x00000004,

        /// <summary>
        /// Writable file was closed
        /// </summary>
        CloseWrite = 0x00000008,

        /// <summary>
        /// Unwritable file closed
        /// </summary>
        CloseNoWrite = 0x00000010,

        /// <summary>
        /// File closed
        /// </summary>
        Close = CloseWrite | CloseNoWrite,

        /// <summary>
        /// File was opened
        /// </summary>
        Open = 0x00000020,

        /// <summary>
        /// File was moved from X
        /// </summary>
        MovedFrom = 0x00000040,

        /// <summary>
        /// File was moved to Y
        /// </summary>
        MovedTo = 0x00000080,

        /// <summary>
        /// File was moved
        /// </summary>
        Move = MovedFrom | MovedTo,

        /// <summary>
        /// Subfile was created
        /// </summary>
        Create = 0x00000100,

        /// <summary>
        /// Subfile was deleted
        /// </summary>
        Delete = 0x00000200,

        /// <summary>
        /// Self was deleted
        /// </summary>
        DeleteSelf = 0x00000400,

        /// <summary>
        /// Self was moved
        /// </summary>
        MoveSelf = 0x00000800,

        /// <summary>
        /// Backing fs was unmounted
        /// </summary>
        Unmount = 0x00002000,

        /// <summary>
        /// Event queue overflowed
        /// </summary>
        QueueOverflow = 0x00004000,

        /// <summary>
        /// File was ignored
        /// </summary>
        Ignored = 0x00008000,

        /// <summary>
        /// Only watch the path if it is a directory
        /// </summary>
        OnlyDirectory = 0x01000000,

        /// <summary>
        /// Do not follow symlinks
        /// </summary>
        DontFollow = 0x02000000,

        /// <summary>
        /// Add to the mask of an already existing watch
        /// </summary>
        MaskAdd = 0x20000000,

        /// <summary>
        /// Event occurred against dir
        /// </summary>
        IsDirectory = 0x40000000,

        /// <summary>
        /// Only send event once
        /// </summary>
        Oneshot = 0x80000000,

        /// <summary>
        /// All events which a program can wait on
        /// </summary>
        AllEvents =
            Access | Modify | Attrib | Close | Open | Move |
            Create | Delete | DeleteSelf | MoveSelf
    }
#endif
}

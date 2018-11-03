using System;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Metadata values stored by the file system on disk and are used by the system and are available to developers
    /// via various file I/O APIs.
    /// </summary>
    [Flags]
    public enum FileAttributeFlags : uint
    {
        /// <summary>
        /// A file that is read-only. Applications can read the file, but cannot write to it or delete it.
        /// This attribute is not honored on directories.
        /// </summary>
        ReadOnly = 0x00000001,

        /// <summary>
        /// The file or directory is hidden. It is not included in an ordinary directory listing.
        /// </summary>
        Hidden = 0x00000002,

        /// <summary>
        /// A file or directory that the operating system uses a part of, or uses exclusively.
        /// </summary>
        System = 0x00000004,

        /// <summary>
        /// The handle that identifies a directory.
        /// </summary>
        Directory = 0x00000010,

        /// <summary>
        /// A file or directory that is an archive file or directory.
        /// Applications typically use this attribute to mark files for backup or removal.
        /// </summary>
        Archive = 0x00000020,

        /// <summary>
        /// This value is reserved for system use.
        /// </summary>
        Device = 0x00000040,

        /// <summary>
        /// A file that does not have other attributes set. This attribute is valid only when used alone.
        /// </summary>
        Normal = 0x00000080,

        /// <summary>
        /// A file that is being used for temporary storage. File systems avoid writing data back to mass storage
        /// if sufficient cache memory is available, because typically, an application deletes a temporary file after
        /// the handle is closed. In that scenario, the system can entirely avoid writing the data. Otherwise,
        /// the data is written after the handle is closed.
        /// </summary>
        Temporary = 0x00000100,

        /// <summary>
        /// A file that is a sparse file.
        /// </summary>
        SparseFile = 0x00000200,

        /// <summary>
        /// A file or directory that has an associated reparse point, or a file that is a symbolic link.
        /// </summary>
        ReparsePoint = 0x00000400,

        /// <summary>
        /// A file or directory that is compressed. For a file, all of the data in the file is compressed. For a
        /// directory, compression is the default for newly created files and subdirectories.
        /// </summary>
        Compressed = 0x00000800,

        /// <summary>
        /// The data of a file is not available immediately. This attribute indicates that the file data is physically
        /// moved to offline storage. This attribute is used by Remote Storage, which is the hierarchical
        /// storage management software. Applications should not arbitrarily change this attribute.
        /// </summary>
        Offline = 0x00001000,

        /// <summary>
        /// The file or directory is not to be indexed by the content indexing service.
        /// </summary>
        NotContentIndexed = 0x00002000,

        /// <summary>
        /// A file or directory that is encrypted. For a file, all data streams in the file are encrypted.
        /// For a directory, encryption is the default for newly created files and subdirectories.
        /// </summary>
        Encrypted = 0x00004000,

        /// <summary>
        /// The directory or user data stream is configured with integrity (only supported on ReFS volumes).
        /// It is not included in an ordinary directory listing.<para/>
        /// This flag is not supported until Windows Server 2012.
        /// </summary>
        IntegrityStream = 0x00008000,

        /// <summary>
        /// This value is reserved for system use.
        /// </summary>
        Virtual = 0x00010000,

        /// <summary>
        /// The user data stream not to be read by the background data integrity scanner (AKA scrubber).
        /// When set on a directory it only provides inheritance. This flag is only supported on Storage Spaces
        /// and ReFS volumes. It is not included in an ordinary directory listing.<para/>
        /// This flag is not supported until Windows 8 and Windows Server 2012.
        /// </summary>
        NoScrubData = 0x00020000,

        /// <summary>
        /// This attribute only appears in directory enumeration classes (FILE_DIRECTORY_INFORMATION,
        /// FILE_BOTH_DIR_INFORMATION, etc.). When this attribute is set, it means that the file or directory has
        /// no physical representation on the local system; the item is virtual. Opening the item will be more
        /// expensive than normal, e.g. it will cause at least some of it to be fetched from a remote store.
        /// </summary>
        RecallOnOpen = 0x00040000,

        /// <summary>
        /// When this attribute is set, it means that the file or directory is not fully present locally. For a file
        /// that means that not all of its data is on local storage (e.g. it may be sparse with some data still in
        /// remote storage). For a directory it means that some of the directory contents are being virtualized from
        /// another location. Reading the file / enumerating the directory will be more expensive than normal, e.g.
        /// it will cause at least some of the file/directory content to be fetched from a remote store. Only
        /// kernel-mode callers can set this bit.
        /// </summary>
        RecallOnDataAccess = 0x00400000,
    }
}

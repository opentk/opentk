using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenToolkit.NT.Native
{
    /// <summary>
    /// Provides a subset of functions from the Windows API, specifically those that are imported from shell32.dll.
    /// </summary>
    public static class Shell32
    {
        /// <summary>
        /// The filename of the dynamic link library (DLL) that contains these functions.
        /// </summary>
        public const string Library = "shell32.dll";

        /// <summary>
        /// Defines the maximum length for a path name in characters (including the terminating null character).
        /// </summary>
        public const uint MaxPathLength = 260;

        /// <summary>
        /// Registers whether a window accepts dropped files.
        /// </summary>
        /// <param name="window">
        /// The identifier of the window that is registering whether it will accept dropped files.
        /// </param>
        /// <param name="accept">
        /// A value that indicates if the window identified by the <paramref name="window"/> parameter accepts dropped
        /// files. This value is true to accept dropped files or false to discontinue accepting dropped files.
        /// </param>
        [DllImport(Library)]
        public static extern void DragAcceptFiles(IntPtr window, bool accept);

        /// <summary>
        /// Retrieves the names of dropped files that result from a successful drag-and-drop operation.
        /// </summary>
        /// <param name="drop">Identifier of the structure that contains the file names of the dropped files.</param>
        /// <param name="fileIndex">
        /// Index of the file to query. If the value of this parameter is 0xFFFFFFFF,
        /// <see cref="DragQueryFile(IntPtr, uint, StringBuilder, uint)"/> returns a count of the files dropped.
        /// If the value of this parameter is between zero and the total number of files dropped,
        /// <see cref="DragQueryFile(IntPtr, uint, StringBuilder, uint)"/> copies the file name with the corresponding
        /// value to the buffer pointed to by the <paramref name="lpszFile"/> parameter.
        /// </param>
        /// <param name="lpszFile">
        /// The address of a buffer that receives the file name of a dropped file when the function returns. This
        /// file name is a null-terminated string. If this parameter is null,
        /// <see cref="DragQueryFile(IntPtr, uint, StringBuilder, uint)"/> returns the required size, in characters,
        /// of this buffer.
        /// </param>
        /// <param name="cch">The size, in characters, of the <paramref name="lpszFile"/> buffer.</param>
        /// <returns>
        /// A nonzero value indicates a successful call.<para/>
        /// When the function copies a file name to the buffer, the return value is a count of the characters copied,
        /// not including the terminating null character.<para/>
        /// If the index value is 0xFFFFFFFF, the return value is a count of the dropped files.
        /// Note that the index variable itself returns unchanged, and therefore remains 0xFFFFFFFF.<para/>
        /// If the index value is between zero and the total number of dropped files, and the lpszFile buffer address
        /// is NULL, the return value is the required size, in characters, of the buffer, not including the terminating
        /// null character.
        /// </returns>
        [DllImport(Library, CharSet = CharSet.Unicode)]
        public static extern uint DragQueryFile
        (
            [In] IntPtr drop,
            [In] uint fileIndex,
            [Out] StringBuilder lpszFile,
            uint cch
        );

        /// <summary>
        /// Releases memory that the system allocated for use in transferring file names to the application.
        /// </summary>
        /// <param name="drop">
        /// Identifier of the structure that describes dropped files. This handle is retrieved from the wParam
        /// parameter of the <see cref="WindowMessage.DropFiles"/> message.
        /// </param>
        [DllImport(Library)]
        public static extern void DragFinish(IntPtr drop);

        /// <summary>
        /// Retrieves information about an object in the file system, such as a file, folder, directory, or drive root.
        /// </summary>
        /// <param name="pszPath">
        /// A pointer to a null-terminated string of maximum length <see cref="MaxPathLength"/> that contains the path
        /// and file name. Both absolute and relative paths are valid.
        /// </param>
        /// <param name="fileAttributes">
        /// A combination of one or more <see cref="FileAttributeFlags"/>. If <paramref name="flags"/> does not
        /// include the <see cref="ShGetFileInfoFlags.UseFileAttributes"/> flag, this parameter is ignored.
        /// </param>
        /// <param name="psfi">Pointer to a <see cref="SHFileInfo"/> structure to receive the file information.</param>
        /// <param name="fileInfo">
        /// The size, in bytes, of the <see cref="SHFileInfo"/> structure pointed to by the
        /// <paramref name="psfi"/> parameter.
        /// </param>
        /// <param name="flags">
        /// The flags that specify the file information to retrieve.
        /// This parameter can be a combination of one or more <see cref="ShGetFileInfoFlags"/>.
        /// </param>
        /// <returns>
        /// Returns a value whose meaning depends on the <paramref name="flags"/> parameter:<para/>
        /// If <paramref name="flags"/> does not contain <see cref="ShGetFileInfoFlags.ExeType"/> or
        /// <see cref="ShGetFileInfoFlags.SysIconIndex"/>, the return value is nonzero if successful,
        /// or zero otherwise.<para/>
        /// If <paramref name="flags"/> contains the <see cref="ShGetFileInfoFlags.ExeType"/> flag, the return value
        /// specifies the type of the executable file. Check the windows API documentation for more information.
        /// </returns>
        [DllImport(Library)]
        public static extern IntPtr SHGetFileInfo
        (
            [In] string pszPath,
            FileAttributeFlags fileAttributes,
            [In] [Out] ref SHFileInfo psfi,
            uint fileInfo,
            ShGetFileInfoFlags flags
        );
    }
}

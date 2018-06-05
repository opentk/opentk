using System;
using System.Runtime.InteropServices;

using HDROP = System.IntPtr;
using LPCTSTR = System.String;
using DWORD = System.Int32;
using UINT = System.UInt32;

namespace OpenTK.NT.Native
{
    public static class Shell32
    {
        private const string Lib = "shell32.dll";

        [DllImport(Lib, CharSet = CharSet.Auto)]
        public static extern bool DragAcceptFiles(IntPtr handle, [MarshalAs(UnmanagedType.Bool)] bool fAccept);

        [DllImport(Lib, CharSet = CharSet.Auto)]
        public static extern uint DragQueryFile(HDROP hDrop, uint iFile, IntPtr lpszFile, uint cch);

        [DllImport(Lib)]
        public static extern void DragFinish(HDROP hDrop);

        [DllImport(Lib)]
        public static extern IntPtr SHGetFileInfo(LPCTSTR pszPath, DWORD dwFileAttributes, ref SHFILEINFO psfi, UINT cbFileInfo, ShGetFileIconFlags uFlags);
    }
}

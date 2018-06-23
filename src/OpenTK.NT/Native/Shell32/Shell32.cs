using System;
using System.Runtime.InteropServices;

using BOOL = System.Boolean;
using DWORD = System.UInt32;
using DWORD_PTR = System.IntPtr;
using HDROP = System.IntPtr;
using HWND = System.IntPtr;
using LPCTSTR = System.String;
using LPTSTR = System.Text.StringBuilder;
using UINT = System.UInt32;

namespace OpenTK.NT.Native
{
    public static class Shell32
    {
        private const string Library = "shell32.dll";

        [DllImport(Library)]
        public static extern void DragAcceptFiles(HWND handle, [MarshalAs(UnmanagedType.Bool)] BOOL fAccept);

        [DllImport(Library, CharSet = CharSet.Auto)]
        public static extern UINT DragQueryFile
        (
            [In] HDROP hDrop,
            [In] UINT iFile,
            [Out] LPTSTR lpszFile,
            UINT cch
        );

        [DllImport(Library)]
        public static extern void DragFinish(HDROP hDrop);

        [DllImport(Library)]
        public static extern DWORD_PTR SHGetFileInfo
        (
            [In] LPCTSTR pszPath,
            DWORD dwFileAttributes,
            [In] [Out] ref SHFileInfo psfi,
            UINT cbFileInfo,
            ShGetFileInfoFlags uFlags
        );
    }
}

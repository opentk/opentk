using OpenTK.Graphics.Vulkan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.Windows.Win32;

namespace OpenTK.Platform.Native.Windows
{
    internal static unsafe partial class COM
    {
        [GeneratedComInterface]
        [Guid("56FDF342-FD6D-11d0-958A-006097C9A090")]
        internal partial interface ITaskbarList
        {
            void HrInit();
            void AddTab(IntPtr /* HWND */ hwnd);
            void DeleteTab(IntPtr /* HWND */ hwnd);
            void ActivateTab(IntPtr /* HWND */ hwnd);
            void SetActiveAlt(IntPtr /* HWND */ hwnd);
        }

        [GeneratedComInterface]
        [Guid("602D4995-B13A-429b-A66E-1935E44F4317")]
        internal partial interface ITaskbarList2 : ITaskbarList
        {
            void MarkFullscreenWindow(IntPtr /* HWND */ hwnd, [MarshalAs(UnmanagedType.Bool)] bool fFullscreen);
        }

        internal struct THUMBBUTTON
        {
            public THUMBBUTTONMASK dwMask;
            public uint iId;
            public uint iBitmap;
            public IntPtr /* HICON */ hIcon;
            public fixed char szTip[260];
            public THUMBBUTTONFLAGS dwFlags;
        }

        [GeneratedComInterface]
        [Guid("ea1afb91-9e28-4b86-90e9-9e9f8a5eefaf")]
        internal partial interface ITaskbarList3 : ITaskbarList2
        {
            void SetProgressValue(IntPtr /* HWND */ hwnd, ulong ullCompleted, ulong ullTotal);
            void SetProgressState(IntPtr /* HWND */ hwnd, TBPFLAG tbpFlags);
            void RegisterTab(IntPtr /* HWND */ hwndTab, IntPtr /* HWND */ hwndMDI);
            void UnregisterTab(IntPtr /* HWND */ hwndTab);
            void SetTabOrder(IntPtr /* HWND */ hwndTab, IntPtr /* HWND */ hwndInsertBefore);
            void SetTabActive(IntPtr /* HWND */ hwndTab, IntPtr /* HWND */ hwndMDI, uint dwReserved);
            void ThumbBarAddButtons(IntPtr /* HWND */ hwnd, uint cButtons, THUMBBUTTON* pButton);
            void ThumbBarUpdateButtons(IntPtr /* HWND */ hwnd, uint cButtons, THUMBBUTTON* pButton);
            void ThumbBarSetImageList(IntPtr /* HWND */ hwnd, IntPtr /* HIMAGELIST */ himl);
            void SetOverlayIcon(IntPtr /* HWND */ hwnd, IntPtr /* HICON */ hIcon, [MarshalAs(UnmanagedType.LPWStr)] string /* LPCWSTR */ pszDescription);
            void SetThumbnailTooltip(IntPtr /* HWND */ hwnd, [MarshalAs(UnmanagedType.LPWStr)] string /* LPCWSTR */ pszTip);
            void SetThumbnailClip(IntPtr /* HWND */ hwnd, Win32.RECT *prcClip);
        }

        internal static readonly Guid CLSID_TaskbarList = new Guid("56FDF344-FD6D-11d0-958A-006097C9A090");

        [DllImport("ole32.dll")]
        internal static extern int /* HRESULT */ CoCreateInstance(in Guid rclsid, IntPtr /* LPUNKNOWN */ pUnkOuter, CLSCTX dwClsContext, in Guid riid, out IntPtr ppv);
    }
}

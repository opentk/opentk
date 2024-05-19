using Microsoft.Win32.SafeHandles;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.Windows.XInput;

namespace OpenTK.Platform.Native.Windows
{
    internal class DialogHandle
    {
        
    };

    internal struct Button
    {
        public string Text;
    }

    internal struct DLGTEMPLATEEX
    {
        public ushort dlgVer;
        public ushort signature;
        public uint helpID;
        public WindowStylesEx exStyle;
        public DialogStyles style;
        public ushort cDlgItems;
        public short x;
        public short y;
        public short cx;
        public short cy;
        /*
        sz_Or_Ord menu;
        sz_Or_Ord windowClass;
        char title[titleLen];
        ushort pointsize;
        ushort weight;
        byte italic;
        byte charset;
        char typeface[stringLen];
        */
    }

    internal struct DLGITEMTEMPLATEEX
    {
        public uint helpID;
        public WindowStylesEx exStyle;
        // FIXME: 
        public uint style;
        public short x;
        public short y;
        public short cx;
        public short cy;
        public uint id;
        /*
        sz_Or_Ord windowClass;
        sz_Or_Ord title;
        WORD extraCount;
        */
    }

    // Make struct?
    internal unsafe struct DialogData
    {
        public const nuint BLOCK_SIZE = 4096;

        public enum ControlType : ushort
        {
            Button = 0x0080,
            Edit = 0x0081,
            Static = 0x0082,
            Listbox = 0x0083,
            Scrollbar = 0x0084,
            Combobox = 0x0085,
        }

        public byte* Data;
        public nuint Size;
        public nuint Used;

        public static DialogData Alloc()
        {
            DialogData data;
            data.Size = 4096;
            data.Data = (byte*)NativeMemory.AlignedAlloc(data.Size, sizeof(int));
            data.Used = 0;
            return data;
        }

        public void EnsureSize(nuint size)
        {
            if (Used + size > Size)
            {
                Data = (byte*)NativeMemory.AlignedRealloc(Data, Size + BLOCK_SIZE, sizeof(int));
                Size += BLOCK_SIZE;
            }
        }

        public void AlignData(nuint alignment)
        {
            nuint padding = Used % alignment;
            EnsureSize(Used + padding);
            Used += padding;
        }

        public void AddDialogData<T>(T data) where T : unmanaged
        {
            EnsureSize(Size + (uint)sizeof(T));
            NativeMemory.Copy(&data, &Data[Used], (uint)sizeof(T));
            Used += (uint)sizeof(T);
        }

        public void AddDialogString(string str)
        {
            uint dataSize = (uint)(str.Length * sizeof(char));
            EnsureSize(Size + dataSize);
            fixed (char* c = str)
            {
                NativeMemory.Copy(c, &Data[Used], (uint)dataSize);
            }
            Used += dataSize;
        }

        // FIXME: Strong type for type
        public void AddDialogControl(ControlType type, uint style, WindowStylesEx exStyle, uint id, string caption)
        {
            DLGITEMTEMPLATEEX itemTemplate;
            itemTemplate.helpID = 0;
            itemTemplate.exStyle = exStyle;
            itemTemplate.style = (uint)style;
            // FIXME: position!
            itemTemplate.x = 0;
            itemTemplate.y = 0;
            itemTemplate.cx = 10;
            itemTemplate.cy = 10;
            itemTemplate.id = id;

            AlignData(sizeof(int));

            AddDialogData(itemTemplate);

            // windowClass
            AddDialogData<ushort>(0xFFFF);
            AddDialogData(type);

            AddDialogString(caption);

            // extraData
            AddDialogData<short>(0);

            ((DLGTEMPLATEEX*)Data)->cDlgItems++;
        }

        public void Init(int w, int h, string caption)
        {
            DLGTEMPLATEEX template;
            template.dlgVer = 1;
            template.signature = 0xFFFF;
            template.helpID = 0;
            template.exStyle = 0;
            template.style = DialogStyles.Caption | DialogStyles.Center | DialogStyles.ShellFont;
            template.cDlgItems = 0;
            template.x = 0;
            template.y = 0;
            // FIXME: These are in DLU units not in pixels?
            template.cx = (short)w;
            template.cy = (short)h;

            AddDialogData(template);

            // No menu
            AddDialogData<short>(0);

            // No custom class
            AddDialogData<short>(0);

            AddDialogString(caption);

            // FIXME: Font stuff!
            // pointsize
            AddDialogData<short>(12);
            // weight
            AddDialogData<short>(400);
            // italic
            AddDialogData<byte>(0);
            // charset
            AddDialogData<byte>(0);
            // FIXME: Font name!
            AddDialogString("Arial");

            AddDialogControl(ControlType.Button, (uint)WindowStyles.Visible | (uint)WindowStyles.Child | (uint)WindowStyles.TabStop | (uint)ButtonStyles.BS_DEFPUSHBUTTON | (uint)WindowStyles.Group, 0, 1, "Hello!");
        }
    }

    public class DialogComponent : IDialogComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(DialogComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Dialog;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Dialog)
            {
                throw new Exception("DialogComponent can only initialize the Dialog component.");
            }
        }

        /// <inheritdoc/>
        public bool CanTargetFolders => false;

        static IntPtr /* INT_PTR */ MessageBoxDialogProc(IntPtr /* HWND */ hDlg, WM iMessage, UIntPtr /* WPARAM */ wParam, IntPtr /* LPARAM */ lParam)
        {
            Console.WriteLine($"Message: {iMessage}, wParam: {wParam}, lParam: {lParam}");

            switch (iMessage)
            {
                case WM.INITDIALOG:
                    return 1;
                default:
                    break;
            }

            return 0;
        }

        internal unsafe int ShowMessageBox(WindowHandle parent, string text, IconHandle icon, ReadOnlySpan<Button> buttons)
        {
            // FIXME:
            HWND hwnd = parent.As<HWND>(null!);

            DialogData diag = DialogData.Alloc();
            diag.Init(20, 20, "Test dialog");

            var ret = Win32.DialogBoxIndirectParamW(IntPtr.Zero, (DLGTEMPLATEEX*)diag.Data, hwnd.HWnd, MessageBoxDialogProc, IntPtr.Zero);
            if (ret == -1)
            {
                throw new Win32Exception();
            }

            return 0;
        }

        // The size of the buffer used to receive file paths.
        // FIXME: Do something to avoid having this limit?
        const int MAX_FILE_LENGTH = 1024;

        private unsafe char* CreateFilterString(DialogFileFilter[]? filters)
        {
            char* extensionListPtr;
            if (filters == null)
            {
                string filter = "All Files\0*.*\0\0";
                extensionListPtr = (char*)Marshal.AllocHGlobal(filter.Length * 2);
                Span<char> extensionList = new Span<char>(extensionListPtr, filter.Length);
                filter.CopyTo(extensionList);
            }
            else
            {
                int chars = 1;
                for (int i = 0; i < filters.Length; i++)
                {
                    chars += filters[i].Name.Length + 1;
                    // +2 for '*.' and +1 for \0
                    chars += filters[i].Filter.Length + 2 + 1;
                }

                extensionListPtr = (char*)Marshal.AllocHGlobal(chars * 2);
                Span<char> extensionList = new Span<char>(extensionListPtr, chars);

                int offset = 0;
                for (int i = 0; i < filters.Length; i++)
                {
                    filters[i].Name.CopyTo(extensionList.Slice(offset));
                    offset += filters[i].Name.Length;
                    extensionList[offset++] = '\0';

                    extensionList[offset++] = '*';
                    extensionList[offset++] = '.';
                    filters[i].Filter.CopyTo(extensionList.Slice(offset));
                    offset += filters[i].Filter.Length;
                    extensionList[offset++] = '\0';
                }
                extensionList[offset++] = '\0';
            }

            return extensionListPtr;
        }

        /// <inheritdoc/>
        public unsafe List<string>? ShowOpenDialog(WindowHandle parent, string title, string directory, DialogFileFilter[]? allowedExtensions, OpenDialogOptions options)
        {
            HWND hwnd = parent.As<HWND>(this);

            char* extensionListPtr = CreateFilterString(allowedExtensions);

            char* titlePtr = (char*)Marshal.StringToHGlobalUni(title);
            char* directoryPtr = (char*)Marshal.StringToHGlobalUni(directory);
            // FIXME: Do something to support default extension..
            //char* defaultExt = (char*)Marshal.StringToHGlobalUni($"\0{allowedExtensions?[0].Ext}");

            Win32.OPENFILENAMEW dialog;
            dialog.lStructSize = (uint)Marshal.SizeOf<Win32.OPENFILENAMEW>();
            dialog.hwndOwner = hwnd.HWnd;
            dialog.hInstance = 0;
            dialog.lpstrFilter = extensionListPtr; // FIXME: Create a string with all of the required null terminations and internal strings.
            dialog.lpstrCustomFilter = null;
            dialog.nMaxCustFilter = 0;
            dialog.nFilterIndex = 0;
            dialog.lpstrFile = (char*)NativeMemory.AllocZeroed(MAX_FILE_LENGTH);
            dialog.nMaxFile = MAX_FILE_LENGTH;
            dialog.lpstrFileTitle = null;
            dialog.nMaxFileTitle = 0;
            dialog.lpstrInitialDir = directoryPtr;
            dialog.lpstrTitle = titlePtr;
            dialog.Flags = OFN.Explorer | OFN.HideReadOnly | (options.HasFlag(OpenDialogOptions.AllowMultiSelect) ? OFN.AllowMultiSelect : 0u);
            dialog.nFileOffset = 0;
            dialog.nFileExtension = 0;
            // FIXME: This only appends 3 characters...
            dialog.lpstrDefExt = null;
            dialog.lCustData = 0;
            dialog.lpfnHook = 0;
            dialog.lpTemplateName = null;
            dialog.pvReserved = null;
            dialog.dwReserved = 0;
            dialog.FlagsEx = 0;

            bool success = Win32.GetOpenFileNameW(ref dialog);
            if (success == false)
            {
                int error = (int)Win32.CommDlgExtendedError();
                if (error == 0)
                {
                    // FIXME: Free allocations.
                    return null;
                }
                else
                {
                    // FIXME: Proper error!
                    throw new Win32Exception(error);
                }
            }

            Marshal.FreeHGlobal((nint)extensionListPtr);
            Marshal.FreeHGlobal((nint)titlePtr);
            Marshal.FreeHGlobal((nint)directoryPtr);
            //Marshal.FreeHGlobal((nint)defaultExt);

            int length = 0;
            while (dialog.lpstrFile[length + 1] != 0)
            {
                while (dialog.lpstrFile[++length] != 0) { }
            }

            List<string> result = new List<string>();

            // FIXME: Double check this logic...
            Span<char> selectedFiles = new Span<char>(dialog.lpstrFile, length + 1);
            if (options.HasFlag(OpenDialogOptions.AllowMultiSelect) && selectedFiles.Contains('\0'))
            {
                Span<char> selectedDirectory = selectedFiles.Slice(0, selectedFiles.IndexOf('\0'));

                selectedFiles = selectedFiles.Slice(selectedDirectory.Length + 1);
                while (selectedFiles.Length > 0)
                {
                    Span<char> selectedFile = selectedFiles.Slice(0, selectedFiles.IndexOf('\0'));
                    result.Add(Path.Join(selectedDirectory, selectedFile));
                    selectedFiles = selectedFiles.Slice(selectedFile.Length + 1);
                }
            }
            else
            {
                // FIXME: What if no file was selected?
                // We trim the last byte off the name as that is a null terminator.
                result.Add(selectedFiles.Slice(0, selectedFiles.Length - 1).ToString());
            }

            NativeMemory.Free(dialog.lpstrFile);

            return result;
        }

        /// <inheritdoc/>
        public unsafe string? ShowSaveDialog(WindowHandle parent, string title, string directory, DialogFileFilter[]? allowedExtensions, SaveDialogOptions options)
        {
            HWND hwnd = parent.As<HWND>(this);

            char* extensionListPtr = CreateFilterString(allowedExtensions);
            
            char* titlePtr = (char*)Marshal.StringToHGlobalUni(title);
            char* directoryPtr = (char*)Marshal.StringToHGlobalUni(directory);
            //char* defaultExt = (char*)Marshal.StringToHGlobalUni($"\0{allowedExtensions[0]}");

            Win32.OPENFILENAMEW dialog;
            dialog.lStructSize = (uint)Marshal.SizeOf<Win32.OPENFILENAMEW>();
            dialog.hwndOwner = hwnd.HWnd;
            dialog.hInstance = 0;
            dialog.lpstrFilter = extensionListPtr; // FIXME: Create a string with all of the required null terminations and internal strings.
            dialog.lpstrCustomFilter = null;
            dialog.nMaxCustFilter = 0;
            dialog.nFilterIndex = 0;
            dialog.lpstrFile = (char*)NativeMemory.AllocZeroed(MAX_FILE_LENGTH);
            dialog.nMaxFile = MAX_FILE_LENGTH;
            dialog.lpstrFileTitle = null;
            dialog.nMaxFileTitle = 0;
            dialog.lpstrInitialDir = directoryPtr;
            dialog.lpstrTitle = titlePtr;
            dialog.Flags = OFN.Explorer | OFN.OverwritePrompt;
            dialog.nFileOffset = 0;
            dialog.nFileExtension = 0;
            // FIXME: This only appends 3 characters...
            dialog.lpstrDefExt = null;
            dialog.lCustData = 0;
            dialog.lpfnHook = 0;
            dialog.lpTemplateName = null;
            dialog.pvReserved = null;
            dialog.dwReserved = 0;
            dialog.FlagsEx = 0;

            bool success = Win32.GetSaveFileNameW(ref dialog);
            if (success == false)
            {
                int error = (int)Win32.CommDlgExtendedError();
                if (error == 0)
                {
                    // FIXME: Free allocations.
                    return null;
                }
                else
                {
                    // FIXME: Proper error!
                    throw new Win32Exception(error);
                }
            }

            Marshal.FreeHGlobal((nint)extensionListPtr);
            Marshal.FreeHGlobal((nint)titlePtr);
            Marshal.FreeHGlobal((nint)directoryPtr);
            //Marshal.FreeHGlobal((nint)defaultExt);

            int length = 0;
            while (dialog.lpstrFile[length + 1] != 0)
            {
                while (dialog.lpstrFile[++length] != 0) { }
            }

            string result;
            // FIXME: Double check this logic...
            Span<char> selectedFiles = new Span<char>(dialog.lpstrFile, length + 1);
            {
                // FIXME: What if the file name is weird or zero?
                // We trim the last byte off the name as that is a null terminator.
                result = selectedFiles.Slice(0, selectedFiles.Length - 1).ToString();
            }

            NativeMemory.Free(dialog.lpstrFile);

            return result;
        }
    }
}

using OpenTK.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.Native.Windows
{
    public class DialogComponent : IDialogComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(DialogComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Dialog;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        internal IntPtr ActivationContext;
        internal uint ActivationContextCookie;

        /// <inheritdoc/>
        public unsafe void Initialize(ToolkitOptions options)
        {
            // FIXME: Make sure we support the correct styling??
            // Either through a manifest or enabling it ourselves?
            // See EnableVisualStyles or https://stackoverflow.com/questions/1415270/c-comctl32-dll-version-6-in-debugger
            // - Noggin_bops 2024-07-17

            if (options.Windows.EnableVisualStyles)
            {
                Module module = typeof(DialogComponent).Module;
                IntPtr moduleHandle = Win32.GetModuleHandle(module.Name);
                if (moduleHandle != 0)
                {
                    // We where able to read the module, so we can get the embedded manifest.
                    Win32.ACTCTXW context = default;
                    context.cbSize = (uint)sizeof(Win32.ACTCTXW);
                    // CSC embeds DLL manifests as native resource ID 2
                    // https://github.com/dotnet/roslyn/blob/fab7134296816fc80019c60b0f5bef7400cf23ea/src/Compilers/Core/Portable/CvtRes.cs#L562
                    context.lpResourceName = (char*)2;
                    context.dwFlags = ACTCTXFlag.HModuleValid | ACTCTXFlag.ResourceNameValid;
                    context.hModule = moduleHandle;

                    ActivationContext = Win32.CreateActCtxW(ref context);
                    if (ActivationContext == Win32.INVALID_HANDLE_VALUE)
                    {
                        // FIXME: Maybe don't throw the exception?
                        throw new Win32Exception();
                    }

                    Logger?.LogDebug("Enabled visual styles through module native resource manifest.");
                }
                else
                {
                    using Stream? stream = module.Assembly.GetManifestResourceStream("OpenTK.Platform.Native.Windows.VisualStyles.manifest");
                    if (stream != null)
                    {
                        string tempFilePath = Path.Join(Path.GetDirectoryName(module.Assembly.Location), Path.GetRandomFileName());
                        tempFilePath = Path.ChangeExtension(tempFilePath, "manifest");
                        using (FileStream tempFileStream = new FileStream(tempFilePath, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.Delete | FileShare.ReadWrite))
                        {
                            stream.CopyTo(tempFileStream);
                        }

                        fixed (char* tempFilePathPtr = tempFilePath)
                        {
                            File.Exists(tempFilePath);

                            Win32.ACTCTXW context = default;
                            context.cbSize = (uint)sizeof(Win32.ACTCTXW);
                            context.lpSource = tempFilePathPtr;

                            ActivationContext = Win32.CreateActCtxW(ref context);
                            if (ActivationContext == Win32.INVALID_HANDLE_VALUE)
                            {
                                throw new Win32Exception();
                            }
                        }

                        try
                        {
                            File.Delete(tempFilePath);
                        }
                        catch (Exception e) when (e is UnauthorizedAccessException or IOException)
                        {
                            // If we can't delete the file we continue.
                            // - Noggin_bops 2024-08-01
                            Logger?.LogInfo($"Wasn't able to delete temporary manifest file '{tempFilePath}'.");
                        }

                        Logger?.LogDebug("Enabled visual styles through temporary file manifest.");
                    }
                    else
                    {
                        Logger?.LogWarning("Was not able to get native module handle or open manifest resource stream. Can't enable visual styles.");
                    }
                }

                // FIXME: Don't gobally activate this context?
                if (ActivationContext != Win32.INVALID_HANDLE_VALUE)
                {
                    bool success = Win32.ActivateActCtx(ActivationContext, out ActivationContextCookie);
                    if (success == false)
                    {
                        throw new Win32Exception();
                    }
                }
            }
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
            if (ActivationContext != Win32.INVALID_HANDLE_VALUE)
            {
                // FIXME: This doesn't seem to work for some reason..
                // We get an exception, not even a false return value.
                // - Noggin_bops 2024-10-30
                /*
                bool success = Win32.DeactivateActCtx(0, ActivationContextCookie);
                if (success == false)
                {
                    throw new Win32Exception();
                }
                */
            }
        }

        /// <inheritdoc/>
        public bool CanTargetFolders => false;

        /// <inheritdoc/>
        public unsafe MessageBoxButton ShowMessageBox(WindowHandle parent, string title, string content, MessageBoxType messageBoxType, IconHandle? customIcon = null)
        {
            // FIXME:
            HWND hwnd = parent.As<HWND>(this);
            HIcon? hicon = customIcon?.As<HIcon>(this);

            IntPtr iconResouce;
            TASKDIALOG_COMMON_BUTTON_FLAGS commonButtons;
            switch (messageBoxType)
            {
                case MessageBoxType.Information:
                    iconResouce = Win32.TD_INFORMATION_ICON;
                    commonButtons = TASKDIALOG_COMMON_BUTTON_FLAGS.OKButton;
                    break;
                case MessageBoxType.Warning:
                    iconResouce = Win32.TD_WARNING_ICON;
                    commonButtons = TASKDIALOG_COMMON_BUTTON_FLAGS.OKButton;
                    break;
                case MessageBoxType.Error:
                    iconResouce = Win32.TD_ERROR_ICON;
                    commonButtons = TASKDIALOG_COMMON_BUTTON_FLAGS.OKButton;
                    break;
                case MessageBoxType.Confirmation:
                    iconResouce = Win32.TD_INFORMATION_ICON;
                    commonButtons = TASKDIALOG_COMMON_BUTTON_FLAGS.YesButton | TASKDIALOG_COMMON_BUTTON_FLAGS.NoButton | TASKDIALOG_COMMON_BUTTON_FLAGS.CancelButton;
                    break;
                case MessageBoxType.Retry:
                    iconResouce = Win32.TD_INFORMATION_ICON;
                    commonButtons = TASKDIALOG_COMMON_BUTTON_FLAGS.RetryButton | TASKDIALOG_COMMON_BUTTON_FLAGS.CancelButton;
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(messageBoxType), (int)messageBoxType, messageBoxType.GetType());
            }

            int result;
            int pnButton = default;

            fixed (char* titlePtr = title)
            fixed (char* contentPtr = content)
            fixed (char* instPtr = "TEST INSTRUCTION")
            {
                Win32.TASKDIALOGCONFIG dialogConfig;
                dialogConfig.cbSize = (uint)Marshal.SizeOf<Win32.TASKDIALOGCONFIG>();
                dialogConfig.hwndParent = hwnd.HWnd;
                dialogConfig.hInstance = IntPtr.Zero;
                dialogConfig.dwFlags = TASKDIALOG_FLAGS.SizeToContent | (hicon != null ? TASKDIALOG_FLAGS.UseHIconMain : 0);
                dialogConfig.dwCommonButtons = commonButtons;
                dialogConfig.pszWindowTitle = titlePtr;
                dialogConfig.hMainIcon = hicon?.Icon ?? iconResouce;
                dialogConfig.pszMainInstruction = titlePtr;
                dialogConfig.pszContent = contentPtr;
                dialogConfig.cButtons = 0;
                dialogConfig.pButtons = null;
                dialogConfig.nDefaultButton = TaskDialogButtonID.IDCLOSE;
                dialogConfig.cRadioButtons = 0;
                dialogConfig.pRadioButtons = null;
                dialogConfig.nDefaultRadioButton = 0;
                dialogConfig.pszVerificationText = null;
                dialogConfig.pszExpandedInformation = null;
                dialogConfig.pszExpandedControlText = null;
                dialogConfig.pszCollapsedControlText = null;
                dialogConfig.hFooterIcon = IntPtr.Zero;
                dialogConfig.pszFooter = null;
                dialogConfig.pfCallback = null;
                dialogConfig.lpCallbackData = UIntPtr.Zero;
                dialogConfig.cxWidth = 0;

                result = Win32.TaskDialogIndirect(in dialogConfig, ref pnButton, ref Unsafe.NullRef<int>(), ref Unsafe.NullRef<int>());
            }

            if (result != Win32.S_OK)
            {
                if (result == Win32.E_OUTOFMEMORY)
                {
                    throw new OutOfMemoryException();
                }
                else if (result == Win32.E_INVALIDARG)
                {
                    throw new ArgumentException();
                }
                else if (result == Win32.E_FAIL)
                {
                    Logger?.LogWarning($"TaskDialogIndirect returned E_FAIL ({result})");
                    return MessageBoxButton.None;
                }
                else
                {
                    Logger?.LogWarning($"TaskDialogIndirect returned unknown error {result}");
                    return MessageBoxButton.None;
                }
            }
            else
            {
                MessageBoxButton pressedButton;
                switch ((TaskDialogButtonID)pnButton)
                {
                    case TaskDialogButtonID.IDOK:
                        pressedButton = MessageBoxButton.Ok;
                        break;
                    case TaskDialogButtonID.IDCANCEL:
                        pressedButton = MessageBoxButton.Cancel;
                        break;
                    case TaskDialogButtonID.IDABORT:
                        Logger?.LogWarning($"Unexpected task dialog button: {(TaskDialogButtonID)pnButton}.");
                        pressedButton = MessageBoxButton.None;
                        break;
                    case TaskDialogButtonID.IDRETRY:
                        pressedButton = MessageBoxButton.Retry;
                        break;
                    case TaskDialogButtonID.IDIGNORE:
                        Logger?.LogWarning($"Unexpected task dialog button: {(TaskDialogButtonID)pnButton}.");
                        pressedButton = MessageBoxButton.None;
                        break;
                    case TaskDialogButtonID.IDYES:
                        pressedButton = MessageBoxButton.Yes;
                        break;
                    case TaskDialogButtonID.IDNO:
                        pressedButton = MessageBoxButton.No;
                        break;
                    case TaskDialogButtonID.IDCLOSE:
                        Logger?.LogWarning($"Unexpected task dialog button: {(TaskDialogButtonID)pnButton}.");
                        pressedButton = MessageBoxButton.None;
                        break;
                    case TaskDialogButtonID.IDHELP:
                        Logger?.LogWarning($"Unexpected task dialog button: {(TaskDialogButtonID)pnButton}.");
                        pressedButton = MessageBoxButton.None;
                        break;
                    default:
                        Logger?.LogWarning($"Unexpected task dialog button: {(TaskDialogButtonID)pnButton}.");
                        pressedButton = MessageBoxButton.None;
                        break;
                }

                return pressedButton;
            }
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
                    // +1 for \0
                    chars += filters[i].Filter.Length + 1;
                    // *2 for '*.'
                    chars += (filters[i].Filter.Count(static c => c == ';') + 1) * 3;
                }

                extensionListPtr = (char*)Marshal.AllocHGlobal(chars * 2);
                Span<char> extensionList = new Span<char>(extensionListPtr, chars);

                int offset = 0;
                for (int i = 0; i < filters.Length; i++)
                {
                    filters[i].Name.CopyTo(extensionList.Slice(offset));
                    offset += filters[i].Name.Length;
                    extensionList[offset++] = '\0';

                    int currIndex = 0;
                    do
                    {
                        int prevIndex = currIndex;
                        currIndex = filters[i].Filter.IndexOf(';', prevIndex);
                        if (currIndex == -1)
                        {
                            currIndex = filters[i].Filter.Length;
                        }

                        ReadOnlySpan<char> ext = filters[i].Filter.AsSpan().Slice(prevIndex, currIndex - prevIndex);

                        extensionList[offset++] = '*';
                        extensionList[offset++] = '.';
                        ext.CopyTo(extensionList.Slice(offset));
                        offset += ext.Length;
                        if (currIndex < filters[i].Filter.Length)
                            extensionList[offset++] = ';';

                        currIndex++;
                    } while (currIndex < filters[i].Filter.Length);
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

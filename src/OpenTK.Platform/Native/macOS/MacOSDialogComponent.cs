﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using OpenTK.Platform;
using OpenTK.Core.Utility;
using System.Runtime.CompilerServices;
using static OpenTK.Platform.Native.macOS.ObjC;
using static OpenTK.Platform.Native.macOS.MacOSWindowComponent;

namespace OpenTK.Platform.Native.macOS
{
    public class MacOSDialogComponent : IDialogComponent
    {
        internal static readonly ObjCClass NSOpenPanelClass = objc_getClass("NSOpenPanel"u8);
        internal static readonly ObjCClass NSSavePanelClass = objc_getClass("NSSavePanel"u8);
        internal static readonly ObjCClass NSURLClass = objc_getClass("NSURL"u8);
        internal static readonly ObjCClass UTTypeClass = objc_getClass("UTType"u8);
        internal static readonly ObjCClass NSMutableArrayClass = objc_getClass("NSMutableArray"u8);
        internal static readonly ObjCClass NSAlert = objc_getClass("NSAlert"u8);
        internal static readonly ObjCClass NSObject = objc_getClass("NSObject"u8);

        internal static readonly ObjCClass NSStackBlock = objc_getClass("NSStackBlock"u8);

        internal static readonly SEL selOpenPanel = sel_registerName("openPanel"u8);
        internal static readonly SEL selSavePanel = sel_registerName("savePanel"u8);
        internal static readonly SEL selRunModal = sel_registerName("runModal"u8);
        internal static readonly SEL selBeginSheetModalForWindow_ModalDelegate_DidEndSelector_ContextInfo = sel_registerName("beginSheetModalForWindow:modalDelegate:didEndSelector:contextInfo:"u8);
        internal static readonly SEL selBeginSheet_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo = sel_registerName("beginSheet:modalForWindow:modalDelegate:didEndSelector:contextInfo:"u8);
        internal static readonly SEL selBeginSheetForDirectory_File_Types_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo = sel_registerName("beginSheetForDirectory:file:types:modalForWindow:modalDelegate:didEndSelector:contextInfo:"u8);
        internal static readonly SEL selBeginSheetForDirectory_File_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo = sel_registerName("beginSheetForDirectory:file:modalForWindow:modalDelegate:didEndSelector:contextInfo:"u8);

        internal static readonly SEL selTitle = sel_registerName("title"u8);
        internal static readonly SEL selSetTitle = sel_registerName("setTitle:"u8);

        internal static readonly SEL selAllowMultipleSelection = sel_registerName("allowsMultipleSelection"u8);
        internal static readonly SEL selSetAllowMultipleSelection = sel_registerName("setAllowsMultipleSelection:"u8);

        internal static readonly SEL selCanChooseFiles = sel_registerName("canChooseFiles"u8);
        internal static readonly SEL selSetCanChooseFiles = sel_registerName("setCanChooseFiles:"u8);

        internal static readonly SEL selCanChooseDirectories = sel_registerName("canChooseDirectories"u8);
        internal static readonly SEL selSetCanChooseDirectories = sel_registerName("setCanChooseDirectories:"u8);

        internal static readonly SEL selDirectoryURL = sel_registerName("directoryURL"u8);
        internal static readonly SEL selSetDirectoryURL = sel_registerName("setDirectoryURL:"u8);

        internal static readonly SEL selNameFieldStringValue = sel_registerName("nameFieldStringValue"u8);
        internal static readonly SEL selSetNameFieldStringValue = sel_registerName("setNameFieldStringValue:"u8);

        internal static readonly SEL selCanCreateDirectories = sel_registerName("canCreateDirectories"u8);
        internal static readonly SEL selSetCanCreateDirectories = sel_registerName("setCanCreateDirectories:"u8);

        internal static readonly SEL selAllowedContentTypes = sel_registerName("allowedContentTypes"u8);
        internal static readonly SEL selSetAllowedContentTypes = sel_registerName("setAllowedContentTypes:"u8);
        internal static readonly SEL selAllowsOtherFileTypes = sel_registerName("allowsOtherFileTypes"u8);
        internal static readonly SEL selSetAllowsOtherFileTypes = sel_registerName("setAllowsOtherFileTypes:"u8);
        
        internal static readonly SEL selSuperclass = sel_registerName("superclass"u8);
        internal static readonly SEL selRun = sel_registerName("run"u8);
        internal static readonly SEL selStopModal = sel_registerName("stopModal"u8);
        internal static readonly SEL selStopModalWithCode = sel_registerName("stopModalWithCode:"u8);
        internal static readonly SEL selRunModalForWindow = sel_registerName("runModalForWindow:"u8);
        internal static readonly SEL selEndSheet = sel_registerName("endSheet:"u8);


        internal static readonly SEL selURL = sel_registerName("URL"u8);
        internal static readonly SEL selURLs = sel_registerName("URLs"u8);
        internal static readonly SEL selCount = sel_registerName("count"u8);
        internal static readonly SEL selObjectAtIndex = sel_registerName("objectAtIndex:"u8);
        internal static readonly SEL selIsFileURL = sel_registerName("isFileURL"u8);
        internal static readonly SEL selFileSystemRepresentation = sel_registerName("fileSystemRepresentation"u8);

        internal static readonly SEL selFileURLWithPath_isDirectory = sel_registerName("fileURLWithPath:isDirectory:"u8);

        internal static readonly SEL selTypeWithFilenameExtension = sel_registerName("typeWithFilenameExtension:"u8);

        internal static readonly SEL selArrayWithCapacity = sel_registerName("arrayWithCapacity:"u8);
        internal static readonly SEL selAddObject = sel_registerName("addObject:"u8);

        internal static readonly SEL selInit = sel_registerName("init"u8);
        internal static readonly SEL selSetMessageText = sel_registerName("setMessageText:"u8);
        internal static readonly SEL selSetInformativeText = sel_registerName("setInformativeText:"u8);
        internal static readonly SEL selSetIcon = sel_registerName("setIcon:"u8);
        internal static readonly SEL selAddButtonWithTitle = sel_registerName("addButtonWithTitle:"u8);
        internal static readonly SEL selSetAlertStyle = sel_registerName("setAlertStyle:"u8);
        internal static readonly SEL selLayout = sel_registerName("layout"u8);

        /// <inheritdoc/>
        public string Name => nameof(MacOSDialogComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Dialog;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        internal ObjCClass NSOtkSyncModalClass;

        /// <inheritdoc/>
        public unsafe void Initialize(ToolkitOptions options)
        {
            NSOtkSyncModalClass = objc_allocateClassPair(NSObject, "NSOtkSyncModal"u8, 0);

            class_addMethod(NSOtkSyncModalClass, selInitWithAlert_AsSheetForWindow, (IntPtr)NSOtkSyncModal_InitWithAlert_AsSheetForWindowInst, "@@:@@"u8);
            class_addMethod(NSOtkSyncModalClass, selInitWithOpenPanel_AsSheetForWindow_InDirectory_File_Types, (IntPtr)NSOtkSyncModal_InitWithOpenPanel_AsSheetForWindow_InDirectory_File_TypesInst, "@@:@@@@@"u8);
            class_addMethod(NSOtkSyncModalClass, selInitWithSavePanel_AsSheetForWindow_InDirectory_File, (IntPtr)NSOtkSyncModal_InitWithSavePanel_AsSheetForWindow_InDirectory_FileInst, "@@:@@@@"u8);
            class_addMethod(NSOtkSyncModalClass, selRun, (IntPtr)NSOtkSyncModal_RunInst, "q@:@@"u8);
            // FIXME: This is going to be called from NSAlert with an NSInteger, but we use q here. This will break on arm.
            class_addMethod(NSOtkSyncModalClass, selAlertDidEnd_ReturnCode, (IntPtr)NSOtkSyncModal_AlertDidEnd_ReturnCodeInst, "v@:@q@"u8);
            class_addMethod(NSOtkSyncModalClass, selFilePanelDidEnd_ReturnCode, (IntPtr)NSOtkSyncModal_FilePanelDidEnd_ReturnCodeInst, "v@:@q@"u8);

            objc_registerClassPair(NSOtkSyncModalClass);
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
            objc_disposeClassPair(NSOtkSyncModalClass);
        }

        internal static readonly SEL selInitWithAlert_AsSheetForWindow = sel_registerName("initWithAlert:asSheetForWindow:"u8);
        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, IntPtr, IntPtr> NSOtkSyncModal_InitWithAlert_AsSheetForWindowInst = &NSOtkSyncModal_InitWithAlert_AsSheetForWindow;
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        private static IntPtr NSOtkSyncModal_InitWithAlert_AsSheetForWindow(IntPtr syncObj, SEL selector, IntPtr alert, IntPtr window)
        {
            objc_super super;
            super.receiver = syncObj;
            super.pclass = (ObjCClass)objc_msgSend_IntPtr(syncObj, selSuperclass);
            objc_msgSendSuper(super, selInit);

            objc_msgSend(
                alert, 
                selBeginSheetModalForWindow_ModalDelegate_DidEndSelector_ContextInfo,
                window,
                syncObj,
                selAlertDidEnd_ReturnCode,
                IntPtr.Zero);

            return syncObj;
        }

        internal static readonly SEL selInitWithOpenPanel_AsSheetForWindow_InDirectory_File_Types = sel_registerName("initWithOpenPanel:asSheetForWindow:inDirectory:file:types:"u8);
        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr> NSOtkSyncModal_InitWithOpenPanel_AsSheetForWindow_InDirectory_File_TypesInst = &NSOtkSyncModal_InitWithOpenPanel_AsSheetForWindow_InDirectory_File_Types;
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        private static IntPtr NSOtkSyncModal_InitWithOpenPanel_AsSheetForWindow_InDirectory_File_Types(IntPtr syncObj, SEL selector, IntPtr panel, IntPtr window, IntPtr directory, IntPtr file, IntPtr fileTypes)
        {
            objc_super super;
            super.receiver = syncObj;
            super.pclass = (ObjCClass)objc_msgSend_IntPtr(syncObj, selSuperclass);
            objc_msgSendSuper(super, selInit);

            objc_msgSend(
                panel, 
                selBeginSheetForDirectory_File_Types_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo,
                directory,
                file,
                fileTypes,
                window,
                syncObj,
                selFilePanelDidEnd_ReturnCode,
                IntPtr.Zero);

            return syncObj;
        }

        internal static readonly SEL selInitWithSavePanel_AsSheetForWindow_InDirectory_File = sel_registerName("initWithSavePanel:asSheetForWindow:inDirectory:file:"u8);
        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr> NSOtkSyncModal_InitWithSavePanel_AsSheetForWindow_InDirectory_FileInst = &NSOtkSyncModal_InitWithSavePanel_AsSheetForWindow_InDirectory_File;
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        private static IntPtr NSOtkSyncModal_InitWithSavePanel_AsSheetForWindow_InDirectory_File(IntPtr syncObj, SEL selector, IntPtr panel, IntPtr window, IntPtr directory, IntPtr file)
        {
            objc_super super;
            super.receiver = syncObj;
            super.pclass = (ObjCClass)objc_msgSend_IntPtr(syncObj, selSuperclass);
            objc_msgSendSuper(super, selInit);

            objc_msgSend(
                panel, 
                selBeginSheetForDirectory_File_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo,
                directory,
                file,
                window,
                syncObj,
                selFilePanelDidEnd_ReturnCode,
                IntPtr.Zero);

            return syncObj;
        }

        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, long> NSOtkSyncModal_RunInst = &NSOtkSyncModal_Run;
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        private static long NSOtkSyncModal_Run(IntPtr syncObj, SEL selector, IntPtr window)
        {
            nint returnCode = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSApplicationClass, selSharedApplication), selRunModalForWindow, window);
            return returnCode;
        }

        internal static readonly SEL selAlertDidEnd_ReturnCode = sel_registerName("alertDidEnd:returnCode:"u8);
        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, nint, IntPtr, void> NSOtkSyncModal_AlertDidEnd_ReturnCodeInst = &NSOtkSyncModal_AlertDidEnd_ReturnCode;
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        private static void NSOtkSyncModal_AlertDidEnd_ReturnCode(IntPtr syncObj, SEL selector, IntPtr alert, nint returnCode, IntPtr contextInfo)
        {
            objc_msgSend(objc_msgSend_IntPtr(alert, selWindow), selOrderOut, syncObj);
            objc_msgSend(objc_msgSend_IntPtr((IntPtr)NSApplicationClass, selSharedApplication), selStopModalWithCode, returnCode);
        }

        // FIXME: This method is never called... we should remove it.
        internal static readonly SEL selFilePanelDidEnd_ReturnCode = sel_registerName("filePanelDidEnd:returnCode:"u8);
        private static unsafe readonly delegate* unmanaged[Cdecl]<IntPtr, SEL, IntPtr, nint, IntPtr, void> NSOtkSyncModal_FilePanelDidEnd_ReturnCodeInst = &NSOtkSyncModal_FilePanelDidEnd_ReturnCode;
        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        private static void NSOtkSyncModal_FilePanelDidEnd_ReturnCode(IntPtr syncObj, SEL selector, IntPtr panel, nint returnCode, IntPtr contextInfo)
        {
            objc_msgSend(objc_msgSend_IntPtr((IntPtr)NSApplicationClass, selSharedApplication), selStopModalWithCode, returnCode);
        }

        /// <inheritdoc/>
        public bool CanTargetFolders => true;

        /// <inheritdoc/>
        public MessageBoxButton ShowMessageBox(WindowHandle parent, string title, string content, MessageBoxType messageBoxType, IconHandle? customIcon = null)
        {
            NSWindowHandle nswindow = parent.As<NSWindowHandle>(this);
            NSIconHandle? icon = customIcon?.As<NSIconHandle>(this);

            IntPtr alert = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSAlert, Alloc), selInit);

            IntPtr titleNSString = ToNSString(title);
            IntPtr contentNSString = ToNSString(content);

            objc_msgSend(alert, selSetMessageText, titleNSString);
            objc_msgSend(alert, selSetInformativeText, contentNSString);
            objc_msgSend(alert, selSetIcon, icon?.Image ?? IntPtr.Zero);

            switch (messageBoxType)
            {
                case MessageBoxType.Information:
                    objc_msgSend(alert, selSetAlertStyle, (nuint)NSAlertStyle.NSAlertStyleInformational);
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("OK"u8));
                    break;
                case MessageBoxType.Warning:
                    objc_msgSend(alert, selSetAlertStyle, (nuint)NSAlertStyle.NSAlertStyleWarning);
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("OK"u8));
                    break;
                case MessageBoxType.Error:
                    objc_msgSend(alert, selSetAlertStyle, (nuint)NSAlertStyle.NSAlertStyleCritical);
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("OK"u8));
                    break;
                case MessageBoxType.Confirmation:
                    objc_msgSend(alert, selSetAlertStyle, (nuint)NSAlertStyle.NSAlertStyleInformational);
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("Yes"u8));
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("No"u8));
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("Cancel"u8));
                    break;
                case MessageBoxType.Retry:
                    // FIXME: Should we use NSAlertStyleCritical or NSAlertStyleInformational here?
                    objc_msgSend(alert, selSetAlertStyle, (nuint)NSAlertStyle.NSAlertStyleCritical);
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("Retry"u8));
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("Cancel"u8));
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(messageBoxType), (int)messageBoxType, messageBoxType.GetType());
            }

            objc_msgSend(alert, selLayout);

            IntPtr modalSync = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSOtkSyncModalClass, Alloc), selInitWithAlert_AsSheetForWindow, alert, nswindow.Window);
            NSModalResponse response = (NSModalResponse)objc_msgSend_IntPtr(modalSync, selRun, nswindow.Window);
            objc_msgSend(modalSync, Release);

            MessageBoxButton button = MessageBoxButton.None;
            switch (messageBoxType)
            {
                case MessageBoxType.Information:
                case MessageBoxType.Warning:
                case MessageBoxType.Error:
                    if (response == NSModalResponse.AlertFirstButtonReturn)
                    {
                        button = MessageBoxButton.Ok;
                    }
                    else
                    {
                        Logger?.LogDebug($"Unexpected modal response: {response}");
                    }
                    break;
                case MessageBoxType.Confirmation:
                    if (response == NSModalResponse.AlertFirstButtonReturn)
                    {
                        button = MessageBoxButton.Yes;
                    }
                    else if (response == NSModalResponse.AlertSecondButtonReturn)
                    {
                        button = MessageBoxButton.No;
                    }
                    else if (response == NSModalResponse.AlertThirdButtonReturn)
                    {
                        button = MessageBoxButton.Cancel;
                    }
                    else
                    {
                        Logger?.LogDebug($"Unexpected modal response: {response}");
                    }
                    break;
                case MessageBoxType.Retry:
                    if (response == NSModalResponse.AlertFirstButtonReturn)
                    {
                        button = MessageBoxButton.Retry;
                    }
                    else if (response == NSModalResponse.AlertSecondButtonReturn)
                    {
                        button = MessageBoxButton.Cancel;
                    }
                    else
                    {
                        Logger?.LogDebug($"Unexpected modal response: {response}");
                    }
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(messageBoxType), (int)messageBoxType, messageBoxType.GetType());
            }

            return button;
        }

        /// <summary>
        /// Shows a modal message box not attached to any specific window.
        /// </summary>
        /// <inheritdoc cref="ShowMessageBox"/>
        public MessageBoxButton ShowMessageBoxNoWindow(string title, string content, MessageBoxType messageBoxType, IconHandle? customIcon = null)
        {
            NSIconHandle? icon = customIcon?.As<NSIconHandle>(this);

            IntPtr alert = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSAlert, Alloc), selInit);

            IntPtr titleNSString = ToNSString(title);
            IntPtr contentNSString = ToNSString(content);

            objc_msgSend(alert, selSetMessageText, titleNSString);
            objc_msgSend(alert, selSetInformativeText, contentNSString);
            objc_msgSend(alert, selSetIcon, icon?.Image ?? IntPtr.Zero);

            switch (messageBoxType)
            {
                case MessageBoxType.Information:
                    objc_msgSend(alert, selSetAlertStyle, (nuint)NSAlertStyle.NSAlertStyleInformational);
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("OK"u8));
                    break;
                case MessageBoxType.Warning:
                    objc_msgSend(alert, selSetAlertStyle, (nuint)NSAlertStyle.NSAlertStyleWarning);
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("OK"u8));
                    break;
                case MessageBoxType.Error:
                    objc_msgSend(alert, selSetAlertStyle, (nuint)NSAlertStyle.NSAlertStyleCritical);
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("OK"u8));
                    break;
                case MessageBoxType.Confirmation:
                    objc_msgSend(alert, selSetAlertStyle, (nuint)NSAlertStyle.NSAlertStyleInformational);
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("Yes"u8));
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("No"u8));
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("Cancel"u8));
                    break;
                case MessageBoxType.Retry:
                    // FIXME: Should we use NSAlertStyleCritical or NSAlertStyleInformational here?
                    objc_msgSend(alert, selSetAlertStyle, (nuint)NSAlertStyle.NSAlertStyleCritical);
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("Retry"u8));
                    objc_msgSend_IntPtr(alert, selAddButtonWithTitle, ToNSString("Cancel"u8));
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(messageBoxType), (int)messageBoxType, messageBoxType.GetType());
            }

            objc_msgSend(alert, selLayout);

            NSModalResponse response = (NSModalResponse)objc_msgSend_IntPtr(alert, selRunModal);

            MessageBoxButton button = MessageBoxButton.None;
            switch (messageBoxType)
            {
                case MessageBoxType.Information:
                case MessageBoxType.Warning:
                case MessageBoxType.Error:
                    if (response == NSModalResponse.AlertFirstButtonReturn)
                    {
                        button = MessageBoxButton.Ok;
                    }
                    else
                    {
                        Logger?.LogDebug($"Unexpected modal response: {response}");
                    }
                    break;
                case MessageBoxType.Confirmation:
                    if (response == NSModalResponse.AlertFirstButtonReturn)
                    {
                        button = MessageBoxButton.Yes;
                    }
                    else if (response == NSModalResponse.AlertSecondButtonReturn)
                    {
                        button = MessageBoxButton.No;
                    }
                    else if (response == NSModalResponse.AlertThirdButtonReturn)
                    {
                        button = MessageBoxButton.Cancel;
                    }
                    else
                    {
                        Logger?.LogDebug($"Unexpected modal response: {response}");
                    }
                    break;
                case MessageBoxType.Retry:
                    if (response == NSModalResponse.AlertFirstButtonReturn)
                    {
                        button = MessageBoxButton.Retry;
                    }
                    else if (response == NSModalResponse.AlertSecondButtonReturn)
                    {
                        button = MessageBoxButton.Cancel;
                    }
                    else
                    {
                        Logger?.LogDebug($"Unexpected modal response: {response}");
                    }
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(messageBoxType), (int)messageBoxType, messageBoxType.GetType());
            }

            return button;
        }

        private IntPtr CreateAllowedContentsTypeArray(DialogFileFilter[]? allowedExtensions)
        {
            if (allowedExtensions == null)
                return 0;

            // If we have the "*" filter we don't need to create a filter...
            for (int i = 0; i < allowedExtensions.Length; i++)
            {
                if (allowedExtensions[i].Filter == "*")
                {
                    return 0;
                }
            }

            IntPtr array = objc_msgSend_IntPtr((IntPtr)NSMutableArrayClass, selArrayWithCapacity, allowedExtensions.Length);

            for (int i = 0; i < allowedExtensions?.Length; i++)
            {
                Debug.Assert(allowedExtensions[i].Filter.Contains(';') == false, "We don't support multiple extension filters in one filter on macOS atm.");
                IntPtr ext = ToNSString(allowedExtensions[i].Filter);
                IntPtr type = objc_msgSend_IntPtr((IntPtr)UTTypeClass, selTypeWithFilenameExtension, ext);
                //Console.WriteLine(FromNSString(objc_msgSend_IntPtr(type, sel_registerName("identifier"u8))));
                objc_msgSend(array, selAddObject, type);
                objc_msgSend(type, Release);
                objc_msgSend(ext, Release);
            }

            return array;
        }

        /// <inheritdoc/>
        public List<string>? ShowOpenDialog(WindowHandle parent, string title, string directory, DialogFileFilter[]? allowedExtensions, OpenDialogOptions options)
        {
            NSWindowHandle nswindow = parent.As<NSWindowHandle>(this);
            IntPtr openPanel = objc_msgSend_IntPtr((IntPtr)NSOpenPanelClass, selOpenPanel);

            IntPtr titleString = ToNSString(title);
            objc_msgSend(openPanel, selSetTitle, titleString);
            objc_msgSend(titleString, Release);

            IntPtr directoryString = ToNSString(directory);
            IntPtr directoryURL = objc_msgSend_IntPtr((IntPtr)NSURLClass, selFileURLWithPath_isDirectory, directoryString, true);
            objc_msgSend(openPanel, selSetDirectoryURL, directoryURL);
            objc_msgSend(directoryURL, Release);
            objc_msgSend(directoryString, Release);

            IntPtr allowedContentTypesArray = CreateAllowedContentsTypeArray(allowedExtensions);
            if (allowedContentTypesArray != 0)
                objc_msgSend(openPanel, selSetAllowedContentTypes, allowedContentTypesArray);

            if (options.HasFlag(OpenDialogOptions.AllowMultiSelect))
            {
                objc_msgSend(openPanel, selSetAllowMultipleSelection, true);
            }

            if (options.HasFlag(OpenDialogOptions.SelectDirectory))
            {
                objc_msgSend(openPanel, selSetCanChooseDirectories, true);
                objc_msgSend(openPanel, selSetCanChooseFiles, false);
            }

            IntPtr modalSync = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSOtkSyncModalClass, Alloc), selInitWithOpenPanel_AsSheetForWindow_InDirectory_File_Types, openPanel, nswindow.Window, ToNSString(directory), IntPtr.Zero, allowedContentTypesArray);
            NSModalResponse response = (NSModalResponse)objc_msgSend_IntPtr(modalSync, selRun, openPanel);
            objc_msgSend(modalSync, Release);
            if (response != NSModalResponse.OK)
            {
                objc_msgSend(allowedContentTypesArray, Release);
                objc_msgSend(openPanel, Release);
                return null;
            }

            IntPtr urlArray = objc_msgSend_IntPtr(openPanel, selURLs);

            nuint count = (nuint)objc_msgSend_IntPtr(urlArray, selCount);
            List<string> paths = new List<string>((int)count);
            for (nuint i = 0; i < count; i++)
            {
                IntPtr url = objc_msgSend_IntPtr(urlArray, selObjectAtIndex, i);
                // FIXME: Double check that this is a file?
                // bool isFile = objc_msgSend_bool(url, selIsFileURL);
                string str = Marshal.PtrToStringUTF8(objc_msgSend_IntPtr(url, selFileSystemRepresentation))!;
                paths.Add(str);
            }

            objc_msgSend(allowedContentTypesArray, Release);
            objc_msgSend(urlArray, Release);
            objc_msgSend(openPanel, Release);
            return paths;
        }

        /// <summary>
        /// Shows a modal "open file/folder" dialog not attached to any specific window.
        /// </summary>
        /// <inheritdoc cref="ShowOpenDialog"/>
        public List<string>? ShowOpenDialogNoWindow(string title, string directory, DialogFileFilter[]? allowedExtensions, OpenDialogOptions options)
        {
            IntPtr openPanel = objc_msgSend_IntPtr((IntPtr)NSOpenPanelClass, selOpenPanel);

            IntPtr titleString = ToNSString(title);
            objc_msgSend(openPanel, selSetTitle, titleString);
            objc_msgSend(titleString, Release);

            IntPtr directoryString = ToNSString(directory);
            IntPtr directoryURL = objc_msgSend_IntPtr((IntPtr)NSURLClass, selFileURLWithPath_isDirectory, directoryString, true);
            objc_msgSend(openPanel, selSetDirectoryURL, directoryURL);
            objc_msgSend(directoryURL, Release);
            objc_msgSend(directoryString, Release);

            IntPtr allowedContentTypesArray = CreateAllowedContentsTypeArray(allowedExtensions);
            if (allowedContentTypesArray != 0)
                objc_msgSend(openPanel, selSetAllowedContentTypes, allowedContentTypesArray);

            if (options.HasFlag(OpenDialogOptions.AllowMultiSelect))
            {
                objc_msgSend(openPanel, selSetAllowMultipleSelection, true);
            }

            if (options.HasFlag(OpenDialogOptions.SelectDirectory))
            {
                objc_msgSend(openPanel, selSetCanChooseDirectories, true);
                objc_msgSend(openPanel, selSetCanChooseFiles, false);
            }
            
            NSModalResponse response = (NSModalResponse)objc_msgSend_IntPtr(openPanel, selRunModal);
            if (response != NSModalResponse.OK)
            {
                objc_msgSend(allowedContentTypesArray, Release);
                objc_msgSend(openPanel, Release);
                return null;
            }

            IntPtr urlArray = objc_msgSend_IntPtr(openPanel, selURLs);

            nuint count = (nuint)objc_msgSend_IntPtr(urlArray, selCount);
            List<string> paths = new List<string>((int)count);
            for (nuint i = 0; i < count; i++)
            {
                IntPtr url = objc_msgSend_IntPtr(urlArray, selObjectAtIndex, i);
                // FIXME: Double check that this is a file?
                // bool isFile = objc_msgSend_bool(url, selIsFileURL);
                string str = Marshal.PtrToStringUTF8(objc_msgSend_IntPtr(url, selFileSystemRepresentation))!;
                paths.Add(str);
            }

            objc_msgSend(allowedContentTypesArray, Release);
            objc_msgSend(urlArray, Release);
            objc_msgSend(openPanel, Release);
            return paths;
        }

        /// <inheritdoc/>
        public string? ShowSaveDialog(WindowHandle parent, string title, string directory, string? defaultFileName, DialogFileFilter[]? allowedExtensions, SaveDialogOptions options)
        {
            NSWindowHandle nswindow = parent.As<NSWindowHandle>(this);

            IntPtr savePanel = objc_msgSend_IntPtr((IntPtr)NSSavePanelClass, selSavePanel);

            IntPtr titleString = ToNSString(title);
            objc_msgSend(savePanel, selSetTitle, titleString);
            objc_msgSend(titleString, Release);

            IntPtr directoryString = ToNSString(directory);
            IntPtr directoryURL = objc_msgSend_IntPtr((IntPtr)NSURLClass, selFileURLWithPath_isDirectory, directoryString, true);
            objc_msgSend(savePanel, selSetDirectoryURL, directoryURL);
            objc_msgSend(directoryURL, Release);
            objc_msgSend(directoryString, Release);

            if (defaultFileName != null)
            {
                IntPtr defaultFileNameString = ToNSString(defaultFileName);
                objc_msgSend(savePanel, selSetNameFieldStringValue, defaultFileNameString);
                objc_msgSend(defaultFileNameString, Release);
            }

            IntPtr allowedContentTypesArray = CreateAllowedContentsTypeArray(allowedExtensions);
            if (allowedContentTypesArray != 0)
                objc_msgSend(savePanel, selSetAllowedContentTypes, allowedContentTypesArray);
            objc_msgSend(savePanel, selSetAllowsOtherFileTypes, true);

            IntPtr modalSync = objc_msgSend_IntPtr(objc_msgSend_IntPtr((IntPtr)NSOtkSyncModalClass, Alloc), selInitWithSavePanel_AsSheetForWindow_InDirectory_File, savePanel, nswindow.Window, ToNSString(directory), IntPtr.Zero);
            NSModalResponse response = (NSModalResponse)objc_msgSend_IntPtr(modalSync, selRun, savePanel);
            objc_msgSend(modalSync, Release);
            if (response != NSModalResponse.OK)
            {
                objc_msgSend(savePanel, Release);
                return null;
            }

            IntPtr url = objc_msgSend_IntPtr(savePanel, selURL);
            string path = Marshal.PtrToStringUTF8(objc_msgSend_IntPtr(url, selFileSystemRepresentation))!;

            objc_msgSend(url, Release);
            objc_msgSend(savePanel, Release);
            return path;
        }

        /// <summary>
        /// Shows a modal "save file" dialog not attached to any specific window.
        /// </summary>
        /// <inheritdoc cref="ShowSaveDialog"/>
        public string? ShowSaveDialogNoWindow(string title, string directory, string? defaultFileName, DialogFileFilter[]? allowedExtensions, SaveDialogOptions options)
        {
            IntPtr savePanel = objc_msgSend_IntPtr((IntPtr)NSSavePanelClass, selSavePanel);

            IntPtr titleString = ToNSString(title);
            objc_msgSend(savePanel, selSetTitle, titleString);
            objc_msgSend(titleString, Release);

            IntPtr directoryString = ToNSString(directory);
            IntPtr directoryURL = objc_msgSend_IntPtr((IntPtr)NSURLClass, selFileURLWithPath_isDirectory, directoryString, true);
            objc_msgSend(savePanel, selSetDirectoryURL, directoryURL);
            objc_msgSend(directoryURL, Release);
            objc_msgSend(directoryString, Release);

            if (defaultFileName != null)
            {
                IntPtr defaultFileNameString = ToNSString(defaultFileName);
                objc_msgSend(savePanel, selSetNameFieldStringValue, defaultFileNameString);
                objc_msgSend(defaultFileNameString, Release);
            }

            IntPtr allowedContentTypesArray = CreateAllowedContentsTypeArray(allowedExtensions);
            if (allowedContentTypesArray != 0)
                objc_msgSend(savePanel, selSetAllowedContentTypes, allowedContentTypesArray);
            objc_msgSend(savePanel, selSetAllowsOtherFileTypes, true);

            NSModalResponse response = (NSModalResponse)objc_msgSend_IntPtr(savePanel, selRunModal);
            if (response != NSModalResponse.OK)
            {
                objc_msgSend(savePanel, Release);
                return null;
            }

            IntPtr url = objc_msgSend_IntPtr(savePanel, selURL);
            string path = Marshal.PtrToStringUTF8(objc_msgSend_IntPtr(url, selFileSystemRepresentation))!;

            objc_msgSend(url, Release);
            objc_msgSend(savePanel, Release);
            return path;
        }
    }
}


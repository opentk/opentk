using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using static OpenTK.Platform.Native.macOS.ObjC;

namespace OpenTK.Platform.Native.macOS
{
    public class MacOSDialogComponent : IDialogComponent
    {
        internal static readonly ObjCClass NSOpenPanelClass = objc_getClass("NSOpenPanel"u8);
        internal static readonly ObjCClass NSSavePanelClass = objc_getClass("NSSavePanel"u8);
        internal static readonly ObjCClass NSURLClass = objc_getClass("NSURL"u8);
        internal static readonly ObjCClass UTTypeClass = objc_getClass("UTType"u8);
        internal static readonly ObjCClass NSMutableArrayClass = objc_getClass("NSMutableArray"u8);

        internal static readonly SEL selOpenPanel = sel_registerName("openPanel"u8);
        internal static readonly SEL selSavePanel = sel_registerName("savePanel"u8);
        internal static readonly SEL selRunModal = sel_registerName("runModal"u8);

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

        internal static readonly SEL selCanCreateDirectories = sel_registerName("canCreateDirectories"u8);
        internal static readonly SEL selSetCanCreateDirectories = sel_registerName("setCanCreateDirectories:"u8);

        internal static readonly SEL selAllowedContentTypes = sel_registerName("allowedContentTypes"u8);
        internal static readonly SEL selSetAllowedContentTypes = sel_registerName("setAllowedContentTypes:"u8);
        internal static readonly SEL selAllowsOtherFileTypes = sel_registerName("allowsOtherFileTypes"u8);
        internal static readonly SEL selSetAllowsOtherFileTypes = sel_registerName("setAllowsOtherFileTypes:"u8);
        


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


        /// <inheritdoc/>
        public string Name => nameof(MacOSDialogComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Dialog;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Dialog)
            {
                throw new Exception("MacOSDialogComponent can only initialize the Dialog component.");
            }
        }

        /// <inheritdoc/>
        public bool CanTargetFolders => true;

        private IntPtr CreateAllowedContentsTypeArray(DialogFileFilter[]? allowedExtensions)
        {
            // If we have the "*" filter we don't need to create a filter...
            for (int i = 0; i < allowedExtensions?.Length; i++)
            {
                if (allowedExtensions[i].Filter == "*")
                {
                    return 0;
                }
            }

            IntPtr array = objc_msgSend_IntPtr((IntPtr)NSMutableArrayClass, selArrayWithCapacity, allowedExtensions?.Length ?? 0);

            for (int i = 0; i < allowedExtensions?.Length; i++)
            {
                IntPtr ext = ToNSString(allowedExtensions[i].Filter);
                IntPtr type = objc_msgSend_IntPtr((IntPtr)UTTypeClass, selTypeWithFilenameExtension, ext);
                Console.WriteLine(FromNSString(objc_msgSend_IntPtr(type, sel_registerName("identifier"u8))));
                objc_msgSend(array, selAddObject, type);
                objc_msgSend(type, Release);
                objc_msgSend(ext, Release);
            }

            return array;
        }

        /// <inheritdoc/>
        public List<string>? ShowOpenDialog(WindowHandle parent, string title, string directory, DialogFileFilter[]? allowedExtensions, OpenDialogOptions options)
        {
            IntPtr openPanel = objc_msgSend_IntPtr((IntPtr)NSOpenPanelClass, selOpenPanel);

            // FIXME: Memory leak?
            objc_msgSend(openPanel, selSetTitle, ToNSString(title));

            IntPtr directoryString = ToNSString(directory);
            IntPtr directoryURL = objc_msgSend_IntPtr((IntPtr)NSURLClass, selFileURLWithPath_isDirectory, directoryString, true);
            objc_msgSend(openPanel, selSetDirectoryURL, directoryURL);
            objc_msgSend(directoryURL, Release);
            objc_msgSend(directoryString, Release);

            IntPtr allowedContentTypesArray = CreateAllowedContentsTypeArray(allowedExtensions);
            if (allowedContentTypesArray != 0)
                objc_msgSend(openPanel, selSetAllowedContentTypes, allowedContentTypesArray);

            objc_msgSend(openPanel, selSetCanCreateDirectories, true);

            if (options.HasFlag(OpenDialogOptions.AllowMultiSelect))
            {
                objc_msgSend(openPanel, selSetAllowMultipleSelection, true);
            }

            if (options.HasFlag(OpenDialogOptions.SelectDirectory))
            {
                objc_msgSend(openPanel, selSetCanChooseDirectories, true);
                objc_msgSend(openPanel, selSetCanChooseFiles, false);
            }

            // FIXME: Run this with beginSheetModalForWindow:completionHandler: ?
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
        public string? ShowSaveDialog(WindowHandle parent, string title, string directory, DialogFileFilter[]? allowedExtensions, SaveDialogOptions options)
        {
            IntPtr savePanel = objc_msgSend_IntPtr((IntPtr)NSSavePanelClass, selSavePanel);

            // FIXME: Memory leak?
            objc_msgSend(savePanel, selSetTitle, ToNSString(title));

            IntPtr directoryString = ToNSString(directory);
            IntPtr directoryURL = objc_msgSend_IntPtr((IntPtr)NSURLClass, selFileURLWithPath_isDirectory, directoryString, true);
            objc_msgSend(savePanel, selSetDirectoryURL, directoryURL);
            objc_msgSend(directoryURL, Release);
            objc_msgSend(directoryString, Release);

            IntPtr allowedContentTypesArray = CreateAllowedContentsTypeArray(allowedExtensions);
            if (allowedContentTypesArray != 0)
                objc_msgSend(savePanel, selSetAllowedContentTypes, allowedContentTypesArray);
            objc_msgSend(savePanel, selSetAllowsOtherFileTypes, true);

            objc_msgSend(savePanel, selSetCanCreateDirectories, true);

            // FIXME: Run with beginSheetModalForWindow:completionHandler: ?
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


using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Platform;
using OpenTK.Core.Utility;
using static OpenTK.Platform.Native.X11.LibX11;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
using System.ComponentModel;

namespace OpenTK.Platform.Native.X11
{
    public class X11ClipboardComponent : IClipboardComponent
    {
        /// <inheritdoc/>
        public string Name => nameof(X11ClipboardComponent);

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Clipboard;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            OpenTKSelection = XInternAtom(X11.Display, "OpenTK_Selection", false);

            image_png = XInternAtom(X11.Display, "image/png", false);
            image_bmp = XInternAtom(X11.Display, "image/bmp", false);

            text_urilist = XInternAtom(X11.Display, "text/uri-list", false);

            text_utf8 = XInternAtom(X11.Display, "text/plain;charset=utf-8", false);

            // Maybe we will need to use DE specific formats?
            //xspecial_gnomecopiedfiles = XInternAtom(X11.Display, "x-special/gnome-copied-files", false);
        }

        /// <summary>
        /// Custom atom used to receive clipboard data.
        /// </summary>
        internal static XAtom OpenTKSelection;

        // FIXME: Figure out which image formats we support?
        private static XAtom image_png;
        private static XAtom image_bmp;

        private static XAtom text_urilist;
        private static XAtom text_utf8;

        private static readonly ClipboardFormat[] _supportedFormats = { ClipboardFormat.Text, ClipboardFormat.Files };
        private static readonly ClipboardFormat[] _supportedFormatsWithBitmap = { ClipboardFormat.Text, ClipboardFormat.Bitmap, ClipboardFormat.Files };

        /// <inheritdoc/>
        public IReadOnlyList<ClipboardFormat> SupportedFormats => (PngCodec != null && PngCodec.CanDecodePng) ?  _supportedFormatsWithBitmap : _supportedFormats;

        private IPngCodec? PngCodec;

        /// <summary>The currently set clipboard string, or null if no clipboard string is set.</summary>
        // FIXME: Some way to discern what type of clipboard data we have...
        private static ClipboardFormat CurrentClipboardFormat = ClipboardFormat.None;
        private static string? ClipboardString;
        private static byte[]? ClipboardPng;

        private unsafe byte[] ReadINCRData(XEvent notification)
        {
            byte[] dataBytes = Array.Empty<byte>();

            while (true)
            {
                // FIXME: Do we want to use something like WaitForSelectionNotify here?
                while (XCheckIfEvent(X11.Display, out _, X11.IsSelectionPropertyNewValueNotify, new IntPtr(&notification)) == false)
                {
                    // FIXME: Wait for events!
                    X11.WaitForXEvents();
                }

                XGetWindowProperty(
                    X11.Display,
                    notification.Selection.requestor,
                    notification.Selection.property,
                    0, long.MaxValue, true,
                    // FIXME: AnyPropertyType
                    new XAtom(0),
                    out XAtom actualType,
                    out int actualFormat,
                    out long numberOfItems,
                    out _,
                    out IntPtr data);

                if (numberOfItems != 0)
                {
                    // There is still more data incomming.
                    int sizeSoFar = dataBytes.Length;
                    Array.Resize(ref dataBytes, sizeSoFar + (int)numberOfItems);
                    Marshal.Copy(data, dataBytes, sizeSoFar, (int)numberOfItems);
                    XFree(data);
                }
                else
                {
                    // This was the last data.
                    XFree(data);
                    return dataBytes;
                }
            }
        }

        private static unsafe bool TryWaitForSelectionNotify(ILogger? logger, out XEvent notification)
        {
            Stopwatch watch = Stopwatch.StartNew();
            while (XCheckTypedWindowEvent(X11.Display, X11WindowComponent.HelperWindow, XEventType.SelectionNotify, out notification) == false)
            {
                X11.WaitForXEvents();

                if (watch.ElapsedMilliseconds >= 1000) {
                    // We timed out.
                    logger?.LogWarning("We never got a SelectionNotify after waiting for 1 second.");
                    return false;
                }

                // We still want to respond to SelectionRequest events when we are waiting for a
                // SelectionNotify event, in case we are the selection owner...
                if (XCheckIfEvent(X11.Display, out XEvent @event, IsClipboardEvent, IntPtr.Zero)) {
                    HandleClipboardEvent(ref @event, logger);
                }

                static bool IsClipboardEvent(XDisplayPtr display, ref XEvent @event, IntPtr arg)
                {
                    return
                        @event.Type == XEventType.SelectionClear ||
                        @event.Type == XEventType.SelectionRequest;
                }
            }

            bool found;
            fixed (XEvent* ptr = &notification) {
                found = XCheckIfEvent(X11.Display, out _, X11.IsSelectionPropertyNewValueNotify, new IntPtr(ptr));
            }

            if (found == false) {
                logger?.LogWarning("We got a SelectionNotify event but it wasn't PropertyNewValue...");
            }

            return found;
        }

        // FIXME: What if we've not initialized the clipboard component
        internal static unsafe ClipboardFormat GetSelectionFormat(XAtom selection, XAtom property, ILogger? logger)
        {
            XConvertSelection(
                    X11.Display,
                    selection,
                    X11.Atoms[KnownAtoms.TARGETS],
                    property,
                    X11WindowComponent.HelperWindow,
                    XTime.CurrentTime);

            if (TryWaitForSelectionNotify(logger, out XEvent notification) == false)
            {
                return ClipboardFormat.None;
            }

            int result = XGetWindowProperty(
                X11.Display,
                notification.Selection.requestor,
                notification.Selection.property,
                0, long.MaxValue, true,
                // FIXME: AnyPropertyType
                new XAtom(0),
                out XAtom actualType,
                out int actualFormat,
                out long numberOfItems,
                out long remainingBytes,
                out IntPtr data);

            if (result != Success) {
                logger?.LogWarning($"Could not get the selection property data from the SelectionNotify event when reading clipboard format. (selection: {selection}, property: {property})");
                if (data != IntPtr.Zero) 
                {
                    XFree(data);
                }
                return ClipboardFormat.None;
            }

            if (actualType == X11.Atoms[KnownAtoms.INCR])
            {
                XFree(data);
                throw new NotImplementedException("We don't support INCR here yet.");
            }
            else
            {
                // Loop through the list of atoms and find the first
                // format we can use
                Span<XAtom> atoms = new Span<XAtom>((XAtom*)data, (int)numberOfItems);

                //for (int i = 0; i < atoms.Length; i++)
                //{
                //    logger?.LogDebug($"{i}: {atoms[i]}");
                //}

                // Search for file lists first as these can also be reported as STRING.
                for (int i = 0; i < atoms.Length; i++)
                {
                    if (atoms[i] == text_urilist)
                    {
                        XFree(data);
                        return ClipboardFormat.Files;
                    }
                }

                for (int i = 0; i < atoms.Length; i++)
                {
                    XAtom atom = atoms[i];
                    if (atom == X11.Atoms[KnownAtoms.UTF8_STRING] ||
                        atom == X11.Atoms[KnownAtoms.STRING])
                    {
                        XFree(data);
                        return ClipboardFormat.Text;
                    }
                    else if (atom == image_png || 
                            atom == image_bmp)
                    {
                        XFree(data);
                        return ClipboardFormat.Bitmap;
                    }
                    //else if (atom = audioau)?
                    //{
                    //    return ClipboardFormat.Audio
                    //}
                }

                XFree(data);
                return ClipboardFormat.None;
            }
        }

        internal static unsafe void HandleClipboardEvent(ref XEvent xevent, ILogger? logger)
        {
            switch (xevent.Type)
            {
                case XEventType.SelectionRequest:
                    ref XSelectionRequestEvent request = ref xevent.SelectionRequest;
                    logger?.LogDebug($"SelectionRequest target Requestor: {request.requestor}, Owner: {request.owner}, Target:{request.target}, Property: {request.property}, Selection: {request.selection}");

                    XEvent sendEvent = new XEvent();
                    sendEvent.Type = XEventType.SelectionNotify;
                    ref XSelectionEvent selectionNotify = ref sendEvent.Selection;
                    selectionNotify.display = X11.Display;
                    selectionNotify.requestor = request.requestor;
                    selectionNotify.selection = request.selection;
                    selectionNotify.target = X11.Atoms[KnownAtoms.TARGETS];
                    selectionNotify.property = XAtom.None;
                    selectionNotify.time = request.time;

                    if (request.target == X11.Atoms[KnownAtoms.TARGETS])
                    {
                        // Report supported targets.
                        Span<XAtom> supportedFormats = stackalloc XAtom[]{ X11.Atoms[KnownAtoms.TARGETS] };
                        switch (CurrentClipboardFormat)
                        {
                            case ClipboardFormat.Text:
                                supportedFormats = stackalloc XAtom[]{ X11.Atoms[KnownAtoms.TARGETS], X11.Atoms[KnownAtoms.UTF8_STRING], X11.Atoms[KnownAtoms.STRING] };
                                break;
                            case ClipboardFormat.Bitmap:
                                supportedFormats = stackalloc XAtom[]{ X11.Atoms[KnownAtoms.TARGETS], image_png };
                                break;
                            case ClipboardFormat.None:
                            case ClipboardFormat.Audio:
                            case ClipboardFormat.Files:
                                // We don't support these atm. Report only TARGETS as valid target.
                                break;
                            default:
                                throw new UnreachableException($"Unknown ClipboardFormat {CurrentClipboardFormat}");
                        }

                        fixed (XAtom* ptr = supportedFormats)
                        {
                            XChangeProperty(X11.Display, request.requestor, request.property, X11.Atoms[KnownAtoms.ATOM], 32, XPropertyMode.Replace, (IntPtr)ptr, supportedFormats.Length);
                        }
                        
                        selectionNotify.target = X11.Atoms[KnownAtoms.TARGETS];
                        selectionNotify.property = request.property;
                    }
                    else
                    {
                        switch (CurrentClipboardFormat)
                        {
                            case ClipboardFormat.Text:
                                {
                                    if (ClipboardString != null)
                                    {
                                        if (request.target == X11.Atoms[KnownAtoms.UTF8_STRING] || request.target == text_utf8)
                                        {
                                            logger?.LogDebug($"Sending clipboard format: {request.target}");
                                            byte[] data = Encoding.UTF8.GetBytes(ClipboardString!);
                                            int result = XChangeProperty(X11.Display, request.requestor, request.property, request.target, 8, XPropertyMode.Replace, data, data.Length);

                                            selectionNotify.property = request.property;
                                        }
                                        else if (request.target == X11.Atoms[KnownAtoms.STRING])
                                        {
                                            logger?.LogDebug($"Sending clipboard format: {request.target}");
                                            
                                            // FIXME: STRING specifies ISO Latin-1 with tabs and newlines...
                                            byte[] data = Encoding.Latin1.GetBytes(ClipboardString);
                                            
                                            Debug.Assert(data.Length < 262140, "The png is larger than the max supported reques size. We need to implement the INCR protocol.");

                                            int result = XChangeProperty(X11.Display, request.requestor, request.property, request.target, 8, XPropertyMode.Replace, data, data.Length);

                                            selectionNotify.property = request.property;
                                        }
                                        else
                                        {
                                            logger?.LogDebug($"SelectionRequest: Trying to request unsupported target: {request.target}");

                                            // We don't support this target.
                                            selectionNotify.property = XAtom.None;
                                        }
                                    }
                                    else
                                    {
                                        logger?.LogWarning($"CurrentClipboardFormat ({CurrentClipboardFormat}) indicated ClipboardString would be set but it was null.");

                                        // We don't support this target.
                                        selectionNotify.property = XAtom.None;
                                    }
                                    break;
                                }
                            case ClipboardFormat.Bitmap:
                                {
                                    if (ClipboardPng != null)
                                    {
                                        if (request.target == image_png)
                                        {
                                            logger?.LogDebug($"Sending clipboard format: {request.target}");
                                            
                                            byte[] data = ClipboardPng;

                                            Debug.Assert(data.Length < 262140, "The png is larger than the max supported reques size. We need to implement the INCR protocol.");

                                            int result = XChangeProperty(X11.Display, request.requestor, request.property, request.target, 8, XPropertyMode.Replace, data, data.Length);

                                            selectionNotify.property = request.property;
                                        }
                                        else
                                        {
                                            logger?.LogDebug($"SelectionRequest: Trying to request unsupported target: {request.target}");

                                            // We don't support this target.
                                            selectionNotify.property = XAtom.None;
                                        }
                                    }
                                    else
                                    {
                                        logger?.LogWarning($"CurrentClipboardFormat ({CurrentClipboardFormat}) indicated ClipboardPng would be set but it was null.");

                                        // We don't support this target.
                                        selectionNotify.property = XAtom.None;
                                    }
                                    break;
                                }
                            case ClipboardFormat.None:
                            case ClipboardFormat.Audio:
                            case ClipboardFormat.Files:
                                {
                                    // We don't support this target.
                                    selectionNotify.property = XAtom.None;
                                    break;
                                }
                            default:
                                throw new UnreachableException($"Unknown ClipboardFormat {CurrentClipboardFormat}");
                        }
                    }

                    XSendEvent(X11.Display, request.requestor, True, 0, in sendEvent);
                    // FIXME: Do we need this?
                    XSync(X11.Display, False);
                    break;
                case XEventType.SelectionNotify:
                    logger?.LogDebug($"Selection notify!");
                    // Do we want to implement this?
                    break;
                case XEventType.SelectionClear:
                    logger?.LogDebug($"Selection clear!");
                    ClipboardString = null;
                    // Clear all stored clipboard data.
                    break;
                default:
                    logger?.LogWarning($"Unknown clipboard event: {xevent.Type}.");
                    break;
            }
        }

        /// <inheritdoc/>
        public unsafe ClipboardFormat GetClipboardFormat()
        {
            return GetSelectionFormat(X11.Atoms[KnownAtoms.CLIPBOARD], OpenTKSelection, Logger);
        }

        /// <inheritdoc/>
        public void SetClipboardText(string text)
        {
            ClipboardString = text;
            CurrentClipboardFormat = ClipboardFormat.Text;
            XSetSelectionOwner(X11.Display, X11.Atoms[KnownAtoms.CLIPBOARD], X11WindowComponent.HelperWindow, XTime.CurrentTime);
        }

        /// <inheritdoc/>
        public unsafe string? GetClipboardText()
        {
            // First try to convert to UTF8 string, otherwise use XA_STRING.

            Span<XAtom> formats = stackalloc XAtom[2] { X11.Atoms[KnownAtoms.UTF8_STRING], X11.Atoms[KnownAtoms.STRING] };

            for (int i = 0; i < formats.Length; i++)
            {
                XConvertSelection(
                    X11.Display,
                    X11.Atoms[KnownAtoms.CLIPBOARD],
                    formats[i],
                    OpenTKSelection,
                    X11WindowComponent.HelperWindow,
                    XTime.CurrentTime);

                if (TryWaitForSelectionNotify(Logger, out XEvent notification) == false)
                {
                    continue;
                }

                int result = XGetWindowProperty(
                    X11.Display,
                    notification.Selection.requestor,
                    notification.Selection.property,
                    0, long.MaxValue, true,
                    // FIXME: AnyPropertyType
                    new XAtom(0),
                    out XAtom actualType,
                    out int actualFormat,
                    out long numberOfItems,
                    out long remainingBytes,
                    out IntPtr data);

                if (result != Success)
                {
                    Logger?.LogWarning($"Could not get the selection property data from the SelectionNotify event. (property: {notification.Selection.property})");
                    if (data != IntPtr.Zero)
                    {
                        XFree(data);
                    }
                    return null;
                }

                if (actualType == X11.Atoms[KnownAtoms.INCR])
                {
                    XFree(data);

                    // We've deleted the INCR property signaling the owner to start transferring data
                    byte[] stringBytes = ReadINCRData(notification);
                    string str;
                    if (formats[i] == X11.Atoms[KnownAtoms.UTF8_STRING])
                    {
                        str = Encoding.UTF8.GetString(stringBytes);
                    }
                    else
                    {
                        str = Encoding.Latin1.GetString(stringBytes);
                    }
                    return str;
                }
                else if (actualType == formats[i])
                {
                    // We got the thing!
                    string str;
                    if (formats[i] == X11.Atoms[KnownAtoms.UTF8_STRING])
                    {
                        str = Marshal.PtrToStringUTF8(data)!;
                    }
                    else
                    {
                        // FIXME: Is this the correct way of getting the length of the data?
                        str = Encoding.Latin1.GetString((byte*)data, (actualFormat / 8) * (int)numberOfItems);
                    }
                    XFree(data);
                    return str;
                }
                else
                {
                    XFree(data);
                }
            }

            return null;
        }

        /// <inheritdoc/>
        public AudioData? GetClipboardAudio()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Writes a bitmap to the clipboard.
        /// </summary>
        /// <remarks>
        /// On linux clipboard bitmaps are defacto transferred as PNG data, as such a PNG encoder/decoder is needed to read and write bitmaps from the clipboard.
        /// To enable this <see cref="SetPngCodec(IPngCodec?)"/> must be called with an object that implements the <see cref="IPngCodec"/> interface.
        /// </remarks>
        /// <param name="bitmap">The bitmap to write to the clipboard.</param>
        /// <seealso cref="SetPngCodec(IPngCodec?)"/>
        public void SetClipboardBitmap(Bitmap bitmap)
        {
            if (PngCodec == null)
            {
                Logger?.LogWarning("Unable to set clipboard bitmap. On linux clipboard images use png, and no png encoder has been set using SetPngCodec(IPngCodec).");
                return;
            }

            if (PngCodec.CanEncodePng == false)
            {
                Logger?.LogWarning($"The provided png codec ({PngCodec}) does not support encoding png images. This is necessary to obtain clipboard bitmaps on linux.");
                return;
            }

            ClipboardPng = PngCodec.EncodePng(bitmap, Logger);
            if (ClipboardPng == null) 
            {
                Logger?.LogWarning("Could not encode png. We will not take ownership of the clipboard selection.");
                return;
            }

            CurrentClipboardFormat = ClipboardFormat.Bitmap;
            XSetSelectionOwner(X11.Display, X11.Atoms[KnownAtoms.CLIPBOARD], X11WindowComponent.HelperWindow, XTime.CurrentTime);
        }

        /// <inheritdoc/>
        /// <remarks>
        /// On linux clipboard bitmaps are defacto transferred as PNG data, as such a PNG encoder/decoder is needed to read and write bitmaps from the clipboard.
        /// To enable this <see cref="SetPngCodec(IPngCodec?)"/> must be called with an object that implements the <see cref="IPngCodec"/> interface.
        /// </remarks>
        /// <seealso cref="SetPngCodec(IPngCodec?)"/>
        public unsafe Bitmap? GetClipboardBitmap()
        {
            if (PngCodec == null)
            {
                Logger?.LogWarning("Unable to get clipboard bitmap. On linux clipboard images use png, and no png decoder has been set using SetPngCodec(IPngCodec).");
                return null;
            }

            if (PngCodec.CanDecodePng == false)
            {
                Logger?.LogWarning($"The provided png codec ({PngCodec}) does not support decoding png images. This is necessary to obtain clipboard bitmaps on linux.");
                return null;
            }

            // FIXME: We need to decode a png here, and there is no good way to do this really...
            Span<XAtom> formats = stackalloc XAtom[1] { image_png };

            for (int i = 0; i < formats.Length; i++)
            {
                XConvertSelection(
                    X11.Display,
                    X11.Atoms[KnownAtoms.CLIPBOARD],
                    formats[i],
                    OpenTKSelection,
                    X11WindowComponent.HelperWindow,
                    XTime.CurrentTime);

                if (TryWaitForSelectionNotify(Logger, out XEvent notification) == false)
                {
                    continue;
                }

                int result = XGetWindowProperty(
                    X11.Display,
                    notification.Selection.requestor,
                    notification.Selection.property,
                    0, long.MaxValue, true,
                    // FIXME: AnyPropertyType
                    new XAtom(0),
                    out XAtom actualType,
                    out int actualFormat,
                    out long numberOfItems,
                    out long remainingBytes,
                    out IntPtr data);

                if (result != Success)
                {
                    Logger?.LogWarning($"Could not get the selection property data from the SelectionNotify event. (property: {notification.Selection.property})");
                    if (data != IntPtr.Zero)
                    {
                        XFree(data);
                    }
                    return null;
                }

                Span<byte> imageBytes;
                if (actualType == X11.Atoms[KnownAtoms.INCR])
                {
                    XFree(data);

                    // We've deleted the INCR property signaling the owner to start transferring data
                    imageBytes = ReadINCRData(notification);

                    Bitmap? bitmap = PngCodec.DecodePng(imageBytes, Logger);

                    return bitmap;
                }
                else if (actualType == formats[i])
                {
                    imageBytes = new Span<byte>((byte*)data, (actualFormat / 8) * (int)numberOfItems);

                    Bitmap? bitmap = PngCodec.DecodePng(imageBytes, Logger);
                    
                    return bitmap;
                }
                
                if (data != IntPtr.Zero)
                {
                    XFree(data);
                }
            }

            return null;
        }

        /// <inheritdoc/>
        public unsafe List<string>? GetClipboardFiles()
        {
            XConvertSelection(
                    X11.Display,
                    X11.Atoms[KnownAtoms.CLIPBOARD],
                    text_urilist,
                    OpenTKSelection,
                    X11WindowComponent.HelperWindow,
                    XTime.CurrentTime);

            if (TryWaitForSelectionNotify(Logger, out XEvent notification) == false)
            {
                return null;
            }

            int result = XGetWindowProperty(
                X11.Display,
                notification.Selection.requestor,
                notification.Selection.property,
                0, long.MaxValue, true,
                // FIXME: AnyPropertyType
                new XAtom(0),
                out XAtom actualType,
                out int actualFormat,
                out long numberOfItems,
                out long remainingBytes,
                out IntPtr data);

            if (result != Success)
            {
                Logger?.LogWarning($"Could not get the selection property data from the SelectionNotify event. (property: {notification.Selection.property})");
                if (data != IntPtr.Zero)
                {
                    XFree(data);
                }
                return null;
            }

            if (actualType == X11.Atoms[KnownAtoms.INCR])
            {
                XFree(data);
                throw new NotImplementedException("We don't support INCR here yet.");
            }
            else
            {
                string fullString = Marshal.PtrToStringUTF8(data)!;

                List<string> files = new List<string>();
                string[] lines = fullString.Split('\n', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("#")) continue;
                    else if (lines[i].StartsWith("file://"))
                        files.Add(lines[i]["file://".Length..]);
                    else Logger?.LogDebug($"Got unknown file uri: {lines[i]}");
                }

                XFree(data);
                return files;
            }
        }

        // FIXME: Platform specific API for getting and setting the current selection string?

        /// <summary>
        /// Png encoding/decoding interface for handling clipboard images.
        /// </summary>
        /// <see cref="SetPngCodec(IPngCodec?)"/>
        public interface IPngCodec
        {
            /// <summary>
            /// If this <see cref="IPngCodec"/> instance can decode png images.
            /// </summary>
            /// <seealso cref="DecodePng(Span{byte}, ILogger?)"/>
            public bool CanDecodePng { get; }

            /// <summary>
            /// If this <see cref="IPngCodec"/> instance can encode png images.
            /// </summary>
            /// <seealso cref="EncodePng(Bitmap, ILogger?)"/>
            public bool CanEncodePng { get; }

            /// <summary>
            /// Function that decodes png image bytes into a <see cref="Bitmap"/>.
            /// </summary>
            /// <param name="imageData">The png image bytes. This is untrusted data.</param>
            /// <param name="logger">A logger that can be used to write diagnostic messages.</param>
            /// <returns>The decoded png or null if some error occured</returns>
            /// <seealso cref="CanDecodePng"/>
            public Bitmap? DecodePng(Span<byte> imageData, ILogger? logger);

            /// <summary>
            /// Function that encodes a <see cref="Bitmap"/> into an array of bytes.
            /// </summary>
            /// <param name="image">The <see cref="Bitmap"/> instance to encode.</param>
            /// <param name="logger">A logger that can be used to write diagnostic messages.</param>
            /// <returns>The encoded png bytes or null if an error occured.</returns>
            /// <seealso cref="CanEncodePng"/>
            public byte[]? EncodePng(Bitmap image, ILogger? logger);
        }
    
        /// <summary>
        /// Allows the clipboard component to decode and encode png images using the specified <see cref="IPngCodec"/> instance.
        /// </summary>
        /// <param name="codec">The <see cref="IPngCodec"/> to use for image encoding.</param>
        /// <seealso cref="IPngCodec"/>
        /// <seealso cref="GetClipboardBitmap"/>
        /// <seealso cref="SetClipboardBitmap(Bitmap)"/>
        public void SetPngCodec(IPngCodec? codec)
        {
            PngCodec = codec;
        }
    }
}

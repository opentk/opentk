using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using OpenTK.Core;
using OpenTK.Core.Platform;
using OpenTK.Core.Platform.Enums;
using OpenTK.Core.Platform.Interfaces;
using static OpenTK.Platform.Native.X11.LibX11;

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
        public void Initialize(PalComponents which)
        {
            if ((which & ~Provides) != 0)
            {
                throw new PalException(this, $"Cannot initialize unimplemented components {which & ~Provides}.");
            }


            OpenTKSelection = XInternAtom(X11.Display, "OpenTK_Selection", false);

            image_png = XInternAtom(X11.Display, "image/png", false);
            image_bmp = XInternAtom(X11.Display, "image/bmp", false);

            text_urilist = XInternAtom(X11.Display, "text/uri-list", false);

            // Maybe we will need to use DE specific formats?
            //xspecial_gnomecopiedfiles = XInternAtom(X11.Display, "x-special/gnome-copied-files", false);
        }

        /// <summary>
        /// Custom atom used to receive clipboard data.
        /// </summary>
        private XAtom OpenTKSelection;

        // FIXME: Figure out which image formats we support?
        private XAtom image_png;
        private XAtom image_bmp;

        private XAtom text_urilist;

        private struct pollfd {
            public int fd;
            public short events;
            public short revents;
        }

        [DllImport("libc", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
        private static unsafe extern int poll(pollfd* fds, uint nfds, int timeout);

        private static unsafe bool Poll(pollfd* fds, int count, int timeout)
        {
            while (true)
            {
                int result = poll(fds, (uint)count, timeout);
                int errno = Marshal.GetLastSystemError();

                const int EINTR = 4;
                const int EAGAIN = 11;

                if (result > 0)
                {
                    return true;
                }
                else if (result < 0 && errno != EINTR && errno != EAGAIN)
                {
                    return false;
                }
                else // (result == 0)
                {
                    return false;
                }
            }
        }

        private static unsafe bool WaitForXEvents()
        {
            const short POLLIN = 0x0001;

            pollfd fd = new pollfd(){
                fd = XConnectionNumber(X11.Display),
                events = POLLIN,
            };

            while (XPending(X11.Display) == 0)
            {
                // poll with no timeout.
                if (Poll(&fd, 1, -1) == false)
                    return false;
            }

            return true;
        }

        private static unsafe bool IsSelectionPropertyNewValueNotify(XDisplayPtr display, ref XEvent @event, IntPtr pointer)
        {
            XEvent* notification = (XEvent*)pointer;
            return @event.Type == XEventType.PropertyNotify &&
                @event.Property.state == PropertyState.PropertyNewValue &&
                @event.Property.window == notification->Selection.requestor &&
                @event.Property.atom == notification->Selection.property;
        }

        private unsafe byte[] ReadINCRData(XEvent notification)
        {
            byte[] dataBytes = Array.Empty<byte>();

            while (true)
            {
                while (XCheckIfEvent(X11.Display, out _, IsSelectionPropertyNewValueNotify, new IntPtr(&notification)) == false)
                {
                    // FIXME: Wait for events!
                    WaitForXEvents();
                }

                XGetWindowProperty(X11.Display,
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

        /// <inheritdoc/>
        public IReadOnlyList<ClipboardFormat> SupportedFormats => throw new NotImplementedException();

        /// <inheritdoc/>
        public unsafe ClipboardFormat GetClipboardFormat()
        {
            XConvertSelection(
                    X11.Display,
                    X11.Atoms[KnownAtoms.CLIPBOARD],
                    X11.Atoms[KnownAtoms.TARGETS],
                    OpenTKSelection,
                    X11WindowComponent.HelperWindow,
                    XTime.CurrentTime);

            XEvent notification;
            while (XCheckTypedWindowEvent(X11.Display, X11WindowComponent.HelperWindow, XEventType.SelectionNotify, out notification) == false)
            {
                WaitForXEvents();
            }

            // Find the event and remove it from the queue
            XCheckIfEvent(X11.Display, out _, IsSelectionPropertyNewValueNotify, new IntPtr(&notification));

            XGetWindowProperty(X11.Display,
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

            if (actualType == X11.Atoms[KnownAtoms.INCR])
            {
                throw new NotImplementedException("We don't support INCR here yet.");
            }
            else
            {
                // Loop through the list of atoms and find the first
                // format we can use
                Span<XAtom> atoms = new Span<XAtom>((XAtom*)data, (int)numberOfItems);

                // Search for file lists first as these can also be reported as STRING.
                for (int i = 0; i < atoms.Length; i++)
                {
                    if (atoms[i] == text_urilist)
                    {
                        return ClipboardFormat.Files;
                    }
                }

                for (int i = 0; i < atoms.Length; i++)
                {
                    XAtom atom = atoms[i];
                    if (atom == X11.Atoms[KnownAtoms.UTF8_STRING] ||
                        atom == X11.Atoms[KnownAtoms.STRING])
                    {
                        return ClipboardFormat.Text;
                    }
                    else if (atom == image_png ||
                             atom == image_bmp)
                    {
                        return ClipboardFormat.Bitmap;
                    }
                    //else if (atom = audioau)?
                    //{
                    //    return ClipboardFormat.Audio
                    //}
                }

                return ClipboardFormat.None;
            }
        }

        /// <inheritdoc/>
        public void SetClipboardText(string text)
        {
            throw new NotImplementedException();
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

                XEvent notification;
                while (XCheckTypedWindowEvent(X11.Display, X11WindowComponent.HelperWindow, XEventType.SelectionNotify, out notification) == false)
                {
                    WaitForXEvents();
                }

                // Find the event and remove it from the queue
                XCheckIfEvent(X11.Display, out _, IsSelectionPropertyNewValueNotify, new IntPtr(&notification));

                XGetWindowProperty(X11.Display,
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

        /// <inheritdoc/>
        public Bitmap? GetClipboardBitmap()
        {
            // FIXME: We need to decode a png here, and there is no good way to do this really...
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        // FIXME: Remove this if favor of platform specific APIs for getting arbitrary formats.
        public string? GetClipboardHTML()
        {
            throw new NotImplementedException();
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

            XEvent notification;
            while (XCheckTypedWindowEvent(X11.Display, X11WindowComponent.HelperWindow, XEventType.SelectionNotify, out notification) == false)
            {
                WaitForXEvents();
            }

            // Find the event and remove it from the queue
            XCheckIfEvent(X11.Display, out _, IsSelectionPropertyNewValueNotify, new IntPtr(&notification));

            XGetWindowProperty(X11.Display,
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

            if (actualType == X11.Atoms[KnownAtoms.INCR])
            {
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

                return files;
            }
        }
    }
}

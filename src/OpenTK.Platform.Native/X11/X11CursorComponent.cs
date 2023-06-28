using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.X11.LibX11;
using static OpenTK.Platform.Native.X11.XFixes;

namespace OpenTK.Platform.Native.X11
{
    public class X11CursorComponent : ICursorComponent
    {
        /// <inheritdoc />
        public string Name => nameof(X11CursorComponent);

        /// <inheritdoc />
        public PalComponents Provides => PalComponents.MouseCursor;

        /// <inheritdoc />
        public ILogger? Logger { get; set; }

        private bool _hasXFixes = false;

        /// <inheritdoc />
        public void Initialize(PalComponents which)
        {
            if ((which & ~Provides) != 0)
            {
                throw new PalException(this, $"Cannot initialize unimplemented components {which & ~Provides}.");
            }

            if (XFixesQueryExtension(X11.Display, out int event_base, out int error_base))
            {
                _hasXFixes = true;

                int major = 5;
                int minor = 0;
                int status = XFixesQueryVersion(X11.Display, ref major, ref minor);

                if (major < 5)
                {
                    Logger?.LogError($"Could not load XFixes. Got version: {major}.{minor} but we require 5.0. Status: {status}");
                    _hasXFixes = false;
                }

                Console.WriteLine("Loaded xfixes!");
            }
        }

        /// <inheritdoc />
        public bool CanLoadSystemCursors => true;

        /// <inheritdoc />
        public bool CanInspectSystemCursors => false;

        /// <inheritdoc />
        public CursorHandle Create(SystemCursorType systemCursor)
        {
            XCursorHandle xcursor = new XCursorHandle();

            XCursorShape shape;
            switch (systemCursor)
            {
                case SystemCursorType.Default:
                    shape = XCursorShape.LeftPtr;
                    break;
                case SystemCursorType.Loading:
                    // FIXME: Do we want to use left_ptr_watch??
                    // https://www.pixelbeat.org/programming/x_cursors/
                    shape = XCursorShape.Watch;
                    break;
                case SystemCursorType.Wait:
                    shape = XCursorShape.Watch;
                    break;
                case SystemCursorType.Cross:
                    shape = XCursorShape.Crosshair;
                    break;
                case SystemCursorType.Hand:
                    shape = XCursorShape.Hand2;
                    break;
                case SystemCursorType.Help:
                    shape = XCursorShape.QuestionArrow;
                    break;
                case SystemCursorType.TextBeam:
                    shape = XCursorShape.XTerm;
                    break;
                case SystemCursorType.Forbidden:
                    shape = XCursorShape.XCursor;
                    break;
                case SystemCursorType.ArrowFourway:
                    shape = XCursorShape.Fleur;
                    break;
                case SystemCursorType.ArrowNS:
                    shape = XCursorShape.SBVerticalDoubleArrow;
                    break;
                case SystemCursorType.ArrowEW:
                    shape = XCursorShape.SBHorizontalDoubleArrow;
                    break;
                case SystemCursorType.ArrowNESW:
                    // FIXME: Is there are better shape?
                    // https://unix.stackexchange.com/questions/684139/what-do-these-xcursor-names-mean
                    shape = XCursorShape.BottomLeftCorner;
                    break;
                case SystemCursorType.ArrowNWSE:
                    // FIXME: Is there are better shape?
                    // https://unix.stackexchange.com/questions/684139/what-do-these-xcursor-names-mean
                    shape = XCursorShape.BottomRightCorner;
                    break;
                case SystemCursorType.ArrowUp:
                    shape = XCursorShape.SBUpArrow;
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(systemCursor), (int)systemCursor, typeof(SystemCursorType));
            }

            XCursor cursor = XCreateFontCursor(X11.Display, shape);

            xcursor.Cursor = cursor;

            return xcursor;
        }

        // FIXME: Save size and hotspot for image cursors so we can return them later.
        // FIXME: Separate system and image cursors.

        /// <inheritdoc />
        public CursorHandle Create(int width, int height, ReadOnlySpan<byte> image, int hotspotX, int hotspotY)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public unsafe CursorHandle Create(int width, int height, ReadOnlySpan<byte> colorData, ReadOnlySpan<byte> maskData, int hotspotX, int hotspotY)
        {
            XCursorHandle xcursor = new XCursorHandle();

            byte[] mask = new byte[maskData.Length / 8];
            for (int i = 0; i < maskData.Length; i++)
            {
                if (maskData[i] == 1)
                {
                    mask[i / 8] |= (byte)(0x1 << (i % 8));
                }
            }

            XPixmap pixmap;
            fixed (byte* maskPtr = mask)
            {
                pixmap = XCreateBitmapFromData(X11.Display, X11.DefaultRootWindow, maskPtr, width, height);
            }

            XColor color;
            color.red = 255;
            color.green = 128;
            color.blue = 64;
            color.flags = XColorFlags.DoRed | XColorFlags.DoGreen | XColorFlags.DoBlue;

            XCursor cursor = XCreatePixmapCursor(X11.Display, pixmap, pixmap, &color, &color, hotspotX, hotspotY);

            xcursor.Cursor = cursor;

            XFreePixmap(X11.Display, pixmap);

            return xcursor;
        }

        /// <inheritdoc />
        public void Destroy(CursorHandle handle)
        {
            XCursorHandle xcursor = handle.As<XCursorHandle>(this);

            // FIXME: Don't destroy system cursors?
            if (xcursor.Cursor != XCursor.None)
            {
                XFreeCursor(X11.Display, xcursor.Cursor);
            }

            xcursor.Cursor = XCursor.None;
        }

        /// <inheritdoc />
        public bool IsSystemCursor(CursorHandle handle)
        {
            XCursorHandle xcursor = handle.As<XCursorHandle>(this);
            // FIXME: For now we only support system cursors.
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public unsafe void GetSize(CursorHandle handle, out int width, out int height)
        {
            XCursorHandle xcursor = handle.As<XCursorHandle>(this);

            // FIXME: Non system cursors.
            throw new InvalidOperationException("X11 backend cannot get the hotspot of a system cursor.");

            // FIXME: This code is not needed now, because we are not trying to get the size of system cursors.
            if (_hasXFixes)
            {
                // FIXME: This only works for the current cursor
                // So we are likely going to have to temporarily change the cursor,
                // - Noggin_bops 2023-03-10
                XFixesCursorImage* cursor = XFixesGetCursorImage(X11.Display);

                width = cursor->width;
                height = cursor->height;

                XFree(cursor);
            }
            else
            {
                // FIXME: Return the size of the cursor image if it's not a system cursor...
                Logger?.LogError("Can't get cursor size because XFixes is not available!");
                width = 0;
                height = 0;
            }
        }

        /// <inheritdoc />
        public void GetHotspot(CursorHandle handle, out int x, out int y)
        {
            XCursorHandle xcursor = handle.As<XCursorHandle>(this);

            // FIXME: Non system cursors.
            throw new InvalidOperationException("X11 backend cannot get the hotspot of a system cursor.");
        }
    }
}

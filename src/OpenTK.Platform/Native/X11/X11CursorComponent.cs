using OpenTK.Core.Utility;
using System;
using System.ComponentModel;
using static OpenTK.Platform.Native.X11.LibX11;
using static OpenTK.Platform.Native.X11.XFixes;
using static OpenTK.Platform.Native.X11.LibXcursor;
using System.Runtime.InteropServices;

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
        public void Initialize(ToolkitOptions options)
        {
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

                Logger?.LogInfo("Loaded xfixes!");
            }
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
        }

        /// <inheritdoc />
        public bool CanLoadSystemCursors => true;

        /// <inheritdoc />
        public bool CanInspectSystemCursors => false;

        /// <inheritdoc />
        public CursorHandle Create(SystemCursorType systemCursor)
        {
            XCursorHandle xcursor = new XCursorHandle();

            // FIXME: Maybe use Xcursor themes?

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
                case SystemCursorType.ArrowN:
                    shape = XCursorShape.TopSide;
                    break;
                case SystemCursorType.ArrowE:
                    shape = XCursorShape.RightSide;
                    break;
                case SystemCursorType.ArrowS:
                    shape = XCursorShape.BottomSide;
                    break;
                case SystemCursorType.ArrowW:
                    shape = XCursorShape.LeftSide;
                    break;
                case SystemCursorType.ArrowNE:
                    shape = XCursorShape.TopRightCorner;
                    break;
                case SystemCursorType.ArrowSE:
                    shape = XCursorShape.BottomRightCorner;
                    break;
                case SystemCursorType.ArrowSW:
                    shape = XCursorShape.BottomLeftCorner;
                    break;
                case SystemCursorType.ArrowNW:
                    shape = XCursorShape.TopLeftCorner;
                    break;
                case SystemCursorType.ArrowUp:
                    shape = XCursorShape.SBUpArrow;
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(systemCursor), (int)systemCursor, typeof(SystemCursorType));
            }

            XCursor cursor = XCreateFontCursor(X11.Display, shape);

            xcursor.Cursor = cursor;
            xcursor.Mode = XCursorHandle.CursorMode.SystemCursor;

            return xcursor;
        }

        /// <inheritdoc />
        public unsafe CursorHandle Create(int width, int height, ReadOnlySpan<byte> image, int hotspotX, int hotspotY)
        {
            XCursorHandle xcursor = new XCursorHandle();

            if (width < 0) throw new ArgumentOutOfRangeException(nameof(width), width, "Width cannot be negative");
            if (height < 0) throw new ArgumentOutOfRangeException(nameof(height), height, "Height cannot be negative");

            if (image.Length < width * height * 4) throw new ArgumentException($"The given span is too small. It must be at least {width * height * 4} long. Was: {image.Length}");

            if (hotspotX < 0) throw new ArgumentOutOfRangeException(nameof(hotspotX), hotspotX, "Hotspot X cannot be negative");
            if (hotspotY < 0) throw new ArgumentOutOfRangeException(nameof(hotspotY), hotspotY, "Hotspot Y cannot be negative");
            if (hotspotX > width) throw new ArgumentOutOfRangeException(nameof(hotspotX), hotspotX, $"Hotspot X cannot be larger than the width of the image {width}");
            if (hotspotY > height) throw new ArgumentOutOfRangeException(nameof(hotspotY), hotspotY, $"Hotspot Y cannot be larger than the height of the image {height}");

            XcursorImage* ximage = XcursorImageCreate(width, height);

            ximage->xhot = (uint)hotspotX;
            ximage->yhot = (uint)hotspotY;

            Span<byte> imageBytes = MemoryMarshal.Cast<uint, byte>(new Span<uint>(ximage->pixels, width * height));
            // Xcursor wants byte order BGRA
            for (int i = 0; i < width * height; i++)
            {
                imageBytes[i * 4 + 0] = image[i * 4 + 2];
                imageBytes[i * 4 + 1] = image[i * 4 + 1];
                imageBytes[i * 4 + 2] = image[i * 4 + 0];
                imageBytes[i * 4 + 3] = image[i * 4 + 3];
            }

            xcursor.Cursor = XcursorImageLoadCursor(X11.Display, ximage);
            XcursorImageDestroy(ximage);

            xcursor.Mode = XCursorHandle.CursorMode.ImageCursor;
            xcursor.Width = width;
            xcursor.Height = height;
            xcursor.HotspotX = hotspotX;
            xcursor.HotspotY = hotspotY;

            return xcursor;
        }

        /// <inheritdoc />
        public unsafe CursorHandle Create(int width, int height, ReadOnlySpan<byte> colorData, ReadOnlySpan<byte> maskData, int hotspotX, int hotspotY)
        {
            XCursorHandle xcursor = new XCursorHandle();

            if (width < 0) throw new ArgumentOutOfRangeException(nameof(width), width, "Width cannot be negative");
            if (height < 0) throw new ArgumentOutOfRangeException(nameof(height), height, "Height cannot be negative");

            if (colorData.Length < width * height * 3) throw new ArgumentException($"The given color data span is too small. It must be at least {width * height * 3} long. Was: {colorData.Length}");
            if (maskData.Length < width * height * 1) throw new ArgumentException($"The given mask data span is too small. It must be at least {width * height * 1} long. Was: {maskData.Length}");

            if (hotspotX < 0) throw new ArgumentOutOfRangeException(nameof(hotspotX), hotspotX, "Hotspot X cannot be negative");
            if (hotspotY < 0) throw new ArgumentOutOfRangeException(nameof(hotspotY), hotspotY, "Hotspot Y cannot be negative");
            if (hotspotX > width) throw new ArgumentOutOfRangeException(nameof(hotspotX), hotspotX, $"Hotspot X cannot be larger than the width of the image {width}");
            if (hotspotY > height) throw new ArgumentOutOfRangeException(nameof(hotspotY), hotspotY, $"Hotspot Y cannot be larger than the height of the image {height}");

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
                pixmap = XCreateBitmapFromData(X11.Display, (XDrawable)X11.DefaultRootWindow, maskPtr, width, height);
            }

            // FIXME: Color?
            XColor color;
            color.red = 255;
            color.green = 128;
            color.blue = 64;
            color.flags = XColorFlags.DoRed | XColorFlags.DoGreen | XColorFlags.DoBlue;

            XCursor cursor = XCreatePixmapCursor(X11.Display, pixmap, pixmap, &color, &color, hotspotX, hotspotY);
            XFreePixmap(X11.Display, pixmap);

            xcursor.Cursor = cursor;
            xcursor.Mode = XCursorHandle.CursorMode.ImageCursor;
            xcursor.Width = width;
            xcursor.Height = height;
            xcursor.HotspotX = hotspotX;
            xcursor.HotspotY = hotspotY;

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
            xcursor.Mode = XCursorHandle.CursorMode.Uninitialized;
        }

        /// <inheritdoc />
        public bool IsSystemCursor(CursorHandle handle)
        {
            XCursorHandle xcursor = handle.As<XCursorHandle>(this);

            return xcursor.Mode == XCursorHandle.CursorMode.SystemCursor;
        }

        /// <inheritdoc />
        public unsafe void GetSize(CursorHandle handle, out int width, out int height)
        {
            XCursorHandle xcursor = handle.As<XCursorHandle>(this);

            if (xcursor.Mode == XCursorHandle.CursorMode.SystemCursor)
            {
                throw new InvalidOperationException("X11 backend cannot get the size of a system cursor.");
            }

            width = xcursor.Width;
            height = xcursor.Height;
        }

        /// <inheritdoc />
        public void GetHotspot(CursorHandle handle, out int x, out int y)
        {
            XCursorHandle xcursor = handle.As<XCursorHandle>(this);

            if (xcursor.Mode == XCursorHandle.CursorMode.SystemCursor)
            {
                throw new InvalidOperationException("X11 backend cannot get the hotspot of a system cursor.");
            }

            x = xcursor.HotspotX;
            y = xcursor.HotspotY;
        }
    }
}

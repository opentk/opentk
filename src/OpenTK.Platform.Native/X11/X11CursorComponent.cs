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

namespace OpenTK.Platform.Native.X11
{
    public class X11CursorComponent : ICursorComponent
    {
        public string Name => nameof(X11CursorComponent);

        public PalComponents Provides => PalComponents.MouseCursor;

        public ILogger? Logger { get; set; }

        public void Initialize(PalComponents which)
        {
            if ((which & ~Provides) != 0)
            {
                throw new PalException(this, $"Cannot initialize unimplemented components {which & ~Provides}.");
            }


        }

        public bool CanLoadFromFile => throw new NotImplementedException();

        public bool CanLoadSystemCursor => true;

        public bool CanScaleCursor => throw new NotImplementedException();

        public bool CanSupportAnimatedCursor => throw new NotImplementedException();

        public CursorHandle Create()
        {
            return new XCursorHandle();
        }

        public void Destroy(CursorHandle handle)
        {
            XCursorHandle xcursor = handle.As<XCursorHandle>(this);

            XFreeCursor(X11.Display, xcursor.Cursor);

            xcursor.Cursor = XCursor.None;
        }

        public void GetSize(CursorHandle handle, out int width, out int height)
        {
            throw new NotImplementedException();
        }

        public void GetHotspot(CursorHandle handle, out int x, out int y)
        {
            throw new NotImplementedException();
        }

        public void GetImage(CursorHandle handle, Span<byte> image)
        {
            throw new NotImplementedException();
        }

        public void GetScale(CursorHandle handle, out float horizontal, out float vertical)
        {
            throw new NotImplementedException();
        }

        public void Load(CursorHandle handle, SystemCursorType systemCursor)
        {
            XCursorHandle xcursor = handle.As<XCursorHandle>(this);

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
        }

        public void Load(CursorHandle handle, int width, int height, ReadOnlySpan<byte> image)
        {
            throw new NotImplementedException();
        }

        public unsafe void Load(CursorHandle handle, int width, int height, ReadOnlySpan<byte> colorData, ReadOnlySpan<byte> maskData)
        {
            XCursorHandle xcursor = handle.As<XCursorHandle>(this);

            Destroy(xcursor);

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

            XCursor cursor = XCreatePixmapCursor(X11.Display, pixmap, pixmap, &color, &color, 0, 0);

            xcursor.Cursor = cursor;

            XFreePixmap(X11.Display, pixmap);
        }

        public void Load(CursorHandle handle, string file)
        {
            throw new NotImplementedException();
        }

        public void Load(CursorHandle handle, Stream stream)
        {
            throw new NotImplementedException();
        }

        public void SetHotspot(CursorHandle handle, int x, int y)
        {
            throw new NotImplementedException();
        }

        public void SetScale(CursorHandle handle, float horizontal, float vertical)
        {
            throw new NotImplementedException();
        }
    }
}

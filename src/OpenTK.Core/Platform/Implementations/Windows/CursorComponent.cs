using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform.Implementations.Windows
{
    public class CursorComponent : ICursorComponent
    {
        public string Name => "Win32CursorComponent";

        public PalComponents Provides => PalComponents.MouseCursor;

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.MouseCursor)
            {
                throw new Exception("CursorComponent can only initialize the MouseCursor component.");
            }
        }

        public bool CanLoadFromFile => throw new NotImplementedException();

        public bool CanLoadSystemCursor => true;

        public bool CanScaleCursor => throw new NotImplementedException();

        public CursorHandle Create()
        {
            return new HCursor();
        }

        public void Destroy(CursorHandle handle)
        {
            HCursor hcursor = handle.As<HCursor>(this);

            if (hcursor.IsShared == false)
            {
                if (hcursor.IsIcon)
                {
                    bool success = Win32.DestroyIcon(hcursor.Cursor);
                    if (success == false)
                    {
                        throw new Win32Exception("DestroyIcon failed.");
                    }
                }
                else
                {
                    bool success = Win32.DestroyCursor(hcursor.Cursor);
                    if (success == false)
                    {
                        throw new Win32Exception("DestroyCursor failed.");
                    }
                }
            }

            hcursor.Cursor = IntPtr.Zero;
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
            HCursor hcursor = handle.As<HCursor>(this);

            if (hcursor.Cursor != IntPtr.Zero)
            {
                // FIXME: Figure if we really need to destroy the cursor.
                // FIXME: We want to call win32 DestroyCursor() if this is a non-shared cursor.
                Destroy(handle);
            }

            OCR cursor;
            switch (systemCursor)
            {
                case SystemCursorType.Default:
                    cursor = OCR.Normal;
                    break;
                case SystemCursorType.Loading:
                    cursor = OCR.Wait;
                    break;
                case SystemCursorType.Wait:
                    cursor = OCR.Wait;
                    break;
                case SystemCursorType.Cross:
                    cursor = OCR.Cross;
                    break;
                case SystemCursorType.Hand:
                    cursor = OCR.Hand;
                    break;
                case SystemCursorType.Help:
                    cursor = OCR.Help;
                    break;
                case SystemCursorType.TextBeam:
                    cursor = OCR.IBeam;
                    break;
                case SystemCursorType.Forbidden:
                    cursor = OCR.No;
                    break;
                case SystemCursorType.ArrowFourway:
                    cursor = OCR.SizeAll;
                    break;
                case SystemCursorType.ArrowNS:
                    cursor = OCR.SizeNS;
                    break;
                case SystemCursorType.ArrowEW:
                    cursor = OCR.SizeWE;
                    break;
                case SystemCursorType.ArrowNESW:
                    cursor = OCR.SizeNESW;
                    break;
                case SystemCursorType.ArrowNWSE:
                    cursor = OCR.SizeNWSE;
                    break;
                case SystemCursorType.ArrowUp:
                    cursor = OCR.Up;
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(systemCursor), (int)systemCursor, typeof(SystemCursorType));
            }

            // FIXME: For now we are sending 0, 0 and DefaultSize for the size of the cursor.
            // We might want to handle this differently in the future.
            hcursor.Cursor = Win32.LoadImage(IntPtr.Zero, cursor, ImageType.Cursor, 0, 0, LR.DefaultSize | LR.Shared);
            hcursor.IsShared = true;
            hcursor.IsIcon = false;

            if (hcursor.Cursor == IntPtr.Zero)
            {
                throw new Win32Exception($"Could not load cursor '{cursor}'");
            }
        }

        public void Load(CursorHandle handle, int width, int height, ReadOnlySpan<byte> image)
        {
            HCursor hcursor = handle.As<HCursor>(this);

            IntPtr hDC = Win32.GetDC(IntPtr.Zero);
            IntPtr hAndMaskDC = Win32.CreateCompatibleDC(hDC);
            IntPtr hXorMaskDC = Win32.CreateCompatibleDC(hDC);

            IntPtr hAndMaskBitmap = Win32.CreateCompatibleBitmap(hAndMaskDC, width, height);
            IntPtr hXorMaskBitmap = Win32.CreateCompatibleBitmap(hXorMaskDC, width, height);

            IntPtr hOldAndMaskBitmap = Win32.SelectObject(hAndMaskDC, hAndMaskBitmap);
            IntPtr hOldXorMaskBitmap = Win32.SelectObject(hXorMaskDC, hXorMaskBitmap);

            // FIXME: We want to consider transparency!
            // And the possibility of a "Reverse screen" color
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int index = (x + (y * width)) * 3;

                    int color = image[index + 0] | image[index + 1] << 8 | image[index + 2] << 16;

                    Win32.SetPixel(hAndMaskDC, x, y, 0x0f_00_0f_ff);
                    Win32.SetPixel(hXorMaskDC, x, y, color);
                }
            }

            // Select the old objects again, as stated we should in the documentation.
            Win32.SelectObject(hAndMaskDC, hOldAndMaskBitmap);
            Win32.SelectObject(hXorMaskDC, hOldXorMaskBitmap);

            Win32.DeleteDC(hAndMaskDC);
            Win32.DeleteDC(hXorMaskDC);

            Win32.ReleaseDC(IntPtr.Zero, hDC);

            Win32.ICONINFO iconinfo = new Win32.ICONINFO()
            {
                fIcon = false, // we are creating a cursor
                xHotspot = 0,
                yHotspot = 0,
                hbmMask = hAndMaskBitmap,
                hbmColor = hXorMaskBitmap,
            };

            IntPtr hcursorIcon = Win32.CreateIconIndirect(in iconinfo);
            if (hcursorIcon == IntPtr.Zero)
            {
                throw new Win32Exception("CreateIconIndirect failed.");
            }

            hcursor.Cursor = hcursorIcon;
            hcursor.IsShared = false;
            hcursor.IsIcon = true;
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

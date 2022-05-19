using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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

        public bool CanScaleCursor => false;

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

        public unsafe void GetSize(CursorHandle handle, out int width, out int height)
        {
            HCursor hcursor = handle.As<HCursor>(this);

            width = 0;
            height = 0;

            // See https://stackoverflow.com/a/13295280
            if (Win32.GetIconInfo(hcursor.Cursor, out Win32.ICONINFO info))
            {
                bool bwCursor = info.hbmColor == IntPtr.Zero;
                if (Win32.GetObject(info.hbmMask, sizeof(Win32.BITMAP), out Win32.BITMAP bmpInfo) != 0)
                {
                    width = bmpInfo.bmWidth;
                    height = bmpInfo.bmHeight / (bwCursor ? 2 : 1);
                }

                if (info.hbmColor != IntPtr.Zero)
                    Win32.DeleteObject(info.hbmColor);
                Win32.DeleteObject(info.hbmMask);
            }
        }

        public void GetHotspot(CursorHandle handle, out int x, out int y)
        {
            HCursor hcursor = handle.As<HCursor>(this);

            // See https://stackoverflow.com/a/13295280
            if (Win32.GetIconInfo(hcursor.Cursor, out Win32.ICONINFO info))
            {
                x = info.xHotspot;
                y = info.yHotspot;
            }
            else
            {
                throw new Win32Exception("GetIconInfo failed.");
            }
        }

        public unsafe void GetImage(CursorHandle handle, Span<byte> image)
        {
            HCursor hcursor = handle.As<HCursor>(this);

            // FIXME: If this cursor is one of the standard cursors
            // we want to call CopyIcon so that we can call GetIconInfo properly!

            // See https://stackoverflow.com/a/13295280
            if (Win32.GetIconInfo(hcursor.Cursor, out Win32.ICONINFO info))
            {
                bool bwCursor = info.hbmColor == IntPtr.Zero;

                IntPtr hDC = Win32.GetDC(IntPtr.Zero);
                IntPtr compatibleDC = Win32.CreateCompatibleDC(hDC);

                Win32.BITMAPINFO bmInfo = default;
                bmInfo.bmiHeader.biSize = (uint)sizeof(Win32.BITMAPINFOHEADER);
                int success = Win32.GetDIBits(hDC, info.hbmColor, 0, 0, null, ref bmInfo, DIB.RGBColors);
                if (success == 0 || success == Win32.ERROR_INVALID_PARAMETER)
                {
                    throw new Exception("GetDIBits failed.");
                }

                if (image.Length < bmInfo.bmiHeader.biSizeImage)
                {
                    throw new Exception("Image buffer not big enough!");
                }

                bmInfo.bmiHeader.biPlanes = 1;
                bmInfo.bmiHeader.biCompression = BI.RGB;

                fixed (byte* ptr = image)
                {
                    if (bmInfo.bmiHeader.biHeight >= 0)
                    {
                        success = Win32.GetDIBits(hDC, info.hbmColor, 0, (uint)bmInfo.bmiHeader.biHeight, (void*)ptr, ref bmInfo, DIB.RGBColors);
                        if (success == 0 || success == Win32.ERROR_INVALID_PARAMETER)
                        {
                            throw new Exception("GetDIBits failed.");
                        }
                    }
                    else
                    {
                        // FIXME: Handle negative height!
                        throw new NotImplementedException();
                        //Win32.GetDIBits(hDC, info.hbmColor, 0, bmInfo.bmiHeader., (void*)ptr, ref bmInfo, DIB.RGBColors);
                    }
                }

                Win32.ReleaseDC(IntPtr.Zero, hDC);

                if (info.hbmColor != IntPtr.Zero)
                    Win32.DeleteObject(info.hbmColor);
                Win32.DeleteObject(info.hbmMask);
            }
            else
            {
                throw new Win32Exception("GetIconInfo failed.");
            }

            throw new NotImplementedException();
        }

        public void GetScale(CursorHandle handle, out float horizontal, out float vertical)
        {
            HCursor hcursor = handle.As<HCursor>(this);

            horizontal = 1;
            vertical = 1;
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

            // See https://www.codeguru.com/windows/creating-a-color-cursor-from-a-bitmap/

            IntPtr hDC = Win32.GetDC(IntPtr.Zero);
            IntPtr hAndMaskDC = Win32.CreateCompatibleDC(hDC);
            if (hAndMaskDC == IntPtr.Zero) throw new Win32Exception("AndMask CreateCompatibleDC() failed.");
            IntPtr hXorMaskDC = Win32.CreateCompatibleDC(hDC);
            if (hXorMaskDC == IntPtr.Zero) throw new Win32Exception("XorMask CreateCompatibleDC() failed.");

            // Make sure to call CreateCompatibleBitmap with the window DC as the
            // newly created DC is initialized with a mono-chromatic 1x1 pixel bitmap by default.
            // And we don't want to create a bitmap with a monochrome format.
            // See https://www.codeproject.com/Articles/224754/Guide-to-Win32-Memory-DC#:~:text=Avoid%20a%20Common%20Mistake
            IntPtr hAndMaskBitmap = Win32.CreateCompatibleBitmap(hDC, width, height);
            if (hAndMaskBitmap == IntPtr.Zero) throw new Win32Exception("AndMask CreateCompatibleBitmap() failed.");
            IntPtr hXorMaskBitmap = Win32.CreateCompatibleBitmap(hDC, width, height);
            if (hXorMaskBitmap == IntPtr.Zero) throw new Win32Exception("XorMask CreateCompatibleBitmap() failed.");

            IntPtr hOldAndMaskBitmap = Win32.SelectObject(hAndMaskDC, hAndMaskBitmap);
            if (hOldAndMaskBitmap == IntPtr.Zero) throw new Win32Exception("AndMask SelectObject() failed.");
            IntPtr hOldXorMaskBitmap = Win32.SelectObject(hXorMaskDC, hXorMaskBitmap);
            if (hOldXorMaskBitmap == IntPtr.Zero) throw new Win32Exception("XorMask SelectObject() failed.");

            // FIXME: We want to consider transparency!
            // And the possibility of a "Reverse screen" color
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int index = (x + (y * width)) * 3;

                    uint color = (uint)image[index + 0] << 0 | (uint)image[index + 1] << 8 | (uint)image[index + 2] << 16;

                    int success;
                    success = Win32.SetPixelV(hAndMaskDC, x, y, 0x00_00_00_00u);
                    if (success == 0) throw new Win32Exception("AndMask SetPixel() failed.");
                    success = Win32.SetPixelV(hXorMaskDC, x, y, color);
                    if (success == 0) throw new Win32Exception("XorMask SetPixel() failed.");
                }
            }

            // Select the old objects again, as stated we should in the documentation.
            Win32.SelectObject(hAndMaskDC, hOldAndMaskBitmap);
            Win32.SelectObject(hXorMaskDC, hOldXorMaskBitmap);

            bool deleted;
            deleted = Win32.DeleteDC(hAndMaskDC);
            if (deleted == false) throw new Win32Exception("AndMask DeleteDC() failed.");
            deleted = Win32.DeleteDC(hXorMaskDC);
            if (deleted == false) throw new Win32Exception("XorMask DeleteDC() failed.");

            Win32.ReleaseDC(IntPtr.Zero, hDC);

            Win32.ICONINFO iconinfo = new Win32.ICONINFO()
            {
                fIcon = false, // We are creating a cursor
                xHotspot = hcursor.HotSpotX,
                yHotspot = hcursor.HotSpotY,
                hbmMask = hAndMaskBitmap,
                hbmColor = hXorMaskBitmap,
            };

            IntPtr hcursorIcon = Win32.CreateIconIndirect(in iconinfo);
            if (hcursorIcon == IntPtr.Zero)
            {
                throw new Win32Exception("CreateIconIndirect() failed.");
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
            HCursor hcursor = handle.As<HCursor>(this);

            hcursor.HotSpotX = x;
            hcursor.HotSpotY = y;

            throw new NotImplementedException();
        }

        public void SetScale(CursorHandle handle, float horizontal, float vertical)
        {
            throw new NotImplementedException();
        }
    }
}

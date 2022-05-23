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

        public bool CanSupportAnimatedCursor => throw new NotImplementedException();

        public CursorHandle Create()
        {
            return new HCursor();
        }

        public void Destroy(CursorHandle handle)
        {
            HCursor hcursor = handle.As<HCursor>(this);

            switch (hcursor.Mode)
            {
                case HCursor.CursorMode.Uninitialized:
                    // Do nothing.
                    break;
                case HCursor.CursorMode.SystemCursor:
                    {
                        // This is a shared cursor, so we shouldn't destroy it.
                        break;
                    }
                case HCursor.CursorMode.Icon:
                    {
                        bool success = Win32.DestroyIcon(hcursor.Cursor);
                        if (success == false)
                        {
                            throw new Win32Exception("DestroyIcon failed.");
                        }

                        // Delete the mask and color bitmaps.
                        Win32.DeleteObject(hcursor.MaskBitmap);
                        Win32.DeleteObject(hcursor.ColorBitmap);
                        break;
                    }
                default:
                    throw new InvalidOperationException($"Unknown cursor mode: {hcursor.Mode}.");
            }

            hcursor.Cursor = IntPtr.Zero;
            hcursor.ColorBitmap = IntPtr.Zero;
            hcursor.MaskBitmap = IntPtr.Zero;
            hcursor.Mode = HCursor.CursorMode.Uninitialized;
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

                Win32.DeleteObject(info.hbmColor);
                Win32.DeleteObject(info.hbmMask);
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
            IntPtr cursor_copy = Win32.CopyIcon(hcursor.Cursor);
            {
                Win32.CURSORINFO cinfo = default;
                cinfo.cbSize = (uint)sizeof(Win32.CURSORINFO);
                if (Win32.GetCursorInfo(ref cinfo) == false)
                    throw new Win32Exception("GetCursorInfo failed.");
            }

            // See https://stackoverflow.com/a/13295280
            if (Win32.GetIconInfo(cursor_copy, out Win32.ICONINFO info))
            {
                // Create a buffer for the mask.
                static void GetImage(IntPtr hDC, IntPtr hbm, Span<byte> image)
                {
                    Win32.BITMAPINFO bmInfo = default;
                    bmInfo.bmiHeader.biSize = (uint)sizeof(Win32.BITMAPINFOHEADER);
                    int success = Win32.GetDIBits(hDC, hbm, 0, 0, null, ref bmInfo, DIB.RGBColors);
                    if (success == 0 || success == Win32.ERROR_INVALID_PARAMETER)
                    {
                        throw new Exception("GetDIBits failed.");
                    }

                    if (image.Length < bmInfo.bmiHeader.biSizeImage)
                    {
                        throw new Exception("Image buffer not big enough!");
                    }

                    bmInfo.bmiHeader.biBitCount = 32;
                    bmInfo.bmiHeader.biPlanes = 1;
                    bmInfo.bmiHeader.biCompression = BI.RGB;

                    fixed (byte* ptr = image)
                    {
                        success = Win32.GetDIBits(hDC, hbm, 0, (uint)bmInfo.bmiHeader.biHeight, (void*)ptr, ref bmInfo, DIB.RGBColors);
                        if (success == 0 || success == Win32.ERROR_INVALID_PARAMETER)
                        {
                            throw new Exception("GetDIBits failed.");
                        }
                    }

                    if (bmInfo.bmiHeader.biHeight < 0)
                    {
                        // A negative height means we have a top-down bitmap.
                        // For consistency we need to flip this image vertically.
                        for (int y = 0; y < bmInfo.bmiHeader.biHeight / 2; y++)
                        {
                            for (int x = 0; x < bmInfo.bmiHeader.biWidth; x++)
                            {
                                int index = ((y * bmInfo.bmiHeader.biWidth) + x) * 4;
                                int indexFlipped = (((bmInfo.bmiHeader.biHeight - y - 1) * bmInfo.bmiHeader.biWidth) + x) * 4;
                                (image[index], image[indexFlipped]) = (image[indexFlipped], image[index]);
                            }
                        }
                    }
                }

                IntPtr hDC = Win32.GetDC(IntPtr.Zero);

                if (info.hbmColor == IntPtr.Zero)
                {
                    // These is no color mask, so we need to read the mask
                    GetImage(hDC, info.hbmMask, image);

                    // Here we apply the mask over a white background
                    // And at the same time generate an alpha mask.
                    for (int i = 0; i < image.Length; i += 4)
                    {
                        // We also convert from Bgra to Rgba here.
                        image[i + 0] = (byte)(0xFF ^ image[i + 2]);
                        image[i + 1] = (byte)(0xFF ^ image[i + 1]);
                        image[i + 2] = (byte)(0xFF ^ image[i + 0]);

                        // If the resulting color pure white we set alpha to 0,
                        // otherwise we set it to 255.
                        if (image[i + 0] == 0xFF && image[i + 1] == 0xFF && image[i + 2] == 0xFF)
                        {
                            // The final color is pure white
                            image[i + 3] = 0x00;
                        }
                        else
                        {
                            // The final color not pure white, so we set alpha.
                            image[i + 3] = 0xFF;
                        }
                    }
                }
                else
                {
                    GetImage(hDC, info.hbmColor, image);

                    // Convert from Bgra to Rgba.
                    for (int i = 0; i < image.Length; i += 4)
                    {
                        (image[i + 0], image[i + 2]) = (image[i + 2], image[i + 0]);
                    }
                }

                Win32.ReleaseDC(IntPtr.Zero, hDC);

                Win32.DeleteObject(info.hbmColor);
                Win32.DeleteObject(info.hbmMask);
            }
            else
            {
                throw new Win32Exception("GetIconInfo failed.");
            }

            bool successBool = Win32.DestroyIcon(cursor_copy);
            if (successBool == false)
            {
                throw new Win32Exception("DestroyIcon failed.");
            }
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
                // FIXME: Figure out if we really need to destroy the cursor.
                // FIXME: We want to call win32 DestroyCursor() if this is a non-shared cursor.
                Destroy(handle);
            }

            OCR ocr;
            switch (systemCursor)
            {
                case SystemCursorType.Default:
                    ocr = OCR.Normal;
                    break;
                case SystemCursorType.Loading:
                    ocr = OCR.Wait;
                    break;
                case SystemCursorType.Wait:
                    ocr = OCR.Wait;
                    break;
                case SystemCursorType.Cross:
                    ocr = OCR.Cross;
                    break;
                case SystemCursorType.Hand:
                    ocr = OCR.Hand;
                    break;
                case SystemCursorType.Help:
                    ocr = OCR.Help;
                    break;
                case SystemCursorType.TextBeam:
                    ocr = OCR.IBeam;
                    break;
                case SystemCursorType.Forbidden:
                    ocr = OCR.No;
                    break;
                case SystemCursorType.ArrowFourway:
                    ocr = OCR.SizeAll;
                    break;
                case SystemCursorType.ArrowNS:
                    ocr = OCR.SizeNS;
                    break;
                case SystemCursorType.ArrowEW:
                    ocr = OCR.SizeWE;
                    break;
                case SystemCursorType.ArrowNESW:
                    ocr = OCR.SizeNESW;
                    break;
                case SystemCursorType.ArrowNWSE:
                    ocr = OCR.SizeNWSE;
                    break;
                case SystemCursorType.ArrowUp:
                    ocr = OCR.Up;
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(systemCursor), (int)systemCursor, typeof(SystemCursorType));
            }

            // FIXME: For now we are sending 0, 0 and DefaultSize for the size of the cursor.
            // We might want to handle this differently in the future.
            hcursor.Cursor = Win32.LoadImage(IntPtr.Zero, ocr, ImageType.Cursor, 0, 0, LR.Shared | LR.DefaultSize);
            hcursor.Mode = HCursor.CursorMode.SystemCursor;

            if (hcursor.Cursor == IntPtr.Zero)
            {
                throw new Win32Exception($"Could not load cursor '{ocr}'");
            }
        }

        public unsafe void Load(CursorHandle handle, int width, int height, ReadOnlySpan<byte> image)
        {
            HCursor hcursor = handle.As<HCursor>(this);

            if (width < 0) throw new ArgumentOutOfRangeException($"Width cannot be negative. Value: {width}");
            if (height < 0) throw new ArgumentOutOfRangeException($"Height cannot be negative. Value: {height}");

            if (image.Length < width * height * 4) throw new ArgumentException($"The given span is too small. It must be at least {width * height * 4} long. Was: {image.Length}");

            if (hcursor.Cursor != IntPtr.Zero)
            {
                // FIXME: Figure out if we really need to destroy the cursor.
                // FIXME: We want to call win32 DestroyCursor() if this is a non-shared cursor.
                Destroy(handle);
            }

            // See https://web.archive.org/web/20080205042408/http://support.microsoft.com/kb/318876
            Win32.BITMAPV5HEADER header = default;
            header.bV5Size = (uint)sizeof(Win32.BITMAPV5HEADER);
            header.bV5Width = width;
            header.bV5Height = height;
            header.bV5Planes = 1;
            header.bV5BitCount = 32;
            header.bV5Compression = BI.Bitfields;
            header.bV5RedMask = 0x00_FF_00_00;
            header.bV5GreenMask = 0x00_00_FF_00;
            header.bV5BlueMask = 0x00_00_00_FF;
            header.bV5AlphaMask = 0xFF_00_00_00;
            // FIXME: Determine color space!
            // header.bV5CSType = LCS_sRGB?

            IntPtr hDC = Win32.GetDC(IntPtr.Zero);

            IntPtr colorBitmap = Win32.CreateDIBSection(hDC, in header, DIB.RGBColors, out IntPtr dataPtr, IntPtr.Zero, 0);
            if (colorBitmap == IntPtr.Zero)
            {
                throw new Win32Exception("CreateDIBSection failed.");
            }

            Span<byte> data = new Span<byte>(dataPtr.ToPointer(), width * height * 4);

            // Copy over image data.
            image.CopyTo(data);

            // Create an empty mask.
            IntPtr maskBitmap = Win32.CreateBitmap(width, height, 1, 1, IntPtr.Zero);
            // FIXME: The value if ERROR_INVALID_BITMAP is impossible to find.
            // It's not defined in wingdi.h and nothing online mentions it.
            if (maskBitmap == IntPtr.Zero /*|| maskBitmap == Win32.ERROR_INVALID_BITMAP*/)
            {
                throw new Win32Exception("CreateBitmap failed.");
            }

            Win32.ICONINFO iconinfo = new Win32.ICONINFO()
            {
                fIcon = false, // We are creating a cursor
                xHotspot = hcursor.HotSpotX,
                yHotspot = hcursor.HotSpotY,
                hbmMask = maskBitmap,
                hbmColor = colorBitmap,
            };

            IntPtr hcursorIcon = Win32.CreateIconIndirect(in iconinfo);
            if (hcursorIcon == IntPtr.Zero)
            {
                throw new Win32Exception("CreateIconIndirect() failed.");
            }

            Win32.ReleaseDC(IntPtr.Zero, hDC);

            hcursor.Cursor = hcursorIcon;
            hcursor.MaskBitmap = maskBitmap;
            hcursor.ColorBitmap = colorBitmap;
            hcursor.Mode = HCursor.CursorMode.Icon;
        }

        public void Load(CursorHandle handle, int width, int height, ReadOnlySpan<byte> colorData, ReadOnlySpan<byte> maskData)
        {
            HCursor hcursor = handle.As<HCursor>(this);

            if (width < 0) throw new ArgumentOutOfRangeException(nameof(width), $"Width cannot be negative. Value: {width}");
            if (height < 0) throw new ArgumentOutOfRangeException(nameof(height), $"Height cannot be negative. Value: {height}");

            if (colorData.Length < width * height * 3) throw new ArgumentException($"The given color data span is too small. It must be at least {width * height * 3} long. Was: {colorData.Length}");
            if (maskData.Length < width * height * 1) throw new ArgumentException($"The given mask data span is too small. It must be at least {width * height * 1} long. Was: {maskData.Length}");

            if (hcursor.Cursor != IntPtr.Zero)
            {
                // FIXME: Figure out if we really need to destroy the cursor.
                // FIXME: We want to call win32 DestroyCursor() if this is a non-shared cursor.
                Destroy(handle);
            }

            // See https://www.codeguru.com/windows/creating-a-color-cursor-from-a-bitmap
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

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int index = (x + (y * width)) * 3;

                    uint mask = (uint)maskData[x + (y * width)] == 1 ? 0x00_FF_FF_FFu : 0x00_00_00_00u;
                    uint color = (uint)colorData[index + 0] << 0 | (uint)colorData[index + 1] << 8 | (uint)colorData[index + 2] << 16;

                    int success;
                    success = Win32.SetPixelV(hAndMaskDC, x, y, mask);
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
            hcursor.MaskBitmap = hAndMaskBitmap;
            hcursor.ColorBitmap = hXorMaskBitmap;
            hcursor.Mode = HCursor.CursorMode.Icon;
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

            GetSize(handle, out int width, out int height);

            if (x < 0) throw new ArgumentOutOfRangeException(nameof(x), $"x cannot be negative. x = {x}");
            if (y < 0) throw new ArgumentOutOfRangeException(nameof(y), $"y cannot be negative. y = {y}");
            if (x >= width) throw new ArgumentOutOfRangeException(nameof(x), $"x cannot be larger than the cursor width. cursor width = {width}, x = {x}");
            if (y >= height) throw new ArgumentOutOfRangeException(nameof(y), $"y cannot be larger than the cursor height. cursor height = {height}, y = {y}");

            hcursor.HotSpotX = x;
            hcursor.HotSpotY = y;

            // Here we need to recreate the HCursor with the new hotspot.

            switch (hcursor.Mode)
            {
                case HCursor.CursorMode.Uninitialized:
                    // For an uninitialized cursor we just need to record the hotspot for later use.
                    break;
                case HCursor.CursorMode.SystemCursor:
                    // Here we could get the bitmaps related to this system cursor using Win32.GetIconInfo
                    // and convert this into a CursorMode.Icon cursor. That way we can set the hotspot to wherever.
                    throw new NotSupportedException("Cannot change the hotspot of a system cursor.");
                case HCursor.CursorMode.Icon:
                    {
                        // Here we delete the HCursor, and create a new one from the stored bitmaps.
                        Win32.DestroyIcon(hcursor.Cursor);

                        Win32.ICONINFO info = new Win32.ICONINFO()
                        {
                            fIcon = false,
                            xHotspot = hcursor.HotSpotX,
                            yHotspot = hcursor.HotSpotY,
                            hbmMask = hcursor.MaskBitmap,
                            hbmColor = hcursor.ColorBitmap,
                        };

                        IntPtr hcursorIcon = Win32.CreateIconIndirect(in info);
                        if (hcursorIcon == IntPtr.Zero)
                        {
                            throw new Win32Exception("CreateIconIndirect() failed.");
                        }

                        hcursor.Cursor = hcursorIcon;
                        break;
                    }
                default:
                    throw new InvalidOperationException($"Unknown cursor mode: {hcursor.Mode}.");
            }
        }

        public void SetScale(CursorHandle handle, float horizontal, float vertical)
        {
            HCursor hcursor = handle.As<HCursor>(this);

            throw new NotSupportedException("Cannot scale cursor on windows.");
        }
    }
}

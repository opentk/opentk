using OpenTK.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Platform.Native.Windows.Win32;

namespace OpenTK.Platform.Native.Windows
{
    public class CursorComponent : ICursorComponent
    {
        /// <inheritdoc/>
        public string Name => "Win32CursorComponent";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.MouseCursor;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.MouseCursor)
            {
                throw new Exception("CursorComponent can only initialize the MouseCursor component.");
            }
        }

        /// <inheritdoc/>
        public bool CanLoadSystemCursors => true;

        /// <inheritdoc/>
        public bool CanInspectSystemCursors => true;

        /// <inheritdoc/>
        public CursorHandle Create(SystemCursorType systemCursor)
        {
            HCursor hcursor = new HCursor();

            OCR ocr;
            switch (systemCursor)
            {
                case SystemCursorType.Default:
                    ocr = OCR.Normal;
                    break;
                case SystemCursorType.Loading:
                    ocr = OCR.AppStarting;
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
                case SystemCursorType.ArrowN:
                case SystemCursorType.ArrowS:
                case SystemCursorType.ArrowNS:
                    ocr = OCR.SizeNS;
                    break;
                case SystemCursorType.ArrowW:
                case SystemCursorType.ArrowE:
                case SystemCursorType.ArrowEW:
                    ocr = OCR.SizeWE;
                    break;
                case SystemCursorType.ArrowNE:
                case SystemCursorType.ArrowSW:
                case SystemCursorType.ArrowNESW:
                    ocr = OCR.SizeNESW;
                    break;
                case SystemCursorType.ArrowNW:
                case SystemCursorType.ArrowSE:
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
                throw new Win32Exception();
            }

            return hcursor;
        }

        /// <inheritdoc/>
        public unsafe CursorHandle Create(int width, int height, ReadOnlySpan<byte> image, int hotspotX, int hotspotY)
        {
            HCursor hcursor = new HCursor();

            if (width < 0) throw new ArgumentOutOfRangeException($"Width cannot be negative. Value: {width}");
            if (height < 0) throw new ArgumentOutOfRangeException($"Height cannot be negative. Value: {height}");

            if (image.Length < width * height * 4) throw new ArgumentException($"The given span is too small. It must be at least {width * height * 4} long. Was: {image.Length}");

            // See https://web.archive.org/web/20080205042408/http://support.microsoft.com/kb/318876
            Win32.BITMAPV5HEADER header = default;
            header.bV5Size = (uint)sizeof(Win32.BITMAPV5HEADER);
            header.bV5Width = width;
            header.bV5Height = -height;
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
                throw new Win32Exception();
            }

            Span<byte> data = new Span<byte>(dataPtr.ToPointer(), width * height * 4);

            // Copy over image data.
            // R,G,B,A byte order to B,G,R,A byte order.
            for (int i = 0; i < data.Length; i += 4)
            {
                data[i + 0] = image[i + 2];
                data[i + 1] = image[i + 1];
                data[i + 2] = image[i + 0];
                data[i + 3] = image[i + 3];
            }

            // Create an empty mask.
            IntPtr maskBitmap = Win32.CreateBitmap(width, height, 1, 1, IntPtr.Zero);
            // FIXME: The value if ERROR_INVALID_BITMAP is impossible to find.
            // It's not defined in wingdi.h and nothing online mentions it.
            if (maskBitmap == IntPtr.Zero /*|| maskBitmap == Win32.ERROR_INVALID_BITMAP*/)
            {
                throw new Win32Exception();
            }

            Win32.ICONINFO iconinfo = new Win32.ICONINFO()
            {
                fIcon = false, // We are creating a cursor
                xHotspot = hotspotX,
                yHotspot = hotspotY,
                hbmMask = maskBitmap,
                hbmColor = colorBitmap,
            };

            IntPtr hcursorIcon = Win32.CreateIconIndirect(in iconinfo);
            if (hcursorIcon == IntPtr.Zero)
            {
                throw new Win32Exception();
            }

            Win32.ReleaseDC(IntPtr.Zero, hDC);

            hcursor.Cursor = hcursorIcon;
            hcursor.MaskBitmap = maskBitmap;
            hcursor.ColorBitmap = colorBitmap;
            hcursor.Mode = HCursor.CursorMode.Icon;

            return hcursor;
        }

        /// <inheritdoc/>
        public CursorHandle Create(int width, int height, ReadOnlySpan<byte> colorData, ReadOnlySpan<byte> maskData, int hotspotX, int hotspotY)
        {
            HCursor hcursor = new HCursor();

            if (width < 0) throw new ArgumentOutOfRangeException(nameof(width), $"Width cannot be negative. Value: {width}");
            if (height < 0) throw new ArgumentOutOfRangeException(nameof(height), $"Height cannot be negative. Value: {height}");

            if (colorData.Length < width * height * 3) throw new ArgumentException($"The given color data span is too small. It must be at least {width * height * 3} long. Was: {colorData.Length}");
            if (maskData.Length < width * height * 1) throw new ArgumentException($"The given mask data span is too small. It must be at least {width * height * 1} long. Was: {maskData.Length}");

            // See https://www.codeguru.com/windows/creating-a-color-cursor-from-a-bitmap
            IntPtr hDC = Win32.GetDC(IntPtr.Zero);
            IntPtr hAndMaskDC = Win32.CreateCompatibleDC(hDC);
            if (hAndMaskDC == IntPtr.Zero) throw new Win32Exception();
            IntPtr hXorMaskDC = Win32.CreateCompatibleDC(hDC);
            if (hXorMaskDC == IntPtr.Zero) throw new Win32Exception();

            // Make sure to call CreateCompatibleBitmap with the window DC as the
            // newly created DC is initialized with a mono-chromatic 1x1 pixel bitmap by default.
            // And we don't want to create a bitmap with a monochrome format.
            // See https://www.codeproject.com/Articles/224754/Guide-to-Win32-Memory-DC#:~:text=Avoid%20a%20Common%20Mistake
            IntPtr hAndMaskBitmap = Win32.CreateCompatibleBitmap(hDC, width, height);
            if (hAndMaskBitmap == IntPtr.Zero) throw new Win32Exception();
            IntPtr hXorMaskBitmap = Win32.CreateCompatibleBitmap(hDC, width, height);
            if (hXorMaskBitmap == IntPtr.Zero) throw new Win32Exception();

            IntPtr hOldAndMaskBitmap = Win32.SelectObject(hAndMaskDC, hAndMaskBitmap);
            if (hOldAndMaskBitmap == IntPtr.Zero) throw new Win32Exception();
            IntPtr hOldXorMaskBitmap = Win32.SelectObject(hXorMaskDC, hXorMaskBitmap);
            if (hOldXorMaskBitmap == IntPtr.Zero) throw new Win32Exception();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int index = (x + (y * width)) * 3;

                    uint mask = (uint)maskData[x + (y * width)] == 1 ? 0x00_FF_FF_FFu : 0x00_00_00_00u;
                    uint color = (uint)colorData[index + 0] << 0 | (uint)colorData[index + 1] << 8 | (uint)colorData[index + 2] << 16;

                    int success;
                    success = Win32.SetPixelV(hAndMaskDC, x, y, mask);
                    if (success == 0) throw new Win32Exception();
                    success = Win32.SetPixelV(hXorMaskDC, x, y, color);
                    if (success == 0) throw new Win32Exception();
                }
            }

            // Select the old objects again, as stated we should in the documentation.
            Win32.SelectObject(hAndMaskDC, hOldAndMaskBitmap);
            Win32.SelectObject(hXorMaskDC, hOldXorMaskBitmap);

            bool deleted;
            deleted = Win32.DeleteDC(hAndMaskDC);
            if (deleted == false) throw new Win32Exception();
            deleted = Win32.DeleteDC(hXorMaskDC);
            if (deleted == false) throw new Win32Exception();

            Win32.ReleaseDC(IntPtr.Zero, hDC);

            Win32.ICONINFO iconinfo = new Win32.ICONINFO()
            {
                fIcon = false, // We are creating a cursor
                xHotspot = hotspotX,
                yHotspot = hotspotY,
                hbmMask = hAndMaskBitmap,
                hbmColor = hXorMaskBitmap,
            };

            IntPtr hcursorIcon = Win32.CreateIconIndirect(in iconinfo);
            if (hcursorIcon == IntPtr.Zero)
            {
                throw new Win32Exception();
            }

            hcursor.Cursor = hcursorIcon;
            hcursor.MaskBitmap = hAndMaskBitmap;
            hcursor.ColorBitmap = hXorMaskBitmap;
            hcursor.Mode = HCursor.CursorMode.Icon;

            return hcursor;
        }

        // FIXME: Document if you can get the size and hotspot of these cursors?

        /// <summary>
        /// Creates a cursor from a .cur file.
        /// </summary>
        /// <remarks>
        /// Handles created by this method will work in <see cref="GetSize(CursorHandle, out int, out int)"/> and <see cref="GetHotspot(CursorHandle, out int, out int)"/>.
        /// </remarks>
        /// <param name="file">The .cur file to load.</param>
        /// <exception cref="FileNotFoundException"></exception>
        public CursorHandle CreateFromCurFile(string file)
        {
            HCursor hcursor = new HCursor();

            IntPtr cursor = Win32.LoadCursorFromFile(file);
            if (cursor == IntPtr.Zero)
            {
                // FIXME: Find out if we failed because of the wrong format!
                int error = Marshal.GetLastWin32Error();
                if (error == Win32.ERROR_FILE_NOT_FOUND)
                {
                    throw new FileNotFoundException($"Could not find file: '{file}'", file);
                }
                else
                {
                    throw new Win32Exception(error);
                }
            }

            hcursor.Cursor = cursor;
            hcursor.Mode = HCursor.CursorMode.FileIcon;

            return hcursor;
        }

#pragma warning disable CS0649 // Field '' is never assigned to, and will always have its default value 0
        private struct ICONDIR
        {
            public ushort idReserved;   // Reserved (must be 0)
            public ushort idType;       // Resource Type (1 for icons)
            public ushort idCount;      // How many images?
        }

        private struct CURSORDIRENTRY
        {
            public byte bWidth;          // Width, in pixels, of the image
            public byte bHeight;         // Height, in pixels, of the image
            public byte bColorCount;     // Number of colors in image (0 if >=8bpp)
            public byte bReserved;       // Reserved ( must be 0)
            public ushort wHotSpotX;         // Color Planes
            public ushort wHotSpotY;       // Bits per pixel
            public uint dwBytesInRes;    // How many bytes in this resource?
            public uint dwImageOffset;   // Where in the file is this image?
        }
#pragma warning restore CS0649 // Field '' is never assigned to, and will always have its default value 0

        /// <remarks>
        /// Currently this function does not work with .ani files.
        /// </remarks>
        public unsafe CursorHandle CreateFromCurResorce(byte[] resource)
        {
            HCursor hcursor = new HCursor();

            fixed (byte* ptr = resource)
            {
                int offset = Win32.LookupIconIdFromDirectoryEx(ptr, false, 0, 0, LR.DefaultColor | LR.DefaultSize);
                if (offset == 0)
                {
                    throw new Win32Exception();
                }

                // The .cur file format is unfortunately not compatible with the cursor resource format.
                // The difference is that the file format stores the hotspot in the DIRENTRY while
                // the resource format prepends the hotspot before the BITMAPINFOHEADER.
                // Because of this we need to first find the DIRENTRY that LookupIconIdFromDirectoryEx selected
                // Then we need to extract the hotspot and resource byte count so that we can then
                // allocate an aligned buffer (does it need to be aligned?) where we can first put in
                // the hotspot followed by the complete resource data.
                // I don't like this solution, but it's the best one I can figure out.
                // - Noggin_bops 2023-09-10

                ICONDIR* dir = (ICONDIR*)(ptr);
                int count = dir->idCount;

                uint bytes = 0;
                ushort hotspotx = 0, hotspoty = 0;
                CURSORDIRENTRY* image = (CURSORDIRENTRY*)(ptr + sizeof(ICONDIR));
                for (int i = 0; i < count; i++)
                {
                    CURSORDIRENTRY* cursorEntry = &image[i];

                    if (offset == cursorEntry->dwImageOffset)
                    {
                        hotspotx = cursorEntry->wHotSpotX;
                        hotspoty = cursorEntry->wHotSpotY;
                        bytes = cursorEntry->dwBytesInRes;
                    }
                }

                byte* data = (byte*)NativeMemory.AlignedAlloc(bytes + 4, (nuint)IntPtr.Size);

                // Set the hotspot.
                *(ushort*)(data + 0) = hotspotx;
                *(ushort*)(data + 2) = hotspoty;

                NativeMemory.Copy(ptr + offset, data + 4, bytes);

                IntPtr cursor = Win32.CreateIconFromResourceEx(data, bytes + 4, false, 0x00030000, 0, 0, LR.DefaultColor | LR.DefaultSize);

                NativeMemory.Free(data);

                if (cursor == IntPtr.Zero)
                {
                    throw new Win32Exception();
                }

                hcursor.Cursor = cursor;
            }

            hcursor.Mode = HCursor.CursorMode.FileIcon;

            return hcursor;
        }

        /// <summary>
        /// Creates a cursor from a resource name.
        /// </summary>
        /// <remarks>
        /// To use this function you need to create and include a resource file in your exe.
        /// To do this, first create a .rc resource definition file and include your icon.
        /// Then you need to compile that file into a .res file using rc.exe, the resource compiler.
        /// Lastly you need to include that .res file in your csproj using the &lt;Win32Resource&gt; property.
        /// FIXME: Write a guide on how to compile .rc files and include a .res file using &lt;Win32Resource&gt;.
        /// </remarks>
        /// <param name="resourceName">The name of the icon resource to load.</param>
        public unsafe CursorHandle CreateFromCurResorce(string resourceName)
        {
            HCursor hcursor = new HCursor();

            IntPtr cursor = Win32.LoadCursor(WindowComponent.HInstance, resourceName);

            hcursor.Cursor = cursor;
            hcursor.Mode = HCursor.CursorMode.FileIcon;

            return hcursor;
        }

        /// <inheritdoc/>
        public void Destroy(CursorHandle handle)
        {
            HCursor hcursor = handle.As<HCursor>(this);

            switch (hcursor.Mode)
            {
                // FIXME: Do we need this enum value anymore?
                // Maybe change the name to something like, deleted or destroyed?
                case HCursor.CursorMode.Uninitialized:
                    {
                        // Do nothing.
                        break;
                    }
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
                            throw new Win32Exception();
                        }

                        // Delete the mask and color bitmaps.
                        Win32.DeleteObject(hcursor.MaskBitmap);
                        Win32.DeleteObject(hcursor.ColorBitmap);
                        break;
                    }
                case HCursor.CursorMode.FileIcon:
                    {
                        // Cursors loaded with Win32.LoadCursorFromFile are shared so we should not delete them.
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

        /// <inheritdoc/>
        public bool IsSystemCursor(CursorHandle handle)
        {
            HCursor hcursor = handle.As<HCursor>(this);
            return hcursor.Mode == HCursor.CursorMode.SystemCursor;
        }

        /// <inheritdoc/>
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
            else
            {
                throw new Win32Exception();
            }
        }

        /// <inheritdoc/>
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
                throw new Win32Exception();
            }
        }

        /// <summary>
        /// Get the mouse cursor image.
        /// </summary>
        /// <remarks>
        /// This method works for all cursors, even system cursors.
        /// </remarks>
        /// <param name="handle">Handle to a cursor object.</param>
        /// <param name="image">Buffer to copy cursor image into.</param>
        /// <exception cref="ArgumentNullException"><paramref name="handle"/> is null.</exception>
        // FIXME: Document the format of the return image!
        // Maybe we don't care about this function? - Noggin_bops 2023-09-10
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
                    throw new Win32Exception();
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
                        throw new Exception($"GetDIBits failed. (0x{success:X})");
                    }

                    if (image.Length < bmInfo.bmiHeader.biSizeImage)
                    {
                        throw new Exception($"Image buffer not big enough! Expected: {bmInfo.bmiHeader.biSizeImage} bytes, got {image.Length} bytes");
                    }

                    bmInfo.bmiHeader.biBitCount = 32;
                    bmInfo.bmiHeader.biPlanes = 1;
                    bmInfo.bmiHeader.biCompression = BI.RGB;

                    fixed (byte* ptr = image)
                    {
                        success = Win32.GetDIBits(hDC, hbm, 0, (uint)bmInfo.bmiHeader.biHeight, (void*)ptr, ref bmInfo, DIB.RGBColors);
                        if (success == 0 || success == Win32.ERROR_INVALID_PARAMETER)
                        {
                            throw new Exception($"GetDIBits failed. (0x{success:X})");
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
                throw new Win32Exception();
            }

            bool successBool = Win32.DestroyIcon(cursor_copy);
            if (successBool == false)
            {
                throw new Win32Exception();
            }
        }
    }
}

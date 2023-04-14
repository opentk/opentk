using OpenTK.Core.Platform;
using OpenTK.Core.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Platform.Native.Windows
{
    public class IconComponent : IIconComponent
    {
        /// <inheritdoc/>
        public string Name => "Win32IconComponent";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.WindowIcon;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <inheritdoc/>
        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.WindowIcon)
            {
                throw new Exception("IconComponent can only initialize the WindowIcon component.");
            }
        }

        /// <inheritdoc/>
        public bool CanLoadSystemIcon => true;

        /// <inheritdoc/>
        public IconHandle Create()
        {
            return new HIcon();
        }

        /// <inheritdoc/>
        public void Destroy(IconHandle handle)
        {
            HIcon hicon = handle.As<HIcon>(this);

            switch (hicon.Mode)
            {
                case HIcon.IconMode.Uninitialized:
                    // Do nothing.
                    break;
                case HIcon.IconMode.SystemIcon:
                    // This is a shared icon, so we shouldn't destroy it.
                    break;
                case HIcon.IconMode.Icon:
                    {
                        bool success = Win32.DestroyIcon(hicon.Icon);
                        if (success == false)
                        {
                            throw new Win32Exception("DestroyIcon failed.");
                        }

                        // Delete the mask and color bitmaps.
                        Win32.DeleteObject(hicon.MaskBitmap);
                        Win32.DeleteObject(hicon.ColorBitmap);
                        break;
                    }
                case HIcon.IconMode.FileIcon:
                    {
                        // Documentation for LoadImage says we should release the icon like this.
                        Win32.DestroyIcon(hicon.Icon);
                        break;
                    }
                default:
                    throw new InvalidOperationException($"Unknown cursor mode: {hicon.Mode}.");
            }

            hicon.Mode = HIcon.IconMode.Uninitialized;
            hicon.Icon = default;
            hicon.MaskBitmap = default;
            hicon.ColorBitmap = default;
        }

        /// <inheritdoc/>
        public unsafe void GetDimensions(IconHandle handle, out int width, out int height)
        {
            HIcon hicon = handle.As<HIcon>(this);

            width = 0;
            height = 0;

            // See https://stackoverflow.com/a/13295280
            if (Win32.GetIconInfo(hicon.Icon, out Win32.ICONINFO info))
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
        public unsafe void GetBitmapData(IconHandle handle, Span<byte> data)
        {
            HIcon hicon = handle.As<HIcon>(this);

            // FIXME: If this icon is one of the standard icons
            // we want to call CopyIcon so that we can call GetIconInfo properly!
            IntPtr cursor_copy = Win32.CopyIcon(hicon.Icon);
            {
                Win32.CURSORINFO cinfo = default;
                cinfo.cbSize = (uint)sizeof(Win32.CURSORINFO);
                if (Win32.GetCursorInfo(ref cinfo) == false)
                    throw new Win32Exception("GetCursorInfo failed.");
            }

            // See https://stackoverflow.com/a/13295280
            if (Win32.GetIconInfo(cursor_copy, out Win32.ICONINFO info))
            {
                static void GetImage(IntPtr hDC, IntPtr hbm, Span<byte> image)
                {
                    Win32.BITMAPINFO bmInfo = default;
                    bmInfo.bmiHeader.biSize = (uint)sizeof(Win32.BITMAPINFOHEADER);
                    int success = Win32.GetDIBits(hDC, hbm, 0, 0, null, ref bmInfo, DIB.RGBColors);
                    if (success == 0 || success == Win32.ERROR_INVALID_PARAMETER)
                    {
                        throw new Exception("GetDIBits failed.");
                    }

                    // FIXME: biSizeImage can be 0 if biCompression = RGB
                    if (image.Length < bmInfo.bmiHeader.biSizeImage)
                    {
                        throw new Exception("Image buffer not big enough!");
                    }

                    // Force the bitmap to be top-down.
                    bmInfo.bmiHeader.biHeight = -Math.Abs(bmInfo.bmiHeader.biHeight);

                    bmInfo.bmiHeader.biBitCount = 32;
                    bmInfo.bmiHeader.biPlanes = 1;
                    bmInfo.bmiHeader.biCompression = BI.RGB;

                    fixed (byte* ptr = image)
                    {
                        success = Win32.GetDIBits(hDC, hbm, 0, (uint)Math.Abs(bmInfo.bmiHeader.biHeight), (void*)ptr, ref bmInfo, DIB.RGBColors);
                        if (success == 0 || success == Win32.ERROR_INVALID_PARAMETER)
                        {
                            throw new Exception("GetDIBits failed.");
                        }
                    }

                    if (bmInfo.bmiHeader.biHeight < 0)
                    {
                        // FIXME: Overflow?
                        bmInfo.bmiHeader.biHeight = -bmInfo.bmiHeader.biHeight;
                        
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
                    GetImage(hDC, info.hbmMask, data);

                    // Here we apply the mask over a white background
                    // And at the same time generate an alpha mask.
                    for (int i = 0; i < data.Length; i += 4)
                    {
                        // We also convert from Bgra to Rgba here.
                        data[i + 0] = (byte)(0xFF ^ data[i + 2]);
                        data[i + 2] = (byte)(0xFF ^ data[i + 0]);
                        data[i + 1] = (byte)(0xFF ^ data[i + 1]);

                        // If the resulting color pure white we set alpha to 0,
                        // otherwise we set it to 255.
                        if (data[i + 0] == 0xFF && data[i + 1] == 0xFF && data[i + 2] == 0xFF)
                        {
                            // The final color is pure white
                            data[i + 3] = 0x00;
                        }
                        else
                        {
                            // The final color not pure white, so we set alpha.
                            data[i + 3] = 0xFF;
                        }
                    }
                }
                else
                {
                    GetImage(hDC, info.hbmColor, data);

                    // Convert from Bgra to Rgba.
                    for (int i = 0; i < data.Length; i += 4)
                    {
                        (data[i + 0], data[i + 2]) = (data[i + 2], data[i + 0]);
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

        /// <inheritdoc/>
        public unsafe int GetBitmapByteSize(IconHandle handle)
        {
            HIcon hicon = handle.As<HIcon>(this);

            int size;

            // See https://stackoverflow.com/a/13295280
            if (Win32.GetIconInfo(hicon.Icon, out Win32.ICONINFO info))
            {
                bool bwCursor = info.hbmColor == IntPtr.Zero;
                if (Win32.GetObject(info.hbmMask, sizeof(Win32.BITMAP), out Win32.BITMAP bmpInfo) != 0)
                {
                    int width = bmpInfo.bmWidth;
                    int height = bmpInfo.bmHeight / (bwCursor ? 2 : 1);

                    size = width * height * 4;
                }
                else
                {
                    throw new PalException(this, $"GetObject failed. (hbm: {info.hbmMask})");
                }

                Win32.DeleteObject(info.hbmColor);
                Win32.DeleteObject(info.hbmMask);
            }
            else
            {
                throw new Win32Exception();
            }

            return size;
        }

        /// <inheritdoc/>
        public unsafe void Load(IconHandle handle, int width, int height, ReadOnlySpan<byte> data)
        {
            HIcon hicon = handle.As<HIcon>(this);

            if (width < 0) throw new ArgumentOutOfRangeException($"Width cannot be negative. Value: {width}");
            if (height < 0) throw new ArgumentOutOfRangeException($"Height cannot be negative. Value: {height}");

            if (data.Length < width * height * 4) throw new ArgumentException($"The given span is too small. It must be at least {width * height * 4} long. Was: {data.Length}");

            // FIXME: Figure out if we should destroy the previous icon like this.
            Destroy(handle);

            // See https://web.archive.org/web/20080205042408/http://support.microsoft.com/kb/318876
            Win32.BITMAPV5HEADER header = default;
            header.bV5Size = (uint)sizeof(Win32.BITMAPV5HEADER);
            header.bV5Width = width;
            header.bV5Height = -height;
            header.bV5Planes = 1;
            header.bV5BitCount = 32;
            header.bV5Compression = BI.Bitfields;
            // For some reason setting these masks to a proper ARGB format (or R, G, B, A as individual bytes) doesn't result in alpha.
            // As such we are going to have to swizzle the data.
            // - Noggin_Bops 2023-04-14
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

            Span<byte> bitmapData = new Span<byte>(dataPtr.ToPointer(), width * height * 4);

            // Copy over image data.
            // R,G,B,A byte order to B,G,R,A byte order.
            for (int i = 0; i < data.Length; i += 4)
            {
                bitmapData[i + 0] = data[i + 2];
                bitmapData[i + 1] = data[i + 1];
                bitmapData[i + 2] = data[i + 0];
                bitmapData[i + 3] = data[i + 3];
            }

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
                fIcon = true, // We are creating a icon
                xHotspot = 0,
                yHotspot = 0,
                hbmMask = maskBitmap,
                hbmColor = colorBitmap,
            };

            IntPtr hIcon = Win32.CreateIconIndirect(in iconinfo);
            if (hIcon == IntPtr.Zero)
            {
                throw new Win32Exception("CreateIconIndirect() failed.");
            }

            Win32.ReleaseDC(IntPtr.Zero, hDC);

            hicon.Icon = hIcon;
            hicon.MaskBitmap = maskBitmap;
            hicon.ColorBitmap = colorBitmap;
            hicon.Mode = HIcon.IconMode.Icon;
        }

        /// <summary>
        /// Loads a windows .ico file.
        /// </summary>
        /// <param name="handle">Handle to an icon object.</param>
        /// <param name="file">The icon file to load.</param>
        public void LoadIcoFile(IconHandle handle, string file)
        {
            HIcon hicon = handle.As<HIcon>(this);

            Destroy(hicon);

            IntPtr icon = Win32.LoadImage(IntPtr.Zero, file, ImageType.Icon, 0, 0, LR.LoadFromFile | LR.DefaultSize);
            if (icon == IntPtr.Zero)
            {
                throw new Win32Exception();
            }

            hicon.Icon = icon;
            hicon.Mode = HIcon.IconMode.FileIcon;
        }

        /// <inheritdoc/>
        public void Load(IconHandle handle, SystemIconType systemIcon)
        {
            HIcon hicon = handle.As<HIcon>(this);

            Destroy(hicon);

            OIC oic = default;
            switch (systemIcon)
            {
                case SystemIconType.Default:
                    oic = OIC.WinLogo;
                    break;
                case SystemIconType.Asterisk:
                    // FIXME
                    oic = OIC.Information;
                    break;
                case SystemIconType.Error:
                    oic = OIC.Error;
                    break;
                case SystemIconType.Exclamation:
                    oic = OIC.Bang;
                    break;
                case SystemIconType.Hand:
                    oic = OIC.Hand;
                    break;
                case SystemIconType.Information:
                    oic = OIC.Information;
                    break;
                case SystemIconType.Question:
                    oic = OIC.Ques;
                    break;
                case SystemIconType.Shield:
                    oic = OIC.Shield;
                    break;
                case SystemIconType.Warning:
                    oic = OIC.Warning;
                    break;
                case SystemIconType.OperatingSystem:
                    // FIXME how do we get this?
                    oic = OIC.WinLogo;
                    break;
                default:
                    throw new InvalidEnumArgumentException(nameof(systemIcon), (int)systemIcon, typeof(SystemIconType));
            }

            hicon.Icon = Win32.LoadImage(IntPtr.Zero, oic, ImageType.Icon, 0, 0, LR.Shared | LR.DefaultSize);
            hicon.Mode = HIcon.IconMode.SystemIcon;
        }
    }
}

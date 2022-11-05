using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Core.Platform;

namespace OpenTK.Platform.Native.Windows
{
    public class ClipboardComponent : IClipboardComponent
    {
        // FIXME: Some way to specify the
        // "ExcludeClipboardContentFromMonitorProcessing",
        // "CanIncludeInClipboardHistory", or
        // "CanUploadToCloudClipboard"
        // on win32 to handle cloud clipboards.

        public string Name => "Win32 Clipboard component";

        public PalComponents Provides => PalComponents.Clipboard;

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Clipboard)
            {
                throw new PalException(this, "ClipboardComponent can only initialize the Clipboard component.");
            }

            // Get the HTML format
            CF_HTML = Win32.RegisterClipboardFormat("HTML Format");
            if (CF_HTML == 0)
            {
                throw new Win32Exception();
            }
        }

        // (0xC095): Rich Text Format
        private static CF CF_HTML;

        public IReadOnlyList<ClipboardFormat> SupportedFormats => _SupportedFormats;

        private static readonly ClipboardFormat[] _SupportedFormats = new[]
        {
            ClipboardFormat.Text,
            ClipboardFormat.HTML,
            ClipboardFormat.Files,
        };

        public ClipboardFormat GetClipboardFormat()
        {
            bool success = Win32.OpenClipboard(WindowComponent.HelperHWnd);
            if (success == false)
            {
                throw new Win32Exception();
            }

            StringBuilder name = new StringBuilder(1024);

            ClipboardFormat format = ClipboardFormat.None;

            CF cf = 0;
            while (format == ClipboardFormat.None && (cf = Win32.EnumClipboardFormats(cf)) != 0)
            {
                switch (cf)
                {
                    case CF.HDrop:
                        format = ClipboardFormat.Files;
                        break;
                    case CF.UnicodeText:
                        format = ClipboardFormat.Text;
                        break;
                    case CF.Bitmap:
                    case CF.DIB:
                    case CF.DIBV5:
                        // All of these formats can be synthesized into CF_BITMAP.
                        // https://learn.microsoft.com/en-us/windows/win32/dataxchg/clipboard-formats#synthesized-clipboard-formats
                        format = ClipboardFormat.Bitmap;
                        break;
                    default:
                        if (cf == CF_HTML)
                        {
                            format = ClipboardFormat.HTML;
                            break;
                        }
                        break;
                }

                if ((uint)cf > 0xC000u && (uint)cf < 0xFFFFu)
                {
                    int length = Win32.GetClipboardFormatName(cf, name, name.Capacity);
                    if (length == 0)
                    {
                        throw new Win32Exception();
                    }

                    Console.WriteLine($"Format (0x{(uint)cf:X4}): {name}");
                }
                else
                {
                    Console.WriteLine($"Format (0x{(uint)cf:X4}): {cf}");
                }
            }

            int error = Marshal.GetLastWin32Error();
            if (error != 0)
            {
                throw new Win32Exception();
            }

            success = Win32.CloseClipboard();
            if (success == false)
            {
                throw new Win32Exception();
            }

            return format;
        }

        public unsafe void SetClipboardText(string text)
        {
            ReadOnlySpan<char> textData = text.AsSpan();

            int bytes = textData.Length * sizeof(char) + 2;

            IntPtr hmem = Win32.GlobalAlloc(GMEM.Moveable, (ulong)bytes);
            if (hmem == IntPtr.Zero)
            {
                throw new Win32Exception();
            }

            {
                char* memory = (char*)Win32.GlobalLock(hmem);
                if (memory == null)
                {
                    int error = Marshal.GetLastWin32Error();
                    Win32.GlobalFree(hmem);
                    throw new Win32Exception(error);
                }

                Span<char> memorySpan = new Span<char>(memory, bytes);

                // Copy over the string.
                textData.CopyTo(memorySpan);

                // Write null terminator.
                memorySpan[^1] = '\0';

                bool stillLocked = Win32.GlobalUnlock(hmem);
                if (stillLocked == false)
                {
                    // If the function returns NO_ERROR then there is no error.
                    int errorCode = Marshal.GetLastWin32Error();
                    if (errorCode != 0)
                    {
                        throw new Win32Exception(errorCode);
                    }
                }
            }
            
            bool success = Win32.OpenClipboard(WindowComponent.HelperHWnd);
            if (success == false)
            {
                int error = Marshal.GetLastWin32Error();
                Win32.GlobalFree(hmem);
                throw new Win32Exception(error);
            }

            Win32.EmptyClipboard();

            Win32.SetClipboardData(CF.UnicodeText, hmem);

            Win32.CloseClipboard();
        }

        public unsafe string? GetClipboardText()
        {
            bool success = Win32.OpenClipboard(WindowComponent.HelperHWnd);
            if (success == false)
            {
                throw new Win32Exception();
            }

            IntPtr obj = Win32.GetClipboardData(CF.UnicodeText);
            if (obj == IntPtr.Zero)
            {
                // We couldn't get any text.
                return null;
            }

            char* strData = (char*)Win32.GlobalLock(obj);
            if (strData == null)
            {
                throw new Win32Exception();
            }

            // FIXME: Can this fail? Or is this a security issue?
            string str = new string(strData);

            bool stillLocked = Win32.GlobalUnlock(obj);
            if (stillLocked)
            {
                // If the function returns NO_ERROR then there is no error.
                int errorCode = Marshal.GetLastWin32Error();
                if (errorCode != 0)
                {
                    throw new Win32Exception(errorCode);
                }
            }

            bool succeess = Win32.CloseClipboard();
            if (succeess == false)
            {
                throw new Win32Exception();
            }

            return str;
        }

        public object? GetClipboardAudio()
        {
            throw new NotImplementedException();
        }

        public unsafe Bitmap? GetClipboardBitmap()
        {
            bool success = Win32.OpenClipboard(WindowComponent.HelperHWnd);
            if (success == false)
            {
                throw new Win32Exception();
            }

            IntPtr hbitmap = Win32.GetClipboardData(CF.Bitmap);
            if (hbitmap == IntPtr.Zero)
            {
                // We couldn't get a bitmap.
                return null;
            }

            IntPtr hDC = Win32.GetDC(IntPtr.Zero);

            int width = 0;
            int height = 0;
            if (Win32.GetObject(hbitmap, sizeof(Win32.BITMAP), out Win32.BITMAP bmpInfo) != 0)
            {
                width = bmpInfo.bmWidth;
                height = bmpInfo.bmHeight;
            }
            else
            {
                Win32.CloseClipboard();
                throw new Exception("Failed to get clipboard bitmap!");
            }

            byte[] image = new byte[width * height * 4];

            GetImage(hDC, hbitmap, image);

            // Convert from Bgra to Rgba.
            for (int i = 0; i < image.Length; i += 4)
            {
                (image[i + 0], image[i + 2]) = (image[i + 2], image[i + 0]);
            }

            bool succeess = Win32.CloseClipboard();
            if (succeess == false)
            {
                throw new Win32Exception();
            }

            // FIXME: This is the same as in IconComponent, we might want to fix that!
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

            return new Bitmap(width, height, image);
        }

        public unsafe string? GetClipboardHTML()
        {
            bool success = Win32.OpenClipboard(WindowComponent.HelperHWnd);
            if (success == false)
            {
                throw new Win32Exception();
            }

            IntPtr obj = Win32.GetClipboardData(CF_HTML);
            if (obj == IntPtr.Zero)
            {
                // We couldn't get any text.
                return null;
            }

            int strSize = (int)Win32.GlobalSize(obj);
            if (strSize == 0)
            {
                throw new Win32Exception();
            }

            byte* strData = (byte*)Win32.GlobalLock(obj);
            if (strData == null)
            {
                throw new Win32Exception();
            }

            // FIXME: Can this fail? Or is this a security issue?
            string str = Encoding.UTF8.GetString(strData, strSize);

            bool stillLocked = Win32.GlobalUnlock(obj);
            if (stillLocked)
            {
                // If the function returns NO_ERROR then there is no error.
                int errorCode = Marshal.GetLastWin32Error();
                if (errorCode != 0)
                {
                    throw new Win32Exception(errorCode);
                }
            }

            bool succeess = Win32.CloseClipboard();
            if (succeess == false)
            {
                throw new Win32Exception();
            }

            return str;
        }

        public List<string>? GetClipboardFiles()
        {
            bool success = Win32.OpenClipboard(WindowComponent.HelperHWnd);
            if (success == false)
            {
                throw new Win32Exception();
            }

            IntPtr hdrop = Win32.GetClipboardData(CF.HDrop);
            if (hdrop == IntPtr.Zero)
            {
                // We couldn't get any text.
                return null;
            }

            uint count = Win32.DragQueryFile(hdrop, 0xFFFFFFFF, null, 0);
            Console.WriteLine($"Drop! {count}");

            List<string> paths = new List<string>();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                uint size = Win32.DragQueryFile(hdrop, (uint)i, null, 0);

                //  size does not include null terminator.
                sb.EnsureCapacity((int)size + 1);

                uint querySuccess = Win32.DragQueryFile(hdrop, (uint)i, sb, (uint)sb.Capacity);
                if (querySuccess == 0)
                {
                    // FIXME: Is is an issue? Can this happen?
                    throw new Exception();
                }

                paths.Add(sb.ToString());
            }

            bool succeess = Win32.CloseClipboard();
            if (succeess == false)
            {
                throw new Win32Exception();
            }

            return paths;
        }
    }
}

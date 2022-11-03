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
    // FIXME: Some way to get the plain text version of HTML.

    public class ClipboardComponent : IClipboardComponent
    {
        public string Name => "Win32 Clipboard component";

        public PalComponents Provides => PalComponents.Clipboard;

        public void Initialize(PalComponents which)
        {
            if (which != PalComponents.Clipboard)
            {
                throw new PalException(this, "ClipboardComponent can only initialize the Clipboard component.");
            }
        }

        public IReadOnlyList<ClipboardFormat> SupportedFormats => _SupportedFormats;

        private static readonly ClipboardFormat[] _SupportedFormats = new[]
        {
            ClipboardFormat.Text,
            ClipboardFormat.HTML,
            ClipboardFormat.Files,
        };

        private const CF CF_HTML = (CF)0xC11E;

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
                    case CF_HTML:
                        format = ClipboardFormat.HTML;
                        break;
                    case CF.HDrop:
                        format = ClipboardFormat.Files;
                        break;
                    case CF.UnicodeText:
                        format = ClipboardFormat.Text;
                        break;
                    default:
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

        public object? GetClipboardBitmap()
        {
            throw new NotImplementedException();
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

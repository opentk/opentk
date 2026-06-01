using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Platform;
using OpenTK.Core.Utility;

namespace OpenTK.Platform.Native.Windows
{
    public class ClipboardComponent : IClipboardComponent
    {
        /// <inheritdoc/>
        public string Name => "Win32ClipboardComponent";

        /// <inheritdoc/>
        public PalComponents Provides => PalComponents.Clipboard;

        /// <inheritdoc/>
        public ILogger? Logger { get; set; }

        /// <summary>
        /// If this property is not null when setting the clipboard <c>CanIncludeInClipboardHistory</c> will be added to the clipboard format
        /// to either disable clipboard history or explicitly request the clipboard to be included in the histroy.
        ///
        /// See documentation: <see href="https://learn.microsoft.com/en-us/windows/win32/dataxchg/clipboard-formats#cloud-clipboard-and-clipboard-history-formats"/>
        /// </summary>
        public bool? CanIncludeInClipboardHistory { get; set; }

        /// <summary>
        /// If this property is not null when setting the clipboard <c>CanUploadToCloudClipboard</c> will be added to the clipboard format
        /// to either disable the value set in the clipboard from syncing to the users devices, or request that it be syncronized with the users other devices.
        ///
        /// See documentation: <see href="https://learn.microsoft.com/en-us/windows/win32/dataxchg/clipboard-formats#cloud-clipboard-and-clipboard-history-formats"/>
        /// </summary>
        public bool? CanUploadToCloudClipboard { get; set; }

        // FIXME: Do we need a way to specify "ExcludeClipboardContentFromMonitorProcessing"?
        private void SetClipboardOptions()
        {
            if (CanIncludeInClipboardHistory is bool canIncludeInClipboardHistory)
            {
                IntPtr hmem = Win32.GlobalAlloc(GMEM.Moveable, sizeof(uint));
                if (hmem == IntPtr.Zero)
                {
                    throw new Win32Exception();
                }

                // Write the data
                unsafe
                {
                    uint* memory = (uint*)Win32.GlobalLock(hmem);
                    if (memory == null)
                    {
                        int error = Marshal.GetLastWin32Error();
                        Win32.GlobalFree(hmem);
                        throw new Win32Exception(error);
                    }

                    *memory = canIncludeInClipboardHistory ? 1u : 0u;

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
                
                IntPtr data = Win32.SetClipboardData(CF_CanIncludeInClipboardHistory, hmem);
                if (data == IntPtr.Zero)
                {
                    int error = Marshal.GetLastWin32Error();
                    if (error != 0)
                    {
                        Win32.GlobalFree(hmem);
                        throw new Win32Exception(error);
                    }
                }
            }

            if (CanUploadToCloudClipboard is bool canUploadToCloudClipboard)
            {
                IntPtr hmem = Win32.GlobalAlloc(GMEM.Moveable, sizeof(uint));
                if (hmem == IntPtr.Zero)
                {
                    throw new Win32Exception();
                }

                // Write the data
                unsafe
                {
                    uint* memory = (uint*)Win32.GlobalLock(hmem);
                    if (memory == null)
                    {
                        int error = Marshal.GetLastWin32Error();
                        Win32.GlobalFree(hmem);
                        throw new Win32Exception(error);
                    }

                    *memory = canUploadToCloudClipboard ? 1u : 0u;

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

                IntPtr data = Win32.SetClipboardData(CF_CanUploadToCloudClipboard, hmem);
                if (data == IntPtr.Zero)
                {
                    int error = Marshal.GetLastWin32Error();
                    if (error != 0)
                    {
                        Win32.GlobalFree(hmem);
                        throw new Win32Exception(error);
                    }
                }
            }
        }

        /// <inheritdoc/>
        public void Initialize(ToolkitOptions options)
        {
            // FIXME: Should we check for errors here?
            CF_CanIncludeInClipboardHistory = Win32.RegisterClipboardFormat("CanIncludeInClipboardHistory");
            CF_CanUploadToCloudClipboard = Win32.RegisterClipboardFormat("CanUploadToCloudClipboard");
        }

        /// <inheritdoc/>
        public void Uninitialize()
        {
        }

        private static CF CF_CanIncludeInClipboardHistory;
        private static CF CF_CanUploadToCloudClipboard;

        /// <inheritdoc/>
        public IReadOnlyList<ClipboardFormat> SupportedFormats => _SupportedFormats;

        private static readonly ClipboardFormat[] _SupportedFormats = new[]
        {
            ClipboardFormat.Text,
            ClipboardFormat.Files,
            ClipboardFormat.Bitmap,
            ClipboardFormat.Audio,
        };

        internal static ClipboardFormat GetClipboardFormatInternal(ILogger? logger)
        {
            bool success = Win32.OpenClipboard(WindowComponent.HelperHWnd);
            if (success == false)
            {
                logger?.LogInfo("Could not open clipboard to get clipboard format!");
                return ClipboardFormat.None;
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
                    case CF.Wave:
                        format = ClipboardFormat.Audio;
                        break;
                    default:
                        break;
                }

                if ((uint)cf > 0xC000u && (uint)cf < 0xFFFFu)
                {
                    int length = Win32.GetClipboardFormatName(cf, name, name.Capacity);
                    if (length == 0)
                    {
                        int code = Marshal.GetLastWin32Error();
                        Win32.CloseClipboard();
                        throw new Win32Exception(code);
                    }

                    // FIXME: Are these printouts useful?
                    logger?.LogDebug($"Format (0x{(uint)cf:X4}): {name}");
                }
                else
                {
                    // FIXME: Are these printouts useful?
                    logger?.LogDebug($"Format (0x{(uint)cf:X4}): {cf}");
                }
            }

            while ((cf = Win32.EnumClipboardFormats(cf)) != 0)
            {
                if ((uint)cf > 0xC000u && (uint)cf < 0xFFFFu)
                {
                    int length = Win32.GetClipboardFormatName(cf, name, name.Capacity);
                    if (length == 0)
                    {
                        int code = Marshal.GetLastWin32Error();
                        Win32.CloseClipboard();
                        throw new Win32Exception(code);
                    }

                    // FIXME: Are these printouts useful?
                    logger?.LogDebug($"Format (0x{(uint)cf:X4}): {name}");
                }
                else
                {
                    // FIXME: Are these printouts useful?
                    logger?.LogDebug($"Format (0x{(uint)cf:X4}): {cf}");
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

        /// <inheritdoc/>
        public ClipboardFormat GetClipboardFormat()
        {
            return GetClipboardFormatInternal(Logger);
        }

        /// <inheritdoc/>
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

            IntPtr handle = Win32.SetClipboardData(CF.UnicodeText, hmem);
            if (handle == IntPtr.Zero)
            {
                int error = Marshal.GetLastWin32Error();
                Win32.CloseClipboard();
                throw new Win32Exception(error);
            }

            SetClipboardOptions();

            Win32.CloseClipboard();
        }

        // FIXME: It's quite possible that we will not be able to open the clipboard
        // because someone else is either reading or writing from it.
        // So we need to handle that when opening the clipboard.
        /// <inheritdoc/>
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
                int lastError = Marshal.GetLastWin32Error();

                success = Win32.CloseClipboard();
                if (success == false)
                {
                    throw new Win32Exception();
                }

                if (lastError == 0)
                {
                    Logger?.LogDebug($"Could not get CF_UNICODETEXT data from clipboard.");
                    return null;
                }
                else
                {
                    throw new Win32Exception(lastError);
                }
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

        unsafe struct wav_header
        {
            // RIFF Header
            public fixed byte riff_header[4]; // Contains "RIFF"
            public int wav_size; // Size of the wav portion of the file, which follows the first 8 bytes. File size - 8
            public fixed byte wave_header[4]; // Contains "WAVE"

            // Format Header
            public fixed byte fmt_header[4]; // Contains "fmt " (includes trailing space)
            public int fmt_chunk_size; // Should be 16 for PCM
            public short audio_format; // Should be 1 for PCM. 3 for IEEE Float
            public short num_channels;
            public int sample_rate;
            public int byte_rate; // Number of bytes per second. sample_rate * num_channels * Bytes Per Sample
            public short sample_alignment; // num_channels * Bytes Per Sample
            public short bit_depth; // Number of bits per sample

            // Data
            public fixed byte data_header[4]; // Contains "data"
            public int data_bytes; // Number of bytes in data. Number of samples * num_channels * sample byte size
                                   // uint8_t bytes[]; // Remainder of wave file is bytes
        }

        /// 
        public unsafe void SetClipboardAudio(AudioData data)
        {
            int bytes = sizeof(wav_header) + data.Audio.Length * sizeof(short);

            wav_header header;

            header.riff_header[0] = (byte)'R';
            header.riff_header[1] = (byte)'I';
            header.riff_header[2] = (byte)'F';
            header.riff_header[3] = (byte)'F';

            header.wav_size = bytes - 8; // file size - 8

            header.wave_header[0] = (byte)'W';
            header.wave_header[1] = (byte)'A';
            header.wave_header[2] = (byte)'V';
            header.wave_header[3] = (byte)'E';

            header.fmt_header[0] = (byte)'f';
            header.fmt_header[1] = (byte)'m';
            header.fmt_header[2] = (byte)'t';
            header.fmt_header[3] = (byte)' ';

            header.fmt_chunk_size = 16;
            header.audio_format = 1; // 1 for PCM. FIXME: Find the valid constants!

            header.num_channels = (short)(data.Stereo ? 2 : 1);
            header.sample_rate = data.SampleRate;
            header.byte_rate = header.sample_rate * header.num_channels * sizeof(short);
            header.sample_alignment = (short)(header.num_channels * sizeof(short));
            header.bit_depth = 16;

            header.data_header[0] = (byte)'d';
            header.data_header[1] = (byte)'a';
            header.data_header[2] = (byte)'t';
            header.data_header[3] = (byte)'a';

            header.data_bytes = data.Audio.Length * sizeof(short);

            IntPtr hmem = Win32.GlobalAlloc(GMEM.Moveable, (ulong)bytes);
            if (hmem == IntPtr.Zero)
            {
                throw new Win32Exception();
            }

            {
                void* memory = (char*)Win32.GlobalLock(hmem);
                if (memory == null)
                {
                    int error = Marshal.GetLastWin32Error();
                    Win32.GlobalFree(hmem);
                    throw new Win32Exception(error);
                }

                Span<byte> memorySpan = new Span<byte>(memory, bytes);

                // First we copy over the wav header
                MemoryMarshal.Cast<byte, wav_header>(memorySpan)[0] = header;

                // Then copy the wav data
                data.Audio.AsSpan().CopyTo(MemoryMarshal.Cast<byte, short>(memorySpan.Slice(sizeof(wav_header))));

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

            IntPtr handle = Win32.SetClipboardData(CF.Wave, hmem);
            if (handle == IntPtr.Zero)
            {
                int error = Marshal.GetLastWin32Error();
                Win32.CloseClipboard();
                throw new Win32Exception(error);
            }

            SetClipboardOptions();

            Win32.CloseClipboard();
        }

        /// <inheritdoc/>
        public unsafe AudioData? GetClipboardAudio()
        {
            bool success = Win32.OpenClipboard(WindowComponent.HelperHWnd);
            if (success == false)
            {
                throw new Win32Exception();
            }

            IntPtr obj = Win32.GetClipboardData(CF.Wave);
            if (obj == IntPtr.Zero)
            {
                int lastError = Marshal.GetLastWin32Error();

                success = Win32.CloseClipboard();
                if (success == false)
                {
                    throw new Win32Exception();
                }

                if (lastError == 0)
                {
                    Logger?.LogDebug($"Could not get CF_WAVE data from clipboard.");
                    return null;
                }
                else
                {
                    throw new Win32Exception(lastError);
                }
            }

            int waveDataSize = (int)Win32.GlobalSize(obj);

            void* waveData = (void*)Win32.GlobalLock(obj);
            if (waveData == null)
            {
                throw new Win32Exception();
            }

            Span<byte> span = new Span<byte>(waveData, waveDataSize);

            wav_header header = MemoryMarshal.Cast<byte, wav_header>(span)[0];

            Logger?.LogDebug($"wav_size: {header.wav_size}");


            Logger?.LogDebug($"fmt_chunk_size: {header.fmt_chunk_size}");
            Logger?.LogDebug($"audio_format: {header.audio_format}");
            Logger?.LogDebug($"num_channels: {header.num_channels}");
            Logger?.LogDebug($"sample_rate: {header.sample_rate}");
            Logger?.LogDebug($"byte_rate: {header.byte_rate}");
            Logger?.LogDebug($"sample_alignment: {header.sample_alignment}");
            Logger?.LogDebug($"bit_depth: {header.bit_depth}");
            Logger?.LogDebug($"data_bytes: {header.data_bytes}");

            AudioData data = new AudioData();

            data.SampleRate = header.sample_rate;
            data.Stereo = header.num_channels == 2 ? true : false; // More than 2 channels?
            // FIXME: Consider sample alignment, format etc
            data.Audio = MemoryMarshal.Cast<byte, short>(span.Slice(sizeof(wav_header))).ToArray();

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

            return data;
        }

        /// <inheritdoc/>
        public unsafe void SetClipboardBitmap(Bitmap bitmap)
        {
            // We don't need to consider alignment as 32bpp image data will always align to DWORDs
            // independent of the width of the image.
            // This is not true for 24bpp images at certain widths, but we don't have to worry.
            // See https://learn.microsoft.com/en-us/windows/win32/api/wingdi/ns-wingdi-bitmapinfoheader#calculating-surface-stride
            int bytesPerRow = bitmap.Width * 4;

            int bytes = (int)sizeof(Win32.BITMAPV5HEADER) + bytesPerRow * bitmap.Height;

            IntPtr hmem = Win32.GlobalAlloc(GMEM.Moveable | GMEM.ZeroInit, (ulong)bytes);
            if (hmem == IntPtr.Zero)
            {
                throw new Win32Exception();
            }

            {
                void* memory = (char*)Win32.GlobalLock(hmem);
                if (memory == null)
                {
                    int error = Marshal.GetLastWin32Error();
                    Win32.GlobalFree(hmem);
                    throw new Win32Exception(error);
                }

                Span<byte> memorySpan = new Span<byte>(memory, bytes);

                // First we set the header
                ref Win32.BITMAPV5HEADER header = ref MemoryMarshal.Cast<byte, Win32.BITMAPV5HEADER>(memorySpan)[0];

                header.bV5Size = (uint)Marshal.SizeOf<Win32.BITMAPV5HEADER>();

                header.bV5Width = bitmap.Width;
                header.bV5Height = bitmap.Height;
                header.bV5Planes = 1;
                header.bV5BitCount = 32;
                header.bV5Compression = BI.RGB;
                header.bV5CSType = CSType.sRGB;
                header.bV5SizeImage = (uint)(bytesPerRow * bitmap.Height);
                header.bV5RedMask = 0x00_FF_00_00;
                header.bV5GreenMask = 0x00_00_FF_00;
                header.bV5BlueMask = 0x00_00_00_FF;
                header.bV5AlphaMask = 0x00_00_00_00;
                header.bV5Intent = GamutMappingIntent.Graphics;

                Span<byte> image = memorySpan.Slice(sizeof(Win32.BITMAPV5HEADER));

                // FIXME: This copy plus RGBA to BGRA conversion can probably be done more efficiently
                bitmap.Data.AsSpan().CopyTo(image);

                // Convert from RGBA data into BGRA data.
                for (int i = 0; i < image.Length; i += 4)
                {
                    (image[i + 0], image[i + 2]) = (image[i + 2], image[i + 0]);
                }

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
                // We assume the clipboard didn't take ownership of the memory.
                Win32.GlobalFree(hmem);
                Win32.CloseClipboard();
                throw new Win32Exception(error);
            }

            Win32.EmptyClipboard();

            IntPtr handle = Win32.SetClipboardData(CF.DIBV5, hmem);
            if (handle == IntPtr.Zero)
            {
                int error = Marshal.GetLastWin32Error();
                Win32.CloseClipboard();
                throw new Win32Exception(error);
            }

            SetClipboardOptions();

            success = Win32.CloseClipboard();
            if (success == false)
            {
                throw new Win32Exception();
            }
        }

        /// <inheritdoc/>
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
                int lastError = Marshal.GetLastWin32Error();

                success = Win32.CloseClipboard();
                if (success == false)
                {
                    throw new Win32Exception();
                }

                if (lastError == 0)
                {
                    Logger?.LogDebug($"Could not get CF_BITMAP data from clipboard.");
                    return null;
                }
                else
                {
                    throw new Win32Exception(lastError);
                }
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

            Win32.ReleaseDC(IntPtr.Zero, hDC);

            // FIXME: Potentially flip the image so that it is top to bottom.

            // Convert from Bgra to Rgba.
            for (int i = 0; i < image.Length; i += 4)
            {
                (image[i + 0], image[i + 2]) = (image[i + 2], image[i + 0]);
            }

            success = Win32.CloseClipboard();
            if (success == false)
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

                // FIXME: Should we be flipping the bottom up images instead?
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

        /// <inheritdoc/>
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
                int lastError = Marshal.GetLastWin32Error();

                success = Win32.CloseClipboard();
                if (success == false)
                {
                    throw new Win32Exception();
                }

                if (lastError == 0)
                {
                    Logger?.LogDebug($"Could not get CF_HDROP data from clipboard.");
                    return null;
                }
                else
                {
                    throw new Win32Exception(lastError);
                }
            }

            uint count = Win32.DragQueryFile(hdrop, 0xFFFFFFFF, null, 0);

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

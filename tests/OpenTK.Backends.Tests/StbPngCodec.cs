using System;
using System.IO;
using System.Runtime.InteropServices;
using OpenTK.Core.Utility;
using OpenTK.Platform;
using OpenTK.Platform.Native.X11;
using StbImageSharp;
using StbImageWriteSharp;

namespace OpenTK.Backends.Tests
{
    /// <summary>
    /// Png codec using StbImageSharp and StbImageWriteSharp to encode/decode images.
    /// </summary>
    public class StbPngCodec : X11ClipboardComponent.IPngCodec
    {
        bool X11ClipboardComponent.IPngCodec.CanDecodePng => true;

        bool X11ClipboardComponent.IPngCodec.CanEncodePng => true;

        unsafe Bitmap? X11ClipboardComponent.IPngCodec.DecodePng(Span<byte> imageData, ILogger? logger)
        {
            ImageResult result;
            fixed(byte* ptr = imageData)
            {
                UnmanagedMemoryStream imageStream = new UnmanagedMemoryStream(ptr, imageData.Length);

                int prev = StbImage.stbi__vertically_flip_on_load_global;
                try
                {
                    // FIXME: Should we flip here?
                    StbImage.stbi_set_flip_vertically_on_load(1);
                    result = ImageResult.FromStream(imageStream, StbImageSharp.ColorComponents.RedGreenBlueAlpha);
                }
                catch (InvalidOperationException ex)
                {
                    logger?.LogWarning($"Failed to decode png: {ex}");
                    return null;
                }
                finally
                {
                    StbImage.stbi__vertically_flip_on_load_global = prev;
                }

                imageStream.Close();
            }

            Bitmap bitmap = new Bitmap(result.Width, result.Height, result.Data);
            return bitmap;
        }

        unsafe byte[]? X11ClipboardComponent.IPngCodec.EncodePng(Bitmap image, ILogger? logger)
        {
            fixed (byte* ptr = image.Data)
            {
                StbImageWrite.stbi_flip_vertically_on_write(1);
                // FIXME: Maybe use stbi_write_png_to_mem directly and return a span?
                int len;
                byte* data = StbImageWrite.stbi_write_png_to_mem(ptr, image.Width * 4, image.Width, image.Height, 4, &len);
                if (data == null)
                {
                    // Would ideally want a better error message but alas...
                    logger?.LogWarning($"Unable to encode bitmap to png. stbi_write_png_to_mem returned NULL.");
                    return null;
                }

                byte[] dataArr = new Span<byte>(data, len).ToArray();

                // sbti_write uses Marshal.AllocHGlobal for malloc.
                Marshal.FreeHGlobal((IntPtr)data);

                return dataArr;
            }
        }
    }
}


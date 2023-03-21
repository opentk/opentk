using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace OpenTK.OpenAL
{
    internal static unsafe class STBImageLow
    {
        private const CallingConvention STBCallingConvention = CallingConvention.Cdecl;
        private const string Lib = "";

        [DllImport(Lib, EntryPoint = "stbi_hdr_to_ldr_gamma", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern void stbi_hdr_to_ldr_gamma(float gamma);

        [DllImport(Lib, EntryPoint = "stbi_hdr_to_ldr_scale", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern void stbi_hdr_to_ldr_scale(float scale);

        [DllImport(Lib, EntryPoint = "stbi_ldr_to_hdr_gamma", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern void stbi_ldr_to_hdr_gamma(float gamma);

        [DllImport(Lib, EntryPoint = "stbi_ldr_to_hdr_scale", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern void stbi_ldr_to_hdr_scale(float scale);

        [DllImport(Lib, EntryPoint = "stbi_is_hdr_from_memory", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern int stbi_is_hdr_from_memory(byte  *buffer, int len);

        [DllImport(Lib, EntryPoint = "stbi_is_hdr", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern int stbi_is_hdr(byte *filename);

        [DllImport(Lib, EntryPoint = "stbi_image_free", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern void stbi_image_free(void *retval_from_stbi_load);

        [DllImport(Lib, EntryPoint = "stbi_info_from_memory", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern int stbi_info_from_memory(byte  *buffer, int len, int *x, int *y, int *comp);

        [DllImport(Lib, EntryPoint = "stbi_is_16_bit_from_memory", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern int stbi_is_16_bit_from_memory(byte  *buffer, int len);

        [DllImport(Lib, EntryPoint = "stbi_info", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern int stbi_info(byte *filename,     int *x, int *y, int *comp);

        [DllImport(Lib, EntryPoint = "stbi_is_16_bit", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern int stbi_is_16_bit(byte *filename);

        [DllImport(Lib, EntryPoint = "stbi_set_unpremultiply_on_load", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern void stbi_set_unpremultiply_on_load(int flag_true_if_should_unpremultiply);

        [DllImport(Lib, EntryPoint = "stbi_convert_iphone_png_to_rgb", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern void stbi_convert_iphone_png_to_rgb(int flag_true_if_should_convert);

        [DllImport(Lib, EntryPoint = "stbi_set_flip_vertically_on_load", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern void stbi_set_flip_vertically_on_load(int flag_true_if_should_flip);

        [DllImport(Lib, EntryPoint = "stbi_set_unpremultiply_on_load_thread", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern void stbi_set_unpremultiply_on_load_thread(int flag_true_if_should_unpremultiply);

        [DllImport(Lib, EntryPoint = "stbi_convert_iphone_png_to_rgb_thread", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern void stbi_convert_iphone_png_to_rgb_thread(int flag_true_if_should_convert);

        [DllImport(Lib, EntryPoint = "stbi_set_flip_vertically_on_load_thread", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern void stbi_set_flip_vertically_on_load_thread(int flag_true_if_should_flip);

        [DllImport(Lib, EntryPoint = "stbi_zlib_decode_buffer", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern int stbi_zlib_decode_buffer(byte *obuffer, int olen,  byte *ibuffer, int ilen);

        [DllImport(Lib, EntryPoint = "stbi_zlib_decode_noheader_buffer", ExactSpelling = true, CallingConvention = STBCallingConvention)]
        public static extern int stbi_zlib_decode_noheader_buffer(byte *obuffer, int olen,  byte *ibuffer, int ilen);

    }
}

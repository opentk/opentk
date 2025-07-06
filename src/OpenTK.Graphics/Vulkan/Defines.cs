// This file is auto generated, do not edit.
using System;

namespace OpenTK.Graphics.Vulkan
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static unsafe partial class Vk
    {
        /// <summary><b>[requires: v1.0]</b> 
        /// <br/><b>[deprecated by: v1.0]</b> see: <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#deprecation-version-macros" />
        /// </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_MAKE_VERSION.html" /></remarks>
        public static uint MAKE_VERSION(uint major, uint minor, uint patch) { return (major << 22) | (minor << 12) | (patch); }
        /// <summary><b>[requires: v1.0]</b> 
        /// <br/><b>[deprecated by: v1.0]</b> see: <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#deprecation-version-macros" />
        /// </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_VERSION_MAJOR.html" /></remarks>
        public static uint VERSION_MAJOR(uint version) { return (version >> 22); }
        /// <summary><b>[requires: v1.0]</b> 
        /// <br/><b>[deprecated by: v1.0]</b> see: <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#deprecation-version-macros" />
        /// </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_VERSION_MINOR.html" /></remarks>
        public static uint VERSION_MINOR(uint version) { return ((version >> 12) & 0x3FFU); }
        /// <summary><b>[requires: v1.0]</b> 
        /// <br/><b>[deprecated by: v1.0]</b> see: <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#deprecation-version-macros" />
        /// </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_VERSION_PATCH.html" /></remarks>
        public static uint VERSION_PATCH(uint version) { return (version & 0xFFFU); }
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_MAKE_API_VERSION.html" /></remarks>
        public static uint MAKE_API_VERSION(uint variant, uint major, uint minor, uint patch) { return (variant << 29) | (major << 22) | (minor << 12) | (patch); }
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_API_VERSION_VARIANT.html" /></remarks>
        public static uint API_VERSION_VARIANT(uint version) { return (version >> 29); }
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_API_VERSION_MAJOR.html" /></remarks>
        public static uint API_VERSION_MAJOR(uint version) { return ((version >> 22) & 0x7FU); }
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_API_VERSION_MINOR.html" /></remarks>
        public static uint API_VERSION_MINOR(uint version) { return ((version >> 12) & 0x3FFU); }
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_API_VERSION_PATCH.html" /></remarks>
        public static uint API_VERSION_PATCH(uint version) { return (version & 0xFFFU); }
        /// <summary></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VKSC_API_VARIANT.html" /></remarks>
        public const uint VKSC_API_VARIANT = unchecked((uint)1);
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_API_VERSION_1_0.html" /></remarks>
        public static ulong API_VERSION_1_0() { return MAKE_API_VERSION(0, 1, 0, 0); }
        /// <summary><b>[requires: v1.1]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_API_VERSION_1_1.html" /></remarks>
        public static ulong API_VERSION_1_1() { return MAKE_API_VERSION(0, 1, 1, 0); }
        /// <summary><b>[requires: v1.2]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_API_VERSION_1_2.html" /></remarks>
        public static ulong API_VERSION_1_2() { return MAKE_API_VERSION(0, 1, 2, 0); }
        /// <summary><b>[requires: v1.3]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_API_VERSION_1_3.html" /></remarks>
        public static ulong API_VERSION_1_3() { return MAKE_API_VERSION(0, 1, 3, 0); }
        /// <summary><b>[requires: v1.4]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_API_VERSION_1_4.html" /></remarks>
        public static ulong API_VERSION_1_4() { return MAKE_API_VERSION(0, 1, 4, 0); }
        /// <summary></summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VKSC_API_VERSION_1_0.html" /></remarks>
        public static ulong VKSC_API_VERSION_1_0() { return MAKE_API_VERSION(VKSC_API_VARIANT, 1, 0, 0); }
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_HEADER_VERSION.html" /></remarks>
        public const uint HEADER_VERSION = unchecked((uint)321);
        /// <summary><b>[requires: v1.0]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_HEADER_VERSION_COMPLETE.html" /></remarks>
        public static ulong HEADER_VERSION_COMPLETE() { return MAKE_API_VERSION(0, 1, 4, HEADER_VERSION); }
        
        // Vulkan video macros
        
        /// <summary><b>[requires: vulkan_video_codecs_common]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_MAKE_VIDEO_STD_VERSION.html" /></remarks>
        public static uint MAKE_VIDEO_STD_VERSION(uint major, uint minor, uint patch) { return ((major) << 22) | ((minor) << 12) | (patch); }
        /// <summary><b>[requires: vulkan_video_codec_h264std_decode]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_STD_VULKAN_VIDEO_CODEC_H264_DECODE_API_VERSION_1_0_0.html" /></remarks>
        public static uint STD_VULKAN_VIDEO_CODEC_H264_DECODE_API_VERSION_1_0_0() { return MAKE_VIDEO_STD_VERSION(1, 0, 0); }
        /// <summary><b>[requires: vulkan_video_codec_h264std_encode]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_STD_VULKAN_VIDEO_CODEC_H264_ENCODE_API_VERSION_1_0_0.html" /></remarks>
        public static uint STD_VULKAN_VIDEO_CODEC_H264_ENCODE_API_VERSION_1_0_0() { return MAKE_VIDEO_STD_VERSION(1, 0, 0); }
        /// <summary><b>[requires: vulkan_video_codec_h265std_decode]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_STD_VULKAN_VIDEO_CODEC_H265_DECODE_API_VERSION_1_0_0.html" /></remarks>
        public static uint STD_VULKAN_VIDEO_CODEC_H265_DECODE_API_VERSION_1_0_0() { return MAKE_VIDEO_STD_VERSION(1, 0, 0); }
        /// <summary><b>[requires: vulkan_video_codec_h265std_encode]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_STD_VULKAN_VIDEO_CODEC_H265_ENCODE_API_VERSION_1_0_0.html" /></remarks>
        public static uint STD_VULKAN_VIDEO_CODEC_H265_ENCODE_API_VERSION_1_0_0() { return MAKE_VIDEO_STD_VERSION(1, 0, 0); }
        /// <summary><b>[requires: vulkan_video_codec_vp9std_decode]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_STD_VULKAN_VIDEO_CODEC_VP9_DECODE_API_VERSION_1_0_0.html" /></remarks>
        public static uint STD_VULKAN_VIDEO_CODEC_VP9_DECODE_API_VERSION_1_0_0() { return MAKE_VIDEO_STD_VERSION(1, 0, 0); }
        /// <summary><b>[requires: vulkan_video_codec_av1std_decode]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_STD_VULKAN_VIDEO_CODEC_AV1_DECODE_API_VERSION_1_0_0.html" /></remarks>
        public static uint STD_VULKAN_VIDEO_CODEC_AV1_DECODE_API_VERSION_1_0_0() { return MAKE_VIDEO_STD_VERSION(1, 0, 0); }
        /// <summary><b>[requires: vulkan_video_codec_av1std_encode]</b> </summary>
        /// <remarks><see href="https://registry.khronos.org/vulkan/specs/latest/man/html/VK_STD_VULKAN_VIDEO_CODEC_AV1_ENCODE_API_VERSION_1_0_0.html" /></remarks>
        public static uint STD_VULKAN_VIDEO_CODEC_AV1_ENCODE_API_VERSION_1_0_0() { return MAKE_VIDEO_STD_VERSION(1, 0, 0); }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

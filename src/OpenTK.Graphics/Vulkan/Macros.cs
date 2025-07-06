using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Graphics.Vulkan
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public static unsafe partial class Vk
    {
        [Obsolete("This define is deprecated. VK_MAKE_API_VERSION should be used instead.")]
        public static uint MAKE_VERSION(uint major, uint minor, uint patch) => (major << 22) | (minor << 12) | (patch);

        [Obsolete("This define is deprecated. VK_API_VERSION_MAJOR should be used instead.")]
        public static uint VERSION_MAJOR(uint version) => (version >> 22);

        [Obsolete("This define is deprecated. VK_API_VERSION_MINOR should be used instead.")]
        public static uint VERSION_MINOR(uint version) => ((version >> 12) & 0x3FFU);

        [Obsolete("This define is deprecated. VK_API_VERSION_PATCH should be used instead.")]
        public static uint VERSION_PATCH(uint version) => (version & 0xFFF);

        public static uint MAKE_API_VERSION(uint variant, uint major, uint minor, uint patch) => (variant << 29) | (major << 22) | (minor << 12) | (patch);

        public static uint API_VERSION_VARIANT(uint version) => (version >> 29);
        public static uint VK_API_VERSION_MAJOR(uint version) => ((version >> 22) & 0x7FU);
        public static uint VK_API_VERSION_MINOR(uint version) => ((version >> 12) & 0x3FFU);
        public static uint VK_API_VERSION_PATCH(uint version) => (version & 0xFFFU);

        public const uint VKSC_API_VARIANT = 1;

        public static readonly uint VK_API_VERSION_1_0 = MAKE_API_VERSION(0, 1, 0, 0);
        public static readonly uint VK_API_VERSION_1_1 = MAKE_API_VERSION(0, 1, 1, 0);
        public static readonly uint VK_API_VERSION_1_2 = MAKE_API_VERSION(0, 1, 2, 0);
        public static readonly uint VK_API_VERSION_1_3 = MAKE_API_VERSION(0, 1, 3, 0);
        public static readonly uint VK_API_VERSION_1_4 = MAKE_API_VERSION(0, 1, 4, 0);

        public static readonly uint VKSC_API_VERSION_1_0 = MAKE_API_VERSION(VKSC_API_VARIANT, 1, 0, 0);

        // FIXME: Auto generate this? if not all of the defines??
        // We want to keep this up to date...
        public const uint VK_HEADER_VERSION = 321;
        public static readonly uint VK_HEADER_VERSION_COMPLETE = MAKE_API_VERSION(0, 1, 4, VK_HEADER_VERSION);

        // For vulkansc that we don't support atm.
        //public const uint VK_HEADER_VERSION = 18;
        //public static readonly uint VK_HEADER_VERSION_COMPLETE = MAKE_API_VERSION(VKSC_API_VARIANT, 1, 0, VK_HEADER_VERSION);

        //  Vulkan video macros

        public static uint VK_MAKE_VIDEO_STD_VERSION(uint major, uint minor, uint patch) => ((major) << 22) | ((minor) << 12) | (patch);

        public static readonly uint VK_STD_VULKAN_VIDEO_CODEC_AV1_ENCODE_API_VERSION_1_0_0 = VK_MAKE_VIDEO_STD_VERSION(1, 0, 0);
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

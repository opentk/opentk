using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Graphics.Vulkan
{
    public static unsafe partial class Vk
    {
        public const uint MaxPhysicalDeviceNameSize = 256;
        public const uint UUIDSize = 16;
        public const uint LUIDSize = 8;
        public const uint LUIDSizeKHR = LUIDSize;
        public const uint MaxExtensionNameSize = 256;
        public const uint MaxDescriptionSize = 256;
        public const uint MaxMemoryTypes = 32;
        /// <summary>The maximum number of unique memory heaps, each of which supporting 1 or more memory types</summary>
        public const uint MaxMemoryHeaps = 16;
        public const float LodClampNone = 1000.0F;
        public const uint RemainingMipLevels = (~0U);
        public const uint RemainingArrayLayers = (~0U);
        public const uint Remaining3DSlicesEXT = (~0U);
        public const ulong WholeSize = (~0UL);
        public const uint AttachmentUnused = (~0U);
        public const uint True = 1;
        public const uint False = 0;
        public const uint QueueFamilyIgnored = (~0U);
        public const uint QueueFamilyExternal = (~1U);
        public const uint QueueFamilyExternalKHR = QueueFamilyExternal;
        public const uint QueueFamilyForeignEXT = (~2U);
        public const uint SubpassExternal = (~0U);
        public const uint MaxDeviceGroupSize = 32;
        public const uint MaxDeviceGroupSizeKHR = MaxDeviceGroupSize;
        public const uint MaxDriverNameSize = 256;
        public const uint MaxDriverNameSizeKHR = MaxDriverNameSize;
        public const uint MaxDriverInfoSize = 256;
        public const uint MaxDriverInfoSizeKHR = MaxDriverInfoSize;
        public const uint ShaderUnusedKHR = (~0U);
        public const uint ShaderUnusedNV = ShaderUnusedKHR;
        public const uint MaxGlobalPrioritySizeKHR = 16;
        public const uint MaxGlobalPrioritySizeEXT = MaxGlobalPrioritySizeKHR;
        public const uint MaxShaderModuleIdentifierSizeEXT = 32;
        public const uint MaxVideoAV1ReferencesPerFrameKHR = 7;
        public const uint ShaderIndexUnusedAMDX = (~0U);

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
        public static readonly uint VKSC_API_VERSION_1_0 = MAKE_API_VERSION(VKSC_API_VARIANT, 1, 0, 0);

        // FIXME: Auto generate this? if not all of the defines??
        // We want to keep this up to date...
        public const uint VK_HEADER_VERSION = 289;
        public static readonly uint VK_HEADER_VERSION_COMPLETE = MAKE_API_VERSION(0, 1, 3, VK_HEADER_VERSION);

        // For vulkansc that we don't support atm.
        //public const uint VK_HEADER_VERSION = 15;
        //public static readonly uint VK_HEADER_VERSION_COMPLETE = MAKE_API_VERSION(VKSC_API_VARIANT, 1, 0, VK_HEADER_VERSION);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Core.Platform.Interfaces
{
    public interface IVulkanComponent : IPalComponent
    {
        // FIXME: Move all pal2 stuff into OpenTK.Platform.Native.
        //public ReadOnlySpan<string> GetRequiredInstanceExtensions();

        //public unsafe bool GetPhysicalDevicePresentationSupport(VkInstance instance, VkPhysicalDevice device, uint queueFamily);

        //public unsafe VkResult CreateWindowSurface(VkInstance instance, WindowHandle window, VkAllocationCallbacks* allocator, out VkSurfaceKHR surface);
    }
}

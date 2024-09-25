using System;

namespace OpenTK.Platform;

/// <summary>
/// Graphics API hints for the Vulkan API.
/// </summary>
public class VulkanGraphicsApiHints : GraphicsApiHints
{
    /// <inheritdoc/>
    public override GraphicsApi Api => GraphicsApi.Vulkan;

    // Do we want to have any settings here?
}

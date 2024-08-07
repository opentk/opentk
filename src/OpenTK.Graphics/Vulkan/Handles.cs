// This file is auto generated, do not edit.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace OpenTK.Graphics.Vulkan
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    [DebuggerDisplay("VkInstance\\{{Handle}\\}")]
    public unsafe struct VkInstance : IEquatable<VkInstance>
    {
        public static VkInstance Zero => new VkInstance(0);
        public ulong Handle;
        public VkInstance(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkInstance instance && Equals(instance);
        public bool Equals(VkInstance other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkInstance left, VkInstance right) => left.Equals(right);
        public static bool operator !=(VkInstance left, VkInstance right) => !(left == right);
        public static explicit operator ulong(VkInstance handle) => handle.Handle;
        public static explicit operator VkInstance(ulong handle) => new VkInstance(handle);
    }
    [DebuggerDisplay("VkPhysicalDevice\\{{Handle}\\}")]
    public unsafe struct VkPhysicalDevice : IEquatable<VkPhysicalDevice>
    {
        public static VkPhysicalDevice Zero => new VkPhysicalDevice(0);
        public ulong Handle;
        public VkPhysicalDevice(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkPhysicalDevice instance && Equals(instance);
        public bool Equals(VkPhysicalDevice other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkPhysicalDevice left, VkPhysicalDevice right) => left.Equals(right);
        public static bool operator !=(VkPhysicalDevice left, VkPhysicalDevice right) => !(left == right);
        public static explicit operator ulong(VkPhysicalDevice handle) => handle.Handle;
        public static explicit operator VkPhysicalDevice(ulong handle) => new VkPhysicalDevice(handle);
    }
    [DebuggerDisplay("VkDevice\\{{Handle}\\}")]
    public unsafe struct VkDevice : IEquatable<VkDevice>
    {
        public static VkDevice Zero => new VkDevice(0);
        public ulong Handle;
        public VkDevice(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkDevice instance && Equals(instance);
        public bool Equals(VkDevice other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkDevice left, VkDevice right) => left.Equals(right);
        public static bool operator !=(VkDevice left, VkDevice right) => !(left == right);
        public static explicit operator ulong(VkDevice handle) => handle.Handle;
        public static explicit operator VkDevice(ulong handle) => new VkDevice(handle);
    }
    [DebuggerDisplay("VkQueue\\{{Handle}\\}")]
    public unsafe struct VkQueue : IEquatable<VkQueue>
    {
        public static VkQueue Zero => new VkQueue(0);
        public ulong Handle;
        public VkQueue(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkQueue instance && Equals(instance);
        public bool Equals(VkQueue other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkQueue left, VkQueue right) => left.Equals(right);
        public static bool operator !=(VkQueue left, VkQueue right) => !(left == right);
        public static explicit operator ulong(VkQueue handle) => handle.Handle;
        public static explicit operator VkQueue(ulong handle) => new VkQueue(handle);
    }
    [DebuggerDisplay("VkCommandBuffer\\{{Handle}\\}")]
    public unsafe struct VkCommandBuffer : IEquatable<VkCommandBuffer>
    {
        public static VkCommandBuffer Zero => new VkCommandBuffer(0);
        public ulong Handle;
        public VkCommandBuffer(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkCommandBuffer instance && Equals(instance);
        public bool Equals(VkCommandBuffer other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkCommandBuffer left, VkCommandBuffer right) => left.Equals(right);
        public static bool operator !=(VkCommandBuffer left, VkCommandBuffer right) => !(left == right);
        public static explicit operator ulong(VkCommandBuffer handle) => handle.Handle;
        public static explicit operator VkCommandBuffer(ulong handle) => new VkCommandBuffer(handle);
    }
    [DebuggerDisplay("VkDeviceMemory\\{{Handle}\\}")]
    public unsafe struct VkDeviceMemory : IEquatable<VkDeviceMemory>
    {
        public static VkDeviceMemory Zero => new VkDeviceMemory(0);
        public ulong Handle;
        public VkDeviceMemory(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkDeviceMemory instance && Equals(instance);
        public bool Equals(VkDeviceMemory other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkDeviceMemory left, VkDeviceMemory right) => left.Equals(right);
        public static bool operator !=(VkDeviceMemory left, VkDeviceMemory right) => !(left == right);
        public static explicit operator ulong(VkDeviceMemory handle) => handle.Handle;
        public static explicit operator VkDeviceMemory(ulong handle) => new VkDeviceMemory(handle);
    }
    [DebuggerDisplay("VkCommandPool\\{{Handle}\\}")]
    public unsafe struct VkCommandPool : IEquatable<VkCommandPool>
    {
        public static VkCommandPool Zero => new VkCommandPool(0);
        public ulong Handle;
        public VkCommandPool(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkCommandPool instance && Equals(instance);
        public bool Equals(VkCommandPool other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkCommandPool left, VkCommandPool right) => left.Equals(right);
        public static bool operator !=(VkCommandPool left, VkCommandPool right) => !(left == right);
        public static explicit operator ulong(VkCommandPool handle) => handle.Handle;
        public static explicit operator VkCommandPool(ulong handle) => new VkCommandPool(handle);
    }
    [DebuggerDisplay("VkBuffer\\{{Handle}\\}")]
    public unsafe struct VkBuffer : IEquatable<VkBuffer>
    {
        public static VkBuffer Zero => new VkBuffer(0);
        public ulong Handle;
        public VkBuffer(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkBuffer instance && Equals(instance);
        public bool Equals(VkBuffer other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkBuffer left, VkBuffer right) => left.Equals(right);
        public static bool operator !=(VkBuffer left, VkBuffer right) => !(left == right);
        public static explicit operator ulong(VkBuffer handle) => handle.Handle;
        public static explicit operator VkBuffer(ulong handle) => new VkBuffer(handle);
    }
    [DebuggerDisplay("VkBufferView\\{{Handle}\\}")]
    public unsafe struct VkBufferView : IEquatable<VkBufferView>
    {
        public static VkBufferView Zero => new VkBufferView(0);
        public ulong Handle;
        public VkBufferView(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkBufferView instance && Equals(instance);
        public bool Equals(VkBufferView other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkBufferView left, VkBufferView right) => left.Equals(right);
        public static bool operator !=(VkBufferView left, VkBufferView right) => !(left == right);
        public static explicit operator ulong(VkBufferView handle) => handle.Handle;
        public static explicit operator VkBufferView(ulong handle) => new VkBufferView(handle);
    }
    [DebuggerDisplay("VkImage\\{{Handle}\\}")]
    public unsafe struct VkImage : IEquatable<VkImage>
    {
        public static VkImage Zero => new VkImage(0);
        public ulong Handle;
        public VkImage(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkImage instance && Equals(instance);
        public bool Equals(VkImage other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkImage left, VkImage right) => left.Equals(right);
        public static bool operator !=(VkImage left, VkImage right) => !(left == right);
        public static explicit operator ulong(VkImage handle) => handle.Handle;
        public static explicit operator VkImage(ulong handle) => new VkImage(handle);
    }
    [DebuggerDisplay("VkImageView\\{{Handle}\\}")]
    public unsafe struct VkImageView : IEquatable<VkImageView>
    {
        public static VkImageView Zero => new VkImageView(0);
        public ulong Handle;
        public VkImageView(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkImageView instance && Equals(instance);
        public bool Equals(VkImageView other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkImageView left, VkImageView right) => left.Equals(right);
        public static bool operator !=(VkImageView left, VkImageView right) => !(left == right);
        public static explicit operator ulong(VkImageView handle) => handle.Handle;
        public static explicit operator VkImageView(ulong handle) => new VkImageView(handle);
    }
    [DebuggerDisplay("VkShaderModule\\{{Handle}\\}")]
    public unsafe struct VkShaderModule : IEquatable<VkShaderModule>
    {
        public static VkShaderModule Zero => new VkShaderModule(0);
        public ulong Handle;
        public VkShaderModule(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkShaderModule instance && Equals(instance);
        public bool Equals(VkShaderModule other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkShaderModule left, VkShaderModule right) => left.Equals(right);
        public static bool operator !=(VkShaderModule left, VkShaderModule right) => !(left == right);
        public static explicit operator ulong(VkShaderModule handle) => handle.Handle;
        public static explicit operator VkShaderModule(ulong handle) => new VkShaderModule(handle);
    }
    [DebuggerDisplay("VkPipeline\\{{Handle}\\}")]
    public unsafe struct VkPipeline : IEquatable<VkPipeline>
    {
        public static VkPipeline Zero => new VkPipeline(0);
        public ulong Handle;
        public VkPipeline(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkPipeline instance && Equals(instance);
        public bool Equals(VkPipeline other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkPipeline left, VkPipeline right) => left.Equals(right);
        public static bool operator !=(VkPipeline left, VkPipeline right) => !(left == right);
        public static explicit operator ulong(VkPipeline handle) => handle.Handle;
        public static explicit operator VkPipeline(ulong handle) => new VkPipeline(handle);
    }
    [DebuggerDisplay("VkPipelineLayout\\{{Handle}\\}")]
    public unsafe struct VkPipelineLayout : IEquatable<VkPipelineLayout>
    {
        public static VkPipelineLayout Zero => new VkPipelineLayout(0);
        public ulong Handle;
        public VkPipelineLayout(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkPipelineLayout instance && Equals(instance);
        public bool Equals(VkPipelineLayout other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkPipelineLayout left, VkPipelineLayout right) => left.Equals(right);
        public static bool operator !=(VkPipelineLayout left, VkPipelineLayout right) => !(left == right);
        public static explicit operator ulong(VkPipelineLayout handle) => handle.Handle;
        public static explicit operator VkPipelineLayout(ulong handle) => new VkPipelineLayout(handle);
    }
    [DebuggerDisplay("VkSampler\\{{Handle}\\}")]
    public unsafe struct VkSampler : IEquatable<VkSampler>
    {
        public static VkSampler Zero => new VkSampler(0);
        public ulong Handle;
        public VkSampler(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkSampler instance && Equals(instance);
        public bool Equals(VkSampler other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkSampler left, VkSampler right) => left.Equals(right);
        public static bool operator !=(VkSampler left, VkSampler right) => !(left == right);
        public static explicit operator ulong(VkSampler handle) => handle.Handle;
        public static explicit operator VkSampler(ulong handle) => new VkSampler(handle);
    }
    [DebuggerDisplay("VkDescriptorSet\\{{Handle}\\}")]
    public unsafe struct VkDescriptorSet : IEquatable<VkDescriptorSet>
    {
        public static VkDescriptorSet Zero => new VkDescriptorSet(0);
        public ulong Handle;
        public VkDescriptorSet(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkDescriptorSet instance && Equals(instance);
        public bool Equals(VkDescriptorSet other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkDescriptorSet left, VkDescriptorSet right) => left.Equals(right);
        public static bool operator !=(VkDescriptorSet left, VkDescriptorSet right) => !(left == right);
        public static explicit operator ulong(VkDescriptorSet handle) => handle.Handle;
        public static explicit operator VkDescriptorSet(ulong handle) => new VkDescriptorSet(handle);
    }
    [DebuggerDisplay("VkDescriptorSetLayout\\{{Handle}\\}")]
    public unsafe struct VkDescriptorSetLayout : IEquatable<VkDescriptorSetLayout>
    {
        public static VkDescriptorSetLayout Zero => new VkDescriptorSetLayout(0);
        public ulong Handle;
        public VkDescriptorSetLayout(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkDescriptorSetLayout instance && Equals(instance);
        public bool Equals(VkDescriptorSetLayout other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkDescriptorSetLayout left, VkDescriptorSetLayout right) => left.Equals(right);
        public static bool operator !=(VkDescriptorSetLayout left, VkDescriptorSetLayout right) => !(left == right);
        public static explicit operator ulong(VkDescriptorSetLayout handle) => handle.Handle;
        public static explicit operator VkDescriptorSetLayout(ulong handle) => new VkDescriptorSetLayout(handle);
    }
    [DebuggerDisplay("VkDescriptorPool\\{{Handle}\\}")]
    public unsafe struct VkDescriptorPool : IEquatable<VkDescriptorPool>
    {
        public static VkDescriptorPool Zero => new VkDescriptorPool(0);
        public ulong Handle;
        public VkDescriptorPool(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkDescriptorPool instance && Equals(instance);
        public bool Equals(VkDescriptorPool other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkDescriptorPool left, VkDescriptorPool right) => left.Equals(right);
        public static bool operator !=(VkDescriptorPool left, VkDescriptorPool right) => !(left == right);
        public static explicit operator ulong(VkDescriptorPool handle) => handle.Handle;
        public static explicit operator VkDescriptorPool(ulong handle) => new VkDescriptorPool(handle);
    }
    [DebuggerDisplay("VkFence\\{{Handle}\\}")]
    public unsafe struct VkFence : IEquatable<VkFence>
    {
        public static VkFence Zero => new VkFence(0);
        public ulong Handle;
        public VkFence(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkFence instance && Equals(instance);
        public bool Equals(VkFence other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkFence left, VkFence right) => left.Equals(right);
        public static bool operator !=(VkFence left, VkFence right) => !(left == right);
        public static explicit operator ulong(VkFence handle) => handle.Handle;
        public static explicit operator VkFence(ulong handle) => new VkFence(handle);
    }
    [DebuggerDisplay("VkSemaphore\\{{Handle}\\}")]
    public unsafe struct VkSemaphore : IEquatable<VkSemaphore>
    {
        public static VkSemaphore Zero => new VkSemaphore(0);
        public ulong Handle;
        public VkSemaphore(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkSemaphore instance && Equals(instance);
        public bool Equals(VkSemaphore other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkSemaphore left, VkSemaphore right) => left.Equals(right);
        public static bool operator !=(VkSemaphore left, VkSemaphore right) => !(left == right);
        public static explicit operator ulong(VkSemaphore handle) => handle.Handle;
        public static explicit operator VkSemaphore(ulong handle) => new VkSemaphore(handle);
    }
    [DebuggerDisplay("VkEvent\\{{Handle}\\}")]
    public unsafe struct VkEvent : IEquatable<VkEvent>
    {
        public static VkEvent Zero => new VkEvent(0);
        public ulong Handle;
        public VkEvent(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkEvent instance && Equals(instance);
        public bool Equals(VkEvent other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkEvent left, VkEvent right) => left.Equals(right);
        public static bool operator !=(VkEvent left, VkEvent right) => !(left == right);
        public static explicit operator ulong(VkEvent handle) => handle.Handle;
        public static explicit operator VkEvent(ulong handle) => new VkEvent(handle);
    }
    [DebuggerDisplay("VkQueryPool\\{{Handle}\\}")]
    public unsafe struct VkQueryPool : IEquatable<VkQueryPool>
    {
        public static VkQueryPool Zero => new VkQueryPool(0);
        public ulong Handle;
        public VkQueryPool(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkQueryPool instance && Equals(instance);
        public bool Equals(VkQueryPool other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkQueryPool left, VkQueryPool right) => left.Equals(right);
        public static bool operator !=(VkQueryPool left, VkQueryPool right) => !(left == right);
        public static explicit operator ulong(VkQueryPool handle) => handle.Handle;
        public static explicit operator VkQueryPool(ulong handle) => new VkQueryPool(handle);
    }
    [DebuggerDisplay("VkFramebuffer\\{{Handle}\\}")]
    public unsafe struct VkFramebuffer : IEquatable<VkFramebuffer>
    {
        public static VkFramebuffer Zero => new VkFramebuffer(0);
        public ulong Handle;
        public VkFramebuffer(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkFramebuffer instance && Equals(instance);
        public bool Equals(VkFramebuffer other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkFramebuffer left, VkFramebuffer right) => left.Equals(right);
        public static bool operator !=(VkFramebuffer left, VkFramebuffer right) => !(left == right);
        public static explicit operator ulong(VkFramebuffer handle) => handle.Handle;
        public static explicit operator VkFramebuffer(ulong handle) => new VkFramebuffer(handle);
    }
    [DebuggerDisplay("VkRenderPass\\{{Handle}\\}")]
    public unsafe struct VkRenderPass : IEquatable<VkRenderPass>
    {
        public static VkRenderPass Zero => new VkRenderPass(0);
        public ulong Handle;
        public VkRenderPass(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkRenderPass instance && Equals(instance);
        public bool Equals(VkRenderPass other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkRenderPass left, VkRenderPass right) => left.Equals(right);
        public static bool operator !=(VkRenderPass left, VkRenderPass right) => !(left == right);
        public static explicit operator ulong(VkRenderPass handle) => handle.Handle;
        public static explicit operator VkRenderPass(ulong handle) => new VkRenderPass(handle);
    }
    [DebuggerDisplay("VkPipelineCache\\{{Handle}\\}")]
    public unsafe struct VkPipelineCache : IEquatable<VkPipelineCache>
    {
        public static VkPipelineCache Zero => new VkPipelineCache(0);
        public ulong Handle;
        public VkPipelineCache(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkPipelineCache instance && Equals(instance);
        public bool Equals(VkPipelineCache other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkPipelineCache left, VkPipelineCache right) => left.Equals(right);
        public static bool operator !=(VkPipelineCache left, VkPipelineCache right) => !(left == right);
        public static explicit operator ulong(VkPipelineCache handle) => handle.Handle;
        public static explicit operator VkPipelineCache(ulong handle) => new VkPipelineCache(handle);
    }
    [DebuggerDisplay("VkIndirectCommandsLayoutNV\\{{Handle}\\}")]
    public unsafe struct VkIndirectCommandsLayoutNV : IEquatable<VkIndirectCommandsLayoutNV>
    {
        public static VkIndirectCommandsLayoutNV Zero => new VkIndirectCommandsLayoutNV(0);
        public ulong Handle;
        public VkIndirectCommandsLayoutNV(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkIndirectCommandsLayoutNV instance && Equals(instance);
        public bool Equals(VkIndirectCommandsLayoutNV other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right) => left.Equals(right);
        public static bool operator !=(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right) => !(left == right);
        public static explicit operator ulong(VkIndirectCommandsLayoutNV handle) => handle.Handle;
        public static explicit operator VkIndirectCommandsLayoutNV(ulong handle) => new VkIndirectCommandsLayoutNV(handle);
    }
    [DebuggerDisplay("VkDescriptorUpdateTemplate\\{{Handle}\\}")]
    public unsafe struct VkDescriptorUpdateTemplate : IEquatable<VkDescriptorUpdateTemplate>
    {
        public static VkDescriptorUpdateTemplate Zero => new VkDescriptorUpdateTemplate(0);
        public ulong Handle;
        public VkDescriptorUpdateTemplate(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkDescriptorUpdateTemplate instance && Equals(instance);
        public bool Equals(VkDescriptorUpdateTemplate other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) => left.Equals(right);
        public static bool operator !=(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) => !(left == right);
        public static explicit operator ulong(VkDescriptorUpdateTemplate handle) => handle.Handle;
        public static explicit operator VkDescriptorUpdateTemplate(ulong handle) => new VkDescriptorUpdateTemplate(handle);
    }
    [DebuggerDisplay("VkDescriptorUpdateTemplateKHR\\{{Handle}\\}")]
    public unsafe struct VkDescriptorUpdateTemplateKHR : IEquatable<VkDescriptorUpdateTemplateKHR>
    {
        public static VkDescriptorUpdateTemplateKHR Zero => new VkDescriptorUpdateTemplateKHR(0);
        public ulong Handle;
        public VkDescriptorUpdateTemplateKHR(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkDescriptorUpdateTemplateKHR instance && Equals(instance);
        public bool Equals(VkDescriptorUpdateTemplateKHR other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkDescriptorUpdateTemplateKHR left, VkDescriptorUpdateTemplateKHR right) => left.Equals(right);
        public static bool operator !=(VkDescriptorUpdateTemplateKHR left, VkDescriptorUpdateTemplateKHR right) => !(left == right);
        public static explicit operator ulong(VkDescriptorUpdateTemplateKHR handle) => handle.Handle;
        public static explicit operator VkDescriptorUpdateTemplateKHR(ulong handle) => new VkDescriptorUpdateTemplateKHR(handle);
    }
    [DebuggerDisplay("VkSamplerYcbcrConversion\\{{Handle}\\}")]
    public unsafe struct VkSamplerYcbcrConversion : IEquatable<VkSamplerYcbcrConversion>
    {
        public static VkSamplerYcbcrConversion Zero => new VkSamplerYcbcrConversion(0);
        public ulong Handle;
        public VkSamplerYcbcrConversion(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkSamplerYcbcrConversion instance && Equals(instance);
        public bool Equals(VkSamplerYcbcrConversion other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) => left.Equals(right);
        public static bool operator !=(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) => !(left == right);
        public static explicit operator ulong(VkSamplerYcbcrConversion handle) => handle.Handle;
        public static explicit operator VkSamplerYcbcrConversion(ulong handle) => new VkSamplerYcbcrConversion(handle);
    }
    [DebuggerDisplay("VkSamplerYcbcrConversionKHR\\{{Handle}\\}")]
    public unsafe struct VkSamplerYcbcrConversionKHR : IEquatable<VkSamplerYcbcrConversionKHR>
    {
        public static VkSamplerYcbcrConversionKHR Zero => new VkSamplerYcbcrConversionKHR(0);
        public ulong Handle;
        public VkSamplerYcbcrConversionKHR(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkSamplerYcbcrConversionKHR instance && Equals(instance);
        public bool Equals(VkSamplerYcbcrConversionKHR other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkSamplerYcbcrConversionKHR left, VkSamplerYcbcrConversionKHR right) => left.Equals(right);
        public static bool operator !=(VkSamplerYcbcrConversionKHR left, VkSamplerYcbcrConversionKHR right) => !(left == right);
        public static explicit operator ulong(VkSamplerYcbcrConversionKHR handle) => handle.Handle;
        public static explicit operator VkSamplerYcbcrConversionKHR(ulong handle) => new VkSamplerYcbcrConversionKHR(handle);
    }
    [DebuggerDisplay("VkValidationCacheEXT\\{{Handle}\\}")]
    public unsafe struct VkValidationCacheEXT : IEquatable<VkValidationCacheEXT>
    {
        public static VkValidationCacheEXT Zero => new VkValidationCacheEXT(0);
        public ulong Handle;
        public VkValidationCacheEXT(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkValidationCacheEXT instance && Equals(instance);
        public bool Equals(VkValidationCacheEXT other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkValidationCacheEXT left, VkValidationCacheEXT right) => left.Equals(right);
        public static bool operator !=(VkValidationCacheEXT left, VkValidationCacheEXT right) => !(left == right);
        public static explicit operator ulong(VkValidationCacheEXT handle) => handle.Handle;
        public static explicit operator VkValidationCacheEXT(ulong handle) => new VkValidationCacheEXT(handle);
    }
    [DebuggerDisplay("VkAccelerationStructureKHR\\{{Handle}\\}")]
    public unsafe struct VkAccelerationStructureKHR : IEquatable<VkAccelerationStructureKHR>
    {
        public static VkAccelerationStructureKHR Zero => new VkAccelerationStructureKHR(0);
        public ulong Handle;
        public VkAccelerationStructureKHR(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkAccelerationStructureKHR instance && Equals(instance);
        public bool Equals(VkAccelerationStructureKHR other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right) => left.Equals(right);
        public static bool operator !=(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right) => !(left == right);
        public static explicit operator ulong(VkAccelerationStructureKHR handle) => handle.Handle;
        public static explicit operator VkAccelerationStructureKHR(ulong handle) => new VkAccelerationStructureKHR(handle);
    }
    [DebuggerDisplay("VkAccelerationStructureNV\\{{Handle}\\}")]
    public unsafe struct VkAccelerationStructureNV : IEquatable<VkAccelerationStructureNV>
    {
        public static VkAccelerationStructureNV Zero => new VkAccelerationStructureNV(0);
        public ulong Handle;
        public VkAccelerationStructureNV(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkAccelerationStructureNV instance && Equals(instance);
        public bool Equals(VkAccelerationStructureNV other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkAccelerationStructureNV left, VkAccelerationStructureNV right) => left.Equals(right);
        public static bool operator !=(VkAccelerationStructureNV left, VkAccelerationStructureNV right) => !(left == right);
        public static explicit operator ulong(VkAccelerationStructureNV handle) => handle.Handle;
        public static explicit operator VkAccelerationStructureNV(ulong handle) => new VkAccelerationStructureNV(handle);
    }
    [DebuggerDisplay("VkPerformanceConfigurationINTEL\\{{Handle}\\}")]
    public unsafe struct VkPerformanceConfigurationINTEL : IEquatable<VkPerformanceConfigurationINTEL>
    {
        public static VkPerformanceConfigurationINTEL Zero => new VkPerformanceConfigurationINTEL(0);
        public ulong Handle;
        public VkPerformanceConfigurationINTEL(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkPerformanceConfigurationINTEL instance && Equals(instance);
        public bool Equals(VkPerformanceConfigurationINTEL other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right) => left.Equals(right);
        public static bool operator !=(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right) => !(left == right);
        public static explicit operator ulong(VkPerformanceConfigurationINTEL handle) => handle.Handle;
        public static explicit operator VkPerformanceConfigurationINTEL(ulong handle) => new VkPerformanceConfigurationINTEL(handle);
    }
    [DebuggerDisplay("VkBufferCollectionFUCHSIA\\{{Handle}\\}")]
    public unsafe struct VkBufferCollectionFUCHSIA : IEquatable<VkBufferCollectionFUCHSIA>
    {
        public static VkBufferCollectionFUCHSIA Zero => new VkBufferCollectionFUCHSIA(0);
        public ulong Handle;
        public VkBufferCollectionFUCHSIA(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkBufferCollectionFUCHSIA instance && Equals(instance);
        public bool Equals(VkBufferCollectionFUCHSIA other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkBufferCollectionFUCHSIA left, VkBufferCollectionFUCHSIA right) => left.Equals(right);
        public static bool operator !=(VkBufferCollectionFUCHSIA left, VkBufferCollectionFUCHSIA right) => !(left == right);
        public static explicit operator ulong(VkBufferCollectionFUCHSIA handle) => handle.Handle;
        public static explicit operator VkBufferCollectionFUCHSIA(ulong handle) => new VkBufferCollectionFUCHSIA(handle);
    }
    [DebuggerDisplay("VkDeferredOperationKHR\\{{Handle}\\}")]
    public unsafe struct VkDeferredOperationKHR : IEquatable<VkDeferredOperationKHR>
    {
        public static VkDeferredOperationKHR Zero => new VkDeferredOperationKHR(0);
        public ulong Handle;
        public VkDeferredOperationKHR(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkDeferredOperationKHR instance && Equals(instance);
        public bool Equals(VkDeferredOperationKHR other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkDeferredOperationKHR left, VkDeferredOperationKHR right) => left.Equals(right);
        public static bool operator !=(VkDeferredOperationKHR left, VkDeferredOperationKHR right) => !(left == right);
        public static explicit operator ulong(VkDeferredOperationKHR handle) => handle.Handle;
        public static explicit operator VkDeferredOperationKHR(ulong handle) => new VkDeferredOperationKHR(handle);
    }
    [DebuggerDisplay("VkPrivateDataSlot\\{{Handle}\\}")]
    public unsafe struct VkPrivateDataSlot : IEquatable<VkPrivateDataSlot>
    {
        public static VkPrivateDataSlot Zero => new VkPrivateDataSlot(0);
        public ulong Handle;
        public VkPrivateDataSlot(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkPrivateDataSlot instance && Equals(instance);
        public bool Equals(VkPrivateDataSlot other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkPrivateDataSlot left, VkPrivateDataSlot right) => left.Equals(right);
        public static bool operator !=(VkPrivateDataSlot left, VkPrivateDataSlot right) => !(left == right);
        public static explicit operator ulong(VkPrivateDataSlot handle) => handle.Handle;
        public static explicit operator VkPrivateDataSlot(ulong handle) => new VkPrivateDataSlot(handle);
    }
    [DebuggerDisplay("VkPrivateDataSlotEXT\\{{Handle}\\}")]
    public unsafe struct VkPrivateDataSlotEXT : IEquatable<VkPrivateDataSlotEXT>
    {
        public static VkPrivateDataSlotEXT Zero => new VkPrivateDataSlotEXT(0);
        public ulong Handle;
        public VkPrivateDataSlotEXT(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkPrivateDataSlotEXT instance && Equals(instance);
        public bool Equals(VkPrivateDataSlotEXT other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right) => left.Equals(right);
        public static bool operator !=(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right) => !(left == right);
        public static explicit operator ulong(VkPrivateDataSlotEXT handle) => handle.Handle;
        public static explicit operator VkPrivateDataSlotEXT(ulong handle) => new VkPrivateDataSlotEXT(handle);
    }
    [DebuggerDisplay("VkCuModuleNVX\\{{Handle}\\}")]
    public unsafe struct VkCuModuleNVX : IEquatable<VkCuModuleNVX>
    {
        public static VkCuModuleNVX Zero => new VkCuModuleNVX(0);
        public ulong Handle;
        public VkCuModuleNVX(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkCuModuleNVX instance && Equals(instance);
        public bool Equals(VkCuModuleNVX other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkCuModuleNVX left, VkCuModuleNVX right) => left.Equals(right);
        public static bool operator !=(VkCuModuleNVX left, VkCuModuleNVX right) => !(left == right);
        public static explicit operator ulong(VkCuModuleNVX handle) => handle.Handle;
        public static explicit operator VkCuModuleNVX(ulong handle) => new VkCuModuleNVX(handle);
    }
    [DebuggerDisplay("VkCuFunctionNVX\\{{Handle}\\}")]
    public unsafe struct VkCuFunctionNVX : IEquatable<VkCuFunctionNVX>
    {
        public static VkCuFunctionNVX Zero => new VkCuFunctionNVX(0);
        public ulong Handle;
        public VkCuFunctionNVX(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkCuFunctionNVX instance && Equals(instance);
        public bool Equals(VkCuFunctionNVX other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkCuFunctionNVX left, VkCuFunctionNVX right) => left.Equals(right);
        public static bool operator !=(VkCuFunctionNVX left, VkCuFunctionNVX right) => !(left == right);
        public static explicit operator ulong(VkCuFunctionNVX handle) => handle.Handle;
        public static explicit operator VkCuFunctionNVX(ulong handle) => new VkCuFunctionNVX(handle);
    }
    [DebuggerDisplay("VkOpticalFlowSessionNV\\{{Handle}\\}")]
    public unsafe struct VkOpticalFlowSessionNV : IEquatable<VkOpticalFlowSessionNV>
    {
        public static VkOpticalFlowSessionNV Zero => new VkOpticalFlowSessionNV(0);
        public ulong Handle;
        public VkOpticalFlowSessionNV(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkOpticalFlowSessionNV instance && Equals(instance);
        public bool Equals(VkOpticalFlowSessionNV other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkOpticalFlowSessionNV left, VkOpticalFlowSessionNV right) => left.Equals(right);
        public static bool operator !=(VkOpticalFlowSessionNV left, VkOpticalFlowSessionNV right) => !(left == right);
        public static explicit operator ulong(VkOpticalFlowSessionNV handle) => handle.Handle;
        public static explicit operator VkOpticalFlowSessionNV(ulong handle) => new VkOpticalFlowSessionNV(handle);
    }
    [DebuggerDisplay("VkMicromapEXT\\{{Handle}\\}")]
    public unsafe struct VkMicromapEXT : IEquatable<VkMicromapEXT>
    {
        public static VkMicromapEXT Zero => new VkMicromapEXT(0);
        public ulong Handle;
        public VkMicromapEXT(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkMicromapEXT instance && Equals(instance);
        public bool Equals(VkMicromapEXT other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkMicromapEXT left, VkMicromapEXT right) => left.Equals(right);
        public static bool operator !=(VkMicromapEXT left, VkMicromapEXT right) => !(left == right);
        public static explicit operator ulong(VkMicromapEXT handle) => handle.Handle;
        public static explicit operator VkMicromapEXT(ulong handle) => new VkMicromapEXT(handle);
    }
    [DebuggerDisplay("VkShaderEXT\\{{Handle}\\}")]
    public unsafe struct VkShaderEXT : IEquatable<VkShaderEXT>
    {
        public static VkShaderEXT Zero => new VkShaderEXT(0);
        public ulong Handle;
        public VkShaderEXT(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkShaderEXT instance && Equals(instance);
        public bool Equals(VkShaderEXT other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkShaderEXT left, VkShaderEXT right) => left.Equals(right);
        public static bool operator !=(VkShaderEXT left, VkShaderEXT right) => !(left == right);
        public static explicit operator ulong(VkShaderEXT handle) => handle.Handle;
        public static explicit operator VkShaderEXT(ulong handle) => new VkShaderEXT(handle);
    }
    [DebuggerDisplay("VkDisplayKHR\\{{Handle}\\}")]
    public unsafe struct VkDisplayKHR : IEquatable<VkDisplayKHR>
    {
        public static VkDisplayKHR Zero => new VkDisplayKHR(0);
        public ulong Handle;
        public VkDisplayKHR(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkDisplayKHR instance && Equals(instance);
        public bool Equals(VkDisplayKHR other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkDisplayKHR left, VkDisplayKHR right) => left.Equals(right);
        public static bool operator !=(VkDisplayKHR left, VkDisplayKHR right) => !(left == right);
        public static explicit operator ulong(VkDisplayKHR handle) => handle.Handle;
        public static explicit operator VkDisplayKHR(ulong handle) => new VkDisplayKHR(handle);
    }
    [DebuggerDisplay("VkDisplayModeKHR\\{{Handle}\\}")]
    public unsafe struct VkDisplayModeKHR : IEquatable<VkDisplayModeKHR>
    {
        public static VkDisplayModeKHR Zero => new VkDisplayModeKHR(0);
        public ulong Handle;
        public VkDisplayModeKHR(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkDisplayModeKHR instance && Equals(instance);
        public bool Equals(VkDisplayModeKHR other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkDisplayModeKHR left, VkDisplayModeKHR right) => left.Equals(right);
        public static bool operator !=(VkDisplayModeKHR left, VkDisplayModeKHR right) => !(left == right);
        public static explicit operator ulong(VkDisplayModeKHR handle) => handle.Handle;
        public static explicit operator VkDisplayModeKHR(ulong handle) => new VkDisplayModeKHR(handle);
    }
    [DebuggerDisplay("VkSurfaceKHR\\{{Handle}\\}")]
    public unsafe struct VkSurfaceKHR : IEquatable<VkSurfaceKHR>
    {
        public static VkSurfaceKHR Zero => new VkSurfaceKHR(0);
        public ulong Handle;
        public VkSurfaceKHR(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkSurfaceKHR instance && Equals(instance);
        public bool Equals(VkSurfaceKHR other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkSurfaceKHR left, VkSurfaceKHR right) => left.Equals(right);
        public static bool operator !=(VkSurfaceKHR left, VkSurfaceKHR right) => !(left == right);
        public static explicit operator ulong(VkSurfaceKHR handle) => handle.Handle;
        public static explicit operator VkSurfaceKHR(ulong handle) => new VkSurfaceKHR(handle);
    }
    [DebuggerDisplay("VkSwapchainKHR\\{{Handle}\\}")]
    public unsafe struct VkSwapchainKHR : IEquatable<VkSwapchainKHR>
    {
        public static VkSwapchainKHR Zero => new VkSwapchainKHR(0);
        public ulong Handle;
        public VkSwapchainKHR(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkSwapchainKHR instance && Equals(instance);
        public bool Equals(VkSwapchainKHR other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkSwapchainKHR left, VkSwapchainKHR right) => left.Equals(right);
        public static bool operator !=(VkSwapchainKHR left, VkSwapchainKHR right) => !(left == right);
        public static explicit operator ulong(VkSwapchainKHR handle) => handle.Handle;
        public static explicit operator VkSwapchainKHR(ulong handle) => new VkSwapchainKHR(handle);
    }
    [DebuggerDisplay("VkDebugReportCallbackEXT\\{{Handle}\\}")]
    public unsafe struct VkDebugReportCallbackEXT : IEquatable<VkDebugReportCallbackEXT>
    {
        public static VkDebugReportCallbackEXT Zero => new VkDebugReportCallbackEXT(0);
        public ulong Handle;
        public VkDebugReportCallbackEXT(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkDebugReportCallbackEXT instance && Equals(instance);
        public bool Equals(VkDebugReportCallbackEXT other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) => left.Equals(right);
        public static bool operator !=(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) => !(left == right);
        public static explicit operator ulong(VkDebugReportCallbackEXT handle) => handle.Handle;
        public static explicit operator VkDebugReportCallbackEXT(ulong handle) => new VkDebugReportCallbackEXT(handle);
    }
    [DebuggerDisplay("VkDebugUtilsMessengerEXT\\{{Handle}\\}")]
    public unsafe struct VkDebugUtilsMessengerEXT : IEquatable<VkDebugUtilsMessengerEXT>
    {
        public static VkDebugUtilsMessengerEXT Zero => new VkDebugUtilsMessengerEXT(0);
        public ulong Handle;
        public VkDebugUtilsMessengerEXT(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkDebugUtilsMessengerEXT instance && Equals(instance);
        public bool Equals(VkDebugUtilsMessengerEXT other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) => left.Equals(right);
        public static bool operator !=(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) => !(left == right);
        public static explicit operator ulong(VkDebugUtilsMessengerEXT handle) => handle.Handle;
        public static explicit operator VkDebugUtilsMessengerEXT(ulong handle) => new VkDebugUtilsMessengerEXT(handle);
    }
    [DebuggerDisplay("VkVideoSessionKHR\\{{Handle}\\}")]
    public unsafe struct VkVideoSessionKHR : IEquatable<VkVideoSessionKHR>
    {
        public static VkVideoSessionKHR Zero => new VkVideoSessionKHR(0);
        public ulong Handle;
        public VkVideoSessionKHR(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkVideoSessionKHR instance && Equals(instance);
        public bool Equals(VkVideoSessionKHR other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkVideoSessionKHR left, VkVideoSessionKHR right) => left.Equals(right);
        public static bool operator !=(VkVideoSessionKHR left, VkVideoSessionKHR right) => !(left == right);
        public static explicit operator ulong(VkVideoSessionKHR handle) => handle.Handle;
        public static explicit operator VkVideoSessionKHR(ulong handle) => new VkVideoSessionKHR(handle);
    }
    [DebuggerDisplay("VkVideoSessionParametersKHR\\{{Handle}\\}")]
    public unsafe struct VkVideoSessionParametersKHR : IEquatable<VkVideoSessionParametersKHR>
    {
        public static VkVideoSessionParametersKHR Zero => new VkVideoSessionParametersKHR(0);
        public ulong Handle;
        public VkVideoSessionParametersKHR(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkVideoSessionParametersKHR instance && Equals(instance);
        public bool Equals(VkVideoSessionParametersKHR other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkVideoSessionParametersKHR left, VkVideoSessionParametersKHR right) => left.Equals(right);
        public static bool operator !=(VkVideoSessionParametersKHR left, VkVideoSessionParametersKHR right) => !(left == right);
        public static explicit operator ulong(VkVideoSessionParametersKHR handle) => handle.Handle;
        public static explicit operator VkVideoSessionParametersKHR(ulong handle) => new VkVideoSessionParametersKHR(handle);
    }
    [DebuggerDisplay("VkSemaphoreSciSyncPoolNV\\{{Handle}\\}")]
    public unsafe struct VkSemaphoreSciSyncPoolNV : IEquatable<VkSemaphoreSciSyncPoolNV>
    {
        public static VkSemaphoreSciSyncPoolNV Zero => new VkSemaphoreSciSyncPoolNV(0);
        public ulong Handle;
        public VkSemaphoreSciSyncPoolNV(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkSemaphoreSciSyncPoolNV instance && Equals(instance);
        public bool Equals(VkSemaphoreSciSyncPoolNV other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkSemaphoreSciSyncPoolNV left, VkSemaphoreSciSyncPoolNV right) => left.Equals(right);
        public static bool operator !=(VkSemaphoreSciSyncPoolNV left, VkSemaphoreSciSyncPoolNV right) => !(left == right);
        public static explicit operator ulong(VkSemaphoreSciSyncPoolNV handle) => handle.Handle;
        public static explicit operator VkSemaphoreSciSyncPoolNV(ulong handle) => new VkSemaphoreSciSyncPoolNV(handle);
    }
    [DebuggerDisplay("VkCudaModuleNV\\{{Handle}\\}")]
    public unsafe struct VkCudaModuleNV : IEquatable<VkCudaModuleNV>
    {
        public static VkCudaModuleNV Zero => new VkCudaModuleNV(0);
        public ulong Handle;
        public VkCudaModuleNV(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkCudaModuleNV instance && Equals(instance);
        public bool Equals(VkCudaModuleNV other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkCudaModuleNV left, VkCudaModuleNV right) => left.Equals(right);
        public static bool operator !=(VkCudaModuleNV left, VkCudaModuleNV right) => !(left == right);
        public static explicit operator ulong(VkCudaModuleNV handle) => handle.Handle;
        public static explicit operator VkCudaModuleNV(ulong handle) => new VkCudaModuleNV(handle);
    }
    [DebuggerDisplay("VkCudaFunctionNV\\{{Handle}\\}")]
    public unsafe struct VkCudaFunctionNV : IEquatable<VkCudaFunctionNV>
    {
        public static VkCudaFunctionNV Zero => new VkCudaFunctionNV(0);
        public ulong Handle;
        public VkCudaFunctionNV(ulong handle) => Handle = handle;
        public override bool Equals(object? obj) => obj is VkCudaFunctionNV instance && Equals(instance);
        public bool Equals(VkCudaFunctionNV other) => Handle.Equals(other.Handle);
        public override int GetHashCode() => HashCode.Combine(Handle);
        public override string? ToString() => Handle.ToString();
        public static bool operator ==(VkCudaFunctionNV left, VkCudaFunctionNV right) => left.Equals(right);
        public static bool operator !=(VkCudaFunctionNV left, VkCudaFunctionNV right) => !(left == right);
        public static explicit operator ulong(VkCudaFunctionNV handle) => handle.Handle;
        public static explicit operator VkCudaFunctionNV(ulong handle) => new VkCudaFunctionNV(handle);
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}

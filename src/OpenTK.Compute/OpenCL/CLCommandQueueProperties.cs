//
// CLCommandQueueProperties.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenTK.Compute.OpenCL
{
    /// <summary>
    /// Convenience class for handling CLCommandQueue Properties
    /// </summary>
    public struct CLCommandQueueProperties
    {
        public CommandQueueProperties? Properties { get; set; }
        public uint? QueueSize { get; set; }
        public bool? KernelBatchingARM { get; set; }
        public bool? DeferredFlushARM { get; set; }
        public uint? FamilyIntel { get; set; }
        public uint? IndexIntel { get; set; }

        /// <summary>
        /// Gets or sets additional properties for forward compatibility
        /// </summary>
        public ulong[] AdditionalProperties { get; set; }

        /// <summary>
        /// Converts these context properties to a <see cref="CL.CreateCommandQueueWithProperties(CLContext, MemoryFlags, uint, uint, IntPtr[], out CLResultCode)"/> compatible list.
        /// Alternativly, consider using the more convenient <see cref="CL.CreateCommandQueueWithProperties(CLCommandQueueProperties, CLDevice[], IntPtr, IntPtr, out CLResultCode)"/> overload.
        /// </summary>
        /// <returns>The attibute list in the form of a span.</returns>
        public ulong[] CreatePropertyArray()
        {
            List<ulong> propertyList = new List<ulong>();

            void AddProperty(ulong value, CommandQueueProperty property)
            {
                propertyList.Add((ulong)property);
                propertyList.Add(value);
            }

            if (Properties.HasValue) AddProperty((ulong)Properties.Value, CommandQueueProperty.Properties);
            if (QueueSize.HasValue) AddProperty((ulong)QueueSize.Value, CommandQueueProperty.Size);
            if (KernelBatchingARM.HasValue) AddProperty((ulong)(KernelBatchingARM.Value ? 1 : 0), CommandQueueProperty.KernelBatchingARM);
            if (DeferredFlushARM.HasValue) AddProperty((ulong)(DeferredFlushARM.Value ? 1 : 0), CommandQueueProperty.DeferredFlushARM);
            if (FamilyIntel.HasValue) AddProperty((ulong)FamilyIntel.Value, CommandQueueProperty.FamilyIntel);
            if (IndexIntel.HasValue) AddProperty((ulong)IndexIntel.Value, CommandQueueProperty.IndexIntel);
            if (AdditionalProperties != null)
            {
                propertyList.AddRange(AdditionalProperties);
            }

            if (propertyList.Count == 0) return null;

            // Add the trailing null byte.
            propertyList.Add(0);

            return propertyList.ToArray();
        }

        // Used for ToString.
        private string GetOptionalString<T>(string title, T value)
        {
            if (value == null)
            {
                return null;
            }
            else
            {
                return $"{title}: {value}";
            }
        }

        /// <summary>
        /// Converts the attributes to a string representation.
        /// </summary>
        /// <returns>The string representation of the attributes.</returns>
        public override string ToString()
        {
            return string.Join(", ", new[]{
                GetOptionalString(nameof(Properties), Properties),
                GetOptionalString(nameof(QueueSize), QueueSize) ,
                GetOptionalString(nameof(KernelBatchingARM), KernelBatchingARM) ,
                GetOptionalString(nameof(DeferredFlushARM), DeferredFlushARM) ,
                GetOptionalString(nameof(FamilyIntel), FamilyIntel) ,
                GetOptionalString(nameof(IndexIntel), IndexIntel) ,
                (AdditionalProperties != null ? string.Join(", ", AdditionalProperties) : string.Empty)
                });
        }
    }
}

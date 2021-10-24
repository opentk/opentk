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
    /// Convenience class for handling CLContext Properties
    /// </summary>
    public class CLCommandQueueProperties
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
        public IntPtr[] AdditionalProperties { get; set; }

        public CLCommandQueueProperties()
        {

        }
        public CLCommandQueueProperties(CommandQueueProperties? properties, uint? queueSize = null)
        {
            Properties = properties;
            QueueSize = queueSize;
        }

        /// <summary>
        /// Converts these context properties to a <see cref="CL.CreateCommandQueueWithProperties(CLContext, MemoryFlags, uint, uint, IntPtr[], out CLResultCode)"/> compatible list.
        /// Alternativly, consider using the more convenient <see cref="CL.CreateCommandQueueWithProperties(CLCommandQueueProperties, CLDevice[], IntPtr, IntPtr, out CLResultCode)"/> overload.
        /// </summary>
        /// <returns>The attibute list in the form of a span.</returns>
        public IntPtr[] CreatePropertyArray()
        {
            List<IntPtr> propertyList = new List<IntPtr>();

            void AddProperty(IntPtr value, CommandQueueProperty property)
            {
                propertyList.Add((IntPtr)property);
                propertyList.Add(value);
            }

            if (Properties.HasValue) AddProperty((IntPtr)Properties.Value, CommandQueueProperty.Properties);
            if (QueueSize.HasValue) AddProperty((IntPtr)QueueSize.Value, CommandQueueProperty.Size);
            if (KernelBatchingARM.HasValue) AddProperty((IntPtr)(KernelBatchingARM.Value ? 1 : 0), CommandQueueProperty.KernelBatchingARM);
            if (DeferredFlushARM.HasValue) AddProperty((IntPtr)(DeferredFlushARM.Value ? 1 : 0), CommandQueueProperty.DeferredFlushARM);
            if (FamilyIntel.HasValue) AddProperty((IntPtr)FamilyIntel.Value, CommandQueueProperty.FamilyIntel);
            if (IndexIntel.HasValue) AddProperty((IntPtr)IndexIntel.Value, CommandQueueProperty.IndexIntel);
            if (AdditionalProperties != null)
            {
                propertyList.AddRange(AdditionalProperties);
            }

            if (propertyList.Count == 0) return null;

            // Add the trailing null byte.
            propertyList.Add(IntPtr.Zero);

            return propertyList.ToArray();
        }

        /// <summary>
        /// Parses a CL sampler property list.
        /// </summary>
        /// <param name="propertyArray">The CL sampler attribute list.</param>
        /// <returns>The parsed <see cref="CLCommandQueueProperties"/> object.</returns>
        internal static CLCommandQueueProperties FromArray(IntPtr[] propertyArray)
        {
            List<IntPtr> extra = new List<IntPtr>();
            CLCommandQueueProperties properties = new CLCommandQueueProperties();

            float GetFloat(IntPtr buf)
            {
                var CommandQueue = new float[1];
                Marshal.Copy(buf, CommandQueue, 0, 1);
                return CommandQueue[0];
            }

            void ParseAttribute(IntPtr @enum, IntPtr value)
            {
                switch (@enum.ToInt32())
                {
                    case (int)CommandQueueProperty.Properties:
                        properties.Properties = (CommandQueueProperties)value.ToInt64();
                        break;
                    case (int)CommandQueueProperty.Size:
                        properties.QueueSize = (uint)value.ToInt32();
                        break;
                    case (int)CommandQueueProperty.KernelBatchingARM:
                        properties.KernelBatchingARM = value.ToInt32() == 1;
                        break;
                    case (int)CommandQueueProperty.DeferredFlushARM:
                        properties.DeferredFlushARM = value.ToInt32() == 1;
                        break;
                    case (int)CommandQueueProperty.FamilyIntel:
                        properties.FamilyIntel = (uint)value.ToInt32();
                        break;
                    case (int)CommandQueueProperty.IndexIntel:
                        properties.IndexIntel = (uint)value.ToInt32();
                        break;
                    default:
                        extra.Add(@enum); extra.Add(value);
                        break;
                }
            }

            for (int i = 0; i < propertyArray.Length - 1; i += 2)
            {
                ParseAttribute(propertyArray[i], propertyArray[i + 1]);
            }

            properties.AdditionalProperties = extra.ToArray();

            return properties;
        }

        // Used for ToString.
        private string GetOptionalString<IntPtr>(string title, IntPtr value)
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
            return $"{((AdditionalProperties != null) ? ", " + string.Join(", ", AdditionalProperties) : string.Empty)}";
        }
    }
}

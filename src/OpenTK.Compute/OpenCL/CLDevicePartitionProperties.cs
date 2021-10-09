//
// CLDevicePartitionProperties.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;

namespace OpenTK.Compute.OpenCL
{
    /// <summary>
    /// Convenience class for handling CLDevice Partition Properties
    /// </summary>
    public class CLDevicePartitionProperties
    {
        public uint? Equally { get; set; }
        public uint[] ByCounts { get; set; }
        public CLDevice.AffinityDomain? ByAffinityDomain { get; set; }

        /// <summary>
        /// Gets or sets additional properties for forward compatibility
        /// </summary>
        public IntPtr[] AdditionalProperties { get; set; }

        public CLDevicePartitionProperties()
        {

        }

        /// <summary>
        /// Converts these context properties to a <see cref="CL.CreateSubDevice(CLContext, MemoryFlags, uint, uint, IntPtr[], out CLResultCode)"/> compatible list.
        /// Alternativly, consider using the more convenient <see cref="CL.CreateSubDevice(CLDevicePartitionProperties, CLDevice[], IntPtr, IntPtr, out CLResultCode)"/> overload.
        /// </summary>
        /// <returns>The attibute list in the form of a span.</returns>
        public IntPtr[] CreatePropertyArray()
        {
            List<IntPtr> propertyList = new List<IntPtr>();

            void AddProperty(IntPtr value, CLDevice.PartitionProperty property)
            {
                propertyList.Add((IntPtr)property);
                propertyList.Add(value);
            }

            if (Equally.HasValue) AddProperty((IntPtr)Equally.Value, CLDevice.PartitionProperty.Equally);
            if (ByCounts.Length > 0)
            {
                propertyList.Add((IntPtr)CLDevice.PartitionProperty.ByCounts);
                propertyList.AddRange(from value in ByCounts
                                      select (IntPtr)value);
                propertyList.Add((IntPtr)CLDevice.PartitionProperty.ByCountsListEnd);
            }
            if (ByAffinityDomain.HasValue) AddProperty((IntPtr)ByAffinityDomain.Value, CLDevice.PartitionProperty.ByAffinityDomain);

            if (AdditionalProperties != null)
            {
                propertyList.AddRange(AdditionalProperties);
            }

            // Add the trailing null byte.
            propertyList.Add(IntPtr.Zero);

            return propertyList.ToArray();
        }

        /// <summary>
        /// Parses a CL sampler property list.
        /// </summary>
        /// <param name="propertyArray">The CL sampler attribute list.</param>
        /// <returns>The parsed <see cref="CLDevicePartitionProperties"/> object.</returns>
        internal static CLDevicePartitionProperties FromArray(IntPtr[] propertyArray)
        {
            List<IntPtr> extra = new List<IntPtr>();
            CLDevicePartitionProperties properties = new CLDevicePartitionProperties();

            for (int i = 0; i < propertyArray.Length - 1; i += 2)
            {
                switch (propertyArray[i].ToInt32())
                {
                    case (int)CLDevice.PartitionProperty.Equally:
                        properties.Equally = (uint)propertyArray[i + 1].ToInt32();
                        break;
                    case (int)CLDevice.PartitionProperty.ByAffinityDomain:
                        properties.ByAffinityDomain = (CLDevice.AffinityDomain)propertyArray[i + 1].ToInt64();
                        break;
                    case (int)CLDevice.PartitionProperty.ByCounts:
                        var value = (uint)propertyArray[i + 1];
                        var list = new List<uint>();
                        while (value != (uint)CLDevice.PartitionProperty.ByCountsListEnd){
                            list.Add(value);
                            i++;
                            if (i >= propertyArray.Length - 1) break;
                            value = (uint)propertyArray[i + 1];
                        }
                        properties.ByCounts = list.ToArray();
                        break;
                    default:
                        extra.Add(propertyArray[i]); extra.Add(propertyArray[i + 1]);
                        break;
                }
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

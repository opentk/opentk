//
// CLSamplerProperties.cs
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
    /// Convenience class for handling CLSampler Properties
    /// </summary>
    public struct CLSamplerProperties
    {
        public bool? NormalizedCoords { get; set; }
        public SamplerAddressingMode? AddressingMode { get; set; }
        public SamplerFilterMode? FilterMode { get; set; }
        public SamplerFilterMode? MipFilterModeKHR { get; set; }
        public float? LodMinKHR { get; set; }
        public float? LodMaxKHR { get; set; }

        /// <summary>
        /// Gets or sets additional properties for forward compatibility
        /// </summary>
        public ulong[] AdditionalProperties { get; set; }

        /// <summary>
        /// Converts these context properties to a <see cref="CL.CreateContext(IntPtr[], CLDevice[], IntPtr, IntPtr, out CLResultCode)"/> compatible list.
        /// Alternativly, consider using the more convenient <see cref="CL.CreateContext(CLSamplerProperties, CLDevice[], IntPtr, IntPtr, out CLResultCode)"/> overload.
        /// </summary>
        /// <returns>The attibute list in the form of a span.</returns>
        public ulong[] CreatePropertyArray()
        {
            List<ulong> propertyList = new List<ulong>();

            void AddProperty(ulong value, SamplerProperty property)
            {
                propertyList.Add((ulong)property);
                propertyList.Add(value);
            }

            if (NormalizedCoords != null) AddProperty((ulong)(NormalizedCoords.Value ? 1 : 0), SamplerProperty.NormalizedCoords);
            if (AddressingMode != null) AddProperty((ulong)AddressingMode, SamplerProperty.AddressingMode);
            if (FilterMode != null) AddProperty((ulong)FilterMode, SamplerProperty.FilterMode);
            if (MipFilterModeKHR != null) AddProperty((ulong)MipFilterModeKHR, SamplerProperty.MipFilterModeKHR);
            if (LodMinKHR != null) AddProperty((ulong)BitConverter.SingleToInt32Bits(LodMinKHR.Value), SamplerProperty.LodMinKHR);
            if (LodMaxKHR != null) AddProperty((ulong)BitConverter.SingleToInt32Bits(LodMaxKHR.Value), SamplerProperty.LodMaxKHR);

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
                GetOptionalString(nameof(NormalizedCoords), NormalizedCoords) ,
                GetOptionalString(nameof(AddressingMode), AddressingMode) ,
                GetOptionalString(nameof(FilterMode), FilterMode) ,
                GetOptionalString(nameof(MipFilterModeKHR), MipFilterModeKHR) ,
                GetOptionalString(nameof(LodMinKHR), LodMinKHR) ,
                GetOptionalString(nameof(LodMaxKHR), LodMaxKHR) ,
                (AdditionalProperties != null ? string.Join(", ", AdditionalProperties) : string.Empty)
                });
        }
    }
}

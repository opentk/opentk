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
    /// Convenience class for handling CLContext Properties
    /// </summary>
    public class CLSamplerProperties
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
        public IntPtr[] AdditionalProperties { get; set; }

        public CLSamplerProperties(){

        }

        public CLSamplerProperties(bool? normalizedCoords, SamplerAddressingMode? addressingMode, SamplerFilterMode? filterMode)
        {
            NormalizedCoords = normalizedCoords;
            AddressingMode = addressingMode;
            FilterMode = filterMode;
        }

        public CLSamplerProperties(bool? normalizedCoords, SamplerAddressingMode? addressingMode,
                                   SamplerFilterMode? filterMode, SamplerFilterMode? mipFilterModeKHR, float? lodMinKHR,
                                   float? lodMaxKHR)
        {
            NormalizedCoords = normalizedCoords;
            AddressingMode = addressingMode;
            FilterMode = filterMode;
            MipFilterModeKHR = mipFilterModeKHR;
            LodMinKHR = lodMinKHR;
            LodMaxKHR = lodMaxKHR;
        }


        /// <summary>
        /// Converts these context properties to a <see cref="CL.CreateContext(IntPtr[], CLDevice[], IntPtr, IntPtr, out CLResultCode)"/> compatible list.
        /// Alternativly, consider using the more convenient <see cref="CL.CreateContext(CLSamplerProperties, CLDevice[], IntPtr, IntPtr, out CLResultCode)"/> overload.
        /// </summary>
        /// <returns>The attibute list in the form of a span.</returns>
        public IntPtr[] CreatePropertyArray()
        {
            List<IntPtr> propertyList = new List<IntPtr>();

            void AddProperty(IntPtr value, SamplerProperty property)
            {
                if (value != null)
                {
                    propertyList.Add((IntPtr)property);
                    propertyList.Add(value);
                }
            }

            if (NormalizedCoords != null) AddProperty((IntPtr)(NormalizedCoords.Value ? 1 : 0), SamplerProperty.NormalizedCoords);
            if (AddressingMode != null) AddProperty((IntPtr)AddressingMode, SamplerProperty.AddressingMode);
            if (FilterMode != null) AddProperty((IntPtr)FilterMode, SamplerProperty.FilterMode);
            if (MipFilterModeKHR != null) AddProperty((IntPtr)MipFilterModeKHR, SamplerProperty.MipFilterModeKHR);
            if (LodMinKHR != null) AddProperty((IntPtr)BitConverter.SingleToInt32Bits(LodMinKHR.Value), SamplerProperty.LodMinKHR);
            if (LodMaxKHR != null) AddProperty((IntPtr)BitConverter.SingleToInt32Bits(LodMaxKHR.Value), SamplerProperty.LodMaxKHR);

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
        /// <returns>The parsed <see cref="CLSamplerProperties"/> object.</returns>
        internal static CLSamplerProperties FromArray(IntPtr[] propertyArray)
        {
            List<IntPtr> extra = new List<IntPtr>();
            CLSamplerProperties properties = new CLSamplerProperties();

            float GetFloat(IntPtr buf)
            {
                var buffer = new float[1];
                Marshal.Copy(buf, buffer, 0, 1);
                return buffer[0];
            }

            void ParseAttribute(IntPtr @enum, IntPtr value)
            {
                switch (@enum.ToInt32())
                {
                    case (int)SamplerProperty.NormalizedCoords:
                        properties.NormalizedCoords = (uint)value == 1;
                        break;
                    case (int)SamplerProperty.AddressingMode:
                        properties.AddressingMode = (SamplerAddressingMode)value;
                        break;
                    case (int)SamplerProperty.FilterMode:
                        properties.FilterMode = (SamplerFilterMode)value;
                        break;
                    case (int)SamplerProperty.MipFilterModeKHR:
                        properties.MipFilterModeKHR = (SamplerFilterMode)value;
                        break;
                    case (int)SamplerProperty.LodMinKHR:
                        properties.LodMinKHR = GetFloat(value);
                        break;
                    case (int)SamplerProperty.LodMaxKHR:
                        properties.LodMaxKHR = GetFloat(value);
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
            return $"{GetOptionalString(nameof(NormalizedCoords), NormalizedCoords)}, " +
                $"{GetOptionalString(nameof(AddressingMode), AddressingMode)}, " +
                $"{GetOptionalString(nameof(FilterMode), FilterMode)}, " +
                $"{GetOptionalString(nameof(MipFilterModeKHR), MipFilterModeKHR)}, " +
                $"{GetOptionalString(nameof(LodMinKHR), LodMinKHR)}, " +
                $"{GetOptionalString(nameof(LodMaxKHR), LodMaxKHR)}, " +
                $"{((AdditionalProperties != null) ? ", " + string.Join(", ", AdditionalProperties) : string.Empty)}";
        }
    }
}

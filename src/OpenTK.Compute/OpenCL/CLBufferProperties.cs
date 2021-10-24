//
// CLBufferProperties.cs
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
    public class CLBufferProperties
    {
        /// <summary>
        /// Gets or sets additional properties for forward compatibility
        /// </summary>
        public IntPtr[] AdditionalProperties { get; set; }

        public CLBufferProperties()
        {

        }

        /// <summary>
        /// Converts these context properties to a <see cref="CL.CreateBufferWithProperties(CLContext, MemoryFlags, uint, uint, IntPtr[], out CLResultCode)"/> compatible list.
        /// Alternativly, consider using the more convenient <see cref="CL.CreateBufferWithProperties(CLBufferProperties, CLDevice[], IntPtr, IntPtr, out CLResultCode)"/> overload.
        /// </summary>
        /// <returns>The attibute list in the form of a span.</returns>
        public IntPtr[] CreatePropertyArray()
        {
            List<IntPtr> propertyList = new List<IntPtr>();

            void AddProperty(IntPtr value, BufferProperty property)
            {
                if (value != null)
                {
                    propertyList.Add((IntPtr)property);
                    propertyList.Add(value);
                }
            }

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
        /// <returns>The parsed <see cref="CLBufferProperties"/> object.</returns>
        internal static CLBufferProperties FromArray(IntPtr[] propertyArray)
        {
            List<IntPtr> extra = new List<IntPtr>();
            CLBufferProperties properties = new CLBufferProperties();

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

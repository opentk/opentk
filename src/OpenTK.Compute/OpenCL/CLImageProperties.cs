//
// CLImageProperties.cs
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
    /// Convenience class for handling CLImage Properties
    /// </summary>
    public struct CLImageProperties
    {
        /// <summary>
        /// Gets or sets additional properties for forward compatibility
        /// </summary>
        public ulong[] AdditionalProperties { get; set; }

        /// <summary>
        /// Converts these context properties to a <see cref="CL.CreateImageWithProperties(CLContext, MemoryFlags, uint, uint, IntPtr[], out CLResultCode)"/> compatible list.
        /// Alternativly, consider using the more convenient <see cref="CL.CreateImageWithProperties(CLImageProperties, CLDevice[], IntPtr, IntPtr, out CLResultCode)"/> overload.
        /// </summary>
        /// <returns>The attibute list in the form of a span.</returns>
        public ulong[] CreatePropertyArray()
        {
            List<ulong> propertyList = new List<ulong>();


            if (AdditionalProperties != null)
            {
                propertyList.AddRange(AdditionalProperties);
            }

            if (propertyList.Count == 0) return null;

            // Add the trailing null byte.
            propertyList.Add(0);

            return propertyList.ToArray();
        }

        /// <summary>
        /// Converts the attributes to a string representation.
        /// </summary>
        /// <returns>The string representation of the attributes.</returns>
        public override string ToString()
        {
            return ((AdditionalProperties != null) ? string.Join(", ", AdditionalProperties) : string.Empty);
        }
    }
}

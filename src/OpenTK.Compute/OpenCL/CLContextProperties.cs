//
// CLContextProperties.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;

namespace OpenTK.Compute.OpenCL
{
    /// <summary>
    /// Convenience class for handling CLContext Properties
    /// </summary>
    public struct CLContextProperties
    {
        public CLPlatform ContextPlatform { get; set; }
        public bool? ContextInteropUserSync { get; set; }
        public IntPtr? GlContextKHR { get; set; }
        public IntPtr? EglDisplayKHR { get; set; }
        public IntPtr? GlxDisplayKHR { get; set; }
        public IntPtr? WglHDCKHR { get; set; }
        public IntPtr? CglShareGroupKHR { get; set; }
        public IntPtr? ContextD3D10DeviceKHR { get; set; }
        public IntPtr? ContextD3D11DeviceKHR { get; set; }
        public IntPtr? ContextAdapterD3D9KHR { get; set; }
        public IntPtr? ContextAdapterD3D9ExKHR { get; set; }
        public IntPtr? ContextAdapterDXVAKHR { get; set; }
        public ContextMemoryInitializeKHR? ContextMemoryInitializeKHR { get; set; }
        public bool? ContextTerminateKHR { get; set; }

        /// <summary>
        /// Gets or sets additional properties.
        /// Will usually be the major and minor version numbers of the context.
        /// </summary>
        public IntPtr[] AdditionalProperties { get; set; }


        /// <summary>
        /// Converts these context properties to a <see cref="CL.CreateContext(IntPtr[], CLDevice[], IntPtr, IntPtr, out CLResultCode)"/> compatible list.
        /// Alternativly, consider using the more convenient <see cref="CL.CreateContext(CLContextProperties, CLDevice[], IntPtr, IntPtr, out CLResultCode)"/> overload.
        /// </summary>
        /// <returns>The attibute list in the form of a span.</returns>
        public IntPtr[] CreatePropertyArray()
        {
            // The number of members * 2 + AdditionalProperties
            List<IntPtr> propertyList = new List<IntPtr>();

            void AddProperty(IntPtr value, ContextProperty property)
            {
                propertyList.Add((IntPtr)property);
                propertyList.Add(value);
            }

            if (ContextPlatform.Handle != IntPtr.Zero) AddProperty(ContextPlatform, ContextProperty.ContextPlatform);
            if (ContextInteropUserSync.HasValue) AddProperty((IntPtr)(ContextInteropUserSync.Value ? 1 : 0), ContextProperty.ContextInteropUserSync);
            if (GlContextKHR.HasValue) AddProperty(GlContextKHR.Value, ContextProperty.GlContextKHR);
            if (EglDisplayKHR.HasValue) AddProperty(EglDisplayKHR.Value, ContextProperty.EglDisplayKHR);
            if (GlxDisplayKHR.HasValue) AddProperty(GlxDisplayKHR.Value, ContextProperty.GlxDisplayKHR);
            if (WglHDCKHR.HasValue) AddProperty(WglHDCKHR.Value, ContextProperty.WglHDCKHR);
            if (CglShareGroupKHR.HasValue) AddProperty(CglShareGroupKHR.Value, ContextProperty.CglShareGroupKHR);
            if (ContextD3D10DeviceKHR.HasValue) AddProperty(ContextD3D10DeviceKHR.Value, ContextProperty.ContextD3D10DeviceKHR);
            if (ContextD3D11DeviceKHR.HasValue) AddProperty(ContextD3D11DeviceKHR.Value, ContextProperty.ContextD3D11DeviceKHR);
            if (ContextAdapterD3D9KHR.HasValue) AddProperty(ContextAdapterD3D9KHR.Value, ContextProperty.ContextAdapterD3D9KHR);
            if (ContextAdapterD3D9ExKHR.HasValue) AddProperty(ContextAdapterD3D9ExKHR.Value, ContextProperty.ContextAdapterD3D9ExKHR);
            if (ContextAdapterDXVAKHR.HasValue) AddProperty(ContextAdapterDXVAKHR.Value, ContextProperty.ContextAdapterDXVAKHR);
            if (ContextMemoryInitializeKHR.HasValue) AddProperty((IntPtr)ContextMemoryInitializeKHR.Value, ContextProperty.ContextMemoryInitializeKHR);
            if (ContextTerminateKHR.HasValue) AddProperty((IntPtr)(ContextTerminateKHR.Value ? 1 : 0), ContextProperty.ContextTerminateKHR);

            if (AdditionalProperties != null)
            {
                propertyList.AddRange(AdditionalProperties);
            }

            if (propertyList.Count == 0) return null;

            // Add the trailing null byte.
            propertyList.Add(IntPtr.Zero);

            return propertyList.ToArray();
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
            return string.Join(", ", new[]{
                GetOptionalString(nameof(ContextPlatform), ContextPlatform),
                GetOptionalString(nameof(GlContextKHR), GlContextKHR),
                GetOptionalString(nameof(EglDisplayKHR), EglDisplayKHR),
                GetOptionalString(nameof(GlxDisplayKHR), GlxDisplayKHR),
                GetOptionalString(nameof(WglHDCKHR), WglHDCKHR),
                GetOptionalString(nameof(CglShareGroupKHR), CglShareGroupKHR),
                GetOptionalString(nameof(ContextInteropUserSync), ContextInteropUserSync),
                GetOptionalString(nameof(ContextD3D10DeviceKHR), ContextD3D10DeviceKHR),
                GetOptionalString(nameof(ContextD3D11DeviceKHR), ContextD3D11DeviceKHR),
                GetOptionalString(nameof(ContextAdapterD3D9KHR), ContextAdapterD3D9KHR),
                GetOptionalString(nameof(ContextAdapterD3D9ExKHR), ContextAdapterD3D9ExKHR),
                GetOptionalString(nameof(ContextAdapterDXVAKHR), ContextAdapterDXVAKHR),
                GetOptionalString(nameof(ContextMemoryInitializeKHR), ContextMemoryInitializeKHR),
                GetOptionalString(nameof(ContextTerminateKHR), ContextTerminateKHR),
                (AdditionalProperties != null ? string.Join(", ", AdditionalProperties) : string.Empty)
                });
        }
    }
}
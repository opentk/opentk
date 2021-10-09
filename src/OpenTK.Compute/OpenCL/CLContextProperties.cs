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
    public class CLContextProperties
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
        public CLContext.MemoryInitializeKHR? ContextMemoryInitializeKHR { get; set; }
        public bool? ContextTerminateKHR { get; set; }

        /// <summary>
        /// Gets or sets additional properties.
        /// Will usually be the major and minor version numbers of the context.
        /// </summary>
        public IntPtr[] AdditionalProperties { get; set; }

        public CLContextProperties()
        {

        }

        public CLContextProperties(
            CLPlatform contextPlatform,
            bool? contextInteropUserSync)
        {
            ContextPlatform = contextPlatform;
            ContextInteropUserSync = contextInteropUserSync;
        }

        public CLContextProperties(
            CLPlatform contextPlatform,
            bool? contextInteropUserSync,
            IntPtr? glContextKHR,
            IntPtr? eglDisplayKHR,
            IntPtr? glxDisplayKHR,
            IntPtr? wglHDCKHR,
            IntPtr? cglShareGroupKHR,
            IntPtr? contextD3D10DeviceKHR,
            IntPtr? contextD3D11DeviceKHR,
            IntPtr? contextAdapterD3D9KHR,
            IntPtr? contextAdapterD3D9ExKHR,
            IntPtr? contextAdapterDXVAKHR,
            CLContext.MemoryInitializeKHR? contextMemoryInitializeKHR,
            bool? contextTerminateKHR)
        {
            ContextPlatform = contextPlatform;
            ContextInteropUserSync = contextInteropUserSync;
            GlContextKHR = glContextKHR;
            EglDisplayKHR = eglDisplayKHR;
            GlxDisplayKHR = glxDisplayKHR;
            WglHDCKHR = wglHDCKHR;
            CglShareGroupKHR = cglShareGroupKHR;
            ContextD3D10DeviceKHR = contextD3D10DeviceKHR;
            ContextD3D11DeviceKHR = contextD3D11DeviceKHR;
            ContextAdapterD3D9KHR = contextAdapterD3D9KHR;
            ContextAdapterD3D9ExKHR = contextAdapterD3D9ExKHR;
            ContextAdapterDXVAKHR = contextAdapterDXVAKHR;
            ContextMemoryInitializeKHR = contextMemoryInitializeKHR;
            ContextTerminateKHR = contextTerminateKHR;
        }


        /// <summary>
        /// Converts these context properties to a <see cref="CL.CreateContext(IntPtr[], CLDevice[], IntPtr, IntPtr, out CLResultCode)"/> compatible list.
        /// Alternativly, consider using the more convenient <see cref="CL.CreateContext(CLContextProperties, CLDevice[], IntPtr, IntPtr, out CLResultCode)"/> overload.
        /// </summary>
        /// <returns>The attibute list in the form of a span.</returns>
        public IntPtr[] CreatePropertyArray()
        {
            // The number of members * 2 + AdditionalProperties
            List<IntPtr> propertyList = new List<IntPtr>();

            void AddProperty(IntPtr value, CLContext.Property property)
            {
                propertyList.Add((IntPtr)property);
                propertyList.Add(value);                
            }

            if (ContextPlatform != null) AddProperty(ContextPlatform, CLContext.Property.ContextPlatform);
            if (ContextInteropUserSync.HasValue) AddProperty((IntPtr)(ContextInteropUserSync.Value?1:0), CLContext.Property.ContextInteropUserSync);
            if (GlContextKHR.HasValue) AddProperty(GlContextKHR.Value, CLContext.Property.GlContextKHR);
            if (EglDisplayKHR.HasValue) AddProperty(EglDisplayKHR.Value, CLContext.Property.EglDisplayKHR);
            if (GlxDisplayKHR.HasValue) AddProperty(GlxDisplayKHR.Value, CLContext.Property.GlxDisplayKHR);
            if (WglHDCKHR.HasValue) AddProperty(WglHDCKHR.Value, CLContext.Property.WglHDCKHR);
            if (CglShareGroupKHR.HasValue) AddProperty(CglShareGroupKHR.Value, CLContext.Property.CglShareGroupKHR);
            if (ContextD3D10DeviceKHR.HasValue) AddProperty(ContextD3D10DeviceKHR.Value, CLContext.Property.ContextD3D10DeviceKHR);
            if (ContextD3D11DeviceKHR.HasValue) AddProperty(ContextD3D11DeviceKHR.Value, CLContext.Property.ContextD3D11DeviceKHR);
            if (ContextAdapterD3D9KHR.HasValue) AddProperty(ContextAdapterD3D9KHR.Value, CLContext.Property.ContextAdapterD3D9KHR);
            if (ContextAdapterD3D9ExKHR.HasValue) AddProperty(ContextAdapterD3D9ExKHR.Value, CLContext.Property.ContextAdapterD3D9ExKHR);
            if (ContextAdapterDXVAKHR.HasValue) AddProperty(ContextAdapterDXVAKHR.Value, CLContext.Property.ContextAdapterDXVAKHR);
            if (ContextMemoryInitializeKHR.HasValue) AddProperty((IntPtr)ContextMemoryInitializeKHR.Value, CLContext.Property.ContextMemoryInitializeKHR);
            if (ContextTerminateKHR.HasValue) AddProperty((IntPtr)(ContextTerminateKHR.Value ? 1 : 0), CLContext.Property.ContextTerminateKHR);

            if (AdditionalProperties != null)
            {
                propertyList.AddRange(AdditionalProperties);
            }

            // Add the trailing null byte.
            propertyList.Add(IntPtr.Zero);

            return propertyList.ToArray();
        }

        /// <summary>
        /// Parses a CL context property list.
        /// </summary>
        /// <param name="propertyArray">The CL context attribute list.</param>
        /// <returns>The parsed <see cref="CLContextProperties"/> object.</returns>
        internal static CLContextProperties FromArray(IntPtr[] propertyArray)
        {
            List<IntPtr> extra = new List<IntPtr>();
            CLContextProperties properties = new CLContextProperties();

            void ParseAttribute(IntPtr @enum, IntPtr value)
            {
                switch (@enum.ToInt32())
                {
                    case (int)CLContext.Property.ContextPlatform:
                        properties.ContextPlatform = new CLPlatform(value);
                        break;
                    case (int)CLContext.Property.GlContextKHR:
                        properties.GlContextKHR = value;
                        break;
                    case (int)CLContext.Property.EglDisplayKHR:
                        properties.EglDisplayKHR = value;
                        break;
                    case (int)CLContext.Property.GlxDisplayKHR:
                        properties.GlxDisplayKHR = value;
                        break;
                    case (int)CLContext.Property.WglHDCKHR:
                        properties.WglHDCKHR = value;
                        break;
                    case (int)CLContext.Property.CglShareGroupKHR:
                        properties.CglShareGroupKHR = value;
                        break;
                    case (int)CLContext.Property.ContextInteropUserSync:
                        properties.ContextInteropUserSync = value.ToInt32() > 0;
                        break;
                    case (int)CLContext.Property.ContextD3D10DeviceKHR:
                        properties.ContextD3D10DeviceKHR = value;
                        break;
                    case (int)CLContext.Property.ContextD3D11DeviceKHR:
                        properties.ContextD3D11DeviceKHR = value;
                        break;
                    case (int)CLContext.Property.ContextAdapterD3D9KHR:
                        properties.ContextAdapterD3D9KHR = value;
                        break;
                    case (int)CLContext.Property.ContextAdapterD3D9ExKHR:
                        properties.ContextAdapterD3D9ExKHR = value;
                        break;
                    case (int)CLContext.Property.ContextAdapterDXVAKHR:
                        properties.ContextAdapterDXVAKHR = value;
                        break;
                    case (int)CLContext.Property.ContextMemoryInitializeKHR:
                        properties.ContextMemoryInitializeKHR = (CLContext.MemoryInitializeKHR)value.ToInt64();
                        break;
                    case (int)CLContext.Property.ContextTerminateKHR:
                        properties.ContextTerminateKHR = value.ToInt32() > 0;
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
            return $"{GetOptionalString(nameof(ContextPlatform), ContextPlatform)}, " +
                $"{GetOptionalString(nameof(GlContextKHR), GlContextKHR)}, " +
                $"{GetOptionalString(nameof(EglDisplayKHR), EglDisplayKHR)}, " +
                $"{GetOptionalString(nameof(GlxDisplayKHR), GlxDisplayKHR)}, " +
                $"{GetOptionalString(nameof(WglHDCKHR), WglHDCKHR)}, " +
                $"{GetOptionalString(nameof(CglShareGroupKHR), CglShareGroupKHR)}, " +
                $"{GetOptionalString(nameof(ContextInteropUserSync), ContextInteropUserSync)}, " +
                $"{GetOptionalString(nameof(ContextD3D10DeviceKHR), ContextD3D10DeviceKHR)}, " +
                $"{GetOptionalString(nameof(ContextD3D11DeviceKHR), ContextD3D11DeviceKHR)}, " +
                $"{GetOptionalString(nameof(ContextAdapterD3D9KHR), ContextAdapterD3D9KHR)}, " +
                $"{GetOptionalString(nameof(ContextAdapterD3D9ExKHR), ContextAdapterD3D9ExKHR)}, " +
                $"{GetOptionalString(nameof(ContextAdapterDXVAKHR), ContextAdapterDXVAKHR)}, " +
                $"{GetOptionalString(nameof(ContextMemoryInitializeKHR), ContextMemoryInitializeKHR)}, " +
                $"{GetOptionalString(nameof(ContextTerminateKHR), ContextTerminateKHR)}, " +
                $"{((AdditionalProperties != null) ? ", " + string.Join(", ", AdditionalProperties) : string.Empty)}";
        }
    }
}

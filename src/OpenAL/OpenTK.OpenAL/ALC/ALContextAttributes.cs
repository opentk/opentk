//
// ALContextAttributes.cs
//
// Copyright (C) 2020 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio.OpenAL
{
    /// <summary>
    /// Convenience class for handling ALContext attributes.
    /// </summary>
    public class ALContextAttributes
    {
        /// <summary>
        /// Gets or sets the output buffer frequency in Hz.
        /// This does not actually change any AL state. To apply these attributes see <see cref="ALC.CreateContext(ALDevice, ALContextAttributes)"/>.
        /// </summary>
        public int? Frequency { get; set; }

        /// <summary>
        /// Gets or sets the number of mono sources.
        /// This does not actually change any AL state. To apply these attributes see <see cref="ALC.CreateContext(ALDevice, ALContextAttributes)"/>.
        /// Not guaranteed to get exact number of mono sources when creating a context.
        /// </summary>
        public int? MonoSources { get; set; }

        /// <summary>
        /// Gets or sets the number of stereo sources.
        /// This does not actually change any AL state. To apply these attributes see <see cref="ALC.CreateContext(ALDevice, ALContextAttributes)"/>.
        /// Not guaranteed to get exact number of mono sources when creating a context.
        /// </summary>
        public int? StereoSources { get; set; }

        /// <summary>
        /// Gets or sets the refrash interval in Hz.
        /// This does not actually change any AL state. To apply these attributes see <see cref="ALC.CreateContext(ALDevice, ALContextAttributes)"/>.
        /// </summary>
        public int? Refresh { get; set; }

        /// <summary>
        /// Gets or sets if the context is synchronous.
        /// This does not actually change any AL state. To apply these attributes see <see cref="ALC.CreateContext(ALDevice, ALContextAttributes)"/>.
        /// </summary>
        public bool? Sync { get; set; }

        /// <summary>
        /// Gets or sets additional attributes.
        /// Will usually be the major and minor version numbers of the context. // FIXME: This needs verification. Docs say nothing about this.
        /// </summary>
        public int[] AdditionalAttributes { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ALContextAttributes"/> class.
        /// Leaving all attributes to the driver implementation default values.
        /// </summary>
        public ALContextAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ALContextAttributes"/> class.
        /// </summary>
        /// <param name="frequency">The mixing output buffer frequency in Hz.</param>
        /// <param name="monoSources">The number of mono sources available. Not guaranteed.</param>
        /// <param name="stereoSources">The number of stereo sources available. Not guaranteed.</param>
        /// <param name="refresh">The refresh interval in Hz.</param>
        /// <param name="sync">If the context is synchronous.</param>
        public ALContextAttributes(int? frequency, int? monoSources, int? stereoSources, int? refresh, bool? sync)
        {
            Frequency = frequency;
            MonoSources = monoSources;
            StereoSources = stereoSources;
            Refresh = refresh;
            Sync = sync;
        }

        /// <summary>
        /// Converts these context attributes to a <see cref="ALC.CreateContext(ALDevice, int[])"/> compatible list.
        /// Alternativly, consider using the more convenient <see cref="ALC.CreateContext(ALDevice, ALContextAttributes)"/> overload.
        /// </summary>
        /// <returns>The attibute list in the form of a span.</returns>
        public int[] CreateAttributeArray()
        {
            // The number of members * 2 + AdditionalAttributes
            int[] attributeList = new int[(5 * 2) + (AdditionalAttributes?.Length ?? 0) + 1];
            int index = 0;

            void AddAttribute(int? value, AlcContextAttributes attribute)
            {
                if (value != null)
                {
                    attributeList[index++] = (int)attribute;
                    attributeList[index++] = value ?? default;
                }
            }

            AddAttribute(Frequency, AlcContextAttributes.Frequency);
            AddAttribute(MonoSources, AlcContextAttributes.MonoSources);
            AddAttribute(StereoSources, AlcContextAttributes.StereoSources);
            AddAttribute(Refresh, AlcContextAttributes.Refresh);
            if (Sync != null)
            {
                AddAttribute((Sync ?? false) ? 1 : 0, AlcContextAttributes.Sync);
            }

            if (AdditionalAttributes != null)
            {
                Array.Copy(AdditionalAttributes, 0, attributeList, index, AdditionalAttributes.Length);
                index += AdditionalAttributes.Length;
            }

            // Add the trailing null byte.
            attributeList[index++] = 0;

            return attributeList;
        }

        /// <summary>
        /// Parses a AL attribute list.
        /// </summary>
        /// <param name="attributeArray">The AL context attribute list.</param>
        /// <returns>The parsed <see cref="AlcContextAttributes"/> object.</returns>
        internal static ALContextAttributes FromArray(int[] attributeArray)
        {
            List<int> extra = new List<int>();
            ALContextAttributes attributes = new ALContextAttributes();

            void ParseAttribute(int @enum, int value)
            {
                switch (@enum)
                {
                    case (int)AlcContextAttributes.Frequency:
                        attributes.Frequency = value;
                        break;
                    case (int)AlcContextAttributes.MonoSources:
                        attributes.MonoSources = value;
                        break;
                    case (int)AlcContextAttributes.StereoSources:
                        attributes.StereoSources = value;
                        break;
                    case (int)AlcContextAttributes.Refresh:
                        attributes.Refresh = value;
                        break;
                    case (int)AlcContextAttributes.Sync:
                        attributes.Sync = value == 1;
                        break;
                    default:
                        extra.Add(@enum); extra.Add(value);
                        break;
                }
            }

            for (int i = 0; i < attributeArray.Length - 1; i += 2)
            {
                ParseAttribute(attributeArray[i], attributeArray[i + 1]);
            }

            attributes.AdditionalAttributes = extra.ToArray();

            return attributes;
        }

        // Used for ToString.
        private string GetOptionalString<T>(string title, T? value)
            where T : unmanaged
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
            return $"{GetOptionalString(nameof(Frequency), Frequency)}, " +
                $"{GetOptionalString(nameof(MonoSources), MonoSources)}, " +
                $"{GetOptionalString(nameof(StereoSources), StereoSources)}, " +
                $"{GetOptionalString(nameof(Refresh), Refresh)}, " +
                $"{GetOptionalString(nameof(Sync), Sync)}" +
                $"{((AdditionalAttributes != null) ? ", " + string.Join(", ", AdditionalAttributes) : string.Empty)}";
        }
    }
}

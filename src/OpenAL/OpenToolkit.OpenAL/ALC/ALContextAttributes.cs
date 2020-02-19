using System;
using System.Collections.Generic;
using System.Text;

namespace OpenToolkit.Audio.OpenAL
{
    public class ALContextAttributes
    {
        public int? Frequency { get; set; }

        public int? MonoSources { get; set; }

        public int? StereoSources { get; set; }

        public int? Refresh { get; set; }

        public bool? Sync { get; set; }

        public int[] AdditionalAttributes { get; set; }

        public ALContextAttributes()
        {
        }

        public ALContextAttributes(int? frequency, int? monoSources, int? stereoSources, int? refresh, bool? sync)
        {
            Frequency = frequency;
            MonoSources = monoSources;
            StereoSources = stereoSources;
            Refresh = refresh;
            Sync = sync;
        }

        /// <summary>
        /// Converts these context attributes to a <see cref="ALC.CreateContext(ALDevice, Span{int})"/> compatible list.
        /// </summary>
        /// <returns>The attibute list in the form of a span.</returns>
        public int[] CreateAttributeList()
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

            // The last int is a zero
            for (int i = 0; i < attributeArray.Length - 1; i += 2)
            {
                ParseAttribute(attributeArray[i], attributeArray[i + 1]);
            }

            attributes.AdditionalAttributes = extra.ToArray();

            return attributes;
        }

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

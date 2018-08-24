using System;
using System.Linq;
using System.Reflection;

namespace OpenTK.OpenAL.Native.Attributes
{
    /// <summary>
    /// Helper methods for buffer formats.
    /// </summary>
    public static class FormatHelpers
    {
        /// <summary>
        /// Gets the native byte size of the given format.
        /// </summary>
        /// <returns></returns>
        public static int GetFormatSize<TFormat>(TFormat format) where TFormat : struct, Enum
        {
            var enumType = typeof(TFormat);
            var member = enumType.GetMember(format.ToString()).First();

            if (!(member.GetCustomAttribute(typeof(FormatSizeAttribute)) is FormatSizeAttribute sizeAttribute))
            {
                throw new InvalidOperationException("The given buffer format doesn't have a format size set.");
            }

            return sizeAttribute.Size;
        }
    }
}

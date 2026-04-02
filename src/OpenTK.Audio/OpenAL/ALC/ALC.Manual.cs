using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Audio.OpenAL.ALC
{
    public static unsafe partial class ALC
    {
        /// <inheritdoc cref="CreateContext(ALCDevice, int*)"/>
        public static ALCContext CreateContext(ALCDevice device, ALCContextAttributes attributes)
        {
            return CreateContext(device, attributes.CreateAttributeArray());
        }

        /// <inheritdoc cref="GetIntegerv(ALCDevice, GetPNameIV, int, int*)"/>
        public static unsafe int GetInteger(ALCDevice device, GetPNameIV name)
        {
            int value;
            GetIntegerv(device, name, 1, &value);
            return value;
        }

        /// <summary>
        /// Gets and constructs a <see cref="ALCContextAttributes"/> object by calling <see cref="ALC.GetInteger(ALCDevice, GetPNameIV)"/> on current device.
        /// </summary>
        /// <param name="device">The device to get the context attributes from.</param>
        /// <returns>The parsed context attributes.</returns>
        public static ALCContextAttributes GetContextAttributes(ALCDevice device)
        {
            int size = 0;
            ALC.GetInteger(device, GetPNameIV.AttributesSize, 1, ref size);
            int[] attributes = new int[size];
            ALC.GetInteger(device, GetPNameIV.AllAttributes, size, attributes);
            return ALCContextAttributes.FromArray(attributes);
        }

        /// <summary>
        /// Calls <see cref="ALC.GetString_(ALCDevice, StringName)"/> and parses a OpenAL format string list into a list of strings.
        /// </summary>
        /// <remarks>
        /// This is most useful when called with <see cref="StringName.AllDevicesSpecifier"/> to get a list of all devices.
        /// </remarks>
        /// <param name="device">The device to get the string list from.</param>
        /// <param name="name">The string list to receive.</param>
        /// <returns>The string list.</returns>
        public static unsafe List<string> GetStringList(ALCDevice device, StringName name)
        {
            byte* result = ALC.GetString_(device, name);
            return ALStringListToList(result);

            static unsafe List<string> ALStringListToList(byte* alList)
            {
                if (alList == (byte*)0)
                {
                    return [];
                }

                var strings = new List<string>();

                byte* currentPos = alList;
                while (true)
                {
                    var currentString = Marshal.PtrToStringAnsi(new IntPtr(currentPos));
                    if (string.IsNullOrEmpty(currentString))
                    {
                        break;
                    }

                    strings.Add(currentString);
                    currentPos += currentString.Length + 1;
                }

                return strings;
            }
        }
    }
}

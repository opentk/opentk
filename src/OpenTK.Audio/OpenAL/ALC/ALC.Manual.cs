using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Audio.OpenAL.ALC
{
    public static unsafe partial class ALC
    {
        /// <inheritdoc cref="GetIntegerv(ALCDevice, GetPNameIV, int, int*)"/>
        public static unsafe int GetInteger(ALCDevice device, GetPNameIV name)
        {
            int value;
            GetIntegerv(device, name, 1, &value);
            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio.OpenAL
{
    public enum RenderFormat
    {
        /// <summary>
        /// Data type: <see cref="sbyte"/>, Value range: -128...+127.
        /// </summary>
        ByteSOFT = 0x1400,

        /// <summary>
        /// Data type: <see cref="byte"/>, Value range: 0...+255.
        /// </summary>
        UnsignedByteSOFT = 0x1401,

        /// <summary>
        /// Data type: <see cref="short"/>, Value range: -32768...+32767.
        /// </summary>
        ShortSOFT = 0x1402,

        /// <summary>
        /// Data type: <see cref="ushort"/>, Value range: 0...+65535.
        /// </summary>
        UnsignedShortSOFT = 0x1403,

        /// <summary>
        /// Data type: <see cref="int"/>, Value range: -2147483648...+2147483647.
        /// </summary>
        IntSOFT = 0x1404,

        /// <summary>
        /// Data type: <see cref="uint"/>, Value range: 0...+4294967295.
        /// </summary>
        UnsignedIntSOFT = 0x1405,

        /// <summary>
        /// Data type: <see cref="float"/>, Value range: -1.0...+1.0.
        /// </summary>
        FloatSOFT = 0x1406,
    }
}

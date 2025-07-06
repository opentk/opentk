using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio.OpenAL
{
    public enum Channels
    {
        /// <summary>
        /// Sample order: mono.
        /// </summary>
        MonoSOFT = 0x1500,

        /// <summary>
        /// Sample order: front-left, front-right.
        /// </summary>
        StereoSOFT = 0x1501,

        /// <summary>
        /// Sample order: front-left, front-right, rear-left, rear-right.
        /// </summary>
        QuadSOFT = 0x1503,

        /// <summary>
        /// Sample order: front-left, front-right, front-center, lfe, rear-left, rear-right.
        /// </summary>
        _5Point1SOFT = 0x1504,

        /// <summary>
        /// Sample order: front-left, front-right, front-center,  lfe, rear-center, side-left, side-right.
        /// </summary>
        _6Point1SOFT = 0x1505,

        /// <summary>
        /// Sample order: front-left, front-right, front-center, lfe, rear-left, rear-right, side-left, side-right.
        /// </summary>
        _7Point1SOFT = 0x1506,
    }
}

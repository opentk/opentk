using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Audio.OpenAL
{
    public enum BufferLoopPoint
    {
        /// <summary>
        /// <para>
        /// Specifies the two offsets the playing source will use to loop, expressed
        /// in uncompressed samples. This only has an affect when the source it's
        /// attached to is of an AL_STATIC type and its AL_LOOPING attribute is set to
        /// AL_TRUE. The first value specifies the offset the source will loop to when
        /// it reaches the offset specified by the second value.
        /// </para>
        /// <para>
        /// If the source's current position within the buffer is not between the two
        /// offsets, it will not be moved. If the source then reaches the end of the
        /// buffer data, it will progress to an AL_STOPPED state.
        /// </para>
        /// <para>
        /// The offsets must be less than or equal to the number of samples in the
        /// buffer, and the second offset must be greater than the first offset, or an
        /// AL_INVALID_VALUE error is generated. An attempt to change the values while
        /// the buffer is attached or queued to a source will generate an
        /// AL_INVALID_OPERATION error.
        /// </para>
        /// </summary>
        LoopPointsSOFT = 0x2015,
    }
}

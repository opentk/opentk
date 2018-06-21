//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;

namespace OpenTK.Graphics.ES11
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleSync
    {
        /// <summary>
        /// Original was GL_SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001
        /// </summary>
        SyncFlushCommandsBitApple = ((int)0x00000001),

        /// <summary>
        /// Original was GL_SYNC_OBJECT_APPLE = 0x8A53
        /// </summary>
        SyncObjectApple = 0x8a53,

        /// <summary>
        /// Original was GL_MAX_SERVER_WAIT_TIMEOUT_APPLE = 0x9111
        /// </summary>
        MaxServerWaitTimeoutApple = 0x9111,

        /// <summary>
        /// Original was GL_OBJECT_TYPE_APPLE = 0x9112
        /// </summary>
        ObjectTypeApple = 0x9112,

        /// <summary>
        /// Original was GL_SYNC_CONDITION_APPLE = 0x9113
        /// </summary>
        SyncConditionApple = 0x9113,

        /// <summary>
        /// Original was GL_SYNC_STATUS_APPLE = 0x9114
        /// </summary>
        SyncStatusApple = 0x9114,

        /// <summary>
        /// Original was GL_SYNC_FLAGS_APPLE = 0x9115
        /// </summary>
        SyncFlagsApple = 0x9115,

        /// <summary>
        /// Original was GL_SYNC_FENCE_APPLE = 0x9116
        /// </summary>
        SyncFenceApple = 0x9116,

        /// <summary>
        /// Original was GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE = 0x9117
        /// </summary>
        SyncGpuCommandsCompleteApple = 0x9117,

        /// <summary>
        /// Original was GL_UNSIGNALED_APPLE = 0x9118
        /// </summary>
        UnsignaledApple = 0x9118,

        /// <summary>
        /// Original was GL_SIGNALED_APPLE = 0x9119
        /// </summary>
        SignaledApple = 0x9119,

        /// <summary>
        /// Original was GL_ALREADY_SIGNALED_APPLE = 0x911A
        /// </summary>
        AlreadySignaledApple = 0x911a,

        /// <summary>
        /// Original was GL_TIMEOUT_EXPIRED_APPLE = 0x911B
        /// </summary>
        TimeoutExpiredApple = 0x911b,

        /// <summary>
        /// Original was GL_CONDITION_SATISFIED_APPLE = 0x911C
        /// </summary>
        ConditionSatisfiedApple = 0x911c,

        /// <summary>
        /// Original was GL_WAIT_FAILED_APPLE = 0x911D
        /// </summary>
        WaitFailedApple = 0x911d,

        /// <summary>
        /// Original was GL_TIMEOUT_IGNORED_APPLE = 0xFFFFFFFFFFFFFFFF
        /// </summary>
        TimeoutIgnoredApple = unchecked((int)0xffffffffffffffff)
    }
}

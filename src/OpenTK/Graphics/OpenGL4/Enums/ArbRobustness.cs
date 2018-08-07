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

// ReSharper disable InconsistentNaming
#pragma warning disable SA1139 // Use literal suffix notation instead of casting

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbRobustness
    {
        /// <summary>
        /// Original was GL_NO_ERROR = 0x0
        /// </summary>
        NoError = 0x0,

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x4
        /// </summary>
        ContextFlagRobustAccessBitArb = 0x4,

        /// <summary>
        /// Original was GL_LOSE_CONTEXT_ON_RESET_ARB = 0x8252
        /// </summary>
        LoseContextOnResetArb = 0x8252,

        /// <summary>
        /// Original was GL_GUILTY_CONTEXT_RESET_ARB = 0x8253
        /// </summary>
        GuiltyContextResetArb = 0x8253,

        /// <summary>
        /// Original was GL_INNOCENT_CONTEXT_RESET_ARB = 0x8254
        /// </summary>
        InnocentContextResetArb = 0x8254,

        /// <summary>
        /// Original was GL_UNKNOWN_CONTEXT_RESET_ARB = 0x8255
        /// </summary>
        UnknownContextResetArb = 0x8255,

        /// <summary>
        /// Original was GL_RESET_NOTIFICATION_STRATEGY_ARB = 0x8256
        /// </summary>
        ResetNotificationStrategyArb = 0x8256,

        /// <summary>
        /// Original was GL_NO_RESET_NOTIFICATION_ARB = 0x8261
        /// </summary>
        NoResetNotificationArb = 0x8261
    }
}

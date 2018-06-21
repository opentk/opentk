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

namespace OpenTK.Graphics.ES20
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum KhrRobustness
    {
        /// <summary>
        /// Original was GL_NO_ERROR = 0
        /// </summary>
        NoError = 0,

        /// <summary>
        /// Original was GL_CONTEXT_LOST = 0x0507
        /// </summary>
        ContextLost = 0x0507,

        /// <summary>
        /// Original was GL_CONTEXT_LOST_KHR = 0x0507
        /// </summary>
        ContextLostKhr = 0x0507,

        /// <summary>
        /// Original was GL_LOSE_CONTEXT_ON_RESET = 0x8252
        /// </summary>
        LoseContextOnReset = 0x8252,

        /// <summary>
        /// Original was GL_LOSE_CONTEXT_ON_RESET_KHR = 0x8252
        /// </summary>
        LoseContextOnResetKhr = 0x8252,

        /// <summary>
        /// Original was GL_GUILTY_CONTEXT_RESET = 0x8253
        /// </summary>
        GuiltyContextReset = 0x8253,

        /// <summary>
        /// Original was GL_GUILTY_CONTEXT_RESET_KHR = 0x8253
        /// </summary>
        GuiltyContextResetKhr = 0x8253,

        /// <summary>
        /// Original was GL_INNOCENT_CONTEXT_RESET = 0x8254
        /// </summary>
        InnocentContextReset = 0x8254,

        /// <summary>
        /// Original was GL_INNOCENT_CONTEXT_RESET_KHR = 0x8254
        /// </summary>
        InnocentContextResetKhr = 0x8254,

        /// <summary>
        /// Original was GL_UNKNOWN_CONTEXT_RESET = 0x8255
        /// </summary>
        UnknownContextReset = 0x8255,

        /// <summary>
        /// Original was GL_UNKNOWN_CONTEXT_RESET_KHR = 0x8255
        /// </summary>
        UnknownContextResetKhr = 0x8255,

        /// <summary>
        /// Original was GL_RESET_NOTIFICATION_STRATEGY = 0x8256
        /// </summary>
        ResetNotificationStrategy = 0x8256,

        /// <summary>
        /// Original was GL_RESET_NOTIFICATION_STRATEGY_KHR = 0x8256
        /// </summary>
        ResetNotificationStrategyKhr = 0x8256,

        /// <summary>
        /// Original was GL_NO_RESET_NOTIFICATION = 0x8261
        /// </summary>
        NoResetNotification = 0x8261,

        /// <summary>
        /// Original was GL_NO_RESET_NOTIFICATION_KHR = 0x8261
        /// </summary>
        NoResetNotificationKhr = 0x8261,

        /// <summary>
        /// Original was GL_CONTEXT_ROBUST_ACCESS = 0x90F3
        /// </summary>
        ContextRobustAccess = 0x90f3,

        /// <summary>
        /// Original was GL_CONTEXT_ROBUST_ACCESS_KHR = 0x90F3
        /// </summary>
        ContextRobustAccessKhr = 0x90f3
    }
}

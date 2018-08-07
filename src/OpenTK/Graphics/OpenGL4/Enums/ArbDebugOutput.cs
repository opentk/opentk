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
    public enum ArbDebugOutput
    {
        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_SYNCHRONOUS_ARB = 0x8242
        /// </summary>
        DebugOutputSynchronousArb = 0x8242,

        /// <summary>
        /// Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB = 0x8243
        /// </summary>
        DebugNextLoggedMessageLengthArb = 0x8243,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_FUNCTION_ARB = 0x8244
        /// </summary>
        DebugCallbackFunctionArb = 0x8244,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_USER_PARAM_ARB = 0x8245
        /// </summary>
        DebugCallbackUserParamArb = 0x8245,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_API_ARB = 0x8246
        /// </summary>
        DebugSourceApiArb = 0x8246,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM_ARB = 0x8247
        /// </summary>
        DebugSourceWindowSystemArb = 0x8247,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_SHADER_COMPILER_ARB = 0x8248
        /// </summary>
        DebugSourceShaderCompilerArb = 0x8248,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_THIRD_PARTY_ARB = 0x8249
        /// </summary>
        DebugSourceThirdPartyArb = 0x8249,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_APPLICATION_ARB = 0x824A
        /// </summary>
        DebugSourceApplicationArb = 0x824A,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_OTHER_ARB = 0x824B
        /// </summary>
        DebugSourceOtherArb = 0x824B,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_ERROR_ARB = 0x824C
        /// </summary>
        DebugTypeErrorArb = 0x824C,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB = 0x824D
        /// </summary>
        DebugTypeDeprecatedBehaviorArb = 0x824D,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB = 0x824E
        /// </summary>
        DebugTypeUndefinedBehaviorArb = 0x824E,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PORTABILITY_ARB = 0x824F
        /// </summary>
        DebugTypePortabilityArb = 0x824F,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PERFORMANCE_ARB = 0x8250
        /// </summary>
        DebugTypePerformanceArb = 0x8250,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_OTHER_ARB = 0x8251
        /// </summary>
        DebugTypeOtherArb = 0x8251,

        /// <summary>
        /// Original was GL_MAX_DEBUG_MESSAGE_LENGTH_ARB = 0x9143
        /// </summary>
        MaxDebugMessageLengthArb = 0x9143,

        /// <summary>
        /// Original was GL_MAX_DEBUG_LOGGED_MESSAGES_ARB = 0x9144
        /// </summary>
        MaxDebugLoggedMessagesArb = 0x9144,

        /// <summary>
        /// Original was GL_DEBUG_LOGGED_MESSAGES_ARB = 0x9145
        /// </summary>
        DebugLoggedMessagesArb = 0x9145,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_HIGH_ARB = 0x9146
        /// </summary>
        DebugSeverityHighArb = 0x9146,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_MEDIUM_ARB = 0x9147
        /// </summary>
        DebugSeverityMediumArb = 0x9147,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_LOW_ARB = 0x9148
        /// </summary>
        DebugSeverityLowArb = 0x9148
    }
}

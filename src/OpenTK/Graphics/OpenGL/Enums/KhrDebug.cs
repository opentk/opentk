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

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// Used in GL.Khr.GetObjectLabel, GL.Khr.GetPointer
    /// </summary>
    public enum KhrDebug
    {
        /// <summary>
        /// Original was GL_CONTEXT_FLAG_DEBUG_BIT = 0x00000002
        /// </summary>
        ContextFlagDebugBit = ((int)0x00000002),

        /// <summary>
        /// Original was GL_CONTEXT_FLAG_DEBUG_BIT_KHR = 0x00000002
        /// </summary>
        ContextFlagDebugBitKhr = ((int)0x00000002),

        /// <summary>
        /// Original was GL_STACK_OVERFLOW = 0x0503
        /// </summary>
        StackOverflow = 0x0503,

        /// <summary>
        /// Original was GL_STACK_OVERFLOW_KHR = 0x0503
        /// </summary>
        StackOverflowKhr = 0x0503,

        /// <summary>
        /// Original was GL_STACK_UNDERFLOW = 0x0504
        /// </summary>
        StackUnderflow = 0x0504,

        /// <summary>
        /// Original was GL_STACK_UNDERFLOW_KHR = 0x0504
        /// </summary>
        StackUnderflowKhr = 0x0504,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = 0x8074,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_KHR = 0x8074
        /// </summary>
        VertexArrayKhr = 0x8074,

        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242
        /// </summary>
        DebugOutputSynchronous = 0x8242,

        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_SYNCHRONOUS_KHR = 0x8242
        /// </summary>
        DebugOutputSynchronousKhr = 0x8242,

        /// <summary>
        /// Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243
        /// </summary>
        DebugNextLoggedMessageLength = 0x8243,

        /// <summary>
        /// Original was GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_KHR = 0x8243
        /// </summary>
        DebugNextLoggedMessageLengthKhr = 0x8243,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_FUNCTION = 0x8244
        /// </summary>
        DebugCallbackFunction = 0x8244,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_FUNCTION_KHR = 0x8244
        /// </summary>
        DebugCallbackFunctionKhr = 0x8244,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_USER_PARAM = 0x8245
        /// </summary>
        DebugCallbackUserParam = 0x8245,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_USER_PARAM_KHR = 0x8245
        /// </summary>
        DebugCallbackUserParamKhr = 0x8245,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_API = 0x8246
        /// </summary>
        DebugSourceApi = 0x8246,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_API_KHR = 0x8246
        /// </summary>
        DebugSourceApiKhr = 0x8246,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247
        /// </summary>
        DebugSourceWindowSystem = 0x8247,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_WINDOW_SYSTEM_KHR = 0x8247
        /// </summary>
        DebugSourceWindowSystemKhr = 0x8247,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_SHADER_COMPILER = 0x8248
        /// </summary>
        DebugSourceShaderCompiler = 0x8248,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_SHADER_COMPILER_KHR = 0x8248
        /// </summary>
        DebugSourceShaderCompilerKhr = 0x8248,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_THIRD_PARTY = 0x8249
        /// </summary>
        DebugSourceThirdParty = 0x8249,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_THIRD_PARTY_KHR = 0x8249
        /// </summary>
        DebugSourceThirdPartyKhr = 0x8249,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_APPLICATION = 0x824A
        /// </summary>
        DebugSourceApplication = 0x824a,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_APPLICATION_KHR = 0x824A
        /// </summary>
        DebugSourceApplicationKhr = 0x824a,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_OTHER = 0x824B
        /// </summary>
        DebugSourceOther = 0x824b,

        /// <summary>
        /// Original was GL_DEBUG_SOURCE_OTHER_KHR = 0x824B
        /// </summary>
        DebugSourceOtherKhr = 0x824b,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_ERROR = 0x824C
        /// </summary>
        DebugTypeError = 0x824c,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_ERROR_KHR = 0x824C
        /// </summary>
        DebugTypeErrorKhr = 0x824c,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D
        /// </summary>
        DebugTypeDeprecatedBehavior = 0x824d,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_KHR = 0x824D
        /// </summary>
        DebugTypeDeprecatedBehaviorKhr = 0x824d,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E
        /// </summary>
        DebugTypeUndefinedBehavior = 0x824e,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_KHR = 0x824E
        /// </summary>
        DebugTypeUndefinedBehaviorKhr = 0x824e,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PORTABILITY = 0x824F
        /// </summary>
        DebugTypePortability = 0x824f,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PORTABILITY_KHR = 0x824F
        /// </summary>
        DebugTypePortabilityKhr = 0x824f,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PERFORMANCE = 0x8250
        /// </summary>
        DebugTypePerformance = 0x8250,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PERFORMANCE_KHR = 0x8250
        /// </summary>
        DebugTypePerformanceKhr = 0x8250,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_OTHER = 0x8251
        /// </summary>
        DebugTypeOther = 0x8251,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_OTHER_KHR = 0x8251
        /// </summary>
        DebugTypeOtherKhr = 0x8251,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_MARKER = 0x8268
        /// </summary>
        DebugTypeMarker = 0x8268,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_MARKER_KHR = 0x8268
        /// </summary>
        DebugTypeMarkerKhr = 0x8268,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PUSH_GROUP = 0x8269
        /// </summary>
        DebugTypePushGroup = 0x8269,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_PUSH_GROUP_KHR = 0x8269
        /// </summary>
        DebugTypePushGroupKhr = 0x8269,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_POP_GROUP = 0x826A
        /// </summary>
        DebugTypePopGroup = 0x826a,

        /// <summary>
        /// Original was GL_DEBUG_TYPE_POP_GROUP_KHR = 0x826A
        /// </summary>
        DebugTypePopGroupKhr = 0x826a,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_NOTIFICATION = 0x826B
        /// </summary>
        DebugSeverityNotification = 0x826b,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_NOTIFICATION_KHR = 0x826B
        /// </summary>
        DebugSeverityNotificationKhr = 0x826b,

        /// <summary>
        /// Original was GL_MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C
        /// </summary>
        MaxDebugGroupStackDepth = 0x826c,

        /// <summary>
        /// Original was GL_MAX_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826C
        /// </summary>
        MaxDebugGroupStackDepthKhr = 0x826c,

        /// <summary>
        /// Original was GL_DEBUG_GROUP_STACK_DEPTH = 0x826D
        /// </summary>
        DebugGroupStackDepth = 0x826d,

        /// <summary>
        /// Original was GL_DEBUG_GROUP_STACK_DEPTH_KHR = 0x826D
        /// </summary>
        DebugGroupStackDepthKhr = 0x826d,

        /// <summary>
        /// Original was GL_BUFFER = 0x82E0
        /// </summary>
        Buffer = 0x82e0,

        /// <summary>
        /// Original was GL_BUFFER_KHR = 0x82E0
        /// </summary>
        BufferKhr = 0x82e0,

        /// <summary>
        /// Original was GL_SHADER = 0x82E1
        /// </summary>
        Shader = 0x82e1,

        /// <summary>
        /// Original was GL_SHADER_KHR = 0x82E1
        /// </summary>
        ShaderKhr = 0x82e1,

        /// <summary>
        /// Original was GL_PROGRAM = 0x82E2
        /// </summary>
        Program = 0x82e2,

        /// <summary>
        /// Original was GL_PROGRAM_KHR = 0x82E2
        /// </summary>
        ProgramKhr = 0x82e2,

        /// <summary>
        /// Original was GL_QUERY = 0x82E3
        /// </summary>
        Query = 0x82e3,

        /// <summary>
        /// Original was GL_QUERY_KHR = 0x82E3
        /// </summary>
        QueryKhr = 0x82e3,

        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE = 0x82E4
        /// </summary>
        ProgramPipeline = 0x82e4,

        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE_KHR = 0x82E4
        /// </summary>
        ProgramPipelineKhr = 0x82e4,

        /// <summary>
        /// Original was GL_SAMPLER = 0x82E6
        /// </summary>
        Sampler = 0x82e6,

        /// <summary>
        /// Original was GL_SAMPLER_KHR = 0x82E6
        /// </summary>
        SamplerKhr = 0x82e6,

        /// <summary>
        /// Original was GL_DISPLAY_LIST = 0x82E7
        /// </summary>
        DisplayList = 0x82e7,

        /// <summary>
        /// Original was GL_MAX_LABEL_LENGTH = 0x82E8
        /// </summary>
        MaxLabelLength = 0x82e8,

        /// <summary>
        /// Original was GL_MAX_LABEL_LENGTH_KHR = 0x82E8
        /// </summary>
        MaxLabelLengthKhr = 0x82e8,

        /// <summary>
        /// Original was GL_MAX_DEBUG_MESSAGE_LENGTH = 0x9143
        /// </summary>
        MaxDebugMessageLength = 0x9143,

        /// <summary>
        /// Original was GL_MAX_DEBUG_MESSAGE_LENGTH_KHR = 0x9143
        /// </summary>
        MaxDebugMessageLengthKhr = 0x9143,

        /// <summary>
        /// Original was GL_MAX_DEBUG_LOGGED_MESSAGES = 0x9144
        /// </summary>
        MaxDebugLoggedMessages = 0x9144,

        /// <summary>
        /// Original was GL_MAX_DEBUG_LOGGED_MESSAGES_KHR = 0x9144
        /// </summary>
        MaxDebugLoggedMessagesKhr = 0x9144,

        /// <summary>
        /// Original was GL_DEBUG_LOGGED_MESSAGES = 0x9145
        /// </summary>
        DebugLoggedMessages = 0x9145,

        /// <summary>
        /// Original was GL_DEBUG_LOGGED_MESSAGES_KHR = 0x9145
        /// </summary>
        DebugLoggedMessagesKhr = 0x9145,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_HIGH = 0x9146
        /// </summary>
        DebugSeverityHigh = 0x9146,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_HIGH_KHR = 0x9146
        /// </summary>
        DebugSeverityHighKhr = 0x9146,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_MEDIUM = 0x9147
        /// </summary>
        DebugSeverityMedium = 0x9147,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_MEDIUM_KHR = 0x9147
        /// </summary>
        DebugSeverityMediumKhr = 0x9147,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_LOW = 0x9148
        /// </summary>
        DebugSeverityLow = 0x9148,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_LOW_KHR = 0x9148
        /// </summary>
        DebugSeverityLowKhr = 0x9148,

        /// <summary>
        /// Original was GL_DEBUG_OUTPUT = 0x92E0
        /// </summary>
        DebugOutput = 0x92e0,

        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_KHR = 0x92E0
        /// </summary>
        DebugOutputKhr = 0x92e0
    }
}

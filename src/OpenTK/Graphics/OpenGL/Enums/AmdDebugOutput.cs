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
    /// Used in GL.Amd.DebugMessageEnable, GL.Amd.DebugMessageInsert and 1 other function
    /// </summary>
    public enum AmdDebugOutput
    {
        /// <summary>
        /// Original was GL_MAX_DEBUG_MESSAGE_LENGTH_AMD = 0x9143
        /// </summary>
        MaxDebugMessageLengthAmd = 0x9143,

        /// <summary>
        /// Original was GL_MAX_DEBUG_LOGGED_MESSAGES_AMD = 0x9144
        /// </summary>
        MaxDebugLoggedMessagesAmd = 0x9144,

        /// <summary>
        /// Original was GL_DEBUG_LOGGED_MESSAGES_AMD = 0x9145
        /// </summary>
        DebugLoggedMessagesAmd = 0x9145,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_HIGH_AMD = 0x9146
        /// </summary>
        DebugSeverityHighAmd = 0x9146,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_MEDIUM_AMD = 0x9147
        /// </summary>
        DebugSeverityMediumAmd = 0x9147,

        /// <summary>
        /// Original was GL_DEBUG_SEVERITY_LOW_AMD = 0x9148
        /// </summary>
        DebugSeverityLowAmd = 0x9148,

        /// <summary>
        /// Original was GL_DEBUG_CATEGORY_API_ERROR_AMD = 0x9149
        /// </summary>
        DebugCategoryApiErrorAmd = 0x9149,

        /// <summary>
        /// Original was GL_DEBUG_CATEGORY_WINDOW_SYSTEM_AMD = 0x914A
        /// </summary>
        DebugCategoryWindowSystemAmd = 0x914a,

        /// <summary>
        /// Original was GL_DEBUG_CATEGORY_DEPRECATION_AMD = 0x914B
        /// </summary>
        DebugCategoryDeprecationAmd = 0x914b,

        /// <summary>
        /// Original was GL_DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMD = 0x914C
        /// </summary>
        DebugCategoryUndefinedBehaviorAmd = 0x914c,

        /// <summary>
        /// Original was GL_DEBUG_CATEGORY_PERFORMANCE_AMD = 0x914D
        /// </summary>
        DebugCategoryPerformanceAmd = 0x914d,

        /// <summary>
        /// Original was GL_DEBUG_CATEGORY_SHADER_COMPILER_AMD = 0x914E
        /// </summary>
        DebugCategoryShaderCompilerAmd = 0x914e,

        /// <summary>
        /// Original was GL_DEBUG_CATEGORY_APPLICATION_AMD = 0x914F
        /// </summary>
        DebugCategoryApplicationAmd = 0x914f,

        /// <summary>
        /// Original was GL_DEBUG_CATEGORY_OTHER_AMD = 0x9150
        /// </summary>
        DebugCategoryOtherAmd = 0x9150
    }
}

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
    /// Used in GL.EXT.GetObjectLabel and GL.EXT.LabelObject.
    /// </summary>
    public enum ExtDebugLabel
    {
        /// <summary>
        /// Original was GL_SAMPLER = 0x82E6
        /// </summary>
        Sampler = 0x82E6,

        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE_OBJECT_EXT = 0x8A4F
        /// </summary>
        ProgramPipelineObjectExt = 0x8A4F,

        /// <summary>
        /// Original was GL_PROGRAM_OBJECT_EXT = 0x8B40
        /// </summary>
        ProgramObjectExt = 0x8B40,

        /// <summary>
        /// Original was GL_SHADER_OBJECT_EXT = 0x8B48
        /// </summary>
        ShaderObjectExt = 0x8B48,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK = 0x8E22
        /// </summary>
        TransformFeedback = 0x8E22,

        /// <summary>
        /// Original was GL_BUFFER_OBJECT_EXT = 0x9151
        /// </summary>
        BufferObjectExt = 0x9151,

        /// <summary>
        /// Original was GL_QUERY_OBJECT_EXT = 0x9153
        /// </summary>
        QueryObjectExt = 0x9153,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_OBJECT_EXT = 0x9154
        /// </summary>
        VertexArrayObjectExt = 0x9154
    }
}

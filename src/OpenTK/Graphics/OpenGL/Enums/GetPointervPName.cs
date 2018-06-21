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
    /// Used in GL.GetPointer, GL.Ext.GetPointer
    /// </summary>
    public enum GetPointervPName
    {
        /// <summary>
        /// Original was GL_FEEDBACK_BUFFER_POINTER = 0x0DF0
        /// </summary>
        FeedbackBufferPointer = 0x0df0,

        /// <summary>
        /// Original was GL_SELECTION_BUFFER_POINTER = 0x0DF3
        /// </summary>
        SelectionBufferPointer = 0x0df3,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_POINTER = 0x808E
        /// </summary>
        VertexArrayPointer = 0x808e,

        /// <summary>
        /// Original was GL_VERTEX_ARRAY_POINTER_EXT = 0x808E
        /// </summary>
        VertexArrayPointerExt = 0x808e,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_POINTER = 0x808F
        /// </summary>
        NormalArrayPointer = 0x808f,

        /// <summary>
        /// Original was GL_NORMAL_ARRAY_POINTER_EXT = 0x808F
        /// </summary>
        NormalArrayPointerExt = 0x808f,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_POINTER = 0x8090
        /// </summary>
        ColorArrayPointer = 0x8090,

        /// <summary>
        /// Original was GL_COLOR_ARRAY_POINTER_EXT = 0x8090
        /// </summary>
        ColorArrayPointerExt = 0x8090,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_POINTER = 0x8091
        /// </summary>
        IndexArrayPointer = 0x8091,

        /// <summary>
        /// Original was GL_INDEX_ARRAY_POINTER_EXT = 0x8091
        /// </summary>
        IndexArrayPointerExt = 0x8091,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092
        /// </summary>
        TextureCoordArrayPointer = 0x8092,

        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092
        /// </summary>
        TextureCoordArrayPointerExt = 0x8092,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_POINTER = 0x8093
        /// </summary>
        EdgeFlagArrayPointer = 0x8093,

        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY_POINTER_EXT = 0x8093
        /// </summary>
        EdgeFlagArrayPointerExt = 0x8093,

        /// <summary>
        /// Original was GL_INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180
        /// </summary>
        InstrumentBufferPointerSgix = 0x8180,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_FUNCTION = 0x8244
        /// </summary>
        DebugCallbackFunction = 0x8244,

        /// <summary>
        /// Original was GL_DEBUG_CALLBACK_USER_PARAM = 0x8245
        /// </summary>
        DebugCallbackUserParam = 0x8245,

        /// <summary>
        /// Original was GL_FOG_COORD_ARRAY_POINTER = 0x8456
        /// </summary>
        FogCoordArrayPointer = 0x8456,

        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY_POINTER = 0x845D
        /// </summary>
        SecondaryColorArrayPointer = 0x845d
    }
}

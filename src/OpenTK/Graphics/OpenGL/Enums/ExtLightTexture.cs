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
    /// Used in GL.Ext.ApplyTexture, GL.Ext.TextureLight
    /// </summary>
    public enum ExtLightTexture
    {
        /// <summary>
        /// Original was GL_FRAGMENT_MATERIAL_EXT = 0x8349
        /// </summary>
        FragmentMaterialExt = 0x8349,

        /// <summary>
        /// Original was GL_FRAGMENT_NORMAL_EXT = 0x834A
        /// </summary>
        FragmentNormalExt = 0x834a,

        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_EXT = 0x834C
        /// </summary>
        FragmentColorExt = 0x834c,

        /// <summary>
        /// Original was GL_ATTENUATION_EXT = 0x834D
        /// </summary>
        AttenuationExt = 0x834d,

        /// <summary>
        /// Original was GL_SHADOW_ATTENUATION_EXT = 0x834E
        /// </summary>
        ShadowAttenuationExt = 0x834e,

        /// <summary>
        /// Original was GL_TEXTURE_APPLICATION_MODE_EXT = 0x834F
        /// </summary>
        TextureApplicationModeExt = 0x834f,

        /// <summary>
        /// Original was GL_TEXTURE_LIGHT_EXT = 0x8350
        /// </summary>
        TextureLightExt = 0x8350,

        /// <summary>
        /// Original was GL_TEXTURE_MATERIAL_FACE_EXT = 0x8351
        /// </summary>
        TextureMaterialFaceExt = 0x8351,

        /// <summary>
        /// Original was GL_TEXTURE_MATERIAL_PARAMETER_EXT = 0x8352
        /// </summary>
        TextureMaterialParameterExt = 0x8352,

        /// <summary>
        /// Original was GL_FRAGMENT_DEPTH_EXT = 0x8452
        /// </summary>
        FragmentDepthExt = 0x8452
    }
}

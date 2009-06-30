#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
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
#endregion

using System;

namespace OpenTK.Graphics.GLES20
{
    #pragma warning disable 1591

    public enum All
    {
        False = ((int)0),
        Noerror = ((int)0),
        None = ((int)0),
        Zero = ((int)0),
        Points = ((int)0X0000),
        Depthbufferbit = ((int)0X00000100),
        Stencilbufferbit = ((int)0X00000400),
        Colorbufferbit = ((int)0X00004000),
        Lines = ((int)0X0001),
        Lineloop = ((int)0X0002),
        Linestrip = ((int)0X0003),
        Triangles = ((int)0X0004),
        Trianglestrip = ((int)0X0005),
        Trianglefan = ((int)0X0006),
        Never = ((int)0X0200),
        Less = ((int)0X0201),
        Equal = ((int)0X0202),
        Lequal = ((int)0X0203),
        Greater = ((int)0X0204),
        Notequal = ((int)0X0205),
        Gequal = ((int)0X0206),
        Always = ((int)0X0207),
        Srccolor = ((int)0X0300),
        Oneminussrccolor = ((int)0X0301),
        Srcalpha = ((int)0X0302),
        Oneminussrcalpha = ((int)0X0303),
        Dstalpha = ((int)0X0304),
        Oneminusdstalpha = ((int)0X0305),
        Dstcolor = ((int)0X0306),
        Oneminusdstcolor = ((int)0X0307),
        Srcalphasaturate = ((int)0X0308),
        Front = ((int)0X0404),
        Back = ((int)0X0405),
        Frontandback = ((int)0X0408),
        Invalidenum = ((int)0X0500),
        Invalidvalue = ((int)0X0501),
        Invalidoperation = ((int)0X0502),
        Outofmemory = ((int)0X0505),
        Invalidframebufferoperation = ((int)0X0506),
        Cw = ((int)0X0900),
        Ccw = ((int)0X0901),
        Linewidth = ((int)0X0b21),
        Cullface = ((int)0X0b44),
        Cullfacemode = ((int)0X0b45),
        Frontface = ((int)0X0b46),
        Depthrange = ((int)0X0b70),
        Depthtest = ((int)0X0b71),
        Depthwritemask = ((int)0X0b72),
        Depthclearvalue = ((int)0X0b73),
        Depthfunc = ((int)0X0b74),
        Stenciltest = ((int)0X0b90),
        Stencilclearvalue = ((int)0X0b91),
        Stencilfunc = ((int)0X0b92),
        Stencilvaluemask = ((int)0X0b93),
        Stencilfail = ((int)0X0b94),
        Stencilpassdepthfail = ((int)0X0b95),
        Stencilpassdepthpass = ((int)0X0b96),
        Stencilref = ((int)0X0b97),
        Stencilwritemask = ((int)0X0b98),
        Viewport = ((int)0X0ba2),
        Dither = ((int)0X0bd0),
        Blend = ((int)0X0be2),
        Scissorbox = ((int)0X0c10),
        Scissortest = ((int)0X0c11),
        Colorclearvalue = ((int)0X0c22),
        Colorwritemask = ((int)0X0c23),
        Unpackalignment = ((int)0X0cf5),
        Packalignment = ((int)0X0d05),
        Maxtexturesize = ((int)0X0d33),
        Maxviewportdims = ((int)0X0d3a),
        Subpixelbits = ((int)0X0d50),
        Redbits = ((int)0X0d52),
        Greenbits = ((int)0X0d53),
        Bluebits = ((int)0X0d54),
        Alphabits = ((int)0X0d55),
        Depthbits = ((int)0X0d56),
        Stencilbits = ((int)0X0d57),
        Texture2D = ((int)0X0de1),
        Dontcare = ((int)0X1100),
        Fastest = ((int)0X1101),
        Nicest = ((int)0X1102),
        Byte = ((int)0X1400),
        Unsignedbyte = ((int)0X1401),
        Short = ((int)0X1402),
        Unsignedshort = ((int)0X1403),
        Int = ((int)0X1404),
        Unsignedint = ((int)0X1405),
        Float = ((int)0X1406),
        Fixed = ((int)0X140c),
        Invert = ((int)0X150a),
        Texture = ((int)0X1702),
        Stencilindex = ((int)0X1901),
        Depthcomponent = ((int)0X1902),
        Alpha = ((int)0X1906),
        Rgb = ((int)0X1907),
        Rgba = ((int)0X1908),
        Luminance = ((int)0X1909),
        Luminancealpha = ((int)0X190a),
        Keep = ((int)0X1e00),
        Replace = ((int)0X1e01),
        Incr = ((int)0X1e02),
        Decr = ((int)0X1e03),
        Vendor = ((int)0X1f00),
        Renderer = ((int)0X1f01),
        Version = ((int)0X1f02),
        Extensions = ((int)0X1f03),
        Nearest = ((int)0X2600),
        Linear = ((int)0X2601),
        Nearestmipmapnearest = ((int)0X2700),
        Linearmipmapnearest = ((int)0X2701),
        Nearestmipmaplinear = ((int)0X2702),
        Linearmipmaplinear = ((int)0X2703),
        Texturemagfilter = ((int)0X2800),
        Textureminfilter = ((int)0X2801),
        Texturewraps = ((int)0X2802),
        Texturewrapt = ((int)0X2803),
        Repeat = ((int)0X2901),
        Polygonoffsetunits = ((int)0X2a00),
        Constantcolor = ((int)0X8001),
        Oneminusconstantcolor = ((int)0X8002),
        Constantalpha = ((int)0X8003),
        Oneminusconstantalpha = ((int)0X8004),
        Blendcolor = ((int)0X8005),
        Funcadd = ((int)0X8006),
        Blendequation = ((int)0X8009),
        Blendequationrgb = ((int)0X8009),
        Funcsubtract = ((int)0X800a),
        Funcreversesubtract = ((int)0X800b),
        Unsignedshort4444 = ((int)0X8033),
        Unsignedshort5551 = ((int)0X8034),
        Polygonoffsetfill = ((int)0X8037),
        Polygonoffsetfactor = ((int)0X8038),
        Rgba4 = ((int)0X8056),
        Rgb5a1 = ((int)0X8057),
        Texturebinding2D = ((int)0X8069),
        Samplealphatocoverage = ((int)0X809e),
        Samplecoverage = ((int)0X80a0),
        Samplebuffers = ((int)0X80a8),
        Samples = ((int)0X80a9),
        Samplecoveragevalue = ((int)0X80aa),
        Samplecoverageinvert = ((int)0X80ab),
        Blenddstrgb = ((int)0X80c8),
        Blendsrcrgb = ((int)0X80c9),
        Blenddstalpha = ((int)0X80ca),
        Blendsrcalpha = ((int)0X80cb),
        Clamptoedge = ((int)0X812f),
        Generatemipmaphint = ((int)0X8192),
        Depthcomponent16 = ((int)0X81a5),
        Unsignedshort565 = ((int)0X8363),
        Mirroredrepeat = ((int)0X8370),
        Aliasedpointsizerange = ((int)0X846d),
        Aliasedlinewidthrange = ((int)0X846e),
        Texture0 = ((int)0X84c0),
        Texture1 = ((int)0X84c1),
        Texture2 = ((int)0X84c2),
        Texture3 = ((int)0X84c3),
        Texture4 = ((int)0X84c4),
        Texture5 = ((int)0X84c5),
        Texture6 = ((int)0X84c6),
        Texture7 = ((int)0X84c7),
        Texture8 = ((int)0X84c8),
        Texture9 = ((int)0X84c9),
        Texture10 = ((int)0X84ca),
        Texture11 = ((int)0X84cb),
        Texture12 = ((int)0X84cc),
        Texture13 = ((int)0X84cd),
        Texture14 = ((int)0X84ce),
        Texture15 = ((int)0X84cf),
        Texture16 = ((int)0X84d0),
        Texture17 = ((int)0X84d1),
        Texture18 = ((int)0X84d2),
        Texture19 = ((int)0X84d3),
        Texture20 = ((int)0X84d4),
        Texture21 = ((int)0X84d5),
        Texture22 = ((int)0X84d6),
        Texture23 = ((int)0X84d7),
        Texture24 = ((int)0X84d8),
        Texture25 = ((int)0X84d9),
        Texture26 = ((int)0X84da),
        Texture27 = ((int)0X84db),
        Texture28 = ((int)0X84dc),
        Texture29 = ((int)0X84dd),
        Texture30 = ((int)0X84de),
        Texture31 = ((int)0X84df),
        Activetexture = ((int)0X84e0),
        Maxrenderbuffersize = ((int)0X84e8),
        Incrwrap = ((int)0X8507),
        Decrwrap = ((int)0X8508),
        Texturecubemap = ((int)0X8513),
        Texturebindingcubemap = ((int)0X8514),
        Texturecubemappositivex = ((int)0X8515),
        Texturecubemapnegativex = ((int)0X8516),
        Texturecubemappositivey = ((int)0X8517),
        Texturecubemapnegativey = ((int)0X8518),
        Texturecubemappositivez = ((int)0X8519),
        Texturecubemapnegativez = ((int)0X851a),
        Maxcubemaptexturesize = ((int)0X851c),
        Vertexattribarrayenabled = ((int)0X8622),
        Vertexattribarraysize = ((int)0X8623),
        Vertexattribarraystride = ((int)0X8624),
        Vertexattribarraytype = ((int)0X8625),
        Currentvertexattrib = ((int)0X8626),
        Vertexattribarraypointer = ((int)0X8645),
        Numcompressedtextureformats = ((int)0X86a2),
        Compressedtextureformats = ((int)0X86a3),
        Buffersize = ((int)0X8764),
        Bufferusage = ((int)0X8765),
        Stencilbackfunc = ((int)0X8800),
        Stencilbackfail = ((int)0X8801),
        Stencilbackpassdepthfail = ((int)0X8802),
        Stencilbackpassdepthpass = ((int)0X8803),
        Blendequationalpha = ((int)0X883d),
        Maxvertexattribs = ((int)0X8869),
        Vertexattribarraynormalized = ((int)0X886a),
        Maxtextureimageunits = ((int)0X8872),
        Arraybuffer = ((int)0X8892),
        Elementarraybuffer = ((int)0X8893),
        Arraybufferbinding = ((int)0X8894),
        Elementarraybufferbinding = ((int)0X8895),
        Vertexattribarraybufferbinding = ((int)0X889f),
        Streamdraw = ((int)0X88e0),
        Staticdraw = ((int)0X88e4),
        Dynamicdraw = ((int)0X88e8),
        Fragmentshader = ((int)0X8b30),
        Vertexshader = ((int)0X8b31),
        Maxvertextextureimageunits = ((int)0X8b4c),
        Maxcombinedtextureimageunits = ((int)0X8b4d),
        Shadertype = ((int)0X8b4f),
        Floatvec2 = ((int)0X8b50),
        Floatvec3 = ((int)0X8b51),
        Floatvec4 = ((int)0X8b52),
        Intvec2 = ((int)0X8b53),
        Intvec3 = ((int)0X8b54),
        Intvec4 = ((int)0X8b55),
        Bool = ((int)0X8b56),
        Boolvec2 = ((int)0X8b57),
        Boolvec3 = ((int)0X8b58),
        Boolvec4 = ((int)0X8b59),
        Floatmat2 = ((int)0X8b5a),
        Floatmat3 = ((int)0X8b5b),
        Floatmat4 = ((int)0X8b5c),
        Sampler2D = ((int)0X8b5e),
        Samplercube = ((int)0X8b60),
        Deletestatus = ((int)0X8b80),
        Compilestatus = ((int)0X8b81),
        Linkstatus = ((int)0X8b82),
        Validatestatus = ((int)0X8b83),
        Infologlength = ((int)0X8b84),
        Attachedshaders = ((int)0X8b85),
        Activeuniforms = ((int)0X8b86),
        Activeuniformmaxlength = ((int)0X8b87),
        Shadersourcelength = ((int)0X8b88),
        Activeattributes = ((int)0X8b89),
        Activeattributemaxlength = ((int)0X8b8a),
        Shadinglanguageversion = ((int)0X8b8c),
        Currentprogram = ((int)0X8b8d),
        Implementationcolorreadtype = ((int)0X8b9a),
        Implementationcolorreadformat = ((int)0X8b9b),
        Stencilbackref = ((int)0X8ca3),
        Stencilbackvaluemask = ((int)0X8ca4),
        Stencilbackwritemask = ((int)0X8ca5),
        Framebufferbinding = ((int)0X8ca6),
        Renderbufferbinding = ((int)0X8ca7),
        Framebufferattachmentobjecttype = ((int)0X8cd0),
        Framebufferattachmentobjectname = ((int)0X8cd1),
        Framebufferattachmenttexturelevel = ((int)0X8cd2),
        Framebufferattachmenttexturecubemapface = ((int)0X8cd3),
        Framebuffercomplete = ((int)0X8cd5),
        Framebufferincompleteattachment = ((int)0X8cd6),
        Framebufferincompletemissingattachment = ((int)0X8cd7),
        Framebufferincompletedimensions = ((int)0X8cd9),
        Framebufferunsupported = ((int)0X8cdd),
        Colorattachment0 = ((int)0X8ce0),
        Depthattachment = ((int)0X8d00),
        Stencilattachment = ((int)0X8d20),
        Framebuffer = ((int)0X8d40),
        Renderbuffer = ((int)0X8d41),
        Renderbufferwidth = ((int)0X8d42),
        Renderbufferheight = ((int)0X8d43),
        Renderbufferinternalformat = ((int)0X8d44),
        Stencilindex8 = ((int)0X8d48),
        Renderbufferredsize = ((int)0X8d50),
        Renderbuffergreensize = ((int)0X8d51),
        Renderbufferbluesize = ((int)0X8d52),
        Renderbufferalphasize = ((int)0X8d53),
        Renderbufferdepthsize = ((int)0X8d54),
        Renderbufferstencilsize = ((int)0X8d55),
        Rgb565 = ((int)0X8d62),
        Lowfloat = ((int)0X8df0),
        Mediumfloat = ((int)0X8df1),
        Highfloat = ((int)0X8df2),
        Lowint = ((int)0X8df3),
        Mediumint = ((int)0X8df4),
        Highint = ((int)0X8df5),
        Shaderbinaryformats = ((int)0X8df8),
        Numshaderbinaryformats = ((int)0X8df9),
        Shadercompiler = ((int)0X8dfa),
        Maxvertexuniformvectors = ((int)0X8dfb),
        Maxvaryingvectors = ((int)0X8dfc),
        Maxfragmentuniformvectors = ((int)0X8dfd),
        Esversion20 = ((int)1),
        One = ((int)1),
        True = ((int)1),
    }

    public enum BeginMode
    {
        Points = ((int)0X0000),
        Lines = ((int)0X0001),
        Lineloop = ((int)0X0002),
        Linestrip = ((int)0X0003),
        Triangles = ((int)0X0004),
        Trianglestrip = ((int)0X0005),
        Trianglefan = ((int)0X0006),
    }

    public enum BlendEquationSeparate
    {
        Funcadd = ((int)0X8006),
        Blendequation = ((int)0X8009),
        Blendequationrgb = ((int)0X8009),
        Blendequationalpha = ((int)0X883d),
    }

    public enum BlendFunctionSeparate
    {
        Constantcolor = ((int)0X8001),
        Oneminusconstantcolor = ((int)0X8002),
        Constantalpha = ((int)0X8003),
        Oneminusconstantalpha = ((int)0X8004),
        Blendcolor = ((int)0X8005),
        Blenddstrgb = ((int)0X80c8),
        Blendsrcrgb = ((int)0X80c9),
        Blenddstalpha = ((int)0X80ca),
        Blendsrcalpha = ((int)0X80cb),
    }

    public enum BlendingFactorDest
    {
        Zero = ((int)0),
        Srccolor = ((int)0X0300),
        Oneminussrccolor = ((int)0X0301),
        Srcalpha = ((int)0X0302),
        Oneminussrcalpha = ((int)0X0303),
        Dstalpha = ((int)0X0304),
        Oneminusdstalpha = ((int)0X0305),
        One = ((int)1),
    }

    public enum BlendingFactorSrc
    {
        Dstcolor = ((int)0X0306),
        Oneminusdstcolor = ((int)0X0307),
        Srcalphasaturate = ((int)0X0308),
    }

    public enum BlendSubtract
    {
        Funcsubtract = ((int)0X800a),
        Funcreversesubtract = ((int)0X800b),
    }

    public enum Boolean
    {
        False = ((int)0),
        True = ((int)1),
    }

    public enum BufferObjects
    {
        Currentvertexattrib = ((int)0X8626),
        Buffersize = ((int)0X8764),
        Bufferusage = ((int)0X8765),
        Arraybuffer = ((int)0X8892),
        Elementarraybuffer = ((int)0X8893),
        Arraybufferbinding = ((int)0X8894),
        Elementarraybufferbinding = ((int)0X8895),
        Streamdraw = ((int)0X88e0),
        Staticdraw = ((int)0X88e4),
        Dynamicdraw = ((int)0X88e8),
    }

    [Flags]
    public enum ClearBufferMask
    {
        Depthbufferbit = ((int)0X00000100),
        Stencilbufferbit = ((int)0X00000400),
        Colorbufferbit = ((int)0X00004000),
    }

    public enum CullFaceMode
    {
        Front = ((int)0X0404),
        Back = ((int)0X0405),
        Frontandback = ((int)0X0408),
    }

    public enum DataType
    {
        Byte = ((int)0X1400),
        Unsignedbyte = ((int)0X1401),
        Short = ((int)0X1402),
        Unsignedshort = ((int)0X1403),
        Int = ((int)0X1404),
        Unsignedint = ((int)0X1405),
        Float = ((int)0X1406),
        Fixed = ((int)0X140c),
    }

    public enum EnableCap
    {
        Cullface = ((int)0X0b44),
        Depthtest = ((int)0X0b71),
        Stenciltest = ((int)0X0b90),
        Dither = ((int)0X0bd0),
        Blend = ((int)0X0be2),
        Scissortest = ((int)0X0c11),
        Texture2D = ((int)0X0de1),
        Polygonoffsetfill = ((int)0X8037),
        Samplealphatocoverage = ((int)0X809e),
        Samplecoverage = ((int)0X80a0),
    }

    public enum ErrorCode
    {
        Noerror = ((int)0),
        Invalidenum = ((int)0X0500),
        Invalidvalue = ((int)0X0501),
        Invalidoperation = ((int)0X0502),
        Outofmemory = ((int)0X0505),
    }

    public enum FramebufferObject
    {
        None = ((int)0),
        Invalidframebufferoperation = ((int)0X0506),
        Stencilindex = ((int)0X1901),
        Rgba4 = ((int)0X8056),
        Rgb5a1 = ((int)0X8057),
        Depthcomponent16 = ((int)0X81a5),
        Maxrenderbuffersize = ((int)0X84e8),
        Framebufferbinding = ((int)0X8ca6),
        Renderbufferbinding = ((int)0X8ca7),
        Framebufferattachmentobjecttype = ((int)0X8cd0),
        Framebufferattachmentobjectname = ((int)0X8cd1),
        Framebufferattachmenttexturelevel = ((int)0X8cd2),
        Framebufferattachmenttexturecubemapface = ((int)0X8cd3),
        Framebuffercomplete = ((int)0X8cd5),
        Framebufferincompleteattachment = ((int)0X8cd6),
        Framebufferincompletemissingattachment = ((int)0X8cd7),
        Framebufferincompletedimensions = ((int)0X8cd9),
        Framebufferunsupported = ((int)0X8cdd),
        Colorattachment0 = ((int)0X8ce0),
        Depthattachment = ((int)0X8d00),
        Stencilattachment = ((int)0X8d20),
        Framebuffer = ((int)0X8d40),
        Renderbuffer = ((int)0X8d41),
        Renderbufferwidth = ((int)0X8d42),
        Renderbufferheight = ((int)0X8d43),
        Renderbufferinternalformat = ((int)0X8d44),
        Stencilindex8 = ((int)0X8d48),
        Renderbufferredsize = ((int)0X8d50),
        Renderbuffergreensize = ((int)0X8d51),
        Renderbufferbluesize = ((int)0X8d52),
        Renderbufferalphasize = ((int)0X8d53),
        Renderbufferdepthsize = ((int)0X8d54),
        Renderbufferstencilsize = ((int)0X8d55),
        Rgb565 = ((int)0X8d62),
    }

    public enum FrontFaceDirection
    {
        Cw = ((int)0X0900),
        Ccw = ((int)0X0901),
    }

    public enum GetPName
    {
        Linewidth = ((int)0X0b21),
        Cullfacemode = ((int)0X0b45),
        Frontface = ((int)0X0b46),
        Depthrange = ((int)0X0b70),
        Depthwritemask = ((int)0X0b72),
        Depthclearvalue = ((int)0X0b73),
        Depthfunc = ((int)0X0b74),
        Stencilclearvalue = ((int)0X0b91),
        Stencilfunc = ((int)0X0b92),
        Stencilvaluemask = ((int)0X0b93),
        Stencilfail = ((int)0X0b94),
        Stencilpassdepthfail = ((int)0X0b95),
        Stencilpassdepthpass = ((int)0X0b96),
        Stencilref = ((int)0X0b97),
        Stencilwritemask = ((int)0X0b98),
        Viewport = ((int)0X0ba2),
        Scissorbox = ((int)0X0c10),
        Colorclearvalue = ((int)0X0c22),
        Colorwritemask = ((int)0X0c23),
        Unpackalignment = ((int)0X0cf5),
        Packalignment = ((int)0X0d05),
        Maxtexturesize = ((int)0X0d33),
        Maxviewportdims = ((int)0X0d3a),
        Subpixelbits = ((int)0X0d50),
        Redbits = ((int)0X0d52),
        Greenbits = ((int)0X0d53),
        Bluebits = ((int)0X0d54),
        Alphabits = ((int)0X0d55),
        Depthbits = ((int)0X0d56),
        Stencilbits = ((int)0X0d57),
        Polygonoffsetunits = ((int)0X2a00),
        Polygonoffsetfactor = ((int)0X8038),
        Texturebinding2D = ((int)0X8069),
        Samplebuffers = ((int)0X80a8),
        Samples = ((int)0X80a9),
        Samplecoveragevalue = ((int)0X80aa),
        Samplecoverageinvert = ((int)0X80ab),
        Aliasedpointsizerange = ((int)0X846d),
        Aliasedlinewidthrange = ((int)0X846e),
        Stencilbackfunc = ((int)0X8800),
        Stencilbackfail = ((int)0X8801),
        Stencilbackpassdepthfail = ((int)0X8802),
        Stencilbackpassdepthpass = ((int)0X8803),
        Stencilbackref = ((int)0X8ca3),
        Stencilbackvaluemask = ((int)0X8ca4),
        Stencilbackwritemask = ((int)0X8ca5),
    }

    public enum GetTextureParameter
    {
        Numcompressedtextureformats = ((int)0X86a2),
        Compressedtextureformats = ((int)0X86a3),
    }

    public enum HintMode
    {
        Dontcare = ((int)0X1100),
        Fastest = ((int)0X1101),
        Nicest = ((int)0X1102),
    }

    public enum HintTarget
    {
        Generatemipmaphint = ((int)0X8192),
    }

    public enum PixelFormat
    {
        Depthcomponent = ((int)0X1902),
        Alpha = ((int)0X1906),
        Rgb = ((int)0X1907),
        Rgba = ((int)0X1908),
        Luminance = ((int)0X1909),
        Luminancealpha = ((int)0X190a),
    }

    public enum PixelType
    {
        Unsignedshort4444 = ((int)0X8033),
        Unsignedshort5551 = ((int)0X8034),
        Unsignedshort565 = ((int)0X8363),
    }

    public enum ReadFormat
    {
        Implementationcolorreadtype = ((int)0X8b9a),
        Implementationcolorreadformat = ((int)0X8b9b),
    }

    public enum ShaderBinary
    {
        Shaderbinaryformats = ((int)0X8df8),
        Numshaderbinaryformats = ((int)0X8df9),
    }

    public enum ShaderPrecision
    {
        Lowfloat = ((int)0X8df0),
        Mediumfloat = ((int)0X8df1),
        Highfloat = ((int)0X8df2),
        Lowint = ((int)0X8df3),
        Mediumint = ((int)0X8df4),
        Highint = ((int)0X8df5),
    }

    public enum Shaders
    {
        Maxvertexattribs = ((int)0X8869),
        Maxtextureimageunits = ((int)0X8872),
        Fragmentshader = ((int)0X8b30),
        Vertexshader = ((int)0X8b31),
        Maxvertextextureimageunits = ((int)0X8b4c),
        Maxcombinedtextureimageunits = ((int)0X8b4d),
        Shadertype = ((int)0X8b4f),
        Deletestatus = ((int)0X8b80),
        Linkstatus = ((int)0X8b82),
        Validatestatus = ((int)0X8b83),
        Attachedshaders = ((int)0X8b85),
        Activeuniforms = ((int)0X8b86),
        Activeuniformmaxlength = ((int)0X8b87),
        Activeattributes = ((int)0X8b89),
        Activeattributemaxlength = ((int)0X8b8a),
        Shadinglanguageversion = ((int)0X8b8c),
        Currentprogram = ((int)0X8b8d),
        Maxvertexuniformvectors = ((int)0X8dfb),
        Maxvaryingvectors = ((int)0X8dfc),
        Maxfragmentuniformvectors = ((int)0X8dfd),
    }

    public enum ShaderSource
    {
        Compilestatus = ((int)0X8b81),
        Infologlength = ((int)0X8b84),
        Shadersourcelength = ((int)0X8b88),
        Shadercompiler = ((int)0X8dfa),
    }

    public enum StencilFunction
    {
        Never = ((int)0X0200),
        Less = ((int)0X0201),
        Equal = ((int)0X0202),
        Lequal = ((int)0X0203),
        Greater = ((int)0X0204),
        Notequal = ((int)0X0205),
        Gequal = ((int)0X0206),
        Always = ((int)0X0207),
    }

    public enum StencilOp
    {
        Invert = ((int)0X150a),
        Keep = ((int)0X1e00),
        Replace = ((int)0X1e01),
        Incr = ((int)0X1e02),
        Decr = ((int)0X1e03),
        Incrwrap = ((int)0X8507),
        Decrwrap = ((int)0X8508),
    }

    public enum StringName
    {
        Vendor = ((int)0X1f00),
        Renderer = ((int)0X1f01),
        Version = ((int)0X1f02),
        Extensions = ((int)0X1f03),
    }

    public enum TextureMagFilter
    {
        Nearest = ((int)0X2600),
        Linear = ((int)0X2601),
    }

    public enum TextureMinFilter
    {
        Nearestmipmapnearest = ((int)0X2700),
        Linearmipmapnearest = ((int)0X2701),
        Nearestmipmaplinear = ((int)0X2702),
        Linearmipmaplinear = ((int)0X2703),
    }

    public enum TextureParameterName
    {
        Texturemagfilter = ((int)0X2800),
        Textureminfilter = ((int)0X2801),
        Texturewraps = ((int)0X2802),
        Texturewrapt = ((int)0X2803),
    }

    public enum TextureTarget
    {
        Texture = ((int)0X1702),
        Texturecubemap = ((int)0X8513),
        Texturebindingcubemap = ((int)0X8514),
        Texturecubemappositivex = ((int)0X8515),
        Texturecubemapnegativex = ((int)0X8516),
        Texturecubemappositivey = ((int)0X8517),
        Texturecubemapnegativey = ((int)0X8518),
        Texturecubemappositivez = ((int)0X8519),
        Texturecubemapnegativez = ((int)0X851a),
        Maxcubemaptexturesize = ((int)0X851c),
    }

    public enum TextureUnit
    {
        Texture0 = ((int)0X84c0),
        Texture1 = ((int)0X84c1),
        Texture2 = ((int)0X84c2),
        Texture3 = ((int)0X84c3),
        Texture4 = ((int)0X84c4),
        Texture5 = ((int)0X84c5),
        Texture6 = ((int)0X84c6),
        Texture7 = ((int)0X84c7),
        Texture8 = ((int)0X84c8),
        Texture9 = ((int)0X84c9),
        Texture10 = ((int)0X84ca),
        Texture11 = ((int)0X84cb),
        Texture12 = ((int)0X84cc),
        Texture13 = ((int)0X84cd),
        Texture14 = ((int)0X84ce),
        Texture15 = ((int)0X84cf),
        Texture16 = ((int)0X84d0),
        Texture17 = ((int)0X84d1),
        Texture18 = ((int)0X84d2),
        Texture19 = ((int)0X84d3),
        Texture20 = ((int)0X84d4),
        Texture21 = ((int)0X84d5),
        Texture22 = ((int)0X84d6),
        Texture23 = ((int)0X84d7),
        Texture24 = ((int)0X84d8),
        Texture25 = ((int)0X84d9),
        Texture26 = ((int)0X84da),
        Texture27 = ((int)0X84db),
        Texture28 = ((int)0X84dc),
        Texture29 = ((int)0X84dd),
        Texture30 = ((int)0X84de),
        Texture31 = ((int)0X84df),
        Activetexture = ((int)0X84e0),
    }

    public enum TextureWrapMode
    {
        Repeat = ((int)0X2901),
        Clamptoedge = ((int)0X812f),
        Mirroredrepeat = ((int)0X8370),
    }

    public enum UniformTypes
    {
        Floatvec2 = ((int)0X8b50),
        Floatvec3 = ((int)0X8b51),
        Floatvec4 = ((int)0X8b52),
        Intvec2 = ((int)0X8b53),
        Intvec3 = ((int)0X8b54),
        Intvec4 = ((int)0X8b55),
        Bool = ((int)0X8b56),
        Boolvec2 = ((int)0X8b57),
        Boolvec3 = ((int)0X8b58),
        Boolvec4 = ((int)0X8b59),
        Floatmat2 = ((int)0X8b5a),
        Floatmat3 = ((int)0X8b5b),
        Floatmat4 = ((int)0X8b5c),
        Sampler2D = ((int)0X8b5e),
        Samplercube = ((int)0X8b60),
    }

    public enum Version
    {
        Esversion20 = ((int)1),
    }

    public enum VertexArrays
    {
        Vertexattribarrayenabled = ((int)0X8622),
        Vertexattribarraysize = ((int)0X8623),
        Vertexattribarraystride = ((int)0X8624),
        Vertexattribarraytype = ((int)0X8625),
        Vertexattribarraypointer = ((int)0X8645),
        Vertexattribarraynormalized = ((int)0X886a),
        Vertexattribarraybufferbinding = ((int)0X889f),
    }

}

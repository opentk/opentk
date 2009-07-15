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

namespace OpenTK.Graphics.ES20
{
        using System;
        using System.Runtime.InteropServices;
        #pragma warning disable 0649
        #pragma warning disable 3019
        #pragma warning disable 1591

    partial class ES
        {
        internal static partial class Delegates
                {
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveTexture([In, Out] OpenTK.Graphics.ES20.All texture);
            internal static ActiveTexture glActiveTexture;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void AttachShader([In, Out] UInt32 program, [In, Out] UInt32 shader);
            internal static AttachShader glAttachShader;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindAttribLocation([In, Out] UInt32 program, [In, Out] UInt32 index, [In, Out] String name);
            internal static BindAttribLocation glBindAttribLocation;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBuffer([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] UInt32 buffer);
            internal static BindBuffer glBindBuffer;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFramebuffer([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] UInt32 framebuffer);
            internal static BindFramebuffer glBindFramebuffer;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindRenderbuffer([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] UInt32 renderbuffer);
            internal static BindRenderbuffer glBindRenderbuffer;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTexture([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] UInt32 texture);
            internal static BindTexture glBindTexture;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendColor([In, Out] Single red, [In, Out] Single green, [In, Out] Single blue, [In, Out] Single alpha);
            internal static BlendColor glBlendColor;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquation([In, Out] OpenTK.Graphics.ES20.All mode);
            internal static BlendEquation glBlendEquation;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparate([In, Out] OpenTK.Graphics.ES20.All modeRGB, [In, Out] OpenTK.Graphics.ES20.All modeAlpha);
            internal static BlendEquationSeparate glBlendEquationSeparate;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunc([In, Out] OpenTK.Graphics.ES20.All sfactor, [In, Out] OpenTK.Graphics.ES20.All dfactor);
            internal static BlendFunc glBlendFunc;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparate([In, Out] OpenTK.Graphics.ES20.All srcRGB, [In, Out] OpenTK.Graphics.ES20.All dstRGB, [In, Out] OpenTK.Graphics.ES20.All srcAlpha, [In, Out] OpenTK.Graphics.ES20.All dstAlpha);
            internal static BlendFuncSeparate glBlendFuncSeparate;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferData([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] IntPtr size, [In, Out] IntPtr data, [In, Out] OpenTK.Graphics.ES20.All usage);
            internal static BufferData glBufferData;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferSubData([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] IntPtr offset, [In, Out] IntPtr size, [In, Out] IntPtr data);
            internal static BufferSubData glBufferSubData;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.ES20.All CheckFramebufferStatus([In, Out] OpenTK.Graphics.ES20.All target);
            internal static CheckFramebufferStatus glCheckFramebufferStatus;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Clear([In, Out] UInt32 mask);
            internal static Clear glClear;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColor([In, Out] Single red, [In, Out] Single green, [In, Out] Single blue, [In, Out] Single alpha);
            internal static ClearColor glClearColor;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthf([In, Out] Single depth);
            internal static ClearDepthf glClearDepthf;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearStencil([In, Out] Int32 s);
            internal static ClearStencil glClearStencil;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMask([In, Out] bool red, [In, Out] bool green, [In, Out] bool blue, [In, Out] bool alpha);
            internal static ColorMask glColorMask;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompileShader([In, Out] UInt32 shader);
            internal static CompileShader glCompileShader;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage2D([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] Int32 level, [In, Out] OpenTK.Graphics.ES20.All internalformat, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] Int32 border, [In, Out] Int32 imageSize, [In, Out] IntPtr data);
            internal static CompressedTexImage2D glCompressedTexImage2D;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage2D([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] Int32 level, [In, Out] Int32 xoffset, [In, Out] Int32 yoffset, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] OpenTK.Graphics.ES20.All format, [In, Out] Int32 imageSize, [In, Out] IntPtr data);
            internal static CompressedTexSubImage2D glCompressedTexSubImage2D;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage2D([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] Int32 level, [In, Out] OpenTK.Graphics.ES20.All internalformat, [In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage2D([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] Int32 level, [In, Out] Int32 xoffset, [In, Out] Int32 yoffset, [In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateProgram();
            internal static CreateProgram glCreateProgram;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShader([In, Out] OpenTK.Graphics.ES20.All type);
            internal static CreateShader glCreateShader;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void CullFace([In, Out] OpenTK.Graphics.ES20.All mode);
            internal static CullFace glCullFace;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteBuffers([In, Out] Int32 n, [In, Out] UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFramebuffers([In, Out] Int32 n, [In, Out] UInt32* framebuffers);
            internal unsafe static DeleteFramebuffers glDeleteFramebuffers;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteProgram([In, Out] UInt32 program);
            internal static DeleteProgram glDeleteProgram;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteRenderbuffers([In, Out] Int32 n, [In, Out] UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffers glDeleteRenderbuffers;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteShader([In, Out] UInt32 shader);
            internal static DeleteShader glDeleteShader;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTextures([In, Out] Int32 n, [In, Out] UInt32* textures);
            internal unsafe static DeleteTextures glDeleteTextures;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthFunc([In, Out] OpenTK.Graphics.ES20.All func);
            internal static DepthFunc glDepthFunc;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthMask([In, Out] bool flag);
            internal static DepthMask glDepthMask;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangef([In, Out] Single zNear, [In, Out] Single zFar);
            internal static DepthRangef glDepthRangef;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DetachShader([In, Out] UInt32 program, [In, Out] UInt32 shader);
            internal static DetachShader glDetachShader;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Disable([In, Out] OpenTK.Graphics.ES20.All cap);
            internal static Disable glDisable;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVertexAttribArray([In, Out] UInt32 index);
            internal static DisableVertexAttribArray glDisableVertexAttribArray;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArrays([In, Out] OpenTK.Graphics.ES20.All mode, [In, Out] Int32 first, [In, Out] Int32 count);
            internal static DrawArrays glDrawArrays;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElements([In, Out] OpenTK.Graphics.ES20.All mode, [In, Out] Int32 count, [In, Out] OpenTK.Graphics.ES20.All type, [In, Out] IntPtr indices);
            internal static DrawElements glDrawElements;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Enable([In, Out] OpenTK.Graphics.ES20.All cap);
            internal static Enable glEnable;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVertexAttribArray([In, Out] UInt32 index);
            internal static EnableVertexAttribArray glEnableVertexAttribArray;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Finish();
            internal static Finish glFinish;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Flush();
            internal static Flush glFlush;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferRenderbuffer([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All attachment, [In, Out] OpenTK.Graphics.ES20.All renderbuffertarget, [In, Out] UInt32 renderbuffer);
            internal static FramebufferRenderbuffer glFramebufferRenderbuffer;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture2D([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All attachment, [In, Out] OpenTK.Graphics.ES20.All textarget, [In, Out] UInt32 texture, [In, Out] Int32 level);
            internal static FramebufferTexture2D glFramebufferTexture2D;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void FrontFace([In, Out] OpenTK.Graphics.ES20.All mode);
            internal static FrontFace glFrontFace;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenBuffers([In, Out] Int32 n, [In, Out] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GenerateMipmap([In, Out] OpenTK.Graphics.ES20.All target);
            internal static GenerateMipmap glGenerateMipmap;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFramebuffers([In, Out] Int32 n, [In, Out] UInt32* framebuffers);
            internal unsafe static GenFramebuffers glGenFramebuffers;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenRenderbuffers([In, Out] Int32 n, [In, Out] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffers glGenRenderbuffers;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTextures([In, Out] Int32 n, [In, Out] UInt32* textures);
            internal unsafe static GenTextures glGenTextures;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveAttrib([In, Out] UInt32 program, [In, Out] UInt32 index, [In, Out] Int32 bufsize, [In, Out] Int32* length, [In, Out] Int32* size, [In, Out] OpenTK.Graphics.ES20.All* type, [In, Out] String name);
            internal unsafe static GetActiveAttrib glGetActiveAttrib;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniform([In, Out] UInt32 program, [In, Out] UInt32 index, [In, Out] Int32 bufsize, [In, Out] Int32* length, [In, Out] Int32* size, [In, Out] OpenTK.Graphics.ES20.All* type, [In, Out] String name);
            internal unsafe static GetActiveUniform glGetActiveUniform;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetAttachedShaders([In, Out] UInt32 program, [In, Out] Int32 maxcount, [In, Out] Int32* count, [In, Out] UInt32* shaders);
            internal unsafe static GetAttachedShaders glGetAttachedShaders;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetAttribLocation([In, Out] UInt32 program, [In, Out] String name);
            internal static GetAttribLocation glGetAttribLocation;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleanv([In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] bool* @params);
            internal unsafe static GetBooleanv glGetBooleanv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameteriv([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate OpenTK.Graphics.ES20.All GetError();
            internal static GetError glGetError;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFloatv([In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Single* @params);
            internal unsafe static GetFloatv glGetFloatv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFramebufferAttachmentParameteriv([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All attachment, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerv([In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
            internal unsafe static GetIntegerv glGetIntegerv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramInfoLog([In, Out] UInt32 program, [In, Out] Int32 bufsize, [In, Out] Int32* length, [In, Out] String infolog);
            internal unsafe static GetProgramInfoLog glGetProgramInfoLog;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramiv([In, Out] UInt32 program, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
            internal unsafe static GetProgramiv glGetProgramiv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetRenderbufferParameteriv([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
            internal unsafe static GetRenderbufferParameteriv glGetRenderbufferParameteriv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderInfoLog([In, Out] UInt32 shader, [In, Out] Int32 bufsize, [In, Out] Int32* length, [In, Out] String infolog);
            internal unsafe static GetShaderInfoLog glGetShaderInfoLog;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderiv([In, Out] UInt32 shader, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
            internal unsafe static GetShaderiv glGetShaderiv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderPrecisionFormat([In, Out] OpenTK.Graphics.ES20.All shadertype, [In, Out] OpenTK.Graphics.ES20.All precisiontype, [In, Out] Int32* range, [In, Out] Int32* precision);
            internal unsafe static GetShaderPrecisionFormat glGetShaderPrecisionFormat;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderSource([In, Out] UInt32 shader, [In, Out] Int32 bufsize, [In, Out] Int32* length, [Out] System.Text.StringBuilder source);
            internal unsafe static GetShaderSource glGetShaderSource;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr GetString([In, Out] OpenTK.Graphics.ES20.All name);
            internal unsafe static GetString glGetString;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterfv([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameteriv([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformfv([In, Out] UInt32 program, [In, Out] Int32 location, [In, Out] Single* @params);
            internal unsafe static GetUniformfv glGetUniformfv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformiv([In, Out] UInt32 program, [In, Out] Int32 location, [In, Out] Int32* @params);
            internal unsafe static GetUniformiv glGetUniformiv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int GetUniformLocation([In, Out] UInt32 program, [In, Out] String name);
            internal static GetUniformLocation glGetUniformLocation;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfv([In, Out] UInt32 index, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Single* @params);
            internal unsafe static GetVertexAttribfv glGetVertexAttribfv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribiv([In, Out] UInt32 index, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
            internal unsafe static GetVertexAttribiv glGetVertexAttribiv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVertexAttribPointerv([In, Out] UInt32 index, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] IntPtr pointer);
            internal static GetVertexAttribPointerv glGetVertexAttribPointerv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Hint([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All mode);
            internal static Hint glHint;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsBuffer([In, Out] UInt32 buffer);
            internal static IsBuffer glIsBuffer;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsEnabled([In, Out] OpenTK.Graphics.ES20.All cap);
            internal static IsEnabled glIsEnabled;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsFramebuffer([In, Out] UInt32 framebuffer);
            internal static IsFramebuffer glIsFramebuffer;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsProgram([In, Out] UInt32 program);
            internal static IsProgram glIsProgram;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsRenderbuffer([In, Out] UInt32 renderbuffer);
            internal static IsRenderbuffer glIsRenderbuffer;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsShader([In, Out] UInt32 shader);
            internal static IsShader glIsShader;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTexture([In, Out] UInt32 texture);
            internal static IsTexture glIsTexture;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LineWidth([In, Out] Single width);
            internal static LineWidth glLineWidth;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LinkProgram([In, Out] UInt32 program);
            internal static LinkProgram glLinkProgram;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStorei([In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32 param);
            internal static PixelStorei glPixelStorei;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffset([In, Out] Single factor, [In, Out] Single units);
            internal static PolygonOffset glPolygonOffset;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadPixels([In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] OpenTK.Graphics.ES20.All format, [In, Out] OpenTK.Graphics.ES20.All type, [In, Out] IntPtr pixels);
            internal static ReadPixels glReadPixels;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ReleaseShaderCompiler();
            internal static ReleaseShaderCompiler glReleaseShaderCompiler;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorage([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All internalformat, [In, Out] Int32 width, [In, Out] Int32 height);
            internal static RenderbufferStorage glRenderbufferStorage;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoverage([In, Out] Single value, [In, Out] bool invert);
            internal static SampleCoverage glSampleCoverage;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Scissor([In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height);
            internal static Scissor glScissor;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderBinary([In, Out] Int32 n, [In, Out] UInt32* shaders, [In, Out] OpenTK.Graphics.ES20.All binaryformat, [In, Out] IntPtr binary, [In, Out] Int32 length);
            internal unsafe static ShaderBinary glShaderBinary;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderSource([In, Out] UInt32 shader, [In, Out] Int32 count, [In, Out] String[] @string, [In, Out] Int32* length);
            internal unsafe static ShaderSource glShaderSource;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFunc([In, Out] OpenTK.Graphics.ES20.All func, [In, Out] Int32 @ref, [In, Out] UInt32 mask);
            internal static StencilFunc glStencilFunc;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFuncSeparate([In, Out] OpenTK.Graphics.ES20.All face, [In, Out] OpenTK.Graphics.ES20.All func, [In, Out] Int32 @ref, [In, Out] UInt32 mask);
            internal static StencilFuncSeparate glStencilFuncSeparate;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMask([In, Out] UInt32 mask);
            internal static StencilMask glStencilMask;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMaskSeparate([In, Out] OpenTK.Graphics.ES20.All face, [In, Out] UInt32 mask);
            internal static StencilMaskSeparate glStencilMaskSeparate;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOp([In, Out] OpenTK.Graphics.ES20.All fail, [In, Out] OpenTK.Graphics.ES20.All zfail, [In, Out] OpenTK.Graphics.ES20.All zpass);
            internal static StencilOp glStencilOp;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOpSeparate([In, Out] OpenTK.Graphics.ES20.All face, [In, Out] OpenTK.Graphics.ES20.All fail, [In, Out] OpenTK.Graphics.ES20.All zfail, [In, Out] OpenTK.Graphics.ES20.All zpass);
            internal static StencilOpSeparate glStencilOpSeparate;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage2D([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] Int32 level, [In, Out] OpenTK.Graphics.ES20.All internalformat, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] Int32 border, [In, Out] OpenTK.Graphics.ES20.All format, [In, Out] OpenTK.Graphics.ES20.All type, [In, Out] IntPtr pixels);
            internal static TexImage2D glTexImage2D;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameterf([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Single param);
            internal static TexParameterf glTexParameterf;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterfv([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameteri([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32 param);
            internal static TexParameteri glTexParameteri;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameteriv([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage2D([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] Int32 level, [In, Out] Int32 xoffset, [In, Out] Int32 yoffset, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] OpenTK.Graphics.ES20.All format, [In, Out] OpenTK.Graphics.ES20.All type, [In, Out] IntPtr pixels);
            internal static TexSubImage2D glTexSubImage2D;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1f([In, Out] Int32 location, [In, Out] Single x);
            internal static Uniform1f glUniform1f;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1fv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Single* v);
            internal unsafe static Uniform1fv glUniform1fv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1i([In, Out] Int32 location, [In, Out] Int32 x);
            internal static Uniform1i glUniform1i;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1iv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Int32* v);
            internal unsafe static Uniform1iv glUniform1iv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2f([In, Out] Int32 location, [In, Out] Single x, [In, Out] Single y);
            internal static Uniform2f glUniform2f;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2fv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Single* v);
            internal unsafe static Uniform2fv glUniform2fv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2i([In, Out] Int32 location, [In, Out] Int32 x, [In, Out] Int32 y);
            internal static Uniform2i glUniform2i;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2iv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Int32* v);
            internal unsafe static Uniform2iv glUniform2iv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3f([In, Out] Int32 location, [In, Out] Single x, [In, Out] Single y, [In, Out] Single z);
            internal static Uniform3f glUniform3f;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3fv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Single* v);
            internal unsafe static Uniform3fv glUniform3fv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3i([In, Out] Int32 location, [In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 z);
            internal static Uniform3i glUniform3i;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3iv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Int32* v);
            internal unsafe static Uniform3iv glUniform3iv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4f([In, Out] Int32 location, [In, Out] Single x, [In, Out] Single y, [In, Out] Single z, [In, Out] Single w);
            internal static Uniform4f glUniform4f;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4fv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Single* v);
            internal unsafe static Uniform4fv glUniform4fv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4i([In, Out] Int32 location, [In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 z, [In, Out] Int32 w);
            internal static Uniform4i glUniform4i;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4iv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Int32* v);
            internal unsafe static Uniform4iv glUniform4iv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2fv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] bool transpose, [In, Out] Single* value);
            internal unsafe static UniformMatrix2fv glUniformMatrix2fv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3fv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] bool transpose, [In, Out] Single* value);
            internal unsafe static UniformMatrix3fv glUniformMatrix3fv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4fv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] bool transpose, [In, Out] Single* value);
            internal unsafe static UniformMatrix4fv glUniformMatrix4fv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgram([In, Out] UInt32 program);
            internal static UseProgram glUseProgram;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgram([In, Out] UInt32 program);
            internal static ValidateProgram glValidateProgram;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1f([In, Out] UInt32 indx, [In, Out] Single x);
            internal static VertexAttrib1f glVertexAttrib1f;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1fv([In, Out] UInt32 indx, [In, Out] Single* values);
            internal unsafe static VertexAttrib1fv glVertexAttrib1fv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2f([In, Out] UInt32 indx, [In, Out] Single x, [In, Out] Single y);
            internal static VertexAttrib2f glVertexAttrib2f;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2fv([In, Out] UInt32 indx, [In, Out] Single* values);
            internal unsafe static VertexAttrib2fv glVertexAttrib2fv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3f([In, Out] UInt32 indx, [In, Out] Single x, [In, Out] Single y, [In, Out] Single z);
            internal static VertexAttrib3f glVertexAttrib3f;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3fv([In, Out] UInt32 indx, [In, Out] Single* values);
            internal unsafe static VertexAttrib3fv glVertexAttrib3fv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4f([In, Out] UInt32 indx, [In, Out] Single x, [In, Out] Single y, [In, Out] Single z, [In, Out] Single w);
            internal static VertexAttrib4f glVertexAttrib4f;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4fv([In, Out] UInt32 indx, [In, Out] Single* values);
            internal unsafe static VertexAttrib4fv glVertexAttrib4fv;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribPointer([In, Out] UInt32 indx, [In, Out] Int32 size, [In, Out] OpenTK.Graphics.ES20.All type, [In, Out] bool normalized, [In, Out] Int32 stride, [In, Out] IntPtr ptr);
            internal static VertexAttribPointer glVertexAttribPointer;
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Viewport([In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height);
            internal static Viewport glViewport;
                }
        }
}

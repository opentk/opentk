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
        #pragma warning disable 3019
        #pragma warning disable 1591

    partial class ES
        {

        internal static partial class Core
                {

                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glActiveTexture", ExactSpelling = true)]
            internal extern static void ActiveTexture([In, Out] OpenTK.Graphics.ES20.All texture);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glAttachShader", ExactSpelling = true)]
            internal extern static void AttachShader([In, Out] UInt32 program, [In, Out] UInt32 shader);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glBindAttribLocation", ExactSpelling = true)]
            internal extern static void BindAttribLocation([In, Out] UInt32 program, [In, Out] UInt32 index, [In, Out] String name);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glBindBuffer", ExactSpelling = true)]
            internal extern static void BindBuffer([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] UInt32 buffer);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glBindFramebuffer", ExactSpelling = true)]
            internal extern static void BindFramebuffer([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] UInt32 framebuffer);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glBindRenderbuffer", ExactSpelling = true)]
            internal extern static void BindRenderbuffer([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] UInt32 renderbuffer);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glBindTexture", ExactSpelling = true)]
            internal extern static void BindTexture([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] UInt32 texture);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glBlendColor", ExactSpelling = true)]
            internal extern static void BlendColor([In, Out] Single red, [In, Out] Single green, [In, Out] Single blue, [In, Out] Single alpha);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glBlendEquation", ExactSpelling = true)]
            internal extern static void BlendEquation([In, Out] OpenTK.Graphics.ES20.All mode);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glBlendEquationSeparate", ExactSpelling = true)]
            internal extern static void BlendEquationSeparate([In, Out] OpenTK.Graphics.ES20.All modeRGB, [In, Out] OpenTK.Graphics.ES20.All modeAlpha);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
            internal extern static void BlendFunc([In, Out] OpenTK.Graphics.ES20.All sfactor, [In, Out] OpenTK.Graphics.ES20.All dfactor);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glBlendFuncSeparate", ExactSpelling = true)]
            internal extern static void BlendFuncSeparate([In, Out] OpenTK.Graphics.ES20.All srcRGB, [In, Out] OpenTK.Graphics.ES20.All dstRGB, [In, Out] OpenTK.Graphics.ES20.All srcAlpha, [In, Out] OpenTK.Graphics.ES20.All dstAlpha);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glBufferData", ExactSpelling = true)]
            internal extern static void BufferData([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] IntPtr size, [In, Out] IntPtr data, [In, Out] OpenTK.Graphics.ES20.All usage);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glBufferSubData", ExactSpelling = true)]
            internal extern static void BufferSubData([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] IntPtr offset, [In, Out] IntPtr size, [In, Out] IntPtr data);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glCheckFramebufferStatus", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.ES20.All CheckFramebufferStatus([In, Out] OpenTK.Graphics.ES20.All target);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glClear", ExactSpelling = true)]
            internal extern static void Clear([In, Out] UInt32 mask);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glClearColor", ExactSpelling = true)]
            internal extern static void ClearColor([In, Out] Single red, [In, Out] Single green, [In, Out] Single blue, [In, Out] Single alpha);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glClearDepthf", ExactSpelling = true)]
            internal extern static void ClearDepthf([In, Out] Single depth);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
            internal extern static void ClearStencil([In, Out] Int32 s);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glColorMask", ExactSpelling = true)]
            internal extern static void ColorMask([In, Out] bool red, [In, Out] bool green, [In, Out] bool blue, [In, Out] bool alpha);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glCompileShader", ExactSpelling = true)]
            internal extern static void CompileShader([In, Out] UInt32 shader);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexImage2D([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] Int32 level, [In, Out] OpenTK.Graphics.ES20.All internalformat, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] Int32 border, [In, Out] Int32 imageSize, [In, Out] IntPtr data);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage2D([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] Int32 level, [In, Out] Int32 xoffset, [In, Out] Int32 yoffset, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] OpenTK.Graphics.ES20.All format, [In, Out] Int32 imageSize, [In, Out] IntPtr data);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
            internal extern static void CopyTexImage2D([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] Int32 level, [In, Out] OpenTK.Graphics.ES20.All internalformat, [In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] Int32 border);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage2D([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] Int32 level, [In, Out] Int32 xoffset, [In, Out] Int32 yoffset, [In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glCreateProgram", ExactSpelling = true)]
            internal extern static Int32 CreateProgram();
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glCreateShader", ExactSpelling = true)]
            internal extern static Int32 CreateShader([In, Out] OpenTK.Graphics.ES20.All type);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glCullFace", ExactSpelling = true)]
            internal extern static void CullFace([In, Out] OpenTK.Graphics.ES20.All mode);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDeleteBuffers", ExactSpelling = true)]
            internal extern static unsafe void DeleteBuffers([In, Out] Int32 n, [In, Out] UInt32* buffers);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDeleteFramebuffers", ExactSpelling = true)]
            internal extern static unsafe void DeleteFramebuffers([In, Out] Int32 n, [In, Out] UInt32* framebuffers);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDeleteProgram", ExactSpelling = true)]
            internal extern static void DeleteProgram([In, Out] UInt32 program);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDeleteRenderbuffers", ExactSpelling = true)]
            internal extern static unsafe void DeleteRenderbuffers([In, Out] Int32 n, [In, Out] UInt32* renderbuffers);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDeleteShader", ExactSpelling = true)]
            internal extern static void DeleteShader([In, Out] UInt32 shader);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDeleteTextures", ExactSpelling = true)]
            internal extern static unsafe void DeleteTextures([In, Out] Int32 n, [In, Out] UInt32* textures);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDepthFunc", ExactSpelling = true)]
            internal extern static void DepthFunc([In, Out] OpenTK.Graphics.ES20.All func);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
            internal extern static void DepthMask([In, Out] bool flag);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDepthRangef", ExactSpelling = true)]
            internal extern static void DepthRangef([In, Out] Single zNear, [In, Out] Single zFar);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDetachShader", ExactSpelling = true)]
            internal extern static void DetachShader([In, Out] UInt32 program, [In, Out] UInt32 shader);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDisable", ExactSpelling = true)]
            internal extern static void Disable([In, Out] OpenTK.Graphics.ES20.All cap);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDisableVertexAttribArray", ExactSpelling = true)]
            internal extern static void DisableVertexAttribArray([In, Out] UInt32 index);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
            internal extern static void DrawArrays([In, Out] OpenTK.Graphics.ES20.All mode, [In, Out] Int32 first, [In, Out] Int32 count);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
            internal extern static void DrawElements([In, Out] OpenTK.Graphics.ES20.All mode, [In, Out] Int32 count, [In, Out] OpenTK.Graphics.ES20.All type, [In, Out] IntPtr indices);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glEnable", ExactSpelling = true)]
            internal extern static void Enable([In, Out] OpenTK.Graphics.ES20.All cap);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glEnableVertexAttribArray", ExactSpelling = true)]
            internal extern static void EnableVertexAttribArray([In, Out] UInt32 index);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glFinish", ExactSpelling = true)]
            internal extern static void Finish();
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glFlush", ExactSpelling = true)]
            internal extern static void Flush();
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glFramebufferRenderbuffer", ExactSpelling = true)]
            internal extern static void FramebufferRenderbuffer([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All attachment, [In, Out] OpenTK.Graphics.ES20.All renderbuffertarget, [In, Out] UInt32 renderbuffer);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glFramebufferTexture2D", ExactSpelling = true)]
            internal extern static void FramebufferTexture2D([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All attachment, [In, Out] OpenTK.Graphics.ES20.All textarget, [In, Out] UInt32 texture, [In, Out] Int32 level);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
            internal extern static void FrontFace([In, Out] OpenTK.Graphics.ES20.All mode);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGenBuffers", ExactSpelling = true)]
            internal extern static unsafe void GenBuffers([In, Out] Int32 n, [In, Out] UInt32* buffers);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGenerateMipmap", ExactSpelling = true)]
            internal extern static void GenerateMipmap([In, Out] OpenTK.Graphics.ES20.All target);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGenFramebuffers", ExactSpelling = true)]
            internal extern static unsafe void GenFramebuffers([In, Out] Int32 n, [In, Out] UInt32* framebuffers);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGenRenderbuffers", ExactSpelling = true)]
            internal extern static unsafe void GenRenderbuffers([In, Out] Int32 n, [In, Out] UInt32* renderbuffers);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGenTextures", ExactSpelling = true)]
            internal extern static unsafe void GenTextures([In, Out] Int32 n, [In, Out] UInt32* textures);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetActiveAttrib", ExactSpelling = true)]
            internal extern static unsafe void GetActiveAttrib([In, Out] UInt32 program, [In, Out] UInt32 index, [In, Out] Int32 bufsize, [In, Out] Int32* length, [In, Out] Int32* size, [In, Out] OpenTK.Graphics.ES20.All* type, [In, Out] String name);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetActiveUniform", ExactSpelling = true)]
            internal extern static unsafe void GetActiveUniform([In, Out] UInt32 program, [In, Out] UInt32 index, [In, Out] Int32 bufsize, [In, Out] Int32* length, [In, Out] Int32* size, [In, Out] OpenTK.Graphics.ES20.All* type, [In, Out] String name);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetAttachedShaders", ExactSpelling = true)]
            internal extern static unsafe void GetAttachedShaders([In, Out] UInt32 program, [In, Out] Int32 maxcount, [In, Out] Int32* count, [In, Out] UInt32* shaders);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetAttribLocation", ExactSpelling = true)]
            internal extern static int GetAttribLocation([In, Out] UInt32 program, [In, Out] String name);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetBooleanv", ExactSpelling = true)]
            internal extern static unsafe void GetBooleanv([In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] bool* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetBufferParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetBufferParameteriv([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetError", ExactSpelling = true)]
            internal extern static OpenTK.Graphics.ES20.All GetError();
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetFloatv", ExactSpelling = true)]
            internal extern static unsafe void GetFloatv([In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Single* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetFramebufferAttachmentParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetFramebufferAttachmentParameteriv([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All attachment, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
            internal extern static unsafe void GetIntegerv([In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetProgramInfoLog", ExactSpelling = true)]
            internal extern static unsafe void GetProgramInfoLog([In, Out] UInt32 program, [In, Out] Int32 bufsize, [In, Out] Int32* length, [In, Out] String infolog);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetProgramiv", ExactSpelling = true)]
            internal extern static unsafe void GetProgramiv([In, Out] UInt32 program, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetRenderbufferParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetRenderbufferParameteriv([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetShaderInfoLog", ExactSpelling = true)]
            internal extern static unsafe void GetShaderInfoLog([In, Out] UInt32 shader, [In, Out] Int32 bufsize, [In, Out] Int32* length, [In, Out] String infolog);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetShaderiv", ExactSpelling = true)]
            internal extern static unsafe void GetShaderiv([In, Out] UInt32 shader, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetShaderPrecisionFormat", ExactSpelling = true)]
            internal extern static unsafe void GetShaderPrecisionFormat([In, Out] OpenTK.Graphics.ES20.All shadertype, [In, Out] OpenTK.Graphics.ES20.All precisiontype, [In, Out] Int32* range, [In, Out] Int32* precision);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetShaderSource", ExactSpelling = true)]
            internal extern static unsafe void GetShaderSource([In, Out] UInt32 shader, [In, Out] Int32 bufsize, [In, Out] Int32* length, [Out] System.Text.StringBuilder source);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetString", ExactSpelling = true)]
            internal extern static unsafe IntPtr GetString([In, Out] OpenTK.Graphics.ES20.All name);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameterfv([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Single* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameteriv([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetUniformfv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformfv([In, Out] UInt32 program, [In, Out] Int32 location, [In, Out] Single* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetUniformiv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformiv([In, Out] UInt32 program, [In, Out] Int32 location, [In, Out] Int32* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetUniformLocation", ExactSpelling = true)]
            internal extern static int GetUniformLocation([In, Out] UInt32 program, [In, Out] String name);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetVertexAttribfv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribfv([In, Out] UInt32 index, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Single* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetVertexAttribiv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribiv([In, Out] UInt32 index, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glGetVertexAttribPointerv", ExactSpelling = true)]
            internal extern static void GetVertexAttribPointerv([In, Out] UInt32 index, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] IntPtr pointer);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glHint", ExactSpelling = true)]
            internal extern static void Hint([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All mode);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glIsBuffer", ExactSpelling = true)]
            internal extern static bool IsBuffer([In, Out] UInt32 buffer);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glIsEnabled", ExactSpelling = true)]
            internal extern static bool IsEnabled([In, Out] OpenTK.Graphics.ES20.All cap);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glIsFramebuffer", ExactSpelling = true)]
            internal extern static bool IsFramebuffer([In, Out] UInt32 framebuffer);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glIsProgram", ExactSpelling = true)]
            internal extern static bool IsProgram([In, Out] UInt32 program);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glIsRenderbuffer", ExactSpelling = true)]
            internal extern static bool IsRenderbuffer([In, Out] UInt32 renderbuffer);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glIsShader", ExactSpelling = true)]
            internal extern static bool IsShader([In, Out] UInt32 shader);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glIsTexture", ExactSpelling = true)]
            internal extern static bool IsTexture([In, Out] UInt32 texture);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
            internal extern static void LineWidth([In, Out] Single width);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glLinkProgram", ExactSpelling = true)]
            internal extern static void LinkProgram([In, Out] UInt32 program);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
            internal extern static void PixelStorei([In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32 param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glPolygonOffset", ExactSpelling = true)]
            internal extern static void PolygonOffset([In, Out] Single factor, [In, Out] Single units);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
            internal extern static void ReadPixels([In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] OpenTK.Graphics.ES20.All format, [In, Out] OpenTK.Graphics.ES20.All type, [In, Out] IntPtr pixels);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glReleaseShaderCompiler", ExactSpelling = true)]
            internal extern static void ReleaseShaderCompiler();
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glRenderbufferStorage", ExactSpelling = true)]
            internal extern static void RenderbufferStorage([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All internalformat, [In, Out] Int32 width, [In, Out] Int32 height);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glSampleCoverage", ExactSpelling = true)]
            internal extern static void SampleCoverage([In, Out] Single value, [In, Out] bool invert);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glScissor", ExactSpelling = true)]
            internal extern static void Scissor([In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glShaderBinary", ExactSpelling = true)]
            internal extern static unsafe void ShaderBinary([In, Out] Int32 n, [In, Out] UInt32* shaders, [In, Out] OpenTK.Graphics.ES20.All binaryformat, [In, Out] IntPtr binary, [In, Out] Int32 length);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glShaderSource", ExactSpelling = true)]
            internal extern static unsafe void ShaderSource([In, Out] UInt32 shader, [In, Out] Int32 count, [In, Out] String[] @string, [In, Out] Int32* length);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
            internal extern static void StencilFunc([In, Out] OpenTK.Graphics.ES20.All func, [In, Out] Int32 @ref, [In, Out] UInt32 mask);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glStencilFuncSeparate", ExactSpelling = true)]
            internal extern static void StencilFuncSeparate([In, Out] OpenTK.Graphics.ES20.All face, [In, Out] OpenTK.Graphics.ES20.All func, [In, Out] Int32 @ref, [In, Out] UInt32 mask);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
            internal extern static void StencilMask([In, Out] UInt32 mask);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glStencilMaskSeparate", ExactSpelling = true)]
            internal extern static void StencilMaskSeparate([In, Out] OpenTK.Graphics.ES20.All face, [In, Out] UInt32 mask);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
            internal extern static void StencilOp([In, Out] OpenTK.Graphics.ES20.All fail, [In, Out] OpenTK.Graphics.ES20.All zfail, [In, Out] OpenTK.Graphics.ES20.All zpass);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glStencilOpSeparate", ExactSpelling = true)]
            internal extern static void StencilOpSeparate([In, Out] OpenTK.Graphics.ES20.All face, [In, Out] OpenTK.Graphics.ES20.All fail, [In, Out] OpenTK.Graphics.ES20.All zfail, [In, Out] OpenTK.Graphics.ES20.All zpass);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
            internal extern static void TexImage2D([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] Int32 level, [In, Out] OpenTK.Graphics.ES20.All internalformat, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] Int32 border, [In, Out] OpenTK.Graphics.ES20.All format, [In, Out] OpenTK.Graphics.ES20.All type, [In, Out] IntPtr pixels);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
            internal extern static void TexParameterf([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Single param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTexParameterfv", ExactSpelling = true)]
            internal extern static unsafe void TexParameterfv([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Single* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTexParameteri", ExactSpelling = true)]
            internal extern static void TexParameteri([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32 param);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTexParameteriv", ExactSpelling = true)]
            internal extern static unsafe void TexParameteriv([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] OpenTK.Graphics.ES20.All pname, [In, Out] Int32* @params);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
            internal extern static void TexSubImage2D([In, Out] OpenTK.Graphics.ES20.All target, [In, Out] Int32 level, [In, Out] Int32 xoffset, [In, Out] Int32 yoffset, [In, Out] Int32 width, [In, Out] Int32 height, [In, Out] OpenTK.Graphics.ES20.All format, [In, Out] OpenTK.Graphics.ES20.All type, [In, Out] IntPtr pixels);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform1f", ExactSpelling = true)]
            internal extern static void Uniform1f([In, Out] Int32 location, [In, Out] Single x);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform1fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform1fv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Single* v);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform1i", ExactSpelling = true)]
            internal extern static void Uniform1i([In, Out] Int32 location, [In, Out] Int32 x);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform1iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform1iv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Int32* v);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform2f", ExactSpelling = true)]
            internal extern static void Uniform2f([In, Out] Int32 location, [In, Out] Single x, [In, Out] Single y);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform2fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform2fv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Single* v);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform2i", ExactSpelling = true)]
            internal extern static void Uniform2i([In, Out] Int32 location, [In, Out] Int32 x, [In, Out] Int32 y);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform2iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform2iv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Int32* v);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform3f", ExactSpelling = true)]
            internal extern static void Uniform3f([In, Out] Int32 location, [In, Out] Single x, [In, Out] Single y, [In, Out] Single z);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform3fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform3fv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Single* v);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform3i", ExactSpelling = true)]
            internal extern static void Uniform3i([In, Out] Int32 location, [In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 z);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform3iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform3iv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Int32* v);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform4f", ExactSpelling = true)]
            internal extern static void Uniform4f([In, Out] Int32 location, [In, Out] Single x, [In, Out] Single y, [In, Out] Single z, [In, Out] Single w);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform4fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform4fv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Single* v);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform4i", ExactSpelling = true)]
            internal extern static void Uniform4i([In, Out] Int32 location, [In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 z, [In, Out] Int32 w);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniform4iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform4iv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] Int32* v);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniformMatrix2fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2fv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] bool transpose, [In, Out] Single* value);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniformMatrix3fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3fv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] bool transpose, [In, Out] Single* value);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUniformMatrix4fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4fv([In, Out] Int32 location, [In, Out] Int32 count, [In, Out] bool transpose, [In, Out] Single* value);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glUseProgram", ExactSpelling = true)]
            internal extern static void UseProgram([In, Out] UInt32 program);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glValidateProgram", ExactSpelling = true)]
            internal extern static void ValidateProgram([In, Out] UInt32 program);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glVertexAttrib1f", ExactSpelling = true)]
            internal extern static void VertexAttrib1f([In, Out] UInt32 indx, [In, Out] Single x);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glVertexAttrib1fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1fv([In, Out] UInt32 indx, [In, Out] Single* values);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glVertexAttrib2f", ExactSpelling = true)]
            internal extern static void VertexAttrib2f([In, Out] UInt32 indx, [In, Out] Single x, [In, Out] Single y);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glVertexAttrib2fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2fv([In, Out] UInt32 indx, [In, Out] Single* values);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glVertexAttrib3f", ExactSpelling = true)]
            internal extern static void VertexAttrib3f([In, Out] UInt32 indx, [In, Out] Single x, [In, Out] Single y, [In, Out] Single z);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glVertexAttrib3fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3fv([In, Out] UInt32 indx, [In, Out] Single* values);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glVertexAttrib4f", ExactSpelling = true)]
            internal extern static void VertexAttrib4f([In, Out] UInt32 indx, [In, Out] Single x, [In, Out] Single y, [In, Out] Single z, [In, Out] Single w);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glVertexAttrib4fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4fv([In, Out] UInt32 indx, [In, Out] Single* values);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glVertexAttribPointer", ExactSpelling = true)]
            internal extern static void VertexAttribPointer([In, Out] UInt32 indx, [In, Out] Int32 size, [In, Out] OpenTK.Graphics.ES20.All type, [In, Out] bool normalized, [In, Out] Int32 stride, [In, Out] IntPtr ptr);
                        [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(ES.Library, EntryPoint = "glViewport", ExactSpelling = true)]
            internal extern static void Viewport([In, Out] Int32 x, [In, Out] Int32 y, [In, Out] Int32 width, [In, Out] Int32 height);
                }
        }
}

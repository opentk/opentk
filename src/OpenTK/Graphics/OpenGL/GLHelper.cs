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
#if !MINIMAL
using System.Drawing;
#endif
using System.Text;
using System.Runtime.InteropServices;


namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// OpenGL bindings for .NET, implementing the full OpenGL API, including extensions.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This class contains all OpenGL enums and functions defined in the latest OpenGL specification.
    /// The official .spec files can be found at: http://opengl.org/registry/.
    /// </para>
    /// <para> A valid OpenGL context must be created before calling any OpenGL function.</para>
    /// <para>
    /// Use the GL.Load and GL.LoadAll methods to prepare function entry points prior to use. To maintain
    /// cross-platform compatibility, this must be done for both core and extension functions. The GameWindow
    /// and the GLControl class will take care of this automatically.
    /// </para>
    /// <para>
    /// You can use the GL.SupportsExtension method to check whether any given category of extension functions
    /// exists in the current OpenGL context. Keep in mind that different OpenGL contexts may support different
    /// extensions, and under different entry points. Always check if all required extensions are still supported
    /// when changing visuals or pixel formats.
    /// </para>
    /// <para>
    /// You may retrieve the entry point for an OpenGL function using the GL.GetDelegate method.
    /// </para>
    /// </remarks>
    /// <see href="http://opengl.org/registry/"/>
    public sealed partial class GL : GraphicsBindingsBase
    {
        internal const string Library = "opengl32.dll";

        private static readonly object sync_root = new object();

        private static IntPtr[] EntryPoints;
        private static byte[] EntryPointNames;
        private static int[] EntryPointNameOffsets;

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GL()
        {
            _EntryPointsInstance = EntryPoints;
            _EntryPointNamesInstance = EntryPointNames;
            _EntryPointNameOffsetsInstance = EntryPointNameOffsets;
        }

        /// <summary>
        /// Returns a synchronization token unique for the GL class.
        /// </summary>
        protected override object SyncRoot
        {
            get { return sync_root; }
        }

        // Note: Mono 1.9.1 truncates StringBuilder results (for 'out string' parameters).
        // We work around this issue by doubling the StringBuilder capacity.

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Set the RGB values of the current color.
        /// </summary>
        /// <param name="color">The color to set.</param>
        public static void Color3(Color color)
        {
            GL.Color3(color.R, color.G, color.B);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Set the current color.
        /// </summary>
        /// <param name="color">The color to set.</param>
        public static void Color4(Color color)
        {
            GL.Color4(color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Set the RGB values of the current color.
        /// </summary>
        /// <param name="color">The color to set.</param>
        public static void Color3(Vector3 color)
        {
            GL.Color3(color.X, color.Y, color.Z);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Set the current color.
        /// </summary>
        /// <param name="color">The color to set.</param>
        public static void Color4(Vector4 color)
        {
            GL.Color4(color.X, color.Y, color.Z, color.W);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Set the current color.
        /// </summary>
        /// <param name="color">The color to set.</param>
        public static void Color4(Color4 color)
        {
            GL.Color4(color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// [requires: v1.0]
        /// Specify clear values for the color buffers.
        /// </summary>
        /// <param name="color">The color to set as the clear value.</param>
        public static void ClearColor(Color color)
        {
            GL.ClearColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        /// <summary>
        /// [requires: v1.0]
        /// Specify clear values for the color buffers.
        /// </summary>
        /// <param name="color">The color to set as the clear value.</param>
        public static void ClearColor(Color4 color)
        {
            GL.ClearColor(color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// [requires: v1.4 or ARB_imaging|VERSION_1_4]
        /// Set the blend color.
        /// </summary>
        /// <param name="color">The blend color to set.</param>
        public static void BlendColor(Color color)
        {
            GL.BlendColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        /// <summary>
        /// [requires: v1.4 or ARB_imaging|VERSION_1_4]
        /// Set the blend color.
        /// </summary>
        /// <param name="color">The blend color to set.</param>
        public static void BlendColor(Color4 color)
        {
            GL.BlendColor(color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Specify material parameters for the lighting model.
        /// </summary>
        /// <param name="face">
        /// Specifies which face or faces are being updated. Must be one of Front, Back, or FrontAndBack.
        /// </param>
        /// <param name="pname">
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Shininess.
        /// </param>
        /// <param name="params">[length: pname]
        /// Specifies the value that parameter Shininess will be set to.
        /// </param>
        public static void Material(MaterialFace face, MaterialParameter pname, Vector4 @params)
        {
            unsafe { Material(face, pname, (float*)&@params.X); }
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Specify material parameters for the lighting model.
        /// </summary>
        /// <param name="face">
        /// Specifies which face or faces are being updated. Must be one of Front, Back, or FrontAndBack.
        /// </param>
        /// <param name="pname">
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Shininess.
        /// </param>
        /// <param name="params">[length: pname]
        /// Specifies the value that parameter Shininess will be set to.
        /// </param>
        public static void Material(MaterialFace face, MaterialParameter pname, Color4 @params)
        {
            unsafe { GL.Material(face, pname, (float*)&@params); }
        }

        /// <summary>[requires: v1.0][deprecated: v3.2]
        /// Set light source parameters
        /// </summary>
        /// <param name="name">
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form Light , where i ranges from 0 to the value of MaxLights - 1.
        /// </param>
        /// <param name="pname">
        /// Specifies a single-valued light source parameter for light. SpotExponent, SpotCutoff, ConstantAttenuation, LinearAttenuation, and QuadraticAttenuation are accepted.
        /// </param>
        /// <param name="params">[length: pname]
        /// Specifies the value that parameter pname of light source light will be set to.
        /// </param>
        public static void Light(LightName name, LightParameter pname, Vector4 @params)
        {
            unsafe { GL.Light(name, pname, (float*)&@params.X); }
        }

        /// <summary>[requires: v1.0][deprecated: v3.2]
        /// Set light source parameters
        /// </summary>
        /// <param name="name">
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form Light , where i ranges from 0 to the value of MaxLights - 1.
        /// </param>
        /// <param name="pname">
        /// Specifies a single-valued light source parameter for light. SpotExponent, SpotCutoff, ConstantAttenuation, LinearAttenuation, and QuadraticAttenuation are accepted.
        /// </param>
        /// <param name="params">[length: pname]
        /// Specifies the value that parameter pname of light source light will be set to.
        /// </param>
        public static void Light(LightName name, LightParameter pname, Color4 @params)
        {
            unsafe { GL.Light(name, pname, (float*)&@params); }
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Set the current normal vector.
        /// </summary>
        /// <param name="normal">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit vector, (0, 0, 1).
        /// </param>
        public static void Normal3(Vector3 normal)
        {
            GL.Normal3(normal.X, normal.Y, normal.Z);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Specify the raster position for pixel operations.
        /// </summary>
        /// <param name="pos">
        /// Specify the x and y object coordinates (if present) for the raster position.
        /// </param>
        public static void RasterPos2(Vector2 pos)
        {
            GL.RasterPos2(pos.X, pos.Y);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Specify the raster position for pixel operations.
        /// </summary>
        /// <param name="pos">
        /// Specify the x, y, and z object coordinates (if present) for the raster position.
        /// </param>
        public static void RasterPos3(Vector3 pos)
        {
            GL.RasterPos3(pos.X, pos.Y, pos.Z);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Specify the raster position for pixel operations.
        /// </summary>
        /// <param name="pos">
        /// Specify the x, y, z, and w object coordinates (if present) for the raster position.
        /// </param>
        public static void RasterPos4(Vector4 pos)
        {
            GL.RasterPos4(pos.X, pos.Y, pos.Z, pos.W);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Specify a vertex.
        /// </summary>
        /// <param name="v">
        /// Specifies the x and y coordinates of a vertex.
        /// </param>
        public static void Vertex2(Vector2 v)
        {
            GL.Vertex2(v.X, v.Y);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Specify a vertex.
        /// </summary>
        /// <param name="v">
        /// Specifies the x, y and z coordinates of a vertex.
        /// </param>
        public static void Vertex3(Vector3 v)
        {
            GL.Vertex3(v.X, v.Y, v.Z);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Specify a vertex.
        /// </summary>
        /// <param name="v">
        /// Specifies the x, y, z and w coordinates of a vertex.
        /// </param>
        public static void Vertex4(Vector4 v)
        {
            GL.Vertex4(v.X, v.Y, v.Z, v.W);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="v">
        /// Specifies the s and t texture coordinates.
        /// </param>
        public static void TexCoord2(Vector2 v)
        {
            GL.TexCoord2(v.X, v.Y);
        }
        
        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="v">
        /// Specifies the s, t and r texture coordinates.
        /// </param>
        public static void TexCoord3(Vector3 v)
        {
            GL.TexCoord3(v.X, v.Y, v.Z);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="v">
        /// Specifies the s, t, r and q texture coordinates.
        /// </param>
        public static void TexCoord4(Vector4 v)
        {
            GL.TexCoord4(v.X, v.Y, v.Z, v.W);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Multiply the current matrix by a rotation matrix.
        /// </summary>
        /// <param name="angle">
        /// Specifies the angle of rotation, in degrees.
        /// </param>
        /// <param name="axis">
        /// Specifies the axis of rotation.
        /// </param>
        public static void Rotate(Single angle, Vector3 axis)
        {
            GL.Rotate((Single)angle, axis.X, axis.Y, axis.Z);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Multiply the current matrix by a general scaling matrix.
        /// </summary>
        /// <param name="scale">
        /// Specifies scale factors along the x, y, and z axes.
        /// </param>
        public static void Scale(Vector3 scale)
        {
            GL.Scale(scale.X, scale.Y, scale.Z);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Multiply the current matrix by a translation matrix.
        /// </summary>
        /// <param name="trans">
        /// Specifies the x, y, and z coordinates with which to translate.
        /// </param>
        public static void Translate(Vector3 trans)
        {
            GL.Translate(trans.X, trans.Y, trans.Z);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Multiply the current matrix with the specified matrix.
        /// </summary>
        /// <param name="mat">
        /// The matrix to multiply the current one with.
        /// </param>
        public static void MultMatrix(ref Matrix4 mat)
        {
            unsafe
            {
                fixed (Single* m_ptr = &mat.Row0.X)
                {
                    GL.MultMatrix((Single*)m_ptr);
                }
            }
        }

        /// <summary>[requires: v1.0][deprecated: v3.2]
        /// Replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="mat">
        /// The matrix to replace the current one with.
        /// </param>
        public static void LoadMatrix(ref Matrix4 mat)
        {
            unsafe
            {
                fixed (Single* m_ptr = &mat.Row0.X)
                {
                    GL.LoadMatrix((Single*)m_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v1.3][deprecated: v3.2]
        /// Replace the current matrix with the specified row-major ordered matrix.
        /// </summary>
        /// <param name="mat">
        /// The matrix to replace the current one with.
        /// </param>
        public static void LoadTransposeMatrix(ref Matrix4 mat)
        {
            unsafe
            {
                fixed (Single* m_ptr = &mat.Row0.X)
                {
                    GL.LoadTransposeMatrix((Single*)m_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v1.3][deprecated: v3.2]
        /// Multiply the current matrix with the specified row-major ordered matrix
        /// </summary>
        /// <param name="mat">
        /// The matrix to multiply the current one with.
        /// </param>
        public static void MultTransposeMatrix(ref Matrix4 mat)
        {
            unsafe
            {
                fixed (Single* m_ptr = &mat.Row0.X)
                {
                    GL.MultTransposeMatrix((Single*)m_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Set the current normal vector.
        /// </summary>
        /// <param name="normal">
        /// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit vector, (0, 0, 1).
        /// </param>
        public static void Normal3(Vector3d normal)
        {
            GL.Normal3(normal.X, normal.Y, normal.Z);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Specify the raster position for pixel operations.
        /// </summary>
        /// <param name="pos">
        /// Specify the x and y object coordinates (if present) for the raster position.
        /// </param>
        public static void RasterPos2(Vector2d pos)
        {
            GL.RasterPos2(pos.X, pos.Y);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Specify the raster position for pixel operations.
        /// </summary>
        /// <param name="pos">
        /// Specify the x, y and z object coordinates (if present) for the raster position.
        /// </param>
        public static void RasterPos3(Vector3d pos)
        {
            GL.RasterPos3(pos.X, pos.Y, pos.Z);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Specify the raster position for pixel operations.
        /// </summary>
        /// <param name="pos">
        /// Specify the x, y, z and w object coordinates (if present) for the raster position.
        /// </param>
        public static void RasterPos4(Vector4d pos)
        {
            GL.RasterPos4(pos.X, pos.Y, pos.Z, pos.W);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Specify a vertex.
        /// </summary>
        /// <param name="v">
        /// Specifies the x and y coordinates of a vertex.
        /// </param>
        public static void Vertex2(Vector2d v)
        {
            GL.Vertex2(v.X, v.Y);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Specify a vertex.
        /// </summary>
        /// <param name="v">
        /// Specifies the x, y and z coordinates of a vertex.
        /// </param>
        public static void Vertex3(Vector3d v)
        {
            GL.Vertex3(v.X, v.Y, v.Z);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Specify a vertex.
        /// </summary>
        /// <param name="v">
        /// Specifies the x, y, z and w coordinates of a vertex.
        /// </param>
        public static void Vertex4(Vector4d v)
        {
            GL.Vertex4(v.X, v.Y, v.Z, v.W);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="v">
        /// Specifies the s and t texture coordinates.
        /// </param>
        public static void TexCoord2(Vector2d v)
        {
            GL.TexCoord2(v.X, v.Y);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="v">
        /// Specifies the s, t and r texture coordinates.
        /// </param>
        public static void TexCoord3(Vector3d v)
        {
            GL.TexCoord3(v.X, v.Y, v.Z);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="v">
        /// Specifies the s, t, r and q texture coordinates.
        /// </param>
        public static void TexCoord4(Vector4d v)
        {
            GL.TexCoord4(v.X, v.Y, v.Z, v.W);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Multiply the current matrix by a rotation matrix.
        /// </summary>
        /// <param name="angle">
        /// Specifies the angle of rotation, in degrees.
        /// </param>
        /// <param name="axis">
        /// Specifies the axis of rotation.
        /// </param>
        public static void Rotate(double angle, Vector3d axis)
        {
            GL.Rotate((double)angle, axis.X, axis.Y, axis.Z);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Multiply the current matrix by a general scaling matrix.
        /// </summary>
        /// <param name="scale">
        /// Specifies scale factors along the x, y, and z axes.
        /// </param>
        public static void Scale(Vector3d scale)
        {
            GL.Scale(scale.X, scale.Y, scale.Z);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Multiply the current matrix by a translation matrix.
        /// </summary>
        /// <param name="trans">
        /// Specifies the x, y, and z coordinates with which to translate.
        /// </param>
        public static void Translate(Vector3d trans)
        {
            GL.Translate(trans.X, trans.Y, trans.Z);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Multiply the current matrix with the specified matrix.
        /// </summary>
        /// <param name="mat">
        /// The matrix to multiply the current one with.
        /// </param>
        public static void MultMatrix(ref Matrix4d mat)
        {
            unsafe
            {
                fixed (Double* m_ptr = &mat.Row0.X)
                {
                    GL.MultMatrix((Double*)m_ptr);
                }
            }
        }

        /// <summary>[requires: v1.0][deprecated: v3.2]
        /// Replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="mat">
        /// The matrix to replace the current one with.
        /// </param>
        public static void LoadMatrix(ref Matrix4d mat)
        {
            unsafe
            {
                fixed (Double* m_ptr = &mat.Row0.X)
                {
                    GL.LoadMatrix((Double*)m_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v1.3][deprecated: v3.2]
        /// Replace the current matrix with the specified row-major ordered matrix.
        /// </summary>
        /// <param name="mat">
        /// The matrix to replace the current one with.
        /// </param>
        public static void LoadTransposeMatrix(ref Matrix4d mat)
        {
            unsafe
            {
                fixed (Double* m_ptr = &mat.Row0.X)
                {
                    GL.LoadTransposeMatrix((Double*)m_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v1.3][deprecated: v3.2]
        /// Multiply the current matrix with the specified row-major ordered matrix
        /// </summary>
        /// <param name="mat">
        /// The matrix to multiply the current one with.
        /// </param>
        public static void MultTransposeMatrix(ref Matrix4d mat)
        {
            unsafe
            {
                fixed (Double* m_ptr = &mat.Row0.X)
                {
                    GL.MultTransposeMatrix((Double*)m_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        [CLSCompliant(false)]
        public static void Uniform2(int location, ref Vector2 vector)
        {
            GL.Uniform2(location, vector.X, vector.Y);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        [CLSCompliant(false)]
        public static void Uniform3(int location, ref Vector3 vector)
        {
            GL.Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        [CLSCompliant(false)]
        public static void Uniform4(int location, ref Vector4 vector)
        {
            GL.Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform2(int location, Vector2 vector)
        {
            GL.Uniform2(location, vector.X, vector.Y);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform3(int location, Vector3 vector)
        {
            GL.Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Vector4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform4(int location, Vector4 vector)
        {
            GL.Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="OpenTK.Graphics.Color4"/> uniform variable for the current program object.
        /// In shader code, this is represented as a <see cref="Vector4"/>.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="color">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform4(int location, Color4 color)
        {
            GL.Uniform4(location, color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Quaternion"/> uniform variable for the current program object.
        /// In shader code, this is represented as a <see cref="Vector4"/>.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="quaternion">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void Uniform4(int location, Quaternion quaternion)
        {
            GL.Uniform4(location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Matrix2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix2(int location, bool transpose, ref Matrix2 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix2(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix2d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix2(int location, bool transpose, ref Matrix2d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix2(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Matrix2x3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix2x3(int location, bool transpose, ref Matrix2x3 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix2x3(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix2x3d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix2x3(int location, bool transpose, ref Matrix2x3d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix2x3(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.1]
        /// Specify the value of a <see cref="Matrix2x4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix2x4(int location, bool transpose, ref Matrix2x4 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix2x4(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix2x4d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix2x4(int location, bool transpose, ref Matrix2x4d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix2x4(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.1]
        /// Specify the value of a <see cref="Matrix3x2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix3x2(int location, bool transpose, ref Matrix3x2 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix3x2(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix3x2d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix3x2(int location, bool transpose, ref Matrix3x2d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix3x2(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Matrix3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix3(int location, bool transpose, ref Matrix3 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix3(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix3(int location, bool transpose, ref Matrix3d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix3(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.1]
        /// Specify the value of a <see cref="Matrix3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix3x4(int location, bool transpose, ref Matrix3x4 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix3x4(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix3x4d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix3x4(int location, bool transpose, ref Matrix3x4d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix3x4(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.1]
        /// Specify the value of a <see cref="Matrix4x2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix4x2(int location, bool transpose, ref Matrix4x2 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix4x2(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix4x2d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix4x2(int location, bool transpose, ref Matrix4x2d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix4x2(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.1]
        /// Specify the value of a <see cref="Matrix4x3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix4x3(int location, bool transpose, ref Matrix4x3 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix4x3(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix4x3d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix4x3(int location, bool transpose, ref Matrix4x3d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix4x3(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specify the value of a <see cref="Matrix4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix4(int location, bool transpose, ref Matrix4 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix4(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.0 or ARB_gpu_shader_fp64|VERSION_4_0]
        /// Specify the value of a <see cref="Matrix4d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void UniformMatrix4(int location, bool transpose, ref Matrix4d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.UniformMatrix4(location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector2"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        [CLSCompliant(false)]
        public static void ProgramUniform2(int program, int location, ref Vector2 vector)
        {
            GL.ProgramUniform2(program, location, vector.X, vector.Y);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector3"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        [CLSCompliant(false)]
        public static void ProgramUniform3(int program, int location, ref Vector3 vector)
        {
            GL.ProgramUniform3(program, location, vector.X, vector.Y, vector.Z);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector4"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        [CLSCompliant(false)]
        public static void ProgramUniform4(int program, int location, ref Vector4 vector)
        {
            GL.ProgramUniform4(program, location, vector.X, vector.Y, vector.Z, vector.W);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector2"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform2(int program, int location, Vector2 vector)
        {
            GL.ProgramUniform2(program, location, vector.X, vector.Y);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector3"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform3(int program, int location, Vector3 vector)
        {
            GL.ProgramUniform3(program, location, vector.X, vector.Y, vector.Z);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Vector4"/> uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="vector">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform4(int program, int location, Vector4 vector)
        {
            GL.ProgramUniform4(program, location, vector.X, vector.Y, vector.Z, vector.W);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="OpenTK.Graphics.Color4"/> uniform variable for the specified program object.
        /// In shader code, this is represented as a <see cref="Vector4"/>.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="color">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform4(int program, int location, Color4 color)
        {
            GL.ProgramUniform4(program, location, color.R, color.G, color.B, color.A);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Quaternion"/> uniform variable for the specified program object.
        /// In shader code, this is represented as a <see cref="Vector4"/>.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="quaternion">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniform4(int program, int location, Quaternion quaternion)
        {
            GL.ProgramUniform4(program, location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix2(int program, int location, bool transpose, ref Matrix2 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix2(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix2d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix2(int program, int location, bool transpose, ref Matrix2d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix2(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix2x3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix2x3(int program, int location, bool transpose, ref Matrix2x3 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix2x3(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix2x3d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix2x3(int program, int location, bool transpose, ref Matrix2x3d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix2x3(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix2x4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix2x4(int program, int location, bool transpose, ref Matrix2x4 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix2x4(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix2x4d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix2x4(int program, int location, bool transpose, ref Matrix2x4d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix2x4(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix3x2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix3x2(int program, int location, bool transpose, ref Matrix3x2 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix3x2(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix3x2d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix3x2(int program, int location, bool transpose, ref Matrix3x2d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix3x2(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix3(int program, int location, bool transpose, ref Matrix3 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix3(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix3d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix3(int program, int location, bool transpose, ref Matrix3d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix3(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix3x4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix3x4(int program, int location, bool transpose, ref Matrix3x4 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix3x4(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix3x4d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix3x4(int program, int location, bool transpose, ref Matrix3x4d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix3x4(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix4x2"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix4x2(int program, int location, bool transpose, ref Matrix4x2 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix4x2(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix4x2d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix4x2(int program, int location, bool transpose, ref Matrix4x2d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix4x2(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix4x3"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix4x3(int program, int location, bool transpose, ref Matrix4x3 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix4x3(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix4x3d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix4x3(int program, int location, bool transpose, ref Matrix4x3d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix4x3(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix4"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix4(int program, int location, bool transpose, ref Matrix4 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix4(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v4.1 or ARB_separate_shader_objects|VERSION_4_1]
        /// Specify the value of a <see cref="Matrix4d"/> uniform variable for the current program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the handle of the program containing the uniform variable to be modified.
        /// </param>
        /// <param name="location">
        /// Specifies the location of the uniform variable to be modified.
        /// </param>
        /// <param name="transpose">
        /// Whether or not the matrix should be transposed.</param>
        /// <param name="matrix">
        /// Specifies the new vector to be used for the specified uniform variable.
        /// </param>
        public static void ProgramUniformMatrix4(int program, int location, bool transpose, ref Matrix4d matrix)
        {
            unsafe
            {
                fixed (double* matrix_ptr = &matrix.Row0.X)
                {
                    GL.ProgramUniformMatrix4(program, location, 1, transpose, matrix_ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v2.0]
        /// Returns information about an active attribute variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="index">
        /// Specifies the index of the attribute variable to be queried.
        /// </param>
        /// <param name="size">
        /// Returns the size of the attribute variable.
        /// </param>
        /// <param name="type">
        /// Returns the data type of the attribute variable.
        /// </param>
        /// <returns>
        /// The name of the attribute variable.
        /// </returns>
        public static string GetActiveAttrib(int program, int index, out int size, out ActiveAttribType type)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.GetProgramParameterName.ActiveAttributeMaxLength, out length);
            string str;

            GetActiveAttrib(program, index, length == 0 ? 1 : length * 2, out length, out size, out type, out str);
            return str;
        }

        /// <summary>
        /// [requires: v2.0]
        /// Returns information about an active uniform variable for the specified program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the program object to be queried.
        /// </param>
        /// <param name="uniformIndex">
        /// Specifies the index of the uniform variable to be queried.
        /// </param>
        /// <param name="size">[length: 1]
        /// Returns the size of the uniform variable.
        /// </param>
        /// <param name="type">[length: 1]
        /// Returns the data type of the uniform variable.
        /// </param>
        /// <returns>[length: bufSize]
        /// The name of the uniform variable.
        /// </returns>
        public static string GetActiveUniform(int program, int uniformIndex, out int size, out ActiveUniformType type)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.GetProgramParameterName.ActiveUniformMaxLength, out length);

            string str;
            GetActiveUniform(program, uniformIndex, length == 0 ? 1 : length, out length, out size, out type, out str);
            return str;
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Query the name of an active uniform.
        /// </summary>
        /// <param name="program">
        /// Specifies the program containing the active uniform index uniformIndex.
        /// </param>
        /// <param name="uniformIndex">
        /// Specifies the index of the active uniform whose name to query.
        /// </param>
        /// <returns>
        /// The name of the active uniform at uniformIndex within program.
        /// </returns>
        public static string GetActiveUniformName(int program, int uniformIndex)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.GetProgramParameterName.ActiveUniformMaxLength, out length);
            string str;

            GetActiveUniformName(program, uniformIndex, length == 0 ? 1 : length * 2, out length, out str);
            return str;
        }

        /// <summary>
        /// [requires: v3.1 or ARB_uniform_buffer_object|VERSION_3_1]
        /// Retrieve the name of an active uniform block.
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program containing the uniform block.
        /// </param>
        /// <param name="uniformIndex">
        /// Specifies the index of the uniform block within program.
        /// </param>
        /// <returns>
        /// The name of the uniform block at uniformIndex.
        /// </returns>
        public static string GetActiveUniformBlockName(int program, int uniformIndex)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.GetProgramParameterName.ActiveUniformBlockMaxNameLength, out length);
            string str;

            GetActiveUniformBlockName(program, uniformIndex, length == 0 ? 1 : length * 2, out length, out str);
            return str;
        }

        /// <summary>
        /// [requires: v2.0]
        /// Replaces the source code in a shader object.
        /// </summary>
        /// <param name="shader">
        /// Specifies the handle of the shader object whose source code is to be replaced.
        /// </param>
        /// <param name="string">
        /// Specifies a string containing the source code to be loaded into the shader.
        /// </param>
        public static void ShaderSource(Int32 shader, System.String @string)
        {
            unsafe
            {
                int length = @string.Length;
                GL.ShaderSource((UInt32)shader, 1, new string[] { @string }, &length);
            }
        }

        /// <summary>
        /// [requires: v2.0]
        /// Returns the information log for a shader object.
        /// </summary>
        /// <param name="shader">
        /// Specifies the shader object whose information log is to be queried.
        /// </param>
        /// <returns>
        /// The information log.
        /// </returns>
        public static string GetShaderInfoLog(Int32 shader)
        {
            string info;
            GetShaderInfoLog(shader, out info);
            return info;
        }

        /// <summary>
        /// [requires: v2.0]
        /// Returns the information log for a shader object.
        /// </summary>
        /// <param name="shader">
        /// Specifies the shader object whose information log is to be queried.
        /// </param>
        /// <param name="info">[length: bufSize]
        /// Specifies a string that is used to return the information log.
        /// </param>
        public static void GetShaderInfoLog(Int32 shader, out string info)
        {
            unsafe
            {
                int length;
                GL.GetShader(shader, ShaderParameter.InfoLogLength, out length);
                if (length == 0)
                {
                    info = String.Empty;
                    return;
                }
                GL.GetShaderInfoLog((UInt32)shader, length * 2, &length, out info);
            }
        }

        /// <summary>
        /// [requires: v2.0]
        /// Returns the information log for a program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the program object whose information log is to be queried.
        /// </param>
        /// <returns>
        /// The information log.
        /// </returns>
        public static string GetProgramInfoLog(Int32 program)
        {
            string info;
            GetProgramInfoLog(program, out info);
            return info;
        }

        /// <summary>
        /// [requires: v2.0]
        /// Returns the information log for a program object.
        /// </summary>
        /// <param name="program">
        /// Specifies the program object whose information log is to be queried.
        /// </param>
        /// <param name="info">[length: bufSize]
        /// Specifies a string that is used to return the information log.
        /// </param>
        public static void GetProgramInfoLog(Int32 program, out string info)
        {
            unsafe
            {
                int length;
                GL.GetProgram(program, OpenTK.Graphics.OpenGL.GetProgramParameterName.InfoLogLength, out length); if (length == 0)
                {
                    info = String.Empty;
                    return;
                }
                GL.GetProgramInfoLog((UInt32)program, length * 2, &length, out info);
            }
        }

        /// <summary>
        /// Helper function that defines the coordinate origin of the Point Sprite.
        /// </summary>
        /// <param name="param">
        /// A OpenTK.Graphics.OpenGL.GL.PointSpriteCoordOriginParameter token,
        /// denoting the origin of the Point Sprite.
        /// </param>
        public static void PointParameter(PointSpriteCoordOriginParameter param)
        {
            GL.PointParameter(PointParameterName.PointSpriteCoordOrigin, (int)param);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// Specifies the new x and y values to be used for the specified vertex attribute.
        /// </param>
        [CLSCompliant(false)]
        public static void VertexAttrib2(Int32 index, ref Vector2 v)
        {
            GL.VertexAttrib2(index, v.X, v.Y);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// Specifies the new x, y and z values to be used for the specified vertex attribute.
        /// </param>
        [CLSCompliant(false)]
        public static void VertexAttrib3(Int32 index, ref Vector3 v)
        {
            GL.VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// Specifies the new x, y, z and w values to be used for the specified vertex attribute.
        /// </param>
        [CLSCompliant(false)]
        public static void VertexAttrib4(Int32 index, ref Vector4 v)
        {
            GL.VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// Specifies the new x and y values to be used for the specified vertex attribute.
        /// </param>
        public static void VertexAttrib2(Int32 index, Vector2 v)
        {
            GL.VertexAttrib2(index, v.X, v.Y);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// Specifies the new x, y and z values to be used for the specified vertex attribute.
        /// </param>
        public static void VertexAttrib3(Int32 index, Vector3 v)
        {
            GL.VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// Specifies the new x, y, z and w values to be used for the specified vertex attribute.
        /// </param>
        public static void VertexAttrib4(Int32 index, Vector4 v)
        {
            GL.VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        /// <summary>
        /// [requires: v1.3][deprecated: v3.2]
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is 
        /// implementation dependent, but must be at least two. Symbolic constant must be one of Texture, where i 
        /// ranges from 0 to MaxTextureCoords - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// Specifies the s and t texture coordinates for target texture unit.
        /// </param>
        public static void MultiTexCoord2(TextureUnit target, ref Vector2 v)
        {
            GL.MultiTexCoord2(target, v.X, v.Y);
        }

        /// <summary>
        /// [requires: v1.3][deprecated: v3.2]
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is 
        /// implementation dependent, but must be at least two. Symbolic constant must be one of Texture, where i 
        /// ranges from 0 to MaxTextureCoords - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// Specifies the s, t, and r texture coordinates for target texture unit.
        /// </param>
        public static void MultiTexCoord3(TextureUnit target, ref Vector3 v)
        {
            GL.MultiTexCoord3(target, v.X, v.Y, v.Z);
        }

        /// <summary>
        /// [requires: v1.3][deprecated: v3.2]
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is 
        /// implementation dependent, but must be at least two. Symbolic constant must be one of Texture, where i 
        /// ranges from 0 to MaxTextureCoords - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// Specifies the s, t, r, and q texture coordinates for target texture unit.
        /// </param>
        public static void MultiTexCoord4(TextureUnit target, ref Vector4 v)
        {
            GL.MultiTexCoord4(target, v.X, v.Y, v.Z, v.W);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// Specifies the new x and y values to be used for the specified vertex attribute.
        /// </param>
        [CLSCompliant(false)]
        public static void VertexAttrib2(Int32 index, ref Vector2d v)
        {
            GL.VertexAttrib2(index, v.X, v.Y);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// Specifies the new x, y and z values to be used for the specified vertex attribute.
        /// </param>
        [CLSCompliant(false)]
        public static void VertexAttrib3(Int32 index, ref Vector3d v)
        {
            GL.VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// Specifies the new x, y, z and w values to be used for the specified vertex attribute.
        /// </param>
        [CLSCompliant(false)]
        public static void VertexAttrib4(Int32 index, ref Vector4d v)
        {
            GL.VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// Specifies the new x and y values to be used for the specified vertex attribute.
        /// </param>
        public static void VertexAttrib2(Int32 index, Vector2d v)
        {
            GL.VertexAttrib2(index, v.X, v.Y);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// Specifies the new x, y and z values to be used for the specified vertex attribute.
        /// </param>
        public static void VertexAttrib3(Int32 index, Vector3d v)
        {
            GL.VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Specifies the value of a generic vertex attribute.
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="v">
        /// Specifies the new x, y, z and w values to be used for the specified vertex attribute.
        /// </param>
        public static void VertexAttrib4(Int32 index, Vector4d v)
        {
            GL.VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        /// <summary>
        /// [requires: v1.3][deprecated: v3.2]
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is 
        /// implementation dependent, but must be at least two. Symbolic constant must be one of Texture, where i 
        /// ranges from 0 to MaxTextureCoords - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// Specifies the s and t texture coordinates for target texture unit.
        /// </param>
        public static void MultiTexCoord2(TextureUnit target, ref Vector2d v)
        {
            GL.MultiTexCoord2(target, v.X, v.Y);
        }

        /// <summary>
        /// [requires: v1.3][deprecated: v3.2]
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is 
        /// implementation dependent, but must be at least two. Symbolic constant must be one of Texture, where i 
        /// ranges from 0 to MaxTextureCoords - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// Specifies the s, t, and r texture coordinates for target texture unit.
        /// </param>
        public static void MultiTexCoord3(TextureUnit target, ref Vector3d v)
        {
            GL.MultiTexCoord3(target, v.X, v.Y, v.Z);
        }

        /// <summary>
        /// [requires: v1.3][deprecated: v3.2]
        /// Set the current texture coordinates.
        /// </summary>
        /// <param name="target">
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is 
        /// implementation dependent, but must be at least two. Symbolic constant must be one of Texture, where i 
        /// ranges from 0 to MaxTextureCoords - 1, which is an implementation-dependent value.
        /// </param>
        /// <param name="v">
        /// Specifies the s, t, r, and q texture coordinates for target texture unit.
        /// </param>
        public static void MultiTexCoord4(TextureUnit target, ref Vector4d v)
        {
            GL.MultiTexCoord4(target, v.X, v.Y, v.Z, v.W);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Draw a rectangle.
        /// </summary>
        /// <param name="rect">
        /// Specifies the vertices of the rectangle.
        /// </param>
        [CLSCompliant(false)]
        public static void Rect(RectangleF rect)
        {
            GL.Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Draw a rectangle.
        /// </summary>
        /// <param name="rect">
        /// Specifies the vertices of the rectangle.
        /// </param>
        [CLSCompliant(false)]
        public static void Rect(Rectangle rect)
        {
            GL.Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Draw a rectangle.
        /// </summary>
        /// <param name="rect">
        /// Specifies the vertices of the rectangle.
        /// </param>
        [CLSCompliant(false)]
        public static void Rect(ref RectangleF rect)
        {
            GL.Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Draw a rectangle.
        /// </summary>
        /// <param name="rect">
        /// Specifies the vertices of the rectangle.
        /// </param>
        [CLSCompliant(false)]
        public static void Rect(ref Rectangle rect)
        {
            GL.Rect(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

        /// <summary>
        /// [requires: v1.1][deprecated: v3.2]
        /// Define an array of vertex data.
        /// </summary>
        /// <param name="size">
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of each coordinate in the array. Symbolic constants Short, Int, Float, or Double 
        /// are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to 
        /// be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="offset">
        /// Specifies the first coordinate of the first vertex in the array. The initial value is 0.
        /// </param>
        public static void VertexPointer(int size, VertexPointerType type, int stride, int offset)
        {
            VertexPointer(size, type, stride, (IntPtr)offset);
        }

        /// <summary>
        /// [requires: v1.1][deprecated: v3.2]
        /// Define an array of normals.
        /// </summary>
        /// <param name="type">
        /// Specifies the data type of each coordinate in the array. Symbolic constants Byte, Short, Int, Float, and 
        /// Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be 
        /// tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="offset">[length: type,stride]
        /// Specifies the first coordinate of the first normal in the array. The initial value is 0.
        /// </param>
        public static void NormalPointer(NormalPointerType type, int stride, int offset)
        {
            NormalPointer(type, stride, (IntPtr)offset);
        }

        /// <summary>
        /// [requires: v1.1][deprecated: v3.2]
        /// Define an array of color indexes.
        /// </summary>
        /// <param name="type">
        /// Specifies the data type of each color index in the array. Symbolic constants UnsignedByte, Short, Int, 
        /// Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive color indexes. If stride is 0, the color indexes are 
        /// understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="offset">
        /// Specifies the first index in the array. The initial value is 0.
        /// </param>
        public static void IndexPointer(IndexPointerType type, int stride, int offset)
        {
            IndexPointer(type, stride, (IntPtr)offset);
        }

        /// <summary>
        ///[requires: v1.1][deprecated: v3.2]
        /// Define an array of colors.
        /// </summary>
        /// <param name="size">
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, 
        /// UnsignedShort, Int, UnsignedInt, Float, and Double are accepted. The initial value is Float.
        /// </param>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be 
        /// tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="offset">
        /// Specifies the first component of the first color element in the array. The initial value is 0.
        /// </param>
        public static void ColorPointer(int size, ColorPointerType type, int stride, int offset)
        {
            ColorPointer(size, type, stride, (IntPtr)offset);
        }

        /// <summary>
        /// [requires: v1.4][deprecated: v3.2]
        /// Define an array of fog coordinates.
        /// </summary>
        /// <param name="type">
        /// Specifies the data type of each fog coordinate. Symbolic constants Float, or Double are accepted. 
        /// The initial value is Float.
        /// </param>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive fog coordinates. If stride is 0, the array elements are 
        /// understood to be tightly packed. The initial value is 0.
        /// </param>
        /// <param name="offset">
        /// Specifies the first coordinate of the first fog coordinate in the array. The initial value is 0.
        /// </param>
        public static void FogCoordPointer(FogPointerType type, int stride, int offset)
        {
            FogCoordPointer(type, stride, (IntPtr)offset);
        }

        /// <summary>
        /// [requires: v1.1][deprecated: v3.2]
        /// Define an array of edge flags.
        /// </summary>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive edge flags. If stride is 0, the edge flags are understood to
        ///  be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="offset">
        /// Specifies the first edge flag in the array. The initial value is 0.
        /// </param>
        public static void EdgeFlagPointer(int stride, int offset)
        {
            EdgeFlagPointer(stride, (IntPtr)offset);
        }

        /// <summary>
        /// [requires: v1.1][deprecated: v3.2]
        /// Define an array of texture coordinates.
        /// </summary>
        /// <param name="size">
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of each texture coordinate. Symbolic constants Short, Int, Float, or Double are 
        /// accepted. The initial value is Float.
        /// </param>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array 
        /// elements are understood to be tightly packed. The initial value is 0.
        /// </param>
        /// <param name="offset">
        /// Specifies the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </param>
        public static void TexCoordPointer(int size, TexCoordPointerType type, int stride, int offset)
        {
            TexCoordPointer(size, type, stride, (IntPtr)offset);
        }

        /// <summary>
        /// [requires: v2.0]
        /// Define an array of generic vertex attribute data.
        /// </summary>
        /// <param name="index">
        /// Specifies the index of the generic vertex attribute to be modified.
        /// </param>
        /// <param name="size">
        /// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the 
        /// symbolic constant Bgra is accepted by glVertexAttribPointer. The initial value is 4.
        /// </param>
        /// <param name="type">
        /// Specifies the data type of each component in the array. The symbolic constants Byte, UnsignedByte, Short, 
        /// UnsignedShort, Int, and UnsignedInt are accepted by glVertexAttribPointer and glVertexAttribIPointer. 
        /// Additionally HalfFloat, Float, Double, Fixed, Int2101010Rev, UnsignedInt2101010Rev and 
        /// UnsignedInt10F11F11FRev are accepted by glVertexAttribPointer. Double is also accepted by 
        /// glVertexAttribLPointer and is the only token accepted by the type parameter for that function. 
        /// The initial value is Float.
        /// </param>
        /// <param name="normalized">
        /// For glVertexAttribPointer, specifies whether fixed-point data values should be normalized (True) or 
        /// converted directly as fixed-point values (False) when they are accessed.
        /// </param>
        /// <param name="stride">
        /// Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex 
        /// attributes are understood to be tightly packed in the array. The initial value is 0.
        /// </param>
        /// <param name="offset">
        /// Specifies the first component of the first generic vertex attribute in the array in the data store of the 
        /// buffer currently bound to the ArrayBuffer target. The initial value is 0.
        /// </param>
        public static void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, int offset)
        {
            VertexAttribPointer(index, size, type, normalized, stride, (IntPtr)offset);
        }

        /// <summary>
        /// [requires: v1.0]
        /// Gets a series of consequtive float values as a vector.
        /// </summary>
        /// <param name="pname">
        /// The name of the property that holds the values.
        /// </param>
        /// <param name="vector">
        /// The vector which will hold the values.
        /// </param>
        public static void GetFloat(GetPName pname, out Vector2 vector)
        {
            unsafe
            {
                fixed (Vector2* ptr = &vector)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v1.0]
        /// Gets a series of consequtive float values as a vector.
        /// </summary>
        /// <param name="pname">
        /// The name of the property that holds the values.
        /// </param>
        /// <param name="vector">
        /// The vector which will hold the values.
        /// </param>
        public static void GetFloat(GetPName pname, out Vector3 vector)
        {
            unsafe
            {
                fixed (Vector3* ptr = &vector)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v1.0]
        /// Gets a series of consequtive float values as a vector.
        /// </summary>
        /// <param name="pname">
        /// The name of the property that holds the values.
        /// </param>
        /// <param name="vector">
        /// The vector which will hold the values.
        /// </param>
        public static void GetFloat(GetPName pname, out Vector4 vector)
        {
            unsafe
            {
                fixed (Vector4* ptr = &vector)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v1.0]
        /// Gets a series of consequtive float values as a matrix.
        /// </summary>
        /// <param name="pname">
        /// The name of the property that holds the values.
        /// </param>
        /// <param name="matrix">
        /// The matrix which will hold the values.
        /// </param>
        public static void GetFloat(GetPName pname, out Matrix4 matrix)
        {
            unsafe
            {
                fixed (Matrix4* ptr = &matrix)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v1.0]
        /// Gets a series of consequtive 64-bit float values as a vector.
        /// </summary>
        /// <param name="pname">
        /// The name of the property that holds the values.
        /// </param>
        /// <param name="vector">
        /// The vector which will hold the values.
        /// </param>
        public static void GetDouble(GetPName pname, out Vector2d vector)
        {
            unsafe
            {
                fixed (Vector2d* ptr = &vector)
                {
                    GetDouble(pname, (double*)ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v1.0]
        /// Gets a series of consequtive 64-bit float values as a vector.
        /// </summary>
        /// <param name="pname">
        /// The name of the property that holds the values.
        /// </param>
        /// <param name="vector">
        /// The vector which will hold the values.
        /// </param>
        public static void GetDouble(GetPName pname, out Vector3d vector)
        {
            unsafe
            {
                fixed (Vector3d* ptr = &vector)
                {
                    GetDouble(pname, (double*)ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v1.0]
        /// Gets a series of consequtive 64-bit float values as a vector.
        /// </summary>
        /// <param name="pname">
        /// The name of the property that holds the values.
        /// </param>
        /// <param name="vector">
        /// The vector which will hold the values.
        /// </param>
        public static void GetDouble(GetPName pname, out Vector4d vector)
        {
            unsafe
            {
                fixed (Vector4d* ptr = &vector)
                {
                    GetDouble(pname, (double*)ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v1.0]
        /// Gets a series of consequtive 64-bit float values as a matrix.
        /// </summary>
        /// <param name="pname">
        /// The name of the property that holds the values.
        /// </param>
        /// <param name="matrix">
        /// The matrix which will hold the values.
        /// </param>
        public static void GetDouble(GetPName pname, out Matrix4d matrix)
        {
            unsafe
            {
                fixed (Matrix4d* ptr = &matrix)
                {
                    GetDouble(pname, (double*)ptr);
                }
            }
        }

        /// <summary>
        /// [requires: v1.0]
        /// Set the viewport. This function assumes a lower left corner of (0, 0).
        /// </summary>
        /// <param name="size">
        /// Specifies the width and height of the viewport. When a GL context is first attached to a window, 
        /// width and height are set to the dimensions of that window.
        /// </param>
        public static void Viewport(Size size)
        {
            GL.Viewport(0, 0, size.Width, size.Height);
        }

        /// <summary>
        /// [requires: v1.0]
        /// Set the viewport.
        /// </summary>
        /// <param name="location">
        /// Specifies the lower left corner of the viewport.
        /// </param>
        /// <param name="size">
        /// Specifies the width and height of the viewport. When a GL context is first attached to a window, 
        /// width and height are set to the dimensions of that window.
        /// </param>
        public static void Viewport(Point location, Size size)
        {
            GL.Viewport(location.X, location.Y, size.Width, size.Height);
        }

        /// <summary>
        /// [requires: v1.0]
        /// Set the viewport.
        /// </summary>
        /// <param name="rectangle">
        /// Specifies the lower left corner, as well as the width and height of the viewport. When a GL context is 
        /// first attached to a window, width and height are set to the dimensions of that window.
        /// </param>
        public static void Viewport(Rectangle rectangle)
        {
            GL.Viewport(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }
#if MINIMAL
        /// <summary>
        /// [requires: v1.0]
        /// Set the viewport.
        /// </summary>
        /// <param name="location">
        /// Specifies the lower left corner of the viewport.
        /// </param>
        /// <param name="size">
        /// Specifies the width and height of the viewport. When a GL context is first attached to a window, 
        /// width and height are set to the dimensions of that window.
        /// </param>
        public static void Viewport(OpenTK.Point location, OpenTK.Size size)
        {
            GL.Viewport(location.X, location.Y, size.Width, size.Height);
        }

        /// <summary>
        /// [requires: v1.0]
        /// Set the viewport.
        /// </summary>
        /// <param name="rectangle">
        /// Specifies the lower left corner, as well as the width and height of the viewport. When a GL context is 
        /// first attached to a window, width and height are set to the dimensions of that window.
        /// </param>
        public static void Viewport(OpenTK.Rectangle rectangle)
        {
            GL.Viewport(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }
#endif

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Set texture environment parameters.
        /// </summary>
        /// <param name="target">
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl or PointSprite.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either TextureEnvMode, 
        /// TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, 
        /// Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, 
        /// or CoordReplace.
        /// </param>
        /// <param name="color">
        /// Specifies the color to apply.
        /// </param>
        public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Color color)
        {
            Color4 c = new Color4(color.R, color.G, color.B, color.A);
            unsafe
            {
                TexEnv(target, pname, &c.R);
            }
        }

        /// <summary>
        /// [requires: v1.0][deprecated: v3.2]
        /// Set texture environment parameters.
        /// </summary>
        /// <param name="target">
        /// Specifies a texture environment. May be TextureEnv, TextureFilterControl or PointSprite.
        /// </param>
        /// <param name="pname">
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either TextureEnvMode, 
        /// TextureLodBias, CombineRgb, CombineAlpha, Src0Rgb, Src1Rgb, Src2Rgb, Src0Alpha, Src1Alpha, Src2Alpha, 
        /// Operand0Rgb, Operand1Rgb, Operand2Rgb, Operand0Alpha, Operand1Alpha, Operand2Alpha, RgbScale, AlphaScale, 
        /// or CoordReplace.
        /// </param>
        /// <param name="color">
        /// Specifies the color to apply.
        /// </param>
        public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Color4 color)
        {
            unsafe
            {
                TexEnv(target, pname, &color.R);
            }
        }
    }

    #pragma warning disable 1574 // XML comment cref attribute could not be resolved, compiler bug in Mono 3.4.0

    /// <summary>
    /// Defines the signature of a debug callback for
    /// <see cref="GL.Amd.DebugMessageCallback"/>.
    /// </summary>
    /// <param name="id">The id of this debug message.</param>
    /// <param name="category">The <see cref="AmdDebugOutput"/> category for this debug message.</param>
    /// <param name="severity">The <see cref="AmdDebugOutput"/> severity for this debug message.</param>
    /// <param name="length">The length of this debug message.</param>
    /// <param name="message">A pointer to a null-terminated ASCII C string, representing the content of this debug message.</param>
    /// <param name="userParam">A pointer to a user-specified parameter.</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void DebugProcAmd(int id,
        AmdDebugOutput category, AmdDebugOutput severity,
        int length, IntPtr message, IntPtr userParam);

    /// <summary>
    /// Defines the signature of a debug callback for
    /// <see cref="GL.Arb.DebugMessageCallback"/>.
    /// </summary>
    /// <param name="source">The <see cref="DebugSource"/> for this debug message.</param>
    /// <param name="type">The <see cref="DebugType"/> for this debug message.</param>
    /// <param name="id">The id of this debug message.</param>
    /// <param name="severity">The <see cref="DebugSeverity"/> for this debug message.</param>
    /// <param name="length">The length of this debug message.</param>
    /// <param name="message">A pointer to a null-terminated ASCII C string, representing the content of this debug message.</param>
    /// <param name="userParam">A pointer to a user-specified parameter.</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void DebugProcArb(
        DebugSource source, DebugType type, int id,
        DebugSeverity severity, int length, IntPtr message,
        IntPtr userParam);

    /// <summary>
    /// Defines the signature of a debug callback for
    /// <see cref="GL.DebugMessageCallback"/>.
    /// </summary>
    /// <param name="source">The <see cref="DebugSource"/> for this debug message.</param>
    /// <param name="type">The <see cref="DebugType"/> for this debug message.</param>
    /// <param name="id">The id of this debug message.</param>
    /// <param name="severity">The <see cref="DebugSeverity"/> for this debug message.</param>
    /// <param name="length">The length of this debug message.</param>
    /// <param name="message">A pointer to a null-terminated ASCII C string, representing the content of this debug message.</param>
    /// <param name="userParam">A pointer to a user-specified parameter.</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void DebugProc(
        DebugSource source, DebugType type, int id,
        DebugSeverity severity, int length, IntPtr message,
        IntPtr userParam);

    /// <summary>
    /// Defines the signature of a debug callback for
    /// <see cref="GL.Khr.DebugMessageCallback"/>.
    /// </summary>
    /// <param name="source">The <see cref="DebugSource"/> for this debug message.</param>
    /// <param name="type">The <see cref="DebugType"/> for this debug message.</param>
    /// <param name="id">The id of this debug message.</param>
    /// <param name="severity">The <see cref="DebugSeverity"/> for this debug message.</param>
    /// <param name="length">The length of this debug message.</param>
    /// <param name="message">A pointer to a null-terminated ASCII C string, representing the content of this debug message.</param>
    /// <param name="userParam">A pointer to a user-specified parameter.</param>
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void DebugProcKhr(
        DebugSource source, DebugType type, int id,
        DebugSeverity severity, int length, IntPtr message,
        IntPtr userParam);

    #pragma warning restore 1574 // XML comment cref attribute could not be resolved, compiler bug in Mono 3.4.0
}

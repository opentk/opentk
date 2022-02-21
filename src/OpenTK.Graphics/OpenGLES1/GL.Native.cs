// This file is auto generated, do not edit.
using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics;

namespace OpenTK.Graphics.OpenGLES1
{
    public static unsafe partial class GL
    {
        private static delegate* unmanaged<AlphaFunction, float, void> _AlphaFunc_fnptr = &AlphaFunc_Lazy;
        public static void AlphaFunc(AlphaFunction func, float reference) => _AlphaFunc_fnptr(func, reference);
        [UnmanagedCallersOnly]
        private static void AlphaFunc_Lazy(AlphaFunction func, float reference)
        {
            _AlphaFunc_fnptr = (delegate* unmanaged<AlphaFunction, float, void>)GLLoader.BindingsContext.GetProcAddress("glAlphaFunc");
            _AlphaFunc_fnptr(func, reference);
        }
        
        private static delegate* unmanaged<float, float, float, float, void> _ClearColor_fnptr = &ClearColor_Lazy;
        public static void ClearColor(float red, float green, float blue, float alpha) => _ClearColor_fnptr(red, green, blue, alpha);
        [UnmanagedCallersOnly]
        private static void ClearColor_Lazy(float red, float green, float blue, float alpha)
        {
            _ClearColor_fnptr = (delegate* unmanaged<float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glClearColor");
            _ClearColor_fnptr(red, green, blue, alpha);
        }
        
        private static delegate* unmanaged<float, void> _ClearDepthf_fnptr = &ClearDepthf_Lazy;
        public static void ClearDepthf(float d) => _ClearDepthf_fnptr(d);
        [UnmanagedCallersOnly]
        private static void ClearDepthf_Lazy(float d)
        {
            _ClearDepthf_fnptr = (delegate* unmanaged<float, void>)GLLoader.BindingsContext.GetProcAddress("glClearDepthf");
            _ClearDepthf_fnptr(d);
        }
        
        private static delegate* unmanaged<ClipPlaneName, float*, void> _ClipPlanef_fnptr = &ClipPlanef_Lazy;
        public static void ClipPlanef(ClipPlaneName p, float* eqn) => _ClipPlanef_fnptr(p, eqn);
        [UnmanagedCallersOnly]
        private static void ClipPlanef_Lazy(ClipPlaneName p, float* eqn)
        {
            _ClipPlanef_fnptr = (delegate* unmanaged<ClipPlaneName, float*, void>)GLLoader.BindingsContext.GetProcAddress("glClipPlanef");
            _ClipPlanef_fnptr(p, eqn);
        }
        
        private static delegate* unmanaged<float, float, float, float, void> _Color4f_fnptr = &Color4f_Lazy;
        public static void Color4f(float red, float green, float blue, float alpha) => _Color4f_fnptr(red, green, blue, alpha);
        [UnmanagedCallersOnly]
        private static void Color4f_Lazy(float red, float green, float blue, float alpha)
        {
            _Color4f_fnptr = (delegate* unmanaged<float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glColor4f");
            _Color4f_fnptr(red, green, blue, alpha);
        }
        
        private static delegate* unmanaged<float, float, void> _DepthRangef_fnptr = &DepthRangef_Lazy;
        public static void DepthRangef(float n, float f) => _DepthRangef_fnptr(n, f);
        [UnmanagedCallersOnly]
        private static void DepthRangef_Lazy(float n, float f)
        {
            _DepthRangef_fnptr = (delegate* unmanaged<float, float, void>)GLLoader.BindingsContext.GetProcAddress("glDepthRangef");
            _DepthRangef_fnptr(n, f);
        }
        
        private static delegate* unmanaged<FogParameter, float, void> _Fogf_fnptr = &Fogf_Lazy;
        public static void Fogf(FogParameter pname, float param) => _Fogf_fnptr(pname, param);
        [UnmanagedCallersOnly]
        private static void Fogf_Lazy(FogParameter pname, float param)
        {
            _Fogf_fnptr = (delegate* unmanaged<FogParameter, float, void>)GLLoader.BindingsContext.GetProcAddress("glFogf");
            _Fogf_fnptr(pname, param);
        }
        
        private static delegate* unmanaged<FogParameter, float*, void> _Fogfv_fnptr = &Fogfv_Lazy;
        public static void Fogfv(FogParameter pname, float* parameters) => _Fogfv_fnptr(pname, parameters);
        [UnmanagedCallersOnly]
        private static void Fogfv_Lazy(FogParameter pname, float* parameters)
        {
            _Fogfv_fnptr = (delegate* unmanaged<FogParameter, float*, void>)GLLoader.BindingsContext.GetProcAddress("glFogfv");
            _Fogfv_fnptr(pname, parameters);
        }
        
        private static delegate* unmanaged<float, float, float, float, float, float, void> _Frustumf_fnptr = &Frustumf_Lazy;
        public static void Frustumf(float l, float r, float b, float t, float n, float f) => _Frustumf_fnptr(l, r, b, t, n, f);
        [UnmanagedCallersOnly]
        private static void Frustumf_Lazy(float l, float r, float b, float t, float n, float f)
        {
            _Frustumf_fnptr = (delegate* unmanaged<float, float, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glFrustumf");
            _Frustumf_fnptr(l, r, b, t, n, f);
        }
        
        private static delegate* unmanaged<ClipPlaneName, float*, void> _GetClipPlanef_fnptr = &GetClipPlanef_Lazy;
        public static void GetClipPlanef(ClipPlaneName plane, float* equation) => _GetClipPlanef_fnptr(plane, equation);
        [UnmanagedCallersOnly]
        private static void GetClipPlanef_Lazy(ClipPlaneName plane, float* equation)
        {
            _GetClipPlanef_fnptr = (delegate* unmanaged<ClipPlaneName, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetClipPlanef");
            _GetClipPlanef_fnptr(plane, equation);
        }
        
        private static delegate* unmanaged<GetPName, float*, void> _GetFloatv_fnptr = &GetFloatv_Lazy;
        public static void GetFloatv(GetPName pname, float* data) => _GetFloatv_fnptr(pname, data);
        [UnmanagedCallersOnly]
        private static void GetFloatv_Lazy(GetPName pname, float* data)
        {
            _GetFloatv_fnptr = (delegate* unmanaged<GetPName, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetFloatv");
            _GetFloatv_fnptr(pname, data);
        }
        
        private static delegate* unmanaged<LightName, LightParameter, float*, void> _GetLightfv_fnptr = &GetLightfv_Lazy;
        public static void GetLightfv(LightName light, LightParameter pname, float* parameters) => _GetLightfv_fnptr(light, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetLightfv_Lazy(LightName light, LightParameter pname, float* parameters)
        {
            _GetLightfv_fnptr = (delegate* unmanaged<LightName, LightParameter, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetLightfv");
            _GetLightfv_fnptr(light, pname, parameters);
        }
        
        private static delegate* unmanaged<MaterialFace, MaterialParameter, float*, void> _GetMaterialfv_fnptr = &GetMaterialfv_Lazy;
        public static void GetMaterialfv(MaterialFace face, MaterialParameter pname, float* parameters) => _GetMaterialfv_fnptr(face, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetMaterialfv_Lazy(MaterialFace face, MaterialParameter pname, float* parameters)
        {
            _GetMaterialfv_fnptr = (delegate* unmanaged<MaterialFace, MaterialParameter, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetMaterialfv");
            _GetMaterialfv_fnptr(face, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, float*, void> _GetTexEnvfv_fnptr = &GetTexEnvfv_Lazy;
        public static void GetTexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* parameters) => _GetTexEnvfv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexEnvfv_Lazy(TextureEnvTarget target, TextureEnvParameter pname, float* parameters)
        {
            _GetTexEnvfv_fnptr = (delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexEnvfv");
            _GetTexEnvfv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureTarget, GetTextureParameter, float*, void> _GetTexParameterfv_fnptr = &GetTexParameterfv_Lazy;
        public static void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, float* parameters) => _GetTexParameterfv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexParameterfv_Lazy(TextureTarget target, GetTextureParameter pname, float* parameters)
        {
            _GetTexParameterfv_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexParameterfv");
            _GetTexParameterfv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<LightModelParameter, float, void> _LightModelf_fnptr = &LightModelf_Lazy;
        public static void LightModelf(LightModelParameter pname, float param) => _LightModelf_fnptr(pname, param);
        [UnmanagedCallersOnly]
        private static void LightModelf_Lazy(LightModelParameter pname, float param)
        {
            _LightModelf_fnptr = (delegate* unmanaged<LightModelParameter, float, void>)GLLoader.BindingsContext.GetProcAddress("glLightModelf");
            _LightModelf_fnptr(pname, param);
        }
        
        private static delegate* unmanaged<LightModelParameter, float*, void> _LightModelfv_fnptr = &LightModelfv_Lazy;
        public static void LightModelfv(LightModelParameter pname, float* parameters) => _LightModelfv_fnptr(pname, parameters);
        [UnmanagedCallersOnly]
        private static void LightModelfv_Lazy(LightModelParameter pname, float* parameters)
        {
            _LightModelfv_fnptr = (delegate* unmanaged<LightModelParameter, float*, void>)GLLoader.BindingsContext.GetProcAddress("glLightModelfv");
            _LightModelfv_fnptr(pname, parameters);
        }
        
        private static delegate* unmanaged<LightName, LightParameter, float, void> _Lightf_fnptr = &Lightf_Lazy;
        public static void Lightf(LightName light, LightParameter pname, float param) => _Lightf_fnptr(light, pname, param);
        [UnmanagedCallersOnly]
        private static void Lightf_Lazy(LightName light, LightParameter pname, float param)
        {
            _Lightf_fnptr = (delegate* unmanaged<LightName, LightParameter, float, void>)GLLoader.BindingsContext.GetProcAddress("glLightf");
            _Lightf_fnptr(light, pname, param);
        }
        
        private static delegate* unmanaged<LightName, LightParameter, float*, void> _Lightfv_fnptr = &Lightfv_Lazy;
        public static void Lightfv(LightName light, LightParameter pname, float* parameters) => _Lightfv_fnptr(light, pname, parameters);
        [UnmanagedCallersOnly]
        private static void Lightfv_Lazy(LightName light, LightParameter pname, float* parameters)
        {
            _Lightfv_fnptr = (delegate* unmanaged<LightName, LightParameter, float*, void>)GLLoader.BindingsContext.GetProcAddress("glLightfv");
            _Lightfv_fnptr(light, pname, parameters);
        }
        
        private static delegate* unmanaged<float, void> _LineWidth_fnptr = &LineWidth_Lazy;
        public static void LineWidth(float width) => _LineWidth_fnptr(width);
        [UnmanagedCallersOnly]
        private static void LineWidth_Lazy(float width)
        {
            _LineWidth_fnptr = (delegate* unmanaged<float, void>)GLLoader.BindingsContext.GetProcAddress("glLineWidth");
            _LineWidth_fnptr(width);
        }
        
        private static delegate* unmanaged<float*, void> _LoadMatrixf_fnptr = &LoadMatrixf_Lazy;
        public static void LoadMatrixf(float* m) => _LoadMatrixf_fnptr(m);
        [UnmanagedCallersOnly]
        private static void LoadMatrixf_Lazy(float* m)
        {
            _LoadMatrixf_fnptr = (delegate* unmanaged<float*, void>)GLLoader.BindingsContext.GetProcAddress("glLoadMatrixf");
            _LoadMatrixf_fnptr(m);
        }
        
        private static delegate* unmanaged<MaterialFace, MaterialParameter, float, void> _Materialf_fnptr = &Materialf_Lazy;
        public static void Materialf(MaterialFace face, MaterialParameter pname, float param) => _Materialf_fnptr(face, pname, param);
        [UnmanagedCallersOnly]
        private static void Materialf_Lazy(MaterialFace face, MaterialParameter pname, float param)
        {
            _Materialf_fnptr = (delegate* unmanaged<MaterialFace, MaterialParameter, float, void>)GLLoader.BindingsContext.GetProcAddress("glMaterialf");
            _Materialf_fnptr(face, pname, param);
        }
        
        private static delegate* unmanaged<MaterialFace, MaterialParameter, float*, void> _Materialfv_fnptr = &Materialfv_Lazy;
        public static void Materialfv(MaterialFace face, MaterialParameter pname, float* parameters) => _Materialfv_fnptr(face, pname, parameters);
        [UnmanagedCallersOnly]
        private static void Materialfv_Lazy(MaterialFace face, MaterialParameter pname, float* parameters)
        {
            _Materialfv_fnptr = (delegate* unmanaged<MaterialFace, MaterialParameter, float*, void>)GLLoader.BindingsContext.GetProcAddress("glMaterialfv");
            _Materialfv_fnptr(face, pname, parameters);
        }
        
        private static delegate* unmanaged<float*, void> _MultMatrixf_fnptr = &MultMatrixf_Lazy;
        public static void MultMatrixf(float* m) => _MultMatrixf_fnptr(m);
        [UnmanagedCallersOnly]
        private static void MultMatrixf_Lazy(float* m)
        {
            _MultMatrixf_fnptr = (delegate* unmanaged<float*, void>)GLLoader.BindingsContext.GetProcAddress("glMultMatrixf");
            _MultMatrixf_fnptr(m);
        }
        
        private static delegate* unmanaged<TextureUnit, float, float, float, float, void> _MultiTexCoord4f_fnptr = &MultiTexCoord4f_Lazy;
        public static void MultiTexCoord4f(TextureUnit target, float s, float t, float r, float q) => _MultiTexCoord4f_fnptr(target, s, t, r, q);
        [UnmanagedCallersOnly]
        private static void MultiTexCoord4f_Lazy(TextureUnit target, float s, float t, float r, float q)
        {
            _MultiTexCoord4f_fnptr = (delegate* unmanaged<TextureUnit, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord4f");
            _MultiTexCoord4f_fnptr(target, s, t, r, q);
        }
        
        private static delegate* unmanaged<float, float, float, void> _Normal3f_fnptr = &Normal3f_Lazy;
        public static void Normal3f(float nx, float ny, float nz) => _Normal3f_fnptr(nx, ny, nz);
        [UnmanagedCallersOnly]
        private static void Normal3f_Lazy(float nx, float ny, float nz)
        {
            _Normal3f_fnptr = (delegate* unmanaged<float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glNormal3f");
            _Normal3f_fnptr(nx, ny, nz);
        }
        
        private static delegate* unmanaged<float, float, float, float, float, float, void> _Orthof_fnptr = &Orthof_Lazy;
        public static void Orthof(float l, float r, float b, float t, float n, float f) => _Orthof_fnptr(l, r, b, t, n, f);
        [UnmanagedCallersOnly]
        private static void Orthof_Lazy(float l, float r, float b, float t, float n, float f)
        {
            _Orthof_fnptr = (delegate* unmanaged<float, float, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glOrthof");
            _Orthof_fnptr(l, r, b, t, n, f);
        }
        
        private static delegate* unmanaged<PointParameterNameARB, float, void> _PointParameterf_fnptr = &PointParameterf_Lazy;
        public static void PointParameterf(PointParameterNameARB pname, float param) => _PointParameterf_fnptr(pname, param);
        [UnmanagedCallersOnly]
        private static void PointParameterf_Lazy(PointParameterNameARB pname, float param)
        {
            _PointParameterf_fnptr = (delegate* unmanaged<PointParameterNameARB, float, void>)GLLoader.BindingsContext.GetProcAddress("glPointParameterf");
            _PointParameterf_fnptr(pname, param);
        }
        
        private static delegate* unmanaged<PointParameterNameARB, float*, void> _PointParameterfv_fnptr = &PointParameterfv_Lazy;
        public static void PointParameterfv(PointParameterNameARB pname, float* parameters) => _PointParameterfv_fnptr(pname, parameters);
        [UnmanagedCallersOnly]
        private static void PointParameterfv_Lazy(PointParameterNameARB pname, float* parameters)
        {
            _PointParameterfv_fnptr = (delegate* unmanaged<PointParameterNameARB, float*, void>)GLLoader.BindingsContext.GetProcAddress("glPointParameterfv");
            _PointParameterfv_fnptr(pname, parameters);
        }
        
        private static delegate* unmanaged<float, void> _PointSize_fnptr = &PointSize_Lazy;
        public static void PointSize(float size) => _PointSize_fnptr(size);
        [UnmanagedCallersOnly]
        private static void PointSize_Lazy(float size)
        {
            _PointSize_fnptr = (delegate* unmanaged<float, void>)GLLoader.BindingsContext.GetProcAddress("glPointSize");
            _PointSize_fnptr(size);
        }
        
        private static delegate* unmanaged<float, float, void> _PolygonOffset_fnptr = &PolygonOffset_Lazy;
        public static void PolygonOffset(float factor, float units) => _PolygonOffset_fnptr(factor, units);
        [UnmanagedCallersOnly]
        private static void PolygonOffset_Lazy(float factor, float units)
        {
            _PolygonOffset_fnptr = (delegate* unmanaged<float, float, void>)GLLoader.BindingsContext.GetProcAddress("glPolygonOffset");
            _PolygonOffset_fnptr(factor, units);
        }
        
        private static delegate* unmanaged<float, float, float, float, void> _Rotatef_fnptr = &Rotatef_Lazy;
        public static void Rotatef(float angle, float x, float y, float z) => _Rotatef_fnptr(angle, x, y, z);
        [UnmanagedCallersOnly]
        private static void Rotatef_Lazy(float angle, float x, float y, float z)
        {
            _Rotatef_fnptr = (delegate* unmanaged<float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glRotatef");
            _Rotatef_fnptr(angle, x, y, z);
        }
        
        private static delegate* unmanaged<float, float, float, void> _Scalef_fnptr = &Scalef_Lazy;
        public static void Scalef(float x, float y, float z) => _Scalef_fnptr(x, y, z);
        [UnmanagedCallersOnly]
        private static void Scalef_Lazy(float x, float y, float z)
        {
            _Scalef_fnptr = (delegate* unmanaged<float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glScalef");
            _Scalef_fnptr(x, y, z);
        }
        
        private static delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, float, void> _TexEnvf_fnptr = &TexEnvf_Lazy;
        public static void TexEnvf(TextureEnvTarget target, TextureEnvParameter pname, float param) => _TexEnvf_fnptr(target, pname, param);
        [UnmanagedCallersOnly]
        private static void TexEnvf_Lazy(TextureEnvTarget target, TextureEnvParameter pname, float param)
        {
            _TexEnvf_fnptr = (delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, float, void>)GLLoader.BindingsContext.GetProcAddress("glTexEnvf");
            _TexEnvf_fnptr(target, pname, param);
        }
        
        private static delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, float*, void> _TexEnvfv_fnptr = &TexEnvfv_Lazy;
        public static void TexEnvfv(TextureEnvTarget target, TextureEnvParameter pname, float* parameters) => _TexEnvfv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexEnvfv_Lazy(TextureEnvTarget target, TextureEnvParameter pname, float* parameters)
        {
            _TexEnvfv_fnptr = (delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, float*, void>)GLLoader.BindingsContext.GetProcAddress("glTexEnvfv");
            _TexEnvfv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureTarget, TextureParameterName, float, void> _TexParameterf_fnptr = &TexParameterf_Lazy;
        public static void TexParameterf(TextureTarget target, TextureParameterName pname, float param) => _TexParameterf_fnptr(target, pname, param);
        [UnmanagedCallersOnly]
        private static void TexParameterf_Lazy(TextureTarget target, TextureParameterName pname, float param)
        {
            _TexParameterf_fnptr = (delegate* unmanaged<TextureTarget, TextureParameterName, float, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameterf");
            _TexParameterf_fnptr(target, pname, param);
        }
        
        private static delegate* unmanaged<TextureTarget, TextureParameterName, float*, void> _TexParameterfv_fnptr = &TexParameterfv_Lazy;
        public static void TexParameterfv(TextureTarget target, TextureParameterName pname, float* parameters) => _TexParameterfv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexParameterfv_Lazy(TextureTarget target, TextureParameterName pname, float* parameters)
        {
            _TexParameterfv_fnptr = (delegate* unmanaged<TextureTarget, TextureParameterName, float*, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameterfv");
            _TexParameterfv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<float, float, float, void> _Translatef_fnptr = &Translatef_Lazy;
        public static void Translatef(float x, float y, float z) => _Translatef_fnptr(x, y, z);
        [UnmanagedCallersOnly]
        private static void Translatef_Lazy(float x, float y, float z)
        {
            _Translatef_fnptr = (delegate* unmanaged<float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glTranslatef");
            _Translatef_fnptr(x, y, z);
        }
        
        private static delegate* unmanaged<TextureUnit, void> _ActiveTexture_fnptr = &ActiveTexture_Lazy;
        public static void ActiveTexture(TextureUnit texture) => _ActiveTexture_fnptr(texture);
        [UnmanagedCallersOnly]
        private static void ActiveTexture_Lazy(TextureUnit texture)
        {
            _ActiveTexture_fnptr = (delegate* unmanaged<TextureUnit, void>)GLLoader.BindingsContext.GetProcAddress("glActiveTexture");
            _ActiveTexture_fnptr(texture);
        }
        
        private static delegate* unmanaged<AlphaFunction, int, void> _AlphaFuncx_fnptr = &AlphaFuncx_Lazy;
        public static void AlphaFuncx(AlphaFunction func, int reference) => _AlphaFuncx_fnptr(func, reference);
        [UnmanagedCallersOnly]
        private static void AlphaFuncx_Lazy(AlphaFunction func, int reference)
        {
            _AlphaFuncx_fnptr = (delegate* unmanaged<AlphaFunction, int, void>)GLLoader.BindingsContext.GetProcAddress("glAlphaFuncx");
            _AlphaFuncx_fnptr(func, reference);
        }
        
        private static delegate* unmanaged<BufferTargetARB, BufferHandle, void> _BindBuffer_fnptr = &BindBuffer_Lazy;
        public static void BindBuffer(BufferTargetARB target, BufferHandle buffer) => _BindBuffer_fnptr(target, buffer);
        [UnmanagedCallersOnly]
        private static void BindBuffer_Lazy(BufferTargetARB target, BufferHandle buffer)
        {
            _BindBuffer_fnptr = (delegate* unmanaged<BufferTargetARB, BufferHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindBuffer");
            _BindBuffer_fnptr(target, buffer);
        }
        
        private static delegate* unmanaged<TextureTarget, TextureHandle, void> _BindTexture_fnptr = &BindTexture_Lazy;
        public static void BindTexture(TextureTarget target, TextureHandle texture) => _BindTexture_fnptr(target, texture);
        [UnmanagedCallersOnly]
        private static void BindTexture_Lazy(TextureTarget target, TextureHandle texture)
        {
            _BindTexture_fnptr = (delegate* unmanaged<TextureTarget, TextureHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindTexture");
            _BindTexture_fnptr(target, texture);
        }
        
        private static delegate* unmanaged<BlendingFactor, BlendingFactor, void> _BlendFunc_fnptr = &BlendFunc_Lazy;
        public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor) => _BlendFunc_fnptr(sfactor, dfactor);
        [UnmanagedCallersOnly]
        private static void BlendFunc_Lazy(BlendingFactor sfactor, BlendingFactor dfactor)
        {
            _BlendFunc_fnptr = (delegate* unmanaged<BlendingFactor, BlendingFactor, void>)GLLoader.BindingsContext.GetProcAddress("glBlendFunc");
            _BlendFunc_fnptr(sfactor, dfactor);
        }
        
        private static delegate* unmanaged<BufferTargetARB, nint, void*, BufferUsageARB, void> _BufferData_fnptr = &BufferData_Lazy;
        public static void BufferData(BufferTargetARB target, nint size, void* data, BufferUsageARB usage) => _BufferData_fnptr(target, size, data, usage);
        [UnmanagedCallersOnly]
        private static void BufferData_Lazy(BufferTargetARB target, nint size, void* data, BufferUsageARB usage)
        {
            _BufferData_fnptr = (delegate* unmanaged<BufferTargetARB, nint, void*, BufferUsageARB, void>)GLLoader.BindingsContext.GetProcAddress("glBufferData");
            _BufferData_fnptr(target, size, data, usage);
        }
        
        private static delegate* unmanaged<BufferTargetARB, IntPtr, nint, void*, void> _BufferSubData_fnptr = &BufferSubData_Lazy;
        public static void BufferSubData(BufferTargetARB target, IntPtr offset, nint size, void* data) => _BufferSubData_fnptr(target, offset, size, data);
        [UnmanagedCallersOnly]
        private static void BufferSubData_Lazy(BufferTargetARB target, IntPtr offset, nint size, void* data)
        {
            _BufferSubData_fnptr = (delegate* unmanaged<BufferTargetARB, IntPtr, nint, void*, void>)GLLoader.BindingsContext.GetProcAddress("glBufferSubData");
            _BufferSubData_fnptr(target, offset, size, data);
        }
        
        private static delegate* unmanaged<ClearBufferMask, void> _Clear_fnptr = &Clear_Lazy;
        public static void Clear(ClearBufferMask mask) => _Clear_fnptr(mask);
        [UnmanagedCallersOnly]
        private static void Clear_Lazy(ClearBufferMask mask)
        {
            _Clear_fnptr = (delegate* unmanaged<ClearBufferMask, void>)GLLoader.BindingsContext.GetProcAddress("glClear");
            _Clear_fnptr(mask);
        }
        
        private static delegate* unmanaged<int, int, int, int, void> _ClearColorx_fnptr = &ClearColorx_Lazy;
        public static void ClearColorx(int red, int green, int blue, int alpha) => _ClearColorx_fnptr(red, green, blue, alpha);
        [UnmanagedCallersOnly]
        private static void ClearColorx_Lazy(int red, int green, int blue, int alpha)
        {
            _ClearColorx_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glClearColorx");
            _ClearColorx_fnptr(red, green, blue, alpha);
        }
        
        private static delegate* unmanaged<int, void> _ClearDepthx_fnptr = &ClearDepthx_Lazy;
        public static void ClearDepthx(int depth) => _ClearDepthx_fnptr(depth);
        [UnmanagedCallersOnly]
        private static void ClearDepthx_Lazy(int depth)
        {
            _ClearDepthx_fnptr = (delegate* unmanaged<int, void>)GLLoader.BindingsContext.GetProcAddress("glClearDepthx");
            _ClearDepthx_fnptr(depth);
        }
        
        private static delegate* unmanaged<int, void> _ClearStencil_fnptr = &ClearStencil_Lazy;
        public static void ClearStencil(int s) => _ClearStencil_fnptr(s);
        [UnmanagedCallersOnly]
        private static void ClearStencil_Lazy(int s)
        {
            _ClearStencil_fnptr = (delegate* unmanaged<int, void>)GLLoader.BindingsContext.GetProcAddress("glClearStencil");
            _ClearStencil_fnptr(s);
        }
        
        private static delegate* unmanaged<TextureUnit, void> _ClientActiveTexture_fnptr = &ClientActiveTexture_Lazy;
        public static void ClientActiveTexture(TextureUnit texture) => _ClientActiveTexture_fnptr(texture);
        [UnmanagedCallersOnly]
        private static void ClientActiveTexture_Lazy(TextureUnit texture)
        {
            _ClientActiveTexture_fnptr = (delegate* unmanaged<TextureUnit, void>)GLLoader.BindingsContext.GetProcAddress("glClientActiveTexture");
            _ClientActiveTexture_fnptr(texture);
        }
        
        private static delegate* unmanaged<ClipPlaneName, int*, void> _ClipPlanex_fnptr = &ClipPlanex_Lazy;
        public static void ClipPlanex(ClipPlaneName plane, int* equation) => _ClipPlanex_fnptr(plane, equation);
        [UnmanagedCallersOnly]
        private static void ClipPlanex_Lazy(ClipPlaneName plane, int* equation)
        {
            _ClipPlanex_fnptr = (delegate* unmanaged<ClipPlaneName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glClipPlanex");
            _ClipPlanex_fnptr(plane, equation);
        }
        
        private static delegate* unmanaged<byte, byte, byte, byte, void> _Color4ub_fnptr = &Color4ub_Lazy;
        public static void Color4ub(byte red, byte green, byte blue, byte alpha) => _Color4ub_fnptr(red, green, blue, alpha);
        [UnmanagedCallersOnly]
        private static void Color4ub_Lazy(byte red, byte green, byte blue, byte alpha)
        {
            _Color4ub_fnptr = (delegate* unmanaged<byte, byte, byte, byte, void>)GLLoader.BindingsContext.GetProcAddress("glColor4ub");
            _Color4ub_fnptr(red, green, blue, alpha);
        }
        
        private static delegate* unmanaged<int, int, int, int, void> _Color4x_fnptr = &Color4x_Lazy;
        public static void Color4x(int red, int green, int blue, int alpha) => _Color4x_fnptr(red, green, blue, alpha);
        [UnmanagedCallersOnly]
        private static void Color4x_Lazy(int red, int green, int blue, int alpha)
        {
            _Color4x_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glColor4x");
            _Color4x_fnptr(red, green, blue, alpha);
        }
        
        private static delegate* unmanaged<byte, byte, byte, byte, void> _ColorMask_fnptr = &ColorMask_Lazy;
        public static void ColorMask(byte red, byte green, byte blue, byte alpha) => _ColorMask_fnptr(red, green, blue, alpha);
        [UnmanagedCallersOnly]
        private static void ColorMask_Lazy(byte red, byte green, byte blue, byte alpha)
        {
            _ColorMask_fnptr = (delegate* unmanaged<byte, byte, byte, byte, void>)GLLoader.BindingsContext.GetProcAddress("glColorMask");
            _ColorMask_fnptr(red, green, blue, alpha);
        }
        
        private static delegate* unmanaged<int, ColorPointerType, int, void*, void> _ColorPointer_fnptr = &ColorPointer_Lazy;
        public static void ColorPointer(int size, ColorPointerType type, int stride, void* pointer) => _ColorPointer_fnptr(size, type, stride, pointer);
        [UnmanagedCallersOnly]
        private static void ColorPointer_Lazy(int size, ColorPointerType type, int stride, void* pointer)
        {
            _ColorPointer_fnptr = (delegate* unmanaged<int, ColorPointerType, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glColorPointer");
            _ColorPointer_fnptr(size, type, stride, pointer);
        }
        
        private static delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, void*, void> _CompressedTexImage2D_fnptr = &CompressedTexImage2D_Lazy;
        public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data) => _CompressedTexImage2D_fnptr(target, level, internalformat, width, height, border, imageSize, data);
        [UnmanagedCallersOnly]
        private static void CompressedTexImage2D_Lazy(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, void* data)
        {
            _CompressedTexImage2D_fnptr = (delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glCompressedTexImage2D");
            _CompressedTexImage2D_fnptr(target, level, internalformat, width, height, border, imageSize, data);
        }
        
        private static delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, int, void*, void> _CompressedTexSubImage2D_fnptr = &CompressedTexSubImage2D_Lazy;
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void* data) => _CompressedTexSubImage2D_fnptr(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        [UnmanagedCallersOnly]
        private static void CompressedTexSubImage2D_Lazy(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, void* data)
        {
            _CompressedTexSubImage2D_fnptr = (delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glCompressedTexSubImage2D");
            _CompressedTexSubImage2D_fnptr(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }
        
        private static delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, int, void> _CopyTexImage2D_fnptr = &CopyTexImage2D_Lazy;
        public static void CopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border) => _CopyTexImage2D_fnptr(target, level, internalformat, x, y, width, height, border);
        [UnmanagedCallersOnly]
        private static void CopyTexImage2D_Lazy(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border)
        {
            _CopyTexImage2D_fnptr = (delegate* unmanaged<TextureTarget, int, InternalFormat, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glCopyTexImage2D");
            _CopyTexImage2D_fnptr(target, level, internalformat, x, y, width, height, border);
        }
        
        private static delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, void> _CopyTexSubImage2D_fnptr = &CopyTexSubImage2D_Lazy;
        public static void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height) => _CopyTexSubImage2D_fnptr(target, level, xoffset, yoffset, x, y, width, height);
        [UnmanagedCallersOnly]
        private static void CopyTexSubImage2D_Lazy(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
        {
            _CopyTexSubImage2D_fnptr = (delegate* unmanaged<TextureTarget, int, int, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glCopyTexSubImage2D");
            _CopyTexSubImage2D_fnptr(target, level, xoffset, yoffset, x, y, width, height);
        }
        
        private static delegate* unmanaged<CullFaceMode, void> _CullFace_fnptr = &CullFace_Lazy;
        public static void CullFace(CullFaceMode mode) => _CullFace_fnptr(mode);
        [UnmanagedCallersOnly]
        private static void CullFace_Lazy(CullFaceMode mode)
        {
            _CullFace_fnptr = (delegate* unmanaged<CullFaceMode, void>)GLLoader.BindingsContext.GetProcAddress("glCullFace");
            _CullFace_fnptr(mode);
        }
        
        private static delegate* unmanaged<int, BufferHandle*, void> _DeleteBuffers_fnptr = &DeleteBuffers_Lazy;
        public static void DeleteBuffers(int n, BufferHandle* buffers) => _DeleteBuffers_fnptr(n, buffers);
        [UnmanagedCallersOnly]
        private static void DeleteBuffers_Lazy(int n, BufferHandle* buffers)
        {
            _DeleteBuffers_fnptr = (delegate* unmanaged<int, BufferHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteBuffers");
            _DeleteBuffers_fnptr(n, buffers);
        }
        
        private static delegate* unmanaged<int, TextureHandle*, void> _DeleteTextures_fnptr = &DeleteTextures_Lazy;
        public static void DeleteTextures(int n, TextureHandle* textures) => _DeleteTextures_fnptr(n, textures);
        [UnmanagedCallersOnly]
        private static void DeleteTextures_Lazy(int n, TextureHandle* textures)
        {
            _DeleteTextures_fnptr = (delegate* unmanaged<int, TextureHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteTextures");
            _DeleteTextures_fnptr(n, textures);
        }
        
        private static delegate* unmanaged<DepthFunction, void> _DepthFunc_fnptr = &DepthFunc_Lazy;
        public static void DepthFunc(DepthFunction func) => _DepthFunc_fnptr(func);
        [UnmanagedCallersOnly]
        private static void DepthFunc_Lazy(DepthFunction func)
        {
            _DepthFunc_fnptr = (delegate* unmanaged<DepthFunction, void>)GLLoader.BindingsContext.GetProcAddress("glDepthFunc");
            _DepthFunc_fnptr(func);
        }
        
        private static delegate* unmanaged<byte, void> _DepthMask_fnptr = &DepthMask_Lazy;
        public static void DepthMask(byte flag) => _DepthMask_fnptr(flag);
        [UnmanagedCallersOnly]
        private static void DepthMask_Lazy(byte flag)
        {
            _DepthMask_fnptr = (delegate* unmanaged<byte, void>)GLLoader.BindingsContext.GetProcAddress("glDepthMask");
            _DepthMask_fnptr(flag);
        }
        
        private static delegate* unmanaged<int, int, void> _DepthRangex_fnptr = &DepthRangex_Lazy;
        public static void DepthRangex(int n, int f) => _DepthRangex_fnptr(n, f);
        [UnmanagedCallersOnly]
        private static void DepthRangex_Lazy(int n, int f)
        {
            _DepthRangex_fnptr = (delegate* unmanaged<int, int, void>)GLLoader.BindingsContext.GetProcAddress("glDepthRangex");
            _DepthRangex_fnptr(n, f);
        }
        
        private static delegate* unmanaged<EnableCap, void> _Disable_fnptr = &Disable_Lazy;
        public static void Disable(EnableCap cap) => _Disable_fnptr(cap);
        [UnmanagedCallersOnly]
        private static void Disable_Lazy(EnableCap cap)
        {
            _Disable_fnptr = (delegate* unmanaged<EnableCap, void>)GLLoader.BindingsContext.GetProcAddress("glDisable");
            _Disable_fnptr(cap);
        }
        
        private static delegate* unmanaged<EnableCap, void> _DisableClientState_fnptr = &DisableClientState_Lazy;
        public static void DisableClientState(EnableCap array) => _DisableClientState_fnptr(array);
        [UnmanagedCallersOnly]
        private static void DisableClientState_Lazy(EnableCap array)
        {
            _DisableClientState_fnptr = (delegate* unmanaged<EnableCap, void>)GLLoader.BindingsContext.GetProcAddress("glDisableClientState");
            _DisableClientState_fnptr(array);
        }
        
        private static delegate* unmanaged<PrimitiveType, int, int, void> _DrawArrays_fnptr = &DrawArrays_Lazy;
        public static void DrawArrays(PrimitiveType mode, int first, int count) => _DrawArrays_fnptr(mode, first, count);
        [UnmanagedCallersOnly]
        private static void DrawArrays_Lazy(PrimitiveType mode, int first, int count)
        {
            _DrawArrays_fnptr = (delegate* unmanaged<PrimitiveType, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawArrays");
            _DrawArrays_fnptr(mode, first, count);
        }
        
        private static delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, void> _DrawElements_fnptr = &DrawElements_Lazy;
        public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, void* indices) => _DrawElements_fnptr(mode, count, type, indices);
        [UnmanagedCallersOnly]
        private static void DrawElements_Lazy(PrimitiveType mode, int count, DrawElementsType type, void* indices)
        {
            _DrawElements_fnptr = (delegate* unmanaged<PrimitiveType, int, DrawElementsType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glDrawElements");
            _DrawElements_fnptr(mode, count, type, indices);
        }
        
        private static delegate* unmanaged<EnableCap, void> _Enable_fnptr = &Enable_Lazy;
        public static void Enable(EnableCap cap) => _Enable_fnptr(cap);
        [UnmanagedCallersOnly]
        private static void Enable_Lazy(EnableCap cap)
        {
            _Enable_fnptr = (delegate* unmanaged<EnableCap, void>)GLLoader.BindingsContext.GetProcAddress("glEnable");
            _Enable_fnptr(cap);
        }
        
        private static delegate* unmanaged<EnableCap, void> _EnableClientState_fnptr = &EnableClientState_Lazy;
        public static void EnableClientState(EnableCap array) => _EnableClientState_fnptr(array);
        [UnmanagedCallersOnly]
        private static void EnableClientState_Lazy(EnableCap array)
        {
            _EnableClientState_fnptr = (delegate* unmanaged<EnableCap, void>)GLLoader.BindingsContext.GetProcAddress("glEnableClientState");
            _EnableClientState_fnptr(array);
        }
        
        private static delegate* unmanaged<void> _Finish_fnptr = &Finish_Lazy;
        public static void Finish() => _Finish_fnptr();
        [UnmanagedCallersOnly]
        private static void Finish_Lazy()
        {
            _Finish_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glFinish");
            _Finish_fnptr();
        }
        
        private static delegate* unmanaged<void> _Flush_fnptr = &Flush_Lazy;
        public static void Flush() => _Flush_fnptr();
        [UnmanagedCallersOnly]
        private static void Flush_Lazy()
        {
            _Flush_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glFlush");
            _Flush_fnptr();
        }
        
        private static delegate* unmanaged<FogPName, int, void> _Fogx_fnptr = &Fogx_Lazy;
        public static void Fogx(FogPName pname, int param) => _Fogx_fnptr(pname, param);
        [UnmanagedCallersOnly]
        private static void Fogx_Lazy(FogPName pname, int param)
        {
            _Fogx_fnptr = (delegate* unmanaged<FogPName, int, void>)GLLoader.BindingsContext.GetProcAddress("glFogx");
            _Fogx_fnptr(pname, param);
        }
        
        private static delegate* unmanaged<FogPName, int*, void> _Fogxv_fnptr = &Fogxv_Lazy;
        public static void Fogxv(FogPName pname, int* param) => _Fogxv_fnptr(pname, param);
        [UnmanagedCallersOnly]
        private static void Fogxv_Lazy(FogPName pname, int* param)
        {
            _Fogxv_fnptr = (delegate* unmanaged<FogPName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glFogxv");
            _Fogxv_fnptr(pname, param);
        }
        
        private static delegate* unmanaged<FrontFaceDirection, void> _FrontFace_fnptr = &FrontFace_Lazy;
        public static void FrontFace(FrontFaceDirection mode) => _FrontFace_fnptr(mode);
        [UnmanagedCallersOnly]
        private static void FrontFace_Lazy(FrontFaceDirection mode)
        {
            _FrontFace_fnptr = (delegate* unmanaged<FrontFaceDirection, void>)GLLoader.BindingsContext.GetProcAddress("glFrontFace");
            _FrontFace_fnptr(mode);
        }
        
        private static delegate* unmanaged<int, int, int, int, int, int, void> _Frustumx_fnptr = &Frustumx_Lazy;
        public static void Frustumx(int l, int r, int b, int t, int n, int f) => _Frustumx_fnptr(l, r, b, t, n, f);
        [UnmanagedCallersOnly]
        private static void Frustumx_Lazy(int l, int r, int b, int t, int n, int f)
        {
            _Frustumx_fnptr = (delegate* unmanaged<int, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glFrustumx");
            _Frustumx_fnptr(l, r, b, t, n, f);
        }
        
        private static delegate* unmanaged<GetPName, byte*, void> _GetBooleanv_fnptr = &GetBooleanv_Lazy;
        public static void GetBooleanv(GetPName pname, byte* data) => _GetBooleanv_fnptr(pname, data);
        [UnmanagedCallersOnly]
        private static void GetBooleanv_Lazy(GetPName pname, byte* data)
        {
            _GetBooleanv_fnptr = (delegate* unmanaged<GetPName, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetBooleanv");
            _GetBooleanv_fnptr(pname, data);
        }
        
        private static delegate* unmanaged<BufferTargetARB, BufferPNameARB, int*, void> _GetBufferParameteriv_fnptr = &GetBufferParameteriv_Lazy;
        public static void GetBufferParameteriv(BufferTargetARB target, BufferPNameARB pname, int* parameters) => _GetBufferParameteriv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetBufferParameteriv_Lazy(BufferTargetARB target, BufferPNameARB pname, int* parameters)
        {
            _GetBufferParameteriv_fnptr = (delegate* unmanaged<BufferTargetARB, BufferPNameARB, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetBufferParameteriv");
            _GetBufferParameteriv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<ClipPlaneName, int*, void> _GetClipPlanex_fnptr = &GetClipPlanex_Lazy;
        public static void GetClipPlanex(ClipPlaneName plane, int* equation) => _GetClipPlanex_fnptr(plane, equation);
        [UnmanagedCallersOnly]
        private static void GetClipPlanex_Lazy(ClipPlaneName plane, int* equation)
        {
            _GetClipPlanex_fnptr = (delegate* unmanaged<ClipPlaneName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetClipPlanex");
            _GetClipPlanex_fnptr(plane, equation);
        }
        
        private static delegate* unmanaged<int, BufferHandle*, void> _GenBuffers_fnptr = &GenBuffers_Lazy;
        public static void GenBuffers(int n, BufferHandle* buffers) => _GenBuffers_fnptr(n, buffers);
        [UnmanagedCallersOnly]
        private static void GenBuffers_Lazy(int n, BufferHandle* buffers)
        {
            _GenBuffers_fnptr = (delegate* unmanaged<int, BufferHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenBuffers");
            _GenBuffers_fnptr(n, buffers);
        }
        
        private static delegate* unmanaged<int, TextureHandle*, void> _GenTextures_fnptr = &GenTextures_Lazy;
        public static void GenTextures(int n, TextureHandle* textures) => _GenTextures_fnptr(n, textures);
        [UnmanagedCallersOnly]
        private static void GenTextures_Lazy(int n, TextureHandle* textures)
        {
            _GenTextures_fnptr = (delegate* unmanaged<int, TextureHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenTextures");
            _GenTextures_fnptr(n, textures);
        }
        
        private static delegate* unmanaged<ErrorCode> _GetError_fnptr = &GetError_Lazy;
        public static ErrorCode GetError() => _GetError_fnptr();
        [UnmanagedCallersOnly]
        private static ErrorCode GetError_Lazy()
        {
            _GetError_fnptr = (delegate* unmanaged<ErrorCode>)GLLoader.BindingsContext.GetProcAddress("glGetError");
            return _GetError_fnptr();
        }
        
        private static delegate* unmanaged<GetPName, int*, void> _GetFixedv_fnptr = &GetFixedv_Lazy;
        public static void GetFixedv(GetPName pname, int* parameters) => _GetFixedv_fnptr(pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetFixedv_Lazy(GetPName pname, int* parameters)
        {
            _GetFixedv_fnptr = (delegate* unmanaged<GetPName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetFixedv");
            _GetFixedv_fnptr(pname, parameters);
        }
        
        private static delegate* unmanaged<GetPName, int*, void> _GetIntegerv_fnptr = &GetIntegerv_Lazy;
        public static void GetIntegerv(GetPName pname, int* data) => _GetIntegerv_fnptr(pname, data);
        [UnmanagedCallersOnly]
        private static void GetIntegerv_Lazy(GetPName pname, int* data)
        {
            _GetIntegerv_fnptr = (delegate* unmanaged<GetPName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetIntegerv");
            _GetIntegerv_fnptr(pname, data);
        }
        
        private static delegate* unmanaged<LightName, LightParameter, int*, void> _GetLightxv_fnptr = &GetLightxv_Lazy;
        public static void GetLightxv(LightName light, LightParameter pname, int* parameters) => _GetLightxv_fnptr(light, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetLightxv_Lazy(LightName light, LightParameter pname, int* parameters)
        {
            _GetLightxv_fnptr = (delegate* unmanaged<LightName, LightParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetLightxv");
            _GetLightxv_fnptr(light, pname, parameters);
        }
        
        private static delegate* unmanaged<MaterialFace, MaterialParameter, int*, void> _GetMaterialxv_fnptr = &GetMaterialxv_Lazy;
        public static void GetMaterialxv(MaterialFace face, MaterialParameter pname, int* parameters) => _GetMaterialxv_fnptr(face, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetMaterialxv_Lazy(MaterialFace face, MaterialParameter pname, int* parameters)
        {
            _GetMaterialxv_fnptr = (delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetMaterialxv");
            _GetMaterialxv_fnptr(face, pname, parameters);
        }
        
        private static delegate* unmanaged<GetPointervPName, void**, void> _GetPointerv_fnptr = &GetPointerv_Lazy;
        public static void GetPointerv(GetPointervPName pname, void** parameters) => _GetPointerv_fnptr(pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetPointerv_Lazy(GetPointervPName pname, void** parameters)
        {
            _GetPointerv_fnptr = (delegate* unmanaged<GetPointervPName, void**, void>)GLLoader.BindingsContext.GetProcAddress("glGetPointerv");
            _GetPointerv_fnptr(pname, parameters);
        }
        
        private static delegate* unmanaged<StringName, byte*> _GetString__fnptr = &GetString__Lazy;
        public static byte* GetString_(StringName name) => _GetString__fnptr(name);
        [UnmanagedCallersOnly]
        private static byte* GetString__Lazy(StringName name)
        {
            _GetString__fnptr = (delegate* unmanaged<StringName, byte*>)GLLoader.BindingsContext.GetProcAddress("glGetString");
            return _GetString__fnptr(name);
        }
        
        private static delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void> _GetTexEnviv_fnptr = &GetTexEnviv_Lazy;
        public static void GetTexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => _GetTexEnviv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexEnviv_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int* parameters)
        {
            _GetTexEnviv_fnptr = (delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexEnviv");
            _GetTexEnviv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void> _GetTexEnvxv_fnptr = &GetTexEnvxv_Lazy;
        public static void GetTexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => _GetTexEnvxv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexEnvxv_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int* parameters)
        {
            _GetTexEnvxv_fnptr = (delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexEnvxv");
            _GetTexEnvxv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void> _GetTexParameteriv_fnptr = &GetTexParameteriv_Lazy;
        public static void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, int* parameters) => _GetTexParameteriv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexParameteriv_Lazy(TextureTarget target, GetTextureParameter pname, int* parameters)
        {
            _GetTexParameteriv_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexParameteriv");
            _GetTexParameteriv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void> _GetTexParameterxv_fnptr = &GetTexParameterxv_Lazy;
        public static void GetTexParameterxv(TextureTarget target, GetTextureParameter pname, int* parameters) => _GetTexParameterxv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void GetTexParameterxv_Lazy(TextureTarget target, GetTextureParameter pname, int* parameters)
        {
            _GetTexParameterxv_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexParameterxv");
            _GetTexParameterxv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<HintTarget, HintMode, void> _Hint_fnptr = &Hint_Lazy;
        public static void Hint(HintTarget target, HintMode mode) => _Hint_fnptr(target, mode);
        [UnmanagedCallersOnly]
        private static void Hint_Lazy(HintTarget target, HintMode mode)
        {
            _Hint_fnptr = (delegate* unmanaged<HintTarget, HintMode, void>)GLLoader.BindingsContext.GetProcAddress("glHint");
            _Hint_fnptr(target, mode);
        }
        
        private static delegate* unmanaged<BufferHandle, byte> _IsBuffer_fnptr = &IsBuffer_Lazy;
        public static byte IsBuffer(BufferHandle buffer) => _IsBuffer_fnptr(buffer);
        [UnmanagedCallersOnly]
        private static byte IsBuffer_Lazy(BufferHandle buffer)
        {
            _IsBuffer_fnptr = (delegate* unmanaged<BufferHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsBuffer");
            return _IsBuffer_fnptr(buffer);
        }
        
        private static delegate* unmanaged<EnableCap, byte> _IsEnabled_fnptr = &IsEnabled_Lazy;
        public static byte IsEnabled(EnableCap cap) => _IsEnabled_fnptr(cap);
        [UnmanagedCallersOnly]
        private static byte IsEnabled_Lazy(EnableCap cap)
        {
            _IsEnabled_fnptr = (delegate* unmanaged<EnableCap, byte>)GLLoader.BindingsContext.GetProcAddress("glIsEnabled");
            return _IsEnabled_fnptr(cap);
        }
        
        private static delegate* unmanaged<TextureHandle, byte> _IsTexture_fnptr = &IsTexture_Lazy;
        public static byte IsTexture(TextureHandle texture) => _IsTexture_fnptr(texture);
        [UnmanagedCallersOnly]
        private static byte IsTexture_Lazy(TextureHandle texture)
        {
            _IsTexture_fnptr = (delegate* unmanaged<TextureHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsTexture");
            return _IsTexture_fnptr(texture);
        }
        
        private static delegate* unmanaged<LightModelParameter, int, void> _LightModelx_fnptr = &LightModelx_Lazy;
        public static void LightModelx(LightModelParameter pname, int param) => _LightModelx_fnptr(pname, param);
        [UnmanagedCallersOnly]
        private static void LightModelx_Lazy(LightModelParameter pname, int param)
        {
            _LightModelx_fnptr = (delegate* unmanaged<LightModelParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glLightModelx");
            _LightModelx_fnptr(pname, param);
        }
        
        private static delegate* unmanaged<LightModelParameter, int*, void> _LightModelxv_fnptr = &LightModelxv_Lazy;
        public static void LightModelxv(LightModelParameter pname, int* param) => _LightModelxv_fnptr(pname, param);
        [UnmanagedCallersOnly]
        private static void LightModelxv_Lazy(LightModelParameter pname, int* param)
        {
            _LightModelxv_fnptr = (delegate* unmanaged<LightModelParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glLightModelxv");
            _LightModelxv_fnptr(pname, param);
        }
        
        private static delegate* unmanaged<LightName, LightParameter, int, void> _Lightx_fnptr = &Lightx_Lazy;
        public static void Lightx(LightName light, LightParameter pname, int param) => _Lightx_fnptr(light, pname, param);
        [UnmanagedCallersOnly]
        private static void Lightx_Lazy(LightName light, LightParameter pname, int param)
        {
            _Lightx_fnptr = (delegate* unmanaged<LightName, LightParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glLightx");
            _Lightx_fnptr(light, pname, param);
        }
        
        private static delegate* unmanaged<LightName, LightParameter, int*, void> _Lightxv_fnptr = &Lightxv_Lazy;
        public static void Lightxv(LightName light, LightParameter pname, int* parameters) => _Lightxv_fnptr(light, pname, parameters);
        [UnmanagedCallersOnly]
        private static void Lightxv_Lazy(LightName light, LightParameter pname, int* parameters)
        {
            _Lightxv_fnptr = (delegate* unmanaged<LightName, LightParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glLightxv");
            _Lightxv_fnptr(light, pname, parameters);
        }
        
        private static delegate* unmanaged<int, void> _LineWidthx_fnptr = &LineWidthx_Lazy;
        public static void LineWidthx(int width) => _LineWidthx_fnptr(width);
        [UnmanagedCallersOnly]
        private static void LineWidthx_Lazy(int width)
        {
            _LineWidthx_fnptr = (delegate* unmanaged<int, void>)GLLoader.BindingsContext.GetProcAddress("glLineWidthx");
            _LineWidthx_fnptr(width);
        }
        
        private static delegate* unmanaged<void> _LoadIdentity_fnptr = &LoadIdentity_Lazy;
        public static void LoadIdentity() => _LoadIdentity_fnptr();
        [UnmanagedCallersOnly]
        private static void LoadIdentity_Lazy()
        {
            _LoadIdentity_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glLoadIdentity");
            _LoadIdentity_fnptr();
        }
        
        private static delegate* unmanaged<int*, void> _LoadMatrixx_fnptr = &LoadMatrixx_Lazy;
        public static void LoadMatrixx(int* m) => _LoadMatrixx_fnptr(m);
        [UnmanagedCallersOnly]
        private static void LoadMatrixx_Lazy(int* m)
        {
            _LoadMatrixx_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glLoadMatrixx");
            _LoadMatrixx_fnptr(m);
        }
        
        private static delegate* unmanaged<LogicOp, void> _LogicOp_fnptr = &LogicOp_Lazy;
        public static void LogicOp(LogicOp opcode) => _LogicOp_fnptr(opcode);
        [UnmanagedCallersOnly]
        private static void LogicOp_Lazy(LogicOp opcode)
        {
            _LogicOp_fnptr = (delegate* unmanaged<LogicOp, void>)GLLoader.BindingsContext.GetProcAddress("glLogicOp");
            _LogicOp_fnptr(opcode);
        }
        
        private static delegate* unmanaged<MaterialFace, MaterialParameter, int, void> _Materialx_fnptr = &Materialx_Lazy;
        public static void Materialx(MaterialFace face, MaterialParameter pname, int param) => _Materialx_fnptr(face, pname, param);
        [UnmanagedCallersOnly]
        private static void Materialx_Lazy(MaterialFace face, MaterialParameter pname, int param)
        {
            _Materialx_fnptr = (delegate* unmanaged<MaterialFace, MaterialParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glMaterialx");
            _Materialx_fnptr(face, pname, param);
        }
        
        private static delegate* unmanaged<MaterialFace, MaterialParameter, int*, void> _Materialxv_fnptr = &Materialxv_Lazy;
        public static void Materialxv(MaterialFace face, MaterialParameter pname, int* param) => _Materialxv_fnptr(face, pname, param);
        [UnmanagedCallersOnly]
        private static void Materialxv_Lazy(MaterialFace face, MaterialParameter pname, int* param)
        {
            _Materialxv_fnptr = (delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glMaterialxv");
            _Materialxv_fnptr(face, pname, param);
        }
        
        private static delegate* unmanaged<MatrixMode, void> _MatrixMode_fnptr = &MatrixMode_Lazy;
        public static void MatrixMode(MatrixMode mode) => _MatrixMode_fnptr(mode);
        [UnmanagedCallersOnly]
        private static void MatrixMode_Lazy(MatrixMode mode)
        {
            _MatrixMode_fnptr = (delegate* unmanaged<MatrixMode, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixMode");
            _MatrixMode_fnptr(mode);
        }
        
        private static delegate* unmanaged<int*, void> _MultMatrixx_fnptr = &MultMatrixx_Lazy;
        public static void MultMatrixx(int* m) => _MultMatrixx_fnptr(m);
        [UnmanagedCallersOnly]
        private static void MultMatrixx_Lazy(int* m)
        {
            _MultMatrixx_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glMultMatrixx");
            _MultMatrixx_fnptr(m);
        }
        
        private static delegate* unmanaged<TextureUnit, int, int, int, int, void> _MultiTexCoord4x_fnptr = &MultiTexCoord4x_Lazy;
        public static void MultiTexCoord4x(TextureUnit texture, int s, int t, int r, int q) => _MultiTexCoord4x_fnptr(texture, s, t, r, q);
        [UnmanagedCallersOnly]
        private static void MultiTexCoord4x_Lazy(TextureUnit texture, int s, int t, int r, int q)
        {
            _MultiTexCoord4x_fnptr = (delegate* unmanaged<TextureUnit, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord4x");
            _MultiTexCoord4x_fnptr(texture, s, t, r, q);
        }
        
        private static delegate* unmanaged<int, int, int, void> _Normal3x_fnptr = &Normal3x_Lazy;
        public static void Normal3x(int nx, int ny, int nz) => _Normal3x_fnptr(nx, ny, nz);
        [UnmanagedCallersOnly]
        private static void Normal3x_Lazy(int nx, int ny, int nz)
        {
            _Normal3x_fnptr = (delegate* unmanaged<int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glNormal3x");
            _Normal3x_fnptr(nx, ny, nz);
        }
        
        private static delegate* unmanaged<NormalPointerType, int, void*, void> _NormalPointer_fnptr = &NormalPointer_Lazy;
        public static void NormalPointer(NormalPointerType type, int stride, void* pointer) => _NormalPointer_fnptr(type, stride, pointer);
        [UnmanagedCallersOnly]
        private static void NormalPointer_Lazy(NormalPointerType type, int stride, void* pointer)
        {
            _NormalPointer_fnptr = (delegate* unmanaged<NormalPointerType, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glNormalPointer");
            _NormalPointer_fnptr(type, stride, pointer);
        }
        
        private static delegate* unmanaged<int, int, int, int, int, int, void> _Orthox_fnptr = &Orthox_Lazy;
        public static void Orthox(int l, int r, int b, int t, int n, int f) => _Orthox_fnptr(l, r, b, t, n, f);
        [UnmanagedCallersOnly]
        private static void Orthox_Lazy(int l, int r, int b, int t, int n, int f)
        {
            _Orthox_fnptr = (delegate* unmanaged<int, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glOrthox");
            _Orthox_fnptr(l, r, b, t, n, f);
        }
        
        private static delegate* unmanaged<PixelStoreParameter, int, void> _PixelStorei_fnptr = &PixelStorei_Lazy;
        public static void PixelStorei(PixelStoreParameter pname, int param) => _PixelStorei_fnptr(pname, param);
        [UnmanagedCallersOnly]
        private static void PixelStorei_Lazy(PixelStoreParameter pname, int param)
        {
            _PixelStorei_fnptr = (delegate* unmanaged<PixelStoreParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glPixelStorei");
            _PixelStorei_fnptr(pname, param);
        }
        
        private static delegate* unmanaged<PointParameterNameARB, int, void> _PointParameterx_fnptr = &PointParameterx_Lazy;
        public static void PointParameterx(PointParameterNameARB pname, int param) => _PointParameterx_fnptr(pname, param);
        [UnmanagedCallersOnly]
        private static void PointParameterx_Lazy(PointParameterNameARB pname, int param)
        {
            _PointParameterx_fnptr = (delegate* unmanaged<PointParameterNameARB, int, void>)GLLoader.BindingsContext.GetProcAddress("glPointParameterx");
            _PointParameterx_fnptr(pname, param);
        }
        
        private static delegate* unmanaged<PointParameterNameARB, int*, void> _PointParameterxv_fnptr = &PointParameterxv_Lazy;
        public static void PointParameterxv(PointParameterNameARB pname, int* parameters) => _PointParameterxv_fnptr(pname, parameters);
        [UnmanagedCallersOnly]
        private static void PointParameterxv_Lazy(PointParameterNameARB pname, int* parameters)
        {
            _PointParameterxv_fnptr = (delegate* unmanaged<PointParameterNameARB, int*, void>)GLLoader.BindingsContext.GetProcAddress("glPointParameterxv");
            _PointParameterxv_fnptr(pname, parameters);
        }
        
        private static delegate* unmanaged<int, void> _PointSizex_fnptr = &PointSizex_Lazy;
        public static void PointSizex(int size) => _PointSizex_fnptr(size);
        [UnmanagedCallersOnly]
        private static void PointSizex_Lazy(int size)
        {
            _PointSizex_fnptr = (delegate* unmanaged<int, void>)GLLoader.BindingsContext.GetProcAddress("glPointSizex");
            _PointSizex_fnptr(size);
        }
        
        private static delegate* unmanaged<int, int, void> _PolygonOffsetx_fnptr = &PolygonOffsetx_Lazy;
        public static void PolygonOffsetx(int factor, int units) => _PolygonOffsetx_fnptr(factor, units);
        [UnmanagedCallersOnly]
        private static void PolygonOffsetx_Lazy(int factor, int units)
        {
            _PolygonOffsetx_fnptr = (delegate* unmanaged<int, int, void>)GLLoader.BindingsContext.GetProcAddress("glPolygonOffsetx");
            _PolygonOffsetx_fnptr(factor, units);
        }
        
        private static delegate* unmanaged<void> _PopMatrix_fnptr = &PopMatrix_Lazy;
        public static void PopMatrix() => _PopMatrix_fnptr();
        [UnmanagedCallersOnly]
        private static void PopMatrix_Lazy()
        {
            _PopMatrix_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glPopMatrix");
            _PopMatrix_fnptr();
        }
        
        private static delegate* unmanaged<void> _PushMatrix_fnptr = &PushMatrix_Lazy;
        public static void PushMatrix() => _PushMatrix_fnptr();
        [UnmanagedCallersOnly]
        private static void PushMatrix_Lazy()
        {
            _PushMatrix_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glPushMatrix");
            _PushMatrix_fnptr();
        }
        
        private static delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, void*, void> _ReadPixels_fnptr = &ReadPixels_Lazy;
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels) => _ReadPixels_fnptr(x, y, width, height, format, type, pixels);
        [UnmanagedCallersOnly]
        private static void ReadPixels_Lazy(int x, int y, int width, int height, PixelFormat format, PixelType type, void* pixels)
        {
            _ReadPixels_fnptr = (delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glReadPixels");
            _ReadPixels_fnptr(x, y, width, height, format, type, pixels);
        }
        
        private static delegate* unmanaged<int, int, int, int, void> _Rotatex_fnptr = &Rotatex_Lazy;
        public static void Rotatex(int angle, int x, int y, int z) => _Rotatex_fnptr(angle, x, y, z);
        [UnmanagedCallersOnly]
        private static void Rotatex_Lazy(int angle, int x, int y, int z)
        {
            _Rotatex_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRotatex");
            _Rotatex_fnptr(angle, x, y, z);
        }
        
        private static delegate* unmanaged<float, byte, void> _SampleCoverage_fnptr = &SampleCoverage_Lazy;
        public static void SampleCoverage(float value, byte invert) => _SampleCoverage_fnptr(value, invert);
        [UnmanagedCallersOnly]
        private static void SampleCoverage_Lazy(float value, byte invert)
        {
            _SampleCoverage_fnptr = (delegate* unmanaged<float, byte, void>)GLLoader.BindingsContext.GetProcAddress("glSampleCoverage");
            _SampleCoverage_fnptr(value, invert);
        }
        
        private static delegate* unmanaged<int, byte, void> _SampleCoveragex_fnptr = &SampleCoveragex_Lazy;
        public static void SampleCoveragex(int value, byte invert) => _SampleCoveragex_fnptr(value, invert);
        [UnmanagedCallersOnly]
        private static void SampleCoveragex_Lazy(int value, byte invert)
        {
            _SampleCoveragex_fnptr = (delegate* unmanaged<int, byte, void>)GLLoader.BindingsContext.GetProcAddress("glSampleCoveragex");
            _SampleCoveragex_fnptr(value, invert);
        }
        
        private static delegate* unmanaged<int, int, int, void> _Scalex_fnptr = &Scalex_Lazy;
        public static void Scalex(int x, int y, int z) => _Scalex_fnptr(x, y, z);
        [UnmanagedCallersOnly]
        private static void Scalex_Lazy(int x, int y, int z)
        {
            _Scalex_fnptr = (delegate* unmanaged<int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glScalex");
            _Scalex_fnptr(x, y, z);
        }
        
        private static delegate* unmanaged<int, int, int, int, void> _Scissor_fnptr = &Scissor_Lazy;
        public static void Scissor(int x, int y, int width, int height) => _Scissor_fnptr(x, y, width, height);
        [UnmanagedCallersOnly]
        private static void Scissor_Lazy(int x, int y, int width, int height)
        {
            _Scissor_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glScissor");
            _Scissor_fnptr(x, y, width, height);
        }
        
        private static delegate* unmanaged<ShadingModel, void> _ShadeModel_fnptr = &ShadeModel_Lazy;
        public static void ShadeModel(ShadingModel mode) => _ShadeModel_fnptr(mode);
        [UnmanagedCallersOnly]
        private static void ShadeModel_Lazy(ShadingModel mode)
        {
            _ShadeModel_fnptr = (delegate* unmanaged<ShadingModel, void>)GLLoader.BindingsContext.GetProcAddress("glShadeModel");
            _ShadeModel_fnptr(mode);
        }
        
        private static delegate* unmanaged<StencilFunction, int, uint, void> _StencilFunc_fnptr = &StencilFunc_Lazy;
        public static void StencilFunc(StencilFunction func, int reference, uint mask) => _StencilFunc_fnptr(func, reference, mask);
        [UnmanagedCallersOnly]
        private static void StencilFunc_Lazy(StencilFunction func, int reference, uint mask)
        {
            _StencilFunc_fnptr = (delegate* unmanaged<StencilFunction, int, uint, void>)GLLoader.BindingsContext.GetProcAddress("glStencilFunc");
            _StencilFunc_fnptr(func, reference, mask);
        }
        
        private static delegate* unmanaged<uint, void> _StencilMask_fnptr = &StencilMask_Lazy;
        public static void StencilMask(uint mask) => _StencilMask_fnptr(mask);
        [UnmanagedCallersOnly]
        private static void StencilMask_Lazy(uint mask)
        {
            _StencilMask_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glStencilMask");
            _StencilMask_fnptr(mask);
        }
        
        private static delegate* unmanaged<StencilOp, StencilOp, StencilOp, void> _StencilOp_fnptr = &StencilOp_Lazy;
        public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass) => _StencilOp_fnptr(fail, zfail, zpass);
        [UnmanagedCallersOnly]
        private static void StencilOp_Lazy(StencilOp fail, StencilOp zfail, StencilOp zpass)
        {
            _StencilOp_fnptr = (delegate* unmanaged<StencilOp, StencilOp, StencilOp, void>)GLLoader.BindingsContext.GetProcAddress("glStencilOp");
            _StencilOp_fnptr(fail, zfail, zpass);
        }
        
        private static delegate* unmanaged<int, TexCoordPointerType, int, void*, void> _TexCoordPointer_fnptr = &TexCoordPointer_Lazy;
        public static void TexCoordPointer(int size, TexCoordPointerType type, int stride, void* pointer) => _TexCoordPointer_fnptr(size, type, stride, pointer);
        [UnmanagedCallersOnly]
        private static void TexCoordPointer_Lazy(int size, TexCoordPointerType type, int stride, void* pointer)
        {
            _TexCoordPointer_fnptr = (delegate* unmanaged<int, TexCoordPointerType, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoordPointer");
            _TexCoordPointer_fnptr(size, type, stride, pointer);
        }
        
        private static delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int, void> _TexEnvi_fnptr = &TexEnvi_Lazy;
        public static void TexEnvi(TextureEnvTarget target, TextureEnvParameter pname, int param) => _TexEnvi_fnptr(target, pname, param);
        [UnmanagedCallersOnly]
        private static void TexEnvi_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int param)
        {
            _TexEnvi_fnptr = (delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexEnvi");
            _TexEnvi_fnptr(target, pname, param);
        }
        
        private static delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int, void> _TexEnvx_fnptr = &TexEnvx_Lazy;
        public static void TexEnvx(TextureEnvTarget target, TextureEnvParameter pname, int param) => _TexEnvx_fnptr(target, pname, param);
        [UnmanagedCallersOnly]
        private static void TexEnvx_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int param)
        {
            _TexEnvx_fnptr = (delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexEnvx");
            _TexEnvx_fnptr(target, pname, param);
        }
        
        private static delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void> _TexEnviv_fnptr = &TexEnviv_Lazy;
        public static void TexEnviv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => _TexEnviv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexEnviv_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int* parameters)
        {
            _TexEnviv_fnptr = (delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexEnviv");
            _TexEnviv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void> _TexEnvxv_fnptr = &TexEnvxv_Lazy;
        public static void TexEnvxv(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => _TexEnvxv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexEnvxv_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int* parameters)
        {
            _TexEnvxv_fnptr = (delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexEnvxv");
            _TexEnvxv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void> _TexImage2D_fnptr = &TexImage2D_Lazy;
        public static void TexImage2D(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels) => _TexImage2D_fnptr(target, level, internalformat, width, height, border, format, type, pixels);
        [UnmanagedCallersOnly]
        private static void TexImage2D_Lazy(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, void* pixels)
        {
            _TexImage2D_fnptr = (delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glTexImage2D");
            _TexImage2D_fnptr(target, level, internalformat, width, height, border, format, type, pixels);
        }
        
        private static delegate* unmanaged<TextureTarget, TextureParameterName, int, void> _TexParameteri_fnptr = &TexParameteri_Lazy;
        public static void TexParameteri(TextureTarget target, TextureParameterName pname, int param) => _TexParameteri_fnptr(target, pname, param);
        [UnmanagedCallersOnly]
        private static void TexParameteri_Lazy(TextureTarget target, TextureParameterName pname, int param)
        {
            _TexParameteri_fnptr = (delegate* unmanaged<TextureTarget, TextureParameterName, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameteri");
            _TexParameteri_fnptr(target, pname, param);
        }
        
        private static delegate* unmanaged<TextureTarget, GetTextureParameter, int, void> _TexParameterx_fnptr = &TexParameterx_Lazy;
        public static void TexParameterx(TextureTarget target, GetTextureParameter pname, int param) => _TexParameterx_fnptr(target, pname, param);
        [UnmanagedCallersOnly]
        private static void TexParameterx_Lazy(TextureTarget target, GetTextureParameter pname, int param)
        {
            _TexParameterx_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameterx");
            _TexParameterx_fnptr(target, pname, param);
        }
        
        private static delegate* unmanaged<TextureTarget, TextureParameterName, int*, void> _TexParameteriv_fnptr = &TexParameteriv_Lazy;
        public static void TexParameteriv(TextureTarget target, TextureParameterName pname, int* parameters) => _TexParameteriv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexParameteriv_Lazy(TextureTarget target, TextureParameterName pname, int* parameters)
        {
            _TexParameteriv_fnptr = (delegate* unmanaged<TextureTarget, TextureParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameteriv");
            _TexParameteriv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void> _TexParameterxv_fnptr = &TexParameterxv_Lazy;
        public static void TexParameterxv(TextureTarget target, GetTextureParameter pname, int* parameters) => _TexParameterxv_fnptr(target, pname, parameters);
        [UnmanagedCallersOnly]
        private static void TexParameterxv_Lazy(TextureTarget target, GetTextureParameter pname, int* parameters)
        {
            _TexParameterxv_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameterxv");
            _TexParameterxv_fnptr(target, pname, parameters);
        }
        
        private static delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void> _TexSubImage2D_fnptr = &TexSubImage2D_Lazy;
        public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels) => _TexSubImage2D_fnptr(target, level, xoffset, yoffset, width, height, format, type, pixels);
        [UnmanagedCallersOnly]
        private static void TexSubImage2D_Lazy(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, void* pixels)
        {
            _TexSubImage2D_fnptr = (delegate* unmanaged<TextureTarget, int, int, int, int, int, PixelFormat, PixelType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glTexSubImage2D");
            _TexSubImage2D_fnptr(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }
        
        private static delegate* unmanaged<int, int, int, void> _Translatex_fnptr = &Translatex_Lazy;
        public static void Translatex(int x, int y, int z) => _Translatex_fnptr(x, y, z);
        [UnmanagedCallersOnly]
        private static void Translatex_Lazy(int x, int y, int z)
        {
            _Translatex_fnptr = (delegate* unmanaged<int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glTranslatex");
            _Translatex_fnptr(x, y, z);
        }
        
        private static delegate* unmanaged<int, VertexPointerType, int, void*, void> _VertexPointer_fnptr = &VertexPointer_Lazy;
        public static void VertexPointer(int size, VertexPointerType type, int stride, void* pointer) => _VertexPointer_fnptr(size, type, stride, pointer);
        [UnmanagedCallersOnly]
        private static void VertexPointer_Lazy(int size, VertexPointerType type, int stride, void* pointer)
        {
            _VertexPointer_fnptr = (delegate* unmanaged<int, VertexPointerType, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glVertexPointer");
            _VertexPointer_fnptr(size, type, stride, pointer);
        }
        
        private static delegate* unmanaged<int, int, int, int, void> _Viewport_fnptr = &Viewport_Lazy;
        public static void Viewport(int x, int y, int width, int height) => _Viewport_fnptr(x, y, width, height);
        [UnmanagedCallersOnly]
        private static void Viewport_Lazy(int x, int y, int width, int height)
        {
            _Viewport_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glViewport");
            _Viewport_fnptr(x, y, width, height);
        }
        
        public static unsafe partial class APPLE
        {
            private static delegate* unmanaged<uint, uint, int, int, void> _CopyTextureLevelsAPPLE_fnptr = &CopyTextureLevelsAPPLE_Lazy;
            public static void CopyTextureLevelsAPPLE(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount) => _CopyTextureLevelsAPPLE_fnptr(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
            [UnmanagedCallersOnly]
            private static void CopyTextureLevelsAPPLE_Lazy(uint destinationTexture, uint sourceTexture, int sourceBaseLevel, int sourceLevelCount)
            {
                _CopyTextureLevelsAPPLE_fnptr = (delegate* unmanaged<uint, uint, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glCopyTextureLevelsAPPLE");
                _CopyTextureLevelsAPPLE_fnptr(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
            }
            
            private static delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void> _RenderbufferStorageMultisampleAPPLE_fnptr = &RenderbufferStorageMultisampleAPPLE_Lazy;
            public static void RenderbufferStorageMultisampleAPPLE(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => _RenderbufferStorageMultisampleAPPLE_fnptr(target, samples, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void RenderbufferStorageMultisampleAPPLE_Lazy(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
            {
                _RenderbufferStorageMultisampleAPPLE_fnptr = (delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorageMultisampleAPPLE");
                _RenderbufferStorageMultisampleAPPLE_fnptr(target, samples, internalformat, width, height);
            }
            
            private static delegate* unmanaged<void> _ResolveMultisampleFramebufferAPPLE_fnptr = &ResolveMultisampleFramebufferAPPLE_Lazy;
            public static void ResolveMultisampleFramebufferAPPLE() => _ResolveMultisampleFramebufferAPPLE_fnptr();
            [UnmanagedCallersOnly]
            private static void ResolveMultisampleFramebufferAPPLE_Lazy()
            {
                _ResolveMultisampleFramebufferAPPLE_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glResolveMultisampleFramebufferAPPLE");
                _ResolveMultisampleFramebufferAPPLE_fnptr();
            }
            
            private static delegate* unmanaged<SyncCondition, SyncBehaviorFlags, IntPtr> _FenceSyncAPPLE_fnptr = &FenceSyncAPPLE_Lazy;
            public static GLSync FenceSyncAPPLE(SyncCondition condition, SyncBehaviorFlags flags) => (GLSync) _FenceSyncAPPLE_fnptr(condition, flags);
            [UnmanagedCallersOnly]
            private static IntPtr FenceSyncAPPLE_Lazy(SyncCondition condition, SyncBehaviorFlags flags)
            {
                _FenceSyncAPPLE_fnptr = (delegate* unmanaged<SyncCondition, SyncBehaviorFlags, IntPtr>)GLLoader.BindingsContext.GetProcAddress("glFenceSyncAPPLE");
                return _FenceSyncAPPLE_fnptr(condition, flags);
            }
            
            private static delegate* unmanaged<GLSync, byte> _IsSyncAPPLE_fnptr = &IsSyncAPPLE_Lazy;
            public static byte IsSyncAPPLE(GLSync sync) => _IsSyncAPPLE_fnptr(sync);
            [UnmanagedCallersOnly]
            private static byte IsSyncAPPLE_Lazy(GLSync sync)
            {
                _IsSyncAPPLE_fnptr = (delegate* unmanaged<GLSync, byte>)GLLoader.BindingsContext.GetProcAddress("glIsSyncAPPLE");
                return _IsSyncAPPLE_fnptr(sync);
            }
            
            private static delegate* unmanaged<GLSync, void> _DeleteSyncAPPLE_fnptr = &DeleteSyncAPPLE_Lazy;
            public static void DeleteSyncAPPLE(GLSync sync) => _DeleteSyncAPPLE_fnptr(sync);
            [UnmanagedCallersOnly]
            private static void DeleteSyncAPPLE_Lazy(GLSync sync)
            {
                _DeleteSyncAPPLE_fnptr = (delegate* unmanaged<GLSync, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteSyncAPPLE");
                _DeleteSyncAPPLE_fnptr(sync);
            }
            
            private static delegate* unmanaged<GLSync, SyncObjectMask, ulong, SyncStatus> _ClientWaitSyncAPPLE_fnptr = &ClientWaitSyncAPPLE_Lazy;
            public static SyncStatus ClientWaitSyncAPPLE(GLSync sync, SyncObjectMask flags, ulong timeout) => _ClientWaitSyncAPPLE_fnptr(sync, flags, timeout);
            [UnmanagedCallersOnly]
            private static SyncStatus ClientWaitSyncAPPLE_Lazy(GLSync sync, SyncObjectMask flags, ulong timeout)
            {
                _ClientWaitSyncAPPLE_fnptr = (delegate* unmanaged<GLSync, SyncObjectMask, ulong, SyncStatus>)GLLoader.BindingsContext.GetProcAddress("glClientWaitSyncAPPLE");
                return _ClientWaitSyncAPPLE_fnptr(sync, flags, timeout);
            }
            
            private static delegate* unmanaged<GLSync, SyncBehaviorFlags, ulong, void> _WaitSyncAPPLE_fnptr = &WaitSyncAPPLE_Lazy;
            public static void WaitSyncAPPLE(GLSync sync, SyncBehaviorFlags flags, ulong timeout) => _WaitSyncAPPLE_fnptr(sync, flags, timeout);
            [UnmanagedCallersOnly]
            private static void WaitSyncAPPLE_Lazy(GLSync sync, SyncBehaviorFlags flags, ulong timeout)
            {
                _WaitSyncAPPLE_fnptr = (delegate* unmanaged<GLSync, SyncBehaviorFlags, ulong, void>)GLLoader.BindingsContext.GetProcAddress("glWaitSyncAPPLE");
                _WaitSyncAPPLE_fnptr(sync, flags, timeout);
            }
            
            private static delegate* unmanaged<GetPName, long*, void> _GetInteger64vAPPLE_fnptr = &GetInteger64vAPPLE_Lazy;
            public static void GetInteger64vAPPLE(GetPName pname, long* parameters) => _GetInteger64vAPPLE_fnptr(pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetInteger64vAPPLE_Lazy(GetPName pname, long* parameters)
            {
                _GetInteger64vAPPLE_fnptr = (delegate* unmanaged<GetPName, long*, void>)GLLoader.BindingsContext.GetProcAddress("glGetInteger64vAPPLE");
                _GetInteger64vAPPLE_fnptr(pname, parameters);
            }
            
            private static delegate* unmanaged<GLSync, SyncParameterName, int, int*, int*, void> _GetSyncivAPPLE_fnptr = &GetSyncivAPPLE_Lazy;
            public static void GetSyncivAPPLE(GLSync sync, SyncParameterName pname, int count, int* length, int* values) => _GetSyncivAPPLE_fnptr(sync, pname, count, length, values);
            [UnmanagedCallersOnly]
            private static void GetSyncivAPPLE_Lazy(GLSync sync, SyncParameterName pname, int count, int* length, int* values)
            {
                _GetSyncivAPPLE_fnptr = (delegate* unmanaged<GLSync, SyncParameterName, int, int*, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetSyncivAPPLE");
                _GetSyncivAPPLE_fnptr(sync, pname, count, length, values);
            }
            
        }
        public static unsafe partial class EXT
        {
            private static delegate* unmanaged<BlendEquationModeEXT, void> _BlendEquationEXT_fnptr = &BlendEquationEXT_Lazy;
            public static void BlendEquationEXT(BlendEquationModeEXT mode) => _BlendEquationEXT_fnptr(mode);
            [UnmanagedCallersOnly]
            private static void BlendEquationEXT_Lazy(BlendEquationModeEXT mode)
            {
                _BlendEquationEXT_fnptr = (delegate* unmanaged<BlendEquationModeEXT, void>)GLLoader.BindingsContext.GetProcAddress("glBlendEquationEXT");
                _BlendEquationEXT_fnptr(mode);
            }
            
            private static delegate* unmanaged<int, byte*, void> _InsertEventMarkerEXT_fnptr = &InsertEventMarkerEXT_Lazy;
            public static void InsertEventMarkerEXT(int length, byte* marker) => _InsertEventMarkerEXT_fnptr(length, marker);
            [UnmanagedCallersOnly]
            private static void InsertEventMarkerEXT_Lazy(int length, byte* marker)
            {
                _InsertEventMarkerEXT_fnptr = (delegate* unmanaged<int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glInsertEventMarkerEXT");
                _InsertEventMarkerEXT_fnptr(length, marker);
            }
            
            private static delegate* unmanaged<int, byte*, void> _PushGroupMarkerEXT_fnptr = &PushGroupMarkerEXT_Lazy;
            public static void PushGroupMarkerEXT(int length, byte* marker) => _PushGroupMarkerEXT_fnptr(length, marker);
            [UnmanagedCallersOnly]
            private static void PushGroupMarkerEXT_Lazy(int length, byte* marker)
            {
                _PushGroupMarkerEXT_fnptr = (delegate* unmanaged<int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glPushGroupMarkerEXT");
                _PushGroupMarkerEXT_fnptr(length, marker);
            }
            
            private static delegate* unmanaged<void> _PopGroupMarkerEXT_fnptr = &PopGroupMarkerEXT_Lazy;
            public static void PopGroupMarkerEXT() => _PopGroupMarkerEXT_fnptr();
            [UnmanagedCallersOnly]
            private static void PopGroupMarkerEXT_Lazy()
            {
                _PopGroupMarkerEXT_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glPopGroupMarkerEXT");
                _PopGroupMarkerEXT_fnptr();
            }
            
            private static delegate* unmanaged<FramebufferTarget, int, InvalidateFramebufferAttachment*, void> _DiscardFramebufferEXT_fnptr = &DiscardFramebufferEXT_Lazy;
            public static void DiscardFramebufferEXT(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments) => _DiscardFramebufferEXT_fnptr(target, numAttachments, attachments);
            [UnmanagedCallersOnly]
            private static void DiscardFramebufferEXT_Lazy(FramebufferTarget target, int numAttachments, InvalidateFramebufferAttachment* attachments)
            {
                _DiscardFramebufferEXT_fnptr = (delegate* unmanaged<FramebufferTarget, int, InvalidateFramebufferAttachment*, void>)GLLoader.BindingsContext.GetProcAddress("glDiscardFramebufferEXT");
                _DiscardFramebufferEXT_fnptr(target, numAttachments, attachments);
            }
            
            private static delegate* unmanaged<BufferTargetARB, IntPtr, nint, MapBufferAccessMask, void*> _MapBufferRangeEXT_fnptr = &MapBufferRangeEXT_Lazy;
            public static void* MapBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access) => _MapBufferRangeEXT_fnptr(target, offset, length, access);
            [UnmanagedCallersOnly]
            private static void* MapBufferRangeEXT_Lazy(BufferTargetARB target, IntPtr offset, nint length, MapBufferAccessMask access)
            {
                _MapBufferRangeEXT_fnptr = (delegate* unmanaged<BufferTargetARB, IntPtr, nint, MapBufferAccessMask, void*>)GLLoader.BindingsContext.GetProcAddress("glMapBufferRangeEXT");
                return _MapBufferRangeEXT_fnptr(target, offset, length, access);
            }
            
            private static delegate* unmanaged<BufferTargetARB, IntPtr, nint, void> _FlushMappedBufferRangeEXT_fnptr = &FlushMappedBufferRangeEXT_Lazy;
            public static void FlushMappedBufferRangeEXT(BufferTargetARB target, IntPtr offset, nint length) => _FlushMappedBufferRangeEXT_fnptr(target, offset, length);
            [UnmanagedCallersOnly]
            private static void FlushMappedBufferRangeEXT_Lazy(BufferTargetARB target, IntPtr offset, nint length)
            {
                _FlushMappedBufferRangeEXT_fnptr = (delegate* unmanaged<BufferTargetARB, IntPtr, nint, void>)GLLoader.BindingsContext.GetProcAddress("glFlushMappedBufferRangeEXT");
                _FlushMappedBufferRangeEXT_fnptr(target, offset, length);
            }
            
            private static delegate* unmanaged<PrimitiveType, int*, int*, int, void> _MultiDrawArraysEXT_fnptr = &MultiDrawArraysEXT_Lazy;
            public static void MultiDrawArraysEXT(PrimitiveType mode, int* first, int* count, int primcount) => _MultiDrawArraysEXT_fnptr(mode, first, count, primcount);
            [UnmanagedCallersOnly]
            private static void MultiDrawArraysEXT_Lazy(PrimitiveType mode, int* first, int* count, int primcount)
            {
                _MultiDrawArraysEXT_fnptr = (delegate* unmanaged<PrimitiveType, int*, int*, int, void>)GLLoader.BindingsContext.GetProcAddress("glMultiDrawArraysEXT");
                _MultiDrawArraysEXT_fnptr(mode, first, count, primcount);
            }
            
            private static delegate* unmanaged<PrimitiveType, int*, DrawElementsType, void**, int, void> _MultiDrawElementsEXT_fnptr = &MultiDrawElementsEXT_Lazy;
            public static void MultiDrawElementsEXT(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int primcount) => _MultiDrawElementsEXT_fnptr(mode, count, type, indices, primcount);
            [UnmanagedCallersOnly]
            private static void MultiDrawElementsEXT_Lazy(PrimitiveType mode, int* count, DrawElementsType type, void** indices, int primcount)
            {
                _MultiDrawElementsEXT_fnptr = (delegate* unmanaged<PrimitiveType, int*, DrawElementsType, void**, int, void>)GLLoader.BindingsContext.GetProcAddress("glMultiDrawElementsEXT");
                _MultiDrawElementsEXT_fnptr(mode, count, type, indices, primcount);
            }
            
            private static delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void> _RenderbufferStorageMultisampleEXT_fnptr = &RenderbufferStorageMultisampleEXT_Lazy;
            public static void RenderbufferStorageMultisampleEXT(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => _RenderbufferStorageMultisampleEXT_fnptr(target, samples, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void RenderbufferStorageMultisampleEXT_Lazy(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
            {
                _RenderbufferStorageMultisampleEXT_fnptr = (delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorageMultisampleEXT");
                _RenderbufferStorageMultisampleEXT_fnptr(target, samples, internalformat, width, height);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void> _FramebufferTexture2DMultisampleEXT_fnptr = &FramebufferTexture2DMultisampleEXT_Lazy;
            public static void FramebufferTexture2DMultisampleEXT(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples) => _FramebufferTexture2DMultisampleEXT_fnptr(target, attachment, textarget, texture, level, samples);
            [UnmanagedCallersOnly]
            private static void FramebufferTexture2DMultisampleEXT_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples)
            {
                _FramebufferTexture2DMultisampleEXT_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferTexture2DMultisampleEXT");
                _FramebufferTexture2DMultisampleEXT_fnptr(target, attachment, textarget, texture, level, samples);
            }
            
            private static delegate* unmanaged<GraphicsResetStatus> _GetGraphicsResetStatusEXT_fnptr = &GetGraphicsResetStatusEXT_Lazy;
            public static GraphicsResetStatus GetGraphicsResetStatusEXT() => _GetGraphicsResetStatusEXT_fnptr();
            [UnmanagedCallersOnly]
            private static GraphicsResetStatus GetGraphicsResetStatusEXT_Lazy()
            {
                _GetGraphicsResetStatusEXT_fnptr = (delegate* unmanaged<GraphicsResetStatus>)GLLoader.BindingsContext.GetProcAddress("glGetGraphicsResetStatusEXT");
                return _GetGraphicsResetStatusEXT_fnptr();
            }
            
            private static delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, int, void*, void> _ReadnPixelsEXT_fnptr = &ReadnPixelsEXT_Lazy;
            public static void ReadnPixelsEXT(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data) => _ReadnPixelsEXT_fnptr(x, y, width, height, format, type, bufSize, data);
            [UnmanagedCallersOnly]
            private static void ReadnPixelsEXT_Lazy(int x, int y, int width, int height, PixelFormat format, PixelType type, int bufSize, void* data)
            {
                _ReadnPixelsEXT_fnptr = (delegate* unmanaged<int, int, int, int, PixelFormat, PixelType, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glReadnPixelsEXT");
                _ReadnPixelsEXT_fnptr(x, y, width, height, format, type, bufSize, data);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, float*, void> _GetnUniformfvEXT_fnptr = &GetnUniformfvEXT_Lazy;
            public static void GetnUniformfvEXT(ProgramHandle program, int location, int bufSize, float* parameters) => _GetnUniformfvEXT_fnptr(program, location, bufSize, parameters);
            [UnmanagedCallersOnly]
            private static void GetnUniformfvEXT_Lazy(ProgramHandle program, int location, int bufSize, float* parameters)
            {
                _GetnUniformfvEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetnUniformfvEXT");
                _GetnUniformfvEXT_fnptr(program, location, bufSize, parameters);
            }
            
            private static delegate* unmanaged<ProgramHandle, int, int, int*, void> _GetnUniformivEXT_fnptr = &GetnUniformivEXT_Lazy;
            public static void GetnUniformivEXT(ProgramHandle program, int location, int bufSize, int* parameters) => _GetnUniformivEXT_fnptr(program, location, bufSize, parameters);
            [UnmanagedCallersOnly]
            private static void GetnUniformivEXT_Lazy(ProgramHandle program, int location, int bufSize, int* parameters)
            {
                _GetnUniformivEXT_fnptr = (delegate* unmanaged<ProgramHandle, int, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetnUniformivEXT");
                _GetnUniformivEXT_fnptr(program, location, bufSize, parameters);
            }
            
            private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, void> _TexStorage1DEXT_fnptr = &TexStorage1DEXT_Lazy;
            public static void TexStorage1DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width) => _TexStorage1DEXT_fnptr(target, levels, internalformat, width);
            [UnmanagedCallersOnly]
            private static void TexStorage1DEXT_Lazy(TextureTarget target, int levels, SizedInternalFormat internalformat, int width)
            {
                _TexStorage1DEXT_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorage1DEXT");
                _TexStorage1DEXT_fnptr(target, levels, internalformat, width);
            }
            
            private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, void> _TexStorage2DEXT_fnptr = &TexStorage2DEXT_Lazy;
            public static void TexStorage2DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height) => _TexStorage2DEXT_fnptr(target, levels, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void TexStorage2DEXT_Lazy(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height)
            {
                _TexStorage2DEXT_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorage2DEXT");
                _TexStorage2DEXT_fnptr(target, levels, internalformat, width, height);
            }
            
            private static delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, void> _TexStorage3DEXT_fnptr = &TexStorage3DEXT_Lazy;
            public static void TexStorage3DEXT(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => _TexStorage3DEXT_fnptr(target, levels, internalformat, width, height, depth);
            [UnmanagedCallersOnly]
            private static void TexStorage3DEXT_Lazy(TextureTarget target, int levels, SizedInternalFormat internalformat, int width, int height, int depth)
            {
                _TexStorage3DEXT_fnptr = (delegate* unmanaged<TextureTarget, int, SizedInternalFormat, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexStorage3DEXT");
                _TexStorage3DEXT_fnptr(target, levels, internalformat, width, height, depth);
            }
            
            private static delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, void> _TextureStorage1DEXT_fnptr = &TextureStorage1DEXT_Lazy;
            public static void TextureStorage1DEXT(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width) => _TextureStorage1DEXT_fnptr(texture, target, levels, internalformat, width);
            [UnmanagedCallersOnly]
            private static void TextureStorage1DEXT_Lazy(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width)
            {
                _TextureStorage1DEXT_fnptr = (delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, void>)GLLoader.BindingsContext.GetProcAddress("glTextureStorage1DEXT");
                _TextureStorage1DEXT_fnptr(texture, target, levels, internalformat, width);
            }
            
            private static delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, int, void> _TextureStorage2DEXT_fnptr = &TextureStorage2DEXT_Lazy;
            public static void TextureStorage2DEXT(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width, int height) => _TextureStorage2DEXT_fnptr(texture, target, levels, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void TextureStorage2DEXT_Lazy(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width, int height)
            {
                _TextureStorage2DEXT_fnptr = (delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glTextureStorage2DEXT");
                _TextureStorage2DEXT_fnptr(texture, target, levels, internalformat, width, height);
            }
            
            private static delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, int, int, void> _TextureStorage3DEXT_fnptr = &TextureStorage3DEXT_Lazy;
            public static void TextureStorage3DEXT(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width, int height, int depth) => _TextureStorage3DEXT_fnptr(texture, target, levels, internalformat, width, height, depth);
            [UnmanagedCallersOnly]
            private static void TextureStorage3DEXT_Lazy(TextureHandle texture, All target, int levels, SizedInternalFormat internalformat, int width, int height, int depth)
            {
                _TextureStorage3DEXT_fnptr = (delegate* unmanaged<TextureHandle, All, int, SizedInternalFormat, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glTextureStorage3DEXT");
                _TextureStorage3DEXT_fnptr(texture, target, levels, internalformat, width, height, depth);
            }
            
        }
        public static unsafe partial class IMG
        {
            private static delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void> _RenderbufferStorageMultisampleIMG_fnptr = &RenderbufferStorageMultisampleIMG_Lazy;
            public static void RenderbufferStorageMultisampleIMG(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height) => _RenderbufferStorageMultisampleIMG_fnptr(target, samples, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void RenderbufferStorageMultisampleIMG_Lazy(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
            {
                _RenderbufferStorageMultisampleIMG_fnptr = (delegate* unmanaged<RenderbufferTarget, int, InternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorageMultisampleIMG");
                _RenderbufferStorageMultisampleIMG_fnptr(target, samples, internalformat, width, height);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void> _FramebufferTexture2DMultisampleIMG_fnptr = &FramebufferTexture2DMultisampleIMG_Lazy;
            public static void FramebufferTexture2DMultisampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples) => _FramebufferTexture2DMultisampleIMG_fnptr(target, attachment, textarget, texture, level, samples);
            [UnmanagedCallersOnly]
            private static void FramebufferTexture2DMultisampleIMG_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level, int samples)
            {
                _FramebufferTexture2DMultisampleIMG_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferTexture2DMultisampleIMG");
                _FramebufferTexture2DMultisampleIMG_fnptr(target, attachment, textarget, texture, level, samples);
            }
            
            private static delegate* unmanaged<ClipPlaneName, float*, void> _ClipPlanefIMG_fnptr = &ClipPlanefIMG_Lazy;
            public static void ClipPlanefIMG(ClipPlaneName p, float* eqn) => _ClipPlanefIMG_fnptr(p, eqn);
            [UnmanagedCallersOnly]
            private static void ClipPlanefIMG_Lazy(ClipPlaneName p, float* eqn)
            {
                _ClipPlanefIMG_fnptr = (delegate* unmanaged<ClipPlaneName, float*, void>)GLLoader.BindingsContext.GetProcAddress("glClipPlanefIMG");
                _ClipPlanefIMG_fnptr(p, eqn);
            }
            
            private static delegate* unmanaged<ClipPlaneName, int*, void> _ClipPlanexIMG_fnptr = &ClipPlanexIMG_Lazy;
            public static void ClipPlanexIMG(ClipPlaneName p, int* eqn) => _ClipPlanexIMG_fnptr(p, eqn);
            [UnmanagedCallersOnly]
            private static void ClipPlanexIMG_Lazy(ClipPlaneName p, int* eqn)
            {
                _ClipPlanexIMG_fnptr = (delegate* unmanaged<ClipPlaneName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glClipPlanexIMG");
                _ClipPlanexIMG_fnptr(p, eqn);
            }
            
        }
        public static unsafe partial class KHR
        {
            private static delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void> _DebugMessageControl_fnptr = &DebugMessageControl_Lazy;
            public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled) => _DebugMessageControl_fnptr(source, type, severity, count, ids, enabled);
            [UnmanagedCallersOnly]
            private static void DebugMessageControl_Lazy(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled)
            {
                _DebugMessageControl_fnptr = (delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void>)GLLoader.BindingsContext.GetProcAddress("glDebugMessageControl");
                _DebugMessageControl_fnptr(source, type, severity, count, ids, enabled);
            }
            
            private static delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void> _DebugMessageInsert_fnptr = &DebugMessageInsert_Lazy;
            public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => _DebugMessageInsert_fnptr(source, type, id, severity, length, buf);
            [UnmanagedCallersOnly]
            private static void DebugMessageInsert_Lazy(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf)
            {
                _DebugMessageInsert_fnptr = (delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glDebugMessageInsert");
                _DebugMessageInsert_fnptr(source, type, id, severity, length, buf);
            }
            
            private static delegate* unmanaged<IntPtr, void*, void> _DebugMessageCallback_fnptr = &DebugMessageCallback_Lazy;
            public static void DebugMessageCallback(IntPtr callback, void* userParam) => _DebugMessageCallback_fnptr(callback, userParam);
            [UnmanagedCallersOnly]
            private static void DebugMessageCallback_Lazy(IntPtr callback, void* userParam)
            {
                _DebugMessageCallback_fnptr = (delegate* unmanaged<IntPtr, void*, void>)GLLoader.BindingsContext.GetProcAddress("glDebugMessageCallback");
                _DebugMessageCallback_fnptr(callback, userParam);
            }
            
            private static delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint> _GetDebugMessageLog_fnptr = &GetDebugMessageLog_Lazy;
            public static uint GetDebugMessageLog(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => _GetDebugMessageLog_fnptr(count, bufSize, sources, types, ids, severities, lengths, messageLog);
            [UnmanagedCallersOnly]
            private static uint GetDebugMessageLog_Lazy(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog)
            {
                _GetDebugMessageLog_fnptr = (delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint>)GLLoader.BindingsContext.GetProcAddress("glGetDebugMessageLog");
                return _GetDebugMessageLog_fnptr(count, bufSize, sources, types, ids, severities, lengths, messageLog);
            }
            
            private static delegate* unmanaged<DebugSource, uint, int, byte*, void> _PushDebugGroup_fnptr = &PushDebugGroup_Lazy;
            public static void PushDebugGroup(DebugSource source, uint id, int length, byte* message) => _PushDebugGroup_fnptr(source, id, length, message);
            [UnmanagedCallersOnly]
            private static void PushDebugGroup_Lazy(DebugSource source, uint id, int length, byte* message)
            {
                _PushDebugGroup_fnptr = (delegate* unmanaged<DebugSource, uint, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glPushDebugGroup");
                _PushDebugGroup_fnptr(source, id, length, message);
            }
            
            private static delegate* unmanaged<void> _PopDebugGroup_fnptr = &PopDebugGroup_Lazy;
            public static void PopDebugGroup() => _PopDebugGroup_fnptr();
            [UnmanagedCallersOnly]
            private static void PopDebugGroup_Lazy()
            {
                _PopDebugGroup_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glPopDebugGroup");
                _PopDebugGroup_fnptr();
            }
            
            private static delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void> _ObjectLabel_fnptr = &ObjectLabel_Lazy;
            public static void ObjectLabel(ObjectIdentifier identifier, uint name, int length, byte* label) => _ObjectLabel_fnptr(identifier, name, length, label);
            [UnmanagedCallersOnly]
            private static void ObjectLabel_Lazy(ObjectIdentifier identifier, uint name, int length, byte* label)
            {
                _ObjectLabel_fnptr = (delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glObjectLabel");
                _ObjectLabel_fnptr(identifier, name, length, label);
            }
            
            private static delegate* unmanaged<ObjectIdentifier, uint, int, int*, byte*, void> _GetObjectLabel_fnptr = &GetObjectLabel_Lazy;
            public static void GetObjectLabel(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label) => _GetObjectLabel_fnptr(identifier, name, bufSize, length, label);
            [UnmanagedCallersOnly]
            private static void GetObjectLabel_Lazy(ObjectIdentifier identifier, uint name, int bufSize, int* length, byte* label)
            {
                _GetObjectLabel_fnptr = (delegate* unmanaged<ObjectIdentifier, uint, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetObjectLabel");
                _GetObjectLabel_fnptr(identifier, name, bufSize, length, label);
            }
            
            private static delegate* unmanaged<void*, int, byte*, void> _ObjectPtrLabel_fnptr = &ObjectPtrLabel_Lazy;
            public static void ObjectPtrLabel(void* ptr, int length, byte* label) => _ObjectPtrLabel_fnptr(ptr, length, label);
            [UnmanagedCallersOnly]
            private static void ObjectPtrLabel_Lazy(void* ptr, int length, byte* label)
            {
                _ObjectPtrLabel_fnptr = (delegate* unmanaged<void*, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glObjectPtrLabel");
                _ObjectPtrLabel_fnptr(ptr, length, label);
            }
            
            private static delegate* unmanaged<void*, int, int*, byte*, void> _GetObjectPtrLabel_fnptr = &GetObjectPtrLabel_Lazy;
            public static void GetObjectPtrLabel(void* ptr, int bufSize, int* length, byte* label) => _GetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
            [UnmanagedCallersOnly]
            private static void GetObjectPtrLabel_Lazy(void* ptr, int bufSize, int* length, byte* label)
            {
                _GetObjectPtrLabel_fnptr = (delegate* unmanaged<void*, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetObjectPtrLabel");
                _GetObjectPtrLabel_fnptr(ptr, bufSize, length, label);
            }
            
            private static delegate* unmanaged<GetPointervPName, void**, void> _GetPointerv_fnptr = &GetPointerv_Lazy;
            public static void GetPointerv(GetPointervPName pname, void** parameters) => _GetPointerv_fnptr(pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetPointerv_Lazy(GetPointervPName pname, void** parameters)
            {
                _GetPointerv_fnptr = (delegate* unmanaged<GetPointervPName, void**, void>)GLLoader.BindingsContext.GetProcAddress("glGetPointerv");
                _GetPointerv_fnptr(pname, parameters);
            }
            
            private static delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void> _DebugMessageControlKHR_fnptr = &DebugMessageControlKHR_Lazy;
            public static void DebugMessageControlKHR(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled) => _DebugMessageControlKHR_fnptr(source, type, severity, count, ids, enabled);
            [UnmanagedCallersOnly]
            private static void DebugMessageControlKHR_Lazy(DebugSource source, DebugType type, DebugSeverity severity, int count, uint* ids, byte enabled)
            {
                _DebugMessageControlKHR_fnptr = (delegate* unmanaged<DebugSource, DebugType, DebugSeverity, int, uint*, byte, void>)GLLoader.BindingsContext.GetProcAddress("glDebugMessageControlKHR");
                _DebugMessageControlKHR_fnptr(source, type, severity, count, ids, enabled);
            }
            
            private static delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void> _DebugMessageInsertKHR_fnptr = &DebugMessageInsertKHR_Lazy;
            public static void DebugMessageInsertKHR(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf) => _DebugMessageInsertKHR_fnptr(source, type, id, severity, length, buf);
            [UnmanagedCallersOnly]
            private static void DebugMessageInsertKHR_Lazy(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, byte* buf)
            {
                _DebugMessageInsertKHR_fnptr = (delegate* unmanaged<DebugSource, DebugType, uint, DebugSeverity, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glDebugMessageInsertKHR");
                _DebugMessageInsertKHR_fnptr(source, type, id, severity, length, buf);
            }
            
            private static delegate* unmanaged<IntPtr, void*, void> _DebugMessageCallbackKHR_fnptr = &DebugMessageCallbackKHR_Lazy;
            public static void DebugMessageCallbackKHR(IntPtr callback, void* userParam) => _DebugMessageCallbackKHR_fnptr(callback, userParam);
            [UnmanagedCallersOnly]
            private static void DebugMessageCallbackKHR_Lazy(IntPtr callback, void* userParam)
            {
                _DebugMessageCallbackKHR_fnptr = (delegate* unmanaged<IntPtr, void*, void>)GLLoader.BindingsContext.GetProcAddress("glDebugMessageCallbackKHR");
                _DebugMessageCallbackKHR_fnptr(callback, userParam);
            }
            
            private static delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint> _GetDebugMessageLogKHR_fnptr = &GetDebugMessageLogKHR_Lazy;
            public static uint GetDebugMessageLogKHR(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog) => _GetDebugMessageLogKHR_fnptr(count, bufSize, sources, types, ids, severities, lengths, messageLog);
            [UnmanagedCallersOnly]
            private static uint GetDebugMessageLogKHR_Lazy(uint count, int bufSize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, byte* messageLog)
            {
                _GetDebugMessageLogKHR_fnptr = (delegate* unmanaged<uint, int, DebugSource*, DebugType*, uint*, DebugSeverity*, int*, byte*, uint>)GLLoader.BindingsContext.GetProcAddress("glGetDebugMessageLogKHR");
                return _GetDebugMessageLogKHR_fnptr(count, bufSize, sources, types, ids, severities, lengths, messageLog);
            }
            
            private static delegate* unmanaged<DebugSource, uint, int, byte*, void> _PushDebugGroupKHR_fnptr = &PushDebugGroupKHR_Lazy;
            public static void PushDebugGroupKHR(DebugSource source, uint id, int length, byte* message) => _PushDebugGroupKHR_fnptr(source, id, length, message);
            [UnmanagedCallersOnly]
            private static void PushDebugGroupKHR_Lazy(DebugSource source, uint id, int length, byte* message)
            {
                _PushDebugGroupKHR_fnptr = (delegate* unmanaged<DebugSource, uint, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glPushDebugGroupKHR");
                _PushDebugGroupKHR_fnptr(source, id, length, message);
            }
            
            private static delegate* unmanaged<void> _PopDebugGroupKHR_fnptr = &PopDebugGroupKHR_Lazy;
            public static void PopDebugGroupKHR() => _PopDebugGroupKHR_fnptr();
            [UnmanagedCallersOnly]
            private static void PopDebugGroupKHR_Lazy()
            {
                _PopDebugGroupKHR_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glPopDebugGroupKHR");
                _PopDebugGroupKHR_fnptr();
            }
            
            private static delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void> _ObjectLabelKHR_fnptr = &ObjectLabelKHR_Lazy;
            public static void ObjectLabelKHR(ObjectIdentifier identifier, uint name, int length, byte* label) => _ObjectLabelKHR_fnptr(identifier, name, length, label);
            [UnmanagedCallersOnly]
            private static void ObjectLabelKHR_Lazy(ObjectIdentifier identifier, uint name, int length, byte* label)
            {
                _ObjectLabelKHR_fnptr = (delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glObjectLabelKHR");
                _ObjectLabelKHR_fnptr(identifier, name, length, label);
            }
            
            private static delegate* unmanaged<All, uint, int, int*, byte*, void> _GetObjectLabelKHR_fnptr = &GetObjectLabelKHR_Lazy;
            public static void GetObjectLabelKHR(All identifier, uint name, int bufSize, int* length, byte* label) => _GetObjectLabelKHR_fnptr(identifier, name, bufSize, length, label);
            [UnmanagedCallersOnly]
            private static void GetObjectLabelKHR_Lazy(All identifier, uint name, int bufSize, int* length, byte* label)
            {
                _GetObjectLabelKHR_fnptr = (delegate* unmanaged<All, uint, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetObjectLabelKHR");
                _GetObjectLabelKHR_fnptr(identifier, name, bufSize, length, label);
            }
            
            private static delegate* unmanaged<void*, int, byte*, void> _ObjectPtrLabelKHR_fnptr = &ObjectPtrLabelKHR_Lazy;
            public static void ObjectPtrLabelKHR(void* ptr, int length, byte* label) => _ObjectPtrLabelKHR_fnptr(ptr, length, label);
            [UnmanagedCallersOnly]
            private static void ObjectPtrLabelKHR_Lazy(void* ptr, int length, byte* label)
            {
                _ObjectPtrLabelKHR_fnptr = (delegate* unmanaged<void*, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glObjectPtrLabelKHR");
                _ObjectPtrLabelKHR_fnptr(ptr, length, label);
            }
            
            private static delegate* unmanaged<void*, int, int*, byte*, void> _GetObjectPtrLabelKHR_fnptr = &GetObjectPtrLabelKHR_Lazy;
            public static void GetObjectPtrLabelKHR(void* ptr, int bufSize, int* length, byte* label) => _GetObjectPtrLabelKHR_fnptr(ptr, bufSize, length, label);
            [UnmanagedCallersOnly]
            private static void GetObjectPtrLabelKHR_Lazy(void* ptr, int bufSize, int* length, byte* label)
            {
                _GetObjectPtrLabelKHR_fnptr = (delegate* unmanaged<void*, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetObjectPtrLabelKHR");
                _GetObjectPtrLabelKHR_fnptr(ptr, bufSize, length, label);
            }
            
            private static delegate* unmanaged<All, void**, void> _GetPointervKHR_fnptr = &GetPointervKHR_Lazy;
            public static void GetPointervKHR(All pname, void** parameters) => _GetPointervKHR_fnptr(pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetPointervKHR_Lazy(All pname, void** parameters)
            {
                _GetPointervKHR_fnptr = (delegate* unmanaged<All, void**, void>)GLLoader.BindingsContext.GetProcAddress("glGetPointervKHR");
                _GetPointervKHR_fnptr(pname, parameters);
            }
            
        }
        public static unsafe partial class NV
        {
            private static delegate* unmanaged<int, uint*, void> _DeleteFencesNV_fnptr = &DeleteFencesNV_Lazy;
            public static void DeleteFencesNV(int n, uint* fences) => _DeleteFencesNV_fnptr(n, fences);
            [UnmanagedCallersOnly]
            private static void DeleteFencesNV_Lazy(int n, uint* fences)
            {
                _DeleteFencesNV_fnptr = (delegate* unmanaged<int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteFencesNV");
                _DeleteFencesNV_fnptr(n, fences);
            }
            
            private static delegate* unmanaged<int, uint*, void> _GenFencesNV_fnptr = &GenFencesNV_Lazy;
            public static void GenFencesNV(int n, uint* fences) => _GenFencesNV_fnptr(n, fences);
            [UnmanagedCallersOnly]
            private static void GenFencesNV_Lazy(int n, uint* fences)
            {
                _GenFencesNV_fnptr = (delegate* unmanaged<int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGenFencesNV");
                _GenFencesNV_fnptr(n, fences);
            }
            
            private static delegate* unmanaged<uint, byte> _IsFenceNV_fnptr = &IsFenceNV_Lazy;
            public static byte IsFenceNV(uint fence) => _IsFenceNV_fnptr(fence);
            [UnmanagedCallersOnly]
            private static byte IsFenceNV_Lazy(uint fence)
            {
                _IsFenceNV_fnptr = (delegate* unmanaged<uint, byte>)GLLoader.BindingsContext.GetProcAddress("glIsFenceNV");
                return _IsFenceNV_fnptr(fence);
            }
            
            private static delegate* unmanaged<uint, byte> _TestFenceNV_fnptr = &TestFenceNV_Lazy;
            public static byte TestFenceNV(uint fence) => _TestFenceNV_fnptr(fence);
            [UnmanagedCallersOnly]
            private static byte TestFenceNV_Lazy(uint fence)
            {
                _TestFenceNV_fnptr = (delegate* unmanaged<uint, byte>)GLLoader.BindingsContext.GetProcAddress("glTestFenceNV");
                return _TestFenceNV_fnptr(fence);
            }
            
            private static delegate* unmanaged<uint, FenceParameterNameNV, int*, void> _GetFenceivNV_fnptr = &GetFenceivNV_Lazy;
            public static void GetFenceivNV(uint fence, FenceParameterNameNV pname, int* parameters) => _GetFenceivNV_fnptr(fence, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetFenceivNV_Lazy(uint fence, FenceParameterNameNV pname, int* parameters)
            {
                _GetFenceivNV_fnptr = (delegate* unmanaged<uint, FenceParameterNameNV, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetFenceivNV");
                _GetFenceivNV_fnptr(fence, pname, parameters);
            }
            
            private static delegate* unmanaged<uint, void> _FinishFenceNV_fnptr = &FinishFenceNV_Lazy;
            public static void FinishFenceNV(uint fence) => _FinishFenceNV_fnptr(fence);
            [UnmanagedCallersOnly]
            private static void FinishFenceNV_Lazy(uint fence)
            {
                _FinishFenceNV_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glFinishFenceNV");
                _FinishFenceNV_fnptr(fence);
            }
            
            private static delegate* unmanaged<uint, FenceConditionNV, void> _SetFenceNV_fnptr = &SetFenceNV_Lazy;
            public static void SetFenceNV(uint fence, FenceConditionNV condition) => _SetFenceNV_fnptr(fence, condition);
            [UnmanagedCallersOnly]
            private static void SetFenceNV_Lazy(uint fence, FenceConditionNV condition)
            {
                _SetFenceNV_fnptr = (delegate* unmanaged<uint, FenceConditionNV, void>)GLLoader.BindingsContext.GetProcAddress("glSetFenceNV");
                _SetFenceNV_fnptr(fence, condition);
            }
            
        }
        public static unsafe partial class OES
        {
            private static delegate* unmanaged<All, void*, void> _EGLImageTargetTexture2DOES_fnptr = &EGLImageTargetTexture2DOES_Lazy;
            public static void EGLImageTargetTexture2DOES(All target, void* image) => _EGLImageTargetTexture2DOES_fnptr(target, image);
            [UnmanagedCallersOnly]
            private static void EGLImageTargetTexture2DOES_Lazy(All target, void* image)
            {
                _EGLImageTargetTexture2DOES_fnptr = (delegate* unmanaged<All, void*, void>)GLLoader.BindingsContext.GetProcAddress("glEGLImageTargetTexture2DOES");
                _EGLImageTargetTexture2DOES_fnptr(target, image);
            }
            
            private static delegate* unmanaged<All, void*, void> _EGLImageTargetRenderbufferStorageOES_fnptr = &EGLImageTargetRenderbufferStorageOES_Lazy;
            public static void EGLImageTargetRenderbufferStorageOES(All target, void* image) => _EGLImageTargetRenderbufferStorageOES_fnptr(target, image);
            [UnmanagedCallersOnly]
            private static void EGLImageTargetRenderbufferStorageOES_Lazy(All target, void* image)
            {
                _EGLImageTargetRenderbufferStorageOES_fnptr = (delegate* unmanaged<All, void*, void>)GLLoader.BindingsContext.GetProcAddress("glEGLImageTargetRenderbufferStorageOES");
                _EGLImageTargetRenderbufferStorageOES_fnptr(target, image);
            }
            
            private static delegate* unmanaged<BlendEquationModeEXT, BlendEquationModeEXT, void> _BlendEquationSeparateOES_fnptr = &BlendEquationSeparateOES_Lazy;
            public static void BlendEquationSeparateOES(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha) => _BlendEquationSeparateOES_fnptr(modeRGB, modeAlpha);
            [UnmanagedCallersOnly]
            private static void BlendEquationSeparateOES_Lazy(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
            {
                _BlendEquationSeparateOES_fnptr = (delegate* unmanaged<BlendEquationModeEXT, BlendEquationModeEXT, void>)GLLoader.BindingsContext.GetProcAddress("glBlendEquationSeparateOES");
                _BlendEquationSeparateOES_fnptr(modeRGB, modeAlpha);
            }
            
            private static delegate* unmanaged<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void> _BlendFuncSeparateOES_fnptr = &BlendFuncSeparateOES_Lazy;
            public static void BlendFuncSeparateOES(BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha) => _BlendFuncSeparateOES_fnptr(srcRGB, dstRGB, srcAlpha, dstAlpha);
            [UnmanagedCallersOnly]
            private static void BlendFuncSeparateOES_Lazy(BlendingFactor srcRGB, BlendingFactor dstRGB, BlendingFactor srcAlpha, BlendingFactor dstAlpha)
            {
                _BlendFuncSeparateOES_fnptr = (delegate* unmanaged<BlendingFactor, BlendingFactor, BlendingFactor, BlendingFactor, void>)GLLoader.BindingsContext.GetProcAddress("glBlendFuncSeparateOES");
                _BlendFuncSeparateOES_fnptr(srcRGB, dstRGB, srcAlpha, dstAlpha);
            }
            
            private static delegate* unmanaged<BlendEquationModeEXT, void> _BlendEquationOES_fnptr = &BlendEquationOES_Lazy;
            public static void BlendEquationOES(BlendEquationModeEXT mode) => _BlendEquationOES_fnptr(mode);
            [UnmanagedCallersOnly]
            private static void BlendEquationOES_Lazy(BlendEquationModeEXT mode)
            {
                _BlendEquationOES_fnptr = (delegate* unmanaged<BlendEquationModeEXT, void>)GLLoader.BindingsContext.GetProcAddress("glBlendEquationOES");
                _BlendEquationOES_fnptr(mode);
            }
            
            private static delegate* unmanaged<TextureUnit, sbyte, void> _MultiTexCoord1bOES_fnptr = &MultiTexCoord1bOES_Lazy;
            public static void MultiTexCoord1bOES(TextureUnit texture, sbyte s) => _MultiTexCoord1bOES_fnptr(texture, s);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord1bOES_Lazy(TextureUnit texture, sbyte s)
            {
                _MultiTexCoord1bOES_fnptr = (delegate* unmanaged<TextureUnit, sbyte, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord1bOES");
                _MultiTexCoord1bOES_fnptr(texture, s);
            }
            
            private static delegate* unmanaged<TextureUnit, sbyte*, void> _MultiTexCoord1bvOES_fnptr = &MultiTexCoord1bvOES_Lazy;
            public static void MultiTexCoord1bvOES(TextureUnit texture, sbyte* coords) => _MultiTexCoord1bvOES_fnptr(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord1bvOES_Lazy(TextureUnit texture, sbyte* coords)
            {
                _MultiTexCoord1bvOES_fnptr = (delegate* unmanaged<TextureUnit, sbyte*, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord1bvOES");
                _MultiTexCoord1bvOES_fnptr(texture, coords);
            }
            
            private static delegate* unmanaged<TextureUnit, sbyte, sbyte, void> _MultiTexCoord2bOES_fnptr = &MultiTexCoord2bOES_Lazy;
            public static void MultiTexCoord2bOES(TextureUnit texture, sbyte s, sbyte t) => _MultiTexCoord2bOES_fnptr(texture, s, t);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord2bOES_Lazy(TextureUnit texture, sbyte s, sbyte t)
            {
                _MultiTexCoord2bOES_fnptr = (delegate* unmanaged<TextureUnit, sbyte, sbyte, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord2bOES");
                _MultiTexCoord2bOES_fnptr(texture, s, t);
            }
            
            private static delegate* unmanaged<TextureUnit, sbyte*, void> _MultiTexCoord2bvOES_fnptr = &MultiTexCoord2bvOES_Lazy;
            public static void MultiTexCoord2bvOES(TextureUnit texture, sbyte* coords) => _MultiTexCoord2bvOES_fnptr(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord2bvOES_Lazy(TextureUnit texture, sbyte* coords)
            {
                _MultiTexCoord2bvOES_fnptr = (delegate* unmanaged<TextureUnit, sbyte*, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord2bvOES");
                _MultiTexCoord2bvOES_fnptr(texture, coords);
            }
            
            private static delegate* unmanaged<TextureUnit, sbyte, sbyte, sbyte, void> _MultiTexCoord3bOES_fnptr = &MultiTexCoord3bOES_Lazy;
            public static void MultiTexCoord3bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r) => _MultiTexCoord3bOES_fnptr(texture, s, t, r);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord3bOES_Lazy(TextureUnit texture, sbyte s, sbyte t, sbyte r)
            {
                _MultiTexCoord3bOES_fnptr = (delegate* unmanaged<TextureUnit, sbyte, sbyte, sbyte, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord3bOES");
                _MultiTexCoord3bOES_fnptr(texture, s, t, r);
            }
            
            private static delegate* unmanaged<TextureUnit, sbyte*, void> _MultiTexCoord3bvOES_fnptr = &MultiTexCoord3bvOES_Lazy;
            public static void MultiTexCoord3bvOES(TextureUnit texture, sbyte* coords) => _MultiTexCoord3bvOES_fnptr(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord3bvOES_Lazy(TextureUnit texture, sbyte* coords)
            {
                _MultiTexCoord3bvOES_fnptr = (delegate* unmanaged<TextureUnit, sbyte*, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord3bvOES");
                _MultiTexCoord3bvOES_fnptr(texture, coords);
            }
            
            private static delegate* unmanaged<TextureUnit, sbyte, sbyte, sbyte, sbyte, void> _MultiTexCoord4bOES_fnptr = &MultiTexCoord4bOES_Lazy;
            public static void MultiTexCoord4bOES(TextureUnit texture, sbyte s, sbyte t, sbyte r, sbyte q) => _MultiTexCoord4bOES_fnptr(texture, s, t, r, q);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord4bOES_Lazy(TextureUnit texture, sbyte s, sbyte t, sbyte r, sbyte q)
            {
                _MultiTexCoord4bOES_fnptr = (delegate* unmanaged<TextureUnit, sbyte, sbyte, sbyte, sbyte, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord4bOES");
                _MultiTexCoord4bOES_fnptr(texture, s, t, r, q);
            }
            
            private static delegate* unmanaged<TextureUnit, sbyte*, void> _MultiTexCoord4bvOES_fnptr = &MultiTexCoord4bvOES_Lazy;
            public static void MultiTexCoord4bvOES(TextureUnit texture, sbyte* coords) => _MultiTexCoord4bvOES_fnptr(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord4bvOES_Lazy(TextureUnit texture, sbyte* coords)
            {
                _MultiTexCoord4bvOES_fnptr = (delegate* unmanaged<TextureUnit, sbyte*, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord4bvOES");
                _MultiTexCoord4bvOES_fnptr(texture, coords);
            }
            
            private static delegate* unmanaged<sbyte, void> _TexCoord1bOES_fnptr = &TexCoord1bOES_Lazy;
            public static void TexCoord1bOES(sbyte s) => _TexCoord1bOES_fnptr(s);
            [UnmanagedCallersOnly]
            private static void TexCoord1bOES_Lazy(sbyte s)
            {
                _TexCoord1bOES_fnptr = (delegate* unmanaged<sbyte, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord1bOES");
                _TexCoord1bOES_fnptr(s);
            }
            
            private static delegate* unmanaged<sbyte*, void> _TexCoord1bvOES_fnptr = &TexCoord1bvOES_Lazy;
            public static void TexCoord1bvOES(sbyte* coords) => _TexCoord1bvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord1bvOES_Lazy(sbyte* coords)
            {
                _TexCoord1bvOES_fnptr = (delegate* unmanaged<sbyte*, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord1bvOES");
                _TexCoord1bvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<sbyte, sbyte, void> _TexCoord2bOES_fnptr = &TexCoord2bOES_Lazy;
            public static void TexCoord2bOES(sbyte s, sbyte t) => _TexCoord2bOES_fnptr(s, t);
            [UnmanagedCallersOnly]
            private static void TexCoord2bOES_Lazy(sbyte s, sbyte t)
            {
                _TexCoord2bOES_fnptr = (delegate* unmanaged<sbyte, sbyte, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord2bOES");
                _TexCoord2bOES_fnptr(s, t);
            }
            
            private static delegate* unmanaged<sbyte*, void> _TexCoord2bvOES_fnptr = &TexCoord2bvOES_Lazy;
            public static void TexCoord2bvOES(sbyte* coords) => _TexCoord2bvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord2bvOES_Lazy(sbyte* coords)
            {
                _TexCoord2bvOES_fnptr = (delegate* unmanaged<sbyte*, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord2bvOES");
                _TexCoord2bvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<sbyte, sbyte, sbyte, void> _TexCoord3bOES_fnptr = &TexCoord3bOES_Lazy;
            public static void TexCoord3bOES(sbyte s, sbyte t, sbyte r) => _TexCoord3bOES_fnptr(s, t, r);
            [UnmanagedCallersOnly]
            private static void TexCoord3bOES_Lazy(sbyte s, sbyte t, sbyte r)
            {
                _TexCoord3bOES_fnptr = (delegate* unmanaged<sbyte, sbyte, sbyte, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord3bOES");
                _TexCoord3bOES_fnptr(s, t, r);
            }
            
            private static delegate* unmanaged<sbyte*, void> _TexCoord3bvOES_fnptr = &TexCoord3bvOES_Lazy;
            public static void TexCoord3bvOES(sbyte* coords) => _TexCoord3bvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord3bvOES_Lazy(sbyte* coords)
            {
                _TexCoord3bvOES_fnptr = (delegate* unmanaged<sbyte*, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord3bvOES");
                _TexCoord3bvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<sbyte, sbyte, sbyte, sbyte, void> _TexCoord4bOES_fnptr = &TexCoord4bOES_Lazy;
            public static void TexCoord4bOES(sbyte s, sbyte t, sbyte r, sbyte q) => _TexCoord4bOES_fnptr(s, t, r, q);
            [UnmanagedCallersOnly]
            private static void TexCoord4bOES_Lazy(sbyte s, sbyte t, sbyte r, sbyte q)
            {
                _TexCoord4bOES_fnptr = (delegate* unmanaged<sbyte, sbyte, sbyte, sbyte, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord4bOES");
                _TexCoord4bOES_fnptr(s, t, r, q);
            }
            
            private static delegate* unmanaged<sbyte*, void> _TexCoord4bvOES_fnptr = &TexCoord4bvOES_Lazy;
            public static void TexCoord4bvOES(sbyte* coords) => _TexCoord4bvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord4bvOES_Lazy(sbyte* coords)
            {
                _TexCoord4bvOES_fnptr = (delegate* unmanaged<sbyte*, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord4bvOES");
                _TexCoord4bvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<sbyte, sbyte, void> _Vertex2bOES_fnptr = &Vertex2bOES_Lazy;
            public static void Vertex2bOES(sbyte x, sbyte y) => _Vertex2bOES_fnptr(x, y);
            [UnmanagedCallersOnly]
            private static void Vertex2bOES_Lazy(sbyte x, sbyte y)
            {
                _Vertex2bOES_fnptr = (delegate* unmanaged<sbyte, sbyte, void>)GLLoader.BindingsContext.GetProcAddress("glVertex2bOES");
                _Vertex2bOES_fnptr(x, y);
            }
            
            private static delegate* unmanaged<sbyte*, void> _Vertex2bvOES_fnptr = &Vertex2bvOES_Lazy;
            public static void Vertex2bvOES(sbyte* coords) => _Vertex2bvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void Vertex2bvOES_Lazy(sbyte* coords)
            {
                _Vertex2bvOES_fnptr = (delegate* unmanaged<sbyte*, void>)GLLoader.BindingsContext.GetProcAddress("glVertex2bvOES");
                _Vertex2bvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<sbyte, sbyte, sbyte, void> _Vertex3bOES_fnptr = &Vertex3bOES_Lazy;
            public static void Vertex3bOES(sbyte x, sbyte y, sbyte z) => _Vertex3bOES_fnptr(x, y, z);
            [UnmanagedCallersOnly]
            private static void Vertex3bOES_Lazy(sbyte x, sbyte y, sbyte z)
            {
                _Vertex3bOES_fnptr = (delegate* unmanaged<sbyte, sbyte, sbyte, void>)GLLoader.BindingsContext.GetProcAddress("glVertex3bOES");
                _Vertex3bOES_fnptr(x, y, z);
            }
            
            private static delegate* unmanaged<sbyte*, void> _Vertex3bvOES_fnptr = &Vertex3bvOES_Lazy;
            public static void Vertex3bvOES(sbyte* coords) => _Vertex3bvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void Vertex3bvOES_Lazy(sbyte* coords)
            {
                _Vertex3bvOES_fnptr = (delegate* unmanaged<sbyte*, void>)GLLoader.BindingsContext.GetProcAddress("glVertex3bvOES");
                _Vertex3bvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<sbyte, sbyte, sbyte, sbyte, void> _Vertex4bOES_fnptr = &Vertex4bOES_Lazy;
            public static void Vertex4bOES(sbyte x, sbyte y, sbyte z, sbyte w) => _Vertex4bOES_fnptr(x, y, z, w);
            [UnmanagedCallersOnly]
            private static void Vertex4bOES_Lazy(sbyte x, sbyte y, sbyte z, sbyte w)
            {
                _Vertex4bOES_fnptr = (delegate* unmanaged<sbyte, sbyte, sbyte, sbyte, void>)GLLoader.BindingsContext.GetProcAddress("glVertex4bOES");
                _Vertex4bOES_fnptr(x, y, z, w);
            }
            
            private static delegate* unmanaged<sbyte*, void> _Vertex4bvOES_fnptr = &Vertex4bvOES_Lazy;
            public static void Vertex4bvOES(sbyte* coords) => _Vertex4bvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void Vertex4bvOES_Lazy(sbyte* coords)
            {
                _Vertex4bvOES_fnptr = (delegate* unmanaged<sbyte*, void>)GLLoader.BindingsContext.GetProcAddress("glVertex4bvOES");
                _Vertex4bvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<short, short, short, short, short, void> _DrawTexsOES_fnptr = &DrawTexsOES_Lazy;
            public static void DrawTexsOES(short x, short y, short z, short width, short height) => _DrawTexsOES_fnptr(x, y, z, width, height);
            [UnmanagedCallersOnly]
            private static void DrawTexsOES_Lazy(short x, short y, short z, short width, short height)
            {
                _DrawTexsOES_fnptr = (delegate* unmanaged<short, short, short, short, short, void>)GLLoader.BindingsContext.GetProcAddress("glDrawTexsOES");
                _DrawTexsOES_fnptr(x, y, z, width, height);
            }
            
            private static delegate* unmanaged<int, int, int, int, int, void> _DrawTexiOES_fnptr = &DrawTexiOES_Lazy;
            public static void DrawTexiOES(int x, int y, int z, int width, int height) => _DrawTexiOES_fnptr(x, y, z, width, height);
            [UnmanagedCallersOnly]
            private static void DrawTexiOES_Lazy(int x, int y, int z, int width, int height)
            {
                _DrawTexiOES_fnptr = (delegate* unmanaged<int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawTexiOES");
                _DrawTexiOES_fnptr(x, y, z, width, height);
            }
            
            private static delegate* unmanaged<int, int, int, int, int, void> _DrawTexxOES_fnptr = &DrawTexxOES_Lazy;
            public static void DrawTexxOES(int x, int y, int z, int width, int height) => _DrawTexxOES_fnptr(x, y, z, width, height);
            [UnmanagedCallersOnly]
            private static void DrawTexxOES_Lazy(int x, int y, int z, int width, int height)
            {
                _DrawTexxOES_fnptr = (delegate* unmanaged<int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glDrawTexxOES");
                _DrawTexxOES_fnptr(x, y, z, width, height);
            }
            
            private static delegate* unmanaged<short*, void> _DrawTexsvOES_fnptr = &DrawTexsvOES_Lazy;
            public static void DrawTexsvOES(short* coords) => _DrawTexsvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void DrawTexsvOES_Lazy(short* coords)
            {
                _DrawTexsvOES_fnptr = (delegate* unmanaged<short*, void>)GLLoader.BindingsContext.GetProcAddress("glDrawTexsvOES");
                _DrawTexsvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<int*, void> _DrawTexivOES_fnptr = &DrawTexivOES_Lazy;
            public static void DrawTexivOES(int* coords) => _DrawTexivOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void DrawTexivOES_Lazy(int* coords)
            {
                _DrawTexivOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glDrawTexivOES");
                _DrawTexivOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<int*, void> _DrawTexxvOES_fnptr = &DrawTexxvOES_Lazy;
            public static void DrawTexxvOES(int* coords) => _DrawTexxvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void DrawTexxvOES_Lazy(int* coords)
            {
                _DrawTexxvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glDrawTexxvOES");
                _DrawTexxvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<float, float, float, float, float, void> _DrawTexfOES_fnptr = &DrawTexfOES_Lazy;
            public static void DrawTexfOES(float x, float y, float z, float width, float height) => _DrawTexfOES_fnptr(x, y, z, width, height);
            [UnmanagedCallersOnly]
            private static void DrawTexfOES_Lazy(float x, float y, float z, float width, float height)
            {
                _DrawTexfOES_fnptr = (delegate* unmanaged<float, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glDrawTexfOES");
                _DrawTexfOES_fnptr(x, y, z, width, height);
            }
            
            private static delegate* unmanaged<float*, void> _DrawTexfvOES_fnptr = &DrawTexfvOES_Lazy;
            public static void DrawTexfvOES(float* coords) => _DrawTexfvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void DrawTexfvOES_Lazy(float* coords)
            {
                _DrawTexfvOES_fnptr = (delegate* unmanaged<float*, void>)GLLoader.BindingsContext.GetProcAddress("glDrawTexfvOES");
                _DrawTexfvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<AlphaFunction, int, void> _AlphaFuncxOES_fnptr = &AlphaFuncxOES_Lazy;
            public static void AlphaFuncxOES(AlphaFunction func, int reference) => _AlphaFuncxOES_fnptr(func, reference);
            [UnmanagedCallersOnly]
            private static void AlphaFuncxOES_Lazy(AlphaFunction func, int reference)
            {
                _AlphaFuncxOES_fnptr = (delegate* unmanaged<AlphaFunction, int, void>)GLLoader.BindingsContext.GetProcAddress("glAlphaFuncxOES");
                _AlphaFuncxOES_fnptr(func, reference);
            }
            
            private static delegate* unmanaged<int, int, int, int, void> _ClearColorxOES_fnptr = &ClearColorxOES_Lazy;
            public static void ClearColorxOES(int red, int green, int blue, int alpha) => _ClearColorxOES_fnptr(red, green, blue, alpha);
            [UnmanagedCallersOnly]
            private static void ClearColorxOES_Lazy(int red, int green, int blue, int alpha)
            {
                _ClearColorxOES_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glClearColorxOES");
                _ClearColorxOES_fnptr(red, green, blue, alpha);
            }
            
            private static delegate* unmanaged<int, void> _ClearDepthxOES_fnptr = &ClearDepthxOES_Lazy;
            public static void ClearDepthxOES(int depth) => _ClearDepthxOES_fnptr(depth);
            [UnmanagedCallersOnly]
            private static void ClearDepthxOES_Lazy(int depth)
            {
                _ClearDepthxOES_fnptr = (delegate* unmanaged<int, void>)GLLoader.BindingsContext.GetProcAddress("glClearDepthxOES");
                _ClearDepthxOES_fnptr(depth);
            }
            
            private static delegate* unmanaged<ClipPlaneName, int*, void> _ClipPlanexOES_fnptr = &ClipPlanexOES_Lazy;
            public static void ClipPlanexOES(ClipPlaneName plane, int* equation) => _ClipPlanexOES_fnptr(plane, equation);
            [UnmanagedCallersOnly]
            private static void ClipPlanexOES_Lazy(ClipPlaneName plane, int* equation)
            {
                _ClipPlanexOES_fnptr = (delegate* unmanaged<ClipPlaneName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glClipPlanexOES");
                _ClipPlanexOES_fnptr(plane, equation);
            }
            
            private static delegate* unmanaged<int, int, int, int, void> _Color4xOES_fnptr = &Color4xOES_Lazy;
            public static void Color4xOES(int red, int green, int blue, int alpha) => _Color4xOES_fnptr(red, green, blue, alpha);
            [UnmanagedCallersOnly]
            private static void Color4xOES_Lazy(int red, int green, int blue, int alpha)
            {
                _Color4xOES_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glColor4xOES");
                _Color4xOES_fnptr(red, green, blue, alpha);
            }
            
            private static delegate* unmanaged<int, int, void> _DepthRangexOES_fnptr = &DepthRangexOES_Lazy;
            public static void DepthRangexOES(int n, int f) => _DepthRangexOES_fnptr(n, f);
            [UnmanagedCallersOnly]
            private static void DepthRangexOES_Lazy(int n, int f)
            {
                _DepthRangexOES_fnptr = (delegate* unmanaged<int, int, void>)GLLoader.BindingsContext.GetProcAddress("glDepthRangexOES");
                _DepthRangexOES_fnptr(n, f);
            }
            
            private static delegate* unmanaged<FogPName, int, void> _FogxOES_fnptr = &FogxOES_Lazy;
            public static void FogxOES(FogPName pname, int param) => _FogxOES_fnptr(pname, param);
            [UnmanagedCallersOnly]
            private static void FogxOES_Lazy(FogPName pname, int param)
            {
                _FogxOES_fnptr = (delegate* unmanaged<FogPName, int, void>)GLLoader.BindingsContext.GetProcAddress("glFogxOES");
                _FogxOES_fnptr(pname, param);
            }
            
            private static delegate* unmanaged<FogPName, int*, void> _FogxvOES_fnptr = &FogxvOES_Lazy;
            public static void FogxvOES(FogPName pname, int* param) => _FogxvOES_fnptr(pname, param);
            [UnmanagedCallersOnly]
            private static void FogxvOES_Lazy(FogPName pname, int* param)
            {
                _FogxvOES_fnptr = (delegate* unmanaged<FogPName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glFogxvOES");
                _FogxvOES_fnptr(pname, param);
            }
            
            private static delegate* unmanaged<int, int, int, int, int, int, void> _FrustumxOES_fnptr = &FrustumxOES_Lazy;
            public static void FrustumxOES(int l, int r, int b, int t, int n, int f) => _FrustumxOES_fnptr(l, r, b, t, n, f);
            [UnmanagedCallersOnly]
            private static void FrustumxOES_Lazy(int l, int r, int b, int t, int n, int f)
            {
                _FrustumxOES_fnptr = (delegate* unmanaged<int, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glFrustumxOES");
                _FrustumxOES_fnptr(l, r, b, t, n, f);
            }
            
            private static delegate* unmanaged<ClipPlaneName, int*, void> _GetClipPlanexOES_fnptr = &GetClipPlanexOES_Lazy;
            public static void GetClipPlanexOES(ClipPlaneName plane, int* equation) => _GetClipPlanexOES_fnptr(plane, equation);
            [UnmanagedCallersOnly]
            private static void GetClipPlanexOES_Lazy(ClipPlaneName plane, int* equation)
            {
                _GetClipPlanexOES_fnptr = (delegate* unmanaged<ClipPlaneName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetClipPlanexOES");
                _GetClipPlanexOES_fnptr(plane, equation);
            }
            
            private static delegate* unmanaged<GetPName, int*, void> _GetFixedvOES_fnptr = &GetFixedvOES_Lazy;
            public static void GetFixedvOES(GetPName pname, int* parameters) => _GetFixedvOES_fnptr(pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetFixedvOES_Lazy(GetPName pname, int* parameters)
            {
                _GetFixedvOES_fnptr = (delegate* unmanaged<GetPName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetFixedvOES");
                _GetFixedvOES_fnptr(pname, parameters);
            }
            
            private static delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void> _GetTexEnvxvOES_fnptr = &GetTexEnvxvOES_Lazy;
            public static void GetTexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => _GetTexEnvxvOES_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexEnvxvOES_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int* parameters)
            {
                _GetTexEnvxvOES_fnptr = (delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexEnvxvOES");
                _GetTexEnvxvOES_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void> _GetTexParameterxvOES_fnptr = &GetTexParameterxvOES_Lazy;
            public static void GetTexParameterxvOES(TextureTarget target, GetTextureParameter pname, int* parameters) => _GetTexParameterxvOES_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexParameterxvOES_Lazy(TextureTarget target, GetTextureParameter pname, int* parameters)
            {
                _GetTexParameterxvOES_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexParameterxvOES");
                _GetTexParameterxvOES_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<LightModelParameter, int, void> _LightModelxOES_fnptr = &LightModelxOES_Lazy;
            public static void LightModelxOES(LightModelParameter pname, int param) => _LightModelxOES_fnptr(pname, param);
            [UnmanagedCallersOnly]
            private static void LightModelxOES_Lazy(LightModelParameter pname, int param)
            {
                _LightModelxOES_fnptr = (delegate* unmanaged<LightModelParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glLightModelxOES");
                _LightModelxOES_fnptr(pname, param);
            }
            
            private static delegate* unmanaged<LightModelParameter, int*, void> _LightModelxvOES_fnptr = &LightModelxvOES_Lazy;
            public static void LightModelxvOES(LightModelParameter pname, int* param) => _LightModelxvOES_fnptr(pname, param);
            [UnmanagedCallersOnly]
            private static void LightModelxvOES_Lazy(LightModelParameter pname, int* param)
            {
                _LightModelxvOES_fnptr = (delegate* unmanaged<LightModelParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glLightModelxvOES");
                _LightModelxvOES_fnptr(pname, param);
            }
            
            private static delegate* unmanaged<LightName, LightParameter, int, void> _LightxOES_fnptr = &LightxOES_Lazy;
            public static void LightxOES(LightName light, LightParameter pname, int param) => _LightxOES_fnptr(light, pname, param);
            [UnmanagedCallersOnly]
            private static void LightxOES_Lazy(LightName light, LightParameter pname, int param)
            {
                _LightxOES_fnptr = (delegate* unmanaged<LightName, LightParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glLightxOES");
                _LightxOES_fnptr(light, pname, param);
            }
            
            private static delegate* unmanaged<LightName, LightParameter, int*, void> _LightxvOES_fnptr = &LightxvOES_Lazy;
            public static void LightxvOES(LightName light, LightParameter pname, int* parameters) => _LightxvOES_fnptr(light, pname, parameters);
            [UnmanagedCallersOnly]
            private static void LightxvOES_Lazy(LightName light, LightParameter pname, int* parameters)
            {
                _LightxvOES_fnptr = (delegate* unmanaged<LightName, LightParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glLightxvOES");
                _LightxvOES_fnptr(light, pname, parameters);
            }
            
            private static delegate* unmanaged<int, void> _LineWidthxOES_fnptr = &LineWidthxOES_Lazy;
            public static void LineWidthxOES(int width) => _LineWidthxOES_fnptr(width);
            [UnmanagedCallersOnly]
            private static void LineWidthxOES_Lazy(int width)
            {
                _LineWidthxOES_fnptr = (delegate* unmanaged<int, void>)GLLoader.BindingsContext.GetProcAddress("glLineWidthxOES");
                _LineWidthxOES_fnptr(width);
            }
            
            private static delegate* unmanaged<int*, void> _LoadMatrixxOES_fnptr = &LoadMatrixxOES_Lazy;
            public static void LoadMatrixxOES(int* m) => _LoadMatrixxOES_fnptr(m);
            [UnmanagedCallersOnly]
            private static void LoadMatrixxOES_Lazy(int* m)
            {
                _LoadMatrixxOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glLoadMatrixxOES");
                _LoadMatrixxOES_fnptr(m);
            }
            
            private static delegate* unmanaged<MaterialFace, MaterialParameter, int, void> _MaterialxOES_fnptr = &MaterialxOES_Lazy;
            public static void MaterialxOES(MaterialFace face, MaterialParameter pname, int param) => _MaterialxOES_fnptr(face, pname, param);
            [UnmanagedCallersOnly]
            private static void MaterialxOES_Lazy(MaterialFace face, MaterialParameter pname, int param)
            {
                _MaterialxOES_fnptr = (delegate* unmanaged<MaterialFace, MaterialParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glMaterialxOES");
                _MaterialxOES_fnptr(face, pname, param);
            }
            
            private static delegate* unmanaged<MaterialFace, MaterialParameter, int*, void> _MaterialxvOES_fnptr = &MaterialxvOES_Lazy;
            public static void MaterialxvOES(MaterialFace face, MaterialParameter pname, int* param) => _MaterialxvOES_fnptr(face, pname, param);
            [UnmanagedCallersOnly]
            private static void MaterialxvOES_Lazy(MaterialFace face, MaterialParameter pname, int* param)
            {
                _MaterialxvOES_fnptr = (delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glMaterialxvOES");
                _MaterialxvOES_fnptr(face, pname, param);
            }
            
            private static delegate* unmanaged<int*, void> _MultMatrixxOES_fnptr = &MultMatrixxOES_Lazy;
            public static void MultMatrixxOES(int* m) => _MultMatrixxOES_fnptr(m);
            [UnmanagedCallersOnly]
            private static void MultMatrixxOES_Lazy(int* m)
            {
                _MultMatrixxOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glMultMatrixxOES");
                _MultMatrixxOES_fnptr(m);
            }
            
            private static delegate* unmanaged<TextureUnit, int, int, int, int, void> _MultiTexCoord4xOES_fnptr = &MultiTexCoord4xOES_Lazy;
            public static void MultiTexCoord4xOES(TextureUnit texture, int s, int t, int r, int q) => _MultiTexCoord4xOES_fnptr(texture, s, t, r, q);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord4xOES_Lazy(TextureUnit texture, int s, int t, int r, int q)
            {
                _MultiTexCoord4xOES_fnptr = (delegate* unmanaged<TextureUnit, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord4xOES");
                _MultiTexCoord4xOES_fnptr(texture, s, t, r, q);
            }
            
            private static delegate* unmanaged<int, int, int, void> _Normal3xOES_fnptr = &Normal3xOES_Lazy;
            public static void Normal3xOES(int nx, int ny, int nz) => _Normal3xOES_fnptr(nx, ny, nz);
            [UnmanagedCallersOnly]
            private static void Normal3xOES_Lazy(int nx, int ny, int nz)
            {
                _Normal3xOES_fnptr = (delegate* unmanaged<int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glNormal3xOES");
                _Normal3xOES_fnptr(nx, ny, nz);
            }
            
            private static delegate* unmanaged<int, int, int, int, int, int, void> _OrthoxOES_fnptr = &OrthoxOES_Lazy;
            public static void OrthoxOES(int l, int r, int b, int t, int n, int f) => _OrthoxOES_fnptr(l, r, b, t, n, f);
            [UnmanagedCallersOnly]
            private static void OrthoxOES_Lazy(int l, int r, int b, int t, int n, int f)
            {
                _OrthoxOES_fnptr = (delegate* unmanaged<int, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glOrthoxOES");
                _OrthoxOES_fnptr(l, r, b, t, n, f);
            }
            
            private static delegate* unmanaged<PointParameterNameARB, int*, void> _PointParameterxvOES_fnptr = &PointParameterxvOES_Lazy;
            public static void PointParameterxvOES(PointParameterNameARB pname, int* parameters) => _PointParameterxvOES_fnptr(pname, parameters);
            [UnmanagedCallersOnly]
            private static void PointParameterxvOES_Lazy(PointParameterNameARB pname, int* parameters)
            {
                _PointParameterxvOES_fnptr = (delegate* unmanaged<PointParameterNameARB, int*, void>)GLLoader.BindingsContext.GetProcAddress("glPointParameterxvOES");
                _PointParameterxvOES_fnptr(pname, parameters);
            }
            
            private static delegate* unmanaged<int, void> _PointSizexOES_fnptr = &PointSizexOES_Lazy;
            public static void PointSizexOES(int size) => _PointSizexOES_fnptr(size);
            [UnmanagedCallersOnly]
            private static void PointSizexOES_Lazy(int size)
            {
                _PointSizexOES_fnptr = (delegate* unmanaged<int, void>)GLLoader.BindingsContext.GetProcAddress("glPointSizexOES");
                _PointSizexOES_fnptr(size);
            }
            
            private static delegate* unmanaged<int, int, void> _PolygonOffsetxOES_fnptr = &PolygonOffsetxOES_Lazy;
            public static void PolygonOffsetxOES(int factor, int units) => _PolygonOffsetxOES_fnptr(factor, units);
            [UnmanagedCallersOnly]
            private static void PolygonOffsetxOES_Lazy(int factor, int units)
            {
                _PolygonOffsetxOES_fnptr = (delegate* unmanaged<int, int, void>)GLLoader.BindingsContext.GetProcAddress("glPolygonOffsetxOES");
                _PolygonOffsetxOES_fnptr(factor, units);
            }
            
            private static delegate* unmanaged<int, int, int, int, void> _RotatexOES_fnptr = &RotatexOES_Lazy;
            public static void RotatexOES(int angle, int x, int y, int z) => _RotatexOES_fnptr(angle, x, y, z);
            [UnmanagedCallersOnly]
            private static void RotatexOES_Lazy(int angle, int x, int y, int z)
            {
                _RotatexOES_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRotatexOES");
                _RotatexOES_fnptr(angle, x, y, z);
            }
            
            private static delegate* unmanaged<int, int, int, void> _ScalexOES_fnptr = &ScalexOES_Lazy;
            public static void ScalexOES(int x, int y, int z) => _ScalexOES_fnptr(x, y, z);
            [UnmanagedCallersOnly]
            private static void ScalexOES_Lazy(int x, int y, int z)
            {
                _ScalexOES_fnptr = (delegate* unmanaged<int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glScalexOES");
                _ScalexOES_fnptr(x, y, z);
            }
            
            private static delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int, void> _TexEnvxOES_fnptr = &TexEnvxOES_Lazy;
            public static void TexEnvxOES(TextureEnvTarget target, TextureEnvParameter pname, int param) => _TexEnvxOES_fnptr(target, pname, param);
            [UnmanagedCallersOnly]
            private static void TexEnvxOES_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int param)
            {
                _TexEnvxOES_fnptr = (delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexEnvxOES");
                _TexEnvxOES_fnptr(target, pname, param);
            }
            
            private static delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void> _TexEnvxvOES_fnptr = &TexEnvxvOES_Lazy;
            public static void TexEnvxvOES(TextureEnvTarget target, TextureEnvParameter pname, int* parameters) => _TexEnvxvOES_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void TexEnvxvOES_Lazy(TextureEnvTarget target, TextureEnvParameter pname, int* parameters)
            {
                _TexEnvxvOES_fnptr = (delegate* unmanaged<TextureEnvTarget, TextureEnvParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexEnvxvOES");
                _TexEnvxvOES_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureTarget, GetTextureParameter, int, void> _TexParameterxOES_fnptr = &TexParameterxOES_Lazy;
            public static void TexParameterxOES(TextureTarget target, GetTextureParameter pname, int param) => _TexParameterxOES_fnptr(target, pname, param);
            [UnmanagedCallersOnly]
            private static void TexParameterxOES_Lazy(TextureTarget target, GetTextureParameter pname, int param)
            {
                _TexParameterxOES_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameterxOES");
                _TexParameterxOES_fnptr(target, pname, param);
            }
            
            private static delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void> _TexParameterxvOES_fnptr = &TexParameterxvOES_Lazy;
            public static void TexParameterxvOES(TextureTarget target, GetTextureParameter pname, int* parameters) => _TexParameterxvOES_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void TexParameterxvOES_Lazy(TextureTarget target, GetTextureParameter pname, int* parameters)
            {
                _TexParameterxvOES_fnptr = (delegate* unmanaged<TextureTarget, GetTextureParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexParameterxvOES");
                _TexParameterxvOES_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<int, int, int, void> _TranslatexOES_fnptr = &TranslatexOES_Lazy;
            public static void TranslatexOES(int x, int y, int z) => _TranslatexOES_fnptr(x, y, z);
            [UnmanagedCallersOnly]
            private static void TranslatexOES_Lazy(int x, int y, int z)
            {
                _TranslatexOES_fnptr = (delegate* unmanaged<int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glTranslatexOES");
                _TranslatexOES_fnptr(x, y, z);
            }
            
            private static delegate* unmanaged<LightName, LightParameter, int*, void> _GetLightxvOES_fnptr = &GetLightxvOES_Lazy;
            public static void GetLightxvOES(LightName light, LightParameter pname, int* parameters) => _GetLightxvOES_fnptr(light, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetLightxvOES_Lazy(LightName light, LightParameter pname, int* parameters)
            {
                _GetLightxvOES_fnptr = (delegate* unmanaged<LightName, LightParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetLightxvOES");
                _GetLightxvOES_fnptr(light, pname, parameters);
            }
            
            private static delegate* unmanaged<MaterialFace, MaterialParameter, int*, void> _GetMaterialxvOES_fnptr = &GetMaterialxvOES_Lazy;
            public static void GetMaterialxvOES(MaterialFace face, MaterialParameter pname, int* parameters) => _GetMaterialxvOES_fnptr(face, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetMaterialxvOES_Lazy(MaterialFace face, MaterialParameter pname, int* parameters)
            {
                _GetMaterialxvOES_fnptr = (delegate* unmanaged<MaterialFace, MaterialParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetMaterialxvOES");
                _GetMaterialxvOES_fnptr(face, pname, parameters);
            }
            
            private static delegate* unmanaged<PointParameterNameARB, int, void> _PointParameterxOES_fnptr = &PointParameterxOES_Lazy;
            public static void PointParameterxOES(PointParameterNameARB pname, int param) => _PointParameterxOES_fnptr(pname, param);
            [UnmanagedCallersOnly]
            private static void PointParameterxOES_Lazy(PointParameterNameARB pname, int param)
            {
                _PointParameterxOES_fnptr = (delegate* unmanaged<PointParameterNameARB, int, void>)GLLoader.BindingsContext.GetProcAddress("glPointParameterxOES");
                _PointParameterxOES_fnptr(pname, param);
            }
            
            private static delegate* unmanaged<int, byte, void> _SampleCoveragexOES_fnptr = &SampleCoveragexOES_Lazy;
            public static void SampleCoveragexOES(int value, byte invert) => _SampleCoveragexOES_fnptr(value, invert);
            [UnmanagedCallersOnly]
            private static void SampleCoveragexOES_Lazy(int value, byte invert)
            {
                _SampleCoveragexOES_fnptr = (delegate* unmanaged<int, byte, void>)GLLoader.BindingsContext.GetProcAddress("glSampleCoveragexOES");
                _SampleCoveragexOES_fnptr(value, invert);
            }
            
            private static delegate* unmanaged<All, int, void> _AccumxOES_fnptr = &AccumxOES_Lazy;
            public static void AccumxOES(All op, int value) => _AccumxOES_fnptr(op, value);
            [UnmanagedCallersOnly]
            private static void AccumxOES_Lazy(All op, int value)
            {
                _AccumxOES_fnptr = (delegate* unmanaged<All, int, void>)GLLoader.BindingsContext.GetProcAddress("glAccumxOES");
                _AccumxOES_fnptr(op, value);
            }
            
            private static delegate* unmanaged<int, int, int, int, int, int, byte*, void> _BitmapxOES_fnptr = &BitmapxOES_Lazy;
            public static void BitmapxOES(int width, int height, int xorig, int yorig, int xmove, int ymove, byte* bitmap) => _BitmapxOES_fnptr(width, height, xorig, yorig, xmove, ymove, bitmap);
            [UnmanagedCallersOnly]
            private static void BitmapxOES_Lazy(int width, int height, int xorig, int yorig, int xmove, int ymove, byte* bitmap)
            {
                _BitmapxOES_fnptr = (delegate* unmanaged<int, int, int, int, int, int, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glBitmapxOES");
                _BitmapxOES_fnptr(width, height, xorig, yorig, xmove, ymove, bitmap);
            }
            
            private static delegate* unmanaged<int, int, int, int, void> _BlendColorxOES_fnptr = &BlendColorxOES_Lazy;
            public static void BlendColorxOES(int red, int green, int blue, int alpha) => _BlendColorxOES_fnptr(red, green, blue, alpha);
            [UnmanagedCallersOnly]
            private static void BlendColorxOES_Lazy(int red, int green, int blue, int alpha)
            {
                _BlendColorxOES_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glBlendColorxOES");
                _BlendColorxOES_fnptr(red, green, blue, alpha);
            }
            
            private static delegate* unmanaged<int, int, int, int, void> _ClearAccumxOES_fnptr = &ClearAccumxOES_Lazy;
            public static void ClearAccumxOES(int red, int green, int blue, int alpha) => _ClearAccumxOES_fnptr(red, green, blue, alpha);
            [UnmanagedCallersOnly]
            private static void ClearAccumxOES_Lazy(int red, int green, int blue, int alpha)
            {
                _ClearAccumxOES_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glClearAccumxOES");
                _ClearAccumxOES_fnptr(red, green, blue, alpha);
            }
            
            private static delegate* unmanaged<int, int, int, void> _Color3xOES_fnptr = &Color3xOES_Lazy;
            public static void Color3xOES(int red, int green, int blue) => _Color3xOES_fnptr(red, green, blue);
            [UnmanagedCallersOnly]
            private static void Color3xOES_Lazy(int red, int green, int blue)
            {
                _Color3xOES_fnptr = (delegate* unmanaged<int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glColor3xOES");
                _Color3xOES_fnptr(red, green, blue);
            }
            
            private static delegate* unmanaged<int*, void> _Color3xvOES_fnptr = &Color3xvOES_Lazy;
            public static void Color3xvOES(int* components) => _Color3xvOES_fnptr(components);
            [UnmanagedCallersOnly]
            private static void Color3xvOES_Lazy(int* components)
            {
                _Color3xvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glColor3xvOES");
                _Color3xvOES_fnptr(components);
            }
            
            private static delegate* unmanaged<int*, void> _Color4xvOES_fnptr = &Color4xvOES_Lazy;
            public static void Color4xvOES(int* components) => _Color4xvOES_fnptr(components);
            [UnmanagedCallersOnly]
            private static void Color4xvOES_Lazy(int* components)
            {
                _Color4xvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glColor4xvOES");
                _Color4xvOES_fnptr(components);
            }
            
            private static delegate* unmanaged<ConvolutionTargetEXT, ConvolutionParameterEXT, int, void> _ConvolutionParameterxOES_fnptr = &ConvolutionParameterxOES_Lazy;
            public static void ConvolutionParameterxOES(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int param) => _ConvolutionParameterxOES_fnptr(target, pname, param);
            [UnmanagedCallersOnly]
            private static void ConvolutionParameterxOES_Lazy(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int param)
            {
                _ConvolutionParameterxOES_fnptr = (delegate* unmanaged<ConvolutionTargetEXT, ConvolutionParameterEXT, int, void>)GLLoader.BindingsContext.GetProcAddress("glConvolutionParameterxOES");
                _ConvolutionParameterxOES_fnptr(target, pname, param);
            }
            
            private static delegate* unmanaged<ConvolutionTargetEXT, ConvolutionParameterEXT, int*, void> _ConvolutionParameterxvOES_fnptr = &ConvolutionParameterxvOES_Lazy;
            public static void ConvolutionParameterxvOES(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int* parameters) => _ConvolutionParameterxvOES_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void ConvolutionParameterxvOES_Lazy(ConvolutionTargetEXT target, ConvolutionParameterEXT pname, int* parameters)
            {
                _ConvolutionParameterxvOES_fnptr = (delegate* unmanaged<ConvolutionTargetEXT, ConvolutionParameterEXT, int*, void>)GLLoader.BindingsContext.GetProcAddress("glConvolutionParameterxvOES");
                _ConvolutionParameterxvOES_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<int, void> _EvalCoord1xOES_fnptr = &EvalCoord1xOES_Lazy;
            public static void EvalCoord1xOES(int u) => _EvalCoord1xOES_fnptr(u);
            [UnmanagedCallersOnly]
            private static void EvalCoord1xOES_Lazy(int u)
            {
                _EvalCoord1xOES_fnptr = (delegate* unmanaged<int, void>)GLLoader.BindingsContext.GetProcAddress("glEvalCoord1xOES");
                _EvalCoord1xOES_fnptr(u);
            }
            
            private static delegate* unmanaged<int*, void> _EvalCoord1xvOES_fnptr = &EvalCoord1xvOES_Lazy;
            public static void EvalCoord1xvOES(int* coords) => _EvalCoord1xvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void EvalCoord1xvOES_Lazy(int* coords)
            {
                _EvalCoord1xvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glEvalCoord1xvOES");
                _EvalCoord1xvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<int, int, void> _EvalCoord2xOES_fnptr = &EvalCoord2xOES_Lazy;
            public static void EvalCoord2xOES(int u, int v) => _EvalCoord2xOES_fnptr(u, v);
            [UnmanagedCallersOnly]
            private static void EvalCoord2xOES_Lazy(int u, int v)
            {
                _EvalCoord2xOES_fnptr = (delegate* unmanaged<int, int, void>)GLLoader.BindingsContext.GetProcAddress("glEvalCoord2xOES");
                _EvalCoord2xOES_fnptr(u, v);
            }
            
            private static delegate* unmanaged<int*, void> _EvalCoord2xvOES_fnptr = &EvalCoord2xvOES_Lazy;
            public static void EvalCoord2xvOES(int* coords) => _EvalCoord2xvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void EvalCoord2xvOES_Lazy(int* coords)
            {
                _EvalCoord2xvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glEvalCoord2xvOES");
                _EvalCoord2xvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<int, All, int*, void> _FeedbackBufferxOES_fnptr = &FeedbackBufferxOES_Lazy;
            public static void FeedbackBufferxOES(int n, All type, int* buffer) => _FeedbackBufferxOES_fnptr(n, type, buffer);
            [UnmanagedCallersOnly]
            private static void FeedbackBufferxOES_Lazy(int n, All type, int* buffer)
            {
                _FeedbackBufferxOES_fnptr = (delegate* unmanaged<int, All, int*, void>)GLLoader.BindingsContext.GetProcAddress("glFeedbackBufferxOES");
                _FeedbackBufferxOES_fnptr(n, type, buffer);
            }
            
            private static delegate* unmanaged<All, All, int*, void> _GetConvolutionParameterxvOES_fnptr = &GetConvolutionParameterxvOES_Lazy;
            public static void GetConvolutionParameterxvOES(All target, All pname, int* parameters) => _GetConvolutionParameterxvOES_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetConvolutionParameterxvOES_Lazy(All target, All pname, int* parameters)
            {
                _GetConvolutionParameterxvOES_fnptr = (delegate* unmanaged<All, All, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetConvolutionParameterxvOES");
                _GetConvolutionParameterxvOES_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<HistogramTargetEXT, GetHistogramParameterPNameEXT, int*, void> _GetHistogramParameterxvOES_fnptr = &GetHistogramParameterxvOES_Lazy;
            public static void GetHistogramParameterxvOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int* parameters) => _GetHistogramParameterxvOES_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetHistogramParameterxvOES_Lazy(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, int* parameters)
            {
                _GetHistogramParameterxvOES_fnptr = (delegate* unmanaged<HistogramTargetEXT, GetHistogramParameterPNameEXT, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetHistogramParameterxvOES");
                _GetHistogramParameterxvOES_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<LightName, LightParameter, int*, void> _GetLightxOES_fnptr = &GetLightxOES_Lazy;
            public static void GetLightxOES(LightName light, LightParameter pname, int* parameters) => _GetLightxOES_fnptr(light, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetLightxOES_Lazy(LightName light, LightParameter pname, int* parameters)
            {
                _GetLightxOES_fnptr = (delegate* unmanaged<LightName, LightParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetLightxOES");
                _GetLightxOES_fnptr(light, pname, parameters);
            }
            
            private static delegate* unmanaged<MapTarget, GetMapQuery, int*, void> _GetMapxvOES_fnptr = &GetMapxvOES_Lazy;
            public static void GetMapxvOES(MapTarget target, GetMapQuery query, int* v) => _GetMapxvOES_fnptr(target, query, v);
            [UnmanagedCallersOnly]
            private static void GetMapxvOES_Lazy(MapTarget target, GetMapQuery query, int* v)
            {
                _GetMapxvOES_fnptr = (delegate* unmanaged<MapTarget, GetMapQuery, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetMapxvOES");
                _GetMapxvOES_fnptr(target, query, v);
            }
            
            private static delegate* unmanaged<MaterialFace, MaterialParameter, int, void> _GetMaterialxOES_fnptr = &GetMaterialxOES_Lazy;
            public static void GetMaterialxOES(MaterialFace face, MaterialParameter pname, int param) => _GetMaterialxOES_fnptr(face, pname, param);
            [UnmanagedCallersOnly]
            private static void GetMaterialxOES_Lazy(MaterialFace face, MaterialParameter pname, int param)
            {
                _GetMaterialxOES_fnptr = (delegate* unmanaged<MaterialFace, MaterialParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glGetMaterialxOES");
                _GetMaterialxOES_fnptr(face, pname, param);
            }
            
            private static delegate* unmanaged<PixelMap, int, int*, void> _GetPixelMapxv_fnptr = &GetPixelMapxv_Lazy;
            public static void GetPixelMapxv(PixelMap map, int size, int* values) => _GetPixelMapxv_fnptr(map, size, values);
            [UnmanagedCallersOnly]
            private static void GetPixelMapxv_Lazy(PixelMap map, int size, int* values)
            {
                _GetPixelMapxv_fnptr = (delegate* unmanaged<PixelMap, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetPixelMapxv");
                _GetPixelMapxv_fnptr(map, size, values);
            }
            
            private static delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void> _GetTexGenxvOES_fnptr = &GetTexGenxvOES_Lazy;
            public static void GetTexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => _GetTexGenxvOES_fnptr(coord, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexGenxvOES_Lazy(TextureCoordName coord, TextureGenParameter pname, int* parameters)
            {
                _GetTexGenxvOES_fnptr = (delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexGenxvOES");
                _GetTexGenxvOES_fnptr(coord, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureTarget, int, GetTextureParameter, int*, void> _GetTexLevelParameterxvOES_fnptr = &GetTexLevelParameterxvOES_Lazy;
            public static void GetTexLevelParameterxvOES(TextureTarget target, int level, GetTextureParameter pname, int* parameters) => _GetTexLevelParameterxvOES_fnptr(target, level, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexLevelParameterxvOES_Lazy(TextureTarget target, int level, GetTextureParameter pname, int* parameters)
            {
                _GetTexLevelParameterxvOES_fnptr = (delegate* unmanaged<TextureTarget, int, GetTextureParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexLevelParameterxvOES");
                _GetTexLevelParameterxvOES_fnptr(target, level, pname, parameters);
            }
            
            private static delegate* unmanaged<int, void> _IndexxOES_fnptr = &IndexxOES_Lazy;
            public static void IndexxOES(int component) => _IndexxOES_fnptr(component);
            [UnmanagedCallersOnly]
            private static void IndexxOES_Lazy(int component)
            {
                _IndexxOES_fnptr = (delegate* unmanaged<int, void>)GLLoader.BindingsContext.GetProcAddress("glIndexxOES");
                _IndexxOES_fnptr(component);
            }
            
            private static delegate* unmanaged<int*, void> _IndexxvOES_fnptr = &IndexxvOES_Lazy;
            public static void IndexxvOES(int* component) => _IndexxvOES_fnptr(component);
            [UnmanagedCallersOnly]
            private static void IndexxvOES_Lazy(int* component)
            {
                _IndexxvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glIndexxvOES");
                _IndexxvOES_fnptr(component);
            }
            
            private static delegate* unmanaged<int*, void> _LoadTransposeMatrixxOES_fnptr = &LoadTransposeMatrixxOES_Lazy;
            public static void LoadTransposeMatrixxOES(int* m) => _LoadTransposeMatrixxOES_fnptr(m);
            [UnmanagedCallersOnly]
            private static void LoadTransposeMatrixxOES_Lazy(int* m)
            {
                _LoadTransposeMatrixxOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glLoadTransposeMatrixxOES");
                _LoadTransposeMatrixxOES_fnptr(m);
            }
            
            private static delegate* unmanaged<MapTarget, int, int, int, int, int, void> _Map1xOES_fnptr = &Map1xOES_Lazy;
            public static void Map1xOES(MapTarget target, int u1, int u2, int stride, int order, int points) => _Map1xOES_fnptr(target, u1, u2, stride, order, points);
            [UnmanagedCallersOnly]
            private static void Map1xOES_Lazy(MapTarget target, int u1, int u2, int stride, int order, int points)
            {
                _Map1xOES_fnptr = (delegate* unmanaged<MapTarget, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glMap1xOES");
                _Map1xOES_fnptr(target, u1, u2, stride, order, points);
            }
            
            private static delegate* unmanaged<MapTarget, int, int, int, int, int, int, int, int, int, void> _Map2xOES_fnptr = &Map2xOES_Lazy;
            public static void Map2xOES(MapTarget target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points) => _Map2xOES_fnptr(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
            [UnmanagedCallersOnly]
            private static void Map2xOES_Lazy(MapTarget target, int u1, int u2, int ustride, int uorder, int v1, int v2, int vstride, int vorder, int points)
            {
                _Map2xOES_fnptr = (delegate* unmanaged<MapTarget, int, int, int, int, int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glMap2xOES");
                _Map2xOES_fnptr(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
            }
            
            private static delegate* unmanaged<int, int, int, void> _MapGrid1xOES_fnptr = &MapGrid1xOES_Lazy;
            public static void MapGrid1xOES(int n, int u1, int u2) => _MapGrid1xOES_fnptr(n, u1, u2);
            [UnmanagedCallersOnly]
            private static void MapGrid1xOES_Lazy(int n, int u1, int u2)
            {
                _MapGrid1xOES_fnptr = (delegate* unmanaged<int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glMapGrid1xOES");
                _MapGrid1xOES_fnptr(n, u1, u2);
            }
            
            private static delegate* unmanaged<int, int, int, int, int, void> _MapGrid2xOES_fnptr = &MapGrid2xOES_Lazy;
            public static void MapGrid2xOES(int n, int u1, int u2, int v1, int v2) => _MapGrid2xOES_fnptr(n, u1, u2, v1, v2);
            [UnmanagedCallersOnly]
            private static void MapGrid2xOES_Lazy(int n, int u1, int u2, int v1, int v2)
            {
                _MapGrid2xOES_fnptr = (delegate* unmanaged<int, int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glMapGrid2xOES");
                _MapGrid2xOES_fnptr(n, u1, u2, v1, v2);
            }
            
            private static delegate* unmanaged<int*, void> _MultTransposeMatrixxOES_fnptr = &MultTransposeMatrixxOES_Lazy;
            public static void MultTransposeMatrixxOES(int* m) => _MultTransposeMatrixxOES_fnptr(m);
            [UnmanagedCallersOnly]
            private static void MultTransposeMatrixxOES_Lazy(int* m)
            {
                _MultTransposeMatrixxOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glMultTransposeMatrixxOES");
                _MultTransposeMatrixxOES_fnptr(m);
            }
            
            private static delegate* unmanaged<TextureUnit, int, void> _MultiTexCoord1xOES_fnptr = &MultiTexCoord1xOES_Lazy;
            public static void MultiTexCoord1xOES(TextureUnit texture, int s) => _MultiTexCoord1xOES_fnptr(texture, s);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord1xOES_Lazy(TextureUnit texture, int s)
            {
                _MultiTexCoord1xOES_fnptr = (delegate* unmanaged<TextureUnit, int, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord1xOES");
                _MultiTexCoord1xOES_fnptr(texture, s);
            }
            
            private static delegate* unmanaged<TextureUnit, int*, void> _MultiTexCoord1xvOES_fnptr = &MultiTexCoord1xvOES_Lazy;
            public static void MultiTexCoord1xvOES(TextureUnit texture, int* coords) => _MultiTexCoord1xvOES_fnptr(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord1xvOES_Lazy(TextureUnit texture, int* coords)
            {
                _MultiTexCoord1xvOES_fnptr = (delegate* unmanaged<TextureUnit, int*, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord1xvOES");
                _MultiTexCoord1xvOES_fnptr(texture, coords);
            }
            
            private static delegate* unmanaged<TextureUnit, int, int, void> _MultiTexCoord2xOES_fnptr = &MultiTexCoord2xOES_Lazy;
            public static void MultiTexCoord2xOES(TextureUnit texture, int s, int t) => _MultiTexCoord2xOES_fnptr(texture, s, t);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord2xOES_Lazy(TextureUnit texture, int s, int t)
            {
                _MultiTexCoord2xOES_fnptr = (delegate* unmanaged<TextureUnit, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord2xOES");
                _MultiTexCoord2xOES_fnptr(texture, s, t);
            }
            
            private static delegate* unmanaged<TextureUnit, int*, void> _MultiTexCoord2xvOES_fnptr = &MultiTexCoord2xvOES_Lazy;
            public static void MultiTexCoord2xvOES(TextureUnit texture, int* coords) => _MultiTexCoord2xvOES_fnptr(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord2xvOES_Lazy(TextureUnit texture, int* coords)
            {
                _MultiTexCoord2xvOES_fnptr = (delegate* unmanaged<TextureUnit, int*, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord2xvOES");
                _MultiTexCoord2xvOES_fnptr(texture, coords);
            }
            
            private static delegate* unmanaged<TextureUnit, int, int, int, void> _MultiTexCoord3xOES_fnptr = &MultiTexCoord3xOES_Lazy;
            public static void MultiTexCoord3xOES(TextureUnit texture, int s, int t, int r) => _MultiTexCoord3xOES_fnptr(texture, s, t, r);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord3xOES_Lazy(TextureUnit texture, int s, int t, int r)
            {
                _MultiTexCoord3xOES_fnptr = (delegate* unmanaged<TextureUnit, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord3xOES");
                _MultiTexCoord3xOES_fnptr(texture, s, t, r);
            }
            
            private static delegate* unmanaged<TextureUnit, int*, void> _MultiTexCoord3xvOES_fnptr = &MultiTexCoord3xvOES_Lazy;
            public static void MultiTexCoord3xvOES(TextureUnit texture, int* coords) => _MultiTexCoord3xvOES_fnptr(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord3xvOES_Lazy(TextureUnit texture, int* coords)
            {
                _MultiTexCoord3xvOES_fnptr = (delegate* unmanaged<TextureUnit, int*, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord3xvOES");
                _MultiTexCoord3xvOES_fnptr(texture, coords);
            }
            
            private static delegate* unmanaged<TextureUnit, int*, void> _MultiTexCoord4xvOES_fnptr = &MultiTexCoord4xvOES_Lazy;
            public static void MultiTexCoord4xvOES(TextureUnit texture, int* coords) => _MultiTexCoord4xvOES_fnptr(texture, coords);
            [UnmanagedCallersOnly]
            private static void MultiTexCoord4xvOES_Lazy(TextureUnit texture, int* coords)
            {
                _MultiTexCoord4xvOES_fnptr = (delegate* unmanaged<TextureUnit, int*, void>)GLLoader.BindingsContext.GetProcAddress("glMultiTexCoord4xvOES");
                _MultiTexCoord4xvOES_fnptr(texture, coords);
            }
            
            private static delegate* unmanaged<int*, void> _Normal3xvOES_fnptr = &Normal3xvOES_Lazy;
            public static void Normal3xvOES(int* coords) => _Normal3xvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void Normal3xvOES_Lazy(int* coords)
            {
                _Normal3xvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glNormal3xvOES");
                _Normal3xvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<int, void> _PassThroughxOES_fnptr = &PassThroughxOES_Lazy;
            public static void PassThroughxOES(int token) => _PassThroughxOES_fnptr(token);
            [UnmanagedCallersOnly]
            private static void PassThroughxOES_Lazy(int token)
            {
                _PassThroughxOES_fnptr = (delegate* unmanaged<int, void>)GLLoader.BindingsContext.GetProcAddress("glPassThroughxOES");
                _PassThroughxOES_fnptr(token);
            }
            
            private static delegate* unmanaged<PixelMap, int, int*, void> _PixelMapx_fnptr = &PixelMapx_Lazy;
            public static void PixelMapx(PixelMap map, int size, int* values) => _PixelMapx_fnptr(map, size, values);
            [UnmanagedCallersOnly]
            private static void PixelMapx_Lazy(PixelMap map, int size, int* values)
            {
                _PixelMapx_fnptr = (delegate* unmanaged<PixelMap, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glPixelMapx");
                _PixelMapx_fnptr(map, size, values);
            }
            
            private static delegate* unmanaged<PixelStoreParameter, int, void> _PixelStorex_fnptr = &PixelStorex_Lazy;
            public static void PixelStorex(PixelStoreParameter pname, int param) => _PixelStorex_fnptr(pname, param);
            [UnmanagedCallersOnly]
            private static void PixelStorex_Lazy(PixelStoreParameter pname, int param)
            {
                _PixelStorex_fnptr = (delegate* unmanaged<PixelStoreParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glPixelStorex");
                _PixelStorex_fnptr(pname, param);
            }
            
            private static delegate* unmanaged<PixelTransferParameter, int, void> _PixelTransferxOES_fnptr = &PixelTransferxOES_Lazy;
            public static void PixelTransferxOES(PixelTransferParameter pname, int param) => _PixelTransferxOES_fnptr(pname, param);
            [UnmanagedCallersOnly]
            private static void PixelTransferxOES_Lazy(PixelTransferParameter pname, int param)
            {
                _PixelTransferxOES_fnptr = (delegate* unmanaged<PixelTransferParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glPixelTransferxOES");
                _PixelTransferxOES_fnptr(pname, param);
            }
            
            private static delegate* unmanaged<int, int, void> _PixelZoomxOES_fnptr = &PixelZoomxOES_Lazy;
            public static void PixelZoomxOES(int xfactor, int yfactor) => _PixelZoomxOES_fnptr(xfactor, yfactor);
            [UnmanagedCallersOnly]
            private static void PixelZoomxOES_Lazy(int xfactor, int yfactor)
            {
                _PixelZoomxOES_fnptr = (delegate* unmanaged<int, int, void>)GLLoader.BindingsContext.GetProcAddress("glPixelZoomxOES");
                _PixelZoomxOES_fnptr(xfactor, yfactor);
            }
            
            private static delegate* unmanaged<int, TextureHandle*, int*, void> _PrioritizeTexturesxOES_fnptr = &PrioritizeTexturesxOES_Lazy;
            public static void PrioritizeTexturesxOES(int n, TextureHandle* textures, int* priorities) => _PrioritizeTexturesxOES_fnptr(n, textures, priorities);
            [UnmanagedCallersOnly]
            private static void PrioritizeTexturesxOES_Lazy(int n, TextureHandle* textures, int* priorities)
            {
                _PrioritizeTexturesxOES_fnptr = (delegate* unmanaged<int, TextureHandle*, int*, void>)GLLoader.BindingsContext.GetProcAddress("glPrioritizeTexturesxOES");
                _PrioritizeTexturesxOES_fnptr(n, textures, priorities);
            }
            
            private static delegate* unmanaged<int, int, void> _RasterPos2xOES_fnptr = &RasterPos2xOES_Lazy;
            public static void RasterPos2xOES(int x, int y) => _RasterPos2xOES_fnptr(x, y);
            [UnmanagedCallersOnly]
            private static void RasterPos2xOES_Lazy(int x, int y)
            {
                _RasterPos2xOES_fnptr = (delegate* unmanaged<int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRasterPos2xOES");
                _RasterPos2xOES_fnptr(x, y);
            }
            
            private static delegate* unmanaged<int*, void> _RasterPos2xvOES_fnptr = &RasterPos2xvOES_Lazy;
            public static void RasterPos2xvOES(int* coords) => _RasterPos2xvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void RasterPos2xvOES_Lazy(int* coords)
            {
                _RasterPos2xvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glRasterPos2xvOES");
                _RasterPos2xvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<int, int, int, void> _RasterPos3xOES_fnptr = &RasterPos3xOES_Lazy;
            public static void RasterPos3xOES(int x, int y, int z) => _RasterPos3xOES_fnptr(x, y, z);
            [UnmanagedCallersOnly]
            private static void RasterPos3xOES_Lazy(int x, int y, int z)
            {
                _RasterPos3xOES_fnptr = (delegate* unmanaged<int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRasterPos3xOES");
                _RasterPos3xOES_fnptr(x, y, z);
            }
            
            private static delegate* unmanaged<int*, void> _RasterPos3xvOES_fnptr = &RasterPos3xvOES_Lazy;
            public static void RasterPos3xvOES(int* coords) => _RasterPos3xvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void RasterPos3xvOES_Lazy(int* coords)
            {
                _RasterPos3xvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glRasterPos3xvOES");
                _RasterPos3xvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<int, int, int, int, void> _RasterPos4xOES_fnptr = &RasterPos4xOES_Lazy;
            public static void RasterPos4xOES(int x, int y, int z, int w) => _RasterPos4xOES_fnptr(x, y, z, w);
            [UnmanagedCallersOnly]
            private static void RasterPos4xOES_Lazy(int x, int y, int z, int w)
            {
                _RasterPos4xOES_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRasterPos4xOES");
                _RasterPos4xOES_fnptr(x, y, z, w);
            }
            
            private static delegate* unmanaged<int*, void> _RasterPos4xvOES_fnptr = &RasterPos4xvOES_Lazy;
            public static void RasterPos4xvOES(int* coords) => _RasterPos4xvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void RasterPos4xvOES_Lazy(int* coords)
            {
                _RasterPos4xvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glRasterPos4xvOES");
                _RasterPos4xvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<int, int, int, int, void> _RectxOES_fnptr = &RectxOES_Lazy;
            public static void RectxOES(int x1, int y1, int x2, int y2) => _RectxOES_fnptr(x1, y1, x2, y2);
            [UnmanagedCallersOnly]
            private static void RectxOES_Lazy(int x1, int y1, int x2, int y2)
            {
                _RectxOES_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRectxOES");
                _RectxOES_fnptr(x1, y1, x2, y2);
            }
            
            private static delegate* unmanaged<int*, int*, void> _RectxvOES_fnptr = &RectxvOES_Lazy;
            public static void RectxvOES(int* v1, int* v2) => _RectxvOES_fnptr(v1, v2);
            [UnmanagedCallersOnly]
            private static void RectxvOES_Lazy(int* v1, int* v2)
            {
                _RectxvOES_fnptr = (delegate* unmanaged<int*, int*, void>)GLLoader.BindingsContext.GetProcAddress("glRectxvOES");
                _RectxvOES_fnptr(v1, v2);
            }
            
            private static delegate* unmanaged<int, void> _TexCoord1xOES_fnptr = &TexCoord1xOES_Lazy;
            public static void TexCoord1xOES(int s) => _TexCoord1xOES_fnptr(s);
            [UnmanagedCallersOnly]
            private static void TexCoord1xOES_Lazy(int s)
            {
                _TexCoord1xOES_fnptr = (delegate* unmanaged<int, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord1xOES");
                _TexCoord1xOES_fnptr(s);
            }
            
            private static delegate* unmanaged<int*, void> _TexCoord1xvOES_fnptr = &TexCoord1xvOES_Lazy;
            public static void TexCoord1xvOES(int* coords) => _TexCoord1xvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord1xvOES_Lazy(int* coords)
            {
                _TexCoord1xvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord1xvOES");
                _TexCoord1xvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<int, int, void> _TexCoord2xOES_fnptr = &TexCoord2xOES_Lazy;
            public static void TexCoord2xOES(int s, int t) => _TexCoord2xOES_fnptr(s, t);
            [UnmanagedCallersOnly]
            private static void TexCoord2xOES_Lazy(int s, int t)
            {
                _TexCoord2xOES_fnptr = (delegate* unmanaged<int, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord2xOES");
                _TexCoord2xOES_fnptr(s, t);
            }
            
            private static delegate* unmanaged<int*, void> _TexCoord2xvOES_fnptr = &TexCoord2xvOES_Lazy;
            public static void TexCoord2xvOES(int* coords) => _TexCoord2xvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord2xvOES_Lazy(int* coords)
            {
                _TexCoord2xvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord2xvOES");
                _TexCoord2xvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<int, int, int, void> _TexCoord3xOES_fnptr = &TexCoord3xOES_Lazy;
            public static void TexCoord3xOES(int s, int t, int r) => _TexCoord3xOES_fnptr(s, t, r);
            [UnmanagedCallersOnly]
            private static void TexCoord3xOES_Lazy(int s, int t, int r)
            {
                _TexCoord3xOES_fnptr = (delegate* unmanaged<int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord3xOES");
                _TexCoord3xOES_fnptr(s, t, r);
            }
            
            private static delegate* unmanaged<int*, void> _TexCoord3xvOES_fnptr = &TexCoord3xvOES_Lazy;
            public static void TexCoord3xvOES(int* coords) => _TexCoord3xvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord3xvOES_Lazy(int* coords)
            {
                _TexCoord3xvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord3xvOES");
                _TexCoord3xvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<int, int, int, int, void> _TexCoord4xOES_fnptr = &TexCoord4xOES_Lazy;
            public static void TexCoord4xOES(int s, int t, int r, int q) => _TexCoord4xOES_fnptr(s, t, r, q);
            [UnmanagedCallersOnly]
            private static void TexCoord4xOES_Lazy(int s, int t, int r, int q)
            {
                _TexCoord4xOES_fnptr = (delegate* unmanaged<int, int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord4xOES");
                _TexCoord4xOES_fnptr(s, t, r, q);
            }
            
            private static delegate* unmanaged<int*, void> _TexCoord4xvOES_fnptr = &TexCoord4xvOES_Lazy;
            public static void TexCoord4xvOES(int* coords) => _TexCoord4xvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void TexCoord4xvOES_Lazy(int* coords)
            {
                _TexCoord4xvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexCoord4xvOES");
                _TexCoord4xvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<TextureCoordName, TextureGenParameter, int, void> _TexGenxOES_fnptr = &TexGenxOES_Lazy;
            public static void TexGenxOES(TextureCoordName coord, TextureGenParameter pname, int param) => _TexGenxOES_fnptr(coord, pname, param);
            [UnmanagedCallersOnly]
            private static void TexGenxOES_Lazy(TextureCoordName coord, TextureGenParameter pname, int param)
            {
                _TexGenxOES_fnptr = (delegate* unmanaged<TextureCoordName, TextureGenParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexGenxOES");
                _TexGenxOES_fnptr(coord, pname, param);
            }
            
            private static delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void> _TexGenxvOES_fnptr = &TexGenxvOES_Lazy;
            public static void TexGenxvOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => _TexGenxvOES_fnptr(coord, pname, parameters);
            [UnmanagedCallersOnly]
            private static void TexGenxvOES_Lazy(TextureCoordName coord, TextureGenParameter pname, int* parameters)
            {
                _TexGenxvOES_fnptr = (delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexGenxvOES");
                _TexGenxvOES_fnptr(coord, pname, parameters);
            }
            
            private static delegate* unmanaged<int, void> _Vertex2xOES_fnptr = &Vertex2xOES_Lazy;
            public static void Vertex2xOES(int x) => _Vertex2xOES_fnptr(x);
            [UnmanagedCallersOnly]
            private static void Vertex2xOES_Lazy(int x)
            {
                _Vertex2xOES_fnptr = (delegate* unmanaged<int, void>)GLLoader.BindingsContext.GetProcAddress("glVertex2xOES");
                _Vertex2xOES_fnptr(x);
            }
            
            private static delegate* unmanaged<int*, void> _Vertex2xvOES_fnptr = &Vertex2xvOES_Lazy;
            public static void Vertex2xvOES(int* coords) => _Vertex2xvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void Vertex2xvOES_Lazy(int* coords)
            {
                _Vertex2xvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glVertex2xvOES");
                _Vertex2xvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<int, int, void> _Vertex3xOES_fnptr = &Vertex3xOES_Lazy;
            public static void Vertex3xOES(int x, int y) => _Vertex3xOES_fnptr(x, y);
            [UnmanagedCallersOnly]
            private static void Vertex3xOES_Lazy(int x, int y)
            {
                _Vertex3xOES_fnptr = (delegate* unmanaged<int, int, void>)GLLoader.BindingsContext.GetProcAddress("glVertex3xOES");
                _Vertex3xOES_fnptr(x, y);
            }
            
            private static delegate* unmanaged<int*, void> _Vertex3xvOES_fnptr = &Vertex3xvOES_Lazy;
            public static void Vertex3xvOES(int* coords) => _Vertex3xvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void Vertex3xvOES_Lazy(int* coords)
            {
                _Vertex3xvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glVertex3xvOES");
                _Vertex3xvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<int, int, int, void> _Vertex4xOES_fnptr = &Vertex4xOES_Lazy;
            public static void Vertex4xOES(int x, int y, int z) => _Vertex4xOES_fnptr(x, y, z);
            [UnmanagedCallersOnly]
            private static void Vertex4xOES_Lazy(int x, int y, int z)
            {
                _Vertex4xOES_fnptr = (delegate* unmanaged<int, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glVertex4xOES");
                _Vertex4xOES_fnptr(x, y, z);
            }
            
            private static delegate* unmanaged<int*, void> _Vertex4xvOES_fnptr = &Vertex4xvOES_Lazy;
            public static void Vertex4xvOES(int* coords) => _Vertex4xvOES_fnptr(coords);
            [UnmanagedCallersOnly]
            private static void Vertex4xvOES_Lazy(int* coords)
            {
                _Vertex4xvOES_fnptr = (delegate* unmanaged<int*, void>)GLLoader.BindingsContext.GetProcAddress("glVertex4xvOES");
                _Vertex4xvOES_fnptr(coords);
            }
            
            private static delegate* unmanaged<RenderbufferHandle, byte> _IsRenderbufferOES_fnptr = &IsRenderbufferOES_Lazy;
            public static byte IsRenderbufferOES(RenderbufferHandle renderbuffer) => _IsRenderbufferOES_fnptr(renderbuffer);
            [UnmanagedCallersOnly]
            private static byte IsRenderbufferOES_Lazy(RenderbufferHandle renderbuffer)
            {
                _IsRenderbufferOES_fnptr = (delegate* unmanaged<RenderbufferHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsRenderbufferOES");
                return _IsRenderbufferOES_fnptr(renderbuffer);
            }
            
            private static delegate* unmanaged<RenderbufferTarget, RenderbufferHandle, void> _BindRenderbufferOES_fnptr = &BindRenderbufferOES_Lazy;
            public static void BindRenderbufferOES(RenderbufferTarget target, RenderbufferHandle renderbuffer) => _BindRenderbufferOES_fnptr(target, renderbuffer);
            [UnmanagedCallersOnly]
            private static void BindRenderbufferOES_Lazy(RenderbufferTarget target, RenderbufferHandle renderbuffer)
            {
                _BindRenderbufferOES_fnptr = (delegate* unmanaged<RenderbufferTarget, RenderbufferHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindRenderbufferOES");
                _BindRenderbufferOES_fnptr(target, renderbuffer);
            }
            
            private static delegate* unmanaged<int, RenderbufferHandle*, void> _DeleteRenderbuffersOES_fnptr = &DeleteRenderbuffersOES_Lazy;
            public static void DeleteRenderbuffersOES(int n, RenderbufferHandle* renderbuffers) => _DeleteRenderbuffersOES_fnptr(n, renderbuffers);
            [UnmanagedCallersOnly]
            private static void DeleteRenderbuffersOES_Lazy(int n, RenderbufferHandle* renderbuffers)
            {
                _DeleteRenderbuffersOES_fnptr = (delegate* unmanaged<int, RenderbufferHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteRenderbuffersOES");
                _DeleteRenderbuffersOES_fnptr(n, renderbuffers);
            }
            
            private static delegate* unmanaged<int, RenderbufferHandle*, void> _GenRenderbuffersOES_fnptr = &GenRenderbuffersOES_Lazy;
            public static void GenRenderbuffersOES(int n, RenderbufferHandle* renderbuffers) => _GenRenderbuffersOES_fnptr(n, renderbuffers);
            [UnmanagedCallersOnly]
            private static void GenRenderbuffersOES_Lazy(int n, RenderbufferHandle* renderbuffers)
            {
                _GenRenderbuffersOES_fnptr = (delegate* unmanaged<int, RenderbufferHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenRenderbuffersOES");
                _GenRenderbuffersOES_fnptr(n, renderbuffers);
            }
            
            private static delegate* unmanaged<RenderbufferTarget, InternalFormat, int, int, void> _RenderbufferStorageOES_fnptr = &RenderbufferStorageOES_Lazy;
            public static void RenderbufferStorageOES(RenderbufferTarget target, InternalFormat internalformat, int width, int height) => _RenderbufferStorageOES_fnptr(target, internalformat, width, height);
            [UnmanagedCallersOnly]
            private static void RenderbufferStorageOES_Lazy(RenderbufferTarget target, InternalFormat internalformat, int width, int height)
            {
                _RenderbufferStorageOES_fnptr = (delegate* unmanaged<RenderbufferTarget, InternalFormat, int, int, void>)GLLoader.BindingsContext.GetProcAddress("glRenderbufferStorageOES");
                _RenderbufferStorageOES_fnptr(target, internalformat, width, height);
            }
            
            private static delegate* unmanaged<RenderbufferTarget, RenderbufferParameterName, int*, void> _GetRenderbufferParameterivOES_fnptr = &GetRenderbufferParameterivOES_Lazy;
            public static void GetRenderbufferParameterivOES(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters) => _GetRenderbufferParameterivOES_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetRenderbufferParameterivOES_Lazy(RenderbufferTarget target, RenderbufferParameterName pname, int* parameters)
            {
                _GetRenderbufferParameterivOES_fnptr = (delegate* unmanaged<RenderbufferTarget, RenderbufferParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetRenderbufferParameterivOES");
                _GetRenderbufferParameterivOES_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<FramebufferHandle, byte> _IsFramebufferOES_fnptr = &IsFramebufferOES_Lazy;
            public static byte IsFramebufferOES(FramebufferHandle framebuffer) => _IsFramebufferOES_fnptr(framebuffer);
            [UnmanagedCallersOnly]
            private static byte IsFramebufferOES_Lazy(FramebufferHandle framebuffer)
            {
                _IsFramebufferOES_fnptr = (delegate* unmanaged<FramebufferHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsFramebufferOES");
                return _IsFramebufferOES_fnptr(framebuffer);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferHandle, void> _BindFramebufferOES_fnptr = &BindFramebufferOES_Lazy;
            public static void BindFramebufferOES(FramebufferTarget target, FramebufferHandle framebuffer) => _BindFramebufferOES_fnptr(target, framebuffer);
            [UnmanagedCallersOnly]
            private static void BindFramebufferOES_Lazy(FramebufferTarget target, FramebufferHandle framebuffer)
            {
                _BindFramebufferOES_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindFramebufferOES");
                _BindFramebufferOES_fnptr(target, framebuffer);
            }
            
            private static delegate* unmanaged<int, FramebufferHandle*, void> _DeleteFramebuffersOES_fnptr = &DeleteFramebuffersOES_Lazy;
            public static void DeleteFramebuffersOES(int n, FramebufferHandle* framebuffers) => _DeleteFramebuffersOES_fnptr(n, framebuffers);
            [UnmanagedCallersOnly]
            private static void DeleteFramebuffersOES_Lazy(int n, FramebufferHandle* framebuffers)
            {
                _DeleteFramebuffersOES_fnptr = (delegate* unmanaged<int, FramebufferHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteFramebuffersOES");
                _DeleteFramebuffersOES_fnptr(n, framebuffers);
            }
            
            private static delegate* unmanaged<int, FramebufferHandle*, void> _GenFramebuffersOES_fnptr = &GenFramebuffersOES_Lazy;
            public static void GenFramebuffersOES(int n, FramebufferHandle* framebuffers) => _GenFramebuffersOES_fnptr(n, framebuffers);
            [UnmanagedCallersOnly]
            private static void GenFramebuffersOES_Lazy(int n, FramebufferHandle* framebuffers)
            {
                _GenFramebuffersOES_fnptr = (delegate* unmanaged<int, FramebufferHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenFramebuffersOES");
                _GenFramebuffersOES_fnptr(n, framebuffers);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferStatus> _CheckFramebufferStatusOES_fnptr = &CheckFramebufferStatusOES_Lazy;
            public static FramebufferStatus CheckFramebufferStatusOES(FramebufferTarget target) => _CheckFramebufferStatusOES_fnptr(target);
            [UnmanagedCallersOnly]
            private static FramebufferStatus CheckFramebufferStatusOES_Lazy(FramebufferTarget target)
            {
                _CheckFramebufferStatusOES_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferStatus>)GLLoader.BindingsContext.GetProcAddress("glCheckFramebufferStatusOES");
                return _CheckFramebufferStatusOES_fnptr(target);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, RenderbufferHandle, void> _FramebufferRenderbufferOES_fnptr = &FramebufferRenderbufferOES_Lazy;
            public static void FramebufferRenderbufferOES(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, RenderbufferHandle renderbuffer) => _FramebufferRenderbufferOES_fnptr(target, attachment, renderbuffertarget, renderbuffer);
            [UnmanagedCallersOnly]
            private static void FramebufferRenderbufferOES_Lazy(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, RenderbufferHandle renderbuffer)
            {
                _FramebufferRenderbufferOES_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, RenderbufferTarget, RenderbufferHandle, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferRenderbufferOES");
                _FramebufferRenderbufferOES_fnptr(target, attachment, renderbuffertarget, renderbuffer);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, void> _FramebufferTexture2DOES_fnptr = &FramebufferTexture2DOES_Lazy;
            public static void FramebufferTexture2DOES(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level) => _FramebufferTexture2DOES_fnptr(target, attachment, textarget, texture, level);
            [UnmanagedCallersOnly]
            private static void FramebufferTexture2DOES_Lazy(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, TextureHandle texture, int level)
            {
                _FramebufferTexture2DOES_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, TextureTarget, TextureHandle, int, void>)GLLoader.BindingsContext.GetProcAddress("glFramebufferTexture2DOES");
                _FramebufferTexture2DOES_fnptr(target, attachment, textarget, texture, level);
            }
            
            private static delegate* unmanaged<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*, void> _GetFramebufferAttachmentParameterivOES_fnptr = &GetFramebufferAttachmentParameterivOES_Lazy;
            public static void GetFramebufferAttachmentParameterivOES(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters) => _GetFramebufferAttachmentParameterivOES_fnptr(target, attachment, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetFramebufferAttachmentParameterivOES_Lazy(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, int* parameters)
            {
                _GetFramebufferAttachmentParameterivOES_fnptr = (delegate* unmanaged<FramebufferTarget, FramebufferAttachment, FramebufferAttachmentParameterName, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetFramebufferAttachmentParameterivOES");
                _GetFramebufferAttachmentParameterivOES_fnptr(target, attachment, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureTarget, void> _GenerateMipmapOES_fnptr = &GenerateMipmapOES_Lazy;
            public static void GenerateMipmapOES(TextureTarget target) => _GenerateMipmapOES_fnptr(target);
            [UnmanagedCallersOnly]
            private static void GenerateMipmapOES_Lazy(TextureTarget target)
            {
                _GenerateMipmapOES_fnptr = (delegate* unmanaged<TextureTarget, void>)GLLoader.BindingsContext.GetProcAddress("glGenerateMipmapOES");
                _GenerateMipmapOES_fnptr(target);
            }
            
            private static delegate* unmanaged<BufferTargetARB, BufferAccessARB, void*> _MapBufferOES_fnptr = &MapBufferOES_Lazy;
            public static void* MapBufferOES(BufferTargetARB target, BufferAccessARB access) => _MapBufferOES_fnptr(target, access);
            [UnmanagedCallersOnly]
            private static void* MapBufferOES_Lazy(BufferTargetARB target, BufferAccessARB access)
            {
                _MapBufferOES_fnptr = (delegate* unmanaged<BufferTargetARB, BufferAccessARB, void*>)GLLoader.BindingsContext.GetProcAddress("glMapBufferOES");
                return _MapBufferOES_fnptr(target, access);
            }
            
            private static delegate* unmanaged<All, byte> _UnmapBufferOES_fnptr = &UnmapBufferOES_Lazy;
            public static byte UnmapBufferOES(All target) => _UnmapBufferOES_fnptr(target);
            [UnmanagedCallersOnly]
            private static byte UnmapBufferOES_Lazy(All target)
            {
                _UnmapBufferOES_fnptr = (delegate* unmanaged<All, byte>)GLLoader.BindingsContext.GetProcAddress("glUnmapBufferOES");
                return _UnmapBufferOES_fnptr(target);
            }
            
            private static delegate* unmanaged<BufferTargetARB, BufferPointerNameARB, void**, void> _GetBufferPointervOES_fnptr = &GetBufferPointervOES_Lazy;
            public static void GetBufferPointervOES(BufferTargetARB target, BufferPointerNameARB pname, void** parameters) => _GetBufferPointervOES_fnptr(target, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetBufferPointervOES_Lazy(BufferTargetARB target, BufferPointerNameARB pname, void** parameters)
            {
                _GetBufferPointervOES_fnptr = (delegate* unmanaged<BufferTargetARB, BufferPointerNameARB, void**, void>)GLLoader.BindingsContext.GetProcAddress("glGetBufferPointervOES");
                _GetBufferPointervOES_fnptr(target, pname, parameters);
            }
            
            private static delegate* unmanaged<uint, void> _CurrentPaletteMatrixOES_fnptr = &CurrentPaletteMatrixOES_Lazy;
            public static void CurrentPaletteMatrixOES(uint matrixpaletteindex) => _CurrentPaletteMatrixOES_fnptr(matrixpaletteindex);
            [UnmanagedCallersOnly]
            private static void CurrentPaletteMatrixOES_Lazy(uint matrixpaletteindex)
            {
                _CurrentPaletteMatrixOES_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glCurrentPaletteMatrixOES");
                _CurrentPaletteMatrixOES_fnptr(matrixpaletteindex);
            }
            
            private static delegate* unmanaged<void> _LoadPaletteFromModelViewMatrixOES_fnptr = &LoadPaletteFromModelViewMatrixOES_Lazy;
            public static void LoadPaletteFromModelViewMatrixOES() => _LoadPaletteFromModelViewMatrixOES_fnptr();
            [UnmanagedCallersOnly]
            private static void LoadPaletteFromModelViewMatrixOES_Lazy()
            {
                _LoadPaletteFromModelViewMatrixOES_fnptr = (delegate* unmanaged<void>)GLLoader.BindingsContext.GetProcAddress("glLoadPaletteFromModelViewMatrixOES");
                _LoadPaletteFromModelViewMatrixOES_fnptr();
            }
            
            private static delegate* unmanaged<int, MatrixIndexPointerTypeARB, int, void*, void> _MatrixIndexPointerOES_fnptr = &MatrixIndexPointerOES_Lazy;
            public static void MatrixIndexPointerOES(int size, MatrixIndexPointerTypeARB type, int stride, void* pointer) => _MatrixIndexPointerOES_fnptr(size, type, stride, pointer);
            [UnmanagedCallersOnly]
            private static void MatrixIndexPointerOES_Lazy(int size, MatrixIndexPointerTypeARB type, int stride, void* pointer)
            {
                _MatrixIndexPointerOES_fnptr = (delegate* unmanaged<int, MatrixIndexPointerTypeARB, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glMatrixIndexPointerOES");
                _MatrixIndexPointerOES_fnptr(size, type, stride, pointer);
            }
            
            private static delegate* unmanaged<int, All, int, void*, void> _WeightPointerOES_fnptr = &WeightPointerOES_Lazy;
            public static void WeightPointerOES(int size, All type, int stride, void* pointer) => _WeightPointerOES_fnptr(size, type, stride, pointer);
            [UnmanagedCallersOnly]
            private static void WeightPointerOES_Lazy(int size, All type, int stride, void* pointer)
            {
                _WeightPointerOES_fnptr = (delegate* unmanaged<int, All, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glWeightPointerOES");
                _WeightPointerOES_fnptr(size, type, stride, pointer);
            }
            
            private static delegate* unmanaged<All, int, void*, void> _PointSizePointerOES_fnptr = &PointSizePointerOES_Lazy;
            public static void PointSizePointerOES(All type, int stride, void* pointer) => _PointSizePointerOES_fnptr(type, stride, pointer);
            [UnmanagedCallersOnly]
            private static void PointSizePointerOES_Lazy(All type, int stride, void* pointer)
            {
                _PointSizePointerOES_fnptr = (delegate* unmanaged<All, int, void*, void>)GLLoader.BindingsContext.GetProcAddress("glPointSizePointerOES");
                _PointSizePointerOES_fnptr(type, stride, pointer);
            }
            
            private static delegate* unmanaged<int*, int*, All> _QueryMatrixxOES_fnptr = &QueryMatrixxOES_Lazy;
            public static All QueryMatrixxOES(int* mantissa, int* exponent) => _QueryMatrixxOES_fnptr(mantissa, exponent);
            [UnmanagedCallersOnly]
            private static All QueryMatrixxOES_Lazy(int* mantissa, int* exponent)
            {
                _QueryMatrixxOES_fnptr = (delegate* unmanaged<int*, int*, All>)GLLoader.BindingsContext.GetProcAddress("glQueryMatrixxOES");
                return _QueryMatrixxOES_fnptr(mantissa, exponent);
            }
            
            private static delegate* unmanaged<float, void> _ClearDepthfOES_fnptr = &ClearDepthfOES_Lazy;
            public static void ClearDepthfOES(float depth) => _ClearDepthfOES_fnptr(depth);
            [UnmanagedCallersOnly]
            private static void ClearDepthfOES_Lazy(float depth)
            {
                _ClearDepthfOES_fnptr = (delegate* unmanaged<float, void>)GLLoader.BindingsContext.GetProcAddress("glClearDepthfOES");
                _ClearDepthfOES_fnptr(depth);
            }
            
            private static delegate* unmanaged<ClipPlaneName, float*, void> _ClipPlanefOES_fnptr = &ClipPlanefOES_Lazy;
            public static void ClipPlanefOES(ClipPlaneName plane, float* equation) => _ClipPlanefOES_fnptr(plane, equation);
            [UnmanagedCallersOnly]
            private static void ClipPlanefOES_Lazy(ClipPlaneName plane, float* equation)
            {
                _ClipPlanefOES_fnptr = (delegate* unmanaged<ClipPlaneName, float*, void>)GLLoader.BindingsContext.GetProcAddress("glClipPlanefOES");
                _ClipPlanefOES_fnptr(plane, equation);
            }
            
            private static delegate* unmanaged<float, float, void> _DepthRangefOES_fnptr = &DepthRangefOES_Lazy;
            public static void DepthRangefOES(float n, float f) => _DepthRangefOES_fnptr(n, f);
            [UnmanagedCallersOnly]
            private static void DepthRangefOES_Lazy(float n, float f)
            {
                _DepthRangefOES_fnptr = (delegate* unmanaged<float, float, void>)GLLoader.BindingsContext.GetProcAddress("glDepthRangefOES");
                _DepthRangefOES_fnptr(n, f);
            }
            
            private static delegate* unmanaged<float, float, float, float, float, float, void> _FrustumfOES_fnptr = &FrustumfOES_Lazy;
            public static void FrustumfOES(float l, float r, float b, float t, float n, float f) => _FrustumfOES_fnptr(l, r, b, t, n, f);
            [UnmanagedCallersOnly]
            private static void FrustumfOES_Lazy(float l, float r, float b, float t, float n, float f)
            {
                _FrustumfOES_fnptr = (delegate* unmanaged<float, float, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glFrustumfOES");
                _FrustumfOES_fnptr(l, r, b, t, n, f);
            }
            
            private static delegate* unmanaged<ClipPlaneName, float*, void> _GetClipPlanefOES_fnptr = &GetClipPlanefOES_Lazy;
            public static void GetClipPlanefOES(ClipPlaneName plane, float* equation) => _GetClipPlanefOES_fnptr(plane, equation);
            [UnmanagedCallersOnly]
            private static void GetClipPlanefOES_Lazy(ClipPlaneName plane, float* equation)
            {
                _GetClipPlanefOES_fnptr = (delegate* unmanaged<ClipPlaneName, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetClipPlanefOES");
                _GetClipPlanefOES_fnptr(plane, equation);
            }
            
            private static delegate* unmanaged<float, float, float, float, float, float, void> _OrthofOES_fnptr = &OrthofOES_Lazy;
            public static void OrthofOES(float l, float r, float b, float t, float n, float f) => _OrthofOES_fnptr(l, r, b, t, n, f);
            [UnmanagedCallersOnly]
            private static void OrthofOES_Lazy(float l, float r, float b, float t, float n, float f)
            {
                _OrthofOES_fnptr = (delegate* unmanaged<float, float, float, float, float, float, void>)GLLoader.BindingsContext.GetProcAddress("glOrthofOES");
                _OrthofOES_fnptr(l, r, b, t, n, f);
            }
            
            private static delegate* unmanaged<TextureCoordName, TextureGenParameter, float, void> _TexGenfOES_fnptr = &TexGenfOES_Lazy;
            public static void TexGenfOES(TextureCoordName coord, TextureGenParameter pname, float param) => _TexGenfOES_fnptr(coord, pname, param);
            [UnmanagedCallersOnly]
            private static void TexGenfOES_Lazy(TextureCoordName coord, TextureGenParameter pname, float param)
            {
                _TexGenfOES_fnptr = (delegate* unmanaged<TextureCoordName, TextureGenParameter, float, void>)GLLoader.BindingsContext.GetProcAddress("glTexGenfOES");
                _TexGenfOES_fnptr(coord, pname, param);
            }
            
            private static delegate* unmanaged<TextureCoordName, TextureGenParameter, float*, void> _TexGenfvOES_fnptr = &TexGenfvOES_Lazy;
            public static void TexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float* parameters) => _TexGenfvOES_fnptr(coord, pname, parameters);
            [UnmanagedCallersOnly]
            private static void TexGenfvOES_Lazy(TextureCoordName coord, TextureGenParameter pname, float* parameters)
            {
                _TexGenfvOES_fnptr = (delegate* unmanaged<TextureCoordName, TextureGenParameter, float*, void>)GLLoader.BindingsContext.GetProcAddress("glTexGenfvOES");
                _TexGenfvOES_fnptr(coord, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureCoordName, TextureGenParameter, int, void> _TexGeniOES_fnptr = &TexGeniOES_Lazy;
            public static void TexGeniOES(TextureCoordName coord, TextureGenParameter pname, int param) => _TexGeniOES_fnptr(coord, pname, param);
            [UnmanagedCallersOnly]
            private static void TexGeniOES_Lazy(TextureCoordName coord, TextureGenParameter pname, int param)
            {
                _TexGeniOES_fnptr = (delegate* unmanaged<TextureCoordName, TextureGenParameter, int, void>)GLLoader.BindingsContext.GetProcAddress("glTexGeniOES");
                _TexGeniOES_fnptr(coord, pname, param);
            }
            
            private static delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void> _TexGenivOES_fnptr = &TexGenivOES_Lazy;
            public static void TexGenivOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => _TexGenivOES_fnptr(coord, pname, parameters);
            [UnmanagedCallersOnly]
            private static void TexGenivOES_Lazy(TextureCoordName coord, TextureGenParameter pname, int* parameters)
            {
                _TexGenivOES_fnptr = (delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glTexGenivOES");
                _TexGenivOES_fnptr(coord, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureCoordName, TextureGenParameter, float*, void> _GetTexGenfvOES_fnptr = &GetTexGenfvOES_Lazy;
            public static void GetTexGenfvOES(TextureCoordName coord, TextureGenParameter pname, float* parameters) => _GetTexGenfvOES_fnptr(coord, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexGenfvOES_Lazy(TextureCoordName coord, TextureGenParameter pname, float* parameters)
            {
                _GetTexGenfvOES_fnptr = (delegate* unmanaged<TextureCoordName, TextureGenParameter, float*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexGenfvOES");
                _GetTexGenfvOES_fnptr(coord, pname, parameters);
            }
            
            private static delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void> _GetTexGenivOES_fnptr = &GetTexGenivOES_Lazy;
            public static void GetTexGenivOES(TextureCoordName coord, TextureGenParameter pname, int* parameters) => _GetTexGenivOES_fnptr(coord, pname, parameters);
            [UnmanagedCallersOnly]
            private static void GetTexGenivOES_Lazy(TextureCoordName coord, TextureGenParameter pname, int* parameters)
            {
                _GetTexGenivOES_fnptr = (delegate* unmanaged<TextureCoordName, TextureGenParameter, int*, void>)GLLoader.BindingsContext.GetProcAddress("glGetTexGenivOES");
                _GetTexGenivOES_fnptr(coord, pname, parameters);
            }
            
            private static delegate* unmanaged<VertexArrayHandle, void> _BindVertexArrayOES_fnptr = &BindVertexArrayOES_Lazy;
            public static void BindVertexArrayOES(VertexArrayHandle array) => _BindVertexArrayOES_fnptr(array);
            [UnmanagedCallersOnly]
            private static void BindVertexArrayOES_Lazy(VertexArrayHandle array)
            {
                _BindVertexArrayOES_fnptr = (delegate* unmanaged<VertexArrayHandle, void>)GLLoader.BindingsContext.GetProcAddress("glBindVertexArrayOES");
                _BindVertexArrayOES_fnptr(array);
            }
            
            private static delegate* unmanaged<int, VertexArrayHandle*, void> _DeleteVertexArraysOES_fnptr = &DeleteVertexArraysOES_Lazy;
            public static void DeleteVertexArraysOES(int n, VertexArrayHandle* arrays) => _DeleteVertexArraysOES_fnptr(n, arrays);
            [UnmanagedCallersOnly]
            private static void DeleteVertexArraysOES_Lazy(int n, VertexArrayHandle* arrays)
            {
                _DeleteVertexArraysOES_fnptr = (delegate* unmanaged<int, VertexArrayHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glDeleteVertexArraysOES");
                _DeleteVertexArraysOES_fnptr(n, arrays);
            }
            
            private static delegate* unmanaged<int, VertexArrayHandle*, void> _GenVertexArraysOES_fnptr = &GenVertexArraysOES_Lazy;
            public static void GenVertexArraysOES(int n, VertexArrayHandle* arrays) => _GenVertexArraysOES_fnptr(n, arrays);
            [UnmanagedCallersOnly]
            private static void GenVertexArraysOES_Lazy(int n, VertexArrayHandle* arrays)
            {
                _GenVertexArraysOES_fnptr = (delegate* unmanaged<int, VertexArrayHandle*, void>)GLLoader.BindingsContext.GetProcAddress("glGenVertexArraysOES");
                _GenVertexArraysOES_fnptr(n, arrays);
            }
            
            private static delegate* unmanaged<VertexArrayHandle, byte> _IsVertexArrayOES_fnptr = &IsVertexArrayOES_Lazy;
            public static byte IsVertexArrayOES(VertexArrayHandle array) => _IsVertexArrayOES_fnptr(array);
            [UnmanagedCallersOnly]
            private static byte IsVertexArrayOES_Lazy(VertexArrayHandle array)
            {
                _IsVertexArrayOES_fnptr = (delegate* unmanaged<VertexArrayHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glIsVertexArrayOES");
                return _IsVertexArrayOES_fnptr(array);
            }
            
        }
        public static unsafe partial class QCOM
        {
            private static delegate* unmanaged<int*, int, uint*, void> _GetDriverControlsQCOM_fnptr = &GetDriverControlsQCOM_Lazy;
            public static void GetDriverControlsQCOM(int* num, int size, uint* driverControls) => _GetDriverControlsQCOM_fnptr(num, size, driverControls);
            [UnmanagedCallersOnly]
            private static void GetDriverControlsQCOM_Lazy(int* num, int size, uint* driverControls)
            {
                _GetDriverControlsQCOM_fnptr = (delegate* unmanaged<int*, int, uint*, void>)GLLoader.BindingsContext.GetProcAddress("glGetDriverControlsQCOM");
                _GetDriverControlsQCOM_fnptr(num, size, driverControls);
            }
            
            private static delegate* unmanaged<uint, int, int*, byte*, void> _GetDriverControlStringQCOM_fnptr = &GetDriverControlStringQCOM_Lazy;
            public static void GetDriverControlStringQCOM(uint driverControl, int bufSize, int* length, byte* driverControlString) => _GetDriverControlStringQCOM_fnptr(driverControl, bufSize, length, driverControlString);
            [UnmanagedCallersOnly]
            private static void GetDriverControlStringQCOM_Lazy(uint driverControl, int bufSize, int* length, byte* driverControlString)
            {
                _GetDriverControlStringQCOM_fnptr = (delegate* unmanaged<uint, int, int*, byte*, void>)GLLoader.BindingsContext.GetProcAddress("glGetDriverControlStringQCOM");
                _GetDriverControlStringQCOM_fnptr(driverControl, bufSize, length, driverControlString);
            }
            
            private static delegate* unmanaged<uint, void> _EnableDriverControlQCOM_fnptr = &EnableDriverControlQCOM_Lazy;
            public static void EnableDriverControlQCOM(uint driverControl) => _EnableDriverControlQCOM_fnptr(driverControl);
            [UnmanagedCallersOnly]
            private static void EnableDriverControlQCOM_Lazy(uint driverControl)
            {
                _EnableDriverControlQCOM_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glEnableDriverControlQCOM");
                _EnableDriverControlQCOM_fnptr(driverControl);
            }
            
            private static delegate* unmanaged<uint, void> _DisableDriverControlQCOM_fnptr = &DisableDriverControlQCOM_Lazy;
            public static void DisableDriverControlQCOM(uint driverControl) => _DisableDriverControlQCOM_fnptr(driverControl);
            [UnmanagedCallersOnly]
            private static void DisableDriverControlQCOM_Lazy(uint driverControl)
            {
                _DisableDriverControlQCOM_fnptr = (delegate* unmanaged<uint, void>)GLLoader.BindingsContext.GetProcAddress("glDisableDriverControlQCOM");
                _DisableDriverControlQCOM_fnptr(driverControl);
            }
            
            private static delegate* unmanaged<TextureHandle*, int, int*, void> _ExtGetTexturesQCOM_fnptr = &ExtGetTexturesQCOM_Lazy;
            public static void ExtGetTexturesQCOM(TextureHandle* textures, int maxTextures, int* numTextures) => _ExtGetTexturesQCOM_fnptr(textures, maxTextures, numTextures);
            [UnmanagedCallersOnly]
            private static void ExtGetTexturesQCOM_Lazy(TextureHandle* textures, int maxTextures, int* numTextures)
            {
                _ExtGetTexturesQCOM_fnptr = (delegate* unmanaged<TextureHandle*, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetTexturesQCOM");
                _ExtGetTexturesQCOM_fnptr(textures, maxTextures, numTextures);
            }
            
            private static delegate* unmanaged<BufferHandle*, int, int*, void> _ExtGetBuffersQCOM_fnptr = &ExtGetBuffersQCOM_Lazy;
            public static void ExtGetBuffersQCOM(BufferHandle* buffers, int maxBuffers, int* numBuffers) => _ExtGetBuffersQCOM_fnptr(buffers, maxBuffers, numBuffers);
            [UnmanagedCallersOnly]
            private static void ExtGetBuffersQCOM_Lazy(BufferHandle* buffers, int maxBuffers, int* numBuffers)
            {
                _ExtGetBuffersQCOM_fnptr = (delegate* unmanaged<BufferHandle*, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetBuffersQCOM");
                _ExtGetBuffersQCOM_fnptr(buffers, maxBuffers, numBuffers);
            }
            
            private static delegate* unmanaged<RenderbufferHandle*, int, int*, void> _ExtGetRenderbuffersQCOM_fnptr = &ExtGetRenderbuffersQCOM_Lazy;
            public static void ExtGetRenderbuffersQCOM(RenderbufferHandle* renderbuffers, int maxRenderbuffers, int* numRenderbuffers) => _ExtGetRenderbuffersQCOM_fnptr(renderbuffers, maxRenderbuffers, numRenderbuffers);
            [UnmanagedCallersOnly]
            private static void ExtGetRenderbuffersQCOM_Lazy(RenderbufferHandle* renderbuffers, int maxRenderbuffers, int* numRenderbuffers)
            {
                _ExtGetRenderbuffersQCOM_fnptr = (delegate* unmanaged<RenderbufferHandle*, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetRenderbuffersQCOM");
                _ExtGetRenderbuffersQCOM_fnptr(renderbuffers, maxRenderbuffers, numRenderbuffers);
            }
            
            private static delegate* unmanaged<FramebufferHandle*, int, int*, void> _ExtGetFramebuffersQCOM_fnptr = &ExtGetFramebuffersQCOM_Lazy;
            public static void ExtGetFramebuffersQCOM(FramebufferHandle* framebuffers, int maxFramebuffers, int* numFramebuffers) => _ExtGetFramebuffersQCOM_fnptr(framebuffers, maxFramebuffers, numFramebuffers);
            [UnmanagedCallersOnly]
            private static void ExtGetFramebuffersQCOM_Lazy(FramebufferHandle* framebuffers, int maxFramebuffers, int* numFramebuffers)
            {
                _ExtGetFramebuffersQCOM_fnptr = (delegate* unmanaged<FramebufferHandle*, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetFramebuffersQCOM");
                _ExtGetFramebuffersQCOM_fnptr(framebuffers, maxFramebuffers, numFramebuffers);
            }
            
            private static delegate* unmanaged<TextureHandle, All, int, All, int*, void> _ExtGetTexLevelParameterivQCOM_fnptr = &ExtGetTexLevelParameterivQCOM_Lazy;
            public static void ExtGetTexLevelParameterivQCOM(TextureHandle texture, All face, int level, All pname, int* parameters) => _ExtGetTexLevelParameterivQCOM_fnptr(texture, face, level, pname, parameters);
            [UnmanagedCallersOnly]
            private static void ExtGetTexLevelParameterivQCOM_Lazy(TextureHandle texture, All face, int level, All pname, int* parameters)
            {
                _ExtGetTexLevelParameterivQCOM_fnptr = (delegate* unmanaged<TextureHandle, All, int, All, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetTexLevelParameterivQCOM");
                _ExtGetTexLevelParameterivQCOM_fnptr(texture, face, level, pname, parameters);
            }
            
            private static delegate* unmanaged<All, All, int, void> _ExtTexObjectStateOverrideiQCOM_fnptr = &ExtTexObjectStateOverrideiQCOM_Lazy;
            public static void ExtTexObjectStateOverrideiQCOM(All target, All pname, int param) => _ExtTexObjectStateOverrideiQCOM_fnptr(target, pname, param);
            [UnmanagedCallersOnly]
            private static void ExtTexObjectStateOverrideiQCOM_Lazy(All target, All pname, int param)
            {
                _ExtTexObjectStateOverrideiQCOM_fnptr = (delegate* unmanaged<All, All, int, void>)GLLoader.BindingsContext.GetProcAddress("glExtTexObjectStateOverrideiQCOM");
                _ExtTexObjectStateOverrideiQCOM_fnptr(target, pname, param);
            }
            
            private static delegate* unmanaged<All, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void> _ExtGetTexSubImageQCOM_fnptr = &ExtGetTexSubImageQCOM_Lazy;
            public static void ExtGetTexSubImageQCOM(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* texels) => _ExtGetTexSubImageQCOM_fnptr(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels);
            [UnmanagedCallersOnly]
            private static void ExtGetTexSubImageQCOM_Lazy(All target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, void* texels)
            {
                _ExtGetTexSubImageQCOM_fnptr = (delegate* unmanaged<All, int, int, int, int, int, int, int, PixelFormat, PixelType, void*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetTexSubImageQCOM");
                _ExtGetTexSubImageQCOM_fnptr(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels);
            }
            
            private static delegate* unmanaged<All, void**, void> _ExtGetBufferPointervQCOM_fnptr = &ExtGetBufferPointervQCOM_Lazy;
            public static void ExtGetBufferPointervQCOM(All target, void** parameters) => _ExtGetBufferPointervQCOM_fnptr(target, parameters);
            [UnmanagedCallersOnly]
            private static void ExtGetBufferPointervQCOM_Lazy(All target, void** parameters)
            {
                _ExtGetBufferPointervQCOM_fnptr = (delegate* unmanaged<All, void**, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetBufferPointervQCOM");
                _ExtGetBufferPointervQCOM_fnptr(target, parameters);
            }
            
            private static delegate* unmanaged<ShaderHandle*, int, int*, void> _ExtGetShadersQCOM_fnptr = &ExtGetShadersQCOM_Lazy;
            public static void ExtGetShadersQCOM(ShaderHandle* shaders, int maxShaders, int* numShaders) => _ExtGetShadersQCOM_fnptr(shaders, maxShaders, numShaders);
            [UnmanagedCallersOnly]
            private static void ExtGetShadersQCOM_Lazy(ShaderHandle* shaders, int maxShaders, int* numShaders)
            {
                _ExtGetShadersQCOM_fnptr = (delegate* unmanaged<ShaderHandle*, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetShadersQCOM");
                _ExtGetShadersQCOM_fnptr(shaders, maxShaders, numShaders);
            }
            
            private static delegate* unmanaged<ProgramHandle*, int, int*, void> _ExtGetProgramsQCOM_fnptr = &ExtGetProgramsQCOM_Lazy;
            public static void ExtGetProgramsQCOM(ProgramHandle* programs, int maxPrograms, int* numPrograms) => _ExtGetProgramsQCOM_fnptr(programs, maxPrograms, numPrograms);
            [UnmanagedCallersOnly]
            private static void ExtGetProgramsQCOM_Lazy(ProgramHandle* programs, int maxPrograms, int* numPrograms)
            {
                _ExtGetProgramsQCOM_fnptr = (delegate* unmanaged<ProgramHandle*, int, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetProgramsQCOM");
                _ExtGetProgramsQCOM_fnptr(programs, maxPrograms, numPrograms);
            }
            
            private static delegate* unmanaged<ProgramHandle, byte> _ExtIsProgramBinaryQCOM_fnptr = &ExtIsProgramBinaryQCOM_Lazy;
            public static byte ExtIsProgramBinaryQCOM(ProgramHandle program) => _ExtIsProgramBinaryQCOM_fnptr(program);
            [UnmanagedCallersOnly]
            private static byte ExtIsProgramBinaryQCOM_Lazy(ProgramHandle program)
            {
                _ExtIsProgramBinaryQCOM_fnptr = (delegate* unmanaged<ProgramHandle, byte>)GLLoader.BindingsContext.GetProcAddress("glExtIsProgramBinaryQCOM");
                return _ExtIsProgramBinaryQCOM_fnptr(program);
            }
            
            private static delegate* unmanaged<ProgramHandle, ShaderType, byte*, int*, void> _ExtGetProgramBinarySourceQCOM_fnptr = &ExtGetProgramBinarySourceQCOM_Lazy;
            public static void ExtGetProgramBinarySourceQCOM(ProgramHandle program, ShaderType shadertype, byte* source, int* length) => _ExtGetProgramBinarySourceQCOM_fnptr(program, shadertype, source, length);
            [UnmanagedCallersOnly]
            private static void ExtGetProgramBinarySourceQCOM_Lazy(ProgramHandle program, ShaderType shadertype, byte* source, int* length)
            {
                _ExtGetProgramBinarySourceQCOM_fnptr = (delegate* unmanaged<ProgramHandle, ShaderType, byte*, int*, void>)GLLoader.BindingsContext.GetProcAddress("glExtGetProgramBinarySourceQCOM");
                _ExtGetProgramBinarySourceQCOM_fnptr(program, shadertype, source, length);
            }
            
            private static delegate* unmanaged<uint, uint, uint, uint, BufferBitQCOM, void> _StartTilingQCOM_fnptr = &StartTilingQCOM_Lazy;
            public static void StartTilingQCOM(uint x, uint y, uint width, uint height, BufferBitQCOM preserveMask) => _StartTilingQCOM_fnptr(x, y, width, height, preserveMask);
            [UnmanagedCallersOnly]
            private static void StartTilingQCOM_Lazy(uint x, uint y, uint width, uint height, BufferBitQCOM preserveMask)
            {
                _StartTilingQCOM_fnptr = (delegate* unmanaged<uint, uint, uint, uint, BufferBitQCOM, void>)GLLoader.BindingsContext.GetProcAddress("glStartTilingQCOM");
                _StartTilingQCOM_fnptr(x, y, width, height, preserveMask);
            }
            
            private static delegate* unmanaged<BufferBitQCOM, void> _EndTilingQCOM_fnptr = &EndTilingQCOM_Lazy;
            public static void EndTilingQCOM(BufferBitQCOM preserveMask) => _EndTilingQCOM_fnptr(preserveMask);
            [UnmanagedCallersOnly]
            private static void EndTilingQCOM_Lazy(BufferBitQCOM preserveMask)
            {
                _EndTilingQCOM_fnptr = (delegate* unmanaged<BufferBitQCOM, void>)GLLoader.BindingsContext.GetProcAddress("glEndTilingQCOM");
                _EndTilingQCOM_fnptr(preserveMask);
            }
            
        }
    }
}

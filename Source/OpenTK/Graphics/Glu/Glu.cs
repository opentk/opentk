namespace OpenTK.Graphics
{
    using System;
    using System.Runtime.InteropServices;
    #pragma warning disable 3019
    #pragma warning disable 1591

    static partial class Glu
    {

        public static 
        void BeginCurve(IntPtr nurb)
        {
            Delegates.gluBeginCurve((IntPtr)nurb);
        }

        public static 
        void BeginPolygon(IntPtr tess)
        {
            Delegates.gluBeginPolygon((IntPtr)tess);
        }

        public static 
        void BeginSurface(IntPtr nurb)
        {
            Delegates.gluBeginSurface((IntPtr)nurb);
        }

        public static 
        void BeginTrim(IntPtr nurb)
        {
            Delegates.gluBeginTrim((IntPtr)nurb);
        }

        public static 
        Int32 Build1DMipmapLevel(TextureTarget target, Int32 internalFormat, Int32 width, PixelFormat format, PixelType type, Int32 level, Int32 @base, Int32 max, IntPtr data)
        {
            unsafe
            {
                return Delegates.gluBuild1DMipmapLevels((TextureTarget)target, (Int32)internalFormat, (Int32)width, (PixelFormat)format, (PixelType)type, (Int32)level, (Int32)@base, (Int32)max, (IntPtr)data);
            }
        }

        public static 
        Int32 Build1DMipmapLevel(TextureTarget target, Int32 internalFormat, Int32 width, PixelFormat format, PixelType type, Int32 level, Int32 @base, Int32 max, [In, Out] object data)
        {
            unsafe
            {
                System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
                try
                {
                    return Delegates.gluBuild1DMipmapLevels((TextureTarget)target, (Int32)internalFormat, (Int32)width, (PixelFormat)format, (PixelType)type, (Int32)level, (Int32)@base, (Int32)max, (IntPtr)data_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    data_ptr.Free();
                }
            }
        }

        public static 
        Int32 Build1DMipmap(TextureTarget target, Int32 internalFormat, Int32 width, PixelFormat format, PixelType type, IntPtr data)
        {
            unsafe
            {
                return Delegates.gluBuild1DMipmaps((TextureTarget)target, (Int32)internalFormat, (Int32)width, (PixelFormat)format, (PixelType)type, (IntPtr)data);
            }
        }

        public static 
        Int32 Build1DMipmap(TextureTarget target, Int32 internalFormat, Int32 width, PixelFormat format, PixelType type, [In, Out] object data)
        {
            unsafe
            {
                System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
                try
                {
                    return Delegates.gluBuild1DMipmaps((TextureTarget)target, (Int32)internalFormat, (Int32)width, (PixelFormat)format, (PixelType)type, (IntPtr)data_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    data_ptr.Free();
                }
            }
        }

        public static 
        Int32 Build2DMipmapLevel(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, PixelFormat format, PixelType type, Int32 level, Int32 @base, Int32 max, IntPtr data)
        {
            unsafe
            {
                return Delegates.gluBuild2DMipmapLevels((TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (PixelFormat)format, (PixelType)type, (Int32)level, (Int32)@base, (Int32)max, (IntPtr)data);
            }
        }

        public static 
        Int32 Build2DMipmapLevel(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, PixelFormat format, PixelType type, Int32 level, Int32 @base, Int32 max, [In, Out] object data)
        {
            unsafe
            {
                System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
                try
                {
                    return Delegates.gluBuild2DMipmapLevels((TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (PixelFormat)format, (PixelType)type, (Int32)level, (Int32)@base, (Int32)max, (IntPtr)data_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    data_ptr.Free();
                }
            }
        }

        public static 
        Int32 Build2DMipmap(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr data)
        {
            unsafe
            {
                return Delegates.gluBuild2DMipmaps((TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (PixelFormat)format, (PixelType)type, (IntPtr)data);
            }
        }

        public static 
        Int32 Build2DMipmap(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, PixelFormat format, PixelType type, [In, Out] object data)
        {
            unsafe
            {
                System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
                try
                {
                    return Delegates.gluBuild2DMipmaps((TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (PixelFormat)format, (PixelType)type, (IntPtr)data_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    data_ptr.Free();
                }
            }
        }

        public static 
        Int32 Build3DMipmapLevel(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, Int32 level, Int32 @base, Int32 max, IntPtr data)
        {
            unsafe
            {
                return Delegates.gluBuild3DMipmapLevels((TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (Int32)depth, (PixelFormat)format, (PixelType)type, (Int32)level, (Int32)@base, (Int32)max, (IntPtr)data);
            }
        }

        public static 
        Int32 Build3DMipmapLevel(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, Int32 level, Int32 @base, Int32 max, [In, Out] object data)
        {
            unsafe
            {
                System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
                try
                {
                    return Delegates.gluBuild3DMipmapLevels((TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (Int32)depth, (PixelFormat)format, (PixelType)type, (Int32)level, (Int32)@base, (Int32)max, (IntPtr)data_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    data_ptr.Free();
                }
            }
        }

        public static 
        Int32 Build3DMipmap(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr data)
        {
            unsafe
            {
                return Delegates.gluBuild3DMipmaps((TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (Int32)depth, (PixelFormat)format, (PixelType)type, (IntPtr)data);
            }
        }

        public static 
        Int32 Build3DMipmap(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, [In, Out] object data)
        {
            unsafe
            {
                System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
                try
                {
                    return Delegates.gluBuild3DMipmaps((TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (Int32)depth, (PixelFormat)format, (PixelType)type, (IntPtr)data_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    data_ptr.Free();
                }
            }
        }

        public static 
        bool CheckExtension(Byte[] extName, Byte[] extString)
        {
            unsafe
            {
                fixed (Byte* extName_ptr = extName)
                fixed (Byte* extString_ptr = extString)
                {
                    return Delegates.gluCheckExtension((Byte*)extName_ptr, (Byte*)extString_ptr);
                }
            }
        }

        public static 
        bool CheckExtension(ref Byte extName, ref Byte extString)
        {
            unsafe
            {
                fixed (Byte* extName_ptr = &extName)
                fixed (Byte* extString_ptr = &extString)
                {
                    return Delegates.gluCheckExtension((Byte*)extName_ptr, (Byte*)extString_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe bool CheckExtension(Byte* extName, Byte* extString)
        {
            return Delegates.gluCheckExtension((Byte*)extName, (Byte*)extString);
        }

        public static 
        void Cylinder(IntPtr quad, double @base, double top, double height, Int32 slices, Int32 stacks)
        {
            Delegates.gluCylinder((IntPtr)quad, (double)@base, (double)top, (double)height, (Int32)slices, (Int32)stacks);
        }

        public static 
        void DeleteNurbsRenderer(IntPtr nurb)
        {
            Delegates.gluDeleteNurbsRenderer((IntPtr)nurb);
        }

        public static 
        void DeleteQuadric(IntPtr quad)
        {
            Delegates.gluDeleteQuadric((IntPtr)quad);
        }

        public static 
        void DeleteTess(IntPtr tess)
        {
            Delegates.gluDeleteTess((IntPtr)tess);
        }

        public static 
        void Disk(IntPtr quad, double inner, double outer, Int32 slices, Int32 loops)
        {
            Delegates.gluDisk((IntPtr)quad, (double)inner, (double)outer, (Int32)slices, (Int32)loops);
        }

        public static 
        void EndCurve(IntPtr nurb)
        {
            Delegates.gluEndCurve((IntPtr)nurb);
        }

        public static 
        void EndPolygon(IntPtr tess)
        {
            Delegates.gluEndPolygon((IntPtr)tess);
        }

        public static 
        void EndSurface(IntPtr nurb)
        {
            Delegates.gluEndSurface((IntPtr)nurb);
        }

        public static 
        void EndTrim(IntPtr nurb)
        {
            Delegates.gluEndTrim((IntPtr)nurb);
        }

        public static 
        string ErrorString(OpenTK.Graphics.GluErrorCode error)
        {
            unsafe
            {
                return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Delegates.gluErrorString((OpenTK.Graphics.GluErrorCode)error));
            }
        }

        public static 
        string GetString(OpenTK.Graphics.GluStringName name)
        {
            unsafe
            {
                return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Delegates.gluGetString((OpenTK.Graphics.GluStringName)name));
            }
        }

        public static 
        void GetNurbsProperty(IntPtr nurb, OpenTK.Graphics.NurbsProperty property, [Out] float[] data)
        {
            unsafe
            {
                fixed (float* data_ptr = data)
                {
                    Delegates.gluGetNurbsProperty((IntPtr)nurb, (OpenTK.Graphics.NurbsProperty)property, (float*)data_ptr);
                }
            }
        }

        public static 
        void GetNurbsProperty(IntPtr nurb, OpenTK.Graphics.NurbsProperty property, [Out] out float data)
        {
            unsafe
            {
                fixed (float* data_ptr = &data)
                {
                    Delegates.gluGetNurbsProperty((IntPtr)nurb, (OpenTK.Graphics.NurbsProperty)property, (float*)data_ptr);
                    data = *data_ptr;
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void GetNurbsProperty(IntPtr nurb, OpenTK.Graphics.NurbsProperty property, [Out] float* data)
        {
            Delegates.gluGetNurbsProperty((IntPtr)nurb, (OpenTK.Graphics.NurbsProperty)property, (float*)data);
        }

        public static 
        void GetTessProperty(IntPtr tess, OpenTK.Graphics.TessParameter which, [Out] double[] data)
        {
            unsafe
            {
                fixed (double* data_ptr = data)
                {
                    Delegates.gluGetTessProperty((IntPtr)tess, (OpenTK.Graphics.TessParameter)which, (double*)data_ptr);
                }
            }
        }

        public static 
        void GetTessProperty(IntPtr tess, OpenTK.Graphics.TessParameter which, [Out] out double data)
        {
            unsafe
            {
                fixed (double* data_ptr = &data)
                {
                    Delegates.gluGetTessProperty((IntPtr)tess, (OpenTK.Graphics.TessParameter)which, (double*)data_ptr);
                    data = *data_ptr;
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void GetTessProperty(IntPtr tess, OpenTK.Graphics.TessParameter which, [Out] double* data)
        {
            Delegates.gluGetTessProperty((IntPtr)tess, (OpenTK.Graphics.TessParameter)which, (double*)data);
        }

        public static 
        void LoadSamplingMatrices(IntPtr nurb, float[] model, float[] perspective, Int32[] view)
        {
            unsafe
            {
                fixed (float* model_ptr = model)
                fixed (float* perspective_ptr = perspective)
                fixed (Int32* view_ptr = view)
                {
                    Delegates.gluLoadSamplingMatrices((IntPtr)nurb, (float*)model_ptr, (float*)perspective_ptr, (Int32*)view_ptr);
                }
            }
        }

        public static 
        void LoadSamplingMatrices(IntPtr nurb, ref float model, ref float perspective, ref Int32 view)
        {
            unsafe
            {
                fixed (float* model_ptr = &model)
                fixed (float* perspective_ptr = &perspective)
                fixed (Int32* view_ptr = &view)
                {
                    Delegates.gluLoadSamplingMatrices((IntPtr)nurb, (float*)model_ptr, (float*)perspective_ptr, (Int32*)view_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void LoadSamplingMatrices(IntPtr nurb, float* model, float* perspective, Int32* view)
        {
            Delegates.gluLoadSamplingMatrices((IntPtr)nurb, (float*)model, (float*)perspective, (Int32*)view);
        }

        public static 
        void LookAt(double eyeX, double eyeY, double eyeZ, double centerX, double centerY, double centerZ, double upX, double upY, double upZ)
        {
            Delegates.gluLookAt((double)eyeX, (double)eyeY, (double)eyeZ, (double)centerX, (double)centerY, (double)centerZ, (double)upX, (double)upY, (double)upZ);
        }

        public static 
        IntPtr NewNurbsRenderer()
        {
            return Delegates.gluNewNurbsRenderer();
        }

        public static 
        IntPtr NewQuadric()
        {
            return Delegates.gluNewQuadric();
        }

        public static 
        IntPtr NewTess()
        {
            return Delegates.gluNewTess();
        }

        public static 
        void NextContour(IntPtr tess, OpenTK.Graphics.TessContour type)
        {
            Delegates.gluNextContour((IntPtr)tess, (OpenTK.Graphics.TessContour)type);
        }

        public static 
        void NurbsCallback(IntPtr nurb, OpenTK.Graphics.NurbsCallback which, Delegate CallBackFunc)
        {
            Delegates.gluNurbsCallback((IntPtr)nurb, (OpenTK.Graphics.NurbsCallback)which, (Delegate)CallBackFunc);
        }

        public static 
        void NurbsCallbackData(IntPtr nurb, IntPtr userData)
        {
            unsafe
            {
                Delegates.gluNurbsCallbackData((IntPtr)nurb, (IntPtr)userData);
            }
        }

        public static 
        void NurbsCallbackData(IntPtr nurb, [In, Out] object userData)
        {
            unsafe
            {
                System.Runtime.InteropServices.GCHandle userData_ptr = System.Runtime.InteropServices.GCHandle.Alloc(userData, System.Runtime.InteropServices.GCHandleType.Pinned);
                try
                {
                    Delegates.gluNurbsCallbackData((IntPtr)nurb, (IntPtr)userData_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    userData_ptr.Free();
                }
            }
        }

        public static 
        void NurbsCurve(IntPtr nurb, Int32 knotCount, [Out] float[] knots, Int32 stride, [Out] float[] control, Int32 order, MapTarget type)
        {
            unsafe
            {
                fixed (float* knots_ptr = knots)
                fixed (float* control_ptr = control)
                {
                    Delegates.gluNurbsCurve((IntPtr)nurb, (Int32)knotCount, (float*)knots_ptr, (Int32)stride, (float*)control_ptr, (Int32)order, (MapTarget)type);
                }
            }
        }

        public static 
        void NurbsCurve(IntPtr nurb, Int32 knotCount, [Out] out float knots, Int32 stride, [Out] out float control, Int32 order, MapTarget type)
        {
            unsafe
            {
                fixed (float* knots_ptr = &knots)
                fixed (float* control_ptr = &control)
                {
                    Delegates.gluNurbsCurve((IntPtr)nurb, (Int32)knotCount, (float*)knots_ptr, (Int32)stride, (float*)control_ptr, (Int32)order, (MapTarget)type);
                    knots = *knots_ptr;
                    control = *control_ptr;
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void NurbsCurve(IntPtr nurb, Int32 knotCount, [Out] float* knots, Int32 stride, [Out] float* control, Int32 order, MapTarget type)
        {
            Delegates.gluNurbsCurve((IntPtr)nurb, (Int32)knotCount, (float*)knots, (Int32)stride, (float*)control, (Int32)order, (MapTarget)type);
        }

        public static 
        void NurbsProperty(IntPtr nurb, OpenTK.Graphics.NurbsProperty property, float value)
        {
            Delegates.gluNurbsProperty((IntPtr)nurb, (OpenTK.Graphics.NurbsProperty)property, (float)value);
        }

        public static 
        void NurbsSurface(IntPtr nurb, Int32 sKnotCount, float[] sKnots, Int32 tKnotCount, float[] tKnots, Int32 sStride, Int32 tStride, float[] control, Int32 sOrder, Int32 tOrder, MapTarget type)
        {
            unsafe
            {
                fixed (float* sKnots_ptr = sKnots)
                fixed (float* tKnots_ptr = tKnots)
                fixed (float* control_ptr = control)
                {
                    Delegates.gluNurbsSurface((IntPtr)nurb, (Int32)sKnotCount, (float*)sKnots_ptr, (Int32)tKnotCount, (float*)tKnots_ptr, (Int32)sStride, (Int32)tStride, (float*)control_ptr, (Int32)sOrder, (Int32)tOrder, (MapTarget)type);
                }
            }
        }

        public static 
        void NurbsSurface(IntPtr nurb, Int32 sKnotCount, ref float sKnots, Int32 tKnotCount, ref float tKnots, Int32 sStride, Int32 tStride, ref float control, Int32 sOrder, Int32 tOrder, MapTarget type)
        {
            unsafe
            {
                fixed (float* sKnots_ptr = &sKnots)
                fixed (float* tKnots_ptr = &tKnots)
                fixed (float* control_ptr = &control)
                {
                    Delegates.gluNurbsSurface((IntPtr)nurb, (Int32)sKnotCount, (float*)sKnots_ptr, (Int32)tKnotCount, (float*)tKnots_ptr, (Int32)sStride, (Int32)tStride, (float*)control_ptr, (Int32)sOrder, (Int32)tOrder, (MapTarget)type);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void NurbsSurface(IntPtr nurb, Int32 sKnotCount, float* sKnots, Int32 tKnotCount, float* tKnots, Int32 sStride, Int32 tStride, float* control, Int32 sOrder, Int32 tOrder, MapTarget type)
        {
            Delegates.gluNurbsSurface((IntPtr)nurb, (Int32)sKnotCount, (float*)sKnots, (Int32)tKnotCount, (float*)tKnots, (Int32)sStride, (Int32)tStride, (float*)control, (Int32)sOrder, (Int32)tOrder, (MapTarget)type);
        }

        public static 
        void Ortho2D(double left, double right, double bottom, double top)
        {
            Delegates.gluOrtho2D((double)left, (double)right, (double)bottom, (double)top);
        }

        public static 
        void PartialDisk(IntPtr quad, double inner, double outer, Int32 slices, Int32 loops, double start, double sweep)
        {
            Delegates.gluPartialDisk((IntPtr)quad, (double)inner, (double)outer, (Int32)slices, (Int32)loops, (double)start, (double)sweep);
        }

        public static 
        void Perspective(double fovy, double aspect, double zNear, double zFar)
        {
            Delegates.gluPerspective((double)fovy, (double)aspect, (double)zNear, (double)zFar);
        }

        public static 
        void PickMatrix(double x, double y, double delX, double delY, [Out] Int32[] viewport)
        {
            unsafe
            {
                fixed (Int32* viewport_ptr = viewport)
                {
                    Delegates.gluPickMatrix((double)x, (double)y, (double)delX, (double)delY, (Int32*)viewport_ptr);
                }
            }
        }

        public static 
        void PickMatrix(double x, double y, double delX, double delY, [Out] out Int32 viewport)
        {
            unsafe
            {
                fixed (Int32* viewport_ptr = &viewport)
                {
                    Delegates.gluPickMatrix((double)x, (double)y, (double)delX, (double)delY, (Int32*)viewport_ptr);
                    viewport = *viewport_ptr;
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void PickMatrix(double x, double y, double delX, double delY, [Out] Int32* viewport)
        {
            Delegates.gluPickMatrix((double)x, (double)y, (double)delX, (double)delY, (Int32*)viewport);
        }

        public static 
        Int32 Project(double objX, double objY, double objZ, double[] model, double[] proj, Int32[] view, double[] winX, double[] winY, double[] winZ)
        {
            unsafe
            {
                fixed (double* model_ptr = model)
                fixed (double* proj_ptr = proj)
                fixed (Int32* view_ptr = view)
                fixed (double* winX_ptr = winX)
                fixed (double* winY_ptr = winY)
                fixed (double* winZ_ptr = winZ)
                {
                    return Delegates.gluProject((double)objX, (double)objY, (double)objZ, (double*)model_ptr, (double*)proj_ptr, (Int32*)view_ptr, (double*)winX_ptr, (double*)winY_ptr, (double*)winZ_ptr);
                }
            }
        }

        public static 
        Int32 Project(double objX, double objY, double objZ, ref double model, ref double proj, ref Int32 view, ref double winX, ref double winY, ref double winZ)
        {
            unsafe
            {
                fixed (double* model_ptr = &model)
                fixed (double* proj_ptr = &proj)
                fixed (Int32* view_ptr = &view)
                fixed (double* winX_ptr = &winX)
                fixed (double* winY_ptr = &winY)
                fixed (double* winZ_ptr = &winZ)
                {
                    return Delegates.gluProject((double)objX, (double)objY, (double)objZ, (double*)model_ptr, (double*)proj_ptr, (Int32*)view_ptr, (double*)winX_ptr, (double*)winY_ptr, (double*)winZ_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe Int32 Project(double objX, double objY, double objZ, double* model, double* proj, Int32* view, double* winX, double* winY, double* winZ)
        {
            return Delegates.gluProject((double)objX, (double)objY, (double)objZ, (double*)model, (double*)proj, (Int32*)view, (double*)winX, (double*)winY, (double*)winZ);
        }

        public static 
        void PwlCurve(IntPtr nurb, Int32 count, float[] data, Int32 stride, OpenTK.Graphics.NurbsTrim type)
        {
            unsafe
            {
                fixed (float* data_ptr = data)
                {
                    Delegates.gluPwlCurve((IntPtr)nurb, (Int32)count, (float*)data_ptr, (Int32)stride, (OpenTK.Graphics.NurbsTrim)type);
                }
            }
        }

        public static 
        void PwlCurve(IntPtr nurb, Int32 count, ref float data, Int32 stride, OpenTK.Graphics.NurbsTrim type)
        {
            unsafe
            {
                fixed (float* data_ptr = &data)
                {
                    Delegates.gluPwlCurve((IntPtr)nurb, (Int32)count, (float*)data_ptr, (Int32)stride, (OpenTK.Graphics.NurbsTrim)type);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void PwlCurve(IntPtr nurb, Int32 count, float* data, Int32 stride, OpenTK.Graphics.NurbsTrim type)
        {
            Delegates.gluPwlCurve((IntPtr)nurb, (Int32)count, (float*)data, (Int32)stride, (OpenTK.Graphics.NurbsTrim)type);
        }

        public static 
        void QuadricCallback(IntPtr quad, OpenTK.Graphics.QuadricCallback which, Delegate CallBackFunc)
        {
            Delegates.gluQuadricCallback((IntPtr)quad, (OpenTK.Graphics.QuadricCallback)which, (Delegate)CallBackFunc);
        }

        public static 
        void QuadricDrawStyle(IntPtr quad, OpenTK.Graphics.QuadricDrawStyle draw)
        {
            Delegates.gluQuadricDrawStyle((IntPtr)quad, (OpenTK.Graphics.QuadricDrawStyle)draw);
        }

        public static 
        void QuadricNormal(IntPtr quad, OpenTK.Graphics.QuadricNormal normal)
        {
            Delegates.gluQuadricNormals((IntPtr)quad, (OpenTK.Graphics.QuadricNormal)normal);
        }

        public static 
        void QuadricOrientation(IntPtr quad, OpenTK.Graphics.QuadricOrientation orientation)
        {
            Delegates.gluQuadricOrientation((IntPtr)quad, (OpenTK.Graphics.QuadricOrientation)orientation);
        }

        public static 
        void QuadricTexture(IntPtr quad, bool texture)
        {
            Delegates.gluQuadricTexture((IntPtr)quad, (bool)texture);
        }

        public static 
        Int32 ScaleImage(PixelFormat format, Int32 wIn, Int32 hIn, PixelType typeIn, IntPtr dataIn, Int32 wOut, Int32 hOut, PixelType typeOut, [Out] IntPtr dataOut)
        {
            unsafe
            {
                return Delegates.gluScaleImage((PixelFormat)format, (Int32)wIn, (Int32)hIn, (PixelType)typeIn, (IntPtr)dataIn, (Int32)wOut, (Int32)hOut, (PixelType)typeOut, (IntPtr)dataOut);
            }
        }

        public static 
        Int32 ScaleImage(PixelFormat format, Int32 wIn, Int32 hIn, PixelType typeIn, [In, Out] object dataIn, Int32 wOut, Int32 hOut, PixelType typeOut, [In, Out] object dataOut)
        {
            unsafe
            {
                System.Runtime.InteropServices.GCHandle dataIn_ptr = System.Runtime.InteropServices.GCHandle.Alloc(dataIn, System.Runtime.InteropServices.GCHandleType.Pinned);
                System.Runtime.InteropServices.GCHandle dataOut_ptr = System.Runtime.InteropServices.GCHandle.Alloc(dataOut, System.Runtime.InteropServices.GCHandleType.Pinned);
                try
                {
                    return Delegates.gluScaleImage((PixelFormat)format, (Int32)wIn, (Int32)hIn, (PixelType)typeIn, (IntPtr)dataIn_ptr.AddrOfPinnedObject(), (Int32)wOut, (Int32)hOut, (PixelType)typeOut, (IntPtr)dataOut_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    dataIn_ptr.Free();
                    dataOut_ptr.Free();
                }
            }
        }

        public static 
        void Sphere(IntPtr quad, double radius, Int32 slices, Int32 stacks)
        {
            Delegates.gluSphere((IntPtr)quad, (double)radius, (Int32)slices, (Int32)stacks);
        }

        public static 
        void TessBeginContour(IntPtr tess)
        {
            Delegates.gluTessBeginContour((IntPtr)tess);
        }

        public static 
        void TessBeginPolygon(IntPtr tess, IntPtr data)
        {
            unsafe
            {
                Delegates.gluTessBeginPolygon((IntPtr)tess, (IntPtr)data);
            }
        }

        public static 
        void TessBeginPolygon(IntPtr tess, [In, Out] object data)
        {
            unsafe
            {
                System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
                try
                {
                    Delegates.gluTessBeginPolygon((IntPtr)tess, (IntPtr)data_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    data_ptr.Free();
                }
            }
        }

        public static 
        void TessCallback(IntPtr tess, OpenTK.Graphics.TessCallback which, Delegate CallBackFunc)
        {
            Delegates.gluTessCallback((IntPtr)tess, (OpenTK.Graphics.TessCallback)which, (Delegate)CallBackFunc);
        }

        public static 
        void TessEndContour(IntPtr tess)
        {
            Delegates.gluTessEndContour((IntPtr)tess);
        }

        public static 
        void TessEndPolygon(IntPtr tess)
        {
            Delegates.gluTessEndPolygon((IntPtr)tess);
        }

        public static 
        void TessNormal(IntPtr tess, double valueX, double valueY, double valueZ)
        {
            Delegates.gluTessNormal((IntPtr)tess, (double)valueX, (double)valueY, (double)valueZ);
        }

        public static 
        void TessProperty(IntPtr tess, OpenTK.Graphics.TessParameter which, double data)
        {
            Delegates.gluTessProperty((IntPtr)tess, (OpenTK.Graphics.TessParameter)which, (double)data);
        }

        public static 
        void TessVertex(IntPtr tess, double[] location, IntPtr data)
        {
            unsafe
            {
                fixed (double* location_ptr = location)
                {
                    Delegates.gluTessVertex((IntPtr)tess, (double*)location_ptr, (IntPtr)data);
                }
            }
        }

        public static 
        void TessVertex(IntPtr tess, double[] location, [In, Out] object data)
        {
            unsafe
            {
                fixed (double* location_ptr = location)
                {
                    System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        Delegates.gluTessVertex((IntPtr)tess, (double*)location_ptr, (IntPtr)data_ptr.AddrOfPinnedObject());
                    }
                    finally
                    {
                        data_ptr.Free();
                    }
                }
            }
        }

        public static 
        void TessVertex(IntPtr tess, ref double location, IntPtr data)
        {
            unsafe
            {
                fixed (double* location_ptr = &location)
                {
                    Delegates.gluTessVertex((IntPtr)tess, (double*)location_ptr, (IntPtr)data);
                }
            }
        }

        public static 
        void TessVertex(IntPtr tess, ref double location, [In, Out] object data)
        {
            unsafe
            {
                fixed (double* location_ptr = &location)
                {
                    System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        Delegates.gluTessVertex((IntPtr)tess, (double*)location_ptr, (IntPtr)data_ptr.AddrOfPinnedObject());
                    }
                    finally
                    {
                        data_ptr.Free();
                    }
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void TessVertex(IntPtr tess, double* location, IntPtr data)
        {
            Delegates.gluTessVertex((IntPtr)tess, (double*)location, (IntPtr)data);
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void TessVertex(IntPtr tess, double* location, [In, Out] object data)
        {
            System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
            try
            {
                Delegates.gluTessVertex((IntPtr)tess, (double*)location, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
        }

        public static 
        Int32 UnProject(double winX, double winY, double winZ, double[] model, double[] proj, Int32[] view, double[] objX, double[] objY, double[] objZ)
        {
            unsafe
            {
                fixed (double* model_ptr = model)
                fixed (double* proj_ptr = proj)
                fixed (Int32* view_ptr = view)
                fixed (double* objX_ptr = objX)
                fixed (double* objY_ptr = objY)
                fixed (double* objZ_ptr = objZ)
                {
                    return Delegates.gluUnProject((double)winX, (double)winY, (double)winZ, (double*)model_ptr, (double*)proj_ptr, (Int32*)view_ptr, (double*)objX_ptr, (double*)objY_ptr, (double*)objZ_ptr);
                }
            }
        }

        public static 
        Int32 UnProject(double winX, double winY, double winZ, ref double model, ref double proj, ref Int32 view, ref double objX, ref double objY, ref double objZ)
        {
            unsafe
            {
                fixed (double* model_ptr = &model)
                fixed (double* proj_ptr = &proj)
                fixed (Int32* view_ptr = &view)
                fixed (double* objX_ptr = &objX)
                fixed (double* objY_ptr = &objY)
                fixed (double* objZ_ptr = &objZ)
                {
                    return Delegates.gluUnProject((double)winX, (double)winY, (double)winZ, (double*)model_ptr, (double*)proj_ptr, (Int32*)view_ptr, (double*)objX_ptr, (double*)objY_ptr, (double*)objZ_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe Int32 UnProject(double winX, double winY, double winZ, double* model, double* proj, Int32* view, double* objX, double* objY, double* objZ)
        {
            return Delegates.gluUnProject((double)winX, (double)winY, (double)winZ, (double*)model, (double*)proj, (Int32*)view, (double*)objX, (double*)objY, (double*)objZ);
        }

        public static 
        Int32 UnProject4(double winX, double winY, double winZ, double clipW, double[] model, double[] proj, Int32[] view, double near, double far, double[] objX, double[] objY, double[] objZ, double[] objW)
        {
            unsafe
            {
                fixed (double* model_ptr = model)
                fixed (double* proj_ptr = proj)
                fixed (Int32* view_ptr = view)
                fixed (double* objX_ptr = objX)
                fixed (double* objY_ptr = objY)
                fixed (double* objZ_ptr = objZ)
                fixed (double* objW_ptr = objW)
                {
                    return Delegates.gluUnProject4((double)winX, (double)winY, (double)winZ, (double)clipW, (double*)model_ptr, (double*)proj_ptr, (Int32*)view_ptr, (double)near, (double)far, (double*)objX_ptr, (double*)objY_ptr, (double*)objZ_ptr, (double*)objW_ptr);
                }
            }
        }

        public static 
        Int32 UnProject4(double winX, double winY, double winZ, double clipW, ref double model, ref double proj, ref Int32 view, double near, double far, ref double objX, ref double objY, ref double objZ, ref double objW)
        {
            unsafe
            {
                fixed (double* model_ptr = &model)
                fixed (double* proj_ptr = &proj)
                fixed (Int32* view_ptr = &view)
                fixed (double* objX_ptr = &objX)
                fixed (double* objY_ptr = &objY)
                fixed (double* objZ_ptr = &objZ)
                fixed (double* objW_ptr = &objW)
                {
                    return Delegates.gluUnProject4((double)winX, (double)winY, (double)winZ, (double)clipW, (double*)model_ptr, (double*)proj_ptr, (Int32*)view_ptr, (double)near, (double)far, (double*)objX_ptr, (double*)objY_ptr, (double*)objZ_ptr, (double*)objW_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe Int32 UnProject4(double winX, double winY, double winZ, double clipW, double* model, double* proj, Int32* view, double near, double far, double* objX, double* objY, double* objZ, double* objW)
        {
            return Delegates.gluUnProject4((double)winX, (double)winY, (double)winZ, (double)clipW, (double*)model, (double*)proj, (Int32*)view, (double)near, (double)far, (double*)objX, (double*)objY, (double*)objZ, (double*)objW);
        }

        public static partial class Ext
        {
            public static 
            void NurbsCallbackData(IntPtr nurb, IntPtr userData)
            {
                unsafe
                {
                    Delegates.gluNurbsCallbackDataEXT((IntPtr)nurb, (IntPtr)userData);
                }
            }

            public static 
            void NurbsCallbackData(IntPtr nurb, [In, Out] object userData)
            {
                unsafe
                {
                    System.Runtime.InteropServices.GCHandle userData_ptr = System.Runtime.InteropServices.GCHandle.Alloc(userData, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        Delegates.gluNurbsCallbackDataEXT((IntPtr)nurb, (IntPtr)userData_ptr.AddrOfPinnedObject());
                    }
                    finally
                    {
                        userData_ptr.Free();
                    }
                }
            }

        }

        public static partial class Sgi
        {
            public static 
            Int32 TexFilterFunc(TextureTarget target, SgisTextureFilter4 filtertype, float[] parms, Int32 n, [Out] float[] weights)
            {
                unsafe
                {
                    fixed (float* parms_ptr = parms)
                    fixed (float* weights_ptr = weights)
                    {
                        return Delegates.gluTexFilterFuncSGI((TextureTarget)target, (SgisTextureFilter4)filtertype, (float*)parms_ptr, (Int32)n, (float*)weights_ptr);
                    }
                }
            }

            public static 
            Int32 TexFilterFunc(TextureTarget target, SgisTextureFilter4 filtertype, ref float parms, Int32 n, [Out] out float weights)
            {
                unsafe
                {
                    fixed (float* parms_ptr = &parms)
                    fixed (float* weights_ptr = &weights)
                    {
                        Int32 retval = Delegates.gluTexFilterFuncSGI((TextureTarget)target, (SgisTextureFilter4)filtertype, (float*)parms_ptr, (Int32)n, (float*)weights_ptr);
                        weights = *weights_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Int32 TexFilterFunc(TextureTarget target, SgisTextureFilter4 filtertype, float* parms, Int32 n, [Out] float* weights)
            {
                return Delegates.gluTexFilterFuncSGI((TextureTarget)target, (SgisTextureFilter4)filtertype, (float*)parms, (Int32)n, (float*)weights);
            }

        }

    }
}

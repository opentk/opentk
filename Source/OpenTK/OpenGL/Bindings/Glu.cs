namespace OpenTK.OpenGL
{
    using System;
    using System.Runtime.InteropServices;

    public static partial class Glu
    {

        public static 
        void BeginCurve(int nurb)
        {
            Delegates.gluBeginCurve((int)nurb);
        }

        public static 
        void BeginPolygon(int tess)
        {
            Delegates.gluBeginPolygon((int)tess);
        }

        public static 
        void BeginSurface(int nurb)
        {
            Delegates.gluBeginSurface((int)nurb);
        }

        public static 
        void BeginTrim(int nurb)
        {
            Delegates.gluBeginTrim((int)nurb);
        }

        public static 
        Int32 Build1DMipmapLevel(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, Int32 level, Int32 @base, Int32 max, IntPtr data)
        {
            return Delegates.gluBuild1DMipmapLevels((OpenTK.OpenGL.Enums.TextureTarget)target, (Int32)internalFormat, (Int32)width, (OpenTK.OpenGL.Enums.PixelFormat)format, (OpenTK.OpenGL.Enums.PixelType)type, (Int32)level, (Int32)@base, (Int32)max, (IntPtr)data);
        }

        public static 
        Int32 Build1DMipmapLevel(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, Int32 level, Int32 @base, Int32 max, [In, Out] object data)
        {
            System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
            try
            {
                return Delegates.gluBuild1DMipmapLevels((OpenTK.OpenGL.Enums.TextureTarget)target, (Int32)internalFormat, (Int32)width, (OpenTK.OpenGL.Enums.PixelFormat)format, (OpenTK.OpenGL.Enums.PixelType)type, (Int32)level, (Int32)@base, (Int32)max, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
        }

        public static 
        Int32 Build1DMipmap(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, IntPtr data)
        {
            return Delegates.gluBuild1DMipmaps((OpenTK.OpenGL.Enums.TextureTarget)target, (Int32)internalFormat, (Int32)width, (OpenTK.OpenGL.Enums.PixelFormat)format, (OpenTK.OpenGL.Enums.PixelType)type, (IntPtr)data);
        }

        public static 
        Int32 Build1DMipmap(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, [In, Out] object data)
        {
            System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
            try
            {
                return Delegates.gluBuild1DMipmaps((OpenTK.OpenGL.Enums.TextureTarget)target, (Int32)internalFormat, (Int32)width, (OpenTK.OpenGL.Enums.PixelFormat)format, (OpenTK.OpenGL.Enums.PixelType)type, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
        }

        public static 
        Int32 Build2DMipmapLevel(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, Int32 level, Int32 @base, Int32 max, IntPtr data)
        {
            return Delegates.gluBuild2DMipmapLevels((OpenTK.OpenGL.Enums.TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (OpenTK.OpenGL.Enums.PixelFormat)format, (OpenTK.OpenGL.Enums.PixelType)type, (Int32)level, (Int32)@base, (Int32)max, (IntPtr)data);
        }

        public static 
        Int32 Build2DMipmapLevel(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, Int32 level, Int32 @base, Int32 max, [In, Out] object data)
        {
            System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
            try
            {
                return Delegates.gluBuild2DMipmapLevels((OpenTK.OpenGL.Enums.TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (OpenTK.OpenGL.Enums.PixelFormat)format, (OpenTK.OpenGL.Enums.PixelType)type, (Int32)level, (Int32)@base, (Int32)max, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
        }

        public static 
        Int32 Build2DMipmap(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, IntPtr data)
        {
            return Delegates.gluBuild2DMipmaps((OpenTK.OpenGL.Enums.TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (OpenTK.OpenGL.Enums.PixelFormat)format, (OpenTK.OpenGL.Enums.PixelType)type, (IntPtr)data);
        }

        public static 
        Int32 Build2DMipmap(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, [In, Out] object data)
        {
            System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
            try
            {
                return Delegates.gluBuild2DMipmaps((OpenTK.OpenGL.Enums.TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (OpenTK.OpenGL.Enums.PixelFormat)format, (OpenTK.OpenGL.Enums.PixelType)type, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
        }

        public static 
        Int32 Build3DMipmapLevel(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, Int32 level, Int32 @base, Int32 max, IntPtr data)
        {
            return Delegates.gluBuild3DMipmapLevels((OpenTK.OpenGL.Enums.TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.OpenGL.Enums.PixelFormat)format, (OpenTK.OpenGL.Enums.PixelType)type, (Int32)level, (Int32)@base, (Int32)max, (IntPtr)data);
        }

        public static 
        Int32 Build3DMipmapLevel(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, Int32 level, Int32 @base, Int32 max, [In, Out] object data)
        {
            System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
            try
            {
                return Delegates.gluBuild3DMipmapLevels((OpenTK.OpenGL.Enums.TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.OpenGL.Enums.PixelFormat)format, (OpenTK.OpenGL.Enums.PixelType)type, (Int32)level, (Int32)@base, (Int32)max, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
        }

        public static 
        Int32 Build3DMipmap(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, IntPtr data)
        {
            return Delegates.gluBuild3DMipmaps((OpenTK.OpenGL.Enums.TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.OpenGL.Enums.PixelFormat)format, (OpenTK.OpenGL.Enums.PixelType)type, (IntPtr)data);
        }

        public static 
        Int32 Build3DMipmap(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, [In, Out] object data)
        {
            System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
            try
            {
                return Delegates.gluBuild3DMipmaps((OpenTK.OpenGL.Enums.TextureTarget)target, (Int32)internalFormat, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.OpenGL.Enums.PixelFormat)format, (OpenTK.OpenGL.Enums.PixelType)type, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
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
        void Cylinder(int quad, double @base, double top, double height, Int32 slices, Int32 stacks)
        {
            Delegates.gluCylinder((int)quad, (double)@base, (double)top, (double)height, (Int32)slices, (Int32)stacks);
        }

        public static 
        void DeleteNurbsRenderer(int nurb)
        {
            Delegates.gluDeleteNurbsRenderer((int)nurb);
        }

        public static 
        void DeleteQuadric(int quad)
        {
            Delegates.gluDeleteQuadric((int)quad);
        }

        public static 
        void DeleteTes(int tess)
        {
            Delegates.gluDeleteTess((int)tess);
        }

        public static 
        void Disk(int quad, double inner, double outer, Int32 slices, Int32 loops)
        {
            Delegates.gluDisk((int)quad, (double)inner, (double)outer, (Int32)slices, (Int32)loops);
        }

        public static 
        void EndCurve(int nurb)
        {
            Delegates.gluEndCurve((int)nurb);
        }

        public static 
        void EndPolygon(int tess)
        {
            Delegates.gluEndPolygon((int)tess);
        }

        public static 
        void EndSurface(int nurb)
        {
            Delegates.gluEndSurface((int)nurb);
        }

        public static 
        void EndTrim(int nurb)
        {
            Delegates.gluEndTrim((int)nurb);
        }

        public static 
        string ErrorString(OpenTK.OpenGL.Enums.GluErrorCode error)
        {
            return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Delegates.gluErrorString((OpenTK.OpenGL.Enums.GluErrorCode)error));
        }

        public static 
        string GetString(OpenTK.OpenGL.Enums.GluStringName name)
        {
            return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Delegates.gluGetString((OpenTK.OpenGL.Enums.GluStringName)name));
        }

        public static 
        void GetNurbsProperty(int nurb, OpenTK.OpenGL.Enums.NurbsProperty property, [Out] float[] data)
        {
            unsafe
            {
                fixed (float* data_ptr = data)
                {
                    Delegates.gluGetNurbsProperty((int)nurb, (OpenTK.OpenGL.Enums.NurbsProperty)property, (float*)data_ptr);
                }
            }
        }

        public static 
        void GetNurbsProperty(int nurb, OpenTK.OpenGL.Enums.NurbsProperty property, [Out] out float data)
        {
            unsafe
            {
                fixed (float* data_ptr = &data)
                {
                    Delegates.gluGetNurbsProperty((int)nurb, (OpenTK.OpenGL.Enums.NurbsProperty)property, (float*)data_ptr);
                    data = *data_ptr;
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void GetNurbsProperty(int nurb, OpenTK.OpenGL.Enums.NurbsProperty property, [Out] float* data)
        {
            Delegates.gluGetNurbsProperty((int)nurb, (OpenTK.OpenGL.Enums.NurbsProperty)property, (float*)data);
        }

        public static 
        void GetTessProperty(int tess, OpenTK.OpenGL.Enums.TessProperty which, [Out] double[] data)
        {
            unsafe
            {
                fixed (double* data_ptr = data)
                {
                    Delegates.gluGetTessProperty((int)tess, (OpenTK.OpenGL.Enums.TessProperty)which, (double*)data_ptr);
                }
            }
        }

        public static 
        void GetTessProperty(int tess, OpenTK.OpenGL.Enums.TessProperty which, [Out] out double data)
        {
            unsafe
            {
                fixed (double* data_ptr = &data)
                {
                    Delegates.gluGetTessProperty((int)tess, (OpenTK.OpenGL.Enums.TessProperty)which, (double*)data_ptr);
                    data = *data_ptr;
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void GetTessProperty(int tess, OpenTK.OpenGL.Enums.TessProperty which, [Out] double* data)
        {
            Delegates.gluGetTessProperty((int)tess, (OpenTK.OpenGL.Enums.TessProperty)which, (double*)data);
        }

        public static 
        void LoadSamplingMatrices(int nurb, float[] model, float[] perspective, Int32[] view)
        {
            unsafe
            {
                fixed (float* model_ptr = model)
                fixed (float* perspective_ptr = perspective)
                fixed (Int32* view_ptr = view)
                {
                    Delegates.gluLoadSamplingMatrices((int)nurb, (float*)model_ptr, (float*)perspective_ptr, (Int32*)view_ptr);
                }
            }
        }

        public static 
        void LoadSamplingMatrices(int nurb, ref float model, ref float perspective, ref Int32 view)
        {
            unsafe
            {
                fixed (float* model_ptr = &model)
                fixed (float* perspective_ptr = &perspective)
                fixed (Int32* view_ptr = &view)
                {
                    Delegates.gluLoadSamplingMatrices((int)nurb, (float*)model_ptr, (float*)perspective_ptr, (Int32*)view_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void LoadSamplingMatrices(int nurb, float* model, float* perspective, Int32* view)
        {
            Delegates.gluLoadSamplingMatrices((int)nurb, (float*)model, (float*)perspective, (Int32*)view);
        }

        public static 
        void LookAt(double eyeX, double eyeY, double eyeZ, double centerX, double centerY, double centerZ, double upX, double upY, double upZ)
        {
            Delegates.gluLookAt((double)eyeX, (double)eyeY, (double)eyeZ, (double)centerX, (double)centerY, (double)centerZ, (double)upX, (double)upY, (double)upZ);
        }

        public static 
        int NewNurbsRenderer()
        {
            return Delegates.gluNewNurbsRenderer();
        }

        public static 
        int NewQuadric()
        {
            return Delegates.gluNewQuadric();
        }

        public static 
        int NewTes()
        {
            return Delegates.gluNewTess();
        }

        public static 
        void NextContour(int tess, OpenTK.OpenGL.Enums.TessContour type)
        {
            Delegates.gluNextContour((int)tess, (OpenTK.OpenGL.Enums.TessContour)type);
        }

        public static 
        void NurbsCallback(int nurb, OpenTK.OpenGL.Enums.NurbsCallback which, IntPtr CallBackFunc)
        {
            Delegates.gluNurbsCallback((int)nurb, (OpenTK.OpenGL.Enums.NurbsCallback)which, (IntPtr)CallBackFunc);
        }

        public static 
        void NurbsCallbackData(int nurb, IntPtr userData)
        {
            Delegates.gluNurbsCallbackData((int)nurb, (IntPtr)userData);
        }

        public static 
        void NurbsCallbackData(int nurb, [In, Out] object userData)
        {
            System.Runtime.InteropServices.GCHandle userData_ptr = System.Runtime.InteropServices.GCHandle.Alloc(userData, System.Runtime.InteropServices.GCHandleType.Pinned);
            try
            {
                Delegates.gluNurbsCallbackData((int)nurb, (IntPtr)userData_ptr.AddrOfPinnedObject());
            }
            finally
            {
                userData_ptr.Free();
            }
        }

        public static 
        void NurbsCurve(int nurb, Int32 knotCount, [Out] float[] knots, Int32 stride, [Out] float[] control, Int32 order, OpenTK.OpenGL.Enums.MapTarget type)
        {
            unsafe
            {
                fixed (float* knots_ptr = knots)
                fixed (float* control_ptr = control)
                {
                    Delegates.gluNurbsCurve((int)nurb, (Int32)knotCount, (float*)knots_ptr, (Int32)stride, (float*)control_ptr, (Int32)order, (OpenTK.OpenGL.Enums.MapTarget)type);
                }
            }
        }

        public static 
        void NurbsCurve(int nurb, Int32 knotCount, [Out] out float knots, Int32 stride, [Out] out float control, Int32 order, OpenTK.OpenGL.Enums.MapTarget type)
        {
            unsafe
            {
                fixed (float* knots_ptr = &knots)
                fixed (float* control_ptr = &control)
                {
                    Delegates.gluNurbsCurve((int)nurb, (Int32)knotCount, (float*)knots_ptr, (Int32)stride, (float*)control_ptr, (Int32)order, (OpenTK.OpenGL.Enums.MapTarget)type);
                    knots = *knots_ptr;
                    control = *control_ptr;
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void NurbsCurve(int nurb, Int32 knotCount, [Out] float* knots, Int32 stride, [Out] float* control, Int32 order, OpenTK.OpenGL.Enums.MapTarget type)
        {
            Delegates.gluNurbsCurve((int)nurb, (Int32)knotCount, (float*)knots, (Int32)stride, (float*)control, (Int32)order, (OpenTK.OpenGL.Enums.MapTarget)type);
        }

        public static 
        void NurbsProperty(int nurb, OpenTK.OpenGL.Enums.NurbsProperty property, float value)
        {
            Delegates.gluNurbsProperty((int)nurb, (OpenTK.OpenGL.Enums.NurbsProperty)property, (float)value);
        }

        public static 
        void NurbsSurface(int nurb, Int32 sKnotCount, float[] sKnots, Int32 tKnotCount, float[] tKnots, Int32 sStride, Int32 tStride, float[] control, Int32 sOrder, Int32 tOrder, OpenTK.OpenGL.Enums.MapTarget type)
        {
            unsafe
            {
                fixed (float* sKnots_ptr = sKnots)
                fixed (float* tKnots_ptr = tKnots)
                fixed (float* control_ptr = control)
                {
                    Delegates.gluNurbsSurface((int)nurb, (Int32)sKnotCount, (float*)sKnots_ptr, (Int32)tKnotCount, (float*)tKnots_ptr, (Int32)sStride, (Int32)tStride, (float*)control_ptr, (Int32)sOrder, (Int32)tOrder, (OpenTK.OpenGL.Enums.MapTarget)type);
                }
            }
        }

        public static 
        void NurbsSurface(int nurb, Int32 sKnotCount, ref float sKnots, Int32 tKnotCount, ref float tKnots, Int32 sStride, Int32 tStride, ref float control, Int32 sOrder, Int32 tOrder, OpenTK.OpenGL.Enums.MapTarget type)
        {
            unsafe
            {
                fixed (float* sKnots_ptr = &sKnots)
                fixed (float* tKnots_ptr = &tKnots)
                fixed (float* control_ptr = &control)
                {
                    Delegates.gluNurbsSurface((int)nurb, (Int32)sKnotCount, (float*)sKnots_ptr, (Int32)tKnotCount, (float*)tKnots_ptr, (Int32)sStride, (Int32)tStride, (float*)control_ptr, (Int32)sOrder, (Int32)tOrder, (OpenTK.OpenGL.Enums.MapTarget)type);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void NurbsSurface(int nurb, Int32 sKnotCount, float* sKnots, Int32 tKnotCount, float* tKnots, Int32 sStride, Int32 tStride, float* control, Int32 sOrder, Int32 tOrder, OpenTK.OpenGL.Enums.MapTarget type)
        {
            Delegates.gluNurbsSurface((int)nurb, (Int32)sKnotCount, (float*)sKnots, (Int32)tKnotCount, (float*)tKnots, (Int32)sStride, (Int32)tStride, (float*)control, (Int32)sOrder, (Int32)tOrder, (OpenTK.OpenGL.Enums.MapTarget)type);
        }

        public static 
        void Ortho2D(double left, double right, double bottom, double top)
        {
            Delegates.gluOrtho2D((double)left, (double)right, (double)bottom, (double)top);
        }

        public static 
        void PartialDisk(int quad, double inner, double outer, Int32 slices, Int32 loops, double start, double sweep)
        {
            Delegates.gluPartialDisk((int)quad, (double)inner, (double)outer, (Int32)slices, (Int32)loops, (double)start, (double)sweep);
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
        void PwlCurve(int nurb, Int32 count, float[] data, Int32 stride, OpenTK.OpenGL.Enums.NurbsTrim type)
        {
            unsafe
            {
                fixed (float* data_ptr = data)
                {
                    Delegates.gluPwlCurve((int)nurb, (Int32)count, (float*)data_ptr, (Int32)stride, (OpenTK.OpenGL.Enums.NurbsTrim)type);
                }
            }
        }

        public static 
        void PwlCurve(int nurb, Int32 count, ref float data, Int32 stride, OpenTK.OpenGL.Enums.NurbsTrim type)
        {
            unsafe
            {
                fixed (float* data_ptr = &data)
                {
                    Delegates.gluPwlCurve((int)nurb, (Int32)count, (float*)data_ptr, (Int32)stride, (OpenTK.OpenGL.Enums.NurbsTrim)type);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void PwlCurve(int nurb, Int32 count, float* data, Int32 stride, OpenTK.OpenGL.Enums.NurbsTrim type)
        {
            Delegates.gluPwlCurve((int)nurb, (Int32)count, (float*)data, (Int32)stride, (OpenTK.OpenGL.Enums.NurbsTrim)type);
        }

        public static 
        void QuadricCallback(int quad, OpenTK.OpenGL.Enums.QuadricCallback which, IntPtr CallBackFunc)
        {
            Delegates.gluQuadricCallback((int)quad, (OpenTK.OpenGL.Enums.QuadricCallback)which, (IntPtr)CallBackFunc);
        }

        public static 
        void QuadricDrawStyle(int quad, OpenTK.OpenGL.Enums.QuadricDrawStyle draw)
        {
            Delegates.gluQuadricDrawStyle((int)quad, (OpenTK.OpenGL.Enums.QuadricDrawStyle)draw);
        }

        public static 
        void QuadricNormal(int quad, OpenTK.OpenGL.Enums.QuadricNormal normal)
        {
            Delegates.gluQuadricNormals((int)quad, (OpenTK.OpenGL.Enums.QuadricNormal)normal);
        }

        public static 
        void QuadricOrientation(int quad, OpenTK.OpenGL.Enums.QuadricOrientation orientation)
        {
            Delegates.gluQuadricOrientation((int)quad, (OpenTK.OpenGL.Enums.QuadricOrientation)orientation);
        }

        public static 
        void QuadricTexture(int quad, bool texture)
        {
            Delegates.gluQuadricTexture((int)quad, (bool)texture);
        }

        public static 
        Int32 ScaleImage(OpenTK.OpenGL.Enums.PixelFormat format, Int32 wIn, Int32 hIn, OpenTK.OpenGL.Enums.PixelType typeIn, IntPtr dataIn, Int32 wOut, Int32 hOut, OpenTK.OpenGL.Enums.PixelType typeOut, [Out] IntPtr dataOut)
        {
            return Delegates.gluScaleImage((OpenTK.OpenGL.Enums.PixelFormat)format, (Int32)wIn, (Int32)hIn, (OpenTK.OpenGL.Enums.PixelType)typeIn, (IntPtr)dataIn, (Int32)wOut, (Int32)hOut, (OpenTK.OpenGL.Enums.PixelType)typeOut, (IntPtr)dataOut);
        }

        public static 
        Int32 ScaleImage(OpenTK.OpenGL.Enums.PixelFormat format, Int32 wIn, Int32 hIn, OpenTK.OpenGL.Enums.PixelType typeIn, [In, Out] object dataIn, Int32 wOut, Int32 hOut, OpenTK.OpenGL.Enums.PixelType typeOut, [In, Out] object dataOut)
        {
            System.Runtime.InteropServices.GCHandle dataIn_ptr = System.Runtime.InteropServices.GCHandle.Alloc(dataIn, System.Runtime.InteropServices.GCHandleType.Pinned);
            System.Runtime.InteropServices.GCHandle dataOut_ptr = System.Runtime.InteropServices.GCHandle.Alloc(dataOut, System.Runtime.InteropServices.GCHandleType.Pinned);
            try
            {
                return Delegates.gluScaleImage((OpenTK.OpenGL.Enums.PixelFormat)format, (Int32)wIn, (Int32)hIn, (OpenTK.OpenGL.Enums.PixelType)typeIn, (IntPtr)dataIn_ptr.AddrOfPinnedObject(), (Int32)wOut, (Int32)hOut, (OpenTK.OpenGL.Enums.PixelType)typeOut, (IntPtr)dataOut_ptr.AddrOfPinnedObject());
            }
            finally
            {
                dataIn_ptr.Free();
                dataOut_ptr.Free();
            }
        }

        public static 
        void Sphere(int quad, double radius, Int32 slices, Int32 stacks)
        {
            Delegates.gluSphere((int)quad, (double)radius, (Int32)slices, (Int32)stacks);
        }

        public static 
        void TessBeginContour(int tess)
        {
            Delegates.gluTessBeginContour((int)tess);
        }

        public static 
        void TessBeginPolygon(int tess, IntPtr data)
        {
            Delegates.gluTessBeginPolygon((int)tess, (IntPtr)data);
        }

        public static 
        void TessBeginPolygon(int tess, [In, Out] object data)
        {
            System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
            try
            {
                Delegates.gluTessBeginPolygon((int)tess, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
        }

        public static 
        void TessCallback(int tess, OpenTK.OpenGL.Enums.TessCallback which, IntPtr CallBackFunc)
        {
            Delegates.gluTessCallback((int)tess, (OpenTK.OpenGL.Enums.TessCallback)which, (IntPtr)CallBackFunc);
        }

        public static 
        void TessEndContour(int tess)
        {
            Delegates.gluTessEndContour((int)tess);
        }

        public static 
        void TessEndPolygon(int tess)
        {
            Delegates.gluTessEndPolygon((int)tess);
        }

        public static 
        void TessNormal(int tess, double valueX, double valueY, double valueZ)
        {
            Delegates.gluTessNormal((int)tess, (double)valueX, (double)valueY, (double)valueZ);
        }

        public static 
        void TessProperty(int tess, OpenTK.OpenGL.Enums.TessProperty which, double data)
        {
            Delegates.gluTessProperty((int)tess, (OpenTK.OpenGL.Enums.TessProperty)which, (double)data);
        }

        public static 
        void TessVertex(int tess, [Out] double[] location, IntPtr data)
        {
            unsafe
            {
                fixed (double* location_ptr = location)
                {
                    Delegates.gluTessVertex((int)tess, (double*)location_ptr, (IntPtr)data);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe void TessVertex(int tess, [Out] double* location, [In, Out] object data)
        {
            System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
            try
            {
                Delegates.gluTessVertex((int)tess, (double*)location, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
        }

        public static 
        void TessVertex(int tess, [Out] out double location, [In, Out] object data)
        {
            unsafe
            {
                fixed (double* location_ptr = &location)
                {
                    System.Runtime.InteropServices.GCHandle data_ptr = System.Runtime.InteropServices.GCHandle.Alloc(data, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        Delegates.gluTessVertex((int)tess, (double*)location_ptr, (IntPtr)data_ptr.AddrOfPinnedObject());
                        location = *location_ptr;
                    }
                    finally
                    {
                        data_ptr.Free();
                    }
                }
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
            void NurbsCallbackData(int nurb, IntPtr userData)
            {
                Delegates.gluNurbsCallbackDataEXT((int)nurb, (IntPtr)userData);
            }

            public static 
            void NurbsCallbackData(int nurb, [In, Out] object userData)
            {
                System.Runtime.InteropServices.GCHandle userData_ptr = System.Runtime.InteropServices.GCHandle.Alloc(userData, System.Runtime.InteropServices.GCHandleType.Pinned);
                try
                {
                    Delegates.gluNurbsCallbackDataEXT((int)nurb, (IntPtr)userData_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    userData_ptr.Free();
                }
            }

        }

        public static partial class Sgi
        {
            public static 
            Int32 TexFilterFunc(OpenTK.OpenGL.Enums.TextureTarget target, OpenTK.OpenGL.Enums.Filter4TypeSgis filtertype, float[] parms, Int32 n, [Out] float[] weights)
            {
                unsafe
                {
                    fixed (float* parms_ptr = parms)
                    fixed (float* weights_ptr = weights)
                    {
                        return Delegates.gluTexFilterFuncSGI((OpenTK.OpenGL.Enums.TextureTarget)target, (OpenTK.OpenGL.Enums.Filter4TypeSgis)filtertype, (float*)parms_ptr, (Int32)n, (float*)weights_ptr);
                    }
                }
            }

            public static 
            Int32 TexFilterFunc(OpenTK.OpenGL.Enums.TextureTarget target, OpenTK.OpenGL.Enums.Filter4TypeSgis filtertype, ref float parms, Int32 n, [Out] out float weights)
            {
                unsafe
                {
                    fixed (float* parms_ptr = &parms)
                    fixed (float* weights_ptr = &weights)
                    {
                        Int32 retval = Delegates.gluTexFilterFuncSGI((OpenTK.OpenGL.Enums.TextureTarget)target, (OpenTK.OpenGL.Enums.Filter4TypeSgis)filtertype, (float*)parms_ptr, (Int32)n, (float*)weights_ptr);
                        weights = *weights_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Int32 TexFilterFunc(OpenTK.OpenGL.Enums.TextureTarget target, OpenTK.OpenGL.Enums.Filter4TypeSgis filtertype, float* parms, Int32 n, [Out] float* weights)
            {
                return Delegates.gluTexFilterFuncSGI((OpenTK.OpenGL.Enums.TextureTarget)target, (OpenTK.OpenGL.Enums.Filter4TypeSgis)filtertype, (float*)parms, (Int32)n, (float*)weights);
            }

        }

    }
}

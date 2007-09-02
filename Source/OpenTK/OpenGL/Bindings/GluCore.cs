namespace OpenTK.OpenGL
{
    using System;
    using System.Runtime.InteropServices;

    partial class Glu
    {

        internal static class Imports
        {
            static Imports() { }

            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBeginCurve", ExactSpelling = true)]
            internal extern static void BeginCurve(int nurb);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBeginPolygon", ExactSpelling = true)]
            internal extern static void BeginPolygon(int tess);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBeginSurface", ExactSpelling = true)]
            internal extern static void BeginSurface(int nurb);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBeginTrim", ExactSpelling = true)]
            internal extern static void BeginTrim(int nurb);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBuild1DMipmapLevels", ExactSpelling = true)]
            internal extern static unsafe Int32 Build1DMipmapLevels(GL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, Int32 level, Int32 @base, Int32 max, void* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBuild1DMipmaps", ExactSpelling = true)]
            internal extern static unsafe Int32 Build1DMipmaps(GL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBuild2DMipmapLevels", ExactSpelling = true)]
            internal extern static unsafe Int32 Build2DMipmapLevels(GL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, Int32 level, Int32 @base, Int32 max, void* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBuild2DMipmaps", ExactSpelling = true)]
            internal extern static unsafe Int32 Build2DMipmaps(GL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBuild3DMipmapLevels", ExactSpelling = true)]
            internal extern static unsafe Int32 Build3DMipmapLevels(GL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, Int32 level, Int32 @base, Int32 max, void* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBuild3DMipmaps", ExactSpelling = true)]
            internal extern static unsafe Int32 Build3DMipmaps(GL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluCheckExtension", ExactSpelling = true)]
            internal extern static unsafe Boolean CheckExtension(Byte* extName, Byte* extString);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluCylinder", ExactSpelling = true)]
            internal extern static void Cylinder(int quad, double @base, double top, double height, Int32 slices, Int32 stacks);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluDeleteNurbsRenderer", ExactSpelling = true)]
            internal extern static void DeleteNurbsRenderer(int nurb);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluDeleteQuadric", ExactSpelling = true)]
            internal extern static void DeleteQuadric(int quad);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluDeleteTess", ExactSpelling = true)]
            internal extern static void DeleteTess(int tess);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluDisk", ExactSpelling = true)]
            internal extern static void Disk(int quad, double inner, double outer, Int32 slices, Int32 loops);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluEndCurve", ExactSpelling = true)]
            internal extern static void EndCurve(int nurb);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluEndPolygon", ExactSpelling = true)]
            internal extern static void EndPolygon(int tess);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluEndSurface", ExactSpelling = true)]
            internal extern static void EndSurface(int nurb);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluEndTrim", ExactSpelling = true)]
            internal extern static void EndTrim(int nurb);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluErrorString", ExactSpelling = true)]
            internal extern static IntPtr ErrorString(Glu.Enums.ErrorCode error);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluGetString", ExactSpelling = true)]
            internal extern static IntPtr GetString(Glu.Enums.StringName name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluGetNurbsProperty", ExactSpelling = true)]
            internal extern static unsafe void GetNurbsProperty(int nurb, Glu.Enums.NurbsProperty property, [Out] float* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluGetTessProperty", ExactSpelling = true)]
            internal extern static unsafe void GetTessProperty(int tess, Glu.Enums.TessProperty which, [Out] double* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluLoadSamplingMatrices", ExactSpelling = true)]
            internal extern static unsafe void LoadSamplingMatrices(int nurb, float* model, float* perspective, Int32* view);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluLookAt", ExactSpelling = true)]
            internal extern static void LookAt(double eyeX, double eyeY, double eyeZ, double centerX, double centerY, double centerZ, double upX, double upY, double upZ);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNewNurbsRenderer", ExactSpelling = true)]
            internal extern static int NewNurbsRenderer();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNewQuadric", ExactSpelling = true)]
            internal extern static int NewQuadric();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNewTess", ExactSpelling = true)]
            internal extern static int NewTess();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNextContour", ExactSpelling = true)]
            internal extern static void NextContour(int tess, Glu.Enums.TessContour type);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNurbsCallback", ExactSpelling = true)]
            internal extern static void NurbsCallback(int nurb, Glu.Enums.NurbsCallback which, IntPtr CallBackFunc);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNurbsCallbackData", ExactSpelling = true)]
            internal extern static unsafe void NurbsCallbackData(int nurb, void* userData);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNurbsCurve", ExactSpelling = true)]
            internal extern static unsafe void NurbsCurve(int nurb, Int32 knotCount, [Out] float* knots, Int32 stride, [Out] float* control, Int32 order, GL.Enums.MapTarget type);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNurbsProperty", ExactSpelling = true)]
            internal extern static void NurbsProperty(int nurb, Glu.Enums.NurbsProperty property, float value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNurbsSurface", ExactSpelling = true)]
            internal extern static unsafe void NurbsSurface(int nurb, Int32 sKnotCount, float* sKnots, Int32 tKnotCount, float* tKnots, Int32 sStride, Int32 tStride, float* control, Int32 sOrder, Int32 tOrder, GL.Enums.MapTarget type);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluOrtho2D", ExactSpelling = true)]
            internal extern static void Ortho2D(double left, double right, double bottom, double top);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluPartialDisk", ExactSpelling = true)]
            internal extern static void PartialDisk(int quad, double inner, double outer, Int32 slices, Int32 loops, double start, double sweep);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluPerspective", ExactSpelling = true)]
            internal extern static void Perspective(double fovy, double aspect, double zNear, double zFar);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluPickMatrix", ExactSpelling = true)]
            internal extern static unsafe void PickMatrix(double x, double y, double delX, double delY, [Out] Int32* viewport);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluProject", ExactSpelling = true)]
            internal extern static unsafe Int32 Project(double objX, double objY, double objZ, double* model, double* proj, Int32* view, double* winX, double* winY, double* winZ);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluPwlCurve", ExactSpelling = true)]
            internal extern static unsafe void PwlCurve(int nurb, Int32 count, float* data, Int32 stride, Glu.Enums.NurbsTrim type);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluQuadricCallback", ExactSpelling = true)]
            internal extern static void QuadricCallback(int quad, Glu.Enums.QuadricCallback which, IntPtr CallBackFunc);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluQuadricDrawStyle", ExactSpelling = true)]
            internal extern static void QuadricDrawStyle(int quad, Glu.Enums.QuadricDrawStyle draw);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluQuadricNormals", ExactSpelling = true)]
            internal extern static void QuadricNormals(int quad, Glu.Enums.QuadricNormal normal);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluQuadricOrientation", ExactSpelling = true)]
            internal extern static void QuadricOrientation(int quad, Glu.Enums.QuadricOrientation orientation);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluQuadricTexture", ExactSpelling = true)]
            internal extern static void QuadricTexture(int quad, Glu.Enums.Boolean texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluScaleImage", ExactSpelling = true)]
            internal extern static unsafe Int32 ScaleImage(GL.Enums.PixelFormat format, Int32 wIn, Int32 hIn, GL.Enums.PixelType typeIn, void* dataIn, Int32 wOut, Int32 hOut, GL.Enums.PixelType typeOut, [Out] void* dataOut);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluSphere", ExactSpelling = true)]
            internal extern static void Sphere(int quad, double radius, Int32 slices, Int32 stacks);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessBeginContour", ExactSpelling = true)]
            internal extern static void TessBeginContour(int tess);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessBeginPolygon", ExactSpelling = true)]
            internal extern static unsafe void TessBeginPolygon(int tess, void* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessCallback", ExactSpelling = true)]
            internal extern static void TessCallback(int tess, Glu.Enums.TessCallback which, IntPtr CallBackFunc);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessEndContour", ExactSpelling = true)]
            internal extern static void TessEndContour(int tess);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessEndPolygon", ExactSpelling = true)]
            internal extern static void TessEndPolygon(int tess);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessNormal", ExactSpelling = true)]
            internal extern static void TessNormal(int tess, double valueX, double valueY, double valueZ);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessProperty", ExactSpelling = true)]
            internal extern static void TessProperty(int tess, Glu.Enums.TessProperty which, double data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessVertex", ExactSpelling = true)]
            internal extern static unsafe void TessVertex(int tess, [Out] double* location, void* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluUnProject", ExactSpelling = true)]
            internal extern static unsafe Int32 UnProject(double winX, double winY, double winZ, double* model, double* proj, Int32* view, double* objX, double* objY, double* objZ);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluUnProject4", ExactSpelling = true)]
            internal extern static unsafe Int32 UnProject4(double winX, double winY, double winZ, double clipW, double* model, double* proj, Int32* view, double near, double far, double* objX, double* objY, double* objZ, double* objW);
        }
    }
}

namespace OpenTK.Graphics
{
    using System;
    using System.Runtime.InteropServices;
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class Glu
    {

        internal static partial class Imports
        {

            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBeginCurve", ExactSpelling = true)]
            internal extern static void BeginCurve(IntPtr nurb);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBeginPolygon", ExactSpelling = true)]
            internal extern static void BeginPolygon(IntPtr tess);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBeginSurface", ExactSpelling = true)]
            internal extern static void BeginSurface(IntPtr nurb);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBeginTrim", ExactSpelling = true)]
            internal extern static void BeginTrim(IntPtr nurb);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBuild1DMipmapLevels", ExactSpelling = true)]
            internal extern static Int32 Build1DMipmapLevels(TextureTarget target, Int32 internalFormat, Int32 width, PixelFormat format, PixelType type, Int32 level, Int32 @base, Int32 max, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBuild1DMipmaps", ExactSpelling = true)]
            internal extern static Int32 Build1DMipmaps(TextureTarget target, Int32 internalFormat, Int32 width, PixelFormat format, PixelType type, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBuild2DMipmapLevels", ExactSpelling = true)]
            internal extern static Int32 Build2DMipmapLevels(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, PixelFormat format, PixelType type, Int32 level, Int32 @base, Int32 max, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBuild2DMipmaps", ExactSpelling = true)]
            internal extern static Int32 Build2DMipmaps(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBuild3DMipmapLevels", ExactSpelling = true)]
            internal extern static Int32 Build3DMipmapLevels(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, Int32 level, Int32 @base, Int32 max, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluBuild3DMipmaps", ExactSpelling = true)]
            internal extern static Int32 Build3DMipmaps(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluCheckExtension", ExactSpelling = true)]
            internal extern static unsafe bool CheckExtension(Byte* extName, Byte* extString);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluCylinder", ExactSpelling = true)]
            internal extern static void Cylinder(IntPtr quad, double @base, double top, double height, Int32 slices, Int32 stacks);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluDeleteNurbsRenderer", ExactSpelling = true)]
            internal extern static void DeleteNurbsRenderer(IntPtr nurb);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluDeleteQuadric", ExactSpelling = true)]
            internal extern static void DeleteQuadric(IntPtr quad);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluDeleteTess", ExactSpelling = true)]
            internal extern static void DeleteTess(IntPtr tess);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluDisk", ExactSpelling = true)]
            internal extern static void Disk(IntPtr quad, double inner, double outer, Int32 slices, Int32 loops);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluEndCurve", ExactSpelling = true)]
            internal extern static void EndCurve(IntPtr nurb);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluEndPolygon", ExactSpelling = true)]
            internal extern static void EndPolygon(IntPtr tess);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluEndSurface", ExactSpelling = true)]
            internal extern static void EndSurface(IntPtr nurb);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluEndTrim", ExactSpelling = true)]
            internal extern static void EndTrim(IntPtr nurb);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluErrorString", ExactSpelling = true)]
            internal extern static IntPtr ErrorString(OpenTK.Graphics.GluErrorCode error);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluGetString", ExactSpelling = true)]
            internal extern static IntPtr GetString(OpenTK.Graphics.GluStringName name);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluGetNurbsProperty", ExactSpelling = true)]
            internal extern static unsafe void GetNurbsProperty(IntPtr nurb, OpenTK.Graphics.NurbsProperty property, [Out] float* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluGetTessProperty", ExactSpelling = true)]
            internal extern static unsafe void GetTessProperty(IntPtr tess, OpenTK.Graphics.TessParameter which, [Out] double* data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluLoadSamplingMatrices", ExactSpelling = true)]
            internal extern static unsafe void LoadSamplingMatrices(IntPtr nurb, float* model, float* perspective, Int32* view);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluLookAt", ExactSpelling = true)]
            internal extern static void LookAt(double eyeX, double eyeY, double eyeZ, double centerX, double centerY, double centerZ, double upX, double upY, double upZ);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNewNurbsRenderer", ExactSpelling = true)]
            internal extern static IntPtr NewNurbsRenderer();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNewQuadric", ExactSpelling = true)]
            internal extern static IntPtr NewQuadric();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNewTess", ExactSpelling = true)]
            internal extern static IntPtr NewTess();
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNextContour", ExactSpelling = true)]
            internal extern static void NextContour(IntPtr tess, OpenTK.Graphics.TessContour type);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNurbsCallback", ExactSpelling = true)]
            internal extern static void NurbsCallback(IntPtr nurb, OpenTK.Graphics.NurbsCallback which, Delegate CallBackFunc);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNurbsCallbackData", ExactSpelling = true)]
            internal extern static void NurbsCallbackData(IntPtr nurb, IntPtr userData);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNurbsCurve", ExactSpelling = true)]
            internal extern static unsafe void NurbsCurve(IntPtr nurb, Int32 knotCount, [Out] float* knots, Int32 stride, [Out] float* control, Int32 order, MapTarget type);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNurbsProperty", ExactSpelling = true)]
            internal extern static void NurbsProperty(IntPtr nurb, OpenTK.Graphics.NurbsProperty property, float value);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluNurbsSurface", ExactSpelling = true)]
            internal extern static unsafe void NurbsSurface(IntPtr nurb, Int32 sKnotCount, float* sKnots, Int32 tKnotCount, float* tKnots, Int32 sStride, Int32 tStride, float* control, Int32 sOrder, Int32 tOrder, MapTarget type);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluOrtho2D", ExactSpelling = true)]
            internal extern static void Ortho2D(double left, double right, double bottom, double top);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluPartialDisk", ExactSpelling = true)]
            internal extern static void PartialDisk(IntPtr quad, double inner, double outer, Int32 slices, Int32 loops, double start, double sweep);
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
            internal extern static unsafe void PwlCurve(IntPtr nurb, Int32 count, float* data, Int32 stride, OpenTK.Graphics.NurbsTrim type);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluQuadricCallback", ExactSpelling = true)]
            internal extern static void QuadricCallback(IntPtr quad, OpenTK.Graphics.QuadricCallback which, Delegate CallBackFunc);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluQuadricDrawStyle", ExactSpelling = true)]
            internal extern static void QuadricDrawStyle(IntPtr quad, OpenTK.Graphics.QuadricDrawStyle draw);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluQuadricNormals", ExactSpelling = true)]
            internal extern static void QuadricNormals(IntPtr quad, OpenTK.Graphics.QuadricNormal normal);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluQuadricOrientation", ExactSpelling = true)]
            internal extern static void QuadricOrientation(IntPtr quad, OpenTK.Graphics.QuadricOrientation orientation);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluQuadricTexture", ExactSpelling = true)]
            internal extern static void QuadricTexture(IntPtr quad, bool texture);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluScaleImage", ExactSpelling = true)]
            internal extern static Int32 ScaleImage(PixelFormat format, Int32 wIn, Int32 hIn, PixelType typeIn, IntPtr dataIn, Int32 wOut, Int32 hOut, PixelType typeOut, [Out] IntPtr dataOut);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluSphere", ExactSpelling = true)]
            internal extern static void Sphere(IntPtr quad, double radius, Int32 slices, Int32 stacks);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessBeginContour", ExactSpelling = true)]
            internal extern static void TessBeginContour(IntPtr tess);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessBeginPolygon", ExactSpelling = true)]
            internal extern static void TessBeginPolygon(IntPtr tess, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessCallback", ExactSpelling = true)]
            internal extern static void TessCallback(IntPtr tess, OpenTK.Graphics.TessCallback which, Delegate CallBackFunc);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessEndContour", ExactSpelling = true)]
            internal extern static void TessEndContour(IntPtr tess);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessEndPolygon", ExactSpelling = true)]
            internal extern static void TessEndPolygon(IntPtr tess);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessNormal", ExactSpelling = true)]
            internal extern static void TessNormal(IntPtr tess, double valueX, double valueY, double valueZ);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessProperty", ExactSpelling = true)]
            internal extern static void TessProperty(IntPtr tess, OpenTK.Graphics.TessParameter which, double data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluTessVertex", ExactSpelling = true)]
            internal extern static unsafe void TessVertex(IntPtr tess, double* location, IntPtr data);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluUnProject", ExactSpelling = true)]
            internal extern static unsafe Int32 UnProject(double winX, double winY, double winZ, double* model, double* proj, Int32* view, double* objX, double* objY, double* objZ);
            [System.Security.SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(Glu.Library, EntryPoint = "gluUnProject4", ExactSpelling = true)]
            internal extern static unsafe Int32 UnProject4(double winX, double winY, double winZ, double clipW, double* model, double* proj, Int32* view, double near, double far, double* objX, double* objY, double* objZ, double* objW);
        }
    }
}

namespace OpenTK.Graphics
{
    using System;
    using System.Runtime.InteropServices;
    #pragma warning disable 0649
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class Glu
    {
        internal static partial class Delegates
        {
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginCurve(IntPtr nurb);
            internal static BeginCurve gluBeginCurve;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginPolygon(IntPtr tess);
            internal static BeginPolygon gluBeginPolygon;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginSurface(IntPtr nurb);
            internal static BeginSurface gluBeginSurface;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginTrim(IntPtr nurb);
            internal static BeginTrim gluBeginTrim;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 Build1DMipmapLevels(TextureTarget target, Int32 internalFormat, Int32 width, PixelFormat format, PixelType type, Int32 level, Int32 @base, Int32 max, IntPtr data);
            internal static Build1DMipmapLevels gluBuild1DMipmapLevels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 Build1DMipmaps(TextureTarget target, Int32 internalFormat, Int32 width, PixelFormat format, PixelType type, IntPtr data);
            internal static Build1DMipmaps gluBuild1DMipmaps;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 Build2DMipmapLevels(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, PixelFormat format, PixelType type, Int32 level, Int32 @base, Int32 max, IntPtr data);
            internal static Build2DMipmapLevels gluBuild2DMipmapLevels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 Build2DMipmaps(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr data);
            internal static Build2DMipmaps gluBuild2DMipmaps;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 Build3DMipmapLevels(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, Int32 level, Int32 @base, Int32 max, IntPtr data);
            internal static Build3DMipmapLevels gluBuild3DMipmapLevels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 Build3DMipmaps(TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr data);
            internal static Build3DMipmaps gluBuild3DMipmaps;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate bool CheckExtension(Byte* extName, Byte* extString);
            internal unsafe static CheckExtension gluCheckExtension;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Cylinder(IntPtr quad, double @base, double top, double height, Int32 slices, Int32 stacks);
            internal static Cylinder gluCylinder;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteNurbsRenderer(IntPtr nurb);
            internal static DeleteNurbsRenderer gluDeleteNurbsRenderer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteQuadric(IntPtr quad);
            internal static DeleteQuadric gluDeleteQuadric;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteTess(IntPtr tess);
            internal static DeleteTess gluDeleteTess;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Disk(IntPtr quad, double inner, double outer, Int32 slices, Int32 loops);
            internal static Disk gluDisk;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndCurve(IntPtr nurb);
            internal static EndCurve gluEndCurve;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndPolygon(IntPtr tess);
            internal static EndPolygon gluEndPolygon;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndSurface(IntPtr nurb);
            internal static EndSurface gluEndSurface;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndTrim(IntPtr nurb);
            internal static EndTrim gluEndTrim;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr ErrorString(OpenTK.Graphics.GluErrorCode error);
            internal static ErrorString gluErrorString;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetString(OpenTK.Graphics.GluStringName name);
            internal static GetString gluGetString;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNurbsProperty(IntPtr nurb, OpenTK.Graphics.NurbsProperty property, [Out] float* data);
            internal unsafe static GetNurbsProperty gluGetNurbsProperty;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTessProperty(IntPtr tess, OpenTK.Graphics.TessParameter which, [Out] double* data);
            internal unsafe static GetTessProperty gluGetTessProperty;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadSamplingMatrices(IntPtr nurb, float* model, float* perspective, Int32* view);
            internal unsafe static LoadSamplingMatrices gluLoadSamplingMatrices;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LookAt(double eyeX, double eyeY, double eyeZ, double centerX, double centerY, double centerZ, double upX, double upY, double upZ);
            internal static LookAt gluLookAt;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr NewNurbsRenderer();
            internal static NewNurbsRenderer gluNewNurbsRenderer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr NewQuadric();
            internal static NewQuadric gluNewQuadric;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr NewTess();
            internal static NewTess gluNewTess;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NextContour(IntPtr tess, OpenTK.Graphics.TessContour type);
            internal static NextContour gluNextContour;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NurbsCallback(IntPtr nurb, OpenTK.Graphics.NurbsCallback which, Delegate CallBackFunc);
            internal static NurbsCallback gluNurbsCallback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NurbsCallbackData(IntPtr nurb, IntPtr userData);
            internal static NurbsCallbackData gluNurbsCallbackData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NurbsCallbackDataEXT(IntPtr nurb, IntPtr userData);
            internal static NurbsCallbackDataEXT gluNurbsCallbackDataEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NurbsCurve(IntPtr nurb, Int32 knotCount, [Out] float* knots, Int32 stride, [Out] float* control, Int32 order, MapTarget type);
            internal unsafe static NurbsCurve gluNurbsCurve;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NurbsProperty(IntPtr nurb, OpenTK.Graphics.NurbsProperty property, float value);
            internal static NurbsProperty gluNurbsProperty;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NurbsSurface(IntPtr nurb, Int32 sKnotCount, float* sKnots, Int32 tKnotCount, float* tKnots, Int32 sStride, Int32 tStride, float* control, Int32 sOrder, Int32 tOrder, MapTarget type);
            internal unsafe static NurbsSurface gluNurbsSurface;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Ortho2D(double left, double right, double bottom, double top);
            internal static Ortho2D gluOrtho2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PartialDisk(IntPtr quad, double inner, double outer, Int32 slices, Int32 loops, double start, double sweep);
            internal static PartialDisk gluPartialDisk;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Perspective(double fovy, double aspect, double zNear, double zFar);
            internal static Perspective gluPerspective;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PickMatrix(double x, double y, double delX, double delY, [Out] Int32* viewport);
            internal unsafe static PickMatrix gluPickMatrix;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 Project(double objX, double objY, double objZ, double* model, double* proj, Int32* view, double* winX, double* winY, double* winZ);
            internal unsafe static Project gluProject;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PwlCurve(IntPtr nurb, Int32 count, float* data, Int32 stride, OpenTK.Graphics.NurbsTrim type);
            internal unsafe static PwlCurve gluPwlCurve;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QuadricCallback(IntPtr quad, OpenTK.Graphics.QuadricCallback which, Delegate CallBackFunc);
            internal static QuadricCallback gluQuadricCallback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QuadricDrawStyle(IntPtr quad, OpenTK.Graphics.QuadricDrawStyle draw);
            internal static QuadricDrawStyle gluQuadricDrawStyle;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QuadricNormals(IntPtr quad, OpenTK.Graphics.QuadricNormal normal);
            internal static QuadricNormals gluQuadricNormals;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QuadricOrientation(IntPtr quad, OpenTK.Graphics.QuadricOrientation orientation);
            internal static QuadricOrientation gluQuadricOrientation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QuadricTexture(IntPtr quad, bool texture);
            internal static QuadricTexture gluQuadricTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 ScaleImage(PixelFormat format, Int32 wIn, Int32 hIn, PixelType typeIn, IntPtr dataIn, Int32 wOut, Int32 hOut, PixelType typeOut, [Out] IntPtr dataOut);
            internal static ScaleImage gluScaleImage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Sphere(IntPtr quad, double radius, Int32 slices, Int32 stacks);
            internal static Sphere gluSphere;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessBeginContour(IntPtr tess);
            internal static TessBeginContour gluTessBeginContour;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessBeginPolygon(IntPtr tess, IntPtr data);
            internal static TessBeginPolygon gluTessBeginPolygon;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessCallback(IntPtr tess, OpenTK.Graphics.TessCallback which, Delegate CallBackFunc);
            internal static TessCallback gluTessCallback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessEndContour(IntPtr tess);
            internal static TessEndContour gluTessEndContour;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessEndPolygon(IntPtr tess);
            internal static TessEndPolygon gluTessEndPolygon;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessNormal(IntPtr tess, double valueX, double valueY, double valueZ);
            internal static TessNormal gluTessNormal;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessProperty(IntPtr tess, OpenTK.Graphics.TessParameter which, double data);
            internal static TessProperty gluTessProperty;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TessVertex(IntPtr tess, double* location, IntPtr data);
            internal unsafe static TessVertex gluTessVertex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 TexFilterFuncSGI(TextureTarget target, SgisTextureFilter4 filtertype, float* parms, Int32 n, [Out] float* weights);
            internal unsafe static TexFilterFuncSGI gluTexFilterFuncSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 UnProject(double winX, double winY, double winZ, double* model, double* proj, Int32* view, double* objX, double* objY, double* objZ);
            internal unsafe static UnProject gluUnProject;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 UnProject4(double winX, double winY, double winZ, double clipW, double* model, double* proj, Int32* view, double near, double far, double* objX, double* objY, double* objZ, double* objW);
            internal unsafe static UnProject4 gluUnProject4;
        }
    }
}

namespace OpenTK.OpenGL
{
    using System;
    using System.Runtime.InteropServices;
    #pragma warning disable 0649

    partial class Glu
    {
        internal static partial class Delegates
        {
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginCurve(int nurb);
            internal static BeginCurve gluBeginCurve;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginPolygon(int tess);
            internal static BeginPolygon gluBeginPolygon;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginSurface(int nurb);
            internal static BeginSurface gluBeginSurface;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginTrim(int nurb);
            internal static BeginTrim gluBeginTrim;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 Build1DMipmapLevels(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, Int32 level, Int32 @base, Int32 max, IntPtr data);
            internal static Build1DMipmapLevels gluBuild1DMipmapLevels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 Build1DMipmaps(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, IntPtr data);
            internal static Build1DMipmaps gluBuild1DMipmaps;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 Build2DMipmapLevels(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, Int32 level, Int32 @base, Int32 max, IntPtr data);
            internal static Build2DMipmapLevels gluBuild2DMipmapLevels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 Build2DMipmaps(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, IntPtr data);
            internal static Build2DMipmaps gluBuild2DMipmaps;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 Build3DMipmapLevels(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, Int32 level, Int32 @base, Int32 max, IntPtr data);
            internal static Build3DMipmapLevels gluBuild3DMipmapLevels;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 Build3DMipmaps(OpenTK.OpenGL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, OpenTK.OpenGL.Enums.PixelFormat format, OpenTK.OpenGL.Enums.PixelType type, IntPtr data);
            internal static Build3DMipmaps gluBuild3DMipmaps;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate bool CheckExtension(Byte* extName, Byte* extString);
            internal unsafe static CheckExtension gluCheckExtension;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Cylinder(int quad, double @base, double top, double height, Int32 slices, Int32 stacks);
            internal static Cylinder gluCylinder;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteNurbsRenderer(int nurb);
            internal static DeleteNurbsRenderer gluDeleteNurbsRenderer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteQuadric(int quad);
            internal static DeleteQuadric gluDeleteQuadric;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteTess(int tess);
            internal static DeleteTess gluDeleteTess;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Disk(int quad, double inner, double outer, Int32 slices, Int32 loops);
            internal static Disk gluDisk;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndCurve(int nurb);
            internal static EndCurve gluEndCurve;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndPolygon(int tess);
            internal static EndPolygon gluEndPolygon;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndSurface(int nurb);
            internal static EndSurface gluEndSurface;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndTrim(int nurb);
            internal static EndTrim gluEndTrim;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr ErrorString(OpenTK.OpenGL.Enums.GluErrorCode error);
            internal static ErrorString gluErrorString;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetString(OpenTK.OpenGL.Enums.GluStringName name);
            internal static GetString gluGetString;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNurbsProperty(int nurb, OpenTK.OpenGL.Enums.NurbsProperty property, [Out] float* data);
            internal unsafe static GetNurbsProperty gluGetNurbsProperty;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTessProperty(int tess, OpenTK.OpenGL.Enums.TessProperty which, [Out] double* data);
            internal unsafe static GetTessProperty gluGetTessProperty;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadSamplingMatrices(int nurb, float* model, float* perspective, Int32* view);
            internal unsafe static LoadSamplingMatrices gluLoadSamplingMatrices;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LookAt(double eyeX, double eyeY, double eyeZ, double centerX, double centerY, double centerZ, double upX, double upY, double upZ);
            internal static LookAt gluLookAt;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int NewNurbsRenderer();
            internal static NewNurbsRenderer gluNewNurbsRenderer;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int NewQuadric();
            internal static NewQuadric gluNewQuadric;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int NewTess();
            internal static NewTess gluNewTess;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NextContour(int tess, OpenTK.OpenGL.Enums.TessContour type);
            internal static NextContour gluNextContour;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NurbsCallback(int nurb, OpenTK.OpenGL.Enums.NurbsCallback which, IntPtr CallBackFunc);
            internal static NurbsCallback gluNurbsCallback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NurbsCallbackData(int nurb, IntPtr userData);
            internal static NurbsCallbackData gluNurbsCallbackData;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NurbsCallbackDataEXT(int nurb, IntPtr userData);
            internal static NurbsCallbackDataEXT gluNurbsCallbackDataEXT;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NurbsCurve(int nurb, Int32 knotCount, [Out] float* knots, Int32 stride, [Out] float* control, Int32 order, OpenTK.OpenGL.Enums.MapTarget type);
            internal unsafe static NurbsCurve gluNurbsCurve;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NurbsProperty(int nurb, OpenTK.OpenGL.Enums.NurbsProperty property, float value);
            internal static NurbsProperty gluNurbsProperty;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NurbsSurface(int nurb, Int32 sKnotCount, float* sKnots, Int32 tKnotCount, float* tKnots, Int32 sStride, Int32 tStride, float* control, Int32 sOrder, Int32 tOrder, OpenTK.OpenGL.Enums.MapTarget type);
            internal unsafe static NurbsSurface gluNurbsSurface;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Ortho2D(double left, double right, double bottom, double top);
            internal static Ortho2D gluOrtho2D;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PartialDisk(int quad, double inner, double outer, Int32 slices, Int32 loops, double start, double sweep);
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
            internal unsafe delegate void PwlCurve(int nurb, Int32 count, float* data, Int32 stride, OpenTK.OpenGL.Enums.NurbsTrim type);
            internal unsafe static PwlCurve gluPwlCurve;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QuadricCallback(int quad, OpenTK.OpenGL.Enums.QuadricCallback which, IntPtr CallBackFunc);
            internal static QuadricCallback gluQuadricCallback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QuadricDrawStyle(int quad, OpenTK.OpenGL.Enums.QuadricDrawStyle draw);
            internal static QuadricDrawStyle gluQuadricDrawStyle;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QuadricNormals(int quad, OpenTK.OpenGL.Enums.QuadricNormal normal);
            internal static QuadricNormals gluQuadricNormals;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QuadricOrientation(int quad, OpenTK.OpenGL.Enums.QuadricOrientation orientation);
            internal static QuadricOrientation gluQuadricOrientation;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QuadricTexture(int quad, bool texture);
            internal static QuadricTexture gluQuadricTexture;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 ScaleImage(OpenTK.OpenGL.Enums.PixelFormat format, Int32 wIn, Int32 hIn, OpenTK.OpenGL.Enums.PixelType typeIn, IntPtr dataIn, Int32 wOut, Int32 hOut, OpenTK.OpenGL.Enums.PixelType typeOut, [Out] IntPtr dataOut);
            internal static ScaleImage gluScaleImage;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Sphere(int quad, double radius, Int32 slices, Int32 stacks);
            internal static Sphere gluSphere;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessBeginContour(int tess);
            internal static TessBeginContour gluTessBeginContour;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessBeginPolygon(int tess, IntPtr data);
            internal static TessBeginPolygon gluTessBeginPolygon;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessCallback(int tess, OpenTK.OpenGL.Enums.TessCallback which, IntPtr CallBackFunc);
            internal static TessCallback gluTessCallback;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessEndContour(int tess);
            internal static TessEndContour gluTessEndContour;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessEndPolygon(int tess);
            internal static TessEndPolygon gluTessEndPolygon;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessNormal(int tess, double valueX, double valueY, double valueZ);
            internal static TessNormal gluTessNormal;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessProperty(int tess, OpenTK.OpenGL.Enums.TessProperty which, double data);
            internal static TessProperty gluTessProperty;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TessVertex(int tess, [Out] double* location, IntPtr data);
            internal unsafe static TessVertex gluTessVertex;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 TexFilterFuncSGI(OpenTK.OpenGL.Enums.TextureTarget target, OpenTK.OpenGL.Enums.Filter4TypeSgis filtertype, float* parms, Int32 n, [Out] float* weights);
            internal unsafe static TexFilterFuncSGI gluTexFilterFuncSGI;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 UnProject(double winX, double winY, double winZ, double* model, double* proj, Int32* view, double* objX, double* objY, double* objZ);
            internal unsafe static UnProject gluUnProject;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 UnProject4(double winX, double winY, double winZ, double clipW, double* model, double* proj, Int32* view, double near, double far, double* objX, double* objY, double* objZ, double* objW);
            internal unsafe static UnProject4 gluUnProject4;
        }
    }
    #pragma warning restore 0649
}

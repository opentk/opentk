namespace OpenTK.OpenGL
{
    using System;
    using System.Runtime.InteropServices;

    partial class Glu
    {

        internal static class Delegates
        {
            static Delegates()
            {
            }

            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginCurve(int nurb);
            internal static BeginCurve gluBeginCurve = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginPolygon(int tess);
            internal static BeginPolygon gluBeginPolygon = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginSurface(int nurb);
            internal static BeginSurface gluBeginSurface = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginTrim(int nurb);
            internal static BeginTrim gluBeginTrim = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 Build1DMipmapLevels(GL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, Int32 level, Int32 @base, Int32 max, void* data);
            internal unsafe static Build1DMipmapLevels gluBuild1DMipmapLevels = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 Build1DMipmaps(GL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
            internal unsafe static Build1DMipmaps gluBuild1DMipmaps = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 Build2DMipmapLevels(GL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, Int32 level, Int32 @base, Int32 max, void* data);
            internal unsafe static Build2DMipmapLevels gluBuild2DMipmapLevels = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 Build2DMipmaps(GL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
            internal unsafe static Build2DMipmaps gluBuild2DMipmaps = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 Build3DMipmapLevels(GL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, Int32 level, Int32 @base, Int32 max, void* data);
            internal unsafe static Build3DMipmapLevels gluBuild3DMipmapLevels = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 Build3DMipmaps(GL.Enums.TextureTarget target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, GL.Enums.PixelFormat format, GL.Enums.PixelType type, void* data);
            internal unsafe static Build3DMipmaps gluBuild3DMipmaps = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Boolean CheckExtension(Byte* extName, Byte* extString);
            internal unsafe static CheckExtension gluCheckExtension = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Cylinder(int quad, double @base, double top, double height, Int32 slices, Int32 stacks);
            internal static Cylinder gluCylinder = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteNurbsRenderer(int nurb);
            internal static DeleteNurbsRenderer gluDeleteNurbsRenderer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteQuadric(int quad);
            internal static DeleteQuadric gluDeleteQuadric = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteTess(int tess);
            internal static DeleteTess gluDeleteTess = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Disk(int quad, double inner, double outer, Int32 slices, Int32 loops);
            internal static Disk gluDisk = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndCurve(int nurb);
            internal static EndCurve gluEndCurve = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndPolygon(int tess);
            internal static EndPolygon gluEndPolygon = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndSurface(int nurb);
            internal static EndSurface gluEndSurface = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void EndTrim(int nurb);
            internal static EndTrim gluEndTrim = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr ErrorString(Glu.Enums.ErrorCode error);
            internal static ErrorString gluErrorString = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetString(Glu.Enums.StringName name);
            internal static GetString gluGetString = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNurbsProperty(int nurb, Glu.Enums.NurbsProperty property, [Out] float* data);
            internal unsafe static GetNurbsProperty gluGetNurbsProperty = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTessProperty(int tess, Glu.Enums.TessProperty which, [Out] double* data);
            internal unsafe static GetTessProperty gluGetTessProperty = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadSamplingMatrices(int nurb, float* model, float* perspective, Int32* view);
            internal unsafe static LoadSamplingMatrices gluLoadSamplingMatrices = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void LookAt(double eyeX, double eyeY, double eyeZ, double centerX, double centerY, double centerZ, double upX, double upY, double upZ);
            internal static LookAt gluLookAt = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int NewNurbsRenderer();
            internal static NewNurbsRenderer gluNewNurbsRenderer = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int NewQuadric();
            internal static NewQuadric gluNewQuadric = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate int NewTess();
            internal static NewTess gluNewTess = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NextContour(int tess, Glu.Enums.TessContour type);
            internal static NextContour gluNextContour = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NurbsCallback(int nurb, Glu.Enums.NurbsCallback which, IntPtr CallBackFunc);
            internal static NurbsCallback gluNurbsCallback = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NurbsCallbackData(int nurb, void* userData);
            internal unsafe static NurbsCallbackData gluNurbsCallbackData = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NurbsCallbackDataEXT(int nurb, void* userData);
            internal unsafe static NurbsCallbackDataEXT gluNurbsCallbackDataEXT = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NurbsCurve(int nurb, Int32 knotCount, [Out] float* knots, Int32 stride, [Out] float* control, Int32 order, GL.Enums.MapTarget type);
            internal unsafe static NurbsCurve gluNurbsCurve = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void NurbsProperty(int nurb, Glu.Enums.NurbsProperty property, float value);
            internal static NurbsProperty gluNurbsProperty = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NurbsSurface(int nurb, Int32 sKnotCount, float* sKnots, Int32 tKnotCount, float* tKnots, Int32 sStride, Int32 tStride, float* control, Int32 sOrder, Int32 tOrder, GL.Enums.MapTarget type);
            internal unsafe static NurbsSurface gluNurbsSurface = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Ortho2D(double left, double right, double bottom, double top);
            internal static Ortho2D gluOrtho2D = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void PartialDisk(int quad, double inner, double outer, Int32 slices, Int32 loops, double start, double sweep);
            internal static PartialDisk gluPartialDisk = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Perspective(double fovy, double aspect, double zNear, double zFar);
            internal static Perspective gluPerspective = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PickMatrix(double x, double y, double delX, double delY, [Out] Int32* viewport);
            internal unsafe static PickMatrix gluPickMatrix = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 Project(double objX, double objY, double objZ, double* model, double* proj, Int32* view, double* winX, double* winY, double* winZ);
            internal unsafe static Project gluProject = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PwlCurve(int nurb, Int32 count, float* data, Int32 stride, Glu.Enums.NurbsTrim type);
            internal unsafe static PwlCurve gluPwlCurve = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QuadricCallback(int quad, Glu.Enums.QuadricCallback which, IntPtr CallBackFunc);
            internal static QuadricCallback gluQuadricCallback = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QuadricDrawStyle(int quad, Glu.Enums.QuadricDrawStyle draw);
            internal static QuadricDrawStyle gluQuadricDrawStyle = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QuadricNormals(int quad, Glu.Enums.QuadricNormal normal);
            internal static QuadricNormals gluQuadricNormals = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QuadricOrientation(int quad, Glu.Enums.QuadricOrientation orientation);
            internal static QuadricOrientation gluQuadricOrientation = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void QuadricTexture(int quad, Glu.Enums.Boolean texture);
            internal static QuadricTexture gluQuadricTexture = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 ScaleImage(GL.Enums.PixelFormat format, Int32 wIn, Int32 hIn, GL.Enums.PixelType typeIn, void* dataIn, Int32 wOut, Int32 hOut, GL.Enums.PixelType typeOut, [Out] void* dataOut);
            internal unsafe static ScaleImage gluScaleImage = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void Sphere(int quad, double radius, Int32 slices, Int32 stacks);
            internal static Sphere gluSphere = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessBeginContour(int tess);
            internal static TessBeginContour gluTessBeginContour = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TessBeginPolygon(int tess, void* data);
            internal unsafe static TessBeginPolygon gluTessBeginPolygon = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessCallback(int tess, Glu.Enums.TessCallback which, IntPtr CallBackFunc);
            internal static TessCallback gluTessCallback = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessEndContour(int tess);
            internal static TessEndContour gluTessEndContour = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessEndPolygon(int tess);
            internal static TessEndPolygon gluTessEndPolygon = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessNormal(int tess, double valueX, double valueY, double valueZ);
            internal static TessNormal gluTessNormal = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal delegate void TessProperty(int tess, Glu.Enums.TessProperty which, double data);
            internal static TessProperty gluTessProperty = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TessVertex(int tess, [Out] double* location, void* data);
            internal unsafe static TessVertex gluTessVertex = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 TexFilterFuncSGI(GL.Enums.TextureTarget target, Glu.Enums.Filter4TypeSGIS filtertype, float* parms, Int32 n, [Out] float* weights);
            internal unsafe static TexFilterFuncSGI gluTexFilterFuncSGI = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 UnProject(double winX, double winY, double winZ, double* model, double* proj, Int32* view, double* objX, double* objY, double* objZ);
            internal unsafe static UnProject gluUnProject = null;
            [System.Security.SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 UnProject4(double winX, double winY, double winZ, double clipW, double* model, double* proj, Int32* view, double near, double far, double* objX, double* objY, double* objZ, double* objW);
            internal unsafe static UnProject4 gluUnProject4 = null;
        }
    }
}

using System.Runtime.InteropServices;
using System;
using OpenToolkit.Graphics.Types;

namespace OpenToolkit.Graphics.OpenGL.Extensions
{
    public static partial class SGIX
    {
        public unsafe static partial class Async
        {
            [DllImport("opengl32.dll", EntryPoint = "glAsyncMarkerSGIX")]
            public static extern void GlAsyncMarker(uint marker);
            
            [DllImport("opengl32.dll", EntryPoint = "glFinishAsyncSGIX")]
            public static extern int GlFinishAsync(uint* markerp);
            
            [DllImport("opengl32.dll", EntryPoint = "glPollAsyncSGIX")]
            public static extern int GlPollAsync(uint* markerp);
            
            [DllImport("opengl32.dll", EntryPoint = "glGenAsyncMarkersSGIX")]
            public static extern uint GlGenAsyncMarkers(int range);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeleteAsyncMarkersSGIX")]
            public static extern void GlDeleteAsyncMarkers(uint marker, int range);
            
            [DllImport("opengl32.dll", EntryPoint = "glIsAsyncMarkerSGIX")]
            public static extern byte GlIsAsyncMarker(uint marker);
            
        }
        public unsafe static partial class AsyncHistogram
        {
        }
        public unsafe static partial class AsyncPixel
        {
        }
        public unsafe static partial class BlendAlphaMinmax
        {
        }
        public unsafe static partial class CalligraphicFragment
        {
        }
        public unsafe static partial class Clipmap
        {
        }
        public unsafe static partial class ConvolutionAccuracy
        {
        }
        public unsafe static partial class DepthPassInstrument
        {
        }
        public unsafe static partial class DepthTexture
        {
        }
        public unsafe static partial class FlushRaster
        {
            [DllImport("opengl32.dll", EntryPoint = "glFlushRasterSGIX")]
            public static extern void GlFlushRaster();
            
        }
        public unsafe static partial class FogOffset
        {
        }
        public unsafe static partial class FragmentLighting
        {
            [DllImport("opengl32.dll", EntryPoint = "glFragmentColorMaterialSGIX")]
            public static extern void GlFragmentColorMaterial(uint face, uint mode);
            
            [DllImport("opengl32.dll", EntryPoint = "glFragmentLightfSGIX")]
            public static extern void GlFragmentLightf(uint light, uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glFragmentLightfvSGIX")]
            public static extern void GlFragmentLightfv(uint light, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glFragmentLightiSGIX")]
            public static extern void GlFragmentLighti(uint light, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glFragmentLightivSGIX")]
            public static extern void GlFragmentLightiv(uint light, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glFragmentLightModelfSGIX")]
            public static extern void GlFragmentLightModelf(uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glFragmentLightModelfvSGIX")]
            public static extern void GlFragmentLightModelfv(uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glFragmentLightModeliSGIX")]
            public static extern void GlFragmentLightModeli(uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glFragmentLightModelivSGIX")]
            public static extern void GlFragmentLightModeliv(uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glFragmentMaterialfSGIX")]
            public static extern void GlFragmentMaterialf(uint face, uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glFragmentMaterialfvSGIX")]
            public static extern void GlFragmentMaterialfv(uint face, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glFragmentMaterialiSGIX")]
            public static extern void GlFragmentMateriali(uint face, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glFragmentMaterialivSGIX")]
            public static extern void GlFragmentMaterialiv(uint face, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFragmentLightfvSGIX")]
            public static extern void GlGetFragmentLightfv(uint light, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFragmentLightivSGIX")]
            public static extern void GlGetFragmentLightiv(uint light, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFragmentMaterialfvSGIX")]
            public static extern void GlGetFragmentMaterialfv(uint face, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetFragmentMaterialivSGIX")]
            public static extern void GlGetFragmentMaterialiv(uint face, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glLightEnviSGIX")]
            public static extern void GlLightEnvi(uint pname, int param);
            
        }
        public unsafe static partial class Framezoom
        {
            [DllImport("opengl32.dll", EntryPoint = "glFrameZoomSGIX")]
            public static extern void GlFrameZoom(int factor);
            
        }
        public unsafe static partial class IglooInterface
        {
            [DllImport("opengl32.dll", EntryPoint = "glIglooInterfaceSGIX")]
            public static extern void GlIglooInterface(uint pname, void* parameters);
            
        }
        public unsafe static partial class Instruments
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetInstrumentsSGIX")]
            public static extern int GlGetInstruments();
            
            [DllImport("opengl32.dll", EntryPoint = "glInstrumentsBufferSGIX")]
            public static extern void GlInstrumentsBuffer(int size, int* buffer);
            
            [DllImport("opengl32.dll", EntryPoint = "glPollInstrumentsSGIX")]
            public static extern int GlPollInstruments(int* marker_p);
            
            [DllImport("opengl32.dll", EntryPoint = "glReadInstrumentsSGIX")]
            public static extern void GlReadInstruments(int marker);
            
            [DllImport("opengl32.dll", EntryPoint = "glStartInstrumentsSGIX")]
            public static extern void GlStartInstruments();
            
            [DllImport("opengl32.dll", EntryPoint = "glStopInstrumentsSGIX")]
            public static extern void GlStopInstruments(int marker);
            
        }
        public unsafe static partial class Interlace
        {
        }
        public unsafe static partial class IrInstrument1
        {
        }
        public unsafe static partial class ListPriority
        {
            [DllImport("opengl32.dll", EntryPoint = "glGetListParameterfvSGIX")]
            public static extern void GlGetListParameterfv(uint list, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glGetListParameterivSGIX")]
            public static extern void GlGetListParameteriv(uint list, uint pname, int* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glListParameterfSGIX")]
            public static extern void GlListParameterf(uint list, uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glListParameterfvSGIX")]
            public static extern void GlListParameterfv(uint list, uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glListParameteriSGIX")]
            public static extern void GlListParameteri(uint list, uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glListParameterivSGIX")]
            public static extern void GlListParameteriv(uint list, uint pname, int* parameters);
            
        }
        public unsafe static partial class PixelTexture
        {
            [DllImport("opengl32.dll", EntryPoint = "glPixelTexGenSGIX")]
            public static extern void GlPixelTexGen(uint mode);
            
        }
        public unsafe static partial class PixelTiles
        {
        }
        public unsafe static partial class PolynomialFfd
        {
            [DllImport("opengl32.dll", EntryPoint = "glDeformationMap3dSGIX")]
            public static extern void GlDeformationMap3d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double* points);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeformationMap3fSGIX")]
            public static extern void GlDeformationMap3f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float* points);
            
            [DllImport("opengl32.dll", EntryPoint = "glDeformSGIX")]
            public static extern void GlDeform(uint mask);
            
            [DllImport("opengl32.dll", EntryPoint = "glLoadIdentityDeformationMapSGIX")]
            public static extern void GlLoadIdentityDeformationMap(uint mask);
            
        }
        public unsafe static partial class ReferencePlane
        {
            [DllImport("opengl32.dll", EntryPoint = "glReferencePlaneSGIX")]
            public static extern void GlReferencePlane(double* equation);
            
        }
        public unsafe static partial class Resample
        {
        }
        public unsafe static partial class ScalebiasHint
        {
        }
        public unsafe static partial class Shadow
        {
        }
        public unsafe static partial class ShadowAmbient
        {
        }
        public unsafe static partial class Sprite
        {
            [DllImport("opengl32.dll", EntryPoint = "glSpriteParameterfSGIX")]
            public static extern void GlSpriteParameterf(uint pname, float param);
            
            [DllImport("opengl32.dll", EntryPoint = "glSpriteParameterfvSGIX")]
            public static extern void GlSpriteParameterfv(uint pname, float* parameters);
            
            [DllImport("opengl32.dll", EntryPoint = "glSpriteParameteriSGIX")]
            public static extern void GlSpriteParameteri(uint pname, int param);
            
            [DllImport("opengl32.dll", EntryPoint = "glSpriteParameterivSGIX")]
            public static extern void GlSpriteParameteriv(uint pname, int* parameters);
            
        }
        public unsafe static partial class Subsample
        {
        }
        public unsafe static partial class TagSampleBuffer
        {
            [DllImport("opengl32.dll", EntryPoint = "glTagSampleBufferSGIX")]
            public static extern void GlTagSampleBuffer();
            
        }
        public unsafe static partial class TextureAddEnv
        {
        }
        public unsafe static partial class TextureCoordinateClamp
        {
        }
        public unsafe static partial class TextureLodBias
        {
        }
        public unsafe static partial class TextureMultiBuffer
        {
        }
        public unsafe static partial class TextureScaleBias
        {
        }
        public unsafe static partial class VertexPreclip
        {
        }
        public unsafe static partial class Ycrcb
        {
        }
        public unsafe static partial class YcrcbSubsample
        {
        }
        public unsafe static partial class Ycrcba
        {
        }
    }
}

namespace OpenTK.Platform.Windows
{
    using System;
    using System.Runtime.InteropServices;
    #pragma warning disable 3019
    #pragma warning disable 1591

    static partial class Wgl
    {

        public static 
        IntPtr CreateContext(IntPtr hDc)
        {
            return Delegates.wglCreateContext((IntPtr)hDc);
        }

        public static 
        Boolean DeleteContext(IntPtr oldContext)
        {
            return Delegates.wglDeleteContext((IntPtr)oldContext);
        }

        public static 
        IntPtr GetCurrentContext()
        {
            return Delegates.wglGetCurrentContext();
        }

        public static 
        Boolean MakeCurrent(IntPtr hDc, IntPtr newContext)
        {
            return Delegates.wglMakeCurrent((IntPtr)hDc, (IntPtr)newContext);
        }

        [System.CLSCompliant(false)]
        public static 
        Boolean CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, UInt32 mask)
        {
            return Delegates.wglCopyContext((IntPtr)hglrcSrc, (IntPtr)hglrcDst, (UInt32)mask);
        }

        public static 
        Boolean CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, Int32 mask)
        {
            return Delegates.wglCopyContext((IntPtr)hglrcSrc, (IntPtr)hglrcDst, (UInt32)mask);
        }

        public static 
        int ChoosePixelFormat(IntPtr hDc, PixelFormatDescriptor[] pPfd)
        {
            unsafe
            {
                fixed (PixelFormatDescriptor* pPfd_ptr = pPfd)
                {
                    return Delegates.wglChoosePixelFormat((IntPtr)hDc, (PixelFormatDescriptor*)pPfd_ptr);
                }
            }
        }

        public static 
        int ChoosePixelFormat(IntPtr hDc, ref PixelFormatDescriptor pPfd)
        {
            unsafe
            {
                fixed (PixelFormatDescriptor* pPfd_ptr = &pPfd)
                {
                    return Delegates.wglChoosePixelFormat((IntPtr)hDc, (PixelFormatDescriptor*)pPfd_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe int ChoosePixelFormat(IntPtr hDc, PixelFormatDescriptor* pPfd)
        {
            return Delegates.wglChoosePixelFormat((IntPtr)hDc, (PixelFormatDescriptor*)pPfd);
        }

        [System.CLSCompliant(false)]
        public static 
        int DescribePixelFormat(IntPtr hdc, int ipfd, UInt32 cjpfd, PixelFormatDescriptor[] ppfd)
        {
            unsafe
            {
                fixed (PixelFormatDescriptor* ppfd_ptr = ppfd)
                {
                    return Delegates.wglDescribePixelFormat((IntPtr)hdc, (int)ipfd, (UInt32)cjpfd, (PixelFormatDescriptor*)ppfd_ptr);
                }
            }
        }

        public static 
        int DescribePixelFormat(IntPtr hdc, int ipfd, Int32 cjpfd, PixelFormatDescriptor[] ppfd)
        {
            unsafe
            {
                fixed (PixelFormatDescriptor* ppfd_ptr = ppfd)
                {
                    return Delegates.wglDescribePixelFormat((IntPtr)hdc, (int)ipfd, (UInt32)cjpfd, (PixelFormatDescriptor*)ppfd_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        int DescribePixelFormat(IntPtr hdc, int ipfd, UInt32 cjpfd, ref PixelFormatDescriptor ppfd)
        {
            unsafe
            {
                fixed (PixelFormatDescriptor* ppfd_ptr = &ppfd)
                {
                    return Delegates.wglDescribePixelFormat((IntPtr)hdc, (int)ipfd, (UInt32)cjpfd, (PixelFormatDescriptor*)ppfd_ptr);
                }
            }
        }

        public static 
        int DescribePixelFormat(IntPtr hdc, int ipfd, Int32 cjpfd, ref PixelFormatDescriptor ppfd)
        {
            unsafe
            {
                fixed (PixelFormatDescriptor* ppfd_ptr = &ppfd)
                {
                    return Delegates.wglDescribePixelFormat((IntPtr)hdc, (int)ipfd, (UInt32)cjpfd, (PixelFormatDescriptor*)ppfd_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe int DescribePixelFormat(IntPtr hdc, int ipfd, UInt32 cjpfd, PixelFormatDescriptor* ppfd)
        {
            return Delegates.wglDescribePixelFormat((IntPtr)hdc, (int)ipfd, (UInt32)cjpfd, (PixelFormatDescriptor*)ppfd);
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe int DescribePixelFormat(IntPtr hdc, int ipfd, Int32 cjpfd, PixelFormatDescriptor* ppfd)
        {
            return Delegates.wglDescribePixelFormat((IntPtr)hdc, (int)ipfd, (UInt32)cjpfd, (PixelFormatDescriptor*)ppfd);
        }

        public static 
        IntPtr GetCurrentDC()
        {
            return Delegates.wglGetCurrentDC();
        }

        public static 
        IntPtr GetDefaultProcAddres(String lpszProc)
        {
            return Delegates.wglGetDefaultProcAddress((String)lpszProc);
        }

        public static 
        IntPtr GetProcAddres(String lpszProc)
        {
            return Delegates.wglGetProcAddress((String)lpszProc);
        }

        public static 
        int GetPixelFormat(IntPtr hdc)
        {
            return Delegates.wglGetPixelFormat((IntPtr)hdc);
        }

        public static 
        Boolean SetPixelFormat(IntPtr hdc, int ipfd, PixelFormatDescriptor[] ppfd)
        {
            unsafe
            {
                fixed (PixelFormatDescriptor* ppfd_ptr = ppfd)
                {
                    return Delegates.wglSetPixelFormat((IntPtr)hdc, (int)ipfd, (PixelFormatDescriptor*)ppfd_ptr);
                }
            }
        }

        public static 
        Boolean SetPixelFormat(IntPtr hdc, int ipfd, ref PixelFormatDescriptor ppfd)
        {
            unsafe
            {
                fixed (PixelFormatDescriptor* ppfd_ptr = &ppfd)
                {
                    return Delegates.wglSetPixelFormat((IntPtr)hdc, (int)ipfd, (PixelFormatDescriptor*)ppfd_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe Boolean SetPixelFormat(IntPtr hdc, int ipfd, PixelFormatDescriptor* ppfd)
        {
            return Delegates.wglSetPixelFormat((IntPtr)hdc, (int)ipfd, (PixelFormatDescriptor*)ppfd);
        }

        public static 
        Boolean SwapBuffers(IntPtr hdc)
        {
            return Delegates.wglSwapBuffers((IntPtr)hdc);
        }

        public static 
        Boolean ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource)
        {
            return Delegates.wglShareLists((IntPtr)hrcSrvShare, (IntPtr)hrcSrvSource);
        }

        public static 
        IntPtr CreateLayerContext(IntPtr hDc, int level)
        {
            return Delegates.wglCreateLayerContext((IntPtr)hDc, (int)level);
        }

        [System.CLSCompliant(false)]
        public static 
        Boolean DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, UInt32 nBytes, LayerPlaneDescriptor[] plpd)
        {
            unsafe
            {
                fixed (LayerPlaneDescriptor* plpd_ptr = plpd)
                {
                    return Delegates.wglDescribeLayerPlane((IntPtr)hDc, (int)pixelFormat, (int)layerPlane, (UInt32)nBytes, (LayerPlaneDescriptor*)plpd_ptr);
                }
            }
        }

        public static 
        Boolean DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, Int32 nBytes, LayerPlaneDescriptor[] plpd)
        {
            unsafe
            {
                fixed (LayerPlaneDescriptor* plpd_ptr = plpd)
                {
                    return Delegates.wglDescribeLayerPlane((IntPtr)hDc, (int)pixelFormat, (int)layerPlane, (UInt32)nBytes, (LayerPlaneDescriptor*)plpd_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        Boolean DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, UInt32 nBytes, ref LayerPlaneDescriptor plpd)
        {
            unsafe
            {
                fixed (LayerPlaneDescriptor* plpd_ptr = &plpd)
                {
                    return Delegates.wglDescribeLayerPlane((IntPtr)hDc, (int)pixelFormat, (int)layerPlane, (UInt32)nBytes, (LayerPlaneDescriptor*)plpd_ptr);
                }
            }
        }

        public static 
        Boolean DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, Int32 nBytes, ref LayerPlaneDescriptor plpd)
        {
            unsafe
            {
                fixed (LayerPlaneDescriptor* plpd_ptr = &plpd)
                {
                    return Delegates.wglDescribeLayerPlane((IntPtr)hDc, (int)pixelFormat, (int)layerPlane, (UInt32)nBytes, (LayerPlaneDescriptor*)plpd_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe Boolean DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, UInt32 nBytes, LayerPlaneDescriptor* plpd)
        {
            return Delegates.wglDescribeLayerPlane((IntPtr)hDc, (int)pixelFormat, (int)layerPlane, (UInt32)nBytes, (LayerPlaneDescriptor*)plpd);
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe Boolean DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, Int32 nBytes, LayerPlaneDescriptor* plpd)
        {
            return Delegates.wglDescribeLayerPlane((IntPtr)hDc, (int)pixelFormat, (int)layerPlane, (UInt32)nBytes, (LayerPlaneDescriptor*)plpd);
        }

        public static 
        int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32[] pcr)
        {
            unsafe
            {
                fixed (Int32* pcr_ptr = pcr)
                {
                    return Delegates.wglSetLayerPaletteEntries((IntPtr)hdc, (int)iLayerPlane, (int)iStart, (int)cEntries, (Int32*)pcr_ptr);
                }
            }
        }

        public static 
        int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, ref Int32 pcr)
        {
            unsafe
            {
                fixed (Int32* pcr_ptr = &pcr)
                {
                    return Delegates.wglSetLayerPaletteEntries((IntPtr)hdc, (int)iLayerPlane, (int)iStart, (int)cEntries, (Int32*)pcr_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32* pcr)
        {
            return Delegates.wglSetLayerPaletteEntries((IntPtr)hdc, (int)iLayerPlane, (int)iStart, (int)cEntries, (Int32*)pcr);
        }

        public static 
        int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32[] pcr)
        {
            unsafe
            {
                fixed (Int32* pcr_ptr = pcr)
                {
                    return Delegates.wglGetLayerPaletteEntries((IntPtr)hdc, (int)iLayerPlane, (int)iStart, (int)cEntries, (Int32*)pcr_ptr);
                }
            }
        }

        public static 
        int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, ref Int32 pcr)
        {
            unsafe
            {
                fixed (Int32* pcr_ptr = &pcr)
                {
                    return Delegates.wglGetLayerPaletteEntries((IntPtr)hdc, (int)iLayerPlane, (int)iStart, (int)cEntries, (Int32*)pcr_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32* pcr)
        {
            return Delegates.wglGetLayerPaletteEntries((IntPtr)hdc, (int)iLayerPlane, (int)iStart, (int)cEntries, (Int32*)pcr);
        }

        public static 
        Boolean RealizeLayerPalette(IntPtr hdc, int iLayerPlane, Boolean bRealize)
        {
            return Delegates.wglRealizeLayerPalette((IntPtr)hdc, (int)iLayerPlane, (Boolean)bRealize);
        }

        [System.CLSCompliant(false)]
        public static 
        Boolean SwapLayerBuffers(IntPtr hdc, UInt32 fuFlags)
        {
            return Delegates.wglSwapLayerBuffers((IntPtr)hdc, (UInt32)fuFlags);
        }

        public static 
        Boolean SwapLayerBuffers(IntPtr hdc, Int32 fuFlags)
        {
            return Delegates.wglSwapLayerBuffers((IntPtr)hdc, (UInt32)fuFlags);
        }

        public static 
        Boolean UseFontBitmapsA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase)
        {
            return Delegates.wglUseFontBitmapsA((IntPtr)hDC, (Int32)first, (Int32)count, (Int32)listBase);
        }

        public static 
        Boolean UseFontBitmapsW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase)
        {
            return Delegates.wglUseFontBitmapsW((IntPtr)hDC, (Int32)first, (Int32)count, (Int32)listBase);
        }

        public static 
        Boolean UseFontOutlinesA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float thickness, float deviation, Int32 fontMode, GlyphMetricsFloat[] glyphMetrics)
        {
            unsafe
            {
                fixed (GlyphMetricsFloat* glyphMetrics_ptr = glyphMetrics)
                {
                    return Delegates.wglUseFontOutlinesA((IntPtr)hDC, (Int32)first, (Int32)count, (Int32)listBase, (float)thickness, (float)deviation, (Int32)fontMode, (GlyphMetricsFloat*)glyphMetrics_ptr);
                }
            }
        }

        public static 
        Boolean UseFontOutlinesA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float thickness, float deviation, Int32 fontMode, ref GlyphMetricsFloat glyphMetrics)
        {
            unsafe
            {
                fixed (GlyphMetricsFloat* glyphMetrics_ptr = &glyphMetrics)
                {
                    return Delegates.wglUseFontOutlinesA((IntPtr)hDC, (Int32)first, (Int32)count, (Int32)listBase, (float)thickness, (float)deviation, (Int32)fontMode, (GlyphMetricsFloat*)glyphMetrics_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe Boolean UseFontOutlinesA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float thickness, float deviation, Int32 fontMode, GlyphMetricsFloat* glyphMetrics)
        {
            return Delegates.wglUseFontOutlinesA((IntPtr)hDC, (Int32)first, (Int32)count, (Int32)listBase, (float)thickness, (float)deviation, (Int32)fontMode, (GlyphMetricsFloat*)glyphMetrics);
        }

        public static 
        Boolean UseFontOutlinesW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float thickness, float deviation, Int32 fontMode, GlyphMetricsFloat[] glyphMetrics)
        {
            unsafe
            {
                fixed (GlyphMetricsFloat* glyphMetrics_ptr = glyphMetrics)
                {
                    return Delegates.wglUseFontOutlinesW((IntPtr)hDC, (Int32)first, (Int32)count, (Int32)listBase, (float)thickness, (float)deviation, (Int32)fontMode, (GlyphMetricsFloat*)glyphMetrics_ptr);
                }
            }
        }

        public static 
        Boolean UseFontOutlinesW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float thickness, float deviation, Int32 fontMode, ref GlyphMetricsFloat glyphMetrics)
        {
            unsafe
            {
                fixed (GlyphMetricsFloat* glyphMetrics_ptr = &glyphMetrics)
                {
                    return Delegates.wglUseFontOutlinesW((IntPtr)hDC, (Int32)first, (Int32)count, (Int32)listBase, (float)thickness, (float)deviation, (Int32)fontMode, (GlyphMetricsFloat*)glyphMetrics_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe Boolean UseFontOutlinesW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float thickness, float deviation, Int32 fontMode, GlyphMetricsFloat* glyphMetrics)
        {
            return Delegates.wglUseFontOutlinesW((IntPtr)hDC, (Int32)first, (Int32)count, (Int32)listBase, (float)thickness, (float)deviation, (Int32)fontMode, (GlyphMetricsFloat*)glyphMetrics);
        }

        public static 
        Boolean MakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
        {
            return Delegates.wglMakeContextCurrentEXT((IntPtr)hDrawDC, (IntPtr)hReadDC, (IntPtr)hglrc);
        }

        [System.CLSCompliant(false)]
        public static 
        Boolean ChoosePixelFormatEXT(IntPtr hdc, int[] piAttribIList, Single[] pfAttribFList, UInt32 nMaxFormats, [Out] int[] piFormats, [Out] UInt32[] nNumFormats)
        {
            unsafe
            {
                fixed (int* piAttribIList_ptr = piAttribIList)
                fixed (Single* pfAttribFList_ptr = pfAttribFList)
                fixed (int* piFormats_ptr = piFormats)
                fixed (UInt32* nNumFormats_ptr = nNumFormats)
                {
                    return Delegates.wglChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32*)nNumFormats_ptr);
                }
            }
        }

        public static 
        Boolean ChoosePixelFormatEXT(IntPtr hdc, int[] piAttribIList, Single[] pfAttribFList, Int32 nMaxFormats, [Out] int[] piFormats, [Out] Int32[] nNumFormats)
        {
            unsafe
            {
                fixed (int* piAttribIList_ptr = piAttribIList)
                fixed (Single* pfAttribFList_ptr = pfAttribFList)
                fixed (int* piFormats_ptr = piFormats)
                fixed (Int32* nNumFormats_ptr = nNumFormats)
                {
                    return Delegates.wglChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32*)nNumFormats_ptr);
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        Boolean ChoosePixelFormatEXT(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] out UInt32 nNumFormats)
        {
            unsafe
            {
                fixed (int* piAttribIList_ptr = &piAttribIList)
                fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                fixed (int* piFormats_ptr = &piFormats)
                fixed (UInt32* nNumFormats_ptr = &nNumFormats)
                {
                    Boolean retval = Delegates.wglChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32*)nNumFormats_ptr);
                    piFormats = *piFormats_ptr;
                    nNumFormats = *nNumFormats_ptr;
                    return retval;
                }
            }
        }

        public static 
        Boolean ChoosePixelFormatEXT(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] out Int32 nNumFormats)
        {
            unsafe
            {
                fixed (int* piAttribIList_ptr = &piAttribIList)
                fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                fixed (int* piFormats_ptr = &piFormats)
                fixed (Int32* nNumFormats_ptr = &nNumFormats)
                {
                    Boolean retval = Delegates.wglChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32*)nNumFormats_ptr);
                    piFormats = *piFormats_ptr;
                    nNumFormats = *nNumFormats_ptr;
                    return retval;
                }
            }
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe Boolean ChoosePixelFormatEXT(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32* nNumFormats)
        {
            return Delegates.wglChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32*)nNumFormats);
        }

        [System.CLSCompliant(false)]
        public static 
        unsafe Boolean ChoosePixelFormatEXT(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32* nNumFormats)
        {
            return Delegates.wglChoosePixelFormatEXT((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32*)nNumFormats);
        }

        public static partial class Arb
        {
            [CLSCompliant(false)]
            unsafe public static
            IntPtr CreateContextAttribs(IntPtr hDC, IntPtr hShareContext, int* attribList)
            {
                return Delegates.wglCreateContextAttribsARB((IntPtr)hDC, (IntPtr)hShareContext, (int*)attribList);
            }

            public static
            IntPtr CreateContextAttribs(IntPtr hDC, IntPtr hShareContext, ref int attribList)
            {
                unsafe
                {
                    fixed (int* attribList_ptr = &attribList)
                    {
                        return Delegates.wglCreateContextAttribsARB((IntPtr)hDC, (IntPtr)hShareContext, (int*)attribList_ptr);
                    }
                }
            }

            public static
            IntPtr CreateContextAttribs(IntPtr hDC, IntPtr hShareContext, int[] attribList)
            {
                unsafe
                {
                    fixed (int* attribList_ptr = attribList)
                    {
                        return Delegates.wglCreateContextAttribsARB((IntPtr)hDC, (IntPtr)hShareContext, (int*)attribList_ptr);
                    }
                }
            }
            
            [System.CLSCompliant(false)]
            public static 
            IntPtr CreateBufferRegion(IntPtr hDC, int iLayerPlane, UInt32 uType)
            {
                return Delegates.wglCreateBufferRegionARB((IntPtr)hDC, (int)iLayerPlane, (UInt32)uType);
            }

            public static 
            IntPtr CreateBufferRegion(IntPtr hDC, int iLayerPlane, Int32 uType)
            {
                return Delegates.wglCreateBufferRegionARB((IntPtr)hDC, (int)iLayerPlane, (UInt32)uType);
            }

            public static 
            void DeleteBufferRegion(IntPtr hRegion)
            {
                Delegates.wglDeleteBufferRegionARB((IntPtr)hRegion);
            }

            public static 
            Boolean SaveBufferRegion(IntPtr hRegion, int x, int y, int width, int height)
            {
                return Delegates.wglSaveBufferRegionARB((IntPtr)hRegion, (int)x, (int)y, (int)width, (int)height);
            }

            public static 
            Boolean RestoreBufferRegion(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc)
            {
                return Delegates.wglRestoreBufferRegionARB((IntPtr)hRegion, (int)x, (int)y, (int)width, (int)height, (int)xSrc, (int)ySrc);
            }

            public static 
            string GetExtensionsString(IntPtr hdc)
            {
                unsafe
                {
                    return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Delegates.wglGetExtensionsStringARB((IntPtr)hdc));
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int[] piAttributes, [Out] int[] piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (int* piValues_ptr = piValues)
                    {
                        return Delegates.wglGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                    }
                }
            }

            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, int[] piAttributes, [Out] int[] piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (int* piValues_ptr = piValues)
                    {
                        return Delegates.wglGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, ref int piAttributes, [Out] out int piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.wglGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        piValues = *piValues_ptr;
                        return retval;
                    }
                }
            }

            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, ref int piAttributes, [Out] out int piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.wglGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        piValues = *piValues_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] int* piValues)
            {
                return Delegates.wglGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues);
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, int* piAttributes, [Out] int* piValues)
            {
                return Delegates.wglGetPixelFormatAttribivARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues);
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int[] piAttributes, [Out] Single[] pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        return Delegates.wglGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                    }
                }
            }

            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, int[] piAttributes, [Out] Single[] pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        return Delegates.wglGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, ref int piAttributes, [Out] out Single pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.wglGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
                }
            }

            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, ref int piAttributes, [Out] out Single pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.wglGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] Single* pfValues)
            {
                return Delegates.wglGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues);
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, int* piAttributes, [Out] Single* pfValues)
            {
                return Delegates.wglGetPixelFormatAttribfvARB((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues);
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, int[] piAttribIList, Single[] pfAttribFList, UInt32 nMaxFormats, [Out] int[] piFormats, [Out] UInt32[] nNumFormats)
            {
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    fixed (UInt32* nNumFormats_ptr = nNumFormats)
                    {
                        return Delegates.wglChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32*)nNumFormats_ptr);
                    }
                }
            }

            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, int[] piAttribIList, Single[] pfAttribFList, Int32 nMaxFormats, [Out] int[] piFormats, [Out] Int32[] nNumFormats)
            {
                unsafe
                {
                    fixed (int* piAttribIList_ptr = piAttribIList)
                    fixed (Single* pfAttribFList_ptr = pfAttribFList)
                    fixed (int* piFormats_ptr = piFormats)
                    fixed (Int32* nNumFormats_ptr = nNumFormats)
                    {
                        return Delegates.wglChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32*)nNumFormats_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, UInt32 nMaxFormats, [Out] out int piFormats, [Out] out UInt32 nNumFormats)
            {
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    fixed (UInt32* nNumFormats_ptr = &nNumFormats)
                    {
                        Boolean retval = Delegates.wglChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32*)nNumFormats_ptr);
                        piFormats = *piFormats_ptr;
                        nNumFormats = *nNumFormats_ptr;
                        return retval;
                    }
                }
            }

            public static 
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] out Int32 nNumFormats)
            {
                unsafe
                {
                    fixed (int* piAttribIList_ptr = &piAttribIList)
                    fixed (Single* pfAttribFList_ptr = &pfAttribFList)
                    fixed (int* piFormats_ptr = &piFormats)
                    fixed (Int32* nNumFormats_ptr = &nNumFormats)
                    {
                        Boolean retval = Delegates.wglChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList_ptr, (Single*)pfAttribFList_ptr, (UInt32)nMaxFormats, (int*)piFormats_ptr, (UInt32*)nNumFormats_ptr);
                        piFormats = *piFormats_ptr;
                        nNumFormats = *nNumFormats_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32* nNumFormats)
            {
                return Delegates.wglChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32*)nNumFormats);
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean ChoosePixelFormat(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, Int32 nMaxFormats, [Out] int* piFormats, [Out] Int32* nNumFormats)
            {
                return Delegates.wglChoosePixelFormatARB((IntPtr)hdc, (int*)piAttribIList, (Single*)pfAttribFList, (UInt32)nMaxFormats, (int*)piFormats, (UInt32*)nNumFormats);
            }

            public static 
            Boolean MakeContextCurrent(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
            {
                return Delegates.wglMakeContextCurrentARB((IntPtr)hDrawDC, (IntPtr)hReadDC, (IntPtr)hglrc);
            }

            public static 
            IntPtr GetCurrentReadDC()
            {
                return Delegates.wglGetCurrentReadDCARB();
            }

            public static 
            IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = piAttribList)
                    {
                        return Delegates.wglCreatePbufferARB((IntPtr)hDC, (int)iPixelFormat, (int)iWidth, (int)iHeight, (int*)piAttribList_ptr);
                    }
                }
            }

            public static 
            IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, ref int piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = &piAttribList)
                    {
                        return Delegates.wglCreatePbufferARB((IntPtr)hDC, (int)iPixelFormat, (int)iWidth, (int)iHeight, (int*)piAttribList_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList)
            {
                return Delegates.wglCreatePbufferARB((IntPtr)hDC, (int)iPixelFormat, (int)iWidth, (int)iHeight, (int*)piAttribList);
            }

            public static 
            IntPtr GetPbufferDC(IntPtr hPbuffer)
            {
                return Delegates.wglGetPbufferDCARB((IntPtr)hPbuffer);
            }

            public static 
            int ReleasePbufferDC(IntPtr hPbuffer, IntPtr hDC)
            {
                return Delegates.wglReleasePbufferDCARB((IntPtr)hPbuffer, (IntPtr)hDC);
            }

            public static 
            Boolean DestroyPbuffer(IntPtr hPbuffer)
            {
                return Delegates.wglDestroyPbufferARB((IntPtr)hPbuffer);
            }

            public static 
            Boolean QueryPbuffer(IntPtr hPbuffer, int iAttribute, [Out] int[] piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = piValue)
                    {
                        return Delegates.wglQueryPbufferARB((IntPtr)hPbuffer, (int)iAttribute, (int*)piValue_ptr);
                    }
                }
            }

            public static 
            Boolean QueryPbuffer(IntPtr hPbuffer, int iAttribute, [Out] out int piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = &piValue)
                    {
                        Boolean retval = Delegates.wglQueryPbufferARB((IntPtr)hPbuffer, (int)iAttribute, (int*)piValue_ptr);
                        piValue = *piValue_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean QueryPbuffer(IntPtr hPbuffer, int iAttribute, [Out] int* piValue)
            {
                return Delegates.wglQueryPbufferARB((IntPtr)hPbuffer, (int)iAttribute, (int*)piValue);
            }

            public static 
            Boolean BindTexImage(IntPtr hPbuffer, int iBuffer)
            {
                return Delegates.wglBindTexImageARB((IntPtr)hPbuffer, (int)iBuffer);
            }

            public static 
            Boolean ReleaseTexImage(IntPtr hPbuffer, int iBuffer)
            {
                return Delegates.wglReleaseTexImageARB((IntPtr)hPbuffer, (int)iBuffer);
            }

            public static 
            Boolean SetPbufferAttrib(IntPtr hPbuffer, int[] piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = piAttribList)
                    {
                        return Delegates.wglSetPbufferAttribARB((IntPtr)hPbuffer, (int*)piAttribList_ptr);
                    }
                }
            }

            public static 
            Boolean SetPbufferAttrib(IntPtr hPbuffer, ref int piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = &piAttribList)
                    {
                        return Delegates.wglSetPbufferAttribARB((IntPtr)hPbuffer, (int*)piAttribList_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetPbufferAttrib(IntPtr hPbuffer, int* piAttribList)
            {
                return Delegates.wglSetPbufferAttribARB((IntPtr)hPbuffer, (int*)piAttribList);
            }

        }

        public static partial class Ext
        {
            [System.CLSCompliant(false)]
            public static 
            bool CreateDisplayColorTable(UInt16 id)
            {
                return Delegates.wglCreateDisplayColorTableEXT((UInt16)id);
            }

            public static 
            bool CreateDisplayColorTable(Int16 id)
            {
                return Delegates.wglCreateDisplayColorTableEXT((UInt16)id);
            }

            [System.CLSCompliant(false)]
            public static 
            bool LoadDisplayColorTable(UInt16[] table, UInt32 length)
            {
                unsafe
                {
                    fixed (UInt16* table_ptr = table)
                    {
                        return Delegates.wglLoadDisplayColorTableEXT((UInt16*)table_ptr, (UInt32)length);
                    }
                }
            }

            public static 
            bool LoadDisplayColorTable(Int16[] table, Int32 length)
            {
                unsafe
                {
                    fixed (Int16* table_ptr = table)
                    {
                        return Delegates.wglLoadDisplayColorTableEXT((UInt16*)table_ptr, (UInt32)length);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            bool LoadDisplayColorTable(ref UInt16 table, UInt32 length)
            {
                unsafe
                {
                    fixed (UInt16* table_ptr = &table)
                    {
                        return Delegates.wglLoadDisplayColorTableEXT((UInt16*)table_ptr, (UInt32)length);
                    }
                }
            }

            public static 
            bool LoadDisplayColorTable(ref Int16 table, Int32 length)
            {
                unsafe
                {
                    fixed (Int16* table_ptr = &table)
                    {
                        return Delegates.wglLoadDisplayColorTableEXT((UInt16*)table_ptr, (UInt32)length);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe bool LoadDisplayColorTable(UInt16* table, UInt32 length)
            {
                return Delegates.wglLoadDisplayColorTableEXT((UInt16*)table, (UInt32)length);
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe bool LoadDisplayColorTable(Int16* table, Int32 length)
            {
                return Delegates.wglLoadDisplayColorTableEXT((UInt16*)table, (UInt32)length);
            }

            [System.CLSCompliant(false)]
            public static 
            bool BindDisplayColorTable(UInt16 id)
            {
                return Delegates.wglBindDisplayColorTableEXT((UInt16)id);
            }

            public static 
            bool BindDisplayColorTable(Int16 id)
            {
                return Delegates.wglBindDisplayColorTableEXT((UInt16)id);
            }

            [System.CLSCompliant(false)]
            public static 
            void DestroyDisplayColorTable(UInt16 id)
            {
                Delegates.wglDestroyDisplayColorTableEXT((UInt16)id);
            }

            public static 
            void DestroyDisplayColorTable(Int16 id)
            {
                Delegates.wglDestroyDisplayColorTableEXT((UInt16)id);
            }

            public static 
            string GetExtensionsString()
            {
                unsafe
                {
                    return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Delegates.wglGetExtensionsStringEXT());
                }
            }

            public static 
            IntPtr GetCurrentReadDC()
            {
                return Delegates.wglGetCurrentReadDCEXT();
            }

            public static 
            IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = piAttribList)
                    {
                        return Delegates.wglCreatePbufferEXT((IntPtr)hDC, (int)iPixelFormat, (int)iWidth, (int)iHeight, (int*)piAttribList_ptr);
                    }
                }
            }

            public static 
            IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, ref int piAttribList)
            {
                unsafe
                {
                    fixed (int* piAttribList_ptr = &piAttribList)
                    {
                        return Delegates.wglCreatePbufferEXT((IntPtr)hDC, (int)iPixelFormat, (int)iWidth, (int)iHeight, (int*)piAttribList_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList)
            {
                return Delegates.wglCreatePbufferEXT((IntPtr)hDC, (int)iPixelFormat, (int)iWidth, (int)iHeight, (int*)piAttribList);
            }

            public static 
            IntPtr GetPbufferDC(IntPtr hPbuffer)
            {
                return Delegates.wglGetPbufferDCEXT((IntPtr)hPbuffer);
            }

            public static 
            int ReleasePbufferDC(IntPtr hPbuffer, IntPtr hDC)
            {
                return Delegates.wglReleasePbufferDCEXT((IntPtr)hPbuffer, (IntPtr)hDC);
            }

            public static 
            Boolean DestroyPbuffer(IntPtr hPbuffer)
            {
                return Delegates.wglDestroyPbufferEXT((IntPtr)hPbuffer);
            }

            public static 
            Boolean QueryPbuffer(IntPtr hPbuffer, int iAttribute, [Out] int[] piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = piValue)
                    {
                        return Delegates.wglQueryPbufferEXT((IntPtr)hPbuffer, (int)iAttribute, (int*)piValue_ptr);
                    }
                }
            }

            public static 
            Boolean QueryPbuffer(IntPtr hPbuffer, int iAttribute, [Out] out int piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = &piValue)
                    {
                        Boolean retval = Delegates.wglQueryPbufferEXT((IntPtr)hPbuffer, (int)iAttribute, (int*)piValue_ptr);
                        piValue = *piValue_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean QueryPbuffer(IntPtr hPbuffer, int iAttribute, [Out] int* piValue)
            {
                return Delegates.wglQueryPbufferEXT((IntPtr)hPbuffer, (int)iAttribute, (int*)piValue);
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int[] piAttributes, [Out] int[] piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (int* piValues_ptr = piValues)
                    {
                        return Delegates.wglGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                    }
                }
            }

            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] int[] piAttributes, [Out] int[] piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (int* piValues_ptr = piValues)
                    {
                        return Delegates.wglGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] out int piAttributes, [Out] out int piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.wglGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        piAttributes = *piAttributes_ptr;
                        piValues = *piValues_ptr;
                        return retval;
                    }
                }
            }

            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] out int piAttributes, [Out] out int piValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (int* piValues_ptr = &piValues)
                    {
                        Boolean retval = Delegates.wglGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (int*)piValues_ptr);
                        piAttributes = *piAttributes_ptr;
                        piValues = *piValues_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] int* piValues)
            {
                return Delegates.wglGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues);
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] int* piAttributes, [Out] int* piValues)
            {
                return Delegates.wglGetPixelFormatAttribivEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (int*)piValues);
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int[] piAttributes, [Out] Single[] pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        return Delegates.wglGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                    }
                }
            }

            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] int[] piAttributes, [Out] Single[] pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = piAttributes)
                    fixed (Single* pfValues_ptr = pfValues)
                    {
                        return Delegates.wglGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] out int piAttributes, [Out] out Single pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.wglGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        piAttributes = *piAttributes_ptr;
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
                }
            }

            public static 
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] out int piAttributes, [Out] out Single pfValues)
            {
                unsafe
                {
                    fixed (int* piAttributes_ptr = &piAttributes)
                    fixed (Single* pfValues_ptr = &pfValues)
                    {
                        Boolean retval = Delegates.wglGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes_ptr, (Single*)pfValues_ptr);
                        piAttributes = *piAttributes_ptr;
                        pfValues = *pfValues_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] Single* pfValues)
            {
                return Delegates.wglGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues);
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, [Out] int* piAttributes, [Out] Single* pfValues)
            {
                return Delegates.wglGetPixelFormatAttribfvEXT((IntPtr)hdc, (int)iPixelFormat, (int)iLayerPlane, (UInt32)nAttributes, (int*)piAttributes, (Single*)pfValues);
            }

            public static 
            Boolean SwapInterval(int interval)
            {
                return Delegates.wglSwapIntervalEXT((int)interval);
            }

            public static 
            int GetSwapInterval()
            {
                return Delegates.wglGetSwapIntervalEXT();
            }

        }

        public static partial class NV
        {
            [System.CLSCompliant(false)]
            public static 
            unsafe IntPtr AllocateMemory(Int32 size, Single readfreq, Single writefreq, Single priority)
            {
                return Delegates.wglAllocateMemoryNV((Int32)size, (Single)readfreq, (Single)writefreq, (Single)priority);
            }

            public static 
            void FreeMemory([Out] IntPtr pointer)
            {
                unsafe
                {
                    Delegates.wglFreeMemoryNV((IntPtr)pointer);
                }
            }

            public static 
            void FreeMemory([In, Out] object pointer)
            {
                unsafe
                {
                    System.Runtime.InteropServices.GCHandle pointer_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pointer, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        Delegates.wglFreeMemoryNV((IntPtr)pointer_ptr.AddrOfPinnedObject());
                    }
                    finally
                    {
                        pointer_ptr.Free();
                    }
                }
            }

        }

        public static partial class Oml
        {
            public static 
            Boolean GetSyncValues(IntPtr hdc, [Out] Int64[] ust, [Out] Int64[] msc, [Out] Int64[] sbc)
            {
                unsafe
                {
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        return Delegates.wglGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                    }
                }
            }

            public static 
            Boolean GetSyncValues(IntPtr hdc, [Out] out Int64 ust, [Out] out Int64 msc, [Out] out Int64 sbc)
            {
                unsafe
                {
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.wglGetSyncValuesOML((IntPtr)hdc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        msc = *msc_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetSyncValues(IntPtr hdc, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc)
            {
                return Delegates.wglGetSyncValuesOML((IntPtr)hdc, (Int64*)ust, (Int64*)msc, (Int64*)sbc);
            }

            public static 
            Boolean GetMscRate(IntPtr hdc, [Out] Int32[] numerator, [Out] Int32[] denominator)
            {
                unsafe
                {
                    fixed (Int32* numerator_ptr = numerator)
                    fixed (Int32* denominator_ptr = denominator)
                    {
                        return Delegates.wglGetMscRateOML((IntPtr)hdc, (Int32*)numerator_ptr, (Int32*)denominator_ptr);
                    }
                }
            }

            public static 
            Boolean GetMscRate(IntPtr hdc, [Out] out Int32 numerator, [Out] out Int32 denominator)
            {
                unsafe
                {
                    fixed (Int32* numerator_ptr = &numerator)
                    fixed (Int32* denominator_ptr = &denominator)
                    {
                        Boolean retval = Delegates.wglGetMscRateOML((IntPtr)hdc, (Int32*)numerator_ptr, (Int32*)denominator_ptr);
                        numerator = *numerator_ptr;
                        denominator = *denominator_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetMscRate(IntPtr hdc, [Out] Int32* numerator, [Out] Int32* denominator)
            {
                return Delegates.wglGetMscRateOML((IntPtr)hdc, (Int32*)numerator, (Int32*)denominator);
            }

            public static 
            Int64 SwapBuffersMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder)
            {
                return Delegates.wglSwapBuffersMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder);
            }

            public static 
            Int64 SwapLayerBuffersMsc(IntPtr hdc, int fuPlanes, Int64 target_msc, Int64 divisor, Int64 remainder)
            {
                return Delegates.wglSwapLayerBuffersMscOML((IntPtr)hdc, (int)fuPlanes, (Int64)target_msc, (Int64)divisor, (Int64)remainder);
            }

            public static 
            Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64[] ust, [Out] Int64[] msc, [Out] Int64[] sbc)
            {
                unsafe
                {
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        return Delegates.wglWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                    }
                }
            }

            public static 
            Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] out Int64 ust, [Out] out Int64 msc, [Out] out Int64 sbc)
            {
                unsafe
                {
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.wglWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        msc = *msc_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForMsc(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc)
            {
                return Delegates.wglWaitForMscOML((IntPtr)hdc, (Int64)target_msc, (Int64)divisor, (Int64)remainder, (Int64*)ust, (Int64*)msc, (Int64*)sbc);
            }

            public static 
            Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] Int64[] ust, [Out] Int64[] msc, [Out] Int64[] sbc)
            {
                unsafe
                {
                    fixed (Int64* ust_ptr = ust)
                    fixed (Int64* msc_ptr = msc)
                    fixed (Int64* sbc_ptr = sbc)
                    {
                        return Delegates.wglWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                    }
                }
            }

            public static 
            Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] out Int64 ust, [Out] out Int64 msc, [Out] out Int64 sbc)
            {
                unsafe
                {
                    fixed (Int64* ust_ptr = &ust)
                    fixed (Int64* msc_ptr = &msc)
                    fixed (Int64* sbc_ptr = &sbc)
                    {
                        Boolean retval = Delegates.wglWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust_ptr, (Int64*)msc_ptr, (Int64*)sbc_ptr);
                        ust = *ust_ptr;
                        msc = *msc_ptr;
                        sbc = *sbc_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean WaitForSbc(IntPtr hdc, Int64 target_sbc, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc)
            {
                return Delegates.wglWaitForSbcOML((IntPtr)hdc, (Int64)target_sbc, (Int64*)ust, (Int64*)msc, (Int64*)sbc);
            }

        }

        public static partial class I3d
        {
            public static 
            Boolean GetDigitalVideoParameters(IntPtr hDC, int iAttribute, [Out] int[] piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = piValue)
                    {
                        return Delegates.wglGetDigitalVideoParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                    }
                }
            }

            public static 
            Boolean GetDigitalVideoParameters(IntPtr hDC, int iAttribute, [Out] out int piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = &piValue)
                    {
                        Boolean retval = Delegates.wglGetDigitalVideoParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                        piValue = *piValue_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetDigitalVideoParameters(IntPtr hDC, int iAttribute, [Out] int* piValue)
            {
                return Delegates.wglGetDigitalVideoParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue);
            }

            public static 
            Boolean SetDigitalVideoParameters(IntPtr hDC, int iAttribute, int[] piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = piValue)
                    {
                        return Delegates.wglSetDigitalVideoParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                    }
                }
            }

            public static 
            Boolean SetDigitalVideoParameters(IntPtr hDC, int iAttribute, ref int piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = &piValue)
                    {
                        return Delegates.wglSetDigitalVideoParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetDigitalVideoParameters(IntPtr hDC, int iAttribute, int* piValue)
            {
                return Delegates.wglSetDigitalVideoParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue);
            }

            public static 
            Boolean GetGammaTableParameters(IntPtr hDC, int iAttribute, [Out] int[] piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = piValue)
                    {
                        return Delegates.wglGetGammaTableParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                    }
                }
            }

            public static 
            Boolean GetGammaTableParameters(IntPtr hDC, int iAttribute, [Out] out int piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = &piValue)
                    {
                        Boolean retval = Delegates.wglGetGammaTableParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                        piValue = *piValue_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTableParameters(IntPtr hDC, int iAttribute, [Out] int* piValue)
            {
                return Delegates.wglGetGammaTableParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue);
            }

            public static 
            Boolean SetGammaTableParameters(IntPtr hDC, int iAttribute, int[] piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = piValue)
                    {
                        return Delegates.wglSetGammaTableParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                    }
                }
            }

            public static 
            Boolean SetGammaTableParameters(IntPtr hDC, int iAttribute, ref int piValue)
            {
                unsafe
                {
                    fixed (int* piValue_ptr = &piValue)
                    {
                        return Delegates.wglSetGammaTableParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTableParameters(IntPtr hDC, int iAttribute, int* piValue)
            {
                return Delegates.wglSetGammaTableParametersI3D((IntPtr)hDC, (int)iAttribute, (int*)piValue);
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] UInt16[] puRed, [Out] UInt16[] puGreen, [Out] UInt16[] puBlue)
            {
                unsafe
                {
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puGreen_ptr = puGreen)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        return Delegates.wglGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                    }
                }
            }

            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] Int16[] puRed, [Out] Int16[] puGreen, [Out] Int16[] puBlue)
            {
                unsafe
                {
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puGreen_ptr = puGreen)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        return Delegates.wglGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out UInt16 puRed, [Out] out UInt16 puGreen, [Out] out UInt16 puBlue)
            {
                unsafe
                {
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.wglGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puRed = *puRed_ptr;
                        puGreen = *puGreen_ptr;
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
                }
            }

            public static 
            Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] out Int16 puRed, [Out] out Int16 puGreen, [Out] out Int16 puBlue)
            {
                unsafe
                {
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puGreen_ptr = &puGreen)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        Boolean retval = Delegates.wglGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                        puRed = *puRed_ptr;
                        puGreen = *puGreen_ptr;
                        puBlue = *puBlue_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] UInt16* puRed, [Out] UInt16* puGreen, [Out] UInt16* puBlue)
            {
                return Delegates.wglGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue);
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGammaTable(IntPtr hDC, int iEntries, [Out] Int16* puRed, [Out] Int16* puGreen, [Out] Int16* puBlue)
            {
                return Delegates.wglGetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue);
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, UInt16[] puRed, UInt16[] puGreen, UInt16[] puBlue)
            {
                unsafe
                {
                    fixed (UInt16* puRed_ptr = puRed)
                    fixed (UInt16* puGreen_ptr = puGreen)
                    fixed (UInt16* puBlue_ptr = puBlue)
                    {
                        return Delegates.wglSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                    }
                }
            }

            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, Int16[] puRed, Int16[] puGreen, Int16[] puBlue)
            {
                unsafe
                {
                    fixed (Int16* puRed_ptr = puRed)
                    fixed (Int16* puGreen_ptr = puGreen)
                    fixed (Int16* puBlue_ptr = puBlue)
                    {
                        return Delegates.wglSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, ref UInt16 puRed, ref UInt16 puGreen, ref UInt16 puBlue)
            {
                unsafe
                {
                    fixed (UInt16* puRed_ptr = &puRed)
                    fixed (UInt16* puGreen_ptr = &puGreen)
                    fixed (UInt16* puBlue_ptr = &puBlue)
                    {
                        return Delegates.wglSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                    }
                }
            }

            public static 
            Boolean SetGammaTable(IntPtr hDC, int iEntries, ref Int16 puRed, ref Int16 puGreen, ref Int16 puBlue)
            {
                unsafe
                {
                    fixed (Int16* puRed_ptr = &puRed)
                    fixed (Int16* puGreen_ptr = &puGreen)
                    fixed (Int16* puBlue_ptr = &puBlue)
                    {
                        return Delegates.wglSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed_ptr, (UInt16*)puGreen_ptr, (UInt16*)puBlue_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, UInt16* puRed, UInt16* puGreen, UInt16* puBlue)
            {
                return Delegates.wglSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue);
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean SetGammaTable(IntPtr hDC, int iEntries, Int16* puRed, Int16* puGreen, Int16* puBlue)
            {
                return Delegates.wglSetGammaTableI3D((IntPtr)hDC, (int)iEntries, (UInt16*)puRed, (UInt16*)puGreen, (UInt16*)puBlue);
            }

            public static 
            Boolean EnableGenlock(IntPtr hDC)
            {
                return Delegates.wglEnableGenlockI3D((IntPtr)hDC);
            }

            public static 
            Boolean DisableGenlock(IntPtr hDC)
            {
                return Delegates.wglDisableGenlockI3D((IntPtr)hDC);
            }

            public static 
            Boolean IsEnabledGenlock(IntPtr hDC, [Out] Boolean[] pFlag)
            {
                unsafe
                {
                    fixed (Boolean* pFlag_ptr = pFlag)
                    {
                        return Delegates.wglIsEnabledGenlockI3D((IntPtr)hDC, (Boolean*)pFlag_ptr);
                    }
                }
            }

            public static 
            Boolean IsEnabledGenlock(IntPtr hDC, [Out] out Boolean pFlag)
            {
                unsafe
                {
                    fixed (Boolean* pFlag_ptr = &pFlag)
                    {
                        Boolean retval = Delegates.wglIsEnabledGenlockI3D((IntPtr)hDC, (Boolean*)pFlag_ptr);
                        pFlag = *pFlag_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean IsEnabledGenlock(IntPtr hDC, [Out] Boolean* pFlag)
            {
                return Delegates.wglIsEnabledGenlockI3D((IntPtr)hDC, (Boolean*)pFlag);
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GenlockSource(IntPtr hDC, UInt32 uSource)
            {
                return Delegates.wglGenlockSourceI3D((IntPtr)hDC, (UInt32)uSource);
            }

            public static 
            Boolean GenlockSource(IntPtr hDC, Int32 uSource)
            {
                return Delegates.wglGenlockSourceI3D((IntPtr)hDC, (UInt32)uSource);
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetGenlockSource(IntPtr hDC, [Out] UInt32[] uSource)
            {
                unsafe
                {
                    fixed (UInt32* uSource_ptr = uSource)
                    {
                        return Delegates.wglGetGenlockSourceI3D((IntPtr)hDC, (UInt32*)uSource_ptr);
                    }
                }
            }

            public static 
            Boolean GetGenlockSource(IntPtr hDC, [Out] Int32[] uSource)
            {
                unsafe
                {
                    fixed (Int32* uSource_ptr = uSource)
                    {
                        return Delegates.wglGetGenlockSourceI3D((IntPtr)hDC, (UInt32*)uSource_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetGenlockSource(IntPtr hDC, [Out] out UInt32 uSource)
            {
                unsafe
                {
                    fixed (UInt32* uSource_ptr = &uSource)
                    {
                        Boolean retval = Delegates.wglGetGenlockSourceI3D((IntPtr)hDC, (UInt32*)uSource_ptr);
                        uSource = *uSource_ptr;
                        return retval;
                    }
                }
            }

            public static 
            Boolean GetGenlockSource(IntPtr hDC, [Out] out Int32 uSource)
            {
                unsafe
                {
                    fixed (Int32* uSource_ptr = &uSource)
                    {
                        Boolean retval = Delegates.wglGetGenlockSourceI3D((IntPtr)hDC, (UInt32*)uSource_ptr);
                        uSource = *uSource_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGenlockSource(IntPtr hDC, [Out] UInt32* uSource)
            {
                return Delegates.wglGetGenlockSourceI3D((IntPtr)hDC, (UInt32*)uSource);
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGenlockSource(IntPtr hDC, [Out] Int32* uSource)
            {
                return Delegates.wglGetGenlockSourceI3D((IntPtr)hDC, (UInt32*)uSource);
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GenlockSourceEdge(IntPtr hDC, UInt32 uEdge)
            {
                return Delegates.wglGenlockSourceEdgeI3D((IntPtr)hDC, (UInt32)uEdge);
            }

            public static 
            Boolean GenlockSourceEdge(IntPtr hDC, Int32 uEdge)
            {
                return Delegates.wglGenlockSourceEdgeI3D((IntPtr)hDC, (UInt32)uEdge);
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetGenlockSourceEdge(IntPtr hDC, [Out] UInt32[] uEdge)
            {
                unsafe
                {
                    fixed (UInt32* uEdge_ptr = uEdge)
                    {
                        return Delegates.wglGetGenlockSourceEdgeI3D((IntPtr)hDC, (UInt32*)uEdge_ptr);
                    }
                }
            }

            public static 
            Boolean GetGenlockSourceEdge(IntPtr hDC, [Out] Int32[] uEdge)
            {
                unsafe
                {
                    fixed (Int32* uEdge_ptr = uEdge)
                    {
                        return Delegates.wglGetGenlockSourceEdgeI3D((IntPtr)hDC, (UInt32*)uEdge_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetGenlockSourceEdge(IntPtr hDC, [Out] out UInt32 uEdge)
            {
                unsafe
                {
                    fixed (UInt32* uEdge_ptr = &uEdge)
                    {
                        Boolean retval = Delegates.wglGetGenlockSourceEdgeI3D((IntPtr)hDC, (UInt32*)uEdge_ptr);
                        uEdge = *uEdge_ptr;
                        return retval;
                    }
                }
            }

            public static 
            Boolean GetGenlockSourceEdge(IntPtr hDC, [Out] out Int32 uEdge)
            {
                unsafe
                {
                    fixed (Int32* uEdge_ptr = &uEdge)
                    {
                        Boolean retval = Delegates.wglGetGenlockSourceEdgeI3D((IntPtr)hDC, (UInt32*)uEdge_ptr);
                        uEdge = *uEdge_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGenlockSourceEdge(IntPtr hDC, [Out] UInt32* uEdge)
            {
                return Delegates.wglGetGenlockSourceEdgeI3D((IntPtr)hDC, (UInt32*)uEdge);
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGenlockSourceEdge(IntPtr hDC, [Out] Int32* uEdge)
            {
                return Delegates.wglGetGenlockSourceEdgeI3D((IntPtr)hDC, (UInt32*)uEdge);
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GenlockSampleRate(IntPtr hDC, UInt32 uRate)
            {
                return Delegates.wglGenlockSampleRateI3D((IntPtr)hDC, (UInt32)uRate);
            }

            public static 
            Boolean GenlockSampleRate(IntPtr hDC, Int32 uRate)
            {
                return Delegates.wglGenlockSampleRateI3D((IntPtr)hDC, (UInt32)uRate);
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetGenlockSampleRate(IntPtr hDC, [Out] UInt32[] uRate)
            {
                unsafe
                {
                    fixed (UInt32* uRate_ptr = uRate)
                    {
                        return Delegates.wglGetGenlockSampleRateI3D((IntPtr)hDC, (UInt32*)uRate_ptr);
                    }
                }
            }

            public static 
            Boolean GetGenlockSampleRate(IntPtr hDC, [Out] Int32[] uRate)
            {
                unsafe
                {
                    fixed (Int32* uRate_ptr = uRate)
                    {
                        return Delegates.wglGetGenlockSampleRateI3D((IntPtr)hDC, (UInt32*)uRate_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetGenlockSampleRate(IntPtr hDC, [Out] out UInt32 uRate)
            {
                unsafe
                {
                    fixed (UInt32* uRate_ptr = &uRate)
                    {
                        Boolean retval = Delegates.wglGetGenlockSampleRateI3D((IntPtr)hDC, (UInt32*)uRate_ptr);
                        uRate = *uRate_ptr;
                        return retval;
                    }
                }
            }

            public static 
            Boolean GetGenlockSampleRate(IntPtr hDC, [Out] out Int32 uRate)
            {
                unsafe
                {
                    fixed (Int32* uRate_ptr = &uRate)
                    {
                        Boolean retval = Delegates.wglGetGenlockSampleRateI3D((IntPtr)hDC, (UInt32*)uRate_ptr);
                        uRate = *uRate_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGenlockSampleRate(IntPtr hDC, [Out] UInt32* uRate)
            {
                return Delegates.wglGetGenlockSampleRateI3D((IntPtr)hDC, (UInt32*)uRate);
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGenlockSampleRate(IntPtr hDC, [Out] Int32* uRate)
            {
                return Delegates.wglGetGenlockSampleRateI3D((IntPtr)hDC, (UInt32*)uRate);
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GenlockSourceDelay(IntPtr hDC, UInt32 uDelay)
            {
                return Delegates.wglGenlockSourceDelayI3D((IntPtr)hDC, (UInt32)uDelay);
            }

            public static 
            Boolean GenlockSourceDelay(IntPtr hDC, Int32 uDelay)
            {
                return Delegates.wglGenlockSourceDelayI3D((IntPtr)hDC, (UInt32)uDelay);
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetGenlockSourceDelay(IntPtr hDC, [Out] UInt32[] uDelay)
            {
                unsafe
                {
                    fixed (UInt32* uDelay_ptr = uDelay)
                    {
                        return Delegates.wglGetGenlockSourceDelayI3D((IntPtr)hDC, (UInt32*)uDelay_ptr);
                    }
                }
            }

            public static 
            Boolean GetGenlockSourceDelay(IntPtr hDC, [Out] Int32[] uDelay)
            {
                unsafe
                {
                    fixed (Int32* uDelay_ptr = uDelay)
                    {
                        return Delegates.wglGetGenlockSourceDelayI3D((IntPtr)hDC, (UInt32*)uDelay_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean GetGenlockSourceDelay(IntPtr hDC, [Out] out UInt32 uDelay)
            {
                unsafe
                {
                    fixed (UInt32* uDelay_ptr = &uDelay)
                    {
                        Boolean retval = Delegates.wglGetGenlockSourceDelayI3D((IntPtr)hDC, (UInt32*)uDelay_ptr);
                        uDelay = *uDelay_ptr;
                        return retval;
                    }
                }
            }

            public static 
            Boolean GetGenlockSourceDelay(IntPtr hDC, [Out] out Int32 uDelay)
            {
                unsafe
                {
                    fixed (Int32* uDelay_ptr = &uDelay)
                    {
                        Boolean retval = Delegates.wglGetGenlockSourceDelayI3D((IntPtr)hDC, (UInt32*)uDelay_ptr);
                        uDelay = *uDelay_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGenlockSourceDelay(IntPtr hDC, [Out] UInt32* uDelay)
            {
                return Delegates.wglGetGenlockSourceDelayI3D((IntPtr)hDC, (UInt32*)uDelay);
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetGenlockSourceDelay(IntPtr hDC, [Out] Int32* uDelay)
            {
                return Delegates.wglGetGenlockSourceDelayI3D((IntPtr)hDC, (UInt32*)uDelay);
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean QueryGenlockMaxSourceDelay(IntPtr hDC, [Out] UInt32[] uMaxLineDelay, [Out] UInt32[] uMaxPixelDelay)
            {
                unsafe
                {
                    fixed (UInt32* uMaxLineDelay_ptr = uMaxLineDelay)
                    fixed (UInt32* uMaxPixelDelay_ptr = uMaxPixelDelay)
                    {
                        return Delegates.wglQueryGenlockMaxSourceDelayI3D((IntPtr)hDC, (UInt32*)uMaxLineDelay_ptr, (UInt32*)uMaxPixelDelay_ptr);
                    }
                }
            }

            public static 
            Boolean QueryGenlockMaxSourceDelay(IntPtr hDC, [Out] Int32[] uMaxLineDelay, [Out] Int32[] uMaxPixelDelay)
            {
                unsafe
                {
                    fixed (Int32* uMaxLineDelay_ptr = uMaxLineDelay)
                    fixed (Int32* uMaxPixelDelay_ptr = uMaxPixelDelay)
                    {
                        return Delegates.wglQueryGenlockMaxSourceDelayI3D((IntPtr)hDC, (UInt32*)uMaxLineDelay_ptr, (UInt32*)uMaxPixelDelay_ptr);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean QueryGenlockMaxSourceDelay(IntPtr hDC, [Out] out UInt32 uMaxLineDelay, [Out] out UInt32 uMaxPixelDelay)
            {
                unsafe
                {
                    fixed (UInt32* uMaxLineDelay_ptr = &uMaxLineDelay)
                    fixed (UInt32* uMaxPixelDelay_ptr = &uMaxPixelDelay)
                    {
                        Boolean retval = Delegates.wglQueryGenlockMaxSourceDelayI3D((IntPtr)hDC, (UInt32*)uMaxLineDelay_ptr, (UInt32*)uMaxPixelDelay_ptr);
                        uMaxLineDelay = *uMaxLineDelay_ptr;
                        uMaxPixelDelay = *uMaxPixelDelay_ptr;
                        return retval;
                    }
                }
            }

            public static 
            Boolean QueryGenlockMaxSourceDelay(IntPtr hDC, [Out] out Int32 uMaxLineDelay, [Out] out Int32 uMaxPixelDelay)
            {
                unsafe
                {
                    fixed (Int32* uMaxLineDelay_ptr = &uMaxLineDelay)
                    fixed (Int32* uMaxPixelDelay_ptr = &uMaxPixelDelay)
                    {
                        Boolean retval = Delegates.wglQueryGenlockMaxSourceDelayI3D((IntPtr)hDC, (UInt32*)uMaxLineDelay_ptr, (UInt32*)uMaxPixelDelay_ptr);
                        uMaxLineDelay = *uMaxLineDelay_ptr;
                        uMaxPixelDelay = *uMaxPixelDelay_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean QueryGenlockMaxSourceDelay(IntPtr hDC, [Out] UInt32* uMaxLineDelay, [Out] UInt32* uMaxPixelDelay)
            {
                return Delegates.wglQueryGenlockMaxSourceDelayI3D((IntPtr)hDC, (UInt32*)uMaxLineDelay, (UInt32*)uMaxPixelDelay);
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean QueryGenlockMaxSourceDelay(IntPtr hDC, [Out] Int32* uMaxLineDelay, [Out] Int32* uMaxPixelDelay)
            {
                return Delegates.wglQueryGenlockMaxSourceDelayI3D((IntPtr)hDC, (UInt32*)uMaxLineDelay, (UInt32*)uMaxPixelDelay);
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe IntPtr CreateImageBuffer(IntPtr hDC, Int32 dwSize, UInt32 uFlags)
            {
                return Delegates.wglCreateImageBufferI3D((IntPtr)hDC, (Int32)dwSize, (UInt32)uFlags);
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe IntPtr CreateImageBuffer(IntPtr hDC, Int32 dwSize, Int32 uFlags)
            {
                return Delegates.wglCreateImageBufferI3D((IntPtr)hDC, (Int32)dwSize, (UInt32)uFlags);
            }

            public static 
            Boolean DestroyImageBuffer(IntPtr hDC, IntPtr pAddress)
            {
                unsafe
                {
                    return Delegates.wglDestroyImageBufferI3D((IntPtr)hDC, (IntPtr)pAddress);
                }
            }

            public static 
            Boolean DestroyImageBuffer(IntPtr hDC, [In, Out] object pAddress)
            {
                unsafe
                {
                    System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        return Delegates.wglDestroyImageBufferI3D((IntPtr)hDC, (IntPtr)pAddress_ptr.AddrOfPinnedObject());
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr[] pEvent, IntPtr pAddress, Int32[] pSize, UInt32 count)
            {
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    fixed (Int32* pSize_ptr = pSize)
                    {
                        return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (IntPtr)pAddress, (Int32*)pSize_ptr, (UInt32)count);
                    }
                }
            }

            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr[] pEvent, IntPtr pAddress, Int32[] pSize, Int32 count)
            {
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    fixed (Int32* pSize_ptr = pSize)
                    {
                        return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (IntPtr)pAddress, (Int32*)pSize_ptr, (UInt32)count);
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr[] pEvent, [In, Out] object pAddress, Int32[] pSize, UInt32 count)
            {
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    fixed (Int32* pSize_ptr = pSize)
                    {
                        System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                        try
                        {
                            return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        }
                        finally
                        {
                            pAddress_ptr.Free();
                        }
                    }
                }
            }

            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr[] pEvent, [In, Out] object pAddress, Int32[] pSize, Int32 count)
            {
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    fixed (Int32* pSize_ptr = pSize)
                    {
                        System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                        try
                        {
                            return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        }
                        finally
                        {
                            pAddress_ptr.Free();
                        }
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr[] pEvent, [In, Out] object pAddress, ref Int32 pSize, UInt32 count)
            {
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    fixed (Int32* pSize_ptr = &pSize)
                    {
                        System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                        try
                        {
                            return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        }
                        finally
                        {
                            pAddress_ptr.Free();
                        }
                    }
                }
            }

            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr[] pEvent, [In, Out] object pAddress, ref Int32 pSize, Int32 count)
            {
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = pEvent)
                    fixed (Int32* pSize_ptr = &pSize)
                    {
                        System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                        try
                        {
                            return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        }
                        finally
                        {
                            pAddress_ptr.Free();
                        }
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, [In, Out] object pAddress, Int32[] pSize, UInt32 count)
            {
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    fixed (Int32* pSize_ptr = pSize)
                    {
                        System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                        try
                        {
                            return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        }
                        finally
                        {
                            pAddress_ptr.Free();
                        }
                    }
                }
            }

            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, [In, Out] object pAddress, Int32[] pSize, Int32 count)
            {
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    fixed (Int32* pSize_ptr = pSize)
                    {
                        System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                        try
                        {
                            return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        }
                        finally
                        {
                            pAddress_ptr.Free();
                        }
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, [In, Out] object pAddress, ref Int32 pSize, UInt32 count)
            {
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    fixed (Int32* pSize_ptr = &pSize)
                    {
                        System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                        try
                        {
                            return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        }
                        finally
                        {
                            pAddress_ptr.Free();
                        }
                    }
                }
            }

            public static 
            Boolean AssociateImageBufferEvents(IntPtr hDC, ref IntPtr pEvent, [In, Out] object pAddress, ref Int32 pSize, Int32 count)
            {
                unsafe
                {
                    fixed (IntPtr* pEvent_ptr = &pEvent)
                    fixed (Int32* pSize_ptr = &pSize)
                    {
                        System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                        try
                        {
                            return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent_ptr, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        }
                        finally
                        {
                            pAddress_ptr.Free();
                        }
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, [In, Out] object pAddress, Int32* pSize, UInt32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                try
                {
                    return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize, (UInt32)count);
                }
                finally
                {
                    pAddress_ptr.Free();
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, [In, Out] object pAddress, Int32* pSize, Int32 count)
            {
                System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                try
                {
                    return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize, (UInt32)count);
                }
                finally
                {
                    pAddress_ptr.Free();
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, [In, Out] object pAddress, Int32[] pSize, UInt32 count)
            {
                unsafe
                {
                    fixed (Int32* pSize_ptr = pSize)
                    {
                        System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                        try
                        {
                            return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        }
                        finally
                        {
                            pAddress_ptr.Free();
                        }
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, [In, Out] object pAddress, Int32[] pSize, Int32 count)
            {
                unsafe
                {
                    fixed (Int32* pSize_ptr = pSize)
                    {
                        System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                        try
                        {
                            return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        }
                        finally
                        {
                            pAddress_ptr.Free();
                        }
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, [In, Out] object pAddress, ref Int32 pSize, UInt32 count)
            {
                unsafe
                {
                    fixed (Int32* pSize_ptr = &pSize)
                    {
                        System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                        try
                        {
                            return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        }
                        finally
                        {
                            pAddress_ptr.Free();
                        }
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean AssociateImageBufferEvents(IntPtr hDC, IntPtr* pEvent, [In, Out] object pAddress, ref Int32 pSize, Int32 count)
            {
                unsafe
                {
                    fixed (Int32* pSize_ptr = &pSize)
                    {
                        System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                        try
                        {
                            return Delegates.wglAssociateImageBufferEventsI3D((IntPtr)hDC, (IntPtr*)pEvent, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (Int32*)pSize_ptr, (UInt32)count);
                        }
                        finally
                        {
                            pAddress_ptr.Free();
                        }
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean ReleaseImageBufferEvents(IntPtr hDC, IntPtr pAddress, UInt32 count)
            {
                unsafe
                {
                    return Delegates.wglReleaseImageBufferEventsI3D((IntPtr)hDC, (IntPtr)pAddress, (UInt32)count);
                }
            }

            public static 
            Boolean ReleaseImageBufferEvents(IntPtr hDC, IntPtr pAddress, Int32 count)
            {
                unsafe
                {
                    return Delegates.wglReleaseImageBufferEventsI3D((IntPtr)hDC, (IntPtr)pAddress, (UInt32)count);
                }
            }

            [System.CLSCompliant(false)]
            public static 
            Boolean ReleaseImageBufferEvents(IntPtr hDC, [In, Out] object pAddress, UInt32 count)
            {
                unsafe
                {
                    System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        return Delegates.wglReleaseImageBufferEventsI3D((IntPtr)hDC, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (UInt32)count);
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }

            public static 
            Boolean ReleaseImageBufferEvents(IntPtr hDC, [In, Out] object pAddress, Int32 count)
            {
                unsafe
                {
                    System.Runtime.InteropServices.GCHandle pAddress_ptr = System.Runtime.InteropServices.GCHandle.Alloc(pAddress, System.Runtime.InteropServices.GCHandleType.Pinned);
                    try
                    {
                        return Delegates.wglReleaseImageBufferEventsI3D((IntPtr)hDC, (IntPtr)pAddress_ptr.AddrOfPinnedObject(), (UInt32)count);
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }

            public static 
            Boolean EnableFrameLock()
            {
                return Delegates.wglEnableFrameLockI3D();
            }

            public static 
            Boolean DisableFrameLock()
            {
                return Delegates.wglDisableFrameLockI3D();
            }

            public static 
            Boolean IsEnabledFrameLock([Out] Boolean[] pFlag)
            {
                unsafe
                {
                    fixed (Boolean* pFlag_ptr = pFlag)
                    {
                        return Delegates.wglIsEnabledFrameLockI3D((Boolean*)pFlag_ptr);
                    }
                }
            }

            public static 
            Boolean IsEnabledFrameLock([Out] out Boolean pFlag)
            {
                unsafe
                {
                    fixed (Boolean* pFlag_ptr = &pFlag)
                    {
                        Boolean retval = Delegates.wglIsEnabledFrameLockI3D((Boolean*)pFlag_ptr);
                        pFlag = *pFlag_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean IsEnabledFrameLock([Out] Boolean* pFlag)
            {
                return Delegates.wglIsEnabledFrameLockI3D((Boolean*)pFlag);
            }

            public static 
            Boolean QueryFrameLockMaster([Out] Boolean[] pFlag)
            {
                unsafe
                {
                    fixed (Boolean* pFlag_ptr = pFlag)
                    {
                        return Delegates.wglQueryFrameLockMasterI3D((Boolean*)pFlag_ptr);
                    }
                }
            }

            public static 
            Boolean QueryFrameLockMaster([Out] out Boolean pFlag)
            {
                unsafe
                {
                    fixed (Boolean* pFlag_ptr = &pFlag)
                    {
                        Boolean retval = Delegates.wglQueryFrameLockMasterI3D((Boolean*)pFlag_ptr);
                        pFlag = *pFlag_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean QueryFrameLockMaster([Out] Boolean* pFlag)
            {
                return Delegates.wglQueryFrameLockMasterI3D((Boolean*)pFlag);
            }

            public static 
            Boolean GetFrameUsage([Out] float[] pUsage)
            {
                unsafe
                {
                    fixed (float* pUsage_ptr = pUsage)
                    {
                        return Delegates.wglGetFrameUsageI3D((float*)pUsage_ptr);
                    }
                }
            }

            public static 
            Boolean GetFrameUsage([Out] out float pUsage)
            {
                unsafe
                {
                    fixed (float* pUsage_ptr = &pUsage)
                    {
                        Boolean retval = Delegates.wglGetFrameUsageI3D((float*)pUsage_ptr);
                        pUsage = *pUsage_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean GetFrameUsage([Out] float* pUsage)
            {
                return Delegates.wglGetFrameUsageI3D((float*)pUsage);
            }

            public static 
            Boolean BeginFrameTracking()
            {
                return Delegates.wglBeginFrameTrackingI3D();
            }

            public static 
            Boolean EndFrameTracking()
            {
                return Delegates.wglEndFrameTrackingI3D();
            }

            public static 
            Boolean QueryFrameTracking([Out] Int32[] pFrameCount, [Out] Int32[] pMissedFrames, [Out] float[] pLastMissedUsage)
            {
                unsafe
                {
                    fixed (Int32* pFrameCount_ptr = pFrameCount)
                    fixed (Int32* pMissedFrames_ptr = pMissedFrames)
                    fixed (float* pLastMissedUsage_ptr = pLastMissedUsage)
                    {
                        return Delegates.wglQueryFrameTrackingI3D((Int32*)pFrameCount_ptr, (Int32*)pMissedFrames_ptr, (float*)pLastMissedUsage_ptr);
                    }
                }
            }

            public static 
            Boolean QueryFrameTracking([Out] out Int32 pFrameCount, [Out] out Int32 pMissedFrames, [Out] out float pLastMissedUsage)
            {
                unsafe
                {
                    fixed (Int32* pFrameCount_ptr = &pFrameCount)
                    fixed (Int32* pMissedFrames_ptr = &pMissedFrames)
                    fixed (float* pLastMissedUsage_ptr = &pLastMissedUsage)
                    {
                        Boolean retval = Delegates.wglQueryFrameTrackingI3D((Int32*)pFrameCount_ptr, (Int32*)pMissedFrames_ptr, (float*)pLastMissedUsage_ptr);
                        pFrameCount = *pFrameCount_ptr;
                        pMissedFrames = *pMissedFrames_ptr;
                        pLastMissedUsage = *pLastMissedUsage_ptr;
                        return retval;
                    }
                }
            }

            [System.CLSCompliant(false)]
            public static 
            unsafe Boolean QueryFrameTracking([Out] Int32* pFrameCount, [Out] Int32* pMissedFrames, [Out] float* pLastMissedUsage)
            {
                return Delegates.wglQueryFrameTrackingI3D((Int32*)pFrameCount, (Int32*)pMissedFrames, (float*)pLastMissedUsage);
            }

        }

    }
}

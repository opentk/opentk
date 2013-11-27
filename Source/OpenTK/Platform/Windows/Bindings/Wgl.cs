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
    }
}

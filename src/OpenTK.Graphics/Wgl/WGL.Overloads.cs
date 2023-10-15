// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;
using OpenTK.Graphics;

namespace OpenTK.Graphics.Wgl
{
    public static unsafe partial class WGL
    {
        /// <inheritdoc cref="ChoosePixelFormat(IntPtr, PixelFormatDescriptor*)"/>
        public static unsafe int ChoosePixelFormat(IntPtr hDc, ReadOnlySpan<PixelFormatDescriptor> pPfd)
        {
            int returnValue;
            fixed (PixelFormatDescriptor* pPfd_ptr = pPfd)
            {
                returnValue = ChoosePixelFormat(hDc, pPfd_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="ChoosePixelFormat(IntPtr, PixelFormatDescriptor*)"/>
        public static unsafe int ChoosePixelFormat(IntPtr hDc, PixelFormatDescriptor[] pPfd)
        {
            int returnValue;
            fixed (PixelFormatDescriptor* pPfd_ptr = pPfd)
            {
                returnValue = ChoosePixelFormat(hDc, pPfd_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="ChoosePixelFormat(IntPtr, PixelFormatDescriptor*)"/>
        public static unsafe int ChoosePixelFormat(IntPtr hDc, in PixelFormatDescriptor pPfd)
        {
            int returnValue;
            fixed (PixelFormatDescriptor* pPfd_ptr = &pPfd)
            {
                returnValue = ChoosePixelFormat(hDc, pPfd_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="DescribeLayerPlane(IntPtr, int, int, uint, LayerPlaneDescriptor*)"/>
        public static unsafe int DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, uint nBytes, Span<LayerPlaneDescriptor> plpd)
        {
            int returnValue;
            fixed (LayerPlaneDescriptor* plpd_ptr = plpd)
            {
                returnValue = DescribeLayerPlane(hDc, pixelFormat, layerPlane, nBytes, plpd_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="DescribeLayerPlane(IntPtr, int, int, uint, LayerPlaneDescriptor*)"/>
        public static unsafe int DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, uint nBytes, LayerPlaneDescriptor[] plpd)
        {
            int returnValue;
            fixed (LayerPlaneDescriptor* plpd_ptr = plpd)
            {
                returnValue = DescribeLayerPlane(hDc, pixelFormat, layerPlane, nBytes, plpd_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="DescribeLayerPlane(IntPtr, int, int, uint, LayerPlaneDescriptor*)"/>
        public static unsafe int DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, uint nBytes, ref LayerPlaneDescriptor plpd)
        {
            int returnValue;
            fixed (LayerPlaneDescriptor* plpd_ptr = &plpd)
            {
                returnValue = DescribeLayerPlane(hDc, pixelFormat, layerPlane, nBytes, plpd_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="DescribePixelFormat(IntPtr, int, uint, PixelFormatDescriptor*)"/>
        public static unsafe int DescribePixelFormat(IntPtr hdc, int ipfd, uint cjpfd, Span<PixelFormatDescriptor> ppfd)
        {
            int returnValue;
            fixed (PixelFormatDescriptor* ppfd_ptr = ppfd)
            {
                returnValue = DescribePixelFormat(hdc, ipfd, cjpfd, ppfd_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="DescribePixelFormat(IntPtr, int, uint, PixelFormatDescriptor*)"/>
        public static unsafe int DescribePixelFormat(IntPtr hdc, int ipfd, uint cjpfd, PixelFormatDescriptor[] ppfd)
        {
            int returnValue;
            fixed (PixelFormatDescriptor* ppfd_ptr = ppfd)
            {
                returnValue = DescribePixelFormat(hdc, ipfd, cjpfd, ppfd_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="DescribePixelFormat(IntPtr, int, uint, PixelFormatDescriptor*)"/>
        public static unsafe int DescribePixelFormat(IntPtr hdc, int ipfd, uint cjpfd, ref PixelFormatDescriptor ppfd)
        {
            int returnValue;
            fixed (PixelFormatDescriptor* ppfd_ptr = &ppfd)
            {
                returnValue = DescribePixelFormat(hdc, ipfd, cjpfd, ppfd_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEnhMetaFilePixelFormat(IntPtr, uint, PixelFormatDescriptor*)"/>
        public static unsafe uint GetEnhMetaFilePixelFormat(IntPtr hemf, uint cbBuffer, Span<PixelFormatDescriptor> ppfd)
        {
            uint returnValue;
            fixed (PixelFormatDescriptor* ppfd_ptr = ppfd)
            {
                returnValue = GetEnhMetaFilePixelFormat(hemf, cbBuffer, ppfd_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEnhMetaFilePixelFormat(IntPtr, uint, PixelFormatDescriptor*)"/>
        public static unsafe uint GetEnhMetaFilePixelFormat(IntPtr hemf, uint cbBuffer, PixelFormatDescriptor[] ppfd)
        {
            uint returnValue;
            fixed (PixelFormatDescriptor* ppfd_ptr = ppfd)
            {
                returnValue = GetEnhMetaFilePixelFormat(hemf, cbBuffer, ppfd_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetEnhMetaFilePixelFormat(IntPtr, uint, PixelFormatDescriptor*)"/>
        public static unsafe uint GetEnhMetaFilePixelFormat(IntPtr hemf, uint cbBuffer, ref PixelFormatDescriptor ppfd)
        {
            uint returnValue;
            fixed (PixelFormatDescriptor* ppfd_ptr = &ppfd)
            {
                returnValue = GetEnhMetaFilePixelFormat(hemf, cbBuffer, ppfd_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetLayerPaletteEntries(IntPtr, int, int, int, ColorRef*)"/>
        public static unsafe int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, Span<ColorRef> pcr)
        {
            int returnValue;
            int cEntries = (int)(pcr.Length);
            fixed (ColorRef* pcr_ptr = pcr)
            {
                returnValue = GetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, pcr_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetLayerPaletteEntries(IntPtr, int, int, int, ColorRef*)"/>
        public static unsafe int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, ColorRef[] pcr)
        {
            int returnValue;
            int cEntries = (int)(pcr.Length);
            fixed (ColorRef* pcr_ptr = pcr)
            {
                returnValue = GetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, pcr_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetLayerPaletteEntries(IntPtr, int, int, int, ColorRef*)"/>
        public static unsafe int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, ref ColorRef pcr)
        {
            int returnValue;
            fixed (ColorRef* pcr_ptr = &pcr)
            {
                returnValue = GetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, pcr_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProcAddress(char*)"/>
        public static unsafe IntPtr GetProcAddress(string lpszProc)
        {
            IntPtr returnValue;
            char* lpszProc_ptr = (char*)Marshal.StringToCoTaskMemAuto(lpszProc);
            returnValue = GetProcAddress(lpszProc_ptr);
            Marshal.FreeCoTaskMem((IntPtr)lpszProc_ptr);
            return returnValue;
        }
        /// <inheritdoc cref="SetLayerPaletteEntries(IntPtr, int, int, int, ColorRef*)"/>
        public static unsafe int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, ReadOnlySpan<ColorRef> pcr)
        {
            int returnValue;
            int cEntries = (int)(pcr.Length);
            fixed (ColorRef* pcr_ptr = pcr)
            {
                returnValue = SetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, pcr_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetLayerPaletteEntries(IntPtr, int, int, int, ColorRef*)"/>
        public static unsafe int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, ColorRef[] pcr)
        {
            int returnValue;
            int cEntries = (int)(pcr.Length);
            fixed (ColorRef* pcr_ptr = pcr)
            {
                returnValue = SetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, pcr_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetLayerPaletteEntries(IntPtr, int, int, int, ColorRef*)"/>
        public static unsafe int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, in ColorRef pcr)
        {
            int returnValue;
            fixed (ColorRef* pcr_ptr = &pcr)
            {
                returnValue = SetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, pcr_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetPixelFormat(IntPtr, int, PixelFormatDescriptor*)"/>
        public static unsafe int SetPixelFormat(IntPtr hdc, int ipfd, ReadOnlySpan<PixelFormatDescriptor> ppfd)
        {
            int returnValue;
            fixed (PixelFormatDescriptor* ppfd_ptr = ppfd)
            {
                returnValue = SetPixelFormat(hdc, ipfd, ppfd_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetPixelFormat(IntPtr, int, PixelFormatDescriptor*)"/>
        public static unsafe int SetPixelFormat(IntPtr hdc, int ipfd, PixelFormatDescriptor[] ppfd)
        {
            int returnValue;
            fixed (PixelFormatDescriptor* ppfd_ptr = ppfd)
            {
                returnValue = SetPixelFormat(hdc, ipfd, ppfd_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SetPixelFormat(IntPtr, int, PixelFormatDescriptor*)"/>
        public static unsafe int SetPixelFormat(IntPtr hdc, int ipfd, in PixelFormatDescriptor ppfd)
        {
            int returnValue;
            fixed (PixelFormatDescriptor* ppfd_ptr = &ppfd)
            {
                returnValue = SetPixelFormat(hdc, ipfd, ppfd_ptr);
            }
            return returnValue;
        }
        public static unsafe partial class _3DL
        {
        }
        public static unsafe partial class AMD
        {
            /// <inheritdoc cref="CreateAssociatedContextAttribsAMD(uint, IntPtr, int*)"/>
            public static unsafe IntPtr CreateAssociatedContextAttribsAMD(uint id, IntPtr hShareContext, in int attribList)
            {
                IntPtr returnValue;
                fixed (int* attribList_ptr = &attribList)
                {
                    returnValue = CreateAssociatedContextAttribsAMD(id, hShareContext, attribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGPUIDsAMD(uint, uint*)"/>
            public static unsafe uint GetGPUIDsAMD(Span<uint> ids)
            {
                uint returnValue;
                uint maxCount = (uint)(ids.Length);
                fixed (uint* ids_ptr = ids)
                {
                    returnValue = GetGPUIDsAMD(maxCount, ids_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGPUIDsAMD(uint, uint*)"/>
            public static unsafe uint GetGPUIDsAMD(uint[] ids)
            {
                uint returnValue;
                uint maxCount = (uint)(ids.Length);
                fixed (uint* ids_ptr = ids)
                {
                    returnValue = GetGPUIDsAMD(maxCount, ids_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGPUIDsAMD(uint, uint*)"/>
            public static unsafe uint GetGPUIDsAMD(uint maxCount, ref uint ids)
            {
                uint returnValue;
                fixed (uint* ids_ptr = &ids)
                {
                    returnValue = GetGPUIDsAMD(maxCount, ids_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGPUInfoAMD(uint, GPUPropertyAMD, All, uint, void*)"/>
            public static unsafe int GetGPUInfoAMD(uint id, GPUPropertyAMD property, All dataType, uint size, IntPtr data)
            {
                int returnValue;
                void* data_vptr = (void*)data;
                returnValue = GetGPUInfoAMD(id, property, dataType, size, data_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="GetGPUInfoAMD(uint, GPUPropertyAMD, All, uint, void*)"/>
            public static unsafe int GetGPUInfoAMD<T1>(uint id, GPUPropertyAMD property, All dataType, uint size, Span<T1> data)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* data_ptr = data)
                {
                    returnValue = GetGPUInfoAMD(id, property, dataType, size, data_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGPUInfoAMD(uint, GPUPropertyAMD, All, uint, void*)"/>
            public static unsafe int GetGPUInfoAMD<T1>(uint id, GPUPropertyAMD property, All dataType, uint size, T1[] data)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* data_ptr = data)
                {
                    returnValue = GetGPUInfoAMD(id, property, dataType, size, data_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGPUInfoAMD(uint, GPUPropertyAMD, All, uint, void*)"/>
            public static unsafe int GetGPUInfoAMD<T1>(uint id, GPUPropertyAMD property, All dataType, uint size, ref T1 data)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* data_ptr = &data)
                {
                    returnValue = GetGPUInfoAMD(id, property, dataType, size, data_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class ARB
        {
            /// <inheritdoc cref="ChoosePixelFormatARB(IntPtr, int*, float*, uint, int*, uint*)"/>
            public static unsafe int ChoosePixelFormatARB(IntPtr hdc, in int piAttribIList, in float pfAttribFList, Span<int> piFormats, Span<uint> nNumFormats)
            {
                int returnValue;
                fixed (int* piAttribIList_ptr = &piAttribIList)
                fixed (float* pfAttribFList_ptr = &pfAttribFList)
                {
                    uint nMaxFormats = (uint)(piFormats.Length);
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        fixed (uint* nNumFormats_ptr = nNumFormats)
                        {
                            returnValue = ChoosePixelFormatARB(hdc, piAttribIList_ptr, pfAttribFList_ptr, nMaxFormats, piFormats_ptr, nNumFormats_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="ChoosePixelFormatARB(IntPtr, int*, float*, uint, int*, uint*)"/>
            public static unsafe int ChoosePixelFormatARB(IntPtr hdc, in int piAttribIList, in float pfAttribFList, int[] piFormats, uint[] nNumFormats)
            {
                int returnValue;
                fixed (int* piAttribIList_ptr = &piAttribIList)
                fixed (float* pfAttribFList_ptr = &pfAttribFList)
                {
                    uint nMaxFormats = (uint)(piFormats.Length);
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        fixed (uint* nNumFormats_ptr = nNumFormats)
                        {
                            returnValue = ChoosePixelFormatARB(hdc, piAttribIList_ptr, pfAttribFList_ptr, nMaxFormats, piFormats_ptr, nNumFormats_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="ChoosePixelFormatARB(IntPtr, int*, float*, uint, int*, uint*)"/>
            public static unsafe int ChoosePixelFormatARB(IntPtr hdc, in int piAttribIList, in float pfAttribFList, uint nMaxFormats, ref int piFormats, ref uint nNumFormats)
            {
                int returnValue;
                fixed (int* piAttribIList_ptr = &piAttribIList)
                fixed (float* pfAttribFList_ptr = &pfAttribFList)
                fixed (int* piFormats_ptr = &piFormats)
                fixed (uint* nNumFormats_ptr = &nNumFormats)
                {
                    returnValue = ChoosePixelFormatARB(hdc, piAttribIList_ptr, pfAttribFList_ptr, nMaxFormats, piFormats_ptr, nNumFormats_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateContextAttribsARB(IntPtr, IntPtr, int*)"/>
            public static unsafe IntPtr CreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, in int attribList)
            {
                IntPtr returnValue;
                fixed (int* attribList_ptr = &attribList)
                {
                    returnValue = CreateContextAttribsARB(hDC, hShareContext, attribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreatePbufferARB(IntPtr, int, int, int, int*)"/>
            public static unsafe IntPtr CreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, in int piAttribList)
            {
                IntPtr returnValue;
                fixed (int* piAttribList_ptr = &piAttribList)
                {
                    returnValue = CreatePbufferARB(hDC, iPixelFormat, iWidth, iHeight, piAttribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetExtensionsStringARB(IntPtr)"/>
            public static unsafe string? GetExtensionsStringARB(IntPtr hdc)
            {
                string? returnValue_str;
                byte* returnValue;
                returnValue = GetExtensionsStringARB_(hdc);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="GetPixelFormatAttribfvARB(IntPtr, int, int, uint, int*, float*)"/>
            public static unsafe int GetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, ReadOnlySpan<int> piAttributes, Span<float> pfValues)
            {
                int returnValue;
                fixed (int* piAttributes_ptr = piAttributes)
                {
                    fixed (float* pfValues_ptr = pfValues)
                    {
                        returnValue = GetPixelFormatAttribfvARB(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes_ptr, pfValues_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetPixelFormatAttribfvARB(IntPtr, int, int, uint, int*, float*)"/>
            public static unsafe int GetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int[] piAttributes, float[] pfValues)
            {
                int returnValue;
                fixed (int* piAttributes_ptr = piAttributes)
                {
                    fixed (float* pfValues_ptr = pfValues)
                    {
                        returnValue = GetPixelFormatAttribfvARB(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes_ptr, pfValues_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetPixelFormatAttribfvARB(IntPtr, int, int, uint, int*, float*)"/>
            public static unsafe int GetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, in int piAttributes, ref float pfValues)
            {
                int returnValue;
                fixed (int* piAttributes_ptr = &piAttributes)
                fixed (float* pfValues_ptr = &pfValues)
                {
                    returnValue = GetPixelFormatAttribfvARB(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes_ptr, pfValues_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetPixelFormatAttribivARB(IntPtr, int, int, uint, int*, int*)"/>
            public static unsafe int GetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, ReadOnlySpan<int> piAttributes, Span<int> piValues)
            {
                int returnValue;
                fixed (int* piAttributes_ptr = piAttributes)
                {
                    fixed (int* piValues_ptr = piValues)
                    {
                        returnValue = GetPixelFormatAttribivARB(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes_ptr, piValues_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetPixelFormatAttribivARB(IntPtr, int, int, uint, int*, int*)"/>
            public static unsafe int GetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int[] piAttributes, int[] piValues)
            {
                int returnValue;
                fixed (int* piAttributes_ptr = piAttributes)
                {
                    fixed (int* piValues_ptr = piValues)
                    {
                        returnValue = GetPixelFormatAttribivARB(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes_ptr, piValues_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetPixelFormatAttribivARB(IntPtr, int, int, uint, int*, int*)"/>
            public static unsafe int GetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, in int piAttributes, ref int piValues)
            {
                int returnValue;
                fixed (int* piAttributes_ptr = &piAttributes)
                fixed (int* piValues_ptr = &piValues)
                {
                    returnValue = GetPixelFormatAttribivARB(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes_ptr, piValues_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryPbufferARB(IntPtr, PBufferAttribute, int*)"/>
            public static unsafe int QueryPbufferARB(IntPtr hPbuffer, PBufferAttribute iAttribute, Span<int> piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = QueryPbufferARB(hPbuffer, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryPbufferARB(IntPtr, PBufferAttribute, int*)"/>
            public static unsafe int QueryPbufferARB(IntPtr hPbuffer, PBufferAttribute iAttribute, int[] piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = QueryPbufferARB(hPbuffer, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryPbufferARB(IntPtr, PBufferAttribute, int*)"/>
            public static unsafe int QueryPbufferARB(IntPtr hPbuffer, PBufferAttribute iAttribute, ref int piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = &piValue)
                {
                    returnValue = QueryPbufferARB(hPbuffer, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetPbufferAttribARB(IntPtr, int*)"/>
            public static unsafe int SetPbufferAttribARB(IntPtr hPbuffer, in int piAttribList)
            {
                int returnValue;
                fixed (int* piAttribList_ptr = &piAttribList)
                {
                    returnValue = SetPbufferAttribARB(hPbuffer, piAttribList_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class EXT
        {
            /// <inheritdoc cref="ChoosePixelFormatEXT(IntPtr, int*, float*, uint, int*, uint*)"/>
            public static unsafe int ChoosePixelFormatEXT(IntPtr hdc, in int piAttribIList, in float pfAttribFList, Span<int> piFormats, Span<uint> nNumFormats)
            {
                int returnValue;
                fixed (int* piAttribIList_ptr = &piAttribIList)
                fixed (float* pfAttribFList_ptr = &pfAttribFList)
                {
                    uint nMaxFormats = (uint)(piFormats.Length);
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        fixed (uint* nNumFormats_ptr = nNumFormats)
                        {
                            returnValue = ChoosePixelFormatEXT(hdc, piAttribIList_ptr, pfAttribFList_ptr, nMaxFormats, piFormats_ptr, nNumFormats_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="ChoosePixelFormatEXT(IntPtr, int*, float*, uint, int*, uint*)"/>
            public static unsafe int ChoosePixelFormatEXT(IntPtr hdc, in int piAttribIList, in float pfAttribFList, int[] piFormats, uint[] nNumFormats)
            {
                int returnValue;
                fixed (int* piAttribIList_ptr = &piAttribIList)
                fixed (float* pfAttribFList_ptr = &pfAttribFList)
                {
                    uint nMaxFormats = (uint)(piFormats.Length);
                    fixed (int* piFormats_ptr = piFormats)
                    {
                        fixed (uint* nNumFormats_ptr = nNumFormats)
                        {
                            returnValue = ChoosePixelFormatEXT(hdc, piAttribIList_ptr, pfAttribFList_ptr, nMaxFormats, piFormats_ptr, nNumFormats_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="ChoosePixelFormatEXT(IntPtr, int*, float*, uint, int*, uint*)"/>
            public static unsafe int ChoosePixelFormatEXT(IntPtr hdc, in int piAttribIList, in float pfAttribFList, uint nMaxFormats, ref int piFormats, ref uint nNumFormats)
            {
                int returnValue;
                fixed (int* piAttribIList_ptr = &piAttribIList)
                fixed (float* pfAttribFList_ptr = &pfAttribFList)
                fixed (int* piFormats_ptr = &piFormats)
                fixed (uint* nNumFormats_ptr = &nNumFormats)
                {
                    returnValue = ChoosePixelFormatEXT(hdc, piAttribIList_ptr, pfAttribFList_ptr, nMaxFormats, piFormats_ptr, nNumFormats_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreatePbufferEXT(IntPtr, int, int, int, int*)"/>
            public static unsafe IntPtr CreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, in int piAttribList)
            {
                IntPtr returnValue;
                fixed (int* piAttribList_ptr = &piAttribList)
                {
                    returnValue = CreatePbufferEXT(hDC, iPixelFormat, iWidth, iHeight, piAttribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetExtensionsStringEXT()"/>
            public static unsafe string? GetExtensionsStringEXT()
            {
                string? returnValue_str;
                byte* returnValue;
                returnValue = GetExtensionsStringEXT_();
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="GetPixelFormatAttribfvEXT(IntPtr, int, int, uint, int*, float*)"/>
            public static unsafe int GetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, Span<int> piAttributes, Span<float> pfValues)
            {
                int returnValue;
                fixed (int* piAttributes_ptr = piAttributes)
                {
                    fixed (float* pfValues_ptr = pfValues)
                    {
                        returnValue = GetPixelFormatAttribfvEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes_ptr, pfValues_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetPixelFormatAttribfvEXT(IntPtr, int, int, uint, int*, float*)"/>
            public static unsafe int GetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int[] piAttributes, float[] pfValues)
            {
                int returnValue;
                fixed (int* piAttributes_ptr = piAttributes)
                {
                    fixed (float* pfValues_ptr = pfValues)
                    {
                        returnValue = GetPixelFormatAttribfvEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes_ptr, pfValues_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetPixelFormatAttribfvEXT(IntPtr, int, int, uint, int*, float*)"/>
            public static unsafe int GetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, ref int piAttributes, ref float pfValues)
            {
                int returnValue;
                fixed (int* piAttributes_ptr = &piAttributes)
                fixed (float* pfValues_ptr = &pfValues)
                {
                    returnValue = GetPixelFormatAttribfvEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes_ptr, pfValues_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetPixelFormatAttribivEXT(IntPtr, int, int, uint, int*, int*)"/>
            public static unsafe int GetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, Span<int> piAttributes, Span<int> piValues)
            {
                int returnValue;
                fixed (int* piAttributes_ptr = piAttributes)
                {
                    fixed (int* piValues_ptr = piValues)
                    {
                        returnValue = GetPixelFormatAttribivEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes_ptr, piValues_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetPixelFormatAttribivEXT(IntPtr, int, int, uint, int*, int*)"/>
            public static unsafe int GetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int[] piAttributes, int[] piValues)
            {
                int returnValue;
                fixed (int* piAttributes_ptr = piAttributes)
                {
                    fixed (int* piValues_ptr = piValues)
                    {
                        returnValue = GetPixelFormatAttribivEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes_ptr, piValues_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetPixelFormatAttribivEXT(IntPtr, int, int, uint, int*, int*)"/>
            public static unsafe int GetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, ref int piAttributes, ref int piValues)
            {
                int returnValue;
                fixed (int* piAttributes_ptr = &piAttributes)
                fixed (int* piValues_ptr = &piValues)
                {
                    returnValue = GetPixelFormatAttribivEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes_ptr, piValues_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="LoadDisplayColorTableEXT(ushort*, uint)"/>
            public static unsafe bool LoadDisplayColorTableEXT(ReadOnlySpan<ushort> table)
            {
                bool returnValue;
                uint length = (uint)(table.Length / 3);
                fixed (ushort* table_ptr = table)
                {
                    returnValue = LoadDisplayColorTableEXT(table_ptr, length);
                }
                return returnValue;
            }
            /// <inheritdoc cref="LoadDisplayColorTableEXT(ushort*, uint)"/>
            public static unsafe bool LoadDisplayColorTableEXT(ushort[] table)
            {
                bool returnValue;
                uint length = (uint)(table.Length / 3);
                fixed (ushort* table_ptr = table)
                {
                    returnValue = LoadDisplayColorTableEXT(table_ptr, length);
                }
                return returnValue;
            }
            /// <inheritdoc cref="LoadDisplayColorTableEXT(ushort*, uint)"/>
            public static unsafe bool LoadDisplayColorTableEXT(in ushort table, uint length)
            {
                bool returnValue;
                fixed (ushort* table_ptr = &table)
                {
                    returnValue = LoadDisplayColorTableEXT(table_ptr, length);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryPbufferEXT(IntPtr, PBufferAttribute, int*)"/>
            public static unsafe int QueryPbufferEXT(IntPtr hPbuffer, PBufferAttribute iAttribute, Span<int> piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = QueryPbufferEXT(hPbuffer, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryPbufferEXT(IntPtr, PBufferAttribute, int*)"/>
            public static unsafe int QueryPbufferEXT(IntPtr hPbuffer, PBufferAttribute iAttribute, int[] piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = QueryPbufferEXT(hPbuffer, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryPbufferEXT(IntPtr, PBufferAttribute, int*)"/>
            public static unsafe int QueryPbufferEXT(IntPtr hPbuffer, PBufferAttribute iAttribute, ref int piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = &piValue)
                {
                    returnValue = QueryPbufferEXT(hPbuffer, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class I3D
        {
            /// <inheritdoc cref="AssociateImageBufferEventsI3D(IntPtr, IntPtr*, IntPtr*, uint*, uint)"/>
            public static unsafe int AssociateImageBufferEventsI3D(IntPtr hDC, ReadOnlySpan<IntPtr> pEvent, ReadOnlySpan<IntPtr> pAddress, ReadOnlySpan<uint> pSize, uint count)
            {
                int returnValue;
                fixed (IntPtr* pEvent_ptr = pEvent)
                {
                    fixed (IntPtr* pAddress_ptr = pAddress)
                    {
                        fixed (uint* pSize_ptr = pSize)
                        {
                            returnValue = AssociateImageBufferEventsI3D(hDC, pEvent_ptr, pAddress_ptr, pSize_ptr, count);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="AssociateImageBufferEventsI3D(IntPtr, IntPtr*, IntPtr*, uint*, uint)"/>
            public static unsafe int AssociateImageBufferEventsI3D(IntPtr hDC, IntPtr[] pEvent, IntPtr[] pAddress, uint[] pSize, uint count)
            {
                int returnValue;
                fixed (IntPtr* pEvent_ptr = pEvent)
                {
                    fixed (IntPtr* pAddress_ptr = pAddress)
                    {
                        fixed (uint* pSize_ptr = pSize)
                        {
                            returnValue = AssociateImageBufferEventsI3D(hDC, pEvent_ptr, pAddress_ptr, pSize_ptr, count);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="AssociateImageBufferEventsI3D(IntPtr, IntPtr*, IntPtr*, uint*, uint)"/>
            public static unsafe int AssociateImageBufferEventsI3D(IntPtr hDC, in IntPtr pEvent, in IntPtr pAddress, in uint pSize, uint count)
            {
                int returnValue;
                fixed (IntPtr* pEvent_ptr = &pEvent)
                fixed (IntPtr* pAddress_ptr = &pAddress)
                fixed (uint* pSize_ptr = &pSize)
                {
                    returnValue = AssociateImageBufferEventsI3D(hDC, pEvent_ptr, pAddress_ptr, pSize_ptr, count);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDigitalVideoParametersI3D(IntPtr, DigitalVideoAttribute, int*)"/>
            public static unsafe int GetDigitalVideoParametersI3D(IntPtr hDC, DigitalVideoAttribute iAttribute, Span<int> piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = GetDigitalVideoParametersI3D(hDC, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDigitalVideoParametersI3D(IntPtr, DigitalVideoAttribute, int*)"/>
            public static unsafe int GetDigitalVideoParametersI3D(IntPtr hDC, DigitalVideoAttribute iAttribute, int[] piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = GetDigitalVideoParametersI3D(hDC, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetDigitalVideoParametersI3D(IntPtr, DigitalVideoAttribute, int*)"/>
            public static unsafe int GetDigitalVideoParametersI3D(IntPtr hDC, DigitalVideoAttribute iAttribute, ref int piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = &piValue)
                {
                    returnValue = GetDigitalVideoParametersI3D(hDC, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetFrameUsageI3D(float*)"/>
            public static unsafe int GetFrameUsageI3D(Span<float> pUsage)
            {
                int returnValue;
                fixed (float* pUsage_ptr = pUsage)
                {
                    returnValue = GetFrameUsageI3D(pUsage_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetFrameUsageI3D(float*)"/>
            public static unsafe int GetFrameUsageI3D(float[] pUsage)
            {
                int returnValue;
                fixed (float* pUsage_ptr = pUsage)
                {
                    returnValue = GetFrameUsageI3D(pUsage_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetFrameUsageI3D(float*)"/>
            public static unsafe int GetFrameUsageI3D(ref float pUsage)
            {
                int returnValue;
                fixed (float* pUsage_ptr = &pUsage)
                {
                    returnValue = GetFrameUsageI3D(pUsage_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGammaTableI3D(IntPtr, int, ushort*, ushort*, ushort*)"/>
            public static unsafe int GetGammaTableI3D(IntPtr hDC, int iEntries, Span<ushort> puRed, Span<ushort> puGreen, Span<ushort> puBlue)
            {
                int returnValue;
                fixed (ushort* puRed_ptr = puRed)
                {
                    fixed (ushort* puGreen_ptr = puGreen)
                    {
                        fixed (ushort* puBlue_ptr = puBlue)
                        {
                            returnValue = GetGammaTableI3D(hDC, iEntries, puRed_ptr, puGreen_ptr, puBlue_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGammaTableI3D(IntPtr, int, ushort*, ushort*, ushort*)"/>
            public static unsafe int GetGammaTableI3D(IntPtr hDC, int iEntries, ushort[] puRed, ushort[] puGreen, ushort[] puBlue)
            {
                int returnValue;
                fixed (ushort* puRed_ptr = puRed)
                {
                    fixed (ushort* puGreen_ptr = puGreen)
                    {
                        fixed (ushort* puBlue_ptr = puBlue)
                        {
                            returnValue = GetGammaTableI3D(hDC, iEntries, puRed_ptr, puGreen_ptr, puBlue_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGammaTableI3D(IntPtr, int, ushort*, ushort*, ushort*)"/>
            public static unsafe int GetGammaTableI3D(IntPtr hDC, int iEntries, ref ushort puRed, ref ushort puGreen, ref ushort puBlue)
            {
                int returnValue;
                fixed (ushort* puRed_ptr = &puRed)
                fixed (ushort* puGreen_ptr = &puGreen)
                fixed (ushort* puBlue_ptr = &puBlue)
                {
                    returnValue = GetGammaTableI3D(hDC, iEntries, puRed_ptr, puGreen_ptr, puBlue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGammaTableParametersI3D(IntPtr, GammaTableAttribute, int*)"/>
            public static unsafe int GetGammaTableParametersI3D(IntPtr hDC, GammaTableAttribute iAttribute, Span<int> piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = GetGammaTableParametersI3D(hDC, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGammaTableParametersI3D(IntPtr, GammaTableAttribute, int*)"/>
            public static unsafe int GetGammaTableParametersI3D(IntPtr hDC, GammaTableAttribute iAttribute, int[] piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = GetGammaTableParametersI3D(hDC, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGammaTableParametersI3D(IntPtr, GammaTableAttribute, int*)"/>
            public static unsafe int GetGammaTableParametersI3D(IntPtr hDC, GammaTableAttribute iAttribute, ref int piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = &piValue)
                {
                    returnValue = GetGammaTableParametersI3D(hDC, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGenlockSampleRateI3D(IntPtr, uint*)"/>
            public static unsafe int GetGenlockSampleRateI3D(IntPtr hDC, Span<uint> uRate)
            {
                int returnValue;
                fixed (uint* uRate_ptr = uRate)
                {
                    returnValue = GetGenlockSampleRateI3D(hDC, uRate_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGenlockSampleRateI3D(IntPtr, uint*)"/>
            public static unsafe int GetGenlockSampleRateI3D(IntPtr hDC, uint[] uRate)
            {
                int returnValue;
                fixed (uint* uRate_ptr = uRate)
                {
                    returnValue = GetGenlockSampleRateI3D(hDC, uRate_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGenlockSampleRateI3D(IntPtr, uint*)"/>
            public static unsafe int GetGenlockSampleRateI3D(IntPtr hDC, ref uint uRate)
            {
                int returnValue;
                fixed (uint* uRate_ptr = &uRate)
                {
                    returnValue = GetGenlockSampleRateI3D(hDC, uRate_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGenlockSourceDelayI3D(IntPtr, uint*)"/>
            public static unsafe int GetGenlockSourceDelayI3D(IntPtr hDC, Span<uint> uDelay)
            {
                int returnValue;
                fixed (uint* uDelay_ptr = uDelay)
                {
                    returnValue = GetGenlockSourceDelayI3D(hDC, uDelay_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGenlockSourceDelayI3D(IntPtr, uint*)"/>
            public static unsafe int GetGenlockSourceDelayI3D(IntPtr hDC, uint[] uDelay)
            {
                int returnValue;
                fixed (uint* uDelay_ptr = uDelay)
                {
                    returnValue = GetGenlockSourceDelayI3D(hDC, uDelay_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGenlockSourceDelayI3D(IntPtr, uint*)"/>
            public static unsafe int GetGenlockSourceDelayI3D(IntPtr hDC, ref uint uDelay)
            {
                int returnValue;
                fixed (uint* uDelay_ptr = &uDelay)
                {
                    returnValue = GetGenlockSourceDelayI3D(hDC, uDelay_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGenlockSourceEdgeI3D(IntPtr, uint*)"/>
            public static unsafe int GetGenlockSourceEdgeI3D(IntPtr hDC, Span<uint> uEdge)
            {
                int returnValue;
                fixed (uint* uEdge_ptr = uEdge)
                {
                    returnValue = GetGenlockSourceEdgeI3D(hDC, uEdge_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGenlockSourceEdgeI3D(IntPtr, uint*)"/>
            public static unsafe int GetGenlockSourceEdgeI3D(IntPtr hDC, uint[] uEdge)
            {
                int returnValue;
                fixed (uint* uEdge_ptr = uEdge)
                {
                    returnValue = GetGenlockSourceEdgeI3D(hDC, uEdge_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGenlockSourceEdgeI3D(IntPtr, uint*)"/>
            public static unsafe int GetGenlockSourceEdgeI3D(IntPtr hDC, ref uint uEdge)
            {
                int returnValue;
                fixed (uint* uEdge_ptr = &uEdge)
                {
                    returnValue = GetGenlockSourceEdgeI3D(hDC, uEdge_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGenlockSourceI3D(IntPtr, uint*)"/>
            public static unsafe int GetGenlockSourceI3D(IntPtr hDC, Span<uint> uSource)
            {
                int returnValue;
                fixed (uint* uSource_ptr = uSource)
                {
                    returnValue = GetGenlockSourceI3D(hDC, uSource_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGenlockSourceI3D(IntPtr, uint*)"/>
            public static unsafe int GetGenlockSourceI3D(IntPtr hDC, uint[] uSource)
            {
                int returnValue;
                fixed (uint* uSource_ptr = uSource)
                {
                    returnValue = GetGenlockSourceI3D(hDC, uSource_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGenlockSourceI3D(IntPtr, uint*)"/>
            public static unsafe int GetGenlockSourceI3D(IntPtr hDC, ref uint uSource)
            {
                int returnValue;
                fixed (uint* uSource_ptr = &uSource)
                {
                    returnValue = GetGenlockSourceI3D(hDC, uSource_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="IsEnabledFrameLockI3D(int*)"/>
            public static unsafe int IsEnabledFrameLockI3D(Span<int> pFlag)
            {
                int returnValue;
                fixed (int* pFlag_ptr = pFlag)
                {
                    returnValue = IsEnabledFrameLockI3D(pFlag_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="IsEnabledFrameLockI3D(int*)"/>
            public static unsafe int IsEnabledFrameLockI3D(int[] pFlag)
            {
                int returnValue;
                fixed (int* pFlag_ptr = pFlag)
                {
                    returnValue = IsEnabledFrameLockI3D(pFlag_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="IsEnabledFrameLockI3D(int*)"/>
            public static unsafe int IsEnabledFrameLockI3D(ref int pFlag)
            {
                int returnValue;
                fixed (int* pFlag_ptr = &pFlag)
                {
                    returnValue = IsEnabledFrameLockI3D(pFlag_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="IsEnabledGenlockI3D(IntPtr, int*)"/>
            public static unsafe int IsEnabledGenlockI3D(IntPtr hDC, Span<int> pFlag)
            {
                int returnValue;
                fixed (int* pFlag_ptr = pFlag)
                {
                    returnValue = IsEnabledGenlockI3D(hDC, pFlag_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="IsEnabledGenlockI3D(IntPtr, int*)"/>
            public static unsafe int IsEnabledGenlockI3D(IntPtr hDC, int[] pFlag)
            {
                int returnValue;
                fixed (int* pFlag_ptr = pFlag)
                {
                    returnValue = IsEnabledGenlockI3D(hDC, pFlag_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="IsEnabledGenlockI3D(IntPtr, int*)"/>
            public static unsafe int IsEnabledGenlockI3D(IntPtr hDC, ref int pFlag)
            {
                int returnValue;
                fixed (int* pFlag_ptr = &pFlag)
                {
                    returnValue = IsEnabledGenlockI3D(hDC, pFlag_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryFrameLockMasterI3D(int*)"/>
            public static unsafe int QueryFrameLockMasterI3D(Span<int> pFlag)
            {
                int returnValue;
                fixed (int* pFlag_ptr = pFlag)
                {
                    returnValue = QueryFrameLockMasterI3D(pFlag_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryFrameLockMasterI3D(int*)"/>
            public static unsafe int QueryFrameLockMasterI3D(int[] pFlag)
            {
                int returnValue;
                fixed (int* pFlag_ptr = pFlag)
                {
                    returnValue = QueryFrameLockMasterI3D(pFlag_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryFrameLockMasterI3D(int*)"/>
            public static unsafe int QueryFrameLockMasterI3D(ref int pFlag)
            {
                int returnValue;
                fixed (int* pFlag_ptr = &pFlag)
                {
                    returnValue = QueryFrameLockMasterI3D(pFlag_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryFrameTrackingI3D(uint*, uint*, float*)"/>
            public static unsafe int QueryFrameTrackingI3D(Span<uint> pFrameCount, Span<uint> pMissedFrames, Span<float> pLastMissedUsage)
            {
                int returnValue;
                fixed (uint* pFrameCount_ptr = pFrameCount)
                {
                    fixed (uint* pMissedFrames_ptr = pMissedFrames)
                    {
                        fixed (float* pLastMissedUsage_ptr = pLastMissedUsage)
                        {
                            returnValue = QueryFrameTrackingI3D(pFrameCount_ptr, pMissedFrames_ptr, pLastMissedUsage_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryFrameTrackingI3D(uint*, uint*, float*)"/>
            public static unsafe int QueryFrameTrackingI3D(uint[] pFrameCount, uint[] pMissedFrames, float[] pLastMissedUsage)
            {
                int returnValue;
                fixed (uint* pFrameCount_ptr = pFrameCount)
                {
                    fixed (uint* pMissedFrames_ptr = pMissedFrames)
                    {
                        fixed (float* pLastMissedUsage_ptr = pLastMissedUsage)
                        {
                            returnValue = QueryFrameTrackingI3D(pFrameCount_ptr, pMissedFrames_ptr, pLastMissedUsage_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryFrameTrackingI3D(uint*, uint*, float*)"/>
            public static unsafe int QueryFrameTrackingI3D(ref uint pFrameCount, ref uint pMissedFrames, ref float pLastMissedUsage)
            {
                int returnValue;
                fixed (uint* pFrameCount_ptr = &pFrameCount)
                fixed (uint* pMissedFrames_ptr = &pMissedFrames)
                fixed (float* pLastMissedUsage_ptr = &pLastMissedUsage)
                {
                    returnValue = QueryFrameTrackingI3D(pFrameCount_ptr, pMissedFrames_ptr, pLastMissedUsage_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryGenlockMaxSourceDelayI3D(IntPtr, uint*, uint*)"/>
            public static unsafe int QueryGenlockMaxSourceDelayI3D(IntPtr hDC, Span<uint> uMaxLineDelay, Span<uint> uMaxPixelDelay)
            {
                int returnValue;
                fixed (uint* uMaxLineDelay_ptr = uMaxLineDelay)
                {
                    fixed (uint* uMaxPixelDelay_ptr = uMaxPixelDelay)
                    {
                        returnValue = QueryGenlockMaxSourceDelayI3D(hDC, uMaxLineDelay_ptr, uMaxPixelDelay_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryGenlockMaxSourceDelayI3D(IntPtr, uint*, uint*)"/>
            public static unsafe int QueryGenlockMaxSourceDelayI3D(IntPtr hDC, uint[] uMaxLineDelay, uint[] uMaxPixelDelay)
            {
                int returnValue;
                fixed (uint* uMaxLineDelay_ptr = uMaxLineDelay)
                {
                    fixed (uint* uMaxPixelDelay_ptr = uMaxPixelDelay)
                    {
                        returnValue = QueryGenlockMaxSourceDelayI3D(hDC, uMaxLineDelay_ptr, uMaxPixelDelay_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryGenlockMaxSourceDelayI3D(IntPtr, uint*, uint*)"/>
            public static unsafe int QueryGenlockMaxSourceDelayI3D(IntPtr hDC, ref uint uMaxLineDelay, ref uint uMaxPixelDelay)
            {
                int returnValue;
                fixed (uint* uMaxLineDelay_ptr = &uMaxLineDelay)
                fixed (uint* uMaxPixelDelay_ptr = &uMaxPixelDelay)
                {
                    returnValue = QueryGenlockMaxSourceDelayI3D(hDC, uMaxLineDelay_ptr, uMaxPixelDelay_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReleaseImageBufferEventsI3D(IntPtr, IntPtr*, uint)"/>
            public static unsafe int ReleaseImageBufferEventsI3D(IntPtr hDC, ReadOnlySpan<IntPtr> pAddress)
            {
                int returnValue;
                uint count = (uint)(pAddress.Length);
                fixed (IntPtr* pAddress_ptr = pAddress)
                {
                    returnValue = ReleaseImageBufferEventsI3D(hDC, pAddress_ptr, count);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReleaseImageBufferEventsI3D(IntPtr, IntPtr*, uint)"/>
            public static unsafe int ReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr[] pAddress)
            {
                int returnValue;
                uint count = (uint)(pAddress.Length);
                fixed (IntPtr* pAddress_ptr = pAddress)
                {
                    returnValue = ReleaseImageBufferEventsI3D(hDC, pAddress_ptr, count);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReleaseImageBufferEventsI3D(IntPtr, IntPtr*, uint)"/>
            public static unsafe int ReleaseImageBufferEventsI3D(IntPtr hDC, in IntPtr pAddress, uint count)
            {
                int returnValue;
                fixed (IntPtr* pAddress_ptr = &pAddress)
                {
                    returnValue = ReleaseImageBufferEventsI3D(hDC, pAddress_ptr, count);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetDigitalVideoParametersI3D(IntPtr, DigitalVideoAttribute, int*)"/>
            public static unsafe int SetDigitalVideoParametersI3D(IntPtr hDC, DigitalVideoAttribute iAttribute, ReadOnlySpan<int> piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = SetDigitalVideoParametersI3D(hDC, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetDigitalVideoParametersI3D(IntPtr, DigitalVideoAttribute, int*)"/>
            public static unsafe int SetDigitalVideoParametersI3D(IntPtr hDC, DigitalVideoAttribute iAttribute, int[] piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = SetDigitalVideoParametersI3D(hDC, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetDigitalVideoParametersI3D(IntPtr, DigitalVideoAttribute, int*)"/>
            public static unsafe int SetDigitalVideoParametersI3D(IntPtr hDC, DigitalVideoAttribute iAttribute, in int piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = &piValue)
                {
                    returnValue = SetDigitalVideoParametersI3D(hDC, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetGammaTableI3D(IntPtr, int, ushort*, ushort*, ushort*)"/>
            public static unsafe int SetGammaTableI3D(IntPtr hDC, int iEntries, ReadOnlySpan<ushort> puRed, ReadOnlySpan<ushort> puGreen, ReadOnlySpan<ushort> puBlue)
            {
                int returnValue;
                fixed (ushort* puRed_ptr = puRed)
                {
                    fixed (ushort* puGreen_ptr = puGreen)
                    {
                        fixed (ushort* puBlue_ptr = puBlue)
                        {
                            returnValue = SetGammaTableI3D(hDC, iEntries, puRed_ptr, puGreen_ptr, puBlue_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetGammaTableI3D(IntPtr, int, ushort*, ushort*, ushort*)"/>
            public static unsafe int SetGammaTableI3D(IntPtr hDC, int iEntries, ushort[] puRed, ushort[] puGreen, ushort[] puBlue)
            {
                int returnValue;
                fixed (ushort* puRed_ptr = puRed)
                {
                    fixed (ushort* puGreen_ptr = puGreen)
                    {
                        fixed (ushort* puBlue_ptr = puBlue)
                        {
                            returnValue = SetGammaTableI3D(hDC, iEntries, puRed_ptr, puGreen_ptr, puBlue_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetGammaTableI3D(IntPtr, int, ushort*, ushort*, ushort*)"/>
            public static unsafe int SetGammaTableI3D(IntPtr hDC, int iEntries, in ushort puRed, in ushort puGreen, in ushort puBlue)
            {
                int returnValue;
                fixed (ushort* puRed_ptr = &puRed)
                fixed (ushort* puGreen_ptr = &puGreen)
                fixed (ushort* puBlue_ptr = &puBlue)
                {
                    returnValue = SetGammaTableI3D(hDC, iEntries, puRed_ptr, puGreen_ptr, puBlue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetGammaTableParametersI3D(IntPtr, GammaTableAttribute, int*)"/>
            public static unsafe int SetGammaTableParametersI3D(IntPtr hDC, GammaTableAttribute iAttribute, ReadOnlySpan<int> piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = SetGammaTableParametersI3D(hDC, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetGammaTableParametersI3D(IntPtr, GammaTableAttribute, int*)"/>
            public static unsafe int SetGammaTableParametersI3D(IntPtr hDC, GammaTableAttribute iAttribute, int[] piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = SetGammaTableParametersI3D(hDC, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SetGammaTableParametersI3D(IntPtr, GammaTableAttribute, int*)"/>
            public static unsafe int SetGammaTableParametersI3D(IntPtr hDC, GammaTableAttribute iAttribute, in int piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = &piValue)
                {
                    returnValue = SetGammaTableParametersI3D(hDC, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class NV
        {
            /// <inheritdoc cref="BindVideoDeviceNV(IntPtr, uint, IntPtr, int*)"/>
            public static unsafe int BindVideoDeviceNV(IntPtr hDc, uint uVideoSlot, IntPtr hVideoDevice, in int piAttribList)
            {
                int returnValue;
                fixed (int* piAttribList_ptr = &piAttribList)
                {
                    returnValue = BindVideoDeviceNV(hDc, uVideoSlot, hVideoDevice, piAttribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateAffinityDCNV(IntPtr*)"/>
            public static unsafe IntPtr CreateAffinityDCNV(in IntPtr phGpuList)
            {
                IntPtr returnValue;
                fixed (IntPtr* phGpuList_ptr = &phGpuList)
                {
                    returnValue = CreateAffinityDCNV(phGpuList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DXLockObjectsNV(IntPtr, int, IntPtr*)"/>
            public static unsafe int DXLockObjectsNV(IntPtr hDevice, Span<IntPtr> hObjects)
            {
                int returnValue;
                int count = (int)(hObjects.Length);
                fixed (IntPtr* hObjects_ptr = hObjects)
                {
                    returnValue = DXLockObjectsNV(hDevice, count, hObjects_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DXLockObjectsNV(IntPtr, int, IntPtr*)"/>
            public static unsafe int DXLockObjectsNV(IntPtr hDevice, IntPtr[] hObjects)
            {
                int returnValue;
                int count = (int)(hObjects.Length);
                fixed (IntPtr* hObjects_ptr = hObjects)
                {
                    returnValue = DXLockObjectsNV(hDevice, count, hObjects_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DXLockObjectsNV(IntPtr, int, IntPtr*)"/>
            public static unsafe int DXLockObjectsNV(IntPtr hDevice, int count, ref IntPtr hObjects)
            {
                int returnValue;
                fixed (IntPtr* hObjects_ptr = &hObjects)
                {
                    returnValue = DXLockObjectsNV(hDevice, count, hObjects_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DXOpenDeviceNV(void*)"/>
            public static unsafe IntPtr DXOpenDeviceNV(IntPtr dxDevice)
            {
                IntPtr returnValue;
                void* dxDevice_vptr = (void*)dxDevice;
                returnValue = DXOpenDeviceNV(dxDevice_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="DXOpenDeviceNV(void*)"/>
            public static unsafe IntPtr DXOpenDeviceNV<T1>(Span<T1> dxDevice)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (void* dxDevice_ptr = dxDevice)
                {
                    returnValue = DXOpenDeviceNV(dxDevice_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DXOpenDeviceNV(void*)"/>
            public static unsafe IntPtr DXOpenDeviceNV<T1>(T1[] dxDevice)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (void* dxDevice_ptr = dxDevice)
                {
                    returnValue = DXOpenDeviceNV(dxDevice_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DXOpenDeviceNV(void*)"/>
            public static unsafe IntPtr DXOpenDeviceNV<T1>(ref T1 dxDevice)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (void* dxDevice_ptr = &dxDevice)
                {
                    returnValue = DXOpenDeviceNV(dxDevice_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DXRegisterObjectNV(IntPtr, void*, uint, All, WGLDXInteropMaskNV)"/>
            public static unsafe IntPtr DXRegisterObjectNV(IntPtr hDevice, IntPtr dxObject, uint name, All type, WGLDXInteropMaskNV access)
            {
                IntPtr returnValue;
                void* dxObject_vptr = (void*)dxObject;
                returnValue = DXRegisterObjectNV(hDevice, dxObject_vptr, name, type, access);
                return returnValue;
            }
            /// <inheritdoc cref="DXRegisterObjectNV(IntPtr, void*, uint, All, WGLDXInteropMaskNV)"/>
            public static unsafe IntPtr DXRegisterObjectNV<T1>(IntPtr hDevice, Span<T1> dxObject, uint name, All type, WGLDXInteropMaskNV access)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (void* dxObject_ptr = dxObject)
                {
                    returnValue = DXRegisterObjectNV(hDevice, dxObject_ptr, name, type, access);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DXRegisterObjectNV(IntPtr, void*, uint, All, WGLDXInteropMaskNV)"/>
            public static unsafe IntPtr DXRegisterObjectNV<T1>(IntPtr hDevice, T1[] dxObject, uint name, All type, WGLDXInteropMaskNV access)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (void* dxObject_ptr = dxObject)
                {
                    returnValue = DXRegisterObjectNV(hDevice, dxObject_ptr, name, type, access);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DXRegisterObjectNV(IntPtr, void*, uint, All, WGLDXInteropMaskNV)"/>
            public static unsafe IntPtr DXRegisterObjectNV<T1>(IntPtr hDevice, ref T1 dxObject, uint name, All type, WGLDXInteropMaskNV access)
                where T1 : unmanaged
            {
                IntPtr returnValue;
                fixed (void* dxObject_ptr = &dxObject)
                {
                    returnValue = DXRegisterObjectNV(hDevice, dxObject_ptr, name, type, access);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DXSetResourceShareHandleNV(void*, IntPtr)"/>
            public static unsafe int DXSetResourceShareHandleNV(IntPtr dxObject, IntPtr shareHandle)
            {
                int returnValue;
                void* dxObject_vptr = (void*)dxObject;
                returnValue = DXSetResourceShareHandleNV(dxObject_vptr, shareHandle);
                return returnValue;
            }
            /// <inheritdoc cref="DXSetResourceShareHandleNV(void*, IntPtr)"/>
            public static unsafe int DXSetResourceShareHandleNV<T1>(Span<T1> dxObject, IntPtr shareHandle)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dxObject_ptr = dxObject)
                {
                    returnValue = DXSetResourceShareHandleNV(dxObject_ptr, shareHandle);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DXSetResourceShareHandleNV(void*, IntPtr)"/>
            public static unsafe int DXSetResourceShareHandleNV<T1>(T1[] dxObject, IntPtr shareHandle)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dxObject_ptr = dxObject)
                {
                    returnValue = DXSetResourceShareHandleNV(dxObject_ptr, shareHandle);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DXSetResourceShareHandleNV(void*, IntPtr)"/>
            public static unsafe int DXSetResourceShareHandleNV<T1>(ref T1 dxObject, IntPtr shareHandle)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dxObject_ptr = &dxObject)
                {
                    returnValue = DXSetResourceShareHandleNV(dxObject_ptr, shareHandle);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DXUnlockObjectsNV(IntPtr, int, IntPtr*)"/>
            public static unsafe int DXUnlockObjectsNV(IntPtr hDevice, Span<IntPtr> hObjects)
            {
                int returnValue;
                int count = (int)(hObjects.Length);
                fixed (IntPtr* hObjects_ptr = hObjects)
                {
                    returnValue = DXUnlockObjectsNV(hDevice, count, hObjects_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DXUnlockObjectsNV(IntPtr, int, IntPtr*)"/>
            public static unsafe int DXUnlockObjectsNV(IntPtr hDevice, IntPtr[] hObjects)
            {
                int returnValue;
                int count = (int)(hObjects.Length);
                fixed (IntPtr* hObjects_ptr = hObjects)
                {
                    returnValue = DXUnlockObjectsNV(hDevice, count, hObjects_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DXUnlockObjectsNV(IntPtr, int, IntPtr*)"/>
            public static unsafe int DXUnlockObjectsNV(IntPtr hDevice, int count, ref IntPtr hObjects)
            {
                int returnValue;
                fixed (IntPtr* hObjects_ptr = &hObjects)
                {
                    returnValue = DXUnlockObjectsNV(hDevice, count, hObjects_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoCaptureDevicesNV(IntPtr, IntPtr*)"/>
            public static unsafe uint EnumerateVideoCaptureDevicesNV(IntPtr hDc, ref IntPtr phDeviceList)
            {
                uint returnValue;
                fixed (IntPtr* phDeviceList_ptr = &phDeviceList)
                {
                    returnValue = EnumerateVideoCaptureDevicesNV(hDc, phDeviceList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoDevicesNV(IntPtr, IntPtr*)"/>
            public static unsafe int EnumerateVideoDevicesNV(IntPtr hDc, ref IntPtr phDeviceList)
            {
                int returnValue;
                fixed (IntPtr* phDeviceList_ptr = &phDeviceList)
                {
                    returnValue = EnumerateVideoDevicesNV(hDc, phDeviceList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumGpuDevicesNV(IntPtr, uint, _GPU_DEVICE*)"/>
            public static unsafe int EnumGpuDevicesNV(IntPtr hGpu, uint iDeviceIndex, ref _GPU_DEVICE lpGpuDevice)
            {
                int returnValue;
                fixed (_GPU_DEVICE* lpGpuDevice_ptr = &lpGpuDevice)
                {
                    returnValue = EnumGpuDevicesNV(hGpu, iDeviceIndex, lpGpuDevice_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumGpusFromAffinityDCNV(IntPtr, uint, IntPtr*)"/>
            public static unsafe int EnumGpusFromAffinityDCNV(IntPtr hAffinityDC, uint iGpuIndex, Span<IntPtr> hGpu)
            {
                int returnValue;
                fixed (IntPtr* hGpu_ptr = hGpu)
                {
                    returnValue = EnumGpusFromAffinityDCNV(hAffinityDC, iGpuIndex, hGpu_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumGpusFromAffinityDCNV(IntPtr, uint, IntPtr*)"/>
            public static unsafe int EnumGpusFromAffinityDCNV(IntPtr hAffinityDC, uint iGpuIndex, IntPtr[] hGpu)
            {
                int returnValue;
                fixed (IntPtr* hGpu_ptr = hGpu)
                {
                    returnValue = EnumGpusFromAffinityDCNV(hAffinityDC, iGpuIndex, hGpu_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumGpusFromAffinityDCNV(IntPtr, uint, IntPtr*)"/>
            public static unsafe int EnumGpusFromAffinityDCNV(IntPtr hAffinityDC, uint iGpuIndex, ref IntPtr hGpu)
            {
                int returnValue;
                fixed (IntPtr* hGpu_ptr = &hGpu)
                {
                    returnValue = EnumGpusFromAffinityDCNV(hAffinityDC, iGpuIndex, hGpu_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumGpusNV(uint, IntPtr*)"/>
            public static unsafe int EnumGpusNV(uint iGpuIndex, Span<IntPtr> phGpu)
            {
                int returnValue;
                fixed (IntPtr* phGpu_ptr = phGpu)
                {
                    returnValue = EnumGpusNV(iGpuIndex, phGpu_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumGpusNV(uint, IntPtr*)"/>
            public static unsafe int EnumGpusNV(uint iGpuIndex, IntPtr[] phGpu)
            {
                int returnValue;
                fixed (IntPtr* phGpu_ptr = phGpu)
                {
                    returnValue = EnumGpusNV(iGpuIndex, phGpu_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumGpusNV(uint, IntPtr*)"/>
            public static unsafe int EnumGpusNV(uint iGpuIndex, ref IntPtr phGpu)
            {
                int returnValue;
                fixed (IntPtr* phGpu_ptr = &phGpu)
                {
                    returnValue = EnumGpusNV(iGpuIndex, phGpu_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="FreeMemoryNV(void*)"/>
            public static unsafe void FreeMemoryNV(IntPtr pointer)
            {
                void* pointer_vptr = (void*)pointer;
                FreeMemoryNV(pointer_vptr);
            }
            /// <inheritdoc cref="FreeMemoryNV(void*)"/>
            public static unsafe void FreeMemoryNV<T1>(ref T1 pointer)
                where T1 : unmanaged
            {
                fixed (void* pointer_ptr = &pointer)
                {
                    FreeMemoryNV(pointer_ptr);
                }
            }
            /// <inheritdoc cref="GetVideoDeviceNV(IntPtr, int, IntPtr*)"/>
            public static unsafe int GetVideoDeviceNV(IntPtr hDC, Span<IntPtr> hVideoDevice)
            {
                int returnValue;
                int numDevices = (int)(hVideoDevice.Length);
                fixed (IntPtr* hVideoDevice_ptr = hVideoDevice)
                {
                    returnValue = GetVideoDeviceNV(hDC, numDevices, hVideoDevice_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoDeviceNV(IntPtr, int, IntPtr*)"/>
            public static unsafe int GetVideoDeviceNV(IntPtr hDC, IntPtr[] hVideoDevice)
            {
                int returnValue;
                int numDevices = (int)(hVideoDevice.Length);
                fixed (IntPtr* hVideoDevice_ptr = hVideoDevice)
                {
                    returnValue = GetVideoDeviceNV(hDC, numDevices, hVideoDevice_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoDeviceNV(IntPtr, int, IntPtr*)"/>
            public static unsafe int GetVideoDeviceNV(IntPtr hDC, int numDevices, ref IntPtr hVideoDevice)
            {
                int returnValue;
                fixed (IntPtr* hVideoDevice_ptr = &hVideoDevice)
                {
                    returnValue = GetVideoDeviceNV(hDC, numDevices, hVideoDevice_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoInfoNV(IntPtr, ulong*, ulong*)"/>
            public static unsafe int GetVideoInfoNV(IntPtr hpVideoDevice, Span<ulong> pulCounterOutputPbuffer, Span<ulong> pulCounterOutputVideo)
            {
                int returnValue;
                fixed (ulong* pulCounterOutputPbuffer_ptr = pulCounterOutputPbuffer)
                {
                    fixed (ulong* pulCounterOutputVideo_ptr = pulCounterOutputVideo)
                    {
                        returnValue = GetVideoInfoNV(hpVideoDevice, pulCounterOutputPbuffer_ptr, pulCounterOutputVideo_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoInfoNV(IntPtr, ulong*, ulong*)"/>
            public static unsafe int GetVideoInfoNV(IntPtr hpVideoDevice, ulong[] pulCounterOutputPbuffer, ulong[] pulCounterOutputVideo)
            {
                int returnValue;
                fixed (ulong* pulCounterOutputPbuffer_ptr = pulCounterOutputPbuffer)
                {
                    fixed (ulong* pulCounterOutputVideo_ptr = pulCounterOutputVideo)
                    {
                        returnValue = GetVideoInfoNV(hpVideoDevice, pulCounterOutputPbuffer_ptr, pulCounterOutputVideo_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoInfoNV(IntPtr, ulong*, ulong*)"/>
            public static unsafe int GetVideoInfoNV(IntPtr hpVideoDevice, ref ulong pulCounterOutputPbuffer, ref ulong pulCounterOutputVideo)
            {
                int returnValue;
                fixed (ulong* pulCounterOutputPbuffer_ptr = &pulCounterOutputPbuffer)
                fixed (ulong* pulCounterOutputVideo_ptr = &pulCounterOutputVideo)
                {
                    returnValue = GetVideoInfoNV(hpVideoDevice, pulCounterOutputPbuffer_ptr, pulCounterOutputVideo_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryCurrentContextNV(ContextAttribute, int*)"/>
            public static unsafe int QueryCurrentContextNV(ContextAttribute iAttribute, Span<int> piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = QueryCurrentContextNV(iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryCurrentContextNV(ContextAttribute, int*)"/>
            public static unsafe int QueryCurrentContextNV(ContextAttribute iAttribute, int[] piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = QueryCurrentContextNV(iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryCurrentContextNV(ContextAttribute, int*)"/>
            public static unsafe int QueryCurrentContextNV(ContextAttribute iAttribute, ref int piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = &piValue)
                {
                    returnValue = QueryCurrentContextNV(iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryFrameCountNV(IntPtr, uint*)"/>
            public static unsafe int QueryFrameCountNV(IntPtr hDC, Span<uint> count)
            {
                int returnValue;
                fixed (uint* count_ptr = count)
                {
                    returnValue = QueryFrameCountNV(hDC, count_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryFrameCountNV(IntPtr, uint*)"/>
            public static unsafe int QueryFrameCountNV(IntPtr hDC, uint[] count)
            {
                int returnValue;
                fixed (uint* count_ptr = count)
                {
                    returnValue = QueryFrameCountNV(hDC, count_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryFrameCountNV(IntPtr, uint*)"/>
            public static unsafe int QueryFrameCountNV(IntPtr hDC, ref uint count)
            {
                int returnValue;
                fixed (uint* count_ptr = &count)
                {
                    returnValue = QueryFrameCountNV(hDC, count_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapGroupsNV(IntPtr, uint*, uint*)"/>
            public static unsafe int QueryMaxSwapGroupsNV(IntPtr hDC, Span<uint> maxGroups, Span<uint> maxBarriers)
            {
                int returnValue;
                fixed (uint* maxGroups_ptr = maxGroups)
                {
                    fixed (uint* maxBarriers_ptr = maxBarriers)
                    {
                        returnValue = QueryMaxSwapGroupsNV(hDC, maxGroups_ptr, maxBarriers_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapGroupsNV(IntPtr, uint*, uint*)"/>
            public static unsafe int QueryMaxSwapGroupsNV(IntPtr hDC, uint[] maxGroups, uint[] maxBarriers)
            {
                int returnValue;
                fixed (uint* maxGroups_ptr = maxGroups)
                {
                    fixed (uint* maxBarriers_ptr = maxBarriers)
                    {
                        returnValue = QueryMaxSwapGroupsNV(hDC, maxGroups_ptr, maxBarriers_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapGroupsNV(IntPtr, uint*, uint*)"/>
            public static unsafe int QueryMaxSwapGroupsNV(IntPtr hDC, ref uint maxGroups, ref uint maxBarriers)
            {
                int returnValue;
                fixed (uint* maxGroups_ptr = &maxGroups)
                fixed (uint* maxBarriers_ptr = &maxBarriers)
                {
                    returnValue = QueryMaxSwapGroupsNV(hDC, maxGroups_ptr, maxBarriers_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QuerySwapGroupNV(IntPtr, uint*, uint*)"/>
            public static unsafe int QuerySwapGroupNV(IntPtr hDC, Span<uint> group, Span<uint> barrier)
            {
                int returnValue;
                fixed (uint* group_ptr = group)
                {
                    fixed (uint* barrier_ptr = barrier)
                    {
                        returnValue = QuerySwapGroupNV(hDC, group_ptr, barrier_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QuerySwapGroupNV(IntPtr, uint*, uint*)"/>
            public static unsafe int QuerySwapGroupNV(IntPtr hDC, uint[] group, uint[] barrier)
            {
                int returnValue;
                fixed (uint* group_ptr = group)
                {
                    fixed (uint* barrier_ptr = barrier)
                    {
                        returnValue = QuerySwapGroupNV(hDC, group_ptr, barrier_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QuerySwapGroupNV(IntPtr, uint*, uint*)"/>
            public static unsafe int QuerySwapGroupNV(IntPtr hDC, ref uint group, ref uint barrier)
            {
                int returnValue;
                fixed (uint* group_ptr = &group)
                fixed (uint* barrier_ptr = &barrier)
                {
                    returnValue = QuerySwapGroupNV(hDC, group_ptr, barrier_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryVideoCaptureDeviceNV(IntPtr, IntPtr, VideoCaptureDeviceAttribute, int*)"/>
            public static unsafe int QueryVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice, VideoCaptureDeviceAttribute iAttribute, Span<int> piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = QueryVideoCaptureDeviceNV(hDc, hDevice, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryVideoCaptureDeviceNV(IntPtr, IntPtr, VideoCaptureDeviceAttribute, int*)"/>
            public static unsafe int QueryVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice, VideoCaptureDeviceAttribute iAttribute, int[] piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = piValue)
                {
                    returnValue = QueryVideoCaptureDeviceNV(hDc, hDevice, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryVideoCaptureDeviceNV(IntPtr, IntPtr, VideoCaptureDeviceAttribute, int*)"/>
            public static unsafe int QueryVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice, VideoCaptureDeviceAttribute iAttribute, ref int piValue)
            {
                int returnValue;
                fixed (int* piValue_ptr = &piValue)
                {
                    returnValue = QueryVideoCaptureDeviceNV(hDc, hDevice, iAttribute, piValue_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SendPbufferToVideoNV(IntPtr, VideoOutputBufferType, ulong*, int)"/>
            public static unsafe int SendPbufferToVideoNV(IntPtr hPbuffer, VideoOutputBufferType iBufferType, Span<ulong> pulCounterPbuffer, int bBlock)
            {
                int returnValue;
                fixed (ulong* pulCounterPbuffer_ptr = pulCounterPbuffer)
                {
                    returnValue = SendPbufferToVideoNV(hPbuffer, iBufferType, pulCounterPbuffer_ptr, bBlock);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SendPbufferToVideoNV(IntPtr, VideoOutputBufferType, ulong*, int)"/>
            public static unsafe int SendPbufferToVideoNV(IntPtr hPbuffer, VideoOutputBufferType iBufferType, ulong[] pulCounterPbuffer, int bBlock)
            {
                int returnValue;
                fixed (ulong* pulCounterPbuffer_ptr = pulCounterPbuffer)
                {
                    returnValue = SendPbufferToVideoNV(hPbuffer, iBufferType, pulCounterPbuffer_ptr, bBlock);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SendPbufferToVideoNV(IntPtr, VideoOutputBufferType, ulong*, int)"/>
            public static unsafe int SendPbufferToVideoNV(IntPtr hPbuffer, VideoOutputBufferType iBufferType, ref ulong pulCounterPbuffer, int bBlock)
            {
                int returnValue;
                fixed (ulong* pulCounterPbuffer_ptr = &pulCounterPbuffer)
                {
                    returnValue = SendPbufferToVideoNV(hPbuffer, iBufferType, pulCounterPbuffer_ptr, bBlock);
                }
                return returnValue;
            }
        }
        public static unsafe partial class OML
        {
            /// <inheritdoc cref="GetMscRateOML(IntPtr, int*, int*)"/>
            public static unsafe int GetMscRateOML(IntPtr hdc, Span<int> numerator, Span<int> denominator)
            {
                int returnValue;
                fixed (int* numerator_ptr = numerator)
                {
                    fixed (int* denominator_ptr = denominator)
                    {
                        returnValue = GetMscRateOML(hdc, numerator_ptr, denominator_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMscRateOML(IntPtr, int*, int*)"/>
            public static unsafe int GetMscRateOML(IntPtr hdc, int[] numerator, int[] denominator)
            {
                int returnValue;
                fixed (int* numerator_ptr = numerator)
                {
                    fixed (int* denominator_ptr = denominator)
                    {
                        returnValue = GetMscRateOML(hdc, numerator_ptr, denominator_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMscRateOML(IntPtr, int*, int*)"/>
            public static unsafe int GetMscRateOML(IntPtr hdc, ref int numerator, ref int denominator)
            {
                int returnValue;
                fixed (int* numerator_ptr = &numerator)
                fixed (int* denominator_ptr = &denominator)
                {
                    returnValue = GetMscRateOML(hdc, numerator_ptr, denominator_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSyncValuesOML(IntPtr, long*, long*, long*)"/>
            public static unsafe int GetSyncValuesOML(IntPtr hdc, Span<long> ust, Span<long> msc, Span<long> sbc)
            {
                int returnValue;
                fixed (long* ust_ptr = ust)
                {
                    fixed (long* msc_ptr = msc)
                    {
                        fixed (long* sbc_ptr = sbc)
                        {
                            returnValue = GetSyncValuesOML(hdc, ust_ptr, msc_ptr, sbc_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSyncValuesOML(IntPtr, long*, long*, long*)"/>
            public static unsafe int GetSyncValuesOML(IntPtr hdc, long[] ust, long[] msc, long[] sbc)
            {
                int returnValue;
                fixed (long* ust_ptr = ust)
                {
                    fixed (long* msc_ptr = msc)
                    {
                        fixed (long* sbc_ptr = sbc)
                        {
                            returnValue = GetSyncValuesOML(hdc, ust_ptr, msc_ptr, sbc_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSyncValuesOML(IntPtr, long*, long*, long*)"/>
            public static unsafe int GetSyncValuesOML(IntPtr hdc, ref long ust, ref long msc, ref long sbc)
            {
                int returnValue;
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    returnValue = GetSyncValuesOML(hdc, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForMscOML(IntPtr, long, long, long, long*, long*, long*)"/>
            public static unsafe int WaitForMscOML(IntPtr hdc, long target_msc, long divisor, long remainder, Span<long> ust, Span<long> msc, Span<long> sbc)
            {
                int returnValue;
                fixed (long* ust_ptr = ust)
                {
                    fixed (long* msc_ptr = msc)
                    {
                        fixed (long* sbc_ptr = sbc)
                        {
                            returnValue = WaitForMscOML(hdc, target_msc, divisor, remainder, ust_ptr, msc_ptr, sbc_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForMscOML(IntPtr, long, long, long, long*, long*, long*)"/>
            public static unsafe int WaitForMscOML(IntPtr hdc, long target_msc, long divisor, long remainder, long[] ust, long[] msc, long[] sbc)
            {
                int returnValue;
                fixed (long* ust_ptr = ust)
                {
                    fixed (long* msc_ptr = msc)
                    {
                        fixed (long* sbc_ptr = sbc)
                        {
                            returnValue = WaitForMscOML(hdc, target_msc, divisor, remainder, ust_ptr, msc_ptr, sbc_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForMscOML(IntPtr, long, long, long, long*, long*, long*)"/>
            public static unsafe int WaitForMscOML(IntPtr hdc, long target_msc, long divisor, long remainder, ref long ust, ref long msc, ref long sbc)
            {
                int returnValue;
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    returnValue = WaitForMscOML(hdc, target_msc, divisor, remainder, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForSbcOML(IntPtr, long, long*, long*, long*)"/>
            public static unsafe int WaitForSbcOML(IntPtr hdc, long target_sbc, Span<long> ust, Span<long> msc, Span<long> sbc)
            {
                int returnValue;
                fixed (long* ust_ptr = ust)
                {
                    fixed (long* msc_ptr = msc)
                    {
                        fixed (long* sbc_ptr = sbc)
                        {
                            returnValue = WaitForSbcOML(hdc, target_sbc, ust_ptr, msc_ptr, sbc_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForSbcOML(IntPtr, long, long*, long*, long*)"/>
            public static unsafe int WaitForSbcOML(IntPtr hdc, long target_sbc, long[] ust, long[] msc, long[] sbc)
            {
                int returnValue;
                fixed (long* ust_ptr = ust)
                {
                    fixed (long* msc_ptr = msc)
                    {
                        fixed (long* sbc_ptr = sbc)
                        {
                            returnValue = WaitForSbcOML(hdc, target_sbc, ust_ptr, msc_ptr, sbc_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForSbcOML(IntPtr, long, long*, long*, long*)"/>
            public static unsafe int WaitForSbcOML(IntPtr hdc, long target_sbc, ref long ust, ref long msc, ref long sbc)
            {
                int returnValue;
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    returnValue = WaitForSbcOML(hdc, target_sbc, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
        }
    }
}

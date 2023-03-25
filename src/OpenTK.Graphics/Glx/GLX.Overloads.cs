// This file is auto generated, do not edit.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;
using OpenTK.Graphics;

namespace OpenTK.Graphics.Glx
{
    public static unsafe partial class GLX
    {
        /// <inheritdoc cref="ChooseFBConfig(void*, int, int*, int*)"/>
        public static unsafe void* ChooseFBConfig(IntPtr dpy, int screen, in int attrib_list, ref int nelements)
        {
            void* returnValue;
            fixed (int* attrib_list_ptr = &attrib_list)
            fixed (int* nelements_ptr = &nelements)
            {
                void* dpy_vptr = (void*)dpy;
                returnValue = ChooseFBConfig(dpy_vptr, screen, attrib_list_ptr, nelements_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="ChooseFBConfig(void*, int, int*, int*)"/>
        public static unsafe void* ChooseFBConfig<T1>(ref T1 dpy, int screen, in int attrib_list, ref int nelements)
            where T1 : unmanaged
        {
            void* returnValue;
            fixed (void* dpy_ptr = &dpy)
            fixed (int* attrib_list_ptr = &attrib_list)
            fixed (int* nelements_ptr = &nelements)
            {
                returnValue = ChooseFBConfig(dpy_ptr, screen, attrib_list_ptr, nelements_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="ChooseVisual(void*, int, int*)"/>
        public static unsafe void* ChooseVisual(IntPtr dpy, int screen, ref int attribList)
        {
            void* returnValue;
            fixed (int* attribList_ptr = &attribList)
            {
                void* dpy_vptr = (void*)dpy;
                returnValue = ChooseVisual(dpy_vptr, screen, attribList_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="ChooseVisual(void*, int, int*)"/>
        public static unsafe void* ChooseVisual<T1>(ref T1 dpy, int screen, ref int attribList)
            where T1 : unmanaged
        {
            void* returnValue;
            fixed (void* dpy_ptr = &dpy)
            fixed (int* attribList_ptr = &attribList)
            {
                returnValue = ChooseVisual(dpy_ptr, screen, attribList_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CopyContext(void*, void, void, ulong)"/>
        public static unsafe void CopyContext(IntPtr dpy, void src, void dst, ulong mask)
        {
            void* dpy_vptr = (void*)dpy;
            CopyContext(dpy_vptr, src, dst, mask);
        }
        /// <inheritdoc cref="CopyContext(void*, void, void, ulong)"/>
        public static unsafe void CopyContext<T1>(ref T1 dpy, void src, void dst, ulong mask)
            where T1 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            {
                CopyContext(dpy_ptr, src, dst, mask);
            }
        }
        /// <inheritdoc cref="CreateContext(void*, void*, void, bool)"/>
        public static unsafe void CreateContext(IntPtr dpy, IntPtr vis, void shareList, bool direct)
        {
            void* dpy_vptr = (void*)dpy;
            void* vis_vptr = (void*)vis;
            CreateContext(dpy_vptr, vis_vptr, shareList, direct);
        }
        /// <inheritdoc cref="CreateContext(void*, void*, void, bool)"/>
        public static unsafe void CreateContext<T1, T2>(ref T1 dpy, ref T2 vis, void shareList, bool direct)
            where T1 : unmanaged
            where T2 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            fixed (void* vis_ptr = &vis)
            {
                CreateContext(dpy_ptr, vis_ptr, shareList, direct);
            }
        }
        /// <inheritdoc cref="CreateGLXPixmap(void*, void*, void)"/>
        public static unsafe void CreateGLXPixmap(IntPtr dpy, IntPtr visual, void pixmap)
        {
            void* dpy_vptr = (void*)dpy;
            void* visual_vptr = (void*)visual;
            CreateGLXPixmap(dpy_vptr, visual_vptr, pixmap);
        }
        /// <inheritdoc cref="CreateGLXPixmap(void*, void*, void)"/>
        public static unsafe void CreateGLXPixmap<T1, T2>(ref T1 dpy, ref T2 visual, void pixmap)
            where T1 : unmanaged
            where T2 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            fixed (void* visual_ptr = &visual)
            {
                CreateGLXPixmap(dpy_ptr, visual_ptr, pixmap);
            }
        }
        /// <inheritdoc cref="CreateNewContext(void*, void, int, void, bool)"/>
        public static unsafe void CreateNewContext(IntPtr dpy, void config, int render_type, void share_list, bool direct)
        {
            void* dpy_vptr = (void*)dpy;
            CreateNewContext(dpy_vptr, config, render_type, share_list, direct);
        }
        /// <inheritdoc cref="CreateNewContext(void*, void, int, void, bool)"/>
        public static unsafe void CreateNewContext<T1>(ref T1 dpy, void config, int render_type, void share_list, bool direct)
            where T1 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            {
                CreateNewContext(dpy_ptr, config, render_type, share_list, direct);
            }
        }
        /// <inheritdoc cref="CreatePbuffer(void*, void, int*)"/>
        public static unsafe void CreatePbuffer(IntPtr dpy, void config, in int attrib_list)
        {
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                void* dpy_vptr = (void*)dpy;
                CreatePbuffer(dpy_vptr, config, attrib_list_ptr);
            }
        }
        /// <inheritdoc cref="CreatePbuffer(void*, void, int*)"/>
        public static unsafe void CreatePbuffer<T1>(ref T1 dpy, void config, in int attrib_list)
            where T1 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                CreatePbuffer(dpy_ptr, config, attrib_list_ptr);
            }
        }
        /// <inheritdoc cref="CreatePixmap(void*, void, void, int*)"/>
        public static unsafe void CreatePixmap(IntPtr dpy, void config, void pixmap, in int attrib_list)
        {
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                void* dpy_vptr = (void*)dpy;
                CreatePixmap(dpy_vptr, config, pixmap, attrib_list_ptr);
            }
        }
        /// <inheritdoc cref="CreatePixmap(void*, void, void, int*)"/>
        public static unsafe void CreatePixmap<T1>(ref T1 dpy, void config, void pixmap, in int attrib_list)
            where T1 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                CreatePixmap(dpy_ptr, config, pixmap, attrib_list_ptr);
            }
        }
        /// <inheritdoc cref="CreateWindow(void*, void, void, int*)"/>
        public static unsafe void CreateWindow(IntPtr dpy, void config, void win, in int attrib_list)
        {
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                void* dpy_vptr = (void*)dpy;
                CreateWindow(dpy_vptr, config, win, attrib_list_ptr);
            }
        }
        /// <inheritdoc cref="CreateWindow(void*, void, void, int*)"/>
        public static unsafe void CreateWindow<T1>(ref T1 dpy, void config, void win, in int attrib_list)
            where T1 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                CreateWindow(dpy_ptr, config, win, attrib_list_ptr);
            }
        }
        /// <inheritdoc cref="DestroyContext(void*, void)"/>
        public static unsafe void DestroyContext(IntPtr dpy, void ctx)
        {
            void* dpy_vptr = (void*)dpy;
            DestroyContext(dpy_vptr, ctx);
        }
        /// <inheritdoc cref="DestroyContext(void*, void)"/>
        public static unsafe void DestroyContext<T1>(ref T1 dpy, void ctx)
            where T1 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            {
                DestroyContext(dpy_ptr, ctx);
            }
        }
        /// <inheritdoc cref="DestroyGLXPixmap(void*, void)"/>
        public static unsafe void DestroyGLXPixmap(IntPtr dpy, void pixmap)
        {
            void* dpy_vptr = (void*)dpy;
            DestroyGLXPixmap(dpy_vptr, pixmap);
        }
        /// <inheritdoc cref="DestroyGLXPixmap(void*, void)"/>
        public static unsafe void DestroyGLXPixmap<T1>(ref T1 dpy, void pixmap)
            where T1 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            {
                DestroyGLXPixmap(dpy_ptr, pixmap);
            }
        }
        /// <inheritdoc cref="DestroyPbuffer(void*, void)"/>
        public static unsafe void DestroyPbuffer(IntPtr dpy, void pbuf)
        {
            void* dpy_vptr = (void*)dpy;
            DestroyPbuffer(dpy_vptr, pbuf);
        }
        /// <inheritdoc cref="DestroyPbuffer(void*, void)"/>
        public static unsafe void DestroyPbuffer<T1>(ref T1 dpy, void pbuf)
            where T1 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            {
                DestroyPbuffer(dpy_ptr, pbuf);
            }
        }
        /// <inheritdoc cref="DestroyPixmap(void*, void)"/>
        public static unsafe void DestroyPixmap(IntPtr dpy, void pixmap)
        {
            void* dpy_vptr = (void*)dpy;
            DestroyPixmap(dpy_vptr, pixmap);
        }
        /// <inheritdoc cref="DestroyPixmap(void*, void)"/>
        public static unsafe void DestroyPixmap<T1>(ref T1 dpy, void pixmap)
            where T1 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            {
                DestroyPixmap(dpy_ptr, pixmap);
            }
        }
        /// <inheritdoc cref="DestroyWindow(void*, void)"/>
        public static unsafe void DestroyWindow(IntPtr dpy, void win)
        {
            void* dpy_vptr = (void*)dpy;
            DestroyWindow(dpy_vptr, win);
        }
        /// <inheritdoc cref="DestroyWindow(void*, void)"/>
        public static unsafe void DestroyWindow<T1>(ref T1 dpy, void win)
            where T1 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            {
                DestroyWindow(dpy_ptr, win);
            }
        }
        /// <inheritdoc cref="GetClientString(void*, int)"/>
        public static unsafe string? GetClientString(IntPtr dpy, int name)
        {
            byte* returnValue;
            void* dpy_vptr = (void*)dpy;
            string? returnValue_str;
            returnValue = GetClientString(dpy_vptr, name);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <inheritdoc cref="GetClientString(void*, int)"/>
        public static unsafe string? GetClientString<T1>(ref T1 dpy, int name)
            where T1 : unmanaged
        {
            byte* returnValue;
            fixed (void* dpy_ptr = &dpy)
            {
                string? returnValue_str;
                returnValue = GetClientString(dpy_ptr, name);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            }
            return returnValue_str;
        }
        /// <inheritdoc cref="GetConfig(void*, void*, int, int*)"/>
        public static unsafe int GetConfig(IntPtr dpy, IntPtr visual, int attrib, ref int value)
        {
            int returnValue;
            fixed (int* value_ptr = &value)
            {
                void* dpy_vptr = (void*)dpy;
                void* visual_vptr = (void*)visual;
                returnValue = GetConfig(dpy_vptr, visual_vptr, attrib, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetConfig(void*, void*, int, int*)"/>
        public static unsafe int GetConfig<T1, T2>(ref T1 dpy, ref T2 visual, int attrib, ref int value)
            where T1 : unmanaged
            where T2 : unmanaged
        {
            int returnValue;
            fixed (void* dpy_ptr = &dpy)
            fixed (void* visual_ptr = &visual)
            fixed (int* value_ptr = &value)
            {
                returnValue = GetConfig(dpy_ptr, visual_ptr, attrib, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetFBConfigAttrib(void*, void, int, int*)"/>
        public static unsafe int GetFBConfigAttrib(IntPtr dpy, void config, int attribute, ref int value)
        {
            int returnValue;
            fixed (int* value_ptr = &value)
            {
                void* dpy_vptr = (void*)dpy;
                returnValue = GetFBConfigAttrib(dpy_vptr, config, attribute, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetFBConfigAttrib(void*, void, int, int*)"/>
        public static unsafe int GetFBConfigAttrib<T1>(ref T1 dpy, void config, int attribute, ref int value)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* dpy_ptr = &dpy)
            fixed (int* value_ptr = &value)
            {
                returnValue = GetFBConfigAttrib(dpy_ptr, config, attribute, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetFBConfigs(void*, int, int*)"/>
        public static unsafe void* GetFBConfig(IntPtr dpy, int screen, ref int nelements)
        {
            void* returnValue;
            fixed (int* nelements_ptr = &nelements)
            {
                void* dpy_vptr = (void*)dpy;
                returnValue = GetFBConfigs(dpy_vptr, screen, nelements_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetFBConfigs(void*, int, int*)"/>
        public static unsafe void* GetFBConfig<T1>(ref T1 dpy, int screen, ref int nelements)
            where T1 : unmanaged
        {
            void* returnValue;
            fixed (void* dpy_ptr = &dpy)
            fixed (int* nelements_ptr = &nelements)
            {
                returnValue = GetFBConfigs(dpy_ptr, screen, nelements_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProcAddress(byte*)"/>
        public static unsafe void GetProcAddress(in byte procName)
        {
            fixed (byte* procName_ptr = &procName)
            {
                GetProcAddress(procName_ptr);
            }
        }
        /// <inheritdoc cref="GetSelectedEvent(void*, void, ulong*)"/>
        public static unsafe void GetSelectedEvent(IntPtr dpy, void draw, ref ulong event_mask)
        {
            fixed (ulong* event_mask_ptr = &event_mask)
            {
                void* dpy_vptr = (void*)dpy;
                GetSelectedEvent(dpy_vptr, draw, event_mask_ptr);
            }
        }
        /// <inheritdoc cref="GetSelectedEvent(void*, void, ulong*)"/>
        public static unsafe void GetSelectedEvent<T1>(ref T1 dpy, void draw, ref ulong event_mask)
            where T1 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            fixed (ulong* event_mask_ptr = &event_mask)
            {
                GetSelectedEvent(dpy_ptr, draw, event_mask_ptr);
            }
        }
        /// <inheritdoc cref="GetVisualFromFBConfig(void*, void)"/>
        public static unsafe void* GetVisualFromFBConfig(IntPtr dpy, void config)
        {
            void* returnValue;
            void* dpy_vptr = (void*)dpy;
            returnValue = GetVisualFromFBConfig(dpy_vptr, config);
            return returnValue;
        }
        /// <inheritdoc cref="GetVisualFromFBConfig(void*, void)"/>
        public static unsafe void* GetVisualFromFBConfig<T1>(ref T1 dpy, void config)
            where T1 : unmanaged
        {
            void* returnValue;
            fixed (void* dpy_ptr = &dpy)
            {
                returnValue = GetVisualFromFBConfig(dpy_ptr, config);
            }
            return returnValue;
        }
        /// <inheritdoc cref="IsDirect(void*, void)"/>
        public static unsafe bool IsDirect(IntPtr dpy, void ctx)
        {
            bool returnValue;
            void* dpy_vptr = (void*)dpy;
            returnValue = IsDirect(dpy_vptr, ctx);
            return returnValue;
        }
        /// <inheritdoc cref="IsDirect(void*, void)"/>
        public static unsafe bool IsDirect<T1>(ref T1 dpy, void ctx)
            where T1 : unmanaged
        {
            bool returnValue;
            fixed (void* dpy_ptr = &dpy)
            {
                returnValue = IsDirect(dpy_ptr, ctx);
            }
            return returnValue;
        }
        /// <inheritdoc cref="MakeContextCurrent(void*, void, void, void)"/>
        public static unsafe bool MakeContextCurrent(IntPtr dpy, void draw, void read, void ctx)
        {
            bool returnValue;
            void* dpy_vptr = (void*)dpy;
            returnValue = MakeContextCurrent(dpy_vptr, draw, read, ctx);
            return returnValue;
        }
        /// <inheritdoc cref="MakeContextCurrent(void*, void, void, void)"/>
        public static unsafe bool MakeContextCurrent<T1>(ref T1 dpy, void draw, void read, void ctx)
            where T1 : unmanaged
        {
            bool returnValue;
            fixed (void* dpy_ptr = &dpy)
            {
                returnValue = MakeContextCurrent(dpy_ptr, draw, read, ctx);
            }
            return returnValue;
        }
        /// <inheritdoc cref="MakeCurrent(void*, void, void)"/>
        public static unsafe bool MakeCurrent(IntPtr dpy, void drawable, void ctx)
        {
            bool returnValue;
            void* dpy_vptr = (void*)dpy;
            returnValue = MakeCurrent(dpy_vptr, drawable, ctx);
            return returnValue;
        }
        /// <inheritdoc cref="MakeCurrent(void*, void, void)"/>
        public static unsafe bool MakeCurrent<T1>(ref T1 dpy, void drawable, void ctx)
            where T1 : unmanaged
        {
            bool returnValue;
            fixed (void* dpy_ptr = &dpy)
            {
                returnValue = MakeCurrent(dpy_ptr, drawable, ctx);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryContext(void*, void, int, int*)"/>
        public static unsafe int QueryContext(IntPtr dpy, void ctx, int attribute, ref int value)
        {
            int returnValue;
            fixed (int* value_ptr = &value)
            {
                void* dpy_vptr = (void*)dpy;
                returnValue = QueryContext(dpy_vptr, ctx, attribute, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryContext(void*, void, int, int*)"/>
        public static unsafe int QueryContext<T1>(ref T1 dpy, void ctx, int attribute, ref int value)
            where T1 : unmanaged
        {
            int returnValue;
            fixed (void* dpy_ptr = &dpy)
            fixed (int* value_ptr = &value)
            {
                returnValue = QueryContext(dpy_ptr, ctx, attribute, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryDrawable(void*, void, int, uint*)"/>
        public static unsafe void QueryDrawable(IntPtr dpy, void draw, int attribute, ref uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                void* dpy_vptr = (void*)dpy;
                QueryDrawable(dpy_vptr, draw, attribute, value_ptr);
            }
        }
        /// <inheritdoc cref="QueryDrawable(void*, void, int, uint*)"/>
        public static unsafe void QueryDrawable<T1>(ref T1 dpy, void draw, int attribute, ref uint value)
            where T1 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            fixed (uint* value_ptr = &value)
            {
                QueryDrawable(dpy_ptr, draw, attribute, value_ptr);
            }
        }
        /// <inheritdoc cref="QueryExtension(void*, int*, int*)"/>
        public static unsafe bool QueryExtension(IntPtr dpy, ref int errorb, ref int @event)
        {
            bool returnValue;
            fixed (int* errorb_ptr = &errorb)
            fixed (int* @event_ptr = &@event)
            {
                void* dpy_vptr = (void*)dpy;
                returnValue = QueryExtension(dpy_vptr, errorb_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryExtension(void*, int*, int*)"/>
        public static unsafe bool QueryExtension<T1>(ref T1 dpy, ref int errorb, ref int @event)
            where T1 : unmanaged
        {
            bool returnValue;
            fixed (void* dpy_ptr = &dpy)
            fixed (int* errorb_ptr = &errorb)
            fixed (int* @event_ptr = &@event)
            {
                returnValue = QueryExtension(dpy_ptr, errorb_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryExtensionsString(void*, int)"/>
        public static unsafe string? QueryExtensionsString(IntPtr dpy, int screen)
        {
            byte* returnValue;
            void* dpy_vptr = (void*)dpy;
            string? returnValue_str;
            returnValue = QueryExtensionsString(dpy_vptr, screen);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <inheritdoc cref="QueryExtensionsString(void*, int)"/>
        public static unsafe string? QueryExtensionsString<T1>(ref T1 dpy, int screen)
            where T1 : unmanaged
        {
            byte* returnValue;
            fixed (void* dpy_ptr = &dpy)
            {
                string? returnValue_str;
                returnValue = QueryExtensionsString(dpy_ptr, screen);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            }
            return returnValue_str;
        }
        /// <inheritdoc cref="QueryServerString(void*, int, int)"/>
        public static unsafe string? QueryServerString(IntPtr dpy, int screen, int name)
        {
            byte* returnValue;
            void* dpy_vptr = (void*)dpy;
            string? returnValue_str;
            returnValue = QueryServerString(dpy_vptr, screen, name);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <inheritdoc cref="QueryServerString(void*, int, int)"/>
        public static unsafe string? QueryServerString<T1>(ref T1 dpy, int screen, int name)
            where T1 : unmanaged
        {
            byte* returnValue;
            fixed (void* dpy_ptr = &dpy)
            {
                string? returnValue_str;
                returnValue = QueryServerString(dpy_ptr, screen, name);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            }
            return returnValue_str;
        }
        /// <inheritdoc cref="QueryVersion(void*, int*, int*)"/>
        public static unsafe bool QueryVersion(IntPtr dpy, ref int maj, ref int min)
        {
            bool returnValue;
            fixed (int* maj_ptr = &maj)
            fixed (int* min_ptr = &min)
            {
                void* dpy_vptr = (void*)dpy;
                returnValue = QueryVersion(dpy_vptr, maj_ptr, min_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryVersion(void*, int*, int*)"/>
        public static unsafe bool QueryVersion<T1>(ref T1 dpy, ref int maj, ref int min)
            where T1 : unmanaged
        {
            bool returnValue;
            fixed (void* dpy_ptr = &dpy)
            fixed (int* maj_ptr = &maj)
            fixed (int* min_ptr = &min)
            {
                returnValue = QueryVersion(dpy_ptr, maj_ptr, min_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SelectEvent(void*, void, ulong)"/>
        public static unsafe void SelectEvent(IntPtr dpy, void draw, ulong event_mask)
        {
            void* dpy_vptr = (void*)dpy;
            SelectEvent(dpy_vptr, draw, event_mask);
        }
        /// <inheritdoc cref="SelectEvent(void*, void, ulong)"/>
        public static unsafe void SelectEvent<T1>(ref T1 dpy, void draw, ulong event_mask)
            where T1 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            {
                SelectEvent(dpy_ptr, draw, event_mask);
            }
        }
        /// <inheritdoc cref="SwapBuffers(void*, void)"/>
        public static unsafe void SwapBuffers(IntPtr dpy, void drawable)
        {
            void* dpy_vptr = (void*)dpy;
            SwapBuffers(dpy_vptr, drawable);
        }
        /// <inheritdoc cref="SwapBuffers(void*, void)"/>
        public static unsafe void SwapBuffers<T1>(ref T1 dpy, void drawable)
            where T1 : unmanaged
        {
            fixed (void* dpy_ptr = &dpy)
            {
                SwapBuffers(dpy_ptr, drawable);
            }
        }
        public static unsafe partial class AMD
        {
            /// <inheritdoc cref="CreateAssociatedContextAttribsAMD(uint, void, int*)"/>
            public static unsafe void CreateAssociatedContextAttribsAMD(uint id, void share_context, in int attribList)
            {
                fixed (int* attribList_ptr = &attribList)
                {
                    CreateAssociatedContextAttribsAMD(id, share_context, attribList_ptr);
                }
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
            /// <inheritdoc cref="GetGPUInfoAMD(uint, int, All, uint, void*)"/>
            public static unsafe int GetGPUInfoAMD(uint id, int property, All dataType, uint size, IntPtr data)
            {
                int returnValue;
                void* data_vptr = (void*)data;
                returnValue = GetGPUInfoAMD(id, property, dataType, size, data_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="GetGPUInfoAMD(uint, int, All, uint, void*)"/>
            public static unsafe int GetGPUInfoAMD<T1>(uint id, int property, All dataType, uint size, ref T1 data)
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
            /// <inheritdoc cref="CreateContextAttribsARB(void*, void, void, bool, int*)"/>
            public static unsafe void CreateContextAttribsARB(IntPtr dpy, void config, void share_context, bool direct, in int attrib_list)
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    void* dpy_vptr = (void*)dpy;
                    CreateContextAttribsARB(dpy_vptr, config, share_context, direct, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="CreateContextAttribsARB(void*, void, void, bool, int*)"/>
            public static unsafe void CreateContextAttribsARB<T1>(ref T1 dpy, void config, void share_context, bool direct, in int attrib_list)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    CreateContextAttribsARB(dpy_ptr, config, share_context, direct, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="GetProcAddressARB(byte*)"/>
            public static unsafe void GetProcAddressARB(in byte procName)
            {
                fixed (byte* procName_ptr = &procName)
                {
                    GetProcAddressARB(procName_ptr);
                }
            }
        }
        public static unsafe partial class EXT
        {
            /// <inheritdoc cref="BindTexImageEXT(void*, void, int, int*)"/>
            public static unsafe void BindTexImageEXT(IntPtr dpy, void drawable, int buffer, in int attrib_list)
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    void* dpy_vptr = (void*)dpy;
                    BindTexImageEXT(dpy_vptr, drawable, buffer, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="BindTexImageEXT(void*, void, int, int*)"/>
            public static unsafe void BindTexImageEXT<T1>(ref T1 dpy, void drawable, int buffer, in int attrib_list)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    BindTexImageEXT(dpy_ptr, drawable, buffer, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="FreeContextEXT(void*, void)"/>
            public static unsafe void FreeContextEXT(IntPtr dpy, void context)
            {
                void* dpy_vptr = (void*)dpy;
                FreeContextEXT(dpy_vptr, context);
            }
            /// <inheritdoc cref="FreeContextEXT(void*, void)"/>
            public static unsafe void FreeContextEXT<T1>(ref T1 dpy, void context)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    FreeContextEXT(dpy_ptr, context);
                }
            }
            /// <inheritdoc cref="ImportContextEXT(void*, void)"/>
            public static unsafe void ImportContextEXT(IntPtr dpy, void contextID)
            {
                void* dpy_vptr = (void*)dpy;
                ImportContextEXT(dpy_vptr, contextID);
            }
            /// <inheritdoc cref="ImportContextEXT(void*, void)"/>
            public static unsafe void ImportContextEXT<T1>(ref T1 dpy, void contextID)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    ImportContextEXT(dpy_ptr, contextID);
                }
            }
            /// <inheritdoc cref="QueryContextInfoEXT(void*, void, int, int*)"/>
            public static unsafe int QueryContextInfoEXT(IntPtr dpy, void context, int attribute, ref int value)
            {
                int returnValue;
                fixed (int* value_ptr = &value)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = QueryContextInfoEXT(dpy_vptr, context, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryContextInfoEXT(void*, void, int, int*)"/>
            public static unsafe int QueryContextInfoEXT<T1>(ref T1 dpy, void context, int attribute, ref int value)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (int* value_ptr = &value)
                {
                    returnValue = QueryContextInfoEXT(dpy_ptr, context, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReleaseTexImageEXT(void*, void, int)"/>
            public static unsafe void ReleaseTexImageEXT(IntPtr dpy, void drawable, int buffer)
            {
                void* dpy_vptr = (void*)dpy;
                ReleaseTexImageEXT(dpy_vptr, drawable, buffer);
            }
            /// <inheritdoc cref="ReleaseTexImageEXT(void*, void, int)"/>
            public static unsafe void ReleaseTexImageEXT<T1>(ref T1 dpy, void drawable, int buffer)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    ReleaseTexImageEXT(dpy_ptr, drawable, buffer);
                }
            }
            /// <inheritdoc cref="SwapIntervalEXT(void*, void, int)"/>
            public static unsafe void SwapIntervalEXT(IntPtr dpy, void drawable, int interval)
            {
                void* dpy_vptr = (void*)dpy;
                SwapIntervalEXT(dpy_vptr, drawable, interval);
            }
            /// <inheritdoc cref="SwapIntervalEXT(void*, void, int)"/>
            public static unsafe void SwapIntervalEXT<T1>(ref T1 dpy, void drawable, int interval)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    SwapIntervalEXT(dpy_ptr, drawable, interval);
                }
            }
        }
        public static unsafe partial class MESA
        {
            /// <inheritdoc cref="CopySubBufferMESA(void*, void, int, int, int, int)"/>
            public static unsafe void CopySubBufferMESA(IntPtr dpy, void drawable, int x, int y, int width, int height)
            {
                void* dpy_vptr = (void*)dpy;
                CopySubBufferMESA(dpy_vptr, drawable, x, y, width, height);
            }
            /// <inheritdoc cref="CopySubBufferMESA(void*, void, int, int, int, int)"/>
            public static unsafe void CopySubBufferMESA<T1>(ref T1 dpy, void drawable, int x, int y, int width, int height)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    CopySubBufferMESA(dpy_ptr, drawable, x, y, width, height);
                }
            }
            /// <inheritdoc cref="CreateGLXPixmapMESA(void*, void*, void, GLXColormap)"/>
            public static unsafe void CreateGLXPixmapMESA(IntPtr dpy, IntPtr visual, void pixmap, GLXColormap cmap)
            {
                void* dpy_vptr = (void*)dpy;
                void* visual_vptr = (void*)visual;
                CreateGLXPixmapMESA(dpy_vptr, visual_vptr, pixmap, cmap);
            }
            /// <inheritdoc cref="CreateGLXPixmapMESA(void*, void*, void, GLXColormap)"/>
            public static unsafe void CreateGLXPixmapMESA<T1, T2>(ref T1 dpy, ref T2 visual, void pixmap, GLXColormap cmap)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                fixed (void* visual_ptr = &visual)
                {
                    CreateGLXPixmapMESA(dpy_ptr, visual_ptr, pixmap, cmap);
                }
            }
            /// <inheritdoc cref="GetAGPOffsetMESA(void*)"/>
            public static unsafe uint GetAGPOffsetMESA(IntPtr pointer)
            {
                uint returnValue;
                void* pointer_vptr = (void*)pointer;
                returnValue = GetAGPOffsetMESA(pointer_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="GetAGPOffsetMESA(void*)"/>
            public static unsafe uint GetAGPOffsetMESA<T1>(in T1 pointer)
                where T1 : unmanaged
            {
                uint returnValue;
                fixed (void* pointer_ptr = &pointer)
                {
                    returnValue = GetAGPOffsetMESA(pointer_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryCurrentRendererIntegerMESA(int, uint*)"/>
            public static unsafe bool QueryCurrentRendererIntegerMESA(int attribute, ref uint value)
            {
                bool returnValue;
                fixed (uint* value_ptr = &value)
                {
                    returnValue = QueryCurrentRendererIntegerMESA(attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryCurrentRendererStringMESA(int)"/>
            public static unsafe string? QueryCurrentRendererStringMESA(int attribute)
            {
                byte* returnValue;
                string? returnValue_str;
                returnValue = QueryCurrentRendererStringMESA_(attribute);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="QueryRendererIntegerMESA(void*, int, int, int, uint*)"/>
            public static unsafe bool QueryRendererIntegerMESA(IntPtr dpy, int screen, int renderer, int attribute, ref uint value)
            {
                bool returnValue;
                fixed (uint* value_ptr = &value)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = QueryRendererIntegerMESA(dpy_vptr, screen, renderer, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryRendererIntegerMESA(void*, int, int, int, uint*)"/>
            public static unsafe bool QueryRendererIntegerMESA<T1>(ref T1 dpy, int screen, int renderer, int attribute, ref uint value)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (uint* value_ptr = &value)
                {
                    returnValue = QueryRendererIntegerMESA(dpy_ptr, screen, renderer, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryRendererStringMESA(void*, int, int, int)"/>
            public static unsafe string? QueryRendererStringMESA(IntPtr dpy, int screen, int renderer, int attribute)
            {
                byte* returnValue;
                void* dpy_vptr = (void*)dpy;
                string? returnValue_str;
                returnValue = QueryRendererStringMESA(dpy_vptr, screen, renderer, attribute);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="QueryRendererStringMESA(void*, int, int, int)"/>
            public static unsafe string? QueryRendererStringMESA<T1>(ref T1 dpy, int screen, int renderer, int attribute)
                where T1 : unmanaged
            {
                byte* returnValue;
                fixed (void* dpy_ptr = &dpy)
                {
                    string? returnValue_str;
                    returnValue = QueryRendererStringMESA(dpy_ptr, screen, renderer, attribute);
                    returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                }
                return returnValue_str;
            }
            /// <inheritdoc cref="ReleaseBuffersMESA(void*, void)"/>
            public static unsafe bool ReleaseBuffersMESA(IntPtr dpy, void drawable)
            {
                bool returnValue;
                void* dpy_vptr = (void*)dpy;
                returnValue = ReleaseBuffersMESA(dpy_vptr, drawable);
                return returnValue;
            }
            /// <inheritdoc cref="ReleaseBuffersMESA(void*, void)"/>
            public static unsafe bool ReleaseBuffersMESA<T1>(ref T1 dpy, void drawable)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                {
                    returnValue = ReleaseBuffersMESA(dpy_ptr, drawable);
                }
                return returnValue;
            }
        }
        public static unsafe partial class NV
        {
            /// <inheritdoc cref="BindSwapBarrierNV(void*, uint, uint)"/>
            public static unsafe bool BindSwapBarrierNV(IntPtr dpy, uint group, uint barrier)
            {
                bool returnValue;
                void* dpy_vptr = (void*)dpy;
                returnValue = BindSwapBarrierNV(dpy_vptr, group, barrier);
                return returnValue;
            }
            /// <inheritdoc cref="BindSwapBarrierNV(void*, uint, uint)"/>
            public static unsafe bool BindSwapBarrierNV<T1>(ref T1 dpy, uint group, uint barrier)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                {
                    returnValue = BindSwapBarrierNV(dpy_ptr, group, barrier);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindVideoCaptureDeviceNV(void*, uint, void)"/>
            public static unsafe int BindVideoCaptureDeviceNV(IntPtr dpy, uint video_capture_slot, void device)
            {
                int returnValue;
                void* dpy_vptr = (void*)dpy;
                returnValue = BindVideoCaptureDeviceNV(dpy_vptr, video_capture_slot, device);
                return returnValue;
            }
            /// <inheritdoc cref="BindVideoCaptureDeviceNV(void*, uint, void)"/>
            public static unsafe int BindVideoCaptureDeviceNV<T1>(ref T1 dpy, uint video_capture_slot, void device)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                {
                    returnValue = BindVideoCaptureDeviceNV(dpy_ptr, video_capture_slot, device);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindVideoDeviceNV(void*, uint, uint, int*)"/>
            public static unsafe int BindVideoDeviceNV(IntPtr dpy, uint video_slot, uint video_device, in int attrib_list)
            {
                int returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = BindVideoDeviceNV(dpy_vptr, video_slot, video_device, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindVideoDeviceNV(void*, uint, uint, int*)"/>
            public static unsafe int BindVideoDeviceNV<T1>(ref T1 dpy, uint video_slot, uint video_device, in int attrib_list)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = BindVideoDeviceNV(dpy_ptr, video_slot, video_device, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindVideoImageNV(void*, void, void, int)"/>
            public static unsafe int BindVideoImageNV(IntPtr dpy, void VideoDevice, void pbuf, int iVideoBuffer)
            {
                int returnValue;
                void* dpy_vptr = (void*)dpy;
                returnValue = BindVideoImageNV(dpy_vptr, VideoDevice, pbuf, iVideoBuffer);
                return returnValue;
            }
            /// <inheritdoc cref="BindVideoImageNV(void*, void, void, int)"/>
            public static unsafe int BindVideoImageNV<T1>(ref T1 dpy, void VideoDevice, void pbuf, int iVideoBuffer)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                {
                    returnValue = BindVideoImageNV(dpy_ptr, VideoDevice, pbuf, iVideoBuffer);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CopyBufferSubDataNV(void*, void, void, All, All, IntPtr, IntPtr, nint)"/>
            public static unsafe void CopyBufferSubDataNV(IntPtr dpy, void readCtx, void writeCtx, All readTarget, All writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size)
            {
                void* dpy_vptr = (void*)dpy;
                CopyBufferSubDataNV(dpy_vptr, readCtx, writeCtx, readTarget, writeTarget, readOffset, writeOffset, size);
            }
            /// <inheritdoc cref="CopyBufferSubDataNV(void*, void, void, All, All, IntPtr, IntPtr, nint)"/>
            public static unsafe void CopyBufferSubDataNV<T1>(ref T1 dpy, void readCtx, void writeCtx, All readTarget, All writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    CopyBufferSubDataNV(dpy_ptr, readCtx, writeCtx, readTarget, writeTarget, readOffset, writeOffset, size);
                }
            }
            /// <inheritdoc cref="CopyImageSubDataNV(void*, void, uint, All, int, int, int, int, void, uint, All, int, int, int, int, int, int, int)"/>
            public static unsafe void CopyImageSubDataNV(IntPtr dpy, void srcCtx, uint srcName, All srcTarget, int srcLevel, int srcX, int srcY, int srcZ, void dstCtx, uint dstName, All dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
            {
                void* dpy_vptr = (void*)dpy;
                CopyImageSubDataNV(dpy_vptr, srcCtx, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstCtx, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
            }
            /// <inheritdoc cref="CopyImageSubDataNV(void*, void, uint, All, int, int, int, int, void, uint, All, int, int, int, int, int, int, int)"/>
            public static unsafe void CopyImageSubDataNV<T1>(ref T1 dpy, void srcCtx, uint srcName, All srcTarget, int srcLevel, int srcX, int srcY, int srcZ, void dstCtx, uint dstName, All dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    CopyImageSubDataNV(dpy_ptr, srcCtx, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstCtx, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
                }
            }
            /// <inheritdoc cref="DelayBeforeSwapNV(void*, void, float)"/>
            public static unsafe bool DelayBeforeSwapNV(IntPtr dpy, void drawable, float seconds)
            {
                bool returnValue;
                void* dpy_vptr = (void*)dpy;
                returnValue = DelayBeforeSwapNV(dpy_vptr, drawable, seconds);
                return returnValue;
            }
            /// <inheritdoc cref="DelayBeforeSwapNV(void*, void, float)"/>
            public static unsafe bool DelayBeforeSwapNV<T1>(ref T1 dpy, void drawable, float seconds)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                {
                    returnValue = DelayBeforeSwapNV(dpy_ptr, drawable, seconds);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoCaptureDevicesNV(void*, int, int*)"/>
            public static unsafe void* EnumerateVideoCaptureDevicesNV(IntPtr dpy, int screen, ref int nelements)
            {
                void* returnValue;
                fixed (int* nelements_ptr = &nelements)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = EnumerateVideoCaptureDevicesNV(dpy_vptr, screen, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoCaptureDevicesNV(void*, int, int*)"/>
            public static unsafe void* EnumerateVideoCaptureDevicesNV<T1>(ref T1 dpy, int screen, ref int nelements)
                where T1 : unmanaged
            {
                void* returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (int* nelements_ptr = &nelements)
                {
                    returnValue = EnumerateVideoCaptureDevicesNV(dpy_ptr, screen, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoDevicesNV(void*, int, int*)"/>
            public static unsafe uint* EnumerateVideoDevicesNV(IntPtr dpy, int screen, ref int nelements)
            {
                uint* returnValue;
                fixed (int* nelements_ptr = &nelements)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = EnumerateVideoDevicesNV(dpy_vptr, screen, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoDevicesNV(void*, int, int*)"/>
            public static unsafe uint* EnumerateVideoDevicesNV<T1>(ref T1 dpy, int screen, ref int nelements)
                where T1 : unmanaged
            {
                uint* returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (int* nelements_ptr = &nelements)
                {
                    returnValue = EnumerateVideoDevicesNV(dpy_ptr, screen, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoDeviceNV(void*, int, int, void*)"/>
            public static unsafe int GetVideoDeviceNV(IntPtr dpy, int screen, int numVideoDevices, IntPtr pVideoDevice)
            {
                int returnValue;
                void* dpy_vptr = (void*)dpy;
                void* pVideoDevice_vptr = (void*)pVideoDevice;
                returnValue = GetVideoDeviceNV(dpy_vptr, screen, numVideoDevices, pVideoDevice_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoDeviceNV(void*, int, int, void*)"/>
            public static unsafe int GetVideoDeviceNV<T1, T2>(ref T1 dpy, int screen, int numVideoDevices, ref T2 pVideoDevice)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (void* pVideoDevice_ptr = &pVideoDevice)
                {
                    returnValue = GetVideoDeviceNV(dpy_ptr, screen, numVideoDevices, pVideoDevice_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoInfoNV(void*, int, void, ulong*, ulong*)"/>
            public static unsafe int GetVideoInfoNV(IntPtr dpy, int screen, void VideoDevice, ref ulong pulCounterOutputPbuffer, ref ulong pulCounterOutputVideo)
            {
                int returnValue;
                fixed (ulong* pulCounterOutputPbuffer_ptr = &pulCounterOutputPbuffer)
                fixed (ulong* pulCounterOutputVideo_ptr = &pulCounterOutputVideo)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = GetVideoInfoNV(dpy_vptr, screen, VideoDevice, pulCounterOutputPbuffer_ptr, pulCounterOutputVideo_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoInfoNV(void*, int, void, ulong*, ulong*)"/>
            public static unsafe int GetVideoInfoNV<T1>(ref T1 dpy, int screen, void VideoDevice, ref ulong pulCounterOutputPbuffer, ref ulong pulCounterOutputVideo)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (ulong* pulCounterOutputPbuffer_ptr = &pulCounterOutputPbuffer)
                fixed (ulong* pulCounterOutputVideo_ptr = &pulCounterOutputVideo)
                {
                    returnValue = GetVideoInfoNV(dpy_ptr, screen, VideoDevice, pulCounterOutputPbuffer_ptr, pulCounterOutputVideo_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="JoinSwapGroupNV(void*, void, uint)"/>
            public static unsafe bool JoinSwapGroupNV(IntPtr dpy, void drawable, uint group)
            {
                bool returnValue;
                void* dpy_vptr = (void*)dpy;
                returnValue = JoinSwapGroupNV(dpy_vptr, drawable, group);
                return returnValue;
            }
            /// <inheritdoc cref="JoinSwapGroupNV(void*, void, uint)"/>
            public static unsafe bool JoinSwapGroupNV<T1>(ref T1 dpy, void drawable, uint group)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                {
                    returnValue = JoinSwapGroupNV(dpy_ptr, drawable, group);
                }
                return returnValue;
            }
            /// <inheritdoc cref="LockVideoCaptureDeviceNV(void*, void)"/>
            public static unsafe void LockVideoCaptureDeviceNV(IntPtr dpy, void device)
            {
                void* dpy_vptr = (void*)dpy;
                LockVideoCaptureDeviceNV(dpy_vptr, device);
            }
            /// <inheritdoc cref="LockVideoCaptureDeviceNV(void*, void)"/>
            public static unsafe void LockVideoCaptureDeviceNV<T1>(ref T1 dpy, void device)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    LockVideoCaptureDeviceNV(dpy_ptr, device);
                }
            }
            /// <inheritdoc cref="NamedCopyBufferSubDataNV(void*, void, void, uint, uint, IntPtr, IntPtr, nint)"/>
            public static unsafe void NamedCopyBufferSubDataNV(IntPtr dpy, void readCtx, void writeCtx, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size)
            {
                void* dpy_vptr = (void*)dpy;
                NamedCopyBufferSubDataNV(dpy_vptr, readCtx, writeCtx, readBuffer, writeBuffer, readOffset, writeOffset, size);
            }
            /// <inheritdoc cref="NamedCopyBufferSubDataNV(void*, void, void, uint, uint, IntPtr, IntPtr, nint)"/>
            public static unsafe void NamedCopyBufferSubDataNV<T1>(ref T1 dpy, void readCtx, void writeCtx, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    NamedCopyBufferSubDataNV(dpy_ptr, readCtx, writeCtx, readBuffer, writeBuffer, readOffset, writeOffset, size);
                }
            }
            /// <inheritdoc cref="QueryFrameCountNV(void*, int, uint*)"/>
            public static unsafe bool QueryFrameCountNV(IntPtr dpy, int screen, ref uint count)
            {
                bool returnValue;
                fixed (uint* count_ptr = &count)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = QueryFrameCountNV(dpy_vptr, screen, count_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryFrameCountNV(void*, int, uint*)"/>
            public static unsafe bool QueryFrameCountNV<T1>(ref T1 dpy, int screen, ref uint count)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (uint* count_ptr = &count)
                {
                    returnValue = QueryFrameCountNV(dpy_ptr, screen, count_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapGroupsNV(void*, int, uint*, uint*)"/>
            public static unsafe bool QueryMaxSwapGroupsNV(IntPtr dpy, int screen, ref uint maxGroups, ref uint maxBarriers)
            {
                bool returnValue;
                fixed (uint* maxGroups_ptr = &maxGroups)
                fixed (uint* maxBarriers_ptr = &maxBarriers)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = QueryMaxSwapGroupsNV(dpy_vptr, screen, maxGroups_ptr, maxBarriers_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapGroupsNV(void*, int, uint*, uint*)"/>
            public static unsafe bool QueryMaxSwapGroupsNV<T1>(ref T1 dpy, int screen, ref uint maxGroups, ref uint maxBarriers)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (uint* maxGroups_ptr = &maxGroups)
                fixed (uint* maxBarriers_ptr = &maxBarriers)
                {
                    returnValue = QueryMaxSwapGroupsNV(dpy_ptr, screen, maxGroups_ptr, maxBarriers_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QuerySwapGroupNV(void*, void, uint*, uint*)"/>
            public static unsafe bool QuerySwapGroupNV(IntPtr dpy, void drawable, ref uint group, ref uint barrier)
            {
                bool returnValue;
                fixed (uint* group_ptr = &group)
                fixed (uint* barrier_ptr = &barrier)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = QuerySwapGroupNV(dpy_vptr, drawable, group_ptr, barrier_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QuerySwapGroupNV(void*, void, uint*, uint*)"/>
            public static unsafe bool QuerySwapGroupNV<T1>(ref T1 dpy, void drawable, ref uint group, ref uint barrier)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (uint* group_ptr = &group)
                fixed (uint* barrier_ptr = &barrier)
                {
                    returnValue = QuerySwapGroupNV(dpy_ptr, drawable, group_ptr, barrier_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryVideoCaptureDeviceNV(void*, void, int, int*)"/>
            public static unsafe int QueryVideoCaptureDeviceNV(IntPtr dpy, void device, int attribute, ref int value)
            {
                int returnValue;
                fixed (int* value_ptr = &value)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = QueryVideoCaptureDeviceNV(dpy_vptr, device, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryVideoCaptureDeviceNV(void*, void, int, int*)"/>
            public static unsafe int QueryVideoCaptureDeviceNV<T1>(ref T1 dpy, void device, int attribute, ref int value)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (int* value_ptr = &value)
                {
                    returnValue = QueryVideoCaptureDeviceNV(dpy_ptr, device, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReleaseVideoCaptureDeviceNV(void*, void)"/>
            public static unsafe void ReleaseVideoCaptureDeviceNV(IntPtr dpy, void device)
            {
                void* dpy_vptr = (void*)dpy;
                ReleaseVideoCaptureDeviceNV(dpy_vptr, device);
            }
            /// <inheritdoc cref="ReleaseVideoCaptureDeviceNV(void*, void)"/>
            public static unsafe void ReleaseVideoCaptureDeviceNV<T1>(ref T1 dpy, void device)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    ReleaseVideoCaptureDeviceNV(dpy_ptr, device);
                }
            }
            /// <inheritdoc cref="ReleaseVideoDeviceNV(void*, int, void)"/>
            public static unsafe int ReleaseVideoDeviceNV(IntPtr dpy, int screen, void VideoDevice)
            {
                int returnValue;
                void* dpy_vptr = (void*)dpy;
                returnValue = ReleaseVideoDeviceNV(dpy_vptr, screen, VideoDevice);
                return returnValue;
            }
            /// <inheritdoc cref="ReleaseVideoDeviceNV(void*, int, void)"/>
            public static unsafe int ReleaseVideoDeviceNV<T1>(ref T1 dpy, int screen, void VideoDevice)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                {
                    returnValue = ReleaseVideoDeviceNV(dpy_ptr, screen, VideoDevice);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReleaseVideoImageNV(void*, void)"/>
            public static unsafe int ReleaseVideoImageNV(IntPtr dpy, void pbuf)
            {
                int returnValue;
                void* dpy_vptr = (void*)dpy;
                returnValue = ReleaseVideoImageNV(dpy_vptr, pbuf);
                return returnValue;
            }
            /// <inheritdoc cref="ReleaseVideoImageNV(void*, void)"/>
            public static unsafe int ReleaseVideoImageNV<T1>(ref T1 dpy, void pbuf)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                {
                    returnValue = ReleaseVideoImageNV(dpy_ptr, pbuf);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ResetFrameCountNV(void*, int)"/>
            public static unsafe bool ResetFrameCountNV(IntPtr dpy, int screen)
            {
                bool returnValue;
                void* dpy_vptr = (void*)dpy;
                returnValue = ResetFrameCountNV(dpy_vptr, screen);
                return returnValue;
            }
            /// <inheritdoc cref="ResetFrameCountNV(void*, int)"/>
            public static unsafe bool ResetFrameCountNV<T1>(ref T1 dpy, int screen)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                {
                    returnValue = ResetFrameCountNV(dpy_ptr, screen);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SendPbufferToVideoNV(void*, void, int, ulong*, bool)"/>
            public static unsafe int SendPbufferToVideoNV(IntPtr dpy, void pbuf, int iBufferType, ref ulong pulCounterPbuffer, bool bBlock)
            {
                int returnValue;
                fixed (ulong* pulCounterPbuffer_ptr = &pulCounterPbuffer)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = SendPbufferToVideoNV(dpy_vptr, pbuf, iBufferType, pulCounterPbuffer_ptr, bBlock);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SendPbufferToVideoNV(void*, void, int, ulong*, bool)"/>
            public static unsafe int SendPbufferToVideoNV<T1>(ref T1 dpy, void pbuf, int iBufferType, ref ulong pulCounterPbuffer, bool bBlock)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (ulong* pulCounterPbuffer_ptr = &pulCounterPbuffer)
                {
                    returnValue = SendPbufferToVideoNV(dpy_ptr, pbuf, iBufferType, pulCounterPbuffer_ptr, bBlock);
                }
                return returnValue;
            }
        }
        public static unsafe partial class OML
        {
            /// <inheritdoc cref="GetMscRateOML(void*, void, int*, int*)"/>
            public static unsafe bool GetMscRateOML(IntPtr dpy, void drawable, ref int numerator, ref int denominator)
            {
                bool returnValue;
                fixed (int* numerator_ptr = &numerator)
                fixed (int* denominator_ptr = &denominator)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = GetMscRateOML(dpy_vptr, drawable, numerator_ptr, denominator_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMscRateOML(void*, void, int*, int*)"/>
            public static unsafe bool GetMscRateOML<T1>(ref T1 dpy, void drawable, ref int numerator, ref int denominator)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (int* numerator_ptr = &numerator)
                fixed (int* denominator_ptr = &denominator)
                {
                    returnValue = GetMscRateOML(dpy_ptr, drawable, numerator_ptr, denominator_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSyncValuesOML(void*, void, long*, long*, long*)"/>
            public static unsafe bool GetSyncValuesOML(IntPtr dpy, void drawable, ref long ust, ref long msc, ref long sbc)
            {
                bool returnValue;
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = GetSyncValuesOML(dpy_vptr, drawable, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSyncValuesOML(void*, void, long*, long*, long*)"/>
            public static unsafe bool GetSyncValuesOML<T1>(ref T1 dpy, void drawable, ref long ust, ref long msc, ref long sbc)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    returnValue = GetSyncValuesOML(dpy_ptr, drawable, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SwapBuffersMscOML(void*, void, long, long, long)"/>
            public static unsafe long SwapBuffersMscOML(IntPtr dpy, void drawable, long target_msc, long divisor, long remainder)
            {
                long returnValue;
                void* dpy_vptr = (void*)dpy;
                returnValue = SwapBuffersMscOML(dpy_vptr, drawable, target_msc, divisor, remainder);
                return returnValue;
            }
            /// <inheritdoc cref="SwapBuffersMscOML(void*, void, long, long, long)"/>
            public static unsafe long SwapBuffersMscOML<T1>(ref T1 dpy, void drawable, long target_msc, long divisor, long remainder)
                where T1 : unmanaged
            {
                long returnValue;
                fixed (void* dpy_ptr = &dpy)
                {
                    returnValue = SwapBuffersMscOML(dpy_ptr, drawable, target_msc, divisor, remainder);
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForMscOML(void*, void, long, long, long, long*, long*, long*)"/>
            public static unsafe bool WaitForMscOML(IntPtr dpy, void drawable, long target_msc, long divisor, long remainder, ref long ust, ref long msc, ref long sbc)
            {
                bool returnValue;
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = WaitForMscOML(dpy_vptr, drawable, target_msc, divisor, remainder, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForMscOML(void*, void, long, long, long, long*, long*, long*)"/>
            public static unsafe bool WaitForMscOML<T1>(ref T1 dpy, void drawable, long target_msc, long divisor, long remainder, ref long ust, ref long msc, ref long sbc)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    returnValue = WaitForMscOML(dpy_ptr, drawable, target_msc, divisor, remainder, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForSbcOML(void*, void, long, long*, long*, long*)"/>
            public static unsafe bool WaitForSbcOML(IntPtr dpy, void drawable, long target_sbc, ref long ust, ref long msc, ref long sbc)
            {
                bool returnValue;
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = WaitForSbcOML(dpy_vptr, drawable, target_sbc, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForSbcOML(void*, void, long, long*, long*, long*)"/>
            public static unsafe bool WaitForSbcOML<T1>(ref T1 dpy, void drawable, long target_sbc, ref long ust, ref long msc, ref long sbc)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    returnValue = WaitForSbcOML(dpy_ptr, drawable, target_sbc, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class SGI
        {
            /// <inheritdoc cref="CushionSGI(void*, void, float)"/>
            public static unsafe void CushionSGI(IntPtr dpy, void window, float cushion)
            {
                void* dpy_vptr = (void*)dpy;
                CushionSGI(dpy_vptr, window, cushion);
            }
            /// <inheritdoc cref="CushionSGI(void*, void, float)"/>
            public static unsafe void CushionSGI<T1>(ref T1 dpy, void window, float cushion)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    CushionSGI(dpy_ptr, window, cushion);
                }
            }
            /// <inheritdoc cref="GetVideoSyncSGI(uint*)"/>
            public static unsafe int GetVideoSyncSGI(ref uint count)
            {
                int returnValue;
                fixed (uint* count_ptr = &count)
                {
                    returnValue = GetVideoSyncSGI(count_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="MakeCurrentReadSGI(void*, void, void, void)"/>
            public static unsafe bool MakeCurrentReadSGI(IntPtr dpy, void draw, void read, void ctx)
            {
                bool returnValue;
                void* dpy_vptr = (void*)dpy;
                returnValue = MakeCurrentReadSGI(dpy_vptr, draw, read, ctx);
                return returnValue;
            }
            /// <inheritdoc cref="MakeCurrentReadSGI(void*, void, void, void)"/>
            public static unsafe bool MakeCurrentReadSGI<T1>(ref T1 dpy, void draw, void read, void ctx)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                {
                    returnValue = MakeCurrentReadSGI(dpy_ptr, draw, read, ctx);
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitVideoSyncSGI(int, int, uint*)"/>
            public static unsafe int WaitVideoSyncSGI(int divisor, int remainder, ref uint count)
            {
                int returnValue;
                fixed (uint* count_ptr = &count)
                {
                    returnValue = WaitVideoSyncSGI(divisor, remainder, count_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class SGIX
        {
            /// <inheritdoc cref="AssociateDMPbufferSGIX(void*, void, void*, void)"/>
            public static unsafe bool AssociateDMPbufferSGIX(IntPtr dpy, void pbuffer, IntPtr parameters, void dmbuffer)
            {
                bool returnValue;
                void* dpy_vptr = (void*)dpy;
                void* parameters_vptr = (void*)parameters;
                returnValue = AssociateDMPbufferSGIX(dpy_vptr, pbuffer, parameters_vptr, dmbuffer);
                return returnValue;
            }
            /// <inheritdoc cref="AssociateDMPbufferSGIX(void*, void, void*, void)"/>
            public static unsafe bool AssociateDMPbufferSGIX<T1, T2>(ref T1 dpy, void pbuffer, ref T2 parameters, void dmbuffer)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (void* parameters_ptr = &parameters)
                {
                    returnValue = AssociateDMPbufferSGIX(dpy_ptr, pbuffer, parameters_ptr, dmbuffer);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindChannelToWindowSGIX(void*, int, int, void)"/>
            public static unsafe int BindChannelToWindowSGIX(IntPtr display, int screen, int channel, void window)
            {
                int returnValue;
                void* display_vptr = (void*)display;
                returnValue = BindChannelToWindowSGIX(display_vptr, screen, channel, window);
                return returnValue;
            }
            /// <inheritdoc cref="BindChannelToWindowSGIX(void*, int, int, void)"/>
            public static unsafe int BindChannelToWindowSGIX<T1>(ref T1 display, int screen, int channel, void window)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* display_ptr = &display)
                {
                    returnValue = BindChannelToWindowSGIX(display_ptr, screen, channel, window);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindHyperpipeSGIX(void*, int)"/>
            public static unsafe int BindHyperpipeSGIX(IntPtr dpy, int hpId)
            {
                int returnValue;
                void* dpy_vptr = (void*)dpy;
                returnValue = BindHyperpipeSGIX(dpy_vptr, hpId);
                return returnValue;
            }
            /// <inheritdoc cref="BindHyperpipeSGIX(void*, int)"/>
            public static unsafe int BindHyperpipeSGIX<T1>(ref T1 dpy, int hpId)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                {
                    returnValue = BindHyperpipeSGIX(dpy_ptr, hpId);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindSwapBarrierSGIX(void*, void, int)"/>
            public static unsafe void BindSwapBarrierSGIX(IntPtr dpy, void drawable, int barrier)
            {
                void* dpy_vptr = (void*)dpy;
                BindSwapBarrierSGIX(dpy_vptr, drawable, barrier);
            }
            /// <inheritdoc cref="BindSwapBarrierSGIX(void*, void, int)"/>
            public static unsafe void BindSwapBarrierSGIX<T1>(ref T1 dpy, void drawable, int barrier)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    BindSwapBarrierSGIX(dpy_ptr, drawable, barrier);
                }
            }
            /// <inheritdoc cref="ChannelRectSGIX(void*, int, int, int, int, int, int)"/>
            public static unsafe int ChannelRectSGIX(IntPtr display, int screen, int channel, int x, int y, int w, int h)
            {
                int returnValue;
                void* display_vptr = (void*)display;
                returnValue = ChannelRectSGIX(display_vptr, screen, channel, x, y, w, h);
                return returnValue;
            }
            /// <inheritdoc cref="ChannelRectSGIX(void*, int, int, int, int, int, int)"/>
            public static unsafe int ChannelRectSGIX<T1>(ref T1 display, int screen, int channel, int x, int y, int w, int h)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* display_ptr = &display)
                {
                    returnValue = ChannelRectSGIX(display_ptr, screen, channel, x, y, w, h);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ChannelRectSyncSGIX(void*, int, int, All)"/>
            public static unsafe int ChannelRectSyncSGIX(IntPtr display, int screen, int channel, All synctype)
            {
                int returnValue;
                void* display_vptr = (void*)display;
                returnValue = ChannelRectSyncSGIX(display_vptr, screen, channel, synctype);
                return returnValue;
            }
            /// <inheritdoc cref="ChannelRectSyncSGIX(void*, int, int, All)"/>
            public static unsafe int ChannelRectSyncSGIX<T1>(ref T1 display, int screen, int channel, All synctype)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* display_ptr = &display)
                {
                    returnValue = ChannelRectSyncSGIX(display_ptr, screen, channel, synctype);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ChooseFBConfigSGIX(void*, int, int*, int*)"/>
            public static unsafe void* ChooseFBConfigSGIX(IntPtr dpy, int screen, ref int attrib_list, ref int nelements)
            {
                void* returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                fixed (int* nelements_ptr = &nelements)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = ChooseFBConfigSGIX(dpy_vptr, screen, attrib_list_ptr, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ChooseFBConfigSGIX(void*, int, int*, int*)"/>
            public static unsafe void* ChooseFBConfigSGIX<T1>(ref T1 dpy, int screen, ref int attrib_list, ref int nelements)
                where T1 : unmanaged
            {
                void* returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (int* attrib_list_ptr = &attrib_list)
                fixed (int* nelements_ptr = &nelements)
                {
                    returnValue = ChooseFBConfigSGIX(dpy_ptr, screen, attrib_list_ptr, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateContextWithConfigSGIX(void*, void, int, void, bool)"/>
            public static unsafe void CreateContextWithConfigSGIX(IntPtr dpy, void config, int render_type, void share_list, bool direct)
            {
                void* dpy_vptr = (void*)dpy;
                CreateContextWithConfigSGIX(dpy_vptr, config, render_type, share_list, direct);
            }
            /// <inheritdoc cref="CreateContextWithConfigSGIX(void*, void, int, void, bool)"/>
            public static unsafe void CreateContextWithConfigSGIX<T1>(ref T1 dpy, void config, int render_type, void share_list, bool direct)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    CreateContextWithConfigSGIX(dpy_ptr, config, render_type, share_list, direct);
                }
            }
            /// <inheritdoc cref="CreateGLXPbufferSGIX(void*, void, uint, uint, int*)"/>
            public static unsafe void CreateGLXPbufferSGIX(IntPtr dpy, void config, uint width, uint height, ref int attrib_list)
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    void* dpy_vptr = (void*)dpy;
                    CreateGLXPbufferSGIX(dpy_vptr, config, width, height, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="CreateGLXPbufferSGIX(void*, void, uint, uint, int*)"/>
            public static unsafe void CreateGLXPbufferSGIX<T1>(ref T1 dpy, void config, uint width, uint height, ref int attrib_list)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    CreateGLXPbufferSGIX(dpy_ptr, config, width, height, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="CreateGLXPixmapWithConfigSGIX(void*, void, void)"/>
            public static unsafe void CreateGLXPixmapWithConfigSGIX(IntPtr dpy, void config, void pixmap)
            {
                void* dpy_vptr = (void*)dpy;
                CreateGLXPixmapWithConfigSGIX(dpy_vptr, config, pixmap);
            }
            /// <inheritdoc cref="CreateGLXPixmapWithConfigSGIX(void*, void, void)"/>
            public static unsafe void CreateGLXPixmapWithConfigSGIX<T1>(ref T1 dpy, void config, void pixmap)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    CreateGLXPixmapWithConfigSGIX(dpy_ptr, config, pixmap);
                }
            }
            /// <inheritdoc cref="CreateGLXVideoSourceSGIX(void*, int, void, void, int, void)"/>
            public static unsafe void CreateGLXVideoSourceSGIX(IntPtr display, int screen, void server, void path, int nodeClass, void drainNode)
            {
                void* display_vptr = (void*)display;
                CreateGLXVideoSourceSGIX(display_vptr, screen, server, path, nodeClass, drainNode);
            }
            /// <inheritdoc cref="CreateGLXVideoSourceSGIX(void*, int, void, void, int, void)"/>
            public static unsafe void CreateGLXVideoSourceSGIX<T1>(ref T1 display, int screen, void server, void path, int nodeClass, void drainNode)
                where T1 : unmanaged
            {
                fixed (void* display_ptr = &display)
                {
                    CreateGLXVideoSourceSGIX(display_ptr, screen, server, path, nodeClass, drainNode);
                }
            }
            /// <inheritdoc cref="DestroyGLXPbufferSGIX(void*, void)"/>
            public static unsafe void DestroyGLXPbufferSGIX(IntPtr dpy, void pbuf)
            {
                void* dpy_vptr = (void*)dpy;
                DestroyGLXPbufferSGIX(dpy_vptr, pbuf);
            }
            /// <inheritdoc cref="DestroyGLXPbufferSGIX(void*, void)"/>
            public static unsafe void DestroyGLXPbufferSGIX<T1>(ref T1 dpy, void pbuf)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    DestroyGLXPbufferSGIX(dpy_ptr, pbuf);
                }
            }
            /// <inheritdoc cref="DestroyGLXVideoSourceSGIX(void*, void)"/>
            public static unsafe void DestroyGLXVideoSourceSGIX(IntPtr dpy, void glxvideosource)
            {
                void* dpy_vptr = (void*)dpy;
                DestroyGLXVideoSourceSGIX(dpy_vptr, glxvideosource);
            }
            /// <inheritdoc cref="DestroyGLXVideoSourceSGIX(void*, void)"/>
            public static unsafe void DestroyGLXVideoSourceSGIX<T1>(ref T1 dpy, void glxvideosource)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    DestroyGLXVideoSourceSGIX(dpy_ptr, glxvideosource);
                }
            }
            /// <inheritdoc cref="DestroyHyperpipeConfigSGIX(void*, int)"/>
            public static unsafe int DestroyHyperpipeConfigSGIX(IntPtr dpy, int hpId)
            {
                int returnValue;
                void* dpy_vptr = (void*)dpy;
                returnValue = DestroyHyperpipeConfigSGIX(dpy_vptr, hpId);
                return returnValue;
            }
            /// <inheritdoc cref="DestroyHyperpipeConfigSGIX(void*, int)"/>
            public static unsafe int DestroyHyperpipeConfigSGIX<T1>(ref T1 dpy, int hpId)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                {
                    returnValue = DestroyHyperpipeConfigSGIX(dpy_ptr, hpId);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetFBConfigAttribSGIX(void*, void, int, int*)"/>
            public static unsafe int GetFBConfigAttribSGIX(IntPtr dpy, void config, int attribute, ref int value)
            {
                int returnValue;
                fixed (int* value_ptr = &value)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = GetFBConfigAttribSGIX(dpy_vptr, config, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetFBConfigAttribSGIX(void*, void, int, int*)"/>
            public static unsafe int GetFBConfigAttribSGIX<T1>(ref T1 dpy, void config, int attribute, ref int value)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (int* value_ptr = &value)
                {
                    returnValue = GetFBConfigAttribSGIX(dpy_ptr, config, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetFBConfigFromVisualSGIX(void*, void*)"/>
            public static unsafe void GetFBConfigFromVisualSGIX(IntPtr dpy, IntPtr vis)
            {
                void* dpy_vptr = (void*)dpy;
                void* vis_vptr = (void*)vis;
                GetFBConfigFromVisualSGIX(dpy_vptr, vis_vptr);
            }
            /// <inheritdoc cref="GetFBConfigFromVisualSGIX(void*, void*)"/>
            public static unsafe void GetFBConfigFromVisualSGIX<T1, T2>(ref T1 dpy, ref T2 vis)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                fixed (void* vis_ptr = &vis)
                {
                    GetFBConfigFromVisualSGIX(dpy_ptr, vis_ptr);
                }
            }
            /// <inheritdoc cref="GetSelectedEventSGIX(void*, void, ulong*)"/>
            public static unsafe void GetSelectedEventSGIX(IntPtr dpy, void drawable, ref ulong mask)
            {
                fixed (ulong* mask_ptr = &mask)
                {
                    void* dpy_vptr = (void*)dpy;
                    GetSelectedEventSGIX(dpy_vptr, drawable, mask_ptr);
                }
            }
            /// <inheritdoc cref="GetSelectedEventSGIX(void*, void, ulong*)"/>
            public static unsafe void GetSelectedEventSGIX<T1>(ref T1 dpy, void drawable, ref ulong mask)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                fixed (ulong* mask_ptr = &mask)
                {
                    GetSelectedEventSGIX(dpy_ptr, drawable, mask_ptr);
                }
            }
            /// <inheritdoc cref="GetVisualFromFBConfigSGIX(void*, void)"/>
            public static unsafe void* GetVisualFromFBConfigSGIX(IntPtr dpy, void config)
            {
                void* returnValue;
                void* dpy_vptr = (void*)dpy;
                returnValue = GetVisualFromFBConfigSGIX(dpy_vptr, config);
                return returnValue;
            }
            /// <inheritdoc cref="GetVisualFromFBConfigSGIX(void*, void)"/>
            public static unsafe void* GetVisualFromFBConfigSGIX<T1>(ref T1 dpy, void config)
                where T1 : unmanaged
            {
                void* returnValue;
                fixed (void* dpy_ptr = &dpy)
                {
                    returnValue = GetVisualFromFBConfigSGIX(dpy_ptr, config);
                }
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeAttribSGIX(void*, int, int, int, void*)"/>
            public static unsafe int HyperpipeAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr attribList)
            {
                int returnValue;
                void* dpy_vptr = (void*)dpy;
                void* attribList_vptr = (void*)attribList;
                returnValue = HyperpipeAttribSGIX(dpy_vptr, timeSlice, attrib, size, attribList_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeAttribSGIX(void*, int, int, int, void*)"/>
            public static unsafe int HyperpipeAttribSGIX<T1, T2>(ref T1 dpy, int timeSlice, int attrib, int size, ref T2 attribList)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (void* attribList_ptr = &attribList)
                {
                    returnValue = HyperpipeAttribSGIX(dpy_ptr, timeSlice, attrib, size, attribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeConfigSGIX(void*, int, int, void*, int*)"/>
            public static unsafe int HyperpipeConfigSGIX(IntPtr dpy, int networkId, int npipes, IntPtr cfg, ref int hpId)
            {
                int returnValue;
                fixed (int* hpId_ptr = &hpId)
                {
                    void* dpy_vptr = (void*)dpy;
                    void* cfg_vptr = (void*)cfg;
                    returnValue = HyperpipeConfigSGIX(dpy_vptr, networkId, npipes, cfg_vptr, hpId_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeConfigSGIX(void*, int, int, void*, int*)"/>
            public static unsafe int HyperpipeConfigSGIX<T1, T2>(ref T1 dpy, int networkId, int npipes, ref T2 cfg, ref int hpId)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (void* cfg_ptr = &cfg)
                fixed (int* hpId_ptr = &hpId)
                {
                    returnValue = HyperpipeConfigSGIX(dpy_ptr, networkId, npipes, cfg_ptr, hpId_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="JoinSwapGroupSGIX(void*, void, void)"/>
            public static unsafe void JoinSwapGroupSGIX(IntPtr dpy, void drawable, void member)
            {
                void* dpy_vptr = (void*)dpy;
                JoinSwapGroupSGIX(dpy_vptr, drawable, member);
            }
            /// <inheritdoc cref="JoinSwapGroupSGIX(void*, void, void)"/>
            public static unsafe void JoinSwapGroupSGIX<T1>(ref T1 dpy, void drawable, void member)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    JoinSwapGroupSGIX(dpy_ptr, drawable, member);
                }
            }
            /// <inheritdoc cref="QueryChannelDeltasSGIX(void*, int, int, int*, int*, int*, int*)"/>
            public static unsafe int QueryChannelDeltasSGIX(IntPtr display, int screen, int channel, ref int x, ref int y, ref int w, ref int h)
            {
                int returnValue;
                fixed (int* x_ptr = &x)
                fixed (int* y_ptr = &y)
                fixed (int* w_ptr = &w)
                fixed (int* h_ptr = &h)
                {
                    void* display_vptr = (void*)display;
                    returnValue = QueryChannelDeltasSGIX(display_vptr, screen, channel, x_ptr, y_ptr, w_ptr, h_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryChannelDeltasSGIX(void*, int, int, int*, int*, int*, int*)"/>
            public static unsafe int QueryChannelDeltasSGIX<T1>(ref T1 display, int screen, int channel, ref int x, ref int y, ref int w, ref int h)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* display_ptr = &display)
                fixed (int* x_ptr = &x)
                fixed (int* y_ptr = &y)
                fixed (int* w_ptr = &w)
                fixed (int* h_ptr = &h)
                {
                    returnValue = QueryChannelDeltasSGIX(display_ptr, screen, channel, x_ptr, y_ptr, w_ptr, h_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryChannelRectSGIX(void*, int, int, int*, int*, int*, int*)"/>
            public static unsafe int QueryChannelRectSGIX(IntPtr display, int screen, int channel, ref int dx, ref int dy, ref int dw, ref int dh)
            {
                int returnValue;
                fixed (int* dx_ptr = &dx)
                fixed (int* dy_ptr = &dy)
                fixed (int* dw_ptr = &dw)
                fixed (int* dh_ptr = &dh)
                {
                    void* display_vptr = (void*)display;
                    returnValue = QueryChannelRectSGIX(display_vptr, screen, channel, dx_ptr, dy_ptr, dw_ptr, dh_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryChannelRectSGIX(void*, int, int, int*, int*, int*, int*)"/>
            public static unsafe int QueryChannelRectSGIX<T1>(ref T1 display, int screen, int channel, ref int dx, ref int dy, ref int dw, ref int dh)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* display_ptr = &display)
                fixed (int* dx_ptr = &dx)
                fixed (int* dy_ptr = &dy)
                fixed (int* dw_ptr = &dw)
                fixed (int* dh_ptr = &dh)
                {
                    returnValue = QueryChannelRectSGIX(display_ptr, screen, channel, dx_ptr, dy_ptr, dw_ptr, dh_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryGLXPbufferSGIX(void*, void, int, uint*)"/>
            public static unsafe void QueryGLXPbufferSGIX(IntPtr dpy, void pbuf, int attribute, ref uint value)
            {
                fixed (uint* value_ptr = &value)
                {
                    void* dpy_vptr = (void*)dpy;
                    QueryGLXPbufferSGIX(dpy_vptr, pbuf, attribute, value_ptr);
                }
            }
            /// <inheritdoc cref="QueryGLXPbufferSGIX(void*, void, int, uint*)"/>
            public static unsafe void QueryGLXPbufferSGIX<T1>(ref T1 dpy, void pbuf, int attribute, ref uint value)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                fixed (uint* value_ptr = &value)
                {
                    QueryGLXPbufferSGIX(dpy_ptr, pbuf, attribute, value_ptr);
                }
            }
            /// <inheritdoc cref="QueryHyperpipeAttribSGIX(void*, int, int, int, void*)"/>
            public static unsafe int QueryHyperpipeAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr returnAttribList)
            {
                int returnValue;
                void* dpy_vptr = (void*)dpy;
                void* returnAttribList_vptr = (void*)returnAttribList;
                returnValue = QueryHyperpipeAttribSGIX(dpy_vptr, timeSlice, attrib, size, returnAttribList_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeAttribSGIX(void*, int, int, int, void*)"/>
            public static unsafe int QueryHyperpipeAttribSGIX<T1, T2>(ref T1 dpy, int timeSlice, int attrib, int size, ref T2 returnAttribList)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (void* returnAttribList_ptr = &returnAttribList)
                {
                    returnValue = QueryHyperpipeAttribSGIX(dpy_ptr, timeSlice, attrib, size, returnAttribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeBestAttribSGIX(void*, int, int, int, void*, void*)"/>
            public static unsafe int QueryHyperpipeBestAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr attribList, IntPtr returnAttribList)
            {
                int returnValue;
                void* dpy_vptr = (void*)dpy;
                void* attribList_vptr = (void*)attribList;
                void* returnAttribList_vptr = (void*)returnAttribList;
                returnValue = QueryHyperpipeBestAttribSGIX(dpy_vptr, timeSlice, attrib, size, attribList_vptr, returnAttribList_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeBestAttribSGIX(void*, int, int, int, void*, void*)"/>
            public static unsafe int QueryHyperpipeBestAttribSGIX<T1, T2, T3>(ref T1 dpy, int timeSlice, int attrib, int size, ref T2 attribList, ref T3 returnAttribList)
                where T1 : unmanaged
                where T2 : unmanaged
                where T3 : unmanaged
            {
                int returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (void* attribList_ptr = &attribList)
                fixed (void* returnAttribList_ptr = &returnAttribList)
                {
                    returnValue = QueryHyperpipeBestAttribSGIX(dpy_ptr, timeSlice, attrib, size, attribList_ptr, returnAttribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeConfigSGIX(void*, int, int*)"/>
            public static unsafe void* QueryHyperpipeConfigSGIX(IntPtr dpy, int hpId, ref int npipes)
            {
                void* returnValue;
                fixed (int* npipes_ptr = &npipes)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = QueryHyperpipeConfigSGIX(dpy_vptr, hpId, npipes_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeConfigSGIX(void*, int, int*)"/>
            public static unsafe void* QueryHyperpipeConfigSGIX<T1>(ref T1 dpy, int hpId, ref int npipes)
                where T1 : unmanaged
            {
                void* returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (int* npipes_ptr = &npipes)
                {
                    returnValue = QueryHyperpipeConfigSGIX(dpy_ptr, hpId, npipes_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeNetworkSGIX(void*, int*)"/>
            public static unsafe void* QueryHyperpipeNetworkSGIX(IntPtr dpy, ref int npipes)
            {
                void* returnValue;
                fixed (int* npipes_ptr = &npipes)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = QueryHyperpipeNetworkSGIX(dpy_vptr, npipes_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeNetworkSGIX(void*, int*)"/>
            public static unsafe void* QueryHyperpipeNetworkSGIX<T1>(ref T1 dpy, ref int npipes)
                where T1 : unmanaged
            {
                void* returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (int* npipes_ptr = &npipes)
                {
                    returnValue = QueryHyperpipeNetworkSGIX(dpy_ptr, npipes_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapBarriersSGIX(void*, int, int*)"/>
            public static unsafe bool QueryMaxSwapBarriersSGIX(IntPtr dpy, int screen, ref int max)
            {
                bool returnValue;
                fixed (int* max_ptr = &max)
                {
                    void* dpy_vptr = (void*)dpy;
                    returnValue = QueryMaxSwapBarriersSGIX(dpy_vptr, screen, max_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapBarriersSGIX(void*, int, int*)"/>
            public static unsafe bool QueryMaxSwapBarriersSGIX<T1>(ref T1 dpy, int screen, ref int max)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (void* dpy_ptr = &dpy)
                fixed (int* max_ptr = &max)
                {
                    returnValue = QueryMaxSwapBarriersSGIX(dpy_ptr, screen, max_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SelectEventSGIX(void*, void, ulong)"/>
            public static unsafe void SelectEventSGIX(IntPtr dpy, void drawable, ulong mask)
            {
                void* dpy_vptr = (void*)dpy;
                SelectEventSGIX(dpy_vptr, drawable, mask);
            }
            /// <inheritdoc cref="SelectEventSGIX(void*, void, ulong)"/>
            public static unsafe void SelectEventSGIX<T1>(ref T1 dpy, void drawable, ulong mask)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                {
                    SelectEventSGIX(dpy_ptr, drawable, mask);
                }
            }
        }
        public static unsafe partial class SUN
        {
            /// <inheritdoc cref="GetTransparentIndexSUN(void*, void, void, ulong*)"/>
            public static unsafe void GetTransparentIndexSUN(IntPtr dpy, void overlay, void underlay, ref ulong pTransparentIndex)
            {
                fixed (ulong* pTransparentIndex_ptr = &pTransparentIndex)
                {
                    void* dpy_vptr = (void*)dpy;
                    GetTransparentIndexSUN(dpy_vptr, overlay, underlay, pTransparentIndex_ptr);
                }
            }
            /// <inheritdoc cref="GetTransparentIndexSUN(void*, void, void, ulong*)"/>
            public static unsafe void GetTransparentIndexSUN<T1>(ref T1 dpy, void overlay, void underlay, ref ulong pTransparentIndex)
                where T1 : unmanaged
            {
                fixed (void* dpy_ptr = &dpy)
                fixed (ulong* pTransparentIndex_ptr = &pTransparentIndex)
                {
                    GetTransparentIndexSUN(dpy_ptr, overlay, underlay, pTransparentIndex_ptr);
                }
            }
        }
    }
}

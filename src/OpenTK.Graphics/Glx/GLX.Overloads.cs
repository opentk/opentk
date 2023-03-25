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
        /// <inheritdoc cref="ChooseFBConfig(Display*, int, int*, int*)"/>
        public static unsafe __GLXFBConfigRec** ChooseFBConfig(ref Display dpy, int screen, in int attrib_list, ref int nelements)
        {
            __GLXFBConfigRec** returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (int* attrib_list_ptr = &attrib_list)
            fixed (int* nelements_ptr = &nelements)
            {
                returnValue = ChooseFBConfig(dpy_ptr, screen, attrib_list_ptr, nelements_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="ChooseVisual(Display*, int, int*)"/>
        public static unsafe XVisualInfo* ChooseVisual(ref Display dpy, int screen, ref int attribList)
        {
            XVisualInfo* returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (int* attribList_ptr = &attribList)
            {
                returnValue = ChooseVisual(dpy_ptr, screen, attribList_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CopyContext(Display*, __GLXContextRec*, __GLXContextRec*, ulong)"/>
        public static unsafe void CopyContext(ref Display dpy, ref __GLXContextRec src, ref __GLXContextRec dst, ulong mask)
        {
            fixed (Display* dpy_ptr = &dpy)
            fixed (__GLXContextRec* src_ptr = &src)
            fixed (__GLXContextRec* dst_ptr = &dst)
            {
                CopyContext(dpy_ptr, src_ptr, dst_ptr, mask);
            }
        }
        /// <inheritdoc cref="CreateContext(Display*, XVisualInfo*, __GLXContextRec*, bool)"/>
        public static unsafe __GLXContextRec* CreateContext(ref Display dpy, ref XVisualInfo vis, ref __GLXContextRec shareList, bool direct)
        {
            __GLXContextRec* returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (XVisualInfo* vis_ptr = &vis)
            fixed (__GLXContextRec* shareList_ptr = &shareList)
            {
                returnValue = CreateContext(dpy_ptr, vis_ptr, shareList_ptr, direct);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateGLXPixmap(Display*, XVisualInfo*, Pixmap)"/>
        public static unsafe GLXPixmap CreateGLXPixmap(ref Display dpy, ref XVisualInfo visual, Pixmap pixmap)
        {
            GLXPixmap returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (XVisualInfo* visual_ptr = &visual)
            {
                returnValue = CreateGLXPixmap(dpy_ptr, visual_ptr, pixmap);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateNewContext(Display*, __GLXFBConfigRec*, int, __GLXContextRec*, bool)"/>
        public static unsafe __GLXContextRec* CreateNewContext(ref Display dpy, ref __GLXFBConfigRec config, int render_type, ref __GLXContextRec share_list, bool direct)
        {
            __GLXContextRec* returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (__GLXFBConfigRec* config_ptr = &config)
            fixed (__GLXContextRec* share_list_ptr = &share_list)
            {
                returnValue = CreateNewContext(dpy_ptr, config_ptr, render_type, share_list_ptr, direct);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePbuffer(Display*, __GLXFBConfigRec*, int*)"/>
        public static unsafe GLXPbuffer CreatePbuffer(ref Display dpy, ref __GLXFBConfigRec config, in int attrib_list)
        {
            GLXPbuffer returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (__GLXFBConfigRec* config_ptr = &config)
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreatePbuffer(dpy_ptr, config_ptr, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePixmap(Display*, __GLXFBConfigRec*, Pixmap, int*)"/>
        public static unsafe GLXPixmap CreatePixmap(ref Display dpy, ref __GLXFBConfigRec config, Pixmap pixmap, in int attrib_list)
        {
            GLXPixmap returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (__GLXFBConfigRec* config_ptr = &config)
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreatePixmap(dpy_ptr, config_ptr, pixmap, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateWindow(Display*, __GLXFBConfigRec*, Window, int*)"/>
        public static unsafe GLXWindow CreateWindow(ref Display dpy, ref __GLXFBConfigRec config, Window win, in int attrib_list)
        {
            GLXWindow returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (__GLXFBConfigRec* config_ptr = &config)
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreateWindow(dpy_ptr, config_ptr, win, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="DestroyContext(Display*, __GLXContextRec*)"/>
        public static unsafe void DestroyContext(ref Display dpy, ref __GLXContextRec ctx)
        {
            fixed (Display* dpy_ptr = &dpy)
            fixed (__GLXContextRec* ctx_ptr = &ctx)
            {
                DestroyContext(dpy_ptr, ctx_ptr);
            }
        }
        /// <inheritdoc cref="DestroyGLXPixmap(Display*, GLXPixmap)"/>
        public static unsafe void DestroyGLXPixmap(ref Display dpy, GLXPixmap pixmap)
        {
            fixed (Display* dpy_ptr = &dpy)
            {
                DestroyGLXPixmap(dpy_ptr, pixmap);
            }
        }
        /// <inheritdoc cref="DestroyPbuffer(Display*, GLXPbuffer)"/>
        public static unsafe void DestroyPbuffer(ref Display dpy, GLXPbuffer pbuf)
        {
            fixed (Display* dpy_ptr = &dpy)
            {
                DestroyPbuffer(dpy_ptr, pbuf);
            }
        }
        /// <inheritdoc cref="DestroyPixmap(Display*, GLXPixmap)"/>
        public static unsafe void DestroyPixmap(ref Display dpy, GLXPixmap pixmap)
        {
            fixed (Display* dpy_ptr = &dpy)
            {
                DestroyPixmap(dpy_ptr, pixmap);
            }
        }
        /// <inheritdoc cref="DestroyWindow(Display*, GLXWindow)"/>
        public static unsafe void DestroyWindow(ref Display dpy, GLXWindow win)
        {
            fixed (Display* dpy_ptr = &dpy)
            {
                DestroyWindow(dpy_ptr, win);
            }
        }
        /// <inheritdoc cref="GetClientString(Display*, int)"/>
        public static unsafe string? GetClientString(ref Display dpy, int name)
        {
            byte* returnValue;
            fixed (Display* dpy_ptr = &dpy)
            {
                string? returnValue_str;
                returnValue = GetClientString(dpy_ptr, name);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            }
            return returnValue_str;
        }
        /// <inheritdoc cref="GetConfig(Display*, XVisualInfo*, int, int*)"/>
        public static unsafe int GetConfig(ref Display dpy, ref XVisualInfo visual, int attrib, ref int value)
        {
            int returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (XVisualInfo* visual_ptr = &visual)
            fixed (int* value_ptr = &value)
            {
                returnValue = GetConfig(dpy_ptr, visual_ptr, attrib, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetFBConfigAttrib(Display*, __GLXFBConfigRec*, int, int*)"/>
        public static unsafe int GetFBConfigAttrib(ref Display dpy, ref __GLXFBConfigRec config, int attribute, ref int value)
        {
            int returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (__GLXFBConfigRec* config_ptr = &config)
            fixed (int* value_ptr = &value)
            {
                returnValue = GetFBConfigAttrib(dpy_ptr, config_ptr, attribute, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetFBConfigs(Display*, int, int*)"/>
        public static unsafe __GLXFBConfigRec** GetFBConfig(ref Display dpy, int screen, ref int nelements)
        {
            __GLXFBConfigRec** returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (int* nelements_ptr = &nelements)
            {
                returnValue = GetFBConfigs(dpy_ptr, screen, nelements_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProcAddress(byte*)"/>
        public static unsafe IntPtr GetProcAddress(in byte procName)
        {
            IntPtr returnValue;
            fixed (byte* procName_ptr = &procName)
            {
                returnValue = GetProcAddress(procName_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetSelectedEvent(Display*, GLXDrawable, ulong*)"/>
        public static unsafe void GetSelectedEvent(ref Display dpy, GLXDrawable draw, ref ulong event_mask)
        {
            fixed (Display* dpy_ptr = &dpy)
            fixed (ulong* event_mask_ptr = &event_mask)
            {
                GetSelectedEvent(dpy_ptr, draw, event_mask_ptr);
            }
        }
        /// <inheritdoc cref="GetVisualFromFBConfig(Display*, __GLXFBConfigRec*)"/>
        public static unsafe XVisualInfo* GetVisualFromFBConfig(ref Display dpy, ref __GLXFBConfigRec config)
        {
            XVisualInfo* returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (__GLXFBConfigRec* config_ptr = &config)
            {
                returnValue = GetVisualFromFBConfig(dpy_ptr, config_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="IsDirect(Display*, __GLXContextRec*)"/>
        public static unsafe bool IsDirect(ref Display dpy, ref __GLXContextRec ctx)
        {
            bool returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (__GLXContextRec* ctx_ptr = &ctx)
            {
                returnValue = IsDirect(dpy_ptr, ctx_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="MakeContextCurrent(Display*, GLXDrawable, GLXDrawable, __GLXContextRec*)"/>
        public static unsafe bool MakeContextCurrent(ref Display dpy, GLXDrawable draw, GLXDrawable read, ref __GLXContextRec ctx)
        {
            bool returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (__GLXContextRec* ctx_ptr = &ctx)
            {
                returnValue = MakeContextCurrent(dpy_ptr, draw, read, ctx_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="MakeCurrent(Display*, GLXDrawable, __GLXContextRec*)"/>
        public static unsafe bool MakeCurrent(ref Display dpy, GLXDrawable drawable, ref __GLXContextRec ctx)
        {
            bool returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (__GLXContextRec* ctx_ptr = &ctx)
            {
                returnValue = MakeCurrent(dpy_ptr, drawable, ctx_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryContext(Display*, __GLXContextRec*, int, int*)"/>
        public static unsafe int QueryContext(ref Display dpy, ref __GLXContextRec ctx, int attribute, ref int value)
        {
            int returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (__GLXContextRec* ctx_ptr = &ctx)
            fixed (int* value_ptr = &value)
            {
                returnValue = QueryContext(dpy_ptr, ctx_ptr, attribute, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryDrawable(Display*, GLXDrawable, int, uint*)"/>
        public static unsafe void QueryDrawable(ref Display dpy, GLXDrawable draw, int attribute, ref uint value)
        {
            fixed (Display* dpy_ptr = &dpy)
            fixed (uint* value_ptr = &value)
            {
                QueryDrawable(dpy_ptr, draw, attribute, value_ptr);
            }
        }
        /// <inheritdoc cref="QueryExtension(Display*, int*, int*)"/>
        public static unsafe bool QueryExtension(ref Display dpy, ref int errorb, ref int @event)
        {
            bool returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (int* errorb_ptr = &errorb)
            fixed (int* @event_ptr = &@event)
            {
                returnValue = QueryExtension(dpy_ptr, errorb_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryExtensionsString(Display*, int)"/>
        public static unsafe string? QueryExtensionsString(ref Display dpy, int screen)
        {
            byte* returnValue;
            fixed (Display* dpy_ptr = &dpy)
            {
                string? returnValue_str;
                returnValue = QueryExtensionsString(dpy_ptr, screen);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            }
            return returnValue_str;
        }
        /// <inheritdoc cref="QueryServerString(Display*, int, int)"/>
        public static unsafe string? QueryServerString(ref Display dpy, int screen, int name)
        {
            byte* returnValue;
            fixed (Display* dpy_ptr = &dpy)
            {
                string? returnValue_str;
                returnValue = QueryServerString(dpy_ptr, screen, name);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            }
            return returnValue_str;
        }
        /// <inheritdoc cref="QueryVersion(Display*, int*, int*)"/>
        public static unsafe bool QueryVersion(ref Display dpy, ref int maj, ref int min)
        {
            bool returnValue;
            fixed (Display* dpy_ptr = &dpy)
            fixed (int* maj_ptr = &maj)
            fixed (int* min_ptr = &min)
            {
                returnValue = QueryVersion(dpy_ptr, maj_ptr, min_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="SelectEvent(Display*, GLXDrawable, ulong)"/>
        public static unsafe void SelectEvent(ref Display dpy, GLXDrawable draw, ulong event_mask)
        {
            fixed (Display* dpy_ptr = &dpy)
            {
                SelectEvent(dpy_ptr, draw, event_mask);
            }
        }
        /// <inheritdoc cref="SwapBuffers(Display*, GLXDrawable)"/>
        public static unsafe void SwapBuffers(ref Display dpy, GLXDrawable drawable)
        {
            fixed (Display* dpy_ptr = &dpy)
            {
                SwapBuffers(dpy_ptr, drawable);
            }
        }
        public static unsafe partial class AMD
        {
            /// <inheritdoc cref="BlitContextFramebufferAMD(__GLXContextRec*, int, int, int, int, int, int, int, int, uint, All)"/>
            public static unsafe void BlitContextFramebufferAMD(ref __GLXContextRec dstCtx, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, All filter)
            {
                fixed (__GLXContextRec* dstCtx_ptr = &dstCtx)
                {
                    BlitContextFramebufferAMD(dstCtx_ptr, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
                }
            }
            /// <inheritdoc cref="CreateAssociatedContextAMD(uint, __GLXContextRec*)"/>
            public static unsafe __GLXContextRec* CreateAssociatedContextAMD(uint id, ref __GLXContextRec share_list)
            {
                __GLXContextRec* returnValue;
                fixed (__GLXContextRec* share_list_ptr = &share_list)
                {
                    returnValue = CreateAssociatedContextAMD(id, share_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateAssociatedContextAttribsAMD(uint, __GLXContextRec*, int*)"/>
            public static unsafe __GLXContextRec* CreateAssociatedContextAttribsAMD(uint id, ref __GLXContextRec share_context, in int attribList)
            {
                __GLXContextRec* returnValue;
                fixed (__GLXContextRec* share_context_ptr = &share_context)
                fixed (int* attribList_ptr = &attribList)
                {
                    returnValue = CreateAssociatedContextAttribsAMD(id, share_context_ptr, attribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DeleteAssociatedContextAMD(__GLXContextRec*)"/>
            public static unsafe bool DeleteAssociatedContextAMD(ref __GLXContextRec ctx)
            {
                bool returnValue;
                fixed (__GLXContextRec* ctx_ptr = &ctx)
                {
                    returnValue = DeleteAssociatedContextAMD(ctx_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetContextGPUIDAMD(__GLXContextRec*)"/>
            public static unsafe uint GetContextGPUIDAMD(ref __GLXContextRec ctx)
            {
                uint returnValue;
                fixed (__GLXContextRec* ctx_ptr = &ctx)
                {
                    returnValue = GetContextGPUIDAMD(ctx_ptr);
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
            /// <inheritdoc cref="MakeAssociatedContextCurrentAMD(__GLXContextRec*)"/>
            public static unsafe bool MakeAssociatedContextCurrentAMD(ref __GLXContextRec ctx)
            {
                bool returnValue;
                fixed (__GLXContextRec* ctx_ptr = &ctx)
                {
                    returnValue = MakeAssociatedContextCurrentAMD(ctx_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class ARB
        {
            /// <inheritdoc cref="CreateContextAttribsARB(Display*, __GLXFBConfigRec*, __GLXContextRec*, bool, int*)"/>
            public static unsafe __GLXContextRec* CreateContextAttribsARB(ref Display dpy, ref __GLXFBConfigRec config, ref __GLXContextRec share_context, bool direct, in int attrib_list)
            {
                __GLXContextRec* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (__GLXFBConfigRec* config_ptr = &config)
                fixed (__GLXContextRec* share_context_ptr = &share_context)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateContextAttribsARB(dpy_ptr, config_ptr, share_context_ptr, direct, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetProcAddressARB(byte*)"/>
            public static unsafe IntPtr GetProcAddressARB(in byte procName)
            {
                IntPtr returnValue;
                fixed (byte* procName_ptr = &procName)
                {
                    returnValue = GetProcAddressARB(procName_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class EXT
        {
            /// <inheritdoc cref="BindTexImageEXT(Display*, GLXDrawable, int, int*)"/>
            public static unsafe void BindTexImageEXT(ref Display dpy, GLXDrawable drawable, int buffer, in int attrib_list)
            {
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    BindTexImageEXT(dpy_ptr, drawable, buffer, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="FreeContextEXT(Display*, __GLXContextRec*)"/>
            public static unsafe void FreeContextEXT(ref Display dpy, ref __GLXContextRec context)
            {
                fixed (Display* dpy_ptr = &dpy)
                fixed (__GLXContextRec* context_ptr = &context)
                {
                    FreeContextEXT(dpy_ptr, context_ptr);
                }
            }
            /// <inheritdoc cref="GetContextIDEXT(__GLXContextRec*)"/>
            public static unsafe ContextID GetContextIDEXT(in __GLXContextRec context)
            {
                ContextID returnValue;
                fixed (__GLXContextRec* context_ptr = &context)
                {
                    returnValue = GetContextIDEXT(context_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ImportContextEXT(Display*, ContextID)"/>
            public static unsafe __GLXContextRec* ImportContextEXT(ref Display dpy, ContextID contextID)
            {
                __GLXContextRec* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = ImportContextEXT(dpy_ptr, contextID);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryContextInfoEXT(Display*, __GLXContextRec*, int, int*)"/>
            public static unsafe int QueryContextInfoEXT(ref Display dpy, ref __GLXContextRec context, int attribute, ref int value)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (__GLXContextRec* context_ptr = &context)
                fixed (int* value_ptr = &value)
                {
                    returnValue = QueryContextInfoEXT(dpy_ptr, context_ptr, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReleaseTexImageEXT(Display*, GLXDrawable, int)"/>
            public static unsafe void ReleaseTexImageEXT(ref Display dpy, GLXDrawable drawable, int buffer)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    ReleaseTexImageEXT(dpy_ptr, drawable, buffer);
                }
            }
            /// <inheritdoc cref="SwapIntervalEXT(Display*, GLXDrawable, int)"/>
            public static unsafe void SwapIntervalEXT(ref Display dpy, GLXDrawable drawable, int interval)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    SwapIntervalEXT(dpy_ptr, drawable, interval);
                }
            }
        }
        public static unsafe partial class MESA
        {
            /// <inheritdoc cref="CopySubBufferMESA(Display*, GLXDrawable, int, int, int, int)"/>
            public static unsafe void CopySubBufferMESA(ref Display dpy, GLXDrawable drawable, int x, int y, int width, int height)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    CopySubBufferMESA(dpy_ptr, drawable, x, y, width, height);
                }
            }
            /// <inheritdoc cref="CreateGLXPixmapMESA(Display*, XVisualInfo*, Pixmap, Colormap)"/>
            public static unsafe GLXPixmap CreateGLXPixmapMESA(ref Display dpy, ref XVisualInfo visual, Pixmap pixmap, Colormap cmap)
            {
                GLXPixmap returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (XVisualInfo* visual_ptr = &visual)
                {
                    returnValue = CreateGLXPixmapMESA(dpy_ptr, visual_ptr, pixmap, cmap);
                }
                return returnValue;
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
            /// <inheritdoc cref="QueryRendererIntegerMESA(Display*, int, int, int, uint*)"/>
            public static unsafe bool QueryRendererIntegerMESA(ref Display dpy, int screen, int renderer, int attribute, ref uint value)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (uint* value_ptr = &value)
                {
                    returnValue = QueryRendererIntegerMESA(dpy_ptr, screen, renderer, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryRendererStringMESA(Display*, int, int, int)"/>
            public static unsafe string? QueryRendererStringMESA(ref Display dpy, int screen, int renderer, int attribute)
            {
                byte* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    string? returnValue_str;
                    returnValue = QueryRendererStringMESA(dpy_ptr, screen, renderer, attribute);
                    returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                }
                return returnValue_str;
            }
            /// <inheritdoc cref="ReleaseBuffersMESA(Display*, GLXDrawable)"/>
            public static unsafe bool ReleaseBuffersMESA(ref Display dpy, GLXDrawable drawable)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = ReleaseBuffersMESA(dpy_ptr, drawable);
                }
                return returnValue;
            }
        }
        public static unsafe partial class NV
        {
            /// <inheritdoc cref="BindSwapBarrierNV(Display*, uint, uint)"/>
            public static unsafe bool BindSwapBarrierNV(ref Display dpy, uint group, uint barrier)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = BindSwapBarrierNV(dpy_ptr, group, barrier);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindVideoCaptureDeviceNV(Display*, uint, VideoCaptureDeviceNV)"/>
            public static unsafe int BindVideoCaptureDeviceNV(ref Display dpy, uint video_capture_slot, VideoCaptureDeviceNV device)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = BindVideoCaptureDeviceNV(dpy_ptr, video_capture_slot, device);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindVideoDeviceNV(Display*, uint, uint, int*)"/>
            public static unsafe int BindVideoDeviceNV(ref Display dpy, uint video_slot, uint video_device, in int attrib_list)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = BindVideoDeviceNV(dpy_ptr, video_slot, video_device, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindVideoImageNV(Display*, VideoDeviceNV, GLXPbuffer, int)"/>
            public static unsafe int BindVideoImageNV(ref Display dpy, VideoDeviceNV VideoDevice, GLXPbuffer pbuf, int iVideoBuffer)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = BindVideoImageNV(dpy_ptr, VideoDevice, pbuf, iVideoBuffer);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CopyBufferSubDataNV(Display*, __GLXContextRec*, __GLXContextRec*, All, All, IntPtr, IntPtr, nint)"/>
            public static unsafe void CopyBufferSubDataNV(ref Display dpy, ref __GLXContextRec readCtx, ref __GLXContextRec writeCtx, All readTarget, All writeTarget, IntPtr readOffset, IntPtr writeOffset, nint size)
            {
                fixed (Display* dpy_ptr = &dpy)
                fixed (__GLXContextRec* readCtx_ptr = &readCtx)
                fixed (__GLXContextRec* writeCtx_ptr = &writeCtx)
                {
                    CopyBufferSubDataNV(dpy_ptr, readCtx_ptr, writeCtx_ptr, readTarget, writeTarget, readOffset, writeOffset, size);
                }
            }
            /// <inheritdoc cref="CopyImageSubDataNV(Display*, __GLXContextRec*, uint, All, int, int, int, int, __GLXContextRec*, uint, All, int, int, int, int, int, int, int)"/>
            public static unsafe void CopyImageSubDataNV(ref Display dpy, ref __GLXContextRec srcCtx, uint srcName, All srcTarget, int srcLevel, int srcX, int srcY, int srcZ, ref __GLXContextRec dstCtx, uint dstName, All dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
            {
                fixed (Display* dpy_ptr = &dpy)
                fixed (__GLXContextRec* srcCtx_ptr = &srcCtx)
                fixed (__GLXContextRec* dstCtx_ptr = &dstCtx)
                {
                    CopyImageSubDataNV(dpy_ptr, srcCtx_ptr, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstCtx_ptr, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
                }
            }
            /// <inheritdoc cref="DelayBeforeSwapNV(Display*, GLXDrawable, float)"/>
            public static unsafe bool DelayBeforeSwapNV(ref Display dpy, GLXDrawable drawable, float seconds)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = DelayBeforeSwapNV(dpy_ptr, drawable, seconds);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoCaptureDevicesNV(Display*, int, int*)"/>
            public static unsafe VideoCaptureDeviceNV* EnumerateVideoCaptureDevicesNV(ref Display dpy, int screen, ref int nelements)
            {
                VideoCaptureDeviceNV* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* nelements_ptr = &nelements)
                {
                    returnValue = EnumerateVideoCaptureDevicesNV(dpy_ptr, screen, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoDevicesNV(Display*, int, int*)"/>
            public static unsafe uint* EnumerateVideoDevicesNV(ref Display dpy, int screen, ref int nelements)
            {
                uint* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* nelements_ptr = &nelements)
                {
                    returnValue = EnumerateVideoDevicesNV(dpy_ptr, screen, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoDeviceNV(Display*, int, int, VideoDeviceNV*)"/>
            public static unsafe int GetVideoDeviceNV(ref Display dpy, int screen, int numVideoDevices, ref VideoDeviceNV pVideoDevice)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (VideoDeviceNV* pVideoDevice_ptr = &pVideoDevice)
                {
                    returnValue = GetVideoDeviceNV(dpy_ptr, screen, numVideoDevices, pVideoDevice_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoInfoNV(Display*, int, VideoDeviceNV, ulong*, ulong*)"/>
            public static unsafe int GetVideoInfoNV(ref Display dpy, int screen, VideoDeviceNV VideoDevice, ref ulong pulCounterOutputPbuffer, ref ulong pulCounterOutputVideo)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (ulong* pulCounterOutputPbuffer_ptr = &pulCounterOutputPbuffer)
                fixed (ulong* pulCounterOutputVideo_ptr = &pulCounterOutputVideo)
                {
                    returnValue = GetVideoInfoNV(dpy_ptr, screen, VideoDevice, pulCounterOutputPbuffer_ptr, pulCounterOutputVideo_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="JoinSwapGroupNV(Display*, GLXDrawable, uint)"/>
            public static unsafe bool JoinSwapGroupNV(ref Display dpy, GLXDrawable drawable, uint group)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = JoinSwapGroupNV(dpy_ptr, drawable, group);
                }
                return returnValue;
            }
            /// <inheritdoc cref="LockVideoCaptureDeviceNV(Display*, VideoCaptureDeviceNV)"/>
            public static unsafe void LockVideoCaptureDeviceNV(ref Display dpy, VideoCaptureDeviceNV device)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    LockVideoCaptureDeviceNV(dpy_ptr, device);
                }
            }
            /// <inheritdoc cref="NamedCopyBufferSubDataNV(Display*, __GLXContextRec*, __GLXContextRec*, uint, uint, IntPtr, IntPtr, nint)"/>
            public static unsafe void NamedCopyBufferSubDataNV(ref Display dpy, ref __GLXContextRec readCtx, ref __GLXContextRec writeCtx, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, nint size)
            {
                fixed (Display* dpy_ptr = &dpy)
                fixed (__GLXContextRec* readCtx_ptr = &readCtx)
                fixed (__GLXContextRec* writeCtx_ptr = &writeCtx)
                {
                    NamedCopyBufferSubDataNV(dpy_ptr, readCtx_ptr, writeCtx_ptr, readBuffer, writeBuffer, readOffset, writeOffset, size);
                }
            }
            /// <inheritdoc cref="QueryFrameCountNV(Display*, int, uint*)"/>
            public static unsafe bool QueryFrameCountNV(ref Display dpy, int screen, ref uint count)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (uint* count_ptr = &count)
                {
                    returnValue = QueryFrameCountNV(dpy_ptr, screen, count_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapGroupsNV(Display*, int, uint*, uint*)"/>
            public static unsafe bool QueryMaxSwapGroupsNV(ref Display dpy, int screen, ref uint maxGroups, ref uint maxBarriers)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (uint* maxGroups_ptr = &maxGroups)
                fixed (uint* maxBarriers_ptr = &maxBarriers)
                {
                    returnValue = QueryMaxSwapGroupsNV(dpy_ptr, screen, maxGroups_ptr, maxBarriers_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QuerySwapGroupNV(Display*, GLXDrawable, uint*, uint*)"/>
            public static unsafe bool QuerySwapGroupNV(ref Display dpy, GLXDrawable drawable, ref uint group, ref uint barrier)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (uint* group_ptr = &group)
                fixed (uint* barrier_ptr = &barrier)
                {
                    returnValue = QuerySwapGroupNV(dpy_ptr, drawable, group_ptr, barrier_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryVideoCaptureDeviceNV(Display*, VideoCaptureDeviceNV, int, int*)"/>
            public static unsafe int QueryVideoCaptureDeviceNV(ref Display dpy, VideoCaptureDeviceNV device, int attribute, ref int value)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* value_ptr = &value)
                {
                    returnValue = QueryVideoCaptureDeviceNV(dpy_ptr, device, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReleaseVideoCaptureDeviceNV(Display*, VideoCaptureDeviceNV)"/>
            public static unsafe void ReleaseVideoCaptureDeviceNV(ref Display dpy, VideoCaptureDeviceNV device)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    ReleaseVideoCaptureDeviceNV(dpy_ptr, device);
                }
            }
            /// <inheritdoc cref="ReleaseVideoDeviceNV(Display*, int, VideoDeviceNV)"/>
            public static unsafe int ReleaseVideoDeviceNV(ref Display dpy, int screen, VideoDeviceNV VideoDevice)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = ReleaseVideoDeviceNV(dpy_ptr, screen, VideoDevice);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ReleaseVideoImageNV(Display*, GLXPbuffer)"/>
            public static unsafe int ReleaseVideoImageNV(ref Display dpy, GLXPbuffer pbuf)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = ReleaseVideoImageNV(dpy_ptr, pbuf);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ResetFrameCountNV(Display*, int)"/>
            public static unsafe bool ResetFrameCountNV(ref Display dpy, int screen)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = ResetFrameCountNV(dpy_ptr, screen);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SendPbufferToVideoNV(Display*, GLXPbuffer, int, ulong*, bool)"/>
            public static unsafe int SendPbufferToVideoNV(ref Display dpy, GLXPbuffer pbuf, int iBufferType, ref ulong pulCounterPbuffer, bool bBlock)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (ulong* pulCounterPbuffer_ptr = &pulCounterPbuffer)
                {
                    returnValue = SendPbufferToVideoNV(dpy_ptr, pbuf, iBufferType, pulCounterPbuffer_ptr, bBlock);
                }
                return returnValue;
            }
        }
        public static unsafe partial class OML
        {
            /// <inheritdoc cref="GetMscRateOML(Display*, GLXDrawable, int*, int*)"/>
            public static unsafe bool GetMscRateOML(ref Display dpy, GLXDrawable drawable, ref int numerator, ref int denominator)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* numerator_ptr = &numerator)
                fixed (int* denominator_ptr = &denominator)
                {
                    returnValue = GetMscRateOML(dpy_ptr, drawable, numerator_ptr, denominator_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSyncValuesOML(Display*, GLXDrawable, long*, long*, long*)"/>
            public static unsafe bool GetSyncValuesOML(ref Display dpy, GLXDrawable drawable, ref long ust, ref long msc, ref long sbc)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    returnValue = GetSyncValuesOML(dpy_ptr, drawable, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SwapBuffersMscOML(Display*, GLXDrawable, long, long, long)"/>
            public static unsafe long SwapBuffersMscOML(ref Display dpy, GLXDrawable drawable, long target_msc, long divisor, long remainder)
            {
                long returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = SwapBuffersMscOML(dpy_ptr, drawable, target_msc, divisor, remainder);
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForMscOML(Display*, GLXDrawable, long, long, long, long*, long*, long*)"/>
            public static unsafe bool WaitForMscOML(ref Display dpy, GLXDrawable drawable, long target_msc, long divisor, long remainder, ref long ust, ref long msc, ref long sbc)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    returnValue = WaitForMscOML(dpy_ptr, drawable, target_msc, divisor, remainder, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForSbcOML(Display*, GLXDrawable, long, long*, long*, long*)"/>
            public static unsafe bool WaitForSbcOML(ref Display dpy, GLXDrawable drawable, long target_sbc, ref long ust, ref long msc, ref long sbc)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
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
            /// <inheritdoc cref="CushionSGI(Display*, Window, float)"/>
            public static unsafe void CushionSGI(ref Display dpy, Window window, float cushion)
            {
                fixed (Display* dpy_ptr = &dpy)
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
            /// <inheritdoc cref="MakeCurrentReadSGI(Display*, GLXDrawable, GLXDrawable, __GLXContextRec*)"/>
            public static unsafe bool MakeCurrentReadSGI(ref Display dpy, GLXDrawable draw, GLXDrawable read, ref __GLXContextRec ctx)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (__GLXContextRec* ctx_ptr = &ctx)
                {
                    returnValue = MakeCurrentReadSGI(dpy_ptr, draw, read, ctx_ptr);
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
            /// <inheritdoc cref="AssociateDMPbufferSGIX(Display*, GLXPbufferSGIX, void*, void)"/>
            public static unsafe bool AssociateDMPbufferSGIX(ref Display dpy, GLXPbufferSGIX pbuffer, IntPtr parameters, void dmbuffer)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    void* parameters_vptr = (void*)parameters;
                    returnValue = AssociateDMPbufferSGIX(dpy_ptr, pbuffer, parameters_vptr, dmbuffer);
                }
                return returnValue;
            }
            /// <inheritdoc cref="AssociateDMPbufferSGIX(Display*, GLXPbufferSGIX, void*, void)"/>
            public static unsafe bool AssociateDMPbufferSGIX<T1>(ref Display dpy, GLXPbufferSGIX pbuffer, ref T1 parameters, void dmbuffer)
                where T1 : unmanaged
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (void* parameters_ptr = &parameters)
                {
                    returnValue = AssociateDMPbufferSGIX(dpy_ptr, pbuffer, parameters_ptr, dmbuffer);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindChannelToWindowSGIX(Display*, int, int, Window)"/>
            public static unsafe int BindChannelToWindowSGIX(ref Display display, int screen, int channel, Window window)
            {
                int returnValue;
                fixed (Display* display_ptr = &display)
                {
                    returnValue = BindChannelToWindowSGIX(display_ptr, screen, channel, window);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindHyperpipeSGIX(Display*, int)"/>
            public static unsafe int BindHyperpipeSGIX(ref Display dpy, int hpId)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = BindHyperpipeSGIX(dpy_ptr, hpId);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindSwapBarrierSGIX(Display*, GLXDrawable, int)"/>
            public static unsafe void BindSwapBarrierSGIX(ref Display dpy, GLXDrawable drawable, int barrier)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    BindSwapBarrierSGIX(dpy_ptr, drawable, barrier);
                }
            }
            /// <inheritdoc cref="ChannelRectSGIX(Display*, int, int, int, int, int, int)"/>
            public static unsafe int ChannelRectSGIX(ref Display display, int screen, int channel, int x, int y, int w, int h)
            {
                int returnValue;
                fixed (Display* display_ptr = &display)
                {
                    returnValue = ChannelRectSGIX(display_ptr, screen, channel, x, y, w, h);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ChannelRectSyncSGIX(Display*, int, int, All)"/>
            public static unsafe int ChannelRectSyncSGIX(ref Display display, int screen, int channel, All synctype)
            {
                int returnValue;
                fixed (Display* display_ptr = &display)
                {
                    returnValue = ChannelRectSyncSGIX(display_ptr, screen, channel, synctype);
                }
                return returnValue;
            }
            /// <inheritdoc cref="ChooseFBConfigSGIX(Display*, int, int*, int*)"/>
            public static unsafe __GLXFBConfigRec** ChooseFBConfigSGIX(ref Display dpy, int screen, ref int attrib_list, ref int nelements)
            {
                __GLXFBConfigRec** returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* attrib_list_ptr = &attrib_list)
                fixed (int* nelements_ptr = &nelements)
                {
                    returnValue = ChooseFBConfigSGIX(dpy_ptr, screen, attrib_list_ptr, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateContextWithConfigSGIX(Display*, __GLXFBConfigRec*, int, __GLXContextRec*, bool)"/>
            public static unsafe __GLXContextRec* CreateContextWithConfigSGIX(ref Display dpy, ref __GLXFBConfigRec config, int render_type, ref __GLXContextRec share_list, bool direct)
            {
                __GLXContextRec* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (__GLXFBConfigRec* config_ptr = &config)
                fixed (__GLXContextRec* share_list_ptr = &share_list)
                {
                    returnValue = CreateContextWithConfigSGIX(dpy_ptr, config_ptr, render_type, share_list_ptr, direct);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateGLXPbufferSGIX(Display*, __GLXFBConfigRec*, uint, uint, int*)"/>
            public static unsafe GLXPbufferSGIX CreateGLXPbufferSGIX(ref Display dpy, ref __GLXFBConfigRec config, uint width, uint height, ref int attrib_list)
            {
                GLXPbufferSGIX returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (__GLXFBConfigRec* config_ptr = &config)
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateGLXPbufferSGIX(dpy_ptr, config_ptr, width, height, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateGLXPixmapWithConfigSGIX(Display*, __GLXFBConfigRec*, Pixmap)"/>
            public static unsafe GLXPixmap CreateGLXPixmapWithConfigSGIX(ref Display dpy, ref __GLXFBConfigRec config, Pixmap pixmap)
            {
                GLXPixmap returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (__GLXFBConfigRec* config_ptr = &config)
                {
                    returnValue = CreateGLXPixmapWithConfigSGIX(dpy_ptr, config_ptr, pixmap);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateGLXVideoSourceSGIX(Display*, int, void, void, int, void)"/>
            public static unsafe VideoSourceSGIX CreateGLXVideoSourceSGIX(ref Display display, int screen, void server, void path, int nodeClass, void drainNode)
            {
                VideoSourceSGIX returnValue;
                fixed (Display* display_ptr = &display)
                {
                    returnValue = CreateGLXVideoSourceSGIX(display_ptr, screen, server, path, nodeClass, drainNode);
                }
                return returnValue;
            }
            /// <inheritdoc cref="DestroyGLXPbufferSGIX(Display*, GLXPbufferSGIX)"/>
            public static unsafe void DestroyGLXPbufferSGIX(ref Display dpy, GLXPbufferSGIX pbuf)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    DestroyGLXPbufferSGIX(dpy_ptr, pbuf);
                }
            }
            /// <inheritdoc cref="DestroyGLXVideoSourceSGIX(Display*, VideoSourceSGIX)"/>
            public static unsafe void DestroyGLXVideoSourceSGIX(ref Display dpy, VideoSourceSGIX glxvideosource)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    DestroyGLXVideoSourceSGIX(dpy_ptr, glxvideosource);
                }
            }
            /// <inheritdoc cref="DestroyHyperpipeConfigSGIX(Display*, int)"/>
            public static unsafe int DestroyHyperpipeConfigSGIX(ref Display dpy, int hpId)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    returnValue = DestroyHyperpipeConfigSGIX(dpy_ptr, hpId);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetFBConfigAttribSGIX(Display*, __GLXFBConfigRec*, int, int*)"/>
            public static unsafe int GetFBConfigAttribSGIX(ref Display dpy, ref __GLXFBConfigRec config, int attribute, ref int value)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (__GLXFBConfigRec* config_ptr = &config)
                fixed (int* value_ptr = &value)
                {
                    returnValue = GetFBConfigAttribSGIX(dpy_ptr, config_ptr, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetFBConfigFromVisualSGIX(Display*, XVisualInfo*)"/>
            public static unsafe __GLXFBConfigRec* GetFBConfigFromVisualSGIX(ref Display dpy, ref XVisualInfo vis)
            {
                __GLXFBConfigRec* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (XVisualInfo* vis_ptr = &vis)
                {
                    returnValue = GetFBConfigFromVisualSGIX(dpy_ptr, vis_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSelectedEventSGIX(Display*, GLXDrawable, ulong*)"/>
            public static unsafe void GetSelectedEventSGIX(ref Display dpy, GLXDrawable drawable, ref ulong mask)
            {
                fixed (Display* dpy_ptr = &dpy)
                fixed (ulong* mask_ptr = &mask)
                {
                    GetSelectedEventSGIX(dpy_ptr, drawable, mask_ptr);
                }
            }
            /// <inheritdoc cref="GetVisualFromFBConfigSGIX(Display*, __GLXFBConfigRec*)"/>
            public static unsafe XVisualInfo* GetVisualFromFBConfigSGIX(ref Display dpy, ref __GLXFBConfigRec config)
            {
                XVisualInfo* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (__GLXFBConfigRec* config_ptr = &config)
                {
                    returnValue = GetVisualFromFBConfigSGIX(dpy_ptr, config_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeAttribSGIX(Display*, int, int, int, void*)"/>
            public static unsafe int HyperpipeAttribSGIX(ref Display dpy, int timeSlice, int attrib, int size, IntPtr attribList)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    void* attribList_vptr = (void*)attribList;
                    returnValue = HyperpipeAttribSGIX(dpy_ptr, timeSlice, attrib, size, attribList_vptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeAttribSGIX(Display*, int, int, int, void*)"/>
            public static unsafe int HyperpipeAttribSGIX<T1>(ref Display dpy, int timeSlice, int attrib, int size, ref T1 attribList)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (void* attribList_ptr = &attribList)
                {
                    returnValue = HyperpipeAttribSGIX(dpy_ptr, timeSlice, attrib, size, attribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeConfigSGIX(Display*, int, int, GLXHyperpipeConfigSGIX*, int*)"/>
            public static unsafe int HyperpipeConfigSGIX(ref Display dpy, int networkId, int npipes, ref GLXHyperpipeConfigSGIX cfg, ref int hpId)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (GLXHyperpipeConfigSGIX* cfg_ptr = &cfg)
                fixed (int* hpId_ptr = &hpId)
                {
                    returnValue = HyperpipeConfigSGIX(dpy_ptr, networkId, npipes, cfg_ptr, hpId_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="JoinSwapGroupSGIX(Display*, GLXDrawable, GLXDrawable)"/>
            public static unsafe void JoinSwapGroupSGIX(ref Display dpy, GLXDrawable drawable, GLXDrawable member)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    JoinSwapGroupSGIX(dpy_ptr, drawable, member);
                }
            }
            /// <inheritdoc cref="QueryChannelDeltasSGIX(Display*, int, int, int*, int*, int*, int*)"/>
            public static unsafe int QueryChannelDeltasSGIX(ref Display display, int screen, int channel, ref int x, ref int y, ref int w, ref int h)
            {
                int returnValue;
                fixed (Display* display_ptr = &display)
                fixed (int* x_ptr = &x)
                fixed (int* y_ptr = &y)
                fixed (int* w_ptr = &w)
                fixed (int* h_ptr = &h)
                {
                    returnValue = QueryChannelDeltasSGIX(display_ptr, screen, channel, x_ptr, y_ptr, w_ptr, h_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryChannelRectSGIX(Display*, int, int, int*, int*, int*, int*)"/>
            public static unsafe int QueryChannelRectSGIX(ref Display display, int screen, int channel, ref int dx, ref int dy, ref int dw, ref int dh)
            {
                int returnValue;
                fixed (Display* display_ptr = &display)
                fixed (int* dx_ptr = &dx)
                fixed (int* dy_ptr = &dy)
                fixed (int* dw_ptr = &dw)
                fixed (int* dh_ptr = &dh)
                {
                    returnValue = QueryChannelRectSGIX(display_ptr, screen, channel, dx_ptr, dy_ptr, dw_ptr, dh_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryGLXPbufferSGIX(Display*, GLXPbufferSGIX, int, uint*)"/>
            public static unsafe void QueryGLXPbufferSGIX(ref Display dpy, GLXPbufferSGIX pbuf, int attribute, ref uint value)
            {
                fixed (Display* dpy_ptr = &dpy)
                fixed (uint* value_ptr = &value)
                {
                    QueryGLXPbufferSGIX(dpy_ptr, pbuf, attribute, value_ptr);
                }
            }
            /// <inheritdoc cref="QueryHyperpipeAttribSGIX(Display*, int, int, int, void*)"/>
            public static unsafe int QueryHyperpipeAttribSGIX(ref Display dpy, int timeSlice, int attrib, int size, IntPtr returnAttribList)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    void* returnAttribList_vptr = (void*)returnAttribList;
                    returnValue = QueryHyperpipeAttribSGIX(dpy_ptr, timeSlice, attrib, size, returnAttribList_vptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeAttribSGIX(Display*, int, int, int, void*)"/>
            public static unsafe int QueryHyperpipeAttribSGIX<T1>(ref Display dpy, int timeSlice, int attrib, int size, ref T1 returnAttribList)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (void* returnAttribList_ptr = &returnAttribList)
                {
                    returnValue = QueryHyperpipeAttribSGIX(dpy_ptr, timeSlice, attrib, size, returnAttribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeBestAttribSGIX(Display*, int, int, int, void*, void*)"/>
            public static unsafe int QueryHyperpipeBestAttribSGIX(ref Display dpy, int timeSlice, int attrib, int size, IntPtr attribList, IntPtr returnAttribList)
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                {
                    void* attribList_vptr = (void*)attribList;
                    void* returnAttribList_vptr = (void*)returnAttribList;
                    returnValue = QueryHyperpipeBestAttribSGIX(dpy_ptr, timeSlice, attrib, size, attribList_vptr, returnAttribList_vptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeBestAttribSGIX(Display*, int, int, int, void*, void*)"/>
            public static unsafe int QueryHyperpipeBestAttribSGIX<T1, T2>(ref Display dpy, int timeSlice, int attrib, int size, ref T1 attribList, ref T2 returnAttribList)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (void* attribList_ptr = &attribList)
                fixed (void* returnAttribList_ptr = &returnAttribList)
                {
                    returnValue = QueryHyperpipeBestAttribSGIX(dpy_ptr, timeSlice, attrib, size, attribList_ptr, returnAttribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeConfigSGIX(Display*, int, int*)"/>
            public static unsafe GLXHyperpipeConfigSGIX* QueryHyperpipeConfigSGIX(ref Display dpy, int hpId, ref int npipes)
            {
                GLXHyperpipeConfigSGIX* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* npipes_ptr = &npipes)
                {
                    returnValue = QueryHyperpipeConfigSGIX(dpy_ptr, hpId, npipes_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeNetworkSGIX(Display*, int*)"/>
            public static unsafe GLXHyperpipeNetworkSGIX* QueryHyperpipeNetworkSGIX(ref Display dpy, ref int npipes)
            {
                GLXHyperpipeNetworkSGIX* returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* npipes_ptr = &npipes)
                {
                    returnValue = QueryHyperpipeNetworkSGIX(dpy_ptr, npipes_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapBarriersSGIX(Display*, int, int*)"/>
            public static unsafe bool QueryMaxSwapBarriersSGIX(ref Display dpy, int screen, ref int max)
            {
                bool returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (int* max_ptr = &max)
                {
                    returnValue = QueryMaxSwapBarriersSGIX(dpy_ptr, screen, max_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SelectEventSGIX(Display*, GLXDrawable, ulong)"/>
            public static unsafe void SelectEventSGIX(ref Display dpy, GLXDrawable drawable, ulong mask)
            {
                fixed (Display* dpy_ptr = &dpy)
                {
                    SelectEventSGIX(dpy_ptr, drawable, mask);
                }
            }
        }
        public static unsafe partial class SUN
        {
            /// <inheritdoc cref="GetTransparentIndexSUN(Display*, Window, Window, ulong*)"/>
            public static unsafe Status GetTransparentIndexSUN(ref Display dpy, Window overlay, Window underlay, ref ulong pTransparentIndex)
            {
                Status returnValue;
                fixed (Display* dpy_ptr = &dpy)
                fixed (ulong* pTransparentIndex_ptr = &pTransparentIndex)
                {
                    returnValue = GetTransparentIndexSUN(dpy_ptr, overlay, underlay, pTransparentIndex_ptr);
                }
                return returnValue;
            }
        }
    }
}

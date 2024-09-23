// This file is auto generated, do not edit. Generated: 2024-09-23 20:17:38 GMT+02:00
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using OpenTK.Mathematics;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics.Wgl;

namespace OpenTK.Graphics.Glx
{
    public static unsafe partial class Glx
    {
        /// <inheritdoc cref="ChooseFBConfig(DisplayPtr, int, int*, int*)"/>
        public static unsafe GLXFBConfig* ChooseFBConfig(DisplayPtr dpy, int screen, ReadOnlySpan<int> attrib_list, Span<int> nelements)
        {
            GLXFBConfig* returnValue;
            fixed (int* nelements_ptr = nelements)
            {
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = ChooseFBConfig(dpy, screen, attrib_list_ptr, nelements_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="ChooseFBConfig(DisplayPtr, int, int*, int*)"/>
        public static unsafe GLXFBConfig* ChooseFBConfig(DisplayPtr dpy, int screen, int[] attrib_list, int[] nelements)
        {
            GLXFBConfig* returnValue;
            fixed (int* nelements_ptr = nelements)
            {
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = ChooseFBConfig(dpy, screen, attrib_list_ptr, nelements_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="ChooseFBConfig(DisplayPtr, int, int*, int*)"/>
        public static unsafe GLXFBConfig* ChooseFBConfig(DisplayPtr dpy, int screen, ref readonly int attrib_list, ref int nelements)
        {
            GLXFBConfig* returnValue;
            fixed (int* attrib_list_ptr = &attrib_list)
            fixed (int* nelements_ptr = &nelements)
            {
                returnValue = ChooseFBConfig(dpy, screen, attrib_list_ptr, nelements_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="ChooseVisual(DisplayPtr, int, int*)"/>
        public static unsafe XVisualInfoPtr ChooseVisual(DisplayPtr dpy, int screen, Span<int> attribList)
        {
            XVisualInfoPtr returnValue;
            fixed (int* attribList_ptr = attribList)
            {
                returnValue = ChooseVisual(dpy, screen, attribList_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="ChooseVisual(DisplayPtr, int, int*)"/>
        public static unsafe XVisualInfoPtr ChooseVisual(DisplayPtr dpy, int screen, int[] attribList)
        {
            XVisualInfoPtr returnValue;
            fixed (int* attribList_ptr = attribList)
            {
                returnValue = ChooseVisual(dpy, screen, attribList_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="ChooseVisual(DisplayPtr, int, int*)"/>
        public static unsafe XVisualInfoPtr ChooseVisual(DisplayPtr dpy, int screen, ref int attribList)
        {
            XVisualInfoPtr returnValue;
            fixed (int* attribList_ptr = &attribList)
            {
                returnValue = ChooseVisual(dpy, screen, attribList_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePbuffer(DisplayPtr, GLXFBConfig, int*)"/>
        public static unsafe GLXPbuffer CreatePbuffer(DisplayPtr dpy, GLXFBConfig config, ReadOnlySpan<int> attrib_list)
        {
            GLXPbuffer returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreatePbuffer(dpy, config, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePbuffer(DisplayPtr, GLXFBConfig, int*)"/>
        public static unsafe GLXPbuffer CreatePbuffer(DisplayPtr dpy, GLXFBConfig config, int[] attrib_list)
        {
            GLXPbuffer returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreatePbuffer(dpy, config, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePbuffer(DisplayPtr, GLXFBConfig, int*)"/>
        public static unsafe GLXPbuffer CreatePbuffer(DisplayPtr dpy, GLXFBConfig config, ref readonly int attrib_list)
        {
            GLXPbuffer returnValue;
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreatePbuffer(dpy, config, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePixmap(DisplayPtr, GLXFBConfig, Pixmap, int*)"/>
        public static unsafe GLXPixmap CreatePixmap(DisplayPtr dpy, GLXFBConfig config, Pixmap pixmap, ReadOnlySpan<int> attrib_list)
        {
            GLXPixmap returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreatePixmap(dpy, config, pixmap, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePixmap(DisplayPtr, GLXFBConfig, Pixmap, int*)"/>
        public static unsafe GLXPixmap CreatePixmap(DisplayPtr dpy, GLXFBConfig config, Pixmap pixmap, int[] attrib_list)
        {
            GLXPixmap returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreatePixmap(dpy, config, pixmap, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreatePixmap(DisplayPtr, GLXFBConfig, Pixmap, int*)"/>
        public static unsafe GLXPixmap CreatePixmap(DisplayPtr dpy, GLXFBConfig config, Pixmap pixmap, ref readonly int attrib_list)
        {
            GLXPixmap returnValue;
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreatePixmap(dpy, config, pixmap, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateWindow(DisplayPtr, GLXFBConfig, Window, int*)"/>
        public static unsafe GLXWindow CreateWindow(DisplayPtr dpy, GLXFBConfig config, Window win, ReadOnlySpan<int> attrib_list)
        {
            GLXWindow returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreateWindow(dpy, config, win, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateWindow(DisplayPtr, GLXFBConfig, Window, int*)"/>
        public static unsafe GLXWindow CreateWindow(DisplayPtr dpy, GLXFBConfig config, Window win, int[] attrib_list)
        {
            GLXWindow returnValue;
            fixed (int* attrib_list_ptr = attrib_list)
            {
                returnValue = CreateWindow(dpy, config, win, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="CreateWindow(DisplayPtr, GLXFBConfig, Window, int*)"/>
        public static unsafe GLXWindow CreateWindow(DisplayPtr dpy, GLXFBConfig config, Window win, ref readonly int attrib_list)
        {
            GLXWindow returnValue;
            fixed (int* attrib_list_ptr = &attrib_list)
            {
                returnValue = CreateWindow(dpy, config, win, attrib_list_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetClientString(DisplayPtr, int)"/>
        public static unsafe string? GetClientString(DisplayPtr dpy, int name)
        {
            string? returnValue_str;
            byte* returnValue;
            returnValue = GetClientString_(dpy, name);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <inheritdoc cref="GetConfig(DisplayPtr, XVisualInfoPtr, int, int*)"/>
        public static unsafe int GetConfig(DisplayPtr dpy, XVisualInfoPtr visual, int attrib, Span<int> value)
        {
            int returnValue;
            fixed (int* value_ptr = value)
            {
                returnValue = GetConfig(dpy, visual, attrib, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetConfig(DisplayPtr, XVisualInfoPtr, int, int*)"/>
        public static unsafe int GetConfig(DisplayPtr dpy, XVisualInfoPtr visual, int attrib, int[] value)
        {
            int returnValue;
            fixed (int* value_ptr = value)
            {
                returnValue = GetConfig(dpy, visual, attrib, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetConfig(DisplayPtr, XVisualInfoPtr, int, int*)"/>
        public static unsafe int GetConfig(DisplayPtr dpy, XVisualInfoPtr visual, int attrib, ref int value)
        {
            int returnValue;
            fixed (int* value_ptr = &value)
            {
                returnValue = GetConfig(dpy, visual, attrib, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetFBConfigAttrib(DisplayPtr, GLXFBConfig, int, int*)"/>
        public static unsafe int GetFBConfigAttrib(DisplayPtr dpy, GLXFBConfig config, int attribute, Span<int> value)
        {
            int returnValue;
            fixed (int* value_ptr = value)
            {
                returnValue = GetFBConfigAttrib(dpy, config, attribute, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetFBConfigAttrib(DisplayPtr, GLXFBConfig, int, int*)"/>
        public static unsafe int GetFBConfigAttrib(DisplayPtr dpy, GLXFBConfig config, int attribute, int[] value)
        {
            int returnValue;
            fixed (int* value_ptr = value)
            {
                returnValue = GetFBConfigAttrib(dpy, config, attribute, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetFBConfigAttrib(DisplayPtr, GLXFBConfig, int, int*)"/>
        public static unsafe int GetFBConfigAttrib(DisplayPtr dpy, GLXFBConfig config, int attribute, ref int value)
        {
            int returnValue;
            fixed (int* value_ptr = &value)
            {
                returnValue = GetFBConfigAttrib(dpy, config, attribute, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetFBConfigs(DisplayPtr, int, int*)"/>
        public static unsafe GLXFBConfig* GetFBConfig(DisplayPtr dpy, int screen, Span<int> nelements)
        {
            GLXFBConfig* returnValue;
            fixed (int* nelements_ptr = nelements)
            {
                returnValue = GetFBConfigs(dpy, screen, nelements_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetFBConfigs(DisplayPtr, int, int*)"/>
        public static unsafe GLXFBConfig* GetFBConfig(DisplayPtr dpy, int screen, int[] nelements)
        {
            GLXFBConfig* returnValue;
            fixed (int* nelements_ptr = nelements)
            {
                returnValue = GetFBConfigs(dpy, screen, nelements_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetFBConfigs(DisplayPtr, int, int*)"/>
        public static unsafe GLXFBConfig* GetFBConfig(DisplayPtr dpy, int screen, ref int nelements)
        {
            GLXFBConfig* returnValue;
            fixed (int* nelements_ptr = &nelements)
            {
                returnValue = GetFBConfigs(dpy, screen, nelements_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProcAddress(byte*)"/>
        public static unsafe IntPtr GetProcAddress(ReadOnlySpan<byte> procName)
        {
            IntPtr returnValue;
            fixed (byte* procName_ptr = procName)
            {
                returnValue = GetProcAddress(procName_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProcAddress(byte*)"/>
        public static unsafe IntPtr GetProcAddress(byte[] procName)
        {
            IntPtr returnValue;
            fixed (byte* procName_ptr = procName)
            {
                returnValue = GetProcAddress(procName_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetProcAddress(byte*)"/>
        public static unsafe IntPtr GetProcAddress(ref readonly byte procName)
        {
            IntPtr returnValue;
            fixed (byte* procName_ptr = &procName)
            {
                returnValue = GetProcAddress(procName_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="GetSelectedEvent(DisplayPtr, GLXDrawable, ulong*)"/>
        public static unsafe void GetSelectedEvent(DisplayPtr dpy, GLXDrawable draw, Span<ulong> event_mask)
        {
            fixed (ulong* event_mask_ptr = event_mask)
            {
                GetSelectedEvent(dpy, draw, event_mask_ptr);
            }
        }
        /// <inheritdoc cref="GetSelectedEvent(DisplayPtr, GLXDrawable, ulong*)"/>
        public static unsafe void GetSelectedEvent(DisplayPtr dpy, GLXDrawable draw, ulong[] event_mask)
        {
            fixed (ulong* event_mask_ptr = event_mask)
            {
                GetSelectedEvent(dpy, draw, event_mask_ptr);
            }
        }
        /// <inheritdoc cref="GetSelectedEvent(DisplayPtr, GLXDrawable, ulong*)"/>
        public static unsafe void GetSelectedEvent(DisplayPtr dpy, GLXDrawable draw, ref ulong event_mask)
        {
            fixed (ulong* event_mask_ptr = &event_mask)
            {
                GetSelectedEvent(dpy, draw, event_mask_ptr);
            }
        }
        /// <inheritdoc cref="QueryContext(DisplayPtr, GLXContext, int, int*)"/>
        public static unsafe int QueryContext(DisplayPtr dpy, GLXContext ctx, int attribute, Span<int> value)
        {
            int returnValue;
            fixed (int* value_ptr = value)
            {
                returnValue = QueryContext(dpy, ctx, attribute, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryContext(DisplayPtr, GLXContext, int, int*)"/>
        public static unsafe int QueryContext(DisplayPtr dpy, GLXContext ctx, int attribute, int[] value)
        {
            int returnValue;
            fixed (int* value_ptr = value)
            {
                returnValue = QueryContext(dpy, ctx, attribute, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryContext(DisplayPtr, GLXContext, int, int*)"/>
        public static unsafe int QueryContext(DisplayPtr dpy, GLXContext ctx, int attribute, ref int value)
        {
            int returnValue;
            fixed (int* value_ptr = &value)
            {
                returnValue = QueryContext(dpy, ctx, attribute, value_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryDrawable(DisplayPtr, GLXDrawable, int, uint*)"/>
        public static unsafe void QueryDrawable(DisplayPtr dpy, GLXDrawable draw, int attribute, Span<uint> value)
        {
            fixed (uint* value_ptr = value)
            {
                QueryDrawable(dpy, draw, attribute, value_ptr);
            }
        }
        /// <inheritdoc cref="QueryDrawable(DisplayPtr, GLXDrawable, int, uint*)"/>
        public static unsafe void QueryDrawable(DisplayPtr dpy, GLXDrawable draw, int attribute, uint[] value)
        {
            fixed (uint* value_ptr = value)
            {
                QueryDrawable(dpy, draw, attribute, value_ptr);
            }
        }
        /// <inheritdoc cref="QueryDrawable(DisplayPtr, GLXDrawable, int, uint*)"/>
        public static unsafe void QueryDrawable(DisplayPtr dpy, GLXDrawable draw, int attribute, ref uint value)
        {
            fixed (uint* value_ptr = &value)
            {
                QueryDrawable(dpy, draw, attribute, value_ptr);
            }
        }
        /// <inheritdoc cref="QueryExtension(DisplayPtr, int*, int*)"/>
        public static unsafe bool QueryExtension(DisplayPtr dpy, Span<int> errorb, Span<int> @event)
        {
            bool returnValue;
            fixed (int* @event_ptr = @event)
            {
                fixed (int* errorb_ptr = errorb)
                {
                    returnValue = QueryExtension(dpy, errorb_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryExtension(DisplayPtr, int*, int*)"/>
        public static unsafe bool QueryExtension(DisplayPtr dpy, int[] errorb, int[] @event)
        {
            bool returnValue;
            fixed (int* @event_ptr = @event)
            {
                fixed (int* errorb_ptr = errorb)
                {
                    returnValue = QueryExtension(dpy, errorb_ptr, @event_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryExtension(DisplayPtr, int*, int*)"/>
        public static unsafe bool QueryExtension(DisplayPtr dpy, ref int errorb, ref int @event)
        {
            bool returnValue;
            fixed (int* errorb_ptr = &errorb)
            fixed (int* @event_ptr = &@event)
            {
                returnValue = QueryExtension(dpy, errorb_ptr, @event_ptr);
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryExtensionsString(DisplayPtr, int)"/>
        public static unsafe string? QueryExtensionsString(DisplayPtr dpy, int screen)
        {
            string? returnValue_str;
            byte* returnValue;
            returnValue = QueryExtensionsString_(dpy, screen);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <inheritdoc cref="QueryServerString(DisplayPtr, int, int)"/>
        public static unsafe string? QueryServerString(DisplayPtr dpy, int screen, int name)
        {
            string? returnValue_str;
            byte* returnValue;
            returnValue = QueryServerString_(dpy, screen, name);
            returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
            return returnValue_str;
        }
        /// <inheritdoc cref="QueryVersion(DisplayPtr, int*, int*)"/>
        public static unsafe bool QueryVersion(DisplayPtr dpy, Span<int> maj, Span<int> min)
        {
            bool returnValue;
            fixed (int* min_ptr = min)
            {
                fixed (int* maj_ptr = maj)
                {
                    returnValue = QueryVersion(dpy, maj_ptr, min_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryVersion(DisplayPtr, int*, int*)"/>
        public static unsafe bool QueryVersion(DisplayPtr dpy, int[] maj, int[] min)
        {
            bool returnValue;
            fixed (int* min_ptr = min)
            {
                fixed (int* maj_ptr = maj)
                {
                    returnValue = QueryVersion(dpy, maj_ptr, min_ptr);
                }
            }
            return returnValue;
        }
        /// <inheritdoc cref="QueryVersion(DisplayPtr, int*, int*)"/>
        public static unsafe bool QueryVersion(DisplayPtr dpy, ref int maj, ref int min)
        {
            bool returnValue;
            fixed (int* maj_ptr = &maj)
            fixed (int* min_ptr = &min)
            {
                returnValue = QueryVersion(dpy, maj_ptr, min_ptr);
            }
            return returnValue;
        }
        public static unsafe partial class AMD
        {
            /// <inheritdoc cref="CreateAssociatedContextAttribsAMD(uint, GLXContext, int*)"/>
            public static unsafe GLXContext CreateAssociatedContextAttribsAMD(uint id, GLXContext share_context, ReadOnlySpan<int> attribList)
            {
                GLXContext returnValue;
                fixed (int* attribList_ptr = attribList)
                {
                    returnValue = CreateAssociatedContextAttribsAMD(id, share_context, attribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateAssociatedContextAttribsAMD(uint, GLXContext, int*)"/>
            public static unsafe GLXContext CreateAssociatedContextAttribsAMD(uint id, GLXContext share_context, int[] attribList)
            {
                GLXContext returnValue;
                fixed (int* attribList_ptr = attribList)
                {
                    returnValue = CreateAssociatedContextAttribsAMD(id, share_context, attribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateAssociatedContextAttribsAMD(uint, GLXContext, int*)"/>
            public static unsafe GLXContext CreateAssociatedContextAttribsAMD(uint id, GLXContext share_context, ref readonly int attribList)
            {
                GLXContext returnValue;
                fixed (int* attribList_ptr = &attribList)
                {
                    returnValue = CreateAssociatedContextAttribsAMD(id, share_context, attribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGPUIDsAMD(uint, uint*)"/>
            public static unsafe uint GetGPUIDsAMD(uint maxCount, Span<uint> ids)
            {
                uint returnValue;
                fixed (uint* ids_ptr = ids)
                {
                    returnValue = GetGPUIDsAMD(maxCount, ids_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGPUIDsAMD(uint, uint*)"/>
            public static unsafe uint GetGPUIDsAMD(uint maxCount, uint[] ids)
            {
                uint returnValue;
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
            /// <inheritdoc cref="GetGPUInfoAMD(uint, int, All, uint, void*)"/>
            public static unsafe int GetGPUInfoAMD(uint id, int property, All dataType, uint size, IntPtr data)
            {
                int returnValue;
                void* data_vptr = (void*)data;
                returnValue = GetGPUInfoAMD(id, property, dataType, size, data_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="GetGPUInfoAMD(uint, int, All, uint, void*)"/>
            public static unsafe int GetGPUInfoAMD<T1>(uint id, int property, All dataType, uint size, Span<T1> data)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* data_ptr = data)
                {
                    returnValue = GetGPUInfoAMD(id, property, dataType, size, data_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetGPUInfoAMD(uint, int, All, uint, void*)"/>
            public static unsafe int GetGPUInfoAMD<T1>(uint id, int property, All dataType, uint size, T1[] data)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* data_ptr = data)
                {
                    returnValue = GetGPUInfoAMD(id, property, dataType, size, data_ptr);
                }
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
            /// <inheritdoc cref="CreateContextAttribsARB(DisplayPtr, GLXFBConfig, GLXContext, bool, int*)"/>
            public static unsafe GLXContext CreateContextAttribsARB(DisplayPtr dpy, GLXFBConfig config, GLXContext share_context, bool direct, ReadOnlySpan<int> attrib_list)
            {
                GLXContext returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateContextAttribsARB(dpy, config, share_context, direct, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateContextAttribsARB(DisplayPtr, GLXFBConfig, GLXContext, bool, int*)"/>
            public static unsafe GLXContext CreateContextAttribsARB(DisplayPtr dpy, GLXFBConfig config, GLXContext share_context, bool direct, int[] attrib_list)
            {
                GLXContext returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateContextAttribsARB(dpy, config, share_context, direct, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateContextAttribsARB(DisplayPtr, GLXFBConfig, GLXContext, bool, int*)"/>
            public static unsafe GLXContext CreateContextAttribsARB(DisplayPtr dpy, GLXFBConfig config, GLXContext share_context, bool direct, ref readonly int attrib_list)
            {
                GLXContext returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateContextAttribsARB(dpy, config, share_context, direct, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetProcAddressARB(byte*)"/>
            public static unsafe IntPtr GetProcAddressARB(ReadOnlySpan<byte> procName)
            {
                IntPtr returnValue;
                fixed (byte* procName_ptr = procName)
                {
                    returnValue = GetProcAddressARB(procName_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetProcAddressARB(byte*)"/>
            public static unsafe IntPtr GetProcAddressARB(byte[] procName)
            {
                IntPtr returnValue;
                fixed (byte* procName_ptr = procName)
                {
                    returnValue = GetProcAddressARB(procName_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetProcAddressARB(byte*)"/>
            public static unsafe IntPtr GetProcAddressARB(ref readonly byte procName)
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
            /// <inheritdoc cref="BindTexImageEXT(DisplayPtr, GLXDrawable, int, int*)"/>
            public static unsafe void BindTexImageEXT(DisplayPtr dpy, GLXDrawable drawable, int buffer, ReadOnlySpan<int> attrib_list)
            {
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    BindTexImageEXT(dpy, drawable, buffer, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="BindTexImageEXT(DisplayPtr, GLXDrawable, int, int*)"/>
            public static unsafe void BindTexImageEXT(DisplayPtr dpy, GLXDrawable drawable, int buffer, int[] attrib_list)
            {
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    BindTexImageEXT(dpy, drawable, buffer, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="BindTexImageEXT(DisplayPtr, GLXDrawable, int, int*)"/>
            public static unsafe void BindTexImageEXT(DisplayPtr dpy, GLXDrawable drawable, int buffer, ref readonly int attrib_list)
            {
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    BindTexImageEXT(dpy, drawable, buffer, attrib_list_ptr);
                }
            }
            /// <inheritdoc cref="QueryContextInfoEXT(DisplayPtr, GLXContext, int, int*)"/>
            public static unsafe int QueryContextInfoEXT(DisplayPtr dpy, GLXContext context, int attribute, Span<int> value)
            {
                int returnValue;
                fixed (int* value_ptr = value)
                {
                    returnValue = QueryContextInfoEXT(dpy, context, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryContextInfoEXT(DisplayPtr, GLXContext, int, int*)"/>
            public static unsafe int QueryContextInfoEXT(DisplayPtr dpy, GLXContext context, int attribute, int[] value)
            {
                int returnValue;
                fixed (int* value_ptr = value)
                {
                    returnValue = QueryContextInfoEXT(dpy, context, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryContextInfoEXT(DisplayPtr, GLXContext, int, int*)"/>
            public static unsafe int QueryContextInfoEXT(DisplayPtr dpy, GLXContext context, int attribute, ref int value)
            {
                int returnValue;
                fixed (int* value_ptr = &value)
                {
                    returnValue = QueryContextInfoEXT(dpy, context, attribute, value_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class MESA
        {
            /// <inheritdoc cref="GetAGPOffsetMESA(void*)"/>
            public static unsafe uint GetAGPOffsetMESA(IntPtr pointer)
            {
                uint returnValue;
                void* pointer_vptr = (void*)pointer;
                returnValue = GetAGPOffsetMESA(pointer_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="GetAGPOffsetMESA(void*)"/>
            public static unsafe uint GetAGPOffsetMESA<T1>(ReadOnlySpan<T1> pointer)
                where T1 : unmanaged
            {
                uint returnValue;
                fixed (void* pointer_ptr = pointer)
                {
                    returnValue = GetAGPOffsetMESA(pointer_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetAGPOffsetMESA(void*)"/>
            public static unsafe uint GetAGPOffsetMESA<T1>(T1[] pointer)
                where T1 : unmanaged
            {
                uint returnValue;
                fixed (void* pointer_ptr = pointer)
                {
                    returnValue = GetAGPOffsetMESA(pointer_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetAGPOffsetMESA(void*)"/>
            public static unsafe uint GetAGPOffsetMESA<T1>(ref readonly T1 pointer)
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
            public static unsafe bool QueryCurrentRendererIntegerMESA(int attribute, Span<uint> value)
            {
                bool returnValue;
                fixed (uint* value_ptr = value)
                {
                    returnValue = QueryCurrentRendererIntegerMESA(attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryCurrentRendererIntegerMESA(int, uint*)"/>
            public static unsafe bool QueryCurrentRendererIntegerMESA(int attribute, uint[] value)
            {
                bool returnValue;
                fixed (uint* value_ptr = value)
                {
                    returnValue = QueryCurrentRendererIntegerMESA(attribute, value_ptr);
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
                string? returnValue_str;
                byte* returnValue;
                returnValue = QueryCurrentRendererStringMESA_(attribute);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
            /// <inheritdoc cref="QueryRendererIntegerMESA(DisplayPtr, int, int, int, uint*)"/>
            public static unsafe bool QueryRendererIntegerMESA(DisplayPtr dpy, int screen, int renderer, int attribute, Span<uint> value)
            {
                bool returnValue;
                fixed (uint* value_ptr = value)
                {
                    returnValue = QueryRendererIntegerMESA(dpy, screen, renderer, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryRendererIntegerMESA(DisplayPtr, int, int, int, uint*)"/>
            public static unsafe bool QueryRendererIntegerMESA(DisplayPtr dpy, int screen, int renderer, int attribute, uint[] value)
            {
                bool returnValue;
                fixed (uint* value_ptr = value)
                {
                    returnValue = QueryRendererIntegerMESA(dpy, screen, renderer, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryRendererIntegerMESA(DisplayPtr, int, int, int, uint*)"/>
            public static unsafe bool QueryRendererIntegerMESA(DisplayPtr dpy, int screen, int renderer, int attribute, ref uint value)
            {
                bool returnValue;
                fixed (uint* value_ptr = &value)
                {
                    returnValue = QueryRendererIntegerMESA(dpy, screen, renderer, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryRendererStringMESA(DisplayPtr, int, int, int)"/>
            public static unsafe string? QueryRendererStringMESA(DisplayPtr dpy, int screen, int renderer, int attribute)
            {
                string? returnValue_str;
                byte* returnValue;
                returnValue = QueryRendererStringMESA_(dpy, screen, renderer, attribute);
                returnValue_str = Marshal.PtrToStringAnsi((IntPtr)returnValue);
                return returnValue_str;
            }
        }
        public static unsafe partial class NV
        {
            /// <inheritdoc cref="BindVideoDeviceNV(DisplayPtr, uint, uint, int*)"/>
            public static unsafe int BindVideoDeviceNV(DisplayPtr dpy, uint video_slot, uint video_device, ReadOnlySpan<int> attrib_list)
            {
                int returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = BindVideoDeviceNV(dpy, video_slot, video_device, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindVideoDeviceNV(DisplayPtr, uint, uint, int*)"/>
            public static unsafe int BindVideoDeviceNV(DisplayPtr dpy, uint video_slot, uint video_device, int[] attrib_list)
            {
                int returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = BindVideoDeviceNV(dpy, video_slot, video_device, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="BindVideoDeviceNV(DisplayPtr, uint, uint, int*)"/>
            public static unsafe int BindVideoDeviceNV(DisplayPtr dpy, uint video_slot, uint video_device, ref readonly int attrib_list)
            {
                int returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = BindVideoDeviceNV(dpy, video_slot, video_device, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoCaptureDevicesNV(DisplayPtr, int, int*)"/>
            public static unsafe GLXVideoCaptureDeviceNV* EnumerateVideoCaptureDevicesNV(DisplayPtr dpy, int screen, Span<int> nelements)
            {
                GLXVideoCaptureDeviceNV* returnValue;
                fixed (int* nelements_ptr = nelements)
                {
                    returnValue = EnumerateVideoCaptureDevicesNV(dpy, screen, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoCaptureDevicesNV(DisplayPtr, int, int*)"/>
            public static unsafe GLXVideoCaptureDeviceNV* EnumerateVideoCaptureDevicesNV(DisplayPtr dpy, int screen, int[] nelements)
            {
                GLXVideoCaptureDeviceNV* returnValue;
                fixed (int* nelements_ptr = nelements)
                {
                    returnValue = EnumerateVideoCaptureDevicesNV(dpy, screen, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoCaptureDevicesNV(DisplayPtr, int, int*)"/>
            public static unsafe GLXVideoCaptureDeviceNV* EnumerateVideoCaptureDevicesNV(DisplayPtr dpy, int screen, ref int nelements)
            {
                GLXVideoCaptureDeviceNV* returnValue;
                fixed (int* nelements_ptr = &nelements)
                {
                    returnValue = EnumerateVideoCaptureDevicesNV(dpy, screen, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoDevicesNV(DisplayPtr, int, int*)"/>
            public static unsafe uint* EnumerateVideoDevicesNV(DisplayPtr dpy, int screen, Span<int> nelements)
            {
                uint* returnValue;
                fixed (int* nelements_ptr = nelements)
                {
                    returnValue = EnumerateVideoDevicesNV(dpy, screen, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoDevicesNV(DisplayPtr, int, int*)"/>
            public static unsafe uint* EnumerateVideoDevicesNV(DisplayPtr dpy, int screen, int[] nelements)
            {
                uint* returnValue;
                fixed (int* nelements_ptr = nelements)
                {
                    returnValue = EnumerateVideoDevicesNV(dpy, screen, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="EnumerateVideoDevicesNV(DisplayPtr, int, int*)"/>
            public static unsafe uint* EnumerateVideoDevicesNV(DisplayPtr dpy, int screen, ref int nelements)
            {
                uint* returnValue;
                fixed (int* nelements_ptr = &nelements)
                {
                    returnValue = EnumerateVideoDevicesNV(dpy, screen, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoDeviceNV(DisplayPtr, int, int, GLXVideoDeviceNV*)"/>
            public static unsafe int GetVideoDeviceNV(DisplayPtr dpy, int screen, int numVideoDevices, Span<GLXVideoDeviceNV> pVideoDevice)
            {
                int returnValue;
                fixed (GLXVideoDeviceNV* pVideoDevice_ptr = pVideoDevice)
                {
                    returnValue = GetVideoDeviceNV(dpy, screen, numVideoDevices, pVideoDevice_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoDeviceNV(DisplayPtr, int, int, GLXVideoDeviceNV*)"/>
            public static unsafe int GetVideoDeviceNV(DisplayPtr dpy, int screen, int numVideoDevices, GLXVideoDeviceNV[] pVideoDevice)
            {
                int returnValue;
                fixed (GLXVideoDeviceNV* pVideoDevice_ptr = pVideoDevice)
                {
                    returnValue = GetVideoDeviceNV(dpy, screen, numVideoDevices, pVideoDevice_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoDeviceNV(DisplayPtr, int, int, GLXVideoDeviceNV*)"/>
            public static unsafe int GetVideoDeviceNV(DisplayPtr dpy, int screen, int numVideoDevices, ref GLXVideoDeviceNV pVideoDevice)
            {
                int returnValue;
                fixed (GLXVideoDeviceNV* pVideoDevice_ptr = &pVideoDevice)
                {
                    returnValue = GetVideoDeviceNV(dpy, screen, numVideoDevices, pVideoDevice_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoInfoNV(DisplayPtr, int, GLXVideoDeviceNV, ulong*, ulong*)"/>
            public static unsafe int GetVideoInfoNV(DisplayPtr dpy, int screen, GLXVideoDeviceNV VideoDevice, Span<ulong> pulCounterOutputPbuffer, Span<ulong> pulCounterOutputVideo)
            {
                int returnValue;
                fixed (ulong* pulCounterOutputVideo_ptr = pulCounterOutputVideo)
                {
                    fixed (ulong* pulCounterOutputPbuffer_ptr = pulCounterOutputPbuffer)
                    {
                        returnValue = GetVideoInfoNV(dpy, screen, VideoDevice, pulCounterOutputPbuffer_ptr, pulCounterOutputVideo_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoInfoNV(DisplayPtr, int, GLXVideoDeviceNV, ulong*, ulong*)"/>
            public static unsafe int GetVideoInfoNV(DisplayPtr dpy, int screen, GLXVideoDeviceNV VideoDevice, ulong[] pulCounterOutputPbuffer, ulong[] pulCounterOutputVideo)
            {
                int returnValue;
                fixed (ulong* pulCounterOutputVideo_ptr = pulCounterOutputVideo)
                {
                    fixed (ulong* pulCounterOutputPbuffer_ptr = pulCounterOutputPbuffer)
                    {
                        returnValue = GetVideoInfoNV(dpy, screen, VideoDevice, pulCounterOutputPbuffer_ptr, pulCounterOutputVideo_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoInfoNV(DisplayPtr, int, GLXVideoDeviceNV, ulong*, ulong*)"/>
            public static unsafe int GetVideoInfoNV(DisplayPtr dpy, int screen, GLXVideoDeviceNV VideoDevice, ref ulong pulCounterOutputPbuffer, ref ulong pulCounterOutputVideo)
            {
                int returnValue;
                fixed (ulong* pulCounterOutputPbuffer_ptr = &pulCounterOutputPbuffer)
                fixed (ulong* pulCounterOutputVideo_ptr = &pulCounterOutputVideo)
                {
                    returnValue = GetVideoInfoNV(dpy, screen, VideoDevice, pulCounterOutputPbuffer_ptr, pulCounterOutputVideo_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryFrameCountNV(DisplayPtr, int, uint*)"/>
            public static unsafe bool QueryFrameCountNV(DisplayPtr dpy, int screen, Span<uint> count)
            {
                bool returnValue;
                fixed (uint* count_ptr = count)
                {
                    returnValue = QueryFrameCountNV(dpy, screen, count_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryFrameCountNV(DisplayPtr, int, uint*)"/>
            public static unsafe bool QueryFrameCountNV(DisplayPtr dpy, int screen, uint[] count)
            {
                bool returnValue;
                fixed (uint* count_ptr = count)
                {
                    returnValue = QueryFrameCountNV(dpy, screen, count_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryFrameCountNV(DisplayPtr, int, uint*)"/>
            public static unsafe bool QueryFrameCountNV(DisplayPtr dpy, int screen, ref uint count)
            {
                bool returnValue;
                fixed (uint* count_ptr = &count)
                {
                    returnValue = QueryFrameCountNV(dpy, screen, count_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapGroupsNV(DisplayPtr, int, uint*, uint*)"/>
            public static unsafe bool QueryMaxSwapGroupsNV(DisplayPtr dpy, int screen, Span<uint> maxGroups, Span<uint> maxBarriers)
            {
                bool returnValue;
                fixed (uint* maxBarriers_ptr = maxBarriers)
                {
                    fixed (uint* maxGroups_ptr = maxGroups)
                    {
                        returnValue = QueryMaxSwapGroupsNV(dpy, screen, maxGroups_ptr, maxBarriers_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapGroupsNV(DisplayPtr, int, uint*, uint*)"/>
            public static unsafe bool QueryMaxSwapGroupsNV(DisplayPtr dpy, int screen, uint[] maxGroups, uint[] maxBarriers)
            {
                bool returnValue;
                fixed (uint* maxBarriers_ptr = maxBarriers)
                {
                    fixed (uint* maxGroups_ptr = maxGroups)
                    {
                        returnValue = QueryMaxSwapGroupsNV(dpy, screen, maxGroups_ptr, maxBarriers_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapGroupsNV(DisplayPtr, int, uint*, uint*)"/>
            public static unsafe bool QueryMaxSwapGroupsNV(DisplayPtr dpy, int screen, ref uint maxGroups, ref uint maxBarriers)
            {
                bool returnValue;
                fixed (uint* maxGroups_ptr = &maxGroups)
                fixed (uint* maxBarriers_ptr = &maxBarriers)
                {
                    returnValue = QueryMaxSwapGroupsNV(dpy, screen, maxGroups_ptr, maxBarriers_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QuerySwapGroupNV(DisplayPtr, GLXDrawable, uint*, uint*)"/>
            public static unsafe bool QuerySwapGroupNV(DisplayPtr dpy, GLXDrawable drawable, Span<uint> group, Span<uint> barrier)
            {
                bool returnValue;
                fixed (uint* barrier_ptr = barrier)
                {
                    fixed (uint* group_ptr = group)
                    {
                        returnValue = QuerySwapGroupNV(dpy, drawable, group_ptr, barrier_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QuerySwapGroupNV(DisplayPtr, GLXDrawable, uint*, uint*)"/>
            public static unsafe bool QuerySwapGroupNV(DisplayPtr dpy, GLXDrawable drawable, uint[] group, uint[] barrier)
            {
                bool returnValue;
                fixed (uint* barrier_ptr = barrier)
                {
                    fixed (uint* group_ptr = group)
                    {
                        returnValue = QuerySwapGroupNV(dpy, drawable, group_ptr, barrier_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QuerySwapGroupNV(DisplayPtr, GLXDrawable, uint*, uint*)"/>
            public static unsafe bool QuerySwapGroupNV(DisplayPtr dpy, GLXDrawable drawable, ref uint group, ref uint barrier)
            {
                bool returnValue;
                fixed (uint* group_ptr = &group)
                fixed (uint* barrier_ptr = &barrier)
                {
                    returnValue = QuerySwapGroupNV(dpy, drawable, group_ptr, barrier_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryVideoCaptureDeviceNV(DisplayPtr, GLXVideoCaptureDeviceNV, int, int*)"/>
            public static unsafe int QueryVideoCaptureDeviceNV(DisplayPtr dpy, GLXVideoCaptureDeviceNV device, int attribute, Span<int> value)
            {
                int returnValue;
                fixed (int* value_ptr = value)
                {
                    returnValue = QueryVideoCaptureDeviceNV(dpy, device, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryVideoCaptureDeviceNV(DisplayPtr, GLXVideoCaptureDeviceNV, int, int*)"/>
            public static unsafe int QueryVideoCaptureDeviceNV(DisplayPtr dpy, GLXVideoCaptureDeviceNV device, int attribute, int[] value)
            {
                int returnValue;
                fixed (int* value_ptr = value)
                {
                    returnValue = QueryVideoCaptureDeviceNV(dpy, device, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryVideoCaptureDeviceNV(DisplayPtr, GLXVideoCaptureDeviceNV, int, int*)"/>
            public static unsafe int QueryVideoCaptureDeviceNV(DisplayPtr dpy, GLXVideoCaptureDeviceNV device, int attribute, ref int value)
            {
                int returnValue;
                fixed (int* value_ptr = &value)
                {
                    returnValue = QueryVideoCaptureDeviceNV(dpy, device, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SendPbufferToVideoNV(DisplayPtr, GLXPbuffer, int, ulong*, bool)"/>
            public static unsafe int SendPbufferToVideoNV(DisplayPtr dpy, GLXPbuffer pbuf, int iBufferType, Span<ulong> pulCounterPbuffer, bool bBlock)
            {
                int returnValue;
                fixed (ulong* pulCounterPbuffer_ptr = pulCounterPbuffer)
                {
                    returnValue = SendPbufferToVideoNV(dpy, pbuf, iBufferType, pulCounterPbuffer_ptr, bBlock);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SendPbufferToVideoNV(DisplayPtr, GLXPbuffer, int, ulong*, bool)"/>
            public static unsafe int SendPbufferToVideoNV(DisplayPtr dpy, GLXPbuffer pbuf, int iBufferType, ulong[] pulCounterPbuffer, bool bBlock)
            {
                int returnValue;
                fixed (ulong* pulCounterPbuffer_ptr = pulCounterPbuffer)
                {
                    returnValue = SendPbufferToVideoNV(dpy, pbuf, iBufferType, pulCounterPbuffer_ptr, bBlock);
                }
                return returnValue;
            }
            /// <inheritdoc cref="SendPbufferToVideoNV(DisplayPtr, GLXPbuffer, int, ulong*, bool)"/>
            public static unsafe int SendPbufferToVideoNV(DisplayPtr dpy, GLXPbuffer pbuf, int iBufferType, ref ulong pulCounterPbuffer, bool bBlock)
            {
                int returnValue;
                fixed (ulong* pulCounterPbuffer_ptr = &pulCounterPbuffer)
                {
                    returnValue = SendPbufferToVideoNV(dpy, pbuf, iBufferType, pulCounterPbuffer_ptr, bBlock);
                }
                return returnValue;
            }
        }
        public static unsafe partial class OML
        {
            /// <inheritdoc cref="GetMscRateOML(DisplayPtr, GLXDrawable, int*, int*)"/>
            public static unsafe bool GetMscRateOML(DisplayPtr dpy, GLXDrawable drawable, Span<int> numerator, Span<int> denominator)
            {
                bool returnValue;
                fixed (int* denominator_ptr = denominator)
                {
                    fixed (int* numerator_ptr = numerator)
                    {
                        returnValue = GetMscRateOML(dpy, drawable, numerator_ptr, denominator_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMscRateOML(DisplayPtr, GLXDrawable, int*, int*)"/>
            public static unsafe bool GetMscRateOML(DisplayPtr dpy, GLXDrawable drawable, int[] numerator, int[] denominator)
            {
                bool returnValue;
                fixed (int* denominator_ptr = denominator)
                {
                    fixed (int* numerator_ptr = numerator)
                    {
                        returnValue = GetMscRateOML(dpy, drawable, numerator_ptr, denominator_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetMscRateOML(DisplayPtr, GLXDrawable, int*, int*)"/>
            public static unsafe bool GetMscRateOML(DisplayPtr dpy, GLXDrawable drawable, ref int numerator, ref int denominator)
            {
                bool returnValue;
                fixed (int* numerator_ptr = &numerator)
                fixed (int* denominator_ptr = &denominator)
                {
                    returnValue = GetMscRateOML(dpy, drawable, numerator_ptr, denominator_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSyncValuesOML(DisplayPtr, GLXDrawable, long*, long*, long*)"/>
            public static unsafe bool GetSyncValuesOML(DisplayPtr dpy, GLXDrawable drawable, Span<long> ust, Span<long> msc, Span<long> sbc)
            {
                bool returnValue;
                fixed (long* sbc_ptr = sbc)
                {
                    fixed (long* msc_ptr = msc)
                    {
                        fixed (long* ust_ptr = ust)
                        {
                            returnValue = GetSyncValuesOML(dpy, drawable, ust_ptr, msc_ptr, sbc_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSyncValuesOML(DisplayPtr, GLXDrawable, long*, long*, long*)"/>
            public static unsafe bool GetSyncValuesOML(DisplayPtr dpy, GLXDrawable drawable, long[] ust, long[] msc, long[] sbc)
            {
                bool returnValue;
                fixed (long* sbc_ptr = sbc)
                {
                    fixed (long* msc_ptr = msc)
                    {
                        fixed (long* ust_ptr = ust)
                        {
                            returnValue = GetSyncValuesOML(dpy, drawable, ust_ptr, msc_ptr, sbc_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSyncValuesOML(DisplayPtr, GLXDrawable, long*, long*, long*)"/>
            public static unsafe bool GetSyncValuesOML(DisplayPtr dpy, GLXDrawable drawable, ref long ust, ref long msc, ref long sbc)
            {
                bool returnValue;
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    returnValue = GetSyncValuesOML(dpy, drawable, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForMscOML(DisplayPtr, GLXDrawable, long, long, long, long*, long*, long*)"/>
            public static unsafe bool WaitForMscOML(DisplayPtr dpy, GLXDrawable drawable, long target_msc, long divisor, long remainder, Span<long> ust, Span<long> msc, Span<long> sbc)
            {
                bool returnValue;
                fixed (long* sbc_ptr = sbc)
                {
                    fixed (long* msc_ptr = msc)
                    {
                        fixed (long* ust_ptr = ust)
                        {
                            returnValue = WaitForMscOML(dpy, drawable, target_msc, divisor, remainder, ust_ptr, msc_ptr, sbc_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForMscOML(DisplayPtr, GLXDrawable, long, long, long, long*, long*, long*)"/>
            public static unsafe bool WaitForMscOML(DisplayPtr dpy, GLXDrawable drawable, long target_msc, long divisor, long remainder, long[] ust, long[] msc, long[] sbc)
            {
                bool returnValue;
                fixed (long* sbc_ptr = sbc)
                {
                    fixed (long* msc_ptr = msc)
                    {
                        fixed (long* ust_ptr = ust)
                        {
                            returnValue = WaitForMscOML(dpy, drawable, target_msc, divisor, remainder, ust_ptr, msc_ptr, sbc_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForMscOML(DisplayPtr, GLXDrawable, long, long, long, long*, long*, long*)"/>
            public static unsafe bool WaitForMscOML(DisplayPtr dpy, GLXDrawable drawable, long target_msc, long divisor, long remainder, ref long ust, ref long msc, ref long sbc)
            {
                bool returnValue;
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    returnValue = WaitForMscOML(dpy, drawable, target_msc, divisor, remainder, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForSbcOML(DisplayPtr, GLXDrawable, long, long*, long*, long*)"/>
            public static unsafe bool WaitForSbcOML(DisplayPtr dpy, GLXDrawable drawable, long target_sbc, Span<long> ust, Span<long> msc, Span<long> sbc)
            {
                bool returnValue;
                fixed (long* sbc_ptr = sbc)
                {
                    fixed (long* msc_ptr = msc)
                    {
                        fixed (long* ust_ptr = ust)
                        {
                            returnValue = WaitForSbcOML(dpy, drawable, target_sbc, ust_ptr, msc_ptr, sbc_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForSbcOML(DisplayPtr, GLXDrawable, long, long*, long*, long*)"/>
            public static unsafe bool WaitForSbcOML(DisplayPtr dpy, GLXDrawable drawable, long target_sbc, long[] ust, long[] msc, long[] sbc)
            {
                bool returnValue;
                fixed (long* sbc_ptr = sbc)
                {
                    fixed (long* msc_ptr = msc)
                    {
                        fixed (long* ust_ptr = ust)
                        {
                            returnValue = WaitForSbcOML(dpy, drawable, target_sbc, ust_ptr, msc_ptr, sbc_ptr);
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitForSbcOML(DisplayPtr, GLXDrawable, long, long*, long*, long*)"/>
            public static unsafe bool WaitForSbcOML(DisplayPtr dpy, GLXDrawable drawable, long target_sbc, ref long ust, ref long msc, ref long sbc)
            {
                bool returnValue;
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    returnValue = WaitForSbcOML(dpy, drawable, target_sbc, ust_ptr, msc_ptr, sbc_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class SGI
        {
            /// <inheritdoc cref="GetVideoSyncSGI(uint*)"/>
            public static unsafe int GetVideoSyncSGI(Span<uint> count)
            {
                int returnValue;
                fixed (uint* count_ptr = count)
                {
                    returnValue = GetVideoSyncSGI(count_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetVideoSyncSGI(uint*)"/>
            public static unsafe int GetVideoSyncSGI(uint[] count)
            {
                int returnValue;
                fixed (uint* count_ptr = count)
                {
                    returnValue = GetVideoSyncSGI(count_ptr);
                }
                return returnValue;
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
            /// <inheritdoc cref="WaitVideoSyncSGI(int, int, uint*)"/>
            public static unsafe int WaitVideoSyncSGI(int divisor, int remainder, Span<uint> count)
            {
                int returnValue;
                fixed (uint* count_ptr = count)
                {
                    returnValue = WaitVideoSyncSGI(divisor, remainder, count_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="WaitVideoSyncSGI(int, int, uint*)"/>
            public static unsafe int WaitVideoSyncSGI(int divisor, int remainder, uint[] count)
            {
                int returnValue;
                fixed (uint* count_ptr = count)
                {
                    returnValue = WaitVideoSyncSGI(divisor, remainder, count_ptr);
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
            /// <inheritdoc cref="ChooseFBConfigSGIX(DisplayPtr, int, int*, int*)"/>
            public static unsafe GLXFBConfigSGIX* ChooseFBConfigSGIX(DisplayPtr dpy, int screen, Span<int> attrib_list, Span<int> nelements)
            {
                GLXFBConfigSGIX* returnValue;
                fixed (int* nelements_ptr = nelements)
                {
                    fixed (int* attrib_list_ptr = attrib_list)
                    {
                        returnValue = ChooseFBConfigSGIX(dpy, screen, attrib_list_ptr, nelements_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="ChooseFBConfigSGIX(DisplayPtr, int, int*, int*)"/>
            public static unsafe GLXFBConfigSGIX* ChooseFBConfigSGIX(DisplayPtr dpy, int screen, int[] attrib_list, int[] nelements)
            {
                GLXFBConfigSGIX* returnValue;
                fixed (int* nelements_ptr = nelements)
                {
                    fixed (int* attrib_list_ptr = attrib_list)
                    {
                        returnValue = ChooseFBConfigSGIX(dpy, screen, attrib_list_ptr, nelements_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="ChooseFBConfigSGIX(DisplayPtr, int, int*, int*)"/>
            public static unsafe GLXFBConfigSGIX* ChooseFBConfigSGIX(DisplayPtr dpy, int screen, ref int attrib_list, ref int nelements)
            {
                GLXFBConfigSGIX* returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                fixed (int* nelements_ptr = &nelements)
                {
                    returnValue = ChooseFBConfigSGIX(dpy, screen, attrib_list_ptr, nelements_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateGLXPbufferSGIX(DisplayPtr, GLXFBConfigSGIX, uint, uint, int*)"/>
            public static unsafe GLXPbufferSGIX CreateGLXPbufferSGIX(DisplayPtr dpy, GLXFBConfigSGIX config, uint width, uint height, Span<int> attrib_list)
            {
                GLXPbufferSGIX returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateGLXPbufferSGIX(dpy, config, width, height, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateGLXPbufferSGIX(DisplayPtr, GLXFBConfigSGIX, uint, uint, int*)"/>
            public static unsafe GLXPbufferSGIX CreateGLXPbufferSGIX(DisplayPtr dpy, GLXFBConfigSGIX config, uint width, uint height, int[] attrib_list)
            {
                GLXPbufferSGIX returnValue;
                fixed (int* attrib_list_ptr = attrib_list)
                {
                    returnValue = CreateGLXPbufferSGIX(dpy, config, width, height, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="CreateGLXPbufferSGIX(DisplayPtr, GLXFBConfigSGIX, uint, uint, int*)"/>
            public static unsafe GLXPbufferSGIX CreateGLXPbufferSGIX(DisplayPtr dpy, GLXFBConfigSGIX config, uint width, uint height, ref int attrib_list)
            {
                GLXPbufferSGIX returnValue;
                fixed (int* attrib_list_ptr = &attrib_list)
                {
                    returnValue = CreateGLXPbufferSGIX(dpy, config, width, height, attrib_list_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetFBConfigAttribSGIX(DisplayPtr, GLXFBConfigSGIX, int, int*)"/>
            public static unsafe int GetFBConfigAttribSGIX(DisplayPtr dpy, GLXFBConfigSGIX config, int attribute, Span<int> value)
            {
                int returnValue;
                fixed (int* value_ptr = value)
                {
                    returnValue = GetFBConfigAttribSGIX(dpy, config, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetFBConfigAttribSGIX(DisplayPtr, GLXFBConfigSGIX, int, int*)"/>
            public static unsafe int GetFBConfigAttribSGIX(DisplayPtr dpy, GLXFBConfigSGIX config, int attribute, int[] value)
            {
                int returnValue;
                fixed (int* value_ptr = value)
                {
                    returnValue = GetFBConfigAttribSGIX(dpy, config, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetFBConfigAttribSGIX(DisplayPtr, GLXFBConfigSGIX, int, int*)"/>
            public static unsafe int GetFBConfigAttribSGIX(DisplayPtr dpy, GLXFBConfigSGIX config, int attribute, ref int value)
            {
                int returnValue;
                fixed (int* value_ptr = &value)
                {
                    returnValue = GetFBConfigAttribSGIX(dpy, config, attribute, value_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetSelectedEventSGIX(DisplayPtr, GLXDrawable, ulong*)"/>
            public static unsafe void GetSelectedEventSGIX(DisplayPtr dpy, GLXDrawable drawable, Span<ulong> mask)
            {
                fixed (ulong* mask_ptr = mask)
                {
                    GetSelectedEventSGIX(dpy, drawable, mask_ptr);
                }
            }
            /// <inheritdoc cref="GetSelectedEventSGIX(DisplayPtr, GLXDrawable, ulong*)"/>
            public static unsafe void GetSelectedEventSGIX(DisplayPtr dpy, GLXDrawable drawable, ulong[] mask)
            {
                fixed (ulong* mask_ptr = mask)
                {
                    GetSelectedEventSGIX(dpy, drawable, mask_ptr);
                }
            }
            /// <inheritdoc cref="GetSelectedEventSGIX(DisplayPtr, GLXDrawable, ulong*)"/>
            public static unsafe void GetSelectedEventSGIX(DisplayPtr dpy, GLXDrawable drawable, ref ulong mask)
            {
                fixed (ulong* mask_ptr = &mask)
                {
                    GetSelectedEventSGIX(dpy, drawable, mask_ptr);
                }
            }
            /// <inheritdoc cref="HyperpipeAttribSGIX(DisplayPtr, int, int, int, void*)"/>
            public static unsafe int HyperpipeAttribSGIX(DisplayPtr dpy, int timeSlice, int attrib, int size, IntPtr attribList)
            {
                int returnValue;
                void* attribList_vptr = (void*)attribList;
                returnValue = HyperpipeAttribSGIX(dpy, timeSlice, attrib, size, attribList_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeAttribSGIX(DisplayPtr, int, int, int, void*)"/>
            public static unsafe int HyperpipeAttribSGIX<T1>(DisplayPtr dpy, int timeSlice, int attrib, int size, Span<T1> attribList)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* attribList_ptr = attribList)
                {
                    returnValue = HyperpipeAttribSGIX(dpy, timeSlice, attrib, size, attribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeAttribSGIX(DisplayPtr, int, int, int, void*)"/>
            public static unsafe int HyperpipeAttribSGIX<T1>(DisplayPtr dpy, int timeSlice, int attrib, int size, T1[] attribList)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* attribList_ptr = attribList)
                {
                    returnValue = HyperpipeAttribSGIX(dpy, timeSlice, attrib, size, attribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeAttribSGIX(DisplayPtr, int, int, int, void*)"/>
            public static unsafe int HyperpipeAttribSGIX<T1>(DisplayPtr dpy, int timeSlice, int attrib, int size, ref T1 attribList)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* attribList_ptr = &attribList)
                {
                    returnValue = HyperpipeAttribSGIX(dpy, timeSlice, attrib, size, attribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeConfigSGIX(DisplayPtr, int, int, GLXHyperpipeConfigSGIX*, int*)"/>
            public static unsafe int HyperpipeConfigSGIX(DisplayPtr dpy, int networkId, int npipes, Span<GLXHyperpipeConfigSGIX> cfg, Span<int> hpId)
            {
                int returnValue;
                fixed (int* hpId_ptr = hpId)
                {
                    fixed (GLXHyperpipeConfigSGIX* cfg_ptr = cfg)
                    {
                        returnValue = HyperpipeConfigSGIX(dpy, networkId, npipes, cfg_ptr, hpId_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeConfigSGIX(DisplayPtr, int, int, GLXHyperpipeConfigSGIX*, int*)"/>
            public static unsafe int HyperpipeConfigSGIX(DisplayPtr dpy, int networkId, int npipes, GLXHyperpipeConfigSGIX[] cfg, int[] hpId)
            {
                int returnValue;
                fixed (int* hpId_ptr = hpId)
                {
                    fixed (GLXHyperpipeConfigSGIX* cfg_ptr = cfg)
                    {
                        returnValue = HyperpipeConfigSGIX(dpy, networkId, npipes, cfg_ptr, hpId_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="HyperpipeConfigSGIX(DisplayPtr, int, int, GLXHyperpipeConfigSGIX*, int*)"/>
            public static unsafe int HyperpipeConfigSGIX(DisplayPtr dpy, int networkId, int npipes, ref GLXHyperpipeConfigSGIX cfg, ref int hpId)
            {
                int returnValue;
                fixed (GLXHyperpipeConfigSGIX* cfg_ptr = &cfg)
                fixed (int* hpId_ptr = &hpId)
                {
                    returnValue = HyperpipeConfigSGIX(dpy, networkId, npipes, cfg_ptr, hpId_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryChannelDeltasSGIX(DisplayPtr, int, int, int*, int*, int*, int*)"/>
            public static unsafe int QueryChannelDeltasSGIX(DisplayPtr display, int screen, int channel, Span<int> x, Span<int> y, Span<int> w, Span<int> h)
            {
                int returnValue;
                fixed (int* h_ptr = h)
                {
                    fixed (int* w_ptr = w)
                    {
                        fixed (int* y_ptr = y)
                        {
                            fixed (int* x_ptr = x)
                            {
                                returnValue = QueryChannelDeltasSGIX(display, screen, channel, x_ptr, y_ptr, w_ptr, h_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryChannelDeltasSGIX(DisplayPtr, int, int, int*, int*, int*, int*)"/>
            public static unsafe int QueryChannelDeltasSGIX(DisplayPtr display, int screen, int channel, int[] x, int[] y, int[] w, int[] h)
            {
                int returnValue;
                fixed (int* h_ptr = h)
                {
                    fixed (int* w_ptr = w)
                    {
                        fixed (int* y_ptr = y)
                        {
                            fixed (int* x_ptr = x)
                            {
                                returnValue = QueryChannelDeltasSGIX(display, screen, channel, x_ptr, y_ptr, w_ptr, h_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryChannelDeltasSGIX(DisplayPtr, int, int, int*, int*, int*, int*)"/>
            public static unsafe int QueryChannelDeltasSGIX(DisplayPtr display, int screen, int channel, ref int x, ref int y, ref int w, ref int h)
            {
                int returnValue;
                fixed (int* x_ptr = &x)
                fixed (int* y_ptr = &y)
                fixed (int* w_ptr = &w)
                fixed (int* h_ptr = &h)
                {
                    returnValue = QueryChannelDeltasSGIX(display, screen, channel, x_ptr, y_ptr, w_ptr, h_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryChannelRectSGIX(DisplayPtr, int, int, int*, int*, int*, int*)"/>
            public static unsafe int QueryChannelRectSGIX(DisplayPtr display, int screen, int channel, Span<int> dx, Span<int> dy, Span<int> dw, Span<int> dh)
            {
                int returnValue;
                fixed (int* dh_ptr = dh)
                {
                    fixed (int* dw_ptr = dw)
                    {
                        fixed (int* dy_ptr = dy)
                        {
                            fixed (int* dx_ptr = dx)
                            {
                                returnValue = QueryChannelRectSGIX(display, screen, channel, dx_ptr, dy_ptr, dw_ptr, dh_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryChannelRectSGIX(DisplayPtr, int, int, int*, int*, int*, int*)"/>
            public static unsafe int QueryChannelRectSGIX(DisplayPtr display, int screen, int channel, int[] dx, int[] dy, int[] dw, int[] dh)
            {
                int returnValue;
                fixed (int* dh_ptr = dh)
                {
                    fixed (int* dw_ptr = dw)
                    {
                        fixed (int* dy_ptr = dy)
                        {
                            fixed (int* dx_ptr = dx)
                            {
                                returnValue = QueryChannelRectSGIX(display, screen, channel, dx_ptr, dy_ptr, dw_ptr, dh_ptr);
                            }
                        }
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryChannelRectSGIX(DisplayPtr, int, int, int*, int*, int*, int*)"/>
            public static unsafe int QueryChannelRectSGIX(DisplayPtr display, int screen, int channel, ref int dx, ref int dy, ref int dw, ref int dh)
            {
                int returnValue;
                fixed (int* dx_ptr = &dx)
                fixed (int* dy_ptr = &dy)
                fixed (int* dw_ptr = &dw)
                fixed (int* dh_ptr = &dh)
                {
                    returnValue = QueryChannelRectSGIX(display, screen, channel, dx_ptr, dy_ptr, dw_ptr, dh_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryGLXPbufferSGIX(DisplayPtr, GLXPbufferSGIX, int, uint*)"/>
            public static unsafe void QueryGLXPbufferSGIX(DisplayPtr dpy, GLXPbufferSGIX pbuf, int attribute, Span<uint> value)
            {
                fixed (uint* value_ptr = value)
                {
                    QueryGLXPbufferSGIX(dpy, pbuf, attribute, value_ptr);
                }
            }
            /// <inheritdoc cref="QueryGLXPbufferSGIX(DisplayPtr, GLXPbufferSGIX, int, uint*)"/>
            public static unsafe void QueryGLXPbufferSGIX(DisplayPtr dpy, GLXPbufferSGIX pbuf, int attribute, uint[] value)
            {
                fixed (uint* value_ptr = value)
                {
                    QueryGLXPbufferSGIX(dpy, pbuf, attribute, value_ptr);
                }
            }
            /// <inheritdoc cref="QueryGLXPbufferSGIX(DisplayPtr, GLXPbufferSGIX, int, uint*)"/>
            public static unsafe void QueryGLXPbufferSGIX(DisplayPtr dpy, GLXPbufferSGIX pbuf, int attribute, ref uint value)
            {
                fixed (uint* value_ptr = &value)
                {
                    QueryGLXPbufferSGIX(dpy, pbuf, attribute, value_ptr);
                }
            }
            /// <inheritdoc cref="QueryHyperpipeAttribSGIX(DisplayPtr, int, int, int, void*)"/>
            public static unsafe int QueryHyperpipeAttribSGIX(DisplayPtr dpy, int timeSlice, int attrib, int size, IntPtr returnAttribList)
            {
                int returnValue;
                void* returnAttribList_vptr = (void*)returnAttribList;
                returnValue = QueryHyperpipeAttribSGIX(dpy, timeSlice, attrib, size, returnAttribList_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeAttribSGIX(DisplayPtr, int, int, int, void*)"/>
            public static unsafe int QueryHyperpipeAttribSGIX<T1>(DisplayPtr dpy, int timeSlice, int attrib, int size, Span<T1> returnAttribList)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* returnAttribList_ptr = returnAttribList)
                {
                    returnValue = QueryHyperpipeAttribSGIX(dpy, timeSlice, attrib, size, returnAttribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeAttribSGIX(DisplayPtr, int, int, int, void*)"/>
            public static unsafe int QueryHyperpipeAttribSGIX<T1>(DisplayPtr dpy, int timeSlice, int attrib, int size, T1[] returnAttribList)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* returnAttribList_ptr = returnAttribList)
                {
                    returnValue = QueryHyperpipeAttribSGIX(dpy, timeSlice, attrib, size, returnAttribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeAttribSGIX(DisplayPtr, int, int, int, void*)"/>
            public static unsafe int QueryHyperpipeAttribSGIX<T1>(DisplayPtr dpy, int timeSlice, int attrib, int size, ref T1 returnAttribList)
                where T1 : unmanaged
            {
                int returnValue;
                fixed (void* returnAttribList_ptr = &returnAttribList)
                {
                    returnValue = QueryHyperpipeAttribSGIX(dpy, timeSlice, attrib, size, returnAttribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeBestAttribSGIX(DisplayPtr, int, int, int, void*, void*)"/>
            public static unsafe int QueryHyperpipeBestAttribSGIX(DisplayPtr dpy, int timeSlice, int attrib, int size, IntPtr attribList, IntPtr returnAttribList)
            {
                int returnValue;
                void* attribList_vptr = (void*)attribList;
                void* returnAttribList_vptr = (void*)returnAttribList;
                returnValue = QueryHyperpipeBestAttribSGIX(dpy, timeSlice, attrib, size, attribList_vptr, returnAttribList_vptr);
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeBestAttribSGIX(DisplayPtr, int, int, int, void*, void*)"/>
            public static unsafe int QueryHyperpipeBestAttribSGIX<T1, T2>(DisplayPtr dpy, int timeSlice, int attrib, int size, Span<T1> attribList, Span<T2> returnAttribList)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (void* returnAttribList_ptr = returnAttribList)
                {
                    fixed (void* attribList_ptr = attribList)
                    {
                        returnValue = QueryHyperpipeBestAttribSGIX(dpy, timeSlice, attrib, size, attribList_ptr, returnAttribList_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeBestAttribSGIX(DisplayPtr, int, int, int, void*, void*)"/>
            public static unsafe int QueryHyperpipeBestAttribSGIX<T1, T2>(DisplayPtr dpy, int timeSlice, int attrib, int size, T1[] attribList, T2[] returnAttribList)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (void* returnAttribList_ptr = returnAttribList)
                {
                    fixed (void* attribList_ptr = attribList)
                    {
                        returnValue = QueryHyperpipeBestAttribSGIX(dpy, timeSlice, attrib, size, attribList_ptr, returnAttribList_ptr);
                    }
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeBestAttribSGIX(DisplayPtr, int, int, int, void*, void*)"/>
            public static unsafe int QueryHyperpipeBestAttribSGIX<T1, T2>(DisplayPtr dpy, int timeSlice, int attrib, int size, ref T1 attribList, ref T2 returnAttribList)
                where T1 : unmanaged
                where T2 : unmanaged
            {
                int returnValue;
                fixed (void* attribList_ptr = &attribList)
                fixed (void* returnAttribList_ptr = &returnAttribList)
                {
                    returnValue = QueryHyperpipeBestAttribSGIX(dpy, timeSlice, attrib, size, attribList_ptr, returnAttribList_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeConfigSGIX(DisplayPtr, int, int*)"/>
            public static unsafe GLXHyperpipeConfigSGIX* QueryHyperpipeConfigSGIX(DisplayPtr dpy, int hpId, Span<int> npipes)
            {
                GLXHyperpipeConfigSGIX* returnValue;
                fixed (int* npipes_ptr = npipes)
                {
                    returnValue = QueryHyperpipeConfigSGIX(dpy, hpId, npipes_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeConfigSGIX(DisplayPtr, int, int*)"/>
            public static unsafe GLXHyperpipeConfigSGIX* QueryHyperpipeConfigSGIX(DisplayPtr dpy, int hpId, int[] npipes)
            {
                GLXHyperpipeConfigSGIX* returnValue;
                fixed (int* npipes_ptr = npipes)
                {
                    returnValue = QueryHyperpipeConfigSGIX(dpy, hpId, npipes_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeConfigSGIX(DisplayPtr, int, int*)"/>
            public static unsafe GLXHyperpipeConfigSGIX* QueryHyperpipeConfigSGIX(DisplayPtr dpy, int hpId, ref int npipes)
            {
                GLXHyperpipeConfigSGIX* returnValue;
                fixed (int* npipes_ptr = &npipes)
                {
                    returnValue = QueryHyperpipeConfigSGIX(dpy, hpId, npipes_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeNetworkSGIX(DisplayPtr, int*)"/>
            public static unsafe GLXHyperpipeNetworkSGIX* QueryHyperpipeNetworkSGIX(DisplayPtr dpy, Span<int> npipes)
            {
                GLXHyperpipeNetworkSGIX* returnValue;
                fixed (int* npipes_ptr = npipes)
                {
                    returnValue = QueryHyperpipeNetworkSGIX(dpy, npipes_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeNetworkSGIX(DisplayPtr, int*)"/>
            public static unsafe GLXHyperpipeNetworkSGIX* QueryHyperpipeNetworkSGIX(DisplayPtr dpy, int[] npipes)
            {
                GLXHyperpipeNetworkSGIX* returnValue;
                fixed (int* npipes_ptr = npipes)
                {
                    returnValue = QueryHyperpipeNetworkSGIX(dpy, npipes_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryHyperpipeNetworkSGIX(DisplayPtr, int*)"/>
            public static unsafe GLXHyperpipeNetworkSGIX* QueryHyperpipeNetworkSGIX(DisplayPtr dpy, ref int npipes)
            {
                GLXHyperpipeNetworkSGIX* returnValue;
                fixed (int* npipes_ptr = &npipes)
                {
                    returnValue = QueryHyperpipeNetworkSGIX(dpy, npipes_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapBarriersSGIX(DisplayPtr, int, int*)"/>
            public static unsafe bool QueryMaxSwapBarriersSGIX(DisplayPtr dpy, int screen, Span<int> max)
            {
                bool returnValue;
                fixed (int* max_ptr = max)
                {
                    returnValue = QueryMaxSwapBarriersSGIX(dpy, screen, max_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapBarriersSGIX(DisplayPtr, int, int*)"/>
            public static unsafe bool QueryMaxSwapBarriersSGIX(DisplayPtr dpy, int screen, int[] max)
            {
                bool returnValue;
                fixed (int* max_ptr = max)
                {
                    returnValue = QueryMaxSwapBarriersSGIX(dpy, screen, max_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="QueryMaxSwapBarriersSGIX(DisplayPtr, int, int*)"/>
            public static unsafe bool QueryMaxSwapBarriersSGIX(DisplayPtr dpy, int screen, ref int max)
            {
                bool returnValue;
                fixed (int* max_ptr = &max)
                {
                    returnValue = QueryMaxSwapBarriersSGIX(dpy, screen, max_ptr);
                }
                return returnValue;
            }
        }
        public static unsafe partial class SUN
        {
            /// <inheritdoc cref="GetTransparentIndexSUN(DisplayPtr, Window, Window, ulong*)"/>
            public static unsafe int GetTransparentIndexSUN(DisplayPtr dpy, Window overlay, Window underlay, Span<ulong> pTransparentIndex)
            {
                int returnValue;
                fixed (ulong* pTransparentIndex_ptr = pTransparentIndex)
                {
                    returnValue = GetTransparentIndexSUN(dpy, overlay, underlay, pTransparentIndex_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetTransparentIndexSUN(DisplayPtr, Window, Window, ulong*)"/>
            public static unsafe int GetTransparentIndexSUN(DisplayPtr dpy, Window overlay, Window underlay, ulong[] pTransparentIndex)
            {
                int returnValue;
                fixed (ulong* pTransparentIndex_ptr = pTransparentIndex)
                {
                    returnValue = GetTransparentIndexSUN(dpy, overlay, underlay, pTransparentIndex_ptr);
                }
                return returnValue;
            }
            /// <inheritdoc cref="GetTransparentIndexSUN(DisplayPtr, Window, Window, ulong*)"/>
            public static unsafe int GetTransparentIndexSUN(DisplayPtr dpy, Window overlay, Window underlay, ref ulong pTransparentIndex)
            {
                int returnValue;
                fixed (ulong* pTransparentIndex_ptr = &pTransparentIndex)
                {
                    returnValue = GetTransparentIndexSUN(dpy, overlay, underlay, pTransparentIndex_ptr);
                }
                return returnValue;
            }
        }
    }
}

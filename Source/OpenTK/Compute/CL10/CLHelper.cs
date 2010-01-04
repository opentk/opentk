#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace OpenTK.Compute.CL10
{
    /// <summary>
    /// Provides access to the OpenCL 1.0 flat API.
    /// </summary>
    public sealed partial class CL : BindingsBase
    {
        #region Fields

        const string Library = "opencl.dll";
        static readonly object sync_root = new object();

        #endregion

        #region Constructors

        static CL()
        {
            Type imports = typeof(CL).GetNestedType("Core", BindingFlags.Static | BindingFlags.NonPublic);
            FieldInfo[] delegates = typeof(CL).GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic).GetFields(BindingFlags.Static | BindingFlags.NonPublic);
            if (delegates == null || imports == null)
                throw new Exception("[Internal Error] Failed to locate CL.Delegates. Please file a bug report at http://www.opentk.com/issues");

            for (int i = 0; i < delegates.Length; i++)
            {
                MethodInfo method = imports.GetMethod(delegates[i].Name.Substring(2), BindingFlags.Static | BindingFlags.NonPublic);
                Delegate @new = Delegate.CreateDelegate(delegates[i].FieldType, method);
                delegates[i].SetValue(null, @new);
            }
        }

        #endregion

        #region Protected Members

        /// <summary>
        /// Returns a synchronization token unique for the GL class.
        /// </summary>
        protected override object SyncRoot
        {
            get { return sync_root; }
        }

        /// <summary>
        /// Not supported yet.
        /// </summary>
        /// <param name="funcname">The name of the extension function.</param>
        /// <returns>A pointer to the extension function, if available; IntPtr.Zero otherwise.</returns>
        /// <remarks>
        /// <para>Use <see cref="System.Runtime.InteropServices.Marshal.GetDelegateForFunctionPointer"/> to turn this function pointer
        /// into a callable delegate.</para>
        /// <para>A non-zero return value does not mean that this extension function is supported. You also
        /// need to query available extensions through <see cref="GetDeviceInfo"/>.</para>
        /// <para>This method will always return IntPtr.Zero for core (i.e. non-extension) functions.</para>
        /// </remarks>
        protected override IntPtr GetAddress(string funcname)
        {
            throw new NotSupportedException();
            //CL.GetExtensionFunctionAddress
        }

        #endregion
        
        #region Helper Overrides
        
        public static unsafe IntPtr CreateContext(ContextProperties* properties, uint num_devices, IntPtr* devices, IntPtr pfn_notify, IntPtr user_data, OpenTK.Compute.CL10.ErrorCode* errcode_ret)
        {
            return CreateContext((IntPtr*)properties, num_devices, devices, pfn_notify, user_data, errcode_ret);
        }
        
        public static unsafe IntPtr CreateContext(ContextProperties[] properties, uint num_devices, IntPtr[] devices, IntPtr pfn_notify, IntPtr user_data, OpenTK.Compute.CL10.ErrorCode[] errcode_ret)
        {
            IntPtr[] properties_correct = properties != null ? new IntPtr[properties.Length] : null;
			for (int i = 0; i < properties_correct.Length; i++)
				properties_correct[i] = new IntPtr((int)properties[i]);
            return CreateContext(properties_correct, num_devices, devices, pfn_notify, user_data, errcode_ret);
        }
        
        public static unsafe IntPtr CreateContext(ref ContextProperties properties, uint num_devices, ref IntPtr devices, IntPtr pfn_notify, IntPtr user_data, out OpenTK.Compute.CL10.ErrorCode errcode_ret)
        {
            IntPtr properties_correct = new IntPtr((int)properties);
            return CreateContext(ref properties_correct, num_devices, ref devices, pfn_notify, user_data, out errcode_ret);
        }
		
		public static unsafe IntPtr CreateContext<T4>(ContextProperties* properties, uint num_devices, IntPtr* devices, IntPtr pfn_notify, ref T4 user_data, OpenTK.Compute.CL10.ErrorCode* errcode_ret)
			where T4 : struct
        {
            return CreateContext((IntPtr*)properties, num_devices, devices, pfn_notify, ref user_data, errcode_ret);
        }
        
        public static unsafe IntPtr CreateContext<T4>(ContextProperties[] properties, uint num_devices, IntPtr[] devices, IntPtr pfn_notify, ref T4 user_data, OpenTK.Compute.CL10.ErrorCode[] errcode_ret)
			where T4 : struct
        {
            IntPtr[] properties_correct = properties != null ? new IntPtr[properties.Length] : null;
			for (int i = 0; i < properties_correct.Length; i++)
				properties_correct[i] = new IntPtr((int)properties[i]);
            return CreateContext(properties_correct, num_devices, devices, pfn_notify, ref user_data, errcode_ret);
        }
        
        public static unsafe IntPtr CreateContext<T4>(ref ContextProperties properties, uint num_devices, ref IntPtr devices, IntPtr pfn_notify, ref T4 user_data, out OpenTK.Compute.CL10.ErrorCode errcode_ret)
			where T4 : struct
        {
            IntPtr properties_correct = new IntPtr((int)properties);
            return CreateContext(ref properties_correct, num_devices, ref devices, pfn_notify, ref user_data, out errcode_ret);
        }
		
        public static unsafe IntPtr CreateContextFromType(ContextProperties* properties, DeviceTypeFlags device_type, IntPtr pfn_notify, IntPtr user_data, OpenTK.Compute.CL10.ErrorCode* errcode_ret)
        {
            return CreateContextFromType((IntPtr*)properties, device_type, pfn_notify, user_data, errcode_ret);
        }
        
        public static unsafe IntPtr CreateContextFromType(ContextProperties[] properties, DeviceTypeFlags device_type, IntPtr pfn_notify, IntPtr user_data, OpenTK.Compute.CL10.ErrorCode[] errcode_ret)
        {
			IntPtr[] properties_correct = properties != null ? new IntPtr[properties.Length] : null;
			for (int i = 0; i < properties_correct.Length; i++)
				properties_correct[i] = new IntPtr((int)properties[i]);
            return CreateContextFromType(properties_correct, device_type, pfn_notify, user_data, errcode_ret);
        }
        
        public static unsafe IntPtr CreateContextFromType(ref ContextProperties properties, DeviceTypeFlags device_type, IntPtr pfn_notify, IntPtr user_data, out OpenTK.Compute.CL10.ErrorCode errcode_ret)
        {
			IntPtr properties_correct = new IntPtr((int)properties);
            return CreateContextFromType(ref properties_correct, device_type, pfn_notify, user_data, out errcode_ret);
        }
		
		public static unsafe IntPtr CreateContextFromType<T4>(ContextProperties* properties, DeviceTypeFlags device_type, IntPtr pfn_notify, ref T4 user_data, OpenTK.Compute.CL10.ErrorCode* errcode_ret)
			where T4 : struct
        {
            return CreateContextFromType((IntPtr*)properties, device_type, pfn_notify, ref user_data, errcode_ret);
        }
        
        public static unsafe IntPtr CreateContextFromType<T4>(ContextProperties[] properties, DeviceTypeFlags device_type, IntPtr pfn_notify, ref T4 user_data, OpenTK.Compute.CL10.ErrorCode[] errcode_ret)
			where T4 : struct
        {
			IntPtr[] properties_correct = properties != null ? new IntPtr[properties.Length] : null;
			for (int i = 0; i < properties_correct.Length; i++)
				properties_correct[i] = new IntPtr((int)properties[i]);
            return CreateContextFromType(properties_correct, device_type, pfn_notify, ref user_data, errcode_ret);
        }
        
        public static unsafe IntPtr CreateContextFromType<T4>(ref ContextProperties properties, DeviceTypeFlags device_type, IntPtr pfn_notify, ref T4 user_data, out OpenTK.Compute.CL10.ErrorCode errcode_ret)
			where T4 : struct
        {
			IntPtr properties_correct = new IntPtr((int)properties);
            return CreateContextFromType(ref properties_correct, device_type, pfn_notify, ref user_data, out errcode_ret);
        }

        #endregion
    }
}

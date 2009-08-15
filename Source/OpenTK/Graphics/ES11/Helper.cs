using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.ES11
{
    /// <summary>
    /// Provides access to OpenGL ES 1.1 methods.
    /// </summary>
    public partial class GL
    {
        #region Fields

        const string Library = "libGLES.dll";

        readonly static Type delegatesClass = typeof(GL).GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
        readonly static Type importsClass = typeof(GL).GetNestedType("Core", BindingFlags.Static | BindingFlags.NonPublic);

        readonly static SortedList<string, MethodInfo> FunctionMap = new SortedList<string, MethodInfo>();

        #endregion

        #region Constructors

        static GL()
        {
            MethodInfo[] methods = importsClass.GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
            FunctionMap = new SortedList<string, MethodInfo>(methods.Length);
            foreach (MethodInfo m in methods)
            {
                FunctionMap.Add(m.Name, m);
            }
        }

        internal GL()
        {
            //if (GraphicsContext.CurrentContext == null)
            //    throw new GraphicsContextMissingException();

            //FieldInfo[] delegates = this.GetType()
            //    .GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic)
            //    .GetFields(BindingFlags.Static | BindingFlags.NonPublic);

            //if (delegates == null)
            //    throw new Exception("Internal OpenTK error: ES11 bindings not generated correctly. Please report to http://www.opentk.com/issues");

            //for (int i = 0; i < delegates.Length; i++)
            //{

            //}
        }

        #endregion

        #region Private Members

        #region LoadAll

        internal static void LoadAll()
        {
            if (GraphicsContext.CurrentContext == null)
                throw new GraphicsContextMissingException();

            OpenTK.Platform.Utilities.LoadExtensions(typeof(GL));
        }

        #endregion

        #region Load

        static bool Load(string function)
        {
            FieldInfo f = delegatesClass.GetField(function, BindingFlags.Static | BindingFlags.NonPublic);
            if (f == null)
                return false;

            Delegate old = f.GetValue(null) as Delegate;
            Delegate @new = LoadDelegate(f.Name, f.FieldType);
            if (old.Target != @new.Target)
            {
                f.SetValue(null, @new);
            }
            return @new != null;
        }

        #endregion

        #region LoadDelegate

        static Delegate LoadDelegate(string name, Type signature)
        {
            MethodInfo m;
            return
                GetExtensionDelegate(name, signature) ??
                (FunctionMap.TryGetValue((name.Substring(2)), out m) ?
                Delegate.CreateDelegate(signature, m) : null);
        }

        #endregion

        #region GetExtensionDelegate

        // Creates a System.Delegate that can be used to call a dynamically exported OpenGL function.
        internal static Delegate GetExtensionDelegate(string name, Type signature)
        {
            IntPtr address = (GraphicsContext.CurrentContext as IGraphicsContextInternal).GetAddress(name);

            if (address == IntPtr.Zero ||
                address == new IntPtr(1) ||     // Workaround for buggy nvidia drivers which return
                address == new IntPtr(2))       // 1 or 2 instead of IntPtr.Zero for some extensions.
            {
                return null;
            }
            else
            {
                return Marshal.GetDelegateForFunctionPointer(address, signature);
            }
        }

        #endregion

        #endregion
    }
}

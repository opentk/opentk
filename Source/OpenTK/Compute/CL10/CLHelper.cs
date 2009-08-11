using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace OpenTK.Compute.CL10
{
    /// <summary>
    /// Provides access to the OpenCL 1.0 flat API.
    /// </summary>
    public partial class CL
    {
        #region Private Members

        const string Library = "opencl.dll";

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
    }
}

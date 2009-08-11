using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Compute.CL10
{
    struct ErrorHelper : IDisposable
    {
        #region Constructors

        public ErrorHelper(IntPtr context)
        {
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

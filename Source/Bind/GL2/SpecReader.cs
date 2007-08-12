#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using Bind.Structures;
using System.Diagnostics;

namespace Bind.GL2
{
    class SpecReader : ISpecReader
    {
        #region --- ISpecReader Members ---

        #region public virtual DelegateCollection ReadDelegates(System.IO.StreamReader specFile)

        public virtual DelegateCollection ReadDelegates(System.IO.StreamReader specFile)
        {

        }

        #endregion

        #region public virtual EnumCollection ReadEnums(System.IO.StreamReader specFile)

        public virtual EnumCollection ReadEnums(System.IO.StreamReader specfile)
        {

        }

        #endregion

        #region public virtual Dictionary<string, string> ReadTypeMap(System.IO.StreamReader sr)

        public virtual Dictionary<string, string> ReadTypeMap(System.IO.StreamReader sr)
        {

        }

        #endregion

        #region public virtual Dictionary<string, string> ReadCSTypeMap(System.IO.StreamReader sr)

        public virtual Dictionary<string, string> ReadCSTypeMap(System.IO.StreamReader sr)
        {

        }

        #endregion

        #endregion


    }
}

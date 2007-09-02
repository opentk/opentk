#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    /// <summary>
    /// This interface is is used by the ExampleLauncher to identify OpenTK examples,
    /// your applications do not need to implement or use it.
    /// </summary>
    interface IExample
    {
        void Launch();
    }
}

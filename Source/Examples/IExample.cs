#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
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

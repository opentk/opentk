// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
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

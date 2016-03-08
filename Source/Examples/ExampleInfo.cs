// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples
{
    /// <summary>
    /// Contains the information necessary to display and launch an example thorugh the ExampleLauncer.
    /// </summary>
    class ExampleInfo
    {
        public readonly Type Example;
        public readonly ExampleAttribute Attribute;

        public ExampleInfo(Type example, ExampleAttribute attr)
        {
            Example = example;
            Attribute = attr;
        }

        public override string ToString()
        {
            return Attribute.ToString();
        }
    }
}

// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.


using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using OpenTK;

namespace Examples.Tests
{
    [Example("Matrix math test", ExampleCategory.OpenTK, "Test", Visible = false)]
    public class MatrixTest
    {
        public static void Main()
        {
            float x = 1.0f;
            float y = 1.0f;
            float z = 1.0f;

            Matrix4 translation = new Matrix4(new Vector4(1, 0, 0, 2), new Vector4(0, 1, 0, 3), new Vector4(0, 0, 1, -1), new Vector4(0, 0, 0, 1));
            Vector4 point = new Vector4(x, y, z, 1);

            Vector4 result = Vector4.Transform(point, translation);

            Trace.WriteLine("Result should be: (3, 4, 0, 1) : " + result);

        }
    }
}


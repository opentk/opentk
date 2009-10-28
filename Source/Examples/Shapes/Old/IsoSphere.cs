#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK;

namespace Examples.Shapes
{
    class IsoSphere : Shape
    {
        const double DoublePI = System.Math.PI * 2.0;

        public IsoSphere(int s_steps, int t_steps, float x_scale, float y_scale, float z_scale)
        {
            int count = 4 * s_steps * t_steps ;
            
            Vertices = new Vector3[count];
            Normals = new Vector3[count];
            Texcoords = new Vector2[count];
            Indices = new int[6 * count / 4];

            int i = 0;
            for (double t = -System.Math.PI; (float)t < (float)System.Math.PI - Single.Epsilon; t += System.Math.PI / (double)t_steps)
            {
                for (double s = 0.0; (float)s < (float)DoublePI; s += System.Math.PI / (double)s_steps)
                {
                    Vertices[i].X = x_scale * (float)(System.Math.Cos(s) * System.Math.Sin(t));
                    Vertices[i].Y = y_scale * (float)(System.Math.Sin(s) * System.Math.Sin(t));
                    Vertices[i].Z = z_scale * (float)System.Math.Cos(t);
                    //vertices[i] = vertices[i].Scale(x_scale, y_scale, z_scale);
                    Normals[i] = Vector3.Normalize(Vertices[i]);

                    ++i;
                }
            }
            
            for (i = 0; i < 6*count/4; i+=6)
            {
                Indices[i] = i;
                Indices[i + 1] = i + 1;
                Indices[i + 2] = i + 2 * s_steps + 1;
                Indices[i + 3] = i + 2 * s_steps;
                Indices[i + 4] = i;
                Indices[i + 5] = i + 2 * s_steps + 1;
            }
        }
    }
}

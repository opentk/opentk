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
    public class Plane : Shape
    {
        public Plane(int x_res, int y_res, float x_scale, float y_scale)
        {
            Vertices = new Vector3[x_res * y_res];
            Normals = new Vector3[x_res * y_res];
            Indices = new int[6 * x_res * y_res];
            Texcoords = new Vector2[x_res * y_res];

            int i = 0;
            for (int y = -y_res / 2; y < y_res / 2; y++)
            {
                for (int x = -x_res / 2; x < x_res / 2; x++)
                {
                    Vertices[i].X = x_scale * (float)x / (float)x_res;
                    Vertices[i].Y = y_scale * (float)y / (float)y_res;
                    Vertices[i].Z = 0;
                    Normals[i].X = Normals[i].Y = 0;
                    Normals[i].Z = 1;
                    i++;
                }
            }

            i = 0;
            for (int y = 0; y < y_res - 1; y++)
            {
                for (int x = 0; x < x_res - 1; x++)
                {
                    Indices[i++] = (y + 0) * x_res + x;
                    Indices[i++] = (y + 1) * x_res + x;
                    Indices[i++] = (y + 0) * x_res + x + 1;

                    Indices[i++] = (y + 0) * x_res + x + 1;
                    Indices[i++] = (y + 1) * x_res + x;
                    Indices[i++] = (y + 1) * x_res + x + 1;
                }
            }
        }
    }
}

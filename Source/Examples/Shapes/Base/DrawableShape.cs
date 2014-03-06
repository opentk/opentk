#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Examples.Shapes
{
    // Abstract base class for procedurally generated geometry
    // 
    // All classes derived from it must produce Counter-Clockwise (CCW) primitives.
    // Derived classes must create a single VBO and IBO, without primitive restarts for strips. 
    // Uses an double-precision all-possible-attributes VertexT2dN3dV3d Array internally.
    // Cannot directly use VBO, but has Get-methods to retrieve VBO-friendly data.
    // Can use a Display List to prevent repeated immediate mode draws.
    //

    public abstract class DrawableShape: IDisposable
    {
        protected PrimitiveType PrimitiveMode;
        protected VertexT2dN3dV3d[] VertexArray;
        protected uint[] IndexArray;

        public int GetTriangleCount
        {
            get
            {
                switch ( PrimitiveMode )
                {
                    case PrimitiveType.Triangles:
                    if ( IndexArray != null )
                    {
                        return IndexArray.Length / 3;
                    } else
                    {
                        return VertexArray.Length / 3;
                    }
                  //  break;
                default: throw new NotImplementedException("Unknown primitive type.");
                }
            }
        }

        #region Display List

        private bool UseDisplayList;
        private int DisplayListHandle = 0;

        #endregion Display List

        public DrawableShape( bool useDisplayList )
        {
            UseDisplayList = useDisplayList;
            PrimitiveMode = PrimitiveType.Triangles;
            VertexArray = null;
            IndexArray = null;
        }

        #region Convert to VBO

        public void GetArraysforVBO(out PrimitiveType primitives, out VertexT2dN3dV3d[] vertices, out uint[] indices)
        {
            primitives = PrimitiveMode;

            vertices = new VertexT2dN3dV3d[VertexArray.Length];
            for (uint i = 0; i < VertexArray.Length; i++)
            {
                vertices[i].TexCoord = VertexArray[i].TexCoord;
                vertices[i].Normal = VertexArray[i].Normal;
                vertices[i].Position = VertexArray[i].Position;
            }

            indices = IndexArray;
        }

        public void GetArraysforVBO(out PrimitiveType primitives, out VertexT2fN3fV3f[] vertices, out uint[] indices)
        {
            primitives = PrimitiveMode;

            vertices = new VertexT2fN3fV3f[VertexArray.Length];
            for (uint i = 0; i < VertexArray.Length; i++)
            {
                vertices[i].TexCoord = (Vector2)VertexArray[i].TexCoord;
                vertices[i].Normal = (Vector3)VertexArray[i].Normal;
                vertices[i].Position = (Vector3)VertexArray[i].Position;
            }

            indices = IndexArray;
        }

        public void GetArraysforVBO(out PrimitiveType primitives, out VertexT2hN3hV3h[] vertices, out uint[] indices)
        {
            primitives = PrimitiveMode;

            vertices = new VertexT2hN3hV3h[VertexArray.Length];
            for (uint i = 0; i < VertexArray.Length; i++)
            {
                vertices[i].TexCoord = (Vector2h)VertexArray[i].TexCoord;
                vertices[i].Normal = (Vector3h)VertexArray[i].Normal;
                vertices[i].Position = (Vector3h)VertexArray[i].Position;
            }

            indices = IndexArray;
        }

        #endregion Convert to VBO

        private void DrawImmediateMode()
        {
            GL.Begin( PrimitiveMode );
            {
                if ( IndexArray == null )
                    foreach ( VertexT2dN3dV3d v in VertexArray )
                    {
                        GL.TexCoord2( v.TexCoord.X, v.TexCoord.Y );
                        GL.Normal3( v.Normal.X, v.Normal.Y, v.Normal.Z );
                        GL.Vertex3( v.Position.X, v.Position.Y, v.Position.Z );
                    } else
                {
                    for ( uint i = 0; i < IndexArray.Length; i++ )
                    {
                        uint index = IndexArray[i];
                        GL.TexCoord2( VertexArray[index].TexCoord.X, VertexArray[index].TexCoord.Y );
                        GL.Normal3( VertexArray[index].Normal.X, VertexArray[index].Normal.Y, VertexArray[index].Normal.Z );
                        GL.Vertex3( VertexArray[index].Position.X, VertexArray[index].Position.Y, VertexArray[index].Position.Z );
                    }
                }
            }
            GL.End();
        }

        /// <summary>
        /// Does not touch any state/matrices. Does call Begin/End and Vertex&Co.
        /// Creates and compiles a display list if not present yet. Requires an OpenGL context.
        /// </summary>
        public void Draw()
        {
            if ( !UseDisplayList )
                DrawImmediateMode();
            else
                if ( DisplayListHandle == 0 )
                {
                    if ( VertexArray == null )
                        throw new Exception("Cannot draw null Vertex Array.");
                    DisplayListHandle = GL.GenLists( 1 );
                    GL.NewList( DisplayListHandle, ListMode.CompileAndExecute );
                    DrawImmediateMode();
                    GL.EndList();
                } else
                    GL.CallList( DisplayListHandle );
        }

        #region IDisposable Members

        /// <summary>
        /// Removes reference to VertexArray and IndexArray.
        /// Deletes the Display List, so it requires an OpenGL context.
        /// The instance is effectively destroyed.
        /// </summary>
        public void Dispose()
        {
            if ( VertexArray != null )
                VertexArray = null;
            if ( IndexArray != null )
                IndexArray = null;
            if ( DisplayListHandle != 0 )
            {
                GL.DeleteLists( DisplayListHandle, 1 );
                DisplayListHandle = 0;
            }
        }

        #endregion
    }

}

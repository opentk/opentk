using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Text.RegularExpressions;

using OpenTK.Math;
using OpenTK.OpenGL;


namespace OpenTK.Fonts
{
    public class DefaultLayoutProvider : ILayoutProvider
    {
        static Regex break_point = new Regex("[ .,/*-+?\\!=]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        static char[] split_chars = new char[] { ' ', ',', '.', '/', '?', '!', ';', '\\', '-', '+', '*', '=' };

        #region --- ILayoutProvider Members ---

        public void PerformLayout(string text, IFont font, RectangleF layoutRect, StringAlignment alignment, bool rightToLeft)
        {
            Vector2[] vertices = new Vector2[2 * text.Length + 4];
            float x_pos, y_pos;
            int i = 0, count, last_break_point = 0;
            
            if (alignment == StringAlignment.Near && !rightToLeft || alignment == StringAlignment.Far && rightToLeft)
            {
                x_pos = vertices[0].X = layoutRect.Left;
                y_pos = vertices[0].Y = layoutRect.Top;
                vertices[1].X = x_pos;
                vertices[1].Y = y_pos - font.Height;

                count = 2;
                foreach (char c in text)
                {
                    // TODO: This code breaks for small widths or for words that do not fit in one width.
                    if (Char.IsSeparator(c))
                        last_break_point = i;

                    x_pos += font.MeasureString(text.Substring(i, 1)).Width;
                    if (x_pos > layoutRect.Width)
                    {
                        // Move the last word to the next line. If there is not enough vertical space
                        // for a new line, finish layout.

                        y_pos += font.Height;
                        if (y_pos > layoutRect.Bottom)
                            break;
                        x_pos = layoutRect.Left;

                        for (int j = last_break_point; j < i; j++)
                        {
                            int current_vertex = 2 * (j + 1);
                            vertices[current_vertex].X = x_pos;
                            vertices[current_vertex].Y += font.Height;
                            current_vertex++;
                            vertices[current_vertex].X = x_pos;
                            vertices[current_vertex].Y += font.Height;

                            x_pos += font.MeasureString(text.Substring(j, 1)).Width;
                        }

                        x_pos += font.MeasureString(text.Substring(i, 1)).Width;
                    }
                    vertices[count].X = x_pos;
                    vertices[count].Y = y_pos;
                    ++count;
                    vertices[count].X = x_pos;
                    vertices[count].Y = y_pos - font.Height;
                    ++count;

                    ++i;
                }
            }
            else if (alignment != StringAlignment.Center)
            {
                throw new NotImplementedException("This feature is not yet implemented. Sorry for the inconvenience.");
            }
            else
            {
                throw new NotImplementedException("This feature is not yet implemented. Sorry for the inconvenience.");
            }

            int buf;
            GL.GenBuffers(1, out buf);
            
        }

        #endregion
    }
}

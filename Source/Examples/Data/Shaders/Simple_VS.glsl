/* Copies incoming vertex color without change.
 * Applies the transformation matrix to vertex position.
 */
void main()
{
    gl_FrontColor = gl_Color;
    gl_Position = ftransform();
}
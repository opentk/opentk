#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Math;

namespace OpenTK.Fonts
{
    /// <summary>
    /// Defines the interface for TextPrinter implementations.
    /// </summary>
    interface ITextPrinterImplementation
    {
        TextHandle Load(Vector2[] vertices, ushort[] indices);
        void Draw(TextHandle handle);
    }
}

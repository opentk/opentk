// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
ns.Generic;
using System.Text;


namespace OpenTK.Graphics
{
    [Obsolete]
    public interface IFont : IDisposable
    {
        void LoadGlyphs(string glyphs);
        float Height { get; }
        void MeasureString(string str, out float width, out float height);
    }
}

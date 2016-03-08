// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Diagnostics;
using OpenTK.Graphics;

namespace OpenTK.Platform
{
    // Provides the foundation for all desktop IGraphicsContext implementations.
    abstract class EmbeddedGraphicsContext : GraphicsContextBase
    {
        public override void LoadAll()
        {
            Stopwatch time = Stopwatch.StartNew();

            new OpenTK.Graphics.ES11.GL().LoadEntryPoints();
            new OpenTK.Graphics.ES20.GL().LoadEntryPoints();
            new OpenTK.Graphics.ES30.GL().LoadEntryPoints();

            Debug.Print("Bindings loaded in {0} ms.", time.Elapsed.TotalMilliseconds);
        }
    }
}
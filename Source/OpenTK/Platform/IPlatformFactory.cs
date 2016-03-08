// Copyright (c) Open Toolkit library.
// This file is subject to the terms and conditions defined in
// file 'License.txt', which is part of this source code package.
using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Graphics;

namespace OpenTK.Platform
{
    interface IPlatformFactory : IDisposable
    {
        INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device);

        IDisplayDeviceDriver CreateDisplayDeviceDriver();

        IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags);

        IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags);

        GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext();

        OpenTK.Input.IKeyboardDriver2 CreateKeyboardDriver();

        OpenTK.Input.IMouseDriver2 CreateMouseDriver();

        OpenTK.Input.IGamePadDriver CreateGamePadDriver();

        Input.IJoystickDriver2 CreateJoystickDriver();

        [Obsolete]
        Input.IJoystickDriver CreateLegacyJoystickDriver();

        void RegisterResource(IDisposable resource);
    }
}

#region License
//
// PlatformFactoryBase.cs
//
// Author:
//       Stefanos A. <stapostol@gmail.com>
//
// Copyright (c) 2006-2014 Stefanos Apostolopoulos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using OpenTK.Graphics;
using OpenTK.Input;

namespace OpenTK.Platform
{
    /// \internal
    /// <summary>
    /// Implements IPlatformFactory functionality that is common
    /// for all platform backends. IPlatformFactory implementations
    /// should inherit from this class.
    /// </summary>
    abstract class PlatformFactoryBase : IPlatformFactory
    {
        static readonly object sync = new object();
        readonly List<IDisposable> Resources = new List<IDisposable>();

        protected bool IsDisposed;

        public PlatformFactoryBase()
        {
        }

        #region IPlatformFactory Members

        public abstract INativeWindow CreateNativeWindow(int x, int y, int width, int height, string title, GraphicsMode mode, GameWindowFlags options, DisplayDevice device);

        public abstract IDisplayDeviceDriver CreateDisplayDeviceDriver();

        public abstract IGraphicsContext CreateGLContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags);

        public virtual IGraphicsContext CreateGLContext(ContextHandle handle, IWindowInfo window, IGraphicsContext shareContext, bool directRendering, int major, int minor, GraphicsContextFlags flags)
        {
            throw new NotImplementedException();
        }

        public abstract GraphicsContext.GetCurrentContextDelegate CreateGetCurrentGraphicsContext();

        public abstract IKeyboardDriver2 CreateKeyboardDriver();

        public abstract IMouseDriver2 CreateMouseDriver();

        public virtual IGamePadDriver CreateGamePadDriver()
        {
            return new MappedGamePadDriver();
        }

        public abstract IJoystickDriver2 CreateJoystickDriver();

        [Obsolete]
        public virtual IJoystickDriver CreateLegacyJoystickDriver()
        {
            return new LegacyJoystickDriver();
        }

        public void RegisterResource(IDisposable resource)
        {
            lock (sync)
            {
                Resources.Add(resource);
            }
        }

        #endregion

        #region IDisposable implementation

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool manual)
        {
            if (!IsDisposed)
            {
                if (manual)
                {
                    lock (sync)
                    {
                        foreach (var resource in Resources)
                        {
                            resource.Dispose();
                        }
                        Resources.Clear();
                    }
                }
                else
                {
                    Debug.Print("[OpenTK] {0} leaked with {1} live resources, did you forget to call Dispose()?",
                        GetType().FullName, Resources.Count);
                }
                IsDisposed = true;
            }
        }

        ~PlatformFactoryBase()
        {
            Dispose(false);
        }

        #endregion
    }
}


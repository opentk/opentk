//
//  
//  AglContext.cs
//
//  Created by Erik Ylvisaker on 3/17/08.
//  Copyright 2008. All rights reserved.
//
//

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenTK.Platform.MacOS
{
    using Carbon;
    using Graphics;
    using Graphics.OpenGL;

    using AGLRendererInfo = IntPtr;
    using AGLPixelFormat = IntPtr;
    using AGLContext = IntPtr;
    using AGLPbuffer = IntPtr;

    class AglContext : IGraphicsContext, IGraphicsContextInternal 
    {
        IntPtr contextRef;
        bool mVSync = false;
        IntPtr displayID;
        
        GraphicsMode mode;
		CarbonWindowInfo carbonWindow;
		IGraphicsContext shareContext;
		
        static AglContext()
        {
            if (GraphicsContext.GetCurrentContext == null)
                GraphicsContext.GetCurrentContext = AglContext.GetCurrentContext;
        }
        public AglContext(GraphicsMode mode, IWindowInfo window, IGraphicsContext shareContext)
        {
        	this.mode = mode;
        	this.carbonWindow = (CarbonWindowInfo)window;
        	this.shareContext = shareContext;
        	
        	CreateContext(mode, carbonWindow, shareContext);
        }
        
        void CreateContext(GraphicsMode mode, CarbonWindowInfo carbonWindow, IGraphicsContext shareContext)
        {
            int[] attributes =  
            { 
                (int)Agl.PixelFormatAttribute.AGL_RGBA,
                (int)Agl.PixelFormatAttribute.AGL_DOUBLEBUFFER,
                (int)Agl.PixelFormatAttribute.AGL_RED_SIZE, mode.ColorFormat.Red,
                (int)Agl.PixelFormatAttribute.AGL_GREEN_SIZE, mode.ColorFormat.Green,
                (int)Agl.PixelFormatAttribute.AGL_BLUE_SIZE, mode.ColorFormat.Blue,
                (int)Agl.PixelFormatAttribute.AGL_ALPHA_SIZE, mode.ColorFormat.Alpha,
                (int)Agl.PixelFormatAttribute.AGL_DEPTH_SIZE, mode.Depth,
                (int)Agl.PixelFormatAttribute.AGL_STENCIL_SIZE, mode.Stencil,
                (int)Agl.PixelFormatAttribute.AGL_ACCUM_RED_SIZE, mode.AccumulatorFormat.Red,
                (int)Agl.PixelFormatAttribute.AGL_ACCUM_GREEN_SIZE, mode.AccumulatorFormat.Green,
                (int)Agl.PixelFormatAttribute.AGL_ACCUM_BLUE_SIZE, mode.AccumulatorFormat.Blue,
                (int)Agl.PixelFormatAttribute.AGL_ACCUM_ALPHA_SIZE, mode.AccumulatorFormat.Alpha,
                (int)Agl.PixelFormatAttribute.AGL_FULLSCREEN,
                (int)Agl.PixelFormatAttribute.AGL_NONE, 
            };

            AGLPixelFormat myAGLPixelFormat;
            IntPtr shareContextRef = IntPtr.Zero;

            // Choose a pixel format with the attributes we specified.
            myAGLPixelFormat = Agl.aglChoosePixelFormat(IntPtr.Zero, 0, attributes);
            MyAGLReportError();

            if (shareContext != null)
            {
                Debug.Print("shareContext type is {0}", shareContext.GetType());
            }

            if (shareContext != null && shareContext is AglContext)
                shareContextRef = ((AglContext)shareContext).contextRef;

            // create the context and share it with the share reference.
            this.contextRef = Agl.aglCreateContext(myAGLPixelFormat, shareContextRef);
            MyAGLReportError();

            // Free the pixel format from memory.
            Agl.aglDestroyPixelFormat(myAGLPixelFormat);
            MyAGLReportError();

            Debug.Print("IsControl: {0}", carbonWindow.IsControl);
            
            SetDrawable(carbonWindow);
            SetBufferRect(carbonWindow);
			Update(carbonWindow);
			
            MakeCurrent(carbonWindow);

            Debug.Print("context: {0}", contextRef);
        }
        void SetBufferRect(CarbonWindowInfo carbonWindow)
        {
            if (carbonWindow.IsControl)
            {
                Rect rect = API.GetControlBounds(carbonWindow.WindowRef);
                HIRect hirect = API.HIViewGetFrame(carbonWindow.WindowRef);

                Debug.Print("Setting buffer_rect for control.");
                Debug.Print("Rect:   {0}", rect);
                Debug.Print("HIRect: {0}", hirect);
                
                int[] glrect = new int[4];

                glrect[0] = rect.Left;
                glrect[1] = rect.Top;
                glrect[2] = rect.Width;
                glrect[3] = rect.Height;

                Agl.aglSetInteger(contextRef, Agl.ParameterNames.AGL_BUFFER_RECT, glrect);
                MyAGLReportError();

                Agl.aglEnable(contextRef, Agl.ParameterNames.AGL_BUFFER_RECT);
                MyAGLReportError();
            }     
        }
		void SetDrawable(CarbonWindowInfo carbonWindow)
		{
			IntPtr windowPort;
			
            if (carbonWindow.IsControl)
            {
                IntPtr controlOwner = API.GetControlOwner(carbonWindow.WindowRef);

                Debug.Print("GetControlOwner: {0}", controlOwner);

                windowPort = API.GetWindowPort(controlOwner);
            }
            else
                windowPort = API.GetWindowPort(carbonWindow.WindowRef);

            Agl.aglSetDrawable(contextRef, windowPort);

            MyAGLReportError();
		
		}
        public void Update(IWindowInfo window)
        {
            CarbonWindowInfo carbonWindow = (CarbonWindowInfo)window;
			
			SetBufferRect(carbonWindow);
			
            //Agl.aglSetCurrentContext(contextRef);
            Agl.aglUpdateContext(contextRef);
            
        }
        void MyAGLReportError()
        {
            Agl.AglError err = Agl.GetError();

            if (err != Agl.AglError.NoError)
                throw new MacOSException((OSStatus)err, "AGL Error: " + err.ToString() + "  " + Agl.ErrorString(err));
        }

        static ContextHandle GetCurrentContext()
        {
            return Agl.aglGetCurrentContext();
        }

        #region IGraphicsContext Members
		bool first = false;
        public void SwapBuffers()
        {
        	if (first == false && carbonWindow.IsControl)
        	{
        		Debug.WriteLine("--> Resetting drawable. <--");
        		first = true;
        		SetDrawable(carbonWindow);
        		Update(carbonWindow);
        	}
        	
            Agl.aglSwapBuffers(contextRef);
            MyAGLReportError();
        }
		
        public void MakeCurrent(IWindowInfo window)
        {
            if (Agl.aglSetCurrentContext(contextRef) == false)
                MyAGLReportError();
        }

        public bool IsCurrent
        {
            get
            {
                return (contextRef == Agl.aglGetCurrentContext());
            }
        }

        public event DestroyEvent<IGraphicsContext> Destroy;
        void OnDestroy()
        {

            if (Destroy != null)
            {
                Debug.Print("Destroy handlers: {0}", Destroy.GetInvocationList().Length);
                Destroy(this, EventArgs.Empty);
            }
        }

        public bool VSync
        {
            get
            {
                return mVSync;
            }
            set
            {
                int intVal = value ? 1 : 0;

                Agl.aglSetInteger(this.contextRef, Agl.ParameterNames.AGL_SWAP_INTERVAL, ref intVal);

                mVSync = value;
            }
        }

        #endregion

        #region IDisposable Members
        ~AglContext()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        void Dispose(bool disposing)
        {
            
            if (contextRef == IntPtr.Zero)
                return;

            OnDestroy();
            Debug.Print("Disposing of AGL context.");

            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);
            }

            Agl.aglSetCurrentContext(IntPtr.Zero);
            Agl.aglSetDrawable(contextRef, IntPtr.Zero);

            Debug.Print("Set drawable to null for context {0}.", contextRef);

            if (Agl.aglDestroyContext(contextRef) == true)
            {
                contextRef = IntPtr.Zero;
                return;
            }

            // failed to destroy context.
            Debug.WriteLine("Failed to destroy context.");
            Debug.WriteLine(Agl.ErrorString(Agl.GetError()));

            // don't throw an exception from the finalizer thread.
            if (disposing)
            {
                throw new MacOSException((OSStatus)Agl.GetError(), Agl.ErrorString(Agl.GetError()));
            }
        }

        #endregion

        #region IGraphicsContextInternal Members

        void IGraphicsContextInternal.LoadAll()
        {
            GL.LoadAll();
            Glu.LoadAll();
        }

        ContextHandle IGraphicsContextInternal.Context
        {
            get { return contextRef; }
        }

        GraphicsMode IGraphicsContextInternal.GraphicsMode
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        void IGraphicsContextInternal.RegisterForDisposal(IDisposable resource)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        void IGraphicsContextInternal.DisposeResources()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        IntPtr IGraphicsContextInternal.GetAddress(string function)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

    }
}

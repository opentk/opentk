#region License
/* Copyright (c) 2006 Stephen Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using OpenTK.Platform.Windows;
using System.Runtime.InteropServices;
using OpenTK.OpenGL.Platform;
using OpenTK.OpenGL;

namespace OpenTK.Frameworks
{
    public partial class Framework
    {
        internal class WindowsImplementation : FrameworkImplementation
        {
            private Framework framework;

            public WindowsImplementation(Framework f)
            {
                framework = f;

                Setup();
                // Set desktop resolution, refresh rate, pixel depth
            }

            override public void OnHandleCreated(object sender, EventArgs args)
            {
                //throw new Exception("The method or operation is not implemented.");
            }

            /// <summary>
            /// Checks if there all pending messages have been processed.
            /// </summary>
            /// <returns>Returns true if there are no messages left, false otherwise.</returns>
            override public bool IsIdle()
            {
                Api.Message msg;
                return !Api.PeekMessage(out msg, IntPtr.Zero, 0, 0, 0);
            }

            override public void Setup()
            {
            }

            public override bool SetResolution(int width, int height, OpenTK.OpenGL.ColorDepth color, bool fullscreen)
            {
                if (fullscreen)
                {
                    Application.Idle -= framework.OnIdle;
                    //framework.Context.Dispose();

                    Api.DeviceMode ScreenSettings = new Api.DeviceMode();           // Device Mode
                    ScreenSettings.Size = (short)Marshal.SizeOf(ScreenSettings);    // Size Of The Devmode Structure
                    ScreenSettings.PelsWidth = width;                     // Selected Screen Width
                    ScreenSettings.PelsHeight = height;                   // Selected Screen Height
                    ScreenSettings.BitsPerPel = color.Alpha +           // Selected Bits Per Pixel
                                                color.Red +
                                                color.Green +
                                                color.Blue;
                    ScreenSettings.Fields = Api.Constants.DM_BITSPERPEL | Api.Constants.DM_PELSWIDTH | Api.Constants.DM_PELSHEIGHT;

                    //framework.Context = GLContext.Create(framework, framework.ColorDepth, 16, 0);
                    Application.Idle += framework.OnIdle;

                    // Try To Set Selected Mode And Get Results.  NOTE: CDS_FULLSCREEN Gets Rid Of Start Bar.
                    if (Api.ChangeDisplaySettings(ref ScreenSettings, Api.Constants.CDS_FULLSCREEN) == Api.Constants.DISP_CHANGE_SUCCESSFUL)
                    {
                        framework.FormBorderStyle = FormBorderStyle.None;
                        framework.StartPosition = FormStartPosition.Manual;
                        framework.Location = new System.Drawing.Point(0, 0);
                        //framework.Region = new Region(new Rectangle(0, 0, width, height));
                        framework.Capture = true;
                        framework.SetTopLevel(true);
                        Cursor.Hide();

                        framework.Size = new Size(width, height);

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                framework.Size = new Size(width, height);

                return false;
            }

            public override bool SetResolution(bool fullscreen)
            {
                if (fullscreen)
                {
                    Application.Idle -= framework.OnIdle;
                    //framework.Context.Dispose();

                    Api.DeviceMode ScreenSettings = new Api.DeviceMode();           // Device Mode
                    ScreenSettings.Size = (short)Marshal.SizeOf(ScreenSettings);    // Size Of The Devmode Structure
                    ScreenSettings.PelsWidth = framework.Width;                     // Selected Screen Width
                    ScreenSettings.PelsHeight = framework.Height;                   // Selected Screen Height
                    ScreenSettings.BitsPerPel = framework.ColorDepth.Alpha +           // Selected Bits Per Pixel
                                                framework.ColorDepth.Red +
                                                framework.ColorDepth.Green +
                                                framework.ColorDepth.Blue;
                    ScreenSettings.Fields = Api.Constants.DM_BITSPERPEL | Api.Constants.DM_PELSWIDTH | Api.Constants.DM_PELSHEIGHT;

                    //framework.Context = GLContext.Create(framework, framework.ColorDepth, 16, 0);
                    Application.Idle += framework.OnIdle;

                    // Try To Set Selected Mode And Get Results.  NOTE: CDS_FULLSCREEN Gets Rid Of Start Bar.
                    if (Api.ChangeDisplaySettings(ref ScreenSettings, Api.Constants.CDS_FULLSCREEN) == Api.Constants.DISP_CHANGE_SUCCESSFUL)
                    {
                        framework.FormBorderStyle = FormBorderStyle.None;
                        framework.StartPosition = FormStartPosition.Manual;
                        framework.Location = new System.Drawing.Point(0, 0);
                        //framework.Region = new Region(new Rectangle(0, 0, width, height));
                        framework.Capture = true;
                        framework.SetTopLevel(true);
                        Cursor.Hide();

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                return false;
            }
        }
    }
}
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
                Api.DeviceMode device_mode = new Api.DeviceMode();
                Api.EnumDisplaySettings(null, Api.Constants.ENUM_REGISTRY_SETTINGS, device_mode);

                framework.DesktopResolution = new Size(device_mode.PelsWidth, device_mode.PelsHeight);
                framework.DesktopRefreshRate = device_mode.DisplayFrequency;
                framework.DesktopColorDepth = new OpenTK.OpenGL.ColorDepth(device_mode.BitsPerPel);
            }

            public override void SetResolution(int width, int height, OpenTK.OpenGL.ColorDepth color, bool fullscreen)
            {
                if (framework.Size == new Size(width, height) && framework.ColorDepth == color && framework.Fullscreen == fullscreen)
                    return;

                // If we want to change to a fullscreen mode
                if (fullscreen)
                {
                    Application.Idle -= framework.OnIdle;

                    if (framework.WindowState == FormWindowState.Maximized)
                    {
                        Rectangle bounds = framework.RestoreBounds;
                        framework.WindowState = FormWindowState.Normal;
                        width = bounds.Width;
                        height = bounds.Height;
                        //framework.Size = new Size(bounds.Width, bounds.Height);
                        //framework.Bounds = new Rectangle(0, 0, bounds.Width, bounds.Height);
                    }

                    //if (color != framework.ColorDepth)
                    //    framework.Context.Dispose();

                    Api.DeviceMode ScreenSettings = new Api.DeviceMode();
                    ScreenSettings.PelsWidth = width;                       // Selected Screen Width
                    ScreenSettings.PelsHeight = height;                     // Selected Screen Height
                    ScreenSettings.BitsPerPel = color.Alpha +               // Selected Bits Per Pixel
                                                color.Red +
                                                color.Green +
                                                color.Blue;
                    ScreenSettings.Fields = Api.Constants.DM_BITSPERPEL | Api.Constants.DM_PELSWIDTH | Api.Constants.DM_PELSHEIGHT;

                    //framework.Context = GLContext.Create(framework, framework.ColorDepth, 16, 0);
                    Application.Idle += framework.OnIdle;

                    // Try To Set Selected Mode And Get Results.  NOTE: CDS_FULLSCREEN Gets Rid Of Start Bar.
                    if (Api.ChangeDisplaySettings(ScreenSettings, Api.Constants.CDS_FULLSCREEN) == Api.Constants.DISP_CHANGE_SUCCESSFUL)
                    {
                        framework.Fullscreen = true;

                        framework.FormBorderStyle = FormBorderStyle.None;
                        framework.StartPosition = FormStartPosition.Manual;
                        framework.Location = new System.Drawing.Point(0, 0);
                        //framework.Region = new Region(new Rectangle(0, 0, width, height));
                        framework.Capture = true;
                        framework.SetTopLevel(true);
                        Cursor.Hide();

                        framework.Size = new Size(width, height);
                    }
                    else
                    {
                        // If mode change wasn't possible.
                        framework.Fullscreen = false;
                        framework.Size = new Size(width, height);
                    }
                }
                else
                {
                    // If we already are in fullscreen mode and we want to change to windowed mode.

                    if (framework.Fullscreen)
                    {
                        Application.Idle -= framework.OnIdle;

                        // Restore display settings
                        Api.ChangeDisplaySettings(null, 0);
                        framework.FormBorderStyle = FormBorderStyle.Sizable;
                        framework.StartPosition = FormStartPosition.WindowsDefaultLocation;
                        framework.Capture = false;
                        framework.SetTopLevel(true);
                        Cursor.Show();

                        Application.Idle += framework.OnIdle;
                    }

                    framework.Fullscreen = false;
                    framework.Size = new Size(width, height); 
                }
            }
        }
    }
}
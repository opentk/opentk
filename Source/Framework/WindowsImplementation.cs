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

            public override bool ToggleFullscreen(bool fullscreen)
            {
                if (fullscreen)
                {
                    Api.DeviceMode ScreenSettings = new Api.DeviceMode();       // Device Mode
                    ScreenSettings.Size = (short)Marshal.SizeOf(ScreenSettings);    // Size Of The Devmode Structure
                    ScreenSettings.PelsWidth = 640;// width;                           // Selected Screen Width
                    ScreenSettings.PelsHeight = 480;// height;                         // Selected Screen Height
                    ScreenSettings.BitsPerPel = 32;// red + green + blue + alpha;     // Selected Bits Per Pixel
                    ScreenSettings.Fields = Api.Constants.DM_BITSPERPEL | Api.Constants.DM_PELSWIDTH | Api.Constants.DM_PELSHEIGHT;

                    // Try To Set Selected Mode And Get Results.  NOTE: CDS_FULLSCREEN Gets Rid Of Start Bar.
                    if (Api.ChangeDisplaySettings(ref ScreenSettings, Api.Constants.CDS_FULLSCREEN) == Api.Constants.DISP_CHANGE_SUCCESSFUL)
                    {
                        framework.FormBorderStyle = FormBorderStyle.None;
                        framework.StartPosition = FormStartPosition.Manual;
                        framework.Location = new System.Drawing.Point(0, 0);
                        //this.Region = new Region(new Rectangle(0, 0, width, height));
                        framework.Capture = true;
                        framework.SetTopLevel(true);
                        Cursor.Hide();

                        return !fullscreen;
                    }
                    else
                    {
                        // Handle failure.
                    }
                }

                return fullscreen;
            }
        }
    }
}
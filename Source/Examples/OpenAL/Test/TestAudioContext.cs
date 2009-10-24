#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing details.
 */
#endregion

using System;
using System.Diagnostics;

using OpenTK.Audio;
using OpenTK.Audio.OpenAL;

using AlContext = System.IntPtr;
using AlDevice = System.IntPtr;

namespace Examples
{
    [Example("AudioContext Test", ExampleCategory.OpenTK, "Test", 0, false)]
    class TestApp
    {
        public static void PrintOpenALErrors( IntPtr device )
        {
            ALError AlErr = AL.GetError();
            Trace.WriteLine("OpenAL error: {0}"+ AlErr);
        }

        public static void Main()
        {
            AlcUnitTestFunc();
        }

        public static void AlcUnitTestFunc()
        {
            AudioContext context = new AudioContext();

            Trace.WriteLine("Testing AudioContext functions.");
            Trace.Indent();

//            Trace.WriteLine("Suspend()...");
//            context.Suspend();
//            Trace.Assert(!context.IsProcessing);
//
//            Trace.WriteLine("Process()...");
//            context.Process();
//            Trace.Assert(context.IsProcessing);

            //Trace.WriteLine("MakeCurrent()...");
            //context.MakeCurrent();
            //Trace.Assert(context.IsCurrent);

            //Trace.WriteLine("IsCurrent = false...");
            //context.IsCurrent = false;
            //Trace.Assert(!context.IsCurrent);

            //Trace.WriteLine("IsCurrent = true...");
            //context.IsCurrent = true;
            //Trace.Assert(context.IsCurrent);

            Trace.WriteLine("AudioContext.CurrentContext...");
            Trace.Assert(AudioContext.CurrentContext == context);

            #region Get Attribs

            //int AttribCount;
            //Alc.GetInteger(context.Device, AlcGetInteger.AttributesSize, sizeof(int), out AttribCount);
            //Trace.WriteLine("AttributeSize: " + AttribCount);

            //if (AttribCount > 0)
            //{
            //    int[] Attribs = new int[AttribCount];
            //    Alc.GetInteger(context.Device, AlcGetInteger.AllAttributes, AttribCount, out Attribs[0]);
            //    for (int i = 0; i < Attribs.Length; i++)
            //    {
            //        Trace.Write(Attribs[i]);
            //        Trace.Write(" ");
            //    }
            //    Trace.WriteLine();
            //}
            
            #endregion Get Attribs

#if false
            AlDevice MyDevice;
            AlContext MyContext;

            // Initialize Open AL
            MyDevice = Alc.OpenDevice( null );// open default device
            if ( MyDevice != Al.Null )
            {
                Trace.WriteLine( "Device allocation succeeded." );
                MyContext = Alc.CreateContext( MyDevice, Al.Null ); // create context
                if ( MyContext != Al.Null )
                {
                    Trace.WriteLine( "Context allocation succeeded." );
                    GetOpenALErrors( MyDevice );

                    Alc.SuspendContext( MyContext ); // disable context
                    Alc.ProcessContext( MyContext ); // enable context. The default state of a context created by alcCreateContext is that it is processing.
                    Al.Bool result = Alc.MakeContextCurrent( MyContext ); // set active context
                    Trace.WriteLine( "MakeContextCurrent succeeded? " + result );
                    GetOpenALErrors( MyDevice );

                    Trace.WriteLine( "Default: " + Alc.GetString( MyDevice, Enums.AlcGetString.DefaultDeviceSpecifier ) );
                    Trace.WriteLine( "Device: " + Alc.GetString( MyDevice, Enums.AlcGetString.DeviceSpecifier ) );
                    Trace.WriteLine( "Extensions: " + Alc.GetString( MyDevice, Enums.AlcGetString.Extensions ) );
                    GetOpenALErrors( MyDevice );

                    #region Get Attribs
                    int AttribCount;
                    Alc.GetInteger( MyDevice, Enums.AlcGetInteger.AttributesSize, sizeof( int ), out AttribCount );
                    Trace.WriteLine( "AttributeSize: " + AttribCount );

                    if ( AttribCount > 0 )
                    {
                        int[] Attribs = new int[AttribCount];
                        Alc.GetInteger( MyDevice, Enums.AlcGetInteger.AttributesSize, AttribCount, out Attribs[0] );
                        for ( int i = 0; i < Attribs.Length; i++ )
                            Trace.Write( ", " + Attribs[i] );
                        Trace.WriteLine( );
                    }
                    #endregion Get Attribs
                    GetOpenALErrors( MyDevice );

                    AlDevice currdev = Alc.GetContextsDevice( MyContext );
                    AlContext currcon = Alc.GetCurrentContext( );

                    if ( MyDevice == currdev )
                        Trace.WriteLine( "Devices match." );
                    else
                        Trace.WriteLine( "Error: Devices do not match." );

                    if ( MyContext == currcon )
                        Trace.WriteLine( "Context match." );
                    else
                        Trace.WriteLine( "Error: Contexts do not match." );

                    // exit
                    Alc.MakeContextCurrent( Al.Null ); // results in no context being current
                    Alc.DestroyContext( MyContext );
                    result = Alc.CloseDevice( MyDevice );
                    Trace.WriteLine( "Result: " + result );
                    Trace.ReadLine( );
                }
                else
                {
                    Trace.WriteLine( "Context creation failed." );
                }
            }
            else
            {
                Trace.WriteLine( "Failed to find suitable Device." );
            }
#endif
            /*
include <stdlib.h>
include <AL/alut.h>

int
main (int argc, char **argv)
{
  ALuint helloBuffer, helloSource;
  alutInit (&argc, argv);
  helloBuffer = alutCreateBufferHelloWorld ();  alGenSources (1, &helloSource);
  alSourcei (helloSource, AL_Buffer, helloBuffer);
  alSourcePlay (helloSource);
  alutSleep (1);
  alutExit ();
  return EXIT_SUCCESS;
}*/

            /*

             * Processing Loop Example:
// PlaceCamera - places OpenGL camera & updates OpenAL listener buffer
void AVEnvironment::PlaceCamera()
{
// update OpenGL camera position
glMatrixMode(GL_PROJECTION);
glLoadIdentity();
glFrustum(-0.1333, 0.1333, -0.1, 0.1, 0.2, 50.0);
gluLookAt(listenerPos[0], listenerPos[1], listenerPos[2],
(listenerPos[0] + sin(listenerAngle)), listenerPos[1],
(listenerPos[2] - cos(listenerAngle)),
0.0, 1.0, 0.0);
// update OpenAL
// place listener at camera
alListener3f(AL_POSITION, listenerPos[0], listenerPos[1], listenerPos[2]);
float directionvect[6];
directionvect[0] = (float) sin(listenerAngle);
directionvect[1] = 0;
directionvect[2] = (float) cos(listenerAngle);
directionvect[3] = 0;
directionvect[4] = 1;
directionvect[5] = 0;
alListenerfv(AL_ORIENTATION, directionvect);
}

            */
        }
    }
}

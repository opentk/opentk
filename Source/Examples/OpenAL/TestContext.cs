using System;

using OpenTK.OpenAL;

using AlContext = System.IntPtr;
using AlDevice = System.IntPtr;
using Examples;

namespace OpenALTestProgram
{
#if false
    [Example("OpenAL Context Test", ExampleCategory.OpenAL, 101, false)]
    class TestApp
    {
        public static void GetOpenALErrors( IntPtr device )
        {
            Enums.AlError AlErr = Al.GetError( );
            Enums.AlcError AlcErr = Alc.GetError( device );
            Enums.AlutError AlutErr = Alut.GetError( );
            Console.WriteLine( " Al: " + AlErr + "  Alc: " + AlcErr + "  Alut: " + AlcErr + " " + Alut.GetErrorString( AlutErr ) );
        }

        static void Main( string[] args )
        {
            AlcUnitTestFunc( );
        }

        public static void AlcUnitTestFunc()
        {
            Console.WriteLine("Found Devices: "+ Alc.GetString( Al.Null, Enums.AlcGetString.DeviceSpecifier ));

            AlDevice MyDevice;
            AlContext MyContext;

            // Initialize Open AL
            MyDevice = Alc.OpenDevice( null );// open default device
            if ( MyDevice != Al.Null )
            {
                Console.WriteLine( "Device allocation succeeded." );
                MyContext = Alc.CreateContext( MyDevice, Al.Null ); // create context
                if ( MyContext != Al.Null )
                {
                    Console.WriteLine( "Context allocation succeeded." );
                    GetOpenALErrors( MyDevice );

                    Alc.SuspendContext( MyContext ); // disable context
                    Alc.ProcessContext( MyContext ); // enable context. The default state of a context created by alcCreateContext is that it is processing.
                    Al.Bool result = Alc.MakeContextCurrent( MyContext ); // set active context
                    Console.WriteLine( "MakeContextCurrent succeeded? " + result );
                    GetOpenALErrors( MyDevice );

                    Console.WriteLine( "Default: " + Alc.GetString( MyDevice, Enums.AlcGetString.DefaultDeviceSpecifier ) );
                    Console.WriteLine( "Device: " + Alc.GetString( MyDevice, Enums.AlcGetString.DeviceSpecifier ) );
                    Console.WriteLine( "Extensions: " + Alc.GetString( MyDevice, Enums.AlcGetString.Extensions ) );
                    GetOpenALErrors( MyDevice );

                    #region Get Attribs
                    int AttribCount;
                    Alc.GetInteger( MyDevice, Enums.AlcGetInteger.AttributesSize, sizeof( int ), out AttribCount );
                    Console.WriteLine( "AttributeSize: " + AttribCount );

                    if ( AttribCount > 0 )
                    {
                        int[] Attribs = new int[AttribCount];
                        Alc.GetInteger( MyDevice, Enums.AlcGetInteger.AttributesSize, AttribCount, out Attribs[0] );
                        for ( int i = 0; i < Attribs.Length; i++ )
                            Console.Write( ", " + Attribs[i] );
                        Console.WriteLine( );
                    }
                    #endregion Get Attribs
                    GetOpenALErrors( MyDevice );

                    AlDevice currdev = Alc.GetContextsDevice( MyContext );
                    AlContext currcon = Alc.GetCurrentContext( );

                    if ( MyDevice == currdev )
                        Console.WriteLine( "Devices match." );
                    else
                        Console.WriteLine( "Error: Devices do not match." );

                    if ( MyContext == currcon )
                        Console.WriteLine( "Context match." );
                    else
                        Console.WriteLine( "Error: Contexts do not match." );

                    // exit
                    Alc.MakeContextCurrent( Al.Null ); // results in no context being current
                    Alc.DestroyContext( MyContext );
                    result = Alc.CloseDevice( MyDevice );
                    Console.WriteLine( "Result: " + result );
                    Console.ReadLine( );
                }
                else
                {
                    Console.WriteLine( "Context creation failed." );
                }
            }
            else
            {
                Console.WriteLine( "Failed to find suitable Device." );
            }
            /*
include <stdlib.h>
include <AL/alut.h>

int
main (int argc, char **argv)
{
  ALuint helloBuffer, helloSource;
  alutInit (&argc, argv);
  helloBuffer = alutCreateBufferHelloWorld ();
  alGenSources (1, &helloSource);
  alSourcei (helloSource, AL_Buffer, helloBuffer);
  alSourcePlay (helloSource);
  alutSleep (1);
  alutExit ();
  return EXIT_SUCCESS;
}*/

            /*

             * Processing Loop Example:
// PlaceCamera - places OpenGL camera & updates OpenAL listener data
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
#endif
}

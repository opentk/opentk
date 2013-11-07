This folder contains precompiled versions of various optional
dependencies for OpenTK. These are meant for your convenience
and are completely optional to use.

The folder structure is split by CPU architecture:
Dependencies/x86/ - compiled for 32bit Intel and AMD processors
Dependencies/x64/ - compiled for 64bit Intel and AMD processors
Dependencies/     - contains readme and license files

The dependencies are as follows:


[SDL2.dll]
[libSDL2.dylib]

The Simple DirectMedia Library compiled for Windows and Mac OS X.
Copy these to your application directory in order to use the SDL2
platform backend for OpenTK.

http://libsdl.org

"Simple DirectMedia Layer is a cross-platform development library
designed to provide low level access to audio, keyboard, mouse,
joystick, and graphics hardware via OpenGL and Direct3D."

Advantages:
+ improved stability
+ improved joystick support
+ support for Macbook Retina displays
+ support for Steam "Big Picture" controller configuration

Disadvantages:
- does not support OpenTK.GLControl (fix in progress)
- does not support multiple mice or keyboards
- does not support DisplayResolution.ChangeResolution

It is highly recommended that you use the SDL2 backend on Mac OS X.


[openal32.dll]

OpenAL Soft compiled for Windows. Copy this to your application
directory in order to use OpenAL on Windows.

http://kcat.strangesoft.net/openal.html

"OpenAL Soft is an LGPL-licensed, cross-platform, software
implementation of the OpenAL 3D audio API."

This is required in order to use OpenAL on Windows platforms.
Linux and Mac OS X support OpenAL out of the box.


[libEGL.dll]
[libGLESv2.dll]
[d3dcompiler_46.dll]

ANGLE Project compiled for Windows. Copy these to your application
directory in order to use OpenGL ES 2.0 on Windows.

https://code.google.com/p/angleproject/

"The goal of ANGLE is to allow Windows users to seamlessly run WebGL
and other OpenGL ES 2.0 content by translating OpenGL ES 2.0 API
calls to DirectX 9 or DirectX 11 API calls."

These are required if you wish to publish an OpenGL ES application
to the Windows Store. You can also use these in order to port or test
OpenGL ES code from and to mobile devices (Android, iPhone).

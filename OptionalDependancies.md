Optional Dependancies
=====================

OpenTK supports various optional dependancies. These are meant for your convenience and are completely optional to use.

### SDL2
**SDL2.dll libSDL2.dylib libSDL2.so**

The Simple DirectMedia Library compiled for Windows, Mac OS X and Android.

http://libsdl.org

Simple DirectMedia Layer is a cross-platform development library designed to provide low level access to audio, keyboard, mouse, joystick, and graphics hardware via OpenGL and Direct3D.

### OpenAL Soft

**OpenAL32.dll**

OpenAL Soft is an LGPL-licensed, cross-platform, software implementation of the OpenAL 3D audio API, and is required to use OpenAL on Windows. Linux and Mac OS X support OpenAL out of the box.


### ANGLE
**libEGL.dll libGLESv2.dll d3dcompiler_46.dll**

The goal of ANGLE is to allow Windows users to seamlessly run WebGL and other OpenGL ES 2.0 content by translating OpenGL ES 2.0 API calls to DirectX 9 or DirectX 11 API calls.


Windows Architecture Specific Dependancies
==========================================

On Windows, OpenTK supports the following additional DLL seach paths:
**OpenTK Folder\x86** - Place x86 architecture specific files in this subfolder.
**OpenTK Folder\x64** - Place x64 architecture specific files in this subfolder.

Please also see the following Microsoft link for a full explanation on the DLL search order:
https://docs.microsoft.com/en-us/windows/win32/dlls/dynamic-link-library-search-order

Linux and OS-X Dependancies
===========================

Under Linux and Mac OS X, the search path for these optional dependancies may be found in the **OpenTK.dll.config** file, which should be placed next to **OpenTK.dll**
The Mono documentation for this file may be found at the following page:
https://www.mono-project.com/docs/advanced/pinvoke/dllmap/

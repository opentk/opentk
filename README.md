Notice
======

@frassle (current maintainer) is stepping away from this project. The project owner is not around to give direction, and I don't have access to the website, nuget account, travis account or most permissions on the github account. I can't push this project forward.

As I'm the only one whos maintained this repo for the last 6 months with my absence pull requests and issues will probably stay unresolved. I'd suggest developer look to other projects like [MonoGame](http://www.monogame.net/) or [SDL2#](https://github.com/flibitijibibo/SDL2-CS).

As this is a large project used by many people I thought it best to add this notice before signing off.

OpenTK
======

The Open Toolkit library is a fast, low-level C# binding for OpenGL, OpenGL ES and OpenAL. It runs on all major platforms and powers hundreds of apps, games and scientific research.

Use OpenTK to add cross-platform 3d graphics, audio, compute and haptics to your C# application. Integrate it into your existing user interface or use it standalone without any external dependencies.

Project website: http://www.opentk.com/

Official git repository: https://github.com/opentk/opentk


Features
========

- Create cutting-edge graphics with OpenGL 4.4 and OpenGL ES 3.0
- Spice up your GUI with 3d acceleration
- Improve your code flow with strong types and inline documentation
- Write once run everywhere

OpenTK is available for Windows, Linux, Mac OS X, *BSD, SteamOS, Android and iOS. It can be used standalone or integrated into a GUI (Windows.Forms, WPF, GTK+, Qt, VTK, ...)

[Download binaries](http://www.opentk.com) or [NuGet packages](http://www.nuget.org/packages/OpenTK/)


Instructions
============

The simplest way to use OpenTK in your project is to install the [NuGet package](http://www.nuget.org/packages/OpenTK/). 

Note what installing NuGet package will add reference to OpenTK.dll, but OpenTK.dll.config 
will not be copied to the project output directory automatically, so you need to add it to your project 
and then enable the "Copy to Output Directory" option (as in step 3 below).

Alternatively, download the [OpenTK binaries](http://www.opentk.com) and:

1. Copy OpenTK.dll and OpenTK.dll.config to your project directory
2. Use "Add reference" to add OpenTK.dll as a project reference
3. Use "Add files" to add OpenTK.dll.config to your project, and enable the "Copy to Output Directory" option.

To build OpenTK from source, simply double-click OpenTK.sln and build through your IDE.

Alternatively, open a command prompt and type:
```
git clone https://github.com/opentk/opentk   # Download source code from git
cd opentk                                    # Enter the source directory
msbuild /p:Configuration=Release OpenTK.sln  # Build on .Net (Windows)
xbuild  /p:Configuration=Release OpenTK.sln  # Build on Mono (Linux / Mac OS X)
```


News
====

OpenTK 1.1.4c was released on 24 July 2014.

This is a hotfix release that improves stability on Mac OS X. Moreover, it synchronizes the GamePad configuration database with SDL 2.0.4 and fixes an invalid GUID introduced in 1.1.4b.

OpenTK 1.1.4 was released on 21 July 2014.

This release resolves a number of identified issues, adds experimental support for Linux/KMS and synchronizes the OpenGL and OpenGL ES bindings with the July 2014 Khronos specifications.

**Changelog:**

1. Fixed a memory leak in OpenGL functions accepting a string array.
2. Fixed an issue where `MakeCurrent()` might fail on Linux/X11 when using the Nvidia closed-source drivers.
3. Fixed an issue where `GameWindow` might remain open on Linux/X11 after calling `Close()` or `Dispose()`.
4. Fixed a potential crash on Mac OS X systems without hardware acceleration (e.g. virtual machines).
5. Fixed function parameters for the `OES_byte_coordinates` extension.
6. Fixed an issue where OpenTK would always perform a full rebuild even when a partial rebuild could work.
7. Fixed all compilation warnings on VS2013 and Mono 3.4.0.
8. Improved OpenGL and OpenGL ES documentation on 'count' parameters.
9. New platform: Linux/KMS. You can now run OpenTK applications on a Linux terminal without an X11 display server.
10. New OpenGL ES extensions:
  - ANDROID_extension_pack_es31a

OpenTK 1.1.4 is backwards compatible with 1.1.3. Users of previous versions are **strongly** encouraged to upgrade.


Known issues
============

1. The SDL2 backend has a number of limitations compared to the native platform backends. In particular, SDL2 does not support:
   - `OpenTK.GLControl`. OpenTK will automatically switch to a native platform backend instead.
   - `DisplayDevice.ChangeResolution()` without a fullscreen `INativeWindow`.
   - Switching between `WindowBorder.Fixed` and `WindowBorder.Resizable`.
   - High-resolution mouse input. Additionally, it is limited to a single keyboard and mouse device.
2. OpenTK.Input.GamePad.SetVibration is currently not implemented. This API will be implemented in a future release.


Contributing
============

1. Install git and a C# IDE (see requirements section below)
2. Fork the _develop_ branch of https://github.com/opentk/opentk
3. Commit your changes in small, incremental steps with clear descriptions
4. When ready, issue a Pull Request (PR) against the _develop_ branch of https://github.com/opentk/opentk

For details on coding style and best practices, refer to https://github.com/opentk/opentk/wiki/Contributing

Some areas we could really use your help:
- Tutorials for OpenGL 3.x and 4.x. [Inspiration here](https://github.com/Groovounet/ogl-samples)
- New platforms:
  - Native Client (NaCL)
  - Blackberry
  - Wayland
  - Mir
  - WinRT (via ANGLE)
- New features:
  - Multitouch
  - Force feedback
  - Improved joystick support (HID backend for Windows, Linux)

Further ideas for improvement are always welcome!


Requirements
============

- Windows (XP/Vista/7/8), Linux, Mac OS X, *BSD, SteamOS, Android or iOS
- For graphics, OpenGL drivers or a suitable emulator, such as [ANGLE](https://github.com/opentk/opentk/tree/develop/Dependencies/Readme.txt)
- For audio, OpenAL drivers or [OpenAL Soft](https://github.com/opentk/opentk/tree/develop/Dependencies/Readme.txt)
- To develop desktop applications: Visual Studio, Xamarin Studio, MonoDevelop or SharpDevelop
- To develop Android applications: Xamarin Studio or the Xamarin Extensions for Visual Studio
- To develop iOS applications: Xamarin Studio and XCode


Documentation
=============

Your favorite IDE will display inline documentation for all OpenTK APIs. Additional information can be found in the [OpenTK Manual](http://www.opentk.com/doc) and in the [opentk/Documentation/](https://github.com/opentk/opentk/tree/develop/Documentation) folder.

Technical documentation about the implementation of OpenTK can be found in the [Technical Wiki](https://github.com/opentk/opentk/wiki).


Need Help?
==========

Post your questions at the [OpenTK forums](http://www.opentk.com/forum).

Report bugs at https://github.com/opentk/opentk/issues


License
=======

The Open Toolkit is distributed under the permissive MIT/X11 license and is absolutely free.

http://www.opentk.com/project/license


API compatibility
=================

OpenTK 1.1.4 is backwards compatible with 1.1.3.

OpenTK 1.1.3 is backwards compatible with 1.1.2.

OpenTK 1.1.2 is backwards compatible with 1.1.1.

OpenTK 1.1.1 is backwards compatible with 1.1.0.

OpenTK 1.1.0 is not backwards compatible with 1.0. Most projects will be able to upgrade without any modifications. Projects using the following signatures will have to implement the suggested changes:

Namespace OpenTK.Graphics.OpenGL
Change signature:
- GL.MultiDrawArrays (`out` -> `ref`)
- GL.Amd.DeletePerfMonitors (`out` -> `ref`)

Change signature (may cause crash): 
- GL.Apple.ObjectPurgeable (returns `AppleObjectPurgeable` instead of `IntPtr`)
- GL.Ext.SeparableFilter2D
- GL.Ibm.EdgeFlagPointerList (`bool[]` -> `bool*[]`)
- GL.NV.TransformFeedbackVaryings (`string[]` -> `int[]`)

Change return type:
- GL.WaitSync (returns `WaitSyncFlags` instead of `ArbSync`)


Namespace OpenTK.Graphics.ES11
Change return type:
- GL.GetError (`ErrorCode` instead of `All`)

Change `ref` parameters to `out`:
- GL.GenBuffers
- GL.GenTextures
- GL.GetBoolean
- GL.GetBufferParameter
- GL.GetClipPlane
- GL.GetClipPlanex
- GL.GetFixed
- GL.GetFloat
- GL.GetInteger
- GL.GetLight
- GL.GetLightx
- GL.GetMaterial
- GL.GetMaterialx
- GL.GetTexEnv
- GL.GetTexEnvx
- GL.GetTexParameter
- GL.GetTexParameterx
- GL.Oes.GenFramebuffers
- GL.Oes.GetClipPlane
- GL.Oes.GetClipPlanex
- GL.Oes.GetFixed
- GL.Oes.GetFramebufferAttachmentParameter
- GL.Oes.GetLightx
- GL.Oes.GetMaterialx
- GL.Oes.GetRenderbufferParameter
- GL.Oes.GetTexEnvx
- GL.Oes.GetTexGen
- GL.Oes.GetTexGenx
- GL.Oes.GetTexParameterx
- GL.Oes.QueryMatrixx
- GL.NV.GenFences
- GL.NV.GetFence

Change namespace:
- GL.ClipPlanefIMG -> GL.Img.ClipPlane
- GL.DisableDriverControlQCOM -> GL.Qcom.DisableDriverControl


Namespace OpenTK.Graphics.ES20.GL
Change signature (may cause crash):
- GL.NV.GetFence now takes three parameters instead of two

Change `ref` parameters to `out`:
- GL.GetActiveAttrib
- GL.GetActiveUniform
- GL.GetAttachedShaders
- GL.GetProgramInfoLog
- GL.GetShaderInfoLog
- GL.GetShaderSource
- GL.Amd.GetPerfMonitorCounterData
- GL.Amd.GetPerfMonitorCounters
- GL.Amd.GetPerfMonitorCounterString
- GL.Amd.GetPerfMonitorGroup
- GL.Amd.GetPerfMonitorGroupString
- GL.Amd.SelectPerfMonitorCounters

Change namespace:
- GL.DisableDriverControlQCOM -> GL.Qcom.DisableDriverControl
- GL.GetDriverControlsQCOM -> GL.Qcom.GetDriverControls
- GL.GetDriverControlStringQCOM -> GL.Qcom.GetDriverControlString


See also
========

[Delta Engine](http://deltaengine.net/), a high-level, open-source game engine.
[MonoGame](https://github.com/mono/monogame), an open-source, cross-platform implementation of XNA.

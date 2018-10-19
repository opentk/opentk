OpenTK
======

OpenTK is a large project, with a huge number of components. We're looking to add a more maintainers to the team.
Come join us in Discord and let us know where you'd like to help out.

[![Discord](https://discordapp.com/api/guilds/337627185248468993/widget.png)](https://discord.gg/GZTYR4s)

The Open Toolkit library is a fast, low-level C# binding for OpenGL, OpenGL ES and OpenAL. It runs on all major platforms and powers hundreds of apps, games and scientific research.

Use OpenTK to add cross-platform 3d graphics, audio, compute and haptics to your C# application. Integrate it into your existing user interface or use it standalone without any external dependencies.

Project website: https://opentk.github.io/

Official git repository: https://github.com/opentk/opentk

Build Status
========

| Platform       | Status         |
| -------------- | -------------- |
| Windows        | [![Build status](https://ci.appveyor.com/api/projects/status/opentk/branch/develop?svg=true)](https://ci.appveyor.com/project/varon/opentk/branch/develop) |
| Mono/Linux     | [![Build status](https://travis-ci.org/opentk/opentk.svg?branch=develop)](https://travis-ci.org/opentk/opentk) |


Features
========

- Create cutting-edge graphics with OpenGL 4.6 and OpenGL ES 3.0
- Spice up your GUI with 3d acceleration
- Improve your code flow with strong types and inline documentation
- Windowing systems to help get you started
- Input, and other game essentials.
- Performant, highly optimized and bug-free linear algebra library
- Write once run everywhere

OpenTK is available for Windows, Linux, Mac OS X, *BSD, SteamOS, Android and iOS. It can be used standalone or integrated into a GUI (Windows.Forms, WPF, GTK+, Qt, VTK, ...)

[Download binaries](http://www.opentk.com) or [NuGet packages](http://www.nuget.org/packages/OpenTK/)


Instructions
============

The simplest way to use OpenTK in your project is to install the [NuGet package](http://www.nuget.org/packages/OpenTK/).
If you want to try out the latest development build from the `develop` branch, we also have a [MyGet feed](https://www.myget.org/F/opentk-develop/api/v3/index.json).

Note what installing NuGet package will add reference to OpenTK.dll, but OpenTK.dll.config
will not be copied to the project output directory automatically, so you need to add it to your project
and then enable the "Copy to Output Directory" option (as in step 3 below).

To build OpenTK from source, do the following once:
```
git clone https://github.com/opentk/opentk   # Download source code from git
cd opentk                                    # Enter the source directory
./build.cmd                                  # Build on .Net (Windows)
./build.sh                                   # Build on Mono (Linux / Mac OS X)
```

After this is done at least once, you can build OpenTK normally through
your IDE.

News
====

### 2018-10-19

Work is well underway on OpenTK 4.0, which targets .Net Core. We would welcome any contributions!

### 2018-06-07

OpenTK 3.0.1 is available.

https://www.nuget.org/packages/OpenTK/3.0.1

https://www.nuget.org/packages/OpenTK.GLControl/3.0.1

### 2018-01-05

OpenTK 3.0.0 is available.

https://www.nuget.org/packages/OpenTK/3.0.0

https://www.nuget.org/packages/OpenTK.GLControl/3.0.0

### 2017-05-08

A pre-release package is available.

https://www.nuget.org/packages/OpenTK/3.0.0-pre

https://www.nuget.org/packages/OpenTK.GLControl/3.0.0-pre

### 2016-09-23

OpenTK 2.0.0 is now available for download from [Nuget](https://www.nuget.org/packages/OpenTK/2.0.0).

Aside from being a maintenance release to bring the current package closer in-line with develop, this the project's first release since adopting a new build system.

Release notes:
 - Moved to new FAKE/Paket based build system
 - Removed superfluous release configurations
 - Numerous other fixes and enhancements

We would welcome any feedback on the package, so please open a GitHub issue if you require assistance or experience difficulties.

### 2016-07-19

The new OpenTK website is live. You can view it at [opentk.github.io](https://opentk.github.io/)

We are currently looking for contributors for tutorials and other resources.

### 2016-07-13

A pre-release package is available.

https://www.nuget.org/packages/OpenTK.Next/1.2.2336.6514-pre
https://www.nuget.org/packages/OpenTK.Next.GLControl/1.2.2336.6514-pre

*The OpenTK.Next package id will no longer be used for future releases.


### 2014-07-24

OpenTK 1.1.4c was released on 24 July 2014.

This is a hotfix release that improves stability on Mac OS X. Moreover, it synchronizes the GamePad configuration database with SDL 2.0.4 and fixes an invalid GUID introduced in 1.1.4b.

### 2014-07-21

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
- Tutorials for OpenGL 3.x and 4.x. [Inspiration here](https://github.com/g-truc/ogl-samples)
- New platforms:
  - Native Client (NaCL)
  - Wayland
  - Mir
- New features:
  - Multitouch
  - Force feedback
  - Improved joystick support (HID backend for Windows, Linux)

Further ideas for improvement are always welcome!


Requirements
============

- Windows (XP/Vista/7/8,10), Linux, Mac OS X, *BSD, SteamOS, Android or iOS
- For graphics, OpenGL drivers or a suitable emulator, such as [ANGLE](https://github.com/opentk/opentk/tree/develop/Dependencies/Readme.txt)
- For audio, OpenAL drivers or [OpenAL Soft](https://github.com/opentk/opentk/tree/develop/Dependencies/Readme.txt)
- To develop desktop applications: Visual Studio, Rider, or the command line tools.
- To develop Android applications: Visual Studio and Xamarin
- To develop iOS applications: Visual Studio, Xamarin and XCode


Documentation
=============

Your favorite IDE will display inline documentation for all OpenTK APIs. Additional information can be found in the [OpenTK Manual](http://web.archive.org/web/20150325224427/http://www.opentk.com/doc).

Technical documentation about the implementation of OpenTK can be found in the [Technical Wiki](https://github.com/opentk/opentk/wiki).

Need Help?
==========

Come chat with us on [Discord](https://discord.gg/GZTYR4s).

We're happy to help with anything from learning OpenGL to advanced OpenTK questions.


License
=======

The Open Toolkit is distributed under the permissive MIT/X11 license and is absolutely free.

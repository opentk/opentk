OpenTK
======

OpenTK is a large project. There are many components to work on, and we'd welcome almost any contribution. The community is friendly, welcoming and always ready to help you get your PRs merged!

We have a very active discord server, if you need help, want to help, or are just curious, come join us!

[![Discord](https://discordapp.com/api/guilds/337627185248468993/widget.png)](https://discord.gg/6HqD48s)

The Open Toolkit library is a fast, low-level C# binding for OpenGL, OpenGL ES, OpenAL, and OpenCL. It runs on all major platforms and powers hundreds of apps, games and scientific research.

Use OpenTK to add cross-platform 3d graphics, audio, compute and haptics to your C# application. Integrate it into your existing user interface or use it standalone without any external dependencies.

OpenTK comes with simple and easy to follow tutorials for learning *modern* OpenGL. These are written by the community and represent all of the best practices to get you started.

#### Learn how to use OpenTK here: https://opentk.net/learn/index.html

Sample projects that accompany the tutorial can be found here: https://github.com/opentk/LearnOpenTK

Project website: https://opentk.net

Official git repository: https://github.com/opentk/opentk

Build Status
========

| Platform       | Status         |
| -------------- | -------------- |
| Windows        | [![Build status](https://ci.appveyor.com/api/projects/status/c9b9754wa0v1p9rb?svg=true)](https://ci.appveyor.com/project/varon/opentk) |
| Mono/Linux     | [![Build status](https://travis-ci.org/opentk/opentk.svg?branch=master)](https://travis-ci.org/opentk/opentk) |


Features
========

- Create cutting-edge graphics with OpenGL 4.6 and OpenGL ES 3.0
- Spice up your GUI with 3d acceleration
- Improve your code flow with strong types and inline documentation
- Windowing systems to help get you started
- Input, and other game essentials.
- Performant, highly optimized and reliable linear algebra library
- Write once run everywhere

OpenTK is available for Windows, Linux, Mac OS X, *BSD and SteamOS. It can be used standalone or integrated into a GUI (Windows.Forms, WPF, GTK+, Qt, VTK, ...)

An old, unsupported version of OpenTK 1.0 may be included in the [Xamarin](https://docs.microsoft.com/en-us/xamarin/graphics-games/game-development/) Android and iOS distribution. The Xamarin fork is not supported or maintained by this project.

Adding support for mobile again is a future goal of the OpenTK project, but is somewhat frustrated by Apple's deprecation of OpenGL. Contributions to re-add support for these platforms are welcomed.

Instructions
============

OpenTK is available as a [NuGet Package](http://www.nuget.org/packages/OpenTK/).

News
===

### 2020-10-02

OpenTK 4.0.0 is released with full availability.

Key changes:
 * Full support for .Net Core 3.1
 * Brand new GLFW-based windowing system
 * Brand new GLFW-based input system
 * Removed all platform-specific backends (and fixed every xplat bug!)
 * Math library performance improvements and fixes
 * All new OpenAL bindings
 * All new OpenCL Bindings
 * Total restructure of all packages into a modular system with a number of packages. The OpenTK Nuget package is now a metapackage that will automatically download all of these for you.

OpenTK 4.0.0 is entirely MIT licensed.


We're excited to see what you can build with this!

https://www.nuget.org/packages/OpenTK


### 2020-04-06

Oops! Forgot to update the news! OpenTK 4.0.0 PREVIEW is now available on Nuget.

https://www.nuget.org/packages/OpenTK


### 2020-04-06

OpenTK 3.2.0 is available. 

This adds bindings for the wgl_dx_interop extension and support for joysticks with > 64 buttons.

https://www.nuget.org/packages/OpenTK/3.2.0


### 2019-08-04

OpenTK 3.1.0 is available.

https://www.nuget.org/packages/OpenTK/3.1.0

https://www.nuget.org/packages/OpenTK.GLControl/3.1.0



### 2018-10-19

Work is well underway on OpenTK 4.0, which targets .netstandard 2.0.

We would welcome any contributions!

[Click here](https://github.com/opentk/opentk/issues/823) to view the tracking issue.

### 2018-06-07

OpenTK 3.0.1 is available.

https://www.nuget.org/packages/OpenTK/3.0.1

https://www.nuget.org/packages/OpenTK.GLControl/3.0.1

### 2018-01-05

OpenTK 3.0.0 is available.

https://www.nuget.org/packages/OpenTK/3.0.0

https://www.nuget.org/packages/OpenTK.GLControl/3.0.0


Building from source
============

```
git clone https://github.com/opentk/opentk   # Download source code from git
cd opentk                                    # Enter the source directory
./build.cmd / ./build.sh                     # Run the bootstrap/build script for your platform
```


Contributing
============

OpenTK uses and encourages [Early Pull Requests](https://medium.com/practical-blend/pull-request-first-f6bb667a9b6). Please don't wait until you're done to open a PR!

1. Install [Git](https://git-scm.com/downloads) and the [.Net Core SDK](https://www.microsoft.com/net/download)
1. [Fork OpenTK](https://github.com/opentk/opentk/fork)
1. Create a branch on your fork.
1. Add an empty commit to start your work off (and let you open a PR): `git commit --allow-empty -m "start of [thing you're working on]"`
1. Open a Pull request with `[WIP]` in the title. Do this **before** you actually start working.
1. Make your commits in small, incremental steps with clear descriptions.
1. Tag a maintainer when you're done and ask for a review!

[Click here for good first issues.](https://github.com/opentk/opentk/issues?q=is%3Aissue+is%3Aopen+label%3A%22good+first+issue%22)

[Click here for everything we need help with.](https://github.com/opentk/opentk/issues?q=is%3Aissue+is%3Aopen+label%3A%22help+wanted%22)


Requirements
============

- Windows (7/8,10), Linux, Mac OS X, *BSD, SteamOS, Android or iOS
- For graphics, OpenGL drivers or a suitable emulator, such as [ANGLE](https://github.com/opentk/opentk/tree/develop/Dependencies/Readme.txt)
- For audio, OpenAL drivers or OpenAL Soft
- To develop desktop applications: Visual Studio, Rider, or the command line tools.
- To develop Android applications: Visual Studio and Xamarin
- To develop iOS applications: Visual Studio, Xamarin and XCode

Documentation
=============

API Documentation is available on the [official website](https://opentk.net) or inline from favourite IDE.

You can also browse the full API on the official website

Additional information can be found in the [OpenTK Manual](http://web.archive.org/web/20150325224427/http://www.opentk.com/doc).

Technical documentation about the implementation of OpenTK can be found in the [Technical Wiki](https://github.com/opentk/opentk/wiki).


Need Help?
==========

Come chat with us on [Discord](https://discord.gg/6HqD48s).

We're happy to help with anything from learning OpenGL to advanced OpenTK questions.


License
=======

The Open Toolkit is distributed under the permissive MIT/X11 license and is absolutely free.

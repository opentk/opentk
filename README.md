OpenTK
======

The Open Toolkit is an advanced, low-level C# library that wraps OpenGL, OpenGL ES and OpenAL. It is suitable for games, scientific applications and any other project that requires 3d graphics, audio or compute functionality.

Project website: http://www.opentk.com/

Official git repository: https://github.com/opentk/opentk


Features
========

- Create cutting-edge graphics with OpenGL 4.4 and OpenGL ES 3.0
- Spice up your GUI with 3d graphics
- Improve your code flow with strong types and inline documentation
- Write once run everywhere

OpenTK is available for Windows, Linux, Mac OS X, *BSD, SteamOS, Android and iOS. It can be used standalone or integrated into a GUI (Windows.Forms, WPF, GTK+, Qt, VTK, ...)

[Download binaries](http://www.opentk.com) or [NuGet packages](http://www.nuget.org/packages/OpenTK/)


Instructions
============

The simplest way to use OpenTK in your project is to install the [NuGet package](http://www.nuget.org/packages/OpenTK/).

Alternatively, download the [OpenTK binaries](http://www.opentk.com) and:

1. Copy OpenTK.dll and OpenTK.dll.config to your project directory
2. Use "Add reference" to add OpenTK.dll as a project reference
3. Use "Add files" to add OpenTK.dll.config to your project, and enable the "Copy to Output Directory" option.

If you wish to build OpenTK from source, simply double-click OpenTK.sln


News
====

OpenTK 1.1.2 was released on 19 May 2014.

It contains performance and stability improvements and synchronizes the OpenGL and OpenGL ES bindings with the May 2014 Khronos specifications.

**Changelog:**

1. New Cocoa backend for Mac OS X, with support for OpenGL 4.x and retina displays. Huge thanks to [Ollhax](https://github.com/Ollhax) for implementing the backend from scratch, including the necessary Cocoa bindings!
2. Custom hardware cursors are now supported: `INativeWindow.Cursor = new MouseCursor(...)`
3. Up to 2000% improvement in binding loading speed. The exact numbers depend on the operating system and hardware configuration. On a Nvidia 650M GPU and a 2.3GHz processor:
   - Linux: 6.5ms instead of  45ms
   - MacOS: 9.5ms instead of 165ms
   - Win64: 5.9ms instead of 108ms
4. Up to 1000% improvement in memory consumption. The object graph has been reduced from 9000 to 900 objects, consuming between 185-220KB of memory depending on the platform and hardware configuration.
5. Support for high-resolution X/Y scrolling on all platforms:
   - `OpenTK.Input.MouseState.Scroll.X/Y`
6. Improved mouse input APIs:
   - new INativeWindow.MouseMove, MouseUp, MouseDown and MouseWheel events
   - new OpenTK.Mouse.GetCursorPos() API to retrieve the state of the system cursor
   - all mouse event arguments now carry the current MouseState
7. Improved keyboard input APIs:
   - support for non-US layouts on Linux/X11
   - all keyboard event arguments now carry the current KeyboardState
   - all keyboard event arguments now report the correct KeyModifiers state
8. New OpenGL extensions:
   - AMD_gcn_shader
   - AMD_gpu_shader_int64
   - AMD_transform_feedback4
   - EXT_shader_image_load_formatted
   - NV_shader_thread_group
   - NV_shader_thread_shuffle
9. New OpenGL ES extensions:
   - ARM_shader_framebuffer_fetch
   - ARM_shader_framebuffer_fetch_depth_stencil
   - EXT_shader_pixel_local_storage
   - KHR_blend_equation_advanced
   - OES_sample_shading
   - OES_sample_variables
   - OES_shader_image_atomic
   - OES_shader_multisample_interpolation
   - OES_texture_stencil8
   - OES_texture_storage_multisample_2d_array
10. Improved OpenGL ES documentation tooltips.
11. Improved stability when using EGL on Linux and Windows/ANGLE.
12. Improved stability when using SDL2 on 32bit platforms.
13. Improved the shutdown sequence on X11.
14. Fixed a marshaling issue affecting 2d and 3d arrays on Windows/.Net.


OpenTK 1.1.2 is backwards compatible with 1.1.1. Users of previous versions are encouraged to upgrade.


Known issues
============

The SDL2 backend has a number of limitations compared to the native platform backends. In particular, SDL2 does not support:
   - `OpenTK.GLControl`. OpenTK will automatically use a native platform backend instead.
   - `DisplayDevice.ChangeResolution()` without a fullscreen `INativeWindow`.
   - changing `INativeWindow.WindowBorder` once a window is created.
   - high-resolution mouse input. Additionally, it is limited to a single keyboard and mouse device.


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
  - Raspberry PI (EGL without X11)
  - Wayland
  - Mir
  - WinRT (via ANGLE)
- New features:
  - Multitouch
  - Clipboard
  - Input Method Editors (IMEs)
  - USB HID joystick backend (Windows, Linux)

Further ideas for improvement are always welcome.


Requirements
============

- Windows (XP/Vista/7/8), Linux, Mac OS X, *BSD, SteamOS, Android or iOS
- For graphics, OpenGL drivers or a suitable emulator, such as [ANGLE](https://github.com/opentk/opentk/tree/Dependencies/Readme.txt)
- For audio, OpenAL drivers or [OpenAL Soft](https://github.com/opentk/opentk/tree/Dependencies/Readme.txt)
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

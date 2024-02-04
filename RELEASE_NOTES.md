## 4.8.2

* FIX: Fixed issue where setting `NativeWindow.WindowState = WindowState.Normal` while fullscreen would not exit fullscreen. (@Th3Dilli)

* API: Added `NativeWindow.FramebufferSize`, `NativeWindow.OnFramebufferResize`, and `NativeWindow.FramebufferResize` to be able to properly get the framebuffer size of the window (useful on macos where framebuffer size is not equal to client size). (@NogginBops)

* API: Added `GameWindowSettings.Win32SuspendTimerOnDrag` propery that allows the internal timer to be suspended while the window is moved or resized. Without this dragging the window will cause an abnormally large time delta since the last frame. (@MV10)

* API: Made `NativeWindowSettings.Size` obsolete in favour of `NativeWindowSettings.ClientSize` (`NativeWindowSettings.Size` has always set the client size of the window, this namechange just makes this clear). (@MV10)

* API: Added ability to override OpenAL and OpenCL native library search path by setting `OpenALLibraryNameContainer.OverridePath` or `OpenCLLibraryNameContainer.OverridePath`. (@NogginBops)

* API: Added `NativeWindowSettings.AutoIconify` and `NativeWindow.AutoIconify` property to control if the window gets minimized if it loses focus while fullscreen. (@MV10)

* API: Added missing enums to `GetPName`. (@BoyBaykiller)

* FIX: Fixed an issue where creating a `NativeWindow` on wayland would freeze in the constructor. (@Th3Dilli)

* BREAKING: Re-implemented `Box2/3.Inflate` to work like `System.Drawing.Rectangle.Inflate`. The old behaviour can be found using `Box2/3.Extend`, as the previous obsoletion message stated. (@MV10, @NogginBops)

* Add example of how to implement `IBindingsContext` in the documentation comments on `IBindingsContext`. (@utkumaden)

* Internal changes to make the build system simpler and easier to modify. (@NogginBops)

* Internal changes from `Math` to `MathF` where appropriate. (@MV10)

## 4.8.1

* API: Added `NativeWindow.HasTransparentFramebuffer` to be able to check if a transparent framebuffer was created successfully. (@NogginBops)

* API: Added missing enum entries in `OpenCL.ContextProperties`. (@NogginBops)

* FIX: `NativeWindowSettings.StartVisible = false` has been fixed and should now work as expected. (@NogginBops)

* FIX: Fixed issue where `JoystickState.GetAxis` returned buttons instead of axes. (@NogginBops)

* FIX: Fixed issue where self-contained `dotnet publish` would break due to duplicate `libglfw.so` files. (@Th3Dilli)

* FIX: Setting `NativeWindow.WindowState` will now be reflected in `OnResize` event caused by it. (@NogginBops)

* FIX: `GameWindow.UpdateTime` is now correctly updated, fixing an issue that first appeared in `4.7.1`. (@NogginBops)

* FIX: Fixed typo in deprecation message for `GameWindow.RenderFrequency`. (@postmeback)

## 4.8.0

* BREAKING: Renamed the `OpenTK.OpenAL` assembly to `OpenTK.Audio.OpenAL` to match the namespace. (@NogginBops)

* BREAKING: Make OpenAL extensions nested classes of `AL` and `ALC` instead of being namespaces to more closely match the OpenGL bindings. (@NogginBops)

* BREAKING: Removed `AL.BindBufferToSource`, `AL.GetSourceState`, `AL.GetSourceType`, and `ALC.GetAvailableSamples` that doesn't exist in the OpenAL API (use `AL.Get*` and `ALC.Get*` instead). (@Khhs167, @NogginBops)

* BREAKING: `NativeWindow.Location`, `NativeWindow.Size`, and `NativeWindow.Bounds` now correctly refer to the external size and location of the window. (@NogginBops)

* BREAKING: Removed a few functions marked `[Obsolete]` since at least `4.7.2` but some even older. (@NogginBops)

* BREAKING: Removed `OpenTK.Core.Utils.Swap<T>`, use `MathHelper.Swap<T>` instead. (@NogginBops)

* API: Rename `Box.Inflate` to `Box.Extend`, and mark `Box.Inflate` as obsolete so we can change the behavior of `Box.Inflate` in future versions. (@NogginBops)

* API: Added `GameWindow.TimeSinceLastUpdate()` and `GameWindow.ResetTimeSinceLastUpdate()` which are useful when dealing with the modal move/resize loop on windows. (@NogginBops)

* API: Added `NativeWindow.RawMouseInput` and `NativeWindow.SupportsRawMouseInput` for activating raw mouse input. (@NogginBops)

* API: Added opt-in preliminary GLFW Wayland support through the environment variable `OPENTK_4_USE_WAYLAND` (it's broken when used with `GameWindow` or `NativeWindow` in this version). (@NogginBops)

* API: Updated the `GameWindow` run loop to be much more accurate. Exposed `GameWindow.ExpectedSchedulerPeriod` to tell OpenTK how accurate `Thread.Sleep` can be expected to be (this defaults to good defaults for Windows, Linux, and macos). (@NogginBops)

* FIX: Cleaned up some internal OpenGL definitions (doesn't change any bindings). (@BoyBayKiller)

* API: Expose `MouseCursor.StandardShape` as public. (@NogginBops)

* API: Add `VectorNi.EuclideanLengthSquared`. (@NogginBops)

* FIX: Added helpful exception message to `NativeWindow` when running with trimmed assemblies with a workaround for the issue. (@NogginBops)

* FIX: Fixed an issue where starting `NativeWindow` as a fullscreen window and then going to a normal window would throw an exception. (@NogginBops)

## 4.7.7

* FIX: `ToString()` on all math types no longer throw `NullReferenceException`. (@NogginBops)

## 4.7.6

**This version is broken, use 4.7.7 instead.**

* BREAKING: Changed the default value of `NativeWindowSettings.Flags` from `ContextFlags.Default` to `ContextFlags.ForwardCompatible` for better out of the box macos support. (@NogginBops)

* API: Added `NativeWindowSettings.TransparentFramebuffer` and `NativeWindowSettings.VSync`. (@NogginBops)

* API: Component-wise `Lerp` methods for `float` and `double` vector types. (@g7ChoGXh)

* API: Implemented `IFormattable` for most `OpenTK.Mathematics` types. (@g7ChoGXh)

* API: Add bindings for `EXT_fragment_shading_rate`. (@BoyBaykiller)

* API: Added casts from `Vector2i` and `Vector2` to `System.Drawing.Point`/`System.Drawing.Size` and `System.Drawing.PointF`/`System.Drawing.SizeF` respectively. (@NogginBops)

* API: Added missing entries in `SizedInternalFormat`. (@BoyBaykiller)

* API: `BinaryFormat` now contains the `ShaderBinaryFormatSpirV` enum value. (@NogginBops)

* FIX: Many fixes related to `NativeWindow.WindowState`. Most notably, going from fullscreen to maximized and back works correctly. (@NogginBops)

* FIX: `MonitorInfo.WorkArea` now gives the correct values. (@utkumaden)

* FIX: Spelling and formatting corrections in documentation. (@sg-wizard-maker)

* FIX: Math types now change their formatting when `CurrentCulture` is changed. (@g7ChoGXh)

* FIX: `Matrix4x3`/`Matrix4x3d` now print their final row. (@NogginBops)

* FIX: On Windows, setting `GameWindowSettings.UpdateFrequency` and `GameWindowSettings.RenderFrequency` should be more accurate. For details see documentation for `GameWindow.Run()`. (@NogginBops)

* The OpenTK solution should now build directly in Visual Studio with no need to run `build.cmd` any more. (@NogginBops)

## 4.7.5

* BREAKING: Removed the `ALTest` class from the OpenAL namespace. This was an internal test class that was accidentally included in the package. (@NogginBops)

* API: Deprecated `Box.Contains` function in favor of `Box.ContainsInclusive` and `Box.ContainsExclusive` to explicitly state if the box boundary should be considered contained. (@NogginBops, @Oribow)

* API: Exposed EGL bindings to match the WGL bindings. (@NogginBops)

* API: `Box2`, `Box2d`, `Box2i`, `Box3`, `Box3d`, and `Box3i` now support XML serialization. (@NogginBops)

* API: Added `ProgramBinaryLength` to the `GetProgramParameterName` enum. (@NogginBops)

* FIX: `MathHelper.ClampAngle` and `MathHelper.ClampRadians` now return correct results. (@FlashX64)

* FIX: `MathHelper.NormalizeRadians` now return correct results. (@FlashX64)

* FIX: OpenAL now correctly loads on FreeBSD. (@Partmedia)

* Clarify in the readme that running on Windows requires "Visual C++ Redistributable 2015" (@NogginBops)

* Update to GLFW 3.3.8 (@NogginBops)

## 4.7.4

* FIX: Updated `OpenTK.redist.glfw` nuget reference to the latest version (`3.3.7.27`), the previous `3.3.7.25` had issues on linux.

## 4.7.3

* API: Added overloads for `Vector2i`, `Vector3i`, and `Vector4i` to `GL.Uniform` and `GL.ProgramUniform` family of functions. (@NogginBops)

* API: Added overloads for non-symmetric matrices to `GL.Uniform` family of functions to the `OpenTK.Graphics.OpenGL4` namespace. (@NogginBops)

* API: Added `IsButtonPressed` and `IsButtonReleased` to `JoystickState`, to match `KeyboardState` and `MouseState`. (@g7ChoGXh)

* API: Added `GL_KHR_shader_subgroup` to the bindings. (@BoyBaykiller)

* FIX: Fixed race condition in `RethrowCallbackExceptionsIfNeeded` where some uncaught exceptions in callbacks could be lost. (@NogginBops, @seanofw)

* FIX: Fixed issue where `NativeWindow.OnClosing` and `NativeWindow.Closing` wheren't called when calling `NativeWindow.Close()`. (@NogginBops)

* FIX: Made `CL.EnqueueReadBuffer<T>()` use the correct `sizeof(T)` instead of `sizeof(float)`. This caused issues where the wrong number of bytes where sent, possibly leading to an access violation. (@NogginBops, @Ed-Silver)

## 4.7.2

* BREAKING: Fixed issue where the `QuaternionD(double, double, double)` ctor produced the wrong quaternion. It now produces the same quaternion as `Quaterion(float, float, float)`. (@NogginBops)

* BREAKING: Fixed `QuaterionD.ToEulerAngles` to now produce the correct result. It now matches the result from `Quaterion.ToEulerAngles`. (@NogginBops)

* API: Deprecated `NativeWindow.CursorVisible` and `NativeWindow.CursorGrabbed` in favor of a unified `NativeWindow.CursorState` that disallows invalid combinations. (@NogginBops)

* API: Added `NativeWindowSettings.SrgbCapable` to be able to create a default framebuffer with sRGB capabilities. (@NogginBops)

* API: Added glfw native access funtions added in glfw 3.1. (@NogginBops)

* API: Added `MinimumSize` and `MaximumSize` properties to `NativeWindow` and `NativeWindowSettings`. (@toasty1307)

* API: Added `NativeWindow.ProcessWindowEvents` static function for processing events manually. Prefer this function (with `NativeWindow.ProcessInputEvents`) in a multi-window setup. (@NogginBops)

* API: Exposed `NativeWindow.ProcessInputEvents()` so multi-window setups can update input state of all windows before handling events (using `NativeWindow.ProcessWindowEvents`). (@NogginBops)

* API: Added a proper "main thread" check for glfw. To turn this off, `GLFWProvider.CheckForMainThread` can be set to false. (@NogginBops)

* API: Added all missing enums to `SizedInternalFormat`. (@NogginBops)

* API: Added `TextureCubeMapArray` to `TextureTarget3d`. (@NogginBops)

* API: Added `ParameterBuffer` to `BufferTarget`. (@NogginBops)

* API: Added overloads to `MultiDrawElementsIndirectCount` that takes the proper `DrawElementsType` enum as an argument. (@NogginBops)

* API: Added overloads to `VertexAttribIFormat` and `VertexAttribLFormat` that take `VertexAttribIntegerType` and `VertexAttributeDoubleType` respectively. (@BoyBaykiller)

* API: Added bindings for `NV_mesh_shader`, `NV_shading_rate`, `NV_primitive_shading_rate`, `NV_representative_fragment_test` and `NV_scissor_exclusive` extensions. (@BoyBaykiller)

* API: Enums should now be documented with their minimum version or extension requirements. These are not guaranteed to be 100% accurate but should mostly correct. (@NogginBops)

* API: Added `RawMouseMotionAttribute` enum, to be able to control raw mouse motion from GLFW.

* Fix issue where limiting framerate would cause issues with input functions like `JoystickState.WasButtonPressed` whould have an incorrect value (@NogginBops).

* Updated GLFW to 3.3.7. This should fix an issue where UTF-16 code points where sent to OnTextInput causing it to crash. (@NogginBops, @g7ChoGXh)

* If the update loop gets too far behind it no longer tries to make up for lost time. This was typically caused by resizing the window, and or closing the lid of a laptop. (@daerogami)

* OpenTK no longer put an upper limit on the `System.Runtime.CompilerServices.Unsafe` package. (@NogginBops)

* Fixed so `NativeWindowSettings.DepthBits` and `NativeWindowSettings.StencilBits` actually affect the resulting backbuffer format. (@NogginBops)

* Fixed an issue in `Box3i.Contains(Vector3i)` where one of the comparisons where wrong, causing incorrect results. (@BlakkM9)

* Fixed an issue where `Vector3i.ComponentMin` returned one of the input arguments instead of the proper result. (@Oribow)

* Fixed OpenAL `Buffer(int, BufferLoopPoint, ReadOnlySpan<int>)` overload to no longer crash. (@NogginBops)

## 4.7.1

* BREAKING: Simplifications to the `Monitors` api, hopefully it's easier to work with now. Old functions are marked `[Obsolete]` with directions for equivalent operations with the new API. (@NogginBops)

* BREAKING: Changed `Span<T>` to `ReadOnlySpan<T>` in OpenAL bindings where appropriate. (@NogginBops)

* API: Add more information to `MonitorInfo` such as human-readable names and supported video modes. (@NogginBops, @utkumaden)
* API: Added component-wise division operators for vector types (@NogginBops, @wildniklin)
* API: Added missing `One` and `Zero` static readonly fields to `Vector3i` (@NogginBops, @wildniklin)

* API: Implemented `AL_SOFT_loop_points` OpenAL extension. (@NogginBops)

* Passing `ContextAPI.NoAPI` in `NativeWindowSettings.ContextAPI` will not create an OpenGL context. This allows you to use `NativeWindow` to create a vulkan context, see #1334. (@arakis, @NogginBops)

* Added warning to documentation that `ClientSize` will not be guaranteed to have updated values in the `OnMaximized` and `OnMinimized` callbacks. (@NogginBops, @wo80)

* Updated to GLFW 3.3.5. (@NogginBops)

* FIX: Fix invalid IL generation for some edge case GL ES functions, AOT compiling OpenTK now works correctly!! (@NogginBops, thanks @jkotas for helping me understand the issue)

* FIX: Fix `Box3` documentation referencing 2D concepts. (@CaiB)

* FIX: Fixed `MathHelper.MapRange` so that it no longer always throws division by zero exceptions. (@jdmisek)

* FIX: Fixed `OnUnload` so that it's acutally called in all cases when closing the window. (@NogginBops, @adfcf)

* FIX: Wrap all callbacks in exception handlers that will then rethrow these exceptions at the end of `NativeWindow.ProcessEvents()` so that exceptions don't unwind into native calls which is a problem on non-windows platforms. (@NogginBops, @PJB3005)

* FIX: Fix `NativeWindow.IsExiting` and `NativeWindow.Exists` so that they actually contain correct values. (@NogginBops)

* FIX: Fix `Box2d.Translate` and `Box2i.Translate`, this fix also fixes setting the `Box2d.Center` and `Box2i.Center` properties. (@NogginBops, @yts233)

* FIX: Made JoystickCallback still work when multiple windows are used. (@TheBlubb14)

* FIX: The MonitorCallback no longer gets garbage collected and crashes the program when called. (@NogginBops)

* Deprecated the `Closed` event and then `OnClosed` virtual method, they where never called and now we explicitly say so. (@NogginBops)

* Deprecated `NativeWindowSettings.IsFullscreen`, use `NativeWindowSettings.WindowState` instead. (@NogginBops)

* Deprecated `NativeWindowSettings.IsMultiThreaded`, Render/Update split isn't a great idea then multithreading and users can easily spin up an "update" thread themselves. (@NogginBops)

## 4.7.0

This released was built using a broken build script.
4.7.1 is released with a fixed build script and the change log for 4.7.1 is identical to this version except the fix to the build script.

## 4.6.7

* FIX: Fixed closing window causing AccessViolations on windows and other crashes on other platforms. (@NogginBops)

## 4.6.6

* FIX: Fixed arithmetic overflow issue in `Box2i.Center` and `Box3i.Center` introduced when making them return correct values.

## 4.6.5

* API: Added settings in `NativeWindowSettings` for controlling backbuffer parameters such as `DepthBits` and `StencilBits`. (@deccer)

* API: Added `SwapInterval` to `IGraphicsContext` and moved `VSync` property from `GameWindow` to `NativeWindow` to allow for more control over vsync. (@softwareantics)

* Updated GLFW to 3.3.4. (@NogginBops)


* FIX: Fixed `Box2i.Center` and `Box3i.Center` returning wrong values. (@NogginBops, thanks @g7ChoGXh for the bug report)
* FIX: Implemented proper disposing of `NativeWindow`. (@NogginBops, thanks @xiejiang2014 for the bug report)
* FIX: Fixed calling conventions on glfw callbacks in 32-bit builds. (@NogginBops)

## 4.6.4

* FIX: Made it so that the singular check in `Matrix4.Invert` is the same between platforms.
In particular this fixes an issue where the singular check was too aggressive in the SSE3 path. (@NogginBops)
* FIX: Made checking for OpenAL extensions not crash if the extension wasn't present. (@NogginBops)
* FIX: Fix to the rewriter to not generate invalid IL on some GLES functions. (@NogginBops)

* Updated CONTRIBUTING.md to not contain broken links. (@asears)

## 4.6.3

* FIX: Fixed an issue where `Matrix4.Invert` threw an exception if the matrix determinant was negative. (@NogginBops, thanks for reporting @ghidosoft)

## 4.6.2

* FIX: The package should now be built corretly and work on .net core 3.1 and up. (@PJB)

## 4.6.1

* FIX: Made `OpenTK.Mathematics` work on .net standard 2.1 and .net core 3.1 which broke with 4.6.0. (@PJB)

## 4.6.0

* API: Added `cl_khr_gl_sharing` extension for OpenCL which allows OpenCL x OpenGL interop. (@NepNet)

* FIX: Removed allocations from `Matrix4.Invert` and `Matrix3.Invert` and made them about 90% faster. (@NogginBops)

## 4.5.0
* API: Introduced `GameWindow.UpdateTime` to match `GameWindow.RenderTime`. (@NogginBops)
* API: Added GLFW functions for getting platform dependent opengl context pointers. (@NogginBops)

* FIX: `GameWindow.RenderTime` now gets updated correctly. (@NogginBops)
* FIX: Actually assign `APIVersion` property in `NativeWindow`. (@BroMandarin)
* FIX: The `MouseWheelEventArgs` in `OnMouseWheel` now correctly returns a delta instead of an accumulated offset. (@GeorchW)
* FIX: Some overloads for `AL.DeleteSources` where calling `alDeleteBuffers` instead of `alDeleteSources`. (@NogginBops)

## 4.4.0
* API: Added properties ButtonCount, AxisCount, and HatCount to JoystickState (@Ferpsalerp)
* API: Added a method that centers the NativeWindow in the monitor it currently resides (with optional resize) (@Timber1900 and @NogginBops)

### 4.3.0
* API: Add new Monitor Info API (@utkumaden)

* Fix WindowState and StartVisible to behave correctly on MS Windows (@seanofw)
* Fix scrolling getting lost between frames (@NogginBops)
* Fix ContextProfile documentation to be correct (@NogginBops)
* Fix Quaternion -> Matrix3/Matrix4 conversions (@NogginBops)
* Fix wrong binding code generation on some locales (@ahmetsait)

### 4.2.0
* API: Add WGL Bindings + dx_interop extensions.
* API: Add Euclidian/Manhattan Distance to Vector2/3/4i (@NogginBops)
* API: Add Vector Range Mapping (@NogginBops)

* Optimized Quaternion to Matrix3/Matrix4 conversions (~80% faster) (@NogginBops)

### 4.1.0

* API: Switched the type of OpenCL blocking argument to bool (@NepNet)
* API: Add casting from one VectorX to another VectorX (@imkSushi)

* Improvements & fixes for window state transitions (@KinsonDigital)

* Fix generator.bind command line handling (@HowToDoThis)
* NativeWindow disposal improvements (@KinsonDigital)
* Fix JoystickState ToString (@albfan)
* Fix to scroll wheel effecting mouse position (@NogginBops)
* Window border bug fix (@KinsonDigital)
* Added IsKeyPressed/IsKeyReleased to KeyboardState (@NogginBops)
* Fixed delta mouse position (@strexicious)
* Fixed scrolling so that you can actually detect per frame deltas (@NogginBops)
* Added scroll data to MouseState (@NogginBops)
* Fix StartVisible = false not working (@FriendlyChicken)

### 4.0.6
* Fix mouse delta being backwards (@strexicious)

### 4.0.5
* Fix scrolling delta (@NogginBops)

### 4.0.4
* Add scroll wheel support (@NogginBops)
* Fix Windowing minimized on startup (@FriendlyChicken)
* Minor documentation fixes (@NogginBops)

### 4.0.3
* Fix input regression for IsKeyReleased and IsKeyPressed (@FriendlyChicken)
* Invert GetWindowAttrib Decorated check for window border (@FriendlyChicken)
* Internal math improvements (@NogginBops)


### 4.0.2
* Fix for duplicate mouse state updates (Thanks @HughPH)


### 4.0.1

* Internal code improvements & fixes (@NogginBops)
* Remove memory allocations from joystick axes every frame (@K0bin)
* Remove memory allocations from KeyboardState + MouseState Updates (@HughPH)

### 4.0.0
Huge thanks and congratulations to the entire OpenTK Community for getting this release together.

Key changes:
 * Full support for .Net Core 3.1
 * Brand new GLFW-based windowing system
 * Brand new GLFW-based input system
 * Removed all platform-specific backends (and fixed every xplat bug!)
 * Math library performance improvements and fixes
 * All new OpenAL bindings
 * All new OpenCL Bindings
 * Total restructure of all packages into a modular system with a number of packages. The OpenTK package is now a metapackage that will automatically download all of these for you.

OpenTK 4.0.0 is entirely MIT licensed.

Full Log:
* Input fixes (@HughPH)
* Link to the tutorial in the package description.
* Fix for broken delegates (@HughPH)
* Significant rework & improvements to input. (Massive Thanks to @Phyyl, @HughPH and @NogginBops)
* Fixes to OpenAL Bindings (@NogginBops)
* General Math improvements (@NogginBops)
* Added OpenCL Bindings (Huge thanks to @NepNet)
* Fix opentk.redist.glfw version warnings (@jvbsl)
* Add support for window-level multisampling (@jvbsl)
* Allow null delegates for GLFW callbacks (@jvbsl)
* Add new API to get/set from GLFW window/context attributes (@jvbsl)
* Add vulkan surface creation (@jvbsl)
 * Fix bindings generator for net2.1
 * GLFW Native Access bindings. (@RedImp1470 @NogginBops)
 * Fixed normalization in Vector3.Unproject (@burnss9)
 * General windowing improvements and new Graphics Context API. (@NogginBops)
 * Use correct function in SetCharModsCallback (@jvbsl)
 * Return namespaces to the glorious OpenTK (thanks @glopes)
 * Simplified OpenAL loading + add more extensions (@NogginBops)
 * Fixed initial focused inconsistency between Windows and Linux(X11) (@jvbsl)
 * Improved and fixed GLFW binary loading (@jvbsl)
 * Improved mono compat (@jvbsl)
 * Fixed GetLibraryName for iOS platform (thanks @Grizley56)
 * Fixed InputAction for getting Joystick Buttons from GLFW (thanks @HughPH)
 * Fixes reference conditions
 * Save Size property value to _size field (thanks @devel0)
 * Update build.fsx.lock (thanks @CallumDev)
 * Vector3.Unproject returning incorrect result (thanks @leezer3)
 * Incorrect parameter order in QuaternionD constructor (thanks @leezer3)
 * Capslock value not exposed (thanks @KinsonDigital)
 * vector transforms
 * Start of input mode setup for caps lock (thanks @KinsonDigital)
 * Use in parameters instead of ref (thanks @cryovat)
 * OpenTK now includes **OPENAL!** (Biggest thanks to *@NogginBops*)
 * Added check for invalid keys in window key callback (Thanks @Phyyl)
 * Fix rounding errors on tests
 * Add individual project descriptions
 * Add openAL to the build sequence.
 * Added PositiveInfinity and NegativeInfinity to vector structs (Thanks @arakis)
 * Fixed ClientSize not getting updated in OnResize (Thanks @Phyyl)
 * Fix automatic bindings initialization for GL2 (Thanks @Phyyl)
 * Add framework specification to paket files. (Thanks @frederikja163)
 * Fixed GameWindow update frequency (Thanks @MerickOWA)
 * Throw an InvalidOperationException if bindings are uninitialized. (Thanks @PJB)
 * Added Profile Any (Thanks @arakis)
 * Fix error with GLFW Mouse button mapping (Thanks @GeorchW)
 * Build System improvements to fully automatic pipeline.
 * Test and fix build system
 * Fix package metadata
 * Change: Make Command a valid modifier on OS-X #759
 * Splitting Platform/Windows/API.cs into OpenTK.NT #765
 * Immediately return after restoring resolution #766
 * Fix OpenTK.Mathematics assembly name #768
 * [4.0] Implement 'unmanaged' constraint #771 
 * Close display connection for X11 on dispose #773
 * [4.0] Fix StyleCop analysis not working on Windows #775
 * Fixed incorrect Quaternion/Vector rotation #777
 * [4.0] Build Cleanup #778
 * Fixed type for VertexAttribPointer #779
 * [4.0] Fix numerous binder errors #781
 * Fix #USE_SDL2_GAMECONTROLLER code path #782
 * [4.0] Refactor Generator.Rewrite #783
 * [4.0] Fix two typos in CONTRIBUTING.md #785
 * Add common.props for use in all projects #786
 * [4.0] Auto-update OpenTK.sln (done by VS2017) #787
 * Add missing build configs (VS2017) #788
 * Fixed OpenGL 3.2+ Context Creation (Mixed up Profile Mask / Flags) #790
 * [4.0] Create new .sln file for all new projects #791
 * [4.0] Fix CI scripts #792
 * [4.0] Fix general StyleCop errors #793
 * [4.0] Some more small rewriter changes #794
 * [4.0] Refactor Generator.Bind#795
 * [4.0] Get CI to succeed #796
 * Fix: Custom cursors not working under OS-X and dotnet #797
 * [4.0] Fix stylecop errors in OpenTK.Mathematics.#798
 * Fix OpenTK.NT compilation errors #799
 * [4.0] Fix OpenTK.AL compilation errors #800 
 * 4.0 #802
 * Fix csproj references to target netstandard2.0 instead of net461. #803
 * Style guide#804
 * [4.0] Integrate OpenTK.OpenAL#805
 * [4.0] refactored .Math stylecop errors #806
 * Use props/ directory directly #813
 * Add #814 to 4.0 #815
 * Fix document typo #818
 * Binder Docs + Performance#826
 * [4.0] Embedded license handling for binding generator #836
 * [4.0] Adding directory safety to the binder. #837
 * Update README after branch changes #839
 * [4.0] Add StructLayout to Color4#840
 * [4.0] Change root namespace to OpenTK #842
 * Fix the aftermath of merging #842 #843
 * [4.0] Impliment Vectord * Quaterniond #844
 * Fix aftermath of #842 #846
 * [4.0] Minor edits to README.md #848
 * [4.0] Update SDL2 version check #849
 * [4.0] Remove big chunk of unused code from Quaterniond.cs #852
 * [4.0] Remove GLES 1.0 and 1.1 support #856
 * [4.0] Add explicit operators for Color4/Vector4 conversions #858
 * [4.0] Remove unused code #860
 * [4.0] Begin moving Input to OpenTK.Input#861
 * [4.0] Begin moving Platform to OpenTK.Platform #862
 * [4.0] Add RootNamespace tags to projects#863
 * OpenGL Reimplementation #864
 * Input and Windowing via GLFW #867
 * Bindings generator for modularity and ADL#871
 * Update licensing information #875
 * Update Discord link. #876
 * Optimize Vector4/Color4 conversions with Unsafe.As #877
 * Apply Unsafe.As optimization to all vector types #878
 * Fix discord invite link #881
 * Ignoring MouseMoveEx errors and fall back to passed point. #883
 * Rename license files to avoid confusion. #885
 * Emergency fix in short license terms #887
 * [4.0] Adding Lerp function in the math helper #895
 * System.Math and OpenTK.MathHelper symmetry #897
 * Shorten float literals to the actual float value #898
 * Reflect 22/04/2019 development discussion #902
 * Remove obsolete methods within Vector types. #906
 * Add vector types with integer components. #908
 * OpenAL cleanup #909
 * Organise master #912
 * Purity annotations for Math types #915
 * Int vectors in windows #917
 * Box2i support #918
 * add Box3 #919
 * Box2n and Box3n cleanup #920
 * Add API to let users pick OpenGL version #921
 * Add Quaternion to Euler angles conversion #923
 * Fix binder script paths #924
 * Restore unit tests #925
 * Box tests #926
 * GLFW Input. #928
 * Improve EditorConfig file. #929
 * Adds Vulkan related GLFW methods to IGLFW. #930
 * Fixes the binder and makes it 10x faster. #931
 * Add tuple deconstructors and conversions to vector types. #933
 * Fix ToHSV and ToHsl functions generating nan when they shouldn't #934
 * Build System for 4.0 #936
 * Hid input #943
 * Implement ppi in INativeWindow. #945
 * Feature/new Bindings generator #946
 * PlaceholderGL#948
 * Fix Quaternion(euler angle order -> roundtrip tests)#949
 * Fix windowing tests #950
 * chmod +x build.sh #951
 * Fix <LangVersion> getting applied to F# projects. #952
 * Feature/fix box contains #953
 * Test fixes #954
 * Fix PlatformLibraryNameContainerBase on macOS. #962
 * Make GLFW.Image better. #963
 * Default GameWindowSettings.IsSingleThreaded to true. #964
 * Improve mouse cursor handling. #965
 * Fix window icon handling. #966
 * Clean up window events. #967
 * Fix file drop events. #968
 * Fix incorrect type on glfwGetError. #969
 * Move GLFWProvider to Windowing.Desktop. #970
 * Make GLFW structs simpler. #971
 * Clean up window properties/interfaces. #972
 * OpenGL_Bindings.csproj: Call bash instead of sh #974
 * Quaternion(d): Modify instance Invert() to match static functions #975
 * Remove ADL from GLFW. Use DllImport. #976
 * Begin work on merging OpenAL extensions. #986
 * Fix CI system #988
 * GLFW API cleanup. #989
 * Remove reference to Mathematics from GLFW bind. #990
 * Revised boostrap process + update build tools #992
 * Add remaining GLFW Window functions #996
 * Bring forward 3.x binding generators to 4.0 #1004
 * Add matrix multiplication + missing operator to Vector2/Vector2d #1011
 * Optimize barycentric interpolation #1019


### 4.0.0-pre9.10
* Input fixes (@HughPH)
* Link to the tutorial in the package description.

## 4.0.0-pre9.9
* Fix for broken delegates (@HughPH)

## 4.0.0-pre9.8
* Significant rework & improvements to input. (Massive Thanks to @Phyyl, @HughPH and @NogginBops)
* Fixes to OpenAL Bindings (@NogginBops)
* General Math improvements (@NogginBops)
* Added OpenCL Bindings (Huge thanks to @NepNet)

## 4.0.0-pre9.7
* Fix opentk.redist.glfw version warnings (@jvbsl)
* Add support for window-level multisampling (@jvbsl)
* Allow null delegates for GLFW callbacks (@jvbsl)
* Add new API to get/set from GLFW window/context attributes (@jvbsl)
* Add vulkan surface creation (@jvbsl)

## 4.0.0-pre9.6
 * Fix bindings generator for net2.1

## 4.0.0-pre9.5
 * GLFW Native Access bindings. (@RedImp1470 @NogginBops)
 * Fixed normalization in Vector3.Unproject (@burnss9)
 * General windowing improvements and new Graphics Context API. (@NogginBops)
 * Use correct function in SetCharModsCallback (@jvbsl)

## 4.0.0-pre9.4
 * **moved to dotnetcore only**
 * Return namespaces to the glorious OpenTK (thanks @glopes)
 * Simplified OpenAL loading + add more extensions (@NogginBops)
 * Fixed initial focused inconsistency between Windows and Linux(X11) (@jvbsl)

### 4.0.0-pre9.3
 * Improved and fixed GLFW binary loading (@jvbsl)
 * Improved mono compat (@jvbsl)
 * Fixed GetLibraryName for iOS platform (thanks @Grizley56)
 * Fixed InputAction for getting Joystick Buttons from GLFW (thanks @HughPH)

### 4.0.0-pre9.2
 * Fixes reference conditions
 * Save Size property value to _size field (thanks @devel0)
 * Update build.fsx.lock (thanks @CallumDev)
 * Vector3.Unproject returning incorrect result (thanks @leezer3)
 * Incorrect parameter order in QuaternionD constructor (thanks @leezer3)
 * Capslock value not exposed (thanks @KinsonDigital)
 * vector transforms
 * Start of input mode setup for caps lock (thanks @KinsonDigital)
 * Use in parameters instead of ref (thanks @cryovat)

### 4.0.0-pre9.1
 * OpenTK now includes **OPENAL!** (Biggest thanks to *@NogginBops*)
 * Added check for invalid keys in window key callback (Thanks @Phyyl)
 * Fix rounding errors on tests
 * Add individual project descriptions
 * Add openAL to the build sequence.

### 4.0.0-pre9
 * Added PositiveInfinity and NegativeInfinity to vector structs (Thanks @arakis)
 * Fixed ClientSize not getting updated in OnResize (Thanks @Phyyl)

### 4.0.0-pre8
 * Fix automatic bindings initialization for GL2 (Thanks @Phyyl)

### 4.0.0-pre7
* Add framework specification to paket files. (Thanks @frederikja163)

### 4.0.0-pre6
* Fixed GameWindow update frequency (Thanks @MerickOWA)
* Throw an InvalidOperationException if bindings are uninitialized. (Thanks @PJB)

### 4.0.0-pre5
 * Added Profile Any (Thanks @arakis)

### 4.0.0-pre4
 * Fix error with GLFW Mouse button mapping (Thanks @GeorchW)

### 4.0.0-pre3
 * Build System improvements to fully automatic pipeline.

### 4.0.0-pre2
 * Test and fix build system
 * Fix package metadata

### 4.0.0-pre
 Key Changes:
 * Added support for .Net Core
 * Removed all platform-specific backends.
 * Brand new GLFW-based windowing system.
 * Brand new GLFW-based input system.
 * Math library performance improvements and fixes.
 * Changed root namespace to OpenTK for future Xamarin compatibility - (https://github.com/mono/opentk/issues/19)

Note:
- 4.0.0-pre does not include any version of openAl, as that still depends on ADL

OpenTK 4.x is entirely MIT licensed and does not use ADL.

Full Log:
* Change: Make Command a valid modifier on OS-X #759
 * Splitting Platform/Windows/API.cs into OpenTK.NT #765
 * Immediately return after restoring resolution #766
 * Fix OpenTK.Mathematics assembly name #768
 * [4.0] Implement 'unmanaged' constraint #771 
 * Close display connection for X11 on dispose #773
 * [4.0] Fix StyleCop analysis not working on Windows #775
 * Fixed incorrect Quaternion/Vector rotation #777
 * [4.0] Build Cleanup #778
 * Fixed type for VertexAttribPointer #779
 * [4.0] Fix numerous binder errors #781
 * Fix #USE_SDL2_GAMECONTROLLER code path #782
 * [4.0] Refactor Generator.Rewrite #783
 * [4.0] Fix two typos in CONTRIBUTING.md #785
 * Add common.props for use in all projects #786
 * [4.0] Auto-update OpenTK.sln (done by VS2017) #787
 * Add missing build configs (VS2017) #788
 * Fixed OpenGL 3.2+ Context Creation (Mixed up Profile Mask / Flags) #790
 * [4.0] Create new .sln file for all new projects #791
 * [4.0] Fix CI scripts #792
 * [4.0] Fix general StyleCop errors #793
 * [4.0] Some more small rewriter changes #794
 * [4.0] Refactor Generator.Bind#795
 * [4.0] Get CI to succeed #796
 * Fix: Custom cursors not working under OS-X and dotnet #797
 * [4.0] Fix stylecop errors in OpenTK.Mathematics.#798
 * Fix OpenTK.NT compilation errors #799
 * [4.0] Fix OpenTK.AL compilation errors #800 
 * 4.0 #802
 * Fix csproj references to target netstandard2.0 instead of net461. #803
 * Style guide#804
 * [4.0] Integrate OpenTK.OpenAL#805
 * [4.0] refactored .Math stylecop errors #806
 * Use props/ directory directly #813
 * Add #814 to 4.0 #815
 * Fix document typo #818
 * Binder Docs + Performance#826
 * [4.0] Embedded license handling for binding generator #836
 * [4.0] Adding directory safety to the binder. #837
 * Update README after branch changes #839
 * [4.0] Add StructLayout to Color4#840
 * [4.0] Change root namespace to OpenTK #842
 * Fix the aftermath of merging #842 #843
 * [4.0] Impliment Vectord * Quaterniond #844
 * Fix aftermath of #842 #846
 * [4.0] Minor edits to README.md #848
 * [4.0] Update SDL2 version check #849
 * [4.0] Remove big chunk of unused code from Quaterniond.cs #852
 * [4.0] Remove GLES 1.0 and 1.1 support #856
 * [4.0] Add explicit operators for Color4/Vector4 conversions #858
 * [4.0] Remove unused code #860
 * [4.0] Begin moving Input to OpenTK.Input#861
 * [4.0] Begin moving Platform to OpenTK.Platform #862
 * [4.0] Add RootNamespace tags to projects#863
 * OpenGL Reimplementation #864
 * Input and Windowing via GLFW #867
 * Bindings generator for modularity and ADL#871
 * Update licensing information #875
 * Update Discord link. #876
 * Optimize Vector4/Color4 conversions with Unsafe.As #877
 * Apply Unsafe.As optimization to all vector types #878
 * Fix discord invite link #881
 * Ignoring MouseMoveEx errors and fall back to passed point. #883
 * Rename license files to avoid confusion. #885
 * Emergency fix in short license terms #887
 * [4.0] Adding Lerp function in the math helper #895
 * System.Math and OpenTK.MathHelper symmetry #897
 * Shorten float literals to the actual float value #898
 * Reflect 22/04/2019 development discussion #902
 * Remove obsolete methods within Vector types. #906
 * Add vector types with integer components. #908
 * OpenAL cleanup #909
 * Organise master #912
 * Purity annotations for Math types #915
 * Int vectors in windows #917
 * Box2i support #918
 * add Box3 #919
 * Box2n and Box3n cleanup #920
 * Add API to let users pick OpenGL version #921
 * Add Quaternion to Euler angles conversion #923
 * Fix binder script paths #924
 * Restore unit tests #925
 * Box tests #926
 * GLFW Input. #928
 * Improve EditorConfig file. #929
 * Adds Vulkan related GLFW methods to IGLFW. #930
 * Fixes the binder and makes it 10x faster. #931
 * Add tuple deconstructors and conversions to vector types. #933
 * Fix ToHSV and ToHsl functions generating nan when they shouldn't #934
 * Build System for 4.0 #936
 * Hid input #943
 * Implement ppi in INativeWindow. #945
 * Feature/new Bindings generator #946
 * PlaceholderGL#948
 * Fix Quaternion(euler angle order -> roundtrip tests)#949
 * Fix windowing tests #950
 * chmod +x build.sh #951
 * Fix <LangVersion> getting applied to F# projects. #952
 * Feature/fix box contains #953
 * Test fixes #954
 * Fix PlatformLibraryNameContainerBase on macOS. #962
 * Make GLFW.Image better. #963
 * Default GameWindowSettings.IsSingleThreaded to true. #964
 * Improve mouse cursor handling. #965
 * Fix window icon handling. #966
 * Clean up window events. #967
 * Fix file drop events. #968
 * Fix incorrect type on glfwGetError. #969
 * Move GLFWProvider to Windowing.Desktop. #970
 * Make GLFW structs simpler. #971
 * Clean up window properties/interfaces. #972
 * OpenGL_Bindings.csproj: Call bash instead of sh #974
 * Quaternion(d): Modify instance Invert() to match static functions #975
 * Remove ADL from GLFW. Use DllImport. #976
 * Begin work on merging OpenAL extensions. #986
 * Fix CI system #988
 * GLFW API cleanup. #989
 * Remove reference to Mathematics from GLFW bind. #990
 * Revised boostrap process + update build tools #992
 * Add remaining GLFW Window functions #996
 * Bring forward 3.x binding generators to 4.0 #1004
 * Add matrix multiplication + missing operator to Vector2/Vector2d #1011
 * Optimize barycentric interpolation #1019

### 3.1.0

	General:

	* Fixed problem where OpenGL 3.2 contexts where created using the wrong flags, causing renderdoc error (#790).
	* Fixed problem where Vector3.Transform(Quaternion) returned incorrect results ( #776 ).
	* SDL backend no longer handles exceptions thrown in input events ( #735 #737 )
	* Updated gamepadd mappings for SDL (#927).
	* Alt + numpad now results in correct data being passed to OnKeyPress (f17fa4b).

	Windows:

	* Keypress events are using CharSet.Unicode to allow for UTF characters.
	* If GetMouseMovePointsEx returns "access denied" we fall back to the old mouse move handling ( #883 ).
	* Detect joysticks which declare no valid controls & ignore (Cherry-picked from #819 ).
	* Fix where an invalid joystick axis overwrites the first joystick axis. (Cherry-picked from #819 ).
	* Makes the ArbCreateContext return valid settings ( #754 ).

	MacOS:

	* Unprocessed events no longer put the application into a partially-activated state ( #732 ).
	* Multiple fixes under PR #914:
	* NativeWindow.CursorVisible no longer resets the mouse position ( #668 ).
	* Custom cursors should work now ( e598ab2 ).
	* Command key is now a valid modifier ( 286119e ).
	* Fix where KeyDown events would trigger KeyPress when they shouldn't, e.g. when pasting ( ea3dd48 ).
	* KeyPress now receives the correct keycodes even if modifiers where held when typing ( 91b03dd ).

  	Internal:

	* Generator.Build now uses invariant culture for parsing avoiding an exception when the local system uses comma as decimal separator ( #750 ).
	* Removed weird assembly version check fixing #710.
	* Fixed Xamarin project so that it compiles ( See #725 and b16e7fa ).
	* Matrix4 uses unsafe to invert for performace ( #719 ).
	* Removed link to gitter chat, discord is where it's at ( #770 ).

### 3.0.1
    * Hotfix release
    * Fixed an issue with vector transformation

### 3.0.0
    * Final .NET Framework release
    * Numerous bug fixes

### 3.0.0-pre
	* Support for OpenGL 4.6
	* Replaced JoystickButton enum with simple long. (breaking API change)
	* Increase available joystick buttons to 64.
	* Add support for OpenGL ES3 through Angle + DIrect3D.
	* Fix 2 crashes on android
	* Move to built-in System.Diagnostics.Debug for Android + iOS
	* Fix for certain joysticks returning invalid HID pages.
	* Fix for certain joysticks with negative axis range being inverted.
	* Fix Xbox controller D-pad on windows
	* Fix joystick hat position sticking on Linux
	* Enhance xbox button detection to include GUIDE button.
	* Fix iOS GL bindings issue introduced by 2ea8334
	* Fix crash on setting time to <= 0 for iOS + Android.
	* Several minor XML documentation fixes and enhancements
	* Fix for angle backbuffer size issue on window resize
	* Possible fix for broken GLControl package.

### 2.0.0
	* Moved to new FAKE/Paket based build system
	* Removed superfluous release configurations
	* Numerous other fixes and enhancements

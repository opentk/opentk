## 5.0-pre.15

* Optimize vector and matrix indexers so they are actually inlined correctly. (@BoyBaykiller)
* Changed `Matrix4.Invert` to throw using a throw helper method. (@BoyBaykiller)
* Remove unecessary aggressive inlining hint from internal functions `Matrix4.InvertSee3` and `Matrix4.InvertFallback`. (@BoyBaykiller)

**OpenAL bindings changes**:

* Introduces new generated bindings for the entire OpenAL API. (@NogginBops)

**Vulkan bindings changes**:

* Version constants are now correctly typed as `uint` again. (@NogginBops)

**OpenGL bindings changes**:

* Bindings have been modified to be more compatible with trimming, allowing most of the bindings to be trimmed where they wouldn't be able to before. (@BoyBaykiller)

**PAL2 changes**:

* Added `Toolkit.OpenGL.GetContextValues` to get the actually selected OpenGL context settings. (@NogginBops)
* Add `defaultFileName` argument to `Toolkit.Dialog.OpenSaveDialog` to prefill/suggest a file name to the user. (@NogginBops)
* Add `OpenGLGraphicsApiHints.Stereo` and `ContextValues.Stereo` to be able to enumerate and select context settings that allow stereoscopic rendering. (@NogginBops)

win32:

* Add `DisplayComponent.GetColorInfo` for getting display color volume and HDR info. (@NogginBops)

x11:

* Fix crash when unfocusing a window when using non-IME input (@NogginBops)
* Fix issue where `ContextValues.DepthBits` and `ContextValues.StencilBits` where not set correctly causing enumeration to select context values that are not the requested values. (@NogginBops)

## 5.0-pre.14

* Added generic math interfaces to all vector and matrix types. (@vovatrykoz)
* Add boolean vectors `VectorNb` and comparison operators for vectors. (@NogginBops)
* Add `scalar + vecor`, `scalar - vector`, and `scalar / vector` operator overloads for vectors. (@BoyBaykiller)
* Add `JoystickState.GUID`. (@DamensIsPoggers)
* Merged latest OpenTK 4.9.4 changes onto 5.0-pre.14. (@NogginBops)
* Mark many properties and functions as `readonly` in math library. (@BoyBaykiller)
* Made GLFW loading compatible with `IlcDisableReflection. (@BoyBaykiller)

**Vulkan bindings changes**:

* Update vulkan bindings to 1.4.321. (@NogginBops)
* Add `InstanceDispatchTable` and `DeviceDispatchTable` dispatch tables for more efficiently calling vulkan functions. (@NogginBops)
* Fix aliased structs so that they actually contain the correct memebers. (@NogginBops)
* Functions, handles, structs and enums now have correct version and deprecation info documented. (@NogginBops)
* Annotated structs and enums with functions that use them. (@NogginBops)
* Fix XML escape codes in documentation comments. (@NogginBops)

**OpenGL bindings changes**:

* Add `string[]` overloads to functions where applicable. (@NogginBops)
* Remove `VertexBufferObjectUsage` in favor of `BufferUsageHint`. (@NogginBops)

**PAL2 changes**:

* Add `Toolkit.Window.PostUserEvent` multi-threaded API on all plaforms for posting events to the main thread (useful with `waitForEvents = true`). (@NogginBops)
* Add `ToolkitOptions.FeatureFlags` for specifying if pal2 should load OpenGL and/or Vulkan components. (@NogginBops)

win32:

* Fix raw mouse motion. (@JoeTwizzle)
* Add platform specific api for setting window taskbar progress, `ShellComponent.SetProgressStatus`. (@NogginBops)
* Fix transitioning from `WindowState.Hidden` to `WindowState.*Fullscreen` directly. (@NogginBops)
* 

macOS:

* Support for IME text input though `Toolkit.Keyboard.BeginIme`, `Toolkit.Keyboard.SetImeRectangle`, and `Toolkit.Keyboard.EndIme`. (@NogginBops)
* Add platform specific api for setting window taskbar progress, `ShellComponent.SetProgressStatus`. (@NogginBops)
* Support `waitForEvents = true` in `Toolkit.Window.ProcessEvents`. (@NogginBops)
* Animated cursors are not automatically handled, `MacOSCursorComponent.UpdateAnimation` is removed. (@NogginBops)
* Moved `MacOSWindowComponent.SetDockIcon` to `MacOSShellComponent.SetDockIcon`. (@NogginBops)

x11:

* Fix `DllNotFoundException` for `Xrender`. (@NogginBops)
* Make it possible to hide the cursor. (@NogginBops)
* Support for IME text input though `Toolkit.Keyboard.BeginIme`, `Toolkit.Keyboard.SetImeRectangle`, and `Toolkit.Keyboard.EndIme`. (@NogginBops)
* Fix window shadow for opaque windows with transparent Visuals on Ubuntu. (@NogginBops)
* Fix `Toolkit.Window.SetCursorCaptureMode` when running on XWayland. (@NogginBops)
* Fix `Toolkit.Dialog` with newer versions of Zenity. (@NogginBops)

## 5.0-pre.13

* Changed `MarshalTk.MarshalStringArrayToAnsiStringArrayPtr` to take `ReadOnlySpan<string>` instead of `Span<string>`. (@NogginBops)

**Vulkan bindings changes**:

* Add default parameterless constructor to all Vulkan structs so that default member values can be applied (mostly to automatically set `sType`). (@NogginBops)

* Made the Vulkan example project render a triangle. (@NogginBops)

**OpenGL bindings changes**:

* Skip `ref readonly` for singular `Delete*()` functions. (@NogginBops)
* Added generated EGL bindings containing all EGL and ANGLE extensions. (@NogginBops)
* Fixed missing documentation on some OpenGL functions. (@NogginBops)

**PAL2 changes**:

* A lot of documentation improvements. (@NogginBops)
* Added `Toolkit.Window.Get/SetTransparencyMode` to support different modes for window transparency. (@NogginBops)
* Add `reason` parameter to `Toolkit.Shell.AllowScreenSaver`. (@NogginBops)
* Add `Toolkit.Shell.IsScreenSaverAllowed` to be able to check if the screen saver is disabled. (@NogginBops)
* Added `OpenGLGraphicsApiHints.SupportsTransparentFramebufferX11` to mark if the context values selector should look for formats that support framebuffer transparency when on X11 (framebuffer transparency is always supported on Windows and macOS). (@NogginBops)
* Added `ContextValues.SupportsFramebufferTransparency` to check if a particular format supports framebuffer transparency (only relevant on X11). (@NogginBops)
* Updated `ContextValues.DefaultValuesSelector` to handle `SupportsFramebufferTransparency`. (@NogginBops)
* Added `Toolkit.Uninit()` for usecases where unloading OpenTK is useful (don't call this function on application exit). (@NogginBops)
* Added `IPalComponent.Uninitialize()` and implemented it for every component on every platform to make `Toolkit.Uninit()` possible. (@NogginBops)

win32:

macOS:

* Implement `MacOSVulkanComponent` using MoltenVK. (@NogginBops)
* Made dialogs proper window sheets by default. (@NogginBops)
* Added `MacOSDialogComponent.Show*NoWindow` functions for showing dialogs not attached to any window. (@NogginBops)

x11:

* Fixed glX dll resolution to be the same as before 5.0-pre.12 (@NogginBops)
* Fixed memory leak in `X11KeyboardComponent`. (@NogginBops)

ANGLE:

* Switched implementation to use the generated EGL bindings. (@NogginBops)

## 5.0-pre.12

**Vulkan bindings changes:**

* Add links to relevant documentation in Vulkan documentation strings. (@NogginBops)
* Add `[requires: v1.0 | KHR_extension]` strings that document version and extension requirements for function, structs, and enums. (@NogginBops)
* Updated Vulkan to 1.3.295. (@NogginBops)

**OpenGL bindings changes:**

* Switched to using `ref readonly` instead of `in` in OpenGL bindings. (@NogginBops)
* Improvements to glX and WGL bindings. (@NogginBops)

**PAL2 changes:**

* Renamed `Toolkit.Mouse.GetPosition` to `Toolkit.Mouse.GetGlobalPosition`. (@NogginBops)
* Renamed `Toolkit.Mouse.SetPosition` to `Toolkit.Mouse.SetGlobalPosition`. (@NogginBops)
* Renamed `Toolkit.Mouse.GetState` to `Toolkit.Mouse.GetGlobalState`. (@NogginBops)
* Added `Toolkit.Mouse.GetPosition` and `Toolkit.Mouse.GetState` for getting window relative mouse state. (@NogginBops)
* Added `Toolkit.Clipboard.SetClipboardBitmap`. (@NogginBops)
* Added `Toolkit.Window.ClientToFramebuffer` and `Toolkit.Window.FramebufferToClient`. (@NogginBops)
* Switched to using `VectorN` types for most positions and sizes. (@NogginBops)
* Renamed `MouseMoveEventArgs.Position` to `MouseMoveEventArgs.ClientPosition`. (@NogginBops)

win32:

* win32: Switched `OpenGLComponent` to use the generated WGL bindings. (@NogginBops)

macOS:

* macOS: Added `MacOSShellComponent.NSLog` to be able to write to the macOS system log. (@NogginBops)

x11:

* x11: Implemented `X11VulkanComponent` (`Toolkit.Vulkan`). (@NogginBops)
* x11: Implemented `X11ClipboardComponent.SetClipboardText`. (@NogginBops)
* x11: Added `IPngCodec` and `X11ClipboardComponent.SetPngCodec` interface to `X11ClipboardComponent` for optional bitmap support on linux. (@NogginBops)
* x11: Implemented `HitTest` and `Toolkit.Window.SetHitTest`. (@NogginBops)
* x11: Improve `Toolkit.Display` api performance by using `XRRGetScreenResourcesCurrent` instead of `XRRGetScreenResources`. (@NogginBops)
* x11: Fixed issue where pressing cancel in a file dialog would return a list with one empty string in it, instead of null. (@NogginBops)
* x11: Fixed issue where setting a window to Minimized, Maximized, or Fullscreen directly from the Hidden state didn't actually show the window. (@NogginBops)
* x11: Fixed issue where the values for `QueuedAfterFlush` and `QueuedAfterReading` where swapped causing lots of event issues on linux. (@NogginBops)
* x11: Switched `X11OpenGLComponent` to use the generated glX bindings. (@NogginBops)
* x11: Fixed `Toolkit.Window.GetMode` crash when a window doesn't have a `WM_STATE` property set. (@NogginBops)
* x11: Reduce potential memory leaks. (@NogginBops)

## 5.0-pre.11

* Updated all projects to target .net8.0. (@NogginBops)
* Removed `MathHelper` functions that just called directly into `Math` and `MathF`. (@BoyBaykiller)
* Removed old quake inverse sqrt implementation in `MathHelper.InverseSqrtFast` in favour of `Math(F).ReciprocalSqrtEstimate`. (@BoyBaykiller)
* SIMD optimized all MatrixNxM and VectorN equals checks. (@BoyBayKiller, @NogginBops)
* Vector2d.SizeInBytes returns 16 instead of 8. (@BoyBayKiller)
* Merged latest OpenTK 4.8.3 changes onto 5.0-pre.11. (@NogginBops)
  This means that some changes from the upcoming 4.8.3 are also in this release.
  See https://github.com/opentk/opentk/pull/1734 for full details.
  Some of these changes includes: 
  * Update to GLFW 3.4. (@NogginBops)
  * Add swizzle matrices and general math fixes. (@NogginBops)
  * Add `VectorN.Slerp` (spherical interpolation) and `VectorN.Elerp` (exponential interpolation). (@NogginBops)
  * Unclamp `MathHelper.Lerp` so t outside [0, 1] can be used. (@NogginBops)
  * [OpenAL fixes.](https://github.com/opentk/opentk/pull/1716) (@NogginBops)

**Vulkan bindings changes:**

* Added Vulkan API bindings in `OpenTK.Graphics.Vulkan`. Feedback welcome! (@NogginBops)

**OpenGL bindings changes:**

* Removed all automatic length calculations from the OpenGL bindings. (@NogginBops)
* Added `Span<T>` and `T[]` overloads for functions without specified size. (@NogginBops)
* Switch to using `out` by default, and use automatic and manual marking for `in` and `ref`. (@NogginBops)
* Only convert `out` parameters to return values if they are the last `out` parameter. This removes some weird overloads. (@NogginBops)
* Update to latest gl.xml and wgl.xml, resulting in more up to date API definition. (@NogginBops)
* Don't generate return overloads for functions that return more than one item. (@NogginBops)

**PAL2 changes:**

* Introduced the `Toolkit` static class and `ToolkitOptions` which are the main interface for PAL2. (@NogginBops)
* [Added Bejeweled PAL2 demo project.](https://github.com/opentk/opentk/tree/opentk5.0/tests/Bejeweled) (@NogginBops)
* Removed the old `ComponentSet` class. (@NogginBops)
* Added `IDialogComponent` for opening message boxes and open/save file dialogs. (@NogginBops)
* Added `OpenGLGraphicsAPIHints.ContextValueSelector` callback which allows users to enumerate available backbuffer formats when creating a context. Defaults to `ContextValues.DefaultValuesSelector`. (@NogginBops)
* Added `IWindowComponent.GetFramebufferSize` and `WindowFramebufferSize` event. (@NogginBops)
* Added `IWindowComponent.IsFocused`. (@NogginBops)
* Added `IWindowComponent.GetScaleFactor` (@NogginBops)
* Added raw mouse motion API to `IMouseComponent`. (@NogginBops)
* Added `PixelFormat`, `SwapMethod`, `RobustnessFlag`, `ResetNotificationStrategy`, `ResetIsolationFlag`, `NoErrorFlag`, `UseFlushControl`, and `ReleaseBehaviour` to `OpenGLGraphicsApiHints`. (@NogginBops)
* Removed `IClipboardComponent.GetClipboardHTML`. (@NogginBops)

win32:

* win32: Implemented `IDialogComponent`. (@NogginBops)
* win32: Implemented `ContextValueSelector`. (@NogginBops)
* win32: Add `OpenTK.Platform.Windows.OpenGLComponent.UseDwmFlushIfApplicable()` to control whether OpenTK should call `DwmFlush` to potentially fix Vsync issues. (@NogginBops)
* win32: Fix issue where `ShellComponent.SetImmersiveDarkMode` wouldn't trigger a redraw of the window frame. (@NogginBops)
* win32: Added `ShellComponent.SetWindowCornerPreference` to control Windows 11 rounded corners. (@NogginBops)
* win32: Implemented `WindowComponent.GetScaleFactor`. (@NogginBops)
* win32: Fixed issue where `WindowBorderStyle.FixedBorder` would still have the maximize button enabled. (@NogginBops)
* win32: Fixed issue where `ContextStencilBits.None` and `ContextDepthBits.None` would throw an exception. (@NogginBops)
* win32: Implemented `IWindowComponent.ProcessEvents(waitForEvents: true)`. (@NogginBops)
* win32: Added `ToolkitOptions.Windows.EnableVisualStyles` (default true) which enables visual styles for message dialogs to work. (@NogginBops)
* win32: Added `PixelFormat`, `SwapMethod`, `RobustnessFlag`, `ResetNotificationStrategy`, `ResetIsolationFlag`, `NoErrorFlag`, `UseFlushControl`, and `ReleaseBehaviour` in `OpenGLGraphicsApiHints`. (@NogginBops)

macOS:

* macOS: Implemented `WindowMode.WindowedFullscreen`. (@NogginBops)
* macOS: Implemented `MacOSDialogComponent.OpenFileDialog/SaveFileDialog`. (@NogginBops)
* macOS: Implemented `MacOSClipboardComponent` except `MacOSClipboardComponent.GetClipboardAudio`. (@NogginBops)
* macOS: Implemented `ClipboardUpdate` event. (@NogginBops)
* macOS: Implemented `ContextValuesSelector` with default `OpenGLGraphicsApiHints.UseSelectorOnMacOS = false` due to large overhead enumerating context values on macOS. (@NogginBops)
* macOS: Implemented `MacOSWindowComponent.GetFullscreenDisplay/SetFullscreenDisplay`. (@NogginBops)
* macOS: Add `MacOSWindowComponent.SetFullscreenNoSpace` to set an window as fullscreen without opening a new space for the window. (@NogginBops)
* macOS: Implemented `MacOSWindowComponent.SetCursorCaptureMode/GetCursorCaptureMode`. (@NogginBops)
* macOS: Implemented `MacOSClipboardComponent.SetClipboardBitmap`. (@NogginBops)
* macOS: Implemented `FileDrop` event. (@NogginBops)
* macOS: Implemented `WindowScaleChange` event. (@NogginBops)
* macOS: Implemented `MacOSWindowComponent.SetClientPosition`. (@NogginBops)
* macOS: Implemented `MacOSWindowComponent.SetClientBounds`. (@NogginBops)
* macOS: Implemented `MacOSWindowComponent.ScreenToClient/ClientToScreen`. (@NogginBops)
* macOS: Implemented `MacOSWindowComponent.GetScaleFactor`. (@NogginBops)
* macOS: Fixed Y flipping issue in `MacOSMouseComponent`. (@NogginBops)
* macOS: Fixed invisible cursor. (@NogginBops)
* macOS: Fix bug where `MacOSWindowComponent.SetMaxClientSize` would set the minimum client size. (@NogginBops)

x11:

* x11: Implemented `X11DialogComponent` using Zenity when available. (@NogginBops)
* x11: Set `WM_CLASS` to get proper window name in app switcher. (@NogginBops)
* x11: Implemented `ThemeChange` event. (@NogginBops)
* x11: Detect high contrast mode through `org.gnome.desktop.a11y.interface` when available. (@NogginBops)
* x11: Detect power saver mode. (@NogginBops)
* x11: Added `X11WindowComponent.GetIconifiedTitle/SetIconifiedTitle`. (@NogginBops)
* x11: Fixed XRandR loading the correct .so file. (@NogginBops)
* x11: Fixed color byte order for `X11CursorComponent.Create()`. (@NogginBops)
* x11: Fixed issue where `ContextStencilBits.None` and `ContextDepthBits.None` would throw an exception. (@NogginBops)
* x11: Implemented `FramebufferResize` event. (@NogginBops)
* x11: Implemented `ContextValuesSelector`. (@NogginBops)
* x11: Implemented `PixelFormat`, `SwapMethod`, `RobustnessFlag`, `ResetNotificationStrategy`, `ResetIsolationFlag`, `NoErrorFlag`, `UseFlushControl`, and `ReleaseBehaviour` in `OpenGLGraphicsApiHints`. (@NogginBops)

ANGLE:

* ANGLE: Implemented `ContextValuesSelector`. (@NogginBops)
* ANGLE: Known issue on x11 is that `ANGLEOpenGLComponent` will throw an exception.

## 5.0-pre.10

* Merged OpenTK 4.8.2 onto 5.0-pre.9. (@NogginBops)
  This means that all changes from 4.8.2 are also in this release.

* Moved `OpenTK.Color3` to `OpenTK.Mathematics.Color3`. (@NogginBops)

* Fix `NativeWindow` so it properly loads OpenGL bindings without crashing. (@NogginBops)

* Fix bindings generator locale issue that caused wrong results on certain locales. (@utkumaden)

* Changed the name of some enum group to be more like OpenTK 4 groups.
  Notable examples are `BufferTargetARB` -> `BufferTarget` and `BlendEquationModeEXT` -> `BlendEquationMode`. (@NogginBops)

* Fix WGL and GLX bindings and loading. (@NogginBops)

* Change EGL bindings to `DllImport` for `libEGL` instead of `libEGL.dll`. (@NogginBops)

* Made bindings generator correctly bind function taking GLX opaque struct pointers like `Display*`. (@NogginBops)

* Fixed WGL `GetProcAddress` bindings to correctly marshal strings. (@NogginBops)

Platform Abstraction Layer 2.0 (PAL2):

* Removed internal locks from `EventQueue`. (@utkumaden)

* Add `IWindowComponent.GetBounds/SetBounds` + client bounds versions. (@NogginBops)

* Add functions for getting native handles from PAL2 handles. (@NogginBops)

* Added functions and event data for keyboard modifiers. (@NogginBops)

* Win32: Fix sticky RightControl, LeftAlt, and RightAlt keys. (@NogginBops)

* Win32: Fix duplicate `TextInput` events when using IME. (@NogginBops)

* Win32: Fix `CanIncludeInClipboardHistory` and `CanUploadToCloudClipboard`. (@NogginBops)

* X11: Implemented `X11KeyboardComponent.GetKeyboardModifiers()`. (@NogginBops)

* X11: Implemented `X11MouseComponent.GetMouseState()`. (@NogginBops)

* X11: Implemented `X11ShellComponent.GetPreferredTheme()`. (@NogginBops)

* X11: Implemented `ClipboardUpdate`, `DisplayConnectionChanged`, `FileDrop`, `KeyDown`, and `KeyUp` events. (@NogginBops)

* macOS: Implemented `MacOSWindowComponent.GetIcon/SetIcon`. (@NogginBops)

* macOS: Implemented `MacOSWindowComponent.SetSize/SetClientSize`. (@NogginBops)

* macOS: Implemented `MacOSWindowComponent.[Set/Get][Max/Min]ClientSize`. (@NogginBops)

* macOS: Implemented `MacOSWindowComponent.GetDisplay`. (@NogginBops)

* macOS: Implemented window hit test callback for `HitType.Draggable`. (@NogginBops)

* macOS: Implemented `MacOSWindowComponent.SetCursor`. (@NogginBops)

* macOS: Implemented `MacOSMouseComponent.SetPosition`. (@NogginBops)

* macOS: Implemented `MacOSDisplayComponent` fully. (@NogginBops)

* macOS: Implemented `MacOSCursorComponent` fully. (@NogginBops)

* macOS: Implemented basic `KeyDown`/`KeyUp`. (@NogginBops)

* macOS: Implemented `MacOSKeyboardComponent.GetKeyboardState/GetKeyboardModifiers`. (@NogginBops)

* macOS: Implemented `MacOSIconComponent` fully. (@NogginBops)

* macOS: Implemented `MacOSShellComponent` fully. (@NogginBops)

* macOS: Implemented `Focus`, `WindowMove`/`WindowResize`, `WindowModeChange`, `MouseEnter`, `KeyDown`/`KeyUp`, `TextInput`, `ThemeChange`, and `DisplayConnectionChanged` events. (@NogginBops)

* ANGLE: Made `ANGLEOpenGLComponent` work with the X11 backend. (@NogginBops)

## 5.0-pre.9

* Merged PAL2 into OpenTK 5.0. Platform Abstraction Layer 2.0 is an experimental api that represents the future of windowing in OpenTK. (@NogginBops, @utkumaden)
  To learn more visit: https://nogginbops.github.io/opentk.net/learn/pal2/Introduction.html (will be https://opentk.net/learn/pal2/Introduction.html in the future).

* Merged OpenTK  4.8.1 onto 5.0-pre.9. (@NogginBops)
  This means that all changes make between 4.7.6 to 4.8.1 are also in this release.

* BREAKING: Disabled generation of typesafe handles by default. (@NogginBops)
  They are still available optionally when running the generator, but will not be part of the nuget package.

* API: Lots of GL functions are now properly overloaded with math types. (@NogginBops)

* API: Where applicable `System.Numerics` overloads have been added to GL functions. (@NogginBops)

* FIX: `LinearMipmapLinear` is no longer a member in `TextureWrapMode`. (@NogginBops)

* FIX: `GL.CreateShaderProgram` now properly returns an `int`. (@NogginBops)

* API: Added `GL.TransformFeedbackVaryings(int, int, string[], TransformFeedbackBufferMode)` manual overload. (@NogginBops)

* API: Implemented `IEquatable<>` on all typesafe handle types. (@NogginBops)

* FIX: Started using `OperatingSystem.Is*` internally instead of `RuntimeInformation.IsOSPlatform`. (@O1L)

* API: Added `Wgl` and `Glx` bindings (automatic loading the symbols for these APIs is broken, but will be fixed in the next preview). (@NogginBops)

* API: Made all function pointers directly accessibly in `GLPointers`, `GLXPointers`, and `WGLPointers` classes. (@NogginBops)

## 5.0-pre.8

* Merged 5.0 with 4.7.5, this means that all changes made between 4.6.5 to 4.7.5 are also in this release.
* Functions with `bool` parameters and return values are now correctly bound.
* Enum groups now document a few functions where they are used.
* The singular overload of `GenQuries` is now correctly named `GenQuery`.
* Deduplicated internal function pointers to reduce the final binary size.
* Fixes a few functions like `glTexImage3D` that took an `int` parameter when it should have taken an enum instead.

## 5.0-pre.7

* Add documentation to all native and overloaded functions (and links to their refpage) (@frederikja163, @NogginBops)
* Fixed math overloads for float functions (e.g. `GL.UniformMatrix4f`) (@NogginBops)
* Make all vector constructors follow a similar pattern (@Cyphall)

## 5.0-pre.6
* New manual overload for ClearColor
* New manual overload for GetProgramInfoLog
* Move to System.Half from OpenTK.Mathemathics.Half (@friendlychicken)
* Fix native call '_' postfix
* *Added typesafe opengl handles!*

## 5.0-pre.5
* Math type overloads (includes Vector overloads and matrix overloads).

## 5.0-pre.4
* Fixed debug callbacks (GL.DebugMessageCallback)
* Created an offset overloader to deal with glDrawElements* and glVertexAttribXPointer
* Created a bool overloader to properly manage 8 bit booleans in the spec
* Manual overload for GL.CreateShaderProgramv (@deccer)
* Added the old 4.0 name trimmer
* Opentk.compute changed UIntPtr to nuint
* OpenCL OpenGL interop added
* Fixed singular delete overloads
* General overloader code cleanup

## 5.0-pre.3
* Fix an issue when overloading a void* to an IntPtr.

## 5.0-pre.2
* bools will now be booleans instead of bytes
* ref parameters can now be generic
* Delete* will now recieve similar overloads as Gen* and Create*
* Delete, Gen and Create* will have names with removed s for the singular versions
* Overloads now use nint for arguments of type GLsizeiptr and GLsizeiptrARB in c
* Proper parameter naming
* Created new overload for void* parameters making them IntPtr

## 5.0-pre.1
* Rewritten generator for OpenGL bindings, this will enable some nice features that are in the works.
* Updated projects to .net 5
* New colors using phantom types for color spaces.

**Note**: The new OpenGL bindings will receive updates and breaking changes in the coming previews.

**Note**: The generated functions currently do not have xml documentation attached to them, this will be available in the final release.

## 4.9.4

* BREAKING: Made `Matrix3/4.CreateFromQuaternion` and `Matrix3x4/4x3.CreateFromQuaternion` produce idential results for non-normalized quaternions. (@NogginBops)

* API: Add explicit casts to and from `System.Numerics` types. (@DamienIsPoggers, @NogginBops)

* API: Added `VectorN.Round/Ceiling/Floor/Truncate` element-wise functions. (@NogginBops)

* API: Add `ShaderStorageBufferBinding`, `ShaderStorageBufferStart`, and `ShaderStorageBufferSize` to `GetIndexedPName`. (@NogginBops)

* API: Add `MathHelper.RadToDeg(d)` and `MathHelper.DegToRad(d)` constants for conversion between radians and degrees. (@DamienIsPoggers)

* API: Add support for the `ALC_SOFT_loopback` OpenAL extension through `OpenTK.Audio.OpenAL.ALC.Loopback`. (@NogginBops)

* FIX: Update `OpenTK.redist.glfw` to GLFW 3.4 so that the GLFW 3.4 apis work properly. (@NogginBops)

* FIX: Optimized `VectorN.this[int i]` and `MatrixN.this[int row, int col]` indexers. (@NogginBops)

* FIX: Made `Color4.FromHsv` and `Color4.FromHsl` work correctly when hue is `1`. (@NogginBops)

* FIX: Updated OpenAL `DllNotFoundException` exception message to mention having to install OpenAL. (@NogginBops)

* FIX: The documentation for `NativeWindowSettings.RenderFrequency` now correctly refers to `UpdateFrequency` instead of `UpdateFrame`. (@NogginBops)

## 4.9.3

* Fix issue where the `OpenTK.Mathematics` nuget package referenced `System.Runtime.CompilerServices.Unsafe` version `5.0.0` but the compiled `OpenTK.Mathematics.dll` assembly referenced version `6.0.0`. Causing runtime crashes in some circumstances. The `OpenTK.Mathematics` nuget package now correctly requires version `6.0.0`. (@NogginBops)

## 4.9.2

* Made nuget package builds "deterministic". (@NogginBops)

* Fix assembly versions to match OpenTK release version. (@NogginBops)

## 4.9.1

* BREAKING: Made `NativeWindow` able to run on Wayland (when running on Wayland `NativeWindow` will default to Wayland, use `OPENTK_4_USE_WAYLAND=0` or set the X11 glfw hint to use X11/Xwayland). (@NogginBops)

* BREAKING: Change type of `NativeWindow.CurrentMonitor` property from `MonitorHandle` to `MonitorInfo`. (@NogginBops)

* BREAKING: Changed EGL bindings to `DllImport` `libEGL` instead of `libEGL.dll` (shouldn't be breaking in most cases). (@NogginBops)

* BREAKING: Removed leftover module references to `libGLESv2.dll` (and `opengl32.dll` and `GLESv1_CM`) in `OpenTK.Graphics.dll` which was causing build errors in `net8.0-macos` projects. (these references are never used by OpenTK so they shoudn't be there, this might break something in very specific circumstances)(@NogginBops)

* BREAKING: `MathHelper.Lerp` no longer clamps `t` to `[0, 1]` range. (@NogginBops)

* API: Upgrade to GLFW 3.4. (@NogginBops)

* API: Updated OpenGL bindings to contain the latest definitions without breaking `4.8.2` compatibility (this includes OpenGLES 3.1 and 3.2). (@NogginBops)

* API: Add `NativeWindow.MakeFullscreen` method to more seamlessly transition a window to fullscreen. (@NogginBops)

* API: Deprecate `Matrix4(d).ExtractProjection`. (@NogginBops)

* API: Added `Matrix4(d).ExtractPerspectiveOffCenter/ExtractPerspectiveFieldOfView` to extract projection matrix parameters from perspective projections. (@NogginBops)

* API: Added `Matrix4(d).ExtractOrthographicOffCenter/ExtractOrthographic` to extract projection matrix parameters from orthographic projections. (@NogginBops)

* API: Add matrix swizzle functions `Matrix2/3/4(d).Swizzle/Swizzled/CreateSwizzle`. (@NogginBops)

* API: Added `MouseCursor.PointingHand/ResizeEW/ResizeNS/ResizeNWSE/ResizeNESW/ResizeAll/NotAllowed` standard mouse cursors. (@NogginBops)

* API: Added `VectorN.Slerp` (spherical interpolation) and `VectorN.Elerp` (exponential interpolation) functions. (@NogginBops)

* API: Added `NativeWindow.AlwaysOnTop` property to set if a window should always be visible. (@NogginBops)

* API: Added `NativeWindow.MousePassthrough` property to set if the window should be transparent to mouse interactions. (@NogginBops)

* API: Added `CusorState.Confined` to be able to confine the mouse cursor to the window content area. (@NogginBops)

* API: Implemented `Matrix3(d).Column1/2/3`, `Matrix4x3(d).Column1/2/3` and ``Matrix3x4(d).Column1/2/3/4` property setters. (@NogginBops)

* API: Make `NativeWindow` throw explicit `InvalidOperationException` or `OutOfMemoryException` if `glfwCreateWindow` fails. (@NogginBops)

* API: Added a few missing constants to the EGL bindings. (@NogginBops)

* API: Deprecate `NativeWindow.CurrentMonitor` property setter. (@NogginBops)

* API: Implemented `Matrix2/3/4(d).Transposed/Inverted` for matrix types that where missing them. (@NogginBops)

* API: Deprecate `Matrix4d.Scale/RotateX/RotateY/RotateZ/Rotate/Frustum/Perspective`use the `Create*` functions instead. (@NogginBops)

* API: Deprecate `EffectSlotInteger.AuxiliarySendAuto` in favor of `EffectSlotBoolean.AuxiliarySendAuto`. (@NogginBops)

* FIX: Fix wglDXCloseDeviceNV argument name, from `dxDevice` to `hDecvice`. (@NogginBops)

* FIX: All assemblies are now signed. (@RFBomb, @NogginBops)

* FIX: Fixed nuget package metadata. (@NogginBops)

* FIX: `OpenTK.Graphics` now contains proper debug info, the code is still generated but might improve debug experience. (@NogginBops)

* FIX: Fix issue where `NativeWindowSettings.StartVisible=false` with `NativeWindowSettings.StartFocused=true` would create a visible window. (@NogginBops)

* FIX: Updated links in README to link to the website tutorial. (@NogginBops)

* FIX: Added basic README to nuget packages. (@NogginBops)

* FIX: Fix GLFW calling convention when on 32-bit windows, this was causing a StackOverflowException. (@NogginBops)

* FIX: Improved a bunch of OpenAL documentation. (@NogginBops)

## 4.9.0

* This version had broken nuget packages, see `4.9.1` instead.

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

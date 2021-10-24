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

## 4.5.0
API: Introduced `GameWindow.UpdateTime` to match `GameWindow.RenderTime`. (@NogginBops)
API: Added GLFW functions for getting platform dependent opengl context pointers. (@NogginBops)

FIX: `GameWindow.RenderTime` now gets updated correctly. (@NogginBops)
FIX: Actually assign `APIVersion` property in `NativeWindow`. (@BroMandarin)
FIX: The `MouseWheelEventArgs` in `OnMouseWheel` now correctly returns a delta instead of an accumulated offset. (@GeorchW)
FIX: Some overloads for `AL.DeleteSources` where calling `alDeleteBuffers` instead of `alDeleteSources`. (@NogginBops)

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
	
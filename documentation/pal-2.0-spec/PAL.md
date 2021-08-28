# OpenTK Platform Abstraction Layer 2.0 Specification Draft

## Abstract
Over the years the OpenTK project has use several different methods for
abstracting platform APIs (such as but not limited to Win32 and X11). The latest
method, the GLFW library has proven to be troublesome and lack the cohesion of
previous Platform Abstraction Layer (PAL) of the OpenTK 3.0 Version. This
document aims to redesign the original PAL into C-like interface from which
object oriented types may be derived for all platforms which may be partially
implemented depending on the executing system.

## Introduction
With the somewhat recent changes made in OpenTK 4.0 and later, the public API
has been found to be lacking the features the legacy OpenTK had. Many users have
been forced to call GLFW directly, defeating the purpose of OpenTK for providing
a type safe, object oriented platform abraction layer. An ongoing example of
this is the inability to enumerate the video mode capability of connected
displays. (#1221) 

Another problem with GLFW is that it is incapable of creating OpenGL contexts
with a version less than or equal to version 3.2. There is enough demand that
an outstanding issue exists, #1040. This is unacceptable, however, this may only
be fixed by updating GLFW with this capability, which brings me to the final
point.

GLFW is a needless dependency. Even though the project is open source, if a bug
or issue surfaces which may only be fixed in GLFW, a fix may take a long time to
be approved or never be approved even if implemented by OpenTK. This would
require distributing our own fork of GLFW which is more trouble for maintaining
the project. Since it is a 3rd party dependency, sometimes issues rise up with
GLFW not being present at the binary directory, even if it is explicitly
provided by the nuget package. (see #1228)

It is in our best interest to keep OpenTK freestanding from 3rd party
abstraction layers. However, this isn't mutually exclusive to the idea of
supporting dependents from implementing such abstraction layers into OpenTK.

### Previous Abstraction Layers
It is impossible to design something better without having a reference to
compare against. OpenTK has had two major revisions of its platform abstraction
layer, the legacy PAL and GLFW. This section aims to define a reference point
for the new abstraction layer design.

#### Legacy OpenTK: PAL 1.0 (3.x and earlier)
This is the initial implementation of the platform abstraction layer which has
existed since OpenTK version 1.0. At the time of it's implementation, only 
.Net Framework (netfx) and Mono existed. Let us summarize the abstraction layer
in the following figure.

![OpenTK PAL 1.0, Visualized](pal-1.0%20visualized.svg)

__Pros__
* Does not depend on 3rd party libraries (unless using the SDL backend)
* If an issue is found with the abstracation layer, it can be fixed locally
  without having to contribute to depended library.
* Dependents can implement a new native backend if they have different 
  requirements.
* Feature rich, mostly completed.

__Cons__
* Object oriented approach to the abstraction. Since the platform APIs are
  defined in C, it becomes a hassle to defined each platform in an object
  oriented manner.

#### Modern OpenTK: GLFW (4.x and later)
This is the newer reimplemantation of the OpenTK PAL, which depends on the C
library GLFW. This new abstraction layer has not only been poorly implemented,
and has proven to be troublesome in the 4.x release cycle, as a significant
number of changes in the major version 4 were related to GLFW and the platform
layer.

![OpenTK GLFW PAL Visualized](glfw-pal%20visualized.svg)

__Pros__
* GLFW abstracts away the platform for us, which me the OpenTK library only has
  to wrap the C API in an object oriented manner.
* Some people are familiar with this library since they have used it in C or
  C++.

__Cons__
* Another 3rd dependency end users need to be supplied with, can lead to
  problems where the user cannot run the program without troubleshooting, as the
  programmer responsible misdelivered.
* Cannot create OpenGL contexts less than or equal to version 3.2.
* Windowing fixes have to be implemented in GLFW itself, affecting our users as
  fixes may take a long time to arrive or outright be marked as "won't fix".

## Design Goals
* Provide access to platform APIs without being coupled to any specific platform
  or library.
* Provide easy to implement interface with which OpenTK could access unsupported
  platforms; officially, by third parties or dependents.
* Give dependents the choice over native, or third party second order
  dependencies such as GLFW or SDL2.
* Create a well defined contract for the abstraction layer in order to decrease
  the amount of potential platform dependent bugs.
* Given the instanceless nature of platform APIs, keep the PAL as instanceless
  as possible.

## Platform Components
The OpenTK platform abstraction layer should abstract away platform components.
A platform component is any API or system peripheral which the end user may be 
interested in.

### OpenGL Component
The OpenGL component *MUST* provide the following capabilites:
* Creating OpenGL contexts,
* Destroying OpenGL Contexts,
* Getting and setting the active OpenGL context,
* Querying avaliable OpenGL extensions,
* Loading OpenGL procedure addresses (___GetProcAddress).
* Creating shared OpenGL contexts.

### (Future) Vulkan Component
This component *MUST* provide a way to load Vulkan procedure addresses.

### Icon Component
In some operating systems like Windows, an icon object (similar to a window
object) must be created in order to change the icon of a window.

The Icon Component *MUST* provide the following capabilities:
* Creating an icon object,
* Create an icon object containing to common system icons,
* Deleting an icon object,
* Copying bitmap information from buffers (such as arrays, `Spans<T>`s) into any
  mipmap level of the icon,
* Loading an icon from a stream or file if the operating system supports this
  action.

### Mouse Cursor Component
When a desktop operating system is used, the user may want to create a custom
mouse cursor for their application.

The Mouse Cursor Component *MUST* provide the following capabilities:
* Creating a mouse cursor object,
* Creating a mouse cursor object from common system cursors,
* Deleting a mouse cursor object,
* Copying bitmap information from buffers into the mouse cursor object,
* Setting the mouse cursor origin within the image for the mouse cursor object,
* Loading the mouse cursor object from a stream or file if the operating system
  supports this action.
 
### Windowing Component
The windowing component *MUST* provide the following capabilities:
* Creating windows,
* Destroying windows,
* Getting and setting the window title,
* Getting and setting the window icon using an icon object,
* Getting and setting the window size and location,
* Getting and setting the window client area size and location,
* Getting and setting the mouse cursor for the window with a cursor object,
* Changing mouse cursor visibility,
* Getting and setting the display the window is in,
* Getting and setting the window visibility,
* Getting and setting the window border type,
* Changing the window visibility in the task switcher,
* Changining window modes: normal, minimized, maximized, borderless fullscreen,
  exclusive fullscreen (if supported),
* Setting a callback to the window event handler,
* Pumping window events to the callback.

### Surface Component
Some operating systems don't have support for windows, for example game
consoles, mobile devices and framebuffer rendering on Linux. Therefore a OpenGL
surface must be created before rendering commands can be issued.

The Surface Component *MUST* provide the following capabilities:
* Creating a drawing surface,
* Destroying a drawing surface,
* Getting or setting the framebuffer client area,
* Getting or setting the display the surface is in.

### Display Component
Many desktop users and even some laptop users often utilize multiple displays.
This component should provide information on display devices.

The Display Component *MUST* provide the following capabilities:
* Enumerating all available display devices,
* Enumerating all the available display modes for each given device,
* Changing the display mode of each display device,
* Getting the pixel density of each display, for each video mode,
* Getting an identifier object for the default display device.

### Mice Input Component
The Mice Input Component *MUST* provide the following capabilities:
* Enumerating all available mice installed in the system. (if operating system
  supports multiple mice.)
* Getting the state of buttons on the mice.
* Getting or setting the mice position on the screen.
* Getting vertical and horizontal wheel information of the device.

### Keyboard Input Component
The keyboard input component *MUST* provide the following capabilities.
* Enumerating all available keyboards installed in the system (if the operating
  system supports such capability.)
* Getting the state of each button on the a keyboard.
* Querying the global keyboard layout.
* Querying the the keyboard layout for a window given its handle. (if supported)

### IME component.
The IME component *MUST* provide the following capabilities:
* Invoking the input method editor.
* Specifying the input method editor area.

### Controller Input Component
The controller input component *MUST* provide the follwoing capabilities:
* Enumerate all available controller devices in the system.
* Get the number of buttons on each controller device.
* Get the number of all analog channels on each controller device.
* Get the button state for each button on each controller device.
* Get the position value of each analog channel on each controller device.
* Query the name and type of each controller device. (if available.)

## Glossary
<!--
I really hate it when my text documents aren't 80 columns, sorry for not using
markdown syntax here.
-->
<table>
  <tr>
    <th>Term</th> <th>Description</th>
  </tr>
  <tr>
    <td>Dependency</td>
    <td>
      Any program or library which another program or library requires to
      operate.
    </td>
  </tr>
  <tr>
    <td>Dependent</td>
    <td>
      Any program or library which is a dependency of the program or library in
      question.
    </td>
  </tr>
  <tr>
    <td>GLFW</td>
    <td>
      A C library for abstracting away windowing and input for use in games.
    </td>
  </tr>
  <tr>
    <td>nth Order Dependency</td>
    <td>
      An nth order dependency is the dependency of an n-1st dependency. For
      example, for the dependent of OpenTK 4.0, GLFW is a second order
      dependency.
    </td>
  </tr>
  <tr>
    <td>PAL</td>
    <td>Platform Abstraction Layer</td>
  </tr>
</table>
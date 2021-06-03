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

## Glossary
|  Acronym       | Description                                                 |
|----------------|-------------------------------------------------------------|
| GLFW           | A C library for abstracting away windowing and input for use in games. |
| PAL            | Platform Abstraction Layer                                  |
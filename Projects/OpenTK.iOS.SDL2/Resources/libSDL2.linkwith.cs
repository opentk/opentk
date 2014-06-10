using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libSDL2.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator, ForceLoad = true)]

﻿using ImGuiNET;
using OpenTK.Core.Platform;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using OpenTK.Platform.Native.macOS;
using OpenTK.Platform.Native.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Backends.Tests
{
    internal class WindowComponentView : View
    {
        public override string Title => "Window";

        const float IntDragSpeed = 0.2f;

        bool canSetCursor;
        bool canGetDisplay;
        bool canCaptureCursor;
        bool canSetIcon;

        public override void Initialize()
        {
            // FIXME: Catch any exceptions...
            try { canSetCursor = Toolkit.Window.CanSetCursor; } catch { canSetCursor = false; }
            try { canGetDisplay = Toolkit.Window.CanGetDisplay; } catch { canGetDisplay = false; }
            try { canCaptureCursor = Toolkit.Window.CanCaptureCursor; } catch { canCaptureCursor = false; }
            try { canSetIcon = Toolkit.Window.CanSetIcon; } catch { canSetIcon = false; }

            if (Program.UsingGLES)
            {
                openglSettings.Version = new Version(3, 1);
            }

            // FIXME: Make a useful hit test callback as part of this view.
            //WindowComponent.SetHitTestCallback(Program.Window, HitTest);
        }

        // FIXME: Actually make this usable.
        private HitType HitTest(WindowHandle window, Vector2 point)
        {
            if (point.X < 300 && point.Y < 300)
            {
                return HitType.Draggable;
            }

            return HitType.Default;
        }

        int selectedWindow = -1;

        OpenGLGraphicsApiHints openglSettings = new OpenGLGraphicsApiHints()
        {
            Profile = OpenGLProfile.Core,
            DebugFlag = true,
        };
        Vector2i WindowSize = (800, 600);
        WindowMode WindowMode = WindowMode.Normal;

        string titleString = "";
        int modeIndex = 0;
        int borderStyleIndex = 0;
        int captureModeIndex = 0;
        Vector2i windowPosition;
        Vector2i clientPosition;

        readonly static WindowMode[] WindowModes = Enum.GetValues<WindowMode>();
        readonly static string[] WindowModeNames = Enum.GetNames<WindowMode>();

        readonly static WindowBorderStyle[] WindowBorderStyles = Enum.GetValues<WindowBorderStyle>();
        readonly static string[] WindowBorderStyleNames = Enum.GetNames<WindowBorderStyle>();

        readonly static CursorCaptureMode[] CaptureModes = Enum.GetValues<CursorCaptureMode>();
        readonly static string[] CaptureModeNames = Enum.GetNames<CursorCaptureMode>();

        public override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

            if (selectedWindow > Program.ApplicationWindows.Count)
            {
                selectedWindow = -1;
            }

            ImGui.SeparatorText("Component Properties");
            {
                ImGuiUtils.ReadonlyCheckbox("Can set cursor", canSetCursor);
                ImGuiUtils.ReadonlyCheckbox("Can get display ", canGetDisplay);
                ImGuiUtils.ReadonlyCheckbox("Can capture cursor", canCaptureCursor);
                ImGuiUtils.ReadonlyCheckbox("Can set icon", canSetIcon);
            }

            ImGui.SeparatorText("Windows");

            if (ImGui.BeginListBox("Windows"))
            {
                PaintWindow(Program.Window, 0);
                for (int i = 0; i < Program.ApplicationWindows.Count; i++)
                {
                    PaintWindow(Program.ApplicationWindows[i].Window, i + 1);
                }
                ImGui.EndListBox();

                void PaintWindow(WindowHandle window, int i)
                {
                    string name;
                    string displayName;
                    try
                    {
                        name = Toolkit.Window.GetTitle(window);
                        displayName = name;
                    }
                    catch (Exception e)
                    {
                        Program.Logger.LogError($"Unable to get window title of window: {e}");
                        name = $"Window #{i}";
                        displayName = $"{name} (unable to get name)";
                    }

                    if (window == Program.Window)
                    {
                        displayName += " (this window)";
                    }

                    bool isSelected = i == selectedWindow;

                    if (ImGui.Selectable(displayName, isSelected, ImGuiSelectableFlags.AllowOverlap))
                    {
                        selectedWindow = i;
                        titleString = name;
                    }

                    if (isSelected) ImGui.SetItemDefaultFocus();

                    if (window != Program.Window)
                    {
                        ImGui.SameLine();
                        ImGui.PushID(i);
                        if (ImGui.SmallButton($"x"))
                        {
                            try
                            {
                                // Send the close event, this will close the window.
                                WindowHandle handle = Program.ApplicationWindows[i - 1].Window;
                                EventQueue.Raise(handle, PlatformEventType.Close, new CloseEventArgs(handle));

                                if (selectedWindow == i)
                                {
                                    selectedWindow = -1;
                                }
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                        }
                        ImGui.PopID();
                    }
                }
            }
            
            if (selectedWindow != -1)
            {
                WindowHandle window = (selectedWindow == 0)
                        ? Program.Window
                        : Program.ApplicationWindows[selectedWindow - 1].Window;

                if (ImGui.CollapsingHeader("Info"))
                {
                    Toolkit.Window.GetClientSize(window, out int cWidth, out int cHeight);
                    Toolkit.Window.GetSize(window, out int wWidth, out int wHeight);
                    Toolkit.Window.GetClientPosition(window, out int cx, out int cy);
                    Toolkit.Window.GetPosition(window, out int wx, out int wy);
                    ImGui.Text($"Client Position: ({cx}, {cy})");
                    ImGui.Text($"Position: ({wx}, {wy})");
                    ImGui.Text($"Client Size: ({cWidth}, {cHeight})");
                    ImGui.Text($"Size: ({wWidth}, {wHeight})");
                }

                ImGui.AlignTextToFramePadding();
                ImGui.TextUnformatted("Title"); ImGui.SameLine();
                ImGui.InputText("##title", ref titleString, 1024); ImGui.SameLine();
                if (ImGui.Button("Apply##tile"))
                {
                    Toolkit.Window.SetTitle(window, titleString);
                    Program.Logger.LogInfo($"WindowComponent.SetTitle(\"{titleString}\")");
                }

                ImGui.AlignTextToFramePadding();
                ImGui.TextUnformatted("Mode"); ImGui.SameLine();
                ImGui.Combo("##mode", ref modeIndex, WindowModeNames, WindowModeNames.Length); ImGui.SameLine();
                if (ImGui.Button("Apply##mode"))
                {
                    Toolkit.Window.SetMode(window, WindowModes[modeIndex]);
                    Program.Logger.LogInfo($"WindowComponent.SetMode({WindowModeNames[modeIndex]})");
                }

                // FIXME: change to toggle!
                if (ImGui.Button("Set windowed fullscreen"))
                {
                    DisplayHandle display = Toolkit.Window.GetDisplay(window);
                    Toolkit.Window.SetFullscreenDisplay(window, display);
                }

                if (Toolkit.Window is MacOSWindowComponent macosWindowComponent)
                {
                    if (ImGui.Button("Set windowed fullscreen without opening its own space"))
                    {
                        DisplayHandle display = macosWindowComponent.GetDisplay(window);
                        macosWindowComponent.SetFullscreenDisplayNoSpace(window, display);
                    }
                }

                ImGui.AlignTextToFramePadding();
                ImGui.TextUnformatted("Cursor capture mode"); ImGui.SameLine();
                ImGui.Combo("##captureMode", ref captureModeIndex, CaptureModeNames, CaptureModeNames.Length); ImGui.SameLine();
                if (ImGui.Button("Apply##captureMode"))
                {
                    Toolkit.Window.SetCursorCaptureMode(window, CaptureModes[captureModeIndex]);
                }

                ImGui.AlignTextToFramePadding();
                ImGui.TextUnformatted("Border style"); ImGui.SameLine();
                ImGui.Combo("##border_style", ref borderStyleIndex, WindowBorderStyleNames, WindowBorderStyleNames.Length); ImGui.SameLine();
                if (ImGui.Button("Apply##border_style"))
                {
                    Toolkit.Window.SetBorderStyle(window, WindowBorderStyles[borderStyleIndex]);
                    Program.Logger.LogInfo($"WindowComponent.SetBorderStyle({WindowBorderStyleNames[borderStyleIndex]})");

                    var style = Toolkit.Window.GetBorderStyle(window);
                    Program.Logger.LogInfo($"Border style: {style}");
                }

                ImGui.AlignTextToFramePadding();
                ImGui.TextUnformatted("Always on top:"); ImGui.SameLine();
                if (ImGui.Button("Yes"))
                {
                    Toolkit.Window.SetAlwaysOnTop(window, true);

                    bool value = Toolkit.Window.IsAlwaysOnTop(window);
                    Program.Logger.LogInfo($"Always on top: {value}");
                }
                ImGui.SameLine();
                if (ImGui.Button("No"))
                {
                    Toolkit.Window.SetAlwaysOnTop(window, false);

                    bool value = Toolkit.Window.IsAlwaysOnTop(window);
                    Program.Logger.LogInfo($"Always on top: {value}");
                }

                ImGui.DragInt2("Position", ref windowPosition.X); ImGui.SameLine();
                if (ImGui.Button("Set##Position"))
                {
                    Toolkit.Window.SetPosition(Program.Window, windowPosition.X, windowPosition.Y);
                    Program.Logger.LogInfo($"WindowComponent.SetPosition({windowPosition})");

                    Toolkit.Window.GetPosition(Program.Window, out int x, out int y);
                    Program.Logger.LogInfo($"Window position: ({x}, {y})");
                }

                ImGui.DragInt2("Client position", ref clientPosition.X); ImGui.SameLine();
                if (ImGui.Button("Set##ClientPosition"))
                {
                    Toolkit.Window.SetClientPosition(Program.Window, clientPosition.X, clientPosition.Y);
                    Program.Logger.LogInfo($"WindowComponent.SetClientPosition({clientPosition})");

                    Toolkit.Window.GetClientPosition(Program.Window, out int x, out int y);
                    Program.Logger.LogInfo($"Client position: ({x}, {y})");
                }
            }

            if (ImGui.CollapsingHeader("Window Creation"))
            {
                if (ImGui.CollapsingHeader("OpenGL Settings"))
                {
                    ImGui.SeparatorText("Version");
                    int major = openglSettings.Version.Major;
                    bool majorChanged = ImGui.DragInt("Major", ref major, IntDragSpeed, 1, 5);
                    int minor = openglSettings.Version.Minor;
                    bool minorChanged = ImGui.DragInt("Minor", ref minor, IntDragSpeed, 0, 9);
                    if (majorChanged || minorChanged)
                        openglSettings.Version = new Version(major, minor);

                    ImGui.SeparatorText("Color setup");

                    Span<int> bits = stackalloc int[4] {
                        openglSettings.RedColorBits,
                        openglSettings.GreenColorBits,
                        openglSettings.BlueColorBits,
                        openglSettings.AlphaColorBits,
                    };
                    if (ImGui.DragInt4("RGBA color bits", ref bits[0], IntDragSpeed, 0, 128))
                    {
                        openglSettings.RedColorBits = bits[0];
                        openglSettings.GreenColorBits = bits[1];
                        openglSettings.BlueColorBits = bits[2];
                        openglSettings.AlphaColorBits = bits[3];
                    }

                    ContextStencilBits stencilBits = openglSettings.StencilBits;
                    if (ImGuiUtils.EnumCombo("Stencil bits", ref stencilBits))
                        openglSettings.StencilBits = stencilBits;

                    ContextDepthBits depthBits = openglSettings.DepthBits;
                    if (ImGuiUtils.EnumCombo("Depth bits", ref depthBits))
                        openglSettings.DepthBits = depthBits;

                    {
                        // FIXME: Figure out of this mean no msaa
                        bool enableMultisample = openglSettings.Multisamples > 0;
                        if (ImGui.Checkbox("Multisample", ref enableMultisample))
                        {
                            // FIXME: Maybe retain some old value?
                            openglSettings.Multisamples = enableMultisample ? 1 : 0;
                        }

                        ImGui.BeginDisabled(enableMultisample == false);

                        int samples = openglSettings.Multisamples;
                        if (ImGui.DragInt("Samples", ref samples, IntDragSpeed, 1, 128))
                            openglSettings.Multisamples = samples;

                        ImGui.EndDisabled();
                    }

                    bool doubleBuffer = openglSettings.DoubleBuffer;
                    if (ImGui.Checkbox("Double buffer", ref doubleBuffer))
                        openglSettings.DoubleBuffer = doubleBuffer;

                    bool srgb = openglSettings.sRGBFramebuffer;
                    if (ImGui.Checkbox("sRGB Framebuffer", ref srgb))
                        openglSettings.sRGBFramebuffer = srgb;

                    ImGui.SeparatorText("Context settings");

                    OpenGLProfile profile = openglSettings.Profile;
                    if (ImGuiUtils.EnumCombo("Profile", ref profile))
                        openglSettings.Profile = profile;

                    bool forwardCompat = openglSettings.ForwardCompatibleFlag;
                    if (ImGui.Checkbox("Forward compatible flag", ref forwardCompat))
                        openglSettings.ForwardCompatibleFlag = forwardCompat;

                    bool debug = openglSettings.DebugFlag;
                    if (ImGui.Checkbox("Debug flag", ref debug))
                        openglSettings.DebugFlag = debug;
                }

                ImGui.SeparatorText("Window properties");

                ImGui.DragInt2("Size", ref WindowSize.X);

                ImGuiUtils.EnumCombo("Windowe Mode", ref WindowMode);

                if (ImGui.Button("Create Window"))
                {
                    try
                    {
                        WindowHandle handle = Toolkit.Window.Create(openglSettings.Copy());

                        int index = Program.ApplicationWindows.Count + 1;
                        Program.ApplicationWindows.Add(new Program.ApplicationWindow(handle));

                        Toolkit.Window.SetTitle(handle, $"Child Window #{index}");
                        Toolkit.Window.SetSize(handle, WindowSize.X, WindowSize.Y);
                        Toolkit.Window.SetMode(handle, WindowMode);
                    }
                    catch (Exception e)
                    {
                        // FIXME: Show an error message!
                        Program.Logger.LogError($"Unable to create window: {e}");
                    }
                }
            }
        }
    }
}
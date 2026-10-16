using ImGuiNET;
using OpenTK.Mathematics;
using OpenTK.Platform;
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
        }

        int selectedWindow = -1;

        OpenGLGraphicsApiHints openglSettings = new OpenGLGraphicsApiHints()
        {
            Profile = OpenGLProfile.Core,
            DebugFlag = true,
            Selector = static (options, requested, logger) => {
                for (int i = 0; i < options.Count; i++)
                {
                    logger?.LogInfo(options[i].ToString());
                }

                return ContextValues.DefaultValuesSelector(options, requested, logger);
            },
        };
        Vector2i WindowSize = (800, 600);
        WindowMode WindowMode = WindowMode.Normal;

        string titleString = "";
        string iconTitleString = "";
        int windowTypeIndex = 0;
        int modeIndex = 0;
        int borderStyleIndex = 0;
        int transparencyModeIndex = 0;
        float windowOpacity = 1.0f;
        Vector2i windowPosition;
        Vector2i clientPosition;

        readonly static WindowType[] WindowTypes = Enum.GetValues<WindowType>();
        readonly static string[] WindowTypeNames = Enum.GetNames<WindowType>();
        readonly static WindowMode[] WindowModes = Enum.GetValues<WindowMode>();
        
        readonly static string[] WindowModeNames = Enum.GetNames<WindowMode>();

        readonly static WindowBorderStyle[] WindowBorderStyles = Enum.GetValues<WindowBorderStyle>();
        readonly static string[] WindowBorderStyleNames = Enum.GetNames<WindowBorderStyle>();

        readonly static WindowTransparencyMode[] TransparencyModes = Enum.GetValues<WindowTransparencyMode>();
        readonly static string[] TransparencyModeNames = Enum.GetNames<WindowTransparencyMode>();

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

            float itemWidth = ImGui.CalcItemWidth();
            ImGui.Columns(2);
            ImGui.SetColumnWidth(0, itemWidth);
            if (ImGui.BeginChild("##windows", new System.Numerics.Vector2(0, ImGui.GetTextLineHeightWithSpacing() * 7.0f), ImGuiChildFlags.FrameStyle))
            {
                PaintWindow(Program.Window, 0);
                for (int i = 0; i < Program.ApplicationWindows.Count; i++)
                {
                    PaintWindow(Program.ApplicationWindows[i].Window, i + 1);
                }
                
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
                                Toolkit.Event.RaiseEvent(new CloseEventArgs(handle));

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
            ImGui.EndChild();
            ImGui.NextColumn();
            {
                Vector2i pos = default, cPos = default;
                Vector2i size = default, cSize = default, fbSize = default;
                float scaleX = 1, scaleY = 1;

                if (selectedWindow != -1)
                {
                    WindowHandle window = (selectedWindow == 0)
                            ? Program.Window
                            : Program.ApplicationWindows[selectedWindow - 1].Window;

                    Toolkit.Window.GetClientPosition(window, out cPos);
                    Toolkit.Window.GetPosition(window, out pos);
                    Toolkit.Window.GetClientSize(window, out cSize);
                    Toolkit.Window.GetSize(window, out size);
                    Toolkit.Window.GetFramebufferSize(window, out fbSize);
                    Toolkit.Window.GetScaleFactor(window, out scaleX, out scaleY);
                }

                ImGui.Text($"Position: ({pos.X}, {pos.Y})");
                ImGui.Text($"Client Position: ({cPos.X}, {cPos.Y})");
                ImGui.Text($"Size: ({size.X}, {size.Y})");
                ImGui.Text($"Client Size: ({cSize.X}, {cSize.Y})");
                ImGui.Text($"Framebuffer Size: ({fbSize.X}, {fbSize.Y})");
                ImGui.Text($"Scale: ({scaleX}, {scaleY})");
            }
            ImGui.Columns(1);
            
            if (selectedWindow != -1)
            {
                ImGui.SeparatorText("Window properties");

                WindowHandle window = (selectedWindow == 0)
                        ? Program.Window
                        : Program.ApplicationWindows[selectedWindow - 1].Window;

                ImGui.AlignTextToFramePadding();
                ImGui.TextUnformatted("Title"); ImGui.SameLine();
                ImGui.InputText("##title", ref titleString, 1024); ImGui.SameLine();
                if (ImGui.Button("Apply##tile"))
                {
                    Toolkit.Window.SetTitle(window, titleString);
                    Program.Logger.LogInfo($"Toolkit.Window.SetTitle(\"{titleString}\")");
                }

                if (Toolkit.Window is Platform.Native.X11.X11WindowComponent x11Win)
                {
                    ImGui.AlignTextToFramePadding();
                    ImGui.TextUnformatted("Iconified title"); ImGui.SameLine();
                    ImGui.InputText("##icon_title", ref iconTitleString, 1024); ImGui.SameLine();
                    if (ImGui.Button("Apply##icon_tile"))
                    {
                        x11Win.SetIconifiedTitle(window, iconTitleString);
                        Program.Logger.LogInfo($"Toolkit.Window.SetIconTitle(\"{iconTitleString}\")");
                    }

                    string iconTitle = x11Win.GetIconifiedTitle(window);
                }

                ImGui.AlignTextToFramePadding();
                WindowType type = Toolkit.Window.GetWindowType(window);
                if (ImGuiUtils.EnumToggleButtons("Window Type", ref type))
                {
                    Toolkit.Window.SetWindowType(window, type);
                    Program.Logger.LogInfo($"Toolkit.Window.SetWindowType({type})");
                }

                // FIXME: Convert these into buttons for setting the mode, and add a status text showing the current mode.
                ImGui.AlignTextToFramePadding();
                ImGui.TextUnformatted("Mode"); ImGui.SameLine();
                WindowMode mode = Toolkit.Window.GetMode(window);
                if (ImGuiUtils.EnumToggleButtons("Mode", ref mode))
                {
                    Toolkit.Window.SetMode(window, mode);
                    Program.Logger.LogInfo($"Toolkit.Window.SetMode({mode})");
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
                CursorCaptureMode captureMode = Toolkit.Window.GetCursorCaptureMode(window);
                if (ImGuiUtils.EnumCombo("###captureMode", ref captureMode))
                {
                    Toolkit.Window.SetCursorCaptureMode(window, captureMode);
                    Program.Logger.LogInfo($"Toolkit.Window.SetCursorCaptureMode({captureMode})");
                }

                ImGui.AlignTextToFramePadding();
                ImGui.TextUnformatted("Border style"); ImGui.SameLine();
                WindowBorderStyle border = Toolkit.Window.GetBorderStyle(window);
                if (ImGuiUtils.EnumCombo("##border_style", ref border))
                {
                    Toolkit.Window.SetBorderStyle(window, border);
                    Program.Logger.LogInfo($"Toolkit.Window.SetBorderStyle({border})");
                }

                ImGui.AlignTextToFramePadding();
                ImGui.TextUnformatted("Transparency mode"); ImGui.SameLine();
                if (ImGui.BeginCombo("##transparency_mode",  TransparencyModeNames[transparencyModeIndex]))
                {
                    for (int i = 0; i < TransparencyModeNames.Length; i++)
                    {
                        bool isSelected = i == transparencyModeIndex;

                        bool disable = false;
                        if (TransparencyModes[i] == WindowTransparencyMode.TransparentFramebuffer &&
                            Toolkit.Window.SupportsFramebufferTransparency(window) == false)
                        {
                            disable = true;
                        }

                        ImGui.BeginDisabled(disable);

                        if (ImGui.Selectable(TransparencyModeNames[i], isSelected))
                        {
                            transparencyModeIndex = i;
                        }

                        ImGui.EndDisabled();

                        if (isSelected)
                            ImGui.SetItemDefaultFocus();
                    }
                    ImGui.EndCombo();
                }
                ImGui.SameLine();
                //ImGui.Combo("##transparency_mode", ref transparencyModeIndex, TransparencyModeNames, TransparencyModeNames.Length); ImGui.SameLine();
                if (ImGui.Button("Apply##transparency_mode"))
                {
                    Toolkit.Window.SetTransparencyMode(window, TransparencyModes[transparencyModeIndex], windowOpacity);
                    Program.Logger.LogInfo($"Toolkit.Window.SetTransparencyMode({TransparencyModeNames[transparencyModeIndex]}, {windowOpacity})");

                    var transparencymMode = Toolkit.Window.GetTransparencyMode(window, out float opacity);
                    Program.Logger.LogInfo($"Transparency mode: {transparencymMode}");
                }
                ImGui.DragFloat("Opacity", ref windowOpacity, 0.01f, 0.0f, 1.0f);

                ImGui.AlignTextToFramePadding();
                bool alwaysOnTop = Toolkit.Window.IsAlwaysOnTop(window);
                if (ImGuiUtils.YesNoButtons("Always on top", ref alwaysOnTop))
                {
                    Toolkit.Window.SetAlwaysOnTop(window, alwaysOnTop);
                    Program.Logger.LogInfo($"Toolkit.Window.SetAlwaysOnTop({alwaysOnTop})");
                }

                ImGui.AlignTextToFramePadding();
                bool mousePassthrough = Toolkit.Window.GetMousePassthrough(window);
                if (ImGuiUtils.YesNoButtons("Input passthrough", ref mousePassthrough, "Enabled", "Disabled"))
                {
                    Toolkit.Window.SetMousePassthrough(window, mousePassthrough);
                    Program.Logger.LogInfo($"Toolkit.Window.SetMousePassthrough({mousePassthrough})");
                }

                ImGui.AlignTextToFramePadding();
                bool focusable = Toolkit.Window.GetFocusable(window);
                if (ImGuiUtils.YesNoButtons("Focusable", ref focusable))
                {
                    Toolkit.Window.SetFocusable(window, focusable);
                    Program.Logger.LogInfo($"Toolkit.Window.SetFocusable({focusable})");
                }

                ImGui.DragInt2("Position", ref windowPosition.X); ImGui.SameLine();
                if (ImGui.Button("Set##Position"))
                {
                    Toolkit.Window.SetPosition(window, windowPosition);
                    Program.Logger.LogInfo($"Toolkit.Window.SetPosition({windowPosition})");

                    Toolkit.Window.GetPosition(window, out Vector2i position);
                    Program.Logger.LogInfo($"Window position: ({position.X}, {position.Y})");
                }

                ImGui.DragInt2("Client position", ref clientPosition.X); ImGui.SameLine();
                if (ImGui.Button("Set##ClientPosition"))
                {
                    Toolkit.Window.SetClientPosition(window, clientPosition);
                    Program.Logger.LogInfo($"Toolkit.Window.SetClientPosition({clientPosition})");

                    Toolkit.Window.GetClientPosition(window, out Vector2i cPos);
                    Program.Logger.LogInfo($"Client position: ({cPos.X}, {cPos.Y})");
                }
            }

            ImGui.SeparatorText("Window creation");

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

                        // FIXME: Get the max supported samples from the selected window context...?
                        int samples = openglSettings.Multisamples;
                        if (ImGui.DragInt("Samples", ref samples, IntDragSpeed, 1, 128))
                            openglSettings.Multisamples = samples;

                        ImGui.EndDisabled();
                    }

                    ContextPixelFormat pixelFormat = openglSettings.PixelFormat;
                    if (ImGuiUtils.EnumCombo("Pixel format", ref pixelFormat))
                        openglSettings.PixelFormat = pixelFormat;

                    bool doubleBuffer = openglSettings.DoubleBuffer;
                    if (ImGui.Checkbox("Double buffer", ref doubleBuffer))
                        openglSettings.DoubleBuffer = doubleBuffer;

                    bool srgb = openglSettings.sRGBFramebuffer;
                    if (ImGui.Checkbox("sRGB Framebuffer", ref srgb))
                        openglSettings.sRGBFramebuffer = srgb;

                    if (Toolkit.Window is Platform.Native.X11.X11WindowComponent)
                    {
                        bool supportTransparentFramebuffer = openglSettings.SupportTransparentFramebufferX11;
                        if (ImGui.Checkbox("Supports framebuffer transparency", ref supportTransparentFramebuffer))
                            openglSettings.SupportTransparentFramebufferX11 = supportTransparentFramebuffer;
                    }
                    
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

                ImGuiUtils.EnumCombo("Window Mode", ref WindowMode);

                if (ImGui.Button("Create Window"))
                {
                    try
                    {
                        WindowHandle handle = Toolkit.Window.Create(openglSettings.Copy());

                        int index = Program.ApplicationWindows.Count + 1;
                        Program.ApplicationWindows.Add(new Program.ApplicationWindow(handle));

                        Toolkit.Window.SetTitle(handle, $"Child Window #{index}");
                        Toolkit.Window.SetSize(handle, WindowSize);
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

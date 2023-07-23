using ImGuiNET;
using OpenTK.Core.Platform;
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
        public override string Title => "Window Component";

        private IWindowComponent? WindowComponent;
        private WindowManager WindowManager;

        public WindowComponentView() { }

        const float IntDragSpeed = 0.2f;

        public override void Initialize()
        {
            WindowComponent = Program.WindowComp;
            WindowManager = Program.WindowManager;
        }

        int selectedWindow = -1;

        OpenGLGraphicsApiHints openglSettings = new OpenGLGraphicsApiHints();

        string titleString = "";
        int modeIndex = 0;

        WindowMode[] WindowModes = Enum.GetValues<WindowMode>();
        string[] WindowModeNames = Enum.GetNames<WindowMode>();

        public override void Paint()
        {
            base.Paint();

            if (ImGui.BeginTable("window_caps_id", 2, ImGuiTableFlags.Borders))
            {
                ImGui.TableSetupColumn("Capability", ImGuiTableColumnFlags.WidthFixed);
                ImGui.TableSetupColumn("Component", ImGuiTableColumnFlags.WidthFixed);
                ImGui.TableHeadersRow();

                ImGui.TableNextRow();
                ImGui.TableNextColumn(); ImGui.TextUnformatted("Can set cursor");
                bool canSetCursor = WindowComponent?.CanSetCursor ?? false;
                // FIXME: Display a checkmark or something else here?
                ImGui.TableNextColumn(); ImGui.BeginDisabled(); ImGui.Checkbox("", ref canSetCursor); ImGui.EndDisabled();

                ImGui.TableNextRow();
                ImGui.TableNextColumn(); ImGui.TextUnformatted("Can get display");
                bool canGetDisplay = WindowComponent?.CanGetDisplay ?? false;
                // FIXME: Display a checkmark or something else here?
                ImGui.TableNextColumn(); ImGui.BeginDisabled(); ImGui.Checkbox("", ref canGetDisplay); ImGui.EndDisabled();

                ImGui.TableNextRow();
                ImGui.TableNextColumn(); ImGui.TextUnformatted("Can capture cursor");
                bool canCaptureCursor = WindowComponent?.CanCaptureCursor ?? false;
                // FIXME: Display a checkmark or something else here?
                ImGui.TableNextColumn(); ImGui.BeginDisabled(); ImGui.Checkbox("", ref canCaptureCursor); ImGui.EndDisabled();

                ImGui.TableNextRow();
                ImGui.TableNextColumn(); ImGui.TextUnformatted("Can set icon");
                bool canSetIcon = WindowComponent?.CanSetIcon ?? false;
                // FIXME: Display a checkmark or something else here?
                ImGui.TableNextColumn(); ImGui.BeginDisabled(); ImGui.Checkbox("", ref canSetIcon); ImGui.EndDisabled();

                ImGui.EndTable();
            }

            if (ImGui.BeginListBox("Windows"))
            {
                for (int i = 0; i < WindowManager.Count; i++)
                {
                    string name;
                    try
                    {
                        name = WindowComponent!.GetTitle(WindowManager.Windows[i]);
                    }
                    catch (Exception e)
                    {
                        Program.Logger.LogError($"Unable to get window title of window: {e}");
                        name = $"Window #{i} (unable to get name)";
                    }

                    if (WindowManager.Windows[i] == Program.Window)
                    {
                        name += " (this window)";
                    }

                    bool isSelected = i == selectedWindow;

                    if (ImGui.Selectable(name, isSelected, ImGuiSelectableFlags.AllowOverlap))
                    {
                        selectedWindow = i;

                        try
                        {
                            titleString = WindowComponent!.GetTitle(WindowManager.Windows[selectedWindow]);
                        }
                        catch (Exception e)
                        {
                            Program.Logger.LogError($"Unable to get window title of window: {e}");
                            titleString = $"Window #{i} (unable to get title)";
                        }
                    }

                    if (isSelected) ImGui.SetItemDefaultFocus();

                    if (WindowManager.Windows[i] != Program.Window)
                    {
                        ImGui.SameLine();
                        ImGui.PushID(i);
                        if (ImGui.SmallButton($"x"))
                        {
                            try
                            {
                                WindowManager.RemoveWindow(i);

                                if (selectedWindow == i)
                                {
                                    selectedWindow = -1;
                                }
                            }
                            catch (Exception e)
                            {

                                throw;
                            }
                        }
                        ImGui.PopID();
                    }
                }
                ImGui.EndListBox();
            }
            

            if (ImGui.CollapsingHeader("Window Creation"))
            {
                ImGui.SeparatorText("Version");
                int major = openglSettings.Version.Major;
                bool majorChanged = ImGui.DragInt("Major", ref major, IntDragSpeed, 1, 5);
                int minor = openglSettings.Version.Minor;
                bool minorChanged = ImGui.DragInt("Minor", ref minor, IntDragSpeed, 0, 9);
                if (majorChanged || minorChanged)
                    openglSettings.Version = new Version(major, minor);

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
                // FIXME: Find the name string directly?
                if (ImGui.BeginCombo("Stencil bits", stencilBits.ToString()))
                {
                    // FIXME: Nice names like "8 bits"?
                    ContextStencilBits[] values = Enum.GetValues<ContextStencilBits>();
                    for (int i = 0; i < values.Length; i++)
                    {
                        bool isSelected = values[i] == stencilBits;

                        if (ImGui.Selectable(values[i].ToString(), isSelected))
                        {
                            openglSettings.StencilBits = values[i];
                        }

                        if (isSelected) ImGui.SetItemDefaultFocus();
                    }
                    ImGui.EndCombo();
                }

                ContextDepthBits depthBits = openglSettings.DepthBits;
                // FIXME: Find the name string directly?
                if (ImGui.BeginCombo("Depth bits", depthBits.ToString()))
                {
                    // FIXME: Nice names like "8 bits"?
                    ContextDepthBits[] values = Enum.GetValues<ContextDepthBits>();
                    for (int i = 0; i < values.Length; i++)
                    {
                        bool isSelected = values[i] == depthBits;

                        if (ImGui.Selectable(values[i].ToString(), isSelected))
                        {
                            openglSettings.DepthBits = values[i];
                        }

                        if (isSelected) ImGui.SetItemDefaultFocus();
                    }
                    ImGui.EndCombo();
                }

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

                OpenGLProfile profile = openglSettings.Profile;
                // FIXME: Find the name string directly?
                if (ImGui.BeginCombo("Profile", profile.ToString()))
                {
                    OpenGLProfile[] values = Enum.GetValues<OpenGLProfile>();
                    for (int i = 0; i < values.Length; i++)
                    {
                        bool isSelected = values[i] == profile;

                        if (ImGui.Selectable(values[i].ToString(), isSelected))
                        {
                            openglSettings.Profile = values[i];
                        }

                        if (isSelected) ImGui.SetItemDefaultFocus();
                    }
                    ImGui.EndCombo();
                }

                bool forwardCompat = openglSettings.ForwardCompatibleFlag;
                if (ImGui.Checkbox("Forward compatible flag", ref forwardCompat))
                    openglSettings.ForwardCompatibleFlag = forwardCompat;

                bool debug = openglSettings.DebugFlag;
                if (ImGui.Checkbox("Debug flag", ref debug))
                    openglSettings.DebugFlag = debug;

                ImGui.SeparatorText("Window properties");

                if (ImGui.Button("Create Window"))
                {
                    try
                    {
                        WindowHandle handle = WindowComponent!.Create(openglSettings.Copy());
                        int index = WindowManager.AddWindow(handle, null);
                        WindowComponent.SetTitle(handle, $"Child Window #{index}");
                    }
                    catch (Exception e)
                    {
                        // FIXME: Show an error message!
                        Program.Logger.LogError($"Unable to create window: {e}");
                    }
                }
            }

            if (selectedWindow != -1)
            {
                WindowHandle window = WindowManager.Windows[selectedWindow];

                if (ImGui.CollapsingHeader("Info"))
                {
                    ImGui.Text($"Title: {WindowComponent!.GetTitle(window)}");
                    WindowComponent.GetClientSize(window, out int width, out int height);
                    WindowComponent.GetClientPosition(window, out int x, out int y);
                    ImGui.Text($"Client Position: ({x}, {y})");
                    ImGui.Text($"Client Size: ({width}, {height})");
                }

                ImGui.AlignTextToFramePadding();
                ImGui.TextUnformatted("Title"); ImGui.SameLine();
                ImGui.InputText("##title", ref titleString, 1024); ImGui.SameLine();
                if (ImGui.Button("Apply##tile"))
                {
                    WindowComponent!.SetTitle(window, titleString);
                    Program.Logger.LogInfo($"WindowComponent.SetTitle(\"{titleString}\")");
                }

                ImGui.AlignTextToFramePadding();
                ImGui.TextUnformatted("Mode"); ImGui.SameLine();
                ImGui.Combo("##mode", ref modeIndex, WindowModeNames, WindowModeNames.Length); ImGui.SameLine();
                if (ImGui.Button("Apply##mode"))
                {
                    WindowComponent!.SetMode(window, WindowModes[modeIndex]);
                    Program.Logger.LogInfo($"WindowComponent.SetMode({WindowModeNames[modeIndex]})");
                }
            }
        }
    }
}

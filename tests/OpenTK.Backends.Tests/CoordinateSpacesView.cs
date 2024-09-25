using ImGuiNET;
using OpenTK.Platform;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using OpenTK.Platform.Native.macOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Backends.Tests
{
    internal class CoordinateSpacesView : View
    {
        public override string Title => "Coordinates";

        public override bool IsVisible => Toolkit.Window != null;

        static readonly System.Numerics.Vector4 GoodColor = new  System.Numerics.Vector4(0.630f, 0.980f, 0.343f, 1.0f);
        static readonly System.Numerics.Vector4 BadColor = new  System.Numerics.Vector4(1.0f, 0.184f, 0.184f, 1.0f);


        readonly static CursorCaptureMode[] CaptureModes = Enum.GetValues<CursorCaptureMode>();
        readonly static string[] CaptureModeNames = Enum.GetNames<CursorCaptureMode>();

        int captureModeIndex = 0;

        WindowHandle? mouseCoordWindow = null;

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

            if (Toolkit.Window != null)
            {
                try
                {
                    ImGui.SeparatorText("Window comp");

                    Toolkit.Window.GetPosition(Program.Window, out Vector2i p);
                    Toolkit.Window.GetClientPosition(Program.Window, out Vector2i cp);
                    Toolkit.Window.GetSize(Program.Window, out Vector2i s);
                    Toolkit.Window.GetClientSize(Program.Window, out Vector2i cs);
                    Toolkit.Window.GetBounds(Program.Window, out int bpx, out int bpy, out int bw, out int bh);
                    Toolkit.Window.GetClientBounds(Program.Window, out int bcpx, out int bcpy, out int bcw, out int bch);
                    Toolkit.Window.GetScaleFactor(Program.Window, out float scaleX, out float scaleY);
                    Toolkit.Window.GetFramebufferSize(Program.Window, out Vector2i fbs);
                    Toolkit.Window.ClientToScreen(Program.Window, (0, 0), out Vector2 orig);

                    int extLeft = cp.X - p.X;
                    int extTop = cp.Y - p.Y;
                    int extRight = (cp.X + cs.X) - (p.X + s.X);
                    int extBottom = (cp.Y + cs.Y) - (p.Y + s.Y);

                    ImGui.Text($"Position: ({p.X}, {p.Y})");
                    ImGui.Text($"Client Position: ({cp.X}, {cp.Y})");
                    ImGui.Text($"(0,0) client to screen: ({orig.X}, {orig.Y})"); ImGui.SameLine(); ImGuiUtils.HelpMarker("This is calculated by plugging (0, 0) into ClientToScreen().");
                    ImGui.Text($"Size: ({s.X}, {s.Y})");
                    ImGui.Text($"Client Size: ({cs.X}, {cs.Y})");
                    ImGui.Text($"Bounds: (x:{bpx}, y:{bpy}, w:{bw}, h:{bh})");
                    ImGui.Text($"Client Bounds: (x:{bcpx}, y:{bcpy}, w:{bcw}, h:{bch})");
                    ImGui.Text($"Scale factor: (x:{scaleX}, y:{scaleY})");
                    ImGui.Text($"Framebuffer size: {fbs.X}x{fbs.Y}");
                    ImGui.Text($"Window extents: (l:{extLeft}, t:{extTop}, r:{extRight}, b:{extBottom})");

                    // FIXME: Make some way to get out of the locked cursor mode.
                    ImGui.AlignTextToFramePadding();
                    ImGui.TextUnformatted("Cursor capture mode"); ImGui.SameLine();
                    ImGui.Combo("##captureMode", ref captureModeIndex, CaptureModeNames, CaptureModeNames.Length); ImGui.SameLine();
                    if (ImGui.Button("Apply##captureMode"))
                    {
                        Toolkit.Window.SetCursorCaptureMode(Program.Window, CaptureModes[captureModeIndex]);
                    }
                }
                catch { }
            }

            if (Toolkit.Mouse != null)
            {
                try
                {
                    ImGui.SeparatorText("Mouse comp");

                    Toolkit.Mouse.GetGlobalPosition(out Vector2 globalPosition);
                    Toolkit.Mouse.GetGlobalMouseState(out MouseState globalState);

                    System.Numerics.Vector4 positionsMatchColor = globalState.Position == globalPosition ? GoodColor : BadColor;

                    // FIXME: Display these in red text if they are not the same!
                    ImGui.TextColored(positionsMatchColor, $"Global Mouse position: ({globalPosition.X}, {globalPosition.Y})");                   ImGui.SameLine(); ImGuiUtils.HelpMarker("This info comes from GetGlobalPosition(). Should be the same as mouse state position.");
                    ImGui.TextColored(positionsMatchColor, $"Global Mouse state position: ({globalState.Position.X}, {globalState.Position.Y})"); ImGui.SameLine(); ImGuiUtils.HelpMarker("This info comes from GetGlobalMouseState(). Should be the same as mouse position.");

                    ImGuiUtils.WindowCombobox("Window", ref mouseCoordWindow);

                    Toolkit.Mouse.GetPosition(mouseCoordWindow, out Vector2 position);
                    Toolkit.Mouse.GetMouseState(mouseCoordWindow, out MouseState state);

                    System.Numerics.Vector4 windowPositionsMatchColor = state.Position == position ? GoodColor : BadColor;

                    ImGui.TextColored(positionsMatchColor, $"Window Mouse position: ({position.X}, {position.Y})");                   ImGui.SameLine(); ImGuiUtils.HelpMarker("This info comes from GetPosition(). Should be the same as mouse state position.");
                    ImGui.TextColored(positionsMatchColor, $"Window Mouse state position: ({state.Position.X}, {state.Position.Y})"); ImGui.SameLine(); ImGuiUtils.HelpMarker("This info comes from GetMouseState(). Should be the same as mouse position.");

                    if (Toolkit.Window != null)
                    {
                        Toolkit.Window.ScreenToClient(mouseCoordWindow, globalPosition, out Vector2 client);
                        Toolkit.Window.ClientToScreen(mouseCoordWindow, position, out Vector2 screen);
                        Toolkit.Window.ClientToFramebuffer(mouseCoordWindow, position, out Vector2 framebuffer);
                        Toolkit.Window.ClientToFramebuffer(mouseCoordWindow, client, out Vector2 framebuffer2);

                        // FIXME: Maybe only show BadColor if the positions don't match AND the mouse is inside the window.
                        System.Numerics.Vector4 screenToClientColor = (client == position) ? GoodColor : BadColor;
                        System.Numerics.Vector4 clientToScreenColor = (screen == globalPosition) ? GoodColor : BadColor;
                        System.Numerics.Vector4 clientToFramebufferColor = (framebuffer == framebuffer2) ? GoodColor : BadColor;

                        ImGui.TextColored(screenToClientColor, $"Screen to Client position: ({client.X}, {client.Y})"); ImGui.SameLine(); ImGuiUtils.HelpMarker("This info comes from ScreenToClient() plugging in GetGlobalPosition().");
                        ImGui.TextColored(clientToScreenColor, $"Client to Screen position: ({screen.X}, {screen.Y})"); ImGui.SameLine(); ImGuiUtils.HelpMarker("This info comes from ClientToScreen() plugging in GetPosition().");
                        ImGui.TextColored(clientToFramebufferColor, $"Client to Framebuffer position: ({framebuffer.X}, {framebuffer.Y})"); ImGui.SameLine(); ImGuiUtils.HelpMarker("This info comes from ClientToFramebuffer() plugging in GetPosition().");
                        ImGui.TextColored(clientToFramebufferColor, $"Screen to Client to Framebuffer position: ({framebuffer2.X}, {framebuffer2.Y})"); ImGui.SameLine(); ImGuiUtils.HelpMarker("This info comes from ScreenToClient() followed by ClientToFramebuffer() plugging in GetPosition().");
                    }
                }
                catch { }
            }

            if (Toolkit.Display != null)
            {
                try
                {
                    ImGui.SeparatorText("Display comp");

                    // FIXME: Make this some sort of imgui list?
                    int count = Toolkit.Display.GetDisplayCount();
                    for (int i = 0; i < count; i++)
                    {
                        DisplayHandle handle = Toolkit.Display.Open(i);

                        string name = Toolkit.Display.GetName(handle);
                        ImGui.Text($"Display {i + 1} ({name})");

                        Toolkit.Display.GetVirtualPosition(handle, out int x, out int y);
                        Toolkit.Display.GetResolution(handle, out int width, out int height);
                        Toolkit.Display.GetWorkArea(handle, out Box2i workArea);
                        Toolkit.Display.GetDisplayScale(handle, out float scaleX, out float scaleY);
                        Toolkit.Display.GetVideoMode(handle, out VideoMode mode);

                        System.Numerics.Vector4 resolutionsMatchColor = (mode.Width, mode.Height) == (width, height) ? GoodColor : BadColor;

                        ImGui.Text($"Position: ({x}, {y})");
                        // FIXME: Mark red if these do not match.
                        ImGui.TextColored(resolutionsMatchColor, $"Resolution: {width}x{height}");                       ImGui.SameLine(); ImGuiUtils.HelpMarker("From GetResolution(). Should be the same as Video mode resolution.");
                        ImGui.TextColored(resolutionsMatchColor, $"Video mode resoltion: ({mode.Width}x{mode.Height})"); ImGui.SameLine(); ImGuiUtils.HelpMarker("From GetVideoMode(). Should be the same as Resolution.");
                        ImGui.Text($"Bounds: {new Box2i((x,y), (x+width, y+height))}");
                        ImGui.Text($"Work area: {workArea}");

                        ImGui.Text("");

                        Toolkit.Display.Close(handle);
                    }
                }
                catch { }
            }

            // FIXME; Do a little display similar to DisplayComponentView where we can see the displays, the window and the mouse.
        }
    }
}

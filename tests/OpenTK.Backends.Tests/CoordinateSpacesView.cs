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

        readonly static CursorCaptureMode[] CaptureModes = Enum.GetValues<CursorCaptureMode>();
        readonly static string[] CaptureModeNames = Enum.GetNames<CursorCaptureMode>();

        int captureModeIndex = 0;

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

                    Toolkit.Window.GetPosition(Program.Window, out int px, out int py);
                    Toolkit.Window.GetClientPosition(Program.Window, out int cpx, out int cpy);
                    Toolkit.Window.GetSize(Program.Window, out int w, out int h);
                    Toolkit.Window.GetClientSize(Program.Window, out int cw, out int ch);
                    Toolkit.Window.GetBounds(Program.Window, out int bpx, out int bpy, out int bw, out int bh);
                    Toolkit.Window.GetClientBounds(Program.Window, out int bcpx, out int bcpy, out int bcw, out int bch);
                    Toolkit.Window.GetScaleFactor(Program.Window, out float scaleX, out float scaleY);
                    Toolkit.Window.GetFramebufferSize(Program.Window, out int fbw, out int fbh);
                    Toolkit.Window.ClientToScreen(Program.Window, 0, 0, out int origX, out int origY);

                    ImGui.Text($"Position: ({px}, {py})");
                    ImGui.Text($"Client Position: ({cpx}, {cpy})");
                    ImGui.Text($"(0,0) client to screen: ({origX}, {origY})"); ImGui.SameLine(); ImGuiUtils.HelpMarker("This is calculated by plugging (0, 0) into ClientToScreen().");
                    ImGui.Text($"Size: ({w}, {h})");
                    ImGui.Text($"Client Size: ({cw}, {ch})");
                    ImGui.Text($"Bounds: (x:{bpx}, y:{bpy}, w:{bw}, h:{bh})");
                    ImGui.Text($"Client Bounds: (x:{bcpx}, y:{bcpy}, w:{bcw}, h:{bch})");
                    ImGui.Text($"Scale factor: (x:{scaleX}, y:{scaleY})");
                    ImGui.Text($"Framebuffer size: {fbw}x{fbh}");

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

                    Toolkit.Mouse.GetPosition(out int x, out int y);
                    Toolkit.Mouse.GetMouseState(out MouseState state);

                    // FIXME: Display these in red text if they are not the same!
                    ImGui.Text($"Mouse position: ({x}, {y})");                                     ImGui.SameLine(); ImGuiUtils.HelpMarker("This info comes from GetPosition(). Should be the same as mouse state position.");
                    ImGui.Text($"Mouse state position: ({state.Position.X}, {state.Position.Y})"); ImGui.SameLine(); ImGuiUtils.HelpMarker("This info comes from GetMouseState(). Should be the same as mouse position.");

                    if (Toolkit.Window != null)
                    {
                        Toolkit.Window.ScreenToClient(Program.Window, x, y, out int clientX, out int clientY);
                        ImGui.Text($"Client position: ({clientX}, {clientY})"); ImGui.SameLine(); ImGuiUtils.HelpMarker("This info comes from ScreenToClient().");
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

                        ImGui.Text($"Position: ({x}, {y})");
                        // FIXME: Mark red if these do not match.
                        ImGui.Text($"Resolution: {width}x{height}");                       ImGui.SameLine(); ImGuiUtils.HelpMarker("From GetResolution(). Should be the same as Video mode resolution.");
                        ImGui.Text($"Video mode resoltion: ({mode.Width}x{mode.Height})"); ImGui.SameLine(); ImGuiUtils.HelpMarker("From GetVideoMode(). Should be the same as Resolution.");
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

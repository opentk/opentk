using ImGuiNET;
using OpenTK.Core.Platform;
using OpenTK.Mathematics;
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

        public override bool IsVisible => Program.WindowComp != null;

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

            if (Program.WindowComp != null)
            {
                try
                {
                    ImGui.SeparatorText("Window comp");

                    Program.WindowComp.GetPosition(Program.Window, out int px, out int py);
                    Program.WindowComp.GetClientPosition(Program.Window, out int cpx, out int cpy);
                    Program.WindowComp.GetSize(Program.Window, out int w, out int h);
                    Program.WindowComp.GetClientSize(Program.Window, out int cw, out int ch);
                    Program.WindowComp.GetBounds(Program.Window, out int bpx, out int bpy, out int bw, out int bh);
                    Program.WindowComp.GetClientBounds(Program.Window, out int bcpx, out int bcpy, out int bcw, out int bch);

                    ImGui.Text($"Position: ({px}, {py})");
                    ImGui.Text($"Client Position: ({cpx}, {cpy})");
                    ImGui.Text($"Size: ({w}, {h})");
                    ImGui.Text($"Client Size: ({cw}, {ch})");
                    ImGui.Text($"Bounds: (x:{bpx}, y:{bpy}, w:{bw}, h:{bh})");
                    ImGui.Text($"Client Bounds: (x:{bcpx}, y:{bcpy}, w:{bcw}, h:{bch})");
                    // FIXME: Framebuffer size?

                    if (Program.WindowComp is MacOSWindowComponent macOSWindowComp)
                    {
                        macOSWindowComp.GetFramebufferSize(Program.Window, out int fbw, out int fbh);

                        ImGui.Text($"Framebuffer size: {fbw}x{fbh}");
                    }
                }
                catch { }
            }

            if (Program.MouseComponent != null)
            {
                try
                {
                    ImGui.SeparatorText("Mouse comp");

                    Program.MouseComponent.GetPosition(out int x, out int y);
                    Program.MouseComponent.GetMouseState(out MouseState state);

                    // FIXME: Display these in red text if they are not the same!
                    ImGui.Text($"Mouse position: ({x}, {y})");                                     ImGui.SameLine(); ImGuiUtils.HelpMarker("This info comes from GetPosition(). Should be the same as mouse state position.");
                    ImGui.Text($"Mouse state position: ({state.Position.X}, {state.Position.Y})"); ImGui.SameLine(); ImGuiUtils.HelpMarker("This info comes from GetMouseState(). Should be the same as mouse position.");
                }
                catch { }
            }

            if (Program.DisplayComponent != null)
            {
                try
                {
                    ImGui.SeparatorText("Display comp");

                    // FIXME: Make this some sort of imgui list?
                    int count = Program.DisplayComponent.GetDisplayCount();
                    for (int i = 0; i < count; i++)
                    {
                        DisplayHandle handle = Program.DisplayComponent.Open(i);

                        string name = Program.DisplayComponent.GetName(handle);
                        ImGui.Text($"Display {i + 1} ({name})");

                        Program.DisplayComponent.GetVirtualPosition(handle, out int x, out int y);
                        Program.DisplayComponent.GetResolution(handle, out int width, out int height);
                        Program.DisplayComponent.GetWorkArea(handle, out Box2i workArea);
                        Program.DisplayComponent.GetDisplayScale(handle, out float scaleX, out float scaleY);
                        Program.DisplayComponent.GetVideoMode(handle, out VideoMode mode);

                        ImGui.Text($"Position: ({x}, {y})");
                        // FIXME: Mark red if these do not match.
                        ImGui.Text($"Resolution: {width}x{height}");                       ImGui.SameLine(); ImGuiUtils.HelpMarker("From GetResolution(). Should be the same as Video mode resolution.");
                        ImGui.Text($"Video mode resoltion: ({mode.Width}x{mode.Height})"); ImGui.SameLine(); ImGuiUtils.HelpMarker("From GetVideoMode(). Should be the same as Resolution.");
                        ImGui.Text($"Bounds: {new Box2i((x,y), (x+width, y+height))}");
                        ImGui.Text($"Work area: {workArea}");

                        ImGui.Text("");

                        Program.DisplayComponent.Close(handle);
                    }
                }
                catch { }
            }

            // FIXME; Do a little display similar to DisplayComponentView where we can see the displays, the window and the mouse.
        }
    }
}

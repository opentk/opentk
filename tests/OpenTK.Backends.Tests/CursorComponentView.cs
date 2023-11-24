using ImGuiNET;
using OpenTK.Core.Platform;
using OpenTK.Mathematics;
using OpenTK.Platform.Native.macOS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Backends.Tests
{
    internal class CursorComponentView : View
    {
        public override string Title => "Cursor";

        public override bool IsVisible => Program.CursorComp != null;

        private bool canLoadSystemCursors;
        private bool canInspectSystemCursors;

        public SortedDictionary<SystemCursorType, CursorHandle> SystemCursors = new SortedDictionary<SystemCursorType, CursorHandle>();

        public override void Initialize()
        {
            base.Initialize();

            try { canLoadSystemCursors = Program.CursorComp!.CanLoadSystemCursors; } catch { canLoadSystemCursors = false; }
            try { canInspectSystemCursors = Program.CursorComp!.CanInspectSystemCursors; } catch { canInspectSystemCursors = false; }

            if (canLoadSystemCursors)
            {
                foreach (SystemCursorType cursorType in Enum.GetValues<SystemCursorType>())
                {
                    CursorHandle handle = Program.CursorComp!.Create(cursorType);
                    SystemCursors.Add(cursorType, handle);
                }
            }

            try
            {
                // FIXME: Better cursor image
                byte[] icon = new byte[16 * 16 * 4];
                for (int ccx = 0; ccx < 16; ccx++)
                {
                    for (int ccy = 0; ccy < 16; ccy++)
                    {
                        int index = (ccy * 16 + ccx) * 4;

                        if (ccx < 5)
                        {
                            icon[index + 0] = 255;
                            icon[index + 1] = 0;
                            icon[index + 2] = 0;
                        }
                        else if (ccx < 10)
                        {
                            icon[index + 0] = 0;
                            icon[index + 1] = 255;
                            icon[index + 2] = 0;
                        }
                        else
                        {
                            icon[index + 0] = 0;
                            icon[index + 1] = 0;
                            icon[index + 2] = 255;
                        }

                        icon[index + 3] = 255;
                        if (ccy < 5) icon[index + 3] = 50;
                    }
                }
                // FIXME: Don't allocate the cursor every frame...
                customColorCursor = Program.CursorComp!.Create(16, 16, icon, 0, 0);

                byte[] image = new byte[16 * 16 * 3];
                byte[] mask = new byte[16 * 16 * 1];
                for (int ccx = 0; ccx < 16; ccx++)
                {
                    for (int ccy = 0; ccy < 16; ccy++)
                    {
                        int index = (ccy * 16 + ccx) * 3;

                        image[index + 0] = (byte)(ccx * 16);
                        image[index + 1] = (byte)(ccx * 16);
                        image[index + 2] = (byte)(ccx * 16);

                        mask[(ccy * 16 + ccx)] = (byte)((ccy % 2 == 0) ? 1 : 0);
                    }
                }
                customMaskCursor = Program.CursorComp.Create(16, 16, image, mask, 8, 8);
            }
            catch
            { }
        }

        bool hasSetCursor = false;

        string cursorFilePath = Path.Combine(Environment.CurrentDirectory, "Resources");
        CursorHandle? loadedCursor = null;
        CursorHandle? customColorCursor = null;
        CursorHandle? customMaskCursor = null;
        string cursorName = "";
        string? loadingError = null;

        public override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

            bool setCursor = false;

            ImGui.SeparatorText("Component Properties");
            // FIXME: Separate display if the property threw an exception?
            ImGuiUtils.ReadonlyCheckbox("Can Load System Cursors", canLoadSystemCursors);
            ImGuiUtils.ReadonlyCheckbox("Can Inspect System Cursors", canInspectSystemCursors);

            ImGui.SeparatorText("System Cursors");

            if (canLoadSystemCursors == false)
            {
                ImGui.BeginDisabled();
            }

            float targetSize;
            {
                float maxTextWidth = float.NegativeInfinity;
                foreach (string name in Enum.GetNames<SystemCursorType>())
                {
                    float textWidth = ImGui.CalcTextSize(name).X;
                    if (textWidth > maxTextWidth)
                    {
                        maxTextWidth = textWidth;
                    }
                }

                float columnWidth = ImGui.GetColumnWidth();
                // The max text width + some padding.
                targetSize = maxTextWidth + 10;
                int buttonsPerLine = (int)(columnWidth / targetSize);
                if (buttonsPerLine == 0) buttonsPerLine = 1;
                targetSize = columnWidth / buttonsPerLine;

                // Remove a little size to account for padding
                // FIXME: Get the actual size we need to remove
                targetSize -= 8;

                ImGui.PushStyleVar(ImGuiStyleVar.FrameRounding, 5);
                int i = 0;
                int hoveredIndex = -1;
                foreach (var (cursorType, handle) in SystemCursors)
                {
                    if (i++ % buttonsPerLine != 0) ImGui.SameLine();

                    ImGui.Button(cursorType.ToString(), new System.Numerics.Vector2(targetSize, targetSize));

                    if (ImGui.IsItemHovered())
                    {
                        // FIXME: Should we even show the cursors if they can't be set?
                        if (Program.WindowComp.CanSetIcon)
                        {
                            (Program.CursorComp as MacOSCursorComponent)?.UpdateAnimation(handle, deltaTime);
                            // FIXME: We are potentially leaking a cursor? or does the window hold it's own copy?
                            Program.WindowComp.SetCursor(Program.Window, handle);
                            setCursor = true;

                            hoveredIndex = i - 1;

                        }
                    }
                }
                ImGui.PopStyleVar();

                if (canInspectSystemCursors)
                {
                    string? name = null;
                    Vector2i size = (0, 0);
                    Vector2i hotspot = (0, 0);

                    if (hoveredIndex != -1)
                    {
                        // FIXME: linq
                        var (type, handle) = SystemCursors.ElementAt(hoveredIndex);
                        name = type.ToString();

                        Program.CursorComp!.GetSize(handle, out int width, out int height);
                        size = (width, height);

                        Program.CursorComp!.GetHotspot(handle, out int hx, out int hy);
                        hotspot = (hx, hy);
                    }

                    ImGui.Text($"Name: {name}");
                    ImGui.Text($"Width: {size.X}px, Height: {size.Y}px");
                    ImGui.Text($"Hotspot: ({hotspot.X}, {hotspot.Y})");
                }
            }

            if (canLoadSystemCursors == false)
            {
                ImGui.EndDisabled();
            }

            {
                ImGui.SeparatorText("Custom cursors");

                ImGui.PushStyleVar(ImGuiStyleVar.FrameRounding, 5);

                CursorHandle? hoveredHandle = null;
                if (CursorButton(customColorCursor, "Color cursor"))
                {
                    hoveredHandle = customColorCursor;
                }

                ImGui.SameLine();

                if (CursorButton(customMaskCursor, "Mask cursor"))
                {
                    hoveredHandle = customMaskCursor;
                }

                ImGui.PopStyleVar();

                Vector2i size = (0, 0);
                Vector2i hotspot = (0, 0);
                if (hoveredHandle != null)
                {
                    Program.CursorComp!.GetSize(hoveredHandle, out int width, out int height);
                    size = (width, height);

                    Program.CursorComp!.GetHotspot(hoveredHandle, out int x, out int y);
                    hotspot = (x, y);
                }
                ImGui.Text($"Width: {size.X}px, Height: {size.Y}px");
                ImGui.Text($"Hotspot: ({hotspot.X}, {hotspot.Y})");

                bool CursorButton(CursorHandle? handle, string name)
                {
                    if (handle == null)
                    {
                        ImGui.BeginDisabled();
                    }

                    // Do we really want to use targetSize here?
                    float padding = ImGui.GetStyle().FramePadding.X;
                    ImGui.Button(name, new System.Numerics.Vector2(ImGui.CalcTextSize(name).X + 2 * padding, targetSize));
                    bool hovered = ImGui.IsItemHovered();
                    if (hovered)
                    {
                        if (Program.WindowComp.CanSetCursor)
                        {

                            Program.WindowComp.SetCursor(Program.Window, handle);
                            setCursor = true;
                        }
                    }

                    if (handle == null)
                    {
                        ImGui.EndDisabled();
                    }

                    return hovered;
                }
            }

            // FIXME: Add UI for either drawing an image or loading an image to make a cursor.

            if (OperatingSystem.IsWindows())
            {
                if (ImGui.CollapsingHeader("Win32", ImGuiTreeNodeFlags.DefaultOpen))
                {
                    // FIXME: Add test stuff for win32 specific api.

                    ImGui.InputText("Load cursor file", ref cursorFilePath, 4096);
                    ImGui.SameLine();

                    if (ImGui.Button("Load"))
                    {
                        if (loadedCursor != null)
                        {
                            Program.CursorComp!.Destroy(loadedCursor);
                        }

                        // FIXME: catch exceptions.
                        try
                        {
                            loadedCursor = (Program.CursorComp as Platform.Native.Windows.CursorComponent)!.CreateFromCurFile(cursorFilePath);
                            cursorName = Path.GetFileNameWithoutExtension(cursorFilePath);
                            loadingError = null;
                        }
                        catch (FileNotFoundException e)
                        {
                            loadingError = e.Message;
                        }
                        catch (Exception e)
                        {
                            loadingError = e.Message;
                        }
                    }

                    if (loadedCursor != null)
                    {
                        // Make button more square.
                        ImGui.Button(cursorName);
                        if (ImGui.IsItemHovered())
                        {
                            Program.WindowComp.SetCursor(Program.Window, loadedCursor);
                            setCursor = true;
                        }
                    }
                    else if (loadingError != null)
                    {
                        ImGui.PushStyleColor(ImGuiCol.Text, 0xFF1111FF);
                        ImGui.Text($"Could not load cursor: {loadingError}");
                        ImGui.PopStyleColor();
                    }

                    // FIXME: Add something to test loading from resx and .rc resources too...

                    //CursorHandle cursor = (CursorComp as Platform.Native.Windows.CursorComponent)!.CreateFromCurResorce(Icons.Cute_Light_Green_Normal_Select);
                    //CursorHandle cursor = (CursorComp as Platform.Native.Windows.CursorComponent)!.CreateFromCurResorce("light_green_cursor");
                    //WindowComp.SetCursor(Window, cursor);
                }
            }

            // FIXME: We are resetting back to default, which might not always be the correct cursor...
            // Will ImGui set the mouse cursor change flag correctly?
            if (setCursor == false && hasSetCursor == true)
            {
                Program.WindowComp.SetCursor(Program.Window, SystemCursors[SystemCursorType.Default]);
            }
            hasSetCursor = setCursor;
        }
    }
}

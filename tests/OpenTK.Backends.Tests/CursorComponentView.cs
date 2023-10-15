using ImGuiNET;
using OpenTK.Core.Platform;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
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
        }

        bool hasSetCursor = false;

        string cursorFilePath = Path.Combine(Environment.CurrentDirectory, "Resources");
        CursorHandle? loadedCursor = null;
        string cursorName = "";
        string? loadingError = null;

        public override void Paint()
        {
            base.Paint();

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
                float targetSize = maxTextWidth + 10;
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

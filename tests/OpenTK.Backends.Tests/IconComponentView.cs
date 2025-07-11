using ImGuiNET;
using OpenTK.Platform;
using OpenTK.Mathematics;
using OpenTK.Platform.Native;
using OpenTK.Platform.Native.macOS;
using StbImageSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Backends.Tests
{
    internal class IconComponentView : View
    {
        public override string Title => "Icon";

        public override bool IsVisible => Toolkit.Icon != null;

        private bool canLoadSystemIcons;

        public SortedDictionary<SystemIconType, IconHandle> SystemIcons = new SortedDictionary<SystemIconType, IconHandle>();

        public List<(string Name, IconHandle Icon)> CustomIcons = new List<(string Name, IconHandle Icon)>();

        public override void Initialize()
        {
            base.Initialize();

            try { canLoadSystemIcons = Toolkit.Icon.CanLoadSystemIcons; } catch { canLoadSystemIcons = false; }

            if (canLoadSystemIcons)
            {
                foreach (SystemIconType iconType in Enum.GetValues<SystemIconType>())
                {
                    IconHandle handle = Toolkit.Icon.Create(iconType);
                    SystemIcons.Add(iconType, handle);
                }
            }

            ImageResult logoData = ImageResult.FromMemory(Icons.opentk_logo_small_png, ColorComponents.RedGreenBlueAlpha);
            IconHandle logo = Toolkit.Icon.Create(logoData.Width, logoData.Height, logoData.Data);
            CustomIcons.Add(("OpenTK Logo", logo));

            if (OperatingSystem.IsMacOS())
            {
                IconHandle? icon = (Toolkit.Icon as MacOSIconComponent)!.CreateSFSymbol("fireworks", "An icon containing fireworks.");
                if (icon != null)
                {
                    CustomIcons.Add(("Fireworks", icon));
                }

                icon = (Toolkit.Icon as MacOSIconComponent)!.CreateSFSymbol("paintbrush.fill", "An icon depicting a paintbrush.");
                if (icon != null)
                {
                    CustomIcons.Add(("Paintbrush", icon));
                }
            }
        }

        public override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

            ImGui.SeparatorText("Component Properties");
            // FIXME: Separate display if the property threw an exception?
            ImGuiUtils.ReadonlyCheckbox("Can Load System Icons", canLoadSystemIcons);

            ImGui.SeparatorText("System Icons");

            if (canLoadSystemIcons == false)
            {
                ImGui.BeginDisabled();
            }

            // FIXME: Figure out the button sizing for all buttons at the same time
            // so that they all resize in a similar way.

            // FIXME: Disable all of the buttons if we can't set the window icon.
            {
                float maxTextWidth = float.NegativeInfinity;
                foreach (string name in Enum.GetNames<SystemIconType>())
                {
                    float textWidth = ImGui.CalcTextSize(name).X;
                    if (textWidth > maxTextWidth)
                    {
                        maxTextWidth = textWidth;
                    }
                }

                float columnWidth = ImGui.GetColumnWidth() - ImGui.GetStyle().WindowPadding.X * 2; ;
                // The max text width + some padding.
                float padding = ImGui.GetStyle().FramePadding.X;
                float innerPadding = ImGui.GetStyle().ItemInnerSpacing.X;
                float targetSize = maxTextWidth + (padding + innerPadding) * 2;
                int buttonsPerLine = (int)(columnWidth / targetSize);
                if (buttonsPerLine == 0) buttonsPerLine = 1;
                targetSize = columnWidth / buttonsPerLine;

                // Remove a little size to account for padding
                // FIXME: Get the actual size we need to remove
                targetSize -= innerPadding * 2;

                ImGui.PushStyleVar(ImGuiStyleVar.FrameRounding, 5);
                int i = 0;
                SystemIconType hoverIndex = (SystemIconType)(-1);
                foreach (var (type, handle) in SystemIcons)
                {
                    if (i++ % buttonsPerLine != 0) ImGui.SameLine();

                    if (ImGui.Button(type.ToString(), new System.Numerics.Vector2(targetSize, targetSize)))
                    {
                        Toolkit.Window.SetIcon(Program.Window, handle);

                        // If we are on mac there is no window icon, so set the dock icon instead.
                        (Toolkit.Shell as MacOSShellComponent)?.SetDockIcon(handle);
                    }

                    if (ImGui.IsItemHovered())
                    {
                        hoverIndex = type;
                    }

                    // FIXME: Possibly extract the icon data so we can display them here...
                    /*
                    if (ImGui.ImageButton(type.ToString(), , new System.Numerics.Vector2(targetSize, targetSize)))
                    {
                        Program.WindowComp.SetIcon();
                    }
                    */
                }
                Vector2i size = (0, 0);
                if (hoverIndex != (SystemIconType)(-1))
                {
                    Toolkit.Icon.GetSize(SystemIcons[hoverIndex], out int width, out int height);
                    size = (width, height);

                }
                ImGui.TextUnformatted($"Size: {size}");
                ImGui.PopStyleVar();
            }

            if (canLoadSystemIcons == false)
            {
                ImGui.EndDisabled();
            }

            ImGui.SeparatorText("Custom Icons");

            {
                float maxTextWidth = float.NegativeInfinity;
                foreach (var (name, _) in CustomIcons)
                {
                    float textWidth = ImGui.CalcTextSize(name).X;
                    if (textWidth > maxTextWidth)
                    {
                        maxTextWidth = textWidth;
                    }
                }

                float columnWidth = ImGui.GetColumnWidth() - ImGui.GetStyle().WindowPadding.X * 2; ;
                // The max text width + some padding.
                float padding = ImGui.GetStyle().FramePadding.X;
                float innerPadding = ImGui.GetStyle().ItemInnerSpacing.X;
                float targetSize = maxTextWidth + (padding + innerPadding) * 2;
                int buttonsPerLine = (int)(columnWidth / targetSize);
                if (buttonsPerLine == 0) buttonsPerLine = 1;
                targetSize = columnWidth / buttonsPerLine;

                // Remove a little size to account for padding
                // FIXME: Get the actual size we need to remove
                targetSize -= innerPadding;

                ImGui.PushStyleVar(ImGuiStyleVar.FrameRounding, 5);
                int i = 0;
                int hoverIndex = -1;
                foreach (var (name, handle) in CustomIcons)
                {
                    if (i++ % buttonsPerLine != 0) ImGui.SameLine();

                    if (ImGui.Button(name, new System.Numerics.Vector2(targetSize, targetSize)))
                    {
                        Toolkit.Window.SetIcon(Program.Window, handle);

                        // If we are on mac there is no window icon, so set the dock icon instead.
                        (Toolkit.Shell as MacOSShellComponent)?.SetDockIcon(handle);
                    }

                    if (ImGui.IsItemHovered())
                    {
                        hoverIndex = i - 1;
                    }

                    // FIXME: Possibly extract the icon data so we can display them here...
                    /*
                    if (ImGui.ImageButton(type.ToString(), , new System.Numerics.Vector2(targetSize, targetSize)))
                    {
                        Program.WindowComp.SetIcon();
                    }
                    */
                }

                Vector2i size = (0, 0);
                if (hoverIndex != -1)
                {
                    Toolkit.Icon.GetSize(CustomIcons[hoverIndex].Icon, out int width, out int height);
                    size = (width, height);
                    
                }
                ImGui.TextUnformatted($"Size: {size}");

                ImGui.PopStyleVar();
            }

            // FIXME: Set the icon to the OpenTK logo.
        }
    }
}

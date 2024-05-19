using ImGuiNET;
using OpenTK.Core.Platform;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK.Backends.Tests
{
    internal class ClipboardComponentView : View
    {
        public override string Title => "Clipboard";

        public override bool IsVisible => Program.ClipboardComponent != null;

        ClipboardFormat[] AllFormats = Enum.GetValues<ClipboardFormat>();
        ClipboardFormat[] SupportedFormats;

        int ClipboardGLTexture = 0;

        public override void Initialize()
        {
            base.Initialize();

            try { SupportedFormats = Program.ClipboardComponent!.SupportedFormats.ToArray(); }
            catch { SupportedFormats = Array.Empty<ClipboardFormat>(); }

            UpdateClipboardFormat();
        }

        string clipboardInputText = "";

        ClipboardFormat currentFormat;
        string? clipboardText;
        AudioData? clipboardAudio;
        Bitmap? clipboardBitmap;
        string? clipboardHTML;
        List<string>? clipboardFiles;

        public void UpdateClipboardFormat()
        {
            currentFormat = Program.ClipboardComponent!.GetClipboardFormat();
            switch (currentFormat)
            {
                case ClipboardFormat.None:
                    break;
                case ClipboardFormat.Text:
                    clipboardText = Program.ClipboardComponent!.GetClipboardText();
                    break;
                case ClipboardFormat.Audio:
                    clipboardAudio = Program.ClipboardComponent!.GetClipboardAudio();
                    break;
                case ClipboardFormat.Bitmap:
                    clipboardBitmap = Program.ClipboardComponent!.GetClipboardBitmap();
                    break;
                case ClipboardFormat.HTML:
                    clipboardText = Program.ClipboardComponent!.GetClipboardText();
                    clipboardHTML = Program.ClipboardComponent!.GetClipboardHTML();
                    break;
                case ClipboardFormat.Files:
                    clipboardFiles = Program.ClipboardComponent!.GetClipboardFiles();
                    break;
                default:
                    break;
            }
        }

        public override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

            ImGui.SeparatorText("Supported Formats");
            ImGui.BeginDisabled();
            foreach (var format in AllFormats)
            {
                if (format == ClipboardFormat.None) continue;

                // FIXME: Better display.
                bool @checked = SupportedFormats.Contains(format);
                ImGui.Checkbox($"{format}", ref @checked);

                ImGui.SameLine();
            }
            ImGui.EndDisabled();
            ImGui.NewLine();

            ImGui.SeparatorText("Set clipboard text");

            bool enter = ImGui.InputText("Input Text", ref clipboardInputText, 1024, ImGuiInputTextFlags.EnterReturnsTrue);
            ImGui.SameLine();

            if (ImGui.Button("Set clipboard text") || enter)
            {
                Program.ClipboardComponent!.SetClipboardText(clipboardInputText);
            }

            ImGui.SeparatorText("Clipboard contents");

            // FIXME: Maybe tabs for each type?

            ImGui.Text($"Current format: {currentFormat}");

            switch (currentFormat)
            {
                case ClipboardFormat.None:
                    break;
                case ClipboardFormat.Text:
                    {
                        ImGui.Text($"Clipboard text: '{clipboardText}'");
                        break;
                    }
                case ClipboardFormat.Audio:
                    {
                        // Add waveform plot, and playback?

                        break;
                    }
                case ClipboardFormat.Bitmap:
                    {
                        // Display the bitmap.

                        // FIXME: Maybe cache the bitmap to avoid creating it again and again?
                        Bitmap? bitmap = clipboardBitmap;
                        if (bitmap == null) break;

                        var mipmapLevels = MathF.ILogB(Math.Max(bitmap.Width, bitmap.Height));

                        if (ClipboardGLTexture != 0)
                            GL.DeleteTexture(ClipboardGLTexture);

                        // Because we target 4.1 (for macOS) we can't use the newer texture functions
                        // - Noggin_bops 2024-05-19
                        ClipboardGLTexture = GL.GenTexture();
                        GL.BindTexture(TextureTarget.Texture2d, ClipboardGLTexture);
                        GL.TexImage2D(TextureTarget.Texture2d, 0, InternalFormat.Rgba, bitmap.Width, bitmap.Height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, in bitmap.Data[0]);
                        //GL.TextureStorage2D(ClipboardGLTexture, mipmapLevels, SizedInternalFormat.Rgba8, bitmap.Width, bitmap.Height);
                        //GL.TextureSubImage2D(ClipboardGLTexture, 0, 0, 0, bitmap.Width, bitmap.Height, PixelFormat.Rgba, PixelType.UnsignedByte, in bitmap.Data[0]);

                        var error = GL.GetError();

                        GL.GenerateMipmap(TextureTarget.Texture2d);
                        //GL.GenerateTextureMipmap(ClipboardGLTexture);

                        GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
                        //GL.TextureParameteri(ClipboardGLTexture, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

                        // Maybe try to match the pixel size of the bitmap to the display.

                        var contentSize = ImGui.GetContentRegionAvail();

                        // FIXME: Fix the aspect ratio when the available size is too small.

                        if (bitmap.Width < contentSize.X)
                        {
                            contentSize.X = bitmap.Width;
                        }

                        if (bitmap.Height < contentSize.Y)
                        {
                            contentSize.Y = bitmap.Height;
                        }

                        ImGui.Image(ClipboardGLTexture, contentSize, new System.Numerics.Vector2(0, 1), new System.Numerics.Vector2(1, 0));

                        break;
                    }
                case ClipboardFormat.HTML:
                    {
                        ImGui.Text($"Clipboard text (text): '{clipboardText}'");

                        var contentRegion = ImGui.GetContentRegionAvail();
                        contentRegion.X = ImGui.CalcItemWidth();

                        string html = clipboardHTML ?? "";
                        //ImGui.BeginDisabled();
                        ImGui.InputTextMultiline("Clipboard text (HTML):", ref html, 16_384, contentRegion);
                        //ImGui.EndDisabled();
                        break;
                    }
                case ClipboardFormat.Files:
                    {
                        string[] files = clipboardFiles?.ToArray() ?? Array.Empty<string>();

                        int index = -1;
                        ImGui.ListBox("Files", ref index, files, files.Length);

                        break;
                    }
                default: break;
            }

            if (ImGui.BeginTabBar("platforms"))
            {
                if (Program.ClipboardComponent is Platform.Native.Windows.ClipboardComponent winClipboard)
                {
                    if (ImGui.BeginTabItem("Win32"))
                    {
                        // FIXME: Tri-state checkbox
                        bool canIncludeInClipboardHistory = winClipboard.CanIncludeInClipboardHistory ?? false;
                        if (ImGui.Checkbox("Can include in clipboard history", ref canIncludeInClipboardHistory))
                            winClipboard.CanIncludeInClipboardHistory = canIncludeInClipboardHistory;

                        // FIXME: Tri-state checkbox
                        bool canUploadToCloudClipboard = winClipboard.CanUploadToCloudClipboard ?? false;
                        if (ImGui.Checkbox("Can upload to cloud clipboard", ref canUploadToCloudClipboard))
                            winClipboard.CanUploadToCloudClipboard = canUploadToCloudClipboard;

                        // FIXME: Add something for
                        // winClipboard.SetClipboardAudio and
                        // winClipboard.SetClipboardBitmap

                        ImGui.EndTabItem();
                    }
                }

                ImGui.EndTabBar();
            }
        }
    }
}

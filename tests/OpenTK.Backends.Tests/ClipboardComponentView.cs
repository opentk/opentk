using ImGuiNET;
using OpenTK.Platform;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenTK.Backends.Tests
{
    internal class ClipboardComponentView : View
    {
        public override string Title => "Clipboard";

        public override bool IsVisible => Toolkit.Clipboard != null;

        ClipboardFormat[] AllFormats = Enum.GetValues<ClipboardFormat>();
        ClipboardFormat[] SupportedFormats;

        int ClipboardGLTexture = 0;

        public override void Initialize()
        {
            base.Initialize();

            try { SupportedFormats = Toolkit.Clipboard.SupportedFormats.ToArray(); }
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

        public Bitmap CreateExampleBitmap()
        {
            const int W = 600;
            const int H = 600;
            byte[] b = new byte[W * H * 4];
            for (int xi = 0; xi < W; xi++)
            {
                for (int yi = 0; yi < H; yi++)
                {
                    int index = (yi * W + xi) * 4;

                    static byte ftob(float f) => (byte)(f * 255);

                    float x0 = MathHelper.MapRange(xi, 0f, W, -2f, 0.47f);
                    float y0 = MathHelper.MapRange(yi, 0f, H, -1.12f, 1.12f);

                    float x = 0;
                    float y = 0;
                    const int maxIterations = 1000;
                    int iteration = 0;
                    while (x * x + y * y < 2 * 2 && iteration < maxIterations)
                    {
                        iteration++;

                        float xTemp = x * x - y * y + x0;
                        y = 2 * x * y + y0;
                        x = xTemp;
                    }

                    // See https://stackoverflow.com/a/22681410/9316430
                    static void SpectralColor(float l, out float r, out float g, out float b) // RGB <0,1> <- lambda l <400,700> [nm]
                    {
                        float t; r = 0.0f; g = 0.0f; b = 0.0f;
                        if ((l >= 400.0) && (l < 410.0)) { t = (l - 400.0f) / (410.0f - 400.0f); r = +(0.33f * t) - (0.20f * t * t); }
                        else if ((l >= 410.0) && (l < 475.0)) { t = (l - 410.0f) / (475.0f - 410.0f); r = 0.14f - (0.13f * t * t); }
                        else if ((l >= 545.0) && (l < 595.0)) { t = (l - 545.0f) / (595.0f - 545.0f); r = +(1.98f * t) - (t * t); }
                        else if ((l >= 595.0) && (l < 650.0)) { t = (l - 595.0f) / (650.0f - 595.0f); r = 0.98f + (0.06f * t) - (0.40f * t * t); }
                        else if ((l >= 650.0) && (l < 700.0)) { t = (l - 650.0f) / (700.0f - 650.0f); r = 0.65f - (0.84f * t) + (0.20f * t * t); }
                        if ((l >= 415.0) && (l < 475.0)) { t = (l - 415.0f) / (475.0f - 415.0f); g = +(0.80f * t * t); }
                        else if ((l >= 475.0) && (l < 590.0)) { t = (l - 475.0f) / (590.0f - 475.0f); g = 0.8f + (0.76f * t) - (0.80f * t * t); }
                        else if ((l >= 585.0) && (l < 639.0)) { t = (l - 585.0f) / (639.0f - 585.0f); g = 0.84f - (0.84f * t); }
                        if ((l >= 400.0) && (l < 475.0)) { t = (l - 400.0f) / (475.0f - 400.0f); b = +(2.20f * t) - (1.50f * t * t); }
                        else if ((l >= 475.0) && (l < 560.0)) { t = (l - 475.0f) / (560.0f - 475.0f); b = 0.7f - (t) + (0.30f * t * t); }
                    }

                    float l = MathHelper.MapRange(iteration, 0, maxIterations, 400.0f, 700.0f);
                    SpectralColor(l, out float red, out float green, out float blue);

                    b[index + 0] = ftob(red);
                    b[index + 1] = ftob(green);
                    b[index + 2] = ftob(blue);
                    b[index + 3] = 255;
                }
            }

            Bitmap bitmap = new Bitmap(W, H, b);
            return bitmap;
        }

        public void UpdateClipboardFormat()
        {
            currentFormat = Toolkit.Clipboard.GetClipboardFormat();
            switch (currentFormat)
            {
                case ClipboardFormat.None:
                    break;
                case ClipboardFormat.Text:
                    clipboardText = Toolkit.Clipboard.GetClipboardText();
                    break;
                case ClipboardFormat.Audio:
                    clipboardAudio = Toolkit.Clipboard.GetClipboardAudio();
                    break;
                case ClipboardFormat.Bitmap:
                    clipboardBitmap = Toolkit.Clipboard.GetClipboardBitmap();
                    break;
                case ClipboardFormat.Files:
                    clipboardFiles = Toolkit.Clipboard.GetClipboardFiles();
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
                Toolkit.Clipboard.SetClipboardText(clipboardInputText);
            }

            if (ImGui.Button("Set clipboard image"))
            {
                Toolkit.Clipboard.SetClipboardBitmap(CreateExampleBitmap());
            }

            ImGui.SeparatorText("Clipboard contents");

            // FIXME: Maybe tabs for each type?

            ImGui.AlignTextToFramePadding();
            ImGui.Text($"Current format: {currentFormat}");
            ImGui.SameLine();
            if (ImGui.Button("Refresh"))
            {
                UpdateClipboardFormat();
            }

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
                // FIXME: Show the other platforms as diable tabs?
                if (Toolkit.Clipboard is Platform.Native.Windows.ClipboardComponent winClipboard)
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
                        // winClipboard.SetClipboardAudio

                        ImGui.EndTabItem();
                    }
                }
                else if (Toolkit.Clipboard is Platform.Native.macOS.MacOSClipboardComponent macOSClipboard)
                {
                    if (ImGui.BeginTabItem("macOS"))
                    {
                        ImGui.EndTabItem();
                    }
                }
                else if (Toolkit.Clipboard is Platform.Native.X11.X11ClipboardComponent x11Clipboard)
                {
                    if (ImGui.BeginTabItem("X11"))
                    {
                        ImGui.EndTabItem();
                    }
                }

                ImGui.EndTabBar();
            }
        }
    }
}

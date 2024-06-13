using ImGuiNET;
using OpenTK.Graphics.OpenGL;
using OpenTK.Core.Platform;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Diagnostics;
using OpenTK.Platform.Native;

namespace OpenTK.Backends.Tests
{
    public class OpenGLComponentView : View
    {
        /// <inheritdoc/>
        public override string Title => "OpenGL";

        /// <inheritdoc/>
        public override bool IsVisible => Toolkit.OpenGL != null;  // Yes it won't fail, for now :)

        private bool canCreateFromWindow;
        private bool canCreateFromSurface;
        private bool canCanShareContexts;

        private string glVersion = "";
        private string glslVersion = "";
        private string vendorString = "";
        private string renderer = "";

        private string extensionHeader = "##opengl_view_extensions_header";

        private int numExtensions = 0;
        private List<(string Vendor, List<string> Extensions)> extensionGroups = new List<(string, List<string>)>();

        private int selectedWindow = -1;

        // FIXME: Linq
        private string[] testAppNames = TestApps.All.Select(app => app.Name).ToArray();

        private int lastActiveApp = 0;

        private string savePath = Path.Combine(Environment.CurrentDirectory, "opengl.ini");

        private readonly Regex vendorRegex = new Regex("GL_([0-9a-zA-Z]+)", RegexOptions.CultureInvariant | RegexOptions.Compiled);

        public override void Initialize()
        {
            try { canCreateFromWindow =  Toolkit.OpenGL.CanCreateFromWindow; }  catch { canCreateFromWindow = false; }
            try { canCreateFromSurface = Toolkit.OpenGL.CanCreateFromSurface; } catch { canCreateFromSurface = false; }
            try { canCanShareContexts =  Toolkit.OpenGL.CanShareContexts; }     catch { canCanShareContexts = false; }

            glVersion = GL.GetString(StringName.Version) ?? "";
            glslVersion = GL.GetString(StringName.ShadingLanguageVersion) ?? "";
            vendorString = GL.GetString(StringName.Vendor) ?? "";
            renderer = GL.GetString(StringName.Renderer) ?? "";

            Dictionary<string, List<string>> extensions = new Dictionary<string, List<string>>();
            numExtensions = GL.GetInteger(GetPName.NumExtensions);
            extensionHeader = $"Extensions ({numExtensions})" + extensionHeader;

            for(int i = 0; i < numExtensions; i++)
            {
                // FIXME: odd c# binding?
                string? extension = GL.GetStringi(StringName.Extensions, (uint)i);

                // Doubt this will ever hit.
                if (extension is null) continue;

                Match match = vendorRegex.Match(extension);
                string vendor = match.Success && match.Groups.Count > 1 ? match.Groups[1].Value : "Unknown Vendor";

                if (!extensions.TryGetValue(vendor, out List<string>? list))
                {
                    list = new List<string>();
                    extensions[vendor] = list;
                }

                list.Add(extension);
            }

            foreach (var(key, value) in extensions)
            {
                extensionGroups.Add((key, value));
            }
            extensionGroups.Sort((a, b) => StringComparer.InvariantCulture.Compare(a.Vendor, b.Vendor));
        }

        public override void Paint(double deltaTime)
        {
            base.Paint(deltaTime);

            ImGui.SeparatorText("Component Properties");
            // FIXME: Separate display if the property threw an exception?
            ImGuiUtils.ReadonlyCheckbox("Can Create From Window", canCreateFromWindow);
            ImGuiUtils.ReadonlyCheckbox("Can Create From Surface ", canCreateFromSurface);
            ImGuiUtils.ReadonlyCheckbox("Can Share Context", canCanShareContexts);

            ImGui.SeparatorText("Contexts");

            if (selectedWindow >= Program.ApplicationWindows.Count)
            {
                if (Program.ApplicationWindows.Count == 0)
                {
                    selectedWindow = -1;
                }
                else
                {
                    selectedWindow = 0;
                }
            }

            if (selectedWindow == -1 && Program.ApplicationWindows.Count > 0)
            {
                selectedWindow = 0;
            }

            if (Program.ApplicationWindows.Count == 0)
            {
                ImGui.BeginDisabled();
                if (ImGui.BeginCombo("Child Window", "No child windows"))
                {
                    ImGui.EndCombo();
                }
                ImGui.EndDisabled();
            }
            else
            {
                string windowTitle;
                if (selectedWindow == -1)
                {
                    windowTitle = "no window selected";
                }
                else
                {
                    var appWindow = Program.ApplicationWindows[selectedWindow];
                    string title = Toolkit.Window.GetTitle(appWindow.Window);
                    windowTitle = $"{title} ({(appWindow.Context == null ? "no context" : "opengl")})";
                }
                
                if (ImGui.BeginCombo("Child Window", windowTitle))
                {
                    for (int i = 0; i < Program.ApplicationWindows.Count; i++)
                    {
                        var appWindow = Program.ApplicationWindows[i];
                        string title = Toolkit.Window.GetTitle(appWindow.Window);
                        string label = $"{title} ({(appWindow.Context == null ? "no context" : "opengl")})";

                        if (ImGui.Selectable(label))
                        {
                            selectedWindow = i;
                        }
                    }
                    ImGui.EndCombo();
                }
            }

            ImGui.SameLine();
            if (selectedWindow == -1)
            {
                ImGui.BeginDisabled();
                ImGui.Button("Create");
                ImGui.EndDisabled();
            }
            else
            {
                var appWindow = Program.ApplicationWindows[selectedWindow];

                if (appWindow.Context == null)
                {
                    if (ImGui.Button("Create"))
                    {
                        OpenGLContextHandle newContext = Toolkit.OpenGL.CreateFromWindow(appWindow.Window);
                        appWindow.Context = newContext;

                        if (appWindow.Application != null)
                        {
                            // FIXME: Make it only a single place where we actually initialize test apps.
                            Toolkit.OpenGL.SetCurrentContext(appWindow.Context);
                            appWindow.Application.Initialize(appWindow.Window, appWindow.Context, Program.UsingGLES);
                            Toolkit.OpenGL.SetCurrentContext(Program.WindowContext);
                        }
                    }
                }
                else
                {
                    if (ImGui.Button("Destroy"))
                    {
                        OpenGLContextHandle context = appWindow.Context;
                        if (appWindow.Application != null)
                        {
                            Toolkit.OpenGL.SetCurrentContext(appWindow.Context);
                            appWindow.Application.Deinitialize();
                            Toolkit.OpenGL.SetCurrentContext(Program.WindowContext);
                        }
                        appWindow.Context = null;
                        Toolkit.OpenGL.DestroyContext(context);
                    }
                }
            }

            ImGui.Combo("Application", ref lastActiveApp, testAppNames, testAppNames.Length);
            ImGui.SameLine();

            ImGui.BeginDisabled(
                selectedWindow == -1 ||
                Program.ApplicationWindows[selectedWindow].Application?.GetType() == TestApps.All[lastActiveApp]);

            if (ImGui.Button("Launch") && selectedWindow != -1)
            {
                var appWindow = Program.ApplicationWindows[selectedWindow];
                appWindow.Application = TestApps.Create(lastActiveApp);
                if (appWindow.Context != null)
                {
                    Toolkit.OpenGL.SetCurrentContext(appWindow.Context);
                    appWindow.Application.Initialize(appWindow.Window, appWindow.Context, Program.UsingGLES);
                    Toolkit.OpenGL.SetCurrentContext(Program.WindowContext);
                }
            }

            ImGui.EndDisabled();

            ImGui.SeparatorText("Main Context Information");
            ImGuiUtils.ReadonlyText("OpenGL Version", glVersion);
            ImGuiUtils.ReadonlyText("GLSL Version", glslVersion);
            ImGuiUtils.ReadonlyText("OpenGL Vendor", vendorString);
            ImGuiUtils.ReadonlyText("OpenGL Renderer", renderer);

            ImGui.SeparatorText(extensionHeader);
            ImGui.InputText(string.Empty, ref savePath, 4096); ImGui.SameLine();
            if (ImGui.Button("Save"))
            {
                SaveOpenGLDetails(savePath);
            }

            if (ImGui.BeginChild("opengl_view_extensions_child_frame", Vector2.Zero, ImGuiChildFlags.Border, ImGuiWindowFlags.AlwaysVerticalScrollbar))
            {
                const ImGuiTreeNodeFlags VENDOR_FLAGS = ImGuiTreeNodeFlags.OpenOnArrow;
                const ImGuiTreeNodeFlags EXTENSION_FLAGS = ImGuiTreeNodeFlags.Leaf | ImGuiTreeNodeFlags.Bullet;

                foreach (var(vendor, extensions) in extensionGroups)
                {
                    if(!ImGui.TreeNodeEx(vendor, VENDOR_FLAGS))
                        continue;

                    foreach (string extension in extensions)
                    {
                        if (ImGui.TreeNodeEx(extension, EXTENSION_FLAGS))
                        {
                            if (ImGui.IsItemClicked(ImGuiMouseButton.Left) && ImGui.IsMouseDoubleClicked(ImGuiMouseButton.Left))
                            {
                                string ext = extension;
                                if (ext.StartsWith("GL_"))
                                    ext = ext["GL_".Length..];

                                string url;
                                if (vendor == "ANGLE" || vendor == "CHROMIUM")
                                {
                                    url = $"https://chromium.googlesource.com/angle/angle/+/refs/heads/main/extensions/{ext}.txt";
                                }
                                else
                                {
                                    url = $"https://registry.khronos.org/OpenGL/extensions/{vendor}/{ext}.txt";
                                }

                                var info = new ProcessStartInfo(url);
                                info.UseShellExecute = true;
                                Process.Start(info);
                            }

                            ImGui.TreePop();
                        }
                    }

                    ImGui.TreePop();
                }
                ImGui.EndChild();
            }
        }

        private void SaveOpenGLDetails(string path)
        {
            try
            {
                using StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.Create));

                writer.WriteLine("# OpenTK PAL2 OpenGL Information Dump");

                writer.WriteLine("[Context]");
                writer.WriteLine("GL_VERSION={0}", glVersion);
                writer.WriteLine("GL_SHADING_LANGUAGE_VERSION={0}", glslVersion);
                writer.WriteLine("GL_VENDOR={0}", vendorString);
                writer.WriteLine("GL_RENDERER={0}", renderer);
                writer.WriteLine();

                writer.WriteLine("[Extensions]");
                writer.WriteLine("GL_NUM_EXTENSIONS={0}", numExtensions);
                foreach (var(vendor, list) in extensionGroups)
                {
                    writer.WriteLine("{0}={1}", vendor, list.Count);
                }
                writer.WriteLine();

                foreach (var(vendor, list) in extensionGroups)
                {
                    writer.WriteLine("[Extensions/{0}]", vendor);

                    foreach (string extension in list)
                    {
                        writer.WriteLine("{0}=1", extension);
                    }

                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Program.Logger.LogError($"Could not write OpenGL info log to \"{path}\": {ex}\n{ex.StackTrace}");
            }
        }
    }
}

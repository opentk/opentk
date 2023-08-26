using ImGuiNET;
using OpenTK.Graphics.OpenGL;
using OpenTK.Core.Platform;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace OpenTK.Backends.Tests
{
    public class OpenGLComponentView : View
    {
        public override string Title => "OpenGL";
        public override bool IsVisible => Program.OpenGLComp != null;  // Yes it won't fail, for now :)

        private bool canCreateFromWindow;
        private bool canCreateFromSurface;
        private bool canCanShareContexts;
        private string glVersion = string.Empty;
        private string glslVersion = string.Empty;
        private string vendorString = string.Empty;
        private string renderer = string.Empty;
        private int numExtensions = 0;
        private string extensionHeader = "##opengl_view_extensions_header";
        private List<(string vendor, List<string> extensions)> extensionGroups = new List<(string, List<string>)>();
        private int lastActiveWindowIndex = -1;
        private string lastActiveWindowLabel = string.Empty;
        private string[] testApps = TestApps.ByName.Keys.ToArray();
        private int lastActiveApp = 0;
        private string savePath = Path.Combine(Environment.CurrentDirectory, "opengl.ini");

        private readonly Regex vendorRegex = new Regex("GL_([0-9a-zA-Z]+)", RegexOptions.CultureInvariant | RegexOptions.Compiled);

        public override void Initialize()
        {
            try { canCreateFromWindow = Program.OpenGLComp.CanCreateFromWindow; }
            catch { canCreateFromWindow = false;}
            try { canCreateFromSurface = Program.OpenGLComp.CanCreateFromSurface; }
            catch { canCreateFromSurface = false; }
            try { canCanShareContexts = Program.OpenGLComp.CanShareContexts; }
            catch { canCanShareContexts = false; }

            glVersion = GL.GetString(StringName.Version) ?? string.Empty;
            glslVersion = GL.GetString(StringName.ShadingLanguageVersion) ?? string.Empty;
            vendorString = GL.GetString(StringName.Vendor) ?? string.Empty;
            renderer = GL.GetString(StringName.Renderer) ?? string.Empty;

            Dictionary<string, List<string>> extensions = new Dictionary<string, List<string>>();
            numExtensions = GL.GetInteger(GetPName.NumExtensions);
            extensionHeader = $"Extensions ({numExtensions})" + extensionHeader;

            for(int i = 0; i < numExtensions; i++)
            {
                // FIXME: odd c# binding???
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
            extensionGroups.Sort((a, b) => StringComparer.InvariantCulture.Compare(a.vendor, b.vendor));
        }

        public override void Paint()
        {
            bool dummyBoolean;
            string dummyString;

            ImGui.SeparatorText("Component Properties");
            dummyBoolean = canCreateFromWindow;
            ImGui.Checkbox("Can Create From Window", ref dummyBoolean);
            dummyBoolean = canCreateFromSurface;
            ImGui.Checkbox("Can Create From Surface", ref dummyBoolean);
            dummyBoolean = canCanShareContexts;
            ImGui.Checkbox("Can Share Context", ref dummyBoolean);

            ImGui.SeparatorText("Contexts");

            if (
                lastActiveWindowIndex >= Program.WindowManager.Count ||
                Program.WindowManager.Count == 0)
            {
                lastActiveWindowIndex = -1;
                lastActiveWindowLabel = "???";
            }

            if (lastActiveWindowIndex == -1 && Program.WindowManager.Count != 0)
            {
                lastActiveWindowIndex = 0;
                var data = Program.WindowManager[0];
                string title = Program.WindowComp.GetTitle(data.Window);
                lastActiveWindowLabel = $"{title} ({(data.Context == null ? "no context" : "opengl")})";
            }

            if (lastActiveWindowIndex == -1)
            {
                ImGui.BeginDisabled();
                if (ImGui.BeginCombo("Child Window", "No child windows"))
                    ImGui.EndCombo();
                ImGui.EndDisabled();

                lastActiveWindowIndex = -1;
                lastActiveWindowLabel = "???";
            }
            else if (ImGui.BeginCombo("Child Window", lastActiveWindowLabel))
            {
                for (int i = 0; i < Program.WindowManager.Count; i++)
                {
                    var data = Program.WindowManager[i];
                    string title = Program.WindowComp.GetTitle(data.Window);
                    string label = $"{title} ({(data.Context == null ? "no context" : "opengl")})";

                    if (ImGui.Selectable(label))
                    {
                        lastActiveWindowIndex = i;
                        lastActiveWindowLabel = label;
                    }
                }
                ImGui.EndCombo();
            }

            ImGui.SameLine();
            if (lastActiveWindowIndex == -1)
            {
                ImGui.BeginDisabled();
                    ImGui.Button("Create");
                ImGui.EndDisabled();
            }
            else
            {
                var data = Program.WindowManager[lastActiveWindowIndex];

                if (data.Context == null)
                {
                    if (ImGui.Button("Create"))
                    {
                        OpenGLContextHandle newContext = Program.OpenGLComp.CreateFromWindow(data.Window);
                        data.Context = newContext;
                    }
                }
                else
                {
                    if (ImGui.Button("Destroy"))
                    {
                        OpenGLContextHandle context = data.Context;
                        data.Context = null;
                        Program.OpenGLComp.DestroyContext(context);
                    }
                }
            }

            ImGui.Combo("Application", ref lastActiveApp, testApps, testApps.Length);
            ImGui.SameLine();

            ImGui.BeginDisabled(
                lastActiveWindowIndex == -1 ||
                Program.WindowManager[lastActiveWindowIndex].Application?.GetType() == TestApps.All[lastActiveApp]
            );
            if (ImGui.Button("Launch") && lastActiveWindowIndex != -1)
            {
                Program.WindowManager[lastActiveWindowIndex].Application = TestApps.Create(lastActiveApp);
            }
            ImGui.EndDisabled();

            ImGui.SeparatorText("Main Context Information");
            ImGui.BeginDisabled();
                dummyString = glVersion;
                ImGui.InputText("OpenGL Version", ref dummyString, 1024);
                dummyString = glslVersion;
                ImGui.InputText("GLSL Version", ref dummyString, 1024);
                dummyString = vendorString;
                ImGui.InputText("OpenGL Vendor", ref dummyString, 1024);
                dummyString = renderer;
                ImGui.InputText("OpenGL Renderer", ref dummyString, 1024);
            ImGui.EndDisabled();

            ImGui.SeparatorText(extensionHeader);
            ImGui.InputText(string.Empty, ref savePath, 4096); ImGui.SameLine();
            if (ImGui.Button("Save"))
            {
                SaveOpenGLDetails(savePath);
            }

            if (ImGui.BeginChild("opengl_view_extensions_child_frame", Vector2.Zero, true, ImGuiWindowFlags.AlwaysVerticalScrollbar))
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
                            ImGui.TreePop();
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
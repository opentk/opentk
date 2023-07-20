using ImGuiNET;
using System;
using System.Linq;
using System.Text;
using OpenTK.Graphics.OpenGL;
using OpenTK.Core.Platform;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using OpenTK.Platform.Native.X11;
using System.Numerics;

namespace OpenTK.Backends.Tests
{
    public class OpenGLComponentView : View
    {
        public override string Title => "OpenGL";
        public override bool IsVisible => Program.OpenGLComp != null;  // Yes it won't fail, for now :)

        private bool isInit = false;
        private bool canCreateFromWindow;
        private bool canCreateFromSurface;
        private bool canCanShareContexts;
        private string glVersion = string.Empty;
        private string glslVersion = string.Empty;
        private string vendorString = string.Empty;
        private string renderer = string.Empty;
        private List<(string vendor, List<string> extensions)> extensionGroups = new List<(string, List<string>)>();

        private readonly Regex vendorRegex = new Regex("GL_([0-9a-zA-Z]+)", RegexOptions.CultureInvariant | RegexOptions.Compiled);

        public override void NotifyEnter()
        {
            if (isInit) return;

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
            int numExtensions = GL.GetInteger(GetPName.NumExtensions);

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

            isInit = true;
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

            ImGui.SeparatorText("Active Context Information");
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

            ImGui.SeparatorText("Extensions");
            ImGui.BeginChild("opengl_view_extensions_child_frame", Vector2.Zero, true, ImGuiWindowFlags.AlwaysVerticalScrollbar);

            const ImGuiTreeNodeFlags VENDOR_FLAGS = ImGuiTreeNodeFlags.OpenOnArrow | ImGuiTreeNodeFlags.OpenOnDoubleClick;
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
        }
    }
}
using GeneratorV2.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;

namespace GeneratorV2.Writing
{
    public class FeatureNode : Node
    {
        private readonly string _path;
        private readonly Feature _feature;

        public FeatureNode(string path, string subNamespace, Feature feature) : base(new List<Node>())
        {
            _feature = feature;

            _path = Path.Combine(path, "versions", "V" + _feature.Version.Major.ToString() + _feature.Version.Minor.ToString());

            subNamespace = $"{subNamespace}.V{feature.Version.Major}{feature.Version.Minor}";
            var methodClass = AddNode(new FileNode(Path.Combine(_path, $"GL.Methods.cs")))
                                .AddNode(new NamespaceNode(subNamespace))
                                    .AddNode(new ClassNode("GL"));

            var overloadClass = AddNode(new FileNode(Path.Combine(_path, $"GL.Overloads.cs")))
                    .AddNode(new NamespaceNode(subNamespace))
                        .AddNode(new ClassNode("GL"));

            /*
            foreach (var (name, command) in feature.Commands)
            {
                methodClass.AddNode(new MethodNode(command));
                overloadClass.AddNode(new OverloadNode(command));
            }

            var enumNamespace = AddNode(new FileNode(Path.Combine(_path, $"Enums.cs")))
                .AddNode(new NamespaceNode(subNamespace));
            foreach(var (groupName, group) in feature.EnumGroups)
            {
                enumNamespace.AddNode(new EnumNode(groupName, group));
            }
            */
        }

        public override void Write()
        {
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
            WriteChildren();
        }
    }
}

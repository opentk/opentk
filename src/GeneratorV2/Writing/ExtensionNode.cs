using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.IO;

namespace GeneratorV2.Writing
{
    /*
    class ExtensionNode : Node
    {
        private readonly string _path;
        private readonly ApiExtension _extension;

        public ExtensionNode(string path, string subNamespace, ApiExtension extension) : base(new List<Node>())
        {
            _extension = extension;

            _path = Path.Combine(path, "Extensions");

            subNamespace = subNamespace + ".Extensions";

            foreach (var (vendor, extensions) in extension)
            {
                var methodClass = AddNode(new FileNode(Path.Combine(_path, vendor, $"Methods.cs")))
                    .AddNode(new NamespaceNode(subNamespace))
                        .AddNode(new ClassNode(vendor));

                var overloadClass = AddNode(new FileNode(Path.Combine(_path, vendor, $"Overloads.cs")))
                        .AddNode(new NamespaceNode(subNamespace))
                            .AddNode(new ClassNode(vendor));

                foreach(var e in extensions)
                {
                    var methodExtensionClass = methodClass.AddNode(new ClassNode(e.Name));
                    var overloadExtensionClass = overloadClass.AddNode(new ClassNode(e.Name));
                    /*
                    foreach(var (cName, c) in e.Commands)
                    {
                        methodExtensionClass.AddNode(new MethodNode(c));
                        overloadExtensionClass.AddNode(new OverloadNode(c));
                    }
                    /
                }
            }
        }

        public override void Write()
        {
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }

            foreach (var (name, e) in _extension)
            {
                var path = Path.Combine(_path, name);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }

            WriteChildren();
        }
    }*/
}

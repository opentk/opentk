using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace GeneratorV2.Writing
{
    public class ApiNode : Node
    {
        private readonly Api _api;
        private readonly string _path;

        public ApiNode(string path, string namespaceName, Api api) : base(new List<Node>())
        {
            /*
            _api = api;
            _path = Path.Combine(path, _api.Name);

            var subNamespace = $"{namespaceName}.Open{api.Name}";

            AddNode(new ExtensionNode(_path, subNamespace, api.Extensions));

            foreach(var f in api.Features)
            {
                AddNode(new FeatureNode(_path, subNamespace, f));
            }

            var allEnum = _api.AllEnum.Where(x => x.Value.Value <= uint.MaxValue).Select(x => x.Value).ToHashSet();
            var apiNamespace = AddNode(new FileNode(Path.Combine(_path, "All.cs")))
                .AddNode(new NamespaceNode(subNamespace))
                    .AddNode(new EnumNode("All", allEnum));
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

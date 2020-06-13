using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeneratorV2.Writing
{
    class ExtensionWriter : ISubWriter<string, Api>
    {
        public void Write(string namespaceName, string output, Api input)
        {

            foreach (var extension in input.Extensions)
            {
                output = Path.Combine(output, "versions", "V" + extension.Version.Major.ToString() + extension.Version.Minor.ToString());
                if (!Directory.Exists(output))
                {
                    Directory.CreateDirectory(output);
                }

                var subNamespace = $"{namespaceName}.Open{extension.Api.ToUpper()}.V{extension.Version.Major}{extension.Version.Minor}";

                new MethodWriter().Write(subNamespace, Path.Combine(output, $"GL.Methods.cs"), extension);

                new EnumWriter().Write(subNamespace, Path.Combine(output, $"Enums.cs"), extension);

                new OverloadWriter().Write(subNamespace, Path.Combine(output, $"GL.Overloads.cs"), extension);
            }

            foreach (var (vendor, extension) in api.Extensions)
            {
                WriteExtensions(output, api.Name, vendor, extension);
            }
        }
        public static void WriteExtensions(string folderPath, string api, string vendor, List<Extension> extensions)
        {
            folderPath = Path.Combine(folderPath, "Extensions", vendor);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            WriteExtensionBaseDocument(Path.Combine(folderPath, $"Methods.cs"), api, vendor, extensions,
                    (writer, ext) => {
                        foreach (var (cName, c) in ext.Commands)
                        {
                            WriteCommand(writer, c);
                        }
                    });
            WriteExtensionBaseDocument(Path.Combine(folderPath, $"Overloads.cs"), api, vendor, extensions,
                    (writer, ext) => {
                        foreach (var (cName, c) in ext.Commands)
                        {
                            foreach (var o in c.Overloads)
                            {
                                WriteOverload(writer, o, c.Name);
                            }
                        }
                    });
            WriteExtensionBaseDocument(Path.Combine(folderPath, $"Enums.cs"), api, vendor, extensions,
                    (writer, ext) => {
                        if (ext.EnumEntries.Count != 0)
                        {
                            WriteEnumGroups(writer, ext.EnumGroups);
                        }
                    });
        }
    }
}

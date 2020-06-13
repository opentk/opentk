using GeneratorV2.Data;
using GeneratorV2.Parsing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeneratorV2.Writing
{
    public class FeatureWriter : ISubWriter<Api, string>
    {
        public void Write(Api input, string output)
        {
            foreach (var feature in input.Features)
            {
                output = Path.Combine(output, "versions", "V" + feature.Version.Major.ToString() + feature.Version.Minor.ToString());
                if (!Directory.Exists(output))
                {
                    Directory.CreateDirectory(output);
                }

                var subNamespace = $"{namespaceName}.Open{feature.Api.ToUpper()}.V{feature.Version.Major}{feature.Version.Minor}";
                
                new MethodWriter().Write(subNamespace, Path.Combine(output, $"GL.Methods.cs"), feature);

                new EnumWriter().Write(subNamespace, Path.Combine(output, $"Enums.cs"), feature);

                new OverloadWriter().Write(subNamespace, Path.Combine(output, $"GL.Overloads.cs"), feature);
            }
        }

        private static void WriteEnumFile(string outputPath, ISingleWriter<Enum> writer)
        {

        }

        private static void WriteFile(string outputPath, ISingleWriter<Command> singleWriter)
        {
            using var stream = new FileStream(outputPath, FileMode.Create);
            using var streamWriter = new StreamWriter(stream);
            using var writer = new IndentedTextWriter(streamWriter);

            WriterUtility.WriteUsings(writer);

            writer.WriteLine("namespace " + namespaceName);

            using (writer.Scope())
            {
                singleWriter.Write(writer);
            }
        }
    }
}

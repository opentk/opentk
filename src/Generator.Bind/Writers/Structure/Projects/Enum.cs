using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Bind.Writers.Structure.Projects
{
    internal class Enum
    {
        public List<Token> Tokens { get; set; } = new List<Token>();
        public string Name { get; set; }
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();

        public async Task WriteAsync(string file, Subsystem subsystem, Project project)
        {
            if (File.Exists(file))
            {
                return;
            }
            
            var sw = new StreamWriter(file);
            await sw.WriteLineAsync(EmbeddedResources.LicenseText);
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("using System;");
            await sw.WriteLineAsync();
            await sw.WriteLineAsync("namespace "+project.Namespace+".Enums");
            await sw.WriteLineAsync("{");
            foreach (var attr in Attributes)
            {
                await sw.WriteAsync("["+attr.Name+"(");
                var max = attr.Arguments.Count;
                for (var i = 0; i < max; i++)
                {
                    await sw.WriteAsync(attr.Arguments[i]);
                    if (i != max)
                    {
                        await sw.WriteAsync(", ");
                    }
                }

                await sw.WriteLineAsync(")]");
            }
            await sw.WriteLineAsync("    public enum "+Name);
            await sw.WriteLineAsync("    {");
            for (var index = 0; index < Tokens.Count; index++)
            {
                var token = Tokens[index];
                
                await sw.WriteLineAsync("        " + token.Name + " = " + token.Value+(index == Tokens.Count ? "," : ""));
            }

            await sw.WriteLineAsync("    }");
            await sw.WriteLineAsync("}");
            await sw.FlushAsync();
            sw.Dispose();
        }
    }
}
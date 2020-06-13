using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeneratorV2.Writing
{
    public class EnumWriter : ISubWriter<string, CommandEnumCollection>
    {
        public void Write(string namespaceName, string output, CommandEnumCollection input)
        {
            using var stream = new FileStream(output, FileMode.Create);
            using var streamWriter = new StreamWriter(stream);
            using var writer = new IndentedTextWriter(streamWriter);

            writer.WriteLine("namespace " + namespaceName);
            using (writer.Scope())
            {
                foreach (var (groupName, group) in input.EnumGroups)
                {
                    if (groupName == "SpecialNumbers")
                    {
                        WriteEnumClass(writer, groupName, group);
                    }
                    else
                    {
                        WriteEnumGroup(writer, groupName, group);
                    }
                }
            }
        }

        private static void WriteEnumClass(IndentedTextWriter writer, string groupName, HashSet<EnumEntry> group)
        {
            writer.WriteLine($"public static class {groupName}");
            using (writer.Scope())
            {
                var groupEnumerator = group.GetEnumerator();
                var hasNext = groupEnumerator.MoveNext();
                do
                {
                    var curEntry = groupEnumerator.Current;
                    hasNext = groupEnumerator.MoveNext();
                    var type = curEntry.Value > uint.MaxValue ? "ulong" : "uint";
                    writer.WriteLine($"public const {type} {curEntry.MangledName} = 0x{curEntry.Value:X};");
                } while (hasNext);
            }
        }

        private static void WriteEnumGroup(IndentedTextWriter writer, string groupName, HashSet<EnumEntry> group)
        {
            writer.WriteLine($"public enum {groupName} : uint");
            using (writer.Scope())
            {
                var groupEnumerator = group.GetEnumerator();
                var hasNext = groupEnumerator.MoveNext();
                do
                {
                    var curEntry = groupEnumerator.Current;
                    hasNext = groupEnumerator.MoveNext();
                    writer.WriteLine($"{curEntry.MangledName} = 0x{curEntry.Value:X}{ (hasNext ? "," : string.Empty)}");
                } while (hasNext);
            }
        }
    }
}

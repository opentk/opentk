using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;

namespace GeneratorV2.Writing
{
    public class EnumNode : WriterNode
    {
        private string _groupName;
        private HashSet<EnumEntry> _group;

        public EnumNode(string groupName, HashSet<EnumEntry> group)
        {
            _groupName = groupName;
            _group = group;
        }

        public override void Write()
        {
            if (_groupName == "SpecialNumbers")
            {
                WriteEnumClass();
            }
            else
            {
                WriteEnumGroup();
            }
        }

        private void WriteEnumClass()
        {
            Writer.WriteLine($"public static class {_groupName}");
            //using (Writer.Scope())
            {
                var groupEnumerator = _group.GetEnumerator();
                var hasNext = groupEnumerator.MoveNext();
                do
                {
                    var curEntry = groupEnumerator.Current;
                    hasNext = groupEnumerator.MoveNext();
                    var type = curEntry.Value > uint.MaxValue ? "ulong" : "uint";
                    Writer.WriteLine($"public const {type} {curEntry.MangledName} = 0x{curEntry.Value:X};");
                } while (hasNext);
            }
        }

        private void WriteEnumGroup()
        {
            Writer.WriteLine($"public enum {_groupName} : uint");
            //using (Writer.Scope())
            {
                var groupEnumerator = _group.GetEnumerator();
                var hasNext = groupEnumerator.MoveNext();
                do
                {
                    var curEntry = groupEnumerator.Current;
                    hasNext = groupEnumerator.MoveNext();
                    Writer.WriteLine($"{curEntry.MangledName} = 0x{curEntry.Value:X}{ (hasNext ? "," : string.Empty)}");
                } while (hasNext);
            }
        }
    }
}

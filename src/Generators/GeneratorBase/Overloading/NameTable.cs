using System.Collections.Generic;

namespace GeneratorBase.Overloading
{
    public class NameTable
    {
        public Dictionary<Parameter, string> Table = new Dictionary<Parameter, string>();

        public HashSet<Parameter> FixedTable = new HashSet<Parameter>();

        public string? ReturnName = "returnValue";

        public NameTable()
        {
        }

        public NameTable(NameTable table)
        {
            Table = new Dictionary<Parameter, string>(table.Table);
            FixedTable = new HashSet<Parameter>(table.FixedTable);
            ReturnName = table.ReturnName;
        }

        public NameTable New()
        {
            return new NameTable(this);
        }

        public void Rename(Parameter param, string name) => Table[param] = name;

        /// <summary>Mark this parameter as fixed, so generators don't try to use <see langword="fixed"/> on this parameter.</summary>
        public void MarkFixed(Parameter param) => FixedTable.Add(param);

        public bool IsFixed(Parameter param) => FixedTable.Contains(param);

        public string this[Parameter param]
        {
            get
            {
                if (Table.TryGetValue(param, out var name) == false)
                {
                    name = param.Name;
                }

                return name;
            }
        }

        public void Apply(NameTable table)
        {
            foreach (var (param, name) in table.Table)
            {
                Table[param] = name;
            }

            foreach (var fixedParam in table.FixedTable)
            {
                FixedTable.Add(fixedParam);
            }

            // Replace the return name.
            ReturnName = table.ReturnName;
        }
    }
}

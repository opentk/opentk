using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Bind.Structures
{
    /// <summary>
    /// Represents a collection of function definitions.
    /// </summary>
    internal class FunctionCollection : SortedDictionary<string, List<FunctionDefinition>>
    {
        private Regex _unsignedFunctions = new Regex(@".+(u[dfisb]v?)", RegexOptions.Compiled);

        private void Add(FunctionDefinition f)
        {
            if (!ContainsKey(f.ExtensionName))
            {
                Add(f.ExtensionName, new List<FunctionDefinition>());
                this[f.ExtensionName].Add(f);
            }
            else
            {
                this[f.ExtensionName].Add(f);
            }
        }

        /// <summary>
        /// Adds a range of function definitions to the collection.
        /// </summary>
        /// <param name="functions">The functions.</param>
        public void AddRange(IEnumerable<FunctionDefinition> functions)
        {
            foreach (var f in functions)
            {
                AddChecked(f);
            }
        }

        /// <summary>
        /// Adds the function to the collection, if a function with the same name and parameters doesn't already exist.
        /// </summary>
        /// <param name="f">The Function to add.</param>
        private void AddChecked(FunctionDefinition f)
        {
            if (ContainsKey(f.ExtensionName))
            {
                var list = this[f.ExtensionName];
                var index = list.IndexOf(f);
                if (index == -1)
                {
                    Add(f);
                }
                else
                {
                    var existing = list[index];
                    var replace = existing.Parameters.Any(p => p.ParameterType.IsUnsigned) &&
                                  !_unsignedFunctions.IsMatch(existing.Name) && _unsignedFunctions.IsMatch(f.Name);
                    replace |= !existing.Parameters.Any(p => p.ParameterType.IsUnsigned) &&
                               _unsignedFunctions.IsMatch(existing.Name) && !_unsignedFunctions.IsMatch(f.Name);
                    replace |=
                        (from pOld in existing.Parameters
                            join pNew in f.Parameters on pOld.Name equals pNew.Name
                            where pNew.ParameterType.ElementCount == 0 && pOld.ParameterType.ElementCount != 0
                            select true)
                        .Count() != 0;
                    if (replace)
                    {
                        list[index] = f;
                    }
                }
            }
            else
            {
                Add(f);
            }
        }
    }
}

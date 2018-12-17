using System.Collections.Generic;
using OpenTK.BuildTools.Common;

namespace OpenTK.BuildTools.Convert
{
    public static class TypeMapper
    {
        public static void Map(Dictionary<string, string> map, IEnumerable<Function> functions)
        {
            foreach (var function in functions)
            {
                if (map.ContainsKey(function.ReturnType.Name))
                {
                    function.ReturnType.Name = map[function.ReturnType.Name];
                }

                foreach (var parameter in function.Parameters)
                {
                    if (map.ContainsKey(parameter.Type.Name))
                    {
                        parameter.Type.Name = map[parameter.Type.Name];
                    }
                }
            }
        }
    }
}
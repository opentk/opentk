using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Generator.Common.Functions;
using Generator.Convert.Construction.Trimmers;

namespace Generator.Convert.Construction
{
    public static class NameTrimmer
    {
        public static IReadOnlyList<ITrimmer<Function>> FunctionTrimmers { get; } = new ITrimmer<Function>[]
        {
            new ExtensionNameTrimmer(),
            new DataTypeNameTrimmer()
        };

        public static void Trim(IEnumerable<Function> functions)
        {
            Task.WhenAll(functions.Select(TrimAsync)).GetAwaiter().GetResult();
        }

        public static Task TrimAsync(Function function)
        {
            foreach (var functionTrimmer in FunctionTrimmers)
            {
                if (functionTrimmer.IsRelevant(function))
                {
                    functionTrimmer.Trim(function);
                }
            }

            return Task.CompletedTask;
        }
    }
}

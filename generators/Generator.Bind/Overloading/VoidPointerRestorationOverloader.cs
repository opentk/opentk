using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generator.Common.Builders;
using Generator.Common.Functions;

namespace Generator.Bind.Overloading
{
    public class VoidPointerRestorationOverloader : IFunctionOverloader
    {
        // In this PR we made the decision to use IntPtr instead of void*.
        // This overload restores void* in parameters only.
        // See the following message for more information:
        // https://discordapp.com/channels/337627185248468993/525453014618865664/546380176108290098

        public bool IsApplicable(Function function)
        {
            return function.Parameters.Any(x => x.ToString() == "IntPtr");
        }

        public IEnumerable<Overload> CreateOverloads(Function function)
        {
            var sig = new FunctionSignatureBuilder(function).WithParameters
            (
                function.Parameters.Select
                (
                    x => x.ToString() == "IntPtr"
                        ? new ParameterSignatureBuilder(x).WithType
                          (
                              new TypeSignatureBuilder(x.Type).WithIndirectionLevel(1)
                              .WithName("void")
                              .Build()
                          )
                          .Build()
                        : x
                )
                .ToList()
            )
            .Build();
            var sb = new StringBuilder();
            sb.Append("return " + function.Name+"(");
            sb.Append
            (
                string.Join
                (
                    ", ", function.Parameters.Select(x => x.Type.ToString() == "void*" ? "(IntPtr) " + x.Name : x.Name)
                )
            );
            sb.AppendLine(");");
            yield return new Overload(sig, sb, true);
        }
    }
}

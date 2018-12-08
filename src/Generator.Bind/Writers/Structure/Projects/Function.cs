using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Bind.Writers.Structure.Projects
{
    public class Function
    {
        public string Name { get; set; }
        public bool IsUnsafe { get; set; }
        public TypeSignature ReturnType { get; set; }
        public string NativeName { get; set; }

        /// <summary>
        /// Gets the parameters of the function.
        /// </summary>
        [NotNull, ItemNotNull]
        public List<ParameterSignature> Parameters { get; set; } = new List<ParameterSignature>();

        /// <summary>
        /// Gets the generic type parameters of the function.
        /// </summary>
        [NotNull, ItemNotNull]
        public List<GenericTypeParameterSignature> GenericTypeParameters { get; set; } = new List<GenericTypeParameterSignature>();
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();
        public string Doc { get; set; }

        public string ToString()
        {
            var sb = new StringBuilder();

            if (Parameters.Any(p => p.Type.IsPointer))
            {
                sb.Append("unsafe ");
            }

            sb.Append(ReturnType);
            sb.Append(" ");

            sb.Append(Name);
            if (GenericTypeParameters.Count != 0)
            {
                sb.Append("<");
                var genericParameterNames = GenericTypeParameters.Select(p => p.Name);
                var genericParameterList = string.Join(", ", genericParameterNames);
                sb.Append(genericParameterList);
                sb.Append(">");
            }

            sb.Append("(");
            if (Parameters.Count > 0)
            {
                var parameterDeclarations = Parameters.Select(GetDeclarationString);
                var parameterList = string.Join(", ", parameterDeclarations);
                sb.Append(parameterList);
            }

            sb.Append(")");

            if (GenericTypeParameters.Count != 0)
            {
                sb.Append(" ");
                foreach (var p in GenericTypeParameters)
                {
                    var constraints = p.Constraints.Any()
                        ? string.Join(", ", p.Constraints)
                        : "struct";

                    sb.Append($"    where {p.Name} : {constraints}");
                }
            }

            sb.Append(";");

            return sb.ToString();
        }

        [NotNull]
        private string GetDeclarationString([NotNull] ParameterSignature parameter)
        {
            var sb = new StringBuilder();

            var attributes = new List<string>();
            if (parameter.Flow == FlowDirection.Out && parameter.Type.IsPointer)
            {
                sb.Append("out");
            }
            else if (parameter.Flow == FlowDirection.In && parameter.Type.IsPointer)
            {
                sb.Append("in");
            }

            sb.Append(parameter.Type.ToString());

            sb.Append(" ");
            sb.Append(parameter.Name);

            return sb.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Functions;
using JetBrains.Annotations;

namespace Bind.Writers.Structure.Projects
{
    /// <summary>
    /// Represents a C# function.
    /// </summary>
    public class Function
    {
        /// <summary>
        /// Gets or sets the name of this function.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is function is unsafe or safe.
        /// </summary>
        public bool IsUnsafe { get; set; }

        /// <summary>
        /// Gets or sets the return type of this function.
        /// </summary>
        public TypeSignature ReturnType { get; set; }

        /// <summary>
        /// Gets or sets the name of this function, as defined by the API specification.
        /// </summary>
        public string NativeName { get; set; }

        /// <summary>
        /// Gets or sets the parameters of the function.
        /// </summary>
        [NotNull, ItemNotNull]
        public List<ParameterSignature> Parameters { get; set; } = new List<ParameterSignature>();

        /// <summary>
        /// Gets or sets the generic type parameters of the function.
        /// </summary>
        [NotNull, ItemNotNull]
        public List<GenericTypeParameterSignature> GenericTypeParameters { get; set; } = new List<GenericTypeParameterSignature>();

        /// <summary>
        /// Gets or sets a list of attributes to be applied to this function.
        /// </summary>
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();

        /// <summary>
        /// Gets or sets the formatted XML documentation for this function.
        /// </summary>
        public string Doc { get; set; }

        /// <inheritdoc />
        public override string ToString()
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

        /// <summary>
        /// Gets the C# declaration string for the given parameter.
        /// </summary>
        /// <param name="parameter">The given parameter.</param>
        /// <returns>The C# declaration string.</returns>
        [NotNull]
        private static string GetDeclarationString([NotNull] ParameterSignature parameter)
        {
            var sb = new StringBuilder();

            switch (parameter.Flow)
            {
                case FlowDirection.Out when parameter.Type.IsPointer:
                    sb.Append("out ");
                    break;
                case FlowDirection.In when parameter.Type.IsPointer:
                    sb.Append("in ");
                    break;
                case FlowDirection.Undefined:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            sb.Append(parameter.Type.ToString());

            sb.Append(" ");
            sb.Append(parameter.Name);

            return sb.ToString();
        }
    }
}

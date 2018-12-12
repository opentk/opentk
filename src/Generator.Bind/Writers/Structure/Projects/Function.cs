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
        public List<GenericTypeParameterSignature> GenericTypeParameters { get; set; } =
            new List<GenericTypeParameterSignature>();

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

            if (Parameters.Any(p => p.Type.IsPointer) || ReturnType.IsPointer)
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
                for (var index = 0; index < GenericTypeParameters.Count; index++)
                {
                    var p = GenericTypeParameters[index];
                    var constraints = p.Constraints.Any()
                        ? string.Join(", ", p.Constraints)
                        : "struct";

                    sb.Append($"where {p.Name} : {constraints}");
                    if (index != GenericTypeParameters.Count - 1)
                    {
                        sb.Append(" ");
                    }
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

            var type = (TypeSignature)parameter.Type.Clone(); // we're multi-threaded, don't wanna wreck anything
            if (parameter.Flow == FlowDirection.Out && parameter.Type.IsPointer)
            {
                sb.Append("out ");
            }
            else if (parameter.Flow == FlowDirection.In && parameter.Type.IsPointer)
            {
                sb.Append("in ");
                if (type.ToString() == "void*")
                {
                    type = new TypeSignature("UIntPtr", 0, 0, false, false);
                }
                else
                {
                    type.IndirectionLevel--;
                }
            }

            sb.Append(type);

            sb.Append(" ");
            sb.Append((Utilities.CSharpKeywords.Contains(parameter.Name) ? "@" : string.Empty) + parameter.Name);

            return sb.ToString();
        }
    }
}

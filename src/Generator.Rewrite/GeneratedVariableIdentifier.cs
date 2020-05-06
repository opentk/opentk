using System;
using Mono.Cecil.Cil;

namespace OpenTK.Rewrite
{
    /// <summary>
    /// Acts as a unique identifier for a generated named variable that can be passed between methods. Replaces uses of
    /// variable names from Mono.Cecil.
    /// </summary>
    internal sealed class GeneratedVariableIdentifier
    {
        /// <summary>
        /// The <see cref="MethodBody"/> which the variable is in.
        /// </summary>
        public MethodBody Body { get; }

        /// <summary>
        /// The <see cref="VariableDefinition"/> which the variable idetifier maps to.
        /// </summary>
        public VariableDefinition Definition { get; }

        /// <summary>
        /// The name of the generated variable.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedVariableIdentifier"/> class.
        /// </summary>
        /// <param name="body">The method body which the variable is in.</param>
        /// <param name="definition">The definition of the generated variable.</param>
        /// <param name="name">The name of the generated variable.</param>
        /// <exception cref="ArgumentException"></exception>
        public GeneratedVariableIdentifier(MethodBody body, VariableDefinition definition, string name)
        {
            if (body == null)
            {
                throw new ArgumentException("The body argument cannot be null.", nameof(body));
            }

            if (definition == null)
            {
                throw new ArgumentException("The definition argument cannot be null.", nameof(definition));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("The name argument cannot be null or empty", nameof(name));
            }

            this.Body = body;
            this.Definition = definition;
            this.Name = name;
        }
    }
}

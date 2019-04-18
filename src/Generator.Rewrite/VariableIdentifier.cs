using System;
using Mono.Cecil.Cil;

namespace OpenToolkit.Rewrite
{
    /// <summary>
    /// Acts as a unique identifier for a named variable that can be passed between methods. Replaces uses of
    /// variable names from Mono.Cecil.
    /// </summary>
    public sealed class VariableIdentifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableIdentifier" /> class.
        /// </summary>
        /// <param name="body">The method body which the variable is in.</param>
        /// <param name="definition">The definition of the generated variable.</param>
        /// <param name="name">The name of the generated variable.</param>
        /// <exception cref="ArgumentException">
        /// If <paramref name="name"/> is null or an empty string.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// If either <paramref name="body"/> or <paramref name="definition"/> are null.
        /// </exception>
        public VariableIdentifier(MethodBody body, VariableDefinition definition, string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("The name argument cannot be null or empty", nameof(name));
            }

            Body = body ?? throw new ArgumentNullException(nameof(body));
            Definition = definition ?? throw new ArgumentNullException(nameof(definition));
            Name = name;
        }

        /// <summary>
        /// Gets the <see cref="MethodBody"/> which the variable is in.
        /// </summary>
        public MethodBody Body { get; }

        /// <summary>
        /// Gets the <see cref="VariableDefinition"/> which the variable idetifier maps to.
        /// </summary>
        public VariableDefinition Definition { get; }

        /// <summary>
        /// Gets the name of the generated variable.
        /// </summary>
        public string Name { get; }
    }
}

using System;

namespace OpenTK.Rewrite
{
    /// <summary>
    /// Acts as a unique identifier for a generated named variable that can be passed between methods. Replaces uses of 
    /// variable names from Mono.Cecil.
    /// </summary>
    public class GeneratedVariableIdentifier
    {
        /// <summary>
        /// The name of the generated variable.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// The index of the generated variable in its method.
        /// </summary>
        public int Index { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedVariableIdentifier"/> class.
        /// </summary>
        /// <param name="name">The name of the generated variable.</param>
        /// <param name="index">The index of the generated variable in its method.</param>
        /// <exception cref="ArgumentException"></exception>
        public GeneratedVariableIdentifier(string name, int index)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("The name argument cannot be null or empty", nameof(name));
            }

            if (index < 0)
            {
                throw new ArgumentException("The index must be greater than zero.", nameof(index));
            }
            
            this.Name = name;
            this.Index = index;
        }
    }
}
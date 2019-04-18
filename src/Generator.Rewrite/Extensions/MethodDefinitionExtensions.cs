using System.Linq;
using Mono.Cecil;

namespace OpenToolkit.Rewrite.Extensions
{
    /// <summary>
    /// Provides convenience extension methods for <see cref="MethodDefinition"/> instances.
    /// </summary>
    public static class MethodDefinitionExtensions
    {
        /// <summary>
        /// Gets the "slot" (the index of the entry point in a given array of entry points) of a method from its
        /// SlotAttribute, or -1 if none is present.
        /// </summary>
        /// <param name="method">The method definition to get the slot for.</param>
        /// <returns>The slot as specified by the applied SlotAttribute, or -1 if none is found.</returns>
        public static int GetSlot(this MethodDefinition method)
        {
            var slotAttribute = method.CustomAttributes.FirstOrDefault(a =>
            {
                return a.AttributeType.Name == AttributeNames.Slot;
            });
            return (int)(slotAttribute?.ConstructorArguments[0].Value ?? -1);
        }
    }
}

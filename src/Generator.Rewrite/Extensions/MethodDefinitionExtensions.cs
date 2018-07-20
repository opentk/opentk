using Mono.Cecil;
using System.Linq;

namespace OpenTK.Rewrite.Extensions
{
    public static class MethodDefinitionExtensions
    {
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

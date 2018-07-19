using System.Linq;
using System.Text.RegularExpressions;
using Bind.XML.Signatures.Functions;

namespace Bind.Translation.Trimmers
{
    /// <summary>
    /// Trims OpenGL data type endings from function names.
    /// </summary>
    public class OpenGLFunctionDataTypeTrimmer : ITrimmer<FunctionSignature>
    {
        private static Regex DataTypeRegex;

        /// <inheritdoc/>
        public bool IsRelevant(FunctionSignature trimmable)
        {
            if (!trimmable.Parameters.Any())
            {
                return false;
            }

            var hasVectorParameter = trimmable.Parameters.Any(p => p.Type.Name.Contains('*'));
            var hasIndexedVectorParameterPair = trimmable.Parameters.Any(p => p.Name == "index") && hasVectorParameter;

            if (hasIndexedVectorParameterPair)
            {
                return true;
            }

            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public FunctionSignature Trim(FunctionSignature trimmable)
        {
            throw new System.NotImplementedException();
        }
    }
}

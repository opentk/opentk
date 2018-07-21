using System;
using System.Linq;
using System.Text;
using Bind.XML.Signatures;
using JetBrains.Annotations;

namespace Bind.Translation.Translators
{
    /// <summary>
    /// Translates the OpenGL enumeration signatures in a profile into their language-appropriate variants.
    /// </summary>
    public class ProfileEnumerationTranslator : ITranslator<ApiProfile>
    {
        /// <inheritdoc/>
        public ApiProfile TranslateProfile(ApiProfile profile)
        {
            var enumerations = profile.Enumerations;
            var knownExtensions = profile.Functions.Select(f => f.Extension).Distinct().ToList();

            foreach (var enumeration in enumerations)
            {
            }

            throw new NotImplementedException();
        }
    }
}

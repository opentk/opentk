using System;
using System.Collections.Generic;
using Bind.XML.Signatures;

namespace Bind.Translation.Translators
{
    /// <summary>
    /// Translates OpenGL type names in a profile to their respective C# type names.
    /// </summary>
    public class ProfileTypeTranslator : ITranslator<ApiProfile>
    {
        private readonly IReadOnlyDictionary<string, string> _apiTypeMap;
        private readonly IReadOnlyDictionary<string, string> _languageTypeMap;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileTypeTranslator"/> class.
        /// </summary>
        /// <param name="apiTypeMap">The API-specific typemap.</param>
        /// <param name="languageTypeMap">The language-specific typemap.</param>
        public ProfileTypeTranslator
        (
            IReadOnlyDictionary<string, string> apiTypeMap,
            IReadOnlyDictionary<string, string> languageTypeMap
        )
        {
            _apiTypeMap = apiTypeMap;
            _languageTypeMap = languageTypeMap;
        }

        /// <inheritdoc/>
        public ApiProfile Translate(ApiProfile profile)
        {
            throw new NotImplementedException();
        }
    }
}

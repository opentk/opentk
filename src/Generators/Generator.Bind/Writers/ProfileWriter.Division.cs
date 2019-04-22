using System.Collections.Generic;
using System.Linq;
using Bind.Translation.Translators;
using Bind.XML.Signatures;
using Bind.XML.Signatures.Enumerations;
using Bind.XML.Signatures.Functions;

namespace Bind.Writers
{
    internal static partial class ProfileWriter
    {
        /// <summary>
        /// Splits a profile into a group of projects.
        /// </summary>
        /// <param name="profile">The profile to split.</param>
        /// <returns>A collection of projects.</returns>
        public static
            IEnumerable<(string Extension, IEnumerable<(string InterfaceName, IEnumerable<FunctionSignature>)>,
                IEnumerable<EnumerationSignature>)> GetProjects(ApiProfile profile)
        {
            return GetProjectsWithoutEnums(profile.NativeSignatures)
                .Select
                (
                    x => (x.name, x.Item2,
                        (IEnumerable<EnumerationSignature>)(x.name == "Core"
                            ? profile.Enumerations
                            : new EnumerationSignature[0]))
                );
        }

        /// <summary>
        /// Writes a collection of functions to their appropriate projects.
        /// </summary>
        /// <param name="functions">The functions to write.</param>
        /// <returns>A collection of projects.</returns>
        public static IEnumerable<(string name, IEnumerable<(string category, IEnumerable<FunctionSignature>)>)>
            GetProjectsWithoutEnums(IEnumerable<FunctionSignature> functions)
        {
            // extension or core, (interface name, functions)
            var projects = new Dictionary<string, Dictionary<string, List<FunctionSignature>>>();
            foreach (var function in functions)
            {
                foreach (var category in function.Categories)
                {
                    // check that the root project exists
                    if (!projects.ContainsKey("Core"))
                    {
                        projects.Add
                        (
                            "Core",
                            new Dictionary<string, List<FunctionSignature>>()
                        );
                    }

                    // check that the extension project exists, if applicable
                    if (function.Extension != "Core" && !projects.ContainsKey(category))
                    {
                        projects.Add
                        (
                            category,
                            new Dictionary<string, List<FunctionSignature>>()
                        );
                    }

                    // check that the interface exists
                    if
                    (
                        !projects[function.Extension == "Core" ? "Core" : category].ContainsKey("I" + NativeIdentifierTranslator.TranslateIdentifierName(category))
                    )
                    {
                        projects[function.Extension == "Core" ? "Core" : category]
                            .Add
                            (
                                "I" + NativeIdentifierTranslator.TranslateIdentifierName(category),
                                new List<FunctionSignature>()
                            );
                    }

                    // add the function to the interface
                    projects[function.Extension == "Core" ? "Core" : category]
                        ["I" + NativeIdentifierTranslator.TranslateIdentifierName(category)]
                        .Add(function);
                }
            }

            return projects.Select(x => (x.Key, x.Value.Select(y => (y.Key, (IEnumerable<FunctionSignature>)y.Value))));
        }
    }
}

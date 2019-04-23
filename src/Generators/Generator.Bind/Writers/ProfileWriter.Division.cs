using System.Collections.Generic;
using System.Linq;
using Bind.Structure;
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
        public static IEnumerable<Project> GetProjects(ApiProfile profile)
        {
            return GetWithoutEnums(profile.NativeSignatures)
                .Select
                (
                    x => new Project(x.Item1, x.Item2,
                        x.Item1 == "Core"
                            ? profile.Enumerations
                            : new EnumerationSignature[0], profile.Overloads)
                );
        }

        private static IEnumerable<(string, IEnumerable<Interface>)> GetWithoutEnums(IEnumerable<FunctionSignature> fns)
        {
            // extension or core, (interface name, functions)
            var projects = new Dictionary<string, Dictionary<string, List<FunctionSignature>>>();
            foreach (var function in fns)
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

            return projects.Select(x => (x.Key, x.Value.Select(y => new Interface(y.Key, y.Value))));
        }
    }
}

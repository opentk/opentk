using GeneratorV2.Data;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace GeneratorV2.Parsing
{
    public class FeatureParser
    {
        public List<Feature> Parse(XElement input, Dictionary<string, Command2> commands, EnumEntryCollection enums)
        {
            Logger.Info("Begining parsing of features.");

            List<Feature> features = new List<Feature>();

            Feature? previousFeature = null;
            foreach (var element1 in input.Elements("feature"))
            {
                var api = element1.Attribute("api")?.Value;
                var name = element1.Attribute("name")?.Value;
                var input1 = element1.Attribute("number")?.Value;
                if (api == null || name == null || input1 == null)
                {
                    Logger.Error("Feature " + name + " did not parse correctly.");
                }
                else
                {
                    var version = Version.Parse(input1);
                    var excludeEnums = new HashSet<string>();
                    var excludeCommands = new HashSet<string>();
                    foreach (var excludes in element1.Elements("remove"))
                    {
                        ParseExclude(excludes, excludeEnums, excludeCommands);
                    }
                    var feature = new Feature(api, name, version);
                    if (feature.Api == previousFeature?.Api)
                    {
                        feature.Add(previousFeature, excludeEnums, excludeCommands);
                    }
                    foreach (var includes in element1.Elements("require"))
                    {
                        ParseInclude(enums, commands, feature, includes);
                    }
                    previousFeature = feature;

                    features.Add(feature);
                }
            }

            return features;
        }

        private static void ParseExclude(XElement excludes, HashSet<string> excludeEnums, HashSet<string> excludeCommands)
        {
            var profile = excludes.Attribute("profile")?.Value;
            if (profile != "compatibility" && profile != null)
            {
                return;
            }

            foreach (var e in excludes.Elements("enum"))
            {
                var eName = e.Attribute("name")?.Value;
                if (eName == null)
                {
                    Logger.Error($"Feature enum exclude did not parse correctly.");
                    continue;
                }
                excludeEnums.Add(eName);
            }

            foreach (var c in excludes.Elements("command"))
            {
                var cName = c.Attribute("name")?.Value;
                if (cName == null)
                {
                    Logger.Error($"Feature command exclude did not parse correctly.");
                    continue;
                }
                excludeCommands.Add(cName);
            }
        }

        private static void ParseInclude(EnumEntryCollection enums, Dictionary<string, Command2> commands,
            Feature feature, XElement includes)
        {
            var profile = includes.Attribute("profile")?.Value;
            if (profile != "compatibility" && profile != null)
            {
                return;
            }

            foreach (var e in includes.Elements("enum"))
            {
                var eName = e.Attribute("name").Value;
                if (enums.TryGetValue(eName, feature.Api, out var enumEntry))
                {
                    feature.Add(enumEntry);
                }
                else
                {
                    Logger.Error($"Feature command include did not parse correctly.");
                }
            }
            foreach (var e in includes.Elements("command"))
            {
                var cName = e.Attribute("name").Value;

                // FIXME: We should see if reversing this lookup and using
                // List<> instead of Dictionary<> for better itteration.
                if (!commands.TryGetValue(cName, out var command))
                {
                    Logger.Error($"Feature command include did not parse correctly.");
                    continue;
                }
                feature.Add(command);
            }
        }
    }
}

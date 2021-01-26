using System;
using System.Collections.Generic;

namespace GeneratorV2.Data
{
    /// <summary>
    /// A feature is a list of required and removed enums and commands in this version.
    /// Feature = GL version. Ex. GL3.3 or GLES2.0.
    /// </summary>
    public class Feature
    {
        public readonly GLAPI Api;
        public readonly Version Version;
        public readonly string Name;

        public readonly List<RequireEntry> Requires;
        public readonly List<RemoveEntry> Removes;

        public Feature(GLAPI api, Version version, string name, List<RequireEntry> requires, List<RemoveEntry> removes)
        {
            Api = api;
            Version = version;
            Name = name;
            Requires = requires;
            Removes = removes;
        }
    }

    // FIXME: Move these to a better place

    public enum GLAPI
    {
        Invalid,
        None,
        GL,
        GLES1,
        GLES2,
        GLSC2,
    }

    public enum GLProfile
    {
        Invalid,
        None,
        Core,
        Compatibility,
        Common,
        // FIXME...
    }

    // TODO: Merge these too classes probably
    public class RequireEntry
    {
        // This field is most likely not used...
        public readonly GLAPI Api;

        public readonly GLProfile Profile;
        public readonly string? Comment;
        public readonly List<string> Commands = new List<string>();
        public readonly List<string> Enums = new List<string>();

        public RequireEntry(GLAPI api, GLProfile profile, string? comment, List<string> commands, List<string> enums)
        {
            Api = api;
            Profile = profile;
            Comment = comment;
            Commands = commands;
            Enums = enums;
        }
    }

    public class RemoveEntry
    {
        public readonly GLProfile Profile;
        public readonly string? Comment;
        public readonly List<string> Commands = new List<string>();
        public readonly List<string> Enums = new List<string>();

        public RemoveEntry(GLProfile profile, string? comment, List<string> commands, List<string> enums)
        {
            Profile = profile;
            Comment = comment;
            Commands = commands;
            Enums = enums;
        }
    }
}

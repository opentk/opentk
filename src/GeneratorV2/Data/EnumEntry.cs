using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GeneratorV2.Data
{
    public enum EnumType
    {
        Invalid,
        None,
        Bitmask
    }

    public class EnumEntry : IEquatable<EnumEntry>
    {
        public string Name { get; }
        public string? Api { get; }
        public string MangledName { get; }
        public ulong Value { get; }

        public string[] Groups { get; }

        public EnumType Type { get; }

        public EnumEntry(string name, string? api, string mangledName, ulong value, string[] groups, EnumType type)
        {
            Name = name;
            Api = api;
            MangledName = mangledName;
            Value = value;
            Groups = groups;
            Type = type;
        }

        public bool Equals([AllowNull] EnumEntry other)
        {
            return Name == other?.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }

    // <enums/>
    public class EnumsEntry
    {
        public readonly string Namespace;
        public readonly string[]? Groups;
        public readonly EnumType Type;
        public readonly string? Vendor;
        public readonly Range? Range;
        public readonly string? Comment;
        public readonly List<EnumEntry2> Enums;

        public EnumsEntry(string @namespace, string[]? groups, EnumType type, string? vendor, Range? range, string? comment, List<EnumEntry2> enums)
        {
            Namespace = @namespace;
            Groups = groups;
            Type = type;
            Vendor = vendor;
            Range = range;
            Comment = comment;
            Enums = enums;
        }
    }

    /// <summary>
    /// Legal C suffix for the value to force it to a specific type.
    /// Currently only \code{u} and \code{ull} are used,
    /// for \code{unsigned} 32 - and 64 - bit integer values, respectively.
    /// Separated from the \attr{value} field since this eases parsing and
    /// sorting of values, and is rarely used.
    ///
    /// <br/>
    /// Taken from <see href="https://github.com/KhronosGroup/OpenGL-Registry/blob/0dc24166d162723781f1bf9fe433f71fa03a7aa0/xml/readme.tex#L383">KhronosGroup/OpenGL-Registry/xml/readme.tex#L383</see> 2020-11-22
    /// </summary>
    public enum TypeSuffix
    {
        Invalid,
        None,
        // TODO: Maybe consider other postfixes for the future?
        U,
        Ull,
    }

    // <enum/>
    public class EnumEntry2
    {
        public readonly string Name;
        public readonly GLAPI Api;
        public readonly ulong Value;
        public readonly string? Alias;
        public readonly string? Comment;

        public readonly string[]? Groups;

        public readonly TypeSuffix Type;

        public EnumEntry2(string name, GLAPI api, ulong value, string? alias, string? comment, string[]? groups, TypeSuffix type)
        {
            Name = name;
            Api = api;
            Value = value;
            Alias = alias;
            Comment = comment;
            Groups = groups;
            Type = type;
        }
    }
}

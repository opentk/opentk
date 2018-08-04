// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(
    "StyleCop.CSharp.ReadabilityRules",
    "SA1121:Use built-in type alias",
    Justification = "This project uses the type names declared by the Windows API for easier interoperability"
)]
[assembly: SuppressMessage(
    "StyleCop.CSharp.DocumentationRules",
    "SA1625:Element documentation should not be copied and pasted",
    Justification = "It's allowed to copy and paste documentation from the Windows API docs in this project."
)]

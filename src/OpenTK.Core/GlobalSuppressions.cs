// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(
    "StyleCop.CSharp.NamingRules",
    "SA1307:Accessible fields should begin with upper-case letter",
    Justification = "This namespace contains a lot of native interfacing code that is better by using the native API naming convention",
    Scope = "namespaceanddescendants",
    Target = "OpenTK.Platform.Implementations.Windows")]
[assembly: SuppressMessage(
    "StyleCop.CSharp.NamingRules",
    "SA1313:Parameter names should begin with lower-case letter",
    Justification = "This namespace contains a lot of native interfacing code that is better by using the native API naming convention",
    Scope = "namespaceanddescendants",
    Target = "OpenTK.Platform.Implementations.Windows")]
[assembly: SuppressMessage(
    "StyleCop.CSharp.LayoutRules",
    "SA1503:Braces should not be omitted",
    Justification = "This is a stupid rule?",
    Scope = "namespaceanddescendants",
    Target = "OpenTK.Platform.Implementations.Windows")]
[assembly: SuppressMessage(
    "StyleCop.CSharp.SpacingRules",
    "SA1023:Dereference and access of symbols should be spaced correctly",
    Justification = "This rule doesn't work with pointer types inside of function pointers.",
    Scope = "namespaceanddescendants",
    Target = "OpenTK.Platform.Implementations.Windows")]

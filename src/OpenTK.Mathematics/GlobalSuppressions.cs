// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(
    "StyleCop.CSharp.NamingRules",
    "SA1305:Field names should not use Hungarian notation",
    Justification = "There are a lot of short variable names (especially for matrix elements) in the Mathematics library, so instead of changing 500-1000 variable names, we just suppress this message instead."
)]

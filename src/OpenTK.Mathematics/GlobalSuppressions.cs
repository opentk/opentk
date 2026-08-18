// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("OpenTK.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100690271c30ef355685baa02ef75a29ed11d2c2dad57636e5add6c104c241bc08fcf4fb07b3683a088450596f0f17728fed9aa04b915f6ccd0b02b5aea6503cab0fe8195e0db8502aedc242ec88892a9dbb2e850de5812db75f961133ac31c5e931291dae188aab9e30d45725be66d86e276dc79f1fd8bd045554ec7003371f3b2")]
[assembly: InternalsVisibleTo("OpenTK.Benchmarks, PublicKey=0024000004800000940000000602000000240000525341310004000001000100690271c30ef355685baa02ef75a29ed11d2c2dad57636e5add6c104c241bc08fcf4fb07b3683a088450596f0f17728fed9aa04b915f6ccd0b02b5aea6503cab0fe8195e0db8502aedc242ec88892a9dbb2e850de5812db75f961133ac31c5e931291dae188aab9e30d45725be66d86e276dc79f1fd8bd045554ec7003371f3b2")]

[assembly: SuppressMessage(
    "StyleCop.CSharp.NamingRules",
    "SA1305:Field names should not use Hungarian notation",
    Justification = "There are a lot of short variable names (especially for matrix elements) in the Mathematics library, so instead of changing 500-1000 variable names, we just suppress this message instead."
)]

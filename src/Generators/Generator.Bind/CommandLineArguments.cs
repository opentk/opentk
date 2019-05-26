﻿//
// CommandLineArguments.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.Collections.Generic;
using System.IO;
using CommandLine;
using JetBrains.Annotations;
using static Bind.TargetAPI;

namespace Bind
{
    /// <summary>
    /// Holds command-line arguments, parsed from the command line.
    /// </summary>
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public sealed class CommandLineArguments
    {
        /// <summary>
        /// Gets or sets the base input path where the binder looks for specification files.
        /// </summary>
        [Option('i', "input", HelpText = "The base input path where the binder looks for specification files.")]
        public string InputPath { get; set; } = Path.Combine("src", "Generators", "Generator.Bind", "Specifications");

        /// <summary>
        /// Gets or sets the base output path where the binder will write the generated files.
        /// </summary>
        [Option('o', "output", HelpText = "The base output path where the binder will write the generated files.")]
        public string OutputPath { get; set; } = "src";

        /// <summary>
        /// Gets or sets the base path where documentation files are stored.
        /// </summary>
        [Option('d', "doc-path", HelpText = "The base path where documentation files are stored.")]
        public string DocumentationPath { get; set; } = Path.Combine("src", "Generators", "Generator.Bind", "Specifications", "Docs", "docs.gl");

        /// <summary>
        /// Gets or sets the APIs that should be generated.
        /// </summary>
        [Option('a', "apis", Default = new[] { All }, HelpText = "The APIs that should be generated.")]
        public IEnumerable<TargetAPI> TargetAPIs { get; set; }
    }
}

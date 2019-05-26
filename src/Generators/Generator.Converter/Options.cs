﻿//
// Option.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

namespace OpenTK.Convert
{
    /// <summary>
    /// A container class used by <see cref="CommandLine.Parser" /> to parse command line arguments.
    /// </summary>
    public class Options
    {
#pragma warning disable SA1118 // ParameterMustNotSpanMultipleLines
        /// <summary>
        /// Gets a set of usage examples which can be shown to the user.
        /// </summary>
        [Usage(ApplicationAlias = "Convert.exe")]
        public static IEnumerable<Example> Examples
        {
            get
            {
                yield return new Example(
                    "Converting local files",
                    new Options { Prefix = "gl", OutputFile = "signatures.xml", InputFiles = new[] { "gl.xml" } });

                yield return new Example(
                    "Converting latest remote specification",
                    new Options
                    {
                        Prefix = "gl",
                        OutputFile = "signatures.xml",
                        InputFiles = new[]
                        {
                            "https://cvs.khronos.org/svn/repos/ogl/trunk/doc/registry/public/api/gl.xml",
                        },
                    });
            }
        }

        /// <summary>
        /// Gets or sets the prefix to remove from parsed functions and constants.
        /// </summary>
        [Option(
            'p',
            "prefix",
            HelpText = "The prefix to remove from parsed functions and constants.",
            Required = true,
            Default = "gl")]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or sets the path to the output file. Defaults to stdout if no path is provided.
        /// </summary>
        [Option
        (
            'o',
            "output-file",
            HelpText = "The path to the output file. Defaults to stdout if no path is provided."
        )]
        public string OutputFile { get; set; }

        /// <summary>
        /// Gets or sets a list of the Khronos XML files to parse into OpenTK XML. Remote resources in the form of URLs are
        /// supported.
        /// </summary>
        [Option
        (
            'i',
            "input-files",
            HelpText = "A list of the Khronos XML files to parse into OpenTK XML." +
                       "Remote resources in the form of URLs are supported.",
            Required = true
        )]
        public IEnumerable<string> InputFiles { get; set; }
#pragma warning restore SA1118 // ParameterMustNotSpanMultipleLines
    }
}

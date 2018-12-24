﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using CommandLine;
using CommandLine.Text;
using Generator.Convert.Baking;
using Newtonsoft.Json;

namespace Generator.Convert
{
    /// <summary>
    /// The entry point for the bindings converter.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Gets or sets the parsed command-line arguments.
        /// </summary>
        public static Options CliOptions { get; set; }

        /// <summary>
        /// The entry point for the bindings converter.
        /// </summary>
        /// <param name="args">The raw command-line arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("OpenGL Registry Converter");
            Console.WriteLine("(C) The Open Toolkit Project");
            Console.WriteLine();
            var parserResult = new Parser(x => x.HelpWriter = TextWriter.Null).ParseArguments<Options>(args);
            parserResult.WithParsed(result => CliOptions = result);
            parserResult.WithNotParsed
            (
                errs =>
                {
                    var helpText = HelpText.AutoBuild
                        (parserResult, h => HelpText.DefaultParsingErrorsHandler(parserResult, h), e => e);
                    helpText.Copyright = string.Empty;
                    helpText.Heading = string.Empty;
                    Console.WriteLine(helpText);
                    Environment.Exit(-1);
                }
            );

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            using (var profileConstructor = new ProfileConstructor
            {
                InputFiles = CliOptions.InputFiles.ToList(),
                OutputFolder = CliOptions.OutputFolder,
                Pretty = CliOptions.PrettyPrinted,
                Prefix = CliOptions.Prefix,
                TypeMaps = CliOptions.Typemap.Any()
                    ? CliOptions.Typemap.Select(File.ReadAllText)
                        .Select(JsonConvert.DeserializeObject<Dictionary<string, string>>)
                        .ToList()
                    : null
            })
            {
                profileConstructor.WriteProfiles();
            }

            ProfileBakery.Bake
            (
                CliOptions.BakeryInformation.Any()
                    ? CliOptions.BakeryInformation.Select(File.ReadAllText)
                        .Select(JsonConvert.DeserializeObject<ProfileBakeryInformation>)
                    : ProfileBakeryInformation.Default,
                CliOptions.OutputFolder,
                CliOptions.PrettyPrinted
            );
            if (!CliOptions.PreserveRawAPIs)
            {
                ProfileBakery.DeleteRawAPIs(CliOptions.OutputFolder);
            }

            stopwatch.Stop();
            Console.WriteLine("Profiles generated in {0} seconds.", stopwatch.Elapsed.TotalSeconds);
        }
    }
}
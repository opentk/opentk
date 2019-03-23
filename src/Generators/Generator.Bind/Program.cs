using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;
using Generator.Bind.Overloading;
using Generator.Common;
using Newtonsoft.Json;

namespace Generator.Bind
{
    /// <summary>
    /// The entry point for the bindings writer.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Gets or sets the parsed command-line options.
        /// </summary>
        public static Options CliOptions { get; set; }

        /// <summary>
        /// The entry point for the bindings writer.
        /// </summary>
        /// <param name="args">The raw command-line arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("OpenTK Bindings Writer");
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

            Task.WhenAll
            (
                CliOptions.InputFiles.Select(File.ReadAllText)
                    .Select(JsonConvert.DeserializeObject<Profile>)
                    .Select(x => x.FlushAsync())
            )
            .GetAwaiter()
            .GetResult();

            stopwatch.Stop();
            Console.WriteLine("Bindings generated in {0} seconds.", stopwatch.Elapsed.TotalSeconds);
        }
    }
}

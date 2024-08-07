using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenTK.Platform;
using OpenTK.Platform.Native;
using OpenTK.Core.Utility;

namespace OpenTK.Backends.Tests
{
    /// <summary>
    /// Loads the backend configuration for the application.
    /// </summary>
    [JsonSerializable(typeof(BackendsConfig))]
    public class BackendsConfig
    {
        /// <summary>
        /// Create a new instance of BackendsConfig.
        /// </summary>
        public BackendsConfig() { }

        private static BackendsConfig? _singleton = null;

        /// <summary>
        /// The logger for this configuration loader.
        /// </summary>
        public static ILogger? Logger = null;

        /// <summary>
        /// The configuration singleton.
        /// </summary>
        public static BackendsConfig Singleton
        {
            get
            {
                if (_singleton != null)
                    return _singleton;

                LoadSingleton();

                return _singleton!;
            } 
        }

        /// <summary>
        /// Indicates if any extra assemblies were loaded.
        /// </summary>
        public static bool ExtraAssembliesLoaded { get; private set; }

        static void LoadSingleton()
        {
            string[] argv = Environment.GetCommandLineArgs();

            BackendsConfig? config = null;
            try
            {
                if (argv.Length > 1)
                {
                    string pathOrConfig = argv[1];

                    // Allow comments in JSON.
                    JsonSerializerOptions options = new JsonSerializerOptions()
                    {
                        ReadCommentHandling = JsonCommentHandling.Skip,
                    };

                    // If the argument is a file, load the file, else try to interpret as JSON.

                    try
                    {
                        if (File.Exists(pathOrConfig))
                        {
                            using Stream stream = File.Open(pathOrConfig, FileMode.Open);
                            config = JsonSerializer.Deserialize<BackendsConfig>(stream, options);
                        }
                        else
                        {
                            config = JsonSerializer.Deserialize<BackendsConfig>(pathOrConfig, options);
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger?.LogError($"Could not load configuration: {ex}\n{ex.StackTrace}");

                        if (Debugger.IsAttached)
                            Debugger.Break();
                    }
                }

                // Make sure there actually is a backend config.
                if (config == null)
                    config = new BackendsConfig();
            }
            catch (Exception ex)
            {
                Logger?.LogError($"An unkown error occured during loading the configuration: {ex}\n{ex.StackTrace}");

                if (Debugger.IsAttached)
                    Debugger.Break();
            }
            finally
            {
                _singleton = config ?? new BackendsConfig();
            }
        }
    }
}

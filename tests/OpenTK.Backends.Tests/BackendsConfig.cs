using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using OpenTK.Core.Platform;
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
        // Because this tool not only aims to support third party developers
        // making their own platform drivers, it should support a multitude of
        // options for dependency injection.
        //
        // 1. The assemblies in LoadExtraAssemblies are loaded.
        // 2. If any specific driver name is provided, these are created using reflection.
        // 3. Any driver names not provided are loaded using normal driver loading logic.
        //      - PreferSDL2 is passed to the OpenTK.Platform.Native loader.


        /// <summary>
        /// Provides the preferred backend to pick.
        /// </summary>
        /// <remarks>Use "auto" for automatic.</remarks>
        /// <seealso cref="OpenTK.Platform.Native.Backend"/>
        public bool PreferSDL2 {get; set; } = false;

        /// <summary>
        /// Provides the preferred backend to pick.
        /// </summary>
        /// <remarks>Use "auto" for automatic.</remarks>
        /// <seealso cref="OpenTK.Platform.Native.Backend"/>
        public bool PreferANGLE { get; set; } = false;

        /// <summary>
        /// Extra assemblies to load before loading PAL2 drivers.
        /// </summary>
        public List<string> ExtraAssemblies { get; set; } = new List<string>();

        // These keys provide overrides for specific backends.
        /// <summary>
        /// Override the default driver for OpenGL component.
        /// </summary>
        public string? OpenGL { get; set; }
        /// <summary>
        /// Override the default driver for Vulkan component.
        /// </summary>
        public string? Vulkan { get; set; }
        /// <summary>
        /// Override the default driver for WindowIcon component.
        /// </summary>
        public string? WindowIcon { get; set; }
        /// <summary>
        /// Override the default driver for MouseCursor component.
        /// </summary>
        public string? MouseCursor { get; set; }
        /// <summary>
        /// Override the default driver for Window component.
        /// </summary>
        public string? Window { get; set; }
        /// <summary>
        /// Override the default driver for Surface component.
        /// </summary>
        public string? Surface { get; set; }
        /// <summary>
        /// Override the default driver for Display component.
        /// </summary>
        public string? Display { get; set; }
        /// <summary>
        /// Override the default driver for MiceInput component.
        /// </summary>
        public string? MiceInput { get; set; }
        /// <summary>
        /// Override the default driver for KeyboardInput component.
        /// </summary>
        public string? KeyboardInput { get; set; }
        /// <summary>
        /// Override the default driver for ControllerInput component.
        /// </summary>
        public string? ControllerInput { get; set; }
        /// <summary>
        /// Override the default driver for Clipboard component.
        /// </summary>
        public string? Clipboard { get; set; }
        /// <summary>
        /// Override the default driver for Shell component.
        /// </summary>
        public string? Shell { get; set; }
        /// <summary>
        /// Override the default driver for Joystick component.
        /// </summary>
        public string? Joystick { get; set; }

        /// <summary>
        /// Get the override for a component by it's enum.
        /// </summary>
        [JsonIgnore]
        public string? this[PalComponents component] => component switch
        {
            PalComponents.OpenGL => OpenGL,
            PalComponents.Vulkan => Vulkan,
            PalComponents.WindowIcon => WindowIcon,
            PalComponents.MouseCursor => MouseCursor,
            PalComponents.Window => Window,
            PalComponents.Surface => Surface,
            PalComponents.Display => Display,
            PalComponents.MiceInput => MiceInput,
            PalComponents.KeyboardInput => KeyboardInput,
            PalComponents.ControllerInput => ControllerInput,
            PalComponents.Clipboard => Clipboard,
            PalComponents.Shell => Shell,
            PalComponents.Joystick => Joystick,
            _ => null
        };

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

                if (config.ExtraAssemblies?.Count > 0)
                {
                    foreach (string name in config.ExtraAssemblies)
                    {
                        try
                        {
                            Assembly.Load(name);
                        }
                        catch (Exception ex)
                        {
                            Logger?.LogError($"Could not load assembly \"{name}\": {ex}\n{ex.StackTrace}");

                            if (Debugger.IsAttached)
                                Debugger.Break();
                        }
                    }

                    ExtraAssembliesLoaded = true;
                }
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

        /// <summary>
        /// Get the driver instance for a specific backend.
        /// </summary>
        /// <param name="component">The component to get the backend for.</param>
        /// <returns>The component driver, or null if not found/implemented.</returns>
        /// <remarks>May also throw if PlatformComponents.CreateXXX throws.</remarks>
        public static IPalComponent? GetBackend(PalComponents component)
        {
            IPalComponent? driver = null;
            string? overridePath = Singleton[component];

            if (overridePath != null)
            {
                try
                {
                    Type type = Type.GetType(overridePath)
                                ?? throw new Exception($"Could not find type {overridePath}");

                    ConstructorInfo ctor = type?.GetConstructor(BindingFlags.Default, Array.Empty<Type>())
                                            ?? throw new Exception("No suitable constructor found.");

                    driver = (IPalComponent)ctor.Invoke(Array.Empty<object>());
                }
                catch (Exception ex)
                {
                    Logger?.LogError($"Could not load overridden platform driver \"{overridePath}\": {ex}");

                    if (Debugger.IsAttached)
                        Debugger.Break();
                }
            }

            // If the driver is still null, fall back.
            if (driver == null)
            {
                PlatformComponents.PreferSDL2 = Singleton.PreferSDL2;
                PlatformComponents.PreferANGLE = Singleton.PreferANGLE;
                driver = component switch {
                    PalComponents.OpenGL => PlatformComponents.CreateOpenGLComponent(),
                    // PalComponents.Vulkan => PlatformComponents.CreateVulkanComponent(),
                    PalComponents.WindowIcon => PlatformComponents.CreateIconComponent(),
                    PalComponents.MouseCursor => PlatformComponents.CreateCursorComponent(),
                    PalComponents.Window => PlatformComponents.CreateWindowComponent(),
                    PalComponents.Surface => PlatformComponents.CreateSurfaceComponent(),
                    PalComponents.Display => PlatformComponents.CreateDisplayComponent(),
                    PalComponents.MiceInput => PlatformComponents.CreateMouseComponent(),
                    PalComponents.KeyboardInput => PlatformComponents.CreateKeyboardComponent(),
                    // PalComponents.ControllerInput => PlatformComponents.CreateControllerComponent(),
                    PalComponents.Clipboard => PlatformComponents.CreateClipboardComponent(),
                    PalComponents.Shell => PlatformComponents.CreateShellComponent(),
                    PalComponents.Joystick => PlatformComponents.CreateJoystickComponent(),
                    _ => null
                };
            }

            return driver;
        }
    }
}

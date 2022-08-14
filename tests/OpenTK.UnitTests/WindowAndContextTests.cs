using System;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using Xunit;

namespace OpenTK.UnitTests
{
    public class WindowAndContextTests
    {
        [Theory]
        [InlineData(ContextProfile.Any)]
        public void Can_Create_Window_With_GL20_Context(ContextProfile contextProfile)
        {
            using var window = CreateGameWindow(contextProfile, new Version(2, 0));
        }

        [Theory]
        [InlineData(ContextProfile.Any)]
        public void Can_Create_Window_With_GL30_Context(ContextProfile contextProfile)
        {
            using var window = CreateGameWindow(contextProfile, new Version(3, 0));
        }

        [Theory]
        [InlineData(ContextProfile.Any)]
        public void Can_Create_Window_With_GL31_Context(ContextProfile contextProfile)
        {
            using var window = CreateGameWindow(contextProfile, new Version(3, 1));
        }

        [Theory]
        [InlineData(ContextProfile.Any)]
        [InlineData(ContextProfile.Compatability)]
        [InlineData(ContextProfile.Core)]
        public void Can_Create_Window_With_GL32_Context(ContextProfile contextProfile)
        {
            using var window = CreateGameWindow(contextProfile, new Version(3, 2));
        }

        [Theory]
        [InlineData(ContextProfile.Any)]
        [InlineData(ContextProfile.Compatability)]
        [InlineData(ContextProfile.Core)]
        public void Can_Create_Window_With_GL33_Context(ContextProfile contextProfile)
        {
            using var window = CreateGameWindow(contextProfile, new Version(3, 3));
        }

        [Theory]
        [InlineData(ContextProfile.Any)]
        [InlineData(ContextProfile.Compatability)]
        [InlineData(ContextProfile.Core)]
        public void Can_Create_Window_With_GL40_Context(ContextProfile contextProfile)
        {
            using var window = CreateGameWindow(contextProfile, new Version(4, 0));
        }

        [Theory]
        [InlineData(ContextProfile.Any)]
        [InlineData(ContextProfile.Compatability)]
        [InlineData(ContextProfile.Core)]
        public void Can_Create_Window_With_GL41_Context(ContextProfile contextProfile)
        {
            using var window = CreateGameWindow(contextProfile, new Version(4, 1));
        }

        [Theory]
        [InlineData(ContextProfile.Any)]
        [InlineData(ContextProfile.Compatability)]
        [InlineData(ContextProfile.Core)]
        public void Can_Create_Window_With_GL42_Context(ContextProfile contextProfile)
        {
            using var window = CreateGameWindow(contextProfile, new Version(4, 2));
        }

        [Theory]
        [InlineData(ContextProfile.Any)]
        [InlineData(ContextProfile.Compatability)]
        [InlineData(ContextProfile.Core)]
        public void Can_Create_Window_With_GL43_Context(ContextProfile contextProfile)
        {
            using var window = CreateGameWindow(contextProfile, new Version(4, 3));
        }

        [Theory]
        [InlineData(ContextProfile.Any)]
        [InlineData(ContextProfile.Compatability)]
        [InlineData(ContextProfile.Core)]
        public void Can_Create_Window_With_GL44_Context(ContextProfile contextProfile)
        {
            using var window = CreateGameWindow(contextProfile, new Version(4, 4));
        }

        [Theory]
        [InlineData(ContextProfile.Any)]
        [InlineData(ContextProfile.Compatability)]
        [InlineData(ContextProfile.Core)]
        public void Can_Create_Window_With_GL45_Context(ContextProfile contextProfile)
        {
            using var window = CreateGameWindow(contextProfile, new Version(4, 5));
        }

        [Theory]
        [InlineData(ContextProfile.Any)]
        [InlineData(ContextProfile.Compatability)]
        [InlineData(ContextProfile.Core)]
        public void Can_Create_Window_With_GL46_Context(ContextProfile contextProfile)
        {
            using var window = CreateGameWindow(contextProfile, new Version(4, 6));
        }

        private GameWindow CreateGameWindow(ContextProfile contextProfile, Version version)
        {
            var gameWindowSettings = GameWindowSettings.Default;
            var nativeWindowSettings = NativeWindowSettings.Default;
            nativeWindowSettings.Profile = contextProfile;
            nativeWindowSettings.StartVisible = false;
            nativeWindowSettings.StartFocused = false;
            nativeWindowSettings.API = ContextAPI.OpenGL;
            nativeWindowSettings.AutoLoadBindings = true;
            nativeWindowSettings.APIVersion = version;
            return new GameWindow(gameWindowSettings, nativeWindowSettings);
        }
    }
}

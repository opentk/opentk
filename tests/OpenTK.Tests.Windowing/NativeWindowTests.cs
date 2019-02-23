using System;
using System.Threading;
using OpenToolkit.Mathematics;
using OpenToolkit.Windowing.Common;
using OpenToolkit.Windowing.Desktop;
using Xunit;

namespace OpenTK.Tests.Windowing
{
    public class NativeWindowTests
    {
        [Fact]
        public void CreatingThenDisposingWindowDoesNotThrowException()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                Thread.Sleep(1);
            }
        }

        [Fact]
        public void CreatingSubsequentWindowDoesNotThrowException()
        {
            using (var window1 = new NativeWindow(NativeWindowSettings.Default))
            {
                Thread.Sleep(100);
                using (var window2 = new NativeWindow(NativeWindowSettings.Default))
                {
                    Thread.Sleep(100);
                }
            }
        }

        [Fact]
        public void TitleCanBeUpdated()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                var newTitle = $"{new Guid()}";
                window.Title = newTitle;
                Assert.Equal(newTitle, window.Title);
            }
        }

        [Fact]
        public void WindowCanBeFocussed()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                window.Focused = true;
                Assert.True(window.Focused);
            }
        }

        [Fact]
        public void WindowCanBeHidden()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                window.Visible = false;
                Assert.False(window.Visible);
            }
        }

        [Fact]
        public void CanCheckIfWindowExists()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                Assert.True(window.Exists);
            }
        }

        [Fact]
        public void CanMinimizeWindow()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                window.WindowState = WindowState.Minimized;
            }
        }

        [Fact]
        public void CanMiximizeWindow()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                window.WindowState = WindowState.Maximized;
            }
        }

        [Fact]
        public void CanFullscreenWindow()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                window.WindowState = WindowState.Fullscreen;
            }
        }

        [Fact]
        public void CanGetWindowBorderState()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                var borderState = window.WindowBorder;
            }
        }

        [Fact]
        public void CanChangeWindowBounds()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                var newBounds = new Box2(5, 6, 320, 240);
                window.Bounds = newBounds;
                var currentBounds = window.Bounds;
                Assert.Equal(newBounds.Left, currentBounds.Left);
                Assert.Equal(newBounds.Top, currentBounds.Top);
                Assert.Equal(newBounds.Width, currentBounds.Width);
                Assert.Equal(newBounds.Height, currentBounds.Height);
            }
        }

        [Fact]
        public void CanChangeWindowLocation()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                var newLocation = new Vector2(5, 6);
                window.Location = newLocation;
                var currentLocation = window.Location;
                Assert.Equal(newLocation.X, currentLocation.X);
                Assert.Equal(newLocation.Y, currentLocation.Y);
            }
        }

        [Fact]
        public void CanChangeWindowSize()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                var newSize = new Vector2(320, 240);
                window.Size = newSize;
                var currentSize = window.Size;
                Assert.Equal(newSize.X, currentSize.X);
                Assert.Equal(newSize.Y, currentSize.Y);
            }
        }

        [Fact]
        public void CanMultiThreadWindows()
        {
            // Create and start 3 threads, each of which tries to use GLFW.
            Thread[] threads = { new Thread(WindowProc), new Thread(WindowProc), new Thread(WindowProc) };
            foreach (var t in threads)
            {
                t.Start();
            }

            // Wait for all 3 threads to finish. (The order doesn't matter.)
            foreach (var t in threads)
            {
                t.Join();
            }
        }

        private static void WindowProc(object state)
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                Thread.Sleep(10);
            }
        }
    }
}

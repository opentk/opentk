using System;
using System.Drawing;
using System.Threading;
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
            using (var window = new NativeWindow())
            {
                Thread.Sleep(1);
            }
        }

        [Fact]
        public void CreatingSubsequentWindowDoesNotThrowException()
        {
            using (var window1 = new NativeWindow())
            {
                Thread.Sleep(100);
                using (var window2 = new NativeWindow())
                {
                    Thread.Sleep(100);
                }
            }
        }

        [Fact]
        public void TitleCanBeUpdated()
        {
            using (var window = new NativeWindow())
            {
                var newTitle = $"{new Guid()}";
                window.Title = newTitle;
                Assert.Equal(newTitle, window.Title);
            }
        }

        [Fact]
        public void WindowCanBeFocussed()
        {
            using (var window = new NativeWindow())
            {
                window.Focused = true;
                Assert.True(window.Focused);
            }
        }

        [Fact]
        public void WindowCanBeHidden()
        {
            using (var window = new NativeWindow())
            {
                window.Visible = false;
                Assert.False(window.Visible);
            }
        }

        [Fact]
        public void CanCheckIfWindowExists()
        {
            using (var window = new NativeWindow())
            {
                Assert.True(window.Exists);
            }
        }

        [Fact]
        public void CanMinimizeWindow()
        {
            using (var window = new NativeWindow())
            {
                window.WindowState = WindowState.Minimized;
            }
        }

        [Fact]
        public void CanMiximizeWindow()
        {
            using (var window = new NativeWindow())
            {
                window.WindowState = WindowState.Maximized;
            }
        }

        [Fact]
        public void CanFullscreenWindow()
        {
            using (var window = new NativeWindow())
            {
                window.WindowState = WindowState.Fullscreen;
            }
        }

        [Fact]
        public void CanGetWindowBorderState()
        {
            using (var window = new NativeWindow())
            {
                var borderState = window.WindowBorder;
            }
        }

        [Fact]
        public void CanChangeWindowBounds()
        {
            using (var window = new NativeWindow())
            {
                var newBounds = new Rectangle(5, 6, 320, 240);
                window.Bounds = newBounds;
                var currentBounds = window.Bounds;
                Assert.Equal(newBounds.X, currentBounds.X);
                Assert.Equal(newBounds.Y, currentBounds.Y);
                Assert.Equal(newBounds.Width, currentBounds.Width);
                Assert.Equal(newBounds.Height, currentBounds.Height);
            }
        }

        [Fact]
        public void CanChangeWindowLocation()
        {
            using (var window = new NativeWindow())
            {
                var newLocation = new Point(5, 6);
                window.Location = newLocation;
                var currentLocation = window.Location;
                Assert.Equal(newLocation.X, currentLocation.X);
                Assert.Equal(newLocation.Y, currentLocation.Y);
            }
        }

        [Fact]
        public void CanChangeWindowSize()
        {
            using (var window = new NativeWindow())
            {
                var newSize = new Size(320, 240);
                window.Size = newSize;
                var currentSize = window.Size;
                Assert.Equal(newSize.Width, currentSize.Width);
                Assert.Equal(newSize.Height, currentSize.Height);
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
            using (var window = new NativeWindow())
            {
                Thread.Sleep(10);
            }
        }
    }
}

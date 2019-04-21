using System;
using System.Threading;
using OpenToolkit.Mathematics;
using OpenToolkit.Windowing.Common;
using OpenToolkit.Windowing.Desktop;
using Xunit;
using Xunit.Abstractions;

namespace OpenTK.Tests.Windowing
{
    public class NativeWindowTests
    {
        private readonly ITestOutputHelper output;

        public NativeWindowTests(ITestOutputHelper output)
        {
            this.output = output;
        }
        
        [Fact]
        public void CreatingThenDisposingWindowDoesNotThrowException()
        {
            var window = new NativeWindow(NativeWindowSettings.Default);
            Thread.Sleep(1);
            window.Dispose();
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

        private static void TryProcessNextEvents(INativeWindow window)
        {
            if (window.IsEventDriven)
                throw new Exception();
            
            Thread.Sleep(10);
            
            for (var i = 0; i < 100; i++) // busy waiting and try to process a maximum of 100 events
            {
                window.ProcessEvents();
                Thread.Sleep(1);
            }
        }

        [Fact]
        public void TitleCanBeUpdated()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                TryProcessNextEvents(window);
                var newTitle = $"{new Guid()}";
                var testRunning = true;
                window.TitleChanged += (sender, args) => testRunning = false;
                window.Title = newTitle;
                while (testRunning)
                {
                    window.ProcessEvents();
                }

                Assert.Equal(newTitle, window.Title);
            }
        }

        [Fact]
        public void WindowCanBeHidden()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                TryProcessNextEvents(window);
                var testRunning = true;
                window.VisibleChanged += (sender, args) => testRunning = false;
                window.IsVisible = false;
                while (testRunning)
                    window.ProcessEvents();
                Assert.False(window.IsVisible);
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
                TryProcessNextEvents(window);
                window.WindowState = WindowState.Minimized;
                TryProcessNextEvents(window);
                Assert.Equal(WindowState.Minimized, window.WindowState);
            }
        }

        [Fact]
        public void CanMaximizeWindow()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                TryProcessNextEvents(window);
                window.WindowState = WindowState.Maximized;
                TryProcessNextEvents(window);
                Assert.Equal(WindowState.Maximized, window.WindowState);
            }
        }

        [Fact]
        public void CanFullscreenWindow()
        {
            using (var window = new NativeWindow(NativeWindowSettings.Default))
            {
                TryProcessNextEvents(window);
                window.WindowState = WindowState.Fullscreen;
                TryProcessNextEvents(window);
                Assert.Equal(WindowState.Fullscreen, window.WindowState);
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
                TryProcessNextEvents(window);
                bool resized = false;
                bool moved = false;
                var newBounds = new Box2(15, 46, 320, 240);
                window.Resize += (sender, args) =>
                {
                    resized = true;
                };
                window.Move += (sender, args) =>
                {
                    moved = true;
                };
                window.Bounds = newBounds;
                while(!(resized && moved))
                    window.ProcessEvents();
                
                TryProcessNextEvents(window);
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
                TryProcessNextEvents(window);
                bool testRunning = true;
                var newLocation = new Vector2(15, 36);
                window.Move += (sender, args) =>
                {
                    testRunning = false;
                    output.WriteLine("New pos: " + args.X + ", " + args.Y);
                };
                
                window.Location = newLocation;
                
                while(testRunning)
                    window.ProcessEvents();
                
                TryProcessNextEvents(window);

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
                TryProcessNextEvents(window);
                bool testRunning = true;
                var newSize = new Vector2(320, 240);
                window.Resize += (sender, args) => testRunning = false;
                
                window.Size = newSize;
                while(testRunning)
                    window.ProcessEvents();
                TryProcessNextEvents(window);
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

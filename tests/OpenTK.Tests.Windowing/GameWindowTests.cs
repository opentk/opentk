using OpenToolkit.Windowing;
using System;
using Xunit;

namespace OpenTK.Tests.Windowing
{
    public class GameWindowTests
    {
        [Fact]
        public void CreatingThenDisposingGameWindowDoesNotThrowException()
        {
            using (var engine = new GameWindow())
            {
                System.Threading.Thread.Sleep(1);
            }
            System.Threading.Thread.Sleep(1);
        }
    }
}

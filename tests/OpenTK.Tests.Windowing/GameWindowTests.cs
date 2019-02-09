using System.Threading;
using OpenToolkit.Windowing.Desktop;
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
                Thread.Sleep(1);
            }
            Thread.Sleep(1);
        }
    }
}

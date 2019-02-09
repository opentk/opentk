using System.Threading;
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

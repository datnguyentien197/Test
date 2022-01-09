using Test;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ChechNumbers c = new ChechNumbers();
            Assert.True(c.CheckNumber(10));
        }
    }
}
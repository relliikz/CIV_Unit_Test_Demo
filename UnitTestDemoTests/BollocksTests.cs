using System;
using Xunit;
using UnitTestDemo;

namespace UnitTestDemoTests
{
    public class BollocksTests
    {
        [Fact]
        public void ConstructorTest()
        {
            Bollocks b = new Bollocks(5, "bollocks1");

            Assert.Equal(5, b.bollNum);
            Assert.Equal("bollocks1", b.bollString);
        }

        [Theory]
        [InlineData(5, 5, 10)]
        public void AddToTest(int input, int addition, int expected)
        {
           Bollocks b = new Bollocks(input, "bollocks2");
            int result = b.AddTo(addition);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(25, 5, 5)]
        [InlineData(2, 2, 1)]
        [InlineData(10, 3, 3)]
         public void DivByTest(int input, int divisor, int expected)
        {
            Bollocks b = new Bollocks(input, "bollocks2");
            int result = b.DivBy(divisor);
            Assert.Equal(expected, result);
        }
        
        [Fact]
         public void DivBy_Zero_Test()
        {
            Bollocks b = new Bollocks(10, "bollocks1");
            try
            {
                b.DivBy(0);
                Assert.True(false);
            }
            catch
            {
                Assert.True(true);
            }
            
        }

        [Theory]
        [InlineData(11, 2, 1)]
        public void ModOfDivByTest(int input, int mod, int exepected)
        {
            Bollocks b = new Bollocks(input, "bollocks2");
            Assert.Equal(exepected, b.ModOfDivBy(mod));
        }
    }
}

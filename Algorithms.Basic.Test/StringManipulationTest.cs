using Xunit;

namespace Algorithms.Basic.Test
{
    public class StringManipulationTest
    {
        [Fact]
        public void ShouldReverseString()
        {
            var sut = new StringManipulation();

            var reversedString = sut.ReverseString("iman");

            Assert.Equal("nami", reversedString);
        }

        [Fact]
        public void ShouldReverseString2()
        {
            var sut = new StringManipulation();

            var reversedString = sut.ReverseString2("iman");

            Assert.Equal("nami", reversedString);
        }

        [Fact]
        public void ShouldReverseString3()
        {
            var sut = new StringManipulation();

            var reversedString = sut.ReverseString3("iman");

            Assert.Equal("nami", reversedString);
        }

        [Fact]
        public void ShouldReverseString4()
        {
            var sut = new StringManipulation();

            var reversedString = sut.ReverseString4("iman");

            Assert.Equal("nami", reversedString);
        }
    }
}

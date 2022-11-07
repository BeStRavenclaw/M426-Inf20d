using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void Determine_NotMod357_ExitSameNumberAsString()
        {
            int input = 1;
            FooBarQixDeterminer determiner = new();

            string output = determiner.Determine(input);

            Assert.Equal(input.ToString(), output);
        }
    }
}
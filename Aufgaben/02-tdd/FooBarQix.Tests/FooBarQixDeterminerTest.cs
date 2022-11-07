using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public void Determine_NotMod357_SameNumberAsString(int input)
        {
            FooBarQixDeterminer determiner = new();

            string output = determiner.Determine(input);

            Assert.Equal(input.ToString(), output);
        }

        [Theory]
        [InlineData(3,"Foo")]
        [InlineData(5,"Bar")]
        [InlineData(7,"Qix")]
        [InlineData(6,"Foo")]
        public void Determine_Mod357_FooBarOrQix(int input, string expectedOutput)
        {
            FooBarQixDeterminer determiner = new();

            string output = determiner.Determine(input);

            Assert.Equal(expectedOutput, output);
        }

        [Theory]
        [InlineData(15,"FooBar")]
        [InlineData(21,"FooQix")]
        [InlineData(35,"BarQix")]
        [InlineData(105,"FooBarQix")]
        public void Determine_ModMultible357_FooBarQixCombinations(int input, string expectedOutput)
        {
            FooBarQixDeterminer determiner = new();

            string output = determiner.Determine(input);

            Assert.Equal(expectedOutput, output);
        }
    }
}
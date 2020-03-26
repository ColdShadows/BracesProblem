using Xunit;

namespace StringEvaluator
{    
    public class StringEvaluatorTests
    {
        [Theory]
        [InlineData("{{}", false)]
        [InlineData("{{}}", true)]
        [InlineData("{[{}]}", true)]
        [InlineData("{[{]}}", false)]
        [InlineData("{d{}ssl}erw", true)]
        public void IsProperBraces_InputString_ReturnsExpectedBoolean(string bracesInput, bool expected)
        {
            var result = StringEvaluator.IsProperBraces(bracesInput);

            Assert.Equal(expected, result);
        }
    }
}

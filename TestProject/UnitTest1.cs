using BasicAlgorithmExercise;

namespace TestProject
{
    public class UnitTest1
    {
        public class AlgorithmsTests
        {
            [Fact]
            public void PrintTree_ValidHeight_DoesNotThrowException()
            {
                int height = 5;
                var ex = Record.Exception(() => Algorithms.PrintTree(height));
                Assert.Null(ex);
            }

            [Theory]
            [InlineData("I", 1)]
            [InlineData("IV", 4)]
            [InlineData("IX", 9)]
            [InlineData("LVIII", 58)]
            [InlineData("MCMXCIV", 1994)]
            public void RomanToInt_ValidRomanNumerals_ReturnsCorrectInteger(string romanNumeral, int expected)
            {
                int result = Algorithms.RomanToInt(romanNumeral);
                Assert.Equal(expected, result);
            }

            [Theory]
            [InlineData(1, "I")]
            [InlineData(4, "IV")]
            [InlineData(9, "IX")]
            [InlineData(58, "LVIII")]
            [InlineData(1994, "MCMXCIV")]
            public void IntToRoman_ValidIntegers_ReturnsCorrectRomanNumeral(int number, string expected)
            {
                string result = Algorithms.IntToRoman(number);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void GenerateFibonacci_ValidCount_ReturnsCorrectSequence()
            {
                List<int> expected = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
                List<int> result = Algorithms.GenerateFibonacci(10);
                Assert.Equal(expected, result);
            }

            [Theory]
            [InlineData("Saippuakivikauppias", true)]
            [InlineData("racecar", true)]
            [InlineData("hello", false)]
            [InlineData("A man a plan a canal Panama", true)]
            public void IsPalindrome_TestStrings_ReturnsCorrectResult(string input, bool expected)
            {
                bool result = Algorithms.IsPalindrome(input);
                Assert.Equal(expected, result);
            }
        }
    }
}
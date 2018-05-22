using Xunit;

namespace CodeWarsKata.UnitTests
{
    public class StringKataTests
    {
        private readonly StringKata stringKata;

        public StringKataTests()
        {
            stringKata = new StringKata();
        }

        [Fact]
        public void ShouldConvertToCamelCaseWithUnderscores()
        {
            Assert.Equal("theStealthWarrior", stringKata.ToCamelCase("the_stealth_warrior"));
        }

        [Fact]
        public void ShouldConvertToCamelCaseWithDashes()
        {
            Assert.Equal("TheStealthWarrior", stringKata.ToCamelCase("The-Stealth-Warrior"));
        }
    }
}

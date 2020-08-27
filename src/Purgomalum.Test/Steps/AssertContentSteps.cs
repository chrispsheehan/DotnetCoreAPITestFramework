using TechTalk.SpecFlow;
using Drivers;
using Xunit;

namespace StepDefinitions
{
    [Binding]
    public class AssertContentSteps
    {
        private readonly PurgomalumAPI _driver;

        public AssertContentSteps(PurgomalumAPI driver)
        {
            _driver = driver;
        }

        [Then(@"no asterisks are added")]
        public void ThenNoAsterisksAreAdded()
        {
            string actual = _driver.GetResult();

            const string expectedContains = "*";

            Assert.DoesNotContain(expectedContains, actual);
        }

        [Then(@"replaced with the corresponding amount of asterisks")]
        public void ThenReplacedWithTheCorrespondingAmountOfAsterisks()
        {
            string actual = _driver.GetResult();

            const string expectedContains = "*";

            Assert.Contains(expectedContains, actual);
        }        

        [Then(@"replaced profanity with the corresponding amount of (.*)")]
        public void ThenReplacedProfanityWithTheCorrespondingAmountOf(string character)
        {
            string actual = _driver.GetResult();

            string expectedContains = character;

            Assert.Contains(expectedContains, actual);
        }

        [Then(@"the string of (.*) is added")]
        public void ThenTheStringOfIsAdded(string replacementString)
        {
            string actual = _driver.GetResult();

            string expectedContains = replacementString;

            Assert.Contains(expectedContains, actual);
        }

        [Then(@"the (.*) remains unchanged")]
        public void ThenTheTextRemainsUnchanged(string text)
        {
            string actual = _driver.GetResult();

            string expected = text;

            Assert.Equal(expected, actual);
        }        

        [Then(@"profanitys are found")]
        public void ThenProfanitysAreFound()
        {
            bool actual = _driver.GetResultBool();

            Assert.True(actual);
        }

        [Then(@"no profanitys are found")]
        public void ThenNoProfanitysAreFound()
        {
            bool actual = _driver.GetResultBool();

            Assert.False(actual);
        }
    }
}

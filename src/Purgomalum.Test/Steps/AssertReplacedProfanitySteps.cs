using Purgomalum.Service;
using TechTalk.SpecFlow;
using Xunit;

namespace StepDefinitions
{
    [Binding]
    public class AssertReplacedProfanitySteps
    {
        private readonly string _processedText;

        public AssertReplacedProfanitySteps(PurgomalumReplaceService purgomalumReplaceService)
        {
            _processedText = purgomalumReplaceService.GetProcessedText();
        }

        [Then(@"no asterisks are added")]
        public void ThenNoAsterisksAreAdded()
        {
            const string expectedContains = "*";

            Assert.DoesNotContain(expectedContains, _processedText);
        }

        [Then(@"replaced with the corresponding amount of asterisks")]
        public void ThenReplacedWithTheCorrespondingAmountOfAsterisks()
        {
            const string expectedContains = "*";

            Assert.Contains(expectedContains, _processedText);
        }

        [Then(@"replaced profanity with the corresponding amount of (.*)")]
        public void ThenReplacedProfanityWithTheCorrespondingAmountOf(string character)
        {
            string expectedContains = character;

            Assert.Contains(expectedContains, _processedText);
        }

        [Then(@"the string of (.*) is added")]
        public void ThenTheStringOfIsAdded(string replacementString)
        {
            string expectedContains = replacementString;

            Assert.Contains(expectedContains, _processedText);
        }

        [Then(@"the (.*) remains unchanged")]
        public void ThenTheTextRemainsUnchanged(string text)
        {
            string expected = text;

            Assert.Equal(expected, _processedText);
        }
    }
}

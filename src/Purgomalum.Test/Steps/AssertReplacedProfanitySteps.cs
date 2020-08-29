using Purgomalum.Service;
using TechTalk.SpecFlow;
using Xunit;

namespace StepDefinitions
{
    [Binding]
    public class AssertReplacedProfanitySteps
    {
        private readonly PurgomalumReplaceAPI _purgomalumReplaceAPI;

        public AssertReplacedProfanitySteps(PurgomalumReplaceAPI purgomalumReplaceAPI)
        {
            _purgomalumReplaceAPI = purgomalumReplaceAPI;
        }

        [Then(@"no asterisks are added")]
        public void ThenNoAsterisksAreAdded()
        {
            string actual = _purgomalumReplaceAPI.GetProcessedText();;

            const string expectedContains = "*";

            Assert.DoesNotContain(expectedContains, actual);
        }

        [Then(@"replaced with the corresponding amount of asterisks")]
        public void ThenReplacedWithTheCorrespondingAmountOfAsterisks()
        {
            string actual = _purgomalumReplaceAPI.GetProcessedText();

            const string expectedContains = "*";

            Assert.Contains(expectedContains, actual);
        }

        [Then(@"replaced profanity with the corresponding amount of (.*)")]
        public void ThenReplacedProfanityWithTheCorrespondingAmountOf(string character)
        {
            string actual = _purgomalumReplaceAPI.GetProcessedText();

            string expectedContains = character;

            Assert.Contains(expectedContains, actual);
        }

        [Then(@"the string of (.*) is added")]
        public void ThenTheStringOfIsAdded(string replacementString)
        {
            string actual = _purgomalumReplaceAPI.GetProcessedText();

            string expectedContains = replacementString;

            Assert.Contains(expectedContains, actual);
        }

        [Then(@"the (.*) remains unchanged")]
        public void ThenTheTextRemainsUnchanged(string text)
        {
            string actual = _purgomalumReplaceAPI.GetProcessedText();

            string expected = text;

            Assert.Equal(expected, actual);
        }
    }
}

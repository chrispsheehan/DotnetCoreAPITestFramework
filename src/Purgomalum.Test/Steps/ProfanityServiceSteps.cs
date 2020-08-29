using Purgomalum.Service;
using TechTalk.SpecFlow;
using Xunit;

namespace StepDefinitions
{
    [Binding]
    public class ProfanityServiceSteps
    {
        private readonly PurgomalumAPI _purgomalumAPI;

        public ProfanityServiceSteps(PurgomalumAPI purgomalumAPI)
        {
            _purgomalumAPI = purgomalumAPI;
        }

        [Given(@"The profanity removing API is available")]
        public void GivenTheProfanityRemovingAPIIsAvailable()
        {
            var isAvailable = _purgomalumAPI.IsAvailable();

            Assert.True(isAvailable);
        }

        [Given(@"I am using the profanity replacement service")]
        public void GivenIAmUsingTheProfanityReplacementService()
        {
            _purgomalumAPI.SetDefaultService();
        }

        [Given(@"I am using the profanity character replacement service with (.*)")]
        public void GivenIAmUsingTheProfanityCharacterReplacementServiceWith(string replacementCharacter)
        {
            _purgomalumAPI.SetCharacterReplacementService(replacementCharacter);
        }

        [Given(@"I am using the profanity string replacement service with (.*)")]
        public void GivenIAmUsingTheProfanityStringReplacementServiceWith(string replacementString)
        {
            _purgomalumAPI.SetStringReplacementService(replacementString);
        }

        [Given(@"I am using the contains profanity service")]
        public void GivenIAmUsingTheContainsProfanityService()
        {
            _purgomalumAPI.SetContainsService();
        }
    }
}

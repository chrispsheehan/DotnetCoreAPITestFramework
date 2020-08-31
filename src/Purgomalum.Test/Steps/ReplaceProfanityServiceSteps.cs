using Purgomalum.Service;
using TechTalk.SpecFlow;

namespace StepDefinitions
{
    [Binding]
    public class ReplaceProfanityServiceSteps
    {
        private readonly PurgomalumReplaceService _purgomalumReplaceService;

        public ReplaceProfanityServiceSteps(PurgomalumReplaceService purgomalumReplaceService)
        {
            _purgomalumReplaceService = purgomalumReplaceService;
        }

        [When(@"I replace profanitys in the content")]
        public void WhenIReplaceProfanitysInTheContent()
        {
            _purgomalumReplaceService.ProcessText();
        }

        [Given(@"I am using the profanity replacement service")]
        public void GivenIAmUsingTheProfanityReplacementService()
        {
            _purgomalumReplaceService.SetDefaultService();
        }

        [Given(@"I am using the profanity character replacement service with (.*)")]
        public void GivenIAmUsingTheProfanityCharacterReplacementServiceWith(string replacementCharacter)
        {
            _purgomalumReplaceService.SetCharacterReplacementService(replacementCharacter);
        }

        [Given(@"I am using the profanity string replacement service with (.*)")]
        public void GivenIAmUsingTheProfanityStringReplacementServiceWith(string replacementString)
        {
            _purgomalumReplaceService.SetStringReplacementService(replacementString);
        }
    }
}
using TechTalk.SpecFlow;
using Purgomalum.Service;

namespace StepDefinitions
{
    [Binding]
    public class ContainsProfanityServiceSteps
    {
        private readonly PurgomalumContainsService _purgomalumContainsService;

        public ContainsProfanityServiceSteps(PurgomalumContainsService purgomalumContainsService)
        {
            _purgomalumContainsService = purgomalumContainsService;
        }

        [Given(@"I am using the contains profanity service")]
        public void GivenIAmUsingTheContainsProfanityService()
        {
            _purgomalumContainsService.SetContainsService();
        }

        [When(@"I check the content for profanitys")]
        public void WhenICheckTheContentForProfanitys()
        {
            _purgomalumContainsService.ProcessText();
        }
    }
}

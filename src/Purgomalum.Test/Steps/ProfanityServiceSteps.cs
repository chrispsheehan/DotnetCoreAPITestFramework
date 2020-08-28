using PurgomalumService;
using TechTalk.SpecFlow;
using Xunit;

namespace StepDefinitions
{
    [Binding]
    public class ProfanityServiceSteps
    {
        private readonly PurgomalumAPI _prgomalumAPI;

        public ProfanityServiceSteps(PurgomalumAPI prgomalumAPI)
        {
            _prgomalumAPI = prgomalumAPI;
        }

        [Given(@"The profanity removing API is available")]
        public void GivenTheProfanityRemovingAPIIsAvailable()
        {
            var isAvailable = _prgomalumAPI.IsAvailable();

            Assert.True(isAvailable);
        }
    }
}

using Purgomalum.Service;
using TechTalk.SpecFlow;
using Xunit;

namespace StepDefinitions
{
    [Binding]
    public class ProfanityServiceStatusSteps
    {
        private readonly PurgomalumAPI _purgomalumAPI;

        public ProfanityServiceStatusSteps(PurgomalumAPI purgomalumAPI)
        {
            _purgomalumAPI = purgomalumAPI;
        }

        [Given(@"The profanity removing API is available")]
        public void GivenTheProfanityRemovingAPIIsAvailable()
        {
            var isAvailable = _purgomalumAPI.IsAvailable();

            Assert.True(isAvailable);
        }
    }
}

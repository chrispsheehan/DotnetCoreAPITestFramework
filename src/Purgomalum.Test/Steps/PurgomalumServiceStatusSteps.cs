using Purgomalum.Service;
using TechTalk.SpecFlow;
using Xunit;

namespace StepDefinitions
{
    [Binding]
    public class ProfanityServiceStatusSteps
    {
        private readonly PurgomalumServiceStatus _purgomalumServiceStatus;

        public ProfanityServiceStatusSteps(PurgomalumServiceStatus purgomalumServiceStatus)
        {
            _purgomalumServiceStatus = purgomalumServiceStatus;
        }

        [Given(@"The profanity removing API is available")]
        public void GivenTheProfanityRemovingAPIIsAvailable()
        {
            var isAvailable = _purgomalumServiceStatus.IsAvailable();

            Assert.True(isAvailable);
        }
    }
}

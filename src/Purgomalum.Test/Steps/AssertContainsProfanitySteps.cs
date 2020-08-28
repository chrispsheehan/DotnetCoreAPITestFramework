using TechTalk.SpecFlow;
using Drivers;
using Xunit;

namespace StepDefinitions
{
    [Binding]
    public class AssertContainsProfanitySteps
    {
        private readonly PurgomalumContainsAPI _purgomalumContainsAPI;

        public AssertContainsProfanitySteps(PurgomalumContainsAPI purgomalumContainsAPI)
        {
            _purgomalumContainsAPI = purgomalumContainsAPI;
        }

        [Then(@"profanitys are found")]
        public void ThenProfanitysAreFound()
        {
            bool actual = _purgomalumContainsAPI.GetContainsBool();

            Assert.True(actual);
        }

        [Then(@"no profanitys are found")]
        public void ThenNoProfanitysAreFound()
        {
            bool actual = _purgomalumContainsAPI.GetContainsBool();;

            Assert.False(actual);
        }
    }
}

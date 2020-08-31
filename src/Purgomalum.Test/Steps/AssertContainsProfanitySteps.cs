using Purgomalum.Service;
using TechTalk.SpecFlow;
using Xunit;

namespace StepDefinitions
{
    [Binding]
    public class AssertContainsProfanitySteps
    {
        private readonly bool _profanitysFound;

        public AssertContainsProfanitySteps(PurgomalumContainsService purgomalumContainsService)
        {
            _profanitysFound = purgomalumContainsService.GetContainsBool();
        }

        [Then(@"profanitys are found")]
        public void ThenProfanitysAreFound()
        {
            Assert.True(_profanitysFound);
        }

        [Then(@"no profanitys are found")]
        public void ThenNoProfanitysAreFound()
        {
            Assert.False(_profanitysFound);
        }
    }
}

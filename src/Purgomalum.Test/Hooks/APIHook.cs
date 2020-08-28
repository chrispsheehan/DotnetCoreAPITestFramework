using TechTalk.SpecFlow;
using BoDi;
using Object;
using PurgomalumService;

namespace Hooks
{
    [Binding]
    public class APIHooks
    {
        [BeforeScenario]
        public void BeforeScenario(IObjectContainer objectContainer)
        {
            objectContainer.RegisterInstanceAs(new Message());

            objectContainer.RegisterInstanceAs(new PurgomalumAPI(APIConstants.APIBaseUrl, APIConstants.Endpoint));
        }
    }
}
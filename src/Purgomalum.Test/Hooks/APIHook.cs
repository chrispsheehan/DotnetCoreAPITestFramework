using TechTalk.SpecFlow;
using BoDi;
using Drivers;
using Object;

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
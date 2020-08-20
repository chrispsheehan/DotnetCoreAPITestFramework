using System;
using TechTalk.SpecFlow;
using BoDi;
using Drivers;

namespace Hooks
{
    [Binding]
    public class APIHooks
    {
        [BeforeScenario]
        public void BeforeScenario(IObjectContainer objectContainer)
        {
            objectContainer.RegisterInstanceAs(new APIDriver());
        }

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}
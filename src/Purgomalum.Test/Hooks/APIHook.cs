using TechTalk.SpecFlow;
using BoDi;
using Object;
using Purgomulum.Settings;
using Purgomalum.Service;

namespace Hooks
{
    [Binding]
    public class APIHooks
    {
        public static PurgomalumSettings PurgomalumSettings { get; private set; }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            PurgomalumSettings = PurgomalumConfiguation.GetSettings();
        }

        [BeforeScenario]
        public void BeforeScenario(IObjectContainer objectContainer)
        {
            objectContainer.RegisterInstanceAs(new Message());

            objectContainer.RegisterInstanceAs(new PurgomalumAPI(PurgomalumSettings));
        }
    }
}
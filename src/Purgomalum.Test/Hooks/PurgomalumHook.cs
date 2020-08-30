using TechTalk.SpecFlow;
using BoDi;
using Purgomulum.Settings;

namespace Hooks
{
    [Binding]
    public static class PurgomalumHook
    {
        [BeforeTestRun]
        public static void BeforeTestRun(IObjectContainer objectContainer)
        {
            objectContainer.RegisterInstanceAs(PurgomalumConfiguation.GetSettings());
        }
    }
}
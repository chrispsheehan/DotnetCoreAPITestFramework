using TechTalk.SpecFlow;
using BoDi;
using Purgomalum.Service.Object;
using Framework.Settings;

namespace Purgomalum.Test.Hooks
{
    [Binding]
    public static class PurgomalumHook
    {
        [BeforeTestRun]
        public static void BeforeTestRun(IObjectContainer objectContainer)
        {
            objectContainer.RegisterInstanceAs(SettingsConfiguation.Build<PurgomalumSettings>());
        }
    }
}
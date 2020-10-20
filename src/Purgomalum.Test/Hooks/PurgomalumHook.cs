using TechTalk.SpecFlow;
using BoDi;
using Purgomalum.Service.Object;
using Framework.Settings;

namespace Purgomalum.Test.Hooks
{
    [Binding]
    public static class PurgomalumHook
    {
        public static PurgomalumSettings AppSettings;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            AppSettings = SettingsConfiguation.Build<PurgomalumSettings>();
        }

        [BeforeFeature]
        public static void BeforeFeature(IObjectContainer objectContainer)
        {
            objectContainer.RegisterInstanceAs(AppSettings);
        }
    }
}
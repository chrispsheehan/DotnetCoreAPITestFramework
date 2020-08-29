using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Purgomulum.Settings
{
    public static class PurgomalumConfiguation
    {
        private const string SettingsFile = "PurgomalumSettings.json";

        public static PurgomalumSettings GetSettings()
        {
            var configRoot = BuildConfig();

            return new PurgomalumSettings
            {
                BaseUrl = configRoot.GetAppSetting("BaseUrl"),
                Endpoint = configRoot.GetAppSetting("Endpoint"),
                TextProcessParam = configRoot.GetAppSetting("TextProcessParam"),
                ContainsProfanityService  = configRoot.GetAppSetting("ContainsProfanityService"),
                ReplaceCharacterService = configRoot.GetAppSetting("ReplaceCharacterService"),
                ReplaceStringService = configRoot.GetAppSetting("ReplaceStringService"),
                DefaultDataType = configRoot.GetAppSetting("DefaultDataType")
            };
        }

        private static IConfigurationRoot BuildConfig()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(SettingsFile)
                .Build();
        }

        private static string GetAppSetting(this IConfigurationRoot config, string settingName)
        {
            string content = config[settingName];

            if (!string.IsNullOrEmpty(content))
            {
                return content;
            }
            throw new InvalidOperationException($"Could not read app setting for {settingName}");
        }
    }
}
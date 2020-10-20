using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Framework.Settings
{
    public static class SettingsConfiguation
    {
        public static T GetSettings<T>(string settingsFileName)
        {
            return BuildConfig(settingsFileName).Get<T>();
        }

        private static IConfigurationRoot BuildConfig(string settingsFileName)
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(settingsFileName)
                .Build();
        }
    }
}
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Framework.Settings
{
    public static class SettingsConfiguation
    {
        public static T Build<T>(string settingsFileName)
        {
            return BuildConfig(settingsFileName).Get<T>();
        }

        private static IConfigurationRoot BuildConfig(string settingsFileName)
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(settingsFileName)
                .AddEnvironmentVariables()                
                .Build();
        }
    }
}
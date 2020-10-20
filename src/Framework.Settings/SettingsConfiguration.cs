using System.IO;
using Microsoft.Extensions.Configuration;

namespace Framework.Settings
{
    public static class SettingsConfiguation
    {
        public static T Build<T>()
        {
            return BuildConfig(GetConfigFile()).Get<T>();
        }

        private static IConfigurationRoot BuildConfig(string settingsFileName)
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(settingsFileName)
                .AddEnvironmentVariables()                
                .Build();
        }

        private static string GetConfigFile()
        {
            foreach(string file in Directory.GetFiles(Directory.GetCurrentDirectory(), "*TestSettings.json"))
            {
                return Path.GetFileName(file);
            }

            return null;
        }        
    }
}
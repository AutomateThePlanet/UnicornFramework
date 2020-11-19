using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Unicorn.Configuration
{
    public class ConfigurationService
    {
        private static readonly IConfigurationRoot s_configurationRoot;

        static ConfigurationService()
        {
            s_configurationRoot = InitializeConfiguration();
        }

        public static TSection GetSection<TSection>()
            where TSection : class, new()
        {
            string sectionName = typeof(TSection).Name.MakeFirstLetterToLower();
            return s_configurationRoot.GetSection(sectionName).Get<TSection>();
        }

        private static IConfigurationRoot InitializeConfiguration()
        {
            var filesInExecutionDir = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            var settingsFile = filesInExecutionDir.FirstOrDefault(x => x.Contains("testFrameworkSettings") && x.EndsWith(".json"));
            var builder = new ConfigurationBuilder();
            if (File.Exists(settingsFile))
            {
                builder.AddJsonFile(settingsFile, optional: true, reloadOnChange: true);
            }

            return builder.Build();
        }
    }
}

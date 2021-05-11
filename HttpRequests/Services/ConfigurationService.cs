using System.IO;
using Newtonsoft.Json;

namespace HttpRequests.Services
{
    public class ConfigurationService
    {
        private string _configurationPath;

        public ConfigurationService()
        {
            _configurationPath = "configuration.json";
        }

        public Configuration ReadConfig()
        {
            var configContent = File.ReadAllText(_configurationPath);
            var config = JsonConvert.DeserializeObject<Configuration>(configContent);
            return config;
        }
    }
}

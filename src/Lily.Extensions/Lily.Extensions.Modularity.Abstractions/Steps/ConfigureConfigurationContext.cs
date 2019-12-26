using Microsoft.Extensions.Configuration;

namespace Honeywell.Infra.Core.Modular.Steps
{
    public class ConfigureConfigurationContext
    {
        public IConfigurationBuilder ConfigurationBuilder { get; }

        public ConfigureConfigurationContext(IConfigurationBuilder configurationBuilder)
        {
            ConfigurationBuilder = configurationBuilder;
        }
    }
}

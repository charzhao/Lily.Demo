using Microsoft.Extensions.DependencyInjection;

namespace Honeywell.Infra.Core.Modular.Steps
{
    public class ConfigureServicesContext
    {
        public IServiceCollection Services { get; }

        public ConfigureServicesContext(IServiceCollection services)
        {
            Services = services;
        }
    }
}

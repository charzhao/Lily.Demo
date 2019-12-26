using Honeywell.Infra.Core.Modular.Steps;

namespace Lily.Extensions.Modularity.Abstractions
{
    public interface IModule
    {
        void ConfigureConfiguration(ConfigureConfigurationContext context)
        {
           
        }
        void ConfigureServices(ConfigureServicesContext context)
        {

        }

        void ApplicationStart(ApplicationStartContext context)
        {

        }

    }
}

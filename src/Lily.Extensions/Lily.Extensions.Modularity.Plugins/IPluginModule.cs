using Honeywell.Infra.Core.Modular.Steps;
using Lily.Extensions.Modularity.Abstractions;
using System;

namespace Lily.Extensions.Modularity.Plugins
{
    public interface IPluginModule: IModule
    {
        IServiceProvider ConfigureServices(ConfigureServicesContext context);
    }
}

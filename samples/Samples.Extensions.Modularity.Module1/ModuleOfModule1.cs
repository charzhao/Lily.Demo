using Honeywell.Infra.Core.Modular.Steps;
using Lily.Extensions.Modularity.Abstractions;
using System;

namespace Samples.Extensions.Modularity.Module1
{
    public class ModuleOfModule1: IModule
    {
        void IModule.ConfigureConfiguration(ConfigureConfigurationContext context)
        {
            int i = 1;
        }
    }
}

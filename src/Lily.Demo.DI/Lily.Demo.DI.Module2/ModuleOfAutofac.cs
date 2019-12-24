using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Lily.Demo.DI.Module2.Imp;
using Lily.Demo.DI.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace Lily.Demo.DI.Module2
{
    public class ModuleOfAutofac : IModule
    {
        public IServiceProvider ConfigureServices(IServiceCollection serviceCollection)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<AutofacImp>().As<IAutofacImp>();

            containerBuilder.Populate(serviceCollection);
            var container = containerBuilder.Build();
            var serviceProvider = new AutofacServiceProvider(container);
            return serviceProvider;
        }
    }
}

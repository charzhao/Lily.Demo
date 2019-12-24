using System;
using System.ComponentModel;
using Lily.Demo.DI.Module1.Imp;
using Lily.Demo.DI.Shared;
using Microsoft.Extensions.DependencyInjection;
using Unity;
using Unity.Microsoft.DependencyInjection;

namespace Lily.Demo.DI.Module1
{
    public class ModuleOfUnity: IModule
    {
        public IServiceProvider ConfigureServices(IServiceCollection serviceCollection)
        {
            IUnityContainer containerBuilder = new UnityContainer();
            containerBuilder.RegisterType<IUnityImp, UnityImp>();

            var serviceProvider= serviceCollection.BuildServiceProvider(containerBuilder);
            return serviceProvider;
        }
    }
}

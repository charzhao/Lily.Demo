using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Lily.Demo.DI.Imp;
using Lily.Demo.DI.Module1;
using Lily.Demo.DI.Module1.Imp;
using Lily.Demo.DI.Module2;
using Lily.Demo.DI.Module2.Imp;
using Microsoft.Extensions.DependencyInjection;

namespace Lily.Demo.DI
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection serviceCollection=new ServiceCollection();
            serviceCollection.AddSingleton<IMain,Main>();
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var moduleOfUnity = new ModuleOfUnity();
            var unityServiceProvider = moduleOfUnity.ConfigureServices(serviceCollection);

            var moduleOfAutofac = new ModuleOfAutofac();
            var autofacServiceProvider = moduleOfAutofac.ConfigureServices(serviceCollection);

            var charProviderparams = new List<IServiceProvider>
            {
                serviceProvider,
                unityServiceProvider,
                autofacServiceProvider
            };
            var charServiceProvider=new CharServiceProvider(charProviderparams.ToArray());

           var main= charServiceProvider.GetService<IMain>();
           var unityImp = charServiceProvider.GetService<IUnityImp>();
           var autofacImp = charServiceProvider.GetService<IAutofacImp>();
           int i = 1;
        }
    }
}

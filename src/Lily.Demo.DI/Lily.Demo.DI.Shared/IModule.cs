using System;
using System.ComponentModel.Design;
using Microsoft.Extensions.DependencyInjection;

namespace Lily.Demo.DI.Shared
{
    public interface IModule
    {
        IServiceProvider ConfigureServices(IServiceCollection serviceCollection);
    }
}

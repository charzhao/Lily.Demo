using System;
using Microsoft.AspNetCore.Builder;

namespace Lily.Extensions.Modularity.Plugins.AspNetCore
{
    public class WebAppInitContext
    {
        public IServiceProvider ServiceProvider { get; set; }

        public IApplicationBuilder ApplicationBuilder { get; set; }

        public WebAppInitContext(IServiceProvider serviceProvider, IApplicationBuilder applicationBuilder)
        {
            ServiceProvider = serviceProvider;
            ApplicationBuilder = applicationBuilder;
        }
    }
}

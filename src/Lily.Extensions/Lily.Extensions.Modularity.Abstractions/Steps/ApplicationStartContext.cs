using System;

namespace Honeywell.Infra.Core.Modular.Steps
{
    public class ApplicationStartContext
    {
        public IServiceProvider ServiceProvider { get;}

        public ApplicationStartContext(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }
    }
}

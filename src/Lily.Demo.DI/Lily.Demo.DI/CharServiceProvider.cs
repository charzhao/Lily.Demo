using System;
using Microsoft.Extensions.DependencyInjection;

namespace Lily.Demo.DI
{
    public class CharServiceProvider: IServiceProvider, ISupportRequiredService
    {
        private readonly IServiceProvider[] _serviceProviders;
        public CharServiceProvider(params IServiceProvider[] serviceProviders)
        {
            _serviceProviders = serviceProviders;
        }

        #region
        public object GetService(Type serviceType)
        {
            foreach (var serviceProvider in _serviceProviders)
            {
                var a =serviceProvider.GetService(serviceType);
                if (a != null)
                {
                    return a;
                }
            }

            return null;
        }
        #endregion

        #region ISupportRequiredService
        public object GetRequiredService(Type serviceType)
        {
            foreach (var serviceProvider in _serviceProviders)
            {
                var a = serviceProvider.GetRequiredService(serviceType);
                if (a != null)
                {
                    return a;
                }
            }
            throw  new InvalidOperationException(serviceType.ToString()+" failed to resolve");
        }
        #endregion
    }
}

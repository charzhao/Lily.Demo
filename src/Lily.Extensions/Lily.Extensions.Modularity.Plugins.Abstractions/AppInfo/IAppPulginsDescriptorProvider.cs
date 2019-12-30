using System;
using System.Collections.Generic;
using System.Text;

namespace Lily.Extensions.Modularity.Plugins.Abstractions.AppInfo
{
    public interface IAppPulginsDescriptorProvider
    {
    }
    public class EmptyAppPulginsDescriptorProvider : IAppPulginsDescriptorProvider
    {
        public IList<AppPluginsDescriptor> Collect()
        {
            IList<AppPluginsDescriptor> pluginDescriptors = new List<AppPluginsDescriptor>();
            return pluginDescriptors;
        }
    }
}

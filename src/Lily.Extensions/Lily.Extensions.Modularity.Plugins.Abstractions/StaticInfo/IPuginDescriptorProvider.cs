using Lily.Extensions.Modularity.Plugins.Abstractions.StaticInfo;
using System;
using System.Collections.Generic;

namespace Lily.Extensions.Modularity.Plugins.Abstractions
{
    public interface IPuginDescriptorProvider
    {
        IList<PluginDescriptor> Collect();
    }

    public class FolderPuginDescriptorProvider : IPuginDescriptorProvider
    {
        private readonly string _folder;
        public FolderPuginDescriptorProvider(string folder)
        {
            _folder = folder;
        }
        public IList<PluginDescriptor> Collect()
        {
            IList<PluginDescriptor> pluginDescriptors = new List<PluginDescriptor>();
            return pluginDescriptors;
        }
    }
    public class EmptyPuginDescriptorProvider : IPuginDescriptorProvider
    {
        public IList<PluginDescriptor> Collect()
        {
            IList<PluginDescriptor> pluginDescriptors = new List<PluginDescriptor>();
            return pluginDescriptors;
        }
    }
}

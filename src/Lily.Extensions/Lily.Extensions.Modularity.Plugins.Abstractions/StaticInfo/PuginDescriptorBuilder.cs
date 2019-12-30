using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Lily.Extensions.Modularity.Plugins.Abstractions.StaticInfo
{
    public class PuginDescriptorBuilder
    {
        private IList<PluginDescriptor> _pluginDescriptors = new List<PluginDescriptor>();
        private PluginDescriptorOptions _pluginDescriptorOptions;
        public PuginDescriptorBuilder(PluginDescriptorOptions pluginDescriptorOptions)
        {
            _pluginDescriptorOptions = pluginDescriptorOptions;
        }

        public void Use(Action<PluginDescriptorOptions> pluginDescriptorOptions)
        {
            
        }

        public IPuginDescriptorProvider Build()
        {
            return _pluginDescriptorOptions.PuginDescriptorProvider;
        }

    }

}

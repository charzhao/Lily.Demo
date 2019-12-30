using System;
using System.Collections.Generic;
using System.Text;

namespace Lily.Extensions.Modularity.Plugins.Abstractions.StaticInfo
{
    public class PluginDescriptorOptions
    {
        public IPuginDescriptorProvider PuginDescriptorProvider { get; set; } = new EmptyPuginDescriptorProvider();
    }
}

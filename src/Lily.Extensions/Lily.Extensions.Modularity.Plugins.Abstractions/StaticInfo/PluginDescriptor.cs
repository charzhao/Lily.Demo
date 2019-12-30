using System;
using System.Collections.Generic;
using System.Text;

namespace Lily.Extensions.Modularity.Plugins.Abstractions.StaticInfo
{
    public class PluginDescriptor
    {
        public string Name { get; private set; }
        public string FriendlyName { get; private set; }
        public string Version { get; private set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string EntryAssemblyName { get; private set; }
        public IList<string> PluginsDependsOn { get; set; }
        public IList<string> DllsNeedActiveLoad { get; set; }

    }
}

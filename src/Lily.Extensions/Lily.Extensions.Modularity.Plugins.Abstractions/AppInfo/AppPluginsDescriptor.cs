using System;
using System.Collections.Generic;
using System.Text;

namespace Lily.Extensions.Modularity.Plugins.Abstractions.AppInfo
{
    public class AppPluginsDescriptor
    {
        public string Name { get; private set; }
        public bool IsEnabled { get; set; }
    }
}

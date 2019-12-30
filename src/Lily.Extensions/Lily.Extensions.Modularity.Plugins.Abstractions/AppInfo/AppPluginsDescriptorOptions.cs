using System;
using System.Collections.Generic;
using System.Text;

namespace Lily.Extensions.Modularity.Plugins.Abstractions.AppInfo
{
    public class AppPluginsDescriptorOptions
    {
        public IAppPulginsDescriptorProvider AppPulginsDescriptorProvider { get; set; } = new EmptyAppPulginsDescriptorProvider();
    }
}

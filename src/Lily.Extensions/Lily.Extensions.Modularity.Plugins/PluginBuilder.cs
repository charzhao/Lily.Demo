using System;
using System.Collections.Generic;
using System.Text;

namespace Lily.Extensions.Modularity.Plugins
{
    public class PluginBuilder
    {
        private List<Action<PuginDescriptorBuilder>> _configurePuginDescriptorActions = new List<Action<PuginDescriptorBuilder>>();
        public PluginBuilder ConfigurePuginDescriptorActions(Action<PuginDescriptorBuilder> configureDelegate)
        {
            return this;
        }

        public PluginBuilder Build()
        {
            return this;
        }
}

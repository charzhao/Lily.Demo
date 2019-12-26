using Lily.Extensions.Modularity.Abstractions;
using Samples.Extensions.Modularity.Module1;
using System;

namespace Samples.Extensions.Modularity.Host.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IModule module = new ModuleOfModule1();
            module.ConfigureConfiguration(null);


            Console.WriteLine("Hello World!");
        }
    }
}

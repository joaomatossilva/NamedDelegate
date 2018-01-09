using System;
using Autofac;

namespace NamedDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = BuildContainer();

            var service = container.Resolve<SomeService>();
            service.Execute("A");
            service.Execute("B");
            service.Execute("C");
        }

        static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SomeService>();
            builder.RegisterType<TheActualNamedDelegate>();
            builder.RegisterType<StrategyA>().Named<IStrategy>("A");
            builder.RegisterType<StrategyDefault>().AsImplementedInterfaces();
            builder.RegisterType<StrategyB>().Named<IStrategy>("B");
            return builder.Build();
        }
    }
}

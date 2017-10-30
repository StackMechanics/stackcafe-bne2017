﻿using Autofac;
using Autofac.Builder;
using StackMechanics.Common.AppDomainScanner;

namespace StackMechanics.Waiter
{
    public static class IoC
    {
        public static IContainer LetThereBeIoC(ContainerBuildOptions containerBuildOptions = ContainerBuildOptions.None)
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(AppDomainScanner.MyAssemblies);
            return builder.Build(containerBuildOptions);
        }
    }
}
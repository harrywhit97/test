using EFBasics.Data;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EFBasics.IoC
{

    public static class IoC
    {
        public static ApplicationDbContext ApplicationDbContext => IoCContainer.Provider.GetService<ApplicationDbContext>();
    }

    public static class IoCContainer
    {
        public static IServiceProvider Provider { get; set; }
    }
}

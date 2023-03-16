using Microsoft.Extensions.DependencyInjection;
using System;

namespace OrderService.Extensions
{
    public static class ServiceScopeExtensions
    {
        public static IServiceScope CreateScope(this IServiceProvider provider)
        {
            return provider.GetRequiredService<IServiceScopeFactory>().CreateScope();
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using System;

namespace LoginService.Extensions
{
    public static class ServiceScopeExtensions
    {
        public static IServiceScope CreateScope(this IServiceProvider provider)
        {
            return provider.GetRequiredService<IServiceScopeFactory>().CreateScope();
        }
    }
}

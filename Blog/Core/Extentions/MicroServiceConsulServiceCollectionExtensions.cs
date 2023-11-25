using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extentions
{
    public static class MicroServiceConsulServiceCollectionExtensions
    {
        
        public static IServiceCollection AddConsulRegistry(this IServiceCollection services,IConfiguration configuration)
        {
            //1.加载consul服务配置
            services.Configure<ServiceRegistryConfig>(configuration.GetSection("ConsulRegistry"));
            services.AddSingleton<IServiceRegistry, ConsulServiceRegistry>();
            return services;
        }
        public static IServiceCollection AddConsulDiscovery(IServiceCollection services,IConfiguration configuration)
        {
            services.Configure<ServiceDiscoveryConfig>(configuration.GetSection("ConsulRegistry"));
            services.AddSingleton<IServiceDiscovery, ConsulDiscoveryService>();
            return services;
        }
    }
}

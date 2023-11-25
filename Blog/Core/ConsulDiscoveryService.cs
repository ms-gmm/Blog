using Consul;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ConsulDiscoveryService : IServiceDiscovery
    {
        private readonly IConfiguration _configuration;
        public ConsulDiscoveryService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IList<ServiceUrl>> Discovery(string serviceName)
        {
            ServiceDiscoveryConfig serviceDiscoveryConfig =new ServiceDiscoveryConfig {RegistryAddress= _configuration.GetSection("ConsulDiscovery").ToString() };
            //消费 
            var consulCLient = new ConsulClient(cfg =>
            {
                cfg.Address = new Uri(serviceDiscoveryConfig.RegistryAddress);//consul地址
            });
            var queryResult = await consulCLient.Catalog.Service(serviceName);

            var list = new List<ServiceUrl>();

            foreach (var item in queryResult.Response)
            {
                list.Add(new ServiceUrl { Uri= $"{item.Address};{item.ServicePort}"});
            }
            return list;
        }
    }
}

using Consul;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class ConsulServiceRegistry : IServiceRegistry
    {
       

        public void Registry(ServiceRegistryConfig serviceNode)
        {
            var consulClient = new ConsulClient(configuration =>
            {
                configuration.Address = new Uri(serviceNode.RegistryAddress);
            });
            //2.获取服务内部地址

            //3.创建consul服务注册对象
            var registration = new AgentServiceRegistration()
            {
                ID = serviceNode.Id,
                Name = serviceNode.Name,
                Address = serviceNode.Address,
                Port = serviceNode.Port,
                Tags = serviceNode.Tags  
            };
            //4.注册服务
            consulClient.Agent.ServiceRegister(registration).Wait();
            consulClient.Dispose();
        }

        public void DeRegistry(ServiceRegistryConfig serviceNode)
        {
            var consulClient = new ConsulClient(cfg =>
              {
                  cfg.Address =new Uri( serviceNode.Address);
              });
            consulClient.Agent.ServiceDeregister(serviceNode.Id);

            consulClient.Dispose();
        }
    }
}

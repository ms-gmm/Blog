using Consul;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace Blog.Api
{
    public class ConsulHostedService : IHostedService
    {
        private readonly IConsulClient _consulClient;

        public ConsulHostedService(IConsulClient consulClient)
        {
            _consulClient = consulClient;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            // 注册服务到Consul
            var registration = new AgentServiceRegistration()
            {
                ID = "unique-service-id",
                Name = "smallparcel",
                Address = "localhost",
                Port = 5000, // 你的应用程序端口
                Check = new AgentServiceCheck()
                {
                    HTTP = "http://localhost:5000/api/health/CheckHealth", // 健康检查的URL
                    Interval = TimeSpan.FromSeconds(10),
                    Timeout = TimeSpan.FromSeconds(5)
                }
            };

            await _consulClient.Agent.ServiceRegister(registration, cancellationToken);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            // 注销服务
            await _consulClient.Agent.ServiceDeregister("unique-service-id", cancellationToken);
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Hosting.Server.Features;
using System.Linq;

namespace Core.Extentions
{
   public static class MicroServiceConsulApplicationBuliderExtentions
    {

        public static IApplicationBuilder UseConsulRegistry(this IApplicationBuilder app)
        {
            //1.从IOC容器中获取Consule服务注册配置
             var serviceNode = app.ApplicationServices.GetService<IOptions<ServiceRegistryConfig>>().Value;
            //2.获取应用程序生命周期
            var lifetime = app.ApplicationServices.GetService<IHostApplicationLifetime>();

            var sp = app.ApplicationServices;

            var fs = sp.GetService<IFeatureCollection>();
            //2.1获取服务注册实例
            var servicRegistry = app.ApplicationServices.GetRequiredService<IServiceRegistry>();

            //3.获取服务地址
            var features = app.Properties["server.Features"] as FeatureCollection;
            var address = features.Get<IServerAddressesFeature>().Addresses.First();
            var uri = new Uri(address);
            //4.注册服务
            serviceNode.Id = Guid.NewGuid().ToString();
            serviceNode.Address = $"{uri.Scheme}://{uri.Host}";
            serviceNode.Port = uri.Port;
            servicRegistry.Registry(serviceNode);
            //5.服务器关闭时注销服务
            lifetime.ApplicationStopping.Register(() =>
            {
                servicRegistry.DeRegistry(serviceNode);
            });
            return app;
        }
    }
}

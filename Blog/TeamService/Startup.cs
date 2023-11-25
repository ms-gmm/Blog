using Consul;
using Core.Extentions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamService.Repository;

namespace TeamService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var conn = Configuration.GetConnectionString("mysql");
            services.AddDbContextPool<MyDb>(option => option.UseMySql(conn, new MariaDbServerVersion(new Version(5, 5, 68)), b => b.UseQuerySplittingBehavior(QuerySplittingBehavior.SingleQuery)));

            services.AddScoped<TeamDao>();
            services.AddControllers();

            services.AddConsulRegistry(Configuration);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TeamService", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TeamService v1"));
            }

            #region 注册consul
            //var consulClient = new ConsulClient(configuration =>
            //      {
            //          configuration.Address = new Uri("http://localhost:8500");
            //      });
            ////2.获取服务内部地址

            ////3.创建consul服务注册对象
            //var registration = new AgentServiceRegistration()
            //{
            //    ID = Guid.NewGuid().ToString(),
            //    Name = "teamservice",
            //    Address = "http://localhost",
            //    Port = 5001,
            //    Tags = null
            //};
            ////4.注册服务
            //consulClient.Agent.ServiceRegister(registration).Wait();

            //Console.WriteLine("consul注册成功"); 
            #endregion

            app.UseConsulRegistry();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

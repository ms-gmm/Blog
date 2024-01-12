using Blog.Api.Migrations;
using Blog.Api.Repository;
using Blog.Application.AutoMapper;
using Consul;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Prometheus;
using System;
using System.Threading.Channels;


namespace Blog.Api
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
           var aa= Configuration["DbConnect"];
            services.AddDbContextPool<MyDb>(option => option.UseMySql(conn, new MariaDbServerVersion(new Version(5, 5, 68)), b => b.UseQuerySplittingBehavior(QuerySplittingBehavior.SingleQuery)));


            services.AddScoped<UserDao>();
            services.AddScoped<ArticleDao>();
            // services.AddSingleton<AutoMapperConfig>();
            services.AddAutoMapper(typeof(MyProfile));
            //services.AddAutoMapper(typeof(Blog.Application.Entity.Article).Assembly);
         
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Blog.Api", Version = "v1" });
            });

            services.AddSingleton<IConsulClient>(new ConsulClient(config =>
            {
                config.Address = new Uri("http://localhost:8500"); // Consul服务器地址
            }));

            // 注册服务到Consul
            services.AddSingleton<IHostedService, ConsulHostedService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               
            }
            
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blog.Api v1"));

            app.UseStaticFiles();
            app.UseRouting();

            app.UseMetricServer();
            app.UseHttpMetrics();
             
            // app.UseRequestMiddleware();

            app.UseAuthorization();


            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync($"这是{env.EnvironmentName}环境");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("my middleware");
            //    await next();
            //});
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("my middleware 2");
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}


using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Prometheus;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Api
{
    public class PrometheusRequestMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public PrometheusRequestMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            this._next = next;
            this._logger = loggerFactory.CreateLogger<PrometheusRequestMiddleware>();
        }
        // Name of the Response Header, Custom Headers starts with "X-"  
        //private const string RESPONSE_HEADER_RESPONSE_TIME = "X-Response-Time-ms";
        public async Task Invoke(HttpContext httpContext)
        {
            var path = httpContext.Request.Path.Value;
            var method = httpContext.Request.Method;
            //定义接口请求次数 只增不减
            var counter = Metrics.CreateCounter("prometheus_demo_request_total", "HTTP Requests Total", new CounterConfiguration
            {
                LabelNames = new[] { "path", "method", "status" }
            });

            //只统计成功的时间 （随着请求变化）
            var gauge = Metrics.CreateGauge("http_response_time", "Http Response Time ", new GaugeConfiguration
            {
                LabelNames = new[] { "path", "method" }
            });

            var statusCode = 200;
            var watch = new Stopwatch();
            //var responseTime = "0";
            watch.Start();
            httpContext.Response.OnStarting(() =>
            {
                // Stop the timer information and calculate the time   
                watch.Stop();
                //var responseTimeForCompleteRequest = watch.ElapsedMilliseconds;
                // Add the Response time information in the Response headers.   
                //responseTime = responseTimeForCompleteRequest.ToString();
                if (path != "/metrics")
                {
                    statusCode = httpContext.Response.StatusCode;
                    counter.Labels(path, method, statusCode.ToString()).Inc();
                    gauge.Labels(path, method).Inc();
                    gauge.Set(watch.ElapsedMilliseconds);
                }
                return Task.CompletedTask;
            });
            try
            {
                await _next.Invoke(httpContext);
            }
            catch (Exception)
            {
                statusCode = 500;
                counter.Labels(path, method, statusCode.ToString()).Inc();

                throw;
            }

        }
    }

    public static class RequestMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<PrometheusRequestMiddleware>();
        }
    }
}
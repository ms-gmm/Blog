using AggregateService.Models;
using Consul;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AggregateService.Services
{
    public class HttpTeamServiceClient : ITeamServiceClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public HttpTeamServiceClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<List<Team>> GetTeams()
        {
           

            //消费
            var consulCLient = new ConsulClient(cfg =>
              {
                  cfg.Address =new Uri( "http://localhost:8500");
              });
            var queryResult = await consulCLient.Catalog.Service("teamservice");

            var list = new List<string>();

            foreach (var item in queryResult.Response)
            {
                list.Add($"{item.Address};{item.ServicePort}");
            }

            //查询团队
            HttpClient httpClient = _httpClientFactory.CreateClient();
            HttpResponseMessage response = await httpClient.GetAsync($"{list[0]}/api/Team/Get");
            string json = await response.Content.ReadAsStringAsync();
            var teams = JsonConvert.DeserializeObject<List<Team>>(json);

            //查询团队成员
            foreach (var item in teams)
            {
                HttpResponseMessage response1 = await httpClient.GetAsync($"http:localhost:5000/api/User/GetByTeamId?teamId=" + item.Id);
                string json1 = await response1.Content.ReadAsStringAsync();
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json1);
                item.Users = users;
            }
            return teams;
        }
    }
}
